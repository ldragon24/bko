<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmService_add
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
        Me.components = New System.ComponentModel.Container()
        Me.cmbCancel = New System.Windows.Forms.Button()
        Me.cmbAdd = New System.Windows.Forms.Button()
        Me.txtComent = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.chkClose = New System.Windows.Forms.CheckBox()
        Me.cmbTip = New System.Windows.Forms.ComboBox()
        Me.cmbKrit = New System.Windows.Forms.ComboBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.cmbOtv = New System.Windows.Forms.ComboBox()
        Me.cmbStatus = New System.Windows.Forms.ComboBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtRem = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtHead = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.dtIsp = New System.Windows.Forms.DateTimePicker()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtPhone = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.dtReg = New System.Windows.Forms.DateTimePicker()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cmbMast = New System.Windows.Forms.ComboBox()
        Me.cmbIst = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.RemCashe = New System.Windows.Forms.NumericUpDown()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.gbS = New System.Windows.Forms.GroupBox()
        Me.lvRem2 = New System.Windows.Forms.ListView()
        Me.lblWarant = New System.Windows.Forms.Label()
        Me.dtGarRem = New System.Windows.Forms.DateTimePicker()
        Me.CMServices = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.DeleteService = New System.Windows.Forms.ToolStripMenuItem()
        CType(Me.RemCashe, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.gbS.SuspendLayout()
        Me.CMServices.SuspendLayout()
        Me.SuspendLayout()
        '
        'cmbCancel
        '
        Me.cmbCancel.Location = New System.Drawing.Point(153, 638)
        Me.cmbCancel.Name = "cmbCancel"
        Me.cmbCancel.Size = New System.Drawing.Size(75, 23)
        Me.cmbCancel.TabIndex = 54
        Me.cmbCancel.Text = "Отмена"
        Me.cmbCancel.UseVisualStyleBackColor = True
        '
        'cmbAdd
        '
        Me.cmbAdd.Location = New System.Drawing.Point(3, 638)
        Me.cmbAdd.Name = "cmbAdd"
        Me.cmbAdd.Size = New System.Drawing.Size(75, 23)
        Me.cmbAdd.TabIndex = 53
        Me.cmbAdd.Text = "Добавить"
        Me.cmbAdd.UseVisualStyleBackColor = True
        '
        'txtComent
        '
        Me.TableLayoutPanel1.SetColumnSpan(Me.txtComent, 3)
        Me.txtComent.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtComent.Location = New System.Drawing.Point(153, 410)
        Me.txtComent.Multiline = True
        Me.txtComent.Name = "txtComent"
        Me.txtComent.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtComent.Size = New System.Drawing.Size(326, 68)
        Me.txtComent.TabIndex = 52
        '
        'Label12
        '
        Me.Label12.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(3, 431)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(144, 26)
        Me.Label12.TabIndex = 51
        Me.Label12.Text = "Действительный характер:"
        '
        'chkClose
        '
        Me.chkClose.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.chkClose.AutoSize = True
        Me.chkClose.Location = New System.Drawing.Point(346, 644)
        Me.chkClose.Name = "chkClose"
        Me.chkClose.Size = New System.Drawing.Size(133, 17)
        Me.chkClose.TabIndex = 50
        Me.chkClose.Text = "Заявка закрыта"
        Me.chkClose.UseVisualStyleBackColor = True
        '
        'cmbTip
        '
        Me.cmbTip.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
        Me.cmbTip.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.TableLayoutPanel1.SetColumnSpan(Me.cmbTip, 3)
        Me.cmbTip.FormattingEnabled = True
        Me.cmbTip.Location = New System.Drawing.Point(153, 357)
        Me.cmbTip.Name = "cmbTip"
        Me.cmbTip.Size = New System.Drawing.Size(323, 21)
        Me.cmbTip.TabIndex = 49
        '
        'cmbKrit
        '
        Me.cmbKrit.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
        Me.cmbKrit.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.TableLayoutPanel1.SetColumnSpan(Me.cmbKrit, 3)
        Me.cmbKrit.FormattingEnabled = True
        Me.cmbKrit.Location = New System.Drawing.Point(153, 330)
        Me.cmbKrit.Name = "cmbKrit"
        Me.cmbKrit.Size = New System.Drawing.Size(323, 21)
        Me.cmbKrit.TabIndex = 48
        '
        'Label10
        '
        Me.Label10.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(3, 361)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(144, 13)
        Me.Label10.TabIndex = 47
        Me.Label10.Text = "Тип:"
        '
        'Label11
        '
        Me.Label11.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(3, 334)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(144, 13)
        Me.Label11.TabIndex = 46
        Me.Label11.Text = "Критичность:"
        '
        'cmbOtv
        '
        Me.cmbOtv.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
        Me.cmbOtv.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.TableLayoutPanel1.SetColumnSpan(Me.cmbOtv, 3)
        Me.cmbOtv.FormattingEnabled = True
        Me.cmbOtv.Location = New System.Drawing.Point(153, 303)
        Me.cmbOtv.Name = "cmbOtv"
        Me.cmbOtv.Size = New System.Drawing.Size(323, 21)
        Me.cmbOtv.TabIndex = 45
        '
        'cmbStatus
        '
        Me.cmbStatus.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
        Me.cmbStatus.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.TableLayoutPanel1.SetColumnSpan(Me.cmbStatus, 3)
        Me.cmbStatus.FormattingEnabled = True
        Me.cmbStatus.Location = New System.Drawing.Point(153, 276)
        Me.cmbStatus.Name = "cmbStatus"
        Me.cmbStatus.Size = New System.Drawing.Size(323, 21)
        Me.cmbStatus.TabIndex = 44
        '
        'Label8
        '
        Me.Label8.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(3, 307)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(144, 13)
        Me.Label8.TabIndex = 43
        Me.Label8.Text = "Ответственный:"
        '
        'Label9
        '
        Me.Label9.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(3, 280)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(144, 13)
        Me.Label9.TabIndex = 42
        Me.Label9.Text = "Статус:"
        '
        'txtRem
        '
        Me.TableLayoutPanel1.SetColumnSpan(Me.txtRem, 3)
        Me.txtRem.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtRem.Location = New System.Drawing.Point(153, 161)
        Me.txtRem.Multiline = True
        Me.txtRem.Name = "txtRem"
        Me.txtRem.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtRem.Size = New System.Drawing.Size(326, 109)
        Me.txtRem.TabIndex = 41
        '
        'Label7
        '
        Me.Label7.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(3, 209)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(144, 13)
        Me.Label7.TabIndex = 40
        Me.Label7.Text = "Сообщение:"
        '
        'txtHead
        '
        Me.TableLayoutPanel1.SetColumnSpan(Me.txtHead, 3)
        Me.txtHead.Location = New System.Drawing.Point(153, 135)
        Me.txtHead.Name = "txtHead"
        Me.txtHead.Size = New System.Drawing.Size(320, 20)
        Me.txtHead.TabIndex = 39
        '
        'Label6
        '
        Me.Label6.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(3, 138)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(144, 13)
        Me.Label6.TabIndex = 38
        Me.Label6.Text = "Заголовок:"
        '
        'dtIsp
        '
        Me.dtIsp.Location = New System.Drawing.Point(153, 109)
        Me.dtIsp.Name = "dtIsp"
        Me.dtIsp.Size = New System.Drawing.Size(128, 20)
        Me.dtIsp.TabIndex = 37
        '
        'Label5
        '
        Me.Label5.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(3, 112)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(144, 13)
        Me.Label5.TabIndex = 36
        Me.Label5.Text = "Срок исполнения:"
        '
        'txtPhone
        '
        Me.txtPhone.Location = New System.Drawing.Point(153, 83)
        Me.txtPhone.Name = "txtPhone"
        Me.txtPhone.Size = New System.Drawing.Size(128, 20)
        Me.txtPhone.TabIndex = 35
        '
        'Label4
        '
        Me.Label4.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(3, 86)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(144, 13)
        Me.Label4.TabIndex = 34
        Me.Label4.Text = "Телефон:"
        '
        'dtReg
        '
        Me.dtReg.Location = New System.Drawing.Point(153, 57)
        Me.dtReg.Name = "dtReg"
        Me.dtReg.Size = New System.Drawing.Size(128, 20)
        Me.dtReg.TabIndex = 33
        '
        'Label3
        '
        Me.Label3.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(3, 60)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(144, 13)
        Me.Label3.TabIndex = 32
        Me.Label3.Text = "Дата регистрации:"
        '
        'cmbMast
        '
        Me.cmbMast.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
        Me.cmbMast.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.TableLayoutPanel1.SetColumnSpan(Me.cmbMast, 3)
        Me.cmbMast.FormattingEnabled = True
        Me.cmbMast.Location = New System.Drawing.Point(153, 30)
        Me.cmbMast.Name = "cmbMast"
        Me.cmbMast.Size = New System.Drawing.Size(323, 21)
        Me.cmbMast.TabIndex = 31
        '
        'cmbIst
        '
        Me.cmbIst.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
        Me.cmbIst.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.TableLayoutPanel1.SetColumnSpan(Me.cmbIst, 3)
        Me.cmbIst.FormattingEnabled = True
        Me.cmbIst.Location = New System.Drawing.Point(153, 3)
        Me.cmbIst.Name = "cmbIst"
        Me.cmbIst.Size = New System.Drawing.Size(323, 21)
        Me.cmbIst.TabIndex = 30
        '
        'Label2
        '
        Me.Label2.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(3, 34)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(144, 13)
        Me.Label2.TabIndex = 29
        Me.Label2.Text = "Мастер:"
        '
        'Label1
        '
        Me.Label1.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(3, 7)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(144, 13)
        Me.Label1.TabIndex = 28
        Me.Label1.Text = "Источник:"
        '
        'RemCashe
        '
        Me.RemCashe.Location = New System.Drawing.Point(346, 384)
        Me.RemCashe.Maximum = New Decimal(New Integer() {1000000, 0, 0, 0})
        Me.RemCashe.Name = "RemCashe"
        Me.RemCashe.Size = New System.Drawing.Size(120, 20)
        Me.RemCashe.TabIndex = 55
        '
        'Label13
        '
        Me.Label13.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(287, 387)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(53, 13)
        Me.Label13.TabIndex = 56
        Me.Label13.Text = "Затраты:"
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.AutoSize = True
        Me.TableLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.TableLayoutPanel1.ColumnCount = 4
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 150.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel1.Controls.Add(Me.Label1, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.RemCashe, 3, 11)
        Me.TableLayoutPanel1.Controls.Add(Me.cmbIst, 1, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.txtComent, 1, 12)
        Me.TableLayoutPanel1.Controls.Add(Me.Label2, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.Label12, 0, 12)
        Me.TableLayoutPanel1.Controls.Add(Me.cmbMast, 1, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.Label3, 0, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.dtReg, 1, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.Label4, 0, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.txtPhone, 1, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.cmbTip, 1, 10)
        Me.TableLayoutPanel1.Controls.Add(Me.Label5, 0, 4)
        Me.TableLayoutPanel1.Controls.Add(Me.Label10, 0, 10)
        Me.TableLayoutPanel1.Controls.Add(Me.cmbKrit, 1, 9)
        Me.TableLayoutPanel1.Controls.Add(Me.dtIsp, 1, 4)
        Me.TableLayoutPanel1.Controls.Add(Me.Label6, 0, 5)
        Me.TableLayoutPanel1.Controls.Add(Me.Label11, 0, 9)
        Me.TableLayoutPanel1.Controls.Add(Me.txtHead, 1, 5)
        Me.TableLayoutPanel1.Controls.Add(Me.cmbOtv, 1, 8)
        Me.TableLayoutPanel1.Controls.Add(Me.Label7, 0, 6)
        Me.TableLayoutPanel1.Controls.Add(Me.Label8, 0, 8)
        Me.TableLayoutPanel1.Controls.Add(Me.cmbStatus, 1, 7)
        Me.TableLayoutPanel1.Controls.Add(Me.txtRem, 1, 6)
        Me.TableLayoutPanel1.Controls.Add(Me.Label9, 0, 7)
        Me.TableLayoutPanel1.Controls.Add(Me.Label13, 2, 11)
        Me.TableLayoutPanel1.Controls.Add(Me.cmbAdd, 0, 16)
        Me.TableLayoutPanel1.Controls.Add(Me.cmbCancel, 1, 16)
        Me.TableLayoutPanel1.Controls.Add(Me.gbS, 0, 15)
        Me.TableLayoutPanel1.Controls.Add(Me.chkClose, 3, 16)
        Me.TableLayoutPanel1.Controls.Add(Me.lblWarant, 0, 11)
        Me.TableLayoutPanel1.Controls.Add(Me.dtGarRem, 1, 11)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 17
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
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(480, 670)
        Me.TableLayoutPanel1.TabIndex = 57
        '
        'gbS
        '
        Me.gbS.AutoSize = True
        Me.TableLayoutPanel1.SetColumnSpan(Me.gbS, 4)
        Me.gbS.Controls.Add(Me.lvRem2)
        Me.gbS.Dock = System.Windows.Forms.DockStyle.Fill
        Me.gbS.Location = New System.Drawing.Point(3, 484)
        Me.gbS.Name = "gbS"
        Me.gbS.Size = New System.Drawing.Size(476, 148)
        Me.gbS.TabIndex = 58
        Me.gbS.TabStop = False
        Me.gbS.Text = "События"
        Me.gbS.Visible = False
        '
        'lvRem2
        '
        Me.lvRem2.FullRowSelect = True
        Me.lvRem2.GridLines = True
        Me.lvRem2.Location = New System.Drawing.Point(0, 15)
        Me.lvRem2.MultiSelect = False
        Me.lvRem2.Name = "lvRem2"
        Me.lvRem2.ShowItemToolTips = True
        Me.lvRem2.Size = New System.Drawing.Size(470, 114)
        Me.lvRem2.TabIndex = 57
        Me.lvRem2.UseCompatibleStateImageBehavior = False
        Me.lvRem2.View = System.Windows.Forms.View.Details
        '
        'lblWarant
        '
        Me.lblWarant.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblWarant.AutoSize = True
        Me.lblWarant.Location = New System.Drawing.Point(3, 387)
        Me.lblWarant.Name = "lblWarant"
        Me.lblWarant.Size = New System.Drawing.Size(144, 13)
        Me.lblWarant.TabIndex = 59
        Me.lblWarant.Text = "Гарантия:"
        '
        'dtGarRem
        '
        Me.dtGarRem.Location = New System.Drawing.Point(153, 384)
        Me.dtGarRem.MaxDate = New Date(3000, 12, 31, 0, 0, 0, 0)
        Me.dtGarRem.MinDate = New Date(1992, 1, 1, 0, 0, 0, 0)
        Me.dtGarRem.Name = "dtGarRem"
        Me.dtGarRem.Size = New System.Drawing.Size(128, 20)
        Me.dtGarRem.TabIndex = 60
        Me.dtGarRem.Value = New Date(2013, 3, 5, 0, 0, 0, 0)
        '
        'CMServices
        '
        Me.CMServices.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DeleteService})
        Me.CMServices.Name = "CMServices"
        Me.CMServices.Size = New System.Drawing.Size(119, 26)
        '
        'DeleteService
        '
        Me.DeleteService.Name = "DeleteService"
        Me.DeleteService.Size = New System.Drawing.Size(118, 22)
        Me.DeleteService.Text = "Удалить"
        '
        'frmService_add
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.ClientSize = New System.Drawing.Size(480, 670)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "frmService_add"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Добавление (редактирование) заявки"
        CType(Me.RemCashe, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        Me.gbS.ResumeLayout(False)
        Me.CMServices.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cmbCancel As System.Windows.Forms.Button
    Friend WithEvents cmbAdd As System.Windows.Forms.Button
    Friend WithEvents txtComent As System.Windows.Forms.TextBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents chkClose As System.Windows.Forms.CheckBox
    Friend WithEvents cmbTip As System.Windows.Forms.ComboBox
    Friend WithEvents cmbKrit As System.Windows.Forms.ComboBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents cmbOtv As System.Windows.Forms.ComboBox
    Friend WithEvents cmbStatus As System.Windows.Forms.ComboBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents txtRem As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtHead As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents dtIsp As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtPhone As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents dtReg As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents cmbMast As System.Windows.Forms.ComboBox
    Friend WithEvents cmbIst As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents RemCashe As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents lvRem2 As System.Windows.Forms.ListView
    Friend WithEvents gbS As System.Windows.Forms.GroupBox
    Friend WithEvents lblWarant As System.Windows.Forms.Label
    Friend WithEvents dtGarRem As System.Windows.Forms.DateTimePicker
    Friend WithEvents CMServices As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents DeleteService As System.Windows.Forms.ToolStripMenuItem
End Class
