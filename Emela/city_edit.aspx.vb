
Partial Class city_edit
    Inherits System.Web.UI.Page
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If IsPostBack = False Then
            Dim obj As New dbconnection
            Dim table As System.Data.DataTable = obj.gettable("select *from city where c_id=" + Request.QueryString("id"))
            cname.text = table.Rows(0)("c_name").ToString
            zip.text = table.Rows(0)("zip").ToString
            drpdist.datasource = obj.gettable("select *from dis_master")
            drpdist.datatextfield = "name"
            drpdist.datavaluefield = "dist_id"
            drpdist.databind()
            drpdist.selectedvalue = table.Rows(0)("dist_id").ToString
        End If
    End Sub

    Protected Sub reset_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles reset.Click
        cname.text = ""
        zip.text = ""
    End Sub

    Protected Sub submit_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles submit.Click
        Dim obj As New dbconnection
        obj.excecutequery("update city set c_name='" + cname.text + "',zip='" + zip.text + "',dist_id=" + drpdist.selectedvalue + " where c_id=" + Request.QueryString("id"))
        Response.Redirect("city_display.aspx")
    End Sub
End Class
