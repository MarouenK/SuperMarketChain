using System;
using System.Collections.Generic;
using System.Text;

namespace SuperMarketChain
{
    /// <summary>
    /// Class that represent the fruit to be added in the client basket
    /// </summary>
    /// <param name="Type">type of the fruit. exp : orange, apple, watermelon</param>
    /// /// <param name="Price">the price of the fruit</param>
    public abstract class Fruit : IFruit
    {
        public string Type { get; }
        public double Price;

        protected Fruit(string type)
        {
            Type = type;
        }

        public abstract void AddToBasket();


    }
}
