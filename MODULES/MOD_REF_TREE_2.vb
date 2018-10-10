Module MOD_REF_TREE_2

    Private lstgroups1 As TreeView
    Public BrancheNode1 As TreeNode
    Private DepatrmentNode1 As TreeNode
    Private OfficeNode1 As TreeNode
    Private iA1, iA2, iA3, iA4, iA5, iA6, iA7, iA8, iID As String
    Private stmREMONT As Integer = 0
    Public BrancheNode As TreeNode
    Public FILIAL1, OTDEL1, KABINET1 As String

    Public Sub RefFilTree2(ByVal lstgroups As TreeView)

        Dim sVISIBLE As String
        Dim objIniFile As New IniFile(PrPath & "base.ini")
        sVISIBLE = objIniFile.GetString("general", "VisibleALL", "")
        KCKey = objIniFile.GetString("general", "DK", 0)
        DCKey = objIniFile.GetString("general", "Default", 0)


        lstgroups.ImageList = frmComputers.ilsCommands

        lstgroups.BeginUpdate()
        lstgroups.Nodes.Clear()
        lstgroups.HideSelection = False

        Dim rs As Recordset
        rs = New Recordset
        rs.Open("SELECT ORG FROM CONFIGURE", DB7, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic)
        Dim ORG, sSQL, sSQL1, sTEN As String

        With rs
            If Not IsDBNull(.Fields("ORG").Value) Then ORG = .Fields("ORG").Value
        End With

        rs.Close()
        rs = Nothing

        Dim nodeRoot As New TreeNode(ORG, 69, 69)
        nodeRoot.Tag = "ROOT|001" ' & GENID()
        nodeRoot.Name = ORG
        nodeRoot.Text = ORG
        lstgroups.Nodes.Add(nodeRoot)


        sSQL = "SELECT id, Filial FROM SPR_FILIAL where Arhiv=0 ORDER BY Filial"


        rs = New Recordset
        rs.Open(sSQL, DB7, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic)

        With rs
            .MoveFirst()
            Do While Not .EOF
                'My.Application.DoEvents()
                BrancheNode = New TreeNode(.Fields("filial").Value, 0, 0)
                BrancheNode.Tag = "G|" & .Fields("id").Value
                BrancheNode.Name = .Fields("filial").Value
                BrancheNode.Text = .Fields("filial").Value
                sTEN = "G|" & .Fields("id").Value
                nodeRoot.Nodes.Add(BrancheNode)

                FILIAL1 = .Fields("filial").Value
                OTDEL1 = ""
                KABINET1 = ""
                BrancheNode1 = BrancheNode
                lstgroups1 = lstgroups

                If KCKey = 0 And Len(DCKey) <> 0 Then

                    Select Case DCKey

                        Case sTEN

                            lstgroups.SelectedNode = BrancheNode
                            lstgroups.SelectedNode.Expand()

                    End Select

                End If

                BrancheNode.ForeColor = Color.DarkBlue


                .MoveNext()
            Loop
        End With
        rs.Close()
        rs = Nothing

        If KCKey = 0 And Len(DCKey) = 0 Then

            lstgroups.SelectedNode = nodeRoot
            Dim tNode As New TreeNode
            tNode = lstgroups.Nodes(1)
            tNode.Expand()

        End If


        lstgroups.EndUpdate()


    End Sub

    Private Sub FILING_FILIAL()
        On Error GoTo err_
        frmComputers.Cursor = Cursors.WaitCursor

        If Len(FILIAL1) = 0 Then Exit Sub

        Dim sSQL, unameS2 As String

        Dim objIniFile As New IniFile(PrPath & "base.ini")

        Dim sText As String = objIniFile.GetString("general", "Tree_S", 0)

        sSQL = "SELECT  count(*) as tn FROM kompy WHERE filial ='" & FILIAL1 & "' AND mesto ='" & OTDEL1 & "' AND kabn ='" & KABINET1 & "'  AND PCL =0"

        Dim rs3 As Recordset
        rs3 = New Recordset
        rs3.Open(sSQL, DB7, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic)

        With rs3
            unameS2 = .Fields("tn").Value
        End With

        rs3.Close()
        rs3 = Nothing
        If unameS2 = 0 Then Exit Sub

        Select Case sText

            Case 0

                ' sSQL4 =
                '    "SELECT id, mesto, filial, tip_compa, tiptehn, PSEVDONIM, NET_NAME, kabn, Spisan, OS, PRINTER_NAME_4,balans FROM kompy WHERE filial ='" &
                '    FILIAL1 & "' AND mesto ='" & OTDEL1 & "' AND kabn ='" & KABINET1 &
                '    "'  AND PCL =0 ORDER BY PSEVDONIM, tiptehn"
                sSQL = "SELECT id, mesto, filial, tip_compa, tiptehn, PSEVDONIM, NET_NAME, kabn, Spisan, OS, PRINTER_NAME_4,balans, (Select count(*) as t_n FROM Remont Where id_comp=kompy.id and zakryt = 0) as rem FROM kompy WHERE filial ='" & FILIAL1 & "' AND mesto ='" & OTDEL1 & "' AND kabn ='" & KABINET1 & "'  AND PCL =0 ORDER BY PSEVDONIM, tiptehn"
            Case 1

                'sSQL4 =
                '    "SELECT id, mesto, filial, tip_compa, tiptehn, PSEVDONIM, NET_NAME, kabn, Spisan, OS, PRINTER_NAME_4,balans FROM kompy WHERE filial ='" &
                '    FILIAL1 & "' AND mesto ='" & OTDEL1 & "' AND kabn ='" & KABINET1 &
                '    "' AND PCL =0 ORDER BY tiptehn, PSEVDONIM"
                sSQL = "SELECT id, mesto, filial, tip_compa, tiptehn, PSEVDONIM, NET_NAME, kabn, Spisan, OS, PRINTER_NAME_4,balans, (Select count(*) as t_n FROM Remont Where id_comp=kompy.id and zakryt = 0) as rem FROM kompy WHERE filial ='" & FILIAL1 & "' AND mesto ='" & OTDEL1 & "' AND kabn ='" & KABINET1 & "'  AND PCL =0 ORDER BY tiptehn, PSEVDONIM"

        End Select


        rs3 = New Recordset
        rs3.Open(sSQL, DB7, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic)

        Dim tmpRemont As Integer
        With rs3
            .MoveFirst()

            Do While Not .EOF

                If Not IsDBNull(.Fields("tip_compa").Value) Then iA1 = .Fields("tip_compa").Value
                If Not IsDBNull(.Fields("NET_NAME").Value) Then iA2 = .Fields("NET_NAME").Value
                If Not IsDBNull(.Fields("PSEVDONIM").Value) Then iA3 = .Fields("PSEVDONIM").Value
                If Not IsDBNull(.Fields("Spisan").Value) Then iA4 = .Fields("Spisan").Value
                If Not IsDBNull(.Fields("tiptehn").Value) Then iA5 = .Fields("tiptehn").Value
                If Not IsDBNull(.Fields("OS").Value) Then iA6 = .Fields("OS").Value
                If Not IsDBNull(.Fields("PRINTER_NAME_4").Value) Then iA7 = .Fields("PRINTER_NAME_4").Value
                If Not IsDBNull(.Fields("Balans").Value) Then iA8 = .Fields("Balans").Value
                tmpRemont = .Fields("rem").Value
                iID = .Fields("id").Value

                Call FILING_TREE(lstgroups1, iA5, iA1, iA2, iA3, iID, iA4, BrancheNode1, iA6, iA7, iA8, tmpRemont)

                .MoveNext()
            Loop
        End With
        rs3.Close()
        rs3 = Nothing


        frmComputers.Cursor = Cursors.Default

        Exit Sub
err_:
        MsgBox(Err.Description)
        frmComputers.Cursor = Cursors.Default

    End Sub

    Public Sub FILING_TREE(ByVal lstgroups As TreeView, ByVal iTipTehn As String, ByVal TipPC As String,
                           ByVal NET_NAME As String, ByVal PSEVDONIM As String, ByVal iD As String,
                           ByVal Spisan As String, ByVal DepNode As TreeNode, ByVal OS As String, ByVal n_set As String,
                           ByVal balans As String, ByVal REMONT As Integer)

        Dim iC As String
        Dim iA As String
        Dim iB As String
        Dim sTREENAME As String
        Dim N_NAME As String
        Dim P_NAME As String
        Dim L_NAME As String
        Dim iPSid As Long

        Dim uNameS As String

        Dim objIniFile As New IniFile(PrPath & "base.ini")
        KCKey = objIniFile.GetString("general", "DK", 0)
        DCKey = objIniFile.GetString("general", "Default", 0)
        sTREENAME = objIniFile.GetString("general", "NETNAME", "1")

        Select Case iTipTehn

            Case "PC"
                iC = TipPC
            Case Else
                iC = "Рабочая станция"
        End Select

        'Тип техники
        Select Case iC
            Case "Ноутбук"
                iC = "Ноутбук"
            Case "notebook"
                iC = "Ноутбук"
            Case "Notebook"
                iC = "Ноутбук"
            Case "NoteBook"
                iC = "Ноутбук"
            Case "КПК"
                iC = "КПК"
            Case "Pocket PC"
                iC = "КПК"
            Case "Pocket"
                iC = "КПК"
            Case "Palm"
                iC = "КПК"
            Case "Планшет"
                iC = "КПК"
            Case "Сервер"
                iC = "Сервер"
            Case "Server"
                iC = "Сервер"
            Case "Сервер для тонких клиентов"
                iC = "Сервер"
            Case "Сервер видео наблюдения"
                iC = "Сервер"
        End Select

        'Иконки
        Select Case iC
            Case "Рабочая станция"
                iA = 4
                iB = 4
            Case "Сервер"
                iA = 3
                iB = 3
            Case "КПК"
                iA = 31
                iB = 31
            Case "Ноутбук"
                iA = 5
                iB = 5
            Case Else
                iA = 4
                iB = 4
        End Select

        'Определяем подчиненное оборудование (в составе)
        Dim d() As String

        If iTipTehn = "MONITOR" Then

            If Len(OS) > 0 Then
                d = Split(OS, "№")
            End If

        End If

        'Dim TEHNodePS As TreeNode

        Select Case sTREENAME

            Case 0
                N_NAME = NET_NAME
                P_NAME = PSEVDONIM

                Select Case Len(N_NAME)
                    Case 0
                        N_NAME = "NoName"
                End Select

                Select Case Len(P_NAME)
                    Case 0
                        P_NAME = "NoName"
                End Select

                Select Case N_NAME

                    Case P_NAME

                        L_NAME = N_NAME

                    Case Else

                        L_NAME = N_NAME & " (" & P_NAME & ")"

                End Select

            Case 2
                P_NAME = PSEVDONIM

                Select Case Len(P_NAME)
                    Case 0
                        P_NAME = "NoName"
                End Select
                L_NAME = P_NAME

            Case 1

                N_NAME = NET_NAME
                Select Case Len(N_NAME)
                    Case 0
                        N_NAME = "NoName"
                End Select

                L_NAME = N_NAME

        End Select

        Select Case iTipTehn

            Case "CNT"

                Dim uname As String

                On Error Resume Next

                Select Case Len(NET_NAME)
                    Case 0
                        uname = ""
                    Case Else
                        Dim rsOT As Recordset
                        rsOT = New Recordset
                        rsOT.Open("SELECT A FROM spr_other where Name ='" & NET_NAME & "'", DB7,
                                  CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic)
                        With rsOT
                            If Not IsDBNull(.Fields("A").Value) Then uname = .Fields("A").Value
                        End With
                        rsOT.Close()
                        rsOT = Nothing
                End Select

                Dim TEHNodeCNT As New TreeNode(L_NAME, uname, uname)
                TEHNodeCNT.Tag = "C|" & iD
                TEHNodeCNT.Text = L_NAME
                TEHNodeCNT.Name = L_NAME

                DepNode.Nodes.Add(TEHNodeCNT)

                Call checkOther(lstgroups, iD, TEHNodeCNT, Spisan, balans)
                Call checkRemont(iD, TEHNodeCNT, REMONT)

                '#####################################################################
                '#####################################################################
                '#                          КОНТЕЙНЕР
                '#####################################################################
                '#####################################################################

                Dim sText As String = objIniFile.GetString("general", "Tree_S", 0)
                Dim sSQL4 As String

                sSQL4 = "SELECT count(*) as t_n FROM kompy WHERE PCL =" & iD

                Dim rs3 As Recordset
                rs3 = New Recordset
                rs3.Open(sSQL4, DB7, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic)

                Dim sCount As String
                With rs3
                    sCount = .Fields("t_n").Value
                End With

                rs3.Close()
                rs3 = Nothing

                Select Case sCount

                    Case 0

                    Case Else

                        Select Case sText

                            Case 0

                                sSQL4 =
                                    "SELECT id, tiptehn, PSEVDONIM, NET_NAME, Spisan, tip_compa,PRINTER_NAME_4,balans, (Select count(*) as t_n FROM Remont Where id_comp=kompy.id and zakryt = 0) as rem FROM kompy WHERE PCL =" &
                                    iD & " ORDER BY PSEVDONIM, tiptehn"

                            Case 1

                                sSQL4 =
                                    "SELECT id, tiptehn, PSEVDONIM, NET_NAME, Spisan, tip_compa,PRINTER_NAME_4,balans, (Select count(*) as t_n FROM Remont Where id_comp=kompy.id and zakryt = 0) as rem FROM kompy WHERE PCL =" &
                                    iD & " ORDER BY tiptehn, PSEVDONIM"

                        End Select

                        rs3 = New Recordset
                        rs3.Open(sSQL4, DB7, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic)

                        With rs3
                            .MoveFirst()

                            Do While Not .EOF
                                Spisan = .Fields("Spisan").Value
                                balans = .Fields("balans").Value

                                Select Case sTREENAME

                                    Case 0
                                        N_NAME = .Fields("NET_NAME").Value
                                        P_NAME = .Fields("PSEVDONIM").Value

                                        Select Case Len(N_NAME)
                                            Case 0
                                                N_NAME = "NoName"
                                        End Select

                                        Select Case Len(P_NAME)
                                            Case 0
                                                P_NAME = "NoName"
                                        End Select

                                        Select Case N_NAME

                                            Case P_NAME

                                                L_NAME = N_NAME
                                            Case Else

                                                L_NAME = N_NAME & " (" & P_NAME & ")"

                                        End Select

                                    Case 2
                                        P_NAME = .Fields("PSEVDONIM").Value

                                        Select Case Len(P_NAME)
                                            Case 0
                                                P_NAME = "NoName"
                                        End Select

                                        L_NAME = P_NAME

                                    Case 1

                                        N_NAME = .Fields("NET_NAME").Value
                                        Select Case Len(N_NAME)
                                            Case 0
                                                N_NAME = "NoName"
                                        End Select

                                        L_NAME = N_NAME

                                End Select

                                Select Case .Fields("tiptehn").Value

                                    Case "NET"

                                        Dim TEHNodePC As New TreeNode(L_NAME, 10, 10)
                                        TEHNodePC.Tag = "C|" & .Fields("id").Value
                                        TEHNodePC.Text = L_NAME
                                        TEHNodePC.Name = L_NAME
                                        TEHNodeCNT.Nodes.Add(TEHNodePC)
                                        iD = .Fields("id").Value

                                        Select Case n_set

                                            Case "Off"
                                                TEHNodePC.ForeColor = Color.Red

                                            Case "Defective"

                                                TEHNodePC.ForeColor = Color.Blue

                                            Case Else

                                                TEHNodePC.ForeColor = Color.Green

                                        End Select

                                        Call checkOther(lstgroups, .Fields("id").Value, TEHNodePC, Spisan, balans)
                                        Call checkRemont(.Fields("id").Value, TEHNodePC, .Fields("rem").Value)

                                    Case "PC"

                                        iC = .Fields("TIP_COMPA").Value

                                        Select Case iC
                                            Case "Ноутбук"
                                                iC = "Ноутбук"
                                            Case "notebook"
                                                iC = "Ноутбук"
                                            Case "Notebook"
                                                iC = "Ноутбук"
                                            Case "NoteBook"
                                                iC = "Ноутбук"
                                            Case "КПК"
                                                iC = "КПК"
                                            Case "Pocket PC"
                                                iC = "КПК"
                                            Case "Pocket"
                                                iC = "КПК"
                                            Case "Palm"
                                                iC = "КПК"
                                            Case "Планшет"
                                                iC = "КПК"
                                            Case "Сервер"
                                                iC = "Сервер"
                                            Case "Server"
                                                iC = "Сервер"
                                            Case "Сервер для тонких клиентов"
                                                iC = "Сервер"
                                            Case "Сервер видео наблюдения"
                                                iC = "Сервер"
                                        End Select

                                        Select Case iC

                                            Case "Рабочая станция"
                                                iA = 4
                                            Case "Сервер"
                                                iA = 3
                                            Case "КПК"
                                                iA = 31
                                            Case "Ноутбук"
                                                iA = 5
                                            Case Else
                                                iA = 4
                                        End Select

                                        Dim TEHNodePC As New TreeNode(L_NAME, iA, iA)
                                        iD = .Fields("id").Value
                                        TEHNodePC.Tag = "C|" & .Fields("id").Value
                                        TEHNodePC.Text = L_NAME
                                        TEHNodePC.Name = L_NAME
                                        iPSid = .Fields("id").Value

                                        TEHNodeCNT.Nodes.Add(TEHNodePC)

                                        Call checkOther(lstgroups, .Fields("id").Value, TEHNodePC, Spisan, balans)
                                        Call checkRemont(.Fields("id").Value, TEHNodePC, .Fields("rem").Value)

                                        '#####################################################################
                                        '#####################################################################
                                        '#                          Компьютер в контейнере
                                        '#####################################################################
                                        '#####################################################################

                                        sSQL4 = "SELECT count(*) as t_n FROM kompy WHERE PCL =" & iD

                                        rs3 = New Recordset
                                        rs3.Open(sSQL4, DB7, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic)

                                        With rs3
                                            sCount = .Fields("t_n").Value
                                        End With

                                        rs3.Close()
                                        rs3 = Nothing

                                        Select Case sCount

                                            Case 0

                                            Case Else

                                                Select Case sText

                                                    Case 0

                                                        sSQL4 =
                                                            "SELECT id, tiptehn, PSEVDONIM, NET_NAME, Spisan, tip_compa,balans, (Select count(*) as t_n FROM Remont Where id_comp=kompy.id and zakryt = 0) as rem FROM kompy WHERE PCL =" &
                                                            iD & " ORDER BY PSEVDONIM, tiptehn"

                                                    Case 1

                                                        sSQL4 =
                                                            "SELECT id, tiptehn, PSEVDONIM, NET_NAME, Spisan, tip_compa,balans, (Select count(*) as t_n FROM Remont Where id_comp=kompy.id and zakryt = 0) as rem FROM kompy WHERE PCL =" &
                                                            iD & " ORDER BY tiptehn, PSEVDONIM"

                                                End Select

                                                rs3 = New Recordset
                                                rs3.Open(sSQL4, DB7, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic)

                                                With rs3
                                                    .MoveFirst()

                                                    Do While Not .EOF

                                                        Spisan = .Fields("Spisan").Value
                                                        balans = .Fields("balans").Value

                                                        Select Case sTREENAME

                                                            Case 0
                                                                N_NAME = .Fields("NET_NAME").Value
                                                                P_NAME = .Fields("PSEVDONIM").Value

                                                                Select Case Len(N_NAME)
                                                                    Case 0
                                                                        N_NAME = "NoName"
                                                                End Select

                                                                Select Case Len(P_NAME)
                                                                    Case 0
                                                                        P_NAME = "NoName"
                                                                End Select

                                                                Select Case N_NAME

                                                                    Case P_NAME

                                                                        L_NAME = N_NAME

                                                                    Case Else

                                                                        L_NAME = N_NAME & " (" & P_NAME & ")"

                                                                End Select

                                                            Case 2
                                                                P_NAME = .Fields("PSEVDONIM").Value

                                                                Select Case Len(P_NAME)
                                                                    Case 0
                                                                        P_NAME = "NoName"
                                                                End Select
                                                                L_NAME = P_NAME

                                                            Case 1

                                                                N_NAME = .Fields("NET_NAME").Value
                                                                Select Case Len(N_NAME)
                                                                    Case 0
                                                                        N_NAME = "NoName"
                                                                End Select

                                                                L_NAME = N_NAME

                                                        End Select

                                                        stmREMONT = .Fields("rem").Value

                                                        Select Case .Fields("tiptehn").Value

                                                            Case "Printer"

                                                                Filling_TREE_DATA_2(lstgroups, .Fields("id").Value, TEHNodePC,
                                                                                  Spisan, balans, L_NAME, 7)

                                                            Case "MFU"

                                                                Filling_TREE_DATA_2(lstgroups, .Fields("id").Value, TEHNodePC,
                                                                                  Spisan, balans, L_NAME, 8)

                                                            Case "SCANER"

                                                                Filling_TREE_DATA_2(lstgroups, .Fields("id").Value, TEHNodePC,
                                                                                  Spisan, balans, L_NAME, 14)

                                                            Case "ZIP"

                                                                Filling_TREE_DATA_2(lstgroups, .Fields("id").Value, TEHNodePC,
                                                                                  Spisan, balans, L_NAME, 15)

                                                            Case "PHONE"

                                                                Filling_TREE_DATA_2(lstgroups, .Fields("id").Value, TEHNodePC,
                                                                                  Spisan, balans, L_NAME, 12)

                                                            Case "OT"

                                                                On Error Resume Next

                                                                Select Case Len(.Fields("tip_compa").Value)
                                                                    Case 0
                                                                        uname = ""
                                                                    Case Else
                                                                        Dim rsOT As Recordset
                                                                        rsOT = New Recordset
                                                                        rsOT.Open(
                                                                            "SELECT A FROM spr_other where Name ='" &
                                                                            .Fields("tip_compa").Value & "'", DB7,
                                                                            CursorTypeEnum.adOpenDynamic,
                                                                            LockTypeEnum.adLockOptimistic)

                                                                        uname = ""
                                                                        With rsOT

                                                                            If Not IsDBNull(.Fields("A").Value) Then _
                                                                                uname = .Fields("A").Value

                                                                        End With

                                                                        rsOT.Close()
                                                                        rsOT = Nothing
                                                                End Select

                                                                Select Case uname

                                                                    Case ""

                                                                        iA = 16

                                                                    Case Else

                                                                        iA = uname

                                                                End Select

                                                                Filling_TREE_DATA_2(lstgroups, .Fields("id").Value, TEHNodePC,
                                                                                  Spisan, balans, L_NAME, iA)

                                                            Case "MONITOR"

                                                                Filling_TREE_DATA_2(lstgroups, .Fields("id").Value, TEHNodePC,
                                                                                  Spisan, balans, L_NAME, 17)

                                                                '--------------VIP_Graff Добавление новой перефирии Начало-----------------
                                                            Case "USB"

                                                                Filling_TREE_DATA_2(lstgroups, .Fields("id").Value, TEHNodePC,
                                                                                  Spisan, balans, L_NAME, 18)

                                                            Case "SOUND"

                                                                Filling_TREE_DATA_2(lstgroups, .Fields("id").Value, TEHNodePC,
                                                                                  Spisan, balans, L_NAME, 44)

                                                            Case "IBP"

                                                                Filling_TREE_DATA_2(lstgroups, .Fields("id").Value, TEHNodePC,
                                                                                  Spisan, balans, L_NAME, 41)

                                                            Case "FS"

                                                                Filling_TREE_DATA_2(lstgroups, .Fields("id").Value, TEHNodePC,
                                                                                  Spisan, balans, L_NAME, 61)

                                                            Case "KEYB"

                                                                Filling_TREE_DATA_2(lstgroups, .Fields("id").Value, TEHNodePC,
                                                                                  Spisan, balans, L_NAME, 46)

                                                            Case "MOUSE"

                                                                Filling_TREE_DATA_2(lstgroups, .Fields("id").Value, TEHNodePC,
                                                                                  Spisan, balans, L_NAME, 47)

                                                                '--------------VIP_Graff Добавление новой перефирии Конец------------------

                                                            Case Else

                                                        End Select

                                                        .MoveNext()
                                                    Loop
                                                End With
                                                rs3.Close()
                                                rs3 = Nothing

                                        End Select

                                        '#####################################################################
                                        '#####################################################################
                                        '#                          Техника в контейнере
                                        '#####################################################################
                                        '#####################################################################

                                        stmREMONT = .Fields("rem").Value

                                    Case "PHOTO"

                                        Filling_TREE_DATA_2(lstgroups, .Fields("id").Value, TEHNodeCNT, Spisan, balans, L_NAME, 11)


                                    Case "Printer"

                                        Filling_TREE_DATA_2(lstgroups, .Fields("id").Value, TEHNodeCNT, Spisan, balans, L_NAME,
                                                          7)


                                    Case "MFU"

                                        Filling_TREE_DATA_2(lstgroups, .Fields("id").Value, TEHNodeCNT, Spisan, balans, L_NAME,
                                                          8)


                                    Case "SCANER"

                                        Filling_TREE_DATA_2(lstgroups, .Fields("id").Value, TEHNodeCNT, Spisan, balans, L_NAME,
                                                          14)


                                    Case "ZIP"

                                        Filling_TREE_DATA_2(lstgroups, .Fields("id").Value, TEHNodeCNT, Spisan, balans, L_NAME,
                                                          15)

                                    Case "PHONE"

                                        Filling_TREE_DATA_2(lstgroups, .Fields("id").Value, TEHNodeCNT, Spisan, balans, L_NAME,
                                                          12)

                                    Case "OT"

                                        On Error Resume Next

                                        Select Case Len(.Fields("tip_compa").Value)

                                            Case 0
                                                uname = ""
                                            Case Else

                                                Dim rsOT As Recordset
                                                rsOT = New Recordset
                                                rsOT.Open(
                                                    "SELECT A FROM spr_other where Name ='" & .Fields("tip_compa").Value & "'",
                                                    DB7, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic)

                                                uname = ""

                                                With rsOT

                                                    If Not IsDBNull(.Fields("A").Value) Then uname = .Fields("A").Value

                                                End With

                                                rsOT.Close()
                                                rsOT = Nothing

                                        End Select

                                        Select Case uname

                                            Case ""

                                                iA = 16

                                            Case Else

                                                iA = uname

                                        End Select

                                        Filling_TREE_DATA_2(lstgroups, .Fields("id").Value, TEHNodeCNT, Spisan, balans, L_NAME,
                                                          iA)

                                    Case "MONITOR"

                                        Filling_TREE_DATA_2(lstgroups, .Fields("id").Value, TEHNodeCNT, Spisan, balans, L_NAME,
                                                          17)

                                        '--------------VIP_Graff Добавление новой перефирии Начало-----------------
                                    Case "USB"

                                        Filling_TREE_DATA_2(lstgroups, .Fields("id").Value, TEHNodeCNT, Spisan, balans, L_NAME,
                                                          18)

                                    Case "SOUND"

                                        Filling_TREE_DATA_2(lstgroups, .Fields("id").Value, TEHNodeCNT, Spisan, balans, L_NAME,
                                                          44)

                                    Case "IBP"

                                        Filling_TREE_DATA_2(lstgroups, .Fields("id").Value, TEHNodeCNT, Spisan, balans, L_NAME,
                                                          41)

                                    Case "FS"

                                        Filling_TREE_DATA_2(lstgroups, .Fields("id").Value, TEHNodeCNT, Spisan, balans, L_NAME,
                                                          61)

                                    Case "KEYB"

                                        Filling_TREE_DATA_2(lstgroups, .Fields("id").Value, TEHNodeCNT, Spisan, balans, L_NAME,
                                                          46)

                                    Case "MOUSE"

                                        Filling_TREE_DATA_2(lstgroups, .Fields("id").Value, TEHNodeCNT, Spisan, balans, L_NAME,
                                                          47)

                                        '--------------VIP_Graff Добавление новой перефирии Конец------------------
                                    Case Else

                                End Select

                                .MoveNext()
                            Loop
                        End With
                        rs3.Close()
                        rs3 = Nothing

                End Select

                '#####################################################################
                '#####################################################################
                '#                          Компьютер
                '#####################################################################
                '#####################################################################

            Case "PC"
                stmREMONT = REMONT

                Dim TEHNodePC As New TreeNode(L_NAME, iA, iB)

                TEHNodePC.Tag = "C|" & iD
                TEHNodePC.Text = L_NAME
                TEHNodePC.Name = L_NAME

                iPSid = iD

                DepNode.Nodes.Add(TEHNodePC)

                Call checkOther(lstgroups, iD, TEHNodePC, Spisan, balans)
                Call checkRemont(iD, TEHNodePC, REMONT)

                '########################################################################
                '########################################################################
                '########################################################################

                Dim sText As String = objIniFile.GetString("general", "Tree_S", 0)
                Dim sSQL4 As String

                sSQL4 = "SELECT count(*) as t_n FROM kompy WHERE PCL =" & iD

                Dim rs3 As Recordset
                rs3 = New Recordset
                rs3.Open(sSQL4, DB7, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic)

                Dim sCount As String
                With rs3
                    sCount = .Fields("t_n").Value
                End With

                rs3.Close()
                rs3 = Nothing

                Select Case sCount

                    Case 0

                    Case Else

                        Select Case sText

                            Case 0

                                sSQL4 =
                                    "SELECT id, tiptehn, PSEVDONIM, NET_NAME, Spisan, tip_compa,PRINTER_NAME_4,balans, (Select count(*) as t_n FROM Remont Where id_comp=kompy.id and zakryt = 0) as rem FROM kompy WHERE PCL =" &
                                    iD & " ORDER BY PSEVDONIM, tiptehn"

                            Case 1

                                sSQL4 =
                                    "SELECT id, tiptehn, PSEVDONIM, NET_NAME, Spisan, tip_compa,PRINTER_NAME_4,balans, (Select count(*) as t_n FROM Remont Where id_comp=kompy.id and zakryt = 0) as rem FROM kompy WHERE PCL =" &
                                    iD & " ORDER BY tiptehn, PSEVDONIM"

                        End Select

                        rs3 = New Recordset
                        rs3.Open(sSQL4, DB7, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic)

                        With rs3
                            .MoveFirst()

                            Do While Not .EOF

                                Spisan = .Fields("Spisan").Value
                                balans = .Fields("balans").Value

                                Select Case sTREENAME

                                    Case 0
                                        N_NAME = .Fields("NET_NAME").Value
                                        P_NAME = .Fields("PSEVDONIM").Value

                                        Select Case Len(N_NAME)
                                            Case 0
                                                N_NAME = "NoName"
                                        End Select

                                        Select Case Len(P_NAME)
                                            Case 0
                                                P_NAME = "NoName"
                                        End Select

                                        Select Case N_NAME

                                            Case P_NAME

                                                L_NAME = N_NAME
                                            Case Else

                                                L_NAME = N_NAME & " (" & P_NAME & ")"

                                        End Select

                                    Case 2
                                        P_NAME = .Fields("PSEVDONIM").Value

                                        Select Case Len(P_NAME)
                                            Case 0
                                                P_NAME = "NoName"
                                        End Select

                                        L_NAME = P_NAME

                                    Case 1

                                        N_NAME = .Fields("NET_NAME").Value

                                        Select Case Len(N_NAME)
                                            Case 0
                                                N_NAME = "NoName"
                                        End Select

                                        L_NAME = N_NAME

                                End Select

                                stmREMONT = .Fields("rem").Value

                                Select Case .Fields("tiptehn").Value

                                    Case "Printer"

                                        Filling_TREE_DATA_2(lstgroups, .Fields("id").Value, TEHNodePC, Spisan, balans, L_NAME,
                                                          7)

                                    Case "MFU"


                                        Filling_TREE_DATA_2(lstgroups, .Fields("id").Value, TEHNodePC, Spisan, balans, L_NAME,
                                                          8)


                                    Case "SCANER"

                                        Filling_TREE_DATA_2(lstgroups, .Fields("id").Value, TEHNodePC, Spisan, balans, L_NAME,
                                                          14)

                                    Case "ZIP"

                                        Filling_TREE_DATA_2(lstgroups, .Fields("id").Value, TEHNodePC, Spisan, balans, L_NAME,
                                                          15)

                                    Case "PHONE"

                                        Filling_TREE_DATA_2(lstgroups, .Fields("id").Value, TEHNodePC, Spisan, balans, L_NAME,
                                                          12)


                                    Case "OT"

                                        Dim uname As String

                                        On Error Resume Next

                                        Select Case Len(.Fields("tip_compa").Value)
                                            Case 0
                                                uname = ""
                                            Case Else
                                                Dim rsOT As Recordset
                                                rsOT = New Recordset
                                                rsOT.Open(
                                                    "SELECT A FROM spr_other where Name ='" & .Fields("tip_compa").Value & "'",
                                                    DB7, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic)

                                                uname = ""

                                                With rsOT

                                                    If Not IsDBNull(.Fields("A").Value) Then uname = .Fields("A").Value

                                                End With

                                                rsOT.Close()
                                                rsOT = Nothing
                                        End Select

                                        Select Case uname

                                            Case ""

                                                iA = 16

                                            Case Else

                                                iA = uname

                                        End Select

                                        Filling_TREE_DATA_2(lstgroups, .Fields("id").Value, TEHNodePC, Spisan, balans, L_NAME,
                                                          iA)

                                    Case "MONITOR"

                                        Filling_TREE_DATA_2(lstgroups, .Fields("id").Value, TEHNodePC, Spisan, balans, L_NAME,
                                                          17)

                                        '--------------VIP_Graff Добавление новой перефирии Начало-----------------
                                    Case "USB"

                                        Filling_TREE_DATA_2(lstgroups, .Fields("id").Value, TEHNodePC, Spisan, balans, L_NAME,
                                                          18)

                                    Case "SOUND"

                                        Filling_TREE_DATA_2(lstgroups, .Fields("id").Value, TEHNodePC, Spisan, balans, L_NAME,
                                                          44)

                                    Case "IBP"

                                        Filling_TREE_DATA_2(lstgroups, .Fields("id").Value, TEHNodePC, Spisan, balans, L_NAME,
                                                          41)


                                    Case "FS"

                                        Filling_TREE_DATA_2(lstgroups, .Fields("id").Value, TEHNodePC, Spisan, balans, L_NAME,
                                                          61)

                                    Case "KEYB"

                                        Filling_TREE_DATA_2(lstgroups, .Fields("id").Value, TEHNodePC, Spisan, balans, L_NAME,
                                                          46)

                                    Case "MOUSE"

                                        Filling_TREE_DATA_2(lstgroups, .Fields("id").Value, TEHNodePC, Spisan, balans, L_NAME,
                                                          47)

                                        '--------------VIP_Graff Добавление новой перефирии Конец------------------

                                    Case Else

                                End Select

                                .MoveNext()
                            Loop
                        End With
                        rs3.Close()
                        rs3 = Nothing

                End Select

            Case "Printer"
                stmREMONT = REMONT
                Filling_TREE_DATA_2(lstgroups, iD, DepNode, Spisan, balans, L_NAME, 7)

            Case "MFU"
                stmREMONT = REMONT
                Filling_TREE_DATA_2(lstgroups, iD, DepNode, Spisan, balans, L_NAME, 8)

            Case "KOpir"
                stmREMONT = REMONT
                Filling_TREE_DATA_2(lstgroups, iD, DepNode, Spisan, balans, L_NAME, 9)

            Case "NET"
                stmREMONT = REMONT
                Dim TEHNode As New TreeNode(L_NAME, 10, 10)
                TEHNode.Tag = "C|" & iD
                TEHNode.Text = L_NAME
                TEHNode.Name = L_NAME
                DepNode.Nodes.Add(TEHNode)

                Select Case n_set

                    Case "Off"
                        TEHNode.ForeColor = Color.Red

                    Case "Defective"

                        TEHNode.ForeColor = Color.Blue

                    Case Else

                        TEHNode.ForeColor = Color.Green

                End Select

                Call checkOther(lstgroups, iD, TEHNode, Spisan, balans)
                Call checkRemont(iD, TEHNode, REMONT)


            Case "PHOTO"
                stmREMONT = REMONT
                iA = 11
                iB = 11

                Dim TEHNodePHOTO As New TreeNode(L_NAME, iA, iB)

                TEHNodePHOTO.Tag = "C|" & iD
                TEHNodePHOTO.Text = L_NAME
                TEHNodePHOTO.Name = L_NAME
                iPSid = iD

                DepNode.Nodes.Add(TEHNodePHOTO)

                Call checkOther(lstgroups, iD, TEHNodePHOTO, Spisan, balans)
                Call checkRemont(iD, TEHNodePHOTO, REMONT)


                Dim sText As String = objIniFile.GetString("general", "Tree_S", 0)
                Dim sSQL4 As String

                Dim rs3 As Recordset
                rs3 = New Recordset
                rs3.Open("SELECT count(*) as t_n FROM kompy WHERE PCL =" & iD, DB7, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic)

                Dim sCount As String

                sCount = rs3.Fields("t_n").Value

                rs3.Close()
                rs3 = Nothing

                Select Case sCount

                    Case 0

                    Case Else

                        Select Case sText

                            Case 0

                                sSQL4 =
                                    "SELECT id, tiptehn, PSEVDONIM, NET_NAME, Spisan, tip_compa,PRINTER_NAME_4,balans, (Select count(*) as t_n FROM Remont Where id_comp=kompy.id and zakryt = 0) as rem FROM kompy WHERE PCL =" &
                                    iD & " ORDER BY PSEVDONIM, tiptehn"

                            Case 1

                                sSQL4 =
                                    "SELECT id, tiptehn, PSEVDONIM, NET_NAME, Spisan, tip_compa,PRINTER_NAME_4,balans, (Select count(*) as t_n FROM Remont Where id_comp=kompy.id and zakryt = 0) as rem FROM kompy WHERE PCL =" &
                                    iD & " ORDER BY tiptehn, PSEVDONIM"

                        End Select

                        rs3 = New Recordset
                        rs3.Open(sSQL4, DB7, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic)

                        With rs3
                            .MoveFirst()

                            Do While Not .EOF

                                Spisan = .Fields("Spisan").Value
                                balans = .Fields("balans").Value
                                stmREMONT = .Fields("rem").Value

                                Select Case sTREENAME

                                    Case 0
                                        N_NAME = .Fields("NET_NAME").Value
                                        P_NAME = .Fields("PSEVDONIM").Value

                                        Select Case Len(N_NAME)
                                            Case 0
                                                N_NAME = "NoName"
                                        End Select

                                        Select Case Len(P_NAME)
                                            Case 0
                                                P_NAME = "NoName"
                                        End Select

                                        Select Case N_NAME

                                            Case P_NAME

                                                L_NAME = N_NAME
                                            Case Else

                                                L_NAME = N_NAME & " (" & P_NAME & ")"

                                        End Select

                                    Case 2
                                        P_NAME = .Fields("PSEVDONIM").Value

                                        Select Case Len(P_NAME)
                                            Case 0
                                                P_NAME = "NoName"
                                        End Select

                                        L_NAME = P_NAME

                                    Case 1

                                        N_NAME = .Fields("NET_NAME").Value
                                        Select Case Len(N_NAME)
                                            Case 0
                                                N_NAME = "NoName"
                                        End Select

                                        L_NAME = N_NAME

                                End Select

                                Select Case .Fields("tiptehn").Value

                                    Case "OT"

                                        Dim uname As String

                                        On Error Resume Next

                                        Select Case Len(.Fields("tip_compa").Value)

                                            Case 0
                                                uname = ""
                                            Case Else

                                                Dim rsOT As Recordset
                                                rsOT = New Recordset
                                                rsOT.Open(
                                                    "SELECT A FROM spr_other where Name ='" & .Fields("tip_compa").Value & "'",
                                                    DB7, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic)

                                                uname = ""
                                                With rsOT

                                                    If Not IsDBNull(.Fields("A").Value) Then uname = .Fields("A").Value

                                                End With

                                                rsOT.Close()
                                                rsOT = Nothing

                                        End Select

                                        Select Case uname

                                            Case ""

                                                iA = 16

                                            Case Else

                                                iA = uname

                                        End Select

                                        Filling_TREE_DATA_2(lstgroups, .Fields("id").Value, TEHNodePHOTO, Spisan, balans, L_NAME,
                                                          iA)

                                    Case "USB"

                                        Filling_TREE_DATA_2(lstgroups, .Fields("id").Value, TEHNodePHOTO, Spisan, balans, L_NAME,
                                                          18)

                                    Case Else

                                End Select

                                .MoveNext()
                            Loop
                        End With
                        rs3.Close()
                        rs3 = Nothing

                End Select

            Case "PHONE"
                stmREMONT = REMONT
                Filling_TREE_DATA_2(lstgroups, iD, DepNode, Spisan, balans, L_NAME, 12)

            Case "FAX"
                stmREMONT = REMONT
                Filling_TREE_DATA_2(lstgroups, iD, DepNode, Spisan, balans, L_NAME, 13)

            Case "SCANER"
                stmREMONT = REMONT
                Filling_TREE_DATA_2(lstgroups, iD, DepNode, Spisan, balans, L_NAME, 14)

            Case "ZIP"
                stmREMONT = REMONT
                Filling_TREE_DATA_2(lstgroups, iD, DepNode, Spisan, balans, L_NAME, 15)

            Case "OT"
                stmREMONT = REMONT
                Dim uname As String

                On Error Resume Next

                Select Case Len(TipPC)

                    Case 0
                        uname = ""

                    Case Else

                        Dim rsOT As Recordset
                        rsOT = New Recordset
                        rsOT.Open("SELECT A FROM spr_other where Name ='" & TipPC & "'", DB7, CursorTypeEnum.adOpenDynamic,
                                  LockTypeEnum.adLockOptimistic)

                        uname = ""

                        With rsOT

                            If Not IsDBNull(.Fields("A").Value) Then uname = .Fields("A").Value

                        End With

                        rsOT.Close()
                        rsOT = Nothing

                End Select

                Select Case uname

                    Case ""

                        iA = 16

                    Case Else

                        iA = uname

                End Select

                Filling_TREE_DATA_2(lstgroups, iD, DepNode, Spisan, balans, L_NAME, iA)

            Case "MONITOR"
                stmREMONT = REMONT
                Filling_TREE_DATA_2(lstgroups, iD, DepNode, Spisan, balans, L_NAME, 17)

                '--------------VIP_Graff Добавление новой перефирии Начало-----------------
            Case "USB"
                stmREMONT = REMONT
                Filling_TREE_DATA_2(lstgroups, iD, DepNode, Spisan, balans, L_NAME, 18)

            Case "SOUND"
                stmREMONT = REMONT
                Filling_TREE_DATA_2(lstgroups, iD, DepNode, Spisan, balans, L_NAME, 44)

            Case "IBP"
                stmREMONT = REMONT
                Filling_TREE_DATA_2(lstgroups, iD, DepNode, Spisan, balans, L_NAME, 41)

            Case "FS"
                stmREMONT = REMONT
                Filling_TREE_DATA_2(lstgroups, iD, DepNode, Spisan, balans, L_NAME, 61)

            Case "KEYB"
                stmREMONT = REMONT
                Filling_TREE_DATA_2(lstgroups, iD, DepNode, Spisan, balans, L_NAME, 46)

            Case "MOUSE"
                stmREMONT = REMONT
                Filling_TREE_DATA_2(lstgroups, iD, DepNode, Spisan, balans, L_NAME, 47)

                '--------------VIP_Graff Добавление новой перефирии Конец------------------

            Case Else

        End Select
    End Sub

    Public Sub Filling_TREE_DATA_2(ByVal lstgroups As TreeView, ByVal sID As Integer, ByVal TEHNodePCL As TreeNode,
                                ByVal Spisan As String, ByVal balans As String, ByVal L_NAME As String,
                                ByVal sNUM As Decimal)

        On Error Resume Next

        Dim TEHNodeCNT As New TreeNode(L_NAME, sNUM, sNUM)
        TEHNodeCNT.Tag = "C|" & sID
        TEHNodeCNT.Text = L_NAME
        TEHNodeCNT.Name = L_NAME
        TEHNodePCL.Nodes.Add(TEHNodeCNT)

        Call checkOther(lstgroups, sID, TEHNodeCNT, Spisan, balans)
        Call checkRemont(sID, TEHNodeCNT, stmREMONT)

    End Sub

    Public Sub checkRemont(ByVal sID As Integer, ByVal TEHNodePCL As TreeNode, ByVal remont As Integer)

        Select Case remVisible

            Case True

                Select Case remont

                    Case 0

                    Case Else
                        TEHNodePCL.ForeColor = Color.FromName(ServiceColor)
                        TEHNodePCL.BackColor = Color.Olive

                End Select

        End Select

    End Sub

    Public Sub checkOther(ByVal lstgroups As TreeView, ByVal sID As Integer, ByVal TEHNodeCNT As TreeNode,
                                 ByVal Spisan As String, ByVal balans As String)

        On Error Resume Next

        Select Case SPVisible

            Case True

                Select Case Spisan

                    Case "1"
                        TEHNodeCNT.ForeColor = Color.FromName(SpisanColor)
                        TEHNodeCNT.NodeFont = New Font(lstgroups.Font, 8)
                    Case "True"
                        TEHNodeCNT.ForeColor = Color.FromName(SpisanColor)
                        TEHNodeCNT.NodeFont = New Font(lstgroups.Font, 8)
                    Case "-1"
                        TEHNodeCNT.ForeColor = Color.FromName(SpisanColor)
                        TEHNodeCNT.NodeFont = New Font(lstgroups.Font, 8)
                End Select

        End Select

        Select Case NBVisible

            Case True

                If balans = "1" Or balans = "True" Or balans = "-1" Then

                    Select Case Spisan

                        Case "1"

                            TEHNodeCNT.NodeFont = New Font(lstgroups.Font, 10)
                        Case "True"

                            TEHNodeCNT.NodeFont = New Font(lstgroups.Font, 10)
                        Case "-1"

                            TEHNodeCNT.NodeFont = New Font(lstgroups.Font, 10)

                        Case Else
                            TEHNodeCNT.ForeColor = Color.FromName(NbColor)
                            TEHNodeCNT.NodeFont = New Font(lstgroups.Font, 2)

                    End Select

                End If

        End Select

        Select Case KCKey
            Case sID
                lstgroups.SelectedNode = TEHNodeCNT
                lstgroups.SelectedNode.Expand()
        End Select




    End Sub

    Public Sub FILING_FILIAL2(ByVal unameS As String, ByVal nodeToAddTo As TreeNode, ByVal lstgroups As TreeView)
        Dim sTEN As String
        Dim sVISIBLE As String
        Dim sSQL1 As String
        Dim sSQL2 As String
        Dim sSQL4 As String
        Dim sSQL5 As String

        Dim iA1, iA2, iA3, iA4, iA5, iA6 As String

        Dim objIniFile As New IniFile(PrPath & "base.ini")
        sVISIBLE = objIniFile.GetString("general", "VisibleALL", "")
        KCKey = objIniFile.GetString("general", "DK", 0)
        DCKey = objIniFile.GetString("general", "Default", 0)
        Dim rs2 As Recordset
        Dim rs3 As Recordset
        Dim rs4 As Recordset

        Dim unameS2, unameS3, unamS2 As String


        'Вставляем технику если есть
        Dim cFil As String
        sSQL1 = "SELECT count(*) as t_n FROM kompy WHERE filial ='" & FILIAL1 & "' AND mesto =''"
        Dim rs1 As Recordset
        rs1 = New Recordset
        rs1.Open(sSQL1, DB7, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic)
        With rs1
            cFil = .Fields("t_n").Value
        End With
        rs1.Close()
        rs1 = Nothing

        Select Case cFil
            Case 0
            Case Else

                '  BrancheNode1 = FILIAL1

                Call FILING_FILIAL()
        End Select


        sSQL2 = "SELECT count(*) as tn FROM SPR_OTD_FILIAL WHERE filial='" & FILIAL1 & "'"

        rs2 = New Recordset
        rs2.Open(sSQL2, DB7, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic)


        With rs2
            unameS2 = .Fields("tn").Value
        End With

        rs2.Close()
        rs2 = Nothing

        Select Case unameS2
            Case 0
            Case Else

                Select Case sVISIBLE

                    Case 1
                        sSQL2 = "SELECT id, Filial, N_Otd FROM SPR_OTD_FILIAL WHERE filial='" & FILIAL1 & "' ORDER BY Filial, N_Otd"
                    Case Else
                        sSQL2 = "SELECT id, Filial, N_Otd FROM SPR_OTD_FILIAL where filial='" & FILIAL1 & "' AND Arhiv=0 ORDER BY Filial, N_Otd"

                End Select

                rs2 = New Recordset
                rs2.Open(sSQL2, DB7, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic)


                With rs2
                    .MoveFirst()
                    Do While Not .EOF

                        Select Case .Fields("filial").Value

                            Case unameS

                                Dim DepatrmentNode As New TreeNode(.Fields("N_Otd").Value, 1, 1)
                                DepatrmentNode.Tag = "O|" & .Fields("id").Value
                                DepatrmentNode.Name = .Fields("N_Otd").Value
                                DepatrmentNode.Text = .Fields("N_Otd").Value
                                sTEN = "O|" & .Fields("id").Value
                                nodeToAddTo.Nodes.Add(DepatrmentNode)
                                '    nodeToAddTo()

                                unameS2 = .Fields("N_Otd").Value

                                DepatrmentNode1 = DepatrmentNode
                                BrancheNode1 = DepatrmentNode

                                OTDEL1 = .Fields("N_Otd").Value
                                KABINET1 = ""

                                If KCKey = 0 And Len(DCKey) <> 0 Then

                                    Select Case DCKey

                                        Case sTEN

                                            lstgroups.SelectedNode = DepatrmentNode
                                            lstgroups.SelectedNode.Expand()

                                    End Select

                                End If

                                DepatrmentNode.ForeColor = Color.DarkGreen
                                ' Dim cFil As String

                                sSQL4 = "SELECT count(*) as t_n FROM kompy WHERE filial ='" & unameS & "' AND mesto ='" & unameS2 & "' AND kabn=''"
                                rs4 = New Recordset
                                rs4.Open(sSQL4, DB7, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic)
                                With rs4
                                    cFil = .Fields("t_n").Value
                                End With
                                rs4.Close()
                                rs4 = Nothing

                                Select Case cFil
                                    Case 0
                                    Case Else
                                        Call FILING_FILIAL()
                                End Select

                                'Кабинеты Третий уровень дерева


                                Dim rs As Recordset
                                rs = New Recordset
                                rs.Open("SELECT count(*) as t_nim FROM SPR_KAB WHERE N_F='" & unameS & "' AND N_M ='" & unameS2 & "'", DB7, CursorTypeEnum.adOpenDynamic,
                                        LockTypeEnum.adLockOptimistic)

                                With rs
                                    unamS2 = .Fields("t_nim").Value
                                End With
                                rs.Close()
                                rs = Nothing


                                Select Case unamS2

                                    Case 0

                                    Case Else

                                        Select Case sVISIBLE
                                            Case 1
                                                sSQL5 = "SELECT id, Name, N_F, N_M FROM SPR_KAB WHERE N_F='" & unameS & "' AND N_M ='" & unameS2 & "' ORDER BY N_F, N_M, Name"
                                            Case Else
                                                sSQL5 = "SELECT id, Name, N_F, N_M FROM SPR_KAB where N_F='" & unameS & "' AND N_M ='" & unameS2 & "' AND Arhiv=0 ORDER BY N_F, N_M, Name"
                                        End Select


                                        rs3 = New Recordset
                                        rs3.Open(sSQL5, DB7, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic)

                                        With rs3
                                            .MoveFirst()
                                            Do While Not .EOF

                                                Dim OfficeNode As New TreeNode(.Fields("name").Value, 2, 2)
                                                OfficeNode.Tag = "K|" & .Fields("id").Value
                                                OfficeNode.Name = .Fields("name").Value
                                                OfficeNode.Text = .Fields("name").Value
                                                sTEN = "K|" & .Fields("id").Value
                                                DepatrmentNode.Nodes.Add(OfficeNode)

                                                OfficeNode1 = OfficeNode
                                                BrancheNode1 = OfficeNode
                                                KABINET1 = .Fields("name").Value

                                                unameS3 = .Fields("name").Value

                                                If KCKey = 0 And Len(DCKey) <> 0 Then

                                                    Select Case DCKey

                                                        Case sTEN

                                                            lstgroups.SelectedNode = OfficeNode
                                                            lstgroups.SelectedNode.Expand()

                                                    End Select

                                                End If

                                                OfficeNode.ForeColor = Color.DarkGoldenrod

                                                sSQL4 = "SELECT count(*) as t_n FROM kompy WHERE filial ='" & unameS &
                                                        "' AND mesto ='" & unameS2 & "' AND kabn='" & unameS3 & "'"
                                                rs4 = New Recordset
                                                rs4.Open(sSQL4, DB7, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic)
                                                With rs4
                                                    cFil = .Fields("t_n").Value
                                                End With
                                                rs4.Close()
                                                rs4 = Nothing

                                                Select Case cFil
                                                    Case 0
                                                    Case Else
                                                        Call FILING_FILIAL()
                                                End Select

                                                .MoveNext()
                                            Loop
                                        End With
                                        rs3.Close()
                                        rs3 = Nothing

                                End Select
                                'Конец кабинетов

                        End Select

                        .MoveNext()
                    Loop
                End With
                rs2.Close()
                rs2 = Nothing
        End Select



        Exit Sub
err_:


    End Sub

End Module
