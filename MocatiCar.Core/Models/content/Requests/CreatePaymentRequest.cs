using MocatiCar.Core.SeedWorks.Enums;

namespace MocatiCar.Core.Models.content.Requests
{
    public class CreatePaymentRequest
    {
        public Guid? RentalId { get; set; }
        public string PaymentMethod { get; set; }
        public RentalStatus? PaymentStatus { get; set; }

    }
}
