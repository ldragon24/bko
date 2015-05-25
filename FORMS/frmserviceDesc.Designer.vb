<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmserviceDesc
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmserviceDesc))
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.gbTree = New System.Windows.Forms.GroupBox()
        Me.TableLayoutPanel3 = New System.Windows.Forms.TableLayoutPanel()
        Me.treebranche = New System.Windows.Forms.ComboBox()
        Me.txtSearch = New System.Windows.Forms.TextBox()
        Me.lstGroups = New System.Windows.Forms.TreeView()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.btnSearch = New System.Windows.Forms.ToolStripButton()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.gbRem = New System.Windows.Forms.GroupBox()
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
        Me.lvRem = New System.Windows.Forms.ListView()
        Me.New_Button_SD = New System.Windows.Forms.ToolStrip()
        Me.btnRemAdd = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.btnSBTAdd = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.btnRemDel = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.btnSendEmail = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator4 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripDropDownButton1 = New System.Windows.Forms.ToolStripDropDownButton()
        Me.btn_Z_to_Office = New System.Windows.Forms.ToolStripMenuItem()
        Me.Button1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.btn_N_to_Office = New System.Windows.Forms.ToolStripMenuItem()
        Me.btn_MAT_to_Office = New System.Windows.Forms.ToolStripMenuItem()
        Me.MnuBlank = New System.Windows.Forms.ToolStripMenuItem()
        Me.CheckBox2 = New System.Windows.Forms.CheckBox()
        Me.chkNZ = New System.Windows.Forms.CheckBox()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.gbRem2 = New System.Windows.Forms.GroupBox()
        Me.lvRem2 = New System.Windows.Forms.ListView()
        Me.ilsCMD = New System.Windows.Forms.ImageList(Me.components)
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.CMServices = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.EditService = New System.Windows.Forms.ToolStripMenuItem()
        Me.DeleteService = New System.Windows.Forms.ToolStripMenuItem()
        Me.MnuSendEmail = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnu_Z_to_Office = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnu_z_rasp = New System.Windows.Forms.ToolStripMenuItem()
        Me.addServiseWork = New System.Windows.Forms.ToolStripMenuItem()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        Me.gbTree.SuspendLayout()
        Me.TableLayoutPanel3.SuspendLayout()
        Me.ToolStrip1.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.gbRem.SuspendLayout()
        Me.TableLayoutPanel2.SuspendLayout()
        Me.New_Button_SD.SuspendLayout()
        Me.gbRem2.SuspendLayout()
        Me.CMServices.SuspendLayout()
        Me.SuspendLayout()
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
        Me.SplitContainer1.Panel2.Controls.Add(Me.TableLayoutPanel1)
        Me.SplitContainer1.Size = New System.Drawing.Size(934, 468)
        Me.SplitContainer1.SplitterDistance = 294
        Me.SplitContainer1.TabIndex = 1
        '
        'gbTree
        '
        Me.gbTree.Controls.Add(Me.TableLayoutPanel3)
        Me.gbTree.Dock = System.Windows.Forms.DockStyle.Fill
        Me.gbTree.Location = New System.Drawing.Point(0, 0)
        Me.gbTree.Name = "gbTree"
        Me.gbTree.Size = New System.Drawing.Size(294, 468)
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
        Me.TableLayoutPanel3.Controls.Add(Me.ToolStrip1, 1, 0)
        Me.TableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel3.Location = New System.Drawing.Point(3, 16)
        Me.TableLayoutPanel3.Name = "TableLayoutPanel3"
        Me.TableLayoutPanel3.RowCount = 3
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 26.0!))
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel3.Size = New System.Drawing.Size(288, 449)
        Me.TableLayoutPanel3.TabIndex = 4
        '
        'treebranche
        '
        Me.TableLayoutPanel3.SetColumnSpan(Me.treebranche, 2)
        Me.treebranche.Dock = System.Windows.Forms.DockStyle.Fill
        Me.treebranche.FormattingEnabled = True
        Me.treebranche.Location = New System.Drawing.Point(3, 33)
        Me.treebranche.Name = "treebranche"
        Me.treebranche.Size = New System.Drawing.Size(282, 21)
        Me.treebranche.TabIndex = 7
        '
        'txtSearch
        '
        Me.txtSearch.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtSearch.Location = New System.Drawing.Point(3, 3)
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.Size = New System.Drawing.Size(247, 20)
        Me.txtSearch.TabIndex = 2
        '
        'lstGroups
        '
        Me.TableLayoutPanel3.SetColumnSpan(Me.lstGroups, 2)
        Me.lstGroups.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lstGroups.FullRowSelect = True
        Me.lstGroups.HideSelection = False
        Me.lstGroups.Location = New System.Drawing.Point(3, 59)
        Me.lstGroups.Name = "lstGroups"
        Me.lstGroups.Size = New System.Drawing.Size(282, 387)
        Me.lstGroups.TabIndex = 0
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ToolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnSearch})
        Me.ToolStrip1.Location = New System.Drawing.Point(253, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(35, 30)
        Me.ToolStrip1.TabIndex = 8
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'btnSearch
        '
        Me.btnSearch.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btnSearch.Image = CType(resources.GetObject("btnSearch.Image"), System.Drawing.Image)
        Me.btnSearch.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(23, 27)
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 1
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.gbRem, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.gbRem2, 0, 1)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 2
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 60.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 40.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(636, 468)
        Me.TableLayoutPanel1.TabIndex = 3
        '
        'gbRem
        '
        Me.gbRem.Controls.Add(Me.TableLayoutPanel2)
        Me.gbRem.Dock = System.Windows.Forms.DockStyle.Fill
        Me.gbRem.Location = New System.Drawing.Point(3, 3)
        Me.gbRem.Name = "gbRem"
        Me.gbRem.Size = New System.Drawing.Size(630, 274)
        Me.gbRem.TabIndex = 0
        Me.gbRem.TabStop = False
        Me.gbRem.Text = "Заявки:"
        '
        'TableLayoutPanel2
        '
        Me.TableLayoutPanel2.ColumnCount = 5
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel2.Controls.Add(Me.lvRem, 0, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.New_Button_SD, 0, 1)
        Me.TableLayoutPanel2.Controls.Add(Me.CheckBox2, 0, 2)
        Me.TableLayoutPanel2.Controls.Add(Me.chkNZ, 1, 2)
        Me.TableLayoutPanel2.Controls.Add(Me.CheckBox1, 2, 2)
        Me.TableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(3, 16)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RowCount = 3
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(624, 255)
        Me.TableLayoutPanel2.TabIndex = 7
        '
        'lvRem
        '
        Me.TableLayoutPanel2.SetColumnSpan(Me.lvRem, 5)
        Me.lvRem.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lvRem.FullRowSelect = True
        Me.lvRem.GridLines = True
        Me.lvRem.Location = New System.Drawing.Point(3, 3)
        Me.lvRem.MultiSelect = False
        Me.lvRem.Name = "lvRem"
        Me.lvRem.Size = New System.Drawing.Size(642, 203)
        Me.lvRem.TabIndex = 6
        Me.lvRem.UseCompatibleStateImageBehavior = False
        Me.lvRem.View = System.Windows.Forms.View.Details
        '
        'New_Button_SD
        '
        Me.TableLayoutPanel2.SetColumnSpan(Me.New_Button_SD, 4)
        Me.New_Button_SD.Dock = System.Windows.Forms.DockStyle.None
        Me.New_Button_SD.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.New_Button_SD.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnRemAdd, Me.ToolStripSeparator1, Me.btnSBTAdd, Me.ToolStripSeparator2, Me.btnRemDel, Me.ToolStripSeparator3, Me.btnSendEmail, Me.ToolStripSeparator4, Me.ToolStripDropDownButton1})
        Me.New_Button_SD.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.Flow
        Me.New_Button_SD.Location = New System.Drawing.Point(0, 209)
        Me.New_Button_SD.Name = "New_Button_SD"
        Me.New_Button_SD.Size = New System.Drawing.Size(524, 23)
        Me.New_Button_SD.TabIndex = 10
        Me.New_Button_SD.Text = "ToolStrip1"
        '
        'btnRemAdd
        '
        Me.btnRemAdd.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.btnRemAdd.Image = CType(resources.GetObject("btnRemAdd.Image"), System.Drawing.Image)
        Me.btnRemAdd.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnRemAdd.Name = "btnRemAdd"
        Me.btnRemAdd.Size = New System.Drawing.Size(117, 19)
        Me.btnRemAdd.Text = "Регистрация новой"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 23)
        '
        'btnSBTAdd
        '
        Me.btnSBTAdd.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.btnSBTAdd.Image = CType(resources.GetObject("btnSBTAdd.Image"), System.Drawing.Image)
        Me.btnSBTAdd.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnSBTAdd.Name = "btnSBTAdd"
        Me.btnSBTAdd.Size = New System.Drawing.Size(113, 19)
        Me.btnSBTAdd.Text = "Добавить событие"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 23)
        '
        'btnRemDel
        '
        Me.btnRemDel.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.btnRemDel.Image = CType(resources.GetObject("btnRemDel.Image"), System.Drawing.Image)
        Me.btnRemDel.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnRemDel.Name = "btnRemDel"
        Me.btnRemDel.Size = New System.Drawing.Size(93, 19)
        Me.btnRemDel.Text = "Удалить заявку"
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(6, 23)
        '
        'btnSendEmail
        '
        Me.btnSendEmail.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.btnSendEmail.Image = CType(resources.GetObject("btnSendEmail.Image"), System.Drawing.Image)
        Me.btnSendEmail.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnSendEmail.Name = "btnSendEmail"
        Me.btnSendEmail.Size = New System.Drawing.Size(117, 19)
        Me.btnSendEmail.Text = "Отправить мастеру"
        '
        'ToolStripSeparator4
        '
        Me.ToolStripSeparator4.Name = "ToolStripSeparator4"
        Me.ToolStripSeparator4.Size = New System.Drawing.Size(6, 23)
        '
        'ToolStripDropDownButton1
        '
        Me.ToolStripDropDownButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.ToolStripDropDownButton1.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btn_Z_to_Office, Me.Button1, Me.btn_N_to_Office, Me.btn_MAT_to_Office, Me.MnuBlank})
        Me.ToolStripDropDownButton1.Image = CType(resources.GetObject("ToolStripDropDownButton1.Image"), System.Drawing.Image)
        Me.ToolStripDropDownButton1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripDropDownButton1.Name = "ToolStripDropDownButton1"
        Me.ToolStripDropDownButton1.Size = New System.Drawing.Size(59, 19)
        Me.ToolStripDropDownButton1.Text = "Печать"
        '
        'btn_Z_to_Office
        '
        Me.btn_Z_to_Office.Name = "btn_Z_to_Office"
        Me.btn_Z_to_Office.Size = New System.Drawing.Size(207, 22)
        Me.btn_Z_to_Office.Text = "Акт-Заявка"
        '
        'Button1
        '
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(207, 22)
        Me.Button1.Text = "Расписка"
        '
        'btn_N_to_Office
        '
        Me.btn_N_to_Office.Name = "btn_N_to_Office"
        Me.btn_N_to_Office.Size = New System.Drawing.Size(207, 22)
        Me.btn_N_to_Office.Text = "Наряд"
        '
        'btn_MAT_to_Office
        '
        Me.btn_MAT_to_Office.Name = "btn_MAT_to_Office"
        Me.btn_MAT_to_Office.Size = New System.Drawing.Size(207, 22)
        Me.btn_MAT_to_Office.Text = "Материальный пропуск"
        '
        'MnuBlank
        '
        Me.MnuBlank.Name = "MnuBlank"
        Me.MnuBlank.Size = New System.Drawing.Size(207, 22)
        Me.MnuBlank.Text = "Бланк"
        '
        'CheckBox2
        '
        Me.CheckBox2.AutoSize = True
        Me.CheckBox2.Location = New System.Drawing.Point(3, 235)
        Me.CheckBox2.Name = "CheckBox2"
        Me.CheckBox2.Size = New System.Drawing.Size(133, 17)
        Me.CheckBox2.TabIndex = 5
        Me.CheckBox2.Text = "Все не завершенные"
        Me.CheckBox2.UseVisualStyleBackColor = True
        '
        'chkNZ
        '
        Me.chkNZ.AutoSize = True
        Me.chkNZ.Location = New System.Drawing.Point(142, 235)
        Me.chkNZ.Name = "chkNZ"
        Me.chkNZ.Size = New System.Drawing.Size(113, 17)
        Me.chkNZ.TabIndex = 4
        Me.chkNZ.Text = "Не завершенные"
        Me.chkNZ.UseVisualStyleBackColor = True
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.Location = New System.Drawing.Point(261, 235)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(127, 17)
        Me.CheckBox1.TabIndex = 20
        Me.CheckBox1.Text = "Массовое удаление"
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'gbRem2
        '
        Me.gbRem2.Controls.Add(Me.lvRem2)
        Me.gbRem2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.gbRem2.Location = New System.Drawing.Point(3, 283)
        Me.gbRem2.Name = "gbRem2"
        Me.gbRem2.Size = New System.Drawing.Size(630, 182)
        Me.gbRem2.TabIndex = 2
        Me.gbRem2.TabStop = False
        Me.gbRem2.Text = "Выполненные работы:"
        '
        'lvRem2
        '
        Me.lvRem2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lvRem2.FullRowSelect = True
        Me.lvRem2.GridLines = True
        Me.lvRem2.Location = New System.Drawing.Point(3, 16)
        Me.lvRem2.MultiSelect = False
        Me.lvRem2.Name = "lvRem2"
        Me.lvRem2.ShowItemToolTips = True
        Me.lvRem2.Size = New System.Drawing.Size(624, 163)
        Me.lvRem2.TabIndex = 7
        Me.lvRem2.UseCompatibleStateImageBehavior = False
        Me.lvRem2.View = System.Windows.Forms.View.Details
        '
        'ilsCMD
        '
        Me.ilsCMD.ColorDepth = System.Windows.Forms.ColorDepth.Depth32Bit
        Me.ilsCMD.ImageSize = New System.Drawing.Size(16, 16)
        Me.ilsCMD.TransparentColor = System.Drawing.Color.Transparent
        '
        'ToolTip1
        '
        Me.ToolTip1.AutoPopDelay = 9000
        Me.ToolTip1.InitialDelay = 500
        Me.ToolTip1.IsBalloon = True
        Me.ToolTip1.ReshowDelay = 100
        Me.ToolTip1.ShowAlways = True
        Me.ToolTip1.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info
        '
        'CMServices
        '
        Me.CMServices.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.EditService, Me.DeleteService, Me.MnuSendEmail, Me.mnu_Z_to_Office, Me.mnu_z_rasp, Me.addServiseWork})
        Me.CMServices.Name = "CMServices"
        Me.CMServices.Size = New System.Drawing.Size(175, 136)
        '
        'EditService
        '
        Me.EditService.Name = "EditService"
        Me.EditService.Size = New System.Drawing.Size(174, 22)
        Me.EditService.Text = "Редактировать"
        '
        'DeleteService
        '
        Me.DeleteService.Name = "DeleteService"
        Me.DeleteService.Size = New System.Drawing.Size(174, 22)
        Me.DeleteService.Text = "Удалить"
        '
        'MnuSendEmail
        '
        Me.MnuSendEmail.Name = "MnuSendEmail"
        Me.MnuSendEmail.Size = New System.Drawing.Size(174, 22)
        Me.MnuSendEmail.Text = "Отправить матеру"
        '
        'mnu_Z_to_Office
        '
        Me.mnu_Z_to_Office.Name = "mnu_Z_to_Office"
        Me.mnu_Z_to_Office.Size = New System.Drawing.Size(174, 22)
        Me.mnu_Z_to_Office.Text = "Распечатать"
        '
        'mnu_z_rasp
        '
        Me.mnu_z_rasp.Name = "mnu_z_rasp"
        Me.mnu_z_rasp.Size = New System.Drawing.Size(174, 22)
        Me.mnu_z_rasp.Text = "Расписка"
        '
        'addServiseWork
        '
        Me.addServiseWork.Name = "addServiseWork"
        Me.addServiseWork.Size = New System.Drawing.Size(174, 22)
        Me.addServiseWork.Text = "Добавить работы"
        '
        'frmserviceDesc
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(934, 468)
        Me.Controls.Add(Me.SplitContainer1)
        Me.MinimumSize = New System.Drawing.Size(944, 501)
        Me.Name = "frmserviceDesc"
        Me.Text = "Учёт заявок"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        Me.SplitContainer1.ResumeLayout(False)
        Me.gbTree.ResumeLayout(False)
        Me.TableLayoutPanel3.ResumeLayout(False)
        Me.TableLayoutPanel3.PerformLayout()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.gbRem.ResumeLayout(False)
        Me.TableLayoutPanel2.ResumeLayout(False)
        Me.TableLayoutPanel2.PerformLayout()
        Me.New_Button_SD.ResumeLayout(False)
        Me.New_Button_SD.PerformLayout()
        Me.gbRem2.ResumeLayout(False)
        Me.CMServices.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents gbTree As System.Windows.Forms.GroupBox
    Friend WithEvents txtSearch As System.Windows.Forms.TextBox
    Friend WithEvents lstGroups As System.Windows.Forms.TreeView
    Friend WithEvents gbRem2 As System.Windows.Forms.GroupBox
    Friend WithEvents lvRem2 As System.Windows.Forms.ListView
    Friend WithEvents gbRem As System.Windows.Forms.GroupBox
    Friend WithEvents lvRem As System.Windows.Forms.ListView
    Friend WithEvents CheckBox2 As System.Windows.Forms.CheckBox
    Friend WithEvents chkNZ As System.Windows.Forms.CheckBox
    Friend WithEvents ilsCMD As System.Windows.Forms.ImageList
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents TableLayoutPanel3 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents TableLayoutPanel2 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents treebranche As System.Windows.Forms.ComboBox
    Friend WithEvents New_Button_SD As System.Windows.Forms.ToolStrip
    Friend WithEvents btnRemAdd As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnSBTAdd As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnRemDel As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnSendEmail As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripSeparator3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripSeparator4 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripDropDownButton1 As System.Windows.Forms.ToolStripDropDownButton
    Friend WithEvents btn_Z_to_Office As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Button1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents btn_N_to_Office As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents btn_MAT_to_Office As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CheckBox1 As System.Windows.Forms.CheckBox
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents btnSearch As System.Windows.Forms.ToolStripButton
    Friend WithEvents MnuBlank As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CMServices As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents EditService As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DeleteService As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MnuSendEmail As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnu_Z_to_Office As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnu_z_rasp As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents addServiseWork As System.Windows.Forms.ToolStripMenuItem
End Class
