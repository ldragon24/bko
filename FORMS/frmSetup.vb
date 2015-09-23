

Public Class frmSetup

    Private sFILEBD As String
    Private uCOUNTs As String
    Private uEDT As Boolean


    Public Function changeFont(ByVal FontWindow As FontDialog, ByVal str As Control)
        ' Dim wndFont As FontDialog
        Dim DialogResult As DialogResult


        FontWindow.Font = New Font(FontN, fontS, FontSt, FontD, FontB)

        DialogResult = FontWindow.ShowDialog

        'New System.Windows.Forms.FontDialog

        If DialogResult = DialogResult.OK Then

            Return FontWindow.Font


        Else


        End If
        'textbox1.font=changefont(wndfont)
    End Function

    Private Sub USER_LIST()
        lvPrUsers.Items.Clear()
        Dim intCount As Decimal = 0
        Dim rs As Recordset
        rs = New Recordset
        rs.Open("SELECT * FROM T_User", DB7, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic)

        With rs
            .MoveFirst()
            Do While Not .EOF

                lvPrUsers.Items.Add(.Fields("id").Value) 'col no. 1

                If Not IsDBNull(.Fields("user_id").Value) Then
                    lvPrUsers.Items(CInt(intCount)).SubItems.Add(.Fields("user_id").Value)
                Else
                    lvPrUsers.Items(CInt(intCount)).SubItems.Add("")
                End If

                If Not IsDBNull(.Fields("Name").Value) Then
                    lvPrUsers.Items(CInt(intCount)).SubItems.Add(.Fields("Name").Value)
                Else
                    lvPrUsers.Items(CInt(intCount)).SubItems.Add("")
                End If

                If Not IsDBNull(.Fields("Level").Value) Then
                    lvPrUsers.Items(CInt(intCount)).SubItems.Add(.Fields("Level").Value)
                Else
                    lvPrUsers.Items(CInt(intCount)).SubItems.Add("")
                End If

                intCount = intCount + 1
                .MoveNext()
                'DoEvents
            Loop
        End With
        ResList(Me.lvPrUsers)

        rs.Close()
        rs = Nothing
    End Sub

    Private Sub RESIZER()

        lvPrUsers.Width = SplitContainer1.Panel1.Width - 10
        lvPrUsers.Height = SplitContainer1.Panel1.Height - 10
        gbUserLevel.Width = SplitContainer1.Panel2.Width - 20
        gbUserLevel.Height = SplitContainer1.Panel2.Height - 10
    End Sub

    Private Sub btnEverest_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnEverest.Click
        Dim DirectoryBrowser As New FolderBrowserDialog

        ' Then use the following code to create the Dialog window
        ' Change the .SelectedPath property to the default location
        With DirectoryBrowser
            ' Desktop is the root folder in the dialog.

            .RootFolder = Environment.SpecialFolder.Desktop


            If Len(txtEverestDir.Text) = 0 Then
                ' Select the C:\Windows directory on entry.
                .SelectedPath = PrPath
            Else
                .SelectedPath = txtEverestDir.Text
            End If

            ' Prompt the user with a custom message.
            .Description = "Select the source directory"

            If .ShowDialog = DialogResult.OK Then
                ' Display the selected folder if the user clicked on the OK button.
                txtEverestDir.Text = .SelectedPath
            End If

        End With

        Dim objIniFile As New IniFile(PrPath & "base.ini")
        objIniFile.WriteString("general", "aida", txtEverestDir.Text)
    End Sub

    Private Sub frmSetup_Activated(ByVal sender As Object, ByVal e As EventArgs) Handles Me.Activated

        frmMain.SaveInfTehButton.Enabled = False
        frmMain.ToolStripDropDownButton1.Enabled = False
    End Sub

    Private Sub frmSetup_Load(ByVal sender As Object, ByVal e As EventArgs) Handles Me.Load

        SendFonts(Me)

        Call frmSetup_Lang()

        Me.BeginInvoke(New MethodInvoker(AddressOf USER_LIST))


        Dim LNGIniFile As New IniFile(sLANGPATH)

        cmbDefaultModul.Items.Clear()
        cmbDefaultModul.Items.Add(LNGIniFile.GetString("frmSetup", "MSG3", "Учёт оргтехники"))
        cmbDefaultModul.Items.Add(LNGIniFile.GetString("frmSetup", "MSG4", "Учёт заявок"))
        cmbDefaultModul.Items.Add(LNGIniFile.GetString("frmSetup", "MSG5", "Учёт П.О."))
        cmbDefaultModul.Items.Add(LNGIniFile.GetString("frmSetup", "MSG6", "Учёт картриджей"))

        cmbSortTree.Items.Clear()
        cmbSortTree.Items.Add(LNGIniFile.GetString("frmSetup", "MSG1", "По имени техники"))
        cmbSortTree.Items.Add(LNGIniFile.GetString("frmSetup", "MSG2", "По типу техники"))

        Dim uname As String
        Dim objIniFile As New IniFile(PrPath & "base.ini")

        cmbOffice.Text = objIniFile.GetString("General", "Office", "OpenOffice.org")
        uname = objIniFile.GetString("General", "NETNAME", "0")

        Select Case uname

            Case "1"

                RadioButton1.Checked = True

            Case "2"

                RadioButton2.Checked = True

            Case "0"

                RadioButton3.Checked = True

        End Select

        uname = objIniFile.GetString("General", "ICONs", "24*24")

        Select Case uname

            Case "32*32"

                ComboBox1.Text = uname
                sICONS = uname
            Case Else

                ComboBox1.Text = "24*24"
                sICONS = "24*24"
        End Select


        uname = objIniFile.GetString("MYBLANK", "VSU", "0")

        Select Case uname

            Case "1"

                chkVSUst.Checked = True

            Case "0"

                chkVSUst.Checked = False

        End Select

        uname = objIniFile.GetString("GENERAL", "LOG", "0")

        Select Case uname

            Case "1"

                chk_no_log.Checked = True

            Case "0"

                chk_no_log.Checked = False

        End Select


        'chk_no_log

        uname = objIniFile.GetString("MYBLANK", "POu", "0")

        Select Case uname

            Case "1"

                chkPOu.Checked = True

            Case "0"

                chkPOu.Checked = False

        End Select

        uname = objIniFile.GetString("MYBLANK", "REMONT", "0")

        Select Case uname

            Case "1"

                chkREMONT.Checked = True

            Case "0"

                chkREMONT.Checked = False

        End Select


        uname = objIniFile.GetString("MYBLANK", "DVIG", "0")

        Select Case uname

            Case "1"

                chkDVIG.Checked = True

            Case "0"

                chkDVIG.Checked = False

        End Select


        'chkArhiv2exit

        uname = objIniFile.GetString("General", "ARHIVATOR", "0")

        Select Case uname

            Case "0"

                chkArhiv2exit.Checked = False

            Case "1"

                chkArhiv2exit.Checked = True


        End Select


        uname = objIniFile.GetString("General", "RAZDEL", "0")

        Select Case uname

            Case "0"

                RadioButton6.Checked = True

            Case "1"

                RadioButton5.Checked = True

            Case "2"

                RadioButton4.Checked = True

            Case "3"

                RadioButton7.Checked = True

            Case "4"

                RadioButton8.Checked = True

            Case "5"

                RadioButton9.Checked = True


        End Select


        uname = objIniFile.GetString("General", "SYS", "0")

        Select Case uname

            Case "1"

                chkMenuServices.Checked = True

            Case "0"

                chkMenuServices.Checked = False

        End Select

        uname = objIniFile.GetString("General", "Sheduler", "unChecked")

        Select Case uname

            Case "Checked"

                chkSheduler.Checked = True

            Case "unChecked"

                chkSheduler.Checked = False

        End Select


        uname = objIniFile.GetString("IdentifierMAC", "Check", "0")

        Select Case uname

            Case "1"

                chkSNPro.Checked = True

            Case "0"

                chkSNPro.Checked = False

        End Select


        Dim sText As String

        sText = objIniFile.GetString("general", "MOD", 0)

        Select Case sText

            Case 0

                cmbDefaultModul.Text = LNGIniFile.GetString("frmSetup", "MSG3", "Учёт оргтехники") '"Учёт оргтехники"

            Case 1

                cmbDefaultModul.Text = LNGIniFile.GetString("frmSetup", "MSG4", "Учёт заявок") '"Учёт заявок"

            Case 2

                cmbDefaultModul.Text = LNGIniFile.GetString("frmSetup", "MSG5", "Учёт П.О.") '"Учёт П.О."

            Case 3

                cmbDefaultModul.Text = LNGIniFile.GetString("frmSetup", "MSG6", "Учёт картриджей") '"Учёт картриджей"
        End Select


        'objIniFile.WriteString("General", "FullScreen", "0")

        uname = objIniFile.GetString("General", "FullScreen", "0")

        Select Case uname

            Case "1"

                chkFullScreen.Checked = True

            Case "0"

                chkFullScreen.Checked = False

        End Select


        uname = objIniFile.GetString("General", "chkFonts", "0")

        Select Case uname

            Case "1"

                chkFonts.Checked = True

            Case "0"

                chkFonts.Checked = False

        End Select


        uname = objIniFile.GetString("General", "TREE_UPDATE", "0")

        Select Case uname

            Case "1"

                RadioButton10.Checked = False
                RadioButton11.Checked = True

            Case "0"

                RadioButton11.Checked = False
                RadioButton10.Checked = True

        End Select

        uname = objIniFile.GetString("TREE", "REM", "0")

        Select Case uname

            Case "1"

                chkRemVisible.Checked = True

            Case "0"

                chkRemVisible.Checked = False

        End Select

        uname = objIniFile.GetString("TREE", "NB", "1")

        Select Case uname

            Case "1"

                chkNB.Checked = True
                NBVisible = True
            Case "0"

                chkNB.Checked = False
                NBVisible = False
        End Select

        uname = objIniFile.GetString("TREE", "SP", "1")

        Select Case uname

            Case "1"

                chkSP.Checked = True
                SPVisible = True
            Case "0"

                chkSP.Checked = False
                SPVisible = False
        End Select

        txtSMTP.Text = objIniFile.GetString("SMTP", "Server", "")

        txtPort.Text = objIniFile.GetString("SMTP", "Port", "")
        txtMUser.Text = objIniFile.GetString("SMTP", "User", "")
        '  txtPassword.Text = DecryptBytes(objIniFile.GetString("SMTP", "Password", ""))


        Dim decr As String = DecryptBytes(objIniFile.GetString("SMTP", "Password", ""))
        txtMPassword.Text = decr

        chkTLS.Checked = objIniFile.GetString("SMTP", "TLS", "false")

        sText = objIniFile.GetString("general", "Tree_S", 0)

        Select Case sText

            Case 0

                cmbSortTree.Text = LNGIniFile.GetString("frmSetup", "MSG1", "По имени техники") '"По имени техники"

            Case 1

                cmbSortTree.Text = LNGIniFile.GetString("frmSetup", "MSG2", "По типу техники") '"По типу техники"

        End Select

        
        txtSUBD.Text = objIniFile.GetString("General", "BasePath", BasePath)
        txtEverestDir.Text = objIniFile.GetString("General", "aida", PrPath)


        ComboBox2.Text = objIniFile.GetString("General", "TechINF", "AIDA64(Everest)")
        sTechINF = ComboBox2.Text


        Dim rs As Recordset
        rs = New Recordset

        rs.Open("Select count(*) as t_n from CONFIGURE", DB7, CursorTypeEnum.adOpenDynamic,
                LockTypeEnum.adLockOptimistic)

        Dim us As String
        With rs
            us = .Fields("t_n").Value
        End With
        rs.Close()
        rs = Nothing

        If us > 0 Then
            rs = New Recordset
            rs.Open("Select * from CONFIGURE", DB7, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic)
            With rs

                If Not IsDBNull(.Fields("SISADM").Value) Then txtSA.Text = .Fields("SISADM").Value
                If Not IsDBNull(.Fields("ORG").Value) Then txtORG.Text = .Fields("ORG").Value
                If Not IsDBNull(.Fields("Name_Prog").Value) Then txtPRG.Text = .Fields("Name_Prog").Value
                If Not IsDBNull(.Fields("nr").Value) Then txtMail.Text = .Fields("nr").Value
                If Not IsDBNull(.Fields("nomer_compa").Value) Then txtBigBoss.Text = .Fields("nomer_compa").Value

            End With
            rs.Close()
            rs = Nothing

        End If


        'Цвет текста в дереве
        btnServiceColor.ForeColor = Color.FromName(ServiceColor)
        chkRemVisible.ForeColor = btnServiceColor.ForeColor

        btnSpisanColor.ForeColor = Color.FromName(SpisanColor)
        chkSP.ForeColor = btnSpisanColor.ForeColor


        btnNbColor.ForeColor = Color.FromName(NbColor)
        chkNB.ForeColor = btnNbColor.ForeColor

        'Call FONT_LOAD(Me)
        'lvFindDB
    End Sub

    Private Sub chkSNPro_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles chkSNPro.CheckedChanged

        Dim objIniFile As New IniFile(PrPath & "base.ini")

        Select Case chkSNPro.Checked

            Case False

                objIniFile.WriteString("IdentifierMAC", "Check", "0")
                IdentifierMAC = "0"
            Case True

                objIniFile.WriteString("IdentifierMAC", "Check", "1")
                IdentifierMAC = "1"
        End Select
    End Sub

    Private Sub chkSheduler_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) _
        Handles chkSheduler.CheckedChanged

        Dim objIniFile As New IniFile(PrPath & "base.ini")

        Select Case chkSheduler.Checked

            Case False

                objIniFile.WriteString("General", "Sheduler", "unChecked")

            Case True

                objIniFile.WriteString("General", "Sheduler", "Checked")

        End Select

        Call SHED_CHECK()
    End Sub

    Private Sub chkMenuServices_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) _
        Handles chkMenuServices.CheckedChanged

        Dim objIniFile As New IniFile(PrPath & "base.ini")

        Select Case chkMenuServices.Checked

            Case False

                objIniFile.WriteString("General", "SYS", "0")
                frmMain.CleerDBToolStripMenuItem.Visible = False
                frmMain.ЗапросыToolStripMenuItem.Visible = False

            Case True

                objIniFile.WriteString("General", "SYS", "1")

                frmMain.CleerDBToolStripMenuItem.Visible = True
                frmMain.ЗапросыToolStripMenuItem.Visible = True


        End Select
    End Sub

    Private Sub RadioButton1_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) _
        Handles RadioButton1.CheckedChanged

        Dim objIniFile As New IniFile(PrPath & "base.ini")
        objIniFile.WriteString("General", "NETNAME", "1")
    End Sub

    Private Sub RadioButton2_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) _
        Handles RadioButton2.CheckedChanged
        Dim objIniFile As New IniFile(PrPath & "base.ini")
        objIniFile.WriteString("General", "NETNAME", "2")
    End Sub

    Private Sub RadioButton3_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) _
        Handles RadioButton3.CheckedChanged
        Dim objIniFile As New IniFile(PrPath & "base.ini")
        objIniFile.WriteString("General", "NETNAME", "0")
    End Sub

    Private Sub cmbOffice_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) _
        Handles cmbOffice.SelectedIndexChanged

        Dim objIniFile As New IniFile(PrPath & "base.ini")
        objIniFile.WriteString("General", "Office", cmbOffice.Text)

        sOfficePACK = cmbOffice.Text
    End Sub

    Private Sub cmbSortTree_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) _
        Handles cmbSortTree.SelectedIndexChanged
        Dim objIniFile As New IniFile(PrPath & "base.ini")
        Dim LNGIniFile As New IniFile(sLANGPATH)

        Dim sText As String

        If cmbSortTree.Text = LNGIniFile.GetString("frmSetup", "MSG1", "По имени техники") Then sText = 0
        If cmbSortTree.Text = LNGIniFile.GetString("frmSetup", "MSG2", "По типу техники") Then sText = 1

        objIniFile.WriteString("general", "Tree_S", sText)
    End Sub

    Private Sub frmSetup_Resize(ByVal sender As Object, ByVal e As EventArgs) Handles Me.Resize
        'lvFindDB

        SStab1.Width = Me.Width
        SStab1.Height = Me.Height
        ' lvFindDB.Width = SStab1.Width - 5
        gbUsers.Width = SStab1.Width - 5
    End Sub

    'Private Sub lvFindDB_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles lvFindDB.Click
    '    sFILEBD = lvFindDB.Items.Item(lvFindDB.FocusedItem.Index).SubItems(1).Text
    'End Sub

    Private Sub Button1_Click(ByVal sender As Object, ByVal e As EventArgs)

        'lvFindDB

        If Len(sFILEBD) = 0 Then Exit Sub

        Me.Cursor = Cursors.Hand
        UnLoadDatabase()
        Base_Name = sFILEBD

        Dim objIniFile As New IniFile(PrPath & "base.ini")
        objIniFile.WriteString("general", "file", sFILEBD)

        LoadDatabase()
        RefFilTree(frmComputers.lstGroups)
        frmComputers.STAT_INF()

        Call LoadSPR()
        Call SHED_CHECK()
        Call REM_CHECK()

        Dim rsG As Recordset
        rsG = New Recordset

        rsG.Open("SELECT * FROM CONFIGURE", DB7, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic)

        With rsG
            If Not IsDBNull(.Fields("Name_Prog").Value) Then ProGramName = .Fields("Name_Prog").Value
        End With
        rsG.Close()
        rsG = Nothing

        Dim LNGIniFile As New IniFile(sLANGPATH)
        If Len(ProGramName) = 0 Or ProGramName = Nothing Then _
            ProGramName = LNGIniFile.GetString("frmSetup", "MSG7", "БКО") '"БКО"

        frmMain.Text = ProGramName & " " & My.Application.Info.Version.Major & "." & My.Application.Info.Version.Minor &
                       "." & My.Application.Info.Version.Build & "." & My.Application.Info.Version.Revision


        Me.Cursor = Cursors.Default
        Me.Close()
    End Sub

    Private Sub lvPrUsers_Click(ByVal sender As Object, ByVal e As EventArgs) Handles lvPrUsers.Click

        Call USER_CLICK_LOAD()
    End Sub

    Private Sub lvPrUsers_DoubleClick(ByVal sender As Object, ByVal e As EventArgs) Handles lvPrUsers.DoubleClick

        Call USER_CLICK_LOAD()
    End Sub

    Private Sub USER_CLICK_LOAD()
        On Error Resume Next
        Call sUSER_CLEAR()
        If lvPrUsers.Items.Count = 0 Then Exit Sub

        Dim z As Integer

        For z = 0 To lvPrUsers.SelectedItems.Count - 1
            uCOUNTs = (lvPrUsers.SelectedItems(z).Text)
        Next

        Dim sSQL As String
        Dim rs1 As Recordset
        rs1 = New Recordset

        uEDT = True

        sSQL = "SELECT * FROM T_User WHERE id=" & uCOUNTs
        rs1.Open(sSQL, DB7, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic)


        With rs1

            txtUserName.Text = .Fields("Name").Value
            cmbLevel.Text = .Fields("level").Value
            txtLogin.Text = .Fields("user_id").Value

            If Not IsDBNull(.Fields("password")) Then txtPassword.Text = .Fields("password").Value

            If Not IsDBNull(.Fields("password")) Then txtRetipePassword.Text = .Fields("password").Value

            ' txtRetipePassword.Text = .Fields("password").Value

            If .Fields("level").Value = "User" Then
                gbUserLevel.Visible = True
                SplitContainer1.Panel2Collapsed = False

                If .Fields("SETUP").Value = 1 Or .Fields("SETUP").Value = True Then
                    chkSetup.Checked = 1
                Else
                    chkSetup.Checked = 0
                End If
                If .Fields("PCADD").Value = 1 Or .Fields("PCADD").Value = True Then
                    chkTehAdd.Checked = 1
                Else
                    chkTehAdd.Checked = 0
                End If
                If .Fields("PCDEL").Value = 1 Or .Fields("PCDEL").Value = True Then
                    chkTehDel.Checked = 1
                Else
                    chkTehDel.Checked = 0
                End If
                If .Fields("CAPADD").Value = 1 Or .Fields("CAPADD").Value = True Then
                    chkNotesAdd.Checked = 1
                Else
                    chkNotesAdd.Checked = 0
                End If

                If .Fields("CAPDEL").Value = 1 Or .Fields("CAPDEL").Value = True Then
                    chkNotesDel.Checked = 1
                Else
                    chkNotesDel.Checked = 0
                End If
                If .Fields("REPADD").Value = 1 Or .Fields("REPADD").Value = True Then
                    chkRepAdd.Checked = 1
                Else
                    chkRepAdd.Checked = 0
                End If

                If .Fields("REPDEL").Value = 1 Or .Fields("REPDEL").Value = True Then
                    chkRepDel.Checked = 1
                Else
                    chkRepDel.Checked = 0
                End If
                If .Fields("REPed").Value = 1 Or .Fields("REPed").Value = True Then
                    chkRepEd.Checked = 1
                Else
                    chkRepEd.Checked = 0
                End If

                If .Fields("POADD").Value = 1 Or .Fields("POADD").Value = True Then
                    chkPOAdd.Checked = 1
                Else
                    chkPOAdd.Checked = 0
                End If
                If .Fields("PODEL").Value = 1 Or .Fields("PODEL").Value = True Then
                    chkPODel.Checked = 1
                Else
                    chkPODel.Checked = 0
                End If
                If .Fields("CARTR").Value = 1 Or .Fields("CARTR").Value = True Then
                    chkCart.Checked = 1
                Else
                    chkCart.Checked = 0
                End If
                If .Fields("PO").Value = 1 Or .Fields("PO").Value = True Then
                    chkPO.Checked = 1
                Else
                    chkPO.Checked = 0
                End If
                If .Fields("SCLAD").Value = 1 Or .Fields("SCLAD").Value = True Then
                    chkWarehause.Checked = 1
                Else
                    chkWarehause.Checked = 0
                End If

            Else
                gbUserLevel.Visible = False
                SplitContainer1.Panel2Collapsed = True
            End If


        End With

        rs1.Close()
        rs1 = Nothing
    End Sub

    Private Sub SplitContainer1_Resize(ByVal sender As Object, ByVal e As EventArgs) Handles SplitContainer1.Resize
        Call RESIZER()
    End Sub

    Private Sub SplitContainer1_SplitterMoved(ByVal sender As Object, ByVal e As SplitterEventArgs) _
        Handles SplitContainer1.SplitterMoved
        Call RESIZER()
    End Sub

    Private Sub SplitContainer1_SplitterMoving(ByVal sender As Object, ByVal e As SplitterCancelEventArgs) _
        Handles SplitContainer1.SplitterMoving
        Call RESIZER()
    End Sub

    Private Sub btnCancel_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnCancel.Click
        Call sUSER_CLEAR()
    End Sub

    Private Sub sUSER_CLEAR()
        uCOUNTs = 0
        uEDT = False
        txtUserName.Text = ""
        cmbLevel.Text = ""
        txtLogin.Text = ""
        txtPassword.Text = ""
        txtRetipePassword.Text = ""

        chkSetup.Checked = 0
        chkTehAdd.Checked = 0
        chkTehDel.Checked = 0
        chkNotesAdd.Checked = 0
        chkNotesDel.Checked = 0
        chkRepAdd.Checked = 0
        chkRepDel.Checked = 0
        chkRepEd.Checked = 0
        chkPOAdd.Checked = 0
        chkPODel.Checked = 0
        chkCart.Checked = 0
        chkPO.Checked = 0
        chkWarehause.Checked = 0
        txtPassword.PasswordChar = "*"
        txtRetipePassword.PasswordChar = "*"
    End Sub

    Private Sub cmbLevel_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) _
        Handles cmbLevel.SelectedIndexChanged

        If cmbLevel.Text = "User" Then
            gbUserLevel.Visible = True
            SplitContainer1.Panel2Collapsed = False
        Else
            gbUserLevel.Visible = False
            SplitContainer1.Panel2Collapsed = True
        End If
    End Sub

    Private Sub btnEnc_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnEnc.Click
        txtPassword.PasswordChar = ""
        txtRetipePassword.PasswordChar = ""


        strPassword = Trim(txtPassword.Text)
        Call EncryptDecrypt(strPassword)
        txtPassword.Text = Temp$

        strPassword = Trim(txtRetipePassword.Text)
        Call EncryptDecrypt(strPassword)
        txtRetipePassword.Text = Temp$
    End Sub

    Private Sub btnAdd_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnAdd.Click

        Dim LNGIniFile As New IniFile(sLANGPATH)
        'If Len(ProGramName) = 0 Or ProGramName = Nothing Then ProGramName = LNGIniFile.GetString("frmSetup", "MSG7", "БКО") '"БКО"


        If txtRetipePassword.Text <> txtPassword.Text Then
            MsgBox(LNGIniFile.GetString("frmSetup", "MSG8", "Не соответсвие паролей"), MsgBoxStyle.Exclamation,
                   ProGramName)
            txtPassword.Focus()
            Exit Sub
        End If


        Dim Us1 As String

        If uEDT = True Then

            Dim USERCOMP As Recordset
            USERCOMP = New Recordset
            USERCOMP.Open("SELECT * FROM T_User WHERE id =" & uCOUNTs, DB7, CursorTypeEnum.adOpenDynamic,
                          LockTypeEnum.adLockOptimistic)

            With USERCOMP
                If Not IsDBNull(.Fields("PASSWORD")) Then Us1 = .Fields("PASSWORD").Value
            End With
            USERCOMP.Close()
            USERCOMP = Nothing

        End If


        Dim rs As Recordset
        rs = New Recordset
        Dim sSQL As String

        If uEDT = True Then

            sSQL = "SELECT * FROM T_User WHERE id =" & uCOUNTs
        Else
            sSQL = "SELECT * FROM T_User"
        End If

        rs.Open(sSQL, DB7, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic)

        With rs
            If uEDT = True Then

            Else
                .AddNew()
            End If

            .Fields("User_ID").Value = txtLogin.Text

            If uEDT = True Then
                If Us1 = txtRetipePassword.Text Or Us1 = Nothing Then

                Else
                    strPassword = txtRetipePassword.Text
                    EncryptDecrypt(strPassword)
                    .Fields("PASSWORD").Value = Temp$
                End If

            Else
                strPassword = txtRetipePassword.Text
                EncryptDecrypt(strPassword)
                .Fields("PASSWORD").Value = Temp$
            End If

            .Fields("Name").Value = txtUserName.Text
            .Fields("Level").Value = cmbLevel.Text

            .Fields("SETUP").Value = chkSetup.Checked
            .Fields("PCADD").Value = chkTehAdd.Checked
            .Fields("PCDEL").Value = chkTehDel.Checked
            .Fields("CAPADD").Value = chkNotesAdd.Checked
            .Fields("CAPDEL").Value = chkNotesDel.Checked

            .Fields("REPADD").Value = chkRepAdd.Checked
            .Fields("REPDEL").Value = chkRepDel.Checked
            .Fields("RepEd").Value = chkRepEd.Checked

            .Fields("POADD").Value = chkPOAdd.Checked
            .Fields("PODEL").Value = chkPODel.Checked
            .Fields("CARTR").Value = chkCart.Checked
            .Fields("PO").Value = chkPO.Checked
            .Fields("SCLAD").Value = chkWarehause.Checked

            .Update()
        End With

        rs.Close()
        rs = Nothing

        Call sUSER_CLEAR()
        Call USER_LIST()
    End Sub

    Private Sub btnDel_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnDel.Click

        If uCOUNTs = 0 Then Exit Sub

        Dim rs1 As Recordset
        rs1 = New Recordset
        rs1.Open("Delete FROM T_User WHERE id=" & uCOUNTs, DB7, CursorTypeEnum.adOpenDynamic,
                 LockTypeEnum.adLockOptimistic)
        rs1 = Nothing
        Call USER_LIST()
        Call sUSER_CLEAR()
    End Sub

    Private Sub cmbDefaultModul_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) _
        Handles cmbDefaultModul.SelectedIndexChanged
        Dim objIniFile As New IniFile(PrPath & "base.ini")
        Dim LNGIniFile As New IniFile(sLANGPATH)

        Dim sText As String

        If cmbDefaultModul.Text = LNGIniFile.GetString("frmSetup", "MSG3", "Учёт оргтехники") Then sText = 0
        If cmbDefaultModul.Text = LNGIniFile.GetString("frmSetup", "MSG4", "Учёт заявок") Then sText = 1
        If cmbDefaultModul.Text = LNGIniFile.GetString("frmSetup", "MSG5", "Учёт П.О.") Then sText = 2
        If cmbDefaultModul.Text = LNGIniFile.GetString("frmSetup", "MSG6", "Учёт картриджей") Then sText = 3

        objIniFile.WriteString("general", "MOD", sText)
    End Sub

    Private Sub btnSave_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnSave.Click

        On Error GoTo err_

        Dim rs As Recordset
        rs = New Recordset

        rs.Open("Select count(*) as t_n from CONFIGURE", DB7, CursorTypeEnum.adOpenDynamic,
                LockTypeEnum.adLockOptimistic)

        Dim us As String
        With rs
            us = .Fields("t_n").Value
        End With
        rs.Close()
        rs = Nothing

        Dim sSQL As String

        Dim strSimbol1, strSimbol2 As String
        strSimbol1 = "'" : strSimbol2 = "."
        txtSA.Text = Replace(txtSA.Text, strSimbol1, "")
        txtORG.Text = Replace(txtORG.Text, strSimbol1, "")
        txtPRG.Text = Replace(txtPRG.Text, strSimbol1, "")
        txtMail.Text = Replace(txtMail.Text, strSimbol1, "")
        txtBigBoss.Text = Replace(txtBigBoss.Text, strSimbol1, "")

        Select Case us

            Case 0
                sSQL = "INSERT INTO CONFIGURE (SISADM,ORG,Name_Prog,nr,nomer_compa) VALUES ('" & txtSA.Text & "','" & txtORG.Text & "','" & txtPRG.Text & "','" & txtMail.Text & "','" & txtBigBoss.Text & "')"
            Case Else
                sSQL = "UPDATE CONFIGURE SET " &
                   "SISADM='" & txtSA.Text & "'," &
                   "ORG='" & txtORG.Text & "'," &
                   "Name_Prog='" & txtPRG.Text & "'," &
                   "nr='" & txtMail.Text & "'," &
                   "nomer_compa='" & txtBigBoss.Text & "'"

        End Select

        DB7.Execute(sSQL)

        'rs = New Recordset
        'rs.Open("Select * from CONFIGURE", DB7, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic)
        'With rs
        '    If us > 0 Then

        '    Else
        '        .AddNew()
        '    End If

        '    .Fields("SISADM").Value = txtSA.Text
        '    .Fields("ORG").Value = txtORG.Text
        '    .Fields("Name_Prog").Value = txtPRG.Text
        '    .Fields("nr").Value = txtMail.Text
        '    .Fields("nomer_compa").Value = txtBigBoss.Text
        '    '.Fields("asc").Value = 0

        '    .Update()
        'End With
        'rs.Close()
        'rs = Nothing


        Exit Sub
err_:
        MsgBox(Err.Description)
    End Sub

    Private Sub Button2_Click(ByVal sender As Object, ByVal e As EventArgs) Handles Button2.Click


        Dim dlgFont As FontDialog
        dlgFont = New FontDialog


        Label9.Font = changeFont(dlgFont, Label9)


        If FontN <> dlgFont.Font.Name Or fontS <> dlgFont.Font.Size Then

            FontN = dlgFont.Font.Name
            fontS = dlgFont.Font.Size
            FontB = dlgFont.Font.Bold
            FontSt = dlgFont.Font.Style
            FontD = dlgFont.Font.Unit

            Dim objIniFile As New IniFile(PrPath & "base.ini")

            objIniFile.WriteString("general", "Font", FontN)
            objIniFile.WriteString("general", "FontSize", fontS)
            objIniFile.WriteString("general", "FontBold", FontB)
            objIniFile.WriteString("general", "FontStyle", FontSt)
            objIniFile.WriteString("general", "FontUnit", FontD)

            Call SendFonts(frmMain)

        End If

        'End If

        'Call SendFonts(Me)
    End Sub

    Private Sub RadioButton6_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) _
        Handles RadioButton6.CheckedChanged

        If RadioButton6.Checked = True Then RAZDEL = 0


        Dim objIniFile As New IniFile(PrPath & "base.ini")
        objIniFile.WriteString("general", "RAZDEL", RAZDEL)

        Dim LNGIniFile As New IniFile(sLANGPATH)
        frmComputers.ОтделитьПринтерыИМониторыToolStripMenuItem.Text = LNGIniFile.GetString("frmSetup", "MSG9",
                                                                                            "Отделить периферию")
        frmComputers.ВернутьПерефериюToolStripMenuItem.Text = LNGIniFile.GetString("frmSetup", "MSG9.1",
                                                                                   "Присоеденить периферию")
    End Sub

    Private Sub RadioButton5_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) _
        Handles RadioButton5.CheckedChanged
        If RadioButton5.Checked = True Then RAZDEL = 1


        Dim objIniFile As New IniFile(PrPath & "base.ini")
        objIniFile.WriteString("general", "RAZDEL", RAZDEL)

        Dim LNGIniFile As New IniFile(sLANGPATH)

        frmComputers.ОтделитьПринтерыИМониторыToolStripMenuItem.Text = LNGIniFile.GetString("frmSetup", "MSG10",
                                                                                            "Отделить Мониторы") _
        '"Отделить Мониторы"
        frmComputers.ВернутьПерефериюToolStripMenuItem.Text = LNGIniFile.GetString("frmSetup", "MSG10.1",
                                                                                   "Присоеденить Мониторы")
    End Sub

    Private Sub RadioButton4_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) _
        Handles RadioButton4.CheckedChanged

        If RadioButton4.Checked = True Then RAZDEL = 2

        Dim objIniFile As New IniFile(PrPath & "base.ini")
        objIniFile.WriteString("general", "RAZDEL", RAZDEL)


        Dim LNGIniFile As New IniFile(sLANGPATH)

        frmComputers.ОтделитьПринтерыИМониторыToolStripMenuItem.Text = LNGIniFile.GetString("frmSetup", "MSG11",
                                                                                            "Отделить принтеры")
        frmComputers.ВернутьПерефериюToolStripMenuItem.Text = LNGIniFile.GetString("frmSetup", "MSG11.1",
                                                                                   "Присоеденить принтеры")
    End Sub

    Private Sub RadioButton7_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) _
        Handles RadioButton7.CheckedChanged
        If RadioButton7.Checked = True Then RAZDEL = 3

        Dim objIniFile As New IniFile(PrPath & "base.ini")
        objIniFile.WriteString("general", "RAZDEL", RAZDEL)

        Dim LNGIniFile As New IniFile(sLANGPATH)
        frmComputers.ОтделитьПринтерыИМониторыToolStripMenuItem.Text = LNGIniFile.GetString("frmSetup", "MSG12",
                                                                                            "Отделить ИБП")
        frmComputers.ВернутьПерефериюToolStripMenuItem.Text = LNGIniFile.GetString("frmSetup", "MSG12.1",
                                                                                   "Присоеденить ИБП")
    End Sub

    Private Sub RadioButton8_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) _
        Handles RadioButton8.CheckedChanged
        If RadioButton8.Checked = True Then RAZDEL = 4

        Dim objIniFile As New IniFile(PrPath & "base.ini")
        objIniFile.WriteString("general", "RAZDEL", RAZDEL)


        Dim LNGIniFile As New IniFile(sLANGPATH)

        frmComputers.ОтделитьПринтерыИМониторыToolStripMenuItem.Text = LNGIniFile.GetString("frmSetup", "MSG13",
                                                                                            "Отделить Клавиатуры и мыши")
        frmComputers.ВернутьПерефериюToolStripMenuItem.Text = LNGIniFile.GetString("frmSetup", "MSG13.1",
                                                                                   "Присоеденить Клавиатуры и мыши")
    End Sub

    Private Sub RadioButton9_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) _
        Handles RadioButton9.CheckedChanged
        If RadioButton9.Checked = True Then RAZDEL = 5

        Dim objIniFile As New IniFile(PrPath & "base.ini")
        objIniFile.WriteString("general", "RAZDEL", RAZDEL)


        Dim LNGIniFile As New IniFile(sLANGPATH)

        frmComputers.ОтделитьПринтерыИМониторыToolStripMenuItem.Text = LNGIniFile.GetString("frmSetup", "MSG14",
                                                                                            "Отделить сетевые фильтры")
        frmComputers.ВернутьПерефериюToolStripMenuItem.Text = LNGIniFile.GetString("frmSetup", "MSG14.1",
                                                                                   "Присоеденить сетевые фильтры")
    End Sub

    Private Sub chkArhiv2exit_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) _
        Handles chkArhiv2exit.CheckedChanged
        Dim objIniFile As New IniFile(PrPath & "base.ini")

        Select Case chkArhiv2exit.Checked

            Case False

                objIniFile.WriteString("General", "ARHIVATOR", "0")


            Case True

                objIniFile.WriteString("General", "ARHIVATOR", "1")


        End Select
    End Sub

    Private Sub chkVSUst_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles chkVSUst.CheckedChanged
        Dim objIniFile As New IniFile(PrPath & "base.ini")

        Select Case chkVSUst.Checked

            Case False

                objIniFile.WriteString("MYBLANK", "VSU", "0")

            Case True

                objIniFile.WriteString("MYBLANK", "VSU", "1")
        End Select
    End Sub

    Private Sub chkPOu_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles chkPOu.CheckedChanged

        Dim objIniFile As New IniFile(PrPath & "base.ini")

        Select Case chkPOu.Checked

            Case False

                objIniFile.WriteString("MYBLANK", "POu", "0")

            Case True

                objIniFile.WriteString("MYBLANK", "POu", "1")
        End Select
    End Sub

    Private Sub chkREMONT_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles chkREMONT.CheckedChanged

        Dim objIniFile As New IniFile(PrPath & "base.ini")

        Select Case chkREMONT.Checked

            Case False

                objIniFile.WriteString("MYBLANK", "REMONT", "0")

            Case True

                objIniFile.WriteString("MYBLANK", "REMONT", "1")
        End Select
    End Sub

    Private Sub chkDVIG_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles chkDVIG.CheckedChanged

        Dim objIniFile As New IniFile(PrPath & "base.ini")

        Select Case chkDVIG.Checked

            Case False

                objIniFile.WriteString("MYBLANK", "DVIG", "0")

            Case True

                objIniFile.WriteString("MYBLANK", "DVIG", "1")
        End Select
    End Sub

    Private Sub chk_no_log_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) _
        Handles chk_no_log.CheckedChanged

        Dim objIniFile As New IniFile(PrPath & "base.ini")

        Select Case chk_no_log.Checked

            Case False

                objIniFile.WriteString("General", "LOG", "0")

            Case True

                objIniFile.WriteString("General", "LOG", "1")

        End Select
    End Sub

    Private Sub Button3_Click(ByVal sender As Object, ByVal e As EventArgs) Handles Button3.Click

        Dim dlgColor As ColorDialog
        dlgColor = New ColorDialog
        Label9.ForeColor = changeColor(dlgColor, Label9)

        FontC = Label9.ForeColor.Name

        Dim objIniFile As New IniFile(PrPath & "base.ini")

        objIniFile.WriteString("general", "FontColor", FontC)

        Call FONT_LOAD(Me)
    End Sub

    Public Function changeColor(ByVal FontWindow As ColorDialog, ByVal str As Control)

        Dim DialogResult As DialogResult

        Dim PrevisiusColor As Color = str.ForeColor

        DialogResult = FontWindow.ShowDialog

        If DialogResult = DialogResult.OK Then
            Return FontWindow.Color

        Else
            Return PrevisiusColor

        End If
    End Function

    Private Sub FONT_LOAD(ByVal ControlContainer As Object)

        'SendFonts(Me)

        For Each Ctl As Object In ControlContainer.Controls
            Try
                If Not Ctl.Controls Is Nothing Then
                    FONT_LOAD(Ctl)
                    If TypeOf Ctl Is Form Then Ctl.Font = New Font(FontN, fontS, FontSt, 0, FontB)
                    If TypeOf Ctl Is TextBox Then Ctl.Font = New Font(FontN, fontS, FontSt, 0, FontB)
                    If TypeOf Ctl Is ComboBox Then Ctl.Font = New Font(FontN, fontS, FontSt, 0, FontB)
                    If TypeOf Ctl Is Label Then Ctl.Font = New Font(FontN, fontS, FontSt, 0, FontB)
                    If TypeOf Ctl Is ListView Then Ctl.Font = New Font(FontN, fontS, FontSt, 0, FontB)
                    If TypeOf Ctl Is TreeView Then Ctl.Font = New Font(FontN, fontS, FontSt, 0, FontB)
                    If TypeOf Ctl Is TabPage Then Ctl.Font = New Font(FontN, fontS, FontSt, 0, FontB)
                    If TypeOf Ctl Is GroupBox Then Ctl.Font = New Font(FontN, fontS, FontSt, 0, FontB)
                    If TypeOf Ctl Is DateTimePicker Then Ctl.Font = New Font(FontN, fontS, FontSt, 0, FontB)
                    If TypeOf Ctl Is NumericUpDown Then Ctl.Font = New Font(FontN, fontS, FontSt, 0, FontB)
                    If TypeOf Ctl Is Button Then Ctl.Font = New Font(FontN, fontS, FontSt, 0, FontB)
                    If TypeOf Ctl Is CheckBox Then Ctl.Font = New Font(FontN, fontS, FontSt, 0, FontB)
                    If TypeOf Ctl Is RadioButton Then Ctl.Font = New Font(FontN, fontS, FontSt, 0, FontB)
                    If TypeOf Ctl Is ListBox Then Ctl.Font = New Font(FontN, fontS, FontSt, 0, FontB)

                    If TypeOf Ctl Is TabControl Then Ctl.Font = New Font(FontN, fontS)

                    If TypeOf Ctl Is MenuStrip Then Ctl.Font = New Font(FontN, fontS)
                    If TypeOf Ctl Is ToolStrip Then Ctl.Font = New Font(FontN, fontS)
                    If TypeOf Ctl Is StatusStrip Then Ctl.Font = New Font(FontN, fontS)

                    If TypeOf Ctl Is Button Then Ctl.autosize = True
                    If TypeOf Ctl Is Label Then Ctl.autosize = True
                    If TypeOf Ctl Is TableLayoutPanel Then Ctl.autosize = True
                    If TypeOf Ctl Is GroupBox Then Ctl.autosize = True

                End If

            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        Next


        Call COLOR_LOAD(Me)
    End Sub


    Private Sub COLOR_LOAD(ByVal ControlContainer As Object)

        'Me.ForeColor = Drawing.Color.FromName(FontC)

        'lvPrUsers.ForeColor = Drawing.Color.FromName(FontC)


        For Each C As Object In ControlContainer.Controls
            Try
                If Not C.Controls Is Nothing Then
                    COLOR_LOAD(C)
                    If TypeOf C Is Form Then C.ForeColor = Color.FromName(FontC)
                    'If TypeOf C Is TabControl Then C.TabPage.ForeColor = Drawing.Color.FromName(FontC)
                    If TypeOf C Is TableLayoutPanel Then C.ForeColor = Color.FromName(FontC)
                    If TypeOf C Is GroupBox Then C.ForeColor = Color.FromName(FontC)
                    If TypeOf C Is Label Then C.ForeColor = Color.FromName(FontC)
                    If TypeOf C Is CheckBox Then C.ForeColor = Color.FromName(FontC)
                    If TypeOf C Is RadioButton Then C.ForeColor = Color.FromName(FontC)
                    If TypeOf C Is TextBox Then C.ForeColor = Color.FromName(FontC)
                    If TypeOf C Is ComboBox Then C.ForeColor = Color.FromName(FontC)
                    If TypeOf C Is ListView Then C.ForeColor = Color.FromName(FontC)
                End If

            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        Next
    End Sub


    Private Sub ComboBox1_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) _
        Handles ComboBox1.SelectedIndexChanged


        Dim objIniFile As New IniFile(PrPath & "base.ini")
        objIniFile.WriteString("general", "ICONs", ComboBox1.Text)

        sICONS = ComboBox1.Text
    End Sub

    Private Sub chkFullScreen_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) _
        Handles chkFullScreen.CheckedChanged
        Dim objIniFile As New IniFile(PrPath & "base.ini")

        Select Case chkFullScreen.Checked

            Case False

                objIniFile.WriteString("General", "FullScreen", "0")

            Case True

                objIniFile.WriteString("General", "FullScreen", "1")

        End Select
    End Sub

    Private Sub TableLayoutPanel4_Paint(ByVal sender As Object, ByVal e As PaintEventArgs) _
        Handles TableLayoutPanel4.Paint
    End Sub

    Private Sub chkFonts_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles chkFonts.CheckedChanged
        Dim objIniFile As New IniFile(PrPath & "base.ini")

        Select Case chkFonts.Checked

            Case False

                objIniFile.WriteString("General", "chkFonts", "0")
                FontI = 0
                Button2.Visible = False
                Button3.Visible = False
            Case True

                objIniFile.WriteString("General", "chkFonts", "1")
                FontI = 1
                Button2.Visible = True
                Button3.Visible = True
        End Select
    End Sub

    Private Sub ComboBox2_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles ComboBox2.SelectedIndexChanged

        Dim objIniFile As New IniFile(PrPath & "base.ini")
        objIniFile.WriteString("General", "TechINF", ComboBox2.Text)

        sTechINF = ComboBox2.Text
    End Sub

    Private Sub chkUpdate_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles chkUpdate.CheckedChanged
    End Sub

    Private Sub TableLayoutPanel1_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles TableLayoutPanel1.Paint

    End Sub

    Private Sub RadioButton10_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton10.CheckedChanged

        Dim objIniFile As New IniFile(PrPath & "base.ini")
        objIniFile.WriteString("General", "TREE_UPDATE", "0")
        TREE_UPDATE = 0

    End Sub

    Private Sub RadioButton11_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton11.CheckedChanged

        Dim objIniFile As New IniFile(PrPath & "base.ini")
        objIniFile.WriteString("General", "TREE_UPDATE", "1")
        TREE_UPDATE = 1

    End Sub

    Private Sub chkRemVisible_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkRemVisible.CheckedChanged
        Dim objIniFile As New IniFile(PrPath & "base.ini")

        Select Case chkRemVisible.Checked

            Case False

                objIniFile.WriteString("TREE", "REM", "0")
                remVisible = False

            Case True

                objIniFile.WriteString("TREE", "REM", "1")
                remVisible = True

        End Select
    End Sub

    Private Sub chkNB_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkNB.CheckedChanged

        Dim objIniFile As New IniFile(PrPath & "base.ini")

        Select Case chkNB.Checked

            Case False

                objIniFile.WriteString("TREE", "NB", "0")
                NBVisible = False

            Case True

                objIniFile.WriteString("TREE", "NB", "1")
                NBVisible = True

        End Select
    End Sub

    Private Sub chkSP_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkSP.CheckedChanged
        Dim objIniFile As New IniFile(PrPath & "base.ini")

        Select Case chkSP.Checked

            Case False

                objIniFile.WriteString("TREE", "SP", "0")
                SPVisible = False

            Case True

                objIniFile.WriteString("TREE", "SP", "1")
                SPVisible = True

        End Select
    End Sub


    Private Sub Button1_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSMTP_Save.Click
        Dim objIniFile As New IniFile(PrPath & "base.ini")

        objIniFile.WriteString("SMTP", "Server", txtSMTP.Text)
        objIniFile.WriteString("SMTP", "Port", txtPort.Text)
        objIniFile.WriteString("SMTP", "User", txtMUser.Text)

        Dim Code As String = EncryptString(txtMPassword.Text)

        objIniFile.WriteString("SMTP", "Password", Code)

        objIniFile.WriteString("SMTP", "TLS", chkTLS.Checked)

    End Sub



    Private Sub Button5_Click(sender As System.Object, e As System.EventArgs) Handles btnServiceColor.Click

        Dim dlgColor As ColorDialog
        dlgColor = New ColorDialog

        btnServiceColor.ForeColor = changeColor(dlgColor, btnServiceColor)

        ' FontC = Button5.ForeColor.Name

        Dim objIniFile As New IniFile(PrPath & "base.ini")

        objIniFile.WriteString("Tree", "ServiceColor", btnServiceColor.ForeColor.Name)

        chkRemVisible.ForeColor = btnServiceColor.ForeColor
        ServiceColor = btnServiceColor.ForeColor.Name

    End Sub

    Private Sub btnSpisanColor_Click(sender As System.Object, e As System.EventArgs) Handles btnSpisanColor.Click
        Dim dlgColor As ColorDialog
        dlgColor = New ColorDialog

        btnSpisanColor.ForeColor = changeColor(dlgColor, btnSpisanColor)

        ' FontC = Button6.ForeColor.Name

        Dim objIniFile As New IniFile(PrPath & "base.ini")

        objIniFile.WriteString("Tree", "SpisanColor", btnSpisanColor.ForeColor.Name)

        chkSP.ForeColor = btnSpisanColor.ForeColor
        SpisanColor = btnSpisanColor.ForeColor.Name

    End Sub

    Private Sub btnNbColor_Click(sender As System.Object, e As System.EventArgs) Handles btnNbColor.Click
        Dim dlgColor As ColorDialog
        dlgColor = New ColorDialog

        btnNbColor.ForeColor = changeColor(dlgColor, btnNbColor)

        ' FontC = Button7.ForeColor.Name

        Dim objIniFile As New IniFile(PrPath & "base.ini")

        objIniFile.WriteString("Tree", "NbColor", btnNbColor.ForeColor.Name)

        chkNB.ForeColor = btnNbColor.ForeColor

        NbColor = btnNbColor.ForeColor.Name

    End Sub

  
End Class