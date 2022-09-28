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
    public partial class Edit : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            txtId.Text = Request.QueryString["id"];
        }

        protected void btnGuardarAgregar_Click(object sender, EventArgs e)
        {
            ADOEstatusAlumno objAdo = new ADOEstatusAlumno();
            EstatusAlumno estatus = new EstatusAlumno();

            estatus.id = int.Parse(Request.QueryString["id"]);
            estatus.nombre = txtNombre.Text;
            estatus.clave = txtClave.Text;
            objAdo.Actualizar(estatus);
            Response.Redirect("Index.aspx");
        }
    }
}