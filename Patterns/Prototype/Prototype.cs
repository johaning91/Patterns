using System;
using System.Collections.Generic;
using System.Text;

namespace Patterns.Prototype
{
    //generar copias
    public class Prototype: ICloneable
    {
        string name { get; set; }

        public object Clone()
        {
            return this.MemberwiseClone();
        }
    }
}
