Imports System.Data.OleDb

Public Class frm_invoice_a180970
    Dim current_code As String
    Dim current_customer As String
    Dim current_staff As String
    Dim current_date As String
    Private Sub frm_invoice_a180970_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim mysql As String = "SELECT FLD_ORDER_ID FROM TBL_ORDER_A180970 ORDER BY FLD_ORDER_ID"
        Dim mydatatable As New DataTable
        Dim myreader As New OleDb.OleDbDataAdapter(mysql, myconnection)
        myreader.Fill(mydatatable)

        lst_order.DataSource = mydatatable
        lst_order.DisplayMember = "FLD_ORDER_ID"

        refresh_text(lst_order.Text)
    End Sub

    Private Sub refresh_text(id As String)

        Dim mysql As String = "SELECT * FROM TBL_ORDER_A180970 WHERE FLD_ORDER_ID='" & id & "'"
        Dim mydatatable As New DataTable
        Dim myreader As New OleDb.OleDbDataAdapter(mysql, myconnection)
        myreader.Fill(mydatatable)

        lbl_invoiceno.Text = mydatatable.Rows(0).Item("FLD_ORDER_ID")
        lbl_date.Text = mydatatable.Rows(0).Item("FLD_ORDER_DATE")
        lbl_staff.Text = mydatatable.Rows(0).Item("FLD_STAFF_ID")
        lbl_cust.Text = mydatatable.Rows(0).Item("FLD_CUSTOMER_ID")

        get_current_product_list()

    End Sub

    Private Sub get_current_product_list()
        Dim total_amt As Double
        Dim mysql As String
        Try
            grd_details.Rows.Clear()
            total_amt = 0
            Dim newrow As Integer

            grd_details.ColumnCount = 6

            grd_details.Columns(0).HeaderText = "Order ID"
            grd_details.Columns(1).HeaderText = "Product ID"
            grd_details.Columns(2).HeaderText = "Product Name"
            grd_details.Columns(3).HeaderText = "Quantity"
            grd_details.Columns(4).HeaderText = "Price (RM)"
            grd_details.Columns(5).HeaderText = "Subtotal (RM)"

            grd_details.Columns(0).Width = "50"
            grd_details.Columns(1).Width = "50"
            grd_details.Columns(2).Width = "300"
            grd_details.Columns(3).Width = "50"
            grd_details.Columns(4).Width = "50"
            grd_details.Columns(5).Width = "50"

            grd_details.Columns(0).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            grd_details.Columns(3).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            grd_details.Columns(4).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            grd_details.Columns(5).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight

            mysql = "SELECT TBL_ORDER_DETAIL_A180970.FLD_ORDER_ID AS order_id, TBL_ORDER_DETAIL_A180970.FLD_PRICE AS price, " &
            "TBL_ORDER_DETAIL_A180970.FLD_QUANTITY AS quantity, TBL_ORDER_DETAIL_A180970.FLD_PRODUCT_ID AS prod_id, TBL_PRODUCTS_A180970.FLD_PRODUCT_NAME AS prod_name " &
            "FROM TBL_ORDER_DETAIL_A180970, TBL_PRODUCTS_A180970 " &
            "WHERE TBL_ORDER_DETAIL_A180970.FLD_PRODUCT_ID = TBL_PRODUCTS_A180970.FLD_PRODUCT_ID AND " &
            "TBL_ORDER_DETAIL_A180970.FLD_ORDER_ID = '" & lst_order.Text & "'"

            Dim reader As OleDbDataReader
            Dim con As OleDb.OleDbConnection = Nothing
            Dim cmd As OleDb.OleDbCommand = Nothing
            con = New OleDb.OleDbConnection()
            con.ConnectionString = myconnection
            con.Open()
            cmd = New OleDb.OleDbCommand(mysql, con)
            reader = cmd.ExecuteReader()
            While (reader.Read())
                grd_details.RowCount = grd_details.RowCount + 1

                newrow = grd_details.RowCount - 1

                grd_details(0, newrow).Value = reader.Item(0)
                grd_details(1, newrow).Value = reader.Item(3)
                grd_details(2, newrow).Value = reader.Item(4)
                grd_details(3, newrow).Value = reader.Item(2)
                grd_details(4, newrow).Value = reader.Item(1)

                grd_details(5, newrow).Value = Double.Parse(reader.Item(1)) * Int32.Parse(reader.Item(2))
                total_amt = total_amt + (Double.Parse(reader.Item(1)) * Int32.Parse(reader.Item(2)))
            End While

            lbl_totalprice.Text = "RM " & total_amt

            reader.Close()
            cmd.Dispose()
            con.Close()

        Catch ex As Exception
            'MsgBox("Error, please try again or contact system administrator", vbExclamation, "Tools DIY")
        End Try

    End Sub

    Private Sub btn_back_Click(sender As Object, e As EventArgs) Handles btn_back.Click
        frm_mainmenu_a180970.Show()
        Me.Hide()
    End Sub

    Private Sub lst_order_Click(sender As Object, e As EventArgs) Handles lst_order.Click
        refresh_text(lst_order.Text)
    End Sub
End Class