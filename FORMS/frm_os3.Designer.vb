<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_os3
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
        Me.Label1 = New System.Windows.Forms.Label
        Me.txtActNumber = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.dtVip = New System.Windows.Forms.DateTimePicker
        Me.Label3 = New System.Windows.Forms.Label
        Me.cmbCPL = New System.Windows.Forms.ComboBox
        Me.cmbModCPL = New System.Windows.Forms.ComboBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.txtYearPubl = New System.Windows.Forms.TextBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.dtPOST = New System.Windows.Forms.DateTimePicker
        Me.Label6 = New System.Windows.Forms.Label
        Me.txtBalCashe = New System.Windows.Forms.TextBox
        Me.Label7 = New System.Windows.Forms.Label
        Me.txtKolRem = New System.Windows.Forms.TextBox
        Me.Label8 = New System.Windows.Forms.Label
        Me.dtPosKapRem = New System.Windows.Forms.DateTimePicker
        Me.Label9 = New System.Windows.Forms.Label
        Me.Label10 = New System.Windows.Forms.Label
        Me.txtDef = New System.Windows.Forms.TextBox
        Me.Button1 = New System.Windows.Forms.Button
        Me.Button2 = New System.Windows.Forms.Button
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(9, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(67, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Номер акта"
        '
        'txtActNumber
        '
        Me.txtActNumber.Location = New System.Drawing.Point(112, 6)
        Me.txtActNumber.Name = "txtActNumber"
        Me.txtActNumber.Size = New System.Drawing.Size(207, 20)
        Me.txtActNumber.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(9, 36)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(80, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Дата выписки"
        '
        'dtVip
        '
        Me.dtVip.Location = New System.Drawing.Point(112, 32)
        Me.dtVip.Name = "dtVip"
        Me.dtVip.Size = New System.Drawing.Size(207, 20)
        Me.dtVip.TabIndex = 3
        Me.dtVip.Value = New Date(2010, 4, 5, 0, 0, 0, 0)
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(9, 64)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(91, 13)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Комплектующая"
        '
        'cmbCPL
        '
        Me.cmbCPL.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
        Me.cmbCPL.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmbCPL.FormattingEnabled = True
        Me.cmbCPL.Location = New System.Drawing.Point(112, 56)
        Me.cmbCPL.Name = "cmbCPL"
        Me.cmbCPL.Size = New System.Drawing.Size(207, 21)
        Me.cmbCPL.TabIndex = 5
        '
        'cmbModCPL
        '
        Me.cmbModCPL.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
        Me.cmbModCPL.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmbModCPL.FormattingEnabled = True
        Me.cmbModCPL.Location = New System.Drawing.Point(112, 83)
        Me.cmbModCPL.Name = "cmbModCPL"
        Me.cmbModCPL.Size = New System.Drawing.Size(207, 21)
        Me.cmbModCPL.TabIndex = 7
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(9, 91)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(46, 13)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Модель"
        '
        'txtYearPubl
        '
        Me.txtYearPubl.Location = New System.Drawing.Point(112, 110)
        Me.txtYearPubl.Name = "txtYearPubl"
        Me.txtYearPubl.Size = New System.Drawing.Size(207, 20)
        Me.txtYearPubl.TabIndex = 9
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(9, 113)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(98, 13)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "Год изготовления"
        '
        'dtPOST
        '
        Me.dtPOST.Location = New System.Drawing.Point(112, 136)
        Me.dtPOST.Name = "dtPOST"
        Me.dtPOST.Size = New System.Drawing.Size(207, 20)
        Me.dtPOST.TabIndex = 11
        Me.dtPOST.Value = New Date(2010, 4, 5, 0, 0, 0, 0)
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(9, 140)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(100, 13)
        Me.Label6.TabIndex = 10
        Me.Label6.Text = "Дата поступления"
        '
        'txtBalCashe
        '
        Me.txtBalCashe.Location = New System.Drawing.Point(140, 162)
        Me.txtBalCashe.Name = "txtBalCashe"
        Me.txtBalCashe.Size = New System.Drawing.Size(179, 20)
        Me.txtBalCashe.TabIndex = 13
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(9, 165)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(125, 13)
        Me.Label7.TabIndex = 12
        Me.Label7.Text = "Балансовая стоимость"
        '
        'txtKolRem
        '
        Me.txtKolRem.Location = New System.Drawing.Point(160, 188)
        Me.txtKolRem.Name = "txtKolRem"
        Me.txtKolRem.Size = New System.Drawing.Size(159, 20)
        Me.txtKolRem.TabIndex = 15
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(9, 191)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(145, 13)
        Me.Label8.TabIndex = 14
        Me.Label8.Text = "Колличество кап.ремонтов"
        '
        'dtPosKapRem
        '
        Me.dtPosKapRem.Location = New System.Drawing.Point(177, 214)
        Me.dtPosKapRem.Name = "dtPosKapRem"
        Me.dtPosKapRem.Size = New System.Drawing.Size(142, 20)
        Me.dtPosKapRem.TabIndex = 17
        Me.dtPosKapRem.Value = New Date(2010, 4, 5, 0, 0, 0, 0)
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(9, 218)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(162, 13)
        Me.Label9.TabIndex = 16
        Me.Label9.Text = "Дата последнего кап.ремонта"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(12, 248)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(55, 13)
        Me.Label10.TabIndex = 18
        Me.Label10.Text = "Дефекты"
        '
        'txtDef
        '
        Me.txtDef.Location = New System.Drawing.Point(15, 264)
        Me.txtDef.Multiline = True
        Me.txtDef.Name = "txtDef"
        Me.txtDef.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtDef.Size = New System.Drawing.Size(304, 94)
        Me.txtDef.TabIndex = 19
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(15, 374)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 20
        Me.Button1.Text = "Списать"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(112, 374)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 21
        Me.Button2.Text = "Отмена"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'frm_os3
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(331, 403)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.txtDef)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.dtPosKapRem)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.txtKolRem)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.txtBalCashe)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.dtPOST)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txtYearPubl)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.cmbModCPL)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.cmbCPL)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.dtVip)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtActNumber)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "frm_os3"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Данные для списания"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtActNumber As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents dtVip As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents cmbCPL As System.Windows.Forms.ComboBox
    Friend WithEvents cmbModCPL As System.Windows.Forms.ComboBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtYearPubl As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents dtPOST As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtBalCashe As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtKolRem As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents dtPosKapRem As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents txtDef As System.Windows.Forms.TextBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
End Class
