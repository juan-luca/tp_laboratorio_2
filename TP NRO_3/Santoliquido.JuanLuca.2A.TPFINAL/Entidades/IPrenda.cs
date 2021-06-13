using System;
using System.Collections.Generic;
using System.Text;

namespace Entidades
{
    interface IPrenda
    {
        int Id { get; set; }
        int S { get; set; }
        int M { get; set; }
        int L { get; set; }
        int XL { get; set; }
        int XXL { get; set; }

        enumPrenda Tipo { get; set; }

        enumMarca Marca { get; set; }

        string Modelo { get; set; }

        string Variante { get; set; }

    }
}
