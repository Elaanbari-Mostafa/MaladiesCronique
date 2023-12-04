using APIMaladiesCronique.Data;
using APIMaladiesCronique.Dtos.AuthenticationDto;
using APIMaladiesCronique.Dtos.HabilitationDto;
using APIMaladiesCronique.Models.AuthenticationViewModel;
using APIMaladiesCronique.Services.HabilitationService.Interfaces;
using Microsoft.AspNetCore.DataProtection;
using Microsoft.EntityFrameworkCore;
using APIMaladiesCronique.Tools;

namespace APIMaladiesCronique.Services.HabilitationService.Classes
{
    public class UtilisateurService: IUtilisateurService
    {
        private readonly MaladiesCroniqueDbContext _context;
        private readonly IDataProtector _dataProtector;
        private readonly IConfiguration _config;

        public UtilisateurService(MaladiesCroniqueDbContext context,IDataProtectionProvider dataProvider,IConfiguration configuration)
        {
            this._context = context;
            this._config = configuration;
            this._dataProtector = dataProvider.CreateProtector(_config["Protector:purpose"]);
        }

        public async Task<string> LoginByEmailAndPassword(LoginUtilisateurDto loginUtilisateurDto)
        {
            var utilisateur = await _context.Utilisateurs.FirstOrDefaultAsync((u) => u.Email == loginUtilisateurDto.Email);

            if (utilisateur is null) return null;

            if (!(_dataProtector.Unprotect(utilisateur.MotDePasse) == loginUtilisateurDto.MotDePasse)) return null;

            var Autorisations = _context.AutorisationMenuUtilisateurs
                               .Include(r => r.Menu)
                               .Where(r => r.UtilisateurId == utilisateur.Id)
                               .ToList();

            List<HabilitationMenuDto> autorisationList = new();
            Autorisations.ForEach((auto) =>
            {
                autorisationList.Add(new HabilitationMenuDto()
                {
                    MenuId = auto.Menu.Id,
                    Description = auto.Menu.Description,
                    NomDuMenu = auto.Menu.NomDuMenu,
                });
            });

            UtilisateurDto utilisateurDto = new() { Email = utilisateur.Email, Id = utilisateur.Id };

            UtilisateurHabilitationMenu utilisateurHabilitation = new()
            {
                UtilisateurDto = utilisateurDto,
                Autorisations = autorisationList
            };
            
            return GenerateJwtToken(josnData: utilisateurHabilitation, expiresDate: new DateTime().AddHours(8));
            //return utilisateurHabilitation;

        }

        public async Task<Utilisateur> AddUtilisateur(LoginUtilisateurDto addUtilisateurDto)
        {
            Utilisateur utilisateur = new () { Email = addUtilisateurDto.Email, MotDePasse = this._dataProtector.Protect(addUtilisateurDto.MotDePasse) };
            await _context.Utilisateurs.AddAsync(utilisateur);
            await _context.SaveChangesAsync();
            return utilisateur;
        }




    }
}
