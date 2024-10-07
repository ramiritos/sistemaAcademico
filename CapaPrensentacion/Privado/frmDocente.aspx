<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="frmDocente.aspx.cs" Inherits="CapaPrensentacion.Privado.frmDocente" %>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <h3> Mantenimiento de la tabla Docente</h3>
    <p>
        CodDocente:<asp:TextBox runat="server" id="txtCodDocente" CssClass="form-control"/>
    </p>
    <p>
        Apellido Paterno: <asp:TextBox runat="server" id="txtDoAPaterno" CssClass="form-control"/>
    </p>
    <p>
        Apellido Materno: <asp:TextBox runat="server" ID="txtDoAMaterno" CssClass="form-control"/>
    </p>
    <p>
        Nombres: <asp:TextBox runat="server" id="txtDoNombres" CssClass="form-control"/>
    </p>
    <p>
        Usuario: <asp:TextBox runat="server" id="txtDoUsuario" CssClass="form-control"/>
    </p>
    <p>
        <asp:Button Text="Agregar" runat="server" ID="btnAgregar" CssClass="btn btn-primary" OnClick="btnAgregar_Click" />
        <asp:Button Text="Eliminar" runat="server" ID="btnEliminar" CssClass="btn btn-danger" OnClick="btnEliminar_Click" />
        <asp:Button Text="Actualizar" runat="server" ID="btnActualizar" CssClass="btn btn-warning" OnClick="btnActualizar_Click" />
    </p>
    <p>
        Buscar:<asp:TextBox runat="server" ID="txtBuscardo" CssClass="form-control"/>
        <asp:Button Text="Buscar" runat="server" ID="btnBuscar" CssClass="btn btn-info" OnClick="btnBuscar_Click" />
    </p>
    <p>
        <asp:GridView runat="server" ID="gvDocente" CssClass="table table-bordered text-center"></asp:GridView>
    </p>
</asp:Content>
