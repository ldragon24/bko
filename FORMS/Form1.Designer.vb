<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.gbMemo = New System.Windows.Forms.GroupBox()
        Me.txtmemo = New System.Windows.Forms.TextBox()
        Me.gbMemo.SuspendLayout()
        Me.SuspendLayout()
        '
        'gbMemo
        '
        Me.gbMemo.Controls.Add(Me.txtmemo)
        Me.gbMemo.Location = New System.Drawing.Point(12, 12)
        Me.gbMemo.Name = "gbMemo"
        Me.gbMemo.Size = New System.Drawing.Size(660, 127)
        Me.gbMemo.TabIndex = 51
        Me.gbMemo.TabStop = False
        Me.gbMemo.Text = "Краткое описание"
        '
        'txtmemo
        '
        Me.txtmemo.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtmemo.Location = New System.Drawing.Point(3, 16)
        Me.txtmemo.Multiline = True
        Me.txtmemo.Name = "txtmemo"
        Me.txtmemo.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtmemo.Size = New System.Drawing.Size(654, 108)
        Me.txtmemo.TabIndex = 54
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1010, 282)
        Me.Controls.Add(Me.gbMemo)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.gbMemo.ResumeLayout(False)
        Me.gbMemo.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents gbMemo As System.Windows.Forms.GroupBox
    Friend WithEvents txtmemo As System.Windows.Forms.TextBox

End Class
