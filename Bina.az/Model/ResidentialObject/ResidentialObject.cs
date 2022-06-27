using Bina.az.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bina.az
{
    public class ResidentialObject
    {
        public string ID { get; set; }
        public string  Number { get; set; }
        public string Adress { get; set; }
        public Repaired_Unrepaired RepUnrep { get; set; }
        public TypeofOperation TypeofOperation { get; set; }
        public Sell_Buytype Sell_Buytype { get; set; }
        public RentType RentType { get; set; }

    }
}
