using System;
using System.Collections.Generic;
using System.Text;

namespace Patterns.Singleton
{
    public class MySingleton
    {
        private static MySingleton _instance = null;
        
        public static MySingleton Instance
        {
            get {
                if(_instance == null)
                {
                    _instance = new MySingleton();
                }
                return _instance;
            }
        }

        public void GetData()
        {
            Console.WriteLine("Hello world!");
        }

    }
}
