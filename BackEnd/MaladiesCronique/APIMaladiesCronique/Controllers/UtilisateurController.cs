using APIMaladiesCronique.Data;
using APIMaladiesCronique.Dtos.AuthenticationDto;
using APIMaladiesCronique.Services.HabilitationService.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json.Linq;

namespace APIMaladiesCronique.Controllers
{
    //[Authorize]
    [ApiController]
    [Route("[controller]")]
    public class UtilisateurController : ControllerBase
    {
        private readonly MaladiesCroniqueDbContext _dbcontext;
        private readonly IUtilisateurService _utilisateurService;
       

        public UtilisateurController(MaladiesCroniqueDbContext dbcontext, IUtilisateurService utilisateurService)
        {
            this._dbcontext = dbcontext;
            this._utilisateurService = utilisateurService;
         
        }

        [HttpPost]
        public async Task<IActionResult> AddUtilisateur([FromBody] LoginUtilisateurDto addUtilisateurDto)
        {
            if (addUtilisateurDto is null) return BadRequest("Utilisateur data is not completed");

            var utilisateur =  await this._utilisateurService.AddUtilisateur(addUtilisateurDto);

            return Ok(utilisateur);
          
        }

        [HttpPost("/LoginByEmailAndPassword")]
        public async Task<ActionResult> LoginByEmailAndPassword([FromBody] LoginUtilisateurDto utilisateurDto) // return JWT token
        {
            if (utilisateurDto is null) return BadRequest("utilisateur data is not completed !!!");

            var utilisateurHabilitation =  await _utilisateurService.LoginByEmailAndPassword(utilisateurDto);

            if (utilisateurHabilitation == null) return NotFound("Utilisateur n'exist pas !!!");

            return Ok();
            //UtilisateurHabilitationMenu
            return Ok(utilisateurHabilitation);
        }

    }
        
}
