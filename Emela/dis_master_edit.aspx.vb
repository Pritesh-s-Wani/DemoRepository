
Partial Class dis_master_edit
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If IsPostBack = False Then
            Dim obj As New dbconnection
            Dim table As System.Data.DataTable = obj.gettable("select *from dis_master where dist_id=" + Request.QueryString("id"))
            dname.text = table.Rows(0)("name").ToString
            drpstate.datasource = obj.gettable("select *from state")
            drpstate.datatextfield = "s_name"
            drpstate.datavaluefield = "s_id"
            drpstate.databind()
            drpstate.selectedvalue = table.Rows(0)("s_id").ToString
        End If
    End Sub

    Protected Sub reset_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles reset.Click
        dname.text = ""
    End Sub

    Protected Sub submit_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles submit.Click
        Dim obj As New dbconnection
        obj.excecutequery("update dis_master set name='" + dname.text + "',s_id=" + drpstate.selectedvalue + " where dist_id=" + Request.QueryString("id"))
        Response.Redirect("dis_master_display.aspx")
    End Sub
End Class
