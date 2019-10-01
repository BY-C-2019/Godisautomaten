using System;
using System.Collections.Generic;


namespace Godisautomaten
{
    class CandyMachine
    {
        List<Candy> candies             = new List<Candy>();

        public void AddNewCandy(Candy newCandy)
        {
            candies.Add(newCandy);
        }

        public string Buy(int index, int quantity)
        {
            // If index is out of bounds of list, ignore purchase
            if (index < 0 || index >= candies.Count) {
                return "Här var det tomt...";
            }

            // Try to remove quantity of candy. Returns eventual errors
            return candies[index].RemoveQuantity(quantity);
        }

        public void PrintDisplay()
        {
            if (candies.Count == 0) {
                Console.WriteLine("TOMT!\nSelecta har inte fyllt på maskinen idag. Sorry... ");
            }
            for (int i = 0; i < candies.Count; i++)
            {
                // Print items in machine. (i+1) for better ux
                Console.WriteLine("LUCKA {0}: {1} - {2}st", i+1, candies[i].CandyName, candies[i].Quanity);
            }
        }

    }
}