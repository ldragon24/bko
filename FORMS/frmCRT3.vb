Imports Microsoft.Office.Interop.Word

Public Class frmCRT3
    Public rCOUNT As Decimal
    Public zCOUNT As Decimal
    Public cCOUNT As Integer
    Private m_SortingColumn As ColumnHeader
    Public EDTRCART As Boolean
    Public EDTIDTr As Decimal
    Public CRTFU As Boolean
    Public pDRAG As Boolean
    Private cPREF As String
    Private Sav As Boolean
    Private DV As Boolean
    Private sTEXT As String
    Private zPREF As String
    Private zCC As String
    Private search_ As Boolean
    Private OneStart As Decimal = 0


    Private Sub RefFilTreePRN()
        On Error GoTo ERR1

        lstGroups.HideSelection = False

        On Error Resume Next

        Dim sTEN As String
        Dim sVISIBLE As String
        Dim sSQL1 As String
        Dim sSQL2 As String
        Dim sSQL3 As String
        Dim sSQL4 As String
        Dim sSQL5 As String

        Dim iA1, iA2, iA3, iA4, iA5, iA6 As String

        System.Windows.Forms.Application.DoEvents()

        Dim objIniFile As New IniFile(PrPath & "base.ini")
        sVISIBLE = objIniFile.GetString("general", "VisibleALL", "")
        KCKey = objIniFile.GetString("general", "DK", 0)
        DCKey = objIniFile.GetString("general", "Default", 0)
        lstGroups.Nodes.Clear()

        'Select Case sICONS

        '    Case "32*32"

        '        lstGroups.ImageList = frmComputers.ImageList11

        '    Case Else

        '        lstGroups.ImageList = frmComputers.ilsCommands

        'End Select

        lstGroups.ImageList = frmComputers.ilsCommands


        Dim zBranche As String
        zBranche = objIniFile.GetString("general", "branche", "")

        Dim LNGIniFile As New IniFile(sLANGPATH)

        If Len(zBranche) = 0 Or zBranche = LNGIniFile.GetString("frmComputers", "MSG53", "Все") Then

            zBranche = "0"

        Else


        End If


        Dim rs As Recordset
        Dim rs2 As Recordset
        Dim rs3 As Recordset
        Dim rs4 As Recordset
        Dim rs5 As Recordset
        Dim rs6 As Recordset
        Dim rs7 As Recordset

        rs3 = New Recordset
        rs6 = New Recordset


        Dim strItemText As String
        Dim unamS2, unamS As Integer


        rs7 = New Recordset
        rs7.Open("SELECT count(*) as t_nim FROM SPR_KAB", DB7, CursorTypeEnum.adOpenDynamic,
                 LockTypeEnum.adLockOptimistic)

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

            rs7 = New Recordset
            rs7.Open(sSQL5, DB7, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic)
        End If


        'Компы


        rs6.Open("SELECT count(*) as t_n FROM SPR_MESTO", DB7, CursorTypeEnum.adOpenDynamic,
                 LockTypeEnum.adLockOptimistic)

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
        Dim rsG As Recordset
        rsG = New Recordset

        rsG.Open("SELECT * FROM CONFIGURE", DB7, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic)
        Dim ORG As String

        With rsG
            If Not IsDBNull(.Fields("ORG").Value) Then ORG = .Fields("ORG").Value
        End With

        rsG.Close()
        rsG = Nothing

        Dim nodeRoot As New TreeNode(ORG, 0, 0)
        nodeRoot.Tag = "ROOT" & GENID()
        lstGroups.Nodes.Add(nodeRoot)

        'Application.DoEvents()
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
                'Application.DoEvents()
                unameS = .Fields("filial").Value

                Dim sTeh As String
                sSQL4 = "SELECT count(*) as t_n FROM kompy WHERE filial ='" & unameS & "' AND tiptehn ='Printer'"
                rs3 = New Recordset
                rs3.Open(sSQL4, DB7, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic)

                With rs3
                    sTeh = .Fields("t_n").Value
                End With
                rs3.Close()
                rs3 = Nothing

                sSQL4 = "SELECT count(*) as t_n FROM kompy WHERE filial ='" & unameS & "' AND tiptehn ='KOpir'"
                rs3 = New Recordset
                rs3.Open(sSQL4, DB7, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic)

                With rs3
                    sTeh = sTeh + .Fields("t_n").Value
                End With
                rs3.Close()
                rs3 = Nothing

                sSQL4 = "SELECT count(*) as t_n FROM kompy WHERE filial ='" & unameS & "' AND tiptehn ='MFU'"
                rs3 = New Recordset
                rs3.Open(sSQL4, DB7, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic)

                With rs3
                    sTeh = sTeh + .Fields("t_n").Value
                End With
                rs3.Close()
                rs3 = Nothing

                sSQL4 = "SELECT count(*) as t_n FROM kompy WHERE filial ='" & unameS & "' AND tiptehn ='FAX'"
                rs3 = New Recordset
                rs3.Open(sSQL4, DB7, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic)

                With rs3
                    sTeh = sTeh + .Fields("t_n").Value
                End With
                rs3.Close()
                rs3 = Nothing

                If sTeh > 0 Then

                    Dim BrancheNode As New TreeNode(.Fields("filial").Value, 0, 0)
                    BrancheNode.Tag = "G|" & .Fields("id").Value
                    sTEN = "G|" & .Fields("id").Value
                    nodeRoot.Nodes.Add(BrancheNode)

                    unameS = .Fields("filial").Value

                    If KCKey = 0 And Len(DCKey) <> 0 Then

                        If DCKey = .Fields("id").Value Then
                            lstGroups.SelectedNode = BrancheNode
                            lstGroups.SelectedNode.Expand()
                        End If
                    End If

                    BrancheNode.ForeColor = Color.DarkBlue
                    'BrancheNode.NodeFont = New Font(BrancheNode.NodeFont, FontStyle.Bold)


                    'Вставляем технику если есть
                    Dim cFil As String
                    sSQL4 = "SELECT count(*) as t_n FROM kompy WHERE filial ='" & unameS & "' AND mesto =''"
                    rs3 = New Recordset
                    rs3.Open(sSQL4, DB7, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic)
                    With rs3
                        cFil = .Fields("t_n").Value
                    End With
                    rs3.Close()
                    rs3 = Nothing


                    If cFil <> 0 Then

                        Dim sText As String = objIniFile.GetString("general", "Tree_S", 0)

                        Select Case sText

                            Case 0

                                sSQL4 =
                                    "SELECT id, mesto, filial, tip_compa, tiptehn, PSEVDONIM, NET_NAME, kabn, Spisan, OS FROM kompy WHERE filial ='" &
                                    unameS & "' AND mesto ='' AND tiptehn <>'PC' ORDER BY PSEVDONIM, tiptehn"

                            Case 1

                                sSQL4 =
                                    "SELECT id, mesto, filial, tip_compa, tiptehn, PSEVDONIM, NET_NAME, kabn, Spisan, OS FROM kompy WHERE filial ='" &
                                    unameS & "' AND mesto ='' AND tiptehn <>'PC' ORDER BY tiptehn, PSEVDONIM"

                        End Select


                        rs3 = New Recordset
                        rs3.Open(sSQL4, DB7, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic)

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
                                unameS2 = .Fields("N_Otd").Value


                                sSQL4 = "SELECT count(*) as t_n FROM kompy WHERE filial ='" & unameS & "' AND mesto ='" &
                                        unameS2 & "' AND tiptehn ='Printer'"
                                rs3 = New Recordset
                                rs3.Open(sSQL4, DB7, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic)

                                With rs3
                                    sTeh = .Fields("t_n").Value
                                End With
                                rs3.Close()
                                rs3 = Nothing

                                sSQL4 = "SELECT count(*) as t_n FROM kompy WHERE filial ='" & unameS & "' AND mesto ='" &
                                        unameS2 & "' AND tiptehn ='KOpir'"
                                rs3 = New Recordset
                                rs3.Open(sSQL4, DB7, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic)

                                With rs3
                                    sTeh = sTeh + .Fields("t_n").Value
                                End With
                                rs3.Close()
                                rs3 = Nothing

                                sSQL4 = "SELECT count(*) as t_n FROM kompy WHERE filial ='" & unameS & "' AND mesto ='" &
                                        unameS2 & "' AND tiptehn ='MFU'"
                                rs3 = New Recordset
                                rs3.Open(sSQL4, DB7, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic)

                                With rs3
                                    sTeh = sTeh + .Fields("t_n").Value
                                End With
                                rs3.Close()
                                rs3 = Nothing

                                sSQL4 = "SELECT count(*) as t_n FROM kompy WHERE filial ='" & unameS & "' AND mesto ='" &
                                        unameS2 & "' AND tiptehn ='FAX'"
                                rs3 = New Recordset
                                rs3.Open(sSQL4, DB7, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic)

                                With rs3
                                    sTeh = sTeh + .Fields("t_n").Value
                                End With
                                rs3.Close()
                                rs3 = Nothing

                                Dim DepatrmentNode As New TreeNode(.Fields("N_Otd").Value, 1, 1)

                                If sTeh > 0 Then


                                    DepatrmentNode.Tag = "O|" & .Fields("id").Value
                                    sTEN = "O|" & .Fields("id").Value
                                    BrancheNode.Nodes.Add(DepatrmentNode)
                                    unameS2 = .Fields("N_Otd").Value

                                    If KCKey = 0 And Len(DCKey) <> 0 Then

                                        If DCKey = .Fields("id").Value Then
                                            lstGroups.SelectedNode = DepatrmentNode
                                            lstGroups.SelectedNode.Expand()
                                        End If
                                    End If

                                    DepatrmentNode.ForeColor = Color.DarkGreen
                                    'DepatrmentNode.NodeFont = New Font(DepatrmentNode.NodeFont, FontStyle.Italic)


                                    sSQL4 = "SELECT count(*) as t_n FROM kompy WHERE filial ='" & unameS &
                                            "' AND mesto ='" & unameS2 & "' AND kabn=''"
                                    rs3 = New Recordset
                                    rs3.Open(sSQL4, DB7, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic)
                                    With rs3
                                        cFil = .Fields("t_n").Value
                                    End With
                                    rs3.Close()
                                    rs3 = Nothing


                                    If cFil <> 0 Then

                                        Dim sText As String = objIniFile.GetString("general", "Tree_S", 0)

                                        Select Case sText

                                            Case 0

                                                sSQL4 =
                                                    "SELECT id, mesto, filial, tip_compa, tiptehn, PSEVDONIM, NET_NAME, kabn, Spisan, OS FROM kompy WHERE filial ='" &
                                                    unameS & "' AND mesto ='" & unameS2 &
                                                    "' AND kabn='' AND tiptehn <>'PC' ORDER BY PSEVDONIM, tiptehn"

                                            Case 1

                                                sSQL4 =
                                                    "SELECT id, mesto, filial, tip_compa, tiptehn, PSEVDONIM, NET_NAME, kabn, Spisan, OS FROM kompy WHERE filial ='" &
                                                    unameS & "' AND mesto ='" & unameS2 &
                                                    "' AND kabn='' AND tiptehn <>'PC' ORDER BY tiptehn, PSEVDONIM"

                                        End Select

                                        rs3 = New Recordset
                                        rs3.Open(sSQL4, DB7, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic)

                                        With rs3
                                            .MoveFirst()

                                            Do While Not .EOF


                                                If Not IsDBNull(.Fields("tip_compa").Value) Then _
                                                    iA1 = .Fields("tip_compa").Value
                                                If Not IsDBNull(.Fields("NET_NAME").Value) Then _
                                                    iA2 = .Fields("NET_NAME").Value
                                                If Not IsDBNull(.Fields("PSEVDONIM").Value) Then _
                                                    iA3 = .Fields("PSEVDONIM").Value
                                                If Not IsDBNull(.Fields("Spisan").Value) Then _
                                                    iA4 = .Fields("Spisan").Value
                                                If Not IsDBNull(.Fields("tiptehn").Value) Then _
                                                    iA5 = .Fields("tiptehn").Value
                                                If Not IsDBNull(.Fields("OS").Value) Then iA6 = .Fields("OS").Value

                                                FILING_TREE(lstGroups, iA5, iA1, iA2, iA3, .Fields("id").Value, iA4,
                                                            DepatrmentNode, iA6)


                                                .MoveNext()
                                            Loop
                                        End With
                                        rs3.Close()
                                        rs3 = Nothing
                                    End If

                                End If
                                'Кабинеты Третий уровень дерева
                                ' Application.DoEvents()

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
                                            unameS3 = .Fields("name").Value


                                            sSQL4 = "SELECT count(*) as t_n FROM kompy WHERE filial ='" & unameS &
                                                    "' AND mesto ='" & unameS2 & "' AND kabn ='" & unameS3 &
                                                    "' AND tiptehn ='Printer'"
                                            rs3 = New Recordset
                                            rs3.Open(sSQL4, DB7, CursorTypeEnum.adOpenDynamic,
                                                     LockTypeEnum.adLockOptimistic)

                                            With rs3
                                                sTeh = .Fields("t_n").Value
                                            End With
                                            rs3.Close()
                                            rs3 = Nothing

                                            sSQL4 = "SELECT count(*) as t_n FROM kompy WHERE filial ='" & unameS &
                                                    "' AND mesto ='" & unameS2 & "' AND kabn ='" & unameS3 &
                                                    "' AND tiptehn ='KOpir'"
                                            rs3 = New Recordset
                                            rs3.Open(sSQL4, DB7, CursorTypeEnum.adOpenDynamic,
                                                     LockTypeEnum.adLockOptimistic)

                                            With rs3
                                                sTeh = sTeh + .Fields("t_n").Value
                                            End With
                                            rs3.Close()
                                            rs3 = Nothing

                                            sSQL4 = "SELECT count(*) as t_n FROM kompy WHERE filial ='" & unameS &
                                                    "' AND mesto ='" & unameS2 & "' AND kabn ='" & unameS3 &
                                                    "' AND tiptehn ='MFU'"
                                            rs3 = New Recordset
                                            rs3.Open(sSQL4, DB7, CursorTypeEnum.adOpenDynamic,
                                                     LockTypeEnum.adLockOptimistic)

                                            With rs3
                                                sTeh = sTeh + .Fields("t_n").Value
                                            End With
                                            rs3.Close()
                                            rs3 = Nothing

                                            sSQL4 = "SELECT count(*) as t_n FROM kompy WHERE filial ='" & unameS &
                                                    "' AND mesto ='" & unameS2 & "' AND kabn ='" & unameS3 &
                                                    "' AND tiptehn ='FAX'"
                                            rs3 = New Recordset
                                            rs3.Open(sSQL4, DB7, CursorTypeEnum.adOpenDynamic,
                                                     LockTypeEnum.adLockOptimistic)

                                            With rs3
                                                sTeh = sTeh + .Fields("t_n").Value
                                            End With
                                            rs3.Close()
                                            rs3 = Nothing


                                            If sTeh > 0 Then

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


                                                sSQL4 = "SELECT count(*) as t_n FROM kompy WHERE filial ='" & unameS &
                                                        "' AND mesto ='" & unameS2 & "' AND kabn='" & unameS3 & "'"
                                                rs3 = New Recordset
                                                rs3.Open(sSQL4, DB7, CursorTypeEnum.adOpenDynamic,
                                                         LockTypeEnum.adLockOptimistic)
                                                With rs3
                                                    cFil = .Fields("t_n").Value
                                                End With
                                                rs3.Close()
                                                rs3 = Nothing


                                                If cFil <> 0 Then

                                                    Dim sText As String = objIniFile.GetString("general", "Tree_S", 0)

                                                    Select Case sText

                                                        Case 0

                                                            sSQL4 =
                                                                "SELECT id, mesto, filial, tip_compa, tiptehn, PSEVDONIM, NET_NAME, kabn, Spisan, OS FROM kompy WHERE filial ='" &
                                                                unameS & "' AND mesto ='" & unameS2 & "' AND kabn='" &
                                                                unameS3 &
                                                                "' AND tiptehn <>'PC' ORDER BY PSEVDONIM, tiptehn"

                                                        Case 1

                                                            sSQL4 =
                                                                "SELECT id, mesto, filial, tip_compa, tiptehn, PSEVDONIM, NET_NAME, kabn, Spisan, OS FROM kompy WHERE filial ='" &
                                                                unameS & "' AND mesto ='" & unameS2 & "' AND kabn='" &
                                                                unameS3 &
                                                                "' AND tiptehn <>'PC' ORDER BY tiptehn, PSEVDONIM"

                                                    End Select


                                                    rs3 = New Recordset
                                                    rs3.Open(sSQL4, DB7, CursorTypeEnum.adOpenDynamic,
                                                             LockTypeEnum.adLockOptimistic)

                                                    With rs3
                                                        .MoveFirst()

                                                        Do While Not .EOF

                                                            If Not IsDBNull(.Fields("tip_compa").Value) Then _
                                                                iA1 = .Fields("tip_compa").Value
                                                            If Not IsDBNull(.Fields("NET_NAME").Value) Then _
                                                                iA2 = .Fields("NET_NAME").Value
                                                            If Not IsDBNull(.Fields("PSEVDONIM").Value) Then _
                                                                iA3 = .Fields("PSEVDONIM").Value
                                                            If Not IsDBNull(.Fields("Spisan").Value) Then _
                                                                iA4 = .Fields("Spisan").Value
                                                            If Not IsDBNull(.Fields("tiptehn").Value) Then _
                                                                iA5 = .Fields("tiptehn").Value
                                                            If Not IsDBNull(.Fields("OS").Value) Then _
                                                                iA6 = .Fields("OS").Value

                                                            FILING_TREE(lstGroups, iA5, iA1, iA2, iA3,
                                                                        .Fields("id").Value, iA4, OfficeNode, iA6)

                                                            .MoveNext()
                                                        Loop
                                                    End With
                                                    rs3.Close()
                                                    rs3 = Nothing

                                                End If
                                            End If

                                            .MoveNext()
                                        Loop
                                    End With
                                    rs7.Close()
                                    rs7 = Nothing

                                End If
                                ' Application.DoEvents()
                                'Конец кабинетов


                            End If


                            .MoveNext()
                        Loop
                    End With
                    rs2.Close()
                    rs2 = Nothing

                End If


                .MoveNext()
            Loop
        End With

        rs.Close()
        rs = Nothing


        ' On Error Resume Next
        ' Dim LnGIniFile As New IniFile(sLANGPATH)

        Dim CRT_NULL As New TreeNode(LNGIniFile.GetString("frmCRT3", "MSG1", "Картриджи"), 0, 0)
        CRT_NULL.Tag = "GС|" & GENID()
        nodeRoot.Nodes.Add(CRT_NULL)

        Dim rsCRT As Recordset
        rsCRT = New Recordset
        rsCRT.Open("Select count(*) as t_n FROM CARTRIDG WHERE PREF=0 AND USTR=0", DB7, CursorTypeEnum.adOpenDynamic,
                   LockTypeEnum.adLockOptimistic)
        Dim CRT_ As String

        With rsCRT
            CRT_ = .Fields("t_n").Value
        End With

        rsCRT.Close()
        rsCRT = Nothing

        If CRT_ > 0 Then

            Dim rsq As Recordset
            rsq = New Recordset

            Dim sSQL As String
            sSQL =
                "Select CARTRIDG.Model,CARTRIDG.SN, CARTRIDG.id, spr_cart.Name FROM CARTRIDG INNER JOIN spr_cart ON CARTRIDG.Model = spr_cart.Id WHERE CARTRIDG.Model=spr_cart.Id AND CARTRIDG.PREF=0 AND CARTRIDG.USTR=0 ORDER BY spr_cart.Name"
            rsq.Open(sSQL, DB7, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic)


            Dim uname As String
            With rsq
                .MoveFirst()
                Do While Not .EOF

                    Dim TEHNodeCP As New TreeNode(.Fields("Name").Value & "(" & .Fields("SN").Value & ")", 49, 49)
                    TEHNodeCP.Tag = "CRT|" & .Fields("id").Value
                    CRT_NULL.Nodes.Add(TEHNodeCP)

                    If DCKey = 0 And Len(KCKey) <> 0 Then

                        If KCKey = .Fields("id").Value Then
                            lstGroups.SelectedNode = TEHNodeCP
                            lstGroups.SelectedNode.Expand()
                        End If
                    End If


                    .MoveNext()
                Loop
            End With
            rsq.Close()
            rsq = Nothing


        End If

        'ЗАПРАВЩИКИ

        sSQL4 = "SELECT count(*) as t_n FROM SPR_Postav"
        rs3 = New Recordset
        rs3.Open(sSQL4, DB7, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic)
        Dim sCount1 As String
        With rs3
            sCount1 = .Fields("t_n").Value
        End With
        rs3.Close()
        rs3 = Nothing


        Dim CRT_NULL1 As New TreeNode(LNGIniFile.GetString("frmCRT3", "MSG2", "Заправщики"), 0, 0)
        CRT_NULL1.Tag = "Z|" & GENID()
        nodeRoot.Nodes.Add(CRT_NULL1)


        If sCount1 = 0 Then Exit Sub


        sSQL4 = "SELECT * FROM SPR_Postav"
        rs3 = New Recordset
        rs3.Open(sSQL4, DB7, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic)


        With rs3
            .MoveFirst()
            Do While Not .EOF

                Dim OfficeNode As New TreeNode(.Fields("name").Value, 2, 2)
                OfficeNode.Tag = "ZP|" & .Fields("id").Value
                CRT_NULL1.Nodes.Add(OfficeNode)
                unameS3 = .Fields("id").Value

                rsCRT = New Recordset
                rsCRT.Open("Select count(*) as t_n FROM CARTRIDG WHERE PREF=1 AND USTR=" & unameS3, DB7,
                           CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic)

                With rsCRT
                    CRT_ = .Fields("t_n").Value
                End With

                rsCRT.Close()
                rsCRT = Nothing

                If CRT_ > 0 Then


                    rs = New Recordset
                    Dim sSQL As String
                    sSQL =
                        "Select CARTRIDG.Model,CARTRIDG.SN, CARTRIDG.id, spr_cart.Name FROM CARTRIDG INNER JOIN spr_cart ON CARTRIDG.Model = spr_cart.Id WHERE CARTRIDG.Model=spr_cart.Id AND CARTRIDG.PREF=1 AND CARTRIDG.USTR=" &
                        unameS3 & " ORDER BY spr_cart.Name"
                    rs.Open(sSQL, DB7, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic)


                    Dim uname As String
                    With rs
                        .MoveFirst()
                        Do While Not .EOF

                            Dim _
                                TEHNodeCP As _
                                    New TreeNode(.Fields("Name").Value & "(" & .Fields("SN").Value & ")", 49, 49)
                            TEHNodeCP.Tag = "CRT|" & .Fields("id").Value
                            OfficeNode.Nodes.Add(TEHNodeCP)

                            If DCKey = 0 And Len(KCKey) <> 0 Then
                                If KCKey = .Fields("id").Value Then
                                    lstGroups.SelectedNode = TEHNodeCP
                                    lstGroups.SelectedNode.Expand()
                                End If
                            End If


                            .MoveNext()
                        Loop
                    End With
                    rs.Close()
                    rs = Nothing


                End If

                .MoveNext()
            Loop
        End With
        rs3.Close()
        rs3 = Nothing


        If KCKey = 0 And Len(DCKey) = 0 Then

            lstGroups.SelectedNode = nodeRoot
            Dim tNode As New TreeNode
            tNode = lstGroups.Nodes(0)
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

                MsgBox(Err.Description, vbCritical, ProGramName)

        End Select
    End Sub

    Private Sub FILING_TREE(ByVal lstgroups As TreeView, ByVal iTipTehn As String, ByVal TipPC As String,
                            ByVal NET_NAME As String, ByVal PSEVDONIM As String, ByVal iD As String,
                            ByVal Spisan As String, ByVal DepNode As TreeNode, ByVal OS As String)

        On Error Resume Next

        Dim sTREENAME As String
        Dim N_NAME As String
        Dim P_NAME As String
        Dim L_NAME As String

        Dim sSQL As String

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


                Dim rsCRT As Recordset
                rsCRT = New Recordset
                rsCRT.Open("Select count(*) as t_n FROM CARTRIDG WHERE PREF=0 AND USTR=" & iD, DB7,
                           CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic)
                Dim CRT_ As String

                With rsCRT
                    CRT_ = .Fields("t_n").Value
                End With

                rsCRT.Close()
                rsCRT = Nothing

                If CRT_ > 0 Then

                    Dim rs As Recordset
                    rs = New Recordset

                    sSQL =
                        "Select CARTRIDG.Model, CARTRIDG.SN, CARTRIDG.id, spr_cart.Name FROM CARTRIDG INNER JOIN spr_cart ON CARTRIDG.Model = spr_cart.Id WHERE CARTRIDG.Model=spr_cart.Id AND PREF=0 AND USTR=" &
                        iD & " ORDER BY spr_cart.Name"
                    rs.Open(sSQL, DB7, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic)

                    With rs
                        .MoveFirst()
                        Do While Not .EOF


                            Dim _
                                TEHNodeCP As _
                                    New TreeNode(.Fields("name").Value & "(" & .Fields("SN").Value & ")", 49, 49)
                            TEHNodeCP.Tag = "CRT|" & .Fields("id").Value
                            TEHNode.Nodes.Add(TEHNodeCP)

                            If KCKey <> 0 Then
                                If KCKey = .Fields("id").Value Then
                                    lstgroups.SelectedNode = TEHNodeCP
                                    lstgroups.SelectedNode.Expand()
                                End If
                            End If


                            .MoveNext()
                        Loop
                    End With
                    rs.Close()
                    rs = Nothing


                End If


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

                Dim rsCRT As Recordset
                rsCRT = New Recordset
                rsCRT.Open("Select count(*) as t_n FROM CARTRIDG WHERE PREF=0 AND USTR=" & iD, DB7,
                           CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic)
                Dim CRT_ As String

                With rsCRT
                    CRT_ = .Fields("t_n").Value
                End With

                rsCRT.Close()
                rsCRT = Nothing

                If CRT_ > 0 Then

                    Dim rs As Recordset
                    rs = New Recordset

                    sSQL =
                        "Select CARTRIDG.Model,CARTRIDG.SN, CARTRIDG.id, spr_cart.Name FROM CARTRIDG INNER JOIN spr_cart ON CARTRIDG.Model = spr_cart.Id WHERE CARTRIDG.Model=spr_cart.Id AND PREF=0 AND USTR=" &
                        iD & " ORDER BY spr_cart.Name"
                    rs.Open(sSQL, DB7, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic)


                    With rs
                        .MoveFirst()
                        Do While Not .EOF

                            Dim _
                                TEHNodeCP As _
                                    New TreeNode(.Fields("name").Value & "(" & .Fields("SN").Value & ")", 49, 49)
                            TEHNodeCP.Tag = "CRT|" & .Fields("id").Value
                            TEHNode.Nodes.Add(TEHNodeCP)

                            If KCKey <> 0 Then
                                If KCKey = .Fields("id").Value Then
                                    lstgroups.SelectedNode = TEHNodeCP
                                    lstgroups.SelectedNode.Expand()
                                End If
                            End If


                            .MoveNext()
                        Loop
                    End With
                    rs.Close()
                    rs = Nothing

                End If

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

                Dim rsCRT As Recordset
                rsCRT = New Recordset
                rsCRT.Open("Select count(*) as t_n FROM CARTRIDG WHERE PREF=0 AND USTR=" & iD, DB7,
                           CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic)
                Dim CRT_ As String

                With rsCRT
                    CRT_ = .Fields("t_n").Value
                End With

                rsCRT.Close()
                rsCRT = Nothing

                If CRT_ > 0 Then

                    Dim rs As Recordset
                    rs = New Recordset

                    sSQL =
                        "Select CARTRIDG.Model,CARTRIDG.SN, CARTRIDG.id, spr_cart.Name FROM CARTRIDG INNER JOIN spr_cart ON CARTRIDG.Model = spr_cart.Id WHERE CARTRIDG.Model=spr_cart.Id AND PREF=0 AND USTR=" &
                        iD & " ORDER BY spr_cart.Name"
                    rs.Open(sSQL, DB7, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic)


                    With rs
                        .MoveFirst()
                        Do While Not .EOF

                            Dim _
                                TEHNodeCP As _
                                    New TreeNode(.Fields("name").Value & "(" & .Fields("SN").Value & ")", 49, 49)
                            TEHNodeCP.Tag = "CRT|" & .Fields("id").Value
                            TEHNode.Nodes.Add(TEHNodeCP)

                            If KCKey <> 0 Then
                                If KCKey = .Fields("id").Value Then
                                    lstgroups.SelectedNode = TEHNodeCP
                                    lstgroups.SelectedNode.Expand()
                                End If
                            End If

                            .MoveNext()
                        Loop
                    End With
                    rs.Close()
                    rs = Nothing

                End If

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

                Dim rsCRT As Recordset
                rsCRT = New Recordset
                rsCRT.Open("Select count(*) as t_n FROM CARTRIDG WHERE PREF=0 AND USTR=" & iD, DB7,
                           CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic)
                Dim CRT_ As String

                With rsCRT
                    CRT_ = .Fields("t_n").Value
                End With

                rsCRT.Close()
                rsCRT = Nothing

                If CRT_ > 0 Then

                    Dim rs As Recordset
                    rs = New Recordset

                    sSQL =
                        "Select CARTRIDG.Model,CARTRIDG.SN, CARTRIDG.id, spr_cart.Name FROM CARTRIDG INNER JOIN spr_cart ON CARTRIDG.Model = spr_cart.Id WHERE CARTRIDG.Model=spr_cart.Id AND PREF=0 AND USTR=" &
                        iD & " ORDER BY spr_cart.Name"
                    rs.Open(sSQL, DB7, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic)


                    With rs
                        .MoveFirst()
                        Do While Not .EOF


                            Dim _
                                TEHNodeCP As _
                                    New TreeNode(.Fields("name").Value & "(" & .Fields("SN").Value & ")", 49, 49)
                            TEHNodeCP.Tag = "CRT|" & .Fields("id").Value
                            TEHNode.Nodes.Add(TEHNodeCP)

                            If KCKey <> 0 Then
                                If KCKey = .Fields("id").Value Then
                                    lstgroups.SelectedNode = TEHNodeCP
                                    lstgroups.SelectedNode.Expand()
                                End If
                            End If

                            .MoveNext()
                        Loop
                    End With
                    rs.Close()
                    rs = Nothing

                End If

        End Select
    End Sub

    Public Sub LOAD_CRR2(ByVal sSId As String)

        Dim uname As String
        'Dim sSId As String
        Dim objIniFile As New IniFile(sLANGPATH)

        'On Error GoTo Error_
        On Error Resume Next
        btnAdd.Text = objIniFile.GetString("frmCRT3", "MSG3", "Сохранить")


        Dim CARTRIDG As Recordset
        CARTRIDG = New Recordset
        CARTRIDG.Open("SELECT * FROM CARTRIDG WHERE id =" & sSId, DB7, CursorTypeEnum.adOpenDynamic,
                      LockTypeEnum.adLockOptimistic)

        With CARTRIDG

            EDTRCART = True
            lblRealNumber.Text = .Fields("id").Value
            If Not IsDBNull(.Fields("SN").Value) Then txtSerNumb.Text = .Fields("SN").Value
            uname = .Fields("Proizv").Value

            Dim PROYZV As Recordset
            PROYZV = New Recordset
            PROYZV.Open("SELECT * FROM SPR_PROIZV WHERE id=" & uname, DB7, CursorTypeEnum.adOpenDynamic,
                        LockTypeEnum.adLockOptimistic)
            With PROYZV
                cmbProizv.Text = .Fields("Proizv").Value
            End With
            PROYZV.Close()
            PROYZV = Nothing


            If Not IsDBNull(.Fields("TIP").Value) Then cmbTipC.Text = .Fields("TIP").Value
            Dim zaname As Long

            zaname = .Fields("Model").Value

            Dim CARTR As Recordset
            CARTR = New Recordset
            CARTR.Open("SELECT * FROM spr_cart WHERE id=" & zaname, DB7, CursorTypeEnum.adOpenDynamic,
                       LockTypeEnum.adLockOptimistic)

            With CARTR
                cmbModC.Text = .Fields("name").Value
            End With

            CARTR.Close()
            CARTR = Nothing

            If Not IsDBNull(.Fields("USTR").Value) Then uname = .Fields("USTR").Value

            If uname = 0 Then

            Else

                If .Fields("PREF").Value = 1 Then
                    cmbSostUstr.Text = ""
                Else


                    Dim rs As Recordset
                    rs = New Recordset
                    rs.Open("SELECT id,PRINTER_NAME_1,filial,mesto FROM kompy WHERE id=" & uname, DB7, CursorTypeEnum.adOpenDynamic,
                            LockTypeEnum.adLockOptimistic)

                    With rs
                        cmbSostUstr.Text = " № " & .Fields("id").Value & " " & .Fields("PRINTER_NAME_1").Value & " (" &
                                           .Fields("filial").Value & "/" & .Fields("mesto").Value & ")"
                    End With

                    rs.Close()
                    rs = Nothing

                End If

            End If

            uname = 0
            If Not IsDBNull(.Fields("PROD")) Then uname = .Fields("PROD").Value

            If uname = 0 Then
            Else
                Dim Postav As Recordset
                Postav = New Recordset
                Postav.Open("SELECT * FROM SPR_Postav WHERE id=" & uname, DB7, CursorTypeEnum.adOpenDynamic,
                            LockTypeEnum.adLockOptimistic)

                With Postav
                    If Not IsDBNull(.Fields("Name").Value) Then
                        cmbSaler.Text = .Fields("Name").Value
                    Else
                        cmbSaler.Text = ""

                    End If

                End With

                Postav.Close()
                Postav = Nothing

            End If

            txtSaleNumb.Text = .Fields("SCHET").Value
            txtCashe.Text = .Fields("Cena").Value
            dtSale.Text = .Fields("D_T").Value

            Select Case .Fields("NZap").Value

                Case True
                    chkNezap.Checked = 1
                Case False
                    chkNezap.Checked = 0

                Case 1
                    chkNezap.Checked = 1
                Case 0
                    chkNezap.Checked = 0
            End Select


            Select Case .Fields("NeZap").Value

                Case True
                    chkNZ.Checked = 1
                Case False
                    chkNZ.Checked = 0

                Case 1
                    chkNZ.Checked = 1
                Case 0
                    chkNZ.Checked = 0
            End Select


            Select Case .Fields("Iznos").Value

                Case True
                    chkIznos.Checked = 1
                Case False
                    chkIznos.Checked = 0

                Case 1
                    chkIznos.Checked = 1
                Case 0
                    chkIznos.Checked = 0
            End Select

            Select Case .Fields("Spisan").Value

                Case True
                    chkSPS.Checked = 1
                Case False
                    chkSPS.Checked = 0

                Case 1
                    chkSPS.Checked = 1
                Case 0
                    chkSPS.Checked = 0
            End Select

            Select Case .Fields("NaSpisanie").Value

                Case True
                    chkNaSP.Checked = 1
                Case False
                    chkNaSP.Checked = 0

                Case 1
                    chkNaSP.Checked = 1
                Case 0
                    chkNaSP.Checked = 0
            End Select

            If Not IsDBNull(.Fields("PRIM").Value) Then txtMemo.Text = .Fields("PRIM").Value
            EDTIDTr = .Fields("id").Value

        End With

        ShowDialog(Me)

        Exit Sub
Error_:
        'frmCartr_ADD.Show(vbModal)
        MsgBox(Err.Description)
    End Sub

    Public Sub Zap_load(Optional ByVal sXcount As Integer = 0)

        Dim zCOUNT As Integer

        Dim sSQL1 As String
        Dim sSQL As String

        On Error GoTo Error_
        Dim uname As Long
        lvCartZAP.Items.Clear()


        If sXcount = 0 Then
            ' If LVCart.Items.Count = 0 Then Exit Sub
            ' Dim z As Integer
            ' ' Dim rCOUNT As Integer
            '
            'For z = 0 To LVCart.SelectedItems.Count - 1
            'rCOUNT = (LVCart.SelectedItems(z).Text)
            'Next

        Else

            rCOUNT = sXcount

        End If


        Dim rs1 As Recordset
        sSQL1 = "SELECT * FROM CARTRIDG WHERE ID=" & rCOUNT
        rs1 = New Recordset
        rs1.Open(sSQL1, DB7, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic)

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

        Dim rs As Recordset
        sSQL = "SELECT COUNT(*) AS total_number FROM CARTRIDG_Z"
        rs = New Recordset
        rs.Open(sSQL, DB7, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic)

        With rs
            zCOUNT = .Fields("total_number").Value
        End With
        rs.Close()
        rs = Nothing

        If zCOUNT > 0 Then

            rs = New Recordset
            rs.Open("SELECT * FROM CARTRIDG_Z WHERE ID_C=" & rCOUNT & " ORDER BY datazap DESC", DB7,
                    CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic)

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


                        rs1 = New Recordset
                        rs1.Open("SELECT count(*) as t_n FROM SPR_Postav WHERE ID=" & .Fields("SC").Value, DB7,
                                 CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic)
                        Dim sCCC As String
                        With rs1
                            sCCC = .Fields("t_n").Value
                        End With
                        rs1.Close()
                        rs1 = Nothing


                        If sCCC > 0 Then

                            rs1 = New Recordset
                            rs1.Open("SELECT * FROM SPR_Postav WHERE ID=" & .Fields("SC").Value, DB7,
                                     CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic)

                            With rs1
                                If Not IsDBNull(.Fields("Name").Value) Then
                                    lvCartZAP.Items(CInt(intCount)).SubItems.Add(.Fields("Name").Value)
                                Else
                                    lvCartZAP.Items(CInt(intCount)).SubItems.Add("")
                                End If

                            End With
                            rs1.Close()
                            rs1 = Nothing

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

    Private Sub frmCRT3_Activated(ByVal sender As Object, ByVal e As EventArgs) Handles Me.Activated

        TreeORGANIZACIA = lstGroups

        frmMain.SaveInfTehButton.Enabled = False
        frmMain.ToolStripDropDownButton1.Enabled = False
    End Sub

    Private Sub frmCRT3_Load(ByVal sender As Object, ByVal e As EventArgs) Handles Me.Load

        SendFonts(Me)
        btnSearch.Image = New Bitmap(PrPath & "pic\iface\search.png")


        Me.Show()


        Dim objIniFile As New IniFile(PrPath & "base.ini")
        Dim uname As String

        FillComboNET(Me.treebranche, "FILIAL", "SPR_FILIAL", "", False, True)

        Dim LNGIniFile As New IniFile(sLANGPATH)
        treebranche.Items.Add(LNGIniFile.GetString("frmComputers", "MSG53", "Все"))
        uname = objIniFile.GetString("General", "branche", "")

        If Len(uname) = 0 Then
            treebranche.Text = LNGIniFile.GetString("frmComputers", "MSG53", "Все")

        Else
            treebranche.Text = uname

        End If


        'Call RefFilTreePRN()

        Me.Invoke(New MethodInvoker(AddressOf frmCartr3_Lang))
        Me.Invoke(New MethodInvoker(AddressOf RefFilTreePRN))
        Me.Invoke(New MethodInvoker(AddressOf PreLoad))


        FillComboNET(Me.cmbProizv, "PROIZV", "SPR_PROIZV", "", False, True)
        FillComboNET(Me.cmbSaler, "Name", "SPR_Postav", "", False, True)
        FillComboNET(Me.cmbModC, "name", "spr_cart", "", False, True)

        cmbTipC.Items.Clear()

        cmbTipC.Items.Add(LNGIniFile.GetString("frmCRT3", "MSG4", "Струйный"))
        cmbTipC.Items.Add(LNGIniFile.GetString("frmCRT3", "MSG5", "Матричный"))
        cmbTipC.Items.Add(LNGIniFile.GetString("frmCRT3", "MSG6", "Лазерный"))
        cmbTipC.Items.Add(LNGIniFile.GetString("frmCRT3", "MSG7", "Барабан"))
        cmbTipC.Items.Add(LNGIniFile.GetString("frmCRT3", "MSG8", "Термо Пленка"))
        cmbTipC.Items.Add(LNGIniFile.GetString("frmCRT3", "MSG9", "Фотокондуктор"))

        'dtSale.Value = Date.Today


        If EDTRCART = True Then

            Label6.Enabled = True
            cmbSostUstr.Enabled = True

        Else

            Label6.Enabled = False
            cmbSostUstr.Enabled = False

        End If


        OneStart = 1

        Exit Sub
err_:
    End Sub

    Private Sub PreLoad()
        Dim sSQL As String
        Dim Counter As Decimal
        Dim rs As Recordset
        sSQL = "SELECT COUNT(*) AS total_number FROM kompy"
        rs = New Recordset
        rs.Open(sSQL, DB7, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic)

        With rs
            Counter = .Fields("total_number").Value
        End With
        rs.Close()
        rs = Nothing


        If Counter > 0 Then
            cmbSostUstr.Items.Clear()
            rs = New Recordset
            rs.Open(
                "SELECT id,PRINTER_NAME_1,filial,mesto FROM kompy where TipTehn='Printer' or TipTehn='KOpir' or TipTehn='MFU' ORDER BY filial,mesto",
                DB7, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic)

            With rs
                .MoveFirst()
                Do While Not .EOF
                    'If .Fields("TipTehn").Value = "Printer" Or .Fields("TipTehn").Value = "KOpir" Or .Fields("TipTehn").Value = "MFU" Then
                    cmbSostUstr.Items.Add(
                        " № " & .Fields("id").Value & " " & .Fields("PRINTER_NAME_1").Value & " (" &
                        .Fields("filial").Value & "/" & .Fields("mesto").Value & ")")
                    'Else
                    'End If
                    .MoveNext()
                    'DoEvents
                Loop
            End With
            rs.Close()
            rs = Nothing

        End If


        'If Not IsDBNull(.Fields("os")) Then frmComputers.cmbModCartr.Text = .Fields("os").Value
        If EDTRCART = False Then

            If Me.cCOUNT = 0 Then Exit Sub

            rs = New Recordset
            rs.Open("SELECT os FROM kompy where id=" & Me.cCOUNT, DB7, CursorTypeEnum.adOpenDynamic,
                    LockTypeEnum.adLockOptimistic)

            With rs

                If Not IsDBNull(.Fields("os").Value) Then cmbModC.Text = .Fields("os").Value

            End With
            rs.Close()
            rs = Nothing

        End If
    End Sub

    Private Sub btnAdd_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnAdd.Click
        Dim uname As String
        Dim uname2 As String
        Dim uname3 As String
        Dim uname4 As String

        uname = cmbProizv.Text

        If Not (RSExists("PROYZV", "PROiZV", cmbProizv.Text)) Then
            AddPr(cmbProizv.Text)
        End If

        If Not (RSExists("Postav", "name", cmbSaler.Text)) Then
            AddOnePar(cmbSaler.Text, "NAME", "SPR_Postav", cmbSaler)
        End If

        If Not (RSExists("CARTR", "name", cmbModC.Text)) Then

            AddTreePar(cmbModC.Text, cmbTipC.Text, cmbProizv.Text, "spr_cart", cmbModC)

        End If

        Dim PROYZV As Recordset
        PROYZV = New Recordset
        PROYZV.Open("SELECT * FROM SPR_PROIZV WHERE Proizv='" & uname & "'", DB7, CursorTypeEnum.adOpenDynamic,
                    LockTypeEnum.adLockOptimistic)

        With PROYZV
            uname = .Fields("Id").Value
        End With
        PROYZV.Close()
        PROYZV = Nothing

        uname2 = cmbModC.Text


        Dim CARTR As Recordset
        CARTR = New Recordset
        CARTR.Open("SELECT * FROM spr_cart WHERE name='" & uname2 & "'", DB7, CursorTypeEnum.adOpenDynamic,
                   LockTypeEnum.adLockOptimistic)

        With CARTR
            uname2 = .Fields("id").Value
        End With
        CARTR.Close()
        CARTR = Nothing


        If EDTRCART = True Then


            If Len(cmbSostUstr.Text) = 0 Then
                uname3 = 0
            Else

                uname3 = cmbSostUstr.Text

                Dim sTmp() As String
                sTmp = Split(cmbSostUstr.Text, " ")
                uname3 = sTmp(2)

            End If

        Else

            uname3 = Me.cCOUNT

        End If


        uname4 = cmbSaler.Text


        If Len(cmbSaler.Text) = 0 Then

            uname4 = 0

        Else

            If Not (RSExists("Postav", "name", cmbSaler.Text)) Then
                ' AddPost(cmbSaler.Text)
            End If

            Dim Postav As Recordset
            Postav = New Recordset
            Postav.Open("SELECT * FROM SPR_Postav WHERE Name='" & uname4 & "'", DB7, CursorTypeEnum.adOpenDynamic,
                        LockTypeEnum.adLockOptimistic)

            With Postav
                uname4 = .Fields("id").Value
            End With
            Postav.Close()
            Postav = Nothing

        End If


        Dim sSQL As String
        If EDTRCART = True Then
            sSQL = "SELECT * FROM CARTRIDG WHERE id = " & EDTIDTr
        Else

            sSQL = "SELECT * FROM CARTRIDG"

        End If

        Dim LNGIniFile As New IniFile(sLANGPATH)

        If EDTRCART = True Then


            Call DVIG_CRt2(uname3, lstGroups.SelectedNode.Text)

            If DV = True Then

            Else

                If Sav = False Then

                    MsgBox(LNGIniFile.GetString("frmCRT3", "MSG10", "Отмена перемещения"), MsgBoxStyle.Exclamation,
                           ProGramName)

                    If pDRAG = True Then

                        Me.Invoke(New MethodInvoker(AddressOf RefFilTreePRN))

                    End If

                    Zap_load(rCOUNT)
                    LOAD_CRR2(rCOUNT)
                    LOAD_MOVE(rCOUNT)

                    Exit Sub

                Else


                End If
            End If

        Else


        End If

        Dim rs1 As Recordset
        rs1 = New Recordset
        rs1.Open(sSQL, DB7, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic)

        If Len(txtSerNumb.Text) = 0 Then txtSerNumb.Text = "Б\Н"
        If Len(txtSaleNumb.Text) = 0 Then txtSaleNumb.Text = 0
        If Len(txtCashe.Text) = 0 Then txtCashe.Text = 0

        With rs1
            If EDTRCART = True Then
            Else
                .AddNew()
            End If

            .Fields("SN").Value = txtSerNumb.Text
            .Fields("Proizv").Value = uname
            .Fields("TIP").Value = cmbTipC.Text
            .Fields("Model").Value = uname2
            .Fields("USTR").Value = uname3
            .Fields("PROD").Value = uname4
            .Fields("SCHET").Value = txtSaleNumb.Text
            .Fields("Cena").Value = txtCashe.Text
            .Fields("D_T").Value = dtSale.Value
            .Fields("NZap").Value = chkNezap.Checked
            .Fields("NeZap").Value = chkNZ.Checked
            .Fields("Iznos").Value = chkIznos.Checked
            .Fields("Spisan").Value = chkSPS.Checked
            .Fields("NaSpisanie").Value = chkNaSP.Checked
            .Fields("PRIM").Value = txtMemo.Text

            .Fields("Pref").Value = 0

            .Update()
        End With

        rs1.Close()
        rs1 = Nothing

        Dim objIniFile As New IniFile(PrPath & "base.ini")
        objIniFile.WriteString("general", "DK", uname3)
        objIniFile.WriteString("general", "Default", 0)


        Me.Invoke(New MethodInvoker(AddressOf RefFilTreePRN))


        Me.btnAdd.Text = LNGIniFile.GetString("frmCRT3", "btnAdd", "Добавить")
        CRTFU = False
    End Sub

    Private Sub btnCancel_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnCancel.Click


        Dim d() As String

        d = Split(lstGroups.SelectedNode.Tag, "|")

        If d(0) <> "C" Then

            Zap_load(d(1))
            LOAD_CRR2(d(1))

        Else

            cCOUNT = d(1)

        End If


        Dim LNGIniFile As New IniFile(sLANGPATH)
        btnAdd.Text = LNGIniFile.GetString("frmCRT3", "btnAdd", "Добавить")
        EDTRCART = False
        chkNaSP.Checked = 0
        chkSPS.Checked = 0
        chkIznos.Checked = 0
        chkNZ.Checked = 0
        chkNezap.Checked = 0
        txtCashe.Text = 0
        txtSaleNumb.Text = ""
        cmbSaler.Text = ""
        cmbSostUstr.Text = ""
        cmbModC.Text = ""
        cmbTipC.Text = ""
        cmbProizv.Text = ""
        txtSerNumb.Text = ""
        lblRealNumber.Text = ""
        txtMemo.Text = ""
        dtSale.Value = Date.Today
    End Sub

    Private Sub cmbModC_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) _
        Handles cmbModC.SelectedIndexChanged
        On Error Resume Next
        Dim rs As Recordset
        Dim sSQL As String
        Dim uNI As String
        rs = New Recordset


        sSQL = "SELECT * FROM spr_cart WHERE Name = '" & cmbModC.Text & "'"

        rs.Open(sSQL, DB7, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic)

        With rs

            If Not IsDBNull(.Fields("proizv").Value) Then uNI = .Fields("proizv").Value

            Dim PROYZV As Recordset
            PROYZV = New Recordset
            PROYZV.Open("SELECT * FROM SPR_PROIZV WHERE iD=" & uNI, DB7, CursorTypeEnum.adOpenDynamic,
                        LockTypeEnum.adLockOptimistic)

            With PROYZV
                cmbProizv.Text = .Fields("proizv").Value
            End With
            PROYZV.Close()
            PROYZV = Nothing

            If Not IsDBNull(.Fields("A").Value) Then cmbTipC.Text = .Fields("A").Value

        End With

        rs.Close()
        rs = Nothing
    End Sub

    Private Sub btnZapAdd_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnZapAdd.Click


        If rCOUNT = 0 Then Exit Sub

        Dim C As Control

        For Each C In frmCartr_Add_Zap.Controls
            If TypeOf C Is TextBox Then C.Text = ""
            If TypeOf C Is ComboBox Then C.Text = ""
            If TypeOf C Is NumericUpDown Then C.Text = 0
        Next C

        C = Nothing
        frmCartr_Add_Zap.dtAvR.Value = Date.Today.Date
        frmCartr_Add_Zap.dtDateZ.Value = Date.Today.Date

        frmCartr_Add_Zap.EDTRCARTZ = False
        frmCartr_Add_Zap.ShowDialog(Me)
    End Sub

    Private Sub btnZapReport_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnZapReport.Click
        Dim rs As Recordset
        rs = New Recordset

        Dim Coun1 As Long

        Dim rscount As Recordset 'Объявляем рекордсет
        rscount = New Recordset
        rscount.Open("SELECT COUNT(*) AS total_number FROM CARTRIDG_Z", DB7, CursorTypeEnum.adOpenDynamic,
                     LockTypeEnum.adLockOptimistic)

        With rscount
            Coun1 = .Fields("total_number").Value
        End With

        rscount.Close()
        rscount = Nothing

        Dim objIniFile As New IniFile(sLANGPATH)

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
                    objText.insertString(objCursor,
                                         objIniFile.GetString("frmCRT3", "MSG11", "Заправка картриджей") & vbLf, False)

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
                    'objIniFile.GetString("frmCRT3", "MSG11", "")
                    insertIntoCell("A1", objIniFile.GetString("frmCRT3", "MSG12", "Порядковый номер"), objTable)
                    insertIntoCell("B1", objIniFile.GetString("frmCRT3", "MSG13", "Дата заправки"), objTable)
                    insertIntoCell("C1", objIniFile.GetString("frmCRT3", "MSG14", "Модель картриджа"), objTable)
                    insertIntoCell("D1", objIniFile.GetString("frmCRT3", "MSG15", "Восстановлен"), objTable)
                    insertIntoCell("E1", objIniFile.GetString("frmCRT3", "MSG16", "Место установки"), objTable)


                    rscount = New Recordset
                    rscount.Open("SELECT * FROM CARTRIDG_Z", DB7, CursorTypeEnum.adOpenDynamic,
                                 LockTypeEnum.adLockOptimistic)

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
                            rs = New Recordset
                            rs.Open("SELECT model, ustr FROM CARTRIDG WHERE id =" & uname, DB7,
                                    CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic)
                            With rs
                                uname = .Fields("model").Value
                                uname2 = .Fields("ustr").Value

                            End With
                            rs.Close()
                            rs = Nothing

                            rs = New Recordset
                            rs.Open("SELECT name FROM spr_cart WHERE id =" & uname, DB7, CursorTypeEnum.adOpenDynamic,
                                    LockTypeEnum.adLockOptimistic)
                            With rs
                                uname1 = .Fields("name").Value
                            End With
                            rs.Close()
                            rs = Nothing

                            insertIntoCell(c, uname1, objTable)
                            d = "D" & intj


                            If .Fields("VOST").Value = False Or .Fields("VOST").Value = 0 Then
                                uname1 = objIniFile.GetString("frmCRT3", "MSG17", "Нет")
                            Else
                                uname1 = objIniFile.GetString("frmCRT3", "MSG18", "Да")
                            End If
                            insertIntoCell(d, uname1, objTable)

                            If uname2 = 0 Or Len(uname2) = 0 Then

                            Else
                                rs = New Recordset
                                rs.Open("SELECT filial, mesto FROM kompy WHERE id =" & uname2, DB7,
                                        CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic)
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

                    Dim oWord As Application
                    Dim oDoc As Document
                    Dim oTable As Table
                    Dim oPara1 As Paragraph, oPara2 As Paragraph
                    Dim oPara3 As Paragraph, oPara4 As Paragraph
                    Dim oRng As Range
                    Dim oShape As InlineShape
                    Dim oChart As Object
                    Dim Pos As Double


                    'Start Word and open the document template.
                    oWord = CreateObject("Word.Application")
                    oWord.Visible = True
                    oDoc = oWord.Documents.Add

                    'Insert a paragraph at the beginning of the document.
                    oPara1 = oDoc.Content.Paragraphs.Add
                    oPara1.Range.Text = objIniFile.GetString("frmCRT3", "MSG11", "Заправка картриджей")
                    oPara1.Range.Font.Bold = True
                    oPara1.Format.SpaceAfter = 24    '24 pt spacing after paragraph.
                    oPara1.Range.InsertParagraphAfter()


                    oTable = oDoc.Tables.Add(oDoc.Bookmarks.Item("\endofdoc").Range, Coun1 + 1, 5)
                    oTable.Range.ParagraphFormat.SpaceAfter = 6

                    oTable.Cell(1, 1).Range.Text = objIniFile.GetString("frmCRT3", "MSG12", "Порядковый номер")
                    oTable.Cell(1, 2).Range.Text = objIniFile.GetString("frmCRT3", "MSG13", "Дата заправки")
                    oTable.Cell(1, 3).Range.Text = objIniFile.GetString("frmCRT3", "MSG14", "Модель картриджа")
                    oTable.Cell(1, 4).Range.Text = objIniFile.GetString("frmCRT3", "MSG15", "Восстановлен")
                    oTable.Cell(1, 5).Range.Text = objIniFile.GetString("frmCRT3", "MSG16", "Место установки")


                    rscount = New Recordset
                    rscount.Open("SELECT * FROM CARTRIDG_Z", DB7, CursorTypeEnum.adOpenDynamic,
                                 LockTypeEnum.adLockOptimistic)

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
                            rs = New Recordset
                            rs.Open("SELECT model, ustr FROM CARTRIDG WHERE id =" & uname, DB7,
                                    CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic)
                            With rs
                                uname = .Fields("model").Value
                                uname2 = .Fields("ustr").Value

                            End With
                            rs.Close()
                            rs = Nothing

                            rs = New Recordset
                            rs.Open("SELECT name FROM spr_cart WHERE id =" & uname, DB7, CursorTypeEnum.adOpenDynamic,
                                    LockTypeEnum.adLockOptimistic)
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
                                uname1 = objIniFile.GetString("frmCRT3", "MSG17", "Нет")
                            Else
                                uname1 = objIniFile.GetString("frmCRT3", "MSG18", "Да")
                            End If


                            oTable.Cell(intj, 4).Range.Text = uname1


                            If uname2 = 0 Or Len(uname2) = 0 Then

                            Else
                                rs = New Recordset
                                rs.Open("SELECT filial, mesto FROM kompy WHERE id =" & uname2, DB7,
                                        CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic)
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

    Private Sub lvCartZAP_ColumnClick(ByVal sender As Object, ByVal e As ColumnClickEventArgs) _
        Handles lvCartZAP.ColumnClick

        SORTING_LV(lvCartZAP, e)

    End Sub

    Private Sub lvCartZAP_DoubleClick(ByVal sender As Object, ByVal e As EventArgs) Handles lvCartZAP.DoubleClick
        If lvCartZAP.Items.Count = 0 Then Exit Sub

        Dim z As Integer

        For z = 0 To lvCartZAP.SelectedItems.Count - 1
            zCOUNT = (lvCartZAP.SelectedItems(z).Text)
        Next

        frmCartr_Add_Zap.EDTRCARTZ = True

        Dim rs As Recordset
        rs = New Recordset

        rs.Open("SELECT * FROM CARTRIDG_Z where id=" & zCOUNT, DB7, CursorTypeEnum.adOpenDynamic,
                LockTypeEnum.adLockOptimistic)


        With rs
            frmCartr_Add_Zap.lblRealNumber.Text = .Fields("Z_N").Value
            'frmCartr_Add_Zap.cmbPost.Text = .Fields("Z_N").Value
            frmCartr_Add_Zap.txtAvR.Text = .Fields("AKTVR").Value
            frmCartr_Add_Zap.txtCashe.Text = .Fields("STOIM").Value
            frmCartr_Add_Zap.txtPage.Text = .Fields("Paper").Value
            frmCartr_Add_Zap.chkRef.Checked = .Fields("VOST").Value
            frmCartr_Add_Zap.dtAvR.Value = .Fields("DATAAKT").Value
            frmCartr_Add_Zap.dtDateZ.Value = .Fields("DATAZAP").Value

            Dim rs1 As Recordset

            rs1 = New Recordset
            rs1.Open("SELECT count(*) as t_n FROM SPR_Postav WHERE ID=" & .Fields("SC").Value, DB7,
                     CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic)
            Dim sCCC As String
            With rs1
                sCCC = .Fields("t_n").Value
            End With
            rs1.Close()
            rs1 = Nothing


            If sCCC > 0 Then

                rs1 = New Recordset
                rs1.Open("SELECT * FROM SPR_Postav WHERE ID=" & .Fields("SC").Value, DB7, CursorTypeEnum.adOpenDynamic,
                         LockTypeEnum.adLockOptimistic)

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

    Private Sub lstGroups_DragDrop(ByVal sender As Object, ByVal e As DragEventArgs) Handles lstGroups.DragDrop
        If uLevelTehAdd = False And uLevel <> "Admin" Then Exit Sub

        'Check that there is a TreeNode being dragged
        If e.Data.GetDataPresent("System.Windows.Forms.TreeNode", True) = False Then Exit Sub

        'Get the TreeView raising the event (incase multiple on form)
        Dim selectedTreeview As TreeView = CType(sender, TreeView)

        'Get the TreeNode being dragged
        Dim dropNode As TreeNode = CType(e.Data.GetData("System.Windows.Forms.TreeNode"), TreeNode)

        'The target node should be selected from the DragOver event
        Dim targetNode As TreeNode = selectedTreeview.SelectedNode

        'Remove the drop node from its current location
        dropNode.Remove()

        'If there is no targetNode add dropNode to the bottom of the TreeView root
        'nodes, otherwise add it to the end of the dropNode child nodes
        If targetNode Is Nothing Then

            selectedTreeview.Nodes.Add(dropNode)

            pDRAG = False

        Else


            pDRAG = True

            targetNode.Nodes.Add(dropNode)


        End If

        Dim objIniFile As New IniFile(sLANGPATH)

        'Ensure the newley created node is visible to the user and select it

        If pDRAG = True Then

            dropNode.EnsureVisible()
            selectedTreeview.SelectedNode = dropNode

            Me.Cursor = Cursors.WaitCursor

            Select Case cPREF

                Case "CRT"

                    If EDTRCART = True Then

                        Call DVIG_CRt(rCOUNT, lstGroups.SelectedNode.Text)

                        If DV = True Then

                        Else

                            If Sav = False Then

                                MsgBox(objIniFile.GetString("frmCRT3", "MSG10", "Отмена перемещения"),
                                       MsgBoxStyle.Exclamation, ProGramName)

                                If pDRAG = True Then

                                    Me.Invoke(New MethodInvoker(AddressOf RefFilTreePRN))

                                End If

                                Exit Sub

                            Else
                                Dim uSTXT As Decimal

                                If zPREF = "ZP" Then
                                    uSTXT = 1
                                    cCOUNT = zCC
                                Else
                                    uSTXT = 0
                                End If


                                'ТУТ КОД
                                Dim rs As Recordset
                                rs = New Recordset
                                rs.Open(
                                    "update CARTRIDG set USTR =" & cCOUNT & ", PREF=" & uSTXT & " WHERE id=" & rCOUNT,
                                    DB7, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic)
                                rs = Nothing

                            End If

                        End If
                    End If


            End Select

        End If

        pDRAG = False
        Me.Cursor = Cursors.Default
    End Sub

    Private Sub lstGroups_AfterSelect(ByVal sender As Object, ByVal e As TreeViewEventArgs) _
        Handles lstGroups.AfterSelect
        Me.Cursor = Cursors.WaitCursor
        Dim d() As String
        'Dim sTT As String

        lvCRTMove.Sorting = SortOrder.None
        lvCRTMove.ListViewItemSorter = Nothing
        lvCartZAP.Sorting = SortOrder.None
        lvCartZAP.ListViewItemSorter = Nothing

        lvCRTMove.Items.Clear()
        lvCartZAP.Items.Clear()
        cmbSostUstr.Text = ""

        Me.Invoke(New MethodInvoker(AddressOf PreLoad))


        TableLayoutPanel2.Enabled = True

        d = Split(lstGroups.SelectedNode.Tag, "|")

        cPREF = d(0)
        'zPREF = ""

        Dim LNGIniFile As New IniFile(sLANGPATH)

        Select Case d(0)

            Case "C"
                'zPREF = d(0)
                sTEXT = lstGroups.SelectedNode.Text
                cCOUNT = d(1)
                rCOUNT = 0

                btnAdd.Text = LNGIniFile.GetString("frmCRT3", "btnAdd", "Добавить")
                EDTRCART = False
                chkNaSP.Checked = 0
                chkSPS.Checked = 0
                chkIznos.Checked = 0
                chkNZ.Checked = 0
                chkNezap.Checked = 0
                txtCashe.Text = 0
                txtSaleNumb.Text = ""
                cmbSaler.Text = ""
                cmbSostUstr.Text = ""
                cmbModC.Text = ""
                cmbTipC.Text = ""
                cmbProizv.Text = ""
                txtSerNumb.Text = ""
                lblRealNumber.Text = ""
                txtMemo.Text = ""
                dtSale.Value = Date.Today

            Case "CRT"
                'zPREF = d(0)
                EDTRCART = True

                rCOUNT = d(1)
                'cCOUNT = d(1)


                LOAD_CRR2(d(1))

                Zap_load(d(1))

                LOAD_MOVE(d(1))


            Case "ZP"
                rCOUNT = 0
                zPREF = d(0)
                zCC = d(1)

                TableLayoutPanel2.Enabled = False


            Case Else

                If cPREF <> "GС" Then

                    TableLayoutPanel2.Enabled = False

                Else

                    TableLayoutPanel2.Enabled = True

                End If

                sTEXT = lstGroups.SelectedNode.Text
                cCOUNT = 0
                rCOUNT = 0
                zPREF = ""
                btnAdd.Text = LNGIniFile.GetString("frmCRT3", "btnAdd", "Добавить")
                EDTRCART = False
                chkNaSP.Checked = 0
                chkSPS.Checked = 0
                chkIznos.Checked = 0
                chkNZ.Checked = 0
                chkNezap.Checked = 0
                txtCashe.Text = 0
                txtSaleNumb.Text = ""
                cmbSaler.Text = ""
                cmbSostUstr.Text = ""
                cmbModC.Text = ""
                cmbTipC.Text = ""
                cmbProizv.Text = ""
                txtSerNumb.Text = ""
                lblRealNumber.Text = ""
                txtMemo.Text = ""
                dtSale.Value = Date.Today
        End Select


        Select Case d(0)

            Case "C"

                Dim objIniFile As New IniFile(PrPath & "base.ini")
                objIniFile.WriteString("general", "DK", d(1))
                objIniFile.WriteString("general", "Default", 0)

            Case "CRT"

                Dim objIniFile As New IniFile(PrPath & "base.ini")
                objIniFile.WriteString("general", "DK", d(1))
                objIniFile.WriteString("general", "Default", 0)

            Case Else

        End Select

        If EDTRCART = True Then

            Label6.Enabled = True
            cmbSostUstr.Enabled = True

        Else

            Label6.Enabled = False
            cmbSostUstr.Enabled = False

        End If


        Me.Cursor = Cursors.Default
    End Sub

    Private Sub lstGroups_DragEnter(ByVal sender As Object, ByVal e As DragEventArgs) Handles lstGroups.DragEnter
        If uLevelTehAdd = False And uLevel <> "Admin" Then Exit Sub

        'See if there is a TreeNode being dragged
        If e.Data.GetDataPresent("System.Windows.Forms.TreeNode", True) Then
            'TreeNode found allow move effect

            Dim d() As String
            d = Split(lstGroups.SelectedNode.Tag, "|")

            Select Case d(0)

                Case "C"

                    e.Effect = DragDropEffects.Move

                Case "ZP"

                    e.Effect = DragDropEffects.Move

                Case Else

                    Exit Sub


            End Select


        Else
            'No TreeNode found, prevent move
            pDRAG = False
            e.Effect = DragDropEffects.None
        End If
    End Sub

    Private Sub lstGroups_DragOver(ByVal sender As Object, ByVal e As DragEventArgs) Handles lstGroups.DragOver
        If uLevelTehAdd = False And uLevel <> "Admin" Then Exit Sub

        'Check that there is a TreeNode being dragged
        If e.Data.GetDataPresent("System.Windows.Forms.TreeNode", True) = False Then Exit Sub

        'Get the TreeView raising the event (incase multiple on form)
        Dim selectedTreeview As TreeView = CType(sender, TreeView)

        'As the mouse moves over nodes, provide feedback to the user
        'by highlighting the node that is the current drop target
        Dim pt As Drawing.Point = CType(sender, TreeView).PointToClient(New Drawing.Point(e.X, e.Y))
        Dim targetNode As TreeNode = selectedTreeview.GetNodeAt(pt)

        'See if the targetNode is currently selected, if so no need to validate again
        If Not (selectedTreeview Is targetNode) Then
            'Select the node currently under the cursor
            selectedTreeview.SelectedNode = targetNode

            'Check that the selected node is not the dropNode and also that it
            'is not a child of the dropNode and therefore an invalid target
            Dim dropNode As TreeNode = CType(e.Data.GetData("System.Windows.Forms.TreeNode"), TreeNode)

            Do Until targetNode Is Nothing

                If targetNode Is dropNode Then

                    e.Effect = DragDropEffects.None
                    pDRAG = False
                    Exit Sub

                End If

                Dim d() As String
                d = Split(lstGroups.SelectedNode.Tag, "|")

                Select Case d(0)

                    Case "C"

                        targetNode = targetNode.Parent


                    Case "GС"

                        targetNode = targetNode.Parent


                    Case "ZP"

                        targetNode = targetNode.Parent

                    Case Else

                        e.Effect = DragDropEffects.None

                        Exit Sub
                End Select


            Loop
        End If

        'Currently selected node is a suitable target, allow the move
        e.Effect = DragDropEffects.Move
    End Sub

    Private Sub lstGroups_ItemDrag(ByVal sender As Object, ByVal e As ItemDragEventArgs) Handles lstGroups.ItemDrag
        If uLevelTehAdd = False And uLevel <> "Admin" Then Exit Sub

        Dim d() As String
        d = Split(lstGroups.SelectedNode.Tag, "|")

        Select Case d(0)

            Case "CRT"

                pDRAG = True

                DoDragDrop(e.Item, DragDropEffects.Move)

            Case Else

                pDRAG = False

        End Select
    End Sub

    Private Sub DVIG_CRt(ByVal sUSTR As String, ByVal sCRT As String)
        On Error GoTo Error_
        Dim rs As Recordset
        Dim Message, Title, Defaults As String
        Dim strTmp As String
        Dim sTmp As String

        Dim iA, iB, iC, iD, iZ, iUSTR, iZAPR As String


        If EDTRCART = True Then

            DV = True


            If cCOUNT = 0 Then


            Else
                rs = New Recordset
                rs.Open("SELECT id,NET_NAME,filial,mesto,kabn FROM kompy where id =" & cCOUNT, DB7, CursorTypeEnum.adOpenDynamic,
                        LockTypeEnum.adLockOptimistic)

                With rs
                    sTEXT = .Fields("NET_NAME").Value
                    iB = .Fields("filial").Value
                    iC = .Fields("mesto").Value
                    iD = .Fields("kabn").Value
                End With
                rs.Close()
                rs = Nothing

                sTEXT = sTEXT & " " & iB & "/" & iC & "/" & iD

            End If


            rs = New Recordset
            rs.Open("SELECT * FROM CARTRIDG where id =" & rCOUNT, DB7, CursorTypeEnum.adOpenDynamic,
                    LockTypeEnum.adLockOptimistic)

            With rs
                iA = .Fields("USTR").Value
                iZ = .Fields("PREF").Value
                iUSTR = .Fields("USTR").Value

            End With
            rs.Close()
            rs = Nothing


            If iA = 0 Then

                iA = "Картриджи"

            Else

                If iZ = 0 Then


                    rs = New Recordset
                    rs.Open("SELECT id,NET_NAME,filial,mesto,kabn FROM kompy where id =" & iA, DB7, CursorTypeEnum.adOpenDynamic,
                            LockTypeEnum.adLockOptimistic)

                    With rs
                        iA = .Fields("NET_NAME").Value
                        iB = .Fields("filial").Value
                        iC = .Fields("mesto").Value
                        iD = .Fields("kabn").Value
                    End With
                    rs.Close()
                    rs = Nothing

                    iA = iA & " " & iB & "/" & iC & "/" & iD

                Else

                    rs = New Recordset
                    rs.Open("SELECT * FROM SPR_Postav where id=" & iUSTR, DB7, CursorTypeEnum.adOpenDynamic,
                            LockTypeEnum.adLockOptimistic)

                    With rs
                        iZAPR = .Fields("name").Value
                    End With
                    rs.Close()
                    rs = Nothing

                    iA = iZAPR

                End If

            End If

            Dim objIniFile As New IniFile(sLANGPATH)
            If iA <> sTEXT Then

                DV = False
                'objIniFile.GetString("frmCRT3", "btnAdd", "Добавить")
                Message = objIniFile.GetString("frmCRT3", "MSG19", "Укажите причину перемещения картриджа")
                Title = objIniFile.GetString("frmCRT3", "MSG20", "Перемещение картриджа")

                If iZ = 0 Then

                    Defaults = objIniFile.GetString("frmCRT3", "MSG21", "Причина")

                Else


                    Defaults = objIniFile.GetString("frmCRT3", "MSG22", "С заправки в") & " " & iZAPR

                End If


                strTmp = InputBox(Message, Title, Defaults)


                If strTmp = "" Then

                    Sav = False

                    Exit Sub

                Else
                    Sav = True


                End If


                rs = New Recordset
                rs.Open("SELECT * FROM CARTRIDG_D", DB7, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic)

                sTmp = (DateTime.Now.Hour & ":" & DateTime.Now.Minute & ":" & DateTime.Now.Second)

                With rs
                    .AddNew()
                    .Fields("id_comp").Value = rCOUNT
                    .Fields("oldMesto").Value = iA
                    .Fields("NewMesto").Value = sTEXT
                    .Fields("prich").Value = strTmp
                    .Fields("D_T").Value = Date.Today.Date
                    .Fields("T_M").Value = sTmp
                    .Update()
                End With
                rs.Close()
                rs = Nothing
                'Call SaveActivityToLogDB("Перемещение техники " & frmComputers.SelNde.Text & " из " & frmComputers.FilD & "/" & frmComputers.OtdD & " в " & sfilial & "/" & sOTDEL)
                If iZ = 0 Then


                Else
                    If rCOUNT = 0 Then Exit Sub

                    Dim C As Control

                    For Each C In frmCartr_Add_Zap.Controls
                        If TypeOf C Is TextBox Then C.Text = ""
                        If TypeOf C Is ComboBox Then C.Text = ""
                        If TypeOf C Is NumericUpDown Then C.Text = 0
                    Next C

                    C = Nothing

                    frmCartr_Add_Zap.cmbPost.Text = iZAPR

                    frmCartr_Add_Zap.dtAvR.Value = Date.Today.Date
                    frmCartr_Add_Zap.dtDateZ.Value = Date.Today.Date


                    frmCartr_Add_Zap.EDTRCARTZ = False
                    frmCartr_Add_Zap.ShowDialog(Me)

                End If

            Else

            End If

        Else

        End If


        Exit Sub
Error_:
        MsgBox(Err.Description, vbInformation, ProGramName)
    End Sub

    Public Sub LOAD_MOVE(ByVal sID As String)

        Dim sNom As Integer
        lvCRTMove.Items.Clear()

        Dim rscount As Recordset 'Объявляем рекордсет
        rscount = New Recordset
        rscount.Open("SELECT COUNT(*) AS total_number FROM CARTRIDG_D where id_comp=" & sID, DB7,
                     CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic)

        With rscount

            sNom = .Fields("total_number").Value

        End With

        rscount.Close()
        rscount = Nothing

        ResList(lvCRTMove)

        If sNom > 0 Then

            Dim rs As Recordset 'Объявляем рекордсет
            Dim sSQL As String 'Переменная, где будет размещён SQL запрос

            sSQL = "SELECT ID_comp, D_T, id, oldmesto, newmesto, prich, T_M FROM CARTRIDG_D where id_comp=" & sID &
                   " ORDER BY id"
            rs = New Recordset
            rs.Open(sSQL, DB7, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic)

            Dim intCount As Decimal = 0
            With rs
                .MoveFirst()
                Do While Not .EOF
                    'NomR = .Fields(0)
                    lvCRTMove.Items.Add(.Fields("id").Value) 'col no. 1

                    If Not IsDBNull(.Fields("oldmesto").Value) Then
                        lvCRTMove.Items(CInt(intCount)).SubItems.Add(.Fields("oldmesto").Value)
                    Else
                        lvCRTMove.Items(CInt(intCount)).SubItems.Add("")
                    End If

                    If Not IsDBNull(.Fields("newmesto").Value) Then
                        lvCRTMove.Items(CInt(intCount)).SubItems.Add(.Fields("newmesto").Value)
                    Else
                        lvCRTMove.Items(CInt(intCount)).SubItems.Add("")
                    End If

                    If Not IsDBNull(.Fields("prich").Value) Then
                        lvCRTMove.Items(CInt(intCount)).SubItems.Add(.Fields("prich").Value)
                    Else
                        lvCRTMove.Items(CInt(intCount)).SubItems.Add("")
                    End If

                    If Not IsDBNull(.Fields("D_T").Value) Then
                        lvCRTMove.Items(CInt(intCount)).SubItems.Add(.Fields("D_T").Value)
                    Else
                        lvCRTMove.Items(CInt(intCount)).SubItems.Add("")
                    End If

                    If Not IsDBNull(.Fields("T_M").Value) Then
                        lvCRTMove.Items(CInt(intCount)).SubItems.Add(.Fields("T_M").Value)
                    Else
                        lvCRTMove.Items(CInt(intCount)).SubItems.Add("")
                    End If

                    intCount = intCount + 1

                    .MoveNext()
                    'DoEvents
                Loop
            End With

            rs.Close()
            rs = Nothing

            ResList(lvCRTMove)

        End If
    End Sub

    Private Sub btnDelete_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnDelete.Click

        If rCOUNT = 0 Then Exit Sub
        If EDTRCART = False Then Exit Sub
        Dim objIniFile As New IniFile(sLANGPATH)


        If _
            MsgBox(
                objIniFile.GetString("frmCRT3", "MSG23", "Вы желаете удалить картридж?") & " " & vbNewLine & vbNewLine &
                lstGroups.SelectedNode.Text, vbExclamation + vbYesNo, "Удаление техники") = vbNo Then Exit Sub


        Dim rs1 As Recordset
        rs1 = New Recordset

        rs1.Open("Delete FROM CARTRIDG WHERE id=" & rCOUNT, DB7, CursorTypeEnum.adOpenDynamic,
                 LockTypeEnum.adLockOptimistic)

        rs1 = Nothing

        rs1 = New Recordset

        rs1.Open("Delete FROM CARTRIDG_Z WHERE id_c=" & rCOUNT, DB7, CursorTypeEnum.adOpenDynamic,
                 LockTypeEnum.adLockOptimistic)

        rs1 = Nothing

        rs1 = New Recordset

        rs1.Open("Delete FROM CARTRIDG_D WHERE Id_Comp=" & rCOUNT, DB7, CursorTypeEnum.adOpenDynamic,
                 LockTypeEnum.adLockOptimistic)

        rs1 = Nothing


        lstGroups.Nodes.Remove(lstGroups.SelectedNode)

        lvCartZAP.Items.Clear()
        lvCRTMove.Items.Clear()
    End Sub

    Private Sub txtSearch_KeyDown(ByVal sender As Object, ByVal e As KeyEventArgs) Handles txtSearch.KeyDown
        Select Case e.KeyCode

            Case Keys.Enter

                'search_ = True
                Search2(txtSearch.Text)
                FINDTXT_ = txtSearch.Text
                txtSearch.Text = ""

        End Select
    End Sub

    Private Sub Search2(ByVal sFindText As String, Optional ByVal MtchWord As Byte = 0,
                        Optional ByVal MtchCase As Byte = 0)

        lstGroups.Nodes.Clear()

        search_ = True
        Dim FirstColumn As Boolean

        Dim rs3 As Recordset 'Объявляем рекордсет
        Dim sSQL3 As String 'Переменная, где будет размещён SQL запрос
        Dim rs As Recordset 'Объявляем рекордсет
        Dim sSQL As String 'Переменная, где будет размещён SQL запрос

        On Error Resume Next

        Dim GID As Integer


        If MtchWord = 1 And MtchCase = 1 Then
            mde = 3
        Else
            If MtchWord = 1 And MtchCase = 0 Then
                mde = 2
            Else
                If MtchCase = 1 And MtchWord = 0 Then
                    mde = 1
                Else
                    If MtchCase = 0 And MtchWord = 0 Then
                        mde = 0
                    End If
                End If
            End If
        End If


        Dim rsG As Recordset
        rsG = New Recordset
        Dim objIniFile As New IniFile(sLANGPATH)


        rsG.Open("SELECT * FROM CONFIGURE", DB7, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic)
        Dim aaaa As String

        With rsG

            If Not IsDBNull(.Fields("Name_Prog").Value) Then aaaa = .Fields("Name_Prog").Value

        End With
        rsG.Close()
        rsG = Nothing


        Dim nodeRoot As New TreeNode(aaaa, 0, 0)
        nodeRoot.Tag = "ROOT" & GENID()

        lstGroups.Nodes.Add(nodeRoot)

        Dim TempNode2 As New TreeNode(objIniFile.GetString("frmCRT3", "MSG1", "Картриджи"), 0, 0)
        TempNode2.Tag = "G1|2"
        nodeRoot.Nodes.Add(TempNode2)

        sSQL = "SELECT * FROM CARTRIDG"
        sSQL =
            "Select CARTRIDG.Model,CARTRIDG.SN, CARTRIDG.TIP, CARTRIDG.SCHET, CARTRIDG.PRIM, CARTRIDG.id, spr_cart.Name FROM CARTRIDG INNER JOIN spr_cart ON CARTRIDG.Model = spr_cart.Id"
        rs = New Recordset
        rs.Open(sSQL, DB7, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic)

        With rs
            .MoveFirst()
            Do While Not .EOF
                FINDTXT = ""

                If Not IsDBNull(.Fields("SN").Value) Then _
                    If isThere(.Fields("SN").Value, sFindText, mde) = True Then GoTo FoundiR
                If Not IsDBNull(.Fields("TIP").Value) Then _
                    If isThere(.Fields("TIP").Value, sFindText, mde) = True Then GoTo FoundiR
                If Not IsDBNull(.Fields("SCHET").Value) Then _
                    If isThere(.Fields("SCHET").Value, sFindText, mde) = True Then GoTo FoundiR
                If Not IsDBNull(.Fields("PRIM").Value) Then _
                    If isThere(.Fields("PRIM").Value, sFindText, mde) = True Then GoTo FoundiR
                If Not IsDBNull(.Fields("Name").Value) Then _
                    If isThere(.Fields("Name").Value, sFindText, mde) = True Then GoTo FoundiR


FoundiR:
                If Len(FINDTXT) = 0 Then
                Else

                    Dim inising As Integer = .Fields("id").Value


                    Dim rsCRT As Recordset
                    rsCRT = New Recordset
                    rsCRT.Open("Select count(*) as t_n FROM CARTRIDG", DB7, CursorTypeEnum.adOpenDynamic,
                               LockTypeEnum.adLockOptimistic)
                    Dim CRT_ As String

                    With rsCRT
                        CRT_ = .Fields("t_n").Value
                    End With

                    rsCRT.Close()
                    rsCRT = Nothing

                    If CRT_ > 0 Then

                        Dim rsq As Recordset
                        rsq = New Recordset

                        sSQL =
                            "Select CARTRIDG.Model,CARTRIDG.SN, CARTRIDG.id, spr_cart.Name FROM CARTRIDG INNER JOIN spr_cart ON CARTRIDG.Model = spr_cart.Id WHERE CARTRIDG.Model=spr_cart.Id and CARTRIDG.Id =" &
                            inising & " ORDER BY spr_cart.Name"
                        rsq.Open(sSQL, DB7, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic)

                        Dim uname As String
                        With rsq
                            .MoveFirst()
                            Do While Not .EOF

                                Dim _
                                    TEHNodeCP As _
                                        New TreeNode(.Fields("Name").Value & "(" & .Fields("SN").Value & ")", 49, 49)
                                TEHNodeCP.Tag = "CRT|" & .Fields("id").Value
                                TempNode2.Nodes.Add(TEHNodeCP)

                                .MoveNext()
                            Loop
                        End With
                        rsq.Close()
                        rsq = Nothing


                    End If


                End If
                .MoveNext()
            Loop
        End With

        lstGroups.SelectedNode = nodeRoot

        Dim tNode As New TreeNode
        tNode = lstGroups.Nodes(0)
        tNode.Expand()

        rs3.Close()
        rs3 = Nothing
        rs.Close()
        rs = Nothing
    End Sub

    Private Sub txtSearch_TextChanged(ByVal sender As Object, ByVal e As EventArgs) Handles txtSearch.TextChanged
    End Sub

    Private Sub btnSearch_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnSearch.Click
        Me.Cursor = Cursors.WaitCursor
        Me.Invoke(New MethodInvoker(AddressOf RefFilTreePRN))
        txtSearch.Text = ""
        Me.Cursor = Cursors.Default
    End Sub

    Private Sub DVIG_CRt2(ByVal sUSTR As String, ByVal sCRT As String)
        On Error GoTo Error_
        Dim rs As Recordset
        Dim Message, Title, Defaults As String
        Dim strTmp As String
        Dim sTmp As String

        Dim iA, iB, iC, iD, iZ, iUSTR, iZAPR As String

        Dim OldM, NewM As String


        If EDTRCART = True Then

            DV = True

            rs = New Recordset
            rs.Open("SELECT * FROM CARTRIDG where id =" & rCOUNT, DB7, CursorTypeEnum.adOpenDynamic,
                    LockTypeEnum.adLockOptimistic)

            With rs

                iA = .Fields("USTR").Value
                iZ = .Fields("PREF").Value
                iUSTR = .Fields("USTR").Value

            End With
            rs.Close()
            rs = Nothing


            If iZ = 1 Then

                rs = New Recordset
                rs.Open("SELECT * FROM SPR_Postav where id=" & iUSTR, DB7, CursorTypeEnum.adOpenDynamic,
                        LockTypeEnum.adLockOptimistic)

                With rs
                    iZAPR = .Fields("name").Value
                End With
                rs.Close()
                rs = Nothing

                OldM = iZAPR

            Else


                If iUSTR = 0 Then

                    OldM = "Картридж"

                Else

                    rs = New Recordset
                    rs.Open("SELECT id,NET_NAME,filial,mesto,kabn FROM kompy where id =" & iUSTR, DB7, CursorTypeEnum.adOpenDynamic,
                            LockTypeEnum.adLockOptimistic)

                    With rs

                        OldM = .Fields("NET_NAME").Value & " " & .Fields("filial").Value & "/" & .Fields("mesto").Value &
                               "/" & .Fields("kabn").Value

                    End With
                    rs.Close()
                    rs = Nothing

                End If

            End If


            sTEXT = cmbSostUstr.Text


            If Len(cmbSostUstr.Text) = 0 Then
                sTEXT = 0
            Else


                Dim s1Tmp() As String
                s1Tmp = Split(sTEXT, " ")
                sTEXT = s1Tmp(2)


                Dim BASECOMP As Recordset
                BASECOMP = New Recordset
                BASECOMP.Open("SELECT id,PRINTER_NAME_1,filial,mesto,kabn FROM kompy where id=" & sTEXT, DB7, CursorTypeEnum.adOpenDynamic,
                              LockTypeEnum.adLockOptimistic)


                With BASECOMP

                    .MoveFirst()
                    Do While Not .EOF
                        ' If sTEXT = " № " & .Fields("id").Value & " " & .Fields("PRINTER_NAME_1").Value & " (" & .Fields("filial").Value & "/" & .Fields("mesto").Value & ")" Then
                        NewM = .Fields("PRINTER_NAME_1").Value & " " & .Fields("filial").Value & "/" &
                               .Fields("mesto").Value & "/" & .Fields("kabn").Value
                        ' End If
                        .MoveNext()
                        'DoEvents
                    Loop

                End With


                BASECOMP.Close()
                BASECOMP = Nothing

            End If


            If iA = 0 Then

                iA = "Картриджи"

            Else


            End If

            Dim objIniFile As New IniFile(sLANGPATH)

            If Len(cmbSostUstr.Text) = 0 Then NewM = "Картриджи"

            If OldM <> NewM Then

                DV = False

                Message = objIniFile.GetString("frmCRT3", "MSG19", "Укажите причину перемещения картриджа")

                Title = objIniFile.GetString("frmCRT3", "MSG20", "Перемещение картриджа")

                If iZ = 0 Then

                    Defaults = objIniFile.GetString("frmCRT3", "MSG21", "Причина")

                Else


                    Defaults = objIniFile.GetString("frmCRT3", "MSG22", "С заправки в") & " " & iZAPR

                End If


                strTmp = InputBox(Message, Title, Defaults)


                If strTmp = "" Then

                    Sav = False

                    Exit Sub

                Else
                    Sav = True


                End If


                rs = New Recordset
                rs.Open("SELECT * FROM CARTRIDG_D", DB7, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic)

                sTmp = (DateTime.Now.Hour & ":" & DateTime.Now.Minute & ":" & DateTime.Now.Second)


                With rs
                    .AddNew()
                    .Fields("id_comp").Value = rCOUNT
                    .Fields("oldMesto").Value = OldM
                    .Fields("NewMesto").Value = NewM
                    .Fields("prich").Value = strTmp
                    .Fields("D_T").Value = Date.Today.Date
                    .Fields("T_M").Value = sTmp
                    .Update()
                End With
                rs.Close()
                rs = Nothing
                'Call SaveActivityToLogDB("Перемещение техники " & frmComputers.SelNde.Text & " из " & frmComputers.FilD & "/" & frmComputers.OtdD & " в " & sfilial & "/" & sOTDEL)

                If iZ = 0 Then


                Else
                    If rCOUNT = 0 Then Exit Sub

                    Dim C As Control

                    For Each C In frmCartr_Add_Zap.Controls
                        If TypeOf C Is TextBox Then C.Text = ""
                        If TypeOf C Is ComboBox Then C.Text = ""
                        If TypeOf C Is NumericUpDown Then C.Text = 0
                    Next C

                    C = Nothing

                    frmCartr_Add_Zap.cmbPost.Text = iZAPR

                    frmCartr_Add_Zap.dtAvR.Value = Date.Today.Date
                    frmCartr_Add_Zap.dtDateZ.Value = Date.Today.Date


                    frmCartr_Add_Zap.EDTRCARTZ = False
                    frmCartr_Add_Zap.ShowDialog(Me)

                End If

            Else

            End If

        Else

        End If


        Exit Sub
Error_:
        MsgBox(Err.Description, vbInformation, ProGramName)
    End Sub

    Private Sub lstGroups_NodeMouseClick(ByVal sender As Object, ByVal e As TreeNodeMouseClickEventArgs) _
        Handles lstGroups.NodeMouseClick

        '#############################################
        'Выделение по правому клику мышкой
        '#############################################

        If e.Button = MouseButtons.Right Then
            Me.lstGroups.SelectedNode = e.Node
        End If
    End Sub

    Private Sub treebranche_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) _
        Handles treebranche.SelectedIndexChanged

        If OneStart = 0 Then Exit Sub

        Dim objIniFile As New IniFile(PrPath & "base.ini")
        objIniFile.WriteString("General", "branche", treebranche.Text)

        Me.Invoke(New MethodInvoker(AddressOf RefFilTreePRN))
    End Sub

    Private Sub lvCartZAP_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) _
        Handles lvCartZAP.SelectedIndexChanged
    End Sub

    Private Sub lvCRTMove_ColumnClick(ByVal sender As Object, ByVal e As ColumnClickEventArgs) _
        Handles lvCRTMove.ColumnClick

        SORTING_LV(lvCRTMove, e)

    End Sub

    Private Sub lvCRTMove_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) _
        Handles lvCRTMove.SelectedIndexChanged
    End Sub

    Private Sub btnZapDel_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnZapDel.Click
        If lvCartZAP.Items.Count = 0 Then Exit Sub

        Dim r1COUNT As Integer
        Dim z As Integer

        For z = 0 To lvCartZAP.SelectedItems.Count - 1
            r1COUNT = (lvCartZAP.SelectedItems(z).Text)
        Next

        Dim rs1 As Recordset
        rs1 = New Recordset

        rs1.Open("Delete FROM CARTRIDG_Z WHERE id=" & r1COUNT, DB7, CursorTypeEnum.adOpenDynamic,
                 LockTypeEnum.adLockOptimistic)

        rs1 = Nothing
    End Sub
End Class