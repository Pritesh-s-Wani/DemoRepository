<%@ Page Title="" Language="VB" MasterPageFile="~/main_admin_masterpg.master" AutoEventWireup="false" CodeFile="warehouse_master_display.aspx.vb" Inherits="warehouse_master_display" %>

<asp:Content ID="Content1" ContentPlaceHolderID="script" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="pgheader" Runat="Server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="main" Runat="Server">
<asp:Button ID="add" runat="server" Text="Add new Warehouse" />
    <asp:GridView ID="GridView1" runat="server" DataKeyNames="wh_id" AutoGenerateColumns="true">
    <Columns>
    <asp:CommandField HeaderText="Delete" ShowDeleteButton="true" />
    <asp:CommandField HeaderText="Edit" ShowEditButton="true" />
    </Columns>
    </asp:GridView>
</asp:Content>

