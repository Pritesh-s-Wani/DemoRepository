
Partial Class state_edit
    Inherits System.Web.UI.Page

    Protected Sub reset_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles reset.Click
        sname.text = ""
    End Sub

    Protected Sub update_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles update.Click
        Dim obj As New dbconnection
        obj.excecutequery("update state set s_name='" + sname.text + "' where s_id=" + Request.QueryString("id"))
        Response.Redirect("state_display.aspx")
    End Sub

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If IsPostBack = False Then
            Dim obj As New dbconnection
            Dim table As System.Data.DataTable = obj.gettable("select *from state where s_id=" + Request.QueryString("id"))
            sname.text = table.Rows(0)("s_name").ToString
        End If
    End Sub
End Class
