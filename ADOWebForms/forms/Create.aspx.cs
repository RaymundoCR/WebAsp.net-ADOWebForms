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
    public partial class Create : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnGuardarAgregar_Click(object sender, EventArgs e)
        {
            EstatusAlumno estatus = new EstatusAlumno();
            estatus.nombre = txtNombre.Text;
            estatus.clave = txtClave.Text;

            ADOEstatusAlumno objAdo = new ADOEstatusAlumno();
            objAdo.Agregar(estatus);
            Response.Redirect("Index.aspx");
        }
    }
}