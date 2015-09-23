
Module MOD_REF_TREE
    Private lbl_M_F As String
    Private lbl_M_F1 As String
    Private lbl_M_F2 As String
    Private FILIAL1, OTDEL1, KABINET1 As String
    Private lstgroups1 As TreeView
    Private BrancheNode1 As TreeNode
    Private DepatrmentNode1 As TreeNode
    Private OfficeNode1 As TreeNode
    Private FontStyl As FontStyle
    Private iA1, iA2, iA3, iA4, iA5, iA6, iA7, iA8, iID As String
    Private N_NAME As String = ""
    Private P_NAME As String = ""
    Private L_NAME As String = ""
    Private stmREMONT As Integer = 0
    Private tmpTAGkey As String = ""

    Private Sub FILING_FILIAL()
        On Error GoTo err_

        If Len(FILIAL1) = 0 Then Exit Sub

        Dim sSQL As String

        Dim objIniFile As New IniFile(PrPath & "base.ini")

        Dim sText As String = objIniFile.GetString("general", "Tree_S", 0)

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

        Dim rs3 As Recordset
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

        Exit Sub
err_:


    End Sub

    Public Sub RefFilTree(ByVal lstgroups As TreeView)
        On Error GoTo ERR1

        Dim sTEN As String
        Dim sVISIBLE As String
        Dim sSQL1 As String
        Dim sSQL2 As String
        Dim sSQL3 As String
        Dim sSQL4 As String
        Dim sSQL5 As String

        Dim iA1, iA2, iA3, iA4, iA5, iA6 As String

        Dim objIniFile As New IniFile(PrPath & "base.ini")
        sVISIBLE = objIniFile.GetString("general", "VisibleALL", "")
        KCKey = objIniFile.GetString("general", "DK", 0)
        DCKey = objIniFile.GetString("general", "Default", 0)

        Dim zBranche As String
        zBranche = objIniFile.GetString("general", "branche", "")

        lstgroups.BeginUpdate()

        Dim LNGIniFile As New IniFile(sLANGPATH)

        Select Case zBranche

            Case "0"

                zBranche = "0"

            Case LNGIniFile.GetString("frmComputers", "MSG53", "Все")

                zBranche = "0"

        End Select

        lstgroups.Nodes.Clear()
        lstgroups.HideSelection = False

        Select Case sICONS

            Case "32*32"

                sICONS = sICONS

                frmComputers.ilsCommands.ImageSize = New Size(32, 32)
                Tree_Icons_Feel(frmComputers.ilsCommands, "sCMP", "pic\tree\")
            Case Else

                sICONS = "24*24"
                frmComputers.ilsCommands.ImageSize = New Size(24, 24)
                Tree_Icons_Feel(frmComputers.ilsCommands, "sCMP", "pic\tree\")
        End Select

        lstgroups.ImageList = frmComputers.ilsCommands

        Dim rs As Recordset
        Dim rs2 As Recordset
        Dim rs3 As Recordset
        Dim rs4 As Recordset

        Dim strItemText As String
        Dim unamS2, unamS As Integer

        rs = New Recordset
        rs.Open("SELECT count(*) as t_nim FROM SPR_KAB", DB7, CursorTypeEnum.adOpenDynamic,
                LockTypeEnum.adLockOptimistic)

        With rs
            unamS2 = .Fields("t_nim").Value
        End With
        rs.Close()
        rs = Nothing

        'Компы

        rs = New Recordset
        rs.Open("SELECT count(*) as t_n FROM SPR_MESTO", DB7, CursorTypeEnum.adOpenDynamic,
                LockTypeEnum.adLockOptimistic)

        With rs
            unamS = .Fields("t_n").Value
        End With
        rs.Close()
        rs = Nothing

        Dim unameS As String
        Dim unameS2 As String
        Dim unameS3 As String
        Dim unameS4 As String

        'Верхний нулевой уровень - вставляем название организации

        rs = New Recordset
        rs.Open("SELECT ORG FROM CONFIGURE", DB7, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic)
        Dim ORG As String

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

        'Филиалы Первый уровень дерева
        'Проверяем все показывать или только активные

        Select Case zBranche

            Case "0"
                Select Case sVISIBLE

                    Case 1
                        sSQL1 = "SELECT id, Filial FROM SPR_FILIAL ORDER BY Filial"
                    Case Else
                        sSQL1 = "SELECT id, Filial FROM SPR_FILIAL where Arhiv=0 ORDER BY Filial"

                End Select

            Case Else

                Select Case sVISIBLE

                    Case 1
                        sSQL1 = "SELECT id, Filial FROM SPR_FILIAL where filial ='" & zBranche & "' ORDER BY Filial"
                    Case Else
                        sSQL1 = "SELECT id, Filial FROM SPR_FILIAL where Arhiv=0 and filial ='" & zBranche & "' ORDER BY Filial"

                End Select

        End Select

        rs = New Recordset
        rs.Open(sSQL1, DB7, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic)

        With rs
            .MoveFirst()
            Do While Not .EOF
                'My.Application.DoEvents()
                Dim BrancheNode As New TreeNode(.Fields("filial").Value, 0, 0)
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

                unameS = .Fields("filial").Value

                If KCKey = 0 And Len(DCKey) <> 0 Then

                    Select Case DCKey

                        Case sTEN

                            lstgroups.SelectedNode = BrancheNode
                            lstgroups.SelectedNode.Expand()

                    End Select

                End If

                BrancheNode.ForeColor = Color.DarkBlue

                'Вставляем технику если есть
                Dim cFil As String
                sSQL4 = "SELECT count(*) as t_n FROM kompy WHERE filial ='" & unameS & "' AND mesto =''"
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

                'Отделы в филиалах Второй уровень дерева

                Select Case sVISIBLE

                    Case 1
                        sSQL2 = "SELECT id, Filial, N_Otd FROM SPR_OTD_FILIAL WHERE filial='" & unameS &
                            "' ORDER BY Filial, N_Otd"
                    Case Else
                        sSQL2 = "SELECT id, Filial, N_Otd FROM SPR_OTD_FILIAL where filial='" & unameS &
                                                    "' AND Arhiv=0 ORDER BY Filial, N_Otd"

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
                                BrancheNode.Nodes.Add(DepatrmentNode)
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

                                sSQL4 = "SELECT count(*) as t_n FROM kompy WHERE filial ='" & unameS & "' AND mesto ='" &
                                        unameS2 & "' AND kabn=''"
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

                                Select Case unamS2

                                    Case 0

                                    Case Else

                                        Select Case sVISIBLE
                                            Case 1
                                                sSQL5 = "SELECT id, Name, N_F, N_M FROM SPR_KAB WHERE N_F='" & unameS &
                                                   "' AND N_M ='" & unameS2 & "' ORDER BY N_F, N_M, Name"
                                            Case Else
                                                sSQL5 = "SELECT id, Name, N_F, N_M FROM SPR_KAB where N_F='" & unameS &
                                                   "' AND N_M ='" & unameS2 & "' AND Arhiv=0 ORDER BY N_F, N_M, Name"
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

        lstgroups.EndUpdate()

exitsub:

        Exit Sub

ERR1:

        Select Case Err.Number
            Case 3021 'ignore, no entries in list
                ' MsgBox(Err.Description, vbCritical, ProGramName)
                Resume Next
            Case Else

                MsgBox(Err.Description, vbCritical, ProGramName)

        End Select

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

                                                                Filling_TREE_DATA(lstgroups, .Fields("id").Value, TEHNodePC,
                                                                                  Spisan, balans, L_NAME, 7)

                                                            Case "MFU"

                                                                Filling_TREE_DATA(lstgroups, .Fields("id").Value, TEHNodePC,
                                                                                  Spisan, balans, L_NAME, 8)

                                                            Case "SCANER"

                                                                Filling_TREE_DATA(lstgroups, .Fields("id").Value, TEHNodePC,
                                                                                  Spisan, balans, L_NAME, 14)

                                                            Case "ZIP"

                                                                Filling_TREE_DATA(lstgroups, .Fields("id").Value, TEHNodePC,
                                                                                  Spisan, balans, L_NAME, 15)

                                                            Case "PHONE"

                                                                Filling_TREE_DATA(lstgroups, .Fields("id").Value, TEHNodePC,
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

                                                                Filling_TREE_DATA(lstgroups, .Fields("id").Value, TEHNodePC,
                                                                                  Spisan, balans, L_NAME, iA)

                                                            Case "MONITOR"

                                                                Filling_TREE_DATA(lstgroups, .Fields("id").Value, TEHNodePC,
                                                                                  Spisan, balans, L_NAME, 17)

                                                                '--------------VIP_Graff Добавление новой перефирии Начало-----------------
                                                            Case "USB"

                                                                Filling_TREE_DATA(lstgroups, .Fields("id").Value, TEHNodePC,
                                                                                  Spisan, balans, L_NAME, 18)

                                                            Case "SOUND"

                                                                Filling_TREE_DATA(lstgroups, .Fields("id").Value, TEHNodePC,
                                                                                  Spisan, balans, L_NAME, 44)

                                                            Case "IBP"

                                                                Filling_TREE_DATA(lstgroups, .Fields("id").Value, TEHNodePC,
                                                                                  Spisan, balans, L_NAME, 41)

                                                            Case "FS"

                                                                Filling_TREE_DATA(lstgroups, .Fields("id").Value, TEHNodePC,
                                                                                  Spisan, balans, L_NAME, 61)

                                                            Case "KEYB"

                                                                Filling_TREE_DATA(lstgroups, .Fields("id").Value, TEHNodePC,
                                                                                  Spisan, balans, L_NAME, 46)

                                                            Case "MOUSE"

                                                                Filling_TREE_DATA(lstgroups, .Fields("id").Value, TEHNodePC,
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

                                        Filling_TREE_DATA(lstgroups, .Fields("id").Value, TEHNodeCNT, Spisan, balans, L_NAME, 11)


                                    Case "Printer"

                                        Filling_TREE_DATA(lstgroups, .Fields("id").Value, TEHNodeCNT, Spisan, balans, L_NAME,
                                                          7)


                                    Case "MFU"

                                        Filling_TREE_DATA(lstgroups, .Fields("id").Value, TEHNodeCNT, Spisan, balans, L_NAME,
                                                          8)


                                    Case "SCANER"

                                        Filling_TREE_DATA(lstgroups, .Fields("id").Value, TEHNodeCNT, Spisan, balans, L_NAME,
                                                          14)


                                    Case "ZIP"

                                        Filling_TREE_DATA(lstgroups, .Fields("id").Value, TEHNodeCNT, Spisan, balans, L_NAME,
                                                          15)

                                    Case "PHONE"

                                        Filling_TREE_DATA(lstgroups, .Fields("id").Value, TEHNodeCNT, Spisan, balans, L_NAME,
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

                                        Filling_TREE_DATA(lstgroups, .Fields("id").Value, TEHNodeCNT, Spisan, balans, L_NAME,
                                                          iA)

                                    Case "MONITOR"

                                        Filling_TREE_DATA(lstgroups, .Fields("id").Value, TEHNodeCNT, Spisan, balans, L_NAME,
                                                          17)

                                        '--------------VIP_Graff Добавление новой перефирии Начало-----------------
                                    Case "USB"

                                        Filling_TREE_DATA(lstgroups, .Fields("id").Value, TEHNodeCNT, Spisan, balans, L_NAME,
                                                          18)

                                    Case "SOUND"

                                        Filling_TREE_DATA(lstgroups, .Fields("id").Value, TEHNodeCNT, Spisan, balans, L_NAME,
                                                          44)

                                    Case "IBP"

                                        Filling_TREE_DATA(lstgroups, .Fields("id").Value, TEHNodeCNT, Spisan, balans, L_NAME,
                                                          41)

                                    Case "FS"

                                        Filling_TREE_DATA(lstgroups, .Fields("id").Value, TEHNodeCNT, Spisan, balans, L_NAME,
                                                          61)

                                    Case "KEYB"

                                        Filling_TREE_DATA(lstgroups, .Fields("id").Value, TEHNodeCNT, Spisan, balans, L_NAME,
                                                          46)

                                    Case "MOUSE"

                                        Filling_TREE_DATA(lstgroups, .Fields("id").Value, TEHNodeCNT, Spisan, balans, L_NAME,
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

                                        Filling_TREE_DATA(lstgroups, .Fields("id").Value, TEHNodePC, Spisan, balans, L_NAME,
                                                          7)

                                    Case "MFU"


                                        Filling_TREE_DATA(lstgroups, .Fields("id").Value, TEHNodePC, Spisan, balans, L_NAME,
                                                          8)


                                    Case "SCANER"

                                        Filling_TREE_DATA(lstgroups, .Fields("id").Value, TEHNodePC, Spisan, balans, L_NAME,
                                                          14)

                                    Case "ZIP"

                                        Filling_TREE_DATA(lstgroups, .Fields("id").Value, TEHNodePC, Spisan, balans, L_NAME,
                                                          15)

                                    Case "PHONE"

                                        Filling_TREE_DATA(lstgroups, .Fields("id").Value, TEHNodePC, Spisan, balans, L_NAME,
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

                                        Filling_TREE_DATA(lstgroups, .Fields("id").Value, TEHNodePC, Spisan, balans, L_NAME,
                                                          iA)

                                    Case "MONITOR"

                                        Filling_TREE_DATA(lstgroups, .Fields("id").Value, TEHNodePC, Spisan, balans, L_NAME,
                                                          17)

                                        '--------------VIP_Graff Добавление новой перефирии Начало-----------------
                                    Case "USB"

                                        Filling_TREE_DATA(lstgroups, .Fields("id").Value, TEHNodePC, Spisan, balans, L_NAME,
                                                          18)

                                    Case "SOUND"

                                        Filling_TREE_DATA(lstgroups, .Fields("id").Value, TEHNodePC, Spisan, balans, L_NAME,
                                                          44)

                                    Case "IBP"

                                        Filling_TREE_DATA(lstgroups, .Fields("id").Value, TEHNodePC, Spisan, balans, L_NAME,
                                                          41)


                                    Case "FS"

                                        Filling_TREE_DATA(lstgroups, .Fields("id").Value, TEHNodePC, Spisan, balans, L_NAME,
                                                          61)

                                    Case "KEYB"

                                        Filling_TREE_DATA(lstgroups, .Fields("id").Value, TEHNodePC, Spisan, balans, L_NAME,
                                                          46)

                                    Case "MOUSE"

                                        Filling_TREE_DATA(lstgroups, .Fields("id").Value, TEHNodePC, Spisan, balans, L_NAME,
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
                Filling_TREE_DATA(lstgroups, iD, DepNode, Spisan, balans, L_NAME, 7)

            Case "MFU"
                stmREMONT = REMONT
                Filling_TREE_DATA(lstgroups, iD, DepNode, Spisan, balans, L_NAME, 8)

            Case "KOpir"
                stmREMONT = REMONT
                Filling_TREE_DATA(lstgroups, iD, DepNode, Spisan, balans, L_NAME, 9)

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

                                        Filling_TREE_DATA(lstgroups, .Fields("id").Value, TEHNodePHOTO, Spisan, balans, L_NAME,
                                                          iA)

                                    Case "USB"

                                        Filling_TREE_DATA(lstgroups, .Fields("id").Value, TEHNodePHOTO, Spisan, balans, L_NAME,
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
                Filling_TREE_DATA(lstgroups, iD, DepNode, Spisan, balans, L_NAME, 12)

            Case "FAX"
                stmREMONT = REMONT
                Filling_TREE_DATA(lstgroups, iD, DepNode, Spisan, balans, L_NAME, 13)

            Case "SCANER"
                stmREMONT = REMONT
                Filling_TREE_DATA(lstgroups, iD, DepNode, Spisan, balans, L_NAME, 14)

            Case "ZIP"
                stmREMONT = REMONT
                Filling_TREE_DATA(lstgroups, iD, DepNode, Spisan, balans, L_NAME, 15)

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

                Filling_TREE_DATA(lstgroups, iD, DepNode, Spisan, balans, L_NAME, iA)

            Case "MONITOR"
                stmREMONT = REMONT
                Filling_TREE_DATA(lstgroups, iD, DepNode, Spisan, balans, L_NAME, 17)

                '--------------VIP_Graff Добавление новой перефирии Начало-----------------
            Case "USB"
                stmREMONT = REMONT
                Filling_TREE_DATA(lstgroups, iD, DepNode, Spisan, balans, L_NAME, 18)

            Case "SOUND"
                stmREMONT = REMONT
                Filling_TREE_DATA(lstgroups, iD, DepNode, Spisan, balans, L_NAME, 44)

            Case "IBP"
                stmREMONT = REMONT
                Filling_TREE_DATA(lstgroups, iD, DepNode, Spisan, balans, L_NAME, 41)

            Case "FS"
                stmREMONT = REMONT
                Filling_TREE_DATA(lstgroups, iD, DepNode, Spisan, balans, L_NAME, 61)

            Case "KEYB"
                stmREMONT = REMONT
                Filling_TREE_DATA(lstgroups, iD, DepNode, Spisan, balans, L_NAME, 46)

            Case "MOUSE"
                stmREMONT = REMONT
                Filling_TREE_DATA(lstgroups, iD, DepNode, Spisan, balans, L_NAME, 47)

                '--------------VIP_Graff Добавление новой перефирии Конец------------------

            Case Else

        End Select
    End Sub

    Public Sub Filling_TREE_DATA(ByVal lstgroups As TreeView, ByVal sID As Integer, ByVal TEHNodePCL As TreeNode,
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

    '######################################################
    'Новая схема построения дерева при работе с объектами
    '######################################################
    Public Sub PreSaveName(ByVal sID As Integer)

        Dim sSQL As String
        Dim tmpTXT As String
        Dim tmpTXT2 As String

        sSQL = "Select NET_NAME from kompy where id=" & frmComputers.sCOUNT
        ', balans, spisan
        Dim rs As ADODB.Recordset
        rs = New ADODB.Recordset
        rs.Open(sSQL, DB7, ADODB.CursorTypeEnum.adOpenDynamic, ADODB.LockTypeEnum.adLockOptimistic)

        With rs

            tmpTXT = .Fields("NET_NAME").Value

        End With
        rs.Close()
        rs = Nothing

        Select Case TipTehn

            Case "PC"
                tmpTXT2 = frmComputers.txtSNAME.Text
                'SPVisible = frmComputers.chkPCspis.Checked
                'NBVisible = frmComputers.chkPCNNb.Checked
            Case "Printer"
                tmpTXT2 = frmComputers.cmbPRN.Text

                'SPVisible = frmComputers.chkPRNspis.Checked
                'NBVisible = frmComputers.chkPRNNNb.Checked
            Case "MFU"
                tmpTXT2 = frmComputers.cmbPRN.Text

                'SPVisible = frmComputers.chkPRNspis.Checked
                'NBVisible = frmComputers.chkPRNNNb.Checked
            Case "KOpir"
                tmpTXT2 = frmComputers.cmbPRN.Text

                'SPVisible = frmComputers.chkPRNspis.Checked
                'NBVisible = frmComputers.chkPRNNNb.Checked
            Case "NET"
                tmpTXT2 = frmComputers.cmbDevNet.Text

                'SPVisible = frmComputers.chkNETspis.Checked
                'NBVisible = frmComputers.chkNETNNb.Checked
            Case Else
                tmpTXT2 = frmComputers.cmbOTH.Text
                'SPVisible = frmComputers.chkOTHspis.Checked
                'NBVisible = frmComputers.chkOTHNNb.Checked

        End Select

        If tmpTXT = tmpTXT2 Then Exit Sub

        sNetName = True

    End Sub

    Private Sub FIND_NAME(ByVal sID As Integer)
        '######################################################
        'Ищем и формируем имя объекта
        '######################################################
        Dim sSQL As String
        Dim rs As ADODB.Recordset
        Dim sTREENAME As String

        Dim objIniFile As New IniFile(PrPath & "base.ini")
        sTREENAME = objIniFile.GetString("general", "NETNAME", "1")

        sSQL = "Select NET_NAME, PSEVDONIM from kompy where id=" & sID

        rs = New ADODB.Recordset
        rs.Open(sSQL, DB7, ADODB.CursorTypeEnum.adOpenDynamic, ADODB.LockTypeEnum.adLockOptimistic)

        With rs
            N_NAME = .Fields("NET_NAME").Value
            P_NAME = .Fields("PSEVDONIM").Value
        End With
        rs.Close()
        rs = Nothing

        Select Case sTREENAME

            Case 0

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

                Select Case Len(P_NAME)
                    Case 0
                        P_NAME = "NoName"
                End Select

                L_NAME = P_NAME

            Case 1

                Select Case Len(N_NAME)
                    Case 0
                        N_NAME = "NoName"
                End Select

                L_NAME = N_NAME

        End Select
    End Sub

    Private Sub RefTreeSaveTech(ByVal sID As Integer, ByVal sNames As String, ByVal sTIPTEHN As String, ByVal sFIALIAL As String, ByVal sOTDEL As String, ByVal sKABN As String)

        '######################################################
        'Обрабатываем объект, перестраиваем его...
        '######################################################

        On Error GoTo err_
        Dim objIniFile As New IniFile(PrPath & "base.ini")

        If Len(sBranch) = 0 Then Exit Sub

        '  Call frmComputers.selectTECMesto()

        Dim sSQL, PrefM, sNODENAME As String
        Dim sSID As Integer
        Dim rs As ADODB.Recordset

        Select Case Len(sKABN)
            Case 0
            Case Else
                sSQL = "SELECT id, Name as NAME,N_F as FILIAL, N_M as OTDEL FROM SPR_KAB WHERE N_F='" & sFIALIAL & "' AND N_M='" & sOTDEL & "' AND Name='" & sKABN & "'"
                PrefM = "K"
        End Select

        If Len(sOTDEL) <> 0 And Len(sKABN) = 0 Then

            sSQL = "SELECT id, N_Otd as NAME, Filial as FILIAL FROM SPR_OTD_FILIAL WHERE filial='" & sFIALIAL & "' AND n_otd='" & sOTDEL & "'"
            PrefM = "O"
            'sICO = 1
        End If

        If Len(sFIALIAL) <> 0 And Len(sOTDEL) = 0 Then

            sSQL = "SELECT id, FILIAL as NAME FROM SPR_FILIAL WHERE filial='" & sFIALIAL & "'"
            PrefM = "G"
            'sICO = 0
        End If

        rs = New Recordset
        rs.Open(sSQL, DB7, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic)

        With rs
            sSID = .Fields("id").Value
            sNODENAME = .Fields("NAME").Value
        End With

        rs.Close()
        rs = Nothing

        '###########################
        'Ищем место
        '###########################

        '  Call FIND_TREE(sNODENAME)
        FIND_TREE_TAG(frmComputers.lstGroups.Nodes, PrefM & "|" & sSID)

        'Получаем информацию о технике

        Dim tmpCount As Integer

        sSQL = "SELECT count(*) as T_N FROM kompy WHERE id =" & sID & " AND PCL <> 0"

        rs = New Recordset
        rs.Open(sSQL, DB7, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic)

        With rs
            tmpCount = .Fields("T_N").Value
        End With

        rs.Close()
        rs = Nothing

        'Если техника находится в контейнере, то удаляем контейнер, и заново его добавляем.
        Select Case tmpCount

            'если техника не в контейнере то...
            Case 0

                sSQL = "SELECT count(*) as T_N FROM kompy WHERE id =" & sID & " AND PCL =0"

                rs = New Recordset
                rs.Open(sSQL, DB7, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic)

                With rs
                    tmpCount = .Fields("T_N").Value

                End With

                rs.Close()
                rs = Nothing

                Select Case tmpCount

                    Case 0

                    Case Else

                        objIniFile.WriteString("general", "DK", sID)
                        objIniFile.WriteString("general", "Default", 0)

                        ' sSQL = "SELECT id, mesto, filial, tip_compa, tiptehn, PSEVDONIM, NET_NAME, kabn, Spisan, OS, PRINTER_NAME_4,balans FROM kompy WHERE id =" & sID '& " AND PCL =0"
                        sSQL = "SELECT id, mesto, filial, tip_compa, tiptehn, PSEVDONIM, NET_NAME, kabn, Spisan, OS, PRINTER_NAME_4,balans, (Select count(*) as t_n FROM Remont Where id_comp=" & sID & " and zakryt = 0) as rem FROM kompy WHERE id =" & sID

                        rs = New Recordset
                        rs.Open(sSQL, DB7, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic)

                        Dim tmpRemont As Integer

                        With rs

                            If Not IsDBNull(.Fields("tip_compa").Value) Then iA1 = .Fields("tip_compa").Value
                            If Not IsDBNull(.Fields("NET_NAME").Value) Then iA2 = .Fields("NET_NAME").Value
                            If Not IsDBNull(.Fields("PSEVDONIM").Value) Then iA3 = .Fields("PSEVDONIM").Value
                            If Not IsDBNull(.Fields("Spisan").Value) Then iA4 = .Fields("Spisan").Value
                            If Not IsDBNull(.Fields("tiptehn").Value) Then iA5 = .Fields("tiptehn").Value
                            If Not IsDBNull(.Fields("OS").Value) Then iA6 = .Fields("OS").Value
                            If Not IsDBNull(.Fields("PRINTER_NAME_4").Value) Then iA7 = .Fields("PRINTER_NAME_4").Value
                            If Not IsDBNull(.Fields("Balans").Value) Then iA8 = .Fields("Balans").Value
                            tmpRemont = .Fields("rem").Value
                        End With

                        rs.Close()
                        rs = Nothing

                        'Добавляем объект в дерево
                        FILING_TREE(frmComputers.lstGroups, iA5, iA1, iA2, iA3, sID, iA4, frmComputers.lstGroups.SelectedNode, iA6, iA7, iA8, tmpRemont)

                        '###########################
                        'Ищем технику
                        '###########################

                        ' Call FIND_TREE(iA2)

                        Call FIND_TREE_TAG(frmComputers.lstGroups.Nodes, "C|" & sID)


                End Select

                'Если техника в контейнере
            Case Else

                Dim tmpPCL As Integer

                sSQL = "Select PCL from kompy where id=" & sID

                rs = New ADODB.Recordset
                rs.Open(sSQL, DB7, ADODB.CursorTypeEnum.adOpenDynamic, ADODB.LockTypeEnum.adLockOptimistic)

                With rs
                    tmpPCL = .Fields("PCL").Value
                End With
                rs.Close()
                rs = Nothing

                'ищем имя объекта контейнера
                '  Call FIND_NAME(tmpPCL)

                'ищем в дереве объект контейнер
                ' Call FIND_TREE(L_NAME)

                FIND_TREE_TAG(frmComputers.lstGroups.Nodes, "C|" & tmpPCL)

                sSQL = "SELECT id, mesto, filial, tip_compa, tiptehn, PSEVDONIM, NET_NAME, kabn, Spisan, OS, PRINTER_NAME_4,balans, (Select count(*) as t_n FROM Remont Where id_comp=kompy.id and zakryt = 0) as rem FROM kompy WHERE id =" & sID '& " AND PCL =0"

                rs = New Recordset
                rs.Open(sSQL, DB7, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic)

                Dim tmpRemont As Integer
                With rs

                    If Not IsDBNull(.Fields("tip_compa").Value) Then iA1 = .Fields("tip_compa").Value
                    If Not IsDBNull(.Fields("NET_NAME").Value) Then iA2 = .Fields("NET_NAME").Value
                    If Not IsDBNull(.Fields("PSEVDONIM").Value) Then iA3 = .Fields("PSEVDONIM").Value
                    If Not IsDBNull(.Fields("Spisan").Value) Then iA4 = .Fields("Spisan").Value
                    If Not IsDBNull(.Fields("tiptehn").Value) Then iA5 = .Fields("tiptehn").Value
                    If Not IsDBNull(.Fields("OS").Value) Then iA6 = .Fields("OS").Value
                    If Not IsDBNull(.Fields("PRINTER_NAME_4").Value) Then iA7 = .Fields("PRINTER_NAME_4").Value
                    If Not IsDBNull(.Fields("Balans").Value) Then iA8 = .Fields("Balans").Value
                    tmpRemont = .Fields("rem").Value
                End With

                rs.Close()
                rs = Nothing

                objIniFile.WriteString("general", "DK", sID)
                objIniFile.WriteString("general", "Default", 0)

                'Добавляем объект в контейнер в дереве
                Call FILING_TREE(frmComputers.lstGroups, iA5, iA1, iA2, iA3, sID, iA4, frmComputers.lstGroups.SelectedNode, iA6, iA7, iA8, tmpRemont)

        End Select

        Exit Sub
err_:
        ' MsgBox(Err.Description)
        RefFilTree(frmComputers.lstGroups)

    End Sub

    'Ищем в дереве (По имени объекта) необходимый объект и выделяем его

    'Public Sub FIND_TREE(ByVal sNODENAME As String)

    '    On Error Resume Next

    '    Dim arr As TreeNode() = frmComputers.lstGroups.Nodes(0).Nodes(0).Nodes(0).Nodes.Find(sNODENAME, True)

    '    Dim str As Integer = frmComputers.lstGroups.Nodes.Count

    '    For i = 0 To str

    '        arr = frmComputers.lstGroups.Nodes.Find(sNODENAME, True)

    '    Next

    '    If arr.Length > 1 Then RefFilTree(frmComputers.lstGroups)

    '    For i = 0 To arr.Length - 1

    '        frmComputers.lstGroups.SelectedNode = arr(i)

    '    Next

    'End Sub

    'Ищем в дереве (По тэгу объекта, исключается ошибочный выбор объекта) необходимый объект и выделяем его

    Public Function FIND_TREE_TAG(ByVal nodes As TreeNodeCollection, sTXT As String)

        For Each node As TreeNode In nodes

            Select Case node.Tag.ToString

                Case sTXT
                    frmComputers.lstGroups.SelectedNode = node
                Case Else
                    FIND_TREE_TAG(node.Nodes, sTXT)

            End Select

            'If node.Tag.ToString = sTXT Then
            '    ' Return node
            '       frmComputers.lstGroups.SelectedNode = node
            'Else
            '    FIND_TREE_TAG(node.Nodes, sTXT)

            'End If

        Next

        Return FIND_TREE_TAG

    End Function

    'Процедура перестроения дерева
    'Определяем необходимость перестроения
    Public Sub UpdateTree(ByVal sTXT As String, ByVal sTIPTEHN As String, ByVal sID As Integer, ByVal sFIALIAL As String, ByVal sOTDEL As String, ByVal sKABN As String)
        On Error Resume Next

        Select Case frmComputers.pDRAG

            Case False

                Select Case TREE_UPDATE

                    Case 0

                        Select Case frmComputers.EDT

                            Case False
                                RefFilTree(frmComputers.lstGroups)

                            Case True

                                Select Case sNetName

                                    Case True

                                        Call FIND_NAME(frmComputers.sCOUNT)

                                        frmComputers.lstGroups.SelectedNode.Text = L_NAME

                                End Select

                                Select Case DV2
                                    Case True
                                        RefFilTree(frmComputers.lstGroups)

                                    Case False

                                        Call frmComputers.LOAD_LIST()

                                End Select

                        End Select

                    Case 1

                        Select Case frmComputers.EDT

                            Case True

                                Select Case sNetName

                                    Case True

                                        Call FIND_NAME(frmComputers.sCOUNT)

                                        frmComputers.lstGroups.SelectedNode.Text = L_NAME

                                End Select

                                Select Case DV2

                                    Case True

                                        Select Case frmComputers.EDT

                                            Case True
                                                Call FIND_TREE_TAG(frmComputers.lstGroups.Nodes, "C|" & sID)
                                                frmComputers.lstGroups.Nodes.Remove(frmComputers.lstGroups.SelectedNode)
                                        End Select


                                        RefTreeSaveTech(sID, sTXT, sTIPTEHN, sFIALIAL, sOTDEL, sKABN)

                                    Case False

                                        frmComputers.LOAD_LIST()

                                End Select

                            Case False

                                RefTreeSaveTech(sID, sTXT, sTIPTEHN, sFIALIAL, sOTDEL, sKABN)

                        End Select

                End Select

        End Select

        DV2 = False

    End Sub

    '##########################################################################################################

    Public Sub Add_FILIAL_TREE(ByVal sBr As String)
        On Error Resume Next

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

        Select Case us

            Case 0


            Case Else
                Dim sID As Integer
                rs = New Recordset
                rs.Open("Select ORG from CONFIGURE", DB7, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic)

                With rs

                    If Not IsDBNull(.Fields("ORG").Value) Then Call FIND_TREE_TAG(frmComputers.lstGroups.Nodes, "ROOT|001") 'FIND_TREE(.Fields("ORG").Value)

                End With
                rs.Close()
                rs = Nothing

                rs = New Recordset
                rs.Open("SELECT top 1 id FROM SPR_FILIAL WHERE FILIAL='" & sBr & "' order by id desc", DB7, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic)

                With rs
                    sID = .Fields("ID").Value
                End With
                rs.Close()
                rs = Nothing

                Dim BrancheNode As New TreeNode(sBr, 0, 0)
                BrancheNode.Tag = "G|" & sID
                BrancheNode.Name = sBr
                BrancheNode.Text = sBr
                frmComputers.lstGroups.SelectedNode.Nodes.Add(BrancheNode)

        End Select

    End Sub

    Public Sub Add_OTDEL_TREE(ByVal sBr As String, ByVal sDp As String)
        On Error Resume Next
        Dim sID As Integer
        Dim rs As Recordset

        '##################################
        rs = New Recordset
        rs.Open("SELECT top 1 id FROM SPR_FILIAL WHERE FILIAL='" & sBr & "' order by id desc", DB7, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic)

        With rs
            sID = .Fields("ID").Value
        End With
        rs.Close()
        rs = Nothing

        Call FIND_TREE_TAG(frmComputers.lstGroups.Nodes, "G|" & sID)
        '##################################

        '  FIND_TREE(sBr)
        rs = New Recordset
        rs.Open("SELECT top 1 id FROM SPR_OTD_FILIAL WHERE FILIAL='" & sBr & "' AND N_Otd='" & sDp & "' order by id desc", DB7, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic)

        With rs
            sID = .Fields("ID").Value
        End With
        rs.Close()
        rs = Nothing

        Dim BrancheNode As New TreeNode(sDp, 1, 1)
        BrancheNode.Tag = "O|" & sID
        BrancheNode.Name = sDp
        BrancheNode.Text = sDp
        frmComputers.lstGroups.SelectedNode.Nodes.Add(BrancheNode)

    End Sub

    Public Sub Add_KABINET_TREE(ByVal sBr As String, ByVal sDp As String, ByVal sOff As String)
        On Error Resume Next

        Dim rs As Recordset
        Dim sID As Integer


        '#############################
        rs = New Recordset
        rs.Open("SELECT top 1 id FROM SPR_OTD_FILIAL WHERE FILIAL='" & sBr & "' AND N_Otd='" & sDp & "' order by id desc", DB7, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic)

        With rs
            sID = .Fields("ID").Value
        End With
        rs.Close()
        rs = Nothing

        Call FIND_TREE_TAG(frmComputers.lstGroups.Nodes, "O|" & sID)

        '#############################

        '  FIND_TREE(sDp)


        rs = New Recordset
        rs.Open("SELECT top 1 id FROM SPR_KAB WHERE N_F='" & sBr & "' AND N_M='" & sDp & "' AND Name='" & sOff & "' order by id desc", DB7, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic)

        With rs
            sID = .Fields("ID").Value
        End With
        rs.Close()
        rs = Nothing

        Dim BrancheNode As New TreeNode(sOff, 2, 2)
        BrancheNode.Tag = "K|" & sID
        BrancheNode.Name = sOff
        BrancheNode.Text = sOff
        frmComputers.lstGroups.SelectedNode.Nodes.Add(BrancheNode)


    End Sub

    '##########################################################################################################


End Module
