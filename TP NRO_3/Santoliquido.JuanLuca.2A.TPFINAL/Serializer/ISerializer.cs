using System;
using System.Collections.Generic;
using System.Text;

namespace Serializer
{
        interface ISerializer<T>
        {
            bool Guardar(string path, T datos);

            bool Leer(string path, out T datos);
        }
    
}
