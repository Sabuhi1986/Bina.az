using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bina.az
{
    public class NewBuilding : ResidentialObject
    {
        public int CountRoom { get; set; }
        public float AreaRoom { get; set; }
        public decimal PriceNewBuild { get; set; }
        public int Floor { get; set; }
    }
}
