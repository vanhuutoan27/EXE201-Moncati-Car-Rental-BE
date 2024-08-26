namespace MocatiCar.Core.Domain.Content
{
    public class Contact
    {
        public Guid ContactId { get; set; }
        public Guid? RentalId { get; set; }
        public DateTime EffectiveDate { get; set; }
        public DateTime ExpirationDate { get; set; }
        public string Signature { get; set; }
        public string ContractTerms { get; set; }
        public DateTime? CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public Guid? CreatedBy { get; set; }
        public Guid? UpdatedBy { get; set; }
    }
}
