using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MocatiCar.Core.Models.content.Requests
{
    public class CreateUpdateCarTypeRequest
    {
        public string TypeName { get; set; }
        public string Description { get; set; }
       
    }
}
