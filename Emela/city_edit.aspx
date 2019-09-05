<%@ Page Title="" Language="VB" MasterPageFile="~/main_admin_masterpg.master" AutoEventWireup="false" CodeFile="city_edit.aspx.vb" Inherits="city_edit" %>

<asp:Content ID="Content1" ContentPlaceHolderID="script" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="pgheader" Runat="Server">Update City
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="main" Runat="Server">
<table>
<tr>
<td>City name:</td>
<td><asp:TextBox runat="server" ID="cname" /></td>
<td><asp:RequiredFieldValidator ID="req1" runat="server" ControlToValidate="cname" ErrorMessage="*" /></td>
</tr>
<tr>
<td>District:</td>
<td><asp:DropDownList ID="drpdist" runat="server" /></td>
</tr>
<tr>
<td>Zip code:</td>
<td><asp:TextBox ID="zip" runat="server" /></td>
<td>
<asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="zip" ErrorMessage="*" />
<asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" 
        ErrorMessage="Enetr valid Zip code" ControlToValidate="zip" 
        ValidationExpression="[1-9][0-9]{5}" />
</td>
</tr>
<tr>
<td></td>
<td><asp:Button Text="Update" ID="submit" runat="server"/><asp:Button Text="Reset" ID="reset" runat="server" /></td>
</tr>
</table>
</asp:Content>