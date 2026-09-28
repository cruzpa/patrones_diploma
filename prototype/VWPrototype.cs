using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace prototype
{
    public class VWPrototype : AutoPrototype
    {
        public override AutoPrototype Clonar()
        {
            return (VWPrototype)this.MemberwiseClone(); //copia superficial 
        }
        public override string VerAuto()
        {
            return $"Volkswagen: {Modelo}, Color: {Color}";
        }
    }
}