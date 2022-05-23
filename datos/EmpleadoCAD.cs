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
    class EmpleadoCAD
    {
        public static DataTable listar()
        {
            try
            {
                Conexion con = new Conexion();
                string sql = "select * from EMPLEADO";
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

        public static bool guardar(Empleado e)
        {
            try
            {
                Conexion con = new Conexion();
                string sql = "insert into EMPLEADO values('" + e.IdEmpleado1 + "','" + e.NomEmpleado1 + "','" + e.ApellidoEmpleado1 + "','" + e.FuncionEmpleado1 + "','" + e.DirEmpleado1 + "','" + e.DNIEmpleado1 + "','" + e.EdadEmpleado1 + "','" + e.FechaEmpleado1 + "')";
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

        public static Empleado consultar(string IdEmpleado)
        {
            try
            {
                Conexion con = new Conexion();
                string sql = "select * from EMPLEADO where IdEmpleado='" + IdEmpleado + "';";
                SqlCommand comando = new SqlCommand(sql, con.conectar());
                SqlDataReader dr = comando.ExecuteReader();

                Empleado em = new Empleado();

                if (dr.Read())
                {
                    em.IdEmpleado1 = dr["IdEmpleado"].ToString();
                    em.NomEmpleado1 = dr["NomEmpleado"].ToString();
                    em.ApellidoEmpleado1 = dr["ApellidoEmpleado"].ToString();
                    em.FuncionEmpleado1 = dr["FuncionEmpleado"].ToString();
                    em.DirEmpleado1 = dr["DirEmpleado"].ToString();
                    em.DNIEmpleado1 = Convert.ToInt32(dr["DNIEmpleado"].ToString());
                    em.EdadEmpleado1 = Convert.ToInt32(dr["EdadEmpleado"].ToString());
                    em.FechaEmpleado1 = dr["FechaEmpleado"].ToString();
                    return em;
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

        public static bool actualizar(Empleado e)
        {
            try
            {
                Conexion con = new Conexion();
                string sql = "update EMPLEADO set NomEmpleado='" + e.NomEmpleado1 + "',ApellidoEmpleado='" + e.ApellidoEmpleado1 + "',FuncionEmpleado='" + e.FuncionEmpleado1 + "',DirEmpleado='" + e.DirEmpleado1 + "',DNIEmpleado='" + e.DNIEmpleado1 + "',EdadEmpleado='" + e.EdadEmpleado1 + "',FechaEmpleado='" + e.FechaEmpleado1 + "' where IdEmpleado='" + e.IdEmpleado1 + "'";
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

        public static bool eliminar(string IdEmpleado)
        {
            try
            {
                Conexion con = new Conexion();
                string sql = "delete from EMPLEADO where IdEmpleado='" + IdEmpleado + "'";
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
