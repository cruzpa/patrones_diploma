using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace prototype
{
    public abstract class AutoPrototype
    {
        public string Modelo { get; set; }
        public string Color { get; set; }
        public abstract AutoPrototype Clonar();
        public abstract string VerAuto();
    }
}