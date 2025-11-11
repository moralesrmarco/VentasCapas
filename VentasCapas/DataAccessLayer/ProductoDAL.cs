using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VentasCapas.Connection;
using VentasCapas.Entities;

namespace VentasCapas.DataAccessLayer
{
    internal class ProductoDAL
    {
        public List<Producto> buscarPorDescripcion(string descripcion)
        {
            List<Producto> productos = new List<Producto>();
            SqlConnection con = null;
            try
            {
                con = UConnection.getConnection();
                con.Open();
                string sql = "sp_producto_buscar_por_descripcion";
                SqlCommand cmd = new SqlCommand(sql, con);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add("@cadena", SqlDbType.VarChar, 100).Value = descripcion;

                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        Producto producto = new Producto();
                        producto.IdProducto = reader.GetInt32(reader.GetOrdinal("id_producto"));
                        producto.Descripcion = reader.GetString(reader.GetOrdinal("descripcion"));
                        producto.PrecioUnitario = reader.GetDecimal(reader.GetOrdinal("precio_unitario"));
                        productos.Add(producto);
                    }
                }
                reader.Close();
                return productos;
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                if (con != null && con.State == ConnectionState.Open)
                {
                    con.Close();
                }
            }
        }
    }
}
