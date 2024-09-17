using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace MocatiCar.Core.Models.content.Requests
{
    public class CreateFavoriteCarRequest
    {
        [JsonPropertyName("car")]
        public Guid carId {get ; set ;}
        [JsonPropertyName("user")]
        public Guid userId { get; set; }
    }
}