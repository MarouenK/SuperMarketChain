using System;
using System.Collections.Generic;
using System.Text;

namespace SuperMarketChain
{
    /// <summary>
    /// Singleton class that represent the basket to be containing the fruits
    /// </summary>
    /// <param name="ListFruits">List that contains the fruits and their unit price</param>
    /// <param name="BasketPrice">Price of the entire Basket with the discounts</param>
    public sealed class Basket
    {
        private static readonly Basket instance = new Basket();
        public List<Fruit> ListFruits;
        public double BasketPrice;

        static Basket()
        {
            
        }

        private Basket()
        {
            ListFruits = new List<Fruit>();
        }

        public static Basket Instance
        {
            get
            {
                return instance;
            }
        }

        /// <summary>
        /// Method to Add Fruit and add its price to the basket price
        /// </summary>
        public void AddFruit(Fruit fruit)
        {
            ListFruits.Add(fruit);
            BasketPrice += fruit.Price;
        }

        /// <summary>
        /// Method to apply the discount price on the basket (depending on the fruit)
        /// </summary>
        public void RemovePrice(double price)
        {
            BasketPrice -= price;
        }

    }
}
