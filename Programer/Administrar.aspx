<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Administrar.aspx.cs" Inherits="Programer.Formulario_web1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
	<br />
	<br />

	<table class="nav-justified">
		<tr>
			<td style="width: 204px">Cedula</td>
			<td>
				<asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
			</td>
		</tr>
		<tr>
			<td style="width: 204px">Nombre</td>
			<td>
				<asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
			</td>
		</tr>
		<tr>
			<td style="width: 204px">Apellido</td>
			<td>
				<asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
			</td>
		</tr>
		<tr>
			<td style="width: 204px">Fecha Nacimiento</td>
			<td>
				<asp:TextBox ID="TextBox4" runat="server" TextMode="Date"></asp:TextBox>
			</td>
		</tr>
		<tr>
			<td style="width: 204px">Edad</td>
			<td>
				<asp:TextBox ID="TextBox5" runat="server"></asp:TextBox>
			</td>
		</tr>
		<tr>
			<td style="width: 204px">Ciudad</td>
			<td>
				<asp:TextBox ID="TextBox6" runat="server"></asp:TextBox>
			</td>
		</tr>
	</table>
	<br />
	<asp:Button ID="Button1" runat="server" Text="Registrar" OnClick="Button1_Click" />

</asp:Content>
