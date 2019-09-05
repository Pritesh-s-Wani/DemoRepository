<%@ Page Title="" Language="VB" MasterPageFile="~/main_admin_masterpg.master" AutoEventWireup="false" CodeFile="dis_master_add.aspx.vb" Inherits="dis_master_add" %>

<asp:Content ID="Content1" ContentPlaceHolderID="script" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="pgheader" Runat="Server">Add District
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="main" Runat="Server">
<table>
<tr>
<td>District name:</td>
<td><asp:TextBox runat="server" ID="dname" /></td>
<td><asp:RequiredFieldValidator ID="req1" runat="server" ControlToValidate="dname" ErrorMessage="*" /></td>
</tr>
<tr>
<td>State:</td>
<td><asp:DropDownList ID="drpstate" runat="server" /></td>
</tr>
<tr>
<td></td>
<td><asp:Button Text="Submit" ID="submit" runat="server"/><asp:Button Text="Reset" ID="reset" runat="server" /></td>
</tr>
</table>
</asp:Content>

