Public Class frmservice_add_otvets
    Public REMFU As Boolean
    Public REMED As Boolean
    Public EDT As Boolean = False

    Private Sub cmbTip_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) _
        Handles cmbTip.SelectedIndexChanged

        Select Case cmbTip.Text

            Case "Base"

                Me.Height = 330

                gbExt.Visible = False
                cmdAdd.Location = New Size(6, 275)
                cmdCancel.Location = New Size(106, 275)

            Case Else

                Me.Height = 464
                gbExt.Visible = True
                cmdAdd.Location = New Size(6, 409)
                cmdCancel.Location = New Size(106, 409)

        End Select

        Select Case frmComputers.sPREF

            Case "C"

                Dim rs As Recordset
                Dim A, B, c As String
                rs = New Recordset

                rs.Open("Select filial, mesto, kabn from kompy where id=" & frmComputers.sCOUNT, DB7,
                        CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic)

                With rs
                    A = .Fields("filial").Value
                    B = .Fields("mesto").Value
                    c = .Fields("kabn").Value
                End With

                rs.Close()
                rs = Nothing

                If Len(A) <> 0 Then

                    rs = New Recordset
                    rs.Open("Select id, NET_NAME from kompy where filial='" & A & "'  Order by NET_NAME", DB7,
                            CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic)

                Else

                    rs = New Recordset
                    rs.Open("Select id, NET_NAME from kompy where filial='' and mesto='" & B & "'  Order by NET_NAME",
                            DB7, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic)


                End If

                cmbObt.Items.Clear()

                With rs
                    .MoveFirst()
                    Do While Not .EOF

                        cmbObt.Items.Add(.Fields("NET_NAME").Value & "_" & .Fields("id").Value)

                        .MoveNext()
                    Loop
                End With

                rs.Close()
                rs = Nothing

            Case Else


        End Select
    End Sub

    Private Sub Base_A()

        If Len(cmbObt.Text) = 0 Then

            cmbTip.Text = "Base"

            'Call Base_R

            Exit Sub

        Else

        End If

        Dim g() As String
        g = Split(cmbObt.Text, "_")
        frmserviceDesc.EDTID = g(1)

        Dim rs As Recordset
        Dim sSQL, sSQL1, uname As String
        rs = New Recordset
        sSQL1 = "SELECT * FROM remonty_plus"
        rs.Open(sSQL1, DB7, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic)

        With rs
            .AddNew()
            .Fields("otzyv").Value = txtOtzyv.Text
            .Fields("Master").Value = cmbMaster.Text
            .Fields("D_T").Value = dtPic.Value
            .Fields("id_rem").Value = frmserviceDesc.r1COUNT
            .Update()
        End With

        rs.Close()
        rs = Nothing

        rs = New Recordset
        sSQL = "SELECT * FROM Remont WHERE id=" & frmserviceDesc.r1COUNT
        rs.Open(sSQL, DB7, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic)

        With rs
            .Fields("zakryt").Value = chcClose.Checked
            'If Len(UserName11) = 0 Then UserName11 = UserId & "-on-" & ComputerName
            '.Fields("UserName") = UserName11
            .Update()
        End With
        rs.Close()
        rs = Nothing

        '#################################################

        'Добавляем новый ремонт для выбранного объекта
        '#################################################

        Dim rs1 As Recordset
        rs1 = New Recordset
        sSQL = "SELECT filial,mesto,net_name FROM kompy WHERE id=" & frmserviceDesc.EDTID
        rs1.Open(sSQL, DB7, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic)

        With rs1
            uname = .Fields("filial").Value & "/" & .Fields("mesto").Value
            frmserviceDesc.rtxtC = .Fields("net_name").Value
        End With

        rs1.Close()
        rs1 = Nothing

        Dim strTime As String
        strTime = TimeString

        rs = New Recordset
        sSQL = "SELECT * FROM Remont"
        rs.Open(sSQL, DB7, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic)

        With rs

            .AddNew()
            .Fields("Id_Comp").Value = frmserviceDesc.EDTID
            .Fields("NomerRemKomp").Value = frmserviceDesc.lvRem.Items.Count + 1
            .Fields("Comp_name").Value = frmserviceDesc.rtxtC 'Имя устройства
            .Fields("Mesto_Compa").Value = uname 'Место установки устройства
            .Fields("istochnik").Value = "" 'Источник
            .Fields("Master").Value = cmbMaster.Text 'Мастер
            .Fields("D_T").Value = Date.Today 'Дата регистрации
            .Fields("phone").Value = "" 'Телефон
            .Fields("srok").Value = Date.Today 'Срок исполнения
            .Fields("name_of_remont").Value = "" 'Название
            .Fields("Remont").Value = txtOtzyv.Text 'Сообщение
            .Fields("vip").Value = cmbStat.Text 'Статус
            .Fields("otvetstv").Value = cmbOtv.Text 'Ответственный
            .Fields("krit_rem").Value = "" 'Критичность
            .Fields("Uroven").Value = cmbKrit.Text 'Тип
            .Fields("PAMIATKA").Value = "" 'Комментарий
            .Fields("PREF").Value = "C"


            Select Case chcClose.Checked

                Case True

                    If unamDB = "MS access" Then
                        .Fields("zakryt").Value = True
                    Else
                        .Fields("zakryt").Value = "1"
                    End If

                    .Fields("stopdate").Value = Date.Today 'Физическое нажатие закрытие ремонта
                    .Fields("stoptime").Value = strTime 'Физическое нажатие начала ремонта

                Case False

                    If unamDB = "MS access" Then
                        .Fields("zakryt").Value = False
                    Else
                        .Fields("zakryt").Value = "0"
                    End If

            End Select


            'If Len(UserName11) = 0 Then UserName11 = UserId & "-on-" & ComputerName
            '.Fields("UserName") = UserName11
            .Update()
        End With

        rs.Close()
        rs = Nothing


        'Call serviceDesc.LOAD_REPAIR(serviceDesc.sCOUNT, serviceDesc.lvRem)

        Me.Close()
    End Sub

    Private Sub Base_R()

        Dim rs As Recordset 'Объявляем рекордсет
        Dim sSQL As String
        Dim sSQL1 As String

        Dim strTime As String
        strTime = TimeString

        Select Case frmserviceDesc.ZaiavkR

            Case True

                sSQL = "SELECT * FROM remonty_plus WHERE id=" & frmserviceDesc.rCOUNT
                rs = New Recordset
                rs.Open(sSQL, DB7, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic)

                With rs
                    .Fields("otzyv").Value = txtOtzyv.Text
                    .Fields("Master").Value = cmbMaster.Text
                    .Fields("D_T").Value = dtPic.Value
                    .Fields("id_rem").Value = frmserviceDesc.r1COUNT
                    .Update()
                End With
                rs.Close()
                rs = Nothing


                sSQL = "SELECT * FROM Remont WHERE id=" & frmserviceDesc.r1COUNT
                rs = New Recordset
                rs.Open(sSQL, DB7, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic)

                With rs

                    Select Case chcClose.Checked

                        Case True

                            If unamDB = "MS access" Then
                                .Fields("zakryt").Value = True
                            Else
                                .Fields("zakryt").Value = "1"
                            End If

                            .Fields("stopdate").Value = Date.Today 'Физическое нажатие закрытие ремонта
                            .Fields("stoptime").Value = strTime 'Физическое нажатие начала ремонта

                        Case False

                            If unamDB = "MS access" Then
                                .Fields("zakryt").Value = False
                            Else
                                .Fields("zakryt").Value = "0"
                            End If

                    End Select

                    'If Len(UserName11) = 0 Then UserName11 = UserId & "-on-" & ComputerName
                    '.Fields("UserName") = UserName11
                    .Update()
                End With
                rs.Close()
                rs = Nothing

            Case Else

                rs = New Recordset
                sSQL1 = "SELECT * FROM remonty_plus"
                rs.Open(sSQL1, DB7, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic)

                With rs
                    .AddNew()
                    .Fields("otzyv").Value = txtOtzyv.Text
                    .Fields("Master").Value = cmbMaster.Text
                    .Fields("D_T").Value = dtPic.Value
                    .Fields("id_rem").Value = frmserviceDesc.r1COUNT
                    .Update()
                End With
                rs.Close()
                rs = Nothing


                rs = New Recordset
                sSQL = "SELECT * FROM Remont WHERE id=" & frmserviceDesc.r1COUNT
                rs.Open(sSQL, DB7, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic)

                With rs
                    Select Case chcClose.Checked

                        Case True

                            If unamDB = "MS access" Then
                                .Fields("zakryt").Value = True
                            Else
                                .Fields("zakryt").Value = "1"
                            End If

                            .Fields("stopdate").Value = Date.Today 'Физическое нажатие закрытие ремонта
                            .Fields("stoptime").Value = strTime 'Физическое нажатие начала ремонта

                        Case False

                            If unamDB = "MS access" Then
                                .Fields("zakryt").Value = False
                            Else
                                .Fields("zakryt").Value = "0"
                            End If

                    End Select
                    'If Len(UserName11) = 0 Then UserName11 = UserId & "-on-" & ComputerName
                    '.Fields("UserName") = UserName11
                    .Update()
                End With
                rs.Close()
                rs = Nothing

        End Select
    End Sub

    Private Sub cmdAdd_Click(ByVal sender As Object, ByVal e As EventArgs) Handles cmdAdd.Click

        Call DELETE_SIMBOL(Me)

        If Not (RSExists("MASTER", "name", Trim(cmbMaster.Text))) Then
            AddOnePar(cmbMaster.Text, "NAME", "SPR_Master", cmbMaster)
        End If

        Select Case cmbTip.Text

            Case "Base"

                Call Base_R()

            Case Else

                Call Base_A()

        End Select

        If REMFU = True Or REMED = True Then

            'Call LOAD_REPAIR(frmComputers.sCOUNT, frmComputers.lvRepair)

            Select Case frmComputers.sPREF

                Case "C"

                    Select Case TipTehn

                        Case "PC"
                            frmComputers.sSTAB1.SelectedTab = frmComputers.sSTAB1.TabPages("TabPage7")
                            LOAD_REPAIR(frmComputers.sCOUNT, frmComputers.lvRepair)

                        Case "NET"

                            LOAD_REPAIR(frmComputers.sCOUNT, frmComputers.lvRepairNET)

                        Case "Printer"

                            LOAD_REPAIR(frmComputers.sCOUNT, frmComputers.lvRepairPRN)

                        Case "KOpir"

                            LOAD_REPAIR(frmComputers.sCOUNT, frmComputers.lvRepairPRN)

                        Case "OT"

                            LOAD_REPAIR(frmComputers.sCOUNT, frmComputers.lvRepairOTH)

                        Case Else

                            LOAD_REPAIR(frmComputers.sCOUNT, frmComputers.lvRepairOTH)

                    End Select

                Case Else

                    Call LOAD_REPAIR(frmComputers.sCOUNT, frmComputers.lvRepairBR)

            End Select

        Else

            Call frmserviceDesc.load_rplus(frmserviceDesc.r1COUNT, frmserviceDesc.lvRem2)
            Call frmserviceDesc.load_rplus(frmserviceDesc.r1COUNT, frmService_add.lvRem2)

        End If

        REMFU = False
        REMED = False

        Call REM_CHECK()

        Me.Close()
    End Sub

    'Private Sub cmbMaster_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmbMaster.TextChanged, cmbStat.TextChanged, cmbOtv.TextChanged, cmbKrit.TextChanged, cmbObt.TextChanged
    '    Dim boxIndex As Integer, lExst As Boolean
    '    Dim box As ComboBox = sender
    '    Dim txt As String = box.Text
    '    Dim posCursor As Integer = box.SelectionStart
    '    ' If Cursor does not stay on the beginning of text box.
    '    If posCursor <> 0 Then
    '        lExst = False
    '        ' Go in cycle through the combo box list to
    '        ' find the appropriate entry in the list
    '        For boxIndex = 0 To box.Items.Count - 1
    '            If UCase(Mid(box.Items(boxIndex), 1, posCursor)) = UCase(Mid(txt, 1, posCursor)) Then
    '                box.Text = box.Items(boxIndex)
    '                box.SelectionStart = posCursor
    '                lExst = True
    '                Exit For
    '            End If
    '        Next
    '        ' We didn't find appropriate entry and return previous value to text box
    '        If Not lExst Then
    '            box.Text = Mid(txt, 1, posCursor - 1) + Mid(txt, posCursor + 1)
    '            box.SelectionStart = posCursor - 1
    '        End If
    '    End If
    'End Sub

    Private Sub frmservice_add_otvets_Load(ByVal sender As Object, ByVal e As EventArgs) Handles Me.Load

        SendFonts(Me)

        Dim LNGIniFile As New IniFile(sLANGPATH)

        Call frmservice_add_otvets_Lang()

        Select Case frmserviceDesc.ZaiavkR

            Case True

                Label3.Visible = False
                cmbTip.Visible = False
                cmdAdd.Text = LNGIniFile.GetString("frmservice_add_otvets", "MSG1", "Сохранить")

            Case False

                Label3.Visible = True
                cmbTip.Visible = True
                cmdAdd.Text = LNGIniFile.GetString("frmservice_add_otvets", "MSG2", "Добавить")

        End Select

        Me.Height = 330
        gbExt.Visible = False

        cmdAdd.Location = New Size(6, 275)
        cmdCancel.Location = New Size(106, 275)

        FillComboNET(Me.cmbStat, "name", "spr_vip", "", False, True)
        FillComboNET(Me.cmbOtv, "Name", "SPR_Master", "", False, True)
        FillComboNET(Me.cmbKrit, "Uroven", "SPR_Uroven", "", False, True)
        FillComboNET(Me.cmbMaster, "Name", "SPR_Master", "", False, True)


        dtPic.Value = Date.Today
    End Sub
End Class