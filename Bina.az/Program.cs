using Bina.az.MenecmentSystem;
using System;

namespace Bina.az
{
    class Program
    {
        static void Main(string[] args)
        {
            menu();
        }
        public static void menu()
        {
            Console.WriteLine("****************BINA.AZ (Online Dasinmaz emlak bazari)*********************");
            Console.WriteLine("1.Yeni tikili elave et");
            Console.WriteLine("2.Kohne tikili  əlavə et");
            Console.WriteLine("3.Ev əlavə et");
            Console.WriteLine("4.Bag əlavə et ");
            Console.WriteLine("5.Villa əlavə et ");
            Console.WriteLine("6.Cixis");
            
            int secimetmek = int.Parse(Console.ReadLine());
            switch (secimetmek)
            {
                case 1:
                    Manager<NewBuilding>.serviceCall();
                    menu();
                    break;
                case 2:
                    Manager<OldBuilding>.serviceCall();
                    menu();
                    break;
                case 3:
                    Manager<House>.serviceCall();
                    menu();
                    break;
                case 4:
                    Manager<Garden>.serviceCall();
                    menu();
                    break;
                case 5:
                    Manager<Villa>.serviceCall();
                    menu();
                    break;
                case 6:
                    return;
                default:
                    break;
           }
        } 
        
}
}
    

