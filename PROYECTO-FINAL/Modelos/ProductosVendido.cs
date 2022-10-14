using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROYECTO_FINAL.Modelos
{
    public class ProductoVendido
    {

        public long Id { get; set; }
        public int Stock { get; set; }
        public long IdProducto { get; set; }
        public long IdVenta { get; set; }
        public ProductoVendido()
        {
            Id = 0;
            Stock = 0;
            IdProducto = 0;
            IdVenta = 0;
        }

        public ProductoVendido(long _id, int _stock, long _idProducto, long _idVenta)
        {
            Id = _id;
            Stock = _stock;
            IdProducto = _idProducto;
            IdVenta = _idVenta;
        }


    }
}
