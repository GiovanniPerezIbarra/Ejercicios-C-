<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Details.aspx.cs" Inherits="HolaWebForms.Details" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <h3>Detalles</h3>
    <h4>Id:&nbsp;<asp:Label ID="iddetail" runat="server" Font-Italic="True" Font-Size="Smaller" Font-Underline="False"></asp:Label>
    </h4>
    <h4>Nombre:
    <asp:Label ID="nombredetail" runat="server" Font-Italic="True" Font-Size="Smaller"></asp:Label>
    </h4>
    <h4>Clave:
    <asp:Label ID="clavedetail" runat="server" Font-Italic="True" Font-Size="Smaller"></asp:Label>
    </h4>
    <asp:LinkButton ID="borrar" runat="server" href="Inicio.aspx" OnClick="borrar_Click">Regresar a la lista</asp:LinkButton>
</asp:Content>