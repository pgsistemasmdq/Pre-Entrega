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
    public class ProductoVendidoHandler
    {
        public List<ProductoVendido> TraerProductoVendidos(long idUsuario)
        {

            string connectionString = "Server=PABLO-PROG\\SQLEXPRESS; Database = SistemaGestion; trusted_connection = True;";
            ProductoHandler prd = new ProductoHandler();
            List<Producto> productos = prd.TraerProducto(idUsuario);
            List<ProductoVendido> productosVendidos = new List<ProductoVendido>();
            foreach (Producto prod in productos)
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {

                    SqlDataAdapter adapter = new SqlDataAdapter("SELECT pv.id as IdProductoVendido, pv.IdProducto, pv.idVenta, pv.Stock as cantidad FROM ProductoVendido pv WHERE pv.IdProducto = @idProducto", conn);
                    adapter.SelectCommand.Parameters.Add(new SqlParameter("idProducto", SqlDbType.BigInt)).Value = prod.Id;
                    conn.Open();
                    DataTable tabla = new DataTable();
                    adapter.Fill(tabla);
                    foreach (DataRow dr in tabla.Rows)
                    {
                        ProductoVendido prdVendido = new ProductoVendido();
                        prdVendido.Id = Convert.ToInt64(dr["IdProductoVendido"]);
                        prdVendido.IdProducto = Convert.ToInt64(dr["IdProducto"]);
                        prdVendido.IdVenta = Convert.ToInt64(dr["IdVenta"]);
                        prdVendido.Stock = Convert.ToInt32(dr["cantidad"].ToString());
                        productosVendidos.Add(prdVendido);

                    }
                }
            }
            return productosVendidos;
        }
    }
}
