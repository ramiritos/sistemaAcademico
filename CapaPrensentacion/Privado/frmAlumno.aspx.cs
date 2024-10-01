using CapaNegocio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CapaPrensentacion.Privado
{
    public partial class frmAlumno : System.Web.UI.Page
    {
        private void Listar()
        {
            Alumno asignatura = new Alumno();
            gvAsignatura.DataSource = asignatura.Listar();
            gvAsignatura.DataBind();
        }
        protected void Page_Load(object sender, EventArgs e)
        {
            //solo cargar la lista la prinera vez
            if (!Page.IsPostBack)
            {
                Listar();
            }
        }

        protected void btnAgregar_Click(object sender, EventArgs e)
        {
            Alumno alumno = new Alumno();
            alumno.CodAlumno = txtCodAlumno.Text.Trim();
            alumno.NombresAlumno = txtNombresAlumno.Text.Trim();
            alumno.APaterno = txtAPaterno.Text.Trim();
            alumno.AMaterno = txtAMaterno.Text.Trim();
            alumno.UsuarioAlumno = txtUsuarioAlumno.Text.Trim();
            alumno.CodCarrera = txtCodCarrera.Text.Trim();

            if (alumno.Agregar())
            {
                Listar();
            }
            else
            {
                Response.Write("No se agrego la asignatura");
            }
        }

        protected void btnEliminar_Click(object sender, EventArgs e)
        {

        }

        protected void btnActualizar_Click(object sender, EventArgs e)
        {

        }

        protected void btnBuscar_Click(object sender, EventArgs e)
        {

        }

        protected void txtBuscar_TextChanged(object sender, EventArgs e)
        {

        }
    }
}