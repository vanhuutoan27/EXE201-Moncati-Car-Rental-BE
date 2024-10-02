namespace MocatiCar.Core.Models.content.Requests
{
    public class CreateContractRequest
    {
        public Guid RentalId { get; set; }
    
        public string Signature { get; set; }
        public string ContractTerms { get; set; }
        public string Attachment { get; set; }
    }
}
