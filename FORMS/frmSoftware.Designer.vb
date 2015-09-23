<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSoftware
    Inherits System.Windows.Forms.Form

    'Форма переопределяет dispose для очистки списка компонентов.
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

    'Является обязательной для конструктора форм Windows Forms
    Private components As System.ComponentModel.IContainer

    'Примечание: следующая процедура является обязательной для конструктора форм Windows Forms
    'Для ее изменения используйте конструктор форм Windows Form.  
    'Не изменяйте ее в редакторе исходного кода.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmSoftware))
        Me.gbTree = New System.Windows.Forms.GroupBox()
        Me.TableLayoutPanel3 = New System.Windows.Forms.TableLayoutPanel()
        Me.treebranche = New System.Windows.Forms.ComboBox()
        Me.txtSearch = New System.Windows.Forms.TextBox()
        Me.lstGroups = New System.Windows.Forms.TreeView()
        Me.ToolStrip2 = New System.Windows.Forms.ToolStrip()
        Me.btnSearch = New System.Windows.Forms.ToolStripButton()
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.gbSoftware = New System.Windows.Forms.GroupBox()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.CheckBox3_manual = New System.Windows.Forms.CheckBox()
        Me.cmbSoftware = New System.Windows.Forms.ComboBox()
        Me.lstSoftware = New System.Windows.Forms.ListView()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cmbTipLicense = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cmbTipPo = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.dtGok = New System.Windows.Forms.DateTimePicker()
        Me.txtLicKey = New System.Windows.Forms.TextBox()
        Me.DTInstall = New System.Windows.Forms.DateTimePicker()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.cmbSoftPr = New System.Windows.Forms.ComboBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.btnAdd = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.btnDelete = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.btnCancel = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripButton1 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator4 = New System.Windows.Forms.ToolStripSeparator()
        Me.CheckBox2 = New System.Windows.Forms.CheckBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.gbTree.SuspendLayout()
        Me.TableLayoutPanel3.SuspendLayout()
        Me.ToolStrip2.SuspendLayout()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        Me.gbSoftware.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.ToolStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'gbTree
        '
        Me.gbTree.Controls.Add(Me.TableLayoutPanel3)
        Me.gbTree.Dock = System.Windows.Forms.DockStyle.Fill
        Me.gbTree.Location = New System.Drawing.Point(0, 0)
        Me.gbTree.Name = "gbTree"
        Me.gbTree.Size = New System.Drawing.Size(306, 521)
        Me.gbTree.TabIndex = 0
        Me.gbTree.TabStop = False
        Me.gbTree.Text = "Дерево"
        '
        'TableLayoutPanel3
        '
        Me.TableLayoutPanel3.ColumnCount = 2
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 35.0!))
        Me.TableLayoutPanel3.Controls.Add(Me.treebranche, 0, 1)
        Me.TableLayoutPanel3.Controls.Add(Me.txtSearch, 0, 0)
        Me.TableLayoutPanel3.Controls.Add(Me.lstGroups, 0, 2)
        Me.TableLayoutPanel3.Controls.Add(Me.ToolStrip2, 1, 0)
        Me.TableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel3.Location = New System.Drawing.Point(3, 16)
        Me.TableLayoutPanel3.Name = "TableLayoutPanel3"
        Me.TableLayoutPanel3.RowCount = 3
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel3.Size = New System.Drawing.Size(300, 502)
        Me.TableLayoutPanel3.TabIndex = 5
        '
        'treebranche
        '
        Me.TableLayoutPanel3.SetColumnSpan(Me.treebranche, 2)
        Me.treebranche.Dock = System.Windows.Forms.DockStyle.Fill
        Me.treebranche.FormattingEnabled = True
        Me.treebranche.Location = New System.Drawing.Point(3, 33)
        Me.treebranche.Name = "treebranche"
        Me.treebranche.Size = New System.Drawing.Size(294, 21)
        Me.treebranche.TabIndex = 6
        '
        'txtSearch
        '
        Me.txtSearch.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtSearch.Location = New System.Drawing.Point(3, 3)
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.Size = New System.Drawing.Size(259, 20)
        Me.txtSearch.TabIndex = 2
        '
        'lstGroups
        '
        Me.TableLayoutPanel3.SetColumnSpan(Me.lstGroups, 2)
        Me.lstGroups.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lstGroups.FullRowSelect = True
        Me.lstGroups.Location = New System.Drawing.Point(3, 63)
        Me.lstGroups.Name = "lstGroups"
        Me.lstGroups.Size = New System.Drawing.Size(294, 436)
        Me.lstGroups.TabIndex = 0
        '
        'ToolStrip2
        '
        Me.ToolStrip2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ToolStrip2.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.ToolStrip2.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnSearch})
        Me.ToolStrip2.Location = New System.Drawing.Point(265, 0)
        Me.ToolStrip2.Name = "ToolStrip2"
        Me.ToolStrip2.RenderMode = System.Windows.Forms.ToolStripRenderMode.System
        Me.ToolStrip2.Size = New System.Drawing.Size(35, 30)
        Me.ToolStrip2.TabIndex = 7
        Me.ToolStrip2.Text = "ToolStrip2"
        '
        'btnSearch
        '
        Me.btnSearch.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btnSearch.Image = CType(resources.GetObject("btnSearch.Image"), System.Drawing.Image)
        Me.btnSearch.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(23, 27)
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer1.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer1.Name = "SplitContainer1"
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.gbTree)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.gbSoftware)
        Me.SplitContainer1.Size = New System.Drawing.Size(997, 521)
        Me.SplitContainer1.SplitterDistance = 306
        Me.SplitContainer1.TabIndex = 2
        '
        'gbSoftware
        '
        Me.gbSoftware.Controls.Add(Me.TableLayoutPanel1)
        Me.gbSoftware.Controls.Add(Me.Label1)
        Me.gbSoftware.Dock = System.Windows.Forms.DockStyle.Fill
        Me.gbSoftware.Location = New System.Drawing.Point(0, 0)
        Me.gbSoftware.Name = "gbSoftware"
        Me.gbSoftware.Size = New System.Drawing.Size(687, 521)
        Me.gbSoftware.TabIndex = 0
        Me.gbSoftware.TabStop = False
        Me.gbSoftware.Text = "Установленное программное обеспечение"
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 4
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel1.Controls.Add(Me.CheckBox3_manual, 1, 5)
        Me.TableLayoutPanel1.Controls.Add(Me.cmbSoftware, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.lstSoftware, 0, 7)
        Me.TableLayoutPanel1.Controls.Add(Me.CheckBox1, 3, 5)
        Me.TableLayoutPanel1.Controls.Add(Me.Label2, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.cmbTipLicense, 1, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.Label3, 2, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.cmbTipPo, 3, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.Label4, 0, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.dtGok, 2, 5)
        Me.TableLayoutPanel1.Controls.Add(Me.txtLicKey, 0, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.DTInstall, 0, 5)
        Me.TableLayoutPanel1.Controls.Add(Me.Label5, 2, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.Label6, 2, 4)
        Me.TableLayoutPanel1.Controls.Add(Me.cmbSoftPr, 2, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.Label7, 0, 4)
        Me.TableLayoutPanel1.Controls.Add(Me.ToolStrip1, 0, 6)
        Me.TableLayoutPanel1.Controls.Add(Me.CheckBox2, 2, 6)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(3, 16)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 8
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(681, 502)
        Me.TableLayoutPanel1.TabIndex = 19
        '
        'CheckBox3_manual
        '
        Me.CheckBox3_manual.AutoSize = True
        Me.CheckBox3_manual.Location = New System.Drawing.Point(180, 110)
        Me.CheckBox3_manual.Name = "CheckBox3_manual"
        Me.CheckBox3_manual.Size = New System.Drawing.Size(137, 17)
        Me.CheckBox3_manual.TabIndex = 22
        Me.CheckBox3_manual.Text = "Установлено вручную"
        Me.CheckBox3_manual.UseVisualStyleBackColor = True
        '
        'cmbSoftware
        '
        Me.cmbSoftware.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
        Me.cmbSoftware.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.TableLayoutPanel1.SetColumnSpan(Me.cmbSoftware, 4)
        Me.cmbSoftware.Dock = System.Windows.Forms.DockStyle.Fill
        Me.cmbSoftware.FormattingEnabled = True
        Me.cmbSoftware.Location = New System.Drawing.Point(3, 3)
        Me.cmbSoftware.Name = "cmbSoftware"
        Me.cmbSoftware.Size = New System.Drawing.Size(675, 21)
        Me.cmbSoftware.TabIndex = 1
        '
        'lstSoftware
        '
        Me.TableLayoutPanel1.SetColumnSpan(Me.lstSoftware, 4)
        Me.lstSoftware.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lstSoftware.FullRowSelect = True
        Me.lstSoftware.GridLines = True
        Me.lstSoftware.HideSelection = False
        Me.lstSoftware.Location = New System.Drawing.Point(3, 161)
        Me.lstSoftware.MultiSelect = False
        Me.lstSoftware.Name = "lstSoftware"
        Me.lstSoftware.Size = New System.Drawing.Size(675, 338)
        Me.lstSoftware.TabIndex = 17
        Me.lstSoftware.UseCompatibleStateImageBehavior = False
        Me.lstSoftware.View = System.Windows.Forms.View.Details
        '
        'CheckBox1
        '
        Me.CheckBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.Location = New System.Drawing.Point(545, 111)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(133, 17)
        Me.CheckBox1.TabIndex = 18
        Me.CheckBox1.Text = "Беcсрочно"
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(3, 34)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(171, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Тип лицензии:"
        '
        'cmbTipLicense
        '
        Me.cmbTipLicense.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
        Me.cmbTipLicense.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmbTipLicense.Dock = System.Windows.Forms.DockStyle.Fill
        Me.cmbTipLicense.FormattingEnabled = True
        Me.cmbTipLicense.Location = New System.Drawing.Point(180, 30)
        Me.cmbTipLicense.Name = "cmbTipLicense"
        Me.cmbTipLicense.Size = New System.Drawing.Size(210, 21)
        Me.cmbTipLicense.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(396, 34)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(143, 13)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Тип П.О.:"
        '
        'cmbTipPo
        '
        Me.cmbTipPo.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
        Me.cmbTipPo.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmbTipPo.Dock = System.Windows.Forms.DockStyle.Fill
        Me.cmbTipPo.FormattingEnabled = True
        Me.cmbTipPo.Location = New System.Drawing.Point(545, 30)
        Me.cmbTipPo.Name = "cmbTipPo"
        Me.cmbTipPo.Size = New System.Drawing.Size(133, 21)
        Me.cmbTipPo.TabIndex = 5
        '
        'Label4
        '
        Me.Label4.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(3, 54)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(171, 13)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Лицензионный номер:"
        '
        'dtGok
        '
        Me.dtGok.Location = New System.Drawing.Point(396, 110)
        Me.dtGok.Name = "dtGok"
        Me.dtGok.Size = New System.Drawing.Size(140, 20)
        Me.dtGok.TabIndex = 13
        '
        'txtLicKey
        '
        Me.TableLayoutPanel1.SetColumnSpan(Me.txtLicKey, 2)
        Me.txtLicKey.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtLicKey.Location = New System.Drawing.Point(3, 70)
        Me.txtLicKey.Name = "txtLicKey"
        Me.txtLicKey.Size = New System.Drawing.Size(387, 20)
        Me.txtLicKey.TabIndex = 7
        '
        'DTInstall
        '
        Me.DTInstall.Location = New System.Drawing.Point(3, 110)
        Me.DTInstall.Name = "DTInstall"
        Me.DTInstall.Size = New System.Drawing.Size(168, 20)
        Me.DTInstall.TabIndex = 12
        '
        'Label5
        '
        Me.Label5.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(396, 54)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(143, 13)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "Производитель:"
        '
        'Label6
        '
        Me.Label6.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(396, 94)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(143, 13)
        Me.Label6.TabIndex = 11
        Me.Label6.Text = "Дата окончания лицензии:"
        '
        'cmbSoftPr
        '
        Me.cmbSoftPr.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
        Me.cmbSoftPr.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.TableLayoutPanel1.SetColumnSpan(Me.cmbSoftPr, 2)
        Me.cmbSoftPr.Dock = System.Windows.Forms.DockStyle.Fill
        Me.cmbSoftPr.FormattingEnabled = True
        Me.cmbSoftPr.Location = New System.Drawing.Point(396, 70)
        Me.cmbSoftPr.Name = "cmbSoftPr"
        Me.cmbSoftPr.Size = New System.Drawing.Size(282, 21)
        Me.cmbSoftPr.TabIndex = 9
        '
        'Label7
        '
        Me.Label7.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(3, 94)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(171, 13)
        Me.Label7.TabIndex = 10
        Me.Label7.Text = "Дата приобретения (установки):"
        '
        'ToolStrip1
        '
        Me.TableLayoutPanel1.SetColumnSpan(Me.ToolStrip1, 2)
        Me.ToolStrip1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ToolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnAdd, Me.ToolStripSeparator1, Me.btnDelete, Me.ToolStripSeparator2, Me.btnCancel, Me.ToolStripSeparator3, Me.ToolStripButton1, Me.ToolStripSeparator4})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 133)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System
        Me.ToolStrip1.Size = New System.Drawing.Size(393, 25)
        Me.ToolStrip1.TabIndex = 20
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'btnAdd
        '
        Me.btnAdd.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.btnAdd.Image = CType(resources.GetObject("btnAdd.Image"), System.Drawing.Image)
        Me.btnAdd.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(63, 22)
        Me.btnAdd.Text = "Добавить"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'btnDelete
        '
        Me.btnDelete.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.btnDelete.Image = CType(resources.GetObject("btnDelete.Image"), System.Drawing.Image)
        Me.btnDelete.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(55, 22)
        Me.btnDelete.Text = "Удалить"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'btnCancel
        '
        Me.btnCancel.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.btnCancel.Image = CType(resources.GetObject("btnCancel.Image"), System.Drawing.Image)
        Me.btnCancel.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(53, 22)
        Me.btnCancel.Text = "Отмена"
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(6, 25)
        '
        'ToolStripButton1
        '
        Me.ToolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.ToolStripButton1.Image = CType(resources.GetObject("ToolStripButton1.Image"), System.Drawing.Image)
        Me.ToolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton1.Name = "ToolStripButton1"
        Me.ToolStripButton1.Size = New System.Drawing.Size(86, 22)
        Me.ToolStripButton1.Text = "Обновить ПО"
        '
        'ToolStripSeparator4
        '
        Me.ToolStripSeparator4.Name = "ToolStripSeparator4"
        Me.ToolStripSeparator4.Size = New System.Drawing.Size(6, 25)
        '
        'CheckBox2
        '
        Me.CheckBox2.AutoSize = True
        Me.CheckBox2.Location = New System.Drawing.Point(396, 136)
        Me.CheckBox2.Name = "CheckBox2"
        Me.CheckBox2.Size = New System.Drawing.Size(127, 17)
        Me.CheckBox2.TabIndex = 19
        Me.CheckBox2.Text = "Массовое удаление"
        Me.CheckBox2.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(7, 13)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(146, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Программное обеспечение"
        '
        'frmSoftware
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(997, 521)
        Me.Controls.Add(Me.SplitContainer1)
        Me.MinimumSize = New System.Drawing.Size(1012, 559)
        Me.Name = "frmSoftware"
        Me.Text = "Учет программного обеспечения"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.gbTree.ResumeLayout(False)
        Me.TableLayoutPanel3.ResumeLayout(False)
        Me.TableLayoutPanel3.PerformLayout()
        Me.ToolStrip2.ResumeLayout(False)
        Me.ToolStrip2.PerformLayout()
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        Me.gbSoftware.ResumeLayout(False)
        Me.gbSoftware.PerformLayout()
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents gbTree As System.Windows.Forms.GroupBox
    Friend WithEvents txtSearch As System.Windows.Forms.TextBox
    Friend WithEvents lstGroups As System.Windows.Forms.TreeView
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents gbSoftware As System.Windows.Forms.GroupBox
    Friend WithEvents txtLicKey As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents cmbTipPo As System.Windows.Forms.ComboBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents cmbTipLicense As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents cmbSoftware As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cmbSoftPr As System.Windows.Forms.ComboBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents dtGok As System.Windows.Forms.DateTimePicker
    Friend WithEvents DTInstall As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents CheckBox1 As System.Windows.Forms.CheckBox
    Friend WithEvents lstSoftware As System.Windows.Forms.ListView
    Friend WithEvents TableLayoutPanel3 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents treebranche As System.Windows.Forms.ComboBox
    Friend WithEvents CheckBox2 As System.Windows.Forms.CheckBox
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents btnAdd As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnDelete As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnCancel As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripSeparator3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStrip2 As System.Windows.Forms.ToolStrip
    Friend WithEvents btnSearch As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripButton1 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator4 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents CheckBox3_manual As System.Windows.Forms.CheckBox
End Class
