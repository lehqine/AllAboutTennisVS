Public Class frm_updateproduct_a180970
    Dim current_id As String
    Dim defaultpicture As String = Application.StartupPath & "\pictures\nophoto.jpg"
    Dim current_pic_path As String
    Private Sub frm_updateproduct_a180970_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        refresh_grid()

        txt_id.Text = generate_product_id()

        txt_location.Text = defaultpicture
        pic_product.BackgroundImage = Image.FromFile(defaultpicture)
    End Sub
    Private Sub refresh_grid()
        Dim mysql As String = "SELECT * FROM TBL_PRODUCTS_A180970 ORDER BY FLD_PRODUCT_ID"
        Dim mydatatable As New DataTable
        Dim myreader As New OleDb.OleDbDataAdapter(mysql, myconnection2)
        myreader.Fill(mydatatable)
        grd_product.DataSource = mydatatable
    End Sub

    Private Sub clear_fields()
        txt_id.Text = ""
        txt_name.Text = ""
        txt_brand.Text = ""
        txt_quantity.Text = ""
        txt_type.Text = ""
        txt_price.Text = ""
        txt_desc.Text = ""
    End Sub

    Private Sub get_current_code()

        Dim current_row As Integer = grd_product.CurrentRow.Index

        current_id = grd_product(0, current_row).Value

        txt_id.Text = current_id
        txt_name.Text = grd_product(1, current_row).Value
        txt_price.Text = grd_product(2, current_row).Value
        txt_brand.Text = grd_product(3, current_row).Value
        txt_type.Text = grd_product(4, current_row).Value
        txt_quantity.Text = grd_product(5, current_row).Value
        txt_desc.Text = grd_product(6, current_row).Value

        Try
            Using fs As New System.IO.FileStream("pictures\" & current_id & ".jpg", IO.FileMode.Open, IO.FileAccess.Read)
                pic_product.BackgroundImage = System.Drawing.Image.FromStream(fs)
            End Using

            txt_location.Text = Application.StartupPath & "\pictures\" & current_id & ".jpg"
        Catch ex As Exception
            pic_product.BackgroundImage = Image.FromFile(defaultpicture)
            txt_location.Text = defaultpicture
        End Try

        current_pic_path = txt_location.Text

    End Sub

    Private Function generate_product_id() As String

        Dim lastproductid As String = run_sql_query("SELECT MAX(FLD_PRODUCT_ID) AS LASTPRODUCTID FROM TBL_PRODUCTS_A180970").Rows(0).Item("LASTPRODUCTID")

        Dim newproductid As String = "P" & Mid(lastproductid, 2) + 1

        Return newproductid

    End Function

    Private Sub grd_product_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles grd_product.CellClick

        get_current_code()

    End Sub

    Private Sub btn_update_Click(sender As Object, e As EventArgs) Handles btn_update.Click
        run_sql_command("UPDATE TBL_PRODUCTS_A180970 SET FLD_PRODUCT_NAME='" & txt_name.Text & "', FLD_PRICE ='" & txt_price.Text &
                        "', FLD_BRAND = '" & txt_brand.Text & "', FLD_TYPE ='" & txt_type.Text & "', FLD_QUANTITY ='" & txt_quantity.Text &
                        "', FLD_DESCRIPTION = '" & txt_desc.Text & "' WHERE FLD_PRODUCT_ID = '" & current_id & "'")

        Try

            If Not txt_location.Text.Equals(current_pic_path) Then

                If current_pic_path.Equals(defaultpicture) Then
                    My.Computer.FileSystem.CopyFile(txt_location.Text, "pictures\" & current_id & ".jpg")
                Else
                    FileIO.FileSystem.DeleteFile("pictures\" & current_id & ".jpg")
                    My.Computer.FileSystem.CopyFile(txt_location.Text, "pictures\" & current_id & ".jpg")
                End If

            End If

        Catch ex As Exception

            Beep()
            MsgBox("There is a mistake in the data you entered, as shown below" & vbCrLf & vbCrLf & ex.Message)

        End Try

        Beep()
        MsgBox("You have successfully updated the product """ & current_id & """.")

        refresh_grid()
        clear_fields()
        get_current_code()
    End Sub

    Private Sub btn_delete_Click(sender As Object, e As EventArgs) Handles btn_delete.Click
        Dim delete_confirmation = MsgBox("Are you sure you would like to delete the product """ & current_id & """?", MsgBoxStyle.YesNo)

        If delete_confirmation = MsgBoxResult.Yes Then
            run_sql_command("DELETE FROM TBL_PRODUCTS_A180970 WHERE FLD_PRODUCT_ID='" & current_id & "'")

            Try
                If Not txt_location.Text.Equals(defaultpicture) Then
                    FileIO.FileSystem.DeleteFile("pictures\" & current_id & ".jpg")
                End If
            Catch ex As Exception
                Beep()
                MsgBox("There is a mistake in the data you entered, as shown below" & vbCrLf & vbCrLf & ex.Message)
            End Try

            MsgBox("The product """ & current_id & """ has been successfully deleted.")

            refresh_grid()
            clear_fields()
            get_current_code()
        End If
    End Sub

    Private Sub btn_back_Click(sender As Object, e As EventArgs) Handles btn_back.Click
        frm_mainmenu_a180970.Show()
        Me.Hide()
    End Sub

    Private Sub btn_uploadpic_Click(sender As Object, e As EventArgs) Handles btn_uploadpic.Click
        Dim mydesktop As String = My.Computer.FileSystem.SpecialDirectories.Desktop

        OpenFileDialog1.InitialDirectory = mydesktop
        OpenFileDialog1.FileName = ""
        OpenFileDialog1.Filter = "JPG files (*.jpg)|*.jpg"
        OpenFileDialog1.ShowDialog()

        pic_product.BackgroundImage = Image.FromFile(OpenFileDialog1.FileName)
        txt_location.Text = OpenFileDialog1.FileName
    End Sub

    Private Sub btn_insert_Click(sender As Object, e As EventArgs) Handles btn_insert.Click
        Dim mysql As String = "INSERT INTO TBL_PRODUCTS_A180970 VALUES ('" & txt_id.Text & "','" & txt_name.Text & "','" & txt_price.Text & "','" & txt_brand.Text & "','" & txt_type.Text & "','" & txt_quantity.Text & "','" & txt_desc.Text & "')"

        Dim mywriter As New OleDb.OleDbCommand(mysql, myconnection2)

        Try

            mywriter.Connection.Open()
            mywriter.ExecuteNonQuery()
            mywriter.Connection.Close()

            My.Computer.FileSystem.CopyFile(txt_location.Text, "pictures\" & txt_id.Text & ".jpg")

            grd_product.DataSource = run_sql_query("SELECT * FROM TBL_PRODUCTS_A180970 ORDER BY FLD_PRODUCT_ID")

            txt_id.Text = generate_product_id()
            txt_name.Text = ""
            txt_brand.Text = ""
            txt_quantity.Text = ""
            txt_type.Text = ""
            txt_price.Text = ""
            txt_desc.Text = ""
            txt_location.Text = defaultpicture
            pic_product.BackgroundImage = Image.FromFile(defaultpicture)

            MsgBox("You have successfully inserted new product detail.")

        Catch ex As Exception

            Beep()
            MsgBox("There is a mistake in the data you entered, as shown below" & vbCrLf & vbCrLf & ex.Message)

            mywriter.Connection.Close()

        End Try
    End Sub
End Class