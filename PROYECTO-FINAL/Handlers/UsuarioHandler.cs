using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PROYECTO_FINAL.Modelos;

namespace PROYECTO_FINAL.Handlers
{
    public class UsuarioHandler
    {
        public Usuario TraerUsuario(string nomUsuario)
        {
            Usuario usuario = new Usuario();
            string connectionString = "Server=PABLO-PROG\\SQLEXPRESS; Database = SistemaGestion; trusted_connection = True;";
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                SqlDataAdapter adapter = new SqlDataAdapter("SELECT Id ,Nombre ,Apellido ,NombreUsuario ,Contraseña ,Mail FROM Usuario WHERE NombreUsuario like @NombreUsuario", conn);
                adapter.SelectCommand.Parameters.Add(new SqlParameter("NombreUsuario", SqlDbType.VarChar)).Value = nomUsuario;
                conn.Open();
                DataTable tabla = new DataTable();
                adapter.Fill(tabla);
                if (tabla.Rows.Count > 0)
                {
                    DataRow dr = tabla.Rows[0];
                    usuario.Id = Convert.ToInt64(dr["Id"]);
                    usuario.Apellido = dr["Apellido"].ToString();
                    usuario.Nombre = dr["Nombre"].ToString();
                    usuario.NombreUsuario = dr["NombreUsuario"].ToString();
                    usuario.Contraseña = dr["Contraseña"].ToString();
                    usuario.Mail = dr["Mail"].ToString();
                }

                conn.Close();
            }
            return usuario;
        }
        public Usuario InicioSesion(string nomUsuario, string pass)
        {
            Usuario usuario = new Usuario();
            string connectionString = "Server=PABLO-PROG\\SQLEXPRESS; Database = SistemaGestion; trusted_connection = True;";
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                SqlDataAdapter adapter = new SqlDataAdapter("SELECT Id ,Nombre ,Apellido ,NombreUsuario ,Contraseña ,Mail FROM Usuario WHERE NombreUsuario like @NombreUsuario and  Contraseña like @password", conn);
                adapter.SelectCommand.Parameters.Add(new SqlParameter("NombreUsuario", SqlDbType.VarChar)).Value = nomUsuario;
                adapter.SelectCommand.Parameters.Add(new SqlParameter("password", SqlDbType.VarChar)).Value = pass;
                conn.Open();
                DataTable tabla = new DataTable();
                adapter.Fill(tabla);
                if (tabla.Rows.Count > 0)
                {
                    DataRow dr = tabla.Rows[0];
                    usuario.Id = Convert.ToInt64(dr["Id"]);
                    usuario.Apellido = dr["Apellido"].ToString();
                    usuario.Nombre = dr["Nombre"].ToString();
                    usuario.NombreUsuario = dr["NombreUsuario"].ToString();
                    usuario.Contraseña = dr["Contraseña"].ToString();
                    usuario.Mail = dr["Mail"].ToString();
                }

                conn.Close();
            }
            return usuario;

        }
    }
}
