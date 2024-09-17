using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace MocatiCar.Core.Models.content.Requests
{
    public class UpdateFavoriteCarRequest
    {
        [JsonPropertyName("car")]
        public Guid CarId { get; set; }
        
    }
}