using Bina.az.Operations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bina.az.MenecmentSystem
{
    public class NewBuildingManager
    {
        public static void AddNewBuilding()

        {
            NewBuilding newBuilding = new NewBuilding();
            Console.WriteLine("Yeni Tikilinin unvanini daxil edin");
            newBuilding.Adress = Console.ReadLine();
            Console.WriteLine("Yeni tikilinin mertebesini daxil edin");
            newBuilding.Floor = int.Parse(Console.ReadLine());
            Console.WriteLine("Yeni tikilinin Otaq sayini daxil edin");
            newBuilding.CountRoom = int.Parse(Console.ReadLine());
            Console.WriteLine("Yeni tikilinin sahesini daxil edin");
            newBuilding.AreaRoom = float.Parse(Console.ReadLine());
          

            Operaations.NewBuildings.Add(newBuilding);
        }

        public static int ShowNewBuilding()
        {

            foreach (var item in Operaations.NewBuildings)
            {
                Console.WriteLine($"Menzilin unvani {item.Adress}, Menzilin mertebesi {item.Floor}, Menzilin sahesi {item.AreaRoom}, Otaqlarin sayi {item.CountRoom}");
            }
            return Operaations.NewBuildings.Count;
          
        }
    }
}



