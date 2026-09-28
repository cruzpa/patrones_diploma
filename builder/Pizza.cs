using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace builder
{
    public class Pizza
    {
        public Masa Masa { get; set; }
        public Salsa Salsa { get; set; }
        public List<Agregado> Agregados { get; set; } = new List<Agregado>();
        public string Tipo { get; set; }


        public override string ToString()
        {
            var agregadosDescripcion = Agregados.Count > 0 ? string.Join(", ", Agregados.Select(a => a.Descripcion)) : "sin agregados";
            return $"Pizza {Tipo}: {Masa.Descripcion}, salsa: {Salsa.Descripcion}, agregados: {agregadosDescripcion}";
        }
    }
}