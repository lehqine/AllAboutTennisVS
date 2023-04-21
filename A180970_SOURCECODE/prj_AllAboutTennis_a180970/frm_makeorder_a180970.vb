Public Class frm_makeorder_a180970
    Dim total_amt As Double
    Dim get_price As Double
    Dim order_fail As Boolean
    Private Sub frm_makeorder_a180970_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lbl_date.Text = Date.Now
        txt_orderid.Text = generate_orderid()

        total_amt = 0

        Dim mysql As String = "SELECT FLD_CUSTOMER_ID FROM TBL_CUSTOMER_A180970 ORDER BY FLD_CUSTOMER_ID"
        Dim mydatatable As New DataTable
        Dim myreader As New OleDb.OleDbDataAdapter(mysql, myconnection)
        myreader.Fill(mydatatable)

        lst_cust.DataSource = mydatatable
        lst_cust.DisplayMember = "FLD_CUSTOMER_ID"

        cust_refresh_text(lst_cust.Text)

        Dim mysql1 As String = "SELECT FLD_STAFF_ID FROM TBL_STAFF_A180970 ORDER BY FLD_STAFF_ID"
        Dim mydatatable1 As New DataTable
        Dim myreader1 As New OleDb.OleDbDataAdapter(mysql1, myconnection)
        myreader1.Fill(mydatatable1)

        lst_staff.DataSource = mydatatable1
        lst_staff.DisplayMember = "FLD_STAFF_ID"

        staff_refresh_text(lst_staff.Text)

        Dim mysql2 As String = "SELECT FLD_PRODUCT_ID FROM TBL_PRODUCTS_A180970 ORDER BY FLD_PRODUCT_ID"
        Dim mydatatable2 As New DataTable
        Dim myreader2 As New OleDb.OleDbDataAdapter(mysql2, myconnection)
        myreader2.Fill(mydatatable2)

        lst_product.DataSource = mydatatable2
        lst_product.DisplayMember = "FLD_PRODUCT_ID"

        product_refresh_text(lst_product.Text)

        grd_details.ColumnCount = 5

        grd_details.Columns(0).Width = "60"
        grd_details.Columns(1).Width = "350"
        grd_details.Columns(2).Width = "120"
        grd_details.Columns(3).Width = "50"
        grd_details.Columns(4).Width = "60"

        grd_details.Columns(0).HeaderText = "Product ID"
        grd_details.Columns(1).HeaderText = "Product Name"
        grd_details.Columns(2).HeaderText = "Price per unit (RM)"
        grd_details.Columns(3).HeaderText = "Quantity"
        grd_details.Columns(4).HeaderText = "Total (RM)"
    End Sub

    Private Sub cust_refresh_text(id As String)

        Dim mysql As String = "SELECT * FROM TBL_CUSTOMER_A180970 WHERE FLD_CUSTOMER_ID='" & id & "'"
        Dim mydatatable As New DataTable
        Dim myreader As New OleDb.OleDbDataAdapter(mysql, myconnection)
        myreader.Fill(mydatatable)

        txt_custid.Text = mydatatable.Rows(0).Item("FLD_CUSTOMER_ID")
        txt_custname.Text = mydatatable.Rows(0).Item("FLD_CUSTOMER_NAME")
        txt_custcontact.Text = mydatatable.Rows(0).Item("FLD_CONTACT")

    End Sub
    Private Sub staff_refresh_text(id As String)

        Dim mysql1 As String = "SELECT * FROM TBL_STAFF_A180970 WHERE FLD_STAFF_ID='" & id & "'"
        Dim mydatatable1 As New DataTable
        Dim myreader1 As New OleDb.OleDbDataAdapter(mysql1, myconnection)
        myreader1.Fill(mydatatable1)

        txt_staffid.Text = mydatatable1.Rows(0).Item("FLD_STAFF_ID")
        txt_staffname.Text = mydatatable1.Rows(0).Item("FLD_STAFF_NAME")
        txt_staffcontact.Text = mydatatable1.Rows(0).Item("FLD_CONTACT")

    End Sub
    Private Sub product_refresh_text(id As String)

        Dim mysql2 As String = "SELECT * FROM TBL_PRODUCTS_A180970 WHERE FLD_PRODUCT_ID='" & id & "'"
        Dim mydatatable2 As New DataTable
        Dim myreader2 As New OleDb.OleDbDataAdapter(mysql2, myconnection)
        myreader2.Fill(mydatatable2)

        txt_proid.Text = mydatatable2.Rows(0).Item("FLD_PRODUCT_ID")
        txt_proname.Text = mydatatable2.Rows(0).Item("FLD_PRODUCT_NAME")
        txt_price.Text = mydatatable2.Rows(0).Item("FLD_PRICE")
        txt_quantity.Text = "1"

        Try
            pic_product.BackgroundImage = Image.FromFile("pictures/" & id & ".jpg")
        Catch ex As Exception
            pic_product.BackgroundImage = Image.FromFile("pictures/nophoto.jpg")
        End Try

    End Sub
    Private Sub clear_textfield()
        txt_orderid.Text = generate_orderid()
        txt_proid.Text = ""
        txt_proname.Text = ""
        txt_price.Text = ""
        txt_quantity.Text = "1"
        txt_custid.Text = ""
        txt_custname.Text = ""
        txt_custcontact.Text = ""
        txt_staffid.Text = ""
        txt_staffname.Text = ""
        txt_staffname.Text = ""
        txt_staffcontact.Text = ""
        txt_totalprice.Text = ""
        total_amt = 0
        grd_details.Rows.Clear()
    End Sub
    Private Function generate_orderid() As String
        Dim neworderid As String = ""
        Try
            Dim lastorderid As String = run_sql_query("SELECT MAX(FLD_ORDER_ID) AS LASTORDER FROM TBL_ORDER_A180970").Rows(0).Item("LASTORDER")

            neworderid = "O" & Mid(lastorderid, 2) + 1
        Catch ex As Exception
            neworderid = "O1"
        End Try

        Return neworderid
    End Function

    Private Sub tm_time_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tm_time.Tick
        lbl_date.Text = Date.Now
    End Sub

    Private Sub btn_insertproduct_Click(sender As Object, e As EventArgs) Handles btn_insertproduct.Click

        If txt_quantity.Text <> 0 Then
            grd_details.RowCount = grd_details.RowCount + 1

            Dim newrow = grd_details.RowCount - 1

            grd_details(0, newrow).Value = txt_proid.Text
            grd_details(1, newrow).Value = txt_proname.Text
            grd_details(2, newrow).Value = txt_price.Text
            grd_details(3, newrow).Value = txt_quantity.Text
            grd_details(4, newrow).Value = txt_price.Text * txt_quantity.Text
            total_amt = total_amt + (txt_price.Text * txt_quantity.Text)
            txt_totalprice.Text = total_amt

        Else
            MsgBox("Please enter quantity", vbInformation, "All About Tennis")
        End If
    End Sub

    Private Sub lst_cust_Click(sender As Object, e As EventArgs) Handles lst_cust.Click
        cust_refresh_text(lst_cust.Text)
    End Sub

    Private Sub lst_staff_Click(sender As Object, e As EventArgs) Handles lst_staff.Click
        staff_refresh_text(lst_staff.Text)
    End Sub

    Private Sub lst_product_Click(sender As Object, e As EventArgs) Handles lst_product.Click
        product_refresh_text(lst_product.Text)
    End Sub

    Private Sub btn_back_Click(sender As Object, e As EventArgs) Handles btn_back.Click
        frm_mainmenu_a180970.Show()
        Me.Hide()
    End Sub

    Private Sub btn_deleteproduct_Click(sender As Object, e As EventArgs) Handles btn_deleteproduct.Click
        Dim confirm_deletion = MsgBoxResult.No
        Try
            confirm_deletion = MsgBox("Are you sure want to delete " & grd_details(1, grd_details.CurrentRow.Index).Value() & "?", MsgBoxStyle.YesNo + vbExclamation, "All About Tennis")
            get_price = Double.Parse(grd_details(4, grd_details.CurrentRow.Index).Value())

        Catch ex As Exception
            'DO nothing
        End Try

        Try
            If confirm_deletion = MsgBoxResult.Yes Then
                grd_details.Rows.Remove(grd_details.CurrentRow)
                total_amt = total_amt - get_price
                txt_totalprice.Text = total_amt
            End If
        Catch ex As Exception
            'do nothing
        End Try
    End Sub

    Private Sub btn_makeorder_Click(sender As Object, e As EventArgs) Handles btn_makeorder.Click
        If check_textfield() = True Then
            record_order()
            If order_fail = False Then
                MsgBox("Order saved", vbInformation, "All About Tennis")
                clear_textfield()
            End If
        Else
            MsgBox("Order failed", vbExclamation, "All About Tennis")
        End If
    End Sub
    Function check_textfield() As Boolean
        If Trim(txt_orderid.Text) <> "" And Trim(txt_custid.Text) <> "" And Trim(txt_staffname.Text) <> "" And grd_details.Rows.Count > 0 Then
            Return True
        End If
        Return False
    End Function

    Private Sub record_order()
        Dim mytransaction As OleDb.OleDbTransaction
        'Dim mysql As String
        order_fail = True
        myconnection2.Open()

        mytransaction = myconnection2.BeginTransaction

        Try
            Dim mysql1 As String = "INSERT INTO TBL_ORDER_A180970 (FLD_ORDER_ID, FLD_CUSTOMER_ID,FLD_STAFF_ID, FLD_ORDER_DATE) VALUES ('" & txt_orderid.Text & "','" & txt_custid.Text & "','" & txt_staffid.Text & "',#" & Date.Today.ToShortDateString & "#)"
            Dim mywriter2 As New OleDb.OleDbCommand(mysql1, myconnection2, mytransaction)
            mywriter2.ExecuteNonQuery()

            For i As Integer = 0 To grd_details.RowCount - 1

                Dim productid As String = grd_details(0, i).Value
                Dim productprice As String = grd_details(2, i).Value
                Dim productquantity As String = grd_details(3, i).Value

                Dim mysql2 As String = "INSERT INTO TBL_ORDER_DETAIL_A180970 (FLD_ORDER_ID, FLD_PRODUCT_ID, FLD_QUANTITY, FLD_PRICE) VALUES ('" & txt_orderid.Text & "','" & productid & "'," & Int32.Parse(productquantity) & "," & Double.Parse(productprice) & ")"

                Dim mywriter As New OleDb.OleDbCommand(mysql2, myconnection2, mytransaction)

                mywriter.ExecuteNonQuery()
            Next

            mytransaction.Commit()

            myconnection2.Close()
            order_fail = False

            Beep()
        Catch ex As Exception
            myconnection2.Close()
            MsgBox("Please complete the form", vbExclamation, "All About Tennis")
        End Try

    End Sub

    Private Sub btn_vieworder_Click(sender As Object, e As EventArgs) Handles btn_vieworder.Click
        frm_invoice_a180970.Show()
        Me.Hide()
    End Sub
End Class