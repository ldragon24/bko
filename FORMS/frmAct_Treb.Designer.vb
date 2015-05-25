<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAct_Treb
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
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.btnAVOSadd = New System.Windows.Forms.Button()
        Me.lvACTVV = New System.Windows.Forms.ListView()
        Me.btnAVOSofsend = New System.Windows.Forms.Button()
        Me.btnAVOSdel = New System.Windows.Forms.Button()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
        Me.lvACTSP = New System.Windows.Forms.ListView()
        Me.btnASPofsend = New System.Windows.Forms.Button()
        Me.btnASPadd = New System.Windows.Forms.Button()
        Me.btnASPdel = New System.Windows.Forms.Button()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.TableLayoutPanel3 = New System.Windows.Forms.TableLayoutPanel()
        Me.lvTREB = New System.Windows.Forms.ListView()
        Me.btnTRofSend = New System.Windows.Forms.Button()
        Me.btnTRadd = New System.Windows.Forms.Button()
        Me.btnTRdel = New System.Windows.Forms.Button()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.TableLayoutPanel2.SuspendLayout()
        Me.TabPage3.SuspendLayout()
        Me.TableLayoutPanel3.SuspendLayout()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Controls.Add(Me.TabPage3)
        Me.TabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControl1.Location = New System.Drawing.Point(0, 0)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(992, 666)
        Me.TabControl1.TabIndex = 0
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.TableLayoutPanel1)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(984, 640)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Акт ввода основных средств"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 3
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.btnAVOSadd, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.lvACTVV, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.btnAVOSofsend, 2, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.btnAVOSdel, 1, 1)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(3, 3)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 2
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(978, 634)
        Me.TableLayoutPanel1.TabIndex = 8
        '
        'btnAVOSadd
        '
        Me.btnAVOSadd.Location = New System.Drawing.Point(3, 587)
        Me.btnAVOSadd.Name = "btnAVOSadd"
        Me.btnAVOSadd.Size = New System.Drawing.Size(75, 23)
        Me.btnAVOSadd.TabIndex = 5
        Me.btnAVOSadd.Text = "Добавить"
        Me.btnAVOSadd.UseVisualStyleBackColor = True
        '
        'lvACTVV
        '
        Me.TableLayoutPanel1.SetColumnSpan(Me.lvACTVV, 3)
        Me.lvACTVV.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lvACTVV.FullRowSelect = True
        Me.lvACTVV.GridLines = True
        Me.lvACTVV.Location = New System.Drawing.Point(3, 3)
        Me.lvACTVV.Name = "lvACTVV"
        Me.lvACTVV.Size = New System.Drawing.Size(972, 578)
        Me.lvACTVV.TabIndex = 4
        Me.lvACTVV.UseCompatibleStateImageBehavior = False
        Me.lvACTVV.View = System.Windows.Forms.View.Details
        '
        'btnAVOSofsend
        '
        Me.btnAVOSofsend.Location = New System.Drawing.Point(165, 587)
        Me.btnAVOSofsend.Name = "btnAVOSofsend"
        Me.btnAVOSofsend.Size = New System.Drawing.Size(75, 23)
        Me.btnAVOSofsend.TabIndex = 7
        Me.btnAVOSofsend.Text = "В офис"
        Me.btnAVOSofsend.UseVisualStyleBackColor = True
        '
        'btnAVOSdel
        '
        Me.btnAVOSdel.Location = New System.Drawing.Point(84, 587)
        Me.btnAVOSdel.Name = "btnAVOSdel"
        Me.btnAVOSdel.Size = New System.Drawing.Size(75, 23)
        Me.btnAVOSdel.TabIndex = 6
        Me.btnAVOSdel.Text = "Удалить"
        Me.btnAVOSdel.UseVisualStyleBackColor = True
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.TableLayoutPanel2)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(984, 640)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Акт на списание"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'TableLayoutPanel2
        '
        Me.TableLayoutPanel2.ColumnCount = 3
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel2.Controls.Add(Me.lvACTSP, 0, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.btnASPofsend, 2, 1)
        Me.TableLayoutPanel2.Controls.Add(Me.btnASPadd, 0, 1)
        Me.TableLayoutPanel2.Controls.Add(Me.btnASPdel, 1, 1)
        Me.TableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(3, 3)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RowCount = 2
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50.0!))
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(978, 634)
        Me.TableLayoutPanel2.TabIndex = 11
        '
        'lvACTSP
        '
        Me.TableLayoutPanel2.SetColumnSpan(Me.lvACTSP, 3)
        Me.lvACTSP.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lvACTSP.FullRowSelect = True
        Me.lvACTSP.GridLines = True
        Me.lvACTSP.Location = New System.Drawing.Point(3, 3)
        Me.lvACTSP.Name = "lvACTSP"
        Me.lvACTSP.Size = New System.Drawing.Size(972, 578)
        Me.lvACTSP.TabIndex = 5
        Me.lvACTSP.UseCompatibleStateImageBehavior = False
        Me.lvACTSP.View = System.Windows.Forms.View.Details
        '
        'btnASPofsend
        '
        Me.btnASPofsend.Location = New System.Drawing.Point(165, 587)
        Me.btnASPofsend.Name = "btnASPofsend"
        Me.btnASPofsend.Size = New System.Drawing.Size(75, 23)
        Me.btnASPofsend.TabIndex = 10
        Me.btnASPofsend.Text = "В офис"
        Me.btnASPofsend.UseVisualStyleBackColor = True
        '
        'btnASPadd
        '
        Me.btnASPadd.Location = New System.Drawing.Point(3, 587)
        Me.btnASPadd.Name = "btnASPadd"
        Me.btnASPadd.Size = New System.Drawing.Size(75, 23)
        Me.btnASPadd.TabIndex = 8
        Me.btnASPadd.Text = "Добавить"
        Me.btnASPadd.UseVisualStyleBackColor = True
        '
        'btnASPdel
        '
        Me.btnASPdel.Location = New System.Drawing.Point(84, 587)
        Me.btnASPdel.Name = "btnASPdel"
        Me.btnASPdel.Size = New System.Drawing.Size(75, 23)
        Me.btnASPdel.TabIndex = 9
        Me.btnASPdel.Text = "Удалить"
        Me.btnASPdel.UseVisualStyleBackColor = True
        '
        'TabPage3
        '
        Me.TabPage3.Controls.Add(Me.TableLayoutPanel3)
        Me.TabPage3.Location = New System.Drawing.Point(4, 22)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage3.Size = New System.Drawing.Size(984, 640)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "Требования-накладные"
        Me.TabPage3.UseVisualStyleBackColor = True
        '
        'TableLayoutPanel3
        '
        Me.TableLayoutPanel3.ColumnCount = 3
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel3.Controls.Add(Me.lvTREB, 0, 0)
        Me.TableLayoutPanel3.Controls.Add(Me.btnTRofSend, 2, 1)
        Me.TableLayoutPanel3.Controls.Add(Me.btnTRadd, 0, 1)
        Me.TableLayoutPanel3.Controls.Add(Me.btnTRdel, 1, 1)
        Me.TableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel3.Location = New System.Drawing.Point(3, 3)
        Me.TableLayoutPanel3.Name = "TableLayoutPanel3"
        Me.TableLayoutPanel3.RowCount = 2
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50.0!))
        Me.TableLayoutPanel3.Size = New System.Drawing.Size(978, 634)
        Me.TableLayoutPanel3.TabIndex = 11
        '
        'lvTREB
        '
        Me.TableLayoutPanel3.SetColumnSpan(Me.lvTREB, 3)
        Me.lvTREB.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lvTREB.FullRowSelect = True
        Me.lvTREB.GridLines = True
        Me.lvTREB.Location = New System.Drawing.Point(3, 3)
        Me.lvTREB.Name = "lvTREB"
        Me.lvTREB.Size = New System.Drawing.Size(972, 578)
        Me.lvTREB.TabIndex = 5
        Me.lvTREB.UseCompatibleStateImageBehavior = False
        Me.lvTREB.View = System.Windows.Forms.View.Details
        '
        'btnTRofSend
        '
        Me.btnTRofSend.Location = New System.Drawing.Point(165, 587)
        Me.btnTRofSend.Name = "btnTRofSend"
        Me.btnTRofSend.Size = New System.Drawing.Size(75, 23)
        Me.btnTRofSend.TabIndex = 10
        Me.btnTRofSend.Text = "В офис"
        Me.btnTRofSend.UseVisualStyleBackColor = True
        '
        'btnTRadd
        '
        Me.btnTRadd.Location = New System.Drawing.Point(3, 587)
        Me.btnTRadd.Name = "btnTRadd"
        Me.btnTRadd.Size = New System.Drawing.Size(75, 23)
        Me.btnTRadd.TabIndex = 8
        Me.btnTRadd.Text = "Добавить"
        Me.btnTRadd.UseVisualStyleBackColor = True
        '
        'btnTRdel
        '
        Me.btnTRdel.Location = New System.Drawing.Point(84, 587)
        Me.btnTRdel.Name = "btnTRdel"
        Me.btnTRdel.Size = New System.Drawing.Size(75, 23)
        Me.btnTRdel.TabIndex = 9
        Me.btnTRdel.Text = "Удалить"
        Me.btnTRdel.UseVisualStyleBackColor = True
        '
        'frmAct_Treb
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(992, 666)
        Me.Controls.Add(Me.TabControl1)
        Me.MinimumSize = New System.Drawing.Size(1000, 700)
        Me.Name = "frmAct_Treb"
        Me.Text = "Акты-Требования"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TabPage2.ResumeLayout(False)
        Me.TableLayoutPanel2.ResumeLayout(False)
        Me.TabPage3.ResumeLayout(False)
        Me.TableLayoutPanel3.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage3 As System.Windows.Forms.TabPage
    Friend WithEvents lvACTVV As System.Windows.Forms.ListView
    Friend WithEvents lvACTSP As System.Windows.Forms.ListView
    Friend WithEvents lvTREB As System.Windows.Forms.ListView
    Friend WithEvents btnAVOSofsend As System.Windows.Forms.Button
    Friend WithEvents btnAVOSdel As System.Windows.Forms.Button
    Friend WithEvents btnAVOSadd As System.Windows.Forms.Button
    Friend WithEvents btnASPofsend As System.Windows.Forms.Button
    Friend WithEvents btnASPdel As System.Windows.Forms.Button
    Friend WithEvents btnASPadd As System.Windows.Forms.Button
    Friend WithEvents btnTRofSend As System.Windows.Forms.Button
    Friend WithEvents btnTRdel As System.Windows.Forms.Button
    Friend WithEvents btnTRadd As System.Windows.Forms.Button
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents TableLayoutPanel2 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents TableLayoutPanel3 As System.Windows.Forms.TableLayoutPanel
End Class
