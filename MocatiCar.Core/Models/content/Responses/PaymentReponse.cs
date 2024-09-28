
using System.Collections.Generic;

using MocatiCar.Core.SeedWorks.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MocatiCar.Core.Models.content.Responses
{
    public class PaymentReponse
    {
        public bool Success { get; set; }
        public string PaymentMethod { get; set; }
        public string OrderDescription { get; set; }
        public string OrderId { get; set; }
        public string PaymentId { get; set; }
        public string TransactionId { get; set; }
        public string Token { get; set; }
        public string VnPayResponseCode { get; set; }
        public int AccountId { get; set; }
    //}
      //  public Guid PaymentId { get; set; }
        public Guid? RentalId { get; set; }
        //--> Reponse Rental(RentalAmount ,InsuranceAmount,InsuranceAmount,, commission DepositAmount,TotalAmount, CarId, CustomerId) --> User( fullname,ADdress,Avartar) && Cars (Cartypeid --> Cartype (id , name))
        /*
                //USER
                public string FullName { get; set; }
                public string? Address { get; set; }
                public string? Avatar { get; set; }*/
        //Rental
        public RentalResponse Rental { get; set; }
        //   public UserResponse User { get; set; }
        // public CarTypeResponse Type { get; set; }
        //Cars


   /*     // Carr type 
        public string TypeName { get; set; }*/
        //
     //   public string PaymentMethod { get; set; }
        public PaymentStatus PaymentStatus { get; set; }
        public string PaymentStatusString => PaymentStatus.ToString();

        public string Amount { get; set; }
        public DateTime? CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public Guid? CreatedBy { get; set; }
        public Guid? UpdatedBy { get; set; }
        }
    public class RentalResponse
    {
        /*   public decimal RentalAmount { get; set; }
           public decimal InsuranceAmount { get; set; }
           public decimal DepositAmount { get; set; }
           public decimal TotalAmount { get; set; }
           public decimal CommissionAmount { get; set; }*/
        public decimal TotalAmount { get; set; }
        public Guid CarId { get; set; }
        public Guid CarTypeId { get; set; }
    /*    public CarTypeResponses CarType { get; set; }*/

        public string CustomerId { get; set; }
        /*public UserResponse User { get; set; }*/
    }

  /*  public class UserResponse
    {
        public string FullName { get; set; }
        public string? Address { get; set; }
        public string? Avatar { get; set; }
    }
*/
   /* public class CarTypeResponses
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
    }*/

}