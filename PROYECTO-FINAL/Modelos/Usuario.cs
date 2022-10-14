using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace PROYECTO_FINAL.Modelos
{
    public class Usuario
    {
        public long Id { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string NombreUsuario { get; set; }
        public string Contraseña { get; set; }
        public string Mail { get; set; }
        public Usuario()
        {
            Id = 0;
            Nombre = string.Empty;
            Apellido = string.Empty;
            NombreUsuario = string.Empty;
            Contraseña = string.Empty;
            Mail = string.Empty;
        }

        public Usuario(long _id, string _nombre, string _apellido, string _nombreUsuario, string _contraseña, string _mail)
        {
            Id = _id;
            Nombre = _nombre;
            Apellido = _apellido;
            NombreUsuario = _nombreUsuario;
            Contraseña = _contraseña;
            Mail = _mail;
        }
    }
}


