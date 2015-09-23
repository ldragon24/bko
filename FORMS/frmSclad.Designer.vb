<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSclad
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
        Me.lvSclad = New System.Windows.Forms.ListView()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.btnDel = New System.Windows.Forms.Button()
        Me.btnTREB = New System.Windows.Forms.Button()
        Me.btnOffice = New System.Windows.Forms.Button()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'lvSclad
        '
        Me.TableLayoutPanel1.SetColumnSpan(Me.lvSclad, 4)
        Me.lvSclad.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lvSclad.FullRowSelect = True
        Me.lvSclad.GridLines = True
        Me.lvSclad.Location = New System.Drawing.Point(3, 3)
        Me.lvSclad.MultiSelect = False
        Me.lvSclad.Name = "lvSclad"
        Me.lvSclad.ShowItemToolTips = True
        Me.lvSclad.Size = New System.Drawing.Size(986, 590)
        Me.lvSclad.TabIndex = 18
        Me.lvSclad.UseCompatibleStateImageBehavior = False
        Me.lvSclad.View = System.Windows.Forms.View.Details
        '
        'btnAdd
        '
        Me.btnAdd.Location = New System.Drawing.Point(3, 599)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(75, 23)
        Me.btnAdd.TabIndex = 19
        Me.btnAdd.Text = "Добавить"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'btnDel
        '
        Me.btnDel.Location = New System.Drawing.Point(84, 599)
        Me.btnDel.Name = "btnDel"
        Me.btnDel.Size = New System.Drawing.Size(75, 23)
        Me.btnDel.TabIndex = 20
        Me.btnDel.Text = "Удалить"
        Me.btnDel.UseVisualStyleBackColor = True
        '
        'btnTREB
        '
        Me.btnTREB.Location = New System.Drawing.Point(165, 599)
        Me.btnTREB.Name = "btnTREB"
        Me.btnTREB.Size = New System.Drawing.Size(133, 23)
        Me.btnTREB.TabIndex = 21
        Me.btnTREB.Text = "Выписать требование"
        Me.btnTREB.UseVisualStyleBackColor = True
        '
        'btnOffice
        '
        Me.btnOffice.Location = New System.Drawing.Point(304, 599)
        Me.btnOffice.Name = "btnOffice"
        Me.btnOffice.Size = New System.Drawing.Size(75, 23)
        Me.btnOffice.TabIndex = 22
        Me.btnOffice.Text = "В Офис"
        Me.btnOffice.UseVisualStyleBackColor = True
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 4
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.lvSclad, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.btnOffice, 3, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.btnAdd, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.btnTREB, 2, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.btnDel, 1, 1)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 2
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(992, 646)
        Me.TableLayoutPanel1.TabIndex = 23
        '
        'frmSclad
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(992, 646)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.MinimumSize = New System.Drawing.Size(900, 600)
        Me.Name = "frmSclad"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Склад"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents lvSclad As System.Windows.Forms.ListView
    Friend WithEvents btnAdd As System.Windows.Forms.Button
    Friend WithEvents btnDel As System.Windows.Forms.Button
    Friend WithEvents btnTREB As System.Windows.Forms.Button
    Friend WithEvents btnOffice As System.Windows.Forms.Button
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
End Class
