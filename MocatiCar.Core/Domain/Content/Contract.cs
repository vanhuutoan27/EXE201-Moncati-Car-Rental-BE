using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MocatiCar.Core.Domain.Content
{
    public class Contract
    {
        [Key]
        public Guid ContractId { get; set; }
        public Guid RentalId { get; set; }
        public string? Signature { get; set; }
        public string? ContractTerms { get; set; }
        public string? Attachment { get; set; }
        public DateTime? CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public Guid? CreatedBy { get; set; }
        public Guid? UpdatedBy { get; set; }
        [ForeignKey(nameof(RentalId))]
        public Rental Rental { get; set; }
    }
}
