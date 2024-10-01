using CapaNegocio;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CapaPrensentacion.Privado
{
    public partial class frmAsignatura : System.Web.UI.Page
    {
        private void Listar()
        {
            Asignatura asignatura = new Asignatura();
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
            Asignatura asignatura = new Asignatura();
            asignatura.CodAsignatura = txtCodAsignatura.Text.Trim();
            asignatura.NombreAsignatura = txtAsignatura.Text.Trim();
            asignatura.CodRequisito = txtCodRequisito.Text.Trim();

            if (asignatura.Agregar())
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
            Asignatura asignatura = new Asignatura();
            asignatura.CodAsignatura = txtCodAsignatura.Text.Trim();
            if (asignatura.Eliminar())
            {
                Listar();
            }
            else
            {
                Response.Write("No se eliminó la asignatura");
            }

        }

        protected void btnActualizar_Click(object sender, EventArgs e)
        {
            Asignatura asignatura = new Asignatura();
            asignatura.CodAsignatura = txtCodAsignatura.Text.Trim();
            asignatura.NombreAsignatura = txtAsignatura.Text.Trim();
            asignatura.CodRequisito = txtCodRequisito.Text.Trim();


            if (asignatura.Actualizar())
            {
                Listar();
            }
            else
            {
                Response.Write("No se actualizó la asignatura");
            }
        }

        protected void btnBuscar_Click(object sender, EventArgs e)
        {
            string criterio = txtBuscar.Text.Trim(); // Obtener el criterio de búsqueda

            // Llamar al método Buscar
            DataTable resultado = new Asignatura().Buscar(criterio);

            if (resultado.Rows.Count > 0)
            {
                gvAsignatura.DataSource = resultado; // Asignar el DataTable al GridView
                gvAsignatura.DataBind(); // Realizar el binding
            }
            else
            {
                Response.Write("No se encontraron resultados");
                gvAsignatura.DataSource = null; // Limpiar el GridView si no hay resultados
                gvAsignatura.DataBind(); // Realizar el binding para limpiar la vista
            }
        }

        protected void txtBuscar_TextChanged(object sender, EventArgs e)
        {

        }
    }
}