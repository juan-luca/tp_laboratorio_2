using System;
using Entidades;

namespace test
{
    class Program
    {
        static void Main(string[] args)
        {
            Fabrica FB = new Fabrica();
            Buzos corte1 = new Buzos(-1, 2, 2, 1, 4, 5, true, enumMarca.Adidas, "Anorak");//14
            
            Buzos corte2 = new Buzos(2, 6, 4, 2, 1, 10, false, enumMarca.Nike, "Just Do It");//23
            Joggings corte3 = new Joggings(3, 1, 2, 2, 2, 3, false, enumMarca.Nike, "Duo");//10
            Joggings corte4 = new Joggings(4, 5, 5, 5, 5, 5, false, enumMarca.Puma, "Track");//25
            Joggings corte5 = new Joggings(5, 4, 4, 4, 4, 4, true, enumMarca.Adidas, "Retro");//20

            FB += corte1;
            FB += corte2;
            FB += corte3;
            FB += corte4;
            FB += corte5;
            
            
            FB -= corte1;
            FB -= corte5;

            foreach(Buzos item in FB.Buzos)
            {
                Console.WriteLine(item.MostrarDatos());
            }
            foreach (Joggings item in FB.Joggings)
            {
                Console.WriteLine(item.MostrarDatos());
            }

            if (Fabrica.Guardar(FB))
            {
                Console.WriteLine("Exportado con exito");
            }
            FB = null;
            FB = Fabrica.Leer();
            if(FB!=null)
            {
                Console.WriteLine("Importado con exito");
            }

        }
    }
}
