using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.Reflection;
using PROYECTO_FINAL.Modelos;

namespace PROYECTO_FINAL.Handlers
{
    public class ProductoHandler
    {
        public List<Producto> TraerProducto(long idUsuario)
        {
            List<Producto> productos = new List<Producto>();

            string connectionString = "Server=PABLO-PROG\\SQLEXPRESS; Database = SistemaGestion; trusted_connection = True;";
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                SqlDataAdapter adapter = new SqlDataAdapter("SELECT Id, Descripciones, Costo, PrecioVenta, Stock, IdUsuario FROM Producto WHERE IdUsuario = @IdUsuario", conn);
                adapter.SelectCommand.Parameters.Add(new SqlParameter("IdUsuario", SqlDbType.BigInt)).Value = idUsuario;
                conn.Open();
                DataTable tabla = new DataTable();
                adapter.Fill(tabla);
 
                foreach (DataRow dr in tabla.Rows)
                {
                    Producto producto = new Producto();
                    producto.Id = Convert.ToInt64(dr["Id"]);
                    producto.Descripciones = dr["Descripciones"].ToString();
                    producto.Costo = Convert.ToDouble(dr["Costo"].ToString());
                    producto.PrecioVenta = Convert.ToDouble(dr["PrecioVenta"].ToString());
                    producto.Stock = Convert.ToInt32(dr["Stock"].ToString());
                    producto.IdUsuario = Convert.ToInt64(dr["IdUsuario"].ToString());
                    productos.Add(producto);
                }

                conn.Close();
            }

            return productos;
        }


    }
}

