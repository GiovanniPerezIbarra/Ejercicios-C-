<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Create.aspx.cs" Inherits="Presentacion.Alumnos.Create" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <h2>Agregar Alumno</h2>
    <hr />
    <div class="form-group">
        <label for="TextBox1" class="control-label col-md-2">Nombre:</label>
        <div>
            <asp:TextBox ID="nombrebox" CssClass="form-control text-box single-line" runat="server" Width="192px" Height="35px"></asp:TextBox>
        </div>
    </div>
    <div class="form-group">
        <label for="TextBox1" class="control-label col-md-2">Primer Apellido:</label>
        <div>
            <asp:TextBox ID="pabox" CssClass="form-control text-box single-line" runat="server" Width="192px" Height="35px"></asp:TextBox>
        </div>
    </div>
    <div class="form-group">
        <label for="TextBox1" class="control-label col-md-2">Segundo Apellido::</label>
        <div>
            <asp:TextBox ID="sabox" CssClass="form-control text-box single-line" runat="server" Width="192px" Height="35px"></asp:TextBox>
        </div>
    </div>
    <div class="form-group">
        <label for="TextBox1" class="control-label col-md-2">Correo:</label>
        <div>
            <asp:TextBox ID="mailbox" CssClass="form-control text-box single-line" runat="server" Width="192px" Height="35px" TextMode="Email"></asp:TextBox>
        </div>
    </div>
    <div class="form-group">
        <label for="TextBox1" class="control-label col-md-2">Telefono:</label>
        <div>
            <asp:TextBox ID="phonebox" placeholder="99-9999-9999" CssClass="form-control text-box single-line" runat="server" Width="192px" Height="35px"></asp:TextBox>
        </div>
    </div>
    <div class="form-group">
        <label for="TextBox1" class="control-label col-md-2">Fecha de Nacimiento:</label>
        <div>
            <asp:TextBox ID="fnbox" CssClass="form-control text-box single-line" runat="server" Width="192px" Height="35px" TextMode="Date"></asp:TextBox>
        </div>
    </div>
    <div class="form-group">
        <label for="TextBox1" class="control-label col-md-2">CURP:</label>
        <div>
            <asp:TextBox ID="curpbox" CssClass="form-control text-box single-line" runat="server" Width="192px" Height="35px"></asp:TextBox>
        </div>
    </div>
    <div class="form-group">
        <label for="TextBox1" class="control-label col-md-2">Estado:</label>
        <div>
            <asp:DropDownList ID="estadolist" CssClass="form-control text-box single-line" runat="server" Width="192px" Height="35px"></asp:DropDownList>
        </div>
    </div>
    <div class="form-group">
        <label for="TextBox1" class="control-label col-md-2">Estatus:</label>
        <div>
            <asp:DropDownList ID="estatuslist" CssClass="form-control text-box single-line" runat="server" Width="192px" Height="35px"></asp:DropDownList>
        </div>
    </div>
    <div class="form-group">
        <div>
            <asp:Button ID="guardarBtn" runat="server" Text="Guardar" OnClick="guardarBtn_Click" CssClass="btn btn-default"/>
        </div>
    </div>
    <div class="form-group">
        <div>
            <a href="Index.aspx">Regresar a la lista</a>
        </div>
    </div> 
</asp:Content>