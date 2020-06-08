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
        Me.gbQR = New System.Windows.Forms.GroupBox()
        Me.TableLayoutPanel78 = New System.Windows.Forms.TableLayoutPanel()
        Me.pqr = New System.Windows.Forms.PictureBox()
        Me.btnQR = New System.Windows.Forms.Button()
        Me.lblQR = New System.Windows.Forms.Label()
        Me.gbQR.SuspendLayout()
        Me.TableLayoutPanel78.SuspendLayout()
        CType(Me.pqr, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'gbQR
        '
        Me.gbQR.Controls.Add(Me.TableLayoutPanel78)
        Me.gbQR.Location = New System.Drawing.Point(3, 2)
        Me.gbQR.Name = "gbQR"
        Me.gbQR.Size = New System.Drawing.Size(505, 267)
        Me.gbQR.TabIndex = 4
        Me.gbQR.TabStop = False
        Me.gbQR.Text = "QR код"
        '
        'TableLayoutPanel78
        '
        Me.TableLayoutPanel78.ColumnCount = 2
        Me.TableLayoutPanel78.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel78.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel78.Controls.Add(Me.pqr, 0, 0)
        Me.TableLayoutPanel78.Controls.Add(Me.btnQR, 1, 0)
        Me.TableLayoutPanel78.Controls.Add(Me.lblQR, 0, 1)
        Me.TableLayoutPanel78.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel78.Location = New System.Drawing.Point(3, 16)
        Me.TableLayoutPanel78.Name = "TableLayoutPanel78"
        Me.TableLayoutPanel78.RowCount = 2
        Me.TableLayoutPanel78.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel78.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 95.0!))
        Me.TableLayoutPanel78.Size = New System.Drawing.Size(499, 248)
        Me.TableLayoutPanel78.TabIndex = 0
        '
        'pqr
        '
        Me.pqr.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pqr.Location = New System.Drawing.Point(3, 3)
        Me.pqr.Name = "pqr"
        Me.pqr.Size = New System.Drawing.Size(412, 147)
        Me.pqr.TabIndex = 52
        Me.pqr.TabStop = False
        '
        'btnQR
        '
        Me.btnQR.Location = New System.Drawing.Point(421, 3)
        Me.btnQR.Name = "btnQR"
        Me.btnQR.Size = New System.Drawing.Size(75, 23)
        Me.btnQR.TabIndex = 53
        Me.btnQR.Text = "Button4"
        Me.btnQR.UseVisualStyleBackColor = True
        '
        'lblQR
        '
        Me.lblQR.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblQR.AutoSize = True
        Me.lblQR.Location = New System.Drawing.Point(3, 194)
        Me.lblQR.Name = "lblQR"
        Me.lblQR.Size = New System.Drawing.Size(412, 13)
        Me.lblQR.TabIndex = 54
        Me.lblQR.Text = "---"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(621, 407)
        Me.Controls.Add(Me.gbQR)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.gbQR.ResumeLayout(False)
        Me.TableLayoutPanel78.ResumeLayout(False)
        Me.TableLayoutPanel78.PerformLayout()
        CType(Me.pqr, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents gbQR As GroupBox
    Friend WithEvents TableLayoutPanel78 As TableLayoutPanel
    Friend WithEvents pqr As PictureBox
    Friend WithEvents btnQR As Button
    Friend WithEvents lblQR As Label
End Class
