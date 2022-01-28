<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Delete.aspx.cs" Inherits="HolaWebForms.Delete" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <h3>Eliminar</h3>
    <h4>Id:&nbsp;
    <asp:Label ID="iddetail" runat="server" Font-Italic="True" Font-Size="Smaller"></asp:Label>
    </h4>
    <h4>Nombre:&nbsp;
    <asp:Label ID="nombredetail" runat="server" Font-Italic="True" Font-Size="Smaller"></asp:Label>
    </h4>
    <h4>Clave:&nbsp;
    <asp:Label ID="clavedetail" runat="server" Font-Italic="True" Font-Size="Smaller"></asp:Label>
    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        </h4>
        <asp:Button ID="eliminarBtn" runat="server" Text="Eliminar" Height="25px" OnClick="eliminarBtn_Click"/>
    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <br />
    <br />
    <asp:LinkButton ID="borrar" runat="server" href="Inicio.aspx">Regresar a la lista</asp:LinkButton>
</asp:Content>