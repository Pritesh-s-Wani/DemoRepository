
Partial Class city_add
    Inherits System.Web.UI.Page
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Dim obj As New dbconnection
        If IsPostBack = False Then
            drpdist.datasource = obj.gettable("select *from dis_master")
            drpdist.datatextfield = "name"
            drpdist.datavaluefield = "dist_id"
            drpdist.databind()
        End If
    End Sub

    Protected Sub reset_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles reset.Click
        cname.text = ""
        zip.text = ""
    End Sub

    Protected Sub submit_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles submit.Click
        Dim obj As New dbconnection
        obj.excecutequery("insert into city(c_name,dist_id,zip) values('" + cname.text + "'," + drpdist.selectedvalue + ",'" + zip.text + "')")
        Response.Redirect("city_display.aspx")
    End Sub
End Class
