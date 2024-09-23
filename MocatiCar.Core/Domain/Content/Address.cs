using MocatiCar.Core.Domain.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MocatiCar.Core.Domain.Content
{
    public class Address
    {
        public Guid addressId { get; set; }
        public string addressName { get; set; }
        public string locationType { get; set; }
        public string address { get; set; }
        public string province { get; set; }
        public string district { get; set; }
        public string commune { get; set; }
        public bool isDefault { get; set; }
        public DateTime createdAt { get; set; }
        public DateTime updateAt { get; set; }
        public Guid UserId { get; set; }
        [ForeignKey(nameof(UserId))]
        public AppUser User { get; set; }
    }
}
