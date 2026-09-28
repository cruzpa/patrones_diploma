using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace builder
{
    public abstract class PizzaBuilder
    {
        public abstract Masa BuildMasa();
        public abstract Salsa BuildSalsa();

        public Pizza BuildPizza()
        {
            Masa masa = BuildMasa();
            Salsa salsa = BuildSalsa();
            return new Pizza
            {
                Masa = masa,
                Salsa = salsa,
                Agregados = new List<Agregado>(),
                Tipo = this.GetType().Name
            };
        }
    }
}