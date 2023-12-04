namespace APIMaladiesCronique.Models.AuthenticationViewModel
{ 
    public class Utilisateur
    {
        public Guid Id { get; set; }
        public required string Email { get; set; }
        public required string MotDePasse { get; set; }
    }
}
