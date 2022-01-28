<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Index.aspx.cs" Inherits="Presentacion.Alumnos.Index" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <h2>Listado de Alumnos</h2>
    <hr />

    <div class="form-group">
        <div>
            <asp:Button ID="agregarBtn" runat="server" Text="Agregar" OnClick="agregarBtn_Click" CssClass="btn btn-primary"/>
        </div>
    </div>
    <div class="form-group">
        <div>
            <asp:GridView ID="gridalumnos" runat="server" AllowPaging="True" GridLines="Horizontal" OnSelectedIndexChanged="GridView1_SelectedIndexChanged" PageSize="8" BorderStyle="None" OnPageIndexChanging="gridalumnos_PageIndexChanging" OnRowCommand="gridalumnos_RowCommand" AutoGenerateColumns="False" Height="100%" Width="100%">
                <Columns>
                    <asp:BoundField DataField="idAlumnos" HeaderText="Id" />
                    <asp:BoundField DataField="nombre" HeaderText="Nombre" />
                    <asp:BoundField DataField="primerApellido" HeaderText="Primer Apellido" />
                    <asp:BoundField DataField="segundoApellido" HeaderText="Segundo Apellido" />
                    <asp:BoundField DataField="correo" HeaderText="Correo" />
                    <asp:BoundField DataField="telefono" HeaderText="Telefono" />
                    <asp:BoundField DataField="Estado" HeaderText="Estado" />
                    <asp:BoundField DataField="Estatus" HeaderText="Estatus" />
                    <asp:ButtonField CommandName="Detalles" Text="Detalles">
                    <ControlStyle CssClass="btn btn-warning" />
                    </asp:ButtonField>
                    <asp:ButtonField CommandName="Editar" Text="Editar">
                    <ControlStyle CssClass="btn btn-success" />
                    </asp:ButtonField>
                    <asp:ButtonField CommandName="Eliminar" Text="Eliminar">
                    <ControlStyle CssClass="btn btn-danger" />
                    </asp:ButtonField>
                </Columns>
            </asp:GridView>
        </div>
    </div>

</asp:Content>