using RegistroCarpinteria.entidad;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegistroCarpinteria.datos
{
    class ClienteCAD
    {
        public static DataTable listar()
        {
            try
            {
                Conexion con = new Conexion();
                string sql = "select * from CLIENTE";
                SqlCommand comando = new SqlCommand(sql, con.conectar());
                SqlDataReader dr = comando.ExecuteReader(CommandBehavior.CloseConnection);
                DataTable dt = new DataTable();
                dt.Load(dr);

                con.desconectar();

                return dt;
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        public static bool guardar(Cliente c)
        {
            try
            {
                Conexion con = new Conexion();
                string sql = "insert into CLIENTE values('" + c.IdCliente1 + "','" + c.NomCliente1 + "','" + c.ApellidoCliente1 + "','" + c.DirCliente + "')";
                SqlCommand comando = new SqlCommand(sql, con.conectar());
                int cantidad = comando.ExecuteNonQuery();
                if (cantidad == 1)
                {
                    return true;
                }
                else return false;

                con.desconectar();
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public static Cliente consultar(string IdCliente)
        {
            try
            {
                Conexion con = new Conexion();
                string sql = "select * from CLIENTE where IdCliente='" + IdCliente + "';";
                SqlCommand comando = new SqlCommand(sql, con.conectar());
                SqlDataReader dr = comando.ExecuteReader();

                Cliente cl = new Cliente();

                if (dr.Read())
                {
                    cl.IdCliente1 = dr["IdCliente"].ToString();
                    cl.NomCliente1 = dr["NomCliente"].ToString();
                    cl.ApellidoCliente1 = dr["ApellidoCliente"].ToString();
                    cl.DirCliente = dr["dirCliente"].ToString();
                    return cl;
                }
                else
                {
                    con.desconectar();
                    return null;
                }
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        public static bool actualizar(Cliente cl)
        {
            try
            {
                Conexion con = new Conexion();
                string sql = "update CLIENTE set NomCliente='" + cl.NomCliente1 + "',ApellidoCliente='" + cl.ApellidoCliente1 + "',dirCliente='" + cl.DirCliente + "' where IdCliente='" + cl.IdCliente1 + "'";
                SqlCommand comando = new SqlCommand(sql, con.conectar());
                int cantidad = comando.ExecuteNonQuery();
                if (cantidad == 1)
                {
                    //con.desconectar();
                    return true;
                }
                else
                {
                    //con.desconectar();
                    return false;
                }
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public static bool eliminar(string IdCliente)
        {
            try
            {
                Conexion con = new Conexion();
                string sql = "delete from CLIENTE where IdCliente='" + IdCliente + "'";
                SqlCommand comando = new SqlCommand(sql, con.conectar());
                int cantidad = comando.ExecuteNonQuery();
                if (cantidad == 1)
                {
                    con.desconectar();
                    return true;
                }
                else
                {
                    con.desconectar();
                    return false;
                }
            }
            catch (Exception ex)
            {
                return false;
            }
        }
    }
}
