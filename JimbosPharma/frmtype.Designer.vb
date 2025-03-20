<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmtype
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
        Me.Guna2BorderlessForm1 = New Guna.UI2.WinForms.Guna2BorderlessForm(Me.components)
        Me.lblID = New System.Windows.Forms.Label()
        Me.btnupdate = New System.Windows.Forms.Button()
        Me.btnsave = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.txttype = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Guna2Button2 = New Guna.UI2.WinForms.Guna2Button()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Guna2BorderlessForm1
        '
        Me.Guna2BorderlessForm1.ContainerControl = Me
        Me.Guna2BorderlessForm1.DockIndicatorTransparencyValue = 0.6R
        Me.Guna2BorderlessForm1.TransparentWhileDrag = True
        '
        'lblID
        '
        Me.lblID.AutoSize = True
        Me.lblID.Location = New System.Drawing.Point(15, 98)
        Me.lblID.Name = "lblID"
        Me.lblID.Size = New System.Drawing.Size(51, 17)
        Me.lblID.TabIndex = 14
        Me.lblID.Text = "Label2"
        Me.lblID.Visible = False
        '
        'btnupdate
        '
        Me.btnupdate.BackColor = System.Drawing.Color.DarkSlateGray
        Me.btnupdate.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnupdate.FlatAppearance.BorderSize = 0
        Me.btnupdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnupdate.ForeColor = System.Drawing.Color.White
        Me.btnupdate.Location = New System.Drawing.Point(292, 133)
        Me.btnupdate.Name = "btnupdate"
        Me.btnupdate.Size = New System.Drawing.Size(112, 37)
        Me.btnupdate.TabIndex = 12
        Me.btnupdate.Text = "Update"
        Me.btnupdate.UseVisualStyleBackColor = False
        '
        'btnsave
        '
        Me.btnsave.BackColor = System.Drawing.Color.DarkSlateGray
        Me.btnsave.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnsave.FlatAppearance.BorderSize = 0
        Me.btnsave.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnsave.ForeColor = System.Drawing.Color.White
        Me.btnsave.Location = New System.Drawing.Point(292, 133)
        Me.btnsave.Name = "btnsave"
        Me.btnsave.Size = New System.Drawing.Size(112, 37)
        Me.btnsave.TabIndex = 10
        Me.btnsave.Text = "Save"
        Me.btnsave.UseVisualStyleBackColor = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.Controls.Add(Me.lblID)
        Me.Panel1.Controls.Add(Me.txttype)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Location = New System.Drawing.Point(-2, 12)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(406, 158)
        Me.Panel1.TabIndex = 15
        '
        'txttype
        '
        Me.txttype.BorderColor = System.Drawing.Color.Gray
        Me.txttype.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txttype.DefaultText = ""
        Me.txttype.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txttype.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txttype.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txttype.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txttype.FillColor = System.Drawing.Color.LightGreen
        Me.txttype.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txttype.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txttype.ForeColor = System.Drawing.Color.Black
        Me.txttype.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txttype.Location = New System.Drawing.Point(18, 47)
        Me.txttype.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txttype.Name = "txttype"
        Me.txttype.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txttype.PlaceholderForeColor = System.Drawing.Color.Black
        Me.txttype.PlaceholderText = ""
        Me.txttype.SelectedText = ""
        Me.txttype.Size = New System.Drawing.Size(376, 47)
        Me.txttype.TabIndex = 82
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(182, 14)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(77, 29)
        Me.Label2.TabIndex = 80
        Me.Label2.Text = "TYPE"
        '
        'Guna2Button2
        '
        Me.Guna2Button2.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.Guna2Button2.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.Guna2Button2.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.Guna2Button2.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.Guna2Button2.FillColor = System.Drawing.Color.Red
        Me.Guna2Button2.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Guna2Button2.ForeColor = System.Drawing.Color.White
        Me.Guna2Button2.Location = New System.Drawing.Point(357, -1)
        Me.Guna2Button2.Name = "Guna2Button2"
        Me.Guna2Button2.Size = New System.Drawing.Size(47, 14)
        Me.Guna2Button2.TabIndex = 81
        '
        'frmtype
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DarkSlateGray
        Me.ClientSize = New System.Drawing.Size(404, 170)
        Me.Controls.Add(Me.btnsave)
        Me.Controls.Add(Me.Guna2Button2)
        Me.Controls.Add(Me.btnupdate)
        Me.Controls.Add(Me.Panel1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmtype"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmtype"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Guna2BorderlessForm1 As Guna.UI2.WinForms.Guna2BorderlessForm
    Friend WithEvents lblID As System.Windows.Forms.Label
    Friend WithEvents btnupdate As System.Windows.Forms.Button
    Friend WithEvents btnsave As System.Windows.Forms.Button
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Guna2Button2 As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents txttype As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
End Class
