
Partial Class state_insert
    Inherits System.Web.UI.Page

    Protected Sub submit_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles submit.Click
        Dim obj As New dbconnection
        obj.excecutequery("insert into state(s_name) values('" + sname.text + "')")
        Response.Redirect("state_display.aspx")
    End Sub

    Protected Sub reset_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles reset.Click
        sname.Text = ""
    End Sub
End Class
