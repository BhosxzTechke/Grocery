<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmdeliverylist
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmdeliverylist))
        Me.Guna2BorderlessForm1 = New Guna.UI2.WinForms.Guna2BorderlessForm(Me.components)
        Me.Guna2AnimateWindow1 = New Guna.UI2.WinForms.Guna2AnimateWindow(Me.components)
        Me.BackgroundWorker1 = New System.ComponentModel.BackgroundWorker()
        Me.Guna2Elipse1 = New Guna.UI2.WinForms.Guna2Elipse(Me.components)
        Me.Button1 = New System.Windows.Forms.Button()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewCalendarColumn1 = New JimbosPharma.DataGridViewCalendarColumn()
        Me.DataGridViewTextBoxColumn10 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn17 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Guna2CustomGradientPanel1 = New Guna.UI2.WinForms.Guna2CustomGradientPanel()
        Me.Guna2GradientButton1 = New Guna.UI2.WinForms.Guna2GradientButton()
        Me.suppliercombo = New System.Windows.Forms.ComboBox()
        Me.btnsavinginvent = New Guna.UI2.WinForms.Guna2GradientButton()
        Me.txtbatch = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.supid = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ddate = New System.Windows.Forms.DateTimePicker()
        Me.txtcost = New System.Windows.Forms.TextBox()
        Me.Guna2DataGridView1 = New Guna.UI2.WinForms.Guna2DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column14 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ProductID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ProductNamecolumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Quantity = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CostPriceitem = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.reorder = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.calendar = New JimbosPharma.DataGridViewCalendarColumn()
        Me.check = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.lbldelid = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Guna2CustomGradientPanel1.SuspendLayout()
        CType(Me.Guna2DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Guna2BorderlessForm1
        '
        Me.Guna2BorderlessForm1.ContainerControl = Me
        Me.Guna2BorderlessForm1.DockIndicatorTransparencyValue = 0.6R
        Me.Guna2BorderlessForm1.ResizeForm = False
        Me.Guna2BorderlessForm1.TransparentWhileDrag = True
        '
        'Guna2Elipse1
        '
        Me.Guna2Elipse1.BorderRadius = 30
        Me.Guna2Elipse1.TargetControl = Me.Button1
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Maroon
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.ForeColor = System.Drawing.Color.White
        Me.Button1.Location = New System.Drawing.Point(1186, 382)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(111, 29)
        Me.Button1.TabIndex = 43
        Me.Button1.Text = "Clear"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.HeaderText = "DeliveryID"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ReadOnly = True
        Me.DataGridViewTextBoxColumn3.Visible = False
        Me.DataGridViewTextBoxColumn3.Width = 101
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewTextBoxColumn4.HeaderText = "ProductID"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.ReadOnly = True
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.DataGridViewTextBoxColumn5.HeaderText = "Barcode"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.ReadOnly = True
        Me.DataGridViewTextBoxColumn5.Width = 150
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.DataGridViewTextBoxColumn6.HeaderText = "Item Description"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        Me.DataGridViewTextBoxColumn6.ReadOnly = True
        Me.DataGridViewTextBoxColumn6.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridViewTextBoxColumn6.Width = 180
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewTextBoxColumn7.DividerWidth = 1
        Me.DataGridViewTextBoxColumn7.HeaderText = "Quantity"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        Me.DataGridViewTextBoxColumn7.ReadOnly = True
        Me.DataGridViewTextBoxColumn7.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewTextBoxColumn8.DividerWidth = 1
        Me.DataGridViewTextBoxColumn8.HeaderText = "Cost Price"
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        Me.DataGridViewTextBoxColumn8.ReadOnly = True
        Me.DataGridViewTextBoxColumn8.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        '
        'DataGridViewTextBoxColumn9
        '
        Me.DataGridViewTextBoxColumn9.HeaderText = "Reorder Level"
        Me.DataGridViewTextBoxColumn9.Name = "DataGridViewTextBoxColumn9"
        Me.DataGridViewTextBoxColumn9.ReadOnly = True
        Me.DataGridViewTextBoxColumn9.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridViewTextBoxColumn9.Width = 127
        '
        'DataGridViewCalendarColumn1
        '
        Me.DataGridViewCalendarColumn1.HeaderText = "Expiration Date"
        Me.DataGridViewCalendarColumn1.Name = "DataGridViewCalendarColumn1"
        Me.DataGridViewCalendarColumn1.Width = 112
        '
        'DataGridViewTextBoxColumn10
        '
        Me.DataGridViewTextBoxColumn10.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn10.DividerWidth = 1
        Me.DataGridViewTextBoxColumn10.HeaderText = "#                "
        Me.DataGridViewTextBoxColumn10.Name = "DataGridViewTextBoxColumn10"
        Me.DataGridViewTextBoxColumn10.Visible = False
        '
        'DataGridViewTextBoxColumn17
        '
        Me.DataGridViewTextBoxColumn17.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.DataGridViewTextBoxColumn17.DividerWidth = 1
        Me.DataGridViewTextBoxColumn17.HeaderText = "Sales Price"
        Me.DataGridViewTextBoxColumn17.Name = "DataGridViewTextBoxColumn17"
        Me.DataGridViewTextBoxColumn17.ReadOnly = True
        Me.DataGridViewTextBoxColumn17.Visible = False
        Me.DataGridViewTextBoxColumn17.Width = 250
        '
        'Guna2CustomGradientPanel1
        '
        Me.Guna2CustomGradientPanel1.BackgroundImage = CType(resources.GetObject("Guna2CustomGradientPanel1.BackgroundImage"), System.Drawing.Image)
        Me.Guna2CustomGradientPanel1.Controls.Add(Me.Guna2GradientButton1)
        Me.Guna2CustomGradientPanel1.Controls.Add(Me.suppliercombo)
        Me.Guna2CustomGradientPanel1.Controls.Add(Me.btnsavinginvent)
        Me.Guna2CustomGradientPanel1.Controls.Add(Me.txtbatch)
        Me.Guna2CustomGradientPanel1.Controls.Add(Me.Label4)
        Me.Guna2CustomGradientPanel1.Controls.Add(Me.Label2)
        Me.Guna2CustomGradientPanel1.Controls.Add(Me.Label5)
        Me.Guna2CustomGradientPanel1.Controls.Add(Me.supid)
        Me.Guna2CustomGradientPanel1.Controls.Add(Me.Label1)
        Me.Guna2CustomGradientPanel1.Controls.Add(Me.ddate)
        Me.Guna2CustomGradientPanel1.Controls.Add(Me.txtcost)
        Me.Guna2CustomGradientPanel1.FillColor = System.Drawing.Color.Transparent
        Me.Guna2CustomGradientPanel1.FillColor2 = System.Drawing.Color.Transparent
        Me.Guna2CustomGradientPanel1.FillColor3 = System.Drawing.Color.Transparent
        Me.Guna2CustomGradientPanel1.FillColor4 = System.Drawing.Color.Transparent
        Me.Guna2CustomGradientPanel1.Location = New System.Drawing.Point(14, 417)
        Me.Guna2CustomGradientPanel1.Name = "Guna2CustomGradientPanel1"
        Me.Guna2CustomGradientPanel1.Size = New System.Drawing.Size(1340, 359)
        Me.Guna2CustomGradientPanel1.TabIndex = 36
        '
        'Guna2GradientButton1
        '
        Me.Guna2GradientButton1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Guna2GradientButton1.BackColor = System.Drawing.Color.Transparent
        Me.Guna2GradientButton1.BorderColor = System.Drawing.Color.DimGray
        Me.Guna2GradientButton1.BorderRadius = 5
        Me.Guna2GradientButton1.BorderThickness = 1
        Me.Guna2GradientButton1.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.Guna2GradientButton1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.Guna2GradientButton1.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.Guna2GradientButton1.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.Guna2GradientButton1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.Guna2GradientButton1.FillColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Guna2GradientButton1.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Guna2GradientButton1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Guna2GradientButton1.ForeColor = System.Drawing.Color.Black
        Me.Guna2GradientButton1.Location = New System.Drawing.Point(597, 7)
        Me.Guna2GradientButton1.Name = "Guna2GradientButton1"
        Me.Guna2GradientButton1.Size = New System.Drawing.Size(220, 35)
        Me.Guna2GradientButton1.TabIndex = 30
        Me.Guna2GradientButton1.Text = "Browse Product..."
        '
        'suppliercombo
        '
        Me.suppliercombo.FormattingEnabled = True
        Me.suppliercombo.Location = New System.Drawing.Point(852, 109)
        Me.suppliercombo.Name = "suppliercombo"
        Me.suppliercombo.Size = New System.Drawing.Size(398, 24)
        Me.suppliercombo.TabIndex = 44
        '
        'btnsavinginvent
        '
        Me.btnsavinginvent.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnsavinginvent.BackColor = System.Drawing.Color.Transparent
        Me.btnsavinginvent.BorderColor = System.Drawing.Color.DimGray
        Me.btnsavinginvent.BorderRadius = 10
        Me.btnsavinginvent.BorderThickness = 1
        Me.btnsavinginvent.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnsavinginvent.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnsavinginvent.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnsavinginvent.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnsavinginvent.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnsavinginvent.FillColor = System.Drawing.Color.White
        Me.btnsavinginvent.FillColor2 = System.Drawing.Color.White
        Me.btnsavinginvent.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btnsavinginvent.ForeColor = System.Drawing.Color.Black
        Me.btnsavinginvent.Location = New System.Drawing.Point(916, 249)
        Me.btnsavinginvent.Name = "btnsavinginvent"
        Me.btnsavinginvent.Size = New System.Drawing.Size(334, 45)
        Me.btnsavinginvent.TabIndex = 42
        Me.btnsavinginvent.Text = "Save to inventory"
        '
        'txtbatch
        '
        Me.txtbatch.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtbatch.Location = New System.Drawing.Point(201, 103)
        Me.txtbatch.Name = "txtbatch"
        Me.txtbatch.ReadOnly = True
        Me.txtbatch.Size = New System.Drawing.Size(302, 27)
        Me.txtbatch.TabIndex = 0
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(25, 171)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(159, 20)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Delivery Cost Price:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(724, 109)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(75, 20)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Supplier:"
        '
        'Label5
        '
        Me.Label5.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(724, 173)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(116, 20)
        Me.Label5.TabIndex = 31
        Me.Label5.Text = "Delivery Date:"
        '
        'supid
        '
        Me.supid.AutoSize = True
        Me.supid.ForeColor = System.Drawing.Color.Black
        Me.supid.Location = New System.Drawing.Point(767, 109)
        Me.supid.Name = "supid"
        Me.supid.Size = New System.Drawing.Size(0, 17)
        Me.supid.TabIndex = 33
        Me.supid.Visible = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(25, 110)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(80, 20)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Batch no."
        '
        'ddate
        '
        Me.ddate.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ddate.CalendarFont = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ddate.Location = New System.Drawing.Point(852, 169)
        Me.ddate.Name = "ddate"
        Me.ddate.Size = New System.Drawing.Size(398, 22)
        Me.ddate.TabIndex = 29
        '
        'txtcost
        '
        Me.txtcost.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtcost.Location = New System.Drawing.Point(201, 164)
        Me.txtcost.Name = "txtcost"
        Me.txtcost.Size = New System.Drawing.Size(302, 27)
        Me.txtcost.TabIndex = 7
        '
        'Guna2DataGridView1
        '
        Me.Guna2DataGridView1.AllowUserToAddRows = False
        Me.Guna2DataGridView1.AllowUserToDeleteRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.White
        Me.Guna2DataGridView1.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.Guna2DataGridView1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Guna2DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.Guna2DataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(232, Byte), Integer), CType(CType(234, Byte), Integer), CType(CType(237, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Guna2DataGridView1.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.Guna2DataGridView1.ColumnHeadersHeight = 35
        Me.Guna2DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing
        Me.Guna2DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.Column14, Me.ProductID, Me.Column6, Me.ProductNamecolumn, Me.Quantity, Me.CostPriceitem, Me.reorder, Me.calendar, Me.check})
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(243, Byte), Integer))
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.Guna2DataGridView1.DefaultCellStyle = DataGridViewCellStyle3
        Me.Guna2DataGridView1.GridColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(243, Byte), Integer))
        Me.Guna2DataGridView1.Location = New System.Drawing.Point(70, 94)
        Me.Guna2DataGridView1.Name = "Guna2DataGridView1"
        Me.Guna2DataGridView1.RowHeadersVisible = False
        Me.Guna2DataGridView1.RowTemplate.Height = 24
        Me.Guna2DataGridView1.Size = New System.Drawing.Size(1227, 287)
        Me.Guna2DataGridView1.TabIndex = 39
        Me.Guna2DataGridView1.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.LightGrid
        Me.Guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White
        Me.Guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.Font = Nothing
        Me.Guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty
        Me.Guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty
        Me.Guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty
        Me.Guna2DataGridView1.ThemeStyle.BackColor = System.Drawing.Color.White
        Me.Guna2DataGridView1.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(243, Byte), Integer))
        Me.Guna2DataGridView1.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(232, Byte), Integer), CType(CType(234, Byte), Integer), CType(CType(237, Byte), Integer))
        Me.Guna2DataGridView1.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.Guna2DataGridView1.ThemeStyle.HeaderStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2DataGridView1.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.Black
        Me.Guna2DataGridView1.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing
        Me.Guna2DataGridView1.ThemeStyle.HeaderStyle.Height = 35
        Me.Guna2DataGridView1.ThemeStyle.ReadOnly = False
        Me.Guna2DataGridView1.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White
        Me.Guna2DataGridView1.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.Guna2DataGridView1.ThemeStyle.RowsStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2DataGridView1.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black
        Me.Guna2DataGridView1.ThemeStyle.RowsStyle.Height = 24
        Me.Guna2DataGridView1.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(243, Byte), Integer))
        Me.Guna2DataGridView1.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Black
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn1.DividerWidth = 1
        Me.DataGridViewTextBoxColumn1.HeaderText = "#                "
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        Me.DataGridViewTextBoxColumn1.Visible = False
        Me.DataGridViewTextBoxColumn1.Width = 108
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn2.DividerWidth = 1
        Me.DataGridViewTextBoxColumn2.HeaderText = "LineItemID"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        Me.DataGridViewTextBoxColumn2.Visible = False
        Me.DataGridViewTextBoxColumn2.Width = 105
        '
        'Column14
        '
        Me.Column14.HeaderText = "DeliveryID"
        Me.Column14.Name = "Column14"
        Me.Column14.ReadOnly = True
        Me.Column14.Visible = False
        Me.Column14.Width = 101
        '
        'ProductID
        '
        Me.ProductID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.ProductID.HeaderText = "ProductID"
        Me.ProductID.Name = "ProductID"
        Me.ProductID.ReadOnly = True
        '
        'Column6
        '
        Me.Column6.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.Column6.HeaderText = "Barcode"
        Me.Column6.Name = "Column6"
        Me.Column6.ReadOnly = True
        Me.Column6.Width = 150
        '
        'ProductNamecolumn
        '
        Me.ProductNamecolumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.ProductNamecolumn.HeaderText = "Item Description"
        Me.ProductNamecolumn.Name = "ProductNamecolumn"
        Me.ProductNamecolumn.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.ProductNamecolumn.Width = 180
        '
        'Quantity
        '
        Me.Quantity.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Quantity.DividerWidth = 1
        Me.Quantity.HeaderText = "Quantity"
        Me.Quantity.Name = "Quantity"
        Me.Quantity.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        '
        'CostPriceitem
        '
        Me.CostPriceitem.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.CostPriceitem.DividerWidth = 1
        Me.CostPriceitem.HeaderText = "Cost Price Item"
        Me.CostPriceitem.Name = "CostPriceitem"
        Me.CostPriceitem.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        '
        'reorder
        '
        Me.reorder.HeaderText = "Stock Level"
        Me.reorder.Name = "reorder"
        Me.reorder.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.reorder.Width = 112
        '
        'calendar
        '
        Me.calendar.HeaderText = "Expiration Date"
        Me.calendar.Name = "calendar"
        Me.calendar.Width = 112
        '
        'check
        '
        Me.check.HeaderText = ""
        Me.check.Name = "check"
        Me.check.Width = 5
        '
        'lbldelid
        '
        Me.lbldelid.AutoSize = True
        Me.lbldelid.Location = New System.Drawing.Point(75, 2)
        Me.lbldelid.Name = "lbldelid"
        Me.lbldelid.Size = New System.Drawing.Size(0, 17)
        Me.lbldelid.TabIndex = 41
        Me.lbldelid.Visible = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Microsoft YaHei UI", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.DimGray
        Me.Label3.Location = New System.Drawing.Point(633, 21)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(132, 31)
        Me.Label3.TabIndex = 75
        Me.Label3.Text = "DELIVERY"
        '
        'Panel1
        '
        Me.Panel1.BackgroundImage = CType(resources.GetObject("Panel1.BackgroundImage"), System.Drawing.Image)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.Guna2CustomGradientPanel1)
        Me.Panel1.Controls.Add(Me.Button1)
        Me.Panel1.Controls.Add(Me.Guna2DataGridView1)
        Me.Panel1.Location = New System.Drawing.Point(-3, 1)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1372, 827)
        Me.Panel1.TabIndex = 100
        '
        'frmdeliverylist
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(1363, 820)
        Me.Controls.Add(Me.lbldelid)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmdeliverylist"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmdeliverylist"
        Me.Guna2CustomGradientPanel1.ResumeLayout(False)
        Me.Guna2CustomGradientPanel1.PerformLayout()
        CType(Me.Guna2DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Guna2BorderlessForm1 As Guna.UI2.WinForms.Guna2BorderlessForm
    Friend WithEvents Guna2AnimateWindow1 As Guna.UI2.WinForms.Guna2AnimateWindow
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn9 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn10 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn17 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewCalendarColumn1 As JimbosPharma.DataGridViewCalendarColumn
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
    Friend WithEvents Guna2Elipse1 As Guna.UI2.WinForms.Guna2Elipse
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents lbldelid As System.Windows.Forms.Label
    Friend WithEvents Guna2DataGridView1 As Guna.UI2.WinForms.Guna2DataGridView
    Friend WithEvents Guna2CustomGradientPanel1 As Guna.UI2.WinForms.Guna2CustomGradientPanel
    Friend WithEvents Guna2GradientButton1 As Guna.UI2.WinForms.Guna2GradientButton
    Friend WithEvents suppliercombo As System.Windows.Forms.ComboBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents btnsavinginvent As Guna.UI2.WinForms.Guna2GradientButton
    Friend WithEvents txtbatch As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents supid As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents ddate As System.Windows.Forms.DateTimePicker
    Friend WithEvents txtcost As System.Windows.Forms.TextBox
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column14 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ProductID As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ProductNamecolumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Quantity As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CostPriceitem As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents reorder As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents calendar As JimbosPharma.DataGridViewCalendarColumn
    Friend WithEvents check As System.Windows.Forms.DataGridViewCheckBoxColumn
End Class
