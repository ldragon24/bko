<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSheduler
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
        Me.DTSHED = New System.Windows.Forms.DateTimePicker()
        Me.cmbUser = New System.Windows.Forms.ComboBox()
        Me.txtShed = New System.Windows.Forms.TextBox()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.btnDel = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.lstShed = New System.Windows.Forms.ListView()
        Me.btnAll = New System.Windows.Forms.Button()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(3, 8)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(36, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Дата:"
        '
        'Label2
        '
        Me.Label2.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(182, 8)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(105, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Для пользователя:"
        '
        'DTSHED
        '
        Me.DTSHED.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.DTSHED.Location = New System.Drawing.Point(45, 4)
        Me.DTSHED.Name = "DTSHED"
        Me.DTSHED.Size = New System.Drawing.Size(131, 20)
        Me.DTSHED.TabIndex = 2
        Me.DTSHED.Value = New Date(2010, 3, 11, 0, 0, 0, 0)
        '
        'cmbUser
        '
        Me.cmbUser.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.cmbUser.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
        Me.cmbUser.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmbUser.FormattingEnabled = True
        Me.cmbUser.Location = New System.Drawing.Point(293, 4)
        Me.cmbUser.Name = "cmbUser"
        Me.cmbUser.Size = New System.Drawing.Size(302, 21)
        Me.cmbUser.TabIndex = 3
        '
        'txtShed
        '
        Me.TableLayoutPanel1.SetColumnSpan(Me.txtShed, 4)
        Me.txtShed.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtShed.Location = New System.Drawing.Point(3, 32)
        Me.txtShed.Multiline = True
        Me.txtShed.Name = "txtShed"
        Me.TableLayoutPanel1.SetRowSpan(Me.txtShed, 3)
        Me.txtShed.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtShed.Size = New System.Drawing.Size(879, 129)
        Me.txtShed.TabIndex = 4
        '
        'btnAdd
        '
        Me.btnAdd.Location = New System.Drawing.Point(888, 3)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(86, 23)
        Me.btnAdd.TabIndex = 5
        Me.btnAdd.Text = "Добавить"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'btnDel
        '
        Me.btnDel.Location = New System.Drawing.Point(888, 32)
        Me.btnDel.Name = "btnDel"
        Me.btnDel.Size = New System.Drawing.Size(86, 23)
        Me.btnDel.TabIndex = 6
        Me.btnDel.Text = "Удалить"
        Me.btnDel.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(888, 61)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(86, 23)
        Me.btnClear.TabIndex = 7
        Me.btnClear.Text = "Очистить"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'lstShed
        '
        Me.TableLayoutPanel1.SetColumnSpan(Me.lstShed, 5)
        Me.lstShed.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lstShed.FullRowSelect = True
        Me.lstShed.GridLines = True
        Me.lstShed.HideSelection = False
        Me.lstShed.Location = New System.Drawing.Point(3, 167)
        Me.lstShed.MultiSelect = False
        Me.lstShed.Name = "lstShed"
        Me.lstShed.Size = New System.Drawing.Size(986, 496)
        Me.lstShed.TabIndex = 8
        Me.lstShed.UseCompatibleStateImageBehavior = False
        Me.lstShed.View = System.Windows.Forms.View.Details
        '
        'btnAll
        '
        Me.btnAll.Location = New System.Drawing.Point(888, 90)
        Me.btnAll.Name = "btnAll"
        Me.btnAll.Size = New System.Drawing.Size(86, 23)
        Me.btnAll.TabIndex = 9
        Me.btnAll.Text = "Показать все"
        Me.btnAll.UseVisualStyleBackColor = True
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 5
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel1.Controls.Add(Me.Label1, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.lstShed, 0, 4)
        Me.TableLayoutPanel1.Controls.Add(Me.btnAll, 4, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.txtShed, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.DTSHED, 1, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Label2, 2, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.btnClear, 4, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.cmbUser, 3, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.btnDel, 4, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.btnAdd, 4, 0)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 5
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(992, 666)
        Me.TableLayoutPanel1.TabIndex = 10
        '
        'frmSheduler
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(992, 666)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.MinimumSize = New System.Drawing.Size(1000, 700)
        Me.Name = "frmSheduler"
        Me.Text = "Напоминания"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents DTSHED As System.Windows.Forms.DateTimePicker
    Friend WithEvents cmbUser As System.Windows.Forms.ComboBox
    Friend WithEvents txtShed As System.Windows.Forms.TextBox
    Friend WithEvents btnAdd As System.Windows.Forms.Button
    Friend WithEvents btnDel As System.Windows.Forms.Button
    Friend WithEvents btnClear As System.Windows.Forms.Button
    Friend WithEvents lstShed As System.Windows.Forms.ListView
    Friend WithEvents btnAll As System.Windows.Forms.Button
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
End Class
