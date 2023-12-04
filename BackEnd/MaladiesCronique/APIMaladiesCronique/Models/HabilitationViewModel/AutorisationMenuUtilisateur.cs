using APIMaladiesCronique.Models.AuthenticationViewModel;

namespace APIMaladiesCronique.Models.HabilitationViewModel
{
    public class AutorisationMenuUtilisateur
    {
        public required Guid Id { get; set; }
        public required Guid UtilisateurId { get; set; }
        public required Guid MenuId { get; set; }

        //Relations
        public required Menu Menu { get; set; }
        public required Utilisateur Utilisateur { get; set; }
    }
}
