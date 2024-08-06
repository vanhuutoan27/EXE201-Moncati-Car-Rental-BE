using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MocatiCar.Core.Models.content.Requests
{
    public class CreateUpdateBrandRequest
    {
        [Required]
        public string BrandName { get; set; }
        public string? Description { get; set; }
    }
}
