﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bina.az.TradeFacilities
{
    public class Offices: TradeFacilities
    {
        public int CountRoom { get; set; }
        public float AreaRoom { get; set; }
        public decimal PriceOffices { get; set; }
        public string Floor { get; set; }
    }
}
