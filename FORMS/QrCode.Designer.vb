<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class QrCode
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(QrCode))
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.btnPrint = New System.Windows.Forms.Button()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.btnEncode = New System.Windows.Forms.Button()
        Me.txtSize = New System.Windows.Forms.TextBox()
        Me.txtEncodeData = New System.Windows.Forms.TextBox()
        Me.cboCorrectionLevel = New System.Windows.Forms.ComboBox()
        Me.cboVersion = New System.Windows.Forms.ComboBox()
        Me.cboEncoding = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.picEncode = New System.Windows.Forms.PictureBox()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.btnDecode = New System.Windows.Forms.Button()
        Me.btnOpen = New System.Windows.Forms.Button()
        Me.txtDecodedData = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.picDecode = New System.Windows.Forms.PictureBox()
        Me.saveFileDialog1 = New System.Windows.Forms.SaveFileDialog()
        Me.PrintDialog1 = New System.Windows.Forms.PrintDialog()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.gbSoftEd = New System.Windows.Forms.GroupBox()
        Me.TableLayoutPanel13 = New System.Windows.Forms.TableLayoutPanel()
        Me.cmbSoftware = New System.Windows.Forms.ComboBox()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.Label114 = New System.Windows.Forms.Label()
        Me.cmbTipLicense = New System.Windows.Forms.ComboBox()
        Me.Label115 = New System.Windows.Forms.Label()
        Me.cmbTipPo = New System.Windows.Forms.ComboBox()
        Me.Label116 = New System.Windows.Forms.Label()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.txtLicKey = New System.Windows.Forms.TextBox()
        Me.DTInstall = New System.Windows.Forms.DateTimePicker()
        Me.Label117 = New System.Windows.Forms.Label()
        Me.Label118 = New System.Windows.Forms.Label()
        Me.cmbSoftPr = New System.Windows.Forms.ComboBox()
        Me.Label119 = New System.Windows.Forms.Label()
        Me.ToolStrip16 = New System.Windows.Forms.ToolStrip()
        Me.btnAdd = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator20 = New System.Windows.Forms.ToolStripSeparator()
        Me.btnDelete = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator21 = New System.Windows.Forms.ToolStripSeparator()
        Me.btnCancel = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator22 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripButton1 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator23 = New System.Windows.Forms.ToolStripSeparator()
        Me.CheckBox2 = New System.Windows.Forms.CheckBox()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        CType(Me.picEncode, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage2.SuspendLayout()
        CType(Me.picDecode, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbSoftEd.SuspendLayout()
        Me.TableLayoutPanel13.SuspendLayout()
        Me.ToolStrip16.SuspendLayout()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControl1.Location = New System.Drawing.Point(0, 0)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(1232, 479)
        Me.TabControl1.TabIndex = 0
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.btnPrint)
        Me.TabPage1.Controls.Add(Me.btnSave)
        Me.TabPage1.Controls.Add(Me.btnEncode)
        Me.TabPage1.Controls.Add(Me.txtSize)
        Me.TabPage1.Controls.Add(Me.txtEncodeData)
        Me.TabPage1.Controls.Add(Me.cboCorrectionLevel)
        Me.TabPage1.Controls.Add(Me.cboVersion)
        Me.TabPage1.Controls.Add(Me.cboEncoding)
        Me.TabPage1.Controls.Add(Me.Label5)
        Me.TabPage1.Controls.Add(Me.Label4)
        Me.TabPage1.Controls.Add(Me.Label3)
        Me.TabPage1.Controls.Add(Me.Label2)
        Me.TabPage1.Controls.Add(Me.Label1)
        Me.TabPage1.Controls.Add(Me.picEncode)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(1224, 453)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Encode"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'btnPrint
        '
        Me.btnPrint.Location = New System.Drawing.Point(257, 376)
        Me.btnPrint.Name = "btnPrint"
        Me.btnPrint.Size = New System.Drawing.Size(75, 23)
        Me.btnPrint.TabIndex = 13
        Me.btnPrint.Text = "Print"
        Me.btnPrint.UseVisualStyleBackColor = True
        '
        'btnSave
        '
        Me.btnSave.Location = New System.Drawing.Point(164, 376)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(75, 23)
        Me.btnSave.TabIndex = 12
        Me.btnSave.Text = "Save"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'btnEncode
        '
        Me.btnEncode.Location = New System.Drawing.Point(72, 376)
        Me.btnEncode.Name = "btnEncode"
        Me.btnEncode.Size = New System.Drawing.Size(75, 23)
        Me.btnEncode.TabIndex = 11
        Me.btnEncode.Text = "Encode"
        Me.btnEncode.UseVisualStyleBackColor = True
        '
        'txtSize
        '
        Me.txtSize.Location = New System.Drawing.Point(72, 327)
        Me.txtSize.Name = "txtSize"
        Me.txtSize.Size = New System.Drawing.Size(100, 20)
        Me.txtSize.TabIndex = 10
        Me.txtSize.Text = "4"
        '
        'txtEncodeData
        '
        Me.txtEncodeData.Location = New System.Drawing.Point(72, 224)
        Me.txtEncodeData.Name = "txtEncodeData"
        Me.txtEncodeData.Size = New System.Drawing.Size(457, 20)
        Me.txtEncodeData.TabIndex = 9
        Me.txtEncodeData.Text = "Squee&Dragon"
        '
        'cboCorrectionLevel
        '
        Me.cboCorrectionLevel.FormattingEnabled = True
        Me.cboCorrectionLevel.Items.AddRange(New Object() {"L", "M", "Q", "H"})
        Me.cboCorrectionLevel.Location = New System.Drawing.Point(321, 256)
        Me.cboCorrectionLevel.Name = "cboCorrectionLevel"
        Me.cboCorrectionLevel.Size = New System.Drawing.Size(208, 21)
        Me.cboCorrectionLevel.TabIndex = 8
        '
        'cboVersion
        '
        Me.cboVersion.FormattingEnabled = True
        Me.cboVersion.Items.AddRange(New Object() {"1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13", "14", "15", "16", "17", "18", "19", "20", "21", "22", "23", "24", "25", "26", "27", "28", "29", "30", "31", "32", "33", "34", "35", "36", "37", "38", "39", "40"})
        Me.cboVersion.Location = New System.Drawing.Point(72, 292)
        Me.cboVersion.Name = "cboVersion"
        Me.cboVersion.Size = New System.Drawing.Size(121, 21)
        Me.cboVersion.TabIndex = 7
        '
        'cboEncoding
        '
        Me.cboEncoding.FormattingEnabled = True
        Me.cboEncoding.Items.AddRange(New Object() {"AlphaNumeric", "Numeric", "Byte"})
        Me.cboEncoding.Location = New System.Drawing.Point(72, 256)
        Me.cboEncoding.Name = "cboEncoding"
        Me.cboEncoding.Size = New System.Drawing.Size(121, 21)
        Me.cboEncoding.TabIndex = 6
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(12, 330)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(27, 13)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "Size"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(234, 259)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(81, 13)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "CorrectionLevel"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 292)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(42, 13)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Version"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 259)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(52, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Encoding"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(9, 226)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(30, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Data"
        '
        'picEncode
        '
        Me.picEncode.Location = New System.Drawing.Point(7, 7)
        Me.picEncode.Name = "picEncode"
        Me.picEncode.Size = New System.Drawing.Size(800, 212)
        Me.picEncode.TabIndex = 0
        Me.picEncode.TabStop = False
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.gbSoftEd)
        Me.TabPage2.Controls.Add(Me.btnDecode)
        Me.TabPage2.Controls.Add(Me.btnOpen)
        Me.TabPage2.Controls.Add(Me.txtDecodedData)
        Me.TabPage2.Controls.Add(Me.Label6)
        Me.TabPage2.Controls.Add(Me.picDecode)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(1224, 453)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Decode"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'btnDecode
        '
        Me.btnDecode.Location = New System.Drawing.Point(108, 291)
        Me.btnDecode.Name = "btnDecode"
        Me.btnDecode.Size = New System.Drawing.Size(75, 23)
        Me.btnDecode.TabIndex = 13
        Me.btnDecode.Text = "Decode"
        Me.btnDecode.UseVisualStyleBackColor = True
        '
        'btnOpen
        '
        Me.btnOpen.Location = New System.Drawing.Point(11, 291)
        Me.btnOpen.Name = "btnOpen"
        Me.btnOpen.Size = New System.Drawing.Size(75, 23)
        Me.btnOpen.TabIndex = 12
        Me.btnOpen.Text = "Open"
        Me.btnOpen.UseVisualStyleBackColor = True
        '
        'txtDecodedData
        '
        Me.txtDecodedData.Location = New System.Drawing.Point(71, 237)
        Me.txtDecodedData.Name = "txtDecodedData"
        Me.txtDecodedData.Size = New System.Drawing.Size(76, 20)
        Me.txtDecodedData.TabIndex = 11
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(8, 239)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(30, 13)
        Me.Label6.TabIndex = 10
        Me.Label6.Text = "Data"
        '
        'picDecode
        '
        Me.picDecode.Location = New System.Drawing.Point(4, 4)
        Me.picDecode.Name = "picDecode"
        Me.picDecode.Size = New System.Drawing.Size(159, 217)
        Me.picDecode.TabIndex = 0
        Me.picDecode.TabStop = False
        '
        'PrintDialog1
        '
        Me.PrintDialog1.UseEXDialog = True
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'gbSoftEd
        '
        Me.gbSoftEd.Controls.Add(Me.TableLayoutPanel13)
        Me.gbSoftEd.Location = New System.Drawing.Point(262, 44)
        Me.gbSoftEd.Name = "gbSoftEd"
        Me.gbSoftEd.Size = New System.Drawing.Size(716, 189)
        Me.gbSoftEd.TabIndex = 14
        Me.gbSoftEd.TabStop = False
        Me.gbSoftEd.Text = "Редактировать ПО"
        Me.gbSoftEd.Visible = False
        '
        'TableLayoutPanel13
        '
        Me.TableLayoutPanel13.ColumnCount = 4
        Me.TableLayoutPanel13.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel13.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel13.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel13.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel13.Controls.Add(Me.cmbSoftware, 0, 0)
        Me.TableLayoutPanel13.Controls.Add(Me.CheckBox1, 3, 5)
        Me.TableLayoutPanel13.Controls.Add(Me.Label114, 0, 1)
        Me.TableLayoutPanel13.Controls.Add(Me.cmbTipLicense, 1, 1)
        Me.TableLayoutPanel13.Controls.Add(Me.Label115, 2, 1)
        Me.TableLayoutPanel13.Controls.Add(Me.cmbTipPo, 3, 1)
        Me.TableLayoutPanel13.Controls.Add(Me.Label116, 0, 2)
        Me.TableLayoutPanel13.Controls.Add(Me.DateTimePicker1, 2, 5)
        Me.TableLayoutPanel13.Controls.Add(Me.txtLicKey, 0, 3)
        Me.TableLayoutPanel13.Controls.Add(Me.DTInstall, 0, 5)
        Me.TableLayoutPanel13.Controls.Add(Me.Label117, 2, 2)
        Me.TableLayoutPanel13.Controls.Add(Me.Label118, 2, 4)
        Me.TableLayoutPanel13.Controls.Add(Me.cmbSoftPr, 2, 3)
        Me.TableLayoutPanel13.Controls.Add(Me.Label119, 0, 4)
        Me.TableLayoutPanel13.Controls.Add(Me.ToolStrip16, 0, 6)
        Me.TableLayoutPanel13.Controls.Add(Me.CheckBox2, 2, 6)
        Me.TableLayoutPanel13.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel13.Location = New System.Drawing.Point(3, 16)
        Me.TableLayoutPanel13.Name = "TableLayoutPanel13"
        Me.TableLayoutPanel13.RowCount = 7
        Me.TableLayoutPanel13.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel13.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel13.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel13.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel13.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel13.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel13.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel13.Size = New System.Drawing.Size(710, 170)
        Me.TableLayoutPanel13.TabIndex = 20
        '
        'cmbSoftware
        '
        Me.cmbSoftware.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
        Me.cmbSoftware.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.TableLayoutPanel13.SetColumnSpan(Me.cmbSoftware, 4)
        Me.cmbSoftware.Dock = System.Windows.Forms.DockStyle.Fill
        Me.cmbSoftware.FormattingEnabled = True
        Me.cmbSoftware.Location = New System.Drawing.Point(3, 3)
        Me.cmbSoftware.Name = "cmbSoftware"
        Me.cmbSoftware.Size = New System.Drawing.Size(704, 21)
        Me.cmbSoftware.TabIndex = 1
        '
        'CheckBox1
        '
        Me.CheckBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.Location = New System.Drawing.Point(518, 111)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(189, 17)
        Me.CheckBox1.TabIndex = 18
        Me.CheckBox1.Text = "Беcсрочно"
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'Label114
        '
        Me.Label114.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label114.AutoSize = True
        Me.Label114.Location = New System.Drawing.Point(3, 34)
        Me.Label114.Name = "Label114"
        Me.Label114.Size = New System.Drawing.Size(171, 13)
        Me.Label114.TabIndex = 2
        Me.Label114.Text = "Тип лицензии:"
        '
        'cmbTipLicense
        '
        Me.cmbTipLicense.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
        Me.cmbTipLicense.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmbTipLicense.Dock = System.Windows.Forms.DockStyle.Fill
        Me.cmbTipLicense.FormattingEnabled = True
        Me.cmbTipLicense.Location = New System.Drawing.Point(180, 30)
        Me.cmbTipLicense.Name = "cmbTipLicense"
        Me.cmbTipLicense.Size = New System.Drawing.Size(183, 21)
        Me.cmbTipLicense.TabIndex = 3
        '
        'Label115
        '
        Me.Label115.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label115.AutoSize = True
        Me.Label115.Location = New System.Drawing.Point(369, 34)
        Me.Label115.Name = "Label115"
        Me.Label115.Size = New System.Drawing.Size(143, 13)
        Me.Label115.TabIndex = 4
        Me.Label115.Text = "Тип П.О.:"
        '
        'cmbTipPo
        '
        Me.cmbTipPo.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
        Me.cmbTipPo.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmbTipPo.Dock = System.Windows.Forms.DockStyle.Fill
        Me.cmbTipPo.FormattingEnabled = True
        Me.cmbTipPo.Location = New System.Drawing.Point(518, 30)
        Me.cmbTipPo.Name = "cmbTipPo"
        Me.cmbTipPo.Size = New System.Drawing.Size(189, 21)
        Me.cmbTipPo.TabIndex = 5
        '
        'Label116
        '
        Me.Label116.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label116.AutoSize = True
        Me.Label116.Location = New System.Drawing.Point(3, 54)
        Me.Label116.Name = "Label116"
        Me.Label116.Size = New System.Drawing.Size(171, 13)
        Me.Label116.TabIndex = 6
        Me.Label116.Text = "Лицензионный номер:"
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Location = New System.Drawing.Point(369, 110)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(140, 20)
        Me.DateTimePicker1.TabIndex = 13
        '
        'txtLicKey
        '
        Me.TableLayoutPanel13.SetColumnSpan(Me.txtLicKey, 2)
        Me.txtLicKey.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtLicKey.Location = New System.Drawing.Point(3, 70)
        Me.txtLicKey.Name = "txtLicKey"
        Me.txtLicKey.Size = New System.Drawing.Size(360, 20)
        Me.txtLicKey.TabIndex = 7
        '
        'DTInstall
        '
        Me.DTInstall.Location = New System.Drawing.Point(3, 110)
        Me.DTInstall.Name = "DTInstall"
        Me.DTInstall.Size = New System.Drawing.Size(168, 20)
        Me.DTInstall.TabIndex = 12
        '
        'Label117
        '
        Me.Label117.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label117.AutoSize = True
        Me.Label117.Location = New System.Drawing.Point(369, 54)
        Me.Label117.Name = "Label117"
        Me.Label117.Size = New System.Drawing.Size(143, 13)
        Me.Label117.TabIndex = 8
        Me.Label117.Text = "Производитель:"
        '
        'Label118
        '
        Me.Label118.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label118.AutoSize = True
        Me.Label118.Location = New System.Drawing.Point(369, 94)
        Me.Label118.Name = "Label118"
        Me.Label118.Size = New System.Drawing.Size(143, 13)
        Me.Label118.TabIndex = 11
        Me.Label118.Text = "Дата окончания лицензии:"
        '
        'cmbSoftPr
        '
        Me.cmbSoftPr.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
        Me.cmbSoftPr.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.TableLayoutPanel13.SetColumnSpan(Me.cmbSoftPr, 2)
        Me.cmbSoftPr.Dock = System.Windows.Forms.DockStyle.Fill
        Me.cmbSoftPr.FormattingEnabled = True
        Me.cmbSoftPr.Location = New System.Drawing.Point(369, 70)
        Me.cmbSoftPr.Name = "cmbSoftPr"
        Me.cmbSoftPr.Size = New System.Drawing.Size(338, 21)
        Me.cmbSoftPr.TabIndex = 9
        '
        'Label119
        '
        Me.Label119.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label119.AutoSize = True
        Me.Label119.Location = New System.Drawing.Point(3, 94)
        Me.Label119.Name = "Label119"
        Me.Label119.Size = New System.Drawing.Size(171, 13)
        Me.Label119.TabIndex = 10
        Me.Label119.Text = "Дата приобретения (установки):"
        '
        'ToolStrip16
        '
        Me.ToolStrip16.BackColor = System.Drawing.Color.Transparent
        Me.TableLayoutPanel13.SetColumnSpan(Me.ToolStrip16, 2)
        Me.ToolStrip16.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ToolStrip16.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.ToolStrip16.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnAdd, Me.ToolStripSeparator20, Me.btnDelete, Me.ToolStripSeparator21, Me.btnCancel, Me.ToolStripSeparator22, Me.ToolStripButton1, Me.ToolStripSeparator23})
        Me.ToolStrip16.Location = New System.Drawing.Point(0, 133)
        Me.ToolStrip16.Name = "ToolStrip16"
        Me.ToolStrip16.RenderMode = System.Windows.Forms.ToolStripRenderMode.System
        Me.ToolStrip16.Size = New System.Drawing.Size(366, 37)
        Me.ToolStrip16.TabIndex = 20
        Me.ToolStrip16.Text = "ToolStrip16"
        '
        'btnAdd
        '
        Me.btnAdd.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.btnAdd.Image = CType(resources.GetObject("btnAdd.Image"), System.Drawing.Image)
        Me.btnAdd.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(63, 34)
        Me.btnAdd.Text = "Добавить"
        '
        'ToolStripSeparator20
        '
        Me.ToolStripSeparator20.Name = "ToolStripSeparator20"
        Me.ToolStripSeparator20.Size = New System.Drawing.Size(6, 37)
        '
        'btnDelete
        '
        Me.btnDelete.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.btnDelete.Image = CType(resources.GetObject("btnDelete.Image"), System.Drawing.Image)
        Me.btnDelete.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(55, 34)
        Me.btnDelete.Text = "Удалить"
        '
        'ToolStripSeparator21
        '
        Me.ToolStripSeparator21.Name = "ToolStripSeparator21"
        Me.ToolStripSeparator21.Size = New System.Drawing.Size(6, 37)
        '
        'btnCancel
        '
        Me.btnCancel.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.btnCancel.Image = CType(resources.GetObject("btnCancel.Image"), System.Drawing.Image)
        Me.btnCancel.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(53, 34)
        Me.btnCancel.Text = "Отмена"
        '
        'ToolStripSeparator22
        '
        Me.ToolStripSeparator22.Name = "ToolStripSeparator22"
        Me.ToolStripSeparator22.Size = New System.Drawing.Size(6, 37)
        '
        'ToolStripButton1
        '
        Me.ToolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.ToolStripButton1.Image = CType(resources.GetObject("ToolStripButton1.Image"), System.Drawing.Image)
        Me.ToolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton1.Name = "ToolStripButton1"
        Me.ToolStripButton1.Size = New System.Drawing.Size(86, 34)
        Me.ToolStripButton1.Text = "Обновить ПО"
        '
        'ToolStripSeparator23
        '
        Me.ToolStripSeparator23.Name = "ToolStripSeparator23"
        Me.ToolStripSeparator23.Size = New System.Drawing.Size(6, 37)
        '
        'CheckBox2
        '
        Me.CheckBox2.AutoSize = True
        Me.CheckBox2.Location = New System.Drawing.Point(369, 136)
        Me.CheckBox2.Name = "CheckBox2"
        Me.CheckBox2.Size = New System.Drawing.Size(127, 17)
        Me.CheckBox2.TabIndex = 19
        Me.CheckBox2.Text = "Массовое удаление"
        Me.CheckBox2.UseVisualStyleBackColor = True
        '
        'QrCode
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1232, 479)
        Me.Controls.Add(Me.TabControl1)
        Me.Name = "QrCode"
        Me.Text = "QrCode"
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        CType(Me.picEncode, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        CType(Me.picDecode, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbSoftEd.ResumeLayout(False)
        Me.TableLayoutPanel13.ResumeLayout(False)
        Me.TableLayoutPanel13.PerformLayout()
        Me.ToolStrip16.ResumeLayout(False)
        Me.ToolStrip16.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents txtSize As System.Windows.Forms.TextBox
    Friend WithEvents txtEncodeData As System.Windows.Forms.TextBox
    Friend WithEvents cboCorrectionLevel As System.Windows.Forms.ComboBox
    Friend WithEvents cboVersion As System.Windows.Forms.ComboBox
    Friend WithEvents cboEncoding As System.Windows.Forms.ComboBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents picEncode As System.Windows.Forms.PictureBox
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents btnPrint As System.Windows.Forms.Button
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents btnEncode As System.Windows.Forms.Button
    Friend WithEvents picDecode As System.Windows.Forms.PictureBox
    Friend WithEvents btnDecode As System.Windows.Forms.Button
    Friend WithEvents btnOpen As System.Windows.Forms.Button
    Friend WithEvents txtDecodedData As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents saveFileDialog1 As System.Windows.Forms.SaveFileDialog
    Friend WithEvents PrintDialog1 As System.Windows.Forms.PrintDialog
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents gbSoftEd As System.Windows.Forms.GroupBox
    Friend WithEvents TableLayoutPanel13 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents cmbSoftware As System.Windows.Forms.ComboBox
    Friend WithEvents CheckBox1 As System.Windows.Forms.CheckBox
    Friend WithEvents Label114 As System.Windows.Forms.Label
    Friend WithEvents cmbTipLicense As System.Windows.Forms.ComboBox
    Friend WithEvents Label115 As System.Windows.Forms.Label
    Friend WithEvents cmbTipPo As System.Windows.Forms.ComboBox
    Friend WithEvents Label116 As System.Windows.Forms.Label
    Friend WithEvents DateTimePicker1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents txtLicKey As System.Windows.Forms.TextBox
    Friend WithEvents DTInstall As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label117 As System.Windows.Forms.Label
    Friend WithEvents Label118 As System.Windows.Forms.Label
    Friend WithEvents cmbSoftPr As System.Windows.Forms.ComboBox
    Friend WithEvents Label119 As System.Windows.Forms.Label
    Friend WithEvents ToolStrip16 As System.Windows.Forms.ToolStrip
    Friend WithEvents btnAdd As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator20 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents btnDelete As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator21 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents btnCancel As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator22 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripButton1 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator23 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents CheckBox2 As System.Windows.Forms.CheckBox
End Class
