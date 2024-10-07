﻿using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CapaPrensentacion
{
    public partial class Index : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Login1_Authenticate(object sender, AuthenticateEventArgs e)
        {
            string cadena = ConfigurationManager.ConnectionStrings["Cadena"].ConnectionString;
            using (SqlConnection conexion = new SqlConnection(cadena))
            {
                string consulta = "select * from TUsuario where Usuario=@usuario and Contrasena=@pass";
                SqlCommand comando = new SqlCommand(consulta, conexion);
                comando.Parameters.AddWithValue("@usuario", Login1.UserName);
                comando.Parameters.AddWithValue("@pass", Login1.Password);
                SqlDataAdapter adapter = new SqlDataAdapter(comando);
                DataTable tabla = new DataTable();
                adapter.Fill(tabla);
                DataRow fila = tabla.Rows[0];
                adapter.Fill(tabla);
                if (tabla.Rows.Count == 0)
                {
                    Login1.FailureText = "usuario no autorizado";
                }
                else
                {
                    Login1.FailureText = "usuario correcto";

                    FormsAuthentication.RedirectFromLoginPage(Login1.UserName, false);

                }
            }
        }
    }
}