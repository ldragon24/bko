<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmACT_OS_Act_treb
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
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txt_akt_nomer = New System.Windows.Forms.TextBox()
        Me.txt_akt_tip = New System.Windows.Forms.ComboBox()
        Me.txt_akt_mod = New System.Windows.Forms.TextBox()
        Me.txt_akt_cena = New System.Windows.Forms.NumericUpDown()
        Me.txt_akt_nomer_prikaza = New System.Windows.Forms.TextBox()
        Me.txt_akt_data_prikaza = New System.Windows.Forms.DateTimePicker()
        Me.txt_akt_postavshik = New System.Windows.Forms.ComboBox()
        Me.txt_akt_god_vipuska = New System.Windows.Forms.TextBox()
        Me.txt_akt_data_sostav = New System.Windows.Forms.DateTimePicker()
        Me.akt_add = New System.Windows.Forms.Button()
        Me.akt_cancel = New System.Windows.Forms.Button()
        Me.TableLayoutPanel1.SuspendLayout()
        CType(Me.txt_akt_cena, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.Label1, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Label2, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.Label3, 0, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.Label4, 0, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.Label5, 0, 4)
        Me.TableLayoutPanel1.Controls.Add(Me.Label6, 0, 5)
        Me.TableLayoutPanel1.Controls.Add(Me.Label7, 0, 6)
        Me.TableLayoutPanel1.Controls.Add(Me.Label8, 0, 7)
        Me.TableLayoutPanel1.Controls.Add(Me.Label9, 0, 8)
        Me.TableLayoutPanel1.Controls.Add(Me.txt_akt_nomer, 1, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.txt_akt_tip, 1, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.txt_akt_mod, 1, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.txt_akt_cena, 1, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.txt_akt_nomer_prikaza, 1, 4)
        Me.TableLayoutPanel1.Controls.Add(Me.txt_akt_data_prikaza, 1, 5)
        Me.TableLayoutPanel1.Controls.Add(Me.txt_akt_postavshik, 1, 6)
        Me.TableLayoutPanel1.Controls.Add(Me.txt_akt_god_vipuska, 1, 7)
        Me.TableLayoutPanel1.Controls.Add(Me.txt_akt_data_sostav, 1, 8)
        Me.TableLayoutPanel1.Controls.Add(Me.akt_add, 0, 9)
        Me.TableLayoutPanel1.Controls.Add(Me.akt_cancel, 1, 9)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 10
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 26.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 26.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 26.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 26.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 26.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 26.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 26.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 26.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 26.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 36.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(503, 287)
        Me.TableLayoutPanel1.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(3, 6)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(67, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Номер акта"
        '
        'Label2
        '
        Me.Label2.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(3, 32)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(122, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Тип основных средств"
        '
        'Label3
        '
        Me.Label3.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(3, 58)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(132, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Модель комплектующей"
        '
        'Label4
        '
        Me.Label4.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(3, 84)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(33, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Цена"
        '
        'Label5
        '
        Me.Label5.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(3, 110)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(86, 13)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Номер приказа"
        '
        'Label6
        '
        Me.Label6.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(3, 136)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(78, 13)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Дата приказа"
        '
        'Label7
        '
        Me.Label7.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(3, 162)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(65, 13)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = "Поставщик"
        '
        'Label8
        '
        Me.Label8.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(3, 188)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(71, 13)
        Me.Label8.TabIndex = 7
        Me.Label8.Text = "Год выпуска"
        '
        'Label9
        '
        Me.Label9.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(3, 214)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(101, 13)
        Me.Label9.TabIndex = 8
        Me.Label9.Text = "Дата составления"
        '
        'txt_akt_nomer
        '
        Me.txt_akt_nomer.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txt_akt_nomer.Location = New System.Drawing.Point(141, 3)
        Me.txt_akt_nomer.Name = "txt_akt_nomer"
        Me.txt_akt_nomer.Size = New System.Drawing.Size(359, 20)
        Me.txt_akt_nomer.TabIndex = 9
        '
        'txt_akt_tip
        '
        Me.txt_akt_tip.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txt_akt_tip.FormattingEnabled = True
        Me.txt_akt_tip.Location = New System.Drawing.Point(141, 29)
        Me.txt_akt_tip.Name = "txt_akt_tip"
        Me.txt_akt_tip.Size = New System.Drawing.Size(359, 21)
        Me.txt_akt_tip.TabIndex = 10
        '
        'txt_akt_mod
        '
        Me.txt_akt_mod.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txt_akt_mod.Location = New System.Drawing.Point(141, 55)
        Me.txt_akt_mod.Name = "txt_akt_mod"
        Me.txt_akt_mod.Size = New System.Drawing.Size(359, 20)
        Me.txt_akt_mod.TabIndex = 11
        '
        'txt_akt_cena
        '
        Me.txt_akt_cena.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txt_akt_cena.Location = New System.Drawing.Point(141, 81)
        Me.txt_akt_cena.Maximum = New Decimal(New Integer() {1000000, 0, 0, 0})
        Me.txt_akt_cena.Name = "txt_akt_cena"
        Me.txt_akt_cena.Size = New System.Drawing.Size(359, 20)
        Me.txt_akt_cena.TabIndex = 12
        '
        'txt_akt_nomer_prikaza
        '
        Me.txt_akt_nomer_prikaza.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txt_akt_nomer_prikaza.Location = New System.Drawing.Point(141, 107)
        Me.txt_akt_nomer_prikaza.Name = "txt_akt_nomer_prikaza"
        Me.txt_akt_nomer_prikaza.Size = New System.Drawing.Size(359, 20)
        Me.txt_akt_nomer_prikaza.TabIndex = 13
        '
        'txt_akt_data_prikaza
        '
        Me.txt_akt_data_prikaza.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txt_akt_data_prikaza.Location = New System.Drawing.Point(141, 133)
        Me.txt_akt_data_prikaza.Name = "txt_akt_data_prikaza"
        Me.txt_akt_data_prikaza.Size = New System.Drawing.Size(359, 20)
        Me.txt_akt_data_prikaza.TabIndex = 14
        Me.txt_akt_data_prikaza.Value = New Date(2010, 5, 20, 0, 0, 0, 0)
        '
        'txt_akt_postavshik
        '
        Me.txt_akt_postavshik.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txt_akt_postavshik.FormattingEnabled = True
        Me.txt_akt_postavshik.Location = New System.Drawing.Point(141, 159)
        Me.txt_akt_postavshik.Name = "txt_akt_postavshik"
        Me.txt_akt_postavshik.Size = New System.Drawing.Size(359, 21)
        Me.txt_akt_postavshik.TabIndex = 15
        '
        'txt_akt_god_vipuska
        '
        Me.txt_akt_god_vipuska.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txt_akt_god_vipuska.Location = New System.Drawing.Point(141, 185)
        Me.txt_akt_god_vipuska.Name = "txt_akt_god_vipuska"
        Me.txt_akt_god_vipuska.Size = New System.Drawing.Size(359, 20)
        Me.txt_akt_god_vipuska.TabIndex = 16
        '
        'txt_akt_data_sostav
        '
        Me.txt_akt_data_sostav.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txt_akt_data_sostav.Location = New System.Drawing.Point(141, 211)
        Me.txt_akt_data_sostav.Name = "txt_akt_data_sostav"
        Me.txt_akt_data_sostav.Size = New System.Drawing.Size(359, 20)
        Me.txt_akt_data_sostav.TabIndex = 17
        Me.txt_akt_data_sostav.Value = New Date(2010, 5, 20, 0, 0, 0, 0)
        '
        'akt_add
        '
        Me.akt_add.Location = New System.Drawing.Point(3, 237)
        Me.akt_add.Name = "akt_add"
        Me.akt_add.Size = New System.Drawing.Size(75, 23)
        Me.akt_add.TabIndex = 18
        Me.akt_add.Text = "Добавить"
        Me.akt_add.UseVisualStyleBackColor = True
        '
        'akt_cancel
        '
        Me.akt_cancel.Location = New System.Drawing.Point(141, 237)
        Me.akt_cancel.Name = "akt_cancel"
        Me.akt_cancel.Size = New System.Drawing.Size(75, 23)
        Me.akt_cancel.TabIndex = 19
        Me.akt_cancel.Text = "Отмена"
        Me.akt_cancel.UseVisualStyleBackColor = True
        '
        'frmACT_OS_Act_treb
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(503, 287)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "frmACT_OS_Act_treb"
        Me.Text = "Данные для Акта ввода ОС"
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        CType(Me.txt_akt_cena, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents txt_akt_nomer As System.Windows.Forms.TextBox
    Friend WithEvents txt_akt_tip As System.Windows.Forms.ComboBox
    Friend WithEvents txt_akt_mod As System.Windows.Forms.TextBox
    Friend WithEvents txt_akt_cena As System.Windows.Forms.NumericUpDown
    Friend WithEvents txt_akt_nomer_prikaza As System.Windows.Forms.TextBox
    Friend WithEvents txt_akt_data_prikaza As System.Windows.Forms.DateTimePicker
    Friend WithEvents txt_akt_postavshik As System.Windows.Forms.ComboBox
    Friend WithEvents txt_akt_god_vipuska As System.Windows.Forms.TextBox
    Friend WithEvents txt_akt_data_sostav As System.Windows.Forms.DateTimePicker
    Friend WithEvents akt_add As System.Windows.Forms.Button
    Friend WithEvents akt_cancel As System.Windows.Forms.Button
End Class
