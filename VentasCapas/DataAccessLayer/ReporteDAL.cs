using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VentasCapas.Connection;

namespace VentasCapas.DataAccessLayer
{
    internal class ReporteDAL
    {
        public VentasCapasDataSet listarClientes()
        {
            SqlConnection con = null;
            SqlDataAdapter adapter = new SqlDataAdapter();
            VentasCapasDataSet ds = new VentasCapasDataSet();
            try
            {
                con = UConnection.getConnection();
                con.Open();
                string sql = @"
                            Select id_cliente, entidad, ruc, direccion, correo, telefono
                            from cliente
                            ";
                SqlCommand cmd = new SqlCommand(sql, con);
                cmd.CommandType = CommandType.Text;

                // En otros reportes si podriamos usar parametros
                //cmd.Parameters.Add("@id_cliente", SqlDbType.SmallInt).Value = idCliente;

                adapter.SelectCommand = cmd;
                adapter.Fill(ds, "reporteClientes");
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
            return ds;
        }

        public VentasCapasDataSet reporteFactura(int idVenta)
        {
            SqlConnection con = null;
            SqlDataAdapter adapter = new SqlDataAdapter();
            VentasCapasDataSet ds = new VentasCapasDataSet();
            try
            {
                con = UConnection.getConnection();
                con.Open();
                string sql = @"
                            Select
                            venta.id_venta as id_venta,
                            case when venta.tipo_comprobante = 'F'
                            Then 'FACTURA ELECTRONICA'
                            Else 'BOLETA ELECTRONICA'
                            End As tipo_comprobante,
                            venta.tipo_comprobante + venta.serie + '-' + venta.numero as comprobante,
                            venta.fecha as fecha,
                            cliente.entidad as entidad,
                            cliente.direccion as direccion,
                            cliente.ruc as ruc,

                            venta_detalle.cantidad as cantidad,
                            producto.descripcion as producto,
                            venta_detalle.precio_unitario as precio_unitario,
                            venta_detalle.precio_unitario * venta_detalle.cantidad as valor_venta,
                            auxiliar.total as total,
                            auxiliar.total * venta.igv as igv,
                            auxiliar.total - auxiliar.total * venta.igv as subtotal
                            From venta
                            inner join cliente on venta.id_cliente = cliente.id_cliente
                            inner join venta_detalle on venta.id_venta = venta_detalle.id_venta
                            inner join producto on venta_detalle.id_producto = producto.id_producto
                            inner join (
                            select 
                            venta.id_venta as id_venta, 
                            isnull(sum(venta_detalle.precio_unitario*venta_detalle.cantidad), 0) as total
                            From 
                            venta 
                            inner join venta_detalle on venta.id_venta = venta_detalle.id_venta
                            Where
                            venta.id_venta = @idVenta
                            group by
                            venta.id_venta
                            ) as auxiliar
                            on venta.id_venta = auxiliar.id_venta

                            where venta.id_venta = @idVenta
                            ";
                SqlCommand cmd = new SqlCommand(sql, con);
                cmd.CommandType = CommandType.Text;

                cmd.Parameters.Add("@idVenta", SqlDbType.Int).Value = idVenta;

                adapter.SelectCommand = cmd;
                adapter.Fill(ds, "reporteFactura");
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
            return ds;
        }

    }
}
