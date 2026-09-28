using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace prototype
{
    public class ChevPrototype : AutoPrototype
        {
        public override AutoPrototype Clonar()
        {
            return (ChevPrototype)this.MemberwiseClone(); //copia superficial 
        }
        public override string VerAuto()
        {
            return $"Chevrolet: {Modelo}, Color: {Color}";
        }
    }
}