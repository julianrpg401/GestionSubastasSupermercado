using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionSubastasSupermercado
{
    internal class ProductoFactory
    {
        public Producto CrearProducto(string tipoProducto, string nombre, double precioInicial, string descripcion)
        {
            try
            {
                switch (tipoProducto)
                {
                    case "alimento":
                        return new ProductoAlimento(nombre, precioInicial, descripcion);
                    case "electronica":
                        return new ProductoElectronica(nombre, precioInicial, descripcion);
                    case "ropa":
                        return new ProductoRopa(nombre, precioInicial, descripcion);
                    default:
                        throw new NotImplementedException();
                }

                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            return null;
        }
    }
}
