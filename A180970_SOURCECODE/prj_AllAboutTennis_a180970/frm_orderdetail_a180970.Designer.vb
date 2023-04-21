<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_orderdetail_a180970
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_orderdetail_a180970))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btn_back = New Guna.UI2.WinForms.Guna2GradientButton()
        Me.grd_orderdetail = New System.Windows.Forms.DataGridView()
        CType(Me.grd_orderdetail, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Segoe Print", 24.0!, System.Drawing.FontStyle.Bold)
        Me.Label1.Location = New System.Drawing.Point(283, 48)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(350, 71)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "ORDER DETAIL"
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
        Me.btn_back.TabIndex = 17
        Me.btn_back.Text = "BACK"
        '
        'grd_orderdetail
        '
        Me.grd_orderdetail.AllowUserToAddRows = False
        Me.grd_orderdetail.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.grd_orderdetail.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.grd_orderdetail.BackgroundColor = System.Drawing.Color.White
        Me.grd_orderdetail.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grd_orderdetail.Location = New System.Drawing.Point(131, 162)
        Me.grd_orderdetail.Name = "grd_orderdetail"
        Me.grd_orderdetail.RowHeadersWidth = 51
        Me.grd_orderdetail.RowTemplate.Height = 24
        Me.grd_orderdetail.Size = New System.Drawing.Size(672, 334)
        Me.grd_orderdetail.TabIndex = 18
        Me.grd_orderdetail.UseWaitCursor = True
        '
        'frm_orderdetail_a180970
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.prj_AllAboutTennis_a180970.My.Resources.Resources.list
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(927, 550)
        Me.Controls.Add(Me.grd_orderdetail)
        Me.Controls.Add(Me.btn_back)
        Me.Controls.Add(Me.Label1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frm_orderdetail_a180970"
        Me.Text = "AllAboutTennis Order Detail"
        CType(Me.grd_orderdetail, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents btn_back As Guna.UI2.WinForms.Guna2GradientButton
    Friend WithEvents grd_orderdetail As DataGridView
End Class
