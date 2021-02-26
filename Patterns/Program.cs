using Patterns.FactoryAbstract;
using Patterns.FactoryMethod;
using Patterns.Strategy;
using Patterns.Singleton;
using Patterns.Mediator;
using System;

namespace Patterns
{
    class Program
    {
        static void Main(string[] args)
        {
            //Strategy
            Main main = new Main(CountryCodeEnum.Colombia);
            main.RunMS();

            //AbstractFactory factory
            //new WebAppFactory();

            //Factory method
            /*MyFactoryMethod fact = WebAppFactoryMethod.GetDrink(DrinkType.beer);
            fact.Drink();*/

            //Singleton
            /*MySingleton instance = MySingleton.Instance;
            instance.GetData();
            MySingleton instance2 = MySingleton.Instance;
            instance2.GetData();*/

            //Mediator
            /*MyMediator mediator = new MyMediator();
            IColleage user = new User(mediator);
            IColleage admin = new UserAdmin(mediator);

            mediator.Add(user);
            mediator.Add(admin);

            user.Comunicate("Hola");*/
        }
    }
}
