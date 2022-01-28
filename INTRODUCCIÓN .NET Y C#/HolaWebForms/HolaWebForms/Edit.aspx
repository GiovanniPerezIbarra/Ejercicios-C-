<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Edit.aspx.cs" Inherits="HolaWebForms.Edit" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <h3>Editar</h3>
    <h4>Nombre:&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:TextBox ID="nombreedit" runat="server" Height="24px"></asp:TextBox>
    </h4>
    <h4>Clave:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:TextBox ID="claveedit" runat="server" Height="24px"></asp:TextBox>
    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="actualizarBtn" runat="server" Text="Actualizar" Height="25px" OnClick="actualizarBtn_Click" Width="100px" />
    </h4>
    <asp:LinkButton ID="borrar" runat="server" href="Inicio.aspx">Regresar a la lista</asp:LinkButton>
    </asp:Content>