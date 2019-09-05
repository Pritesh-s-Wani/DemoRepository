<%@ Page Title="" Language="VB" MasterPageFile="~/main_admin_masterpg.master" AutoEventWireup="false" CodeFile="warehouse_master_edit.aspx.vb" Inherits="warehouse_master_edit" %>

<asp:Content ID="Content1" ContentPlaceHolderID="script" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="pgheader" Runat="Server">Warehouse Edit
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="main" Runat="Server">
<table>
<tr>
<td>Warehouse name:</td>
<td><asp:TextBox runat="server" ID="wname" /></td>
<td><asp:RequiredFieldValidator ID="req1" runat="server" ControlToValidate="wname" ErrorMessage="*" /></td>
</tr>
<tr>
<td>City:</td>
<td><asp:DropDownList ID="drpcity" runat="server" />
    <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
    </td>
</tr>
<tr>
<td>Address:</td>
<td><asp:TextBox ID="address" runat="server" TextMode="MultiLine" /></td>
<td><asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="address" ErrorMessage="*" /></td>
</tr>
<tr>
<td></td>
<td><asp:Button Text="Update" ID="submit" runat="server"/><asp:Button Text="Reset" ID="reset" runat="server" /></td>
</tr>
</table>
</asp:Content>

