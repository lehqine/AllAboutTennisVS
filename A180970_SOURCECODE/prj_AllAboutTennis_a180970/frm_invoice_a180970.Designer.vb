<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_invoice_a180970
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_invoice_a180970))
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.lbl_invoiceno = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.lbl_date = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.lbl_cust = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.lbl_staff = New System.Windows.Forms.Label()
        Me.grd_details = New System.Windows.Forms.DataGridView()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.lst_order = New System.Windows.Forms.ListBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btn_back = New Guna.UI2.WinForms.Guna2GradientButton()
        Me.lbl_totalprice = New System.Windows.Forms.Label()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        CType(Me.grd_details, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Broadway", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.DarkOliveGreen
        Me.Label2.Location = New System.Drawing.Point(285, 127)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(395, 46)
        Me.Label2.TabIndex = 67
        Me.Label2.Text = "All About Tennis"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(289, 176)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(378, 44)
        Me.Label3.TabIndex = 68
        Me.Label3.Text = "No.10D, Lorong Jalan Ulu Sungai Merah 46W," & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "96000 Sibu, Sarawak, Malaysia."
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(290, 229)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(369, 17)
        Me.Label4.TabIndex = 69
        Me.Label4.Text = "Telefon: +601111557899       Email: allabouttennis@gmail.com"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Times New Roman", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(772, 295)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(94, 19)
        Me.Label5.TabIndex = 70
        Me.Label5.Text = "Invoice No:"
        '
        'lbl_invoiceno
        '
        Me.lbl_invoiceno.AutoSize = True
        Me.lbl_invoiceno.Font = New System.Drawing.Font("Times New Roman", 10.2!)
        Me.lbl_invoiceno.Location = New System.Drawing.Point(872, 295)
        Me.lbl_invoiceno.Name = "lbl_invoiceno"
        Me.lbl_invoiceno.Size = New System.Drawing.Size(56, 19)
        Me.lbl_invoiceno.TabIndex = 71
        Me.lbl_invoiceno.Text = "Label6"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Times New Roman", 10.2!, System.Drawing.FontStyle.Bold)
        Me.Label6.Location = New System.Drawing.Point(772, 337)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(49, 19)
        Me.Label6.TabIndex = 72
        Me.Label6.Text = "Date:"
        '
        'lbl_date
        '
        Me.lbl_date.AutoSize = True
        Me.lbl_date.Font = New System.Drawing.Font("Times New Roman", 10.2!)
        Me.lbl_date.Location = New System.Drawing.Point(829, 337)
        Me.lbl_date.Name = "lbl_date"
        Me.lbl_date.Size = New System.Drawing.Size(56, 19)
        Me.lbl_date.TabIndex = 73
        Me.lbl_date.Text = "Label7"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Times New Roman", 10.2!, System.Drawing.FontStyle.Bold)
        Me.Label7.Location = New System.Drawing.Point(84, 342)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(83, 19)
        Me.Label7.TabIndex = 74
        Me.Label7.Text = "Billed To:"
        '
        'lbl_cust
        '
        Me.lbl_cust.AutoSize = True
        Me.lbl_cust.Font = New System.Drawing.Font("Times New Roman", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_cust.Location = New System.Drawing.Point(173, 344)
        Me.lbl_cust.Name = "lbl_cust"
        Me.lbl_cust.Size = New System.Drawing.Size(56, 19)
        Me.lbl_cust.TabIndex = 75
        Me.lbl_cust.Text = "Label8"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Times New Roman", 10.2!, System.Drawing.FontStyle.Bold)
        Me.Label8.Location = New System.Drawing.Point(369, 342)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(76, 19)
        Me.Label8.TabIndex = 76
        Me.Label8.Text = "Issue By:"
        '
        'lbl_staff
        '
        Me.lbl_staff.AutoSize = True
        Me.lbl_staff.Font = New System.Drawing.Font("Times New Roman", 10.2!)
        Me.lbl_staff.Location = New System.Drawing.Point(451, 342)
        Me.lbl_staff.Name = "lbl_staff"
        Me.lbl_staff.Size = New System.Drawing.Size(56, 19)
        Me.lbl_staff.TabIndex = 77
        Me.lbl_staff.Text = "Label9"
        '
        'grd_details
        '
        Me.grd_details.AllowUserToAddRows = False
        Me.grd_details.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.grd_details.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.grd_details.BackgroundColor = System.Drawing.Color.White
        Me.grd_details.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grd_details.Location = New System.Drawing.Point(64, 376)
        Me.grd_details.Name = "grd_details"
        Me.grd_details.RowHeadersWidth = 51
        Me.grd_details.RowTemplate.Height = 24
        Me.grd_details.Size = New System.Drawing.Size(876, 204)
        Me.grd_details.TabIndex = 78
        Me.grd_details.UseWaitCursor = True
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Times New Roman", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(217, 40)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(133, 26)
        Me.Label9.TabIndex = 79
        Me.Label9.Text = "Total Price:"
        '
        'lst_order
        '
        Me.lst_order.FormattingEnabled = True
        Me.lst_order.ItemHeight = 16
        Me.lst_order.Location = New System.Drawing.Point(1002, 113)
        Me.lst_order.Name = "lst_order"
        Me.lst_order.Size = New System.Drawing.Size(126, 468)
        Me.lst_order.TabIndex = 81
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.DarkSeaGreen
        Me.Label1.Font = New System.Drawing.Font("Segoe Print", 24.0!, System.Drawing.FontStyle.Bold)
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(514, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(166, 71)
        Me.Label1.TabIndex = 65
        Me.Label1.Text = "Invoice"
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
        Me.btn_back.Location = New System.Drawing.Point(21, 26)
        Me.btn_back.Name = "btn_back"
        Me.btn_back.ShadowDecoration.Parent = Me.btn_back
        Me.btn_back.Size = New System.Drawing.Size(106, 41)
        Me.btn_back.TabIndex = 64
        Me.btn_back.Text = "BACK"
        '
        'lbl_totalprice
        '
        Me.lbl_totalprice.AutoSize = True
        Me.lbl_totalprice.Font = New System.Drawing.Font("Times New Roman", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_totalprice.Location = New System.Drawing.Point(140, 101)
        Me.lbl_totalprice.Name = "lbl_totalprice"
        Me.lbl_totalprice.Size = New System.Drawing.Size(174, 68)
        Me.lbl_totalprice.TabIndex = 82
        Me.lbl_totalprice.Text = "RM 0"
        '
        'PictureBox2
        '
        Me.PictureBox2.BackgroundImage = Global.prj_AllAboutTennis_a180970.My.Resources.Resources.thankyou2
        Me.PictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox2.Location = New System.Drawing.Point(-3, 626)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(639, 238)
        Me.PictureBox2.TabIndex = 83
        Me.PictureBox2.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImage = Global.prj_AllAboutTennis_a180970.My.Resources.Resources.logo_tennis
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.PictureBox1.Location = New System.Drawing.Point(64, 113)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(198, 183)
        Me.PictureBox1.TabIndex = 66
        Me.PictureBox1.TabStop = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.DarkSeaGreen
        Me.Panel1.Controls.Add(Me.lbl_totalprice)
        Me.Panel1.Controls.Add(Me.Label9)
        Me.Panel1.Location = New System.Drawing.Point(626, 626)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(532, 238)
        Me.Panel1.TabIndex = 84
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.DarkSeaGreen
        Me.Panel2.Controls.Add(Me.btn_back)
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1161, 94)
        Me.Panel2.TabIndex = 85
        '
        'frm_invoice_a180970
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Honeydew
        Me.ClientSize = New System.Drawing.Size(1157, 869)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.lst_order)
        Me.Controls.Add(Me.grd_details)
        Me.Controls.Add(Me.lbl_staff)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.lbl_cust)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.lbl_date)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.lbl_invoiceno)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frm_invoice_a180970"
        Me.Text = "Invoice All About Tennis"
        CType(Me.grd_details, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents lbl_invoiceno As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents lbl_date As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents lbl_cust As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents lbl_staff As Label
    Friend WithEvents grd_details As DataGridView
    Friend WithEvents Label9 As Label
    Friend WithEvents lst_order As ListBox
    Friend WithEvents Label1 As Label
    Friend WithEvents btn_back As Guna.UI2.WinForms.Guna2GradientButton
    Friend WithEvents lbl_totalprice As Label
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
End Class
