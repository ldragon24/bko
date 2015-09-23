Public Class frmCartr2
    Public rCOUNT As Decimal
    Public zCOUNT As Decimal
    Public cCOUNT As Integer
    Private m_SortingColumn As ColumnHeader
    Public EDTRCART As Boolean
    Public EDTIDTr As Decimal
    Public CRTFU As Boolean


    Private Sub RefFilTreePRN()
        On Error GoTo ERR1

        lstgroups.HideSelection = False

        'On Error Resume Next
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
        lstgroups.Nodes.Clear()

        lstgroups.ImageList = frmComputers.ilsCommands

        Dim rs As ADODB.Recordset
        Dim rs2 As ADODB.Recordset
        Dim rs3 As ADODB.Recordset
        Dim rs4 As ADODB.Recordset
        Dim rs5 As ADODB.Recordset
        Dim rs6 As ADODB.Recordset
        Dim rs7 As ADODB.Recordset

        rs3 = New ADODB.Recordset
        rs6 = New ADODB.Recordset


        Dim strItemText As String
        Dim unamS2, unamS As Integer


        rs7 = New ADODB.Recordset
        rs7.Open("SELECT count(*) as t_nim FROM SPR_KAB", DB7, ADODB.CursorTypeEnum.adOpenDynamic, ADODB.LockTypeEnum.adLockOptimistic)

        With rs7
            unamS2 = .Fields("t_nim").Value
        End With

        rs7.Close()
        rs7 = Nothing

        If unamS2 = 0 Then
        Else
            If sVISIBLE = 1 Then
                sSQL5 = "SELECT id, Name, N_F, N_M FROM SPR_KAB ORDER BY N_F, N_M, Name"
            Else
                sSQL5 = "SELECT id, Name, N_F, N_M FROM SPR_KAB where Arhiv=0 ORDER BY N_F, N_M, Name"
            End If

            rs7 = New ADODB.Recordset
            rs7.Open(sSQL5, DB7, ADODB.CursorTypeEnum.adOpenDynamic, ADODB.LockTypeEnum.adLockOptimistic)
        End If


        'Компы


        rs6.Open("SELECT count(*) as t_n FROM SPR_MESTO", DB7, ADODB.CursorTypeEnum.adOpenDynamic, ADODB.LockTypeEnum.adLockOptimistic)

        With rs6
            unamS = .Fields("t_n").Value
        End With
        rs6.Close()
        rs6 = Nothing



        Dim unameS As String
        Dim unameS2 As String
        Dim unameS3 As String
        Dim unameS4 As String

        'Верхний нулевой уровень - вставляем название организации
        Dim rsG As ADODB.Recordset
        rsG = New ADODB.Recordset

        rsG.Open("SELECT * FROM CONFIGURE", DB7, ADODB.CursorTypeEnum.adOpenDynamic, ADODB.LockTypeEnum.adLockOptimistic)
        Dim ORG As String

        With rsG
            If Not IsDBNull(.Fields("ORG").Value) Then ORG = .Fields("ORG").Value
        End With

        rsG.Close()
        rsG = Nothing

        Dim nodeRoot As New TreeNode(ORG, 0, 0)
        nodeRoot.Tag = "ROOT" & GENID()
        lstgroups.Nodes.Add(nodeRoot)


        'Филиалы Первый уровень дерева
        'Проверяем все показывать или только активные

        If sVISIBLE = 1 Then
            sSQL1 = "SELECT id, Filial FROM SPR_FILIAL ORDER BY Filial"
        Else
            sSQL1 = "SELECT id, Filial FROM SPR_FILIAL where Arhiv=0 ORDER BY Filial"
        End If

        rs = New ADODB.Recordset
        rs.Open(sSQL1, DB7, ADODB.CursorTypeEnum.adOpenDynamic, ADODB.LockTypeEnum.adLockOptimistic)

        With rs
            .MoveFirst()
            Do While Not .EOF

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


                'Вставляем технику если есть
                Dim cFil As String
                sSQL4 = "SELECT count(*) as t_n FROM kompy WHERE filial ='" & unameS & "' AND mesto =''"
                rs3 = New ADODB.Recordset
                rs3.Open(sSQL4, DB7, ADODB.CursorTypeEnum.adOpenDynamic, ADODB.LockTypeEnum.adLockOptimistic)
                With rs3
                    cFil = .Fields("t_n").Value
                End With
                rs3.Close()
                rs3 = Nothing


                If cFil <> 0 Then

                    Dim sText As String = objIniFile.GetString("general", "Tree_S", 0)

                    Select Case sText

                        Case 0

                            sSQL4 = "SELECT id, mesto, filial, tip_compa, tiptehn, PSEVDONIM, NET_NAME, kabn, Spisan, OS FROM kompy WHERE filial ='" & unameS & "' AND mesto ='' AND tiptehn <>'PC' ORDER BY PSEVDONIM, tiptehn"

                        Case 1

                            sSQL4 = "SELECT id, mesto, filial, tip_compa, tiptehn, PSEVDONIM, NET_NAME, kabn, Spisan, OS FROM kompy WHERE filial ='" & unameS & "' AND mesto ='' AND tiptehn <>'PC' ORDER BY tiptehn, PSEVDONIM"

                    End Select


                    rs3 = New ADODB.Recordset
                    rs3.Open(sSQL4, DB7, ADODB.CursorTypeEnum.adOpenDynamic, ADODB.LockTypeEnum.adLockOptimistic)

                    With rs3
                        .MoveFirst()

                        Do While Not .EOF

                            If Not IsDBNull(.Fields("tip_compa").Value) Then iA1 = .Fields("tip_compa").Value
                            If Not IsDBNull(.Fields("NET_NAME").Value) Then iA2 = .Fields("NET_NAME").Value
                            If Not IsDBNull(.Fields("PSEVDONIM").Value) Then iA3 = .Fields("PSEVDONIM").Value
                            If Not IsDBNull(.Fields("Spisan").Value) Then iA4 = .Fields("Spisan").Value
                            If Not IsDBNull(.Fields("tiptehn").Value) Then iA5 = .Fields("tiptehn").Value
                            If Not IsDBNull(.Fields("OS").Value) Then iA6 = .Fields("OS").Value


                            FILING_TREE(lstGroups, iA5, iA1, iA2, iA3, .Fields("id").Value, iA4, BrancheNode, iA6)


                            .MoveNext()
                        Loop
                    End With
                    rs3.Close()
                    rs3 = Nothing
                End If

                'Отделы в филиалах Второй уровень дерева

                If sVISIBLE = 1 Then
                    sSQL2 = "SELECT id, Filial, N_Otd FROM SPR_OTD_FILIAL WHERE filial='" & unameS & "' ORDER BY Filial, N_Otd"
                Else
                    sSQL2 = "SELECT id, Filial, N_Otd FROM SPR_OTD_FILIAL where filial='" & unameS & "' AND Arhiv=0 ORDER BY Filial, N_Otd"
                End If
                rs2 = New ADODB.Recordset
                rs2.Open(sSQL2, DB7, ADODB.CursorTypeEnum.adOpenDynamic, ADODB.LockTypeEnum.adLockOptimistic)

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
                                    lstGroups.SelectedNode = DepatrmentNode
                                    lstGroups.SelectedNode.Expand()
                                End If
                            End If

                            DepatrmentNode.ForeColor = Color.DarkGreen
                            'DepatrmentNode.NodeFont = New Font(DepatrmentNode.NodeFont, FontStyle.Italic)


                            sSQL4 = "SELECT count(*) as t_n FROM kompy WHERE filial ='" & unameS & "' AND mesto ='" & unameS2 & "' AND kabn=''"
                            rs3 = New ADODB.Recordset
                            rs3.Open(sSQL4, DB7, ADODB.CursorTypeEnum.adOpenDynamic, ADODB.LockTypeEnum.adLockOptimistic)
                            With rs3
                                cFil = .Fields("t_n").Value
                            End With
                            rs3.Close()
                            rs3 = Nothing


                            If cFil <> 0 Then

                                Dim sText As String = objIniFile.GetString("general", "Tree_S", 0)

                                Select Case sText

                                    Case 0

                                        sSQL4 = "SELECT id, mesto, filial, tip_compa, tiptehn, PSEVDONIM, NET_NAME, kabn, Spisan, OS FROM kompy WHERE filial ='" & unameS & "' AND mesto ='" & unameS2 & "' AND kabn='' AND tiptehn <>'PC' ORDER BY PSEVDONIM, tiptehn"

                                    Case 1

                                        sSQL4 = "SELECT id, mesto, filial, tip_compa, tiptehn, PSEVDONIM, NET_NAME, kabn, Spisan, OS FROM kompy WHERE filial ='" & unameS & "' AND mesto ='" & unameS2 & "' AND kabn='' AND tiptehn <>'PC' ORDER BY tiptehn, PSEVDONIM"

                                End Select

                                rs3 = New ADODB.Recordset
                                rs3.Open(sSQL4, DB7, ADODB.CursorTypeEnum.adOpenDynamic, ADODB.LockTypeEnum.adLockOptimistic)

                                With rs3
                                    .MoveFirst()

                                    Do While Not .EOF


                                        If Not IsDBNull(.Fields("tip_compa").Value) Then iA1 = .Fields("tip_compa").Value
                                        If Not IsDBNull(.Fields("NET_NAME").Value) Then iA2 = .Fields("NET_NAME").Value
                                        If Not IsDBNull(.Fields("PSEVDONIM").Value) Then iA3 = .Fields("PSEVDONIM").Value
                                        If Not IsDBNull(.Fields("Spisan").Value) Then iA4 = .Fields("Spisan").Value
                                        If Not IsDBNull(.Fields("tiptehn").Value) Then iA5 = .Fields("tiptehn").Value
                                        If Not IsDBNull(.Fields("OS").Value) Then iA6 = .Fields("OS").Value

                                        FILING_TREE(lstGroups, iA5, iA1, iA2, iA3, .Fields("id").Value, iA4, DepatrmentNode, iA6)


                                        .MoveNext()
                                    Loop
                                End With
                                rs3.Close()
                                rs3 = Nothing
                            End If


                            'Кабинеты Третий уровень дерева

                            If unamS2 > 0 Then

                                If sVISIBLE = 1 Then
                                    sSQL5 = "SELECT id, Name, N_F, N_M FROM SPR_KAB WHERE N_F='" & unameS & "' AND N_M ='" & unameS2 & "' ORDER BY N_F, N_M, Name"
                                Else
                                    sSQL5 = "SELECT id, Name, N_F, N_M FROM SPR_KAB where N_F='" & unameS & "' AND N_M ='" & unameS2 & "' AND Arhiv=0 ORDER BY N_F, N_M, Name"
                                End If

                                rs7 = New ADODB.Recordset
                                rs7.Open(sSQL5, DB7, ADODB.CursorTypeEnum.adOpenDynamic, ADODB.LockTypeEnum.adLockOptimistic)

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
                                                lstGroups.SelectedNode = OfficeNode
                                                lstGroups.SelectedNode.Expand()
                                            End If
                                        End If

                                        OfficeNode.ForeColor = Color.DarkGoldenrod


                                        sSQL4 = "SELECT count(*) as t_n FROM kompy WHERE filial ='" & unameS & "' AND mesto ='" & unameS2 & "' AND kabn='" & unameS3 & "'"
                                        rs3 = New ADODB.Recordset
                                        rs3.Open(sSQL4, DB7, ADODB.CursorTypeEnum.adOpenDynamic, ADODB.LockTypeEnum.adLockOptimistic)
                                        With rs3
                                            cFil = .Fields("t_n").Value
                                        End With
                                        rs3.Close()
                                        rs3 = Nothing


                                        If cFil <> 0 Then

                                            Dim sText As String = objIniFile.GetString("general", "Tree_S", 0)

                                            Select Case sText

                                                Case 0

                                                    sSQL4 = "SELECT id, mesto, filial, tip_compa, tiptehn, PSEVDONIM, NET_NAME, kabn, Spisan, OS FROM kompy WHERE filial ='" & unameS & "' AND mesto ='" & unameS2 & "' AND kabn='" & unameS3 & "' AND tiptehn <>'PC' ORDER BY PSEVDONIM, tiptehn"

                                                Case 1

                                                    sSQL4 = "SELECT id, mesto, filial, tip_compa, tiptehn, PSEVDONIM, NET_NAME, kabn, Spisan, OS FROM kompy WHERE filial ='" & unameS & "' AND mesto ='" & unameS2 & "' AND kabn='" & unameS3 & "' AND tiptehn <>'PC' ORDER BY tiptehn, PSEVDONIM"

                                            End Select


                                            rs3 = New ADODB.Recordset
                                            rs3.Open(sSQL4, DB7, ADODB.CursorTypeEnum.adOpenDynamic, ADODB.LockTypeEnum.adLockOptimistic)

                                            With rs3
                                                .MoveFirst()

                                                Do While Not .EOF

                                                    If Not IsDBNull(.Fields("tip_compa").Value) Then iA1 = .Fields("tip_compa").Value
                                                    If Not IsDBNull(.Fields("NET_NAME").Value) Then iA2 = .Fields("NET_NAME").Value
                                                    If Not IsDBNull(.Fields("PSEVDONIM").Value) Then iA3 = .Fields("PSEVDONIM").Value
                                                    If Not IsDBNull(.Fields("Spisan").Value) Then iA4 = .Fields("Spisan").Value
                                                    If Not IsDBNull(.Fields("tiptehn").Value) Then iA5 = .Fields("tiptehn").Value
                                                    If Not IsDBNull(.Fields("OS").Value) Then iA6 = .Fields("OS").Value

                                                    FILING_TREE(lstgroups, iA5, iA1, iA2, iA3, .Fields("id").Value, iA4, OfficeNode, iA6)

                                                    .MoveNext()
                                                Loop
                                            End With
                                            rs3.Close()
                                            rs3 = Nothing

                                        End If

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

                ' On Error Resume Next
                Dim rsCRT As ADODB.Recordset
                rsCRT = New ADODB.Recordset
                rsCRT.Open("Select count(*) as t_n FROM CARTRIDG WHERE USTR=0", DB7, ADODB.CursorTypeEnum.adOpenDynamic, ADODB.LockTypeEnum.adLockOptimistic)
                Dim CRT_ As String

                With rsCRT
                    CRT_ = .Fields("t_n").Value
                End With
                
                rsCRT.Close()
                rsCRT = Nothing

                If CRT_ > 0 Then

                    Dim CRT_NULL As New TreeNode("Картриджи", 0, 0)
                    CRT_NULL.Tag = "GС|" & GENID()
                    nodeRoot.Nodes.Add(CRT_NULL)

                    Dim rsq As ADODB.Recordset
                    rsq = New ADODB.Recordset
                    rsq.Open("Select * FROM CARTRIDG WHERE USTR=0", DB7, ADODB.CursorTypeEnum.adOpenDynamic, ADODB.LockTypeEnum.adLockOptimistic)

                    Dim uname As String
                    With rsq
                        .MoveFirst()
                        Do While Not .EOF

                            Dim rs1 As ADODB.Recordset
                            rs1 = New ADODB.Recordset
                            rs1.Open("Select * FROM spr_cart WHERE id=" & .Fields("model").Value, DB7, ADODB.CursorTypeEnum.adOpenDynamic, ADODB.LockTypeEnum.adLockOptimistic)
                            With rs1
                                uname = .Fields("name").Value
                            End With
                            rs1.Close()
                            rs1 = Nothing

                            Dim TEHNodeCP As New TreeNode(uname, 49, 49)
                            TEHNodeCP.Tag = "CRT|" & .Fields("id").Value
                            CRT_NULL.Nodes.Add(TEHNodeCP)

                            .MoveNext()
                        Loop
                    End With
                    rsq.Close()
                    rsq = Nothing




                End If



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

    Private Sub FILING_TREE(ByVal lstgroups As TreeView, ByVal iTipTehn As String, ByVal TipPC As String, ByVal NET_NAME As String, ByVal PSEVDONIM As String, ByVal iD As String, ByVal Spisan As String, ByVal DepNode As TreeNode, ByVal OS As String)

        Dim sTREENAME As String
        Dim N_NAME As String
        Dim P_NAME As String
        Dim L_NAME As String

        Dim objIniFile As New IniFile(PrPath & "base.ini")
        KCKey = objIniFile.GetString("general", "DK", 0)
        DCKey = objIniFile.GetString("general", "Default", 0)
        sTREENAME = objIniFile.GetString("general", "NETNAME", "1")

        Select Case sTREENAME

            Case 0
                N_NAME = NET_NAME
                P_NAME = PSEVDONIM

                If Len(N_NAME) = 0 Then
                    N_NAME = "NoName"
                End If

                If Len(P_NAME) = 0 Then
                    P_NAME = "NoName"
                End If
                L_NAME = N_NAME & " (" & P_NAME & ")"

            Case 2
                P_NAME = PSEVDONIM

                If Len(P_NAME) = 0 Then
                    P_NAME = "NoName"
                End If
                L_NAME = P_NAME

            Case 1

                N_NAME = NET_NAME
                If Len(N_NAME) = 0 Then
                    N_NAME = "NoName"
                End If

                L_NAME = N_NAME

        End Select


        Select Case iTipTehn

            Case "Printer"

                Dim TEHNode As New TreeNode(L_NAME, 7, 7)
                TEHNode.Tag = "C|" & iD
                DepNode.Nodes.Add(TEHNode)

                If Spisan = "1" Or Spisan = "True" Or Spisan = "-1" Then
                    TEHNode.ForeColor = Color.Red

                End If

                If KCKey <> 0 Then
                    If KCKey = iD Then
                        lstgroups.SelectedNode = TEHNode
                        lstgroups.SelectedNode.Expand()
                    End If
                End If

                Dim rs As ADODB.Recordset
                rs = New ADODB.Recordset
                rs.Open("Select * FROM CARTRIDG WHERE USTR=" & iD, DB7, ADODB.CursorTypeEnum.adOpenDynamic, ADODB.LockTypeEnum.adLockOptimistic)

                Dim uname As String
                With rs
                    .MoveFirst()
                    Do While Not .EOF

                        Dim rs1 As ADODB.Recordset
                        rs1 = New ADODB.Recordset
                        rs1.Open("Select * FROM spr_cart WHERE id=" & .Fields("model").Value, DB7, ADODB.CursorTypeEnum.adOpenDynamic, ADODB.LockTypeEnum.adLockOptimistic)
                        With rs1
                            uname = .Fields("name").Value
                        End With
                        rs1.Close()
                        rs1 = Nothing

                        Dim TEHNodeCP As New TreeNode(uname, 49, 49)
                        TEHNodeCP.Tag = "CRT|" & .Fields("id").Value
                        TEHNode.Nodes.Add(TEHNodeCP)

                        .MoveNext()
                    Loop
                End With
                rs.Close()
                rs = Nothing


            Case "MFU"

                Dim TEHNode As New TreeNode(L_NAME, 8, 8)
                TEHNode.Tag = "C|" & iD
                DepNode.Nodes.Add(TEHNode)

                If Spisan = "1" Or Spisan = "True" Or Spisan = "-1" Then
                    TEHNode.ForeColor = Color.Red

                End If

                If KCKey <> 0 Then
                    If KCKey = iD Then
                        lstgroups.SelectedNode = TEHNode
                        lstgroups.SelectedNode.Expand()
                    End If
                End If

                Dim rs As ADODB.Recordset
                rs = New ADODB.Recordset
                rs.Open("Select * FROM CARTRIDG WHERE USTR=" & iD, DB7, ADODB.CursorTypeEnum.adOpenDynamic, ADODB.LockTypeEnum.adLockOptimistic)

                Dim uname As String
                With rs
                    .MoveFirst()
                    Do While Not .EOF

                        Dim rs1 As ADODB.Recordset
                        rs1 = New ADODB.Recordset
                        rs1.Open("Select * FROM spr_cart WHERE id=" & .Fields("model").Value, DB7, ADODB.CursorTypeEnum.adOpenDynamic, ADODB.LockTypeEnum.adLockOptimistic)
                        With rs1
                            uname = .Fields("name").Value
                        End With
                        rs1.Close()
                        rs1 = Nothing

                        Dim TEHNodeCP As New TreeNode(uname, 49, 49)
                        TEHNodeCP.Tag = "CRT|" & .Fields("id").Value
                        TEHNode.Nodes.Add(TEHNodeCP)

                        .MoveNext()
                    Loop
                End With
                rs.Close()
                rs = Nothing


            Case "KOpir"
                Dim TEHNode As New TreeNode(L_NAME, 9, 9)
                TEHNode.Tag = "C|" & iD
                DepNode.Nodes.Add(TEHNode)

                If Spisan = "1" Or Spisan = "True" Or Spisan = "-1" Then
                    TEHNode.ForeColor = Color.Red

                End If

                If KCKey <> 0 Then
                    If KCKey = iD Then
                        lstgroups.SelectedNode = TEHNode
                        lstgroups.SelectedNode.Expand()
                    End If
                End If

                Dim rs As ADODB.Recordset
                rs = New ADODB.Recordset
                rs.Open("Select * FROM CARTRIDG WHERE USTR=" & iD, DB7, ADODB.CursorTypeEnum.adOpenDynamic, ADODB.LockTypeEnum.adLockOptimistic)

                Dim uname As String
                With rs
                    .MoveFirst()
                    Do While Not .EOF

                        Dim rs1 As ADODB.Recordset
                        rs1 = New ADODB.Recordset
                        rs1.Open("Select * FROM spr_cart WHERE id=" & .Fields("model").Value, DB7, ADODB.CursorTypeEnum.adOpenDynamic, ADODB.LockTypeEnum.adLockOptimistic)
                        With rs1
                            uname = .Fields("name").Value
                        End With
                        rs1.Close()
                        rs1 = Nothing

                        Dim TEHNodeCP As New TreeNode(uname, 49, 49)
                        TEHNodeCP.Tag = "CRT|" & .Fields("id").Value
                        TEHNode.Nodes.Add(TEHNodeCP)

                        .MoveNext()
                    Loop
                End With
                rs.Close()
                rs = Nothing

            Case "FAX"
                Dim TEHNode As New TreeNode(L_NAME, 13, 13)
                TEHNode.Tag = "C|" & iD
                DepNode.Nodes.Add(TEHNode)

                If Spisan = "1" Or Spisan = "True" Or Spisan = "-1" Then
                    TEHNode.ForeColor = Color.Red

                End If

                If KCKey <> 0 Then
                    If KCKey = iD Then
                        lstgroups.SelectedNode = TEHNode
                        lstgroups.SelectedNode.Expand()
                    End If
                End If

                Dim rs As ADODB.Recordset
                rs = New ADODB.Recordset
                rs.Open("Select * FROM CARTRIDG WHERE USTR=" & iD, DB7, ADODB.CursorTypeEnum.adOpenDynamic, ADODB.LockTypeEnum.adLockOptimistic)

                Dim uname As String
                With rs
                    .MoveFirst()
                    Do While Not .EOF

                        Dim rs1 As ADODB.Recordset
                        rs1 = New ADODB.Recordset
                        rs1.Open("Select * FROM spr_cart WHERE id=" & .Fields("model").Value, DB7, ADODB.CursorTypeEnum.adOpenDynamic, ADODB.LockTypeEnum.adLockOptimistic)
                        With rs1
                            uname = .Fields("name").Value
                        End With
                        rs1.Close()
                        rs1 = Nothing

                        Dim TEHNodeCP As New TreeNode(uname, 49, 49)
                        TEHNodeCP.Tag = "CRT|" & .Fields("id").Value
                        TEHNode.Nodes.Add(TEHNodeCP)

                        .MoveNext()
                    Loop
                End With
                rs.Close()
                rs = Nothing


        End Select


    End Sub

    Private Sub frmCartr2_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load


        Call RefFilTreePRN()

        Call frmCartr2_Lang()

        'Call Load_C()

    End Sub

    Public Sub Zap_load(Optional ByVal sXcount As Integer = 0)

        Dim zCOUNT As Integer

        Dim sSQL1 As String
        Dim sSQL As String

        On Error GoTo Error_
        Dim uname As Long
        lvCartZAP.Items.Clear()



        If sXcount = 0 Then
            If LVCart.Items.Count = 0 Then Exit Sub
            Dim z As Integer
            ' Dim rCOUNT As Integer

            For z = 0 To LVCart.SelectedItems.Count - 1
                rCOUNT = (LVCart.SelectedItems(z).Text)
            Next

        Else

            rCOUNT = sXcount

        End If



        Dim rs1 As ADODB.Recordset
        sSQL1 = "SELECT * FROM CARTRIDG WHERE ID=" & rCOUNT
        rs1 = New ADODB.Recordset
        rs1.Open(sSQL1, DB7, ADODB.CursorTypeEnum.adOpenDynamic, ADODB.LockTypeEnum.adLockOptimistic)

        With rs1
            If .Fields("Spisan").Value = False Or .Fields("Spisan").Value = 0 Then
                'A.Icon = 20
                'A.SmallIcon = 20
                btnZapAdd.Enabled = True
                btnZapDel.Enabled = True
            Else
                'A.Icon = 22
                'A.SmallIcon = 22
                btnZapAdd.Enabled = False
                btnZapDel.Enabled = False
            End If

        End With
        rs1.Close()
        rs1 = Nothing

        Dim rs As ADODB.Recordset
        sSQL = "SELECT COUNT(*) AS total_number FROM CARTRIDG_Z"
        rs = New ADODB.Recordset
        rs.Open(sSQL, DB7, ADODB.CursorTypeEnum.adOpenDynamic, ADODB.LockTypeEnum.adLockOptimistic)

        With rs
            zCOUNT = .Fields("total_number").Value
        End With
        rs.Close()
        rs = Nothing

        If zCOUNT > 0 Then

            rs = New ADODB.Recordset
            rs.Open("SELECT * FROM CARTRIDG_Z WHERE ID_C=" & rCOUNT & " ORDER BY DATAZAP DESC", DB7, ADODB.CursorTypeEnum.adOpenDynamic, ADODB.LockTypeEnum.adLockOptimistic)

            Dim intCount As Decimal = 0

            With rs
                .MoveFirst()
                Do While Not .EOF

                    If .Fields("ID_C").Value = rCOUNT Then

                        lvCartZAP.Items.Add(.Fields("id").Value) 'col no. 1

                        If Not IsDBNull(.Fields("Z_N").Value) Then
                            lvCartZAP.Items(CInt(intCount)).SubItems.Add(.Fields("Z_N").Value)
                        Else
                            lvCartZAP.Items(CInt(intCount)).SubItems.Add("")
                        End If

                        If Not IsDBNull(.Fields("datazap").Value) Then
                            lvCartZAP.Items(CInt(intCount)).SubItems.Add(.Fields("datazap").Value)
                        Else
                            lvCartZAP.Items(CInt(intCount)).SubItems.Add("")
                        End If

                        If Not IsDBNull(.Fields("VOST").Value) Then

                            If .Fields("VOST").Value = False Then
                                lvCartZAP.Items(CInt(intCount)).SubItems.Add("Заправлен")
                            Else
                                lvCartZAP.Items(CInt(intCount)).SubItems.Add("Востановлен")
                            End If

                        Else

                            lvCartZAP.Items(CInt(intCount)).SubItems.Add("")

                        End If

                        If Not IsDBNull(.Fields("STOIM").Value) Then
                            lvCartZAP.Items(CInt(intCount)).SubItems.Add(.Fields("STOIM").Value)
                        Else
                            lvCartZAP.Items(CInt(intCount)).SubItems.Add("")
                        End If

                        intCount = intCount + 1


                    End If
                    .MoveNext()
                    'DoEvents
                Loop

            End With





            rs.Close()
            rs = Nothing


        End If


        ResList(Me.lvCartZAP)
        'CARTRIDG_Z.Close
        Exit Sub
Error_:
        Debug.Print(Err.Description)
    End Sub

    Public Sub Load_C(Optional ByVal sID As Integer = 0)

        On Error GoTo Error_

        LVCart.Items.Clear()
        lvCartZAP.Items.Clear()

        Dim sSQL As String



        Dim CARTRIDG As ADODB.Recordset

        If sID = 0 Then

            sSQL = "SELECT * FROM CARTRIDG"
        Else

            sSQL = "SELECT * FROM CARTRIDG where USTR=" & sID
        End If

        CARTRIDG = New ADODB.Recordset
        CARTRIDG.Open(sSQL, DB7, ADODB.CursorTypeEnum.adOpenDynamic, ADODB.LockTypeEnum.adLockOptimistic)



        'Dim CARTRIDG_Z As ADODB.Recordset
        'CARTRIDG_Z = New ADODB.Recordset
        'CARTRIDG_Z.Open("SELECT * FROM CARTRIDG_Z", DB7, ADODB.CursorTypeEnum.adOpenDynamic, ADODB.LockTypeEnum.adLockOptimistic)

        'Dim PROYZV As ADODB.Recordset
        'PROYZV = New ADODB.Recordset
        'PROYZV.Open("SELECT * FROM SPR_PROIZV", DB7, ADODB.CursorTypeEnum.adOpenDynamic, ADODB.LockTypeEnum.adLockOptimistic)

        Dim intCount As Decimal = 0

        With CARTRIDG
            .MoveFirst()
            Do While Not .EOF


                LVCart.Items.Add(.Fields("id").Value) 'col no. 1
                Dim unam1 As Long

                If Not IsDBNull(.Fields("Model").Value) Then unam1 = .Fields("Model").Value

                If Len(unam1) = 0 Then unam1 = 1

                Dim CARTR As ADODB.Recordset
                CARTR = New ADODB.Recordset
                CARTR.Open("SELECT * FROM spr_cart where id =" & unam1, DB7, ADODB.CursorTypeEnum.adOpenDynamic, ADODB.LockTypeEnum.adLockOptimistic)

                With CARTR
                    .MoveFirst()
                    Do While Not .EOF
                        If unam1 = .Fields("ID").Value Then

                            If Not IsDBNull(.Fields("name").Value) Then
                                LVCart.Items(CInt(intCount)).SubItems.Add(.Fields("name").Value)
                            Else
                                LVCart.Items(CInt(intCount)).SubItems.Add("")
                            End If

                        End If
                        .MoveNext()

                    Loop
                End With

                CARTR.Close()
                CARTR = Nothing

                If Not IsDBNull(.Fields("SN").Value) Then
                    LVCart.Items(CInt(intCount)).SubItems.Add(.Fields("SN").Value)
                Else
                    LVCart.Items(CInt(intCount)).SubItems.Add("")
                End If

                If Not IsDBNull(.Fields("data").Value) Then
                    LVCart.Items(CInt(intCount)).SubItems.Add(.Fields("data").Value)
                Else
                    LVCart.Items(CInt(intCount)).SubItems.Add("")
                End If

                Dim uname As String
                If Not IsDBNull(.Fields("USTR").Value) Then uname = .Fields("USTR").Value


                Dim rs As ADODB.Recordset

                rs = New ADODB.Recordset
                rs.Open("SELECT count(*) as t_n FROM kompy where id =" & uname, DB7, ADODB.CursorTypeEnum.adOpenDynamic, ADODB.LockTypeEnum.adLockOptimistic)

                Dim sCounter As String

                With rs

                    sCounter = .Fields("t_n").Value

                End With
                rs.Close()
                rs = Nothing


                If sCounter > 0 Then


                    rs = New ADODB.Recordset
                    rs.Open("SELECT * FROM kompy where id =" & uname, DB7, ADODB.CursorTypeEnum.adOpenDynamic, ADODB.LockTypeEnum.adLockOptimistic)

                    With rs
                        If uname = "0" Then
                        Else
                            .MoveFirst()
                            Do While Not .EOF
                                If uname = .Fields("ID").Value Then

                                    If Not IsDBNull(.Fields("printer_name_1").Value) Then
                                        LVCart.Items(CInt(intCount)).SubItems.Add(.Fields("printer_name_1").Value)
                                    Else
                                        LVCart.Items(CInt(intCount)).SubItems.Add("")
                                    End If

                                    If Not IsDBNull(.Fields("filial").Value) Then
                                        LVCart.Items(CInt(intCount)).SubItems.Add(.Fields("filial").Value)
                                    Else
                                        LVCart.Items(CInt(intCount)).SubItems.Add("")
                                    End If

                                    If Not IsDBNull(.Fields("mesto").Value) Then
                                        LVCart.Items(CInt(intCount)).SubItems.Add(.Fields("mesto").Value)
                                    Else
                                        LVCart.Items(CInt(intCount)).SubItems.Add("")
                                    End If

                                    If Not IsDBNull(.Fields("OTvetstvennyj").Value) Then
                                        LVCart.Items(CInt(intCount)).SubItems.Add(.Fields("OTvetstvennyj").Value)
                                    Else
                                        LVCart.Items(CInt(intCount)).SubItems.Add("")
                                    End If


                                End If
                                .MoveNext()
                                'DoEvents
                            Loop

                        End If
                    End With
                    rs.Close()
                    rs = Nothing

                End If


                If Not IsDBNull(.Fields("prim").Value) Then
                    LVCart.Items(CInt(intCount)).SubItems.Add(.Fields("prim").Value)
                Else
                    LVCart.Items(CInt(intCount)).SubItems.Add("")
                End If


                intCount = intCount + 1

                'Spisan
                'If .Fields("Spisan").Value = False Or .Fields("Spisan").Value = 0 Then
                'A.Icon = 19
                'A.SmallIcon = 19
                ''XPbuscar1.Enabled = True
                ''XPbuscar2.Enabled = True
                'Else
                'A.Icon = 20
                'A.SmallIcon = 20
                ''XPbuscar1.Enabled = False
                ''XPbuscar2.Enabled = False
                'End If

                .MoveNext()
                'DoEvents
            Loop
        End With

        CARTRIDG.Close()
        CARTRIDG = Nothing
        ResList(Me.LVCart)
        'ListViewRavn frmCart.LVCart, frmCart




        Exit Sub
Error_:
        Debug.Print(Err.Description)
    End Sub

    Private Sub frmCartr2_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Activated
        frmMain.SaveInfTehButton.Enabled = False
        frmMain.ToolStripDropDownButton1.Enabled = False
    End Sub

    Private Sub LVCart_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles LVCart.Click
        Call Zap_load()
    End Sub

    Private Sub btnZapReport_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnZapReport.Click
        Dim rs As ADODB.Recordset
        rs = New ADODB.Recordset

        Dim Coun1 As Long

        Dim rscount As ADODB.Recordset 'Объявляем рекордсет
        rscount = New ADODB.Recordset
        rscount.Open("SELECT COUNT(*) AS total_number FROM CARTRIDG_Z", DB7, ADODB.CursorTypeEnum.adOpenDynamic, ADODB.LockTypeEnum.adLockOptimistic)

        With rscount
            Coun1 = .Fields("total_number").Value
        End With

        rscount.Close()
        rscount = Nothing


        If Coun1 > 0 Then


            Select Case sOfficePACK

                Case "OpenOffice.org"


                    Dim objServiceManager, objDesktop As Object 'root objects from OOo API 
                    Dim objCoreReflection, objDocument As Object ' objects from OOo API 
                    Dim objText, objCursor As Object ' objects from OOo API 
                    Dim objTable As Object ' objects from OOo API 
                    Dim objRows, objRow As Object ' objects from OOo API 
                    ' Dim objTextFrame, objSize As Object ' objects from OOo API 
                    ' Dim objFrameText, objFrameTextCursor As Object ' objects from OOo API 

                    objServiceManager = CreateObject("com.sun.star.ServiceManager")
                    'Create the CoreReflection service that is later used to create structs 
                    objCoreReflection = objServiceManager.createInstance("com.sun.star.reflection.CoreReflection")
                    'Create the Desktop 
                    objDesktop = objServiceManager.createInstance("com.sun.star.frame.Desktop")
                    'Open a new empty writer document 
                    Dim args(-1) As Object '<-- initializing the array with a -1 
                    'Dim args(4) As Object 'a Visual Basic array 
                    'args(0) = MakePropertyValue("ReadOnly", True) 
                    ''args(1) = MakePropertyValue("Password", "secret") 
                    'args(1) = MakePropertyValue("hidden", False) 
                    'args(2) = MakePropertyValue("Buttons", False) 
                    'args(3) = MakePropertyValue("Overwrite", False) 
                    objDocument = objDesktop.loadComponentFromURL("private:factory/swriter", "_blank", 0, args)

                    objText = objDocument.getText
                    objCursor = objText.createTextCursor


                    ' replace all

                    objText.insertControlCharacter(objCursor, 0, False)
                    objText.insertString(objCursor, "Заправка картриджей" & vbLf, False)

                    objTable = objDocument.createInstance("com.sun.star.text.TextTable")
                    objTable.Initialize(Coun1 + 1, 5)


                    'Insert the table
                    objText.insertControlCharacter(objCursor, 0, False)
                    objText.insertTextContent(objCursor, objTable, False)

                    'Get first row
                    objRows = objTable.GetRows
                    objRow = objRows.getByIndex(0)

                    'Set the table background color
                    objTable.setPropertyValue("BackTransparent", True)
                    objTable.setPropertyValue("BackColor", 16777215)

                    'Формируем заголовок
                    insertIntoCell("A1", "Порядковый номер", objTable)
                    insertIntoCell("B1", "Дата заправки", objTable)
                    insertIntoCell("C1", "Модель картриджа", objTable)
                    insertIntoCell("D1", "Восстановлен", objTable)
                    insertIntoCell("E1", "Место установки", objTable)


                    rscount = New ADODB.Recordset
                    rscount.Open("SELECT * FROM CARTRIDG_Z", DB7, ADODB.CursorTypeEnum.adOpenDynamic, ADODB.LockTypeEnum.adLockOptimistic)

                    Dim intj As Decimal

                    Dim A, b, c, d, e1 As String
                    intj = 2
                    With rscount
                        .MoveFirst()
                        Do While Not .EOF = True

                            A = "A" & intj
                            insertIntoCell(A, .Fields("id"), objTable)
                            b = "B" & intj
                            insertIntoCell(b, .Fields("DATAZAP"), objTable)
                            c = "C" & intj

                            Dim uname As Long
                            Dim uname1 As String
                            Dim uname2 As Long
                            Dim FF As String
                            Dim mm As String

                            uname = .Fields("ID_C").Value


                            'Dim rs As ADODB.Recordset 'Объявляем рекордсет
                            rs = New ADODB.Recordset
                            rs.Open("SELECT model, ustr FROM CARTRIDG WHERE id =" & uname, DB7, ADODB.CursorTypeEnum.adOpenDynamic, ADODB.LockTypeEnum.adLockOptimistic)
                            With rs
                                uname = .Fields("model").Value
                                uname2 = .Fields("ustr").Value

                            End With
                            rs.Close()
                            rs = Nothing

                            rs = New ADODB.Recordset
                            rs.Open("SELECT name FROM spr_cart WHERE id =" & uname, DB7, ADODB.CursorTypeEnum.adOpenDynamic, ADODB.LockTypeEnum.adLockOptimistic)
                            With rs
                                uname1 = .Fields("name").Value
                            End With
                            rs.Close()
                            rs = Nothing

                            insertIntoCell(c, uname1, objTable)
                            d = "D" & intj


                            If .Fields("VOST").Value = False Or .Fields("VOST").Value = 0 Then
                                uname1 = "Нет"
                            Else
                                uname1 = "Да"
                            End If
                            insertIntoCell(d, uname1, objTable)

                            If uname2 = 0 Or Len(uname2) = 0 Then

                            Else
                                rs = New ADODB.Recordset
                                rs.Open("SELECT filial, mesto FROM kompy WHERE id =" & uname2, DB7, ADODB.CursorTypeEnum.adOpenDynamic, ADODB.LockTypeEnum.adLockOptimistic)
                                With rs
                                    FF = .Fields("filial").Value
                                    mm = .Fields("mesto").Value
                                End With
                                rs.Close()
                                rs = Nothing

                            End If


                            e1 = "E" & intj
                            insertIntoCell(e1, FF & "/" & mm, objTable)
                            FF = ""
                            mm = ""


                            intj = intj + 1

                            .MoveNext()
                        Loop
                    End With
                    rscount.Close()
                    rscount = Nothing


                    objText.insertControlCharacter(objCursor, 0, False)


                Case Else

                    Dim oWord As Word.Application
                    Dim oDoc As Word.Document
                    Dim oTable As Word.Table
                    Dim oPara1 As Word.Paragraph, oPara2 As Word.Paragraph
                    Dim oPara3 As Word.Paragraph, oPara4 As Word.Paragraph
                    Dim oRng As Word.Range
                    Dim oShape As Word.InlineShape
                    Dim oChart As Object
                    Dim Pos As Double


                    'Start Word and open the document template.
                    oWord = CreateObject("Word.Application")
                    oWord.Visible = True
                    oDoc = oWord.Documents.Add

                    'Insert a paragraph at the beginning of the document.
                    oPara1 = oDoc.Content.Paragraphs.Add
                    oPara1.Range.Text = "Заправка картриджей"
                    oPara1.Range.Font.Bold = True
                    oPara1.Format.SpaceAfter = 24    '24 pt spacing after paragraph.
                    oPara1.Range.InsertParagraphAfter()


                    oTable = oDoc.Tables.Add(oDoc.Bookmarks.Item("\endofdoc").Range, Coun1 + 1, 5)
                    oTable.Range.ParagraphFormat.SpaceAfter = 6

                    oTable.Cell(1, 1).Range.Text = "Порядковый номер"
                    oTable.Cell(1, 2).Range.Text = "Дата заправки"
                    oTable.Cell(1, 3).Range.Text = "Модель картриджа"
                    oTable.Cell(1, 4).Range.Text = "Восстановлен"
                    oTable.Cell(1, 5).Range.Text = "Место установки"


                    rscount = New ADODB.Recordset
                    rscount.Open("SELECT * FROM CARTRIDG_Z", DB7, ADODB.CursorTypeEnum.adOpenDynamic, ADODB.LockTypeEnum.adLockOptimistic)

                    Dim intj As Decimal

                    Dim A, b, c, d, e1 As String
                    intj = 2
                    With rscount
                        .MoveFirst()
                        Do While Not .EOF = True



                            oTable.Cell(intj, 1).Range.Text = .Fields("id").Value

                            oTable.Cell(intj, 2).Range.Text = .Fields("DATAZAP").Value



                            Dim uname As Long
                            Dim uname1 As String
                            Dim uname2 As Long
                            Dim FF As String
                            Dim mm As String

                            uname = .Fields("ID_C").Value


                            'Dim rs As ADODB.Recordset 'Объявляем рекордсет
                            rs = New ADODB.Recordset
                            rs.Open("SELECT model, ustr FROM CARTRIDG WHERE id =" & uname, DB7, ADODB.CursorTypeEnum.adOpenDynamic, ADODB.LockTypeEnum.adLockOptimistic)
                            With rs
                                uname = .Fields("model").Value
                                uname2 = .Fields("ustr").Value

                            End With
                            rs.Close()
                            rs = Nothing

                            rs = New ADODB.Recordset
                            rs.Open("SELECT name FROM spr_cart WHERE id =" & uname, DB7, ADODB.CursorTypeEnum.adOpenDynamic, ADODB.LockTypeEnum.adLockOptimistic)
                            With rs
                                uname1 = .Fields("name").Value
                            End With
                            rs.Close()
                            rs = Nothing

                            'insertIntoCell(c, uname1, objTable)

                            oTable.Cell(intj, 3).Range.Text = uname1


                            d = "D" & intj

                            On Error Resume Next

                            If .Fields("VOST").Value = False Or .Fields("VOST").Value = 0 Then
                                uname1 = "Нет"
                            Else
                                uname1 = "Да"
                            End If


                            oTable.Cell(intj, 4).Range.Text = uname1


                            If uname2 = 0 Or Len(uname2) = 0 Then

                            Else
                                rs = New ADODB.Recordset
                                rs.Open("SELECT filial, mesto FROM kompy WHERE id =" & uname2, DB7, ADODB.CursorTypeEnum.adOpenDynamic, ADODB.LockTypeEnum.adLockOptimistic)
                                With rs
                                    FF = .Fields("filial").Value
                                    mm = .Fields("mesto").Value
                                End With
                                rs.Close()
                                rs = Nothing

                            End If


                            oTable.Cell(intj, 5).Range.Text = FF & "/" & mm

                            FF = ""
                            mm = ""


                            intj = intj + 1

                            .MoveNext()
                        Loop
                    End With
                    rscount.Close()
                    rscount = Nothing


            End Select

        End If



    End Sub


    Private Sub LVCart_ColumnClick(ByVal sender As Object, ByVal e As System.Windows.Forms.ColumnClickEventArgs) Handles LVCart.ColumnClick
        Dim new_sorting_column As ColumnHeader = _
          LVCart.Columns(e.Column)
        Dim sort_order As System.Windows.Forms.SortOrder
        If m_SortingColumn Is Nothing Then
            sort_order = SortOrder.Ascending
        Else
            If new_sorting_column.Equals(m_SortingColumn) Then
                If m_SortingColumn.Text.StartsWith("> ") Then
                    sort_order = SortOrder.Descending
                Else
                    sort_order = SortOrder.Ascending
                End If
            Else
                sort_order = SortOrder.Ascending
            End If

            m_SortingColumn.Text = m_SortingColumn.Text.Substring(2)
        End If

        m_SortingColumn = new_sorting_column
        If sort_order = SortOrder.Ascending Then
            m_SortingColumn.Text = "> " & m_SortingColumn.Text
        Else
            m_SortingColumn.Text = "< " & m_SortingColumn.Text
        End If

        LVCart.ListViewItemSorter = New ListViewComparer(e.Column, sort_order)

        LVCart.Sort()
    End Sub

    Private Sub LVCart_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles LVCart.DoubleClick
        Dim z As Integer

        'Dim rCOUNT As String

        For z = 0 To LVCart.SelectedItems.Count - 1
            rCOUNT = (LVCart.SelectedItems(z).Text)
        Next

        LOAD_CRR(rCOUNT)
    End Sub

    Public Sub LOAD_CRR(ByVal sSId As String)

        Dim uname As String
        'Dim sSId As String

        'On Error GoTo Error_
        On Error Resume Next
        frmCartr_ADD.btnAdd.Text = "Сохранить"

        Dim CARTRIDG As ADODB.Recordset
        CARTRIDG = New ADODB.Recordset
        CARTRIDG.Open("SELECT * FROM CARTRIDG WHERE id =" & sSId, DB7, ADODB.CursorTypeEnum.adOpenDynamic, ADODB.LockTypeEnum.adLockOptimistic)

        With CARTRIDG

            frmCartr_ADD.EDTRCART = True
            frmCartr_ADD.lblRealNumber.Text = .Fields("id").Value
            If Not IsDBNull(.Fields("SN").Value) Then frmCartr_ADD.txtSerNumb.Text = .Fields("SN").Value
            uname = .Fields("Proizv").Value

            Dim PROYZV As ADODB.Recordset
            PROYZV = New ADODB.Recordset
            PROYZV.Open("SELECT * FROM SPR_PROIZV WHERE id=" & uname, DB7, ADODB.CursorTypeEnum.adOpenDynamic, ADODB.LockTypeEnum.adLockOptimistic)
            With PROYZV
                frmCartr_ADD.cmbProizv.Text = .Fields("Proizv").Value
            End With
            PROYZV.Close()
            PROYZV = Nothing


            If Not IsDBNull(.Fields("TIP").Value) Then frmCartr_ADD.cmbTipC.Text = .Fields("TIP").Value
            Dim zaname As Long

            zaname = .Fields("Model").Value

            Dim CARTR As ADODB.Recordset
            CARTR = New ADODB.Recordset
            CARTR.Open("SELECT * FROM spr_cart WHERE id=" & zaname, DB7, ADODB.CursorTypeEnum.adOpenDynamic, ADODB.LockTypeEnum.adLockOptimistic)

            With CARTR
                frmCartr_ADD.cmbModC.Text = .Fields("name").Value
            End With

            CARTR.Close()
            CARTR = Nothing

            If Not IsDBNull(.Fields("USTR").Value) Then uname = .Fields("USTR").Value

            If uname = 0 Then
            Else
                Dim rs As ADODB.Recordset
                rs = New ADODB.Recordset
                rs.Open("SELECT * FROM kompy WHERE id=" & uname, DB7, ADODB.CursorTypeEnum.adOpenDynamic, ADODB.LockTypeEnum.adLockOptimistic)

                With rs
                    frmCartr_ADD.cmbSostUstr.Text = .Fields("PRINTER_NAME_1").Value & " (" & .Fields("filial").Value & "/" & .Fields("mesto").Value & ")" & " № " & .Fields("id").Value
                End With

                rs.Close()
                rs = Nothing

            End If

            uname = 0
            If Not IsDBNull(.Fields("PROD")) Then uname = .Fields("PROD").Value

            If uname = 0 Then
            Else
                Dim Postav As ADODB.Recordset
                Postav = New ADODB.Recordset
                Postav.Open("SELECT * FROM SPR_Postav WHERE id=" & uname, DB7, ADODB.CursorTypeEnum.adOpenDynamic, ADODB.LockTypeEnum.adLockOptimistic)

                With Postav
                    If Not IsDBNull(.Fields("Name").Value) Then
                        frmCartr_ADD.cmbSaler.Text = .Fields("Name").Value
                    Else
                        frmCartr_ADD.cmbSaler.Text = ""

                    End If

                End With

                Postav.Close()
                Postav = Nothing

            End If

            frmCartr_ADD.txtSaleNumb.Text = .Fields("SCHET").Value
            frmCartr_ADD.txtCashe.Text = .Fields("Cena").Value
            frmCartr_ADD.dtSale.Text = .Fields("data").Value

            Select Case .Fields("NZap").Value

                Case True
                    frmCartr_ADD.chkNezap.Checked = 1
                Case False
                    frmCartr_ADD.chkNezap.Checked = 0

                Case 1
                    frmCartr_ADD.chkNezap.Checked = 1
                Case 0
                    frmCartr_ADD.chkNezap.Checked = 0
            End Select


            Select Case .Fields("NeZap").Value

                Case True
                    frmCartr_ADD.chkNZ.Checked = 1
                Case False
                    frmCartr_ADD.chkNZ.Checked = 0

                Case 1
                    frmCartr_ADD.chkNZ.Checked = 1
                Case 0
                    frmCartr_ADD.chkNZ.Checked = 0
            End Select


            Select Case .Fields("Iznos").Value

                Case True
                    frmCartr_ADD.chkIznos.Checked = 1
                Case False
                    frmCartr_ADD.chkIznos.Checked = 0

                Case 1
                    frmCartr_ADD.chkIznos.Checked = 1
                Case 0
                    frmCartr_ADD.chkIznos.Checked = 0
            End Select

            Select Case .Fields("Spisan").Value

                Case True
                    frmCartr_ADD.chkSPS.Checked = 1
                Case False
                    frmCartr_ADD.chkSPS.Checked = 0

                Case 1
                    frmCartr_ADD.chkSPS.Checked = 1
                Case 0
                    frmCartr_ADD.chkSPS.Checked = 0
            End Select

            Select Case .Fields("NaSpisanie").Value

                Case True
                    frmCartr_ADD.chkNaSP.Checked = 1
                Case False
                    frmCartr_ADD.chkNaSP.Checked = 0

                Case 1
                    frmCartr_ADD.chkNaSP.Checked = 1
                Case 0
                    frmCartr_ADD.chkNaSP.Checked = 0
            End Select

            If Not IsDBNull(.Fields("PRIM").Value) Then frmCartr_ADD.txtMemo.Text = .Fields("PRIM").Value
            frmCartr_ADD.EDTIDTr = .Fields("id").Value

        End With

        frmCartr_ADD.ShowDialog(Me)

        Exit Sub
Error_:
        'frmCartr_ADD.Show(vbModal)
        MsgBox(Err.Description)
    End Sub

    Private Sub btnCartAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCartAdd.Click

        If cCOUNT = 0 Then Exit Sub
        frmCartr_ADD.btnAdd.Text = "Добавить"
        frmCartr_ADD.CRTFU = False

        frmCartr_ADD.EDTRCART = False
        frmCartr_ADD.chkNaSP.Checked = 0
        frmCartr_ADD.chkSPS.Checked = 0
        frmCartr_ADD.chkIznos.Checked = 0
        frmCartr_ADD.chkNZ.Checked = 0
        frmCartr_ADD.chkNezap.Checked = 0
        frmCartr_ADD.txtCashe.Text = 0
        frmCartr_ADD.txtSaleNumb.Text = ""
        frmCartr_ADD.cmbSaler.Text = ""
        frmCartr_ADD.cmbSostUstr.Text = ""
        frmCartr_ADD.cmbModC.Text = ""
        frmCartr_ADD.cmbTipC.Text = ""
        frmCartr_ADD.cmbProizv.Text = ""
        frmCartr_ADD.txtSerNumb.Text = ""
        frmCartr_ADD.lblRealNumber.Text = ""
        frmCartr_ADD.txtMemo.Text = ""
        frmCartr_ADD.dtSale.Value = Date.Today

        frmCartr_ADD.ShowDialog(Me)
    End Sub

    Private Sub txtMonth_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtMonth.ValueChanged

        Dim uname As Long
        Dim uname1 As String
        Dim umonth As String
        Dim smonth As String
        Dim syear As String

        uname = 0
        Dim rs As ADODB.Recordset
        rs = New ADODB.Recordset
        rs.Open("UPDATE CARTRIDG_Z SET STOIM='0' WHERE STOIM=' '", DB7, ADODB.CursorTypeEnum.adOpenDynamic, ADODB.LockTypeEnum.adLockOptimistic)
        rs = Nothing


        umonth = txtMonth.Value

        If Len(umonth) = 1 Then umonth = "0" & umonth
        Dim strAnimals As String
        Dim iCounter As Integer
        Dim arrAnimals() As String


        On Error GoTo Error_
        Dim rs1 As ADODB.Recordset
        rs1 = New ADODB.Recordset
        rs1.Open("SELECT STOIM, DATAZAP FROM CARTRIDG_Z", DB7, ADODB.CursorTypeEnum.adOpenDynamic, ADODB.LockTypeEnum.adLockOptimistic)

        With rs1
            .MoveFirst()
            Do While Not .EOF

                strAnimals = .Fields("DATAZAP").Value
                arrAnimals = Split(strAnimals, ".")

                For iCounter = LBound(arrAnimals) To UBound(arrAnimals)
                    smonth = arrAnimals(1)
                    syear = arrAnimals(2)
                Next

                If smonth = umonth And syear = Date.Today.Year Then

                    uname1 = .Fields("STOIM").Value

                    If Len(uname1) <> 0 Then

                        uname = (uname + Val(uname1))

                    End If
                End If

                .MoveNext()
            Loop
        End With

        rs1.Close()
        rs1 = Nothing

        'FilePathName
        lblSum.Text = "Потрачено на заправку в"
        lblSum2.Text = "месяце" & ": " & uname & " " & "руб."

        Exit Sub
Error_:
        lblSum.Text = "Потрачено на заправку в"
        lblSum2.Text = "месяце" & ": " & uname & " " & "руб."
        'MsgBox(Err.Description)
    End Sub

    Private Sub btnZapAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnZapAdd.Click
        If LVCart.Items.Count = 0 Then Exit Sub

        Dim z As Integer
        'Dim rCOUNT As Integer

        For z = 0 To LVCart.SelectedItems.Count - 1
            rCOUNT = (LVCart.SelectedItems(z).Text)
        Next

        If rCOUNT = 0 Then Exit Sub

        Dim C As Control

        For Each C In frmCartr_Add_Zap.Controls
            If TypeOf C Is TextBox Then C.Text = ""
            If TypeOf C Is ComboBox Then C.Text = ""
            If TypeOf C Is NumericUpDown Then C.Text = 0
        Next C

        C = Nothing

        frmCartr_Add_Zap.EDTRCARTZ = False
        frmCartr_Add_Zap.ShowDialog(Me)



    End Sub

    Private Sub lvCartZAP_ColumnClick(ByVal sender As Object, ByVal e As System.Windows.Forms.ColumnClickEventArgs) Handles lvCartZAP.ColumnClick
        Dim new_sorting_column As ColumnHeader = _
          lvCartZAP.Columns(e.Column)
        Dim sort_order As System.Windows.Forms.SortOrder
        If m_SortingColumn Is Nothing Then
            sort_order = SortOrder.Ascending
        Else
            If new_sorting_column.Equals(m_SortingColumn) Then
                If m_SortingColumn.Text.StartsWith("> ") Then
                    sort_order = SortOrder.Descending
                Else
                    sort_order = SortOrder.Ascending
                End If
            Else
                sort_order = SortOrder.Ascending
            End If

            m_SortingColumn.Text = m_SortingColumn.Text.Substring(2)
        End If

        m_SortingColumn = new_sorting_column
        If sort_order = SortOrder.Ascending Then
            m_SortingColumn.Text = "> " & m_SortingColumn.Text
        Else
            m_SortingColumn.Text = "< " & m_SortingColumn.Text
        End If

        lvCartZAP.ListViewItemSorter = New ListViewComparer(e.Column, sort_order)

        lvCartZAP.Sort()
    End Sub

    Private Sub lvCartZAP_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles lvCartZAP.DoubleClick
        If lvCartZAP.Items.Count = 0 Then Exit Sub

        Dim z As Integer

        For z = 0 To lvCartZAP.SelectedItems.Count - 1
            zCOUNT = (lvCartZAP.SelectedItems(z).Text)
        Next

        frmCartr_Add_Zap.EDTRCARTZ = True

        Dim rs As ADODB.Recordset
        rs = New ADODB.Recordset

        rs.Open("SELECT * FROM CARTRIDG_Z where id=" & zCOUNT, DB7, ADODB.CursorTypeEnum.adOpenDynamic, ADODB.LockTypeEnum.adLockOptimistic)


        With rs
            frmCartr_Add_Zap.lblRealNumber.Text = .Fields("Z_N").Value
            'frmCartr_Add_Zap.cmbPost.Text = .Fields("Z_N").Value
            frmCartr_Add_Zap.txtAvR.Text = .Fields("AKTVR").Value
            frmCartr_Add_Zap.txtCashe.Text = .Fields("STOIM").Value
            frmCartr_Add_Zap.txtPage.Text = .Fields("Paper").Value
            frmCartr_Add_Zap.chkRef.Checked = .Fields("VOST").Value
            frmCartr_Add_Zap.dtAvR.Value = .Fields("DATAAKT").Value
            frmCartr_Add_Zap.dtDateZ.Value = .Fields("DATAZAP").Value

            Dim rs1 As ADODB.Recordset

            rs1 = New ADODB.Recordset
            rs1.Open("SELECT count(*) as t_n FROM SPR_Postav WHERE ID=" & .Fields("SC").Value, DB7, ADODB.CursorTypeEnum.adOpenDynamic, ADODB.LockTypeEnum.adLockOptimistic)
            Dim sCCC As String
            With rs1
                sCCC = .Fields("t_n").Value
            End With
            rs1.Close()
            rs1 = Nothing





            If sCCC > 0 Then

                rs1 = New ADODB.Recordset
                rs1.Open("SELECT * FROM SPR_Postav WHERE ID=" & .Fields("SC").Value, DB7, ADODB.CursorTypeEnum.adOpenDynamic, ADODB.LockTypeEnum.adLockOptimistic)

                With rs1

                    If Not IsDBNull(.Fields("Name").Value) Then frmCartr_Add_Zap.cmbPost.Text = .Fields("Name").Value

                End With
                rs1.Close()
                rs1 = Nothing

            End If

        End With

        rs.Close()
        rs = Nothing


        frmCartr_Add_Zap.ShowDialog(Me)

    End Sub

    Private Sub frmCartr2_Resize(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Resize

        Call RESIZER()

    End Sub

    Private Sub RESIZER()
        LVCart.Height = GroupBox1.Height - 70
        lvCartZAP.Height = GroupBox2.Height - 70

        btnCartAdd.Top = GroupBox1.Height - 30
        btnCartDel.Top = GroupBox1.Height - 30

        btnZapAdd.Top = GroupBox2.Height - 30
        btnZapDel.Top = GroupBox2.Height - 30
        btnZapReport.Top = GroupBox2.Height - 30

        txtMonth.Top = GroupBox1.Height - 32
        lblSum.Top = GroupBox1.Height - 32
        lblSum2.Top = GroupBox1.Height - 32
        chkAll.Top = GroupBox1.Height - 30
    End Sub

    Private Sub lstGroups_AfterSelect(ByVal sender As System.Object, ByVal e As System.Windows.Forms.TreeViewEventArgs) Handles lstGroups.AfterSelect
        Me.Cursor = Cursors.WaitCursor
        Dim d() As String

        d = Split(lstGroups.SelectedNode.Tag, "|")

        Select Case d(0)

            Case "C"
                LVCart.Visible = True
                Load_C(d(1))

                cCOUNT = d(1)

            Case "CRT"

                'cCOUNT = d(1)
                Zap_load(d(1))

            Case Else

                cCOUNT = 0

        End Select

        Me.Cursor = Cursors.Default

    End Sub

    Private Sub TableLayoutPanel1_Resize(ByVal sender As Object, ByVal e As System.EventArgs) Handles TableLayoutPanel1.Resize
        Call RESIZER()
    End Sub

    Private Sub LVCart_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LVCart.SelectedIndexChanged

    End Sub

    Private Sub btnCartDel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCartDel.Click
        If LVCart.Items.Count = 0 Then Exit Sub

        Dim r1COUNT As Integer

        Dim z As Integer

        For z = 0 To LVCart.SelectedItems.Count - 1
            r1COUNT = (LVCart.SelectedItems(z).Text)
        Next

        Dim rs1 As ADODB.Recordset
        rs1 = New ADODB.Recordset

        rs1.Open("Delete FROM CARTRIDG WHERE id=" & r1COUNT, DB7, ADODB.CursorTypeEnum.adOpenDynamic, ADODB.LockTypeEnum.adLockOptimistic)

        rs1 = Nothing

        rs1 = New ADODB.Recordset

        rs1.Open("Delete FROM CARTRIDG_Z WHERE id_c=" & r1COUNT, DB7, ADODB.CursorTypeEnum.adOpenDynamic, ADODB.LockTypeEnum.adLockOptimistic)

        rs1 = Nothing


        'Call SaveActivityToLogDB("Удаление ремонта - " & " объект - " & lstGroups.SelectedNode.Text & " установлен " & unamZ)



        Call Load_C(cCOUNT)


    End Sub

    Private Sub chkAll_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkAll.CheckedChanged

        If chkAll.Checked = True Then
            Load_C(0)

        Else

            If cCOUNT <> 0 Then
                Load_C(cCOUNT)
            Else

                LVCart.Items.Clear()

            End If
        End If


    End Sub

    Private Sub lvCartZAP_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lvCartZAP.SelectedIndexChanged
        
    End Sub

    Private Sub btnZapDel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnZapDel.Click

    End Sub
End Class