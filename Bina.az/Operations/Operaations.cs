using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bina.az.Operations
{
    public class Operaations
    {
        public static List<Garden> Gardens { get; set; }
        public static List<House> Houses { get; set; }
        public static List<NewBuilding> NewBuildings { get; set; }
        public static List<OldBuilding> OldBuildings { get; set; }
        public static List<ResidentialObject> ResidentialObjects { get; set; }
        public static List<Villa> Villas { get; set; }
        static Operaations()
        {
            Gardens = new List<Garden>();
            Houses = new List<House>();
            NewBuildings = new List<NewBuilding>();
            OldBuildings = new List<OldBuilding>();
            ResidentialObjects = new List<ResidentialObject>();
            Villas = new List<Villa>();
        }
        
    }
}
