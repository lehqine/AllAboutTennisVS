Public Class frm_updatecustomer_a180970
    Dim current_id As String
    Private Sub btn_back_Click(sender As Object, e As EventArgs) Handles btn_back.Click
        frm_mainmenu_a180970.Show()
        Me.Hide()
    End Sub
    Private Sub refresh_grid()
        Dim mysql As String = "SELECT * FROM TBL_CUSTOMER_A180970"

        Dim mydatatable As New DataTable

        Dim myreader As New OleDb.OleDbDataAdapter(mysql, myconnection)

        myreader.Fill(mydatatable)

        grd_customer.DataSource = mydatatable

    End Sub
    Private Sub get_current_code()
        Dim current_row As Integer = grd_customer.CurrentRow.Index
        current_id = grd_customer(0, current_row).Value

        txt_id.Text = current_id
        txt_name.Text = grd_customer(1, current_row).Value
        txt_contact.Text = grd_customer(2, current_row).Value

    End Sub
    Private Sub clear_fields()
        txt_id.Text = generate_customer_id()
        txt_name.Text = ""
        txt_contact.Text = ""
    End Sub

    Private Sub btn_insert_Click(sender As Object, e As EventArgs) Handles btn_insert.Click
        Dim mysql As String = "INSERT INTO TBL_CUSTOMER_A180970 VALUES ('" & txt_id.Text & "','" & txt_name.Text & "','" & txt_contact.Text & "')"

        Dim mywriter As New OleDb.OleDbCommand(mysql, myconnection2)

        Try

            mywriter.Connection.Open()
            mywriter.ExecuteNonQuery()
            mywriter.Connection.Close()

            grd_customer.DataSource = run_sql_query("SELECT * FROM TBL_CUSTOMER_A180970")

            txt_id.Text = generate_customer_id()
            txt_name.Text = ""
            txt_contact.Text = ""

            MsgBox("You have successfully inserted new customer detail.")

        Catch ex As Exception

            Beep()
            MsgBox("There is a mistake in the data you entered, as shown below" & vbCrLf & vbCrLf & ex.Message)

            mywriter.Connection.Close()

        End Try
    End Sub

    Private Sub btn_delete_Click(sender As Object, e As EventArgs) Handles btn_delete.Click
        Dim delete_confirmation = MsgBox("Are you sure you would like to delete the customer """ & current_id & """?", MsgBoxStyle.YesNo)

        If delete_confirmation = MsgBoxResult.Yes Then
            run_sql_command("DELETE FROM TBL_CUSTOMER_A180970 WHERE FLD_CUSTOMER_ID='" & current_id & "'")

            Beep()
            MsgBox("The customer """ & current_id & """ has been successfully deleted.")

            refresh_grid()
            clear_fields()
            get_current_code()
        End If
    End Sub

    Private Sub btn_update_Click(sender As Object, e As EventArgs) Handles btn_update.Click
        run_sql_command("UPDATE TBL_CUSTOMER_A180970 SET FLD_CUSTOMER_NAME='" & txt_name.Text & "', FLD_CONTACT='" & txt_contact.Text & "'  WHERE FLD_CUSTOMER_ID='" & current_id & "'")

        Beep()
        MsgBox("You have successfully updated the customer detail """ & current_id & """.")

        refresh_grid()
        clear_fields()
        get_current_code()
    End Sub

    Private Sub grd_customer_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles grd_customer.CellClick
        get_current_code()
    End Sub

    Private Sub frm_updatecustomer_a180970_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        refresh_grid()

        txt_id.Text = generate_customer_id()
    End Sub
    Private Function generate_customer_id() As String

        Dim lastcustid As String = run_sql_query("SELECT MAX(FLD_CUSTOMER_ID) AS LASTCUSTID FROM TBL_CUSTOMER_A180970").Rows(0).Item("LASTCUSTID")

        Dim newcustid As String = "C" & Mid(lastcustid, 2) + 1

        Return newcustid

    End Function
End Class