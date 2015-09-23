Public Class frmNetMag_selectSVT
    Private m_SortingColumn As ColumnHeader

    Public Sub New()
        InitializeComponent()
    End Sub

    Private Sub frmNetMag_selectSVT_Activated(ByVal sender As Object, ByVal e As EventArgs) Handles Me.Activated
        lvNetMagazin.Sorting = False
        'lvNetMagazin.Items.Clear()
    End Sub 'New

    Private Sub frmNetMag_selectSVT_Load(ByVal sender As Object, ByVal e As EventArgs) Handles Me.Load
        SendFonts(Me)

        Call frmNetMag_selectSVT_LANG()

        lvNetMagazin.Sorting = False

        Call LOAD_SVT()
    End Sub

    Private Sub LOAD_SVT()

        On Error GoTo err_

        lvNetMagazin.Sorting = False
        lvNetMagazin.Items.Clear()

        'frmNetMagazin.sBDO_count
        Dim sSQL As String


        Select Case frmNetMagazin.sBDO_Pref

            Case "G"

                sSQL = "SELECT Filial as one_par FROM SPR_FILIAL where id=" & frmNetMagazin.sBDO_count

            Case "O"

                sSQL = "SELECT Filial as one_par, N_Otd as two_par FROM SPR_OTD_FILIAL WHERE id=" &
                       frmNetMagazin.sBDO_count

            Case "K"

                sSQL = "SELECT Name as tree_par, N_F as one_par, N_M as two_par FROM SPR_KAB where id=" &
                       frmNetMagazin.sBDO_count

            Case "ROOT"


        End Select

        Dim A1, A2, A3 As String
        Dim rs As Recordset

        If frmNetMagazin.sBDO_Pref = "ROOT" Then


        Else


            rs = New Recordset
            rs.Open(sSQL, DB7, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic)


            With rs

                Select Case frmNetMagazin.sBDO_Pref


                    Case "G"
                        A1 = .Fields("one_par").Value
                        A2 = "" '.Fields("two_par").Value
                        A3 = "" '.Fields("tree_par").Value

                    Case "O"

                        A1 = .Fields("one_par").Value
                        A2 = .Fields("two_par").Value
                        A3 = "" '.Fields("tree_par").Value


                    Case "K"

                        A1 = .Fields("one_par").Value
                        A2 = .Fields("two_par").Value
                        A3 = .Fields("tree_par").Value

                End Select


            End With

            rs.Close()
            rs = Nothing

        End If
        Dim scCount As Integer
        Select Case frmNetMagazin.sBDO_SVT_Pref

            Case "PC"

                Select Case frmNetMagazin.sBDO_Pref


                    Case "G"

                        sSQL = "SELECT count(*) as t_n FROM kompy where tiptehn <> 'PC' AND PCL=0 AND filial='" & A1 &
                               "'"
                        rs = New Recordset
                        rs.Open(sSQL, DB7, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic)

                        With rs
                            scCount = .Fields("t_n").Value
                        End With
                        rs.Close()
                        rs = Nothing


                        sSQL = "SELECT id,tiptehn,INV_NO_SYSTEM,INV_NO_PRINTER,INV_NO_MONITOR,INV_NO_SCANER,PRINTER_PROIZV_3,NET_NAME,TIP_COMPA,INV_NO_IBP,OTvetstvennyj,FILIAL,MESTO,kabn FROM kompy where tiptehn <> 'PC' AND filial='" & A1 &
                               "' ORDER BY filial, mesto, kabn, net_name"

                    Case "O"

                        sSQL = "SELECT count(*) as t_n FROM kompy where tiptehn <> 'PC' AND filial='" & A1 &
                               "' AND mesto='" & A2 & "'"
                        rs = New Recordset
                        rs.Open(sSQL, DB7, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic)

                        With rs
                            scCount = .Fields("t_n").Value
                        End With
                        rs.Close()
                        rs = Nothing

                        sSQL = "SELECT id,tiptehn,INV_NO_SYSTEM,INV_NO_PRINTER,INV_NO_MONITOR,INV_NO_SCANER,PRINTER_PROIZV_3,NET_NAME,TIP_COMPA,INV_NO_IBP,OTvetstvennyj,FILIAL,MESTO,kabn FROM kompy where tiptehn <> 'PC' AND filial='" & A1 & "' AND mesto='" & A2 &
                               "' ORDER BY filial, mesto, kabn, net_name"

                    Case "K"
                        sSQL = "SELECT count(*) as t_n FROM kompy where tiptehn <> 'PC' AND filial='" & A1 &
                               "' AND mesto='" & A2 & "' AND kabn='" & A3 & "'" 'AND PCL=0 
                        rs = New Recordset
                        rs.Open(sSQL, DB7, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic)

                        With rs
                            scCount = .Fields("t_n").Value
                        End With
                        rs.Close()
                        rs = Nothing

                        sSQL = "SELECT id,tiptehn,INV_NO_SYSTEM,INV_NO_PRINTER,INV_NO_MONITOR,INV_NO_SCANER,PRINTER_PROIZV_3,NET_NAME,TIP_COMPA,INV_NO_IBP,OTvetstvennyj,FILIAL,MESTO,kabn FROM kompy where tiptehn <> 'PC' AND filial='" & A1 & "' AND mesto='" & A2 &
                               "' AND kabn='" & A3 & "' ORDER BY filial, mesto, kabn, net_name"
                        ' and tiptehn='PC' or tiptehn='Printer' or tiptehn='MFU' or tiptehn='FAX' or tiptehn='PHONE' or tiptehn='NET' or tiptehn='IBP'

                    Case "ROOT"
                        sSQL = "SELECT count(*) as t_n FROM kompy where tiptehn <> 'PC' AND PCL=0"
                        rs = New Recordset
                        rs.Open(sSQL, DB7, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic)

                        With rs
                            scCount = .Fields("t_n").Value
                        End With
                        rs.Close()
                        rs = Nothing


                        sSQL = "SELECT id,tiptehn,INV_NO_SYSTEM,INV_NO_PRINTER,INV_NO_MONITOR,INV_NO_SCANER,PRINTER_PROIZV_3,NET_NAME,TIP_COMPA,INV_NO_IBP,OTvetstvennyj,FILIAL,MESTO,kabn FROM kompy where tiptehn <> 'PC' ORDER BY filial, mesto, kabn, net_name"

                End Select

            Case "NET"
                sSQL = "SELECT count(*) as t_n FROM kompy where tiptehn='NET'"
                rs = New Recordset
                rs.Open(sSQL, DB7, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic)

                With rs
                    scCount = .Fields("t_n").Value
                End With
                rs.Close()
                rs = Nothing
                sSQL = "SELECT id,tiptehn,INV_NO_SYSTEM,INV_NO_PRINTER,INV_NO_MONITOR,INV_NO_SCANER,PRINTER_PROIZV_3,NET_NAME,TIP_COMPA,INV_NO_IBP,OTvetstvennyj,FILIAL,MESTO,kabn FROM kompy where tiptehn='NET' ORDER BY filial, mesto, kabn, net_name"


        End Select


        Dim intCount As Decimal = 0
        Dim LNGIniFile As New IniFile(sLANGPATH)

        If scCount = 0 Then

        Else
            rs = New Recordset
            rs.Open(sSQL, DB7, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic)


            lvNetMagazin.Sorting = False

            With rs
                .MoveFirst()
                Do While Not .EOF

                    lvNetMagazin.Items.Add(.Fields("id").Value) 'col no. 1

                    'lvNetMagazin.Items(CInt(intCount)).SubItems.Add("Компьютер")

                    Select Case .Fields("tiptehn").Value

                        Case "PC"

                            lvNetMagazin.Items(CInt(intCount)).SubItems.Add(LNGIniFile.GetString("frmNetMagazin",
                                                                                                 "MSG11", "Компьютер"))

                            If Not IsDBNull(.Fields("INV_NO_SYSTEM").Value) Then
                                lvNetMagazin.Items(CInt(intCount)).SubItems.Add(.Fields("INV_NO_SYSTEM").Value)
                            Else
                                lvNetMagazin.Items(CInt(intCount)).SubItems.Add("")
                            End If


                        Case "Printer"

                            lvNetMagazin.Items(CInt(intCount)).SubItems.Add(LNGIniFile.GetString("frmNetMagazin", "MSG6",
                                                                                                 "Принтер"))

                            If Not IsDBNull(.Fields("INV_NO_PRINTER").Value) Then
                                lvNetMagazin.Items(CInt(intCount)).SubItems.Add(.Fields("INV_NO_PRINTER").Value)
                            Else
                                lvNetMagazin.Items(CInt(intCount)).SubItems.Add("")
                            End If

                        Case "KOpir"

                            lvNetMagazin.Items(CInt(intCount)).SubItems.Add(LNGIniFile.GetString("frmNetMagazin",
                                                                                                 "MSG13", "Копир"))

                            If Not IsDBNull(.Fields("INV_NO_PRINTER").Value) Then
                                lvNetMagazin.Items(CInt(intCount)).SubItems.Add(.Fields("INV_NO_PRINTER").Value)
                            Else
                                lvNetMagazin.Items(CInt(intCount)).SubItems.Add("")
                            End If

                        Case "MONITOR"
                            lvNetMagazin.Items(CInt(intCount)).SubItems.Add(LNGIniFile.GetString("frmNetMagazin", "MSG3",
                                                                                                 "Монитор"))

                            If Not IsDBNull(.Fields("INV_NO_MONITOR").Value) Then
                                lvNetMagazin.Items(CInt(intCount)).SubItems.Add(.Fields("INV_NO_MONITOR").Value)
                            Else
                                lvNetMagazin.Items(CInt(intCount)).SubItems.Add("")
                            End If


                        Case "SCANER"

                            lvNetMagazin.Items(CInt(intCount)).SubItems.Add(LNGIniFile.GetString("frmNetMagazin", "MSG8",
                                                                                                 "Сканер"))

                            If Not IsDBNull(.Fields("INV_NO_SCANER").Value) Then
                                lvNetMagazin.Items(CInt(intCount)).SubItems.Add(.Fields("INV_NO_SCANER").Value)
                            Else
                                lvNetMagazin.Items(CInt(intCount)).SubItems.Add("")
                            End If

                        Case "NET"

                            lvNetMagazin.Items(CInt(intCount)).SubItems.Add(LNGIniFile.GetString("frmNetMagazin",
                                                                                                 "MSG14",
                                                                                                 "Сетевое оборудование"))

                            If Not IsDBNull(.Fields("PRINTER_PROIZV_3").Value) Then
                                lvNetMagazin.Items(CInt(intCount)).SubItems.Add(.Fields("PRINTER_PROIZV_3").Value)
                            Else
                                lvNetMagazin.Items(CInt(intCount)).SubItems.Add("")
                            End If


                        Case "PHOTO"

                            lvNetMagazin.Items(CInt(intCount)).SubItems.Add(LNGIniFile.GetString("frmNetMagazin",
                                                                                                 "MSG15", "Фотоаппарат"))

                            If Not IsDBNull(.Fields("INV_NO_PRINTER").Value) Then
                                lvNetMagazin.Items(CInt(intCount)).SubItems.Add(.Fields("INV_NO_PRINTER").Value)
                            Else
                                lvNetMagazin.Items(CInt(intCount)).SubItems.Add("")
                            End If

                        Case "OT"

                            lvNetMagazin.Items(CInt(intCount)).SubItems.Add(
                                .Fields("NET_NAME").Value & " " & .Fields("TIP_COMPA").Value)

                            If Not IsDBNull(.Fields("INV_NO_PRINTER").Value) Then
                                lvNetMagazin.Items(CInt(intCount)).SubItems.Add(.Fields("INV_NO_PRINTER").Value)
                            Else
                                lvNetMagazin.Items(CInt(intCount)).SubItems.Add("")
                            End If

                        Case "CNT"

                            lvNetMagazin.Items(CInt(intCount)).SubItems.Add(
                                .Fields("NET_NAME").Value & " " & .Fields("TIP_COMPA").Value)

                            If Not IsDBNull(.Fields("INV_NO_PRINTER").Value) Then
                                lvNetMagazin.Items(CInt(intCount)).SubItems.Add(.Fields("INV_NO_PRINTER").Value)
                            Else
                                lvNetMagazin.Items(CInt(intCount)).SubItems.Add("")
                            End If

                        Case "ZIP"

                            lvNetMagazin.Items(CInt(intCount)).SubItems.Add(LNGIniFile.GetString("frmNetMagazin",
                                                                                                 "MSG18", "Дисковод ZIP"))

                            If Not IsDBNull(.Fields("INV_NO_PRINTER").Value) Then
                                lvNetMagazin.Items(CInt(intCount)).SubItems.Add(.Fields("INV_NO_PRINTER").Value)
                            Else
                                lvNetMagazin.Items(CInt(intCount)).SubItems.Add("")
                            End If

                        Case "PHONE"

                            lvNetMagazin.Items(CInt(intCount)).SubItems.Add(LNGIniFile.GetString("frmNetMagazin",
                                                                                                 "MSG16", "Телефон"))

                            If Not IsDBNull(.Fields("INV_NO_PRINTER").Value) Then
                                lvNetMagazin.Items(CInt(intCount)).SubItems.Add(.Fields("INV_NO_PRINTER").Value)
                            Else
                                lvNetMagazin.Items(CInt(intCount)).SubItems.Add("")
                            End If

                        Case "MFU"

                            lvNetMagazin.Items(CInt(intCount)).SubItems.Add(LNGIniFile.GetString("frmNetMagazin", "MSG7",
                                                                                                 "МФУ"))

                            If Not IsDBNull(.Fields("INV_NO_PRINTER").Value) Then
                                lvNetMagazin.Items(CInt(intCount)).SubItems.Add(.Fields("INV_NO_PRINTER").Value)
                            Else
                                lvNetMagazin.Items(CInt(intCount)).SubItems.Add("")
                            End If


                        Case "FAX"

                            lvNetMagazin.Items(CInt(intCount)).SubItems.Add(LNGIniFile.GetString("frmNetMagazin",
                                                                                                 "MSG17", "Факс"))

                            If Not IsDBNull(.Fields("INV_NO_PRINTER").Value) Then
                                lvNetMagazin.Items(CInt(intCount)).SubItems.Add(.Fields("INV_NO_PRINTER").Value)
                            Else
                                lvNetMagazin.Items(CInt(intCount)).SubItems.Add("")
                            End If

                        Case "USB"

                            lvNetMagazin.Items(CInt(intCount)).SubItems.Add(LNGIniFile.GetString("frmNetMagazin",
                                                                                                 "MSG10",
                                                                                                 "USB Устройство"))
                        Case "IBP"


                            lvNetMagazin.Items(CInt(intCount)).SubItems.Add(LNGIniFile.GetString("frmNetMagazin", "MSG9",
                                                                                                 "Источник бесперебойного питания"))

                            If Not IsDBNull(.Fields("INV_NO_IBP").Value) Then
                                lvNetMagazin.Items(CInt(intCount)).SubItems.Add(.Fields("INV_NO_IBP").Value)
                            Else
                                lvNetMagazin.Items(CInt(intCount)).SubItems.Add("")
                            End If

                        Case "FS"

                            lvNetMagazin.Items(CInt(intCount)).SubItems.Add(LNGIniFile.GetString("frmNetMagazin", "MSG5",
                                                                                                 "Сетевой фильтр"))

                            If Not IsDBNull(.Fields("INV_NO_PRINTER").Value) Then
                                lvNetMagazin.Items(CInt(intCount)).SubItems.Add(.Fields("INV_NO_PRINTER").Value)
                            Else
                                lvNetMagazin.Items(CInt(intCount)).SubItems.Add("")
                            End If

                        Case "SOUND"

                            lvNetMagazin.Items(CInt(intCount)).SubItems.Add(LNGIniFile.GetString("frmNetMagazin", "MSG4",
                                                                                                 "Акустическая система"))

                            If Not IsDBNull(.Fields("INV_NO_PRINTER").Value) Then
                                lvNetMagazin.Items(CInt(intCount)).SubItems.Add(.Fields("INV_NO_PRINTER").Value)
                            Else
                                lvNetMagazin.Items(CInt(intCount)).SubItems.Add("")
                            End If

                        Case "KEYB"
                            lvNetMagazin.Items(CInt(intCount)).SubItems.Add(LNGIniFile.GetString("frmNetMagazin", "MSG1",
                                                                                                 "Клавиатура"))

                            If Not IsDBNull(.Fields("INV_NO_PRINTER").Value) Then
                                lvNetMagazin.Items(CInt(intCount)).SubItems.Add(.Fields("INV_NO_PRINTER").Value)
                            Else
                                lvNetMagazin.Items(CInt(intCount)).SubItems.Add("")
                            End If

                        Case "MOUSE"

                            lvNetMagazin.Items(CInt(intCount)).SubItems.Add(LNGIniFile.GetString("frmNetMagazin", "MSG2",
                                                                                                 "Мышь"))

                            If Not IsDBNull(.Fields("INV_NO_PRINTER").Value) Then
                                lvNetMagazin.Items(CInt(intCount)).SubItems.Add(.Fields("INV_NO_PRINTER").Value)
                            Else
                                lvNetMagazin.Items(CInt(intCount)).SubItems.Add("")
                            End If

                    End Select


                    If Not IsDBNull(.Fields("NET_NAME").Value) Then
                        lvNetMagazin.Items(CInt(intCount)).SubItems.Add(.Fields("NET_NAME").Value)
                    Else
                        lvNetMagazin.Items(CInt(intCount)).SubItems.Add("")
                    End If

                    If Not IsDBNull(.Fields("OTvetstvennyj").Value) Then
                        lvNetMagazin.Items(CInt(intCount)).SubItems.Add(.Fields("OTvetstvennyj").Value)
                    Else
                        lvNetMagazin.Items(CInt(intCount)).SubItems.Add("")
                    End If

                    If Not IsDBNull(.Fields("FILIAL").Value) Then
                        lvNetMagazin.Items(CInt(intCount)).SubItems.Add(.Fields("FILIAL").Value)
                    Else
                        lvNetMagazin.Items(CInt(intCount)).SubItems.Add("")
                    End If

                    If Not IsDBNull(.Fields("MESTO").Value) Then
                        lvNetMagazin.Items(CInt(intCount)).SubItems.Add(.Fields("MESTO").Value)
                    Else
                        lvNetMagazin.Items(CInt(intCount)).SubItems.Add("")
                    End If

                    If Not IsDBNull(.Fields("kabn").Value) Then
                        lvNetMagazin.Items(CInt(intCount)).SubItems.Add(.Fields("kabn").Value)
                    Else
                        lvNetMagazin.Items(CInt(intCount)).SubItems.Add("")
                    End If


                    intCount = intCount + 1
                    .MoveNext()
                Loop
            End With
            rs.Close()
            rs = Nothing

        End If


        If frmNetMagazin.sBDO_SVT_Pref = "PC" Then
            '######################################################
            Select Case frmNetMagazin.sBDO_SVT_Pref

                Case "PC"

                    Select Case frmNetMagazin.sBDO_Pref


                        Case "G"

                            sSQL = "SELECT count(*) as t_n FROM kompy where tiptehn = 'PC' AND filial='" & A1 & "'"
                            rs = New Recordset
                            rs.Open(sSQL, DB7, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic)

                            With rs
                                scCount = .Fields("t_n").Value
                            End With
                            rs.Close()
                            rs = Nothing

                            sSQL = "SELECT id,tiptehn,INV_NO_SYSTEM,NET_NAME,TIP_COMPA,OTvetstvennyj,FILIAL,MESTO,kabn FROM kompy where tiptehn = 'PC' AND filial='" & A1 &
                                   "' ORDER BY filial, mesto, kabn, net_name"

                        Case "O"

                            sSQL = "SELECT count(*) as t_n FROM kompy where tiptehn = 'PC' AND filial='" & A1 &
                                   "' AND mesto='" & A2 & "'"
                            rs = New Recordset
                            rs.Open(sSQL, DB7, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic)

                            With rs
                                scCount = .Fields("t_n").Value
                            End With
                            rs.Close()
                            rs = Nothing

                            sSQL = "SELECT id,tiptehn,INV_NO_SYSTEM,NET_NAME,TIP_COMPA,OTvetstvennyj,FILIAL,MESTO,kabn FROM kompy where tiptehn = 'PC' AND filial='" & A1 & "' AND mesto='" & A2 &
                                   "' ORDER BY filial, mesto, kabn, net_name"

                        Case "K"
                            sSQL = "SELECT count(*) as t_n FROM kompy where tiptehn = 'PC' AND filial='" & A1 &
                                   "' AND mesto='" & A2 & "' AND kabn='" & A3 & "'"
                            rs = New Recordset
                            rs.Open(sSQL, DB7, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic)

                            With rs
                                scCount = .Fields("t_n").Value
                            End With
                            rs.Close()
                            rs = Nothing

                            sSQL = "SELECT id,tiptehn,INV_NO_SYSTEM,NET_NAME,TIP_COMPA,OTvetstvennyj,FILIAL,MESTO,kabn FROM kompy where tiptehn = 'PC' AND filial='" & A1 & "' AND mesto='" & A2 &
                                   "' AND kabn='" & A3 & "' ORDER BY filial, mesto, kabn, net_name"
                            ' and tiptehn='PC' or tiptehn='Printer' or tiptehn='MFU' or tiptehn='FAX' or tiptehn='PHONE' or tiptehn='NET' or tiptehn='IBP'

                        Case "ROOT"
                            sSQL = "SELECT count(*) as t_n FROM kompy where tiptehn = 'PC'"
                            rs = New Recordset
                            rs.Open(sSQL, DB7, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic)

                            With rs
                                scCount = .Fields("t_n").Value
                            End With
                            rs.Close()
                            rs = Nothing

                            sSQL = "SELECT id,tiptehn,INV_NO_SYSTEM,NET_NAME,TIP_COMPA,OTvetstvennyj,FILIAL,MESTO,kabn FROM kompy where tiptehn = 'PC' ORDER BY filial, mesto, kabn, net_name"

                    End Select


            End Select

            If scCount = 0 Then


            Else
                rs = New Recordset
                rs.Open(sSQL, DB7, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic)

                lvNetMagazin.Sorting = False

                With rs
                    .MoveFirst()
                    Do While Not .EOF

                        lvNetMagazin.Items.Add(.Fields("id").Value) 'col no. 1


                        lvNetMagazin.Items(CInt(intCount)).SubItems.Add(LNGIniFile.GetString("frmNetMagazin", "MSG11",
                                                                                             "Компьютер"))


                        If Not IsDBNull(.Fields("INV_NO_SYSTEM").Value) Then
                            lvNetMagazin.Items(CInt(intCount)).SubItems.Add(.Fields("INV_NO_SYSTEM").Value)
                        Else
                            lvNetMagazin.Items(CInt(intCount)).SubItems.Add("")
                        End If

                        If Not IsDBNull(.Fields("NET_NAME").Value) Then
                            lvNetMagazin.Items(CInt(intCount)).SubItems.Add(.Fields("NET_NAME").Value)
                        Else
                            lvNetMagazin.Items(CInt(intCount)).SubItems.Add("")
                        End If

                        If Not IsDBNull(.Fields("OTvetstvennyj").Value) Then
                            lvNetMagazin.Items(CInt(intCount)).SubItems.Add(.Fields("OTvetstvennyj").Value)
                        Else
                            lvNetMagazin.Items(CInt(intCount)).SubItems.Add("")
                        End If

                        If Not IsDBNull(.Fields("FILIAL").Value) Then
                            lvNetMagazin.Items(CInt(intCount)).SubItems.Add(.Fields("FILIAL").Value)
                        Else
                            lvNetMagazin.Items(CInt(intCount)).SubItems.Add("")
                        End If

                        If Not IsDBNull(.Fields("MESTO").Value) Then
                            lvNetMagazin.Items(CInt(intCount)).SubItems.Add(.Fields("MESTO").Value)
                        Else
                            lvNetMagazin.Items(CInt(intCount)).SubItems.Add("")
                        End If

                        If Not IsDBNull(.Fields("kabn").Value) Then
                            lvNetMagazin.Items(CInt(intCount)).SubItems.Add(.Fields("kabn").Value)
                        Else
                            lvNetMagazin.Items(CInt(intCount)).SubItems.Add("")
                        End If


                        intCount = intCount + 1
                        .MoveNext()
                    Loop
                End With
                rs.Close()
                rs = Nothing


                '######################################################
            End If
        End If

        ResList(lvNetMagazin)


        Exit Sub
        err_:
    End Sub


    Private Sub Button2_Click(ByVal sender As Object, ByVal e As EventArgs) Handles Button2.Click
        Me.Close()
    End Sub

    Private Sub lvNetMagazin_DoubleClick(ByVal sender As Object, ByVal e As EventArgs) Handles lvNetMagazin.DoubleClick

        Call Select_SVT()
        Me.Close()
    End Sub

    Private Sub Select_SVT()

        If lvNetMagazin.Items.Count = 0 Then Exit Sub

        Dim z As Integer

        Dim sCNT As Integer


        For z = 0 To lvNetMagazin.SelectedItems.Count - 1
            sCNT = (lvNetMagazin.SelectedItems(z).Text)
        Next

        Dim rs As Recordset
        rs = New Recordset
        rs.Open("SELECT NET_NAME,OTvetstvennyj,TipTehn FROM kompy where id=" & sCNT, DB7, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic)
        Dim sTXT As String
        Dim LNGIniFile As New IniFile(sLANGPATH)

        With rs

            Select Case .Fields("TipTehn").Value

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


            Select Case frmNetMagazin.sBDO_SVT_Pref

                Case "PC"

                    frmNetMag_Add.txtSVT.Text = sTXT & ": " & .Fields("NET_NAME").Value & " , (" &
                                                LNGIniFile.GetString("frmNetMagazin", "MSG19", "Отв.:") & " " &
                                                .Fields("OTvetstvennyj").Value & ")"
                    frmNetMagazin.sBDO_SVT_count = sCNT

                Case Else

                    frmNetMag_Add.txtKom.Text = sTXT & ": " & .Fields("NET_NAME").Value & " , (" &
                                                LNGIniFile.GetString("frmNetMagazin", "MSG19", "Отв.:") & " " &
                                                .Fields("OTvetstvennyj").Value & ")"
                    'frmNetMag_Add.txtKom.Text = LNGIniFile.GetString("frmNetMagazin", "MSG14", "Сетевое оборудование") & ": " & .Fields("NET_NAME").Value & " , (" & LNGIniFile.GetString("frmNetMagazin", "MSG19", "") & " " & .Fields("OTvetstvennyj").Value & ")"
                    frmNetMagazin.sBDO_NET_count = sCNT

            End Select


        End With

        rs.Close()
        rs = Nothing
    End Sub

    Private Sub Button1_Click(ByVal sender As Object, ByVal e As EventArgs) Handles Button1.Click
        Call Select_SVT()
        Me.Close()
    End Sub


    Private Sub lvNetMagazin_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) _
        Handles lvNetMagazin.SelectedIndexChanged
    End Sub
End Class