namespace APIMaladiesCronique.Models.PatientViewModel
{
    public class Patient
    {
        public Guid Id { get; set; }
        public required string Nom { get; set; }
        public required string  Prenom { get; set; }
        public required string  Cin { get; set; }
        public DateOnly? DateNaissance { get; set; }
        public string? Adresse { get; set; }
        public string? NumeroOrder { get; set; }
        public required string Sexe { get; set; }
        public DateOnly? DateDebutMaladie { get; set; }
        public string? NumeroTelephone { get; set; }
        public int TypeDiabete { get; set; }
        
    }
}
