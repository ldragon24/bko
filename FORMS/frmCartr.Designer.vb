<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCartr
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
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer
        Me.Label1 = New System.Windows.Forms.Label
        Me.lblSum2 = New System.Windows.Forms.Label
        Me.txtMonth = New System.Windows.Forms.NumericUpDown
        Me.lblSum = New System.Windows.Forms.Label
        Me.btnCartDel = New System.Windows.Forms.Button
        Me.btnCartAdd = New System.Windows.Forms.Button
        Me.LVCart = New System.Windows.Forms.ListView
        Me.Label2 = New System.Windows.Forms.Label
        Me.btnZapReport = New System.Windows.Forms.Button
        Me.btnZapDel = New System.Windows.Forms.Button
        Me.btnZapAdd = New System.Windows.Forms.Button
        Me.lvCartZAP = New System.Windows.Forms.ListView
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        CType(Me.txtMonth, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.SplitContainer1.Panel1.Controls.Add(Me.Label1)
        Me.SplitContainer1.Panel1.Controls.Add(Me.lblSum2)
        Me.SplitContainer1.Panel1.Controls.Add(Me.txtMonth)
        Me.SplitContainer1.Panel1.Controls.Add(Me.lblSum)
        Me.SplitContainer1.Panel1.Controls.Add(Me.btnCartDel)
        Me.SplitContainer1.Panel1.Controls.Add(Me.btnCartAdd)
        Me.SplitContainer1.Panel1.Controls.Add(Me.LVCart)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.Label2)
        Me.SplitContainer1.Panel2.Controls.Add(Me.btnZapReport)
        Me.SplitContainer1.Panel2.Controls.Add(Me.btnZapDel)
        Me.SplitContainer1.Panel2.Controls.Add(Me.btnZapAdd)
        Me.SplitContainer1.Panel2.Controls.Add(Me.lvCartZAP)
        Me.SplitContainer1.Size = New System.Drawing.Size(992, 666)
        Me.SplitContainer1.SplitterDistance = 642
        Me.SplitContainer1.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(123, 25)
        Me.Label1.TabIndex = 23
        Me.Label1.Text = "Картриджи"
        '
        'lblSum2
        '
        Me.lblSum2.AutoSize = True
        Me.lblSum2.Location = New System.Drawing.Point(393, 616)
        Me.lblSum2.Name = "lblSum2"
        Me.lblSum2.Size = New System.Drawing.Size(77, 13)
        Me.lblSum2.TabIndex = 22
        Me.lblSum2.Text = "месяце 0 руб."
        '
        'txtMonth
        '
        Me.txtMonth.Location = New System.Drawing.Point(337, 614)
        Me.txtMonth.Maximum = New Decimal(New Integer() {12, 0, 0, 0})
        Me.txtMonth.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.txtMonth.Name = "txtMonth"
        Me.txtMonth.Size = New System.Drawing.Size(50, 20)
        Me.txtMonth.TabIndex = 21
        Me.txtMonth.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'lblSum
        '
        Me.lblSum.AutoSize = True
        Me.lblSum.Location = New System.Drawing.Point(190, 616)
        Me.lblSum.Name = "lblSum"
        Me.lblSum.Size = New System.Drawing.Size(141, 13)
        Me.lblSum.TabIndex = 19
        Me.lblSum.Text = "Потрачено на заправку в: "
        '
        'btnCartDel
        '
        Me.btnCartDel.Location = New System.Drawing.Point(93, 611)
        Me.btnCartDel.Name = "btnCartDel"
        Me.btnCartDel.Size = New System.Drawing.Size(75, 23)
        Me.btnCartDel.TabIndex = 18
        Me.btnCartDel.Text = "Удалить"
        Me.btnCartDel.UseVisualStyleBackColor = True
        '
        'btnCartAdd
        '
        Me.btnCartAdd.Location = New System.Drawing.Point(12, 611)
        Me.btnCartAdd.Name = "btnCartAdd"
        Me.btnCartAdd.Size = New System.Drawing.Size(75, 23)
        Me.btnCartAdd.TabIndex = 17
        Me.btnCartAdd.Text = "Добавить"
        Me.btnCartAdd.UseVisualStyleBackColor = True
        '
        'LVCart
        '
        Me.LVCart.FullRowSelect = True
        Me.LVCart.GridLines = True
        Me.LVCart.Location = New System.Drawing.Point(0, 28)
        Me.LVCart.MultiSelect = False
        Me.LVCart.Name = "LVCart"
        Me.LVCart.ShowItemToolTips = True
        Me.LVCart.Size = New System.Drawing.Size(644, 565)
        Me.LVCart.TabIndex = 16
        Me.LVCart.UseCompatibleStateImageBehavior = False
        Me.LVCart.View = System.Windows.Forms.View.Details
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Label2.Location = New System.Drawing.Point(7, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(107, 25)
        Me.Label2.TabIndex = 24
        Me.Label2.Text = "Заправки"
        '
        'btnZapReport
        '
        Me.btnZapReport.Location = New System.Drawing.Point(174, 611)
        Me.btnZapReport.Name = "btnZapReport"
        Me.btnZapReport.Size = New System.Drawing.Size(122, 23)
        Me.btnZapReport.TabIndex = 20
        Me.btnZapReport.Text = "Отчёт по заправкам"
        Me.btnZapReport.UseVisualStyleBackColor = True
        '
        'btnZapDel
        '
        Me.btnZapDel.Location = New System.Drawing.Point(93, 611)
        Me.btnZapDel.Name = "btnZapDel"
        Me.btnZapDel.Size = New System.Drawing.Size(75, 23)
        Me.btnZapDel.TabIndex = 19
        Me.btnZapDel.Text = "Удалить"
        Me.btnZapDel.UseVisualStyleBackColor = True
        '
        'btnZapAdd
        '
        Me.btnZapAdd.Location = New System.Drawing.Point(12, 611)
        Me.btnZapAdd.Name = "btnZapAdd"
        Me.btnZapAdd.Size = New System.Drawing.Size(75, 23)
        Me.btnZapAdd.TabIndex = 18
        Me.btnZapAdd.Text = "Добавить"
        Me.btnZapAdd.UseVisualStyleBackColor = True
        '
        'lvCartZAP
        '
        Me.lvCartZAP.FullRowSelect = True
        Me.lvCartZAP.GridLines = True
        Me.lvCartZAP.Location = New System.Drawing.Point(3, 28)
        Me.lvCartZAP.MultiSelect = False
        Me.lvCartZAP.Name = "lvCartZAP"
        Me.lvCartZAP.ShowItemToolTips = True
        Me.lvCartZAP.Size = New System.Drawing.Size(323, 565)
        Me.lvCartZAP.TabIndex = 17
        Me.lvCartZAP.UseCompatibleStateImageBehavior = False
        Me.lvCartZAP.View = System.Windows.Forms.View.Details
        '
        'frmCartr
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(992, 666)
        Me.Controls.Add(Me.SplitContainer1)
        Me.MinimumSize = New System.Drawing.Size(1000, 700)
        Me.Name = "frmCartr"
        Me.Text = "Учёт картриджей"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel1.PerformLayout()
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        Me.SplitContainer1.Panel2.PerformLayout()
        Me.SplitContainer1.ResumeLayout(False)
        CType(Me.txtMonth, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents LVCart As System.Windows.Forms.ListView
    Friend WithEvents lvCartZAP As System.Windows.Forms.ListView
    Friend WithEvents btnCartDel As System.Windows.Forms.Button
    Friend WithEvents btnCartAdd As System.Windows.Forms.Button
    Friend WithEvents btnZapReport As System.Windows.Forms.Button
    Friend WithEvents btnZapDel As System.Windows.Forms.Button
    Friend WithEvents btnZapAdd As System.Windows.Forms.Button
    Friend WithEvents lblSum As System.Windows.Forms.Label
    Friend WithEvents lblSum2 As System.Windows.Forms.Label
    Friend WithEvents txtMonth As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
End Class
