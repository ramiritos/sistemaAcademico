<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Index.aspx.cs" Inherits="CapaPrensentacion.Index" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <asp:Login ID="Login1" runat="server" OnAuthenticate="Login1_Authenticate">
</asp:Login>
</asp:Content>
