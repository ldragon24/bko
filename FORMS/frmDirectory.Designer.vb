<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDirectory
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmDirectory))
        Me.tvDirectory = New System.Windows.Forms.TreeView()
        Me.gbSpr = New System.Windows.Forms.GroupBox()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.btnDirAdd = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.Button2 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.btnCancell = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator4 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripButton1 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator5 = New System.Windows.Forms.ToolStripSeparator()
        Me.Button3 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.CheckBox2 = New System.Windows.Forms.CheckBox()
        Me.chkCont = New System.Windows.Forms.CheckBox()
        Me.chkVisibleSTR = New System.Windows.Forms.CheckBox()
        Me.gbOther = New System.Windows.Forms.GroupBox()
        Me.cmbIcon = New System.Windows.Forms.ComboBox()
        Me.pbOtherICO = New System.Windows.Forms.PictureBox()
        Me.gb2 = New System.Windows.Forms.GroupBox()
        Me.lbl2 = New System.Windows.Forms.Label()
        Me.cmb2 = New System.Windows.Forms.ComboBox()
        Me.gb1 = New System.Windows.Forms.GroupBox()
        Me.lbl1 = New System.Windows.Forms.Label()
        Me.cmb1 = New System.Windows.Forms.ComboBox()
        Me.txtMemo = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.cmbName3 = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cmbName2 = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cmbName = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lvDirectory = New System.Windows.Forms.ListView()
        Me.ilsCommands = New System.Windows.Forms.ImageList(Me.components)
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.gbSpr.SuspendLayout()
        Me.ToolStrip1.SuspendLayout()
        Me.gbOther.SuspendLayout()
        CType(Me.pbOtherICO, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gb2.SuspendLayout()
        Me.gb1.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'tvDirectory
        '
        Me.tvDirectory.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tvDirectory.Location = New System.Drawing.Point(3, 3)
        Me.tvDirectory.Name = "tvDirectory"
        Me.TableLayoutPanel1.SetRowSpan(Me.tvDirectory, 2)
        Me.tvDirectory.Size = New System.Drawing.Size(302, 596)
        Me.tvDirectory.TabIndex = 0
        '
        'gbSpr
        '
        Me.gbSpr.AutoSize = True
        Me.gbSpr.Controls.Add(Me.ToolStrip1)
        Me.gbSpr.Controls.Add(Me.CheckBox2)
        Me.gbSpr.Controls.Add(Me.chkCont)
        Me.gbSpr.Controls.Add(Me.chkVisibleSTR)
        Me.gbSpr.Controls.Add(Me.gbOther)
        Me.gbSpr.Controls.Add(Me.gb2)
        Me.gbSpr.Controls.Add(Me.gb1)
        Me.gbSpr.Controls.Add(Me.txtMemo)
        Me.gbSpr.Controls.Add(Me.Label4)
        Me.gbSpr.Controls.Add(Me.txtName)
        Me.gbSpr.Controls.Add(Me.cmbName3)
        Me.gbSpr.Controls.Add(Me.Label3)
        Me.gbSpr.Controls.Add(Me.cmbName2)
        Me.gbSpr.Controls.Add(Me.Label2)
        Me.gbSpr.Controls.Add(Me.cmbName)
        Me.gbSpr.Controls.Add(Me.Label1)
        Me.gbSpr.Dock = System.Windows.Forms.DockStyle.Fill
        Me.gbSpr.Location = New System.Drawing.Point(311, 270)
        Me.gbSpr.Name = "gbSpr"
        Me.gbSpr.Size = New System.Drawing.Size(695, 329)
        Me.gbSpr.TabIndex = 2
        Me.gbSpr.TabStop = False
        Me.gbSpr.Text = "Параметры"
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Dock = System.Windows.Forms.DockStyle.None
        Me.ToolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnDirAdd, Me.ToolStripSeparator1, Me.Button2, Me.ToolStripSeparator2, Me.btnCancell, Me.ToolStripSeparator4, Me.ToolStripButton1, Me.ToolStripSeparator5, Me.Button3, Me.ToolStripSeparator3})
        Me.ToolStrip1.Location = New System.Drawing.Point(10, 265)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(243, 25)
        Me.ToolStrip1.TabIndex = 21
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'btnDirAdd
        '
        Me.btnDirAdd.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.btnDirAdd.Image = CType(resources.GetObject("btnDirAdd.Image"), System.Drawing.Image)
        Me.btnDirAdd.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnDirAdd.Name = "btnDirAdd"
        Me.btnDirAdd.Size = New System.Drawing.Size(63, 22)
        Me.btnDirAdd.Text = "Добавить"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'Button2
        '
        Me.Button2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.Button2.Image = CType(resources.GetObject("Button2.Image"), System.Drawing.Image)
        Me.Button2.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(55, 22)
        Me.Button2.Text = "Удалить"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'btnCancell
        '
        Me.btnCancell.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.btnCancell.Image = CType(resources.GetObject("btnCancell.Image"), System.Drawing.Image)
        Me.btnCancell.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnCancell.Name = "btnCancell"
        Me.btnCancell.Size = New System.Drawing.Size(53, 22)
        Me.btnCancell.Text = "Отмена"
        '
        'ToolStripSeparator4
        '
        Me.ToolStripSeparator4.Name = "ToolStripSeparator4"
        Me.ToolStripSeparator4.Size = New System.Drawing.Size(6, 25)
        '
        'ToolStripButton1
        '
        Me.ToolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.ToolStripButton1.Image = CType(resources.GetObject("ToolStripButton1.Image"), System.Drawing.Image)
        Me.ToolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton1.Name = "ToolStripButton1"
        Me.ToolStripButton1.Size = New System.Drawing.Size(67, 22)
        Me.ToolStripButton1.Text = "SNMP OID"
        Me.ToolStripButton1.Visible = False
        '
        'ToolStripSeparator5
        '
        Me.ToolStripSeparator5.Name = "ToolStripSeparator5"
        Me.ToolStripSeparator5.Size = New System.Drawing.Size(6, 25)
        Me.ToolStripSeparator5.Visible = False
        '
        'Button3
        '
        Me.Button3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.Button3.Image = CType(resources.GetObject("Button3.Image"), System.Drawing.Image)
        Me.Button3.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(45, 22)
        Me.Button3.Text = "Выход"
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(6, 25)
        '
        'CheckBox2
        '
        Me.CheckBox2.AutoSize = True
        Me.CheckBox2.Location = New System.Drawing.Point(80, 293)
        Me.CheckBox2.Name = "CheckBox2"
        Me.CheckBox2.Size = New System.Drawing.Size(127, 17)
        Me.CheckBox2.TabIndex = 20
        Me.CheckBox2.Text = "Массовое удаление"
        Me.CheckBox2.UseVisualStyleBackColor = True
        '
        'chkCont
        '
        Me.chkCont.AutoSize = True
        Me.chkCont.Location = New System.Drawing.Point(425, 200)
        Me.chkCont.Name = "chkCont"
        Me.chkCont.Size = New System.Drawing.Size(158, 17)
        Me.chkCont.TabIndex = 17
        Me.chkCont.Text = "Может быть контейнером"
        Me.chkCont.UseVisualStyleBackColor = True
        Me.chkCont.Visible = False
        '
        'chkVisibleSTR
        '
        Me.chkVisibleSTR.AutoSize = True
        Me.chkVisibleSTR.Location = New System.Drawing.Point(537, 16)
        Me.chkVisibleSTR.Name = "chkVisibleSTR"
        Me.chkVisibleSTR.Size = New System.Drawing.Size(103, 17)
        Me.chkVisibleSTR.TabIndex = 12
        Me.chkVisibleSTR.Text = "Не отображать"
        Me.chkVisibleSTR.UseVisualStyleBackColor = True
        Me.chkVisibleSTR.Visible = False
        '
        'gbOther
        '
        Me.gbOther.Controls.Add(Me.cmbIcon)
        Me.gbOther.Controls.Add(Me.pbOtherICO)
        Me.gbOther.Location = New System.Drawing.Point(537, 16)
        Me.gbOther.Name = "gbOther"
        Me.gbOther.Size = New System.Drawing.Size(126, 131)
        Me.gbOther.TabIndex = 11
        Me.gbOther.TabStop = False
        Me.gbOther.Text = "Иконка"
        Me.gbOther.Visible = False
        '
        'cmbIcon
        '
        Me.cmbIcon.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
        Me.cmbIcon.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmbIcon.FormattingEnabled = True
        Me.cmbIcon.Location = New System.Drawing.Point(7, 20)
        Me.cmbIcon.Name = "cmbIcon"
        Me.cmbIcon.Size = New System.Drawing.Size(113, 21)
        Me.cmbIcon.TabIndex = 1
        '
        'pbOtherICO
        '
        Me.pbOtherICO.Location = New System.Drawing.Point(6, 54)
        Me.pbOtherICO.Name = "pbOtherICO"
        Me.pbOtherICO.Size = New System.Drawing.Size(114, 67)
        Me.pbOtherICO.TabIndex = 0
        Me.pbOtherICO.TabStop = False
        '
        'gb2
        '
        Me.gb2.Controls.Add(Me.lbl2)
        Me.gb2.Controls.Add(Me.cmb2)
        Me.gb2.Location = New System.Drawing.Point(221, 195)
        Me.gb2.Name = "gb2"
        Me.gb2.Size = New System.Drawing.Size(197, 67)
        Me.gb2.TabIndex = 10
        Me.gb2.TabStop = False
        Me.gb2.Text = "Тип"
        '
        'lbl2
        '
        Me.lbl2.AutoSize = True
        Me.lbl2.Location = New System.Drawing.Point(6, 44)
        Me.lbl2.Name = "lbl2"
        Me.lbl2.Size = New System.Drawing.Size(0, 13)
        Me.lbl2.TabIndex = 2
        '
        'cmb2
        '
        Me.cmb2.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
        Me.cmb2.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmb2.FormattingEnabled = True
        Me.cmb2.Location = New System.Drawing.Point(7, 20)
        Me.cmb2.Name = "cmb2"
        Me.cmb2.Size = New System.Drawing.Size(184, 21)
        Me.cmb2.TabIndex = 0
        '
        'gb1
        '
        Me.gb1.Controls.Add(Me.lbl1)
        Me.gb1.Controls.Add(Me.cmb1)
        Me.gb1.Location = New System.Drawing.Point(10, 195)
        Me.gb1.Name = "gb1"
        Me.gb1.Size = New System.Drawing.Size(197, 67)
        Me.gb1.TabIndex = 9
        Me.gb1.TabStop = False
        Me.gb1.Text = "Тип"
        '
        'lbl1
        '
        Me.lbl1.AutoSize = True
        Me.lbl1.Location = New System.Drawing.Point(7, 43)
        Me.lbl1.Name = "lbl1"
        Me.lbl1.Size = New System.Drawing.Size(0, 13)
        Me.lbl1.TabIndex = 1
        '
        'cmb1
        '
        Me.cmb1.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
        Me.cmb1.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmb1.FormattingEnabled = True
        Me.cmb1.Location = New System.Drawing.Point(7, 20)
        Me.cmb1.Name = "cmb1"
        Me.cmb1.Size = New System.Drawing.Size(184, 21)
        Me.cmb1.TabIndex = 0
        '
        'txtMemo
        '
        Me.txtMemo.Location = New System.Drawing.Point(119, 101)
        Me.txtMemo.Multiline = True
        Me.txtMemo.Name = "txtMemo"
        Me.txtMemo.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtMemo.Size = New System.Drawing.Size(412, 92)
        Me.txtMemo.TabIndex = 8
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(6, 143)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(70, 13)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Примечание"
        '
        'txtName
        '
        Me.txtName.Location = New System.Drawing.Point(119, 74)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(412, 20)
        Me.txtName.TabIndex = 6
        '
        'cmbName3
        '
        Me.cmbName3.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
        Me.cmbName3.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmbName3.FormattingEnabled = True
        Me.cmbName3.Location = New System.Drawing.Point(119, 74)
        Me.cmbName3.Name = "cmbName3"
        Me.cmbName3.Size = New System.Drawing.Size(412, 21)
        Me.cmbName3.TabIndex = 5
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(7, 74)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(86, 13)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Производитель"
        '
        'cmbName2
        '
        Me.cmbName2.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
        Me.cmbName2.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmbName2.FormattingEnabled = True
        Me.cmbName2.Location = New System.Drawing.Point(119, 47)
        Me.cmbName2.Name = "cmbName2"
        Me.cmbName2.Size = New System.Drawing.Size(412, 21)
        Me.cmbName2.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(7, 47)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(83, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Наименование"
        '
        'cmbName
        '
        Me.cmbName.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
        Me.cmbName.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmbName.FormattingEnabled = True
        Me.cmbName.Location = New System.Drawing.Point(119, 20)
        Me.cmbName.Name = "cmbName"
        Me.cmbName.Size = New System.Drawing.Size(412, 21)
        Me.cmbName.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(7, 20)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(83, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Наименование"
        '
        'lvDirectory
        '
        Me.lvDirectory.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lvDirectory.FullRowSelect = True
        Me.lvDirectory.GridLines = True
        Me.lvDirectory.Location = New System.Drawing.Point(311, 3)
        Me.lvDirectory.MultiSelect = False
        Me.lvDirectory.Name = "lvDirectory"
        Me.lvDirectory.ShowItemToolTips = True
        Me.lvDirectory.Size = New System.Drawing.Size(695, 261)
        Me.lvDirectory.TabIndex = 16
        Me.lvDirectory.UseCompatibleStateImageBehavior = False
        Me.lvDirectory.View = System.Windows.Forms.View.Details
        '
        'ilsCommands
        '
        Me.ilsCommands.ColorDepth = System.Windows.Forms.ColorDepth.Depth32Bit
        Me.ilsCommands.ImageSize = New System.Drawing.Size(32, 32)
        Me.ilsCommands.TransparentColor = System.Drawing.Color.Transparent
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.tvDirectory, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.gbSpr, 1, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.lvDirectory, 1, 0)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 2
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(1009, 602)
        Me.TableLayoutPanel1.TabIndex = 17
        '
        'frmDirectory
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1009, 602)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.MinimumSize = New System.Drawing.Size(860, 640)
        Me.Name = "frmDirectory"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Справочники"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.gbSpr.ResumeLayout(False)
        Me.gbSpr.PerformLayout()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.gbOther.ResumeLayout(False)
        CType(Me.pbOtherICO, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gb2.ResumeLayout(False)
        Me.gb2.PerformLayout()
        Me.gb1.ResumeLayout(False)
        Me.gb1.PerformLayout()
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents tvDirectory As System.Windows.Forms.TreeView
    Friend WithEvents gbSpr As System.Windows.Forms.GroupBox
    Friend WithEvents gbOther As System.Windows.Forms.GroupBox
    Friend WithEvents cmbIcon As System.Windows.Forms.ComboBox
    Friend WithEvents pbOtherICO As System.Windows.Forms.PictureBox
    Friend WithEvents gb2 As System.Windows.Forms.GroupBox
    Friend WithEvents cmb2 As System.Windows.Forms.ComboBox
    Friend WithEvents gb1 As System.Windows.Forms.GroupBox
    Friend WithEvents cmb1 As System.Windows.Forms.ComboBox
    Friend WithEvents txtMemo As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtName As System.Windows.Forms.TextBox
    Friend WithEvents cmbName3 As System.Windows.Forms.ComboBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents cmbName2 As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents cmbName As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents chkVisibleSTR As System.Windows.Forms.CheckBox
    Friend WithEvents lvDirectory As System.Windows.Forms.ListView
    Friend WithEvents lbl1 As System.Windows.Forms.Label
    Friend WithEvents ilsCommands As System.Windows.Forms.ImageList
    Friend WithEvents lbl2 As System.Windows.Forms.Label
    Friend WithEvents chkCont As System.Windows.Forms.CheckBox
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents btnDirAdd As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents Button2 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents btnCancell As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator4 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents Button3 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents CheckBox2 As System.Windows.Forms.CheckBox
    Friend WithEvents ToolStripButton1 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator5 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
End Class
