<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmservice_add_otvets
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
        Me.cmbObt = New System.Windows.Forms.ComboBox()
        Me.cmbKrit = New System.Windows.Forms.ComboBox()
        Me.cmbOtv = New System.Windows.Forms.ComboBox()
        Me.cmdCancel = New System.Windows.Forms.Button()
        Me.cmbStat = New System.Windows.Forms.ComboBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.cmdAdd = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.gbExt = New System.Windows.Forms.GroupBox()
        Me.chcClose = New System.Windows.Forms.CheckBox()
        Me.txtOtzyv = New System.Windows.Forms.TextBox()
        Me.cmbMaster = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.dtPic = New System.Windows.Forms.DateTimePicker()
        Me.cmbTip = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.gbExt.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'cmbObt
        '
        Me.cmbObt.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
        Me.cmbObt.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmbObt.FormattingEnabled = True
        Me.cmbObt.Location = New System.Drawing.Point(101, 97)
        Me.cmbObt.Name = "cmbObt"
        Me.cmbObt.Size = New System.Drawing.Size(446, 21)
        Me.cmbObt.TabIndex = 9
        '
        'cmbKrit
        '
        Me.cmbKrit.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
        Me.cmbKrit.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmbKrit.FormattingEnabled = True
        Me.cmbKrit.Location = New System.Drawing.Point(101, 72)
        Me.cmbKrit.Name = "cmbKrit"
        Me.cmbKrit.Size = New System.Drawing.Size(446, 21)
        Me.cmbKrit.TabIndex = 8
        '
        'cmbOtv
        '
        Me.cmbOtv.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
        Me.cmbOtv.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmbOtv.FormattingEnabled = True
        Me.cmbOtv.Location = New System.Drawing.Point(101, 47)
        Me.cmbOtv.Name = "cmbOtv"
        Me.cmbOtv.Size = New System.Drawing.Size(446, 21)
        Me.cmbOtv.TabIndex = 7
        '
        'cmdCancel
        '
        Me.cmdCancel.Location = New System.Drawing.Point(106, 407)
        Me.cmdCancel.Name = "cmdCancel"
        Me.cmdCancel.Size = New System.Drawing.Size(75, 23)
        Me.cmdCancel.TabIndex = 11
        Me.cmdCancel.Text = "Отменить"
        Me.cmdCancel.UseVisualStyleBackColor = True
        '
        'cmbStat
        '
        Me.cmbStat.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
        Me.cmbStat.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmbStat.FormattingEnabled = True
        Me.cmbStat.Location = New System.Drawing.Point(101, 20)
        Me.cmbStat.Name = "cmbStat"
        Me.cmbStat.Size = New System.Drawing.Size(446, 21)
        Me.cmbStat.TabIndex = 6
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(7, 100)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(48, 13)
        Me.Label7.TabIndex = 5
        Me.Label7.Text = "Объект:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(6, 75)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(74, 13)
        Me.Label6.TabIndex = 4
        Me.Label6.Text = "Критичность:"
        '
        'cmdAdd
        '
        Me.cmdAdd.Location = New System.Drawing.Point(6, 407)
        Me.cmdAdd.Name = "cmdAdd"
        Me.cmdAdd.Size = New System.Drawing.Size(75, 23)
        Me.cmdAdd.TabIndex = 10
        Me.cmdAdd.Text = "Добавить"
        Me.cmdAdd.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(6, 50)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(89, 13)
        Me.Label5.TabIndex = 3
        Me.Label5.Text = "Ответственный:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(6, 23)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(44, 13)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "Статус:"
        '
        'gbExt
        '
        Me.gbExt.Controls.Add(Me.cmbObt)
        Me.gbExt.Controls.Add(Me.cmbKrit)
        Me.gbExt.Controls.Add(Me.cmbOtv)
        Me.gbExt.Controls.Add(Me.cmbStat)
        Me.gbExt.Controls.Add(Me.Label7)
        Me.gbExt.Controls.Add(Me.Label6)
        Me.gbExt.Controls.Add(Me.Label5)
        Me.gbExt.Controls.Add(Me.Label4)
        Me.gbExt.Location = New System.Drawing.Point(6, 277)
        Me.gbExt.Name = "gbExt"
        Me.gbExt.Size = New System.Drawing.Size(553, 124)
        Me.gbExt.TabIndex = 9
        Me.gbExt.TabStop = False
        Me.gbExt.Text = "Расширенный вариант"
        '
        'chcClose
        '
        Me.chcClose.AutoSize = True
        Me.chcClose.Location = New System.Drawing.Point(10, 214)
        Me.chcClose.Name = "chcClose"
        Me.chcClose.Size = New System.Drawing.Size(70, 17)
        Me.chcClose.TabIndex = 5
        Me.chcClose.Text = "Закрыта"
        Me.chcClose.UseVisualStyleBackColor = True
        '
        'txtOtzyv
        '
        Me.txtOtzyv.Location = New System.Drawing.Point(10, 64)
        Me.txtOtzyv.Multiline = True
        Me.txtOtzyv.Name = "txtOtzyv"
        Me.txtOtzyv.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtOtzyv.Size = New System.Drawing.Size(537, 143)
        Me.txtOtzyv.TabIndex = 4
        '
        'cmbMaster
        '
        Me.cmbMaster.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
        Me.cmbMaster.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmbMaster.FormattingEnabled = True
        Me.cmbMaster.Location = New System.Drawing.Point(150, 37)
        Me.cmbMaster.Name = "cmbMaster"
        Me.cmbMaster.Size = New System.Drawing.Size(397, 21)
        Me.cmbMaster.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(147, 19)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(45, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Мастер"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(16, 248)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(29, 13)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Тип:"
        '
        'dtPic
        '
        Me.dtPic.Location = New System.Drawing.Point(10, 37)
        Me.dtPic.Name = "dtPic"
        Me.dtPic.Size = New System.Drawing.Size(128, 20)
        Me.dtPic.TabIndex = 1
        '
        'cmbTip
        '
        Me.cmbTip.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
        Me.cmbTip.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmbTip.FormattingEnabled = True
        Me.cmbTip.Items.AddRange(New Object() {"Base", "Advanced"})
        Me.cmbTip.Location = New System.Drawing.Point(51, 248)
        Me.cmbTip.Name = "cmbTip"
        Me.cmbTip.Size = New System.Drawing.Size(130, 21)
        Me.cmbTip.TabIndex = 8
        Me.cmbTip.Text = "Base"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(7, 20)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(33, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Дата"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.chcClose)
        Me.GroupBox1.Controls.Add(Me.txtOtzyv)
        Me.GroupBox1.Controls.Add(Me.cmbMaster)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.dtPic)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(6, 0)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(553, 241)
        Me.GroupBox1.TabIndex = 6
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Ответ по заявке"
        '
        'frmservice_add_otvets
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(565, 430)
        Me.Controls.Add(Me.cmdCancel)
        Me.Controls.Add(Me.cmdAdd)
        Me.Controls.Add(Me.gbExt)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.cmbTip)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "frmservice_add_otvets"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Ответ на заявку"
        Me.gbExt.ResumeLayout(False)
        Me.gbExt.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cmbObt As System.Windows.Forms.ComboBox
    Friend WithEvents cmbKrit As System.Windows.Forms.ComboBox
    Friend WithEvents cmbOtv As System.Windows.Forms.ComboBox
    Friend WithEvents cmdCancel As System.Windows.Forms.Button
    Friend WithEvents cmbStat As System.Windows.Forms.ComboBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents cmdAdd As System.Windows.Forms.Button
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents gbExt As System.Windows.Forms.GroupBox
    Friend WithEvents chcClose As System.Windows.Forms.CheckBox
    Friend WithEvents txtOtzyv As System.Windows.Forms.TextBox
    Friend WithEvents cmbMaster As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents dtPic As System.Windows.Forms.DateTimePicker
    Friend WithEvents cmbTip As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
End Class
