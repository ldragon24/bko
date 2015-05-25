<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSclad_ADD
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
        Me.nazvan = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.kol = New System.Windows.Forms.TextBox()
        Me.ost = New System.Windows.Forms.TextBox()
        Me.nomer_treb = New System.Windows.Forms.TextBox()
        Me.postavshik = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.prim = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.price = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.nomer_plat = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.garant = New System.Windows.Forms.DateTimePicker()
        Me.poluch = New System.Windows.Forms.DateTimePicker()
        Me.cena_nds = New System.Windows.Forms.TextBox()
        Me.cena_free = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.v_otdel = New System.Windows.Forms.ComboBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.add = New System.Windows.Forms.Button()
        Me.cancel = New System.Windows.Forms.Button()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(3, 7)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(164, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Наименование:"
        '
        'nazvan
        '
        Me.nazvan.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
        Me.nazvan.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.TableLayoutPanel1.SetColumnSpan(Me.nazvan, 2)
        Me.nazvan.Dock = System.Windows.Forms.DockStyle.Fill
        Me.nazvan.FormattingEnabled = True
        Me.nazvan.Location = New System.Drawing.Point(173, 3)
        Me.nazvan.Name = "nazvan"
        Me.nazvan.Size = New System.Drawing.Size(299, 21)
        Me.nazvan.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(3, 27)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(164, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Поступило:"
        '
        'Label3
        '
        Me.Label3.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(173, 27)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(164, 13)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Остаток:"
        '
        'Label4
        '
        Me.Label4.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(343, 27)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(129, 13)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Номер требования:"
        '
        'kol
        '
        Me.kol.Dock = System.Windows.Forms.DockStyle.Fill
        Me.kol.Location = New System.Drawing.Point(3, 43)
        Me.kol.Name = "kol"
        Me.kol.Size = New System.Drawing.Size(164, 20)
        Me.kol.TabIndex = 5
        '
        'ost
        '
        Me.ost.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ost.Location = New System.Drawing.Point(173, 43)
        Me.ost.Name = "ost"
        Me.ost.Size = New System.Drawing.Size(164, 20)
        Me.ost.TabIndex = 6
        '
        'nomer_treb
        '
        Me.nomer_treb.Dock = System.Windows.Forms.DockStyle.Fill
        Me.nomer_treb.Location = New System.Drawing.Point(343, 43)
        Me.nomer_treb.Name = "nomer_treb"
        Me.nomer_treb.Size = New System.Drawing.Size(129, 20)
        Me.nomer_treb.TabIndex = 7
        '
        'postavshik
        '
        Me.postavshik.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
        Me.postavshik.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.TableLayoutPanel1.SetColumnSpan(Me.postavshik, 2)
        Me.postavshik.Dock = System.Windows.Forms.DockStyle.Fill
        Me.postavshik.FormattingEnabled = True
        Me.postavshik.Location = New System.Drawing.Point(173, 69)
        Me.postavshik.Name = "postavshik"
        Me.postavshik.Size = New System.Drawing.Size(299, 21)
        Me.postavshik.TabIndex = 9
        '
        'Label5
        '
        Me.Label5.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(3, 73)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(164, 13)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "Поставщик:"
        '
        'prim
        '
        Me.TableLayoutPanel1.SetColumnSpan(Me.prim, 2)
        Me.prim.Dock = System.Windows.Forms.DockStyle.Fill
        Me.prim.Location = New System.Drawing.Point(173, 96)
        Me.prim.Multiline = True
        Me.prim.Name = "prim"
        Me.prim.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.prim.Size = New System.Drawing.Size(299, 125)
        Me.prim.TabIndex = 11
        '
        'Label6
        '
        Me.Label6.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(3, 152)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(164, 13)
        Me.Label6.TabIndex = 10
        Me.Label6.Text = "Примечание:"
        '
        'price
        '
        Me.price.Dock = System.Windows.Forms.DockStyle.Fill
        Me.price.Location = New System.Drawing.Point(3, 240)
        Me.price.Name = "price"
        Me.price.Size = New System.Drawing.Size(164, 20)
        Me.price.TabIndex = 13
        '
        'Label7
        '
        Me.Label7.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(3, 224)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(164, 13)
        Me.Label7.TabIndex = 12
        Me.Label7.Text = "Счёт:"
        '
        'nomer_plat
        '
        Me.nomer_plat.Dock = System.Windows.Forms.DockStyle.Fill
        Me.nomer_plat.Location = New System.Drawing.Point(173, 240)
        Me.nomer_plat.Name = "nomer_plat"
        Me.nomer_plat.Size = New System.Drawing.Size(164, 20)
        Me.nomer_plat.TabIndex = 15
        '
        'Label8
        '
        Me.Label8.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(173, 224)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(164, 13)
        Me.Label8.TabIndex = 14
        Me.Label8.Text = "№ Платежного поручения:"
        '
        'Label9
        '
        Me.Label9.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(173, 263)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(164, 13)
        Me.Label9.TabIndex = 17
        Me.Label9.Text = "Дата получения:"
        '
        'Label10
        '
        Me.Label10.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(3, 263)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(164, 13)
        Me.Label10.TabIndex = 16
        Me.Label10.Text = "Гарантия:"
        '
        'garant
        '
        Me.garant.Dock = System.Windows.Forms.DockStyle.Fill
        Me.garant.Location = New System.Drawing.Point(3, 279)
        Me.garant.Name = "garant"
        Me.garant.Size = New System.Drawing.Size(164, 20)
        Me.garant.TabIndex = 18
        '
        'poluch
        '
        Me.poluch.Dock = System.Windows.Forms.DockStyle.Fill
        Me.poluch.Location = New System.Drawing.Point(173, 279)
        Me.poluch.Name = "poluch"
        Me.poluch.Size = New System.Drawing.Size(164, 20)
        Me.poluch.TabIndex = 19
        '
        'cena_nds
        '
        Me.cena_nds.Dock = System.Windows.Forms.DockStyle.Fill
        Me.cena_nds.Location = New System.Drawing.Point(173, 318)
        Me.cena_nds.Name = "cena_nds"
        Me.cena_nds.Size = New System.Drawing.Size(164, 20)
        Me.cena_nds.TabIndex = 23
        '
        'cena_free
        '
        Me.cena_free.Dock = System.Windows.Forms.DockStyle.Fill
        Me.cena_free.Location = New System.Drawing.Point(3, 318)
        Me.cena_free.Name = "cena_free"
        Me.cena_free.Size = New System.Drawing.Size(164, 20)
        Me.cena_free.TabIndex = 22
        '
        'Label11
        '
        Me.Label11.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(173, 302)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(164, 13)
        Me.Label11.TabIndex = 21
        Me.Label11.Text = "Стоимость включая НДС:"
        '
        'Label12
        '
        Me.Label12.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(3, 302)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(164, 13)
        Me.Label12.TabIndex = 20
        Me.Label12.Text = "Цена еденицы без НДС:"
        '
        'v_otdel
        '
        Me.v_otdel.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
        Me.v_otdel.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.TableLayoutPanel1.SetColumnSpan(Me.v_otdel, 2)
        Me.v_otdel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.v_otdel.FormattingEnabled = True
        Me.v_otdel.Location = New System.Drawing.Point(173, 344)
        Me.v_otdel.Name = "v_otdel"
        Me.v_otdel.Size = New System.Drawing.Size(299, 21)
        Me.v_otdel.TabIndex = 25
        '
        'Label13
        '
        Me.Label13.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(3, 348)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(164, 13)
        Me.Label13.TabIndex = 24
        Me.Label13.Text = "Переведено в филиал:"
        '
        'add
        '
        Me.add.Location = New System.Drawing.Point(3, 371)
        Me.add.Name = "add"
        Me.add.Size = New System.Drawing.Size(75, 23)
        Me.add.TabIndex = 26
        Me.add.Text = "Добавить"
        Me.add.UseVisualStyleBackColor = True
        '
        'cancel
        '
        Me.cancel.Location = New System.Drawing.Point(173, 371)
        Me.cancel.Name = "cancel"
        Me.cancel.Size = New System.Drawing.Size(75, 23)
        Me.cancel.TabIndex = 27
        Me.cancel.Text = "Отмена"
        Me.cancel.UseVisualStyleBackColor = True
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 3
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel1.Controls.Add(Me.Label1, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.cancel, 1, 14)
        Me.TableLayoutPanel1.Controls.Add(Me.nazvan, 1, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.add, 0, 14)
        Me.TableLayoutPanel1.Controls.Add(Me.Label2, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.v_otdel, 1, 12)
        Me.TableLayoutPanel1.Controls.Add(Me.Label3, 1, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.Label13, 0, 12)
        Me.TableLayoutPanel1.Controls.Add(Me.Label4, 2, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.cena_nds, 1, 11)
        Me.TableLayoutPanel1.Controls.Add(Me.kol, 0, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.cena_free, 0, 11)
        Me.TableLayoutPanel1.Controls.Add(Me.ost, 1, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.Label11, 1, 10)
        Me.TableLayoutPanel1.Controls.Add(Me.nomer_treb, 2, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.Label12, 0, 10)
        Me.TableLayoutPanel1.Controls.Add(Me.postavshik, 1, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.poluch, 1, 9)
        Me.TableLayoutPanel1.Controls.Add(Me.Label5, 0, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.garant, 0, 9)
        Me.TableLayoutPanel1.Controls.Add(Me.Label6, 0, 4)
        Me.TableLayoutPanel1.Controls.Add(Me.Label9, 1, 8)
        Me.TableLayoutPanel1.Controls.Add(Me.prim, 1, 4)
        Me.TableLayoutPanel1.Controls.Add(Me.Label10, 0, 8)
        Me.TableLayoutPanel1.Controls.Add(Me.Label7, 0, 6)
        Me.TableLayoutPanel1.Controls.Add(Me.nomer_plat, 1, 7)
        Me.TableLayoutPanel1.Controls.Add(Me.Label8, 1, 6)
        Me.TableLayoutPanel1.Controls.Add(Me.price, 0, 7)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 15
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
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(475, 407)
        Me.TableLayoutPanel1.TabIndex = 28
        '
        'frmSclad_ADD
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.ClientSize = New System.Drawing.Size(475, 407)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "frmSclad_ADD"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Добавить (редактировать) на склад"
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents nazvan As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents kol As System.Windows.Forms.TextBox
    Friend WithEvents ost As System.Windows.Forms.TextBox
    Friend WithEvents nomer_treb As System.Windows.Forms.TextBox
    Friend WithEvents postavshik As System.Windows.Forms.ComboBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents prim As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents price As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents nomer_plat As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents garant As System.Windows.Forms.DateTimePicker
    Friend WithEvents poluch As System.Windows.Forms.DateTimePicker
    Friend WithEvents cena_nds As System.Windows.Forms.TextBox
    Friend WithEvents cena_free As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents v_otdel As System.Windows.Forms.ComboBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents add As System.Windows.Forms.Button
    Friend WithEvents cancel As System.Windows.Forms.Button
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
End Class
