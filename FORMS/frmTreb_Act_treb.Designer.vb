<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmTreb_Act_treb
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
        Me.txtNomer = New System.Windows.Forms.TextBox()
        Me.cmbTip = New System.Windows.Forms.ComboBox()
        Me.txtNodel = New System.Windows.Forms.TextBox()
        Me.txtCokVo = New System.Windows.Forms.NumericUpDown()
        Me.txtPrice = New System.Windows.Forms.NumericUpDown()
        Me.cmbLich = New System.Windows.Forms.ComboBox()
        Me.cmbLich2 = New System.Windows.Forms.ComboBox()
        Me.txtDate = New System.Windows.Forms.DateTimePicker()
        Me.cmdAdd = New System.Windows.Forms.Button()
        Me.cmdCancel = New System.Windows.Forms.Button()
        Me.TableLayoutPanel1.SuspendLayout()
        CType(Me.txtCokVo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtPrice, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.TableLayoutPanel1.Controls.Add(Me.txtNomer, 1, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.cmbTip, 1, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.txtNodel, 1, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.txtCokVo, 1, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.txtPrice, 1, 4)
        Me.TableLayoutPanel1.Controls.Add(Me.cmbLich, 1, 5)
        Me.TableLayoutPanel1.Controls.Add(Me.cmbLich2, 1, 6)
        Me.TableLayoutPanel1.Controls.Add(Me.txtDate, 1, 7)
        Me.TableLayoutPanel1.Controls.Add(Me.cmdAdd, 0, 8)
        Me.TableLayoutPanel1.Controls.Add(Me.cmdCancel, 1, 8)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 9
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(575, 246)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(3, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(103, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Номер требования"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(3, 26)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(112, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Тип комплектующей"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(3, 53)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(132, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Модель комплектующей"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(3, 79)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(41, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Кол-во"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(3, 105)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(33, 13)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Цена"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(3, 131)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(65, 13)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Через кого"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(3, 158)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(67, 13)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = "Затребовал"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(3, 185)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(33, 13)
        Me.Label8.TabIndex = 7
        Me.Label8.Text = "Дата"
        '
        'txtNomer
        '
        Me.txtNomer.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtNomer.Location = New System.Drawing.Point(141, 3)
        Me.txtNomer.Name = "txtNomer"
        Me.txtNomer.Size = New System.Drawing.Size(431, 20)
        Me.txtNomer.TabIndex = 8
        '
        'cmbTip
        '
        Me.cmbTip.Dock = System.Windows.Forms.DockStyle.Fill
        Me.cmbTip.FormattingEnabled = True
        Me.cmbTip.Location = New System.Drawing.Point(141, 29)
        Me.cmbTip.Name = "cmbTip"
        Me.cmbTip.Size = New System.Drawing.Size(431, 21)
        Me.cmbTip.TabIndex = 9
        '
        'txtNodel
        '
        Me.txtNodel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtNodel.Location = New System.Drawing.Point(141, 56)
        Me.txtNodel.Name = "txtNodel"
        Me.txtNodel.Size = New System.Drawing.Size(431, 20)
        Me.txtNodel.TabIndex = 10
        '
        'txtCokVo
        '
        Me.txtCokVo.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtCokVo.Location = New System.Drawing.Point(141, 82)
        Me.txtCokVo.Maximum = New Decimal(New Integer() {1000, 0, 0, 0})
        Me.txtCokVo.Name = "txtCokVo"
        Me.txtCokVo.Size = New System.Drawing.Size(431, 20)
        Me.txtCokVo.TabIndex = 11
        '
        'txtPrice
        '
        Me.txtPrice.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtPrice.Location = New System.Drawing.Point(141, 108)
        Me.txtPrice.Maximum = New Decimal(New Integer() {1000000, 0, 0, 0})
        Me.txtPrice.Name = "txtPrice"
        Me.txtPrice.Size = New System.Drawing.Size(431, 20)
        Me.txtPrice.TabIndex = 12
        '
        'cmbLich
        '
        Me.cmbLich.Dock = System.Windows.Forms.DockStyle.Fill
        Me.cmbLich.FormattingEnabled = True
        Me.cmbLich.Location = New System.Drawing.Point(141, 134)
        Me.cmbLich.Name = "cmbLich"
        Me.cmbLich.Size = New System.Drawing.Size(431, 21)
        Me.cmbLich.TabIndex = 13
        '
        'cmbLich2
        '
        Me.cmbLich2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.cmbLich2.FormattingEnabled = True
        Me.cmbLich2.Location = New System.Drawing.Point(141, 161)
        Me.cmbLich2.Name = "cmbLich2"
        Me.cmbLich2.Size = New System.Drawing.Size(431, 21)
        Me.cmbLich2.TabIndex = 14
        '
        'txtDate
        '
        Me.txtDate.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtDate.Location = New System.Drawing.Point(141, 188)
        Me.txtDate.Name = "txtDate"
        Me.txtDate.Size = New System.Drawing.Size(431, 20)
        Me.txtDate.TabIndex = 15
        Me.txtDate.Value = New Date(2010, 5, 19, 0, 0, 0, 0)
        '
        'cmdAdd
        '
        Me.cmdAdd.Location = New System.Drawing.Point(3, 214)
        Me.cmdAdd.Name = "cmdAdd"
        Me.cmdAdd.Size = New System.Drawing.Size(75, 23)
        Me.cmdAdd.TabIndex = 16
        Me.cmdAdd.Text = "Добавить"
        Me.cmdAdd.UseVisualStyleBackColor = True
        '
        'cmdCancel
        '
        Me.cmdCancel.Location = New System.Drawing.Point(141, 214)
        Me.cmdCancel.Name = "cmdCancel"
        Me.cmdCancel.Size = New System.Drawing.Size(75, 23)
        Me.cmdCancel.TabIndex = 17
        Me.cmdCancel.Text = "Отмена"
        Me.cmdCancel.UseVisualStyleBackColor = True
        '
        'frmTreb_Act_treb
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(575, 246)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "frmTreb_Act_treb"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Данные для требования"
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        CType(Me.txtCokVo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtPrice, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents txtNomer As System.Windows.Forms.TextBox
    Friend WithEvents cmbTip As System.Windows.Forms.ComboBox
    Friend WithEvents txtNodel As System.Windows.Forms.TextBox
    Friend WithEvents txtCokVo As System.Windows.Forms.NumericUpDown
    Friend WithEvents txtPrice As System.Windows.Forms.NumericUpDown
    Friend WithEvents cmbLich As System.Windows.Forms.ComboBox
    Friend WithEvents cmbLich2 As System.Windows.Forms.ComboBox
    Friend WithEvents txtDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents cmdAdd As System.Windows.Forms.Button
    Friend WithEvents cmdCancel As System.Windows.Forms.Button
End Class
