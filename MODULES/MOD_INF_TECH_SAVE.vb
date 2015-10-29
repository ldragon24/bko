Module MOD_INF_TECH_SAVE
    Private Sav As Boolean
    Private DV As Boolean
    Public DV2 As Boolean = False
    Public MRZD As Boolean = False
    Public sNetName As Boolean = False

    Public Sub PreSaveOtv(ByVal sFIALIAL As String, ByVal sOTDEL As String, ByVal sKABN As String)
        On Error GoTo err_

        Dim sSQL As String
        Dim tmpTXT As String
        Dim tmpTXT2 As String
        Dim sTmp As DateTime = DateTime.Now

        sSQL = "Select OTvetstvennyj from kompy where id=" & frmComputers.sCOUNT

        Dim rs As ADODB.Recordset
        rs = New ADODB.Recordset
        rs.Open(sSQL, DB7, ADODB.CursorTypeEnum.adOpenDynamic, ADODB.LockTypeEnum.adLockOptimistic)

        With rs
            tmpTXT = .Fields("OTvetstvennyj").Value
        End With
        rs.Close()
        rs = Nothing

        Select Case TipTehn

            Case "PC"
                tmpTXT2 = frmComputers.cmbResponsible.Text

            Case "Printer"
                tmpTXT2 = frmComputers.cmbPRNotv.Text

            Case "MFU"
                tmpTXT2 = frmComputers.cmbPRNotv.Text

            Case "KOpir"
                tmpTXT2 = frmComputers.cmbPRNotv.Text

            Case "NET"
                tmpTXT2 = frmComputers.cmbNETotv.Text

            Case Else
                tmpTXT2 = frmComputers.cmbOTHotv.Text

        End Select

        If tmpTXT = tmpTXT2 Then Exit Sub

        If Len(sOTDEL) <> 0 Then sFIALIAL = sFIALIAL & "/" & sOTDEL
        If Len(sKABN) <> 0 Then sFIALIAL = sFIALIAL & "/" & sKABN

        '######################################################################
        'Меняем ответственного у всего контейнера если есть контейнер
        '######################################################################

        Dim sNUM As Integer

        rs = New Recordset
        rs.Open("SELECT COUNT(*) AS total_number FROM kompy where PCL =" & frmComputers.sCOUNT,
                     DB7, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic)

        With rs
            sNUM = .Fields("total_number").Value
        End With
        rs.Close()
        rs = Nothing

        Select Case sNUM

            Case 0

                sSQL = "INSERT INTO Zametki (Master,Zametki,D_T,Id_Comp,Comp_name,Mesto_Compa) VALUES ('" & UserNames & "','" & "Смена ответственного c " & tmpTXT & " на " & tmpTXT2 & "','" & DateAndTime.Today & "'," & frmComputers.sCOUNT & "," & "''" & ",'" & sFIALIAL & "')"
                DB7.Execute(sSQL)

            Case Else

                sSQL = "INSERT INTO Zametki (Master,Zametki,D_T,Id_Comp,Comp_name,Mesto_Compa) VALUES ('" & UserNames & "','" & "Смена ответственного c " & tmpTXT & " на " & tmpTXT2 & "','" & DateAndTime.Today & "'," & frmComputers.sCOUNT & "," & "''" & ",'" & sFIALIAL & "')"
                DB7.Execute(sSQL)

                DB7.Execute("UPDATE kompy SET OTvetstvennyj='" & tmpTXT2 & "' WHERE PCL=" & frmComputers.sCOUNT)

                'rs = New Recordset
                'rs.Open(
                '    "UPDATE kompy SET OTvetstvennyj='" & tmpTXT2 & "' WHERE PCL=" & frmComputers.sCOUNT,
                '    DB7, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic)
                'rs = Nothing

                rs = New Recordset
                rs.Open("SELECT id FROM kompy where PCL =" & frmComputers.sCOUNT,
                             DB7, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic)


                Dim rs1 As ADODB.Recordset

                With rs
                    .MoveFirst()
                    Do While Not .EOF

                        sSQL = "INSERT INTO Zametki (Master,Zametki,D_T,Id_Comp,Comp_name,Mesto_Compa) VALUES ('" & UserNames & "','" & "Смена ответственного c " & tmpTXT & " на " & tmpTXT2 & "','" & DateAndTime.Today & "'," & rs.Fields("id").Value & "," & "''" & ",'" & sFIALIAL & "')"
                        DB7.Execute(sSQL)

                        'rs1 = New Recordset
                        'rs1.Open(sSQL, DB7, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic)
                        'rs1 = Nothing

                        .MoveNext()
                    Loop
                End With
                rs.Close()
                rs = Nothing

        End Select


        Call frmComputers.N_P_LOAD_t()


        Exit Sub
err_:
        MsgBox(Err.Description)


    End Sub

    Private Sub SAVE_GARANT(ByVal sID As String, ByVal dPost As ComboBox, ByVal dtp As DateTimePicker,
                            ByVal dto As DateTimePicker)

        On Error GoTo err_

        Dim sSQL As String

        'Dim rs As Recordset
        'rs = New Recordset
        'rs.Open("Delete FROM Garantia_sis WHERE Id_Comp =" & sID, DB7, CursorTypeEnum.adOpenDynamic,
        '        LockTypeEnum.adLockOptimistic)
        'rs = Nothing

        DB7.Execute("Delete FROM Garantia_sis WHERE Id_Comp =" & sID)

        ' sSQL = "SELECT * FROM Garantia_sis"
        ' rs = New Recordset
        ' rs.Open(sSQL, DB7, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic)

        If Not (RSExists("Postav", "name", dPost.Text)) Then
            AddOnePar(dPost.Text, "name", "SPR_Postav", dPost)
        End If


        sSQL = "INSERT INTO Garantia_sis (Id_Comp,Postav,den,mesiac,god,day_o,month_o,Year_o) VALUES (" & sID & ",'" & dPost.Text & "','" & dtp.Value.Day & "','" & dtp.Value.Month & "','" & dtp.Value.Year & "','" & dto.Value.Day & "','" & dto.Value.Month & "','" & dto.Value.Year & "')"

        'Select Case DB_N

        '    Case "DSN"
        '        sSQL = "INSERT INTO Garantia_sis (Id_Comp,Postav,den,mesiac,god,day_o,month_o,Year_o) VALUES (" & sID & ",'" & dPost.Text & "','" & dtp.Value.Day & "','" & dtp.Value.Month & "','" & dtp.Value.Year & "','" & dto.Value.Day & "','" & dto.Value.Month & "','" & dto.Value.Year & "')"
        '    Case "PostgreSQL"
        '        sSQL = "INSERT INTO Garantia_sis (Id_Comp,Postav,den,mesiac,god,day_o,month_o,Year_o) VALUES (" & sID & ",'" & dPost.Text & "','" & dtp.Value.Day & "','" & dtp.Value.Month & "','" & dtp.Value.Year & "','" & dto.Value.Day & "','" & dto.Value.Month & "','" & dto.Value.Year & "')"

        '    Case "MySQL"
        '        sSQL = "INSERT INTO Garantia_sis (Id_Comp,Postav,den,mesiac,god,day_o,month_o,Year_o) VALUES (" & sID & ",'" & dPost.Text & "','" & dtp.Value.Day & "','" & dtp.Value.Month & "','" & dtp.Value.Year & "','" & dto.Value.Day & "','" & dto.Value.Month & "','" & dto.Value.Year & "')"

        '    Case Else
        '        sSQL = "INSERT INTO Garantia_sis (Id_Comp,Postav,den,mesiac,god,day_o,month_o,Year_o) VALUES (" & sID & ",'" & dPost.Text & "','" & dtp.Value.Day & "','" & dtp.Value.Month & "','" & dtp.Value.Year & "','" & dto.Value.Day & "','" & dto.Value.Month & "','" & dto.Value.Year & "')"

        'End Select

        DB7.Execute(sSQL)

        Exit Sub
err_:
        MsgBox(Err.Description & vbNewLine & "Не возможно сохранить гарантию")
    End Sub

    Private Sub UPDATE_OPLATA(ByVal SFAktNo As String, ByVal CenaRub As String, ByVal StoimRub As String, ByVal Zaiavk As String, ByVal DataVVoda As Date, ByVal dataSF As Date, ByVal Spisan As String, ByVal Balans As String, ByVal data_sp As Date, ByVal sSID As Integer)

        Dim sSQL As String
        Dim DataVVoda1(), dataSF1(), data_sp1() As String

        DataVVoda1 = Split(DataVVoda, " ")
        dataSF1 = Split(dataSF, " ")
        data_sp1 = Split(data_sp, " ")

        sSQL = "UPDATE kompy SET SFAktNo='" & SFAktNo & "', CenaRub='" & CenaRub & "', StoimRub='" & StoimRub & "', Zaiavk='" & Zaiavk & "', Spisan=" & Spisan & ", Balans=" & Balans & "  WHERE id =" & sSID
        DB7.Execute(sSQL)

        sSQL = "UPDATE kompy SET DataVVoda='" & DataVVoda1(0) & "', dataSF='" & dataSF1(0) & "', data_sp='" & data_sp1(0) & "' WHERE id =" & sSID
        DB7.Execute(sSQL)

    End Sub

    Private Sub UPDATE_INFORMARION(ByVal FILIAL As String, ByVal MESTO As String, ByVal kabn As String, ByVal TELEPHONE As String, ByVal NET_NAME As String, ByVal PSEVDONIM As String, ByVal OTvetstvennyj As String, ByVal sSID As Integer)

        Dim sSQL As String

        sSQL = "UPDATE kompy SET FILIAL='" & FILIAL & "', MESTO='" & MESTO & "', kabn='" & kabn & "', TELEPHONE='" & TELEPHONE & "', NET_NAME='" & NET_NAME & "', PSEVDONIM='" & PSEVDONIM & "', OTvetstvennyj='" & OTvetstvennyj & "' WHERE id =" & sSID

        DB7.Execute(sSQL)

    End Sub


    Public Sub SAVE_MON(Optional ByVal sSID As String = "")
        On Error GoTo Err_

        Select Case Len(frmComputers.cmbOTHDepart.Text)

            Case 0

                Select Case Len(frmComputers.cmbOTHOffice.Text)

                    Case 0

                    Case Else
                        MsgBox("Заполните поле 'Отдел' или удалите значение поля 'Кабинет' ", MsgBoxStyle.Exclamation, ProGramName)
                        Exit Sub

                End Select

            Case Else

        End Select

        If Len(frmComputers.cmbOTH.Text) = 0 Or Len(frmComputers.cmbOTHFil.Text) = 0 Then

            MsgBox("Не заполнены обязательные поля", MsgBoxStyle.Information, ProGramName)

            If Len(frmComputers.cmbOTH.Text) = 0 Then frmComputers.cmbOTH.BackColor = Color.Red
            If Len(frmComputers.cmbOTHFil.Text) = 0 Then frmComputers.cmbOTHFil.BackColor = Color.Red

            frmComputers.sSTAB3.SelectedTab = frmComputers.sSTAB3.TabPages("TabPage11")
            Exit Sub
        End If

        Select Case frmComputers.EDT

            Case True
                Call SMENA_PCL(frmComputers.sCOUNT, frmComputers.cmbOTHPCL.Text)

                Call DVIG_TEHN(frmComputers.cmbOTHFil.Text, frmComputers.cmbOTHDepart.Text, frmComputers.cmbOTHOffice.Text, frmComputers.cmbOTH.Text, frmComputers.cmbOTHPCL.Text)

                Select Case DV

                    Case True

                    Case False

                        Select Case Sav

                            Case False
                                MsgBox("Отмена перемещения", MsgBoxStyle.Exclamation, ProGramName)
                                Exit Sub
                        End Select

                End Select

        End Select

        If Not (RSExists("otv", "name", Trim(frmComputers.cmbOTHotv.Text))) Then
            AddOnePar(frmComputers.cmbOTHotv.Text, "NAME", "SPR_OTV", frmComputers.cmbOTHotv)
        End If

        If Not (RSExists("MONITOR", "name", frmComputers.cmbOTH.Text)) Then
            AddTreePar(frmComputers.cmbOTH.Text, frmComputers.txtMonDum.Text, frmComputers.PROiZV39.Text, "SPR_MONITOR",
                       frmComputers.cmbOTH)
        End If

        Dim rs As Recordset
        Dim unaPCL As String
        If Len(frmComputers.cmbOTHPCL.Text) <> 0 Then

            On Error GoTo sAR

            rs = New Recordset
            rs.Open(
                "Select id From kompy where filial='" & frmComputers.cmbOTHFil.Text & "' and mesto='" &
                frmComputers.cmbOTHDepart.Text & "' and kabn='" & frmComputers.cmbOTHOffice.Text & "' and NET_NAME='" &
                frmComputers.cmbOTHPCL.Text & "'", DB7, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic)


            With rs

                unaPCL = .Fields("id").Value

            End With
            rs.Close()
            rs = Nothing
        End If

sAR:

        If Len(unaPCL) = 0 Or unaPCL = Nothing Then unaPCL = 0

        Dim _chkOTHspis As Integer
        Dim _chkOTHNNb As Integer
        If Len(frmComputers.txtOTHSfN.Text) = 0 Then frmComputers.txtOTHSfN.Text = 0
        If Len(frmComputers.txtOTHcash.Text) = 0 Then frmComputers.txtOTHcash.Text = 0
        If Len(frmComputers.txtOTHSUMM.Text) = 0 Then frmComputers.txtOTHSUMM.Text = 0
        If frmComputers.chkOTHspis.Checked = False Then _chkOTHspis = 0 Else _chkOTHspis = 1
        If frmComputers.chkOTHNNb.Checked = False Then _chkOTHNNb = 0 Else _chkOTHNNb = 1


        Dim sSQL As String

        Select Case frmComputers.EDT

            Case False

                sSQL = "INSERT INTO kompy (MONITOR_NAME,MONITOR_DUM,MONITOR_SN,Ser_N_SIS,MONITOR_PROIZV,port_1,INV_NO_MONITOR,FILIAL,MESTO,kabn,TELEPHONE,TIPtehn,NET_NAME,PSEVDONIM,PCL) VALUES ('" & frmComputers.cmbOTH.Text & "','" & frmComputers.txtMonDum.Text & "','" & frmComputers.txtOTHSN.Text & "','" & frmComputers.txtOTHSN.Text & "','" & frmComputers.PROiZV39.Text & "','" & frmComputers.txtOTHMeMo.Text & "','" & frmComputers.txtOTHinnumber.Text & "','" & frmComputers.cmbOTHFil.Text & "','" & frmComputers.cmbOTHDepart.Text & "','" & frmComputers.cmbOTHOffice.Text & "','" & frmComputers.txtOTHphone.Text & "','" & TipTehn & "','" & frmComputers.cmbOTH.Text & "','" & frmComputers.cmbOTH.Text & "'," & unaPCL & ")"

            Case True

                sSQL = "UPDATE kompy SET MONITOR_NAME='" & frmComputers.cmbOTH.Text & "', MONITOR_DUM='" & frmComputers.txtMonDum.Text & "', MONITOR_SN='" & frmComputers.txtOTHSN.Text & "', Ser_N_SIS='" & frmComputers.txtOTHSN.Text & "', MONITOR_PROIZV='" & frmComputers.PROiZV39.Text & "', port_1='" & frmComputers.txtOTHMeMo.Text & "', INV_NO_MONITOR='" & frmComputers.txtOTHinnumber.Text & "', PCL=" & unaPCL & " WHERE id =" & sSID

        End Select

        DB7.Execute(sSQL)

        Select Case frmComputers.EDT

            Case False

                Select Case DB_N

                    Case "DSN"
                        sSQL = "Select id from kompy ORDER BY id DESC LIMIT 1"
                    Case "PostgreSQL"
                        sSQL = "Select id from kompy ORDER BY id DESC LIMIT 1"

                    Case "MySQL"

                        sSQL = "Select id from kompy ORDER BY id DESC LIMIT 1"

                    Case Else

                        sSQL = "Select top 1 id from kompy ORDER BY id DESC"

                End Select

                rs = New Recordset
                rs.Open(sSQL, DB7, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic)
                frmComputers.sCOUNT = rs.Fields("ID").Value
                rs.Close()
                rs = Nothing

                Dim objIniFile As New IniFile(PrPath & "base.ini")
                objIniFile.WriteString("general", "DK", frmComputers.sCOUNT)
                objIniFile.WriteString("general", "Default", 0)

            Case True

        End Select

        If Len(sSID) = 0 Then
            sSID = frmComputers.sCOUNT
        End If

        Call UPDATE_INFORMARION(frmComputers.cmbOTHFil.Text, frmComputers.cmbOTHDepart.Text, frmComputers.cmbOTHOffice.Text, frmComputers.txtOTHphone.Text, frmComputers.cmbOTH.Text, frmComputers.cmbOTH.Text, frmComputers.cmbOTHotv.Text, sSID)

        Call UPDATE_OPLATA(frmComputers.txtOTHSfN.Text, frmComputers.txtOTHcash.Text, frmComputers.txtOTHSUMM.Text, frmComputers.txtOTHZay.Text, frmComputers.dtOTHdataVvoda.Value, frmComputers.dtOTHSFdate.Value, _chkOTHspis, _chkOTHNNb, frmComputers.dtOTHSpisanie.Value, sSID)

        Call SAVE_GARANT(sSID, frmComputers.cmbOTHPostav, frmComputers.dtGOTHPr, frmComputers.dtGOTHok)

        frmComputers.cmbOTH.BackColor = frmComputers.cmbOTH.BackColor
        frmComputers.cmbOTHFil.BackColor = frmComputers.cmbOTHFil.BackColor

        Dim tmpName, tmpFil, tmpDep, tmpOff, tmpID, tmpTip As String
        tmpName = frmComputers.cmbOTH.Text
        tmpFil = frmComputers.cmbOTHFil.Text
        tmpDep = frmComputers.cmbOTHDepart.Text
        tmpOff = frmComputers.cmbOTHOffice.Text
        tmpID = frmComputers.sCOUNT
        tmpTip = TipTehn

        PRESAVE_TREE(frmComputers.cmbOTHFil, frmComputers.cmbOTHDepart, frmComputers.cmbOTHOffice)

        Call UpdateTree(tmpName, tmpTip, tmpID, tmpFil, tmpDep, tmpOff)

        Exit Sub
Err_:
        MsgBox(Err.Description)
    End Sub

    Public Sub Save_OT(Optional ByVal sSID As String = "")
        On Error GoTo Err_

        Select Case Len(frmComputers.cmbOTHDepart.Text)

            Case 0

                Select Case Len(frmComputers.cmbOTHOffice.Text)

                    Case 0

                    Case Else
                        MsgBox("Заполните поле 'Отдел' или удалите значение поля 'Кабинет' ", MsgBoxStyle.Exclamation, ProGramName)
                        Exit Sub

                End Select

            Case Else

        End Select

        If Len(frmComputers.cmbOTH.Text) = 0 Or Len(frmComputers.cmbOTHFil.Text) = 0 Then

            MsgBox("Не заполнены обязательные поля", MsgBoxStyle.Information, ProGramName)

            If Len(frmComputers.cmbOTH.Text) = 0 Then frmComputers.cmbOTH.BackColor = Color.Red
            If Len(frmComputers.cmbOTHFil.Text) = 0 Then frmComputers.cmbOTHFil.BackColor = Color.Red

            frmComputers.sSTAB3.SelectedTab = frmComputers.sSTAB3.TabPages("TabPage11")
            Exit Sub
        End If

        Select Case frmComputers.EDT

            Case True
                Call SMENA_PCL(frmComputers.sCOUNT, frmComputers.cmbOTHPCL.Text)

                Call DVIG_TEHN(frmComputers.cmbOTHFil.Text, frmComputers.cmbOTHDepart.Text, frmComputers.cmbOTHOffice.Text, frmComputers.cmbOTH.Text, frmComputers.cmbOTHPCL.Text)

                Select Case DV

                    Case True

                    Case False

                        Select Case Sav

                            Case False
                                MsgBox("Отмена перемещения", MsgBoxStyle.Exclamation, ProGramName)
                                Exit Sub
                        End Select

                End Select

        End Select

        Dim LNGIniFile As New IniFile(sLANGPATH)
        Dim sTIP_COMPA As String

        Select Case TipTehn

            Case "OT"

                If Not RSExists("OTHER", "name", Trim(frmComputers.cmbOTHConnect.Text)) Then
                    AddOnePar(frmComputers.cmbOTHConnect.Text, "NAME", "spr_other", frmComputers.cmbOTHConnect)
                End If

            Case "PHOTO"
                sTIP_COMPA = LNGIniFile.GetString("frmMain", "33", "")
                If Not RSExists("PHOTO", "name", Trim(frmComputers.cmbOTH.Text)) Then
                    AddTwoPar(frmComputers.cmbOTH.Text, frmComputers.PROiZV39.Text, "spr_photo", frmComputers.cmbOTH)
                End If

            Case "FAX"
                sTIP_COMPA = LNGIniFile.GetString("frmMain", "34", "")
                If Not RSExists("FAX", "name", Trim(frmComputers.cmbOTH.Text)) Then
                    AddTwoPar(frmComputers.cmbOTH.Text, frmComputers.PROiZV39.Text, "spr_fax", frmComputers.cmbOTH)
                End If

            Case "PHONE"
                sTIP_COMPA = LNGIniFile.GetString("frmMain", "32", "")
                If Not RSExists("PHONE", "name", Trim(frmComputers.cmbOTH.Text)) Then
                    AddTwoPar(frmComputers.cmbOTH.Text, frmComputers.PROiZV39.Text, "spr_phone", frmComputers.cmbOTH)
                End If

            Case "ZIP"

                sTIP_COMPA = LNGIniFile.GetString("frmMain", "36", "")

                If Not RSExists("spr_zip", "name", Trim(frmComputers.cmbOTH.Text)) Then
                    AddTwoPar(frmComputers.cmbOTH.Text, frmComputers.PROiZV39.Text, "spr_zip", frmComputers.cmbOTH)
                End If

            Case "SCANER"
                sTIP_COMPA = LNGIniFile.GetString("frmMain", "37", "")
                If Not RSExists("SCANER", "name", Trim(frmComputers.cmbOTH.Text)) Then
                    AddTwoPar(frmComputers.cmbOTH.Text, frmComputers.PROiZV39.Text, "SPR_SCANER", frmComputers.cmbOTH)
                End If

            Case "USB"
                sTIP_COMPA = LNGIniFile.GetString("frmMain", "39", "")
                If Not RSExists("USB", "name", Trim(frmComputers.cmbOTH.Text)) Then
                    AddTwoPar(frmComputers.cmbOTH.Text, frmComputers.PROiZV39.Text, "SPR_USB", frmComputers.cmbOTH)
                End If

            Case "SOUND"
                sTIP_COMPA = LNGIniFile.GetString("frmMain", "40", "")
                If Not RSExists("ASISTEM", "name", Trim(frmComputers.cmbOTH.Text)) Then
                    AddTwoPar(frmComputers.cmbOTH.Text, frmComputers.PROiZV39.Text, "SPR_ASISTEM", frmComputers.cmbOTH)
                End If

            Case "IBP"
                sTIP_COMPA = LNGIniFile.GetString("frmMain", "41", "")
                If Not RSExists("IBP", "name", Trim(frmComputers.cmbOTH.Text)) Then
                    AddTwoPar(frmComputers.cmbOTH.Text, frmComputers.PROiZV39.Text, "SPR_IBP", frmComputers.cmbOTH)
                End If

            Case "FS"
                sTIP_COMPA = LNGIniFile.GetString("frmMain", "46", "")
                If Not RSExists("SPR_FS", "name", Trim(frmComputers.cmbOTH.Text)) Then
                    AddTwoPar(frmComputers.cmbOTH.Text, frmComputers.PROiZV39.Text, "SPR_FS", frmComputers.cmbOTH)
                End If

            Case "KEYB"
                sTIP_COMPA = LNGIniFile.GetString("frmMain", "44", "")
                If Not RSExists("KEYBOARD", "name", Trim(frmComputers.cmbOTH.Text)) Then
                    AddTwoPar(frmComputers.cmbOTH.Text, frmComputers.PROiZV39.Text, "SPR_KEYBOARD", frmComputers.cmbOTH)
                End If

            Case "MOUSE"
                sTIP_COMPA = LNGIniFile.GetString("frmMain", "45", "")
                If Not RSExists("MOUSE", "name", Trim(frmComputers.cmbOTH.Text)) Then
                    AddTwoPar(frmComputers.cmbOTH.Text, frmComputers.PROiZV39.Text, "SPR_MOUSE", frmComputers.cmbOTH)
                End If

            Case "CNT"
                sTIP_COMPA = LNGIniFile.GetString("frmMain", "CNTToolStripMenuItem", "")

                If Not RSExists("OTHER", "name", Trim(frmComputers.cmbOTH.Text)) Then
                    AddOnePar(frmComputers.cmbOTH.Text, "NAME", "spr_other", frmComputers.cmbOTH)
                End If

            Case Else
                sTIP_COMPA = frmComputers.cmbOTHConnect.Text 'LNGIniFile.GetString("frmMain", "38", "")
                If Not RSExists("OTHD", "name", Trim(frmComputers.cmbOTH.Text)) Then
                    AddTreePar(frmComputers.cmbOTH.Text, frmComputers.cmbOTHConnect.Text, frmComputers.PROiZV39.Text,
                               "SPR_OTH_DEV", frmComputers.cmbOTH)
                End If

        End Select

        If Not RSExists("otv", "name", Trim(frmComputers.cmbOTHotv.Text)) Then
            AddOnePar(frmComputers.cmbOTHotv.Text, "NAME", "SPR_OTV", frmComputers.cmbOTHotv)
        End If


        Dim rs As Recordset
        Dim unaPCL As String
        If Len(frmComputers.cmbOTHPCL.Text) <> 0 Then

            On Error GoTo sAR

            rs = New Recordset
            rs.Open(
                "Select id From kompy where filial='" & frmComputers.cmbOTHFil.Text & "' and mesto='" &
                frmComputers.cmbOTHDepart.Text & "' and kabn='" & frmComputers.cmbOTHOffice.Text & "' and NET_NAME='" &
                frmComputers.cmbOTHPCL.Text & "'", DB7, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic)

            With rs

                unaPCL = .Fields("id").Value

            End With
            rs.Close()
            rs = Nothing
        End If

sAR:
        If Len(unaPCL) = 0 Or unaPCL = Nothing Then unaPCL = 0

        Dim _chkOTHspis As Integer
        Dim _chkOTHNNb As Integer
        If Len(frmComputers.txtOTHSfN.Text) = 0 Then frmComputers.txtOTHSfN.Text = 0
        If Len(frmComputers.txtOTHcash.Text) = 0 Then frmComputers.txtOTHcash.Text = 0
        If Len(frmComputers.txtOTHSUMM.Text) = 0 Then frmComputers.txtOTHSUMM.Text = 0
        If frmComputers.chkOTHspis.Checked = False Then _chkOTHspis = 0 Else _chkOTHspis = 1
        If frmComputers.chkOTHNNb.Checked = False Then _chkOTHNNb = 0 Else _chkOTHNNb = 1


        'frmComputers.txtOTHIP.Text


        Dim sSQL As String

        Select Case frmComputers.EDT

            Case False

                sSQL = "INSERT INTO kompy (PRINTER_NAME_1,PRINTER_SN_1,Ser_N_SIS,PRINTER_PROIZV_1,port_1,INV_NO_PRINTER,TIPtehn,PCL,tip_compa,NET_IP_1) VALUES ('" & frmComputers.cmbOTH.Text & "','" & frmComputers.txtOTHSN.Text & "','" & frmComputers.txtOTHSN.Text & "','" & frmComputers.PROiZV39.Text & "','" & frmComputers.txtOTHMeMo.Text & "','" & frmComputers.txtOTHinnumber.Text & "','" & TipTehn & "'," & unaPCL & ",'" & sTIP_COMPA & "','" & frmComputers.txtOTHIP.Text & "')"

            Case True

                sSQL = "UPDATE kompy SET PRINTER_NAME_1='" & frmComputers.cmbOTH.Text & "', PRINTER_SN_1='" & frmComputers.txtOTHSN.Text & "', Ser_N_SIS='" & frmComputers.txtOTHSN.Text & "', PRINTER_PROIZV_1='" & frmComputers.PROiZV39.Text & "', port_1='" & frmComputers.txtOTHMeMo.Text & "', INV_NO_PRINTER='" & frmComputers.txtOTHinnumber.Text & "', TIPtehn='" & TipTehn & "', PCL=" & unaPCL & " , tip_compa='" & frmComputers.cmbOTHConnect.Text & "', NET_IP_1='" & frmComputers.txtOTHIP.Text & "' WHERE id =" & sSID

        End Select

        DB7.Execute(sSQL)

        Select Case frmComputers.EDT

            Case False

                Select Case DB_N

                    Case "DSN"
                        sSQL = "Select id from kompy ORDER BY id DESC LIMIT 1"
                    Case "PostgreSQL"
                        sSQL = "Select id from kompy ORDER BY id DESC LIMIT 1"

                    Case "MySQL"

                        sSQL = "Select id from kompy ORDER BY id DESC LIMIT 1"

                    Case Else

                        sSQL = "Select top 1 id from kompy ORDER BY id DESC"

                End Select

                rs = New Recordset
                rs.Open(sSQL, DB7, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic)
                frmComputers.sCOUNT = rs.Fields("ID").Value
                rs.Close()
                rs = Nothing

                Dim objIniFile As New IniFile(PrPath & "base.ini")
                objIniFile.WriteString("general", "DK", frmComputers.sCOUNT)
                objIniFile.WriteString("general", "Default", 0)

            Case True

        End Select

        If Len(sSID) = 0 Then
            sSID = frmComputers.sCOUNT
        End If

        Call UPDATE_INFORMARION(frmComputers.cmbOTHFil.Text, frmComputers.cmbOTHDepart.Text, frmComputers.cmbOTHOffice.Text, frmComputers.txtOTHphone.Text, frmComputers.cmbOTH.Text, frmComputers.cmbOTH.Text, frmComputers.cmbOTHotv.Text, sSID)

        Call UPDATE_OPLATA(frmComputers.txtOTHSfN.Text, frmComputers.txtOTHcash.Text, frmComputers.txtOTHSUMM.Text, frmComputers.txtOTHZay.Text, frmComputers.dtOTHdataVvoda.Value, frmComputers.dtOTHSFdate.Value, _chkOTHspis, _chkOTHNNb, frmComputers.dtOTHSpisanie.Value, sSID)

        Call SAVE_GARANT(sSID, frmComputers.cmbOTHPostav, frmComputers.dtGOTHPr, frmComputers.dtGOTHok)

        Select Case TipTehn

            Case "IBP"
                sSQL = "UPDATE kompy SET SNMP_COMMUNITY='" & frmComputers.txtSNMP.Text & "', SNMP=" & frmComputers.chkSNMP.Checked & " WHERE id =" & sSID

                DB7.Execute(sSQL)

        End Select


        frmComputers.cmbOTH.BackColor = frmComputers.cmbOTH.BackColor
        frmComputers.cmbOTHFil.BackColor = frmComputers.cmbOTHFil.BackColor

        Dim tmpName, tmpFil, tmpDep, tmpOff, tmpID, tmpTip As String
        tmpName = frmComputers.cmbOTH.Text
        tmpFil = frmComputers.cmbOTHFil.Text
        tmpDep = frmComputers.cmbOTHDepart.Text
        tmpOff = frmComputers.cmbOTHOffice.Text
        tmpID = frmComputers.sCOUNT
        tmpTip = TipTehn

        PRESAVE_TREE(frmComputers.cmbOTHFil, frmComputers.cmbOTHDepart, frmComputers.cmbOTHOffice)

        Call UpdateTree(tmpName, tmpTip, tmpID, tmpFil, tmpDep, tmpOff)

        Exit Sub
Err_:
        MsgBox(Err.Description)
    End Sub

    Public Sub Save_T(Optional ByVal sSID As String = "")

        On Error GoTo err_

        Select Case Len(frmComputers.cmbDepartment.Text)

            Case 0

                Select Case Len(frmComputers.cmbOffice.Text)

                    Case 0

                    Case Else
                        MsgBox("Заполните поле 'Отдел' или удалите значение поля 'Кабинет' ", MsgBoxStyle.Exclamation, ProGramName)
                        Exit Sub

                End Select

            Case Else

        End Select

        If _
            Len(frmComputers.txtSNAME.Text) = 0 Or Len(frmComputers.txtPSEUDONIM.Text) = 0 Or
            Len(frmComputers.cmbBranch.Text) = 0 Then

            MsgBox("Не заполнены обязательные поля", MsgBoxStyle.Information, ProGramName)

            If Len(frmComputers.txtSNAME.Text) = 0 Then frmComputers.txtSNAME.BackColor = Color.Red
            If Len(frmComputers.txtPSEUDONIM.Text) = 0 Then frmComputers.txtPSEUDONIM.BackColor = Color.Red
            If Len(frmComputers.cmbBranch.Text) = 0 Then frmComputers.cmbBranch.BackColor = Color.Red
            frmComputers.sSTAB1.SelectedTab = frmComputers.sSTAB1.TabPages("TabPage6")
            Exit Sub

        End If

        new_prov = False

        Select Case frmComputers.EDT
            Case False
                Call proverka_sn()
        End Select

        Select Case new_prov
            Case True
                Exit Sub
        End Select

        Call addEXISTTEH_()

        Select Case frmComputers.EDT

            Case True

                Call SMENA_PCL(frmComputers.sCOUNT, frmComputers.cmbPCL.Text)

                Call _
                    DVIG_TEHN(frmComputers.cmbBranch.Text, frmComputers.cmbDepartment.Text, frmComputers.cmbOffice.Text,
                              frmComputers.txtSNAME.Text, frmComputers.cmbPCLK.Text)

                Select Case DV

                    Case True

                    Case False

                        Select Case Sav

                            Case False

                                MsgBox("Отмена перемещения", MsgBoxStyle.Exclamation, ProGramName)

                                Select Case frmComputers.pDRAG

                                    Case False

                                        Select Case TREE_UPDATE

                                            Case 0

                                                Select Case frmComputers.EDT
                                                    Case False
                                                        RefFilTree(frmComputers.lstGroups)
                                                    Case True
                                                        frmComputers.LOAD_LIST()
                                                End Select

                                                Select Case sNetName
                                                    Case True
                                                        frmComputers.lstGroups.SelectedNode.Text = frmComputers.cmbOTH.Text
                                                End Select


                                            Case 1

                                                Select Case sNetName
                                                    Case True
                                                        frmComputers.lstGroups.SelectedNode.Text = frmComputers.cmbOTH.Text
                                                End Select

                                                Select Case frmComputers.EDT
                                                    Case True
                                                        frmComputers.LOAD_LIST()
                                                End Select

                                        End Select

                                End Select

                                Exit Sub

                        End Select

                End Select

        End Select

        Dim rs As Recordset

        Dim unaPCL As Integer = 0

        Select Case Len(frmComputers.cmbPCLK.Text)

            Case 0

            Case Else
                On Error GoTo sAR
                rs = New Recordset
                rs.Open(
                    "Select id From kompy where filial='" & frmComputers.cmbBranch.Text & "' and mesto='" &
                    frmComputers.cmbDepartment.Text & "' and kabn='" & frmComputers.cmbOffice.Text & "' and NET_NAME='" &
                    frmComputers.cmbPCLK.Text & "'", DB7, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic)

                With rs
                    unaPCL = .Fields("id").Value
                End With
                rs.Close()
                rs = Nothing

        End Select

sAR:
        If Len(unaPCL) = 0 Or unaPCL = Nothing Then unaPCL = 0

        If Len(frmComputers.cmbAppointment.Text) = 0 Then frmComputers.cmbAppointment.Text = "Рабочая станция"
        If Len(frmComputers.txtPCcash.Text) = 0 Then frmComputers.txtPCcash.Text = 0
        If Len(frmComputers.txtPCSUMM.Text) = 0 Then frmComputers.txtPCSUMM.Text = 0
        If Len(frmComputers.txtPCSfN.Text) = 0 Then frmComputers.txtPCSfN.Text = 0

        Dim _chkPRNspis As Integer
        Dim _chkPRNNNb As Integer
        If frmComputers.chkPCspis.Checked = False Then _chkPRNspis = 0 Else _chkPRNspis = 1
        If frmComputers.chkPCNNb.Checked = False Then _chkPRNNNb = 0 Else _chkPRNNNb = 1

        Dim sSQL As String

        Select Case frmComputers.EDT

            Case False

                sSQL = "INSERT INTO kompy (TIP_COMPA,INV_NO_SYSTEM,INV_NO_MONITOR,INV_NO_IBP,INV_NO_PRINTER,PCL,TIPtehn) VALUES ('" &
                       frmComputers.cmbAppointment.Text & "','" &
                       frmComputers.txtSBSN.Text & "','" &
                       frmComputers.txtMSN.Text & "','" &
                       frmComputers.IN_IBP.Text & "','" &
                       frmComputers.IN_PRN.Text & "'," &
                       unaPCL & ",'" &
                       TipTehn & "')"

                DB7.Execute(sSQL)

                Select Case DB_N

                    Case "DSN"
                        sSQL = "Select id from kompy ORDER BY id DESC LIMIT 1"
                    Case "PostgreSQL"
                        sSQL = "Select id from kompy ORDER BY id DESC LIMIT 1"

                    Case "MySQL"

                        sSQL = "Select id from kompy ORDER BY id DESC LIMIT 1"

                    Case Else

                        sSQL = "Select top 1 id from kompy ORDER BY id DESC"

                End Select

                rs = New Recordset
                rs.Open(sSQL, DB7, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic)
                sSID = rs.Fields("ID").Value
                rs.Close()
                rs = Nothing

                frmComputers.sCOUNT = sSID

            Case True

                sSQL = "UPDATE kompy SET " &
                        "TIP_COMPA='" & frmComputers.cmbAppointment.Text & "'," &
                        "INV_NO_SYSTEM='" & frmComputers.txtSBSN.Text & "'," &
                        "INV_NO_MONITOR='" & frmComputers.txtMSN.Text & "'," &
                        "INV_NO_IBP='" & frmComputers.IN_IBP.Text & "'," &
                        "INV_NO_PRINTER='" & frmComputers.IN_PRN.Text & "'," &
                        "PCL=" & unaPCL & "," &
                        "TIPtehn='" & TipTehn & "' " & " WHERE id =" & sSID

                DB7.Execute(sSQL)

        End Select

        On Error Resume Next

        Call UPDATE_INFORMARION(frmComputers.cmbBranch.Text, frmComputers.cmbDepartment.Text, frmComputers.cmbOffice.Text, frmComputers.txtPHONE.Text, frmComputers.txtSNAME.Text, frmComputers.txtPSEUDONIM.Text, frmComputers.cmbResponsible.Text, sSID)

        sSQL = "UPDATE kompy SET " &
                       "CPU1='" & frmComputers.cmbCPU1.Text & "'," &
                       "CPUmhz1='" & frmComputers.txtMHZ1.Text & "'," &
                       "CPUSocket1='" & frmComputers.txtSoc1.Text & "'," &
                       "CPUProizv1='" & frmComputers.PROizV1.Text & "'," &
                       "CPU2='" & frmComputers.cmbCPU2.Text & "'," &
                       "CPUmhz2='" & frmComputers.txtMHZ2.Text & "'," &
                       "CPUSocket2='" & frmComputers.txtSoc2.Text & "'," &
                       "CPUProizv2='" & frmComputers.PROizV2.Text & "'," &
                       "CPU3='" & frmComputers.cmbCPU3.Text & "'," &
                       "CPUmhz3='" & frmComputers.txtMHZ3.Text & "'," &
                       "CPUSocket3='" & frmComputers.txtSoc3.Text & "'," &
                       "CPUProizv3='" & frmComputers.PROizV3.Text & "'," &
                       "CPU4='" & frmComputers.cmbCPU4.Text & "'," &
                       "CPUmhz4='" & frmComputers.txtMHZ4.Text & "'," &
                       "CPUSocket4='" & frmComputers.txtSoc4.Text & "'," &
                       "CPUProizv4='" & frmComputers.PROizV4.Text & "' " &
                       " WHERE id =" & sSID

        DB7.Execute(sSQL)

        sSQL = "UPDATE kompy SET " &
               "MB_NAME='" & frmComputers.cmbMB.Text & "'," &
               "Mb_Chip='" & frmComputers.txtChip.Text & "'," &
               "Mb_Proizvod='" & frmComputers.PROizV5.Text & "'," &
               "Mb_Id='" & frmComputers.txtSN_MB.Text & "' " &
                " WHERE id =" & sSID

        DB7.Execute(sSQL)

        sSQL = "UPDATE kompy SET " &
               "RAM_1='" & frmComputers.cmbRAM1.Text & "'," &
               "RAM_speed_1='" & frmComputers.txtRamS1.Text & "'," &
               "RAM_SN_1='" & frmComputers.txtRamSN1.Text & "'," &
               "RAM_PROIZV_1='" & frmComputers.PROizV6.Text & "'," &
               "RAM_2='" & frmComputers.cmbRAM2.Text & "'," &
               "RAM_speed_2='" & frmComputers.txtRamS2.Text & "'," &
               "RAM_SN_2='" & frmComputers.txtRamSN2.Text & "'," &
               "RAM_PROIZV_2='" & frmComputers.PROizV7.Text & "'," &
               "RAM_3='" & frmComputers.cmbRAM3.Text & "'," &
               "RAM_speed_3='" & frmComputers.txtRamS3.Text & "'," &
               "RAM_SN_3='" & frmComputers.txtRamSN3.Text & "'," &
               "RAM_PROIZV_3='" & frmComputers.PROizV8.Text & "'," &
               "RAM_4='" & frmComputers.cmbRAM4.Text & "'," &
               "RAM_speed_4='" & frmComputers.txtRamS4.Text & "'," &
               "RAM_SN_4='" & frmComputers.txtRamSN4.Text & "'," &
               "RAM_PROIZV_4='" & frmComputers.PROizV9.Text & "'," &
               "RAM_5='" & frmComputers.cmbRAM5.Text & "'," &
               "RAM_speed_5='" & frmComputers.txtRamS5.Text & "'," &
               "RAM_SN_5='" & frmComputers.txtRamSN5.Text & "'," &
               "RAM_PROIZV_5='" & frmComputers.PROizV44.Text & "'," &
               "RAM_6='" & frmComputers.cmbRAM6.Text & "'," &
               "RAM_speed_6='" & frmComputers.txtRamS6.Text & "'," &
               "RAM_SN_6='" & frmComputers.txtRamSN6.Text & "'," &
               "RAM_PROIZV_6='" & frmComputers.PROizV45.Text & "'," &
               "RAM_7='" & frmComputers.cmbRAM7.Text & "'," &
               "RAM_speed_7='" & frmComputers.txtRamS7.Text & "'," &
               "RAM_SN_7='" & frmComputers.txtRamSN7.Text & "'," &
               "RAM_PROIZV_7='" & frmComputers.PROizV46.Text & "'," &
               "RAM_8='" & frmComputers.cmbRAM8.Text & "'," &
               "RAM_speed_8='" & frmComputers.txtRamS8.Text & "'," &
               "RAM_SN_8='" & frmComputers.txtRamSN8.Text & "'," &
               "RAM_PROIZV_8='" & frmComputers.PROizV47.Text & "' " &
                " WHERE id =" & sSID

        DB7.Execute(sSQL)

        sSQL = "UPDATE kompy SET " &
               "HDD_Name_1='" & frmComputers.cmbHDD1.Text & "'," &
               "HDD_OB_1='" & frmComputers.txtHDDo1.Text & "'," &
               "HDD_SN_1='" & frmComputers.txtHDDsN1.Text & "'," &
               "HDD_PROIZV_1='" & frmComputers.PROizV10.Text & "'," &
               "HDD_Name_2='" & frmComputers.cmbHDD2.Text & "'," &
               "HDD_OB_2='" & frmComputers.txtHDDo2.Text & "'," &
               "HDD_SN_2='" & frmComputers.txtHDDsN2.Text & "'," &
               "HDD_PROIZV_2='" & frmComputers.PROizV11.Text & "'," &
               "HDD_Name_3='" & frmComputers.cmbHDD3.Text & "'," &
               "HDD_OB_3='" & frmComputers.txtHDDo3.Text & "'," &
               "HDD_SN_3='" & frmComputers.txtHDDsN3.Text & "'," &
               "HDD_PROIZV_3='" & frmComputers.PROizV12.Text & "'," &
               "HDD_Name_4='" & frmComputers.cmbHDD4.Text & "'," &
               "HDD_OB_4='" & frmComputers.txtHDDo4.Text & "'," &
               "HDD_SN_4='" & frmComputers.txtHDDsN4.Text & "'," &
               "HDD_PROIZV_4='" & frmComputers.PROizV13.Text & "'," &
               "HDD_Name_5='" & frmComputers.cmbHDD5.Text & "'," &
               "HDD_OB_5='" & frmComputers.txtHDDo5.Text & "'," &
               "HDD_SN_5='" & frmComputers.txtHDDsN5.Text & "'," &
               "HDD_PROIZV_5='" & frmComputers.PROizV48.Text & "'," &
               "HDD_Name_6='" & frmComputers.cmbHDD6.Text & "'," &
               "HDD_OB_6='" & frmComputers.txtHDDo6.Text & "'," &
               "HDD_SN_6='" & frmComputers.txtHDDsN6.Text & "'," &
               "HDD_PROIZV_6='" & frmComputers.PROizV49.Text & "'," &
               "HDD_Name_7='" & frmComputers.cmbHDD7.Text & "'," &
               "HDD_OB_7='" & frmComputers.txtHDDo7.Text & "'," &
               "HDD_SN_7='" & frmComputers.txtHDDsN7.Text & "'," &
               "HDD_PROIZV_7='" & frmComputers.PROizV50.Text & "'," &
               "HDD_Name_8='" & frmComputers.cmbHDD8.Text & "'," &
               "HDD_OB_8='" & frmComputers.txtHDDo8.Text & "'," &
               "HDD_SN_8='" & frmComputers.txtHDDsN8.Text & "'," &
               "HDD_PROIZV_8='" & frmComputers.PROizV51.Text & "' " &
                " WHERE id =" & sSID

        DB7.Execute(sSQL)

        sSQL = "UPDATE kompy SET " &
               "SVGA_NAME='" & frmComputers.cmbSVGA1.Text & "'," &
               "SVGA_OB_RAM='" & frmComputers.txtSVGAr1.Text & "'," &
               "SVGA_SN='" & frmComputers.txtSVGAs1.Text & "'," &
               "SVGA_PROIZV='" & frmComputers.PROizV14.Text & "'," &
               "SVGA2_NAME='" & frmComputers.cmbSVGA2.Text & "'," &
               "SVGA2_OB_RAM='" & frmComputers.txtSVGAr2.Text & "'," &
               "SVGA2_SN='" & frmComputers.txtSVGAs2.Text & "'," &
               "SVGA2_PROIZV='" & frmComputers.PROizV15.Text & "' " &
                " WHERE id =" & sSID

        DB7.Execute(sSQL)

        sSQL = "UPDATE kompy SET " &
               "SOUND_NAME='" & frmComputers.cmbSound.Text & "'," &
               "SOUND_SN='" & frmComputers.txtSoundS.Text & "'," &
               "SOUND_PROIZV='" & frmComputers.PROizV16.Text & "' " &
                " WHERE id =" & sSID

        DB7.Execute(sSQL)

        sSQL = "UPDATE kompy SET " &
               "CD_NAME='" & frmComputers.cmbOPTIC1.Text & "'," &
               "CD_SPEED='" & frmComputers.txtOPTICs1.Text & "'," &
               "CD_SN='" & frmComputers.txtOPTICsn1.Text & "'," &
               "CD_PROIZV='" & frmComputers.PROizV17.Text & "'," &
               "CDRW_NAME='" & frmComputers.cmbOPTIC2.Text & "'," &
               "CDRW_SPEED='" & frmComputers.txtOPTICs2.Text & "'," &
               "CDRW_SN='" & frmComputers.txtOPTICsn2.Text & "'," &
               "CDRW_PROIZV='" & frmComputers.PROizV18.Text & "'," &
               "DVD_NAME='" & frmComputers.cmbOPTIC3.Text & "'," &
               "DVD_SPEED='" & frmComputers.txtOPTICs3.Text & "'," &
               "DVD_SN='" & frmComputers.txtOPTICsn3.Text & "'," &
               "DVD_PROIZV='" & frmComputers.PROizV19.Text & "' " &
                " WHERE id =" & sSID

        DB7.Execute(sSQL)

        sSQL = "UPDATE kompy SET " &
               "NET_NAME_1='" & frmComputers.cmbNET1.Text & "'," &
               "NET_IP_1='" & frmComputers.txtNETip1.Text & "'," &
               "NET_MAC_1='" & frmComputers.txtNETmac1.Text & "'," &
               "NET_PROIZV_1='" & frmComputers.PROizV20.Text & "'," &
               "NET_NAME_2='" & frmComputers.cmbNET2.Text & "'," &
               "NET_IP_2='" & frmComputers.txtNETip2.Text & "'," &
               "NET_MAC_2='" & frmComputers.txtNETmac2.Text & "'," &
               "NET_PROIZV_2='" & frmComputers.PROizV21.Text & "' " &
                " WHERE id =" & sSID

        DB7.Execute(sSQL)

        sSQL = "UPDATE kompy SET " &
               "FDD_NAME='" & frmComputers.cmbFDD.Text & "'," &
               "FDD_SN='" & frmComputers.txtSN.Text & "'," &
               "FDD_PROIZV='" & frmComputers.PROizV22.Text & "' " &
                " WHERE id =" & sSID

        DB7.Execute(sSQL)

        sSQL = "UPDATE kompy SET " &
               "MODEM_NAME='" & frmComputers.cmbModem.Text & "'," &
               "MODEM_SN='" & frmComputers.txtModemSN.Text & "'," &
               "MODEM_PROIZV='" & frmComputers.PROizV24.Text & "' " &
               " WHERE id =" & sSID

        DB7.Execute(sSQL)

        sSQL = "UPDATE kompy SET " &
            "CASE_NAME='" & frmComputers.cmbCase.Text & "'," &
            "CASE_SN='" & frmComputers.txtCase1.Text & "'," &
            "CASE_PROIZV='" & frmComputers.PROizV25.Text & "' " &
             " WHERE id =" & sSID

        DB7.Execute(sSQL)

        sSQL = "UPDATE kompy SET " &
            "CREADER_NAME='" & frmComputers.cmbCreader.Text & "'," &
            "CREADER_SN='" & frmComputers.txtCreader1.Text & "'," &
            "CREADER_PROIZV='" & frmComputers.PROizV23.Text & "' " &
            " WHERE id =" & sSID

        DB7.Execute(sSQL)

        sSQL = "UPDATE kompy SET " &
            "BLOCK='" & frmComputers.cmbBP.Text & "'," &
            "SN_BLOCK='" & frmComputers.txtBP1.Text & "'," &
            "PROIZV_BLOCK='" & frmComputers.PROizV26.Text & "' " &
            " WHERE id =" & sSID

        DB7.Execute(sSQL)

        sSQL = "UPDATE kompy SET " &
            "SYS_PR='" & frmComputers.PROizV27.Text & "'," &
            "Ser_N_SIS='" & frmComputers.txtSNSB.Text & "'," &
            "PATH='" & frmComputers.txtModSB.Text & "' " &
                " WHERE id =" & sSID

        DB7.Execute(sSQL)

        sSQL = "UPDATE kompy SET " &
            "USB_NAME='" & frmComputers.cmbUSB.Text & "'," &
            "USB_SN='" & frmComputers.txtUSBSN.Text & "'," &
            "USB_PROIZV='" & frmComputers.PROizV41.Text & "' " &
                " WHERE id =" & sSID

        DB7.Execute(sSQL)

        sSQL = "UPDATE kompy SET " &
            "PCI_NAME='" & frmComputers.cmbPCI.Text & "'," &
            "PCI_SN='" & frmComputers.txtSNPCI.Text & "'," &
            "PCI_PROIZV='" & frmComputers.PROizV42.Text & "' " &
                " WHERE id =" & sSID

        DB7.Execute(sSQL)

        sSQL = "UPDATE kompy SET " &
            "MONITOR_NAME='" & frmComputers.cmbMon1.Text & "'," &
            "MONITOR_DUM='" & frmComputers.txtMon1Dum.Text & "'," &
            "MONITOR_SN='" & frmComputers.txtMon1SN.Text & "'," &
            "MONITOR_PROIZV='" & frmComputers.PROizV28.Text & "'," &
            "MONITOR_NAME2='" & frmComputers.cmbMon2.Text & "'," &
            "MONITOR_DUM2='" & frmComputers.txtMon2Dum.Text & "'," &
            "MONITOR_SN2='" & frmComputers.txtMon2SN.Text & "'," &
            "MONITOR_PROIZV2='" & frmComputers.PROizV29.Text & "' " &
                " WHERE id =" & sSID

        DB7.Execute(sSQL)

        sSQL = "UPDATE kompy SET " &
            "KEYBOARD_NAME='" & frmComputers.cmbKeyb.Text & "'," &
            "KEYBOARD_SN='" & frmComputers.txtKeybSN.Text & "'," &
            "KEYBOARD_PROIZV='" & frmComputers.PROizV30.Text & "' " &
                " WHERE id =" & sSID

        DB7.Execute(sSQL)

        sSQL = "UPDATE kompy SET " &
            "MOUSE_NAME='" & frmComputers.cmbMouse.Text & "'," &
            "MOUSE_SN='" & frmComputers.txtMouseSN.Text & "'," &
            "MOUSE_PROIZV='" & frmComputers.PROizV31.Text & "' " &
                " WHERE id =" & sSID

        DB7.Execute(sSQL)

        sSQL = "UPDATE kompy SET " &
            "AS_NAME='" & frmComputers.cmbAsist.Text & "'," &
            "AS_SN='" & frmComputers.txtAsistSN.Text & "'," &
            "AS_PROIZV='" & frmComputers.PROizV32.Text & "' " &
                " WHERE id =" & sSID

        DB7.Execute(sSQL)

        sSQL = "UPDATE kompy SET " &
            "FILTR_NAME='" & frmComputers.cmbFilter.Text & "'," &
            "FILTR_SN='" & frmComputers.txtFilterSN.Text & "'," &
            "FILTR_PROIZV='" & frmComputers.PROizV33.Text & "' " &
                " WHERE id =" & sSID

        DB7.Execute(sSQL)

        sSQL = "UPDATE kompy SET " &
            "IBP_NAME='" & frmComputers.cmbIBP.Text & "'," &
            "IBP_SN='" & frmComputers.txtSNIBP.Text & "'," &
            "IBP_PROIZV='" & frmComputers.PROizV43.Text & "' " &
                " WHERE id =" & sSID

        DB7.Execute(sSQL)

        sSQL = "UPDATE kompy SET " &
            "PRINTER_NAME_1='" & frmComputers.cmbPrinters1.Text & "'," &
            "PRINTER_SN_1='" & frmComputers.txtPrint1SN.Text & "'," &
            "PORT_1='" & frmComputers.txtPrint1Port.Text & "'," &
            "PRINTER_PROIZV_1='" & frmComputers.PROizV34.Text & "'," &
            "PRINTER_NAME_2='" & frmComputers.cmbPrinters2.Text & "'," &
            "PRINTER_SN_2='" & frmComputers.txtPrint2SN.Text & "'," &
            "PORT_2='" & frmComputers.txtPrint2Port.Text & "'," &
            "PRINTER_PROIZV_2='" & frmComputers.PROizV35.Text & "'," &
            "PRINTER_NAME_3='" & frmComputers.cmbPrinters3.Text & "'," &
            "PRINTER_SN_3='" & frmComputers.txtPrint3SN.Text & "'," &
            "PORT_3='" & frmComputers.txtPrint3Port.Text & "'," &
            "PRINTER_PROIZV_3='" & frmComputers.PROizV36.Text & "', " &
            "Garantia_Sist=" & frmComputers.rbSist.Checked &
                 " WHERE id =" & sSID

        DB7.Execute(sSQL)

        Call UPDATE_OPLATA(frmComputers.txtPCSfN.Text, frmComputers.txtPCcash.Text, frmComputers.txtPCSumm.Text, frmComputers.txtPCZay.Text, frmComputers.dtPCdataVvoda.Value, frmComputers.dtPCSFdate.Value, _chkPRNspis, _chkPRNNNb, frmComputers.dtSpisanie.Value, sSID)

        Select Case frmComputers.EDT

            Case False

                Dim objIniFile As New IniFile(PrPath & "base.ini")
                objIniFile.WriteString("general", "DK", frmComputers.sCOUNT)
                objIniFile.WriteString("general", "Default", 0)

            Case True

                sSQL = "SELECT count(*) as t_n FROM kompy where PCL=" & frmComputers.sCOUNT
                rs = New Recordset
                rs.Open(sSQL, DB7, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic)

                Dim sCON As String

                With rs
                    sCON = .Fields("t_n").Value
                End With
                rs.Close()
                rs = Nothing

                Select Case sCON

                    Case 0

                    Case Else

                        DB7.Execute("update kompy set OTvetstvennyj='" & frmComputers.cmbResponsible.Text & "', FILIAL='" &
                            frmComputers.cmbBranch.Text & "', mesto='" & frmComputers.cmbDepartment.Text & "', kabn='" &
                            frmComputers.cmbOffice.Text & "' WHERE PCL=" & frmComputers.sCOUNT)

                End Select

                Call SMENA_PCL(frmComputers.sCOUNT, frmComputers.cmbPCL.Text)

        End Select

        Select Case sSID

            Case ""
                sSID = frmComputers.sCOUNT
            Case 0
                sSID = frmComputers.sCOUNT
            Case Else

        End Select


        Select Case frmComputers.rbSist.Checked

            Case True

                SAVE_GARANT(frmComputers.sCOUNT, frmComputers.cmbPostav, frmComputers.dtGPr, frmComputers.dtGok)

        End Select

        'Сохраняем софт 
        Call SAVE_SOFT(frmComputers.lstSoftware, frmComputers.sCOUNT)
        Call SAVE_USERS(frmComputers.lstUsers, frmComputers.sCOUNT) 'esq 130713

        'Решаем что делать с деревом
        'Если массовое добавление то ничего
        Select Case frmComputers.MASSLOAD

            Case True

            Case False

                frmComputers.txtSNAME.BackColor = frmComputers.txtSBSN.BackColor
                frmComputers.txtPSEUDONIM.BackColor = frmComputers.txtSBSN.BackColor
                frmComputers.cmbBranch.BackColor = frmComputers.txtSBSN.BackColor

                'Если использовали драг-н-дроп то ничего не делаем
                Dim tmpName, tmpFil, tmpDep, tmpOff, tmpID As String
                tmpName = frmComputers.txtSNAME.Text
                tmpFil = frmComputers.cmbBranch.Text
                tmpDep = frmComputers.cmbDepartment.Text
                tmpOff = frmComputers.cmbOffice.Text
                tmpID = frmComputers.sCOUNT

                PRESAVE_TREE(frmComputers.cmbBranch, frmComputers.cmbDepartment, frmComputers.cmbOffice)

                Call UpdateTree(tmpName, "PC", tmpID, tmpFil, tmpDep, tmpOff)

        End Select

        Exit Sub
err_:
        MsgBox(Err.Description)
    End Sub

    Public Sub SAVE_SOFT(ByVal lstV As ListView, Optional ByVal sSID As Integer = 0)
        On Error Resume Next

        If sSID = 0 Then Exit Sub
        lstV.Visible = False

        Dim txtPROGRAM, txtVERSIA, txtPublisher, txtLICKEY, txtLICENCE, txtTIP As String

        Dim txtDateInstall, txtDate_OK As Date

        Dim intj As Integer

        ' A1 = 1
        Dim sSQL As String

        For intj = 0 To lstV.Items.Count - 2

            Select Case Len(lstV.Items(intj).SubItems(0).Text)

                Case 0

                Case Else

                    Select Case Len(lstV.Items(intj).SubItems(1).Text)

                        Case Is > 1

                            lstV.Items(intj).Selected = True
                            lstV.Items(intj).EnsureVisible()

                            If Len(lstV.Items(intj).Text) = 0 Then lstV.Items(intj).Text = 1
                            'Софт наименование
                            txtPROGRAM = lstV.Items(intj).SubItems(1).Text

                            Select Case Len(lstV.Items(intj).SubItems(2).Text)
                                Case 0
                                    txtVERSIA = ""
                                Case Else
                                    'Версия
                                    txtVERSIA = lstV.Items(intj).SubItems(2).Text
                            End Select

                            Select Case txtVERSIA
                                Case "<N/A>"
                                    txtVERSIA = ""
                                Case Else
                            End Select

                            Select Case Len(lstV.Items(intj).SubItems(3).Text)
                                Case 0
                                    txtLICKEY = ""
                                Case Else
                                    txtLICKEY = lstV.Items(intj).SubItems(3).Text
                            End Select

                            Select Case Len(lstV.Items(intj).SubItems(4).Text)
                                Case 0
                                    txtLICENCE = ""
                                Case Else
                                    txtLICENCE = lstV.Items(intj).SubItems(4).Text
                            End Select


                            Select Case Len(lstV.Items(intj).SubItems(5).Text)
                                Case 0
                                    txtDateInstall = ""
                                Case Else
                                    txtDateInstall = lstV.Items(intj).SubItems(5).Text
                            End Select

                            Select Case txtDateInstall
                                Case "<N/A>"
                                    txtDateInstall = ""
                                Case Else
                            End Select

                            Select Case Len(lstV.Items(intj).SubItems(6).Text)
                                Case 0
                                    txtDate_OK = ""
                                Case Else
                                    txtDate_OK = lstV.Items(intj).SubItems(6).Text
                            End Select

                            Dim strSimbol1, strSimbol2 As String

                            Select Case Len(lstV.Items(intj).SubItems(7).Text)
                                Case 0
                                    txtPublisher = "NoName"
                                Case Else

                                    txtPublisher = lstV.Items(intj).SubItems(7).Text

                                    strSimbol1 = "'" : strSimbol2 = "."
                                    txtPublisher = Replace(txtPublisher, strSimbol1, "")

                                    If Not (RSExists("PROYZV", "PROiZV", Trim(txtPublisher))) Then
                                        AddPr(Trim(txtPublisher))
                                    End If

                            End Select

                            Select Case Len(lstV.Items(intj).SubItems(8).Text)
                                Case 0
                                    txtTIP = ""
                                Case Else
                                    txtTIP = lstV.Items(intj).SubItems(8).Text
                            End Select

                            strSimbol1 = "'" : strSimbol2 = "."
                            txtPROGRAM = Replace(txtPROGRAM, strSimbol1, "")

                            If Not (RSExistsSoft(sSID, txtPROGRAM)) Then

                                sSQL = "INSERT INTO SOFT_INSTALL (Soft,VERS,t_lic,L_key,d_p,d_o,Publisher,TIP,Id_Comp) VALUES ('" & txtPROGRAM & "','" & txtVERSIA & "','" & txtLICENCE & "','" & txtLICKEY & "','" & txtDateInstall & "','" & txtDate_OK & "','" & txtPublisher & "','" & txtTIP & "'," & sSID & ")"
                                DB7.Execute(sSQL)

                                'esq ************************
                            Else

                                ' sSQL = "UPDATE SOFT_INSTALL SET NomerSoftKomp='" & intj + 1 & "' WHERE Id_Comp= " & sSID & " AND Soft='" & H1 & "'"
                                ' DB7.Execute(sSQL)

                                'esq ************************
                            End If

                        Case Else

                    End Select

            End Select

        Next

        'Костыль для MyODBC 5
        DB7.Execute("UPDATE SOFT_INSTALL SET Id_Comp=" & sSID & " WHERE Id_Comp='0'")

        lstV.Visible = True
    End Sub

    'esq 130713 сохраним пользователей
    Public Sub SAVE_USERS(ByVal lstV As ListView, Optional ByVal sSID As Integer = 0)
        On Error Resume Next

        If (EverestFilePatch <> "") Then ' только при импорте из эвереста

            If sSID = 0 Then Exit Sub
            lstV.Visible = False

            Dim B1, C1, I1, H1, spis As String
            Dim intj As Integer
            Dim rsUser As Recordset
            Dim sSQL As String

            spis = "\"
            For intj = 0 To lstV.Items.Count - 1

                If Len(lstV.Items(intj).SubItems(2).Text) > 0 Then
                    lstV.Items(intj).Selected = True
                    lstV.Items(intj).EnsureVisible()

                    H1 = lstV.Items(intj).SubItems(0).Text

                    If Len(lstV.Items(intj).Text) = 0 Then lstV.Items(intj).Text = 1

                    'FIO
                    If Len(lstV.Items(intj).SubItems(1).Text) = 0 Then
                        B1 = ""
                    Else
                        B1 = lstV.Items(intj).SubItems(1).Text
                    End If

                    ' User_Name
                    If Len(lstV.Items(intj).SubItems(2).Text) = 0 Then
                        C1 = ""
                    Else
                        C1 = lstV.Items(intj).SubItems(2).Text
                    End If

                    'ID_COMP
                    I1 = sSID

                    spis = spis + C1 + "\"

                    If (Len(C1) > 0) And (H1 = 0) Then

                        sSQL = "INSERT INTO USER_COMP (ID_COMP,User_Name,FIO) VALUES ('" & I1 & "','" & C1 & "','" & B1 & "')"

                        DB7.Execute(sSQL)


                        Dim UserExist As Boolean
                        sSQL = "SELECT COUNT(*) AS total_number FROM SPR_USER WHERE name='" & C1 & "' AND A='" & B1 & "'"
                        rsUser = New Recordset
                        rsUser.Open(sSQL, DB7, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic)

                        If rsUser.Fields("total_number").Value = 0 Then
                            UserExist = False
                        Else
                            UserExist = True
                        End If

                        rsUser.Close()
                        rsUser = Nothing

                        If UserExist = False Then

                            sSQL = "INSERT INTO SPR_USER (name,A) VALUES ('" & C1 & "','" & B1 & "')"

                            DB7.Execute(sSQL)

                            frmComputers.txtUserName.Items.Add(C1)
                            If B1 <> "" Then frmComputers.txtUserFIO.Items.Add(B1)
                        End If
                    End If
                End If
            Next

            sSQL = "SELECT * FROM USER_COMP WHERE ID_COMP=" & sSID
            rsUser = New Recordset
            rsUser.Open(sSQL, DB7, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic)
            rsUser.MoveFirst()
            Do While Not rsUser.EOF
                If InStr(spis, "\" & Trim(rsUser.Fields("User_Name").Value) & "\") = 0 Then
                    rsUser.Delete()
                End If
                rsUser.MoveNext()
            Loop
            rsUser.Close()
            rsUser = Nothing

            lstV.Visible = True
            Dim langfile As New IniFile(sLANGPATH)
            frmComputers.cmdUserAdd.Text = langfile.GetString("frmComputers", "MSG30", "Добавить")
            LOAD_USER(frmComputers.sCOUNT)
        End If
        EverestFilePatch = "" ' чтобы не повторять
    End Sub 'esq 130713 сохраним пользователей

    Public Sub User_Comp_ADD()
        On Error GoTo err_

        Dim langfile As New IniFile(sLANGPATH)

        If frmComputers.sCOUNT = 0 Then Exit Sub
        Dim Us1 As String
        Dim Us2 As String

        'esq 130713 импорт юзеров
        If frmComputers.cmdUserAdd.Text = langfile.GetString("frmComputers", "MSG54", "Изменить") Then
            frmComputers.lstUsers.SelectedItems(0).SubItems(2).Text = frmComputers.txtUserName.Text
            frmComputers.lstUsers.SelectedItems(0).SubItems(1).Text = frmComputers.txtUserFIO.Text
            If frmComputers.txtUserName.FindString(frmComputers.txtUserName.Text) < 0 Then
                frmComputers.txtUserName.Items.Add(frmComputers.txtUserName.Text)
            End If
            If frmComputers.txtUserFIO.FindString(frmComputers.txtUserFIO.Text) < 0 Then
                frmComputers.txtUserFIO.Items.Add(frmComputers.txtUserFIO.Text)
            End If
            Exit Sub
        End If 'esq 130713 импорт юзеров

        If frmComputers.cmdUserAdd.Text = langfile.GetString("frmComputers", "MSG42", "Сохранить") Then

            Dim USERCOMP As Recordset
            USERCOMP = New Recordset
            USERCOMP.Open("SELECT * FROM USER_COMP WHERE id=" & frmComputers.uCOUNT, DB7, CursorTypeEnum.adOpenDynamic,
                          LockTypeEnum.adLockOptimistic)

            With USERCOMP
                If Not IsDBNull(.Fields("PASSWORD")) Then Us1 = .Fields("PASSWORD").Value
                If Not IsDBNull(.Fields("EPASS")) Then Us2 = .Fields("EPASS").Value
            End With
            USERCOMP.Close()
            USERCOMP = Nothing

        End If

        Dim sSQL As String
       

        If frmComputers.cmdUserAdd.Text = langfile.GetString("frmComputers", "MSG30", "Добавить") Then
            Call _
                SaveActivityToLogDB(
                    langfile.GetString("frmComputers", "MSG48", "Добавление пользователя на компьютере") & " " &
                    frmComputers.lstGroups.SelectedNode.Text)
            sSQL = "Select * from USER_COMP"
        Else
            Call _
                SaveActivityToLogDB(
                    langfile.GetString("frmComputers", "MSG49", "Редактирование пользователя на компьютере") & " " &
                    frmComputers.lstGroups.SelectedNode.Text)
            sSQL = "Select * from USER_COMP WHERE id =" & frmComputers.uCOUNT
        End If


        Dim rs As Recordset
        rs = New Recordset
        rs.Open(sSQL, DB7, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic)

        With rs

            Select Case frmComputers.cmdUserAdd.Text

                Case langfile.GetString("frmComputers", "MSG42", "Сохранить")

                    If Us1 = frmComputers.txtUserPass.Text Or Us1 = Nothing Then

                    Else
                        strPassword = frmComputers.txtUserPass.Text
                        EncryptDecrypt(strPassword)
                        .Fields("PASSWORD").Value = Temp$
                    End If

                    If Us2 = frmComputers.txtUserEmailPwd.Text Or Us2 = Nothing Then

                    Else
                        strPassword = frmComputers.txtUserEmailPwd.Text
                        EncryptDecrypt(strPassword)
                        .Fields("EPASS").Value = Temp$
                    End If

                Case Else

                    .AddNew()
                    strPassword = Trim(frmComputers.txtUserEmailPwd.Text)
                    Call EncryptDecrypt(strPassword)
                    frmComputers.txtUserEmailPwd.Text = Temp$

                    strPassword = Trim(frmComputers.txtUserPass.Text)
                    Call EncryptDecrypt(strPassword)
                    frmComputers.txtUserPass.Text = Temp$

                    .Fields("PASSWORD").Value = frmComputers.txtUserPass.Text
                    .Fields("EPASS").Value = frmComputers.txtUserEmailPwd.Text

            End Select

            .Fields("Id_Comp").Value = frmComputers.sCOUNT
            .Fields("UserName").Value = frmComputers.txtUserName.Text
            .Fields("EMAIL").Value = frmComputers.txtUserEmail.Text
            .Fields("FIO").Value = frmComputers.txtUserFIO.Text
            .Fields("icq").Value = frmComputers.txtUserIcq.Text
            .Fields("jabber").Value = frmComputers.txtUserJab.Text
            .Fields("MEMO").Value = frmComputers.txtUMEMO.Text


            If frmComputers.ChkPDC.Checked = False Then
                .Fields("PDC").Value = 0
            Else
                .Fields("PDC").Value = 1
            End If

            .Update()
        End With


        rs.Close()
        rs = Nothing

        If Not RSExists("USER", "name", Trim(frmComputers.txtUserName.Text)) Then


            rs = New Recordset

            rs.Open("Select * from SPR_USER ", DB7, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic)

            With rs
                .AddNew()
                .Fields("name").Value = frmComputers.txtUserName.Text
                .Fields("A").Value = frmComputers.txtUserFIO.Text
                .Update()
            End With
            rs.Close()
            rs = Nothing

            frmComputers.txtUserName.Items.Add(frmComputers.txtUserName.Text)

        End If

        FillComboNET(frmComputers.txtUserName, "Name", "SPR_USER", "", False, True) 'esq 130713
        FillComboNET(frmComputers.txtUserFIO, "A", "SPR_USER", "", False, True) 'esq 130713

        frmComputers.cmdUserAdd.Text = langfile.GetString("frmComputers", "MSG30", "Добавить")

        frmComputers.txtUserName.Text = ""
        frmComputers.txtUserPass.Text = ""
        frmComputers.txtUserEmail.Text = ""
        frmComputers.txtUserEmailPwd.Text = ""
        frmComputers.txtUserFIO.Text = ""
        frmComputers.txtUserIcq.Text = ""
        frmComputers.txtUMeMo.Text = ""

        LOAD_USER(frmComputers.sCOUNT)

        Exit Sub
err_:
        MsgBox(Err.Description, MsgBoxStyle.Exclamation, ProGramName)
    End Sub

    Public Sub Save_P(Optional ByVal sSID As String = "")

        On Error GoTo Err_

        Select Case Len(frmComputers.cmbPRNDepart.Text)

            Case 0

                Select Case Len(frmComputers.cmbPRNOffice.Text)

                    Case 0

                    Case Else
                        MsgBox("Заполните поле 'Отдел' или удалите значение поля 'Кабинет' ", MsgBoxStyle.Exclamation, ProGramName)
                        Exit Sub

                End Select

            Case Else

        End Select

        If Len(frmComputers.cmbPRN.Text) = 0 Or Len(frmComputers.cmbPRNFil.Text) = 0 Then

            MsgBox("Не заполнены обязательные поля", MsgBoxStyle.Information, ProGramName)

            If Len(frmComputers.cmbPRN.Text) = 0 Then frmComputers.cmbPRN.BackColor = Color.Red
            If Len(frmComputers.cmbPRNFil.Text) = 0 Then frmComputers.cmbPRNFil.BackColor = Color.Red

            frmComputers.sSTAB2.SelectedTab = frmComputers.sSTAB3.TabPages("TabPage9")
            Exit Sub
        End If

        Select Case frmComputers.EDT

            Case True
                Call SMENA_PCL(frmComputers.sCOUNT, frmComputers.cmbPCL.Text)

                Call DVIG_TEHN(frmComputers.cmbPRNFil.Text, frmComputers.cmbPRNDepart.Text, frmComputers.cmbPRNOffice.Text, frmComputers.cmbPRN.Text, frmComputers.cmbPCL.Text)

                Select Case DV

                    Case True

                    Case False

                        Select Case Sav

                            Case False
                                MsgBox("Отмена перемещения", MsgBoxStyle.Exclamation, ProGramName)
                                Exit Sub
                        End Select

                End Select

        End Select

        ' esq 151026 картриждж и формат: обновление
        Dim sSPRAV As String
        Dim pSQL As String
        'Dim rs1 As Recordset
        If RSExists("MFU", "name", Trim(frmComputers.cmbPRN.Text)) Then
            sSPRAV = "SPR_MFU"
        End If
        If RSExists("PRINTERY", "name", Trim(frmComputers.cmbPRN.Text)) Then
            sSPRAV = "SPR_PRINTER"
        End If
        If RSExists("KOPIRY", "name", Trim(frmComputers.cmbPRN.Text)) Then
            sSPRAV = "SPR_KOPIR"
        End If
        pSQL = "UPDATE " & sSPRAV & " SET A='" & frmComputers.cmbFormat.Text & "', B='" & frmComputers.cmbModCartr.Text &
                "' WHERE Name ='" & Trim(frmComputers.cmbPRN.Text) & "'"
        DB7.Execute(pSQL)

        If (RSExists("CARTR", "name", frmComputers.cmbModCartr.Text)) Then
            pSQL = "UPDATE spr_cart SET A='" & frmComputers.cmbTIPCartridg.Text & "' WHERE Name ='" & Trim(frmComputers.cmbModCartr.Text) & "'"
            DB7.Execute(pSQL)
        End If
        ' esq 151026

        If Not (RSExists("CARTR", "name", frmComputers.cmbModCartr.Text)) Then
            AddTreePar(frmComputers.cmbModCartr.Text, frmComputers.cmbTIPCartridg.Text, frmComputers.PROiZV38.Text, "spr_cart", frmComputers.cmbModCartr) ' esq 151026
        End If

        Select Case TipTehn

            Case "MFU"
                If Not (RSExists("MFU", "name", frmComputers.cmbPRN.Text)) Then
                    AddFOwPar(frmComputers.cmbPRN.Text, frmComputers.cmbFormat.Text, frmComputers.cmbModCartr.Text,
                              frmComputers.PROiZV38.Text, "SPR_MFU", frmComputers.cmbPRN)
                End If

            Case "Printer"

                If Not (RSExists("PRINTERY", "name", frmComputers.cmbPRN.Text)) Then
                    AddFOwPar(frmComputers.cmbPRN.Text, frmComputers.cmbFormat.Text, frmComputers.cmbModCartr.Text,
                              frmComputers.PROiZV38.Text, "SPR_PRINTER", frmComputers.cmbPRN)
                End If

            Case "KOpir"

                If Not (RSExists("KOPIRY", "name", frmComputers.cmbPRN.Text)) Then
                    AddFOwPar(frmComputers.cmbPRN.Text, frmComputers.cmbFormat.Text, frmComputers.cmbModCartr.Text,
                              frmComputers.PROiZV38.Text, "SPR_KOPIR", frmComputers.cmbPRN)
                End If

        End Select

        If Not (RSExists("otv", "name", Trim(frmComputers.cmbPRNotv.Text))) Then
            AddOnePar(frmComputers.cmbPRNotv.Text, "NAME", "SPR_OTV", frmComputers.cmbPRNotv)
        End If

        Dim rs As Recordset
        Dim unaPCL As String
        If Len(frmComputers.cmbPCL.Text) <> 0 Then

            On Error GoTo sAR

            rs = New Recordset
            'rs.Open("Select id From kompy where filial='" & frmComputers.cmbPRNFil.Text & "' and mesto='" & frmComputers.cmbPRNDepart.Text & "' and kabn='" & frmComputers.cmbPRNOffice.Text & "' and TipTehn='PC' and NET_NAME='" & frmComputers.cmbPCL.Text & "'", DB7, ADODB.CursorTypeEnum.adOpenDynamic, ADODB.LockTypeEnum.adLockOptimistic)
            rs.Open(
                "Select id From kompy where filial='" & frmComputers.cmbPRNFil.Text & "' and mesto='" &
                frmComputers.cmbPRNDepart.Text & "' and kabn='" & frmComputers.cmbPRNOffice.Text & "' and NET_NAME='" &
                frmComputers.cmbPCL.Text & "'", DB7, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic)

            With rs

                unaPCL = .Fields("id").Value

            End With
            rs.Close()
            rs = Nothing
        End If

sAR:
        If Len(unaPCL) = 0 Or unaPCL = Nothing Then unaPCL = 0

        On Error GoTo Err_

        Dim _chkPRNspis As Integer
        Dim _chkPRNNNb As Integer
        If Len(frmComputers.txtPRNSfN.Text) = 0 Then frmComputers.txtPRNSfN.Text = 0
        If Len(frmComputers.txtPRNcash.Text) = 0 Then frmComputers.txtPRNcash.Text = 0
        If Len(frmComputers.txtPRNSUMM.Text) = 0 Then frmComputers.txtPRNSUMM.Text = 0
        If frmComputers.chkPRNspis.Checked = False Then _chkPRNspis = 0 Else _chkPRNspis = 1
        If frmComputers.chkPRNNNb.Checked = False Then _chkPRNNNb = 0 Else _chkPRNNNb = 1


        Dim sSQL As String

        Select Case frmComputers.EDT

            Case False

                sSQL = "INSERT INTO kompy (PRINTER_NAME_1,PRINTER_SN_1,Ser_N_SIS,PRINTER_PROIZV_1,port_1," &
                    "INV_NO_PRINTER,TIPtehn,PCL,D_T,os,NET_IP_1,NET_MAC_1,port_2) VALUES ('" &
                    frmComputers.cmbPRN.Text & "','" &
                    frmComputers.txtPRNSN.Text & "','" &
                    frmComputers.txtPRNSN.Text & "','" &
                    frmComputers.PROiZV38.Text & "','" &
                    frmComputers.cmbFormat.Text & "','" &
                    frmComputers.txtPRNinnumber.Text & "','" &
                    TipTehn & "'," &
                    unaPCL & ",'" &
                    Date.Today & "','" &
                    frmComputers.cmbModCartr.Text & "','" &
                    frmComputers.txtPrnIP.Text & "','" &
                    frmComputers.txtPRNMAC.Text & "','" &
                    frmComputers.cmbPRNConnect.Text & "')"

            Case True

                sSQL = "UPDATE kompy SET PRINTER_NAME_1='" & frmComputers.cmbPRN.Text & "', PRINTER_SN_1='" &
                    frmComputers.txtPRNSN.Text & "', Ser_N_SIS='" & frmComputers.txtPRNSN.Text & "', PRINTER_PROIZV_1='" &
                    frmComputers.PROiZV38.Text & "', port_1='" & frmComputers.cmbFormat.Text & "', INV_NO_PRINTER='" &
                    frmComputers.txtPRNinnumber.Text & "', PCL=" & unaPCL & ", os='" & frmComputers.cmbModCartr.Text &
                    "', NET_IP_1='" & frmComputers.txtPrnIP.Text & "',NET_MAC_1='" & frmComputers.txtPRNMAC.Text &
                    "',port_2='" & frmComputers.cmbPRNConnect.Text & "' WHERE id =" & sSID

        End Select

        DB7.Execute(sSQL)

        Select Case frmComputers.EDT

            Case False

                Select Case DB_N

                    Case "DSN"
                        sSQL = "Select id from kompy ORDER BY id DESC LIMIT 1"
                    Case "PostgreSQL"
                        sSQL = "Select id from kompy ORDER BY id DESC LIMIT 1"

                    Case "MySQL"

                        sSQL = "Select id from kompy ORDER BY id DESC LIMIT 1"

                    Case Else

                        sSQL = "Select top 1 id from kompy ORDER BY id DESC"

                End Select

                rs = New Recordset
                rs.Open(sSQL, DB7, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic)
                frmComputers.sCOUNT = rs.Fields("ID").Value
                rs.Close()
                rs = Nothing

                Dim objIniFile As New IniFile(PrPath & "base.ini")
                objIniFile.WriteString("general", "DK", frmComputers.sCOUNT)
                objIniFile.WriteString("general", "Default", 0)

            Case True

        End Select

        If Len(sSID) = 0 Then
            sSID = frmComputers.sCOUNT
        End If

        Call UPDATE_INFORMARION(frmComputers.cmbPRNFil.Text, frmComputers.cmbPRNDepart.Text, frmComputers.cmbPRNOffice.Text, frmComputers.txtPRNphone.Text, frmComputers.cmbPRN.Text, frmComputers.cmbPRN.Text, frmComputers.cmbPRNotv.Text, sSID)
        Call UPDATE_OPLATA(frmComputers.txtPRNSfN.Text, frmComputers.txtPRNcash.Text, frmComputers.txtPRNSUMM.Text, frmComputers.txtPRNZay.Text, frmComputers.dtPRNdataVvoda.Value, frmComputers.dtPRNSFdate.Value, _chkPRNspis, _chkPRNNNb, frmComputers.dtPRNSpisanie.Value, sSID)
        Call SAVE_GARANT(sSID, frmComputers.cmbPRNPostav, frmComputers.dtGPRNPr, frmComputers.dtGPRNok)

        frmComputers.cmbPRN.BackColor = frmComputers.cmbPRN.BackColor
        frmComputers.cmbPRNFil.BackColor = frmComputers.cmbPRNFil.BackColor

        Dim tmpName, tmpFil, tmpDep, tmpOff, tmpID, tmpTip As String
        tmpName = frmComputers.cmbPRN.Text
        tmpFil = frmComputers.cmbPRNFil.Text
        tmpDep = frmComputers.cmbPRNDepart.Text
        tmpOff = frmComputers.cmbPRNOffice.Text
        tmpID = frmComputers.sCOUNT
        tmpTip = TipTehn

        PRESAVE_TREE(frmComputers.cmbPRNFil, frmComputers.cmbPRNDepart, frmComputers.cmbPRNOffice)

        Call UpdateTree(tmpName, tmpTip, tmpID, tmpFil, tmpDep, tmpOff)

        Exit Sub
Err_:
        MsgBox(Err.Description)
    End Sub

    Public Sub Save_NET(Optional ByVal sSID As String = "")

        On Error Resume Next

        On Error GoTo err_


        Select Case Len(frmComputers.cmbNetDepart.Text)

            Case 0

                Select Case Len(frmComputers.cmbNETOffice.Text)

                    Case 0

                    Case Else
                        MsgBox("Заполните поле 'Отдел' или удалите значение поля 'Кабинет' ", MsgBoxStyle.Exclamation, ProGramName)
                        Exit Sub

                End Select

            Case Else

        End Select

        If Len(frmComputers.cmbDevNet.Text) = 0 Or Len(frmComputers.cmbNETBranch.Text) = 0 Then

            MsgBox("Не заполнены обязательные поля", MsgBoxStyle.Information, ProGramName)

            If Len(frmComputers.cmbDevNet.Text) = 0 Then frmComputers.cmbDevNet.BackColor = Color.Red
            If Len(frmComputers.cmbNETBranch.Text) = 0 Then frmComputers.cmbNETBranch.BackColor = Color.Red
            frmComputers.sSTAB4.SelectedTab = frmComputers.sSTAB4.TabPages("TabPage1")
            Exit Sub

        End If

        Select Case frmComputers.EDT

            Case True
                Call SMENA_PCL(frmComputers.sCOUNT, frmComputers.cmbCNTNet.Text)

                Call DVIG_TEHN(frmComputers.cmbNETBranch.Text, frmComputers.cmbNetDepart.Text, frmComputers.cmbNETOffice.Text, frmComputers.cmbDevNet.Text, frmComputers.cmbCNTNet.Text)

                Select Case DV

                    Case True

                    Case False

                        Select Case Sav

                            Case False
                                MsgBox("Отмена перемещения", MsgBoxStyle.Exclamation, ProGramName)
                                Exit Sub
                        End Select

                End Select

        End Select

        Dim rs As Recordset

        Dim unaPCL As String
        If Len(frmComputers.cmbCNTNet.Text) <> 0 Then
            On Error GoTo sAR

            rs = New Recordset
            rs.Open(
                "Select id From kompy where filial='" & frmComputers.cmbNETBranch.Text & "' and mesto='" &
                frmComputers.cmbNetDepart.Text & "' and kabn='" & frmComputers.cmbNETOffice.Text & "' and NET_NAME='" &
                frmComputers.cmbCNTNet.Text & "'", DB7, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic)

            With rs
                unaPCL = .Fields("id").Value
            End With
            rs.Close()
            rs = Nothing

        End If

sAR:
        If Len(unaPCL) = 0 Or unaPCL = Nothing Then unaPCL = 0

        Dim sSQL As String 'Переменная, где будет размещён SQL запрос

        If Not (RSExists("otv", "name", Trim(frmComputers.cmbNETotv.Text))) Then
            AddOnePar(frmComputers.cmbNETotv.Text, "NAME", "SPR_OTV", frmComputers.cmbNETotv)
        End If

        If Not (RSExists("DNDEV", "name", frmComputers.cmbNetDev.Text)) Then
            AddOnePar(frmComputers.cmbNetDev.Text, "NAME", "SPR_NET_DEV", frmComputers.cmbNetDev)
        End If

        If Not (RSExists("NDEV", "name", frmComputers.cmbDevNet.Text)) Then
            AddFOwPar(frmComputers.cmbDevNet.Text, frmComputers.cmbNetDev.Text, frmComputers.txtNetPort.Text,
                      frmComputers.PROiZV40.Text, "SPR_DEV_NET", frmComputers.cmbCPU2)
        End If

        If Len(frmComputers.txtNETSfN.Text) = 0 Then frmComputers.txtNETSfN.Text = 0
        If Len(frmComputers.txtNETcash.Text) = 0 Then frmComputers.txtNETcash.Text = 0
        If Len(frmComputers.txtNETSUMM.Text) = 0 Then frmComputers.txtNETSUMM.Text = 0

        Dim _chkPRNspis As Integer
        Dim _chkPRNNNb As Integer

        If frmComputers.chkNETspis.Checked = False Then _chkPRNspis = 0 Else _chkPRNspis = 1
        If frmComputers.chkNETNNb.Checked = False Then _chkPRNNNb = 0 Else _chkPRNNNb = 1

        Dim strSimbol1, strSimbol2 As String
        strSimbol1 = "'" : strSimbol2 = "."

        frmComputers.txtNetIsp.Text = Replace(frmComputers.txtNetIsp.Text, strSimbol1, "")

        Select Case frmComputers.EDT

            Case False

                sSQL = "INSERT INTO kompy (PRINTER_NAME_1,PRINTER_SN_1,PRINTER_PROIZV_1,NET_IP_1,NET_MAC_1,PRINTER_SN_2,PRINTER_PROIZV_3,PRINTER_SN_3,PRINTER_NAME_4,PRINTER_PROIZV_4,PRINTER_SN_4," &
                        "port_2,port_1,Ser_N_SIS,TIPtehn,PCL) VALUES ('" &
                        frmComputers.cmbNetDev.Text & "','" &
                        frmComputers.cmbDevNet.Text & "','" &
                        frmComputers.PROiZV40.Text & "','" &
                        frmComputers.txtNetIP.Text & "','" &
                        frmComputers.txtNetMac.Text & "','" &
                        frmComputers.txtNetPort.Text & "','" &
                        frmComputers.txtNetINN.Text & "','" &
                        frmComputers.txtNetIsp.Text & "','" &
                        frmComputers.cmbNetVkl.Text & "','" &
                        frmComputers.cmbNetCable.Text & "','" &
                        frmComputers.txtNetCableCat.Text & "','" &
                        frmComputers.txtNetNumberPorts.Text & "','" &
                        frmComputers.txtNetSN.Text & "','" &
                        frmComputers.txtNetSN.Text & "','" &
                        TipTehn & "'," & unaPCL & ")"

            Case True

                sSQL = "UPDATE kompy SET " &
                        "PRINTER_NAME_1='" & frmComputers.cmbNetDev.Text & "'," &
                        "PRINTER_SN_1='" & frmComputers.cmbDevNet.Text & "'," & "PRINTER_PROIZV_1='" & frmComputers.PROiZV40.Text & "'," &
                        "NET_IP_1='" & frmComputers.txtNetIP.Text & "'," & "NET_MAC_1='" & frmComputers.txtNetMac.Text & "'," &
                        "PRINTER_SN_2='" & frmComputers.txtNetPort.Text & "'," & "PRINTER_PROIZV_3='" & frmComputers.txtNetINN.Text & "'," &
                        "PRINTER_SN_3='" & frmComputers.txtNetIsp.Text & "'," & "PRINTER_NAME_4='" & frmComputers.cmbNetVkl.Text & "'," &
                        "PRINTER_PROIZV_4='" & frmComputers.cmbNetCable.Text & "'," & "PRINTER_SN_4='" & frmComputers.txtNetCableCat.Text & "'," &
                        "port_2='" & frmComputers.txtNetNumberPorts.Text & "'," &
                        "port_1='" & frmComputers.txtNetSN.Text & "'," & "Ser_N_SIS='" & frmComputers.txtNetSN.Text & "'," &
                        "TIPtehn='" & TipTehn & "'," & "PCL=" & unaPCL & " WHERE id =" & sSID

        End Select

        DB7.Execute(sSQL)

        Select Case frmComputers.EDT

            Case False

                Select Case DB_N

                    Case "DSN"
                        sSQL = "Select id from kompy ORDER BY id DESC LIMIT 1"
                    Case "PostgreSQL"
                        sSQL = "Select id from kompy ORDER BY id DESC LIMIT 1"

                    Case "MySQL"

                        sSQL = "Select id from kompy ORDER BY id DESC LIMIT 1"

                    Case Else

                        sSQL = "Select top 1 id from kompy ORDER BY id DESC"

                End Select

                rs = New Recordset
                rs.Open(sSQL, DB7, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic)
                frmComputers.sCOUNT = rs.Fields("ID").Value
                rs.Close()
                rs = Nothing

                Dim objIniFile As New IniFile(PrPath & "base.ini")
                objIniFile.WriteString("general", "DK", frmComputers.sCOUNT)
                objIniFile.WriteString("general", "Default", 0)


        End Select

        If Len(sSID) = 0 Then
            sSID = frmComputers.sCOUNT
        End If

        Call UPDATE_INFORMARION(frmComputers.cmbNETBranch.Text, frmComputers.cmbNetDepart.Text, frmComputers.cmbNETOffice.Text, frmComputers.txtNETphone.Text, frmComputers.cmbDevNet.Text, frmComputers.cmbNetDev.Text, frmComputers.cmbNETotv.Text, sSID)
        Call UPDATE_OPLATA(frmComputers.txtNETSfN.Text, frmComputers.txtNETcash.Text, frmComputers.txtNETSUMM.Text, frmComputers.txtNETZay.Text, frmComputers.dtNETdataVvoda.Value, frmComputers.dtNETSFdate.Value, _chkPRNspis, _chkPRNNNb, frmComputers.dtNETSpisanie.Value, sSID)
        Call SAVE_GARANT(sSID, frmComputers.cmbNETPostav, frmComputers.dtGNETPr, frmComputers.dtGNETok)

        frmComputers.cmbDevNet.BackColor = frmComputers.txtSBSN.BackColor
        frmComputers.cmbNETBranch.BackColor = frmComputers.txtSBSN.BackColor

        Dim tmpName, tmpFil, tmpDep, tmpOff, tmpID, tmpTip As String
        tmpName = frmComputers.cmbDevNet.Text
        tmpFil = frmComputers.cmbNETBranch.Text
        tmpDep = frmComputers.cmbNetDepart.Text
        tmpOff = frmComputers.cmbNETOffice.Text
        tmpID = frmComputers.sCOUNT
        tmpTip = TipTehn

        PRESAVE_TREE(frmComputers.cmbNETBranch, frmComputers.cmbNetDepart, frmComputers.cmbNETOffice)

        Call UpdateTree(tmpName, tmpTip, tmpID, tmpFil, tmpDep, tmpOff)


        Exit Sub
err_:
        MsgBox(Err.Description)
    End Sub

    Private Sub DVIG_TEHN(ByVal sFIALIAL As String, ByVal sOTDEL As String, ByVal sKABN As String, ByVal sNAMEs As String, Optional ByVal pcl_txt As String = "")
        On Error GoTo Error_
        Dim rs As Recordset
        Dim Message, Title, Defaults As String
        Dim strTmp As String
        Dim sTmp As DateTime = DateTime.Now
        Dim tNAME As Integer = 0
        Dim tNAME2 As Integer = 0
        Dim tNAME2s As String = ""
        'sNAMEs - переданное имя 

        On Error Resume Next
        'Проверяем контейнер

        rs = New Recordset
        rs.Open("SELECT id FROM kompy where NET_NAME ='" & pcl_txt & "' AND filial='" & sFIALIAL & "' AND mesto='" & sOTDEL & "' AND kabn='" & sKABN & "'", DB7, CursorTypeEnum.adOpenDynamic,
                LockTypeEnum.adLockOptimistic)

        With rs

            tNAME = .Fields("id").Value

        End With
        rs.Close()
        rs = Nothing

        rs = New Recordset
        rs.Open("SELECT pcl FROM kompy where id =" & frmComputers.sCOUNT, DB7, CursorTypeEnum.adOpenDynamic,
                LockTypeEnum.adLockOptimistic)

        Dim rs1 As Recordset

        rs1 = New Recordset
        rs1.Open("SELECT NET_NAME FROM kompy where id =" & rs.Fields("pcl").Value, DB7, CursorTypeEnum.adOpenDynamic,
                LockTypeEnum.adLockOptimistic)


        With rs1
            tNAME2s = .Fields("NET_NAME").Value
        End With
        rs1.Close()
        rs1 = Nothing
        rs.Close()
        rs = Nothing



        'Проверяем место

        Dim iA, iB, iC As String

        If Len(sName) = 0 Then

        Else

            If sName <> sNAMEs And frmComputers.EDT = True Then


                DB7.Execute("update Remont set Comp_Name ='" & sNAMEs &
                        "', Mesto_Compa ='" & sBranch & "/" & sDepartment &
                        "' WHERE Id_Comp=" & frmComputers.sCOUNT)

                'rs = New Recordset
                'rs.Open("update Remont set Comp_Name ='" & sNAMEs &
                '        "', Mesto_Compa ='" & sBranch & "/" & sDepartment &
                '        "' WHERE Id_Comp=" & frmComputers.sCOUNT, DB7, CursorTypeEnum.adOpenDynamic,
                '        LockTypeEnum.adLockOptimistic)
                'rs = Nothing

            Else

            End If

        End If

        Select Case frmComputers.EDT

            Case True

                DV = True

                rs = New Recordset
                rs.Open("SELECT filial,mesto,kabn FROM kompy where id =" & frmComputers.sCOUNT, DB7, CursorTypeEnum.adOpenDynamic,
                        LockTypeEnum.adLockOptimistic)

                With rs
                    iA = .Fields("filial").Value
                    iB = .Fields("mesto").Value
                    iC = .Fields("kabn").Value
                End With
                rs.Close()
                rs = Nothing


                If iB <> sOTDEL Or iA <> sFIALIAL Or iC <> sKABN Or pcl_txt <> tNAME2s Then

                    DV = False

                    Message = "Укажите причину перемещения техники"
                    Title = "Перемещение техники"
                    Defaults = "Причина"
                    strTmp = InputBox(Message, Title, Defaults)

                    Select Case strTmp

                        Case ""
                            Sav = False

                            Exit Sub
                        Case Else
                            Sav = True

                    End Select

                    '                    sTmp = (DateTime.Now.Hour & ":" & DateTime.Now.Minute & ":" & DateTime.Now.Second)

                    If Len(iB) <> 0 Then iA = iA & "/" & iB
                    If Len(iC) <> 0 Then iA = iA & "/" & iC

                    If Len(sOTDEL) <> 0 Then sFIALIAL = sFIALIAL & "/" & sOTDEL
                    If Len(sKABN) <> 0 Then sFIALIAL = sFIALIAL & "/" & sKABN


                    If pcl_txt <> tNAME2s Then iA = iA & "/" & tNAME2s
                    If pcl_txt <> tNAME2s Then sFIALIAL = sFIALIAL & "/" & pcl_txt


                    Dim sSQL As String
                    sSQL = "INSERT INTO dvig (id_comp,oldMesto,NewMesto,prich,D_T,T_M) VALUES (" & frmComputers.sCOUNT & ",'" & iA & "','" & sFIALIAL & "','" & strTmp & "','" & Date.Today & "','" & sTmp.ToLongTimeString & "')"

                    DB7.Execute(sSQL)

                    'rs = New Recordset
                    'rs.Open(sSQL, DB7, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic)
                    'rs = Nothing

                    'Call SaveActivityToLogDB("Перемещение техники " & frmComputers.SelNde.Text & " из " & frmComputers.FilD & "/" & frmComputers.OtdD & " в " & sfilial & "/" & sOTDEL)

                    Dim langfile As New IniFile(sLANGPATH)
                    Call _
                        SaveActivityToLogDB(
                            langfile.GetString("frmComputers", "MSG52", "Перемещение техники") & " " &
                            frmComputers.lstGroups.SelectedNode.Text)

                    rs = New Recordset
                    rs.Open("SELECT count(*) as t_n FROM kompy where PCL=" & frmComputers.sCOUNT, DB7,
                            CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic)

                    Dim sCN As String

                    With rs
                        sCN = .Fields("t_n").Value
                    End With
                    rs.Close()
                    rs = Nothing

                    DV2 = True

                    Select Case sCN

                        Case 0

                        Case Else

                            rs = New Recordset
                            rs.Open("SELECT id FROM kompy where PCL=" & frmComputers.sCOUNT, DB7, CursorTypeEnum.adOpenDynamic,
                                    LockTypeEnum.adLockOptimistic)

                            With rs
                                .MoveFirst()
                                Do While Not .EOF
                                    sCN = .Fields("id").Value

                                    sSQL = "INSERT INTO dvig (id_comp,oldMesto,NewMesto,prich,D_T,T_M) VALUES (" & sCN & ",'" & iA & "','" & sFIALIAL & "','" & strTmp & "','" & Date.Today & "','" & sTmp.ToLongTimeString & "')"

                                    DB7.Execute(sSQL)

                                    'rs1 = New Recordset
                                    'rs1.Open(sSQL, DB7, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic)
                                    'rs1 = Nothing

                                    .MoveNext()
                                Loop
                            End With
                            rs.Close()
                            rs = Nothing

                    End Select

                Else

                End If

        End Select


        Exit Sub
Error_:
        MsgBox(Err.Description, vbInformation, ProGramName)
    End Sub

    Public Sub addEXISTTEH_()

        'Postav


        If Not (RSExists("CPUS", "name", frmComputers.cmbCPU1.Text)) Then
            AddFOwPar(frmComputers.cmbCPU1.Text, frmComputers.txtMHZ1.Text, frmComputers.txtSoc1.Text,
                      frmComputers.PROizV1.Text, "SPR_CPU", frmComputers.cmbCPU1)
        End If

        If Not (RSExists("CPUS", "name", frmComputers.cmbCPU2.Text)) Then
            AddFOwPar(frmComputers.cmbCPU2.Text, frmComputers.txtMHZ2.Text, frmComputers.txtSoc2.Text,
                      frmComputers.PROizV2.Text, "SPR_CPU", frmComputers.cmbCPU2)
        End If

        If Not (RSExists("MB", "name", frmComputers.cmbMB.Text)) Then
            AddTreePar(frmComputers.cmbMB.Text, frmComputers.txtChip.Text, frmComputers.PROizV5.Text, "SPR_MB",
                       frmComputers.cmbMB)
        End If

        If Not (RSExists("RAM", "name", frmComputers.cmbRAM1.Text)) Then
            AddTreePar(frmComputers.cmbRAM1.Text, frmComputers.txtRamS1.Text, frmComputers.PROizV6.Text, "SPR_RAM",
                       frmComputers.cmbRAM1)
        End If

        If Not (RSExists("RAM", "name", frmComputers.cmbRAM2.Text)) Then
            AddTreePar(frmComputers.cmbRAM2.Text, frmComputers.txtRamS2.Text, frmComputers.PROizV7.Text, "SPR_RAM",
                       frmComputers.cmbRAM2)
        End If

        If Not (RSExists("RAM", "name", frmComputers.cmbRAM3.Text)) Then
            AddTreePar(frmComputers.cmbRAM3.Text, frmComputers.txtRamS3.Text, frmComputers.PROizV8.Text, "SPR_RAM",
                       frmComputers.cmbRAM3)
        End If

        If Not (RSExists("RAM", "name", frmComputers.cmbRAM4.Text)) Then
            AddTreePar(frmComputers.cmbRAM4.Text, frmComputers.txtRamS4.Text, frmComputers.PROizV9.Text, "SPR_RAM",
                       frmComputers.cmbRAM4)
        End If

        If Not (RSExists("HDDS", "name", frmComputers.cmbHDD1.Text)) Then
            AddTreePar(frmComputers.cmbHDD1.Text, frmComputers.txtHDDo1.Text, frmComputers.PROizV10.Text, "SPR_HDD",
                       frmComputers.cmbHDD1)
        End If

        If Not (RSExists("HDDS", "name", frmComputers.cmbHDD2.Text)) Then
            AddTreePar(frmComputers.cmbHDD2.Text, frmComputers.txtHDDo2.Text, frmComputers.PROizV11.Text, "SPR_HDD",
                       frmComputers.cmbHDD2)
        End If

        If Not (RSExists("HDDS", "name", frmComputers.cmbHDD3.Text)) Then
            AddTreePar(frmComputers.cmbHDD3.Text, frmComputers.txtHDDo3.Text, frmComputers.PROizV12.Text, "SPR_HDD",
                       frmComputers.cmbHDD3)
        End If

        If Not (RSExists("HDDS", "name", frmComputers.cmbHDD4.Text)) Then
            AddTreePar(frmComputers.cmbHDD4.Text, frmComputers.txtHDDo4.Text, frmComputers.PROizV13.Text, "SPR_HDD",
                       frmComputers.cmbHDD4)
        End If

        If Not (RSExists("SVGA", "name", frmComputers.cmbSVGA1.Text)) Then
            AddTreePar(frmComputers.cmbSVGA1.Text, frmComputers.txtSVGAr1.Text, frmComputers.PROizV14.Text, "SPR_SVGA",
                       frmComputers.cmbSVGA1)
        End If

        If Not (RSExists("SOUND", "name", frmComputers.cmbSound.Text)) Then
            AddTwoPar(frmComputers.cmbSound.Text, frmComputers.PROizV16.Text, "SPR_SOUND", frmComputers.cmbSound)
        End If

        If Not (RSExists("CDROMS", "name", frmComputers.cmbOPTIC1.Text)) Then
            AddTreePar(frmComputers.cmbOPTIC1.Text, frmComputers.txtOPTICs1.Text, frmComputers.PROizV17.Text,
                       "SPR_OPTICAL", frmComputers.cmbOPTIC1)
        End If

        If Not (RSExists("CDRWS", "name", frmComputers.cmbOPTIC2.Text)) Then
            AddTreePar(frmComputers.cmbOPTIC2.Text, frmComputers.txtOPTICs2.Text, frmComputers.PROizV18.Text,
                       "SPR_OPTICAL", frmComputers.cmbOPTIC2)
        End If

        If Not (RSExists("DVDROMS", "name", frmComputers.cmbOPTIC3.Text)) Then
            AddTreePar(frmComputers.cmbOPTIC3.Text, frmComputers.txtOPTICs3.Text, frmComputers.PROizV19.Text,
                       "SPR_OPTICAL", frmComputers.cmbOPTIC3)
        End If


        If Not (RSExists("NET", "name", frmComputers.cmbNET1.Text)) Then
            AddTwoPar(frmComputers.cmbNET1.Text, frmComputers.PROizV20.Text, "SPR_NET", frmComputers.cmbNET1)
        End If


        If Not (RSExists("NET", "name", frmComputers.cmbNET2.Text)) Then
            AddTwoPar(frmComputers.cmbNET2.Text, frmComputers.PROizV21.Text, "SPR_NET", frmComputers.cmbNET2)
        End If


        If Not (RSExists("FDDs", "name", frmComputers.cmbFDD.Text)) Then
            AddTwoPar(frmComputers.cmbFDD.Text, frmComputers.PROizV22.Text, "SPR_FDD", frmComputers.cmbFDD)
        End If


        If Not (RSExists("MODEM", "name", frmComputers.cmbModem.Text)) Then
            AddTwoPar(frmComputers.cmbModem.Text, frmComputers.PROizV24.Text, "SPR_MODEM", frmComputers.cmbModem)
        End If


        If Not (RSExists("KEYBOARD", "name", frmComputers.cmbKeyb.Text)) Then
            AddTwoPar(frmComputers.cmbKeyb.Text, frmComputers.PROizV30.Text, "SPR_KEYBOARD", frmComputers.cmbKeyb)
        End If


        If Not (RSExists("MOUSE", "name", frmComputers.cmbMouse.Text)) Then
            AddTwoPar(frmComputers.cmbMouse.Text, frmComputers.PROizV31.Text, "SPR_MOUSE", frmComputers.cmbMouse)
        End If


        If Not (RSExists("USB", "name", frmComputers.cmbUSB.Text)) Then
            AddTwoPar(frmComputers.cmbUSB.Text, frmComputers.PROizV41.Text, "SPR_USB", frmComputers.cmbUSB)
        End If

        If Not (RSExists("MONITOR", "name", frmComputers.cmbMon1.Text)) Then
            AddTreePar(frmComputers.cmbMon1.Text, frmComputers.txtMon1Dum.Text, frmComputers.PROizV28.Text,
                       "SPR_MONITOR", frmComputers.cmbMon1)
        End If

        If Not (RSExists("MONITOR", "name", frmComputers.cmbMon2.Text)) Then
            AddTreePar(frmComputers.cmbMon2.Text, frmComputers.txtMon2Dum.Text, frmComputers.PROizV29.Text,
                       "SPR_MONITOR", frmComputers.cmbMon2)
        End If

        If Not (RSExists("ASISTEM", "name", frmComputers.cmbAsist.Text)) Then
            AddTwoPar(frmComputers.cmbAsist.Text, frmComputers.PROizV32.Text, "SPR_ASISTEM", frmComputers.cmbAsist)
        End If

        'If Not (RSExists("IBP", "name", frmComputers.CPU(53).Text)) Then
        ''addIBP(frmComputers.CPU(53).Text, frmComputers.PROizV(26).Text)
        'End If


        'If Not (RSExists("SCANER", "name", frmComputers.CPU(53).Text)) Then
        ''addSCANER(frmComputers.CPU(65).Text, frmComputers.PROizV(32).Text)
        'End If

        If Not (RSExists("otv", "name", Trim(frmComputers.cmbResponsible.Text))) Then
            AddOnePar(frmComputers.cmbResponsible.Text, "NAME", "SPR_OTV", frmComputers.cmbResponsible)
        End If


        If Not (RSExists("TIPS", "TIP", Trim(frmComputers.cmbAppointment.Text))) Then
            AddOnePar(frmComputers.cmbAppointment.Text, "TIP", "SPR_TIP", frmComputers.cmbAppointment)
        End If

        If Not (RSExists("Postav", "name", frmComputers.cmbPostav.Text)) Then
            AddOnePar(frmComputers.cmbPostav.Text, "NAME", "SPR_Postav", frmComputers.cmbPostav)
        End If

        If Not (RSExists("BP", "name", frmComputers.cmbBP.Text)) Then
            AddTwoPar(frmComputers.cmbBP.Text, frmComputers.PROizV26.Text, "SPR_BP", frmComputers.cmbBP)
        End If

        If Not (RSExists("CASE", "name", frmComputers.cmbCase.Text)) Then
            AddTwoPar(frmComputers.cmbCase.Text, frmComputers.PROizV25.Text, "SPR_CASE", frmComputers.cmbCase)
        End If

        If Not (RSExists("CREADER", "name", frmComputers.cmbCreader.Text)) Then
            AddTwoPar(frmComputers.cmbCreader.Text, frmComputers.PROizV23.Text, "SPR_CREADER", frmComputers.cmbCreader)
        End If
    End Sub

    Private Sub PRESAVE_TREE(ByVal sBr As ComboBox, ByVal sDp As ComboBox, ByVal sOff As ComboBox)

        Dim sFIL, sDEP, sOf As String
        sFIL = sBr.Text
        sDEP = sDp.Text
        sOf = sOff.Text

        If Not (RSExists("FILIAL", "FILIAL", sBr.Text)) Then
            AddOnePar(sFIL, "FILIAL", "SPR_FILIAL", sBr)

            Select Case TREE_UPDATE
                Case 0
                Case 1
                    Add_FILIAL_TREE(sFIL)
            End Select

        End If

        If Len(sDEP) = 0 Then Exit Sub

        If Not (RSExistsDB(sFIL, sDEP)) Then
            AddDepartment(sFIL, sDEP)
            Select Case TREE_UPDATE
                Case 0
                Case 1
                    Add_OTDEL_TREE(sFIL, sDEP)
            End Select
        End If

        If Len(sOf) = 0 Then Exit Sub

        If Not (RSExistsDBO(sFIL, sDEP, sOf)) Then
            AddOffice(sFIL, sDEP, sOf)
            Select Case TREE_UPDATE
                Case 0
                Case 1
                    Add_KABINET_TREE(sFIL, sDEP, sOf)
            End Select
        End If
    End Sub

    Public Sub SAVE_INF_BRANCHE()

        Dim counter As Long
        Dim SerD As String
        Dim sSQL As String

        Select Case frmComputers.sPREF

            Case "G"

                SerD = frmComputers.sCOUNT & "F"


            Case "O"

                SerD = frmComputers.sCOUNT & "O_F"

            Case "K"
                SerD = frmComputers.sCOUNT & "K"

        End Select


        Dim rs As Recordset
        rs = New Recordset

        rs.Open("Select COUNT(*) AS total_number FROM OTD_O where Id_OTD='" & SerD & "'", DB7,
                CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic)

        With rs
            counter = .Fields("total_number").Value
        End With

        rs.Close()
        rs = Nothing


        If counter = 0 Then

            sSQL = "INSERT INTO OTD_O (Id_OTD,Phone,OTV,ADRESS,Prim) VALUES ('" & SerD & "','" & frmComputers.txtBRPhone.Text & "','" & frmComputers.txtBRBoss.Text & "','" &
            frmComputers.txtBRAddress.Text & "','" & frmComputers.txtBRMemo.Text & "')"
        Else

            sSQL = "UPDATE OTD_O SET " &
                    "Phone='" & frmComputers.txtBRPhone.Text & "'," &
                    "OTV='" & frmComputers.txtBRBoss.Text & "'," &
                    "ADRESS='" & frmComputers.txtBRAddress.Text & "'," &
                    "Prim='" & frmComputers.txtBRMemo.Text & "' WHERE Id_OTD ='" & SerD & "'"

        End If

        DB7.Execute(sSQL)

        'rs = New Recordset
        'rs.Open(sSQL, DB7, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic)
        'rs = Nothing

        'Санитарный паспорт

        If Len(frmComputers.txtspplo.Text) = 0 Then Exit Sub

        rs = New Recordset
        rs.Open("Select COUNT(*) AS total_number FROM SES_Pass where id_OF='" & SerD & "'", DB7,
                CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic)

        With rs
            counter = .Fields("total_number").Value
        End With

        rs.Close()
        rs = Nothing

        If counter = 0 Then

            sSQL = "INSERT INTO SES_Pass (id_OF,Ploshad,visota,Pl1Pk,ob1Pk,nalpom,vent,voda,kanal,teplo,otdelka,mebel) VALUES ('" &
                            SerD & "','" &
                            frmComputers.txtspplo.Text & "','" &
                            frmComputers.txtspvis.Text & "','" &
                            frmComputers.txtspPloOneEVM.Text & "','" &
                            frmComputers.txtspObOneEVM.Text & "','" &
                            frmComputers.cmbSpRemEVM.Text & "','" &
                            frmComputers.cmbSpVent.Text & "','" &
                            frmComputers.cmbSpWater.Text & "','" &
                            frmComputers.cmbSpTeplo.Text & "','" &
                            frmComputers.cmbSpKanal.Text & "','" &
                            frmComputers.txtSpWall.Text & "','" &
                            frmComputers.txtSpMebel.Text & "')"
        Else

            sSQL = "UPDATE SES_Pass SET " &
                            "Ploshad='" & frmComputers.txtspplo.Text & "'," &
                            "visota='" & frmComputers.txtspvis.Text & "'," &
                            "Pl1Pk='" & frmComputers.txtspPloOneEVM.Text & "'," &
                            "ob1Pk='" & frmComputers.txtspObOneEVM.Text & "'," &
                            "nalpom='" & frmComputers.cmbSpRemEVM.Text & "'," &
                            "vent='" & frmComputers.cmbSpVent.Text & "'," &
                            "voda='" & frmComputers.cmbSpWater.Text & "'," &
                            "kanal='" & frmComputers.cmbSpTeplo.Text & "'," &
                            "teplo='" & frmComputers.cmbSpKanal.Text & "'," &
                            "otdelka='" & frmComputers.txtSpWall.Text & "'," &
                            "mebel='" & frmComputers.txtSpMebel.Text & "' WHERE id_OF ='" & SerD & "'"

        End If

        DB7.Execute(sSQL)

        'rs = New Recordset
        'rs.Open(sSQL, DB7, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic)
        'rs = Nothing


    End Sub

    Public Sub SAVE_DRAG_DROP(ByVal sID As String, ByVal sBRANCHE As String, ByVal sDEPARTMENT As String,
                              ByVal sOFFICE As String, ByVal sNAME As String)

        If frmComputers.EDT = True Then
            Call DVIG_TEHN(sBRANCHE, sDEPARTMENT, sOFFICE, sNAME)

            If DV = True Then

            Else
                If Sav = False Then
                    MsgBox("Отмена перемещения", MsgBoxStyle.Exclamation, ProGramName)
                    Exit Sub
                End If

            End If

        End If

        Dim sSQL As String

        sSQL = "UPDATE kompy SET FILIAL='" & sBRANCHE & "', mesto='" & sDEPARTMENT & "',kabn='" & sOFFICE & "',PCL=0 where id=" & sID

        DB7.Execute(sSQL)

        Dim rs As Recordset
        'rs = New Recordset
        'rs.Open(sSQL, DB7, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic)
        'rs = Nothing


        sSQL = "SELECT count(*) as t_n FROM kompy where PCL=" & sID
        rs = New Recordset
        rs.Open(sSQL, DB7, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic)

        Dim sCON As String

        With rs
            sCON = .Fields("t_n").Value
        End With
        rs.Close()
        rs = Nothing

        If sCON > 0 Then

            DB7.Execute("update kompy set FILIAL='" & sBRANCHE & "', mesto='" & sDEPARTMENT & "', kabn='" & sOFFICE & "' WHERE PCL=" & sID)

            ' DB7.Execute("update kompy set FILIAL='" & sBRANCHE & "', mesto='" & sDEPARTMENT & "', kabn='" & sOFFICE & "' WHERE PCL=" & rs.Fields("id").Value)

            'rs = New Recordset
            'rs.Open(
            '    "update kompy set FILIAL='" & sBRANCHE & "', mesto='" & sDEPARTMENT & "', kabn='" & sOFFICE &
            '    "' WHERE PCL=" & sID, DB7, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic)

            'rs = Nothing

            'sSQL = "update kompy set FILIAL='" & sBRANCHE & "', mesto='" & sDEPARTMENT & "', kabn='" & sOFFICE & "' WHERE PCL=" & rs.Fields("id").Value
            'rs = New Recordset
            'rs.Open(sSQL, DB7, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic)
            'rs = Nothing


        End If
    End Sub

    Public Sub under_prn(Optional ByVal sSID As Integer = 0)
        If sSID = 0 Then sSID = frmComputers.sCOUNT

        On Error Resume Next

        Dim sCount As Integer
        Dim rs As Recordset


        Dim sSQL As String
        Dim tId As Integer

        rs = New Recordset
        rs.Open("Select count(*) as t_n from kompy where PCL=" & sSID, DB7, CursorTypeEnum.adOpenDynamic,
                LockTypeEnum.adLockOptimistic)

        With rs

            sCount = .Fields("t_n").Value

        End With
        rs.Close()
        rs = Nothing

        If sCount = 0 Then Exit Sub

        Dim rs1 As Recordset

        Dim objIniFile As New IniFile(PrPath & "base.ini")

        Dim sRAZDEL As String
        sRAZDEL = objIniFile.GetString("General", "RAZDEL", "0")

        Select Case sRAZDEL

            Case 0 'все

                'Мониторы
                sSQL = "SELECT count(*) as t_n FROM kompy where PCL=" & sSID & " and tiptehn = 'MONITOR'"

                rs = New Recordset
                rs.Open(sSQL, DB7, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic)

                With rs

                    sCount = .Fields("t_n").Value

                End With
                rs.Close()
                rs = Nothing

                sSQL = "SELECT id,MONITOR_NAME,MONITOR_DUM,MONITOR_SN,MONITOR_PROIZV,INV_NO_MONITOR FROM kompy where PCL=" & sSID & " and tiptehn = 'MONITOR'"

                rs = New Recordset
                rs.Open(sSQL, DB7, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic)

                Dim i As Integer = 1

                Dim sTMP0 As String

                With rs
                    .MoveFirst()
                    Do While Not .EOF

                        tId = .Fields("id").Value

                        Select Case sCount

                            Case 1

                                sSQL = "UPDATE kompy SET MONITOR_NAME='" & rs.Fields("MONITOR_NAME").Value & "',MONITOR_DUM='" &
                           rs.Fields("MONITOR_DUM").Value & "',MONITOR_SN='" &
                           rs.Fields("MONITOR_SN").Value & "',MONITOR_PROIZV='" &
                           rs.Fields("MONITOR_PROIZV").Value & "',INV_NO_MONITOR='" &
                           rs.Fields("INV_NO_MONITOR").Value & "' where id=" & sSID
                                DB7.Execute(sSQL)

                                'rs1 = New Recordset
                                'rs1.Open(sSQL, DB7, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic)
                                'rs1 = Nothing

                            Case Else

                                Select Case i

                                    Case 2

                                        sSQL = "UPDATE kompy SET MONITOR_NAME2='" & rs.Fields("MONITOR_NAME").Value & "',MONITOR_DUM2='" &
                          rs.Fields("MONITOR_DUM").Value & "',MONITOR_SN2='" &
                          rs.Fields("MONITOR_SN").Value & "',MONITOR_PROIZV2='" &
                          rs.Fields("MONITOR_PROIZV").Value & "',INV_NO_MONITOR='" &
                          rs.Fields("INV_NO_MONITOR").Value & "' where id=" & sSID
                                        DB7.Execute(sSQL)

                                        'rs1 = New Recordset
                                        'rs1.Open(sSQL, DB7, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic)
                                        'rs1 = Nothing

                                    Case Else

                                        sSQL = "UPDATE kompy SET MONITOR_NAME='" & rs.Fields("MONITOR_NAME").Value & "',MONITOR_DUM='" &
                          rs.Fields("MONITOR_DUM").Value & "',MONITOR_SN='" &
                          rs.Fields("MONITOR_SN").Value & "',MONITOR_PROIZV='" &
                          rs.Fields("MONITOR_PROIZV").Value & "',INV_NO_MONITOR='" &
                          rs.Fields("INV_NO_MONITOR").Value & "' where id=" & sSID

                                        DB7.Execute(sSQL)

                                        'rs1 = New Recordset
                                        'rs1.Open(sSQL, DB7, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic)
                                        'rs1 = Nothing

                                End Select

                        End Select

                        i = i + 1

                        DB7.Execute("UPDATE Remont SET Id_Comp=" & sSID & " where Id_Comp=" & tId)
                        DB7.Execute("UPDATE Zametki SET Id_Comp=" & sSID & " where Id_Comp=" & tId)
                        DB7.Execute("Delete from Garantia_sis where Id_Comp=" & tId)
                        DB7.Execute("Delete from dvig where Id_Comp=" & tId)
                        DB7.Execute("Delete from kompy where id=" & tId)


                        'rs1 = New Recordset
                        'rs1.Open("UPDATE Remont SET Id_Comp=" & sSID & " where Id_Comp=" & tId, DB7,
                        '         CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic)
                        'rs1 = Nothing

                        'rs1 = New Recordset
                        'rs1.Open("UPDATE Zametki SET Id_Comp=" & sSID & " where Id_Comp=" & tId, DB7,
                        '         CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic)
                        'rs1 = Nothing

                        'rs1 = New Recordset
                        'rs1.Open("Delete from Garantia_sis where Id_Comp=" & tId, DB7, CursorTypeEnum.adOpenDynamic,
                        '         LockTypeEnum.adLockOptimistic)
                        'rs1 = Nothing

                        'rs1 = New Recordset
                        'rs1.Open("Delete from dvig where Id_Comp=" & tId, DB7, CursorTypeEnum.adOpenDynamic,
                        '         LockTypeEnum.adLockOptimistic)
                        'rs1 = Nothing

                        'rs1 = New Recordset
                        'rs1.Open("Delete from kompy where id=" & tId, DB7, CursorTypeEnum.adOpenDynamic,
                        '         LockTypeEnum.adLockOptimistic)
                        'rs1 = Nothing

                        .MoveNext()
                    Loop
                End With
                rs.Close()
                rs = Nothing

                'Принтеры
                sSQL = "SELECT count(*) as t_n FROM kompy where PCL=" & sSID & " and tiptehn = 'Printer'"

                rs = New Recordset
                rs.Open(sSQL, DB7, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic)

                With rs

                    sCount = .Fields("t_n").Value

                End With
                rs.Close()
                rs = Nothing

                sSQL = "SELECT id,PRINTER_NAME_1,PRINTER_SN_1,PRINTER_PROIZV_1,port_2,INV_NO_PRINTER FROM kompy where PCL=" & sSID & " and tiptehn = 'Printer'"

                rs = New Recordset
                rs.Open(sSQL, DB7, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic)

                i = 1

                Dim pField, pField1, pField2, pField3, pField4 As String

                With rs
                    .MoveFirst()
                    Do While Not .EOF

                        tId = .Fields("id").Value

                        pField1 = "PRINTER_NAME_" & i
                        pField2 = "PRINTER_SN_" & i
                        pField3 = "PRINTER_PROIZV_" & i
                        pField4 = "port_" & i

                        sSQL = "UPDATE kompy SET " & pField1 & "='" & rs.Fields("PRINTER_NAME_1").Value &
                        "'," & pField2 & "='" & rs.Fields("PRINTER_SN_1").Value &
                        "'," & pField3 & "='" & rs.Fields("PRINTER_PROIZV_1").Value &
                        "',INV_NO_PRINTER='" & rs.Fields("INV_NO_PRINTER").Value &
                        "'," & pField4 & "='" & rs.Fields("port_2").Value &
                        "' where id=" & sSID

                        DB7.Execute(sSQL)

                        'rs1 = New Recordset
                        'rs1.Open(sSQL, DB7, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic)
                        'rs1 = Nothing

                        i = i + 1

                        DB7.Execute("UPDATE Remont SET Id_Comp=" & sSID & " where Id_Comp=" & tId)
                        DB7.Execute("UPDATE Zametki SET Id_Comp=" & sSID & " where Id_Comp=" & tId)
                        DB7.Execute("Delete from Garantia_sis where Id_Comp=" & tId)
                        DB7.Execute("Delete from dvig where Id_Comp=" & tId)
                        DB7.Execute("Delete from kompy where id=" & tId)


                        'rs1 = New Recordset
                        'rs1.Open("UPDATE Remont SET Id_Comp=" & sSID & " where Id_Comp=" & tId, DB7,
                        '         CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic)
                        'rs1 = Nothing

                        'rs1 = New Recordset
                        'rs1.Open("UPDATE Zametki SET Id_Comp=" & sSID & " where Id_Comp=" & tId, DB7,
                        '         CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic)
                        'rs1 = Nothing

                        'rs1 = New Recordset
                        'rs1.Open("Delete from Garantia_sis where Id_Comp=" & tId, DB7, CursorTypeEnum.adOpenDynamic,
                        '         LockTypeEnum.adLockOptimistic)
                        'rs1 = Nothing

                        'rs1 = New Recordset
                        'rs1.Open("Delete from dvig where Id_Comp=" & tId, DB7, CursorTypeEnum.adOpenDynamic,
                        '         LockTypeEnum.adLockOptimistic)
                        'rs1 = Nothing

                        'rs1 = New Recordset
                        'rs1.Open("Delete from kompy where id=" & tId, DB7, CursorTypeEnum.adOpenDynamic,
                        '         LockTypeEnum.adLockOptimistic)
                        'rs1 = Nothing

                        .MoveNext()
                    Loop
                End With
                rs.Close()
                rs = Nothing

                'ИБП
                sSQL = "SELECT id,PRINTER_NAME_1,PRINTER_SN_1,PRINTER_PROIZV_1,port_1,INV_NO_PRINTER FROM kompy where PCL=" & sSID & " and tiptehn = 'IBP'"

                rs = New Recordset
                rs.Open(sSQL, DB7, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic)

                With rs
                    .MoveFirst()
                    Do While Not .EOF

                        tId = .Fields("id").Value

                        sSQL = "UPDATE kompy SET IBP_NAME='" & rs.Fields("PRINTER_NAME_1").Value & "',IBP_SN='" &
                         rs.Fields("PRINTER_SN_1").Value & "',IBP_PROIZV='" &
                         rs.Fields("PRINTER_PROIZV_1").Value & "',INV_NO_IBP='" &
                         rs.Fields("INV_NO_PRINTER").Value & "' where id=" & sSID

                        DB7.Execute(sSQL)

                        'rs1 = New Recordset
                        'rs1.Open(sSQL, DB7, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic)
                        'rs1 = Nothing

                        DB7.Execute("UPDATE Remont SET Id_Comp=" & sSID & " where Id_Comp=" & tId)
                        DB7.Execute("UPDATE Zametki SET Id_Comp=" & sSID & " where Id_Comp=" & tId)
                        DB7.Execute("Delete from Garantia_sis where Id_Comp=" & tId)
                        DB7.Execute("Delete from dvig where Id_Comp=" & tId)
                        DB7.Execute("Delete from kompy where id=" & tId)


                        'rs1 = New Recordset
                        'rs1.Open("UPDATE Remont SET Id_Comp=" & sSID & " where Id_Comp=" & tId, DB7,
                        '         CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic)
                        'rs1 = Nothing

                        'rs1 = New Recordset
                        'rs1.Open("UPDATE Zametki SET Id_Comp=" & sSID & " where Id_Comp=" & tId, DB7,
                        '         CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic)
                        'rs1 = Nothing

                        'rs1 = New Recordset
                        'rs1.Open("Delete from Garantia_sis where Id_Comp=" & tId, DB7, CursorTypeEnum.adOpenDynamic,
                        '         LockTypeEnum.adLockOptimistic)
                        'rs1 = Nothing

                        'rs1 = New Recordset
                        'rs1.Open("Delete from kompy where id=" & tId, DB7, CursorTypeEnum.adOpenDynamic,
                        '         LockTypeEnum.adLockOptimistic)
                        'rs1 = Nothing

                        ' Call FIND_TREE_TAG(frmComputers.lstGroups.Nodes, "C|" & tId)
                        ' frmComputers.lstGroups.SelectedNode.Remove()

                        .MoveNext()
                    Loop
                End With
                rs.Close()
                rs = Nothing

                'Клавиатуры мыши
                sSQL = "SELECT id,PRINTER_NAME_1,PRINTER_SN_1,PRINTER_PROIZV_1,port_1 FROM kompy where PCL=" & sSID & " and tiptehn = 'KEYB'"

                rs = New Recordset
                rs.Open(sSQL, DB7, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic)

                With rs
                    .MoveFirst()
                    Do While Not .EOF

                        tId = .Fields("id").Value

                        sSQL = "UPDATE kompy SET KEYBOARD_NAME='" & rs.Fields("PRINTER_NAME_1").Value &
                            "',KEYBOARD_SN='" & rs.Fields("PRINTER_SN_1").Value &
                            "',KEYBOARD_PROIZV='" & rs.Fields("PRINTER_PROIZV_1").Value & "' where id=" & sSID

                        DB7.Execute(sSQL)

                        'rs1 = New Recordset
                        'rs1.Open(sSQL, DB7, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic)
                        'rs1 = Nothing

                        DB7.Execute("UPDATE Remont SET Id_Comp=" & sSID & " where Id_Comp=" & tId)
                        DB7.Execute("UPDATE Zametki SET Id_Comp=" & sSID & " where Id_Comp=" & tId)
                        DB7.Execute("Delete from Garantia_sis where Id_Comp=" & tId)
                        DB7.Execute("Delete from dvig where Id_Comp=" & tId)
                        DB7.Execute("Delete from kompy where id=" & tId)

                        'rs1 = New Recordset
                        'rs1.Open("UPDATE Remont SET Id_Comp=" & sSID & " where Id_Comp=" & tId, DB7,
                        '         CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic)
                        'rs1 = Nothing

                        'rs1 = New Recordset
                        'rs1.Open("UPDATE Zametki SET Id_Comp=" & sSID & " where Id_Comp=" & tId, DB7,
                        '         CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic)
                        'rs1 = Nothing

                        'rs1 = New Recordset
                        'rs1.Open("Delete from Garantia_sis where Id_Comp=" & tId, DB7, CursorTypeEnum.adOpenDynamic,
                        '         LockTypeEnum.adLockOptimistic)
                        'rs1 = Nothing

                        'rs1 = New Recordset
                        'rs1.Open("Delete from kompy where id=" & tId, DB7, CursorTypeEnum.adOpenDynamic,
                        '         LockTypeEnum.adLockOptimistic)
                        'rs1 = Nothing

                        .MoveNext()
                    Loop
                End With
                rs.Close()
                rs = Nothing


                sSQL = "SELECT id,PRINTER_NAME_1,PRINTER_SN_1,PRINTER_PROIZV_1 FROM kompy where PCL=" & sSID & " and tiptehn = 'MOUSE'"

                rs = New Recordset
                rs.Open(sSQL, DB7, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic)

                With rs
                    .MoveFirst()
                    Do While Not .EOF

                        tId = .Fields("id").Value

                        sSQL = "UPDATE kompy SET MOUSE_NAME='" & rs.Fields("PRINTER_NAME_1").Value &
                            "',MOUSE_SN='" & rs.Fields("PRINTER_SN_1").Value &
                            "',MOUSE_PROIZV='" & rs.Fields("PRINTER_PROIZV_1").Value & "' where id=" & sSID

                        DB7.Execute(sSQL)

                        'rs1 = New Recordset
                        'rs1.Open(sSQL, DB7, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic)
                        'rs1 = Nothing

                        DB7.Execute("UPDATE Remont SET Id_Comp=" & sSID & " where Id_Comp=" & tId)
                        DB7.Execute("UPDATE Zametki SET Id_Comp=" & sSID & " where Id_Comp=" & tId)
                        DB7.Execute("Delete from Garantia_sis where Id_Comp=" & tId)
                        DB7.Execute("Delete from dvig where Id_Comp=" & tId)
                        DB7.Execute("Delete from kompy where id=" & tId)

                        'rs1 = New Recordset
                        'rs1.Open("UPDATE Remont SET Id_Comp=" & sSID & " where Id_Comp=" & tId, DB7,
                        '         CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic)
                        'rs1 = Nothing

                        'rs1 = New Recordset
                        'rs1.Open("UPDATE Zametki SET Id_Comp=" & sSID & " where Id_Comp=" & tId, DB7,
                        '         CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic)
                        'rs1 = Nothing

                        'rs1 = New Recordset
                        'rs1.Open("Delete from Garantia_sis where Id_Comp=" & tId, DB7, CursorTypeEnum.adOpenDynamic,
                        '         LockTypeEnum.adLockOptimistic)
                        'rs1 = Nothing

                        'rs1 = New Recordset
                        'rs1.Open("Delete from kompy where id=" & tId, DB7, CursorTypeEnum.adOpenDynamic,
                        '         LockTypeEnum.adLockOptimistic)
                        'rs1 = Nothing

                        .MoveNext()
                    Loop
                End With
                rs.Close()
                rs = Nothing

                'Сетевые фильтры

                sSQL = "SELECT id,PRINTER_NAME_1,PRINTER_SN_1,PRINTER_PROIZV_1 FROM kompy where PCL=" & sSID & " and tiptehn = 'FS'"

                rs = New Recordset
                rs.Open(sSQL, DB7, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic)

                With rs
                    .MoveFirst()
                    Do While Not .EOF

                        tId = .Fields("id").Value

                        sSQL = "UPDATE kompy SET FILTR_NAME='" & rs.Fields("PRINTER_NAME_1").Value &
                            "',FILTR_SN='" & rs.Fields("PRINTER_SN_1").Value &
                            "',FILTR_PROIZV='" & rs.Fields("PRINTER_PROIZV_1").Value &
                            "' where id=" & sSID

                        DB7.Execute(sSQL)

                        'rs1 = New Recordset
                        'rs1.Open(sSQL, DB7, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic)
                        'rs1 = Nothing

                        rs1 = New Recordset
                        rs1.Open("Select FILTR_NAME,FILTR_SN,FILTR_PROIZV from kompy where id=" & sSID, DB7, CursorTypeEnum.adOpenDynamic,
                                 LockTypeEnum.adLockOptimistic)

                        With rs1
                            rs1.Fields("FILTR_NAME").Value = rs.Fields("PRINTER_NAME_1").Value
                            rs1.Fields("FILTR_SN").Value = rs.Fields("PRINTER_SN_1").Value
                            rs1.Fields("FILTR_PROIZV").Value = rs.Fields("PRINTER_PROIZV_1").Value
                            .Update()
                        End With

                        rs1.Close()
                        rs1 = Nothing

                        DB7.Execute("UPDATE Remont SET Id_Comp=" & sSID & " where Id_Comp=" & tId)
                        DB7.Execute("UPDATE Zametki SET Id_Comp=" & sSID & " where Id_Comp=" & tId)
                        DB7.Execute("Delete from Garantia_sis where Id_Comp=" & tId)
                        DB7.Execute("Delete from dvig where Id_Comp=" & tId)
                        DB7.Execute("Delete from kompy where id=" & tId)

                        'rs1 = New Recordset
                        'rs1.Open("UPDATE Remont SET Id_Comp=" & sSID & " where Id_Comp=" & tId, DB7,
                        '         CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic)
                        'rs1 = Nothing

                        'rs1 = New Recordset
                        'rs1.Open("UPDATE Zametki SET Id_Comp=" & sSID & " where Id_Comp=" & tId, DB7,
                        '         CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic)
                        'rs1 = Nothing

                        'rs1 = New Recordset
                        'rs1.Open("Delete from Garantia_sis where Id_Comp=" & tId, DB7, CursorTypeEnum.adOpenDynamic,
                        '         LockTypeEnum.adLockOptimistic)
                        'rs1 = Nothing

                        'rs1 = New Recordset
                        'rs1.Open("Delete from kompy where id=" & tId, DB7, CursorTypeEnum.adOpenDynamic,
                        '         LockTypeEnum.adLockOptimistic)
                        'rs1 = Nothing

                        ' Call FIND_TREE_TAG(frmComputers.lstGroups.Nodes, "C|" & tId)
                        ' frmComputers.lstGroups.SelectedNode.Remove()

                        .MoveNext()
                    Loop
                End With
                rs.Close()
                rs = Nothing

            Case 1 'Мониторы

                sSQL = "SELECT count(*) as t_n FROM kompy where PCL=" & sSID & " and tiptehn = 'MONITOR'"

                rs = New Recordset
                rs.Open(sSQL, DB7, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic)

                With rs

                    sCount = .Fields("t_n").Value

                End With
                rs.Close()
                rs = Nothing

                sSQL = "SELECT id,MONITOR_NAME,MONITOR_DUM,MONITOR_SN,MONITOR_PROIZV,INV_NO_MONITOR FROM kompy where PCL=" & sSID & " and tiptehn = 'MONITOR'"

                rs = New Recordset
                rs.Open(sSQL, DB7, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic)

                Dim i As Integer = 1

                Dim pField As String

                With rs
                    .MoveFirst()
                    Do While Not .EOF

                        tId = .Fields("id").Value

                        rs1 = New Recordset
                        rs1.Open("Select id,MONITOR_NAME,MONITOR_DUM,MONITOR_SN,MONITOR_PROIZV,INV_NO_MONITOR,MONITOR_NAME2,MONITOR_DUM2,MONITOR_SN2,MONITOR_PROIZV2 from kompy where id=" & sSID, DB7, CursorTypeEnum.adOpenDynamic,
                                 LockTypeEnum.adLockOptimistic)


                        If sCount = 1 Then

                            sSQL = "UPDATE kompy SET MONITOR_NAME='" & rs.Fields("MONITOR_NAME").Value &
                                "',MONITOR_DUM='" & rs.Fields("MONITOR_DUM").Value &
                                "',MONITOR_SN='" & rs.Fields("MONITOR_SN").Value &
                                "',MONITOR_PROIZV='" & rs.Fields("MONITOR_PROIZV").Value &
                                "',INV_NO_MONITOR='" & rs.Fields("INV_NO_MONITOR").Value & "' where id=" & sSID

                            DB7.Execute(sSQL)

                            'rs1 = New Recordset
                            'rs1.Open(sSQL, DB7, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic)
                            'rs1 = Nothing

                        Else

                            If i = 2 Then

                                sSQL = "UPDATE kompy SET MONITOR_NAME2='" & rs.Fields("MONITOR_NAME").Value &
                                "',MONITOR_DUM2='" & rs.Fields("MONITOR_DUM").Value &
                                "',MONITOR_SN2='" & rs.Fields("MONITOR_SN").Value &
                                "',MONITOR_PROIZV2='" & rs.Fields("MONITOR_PROIZV").Value &
                                "',INV_NO_MONITOR='" & rs.Fields("INV_NO_MONITOR").Value & "' where id=" & sSID

                                DB7.Execute(sSQL)

                                'rs1 = New Recordset
                                'rs1.Open(sSQL, DB7, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic)
                                'rs1 = Nothing

                            Else

                                sSQL = "UPDATE kompy SET MONITOR_NAME='" & rs.Fields("MONITOR_NAME").Value &
                                "',MONITOR_DUM='" & rs.Fields("MONITOR_DUM").Value &
                                "',MONITOR_SN='" & rs.Fields("MONITOR_SN").Value &
                                "',MONITOR_PROIZV='" & rs.Fields("MONITOR_PROIZV").Value &
                                "',INV_NO_MONITOR='" & rs.Fields("INV_NO_MONITOR").Value & "' where id=" & sSID

                                DB7.Execute(sSQL)

                                'rs1 = New Recordset
                                'rs1.Open(sSQL, DB7, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic)
                                'rs1 = Nothing

                            End If

                        End If

                        i = i + 1

                        DB7.Execute("UPDATE Remont SET Id_Comp=" & sSID & " where Id_Comp=" & tId)
                        DB7.Execute("UPDATE Zametki SET Id_Comp=" & sSID & " where Id_Comp=" & tId)
                        DB7.Execute("Delete from Garantia_sis where Id_Comp=" & tId)
                        DB7.Execute("Delete from dvig where Id_Comp=" & tId)
                        DB7.Execute("Delete from kompy where id=" & tId)

                        'rs1 = New Recordset
                        'rs1.Open("UPDATE Remont SET Id_Comp=" & sSID & " where Id_Comp=" & tId, DB7,
                        '         CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic)
                        'rs1 = Nothing

                        'rs1 = New Recordset
                        'rs1.Open("UPDATE Zametki SET Id_Comp=" & sSID & " where Id_Comp=" & tId, DB7,
                        '         CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic)
                        'rs1 = Nothing

                        'rs1 = New Recordset
                        'rs1.Open("Delete from Garantia_sis where Id_Comp=" & tId, DB7, CursorTypeEnum.adOpenDynamic,
                        '         LockTypeEnum.adLockOptimistic)
                        'rs1 = Nothing

                        'rs1 = New Recordset
                        'rs1.Open("Delete from kompy where id=" & tId, DB7, CursorTypeEnum.adOpenDynamic,
                        '         LockTypeEnum.adLockOptimistic)
                        'rs1 = Nothing

                        .MoveNext()
                    Loop
                End With
                rs.Close()
                rs = Nothing

            Case 2 'Принтеры

                sSQL = "SELECT count(*) as t_n FROM kompy where PCL=" & sSID & " and tiptehn = 'Printer'"

                rs = New Recordset
                rs.Open(sSQL, DB7, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic)

                With rs

                    sCount = .Fields("t_n").Value

                End With
                rs.Close()
                rs = Nothing

                sSQL = "SELECT id.PRINTER_NAME_1,PRINTER_SN_1,PRINTER_PROIZV_1,INV_NO_PRINTER,port_2 FROM kompy where PCL=" & sSID & " and tiptehn = 'Printer'"

                rs = New Recordset
                rs.Open(sSQL, DB7, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic)


                Dim i As Integer = 1

                Dim pField, pField1, pField2, pField3, pField4 As String

                With rs
                    .MoveFirst()
                    Do While Not .EOF

                        tId = .Fields("id").Value

                        pField1 = "PRINTER_NAME_" & i
                        pField2 = "PRINTER_SN_" & i
                        pField3 = "PRINTER_PROIZV_" & i
                        pField4 = "port_" & i

                        sSQL = "UPDATE kompy SET " & pField1 & "='" & rs.Fields("PRINTER_NAME_1").Value &
                        "'," & pField2 & "='" & rs.Fields("PRINTER_SN_1").Value &
                        "'," & pField3 & "='" & rs.Fields("PRINTER_PROIZV_1").Value &
                        "',INV_NO_PRINTER='" & rs.Fields("INV_NO_PRINTER").Value &
                        "'," & pField4 & "='" & rs.Fields("port_2").Value &
                        "' where id=" & sSID

                        DB7.Execute(sSQL)

                        'rs1 = New Recordset
                        'rs1.Open(sSQL, DB7, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic)
                        'rs1 = Nothing

                        i = i + 1

                        DB7.Execute("UPDATE Remont SET Id_Comp=" & sSID & " where Id_Comp=" & tId)
                        DB7.Execute("UPDATE Zametki SET Id_Comp=" & sSID & " where Id_Comp=" & tId)
                        DB7.Execute("Delete from Garantia_sis where Id_Comp=" & tId)
                        DB7.Execute("Delete from dvig where Id_Comp=" & tId)
                        DB7.Execute("Delete from kompy where id=" & tId)

                        'rs1 = New Recordset
                        'rs1.Open("UPDATE Remont SET Id_Comp=" & sSID & " where Id_Comp=" & tId, DB7,
                        '         CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic)
                        'rs1 = Nothing

                        'rs1 = New Recordset
                        'rs1.Open("UPDATE Zametki SET Id_Comp=" & sSID & " where Id_Comp=" & tId, DB7,
                        '         CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic)
                        'rs1 = Nothing

                        'rs1 = New Recordset
                        'rs1.Open("Delete from Garantia_sis where Id_Comp=" & tId, DB7, CursorTypeEnum.adOpenDynamic,
                        '         LockTypeEnum.adLockOptimistic)
                        'rs1 = Nothing

                        'rs1 = New Recordset
                        'rs1.Open("Delete from dvig where Id_Comp=" & tId, DB7, CursorTypeEnum.adOpenDynamic,
                        '         LockTypeEnum.adLockOptimistic)
                        'rs1 = Nothing

                        'rs1 = New Recordset
                        'rs1.Open("Delete from kompy where id=" & tId, DB7, CursorTypeEnum.adOpenDynamic,
                        '         LockTypeEnum.adLockOptimistic)
                        'rs1 = Nothing

                        .MoveNext()
                    Loop
                End With
                rs.Close()
                rs = Nothing

            Case 3 'ИБП

                sSQL = "SELECT id,PRINTER_NAME_1,PRINTER_SN_1,PRINTER_PROIZV_1,INV_NO_PRINTER FROM kompy where PCL=" & sSID & " and tiptehn = 'IBP'"

                rs = New Recordset
                rs.Open(sSQL, DB7, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic)

                With rs
                    .MoveFirst()
                    Do While Not .EOF

                        tId = .Fields("id").Value

                        sSQL = "UPDATE kompy SET IBP_NAME='" & rs.Fields("PRINTER_NAME_1").Value &
                            "',IBP_SN='" & rs.Fields("PRINTER_SN_1").Value &
                            "',IBP_PROIZV='" & rs.Fields("PRINTER_PROIZV_1").Value &
                            "',INV_NO_IBP='" & rs.Fields("INV_NO_PRINTER").Value & "' where id=" & sSID

                        DB7.Execute(sSQL)

                        'rs1 = New Recordset
                        'rs1.Open(sSQL, DB7, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic)
                        'rs1 = Nothing

                        DB7.Execute("UPDATE Remont SET Id_Comp=" & sSID & " where Id_Comp=" & tId)
                        DB7.Execute("UPDATE Zametki SET Id_Comp=" & sSID & " where Id_Comp=" & tId)
                        DB7.Execute("Delete from Garantia_sis where Id_Comp=" & tId)
                        DB7.Execute("Delete from dvig where Id_Comp=" & tId)
                        DB7.Execute("Delete from kompy where id=" & tId)

                        'rs1 = New Recordset
                        'rs1.Open("UPDATE Remont SET Id_Comp=" & sSID & " where Id_Comp=" & tId, DB7,
                        '         CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic)
                        'rs1 = Nothing

                        'rs1 = New Recordset
                        'rs1.Open("UPDATE Zametki SET Id_Comp=" & sSID & " where Id_Comp=" & tId, DB7,
                        '         CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic)
                        'rs1 = Nothing

                        'rs1 = New Recordset
                        'rs1.Open("Delete from Garantia_sis where Id_Comp=" & tId, DB7, CursorTypeEnum.adOpenDynamic,
                        '         LockTypeEnum.adLockOptimistic)
                        'rs1 = Nothing

                        'rs1 = New Recordset
                        'rs1.Open("Delete from kompy where id=" & tId, DB7, CursorTypeEnum.adOpenDynamic,
                        '         LockTypeEnum.adLockOptimistic)
                        'rs1 = Nothing

                        ' Call FIND_TREE_TAG(frmComputers.lstGroups.Nodes, "C|" & tId)
                        ' frmComputers.lstGroups.SelectedNode.Remove()
                        .MoveNext()
                    Loop
                End With
                rs.Close()
                rs = Nothing
            Case 4 'Клавиатуры мыши

                sSQL = "SELECT id,PRINTER_NAME_1,PRINTER_SN_1,PRINTER_PROIZV_1,INV_NO_PRINTER FROM kompy where PCL=" & sSID & " and tiptehn = 'KEYB'"

                rs = New Recordset
                rs.Open(sSQL, DB7, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic)

                With rs
                    .MoveFirst()
                    Do While Not .EOF

                        tId = .Fields("id").Value

                        sSQL = "UPDATE kompy SET KEYBOARD_NAME='" & rs.Fields("PRINTER_NAME_1").Value &
                           "',KEYBOARD_SN='" & rs.Fields("PRINTER_SN_1").Value &
                           "',KEYBOARD_PROIZV='" & rs.Fields("PRINTER_PROIZV_1").Value &
                            "' where id=" & sSID

                        DB7.Execute(sSQL)

                        'rs1 = New Recordset
                        'rs1.Open(sSQL, DB7, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic)
                        'rs1 = Nothing

                        DB7.Execute("UPDATE Remont SET Id_Comp=" & sSID & " where Id_Comp=" & tId)
                        DB7.Execute("UPDATE Zametki SET Id_Comp=" & sSID & " where Id_Comp=" & tId)
                        DB7.Execute("Delete from Garantia_sis where Id_Comp=" & tId)
                        DB7.Execute("Delete from dvig where Id_Comp=" & tId)
                        DB7.Execute("Delete from kompy where id=" & tId)

                        'rs1 = New Recordset
                        'rs1.Open("UPDATE Remont SET Id_Comp=" & sSID & " where Id_Comp=" & tId, DB7,
                        '         CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic)
                        'rs1 = Nothing

                        'rs1 = New Recordset
                        'rs1.Open("UPDATE Zametki SET Id_Comp=" & sSID & " where Id_Comp=" & tId, DB7,
                        '         CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic)
                        'rs1 = Nothing

                        'rs1 = New Recordset
                        'rs1.Open("Delete from Garantia_sis where Id_Comp=" & tId, DB7, CursorTypeEnum.adOpenDynamic,
                        '         LockTypeEnum.adLockOptimistic)
                        'rs1 = Nothing

                        'rs1 = New Recordset
                        'rs1.Open("Delete from kompy where id=" & tId, DB7, CursorTypeEnum.adOpenDynamic,
                        '         LockTypeEnum.adLockOptimistic)
                        'rs1 = Nothing

                        .MoveNext()
                    Loop
                End With
                rs.Close()
                rs = Nothing


                sSQL = "SELECT id,PRINTER_NAME_1,PRINTER_SN_1,PRINTER_PROIZV_1,INV_NO_PRINTER FROM kompy where PCL=" & sSID & " and tiptehn = 'MOUSE'"

                rs = New Recordset
                rs.Open(sSQL, DB7, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic)

                With rs
                    .MoveFirst()
                    Do While Not .EOF

                        tId = .Fields("id").Value

                        sSQL = "UPDATE kompy SET MOUSE_NAME='" & rs.Fields("PRINTER_NAME_1").Value &
                           "',MOUSE_SN='" & rs.Fields("PRINTER_SN_1").Value &
                           "',MOUSE_PROIZV='" & rs.Fields("PRINTER_PROIZV_1").Value &
                            "' where id=" & sSID

                        DB7.Execute(sSQL)

                        'rs1 = New Recordset
                        'rs1.Open(sSQL, DB7, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic)
                        'rs1 = Nothing

                        DB7.Execute("UPDATE Remont SET Id_Comp=" & sSID & " where Id_Comp=" & tId)
                        DB7.Execute("UPDATE Zametki SET Id_Comp=" & sSID & " where Id_Comp=" & tId)
                        DB7.Execute("Delete from Garantia_sis where Id_Comp=" & tId)
                        DB7.Execute("Delete from dvig where Id_Comp=" & tId)
                        DB7.Execute("Delete from kompy where id=" & tId)

                        'rs1 = New Recordset
                        'rs1.Open("UPDATE Remont SET Id_Comp=" & sSID & " where Id_Comp=" & tId, DB7,
                        '         CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic)
                        'rs1 = Nothing

                        'rs1 = New Recordset
                        'rs1.Open("UPDATE Zametki SET Id_Comp=" & sSID & " where Id_Comp=" & tId, DB7,
                        '         CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic)
                        'rs1 = Nothing

                        'rs1 = New Recordset
                        'rs1.Open("Delete from Garantia_sis where Id_Comp=" & tId, DB7, CursorTypeEnum.adOpenDynamic,
                        '         LockTypeEnum.adLockOptimistic)
                        'rs1 = Nothing

                        'rs1 = New Recordset
                        'rs1.Open("Delete from kompy where id=" & tId, DB7, CursorTypeEnum.adOpenDynamic,
                        '         LockTypeEnum.adLockOptimistic)
                        'rs1 = Nothing

                        .MoveNext()
                    Loop
                End With
                rs.Close()
                rs = Nothing


            Case 5 'Сетевые фильтры

                sSQL = "SELECT id,PRINTER_NAME_1,PRINTER_SN_1,PRINTER_PROIZV_1,INV_NO_PRINTER FROM kompy where PCL=" & sSID & " and tiptehn = 'FS'"

                rs = New Recordset
                rs.Open(sSQL, DB7, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic)

                With rs
                    .MoveFirst()
                    Do While Not .EOF

                        tId = .Fields("id").Value

                        sSQL = "UPDATE kompy SET FILTR_NAME='" & rs.Fields("PRINTER_NAME_1").Value &
                           "',FILTR_SN='" & rs.Fields("PRINTER_SN_1").Value &
                           "',FILTR_PROIZV='" & rs.Fields("PRINTER_PROIZV_1").Value &
                            "' where id=" & sSID

                        DB7.Execute(sSQL)

                        'rs1 = New Recordset
                        'rs1.Open(sSQL, DB7, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic)
                        'rs1 = Nothing

                        DB7.Execute("UPDATE Remont SET Id_Comp=" & sSID & " where Id_Comp=" & tId)
                        DB7.Execute("UPDATE Zametki SET Id_Comp=" & sSID & " where Id_Comp=" & tId)
                        DB7.Execute("Delete from Garantia_sis where Id_Comp=" & tId)
                        DB7.Execute("Delete from dvig where Id_Comp=" & tId)
                        DB7.Execute("Delete from kompy where id=" & tId)

                        'rs1 = New Recordset
                        'rs1.Open("UPDATE Remont SET Id_Comp=" & sSID & " where Id_Comp=" & tId, DB7,
                        '         CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic)
                        'rs1 = Nothing

                        'rs1 = New Recordset
                        'rs1.Open("UPDATE Zametki SET Id_Comp=" & sSID & " where Id_Comp=" & tId, DB7,
                        '         CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic)
                        'rs1 = Nothing

                        'rs1 = New Recordset
                        'rs1.Open("Delete from Garantia_sis where Id_Comp=" & tId, DB7, CursorTypeEnum.adOpenDynamic,
                        '         LockTypeEnum.adLockOptimistic)
                        'rs1 = Nothing

                        'rs1 = New Recordset
                        'rs1.Open("Delete from kompy where id=" & tId, DB7, CursorTypeEnum.adOpenDynamic,
                        '         LockTypeEnum.adLockOptimistic)
                        'rs1 = Nothing

                        .MoveNext()
                    Loop
                End With
                rs.Close()
                rs = Nothing

        End Select

        rs1 = New Recordset
        rs1.Open("Select net_NAME, filial, mesto, kabn from kompy where id=" & sSID, DB7, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic)

        Dim tmpname, tmpfil, tmpdep, tmpoff, tmpid As String

        With rs1
            tmpname = .Fields("net_NAME").Value
            tmpfil = .Fields("FILIAL").Value
            tmpdep = .Fields("mesto").Value
            tmpoff = .Fields("kabn").Value
        End With

        rs1.Close()
        rs1 = Nothing

        Select Case TREE_UPDATE

            Case 0

            Case 1

                Select Case MRZD

                    Case True

                        FIND_TREE_TAG(frmComputers.lstGroups.Nodes, "C|" & sSID)

                        DV2 = True
                        Call UpdateTree(tmpname, "PC", sSID, tmpfil, tmpdep, tmpoff)


                    Case Else

                        DV2 = True

                        Call UpdateTree(tmpname, "PC", sSID, tmpfil, tmpdep, tmpoff)

                End Select

        End Select

    End Sub

    Public Sub Re_PRN(Optional ByVal sSID As Integer = 0)
        On Error GoTo err_
        Dim sADD As Boolean

        If sSID = 0 Then sSID = frmComputers.sCOUNT
        Dim rsdb As Recordset
        Dim rs As Recordset

        rsdb = New Recordset
        rsdb.Open("Select * from kompy where id=" & sSID & " and tiptehn ='PC'", DB7, CursorTypeEnum.adOpenDynamic,
                  LockTypeEnum.adLockOptimistic)


        With rsdb

            Dim sTEMP0, sTEMP1, sTEMP3 As String


            Dim objIniFile As New IniFile(PrPath & "base.ini")

            sTEMP3 = objIniFile.GetString("General", "RAZDEL", "0")

            If sTEMP3 = 0 Or sTEMP3 = 2 Then

                If Not IsDBNull(.Fields("PRINTER_NAME_1").Value) Then sTEMP0 = .Fields("PRINTER_NAME_1").Value
                If Not IsDBNull(.Fields("PORT_1").Value) Then sTEMP1 = .Fields("PORT_1").Value

                sADD = False

                If _
                    Left(sTEMP0, 2) <> "\\" And Left(sTEMP1, 2) <> "IP" And Len(sTEMP0) <> 0 And
                    sTEMP0 <> "Microsoft Office Document Image Writer" And sTEMP0 <> "Microsoft XPS Document Writer" And
                    sTEMP0 <> "Microsoft XPS Document Writer" And sTEMP0 <> "Fax" Then


                    If Not RSPRNExt(sTEMP0, sSID) Then
                        sADD = True
                        Call SaveActivityToLogDB("Добавление принтера в результате разделения " & sTEMP0)

                        ' esq 151026 картриждж и формат
                        Dim formatP As String
                        Dim cartrP As String
                        Dim sSPRAV As String
                        sSPRAV = ""
                        If RSExists("MFU", "name", Trim(rsdb.Fields("PRINTER_NAME_1").Value)) Then
                            sSPRAV = "SPR_MFU"
                        End If
                        If RSExists("PRINTERY", "name", Trim(rsdb.Fields("PRINTER_NAME_1").Value)) Then
                            sSPRAV = "SPR_PRINTER"
                        End If
                        If RSExists("KOPIRY", "name", Trim(rsdb.Fields("PRINTER_NAME_1").Value)) Then
                            sSPRAV = "SPR_KOPIR"
                        End If
                        If sSPRAV <> "" Then
                            rs = New Recordset
                            rs.Open("SELECT * FROM " & sSPRAV & " where Name='" & Trim(rsdb.Fields("PRINTER_NAME_1").Value) & "'", DB7, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic)
                            With rs
                                formatP = .Fields("A").Value
                                cartrP = .Fields("B").Value
                            End With
                            rs.Close()
                            rs = Nothing
                        End If
                        ' esq 151026

                        Dim sSQL As String

                        sSQL = "INSERT INTO kompy (D_T,TIPtehn,PRINTER_NAME_1,PRINTER_SN_1,PRINTER_PROIZV_1" &
                               ",INV_NO_PRINTER,port_1,FILIAL,mesto,kabn,OTvetstvennyj,TELEPHONE,NET_IP_1,NET_MAC_1,OS," &
                               "NET_NAME,PSEVDONIM,PCL,port_2," &
                               "SFAktNo,CenaRub,StoimRub,Zaiavk,DataVVoda,dataSF,Spisan,Balans) VALUES ('" &
                               Date.Today &
                                "', 'Printer', '" &
                                rsdb.Fields("PRINTER_NAME_1").Value & "','" &
                                rsdb.Fields("PRINTER_SN_1").Value & "','" &
                                rsdb.Fields("PRINTER_PROIZV_1").Value & "','" &
                                rsdb.Fields("INV_NO_PRINTER").Value & "','" &
                                formatP & "','" &
                                sBranch & "','" &
                                sDepartment & "','" &
                                sOffice & "','" &
                                rsdb.Fields("OTvetstvennyj").Value & "','" &
                                rsdb.Fields("TELEPHONE").Value & "'," &
                                "'', '', '" &
                                cartrP & "','" &
                                rsdb.Fields("PRINTER_NAME_1").Value & "','" &
                                rsdb.Fields("PRINTER_NAME_1").Value & "'," &
                                sSID & ",'" &
                                rsdb.Fields("port_1").Value &
                                "','0','0','0','0','" &
                                rsdb.Fields("DataVVoda").Value & "','" &
                                rsdb.Fields("dataSF").Value &
                                "',0,0)" 'esq 151026

                        DB7.Execute(sSQL)

                        'rs = New Recordset
                        'rs.Open(sSQL, DB7, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic)
                        'rs = Nothing

                        sSQL = "UPDATE kompy SET PRINTER_NAME_1='',PRINTER_SN_1='',PRINTER_PROIZV_1='',INV_NO_PRINTER='',port_1='' where id=" & sSID

                        DB7.Execute(sSQL)

                        'rs = New Recordset
                        'rs.Open(sSQL, DB7, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic)
                        'rs = Nothing

                        Dim rsBK As Recordset
                        rsBK = New Recordset
                        rsBK.Open(
                            "SELECT id FROM kompy WHERE NET_NAME='" & sTEMP0 & "' and MESTO='" & sDepartment &
                            "' and FILIAL='" & sBranch & "'  and kabn='" & sOffice & "' and PCL=" & sSID, DB7,
                            CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic)

                        Dim sPRN As String
                        With rsBK

                            sPRN = .Fields("ID").Value

                        End With
                        rsBK.Close()
                        rsBK = Nothing

                        objIniFile.WriteString("general", "DK", sPRN)
                        objIniFile.WriteString("general", "Default", 0)

                        Call FIND_TREE_TAG(frmComputers.lstGroups.Nodes, "C|" & sSID)

                        Filling_TREE_DATA(frmComputers.lstGroups, sPRN, frmComputers.lstGroups.SelectedNode, 0, 0, sTEMP0, 7)

                    End If

                End If

                If Not IsDBNull(.Fields("PRINTER_NAME_2").Value) Then sTEMP0 = .Fields("PRINTER_NAME_2").Value
                If Not IsDBNull(.Fields("PORT_2").Value) Then sTEMP1 = .Fields("PORT_2").Value

                If _
                    Left(sTEMP0, 2) <> "\\" And Left(sTEMP1, 2) <> "IP" And Len(sTEMP0) <> 0 And
                    sTEMP0 <> "Microsoft Office Document Image Writer" Then


                    If Not RSPRNExt(sTEMP0, sSID) Then

                        sADD = True
                        Call SaveActivityToLogDB("Добавление принтера в результате разделения " & sTEMP0)


                        Dim sSQL As String

                        sSQL = "INSERT INTO kompy (D_T,TIPtehn,PRINTER_NAME_1,PRINTER_SN_1,PRINTER_PROIZV_1" &
                              ",INV_NO_PRINTER,port_1,FILIAL,mesto,kabn,OTvetstvennyj,TELEPHONE,NET_IP_1,NET_MAC_1,OS,NET_NAME,PSEVDONIM,PCL,port_2," &
                              "SFAktNo,CenaRub,StoimRub,Zaiavk,DataVVoda,dataSF,Spisan,Balans) VALUES ('" &
                              Date.Today &
                               "', 'Printer', '" &
                               rsdb.Fields("PRINTER_NAME_2").Value & "','" &
                               rsdb.Fields("PRINTER_SN_2").Value & "','" &
                               rsdb.Fields("PRINTER_PROIZV_2").Value & "','" &
                               rsdb.Fields("INV_NO_PRINTER").Value & "'," &
                               "'','" &
                               sBranch & "','" &
                               sDepartment & "','" &
                               sOffice & "','" &
                               rsdb.Fields("OTvetstvennyj").Value & "','" &
                               rsdb.Fields("TELEPHONE").Value & "'," &
                               "'', '', '','" &
                               rsdb.Fields("PRINTER_NAME_2").Value & "','" &
                               rsdb.Fields("PRINTER_NAME_2").Value & "'," &
                               sSID & ",'" &
                               rsdb.Fields("port_2").Value &
                               "','0','0','0','0','" &
                               rsdb.Fields("DataVVoda").Value & "','" &
                               rsdb.Fields("dataSF").Value &
                               "',0,0)"

                        DB7.Execute(sSQL)

                        'rs = New Recordset
                        'rs.Open(sSQL, DB7, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic)
                        'rs = Nothing

                        sSQL = "UPDATE kompy SET PRINTER_NAME_2='',PRINTER_SN_2='',PRINTER_PROIZV_2='',INV_NO_PRINTER='',port_2='' where id=" & sSID

                        DB7.Execute(sSQL)

                        'rs = New Recordset
                        'rs.Open(sSQL, DB7, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic)
                        'rs = Nothing

                        Dim rsBK As Recordset
                        rsBK = New Recordset
                        rsBK.Open(
                            "SELECT id FROM kompy WHERE NET_NAME='" & sTEMP0 & "' and MESTO='" & sDepartment &
                            "' and FILIAL='" & sBranch & "'  and kabn='" & sOffice & "' and PCL=" & sSID, DB7,
                            CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic)

                        Dim sPRN As String
                        With rsBK

                            sPRN = .Fields("ID").Value

                        End With
                        rsBK.Close()
                        rsBK = Nothing


                        objIniFile.WriteString("general", "DK", sPRN)
                        objIniFile.WriteString("general", "Default", 0)

                        Select Case TREE_UPDATE

                            Case 0

                            Case 1

                                Call FIND_TREE_TAG(frmComputers.lstGroups.Nodes, "C|" & sSID)
                                Filling_TREE_DATA(frmComputers.lstGroups, sPRN, frmComputers.lstGroups.SelectedNode, 0, 0, sTEMP0, 7)

                        End Select


                    End If
                End If


                If Not IsDBNull(.Fields("PRINTER_NAME_3").Value) Then sTEMP0 = .Fields("PRINTER_NAME_3").Value
                If Not IsDBNull(.Fields("PORT_3").Value) Then sTEMP1 = .Fields("PORT_3").Value

                If _
                    Left(sTEMP0, 2) <> "\\" And Left(sTEMP1, 2) <> "IP" And Len(sTEMP0) <> 0 And
                    sTEMP0 <> "Microsoft Office Document Image Writer" Then

                    If Not RSPRNExt(sTEMP0, sSID) Then
                        sADD = True

                        Call SaveActivityToLogDB("Добавление принтера в результате разделения " & sTEMP0)

                        ' Dim rs As Recordset
                        Dim sSQL As String

                        sSQL = "INSERT INTO kompy (D_T,TIPtehn,PRINTER_NAME_1,PRINTER_SN_1,PRINTER_PROIZV_1" &
                              ",INV_NO_PRINTER,port_1,FILIAL,mesto,kabn,OTvetstvennyj,TELEPHONE,NET_IP_1,NET_MAC_1,OS,NET_NAME,PSEVDONIM,PCL,port_2," &
                              "SFAktNo,CenaRub,StoimRub,Zaiavk,DataVVoda,dataSF,Spisan,Balans) VALUES ('" &
                              Date.Today &
                               "', 'Printer', '" &
                               rsdb.Fields("PRINTER_NAME_3").Value & "','" &
                               rsdb.Fields("PRINTER_SN_3").Value & "','" &
                               rsdb.Fields("PRINTER_PROIZV_3").Value & "','" &
                               rsdb.Fields("INV_NO_PRINTER").Value & "'," &
                               "'','" &
                               sBranch & "','" &
                               sDepartment & "','" &
                               sOffice & "','" &
                               rsdb.Fields("OTvetstvennyj").Value & "','" &
                               rsdb.Fields("TELEPHONE").Value & "'," &
                               "'', '', '','" &
                               rsdb.Fields("PRINTER_NAME_3").Value & "','" &
                               rsdb.Fields("PRINTER_NAME_3").Value & "'," &
                               sSID & ",'" &
                               rsdb.Fields("port_3").Value &
                               "','0','0','0','0','" &
                               rsdb.Fields("DataVVoda").Value & "','" &
                               rsdb.Fields("dataSF").Value &
                               "',0,0)"

                        DB7.Execute(sSQL)

                        'rs = New Recordset
                        'rs.Open(sSQL, DB7, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic)
                        'rs = Nothing

                        sSQL = "UPDATE kompy SET PRINTER_NAME_3='',PRINTER_SN_3='',PRINTER_PROIZV_3='',INV_NO_PRINTER='',port_3='' where id=" & sSID

                        DB7.Execute(sSQL)

                        'rs = New Recordset
                        'rs.Open(sSQL, DB7, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic)
                        'rs = Nothing

                        Dim rsBK As Recordset
                        rsBK = New Recordset
                        rsBK.Open(
                            "SELECT id FROM kompy WHERE NET_NAME='" & sTEMP0 & "' and MESTO='" & sDepartment &
                            "' and FILIAL='" & sBranch & "'  and kabn='" & sOffice & "' and PCL=" & sSID, DB7,
                            CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic)

                        Dim sPRN As String
                        With rsBK

                            sPRN = .Fields("ID").Value

                        End With
                        rsBK.Close()
                        rsBK = Nothing

                        objIniFile.WriteString("general", "DK", sPRN)
                        objIniFile.WriteString("general", "Default", 0)

                        Select Case TREE_UPDATE

                            Case 0

                            Case 1

                                Call FIND_TREE_TAG(frmComputers.lstGroups.Nodes, "C|" & sSID)
                                Filling_TREE_DATA(frmComputers.lstGroups, sPRN, frmComputers.lstGroups.SelectedNode, 0, 0, sTEMP0, 7)

                        End Select

                    End If
                End If

            End If

            If sTEMP3 = 0 Or sTEMP3 = 1 Then
                'МОНИТОР
                If Not IsDBNull(.Fields("MONITOR_NAME").Value) Then sTEMP0 = .Fields("MONITOR_NAME").Value

                If Left(sTEMP0, 2) <> "Мо" And Len(sTEMP0) <> 0 Then

                    If Not RSPRNExt(sTEMP0, sSID) Then
                        sADD = True
                        Call SaveActivityToLogDB("Добавление монитора в результате разделения " & sTEMP0)

                        Dim sSQL As String

                        sSQL = "INSERT INTO kompy (MONITOR_NAME,MONITOR_DUM,MONITOR_SN,MONITOR_PROIZV,port_1,INV_NO_MONITOR,OTvetstvennyj,TELEPHONE,NET_NAME,PSEVDONIM,PCL,D_T,TIPtehn,FILIAL,mesto,kabn," &
                            "SFAktNo,CenaRub,StoimRub,Zaiavk,DataVVoda,dataSF,Spisan,Balans) VALUES ('" &
                            rsdb.Fields("MONITOR_NAME").Value & "','" & rsdb.Fields("MONITOR_DUM").Value & "','" & rsdb.Fields("MONITOR_SN").Value & "','" &
                            rsdb.Fields("MONITOR_PROIZV").Value & "','','" & rsdb.Fields("INV_NO_MONITOR").Value & "','" &
                             rsdb.Fields("OTvetstvennyj").Value & "','" & rsdb.Fields("TELEPHONE").Value & "','" & rsdb.Fields("MONITOR_NAME").Value & "','" &
                             rsdb.Fields("MONITOR_NAME").Value & "'," & sSID & ",'" & Date.Today & "','" &
                             "MONITOR" & "','" & sBranch & "','" & sDepartment & "','" & sOffice & "','0','0','0','0','" & rsdb.Fields("DataVVoda").Value & "','" & rsdb.Fields("dataSF").Value & "',0,0)"

                        DB7.Execute(sSQL)

                        'rs = New Recordset
                        'rs.Open(sSQL, DB7, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic)
                        'rs = Nothing

                        sSQL = "UPDATE kompy SET MONITOR_NAME='',MONITOR_DUM='',MONITOR_SN='',MONITOR_PROIZV='',INV_NO_MONITOR='' where id=" & sSID

                        DB7.Execute(sSQL)

                        'rs = New Recordset
                        'rs.Open(sSQL, DB7, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic)
                        'rs = Nothing

                        On Error Resume Next

                        Dim rsBK As Recordset
                        rsBK = New Recordset
                        rsBK.Open(
                            "SELECT id FROM kompy WHERE MONITOR_NAME='" & sTEMP0 & "' and MESTO='" & sDepartment &
                            "' and FILIAL='" & sBranch & "' and kabn='" & sOffice & "' and PCL=" & sSID, DB7,
                            CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic)

                        Dim sPRN As String
                        With rsBK

                            sPRN = .Fields("ID").Value

                        End With
                        rsBK.Close()
                        rsBK = Nothing

                        objIniFile.WriteString("general", "DK", sPRN)
                        objIniFile.WriteString("general", "Default", 0)

                        Select Case TREE_UPDATE

                            Case 0

                            Case 1

                                Call FIND_TREE_TAG(frmComputers.lstGroups.Nodes, "C|" & sSID)
                                Filling_TREE_DATA(frmComputers.lstGroups, sPRN, frmComputers.lstGroups.SelectedNode, 0, 0, sTEMP0, 17)

                        End Select

                    End If
                End If

            End If

            If sTEMP3 = 0 Or sTEMP3 = 3 Then
                'ИБП

                If Not IsDBNull(.Fields("IBP_NAME").Value) Then sTEMP0 = .Fields("IBP_NAME").Value

                If Left(sTEMP0, 2) <> "Мо" And Len(sTEMP0) <> 0 Then

                    If Not RSPRNExt(sTEMP0, sSID) Then

                        sADD = True
                        Call SaveActivityToLogDB("Добавление ИБП в результате разделения " & sTEMP0)

                        Dim sSQL As String

                        If Not RSExists("SPR_IBP", "name", Trim(sTEMP0)) Then
                            AddTwoPar(sTEMP0, rsdb.Fields("IBP_PROIZV").Value, "SPR_IBP", frmComputers.cmbOTH)
                        End If

                        sSQL = "INSERT INTO kompy (PRINTER_NAME_1,PRINTER_SN_1,IBP_PROIZV,OTvetstvennyj,TELEPHONE,NET_NAME,PSEVDONIM,PCL,TIPtehn,INV_NO_PRINTER,FILIAL,mesto,kabn," &
                            "SFAktNo,CenaRub,StoimRub,Zaiavk,DataVVoda,dataSF,Spisan,Balans) VALUES ('" &
                                sTEMP0 & "','" & rsdb.Fields("IBP_SN").Value & "','" & rsdb.Fields("IBP_PROIZV").Value & "','" & rsdb.Fields("OTvetstvennyj").Value & "','" & rsdb.Fields("TELEPHONE").Value & "','" &
                                sTEMP0 & "','" & sTEMP0 & "'," & sSID & ",'" &
                                "IBP" & "','" & rsdb.Fields("INV_NO_IBP").Value & "','" & sBranch & "','" & sDepartment & "','" & sOffice & "','0','0','0','0','" & rsdb.Fields("DataVVoda").Value & "','" & rsdb.Fields("dataSF").Value & "',0,0)"

                        DB7.Execute(sSQL)

                        'rs = New Recordset
                        'rs.Open(sSQL, DB7, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic)
                        'rs = Nothing

                        sSQL = "UPDATE kompy SET IBP_NAME='',IBP_SN='',IBP_PROIZV='',INV_NO_IBP='' where id=" & sSID

                        DB7.Execute(sSQL)

                        'rs = New Recordset
                        'rs.Open(sSQL, DB7, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic)
                        'rs = Nothing

                        Dim rsBK As Recordset
                        rsBK = New Recordset
                        rsBK.Open(
                            "SELECT id FROM kompy WHERE PRINTER_NAME_1='" & sTEMP0 & "' and MESTO='" & sDepartment &
                            "' and FILIAL='" & sBranch & "'  and kabn='" & sOffice & "' and PCL=" & sSID, DB7,
                            CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic)

                        Dim sPRN As String
                        With rsBK

                            sPRN = .Fields("ID").Value

                        End With
                        rsBK.Close()
                        rsBK = Nothing

                        objIniFile.WriteString("general", "DK", sPRN)
                        objIniFile.WriteString("general", "Default", 0)

                        Select Case TREE_UPDATE

                            Case 0

                            Case 1

                                Call FIND_TREE_TAG(frmComputers.lstGroups.Nodes, "C|" & sSID)
                                Filling_TREE_DATA(frmComputers.lstGroups, sPRN, frmComputers.lstGroups.SelectedNode, 0, 0, sTEMP0, 41)

                        End Select

                    End If
                End If

            End If


            '#################################################
            'Клавиатура+Мышь
            If sTEMP3 = 0 Or sTEMP3 = 4 Then

                If Not IsDBNull(.Fields("KEYBOARD_NAME").Value) Then sTEMP0 = .Fields("KEYBOARD_NAME").Value

                If Left(sTEMP0, 2) <> "Мо" And Len(sTEMP0) <> 0 Then

                    If Not RSPRNExt(sTEMP0, sSID) Then

                        sADD = True
                        Call SaveActivityToLogDB("Добавление Клавиатуры в результате разделения " & sTEMP0)

                        Dim sSQL As String


                        If Not RSExists("KEYBOARD", "name", Trim(sTEMP0)) Then
                            AddTwoPar(sTEMP0, rsdb.Fields("KEYBOARD_PROIZV").Value, "SPR_KEYBOARD", frmComputers.cmbOTH)
                        End If

                        'esq rs = New Recordset
                        'esq rs.Open(sSQL, DB7, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic)

                        sSQL = "INSERT INTO kompy (PRINTER_NAME_1,PRINTER_SN_1,PRINTER_PROIZV_1,OTvetstvennyj,TELEPHONE,NET_NAME,PSEVDONIM,PCL,TIPtehn,INV_NO_PRINTER,FILIAL,mesto,kabn," &
                           "SFAktNo,CenaRub,StoimRub,Zaiavk,DataVVoda,dataSF,Spisan,Balans) VALUES ('" &
                               sTEMP0 & "','" & rsdb.Fields("KEYBOARD_SN").Value & "','" & rsdb.Fields("KEYBOARD_PROIZV").Value & "','" & rsdb.Fields("OTvetstvennyj").Value & "','" & rsdb.Fields("TELEPHONE").Value & "','" &
                               sTEMP0 & "','" & sTEMP0 & "'," & sSID & ",'" &
                               "KEYB" & "','" & rsdb.Fields("INV_NO_IBP").Value & "','" & sBranch & "','" & sDepartment & "','" & sOffice & "','0','0','0','0','" & rsdb.Fields("DataVVoda").Value & "','" & rsdb.Fields("dataSF").Value & "',0,0)"

                        DB7.Execute(sSQL)

                        'rs = New Recordset
                        'rs.Open(sSQL, DB7, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic)
                        'rs = Nothing

                        sSQL = "UPDATE kompy SET KEYBOARD_NAME='',KEYBOARD_SN='',KEYBOARD_PROIZV='' where id=" & sSID

                        DB7.Execute(sSQL)

                        'rs = New Recordset
                        'rs.Open(sSQL, DB7, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic)
                        'rs = Nothing

                        Dim rsBK As Recordset
                        rsBK = New Recordset
                        rsBK.Open(
                            "SELECT id FROM kompy WHERE PRINTER_NAME_1='" & sTEMP0 & "' and MESTO='" & sDepartment &
                            "' and FILIAL='" & sBranch & "'  and kabn='" & sOffice & "' and PCL=" & sSID, DB7,
                            CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic)

                        Dim sPRN As String
                        With rsBK

                            sPRN = .Fields("ID").Value

                        End With
                        rsBK.Close()
                        rsBK = Nothing

                        objIniFile.WriteString("general", "DK", sPRN)
                        objIniFile.WriteString("general", "Default", 0)

                        Select Case TREE_UPDATE

                            Case 0

                            Case 1

                                Call FIND_TREE_TAG(frmComputers.lstGroups.Nodes, "C|" & sSID)
                                Filling_TREE_DATA(frmComputers.lstGroups, sPRN, frmComputers.lstGroups.SelectedNode, 0, 0, sTEMP0, 46)

                        End Select

                    End If
                End If

                '#########################################################
                'Мышь
                If Not IsDBNull(.Fields("MOUSE_NAME").Value) Then sTEMP0 = .Fields("MOUSE_NAME").Value

                If Left(sTEMP0, 2) <> "Мо" And Len(sTEMP0) <> 0 Then

                    If Not RSPRNExt(sTEMP0, sSID) Then

                        sADD = True
                        Call SaveActivityToLogDB("Добавление Мыши в результате разделения " & sTEMP0)

                        Dim sSQL As String

                        If Not RSExists("MOUSE", "name", Trim(sTEMP0)) Then
                            AddTwoPar(sTEMP0, rsdb.Fields("MOUSE_PROIZV").Value, "SPR_MOUSE", frmComputers.cmbOTH)
                        End If


                        sSQL = "INSERT INTO kompy (PRINTER_NAME_1,PRINTER_SN_1,PRINTER_PROIZV_1,OTvetstvennyj,TELEPHONE,NET_NAME,PSEVDONIM,PCL,TIPtehn,INV_NO_PRINTER,FILIAL,mesto,kabn," &
                          "SFAktNo,CenaRub,StoimRub,Zaiavk,DataVVoda,dataSF,Spisan,Balans) VALUES ('" &
                              sTEMP0 & "','" & rsdb.Fields("MOUSE_SN").Value & "','" & rsdb.Fields("MOUSE_PROIZV").Value & "','" & rsdb.Fields("OTvetstvennyj").Value & "','" & rsdb.Fields("TELEPHONE").Value & "','" &
                              sTEMP0 & "','" & sTEMP0 & "'," & sSID & ",'" &
                              "MOUSE" & "','" & rsdb.Fields("INV_NO_IBP").Value & "','" & sBranch & "','" & sDepartment & "','" & sOffice & "','0','0','0','0','" & rsdb.Fields("DataVVoda").Value & "','" & rsdb.Fields("dataSF").Value & "',0,0)"

                        DB7.Execute(sSQL)

                        'rs = New Recordset
                        'rs.Open(sSQL, DB7, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic)
                        'rs = Nothing

                        sSQL = "UPDATE kompy SET MOUSE_NAME='',MOUSE_SN='',MOUSE_PROIZV='' where id=" & sSID

                        DB7.Execute(sSQL)

                        'rs = New Recordset
                        'rs.Open(sSQL, DB7, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic)
                        'rs = Nothing

                        Dim rsBK As Recordset
                        rsBK = New Recordset
                        rsBK.Open(
                            "SELECT id FROM kompy WHERE PRINTER_NAME_1='" & sTEMP0 & "' and MESTO='" & sDepartment &
                            "' and FILIAL='" & sBranch & "'  and kabn='" & sOffice & "' and PCL=" & sSID, DB7,
                            CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic)

                        Dim sPRN As String
                        With rsBK

                            sPRN = .Fields("ID").Value

                        End With
                        rsBK.Close()
                        rsBK = Nothing

                        objIniFile.WriteString("general", "DK", sPRN)
                        objIniFile.WriteString("general", "Default", 0)

                        Select Case TREE_UPDATE

                            Case 0

                            Case 1

                                Call FIND_TREE_TAG(frmComputers.lstGroups.Nodes, "C|" & sSID)
                                Filling_TREE_DATA(frmComputers.lstGroups, sPRN, frmComputers.lstGroups.SelectedNode, 0, 0, sTEMP0, 47)

                        End Select

                    End If
                End If

            End If

            '#################################################


            '#################################################
            'Сетевой фильтр
            If sTEMP3 = 0 Or sTEMP3 = 5 Then

                If Not IsDBNull(.Fields("FILTR_NAME").Value) Then sTEMP0 = .Fields("FILTR_NAME").Value

                If Left(sTEMP0, 2) <> "Мо" And Len(sTEMP0) <> 0 Then

                    If Not RSPRNExt(sTEMP0, sSID) Then

                        sADD = True
                        Call SaveActivityToLogDB("Добавление Сетевого фильтра в результате разделения " & sTEMP0)

                        Dim sSQL As String

                        If Not RSExists("OTHER", "name", Trim("Сетевой фильтр")) Then

                            sSQL = "INSERT INTO spr_other (name,A) VALUES ('Сетевой фильтр',48)"

                            DB7.Execute(sSQL)

                        End If

                        If Not RSExists("OTHD", "name", Trim(sTEMP0)) Then
                            AddTreePar(sTEMP0, "Сетевой фильтр", rsdb.Fields("FILTR_PROIZV").Value, "SPR_OTH_DEV",
                                       frmComputers.cmbOTH)
                        End If


                        sSQL = "INSERT INTO kompy (PRINTER_NAME_1,PRINTER_SN_1,PRINTER_PROIZV_1,OTvetstvennyj,TELEPHONE,NET_NAME,PSEVDONIM,PCL,TIPtehn,INV_NO_PRINTER,FILIAL,mesto,kabn," &
                          "SFAktNo,CenaRub,StoimRub,Zaiavk,DataVVoda,dataSF,Spisan,Balans) VALUES ('" &
                              sTEMP0 & "','" & rsdb.Fields("FILTR_SN").Value & "','" & rsdb.Fields("FILTR_PROIZV").Value & "','" & rsdb.Fields("OTvetstvennyj").Value & "','" & rsdb.Fields("TELEPHONE").Value & "','" &
                              sTEMP0 & "','" & sTEMP0 & "'," & sSID & ",'" &
                              "FS" & "','" & rsdb.Fields("INV_NO_IBP").Value & "','" & sBranch & "','" & sDepartment & "','" & sOffice & "','0','0','0','0','" & rsdb.Fields("DataVVoda").Value & "','" & rsdb.Fields("dataSF").Value & "',0,0)"

                        DB7.Execute(sSQL)

                        'rs = New Recordset
                        'rs.Open(sSQL, DB7, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic)
                        'rs = Nothing

                        sSQL = "UPDATE kompy SET FILTR_NAME='',FILTR_SN='',FILTR_PROIZV='' where id=" & sSID

                        DB7.Execute(sSQL)

                        'rs = New Recordset
                        'rs.Open(sSQL, DB7, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic)
                        'rs = Nothing

                        Dim rsBK As Recordset
                        rsBK = New Recordset
                        rsBK.Open(
                            "SELECT id FROM kompy WHERE PRINTER_NAME_1='" & sTEMP0 & "' and MESTO='" & sDepartment &
                            "' and FILIAL='" & sBranch & "'  and kabn='" & sOffice & "' and PCL=" & sSID, DB7,
                            CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic)

                        Dim sPRN As String
                        With rsBK

                            sPRN = .Fields("ID").Value

                            Select Case TREE_UPDATE

                                Case 0

                                Case 1

                                    Call FIND_TREE_TAG(frmComputers.lstGroups.Nodes, "C|" & sSID)
                                    Filling_TREE_DATA(frmComputers.lstGroups, sSID, frmComputers.lstGroups.SelectedNode, 0, 0, sTEMP0, 61)

                            End Select

                        End With
                        rsBK.Close()
                        rsBK = Nothing

                        objIniFile.WriteString("general", "DK", sPRN)
                        objIniFile.WriteString("general", "Default", 0)

                    End If
                End If


            End If


        End With

        rsdb.Close()
        rsdb = Nothing


        If MRZD = True Then Exit Sub

        If sADD = True Then

            '  If TREE_UPDATE = 0 Then RefFilTree(frmComputers.lstGroups) Else frmComputers.LOAD_LIST()

            Select Case TREE_UPDATE

                Case 0
                    RefFilTree(frmComputers.lstGroups)
                Case 1

            End Select


        End If


        Exit Sub

err_:
        MsgBox(Err.Description)

        If MRZD = True Then Exit Sub

        If sADD = True Then

            Select Case TREE_UPDATE

                Case 0
                    RefFilTree(frmComputers.lstGroups)
                Case 1

            End Select

        End If
    End Sub

    Private Function RSPRNExt(ByVal sPRN As String, ByVal sPCL As String)

        RSPRNExt = False

        Dim rs As Recordset
        Dim sSQL As String

        sSQL = "SELECT count(*) as t_n FROM kompy where NET_NAME ='" & sPRN & "' and PCL=" & sPCL

        rs = New Recordset
        rs.Open(sSQL, DB7, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic)


        With rs
            If .Fields("t_n").Value = 0 Then

            Else

                RSPRNExt = True
                rs.Close()
                rs = Nothing
                Exit Function

            End If
        End With


        RSPRNExt = False

        Exit Function
Error_:
        RSPRNExt = False
    End Function

    Public Sub NotesEditAdd(ByVal btAdd As ToolStripButton, ByVal lvsNotes As ListView, ByVal NotesMaster As ComboBox,
                            ByVal textNotes As TextBox, ByVal DateNotes As DateTimePicker, ByVal txtSNAME As String,
                            ByVal Branch As ComboBox, ByVal Department As ComboBox, ByVal Office As ComboBox)

        On Error GoTo err_

        Dim strSimbol1, strSimbol2 As String
        strSimbol1 = "'" : strSimbol2 = "."

        textNotes.Text = Replace(textNotes.Text, strSimbol1, "")
        NotesMaster.Text = Replace(NotesMaster.Text, strSimbol1, "")

        If Len(textNotes.Text) = 0 Then Exit Sub

        Dim sSQL As String
        Dim langfile As New IniFile(sLANGPATH)

        Dim uname As String

        uname = Branch.Text

        If Len(Department.Text) <> 0 Then
            uname = uname & "/" & Department.Text
        End If

        If Len(Office.Text) <> 0 Then
            uname = uname & "/" & Office.Text
        End If

        Dim dataSF1() As String

        dataSF1 = Split(DateNotes.Value, " ")

        If btAdd.Text = langfile.GetString("frmComputers", "MSG30", "Добавить") Then

            Call _
                SaveActivityToLogDB(
                    langfile.GetString("frmComputers", "MSG45", "Добавление заметки для") & " " &
                    frmComputers.lstGroups.SelectedNode.Text)

            sSQL = "INSERT INTO Zametki (NomerZamKomp,Master,Zametki,D_T,Id_Comp,Comp_name,Mesto_Compa) VALUES (" & lvsNotes.Items.Count + 1 & ",'" & NotesMaster.Text & "','" & textNotes.Text & "','" & dataSF1(0) & "'," & frmComputers.sCOUNT & ",'" & txtSNAME & "','" & uname & "')"
            DB7.Execute(sSQL)


        Else
            Call _
                SaveActivityToLogDB(
                    langfile.GetString("frmComputers", "MSG46", "Редактирование заметки для") & " " &
                    frmComputers.lstGroups.SelectedNode.Text)

            sSQL = "UPDATE Zametki SET Master='" & NotesMaster.Text & "',Zametki='" & textNotes.Text & "',D_T='" & dataSF1(0) & "' WHERE id =" & frmComputers.zCOUNT

            DB7.Execute(sSQL)

        End If

        btAdd.Text = langfile.GetString("frmComputers", "MSG30", "Добавить")
        DateNotes.Value = Date.Today
        NotesMaster.Text = ""
        textNotes.Text = ""

        Call LOAD_NOTES(frmComputers.sCOUNT, lvsNotes)

        Exit Sub
err_:
        MsgBox(Err.Description)
    End Sub

    Public Sub NET_PORT_ED(Optional ByVal sSID As String = "")

        Dim langfile As New IniFile(sLANGPATH)


        If frmComputers.portEDT = True Then
        Else
            If frmComputers.lvNetPort.Items.Count >= frmComputers.txtNetPort.Text Then
                MsgBox(
                    langfile.GetString("frmComputers", "MSG47",
                                       "Количество портов достигло допустимого предела для этого устройства"),
                    MsgBoxStyle.Information, ProGramName)
                Exit Sub
            End If
        End If

        Dim sSQL As String

        Select Case frmComputers.portEDT

            Case False

                sSQL = "INSERT INTO net_port (id_net,port,net_n,mac) VALUES (" & frmComputers.sCOUNT & ",'" & frmComputers.txtNetnumberPort.Text & "','" & frmComputers.txtNetPortMapping.Text & "','" & frmComputers.txtNetPortMac.Text & "') "

            Case True

                sSQL = "UPDATE net_port SET id_net=" & frmComputers.sCOUNT & ",port='" & frmComputers.txtNetnumberPort.Text & "',net_n='" & frmComputers.txtNetPortMapping.Text & "',mac='" & frmComputers.txtNetPortMac.Text & "' WHERE id=" & sSID

        End Select

        DB7.Execute(sSQL)

        'Dim rs As Recordset
        'rs = New Recordset
        'rs.Open(sSQL, DB7, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic)
        'rs = Nothing

        frmComputers.portEDT = False
        frmComputers.txtNetnumberPort.Text = ""
        frmComputers.txtNetPortMapping.Text = ""
        frmComputers.txtNetPortMac.Text = ""

        LOAD_NET_PORT(frmComputers.sCOUNT)
    End Sub

    Public Sub BR_NOTES_ADD()

        If Len(frmComputers.Notesbrtxt.Text) = 0 Then Exit Sub

        Dim StrS As String

        Dim langfile As New IniFile(sLANGPATH)

        Select Case frmComputers.sPREF

            Case "C"

            Case "G"
                StrS = frmComputers.sCOUNT & "F"

            Case "O"
                StrS = frmComputers.sCOUNT & "O_F"

            Case "K"
                StrS = frmComputers.sCOUNT & "K"

        End Select

        Dim sSQL As String

        Dim strSimbol1, strSimbol2 As String
        strSimbol1 = "'" : strSimbol2 = "."

        frmComputers.Notesbrtxt.Text = Replace(frmComputers.Notesbrtxt.Text, strSimbol1, "")
        frmComputers.cmbBRMaster.Text = Replace(frmComputers.cmbBRMaster.Text, strSimbol1, "")

        If frmComputers.btnBRNotesAdd.Text = langfile.GetString("frmComputers", "MSG42", "Сохранить") Then

            Dim z As Integer

            For z = 0 To frmComputers.lvNotesBR.SelectedItems.Count - 1
                frmComputers.zCOUNT = (frmComputers.lvNotesBR.SelectedItems(z).Text)
            Next

            sSQL = "INSERT INTO ZAM_OTD (ID_ZAM,ID_OTD,D_T,ZAMETKA,Master) VALUES (" & frmComputers.lvNotesBR.Items.Count + 1 & "," & StrS & ",'" & frmComputers.Notesbrdate.Value & "','" & frmComputers.Notesbrtxt.Text & "','" & frmComputers.cmbBRMaster.Text & "') "

        Else

            sSQL = "UPDATE ZAM_OTD SET D_T='" & frmComputers.Notesbrdate.Value & "',ZAMETKA='" & frmComputers.Notesbrtxt.Text & "',Master='" & frmComputers.cmbBRMaster.Text & "' WHERE id=" & frmComputers.zCOUNT

        End If

        DB7.Execute(sSQL)


        'Dim rs As Recordset
        'rs = New Recordset
        'rs.Open(sSQL, DB7, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic)
        'rs = Nothing

        LOAD_INF_BRANCHE(frmComputers.sCOUNT)
        Notes_Clear(frmComputers.btnBRNotesAdd, frmComputers.Notesbrdate, frmComputers.cmbBRMaster,
                    frmComputers.Notesbrtxt)
    End Sub

    Private Sub SMENA_PCL(ByVal sID As Integer, ByVal sTEXT As String)
        On Error GoTo Error_

        Dim rs As Recordset
        rs = New Recordset
        rs.Open("SELECT pcl FROM kompy where id=" & sID, DB7,
                CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic)

        Dim sCN As Integer
        Dim sTEXT2 As String

        With rs
            sCN = .Fields("pcl").Value
        End With
        rs.Close()
        rs = Nothing

        Select Case sCN

            Case 0

                sTEXT2 = ""

            Case Else

                rs = New Recordset
                rs.Open("SELECT NET_NAME FROM kompy where id=" & sCN, DB7, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic)

                With rs
                    sTEXT2 = .Fields("NET_NAME").Value
                End With
                rs.Close()
                rs = Nothing

        End Select

        If sTEXT2 = sTEXT Then Exit Sub

        DV2 = True

Error_:
        Exit Sub

    End Sub

End Module
