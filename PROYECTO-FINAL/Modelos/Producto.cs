using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROYECTO_FINAL.Modelos
{

    public class Producto
    {

        public long Id { get; set; }
        public string Descripciones { get; set; }
        public double Costo { get; set; }
        public double PrecioVenta { get; set; }
        public int Stock { get; set; }
        public long IdUsuario { get; set; }

        public Producto()
        {
            Id = 0;
            Descripciones = string.Empty;
            Costo = 0;
            PrecioVenta = 0;
            Stock = 0;
            IdUsuario = 0;
        }

        public Producto(long _id, string _descripciones, double _costo, double _precioVenta, int _stock, long _idUsuario)
        {
            Id = _id;
            Descripciones = _descripciones;
            Costo = _costo;
            PrecioVenta = _precioVenta;
            Stock = _stock;
            IdUsuario = _idUsuario;
        }


    }
}
