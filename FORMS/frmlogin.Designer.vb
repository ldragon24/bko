<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmLogin
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmLogin))
        Me.Button1 = New System.Windows.Forms.Button()
        Me.TextBox5 = New System.Windows.Forms.TextBox()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.gbsql = New System.Windows.Forms.GroupBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblServer = New System.Windows.Forms.Label()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.cmbUser = New System.Windows.Forms.ComboBox()
        Me.btnLogin = New System.Windows.Forms.Button()
        Me.txtPassword = New System.Windows.Forms.TextBox()
        Me.gbData = New System.Windows.Forms.GroupBox()
        Me.cmbLang = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.btnDBDir = New System.Windows.Forms.Button()
        Me.cmbBD = New System.Windows.Forms.ComboBox()
        Me.lblPassword = New System.Windows.Forms.Label()
        Me.lblUser = New System.Windows.Forms.Label()
        Me.lblBase = New System.Windows.Forms.Label()
        Me.cmbSUBD = New System.Windows.Forms.ComboBox()
        Me.lblSUBD = New System.Windows.Forms.Label()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.gbsql.SuspendLayout()
        Me.gbData.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(251, 119)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(64, 23)
        Me.Button1.TabIndex = 5
        Me.Button1.Text = "Connect"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'TextBox5
        '
        Me.TextBox5.Location = New System.Drawing.Point(115, 122)
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.TextBox5.Size = New System.Drawing.Size(131, 20)
        Me.TextBox5.TabIndex = 4
        '
        'TextBox4
        '
        Me.TextBox4.AutoCompleteCustomSource.AddRange(New String() {"root", "toor", "sa"})
        Me.TextBox4.Location = New System.Drawing.Point(115, 96)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(200, 20)
        Me.TextBox4.TabIndex = 3
        '
        'TextBox3
        '
        Me.TextBox3.Location = New System.Drawing.Point(115, 70)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(200, 20)
        Me.TextBox3.TabIndex = 2
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(115, 44)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(200, 20)
        Me.TextBox2.TabIndex = 1
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(115, 17)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(200, 20)
        Me.TextBox1.TabIndex = 0
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(2, 125)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(48, 13)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Пароль:"
        '
        'gbsql
        '
        Me.gbsql.AutoSize = True
        Me.TableLayoutPanel1.SetColumnSpan(Me.gbsql, 2)
        Me.gbsql.Controls.Add(Me.Button1)
        Me.gbsql.Controls.Add(Me.TextBox5)
        Me.gbsql.Controls.Add(Me.TextBox4)
        Me.gbsql.Controls.Add(Me.TextBox3)
        Me.gbsql.Controls.Add(Me.TextBox2)
        Me.gbsql.Controls.Add(Me.TextBox1)
        Me.gbsql.Controls.Add(Me.Label4)
        Me.gbsql.Controls.Add(Me.Label3)
        Me.gbsql.Controls.Add(Me.Label2)
        Me.gbsql.Controls.Add(Me.Label1)
        Me.gbsql.Controls.Add(Me.lblServer)
        Me.gbsql.Location = New System.Drawing.Point(3, 43)
        Me.gbsql.Name = "gbsql"
        Me.gbsql.Size = New System.Drawing.Size(321, 161)
        Me.gbsql.TabIndex = 1
        Me.gbsql.TabStop = False
        Me.gbsql.Text = "Соединение с сервером"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(3, 99)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(106, 13)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Имя пользователя:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(2, 73)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(35, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "База:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(2, 47)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(35, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Порт:"
        '
        'lblServer
        '
        Me.lblServer.AutoSize = True
        Me.lblServer.Location = New System.Drawing.Point(2, 20)
        Me.lblServer.Name = "lblServer"
        Me.lblServer.Size = New System.Drawing.Size(47, 13)
        Me.lblServer.TabIndex = 0
        Me.lblServer.Text = "Сервер:"
        '
        'btnCancel
        '
        Me.btnCancel.Location = New System.Drawing.Point(84, 360)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(75, 23)
        Me.btnCancel.TabIndex = 4
        Me.btnCancel.Text = "Отмена"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'cmbUser
        '
        Me.cmbUser.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
        Me.cmbUser.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmbUser.FormattingEnabled = True
        Me.cmbUser.Location = New System.Drawing.Point(115, 49)
        Me.cmbUser.Name = "cmbUser"
        Me.cmbUser.Size = New System.Drawing.Size(200, 21)
        Me.cmbUser.TabIndex = 1
        '
        'btnLogin
        '
        Me.btnLogin.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnLogin.Location = New System.Drawing.Point(3, 360)
        Me.btnLogin.Name = "btnLogin"
        Me.btnLogin.Size = New System.Drawing.Size(75, 23)
        Me.btnLogin.TabIndex = 3
        Me.btnLogin.Text = "Вход"
        Me.btnLogin.UseVisualStyleBackColor = True
        '
        'txtPassword
        '
        Me.txtPassword.Location = New System.Drawing.Point(115, 76)
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtPassword.Size = New System.Drawing.Size(200, 20)
        Me.txtPassword.TabIndex = 2
        '
        'gbData
        '
        Me.gbData.AutoSize = True
        Me.TableLayoutPanel1.SetColumnSpan(Me.gbData, 2)
        Me.gbData.Controls.Add(Me.cmbLang)
        Me.gbData.Controls.Add(Me.Label5)
        Me.gbData.Controls.Add(Me.btnDBDir)
        Me.gbData.Controls.Add(Me.cmbUser)
        Me.gbData.Controls.Add(Me.txtPassword)
        Me.gbData.Controls.Add(Me.cmbBD)
        Me.gbData.Controls.Add(Me.lblPassword)
        Me.gbData.Controls.Add(Me.lblUser)
        Me.gbData.Controls.Add(Me.lblBase)
        Me.gbData.Location = New System.Drawing.Point(3, 210)
        Me.gbData.Name = "gbData"
        Me.gbData.Size = New System.Drawing.Size(321, 144)
        Me.gbData.TabIndex = 2
        Me.gbData.TabStop = False
        Me.gbData.Text = "Вход в программу:"
        '
        'cmbLang
        '
        Me.cmbLang.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
        Me.cmbLang.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmbLang.FormattingEnabled = True
        Me.cmbLang.Location = New System.Drawing.Point(115, 104)
        Me.cmbLang.Name = "cmbLang"
        Me.cmbLang.Size = New System.Drawing.Size(200, 21)
        Me.cmbLang.TabIndex = 5
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(3, 107)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(58, 13)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Language:"
        '
        'btnDBDir
        '
        Me.btnDBDir.Location = New System.Drawing.Point(279, 20)
        Me.btnDBDir.Name = "btnDBDir"
        Me.btnDBDir.Size = New System.Drawing.Size(36, 23)
        Me.btnDBDir.TabIndex = 3
        Me.btnDBDir.Text = "..."
        Me.btnDBDir.UseVisualStyleBackColor = True
        '
        'cmbBD
        '
        Me.cmbBD.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
        Me.cmbBD.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmbBD.FormattingEnabled = True
        Me.cmbBD.Location = New System.Drawing.Point(45, 20)
        Me.cmbBD.Name = "cmbBD"
        Me.cmbBD.Size = New System.Drawing.Size(227, 21)
        Me.cmbBD.TabIndex = 0
        '
        'lblPassword
        '
        Me.lblPassword.AutoSize = True
        Me.lblPassword.Location = New System.Drawing.Point(3, 79)
        Me.lblPassword.Name = "lblPassword"
        Me.lblPassword.Size = New System.Drawing.Size(48, 13)
        Me.lblPassword.TabIndex = 2
        Me.lblPassword.Text = "Пароль:"
        '
        'lblUser
        '
        Me.lblUser.AutoSize = True
        Me.lblUser.Location = New System.Drawing.Point(3, 52)
        Me.lblUser.Name = "lblUser"
        Me.lblUser.Size = New System.Drawing.Size(106, 13)
        Me.lblUser.TabIndex = 1
        Me.lblUser.Text = "Имя пользователя:"
        '
        'lblBase
        '
        Me.lblBase.AutoSize = True
        Me.lblBase.Location = New System.Drawing.Point(3, 20)
        Me.lblBase.Name = "lblBase"
        Me.lblBase.Size = New System.Drawing.Size(35, 13)
        Me.lblBase.TabIndex = 0
        Me.lblBase.Text = "База:"
        '
        'cmbSUBD
        '
        Me.cmbSUBD.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
        Me.cmbSUBD.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.TableLayoutPanel1.SetColumnSpan(Me.cmbSUBD, 2)
        Me.cmbSUBD.FormattingEnabled = True
        Me.cmbSUBD.Items.AddRange(New Object() {"MS Access", "MS Access 2007", "MS SQL", "MS SQL 2008", "MySQL", "PostgreSQL", "DSN", "MySQL (MyODBC 5.1)"})
        Me.cmbSUBD.Location = New System.Drawing.Point(3, 16)
        Me.cmbSUBD.Name = "cmbSUBD"
        Me.cmbSUBD.Size = New System.Drawing.Size(322, 21)
        Me.cmbSUBD.TabIndex = 0
        Me.cmbSUBD.Text = "MS Access"
        '
        'lblSUBD
        '
        Me.lblSUBD.AutoSize = True
        Me.TableLayoutPanel1.SetColumnSpan(Me.lblSUBD, 2)
        Me.lblSUBD.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.lblSUBD.Location = New System.Drawing.Point(3, 0)
        Me.lblSUBD.Name = "lblSUBD"
        Me.lblSUBD.Size = New System.Drawing.Size(104, 13)
        Me.lblSUBD.TabIndex = 11
        Me.lblSUBD.Text = "Выберете СУБД"
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.AutoSize = True
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel1.Controls.Add(Me.lblSUBD, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.btnCancel, 1, 4)
        Me.TableLayoutPanel1.Controls.Add(Me.gbsql, 0, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.btnLogin, 0, 4)
        Me.TableLayoutPanel1.Controls.Add(Me.cmbSUBD, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.gbData, 0, 3)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 5
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(328, 394)
        Me.TableLayoutPanel1.TabIndex = 12
        '
        'frmLogin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange
        Me.ClientSize = New System.Drawing.Size(328, 394)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmLogin"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Вход в программу"
        Me.TopMost = True
        Me.gbsql.ResumeLayout(False)
        Me.gbsql.PerformLayout()
        Me.gbData.ResumeLayout(False)
        Me.gbData.PerformLayout()
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents TextBox5 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox4 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox3 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents gbsql As System.Windows.Forms.GroupBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lblServer As System.Windows.Forms.Label
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    Friend WithEvents cmbUser As System.Windows.Forms.ComboBox
    Friend WithEvents btnLogin As System.Windows.Forms.Button
    Friend WithEvents txtPassword As System.Windows.Forms.TextBox
    Friend WithEvents gbData As System.Windows.Forms.GroupBox
    Friend WithEvents cmbBD As System.Windows.Forms.ComboBox
    Friend WithEvents lblPassword As System.Windows.Forms.Label
    Friend WithEvents lblUser As System.Windows.Forms.Label
    Friend WithEvents lblBase As System.Windows.Forms.Label
    Friend WithEvents cmbSUBD As System.Windows.Forms.ComboBox
    Friend WithEvents lblSUBD As System.Windows.Forms.Label
    Friend WithEvents btnDBDir As System.Windows.Forms.Button
    Friend WithEvents cmbLang As System.Windows.Forms.ComboBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
End Class
