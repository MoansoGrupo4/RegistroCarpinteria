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
    class ProveedorCAD
    {
        public static DataTable listar()
        {
            try
            {
                Conexion con = new Conexion();
                string sql = "select * from PROVEEDOR";
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

        public static bool guardar(Proveedor c)
        {
            try
            {
                Conexion con = new Conexion();
                string sql = "insert into PROVEEDOR values('" + c.CodProveedor1 + "','" + c.NomProveedor1 + "','" + c.DirProveedor1 + "','" + c.TelfProveedor1 + "')";
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

        public static Proveedor consultar(string CodProveedor)
        {
            try
            {
                Conexion con = new Conexion();
                string sql = "select * from PROVEEDOR where CodProveedor='" + CodProveedor + "';";
                SqlCommand comando = new SqlCommand(sql, con.conectar());
                SqlDataReader dr = comando.ExecuteReader();

                Proveedor cl = new Proveedor();

                if (dr.Read())
                {
                    cl.CodProveedor1 = dr["CodProveedor"].ToString();
                    cl.NomProveedor1 = dr["NomProveedor"].ToString();
                    cl.DirProveedor1 = dr["DirProveedor"].ToString();
                    cl.TelfProveedor1 = dr["TelfProveedor"].ToString();
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

        public static bool actualizar(Proveedor cl)
        {
            try
            {
                Conexion con = new Conexion();
                string sql = "update PROVEEDOR set NomProveedor='" + cl.NomProveedor1 + "',DirProveedor='" + cl.DirProveedor1 + "',TelfProveedor='" + cl.TelfProveedor1 + "' where CodProveedor='" + cl.CodProveedor1 + "'";
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

        public static bool eliminar(string CodProveedor)
        {
            try
            {
                Conexion con = new Conexion();
                string sql = "delete from PROVEEDOR where CodProveedor='" + CodProveedor + "'";
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
