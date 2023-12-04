using System.ComponentModel.DataAnnotations;

namespace APIMaladiesCronique.Models.ConsultationViewModel
{
    public class Consultation
    {
        public Guid Id { get; set; }
        public  DateTime DateConsultation { get; set; }
        [MaxLength(4000)]
        public string? Description { get; set; }
    }
}
