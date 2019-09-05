<%@ Page Title="" Language="VB" MasterPageFile="~/main_admin_masterpg.master" AutoEventWireup="false" CodeFile="ma_profile_view.aspx.vb" Inherits="ma_profile_view"   %>

<asp:Content ID="Content1" ContentPlaceHolderID="script" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="pgheader" Runat="Server">
    My Profile
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="main" Runat="Server">
    <asp:FormView ID="frmview_myprofile" DataKeyNames="ma_id" runat="server">
        <ItemTemplate >
            My Id:<asp:Label ID="lbl_ma_id" runat="server" Text='<%# Eval("ma_id")%>'></asp:Label><br /><br />
            My Name:<asp:Label ID="lbl_name" runat="server" Text='<%# Eval("name")%>'></asp:Label><br /><br />
            My Email:<asp:Label ID="lbl_email" runat="server" Text='<%# Eval("email")%>'></asp:Label><br /><br />
            My Contect No:<asp:Label ID="lbl_cno" runat="server" Text='<%# Eval("cno")%>'></asp:Label><br /><br />
            My Pic:<asp:Image Height="100" Width="100" ID="ma_pic" runat="server" ImageUrl='<%# String.Format("./profile_image/{0}", Eval("pic")) %>' /><br /><br />
            <asp:LinkButton ID="Edit" runat="server" CommandName="Edit" Text="Edit" ></asp:LinkButton>
        </ItemTemplate>
        <EditItemTemplate >
             My Id:<asp:Label ID="txt_ma_id" runat="server" Text='<%# Eval("ma_id")%>'></asp:Label><br /><br />
            My Name:<asp:TextBox ID="txt_name" runat="server" Text='<%# Eval("name")%>'></asp:TextBox><br /><br />
            My Email:<asp:TextBox ID="txt_email" runat="server" Text='<%# Eval("email")%>'></asp:TextBox><br /><br />
            My Contect No:<asp:TextBox ID="txt_cno" runat="server" Text='<%# Eval("cno")%>'></asp:TextBox><br /><br />
            Current Password:<asp:TextBox ID="crpass" runat="server" ></asp:TextBox><br />
            New Password:<asp:TextBox ID="newpass" runat="server" ></asp:TextBox><br />
            Conform Password:<asp:TextBox ID="cpass" runat="server" ></asp:TextBox><br />
            <asp:Label ID="passerr" runat="server" ></asp:Label><br />
            My Pic:<asp:Image Height="100" Width="100" ID="ma_e_pic" runat="server" ImageUrl='<%# String.Format("./profile_image/{0}", Eval("pic")) %>' />
            <asp:HiddenField ID="hdn" runat="server" Value='<%#Eval("pic") %>' /><br />
            <asp:FileUpload ID="ma_pic_edit" runat="server" /><br />
            <asp:Label ID="imgerr" runat="server" ></asp:Label><br /><br />
            <asp:LinkButton ID="Edit" runat="server" CommandName="Update" Text="Update" ></asp:LinkButton>
            <asp:LinkButton ID="Cancel" runat="server" CommandName="Cancel" Text="Cancel" ></asp:LinkButton>
           
        </EditItemTemplate>
    </asp:FormView>
</asp:Content>

