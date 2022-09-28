using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ADOWebForms.ADO;
using ADOWebForms.Entidades;

namespace ADOWebForms.forms
{
    public partial class Index : System.Web.UI.Page
    {

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                List<EstatusAlumno> _listaEstatus = new List<EstatusAlumno>();
                ADOEstatusAlumno _objAdo = new ADOEstatusAlumno();
                _listaEstatus = _objAdo.Consultar();
                ddlEstatus.DataSource = _listaEstatus;
                ddlEstatus.DataValueField = "id";
                ddlEstatus.DataTextField = "nombre";
                ddlEstatus.DataBind();
            }
        }

        protected void btnAgregar_Click(object sender, EventArgs e)
        {
            //int id = int.Parse(ddlEstatus.SelectedValue);
            //Response.Redirect($"Create.aspx?id={id}");
            Response.Redirect("Create.aspx");
        }

        protected void btnEditar_Click(object sender, EventArgs e)
        {
            int id = int.Parse(ddlEstatus.SelectedValue);
            Response.Redirect($"Edit.aspx?id={id}");

        }

        protected void btnEliminar_Click(object sender, EventArgs e)
        {
            int id = int.Parse(ddlEstatus.SelectedValue);
            Response.Redirect($"Delete.aspx?id={id}");
        }

        protected void btnDetalles_Click(object sender, EventArgs e)
        {
            int id = int.Parse(ddlEstatus.SelectedValue);
            Response.Redirect($"Details.aspx?id={id}");
        }

        protected void ddlEstatus_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}