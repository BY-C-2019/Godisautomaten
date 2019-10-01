using System;

namespace Godisautomaten
{
    class Candy
    {
        private string  candyName;
        public  string  CandyName { get { return candyName; } }

        private int     quantity;
        public  int     Quanity { get { return quantity; } }

        public Candy(string candyName, int quantity)
        {
            this.candyName  = candyName;
            this.quantity   = quantity;
        }

        public string RemoveQuantity(int amountToRemove)
        {
            // Decrease quantity
            quantity -= amountToRemove;

            // If quantity is lower than 0, print out of stock message and reset to 0
            if (quantity < 0) {
                quantity = 0;
                return "Godiset '" + candyName + "' är tyvärr slut.";
            }

            return "Du köpte " + amountToRemove + "st " + candyName + ", smaskens!";
        }
    }

}
