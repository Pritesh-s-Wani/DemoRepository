<%@ Page Title="" Language="VB" MasterPageFile="~/main_admin_masterpg.master" AutoEventWireup="false" CodeFile="state_insert.aspx.vb" Inherits="state_insert" %>

<asp:Content ID="Content1" ContentPlaceHolderID="script" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="pgheader" Runat="Server">Add new State
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="main" Runat="Server">
<form>
<table>
<tr>
<td>State name:</td>
<td><asp:TextBox runat="server" ID="sname" /></td>
<td><asp:RequiredFieldValidator ID="req1" runat="server" ControlToValidate="sname" ErrorMessage="*" /></td>
</tr>
<tr>
<td></td>
<td><asp:Button Text="Submit" ID="submit" runat="server"/><asp:Button Text="Reset" ID="reset" runat="server" /></td>
</tr>
</table>
</form>
</asp:Content>

