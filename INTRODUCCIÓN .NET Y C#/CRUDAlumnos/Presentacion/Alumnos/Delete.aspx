<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Delete.aspx.cs" Inherits="Presentacion.Alumnos.Delete" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <h2>Datos del Alumno</h2>
    <hr />
	<h4>¿Está seguro que desea eliminar al alumno?</h4>
   <dl class="dl-horizontal">
		<dt>
			Id:
		</dt>
		<dd>
			<asp:Label ID="idlbl" runat="server" Text="Label"></asp:Label>
		</dd>
	</dl>
    <dl class="dl-horizontal">
		<dt>
			Nombre:
		</dt>
		<dd>
			<asp:Label ID="nombrelbl" runat="server" Text="Label"></asp:Label>
		</dd>
	</dl>
    <dl class="dl-horizontal">
		<dt>
			Primer Apellido:
		</dt>
		<dd>
			<asp:Label ID="palbl" runat="server" Text="Label"></asp:Label>
		</dd>
	</dl>
    <dl class="dl-horizontal">
		<dt>
			Segundo Apellido:
		</dt>
		<dd>
			<asp:Label ID="salbl" runat="server" Text="Label"></asp:Label>
		</dd>
	</dl>
    <dl class="dl-horizontal">
		<dt>
			Fecha de Nacimiento:
		</dt>
		<dd>
			<asp:Label ID="fnlbl" runat="server" Text="Label"></asp:Label>
		</dd>
	</dl>
    <dl class="dl-horizontal">
		<dt>
			CURP:
		</dt>
		<dd>
			<asp:Label ID="curplbl" runat="server" Text="Label"></asp:Label>
		</dd>
	</dl>
    <dl class="dl-horizontal">
		<dt>
			Correo:
		</dt>
		<dd>
			<asp:Label ID="emaillbl" runat="server" Text="Label"></asp:Label>
		</dd>
	</dl>
    <dl class="dl-horizontal">
		<dt>
			Telefono:
		</dt>
		<dd>
			<asp:Label ID="phonelbl" runat="server" Text="Label"></asp:Label>
		</dd>
	</dl>
    <dl class="dl-horizontal">
		<dt>
			Estado:
		</dt>
		<dd>
			<asp:Label ID="estadolbl" runat="server" Text="Label"></asp:Label>
		</dd>
	</dl>
    <dl class="dl-horizontal">
		<dt>
			Estatus:
		</dt>
		<dd>
			<asp:Label ID="estatuslbl" runat="server" Text="Label"></asp:Label>
		</dd>
	</dl>
	<div class="form-group">
        <div>
            <asp:Button ID="eliminarBtn" runat="server" Text="Eliminar" OnClick="eliminarBtn_Click" CssClass="btn btn-default"/>
        </div>
    </div>
	<div class="form-group">
        <div>
            <a href="Index.aspx">Regresar a la lista</a>
        </div>
    </div> 
</asp:Content>
