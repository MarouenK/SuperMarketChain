using System;

namespace SuperMarketChain
{
    class Program
    {
        static void Main(string[] args)
        {
            Basket myBasket = Basket.Instance;
            Apple apple = new Apple();
            Watermelon watermelon = new Watermelon();
            Orange orange = new Orange();

            for (int i = 0; i < 4; i++)
            {
                apple.AddToBasket();
            }

            for (int i = 0; i < 3; i++)
            {
                orange.AddToBasket();
            }

            for (int i = 0; i < 5; i++)
            {
                watermelon.AddToBasket();
            }

            Console.WriteLine("Basket Fruits :");
            foreach (var fruit in myBasket.ListFruits)
            {
                Console.WriteLine("Fruit [{0}] Price [{1}]", fruit.Type, fruit.Price);
            }

            Console.WriteLine("Basket Price [{0}]", Basket.Instance.BasketPrice);

            Console.ReadKey();
        }
    }
}
