using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROYECTO_FINAL
{

    public class Venta
    {
        public long Id { get; set; }
        public string Comentarios { get; set; }
        public long IdUsuario { get; set; }
        public Venta()
        {
            Id = 0;
            Comentarios = string.Empty;
            IdUsuario = 0;
        }

        public Venta(long _id, string _comentarios, long _idUsuario)
        {
            Id = _id;
            Comentarios = _comentarios;
            IdUsuario = _idUsuario;
        }


    }


}
