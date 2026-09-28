using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace builder
{
    public abstract class Salsa
    {
        public string Descripcion { get; set; }
    }

    public class SalsaTomate : Salsa
    {
        public SalsaTomate()
        {
            Descripcion = "Salsa de tomate";
        }
    }

    public class SalsaCrema : Salsa
    {
        public SalsaCrema()
        {
            Descripcion = "Salsa de crema";
        }
    }
}