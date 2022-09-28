<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Edit.aspx.cs" Inherits="ADOWebForms.forms.Edit" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div>
    <h2>Actualizar</h2>
	<!-- Control asp Label para mensajes -->		
    <hr />
    <div>
		<!-- Par de label html - Control asp por cada propiedad -->
        
    </div>
    <div>

    </div>
    <div style="display : contents; margin : 30px; ">
        <div>
            <asp:Label ID="lbId" runat="server" Text="Id"></asp:Label>
            <asp:TextBox ID="txtId" runat="server" Enabled="False"></asp:TextBox>
            
        </div>
        <div>
            <asp:Label ID="lbNombre" runat="server" Text="Nombre"></asp:Label>
            <asp:TextBox ID="txtNombre" runat="server"></asp:TextBox>
        </div>
        <div>
            <asp:Label ID="lbClave" runat="server" Text="Clave"></asp:Label>
            <asp:TextBox ID="txtClave" runat="server"></asp:TextBox>
        </div>
    </div>
    <div>
        <div style ="margin : 30px">
            <asp:Button ID="btnEditarAgregar" runat="server" Text="Guardar" OnClick="btnGuardarAgregar_Click" />
        </div>
    </div>        
</div>
</asp:Content>
