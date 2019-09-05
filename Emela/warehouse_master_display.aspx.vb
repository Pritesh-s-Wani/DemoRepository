
Partial Class warehouse_master_display
    Inherits System.Web.UI.Page
    Sub bindgrid()
        Dim obj As New dbconnection
        Gridview1.datasource = obj.gettable("select wh_id,wh_name,wh_address,c_name from warehouse_master,city where city.c_id=warehouse_master.c_id")
        Gridview1.databind()
    End Sub

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        bindgrid()
    End Sub
    Protected Sub Gridview1_RowDeleting(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.GridViewDeleteEventArgs) Handles Gridview1.RowDeleting
        Dim id As String = Gridview1.datakeys(e.RowIndex).value
        Dim obj As New dbconnection
        obj.excecutequery("delete from warehouse_master where c_id=" + id)
        bindgrid()
    End Sub

    Protected Sub add_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles add.Click
        Response.Redirect("warehouse_master_add.aspx")
    End Sub
    Protected Sub Gridview1_RowEditing(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.GridViewEditEventArgs) Handles Gridview1.RowEditing
        Dim id As String = Gridview1.datakeys(e.NewEditIndex).value
        Response.Redirect("warehouse_master_edit.aspx?id=" + id)
    End Sub
End Class
