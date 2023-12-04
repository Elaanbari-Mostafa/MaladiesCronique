using APIMaladiesCronique.Dtos.AuthenticationDto;
using APIMaladiesCronique.Models.AuthenticationViewModel;
using Microsoft.OpenApi.Any;

namespace APIMaladiesCronique.Services.HabilitationService.Interfaces
{
    public interface IUtilisateurService
    {
        Task<string> LoginByEmailAndPassword(LoginUtilisateurDto utilisateurDto);
        Task<Utilisateur> AddUtilisateur(LoginUtilisateurDto addUtilisateurDto);
    }
}
