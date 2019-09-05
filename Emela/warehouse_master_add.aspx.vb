
Partial Class Account_warehouse_master_add
    Inherits System.Web.UI.Page
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Dim obj As New dbconnection
        If IsPostBack = False Then
            drpcity.datasource = obj.gettable("select *from city")
            drpcity.datatextfield = "c_name"
            drpcity.datavaluefield = "c_id"
            drpcity.databind()
        End If
    End Sub

    Protected Sub reset_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles reset.Click
        wname.text = ""
        address.text = ""
    End Sub

    Protected Sub submit_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles submit.Click
        Dim obj As New dbconnection
        obj.excecutequery("insert into warehouse_master(wh_name,c_id,wh_address) values('" + wname.text + "'," + drpcity.selectedvalue + ",'" + address.text + "')")
        Response.Redirect("warehouse_master_display.aspx")
    End Sub
End Class
