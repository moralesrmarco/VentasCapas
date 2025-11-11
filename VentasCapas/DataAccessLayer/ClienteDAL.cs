using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using System.Data.SqlClient;

using VentasCapas.Entities;
using VentasCapas.Connection;

namespace VentasCapas.DataAccessLayer
{
    internal class ClienteDAL
    {

        public int insertar(Cliente cliente)
        {
            int result = 0;
            SqlConnection con = null;
            try
            {
                con = UConnection.getConnection();
                con.Open();
                string sql = "sp_cliente_insertar";
                SqlCommand cmd = new SqlCommand(sql, con);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add("@entidad", SqlDbType.VarChar, 100).Value = cliente.Entidad;
                cmd.Parameters.Add("@ruc", SqlDbType.VarChar, 11).Value = cliente.Ruc;
                cmd.Parameters.Add("@direccion", SqlDbType.VarChar, 100).Value = cliente.Direccion;
                cmd.Parameters.Add("@contacto", SqlDbType.VarChar, 50).Value = cliente.Contacto;
                cmd.Parameters.Add("@correo", SqlDbType.VarChar, 50).Value = cliente.Correo;
                cmd.Parameters.Add("@area", SqlDbType.VarChar, 50).Value = cliente.Area;
                cmd.Parameters.Add("@telefono", SqlDbType.VarChar, 15).Value = cliente.Telefono;
                cmd.Parameters.Add("@observacion", SqlDbType.VarChar, 100).Value = cliente.Observacion;
                cmd.Parameters.Add(@"ciudad", SqlDbType.VarChar, 20).Value = cliente.Ciudad;

                //cmd.Parameters.Add("@id_cliente", SqlDbType.SmallInt).Direction = ParameterDirection.Output;
                SqlParameter outParam = new SqlParameter("@id_cliente", SqlDbType.SmallInt);
                outParam.Direction = ParameterDirection.Output;
                cmd.Parameters.Add(outParam);

                result = cmd.ExecuteNonQuery();
                cliente.IdCliente = Convert.ToInt16(cmd.Parameters["@id_cliente"].Value);
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
            return result;
        }

        public int actualizar(Cliente cliente)
        {
            int result = 0;
            SqlConnection con = null;
            try
            {
                con = UConnection.getConnection();
                con.Open();
                string sql = "sp_cliente_actualizar";
                SqlCommand cmd = new SqlCommand(sql, con);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add("@entidad", SqlDbType.VarChar, 100).Value = cliente.Entidad;
                cmd.Parameters.Add("@ruc", SqlDbType.VarChar, 11).Value = cliente.Ruc;
                cmd.Parameters.Add("@direccion", SqlDbType.VarChar, 100).Value = cliente.Direccion;
                cmd.Parameters.Add("@contacto", SqlDbType.VarChar, 50).Value = cliente.Contacto;
                cmd.Parameters.Add("@correo", SqlDbType.VarChar, 50).Value = cliente.Correo;
                cmd.Parameters.Add("@area", SqlDbType.VarChar, 50).Value = cliente.Area;
                cmd.Parameters.Add("@telefono", SqlDbType.VarChar, 15).Value = cliente.Telefono;
                cmd.Parameters.Add("@observacion", SqlDbType.VarChar, 100).Value = cliente.Observacion;
                cmd.Parameters.Add(@"ciudad", SqlDbType.VarChar, 20).Value = cliente.Ciudad;

                cmd.Parameters.Add("@id_cliente", SqlDbType.SmallInt).Value = cliente.IdCliente;

                result = cmd.ExecuteNonQuery();
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
            return result;
        }

        public int eliminar(short idCliente)
        {
            int result = 0;
            SqlConnection con = null;
            try
            {
                con = UConnection.getConnection();
                con.Open();
                string sql = "sp_cliente_eliminar";
                SqlCommand cmd = new SqlCommand(sql, con);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add("@id_cliente", SqlDbType.SmallInt).Value = idCliente;

                result = cmd.ExecuteNonQuery();
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
            return result;
        }

        public List<Cliente> buscarPorEntidad(string entidad)
        {
            List<Cliente> clientes = new List<Cliente>();
            SqlConnection con = null;
            try
            {
                con = UConnection.getConnection();
                con.Open();
                string sql = "sp_cliente_buscar_por_entidad";
                SqlCommand cmd = new SqlCommand(sql, con);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add("@entidad", SqlDbType.VarChar, 100).Value = entidad;

                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        Cliente cliente = new Cliente();
                        cliente.IdCliente = reader.GetInt16(reader.GetOrdinal("id_cliente"));
                        cliente.Entidad = reader.GetString(reader.GetOrdinal("entidad"));
                        cliente.Ruc = reader.GetString(reader.GetOrdinal("ruc"));
                        clientes.Add(cliente);
                    }
                }
                reader.Close();
                return clientes;
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

        public Cliente buscarPorId(short idCliente)
        {
            Cliente cliente = new Cliente();
            SqlConnection con = null;
            try
            {
                con = UConnection.getConnection();
                con.Open();
                string sql = "sp_cliente_buscar_por_id";
                SqlCommand cmd = new SqlCommand(sql, con);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add("@id_cliente", SqlDbType.SmallInt).Value = idCliente;

                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        cliente.IdCliente = reader.GetInt16(reader.GetOrdinal("id_cliente"));
                        cliente.Entidad = reader.GetString(reader.GetOrdinal("entidad"));
                        cliente.Ruc = reader.GetString(reader.GetOrdinal("ruc"));
                        cliente.Direccion = reader.GetString(reader.GetOrdinal("direccion"));
                        cliente.Contacto = reader.GetString(reader.GetOrdinal("contacto"));
                        cliente.Correo = reader.GetString(reader.GetOrdinal("correo"));
                        cliente.Area = reader.GetString(reader.GetOrdinal("area"));
                        cliente.Telefono = reader.GetString(reader.GetOrdinal("telefono"));
                        cliente.Observacion = reader.GetString(reader.GetOrdinal("observacion"));
                        cliente.Ciudad = reader.GetString(reader.GetOrdinal("ciudad"));
                    }
                }
                reader.Close();
                return cliente;
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
