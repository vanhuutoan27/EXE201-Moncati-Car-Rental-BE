using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MocatiCar.Core.Models.content.Responses
{
    public class ReviewRespone
    {
        public Guid? ReviewId {  get; set; } 
        public Guid? CarId { get; set; }
        public Guid? Author { get; set; }
        public int Rating { get; set; }
        public string? Content { get; set; }
        public DateTime? CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public bool Flag {  get; set; }
    }
}
