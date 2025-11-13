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
    internal class UsuarioDAL
    {
        public int insertar(Usuario usuario)
        {
            int result = 0;
            SqlConnection con = null;
            try
            {
                con = UConnection.getConnection();
                con.Open();
                string sql = "sp_usuario_insertar";
                SqlCommand cmd = new SqlCommand(sql, con);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add("@dni", SqlDbType.Char, 8).Value = usuario.Dni;
                cmd.Parameters.Add("@clave", SqlDbType.VarChar, 100).Value = usuario.Clave;
                cmd.Parameters.Add("@rol", SqlDbType.VarChar, 20).Value = usuario.Rol;
                cmd.Parameters.Add("@apellidos_nombres", SqlDbType.VarChar, 60).Value = usuario.ApellidosNombres;

                SqlParameter outParam = new SqlParameter("@id_usuario", SqlDbType.Int);
                outParam.Direction = ParameterDirection.Output;
                cmd.Parameters.Add(outParam);

                result = cmd.ExecuteNonQuery();
                usuario.IdUsuario = Convert.ToInt32(cmd.Parameters["@id_usuario"].Value);
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

        public bool validarUsuario(Usuario usuario)
        {
            bool resp = false;
            SqlConnection con = null;
            try
            {
                con = UConnection.getConnection();
                con.Open();
                string sql = "sp_usuario_buscar_por_dni";
                SqlCommand cmd = new SqlCommand(sql, con);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add("@dni", SqlDbType.Char, 8).Value = usuario.Dni;

                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    string claveAlmacenada = "";
                    while (reader.Read())
                    {
                        usuario.IdUsuario = reader.GetInt32(reader.GetOrdinal("id_usuario"));
                        claveAlmacenada = reader.GetString(reader.GetOrdinal("clave"));
                        usuario.Rol = reader.GetString(reader.GetOrdinal("rol"));
                        usuario.ApellidosNombres = reader.GetString(reader.GetOrdinal("apellidos_nombres"));
                    }
                    resp = usuario.Clave == claveAlmacenada;
                }
                reader.Close();
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
            return resp;
        }

    }
}
