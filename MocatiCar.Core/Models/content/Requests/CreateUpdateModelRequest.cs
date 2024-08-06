using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MocatiCar.Core.Models.content.Requests
{
    public class CreateUpdateModelRequest
    {
        public string ModelName { get; set; }
        public string? Description { get; set; }
        public int Year { get; set; }
        public Guid BrandId { get; set; }
    }
}
