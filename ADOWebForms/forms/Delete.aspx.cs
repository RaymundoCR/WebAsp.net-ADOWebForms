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
    public partial class Delete : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            ADOEstatusAlumno objAdo = new ADOEstatusAlumno();
            int id =int.Parse(Request.QueryString["id"]);
            EstatusAlumno items = new EstatusAlumno();
            items = objAdo.Consultar(id);
            lbMId.Text = Convert.ToString(items.id);
            lbMNombre.Text = items.nombre;
            lbMClave.Text = items.clave;
        }

        protected void btnGuardarAgregar_Click(object sender, EventArgs e)
        {
            ADOEstatusAlumno objAdo = new ADOEstatusAlumno();
            EstatusAlumno estatus = new EstatusAlumno();
            int id = int.Parse(Request.QueryString["id"]);
            estatus.id = id;
            objAdo.Eliminar(estatus);
            Response.Redirect("Index.aspx");
        }
    }
}