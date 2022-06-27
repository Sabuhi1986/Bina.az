using Bina.az.Operations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bina.az.MenecmentSystem
{
    public class HouseManager
    {
        public static void AddHouse()

        {
            House house = new House();
            Console.WriteLine("Evin unvanini daxil edin");
            house.Adress = Console.ReadLine();
            Console.WriteLine("Evin Otaq sayini daxil edin");
            house.CountRoom = int.Parse(Console.ReadLine());
            Console.WriteLine("Evin sahesini daxil edin");
            house.AreaRoom = float.Parse(Console.ReadLine());

            Operaations.Houses.Add(house);
        }

        public static void ShowHouse()
        {

            foreach (var item in Operaations.Houses)
            {
                Console.WriteLine($"Evinunvani {item.Adress}, Evin sahesi {item.AreaRoom}, Evin otaqlarinin sayi {item.CountRoom}");
            }

        }
    }
}