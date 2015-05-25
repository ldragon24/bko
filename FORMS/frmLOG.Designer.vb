<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Friend Class frmLOG
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
        Me.RBPrLog = New System.Windows.Forms.RadioButton
        Me.rbMove = New System.Windows.Forms.RadioButton
        Me.rbUpdate = New System.Windows.Forms.RadioButton
        Me.lvLOG = New System.Windows.Forms.ListView
        Me.DTLOG = New System.Windows.Forms.DateTimePicker
        Me.btnUpdate = New System.Windows.Forms.Button
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.DTLOG1 = New System.Windows.Forms.DateTimePicker
        Me.SuspendLayout()
        '
        'RBPrLog
        '
        Me.RBPrLog.AutoSize = True
        Me.RBPrLog.Location = New System.Drawing.Point(13, 13)
        Me.RBPrLog.Name = "RBPrLog"
        Me.RBPrLog.Size = New System.Drawing.Size(127, 17)
        Me.RBPrLog.TabIndex = 0
        Me.RBPrLog.Text = "Журнал программы"
        Me.RBPrLog.UseVisualStyleBackColor = True
        '
        'rbMove
        '
        Me.rbMove.AutoSize = True
        Me.rbMove.Location = New System.Drawing.Point(161, 12)
        Me.rbMove.Name = "rbMove"
        Me.rbMove.Size = New System.Drawing.Size(118, 17)
        Me.rbMove.TabIndex = 1
        Me.rbMove.Text = "Журнал движения"
        Me.rbMove.UseVisualStyleBackColor = True
        '
        'rbUpdate
        '
        Me.rbUpdate.AutoSize = True
        Me.rbUpdate.Location = New System.Drawing.Point(312, 12)
        Me.rbUpdate.Name = "rbUpdate"
        Me.rbUpdate.Size = New System.Drawing.Size(128, 17)
        Me.rbUpdate.TabIndex = 2
        Me.rbUpdate.Text = "Журнал обновления"
        Me.rbUpdate.UseVisualStyleBackColor = True
        '
        'lvLOG
        '
        Me.lvLOG.FullRowSelect = True
        Me.lvLOG.GridLines = True
        Me.lvLOG.Location = New System.Drawing.Point(3, 50)
        Me.lvLOG.MultiSelect = False
        Me.lvLOG.Name = "lvLOG"
        Me.lvLOG.ShowItemToolTips = True
        Me.lvLOG.Size = New System.Drawing.Size(977, 684)
        Me.lvLOG.TabIndex = 17
        Me.lvLOG.UseCompatibleStateImageBehavior = False
        Me.lvLOG.View = System.Windows.Forms.View.Details
        '
        'DTLOG
        '
        Me.DTLOG.Location = New System.Drawing.Point(510, 12)
        Me.DTLOG.Name = "DTLOG"
        Me.DTLOG.Size = New System.Drawing.Size(136, 20)
        Me.DTLOG.TabIndex = 18
        Me.DTLOG.Value = New Date(2010, 2, 24, 0, 0, 0, 0)
        '
        'btnUpdate
        '
        Me.btnUpdate.Location = New System.Drawing.Point(905, 13)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(75, 23)
        Me.btnUpdate.TabIndex = 19
        Me.btnUpdate.Text = "Обновить"
        Me.btnUpdate.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(485, 18)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(13, 13)
        Me.Label1.TabIndex = 20
        Me.Label1.Text = "с"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(655, 19)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(19, 13)
        Me.Label2.TabIndex = 22
        Me.Label2.Text = "по"
        '
        'DTLOG1
        '
        Me.DTLOG1.Location = New System.Drawing.Point(691, 12)
        Me.DTLOG1.Name = "DTLOG1"
        Me.DTLOG1.Size = New System.Drawing.Size(136, 20)
        Me.DTLOG1.TabIndex = 21
        Me.DTLOG1.Value = New Date(2010, 2, 24, 0, 0, 0, 0)
        '
        'frmLOG
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(992, 746)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.DTLOG1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnUpdate)
        Me.Controls.Add(Me.DTLOG)
        Me.Controls.Add(Me.lvLOG)
        Me.Controls.Add(Me.rbUpdate)
        Me.Controls.Add(Me.rbMove)
        Me.Controls.Add(Me.RBPrLog)
        Me.MinimumSize = New System.Drawing.Size(1000, 700)
        Me.Name = "frmLOG"
        Me.Text = "Журналы программы"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents RBPrLog As System.Windows.Forms.RadioButton
    Friend WithEvents rbMove As System.Windows.Forms.RadioButton
    Friend WithEvents rbUpdate As System.Windows.Forms.RadioButton
    Friend WithEvents lvLOG As System.Windows.Forms.ListView
    Friend WithEvents DTLOG As System.Windows.Forms.DateTimePicker
    Friend WithEvents btnUpdate As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents DTLOG1 As System.Windows.Forms.DateTimePicker
End Class
