
Partial Class dis_master_add
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Dim obj As New dbconnection
        If IsPostBack = False Then
            drpstate.datasource = obj.gettable("select *from state")
            drpstate.datatextfield = "s_name"
            drpstate.datavaluefield = "s_id"
            drpstate.databind()
        End If
    End Sub

    Protected Sub reset_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles reset.Click
        dname.text = ""
    End Sub

    Protected Sub submit_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles submit.Click
        Dim obj As New dbconnection
        obj.excecutequery("insert into dis_master(name,s_id) values('" + dname.text + "'," + drpstate.selectedvalue + ")")
        Response.Redirect("dis_master_display.aspx")
    End Sub
End Class
