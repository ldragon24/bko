Public Class frm_os3
    Public sEDT As Boolean

    Private Sub Button2_Click(ByVal sender As Object, ByVal e As EventArgs) Handles Button2.Click
        Me.Close()
    End Sub

    Private Sub Button1_Click(ByVal sender As Object, ByVal e As EventArgs) Handles Button1.Click

        Dim AKT_SP_OS3 As Recordset
        Dim sSQL As String


        If Len(txtActNumber.Text) = 0 Then

            sSQL = "SELECT count(*) as t_n FROM AKT_SP_OS3"
            AKT_SP_OS3 = New Recordset
            AKT_SP_OS3.Open(sSQL, DB7, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic)

            With AKT_SP_OS3
                txtActNumber.Text = .Fields("t_n").Value + 1
            End With

            AKT_SP_OS3.Close()
            AKT_SP_OS3 = Nothing

        End If


        If Me.sEDT = False Then

            sSQL = "SELECT * FROM AKT_SP_OS3"

        Else

            sSQL = "SELECT * FROM AKT_SP_OS3 where id=" & frmAct_Treb.dSID

        End If


        AKT_SP_OS3 = New Recordset
        AKT_SP_OS3.Open(sSQL, DB7, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic)

        With AKT_SP_OS3
            If Me.sEDT = False Then
                .AddNew()
                .Fields("ID_COMP").Value = frmComputers.sCOUNT
            Else

            End If

            .Fields("Nomer").Value = txtActNumber.Text
            .Fields("DATAV").Value = dtVip.Value
            .Fields("KOMPL").Value = cmbCPL.Text
            .Fields("Model").Value = cmbModCPL.Text
            .Fields("GODPR").Value = txtYearPubl.Text
            .Fields("DATAPOST").Value = dtPOST.Value
            .Fields("STOIM").Value = txtBalCashe.Text
            .Fields("KolvoRem").Value = txtKolRem.Text
            .Fields("DATAPK").Value = dtPosKapRem.Value
            .Fields("opis").Value = txtDef.Text

            .Update()
        End With
        AKT_SP_OS3.Close()
        AKT_SP_OS3 = Nothing


        Me.sEDT = False

        Call frmAct_Treb.ACTOS3_LOAD()

        Me.Close()
    End Sub

    Private Sub frm_os3_Load(ByVal sender As Object, ByVal e As EventArgs) Handles Me.Load

        SendFonts(Me)

        Call LANG_frm_os3()


        FillComboNET(cmbCPL, "Name", "SPR_Complect", "", False, True)


        If sEDT = False Then

            Dim sSQL As String
            Dim rs As Recordset


            sSQL = "SELECT count(*) as t_n FROM AKT_SP_OS3"
            rs = New Recordset
            rs.Open(sSQL, DB7, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic)

            With rs
                txtActNumber.Text = .Fields("t_n").Value + 1
            End With

            rs.Close()
            rs = Nothing

        End If
    End Sub

    Private Sub cmbCPL_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) _
        Handles cmbCPL.SelectedIndexChanged
        cmbModCPL.Items.Clear()
        Dim objIniFile As New IniFile(sLANGPATH)



        On Error GoTo err_
        Dim rs As Recordset
        Dim sSQL As String

        Select Case cmbCPL.Text

            Case objIniFile.GetString("frm_os3", "cmbCPL1", "Оптический привод")

                sSQL = "SELECT CD_NAME, CDRW_NAME, DVD_NAME from kompy where id=" & frmComputers.sCOUNT

            Case objIniFile.GetString("frm_os3", "cmbCPL2", "Блок питания")

                sSQL = "SELECT BLOCK from kompy where id=" & frmComputers.sCOUNT

            Case objIniFile.GetString("frm_os3", "cmbCPL3", "Видео карта")

                sSQL = "SELECT SVGA_NAME from kompy where id=" & frmComputers.sCOUNT

            Case objIniFile.GetString("frm_os3", "cmbCPL4", "Жесткий диск")

                sSQL = "SELECT HDD_Name_1, HDD_Name_2, HDD_Name_3, HDD_Name_4 from kompy where id=" &
                       frmComputers.sCOUNT

            Case objIniFile.GetString("frm_os3", "cmbCPL5", "Звуковая карта")

                sSQL = "SELECT SOUND_NAME from kompy where id=" & frmComputers.sCOUNT

            Case objIniFile.GetString("frm_os3", "cmbCPL6", "ИБП")

                sSQL = "SELECT IBP_NAME from kompy where id=" & frmComputers.sCOUNT

            Case objIniFile.GetString("frm_os3", "cmbCPL7", "Корпус")

                sSQL = "SELECT CASE_NAME from kompy where id=" & frmComputers.sCOUNT

            Case objIniFile.GetString("frm_os3", "cmbCPL8", "Материнская плата")

                sSQL = "SELECT Mb from kompy where id=" & frmComputers.sCOUNT

            Case objIniFile.GetString("frm_os3", "cmbCPL9", "Модем")

                sSQL = "SELECT MODEM_NAME from kompy where id=" & frmComputers.sCOUNT

            Case objIniFile.GetString("frm_os3", "cmbCPL10", "Модуль памяти")

                sSQL = "SELECT RAM_1, RAM_2, RAM_3, RAM_4 from kompy where id=" & frmComputers.sCOUNT

            Case objIniFile.GetString("frm_os3", "cmbCPL11", "Монитор")

                sSQL = "SELECT MONITOR_NAME, MONITOR_NAME2 from kompy where id=" & frmComputers.sCOUNT

            Case objIniFile.GetString("frm_os3", "cmbCPL12", "Принтер")

                sSQL = "SELECT PRINTER_NAME_1, PRINTER_NAME_2, PRINTER_NAME_3 from kompy where id=" &
                       frmComputers.sCOUNT

            Case objIniFile.GetString("frm_os3", "cmbCPL13", "Процессор")

                sSQL = "SELECT CPU1, CPU2, CPU3, CPU4 from kompy where id=" & frmComputers.sCOUNT

            Case objIniFile.GetString("frm_os3", "cmbCPL14", "Сетевой адаптер")

                sSQL = "SELECT NET_NAME_1, NET_NAME_2 from kompy where id=" & frmComputers.sCOUNT

            Case Else


        End Select

        If Len(sSQL) = 0 Then Exit Sub

        rs = New Recordset
        rs.Open(sSQL, DB7, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic)

        Dim FirstColumn As Boolean

        With rs
            .MoveFirst()
            Do While Not .EOF

                FirstColumn = True

                For lngCounter = 0 To 184

                    If FirstColumn Then

                        If Not IsDBNull(.Fields(lngCounter).Value) Then

                            If Len(.Fields(lngCounter).Value) <> 0 Then cmbModCPL.Items.Add(.Fields(lngCounter).Value)


                        End If


                    Else

                    End If

                Next

                .MoveNext()
            Loop
        End With

        rs.Close()
        rs = Nothing

        Exit Sub
err_:
        '  MsgBox(Err.Description)
    End Sub
End Class