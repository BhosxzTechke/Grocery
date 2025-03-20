<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmdiscountcashier
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmdiscountcashier))
        Me.Guna2BorderlessForm1 = New Guna.UI2.WinForms.Guna2BorderlessForm(Me.components)
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Button10 = New System.Windows.Forms.Button()
        Me.cboDescrip = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtdiscount = New Guna.UI2.WinForms.Guna2TextBox()
        Me.btnselect = New Guna.UI2.WinForms.Guna2Button()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Guna2BorderlessForm1
        '
        Me.Guna2BorderlessForm1.ContainerControl = Me
        Me.Guna2BorderlessForm1.DockIndicatorTransparencyValue = 0.6R
        Me.Guna2BorderlessForm1.TransparentWhileDrag = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Label1.Location = New System.Drawing.Point(14, 13)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(108, 18)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Add Discount"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(31, Byte), Integer))
        Me.Panel2.Controls.Add(Me.Button10)
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(642, 55)
        Me.Panel2.TabIndex = 3
        '
        'Button10
        '
        Me.Button10.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button10.FlatAppearance.BorderSize = 0
        Me.Button10.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button10.Font = New System.Drawing.Font("Century Gothic", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button10.Image = CType(resources.GetObject("Button10.Image"), System.Drawing.Image)
        Me.Button10.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button10.Location = New System.Drawing.Point(762, 3)
        Me.Button10.Name = "Button10"
        Me.Button10.Size = New System.Drawing.Size(38, 29)
        Me.Button10.TabIndex = 13
        Me.Button10.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Button10.UseVisualStyleBackColor = True
        '
        'cboDescrip
        '
        Me.cboDescrip.BackColor = System.Drawing.Color.Transparent
        Me.cboDescrip.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cboDescrip.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboDescrip.FocusedColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cboDescrip.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cboDescrip.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.cboDescrip.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.cboDescrip.ItemHeight = 30
        Me.cboDescrip.Location = New System.Drawing.Point(116, 105)
        Me.cboDescrip.Name = "cboDescrip"
        Me.cboDescrip.Size = New System.Drawing.Size(477, 36)
        Me.cboDescrip.TabIndex = 5
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(14, 124)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(83, 17)
        Me.Label3.TabIndex = 27
        Me.Label3.Text = "Description:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(14, 183)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(67, 17)
        Me.Label2.TabIndex = 28
        Me.Label2.Text = "Discount:"
        '
        'txtdiscount
        '
        Me.txtdiscount.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtdiscount.DefaultText = ""
        Me.txtdiscount.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtdiscount.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtdiscount.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtdiscount.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtdiscount.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtdiscount.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtdiscount.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtdiscount.Location = New System.Drawing.Point(116, 169)
        Me.txtdiscount.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtdiscount.Name = "txtdiscount"
        Me.txtdiscount.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtdiscount.PlaceholderText = ""
        Me.txtdiscount.SelectedText = ""
        Me.txtdiscount.Size = New System.Drawing.Size(158, 31)
        Me.txtdiscount.TabIndex = 29
        '
        'btnselect
        '
        Me.btnselect.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnselect.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnselect.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnselect.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnselect.FillColor = System.Drawing.Color.Teal
        Me.btnselect.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btnselect.ForeColor = System.Drawing.Color.White
        Me.btnselect.Location = New System.Drawing.Point(159, 219)
        Me.btnselect.Name = "btnselect"
        Me.btnselect.Size = New System.Drawing.Size(115, 27)
        Me.btnselect.TabIndex = 46
        Me.btnselect.Text = "Select"
        '
        'frmdiscountcashier
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(642, 339)
        Me.Controls.Add(Me.btnselect)
        Me.Controls.Add(Me.txtdiscount)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.cboDescrip)
        Me.Controls.Add(Me.Panel2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmdiscountcashier"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmdiscountcashier"
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Guna2BorderlessForm1 As Guna.UI2.WinForms.Guna2BorderlessForm
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Button10 As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cboDescrip As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents txtdiscount As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents btnselect As Guna.UI2.WinForms.Guna2Button
End Class
