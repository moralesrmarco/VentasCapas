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

                cmd1.Parameters.Add("@serie", SqlDbType.VarChar, 6).Value = venta.Serie;
                cmd1.Parameters.Add("@numero", SqlDbType.VarChar, 6).Value = venta.Numero;
                cmd1.Parameters.Add("@tipo_comprobante", SqlDbType.VarChar, 1).Value = venta.TipoComprobante;
                cmd1.Parameters.Add("@igv", SqlDbType.Decimal).Value = venta.Igv;

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

        public Venta generarSerieNumeroComprobante(string tipoComprobante)
        {
            Venta venta = new Venta();
            SqlConnection con = null;
            try
            {
                con = UConnection.getConnection();
                con.Open();
                string sql = "sp_venta_generar_serie_numero_comprobante";
                SqlCommand cmd = new SqlCommand(sql, con);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add("@tipo_comprobante", SqlDbType.Char, 1).Value = tipoComprobante;

                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        int serie = reader.GetInt32(reader.GetOrdinal("maximo_serie"));
                        int numero = reader.GetInt32(reader.GetOrdinal("maximo_numero"));

                        if (numero == 0)
                        {
                            serie = 1;
                            numero = 1;
                        }
                        else if (numero > 999999)
                        {
                            serie++;
                            numero = 1;
                        }
                        else
                        {
                            numero++;
                        }
                        int longitudSerie = 6;
                        int longitudNumero = 6;
                        string digitosCerosSerie = new string('0', longitudSerie - serie.ToString().Length);
                        venta.Serie = digitosCerosSerie + serie.ToString();
                        string digitosCerosNumero = new string('0', longitudNumero - numero.ToString().Length);
                        venta.Numero = digitosCerosNumero + numero.ToString();
                    }
                }
                reader.Close();
                return venta;
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
