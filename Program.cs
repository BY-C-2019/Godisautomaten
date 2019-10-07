using System;

namespace godisautomaten
{
    class Program
    {
        static void Main(string[] args)
        {
            int japp = 3;
            int daim = 5;
            int marabou = 5;
            int pigall = 4;
            string choice = "";

            while (true)
            {
                Console.Clear();
                // skriv ut meny
                Console.WriteLine("==== Välkommen till Godisautomaten! ====");
                Console.WriteLine("LUCKA NR [1]: Japp antal {0}st", japp);
                Console.WriteLine("LUCKA NR [2]: Daim antal {0}st", daim);
                Console.WriteLine("LUCKA NR [3]: Marabou antal {0}st", marabou);
                Console.WriteLine("LUCKA NR [4]: Pigall antal {0}st", pigall);
                Console.Write("Vilken godis vill du ha? (q för att avlusta): ");

                choice = Console.ReadLine().ToLower();

                switch (choice)
                {
                    case "1":
                        japp = GetCandy("Japp", japp);
                        break;

                    case "2":
                        daim = GetCandy("Daim", daim);
                        break;

                    case "3":
                        marabou = GetCandy("Marabou", marabou);
                        break;

                    case "4":
                        pigall = GetCandy("Pigall", pigall);
                        break;

                    case "q":
                        return;

                    default:
                        Console.WriteLine("Lågt blodsocker? Tryck på 1, 2, 3, 4 eller q...");
                        Console.ReadKey();
                        break;
                }
            }
        }

        // tom låda
        static void Empty()
        {
            Console.WriteLine("Lådan är tom :(((");
            Console.ReadKey();
        }

        // plocka ut godis
        static int GetCandy(string candy, int amount)
        {
            if (amount > 0)
            {
                Console.WriteLine("Du får en {0}, mums!", candy);
                amount--;
                Console.ReadKey();
            }
            else
            {
                Empty();
            }
            return amount;
        }
    }
}