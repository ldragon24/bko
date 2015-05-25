<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmGarCPL
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
        Me.gbcpu = New System.Windows.Forms.GroupBox()
        Me.PROizV2 = New System.Windows.Forms.ComboBox()
        Me.txtSoc4 = New System.Windows.Forms.TextBox()
        Me.PROizV4 = New System.Windows.Forms.ComboBox()
        Me.txtMHZ4 = New System.Windows.Forms.TextBox()
        Me.cmbCPU4 = New System.Windows.Forms.ComboBox()
        Me.txtSoc3 = New System.Windows.Forms.TextBox()
        Me.PROizV3 = New System.Windows.Forms.ComboBox()
        Me.txtMHZ3 = New System.Windows.Forms.TextBox()
        Me.cmbCPU3 = New System.Windows.Forms.ComboBox()
        Me.txtSoc2 = New System.Windows.Forms.TextBox()
        Me.txtMHZ2 = New System.Windows.Forms.TextBox()
        Me.cmbCPU2 = New System.Windows.Forms.ComboBox()
        Me.txtSoc1 = New System.Windows.Forms.TextBox()
        Me.PROizV1 = New System.Windows.Forms.ComboBox()
        Me.txtMHZ1 = New System.Windows.Forms.TextBox()
        Me.cmbCPU1 = New System.Windows.Forms.ComboBox()
        Me.gbPost = New System.Windows.Forms.GroupBox()
        Me.DOG = New System.Windows.Forms.DateTimePicker()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DNG = New System.Windows.Forms.DateTimePicker()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cmbPostav = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.gbcpu.SuspendLayout()
        Me.gbPost.SuspendLayout()
        Me.SuspendLayout()
        '
        'gbcpu
        '
        Me.gbcpu.AutoSize = True
        Me.gbcpu.Controls.Add(Me.PROizV2)
        Me.gbcpu.Controls.Add(Me.txtSoc4)
        Me.gbcpu.Controls.Add(Me.PROizV4)
        Me.gbcpu.Controls.Add(Me.txtMHZ4)
        Me.gbcpu.Controls.Add(Me.cmbCPU4)
        Me.gbcpu.Controls.Add(Me.txtSoc3)
        Me.gbcpu.Controls.Add(Me.PROizV3)
        Me.gbcpu.Controls.Add(Me.txtMHZ3)
        Me.gbcpu.Controls.Add(Me.cmbCPU3)
        Me.gbcpu.Controls.Add(Me.txtSoc2)
        Me.gbcpu.Controls.Add(Me.txtMHZ2)
        Me.gbcpu.Controls.Add(Me.cmbCPU2)
        Me.gbcpu.Controls.Add(Me.txtSoc1)
        Me.gbcpu.Controls.Add(Me.PROizV1)
        Me.gbcpu.Controls.Add(Me.txtMHZ1)
        Me.gbcpu.Controls.Add(Me.cmbCPU1)
        Me.gbcpu.Location = New System.Drawing.Point(2, 2)
        Me.gbcpu.Name = "gbcpu"
        Me.gbcpu.Size = New System.Drawing.Size(662, 141)
        Me.gbcpu.TabIndex = 0
        Me.gbcpu.TabStop = False
        Me.gbcpu.Text = "Процессор"
        '
        'PROizV2
        '
        Me.PROizV2.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
        Me.PROizV2.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.PROizV2.BackColor = System.Drawing.SystemColors.Window
        Me.PROizV2.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.PROizV2.ForeColor = System.Drawing.SystemColors.WindowText
        Me.PROizV2.Location = New System.Drawing.Point(527, 48)
        Me.PROizV2.Name = "PROizV2"
        Me.PROizV2.Size = New System.Drawing.Size(121, 21)
        Me.PROizV2.Sorted = True
        Me.PROizV2.TabIndex = 7
        '
        'txtSoc4
        '
        Me.txtSoc4.Location = New System.Drawing.Point(422, 100)
        Me.txtSoc4.Name = "txtSoc4"
        Me.txtSoc4.Size = New System.Drawing.Size(100, 20)
        Me.txtSoc4.TabIndex = 14
        '
        'PROizV4
        '
        Me.PROizV4.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
        Me.PROizV4.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.PROizV4.FormattingEnabled = True
        Me.PROizV4.Location = New System.Drawing.Point(527, 100)
        Me.PROizV4.Name = "PROizV4"
        Me.PROizV4.Size = New System.Drawing.Size(122, 21)
        Me.PROizV4.TabIndex = 15
        '
        'txtMHZ4
        '
        Me.txtMHZ4.Location = New System.Drawing.Point(316, 100)
        Me.txtMHZ4.Name = "txtMHZ4"
        Me.txtMHZ4.Size = New System.Drawing.Size(100, 20)
        Me.txtMHZ4.TabIndex = 13
        '
        'cmbCPU4
        '
        Me.cmbCPU4.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
        Me.cmbCPU4.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmbCPU4.FormattingEnabled = True
        Me.cmbCPU4.Location = New System.Drawing.Point(6, 101)
        Me.cmbCPU4.Name = "cmbCPU4"
        Me.cmbCPU4.Size = New System.Drawing.Size(304, 21)
        Me.cmbCPU4.TabIndex = 12
        '
        'txtSoc3
        '
        Me.txtSoc3.Location = New System.Drawing.Point(422, 73)
        Me.txtSoc3.Name = "txtSoc3"
        Me.txtSoc3.Size = New System.Drawing.Size(100, 20)
        Me.txtSoc3.TabIndex = 10
        '
        'PROizV3
        '
        Me.PROizV3.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
        Me.PROizV3.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.PROizV3.FormattingEnabled = True
        Me.PROizV3.Location = New System.Drawing.Point(527, 73)
        Me.PROizV3.Name = "PROizV3"
        Me.PROizV3.Size = New System.Drawing.Size(122, 21)
        Me.PROizV3.TabIndex = 11
        '
        'txtMHZ3
        '
        Me.txtMHZ3.Location = New System.Drawing.Point(316, 73)
        Me.txtMHZ3.Name = "txtMHZ3"
        Me.txtMHZ3.Size = New System.Drawing.Size(100, 20)
        Me.txtMHZ3.TabIndex = 9
        '
        'cmbCPU3
        '
        Me.cmbCPU3.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
        Me.cmbCPU3.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmbCPU3.FormattingEnabled = True
        Me.cmbCPU3.Location = New System.Drawing.Point(6, 74)
        Me.cmbCPU3.Name = "cmbCPU3"
        Me.cmbCPU3.Size = New System.Drawing.Size(304, 21)
        Me.cmbCPU3.TabIndex = 8
        '
        'txtSoc2
        '
        Me.txtSoc2.Location = New System.Drawing.Point(422, 48)
        Me.txtSoc2.Name = "txtSoc2"
        Me.txtSoc2.Size = New System.Drawing.Size(100, 20)
        Me.txtSoc2.TabIndex = 6
        '
        'txtMHZ2
        '
        Me.txtMHZ2.Location = New System.Drawing.Point(316, 48)
        Me.txtMHZ2.Name = "txtMHZ2"
        Me.txtMHZ2.Size = New System.Drawing.Size(100, 20)
        Me.txtMHZ2.TabIndex = 5
        '
        'cmbCPU2
        '
        Me.cmbCPU2.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
        Me.cmbCPU2.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmbCPU2.FormattingEnabled = True
        Me.cmbCPU2.Location = New System.Drawing.Point(6, 47)
        Me.cmbCPU2.Name = "cmbCPU2"
        Me.cmbCPU2.Size = New System.Drawing.Size(304, 21)
        Me.cmbCPU2.TabIndex = 4
        '
        'txtSoc1
        '
        Me.txtSoc1.Location = New System.Drawing.Point(422, 22)
        Me.txtSoc1.Name = "txtSoc1"
        Me.txtSoc1.Size = New System.Drawing.Size(100, 20)
        Me.txtSoc1.TabIndex = 2
        '
        'PROizV1
        '
        Me.PROizV1.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
        Me.PROizV1.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.PROizV1.FormattingEnabled = True
        Me.PROizV1.Location = New System.Drawing.Point(527, 22)
        Me.PROizV1.Name = "PROizV1"
        Me.PROizV1.Size = New System.Drawing.Size(121, 21)
        Me.PROizV1.TabIndex = 3
        '
        'txtMHZ1
        '
        Me.txtMHZ1.Location = New System.Drawing.Point(316, 22)
        Me.txtMHZ1.Name = "txtMHZ1"
        Me.txtMHZ1.Size = New System.Drawing.Size(100, 20)
        Me.txtMHZ1.TabIndex = 1
        '
        'cmbCPU1
        '
        Me.cmbCPU1.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
        Me.cmbCPU1.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmbCPU1.FormattingEnabled = True
        Me.cmbCPU1.Location = New System.Drawing.Point(6, 20)
        Me.cmbCPU1.Name = "cmbCPU1"
        Me.cmbCPU1.Size = New System.Drawing.Size(304, 21)
        Me.cmbCPU1.TabIndex = 0
        '
        'gbPost
        '
        Me.gbPost.AutoSize = True
        Me.gbPost.Controls.Add(Me.DOG)
        Me.gbPost.Controls.Add(Me.Label1)
        Me.gbPost.Controls.Add(Me.DNG)
        Me.gbPost.Controls.Add(Me.Label2)
        Me.gbPost.Controls.Add(Me.cmbPostav)
        Me.gbPost.Controls.Add(Me.Label4)
        Me.gbPost.Location = New System.Drawing.Point(3, 149)
        Me.gbPost.Name = "gbPost"
        Me.gbPost.Size = New System.Drawing.Size(661, 97)
        Me.gbPost.TabIndex = 1
        Me.gbPost.TabStop = False
        Me.gbPost.Text = "Поставщик"
        '
        'DOG
        '
        Me.DOG.Location = New System.Drawing.Point(335, 57)
        Me.DOG.Name = "DOG"
        Me.DOG.Size = New System.Drawing.Size(134, 20)
        Me.DOG.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(247, 63)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(65, 13)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Окончание:"
        '
        'DNG
        '
        Me.DNG.Location = New System.Drawing.Point(96, 58)
        Me.DNG.Name = "DNG"
        Me.DNG.Size = New System.Drawing.Size(134, 20)
        Me.DNG.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(8, 64)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(77, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Приобретено:"
        '
        'cmbPostav
        '
        Me.cmbPostav.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
        Me.cmbPostav.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmbPostav.FormattingEnabled = True
        Me.cmbPostav.Location = New System.Drawing.Point(86, 20)
        Me.cmbPostav.Name = "cmbPostav"
        Me.cmbPostav.Size = New System.Drawing.Size(562, 21)
        Me.cmbPostav.TabIndex = 0
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(8, 28)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(57, 13)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "Продавец"
        '
        'btnAdd
        '
        Me.btnAdd.Location = New System.Drawing.Point(2, 252)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(75, 23)
        Me.btnAdd.TabIndex = 2
        Me.btnAdd.Text = "Сохранить"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'btnCancel
        '
        Me.btnCancel.Location = New System.Drawing.Point(99, 252)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(75, 23)
        Me.btnCancel.TabIndex = 3
        Me.btnCancel.Text = "Отмена"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'frmGarCPL
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(669, 280)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.gbPost)
        Me.Controls.Add(Me.gbcpu)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "frmGarCPL"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Гарантия"
        Me.gbcpu.ResumeLayout(False)
        Me.gbcpu.PerformLayout()
        Me.gbPost.ResumeLayout(False)
        Me.gbPost.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents gbcpu As System.Windows.Forms.GroupBox
    Public WithEvents PROizV2 As System.Windows.Forms.ComboBox
    Friend WithEvents txtSoc4 As System.Windows.Forms.TextBox
    Friend WithEvents PROizV4 As System.Windows.Forms.ComboBox
    Friend WithEvents txtMHZ4 As System.Windows.Forms.TextBox
    Friend WithEvents cmbCPU4 As System.Windows.Forms.ComboBox
    Friend WithEvents txtSoc3 As System.Windows.Forms.TextBox
    Friend WithEvents PROizV3 As System.Windows.Forms.ComboBox
    Friend WithEvents txtMHZ3 As System.Windows.Forms.TextBox
    Friend WithEvents cmbCPU3 As System.Windows.Forms.ComboBox
    Friend WithEvents txtSoc2 As System.Windows.Forms.TextBox
    Friend WithEvents txtMHZ2 As System.Windows.Forms.TextBox
    Friend WithEvents cmbCPU2 As System.Windows.Forms.ComboBox
    Friend WithEvents txtSoc1 As System.Windows.Forms.TextBox
    Friend WithEvents PROizV1 As System.Windows.Forms.ComboBox
    Friend WithEvents txtMHZ1 As System.Windows.Forms.TextBox
    Friend WithEvents cmbCPU1 As System.Windows.Forms.ComboBox
    Friend WithEvents gbPost As System.Windows.Forms.GroupBox
    Friend WithEvents DOG As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents DNG As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents cmbPostav As System.Windows.Forms.ComboBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents btnAdd As System.Windows.Forms.Button
    Friend WithEvents btnCancel As System.Windows.Forms.Button
End Class
