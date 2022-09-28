<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Details.aspx.cs" Inherits="ADOWebForms.forms.Details" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div>
    <h2>Detalles</h2>
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
            <asp:Label ID="lbMId" runat="server" Text=" "></asp:Label>
        </div>
        <div>
            <asp:Label ID="lbNombre" runat="server" Text="Nombre"></asp:Label>
            <asp:Label ID="lbMNombre" runat="server" Text=" "></asp:Label>
        </div>
        <div>
            <asp:Label ID="lbClave" runat="server" Text="Clave"></asp:Label>
            <asp:Label ID="lbMClave" runat="server" Text=" "></asp:Label>
        </div>
    </div>
    <div>
        <div style ="margin : 30px" >
            <asp:Button ID="btnRegresar" runat="server" Text="Regresar" OnClick="btnGuardarAgregar_Click" />
        </div>
    </div>        
</div>
</asp:Content>
