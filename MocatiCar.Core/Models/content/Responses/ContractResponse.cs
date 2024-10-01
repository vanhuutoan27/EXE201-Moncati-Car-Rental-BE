namespace MocatiCar.Core.Models.content.Responses
{
    public class ContractResponse
    {
        public Guid ContactId { get; set; }
        public Guid RentalId { get; set; }
       
        public string? Signature { get; set; }
        public string? ContractTerms { get; set; }
        public string? Attachment { get; set; }

    }
}
