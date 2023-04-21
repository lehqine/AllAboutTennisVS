<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_makeorder_a180970
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_makeorder_a180970))
        Me.btn_back = New Guna.UI2.WinForms.Guna2GradientButton()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txt_quantity = New System.Windows.Forms.TextBox()
        Me.txt_proid = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.pic_product = New System.Windows.Forms.PictureBox()
        Me.lbl_date = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txt_orderid = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txt_price = New System.Windows.Forms.TextBox()
        Me.txt_proname = New System.Windows.Forms.TextBox()
        Me.lst_product = New System.Windows.Forms.ListBox()
        Me.tm_time = New System.Windows.Forms.Timer(Me.components)
        Me.grd_details = New System.Windows.Forms.DataGridView()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txt_totalprice = New System.Windows.Forms.TextBox()
        Me.btn_insertproduct = New Guna.UI2.WinForms.Guna2Button()
        Me.btn_deleteproduct = New Guna.UI2.WinForms.Guna2Button()
        Me.btn_vieworder = New Guna.UI2.WinForms.Guna2GradientButton()
        Me.btn_makeorder = New Guna.UI2.WinForms.Guna2Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txt_staffid = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txt_staffcontact = New System.Windows.Forms.TextBox()
        Me.txt_staffname = New System.Windows.Forms.TextBox()
        Me.lst_staff = New System.Windows.Forms.ListBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.txt_custid = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txt_custcontact = New System.Windows.Forms.TextBox()
        Me.txt_custname = New System.Windows.Forms.TextBox()
        Me.lst_cust = New System.Windows.Forms.ListBox()
        Me.GroupBox3.SuspendLayout()
        CType(Me.pic_product, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grd_details, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'btn_back
        '
        Me.btn_back.AutoRoundedCorners = True
        Me.btn_back.BackColor = System.Drawing.Color.Transparent
        Me.btn_back.BorderRadius = 19
        Me.btn_back.CheckedState.Parent = Me.btn_back
        Me.btn_back.CustomImages.Parent = Me.btn_back
        Me.btn_back.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btn_back.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btn_back.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btn_back.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btn_back.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btn_back.DisabledState.Parent = Me.btn_back
        Me.btn_back.FillColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btn_back.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btn_back.Font = New System.Drawing.Font("Cooper Black", 10.2!)
        Me.btn_back.ForeColor = System.Drawing.Color.Black
        Me.btn_back.HoverState.Parent = Me.btn_back
        Me.btn_back.Location = New System.Drawing.Point(12, 12)
        Me.btn_back.Name = "btn_back"
        Me.btn_back.ShadowDecoration.Parent = Me.btn_back
        Me.btn_back.Size = New System.Drawing.Size(106, 41)
        Me.btn_back.TabIndex = 63
        Me.btn_back.Text = "BACK"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Segoe Print", 24.0!, System.Drawing.FontStyle.Bold)
        Me.Label1.Location = New System.Drawing.Point(449, 12)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(271, 71)
        Me.Label1.TabIndex = 64
        Me.Label1.Text = "Make Order"
        '
        'GroupBox3
        '
        Me.GroupBox3.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox3.Controls.Add(Me.Label10)
        Me.GroupBox3.Controls.Add(Me.txt_quantity)
        Me.GroupBox3.Controls.Add(Me.txt_proid)
        Me.GroupBox3.Controls.Add(Me.Label14)
        Me.GroupBox3.Controls.Add(Me.pic_product)
        Me.GroupBox3.Controls.Add(Me.lbl_date)
        Me.GroupBox3.Controls.Add(Me.Label9)
        Me.GroupBox3.Controls.Add(Me.txt_orderid)
        Me.GroupBox3.Controls.Add(Me.Label8)
        Me.GroupBox3.Controls.Add(Me.Label6)
        Me.GroupBox3.Controls.Add(Me.Label7)
        Me.GroupBox3.Controls.Add(Me.txt_price)
        Me.GroupBox3.Controls.Add(Me.txt_proname)
        Me.GroupBox3.Controls.Add(Me.lst_product)
        Me.GroupBox3.Font = New System.Drawing.Font("Elephant", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.Location = New System.Drawing.Point(33, 111)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(769, 375)
        Me.GroupBox3.TabIndex = 67
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Order List"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Times New Roman", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(536, 293)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(136, 16)
        Me.Label10.TabIndex = 74
        Me.Label10.Text = "(Quantity cannot be 0)"
        '
        'txt_quantity
        '
        Me.txt_quantity.Font = New System.Drawing.Font("Times New Roman", 10.2!)
        Me.txt_quantity.Location = New System.Drawing.Point(539, 263)
        Me.txt_quantity.Name = "txt_quantity"
        Me.txt_quantity.Size = New System.Drawing.Size(130, 27)
        Me.txt_quantity.TabIndex = 73
        Me.txt_quantity.Text = "1"
        '
        'txt_proid
        '
        Me.txt_proid.Font = New System.Drawing.Font("Times New Roman", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_proid.Location = New System.Drawing.Point(538, 130)
        Me.txt_proid.Name = "txt_proid"
        Me.txt_proid.Size = New System.Drawing.Size(132, 27)
        Me.txt_proid.TabIndex = 72
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Times New Roman", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(421, 135)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(97, 19)
        Me.Label14.TabIndex = 71
        Me.Label14.Text = "Product ID:"
        '
        'pic_product
        '
        Me.pic_product.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.pic_product.Location = New System.Drawing.Point(167, 73)
        Me.pic_product.Name = "pic_product"
        Me.pic_product.Size = New System.Drawing.Size(173, 235)
        Me.pic_product.TabIndex = 9
        Me.pic_product.TabStop = False
        '
        'lbl_date
        '
        Me.lbl_date.AutoSize = True
        Me.lbl_date.Font = New System.Drawing.Font("Times New Roman", 10.2!, System.Drawing.FontStyle.Bold)
        Me.lbl_date.Location = New System.Drawing.Point(568, 18)
        Me.lbl_date.Name = "lbl_date"
        Me.lbl_date.Size = New System.Drawing.Size(69, 19)
        Me.lbl_date.TabIndex = 8
        Me.lbl_date.Text = "Label10"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Times New Roman", 10.2!, System.Drawing.FontStyle.Bold)
        Me.Label9.Location = New System.Drawing.Point(439, 266)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(80, 19)
        Me.Label9.TabIndex = 7
        Me.Label9.Text = "Quantity:"
        '
        'txt_orderid
        '
        Me.txt_orderid.Font = New System.Drawing.Font("Times New Roman", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_orderid.Location = New System.Drawing.Point(538, 88)
        Me.txt_orderid.Name = "txt_orderid"
        Me.txt_orderid.Size = New System.Drawing.Size(132, 27)
        Me.txt_orderid.TabIndex = 6
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Times New Roman", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(435, 93)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(83, 19)
        Me.Label8.TabIndex = 5
        Me.Label8.Text = "Order ID:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Times New Roman", 10.2!, System.Drawing.FontStyle.Bold)
        Me.Label6.Location = New System.Drawing.Point(436, 221)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(88, 19)
        Me.Label6.TabIndex = 4
        Me.Label6.Text = "Price: RM"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Times New Roman", 10.2!, System.Drawing.FontStyle.Bold)
        Me.Label7.Location = New System.Drawing.Point(462, 173)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(57, 19)
        Me.Label7.TabIndex = 3
        Me.Label7.Text = "Name:"
        '
        'txt_price
        '
        Me.txt_price.Font = New System.Drawing.Font("Times New Roman", 10.2!)
        Me.txt_price.Location = New System.Drawing.Point(540, 216)
        Me.txt_price.Name = "txt_price"
        Me.txt_price.Size = New System.Drawing.Size(131, 27)
        Me.txt_price.TabIndex = 2
        '
        'txt_proname
        '
        Me.txt_proname.Font = New System.Drawing.Font("Times New Roman", 10.2!)
        Me.txt_proname.Location = New System.Drawing.Point(539, 173)
        Me.txt_proname.Name = "txt_proname"
        Me.txt_proname.Size = New System.Drawing.Size(131, 27)
        Me.txt_proname.TabIndex = 1
        '
        'lst_product
        '
        Me.lst_product.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!)
        Me.lst_product.FormattingEnabled = True
        Me.lst_product.ItemHeight = 16
        Me.lst_product.Location = New System.Drawing.Point(15, 31)
        Me.lst_product.Name = "lst_product"
        Me.lst_product.Size = New System.Drawing.Size(100, 324)
        Me.lst_product.TabIndex = 0
        '
        'tm_time
        '
        '
        'grd_details
        '
        Me.grd_details.AllowUserToAddRows = False
        Me.grd_details.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.grd_details.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.grd_details.BackgroundColor = System.Drawing.Color.White
        Me.grd_details.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grd_details.Location = New System.Drawing.Point(47, 503)
        Me.grd_details.Name = "grd_details"
        Me.grd_details.RowHeadersWidth = 51
        Me.grd_details.RowTemplate.Height = 24
        Me.grd_details.Size = New System.Drawing.Size(928, 215)
        Me.grd_details.TabIndex = 68
        Me.grd_details.UseWaitCursor = True
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.BackColor = System.Drawing.Color.Transparent
        Me.Label11.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label11.Location = New System.Drawing.Point(342, 744)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(146, 23)
        Me.Label11.TabIndex = 69
        Me.Label11.Text = "Total Price: RM"
        '
        'txt_totalprice
        '
        Me.txt_totalprice.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_totalprice.Location = New System.Drawing.Point(500, 742)
        Me.txt_totalprice.Name = "txt_totalprice"
        Me.txt_totalprice.Size = New System.Drawing.Size(143, 30)
        Me.txt_totalprice.TabIndex = 70
        '
        'btn_insertproduct
        '
        Me.btn_insertproduct.CheckedState.Parent = Me.btn_insertproduct
        Me.btn_insertproduct.CustomImages.Parent = Me.btn_insertproduct
        Me.btn_insertproduct.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btn_insertproduct.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btn_insertproduct.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btn_insertproduct.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btn_insertproduct.DisabledState.Parent = Me.btn_insertproduct
        Me.btn_insertproduct.FillColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btn_insertproduct.Font = New System.Drawing.Font("Cooper Black", 10.2!)
        Me.btn_insertproduct.ForeColor = System.Drawing.Color.Black
        Me.btn_insertproduct.HoverState.Parent = Me.btn_insertproduct
        Me.btn_insertproduct.Location = New System.Drawing.Point(1008, 503)
        Me.btn_insertproduct.Name = "btn_insertproduct"
        Me.btn_insertproduct.ShadowDecoration.Parent = Me.btn_insertproduct
        Me.btn_insertproduct.Size = New System.Drawing.Size(180, 45)
        Me.btn_insertproduct.TabIndex = 71
        Me.btn_insertproduct.Text = "Insert"
        '
        'btn_deleteproduct
        '
        Me.btn_deleteproduct.CheckedState.Parent = Me.btn_deleteproduct
        Me.btn_deleteproduct.CustomImages.Parent = Me.btn_deleteproduct
        Me.btn_deleteproduct.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btn_deleteproduct.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btn_deleteproduct.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btn_deleteproduct.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btn_deleteproduct.DisabledState.Parent = Me.btn_deleteproduct
        Me.btn_deleteproduct.FillColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btn_deleteproduct.Font = New System.Drawing.Font("Cooper Black", 10.2!)
        Me.btn_deleteproduct.ForeColor = System.Drawing.Color.Black
        Me.btn_deleteproduct.HoverState.Parent = Me.btn_deleteproduct
        Me.btn_deleteproduct.Location = New System.Drawing.Point(1008, 563)
        Me.btn_deleteproduct.Name = "btn_deleteproduct"
        Me.btn_deleteproduct.ShadowDecoration.Parent = Me.btn_deleteproduct
        Me.btn_deleteproduct.Size = New System.Drawing.Size(180, 45)
        Me.btn_deleteproduct.TabIndex = 72
        Me.btn_deleteproduct.Text = "Delete"
        '
        'btn_vieworder
        '
        Me.btn_vieworder.CheckedState.Parent = Me.btn_vieworder
        Me.btn_vieworder.CustomImages.Parent = Me.btn_vieworder
        Me.btn_vieworder.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btn_vieworder.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btn_vieworder.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btn_vieworder.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btn_vieworder.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btn_vieworder.DisabledState.Parent = Me.btn_vieworder
        Me.btn_vieworder.Font = New System.Drawing.Font("Cooper Black", 10.2!)
        Me.btn_vieworder.ForeColor = System.Drawing.Color.White
        Me.btn_vieworder.HoverState.Parent = Me.btn_vieworder
        Me.btn_vieworder.Location = New System.Drawing.Point(1008, 721)
        Me.btn_vieworder.Name = "btn_vieworder"
        Me.btn_vieworder.ShadowDecoration.Parent = Me.btn_vieworder
        Me.btn_vieworder.Size = New System.Drawing.Size(180, 45)
        Me.btn_vieworder.TabIndex = 73
        Me.btn_vieworder.Text = "View Invoice"
        '
        'btn_makeorder
        '
        Me.btn_makeorder.CheckedState.Parent = Me.btn_makeorder
        Me.btn_makeorder.CustomImages.Parent = Me.btn_makeorder
        Me.btn_makeorder.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btn_makeorder.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btn_makeorder.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btn_makeorder.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btn_makeorder.DisabledState.Parent = Me.btn_makeorder
        Me.btn_makeorder.FillColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btn_makeorder.Font = New System.Drawing.Font("Cooper Black", 10.2!)
        Me.btn_makeorder.ForeColor = System.Drawing.Color.Black
        Me.btn_makeorder.HoverState.Parent = Me.btn_makeorder
        Me.btn_makeorder.Location = New System.Drawing.Point(1008, 635)
        Me.btn_makeorder.Name = "btn_makeorder"
        Me.btn_makeorder.ShadowDecoration.Parent = Me.btn_makeorder
        Me.btn_makeorder.Size = New System.Drawing.Size(180, 45)
        Me.btn_makeorder.TabIndex = 74
        Me.btn_makeorder.Text = "Make Order"
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox2.Controls.Add(Me.Label13)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.txt_staffid)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.txt_staffcontact)
        Me.GroupBox2.Controls.Add(Me.txt_staffname)
        Me.GroupBox2.Controls.Add(Me.lst_staff)
        Me.GroupBox2.Font = New System.Drawing.Font("Elephant", 10.2!)
        Me.GroupBox2.Location = New System.Drawing.Point(831, 305)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(357, 183)
        Me.GroupBox2.TabIndex = 76
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Staff List"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Times New Roman", 10.2!, System.Drawing.FontStyle.Bold)
        Me.Label13.Location = New System.Drawing.Point(158, 44)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(33, 19)
        Me.Label13.TabIndex = 8
        Me.Label13.Text = "ID:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Times New Roman", 10.2!, System.Drawing.FontStyle.Bold)
        Me.Label4.Location = New System.Drawing.Point(118, 137)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(73, 19)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Contact:"
        '
        'txt_staffid
        '
        Me.txt_staffid.Font = New System.Drawing.Font("Times New Roman", 10.2!)
        Me.txt_staffid.Location = New System.Drawing.Point(208, 39)
        Me.txt_staffid.Name = "txt_staffid"
        Me.txt_staffid.Size = New System.Drawing.Size(131, 27)
        Me.txt_staffid.TabIndex = 7
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Times New Roman", 10.2!, System.Drawing.FontStyle.Bold)
        Me.Label5.Location = New System.Drawing.Point(134, 93)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(57, 19)
        Me.Label5.TabIndex = 3
        Me.Label5.Text = "Name:"
        '
        'txt_staffcontact
        '
        Me.txt_staffcontact.Font = New System.Drawing.Font("Times New Roman", 10.2!)
        Me.txt_staffcontact.Location = New System.Drawing.Point(208, 134)
        Me.txt_staffcontact.Name = "txt_staffcontact"
        Me.txt_staffcontact.Size = New System.Drawing.Size(131, 27)
        Me.txt_staffcontact.TabIndex = 2
        '
        'txt_staffname
        '
        Me.txt_staffname.Font = New System.Drawing.Font("Times New Roman", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_staffname.Location = New System.Drawing.Point(208, 85)
        Me.txt_staffname.Name = "txt_staffname"
        Me.txt_staffname.Size = New System.Drawing.Size(131, 27)
        Me.txt_staffname.TabIndex = 1
        '
        'lst_staff
        '
        Me.lst_staff.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!)
        Me.lst_staff.FormattingEnabled = True
        Me.lst_staff.ItemHeight = 16
        Me.lst_staff.Location = New System.Drawing.Point(15, 31)
        Me.lst_staff.Name = "lst_staff"
        Me.lst_staff.Size = New System.Drawing.Size(93, 132)
        Me.lst_staff.TabIndex = 0
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.Label12)
        Me.GroupBox1.Controls.Add(Me.txt_custid)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.txt_custcontact)
        Me.GroupBox1.Controls.Add(Me.txt_custname)
        Me.GroupBox1.Controls.Add(Me.lst_cust)
        Me.GroupBox1.Font = New System.Drawing.Font("Elephant", 10.2!)
        Me.GroupBox1.Location = New System.Drawing.Point(831, 111)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(357, 183)
        Me.GroupBox1.TabIndex = 75
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Customer List"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Times New Roman", 10.2!, System.Drawing.FontStyle.Bold)
        Me.Label12.Location = New System.Drawing.Point(160, 49)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(33, 19)
        Me.Label12.TabIndex = 6
        Me.Label12.Text = "ID:"
        '
        'txt_custid
        '
        Me.txt_custid.Font = New System.Drawing.Font("Times New Roman", 10.2!)
        Me.txt_custid.Location = New System.Drawing.Point(208, 44)
        Me.txt_custid.Name = "txt_custid"
        Me.txt_custid.Size = New System.Drawing.Size(131, 27)
        Me.txt_custid.TabIndex = 5
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Times New Roman", 10.2!, System.Drawing.FontStyle.Bold)
        Me.Label3.Location = New System.Drawing.Point(120, 135)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(73, 19)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Contact:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Times New Roman", 10.2!, System.Drawing.FontStyle.Bold)
        Me.Label2.Location = New System.Drawing.Point(136, 89)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(57, 19)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Name:"
        '
        'txt_custcontact
        '
        Me.txt_custcontact.Font = New System.Drawing.Font("Times New Roman", 10.2!)
        Me.txt_custcontact.Location = New System.Drawing.Point(208, 132)
        Me.txt_custcontact.Name = "txt_custcontact"
        Me.txt_custcontact.Size = New System.Drawing.Size(131, 27)
        Me.txt_custcontact.TabIndex = 2
        '
        'txt_custname
        '
        Me.txt_custname.Font = New System.Drawing.Font("Times New Roman", 10.2!)
        Me.txt_custname.Location = New System.Drawing.Point(208, 86)
        Me.txt_custname.Name = "txt_custname"
        Me.txt_custname.Size = New System.Drawing.Size(131, 27)
        Me.txt_custname.TabIndex = 1
        '
        'lst_cust
        '
        Me.lst_cust.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!)
        Me.lst_cust.FormattingEnabled = True
        Me.lst_cust.ItemHeight = 16
        Me.lst_cust.Location = New System.Drawing.Point(15, 31)
        Me.lst_cust.Name = "lst_cust"
        Me.lst_cust.Size = New System.Drawing.Size(93, 132)
        Me.lst_cust.TabIndex = 0
        '
        'frm_makeorder_a180970
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.prj_AllAboutTennis_a180970.My.Resources.Resources.list
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1214, 802)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btn_makeorder)
        Me.Controls.Add(Me.btn_vieworder)
        Me.Controls.Add(Me.btn_deleteproduct)
        Me.Controls.Add(Me.btn_insertproduct)
        Me.Controls.Add(Me.txt_totalprice)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.grd_details)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btn_back)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frm_makeorder_a180970"
        Me.Text = "Make Order AllAboutTennis"
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        CType(Me.pic_product, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grd_details, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btn_back As Guna.UI2.WinForms.Guna2GradientButton
    Friend WithEvents Label1 As Label
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents lbl_date As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents txt_orderid As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents txt_price As TextBox
    Friend WithEvents txt_proname As TextBox
    Friend WithEvents lst_product As ListBox
    Friend WithEvents tm_time As Timer
    Friend WithEvents pic_product As PictureBox
    Friend WithEvents grd_details As DataGridView
    Friend WithEvents Label11 As Label
    Friend WithEvents txt_totalprice As TextBox
    Friend WithEvents btn_insertproduct As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btn_deleteproduct As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btn_vieworder As Guna.UI2.WinForms.Guna2GradientButton
    Friend WithEvents btn_makeorder As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents txt_staffcontact As TextBox
    Friend WithEvents txt_staffname As TextBox
    Friend WithEvents lst_staff As ListBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txt_custcontact As TextBox
    Friend WithEvents txt_custname As TextBox
    Friend WithEvents lst_cust As ListBox
    Friend WithEvents txt_proid As TextBox
    Friend WithEvents Label14 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents txt_staffid As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents txt_custid As TextBox
    Friend WithEvents txt_quantity As TextBox
    Friend WithEvents Label10 As Label
End Class
