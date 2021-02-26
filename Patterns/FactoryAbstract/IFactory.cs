using System;
using System.Collections.Generic;
using System.Text;

namespace Patterns.FactoryAbstract
{
    public interface IFactory
    {
        FactoryData GetData(int type);
    }

    public abstract class AbstractFactory : IFactory
    {
        public abstract FactoryData GetData(int type);
    }

    public class FactoryData
    {
        private object _data;
        public object Data { get { return _data;  } }
        public FactoryData(object data)
        {
            _data = data;
        }
    }

    public enum ObjectType
    {
        Circle = 0,
        Squared = 1
    }

    public enum ColorType
    {
        Red = 0,
        Blue = 1
    }

    public class Circle
    {
        public void GetInfo()
        {
            Console.WriteLine("Circle");
        }
    }

    public class Squared
    {
        public void GetInfo()
        {
            Console.WriteLine("Squared");
        }
    }

    public class Red
    {
        public void GetInfo()
        {
            Console.WriteLine("Red");
        }
    }

    public class Blue
    {
        public void GetInfo()
        {
            Console.WriteLine("Blue");
        }
    }

    public class ObjectFactory : AbstractFactory
    {
        public override FactoryData GetData(int type)
        {
            FactoryData data = null;
            switch((ObjectType)type)
            {
                case ObjectType.Circle:
                    data = new FactoryData(new Circle());
                    break;

                case ObjectType.Squared:
                    data = new FactoryData(new Squared());
                    break;
            }
            return data;
        }
    }

    public class WebAppFactory
    {
        ObjectFactory objectFactory = new ObjectFactory();
        public WebAppFactory()
        {
            Circle circle = objectFactory.GetData((int) ObjectType.Circle).Data as Circle;
            circle.GetInfo();

            Squared squared = objectFactory.GetData((int)ObjectType.Squared).Data as Squared;
            squared.GetInfo();
        }
    }
}
