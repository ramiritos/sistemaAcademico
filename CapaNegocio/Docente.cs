using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace CapaNegocio
{
    public class Docente
    {

        private static string cadena = ConfigurationManager.ConnectionStrings["Cadena"].ConnectionString;

        public string codDocente { get; set; }

        public string DoAPaterno { get; set; }

        public string DoAMaterno { get; set; }

        public string DoNombre { get; set; }

        public string NomUsuario { get; set; }

        public DataTable Listar()
        {
            using (SqlConnection conexion = new SqlConnection(cadena))
            {
                string consulta = "select * from TDocente";
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
                string consulta = "Insert into TDocente values(@CodDocente,@DoAPaterno,@DoAMaterno,@DoNombres,@DoUsuario)";
                SqlCommand comando = new SqlCommand(consulta, conexion);
                comando.Parameters.AddWithValue("@CodDocente", codDocente);
                comando.Parameters.AddWithValue("@DoAPaterno", DoAPaterno);
                comando.Parameters.AddWithValue("@DoAMaterno", DoAMaterno);
                comando.Parameters.AddWithValue("@DoNombres", DoNombre);
                comando.Parameters.AddWithValue("@DoUsuario", NomUsuario);
                conexion.Open();

                byte i = Convert.ToByte(comando.ExecuteNonQuery());

                conexion.Close();

                if (i == 1)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
    
        }

        public bool Eliminar()
        {
            using (SqlConnection conexion = new SqlConnection(cadena))
            {
                string consulta = "Delete from TDocente where CodDocente = @CodDocente";
                SqlCommand comando = new SqlCommand(consulta, conexion);
                comando.Parameters.AddWithValue("@CodDocente", codDocente);
                conexion.Open();

                byte i = Convert.ToByte(comando.ExecuteNonQuery());

                conexion.Close();

                if (i == 1)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }

        public bool Actualizar()
        {
            using (SqlConnection conexion = new SqlConnection(cadena))
            {
                string consulta = "Update TDocente set APaterno=@DoAPaterno,AMaterno = @DoAMaterno,Nombres = @DoNombres, Usuario = @DoUsuario where CodDocente=@CodDocente";
                SqlCommand comando = new SqlCommand(consulta, conexion);
                comando.Parameters.AddWithValue("@DoAPaterno", DoAPaterno);
                comando.Parameters.AddWithValue("@DoAMaterno", DoAMaterno);
                comando.Parameters.AddWithValue("@DoNombres", DoNombre);
                comando.Parameters.AddWithValue("@DoUsuario", NomUsuario);
                comando.Parameters.AddWithValue("@CodDocente", codDocente);
                conexion.Open();

                byte i = Convert.ToByte(comando.ExecuteNonQuery());

                conexion.Close();

                if (i == 1)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }

        public DataTable Buscar()
        {
            using (SqlConnection conexion = new SqlConnection(cadena))
            {
                string consulta = "select * from TDocente where CodDocente=@CodDocente";
                SqlCommand comando = new SqlCommand(consulta, conexion);
                comando.Parameters.AddWithValue("@CodDocente", codDocente);
                SqlDataAdapter adapter = new SqlDataAdapter(comando);
                DataTable table = new DataTable();
                adapter.Fill(table);
                return table;
            }
        }

    }
}
