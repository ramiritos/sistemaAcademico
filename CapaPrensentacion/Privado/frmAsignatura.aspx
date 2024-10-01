<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="frmAsignatura.aspx.cs" Inherits="CapaPrensentacion.Privado.frmAsignatura" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <h3>Mantenimiento de la tabla Asignaturas</h3>
    <p>
        CodAsignatura: <asp:TextBox runat="server" id="txtCodAsignatura" CssClass="form-control"/> 
    </p>
    <p> 
        Asignatura: <asp:TextBox runat="server" id="txtAsignatura" CssClass="form-control"/>
    </p>   
    <p> 
        Requisito: <asp:TextBox runat="server" id="txtCodRequisito" CssClass="form-control"/>
    </p>
    <p>
        <asp:Button Text="Agregar" runat="server" id="btnAgregar" CssClass="btn btn-primary" OnClick="btnAgregar_Click"/>
        <asp:Button Text="Eliminar" runat="server" id="btnEliminar" CssClass="btn btn-danger" OnClick="btnEliminar_Click"/>
        <asp:Button Text="Actualizar" runat="server" id="btnActualizar" CssClass="btn btn-warning" OnClick="btnActualizar_Click"/>
    </p>
    <p>
         Buscar: <asp:TextBox runat="server" id="txtBuscar" CssClass="form-control" OnTextChanged="txtBuscar_TextChanged" />
    </p>
    <p>
        <asp:Button Text="Buscar" runat="server" id="btnBuscar" CssClass="btn btn-info" OnClick="btnBuscar_Click"/>
    </p>
    <p>
        <asp:GridView runat="server" id="gvAsignatura" CssClass="table table-bordered text-center"></asp:GridView>
    </p>
</asp:Content>
