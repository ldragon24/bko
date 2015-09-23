<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmNetMagazin
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmNetMagazin))
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.gbTree = New System.Windows.Forms.GroupBox()
        Me.TableLayoutPanel3 = New System.Windows.Forms.TableLayoutPanel()
        Me.treebranche = New System.Windows.Forms.ComboBox()
        Me.lstGroups = New System.Windows.Forms.TreeView()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.gbRem = New System.Windows.Forms.GroupBox()
        Me.lvNetMagazin = New System.Windows.Forms.ListView()
        Me.tsPanNetMag = New System.Windows.Forms.ToolStrip()
        Me.tsbAdd = New System.Windows.Forms.ToolStripButton()
        Me.tsbDel = New System.Windows.Forms.ToolStripButton()
        Me.tsbExcell = New System.Windows.Forms.ToolStripButton()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        Me.gbTree.SuspendLayout()
        Me.TableLayoutPanel3.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.gbRem.SuspendLayout()
        Me.tsPanNetMag.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.TableLayoutPanel2.SuspendLayout()
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
        Me.SplitContainer1.Size = New System.Drawing.Size(749, 549)
        Me.SplitContainer1.SplitterDistance = 235
        Me.SplitContainer1.TabIndex = 2
        '
        'gbTree
        '
        Me.gbTree.Controls.Add(Me.TableLayoutPanel3)
        Me.gbTree.Dock = System.Windows.Forms.DockStyle.Fill
        Me.gbTree.Location = New System.Drawing.Point(0, 0)
        Me.gbTree.Name = "gbTree"
        Me.gbTree.Size = New System.Drawing.Size(235, 549)
        Me.gbTree.TabIndex = 0
        Me.gbTree.TabStop = False
        Me.gbTree.Text = "Дерево"
        '
        'TableLayoutPanel3
        '
        Me.TableLayoutPanel3.ColumnCount = 2
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 35.0!))
        Me.TableLayoutPanel3.Controls.Add(Me.treebranche, 0, 0)
        Me.TableLayoutPanel3.Controls.Add(Me.lstGroups, 0, 1)
        Me.TableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel3.Location = New System.Drawing.Point(3, 16)
        Me.TableLayoutPanel3.Name = "TableLayoutPanel3"
        Me.TableLayoutPanel3.RowCount = 3
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 26.0!))
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel3.Size = New System.Drawing.Size(229, 530)
        Me.TableLayoutPanel3.TabIndex = 4
        '
        'treebranche
        '
        Me.TableLayoutPanel3.SetColumnSpan(Me.treebranche, 2)
        Me.treebranche.Dock = System.Windows.Forms.DockStyle.Fill
        Me.treebranche.FormattingEnabled = True
        Me.treebranche.Location = New System.Drawing.Point(3, 3)
        Me.treebranche.Name = "treebranche"
        Me.treebranche.Size = New System.Drawing.Size(223, 21)
        Me.treebranche.TabIndex = 7
        '
        'lstGroups
        '
        Me.TableLayoutPanel3.SetColumnSpan(Me.lstGroups, 2)
        Me.lstGroups.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lstGroups.FullRowSelect = True
        Me.lstGroups.HideSelection = False
        Me.lstGroups.Location = New System.Drawing.Point(3, 33)
        Me.lstGroups.Name = "lstGroups"
        Me.TableLayoutPanel3.SetRowSpan(Me.lstGroups, 2)
        Me.lstGroups.Size = New System.Drawing.Size(223, 494)
        Me.lstGroups.TabIndex = 0
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 1
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.gbRem, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.tsPanNetMag, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.GroupBox1, 0, 2)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 3
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 100.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(510, 549)
        Me.TableLayoutPanel1.TabIndex = 3
        '
        'gbRem
        '
        Me.gbRem.Controls.Add(Me.lvNetMagazin)
        Me.gbRem.Dock = System.Windows.Forms.DockStyle.Fill
        Me.gbRem.Location = New System.Drawing.Point(3, 3)
        Me.gbRem.Name = "gbRem"
        Me.gbRem.Size = New System.Drawing.Size(504, 418)
        Me.gbRem.TabIndex = 0
        Me.gbRem.TabStop = False
        '
        'lvNetMagazin
        '
        Me.lvNetMagazin.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lvNetMagazin.FullRowSelect = True
        Me.lvNetMagazin.GridLines = True
        Me.lvNetMagazin.Location = New System.Drawing.Point(3, 16)
        Me.lvNetMagazin.MultiSelect = False
        Me.lvNetMagazin.Name = "lvNetMagazin"
        Me.lvNetMagazin.Size = New System.Drawing.Size(498, 399)
        Me.lvNetMagazin.TabIndex = 6
        Me.lvNetMagazin.UseCompatibleStateImageBehavior = False
        Me.lvNetMagazin.View = System.Windows.Forms.View.Details
        '
        'tsPanNetMag
        '
        Me.tsPanNetMag.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.tsPanNetMag.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.tsPanNetMag.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.tsPanNetMag.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsbAdd, Me.tsbDel, Me.tsbExcell})
        Me.tsPanNetMag.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow
        Me.tsPanNetMag.Location = New System.Drawing.Point(0, 424)
        Me.tsPanNetMag.Name = "tsPanNetMag"
        Me.tsPanNetMag.RenderMode = System.Windows.Forms.ToolStripRenderMode.System
        Me.tsPanNetMag.Size = New System.Drawing.Size(510, 25)
        Me.tsPanNetMag.TabIndex = 1
        Me.tsPanNetMag.Text = "ToolStrip1"
        '
        'tsbAdd
        '
        Me.tsbAdd.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tsbAdd.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbAdd.Name = "tsbAdd"
        Me.tsbAdd.Size = New System.Drawing.Size(23, 22)
        Me.tsbAdd.Text = "+"
        Me.tsbAdd.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        '
        'tsbDel
        '
        Me.tsbDel.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tsbDel.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbDel.Name = "tsbDel"
        Me.tsbDel.Size = New System.Drawing.Size(23, 22)
        Me.tsbDel.Text = "-"
        Me.tsbDel.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        '
        'tsbExcell
        '
        Me.tsbExcell.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.tsbExcell.Image = CType(resources.GetObject("tsbExcell.Image"), System.Drawing.Image)
        Me.tsbExcell.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbExcell.Name = "tsbExcell"
        Me.tsbExcell.Size = New System.Drawing.Size(66, 22)
        Me.tsbExcell.Text = "В Офис"
        Me.tsbExcell.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.TableLayoutPanel2)
        Me.GroupBox1.Location = New System.Drawing.Point(3, 452)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(493, 93)
        Me.GroupBox1.TabIndex = 2
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "КЛС"
        '
        'TableLayoutPanel2
        '
        Me.TableLayoutPanel2.ColumnCount = 2
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel2.Controls.Add(Me.Label1, 0, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.Label2, 0, 1)
        Me.TableLayoutPanel2.Controls.Add(Me.Label3, 0, 2)
        Me.TableLayoutPanel2.Controls.Add(Me.Label4, 1, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.Label5, 1, 1)
        Me.TableLayoutPanel2.Controls.Add(Me.Label6, 1, 2)
        Me.TableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(3, 16)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RowCount = 3
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(487, 74)
        Me.TableLayoutPanel2.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Label1.Location = New System.Drawing.Point(3, 7)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(237, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Всего портов:"
        '
        'Label2
        '
        Me.Label2.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Label2.Location = New System.Drawing.Point(3, 34)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(237, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Из них занято:"
        '
        'Label3
        '
        Me.Label3.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Label3.Location = New System.Drawing.Point(3, 57)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(237, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Длинна КЛС:"
        '
        'Label4
        '
        Me.Label4.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(246, 7)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(238, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "-"
        '
        'Label5
        '
        Me.Label5.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(246, 34)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(238, 13)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "-"
        '
        'Label6
        '
        Me.Label6.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(246, 57)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(238, 13)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "-"
        '
        'frmNetMagazin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(749, 549)
        Me.Controls.Add(Me.SplitContainer1)
        Me.Name = "frmNetMagazin"
        Me.Text = "Кабельные журналы"
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        Me.SplitContainer1.ResumeLayout(False)
        Me.gbTree.ResumeLayout(False)
        Me.TableLayoutPanel3.ResumeLayout(False)
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        Me.gbRem.ResumeLayout(False)
        Me.tsPanNetMag.ResumeLayout(False)
        Me.tsPanNetMag.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.TableLayoutPanel2.ResumeLayout(False)
        Me.TableLayoutPanel2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents gbTree As System.Windows.Forms.GroupBox
    Friend WithEvents TableLayoutPanel3 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents treebranche As System.Windows.Forms.ComboBox
    Friend WithEvents lstGroups As System.Windows.Forms.TreeView
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents gbRem As System.Windows.Forms.GroupBox
    Friend WithEvents lvNetMagazin As System.Windows.Forms.ListView
    Friend WithEvents tsPanNetMag As System.Windows.Forms.ToolStrip
    Friend WithEvents tsbAdd As System.Windows.Forms.ToolStripButton
    Friend WithEvents tsbDel As System.Windows.Forms.ToolStripButton
    Friend WithEvents tsbExcell As System.Windows.Forms.ToolStripButton
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents TableLayoutPanel2 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
End Class
