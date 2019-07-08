using NUnit.Framework;
using SuperMarketChain;

namespace Tests
{
    public class Tests
    {
        const double Delta = 0.000001;
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void AddFruitToBasketTestMethod()
        {
            Basket myBasket = Basket.Instance;
            myBasket.BasketPrice = 0;
            myBasket.ListFruits.Clear();

            Fruit fruit = new Orange();

            for (int i = 0; i < 5; i++)
            {
                myBasket.AddFruit(fruit);
                Assert.AreEqual(i+1, myBasket.ListFruits.Count);
            }

        }

        [TestCase(0)]
        [TestCase(1)]
        [TestCase(10)]
        public void RemovePriceFromBasketTestMethod(double price)
        {
            Basket myBasket = Basket.Instance;
            myBasket.BasketPrice = 100;
            myBasket.ListFruits.Clear();

            Fruit fruit = new Orange();

            myBasket.RemovePrice(price);

            Assert.AreEqual(100-price, myBasket.BasketPrice, Delta);
        }

        [Test]
        public void AddAppleToBasketTestMethod()
        {
            Basket myBasket = Basket.Instance;
            myBasket.BasketPrice = 0;
            myBasket.ListFruits.Clear();

            Apple apple = new Apple();

            apple.AddToBasket();
            Assert.AreEqual(apple.Price, myBasket.BasketPrice, Delta);

            apple.AddToBasket();
            Assert.AreEqual(apple.Price, myBasket.BasketPrice, Delta);

            apple.AddToBasket();
            Assert.AreEqual(2*apple.Price, myBasket.BasketPrice, Delta);

            apple.AddToBasket();
            Assert.AreEqual(2 * apple.Price, myBasket.BasketPrice, Delta);
        }
        
        [Test]
        public void AddOrangeToBasketTestMethod()
        {
            Basket myBasket = Basket.Instance;
            myBasket.BasketPrice = 0;
            myBasket.ListFruits.Clear();

            Orange orange = new Orange();

            orange.AddToBasket();
            Assert.AreEqual(orange.Price, myBasket.BasketPrice, Delta);

            orange.AddToBasket();
            Assert.AreEqual(2 * orange.Price, myBasket.BasketPrice, Delta);

            orange.AddToBasket();
            Assert.AreEqual(3 * orange.Price, myBasket.BasketPrice, Delta);

            orange.AddToBasket();
            Assert.AreEqual(4 * orange.Price, myBasket.BasketPrice, Delta);
        }

        [Test]
        public void AddWatermelonToBasketTestMethod()
        {
            Basket myBasket = Basket.Instance;
            myBasket.BasketPrice = 0;
            myBasket.ListFruits.Clear();

            Watermelon watermelon = new Watermelon();

            watermelon.AddToBasket();
            Assert.AreEqual(watermelon.Price, myBasket.BasketPrice, Delta);

            watermelon.AddToBasket();
            Assert.AreEqual(2 * watermelon.Price, myBasket.BasketPrice, Delta);

            watermelon.AddToBasket();
            Assert.AreEqual(2 * watermelon.Price, myBasket.BasketPrice, Delta);

            watermelon.AddToBasket();
            Assert.AreEqual(3 * watermelon.Price, myBasket.BasketPrice, Delta);
        }
    }
}