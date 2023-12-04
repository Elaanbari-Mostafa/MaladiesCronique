using APIMaladiesCronique.Dtos.HabilitationDto;
using APIMaladiesCronique.Models.AuthenticationViewModel;

namespace APIMaladiesCronique.Dtos.AuthenticationDto
{
    public class UtilisateurHabilitationMenu
    {
        public required UtilisateurDto UtilisateurDto { get; set; }
        public List<HabilitationMenuDto>? Autorisations { get; set;}
    }
}
