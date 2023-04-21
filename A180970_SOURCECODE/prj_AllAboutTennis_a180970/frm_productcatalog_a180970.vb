Public Class frm_productcatalog_a180970
    Private Sub frm_productcatalog_a180970_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim mysql As String = "SELECT FLD_PRODUCT_ID FROM TBL_PRODUCTS_A180970 ORDER BY FLD_PRODUCT_ID"
        Dim mydatatable As New DataTable
        Dim myreader As New OleDb.OleDbDataAdapter(mysql, myconnection)
        myreader.Fill(mydatatable)

        lst_product.DataSource = mydatatable
        lst_product.DisplayMember = "FLD_PRODUCT_ID"

        refresh_text(lst_product.Text)

    End Sub
    Private Sub refresh_text(id As String)

        Dim mysql As String = "SELECT * FROM TBL_PRODUCTS_A180970 WHERE FLD_PRODUCT_ID='" & id & "'"
        Dim mydatatable As New DataTable
        Dim myreader As New OleDb.OleDbDataAdapter(mysql, myconnection)
        myreader.Fill(mydatatable)

        txt_id.Text = mydatatable.Rows(0).Item("FLD_PRODUCT_ID")
        txt_name.Text = mydatatable.Rows(0).Item("FLD_PRODUCT_NAME")
        txt_price.Text = mydatatable.Rows(0).Item("FLD_PRICE")
        txt_brand.Text = mydatatable.Rows(0).Item("FLD_BRAND")
        txt_type.Text = mydatatable.Rows(0).Item("FLD_TYPE")
        txt_quantity.Text = mydatatable.Rows(0).Item("FLD_QUANTITY")
        txt_desc.Text = mydatatable.Rows(0).Item("FLD_DESCRIPTION")

        Try
            pic_product.BackgroundImage = Image.FromFile("pictures/" & txt_id.Text & ".jpg")
        Catch ex As Exception
            pic_product.BackgroundImage = Image.FromFile("pictures/nophoto.jpg")
        End Try

    End Sub

    Private Sub lst_product_MouseClick(sender As Object, e As MouseEventArgs) Handles lst_product.MouseClick

        refresh_text(lst_product.Text)

    End Sub

    Private Sub btn_back_Click(sender As Object, e As EventArgs) Handles btn_back.Click

        frm_mainmenu_a180970.Show()
        Me.Hide()

    End Sub

    Private Sub frm_productcatalog_a180970_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        refresh_text(lst_product.Text)
    End Sub
End Class