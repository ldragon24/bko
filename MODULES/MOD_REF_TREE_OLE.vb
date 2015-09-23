'Imports System.Threading
'Imports System.Data.OleDb
'Module MOD_REF_TREE_OLE

'    Private lbl_M_F As String
'    Private lbl_M_F1 As String
'    Private lbl_M_F2 As String
'    Private FILIAL1, OTDEL1, KABINET1 As String
'    Private lstgroups1 As TreeView
'    Private BrancheNode1 As TreeNode
'    Private DepatrmentNode1 As TreeNode
'    Private OfficeNode1 As TreeNode

'    Private Sub FILING_FILIAL()
'        Dim zFIL As String

'        If Len(FILIAL1) = 0 Then Exit Sub


'        zFIL = FILIAL1



'        Dim iA1, iA2, iA3, iA4, iA5, iA6 As String

'        Dim sVISIBLE As String

'        Dim sSQL4 As String



'        Dim objIniFile As New IniFile(PrPath & "base.ini")
'        sVISIBLE = objIniFile.GetString("general", "VisibleALL", "")
'        KCKey = objIniFile.GetString("general", "DK", 0)
'        DCKey = objIniFile.GetString("general", "Default", 0)
'        'Вставляем технику если есть

'        Dim sText As String = objIniFile.GetString("general", "Tree_S", 0)

'        Select Case sText

'            Case 0

'                sSQL4 = "SELECT id, mesto, filial, tip_compa, tiptehn, PSEVDONIM, NET_NAME, kabn, Spisan, OS FROM kompy WHERE filial ='" & FILIAL1 & "' AND mesto ='" & OTDEL1 & "' AND kabn ='" & KABINET1 & "'  AND PCL =0 ORDER BY PSEVDONIM, tiptehn"

'            Case 1

'                sSQL4 = "SELECT id, mesto, filial, tip_compa, tiptehn, PSEVDONIM, NET_NAME, kabn, Spisan, OS FROM kompy WHERE filial ='" & FILIAL1 & "' AND mesto ='" & OTDEL1 & "' AND kabn ='" & KABINET1 & "' AND PCL =0 ORDER BY tiptehn, PSEVDONIM"

'        End Select

'        'Dim rs3 As ADODB.Recordset
'        'rs3 = New ADODB.Recordset
'        'rs3.Open(sSQL4, DB7, ADODB.CursorTypeEnum.adOpenDynamic, ADODB.LockTypeEnum.adLockOptimistic)


'        'With rs3
'        '    .MoveFirst()

'        '    Do While Not .EOF

'        '        If Not IsDBNull(.Fields("tip_compa").Value) Then iA1 = .Fields("tip_compa").Value
'        '        If Not IsDBNull(.Fields("NET_NAME").Value) Then iA2 = .Fields("NET_NAME").Value
'        '        If Not IsDBNull(.Fields("PSEVDONIM").Value) Then iA3 = .Fields("PSEVDONIM").Value
'        '        If Not IsDBNull(.Fields("Spisan").Value) Then iA4 = .Fields("Spisan").Value
'        '        If Not IsDBNull(.Fields("tiptehn").Value) Then iA5 = .Fields("tiptehn").Value
'        '        If Not IsDBNull(.Fields("OS").Value) Then iA6 = .Fields("OS").Value


'        '        FILING_TREE(lstgroups1, iA5, iA1, iA2, iA3, .Fields("id").Value, iA4, BrancheNode1, iA6)

'        '        .MoveNext()
'        '    Loop
'        'End With
'        'rs3.Close()
'        'rs3 = Nothing

'        Dim rs As OleDbDataReader
'        Dim cmd As OleDbCommand
'        Dim dr As OleDbDataReader


'        cmd = New OleDbCommand(sSQL4, DB8)
'        dr = cmd.ExecuteReader

'        While dr.Read()
'            'unamS2 = (dr.Item("t_nim"))

'            If Not IsDBNull(dr.Item("tip_compa")) Then iA1 = dr.Item("tip_compa")
'            If Not IsDBNull(dr.Item("NET_NAME")) Then iA2 = dr.Item("NET_NAME")
'            If Not IsDBNull(dr.Item("PSEVDONIM")) Then iA3 = dr.Item("PSEVDONIM")
'            If Not IsDBNull(dr.Item("Spisan")) Then iA4 = dr.Item("Spisan")
'            If Not IsDBNull(dr.Item("tiptehn")) Then iA5 = dr.Item("tiptehn")
'            If Not IsDBNull(dr.Item("OS")) Then iA6 = dr.Item("OS")


'            FILING_TREE(lstgroups1, iA5, iA1, iA2, iA3, dr.Item("id"), iA4, BrancheNode1, iA6)


'        End While
'        dr.Close()
'        dr = Nothing



'    End Sub


'    Public Sub RefFilTree_OLE(ByVal lstgroups As TreeView)
'        On Error GoTo ERR1


'        lstgroups.HideSelection = False

'        'On Error Resume Next
'        Dim sTEN As String
'        Dim sVISIBLE As String
'        Dim sSQL1 As String
'        Dim sSQL2 As String
'        Dim sSQL3 As String
'        Dim sSQL4 As String
'        Dim sSQL5 As String

'        Dim iA1, iA2, iA3, iA4, iA5, iA6 As String


'        Dim objIniFile As New IniFile(PrPath & "base.ini")
'        sVISIBLE = objIniFile.GetString("general", "VisibleALL", "")
'        KCKey = objIniFile.GetString("general", "DK", 0)
'        DCKey = objIniFile.GetString("general", "Default", 0)


'        Dim zBranche As String
'        zBranche = objIniFile.GetString("general", "branche", "")

'        Dim LNGIniFile As New IniFile(sLANGPATH)

'        If Len(zBranche) = 0 Or zBranche = LNGIniFile.GetString("frmComputers", "MSG53", "") Then

'            zBranche = "0"

'        Else


'        End If




'        lstgroups.Nodes.Clear()


'        lstgroups.ImageList = frmComputers.ilsCommands

'        Dim rs7 As OleDbDataReader
'        Dim rs3 As OleDbDataReader
'        Dim rs2 As OleDbDataReader
'        Dim rs6 As OleDbDataReader



'        Dim strItemText As String
'        Dim unamS2, unamS As Integer


'        Dim sSQL As String 'Переменная, где будет размещён SQL запрос
'        sSQL = "SELECT count(*) as t_nim FROM SPR_KAB"


'        Dim cmd As OleDbCommand
'        Dim dr As OleDbDataReader


'        cmd = New OleDbCommand(sSQL, DB8)
'        dr = cmd.ExecuteReader



'        While dr.Read()
'            unamS2 = (dr.Item("t_nim"))
'        End While
'        dr.Close()
'        dr = Nothing

'        If unamS2 = 0 Then

'        Else
'            If sVISIBLE = 1 Then
'                sSQL5 = "SELECT id, Name, N_F, N_M FROM SPR_KAB ORDER BY N_F, N_M, Name"
'            Else
'                sSQL5 = "SELECT id, Name, N_F, N_M FROM SPR_KAB where Arhiv=0 ORDER BY N_F, N_M, Name"
'            End If

'            'cmd = New OLEDBCommand(sSQL, DB8)
'            'rs7 = cmd.ExecuteReader()


'        End If


'        'Компы


'        sSQL = "SELECT count(*) as t_n FROM SPR_MESTO"


'        cmd = New OleDbCommand(sSQL, DB8)
'        rs6 = cmd.ExecuteReader()


'        While rs6.Read()
'            unamS = (rs6.Item("t_n"))
'        End While
'        rs6.Close()
'        rs6 = Nothing

'        Dim unameS As String
'        Dim unameS2 As String
'        Dim unameS3 As String
'        Dim unameS4 As String

'        'Верхний нулевой уровень - вставляем название организации

'        Dim ORG As String

'        Dim rsG As OleDbDataReader

'        sSQL = "SELECT * FROM CONFIGURE"


'        cmd = New OleDbCommand(sSQL, DB8)
'        rsG = cmd.ExecuteReader()

'        While rsG.Read()
'            If Not IsDBNull(rsG.Item("ORG")) Then ORG = rsG.Item("ORG")
'        End While
'        rsG.Close()
'        rsG = Nothing


'        Dim nodeRoot As New TreeNode(ORG, 0, 0)
'        nodeRoot.Tag = "ROOT" & GENID()
'        lstgroups.Nodes.Add(nodeRoot)


'        'Филиалы Первый уровень дерева
'        'Проверяем все показывать или только активные

'        If zBranche = "0" Then

'            If sVISIBLE = 1 Then
'                sSQL1 = "SELECT id, Filial FROM SPR_FILIAL ORDER BY Filial"
'            Else
'                sSQL1 = "SELECT id, Filial FROM SPR_FILIAL where Arhiv=0 ORDER BY Filial"
'            End If

'        Else

'            If sVISIBLE = 1 Then
'                sSQL1 = "SELECT id, Filial FROM SPR_FILIAL where filial ='" & zBranche & "' ORDER BY Filial"
'            Else
'                sSQL1 = "SELECT id, Filial FROM SPR_FILIAL where Arhiv=0 and filial ='" & zBranche & "' ORDER BY Filial"
'            End If

'        End If

'        Dim rsV As OleDbDataReader

'        cmd = New OleDbCommand(sSQL1, DB8)
'        rsV = cmd.ExecuteReader()


'        While rsV.Read()

'            Dim BrancheNode As New TreeNode(rsV.Item("filial"), 0, 0)
'            BrancheNode.Tag = "G|" & rsV.Item("id")
'            sTEN = "G|" & rsV.Item("id")
'            nodeRoot.Nodes.Add(BrancheNode)

'            FILIAL1 = rsV.Item("filial")
'            OTDEL1 = ""
'            KABINET1 = ""
'            BrancheNode1 = BrancheNode
'            lstgroups1 = lstgroups

'            unameS = rsV.Item("filial")

'            If KCKey = 0 And Len(DCKey) <> 0 Then
'                If DCKey = sTEN Then
'                    lstgroups.SelectedNode = BrancheNode
'                    lstgroups.SelectedNode.Expand()
'                End If
'            End If

'            BrancheNode.ForeColor = Color.DarkBlue


'            'Вставляем технику если есть
'            Dim cFil As String

'            sSQL4 = "SELECT count(*) as t_n FROM kompy WHERE filial ='" & unameS & "' AND mesto =''"


'            cmd = New OleDbCommand(sSQL4, DB8)
'            rs3 = cmd.ExecuteReader()

'            While rs3.Read()
'                cFil = rs3.Item("t_n")
'            End While
'            rs3.Close()
'            rs3 = Nothing

'            If cFil <> 0 Then


'                My.Application.DoEvents()

'                If frmComputers.lstGroups.InvokeRequired Then
'                    frmComputers.lstGroups.Invoke(New MethodInvoker(AddressOf FILING_FILIAL))
'                Else
'                    Call FILING_FILIAL()
'                End If



'            End If

'            'Отделы в филиалах Второй уровень дерева

'            If sVISIBLE = 1 Then
'                sSQL2 = "SELECT id, Filial, N_Otd FROM SPR_OTD_FILIAL WHERE filial='" & unameS & "' ORDER BY Filial, N_Otd"
'            Else
'                sSQL2 = "SELECT id, Filial, N_Otd FROM SPR_OTD_FILIAL where filial='" & unameS & "' AND Arhiv=0 ORDER BY Filial, N_Otd"
'            End If


'            cmd = New OleDbCommand(sSQL2, DB8)
'            rs2 = cmd.ExecuteReader()


'            While rs2.Read()

'                If rs2.Item("filial") = unameS Then

'                    Dim DepatrmentNode As New TreeNode(rs2.Item("N_Otd"), 1, 1)
'                    DepatrmentNode.Tag = "O|" & rs2.Item("id")
'                    sTEN = "O|" & rs2.Item("id")
'                    BrancheNode.Nodes.Add(DepatrmentNode)
'                    unameS2 = rs2.Item("N_Otd")

'                    DepatrmentNode1 = DepatrmentNode
'                    BrancheNode1 = DepatrmentNode

'                    OTDEL1 = rs2.Item("N_Otd")
'                    KABINET1 = ""


'                    If KCKey = 0 And Len(DCKey) <> 0 Then

'                        If DCKey = sTEN Then
'                            lstgroups.SelectedNode = DepatrmentNode
'                            lstgroups.SelectedNode.Expand()
'                        End If
'                    End If

'                    DepatrmentNode.ForeColor = Color.DarkGreen
'                    'DepatrmentNode.NodeFont = New Font(DepatrmentNode.NodeFont, FontStyle.Italic)


'                    sSQL4 = "SELECT count(*) as t_n FROM kompy WHERE filial ='" & unameS & "' AND mesto ='" & unameS2 & "' AND kabn=''"



'                    cmd = New OleDbCommand(sSQL4, DB8)
'                    rs3 = cmd.ExecuteReader()

'                    While rs3.Read()
'                        cFil = rs3.Item("t_n")
'                    End While
'                    rs3.Close()
'                    rs3 = Nothing


'                    If cFil <> 0 Then

'                        My.Application.DoEvents()

'                        If frmComputers.lstGroups.InvokeRequired Then
'                            frmComputers.lstGroups.Invoke(New MethodInvoker(AddressOf FILING_FILIAL))
'                        Else
'                            Call FILING_FILIAL()
'                        End If



'                    End If


'                    'Кабинеты Третий уровень дерева

'                    If unamS2 > 0 Then

'                        If sVISIBLE = 1 Then
'                            sSQL5 = "SELECT id, Name, N_F, N_M FROM SPR_KAB WHERE N_F='" & unameS & "' AND N_M ='" & unameS2 & "' ORDER BY N_F, N_M, Name"
'                        Else
'                            sSQL5 = "SELECT id, Name, N_F, N_M FROM SPR_KAB where N_F='" & unameS & "' AND N_M ='" & unameS2 & "' AND Arhiv=0 ORDER BY N_F, N_M, Name"
'                        End If


'                        cmd = New OleDbCommand(sSQL5, DB8)
'                        rs7 = cmd.ExecuteReader()

'                        While rs7.Read

'                            Dim OfficeNode As New TreeNode(rs7.Item("name"), 2, 2)
'                            OfficeNode.Tag = "K|" & rs7.Item("id")
'                            sTEN = "K|" & rs7.Item("id")
'                            DepatrmentNode.Nodes.Add(OfficeNode)
'                            unameS3 = rs7.Item("name")

'                            OfficeNode1 = OfficeNode
'                            BrancheNode1 = OfficeNode
'                            KABINET1 = rs7.Item("name")


'                            If KCKey = 0 And Len(DCKey) <> 0 Then

'                                If DCKey = sTEN Then
'                                    lstgroups.SelectedNode = OfficeNode
'                                    lstgroups.SelectedNode.Expand()
'                                End If
'                            End If

'                            OfficeNode.ForeColor = Color.DarkGoldenrod


'                            sSQL4 = "SELECT count(*) as t_n FROM kompy WHERE filial ='" & unameS & "' AND mesto ='" & unameS2 & "' AND kabn='" & unameS3 & "'"


'                            cmd = New OleDbCommand(sSQL4, DB8)
'                            rs3 = cmd.ExecuteReader()


'                            While rs3.Read()
'                                cFil = rs3.Item("t_n")
'                            End While
'                            rs3.Close()
'                            rs3 = Nothing

'                            If cFil <> 0 Then

'                                My.Application.DoEvents()

'                                If frmComputers.lstGroups.InvokeRequired Then
'                                    frmComputers.lstGroups.Invoke(New MethodInvoker(AddressOf FILING_FILIAL))
'                                Else
'                                    Call FILING_FILIAL()
'                                End If

'                                'Dim sText As String = objIniFile.GetString("general", "Tree_S", 0)

'                                'Select Case sText

'                                '    Case 0

'                                '        sSQL4 = "SELECT id, mesto, filial, tip_compa, tiptehn, PSEVDONIM, NET_NAME, kabn, Spisan, OS FROM kompy WHERE filial ='" & unameS & "' AND mesto ='" & unameS2 & "' AND kabn='" & unameS3 & "' AND PCL =0 ORDER BY PSEVDONIM, tiptehn"

'                                '    Case 1

'                                '        sSQL4 = "SELECT id, mesto, filial, tip_compa, tiptehn, PSEVDONIM, NET_NAME, kabn, Spisan, OS FROM kompy WHERE filial ='" & unameS & "' AND mesto ='" & unameS2 & "' AND kabn='" & unameS3 & "' AND PCL =0 ORDER BY tiptehn, PSEVDONIM"

'                                'End Select



'                                'cmd = New OleDbCommand(sSQL4, DB8)
'                                'rs3 = cmd.ExecuteReader()


'                                'While rs3.Read()

'                                '    If Not IsDBNull(rs3.Item("tip_compa")) Then iA1 = rs3.Item("tip_compa")
'                                '    If Not IsDBNull(rs3.Item("NET_NAME")) Then iA2 = rs3.Item("NET_NAME")
'                                '    If Not IsDBNull(rs3.Item("PSEVDONIM")) Then iA3 = rs3.Item("PSEVDONIM")
'                                '    If Not IsDBNull(rs3.Item("Spisan")) Then iA4 = rs3.Item("Spisan")
'                                '    If Not IsDBNull(rs3.Item("tiptehn")) Then iA5 = rs3.Item("tiptehn")
'                                '    If Not IsDBNull(rs3.Item("OS")) Then iA6 = rs3.Item("OS")

'                                '    FILING_TREE(lstgroups, iA5, iA1, iA2, iA3, rs3.Item("id"), iA4, OfficeNode, iA6)


'                                'End While
'                                'rs3.Close()
'                                'rs3 = Nothing
'                            End If

'                        End While
'                        rs7.Close()
'                        rs7 = Nothing

'                    End If
'                    'Конец кабинетов



'                End If
'            End While
'            rs2.Close()
'            rs2 = Nothing


'        End While

'        rsV.Close()
'        rsV = Nothing

'        'db8.close()


'        If KCKey = 0 And Len(DCKey) = 0 Then

'            lstgroups.SelectedNode = nodeRoot
'            Dim tNode As New TreeNode
'            tNode = lstgroups.Nodes(0)
'            tNode.Expand()

'        End If


'exitsub:


'        Exit Sub
'ERR1:
'        'MsgBox Err.Description
'        Select Case Err.Number
'            Case 3021 'ignore, no entries in list
'                'MsgBox(Err.Description, vbCritical, "KZ")
'                Resume Next
'            Case Else

'                MsgBox(Err.Description, vbCritical, ProGramName)

'        End Select


'    End Sub

'    Private Sub FILING_TREE(ByVal lstgroups As TreeView, ByVal iTipTehn As String, ByVal TipPC As String, ByVal NET_NAME As String, ByVal PSEVDONIM As String, ByVal iD As String, ByVal Spisan As String, ByVal DepNode As TreeNode, ByVal OS As String)

'        Dim iC As String
'        Dim iA As String
'        Dim iB As String
'        Dim sTREENAME As String
'        Dim N_NAME As String
'        Dim P_NAME As String
'        Dim L_NAME As String
'        Dim iPSid As Long
'        Dim uNameS As String

'        Dim objIniFile As New IniFile(PrPath & "base.ini")
'        KCKey = objIniFile.GetString("general", "DK", 0)
'        DCKey = objIniFile.GetString("general", "Default", 0)
'        sTREENAME = objIniFile.GetString("general", "NETNAME", "1")

'        If iTipTehn = "PC" Then
'            iC = TipPC
'        Else
'            iC = "Рабочая станция"
'        End If

'        If iC = "Ноутбук" Or iC = "notebook" Or iC = "Notebook" Or iC = "NoteBook" Then
'            iC = "Ноутбук"
'        End If

'        If iC = "КПК" Or iC = "Pocket PC" Or iC = "Pocket" Or iC = "Palm" Then
'            iC = "КПК"
'        End If

'        If iC = "Сервер" Or iC = "Server" Or iC = "Сервер для тонких клиентов" Or iC = "Сервер видео наблюдения" Then
'            iC = "Сервер"
'        End If


'        Select Case iC

'            Case "Рабочая станция"
'                iA = 4
'                iB = 4

'            Case "Сервер"

'                iA = 3
'                iB = 3

'            Case "КПК"
'                iA = 31
'                iB = 31
'            Case "Ноутбук"
'                iA = 5
'                iB = 5

'            Case Else
'                iA = 4
'                iB = 4

'        End Select


'        'Определяем подчиненное оборудование (в составе)
'        Dim d() As String

'        If iTipTehn = "MONITOR" Then

'            If Len(OS) > 0 Then
'                d = Split(OS, "№")
'            End If

'        End If



'        Select Case sTREENAME

'            Case 0
'                N_NAME = NET_NAME
'                P_NAME = PSEVDONIM

'                If Len(N_NAME) = 0 Then
'                    N_NAME = "NoName"
'                End If

'                If Len(P_NAME) = 0 Then
'                    P_NAME = "NoName"
'                End If
'                L_NAME = N_NAME & " (" & P_NAME & ")"

'            Case 2
'                P_NAME = PSEVDONIM

'                If Len(P_NAME) = 0 Then
'                    P_NAME = "NoName"
'                End If
'                L_NAME = P_NAME

'            Case 1

'                N_NAME = NET_NAME
'                If Len(N_NAME) = 0 Then
'                    N_NAME = "NoName"
'                End If

'                L_NAME = N_NAME

'        End Select


'        Select Case iTipTehn



'            Case "CNT"

'                Dim uname As String
'                Dim cmd As OleDbCommand
'                On Error Resume Next


'                If Len(NET_NAME) = 0 Then

'                    uname = ""

'                Else


'                    Dim dr As OleDbDataReader

'                    cmd = New OleDbCommand("SELECT A FROM spr_other where Name ='" & NET_NAME & "'", DB8)
'                    dr = cmd.ExecuteReader

'                    While dr.Read()
'                        If Not IsDBNull(dr.Item("A")) Then uname = dr.Item("A")
'                    End While
'                    dr.Close()
'                    dr = Nothing


'                End If

'                Dim TEHNodePS As New TreeNode(L_NAME, uname, uname)
'                'Dim TEHNode As New TreeNode(L_NAME, iA, iA)
'                TEHNodePS.Tag = "C|" & iD
'                DepNode.Nodes.Add(TEHNodePS)

'                If Spisan = "1" Or Spisan = "True" Or Spisan = "-1" Then
'                    TEHNodePS.ForeColor = Color.Red

'                End If

'                If KCKey <> 0 Then
'                    If KCKey = iD Then
'                        lstgroups.SelectedNode = TEHNodePS
'                        lstgroups.SelectedNode.Expand()
'                    End If
'                End If

'                '#####################################################################
'                '#####################################################################
'                '#                          КОНТЕЙНЕР
'                '#####################################################################
'                '#####################################################################

'                Dim sText As String = objIniFile.GetString("general", "Tree_S", 0)
'                Dim sSQL4 As String

'                sSQL4 = "SELECT count(*) as t_n FROM kompy WHERE PCL =" & iD

'                Dim sCount As String
'                cmd = New OleDbCommand(sSQL4, DB8)
'                Dim dr1 As OleDbDataReader

'                dr1 = cmd.ExecuteReader()
'                While dr1.Read()
'                    If Not IsDBNull(dr1.Item("t_n")) Then sCount = dr1.Item("t_n")
'                End While
'                dr1.Close()
'                dr1 = Nothing





'                If sCount > 0 Then



'                    Select Case sText

'                        Case 0

'                            sSQL4 = "SELECT id, mesto, filial, tip_compa, tiptehn, PSEVDONIM, NET_NAME, kabn, Spisan, OS FROM kompy WHERE PCL =" & iD & " ORDER BY PSEVDONIM, tiptehn"

'                        Case 1

'                            sSQL4 = "SELECT id, mesto, filial, tip_compa, tiptehn, PSEVDONIM, NET_NAME, kabn, Spisan, OS FROM kompy WHERE PCL =" & iD & " ORDER BY tiptehn, PSEVDONIM"

'                    End Select


'                    cmd = New OleDbCommand(sSQL4, DB8)
'                    Dim rs3 As OleDbDataReader

'                    rs3 = cmd.ExecuteReader()

'                    While rs3.Read()


'                        Select Case sTREENAME

'                            Case 0
'                                N_NAME = rs3.Item("NET_NAME")
'                                P_NAME = rs3.Item("PSEVDONIM")

'                                If Len(N_NAME) = 0 Then
'                                    N_NAME = "NoName"
'                                End If

'                                If Len(P_NAME) = 0 Then
'                                    P_NAME = "NoName"
'                                End If
'                                L_NAME = N_NAME & " (" & P_NAME & ")"

'                            Case 2
'                                P_NAME = rs3.Item("PSEVDONIM")

'                                If Len(P_NAME) = 0 Then
'                                    P_NAME = "NoName"
'                                End If
'                                L_NAME = P_NAME

'                            Case 1

'                                N_NAME = rs3.Item("NET_NAME")
'                                If Len(N_NAME) = 0 Then
'                                    N_NAME = "NoName"
'                                End If

'                                L_NAME = N_NAME

'                        End Select

'                        '###############################################################################################################
'                        Select Case rs3.Item("tiptehn")

'                            Case "NET"
'                                Dim TEHNodePC As New TreeNode(L_NAME, 10, 10)
'                                TEHNodePC.Tag = "C|" & rs3.Item("id")
'                                TEHNodePS.Nodes.Add(TEHNodePC)
'                                iD = rs3.Item("id")

'                                If Spisan = "1" Or Spisan = "True" Or Spisan = "-1" Then
'                                    TEHNodePC.ForeColor = Color.Red
'                                End If

'                                If KCKey <> 0 Then
'                                    If KCKey = iD Then
'                                        lstgroups.SelectedNode = TEHNodePC
'                                        lstgroups.SelectedNode.Expand()
'                                    End If
'                                End If

'                            Case "PC"

'                                iC = rs3.Item("TIP_COMPA")


'                                If iC = "Ноутбук" Or iC = "notebook" Or iC = "Notebook" Or iC = "NoteBook" Then
'                                    iC = "Ноутбук"
'                                End If

'                                If iC = "КПК" Or iC = "Pocket PC" Or iC = "Pocket" Or iC = "Palm" Then
'                                    iC = "КПК"
'                                End If

'                                If iC = "Сервер" Or iC = "Server" Or iC = "Сервер для тонких клиентов" Or iC = "Сервер видео наблюдения" Then
'                                    iC = "Сервер"
'                                End If

'                                'Pocket PC

'                                Select Case iC

'                                    Case "Рабочая станция"
'                                        iA = 4
'                                        iB = 4

'                                    Case "Сервер"

'                                        iA = 3
'                                        iB = 3

'                                    Case "КПК"
'                                        iA = 31
'                                        iB = 31

'                                    Case "Ноутбук"
'                                        iA = 5
'                                        iB = 5

'                                    Case Else
'                                        iA = 4
'                                        iB = 4


'                                End Select


'                                Dim TEHNodePC As New TreeNode(L_NAME, iA, iB)
'                                iD = rs3.Item("id")
'                                TEHNodePC.Tag = "C|" & rs3.Item("id")
'                                iPSid = rs3.Item("id")

'                                TEHNodePS.Nodes.Add(TEHNodePC)

'                                'TEHNode.ForeColor = Color.Blue

'                                If Spisan = "1" Or Spisan = "True" Or Spisan = "-1" Then
'                                    TEHNodePC.ForeColor = Color.Red
'                                End If

'                                If KCKey <> 0 Then
'                                    If KCKey = rs3.Item("id") Then
'                                        lstgroups.SelectedNode = TEHNodePC
'                                        lstgroups.SelectedNode.Expand()
'                                    End If
'                                End If


'                                '########################################################################
'                                '########################################################################
'                                '########################################################################

'                                ' Dim sText As String = objIniFile.GetString("general", "Tree_S", 0)
'                                ' Dim sSQL4 As String


'                                sSQL4 = "SELECT count(*) as t_n FROM kompy WHERE PCL =" & iD

'                                'Dim sCount As String

'                                'Dim cmd As OleDbCommand
'                                Dim dr As OleDbDataReader


'                                cmd = New OleDbCommand(sSQL4, DB8)
'                                dr = cmd.ExecuteReader

'                                While dr.Read()
'                                    sCount = dr.Item("t_n")
'                                End While
'                                dr.Close()
'                                dr = Nothing


'                                If sCount > 0 Then



'                                    Select Case sText

'                                        Case 0

'                                            sSQL4 = "SELECT id, mesto, filial, tip_compa, tiptehn, PSEVDONIM, NET_NAME, kabn, Spisan, OS FROM kompy WHERE PCL =" & iD & " ORDER BY PSEVDONIM, tiptehn"

'                                        Case 1

'                                            sSQL4 = "SELECT id, mesto, filial, tip_compa, tiptehn, PSEVDONIM, NET_NAME, kabn, Spisan, OS FROM kompy WHERE PCL =" & iD & " ORDER BY tiptehn, PSEVDONIM"

'                                    End Select


'                                    cmd = New OleDbCommand(sSQL4, DB8)
'                                    Dim rs15 As OleDbDataReader

'                                    rs15 = cmd.ExecuteReader()

'                                    While rs15.Read()


'                                        Select Case sTREENAME

'                                            Case 0
'                                                N_NAME = rs15.Item("NET_NAME")
'                                                P_NAME = rs15.Item("PSEVDONIM")

'                                                If Len(N_NAME) = 0 Then
'                                                    N_NAME = "NoName"
'                                                End If

'                                                If Len(P_NAME) = 0 Then
'                                                    P_NAME = "NoName"
'                                                End If
'                                                L_NAME = N_NAME & " (" & P_NAME & ")"

'                                            Case 2
'                                                P_NAME = rs15.Item("PSEVDONIM")

'                                                If Len(P_NAME) = 0 Then
'                                                    P_NAME = "NoName"
'                                                End If
'                                                L_NAME = P_NAME

'                                            Case 1

'                                                N_NAME = rs15.Item("NET_NAME")
'                                                If Len(N_NAME) = 0 Then
'                                                    N_NAME = "NoName"
'                                                End If

'                                                L_NAME = N_NAME

'                                        End Select


'                                        Select Case rs15.Item("tiptehn")


'                                            Case "Printer"
'                                                Dim TEHNode As New TreeNode(L_NAME, 7, 7)
'                                                TEHNode.Tag = "C|" & rs15.Item("id")
'                                                TEHNodePC.Nodes.Add(TEHNode)

'                                                If Spisan = "1" Or Spisan = "True" Or Spisan = "-1" Then
'                                                    TEHNode.ForeColor = Color.Red

'                                                End If

'                                                If KCKey <> 0 Then
'                                                    If KCKey = rs15.Item("id") Then
'                                                        lstgroups.SelectedNode = TEHNode
'                                                        lstgroups.SelectedNode.Expand()
'                                                    End If
'                                                End If

'                                            Case "MFU"

'                                                Dim TEHNode As New TreeNode(L_NAME, 8, 8)
'                                                TEHNode.Tag = "C|" & rs15.Item("id")
'                                                TEHNodePC.Nodes.Add(TEHNode)

'                                                If Spisan = "1" Or Spisan = "True" Or Spisan = "-1" Then
'                                                    TEHNode.ForeColor = Color.Red

'                                                End If

'                                                If KCKey <> 0 Then
'                                                    If KCKey = rs15.Item("id") Then
'                                                        lstgroups.SelectedNode = TEHNode
'                                                        lstgroups.SelectedNode.Expand()
'                                                    End If
'                                                End If


'                                            Case "SCANER"

'                                                Dim TEHNode As New TreeNode(L_NAME, 14, 14)
'                                                TEHNode.Tag = "C|" & rs15.Item("id")
'                                                TEHNodePC.Nodes.Add(TEHNode)

'                                                If Spisan = "1" Or Spisan = "True" Or Spisan = "-1" Then
'                                                    TEHNode.ForeColor = Color.Red

'                                                End If

'                                                If KCKey <> 0 Then
'                                                    If KCKey = rs15.Item("id") Then
'                                                        lstgroups.SelectedNode = TEHNode
'                                                        lstgroups.SelectedNode.Expand()
'                                                    End If
'                                                End If

'                                            Case "ZIP"
'                                                Dim TEHNode As New TreeNode(L_NAME, 15, 15)
'                                                TEHNode.Tag = "C|" & rs15.Item("id")
'                                                TEHNodePC.Nodes.Add(TEHNode)

'                                                If Spisan = "1" Or Spisan = "True" Or Spisan = "-1" Then
'                                                    TEHNode.ForeColor = Color.Red

'                                                End If

'                                                If KCKey <> 0 Then
'                                                    If KCKey = rs15.Item("id") Then
'                                                        lstgroups.SelectedNode = TEHNode
'                                                        lstgroups.SelectedNode.Expand()

'                                                    End If
'                                                End If

'                                            Case "PHONE"
'                                                Dim TEHNode As New TreeNode(L_NAME, 12, 12)
'                                                TEHNode.Tag = "C|" & rs15.Item("id")
'                                                TEHNodePC.Nodes.Add(TEHNode)

'                                                If Spisan = "1" Or Spisan = "True" Or Spisan = "-1" Then
'                                                    TEHNode.ForeColor = Color.Red

'                                                End If

'                                                If KCKey <> 0 Then
'                                                    If KCKey = rs15.Item("id") Then
'                                                        lstgroups.SelectedNode = TEHNode
'                                                        lstgroups.SelectedNode.Expand()

'                                                    End If
'                                                End If


'                                            Case "OT"

'                                                ' Dim uname As String

'                                                On Error Resume Next


'                                                If Len(rs15.Item("tip_compa")) = 0 Then

'                                                    uname = ""
'                                                Else

'                                                    Dim rsOT As ADODB.Recordset
'                                                    rsOT = New ADODB.Recordset
'                                                    rsOT.Open("SELECT A FROM spr_other where Name ='" & rs15.Item("tip_compa") & "'", DB7, ADODB.CursorTypeEnum.adOpenDynamic, ADODB.LockTypeEnum.adLockOptimistic)

'                                                    With rsOT
'                                                        '.MoveFirst()
'                                                        'Do While Not .EOF

'                                                        If Not IsDBNull(rs15.Item("A")) Then uname = rs15.Item("A")

'                                                        '.MoveNext()
'                                                        'Loop
'                                                    End With


'                                                    rsOT.Close()
'                                                    rsOT = Nothing


'                                                End If


'                                                If Len(uname) = 0 Or uname = " " Or uname = " 0" Or uname = "" Then
'                                                    iA = 16
'                                                Else
'                                                    iA = uname
'                                                End If


'                                                Dim TEHNode As New TreeNode(L_NAME, iA, iA)
'                                                TEHNode.Tag = "C|" & rs15.Item("id")
'                                                TEHNodePC.Nodes.Add(TEHNode)

'                                                If Spisan = "1" Or Spisan = "True" Or Spisan = "-1" Then
'                                                    TEHNode.ForeColor = Color.Red

'                                                End If

'                                                If KCKey <> 0 Then
'                                                    If KCKey = rs15.Item("id") Then
'                                                        lstgroups.SelectedNode = TEHNode
'                                                        lstgroups.SelectedNode.Expand()
'                                                    End If
'                                                End If

'                                            Case "MONITOR"

'                                                Dim TEHNode As New TreeNode(L_NAME, 17, 17)
'                                                TEHNode.Tag = "C|" & rs15.Item("id")
'                                                TEHNodePC.Nodes.Add(TEHNode)

'                                                If Spisan = "1" Or Spisan = "True" Or Spisan = "-1" Then
'                                                    TEHNode.ForeColor = Color.Red

'                                                End If

'                                                If KCKey <> 0 Then
'                                                    If KCKey = rs15.Item("id") Then
'                                                        lstgroups.SelectedNode = TEHNode
'                                                        lstgroups.SelectedNode.Expand()
'                                                    End If
'                                                End If


'                                                '--------------VIP_Graff Добавление новой перефирии Начало-----------------
'                                            Case "USB"
'                                                Dim TEHNode As New TreeNode(L_NAME, 64, 64)
'                                                TEHNode.Tag = "C|" & rs15.Item("id")
'                                                TEHNodePC.Nodes.Add(TEHNode)
'                                                If Spisan = "1" Or Spisan = "True" Or Spisan = "-1" Then
'                                                    TEHNode.ForeColor = Color.Red
'                                                End If
'                                                If KCKey <> 0 Then
'                                                    If KCKey = rs15.Item("id") Then
'                                                        lstgroups.SelectedNode = TEHNode
'                                                        lstgroups.SelectedNode.Expand()
'                                                    End If
'                                                End If

'                                            Case "SOUND"
'                                                Dim TEHNode As New TreeNode(L_NAME, 44, 44)
'                                                TEHNode.Tag = "C|" & rs15.Item("id")
'                                                TEHNodePC.Nodes.Add(TEHNode)
'                                                If Spisan = "1" Or Spisan = "True" Or Spisan = "-1" Then
'                                                    TEHNode.ForeColor = Color.Red
'                                                End If
'                                                If KCKey <> 0 Then
'                                                    If KCKey = rs15.Item("id") Then
'                                                        lstgroups.SelectedNode = TEHNode
'                                                        lstgroups.SelectedNode.Expand()
'                                                    End If
'                                                End If

'                                            Case "IBP"
'                                                Dim TEHNode As New TreeNode(L_NAME, 41, 41)
'                                                TEHNode.Tag = "C|" & rs15.Item("id")
'                                                TEHNodePC.Nodes.Add(TEHNode)
'                                                If Spisan = "1" Or Spisan = "True" Or Spisan = "-1" Then
'                                                    TEHNode.ForeColor = Color.Red
'                                                End If
'                                                If KCKey <> 0 Then
'                                                    If KCKey = rs15.Item("id") Then
'                                                        lstgroups.SelectedNode = TEHNode
'                                                        lstgroups.SelectedNode.Expand()
'                                                    End If
'                                                End If

'                                            Case "FS"
'                                                Dim TEHNode As New TreeNode(L_NAME, 65, 65)
'                                                TEHNode.Tag = "C|" & rs15.Item("id")
'                                                TEHNodePC.Nodes.Add(TEHNode)
'                                                If Spisan = "1" Or Spisan = "True" Or Spisan = "-1" Then
'                                                    TEHNode.ForeColor = Color.Red
'                                                End If
'                                                If KCKey <> 0 Then
'                                                    If KCKey = rs15.Item("id") Then
'                                                        lstgroups.SelectedNode = TEHNode
'                                                        lstgroups.SelectedNode.Expand()
'                                                    End If
'                                                End If

'                                            Case "KEYB"
'                                                Dim TEHNode As New TreeNode(L_NAME, 46, 46)
'                                                TEHNode.Tag = "C|" & rs15.Item("id")
'                                                TEHNodePC.Nodes.Add(TEHNode)
'                                                If Spisan = "1" Or Spisan = "True" Or Spisan = "-1" Then
'                                                    TEHNode.ForeColor = Color.Red
'                                                End If
'                                                If KCKey <> 0 Then
'                                                    If KCKey = rs15.Item("id") Then
'                                                        lstgroups.SelectedNode = TEHNode
'                                                        lstgroups.SelectedNode.Expand()
'                                                    End If
'                                                End If

'                                            Case "MOUSE"
'                                                Dim TEHNode As New TreeNode(L_NAME, 47, 47)
'                                                TEHNode.Tag = "C|" & rs15.Item("id")
'                                                TEHNodePC.Nodes.Add(TEHNode)
'                                                If Spisan = "1" Or Spisan = "True" Or Spisan = "-1" Then
'                                                    TEHNode.ForeColor = Color.Red
'                                                End If
'                                                If KCKey <> 0 Then
'                                                    If KCKey = rs15.Item("id") Then
'                                                        lstgroups.SelectedNode = TEHNode
'                                                        lstgroups.SelectedNode.Expand()
'                                                    End If
'                                                End If
'                                                '--------------VIP_Graff Добавление новой перефирии Конец------------------

'                                            Case Else


'                                        End Select


'                                    End While

'                                    rs15.Close()
'                                    rs15 = Nothing

'                                End If


'                            Case "Printer"

'                                Dim TEHNode As New TreeNode(L_NAME, 7, 7)
'                                TEHNode.Tag = "C|" & rs3.Item("id")
'                                TEHNodePS.Nodes.Add(TEHNode)

'                                If Spisan = "1" Or Spisan = "True" Or Spisan = "-1" Then
'                                    TEHNode.ForeColor = Color.Red

'                                End If

'                                If KCKey <> 0 Then
'                                    If KCKey = rs3.Item("id") Then
'                                        lstgroups.SelectedNode = TEHNode
'                                        lstgroups.SelectedNode.Expand()
'                                    End If
'                                End If

'                            Case "MFU"

'                                Dim TEHNode As New TreeNode(L_NAME, 8, 8)
'                                TEHNode.Tag = "C|" & rs3.Item("id")
'                                TEHNodePS.Nodes.Add(TEHNode)

'                                If Spisan = "1" Or Spisan = "True" Or Spisan = "-1" Then
'                                    TEHNode.ForeColor = Color.Red

'                                End If

'                                If KCKey <> 0 Then
'                                    If KCKey = rs3.Item("id") Then
'                                        lstgroups.SelectedNode = TEHNode
'                                        lstgroups.SelectedNode.Expand()
'                                    End If
'                                End If


'                            Case "SCANER"

'                                Dim TEHNode As New TreeNode(L_NAME, 14, 14)
'                                TEHNode.Tag = "C|" & rs3.Item("id")
'                                TEHNodePS.Nodes.Add(TEHNode)

'                                If Spisan = "1" Or Spisan = "True" Or Spisan = "-1" Then
'                                    TEHNode.ForeColor = Color.Red

'                                End If

'                                If KCKey <> 0 Then
'                                    If KCKey = rs3.Item("id") Then
'                                        lstgroups.SelectedNode = TEHNode
'                                        lstgroups.SelectedNode.Expand()
'                                    End If
'                                End If

'                            Case "ZIP"
'                                Dim TEHNode As New TreeNode(L_NAME, 15, 15)
'                                TEHNode.Tag = "C|" & rs3.Item("id")
'                                TEHNodePS.Nodes.Add(TEHNode)

'                                If Spisan = "1" Or Spisan = "True" Or Spisan = "-1" Then
'                                    TEHNode.ForeColor = Color.Red

'                                End If

'                                If KCKey <> 0 Then
'                                    If KCKey = rs3.Item("id") Then
'                                        lstgroups.SelectedNode = TEHNode
'                                        lstgroups.SelectedNode.Expand()

'                                    End If
'                                End If

'                            Case "PHONE"
'                                Dim TEHNode As New TreeNode(L_NAME, 12, 12)
'                                TEHNode.Tag = "C|" & rs3.Item("id")
'                                TEHNodePS.Nodes.Add(TEHNode)

'                                If Spisan = "1" Or Spisan = "True" Or Spisan = "-1" Then
'                                    TEHNode.ForeColor = Color.Red

'                                End If

'                                If KCKey <> 0 Then
'                                    If KCKey = rs3.Item("id") Then
'                                        lstgroups.SelectedNode = TEHNode
'                                        lstgroups.SelectedNode.Expand()

'                                    End If
'                                End If


'                            Case "OT"

'                                'Dim uname As String

'                                On Error Resume Next


'                                If Len(TipPC) = 0 Then

'                                    uname = ""
'                                Else

'                                    'Dim cmd As OleDbCommand
'                                    Dim dr As OleDbDataReader


'                                    cmd = New OleDbCommand("SELECT * FROM spr_other where Name ='" & TipPC & "'", DB8)
'                                    Dim dr12 As OleDbDataReader

'                                    dr12 = cmd.ExecuteReader()



'                                    While dr12.Read()
'                                        If Not IsDBNull(dr12.Item("A")) Then uname = dr12.Item("A")
'                                    End While
'                                    dr12.Close()
'                                    dr12 = Nothing

'                                End If


'                                If Len(uname) = 0 Or uname = " " Or uname = " 0" Or uname = "" Then
'                                    iA = 16
'                                Else
'                                    iA = uname
'                                End If


'                                Dim TEHNode As New TreeNode(L_NAME, iA, iA)
'                                TEHNode.Tag = "C|" & rs3.Item("id")
'                                TEHNodePS.Nodes.Add(TEHNode)

'                                If Spisan = "1" Or Spisan = "True" Or Spisan = "-1" Then
'                                    TEHNode.ForeColor = Color.Red

'                                End If

'                                If KCKey <> 0 Then
'                                    If KCKey = rs3.Item("id") Then
'                                        lstgroups.SelectedNode = TEHNode
'                                        lstgroups.SelectedNode.Expand()
'                                    End If
'                                End If

'                            Case "MONITOR"

'                                Dim TEHNode As New TreeNode(L_NAME, 17, 17)
'                                TEHNode.Tag = "C|" & rs3.Item("id")
'                                TEHNodePS.Nodes.Add(TEHNode)

'                                If Spisan = "1" Or Spisan = "True" Or Spisan = "-1" Then
'                                    TEHNode.ForeColor = Color.Red

'                                End If

'                                If KCKey <> 0 Then
'                                    If KCKey = rs3.Item("id") Then
'                                        lstgroups.SelectedNode = TEHNode
'                                        lstgroups.SelectedNode.Expand()
'                                    End If
'                                End If


'                                '--------------VIP_Graff Добавление новой перефирии Начало-----------------
'                            Case "USB"
'                                Dim TEHNode As New TreeNode(L_NAME, 64, 64)
'                                TEHNode.Tag = "C|" & rs3.Item("id")
'                                TEHNodePS.Nodes.Add(TEHNode)
'                                If Spisan = "1" Or Spisan = "True" Or Spisan = "-1" Then
'                                    TEHNode.ForeColor = Color.Red
'                                End If
'                                If KCKey <> 0 Then
'                                    If KCKey = rs3.Item("id") Then
'                                        lstgroups.SelectedNode = TEHNode
'                                        lstgroups.SelectedNode.Expand()
'                                    End If
'                                End If

'                            Case "SOUND"
'                                Dim TEHNode As New TreeNode(L_NAME, 44, 44)
'                                TEHNode.Tag = "C|" & rs3.Item("id")
'                                TEHNodePS.Nodes.Add(TEHNode)
'                                If Spisan = "1" Or Spisan = "True" Or Spisan = "-1" Then
'                                    TEHNode.ForeColor = Color.Red
'                                End If
'                                If KCKey <> 0 Then
'                                    If KCKey = rs3.Item("id") Then
'                                        lstgroups.SelectedNode = TEHNode
'                                        lstgroups.SelectedNode.Expand()
'                                    End If
'                                End If

'                            Case "IBP"
'                                Dim TEHNode As New TreeNode(L_NAME, 41, 41)
'                                TEHNode.Tag = "C|" & rs3.Item("id")
'                                TEHNodePS.Nodes.Add(TEHNode)
'                                If Spisan = "1" Or Spisan = "True" Or Spisan = "-1" Then
'                                    TEHNode.ForeColor = Color.Red
'                                End If
'                                If KCKey <> 0 Then
'                                    If KCKey = rs3.Item("id") Then
'                                        lstgroups.SelectedNode = TEHNode
'                                        lstgroups.SelectedNode.Expand()
'                                    End If
'                                End If

'                            Case "FS"
'                                Dim TEHNode As New TreeNode(L_NAME, 65, 65)
'                                TEHNode.Tag = "C|" & rs3.Item("id")
'                                TEHNodePS.Nodes.Add(TEHNode)
'                                If Spisan = "1" Or Spisan = "True" Or Spisan = "-1" Then
'                                    TEHNode.ForeColor = Color.Red
'                                End If
'                                If KCKey <> 0 Then
'                                    If KCKey = rs3.Item("id") Then
'                                        lstgroups.SelectedNode = TEHNode
'                                        lstgroups.SelectedNode.Expand()
'                                    End If
'                                End If

'                            Case "KEYB"
'                                Dim TEHNode As New TreeNode(L_NAME, 46, 46)
'                                TEHNode.Tag = "C|" & rs3.Item("id")
'                                TEHNodePS.Nodes.Add(TEHNode)
'                                If Spisan = "1" Or Spisan = "True" Or Spisan = "-1" Then
'                                    TEHNode.ForeColor = Color.Red
'                                End If
'                                If KCKey <> 0 Then
'                                    If KCKey = rs3.Item("id") Then
'                                        lstgroups.SelectedNode = TEHNode
'                                        lstgroups.SelectedNode.Expand()
'                                    End If
'                                End If

'                            Case "MOUSE"
'                                Dim TEHNode As New TreeNode(L_NAME, 47, 47)
'                                TEHNode.Tag = "C|" & rs3.Item("id")
'                                TEHNodePS.Nodes.Add(TEHNode)
'                                If Spisan = "1" Or Spisan = "True" Or Spisan = "-1" Then
'                                    TEHNode.ForeColor = Color.Red
'                                End If
'                                If KCKey <> 0 Then
'                                    If KCKey = rs3.Item("id") Then
'                                        lstgroups.SelectedNode = TEHNode
'                                        lstgroups.SelectedNode.Expand()
'                                    End If
'                                End If
'                                '--------------VIP_Graff Добавление новой перефирии Конец------------------

'                            Case Else


'                        End Select



'                    End While
'                    rs3.Close()
'                    rs3 = Nothing

'                End If


'                '#####################################################################
'                '#####################################################################
'                '#####################################################################











'            Case "PC"

'                Dim TEHNodePS As New TreeNode(L_NAME, iA, iB)

'                TEHNodePS.Tag = "C|" & iD
'                iPSid = iD

'                DepNode.Nodes.Add(TEHNodePS)

'                'TEHNode.ForeColor = Color.Blue

'                If Spisan = "1" Or Spisan = "True" Or Spisan = "-1" Then
'                    TEHNodePS.ForeColor = Color.Red
'                End If

'                If KCKey <> 0 Then
'                    If KCKey = iD Then
'                        lstgroups.SelectedNode = TEHNodePS
'                        lstgroups.SelectedNode.Expand()
'                    End If
'                End If

'                Dim sText As String = objIniFile.GetString("general", "Tree_S", 0)
'                Dim sSQL4 As String


'                sSQL4 = "SELECT count(*) as t_n FROM kompy WHERE PCL =" & iD

'                Dim sCount As String

'                Dim cmd As OleDbCommand
'                Dim dr As OleDbDataReader


'                cmd = New OleDbCommand(sSQL4, DB8)
'                dr = cmd.ExecuteReader

'                While dr.Read()
'                    sCount = dr.Item("t_n")
'                End While
'                dr.Close()
'                dr = Nothing


'                If sCount > 0 Then



'                    Select Case sText

'                        Case 0

'                            sSQL4 = "SELECT id, mesto, filial, tip_compa, tiptehn, PSEVDONIM, NET_NAME, kabn, Spisan, OS FROM kompy WHERE PCL =" & iD & " ORDER BY PSEVDONIM, tiptehn"

'                        Case 1

'                            sSQL4 = "SELECT id, mesto, filial, tip_compa, tiptehn, PSEVDONIM, NET_NAME, kabn, Spisan, OS FROM kompy WHERE PCL =" & iD & " ORDER BY tiptehn, PSEVDONIM"

'                    End Select


'                    cmd = New OleDbCommand(sSQL4, DB8)
'                    Dim rs3 As OleDbDataReader

'                    rs3 = cmd.ExecuteReader()

'                    While rs3.Read()


'                        Select Case sTREENAME

'                            Case 0
'                                N_NAME = rs3.Item("NET_NAME")
'                                P_NAME = rs3.Item("PSEVDONIM")

'                                If Len(N_NAME) = 0 Then
'                                    N_NAME = "NoName"
'                                End If

'                                If Len(P_NAME) = 0 Then
'                                    P_NAME = "NoName"
'                                End If
'                                L_NAME = N_NAME & " (" & P_NAME & ")"

'                            Case 2
'                                P_NAME = rs3.Item("PSEVDONIM")

'                                If Len(P_NAME) = 0 Then
'                                    P_NAME = "NoName"
'                                End If
'                                L_NAME = P_NAME

'                            Case 1

'                                N_NAME = rs3.Item("NET_NAME")
'                                If Len(N_NAME) = 0 Then
'                                    N_NAME = "NoName"
'                                End If

'                                L_NAME = N_NAME

'                        End Select


'                        Select Case rs3.Item("tiptehn")


'                            Case "Printer"
'                                Dim TEHNode As New TreeNode(L_NAME, 7, 7)
'                                TEHNode.Tag = "C|" & rs3.Item("id")
'                                TEHNodePS.Nodes.Add(TEHNode)

'                                If Spisan = "1" Or Spisan = "True" Or Spisan = "-1" Then
'                                    TEHNode.ForeColor = Color.Red

'                                End If

'                                If KCKey <> 0 Then
'                                    If KCKey = rs3.Item("id") Then
'                                        lstgroups.SelectedNode = TEHNode
'                                        lstgroups.SelectedNode.Expand()
'                                    End If
'                                End If

'                            Case "MFU"

'                                Dim TEHNode As New TreeNode(L_NAME, 8, 8)
'                                TEHNode.Tag = "C|" & rs3.Item("id")
'                                TEHNodePS.Nodes.Add(TEHNode)

'                                If Spisan = "1" Or Spisan = "True" Or Spisan = "-1" Then
'                                    TEHNode.ForeColor = Color.Red

'                                End If

'                                If KCKey <> 0 Then
'                                    If KCKey = rs3.Item("id") Then
'                                        lstgroups.SelectedNode = TEHNode
'                                        lstgroups.SelectedNode.Expand()
'                                    End If
'                                End If


'                            Case "SCANER"

'                                Dim TEHNode As New TreeNode(L_NAME, 14, 14)
'                                TEHNode.Tag = "C|" & rs3.Item("id")
'                                TEHNodePS.Nodes.Add(TEHNode)

'                                If Spisan = "1" Or Spisan = "True" Or Spisan = "-1" Then
'                                    TEHNode.ForeColor = Color.Red

'                                End If

'                                If KCKey <> 0 Then
'                                    If KCKey = rs3.Item("id") Then
'                                        lstgroups.SelectedNode = TEHNode
'                                        lstgroups.SelectedNode.Expand()
'                                    End If
'                                End If

'                            Case "ZIP"
'                                Dim TEHNode As New TreeNode(L_NAME, 15, 15)
'                                TEHNode.Tag = "C|" & rs3.Item("id")
'                                TEHNodePS.Nodes.Add(TEHNode)

'                                If Spisan = "1" Or Spisan = "True" Or Spisan = "-1" Then
'                                    TEHNode.ForeColor = Color.Red

'                                End If

'                                If KCKey <> 0 Then
'                                    If KCKey = rs3.Item("id") Then
'                                        lstgroups.SelectedNode = TEHNode
'                                        lstgroups.SelectedNode.Expand()

'                                    End If
'                                End If

'                            Case "OT"

'                                Dim uname As String

'                                On Error Resume Next


'                                If Len(rs3.Item("tip_compa")) = 0 Then

'                                    uname = ""
'                                Else


'                                    uname = rs3.Item("tip_compa")

'                                    If uname = Nothing Or Len(uname) = 0 Or uname = 0 Then

'                                        uname = ""

'                                    Else




'                                        cmd = New OleDbCommand("SELECT * FROM spr_other where Name ='" & uname & "'", DB8)
'                                        Dim dr1 As OleDbDataReader

'                                        dr1 = cmd.ExecuteReader()
'                                        While dr1.Read()
'                                            If Not IsDBNull(dr1.Item("A")) Then uname = dr1.Item("A")
'                                        End While
'                                        dr1.Close()
'                                        dr1 = Nothing

'                                    End If



'                                End If


'                                If Len(uname) = 0 Or uname = " " Or uname = " 0" Or uname = "" Then
'                                    iA = 16
'                                Else
'                                    iA = uname
'                                End If


'                                Dim TEHNode As New TreeNode(L_NAME, iA, iA)
'                                TEHNode.Tag = "C|" & rs3.Item("id")
'                                TEHNodePS.Nodes.Add(TEHNode)

'                                If Spisan = "1" Or Spisan = "True" Or Spisan = "-1" Then
'                                    TEHNode.ForeColor = Color.Red

'                                End If

'                                If KCKey <> 0 Then
'                                    If KCKey = rs3.Item("id") Then
'                                        lstgroups.SelectedNode = TEHNode
'                                        lstgroups.SelectedNode.Expand()
'                                    End If
'                                End If

'                            Case "MONITOR"

'                                Dim TEHNode As New TreeNode(L_NAME, 17, 17)
'                                TEHNode.Tag = "C|" & rs3.Item("id")
'                                TEHNodePS.Nodes.Add(TEHNode)

'                                If Spisan = "1" Or Spisan = "True" Or Spisan = "-1" Then
'                                    TEHNode.ForeColor = Color.Red

'                                End If

'                                If KCKey <> 0 Then
'                                    If KCKey = rs3.Item("id") Then
'                                        lstgroups.SelectedNode = TEHNode
'                                        lstgroups.SelectedNode.Expand()
'                                    End If
'                                End If


'                            Case Else


'                        End Select
'                    End While

'                    rs3.Close()
'                    rs3 = Nothing

'                End If


'            Case "Printer"
'                Dim TEHNode As New TreeNode(L_NAME, 7, 7)
'                TEHNode.Tag = "C|" & iD
'                DepNode.Nodes.Add(TEHNode)

'                If Spisan = "1" Or Spisan = "True" Or Spisan = "-1" Then
'                    TEHNode.ForeColor = Color.Red

'                End If

'                If KCKey <> 0 Then
'                    If KCKey = iD Then
'                        lstgroups.SelectedNode = TEHNode
'                        lstgroups.SelectedNode.Expand()
'                    End If
'                End If

'            Case "MFU"

'                Dim TEHNode As New TreeNode(L_NAME, 8, 8)
'                TEHNode.Tag = "C|" & iD
'                DepNode.Nodes.Add(TEHNode)

'                If Spisan = "1" Or Spisan = "True" Or Spisan = "-1" Then
'                    TEHNode.ForeColor = Color.Red

'                End If

'                If KCKey <> 0 Then
'                    If KCKey = iD Then
'                        lstgroups.SelectedNode = TEHNode
'                        lstgroups.SelectedNode.Expand()
'                    End If
'                End If

'            Case "KOpir"
'                Dim TEHNode As New TreeNode(L_NAME, 9, 9)
'                TEHNode.Tag = "C|" & iD
'                DepNode.Nodes.Add(TEHNode)

'                If Spisan = "1" Or Spisan = "True" Or Spisan = "-1" Then
'                    TEHNode.ForeColor = Color.Red

'                End If

'                If KCKey <> 0 Then
'                    If KCKey = iD Then
'                        lstgroups.SelectedNode = TEHNode
'                        lstgroups.SelectedNode.Expand()
'                    End If
'                End If

'            Case "NET"
'                Dim TEHNode As New TreeNode(L_NAME, 10, 10)
'                TEHNode.Tag = "C|" & iD
'                DepNode.Nodes.Add(TEHNode)

'                If Spisan = "1" Or Spisan = "True" Or Spisan = "-1" Then
'                    TEHNode.ForeColor = Color.Red

'                End If

'                If KCKey <> 0 Then
'                    If KCKey = iD Then
'                        lstgroups.SelectedNode = TEHNode
'                        lstgroups.SelectedNode.Expand()
'                    End If
'                End If

'            Case "PHOTO"
'                Dim TEHNode As New TreeNode(L_NAME, 11, 11)
'                TEHNode.Tag = "C|" & iD
'                DepNode.Nodes.Add(TEHNode)

'                If Spisan = "1" Or Spisan = "True" Or Spisan = "-1" Then
'                    TEHNode.ForeColor = Color.Red

'                End If

'                If KCKey <> 0 Then
'                    If KCKey = iD Then
'                        lstgroups.SelectedNode = TEHNode
'                        lstgroups.SelectedNode.Expand()
'                    End If
'                End If

'            Case "PHONE"
'                Dim TEHNode As New TreeNode(L_NAME, 12, 12)
'                TEHNode.Tag = "C|" & iD
'                DepNode.Nodes.Add(TEHNode)

'                If Spisan = "1" Or Spisan = "True" Or Spisan = "-1" Then
'                    TEHNode.ForeColor = Color.Red

'                End If

'                If KCKey <> 0 Then
'                    If KCKey = iD Then
'                        lstgroups.SelectedNode = TEHNode
'                        lstgroups.SelectedNode.Expand()
'                    End If
'                End If

'            Case "FAX"
'                Dim TEHNode As New TreeNode(L_NAME, 13, 13)
'                TEHNode.Tag = "C|" & iD
'                DepNode.Nodes.Add(TEHNode)

'                If Spisan = "1" Or Spisan = "True" Or Spisan = "-1" Then
'                    TEHNode.ForeColor = Color.Red

'                End If

'                If KCKey <> 0 Then
'                    If KCKey = iD Then
'                        lstgroups.SelectedNode = TEHNode
'                        lstgroups.SelectedNode.Expand()
'                    End If
'                End If

'            Case "SCANER"

'                Dim TEHNode As New TreeNode(L_NAME, 14, 14)
'                TEHNode.Tag = "C|" & iD
'                DepNode.Nodes.Add(TEHNode)

'                If Spisan = "1" Or Spisan = "True" Or Spisan = "-1" Then
'                    TEHNode.ForeColor = Color.Red

'                End If

'                If KCKey <> 0 Then
'                    If KCKey = iD Then
'                        lstgroups.SelectedNode = TEHNode
'                        lstgroups.SelectedNode.Expand()
'                    End If
'                End If

'            Case "ZIP"
'                Dim TEHNode As New TreeNode(L_NAME, 15, 15)
'                TEHNode.Tag = "C|" & iD
'                DepNode.Nodes.Add(TEHNode)

'                If Spisan = "1" Or Spisan = "True" Or Spisan = "-1" Then
'                    TEHNode.ForeColor = Color.Red

'                End If

'                If KCKey <> 0 Then
'                    If KCKey = iD Then
'                        lstgroups.SelectedNode = TEHNode
'                        lstgroups.SelectedNode.Expand()

'                    End If
'                End If

'            Case "OT"


'                Dim uname As String

'                On Error Resume Next


'                If Len(TipPC) = 0 Then

'                    uname = ""
'                Else

'                    Dim cmd As OleDbCommand
'                    Dim dr As OleDbDataReader


'                    cmd = New OleDbCommand("SELECT * FROM spr_other where Name ='" & TipPC & "'", DB8)
'                    Dim dr12 As OleDbDataReader

'                    dr12 = cmd.ExecuteReader()



'                    While dr12.Read()
'                        If Not IsDBNull(dr12.Item("A")) Then uname = dr12.Item("A")
'                    End While
'                    dr12.Close()
'                    dr12 = Nothing

'                End If


'                If Len(uname) = 0 Or uname = " " Or uname = " 0" Or uname = "" Then
'                    iA = 16
'                Else
'                    iA = uname
'                End If


'                Dim TEHNode As New TreeNode(L_NAME, iA, iA)
'                TEHNode.Tag = "C|" & iD
'                DepNode.Nodes.Add(TEHNode)

'                If Spisan = "1" Or Spisan = "True" Or Spisan = "-1" Then
'                    TEHNode.ForeColor = Color.Red

'                End If

'                If KCKey <> 0 Then
'                    If KCKey = iD Then
'                        lstgroups.SelectedNode = TEHNode
'                        lstgroups.SelectedNode.Expand()
'                    End If
'                End If

'            Case "MONITOR"


'                Dim TEHNode As New TreeNode(L_NAME, 17, 17)
'                TEHNode.Tag = "C|" & iD
'                DepNode.Nodes.Add(TEHNode)

'                If Spisan = "1" Or Spisan = "True" Or Spisan = "-1" Then
'                    TEHNode.ForeColor = Color.Red

'                End If

'                If KCKey <> 0 Then
'                    If KCKey = iD Then
'                        lstgroups.SelectedNode = TEHNode
'                        lstgroups.SelectedNode.Expand()
'                    End If
'                End If




'            Case Else

'        End Select



'    End Sub



'End Module
