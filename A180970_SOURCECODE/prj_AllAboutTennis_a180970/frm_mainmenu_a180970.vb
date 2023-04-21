Public Class frm_mainmenu_a180970
    Private Sub frm_mainmenu_a180970_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim current_date As String = Date.Now

        lbl_date.Text = current_date

    End Sub

    Private Sub btn_brand_Click(sender As Object, e As EventArgs) Handles btn_brand.Click
        frm_brandlist_a180970.Show()
        Me.Hide()
    End Sub

    Private Sub btn_customer_Click(sender As Object, e As EventArgs) Handles btn_customer.Click
        frm_customerlist_a180970.Show()
        Me.Hide()
    End Sub

    Private Sub btn_orderdetail_Click(sender As Object, e As EventArgs) Handles btn_orderdetail.Click
        frm_orderdetail_a180970.Show()
        Me.Hide()
    End Sub

    Private Sub btn_order_Click(sender As Object, e As EventArgs) Handles btn_order.Click
        frm_orderlist_a180970.Show()
        Me.Hide()
    End Sub

    Private Sub btn_product_Click(sender As Object, e As EventArgs) Handles btn_product.Click
        frm_productlist_a180970.Show()
        Me.Hide()
    End Sub

    Private Sub btn_staff_Click(sender As Object, e As EventArgs) Handles btn_staff.Click
        frm_stafflist_a180970.Show()
        Me.Hide()
    End Sub

    Private Sub btn_type_Click(sender As Object, e As EventArgs) Handles btn_type.Click
        frm_typelist_a180970.Show()
        Me.Hide()
    End Sub

    Private Sub btn_exit_Click(sender As Object, e As EventArgs) Handles btn_exit.Click
        End
    End Sub

    Private Sub btn_back_Click(sender As Object, e As EventArgs) Handles btn_back.Click
        frm_splashscreen_a180970.Show()
        Me.Hide()
    End Sub

    Private Sub btn_updateproduct_Click(sender As Object, e As EventArgs) Handles btn_updateproduct.Click
        frm_updateproduct_a180970.Show()
        Me.Hide()
    End Sub

    Private Sub Guna2Button1_Click(sender As Object, e As EventArgs) Handles Guna2Button1.Click
        frm_productcatalog_a180970.Show()
        Me.Hide()
    End Sub

    Private Sub btn_updatestaff_Click(sender As Object, e As EventArgs) Handles btn_updatestaff.Click
        frm_updatestaff_a180970.Show()
        Me.Hide()
    End Sub

    Private Sub btn_updatecust_Click(sender As Object, e As EventArgs) Handles btn_updatecust.Click
        frm_updatecustomer_a180970.Show()
        Me.Hide()
    End Sub

    Private Sub btn_makeorder_Click(sender As Object, e As EventArgs) Handles btn_makeorder.Click
        frm_makeorder_a180970.Show()
        Me.Hide()
    End Sub

    Private Sub btn_invoice_Click(sender As Object, e As EventArgs) Handles btn_invoice.Click
        frm_invoice_a180970.Show()
        Me.Hide()
    End Sub
End Class