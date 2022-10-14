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
    public class VentaHandler
    {


        public List<Venta> TraerVentas(long idUsuario)
        {

            List<Venta> ventas = new List<Venta>();

            string connectionString = "Server=PABLO-PROG\\SQLEXPRESS; Database = SistemaGestion; trusted_connection = True;";
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                SqlDataAdapter adapter = new SqlDataAdapter("SELECT Id, comentarios, IdUsuario From venta where IdUsuario = @IdUsuario", conn);
                adapter.SelectCommand.Parameters.Add(new SqlParameter("IdUsuario", SqlDbType.BigInt)).Value = idUsuario;
                conn.Open();
                DataTable tabla = new DataTable();
                adapter.Fill(tabla);
                foreach (DataRow dr in tabla.Rows)
                {
                    Venta vta = new Venta();
                    vta.Id = Convert.ToInt64(dr["Id"]);
                    vta.Comentarios = dr["Comentarios"].ToString();
                    vta.IdUsuario = Convert.ToInt64(dr["IdUsuario"].ToString());
                    ventas.Add(vta);
                }

                conn.Close();
            }

            return ventas;
        }


    }
}


