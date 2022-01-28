<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Inicio.aspx.cs" Inherits="HolaWebForms.Inicio" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <h3>Indice</h3>
    <asp:DropDownList ID="DropDownList1" runat="server" Width="264px" Height="24px" OnSelectedIndexChanged="DropDownList1_SelectedIndexChanged"></asp:DropDownList>
    <h1> </h1>
    <asp:LinkButton ID="crear" runat="server" href="Create.aspx" CssClass="btn btn-primary btn-sm" OnClick="crear_Click">Agregar</asp:LinkButton>
    <asp:LinkButton ID="ver" runat="server" CssClass="btn btn-primary btn-sm" OnClick="ver_Click">Detalles</asp:LinkButton>
    <asp:LinkButton ID="cambiar" runat="server" CssClass="btn btn-primary btn-sm" OnClick="cambiar_Click">Editar</asp:LinkButton>
    <asp:LinkButton ID="borrar" runat="server" CssClass="btn btn-primary btn-sm" OnClick="borrar_Click">Eliminar</asp:LinkButton>
</asp:Content>