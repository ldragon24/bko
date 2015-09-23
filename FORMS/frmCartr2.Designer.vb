<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCartr2
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmCartr2))
        Me.LabelProductName = New System.Windows.Forms.Label
        Me.TableLayoutPanel = New System.Windows.Forms.TableLayoutPanel
        Me.LogoPictureBox = New System.Windows.Forms.PictureBox
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel
        Me.gbTree = New System.Windows.Forms.GroupBox
        Me.lstGroups = New System.Windows.Forms.TreeView
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.chkAll = New System.Windows.Forms.CheckBox
        Me.lblSum2 = New System.Windows.Forms.Label
        Me.txtMonth = New System.Windows.Forms.NumericUpDown
        Me.lblSum = New System.Windows.Forms.Label
        Me.btnCartDel = New System.Windows.Forms.Button
        Me.btnCartAdd = New System.Windows.Forms.Button
        Me.LVCart = New System.Windows.Forms.ListView
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.btnZapReport = New System.Windows.Forms.Button
        Me.btnZapDel = New System.Windows.Forms.Button
        Me.btnZapAdd = New System.Windows.Forms.Button
        Me.lvCartZAP = New System.Windows.Forms.ListView
        Me.TableLayoutPanel.SuspendLayout()
        CType(Me.LogoPictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.gbTree.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.txtMonth, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'LabelProductName
        '
        Me.LabelProductName.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LabelProductName.Location = New System.Drawing.Point(358, 0)
        Me.LabelProductName.Margin = New System.Windows.Forms.Padding(6, 0, 3, 0)
        Me.LabelProductName.MaximumSize = New System.Drawing.Size(0, 17)
        Me.LabelProductName.Name = "LabelProductName"
        Me.LabelProductName.Size = New System.Drawing.Size(631, 17)
        Me.LabelProductName.TabIndex = 0
        Me.LabelProductName.Text = "Имя продукта"
        Me.LabelProductName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'TableLayoutPanel
        '
        Me.TableLayoutPanel.ColumnCount = 2
        Me.TableLayoutPanel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 35.50725!))
        Me.TableLayoutPanel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 64.49275!))
        Me.TableLayoutPanel.Controls.Add(Me.LogoPictureBox, 0, 0)
        Me.TableLayoutPanel.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel.Name = "TableLayoutPanel"
        Me.TableLayoutPanel.RowCount = 1
        Me.TableLayoutPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel.Size = New System.Drawing.Size(200, 100)
        Me.TableLayoutPanel.TabIndex = 0
        '
        'LogoPictureBox
        '
        Me.LogoPictureBox.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LogoPictureBox.Image = CType(resources.GetObject("LogoPictureBox.Image"), System.Drawing.Image)
        Me.LogoPictureBox.Location = New System.Drawing.Point(3, 3)
        Me.LogoPictureBox.Name = "LogoPictureBox"
        Me.TableLayoutPanel.SetRowSpan(Me.LogoPictureBox, 6)
        Me.LogoPictureBox.Size = New System.Drawing.Size(65, 114)
        Me.LogoPictureBox.TabIndex = 0
        Me.LogoPictureBox.TabStop = False
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.AutoSize = True
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 32.05645!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 67.94355!))
        Me.TableLayoutPanel1.Controls.Add(Me.gbTree, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.GroupBox1, 1, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.GroupBox2, 1, 1)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 2
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 60.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 40.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(992, 666)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'gbTree
        '
        Me.gbTree.Controls.Add(Me.lstGroups)
        Me.gbTree.Dock = System.Windows.Forms.DockStyle.Fill
        Me.gbTree.Location = New System.Drawing.Point(3, 3)
        Me.gbTree.Name = "gbTree"
        Me.TableLayoutPanel1.SetRowSpan(Me.gbTree, 2)
        Me.gbTree.Size = New System.Drawing.Size(311, 660)
        Me.gbTree.TabIndex = 8
        Me.gbTree.TabStop = False
        Me.gbTree.Text = "Печатающие устройства"
        '
        'lstGroups
        '
        Me.lstGroups.AllowDrop = True
        Me.lstGroups.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lstGroups.FullRowSelect = True
        Me.lstGroups.HideSelection = False
        Me.lstGroups.Location = New System.Drawing.Point(3, 16)
        Me.lstGroups.Name = "lstGroups"
        Me.lstGroups.Size = New System.Drawing.Size(305, 641)
        Me.lstGroups.TabIndex = 2
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.chkAll)
        Me.GroupBox1.Controls.Add(Me.lblSum2)
        Me.GroupBox1.Controls.Add(Me.txtMonth)
        Me.GroupBox1.Controls.Add(Me.lblSum)
        Me.GroupBox1.Controls.Add(Me.btnCartDel)
        Me.GroupBox1.Controls.Add(Me.btnCartAdd)
        Me.GroupBox1.Controls.Add(Me.LVCart)
        Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox1.Location = New System.Drawing.Point(320, 3)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(669, 393)
        Me.GroupBox1.TabIndex = 9
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Картриджи"
        '
        'chkAll
        '
        Me.chkAll.AutoSize = True
        Me.chkAll.Location = New System.Drawing.Point(564, 351)
        Me.chkAll.Name = "chkAll"
        Me.chkAll.Size = New System.Drawing.Size(96, 17)
        Me.chkAll.TabIndex = 28
        Me.chkAll.Text = "Показать все"
        Me.chkAll.UseVisualStyleBackColor = True
        '
        'lblSum2
        '
        Me.lblSum2.AutoSize = True
        Me.lblSum2.Location = New System.Drawing.Point(389, 350)
        Me.lblSum2.Name = "lblSum2"
        Me.lblSum2.Size = New System.Drawing.Size(77, 13)
        Me.lblSum2.TabIndex = 27
        Me.lblSum2.Text = "месяце 0 руб."
        '
        'txtMonth
        '
        Me.txtMonth.Location = New System.Drawing.Point(333, 348)
        Me.txtMonth.Maximum = New Decimal(New Integer() {12, 0, 0, 0})
        Me.txtMonth.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.txtMonth.Name = "txtMonth"
        Me.txtMonth.Size = New System.Drawing.Size(50, 20)
        Me.txtMonth.TabIndex = 26
        Me.txtMonth.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'lblSum
        '
        Me.lblSum.AutoSize = True
        Me.lblSum.Location = New System.Drawing.Point(186, 350)
        Me.lblSum.Name = "lblSum"
        Me.lblSum.Size = New System.Drawing.Size(141, 13)
        Me.lblSum.TabIndex = 25
        Me.lblSum.Text = "Потрачено на заправку в: "
        '
        'btnCartDel
        '
        Me.btnCartDel.Location = New System.Drawing.Point(89, 345)
        Me.btnCartDel.Name = "btnCartDel"
        Me.btnCartDel.Size = New System.Drawing.Size(75, 23)
        Me.btnCartDel.TabIndex = 24
        Me.btnCartDel.Text = "Удалить"
        Me.btnCartDel.UseVisualStyleBackColor = True
        '
        'btnCartAdd
        '
        Me.btnCartAdd.Location = New System.Drawing.Point(8, 345)
        Me.btnCartAdd.Name = "btnCartAdd"
        Me.btnCartAdd.Size = New System.Drawing.Size(75, 23)
        Me.btnCartAdd.TabIndex = 23
        Me.btnCartAdd.Text = "Добавить"
        Me.btnCartAdd.UseVisualStyleBackColor = True
        '
        'LVCart
        '
        Me.LVCart.Dock = System.Windows.Forms.DockStyle.Top
        Me.LVCart.FullRowSelect = True
        Me.LVCart.GridLines = True
        Me.LVCart.Location = New System.Drawing.Point(3, 16)
        Me.LVCart.MultiSelect = False
        Me.LVCart.Name = "LVCart"
        Me.LVCart.ShowItemToolTips = True
        Me.LVCart.Size = New System.Drawing.Size(663, 325)
        Me.LVCart.TabIndex = 17
        Me.LVCart.UseCompatibleStateImageBehavior = False
        Me.LVCart.View = System.Windows.Forms.View.Details
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.btnZapReport)
        Me.GroupBox2.Controls.Add(Me.btnZapDel)
        Me.GroupBox2.Controls.Add(Me.btnZapAdd)
        Me.GroupBox2.Controls.Add(Me.lvCartZAP)
        Me.GroupBox2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox2.Location = New System.Drawing.Point(320, 402)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(669, 261)
        Me.GroupBox2.TabIndex = 10
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Заправки"
        '
        'btnZapReport
        '
        Me.btnZapReport.Location = New System.Drawing.Point(170, 210)
        Me.btnZapReport.Name = "btnZapReport"
        Me.btnZapReport.Size = New System.Drawing.Size(122, 23)
        Me.btnZapReport.TabIndex = 23
        Me.btnZapReport.Text = "Отчёт по заправкам"
        Me.btnZapReport.UseVisualStyleBackColor = True
        '
        'btnZapDel
        '
        Me.btnZapDel.Location = New System.Drawing.Point(89, 210)
        Me.btnZapDel.Name = "btnZapDel"
        Me.btnZapDel.Size = New System.Drawing.Size(75, 23)
        Me.btnZapDel.TabIndex = 22
        Me.btnZapDel.Text = "Удалить"
        Me.btnZapDel.UseVisualStyleBackColor = True
        '
        'btnZapAdd
        '
        Me.btnZapAdd.Location = New System.Drawing.Point(8, 210)
        Me.btnZapAdd.Name = "btnZapAdd"
        Me.btnZapAdd.Size = New System.Drawing.Size(75, 23)
        Me.btnZapAdd.TabIndex = 21
        Me.btnZapAdd.Text = "Добавить"
        Me.btnZapAdd.UseVisualStyleBackColor = True
        '
        'lvCartZAP
        '
        Me.lvCartZAP.Dock = System.Windows.Forms.DockStyle.Top
        Me.lvCartZAP.FullRowSelect = True
        Me.lvCartZAP.GridLines = True
        Me.lvCartZAP.Location = New System.Drawing.Point(3, 16)
        Me.lvCartZAP.MultiSelect = False
        Me.lvCartZAP.Name = "lvCartZAP"
        Me.lvCartZAP.ShowItemToolTips = True
        Me.lvCartZAP.Size = New System.Drawing.Size(663, 204)
        Me.lvCartZAP.TabIndex = 18
        Me.lvCartZAP.UseCompatibleStateImageBehavior = False
        Me.lvCartZAP.View = System.Windows.Forms.View.Details
        '
        'frmCartr2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(992, 666)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Name = "frmCartr2"
        Me.Text = "Учёт картриджей"
        Me.TableLayoutPanel.ResumeLayout(False)
        CType(Me.LogoPictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.gbTree.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.txtMonth, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents LabelProductName As System.Windows.Forms.Label
    Friend WithEvents TableLayoutPanel As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents LogoPictureBox As System.Windows.Forms.PictureBox
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents gbTree As System.Windows.Forms.GroupBox
    Friend WithEvents lstGroups As System.Windows.Forms.TreeView
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents LVCart As System.Windows.Forms.ListView
    Friend WithEvents lblSum2 As System.Windows.Forms.Label
    Friend WithEvents txtMonth As System.Windows.Forms.NumericUpDown
    Friend WithEvents lblSum As System.Windows.Forms.Label
    Friend WithEvents btnCartDel As System.Windows.Forms.Button
    Friend WithEvents btnCartAdd As System.Windows.Forms.Button
    Friend WithEvents lvCartZAP As System.Windows.Forms.ListView
    Friend WithEvents btnZapReport As System.Windows.Forms.Button
    Friend WithEvents btnZapDel As System.Windows.Forms.Button
    Friend WithEvents btnZapAdd As System.Windows.Forms.Button
    Friend WithEvents chkAll As System.Windows.Forms.CheckBox
End Class
