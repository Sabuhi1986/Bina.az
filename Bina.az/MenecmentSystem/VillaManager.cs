using Bina.az.Operations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bina.az.MenecmentSystem
{
    public class VillaManager
    {
        public static void AddVilla()
        {
            
                Villa villa = new Villa();
                Console.WriteLine("Evin unvanini daxil edin");
                villa.Adress = Console.ReadLine();
                Console.WriteLine("Evin Otaq sayini daxil edin");
                villa.CountRoom = int.Parse(Console.ReadLine());
                Console.WriteLine("Evin sahesini daxil edin");
                villa.AreaRoom = float.Parse(Console.ReadLine());

                Operaations.Villas.Add(villa);
            }

            public static void ShowVilla()
            {

                foreach (var item in Operaations.Villas)
                {
                Console.WriteLine($"Villanin unvani {item.Adress}, Villanin sahesi {item.AreaRoom}, Villanin otaqlarinin sayi {item.CountRoom}");
                }

            }
        }
    } 