using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Web;
using ADOWebForms.Entidades;

namespace ADOWebForms.ADO
{
    public class ADOEstatusAlumno : ICRUD
    {
        public static string _cnnString = ConfigurationManager.ConnectionStrings["LocalConnection"].ConnectionString;
        public static List<EstatusAlumno> _listaStatusAl = new List<EstatusAlumno>();
        public static String _query;
        public static SqlCommand _comando;
        public List<EstatusAlumno> Consultar()
        {
            _listaStatusAl = new List<EstatusAlumno>();
            _query = $"select * from EstatusAlumnos";
            using (SqlConnection con = new SqlConnection(_cnnString))
            {
                _comando = new SqlCommand(_query, con);
                _comando.CommandType = CommandType.Text;
                con.Open();
                SqlDataReader reader = _comando.ExecuteReader();
                while (reader.Read())
                {
                    _listaStatusAl.Add(
                    new EstatusAlumno()
                    {
                        id = Convert.ToInt32(reader["id"]),
                        clave = reader["Clave"].ToString(),
                        nombre = reader["Nombre"].ToString()
                    }
                );
                }
                con.Close();
            }
            return _listaStatusAl;
        }
        static EstatusAlumno _objEstatus = new EstatusAlumno();
        public EstatusAlumno Consultar(int id)
        {
            try
            {
                _listaStatusAl = new List<EstatusAlumno>();
                _query = $"select * from EstatusAlumnos where id = {id}";
                using (SqlConnection con = new SqlConnection(_cnnString))
                {
                    _comando = new SqlCommand(_query, con);
                    _comando.CommandType = CommandType.Text;
                    con.Open();
                    SqlDataReader reader = _comando.ExecuteReader();
                    while (reader.Read())
                    {
                        _objEstatus = new EstatusAlumno()
                        {
                            id = Convert.ToInt32(reader["id"]),
                            clave = reader["Clave"].ToString(),
                            nombre = reader["Nombre"].ToString()
                        };
                    }
                    con.Close();
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            return _objEstatus;
        }

        public int Agregar(EstatusAlumno estatus)
        {
            int idEstatus = 0;
            try
            {
                _query = ($"agregarEstatusAlumno");
                using (SqlConnection con = new SqlConnection(_cnnString))
                {
                    _comando = new SqlCommand(_query, con);
                    _comando.CommandType = CommandType.StoredProcedure;
                    _comando.Parameters.AddWithValue("@Clave", estatus.clave);
                    _comando.Parameters.AddWithValue("@Nombre", estatus.nombre);
                    con.Open();
                    idEstatus = (Int32)_comando.ExecuteScalar();
                    con.Close();
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            return idEstatus;
        }

        public void Actualizar(EstatusAlumno estatus)
        {
            _query = $"update EstatusAlumnos set Clave = '{estatus.clave}', Nombre = '{estatus.nombre}' where id = {estatus.id} ";
            using (SqlConnection con = new SqlConnection(_cnnString))
            {
                _comando = new SqlCommand(_query, con);
                _comando.CommandType = CommandType.Text;
                con.Open();
                _comando.ExecuteNonQuery();
                con.Close();
            }
        }
        public void Eliminar(EstatusAlumno estatus)
        {
            _query = $"delete EstatusAlumnos where id = {estatus.id}";
            using (SqlConnection con = new SqlConnection(_cnnString))
            {
                _comando = new SqlCommand(_query, con);
                _comando.CommandType = CommandType.Text;
                con.Open();
                _comando.ExecuteNonQuery();
                con.Close();
            }
        }
    }
}