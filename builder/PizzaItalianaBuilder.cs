using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace builder
{
    public class PizzaItalianaBuilder : PizzaBuilder
    {
        public override Masa BuildMasa()
        {
           return new AlaPiedra();
        }
        public override Salsa BuildSalsa()
        {
            return new SalsaTomate();
        }
    }
}