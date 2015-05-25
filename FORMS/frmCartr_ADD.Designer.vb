<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCartr_ADD
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
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.lblRealNumber = New System.Windows.Forms.Label()
        Me.txtSerNumb = New System.Windows.Forms.TextBox()
        Me.cmbProizv = New System.Windows.Forms.ComboBox()
        Me.cmbTipC = New System.Windows.Forms.ComboBox()
        Me.cmbModC = New System.Windows.Forms.ComboBox()
        Me.cmbSostUstr = New System.Windows.Forms.ComboBox()
        Me.cmbSaler = New System.Windows.Forms.ComboBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtSaleNumb = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.dtSale = New System.Windows.Forms.DateTimePicker()
        Me.txtMemo = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.chkNezap = New System.Windows.Forms.CheckBox()
        Me.chkNZ = New System.Windows.Forms.CheckBox()
        Me.chkIznos = New System.Windows.Forms.CheckBox()
        Me.chkSPS = New System.Windows.Forms.CheckBox()
        Me.chkNaSP = New System.Windows.Forms.CheckBox()
        Me.txtCashe = New System.Windows.Forms.NumericUpDown()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        CType(Me.txtCashe, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(3, 1)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(121, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "№"
        '
        'Label2
        '
        Me.Label2.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(3, 21)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(121, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Серийный номер:"
        '
        'Label3
        '
        Me.Label3.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(3, 48)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(121, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Производитель:"
        '
        'Label4
        '
        Me.Label4.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(3, 75)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(121, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Тип картриджа:"
        '
        'Label5
        '
        Me.Label5.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(3, 102)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(121, 13)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Модель:"
        '
        'Label6
        '
        Me.Label6.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label6.AutoSize = True
        Me.Label6.Enabled = False
        Me.Label6.Location = New System.Drawing.Point(3, 129)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(121, 13)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "В составе устройства:"
        '
        'lblRealNumber
        '
        Me.lblRealNumber.AutoSize = True
        Me.lblRealNumber.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblRealNumber.Location = New System.Drawing.Point(130, 0)
        Me.lblRealNumber.Name = "lblRealNumber"
        Me.lblRealNumber.Size = New System.Drawing.Size(2, 15)
        Me.lblRealNumber.TabIndex = 6
        '
        'txtSerNumb
        '
        Me.TableLayoutPanel1.SetColumnSpan(Me.txtSerNumb, 2)
        Me.txtSerNumb.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtSerNumb.Location = New System.Drawing.Point(130, 18)
        Me.txtSerNumb.Name = "txtSerNumb"
        Me.txtSerNumb.Size = New System.Drawing.Size(270, 20)
        Me.txtSerNumb.TabIndex = 7
        '
        'cmbProizv
        '
        Me.cmbProizv.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
        Me.cmbProizv.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.TableLayoutPanel1.SetColumnSpan(Me.cmbProizv, 2)
        Me.cmbProizv.Dock = System.Windows.Forms.DockStyle.Fill
        Me.cmbProizv.FormattingEnabled = True
        Me.cmbProizv.Location = New System.Drawing.Point(130, 44)
        Me.cmbProizv.Name = "cmbProizv"
        Me.cmbProizv.Size = New System.Drawing.Size(270, 21)
        Me.cmbProizv.TabIndex = 8
        '
        'cmbTipC
        '
        Me.cmbTipC.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
        Me.cmbTipC.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.TableLayoutPanel1.SetColumnSpan(Me.cmbTipC, 2)
        Me.cmbTipC.Dock = System.Windows.Forms.DockStyle.Fill
        Me.cmbTipC.FormattingEnabled = True
        Me.cmbTipC.Location = New System.Drawing.Point(130, 71)
        Me.cmbTipC.Name = "cmbTipC"
        Me.cmbTipC.Size = New System.Drawing.Size(270, 21)
        Me.cmbTipC.TabIndex = 9
        '
        'cmbModC
        '
        Me.cmbModC.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
        Me.cmbModC.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.TableLayoutPanel1.SetColumnSpan(Me.cmbModC, 2)
        Me.cmbModC.Dock = System.Windows.Forms.DockStyle.Fill
        Me.cmbModC.FormattingEnabled = True
        Me.cmbModC.Location = New System.Drawing.Point(130, 98)
        Me.cmbModC.Name = "cmbModC"
        Me.cmbModC.Size = New System.Drawing.Size(270, 21)
        Me.cmbModC.TabIndex = 10
        '
        'cmbSostUstr
        '
        Me.cmbSostUstr.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
        Me.cmbSostUstr.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.TableLayoutPanel1.SetColumnSpan(Me.cmbSostUstr, 2)
        Me.cmbSostUstr.Dock = System.Windows.Forms.DockStyle.Fill
        Me.cmbSostUstr.Enabled = False
        Me.cmbSostUstr.FormattingEnabled = True
        Me.cmbSostUstr.Location = New System.Drawing.Point(130, 125)
        Me.cmbSostUstr.Name = "cmbSostUstr"
        Me.cmbSostUstr.Size = New System.Drawing.Size(270, 21)
        Me.cmbSostUstr.TabIndex = 11
        '
        'cmbSaler
        '
        Me.cmbSaler.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
        Me.cmbSaler.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.TableLayoutPanel1.SetColumnSpan(Me.cmbSaler, 2)
        Me.cmbSaler.Dock = System.Windows.Forms.DockStyle.Fill
        Me.cmbSaler.FormattingEnabled = True
        Me.cmbSaler.Location = New System.Drawing.Point(130, 152)
        Me.cmbSaler.Name = "cmbSaler"
        Me.cmbSaler.Size = New System.Drawing.Size(270, 21)
        Me.cmbSaler.TabIndex = 13
        '
        'Label8
        '
        Me.Label8.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(3, 156)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(121, 13)
        Me.Label8.TabIndex = 12
        Me.Label8.Text = "Продавец:"
        '
        'txtSaleNumb
        '
        Me.TableLayoutPanel1.SetColumnSpan(Me.txtSaleNumb, 2)
        Me.txtSaleNumb.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtSaleNumb.Location = New System.Drawing.Point(130, 179)
        Me.txtSaleNumb.Name = "txtSaleNumb"
        Me.txtSaleNumb.Size = New System.Drawing.Size(270, 20)
        Me.txtSaleNumb.TabIndex = 15
        '
        'Label9
        '
        Me.Label9.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(3, 182)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(121, 13)
        Me.Label9.TabIndex = 14
        Me.Label9.Text = "Счёт фактура:"
        '
        'Label10
        '
        Me.Label10.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(3, 208)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(121, 13)
        Me.Label10.TabIndex = 16
        Me.Label10.Text = "Цена:"
        '
        'Label11
        '
        Me.Label11.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(3, 234)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(121, 13)
        Me.Label11.TabIndex = 18
        Me.Label11.Text = "Дата приобретения:"
        '
        'dtSale
        '
        Me.TableLayoutPanel1.SetColumnSpan(Me.dtSale, 2)
        Me.dtSale.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dtSale.Location = New System.Drawing.Point(130, 231)
        Me.dtSale.Name = "dtSale"
        Me.dtSale.Size = New System.Drawing.Size(270, 20)
        Me.dtSale.TabIndex = 19
        Me.dtSale.Value = New Date(2010, 4, 1, 0, 0, 0, 0)
        '
        'txtMemo
        '
        Me.TableLayoutPanel1.SetColumnSpan(Me.txtMemo, 2)
        Me.txtMemo.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtMemo.Location = New System.Drawing.Point(130, 303)
        Me.txtMemo.Multiline = True
        Me.txtMemo.Name = "txtMemo"
        Me.TableLayoutPanel1.SetRowSpan(Me.txtMemo, 2)
        Me.txtMemo.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtMemo.Size = New System.Drawing.Size(270, 113)
        Me.txtMemo.TabIndex = 20
        '
        'Label7
        '
        Me.Label7.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(3, 353)
        Me.Label7.Name = "Label7"
        Me.TableLayoutPanel1.SetRowSpan(Me.Label7, 2)
        Me.Label7.Size = New System.Drawing.Size(121, 13)
        Me.Label7.TabIndex = 21
        Me.Label7.Text = "Примечания:"
        '
        'btnAdd
        '
        Me.btnAdd.Location = New System.Drawing.Point(3, 422)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(75, 23)
        Me.btnAdd.TabIndex = 22
        Me.btnAdd.Text = "Добавить"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'btnCancel
        '
        Me.btnCancel.Location = New System.Drawing.Point(130, 422)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(75, 23)
        Me.btnCancel.TabIndex = 23
        Me.btnCancel.Text = "Отмена"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'chkNezap
        '
        Me.chkNezap.AutoSize = True
        Me.chkNezap.Location = New System.Drawing.Point(3, 257)
        Me.chkNezap.Name = "chkNezap"
        Me.chkNezap.Size = New System.Drawing.Size(119, 17)
        Me.chkNezap.TabIndex = 24
        Me.chkNezap.Text = "Не заправляемый"
        Me.chkNezap.UseVisualStyleBackColor = True
        '
        'chkNZ
        '
        Me.chkNZ.AutoSize = True
        Me.chkNZ.Location = New System.Drawing.Point(130, 257)
        Me.chkNZ.Name = "chkNZ"
        Me.chkNZ.Size = New System.Drawing.Size(97, 17)
        Me.chkNZ.TabIndex = 25
        Me.chkNZ.Text = "Не заправлен"
        Me.chkNZ.UseVisualStyleBackColor = True
        '
        'chkIznos
        '
        Me.chkIznos.AutoSize = True
        Me.chkIznos.Location = New System.Drawing.Point(233, 257)
        Me.chkIznos.Name = "chkIznos"
        Me.chkIznos.Size = New System.Drawing.Size(72, 17)
        Me.chkIznos.TabIndex = 26
        Me.chkIznos.Text = "Изношен"
        Me.chkIznos.UseVisualStyleBackColor = True
        '
        'chkSPS
        '
        Me.chkSPS.AutoSize = True
        Me.chkSPS.Location = New System.Drawing.Point(3, 280)
        Me.chkSPS.Name = "chkSPS"
        Me.chkSPS.Size = New System.Drawing.Size(63, 17)
        Me.chkSPS.TabIndex = 27
        Me.chkSPS.Text = "Списан"
        Me.chkSPS.UseVisualStyleBackColor = True
        '
        'chkNaSP
        '
        Me.chkNaSP.AutoSize = True
        Me.chkNaSP.Location = New System.Drawing.Point(130, 280)
        Me.chkNaSP.Name = "chkNaSP"
        Me.chkNaSP.Size = New System.Drawing.Size(91, 17)
        Me.chkNaSP.TabIndex = 28
        Me.chkNaSP.Text = "На списание"
        Me.chkNaSP.UseVisualStyleBackColor = True
        '
        'txtCashe
        '
        Me.TableLayoutPanel1.SetColumnSpan(Me.txtCashe, 2)
        Me.txtCashe.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtCashe.Location = New System.Drawing.Point(130, 205)
        Me.txtCashe.Maximum = New Decimal(New Integer() {100000, 0, 0, 0})
        Me.txtCashe.Name = "txtCashe"
        Me.txtCashe.Size = New System.Drawing.Size(270, 20)
        Me.txtCashe.TabIndex = 29
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 3
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel1.Controls.Add(Me.Label1, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.btnCancel, 1, 14)
        Me.TableLayoutPanel1.Controls.Add(Me.chkNaSP, 1, 11)
        Me.TableLayoutPanel1.Controls.Add(Me.btnAdd, 0, 14)
        Me.TableLayoutPanel1.Controls.Add(Me.txtCashe, 1, 8)
        Me.TableLayoutPanel1.Controls.Add(Me.txtMemo, 1, 12)
        Me.TableLayoutPanel1.Controls.Add(Me.Label7, 0, 12)
        Me.TableLayoutPanel1.Controls.Add(Me.chkSPS, 0, 11)
        Me.TableLayoutPanel1.Controls.Add(Me.lblRealNumber, 1, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.chkIznos, 2, 10)
        Me.TableLayoutPanel1.Controls.Add(Me.Label2, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.chkNZ, 1, 10)
        Me.TableLayoutPanel1.Controls.Add(Me.txtSerNumb, 1, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.chkNezap, 0, 10)
        Me.TableLayoutPanel1.Controls.Add(Me.Label3, 0, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.cmbProizv, 1, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.Label4, 0, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.cmbTipC, 1, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.Label5, 0, 4)
        Me.TableLayoutPanel1.Controls.Add(Me.dtSale, 1, 9)
        Me.TableLayoutPanel1.Controls.Add(Me.cmbModC, 1, 4)
        Me.TableLayoutPanel1.Controls.Add(Me.Label11, 0, 9)
        Me.TableLayoutPanel1.Controls.Add(Me.Label6, 0, 5)
        Me.TableLayoutPanel1.Controls.Add(Me.cmbSostUstr, 1, 5)
        Me.TableLayoutPanel1.Controls.Add(Me.Label8, 0, 6)
        Me.TableLayoutPanel1.Controls.Add(Me.Label10, 0, 8)
        Me.TableLayoutPanel1.Controls.Add(Me.cmbSaler, 1, 6)
        Me.TableLayoutPanel1.Controls.Add(Me.txtSaleNumb, 1, 7)
        Me.TableLayoutPanel1.Controls.Add(Me.Label9, 0, 7)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 15
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
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(403, 455)
        Me.TableLayoutPanel1.TabIndex = 30
        '
        'frmCartr_ADD
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.ClientSize = New System.Drawing.Size(403, 455)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "frmCartr_ADD"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Добавление (Редактирование) картриджа"
        CType(Me.txtCashe, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents lblRealNumber As System.Windows.Forms.Label
    Friend WithEvents txtSerNumb As System.Windows.Forms.TextBox
    Friend WithEvents cmbProizv As System.Windows.Forms.ComboBox
    Friend WithEvents cmbTipC As System.Windows.Forms.ComboBox
    Friend WithEvents cmbModC As System.Windows.Forms.ComboBox
    Friend WithEvents cmbSostUstr As System.Windows.Forms.ComboBox
    Friend WithEvents cmbSaler As System.Windows.Forms.ComboBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txtSaleNumb As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents dtSale As System.Windows.Forms.DateTimePicker
    Friend WithEvents txtMemo As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents btnAdd As System.Windows.Forms.Button
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    Friend WithEvents chkNezap As System.Windows.Forms.CheckBox
    Friend WithEvents chkNZ As System.Windows.Forms.CheckBox
    Friend WithEvents chkIznos As System.Windows.Forms.CheckBox
    Friend WithEvents chkSPS As System.Windows.Forms.CheckBox
    Friend WithEvents chkNaSP As System.Windows.Forms.CheckBox
    Friend WithEvents txtCashe As System.Windows.Forms.NumericUpDown
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
End Class
