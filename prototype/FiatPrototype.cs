using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace prototype
{
    public class FiatPrototype : AutoPrototype
    {
        public override AutoPrototype Clonar()
        {
            return (FiatPrototype)this.MemberwiseClone(); //copia superficial 
        }
        public override string VerAuto()
        {
            return $"Fiat: {Modelo}, Color: {Color}";
        }
    }
}