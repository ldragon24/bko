Module MOD_SEARCHE
    Public mde As Decimal
    Public FINDTXT As String
    Public FINDTXT_ As String

    Public Sub Search(ByVal sFindText As String, ByVal lstGroups As TreeView, ByVal gbTree As GroupBox,
                      ByVal sMOD As String, Optional ByVal MtchWord As Byte = 0, Optional ByVal MtchCase As Byte = 0)

        FINDTXT = sFindText


        gbTree.ForeColor = Color.Red
        Dim FirstColumn As Boolean

        Dim sSQL3, sSQL3_1 As String 'Переменная, где будет размещён SQL запрос
        Dim rs As Recordset 'Объявляем рекордсет
        Dim sSQL As String 'Переменная, где будет размещён SQL запрос

        Dim rs4 As Recordset 'Объявляем рекордсет
        Dim sSQL4 As String 'Переменная, где будет размещён SQL запрос


        On Error GoTo err_

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

        Dim langfile As New IniFile(sLANGPATH)

        lstGroups.Nodes.Clear()


        Select Case sMOD

            Case "COMP"
                sSQL3_1 = "SELECT count(*) as t_n FROM kompy where " &
  "CPU1 like '%" & sFindText &
  "%'  or CPU2 like '%" & sFindText &
  "%'  or CPU3 like '%" & sFindText &
  "%'  or CPU4 like '%" & sFindText &
  "%'  or Mb_Name like '%" & sFindText &
  "%'  or Mb_Chip like '%" & sFindText &
  "%'  or RAM_1 like '%" & sFindText &
  "%'  or RAM_SN_1 like '%" & sFindText &
  "%'  or RAM_2 like '%" & sFindText &
  "%'  or RAM_SN_2 like '%" & sFindText &
  "%'  or RAM_3 like '%" & sFindText &
  "%'  or RAM_SN_3 like '%" & sFindText &
  "%'  or RAM_4 like '%" & sFindText &
  "%'  or RAM_SN_4 like '%" & sFindText &
  "%'  or RAM_5 like '%" & sFindText &
  "%'  or RAM_SN_5 like '%" & sFindText &
  "%'  or RAM_6 like '%" & sFindText &
  "%'  or RAM_SN_6 like '%" & sFindText &
  "%'  or RAM_7 like '%" & sFindText &
  "%'  or RAM_SN_7 like '%" & sFindText &
  "%'  or RAM_8 like '%" & sFindText &
  "%'  or RAM_SN_8 like '%" & sFindText &
  "%'  or HDD_Name_1 like '%" & sFindText &
  "%'  or HDD_SN_1 like '%" & sFindText &
  "%'  or HDD_Name_2 like '%" & sFindText &
  "%'  or HDD_SN_2 like '%" & sFindText &
  "%'  or HDD_Name_3 like '%" & sFindText &
  "%'  or HDD_SN_3 like '%" & sFindText &
  "%'  or HDD_Name_4 like '%" & sFindText &
  "%'  or HDD_SN_4 like '%" & sFindText &
  "%'  or HDD_Name_5 like '%" & sFindText &
  "%'  or HDD_SN_5 like '%" & sFindText &
  "%'  or HDD_Name_6 like '%" & sFindText &
  "%'  or HDD_SN_6 like '%" & sFindText &
  "%'  or HDD_Name_7 like '%" & sFindText &
  "%'  or HDD_SN_7 like '%" & sFindText &
  "%'  or HDD_Name_8 like '%" & sFindText &
  "%'  or HDD_SN_8 like '%" & sFindText &
  "%'  or SVGA_NAME like '%" & sFindText &
  "%'  or SVGA_SN like '%" & sFindText &
  "%'  or SOUND_NAME like '%" & sFindText &
  "%'  or CD_NAME like '%" & sFindText &
  "%'  or CD_SPEED like '%" & sFindText &
  "%'  or CD_SN like '%" & sFindText &
  "%'  or CDRW_NAME like '%" & sFindText &
  "%'  or CDRW_SPEED like '%" & sFindText &
  "%'  or CDRW_SN like '%" & sFindText &
  "%'  or DVD_NAME like '%" & sFindText &
  "%'  or DVD_SPEED like '%" & sFindText &
  "%'  or DVD_SN like '%" & sFindText &
  "%'  or NET_NAME_1 like '%" & sFindText &
  "%'  or NET_IP_1 like '%" & sFindText &
  "%'  or NET_MAC_1 like '%" & sFindText &
  "%'  or NET_NAME_2 like '%" & sFindText &
  "%'  or NET_IP_2 like '%" & sFindText &
  "%'  or NET_MAC_2 like '%" & sFindText &
  "%'  or MODEM_NAME like '%" & sFindText &
  "%'  or MODEM_SN like '%" & sFindText &
  "%'  or MONITOR_NAME like '%" & sFindText &
  "%'  or MONITOR_NAME2 like '%" & sFindText &
  "%'  or MONITOR_SN like '%" & sFindText &
  "%'  or MONITOR_SN2 like '%" & sFindText &
  "%'  or AS_NAME like '%" & sFindText &
  "%'  or KEYBOARD_NAME like '%" & sFindText &
  "%'  or MOUSE_NAME like '%" & sFindText &
  "%'  or AS_PROIZV like '%" & sFindText &
  "%'  or IBP_NAME like '%" & sFindText &
  "%'  or FILTR_NAME like '%" & sFindText &
  "%'  or PRINTER_NAME_1 like '%" & sFindText &
  "%'  or PRINTER_SN_1 like '%" & sFindText &
  "%'  or PRINTER_NAME_2 like '%" & sFindText &
  "%'  or PRINTER_SN_2 like '%" & sFindText &
  "%'  or PRINTER_NAME_3 like '%" & sFindText &
  "%'  or PRINTER_SN_3 like '%" & sFindText &
  "%'  or PRINTER_NAME_4 like '%" & sFindText &
  "%'  or PRINTER_SN_4 like '%" & sFindText &
  "%'  or SCANER_NAME like '%" & sFindText &
  "%'  or NET_NAME like '%" & sFindText &
  "%'  or PSEVDONIM like '%" & sFindText &
  "%'  or MESTO like '%" & sFindText &
  "%'  or kabn like '%" & sFindText &
  "%'  or FILIAL like '%" & sFindText &
  "%'  or TELEPHONE like '%" & sFindText &
  "%'  or INV_NO_SYSTEM like '%" & sFindText &
  "%'  or INV_NO_PRINTER like '%" & sFindText &
  "%'  or INV_NO_MODEM like '%" & sFindText &
  "%'  or INV_NO_SCANER like '%" & sFindText &
  "%'  or INV_NO_MONITOR like '%" & sFindText &
  "%'  or INV_NO_IBP like '%" & sFindText &
  "%'  or OTvetstvennyj like '%" & sFindText &
  "%'  or Ser_N_SIS like '%" & sFindText &
  "%'  or BLOCK like '%" & sFindText &
  "%'  or SN_BLOCK like '%" & sFindText &
  "%'  or CREADER_NAME like '%" & sFindText &
  "%'  or CASE_NAME like '%" & sFindText &
  "%'  or CASE_SN like '%" & sFindText &
  "%'  or SYS_PR like '%" & sFindText & "%'"


                sSQL3 = "SELECT * FROM kompy where " &
  "CPU1 like '%" & sFindText &
  "%'  or CPU2 like '%" & sFindText &
  "%'  or CPU3 like '%" & sFindText &
  "%'  or CPU4 like '%" & sFindText &
  "%'  or Mb_Name like '%" & sFindText &
  "%'  or Mb_Chip like '%" & sFindText &
  "%'  or RAM_1 like '%" & sFindText &
  "%'  or RAM_SN_1 like '%" & sFindText &
  "%'  or RAM_2 like '%" & sFindText &
  "%'  or RAM_SN_2 like '%" & sFindText &
  "%'  or RAM_3 like '%" & sFindText &
  "%'  or RAM_SN_3 like '%" & sFindText &
  "%'  or RAM_4 like '%" & sFindText &
  "%'  or RAM_SN_4 like '%" & sFindText &
  "%'  or RAM_5 like '%" & sFindText &
  "%'  or RAM_SN_5 like '%" & sFindText &
  "%'  or RAM_6 like '%" & sFindText &
  "%'  or RAM_SN_6 like '%" & sFindText &
  "%'  or RAM_7 like '%" & sFindText &
  "%'  or RAM_SN_7 like '%" & sFindText &
  "%'  or RAM_8 like '%" & sFindText &
  "%'  or RAM_SN_8 like '%" & sFindText &
  "%'  or HDD_Name_1 like '%" & sFindText &
  "%'  or HDD_SN_1 like '%" & sFindText &
  "%'  or HDD_Name_2 like '%" & sFindText &
  "%'  or HDD_SN_2 like '%" & sFindText &
  "%'  or HDD_Name_3 like '%" & sFindText &
  "%'  or HDD_SN_3 like '%" & sFindText &
  "%'  or HDD_Name_4 like '%" & sFindText &
  "%'  or HDD_SN_4 like '%" & sFindText &
  "%'  or HDD_Name_5 like '%" & sFindText &
  "%'  or HDD_SN_5 like '%" & sFindText &
  "%'  or HDD_Name_6 like '%" & sFindText &
  "%'  or HDD_SN_6 like '%" & sFindText &
  "%'  or HDD_Name_7 like '%" & sFindText &
  "%'  or HDD_SN_7 like '%" & sFindText &
  "%'  or HDD_Name_8 like '%" & sFindText &
  "%'  or HDD_SN_8 like '%" & sFindText &
  "%'  or SVGA_NAME like '%" & sFindText &
  "%'  or SVGA_SN like '%" & sFindText &
  "%'  or SOUND_NAME like '%" & sFindText &
  "%'  or CD_NAME like '%" & sFindText &
  "%'  or CD_SPEED like '%" & sFindText &
  "%'  or CD_SN like '%" & sFindText &
  "%'  or CDRW_NAME like '%" & sFindText &
  "%'  or CDRW_SPEED like '%" & sFindText &
  "%'  or CDRW_SN like '%" & sFindText &
  "%'  or DVD_NAME like '%" & sFindText &
  "%'  or DVD_SPEED like '%" & sFindText &
  "%'  or DVD_SN like '%" & sFindText &
  "%'  or NET_NAME_1 like '%" & sFindText &
  "%'  or NET_IP_1 like '%" & sFindText &
  "%'  or NET_MAC_1 like '%" & sFindText &
  "%'  or NET_NAME_2 like '%" & sFindText &
  "%'  or NET_IP_2 like '%" & sFindText &
  "%'  or NET_MAC_2 like '%" & sFindText &
  "%'  or MODEM_NAME like '%" & sFindText &
  "%'  or MODEM_SN like '%" & sFindText &
  "%'  or MONITOR_NAME like '%" & sFindText &
  "%'  or MONITOR_NAME2 like '%" & sFindText &
  "%'  or MONITOR_SN like '%" & sFindText &
  "%'  or MONITOR_SN2 like '%" & sFindText &
  "%'  or AS_NAME like '%" & sFindText &
  "%'  or KEYBOARD_NAME like '%" & sFindText &
  "%'  or MOUSE_NAME like '%" & sFindText &
  "%'  or AS_PROIZV like '%" & sFindText &
  "%'  or IBP_NAME like '%" & sFindText &
  "%'  or FILTR_NAME like '%" & sFindText &
  "%'  or PRINTER_NAME_1 like '%" & sFindText &
  "%'  or PRINTER_SN_1 like '%" & sFindText &
  "%'  or PRINTER_NAME_2 like '%" & sFindText &
  "%'  or PRINTER_SN_2 like '%" & sFindText &
  "%'  or PRINTER_NAME_3 like '%" & sFindText &
  "%'  or PRINTER_SN_3 like '%" & sFindText &
  "%'  or PRINTER_NAME_4 like '%" & sFindText &
  "%'  or PRINTER_SN_4 like '%" & sFindText &
  "%'  or SCANER_NAME like '%" & sFindText &
  "%'  or NET_NAME like '%" & sFindText &
  "%'  or PSEVDONIM like '%" & sFindText &
  "%'  or MESTO like '%" & sFindText &
  "%'  or kabn like '%" & sFindText &
  "%'  or FILIAL like '%" & sFindText &
  "%'  or TELEPHONE like '%" & sFindText &
  "%'  or INV_NO_SYSTEM like '%" & sFindText &
  "%'  or INV_NO_PRINTER like '%" & sFindText &
  "%'  or INV_NO_MODEM like '%" & sFindText &
  "%'  or INV_NO_SCANER like '%" & sFindText &
  "%'  or INV_NO_MONITOR like '%" & sFindText &
  "%'  or INV_NO_IBP like '%" & sFindText &
  "%'  or OTvetstvennyj like '%" & sFindText &
  "%'  or Ser_N_SIS like '%" & sFindText &
  "%'  or BLOCK like '%" & sFindText &
  "%'  or SN_BLOCK like '%" & sFindText &
  "%'  or CREADER_NAME like '%" & sFindText &
  "%'  or CASE_NAME like '%" & sFindText &
  "%'  or CASE_SN like '%" & sFindText &
  "%'  or SYS_PR like '%" & sFindText &
  "%'order by PSEVDONIM, filial"

            Case "SERVICE"

            Case "SOFT"

            Case "CARTR"

        End Select

        Dim rs3 As Recordset 'Объявляем рекордсет
        rs3 = New Recordset

        rs3 = New Recordset
        rs3.Open(sSQL3_1, DB7, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic)

        Dim sct As Integer
        With rs3
            sct = .Fields("t_n").Value
        End With
        rs3.Close()
        rs3 = Nothing

        Select Case sct

            Case 0

                MsgBox("Поиск по заданным критериям не принес результата" & vbNewLine & "измените параметры поиска и повторите попытку", MsgBoxStyle.Information, ProGramName)

                Exit Sub

            Case Else

                Dim nodeRoot As New TreeNode(ProGramName, 69, 69)
                nodeRoot.Tag = "ROOT" & GENID()

                lstGroups.Nodes.Add(nodeRoot)

                Dim TempNode As New TreeNode(langfile.GetString("frmComputers", "MSG18", "Компьютеры"), 0, 0)
                TempNode.Tag = "G1|2"
                nodeRoot.Nodes.Add(TempNode)

                On Error GoTo err_


                rs3 = New Recordset
                rs3.Open(sSQL3, DB7, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic)

                With rs3
                    .MoveFirst()
                    Do While Not .EOF
                        FINDTXT = ""
                        FirstColumn = True
                        'Ищем то что нам нужно

                        For lngCounter = 0 To rs3.Fields.Count - 2

                            If FirstColumn Then

                                If Not IsDBNull(.Fields(lngCounter).Value) Then _
                                    If isThere(.Fields(lngCounter).Value, sFindText, mde) = True Then GoTo Foundit

                            Else

                            End If                  'TO KEEP DATA FROM SHIFTING LEFT

                        Next

Foundit:

                        'My.Application.DoEvents()

                        If Len(FINDTXT) = 0 Then

                        Else


                            Select Case .Fields("tiptehn").Value

                                Case "PC"

                                    Dim iC, iA As String
                                    iC = .Fields("TIP_COMPA").Value


                                    If iC = "Ноутбук" Or iC = "notebook" Or iC = "Notebook" Or iC = "NoteBook" Then
                                        iC = "Ноутбук"
                                    End If

                                    If iC = "КПК" Or iC = "Pocket PC" Or iC = "Pocket" Or iC = "Palm" Then
                                        iC = "КПК"
                                    End If

                                    If _
                                        iC = "Сервер" Or iC = "Server" Or iC = "Сервер для тонких клиентов" Or
                                        iC = "Сервер видео наблюдения" Then
                                        iC = "Сервер"
                                    End If

                                    'Pocket PC

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

                                    Filling_TREE_DATA(lstGroups, .Fields("id").Value, TempNode, .Fields("Spisan").Value,
                                                      .Fields("balans").Value, .Fields("NET_NAME").Value, iA)


                                Case "Printer"

                                    Filling_TREE_DATA(lstGroups, .Fields("id").Value, TempNode, .Fields("Spisan").Value,
                                                      .Fields("balans").Value, .Fields("NET_NAME").Value, 7)

                                Case "MFU"


                                    Filling_TREE_DATA(lstGroups, .Fields("id").Value, TempNode, .Fields("Spisan").Value,
                                                      .Fields("balans").Value, .Fields("NET_NAME").Value, 8)

                                Case "KOpir"
                                    'Dim TEHNode As New TreeNode(.Fields("NET_NAME").Value, 9, 9)
                                    'TEHNode.Tag = "C|" & .Fields(0).Value
                                    'TempNode.Nodes.Add(TEHNode)

                                    Filling_TREE_DATA(lstGroups, .Fields("id").Value, TempNode, .Fields("Spisan").Value,
                                                      .Fields("balans").Value, .Fields("NET_NAME").Value, 9)

                                Case "NET"
                                    Dim TEHNode As New TreeNode(.Fields("NET_NAME").Value, 10, 10)
                                    TEHNode.Tag = "C|" & .Fields(0).Value
                                    TempNode.Nodes.Add(TEHNode)

                                    Select Case .Fields("PRINTER_NAME_4").Value

                                        Case "Off"
                                            TEHNode.ForeColor = Color.Red

                                        Case "Defective"

                                            TEHNode.ForeColor = Color.Blue

                                        Case Else

                                            TEHNode.ForeColor = Color.Green

                                    End Select


                                    If _
                                        .Fields("balans").Value = "1" Or .Fields("balans").Value = "True" Or
                                        .Fields("balans").Value = "-1" Then

                                        If _
                                            .Fields("Spisan").Value = "1" Or .Fields("Spisan").Value = "True" Or
                                            .Fields("Spisan").Value = "-1" Then
                                            TEHNode.NodeFont = New Font(lstGroups.Font, 10)
                                        Else
                                            TEHNode.NodeFont = New Font(lstGroups.Font, 2)
                                        End If

                                    End If


                                Case "PHOTO"
                                    'Dim TEHNode As New TreeNode(.Fields("NET_NAME").Value, 11, 11)
                                    'TEHNode.Tag = "C|" & .Fields(0).Value
                                    'TempNode.Nodes.Add(TEHNode)

                                    Filling_TREE_DATA(lstGroups, .Fields("id").Value, TempNode, .Fields("Spisan").Value,
                                                      .Fields("balans").Value, .Fields("NET_NAME").Value, 11)

                                Case "PHONE"
                                    'Dim TEHNode As New TreeNode(.Fields("NET_NAME").Value, 12, 12)
                                    'TEHNode.Tag = "C|" & .Fields(0).Value
                                    'TempNode.Nodes.Add(TEHNode)

                                    Filling_TREE_DATA(lstGroups, .Fields("id").Value, TempNode, .Fields("Spisan").Value,
                                                      .Fields("balans").Value, .Fields("NET_NAME").Value, 12)

                                Case "FAX"
                                    'Dim TEHNode As New TreeNode(.Fields("NET_NAME").Value, 13, 13)
                                    'TEHNode.Tag = "C|" & .Fields(0).Value
                                    'TempNode.Nodes.Add(TEHNode)

                                    Filling_TREE_DATA(lstGroups, .Fields("id").Value, TempNode, .Fields("Spisan").Value,
                                                      .Fields("balans").Value, .Fields("NET_NAME").Value, 13)

                                Case "SCANER"

                                    'Dim TEHNode As New TreeNode(.Fields("NET_NAME").Value, 14, 14)
                                    'TEHNode.Tag = "C|" & .Fields(0).Value
                                    'TempNode.Nodes.Add(TEHNode)

                                    Filling_TREE_DATA(lstGroups, .Fields("id").Value, TempNode, .Fields("Spisan").Value,
                                                      .Fields("balans").Value, .Fields("NET_NAME").Value, 14)


                                Case "ZIP"
                                    'Dim TEHNode As New TreeNode(.Fields("NET_NAME").Value, 15, 15)
                                    'TEHNode.Tag = "C|" & .Fields(0).Value
                                    'TempNode.Nodes.Add(TEHNode)

                                    Filling_TREE_DATA(lstGroups, .Fields("id").Value, TempNode, .Fields("Spisan").Value,
                                                      .Fields("balans").Value, .Fields("NET_NAME").Value, 15)

                                Case "OT"

                                    Dim uname As String
                                    Dim rsOT As Recordset
                                    rsOT = New Recordset
                                    rsOT.Open("SELECT A FROM spr_other where Name ='" & .Fields("tip_compa").Value & "'", DB7,
                                              CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic)

                                    With rsOT
                                        If Not IsDBNull(.Fields("A").Value) Then uname = .Fields("A").Value
                                    End With

                                    rsOT.Close()
                                    rsOT = Nothing

                                    Dim TEHNode As New TreeNode(.Fields("NET_NAME").Value, uname, uname)
                                    TEHNode.Tag = "C|" & .Fields(0).Value
                                    TempNode.Nodes.Add(TEHNode)

                                Case "MONITOR"
                                    'Dim TEHNode As New TreeNode(.Fields("NET_NAME").Value, 17, 17)
                                    'TEHNode.Tag = "C|" & .Fields(0).Value
                                    'TempNode.Nodes.Add(TEHNode)

                                    Filling_TREE_DATA(lstGroups, .Fields("id").Value, TempNode, .Fields("Spisan").Value,
                                                      .Fields("balans").Value, .Fields("NET_NAME").Value, 17)

                                    '--------------VIP_Graff Добавление новой перефирии Начало-----------------
                                Case "USB"
                                    'Dim TEHNode As New TreeNode(.Fields("NET_NAME").Value, 18, 18)
                                    'TEHNode.Tag = "C|" & .Fields(0).Value
                                    'TempNode.Nodes.Add(TEHNode)

                                    Filling_TREE_DATA(lstGroups, .Fields("id").Value, TempNode, .Fields("Spisan").Value,
                                                      .Fields("balans").Value, .Fields("NET_NAME").Value, 18)

                                Case "SOUND"
                                    'Dim TEHNode As New TreeNode(.Fields("NET_NAME").Value, 44, 44)
                                    'TEHNode.Tag = "C|" & .Fields(0).Value
                                    'TempNode.Nodes.Add(TEHNode)

                                    Filling_TREE_DATA(lstGroups, .Fields("id").Value, TempNode, .Fields("Spisan").Value,
                                                      .Fields("balans").Value, .Fields("NET_NAME").Value, 44)

                                Case "IBP"
                                    'Dim TEHNode As New TreeNode(.Fields("NET_NAME").Value, 41, 41)
                                    'TEHNode.Tag = "C|" & .Fields(0).Value
                                    'TempNode.Nodes.Add(TEHNode)

                                    Filling_TREE_DATA(lstGroups, .Fields("id").Value, TempNode, .Fields("Spisan").Value,
                                                      .Fields("balans").Value, .Fields("NET_NAME").Value, 41)

                                Case "FS"
                                    'Dim TEHNode As New TreeNode(.Fields("NET_NAME").Value, 61, 61)
                                    'TEHNode.Tag = "C|" & .Fields(0).Value
                                    'TempNode.Nodes.Add(TEHNode)

                                    Filling_TREE_DATA(lstGroups, .Fields("id").Value, TempNode, .Fields("Spisan").Value,
                                                      .Fields("balans").Value, .Fields("NET_NAME").Value, 61)

                                Case "KEYB"
                                    'Dim TEHNode As New TreeNode(.Fields("NET_NAME").Value, 46, 46)
                                    'TEHNode.Tag = "C|" & .Fields(0).Value
                                    'TempNode.Nodes.Add(TEHNode)

                                    Filling_TREE_DATA(lstGroups, .Fields("id").Value, TempNode, .Fields("Spisan").Value,
                                                      .Fields("balans").Value, .Fields("NET_NAME").Value, 46)

                                Case "MOUSE"
                                    'Dim TEHNode As New TreeNode(.Fields("NET_NAME").Value, 47, 47)
                                    'TEHNode.Tag = "C|" & .Fields(0).Value
                                    'TempNode.Nodes.Add(TEHNode)

                                    Filling_TREE_DATA(lstGroups, .Fields("id").Value, TempNode, .Fields("Spisan").Value,
                                                      .Fields("balans").Value, .Fields("NET_NAME").Value, 47)

                                    '--------------VIP_Graff Добавление новой перефирии Конец------------------

                                Case "CNT"

                                    Dim uname As String
                                    Dim rsOT As Recordset
                                    rsOT = New Recordset
                                    rsOT.Open("SELECT A FROM spr_other where Name ='" & .Fields("NET_NAME").Value & "'", DB7,
                                              CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic)

                                    With rsOT
                                        If Not IsDBNull(.Fields("A").Value) Then uname = .Fields("A").Value
                                    End With

                                    rsOT.Close()
                                    rsOT = Nothing

                                    'Dim TEHNode As New TreeNode(.Fields("NET_NAME").Value, uname, uname)
                                    'TEHNode.Tag = "C|" & .Fields(0).Value
                                    'TempNode.Nodes.Add(TEHNode)

                                    Filling_TREE_DATA(lstGroups, .Fields("id").Value, TempNode, .Fields("Spisan").Value,
                                                      .Fields("balans").Value, .Fields("NET_NAME").Value, uname)

                                Case Else

                            End Select

                        End If

                        .MoveNext()
                    Loop
                End With


                'gbTree.ForeColor = frmComputers.gbStat.ForeColor
                lstGroups.SelectedNode = nodeRoot

                Dim tNode As New TreeNode
                tNode = lstGroups.Nodes(0)
                tNode.Expand()

                rs3.Close()
                rs3 = Nothing

        End Select


       


        Exit Sub
err_:
        MsgBox(Err.Description)

    End Sub

    Public Function isThere(ByVal sTxt As String, ByVal sComp As String, ByVal sMode As Long) As Boolean
        Dim TST() As String
        isThere = False

        Select Case sMode
            Case 1
                'match case
                TST = Split(sTxt, sComp)
                If UBound(TST) > 0 Then isThere = True : Exit Function
                Exit Function
            Case 2
                'match word
                TST = Split(LCase(sTxt), LCase(sComp))
                If UBound(TST) <= 0 Then isThere = False : Exit Function
                If Trim(Mid(TST(0), 1, 1)) = "" And Trim(Mid(TST(1), 1, 1)) = "" Then isThere = True : Exit Function

            Case 3
                'match word+case
                TST = Split(sTxt, sComp)
                If UBound(TST) <= 0 Then isThere = False : Exit Function
                If Trim(Mid(TST(0), 1, 1)) = "" And Trim(Mid(TST(1), 1, 1)) = "" Then isThere = True : Exit Function


            Case 0
                'match any
                TST = Split(LCase(sTxt), LCase(sComp))
                If UBound(TST) > 0 Then isThere = True : FINDTXT = LCase(sTxt) : Exit Function


                Exit Function
        End Select
    End Function
End Module
