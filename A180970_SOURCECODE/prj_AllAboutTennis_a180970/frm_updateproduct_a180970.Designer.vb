<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_updateproduct_a180970
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_updateproduct_a180970))
        Me.btn_update = New Guna.UI2.WinForms.Guna2Button()
        Me.btn_delete = New Guna.UI2.WinForms.Guna2Button()
        Me.btn_insert = New Guna.UI2.WinForms.Guna2Button()
        Me.txt_desc = New Guna.UI2.WinForms.Guna2TextBox()
        Me.txt_quantity = New Guna.UI2.WinForms.Guna2TextBox()
        Me.txt_type = New Guna.UI2.WinForms.Guna2TextBox()
        Me.txt_brand = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txt_price = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txt_name = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txt_id = New Guna.UI2.WinForms.Guna2TextBox()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.pic_product = New System.Windows.Forms.PictureBox()
        Me.lbl_title = New System.Windows.Forms.Label()
        Me.btn_uploadpic = New Guna.UI2.WinForms.Guna2GradientButton()
        Me.txt_location = New Guna.UI2.WinForms.Guna2TextBox()
        Me.btn_back = New Guna.UI2.WinForms.Guna2GradientButton()
        Me.grd_product = New System.Windows.Forms.DataGridView()
        CType(Me.pic_product, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grd_product, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btn_update
        '
        Me.btn_update.CheckedState.Parent = Me.btn_update
        Me.btn_update.CustomImages.Parent = Me.btn_update
        Me.btn_update.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btn_update.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btn_update.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btn_update.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btn_update.DisabledState.Parent = Me.btn_update
        Me.btn_update.FillColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btn_update.Font = New System.Drawing.Font("Cooper Black", 10.2!)
        Me.btn_update.ForeColor = System.Drawing.Color.Black
        Me.btn_update.HoverState.Parent = Me.btn_update
        Me.btn_update.Location = New System.Drawing.Point(1011, 529)
        Me.btn_update.Name = "btn_update"
        Me.btn_update.ShadowDecoration.Parent = Me.btn_update
        Me.btn_update.Size = New System.Drawing.Size(180, 45)
        Me.btn_update.TabIndex = 43
        Me.btn_update.Text = "UPDATE"
        '
        'btn_delete
        '
        Me.btn_delete.CheckedState.Parent = Me.btn_delete
        Me.btn_delete.CustomImages.Parent = Me.btn_delete
        Me.btn_delete.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btn_delete.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btn_delete.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btn_delete.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btn_delete.DisabledState.Parent = Me.btn_delete
        Me.btn_delete.FillColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btn_delete.Font = New System.Drawing.Font("Cooper Black", 10.2!)
        Me.btn_delete.ForeColor = System.Drawing.Color.Black
        Me.btn_delete.HoverState.Parent = Me.btn_delete
        Me.btn_delete.Location = New System.Drawing.Point(1286, 529)
        Me.btn_delete.Name = "btn_delete"
        Me.btn_delete.ShadowDecoration.Parent = Me.btn_delete
        Me.btn_delete.Size = New System.Drawing.Size(180, 45)
        Me.btn_delete.TabIndex = 42
        Me.btn_delete.Text = "DELETE"
        '
        'btn_insert
        '
        Me.btn_insert.CheckedState.Parent = Me.btn_insert
        Me.btn_insert.CustomImages.Parent = Me.btn_insert
        Me.btn_insert.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btn_insert.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btn_insert.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btn_insert.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btn_insert.DisabledState.Parent = Me.btn_insert
        Me.btn_insert.FillColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btn_insert.Font = New System.Drawing.Font("Cooper Black", 10.2!)
        Me.btn_insert.ForeColor = System.Drawing.Color.Black
        Me.btn_insert.HoverState.Parent = Me.btn_insert
        Me.btn_insert.Location = New System.Drawing.Point(727, 529)
        Me.btn_insert.Name = "btn_insert"
        Me.btn_insert.ShadowDecoration.Parent = Me.btn_insert
        Me.btn_insert.Size = New System.Drawing.Size(180, 45)
        Me.btn_insert.TabIndex = 41
        Me.btn_insert.Text = "INSERT"
        '
        'txt_desc
        '
        Me.txt_desc.BackColor = System.Drawing.Color.Transparent
        Me.txt_desc.BorderColor = System.Drawing.Color.Black
        Me.txt_desc.BorderRadius = 9
        Me.txt_desc.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txt_desc.DefaultText = ""
        Me.txt_desc.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txt_desc.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txt_desc.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txt_desc.DisabledState.Parent = Me.txt_desc
        Me.txt_desc.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txt_desc.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txt_desc.FocusedState.Parent = Me.txt_desc
        Me.txt_desc.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txt_desc.ForeColor = System.Drawing.Color.Black
        Me.txt_desc.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txt_desc.HoverState.Parent = Me.txt_desc
        Me.txt_desc.Location = New System.Drawing.Point(653, 363)
        Me.txt_desc.Name = "txt_desc"
        Me.txt_desc.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txt_desc.PlaceholderText = ""
        Me.txt_desc.SelectedText = ""
        Me.txt_desc.ShadowDecoration.Parent = Me.txt_desc
        Me.txt_desc.Size = New System.Drawing.Size(576, 88)
        Me.txt_desc.TabIndex = 57
        '
        'txt_quantity
        '
        Me.txt_quantity.BackColor = System.Drawing.Color.Transparent
        Me.txt_quantity.BorderColor = System.Drawing.Color.Black
        Me.txt_quantity.BorderRadius = 9
        Me.txt_quantity.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txt_quantity.DefaultText = ""
        Me.txt_quantity.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txt_quantity.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txt_quantity.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txt_quantity.DisabledState.Parent = Me.txt_quantity
        Me.txt_quantity.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txt_quantity.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txt_quantity.FocusedState.Parent = Me.txt_quantity
        Me.txt_quantity.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txt_quantity.ForeColor = System.Drawing.Color.Black
        Me.txt_quantity.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txt_quantity.HoverState.Parent = Me.txt_quantity
        Me.txt_quantity.Location = New System.Drawing.Point(917, 105)
        Me.txt_quantity.Name = "txt_quantity"
        Me.txt_quantity.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txt_quantity.PlaceholderText = ""
        Me.txt_quantity.SelectedText = ""
        Me.txt_quantity.ShadowDecoration.Parent = Me.txt_quantity
        Me.txt_quantity.Size = New System.Drawing.Size(95, 36)
        Me.txt_quantity.TabIndex = 56
        '
        'txt_type
        '
        Me.txt_type.BackColor = System.Drawing.Color.Transparent
        Me.txt_type.BorderColor = System.Drawing.Color.Black
        Me.txt_type.BorderRadius = 9
        Me.txt_type.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txt_type.DefaultText = ""
        Me.txt_type.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txt_type.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txt_type.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txt_type.DisabledState.Parent = Me.txt_type
        Me.txt_type.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txt_type.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txt_type.FocusedState.Parent = Me.txt_type
        Me.txt_type.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txt_type.ForeColor = System.Drawing.Color.Black
        Me.txt_type.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txt_type.HoverState.Parent = Me.txt_type
        Me.txt_type.Location = New System.Drawing.Point(1046, 242)
        Me.txt_type.Name = "txt_type"
        Me.txt_type.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txt_type.PlaceholderText = ""
        Me.txt_type.SelectedText = ""
        Me.txt_type.ShadowDecoration.Parent = Me.txt_type
        Me.txt_type.Size = New System.Drawing.Size(166, 36)
        Me.txt_type.TabIndex = 55
        '
        'txt_brand
        '
        Me.txt_brand.BackColor = System.Drawing.Color.Transparent
        Me.txt_brand.BorderColor = System.Drawing.Color.Black
        Me.txt_brand.BorderRadius = 9
        Me.txt_brand.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txt_brand.DefaultText = ""
        Me.txt_brand.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txt_brand.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txt_brand.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txt_brand.DisabledState.Parent = Me.txt_brand
        Me.txt_brand.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txt_brand.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txt_brand.FocusedState.Parent = Me.txt_brand
        Me.txt_brand.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txt_brand.ForeColor = System.Drawing.Color.Black
        Me.txt_brand.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txt_brand.HoverState.Parent = Me.txt_brand
        Me.txt_brand.Location = New System.Drawing.Point(713, 242)
        Me.txt_brand.Name = "txt_brand"
        Me.txt_brand.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txt_brand.PlaceholderText = ""
        Me.txt_brand.SelectedText = ""
        Me.txt_brand.ShadowDecoration.Parent = Me.txt_brand
        Me.txt_brand.Size = New System.Drawing.Size(183, 36)
        Me.txt_brand.TabIndex = 54
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Times New Roman", 10.2!, System.Drawing.FontStyle.Bold)
        Me.Label7.Location = New System.Drawing.Point(650, 328)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(103, 19)
        Me.Label7.TabIndex = 53
        Me.Label7.Text = "Description:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Times New Roman", 10.2!, System.Drawing.FontStyle.Bold)
        Me.Label6.Location = New System.Drawing.Point(831, 114)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(80, 19)
        Me.Label6.TabIndex = 52
        Me.Label6.Text = "Quantity:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Times New Roman", 10.2!, System.Drawing.FontStyle.Bold)
        Me.Label5.Location = New System.Drawing.Point(991, 252)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(49, 19)
        Me.Label5.TabIndex = 51
        Me.Label5.Text = "Type:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Times New Roman", 10.2!, System.Drawing.FontStyle.Bold)
        Me.Label4.Location = New System.Drawing.Point(646, 252)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(61, 19)
        Me.Label4.TabIndex = 50
        Me.Label4.Text = "Brand:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Times New Roman", 10.2!, System.Drawing.FontStyle.Bold)
        Me.Label3.Location = New System.Drawing.Point(1031, 114)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(88, 19)
        Me.Label3.TabIndex = 49
        Me.Label3.Text = "Price: RM"
        '
        'txt_price
        '
        Me.txt_price.BackColor = System.Drawing.Color.Transparent
        Me.txt_price.BorderColor = System.Drawing.Color.Black
        Me.txt_price.BorderRadius = 9
        Me.txt_price.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txt_price.DefaultText = ""
        Me.txt_price.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txt_price.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txt_price.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txt_price.DisabledState.Parent = Me.txt_price
        Me.txt_price.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txt_price.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txt_price.FocusedState.Parent = Me.txt_price
        Me.txt_price.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txt_price.ForeColor = System.Drawing.Color.Black
        Me.txt_price.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txt_price.HoverState.Parent = Me.txt_price
        Me.txt_price.Location = New System.Drawing.Point(1125, 105)
        Me.txt_price.Name = "txt_price"
        Me.txt_price.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txt_price.PlaceholderText = ""
        Me.txt_price.SelectedText = ""
        Me.txt_price.ShadowDecoration.Parent = Me.txt_price
        Me.txt_price.Size = New System.Drawing.Size(87, 36)
        Me.txt_price.TabIndex = 48
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Times New Roman", 10.2!, System.Drawing.FontStyle.Bold)
        Me.Label2.Location = New System.Drawing.Point(650, 181)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(57, 19)
        Me.Label2.TabIndex = 47
        Me.Label2.Text = "Name:"
        '
        'txt_name
        '
        Me.txt_name.BackColor = System.Drawing.Color.Transparent
        Me.txt_name.BorderColor = System.Drawing.Color.Black
        Me.txt_name.BorderRadius = 9
        Me.txt_name.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txt_name.DefaultText = ""
        Me.txt_name.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txt_name.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txt_name.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txt_name.DisabledState.Parent = Me.txt_name
        Me.txt_name.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txt_name.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txt_name.FocusedState.Parent = Me.txt_name
        Me.txt_name.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txt_name.ForeColor = System.Drawing.Color.Black
        Me.txt_name.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txt_name.HoverState.Parent = Me.txt_name
        Me.txt_name.Location = New System.Drawing.Point(713, 171)
        Me.txt_name.Name = "txt_name"
        Me.txt_name.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txt_name.PlaceholderText = ""
        Me.txt_name.SelectedText = ""
        Me.txt_name.ShadowDecoration.Parent = Me.txt_name
        Me.txt_name.Size = New System.Drawing.Size(499, 36)
        Me.txt_name.TabIndex = 46
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(674, 114)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(33, 19)
        Me.Label1.TabIndex = 45
        Me.Label1.Text = "ID:"
        '
        'txt_id
        '
        Me.txt_id.BackColor = System.Drawing.Color.Transparent
        Me.txt_id.BorderColor = System.Drawing.Color.Black
        Me.txt_id.BorderRadius = 9
        Me.txt_id.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txt_id.DefaultText = ""
        Me.txt_id.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txt_id.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txt_id.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txt_id.DisabledState.Parent = Me.txt_id
        Me.txt_id.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txt_id.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txt_id.FocusedState.Parent = Me.txt_id
        Me.txt_id.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txt_id.ForeColor = System.Drawing.Color.Black
        Me.txt_id.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txt_id.HoverState.Parent = Me.txt_id
        Me.txt_id.Location = New System.Drawing.Point(713, 105)
        Me.txt_id.Name = "txt_id"
        Me.txt_id.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txt_id.PlaceholderText = ""
        Me.txt_id.SelectedText = ""
        Me.txt_id.ShadowDecoration.Parent = Me.txt_id
        Me.txt_id.Size = New System.Drawing.Size(95, 36)
        Me.txt_id.TabIndex = 44
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'pic_product
        '
        Me.pic_product.BackColor = System.Drawing.Color.Transparent
        Me.pic_product.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.pic_product.Location = New System.Drawing.Point(1286, 105)
        Me.pic_product.Name = "pic_product"
        Me.pic_product.Size = New System.Drawing.Size(185, 200)
        Me.pic_product.TabIndex = 58
        Me.pic_product.TabStop = False
        '
        'lbl_title
        '
        Me.lbl_title.AutoSize = True
        Me.lbl_title.BackColor = System.Drawing.Color.Transparent
        Me.lbl_title.Font = New System.Drawing.Font("Segoe Print", 24.0!, System.Drawing.FontStyle.Bold)
        Me.lbl_title.Location = New System.Drawing.Point(701, 9)
        Me.lbl_title.Name = "lbl_title"
        Me.lbl_title.Size = New System.Drawing.Size(443, 71)
        Me.lbl_title.TabIndex = 59
        Me.lbl_title.Text = "MANAGE PRODUCT"
        '
        'btn_uploadpic
        '
        Me.btn_uploadpic.CheckedState.Parent = Me.btn_uploadpic
        Me.btn_uploadpic.CustomImages.Parent = Me.btn_uploadpic
        Me.btn_uploadpic.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btn_uploadpic.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btn_uploadpic.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btn_uploadpic.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btn_uploadpic.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btn_uploadpic.DisabledState.Parent = Me.btn_uploadpic
        Me.btn_uploadpic.FillColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btn_uploadpic.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btn_uploadpic.Font = New System.Drawing.Font("Cooper Black", 10.2!)
        Me.btn_uploadpic.ForeColor = System.Drawing.Color.Black
        Me.btn_uploadpic.HoverState.Parent = Me.btn_uploadpic
        Me.btn_uploadpic.Location = New System.Drawing.Point(1291, 447)
        Me.btn_uploadpic.Name = "btn_uploadpic"
        Me.btn_uploadpic.ShadowDecoration.Parent = Me.btn_uploadpic
        Me.btn_uploadpic.Size = New System.Drawing.Size(180, 45)
        Me.btn_uploadpic.TabIndex = 60
        Me.btn_uploadpic.Text = "Upload Picture"
        '
        'txt_location
        '
        Me.txt_location.BackColor = System.Drawing.Color.Transparent
        Me.txt_location.BorderColor = System.Drawing.Color.Black
        Me.txt_location.BorderRadius = 9
        Me.txt_location.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txt_location.DefaultText = ""
        Me.txt_location.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txt_location.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txt_location.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txt_location.DisabledState.Parent = Me.txt_location
        Me.txt_location.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txt_location.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txt_location.FocusedState.Parent = Me.txt_location
        Me.txt_location.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txt_location.ForeColor = System.Drawing.Color.Black
        Me.txt_location.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txt_location.HoverState.Parent = Me.txt_location
        Me.txt_location.Location = New System.Drawing.Point(1283, 328)
        Me.txt_location.Name = "txt_location"
        Me.txt_location.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txt_location.PlaceholderText = ""
        Me.txt_location.SelectedText = ""
        Me.txt_location.ShadowDecoration.Parent = Me.txt_location
        Me.txt_location.Size = New System.Drawing.Size(188, 91)
        Me.txt_location.TabIndex = 61
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
        Me.btn_back.TabIndex = 62
        Me.btn_back.Text = "BACK"
        '
        'grd_product
        '
        Me.grd_product.AllowUserToAddRows = False
        Me.grd_product.BackgroundColor = System.Drawing.Color.White
        Me.grd_product.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grd_product.Location = New System.Drawing.Point(12, 91)
        Me.grd_product.Name = "grd_product"
        Me.grd_product.ReadOnly = True
        Me.grd_product.RowHeadersWidth = 51
        Me.grd_product.RowTemplate.Height = 24
        Me.grd_product.Size = New System.Drawing.Size(607, 497)
        Me.grd_product.TabIndex = 63
        '
        'frm_updateproduct_a180970
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.prj_AllAboutTennis_a180970.My.Resources.Resources.list
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1519, 625)
        Me.Controls.Add(Me.grd_product)
        Me.Controls.Add(Me.btn_back)
        Me.Controls.Add(Me.txt_location)
        Me.Controls.Add(Me.btn_uploadpic)
        Me.Controls.Add(Me.lbl_title)
        Me.Controls.Add(Me.pic_product)
        Me.Controls.Add(Me.txt_desc)
        Me.Controls.Add(Me.txt_quantity)
        Me.Controls.Add(Me.txt_type)
        Me.Controls.Add(Me.txt_brand)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txt_price)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txt_name)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txt_id)
        Me.Controls.Add(Me.btn_update)
        Me.Controls.Add(Me.btn_delete)
        Me.Controls.Add(Me.btn_insert)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frm_updateproduct_a180970"
        Me.Text = "AllAboutTennis Update Product"
        CType(Me.pic_product, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grd_product, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btn_update As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btn_delete As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btn_insert As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents txt_desc As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents txt_quantity As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents txt_type As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents txt_brand As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txt_price As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txt_name As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents txt_id As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents pic_product As PictureBox
    Friend WithEvents lbl_title As Label
    Friend WithEvents btn_uploadpic As Guna.UI2.WinForms.Guna2GradientButton
    Friend WithEvents txt_location As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents btn_back As Guna.UI2.WinForms.Guna2GradientButton
    Friend WithEvents grd_product As DataGridView
End Class
