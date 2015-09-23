Imports System.Windows.Forms
Imports System
Imports System.IO
Imports System.Drawing
Imports System.Collections
Imports System.ComponentModel
Imports System.Threading
Imports Ionic.Zip
Imports System.Net.Mail



Public Class frmMain
    Inherits System.Windows.Forms.Form
    Private Btn(500) As ToolStripButton
    Private Btn2(500) As ToolStripButton

    Private Sub frmMain_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Activated

        Me.Show()
        ' My.Application.DoEvents()

        If unamDB <> "MS Access" And unamDB <> "MS Access 2007" Then ArhToolZipbutton.Enabled = False

        Call SECUR_LEVEL()

    End Sub

    Private Sub frmMain_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed

        UnLoadDatabase()

        If unamDB <> "MS Access" Or unamDB <> "MS Access 2007" Then Exit Sub

        Dim objIniFile As New IniFile(PrPath & "base.ini")

        Dim uname As String
        uname = objIniFile.GetString("general", "ARHIVATOR", 0)

        Select Case uname

            Case "1"

                Dim dirs As String
                Dim sFIleName As String
                dirs = BasePath
                sFIleName = PrPath & "arhiv\" & GENID() & "_" & Date.Today & "_" & My.Application.Info.Version.Major & "." & My.Application.Info.Version.Minor & "." & My.Application.Info.Version.Build & "." & My.Application.Info.Version.Revision & ".zip"

                Try
                    Using zip1 As ZipFile = New ZipFile
                        zip1.AddDirectory(dirs)
                        zip1.Save(sFIleName)
                    End Using
                Catch exc1 As Exception
                    MessageBox.Show(String.Format("Исключение при сжатии: {0}", exc1.Message))
                End Try

        End Select

    End Sub

    Private Sub SendFonts_1()
        SendFonts(Me)
    End Sub

    Private Sub load_ICONS()

        On Error Resume Next

        ToolStripDropDownButton1.Image = New System.Drawing.Bitmap(PrPath & "pic\iface\new.png")
        NewToolStripButton.Image = New System.Drawing.Bitmap(PrPath & "pic\iface\find.png")
        SaveInfTehButton.Image = New System.Drawing.Bitmap(PrPath & "pic\iface\save.png")
        ArhToolZipbutton.Image = New System.Drawing.Bitmap(PrPath & "pic\iface\zip.png")
        ToolStripButton1.Image = New System.Drawing.Bitmap(PrPath & "pic\iface\report.png")


        NewToolStripMenuItem.Image = New System.Drawing.Bitmap(PrPath & "pic\iface\setup.png")
        ПроверитьОбновлениеToolStripMenuItem.Image = New System.Drawing.Bitmap(PrPath & "pic\iface\update.png")
        MailToAuthors.Image = New System.Drawing.Bitmap(PrPath & "pic\iface\Mail.png")
        ФорумToolStripMenuItem.Image = New System.Drawing.Bitmap(PrPath & "pic\iface\forum.png")
        BugTrackerToolStripMenuItem.Image = New System.Drawing.Bitmap(PrPath & "pic\iface\bug.png")
        ExitToolStripMenuItem.Image = New System.Drawing.Bitmap(PrPath & "pic\iface\exit.png")

        СправочникиОборудованияToolStripMenuItem.Image = New System.Drawing.Bitmap(PrPath & "pic\iface\direct.png")
        ОрганизацияToolStripMenuItem.Image = New System.Drawing.Bitmap(PrPath & "pic\iface\org.png")
        БланкиToolStripMenuItem.Image = New System.Drawing.Bitmap(PrPath & "pic\iface\blank.png")
        ЖурналыПрограммыToolStripMenuItem.Image = New System.Drawing.Bitmap(PrPath & "pic\iface\log.png")
        АктытребованияToolStripMenuItem.Image = New System.Drawing.Bitmap(PrPath & "pic\iface\akt.png")
        ИнвентаризацияToolStripMenuItem.Image = New System.Drawing.Bitmap(PrPath & "pic\iface\invent.png")
        OptionsToolStripMenuItem.Image = New System.Drawing.Bitmap(PrPath & "pic\iface\notes.png")
        ОбслуживаниеБДToolStripMenuItem.Image = New System.Drawing.Bitmap(PrPath & "pic\iface\database.png")
    End Sub

    Public Sub LOAD_COMPONENT()

        LBL_STAT_1.Text = ""
        LBL_STAT_3.Text = ""
        lblShed.Text = ""
        lblRem.Text = ""
        LBL_SUBD.Text = ""
        DB_USE.Text = ""
        LBL_USER.Text = ""

        LBL_STAT_1.ForeColor = OptionsToolStripMenuItem.ForeColor
        LBL_STAT_3.ForeColor = OptionsToolStripMenuItem.ForeColor
        lblShed.ForeColor = OptionsToolStripMenuItem.ForeColor
        lblRem.ForeColor = OptionsToolStripMenuItem.ForeColor
        LBL_SUBD.ForeColor = OptionsToolStripMenuItem.ForeColor
        DB_USE.ForeColor = OptionsToolStripMenuItem.ForeColor
        LBL_USER.ForeColor = OptionsToolStripMenuItem.ForeColor

        Select Case DB_N

            Case "MS Access"

                DB_USE.Text = Base_Name
                LBL_SUBD.Visible = False

                DB_USE.DropDown.Items.Clear()

                Dim dirs As String() = Directory.GetFiles(BasePath, "*.mdb")
                Dim dir As String

                Dim B1 As New ToolStripButton
                Dim i As Integer = 0
                Dim sNameS(500) As String

                For Each dir In dirs

                    Dim d() As String
                    d = Split(dir, "\")
                    sNameS(i) = d(d.Length - 1)

                    i = i + 1
                Next

                For i1 As Integer = 0 To i
                    Dim B As New ToolStripButton

                    B.ForeColor = Color.Blue
                    B.Text = sNameS(i1)
                    Btn(i1) = B

                    AddHandler Btn(i1).Click, AddressOf DbButtonsClick
                    DB_USE.DropDown.Items.AddRange(New ToolStripItem() {Btn(i1)})
                Next

                DB_USE.Text = Base_Name

            Case "MS Access 2007"

                DB_USE.Text = Base_Name
                LBL_SUBD.Visible = False

                DB_USE.DropDown.Items.Clear()

                Dim dirs As String() = Directory.GetFiles(BasePath, "*.accdb")
                Dim dir As String

                Dim B1 As New ToolStripButton
                Dim i As Integer = 0
                Dim sNameS(500) As String

                For Each dir In dirs

                    Dim d() As String
                    d = Split(dir, "\")
                    sNameS(i) = d(d.Length - 1)

                    i = i + 1
                Next

                For i1 As Integer = 0 To i
                    Dim B As New ToolStripButton

                    B.ForeColor = Color.Blue
                    B.Text = sNameS(i1)
                    Btn(i1) = B

                    AddHandler Btn(i1).Click, AddressOf DbButtonsClick
                    DB_USE.DropDown.Items.AddRange(New ToolStripItem() {Btn(i1)})
                Next

                DB_USE.Text = Base_Name

            Case Else
                LBL_SUBD.Visible = True
                DB_USE.Visible = False

        End Select

        ''Меняем шрифт
        Call SendFonts(Me)
        'Загружаем иконки
        Me.BeginInvoke(New MethodInvoker(AddressOf load_ICONS))
        Call Tree_Icons_Feel(frmComputers.ilsCommands, "sCMP", "pic\tree\")

        'Наименование программы 
        Dim rsG As ADODB.Recordset
        rsG = New ADODB.Recordset

        rsG.Open("SELECT Name_Prog FROM CONFIGURE", DB7, ADODB.CursorTypeEnum.adOpenDynamic, ADODB.LockTypeEnum.adLockOptimistic)

        With rsG
            If Not IsDBNull(.Fields("Name_Prog").Value) Then ProGramName = .Fields("Name_Prog").Value
        End With
        rsG.Close()
        rsG = Nothing

        If Len(ProGramName) = 0 Or ProGramName = Nothing Then ProGramName = "BKO.NET"

        Me.Text = ProGramName & " " & My.Application.Info.Version.Major & "." & My.Application.Info.Version.Minor & "." & My.Application.Info.Version.Build & "." & My.Application.Info.Version.Revision

        'Напоминания есть или нет
        Me.BeginInvoke(New MethodInvoker(AddressOf SHED_CHECK))

        'Ремонты есть или нет
        Me.BeginInvoke(New MethodInvoker(AddressOf REM_CHECK))

        '###########################################################

        'Добавляем в меню добавления техники другое оборудование

        Dim sCountOTH As Integer
        rsG = New ADODB.Recordset
        rsG.Open("SELECT count(*) as T_N FROM spr_other", DB7, ADODB.CursorTypeEnum.adOpenDynamic, ADODB.LockTypeEnum.adLockOptimistic)

        With rsG
            sCountOTH = .Fields("T_N").Value
        End With
        rsG.Close()
        rsG = Nothing

        Select Case sCountOTH

            Case 0

            Case Else

                Dim rs As ADODB.Recordset 'Объявляем рекордсет
                Dim sSQL As String 'Переменная, где будет размещён SQL запрос
                sSQL = "SELECT name FROM spr_other"

                Dim sNameZ(sCountOTH) As String

                rs = New ADODB.Recordset
                rs.Open(sSQL, DB7, ADODB.CursorTypeEnum.adOpenDynamic, ADODB.LockTypeEnum.adLockOptimistic)
                Dim iz As Integer = 0

                With rs
                    .MoveFirst()
                    Do While Not .EOF
                        sNameZ(iz) = .Fields("name").Value
                        iz = iz + 1
                        .MoveNext()
                    Loop
                End With
                rs.Close()
                rs = Nothing

                For i As Integer = 0 To sCountOTH
                    Dim B As New ToolStripButton

                    B.ForeColor = Color.Blue
                    B.Text = sNameZ(i)
                    Btn(i) = B

                    AddHandler Btn(i).Click, AddressOf colorButtonsClick
                    ДругоеОборудованиеToolStripMenuItem.DropDown.Items.AddRange(New ToolStripItem() {Btn(i)})
                Next

        End Select

        Select Case unamDB

            Case "MS Access"
                LBL_SUBD.Text = unamDB & " - " & Base_Name
            Case "MS Access 2007"
                LBL_SUBD.Text = unamDB & " - " & Base_Name
            Case Else
                LBL_SUBD.Text = unamDB & " - " & DBtabl

        End Select

        LBL_USER.Text = UserNames & "/" & uLevel

    End Sub


    Private Sub frmMain_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        Me.BeginInvoke(New MethodInvoker(AddressOf LOAD_COMPONENT))

        Me.BeginInvoke(New MethodInvoker(AddressOf LANG_frmMain))

        Dim sText As String

        'Определяем путь до файла настроек
        Dim objIniFile As New IniFile(PrPath & "base.ini")

        'На полный экран или нет
        sText = objIniFile.GetString("General", "FullScreen", "0")

        Select Case sText

            Case "1"

                Me.WindowState = 2

            Case "0"

                Me.WindowState = 0

        End Select

        'Показывать меню системные или нет
        sText = objIniFile.GetString("general", "SYS", 0)

        Select Case sText

            Case 0

                Me.CleerDBToolStripMenuItem.Visible = False
                Me.ЗапросыToolStripMenuItem.Visible = False

            Case 1

                Me.CleerDBToolStripMenuItem.Visible = True
                Me.ЗапросыToolStripMenuItem.Visible = True

        End Select

        sText = objIniFile.GetString("general", "IMAGE_TEXT", 1)

        Select Case sText

            Case 0

                Me.LabelPanelToolStripMenuItem.Checked = False
                ToolStripDropDownButton1.DisplayStyle = ToolStripItemDisplayStyle.Image
                NewToolStripButton.DisplayStyle = ToolStripItemDisplayStyle.Image
                SaveInfTehButton.DisplayStyle = ToolStripItemDisplayStyle.Image
                ArhToolZipbutton.DisplayStyle = ToolStripItemDisplayStyle.Image
                ToolStripButton1.DisplayStyle = ToolStripItemDisplayStyle.Image
            Case 1

                Me.LabelPanelToolStripMenuItem.Checked = True
                ToolStripDropDownButton1.DisplayStyle = ToolStripItemDisplayStyle.ImageAndText
                NewToolStripButton.DisplayStyle = ToolStripItemDisplayStyle.ImageAndText
                SaveInfTehButton.DisplayStyle = ToolStripItemDisplayStyle.ImageAndText
                ArhToolZipbutton.DisplayStyle = ToolStripItemDisplayStyle.ImageAndText
                ToolStripButton1.DisplayStyle = ToolStripItemDisplayStyle.ImageAndText
        End Select

        sText = objIniFile.GetString("general", "StatusStrip", 1)

        Select Case sText

            Case 0

                Me.StatusBarToolStripMenuItem.Checked = False

            Case 1

                Me.StatusBarToolStripMenuItem.Checked = True

        End Select
        Me.StatusStrip.Visible = Me.StatusBarToolStripMenuItem.Checked

        sText = objIniFile.GetString("general", "ToolStrip", 1)

        Select Case sText

            Case 0

                Me.ToolBarToolStripMenuItem.Checked = False

            Case 1

                Me.ToolBarToolStripMenuItem.Checked = True

        End Select
        Me.ToolStrip.Visible = Me.ToolBarToolStripMenuItem.Checked

        'Какой модуль запускать
        sText = objIniFile.GetString("general", "MOD", 0)

        If Len(sText) > 2 Then sText = 0

        Select Case sText

            Case 0

                'frmComputers.Visible = False
                frmComputers.MdiParent = Me
                ' My.Application.DoEvents()
                frmComputers.Show()
                ' My.Application.DoEvents()

            Case 1
                frmserviceDesc.MdiParent = Me
                ' My.Application.DoEvents()
                frmserviceDesc.Show()
                ' My.Application.DoEvents()
            Case 2

                frmSoftware.MdiParent = Me
                '  My.Application.DoEvents()
                frmSoftware.Show()
                '  My.Application.DoEvents()
            Case 3

                frmCRT3.MdiParent = Me
                '  My.Application.DoEvents()
                frmCRT3.Show()
                '   My.Application.DoEvents()
        End Select

        'Запускаем таймер

        Dim t As New System.Windows.Forms.Timer
        t.Interval = 1000
        t.Enabled = True
        AddHandler t.Tick, AddressOf TimerEventHandler

        Select Case lblShed.Visible

            Case False
                lblSplet.Visible = False

        End Select

        Select Case lblRem.Visible

            Case False
                ToolStripStatusLabel4.Visible = False

        End Select

        '###################################################################3

        Exit Sub
err_:
        'MsgBox(Err.Description)

        '###################################################################3

    End Sub



    Public Sub DbButtonsClick(ByVal sender As [Object], ByVal e As EventArgs)

        Dim senderButton As ToolStripButton = CType(sender, ToolStripButton)

        DB_USE.Text = senderButton.Text

        Me.Cursor = Cursors.Hand

        Base_Name = senderButton.Text

        Dim objIniFile As New IniFile(PrPath & "base.ini")
        objIniFile.WriteString("general", "file", DB_USE.Text)

        Call RELOGIN()

        Exit Sub

    End Sub

    Public Sub colorButtonsClick(ByVal sender As [Object], ByVal e As EventArgs)
        Dim senderButton As ToolStripButton = CType(sender, ToolStripButton)
        'Me.ForeColor = senderButton.ForeColor

        Call ClearForm(frmComputers)

        frmComputers.cmbOTH.Items.Clear()

        FillComboNET(frmComputers.cmbOTH, "name", "SPR_OTH_DEV", "", False, True)
        FillComboNET(frmComputers.cmbOTHConnect, "name", "spr_other", "", False, True)
        frmComputers.lblTipOther.Visible = True
        frmComputers.cmbOTHConnect.Visible = True

        frmComputers.cmbOTHConnect.Text = senderButton.Text

        frmComputers.lblOTMac.Visible = True
        frmComputers.lblOtIp.Visible = True
        frmComputers.txtOTHIP.Visible = True
        frmComputers.txtOTHMAC.Visible = True

        frmComputers.sSTAB3.Visible = True
        frmComputers.sSTAB1.Visible = False
        frmComputers.sSTAB2.Visible = False
        frmComputers.sSTAB4.Visible = False
        frmComputers.sSTAB5.Visible = False
        TipTehn = "OT"
        frmComputers.EDT = False

        frmComputers.selectTECMesto()
        frmComputers.cmbOTHFil.Text = sBranch
        frmComputers.cmbOTHDepart.Text = sDepartment
        frmComputers.cmbOTHOffice.Text = sOffice

        frmComputers.lblOTPCL.Visible = True
        frmComputers.cmbOTHPCL.Visible = True

        Call LOAD_PCL(frmComputers.cmbOTHFil.Text, frmComputers.cmbOTHDepart.Text, frmComputers.cmbOTHOffice.Text, frmComputers.cmbOTHPCL, frmComputers.cmbOTHotv.Text, frmComputers.sCOUNT)

    End Sub

    Private Sub frmMain_Resize(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MyBase.Resize

        On Error GoTo error_Renamed

        If (Me.Height) < 750 Then Me.Height = 750
        If (Me.Width) < 1024 Then Me.Width = 1024

        Exit Sub
error_Renamed:
        Me.Height = 750
        Me.Width = 1024
    End Sub

    Private Sub ExitToolsStripMenuItem_Click_1(ByVal sender As Object, ByVal e As EventArgs)
        Me.Close()
    End Sub

    Private Sub ToolBarToolStripMenuItem_Click_1(ByVal sender As Object, ByVal e As EventArgs)
        Me.ToolStrip.Visible = Me.ToolBarToolStripMenuItem.Checked
    End Sub

    Private Sub StatusBarToolStripMenuItem_Click_1(ByVal sender As Object, ByVal e As EventArgs)
        Me.StatusStrip.Visible = Me.StatusBarToolStripMenuItem.Checked
    End Sub

    Private Sub CloseAllToolStripMenuItem_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CloseAllToolStripMenuItem.Click
        For Each ChildForm As Form In Me.MdiChildren
            ChildForm.Close()
        Next
    End Sub

    Private Sub FrmComputersMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FrmComputersMenuItem.Click
        If sRelogin = True Then Exit Sub

        If DATAB = False Then Exit Sub

        frmComputers.MdiParent = Me
        frmComputers.Show()
        frmComputers.Focus()

    End Sub

    Private Sub CascadeToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CascadeToolStripMenuItem.Click
        Me.LayoutMdi(MdiLayout.Cascade)
    End Sub

    Private Sub СправочникиОборудованияToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles СправочникиОборудованияToolStripMenuItem.Click
        If sRelogin = True Then Exit Sub
        If DATAB = False Then Exit Sub

        frmDirectory.MdiParent = Me
        frmDirectory.Show()
        frmDirectory.Focus()
    End Sub

    Private Sub ToolBarToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolBarToolStripMenuItem.Click
        Dim objIniFile As New IniFile(PrPath & "base.ini")

        Me.ToolStrip.Visible = Me.ToolBarToolStripMenuItem.Checked

        Select Case Me.ToolBarToolStripMenuItem.Checked

            Case True

                objIniFile.WriteString("General", "ToolStrip", 1)

            Case False

                objIniFile.WriteString("General", "ToolStrip", 0)

        End Select

    End Sub

    Private Sub StatusBarToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles StatusBarToolStripMenuItem.Click
        Dim objIniFile As New IniFile(PrPath & "base.ini")

        Me.StatusStrip.Visible = Me.StatusBarToolStripMenuItem.Checked

        Select Case Me.StatusBarToolStripMenuItem.Checked

            Case True

                objIniFile.WriteString("General", "StatusStrip", 1)

            Case False

                objIniFile.WriteString("General", "StatusStrip", 0)

        End Select

    End Sub

    Private Sub TileVerticalToolStripMenuItem_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TileVerticalToolStripMenuItem.Click
        Me.LayoutMdi(MdiLayout.TileVertical)
    End Sub

    Private Sub TileHorizontalToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TileHorizontalToolStripMenuItem.Click
        Me.LayoutMdi(MdiLayout.TileHorizontal)
    End Sub

    Private Sub ArrangeIconsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ArrangeIconsToolStripMenuItem.Click
        Me.LayoutMdi(MdiLayout.ArrangeIcons)
    End Sub

    Private Sub ExitToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExitToolStripMenuItem.Click

        Call UnLoadDatabase()
        'End

    End Sub

    Private Sub УчётЗаявокремонтовToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles УчётЗаявокремонтовToolStripMenuItem.Click
        If sRelogin = True Then Exit Sub

        If DATAB = False Then Exit Sub

        frmserviceDesc.MdiParent = Me
        frmserviceDesc.Show()
        frmserviceDesc.Focus()
    End Sub

    Private Sub HelpMenu_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles HelpMenu.Click
        frmAbout.ShowDialog(Me)
    End Sub

    Private Sub УчётПрограммногоОбеспеченияToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles УчётПрограммногоОбеспеченияToolStripMenuItem.Click
        If sRelogin = True Then Exit Sub

        If DATAB = False Then Exit Sub
        frmSoftware.MdiParent = Me
        frmSoftware.Show()
        frmSoftware.Focus()
    End Sub

    Private Sub HelpToolStripButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        frmARHIV.ShowDialog(Me)
    End Sub

    Private Sub CleerDBToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CleerDBToolStripMenuItem.Click

        If DATAB = False Then Exit Sub

        If MsgBox("Будет очищена база" & vbCrLf & "Хотите продолжить?", MsgBoxStyle.YesNo, ProGramName) = MsgBoxResult.Yes Then

            'On Error GoTo error
            On Error Resume Next

            DB7.Execute("DELETE FROM T_Log")
            DB7.Execute("DELETE FROM Garantia_sis")
            DB7.Execute("DELETE FROM garant_comp")
            DB7.Execute("DELETE FROM SPR_Master")
            DB7.Execute("DELETE FROM remonty_plus")
            DB7.Execute("DELETE FROM Remont")
            DB7.Execute("DELETE FROM SOFT_INSTALL")
            DB7.Execute("DELETE FROM Zametki")
            DB7.Execute("DELETE FROM Update_Log")
            DB7.Execute("DELETE FROM USER_COMP")
            DB7.Execute("DELETE FROM tbl_bios")
            DB7.Execute("DELETE FROM CARTRIDG_Z")
            DB7.Execute("DELETE FROM CARTRIDG_D")
            DB7.Execute("DELETE FROM CARTRIDG")
            DB7.Execute("DELETE FROM AKT_SP_OS3")
            DB7.Execute("DELETE FROM ActOS")
            DB7.Execute("DELETE FROM TrebOvanie")
            DB7.Execute("DELETE FROM dvig")
            DB7.Execute("DELETE FROM SES_Pass")
            DB7.Execute("DELETE FROM ZAM_OTD")
            DB7.Execute("DELETE FROM OTD_O")
            DB7.Execute("DELETE FROM SPR_OTV")
            DB7.Execute("DELETE FROM SPR_KAB")
            DB7.Execute("DELETE FROM SPR_OTD_FILIAL")
            DB7.Execute("DELETE FROM SPR_MESTO")
            DB7.Execute("DELETE FROM SPR_FILIAL")
            DB7.Execute("DELETE FROM Sclad")
            DB7.Execute("DELETE FROM Sheduler")
            DB7.Execute("DELETE FROM net_port")
            DB7.Execute("DELETE FROM tbl_ppr")
            DB7.Execute("DELETE FROM kompy")
            DB7.Execute("DELETE FROM SPR_USER")
            DB7.Execute("DELETE FROM TBL_NET_MAG")


            Call frmComputers.STAT_INF()
            Call SHED_CHECK()
            Call REM_CHECK()
            Call COMPARE_DB()
            Call LoadSPR()

            RefFilTree(frmComputers.lstGroups)

            Dim LNGIniFile As New IniFile(sLANGPATH)

            MsgBox(LNGIniFile.GetString("frmMain", "MSG4", "Очистка базы завершено успешно!"), MsgBoxStyle.Information)
        End If

        Exit Sub
Error_:
        Debug.Print(Err.Description)

    End Sub

    Private Sub CompareDBToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CompareDBToolStripMenuItem.Click

        If DATAB = False Then Exit Sub

        Call COMPARE_DB()

    End Sub

    Public Sub COMPARE_DB()
        On Error GoTo err_
        Dim LNGIniFile As New IniFile(sLANGPATH)


        Select Case DB_N

            Case "MS Access"

                UnLoadDatabase()
                Dim sBname As String
                sBname = "temp_" & Base_Name

                Dim JRO As JRO.JetEngine
                JRO = New JRO.JetEngine
                JRO.CompactDatabase("Provider=Microsoft.Jet.OLEDB.4.0;" & "Data Source=" & BasePath & Base_Name, "Provider=Microsoft.Jet.OLEDB.4.0;" & "Data Source=" & BasePath & sBname & ";Jet OLEDB:Engine Type=5")
                Kill(BasePath & Base_Name)
                Rename(BasePath & sBname, BasePath & Base_Name)
                LoadDatabase()

            Case Else

        End Select

        Exit Sub
err_:
        MsgBox(Err.Description, MsgBoxStyle.Information, ProGramName)
        LoadDatabase()

    End Sub

    Private Sub УчётКартриджейToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles УчётКартриджейToolStripMenuItem.Click
        If sRelogin = True Then Exit Sub

        If DATAB = False Then Exit Sub

        Dim Counter As Decimal
        Dim rs As ADODB.Recordset
        rs = New ADODB.Recordset
        rs.Open("SELECT COUNT(*) AS total_number FROM kompy where tiptehn = 'Printer'", DB7, ADODB.CursorTypeEnum.adOpenDynamic, ADODB.LockTypeEnum.adLockOptimistic)

        With rs
            Counter = .Fields("total_number").Value
        End With
        rs.Close()
        rs = Nothing

        rs = New ADODB.Recordset
        rs.Open("SELECT COUNT(*) AS total_number FROM kompy where tiptehn = 'KOpir'", DB7, ADODB.CursorTypeEnum.adOpenDynamic, ADODB.LockTypeEnum.adLockOptimistic)

        With rs
            Counter = Counter + .Fields("total_number").Value
        End With
        rs.Close()
        rs = Nothing

        rs = New ADODB.Recordset
        rs.Open("SELECT COUNT(*) AS total_number FROM kompy where tiptehn = 'MFU'", DB7, ADODB.CursorTypeEnum.adOpenDynamic, ADODB.LockTypeEnum.adLockOptimistic)

        With rs
            Counter = Counter + .Fields("total_number").Value
        End With
        rs.Close()
        rs = Nothing


        rs = New ADODB.Recordset
        rs.Open("SELECT COUNT(*) AS total_number FROM kompy where tiptehn = 'FAX'", DB7, ADODB.CursorTypeEnum.adOpenDynamic, ADODB.LockTypeEnum.adLockOptimistic)

        With rs
            Counter = Counter + .Fields("total_number").Value
        End With
        rs.Close()
        rs = Nothing

        If Counter = 0 Then
            MsgBox("Печатающих устройств не обнаружено!", MsgBoxStyle.Information, ProGramName)
            Exit Sub
        End If

        frmCRT3.MdiParent = Me
        frmCRT3.Show()
        frmCRT3.Focus()
    End Sub

    Private Sub СкладToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles СкладToolStripMenuItem.Click

        If sRelogin = True Then Exit Sub

        If DATAB = False Then Exit Sub

        frmSclad.MdiParent = Me
        frmSclad.Show()
        frmSclad.Focus()
    End Sub

    Private Sub ЖурналыПрограммыToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ЖурналыПрограммыToolStripMenuItem.Click

        If sRelogin = True Then Exit Sub
        If DATAB = False Then Exit Sub

        frmLOG.MdiParent = Me
        frmLOG.Show()
        frmLOG.Focus()
    End Sub

    Private Sub ФорумToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ФорумToolStripMenuItem.Click

        System.Diagnostics.Process.Start("http://bko.shatki.info/forum/")

    End Sub

    Private Sub BugTrackerToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BugTrackerToolStripMenuItem.Click
        System.Diagnostics.Process.Start("http://code.google.com/p/bko/issues/list")
    End Sub

    Private Sub MailToAuthors_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MailToAuthors.Click

        Dim Subject As String
        Dim Body As String

        Dim bAns As Boolean = True
        Dim sParams As String

        Subject = "БКО " & My.Application.Info.Version.Major & "." & My.Application.Info.Version.Minor & "." & My.Application.Info.Version.Build & "." & My.Application.Info.Version.Revision
        sParams = "ldragon24@gmail.com"
        Body = "Здравствуйте Алексей, " & vbCrLf
        If LCase(Strings.Left(sParams, 7)) <> "mailto:" Then _
            sParams = "mailto:" & sParams

        If Subject <> "" Then sParams = sParams & _
              "?subject=" & Subject

        If Body <> "" Then
            sParams = sParams & IIf(Subject = "", "?", "&")
            sParams = sParams & "body=" & Body
        End If

        Try

            System.Diagnostics.Process.Start(sParams)

        Catch
            bAns = False
        End Try

        'Return bAns

    End Sub

    Private Sub ПаспортКомпьютераToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ПаспортКомпьютераToolStripMenuItem.Click

        If TipTehn <> "PC" Then Exit Sub

        Select Case frmComputers.sPREF

            Case "C"

                Select Case sOfficePACK

                    Case "OpenOffice.org"

                        Call OOO_SEND_PK(frmComputers.sCOUNT)

                    Case Else

                        Call WRD_SEND_PK(frmComputers.sCOUNT)
                End Select

            Case Else

                Exit Sub

        End Select

    End Sub

    Private Sub АктытребованияToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles АктытребованияToolStripMenuItem.Click
        If sRelogin = True Then Exit Sub
        If DATAB = False Then Exit Sub

        Select Case frmComputers.sPREF

            Case "C"

                frmAct_Treb.MdiParent = Me
                frmAct_Treb.Show()
                frmAct_Treb.Focus()

            Case Else

                Exit Sub

        End Select

    End Sub

    Private Sub OptionsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OptionsToolStripMenuItem.Click

        If sRelogin = True Then Exit Sub
        If DATAB = False Then Exit Sub

        frmSheduler.MdiParent = Me
        frmSheduler.Show()
        frmSheduler.Focus()
    End Sub

    Private Sub lblShed_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles lblShed.DoubleClick

        If sRelogin = True Then Exit Sub

        frmSheduler.MdiParent = Me
        frmSheduler.Show()
        frmSheduler.Focus()
    End Sub

    Private Sub lblRem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblRem.Click

        If sRelogin = True Then Exit Sub

        frmserviceDesc.MdiParent = Me
        frmserviceDesc.Show()
        frmserviceDesc.Focus()
    End Sub

    Private Sub ЗапросыToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ЗапросыToolStripMenuItem.Click

        If DATAB = False Then Exit Sub

        frmSQL.MdiParent = Me
        frmSQL.Show()
        frmSQL.Focus()
    End Sub

    Private Sub ОрганизацияToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ОрганизацияToolStripMenuItem.Click
        If sRelogin = True Then Exit Sub
        If DATAB = False Then Exit Sub

        frmSetup.SStab1.SelectedTab = frmSetup.SStab1.TabPages("TabPage3")
        frmSetup.MdiParent = Me
        frmSetup.Show()
        frmSetup.Focus()
    End Sub

    Private Sub ПроверитьОбновлениеToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ПроверитьОбновлениеToolStripMenuItem.Click

        System.Diagnostics.Process.Start("http://code.google.com/p/bko/downloads/list")

        'Dim reader As XmlNodeReader = Nothing

        'Dim iA, iB, iC As String


        'Try
        '    Dim s As String = ""
        '    ' The xml document to read from.
        '    Dim doc As New XmlDocument()

        '    ' Load the xml document.
        '    doc.Load("http://bko.shatki.info/bko.xml")

        '    ' Set the reader to open the xml document.
        '    reader = New XmlNodeReader(doc)

        '    ' Read all the data in the XML document and display it.
        '    While reader.Read()
        '        Select Case reader.NodeType
        '            Case XmlNodeType.Element
        '                ' Keep track of the element that the user is on.
        '                s = reader.Name
        '            Case XmlNodeType.Text
        '                If s.Equals("version") Then
        '                    ' With the first name add a line to the listview control.
        '                    iA = (reader.Value)
        '                    ' For all other data itmes in the list just add
        '                    ' as sub itmes since they are in the correct order.
        '                Else

        '                    iB = (reader.Value)

        '                End If
        '        End Select
        '    End While
        'Finally
        '    ' Do the necessary clean up.
        '    If Not (reader Is Nothing) Then
        '        reader.Close()
        '    End If
        'End Try

        'iC = My.Application.Info.Version.Major & "." & My.Application.Info.Version.Minor & "." & My.Application.Info.Version.Build & "." & My.Application.Info.Version.Revision

        'If iA > iC Then

        '    Dim LNGIniFile As New IniFile(sLANGPATH)
        '    If MsgBox(LNGIniFile.GetString("frmMain", "MSG7", "") & " " & iA & vbCrLf & iB & vbCrLf & LNGIniFile.GetString("frmMain", "MSG8", ""), ProGramName, MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
        '        System.Diagnostics.Process.Start("http://code.google/p/bko/downloads/list")

        '    Else

        '    End If


        '    '"На сервере появилась новая версия программы - " & " " & xmlNode.childNodes(0).Text & ". Открыть страницу загрузки?" & vbNewLine & "Изменения:" & vbNewLine & xmlNode.childNodes(2).Text
        'End If


    End Sub

    Private Sub МойБланкToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles МойБланкToolStripMenuItem.Click

        Dim sTMP As String
        Dim ePatch As String


        ePatch = Directory.GetParent(Application.ExecutablePath).ToString & "\blanks"

        Dim fdlg As OpenFileDialog = New OpenFileDialog()
        Dim LNGIniFile As New IniFile(sLANGPATH)

        fdlg.Title = LNGIniFile.GetString("frmMain", "MSG9", "Шаблоны бланков")
        fdlg.InitialDirectory = ePatch
        fdlg.Filter = "Шаблоны документов MS Word(*.dot)|*.dot|Документы MS Word(*.doc)|*.doc"

        'fdlg.Filter = "All files (*.*)|*.*|Access Database(*.mdb) files (*.mdb)|*.mdb" ;
        '"Шаблоны Microsoft Word (*.doc)|*.doc"
        fdlg.FilterIndex = 2

        fdlg.RestoreDirectory = True

        If fdlg.ShowDialog() = DialogResult.OK Then
            Me.Cursor = Cursors.WaitCursor

            sTMP = fdlg.FileName

        End If

        Select Case sOfficePACK

            Case "OpenOffice.org"

                If Len(sTMP) > 3 Then Call blanks_my_o(fdlg.FileName)


            Case Else

                If Len(sTMP) > 3 Then Call blanks_my_wrd(fdlg.FileName)

        End Select


        Me.Cursor = Cursors.Default
    End Sub

    Private Sub ПаспортМФУToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ПаспортМФУToolStripMenuItem.Click

        If TipTehn <> "MFU" Then Exit Sub

        Call PASSWORD_MFU(frmComputers.sCOUNT, "MFU")

    End Sub

    Private Sub ПаспортПринтераToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ПаспортПринтераToolStripMenuItem.Click

        If TipTehn <> "Printer" Then Exit Sub

        Call PASSWORD_MFU(frmComputers.sCOUNT, "Printer")
    End Sub

    Private Sub ПаспортКопираToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ПаспортКопираToolStripMenuItem.Click

        If TipTehn <> "KOpir" Then Exit Sub

        Call PASSWORD_MFU(frmComputers.sCOUNT, "KOpir")
    End Sub

    Private Sub ПаспортСетевогоОборудованияToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ПаспортСетевогоОборудованияToolStripMenuItem.Click

        If TipTehn <> "NET" Then Exit Sub

        Call PASSWORD_NET(frmComputers.sCOUNT)
    End Sub

    Private Sub ПаспортСканераToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ПаспортСканераToolStripMenuItem.Click

        If TipTehn <> "SCANER" Then Exit Sub

        Call PASSWORD_OTH(frmComputers.sCOUNT, "SCANER")
    End Sub

    Private Sub LabelPanelToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LabelPanelToolStripMenuItem.Click

        Dim objIniFile As New IniFile(PrPath & "base.ini")

        Select Case Me.LabelPanelToolStripMenuItem.Checked

            Case True

                ToolStripDropDownButton1.DisplayStyle = ToolStripItemDisplayStyle.ImageAndText
                NewToolStripButton.DisplayStyle = ToolStripItemDisplayStyle.ImageAndText
                SaveInfTehButton.DisplayStyle = ToolStripItemDisplayStyle.ImageAndText
                ArhToolZipbutton.DisplayStyle = ToolStripItemDisplayStyle.ImageAndText
                ToolStripButton1.DisplayStyle = ToolStripItemDisplayStyle.ImageAndText

                objIniFile.WriteString("General", "IMAGE_TEXT", 1)
            Case False

                ToolStripDropDownButton1.DisplayStyle = ToolStripItemDisplayStyle.Image
                NewToolStripButton.DisplayStyle = ToolStripItemDisplayStyle.Image
                SaveInfTehButton.DisplayStyle = ToolStripItemDisplayStyle.Image
                ArhToolZipbutton.DisplayStyle = ToolStripItemDisplayStyle.Image
                ToolStripButton1.DisplayStyle = ToolStripItemDisplayStyle.Image

                objIniFile.WriteString("General", "IMAGE_TEXT", 0)

        End Select

    End Sub

    Private Sub QRCodeTestingToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles QRCodeTestingToolStripMenuItem.Click
        'QrCode.MdiParent = Me
        'QrCode.Show()
    End Sub

    '#################################################################################################
    Private Sub ФотоаппаратToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ФотоаппаратToolStripMenuItem.Click
        frmComputers.txtMonDum.Visible = False
        'frmComputers.txtOTHSN.Left = "249" 'esq 130612"249"
        'frmComputers.txtOTHSN.Width = "214" 'esq 130612 "214"

        FillComboNET(frmComputers.cmbOTH, "name", "spr_photo", "", False, True)
        frmComputers.lblTipOther.Visible = False
        frmComputers.cmbOTHConnect.Visible = False
        frmComputers.lblOTMac.Visible = False
        frmComputers.lblOtIp.Visible = False
        frmComputers.txtOTHIP.Visible = False
        frmComputers.txtOTHMAC.Visible = False

        frmComputers.sSTAB3.Visible = True
        frmComputers.sSTAB1.Visible = False
        frmComputers.sSTAB2.Visible = False
        frmComputers.sSTAB4.Visible = False
        frmComputers.sSTAB5.Visible = False
        TipTehn = "PHOTO"
        Call ClearForm(frmComputers)

        frmComputers.EDT = False

        frmComputers.selectTECMesto()
        frmComputers.cmbOTHFil.Text = sBranch
        frmComputers.cmbOTHDepart.Text = sDepartment
        frmComputers.cmbOTHOffice.Text = sOffice

        frmComputers.lblOTPCL.Visible = False
        frmComputers.cmbOTHPCL.Visible = False

    End Sub

    Private Sub ФаксToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ФаксToolStripMenuItem.Click
        frmComputers.txtMonDum.Visible = False
        'frmComputers.txtOTHSN.Left = "331" 'esq 130612 "249"
        'frmComputers.txtOTHSN.Width = "284" 'esq 130612"214"

        FillComboNET(frmComputers.cmbOTH, "name", "spr_fax", "", False, True)
        frmComputers.lblTipOther.Visible = False
        frmComputers.cmbOTHConnect.Visible = False
        frmComputers.lblOTMac.Visible = False
        frmComputers.lblOtIp.Visible = False
        frmComputers.txtOTHIP.Visible = False
        frmComputers.txtOTHMAC.Visible = False

        frmComputers.sSTAB3.Visible = True
        frmComputers.sSTAB1.Visible = False
        frmComputers.sSTAB2.Visible = False
        frmComputers.sSTAB4.Visible = False
        frmComputers.sSTAB5.Visible = False
        TipTehn = "FAX"
        Call ClearForm(frmComputers)

        frmComputers.EDT = False

        frmComputers.selectTECMesto()
        frmComputers.cmbOTHFil.Text = sBranch
        frmComputers.cmbOTHDepart.Text = sDepartment
        frmComputers.cmbOTHOffice.Text = sOffice

        frmComputers.lblOTPCL.Visible = False
        frmComputers.cmbOTHPCL.Visible = False

    End Sub

    Private Sub ТелефонToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ТелефонToolStripMenuItem.Click
        frmComputers.txtMonDum.Visible = False
        'frmComputers.txtOTHSN.Left = "249" 'esq 130612"249"
        'frmComputers.txtOTHSN.Width = "214" 'esq 130612 "214"

        Call ClearForm(frmComputers)

        FillComboNET(frmComputers.cmbOTH, "name", "spr_phone", "", False, True)
        frmComputers.lblTipOther.Visible = False
        frmComputers.cmbOTHConnect.Visible = False

        frmComputers.lblOTMac.Visible = True
        frmComputers.lblOtIp.Visible = True
        frmComputers.txtOTHIP.Visible = True
        frmComputers.txtOTHMAC.Visible = True

        frmComputers.sSTAB3.Visible = True
        frmComputers.sSTAB1.Visible = False
        frmComputers.sSTAB2.Visible = False
        frmComputers.sSTAB4.Visible = False
        frmComputers.sSTAB5.Visible = False
        TipTehn = "PHONE"
        frmComputers.EDT = False

        frmComputers.selectTECMesto()
        frmComputers.cmbOTHFil.Text = sBranch
        frmComputers.cmbOTHDepart.Text = sDepartment
        frmComputers.cmbOTHOffice.Text = sOffice

        frmComputers.lblOTPCL.Visible = True
        frmComputers.cmbOTHPCL.Visible = True
        Call LOAD_PCL(frmComputers.cmbOTHFil.Text, frmComputers.cmbOTHDepart.Text, frmComputers.cmbOTHOffice.Text, frmComputers.cmbOTHPCL, frmComputers.cmbOTHotv.Text, frmComputers.sCOUNT)
    End Sub

    Private Sub ДисководZIPToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ДисководZIPToolStripMenuItem.Click
        frmComputers.txtMonDum.Visible = False
        'frmComputers.txtOTHSN.Left = "249" 'esq 130612"249"
        'frmComputers.txtOTHSN.Width = "214" 'esq 130612 "214"

        Call ClearForm(frmComputers)

        FillComboNET(frmComputers.cmbOTH, "name", "spr_zip", "", False, True)
        frmComputers.lblTipOther.Visible = False
        frmComputers.cmbOTHConnect.Visible = False

        frmComputers.lblOTMac.Visible = False
        frmComputers.lblOtIp.Visible = False
        frmComputers.txtOTHIP.Visible = False
        frmComputers.txtOTHMAC.Visible = False

        frmComputers.sSTAB3.Visible = True
        frmComputers.sSTAB1.Visible = False
        frmComputers.sSTAB2.Visible = False
        frmComputers.sSTAB4.Visible = False
        frmComputers.sSTAB5.Visible = False
        TipTehn = "ZIP"
        frmComputers.EDT = False
        frmComputers.selectTECMesto()
        frmComputers.cmbOTHFil.Text = sBranch
        frmComputers.cmbOTHDepart.Text = sDepartment
        frmComputers.cmbOTHOffice.Text = sOffice
        frmComputers.lblOTPCL.Visible = True
        frmComputers.cmbOTHPCL.Visible = True

        Call LOAD_PCL(frmComputers.cmbOTHFil.Text, frmComputers.cmbOTHDepart.Text, frmComputers.cmbOTHOffice.Text, frmComputers.cmbOTHPCL, frmComputers.cmbOTHotv.Text, frmComputers.sCOUNT)
    End Sub

    Private Sub СканерToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles СканерToolStripMenuItem.Click
        frmComputers.txtMonDum.Visible = False
        'frmComputers.txtOTHSN.Left = "249" 'esq 130612"249"
        'frmComputers.txtOTHSN.Width = "214" 'esq 130612 "214"

        Call ClearForm(frmComputers)

        FillComboNET(frmComputers.cmbOTH, "name", "SPR_SCANER", "", False, True)
        frmComputers.lblTipOther.Visible = False
        frmComputers.cmbOTHConnect.Visible = False

        frmComputers.lblOTMac.Visible = False
        frmComputers.lblOtIp.Visible = False
        frmComputers.txtOTHIP.Visible = False
        frmComputers.txtOTHMAC.Visible = False

        frmComputers.sSTAB3.Visible = True
        frmComputers.sSTAB1.Visible = False
        frmComputers.sSTAB2.Visible = False
        frmComputers.sSTAB4.Visible = False
        frmComputers.sSTAB5.Visible = False
        TipTehn = "SCANER"
        frmComputers.EDT = False

        frmComputers.selectTECMesto()
        frmComputers.cmbOTHFil.Text = sBranch
        frmComputers.cmbOTHDepart.Text = sDepartment
        frmComputers.cmbOTHOffice.Text = sOffice

        frmComputers.lblOTPCL.Visible = True
        frmComputers.cmbOTHPCL.Visible = True

        Call LOAD_PCL(frmComputers.cmbOTHFil.Text, frmComputers.cmbOTHDepart.Text, frmComputers.cmbOTHOffice.Text, frmComputers.cmbOTHPCL, frmComputers.cmbOTHotv.Text, frmComputers.sCOUNT)
    End Sub

    Private Sub ДругоеОборудованиеToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ДругоеОборудованиеToolStripMenuItem.Click

        Call ClearForm(frmComputers)

        frmComputers.cmbOTH.Items.Clear()

        FillComboNET(frmComputers.cmbOTH, "name", "SPR_OTH_DEV", "", False, True)
        FillComboNET(frmComputers.cmbOTHConnect, "name", "spr_other", "", False, True)

        frmComputers.lblTipOther.Visible = True
        frmComputers.cmbOTHConnect.Visible = True

        frmComputers.lblOTMac.Visible = True
        frmComputers.lblOtIp.Visible = True
        frmComputers.txtOTHIP.Visible = True
        frmComputers.txtOTHMAC.Visible = True

        frmComputers.sSTAB3.Visible = True
        frmComputers.sSTAB1.Visible = False
        frmComputers.sSTAB2.Visible = False
        frmComputers.sSTAB4.Visible = False
        frmComputers.sSTAB5.Visible = False
        TipTehn = "OT"
        frmComputers.EDT = False

        frmComputers.selectTECMesto()
        frmComputers.cmbOTHFil.Text = sBranch
        frmComputers.cmbOTHDepart.Text = sDepartment
        frmComputers.cmbOTHOffice.Text = sOffice

        frmComputers.lblOTPCL.Visible = True
        frmComputers.cmbOTHPCL.Visible = True

        Call LOAD_PCL(frmComputers.cmbOTHFil.Text, frmComputers.cmbOTHDepart.Text, frmComputers.cmbOTHOffice.Text, frmComputers.cmbOTHPCL, frmComputers.cmbOTHotv.Text, frmComputers.sCOUNT)

    End Sub

    Private Sub МониторToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles МониторToolStripMenuItem.Click
        Call ClearForm(frmComputers)

        FillComboNET(frmComputers.cmbOTH, "name", "SPR_MONITOR", "", False, True)
        frmComputers.lblTipOther.Visible = False
        frmComputers.cmbOTHConnect.Visible = False

        frmComputers.lblOTMac.Visible = False
        frmComputers.lblOtIp.Visible = False
        frmComputers.txtOTHIP.Visible = False
        frmComputers.txtOTHMAC.Visible = False

        frmComputers.sSTAB3.Visible = True
        frmComputers.sSTAB1.Visible = False
        frmComputers.sSTAB2.Visible = False
        frmComputers.sSTAB4.Visible = False
        frmComputers.sSTAB5.Visible = False

        TipTehn = "MONITOR"

        frmComputers.EDT = False
        frmComputers.selectTECMesto()
        frmComputers.cmbOTHFil.Text = sBranch
        frmComputers.cmbOTHDepart.Text = sDepartment
        frmComputers.cmbOTHOffice.Text = sOffice

        frmComputers.txtMonDum.Visible = True
        'frmComputers.txtOTHSN.Left = "471" 'esq 130612"355"
        'frmComputers.txtOTHSN.Width = "146" 'esq 130612"108"

        frmComputers.lblTipOther.Visible = False
        frmComputers.cmbOTHConnect.Visible = False
        frmComputers.lblOTMac.Visible = False
        frmComputers.lblOtIp.Visible = False
        frmComputers.txtOTHIP.Visible = False
        frmComputers.txtOTHMAC.Visible = False

        frmComputers.lblOTPCL.Visible = True
        frmComputers.cmbOTHPCL.Visible = True

        Call LOAD_PCL(frmComputers.cmbOTHFil.Text, frmComputers.cmbOTHDepart.Text, frmComputers.cmbOTHOffice.Text, frmComputers.cmbOTHPCL, frmComputers.cmbOTHotv.Text, frmComputers.sCOUNT)

    End Sub

    Private Sub ЗагрузитьИзCSVEverestToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ЗагрузитьИзCSVEverestToolStripMenuItem.Click

        Call VisibleForm(frmComputers)
        Dim ePatch As String
        Dim objIniFile As New IniFile(PrPath & "base.ini")
        ePatch = objIniFile.GetString("General", "aida", PrPath)

        Dim fdlg As OpenFileDialog = New OpenFileDialog()
        Dim LNGIniFile As New IniFile(sLANGPATH)

        fdlg.Title = LNGIniFile.GetString("frmMain", "MSG3", "Загрузка из Everest Corporate Edition")

        fdlg.InitialDirectory = ePatch
        fdlg.Filter = "csv files (*.csv)|*.csv"
        fdlg.FilterIndex = 2

        fdlg.RestoreDirectory = True

        If fdlg.ShowDialog() = DialogResult.OK Then
            Me.Cursor = Cursors.WaitCursor

            EverestFilePatch = fdlg.FileName

        End If
        frmComputers.selectTECMesto()
        Call ClearForm(frmComputers)
        frmComputers.EDT = False
        TipTehn = "PC"

        frmComputers.sSTAB2.Visible = False
        frmComputers.sSTAB1.Visible = True
        frmComputers.sSTAB3.Visible = False
        frmComputers.sSTAB4.Visible = False
        frmComputers.sSTAB5.Visible = False

        'If Len(EverestFilePatch) > 3 Then Call ReadFromFile(EverestFilePatch)

        frmComputers.cmbBranch.Text = sBranch
        frmComputers.cmbDepartment.Text = sDepartment
        frmComputers.cmbOffice.Text = sOffice

        Me.Cursor = Cursors.Default

        'ReadFromFile
    End Sub

    Private Sub ЗагрузитьЧерезWMIToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ЗагрузитьЧерезWMIToolStripMenuItem.Click

        Call VisibleForm(frmComputers)
        Me.Cursor = Cursors.WaitCursor

        frmComputers.selectTECMesto()
        Call ClearForm(frmComputers)
        frmComputers.EDT = False
        TipTehn = "PC"

        frmComputers.sSTAB2.Visible = False
        frmComputers.sSTAB1.Visible = True
        frmComputers.sSTAB3.Visible = False
        frmComputers.sSTAB4.Visible = False

        Call LOAD_WMI()

        Me.Cursor = Cursors.Default
    End Sub

    Private Sub ЗагрузитьИзASTRA32ToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ЗагрузитьИзASTRA32ToolStripMenuItem.Click
        Call VisibleForm(frmComputers)
        Dim ePatch As String
        Dim objIniFile As New IniFile(PrPath & "base.ini")
        ePatch = objIniFile.GetString("General", "aida", PrPath)

        Dim fdlg As OpenFileDialog = New OpenFileDialog()
        Dim LNGIniFile As New IniFile(sLANGPATH)
        fdlg.Title = LNGIniFile.GetString("frmMain", "MSG6", "Загрузка из ASTRA32")
        fdlg.InitialDirectory = ePatch
        fdlg.Filter = "ini files (*.ini)|*.ini"
        fdlg.FilterIndex = 2

        fdlg.RestoreDirectory = True

        If fdlg.ShowDialog() = DialogResult.OK Then
            Me.Cursor = Cursors.WaitCursor

            EverestFilePatch = fdlg.FileName

        End If
        frmComputers.selectTECMesto()
        Call ClearForm(frmComputers)
        frmComputers.EDT = False
        TipTehn = "PC"

        frmComputers.sSTAB2.Visible = False
        frmComputers.sSTAB1.Visible = True
        frmComputers.sSTAB3.Visible = False
        frmComputers.sSTAB4.Visible = False
        frmComputers.sSTAB5.Visible = False

        If Len(EverestFilePatch) > 3 Then Call ASTRA_Load()

        frmComputers.cmbBranch.Text = sBranch
        frmComputers.cmbDepartment.Text = sDepartment
        frmComputers.cmbOffice.Text = sOffice

        Me.Cursor = Cursors.Default

    End Sub

    Private Sub СетевоеОборудованиеToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles СетевоеОборудованиеToolStripMenuItem.Click

        frmComputers.sSTAB3.Visible = False
        frmComputers.sSTAB1.Visible = False
        frmComputers.sSTAB2.Visible = False
        frmComputers.sSTAB4.Visible = True
        frmComputers.sSTAB5.Visible = False
        TipTehn = "NET"
        Call ClearForm(frmComputers)

        frmComputers.EDT = False

        frmComputers.selectTECMesto()
        frmComputers.cmbNETBranch.Text = sBranch
        frmComputers.cmbNetDepart.Text = sDepartment
        frmComputers.cmbNETOffice.Text = sOffice

    End Sub

    Private Sub КопирToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles КопирToolStripMenuItem.Click
        Call ClearForm(frmComputers)

        frmComputers.EDT = False
        FillComboNET(frmComputers.cmbPRN, "name", "SPR_KOPIR", "", False, True)

        frmComputers.sSTAB2.Visible = True
        frmComputers.sSTAB1.Visible = False
        frmComputers.sSTAB3.Visible = False
        frmComputers.sSTAB4.Visible = False
        frmComputers.sSTAB5.Visible = False

        frmComputers.selectTECMesto()
        frmComputers.cmbPRNFil.Text = sBranch
        frmComputers.cmbPRNDepart.Text = sDepartment
        frmComputers.cmbPRNOffice.Text = sOffice

        'Call LOAD_PCL(frmComputers.cmbPRNFil.Text, frmComputers.cmbPRNDepart.Text, frmComputers.cmbPRNOffice.Text, frmComputers.cmbPCL)
        TipTehn = "KOpir"

        frmComputers.cmbFormat.Items.Clear()

        Dim langfile As New IniFile(sLANGPATH)

        For intj = 1 To 5
            frmComputers.cmbFormat.Items.Add("A" & intj)
        Next

        frmComputers.cmbTIPCartridg.Items.Clear()
        frmComputers.cmbTIPCartridg.Items.Add(langfile.GetString("frmDirectory", "MSG91", "Струйный"))
        frmComputers.cmbTIPCartridg.Items.Add(langfile.GetString("frmDirectory", "MSG92", "Матричный"))
        frmComputers.cmbTIPCartridg.Items.Add(langfile.GetString("frmDirectory", "MSG93", "Лазерный"))
        frmComputers.cmbTIPCartridg.Items.Add(langfile.GetString("frmDirectory", "MSG94", "Барабан"))
        frmComputers.cmbTIPCartridg.Items.Add(langfile.GetString("frmDirectory", "MSG95", "Термо Пленка"))
        frmComputers.cmbTIPCartridg.Items.Add(langfile.GetString("frmDirectory", "MSG96", "Фотокондуктор"))

    End Sub

    Private Sub ПринтерToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ПринтерToolStripMenuItem.Click
        Call ClearForm(frmComputers)

        frmComputers.EDT = False
        FillComboNET(frmComputers.cmbPRN, "name", "SPR_PRINTER", "", False, True)

        frmComputers.sSTAB2.Visible = True
        frmComputers.sSTAB1.Visible = False
        frmComputers.sSTAB3.Visible = False
        frmComputers.sSTAB4.Visible = False
        frmComputers.sSTAB5.Visible = False

        frmComputers.selectTECMesto()
        frmComputers.cmbPRNFil.Text = sBranch
        frmComputers.cmbPRNDepart.Text = sDepartment
        frmComputers.cmbPRNOffice.Text = sOffice

        frmComputers.cmbFormat.Items.Clear()

        Dim langfile As New IniFile(sLANGPATH)

        For intj = 1 To 5
            frmComputers.cmbFormat.Items.Add("A" & intj)
        Next

        frmComputers.cmbTIPCartridg.Items.Clear()
        frmComputers.cmbTIPCartridg.Items.Add(langfile.GetString("frmDirectory", "MSG91", "Струйный"))
        frmComputers.cmbTIPCartridg.Items.Add(langfile.GetString("frmDirectory", "MSG92", "Матричный"))
        frmComputers.cmbTIPCartridg.Items.Add(langfile.GetString("frmDirectory", "MSG93", "Лазерный"))
        frmComputers.cmbTIPCartridg.Items.Add(langfile.GetString("frmDirectory", "MSG94", "Барабан"))
        frmComputers.cmbTIPCartridg.Items.Add(langfile.GetString("frmDirectory", "MSG95", "Термо Пленка"))
        frmComputers.cmbTIPCartridg.Items.Add(langfile.GetString("frmDirectory", "MSG96", "Фотокондуктор"))

        TipTehn = "Printer"
        Call LOAD_PCL(frmComputers.cmbPRNFil.Text, frmComputers.cmbPRNDepart.Text, frmComputers.cmbPRNOffice.Text, frmComputers.cmbPCL, frmComputers.cmbPRNotv.Text, frmComputers.sCOUNT)

    End Sub

    Private Sub МФУToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles МФУToolStripMenuItem.Click
        Call ClearForm(frmComputers)

        frmComputers.EDT = False
        FillComboNET(frmComputers.cmbPRN, "name", "SPR_MFU", "", False, True)

        frmComputers.sSTAB2.Visible = True
        frmComputers.sSTAB1.Visible = False
        frmComputers.sSTAB3.Visible = False
        frmComputers.sSTAB4.Visible = False
        frmComputers.sSTAB5.Visible = False

        frmComputers.selectTECMesto()
        frmComputers.cmbPRNFil.Text = sBranch
        frmComputers.cmbPRNDepart.Text = sDepartment
        frmComputers.cmbPRNOffice.Text = sOffice

        TipTehn = "MFU"

        frmComputers.cmbFormat.Items.Clear()

        Dim langfile As New IniFile(sLANGPATH)

        For intj = 1 To 5
            frmComputers.cmbFormat.Items.Add("A" & intj)
        Next

        frmComputers.cmbTIPCartridg.Items.Clear()
        frmComputers.cmbTIPCartridg.Items.Add(langfile.GetString("frmDirectory", "MSG91", "Струйный"))
        frmComputers.cmbTIPCartridg.Items.Add(langfile.GetString("frmDirectory", "MSG92", "Матричный"))
        frmComputers.cmbTIPCartridg.Items.Add(langfile.GetString("frmDirectory", "MSG93", "Лазерный"))
        frmComputers.cmbTIPCartridg.Items.Add(langfile.GetString("frmDirectory", "MSG94", "Барабан"))
        frmComputers.cmbTIPCartridg.Items.Add(langfile.GetString("frmDirectory", "MSG95", "Термо Пленка"))
        frmComputers.cmbTIPCartridg.Items.Add(langfile.GetString("frmDirectory", "MSG96", "Фотокондуктор"))

        Call LOAD_PCL(frmComputers.cmbPRNFil.Text, frmComputers.cmbPRNDepart.Text, frmComputers.cmbPRNOffice.Text, frmComputers.cmbPCL, frmComputers.cmbPRNotv.Text, frmComputers.sCOUNT)

    End Sub

    Private Sub ЗагрузитьИзEverestiniToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ЗагрузитьИзEverestiniToolStripMenuItem.Click
        Call VisibleForm(frmComputers)

        Dim ePatch As String
        Dim objIniFile As New IniFile(PrPath & "base.ini")
        ePatch = objIniFile.GetString("General", "aida", PrPath)

        Dim fdlg As OpenFileDialog = New OpenFileDialog()
        Dim LNGIniFile As New IniFile(sLANGPATH)
        fdlg.Title = LNGIniFile.GetString("frmMain", "MSG3", "Загрузка из Everest Corporate Edition")
        fdlg.InitialDirectory = ePatch
        fdlg.Filter = "ini files (*.ini)|*.ini"
        fdlg.FilterIndex = 2

        fdlg.RestoreDirectory = True

        If fdlg.ShowDialog() = DialogResult.OK Then
            Me.Cursor = Cursors.WaitCursor

            EverestFilePatch = fdlg.FileName

        End If
        frmComputers.selectTECMesto()
        Call ClearForm(frmComputers)
        frmComputers.EDT = False
        TipTehn = "PC"

        frmComputers.sSTAB2.Visible = False
        frmComputers.sSTAB1.Visible = True
        frmComputers.sSTAB3.Visible = False
        frmComputers.sSTAB4.Visible = False
        frmComputers.sSTAB5.Visible = False

        If Len(EverestFilePatch) > 3 Then Call Everest_Load()

        frmComputers.cmbBranch.Text = sBranch
        frmComputers.cmbDepartment.Text = sDepartment
        frmComputers.cmbOffice.Text = sOffice

        Me.Cursor = Cursors.Default

    End Sub

    Private Sub SaveInfTehButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SaveInfTehButton.Click

        Call SaveInfTeh()

    End Sub

    Public Sub SaveInfTeh()
        Me.Cursor = Cursors.WaitCursor
        On Error Resume Next

        Dim Stmp1, Stmp2 As String

        Stmp1 = TimeOfDay

        Call DELETE_SIMBOL(frmComputers)

        Stmp2 = TimeOfDay

        Dim LNGIniFile As New IniFile(sLANGPATH)

        If Len(TipTehn) <> 0 Then

            GoTo ADD

        Else

            Select Case frmComputers.sPREF

                Case "G"

                    Call SAVE_INF_BRANCHE()

                Case "O"

                    Call SAVE_INF_BRANCHE()

                Case "K"

                    Call SAVE_INF_BRANCHE()

                Case "C"

            End Select

        End If

        Me.Cursor = Cursors.Default

        Exit Sub

ADD:
        Select Case frmComputers.EDT

            Case True
                PreSaveOtv(sBranch, sDepartment, sOffice)
                PreSaveName(frmComputers.sCOUNT)

            Case False

        End Select


        Dim langfile As New IniFile(sLANGPATH)


        Select Case TipTehn

            Case "PC"

                Select Case frmComputers.EDT

                    Case True
                        Call Save_T(frmComputers.sCOUNT)
                    Case False
                        Me.Invoke(New MethodInvoker(AddressOf Save_T))
                End Select


            Case "Printer"
                'Save_P
                Select Case frmComputers.EDT

                    Case True
                        Call Save_P(frmComputers.sCOUNT)
                    Case False
                        Me.Invoke(New MethodInvoker(AddressOf Save_P))
                End Select

            Case "MFU"
                Select Case frmComputers.EDT

                    Case True
                        Call Save_P(frmComputers.sCOUNT)
                    Case False
                        Me.Invoke(New MethodInvoker(AddressOf Save_P))
                End Select

            Case "KOpir"
                Select Case frmComputers.EDT

                    Case True
                        Call Save_P(frmComputers.sCOUNT)
                    Case False
                        Me.Invoke(New MethodInvoker(AddressOf Save_P))
                End Select

            Case "OT"

                Select Case frmComputers.EDT

                    Case True
                        Call Save_OT(frmComputers.sCOUNT)
                    Case False
                        Me.Invoke(New MethodInvoker(AddressOf Save_OT))
                End Select


            Case "CNT"

                Select Case frmComputers.EDT

                    Case True
                        Call Save_OT(frmComputers.sCOUNT)
                    Case False
                        Me.Invoke(New MethodInvoker(AddressOf Save_OT))
                End Select


            Case "PHOTO"

                Select Case frmComputers.EDT

                    Case True
                        Call Save_OT(frmComputers.sCOUNT)
                    Case False
                        Me.Invoke(New MethodInvoker(AddressOf Save_OT))
                End Select

            Case "FAX"

                Select Case frmComputers.EDT

                    Case True
                        Call Save_OT(frmComputers.sCOUNT)
                    Case False
                        Me.Invoke(New MethodInvoker(AddressOf Save_OT))
                End Select

            Case "PHONE"

                Select Case frmComputers.EDT

                    Case True
                        Call Save_OT(frmComputers.sCOUNT)
                    Case False
                        Me.Invoke(New MethodInvoker(AddressOf Save_OT))
                End Select

            Case "ZIP"

                Select Case frmComputers.EDT

                    Case True
                        Call Save_OT(frmComputers.sCOUNT)
                    Case False
                        Me.Invoke(New MethodInvoker(AddressOf Save_OT))
                End Select

            Case "SCANER"
                Select Case frmComputers.EDT

                    Case True
                        Call Save_OT(frmComputers.sCOUNT)
                    Case False
                        Me.Invoke(New MethodInvoker(AddressOf Save_OT))
                End Select

            Case "NET"

                Select Case frmComputers.EDT

                    Case True
                        Call Save_NET(frmComputers.sCOUNT)
                    Case False
                        Me.Invoke(New MethodInvoker(AddressOf Save_NET))
                End Select

            Case "MONITOR"

                Select Case frmComputers.EDT

                    Case True
                        Call SAVE_MON(frmComputers.sCOUNT)
                    Case False
                        Me.Invoke(New MethodInvoker(AddressOf SAVE_MON))
                End Select

                '--------------VIP_Graff Добавление новой перефирии Начало-----------------
            Case "USB"
                Select Case frmComputers.EDT

                    Case True
                        Call Save_OT(frmComputers.sCOUNT)
                    Case False
                        Me.Invoke(New MethodInvoker(AddressOf Save_OT))
                End Select

            Case "SOUND"
                Select Case frmComputers.EDT

                    Case True
                        Call Save_OT(frmComputers.sCOUNT)
                    Case False
                        Me.Invoke(New MethodInvoker(AddressOf Save_OT))
                End Select

            Case "IBP"
                Select Case frmComputers.EDT

                    Case True
                        Call Save_OT(frmComputers.sCOUNT)
                    Case False
                        Me.Invoke(New MethodInvoker(AddressOf Save_OT))
                End Select

            Case "FS"
                Select Case frmComputers.EDT

                    Case True
                        Call Save_OT(frmComputers.sCOUNT)
                    Case False
                        Me.Invoke(New MethodInvoker(AddressOf Save_OT))
                End Select

            Case "KEYB"
                Select Case frmComputers.EDT

                    Case True
                        Call Save_OT(frmComputers.sCOUNT)
                    Case False
                        Me.Invoke(New MethodInvoker(AddressOf Save_OT))
                End Select

            Case "MOUSE"
                Select Case frmComputers.EDT

                    Case True
                        Call Save_OT(frmComputers.sCOUNT)
                    Case False
                        Me.Invoke(New MethodInvoker(AddressOf Save_OT))
                End Select

                '--------------VIP_Graff Добавление новой перефирии Конец------------------

            Case Else

        End Select

        On Error Resume Next

        Select Case frmComputers.EDT
            Case True
                Call SaveActivityToLogDB(langfile.GetString("frmComputers", "MSG51", "Редактирование техники") & " " & frmComputers.lstGroups.SelectedNode.Text)
            Case False
                Call SaveActivityToLogDB(langfile.GetString("frmComputers", "MSG50", "Добавление новой техники в") & " /" & sBranch & "/" & sDepartment & "/" & sOffice)
        End Select

        frmComputers.Invoke(New MethodInvoker(AddressOf frmComputers.STAT_INF))

        System.Windows.Forms.Application.DoEvents()

        'Me.BeginInvoke(New MethodInvoker(AddressOf frmComputers.R_T_LOAD))


        Me.Cursor = Cursors.Default

    End Sub

    Private Sub NewToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NewToolStripMenuItem.Click
        frmSetup.MdiParent = Me
        frmSetup.Show()
        frmSetup.Focus()
    End Sub

    Private Sub HANDINSERTToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles HANDINSERTToolStripMenuItem.Click

        Call VisibleForm(frmComputers)

        frmComputers.sSTAB2.Visible = False
        frmComputers.sSTAB1.Visible = True
        frmComputers.sSTAB3.Visible = False
        frmComputers.sSTAB4.Visible = False
        frmComputers.sSTAB5.Visible = False
        Call ClearForm(frmComputers)

        Call frmComputers.selectTECMesto()

        frmComputers.cmbBranch.Text = sBranch
        frmComputers.cmbDepartment.Text = sDepartment
        frmComputers.cmbOffice.Text = sOffice

        frmComputers.EDT = False
        TipTehn = "PC"

    End Sub

    Private Sub NewToolStripButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NewToolStripButton.Click
        'frmSearch
        frmSearch.MdiParent = Me
        frmSearch.Show()
        frmSearch.Focus()
    End Sub

    Private Sub ToolStripButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton1.Click
        frmReports.MdiParent = Me
        frmReports.Show()
        frmReports.Focus()
    End Sub

    Private Sub ArhToolZipbutton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ArhToolZipbutton.Click
        frmARHIV.ShowDialog(Me)
    End Sub

    Private Sub СетевыеФильтрыToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles СетевыеФильтрыToolStripMenuItem.Click
        frmComputers.txtMonDum.Visible = False
        'frmComputers.txtOTHSN.Left = "249" 'esq 130612"249"
        'frmComputers.txtOTHSN.Width = "214" 'esq 130612 "214"

        Call ClearForm(frmComputers)
        FillComboNET(frmComputers.cmbOTH, "name", "SPR_FS", "", False, True)
        frmComputers.lblTipOther.Visible = False
        frmComputers.cmbOTHConnect.Visible = False

        frmComputers.lblOTMac.Visible = False
        frmComputers.lblOtIp.Visible = False
        frmComputers.txtOTHIP.Visible = False
        frmComputers.txtOTHMAC.Visible = False

        frmComputers.sSTAB3.Visible = True
        frmComputers.sSTAB1.Visible = False
        frmComputers.sSTAB2.Visible = False
        frmComputers.sSTAB4.Visible = False
        frmComputers.sSTAB5.Visible = False
        TipTehn = "FS"
        frmComputers.EDT = False

        frmComputers.selectTECMesto()
        frmComputers.cmbOTHFil.Text = sBranch
        frmComputers.cmbOTHDepart.Text = sDepartment
        frmComputers.cmbOTHOffice.Text = sOffice

        frmComputers.lblOTPCL.Visible = True
        frmComputers.cmbOTHPCL.Visible = True

        Call LOAD_PCL(frmComputers.cmbOTHFil.Text, frmComputers.cmbOTHDepart.Text, frmComputers.cmbOTHOffice.Text, frmComputers.cmbOTHPCL, frmComputers.cmbOTHotv.Text, frmComputers.sCOUNT)
    End Sub

    Private Sub БесперебойникиToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles БесперебойникиToolStripMenuItem.Click
        frmComputers.txtMonDum.Visible = False
        'frmComputers.txtOTHSN.Left = "249" 'esq 130612"249"
        'frmComputers.txtOTHSN.Width = "214" 'esq 130612 "214"

        Call ClearForm(frmComputers)

        FillComboNET(frmComputers.cmbOTH, "name", "SPR_IBP", "", False, True)
        frmComputers.lblTipOther.Visible = False
        frmComputers.cmbOTHConnect.Visible = False

        frmComputers.lblOTMac.Visible = True
        frmComputers.lblOtIp.Visible = True
        frmComputers.txtOTHIP.Visible = True
        frmComputers.txtOTHMAC.Visible = True

        frmComputers.sSTAB3.Visible = True
        frmComputers.sSTAB1.Visible = False
        frmComputers.sSTAB2.Visible = False
        frmComputers.sSTAB4.Visible = False
        frmComputers.sSTAB5.Visible = False
        TipTehn = "IBP"
        frmComputers.EDT = False

        frmComputers.selectTECMesto()
        frmComputers.cmbOTHFil.Text = sBranch
        frmComputers.cmbOTHDepart.Text = sDepartment
        frmComputers.cmbOTHOffice.Text = sOffice

        frmComputers.lblOTPCL.Visible = True
        frmComputers.cmbOTHPCL.Visible = True

        Call LOAD_PCL(frmComputers.cmbOTHFil.Text, frmComputers.cmbOTHDepart.Text, frmComputers.cmbOTHOffice.Text, frmComputers.cmbOTHPCL, frmComputers.cmbOTHotv.Text, frmComputers.sCOUNT)
    End Sub

    Private Sub АккустическиеСистемыToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles АккустическиеСистемыToolStripMenuItem.Click
        frmComputers.txtMonDum.Visible = False
        'frmComputers.txtOTHSN.Left = "249" 'esq 130612"249"
        'frmComputers.txtOTHSN.Width = "214" 'esq 130612 "214"

        Call ClearForm(frmComputers)

        FillComboNET(frmComputers.cmbOTH, "name", "SPR_ASISTEM", "", False, True)
        frmComputers.lblTipOther.Visible = False
        frmComputers.cmbOTHConnect.Visible = False

        frmComputers.lblOTMac.Visible = False
        frmComputers.lblOtIp.Visible = False
        frmComputers.txtOTHIP.Visible = False
        frmComputers.txtOTHMAC.Visible = False

        frmComputers.sSTAB3.Visible = True
        frmComputers.sSTAB1.Visible = False
        frmComputers.sSTAB2.Visible = False
        frmComputers.sSTAB4.Visible = False
        frmComputers.sSTAB5.Visible = False
        TipTehn = "SOUND"
        frmComputers.EDT = False

        frmComputers.selectTECMesto()
        frmComputers.cmbOTHFil.Text = sBranch
        frmComputers.cmbOTHDepart.Text = sDepartment
        frmComputers.cmbOTHOffice.Text = sOffice

        frmComputers.lblOTPCL.Visible = True
        frmComputers.cmbOTHPCL.Visible = True

        Call LOAD_PCL(frmComputers.cmbOTHFil.Text, frmComputers.cmbOTHDepart.Text, frmComputers.cmbOTHOffice.Text, frmComputers.cmbOTHPCL, frmComputers.cmbOTHotv.Text, frmComputers.sCOUNT)

    End Sub

    Private Sub USBУстройстваToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles USBУстройстваToolStripMenuItem.Click
        frmComputers.txtMonDum.Visible = False
        'frmComputers.txtOTHSN.Left = "249" 'esq 130612"249"
        'frmComputers.txtOTHSN.Width = "214" 'esq 130612 "214"

        Call ClearForm(frmComputers)

        FillComboNET(frmComputers.cmbOTH, "name", "SPR_USB", "", False, True)
        frmComputers.lblTipOther.Visible = False
        frmComputers.cmbOTHConnect.Visible = False

        frmComputers.lblOTMac.Visible = False
        frmComputers.lblOtIp.Visible = False
        frmComputers.txtOTHIP.Visible = False
        frmComputers.txtOTHMAC.Visible = False

        frmComputers.sSTAB3.Visible = True
        frmComputers.sSTAB1.Visible = False
        frmComputers.sSTAB2.Visible = False
        frmComputers.sSTAB4.Visible = False
        frmComputers.sSTAB5.Visible = False
        TipTehn = "USB"
        frmComputers.EDT = False

        frmComputers.selectTECMesto()
        frmComputers.cmbOTHFil.Text = sBranch
        frmComputers.cmbOTHDepart.Text = sDepartment
        frmComputers.cmbOTHOffice.Text = sOffice

        frmComputers.lblOTPCL.Visible = True
        frmComputers.cmbOTHPCL.Visible = True

        Call LOAD_PCL(frmComputers.cmbOTHFil.Text, frmComputers.cmbOTHDepart.Text, frmComputers.cmbOTHOffice.Text, frmComputers.cmbOTHPCL, frmComputers.cmbOTHotv.Text, frmComputers.sCOUNT)

    End Sub

    Private Sub КлавиатураToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles КлавиатураToolStripMenuItem.Click
        frmComputers.txtMonDum.Visible = False
        'frmComputers.txtOTHSN.Left = "249" 'esq 130612"249"
        'frmComputers.txtOTHSN.Width = "214" 'esq 130612 "214"

        Call ClearForm(frmComputers)

        FillComboNET(frmComputers.cmbOTH, "name", "SPR_KEYBOARD", "", False, True)
        frmComputers.lblTipOther.Visible = False
        frmComputers.cmbOTHConnect.Visible = False

        frmComputers.lblOTMac.Visible = False
        frmComputers.lblOtIp.Visible = False
        frmComputers.txtOTHIP.Visible = False
        frmComputers.txtOTHMAC.Visible = False

        frmComputers.sSTAB3.Visible = True
        frmComputers.sSTAB1.Visible = False
        frmComputers.sSTAB2.Visible = False
        frmComputers.sSTAB4.Visible = False
        frmComputers.sSTAB5.Visible = False
        TipTehn = "KEYB"
        frmComputers.EDT = False

        frmComputers.selectTECMesto()
        frmComputers.cmbOTHFil.Text = sBranch
        frmComputers.cmbOTHDepart.Text = sDepartment
        frmComputers.cmbOTHOffice.Text = sOffice

        frmComputers.lblOTPCL.Visible = True
        frmComputers.cmbOTHPCL.Visible = True

        Call LOAD_PCL(frmComputers.cmbOTHFil.Text, frmComputers.cmbOTHDepart.Text, frmComputers.cmbOTHOffice.Text, frmComputers.cmbOTHPCL, frmComputers.cmbOTHotv.Text, frmComputers.sCOUNT)

    End Sub

    Private Sub МышьToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles МышьToolStripMenuItem.Click
        frmComputers.txtMonDum.Visible = False
        'frmComputers.txtOTHSN.Left = "249" 'esq 130612"249"
        'frmComputers.txtOTHSN.Width = "214" 'esq 130612 "214"

        Call ClearForm(frmComputers)

        FillComboNET(frmComputers.cmbOTH, "name", "SPR_MOUSE", "", False, True)
        frmComputers.lblTipOther.Visible = False
        frmComputers.cmbOTHConnect.Visible = False

        frmComputers.lblOTMac.Visible = False
        frmComputers.lblOtIp.Visible = False
        frmComputers.txtOTHIP.Visible = False
        frmComputers.txtOTHMAC.Visible = False

        frmComputers.sSTAB3.Visible = True
        frmComputers.sSTAB1.Visible = False
        frmComputers.sSTAB2.Visible = False
        frmComputers.sSTAB4.Visible = False
        frmComputers.sSTAB5.Visible = False
        TipTehn = "MOUSE"
        frmComputers.EDT = False

        frmComputers.selectTECMesto()
        frmComputers.cmbOTHFil.Text = sBranch
        frmComputers.cmbOTHDepart.Text = sDepartment
        frmComputers.cmbOTHOffice.Text = sOffice

        frmComputers.lblOTPCL.Visible = True
        frmComputers.cmbOTHPCL.Visible = True

        Call LOAD_PCL(frmComputers.cmbOTHFil.Text, frmComputers.cmbOTHDepart.Text, frmComputers.cmbOTHOffice.Text, frmComputers.cmbOTHPCL, frmComputers.cmbOTHotv.Text, frmComputers.sCOUNT)

    End Sub

    Private Sub ИнвентаризацияToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ИнвентаризацияToolStripMenuItem.Click

        'Call INVENT()
        frmComputers.BeginInvoke(New MethodInvoker(AddressOf INVENT))
    End Sub

    Private Sub РемонтыToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles РемонтыToolStripMenuItem.Click
        If sRelogin = True Then Exit Sub
        If DATAB = False Then Exit Sub

        frmReports.MdiParent = Me
        frmReports.Show()
        frmReports.sSTAB1.SelectedTab = frmReports.sSTAB1.TabPages("TabPage3")
        frmReports.Focus()

    End Sub

    Private Sub CNTToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CNTToolStripMenuItem.Click

        Call ClearForm(frmComputers)

        frmComputers.cmbOTH.Items.Clear()

        'FillComboNET(frmComputers.cmbOTH, "name", "SPR_OTH_DEV", "", False, True)
        'FillComboNET(frmComputers.cmbOTHConnect, "name", "spr_other", "", False, True)

        'On Error Resume Next
        On Error GoTo err_
        frmComputers.cmbOTH.Items.Clear()

        Dim rs As ADODB.Recordset

        rs = New ADODB.Recordset
        rs.Open("SELECT count(*) as t_n FROM spr_other WHERE name <> '' and C='1'", DB7, ADODB.CursorTypeEnum.adOpenDynamic, ADODB.LockTypeEnum.adLockReadOnly)
        Dim COUnT As String
        With rs

            COUnT = .Fields("t_n").Value

        End With
        rs.Close()
        rs = Nothing

        Select Case COUnT

            Case 0

            Case Else

                rs = New ADODB.Recordset
                rs.Open("SELECT name FROM spr_other WHERE name <> '' and C='1' ORDER BY name", DB7, ADODB.CursorTypeEnum.adOpenDynamic, ADODB.LockTypeEnum.adLockReadOnly)

                With rs
                    .MoveFirst()
                    Do While Not .EOF

                        frmComputers.cmbOTH.Items.Add(.Fields("name").Value)

                        .MoveNext()
                    Loop
                End With

                rs.Close()
                rs = Nothing

        End Select

        frmComputers.lblTipOther.Visible = True
        frmComputers.cmbOTHConnect.Visible = True
        frmComputers.lblOTMac.Visible = True
        frmComputers.lblOtIp.Visible = True
        frmComputers.txtOTHIP.Visible = True
        frmComputers.txtOTHMAC.Visible = True
        frmComputers.sSTAB3.Visible = True
        frmComputers.sSTAB1.Visible = False
        frmComputers.sSTAB2.Visible = False
        frmComputers.sSTAB4.Visible = False
        frmComputers.sSTAB5.Visible = False
        TipTehn = "CNT"
        frmComputers.EDT = False
        frmComputers.selectTECMesto()
        frmComputers.cmbOTHFil.Text = sBranch
        frmComputers.cmbOTHDepart.Text = sDepartment
        frmComputers.cmbOTHOffice.Text = sOffice

        frmComputers.lblOTPCL.Visible = False
        frmComputers.cmbOTHPCL.Visible = False

        '  Call LOAD_PCL(frmComputers.cmbOTHFil.Text, frmComputers.cmbOTHDepart.Text, frmComputers.cmbOTHOffice.Text, frmComputers.cmbOTHPCL)

        Exit Sub
err_:
        MsgBox(Err.Description, MsgBoxStyle.Information, ProGramName)

    End Sub

    Private Sub КабельныеЖурналыToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles netMagmnu.Click

        If sRelogin = True Then Exit Sub
        If DATAB = False Then Exit Sub

        frmNetMagazin.MdiParent = Me
        frmNetMagazin.Show()
        frmNetMagazin.Focus()
    End Sub

    Private Sub TimerEventHandler(ByVal obj As Object, ByVal ergs As EventArgs)
        On Error Resume Next

        If DATAB = False Then Exit Sub

        If TimeOfDay.Minute = 0 And TimeOfDay.Second = 0 Then

            Dim LNGIniFile As New IniFile(sLANGPATH)

            Dim rs As ADODB.Recordset

            Dim sSQL, SERT, SERT2, uname, SERT3 As String

            sSQL = "SELECT COUNT(*) AS total_number FROM Remont"

            rs = New ADODB.Recordset
            rs.Open(sSQL, DB7, ADODB.CursorTypeEnum.adOpenDynamic, ADODB.LockTypeEnum.adLockOptimistic)

            With rs
                SERT = .Fields("total_number").Value
            End With

            rs.Close()
            rs = Nothing

            Select Case SERT

                Case 0

                Case Else
                    rs = New ADODB.Recordset
                    rs.Open("SELECT name FROM SPR_Master WHERE A='" & UserNames & "'", DB7, ADODB.CursorTypeEnum.adOpenDynamic, ADODB.LockTypeEnum.adLockOptimistic)

                    With rs
                        uname = .Fields("name").Value
                    End With

                    rs.Close()
                    rs = Nothing

                    If uname = Nothing Then uname = "ADMINISTRATOR"

                    sSQL = "SELECT COUNT(*) AS total_number FROM Remont WHERE otvetstv='" & uname & "'"

                    rs = New ADODB.Recordset
                    rs.Open(sSQL, DB7, ADODB.CursorTypeEnum.adOpenDynamic, ADODB.LockTypeEnum.adLockOptimistic)

                    With rs
                        SERT2 = .Fields("total_number").Value
                    End With
                    rs.Close()
                    rs = Nothing

                    Select Case SERT2

                        Case 0

                        Case Else

                            sSQL = "SELECT COUNT(*) AS total_number FROM Remont Where otvetstv='" & uname & "' and zakryt = 0"

                            rs = New ADODB.Recordset
                            rs.Open(sSQL, DB7, ADODB.CursorTypeEnum.adOpenDynamic, ADODB.LockTypeEnum.adLockOptimistic)

                            With rs
                                SERT3 = .Fields("total_number").Value
                            End With
                            rs.Close()
                            rs = Nothing

                            Select Case SERT3

                                Case 0

                                Case Else

                                    MsgBox(LNGIniFile.GetString("frmMain", "MSG10", "Имеются не завершенные ремонты в количестве:") & " " & SERT3 & " " & LNGIniFile.GetString("frmMain", "MSG11", "шт."), MsgBoxStyle.Information, ProGramName)

                            End Select


                    End Select

            End Select


        End If

    End Sub

    Private Sub ПерегрузкаСрправочниковToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ПерегрузкаСрправочниковToolStripMenuItem.Click

        If sRelogin = True Then Exit Sub
        If DATAB = False Then Exit Sub

        'Dim newThread2 As New Thread(AddressOf LoadSPR_1)
        'newThread2.Start()

        frmComputers.BeginInvoke(New MethodInvoker(AddressOf LoadSPR))

    End Sub

    Private Sub ПроверитьФилиалыОтделыToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ПроверитьФилиалыОтделыToolStripMenuItem.Click

        If DATAB = False Then Exit Sub

        'Dim newThread1 As New Thread(AddressOf add_kabn_if_nothing)
        'newThread1.Start()
        'newThread1.Priority = 4
        frmComputers.BeginInvoke(New MethodInvoker(AddressOf add_kabn_if_nothing))

    End Sub

    Private Sub SaveToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SaveToolStripMenuItem.Click
        If SaveInfTehButton.Enabled = False Then Exit Sub

        '  Call SaveInfTeh()
        Me.BeginInvoke(New MethodInvoker(AddressOf SaveInfTeh))

    End Sub

    Private Sub ReloginToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ReloginToolStripMenuItem.Click

        ' Call RELOGIN()
        Me.BeginInvoke(New MethodInvoker(AddressOf RELOGIN))

    End Sub

    Private Sub RELOGIN()

        sRelogin = True

        UnLoadDatabase()

        ' Call ClearForm(frmComputers)

        frm_os3.Close()
        frm_wmi.Close()
        frmACT_OS_Act_treb.Close()
        frmAct_Treb.Close()
        frmARHIV.Close()
        frmCartr_ADD.Close()
        frmCartr_Add_Zap.Close()
        frmComputers.Close()
        frmCRT3.Close()
        frmDev.Close()
        frmDirectory.Close()
        frmGarCPL.Close()
        frmLOG.Close()
        frmNetMag_Add.Close()
        frmNetMag_selectSVT.Close()
        frmNetMagazin.Close()
        frmPPR.Close()
        frmReports.Close()
        frmSclad.Close()
        frmSclad_ADD.Close()
        frmSclad_treb.Close()
        frmSearch.Close()
        frmserviceDesc.Close()
        frmService_add.Close()
        frmservice_add_otvets.Close()
        frmSetup.Close()
        frmSheduler.Close()
        frmSoftware.Close()
        frmSQL.Close()
        frmTreb_Act_treb.Close()

        uLevel = ""
        uSERID = ""
        UserNames = ""

        NewToolStripMenuItem.Enabled = False
        УчётToolStripMenuItem.Enabled = False
        СправочникиToolStripMenuItem.Enabled = False
        ОтчётыToolStripMenuItem.Enabled = False
        ToolsMenu.Enabled = False
        ViewMenu.Enabled = False
        WindowsMenu.Enabled = False
        ToolStripButton1.Enabled = False
        NewToolStripButton.Enabled = False

        frmLogin.txtPassword.Text = ""
        frmLogin.ShowDialog(Me)

    End Sub

    Private Sub Services_ADD_Click(sender As System.Object, e As System.EventArgs) Handles Services_ADD.Click

        If sRelogin = True Then Exit Sub

        Dim langfile As New IniFile(sLANGPATH)

        frmService_add.Text = langfile.GetString("frmComputers", "MSG21", "Добавление (редактирование) заявки для ") & " " & TreeORGANIZACIA.SelectedNode.Text      'serviceDesc.MdiParent = frmMain

        'serviceDesc.Show()
        frmService_add.REMFU = True
        frmService_add.REMED = False
        frmService_add.cmbIst.Text = ""
        frmService_add.cmbMast.Text = ""
        frmService_add.txtPhone.Text = ""
        frmService_add.dtReg.Value = Date.Today
        frmService_add.dtIsp.Value = Date.Today
        frmService_add.txtHead.Text = ""
        frmService_add.txtRem.Text = ""
        frmService_add.cmbStatus.Text = ""
        frmService_add.cmbOtv.Text = ""
        frmService_add.cmbKrit.Text = ""
        frmService_add.cmbTip.Text = ""
        frmService_add.txtComent.Text = ""
        frmService_add.RemCashe.Text = 0
        frmService_add.chkClose.Checked = False

        frmService_add.ShowDialog(frmserviceDesc)

        Call _
            SaveActivityToLogDB(
                langfile.GetString("frmComputers", "MSG22", "Добавление заявки для ") & " " &
                TreeORGANIZACIA.SelectedNode.Text)
    End Sub

    Private Sub СинхронизацияПОToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles СинхронизацияПОToolStripMenuItem.Click
        'esq *********
        Dim rs, rs1, rs2 As Recordset
        Dim sSQL, sSQL1, sSQL2, F1, H1 As String
        Dim ID_PROIZV As Integer
        Dim Upd As Boolean

        ' выделение Версии из Наименования в SOFT_INSTALL
        If MsgBox("Внимание! Экспериментальная функция!" + vbCrLf + _
                  "Выделение Версии из Наименования в учёте ПО." + vbCrLf + _
                  "За номер версии принимаются символы в конце наименования если:" + vbCrLf + _
                  "- они заключены в <>;" + vbCrLf + _
                  "- они заключены в () и включают цифрой;" + vbCrLf + _
                  "- они содержат цифры и не менее одной точки." + vbCrLf + _
                  "" + vbCrLf + _
                  "Операция необратима! Если согласны - жмите ОК." + vbCrLf + vbCrLf + _
                  "P.S. Предложения принимаются на форуме. После полного одобрения " + _
                  "функция будет реализована и в импорте из эвереста.", vbOKCancel) = 2 Then GoTo ПропустимВерсии
        'sSQL = "SELECT * FROM SOFT_INSTALL WHERE Soft not like '%update%' and Soft not like '%Обновление%' ORDER BY Soft DESC"
        sSQL = "SELECT * FROM SOFT_INSTALL ORDER BY Soft DESC"
        rs = New Recordset
        rs.Open(sSQL, DB7, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic)
        With rs
            Try
                .MoveFirst()
            Catch ex As Exception
            End Try
            Do While Not .EOF
                'If IsDBNull(.Fields("VERS").Value) = True And InStr(.Fields("Soft").Value, "<") > 0 And InStr(.Fields("Soft").Value, ">") = Len(.Fields("Soft").Value) Then
                '    F1 = Mid(.Fields("Soft").Value, InStr(.Fields("Soft").Value, "<") + 1, InStr(.Fields("Soft").Value, ">") - InStr(.Fields("Soft").Value, "<") - 1)
                '    H1 = Trim(Mid(.Fields("Soft").Value, 1, InStr(.Fields("Soft").Value, "<") - 1))
                '    .Fields("Soft").Value = H1
                '    .Fields("VERS").Value = F1
                '.Update()
                F1 = ""
                Call GetVers(.Fields("Soft").Value, F1, Upd)
                If Upd = True Then
                    .Fields("VERS").Value = F1
                    .Update()
                End If
                .MoveNext()
            Loop
        End With
        rs.Close()
        rs = Nothing
        sSQL = "SELECT * FROM SPR_PO ORDER BY Name DESC"
        rs = New Recordset
        rs.Open(sSQL, DB7, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic)
        With rs
            Try
                .MoveFirst()
            Catch ex As Exception
            End Try
            Do While Not .EOF
                If InStr(.Fields("Name").Value, "<") > 0 And InStr(.Fields("Name").Value, ">") = Len(.Fields("Name").Value) Then
                    .Fields("Name").Value = Trim(Mid(.Fields("Name").Value, 1, InStr(.Fields("Name").Value, "<") - 1))
                    .Update()
                End If
                .MoveNext()
            Loop
        End With
        rs.Close()
        rs = Nothing

ПропустимВерсии:
        ' сжатие SPR_PO
        sSQL = "SELECT * FROM SPR_PO ORDER BY Name"
        rs = New Recordset
        rs.Open(sSQL, DB7, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic)
        With rs
            H1 = ""
            Try
                '.MovePrevious()
                .MoveFirst()
            Catch ex As Exception
            End Try
            Do While Not .EOF
                If H1 = .Fields("Name").Value Then
                    Try
                        H1 = .Fields("Name").Value
                        .Delete()
                    Catch ex As Exception
                    End Try
                Else
                    H1 = .Fields("Name").Value
                    sSQL2 = "SELECT * FROM SOFT_INSTALL WHERE Soft='" & .Fields("Name").Value & "'"
                    rs2 = New Recordset
                    rs2.Open(sSQL2, DB7, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic)
                    Select Case rs2.EOF
                        Case True
                            Try
                                .Delete()
                                .MovePrevious()
                            Catch ex As Exception
                            End Try
                        Case Else
                    End Select
                    rs2.Close()
                    rs2 = Nothing
                End If
                .MoveNext()
            Loop
        End With
        rs.Close()
        rs = Nothing


        ' сжатие SPR_PROIZV
        sSQL = "SELECT * FROM SPR_PROIZV ORDER BY Proizv DESC"
        rs = New Recordset
        rs.Open(sSQL, DB7, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic)
        With rs
            .MoveFirst()
            Do While Not .EOF
                If InStr(.Fields("Proizv").Value, "'") > 0 Then
                    .Fields("Proizv").Value = Replace(.Fields("Proizv").Value, "'", "")
                    .Update()
                End If
                .MoveNext()
            Loop
            .MoveFirst()
            Do While Not .EOF
                sSQL2 = "SELECT * FROM SOFT_INSTALL WHERE Publisher='" & .Fields("Proizv").Value & "'"
                rs2 = New Recordset
                rs2.Open(sSQL2, DB7, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic)
                Select Case rs2.EOF
                    Case True
                        Try
                            sSQL1 = "DELETE FROM SPR_PROIZV WHERE Proizv='" & .Fields("Proizv").Value & "'"
                            DB7.Execute(sSQL1)
                            '.MovePrevious()
                        Catch ex As Exception ' при удалении связанных записей
                        End Try
                    Case Else
                End Select
                rs2.Close()
                rs2 = Nothing
                .MoveNext()
            Loop
        End With
        rs.Close()
        rs = Nothing


        ' обновление SPR_PO
        'sSQL = "SELECT * FROM SOFT_INSTALL WHERE Soft not like '%update%' and Soft not like '%Обновление%' ORDER BY Soft DESC"
        sSQL = "SELECT * FROM SOFT_INSTALL ORDER BY Soft DESC"
        rs = New Recordset
        rs.Open(sSQL, DB7, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic)
        With rs
            .MoveFirst()
            Do While Not .EOF

                If F1 = "" Then
                End If

                If .Fields("Publisher").Value = "" Then
                    F1 = "NoName"
                Else
                    F1 = .Fields("Publisher").Value
                End If

                F1 = Replace(F1, "'", "")
                If Not RSExists("PROYZV", "PROIZV", F1) Then ' добавление нового производителя 
                    sSQL1 = "INSERT INTO SPR_PROIZV (Proizv) VALUES ('" & F1 & "')"
                    DB7.Execute(sSQL1)
                End If
                rs1 = New Recordset
                rs1.Open("SELECT * FROM SPR_PROIZV WHERE PROIZV='" & F1 & "'", DB7, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic)
                ID_PROIZV = rs1.Fields("ID").Value
                rs1.Close()
                rs1 = Nothing

                Dim strSimbol1 As String
                strSimbol1 = "'"
                H1 = .Fields("Soft").Value
                If InStr(.Fields("Soft").Value, strSimbol1) Then
                    H1 = Replace(.Fields("Soft").Value, strSimbol1, "")
                    .Fields("Soft").Value = H1
                    .Update()
                End If

                If Not RSExists("PO", "Name", H1) Then ' добавление нового ПО 
                    sSQL1 = "INSERT INTO SPR_PO (Name,Proizv,A,B,C,Prim) VALUES ('" & H1 & "'," & ID_PROIZV & ",'','','','')"
                    DB7.Execute(sSQL1)
                Else
                    sSQL1 = "UPDATE SPR_PO set Proizv=" & ID_PROIZV & " WHERE Name='" & H1 & "'" 'esq
                    DB7.Execute(sSQL1)
                End If

                .MoveNext()
            Loop
        End With
        rs.Close()
        rs = Nothing

        ' обновление SOFT_INSTALL
        sSQL = "SELECT * FROM SPR_PO ORDER BY Name"
        rs = New Recordset
        rs.Open(sSQL, DB7, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic)
        With rs
            Try
                .MoveFirst()
            Catch ex As Exception
            End Try
            Do While Not .EOF

                rs2 = New Recordset
                rs2.Open("SELECT * FROM SPR_PROIZV WHERE ID=" & .Fields("Proizv").Value, DB7, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic)
                Dim S_PROIZV As String
                S_PROIZV = rs2.Fields("PROIZV").Value
                rs2.Close()
                rs2 = Nothing

                rs2 = New Recordset
                rs2.Open("SELECT * FROM SOFT_INSTALL WHERE Soft='" & .Fields("Name").Value & "' and (Not(Publisher='" & S_PROIZV &
                         "') or Not(TIP='" & .Fields("A").Value & "'))",
                         DB7, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic)
                Try
                    rs2.MoveFirst()
                    Do While Not rs2.EOF
                        rs2.Fields("Publisher").Value = S_PROIZV
                        rs2.Fields("TIP").Value = .Fields("A").Value
                        rs2.Update()
                        rs2.MoveNext()
                    Loop
                Catch ex As Exception
                End Try
                rs2.Close()
                rs2 = Nothing
                .MoveNext()
            Loop
        End With
        rs.Close()
        rs = Nothing

    End Sub

    'esq *********
    Public Sub GetVers(ByRef POname As String, Optional ByRef POvers As String = "", Optional ByRef Upd As Boolean = False)

        If InStr(POname, "<") > 0 And InStr(POname, ">") = Len(POname) Then
            POvers = Mid(POname, InStr(POname, "<") + 1, InStr(POname, ">") - InStr(POname, "<") - 1)
            POname = Trim(Microsoft.VisualBasic.Left(POname, InStr(POname, "<") - 1))
            Upd = True
        End If

        If InStr(POname, "(KB") > 0 And InStr(POname, ")") = Len(POname) Then
            If IsNumeric(Mid(POname, InStr(POname, ")") - 1, 1)) Then
                POvers = Mid(POname, InStr(POname, "(") + 1, InStr(POname, ")") - InStr(POname, "(") - 1)
                POname = Trim(Microsoft.VisualBasic.Left(POname, InStr(POname, "(") - 1))
                Upd = True
                Exit Sub
            End If
        End If

        Dim pnt As Integer = 0
        Dim nv As Integer = Len(POname)
        If InStrRev(POname, "(") > 0 And InStrRev(POname, ")") = Len(POname) Then
            'If IsNumeric(Mid(POname, InStrRev(POname, "(") + 1, 1)) And IsNumeric(Mid(POname, InStrRev(POname, ")") - 1, 1)) Then
            Do While nv > InStrRev(POname, "(")
                If Mid(POname, nv, 1) Like "*[0-9]*" Then
                    pnt = pnt + 1
                End If
                nv = nv - 1
            Loop
            If pnt >= 1 Then
                POvers = Mid(POname, InStrRev(POname, "(") + 1, InStrRev(POname, ")") - InStrRev(POname, "(") - 1)
                POname = Trim(Microsoft.VisualBasic.Left(POname, InStrRev(POname, "(") - 1))
                Upd = True
            End If
        End If

        Dim no As Integer
        nv = Len(POname)
        If nv > 0 Then
            Do Until Mid(POname, nv, 1) Like "*[!0-9KB.]*" Or nv <= 1
                If Mid(POname, nv, 1) Like "*[KB.]*" Then
                    pnt = pnt + 1
                End If
                nv = nv - 1
            Loop
            no = nv
            If Mid(POname, no, 1) Like "*[-. ]*" And pnt >= 1 Then
                If Mid(POname, no - 1, 1) Like "*[-v.]*" Then
                    no = no - 1
                    If Mid(POname, no - 2, 1) Like "*[v]*" Then
                        no = no - 1
                    End If
                End If
            End If
        End If
        If pnt >= 1 Then
            POvers = Microsoft.VisualBasic.Right(POname, Len(POname) - nv) + IIf(POvers = "", "", " (" + POvers + ")")
            POname = Trim(Microsoft.VisualBasic.Left(POname, no - 1))
            Upd = True
            'Exit Sub
        End If
    End Sub
    'esq *********


End Class
