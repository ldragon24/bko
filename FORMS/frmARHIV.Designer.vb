<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmARHIV
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
        Me.btnZipUp = New System.Windows.Forms.Button()
        Me.btnUnZip = New System.Windows.Forms.Button()
        Me.lblStatus = New System.Windows.Forms.Label()
        Me.ProgressBar2 = New System.Windows.Forms.ProgressBar()
        Me.ProgressBar1 = New System.Windows.Forms.ProgressBar()
        Me.lbArh = New System.Windows.Forms.ListBox()
        Me.lvArh = New System.Windows.Forms.ListView()
        Me.SuspendLayout()
        '
        'btnZipUp
        '
        Me.btnZipUp.Location = New System.Drawing.Point(12, 422)
        Me.btnZipUp.Name = "btnZipUp"
        Me.btnZipUp.Size = New System.Drawing.Size(88, 23)
        Me.btnZipUp.TabIndex = 17
        Me.btnZipUp.Text = "Упаковать"
        Me.btnZipUp.UseVisualStyleBackColor = True
        '
        'btnUnZip
        '
        Me.btnUnZip.Enabled = False
        Me.btnUnZip.Location = New System.Drawing.Point(215, 422)
        Me.btnUnZip.Name = "btnUnZip"
        Me.btnUnZip.Size = New System.Drawing.Size(104, 23)
        Me.btnUnZip.TabIndex = 18
        Me.btnUnZip.Text = "Распаковать"
        Me.btnUnZip.UseVisualStyleBackColor = True
        '
        'lblStatus
        '
        Me.lblStatus.AutoSize = True
        Me.lblStatus.Location = New System.Drawing.Point(12, 457)
        Me.lblStatus.Name = "lblStatus"
        Me.lblStatus.Size = New System.Drawing.Size(0, 13)
        Me.lblStatus.TabIndex = 19
        '
        'ProgressBar2
        '
        Me.ProgressBar2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ProgressBar2.Location = New System.Drawing.Point(2, 399)
        Me.ProgressBar2.Name = "ProgressBar2"
        Me.ProgressBar2.Size = New System.Drawing.Size(325, 13)
        Me.ProgressBar2.TabIndex = 21
        '
        'ProgressBar1
        '
        Me.ProgressBar1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ProgressBar1.Location = New System.Drawing.Point(1, 375)
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.Size = New System.Drawing.Size(326, 13)
        Me.ProgressBar1.TabIndex = 20
        '
        'lbArh
        '
        Me.lbArh.FormattingEnabled = True
        Me.lbArh.Location = New System.Drawing.Point(3, 65)
        Me.lbArh.Name = "lbArh"
        Me.lbArh.Size = New System.Drawing.Size(290, 303)
        Me.lbArh.TabIndex = 22
        Me.lbArh.Visible = False
        '
        'lvArh
        '
        Me.lvArh.Dock = System.Windows.Forms.DockStyle.Top
        Me.lvArh.FullRowSelect = True
        Me.lvArh.GridLines = True
        Me.lvArh.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable
        Me.lvArh.Location = New System.Drawing.Point(0, 0)
        Me.lvArh.Name = "lvArh"
        Me.lvArh.Size = New System.Drawing.Size(331, 412)
        Me.lvArh.Sorting = System.Windows.Forms.SortOrder.Ascending
        Me.lvArh.TabIndex = 23
        Me.lvArh.UseCompatibleStateImageBehavior = False
        Me.lvArh.View = System.Windows.Forms.View.Details
        '
        'frmARHIV
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(331, 487)
        Me.Controls.Add(Me.lvArh)
        Me.Controls.Add(Me.lbArh)
        Me.Controls.Add(Me.ProgressBar2)
        Me.Controls.Add(Me.ProgressBar1)
        Me.Controls.Add(Me.lblStatus)
        Me.Controls.Add(Me.btnUnZip)
        Me.Controls.Add(Me.btnZipUp)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "frmARHIV"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Архивация"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnZipUp As System.Windows.Forms.Button
    Friend WithEvents btnUnZip As System.Windows.Forms.Button
    Friend WithEvents lblStatus As System.Windows.Forms.Label
    Friend WithEvents ProgressBar2 As System.Windows.Forms.ProgressBar
    Friend WithEvents ProgressBar1 As System.Windows.Forms.ProgressBar
    Friend WithEvents lbArh As System.Windows.Forms.ListBox
    Friend WithEvents lvArh As System.Windows.Forms.ListView
End Class
