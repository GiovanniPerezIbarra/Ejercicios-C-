<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Edit.aspx.cs" Inherits="Presentacion.Alumnos.Edit" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
     <h2>Actualizar Alumno</h2>
    <hr />
    <div class="form-group">
        <label for="TextBox1" class="control-label col-md-2">Id:</label>
        <div>
            <asp:TextBox ID="idbox" CssClass="form-control text-box single-line" runat="server" Width="192px" Height="35px" Enabled="False"></asp:TextBox>
        </div>
    </div>
    <div class="form-group">
        <label for="TextBox1" class="control-label col-md-2">Nombre:</label>
        <div>
            <asp:TextBox ID="nombrebox" CssClass="form-control text-box single-line" runat="server" Width="192px" Height="35px"></asp:TextBox>
            <asp:RequiredFieldValidator ID="requierenombre" runat="server" ErrorMessage="El nombre es obligatorio." ControlToValidate="nombrebox" Font-Bold="True" Font-Italic="False" Display="Dynamic" EnableTheming="True" ForeColor="Red"></asp:RequiredFieldValidator>
        </div>
    </div>
    <div class="form-group">
        <label for="TextBox1" class="control-label col-md-2">Primer Apellido:</label>
        <div>
            <asp:TextBox ID="pabox" CssClass="form-control text-box single-line" runat="server" Width="192px" Height="35px"></asp:TextBox>
            <asp:RequiredFieldValidator ID="requiereprimerapellido" runat="server" ErrorMessage="El  apellido es obligatorio." ControlToValidate="pabox" Display="Dynamic" Font-Bold="True" ForeColor="Red"></asp:RequiredFieldValidator>
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
            <asp:RequiredFieldValidator ID="mailrequerido" runat="server" ErrorMessage="El correo es obligatorio." ControlToValidate="mailbox" Display="Dynamic" Font-Bold="True" ForeColor="Red"></asp:RequiredFieldValidator>
            </div>
    </div>
    <div class="form-group">
        <label for="TextBox1" class="control-label col-md-2">Telefono:</label>
        <div>
            <asp:TextBox ID="phonebox" placeholder="99-9999-9999" CssClass="form-control text-box single-line" runat="server" Width="192px" Height="35px"></asp:TextBox>
            <asp:RegularExpressionValidator ID="phonevalidar" runat="server" ErrorMessage="El numero debe de ser de 10 digitos." ControlToValidate="phonebox" Display="Dynamic" Font-Bold="True" ForeColor="Red" ValidationExpression="[0-9]{10}"></asp:RegularExpressionValidator>
        </div>
    </div>
    <div class="form-group">
        <label for="TextBox1" class="control-label col-md-2">Fecha de Nacimiento:</label>
        <div>
            <asp:TextBox ID="fnbox" CssClass="form-control text-box single-line" runat="server" Width="192px" Height="35px" TextMode="Date"></asp:TextBox>
            <asp:RangeValidator ID="validafecha" runat="server" ErrorMessage="Fuera de rango." ControlToValidate="fnbox" Display="Dynamic" Font-Bold="True" MaximumValue="2000/12/31" MinimumValue="1990/01/01" Type="Date" ForeColor="Red"></asp:RangeValidator>
            </div>
    </div>
    <div class="form-group">
        <label for="TextBox1" class="control-label col-md-2">CURP:</label>
        <div>
            <asp:TextBox ID="curpbox" CssClass="form-control text-box single-line" runat="server" Width="192px" Height="35px"></asp:TextBox>
            <asp:RegularExpressionValidator ID="curpvalidar" runat="server" ErrorMessage="El formato no es el correcto." ControlToValidate="curpbox" Display="Dynamic" Font-Bold="True" ForeColor="Red" ValidationExpression="[A-Z]{4}[0-9]{6}[H|M][A-Z]{2}[B-DF-HJ-NP-TV-Z]{3}[A-Z&amp;0-9]{2}"></asp:RegularExpressionValidator>
            &nbsp;<asp:CustomValidator ID="compararbox" runat="server" Display="Dynamic" ErrorMessage="La fecha del curp no coincide con la fecha de nacimiento." Font-Bold="True" ForeColor="Red" ControlsToValidate="curpbox" ClientValidationFunction="comparar"></asp:CustomValidator>
        </div>
    </div>
    <div class="form-group">
        <label for="TextBox1" class="control-label col-md-2">Sueldo:</label>
        <div>
            <asp:TextBox ID="sueldobox" CssClass="form-control text-box single-line" runat="server" Width="192px" Height="35px"></asp:TextBox>
            <asp:RequiredFieldValidator ID="requieresueldo" runat="server" ErrorMessage="El  sueldo es obligatorio." ControlToValidate="sueldobox" Display="Dynamic" Font-Bold="True" ForeColor="Red"></asp:RequiredFieldValidator>
      &nbsp;<asp:RegularExpressionValidator ID="mayoracero" runat="server" ErrorMessage="Debe ser mayor a 0 y al menos de 2 digitos." ControlToValidate="sueldobox" Display="Dynamic" Font-Bold="True" ForeColor="Red" ValidationExpression="(^[1-9][0-9]*.[0-9]*$)"></asp:RegularExpressionValidator>

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
            <br />
        </div>
    </div>
    <div class="form-group">
        <div>
            <a href="Index.aspx">Regresar a la lista</a>
        </div>
    </div> 
     <script type="text/javascript">
         function comparar(source, arguments){
             var fn = $("#<%=fnbox.ClientID%>").val();
             var curp = $("#<%=curpbox.ClientID%>").val();
             var sep = fn.split('-');
             var jun = sep[0] + sep[1] + sep[2];
             if (curp.substr(4, 6) == jun.substr(2)) {
                 arguments.IsValid = true;
             } else {
                 arguments.IsValid = false;
             }
         }
     </script>
</asp:Content>