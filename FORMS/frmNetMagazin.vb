

Public Class frmNetMagazin
    Private m_SortingColumn As ColumnHeader
    Public sBDO_Pref As String
    Public sBDO_count As String
    Public sBDO_SVT_count As String
    Public sBDO_NET_count As String
    Private sID As Integer = 0
    Public sBDO_SVT_Pref As String

    Public Sub New()
        InitializeComponent()
    End Sub 'New

    Private Sub frmNetMagazin_Resize(ByVal eventSender As Object, ByVal eventArgs As EventArgs) Handles MyBase.Resize

        Call RESIZER()
    End Sub

    Private Sub SplitContainer1_Resize(ByVal sender As Object, ByVal e As EventArgs) Handles SplitContainer1.Resize
        Call RESIZER()
    End Sub

    Private Sub RESIZER()

        If SplitContainer1.SplitterDistance > 450 Then SplitContainer1.SplitterDistance = 450
        If SplitContainer1.SplitterDistance < 250 Then SplitContainer1.SplitterDistance = 250
    End Sub

    Private Sub SplitContainer1_SplitterMoved(ByVal sender As Object, ByVal e As SplitterEventArgs) _
        Handles SplitContainer1.SplitterMoved
        Call RESIZER()
    End Sub

    Public Sub RefFilTreeNM()
        On Error GoTo ERR1

        lstgroups.HideSelection = False

        'frmComputers.gbTree.ForeColor = Color.Red

        'On Error Resume Next
        Dim sTEN As String
        Dim sVISIBLE As String
        Dim sSQL1 As String
        Dim sSQL2 As String
        'Dim sSQL3 As String
        'Dim sSQL4 As String
        Dim sSQL5 As String


        Dim objIniFile As New IniFile(PrPath & "base.ini")
        sVISIBLE = objIniFile.GetString("general", "VisibleALL", "")
        KCKey = objIniFile.GetString("general", "DK", 0)
        DCKey = objIniFile.GetString("general", "Default", 0)

        Dim zBranche As String
        zBranche = objIniFile.GetString("general", "branche", "")

        Dim LNGIniFile As New IniFile(sLANGPATH)

        If Len(zBranche) = 0 Or zBranche = LNGIniFile.GetString("frmComputers", "MSG53", "Все") Then

            zBranche = "0"

        Else


        End If


        lstgroups.Nodes.Clear()


        'Select Case sICONS


        '    Case "32*32"

        '        lstGroups.ImageList = frmComputers.ImageList11

        '    Case Else

        '        lstGroups.ImageList = frmComputers.ilsCommands

        'End Select

        lstGroups.ImageList = frmComputers.ilsCommands

        Dim rs As Recordset
        Dim rs2 As Recordset
        'Dim rs3 As ADODB.Recordset
        ' Dim rs4 As ADODB.Recordset
        ' Dim rs5 As ADODB.Recordset
        'Dim rs6 As ADODB.Recordset
        Dim rs7 As Recordset


        Dim strItemText As String
        Dim unamS2, unamS As Integer


        Dim unameS As String
        Dim unameS2 As String
        Dim unameS3 As String
        Dim unameS4 As String

        'Верхний нулевой уровень - вставляем название организации
        Dim rsG As Recordset
        rsG = New Recordset

        rsG.Open("SELECT ORG FROM CONFIGURE", DB7, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic)
        Dim ORG As String

        With rsG
            If Not IsDBNull(.Fields("ORG").Value) Then ORG = .Fields("ORG").Value
        End With

        rsG.Close()
        rsG = Nothing

        Dim nodeRoot As New TreeNode(ORG, 0, 0)
        nodeRoot.Tag = "ROOT"
        lstgroups.Nodes.Add(nodeRoot)


        rs7 = New Recordset
        rs7.Open("SELECT count(*) as t_nim FROM SPR_KAB", DB7, CursorTypeEnum.adOpenDynamic,
                 LockTypeEnum.adLockOptimistic)

        With rs7
            unamS2 = .Fields("t_nim").Value
        End With

        rs7.Close()
        rs7 = Nothing


        ''My.Application.DoEvents()

        'lstgroups.Invoke()

        'Филиалы Первый уровень дерева
        'Проверяем все показывать или только активные

        If zBranche = "0" Then

            If sVISIBLE = 1 Then
                sSQL1 = "SELECT id, Filial FROM SPR_FILIAL ORDER BY Filial"
            Else
                sSQL1 = "SELECT id, Filial FROM SPR_FILIAL where Arhiv=0 ORDER BY Filial"
            End If

        Else

            If sVISIBLE = 1 Then
                sSQL1 = "SELECT id, Filial FROM SPR_FILIAL where filial ='" & zBranche & "' ORDER BY Filial"
            Else
                sSQL1 = "SELECT id, Filial FROM SPR_FILIAL where Arhiv=0 and filial ='" & zBranche & "' ORDER BY Filial"
            End If

        End If


        rs = New Recordset
        rs.Open(sSQL1, DB7, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic)

        With rs
            .MoveFirst()
            Do While Not .EOF
                ''My.Application.DoEvents()
                Dim BrancheNode As New TreeNode(.Fields("filial").Value, 0, 0)
                BrancheNode.Tag = "G|" & .Fields("id").Value
                sTEN = "G|" & .Fields("id").Value
                nodeRoot.Nodes.Add(BrancheNode)


                unameS = .Fields("filial").Value

                If KCKey = 0 And Len(DCKey) <> 0 Then

                    If DCKey = sTEN Then
                        lstgroups.SelectedNode = BrancheNode
                        lstgroups.SelectedNode.Expand()
                    End If
                End If

                BrancheNode.ForeColor = Color.DarkBlue
                'BrancheNode.NodeFont = New Font(BrancheNode.NodeFont, FontStyle.Bold)

                'Application.DoEvents()

                'Отделы в филиалах Второй уровень дерева

                If sVISIBLE = 1 Then
                    sSQL2 = "SELECT id, Filial, N_Otd FROM SPR_OTD_FILIAL WHERE filial='" & unameS &
                            "' ORDER BY Filial, N_Otd"
                Else
                    sSQL2 = "SELECT id, Filial, N_Otd FROM SPR_OTD_FILIAL where filial='" & unameS &
                            "' AND Arhiv=0 ORDER BY Filial, N_Otd"
                End If
                rs2 = New Recordset
                rs2.Open(sSQL2, DB7, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic)

                With rs2
                    .MoveFirst()
                    Do While Not .EOF

                        If .Fields("filial").Value = unameS Then

                            Dim DepatrmentNode As New TreeNode(.Fields("N_Otd").Value, 1, 1)
                            DepatrmentNode.Tag = "O|" & .Fields("id").Value
                            sTEN = "O|" & .Fields("id").Value
                            BrancheNode.Nodes.Add(DepatrmentNode)
                            unameS2 = .Fields("N_Otd").Value

                            If KCKey = 0 And Len(DCKey) <> 0 Then

                                If DCKey = sTEN Then
                                    lstgroups.SelectedNode = DepatrmentNode
                                    lstgroups.SelectedNode.Expand()
                                End If
                            End If

                            DepatrmentNode.ForeColor = Color.DarkGreen
                            'DepatrmentNode.NodeFont = New Font(DepatrmentNode.NodeFont, FontStyle.Italic)
                            'Application.DoEvents()

                            'Кабинеты Третий уровень дерева

                            If unamS2 > 0 Then

                                If sVISIBLE = 1 Then
                                    sSQL5 = "SELECT id, Name, N_F, N_M FROM SPR_KAB WHERE N_F='" & unameS &
                                            "' AND N_M ='" & unameS2 & "' ORDER BY N_F, N_M, Name"
                                Else
                                    sSQL5 = "SELECT id, Name, N_F, N_M FROM SPR_KAB where N_F='" & unameS &
                                            "' AND N_M ='" & unameS2 & "' AND Arhiv=0 ORDER BY N_F, N_M, Name"
                                End If

                                rs7 = New Recordset
                                rs7.Open(sSQL5, DB7, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic)

                                With rs7
                                    .MoveFirst()
                                    Do While Not .EOF

                                        Dim OfficeNode As New TreeNode(.Fields("name").Value, 2, 2)
                                        OfficeNode.Tag = "K|" & .Fields("id").Value
                                        sTEN = "K|" & .Fields("id").Value
                                        DepatrmentNode.Nodes.Add(OfficeNode)

                                        unameS3 = .Fields("name").Value

                                        If KCKey = 0 And Len(DCKey) <> 0 Then

                                            If DCKey = sTEN Then
                                                lstgroups.SelectedNode = OfficeNode
                                                lstgroups.SelectedNode.Expand()
                                            End If
                                        End If

                                        OfficeNode.ForeColor = Color.DarkGoldenrod
                                        'Application.DoEvents()

                                        .MoveNext()
                                    Loop
                                End With
                                rs7.Close()
                                rs7 = Nothing

                            End If
                            'Конец кабинетов


                        End If


                        .MoveNext()
                    Loop
                End With
                rs2.Close()
                rs2 = Nothing

                .MoveNext()
            Loop
        End With
        rs.Close()
        rs = Nothing


        If KCKey = 0 And Len(DCKey) = 0 Then

            lstgroups.SelectedNode = nodeRoot
            Dim tNode As New TreeNode
            tNode = lstgroups.Nodes(0)
            tNode.Expand()

        End If


        exitsub:


        Exit Sub
        ERR1:
        'MsgBox Err.Description
        Select Case Err.Number
            Case 3021 'ignore, no entries in list
                'MsgBox(Err.Description, vbCritical, "KZ")
                Resume Next
            Case Else

                MsgBox(Err.Description, vbCritical, "KZ")

        End Select
    End Sub

    Private Sub frmNetMagazin_Activated(ByVal sender As Object, ByVal e As EventArgs) Handles Me.Activated

        frmMain.SaveInfTehButton.Enabled = False
        frmMain.ToolStripDropDownButton1.Enabled = False

        If uLevel <> "Admin" Then
            frmMain.ToolStripDropDownButton1.Enabled = False
            Me.tsbAdd.Enabled = False
            Me.tsbDel.Enabled = False
        End If
    End Sub

    Private Sub frmNetMagazin_Load(ByVal sender As Object, ByVal e As EventArgs) Handles Me.Load


        SendFonts(Me)

        tsbAdd.Image = New Bitmap(PrPath & "pic\iface\add.png")
        tsbDel.Image = New Bitmap(PrPath & "pic\iface\remove.png")


        Dim objIniFile As New IniFile(PrPath & "base.ini")
        Dim uname As String

        uname = objIniFile.GetString("General", "branche", "")
        Dim LNGIniFile As New IniFile(sLANGPATH)

        If Len(uname) = 0 Then
            treebranche.Text = LNGIniFile.GetString("frmComputers", "MSG53", "Все")

        Else
            treebranche.Text = uname

        End If

        FillComboNET(Me.treebranche, "FILIAL", "SPR_FILIAL", "", False, True)
        treebranche.Items.Add("Все")


        Me.Cursor = Cursors.WaitCursor

        Call frmMagazin_LANG()

        Me.Invoke(New MethodInvoker(AddressOf RefFilTreeNM))

        Me.Cursor = Cursors.Default
    End Sub

    Public Sub NET_MAG_LOAD()

        On Error GoTo err_

        Dim LNGIniFile As New IniFile(sLANGPATH)

        lvNetMagazin.Items.Clear()
        lvNetMagazin.Sorting = False

        Label4.Text = "-"
        Label5.Text = "-"
        Label6.Text = "-"

        'TBL_NET_MAG

        Dim sSQL As String
        Dim rs As Recordset
        Dim scCount As Integer


        If sBDO_Pref <> "ROOT" And Me.sBDO_count <> "" Then

            sSQL = "SELECT count(*) as t_n FROM TBL_NET_MAG where sID=" & Me.sBDO_count & " AND PREF='" & Me.sBDO_Pref &
                   "'"

        Else
            sSQL = "SELECT count(*) as t_n FROM TBL_NET_MAG"

        End If


        rs = New Recordset
        rs.Open(sSQL, DB7, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic)
        With rs
            scCount = .Fields("t_n").Value
        End With
        rs.Close()
        rs = Nothing

        Label4.Text = scCount

        If scCount = 0 Then Exit Sub


        If sBDO_Pref <> "ROOT" Then

            sSQL = "SELECT count(*) as t_N FROM TBL_NET_MAG where sID=" & Me.sBDO_count & " AND PREF='" & Me.sBDO_Pref &
                   "' AND SVT <> 0"

        Else

            sSQL = "SELECT count(*) as t_N FROM TBL_NET_MAG where SVT <> 0"

        End If


        rs = New Recordset
        rs.Open(sSQL, DB7, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic)
        With rs
            scCount = .Fields("t_n").Value
        End With
        rs.Close()
        rs = Nothing

        Label5.Text = scCount


        If sBDO_Pref <> "ROOT" Then

            sSQL = "SELECT sum(dlin_cab) as summa FROM TBL_NET_MAG where sID=" & Me.sBDO_count & " AND PREF='" &
                   Me.sBDO_Pref & "'"

        Else

            sSQL = "SELECT sum(dlin_cab) as summa FROM TBL_NET_MAG"

        End If


        rs = New Recordset
        rs.Open(sSQL, DB7, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic)
        With rs
            scCount = .Fields("summa").Value
        End With
        rs.Close()
        rs = Nothing

        Label6.Text = scCount & " " & LNGIniFile.GetString("frmNetMagazin", "MSG23", "м.")


        If sBDO_Pref <> "ROOT" Then

            sSQL = "SELECT * FROM TBL_NET_MAG where sID=" & Me.sBDO_count & " AND PREF='" & Me.sBDO_Pref & "'"

        Else

            sSQL = "SELECT * FROM TBL_NET_MAG ORDER BY id, id_line asc, PREF,SID"

        End If


        Dim rs1 As Recordset

        rs = New Recordset
        rs.Open(sSQL, DB7, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic)

        Dim intCount As Decimal = 0

        With rs
            .MoveFirst()
            Do While Not .EOF

                lvNetMagazin.Items.Add(.Fields("id").Value) 'col no. 1

                If Not IsDBNull(.Fields("id_line").Value) Then
                    lvNetMagazin.Items(CInt(intCount)).SubItems.Add(.Fields("id_line").Value)
                Else
                    lvNetMagazin.Items(CInt(intCount)).SubItems.Add("")
                End If

                If Not IsDBNull(.Fields("tip_cab").Value) Then
                    lvNetMagazin.Items(CInt(intCount)).SubItems.Add(.Fields("tip_cab").Value)
                Else
                    lvNetMagazin.Items(CInt(intCount)).SubItems.Add("")
                End If

                If Not IsDBNull(.Fields("dlin_cab").Value) Then
                    lvNetMagazin.Items(CInt(intCount)).SubItems.Add(.Fields("dlin_cab").Value)
                Else
                    lvNetMagazin.Items(CInt(intCount)).SubItems.Add("")
                End If

                If Not IsDBNull(.Fields("tip_cab_line").Value) Then
                    lvNetMagazin.Items(CInt(intCount)).SubItems.Add(.Fields("tip_cab_line").Value)
                Else
                    lvNetMagazin.Items(CInt(intCount)).SubItems.Add("")
                End If

                If Not IsDBNull(.Fields("PHONE").Value) Then
                    lvNetMagazin.Items(CInt(intCount)).SubItems.Add(.Fields("PHONE").Value)
                Else
                    lvNetMagazin.Items(CInt(intCount)).SubItems.Add("")
                End If

                Dim sIDs As Integer = 0


                If Not IsDBNull(.Fields("SVT").Value) Then

                    sIDs = .Fields("SVT").Value

                    If sIDs = 0 Or Len(sIDs) = 0 Then

                        lvNetMagazin.Items(CInt(intCount)).SubItems.Add("")
                        lvNetMagazin.Items(CInt(intCount)).SubItems.Add("")

                    Else

                        rs1 = New Recordset
                        rs1.Open("SELECT id,NET_NAME,OTvetstvennyj FROM kompy where id=" & sIDs, DB7, CursorTypeEnum.adOpenDynamic,
                                 LockTypeEnum.adLockOptimistic)

                        With rs1

                            If Not IsDBNull(.Fields("OTvetstvennyj").Value) Then
                                lvNetMagazin.Items(CInt(intCount)).SubItems.Add(.Fields("OTvetstvennyj").Value)
                            Else
                                lvNetMagazin.Items(CInt(intCount)).SubItems.Add("")
                            End If

                            If sBDO_Pref = "ROOT" Then

                                If Not IsDBNull(.Fields("NET_NAME").Value) Then
                                    lvNetMagazin.Items(CInt(intCount)).SubItems.Add(.Fields("NET_NAME").Value) _
                                    '& " " & LNGIniFile.GetString("frmNetMagazin", "MSG22", "") & " " & .Fields("filial").Value & "/" & .Fields("mesto").Value & "/" & .Fields("kabn").Value)
                                Else
                                    lvNetMagazin.Items(CInt(intCount)).SubItems.Add("")
                                End If

                            Else
                                If Not IsDBNull(.Fields("NET_NAME").Value) Then
                                    lvNetMagazin.Items(CInt(intCount)).SubItems.Add(.Fields("NET_NAME").Value)
                                Else
                                    lvNetMagazin.Items(CInt(intCount)).SubItems.Add("")
                                End If
                            End If

                        End With
                        rs1.Close()
                        rs1 = Nothing
                    End If


                Else
                    lvNetMagazin.Items(CInt(intCount)).SubItems.Add("")
                    lvNetMagazin.Items(CInt(intCount)).SubItems.Add("")
                End If


                Dim A1, A2, A3, A4 As String

                Select Case .Fields("PREF").Value

                    Case "G"

                        rs1 = New Recordset
                        rs1.Open("SELECT id, Filial as one_par FROM SPR_FILIAL where id=" & .Fields("sID").Value, DB7,
                                 CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic)

                        With rs1

                            A1 = .Fields("one_par").Value
                            A2 = ""
                            A3 = ""
                        End With

                        rs1.Close()
                        rs1 = Nothing

                    Case "O"

                        rs1 = New Recordset
                        rs1.Open(
                            "SELECT id, Filial as one_par, N_Otd as two_par FROM SPR_OTD_FILIAL WHERE id=" &
                            .Fields("sID").Value, DB7, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic)

                        With rs1

                            A1 = .Fields("one_par").Value
                            A2 = .Fields("two_par").Value
                            A3 = ""
                        End With

                        rs1.Close()
                        rs1 = Nothing
                    Case "K"

                        rs1 = New Recordset
                        rs1.Open(
                            "SELECT id, Name as tree_par, N_F as one_par, N_M as two_par FROM SPR_KAB where id=" &
                            .Fields("sID").Value, DB7, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic)

                        With rs1

                            A1 = .Fields("one_par").Value
                            A2 = .Fields("two_par").Value
                            A3 = .Fields("tree_par").Value
                        End With

                        rs1.Close()
                        rs1 = Nothing

                End Select

                If Len(A1) <> 0 Then A4 = A1
                If Len(A2) <> 0 Then A4 = A4 & "/" & A2
                If Len(A3) <> 0 Then A4 = A4 & "/" & A3

                lvNetMagazin.Items(CInt(intCount)).SubItems.Add(A4)


                'If Not IsDBNull(.Fields("COMMUTATOR").Value) Then
                '    lvNetMagazin.Items(CInt(intCount)).SubItems.Add(.Fields("COMMUTATOR").Value)
                'Else
                '    lvNetMagazin.Items(CInt(intCount)).SubItems.Add("")
                'End If


                If Not IsDBNull(.Fields("COMMUTATOR").Value) Then

                    sIDs = .Fields("COMMUTATOR").Value

                    If sIDs = 0 Or Len(sIDs) = 0 Then

                        lvNetMagazin.Items(CInt(intCount)).SubItems.Add("")

                    Else

                        rs1 = New Recordset
                        rs1.Open("SELECT id,NET_NAME,OTvetstvennyj FROM kompy where id=" & sIDs, DB7, CursorTypeEnum.adOpenDynamic,
                                 LockTypeEnum.adLockOptimistic)

                        With rs1

                            lvNetMagazin.Items(CInt(intCount)).SubItems.Add(
                                LNGIniFile.GetString("frmNetMagazin", "MSG14", "Сетевое оборудование") & ": " &
                                .Fields("NET_NAME").Value & " , (" &
                                LNGIniFile.GetString("frmNetMagazin", "MSG19", "Отв.:") & " " &
                                .Fields("OTvetstvennyj").Value & ")")


                        End With
                        rs1.Close()
                        rs1 = Nothing

                    End If

                Else
                    lvNetMagazin.Items(CInt(intCount)).SubItems.Add("1")
                End If


                If Not IsDBNull(.Fields("NET_PORT_COMMUTATOR").Value) Then
                    lvNetMagazin.Items(CInt(intCount)).SubItems.Add(.Fields("NET_PORT_COMMUTATOR").Value)
                Else
                    lvNetMagazin.Items(CInt(intCount)).SubItems.Add("")
                End If

                If Not IsDBNull(.Fields("SVT_MEMO").Value) Then
                    lvNetMagazin.Items(CInt(intCount)).SubItems.Add(.Fields("SVT_MEMO").Value)
                Else
                    lvNetMagazin.Items(CInt(intCount)).SubItems.Add("")
                End If


                intCount = intCount + 1
                .MoveNext()
            Loop
        End With


        'Me.lvNetMagazin.Columns.Add("Порт", 100, HorizontalAlignment.Left)
        'Me.lvNetMagazin.Columns.Add("Примечание", 100, HorizontalAlignment.Left)


        rs.Close()
        rs = Nothing


        ResList(lvNetMagazin)


        Exit Sub
        err_:
    End Sub

    Private Sub lvNetMagazin_ColumnClick(ByVal sender As Object, ByVal e As ColumnClickEventArgs) _
        Handles lvNetMagazin.ColumnClick

        SORTING_LV(lvNetMagazin, e)

    End Sub

    Private Sub tsbAdd_Click(ByVal sender As Object, ByVal e As EventArgs) Handles tsbAdd.Click

        sID = 0

        frmNetMag_Add.sEDT = False
        frmNetMag_Add.sID = 0

        Me.sBDO_SVT_count = 0

        frmNetMag_Add.txtLineRoz.Text = ""
        frmNetMag_Add.cmbTipCab.Text = ""
        frmNetMag_Add.cmbTipKabLine.Text = ""
        frmNetMag_Add.txtDlina.Text = ""
        frmNetMag_Add.cmbTipKabLine.Text = ""
        frmNetMag_Add.txtSVT.Text = ""
        frmNetMag_Add.txtNetPortSVT.Text = ""
        frmNetMag_Add.cmbPhone.Text = ""
        frmNetMag_Add.txtSVT_MEMO.Text = ""
        frmNetMag_Add.txtKom.Text = ""
        frmNetMag_Add.txtPortCom.Text = ""
        frmNetMag_Add.txtComMemo.Text = ""

        frmNetMag_Add.ShowDialog(Me)
    End Sub

    Private Sub lstGroups_AfterSelect(ByVal sender As Object, ByVal e As TreeViewEventArgs) _
        Handles lstGroups.AfterSelect
        'sBDOtext
        sID = 0

        On Error Resume Next
        lvNetMagazin.ListViewItemSorter = Nothing

        frmComputers.sCOUNT = 0

        If lstGroups.Nodes.Count <= 0 Then Exit Sub
        Me.Cursor = Cursors.WaitCursor
        Dim d() As String

        d = Split(lstGroups.SelectedNode.Tag, "|")

        'rtxtC = lstGroups.SelectedNode.Parent.Text
        'rtxtC = lstGroups.SelectedNode.Text

        Select Case d(0)

            Case "C"

                Dim objIniFile As New IniFile(PrPath & "base.ini")
                objIniFile.WriteString("general", "DK", d(1))
                objIniFile.WriteString("general", "Default", 0)

            Case Else

                Dim objIniFile As New IniFile(PrPath & "base.ini")
                objIniFile.WriteString("general", "DK", 0)
                objIniFile.WriteString("general", "Default", lstGroups.SelectedNode.Tag)

        End Select


        Select Case d(0)


            Case "G"


                sBDO_Pref = Trim(d(0))
                sBDO_count = Trim(d(1))

            Case "O"


                sBDO_Pref = Trim(d(0))
                sBDO_count = Trim(d(1))


            Case "K"

                sBDO_Pref = Trim(d(0))
                sBDO_count = Trim(d(1))


            Case "ROOT"

                sBDO_Pref = Trim(d(0))

        End Select

        Me.Cursor = Cursors.Default

        'Me.Text = sBDO_Pref & "\" & sBDO_count

        'Call NET_MAG_LOAD()
        Me.Invoke(New MethodInvoker(AddressOf NET_MAG_LOAD))
    End Sub

    Private Sub lvNetMagazin_DoubleClick(ByVal sender As Object, ByVal e As EventArgs) Handles lvNetMagazin.DoubleClick

        On Error Resume Next

        If uLevel <> "Admin" Then Exit Sub

        If lvNetMagazin.Items.Count = 0 Then Exit Sub


        Me.sBDO_SVT_Pref = "PC"

        Dim z As Integer
        Dim z1 As Integer
        Dim LNGIniFile As New IniFile(sLANGPATH)


        For z = 0 To lvNetMagazin.SelectedItems.Count - 1
            frmNetMag_Add.sID = (lvNetMagazin.SelectedItems(z).Text)
        Next

        Dim sSQL As String
        Dim rs1 As Recordset

        frmNetMag_Add.sEDT = True

        Me.sBDO_Pref = ""
        Me.sBDO_count = 0
        Me.sBDO_SVT_count = 0
        Me.sBDO_NET_count = 0


        sSQL = "SELECT * FROM TBL_NET_MAG where id=" & frmNetMag_Add.sID

        Dim rs As Recordset
        rs = New Recordset
        rs.Open(sSQL, DB7, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic)


        With rs

            frmNetMag_Add.txtLineRoz.Text = .Fields("id_line").Value
            frmNetMag_Add.cmbTipCab.Text = .Fields("tip_cab").Value
            frmNetMag_Add.txtDlina.Text = .Fields("dlin_cab").Value
            frmNetMag_Add.cmbTipKabLine.Text = .Fields("tip_cab_line").Value

            z1 = .Fields("SVT").Value
            Me.sBDO_SVT_count = z1


            If z1 = 0 Or Len(z1) = 0 Then

                frmNetMag_Add.txtSVT.Text = ""
                frmNetMag_Add.txtKom.Text = ""

            Else


                Dim sTXT As String

                rs1 = New Recordset
                rs1.Open("SELECT id,NET_NAME,OTvetstvennyj FROM kompy where id=" & z1, DB7, CursorTypeEnum.adOpenDynamic,
                         LockTypeEnum.adLockOptimistic)


                With rs1

                    Select Case .Fields("tiptehn").Value

                        Case "PC"

                            sTXT = LNGIniFile.GetString("frmNetMagazin", "MSG11", "Компьютер")
                        Case "Printer"

                            sTXT = LNGIniFile.GetString("frmNetMagazin", "MSG6", "Принтер")
                        Case "KOpir"

                            sTXT = LNGIniFile.GetString("frmNetMagazin", "MSG13", "Копир")
                        Case "MONITOR"
                            sTXT = LNGIniFile.GetString("frmNetMagazin", "MSG3", "Монитор")
                        Case "SCANER"

                            sTXT = LNGIniFile.GetString("frmNetMagazin", "MSG8", "Сканер")
                        Case "NET"

                            sTXT = LNGIniFile.GetString("frmNetMagazin", "MSG14", "Сетевое оборудование")
                        Case "PHOTO"

                            sTXT = LNGIniFile.GetString("frmNetMagazin", "MSG15", "Фотоаппарат")

                        Case "OT"

                            sTXT = .Fields("NET_NAME").Value & " " & .Fields("TIP_COMPA").Value
                        Case "ZIP"

                            sTXT = LNGIniFile.GetString("frmNetMagazin", "MSG18", "Дисковод ZIP")
                        Case "PHONE"

                            sTXT = LNGIniFile.GetString("frmNetMagazin", "MSG16", "Телефон")
                        Case "MFU"

                            sTXT = LNGIniFile.GetString("frmNetMagazin", "MSG7", "МФУ")
                        Case "FAX"

                            sTXT = LNGIniFile.GetString("frmNetMagazin", "MSG17", "Факс")

                        Case "USB"


                            sTXT = LNGIniFile.GetString("frmNetMagazin", "MSG10", "USB Устройство")
                        Case "IBP"


                            sTXT = LNGIniFile.GetString("frmNetMagazin", "MSG9", "Источник бесперебойного питания")
                        Case "FS"

                            sTXT = LNGIniFile.GetString("frmNetMagazin", "MSG5", "Сетевой фильтр")

                        Case "SOUND"

                            sTXT = LNGIniFile.GetString("frmNetMagazin", "MSG4", "Акустическая система")


                    End Select


                    Select Case Me.sBDO_SVT_Pref

                        Case "PC"

                            frmNetMag_Add.txtSVT.Text = sTXT & ": " & .Fields("NET_NAME").Value & " , (" &
                                                        LNGIniFile.GetString("frmNetMagazin", "MSG19", "Отв.:") & " " &
                                                        .Fields("OTvetstvennyj").Value & ")"
                            'Me.sBDO_SVT_count = .Fields("SVT").Value
                        Case Else

                            frmNetMag_Add.txtKom.Text = sTXT & ": " & .Fields("NET_NAME").Value & " , (" &
                                                        LNGIniFile.GetString("frmNetMagazin", "MSG19", "Отв.:") & " " &
                                                        .Fields("OTvetstvennyj").Value & ")"

                    End Select

                End With

                rs1.Close()
                rs1 = Nothing

            End If


            frmNetMag_Add.txtNetPortSVT.Text = .Fields("NET_PORT_SVT").Value
            frmNetMag_Add.cmbPhone.Text = .Fields("PHONE").Value
            frmNetMag_Add.txtSVT_MEMO.Text = .Fields("SVT_MEMO").Value

            z1 = .Fields("COMMUTATOR").Value

            Me.sBDO_NET_count = z1

            If z1 = 0 Or Len(z1) = 0 Then

                frmNetMag_Add.txtKom.Text = ""

            Else


                rs1 = New Recordset
                rs1.Open("SELECT id,NET_NAME,OTvetstvennyj FROM kompy where id=" & z1, DB7, CursorTypeEnum.adOpenDynamic,
                         LockTypeEnum.adLockOptimistic)

                With rs1

                    frmNetMag_Add.txtKom.Text = LNGIniFile.GetString("frmNetMagazin", "MSG14", "Сетевое оборудование") &
                                                ": " & .Fields("NET_NAME").Value & " , (" &
                                                LNGIniFile.GetString("frmNetMagazin", "MSG19", "Отв.:") & " " &
                                                .Fields("OTvetstvennyj").Value & ")"

                End With
                rs1.Close()
                rs1 = Nothing

            End If

            frmNetMag_Add.txtPortCom.Text = .Fields("NET_PORT_COMMUTATOR").Value
            frmNetMag_Add.txtComMemo.Text = .Fields("COMMUTATOR_MEMO").Value


            Me.sBDO_Pref = .Fields("PREF").Value
            Me.sBDO_count = .Fields("sID").Value

        End With
        rs.Close()
        rs = Nothing

        frmNetMag_Add.ShowDialog(Me)
    End Sub

    Private Sub lvNetMagazin_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) _
        Handles lvNetMagazin.SelectedIndexChanged

        If uLevel <> "Admin" Then Exit Sub
        If lvNetMagazin.Items.Count = 0 Then Exit Sub

        Dim z As Integer

        For z = 0 To lvNetMagazin.SelectedItems.Count - 1
            sID = (lvNetMagazin.SelectedItems(z).Text)
        Next
    End Sub

    Private Sub tsbDel_Click(ByVal sender As Object, ByVal e As EventArgs) Handles tsbDel.Click

        If sID = 0 Then


        Else
            Dim LNGIniFile As New IniFile(sLANGPATH)
            If _
                MsgBox(
                    LNGIniFile.GetString("frmNetMagazin", "MSG20", "Будет произведено удаление розетки") & vbCrLf &
                    LNGIniFile.GetString("frmNetMagazin", "MSG21", "Хотите продолжить?"), vbExclamation + vbYesNo,
                    ProGramName) = vbNo Then
                Exit Sub
            Else

                Dim rs As Recordset
                rs = New Recordset
                rs.Open("DELETE FROM TBL_NET_MAG WHERE id=" & sID, DB7, CursorTypeEnum.adOpenDynamic,
                        LockTypeEnum.adLockOptimistic)
                rs = Nothing
                Me.Invoke(New MethodInvoker(AddressOf NET_MAG_LOAD))


            End If


        End If
    End Sub

    Private Sub tsbExcell_Click(ByVal sender As Object, ByVal e As EventArgs) Handles tsbExcell.Click
        If lvNetMagazin.Items.Count = 0 Then Exit Sub


        Dim sSQL As String


        Select Case Me.sBDO_Pref

            Case "G"

                sSQL = "SELECT Filial as one_par FROM SPR_FILIAL where id=" & Me.sBDO_count

            Case "O"

                sSQL = "SELECT Filial as one_par, N_Otd as two_par FROM SPR_OTD_FILIAL WHERE id=" & Me.sBDO_count

            Case "K"

                sSQL = "SELECT Name as tree_par, N_F as one_par, N_M as two_par FROM SPR_KAB where id=" & Me.sBDO_count


        End Select

        Dim A1, A2, A3, A4 As String

        If Me.sBDO_Pref <> "ROOT" Then

            Dim rs As Recordset
            rs = New Recordset
            rs.Open(sSQL, DB7, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic)


            With rs

                Select Case Me.sBDO_Pref


                    Case "G"
                        A1 = .Fields("one_par").Value
                        A2 = "" '.Fields("two_par").Value
                        A3 = "" '.Fields("tree_par").Value
                        A4 = A1
                    Case "O"

                        A1 = .Fields("one_par").Value
                        A2 = .Fields("two_par").Value
                        A3 = "" '.Fields("tree_par").Value
                        A4 = A1 & "/" & A2

                    Case "K"

                        A1 = .Fields("one_par").Value
                        A2 = .Fields("two_par").Value
                        A3 = .Fields("tree_par").Value
                        A4 = A1 & "/" & A2 & "/" & A3
                End Select


            End With

            rs.Close()
            rs = Nothing

        Else

            A4 = ""

        End If

        Select Case sOfficePACK

            Case "OpenOffice.org"

                ExportListViewToCalc(lvNetMagazin, Me.Text & " (" & A4 & ")")

            Case Else

                ExportListViewToExcel(lvNetMagazin, Me.Text & " (" & A4 & ")")

        End Select
    End Sub

    Private Sub treebranche_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) _
        Handles treebranche.SelectedIndexChanged
        Dim objIniFile As New IniFile(PrPath & "base.ini")
        objIniFile.WriteString("General", "branche", treebranche.Text)

        Call RefFilTreeNM()
    End Sub
End Class