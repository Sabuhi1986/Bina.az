using Bina.az;
using Bina.az.Operations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bina.az.MenecmentSystem
{
    public class GardenManager
    {
        public static void AddGarden()
        {
            Garden garden = new Garden();
            Console.WriteLine("Bagin unvanini daxil edin");
            garden.Adress = Console.ReadLine();
            Console.WriteLine("Bagin sahesini daxil edin");
            garden.AreaRoom = float.Parse(Console.ReadLine());

            Operaations.Gardens.Add(garden);
        }

        public static void ShowGarden()
        {

            foreach (var item in Operaations.OldBuildings)
            {
                Console.WriteLine($"Bagin unvani {item.Adress}, Bagin sahesi {item.AreaRoom}, Bagin otaqlarinin sayi {item.CountRoom}");
            }
        }
    }
}








