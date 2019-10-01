using System;

namespace Godisautomaten
{
    class Program
    {
        static void Main(string[] args)
        {
            CandyMachine    candyMachine    = new CandyMachine();
            string          msgLog          = "";

            // Add candy to machine
            candyMachine.AddNewCandy(new Candy("Japp", 5));
            candyMachine.AddNewCandy(new Candy("Center", 2));
            candyMachine.AddNewCandy(new Candy("Plopp", 1));
            candyMachine.AddNewCandy(new Candy("M&M", 86));

            while (true) 
            {
                Console.Clear();
                // Print content of candy machine
                candyMachine.PrintDisplay();
                // Print nice fluff
                Console.WriteLine("---------------");
                Console.Write("Display: " + msgLog  + "\n");
                Console.WriteLine("---------------\n");
                Console.WriteLine("Vilken lucka vill du köpa från? Skriv 'q' för att avsluta");
                Console.Write(": ");
                
                // Reset msgLog for next round
                msgLog = "";
                string input = Console.ReadLine().ToLower();

                // Quit the game if "q" was pressed
                if (input[0] == 'q') { return; }

                try {
                    int convInput = Convert.ToInt32(input);

                    // Attemp to buy candy (input - 1 to compensate for application showing 1 index higher for nicer ux)
                    msgLog = candyMachine.Buy(convInput-1, 1);
                }
                catch {
                    msgLog = "Felaktig input...";
                }
            }
        }
    }
}
