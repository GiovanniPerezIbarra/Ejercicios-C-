<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Create.aspx.cs" Inherits="HolaWebForms.Create" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <h3>Agregar</h3>
    <h4>Nombre:&nbsp;&nbsp;&nbsp;<asp:TextBox ID="nombretext" runat="server" Height="24px" Width="222px"></asp:TextBox>
    </h4>
    <h4>Clave:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <asp:TextBox ID="clavetext" runat="server" Height="24px" Width="223px"></asp:TextBox>
        &nbsp;&nbsp;&nbsp;
    <asp:Button ID="guardarBtn" runat="server" Text="Guardar" Height="25px" OnClick="guardarBtn_Click" />
    &nbsp;<asp:Button ID="agregarBtn" runat="server" Text="Limpiar" Height="25px" OnClick="agregarBtn_Click" Width="98px" />
    </h4>
    <asp:LinkButton ID="borrar" runat="server" href="Inicio.aspx">Regresar a la lista</asp:LinkButton>
</asp:Content>