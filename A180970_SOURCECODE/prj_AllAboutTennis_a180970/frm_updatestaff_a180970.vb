Public Class frm_updatestaff_a180970

    Dim current_id As String
    Private Sub btn_back_Click(sender As Object, e As EventArgs) Handles btn_back.Click
        frm_mainmenu_a180970.Show()
        Me.Hide()
    End Sub

    Private Sub frm_updatestaff_a180970_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        refresh_grid()

        txt_id.Text = generate_staff_id()
    End Sub
    Private Sub refresh_grid()
        Dim mysql As String = "SELECT * FROM TBL_STAFF_A180970"

        Dim mydatatable As New DataTable

        Dim myreader As New OleDb.OleDbDataAdapter(mysql, myconnection)

        myreader.Fill(mydatatable)

        grd_staff.DataSource = mydatatable

    End Sub
    Private Sub get_current_code()
        Dim current_row As Integer = grd_staff.CurrentRow.Index
        current_id = grd_staff(0, current_row).Value

        txt_id.Text = current_id
        txt_name.Text = grd_staff(1, current_row).Value
        txt_contact.Text = grd_staff(2, current_row).Value

    End Sub
    Private Sub clear_fields()
        txt_id.Text = generate_staff_id()
        txt_name.Text = ""
        txt_contact.Text = ""
    End Sub

    Private Function generate_staff_id() As String

        Dim laststaffid As String = run_sql_query("SELECT MAX(FLD_STAFF_ID) AS LASTSTAFFID FROM TBL_STAFF_A180970").Rows(0).Item("LASTSTAFFID")

        Dim newstaffid As String = "S" & Mid(laststaffid, 2) + 1

        Return newstaffid

    End Function

    Private Sub btn_insert_Click(sender As Object, e As EventArgs) Handles btn_insert.Click
        Dim mysql As String = "INSERT INTO TBL_STAFF_A180970 VALUES ('" & txt_id.Text & "','" & txt_name.Text & "','" & txt_contact.Text & "')"

        Dim mywriter As New OleDb.OleDbCommand(mysql, myconnection2)

        Try

            mywriter.Connection.Open()
            mywriter.ExecuteNonQuery()
            mywriter.Connection.Close()

            grd_staff.DataSource = run_sql_query("SELECT * FROM TBL_STAFF_A180970")

            txt_id.Text = generate_staff_id()
            txt_name.Text = ""
            txt_contact.Text = ""

            MsgBox("You have successfully inserted new staff detail.")

        Catch ex As Exception

            Beep()
            MsgBox("There is a mistake in the data you entered, as shown below" & vbCrLf & vbCrLf & ex.Message)

            mywriter.Connection.Close()

        End Try
    End Sub

    Private Sub btn_update_Click(sender As Object, e As EventArgs) Handles btn_update.Click

        run_sql_command("UPDATE TBL_STAFF_A180970 SET FLD_STAFF_NAME='" & txt_name.Text & "', FLD_CONTACT='" & txt_contact.Text & "'  WHERE FLD_STAFF_ID='" & current_id & "'")

        Beep()
        MsgBox("You have successfully updated the staff detail """ & current_id & """.")

        refresh_grid()
        clear_fields()
        get_current_code()

    End Sub

    Private Sub btn_delete_Click(sender As Object, e As EventArgs) Handles btn_delete.Click
        Dim delete_confirmation = MsgBox("Are you sure you would like to delete the staff """ & current_id & """?", MsgBoxStyle.YesNo)

        If delete_confirmation = MsgBoxResult.Yes Then
            run_sql_command("DELETE FROM TBL_STAFF_A180970 WHERE FLD_STAFF_ID='" & current_id & "'")

            Beep()
            MsgBox("The staff """ & current_id & """ has been successfully deleted.")

            refresh_grid()
            clear_fields()
            get_current_code()
        End If
    End Sub

    Private Sub grd_staff_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles grd_staff.CellClick
        get_current_code()
    End Sub
End Class