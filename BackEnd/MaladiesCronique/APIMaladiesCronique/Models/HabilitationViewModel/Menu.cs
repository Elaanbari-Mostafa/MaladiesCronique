namespace APIMaladiesCronique.Models.HabilitationViewModel
{
    public class Menu
    {
        public required Guid Id { get; set; }
        public required String NomDuMenu { get; set; }
        public string? Description { get; set; }
    }
}
