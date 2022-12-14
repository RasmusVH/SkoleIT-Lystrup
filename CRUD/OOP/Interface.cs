using System;
using System.Collections.Generic;
using System.Text;

namespace CRUD.OOP
{
    class Interface
    {
        static Controller MinController = new Controller();
        static bool Slut = false;
        static Computer MinComputer = new Computer();

        public static void UI()
        {
            ConsoleKeyInfo valg;
            do
            {
                Console.Clear();
                Console.WriteLine("(1) - Tilføj en Computer");
                Console.WriteLine("(2) - Slet en Computer");
                Console.WriteLine("(3) - Rediger en Computer");
                Console.WriteLine("(4) - Se liste af Computere");
                Console.WriteLine("(5) - Luk Programmet");

                valg = Console.ReadKey(true);

                switch (valg.Key)

                {
                    case ConsoleKey.D1:
                        Console.Clear();
                        Console.WriteLine("DU har valgt at oprette en computer.");
                        Console.WriteLine("Skriv Brand Først og Derefter Model");

                        string PCBrand = Console.ReadLine();

                        string PCModel = Console.ReadLine();

                        MinController.create(PCBrand, PCModel);
                        Console.WriteLine("Du har tilføjet computeren!");
                        Console.ReadKey(true);
                        break;


                    case ConsoleKey.D2:
                        Console.Clear();
                        Console.WriteLine("Du har valgt at slette en PC");
                        Console.WriteLine("Skriv ID");

                        string PCDelete = Console.ReadLine();
                        long PCDelete1 = Convert.ToInt64(PCDelete);

                        MinController.Delete(PCDelete1);
                        Console.ReadKey(true);
                        break;

                    case ConsoleKey.D3:

                        Console.Clear();
                        Console.WriteLine("Her er listen af de computere du har på lager");

                        foreach (var item in MinController.getAll())
                        {
                            Console.WriteLine("ID: " + item.ID);
                        }

                        Console.WriteLine("Hvilken PC vil du slette? (Skriv ID)");

                        long RedigerID = long.Parse(Console.ReadLine());

                        Console.WriteLine("Det nye brand?");
                        string NewBrand = Console.ReadLine();
                        Console.WriteLine("Den nye model?");
                        string NewModel = Console.ReadLine();

                        MinController.update(RedigerID, NewBrand, NewModel);
                        Console.WriteLine("Du har nu opdateret listen med de forskellige computere");
                        Console.ReadKey(true);
                        break;

                    case ConsoleKey.D4:
                        Console.Clear();
                        Console.WriteLine("Her er listen af alle de computere som vi har på vores lager");
                        foreach (var item in MinController.getAll())
                        {
                            Console.WriteLine("ID: " + item.ID + " Brand: " + item.Brand + " Model: " + item.Model);
                        }
                        Console.ReadKey(true);
                        break;

                    case ConsoleKey.D5:
                        Slut = true;

                        break;

                    default:
                        break;
                }


            } while (!Slut);

        }
    }
}
        
    

