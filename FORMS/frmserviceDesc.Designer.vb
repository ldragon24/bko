﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
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
        Me.btnSearch = New System.Windows.Forms.Button()
        Me.txtSearch = New System.Windows.Forms.TextBox()
        Me.lstGroups = New System.Windows.Forms.TreeView()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.gbRem = New System.Windows.Forms.GroupBox()
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
        Me.lvRem = New System.Windows.Forms.ListView()
        Me.btnRemAdd = New System.Windows.Forms.Button()
        Me.btnSBTAdd = New System.Windows.Forms.Button()
        Me.btnRemDel = New System.Windows.Forms.Button()
        Me.chkNZ = New System.Windows.Forms.CheckBox()
        Me.CheckBox2 = New System.Windows.Forms.CheckBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.btnSendEmail = New System.Windows.Forms.Button()
        Me.btn_Z_to_Office = New System.Windows.Forms.Button()
        Me.gbRem2 = New System.Windows.Forms.GroupBox()
        Me.lvRem2 = New System.Windows.Forms.ListView()
        Me.ilsCMD = New System.Windows.Forms.ImageList(Me.components)
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        Me.gbTree.SuspendLayout()
        Me.TableLayoutPanel3.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.gbRem.SuspendLayout()
        Me.TableLayoutPanel2.SuspendLayout()
        Me.gbRem2.SuspendLayout()
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
        Me.SplitContainer1.Size = New System.Drawing.Size(962, 680)
        Me.SplitContainer1.SplitterDistance = 305
        Me.SplitContainer1.TabIndex = 1
        '
        'gbTree
        '
        Me.gbTree.Controls.Add(Me.TableLayoutPanel3)
        Me.gbTree.Dock = System.Windows.Forms.DockStyle.Fill
        Me.gbTree.Location = New System.Drawing.Point(0, 0)
        Me.gbTree.Name = "gbTree"
        Me.gbTree.Size = New System.Drawing.Size(305, 680)
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
        Me.TableLayoutPanel3.Controls.Add(Me.btnSearch, 1, 0)
        Me.TableLayoutPanel3.Controls.Add(Me.txtSearch, 0, 0)
        Me.TableLayoutPanel3.Controls.Add(Me.lstGroups, 0, 2)
        Me.TableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel3.Location = New System.Drawing.Point(3, 16)
        Me.TableLayoutPanel3.Name = "TableLayoutPanel3"
        Me.TableLayoutPanel3.RowCount = 3
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 26.0!))
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel3.Size = New System.Drawing.Size(299, 661)
        Me.TableLayoutPanel3.TabIndex = 4
        '
        'treebranche
        '
        Me.TableLayoutPanel3.SetColumnSpan(Me.treebranche, 2)
        Me.treebranche.Dock = System.Windows.Forms.DockStyle.Fill
        Me.treebranche.FormattingEnabled = True
        Me.treebranche.Location = New System.Drawing.Point(3, 33)
        Me.treebranche.Name = "treebranche"
        Me.treebranche.Size = New System.Drawing.Size(293, 21)
        Me.treebranche.TabIndex = 7
        '
        'btnSearch
        '
        Me.btnSearch.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnSearch.Image = CType(resources.GetObject("btnSearch.Image"), System.Drawing.Image)
        Me.btnSearch.Location = New System.Drawing.Point(267, 3)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(29, 24)
        Me.btnSearch.TabIndex = 3
        Me.btnSearch.UseVisualStyleBackColor = True
        '
        'txtSearch
        '
        Me.txtSearch.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtSearch.Location = New System.Drawing.Point(3, 3)
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.Size = New System.Drawing.Size(258, 20)
        Me.txtSearch.TabIndex = 2
        '
        'lstGroups
        '
        Me.TableLayoutPanel3.SetColumnSpan(Me.lstGroups, 2)
        Me.lstGroups.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lstGroups.FullRowSelect = True
        Me.lstGroups.Location = New System.Drawing.Point(3, 59)
        Me.lstGroups.Name = "lstGroups"
        Me.lstGroups.Size = New System.Drawing.Size(293, 599)
        Me.lstGroups.TabIndex = 0
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
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(653, 680)
        Me.TableLayoutPanel1.TabIndex = 3
        '
        'gbRem
        '
        Me.gbRem.Controls.Add(Me.TableLayoutPanel2)
        Me.gbRem.Dock = System.Windows.Forms.DockStyle.Fill
        Me.gbRem.Location = New System.Drawing.Point(3, 3)
        Me.gbRem.Name = "gbRem"
        Me.gbRem.Size = New System.Drawing.Size(647, 402)
        Me.gbRem.TabIndex = 0
        Me.gbRem.TabStop = False
        Me.gbRem.Text = "Заявки:"
        '
        'TableLayoutPanel2
        '
        Me.TableLayoutPanel2.ColumnCount = 5
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 121.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 119.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 120.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 120.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel2.Controls.Add(Me.lvRem, 0, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.btnRemAdd, 0, 1)
        Me.TableLayoutPanel2.Controls.Add(Me.btnSBTAdd, 1, 1)
        Me.TableLayoutPanel2.Controls.Add(Me.btnRemDel, 2, 1)
        Me.TableLayoutPanel2.Controls.Add(Me.chkNZ, 3, 1)
        Me.TableLayoutPanel2.Controls.Add(Me.CheckBox2, 4, 1)
        Me.TableLayoutPanel2.Controls.Add(Me.Button1, 1, 2)
        Me.TableLayoutPanel2.Controls.Add(Me.btnSendEmail, 0, 2)
        Me.TableLayoutPanel2.Controls.Add(Me.btn_Z_to_Office, 2, 2)
        Me.TableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(3, 16)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RowCount = 3
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 26.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 27.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(641, 383)
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
        Me.lvRem.Size = New System.Drawing.Size(647, 324)
        Me.lvRem.TabIndex = 6
        Me.lvRem.UseCompatibleStateImageBehavior = False
        Me.lvRem.View = System.Windows.Forms.View.Details
        '
        'btnRemAdd
        '
        Me.btnRemAdd.Location = New System.Drawing.Point(3, 333)
        Me.btnRemAdd.Name = "btnRemAdd"
        Me.btnRemAdd.Size = New System.Drawing.Size(114, 20)
        Me.btnRemAdd.TabIndex = 1
        Me.btnRemAdd.Text = "Регистрация новой"
        Me.btnRemAdd.UseVisualStyleBackColor = True
        '
        'btnSBTAdd
        '
        Me.btnSBTAdd.Location = New System.Drawing.Point(124, 333)
        Me.btnSBTAdd.Name = "btnSBTAdd"
        Me.btnSBTAdd.Size = New System.Drawing.Size(113, 20)
        Me.btnSBTAdd.TabIndex = 2
        Me.btnSBTAdd.Text = "Добавить событие"
        Me.btnSBTAdd.UseVisualStyleBackColor = True
        '
        'btnRemDel
        '
        Me.btnRemDel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnRemDel.Location = New System.Drawing.Point(243, 333)
        Me.btnRemDel.Name = "btnRemDel"
        Me.btnRemDel.Size = New System.Drawing.Size(114, 20)
        Me.btnRemDel.TabIndex = 3
        Me.btnRemDel.Text = "Удалить заявку"
        Me.btnRemDel.UseVisualStyleBackColor = True
        '
        'chkNZ
        '
        Me.chkNZ.AutoSize = True
        Me.chkNZ.Location = New System.Drawing.Point(363, 333)
        Me.chkNZ.Name = "chkNZ"
        Me.chkNZ.Size = New System.Drawing.Size(113, 17)
        Me.chkNZ.TabIndex = 4
        Me.chkNZ.Text = "Не завершенные"
        Me.chkNZ.UseVisualStyleBackColor = True
        '
        'CheckBox2
        '
        Me.CheckBox2.AutoSize = True
        Me.CheckBox2.Location = New System.Drawing.Point(483, 333)
        Me.CheckBox2.Name = "CheckBox2"
        Me.CheckBox2.Size = New System.Drawing.Size(133, 17)
        Me.CheckBox2.TabIndex = 5
        Me.CheckBox2.Text = "Все не завершенные"
        Me.CheckBox2.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(124, 359)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(113, 20)
        Me.Button1.TabIndex = 8
        Me.Button1.Text = "Расписка"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'btnSendEmail
        '
        Me.btnSendEmail.Location = New System.Drawing.Point(3, 359)
        Me.btnSendEmail.Name = "btnSendEmail"
        Me.btnSendEmail.Size = New System.Drawing.Size(114, 21)
        Me.btnSendEmail.TabIndex = 7
        Me.btnSendEmail.Text = "Отправить мастеру"
        Me.btnSendEmail.UseVisualStyleBackColor = True
        '
        'btn_Z_to_Office
        '
        Me.btn_Z_to_Office.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btn_Z_to_Office.Location = New System.Drawing.Point(243, 359)
        Me.btn_Z_to_Office.Name = "btn_Z_to_Office"
        Me.btn_Z_to_Office.Size = New System.Drawing.Size(114, 21)
        Me.btn_Z_to_Office.TabIndex = 9
        Me.btn_Z_to_Office.Text = "Печать"
        Me.btn_Z_to_Office.UseVisualStyleBackColor = True
        '
        'gbRem2
        '
        Me.gbRem2.Controls.Add(Me.lvRem2)
        Me.gbRem2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.gbRem2.Location = New System.Drawing.Point(3, 411)
        Me.gbRem2.Name = "gbRem2"
        Me.gbRem2.Size = New System.Drawing.Size(647, 266)
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
        Me.lvRem2.Size = New System.Drawing.Size(641, 247)
        Me.lvRem2.TabIndex = 7
        Me.lvRem2.UseCompatibleStateImageBehavior = False
        Me.lvRem2.View = System.Windows.Forms.View.Details
        '
        'ilsCMD
        '
        Me.ilsCMD.ImageStream = CType(resources.GetObject("ilsCMD.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ilsCMD.TransparentColor = System.Drawing.Color.Transparent
        Me.ilsCMD.Images.SetKeyName(0, "apply.ico")
        Me.ilsCMD.Images.SetKeyName(1, "cnrdelete-all_.ico")
        Me.ilsCMD.Images.SetKeyName(2, "Refresh.ico")
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
        'frmserviceDesc
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(962, 680)
        Me.Controls.Add(Me.SplitContainer1)
        Me.Name = "frmserviceDesc"
        Me.Text = "Учёт заявок"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        Me.gbTree.ResumeLayout(False)
        Me.TableLayoutPanel3.ResumeLayout(False)
        Me.TableLayoutPanel3.PerformLayout()
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.gbRem.ResumeLayout(False)
        Me.TableLayoutPanel2.ResumeLayout(False)
        Me.TableLayoutPanel2.PerformLayout()
        Me.gbRem2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents gbTree As System.Windows.Forms.GroupBox
    Friend WithEvents btnSearch As System.Windows.Forms.Button
    Friend WithEvents txtSearch As System.Windows.Forms.TextBox
    Friend WithEvents lstGroups As System.Windows.Forms.TreeView
    Friend WithEvents gbRem2 As System.Windows.Forms.GroupBox
    Friend WithEvents lvRem2 As System.Windows.Forms.ListView
    Friend WithEvents gbRem As System.Windows.Forms.GroupBox
    Friend WithEvents lvRem As System.Windows.Forms.ListView
    Friend WithEvents CheckBox2 As System.Windows.Forms.CheckBox
    Friend WithEvents chkNZ As System.Windows.Forms.CheckBox
    Friend WithEvents btnRemDel As System.Windows.Forms.Button
    Friend WithEvents btnSBTAdd As System.Windows.Forms.Button
    Friend WithEvents btnRemAdd As System.Windows.Forms.Button
    Friend WithEvents ilsCMD As System.Windows.Forms.ImageList
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents TableLayoutPanel3 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents TableLayoutPanel2 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents btnSendEmail As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents treebranche As System.Windows.Forms.ComboBox
    Friend WithEvents btn_Z_to_Office As System.Windows.Forms.Button
End Class