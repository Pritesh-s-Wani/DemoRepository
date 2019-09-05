
Partial Class ma_profile_view
    Inherits System.Web.UI.Page
    Dim db As New dbconnection
    Dim dt As New System.Data.DataTable
    Dim qry As String
    'Dim ma_id As String = Request.QueryString("ma_id")
    Protected Sub Page_Load(sender As Object, e As EventArgs) Handles Me.Load
        If IsPostBack = False Then


            bindfrmvew()
        End If
    End Sub
    Public Sub bindfrmvew()
        qry = "select * from main_admin_master where ma_id=" + Request.QueryString("ma_id").ToString
        dt = db.gettable(qry)
        frmview_myprofile.DataSource = dt
        frmview_myprofile.DataBind()

    End Sub

    Protected Sub frmview_myprofile_ItemUpdating(sender As Object, e As FormViewUpdateEventArgs) Handles frmview_myprofile.ItemUpdating
        Dim name, mail, cno, crpass As TextBox
        name = CType(frmview_myprofile.FindControl("txt_name"), TextBox)
        mail = CType(frmview_myprofile.FindControl("txt_email"), TextBox)
        cno = CType(frmview_myprofile.FindControl("txt_cno"), TextBox)
        crpass = CType(frmview_myprofile.FindControl("newpass"), TextBox)
        Dim qry1 As String = "update main_admin_master set name='" + name.Text + "',email='" + mail.Text + "',cno=" + cno.Text
        If Not crpass.Text = "" Then
            qry1 += ",pass='" + crpass.Text + "'"
        End If
        Dim fup As FileUpload
        fup = CType(frmview_myprofile.FindControl("ma_pic_edit"), FileUpload)
        If fup.HasFile = True Then
            If fup.PostedFile.ContentType = "image/jpg" Or fup.PostedFile.ContentType = "image/jpeg" Or fup.PostedFile.ContentType = "image/png" Then
                Dim len As Integer
                len = 1024 * 1024
                If fup.PostedFile.ContentLength < len Then
                    Dim p As String
                    Dim hdn As HiddenField
                    hdn = CType(frmview_myprofile.FindControl("hdn"), HiddenField)
                    p = Server.MapPath("") + "\profile_image\" + hdn.Value.ToString
                    If System.IO.File.Exists(p) Then
                        System.IO.File.Delete(p)
                    End If
                    Dim path As String
                    path = Server.MapPath("") + "\profile_image\" + fup.FileName.ToString
                    fup.SaveAs(path)
                    qry1 += ",pic='" + fup.FileName.ToString + "'"
                Else
                End If
            Else
            End If
        Else
        End If
        qry1 += " where ma_id=" + Request.QueryString("ma_id").ToString
        db.excecutequery(qry1)
        frmview_myprofile.ChangeMode(FormViewMode.ReadOnly)
        bindfrmvew()
    End Sub


    Protected Sub frmview_myprofile_ModeChanging(sender As Object, e As FormViewModeEventArgs) Handles frmview_myprofile.ModeChanging
        frmview_myprofile.ChangeMode(e.NewMode)
        bindfrmvew()

    End Sub
End Class
