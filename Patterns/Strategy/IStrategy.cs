using System;
using System.Collections.Generic;
using System.Text;

namespace Patterns.Strategy
{
    public interface IStrategy
    {
         void RunMicroservice(String url);
    }

    public class MSColombia : IStrategy
    {
        public void RunMicroservice(string url)
        {
            Console.WriteLine(url + " MS Colombia running!");
        }
    }

    public class MSEcuador : IStrategy
    {
        public void RunMicroservice(string url)
        {
            Console.WriteLine(url + " MS Ecuador running!");
        }
    }

    public class MSChile : IStrategy
    {
        public void RunMicroservice(string url)
        {
            Console.WriteLine(url + " MS Chile running!");
        }
    }

    public enum CountryCodeEnum
    {
        Colombia = 0,
        Ecuador = 1,
        Chile = 2,
    }

    public class Main
    {
        private CountryCodeEnum _countryCode;

        public Main(CountryCodeEnum countryCode)
        {
            _countryCode = countryCode;
        }

        public void RunMS()
        {
            IStrategy strategy;

            switch (_countryCode)
            {
                case CountryCodeEnum.Colombia:
                    strategy = new MSColombia();
                    strategy.RunMicroservice("localhost:3000");
                    break;

                case CountryCodeEnum.Ecuador:
                    strategy = new MSEcuador();
                    strategy.RunMicroservice("localhost:4000");
                    break;

                case CountryCodeEnum.Chile:
                    strategy = new MSChile();
                    strategy.RunMicroservice("localhost:5000");
                    break;
            }
        }
    }
}
