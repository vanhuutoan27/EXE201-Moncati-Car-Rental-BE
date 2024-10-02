using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MocatiCar.Core.Models.content.Requests
{
    public class UpdateContractRequest
    {
        public string Signature { get; set; }
        public string ContractTerms { get; set; }
    }
}