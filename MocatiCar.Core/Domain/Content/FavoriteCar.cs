using MocatiCar.Core.Domain.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MocatiCar.Core.Domain.Content
{
    public class FavoriteCar
    {
        [Key]
        public Guid FavoriteCarId { get; set; }
        public Guid? CarId { get; set; }
        [ForeignKey(nameof(CarId))]
        public Car Car { get; set; }
        public Guid? UserId { get; set; }

        [ForeignKey(nameof(UserId))]
        public AppUser User { get; set; }
       
    }
}
