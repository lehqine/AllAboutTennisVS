﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_brandlist_a180970
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_brandlist_a180970))
        Me.lbl_title = New System.Windows.Forms.Label()
        Me.btn_back = New Guna.UI2.WinForms.Guna2GradientButton()
        Me.grd_brand = New System.Windows.Forms.DataGridView()
        CType(Me.grd_brand, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lbl_title
        '
        Me.lbl_title.AutoSize = True
        Me.lbl_title.BackColor = System.Drawing.Color.Transparent
        Me.lbl_title.Font = New System.Drawing.Font("Segoe Print", 24.0!, System.Drawing.FontStyle.Bold)
        Me.lbl_title.Location = New System.Drawing.Point(255, 40)
        Me.lbl_title.Name = "lbl_title"
        Me.lbl_title.Size = New System.Drawing.Size(289, 71)
        Me.lbl_title.TabIndex = 0
        Me.lbl_title.Text = "BRAND LIST"
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
        Me.btn_back.TabIndex = 8
        Me.btn_back.Text = "BACK"
        '
        'grd_brand
        '
        Me.grd_brand.AllowUserToAddRows = False
        Me.grd_brand.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.grd_brand.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.grd_brand.BackgroundColor = System.Drawing.Color.White
        Me.grd_brand.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grd_brand.Location = New System.Drawing.Point(233, 143)
        Me.grd_brand.Name = "grd_brand"
        Me.grd_brand.RowHeadersWidth = 51
        Me.grd_brand.RowTemplate.Height = 24
        Me.grd_brand.Size = New System.Drawing.Size(352, 234)
        Me.grd_brand.TabIndex = 9
        Me.grd_brand.UseWaitCursor = True
        '
        'frm_brandlist_a180970
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.prj_AllAboutTennis_a180970.My.Resources.Resources.list
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.grd_brand)
        Me.Controls.Add(Me.btn_back)
        Me.Controls.Add(Me.lbl_title)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frm_brandlist_a180970"
        Me.Text = "AllAboutTennis Brand List"
        CType(Me.grd_brand, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lbl_title As Label
    Friend WithEvents btn_back As Guna.UI2.WinForms.Guna2GradientButton
    Friend WithEvents grd_brand As DataGridView
End Class
