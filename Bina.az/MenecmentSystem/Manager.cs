using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bina.az.MenecmentSystem
{
    public class Manager<T>
    {
        public static void serviceCall()
        {

            Type newBuilding = typeof(NewBuilding);
            if (typeof(T) == newBuilding)
            {
                NewBuildingManager.AddNewBuilding();
            }

            Type oldBuilding = typeof(OldBuilding);
            if (typeof(T) == oldBuilding)
            {
                OldBuildingManager.AddOldBuilding();
            }

            Type house = typeof(House);
            if (typeof(T) == oldBuilding)
            {
                HouseManager.AddHouse();
            }
            Type garden = typeof(Garden);
            if (typeof(T) == garden)
            {
                GardenManager.AddGarden();
            }
            Type villa = typeof(Villa);
            if (typeof(T) == garden)
            {
                VillaManager.AddVilla();
            }
        }
    }
}

