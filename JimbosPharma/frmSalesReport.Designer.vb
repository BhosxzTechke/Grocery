<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSalesReport
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Guna2HtmlLabel1 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.Guna2DateTimePicker1 = New Guna.UI2.WinForms.Guna2DateTimePicker()
        Me.Guna2DateTimePicker2 = New Guna.UI2.WinForms.Guna2DateTimePicker()
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.cbouser = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel1.SuspendLayout()
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
        Me.Label1.BackColor = System.Drawing.Color.White
        Me.Label1.Font = New System.Drawing.Font("Copperplate Gothic Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(3, 11)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(160, 23)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Sales Report"
        '
        'Guna2HtmlLabel1
        '
        Me.Guna2HtmlLabel1.BackColor = System.Drawing.Color.White
        Me.Guna2HtmlLabel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2HtmlLabel1.Location = New System.Drawing.Point(65, 67)
        Me.Guna2HtmlLabel1.Name = "Guna2HtmlLabel1"
        Me.Guna2HtmlLabel1.Size = New System.Drawing.Size(189, 22)
        Me.Guna2HtmlLabel1.TabIndex = 3
        Me.Guna2HtmlLabel1.Text = "Date covered (from - To)"
        '
        'Guna2DateTimePicker1
        '
        Me.Guna2DateTimePicker1.Checked = True
        Me.Guna2DateTimePicker1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Guna2DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.Guna2DateTimePicker1.Location = New System.Drawing.Point(276, 53)
        Me.Guna2DateTimePicker1.MaxDate = New Date(9998, 12, 31, 0, 0, 0, 0)
        Me.Guna2DateTimePicker1.MinDate = New Date(1753, 1, 1, 0, 0, 0, 0)
        Me.Guna2DateTimePicker1.Name = "Guna2DateTimePicker1"
        Me.Guna2DateTimePicker1.Size = New System.Drawing.Size(221, 36)
        Me.Guna2DateTimePicker1.TabIndex = 4
        Me.Guna2DateTimePicker1.Value = New Date(2024, 10, 4, 7, 52, 13, 796)
        '
        'Guna2DateTimePicker2
        '
        Me.Guna2DateTimePicker2.Checked = True
        Me.Guna2DateTimePicker2.FillColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Guna2DateTimePicker2.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Guna2DateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.Guna2DateTimePicker2.Location = New System.Drawing.Point(522, 53)
        Me.Guna2DateTimePicker2.MaxDate = New Date(9998, 12, 31, 0, 0, 0, 0)
        Me.Guna2DateTimePicker2.MinDate = New Date(1753, 1, 1, 0, 0, 0, 0)
        Me.Guna2DateTimePicker2.Name = "Guna2DateTimePicker2"
        Me.Guna2DateTimePicker2.Size = New System.Drawing.Size(221, 36)
        Me.Guna2DateTimePicker2.TabIndex = 5
        Me.Guna2DateTimePicker2.Value = New Date(2024, 10, 4, 7, 52, 13, 796)
        '
        'ReportViewer1
        '
        Me.ReportViewer1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ReportViewer1.Location = New System.Drawing.Point(65, 107)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.Size = New System.Drawing.Size(1113, 538)
        Me.ReportViewer1.TabIndex = 6
        '
        'cbouser
        '
        Me.cbouser.BackColor = System.Drawing.Color.Transparent
        Me.cbouser.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cbouser.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbouser.FocusedColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cbouser.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cbouser.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.cbouser.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.cbouser.ItemHeight = 30
        Me.cbouser.Location = New System.Drawing.Point(780, 53)
        Me.cbouser.Name = "cbouser"
        Me.cbouser.Size = New System.Drawing.Size(307, 36)
        Me.cbouser.TabIndex = 7
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Teal
        Me.Button1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.White
        Me.Button1.Location = New System.Drawing.Point(1093, 60)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(85, 29)
        Me.Button1.TabIndex = 15
        Me.Button1.Text = "Show"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.Firebrick
        Me.Button2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button2.FlatAppearance.BorderSize = 0
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.ForeColor = System.Drawing.Color.White
        Me.Button2.Location = New System.Drawing.Point(1146, -1)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(89, 13)
        Me.Button2.TabIndex = 16
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.cbouser)
        Me.Panel1.Controls.Add(Me.Guna2HtmlLabel1)
        Me.Panel1.Controls.Add(Me.Guna2DateTimePicker1)
        Me.Panel1.Controls.Add(Me.Guna2DateTimePicker2)
        Me.Panel1.Controls.Add(Me.Button1)
        Me.Panel1.Location = New System.Drawing.Point(0, 12)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1235, 681)
        Me.Panel1.TabIndex = 17
        '
        'frmSalesReport
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DarkSlateGray
        Me.ClientSize = New System.Drawing.Size(1233, 692)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmSalesReport"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmSalesReport"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Guna2BorderlessForm1 As Guna.UI2.WinForms.Guna2BorderlessForm
    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents Guna2DateTimePicker2 As Guna.UI2.WinForms.Guna2DateTimePicker
    Friend WithEvents Guna2DateTimePicker1 As Guna.UI2.WinForms.Guna2DateTimePicker
    Friend WithEvents Guna2HtmlLabel1 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cbouser As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
End Class
