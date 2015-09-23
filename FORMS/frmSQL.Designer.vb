<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSQL
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
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.btnExecute = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnResSend = New System.Windows.Forms.Button()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.txtQ = New System.Windows.Forms.TextBox()
        Me.cmbSaveQ = New System.Windows.Forms.ComboBox()
        Me.LvQ = New System.Windows.Forms.ListView()
        Me.lstTable = New System.Windows.Forms.ListBox()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.TableLayoutPanel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.AutoSize = True
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel1.Controls.Add(Me.TableLayoutPanel2, 1, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.txtQ, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.cmbSaveQ, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.LvQ, 0, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.lstTable, 1, 2)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 3
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(992, 616)
        Me.TableLayoutPanel1.TabIndex = 21
        '
        'TableLayoutPanel2
        '
        Me.TableLayoutPanel2.ColumnCount = 1
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel2.Controls.Add(Me.btnDelete, 0, 4)
        Me.TableLayoutPanel2.Controls.Add(Me.btnExecute, 0, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.btnClear, 0, 1)
        Me.TableLayoutPanel2.Controls.Add(Me.btnResSend, 0, 2)
        Me.TableLayoutPanel2.Controls.Add(Me.btnSave, 0, 3)
        Me.TableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(762, 3)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RowCount = 5
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(227, 137)
        Me.TableLayoutPanel2.TabIndex = 27
        '
        'btnDelete
        '
        Me.btnDelete.Location = New System.Drawing.Point(3, 115)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(75, 22)
        Me.btnDelete.TabIndex = 5
        Me.btnDelete.Text = "Удалить"
        Me.btnDelete.UseVisualStyleBackColor = True
        '
        'btnExecute
        '
        Me.btnExecute.Location = New System.Drawing.Point(3, 3)
        Me.btnExecute.Name = "btnExecute"
        Me.btnExecute.Size = New System.Drawing.Size(75, 22)
        Me.btnExecute.TabIndex = 1
        Me.btnExecute.Text = "Выполнить"
        Me.btnExecute.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(3, 31)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(75, 22)
        Me.btnClear.TabIndex = 2
        Me.btnClear.Text = "Очистить"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'btnResSend
        '
        Me.btnResSend.Location = New System.Drawing.Point(3, 59)
        Me.btnResSend.Name = "btnResSend"
        Me.btnResSend.Size = New System.Drawing.Size(75, 22)
        Me.btnResSend.TabIndex = 3
        Me.btnResSend.Text = "В офис"
        Me.btnResSend.UseVisualStyleBackColor = True
        '
        'btnSave
        '
        Me.btnSave.Location = New System.Drawing.Point(3, 87)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(75, 22)
        Me.btnSave.TabIndex = 4
        Me.btnSave.Text = "Сохранить"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'txtQ
        '
        Me.txtQ.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtQ.Location = New System.Drawing.Point(3, 3)
        Me.txtQ.Multiline = True
        Me.txtQ.Name = "txtQ"
        Me.txtQ.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtQ.Size = New System.Drawing.Size(753, 137)
        Me.txtQ.TabIndex = 23
        '
        'cmbSaveQ
        '
        Me.cmbSaveQ.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
        Me.cmbSaveQ.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmbSaveQ.Dock = System.Windows.Forms.DockStyle.Fill
        Me.cmbSaveQ.FormattingEnabled = True
        Me.cmbSaveQ.Location = New System.Drawing.Point(3, 146)
        Me.cmbSaveQ.Name = "cmbSaveQ"
        Me.cmbSaveQ.Size = New System.Drawing.Size(753, 21)
        Me.cmbSaveQ.TabIndex = 25
        '
        'LvQ
        '
        Me.LvQ.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LvQ.FullRowSelect = True
        Me.LvQ.GridLines = True
        Me.LvQ.Location = New System.Drawing.Point(3, 173)
        Me.LvQ.MultiSelect = False
        Me.LvQ.Name = "LvQ"
        Me.LvQ.ShowItemToolTips = True
        Me.LvQ.Size = New System.Drawing.Size(753, 442)
        Me.LvQ.TabIndex = 24
        Me.LvQ.UseCompatibleStateImageBehavior = False
        Me.LvQ.View = System.Windows.Forms.View.Details
        '
        'lstTable
        '
        Me.lstTable.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lstTable.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.lstTable.FormattingEnabled = True
        Me.lstTable.ItemHeight = 16
        Me.lstTable.Location = New System.Drawing.Point(762, 173)
        Me.lstTable.Name = "lstTable"
        Me.lstTable.Size = New System.Drawing.Size(227, 442)
        Me.lstTable.TabIndex = 26
        '
        'frmSQL
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(992, 616)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.MinimumSize = New System.Drawing.Size(1000, 650)
        Me.Name = "frmSQL"
        Me.Text = "Запросы SQL"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        Me.TableLayoutPanel2.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents txtQ As System.Windows.Forms.TextBox
    Friend WithEvents cmbSaveQ As System.Windows.Forms.ComboBox
    Friend WithEvents LvQ As System.Windows.Forms.ListView
    Friend WithEvents lstTable As System.Windows.Forms.ListBox
    Friend WithEvents TableLayoutPanel2 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents btnDelete As System.Windows.Forms.Button
    Friend WithEvents btnExecute As System.Windows.Forms.Button
    Friend WithEvents btnClear As System.Windows.Forms.Button
    Friend WithEvents btnResSend As System.Windows.Forms.Button
    Friend WithEvents btnSave As System.Windows.Forms.Button
End Class
