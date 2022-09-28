<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Index.aspx.cs" Inherits="ADOWebForms.forms.Index" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
<div>
    <h2>IndiIndice</h2>
	<!-- Control asp Label para mensajes -->		
    <hr />
    <div>
		<!-- Par de label html - Control asp por cada propiedad -->
        <asp:DropDownList ID="ddlEstatus" runat="server" OnSelectedIndexChanged="ddlEstatus_SelectedIndexChanged"></asp:DropDownList>
    </div>
    <div>

    </div>
    <div style="display : contents; margin : 30px ">
      <asp:Button ID="btnAgregar" runat="server" Text="Agregar" OnClick="btnAgregar_Click" BackColor="#a2ffa2" />
      <asp:Button ID="btnDetalles" runat="server" Text="Detalles" OnClick="btnDetalles_Click" BackColor="#bbd1ff" />
      <asp:Button ID="btnEditar" runat="server" Text="Editar" OnClick="btnEditar_Click" BackColor="#cefec5" />
      <asp:Button ID="btnEliminar" runat="server" Text="Eliminar" OnClick="btnEliminar_Click" BackColor="#ff5e5e" />
    </div>

    <div>
        <div>
            <a href="Liga.aspx">Ir a
        </div>
    </div>        
</div>
</asp:Content>
