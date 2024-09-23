using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MocatiCar.Core.Models.content.Responses
{
    public class GetReviewandUserbyOwnerRespone
    {
        public string customerName { get; set; }
        public string customerAvatar { get; set; }
        public int rating { get; set; }
        public DateTime? createdAt { get; set; }
        public DateTime? updatedAt { get; set; }
    }
}