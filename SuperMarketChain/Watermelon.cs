using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SuperMarketChain
{
    public class Watermelon : Fruit
    {
        public Watermelon() : base("Watermelon")
        {
            Price = 0.80;
        }

        /// <summary>
        /// Method to add watermelon to basket applying its specific discount on the basket
        /// </summary>
        public override void AddToBasket()
        {
            Basket.Instance.AddFruit(this);

            if (Basket.Instance.ListFruits.Count(f => f.Type.Equals("Watermelon")) % 3 == 0)
            {
                Basket.Instance.RemovePrice(this.Price);
            }
        }
    }
}
