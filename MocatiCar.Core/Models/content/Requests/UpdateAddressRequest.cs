﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MocatiCar.Core.Models.content.Requests
{
    public class UpdateAddressRequest
    {
        public string addressName { get; set; }
        public string locationType { get; set; }
        public string address { get; set; }
        public string province { get; set; }
        public string district { get; set; }
        public string commune { get; set; }
        public bool isDefault { get; set; }
    }
}
