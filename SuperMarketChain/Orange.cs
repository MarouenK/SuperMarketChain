using System;
using System.Collections.Generic;
using System.Text;

namespace SuperMarketChain
{
    public class Orange : Fruit
    {
        public Orange() : base("Orange")
        {
            Price = 0.50;
        }

        /// <summary>
        /// Method to add orange to basket applying its specific discount on the basket
        /// </summary>
        public override void AddToBasket()
        {
            Basket.Instance.AddFruit(this);
        }
    }
}
