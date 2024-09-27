using Microsoft.AspNetCore.Http;
using MocatiCar.Core.Models.content.Requests;
using MocatiCar.Core.Models.content.Responses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MocatiCar.Core.Services
{
    public interface IVnPayService
    {
        string CreatePaymentUrl(PaymentRequest model, HttpContext context);
        PaymentReponse PaymentExecute(IQueryCollection collections);
    }
}
