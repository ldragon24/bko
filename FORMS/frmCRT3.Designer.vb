<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCRT3
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmCRT3))
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.gbTree = New System.Windows.Forms.GroupBox()
        Me.TableLayoutPanel4 = New System.Windows.Forms.TableLayoutPanel()
        Me.txtSearch = New System.Windows.Forms.TextBox()
        Me.lstGroups = New System.Windows.Forms.TreeView()
        Me.treebranche = New System.Windows.Forms.ComboBox()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.btnSearch = New System.Windows.Forms.ToolStripButton()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
        Me.txtMemo = New System.Windows.Forms.TextBox()
        Me.dtSale = New System.Windows.Forms.DateTimePicker()
        Me.txtCashe = New System.Windows.Forms.NumericUpDown()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.chkNZ = New System.Windows.Forms.CheckBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.chkNezap = New System.Windows.Forms.CheckBox()
        Me.lblRealNumber = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtSerNumb = New System.Windows.Forms.TextBox()
        Me.txtSaleNumb = New System.Windows.Forms.TextBox()
        Me.cmbProizv = New System.Windows.Forms.ComboBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cmbSaler = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.cmbTipC = New System.Windows.Forms.ComboBox()
        Me.cmbSostUstr = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.cmbModC = New System.Windows.Forms.ComboBox()
        Me.chkIznos = New System.Windows.Forms.CheckBox()
        Me.chkNaSP = New System.Windows.Forms.CheckBox()
        Me.chkSPS = New System.Windows.Forms.CheckBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.TableLayoutPanel3 = New System.Windows.Forms.TableLayoutPanel()
        Me.btnZapDel = New System.Windows.Forms.Button()
        Me.btnZapAdd = New System.Windows.Forms.Button()
        Me.lvCartZAP = New System.Windows.Forms.ListView()
        Me.btnZapReport = New System.Windows.Forms.Button()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.lvCRTMove = New System.Windows.Forms.ListView()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.gbTree.SuspendLayout()
        Me.TableLayoutPanel4.SuspendLayout()
        Me.ToolStrip1.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TableLayoutPanel2.SuspendLayout()
        CType(Me.txtCashe, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage2.SuspendLayout()
        Me.TableLayoutPanel3.SuspendLayout()
        Me.TabPage3.SuspendLayout()
        Me.SuspendLayout()
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 32.26704!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 67.73296!))
        Me.TableLayoutPanel1.Controls.Add(Me.gbTree, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.TabControl1, 1, 0)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 2
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(975, 608)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'gbTree
        '
        Me.gbTree.Controls.Add(Me.TableLayoutPanel4)
        Me.gbTree.Dock = System.Windows.Forms.DockStyle.Fill
        Me.gbTree.Location = New System.Drawing.Point(3, 3)
        Me.gbTree.Name = "gbTree"
        Me.TableLayoutPanel1.SetRowSpan(Me.gbTree, 2)
        Me.gbTree.Size = New System.Drawing.Size(308, 602)
        Me.gbTree.TabIndex = 9
        Me.gbTree.TabStop = False
        Me.gbTree.Text = "Печатающие устройства"
        '
        'TableLayoutPanel4
        '
        Me.TableLayoutPanel4.ColumnCount = 2
        Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 35.0!))
        Me.TableLayoutPanel4.Controls.Add(Me.txtSearch, 0, 0)
        Me.TableLayoutPanel4.Controls.Add(Me.lstGroups, 0, 2)
        Me.TableLayoutPanel4.Controls.Add(Me.treebranche, 0, 1)
        Me.TableLayoutPanel4.Controls.Add(Me.ToolStrip1, 1, 0)
        Me.TableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel4.Location = New System.Drawing.Point(3, 16)
        Me.TableLayoutPanel4.Name = "TableLayoutPanel4"
        Me.TableLayoutPanel4.RowCount = 3
        Me.TableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.TableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.TableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel4.Size = New System.Drawing.Size(302, 583)
        Me.TableLayoutPanel4.TabIndex = 4
        '
        'txtSearch
        '
        Me.txtSearch.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtSearch.Location = New System.Drawing.Point(3, 3)
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.Size = New System.Drawing.Size(261, 20)
        Me.txtSearch.TabIndex = 4
        '
        'lstGroups
        '
        Me.lstGroups.AllowDrop = True
        Me.TableLayoutPanel4.SetColumnSpan(Me.lstGroups, 2)
        Me.lstGroups.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lstGroups.FullRowSelect = True
        Me.lstGroups.HideSelection = False
        Me.lstGroups.Location = New System.Drawing.Point(3, 63)
        Me.lstGroups.Name = "lstGroups"
        Me.lstGroups.Size = New System.Drawing.Size(296, 521)
        Me.lstGroups.TabIndex = 3
        '
        'treebranche
        '
        Me.TableLayoutPanel4.SetColumnSpan(Me.treebranche, 2)
        Me.treebranche.Dock = System.Windows.Forms.DockStyle.Fill
        Me.treebranche.FormattingEnabled = True
        Me.treebranche.Location = New System.Drawing.Point(3, 33)
        Me.treebranche.Name = "treebranche"
        Me.treebranche.Size = New System.Drawing.Size(296, 21)
        Me.treebranche.TabIndex = 6
        '
        'ToolStrip1
        '
        Me.ToolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnSearch})
        Me.ToolStrip1.Location = New System.Drawing.Point(267, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System
        Me.ToolStrip1.Size = New System.Drawing.Size(35, 25)
        Me.ToolStrip1.TabIndex = 7
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'btnSearch
        '
        Me.btnSearch.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btnSearch.Image = CType(resources.GetObject("btnSearch.Image"), System.Drawing.Image)
        Me.btnSearch.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(23, 22)
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Controls.Add(Me.TabPage3)
        Me.TabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControl1.Location = New System.Drawing.Point(317, 3)
        Me.TabControl1.Name = "TabControl1"
        Me.TableLayoutPanel1.SetRowSpan(Me.TabControl1, 2)
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(655, 602)
        Me.TabControl1.TabIndex = 10
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.TableLayoutPanel2)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(647, 576)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Картридж"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'TableLayoutPanel2
        '
        Me.TableLayoutPanel2.ColumnCount = 3
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel2.Controls.Add(Me.txtMemo, 0, 12)
        Me.TableLayoutPanel2.Controls.Add(Me.dtSale, 1, 9)
        Me.TableLayoutPanel2.Controls.Add(Me.txtCashe, 1, 8)
        Me.TableLayoutPanel2.Controls.Add(Me.Label11, 0, 9)
        Me.TableLayoutPanel2.Controls.Add(Me.chkNZ, 1, 10)
        Me.TableLayoutPanel2.Controls.Add(Me.Label1, 0, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.chkNezap, 0, 10)
        Me.TableLayoutPanel2.Controls.Add(Me.lblRealNumber, 1, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.Label2, 0, 1)
        Me.TableLayoutPanel2.Controls.Add(Me.Label10, 0, 8)
        Me.TableLayoutPanel2.Controls.Add(Me.txtSerNumb, 1, 1)
        Me.TableLayoutPanel2.Controls.Add(Me.txtSaleNumb, 1, 7)
        Me.TableLayoutPanel2.Controls.Add(Me.cmbProizv, 1, 2)
        Me.TableLayoutPanel2.Controls.Add(Me.Label9, 0, 7)
        Me.TableLayoutPanel2.Controls.Add(Me.Label3, 0, 2)
        Me.TableLayoutPanel2.Controls.Add(Me.cmbSaler, 1, 6)
        Me.TableLayoutPanel2.Controls.Add(Me.Label4, 0, 3)
        Me.TableLayoutPanel2.Controls.Add(Me.Label8, 0, 6)
        Me.TableLayoutPanel2.Controls.Add(Me.cmbTipC, 1, 3)
        Me.TableLayoutPanel2.Controls.Add(Me.cmbSostUstr, 1, 5)
        Me.TableLayoutPanel2.Controls.Add(Me.Label5, 0, 4)
        Me.TableLayoutPanel2.Controls.Add(Me.Label6, 0, 5)
        Me.TableLayoutPanel2.Controls.Add(Me.cmbModC, 1, 4)
        Me.TableLayoutPanel2.Controls.Add(Me.chkIznos, 2, 8)
        Me.TableLayoutPanel2.Controls.Add(Me.chkNaSP, 2, 10)
        Me.TableLayoutPanel2.Controls.Add(Me.chkSPS, 2, 9)
        Me.TableLayoutPanel2.Controls.Add(Me.Label7, 0, 11)
        Me.TableLayoutPanel2.Controls.Add(Me.btnAdd, 0, 13)
        Me.TableLayoutPanel2.Controls.Add(Me.btnCancel, 1, 13)
        Me.TableLayoutPanel2.Controls.Add(Me.btnDelete, 2, 13)
        Me.TableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(3, 3)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RowCount = 14
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(641, 570)
        Me.TableLayoutPanel2.TabIndex = 1
        '
        'txtMemo
        '
        Me.TableLayoutPanel2.SetColumnSpan(Me.txtMemo, 3)
        Me.txtMemo.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtMemo.Location = New System.Drawing.Point(3, 293)
        Me.txtMemo.Multiline = True
        Me.txtMemo.Name = "txtMemo"
        Me.txtMemo.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtMemo.Size = New System.Drawing.Size(635, 247)
        Me.txtMemo.TabIndex = 29
        '
        'dtSale
        '
        Me.dtSale.Location = New System.Drawing.Point(130, 231)
        Me.dtSale.Name = "dtSale"
        Me.dtSale.Size = New System.Drawing.Size(137, 20)
        Me.dtSale.TabIndex = 48
        Me.dtSale.Value = New Date(2010, 4, 1, 0, 0, 0, 0)
        '
        'txtCashe
        '
        Me.txtCashe.Location = New System.Drawing.Point(130, 205)
        Me.txtCashe.Maximum = New Decimal(New Integer() {100000, 0, 0, 0})
        Me.txtCashe.Name = "txtCashe"
        Me.txtCashe.Size = New System.Drawing.Size(136, 20)
        Me.txtCashe.TabIndex = 49
        '
        'Label11
        '
        Me.Label11.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(3, 234)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(110, 13)
        Me.Label11.TabIndex = 47
        Me.Label11.Text = "Дата приобретения:"
        '
        'chkNZ
        '
        Me.chkNZ.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.chkNZ.AutoSize = True
        Me.chkNZ.Location = New System.Drawing.Point(130, 257)
        Me.chkNZ.Name = "chkNZ"
        Me.chkNZ.Size = New System.Drawing.Size(97, 17)
        Me.chkNZ.TabIndex = 32
        Me.chkNZ.Text = "Не заправлен"
        Me.chkNZ.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(3, 1)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(18, 13)
        Me.Label1.TabIndex = 30
        Me.Label1.Text = "№"
        '
        'chkNezap
        '
        Me.chkNezap.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.chkNezap.AutoSize = True
        Me.chkNezap.Location = New System.Drawing.Point(3, 257)
        Me.chkNezap.Name = "chkNezap"
        Me.chkNezap.Size = New System.Drawing.Size(119, 17)
        Me.chkNezap.TabIndex = 31
        Me.chkNezap.Text = "Не заправляемый"
        Me.chkNezap.UseVisualStyleBackColor = True
        '
        'lblRealNumber
        '
        Me.lblRealNumber.AutoSize = True
        Me.lblRealNumber.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.TableLayoutPanel2.SetColumnSpan(Me.lblRealNumber, 2)
        Me.lblRealNumber.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblRealNumber.Location = New System.Drawing.Point(130, 0)
        Me.lblRealNumber.Name = "lblRealNumber"
        Me.lblRealNumber.Size = New System.Drawing.Size(508, 15)
        Me.lblRealNumber.TabIndex = 36
        '
        'Label2
        '
        Me.Label2.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(3, 21)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(96, 13)
        Me.Label2.TabIndex = 31
        Me.Label2.Text = "Серийный номер:"
        '
        'Label10
        '
        Me.Label10.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(3, 208)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(36, 13)
        Me.Label10.TabIndex = 46
        Me.Label10.Text = "Цена:"
        '
        'txtSerNumb
        '
        Me.TableLayoutPanel2.SetColumnSpan(Me.txtSerNumb, 2)
        Me.txtSerNumb.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtSerNumb.Location = New System.Drawing.Point(130, 18)
        Me.txtSerNumb.Name = "txtSerNumb"
        Me.txtSerNumb.Size = New System.Drawing.Size(508, 20)
        Me.txtSerNumb.TabIndex = 37
        '
        'txtSaleNumb
        '
        Me.TableLayoutPanel2.SetColumnSpan(Me.txtSaleNumb, 2)
        Me.txtSaleNumb.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtSaleNumb.Location = New System.Drawing.Point(130, 179)
        Me.txtSaleNumb.Name = "txtSaleNumb"
        Me.txtSaleNumb.Size = New System.Drawing.Size(508, 20)
        Me.txtSaleNumb.TabIndex = 45
        '
        'cmbProizv
        '
        Me.cmbProizv.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
        Me.cmbProizv.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.TableLayoutPanel2.SetColumnSpan(Me.cmbProizv, 2)
        Me.cmbProizv.Dock = System.Windows.Forms.DockStyle.Fill
        Me.cmbProizv.FormattingEnabled = True
        Me.cmbProizv.Location = New System.Drawing.Point(130, 44)
        Me.cmbProizv.Name = "cmbProizv"
        Me.cmbProizv.Size = New System.Drawing.Size(508, 21)
        Me.cmbProizv.TabIndex = 38
        '
        'Label9
        '
        Me.Label9.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(3, 182)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(78, 13)
        Me.Label9.TabIndex = 44
        Me.Label9.Text = "Счёт фактура:"
        '
        'Label3
        '
        Me.Label3.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(3, 48)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(89, 13)
        Me.Label3.TabIndex = 32
        Me.Label3.Text = "Производитель:"
        '
        'cmbSaler
        '
        Me.cmbSaler.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
        Me.cmbSaler.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.TableLayoutPanel2.SetColumnSpan(Me.cmbSaler, 2)
        Me.cmbSaler.Dock = System.Windows.Forms.DockStyle.Fill
        Me.cmbSaler.FormattingEnabled = True
        Me.cmbSaler.Location = New System.Drawing.Point(130, 152)
        Me.cmbSaler.Name = "cmbSaler"
        Me.cmbSaler.Size = New System.Drawing.Size(508, 21)
        Me.cmbSaler.TabIndex = 43
        '
        'Label4
        '
        Me.Label4.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(3, 75)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(87, 13)
        Me.Label4.TabIndex = 33
        Me.Label4.Text = "Тип картриджа:"
        '
        'Label8
        '
        Me.Label8.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(3, 156)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(60, 13)
        Me.Label8.TabIndex = 42
        Me.Label8.Text = "Продавец:"
        '
        'cmbTipC
        '
        Me.cmbTipC.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
        Me.cmbTipC.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.TableLayoutPanel2.SetColumnSpan(Me.cmbTipC, 2)
        Me.cmbTipC.Dock = System.Windows.Forms.DockStyle.Fill
        Me.cmbTipC.FormattingEnabled = True
        Me.cmbTipC.Location = New System.Drawing.Point(130, 71)
        Me.cmbTipC.Name = "cmbTipC"
        Me.cmbTipC.Size = New System.Drawing.Size(508, 21)
        Me.cmbTipC.TabIndex = 39
        '
        'cmbSostUstr
        '
        Me.cmbSostUstr.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
        Me.cmbSostUstr.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.TableLayoutPanel2.SetColumnSpan(Me.cmbSostUstr, 2)
        Me.cmbSostUstr.Dock = System.Windows.Forms.DockStyle.Fill
        Me.cmbSostUstr.FormattingEnabled = True
        Me.cmbSostUstr.Location = New System.Drawing.Point(130, 125)
        Me.cmbSostUstr.Name = "cmbSostUstr"
        Me.cmbSostUstr.Size = New System.Drawing.Size(508, 21)
        Me.cmbSostUstr.TabIndex = 41
        '
        'Label5
        '
        Me.Label5.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(3, 102)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(49, 13)
        Me.Label5.TabIndex = 34
        Me.Label5.Text = "Модель:"
        '
        'Label6
        '
        Me.Label6.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label6.AutoSize = True
        Me.Label6.Enabled = False
        Me.Label6.Location = New System.Drawing.Point(3, 129)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(121, 13)
        Me.Label6.TabIndex = 35
        Me.Label6.Text = "В составе устройства:"
        '
        'cmbModC
        '
        Me.cmbModC.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
        Me.cmbModC.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.TableLayoutPanel2.SetColumnSpan(Me.cmbModC, 2)
        Me.cmbModC.Dock = System.Windows.Forms.DockStyle.Fill
        Me.cmbModC.FormattingEnabled = True
        Me.cmbModC.Location = New System.Drawing.Point(130, 98)
        Me.cmbModC.Name = "cmbModC"
        Me.cmbModC.Size = New System.Drawing.Size(508, 21)
        Me.cmbModC.TabIndex = 40
        '
        'chkIznos
        '
        Me.chkIznos.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.chkIznos.AutoSize = True
        Me.chkIznos.Location = New System.Drawing.Point(273, 206)
        Me.chkIznos.Name = "chkIznos"
        Me.chkIznos.Size = New System.Drawing.Size(72, 17)
        Me.chkIznos.TabIndex = 33
        Me.chkIznos.Text = "Изношен"
        Me.chkIznos.UseVisualStyleBackColor = True
        '
        'chkNaSP
        '
        Me.chkNaSP.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.chkNaSP.AutoSize = True
        Me.chkNaSP.Location = New System.Drawing.Point(273, 257)
        Me.chkNaSP.Name = "chkNaSP"
        Me.chkNaSP.Size = New System.Drawing.Size(91, 17)
        Me.chkNaSP.TabIndex = 35
        Me.chkNaSP.Text = "На списание"
        Me.chkNaSP.UseVisualStyleBackColor = True
        '
        'chkSPS
        '
        Me.chkSPS.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.chkSPS.AutoSize = True
        Me.chkSPS.Location = New System.Drawing.Point(273, 232)
        Me.chkSPS.Name = "chkSPS"
        Me.chkSPS.Size = New System.Drawing.Size(63, 17)
        Me.chkSPS.TabIndex = 34
        Me.chkSPS.Text = "Списан"
        Me.chkSPS.UseVisualStyleBackColor = True
        '
        'Label7
        '
        Me.Label7.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(3, 277)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(73, 13)
        Me.Label7.TabIndex = 30
        Me.Label7.Text = "Примечания:"
        '
        'btnAdd
        '
        Me.btnAdd.Location = New System.Drawing.Point(3, 546)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(75, 21)
        Me.btnAdd.TabIndex = 50
        Me.btnAdd.Text = "&Добавить"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'btnCancel
        '
        Me.btnCancel.Location = New System.Drawing.Point(130, 546)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(75, 21)
        Me.btnCancel.TabIndex = 51
        Me.btnCancel.Text = "&Отмена"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'btnDelete
        '
        Me.btnDelete.Location = New System.Drawing.Point(273, 546)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(75, 21)
        Me.btnDelete.TabIndex = 52
        Me.btnDelete.Text = "&Удалить"
        Me.btnDelete.UseVisualStyleBackColor = True
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.TableLayoutPanel3)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(647, 576)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Заправки"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'TableLayoutPanel3
        '
        Me.TableLayoutPanel3.ColumnCount = 3
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100.0!))
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100.0!))
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel3.Controls.Add(Me.btnZapDel, 0, 1)
        Me.TableLayoutPanel3.Controls.Add(Me.btnZapAdd, 0, 1)
        Me.TableLayoutPanel3.Controls.Add(Me.lvCartZAP, 0, 0)
        Me.TableLayoutPanel3.Controls.Add(Me.btnZapReport, 2, 1)
        Me.TableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel3.Location = New System.Drawing.Point(3, 3)
        Me.TableLayoutPanel3.Name = "TableLayoutPanel3"
        Me.TableLayoutPanel3.RowCount = 2
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60.0!))
        Me.TableLayoutPanel3.Size = New System.Drawing.Size(641, 570)
        Me.TableLayoutPanel3.TabIndex = 0
        '
        'btnZapDel
        '
        Me.btnZapDel.Location = New System.Drawing.Point(103, 513)
        Me.btnZapDel.Name = "btnZapDel"
        Me.btnZapDel.Size = New System.Drawing.Size(75, 23)
        Me.btnZapDel.TabIndex = 25
        Me.btnZapDel.Text = "Удалить"
        Me.btnZapDel.UseVisualStyleBackColor = True
        '
        'btnZapAdd
        '
        Me.btnZapAdd.Location = New System.Drawing.Point(3, 513)
        Me.btnZapAdd.Name = "btnZapAdd"
        Me.btnZapAdd.Size = New System.Drawing.Size(75, 23)
        Me.btnZapAdd.TabIndex = 24
        Me.btnZapAdd.Text = "Добавить"
        Me.btnZapAdd.UseVisualStyleBackColor = True
        '
        'lvCartZAP
        '
        Me.TableLayoutPanel3.SetColumnSpan(Me.lvCartZAP, 3)
        Me.lvCartZAP.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lvCartZAP.FullRowSelect = True
        Me.lvCartZAP.GridLines = True
        Me.lvCartZAP.Location = New System.Drawing.Point(3, 3)
        Me.lvCartZAP.MultiSelect = False
        Me.lvCartZAP.Name = "lvCartZAP"
        Me.lvCartZAP.ShowItemToolTips = True
        Me.lvCartZAP.Size = New System.Drawing.Size(635, 504)
        Me.lvCartZAP.TabIndex = 19
        Me.lvCartZAP.UseCompatibleStateImageBehavior = False
        Me.lvCartZAP.View = System.Windows.Forms.View.Details
        '
        'btnZapReport
        '
        Me.btnZapReport.Location = New System.Drawing.Point(203, 513)
        Me.btnZapReport.Name = "btnZapReport"
        Me.btnZapReport.Size = New System.Drawing.Size(122, 23)
        Me.btnZapReport.TabIndex = 26
        Me.btnZapReport.Text = "Отчёт по заправкам"
        Me.btnZapReport.UseVisualStyleBackColor = True
        '
        'TabPage3
        '
        Me.TabPage3.Controls.Add(Me.lvCRTMove)
        Me.TabPage3.Location = New System.Drawing.Point(4, 22)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Size = New System.Drawing.Size(647, 576)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "Перемещения"
        Me.TabPage3.UseVisualStyleBackColor = True
        '
        'lvCRTMove
        '
        Me.lvCRTMove.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lvCRTMove.FullRowSelect = True
        Me.lvCRTMove.GridLines = True
        Me.lvCRTMove.Location = New System.Drawing.Point(0, 0)
        Me.lvCRTMove.MultiSelect = False
        Me.lvCRTMove.Name = "lvCRTMove"
        Me.lvCRTMove.ShowItemToolTips = True
        Me.lvCRTMove.Size = New System.Drawing.Size(647, 576)
        Me.lvCRTMove.TabIndex = 20
        Me.lvCRTMove.UseCompatibleStateImageBehavior = False
        Me.lvCRTMove.View = System.Windows.Forms.View.Details
        '
        'frmCRT3
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(975, 608)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Name = "frmCRT3"
        Me.Text = "Учёт картриджей"
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.gbTree.ResumeLayout(False)
        Me.TableLayoutPanel4.ResumeLayout(False)
        Me.TableLayoutPanel4.PerformLayout()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TableLayoutPanel2.ResumeLayout(False)
        Me.TableLayoutPanel2.PerformLayout()
        CType(Me.txtCashe, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage2.ResumeLayout(False)
        Me.TableLayoutPanel3.ResumeLayout(False)
        Me.TabPage3.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents gbTree As System.Windows.Forms.GroupBox
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage3 As System.Windows.Forms.TabPage
    Friend WithEvents TableLayoutPanel3 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents lvCartZAP As System.Windows.Forms.ListView
    Friend WithEvents TableLayoutPanel2 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents txtMemo As System.Windows.Forms.TextBox
    Friend WithEvents dtSale As System.Windows.Forms.DateTimePicker
    Friend WithEvents txtCashe As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents chkNZ As System.Windows.Forms.CheckBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents chkNezap As System.Windows.Forms.CheckBox
    Friend WithEvents lblRealNumber As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents txtSerNumb As System.Windows.Forms.TextBox
    Friend WithEvents txtSaleNumb As System.Windows.Forms.TextBox
    Friend WithEvents cmbProizv As System.Windows.Forms.ComboBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents cmbSaler As System.Windows.Forms.ComboBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents cmbTipC As System.Windows.Forms.ComboBox
    Friend WithEvents cmbSostUstr As System.Windows.Forms.ComboBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents cmbModC As System.Windows.Forms.ComboBox
    Friend WithEvents chkIznos As System.Windows.Forms.CheckBox
    Friend WithEvents chkNaSP As System.Windows.Forms.CheckBox
    Friend WithEvents chkSPS As System.Windows.Forms.CheckBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents btnAdd As System.Windows.Forms.Button
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    Friend WithEvents btnZapDel As System.Windows.Forms.Button
    Friend WithEvents btnZapAdd As System.Windows.Forms.Button
    Friend WithEvents btnZapReport As System.Windows.Forms.Button
    Friend WithEvents lvCRTMove As System.Windows.Forms.ListView
    Friend WithEvents lstGroups As System.Windows.Forms.TreeView
    Friend WithEvents btnDelete As System.Windows.Forms.Button
    Friend WithEvents TableLayoutPanel4 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents txtSearch As System.Windows.Forms.TextBox
    Friend WithEvents treebranche As System.Windows.Forms.ComboBox
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents btnSearch As System.Windows.Forms.ToolStripButton
End Class
