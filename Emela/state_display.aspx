<%@ Page Title="" Language="VB" MasterPageFile="~/main_admin_masterpg.master" AutoEventWireup="false" CodeFile="state_display.aspx.vb" Inherits="state_display" %>

<asp:Content ID="Content1" ContentPlaceHolderID="script" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="pgheader" Runat="Server">State
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="main" Runat="Server">
<asp:Button ID="add" runat="server" Text="Add new State" />
<asp:GridView DataKeyNames="s_id" runat="server" ID="Gridview1" AutoGenerateColumns="true">
<Columns>
<asp:CommandField HeaderText ="Delete" ShowDeleteButton="true" />
<asp:CommandField HeaderText="Edit" ShowEditButton ="true" />
</Columns>
</asp:GridView>
</asp:Content>

