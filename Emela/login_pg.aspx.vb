
Partial Class login_pg
    Inherits System.Web.UI.Page

    Protected Sub btnlogin_Click(sender As Object, e As EventArgs) Handles btnlogin.Click
        Dim db As New dbconnection
        Dim dt As System.Data.DataTable = db.gettable("select * from main_manager_master where email='" + txtmail.Text + "' and pass='" + txtpass.Text + "'")
        If dt.Rows.Count > 0 Then
            Session.Add("mm_id", dt.Rows(0)("mm_id").ToString)
            Response.Redirect(dt.Rows(0)("mm_id").ToString)
        End If
        dt = db.gettable("select * from main_admin_master where email='" + txtmail.Text + "' and pass='" + txtpass.Text + "'")
        If dt.Rows.Count > 0 Then
            Session.Add("ma_id", dt.Rows(0)("ma_id").ToString)
            Response.Redirect("main_admin_blankpg.aspx")
            'dt.Rows(0)("ma_id").ToString
        End If
        dt = db.gettable("select * from dept_manager_master where email='" + txtmail.Text + "' and pass='" + txtpass.Text + "'")
        If dt.Rows.Count > 0 Then
            Session.Add("dm_id", dt.Rows(0)("dm_id").ToString)
            Response.Redirect(dt.Rows(0)("dm_id").ToString)
        End If
        dt = db.gettable("select * from dept_admin_master where email='" + txtmail.Text + "' and pass='" + txtpass.Text + "'")
        If dt.Rows.Count > 0 Then
            Session.Add("da_id", dt.Rows(0)("da_id").ToString)
            Response.Redirect(dt.Rows(0)("da_id").ToString)
        End If
        dt = db.gettable("select * from clerk_master where email='" + txtmail.Text + "' and pass='" + txtpass.Text + "'")
        If dt.Rows.Count > 0 Then
            Session.Add("clerk_id", dt.Rows(0)("clerk_id").ToString)
            Response.Redirect(dt.Rows(0)("clerk_id").ToString)
        End If
        dt = db.gettable("select * from cust_master where email='" + txtmail.Text + "' and pass='" + txtpass.Text + "'")
        If dt.Rows.Count > 0 Then
            Session.Add("cust_id", dt.Rows(0)("cust_id").ToString)
            Response.Redirect(dt.Rows(0)("cust_id").ToString)
        End If
        dt = db.gettable("select * from business_master where user_id='" + txtmail.Text + "' and pass='" + txtpass.Text + "'")
        If dt.Rows.Count > 0 Then
            Session.Add("business_id", dt.Rows(0)("business_id").ToString)
            Response.Redirect(dt.Rows(0)("business_id").ToString)
        End If
        lblerr.Text = "plz enter correct id pass or create new a/c"
    End Sub
End Class
