using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionSubastasSupermercado
{
    internal interface ISubastaStrategy
    {
        void GestionarOferta(Producto producto, double oferta);
    }
}
