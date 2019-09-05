
Partial Class main_admin_masterpg
    Inherits System.Web.UI.MasterPage

    Protected Sub Page_Load(sender As Object, e As EventArgs) Handles Me.Load
        If Session("ma_id") Is Nothing Then
            Response.Redirect("login_pg.aspx")
        End If
        maidpath.PostBackUrl = "ma_profile_view.aspx?ma_id=" + Session("ma_id").ToString
        Dim db As New dbconnection
        Dim nt As System.Data.DataTable = db.gettable("select * from ma_notification where ma_id=" + Session("ma_id").ToString)
        Dim i As String = nt.Rows.Count().ToString
        If Not i = "0" Then
            no_of_not1.Text = "<span class=" + "badge blue" + ">" + i + "</span>"
            not_head_no.Text = i
            rptnotifocation.DataSource = nt
            rptnotifocation.DataBind()
        End If
        nt = db.gettable("select * from main_admin_master where ma_id=" + Session("ma_id").ToString)
        ppic.ImageUrl = "./profile_image/" + nt.Rows(0)("pic")
        uname.Text = nt.Rows(0)("name").ToString

    End Sub
End Class

