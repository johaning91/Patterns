using System;
using System.Collections.Generic;
using System.Text;

namespace Patterns.FactoryMethod
{
    public abstract class MyFactoryMethod
    {
        public abstract long Drink();
    }

    public class Wine : MyFactoryMethod
    {
        public override long Drink()
        {
            Console.WriteLine(1000);
            return 1000;
        }
    }

    public class Beer : MyFactoryMethod
    {
        public override long Drink()
        {
            Console.WriteLine(500);
            return 500;
        }
    }

    public enum DrinkType
    {
        Wine = 0,
        beer = 1,
    }

    public class WebAppFactoryMethod
    {
        public static MyFactoryMethod GetDrink(DrinkType drinkType)
        {
            switch (drinkType)
            {
                case DrinkType.Wine:
                    return new Wine();

                case DrinkType.beer:
                    return new Beer();

                default:
                    return null;
            }
        }
    }

}
