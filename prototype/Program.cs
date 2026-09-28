using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prototype
{
    internal static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());

            //AutoPrototype FiatPrototype = new FiatPrototype();
            //AutoPrototype ChevPrototype = new ChevPrototype();
            //AutoPrototype VWPrototype = new VWPrototype();

            //AutoPrototype FiatUno = FiatPrototype.Clonar();
            //FiatUno.Modelo = "Fiat Uno";
            //FiatUno.Color = "Blanco";
            //Console.WriteLine(FiatUno.VerAuto());

            //AutoPrototype PalioNegro = FiatPrototype.Clonar();
            //PalioNegro.Modelo = "Palio";
            //PalioNegro.Color = "Negro";
            //Console.WriteLine(PalioNegro.VerAuto());

            //AutoPrototype CorsaGris = ChevPrototype.Clonar();
            //CorsaGris.Modelo = "Corsa";
            //CorsaGris.Color = "Gris";
            //Console.WriteLine(CorsaGris.VerAuto());

            //AutoPrototype OnyxRojo = ChevPrototype.Clonar();
            //OnyxRojo.Modelo = "Onyx";
            //OnyxRojo.Color = "Rojo";
            //Console.WriteLine(OnyxRojo.VerAuto());

            //AutoPrototype GolNegro = VWPrototype.Clonar();
            //GolNegro.Modelo = "Gol";
            //GolNegro.Color = "Negro";
            //Console.WriteLine(GolNegro.VerAuto());

            //AutoPrototype BoraGris = VWPrototype.Clonar();
            //BoraGris.Modelo = "Bora";
            //BoraGris.Color = "Gris";
            //Console.WriteLine(BoraGris.VerAuto());


        }
    }
}
