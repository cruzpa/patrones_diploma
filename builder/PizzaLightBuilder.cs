using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace builder
{
    public class PizzaLightBuilder : PizzaBuilder
    {
        public override Masa BuildMasa()
        {
            return new AlMolde();
        }

        public override Salsa BuildSalsa()
        {
            return new SalsaCrema();
        }
    }
}