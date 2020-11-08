Imports System.IO
Imports System.Security.Principal
Imports ZXing

Module MOD_SYS_PRELOAD
    Public new_prov As Boolean
    'Public lngCounter As Integer
    Public iCOUNTFIELLDS As String
    Public ITEM_DB_COUNT As String
    Public ProGramName As String
    Public FontN As String
    Public fontS As Double
    Public FontC As String
    Public FontB As Boolean
    Public FontSt As FontStyle
    Public FontD As GraphicsUnit
    Public FontI As Integer
    Public srhLDAP As String

    Public RAZDEL As Integer
    Public TREE_UPDATE As Integer = 0
    Public TREE_REFRESH As Integer = 0

    Public KCKey As Integer
    Public DCKey As String
    Public TipTehn As String
    Public PrPath As String
    Public EverestFilePatch As String
    Public CHECKCFGFilePatch As String
    Public IdentifierMAC As String
    Public CS As String
    Public SUBD As String
    Public BaseName As String

    'Структура для перемещения
    Public sBranch As String
    Public sDepartment As String
    Public sOffice As String
    Public sName As String
    Public sOfficePACK As String
    'Пользователи программы
    Public uSERID As String
    Public UserNames As String
    Public uLevel As String
    Public uLevelSetup As Boolean
    Public uLevelTehAdd As Boolean
    Public uLevelTehDel As Boolean
    Public uLevelNotesAdd As Boolean
    Public uLevelNotesDel As Boolean
    Public uLevelRepAdd As Boolean
    Public uLevelRepDel As Boolean
    Public uLevelRepEd As Boolean
    Public uLevelPOAdd As Boolean
    Public uLevelPODel As Boolean
    Public uLevelCart As Boolean
    Public uLevelPO As Boolean
    Public uLevelWarehause As Boolean
    Public uPCNAME As String
    Public uUSERNAME As String
    Public uCASHE As String
    Public sLANGPATH As String
    Public sICONS As String
    Public sRelogin As Boolean = False
    Public sTechINF As String

    Public _DBALTER As Boolean = False
    Public sVERSIA As String
    Public remVisible As Boolean
    Public NotWorkvisible As Boolean
    Public SPVisible As Boolean
    Public NBVisible As Boolean
    Public TreeORGANIZACIA As TreeView

    Public NbColor As String
    Public SpisanColor As String
    Public ServiceColor As String

    Private Property Renderer As Type
    Private bmg As Bitmap
    Public pb As PictureBox = New PictureBox
    Public Upd_flag As Boolean = False



    Public Sub Tree_Icons_Feel(ByVal ills As ImageList, ByVal sFRM As String, ByVal sPATH As String)

        On Error Resume Next

        ills.Images.Clear()

        Select Case sICONS

            Case "32*32"

                frmComputers.ilsCommands.ImageSize = New Size(32, 32)

            Case Else

                frmComputers.ilsCommands.ImageSize = New Size(24, 24)

        End Select

        'ills.Images.Add(Image.FromFile(PrPath & sPATH & "Branche.png"))
        'ills.Images.Add(Image.FromFile(PrPath & sPATH & "Department.png"))
        'ills.Images.Add(Image.FromFile(PrPath & sPATH & "Office.png"))
        'ills.Images.Add(Image.FromFile(PrPath & sPATH & "Server.png"))
        'ills.Images.Add(Image.FromFile(PrPath & sPATH & "PC.png"))
        'ills.Images.Add(Image.FromFile(PrPath & sPATH & "Notebook.png"))
        'ills.Images.Add(Image.FromFile(PrPath & sPATH & "KPK.png"))
        'ills.Images.Add(Image.FromFile(PrPath & sPATH & "Printer.png"))
        'ills.Images.Add(Image.FromFile(PrPath & sPATH & "MFU.png"))

        'ills.Images.Add(Image.FromFile(PrPath & sPATH & "Copir.png"))
        'ills.Images.Add(Image.FromFile(PrPath & sPATH & "NET.png"))
        'ills.Images.Add(Image.FromFile(PrPath & sPATH & "Photo.png"))
        'ills.Images.Add(Image.FromFile(PrPath & sPATH & "Phone.png"))
        'ills.Images.Add(Image.FromFile(PrPath & sPATH & "Fax.png"))
        'ills.Images.Add(Image.FromFile(PrPath & sPATH & "Scanner.png"))
        'ills.Images.Add(Image.FromFile(PrPath & sPATH & "ZIP.png"))
        'ills.Images.Add(Image.FromFile(PrPath & sPATH & "Other.png"))
        'ills.Images.Add(Image.FromFile(PrPath & sPATH & "Monitor1.png"))

        'ills.Images.Add(Image.FromFile(PrPath & sPATH & "USB_FLASH.png"))
        'ills.Images.Add(Image.FromFile(PrPath & sPATH & "Calc.png"))
        'ills.Images.Add(Image.FromFile(PrPath & sPATH & "headphones.png"))
        'ills.Images.Add(Image.FromFile(PrPath & sPATH & "Microphon.png"))
        'ills.Images.Add(Image.FromFile(PrPath & sPATH & "Cam.png"))
        'ills.Images.Add(Image.FromFile(PrPath & sPATH & "Gamepad.png"))
        'ills.Images.Add(Image.FromFile(PrPath & sPATH & "Graph.png"))
        'ills.Images.Add(Image.FromFile(PrPath & sPATH & "SD_CARD1.png"))
        'ills.Images.Add(Image.FromFile(PrPath & sPATH & "SD_CARD2.png"))

        'ills.Images.Add(Image.FromFile(PrPath & sPATH & "SD_CARD3.png"))
        'ills.Images.Add(Image.FromFile(PrPath & sPATH & "Tape.png"))
        'ills.Images.Add(Image.FromFile(PrPath & sPATH & "iPod.png"))
        'ills.Images.Add(Image.FromFile(PrPath & sPATH & "Antenn.png"))
        'ills.Images.Add(Image.FromFile(PrPath & sPATH & "M_Phones1.png"))
        'ills.Images.Add(Image.FromFile(PrPath & sPATH & "M_Phones2.png"))
        'ills.Images.Add(Image.FromFile(PrPath & sPATH & "Monitor2.png"))
        'ills.Images.Add(Image.FromFile(PrPath & sPATH & "Proector.png"))
        'ills.Images.Add(Image.FromFile(PrPath & sPATH & "Monitor3.png"))

        'ills.Images.Add(Image.FromFile(PrPath & sPATH & "G_Key.png"))
        'ills.Images.Add(Image.FromFile(PrPath & sPATH & "USB1.png"))
        'ills.Images.Add(Image.FromFile(PrPath & sPATH & "DVD.png"))
        'ills.Images.Add(Image.FromFile(PrPath & sPATH & "HDD.png"))
        'ills.Images.Add(Image.FromFile(PrPath & sPATH & "M_PHOTO.png"))
        'ills.Images.Add(Image.FromFile(PrPath & sPATH & "IBP.png"))
        'ills.Images.Add(Image.FromFile(PrPath & sPATH & "Accustic1.png"))
        'ills.Images.Add(Image.FromFile(PrPath & sPATH & "People1.png"))
        'ills.Images.Add(Image.FromFile(PrPath & sPATH & "Accustic2.png"))

        'ills.Images.Add(Image.FromFile(PrPath & sPATH & "USB2.png"))
        'ills.Images.Add(Image.FromFile(PrPath & sPATH & "Keyboard.png"))
        'ills.Images.Add(Image.FromFile(PrPath & sPATH & "Mouse.png"))
        'ills.Images.Add(Image.FromFile(PrPath & sPATH & "Socket.png"))
        'ills.Images.Add(Image.FromFile(PrPath & sPATH & "Cartridg.png"))
        'ills.Images.Add(Image.FromFile(PrPath & sPATH & "Jack.png"))
        'ills.Images.Add(Image.FromFile(PrPath & sPATH & "Portf.png"))
        'ills.Images.Add(Image.FromFile(PrPath & sPATH & "Battary.png"))
        'ills.Images.Add(Image.FromFile(PrPath & sPATH & "List.png"))

        'Select Case sFRM

        '    Case "DIR"

        '    Case Else
        '        ills.Images.Add(Image.FromFile(PrPath & sPATH & "PCMCI1.png"))
        '        ills.Images.Add(Image.FromFile(PrPath & sPATH & "devices1.png"))
        '        ills.Images.Add(Image.FromFile(PrPath & sPATH & "devices2.png"))
        '        ills.Images.Add(Image.FromFile(PrPath & sPATH & "devices3.png"))
        '        ills.Images.Add(Image.FromFile(PrPath & sPATH & "HID.png"))
        '        ills.Images.Add(Image.FromFile(PrPath & sPATH & "PCMCI2.png"))
        '        ills.Images.Add(Image.FromFile(PrPath & sPATH & "Label.png"))
        '        ills.Images.Add(Image.FromFile(PrPath & sPATH & "Filter.png"))
        '        ills.Images.Add(Image.FromFile(PrPath & sPATH & "SIM.png"))

        '        ills.Images.Add(Image.FromFile(PrPath & sPATH & "Soft.png"))
        '        ills.Images.Add(Image.FromFile(PrPath & sPATH & "Hand_scanner.png"))
        '        ills.Images.Add(Image.FromFile(PrPath & sPATH & "chair.png"))
        '        ills.Images.Add(Image.FromFile(PrPath & sPATH & "Guitar.png"))
        '        ills.Images.Add(Image.FromFile(PrPath & sPATH & "BlueTouch.png"))

        '        ills.Images.Add(Image.FromFile(PrPath & sPATH & "Case.png"))
        '        ills.Images.Add(Image.FromFile(PrPath & sPATH & "Root.png"))
        '        ills.Images.Add(Image.FromFile(PrPath & sPATH & "BigCase.png"))

        ills.Images.Add(Image.FromFile(PrPath & sPATH & "A1.png"))
        ills.Images.Add(Image.FromFile(PrPath & sPATH & "A2.png"))
        ills.Images.Add(Image.FromFile(PrPath & sPATH & "A3.png"))
        ills.Images.Add(Image.FromFile(PrPath & sPATH & "A4.png"))
        ills.Images.Add(Image.FromFile(PrPath & sPATH & "A5.png"))
        ills.Images.Add(Image.FromFile(PrPath & sPATH & "A6.png"))
        ills.Images.Add(Image.FromFile(PrPath & sPATH & "A7.png"))
        ills.Images.Add(Image.FromFile(PrPath & sPATH & "A8.png"))
        ills.Images.Add(Image.FromFile(PrPath & sPATH & "A9.png"))

        ills.Images.Add(Image.FromFile(PrPath & sPATH & "B1.png"))
        ills.Images.Add(Image.FromFile(PrPath & sPATH & "B2.png"))
        ills.Images.Add(Image.FromFile(PrPath & sPATH & "B3.png"))
        ills.Images.Add(Image.FromFile(PrPath & sPATH & "B4.png"))
        ills.Images.Add(Image.FromFile(PrPath & sPATH & "B5.png"))
        ills.Images.Add(Image.FromFile(PrPath & sPATH & "B6.png"))
        ills.Images.Add(Image.FromFile(PrPath & sPATH & "B7.png"))
        ills.Images.Add(Image.FromFile(PrPath & sPATH & "B8.png"))
        ills.Images.Add(Image.FromFile(PrPath & sPATH & "B9.png"))

        ills.Images.Add(Image.FromFile(PrPath & sPATH & "C1.png"))
        ills.Images.Add(Image.FromFile(PrPath & sPATH & "C2.png"))
        ills.Images.Add(Image.FromFile(PrPath & sPATH & "C3.png"))
        ills.Images.Add(Image.FromFile(PrPath & sPATH & "C4.png"))
        ills.Images.Add(Image.FromFile(PrPath & sPATH & "C5.png"))
        ills.Images.Add(Image.FromFile(PrPath & sPATH & "C6.png"))
        ills.Images.Add(Image.FromFile(PrPath & sPATH & "C7.png"))
        ills.Images.Add(Image.FromFile(PrPath & sPATH & "C8.png"))
        ills.Images.Add(Image.FromFile(PrPath & sPATH & "C9.png"))

        ills.Images.Add(Image.FromFile(PrPath & sPATH & "D1.png"))
        ills.Images.Add(Image.FromFile(PrPath & sPATH & "D2.png"))
        ills.Images.Add(Image.FromFile(PrPath & sPATH & "D3.png"))
        ills.Images.Add(Image.FromFile(PrPath & sPATH & "D4.png"))
        ills.Images.Add(Image.FromFile(PrPath & sPATH & "D5.png"))
        ills.Images.Add(Image.FromFile(PrPath & sPATH & "D6.png"))
        ills.Images.Add(Image.FromFile(PrPath & sPATH & "D7.png"))
        ills.Images.Add(Image.FromFile(PrPath & sPATH & "D8.png"))
        ills.Images.Add(Image.FromFile(PrPath & sPATH & "D9.png"))

        ills.Images.Add(Image.FromFile(PrPath & sPATH & "E1.png"))
        ills.Images.Add(Image.FromFile(PrPath & sPATH & "E2.png"))
        ills.Images.Add(Image.FromFile(PrPath & sPATH & "E3.png"))
        ills.Images.Add(Image.FromFile(PrPath & sPATH & "E4.png"))
        ills.Images.Add(Image.FromFile(PrPath & sPATH & "E5.png"))
        ills.Images.Add(Image.FromFile(PrPath & sPATH & "E6.png"))
        ills.Images.Add(Image.FromFile(PrPath & sPATH & "E7.png"))
        ills.Images.Add(Image.FromFile(PrPath & sPATH & "E8.png"))
        ills.Images.Add(Image.FromFile(PrPath & sPATH & "E9.png"))

        ills.Images.Add(Image.FromFile(PrPath & sPATH & "F1.png"))
        ills.Images.Add(Image.FromFile(PrPath & sPATH & "F2.png"))
        ills.Images.Add(Image.FromFile(PrPath & sPATH & "F3.png"))
        ills.Images.Add(Image.FromFile(PrPath & sPATH & "F4.png"))
        ills.Images.Add(Image.FromFile(PrPath & sPATH & "F5.png"))

        ills.Images.Add(Image.FromFile(PrPath & sPATH & "F6.png"))
        ills.Images.Add(Image.FromFile(PrPath & sPATH & "F7.png"))
        ills.Images.Add(Image.FromFile(PrPath & sPATH & "F8.png"))
        ills.Images.Add(Image.FromFile(PrPath & sPATH & "F9.png"))

        Select Case sFRM

            Case "DIR"

            Case Else
                ills.Images.Add(Image.FromFile(PrPath & sPATH & "G1.png"))
                ills.Images.Add(Image.FromFile(PrPath & sPATH & "G2.png"))
                ills.Images.Add(Image.FromFile(PrPath & sPATH & "G3.png"))
                ills.Images.Add(Image.FromFile(PrPath & sPATH & "G4.png"))
                ills.Images.Add(Image.FromFile(PrPath & sPATH & "G5.png"))
                ills.Images.Add(Image.FromFile(PrPath & sPATH & "G6.png"))
                ills.Images.Add(Image.FromFile(PrPath & sPATH & "G7.png"))
                ills.Images.Add(Image.FromFile(PrPath & sPATH & "G8.png"))
                ills.Images.Add(Image.FromFile(PrPath & sPATH & "G9.png"))

                ills.Images.Add(Image.FromFile(PrPath & sPATH & "H1.png"))
                ills.Images.Add(Image.FromFile(PrPath & sPATH & "H2.png"))
                ills.Images.Add(Image.FromFile(PrPath & sPATH & "H3.png"))
                ills.Images.Add(Image.FromFile(PrPath & sPATH & "H4.png"))
                ills.Images.Add(Image.FromFile(PrPath & sPATH & "H5.png"))

                ills.Images.Add(Image.FromFile(PrPath & sPATH & "I1.png"))
                ills.Images.Add(Image.FromFile(PrPath & sPATH & "A0.png"))
                ills.Images.Add(Image.FromFile(PrPath & sPATH & "I2.png"))


        End Select

        Dim allowedExtensions() As String = {".png"}
        Dim dirFiles() As String = Directory.GetFiles(PrPath & "pic\")


        For Each dirFile As String In dirFiles
            For Each extension As String In allowedExtensions

                Select Case extension

                    Case Path.GetExtension(dirFile)

                        ills.Images.Add(Image.FromFile(dirFile))

                End Select

            Next
        Next
    End Sub

    Public Sub frmservills_load()

        Select Case frmserviceDesc.ilsCMD.Images.Count

            Case 0

                frmserviceDesc.ilsCMD.Images.Add(Image.FromFile(PrPath & "pic\iface\ok.png"))
                frmserviceDesc.ilsCMD.Images.Add(Image.FromFile(PrPath & "pic\iface\servnz.png"))
                frmserviceDesc.ilsCMD.Images.Add(Image.FromFile(PrPath & "pic\iface\pcupdate.png"))

        End Select

    End Sub

    Public Sub PreLoad()

        'Dim langFile As String
        PrPath = Directory.GetParent(Application.ExecutablePath).ToString & "\"

        Dim objIniFile As New IniFile(PrPath & "base.ini")
        BasePath = objIniFile.GetString("general", "BasePath", "")
        IdentifierMAC = objIniFile.GetString("IdentifierMAC", "Check", "0")

        BasePath = BasePath & "\"

        'Проверяем есть ли необхадимые каталоги, если нет то создаем
        If IO.Directory.Exists(Directory.GetParent(Application.ExecutablePath).ToString & "\database") Then
        Else
            IO.Directory.CreateDirectory(Directory.GetParent(Application.ExecutablePath).ToString & "\database")
        End If

        If IO.Directory.Exists(Directory.GetParent(Application.ExecutablePath).ToString & "\QR_CODE") Then
        Else
            IO.Directory.CreateDirectory(Directory.GetParent(Application.ExecutablePath).ToString & "\QR_CODE")
        End If

        If IO.Directory.Exists(Directory.GetParent(Application.ExecutablePath).ToString & "\arhiv") Then
        Else
            IO.Directory.CreateDirectory(Directory.GetParent(Application.ExecutablePath).ToString & "\arhiv")
        End If

        If IO.Directory.Exists(Directory.GetParent(Application.ExecutablePath).ToString & "\blanks") Then
        Else
            IO.Directory.CreateDirectory(Directory.GetParent(Application.ExecutablePath).ToString & "\blanks")
        End If

        If IO.Directory.Exists(Directory.GetParent(Application.ExecutablePath).ToString & "\img") Then
        Else
            IO.Directory.CreateDirectory(Directory.GetParent(Application.ExecutablePath).ToString & "\img")
        End If

        If IO.Directory.Exists(Directory.GetParent(Application.ExecutablePath).ToString & "\pic") Then
        Else
            IO.Directory.CreateDirectory(Directory.GetParent(Application.ExecutablePath).ToString & "\pic")
        End If

        If IO.Directory.Exists(Directory.GetParent(Application.ExecutablePath).ToString & "\lang") Then
        Else
            IO.Directory.CreateDirectory(Directory.GetParent(Application.ExecutablePath).ToString & "\lang")
        End If


        'If BasePath = Nothing Or Len(BasePath) < 3 Then

        '    BasePath = Directory.GetParent(Application.ExecutablePath).ToString & "\database\"
        '    objIniFile.WriteString("general", "BasePath", BasePath)
        'End If

        'Определяем каталог с базами данных
        Select Case BasePath

            Case Nothing

                BasePath = Directory.GetParent(Application.ExecutablePath).ToString & "\database\"
                objIniFile.WriteString("general", "BasePath", BasePath)

        End Select

        'определяем файл базы данных (для акеса)
        Base_Name = objIniFile.GetString("general", "file", "basekomp.mdb")

        'Офисный пакет
        sOfficePACK = objIniFile.GetString("general", "Office", "OpenOffice.org")

        'языковой пакет
        sLANGPATH = PrPath & "lang\" & objIniFile.GetString("general", "LANG", "ru.ini")

        'Размер иконок
        sICONS = objIniFile.GetString("General", "ICONs", "24*24")

        'Формат отчетов о компах
        sTechINF = objIniFile.GetString("General", "TechINF", "AIDA64(Everest)")

        'Шрифт
        FontI = objIniFile.GetString("General", "chkFonts", "0")

        'Как работаем с деревом
        TREE_UPDATE = objIniFile.GetString("General", "TREE_UPDATE", "1")

        'Как работаем с деревом
        TREE_REFRESH = objIniFile.GetString("General", "TREE_REFRESH", "1")

        'LDAP для загрузки данных о пользователях
        srhLDAP = objIniFile.GetString("General", "LDAP", "")


        'Выделение в дереве
        remVisible = objIniFile.GetString("TREE", "REM", "0")
        NBVisible = objIniFile.GetString("TREE", "NB", "1")
        SPVisible = objIniFile.GetString("TREE", "SP", "1")
        NbColor = objIniFile.GetString("TREE", "NbColor", "Black")
        SpisanColor = objIniFile.GetString("TREE", "SpisanColor", "Black")
        ServiceColor = objIniFile.GetString("TREE", "ServiceColor", "Yellow")


        Select Case sICONS

            Case "32*32"

                sICONS = "32*32"

            Case Else

                sICONS = "24*24"

        End Select


        Call UNAME_GET()

        'esq 160307 frmMain.BeginInvoke(New MethodInvoker(AddressOf iface_preload))
        Call iface_preload() 'esq 160307

        Application.DoEvents()

        ' Call UNAME_GET()

    End Sub

    Public Sub iface_preload()

        Dim objIniFile As New IniFile(PrPath & "base.ini")

        FontN = objIniFile.GetString("general", "Font", "Microsoft Sans Serif")
        fontS = objIniFile.GetString("general", "FontSize", "8")
        FontC = objIniFile.GetString("general", "FontColor", "Black")
        FontB = objIniFile.GetString("general", "FontBold", "False")
        FontSt = objIniFile.GetString("general", "FontStyle", "0")
        FontD = objIniFile.GetString("general", "FontUnit", "3")

        If fontS > 10 Then fontS = 10
    End Sub

    Public Sub UNAME_GET()
        Dim rName As String = My.Computer.Name
        Dim lSlash As Integer = rName.LastIndexOf("\")
        Dim fName As String = rName.Substring(lSlash + 1)

        uPCNAME = fName
        uUSERNAME = WindowsIdentity.GetCurrent.Name

        's = GetCurrent.User.Value
    End Sub

    Public Sub VisibleForm(ByVal ControlContainer As Object)

        frmComputers.sCPU = 4
        frmComputers.sRAM = 4
        frmComputers.sHDD = 4
        frmComputers.sVGA = 2
        frmComputers.sOPTICAL = 3
        frmComputers.sNET = 2

        For Each Ctl As Object In ControlContainer.Controls
            Try
                If Not Ctl.Controls Is Nothing Then
                    VisibleForm(Ctl)

                    If TypeOf Ctl Is TextBox Then Ctl.visible = True
                    If TypeOf Ctl Is ComboBox Then Ctl.visible = True

                End If

            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        Next

        frmComputers.bCPUPlus.Visible = False
        frmComputers.bRamPlus.Visible = False
        frmComputers.bHddPlus.Visible = False
        frmComputers.bSVGAPlus.Visible = False
        frmComputers.bOpticalPlus.Visible = False
        frmComputers.bNetPlus.Visible = False
        frmComputers.bMonitorPlus.Visible = False
        frmComputers.bPrinterPlus.Visible = False
    End Sub

    Public Sub COLOR_Form_For_Computer(ByVal ControlContainer As Object)

        For Each Ctl As Object In ControlContainer.Controls
            Try
                If Not Ctl.Controls Is Nothing Then
                    COLOR_Form_For_Computer(Ctl)

                    If TypeOf Ctl Is TextBox Then Ctl.BackColor = Color.White
                    If TypeOf Ctl Is ComboBox Then Ctl.BackColor = Color.White

                End If

            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        Next
    End Sub

    Public Sub combo_Computer(ByVal ControlContainer As Object)

        For Each Ctl As Object In ControlContainer.Controls
            Try
                If Not Ctl.Controls Is Nothing Then
                    combo_Computer(Ctl)

                    If TypeOf Ctl Is ComboBox Then Ctl.FlatStyle = FlatStyle.Flat
                    ' frmComputers.cmbCPU1.FlatStyle = FlatStyle.Flat
                End If

            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        Next
    End Sub



    Public Sub SendFonts(ByVal ControlContainer As Object)

        If FontI = 0 Then Exit Sub

        If _
            FontN = "Microsoft Sans Serif" And fontS = "8,25" And FontC = "Black" And FontB = False And FontSt = 0 And
            FontD = 3 Then Exit Sub

        For Each Ctl As Object In ControlContainer.Controls
            Try
                If Not Ctl.Controls Is Nothing Then
                    SendFonts(Ctl)

                    'esq 160307 *****
                    If InStr("TextBox, ComboBox, Label, ListView, TreeView, TabPage, GroupBox,DateTimePicker, NumericUpDown," _
                        + "Button, CheckBox, RadioButton, MenuStrip,ToolStrip, StatusStrip, ListBox, Form, TabControl", Ctl.GetType().Name) > 0 Then
                        Ctl.Font = New Font(FontN, fontS, FontSt, FontD, FontB)
                    End If

                    If InStr("Button, Label, TableLayoutPanel, GroupBox, CheckBox, RadioButton, Form", Ctl.GetType().Name) > 0 Then
                        Ctl.AutoSize = True
                    End If

                    If InStr("Form, TableLayoutPanel, GroupBox, Label, CheckBox, RadioButton, TextBox, ComboBox, ListView", Ctl.GetType().Name) > 0 Then
                        Ctl.ForeColor = Color.FromName(FontC)
                    End If

                    'esq 160307 *********


                    'If TypeOf Ctl Is TextBox Then Ctl.Font = New Font(FontN, fontS, FontSt, FontD, FontB)
                    'If TypeOf Ctl Is ComboBox Then Ctl.Font = New Font(FontN, fontS, FontSt, FontD, FontB)
                    'If TypeOf Ctl Is Label Then Ctl.Font = New Font(FontN, fontS, FontSt, FontD, FontB)
                    'If TypeOf Ctl Is ListView Then Ctl.Font = New Font(FontN, fontS, FontSt, FontD, FontB)
                    'If TypeOf Ctl Is TreeView Then Ctl.Font = New Font(FontN, fontS, FontSt, FontD, FontB)
                    'If TypeOf Ctl Is TabPage Then Ctl.Font = New Font(FontN, fontS, FontSt, FontD, FontB)
                    'If TypeOf Ctl Is GroupBox Then Ctl.Font = New Font(FontN, fontS, FontSt, FontD, FontB)
                    'If TypeOf Ctl Is DateTimePicker Then Ctl.Font = New Font(FontN, fontS, FontSt, FontD, FontB)
                    'If TypeOf Ctl Is NumericUpDown Then Ctl.Font = New Font(FontN, fontS, FontSt, FontD, FontB)
                    'If TypeOf Ctl Is Button Then Ctl.Font = New Font(FontN, fontS, FontSt, FontD, FontB)
                    'If TypeOf Ctl Is CheckBox Then Ctl.Font = New Font(FontN, fontS, FontSt, FontD, FontB)
                    'If TypeOf Ctl Is RadioButton Then Ctl.Font = New Font(FontN, fontS, FontSt, FontD, FontB)
                    'If TypeOf Ctl Is MenuStrip Then Ctl.Font = New Font(FontN, fontS, FontSt, FontD, FontB)
                    'If TypeOf Ctl Is ToolStrip Then Ctl.Font = New Font(FontN, fontS, FontSt, FontD, FontB)
                    'If TypeOf Ctl Is StatusStrip Then Ctl.Font = New Font(FontN, fontS, FontSt, FontD, FontB)
                    'If TypeOf Ctl Is ListBox Then Ctl.Font = New Font(FontN, fontS, FontSt, FontD, FontB)
                    'If TypeOf Ctl Is Form Then Ctl.Font = New Font(FontN, fontS, FontSt, FontD, FontB)
                    'If TypeOf Ctl Is TabControl Then Ctl.Font = New Font(FontN, fontS, FontSt, FontD, FontB)


                    'If TypeOf Ctl Is Button Then Ctl.autosize = True
                    'If TypeOf Ctl Is Label Then Ctl.autosize = True
                    'If TypeOf Ctl Is TableLayoutPanel Then Ctl.autosize = True
                    'If TypeOf Ctl Is GroupBox Then Ctl.autosize = True
                    'If TypeOf Ctl Is CheckBox Then Ctl.autosize = True
                    'If TypeOf Ctl Is RadioButton Then Ctl.autosize = True
                    'If TypeOf Ctl Is Form Then Ctl.autosize = True

                End If

            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        Next

        'esq 160307 COLOR_LOAD(ControlContainer)
    End Sub

    Private Sub COLOR_LOAD(ByVal ControlContainer As Object)

        'For Each C As Object In ControlContainer.Controls
        '    Try
        '        If Not C.Controls Is Nothing Then
        '            COLOR_LOAD(C)
        '            'esq 160307 *****
        '            If InStr("Form, TableLayoutPanel, GroupBox, Label, CheckBox, RadioButton, TextBox, ComboBox, ListView", C.GetType().Name) > 0 Then
        '                'C.ForeColor = Color.FromName(FontC)
        '            End If
        '            ' TabControl не изменяется
        '            'esq 160307 *********

        '            'If TypeOf C Is Form Then C.ForeColor = Color.FromName(FontC)
        '            ''If TypeOf C Is TabControl Then C.TabPage.ForeColor = Drawing.Color.FromName(FontC)
        '            'If TypeOf C Is TableLayoutPanel Then C.ForeColor = Color.FromName(FontC)
        '            'If TypeOf C Is GroupBox Then C.ForeColor = Color.FromName(FontC)
        '            'If TypeOf C Is Label Then C.ForeColor = Color.FromName(FontC)
        '            'If TypeOf C Is CheckBox Then C.ForeColor = Color.FromName(FontC)
        '            'If TypeOf C Is RadioButton Then C.ForeColor = Color.FromName(FontC)
        '            'If TypeOf C Is TextBox Then C.ForeColor = Color.FromName(FontC)
        '            'If TypeOf C Is ComboBox Then C.ForeColor = Color.FromName(FontC)
        '            'If TypeOf C Is ListView Then C.ForeColor = Color.FromName(FontC)
        '        End If

        '    Catch ex As Exception
        '        MsgBox(ex.Message)
        '    End Try
        'Next
    End Sub

    Public Sub ClearCMB(ByVal ControlContainer As Object)

        For Each Ctl As Object In ControlContainer.Controls
            Try
                If Not Ctl.Controls Is Nothing Then
                    ClearCMB(Ctl)

                    If TypeOf Ctl Is ComboBox Then Ctl.Items.Clear()

                End If

            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        Next
    End Sub

    'Public Sub fLATCMB(ByVal ControlContainer As Object)

    '    For Each Ctl As Object In ControlContainer.Controls
    '        Try
    '            If Not Ctl.Controls Is Nothing Then
    '                fLATCMB(Ctl)

    '                If TypeOf Ctl Is ComboBox Then Ctl.FlatStyle = FlatStyle.Flat
    '                If TypeOf Ctl Is Button Then Ctl.FlatStyle = FlatStyle.Flat
    '            End If

    '        Catch ex As Exception
    '            MsgBox(ex.Message)
    '        End Try
    '    Next
    'End Sub

    Public Sub LOAD_COMBO_SPR()
        Dim oRS As Recordset

        oRS = DB7.OpenSchema(SchemaEnum.adSchemaTables, New Object() {Nothing, Nothing, Nothing, "TABLE"})

        If Not (oRS.EOF) Then
            Do Until oRS.EOF

                If UCase(oRS.Fields.Item("TABLE_TYPE").Value) = "TABLE" Then

                    If Left(oRS.Fields.Item("TABLE_NAME").Value, 3) = "SPR" Then

                        frmDirectory.cmb1.Items.Add(oRS.Fields.Item("TABLE_NAME").Value)

                    End If

                End If
                oRS.MoveNext()
            Loop
        End If

        oRS.Close()
        oRS = Nothing
    End Sub

    Public Sub QR_CODE_GENERATE(ByVal stPic As PictureBox, Optional ByVal sID As String = "")

        '#################################################################
        '###########  QR CODE GENERATOR  #################################
        '#################################################################

        '############################################################################
        fact = New Factors
        EncodingOptions = New Common.EncodingOptions With {.Height = 1280, .Width = 1280}
        Renderer = GetType(Rendering.BitmapRenderer)
        '############################################################################

        Dim objIniFile As New IniFile(sLANGPATH)
        Try

            EncodingOptions = optQR_CODE()

            EncodingOptions = New QrCodeEncodingOptions With {
                .DisableECI = True,
                .CharacterSet = "UTF-8",
               .Width = 180,
            .Height = 180
            }

            Dim writer = New BarcodeWriter With {
                .Format = CType(BarcodeFormat.QR_CODE, BarcodeFormat),
                .Options = EncodingOptions,
                .Renderer = CType(Activator.CreateInstance(Renderer), Rendering.IBarcodeRenderer(Of Bitmap))
            }

            Dim stmpTEXT As String

            Dim sSQL As String

            If sID = "" Then
                sSQL = "Select * FROM kompy"
            Else
                sSQL = "Select * FROM kompy WHERE id=" & sID
            End If

            Dim rs As Recordset
            rs = New Recordset
            rs.Open(sSQL, DB7, CursorTypeEnum.adOpenDynamic,
                     LockTypeEnum.adLockOptimistic)

            With rs
                .MoveFirst()
                Do While Not .EOF

                    Select Case .Fields("tiptehn").Value

                        Case "PC"

                            stmpTEXT = "№: " & .Fields("id").Value & vbNewLine &
                objIniFile.GetString("frmComputers", "lblInNumber", "Инвентарный номер") & ": " & .Fields("INV_NO_SYSTEM").Value & vbNewLine &
                objIniFile.GetString("frmComputers", "lblNetName", "Имя в сети") & ": " & .Fields("NET_NAME").Value & vbNewLine &
                objIniFile.GetString("frmComputers", "gbcpu", "Процессор") & ": " & .Fields("CPU1").Value & vbNewLine &
                objIniFile.GetString("frmComputers", "gbMB", "Материнская плата") & ": " & .Fields("MB_NAME").Value & vbNewLine &
                objIniFile.GetString("frmComputers", "gbRAM", "Память") & ": " & .Fields("RAM_1").Value & "," & .Fields("RAM_2").Value & "," & .Fields("RAM_3").Value & "," & .Fields("RAM_4").Value & vbNewLine &
                objIniFile.GetString("frmComputers", "gbHDD", "Жесткий диск") & ": " & .Fields("HDD_Name_1").Value & "," & .Fields("HDD_Name_2").Value & "," & .Fields("HDD_Name_3").Value & "," & .Fields("HDD_Name_4").Value & vbNewLine &
                objIniFile.GetString("frmComputers", "gbSVGA", "Видео карта") & ": " & .Fields("SVGA_NAME").Value & vbNewLine &
                objIniFile.GetString("frmReports", "lvRemont7", "Место установки") & ": " & .Fields("FILIAL").Value & "\" & .Fields("MESTO").Value & "\" & .Fields("kabn").Value

                        Case "Printer"

                            stmpTEXT = "№: " & .Fields("id").Value & vbNewLine &
               objIniFile.GetString("frmComputers", "lblInNumber", "Инвентарный номер") & ": " & .Fields("INV_NO_PRINTER").Value & vbNewLine &
               objIniFile.GetString("frmComputers", "lblNetName", "Имя в сети") & ": " & .Fields("PRINTER_NAME_1").Value & vbNewLine &
                                     objIniFile.GetString("frmReports", "lvRemont7", "Место установки") & ": " & .Fields("FILIAL").Value & "\" & .Fields("MESTO").Value & "\" & .Fields("kabn").Value

                        Case "MFU"

                            stmpTEXT = "№: " & .Fields("id").Value & vbNewLine &
              objIniFile.GetString("frmComputers", "lblInNumber", "Инвентарный номер") & ": " & .Fields("INV_NO_PRINTER").Value & vbNewLine &
              objIniFile.GetString("frmComputers", "lblNetName", "Имя в сети") & ": " & .Fields("PRINTER_NAME_1").Value & vbNewLine &
                                    objIniFile.GetString("frmReports", "lvRemont7", "Место установки") & ": " & .Fields("FILIAL").Value & "\" & .Fields("MESTO").Value & "\" & .Fields("kabn").Value

                        Case "KOpir"

                            stmpTEXT = "№: " & .Fields("id").Value & vbNewLine &
              objIniFile.GetString("frmComputers", "lblInNumber", "Инвентарный номер") & ": " & .Fields("INV_NO_PRINTER").Value & vbNewLine &
              objIniFile.GetString("frmComputers", "lblNetName", "Имя в сети") & ": " & .Fields("PRINTER_NAME_1").Value & vbNewLine &
                                    objIniFile.GetString("frmReports", "lvRemont7", "Место установки") & ": " & .Fields("FILIAL").Value & "\" & .Fields("MESTO").Value & "\" & .Fields("kabn").Value

                        Case "MONITOR"

                            stmpTEXT = "№: " & .Fields("id").Value & vbNewLine &
             objIniFile.GetString("frmComputers", "lblInNumber", "Инвентарный номер") & ": " & .Fields("INV_NO_MONITOR").Value & vbNewLine &
             objIniFile.GetString("frmComputers", "lblNetName", "Имя в сети") & ": " & .Fields("net_name").Value & vbNewLine &
                                   objIniFile.GetString("frmReports", "lvRemont7", "Место установки") & ": " & .Fields("FILIAL").Value & "\" & .Fields("MESTO").Value & "\" & .Fields("kabn").Value

                        Case "NET"
                            stmpTEXT = "№: " & .Fields("id").Value & vbNewLine &
            objIniFile.GetString("frmComputers", "lblInNumber", "Инвентарный номер") & ": " & .Fields("PRINTER_PROIZV_3").Value & vbNewLine &
            objIniFile.GetString("frmComputers", "lblNetName", "Имя в сети") & ": " & .Fields("PRINTER_SN_1").Value & vbNewLine &
                                  objIniFile.GetString("frmReports", "lvRemont7", "Место установки") & ": " & .Fields("FILIAL").Value & "\" & .Fields("MESTO").Value & "\" & .Fields("kabn").Value

                        Case Else

                            stmpTEXT = "№: " & .Fields("id").Value & vbNewLine &
             objIniFile.GetString("frmComputers", "lblInNumber", "Инвентарный номер") & ": " & .Fields("INV_NO_PRINTER").Value & vbNewLine &
             objIniFile.GetString("frmComputers", "lblNetName", "Имя в сети") & ": " & .Fields("net_name").Value & vbNewLine &
                                   objIniFile.GetString("frmReports", "lvRemont7", "Место установки") & ": " & .Fields("FILIAL").Value & "\" & .Fields("MESTO").Value & "\" & .Fields("kabn").Value

                    End Select


                    '#################################################################
                    '############         SAVE IMAGE        ##########################
                    '#################################################################

                    bmg = writer.Write(stmpTEXT)

                    '  Dim pb As PictureBox = New PictureBox

                    stPic.Image = bmg

                    'stlbl.Text = stmpTEXT

                    Try

                        If stPic.Image IsNot Nothing Then
                            Dim pth As String = Path.Combine(PrPath & "QR_CODE\", .Fields("id").Value & "_" & .Fields("net_name").Value & ".png") '& "_" & .Fields("net_name").Value
                            bmg.Save(pth, ImageFormat.Png)
                        End If

                    Catch ex As Exception

                        If stPic.Image IsNot Nothing Then
                            Dim pth As String = Path.Combine(PrPath & "QR_CODE\", .Fields("id").Value & "_" & "error_name" & ".png") '& "_" & .Fields("net_name").Value
                            bmg.Save(pth, ImageFormat.Png)
                        End If

                    End Try

                    .MoveNext()
                Loop
            End With

            rs.Close()
            rs = Nothing

        Catch exc As Exception
            MessageBox.Show(frmMain, exc.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.[Error])
        End Try

        '#################################################################
    End Sub


End Module

