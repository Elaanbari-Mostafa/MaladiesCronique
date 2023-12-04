namespace APIMaladiesCronique.Dtos.HabilitationDto
{
    public class HabilitationMenuDto
    {
        public Guid MenuId { get; set; }
        public string? Description { get; set; }
        public required string NomDuMenu { get; set; }
    }
}
