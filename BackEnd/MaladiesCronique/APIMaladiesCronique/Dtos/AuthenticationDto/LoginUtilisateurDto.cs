namespace APIMaladiesCronique.Dtos.AuthenticationDto
{ 
    public class LoginUtilisateurDto
    {
        public required string Email { get; set; }
        public required string MotDePasse { get; set; }
    }
}
