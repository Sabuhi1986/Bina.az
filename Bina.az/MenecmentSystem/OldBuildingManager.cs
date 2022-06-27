using Bina.az.Operations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bina.az.MenecmentSystem
{
    public class OldBuildingManager
    {
        public static void AddOldBuilding()
        {

            OldBuilding oldBuilding = new OldBuilding();
            Console.WriteLine("Kohne Tikilinin unvanini daxil edin");
            oldBuilding.Adress = Console.ReadLine();
            Console.WriteLine("Kohne tikilinin mertebesini daxil edin");
            oldBuilding.Floor = int.Parse(Console.ReadLine());
            Console.WriteLine("Kohne tikilinin Otaq sayini daxil edin");
            oldBuilding.CountRoom = int.Parse(Console.ReadLine());
            Console.WriteLine("Kohne tikilinin sahesini daxil edin");
            oldBuilding.AreaRoom = float.Parse(Console.ReadLine());


            Operaations.OldBuildings.Add(oldBuilding);
        }

        public static void ShowOldBuilding()
        {

            foreach (var item in Operaations.OldBuildings)
            {
                Console.WriteLine($"Menzilin unvani {item.Adress}, Menzilin mertebesi {item.Floor}, Menzilin sahesi {item.AreaRoom}, Otaqlarin sayi {item.CountRoom}");
            }

        }
    }
}
