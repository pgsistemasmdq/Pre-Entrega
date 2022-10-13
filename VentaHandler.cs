using PROYECTO_FINAL;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROYECTO_FINAL
{
    public class VentaHandler
    {


        public List<Venta> TraerVentas(long IdUsuario)
        {

            List<Venta> ventas = new List<Venta>();

            string connectionString = "Server=PABLO-PROG\\SQLEXPRESS; Database = SistemaGestion; trusted_connection = True;";
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                SqlDataAdapter adapter = new SqlDataAdapter("SELECT Id, comentarios, IdUsuario From venta where IdUsuario = @IdUsuario", conn);
                adapter.SelectCommand.Parameters.Add(new SqlParameter("IdUsuario", SqlDbType.BigInt)).Value = IdUsuario;
                conn.Open();
                DataTable tabla = new DataTable();
                adapter.Fill(tabla);
                //for (int i = 0 ; i < tabla.Rows.Count;i++)
                //    //DataRow dr = tabla.Rows[i];

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


