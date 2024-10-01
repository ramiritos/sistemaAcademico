<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="frmAlumno.aspx.cs" Inherits="CapaPrensentacion.Privado.frmAlumno" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
      <h3>Mantenimiento de la tabla Alumno</h3>
    <p>
        CodAlumno : <asp:TextBox runat="server" id="txtCodAlumno" CssClass="form-control"/> 
    </p>
    <p> 
        APaterno : <asp:TextBox runat="server" id="txtAPaterno" CssClass="form-control"/>
    </p>   
    <p> 
        AMaterno : <asp:TextBox runat="server" id="txtAMaterno" CssClass="form-control"/>
    </p>
    <p> 
        NombresAlumno  : <asp:TextBox runat="server" id="txtNombresAlumno" CssClass="form-control"/>
    </p>
    <p> 
        UsuarioAlumno  : <asp:TextBox runat="server" id="txtUsuarioAlumno" CssClass="form-control"/>
    </p>
     <p> 
        CodCarrera   : <asp:TextBox runat="server" id="txtCodCarrera" CssClass="form-control"/>
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
