<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Details.aspx.cs" Inherits="Presentacion.Alumnos.Details" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="ajaxToolkit" %>
<asp:Label ID="lblHidden" runat="server" Text=""></asp:Label>
<ajaxToolkit:ModalPopupExtender ID="Modal" runat="server" TargetControlID="lblHidden" PopupControlID="myModalIMSS" DropShadow="true" BackgroundCssClass="modalBackground"></ajaxToolkit:ModalPopupExtender>
    <h2>Datos del Alumno</h2>
    <hr />
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
    <!-- Ventana Modal Servidor -->
  <div id="myModalIMSS">
        <div class="modal-dialog">
            <div class="modal-content">
                <div class="modal-header">
                    <h4 class="modal-title">Cálculo del IMSS</h4>
                    <asp:Button ID="btnX" runat="server" Text="&times;" class="close" />
                </div>
                <div class="modal-body">
                    <dl>
                        <dt>Enfermedades / Maternidad:
                        </dt>
                        <dd>
                            <asp:Label ID="m1" runat="server"></asp:Label>
                        </dd>
                    </dl>
					<dl>
                        <dt>Invalidez / Vida:
                        </dt>
                        <dd>
                            <asp:Label ID="m2" runat="server"></asp:Label>
                        </dd>
                    </dl>
					<dl>
                        <dt>Retiro:
                        </dt>
                        <dd>
                            <asp:Label ID="m3" runat="server"></asp:Label>
                        </dd>
                    </dl>
					<dl>
                        <dt>Cesantía:
                        </dt>
                        <dd>
                            <asp:Label ID="m4" runat="server"></asp:Label>
                        </dd>
                    </dl>
					<dl>
                        <dt>Infonavit:
                        </dt>
                        <dd>
                            <asp:Label ID="m5" runat="server"></asp:Label>
                        </dd>
                    </dl>
                </div>
                <div class="modal-footer">
                    <asp:Button ID="btnCancelar" runat="server" Text="Cerrar" CssClass="btn btn-danger" />
                </div>
            </div>
        </div>
    </div>
        <!-- Ventana Modal AJAX -->
    <div class="modal" id="myModalISR">
        <div class="modal-dialog">
            <div class="modal-content">
                <div class="modal-header">
                    <h4 class="modal-title">Impuesto</h4>
                    <button type="button" class="close" data-dismiss="modal">&times;</button>
                </div>
                <div class="modal-body">    
                    <dl>
                        <dt>Limite Inferior:
                        </dt>
                        <dd>
                            <asp:Label ID="lblimint" runat="server" Text=""></asp:Label>
                        </dd>
                    </dl>
                    <dl>
                        <dt>Limite Superior:
                        </dt>
                        <dd>
                            <asp:Label ID="lblimsup" runat="server" Text=""></asp:Label>
                        </dd>
                    </dl>  
                    <dl>
                        <dt>Cuota fija:
                        </dt>
                        <dd>
                            <asp:Label ID="lblcuota" runat="server" Text=""></asp:Label>
                        </dd>
                    </dl>   
                    <dl>
                        <dt>Excedente:
                        </dt>
                        <dd>
                            <asp:Label ID="lblexced" runat="server" Text=""></asp:Label>
                        </dd>
                    </dl>
                    <dl>
                        <dt>Subsidio:
                        </dt>
                        <dd>
                            <asp:Label ID="lblsubs" runat="server" Text=""></asp:Label>
                        </dd>
                    </dl>  
                    <dl>
                        <dt>Impuesto:
                        </dt>
                        <dd>
                            <asp:Label ID="lblimp" runat="server" Text=""></asp:Label>
                        </dd>
                    </dl>
                </div>
                <div class="modal-footer">
                    <button type="button" class="btn btn-danger" data-dismiss="modal">Cerrar</button>
                </div>
            </div>
        </div>
    </div>
	<div class="form-group">
        <div>
			<asp:Button type="button" id="imssBtn" runat="server" class="btn btn-info" OnClick="imssBtn_Click" data-toggle="modal" data-target="#myModalIMSS" Text="IMSS" />
			<button type="button" runat="server" class="btn btn-info" OnClick="LLamaAJAXPost();" data-toggle="modal" data-target="#myModalISR">ISR</button>
        </div>
    </div>
	<div class="form-group">
        <div>
            <a href="Index.aspx">Regresar a la lista</a>
        </div>
    </div> 
    <script type="text/javascript">
	    function LLamaAJAXPost(){
            var urlws = 'https://localhost:44384/WSAlumno.asmx/CalcularISR';
            const valores = window.location.search;
            const urlParams = new URLSearchParams(valores);
            var id = urlParams.get("id");
            var alumno = { id: parseInt(id)};
            var parametros = JSON.stringify(alumno);

            $.ajax({
                type: 'POST',
                url: urlws,
                data: parametros,
                contentType: "application/json; charset=utf-8",
                dataType: "json",
                success: RecibeObjeto,
                error: errorGenerico
            });
        }
     function RecibeObjeto(data) {
            try {
                imss = data.d;
                if (imss != null) {
                    $('#<%=lblimint.ClientID%>').html(imss.límiteInferior);
                    $('#<%=lblimsup.ClientID%>').html(imss.límiteSuperior);
                    $('#<%=lblcuota.ClientID%>').html(imss.cuotaFija);
                    $('#<%=lblexced.ClientID%>').html(imss.excedente);
                    $('#<%=lblsubs.ClientID%>').html(imss.subsidio);
                    $('#<%=lblimp.ClientID%>').html(imss.impuesto);
                    $('#myModalISR').modal('show');
                }
                else {
                    alert('La respuesta recibida del Web Service es incorrecta ' + data.d);
                }
            }
            catch (ex) {
                alumno = [];
                alert('Error al recibir los datos');
            }
        }		
        function errorGenerico(jqXHR, exception) {
            var msg = '';
            if (jqXHR.status === 0) {
                msg = 'No está conectado, favor de verificar su conexión.';
            }
            else if (jqXHR.status === 404) {
                msg = 'Página no encontrada [404]';
            }
            else if (jqXHR.status === 500) {
                msg = 'Error no hay conexión al servidor [500]';
            }
            else if (jqXHR.status === 'parseerror') {
                msg = 'El parseo del JSON es erróneo.';
            }
            else if (jqXHR.status === 'timeout') {
                $('body').addClass('loaded');
            }
            else if (jqXHR.status === 'abort') {
                msg = 'La petición Ajax fue abortada.';
            }
            else {
                msg = 'Error no conocido. ';
                console.log(exception);
            }
            alert(msg);
        }
    </script>
</asp:Content>