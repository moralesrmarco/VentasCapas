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
    internal class VentaDAL
    {

        public int insertar(Venta venta)
        {
            int resp = 0;
            SqlTransaction objTransac = null;
            SqlConnection con = null;
            SqlCommand cmd1 = null;
            SqlCommand cmd2 = null;
            try
            {
                con = UConnection.getConnection();
                con.Open();
                string sql = "sp_venta_insertar";
                cmd1 = new SqlCommand(sql, con);
                cmd1.CommandType = CommandType.StoredProcedure;
                cmd1.Parameters.Add("@fecha", SqlDbType.DateTime).Value = venta.Fecha;
                cmd1.Parameters.Add("@id_cliente", SqlDbType.SmallInt).Value = venta.Cliente.IdCliente;
                SqlParameter outParam = cmd1.Parameters.Add("@id_venta", SqlDbType.Int);
                outParam.Direction = ParameterDirection.Output;

                string sql2 = "sp_venta_detalle_insertar";
                cmd2 = new SqlCommand(sql2, con);
                cmd2.CommandType = CommandType.StoredProcedure;
                cmd2.Parameters.Add(new SqlParameter("@id_venta", SqlDbType.Int));
                cmd2.Parameters.Add(new SqlParameter("@id_producto", SqlDbType.Int));
                cmd2.Parameters.Add(new SqlParameter("@cantidad", SqlDbType.Int));
                cmd2.Parameters.Add(new SqlParameter("@precio_unitario", SqlDbType.Money));

                objTransac = con.BeginTransaction();
                cmd1.Transaction = objTransac;
                cmd2.Transaction = objTransac;

                cmd1.ExecuteNonQuery();
                venta.IdVenta = Convert.ToInt32(cmd1.Parameters["@id_venta"].Value);

                foreach (VentaDetalle item in venta.VentaDetalles)
                {
                    cmd2.Parameters["@id_venta"].Value = venta.IdVenta;
                    cmd2.Parameters["@id_producto"].Value = item.Producto.IdProducto;
                    cmd2.Parameters["@cantidad"].Value = item.Cantidad;
                    cmd2.Parameters["@precio_unitario"].Value = item.PrecioUnitario;
                    cmd2.ExecuteNonQuery();
                }

                objTransac.Commit();
            }
            catch (Exception ex)
            {
                objTransac.Rollback();
                throw new Exception(ex.Message);
            }
            finally
            {
                if (con != null && con.State == ConnectionState.Open)
                {
                    con.Close();
                }
            }
            return resp;
        }
    }
}
