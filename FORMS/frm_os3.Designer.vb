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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtActNumber = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.dtVip = New System.Windows.Forms.DateTimePicker()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cmbCPL = New System.Windows.Forms.ComboBox()
        Me.cmbModCPL = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtYearPubl = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.dtPOST = New System.Windows.Forms.DateTimePicker()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtBalCashe = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtKolRem = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.dtPosKapRem = New System.Windows.Forms.DateTimePicker()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtDef = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(3, 6)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(173, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Номер акта"
        '
        'txtActNumber
        '
        Me.txtActNumber.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtActNumber.Location = New System.Drawing.Point(182, 3)
        Me.txtActNumber.Name = "txtActNumber"
        Me.txtActNumber.Size = New System.Drawing.Size(182, 20)
        Me.txtActNumber.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(3, 32)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(173, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Дата выписки"
        '
        'dtVip
        '
        Me.dtVip.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dtVip.Location = New System.Drawing.Point(182, 29)
        Me.dtVip.Name = "dtVip"
        Me.dtVip.Size = New System.Drawing.Size(182, 20)
        Me.dtVip.TabIndex = 3
        Me.dtVip.Value = New Date(2010, 4, 5, 0, 0, 0, 0)
        '
        'Label3
        '
        Me.Label3.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(3, 59)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(173, 13)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Комплектующая"
        '
        'cmbCPL
        '
        Me.cmbCPL.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
        Me.cmbCPL.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmbCPL.Dock = System.Windows.Forms.DockStyle.Fill
        Me.cmbCPL.FormattingEnabled = True
        Me.cmbCPL.Location = New System.Drawing.Point(182, 55)
        Me.cmbCPL.Name = "cmbCPL"
        Me.cmbCPL.Size = New System.Drawing.Size(182, 21)
        Me.cmbCPL.TabIndex = 5
        '
        'cmbModCPL
        '
        Me.cmbModCPL.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
        Me.cmbModCPL.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmbModCPL.Dock = System.Windows.Forms.DockStyle.Fill
        Me.cmbModCPL.FormattingEnabled = True
        Me.cmbModCPL.Location = New System.Drawing.Point(182, 82)
        Me.cmbModCPL.Name = "cmbModCPL"
        Me.cmbModCPL.Size = New System.Drawing.Size(182, 21)
        Me.cmbModCPL.TabIndex = 7
        '
        'Label4
        '
        Me.Label4.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(3, 86)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(173, 13)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Модель"
        '
        'txtYearPubl
        '
        Me.txtYearPubl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtYearPubl.Location = New System.Drawing.Point(182, 109)
        Me.txtYearPubl.Name = "txtYearPubl"
        Me.txtYearPubl.Size = New System.Drawing.Size(182, 20)
        Me.txtYearPubl.TabIndex = 9
        '
        'Label5
        '
        Me.Label5.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(3, 112)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(173, 13)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "Год изготовления"
        '
        'dtPOST
        '
        Me.dtPOST.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dtPOST.Location = New System.Drawing.Point(182, 135)
        Me.dtPOST.Name = "dtPOST"
        Me.dtPOST.Size = New System.Drawing.Size(182, 20)
        Me.dtPOST.TabIndex = 11
        Me.dtPOST.Value = New Date(2010, 4, 5, 0, 0, 0, 0)
        '
        'Label6
        '
        Me.Label6.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(3, 138)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(173, 13)
        Me.Label6.TabIndex = 10
        Me.Label6.Text = "Дата поступления"
        '
        'txtBalCashe
        '
        Me.txtBalCashe.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtBalCashe.Location = New System.Drawing.Point(182, 161)
        Me.txtBalCashe.Name = "txtBalCashe"
        Me.txtBalCashe.Size = New System.Drawing.Size(182, 20)
        Me.txtBalCashe.TabIndex = 13
        '
        'Label7
        '
        Me.Label7.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(3, 164)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(173, 13)
        Me.Label7.TabIndex = 12
        Me.Label7.Text = "Балансовая стоимость"
        '
        'txtKolRem
        '
        Me.txtKolRem.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtKolRem.Location = New System.Drawing.Point(182, 187)
        Me.txtKolRem.Name = "txtKolRem"
        Me.txtKolRem.Size = New System.Drawing.Size(182, 20)
        Me.txtKolRem.TabIndex = 15
        '
        'Label8
        '
        Me.Label8.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(3, 190)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(173, 13)
        Me.Label8.TabIndex = 14
        Me.Label8.Text = "Колличество кап.ремонтов"
        '
        'dtPosKapRem
        '
        Me.dtPosKapRem.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dtPosKapRem.Location = New System.Drawing.Point(182, 213)
        Me.dtPosKapRem.Name = "dtPosKapRem"
        Me.dtPosKapRem.Size = New System.Drawing.Size(182, 20)
        Me.dtPosKapRem.TabIndex = 17
        Me.dtPosKapRem.Value = New Date(2010, 4, 5, 0, 0, 0, 0)
        '
        'Label9
        '
        Me.Label9.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(3, 216)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(173, 13)
        Me.Label9.TabIndex = 16
        Me.Label9.Text = "Дата последнего кап.ремонта"
        '
        'Label10
        '
        Me.Label10.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(3, 236)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(173, 13)
        Me.Label10.TabIndex = 18
        Me.Label10.Text = "Дефекты"
        '
        'txtDef
        '
        Me.TableLayoutPanel1.SetColumnSpan(Me.txtDef, 2)
        Me.txtDef.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtDef.Location = New System.Drawing.Point(3, 252)
        Me.txtDef.Multiline = True
        Me.txtDef.Name = "txtDef"
        Me.txtDef.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtDef.Size = New System.Drawing.Size(361, 94)
        Me.txtDef.TabIndex = 19
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(3, 352)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 20
        Me.Button1.Text = "Списать"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.Button2.Location = New System.Drawing.Point(289, 355)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 21
        Me.Button2.Text = "Отмена"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 48.86364!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 51.13636!))
        Me.TableLayoutPanel1.Controls.Add(Me.Label1, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Button2, 1, 11)
        Me.TableLayoutPanel1.Controls.Add(Me.txtActNumber, 1, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Button1, 0, 11)
        Me.TableLayoutPanel1.Controls.Add(Me.Label2, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.txtDef, 0, 10)
        Me.TableLayoutPanel1.Controls.Add(Me.dtVip, 1, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.Label3, 0, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.dtPosKapRem, 1, 8)
        Me.TableLayoutPanel1.Controls.Add(Me.cmbCPL, 1, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.Label9, 0, 8)
        Me.TableLayoutPanel1.Controls.Add(Me.Label4, 0, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.txtKolRem, 1, 7)
        Me.TableLayoutPanel1.Controls.Add(Me.cmbModCPL, 1, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.Label8, 0, 7)
        Me.TableLayoutPanel1.Controls.Add(Me.Label5, 0, 4)
        Me.TableLayoutPanel1.Controls.Add(Me.txtBalCashe, 1, 6)
        Me.TableLayoutPanel1.Controls.Add(Me.txtYearPubl, 1, 4)
        Me.TableLayoutPanel1.Controls.Add(Me.Label7, 0, 6)
        Me.TableLayoutPanel1.Controls.Add(Me.Label6, 0, 5)
        Me.TableLayoutPanel1.Controls.Add(Me.dtPOST, 1, 5)
        Me.TableLayoutPanel1.Controls.Add(Me.Label10, 0, 9)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 12
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(367, 384)
        Me.TableLayoutPanel1.TabIndex = 22
        '
        'frm_os3
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(367, 384)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "frm_os3"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Данные для списания"
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        Me.ResumeLayout(False)

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
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
End Class
