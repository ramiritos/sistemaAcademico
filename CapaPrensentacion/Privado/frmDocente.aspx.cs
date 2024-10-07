using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using CapaNegocio;

namespace CapaPrensentacion.Privado
{
    public partial class frmDocente : System.Web.UI.Page
    {

        private void Listar()
        {
            Docente docente = new Docente();
            gvDocente.DataSource = docente.Listar();
            gvDocente.DataBind();
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                Listar();
            }
        }

        protected void btnAgregar_Click(object sender, EventArgs e)
        {
            Docente docente = new Docente();
            docente.codDocente = txtCodDocente.Text.Trim();
            docente.DoAPaterno = txtDoAPaterno.Text.Trim();
            docente.DoAMaterno = txtDoAMaterno.Text.Trim();
            docente.DoNombre = txtDoNombres.Text.Trim();
            docente.NomUsuario = txtDoUsuario.Text.Trim();

            if (docente.Agregar())
            {
                Listar();
            }
            else
            {
                Response.Write("Error: no se agrego correctamente");
            }
        }

        protected void btnEliminar_Click(object sender, EventArgs e)
        {
            Docente docente = new Docente();
            docente.codDocente = txtCodDocente.Text.Trim();

            if (docente.Eliminar())
            {
                Listar();
            }
            else
            {
                Response.Write("Error: no se agrego correctamente");
            }
        }

        protected void btnActualizar_Click(object sender, EventArgs e)
        {
            Docente docente = new Docente();
            docente.codDocente = txtCodDocente.Text.Trim();
            docente.DoAPaterno = txtDoAPaterno.Text.Trim();
            docente.DoAMaterno = txtDoAMaterno.Text.Trim();
            docente.DoNombre = txtDoNombres.Text.Trim();
            docente.NomUsuario = txtDoUsuario.Text.Trim();


            if (docente.Actualizar())
            {
                Listar();
            }
            else
            {
                Response.Write("Error: no se agrego correctamente");
            }
        }

        protected void btnBuscar_Click(object sender, EventArgs e)
        {
            Docente docente = new Docente();
            docente.codDocente = txtBuscardo.Text.Trim();
            gvDocente.DataSource = docente.Buscar();
            gvDocente.DataBind();
        }

    }
}