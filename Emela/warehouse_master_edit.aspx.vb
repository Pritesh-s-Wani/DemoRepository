
Partial Class warehouse_master_edit
    Inherits System.Web.UI.Page
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If IsPostBack = False Then
            Dim obj As New dbconnection
            Dim table As System.Data.DataTable = obj.gettable("select *from warehouse_master where wh_id=" + Request.QueryString("id"))
            wname.text = table.Rows(0)("wh_name").ToString
            address.text = table.Rows(0)("wh_address").ToString
            drpcity.datasource = obj.gettable("select *from city")
            drpcity.datatextfield = "c_name"
            drpcity.datavaluefield = "c_id"
            drpcity.databind()
            drpcity.selectedvalue = table.Rows(0)("c_id").ToString
        End If
    End Sub

    Protected Sub reset_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles reset.Click
        wname.text = ""
        address.text = ""
    End Sub

    Protected Sub submit_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles submit.Click
        Dim obj As New dbconnection
        obj.excecutequery("update warehouse_master set wh_name='" + wname.text + "',wh_address='" + address.text + "',c_id=" + drpcity.selectedvalue + " where wh_id=" + Request.QueryString("id"))
        Response.Redirect("warehouse_master_display.aspx")
    End Sub
End Class
