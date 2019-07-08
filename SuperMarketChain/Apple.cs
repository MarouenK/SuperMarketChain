using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SuperMarketChain
{
    public class Apple : Fruit
    {
        public Apple() : base("Apple")
        {
            Price = 0.20;
        }

        /// <summary>
        /// Method to add apple to basket applying its specific discount on the basket
        /// </summary>
        public override void AddToBasket()
        {
            Basket.Instance.AddFruit(this);

            if (Basket.Instance.ListFruits.Count(f => f.Type.Equals("Apple")) % 2 == 0)
            {
                Basket.Instance.RemovePrice(this.Price);
            }
        }
    }
}
