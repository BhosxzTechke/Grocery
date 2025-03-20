<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmsupplierlist
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmsupplierlist))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Guna2BorderlessForm1 = New Guna.UI2.WinForms.Guna2BorderlessForm(Me.components)
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Guna2ContextMenuStrip1 = New Guna.UI2.WinForms.Guna2ContextMenuStrip()
        Me.EDITToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DELETEToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.searchboxing = New Guna.UI2.WinForms.Guna2TextBox()
        Me.dataprod = New Guna.UI2.WinForms.Guna2DataGridView()
        Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column14 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn10 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Image = New System.Windows.Forms.DataGridViewImageColumn()
        Me.DataGridViewTextBoxColumn11 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn12 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn13 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.View = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.Edit = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.Delete = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.btnew = New System.Windows.Forms.Button()
        Me.rc1 = New System.Windows.Forms.Label()
        Me.DataGridViewImageColumn1 = New System.Windows.Forms.DataGridViewImageColumn()
        Me.DataGridViewImageColumn2 = New System.Windows.Forms.DataGridViewImageColumn()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Guna2MessageDialog1 = New Guna.UI2.WinForms.Guna2MessageDialog()
        Me.Guna2ContextMenuStrip1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        CType(Me.dataprod, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Guna2BorderlessForm1
        '
        Me.Guna2BorderlessForm1.ContainerControl = Me
        Me.Guna2BorderlessForm1.DockIndicatorTransparencyValue = 0.6R
        Me.Guna2BorderlessForm1.ResizeForm = False
        Me.Guna2BorderlessForm1.TransparentWhileDrag = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(31, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(231, 32)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Manage Supplier"
        '
        'Guna2ContextMenuStrip1
        '
        Me.Guna2ContextMenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.Guna2ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.EDITToolStripMenuItem, Me.DELETEToolStripMenuItem})
        Me.Guna2ContextMenuStrip1.Name = "Guna2ContextMenuStrip1"
        Me.Guna2ContextMenuStrip1.RenderStyle.ArrowColor = System.Drawing.Color.FromArgb(CType(CType(151, Byte), Integer), CType(CType(143, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Guna2ContextMenuStrip1.RenderStyle.BorderColor = System.Drawing.Color.Gainsboro
        Me.Guna2ContextMenuStrip1.RenderStyle.ColorTable = Nothing
        Me.Guna2ContextMenuStrip1.RenderStyle.RoundedEdges = True
        Me.Guna2ContextMenuStrip1.RenderStyle.SelectionArrowColor = System.Drawing.Color.White
        Me.Guna2ContextMenuStrip1.RenderStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Guna2ContextMenuStrip1.RenderStyle.SelectionForeColor = System.Drawing.Color.White
        Me.Guna2ContextMenuStrip1.RenderStyle.SeparatorColor = System.Drawing.Color.Gainsboro
        Me.Guna2ContextMenuStrip1.RenderStyle.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault
        Me.Guna2ContextMenuStrip1.Size = New System.Drawing.Size(129, 52)
        '
        'EDITToolStripMenuItem
        '
        Me.EDITToolStripMenuItem.Name = "EDITToolStripMenuItem"
        Me.EDITToolStripMenuItem.Size = New System.Drawing.Size(128, 24)
        Me.EDITToolStripMenuItem.Text = "EDIT"
        '
        'DELETEToolStripMenuItem
        '
        Me.DELETEToolStripMenuItem.Name = "DELETEToolStripMenuItem"
        Me.DELETEToolStripMenuItem.Size = New System.Drawing.Size(128, 24)
        Me.DELETEToolStripMenuItem.Text = "DELETE"
        '
        'Panel2
        '
        Me.Panel2.BackgroundImage = CType(resources.GetObject("Panel2.BackgroundImage"), System.Drawing.Image)
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Controls.Add(Me.Panel3)
        Me.Panel2.Controls.Add(Me.rc1)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1340, 779)
        Me.Panel2.TabIndex = 21
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.Transparent
        Me.Panel3.Controls.Add(Me.searchboxing)
        Me.Panel3.Controls.Add(Me.dataprod)
        Me.Panel3.Controls.Add(Me.btnew)
        Me.Panel3.Location = New System.Drawing.Point(24, 68)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(1279, 494)
        Me.Panel3.TabIndex = 0
        '
        'searchboxing
        '
        Me.searchboxing.BackColor = System.Drawing.Color.Transparent
        Me.searchboxing.BorderColor = System.Drawing.Color.Transparent
        Me.searchboxing.BorderRadius = 1
        Me.searchboxing.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.searchboxing.DefaultText = ""
        Me.searchboxing.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.searchboxing.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.searchboxing.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.searchboxing.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.searchboxing.FillColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(202, Byte), Integer))
        Me.searchboxing.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.searchboxing.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.searchboxing.ForeColor = System.Drawing.Color.Black
        Me.searchboxing.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.searchboxing.IconLeft = CType(resources.GetObject("searchboxing.IconLeft"), System.Drawing.Image)
        Me.searchboxing.Location = New System.Drawing.Point(13, 20)
        Me.searchboxing.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.searchboxing.Name = "searchboxing"
        Me.searchboxing.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.searchboxing.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(149, Byte), Integer))
        Me.searchboxing.PlaceholderText = "Search Supplier Here"
        Me.searchboxing.SelectedText = ""
        Me.searchboxing.Size = New System.Drawing.Size(504, 40)
        Me.searchboxing.TabIndex = 39
        Me.searchboxing.WordWrap = False
        '
        'dataprod
        '
        Me.dataprod.AllowUserToAddRows = False
        Me.dataprod.AllowUserToResizeColumns = False
        Me.dataprod.AllowUserToResizeRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.White
        Me.dataprod.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.dataprod.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dataprod.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(232, Byte), Integer), CType(CType(234, Byte), Integer), CType(CType(237, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dataprod.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.dataprod.ColumnHeadersHeight = 50
        Me.dataprod.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing
        Me.dataprod.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn8, Me.DataGridViewTextBoxColumn9, Me.Column14, Me.DataGridViewTextBoxColumn10, Me.Image, Me.DataGridViewTextBoxColumn11, Me.DataGridViewTextBoxColumn12, Me.DataGridViewTextBoxColumn13, Me.View, Me.Edit, Me.Delete})
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle6.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle6.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(243, Byte), Integer))
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dataprod.DefaultCellStyle = DataGridViewCellStyle6
        Me.dataprod.GridColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(243, Byte), Integer))
        Me.dataprod.Location = New System.Drawing.Point(13, 73)
        Me.dataprod.Name = "dataprod"
        Me.dataprod.ReadOnly = True
        Me.dataprod.RowHeadersVisible = False
        Me.dataprod.RowTemplate.Height = 24
        Me.dataprod.Size = New System.Drawing.Size(1255, 413)
        Me.dataprod.TabIndex = 34
        Me.dataprod.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.LightGrid
        Me.dataprod.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White
        Me.dataprod.ThemeStyle.AlternatingRowsStyle.Font = Nothing
        Me.dataprod.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty
        Me.dataprod.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty
        Me.dataprod.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty
        Me.dataprod.ThemeStyle.BackColor = System.Drawing.Color.White
        Me.dataprod.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(243, Byte), Integer))
        Me.dataprod.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(232, Byte), Integer), CType(CType(234, Byte), Integer), CType(CType(237, Byte), Integer))
        Me.dataprod.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.dataprod.ThemeStyle.HeaderStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dataprod.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.Black
        Me.dataprod.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing
        Me.dataprod.ThemeStyle.HeaderStyle.Height = 50
        Me.dataprod.ThemeStyle.ReadOnly = True
        Me.dataprod.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White
        Me.dataprod.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.dataprod.ThemeStyle.RowsStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dataprod.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black
        Me.dataprod.ThemeStyle.RowsStyle.Height = 24
        Me.dataprod.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(243, Byte), Integer))
        Me.dataprod.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Black
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn8.DividerWidth = 1
        Me.DataGridViewTextBoxColumn8.HeaderText = "#                "
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        Me.DataGridViewTextBoxColumn8.ReadOnly = True
        Me.DataGridViewTextBoxColumn8.Width = 74
        '
        'DataGridViewTextBoxColumn9
        '
        Me.DataGridViewTextBoxColumn9.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.DataGridViewTextBoxColumn9.DividerWidth = 1
        Me.DataGridViewTextBoxColumn9.HeaderText = "ID"
        Me.DataGridViewTextBoxColumn9.Name = "DataGridViewTextBoxColumn9"
        Me.DataGridViewTextBoxColumn9.ReadOnly = True
        Me.DataGridViewTextBoxColumn9.Visible = False
        Me.DataGridViewTextBoxColumn9.Width = 120
        '
        'Column14
        '
        Me.Column14.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.Column14.HeaderText = "Company Name"
        Me.Column14.Name = "Column14"
        Me.Column14.ReadOnly = True
        Me.Column14.Width = 200
        '
        'DataGridViewTextBoxColumn10
        '
        Me.DataGridViewTextBoxColumn10.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.DataGridViewTextBoxColumn10.HeaderText = "Address"
        Me.DataGridViewTextBoxColumn10.Name = "DataGridViewTextBoxColumn10"
        Me.DataGridViewTextBoxColumn10.ReadOnly = True
        Me.DataGridViewTextBoxColumn10.Width = 320
        '
        'Image
        '
        Me.Image.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.Image.HeaderText = ""
        Me.Image.Name = "Image"
        Me.Image.ReadOnly = True
        Me.Image.Width = 30
        '
        'DataGridViewTextBoxColumn11
        '
        Me.DataGridViewTextBoxColumn11.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.DataGridViewTextBoxColumn11.DividerWidth = 1
        Me.DataGridViewTextBoxColumn11.HeaderText = "Contact Person"
        Me.DataGridViewTextBoxColumn11.Name = "DataGridViewTextBoxColumn11"
        Me.DataGridViewTextBoxColumn11.ReadOnly = True
        Me.DataGridViewTextBoxColumn11.Width = 200
        '
        'DataGridViewTextBoxColumn12
        '
        Me.DataGridViewTextBoxColumn12.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.DataGridViewTextBoxColumn12.HeaderText = "Mobile No."
        Me.DataGridViewTextBoxColumn12.Name = "DataGridViewTextBoxColumn12"
        Me.DataGridViewTextBoxColumn12.ReadOnly = True
        Me.DataGridViewTextBoxColumn12.Width = 200
        '
        'DataGridViewTextBoxColumn13
        '
        Me.DataGridViewTextBoxColumn13.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.DataGridViewTextBoxColumn13.HeaderText = "Tel No."
        Me.DataGridViewTextBoxColumn13.Name = "DataGridViewTextBoxColumn13"
        Me.DataGridViewTextBoxColumn13.ReadOnly = True
        Me.DataGridViewTextBoxColumn13.Width = 120
        '
        'View
        '
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.Chocolate
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle3.NullValue = "View"
        Me.View.DefaultCellStyle = DataGridViewCellStyle3
        Me.View.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.View.HeaderText = ""
        Me.View.Name = "View"
        Me.View.ReadOnly = True
        Me.View.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.View.Width = 5
        '
        'Edit
        '
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.Teal
        DataGridViewCellStyle4.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle4.NullValue = "Edit"
        Me.Edit.DefaultCellStyle = DataGridViewCellStyle4
        Me.Edit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Edit.HeaderText = ""
        Me.Edit.Name = "Edit"
        Me.Edit.ReadOnly = True
        Me.Edit.Width = 5
        '
        'Delete
        '
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle5.BackColor = System.Drawing.Color.Maroon
        DataGridViewCellStyle5.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle5.NullValue = "Delete"
        Me.Delete.DefaultCellStyle = DataGridViewCellStyle5
        Me.Delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Delete.HeaderText = ""
        Me.Delete.Name = "Delete"
        Me.Delete.ReadOnly = True
        Me.Delete.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Delete.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.Delete.Width = 21
        '
        'btnew
        '
        Me.btnew.BackColor = System.Drawing.Color.DarkSlateGray
        Me.btnew.BackgroundImage = CType(resources.GetObject("btnew.BackgroundImage"), System.Drawing.Image)
        Me.btnew.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnew.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnew.FlatAppearance.BorderSize = 0
        Me.btnew.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnew.ForeColor = System.Drawing.Color.White
        Me.btnew.Location = New System.Drawing.Point(1060, 20)
        Me.btnew.Name = "btnew"
        Me.btnew.Size = New System.Drawing.Size(208, 38)
        Me.btnew.TabIndex = 3
        Me.btnew.Text = "New Supplier"
        Me.btnew.UseVisualStyleBackColor = False
        '
        'rc1
        '
        Me.rc1.AutoSize = True
        Me.rc1.Location = New System.Drawing.Point(35, 574)
        Me.rc1.Name = "rc1"
        Me.rc1.Size = New System.Drawing.Size(51, 18)
        Me.rc1.TabIndex = 8
        Me.rc1.Text = "Label2"
        '
        'DataGridViewImageColumn1
        '
        Me.DataGridViewImageColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewImageColumn1.HeaderText = "                                      "
        Me.DataGridViewImageColumn1.Image = CType(resources.GetObject("DataGridViewImageColumn1.Image"), System.Drawing.Image)
        Me.DataGridViewImageColumn1.Name = "DataGridViewImageColumn1"
        Me.DataGridViewImageColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridViewImageColumn1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        '
        'DataGridViewImageColumn2
        '
        Me.DataGridViewImageColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewImageColumn2.HeaderText = "                                     "
        Me.DataGridViewImageColumn2.Image = CType(resources.GetObject("DataGridViewImageColumn2.Image"), System.Drawing.Image)
        Me.DataGridViewImageColumn2.Name = "DataGridViewImageColumn2"
        Me.DataGridViewImageColumn2.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridViewImageColumn2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn1.DividerWidth = 1
        Me.DataGridViewTextBoxColumn1.HeaderText = "#                "
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.DataGridViewTextBoxColumn2.DividerWidth = 1
        Me.DataGridViewTextBoxColumn2.HeaderText = "ID"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        Me.DataGridViewTextBoxColumn2.Visible = False
        Me.DataGridViewTextBoxColumn2.Width = 120
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewTextBoxColumn3.HeaderText = "Company Name"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ReadOnly = True
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn4.HeaderText = "Address"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.ReadOnly = True
        Me.DataGridViewTextBoxColumn4.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn5.DividerWidth = 1
        Me.DataGridViewTextBoxColumn5.HeaderText = "Contact Person"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.ReadOnly = True
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn6.HeaderText = "Mobile No."
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        Me.DataGridViewTextBoxColumn6.ReadOnly = True
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn7.HeaderText = "Tel no."
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        Me.DataGridViewTextBoxColumn7.ReadOnly = True
        '
        'Guna2MessageDialog1
        '
        Me.Guna2MessageDialog1.Buttons = Guna.UI2.WinForms.MessageDialogButtons.YesNo
        Me.Guna2MessageDialog1.Caption = Nothing
        Me.Guna2MessageDialog1.Icon = Guna.UI2.WinForms.MessageDialogIcon.None
        Me.Guna2MessageDialog1.Parent = Me
        Me.Guna2MessageDialog1.Style = Guna.UI2.WinForms.MessageDialogStyle.Light
        Me.Guna2MessageDialog1.Text = Nothing
        '
        'frmsupplierlist
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1340, 779)
        Me.Controls.Add(Me.Panel2)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmsupplierlist"
        Me.Text = "frmsupplier"
        Me.Guna2ContextMenuStrip1.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        CType(Me.dataprod, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Guna2BorderlessForm1 As Guna.UI2.WinForms.Guna2BorderlessForm
    Friend WithEvents btnew As System.Windows.Forms.Button
    Friend WithEvents DataGridViewImageColumn1 As System.Windows.Forms.DataGridViewImageColumn
    Friend WithEvents DataGridViewImageColumn2 As System.Windows.Forms.DataGridViewImageColumn
    Friend WithEvents Guna2ContextMenuStrip1 As Guna.UI2.WinForms.Guna2ContextMenuStrip
    Friend WithEvents EDITToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DELETEToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents rc1 As System.Windows.Forms.Label
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents dataprod As Guna.UI2.WinForms.Guna2DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn9 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column14 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn10 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Image As System.Windows.Forms.DataGridViewImageColumn
    Friend WithEvents DataGridViewTextBoxColumn11 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn12 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn13 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents View As System.Windows.Forms.DataGridViewButtonColumn
    Friend WithEvents Edit As System.Windows.Forms.DataGridViewButtonColumn
    Friend WithEvents Delete As System.Windows.Forms.DataGridViewButtonColumn
    Friend WithEvents searchboxing As Guna.UI2.WinForms.Guna2TextBox
    Public WithEvents Guna2MessageDialog1 As Guna.UI2.WinForms.Guna2MessageDialog
End Class
