using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

namespace CapaNegocio
{
    public class Alumno
    {
        private static string cadena = ConfigurationManager.ConnectionStrings["Cadena"].ConnectionString;
        // mapear las columnas de la tabla en propiedades
        public string CodAlumno { get; set; }
        public string APaterno { get; set; }
        public string AMaterno { get; set; }
        public string NombresAlumno { get; set; }
        public string UsuarioAlumno { get; set; }
        public string CodCarrera { get; set; }


        public DataTable Listar()
        {
            using (SqlConnection conexion = new SqlConnection(cadena))
            {
                string consulta = "select * from TAlumno";
                SqlDataAdapter adapter = new SqlDataAdapter(consulta, conexion);
                DataTable table = new DataTable();
                adapter.Fill(table);
                return table;
            }
        }
        public bool Agregar()
        {
            using (SqlConnection conexion = new SqlConnection(cadena))
            {
                string consulta = "insert into TAlumno values (@CodAlumno, @APaterno, @AMaterno,@NombresAlumno,@UsuarioAlumno,@CodCarrera)";
                SqlCommand comando = new SqlCommand(consulta, conexion);
                comando.Parameters.AddWithValue("@CodAlumno ", CodAlumno);
                comando.Parameters.AddWithValue("@APaterno", APaterno);
                comando.Parameters.AddWithValue("@AMaterno", AMaterno);
                comando.Parameters.AddWithValue("@NombresAlumno", NombresAlumno);
                comando.Parameters.AddWithValue("@UsuarioAlumno", UsuarioAlumno);
                comando.Parameters.AddWithValue("@CodCarrera", CodCarrera);


                conexion.Open();
                byte i = Convert.ToByte(comando.ExecuteNonQuery());
                conexion.Close();
                if (i == 1)
                {
                    return true;
                }
                else { return false; }
            }
        }
        public bool Eliminar()
        {
            using (SqlConnection conexion = new SqlConnection(cadena))
            {
                string consulta = "delete from TAlumno where CodAlumno  = @CodAlumno";
                SqlCommand comando = new SqlCommand(consulta, conexion);
                comando.Parameters.AddWithValue("@CodAlumno ", CodAlumno);
                conexion.Open();
                byte i = Convert.ToByte(comando.ExecuteNonQuery());
                conexion.Close();
                if (i == 1)
                {
                    return true;
                }
                else { return false; }
            }
        }
        public bool Actualizar()
        {
            using (SqlConnection conexion = new SqlConnection(cadena))
            {
                string consulta = "update TAlumno set Alumno = @NombresAlumno  where CodAlumno= @CodAlumno";
                SqlCommand comando = new SqlCommand(consulta, conexion);
                comando.Parameters.AddWithValue("@CodAlumno", CodAlumno);
                comando.Parameters.AddWithValue("@APaterno", APaterno);
                comando.Parameters.AddWithValue("@AMaterno", AMaterno);
                comando.Parameters.AddWithValue("@NombresAlumno", NombresAlumno);
                comando.Parameters.AddWithValue("@UsuarioAlumno", UsuarioAlumno);
                comando.Parameters.AddWithValue("@CodCarrera", CodCarrera);
                conexion.Open();
                byte i = Convert.ToByte(comando.ExecuteNonQuery());
                conexion.Close();
                if (i == 1)
                {
                    return true;
                }
                else { return false; }
            }
        }
        public DataTable Buscar(string criterio)
        {
            using (SqlConnection conexion = new SqlConnection(cadena))
            {
                string consulta = "SELECT * FROM TAlumno WHERE CodAlumno = @Criterio OR Alumno LIKE '%' + @Criterio + '%'";
                SqlCommand comando = new SqlCommand(consulta, conexion);
                comando.Parameters.AddWithValue("@Criterio", criterio);
                SqlDataAdapter adapter = new SqlDataAdapter(comando);
                DataTable table = new DataTable();
                adapter.Fill(table);
                return table;
            }
        }
    }
}
