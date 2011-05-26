﻿Module MOD_PROV_SN

    Public Sub proverka_sn()
        On Error Resume Next
        Dim LNGIniFile As New IniFile(sLANGPATH)

        If IdentifierMAC = 0 Then

            new_prov = False
            Exit Sub

        Else

        End If

        Dim counter As Integer
        Dim intj As Integer
        Dim sSQL As String


        Dim rs As ADODB.Recordset

        sSQL = "SELECT count(*) as t_n FROM kompy"
        rs = New ADODB.Recordset
        rs.Open(sSQL, DB7, ADODB.CursorTypeEnum.adOpenDynamic, ADODB.LockTypeEnum.adLockOptimistic)
        With rs
            counter = .Fields("t_n").Value
        End With
        rs.Close()
        rs = Nothing

        If counter = 0 Then Exit Sub

        sSQL = "SELECT INV_NO_SYSTEM, INV_NO_MONITOR, INV_NO_IBP, NET_MAC_1, NET_NAME, FILIAL, MESTO FROM kompy WHERE tiptehn = 'PC'"
        rs = New ADODB.Recordset
        rs.Open(sSQL, DB7, ADODB.CursorTypeEnum.adOpenDynamic, ADODB.LockTypeEnum.adLockOptimistic)
        intj = 0

        With rs
            .MoveFirst()
            Do While Not .EOF

                'LNGIniFile.GetString("MOD_PROV_SN", "MSG1", "")
                If Len(Trim(frmComputers.txtSBSN.Text)) > 0 Then
                    If .Fields("INV_NO_SYSTEM").Value = frmComputers.txtSBSN.Text Then
                        MsgBox(LNGIniFile.GetString("MOD_PROV_SN", "MSG1", "") & " системного блока " & LNGIniFile.GetString("MOD_PROV_SN", "MSG2", "") & vbCrLf & LNGIniFile.GetString("MOD_PROV_SN", "MSG3", "") & vbCrLf & LNGIniFile.GetString("MOD_PROV_SN", "MSG4", "") & " " & .Fields("NET_NAME").Value & vbCrLf & LNGIniFile.GetString("MOD_PROV_SN", "MSG5", "") & " " & .Fields("FILIAL").Value & vbCrLf & LNGIniFile.GetString("MOD_PROV_SN", "MSG6", "") & " " & .Fields("MESTO").Value, MsgBoxStyle.Exclamation, "!")
                        intj = intj + 1
                    End If
                End If

                If Len(Trim(frmComputers.txtMSN.Text)) > 0 Then
                    If .Fields("INV_NO_MONITOR").Value = frmComputers.txtMSN.Text Then
                        MsgBox(LNGIniFile.GetString("MOD_PROV_SN", "MSG1", "") & " монитора " & LNGIniFile.GetString("MOD_PROV_SN", "MSG2", "") & vbCrLf & LNGIniFile.GetString("MOD_PROV_SN", "MSG3", "") & vbCrLf & LNGIniFile.GetString("MOD_PROV_SN", "MSG4", "") & " " & .Fields("NET_NAME").Value & vbCrLf & LNGIniFile.GetString("MOD_PROV_SN", "MSG5", "") & " " & .Fields("FILIAL").Value & vbCrLf & LNGIniFile.GetString("MOD_PROV_SN", "MSG6", "") & " " & .Fields("MESTO").Value, MsgBoxStyle.Exclamation, "!")
                        intj = intj + 1
                    End If
                End If

                If Len(Trim(frmComputers.IN_IBP.Text)) > 0 Then
                    If .Fields("INV_NO_IBP").Value = frmComputers.IN_IBP.Text Then
                        MsgBox(LNGIniFile.GetString("MOD_PROV_SN", "MSG1", "") & " ИБП " & LNGIniFile.GetString("MOD_PROV_SN", "MSG2", "") & vbCrLf & LNGIniFile.GetString("MOD_PROV_SN", "MSG3", "") & vbCrLf & LNGIniFile.GetString("MOD_PROV_SN", "MSG4", "") & " " & .Fields("NET_NAME").Value & vbCrLf & LNGIniFile.GetString("MOD_PROV_SN", "MSG5", "") & " " & .Fields("FILIAL").Value & vbCrLf & LNGIniFile.GetString("MOD_PROV_SN", "MSG6", "") & " " & .Fields("MESTO").Value, MsgBoxStyle.Exclamation, "!")
                        intj = intj + 1
                    End If
                End If

                If Len(Trim(frmComputers.txtNETmac1.Text)) > 0 Then
                    If .Fields("NET_MAC_1").Value = frmComputers.txtNETmac1.Text Then
                        MsgBox("MAC адрес и имя компьютера " & LNGIniFile.GetString("MOD_PROV_SN", "MSG2", "") & vbCrLf & " " & LNGIniFile.GetString("MOD_PROV_SN", "MSG7", "") & vbCrLf & LNGIniFile.GetString("MOD_PROV_SN", "MSG4", "") & " " & .Fields("NET_NAME").Value & vbCrLf & LNGIniFile.GetString("MOD_PROV_SN", "MSG5", "") & " " & .Fields("FILIAL").Value & vbCrLf & LNGIniFile.GetString("MOD_PROV_SN", "MSG6", "") & " " & .Fields("MESTO").Value, MsgBoxStyle.Exclamation, "!")
                        intj = intj + 1
                    End If
                End If

                .MoveNext()
                'DoEvents
            Loop
        End With

        rs.Close()
        rs = Nothing
        'rs3.Close
        'Set rs3 = Nothing


        '############################
        '# Проверка серийников
        '############################

        'intj = 0

        sSQL = "SELECT Mb_Id, RAM_SN_1, RAM_SN_2, RAM_SN_3, RAM_SN_4, HDD_SN_1, HDD_SN_2, HDD_SN_3, HDD_SN_4, SVGA_SN, SOUND_SN, CD_SN, CDRW_SN, DVD_SN, FDD_SN, MODEM_SN, KEYBOARD_SN, MOUSE_SN, USB_SN, PCI_SN, MONITOR_SN, MONITOR_SN2, AS_SN, IBP_SN, FILTR_SN, PRINTER_SN_1, PRINTER_SN_2, PRINTER_SN_3, PRINTER_SN_4, SCANER_SN, Mb, NET_NAME, FILIAL, MESTO FROM kompy WHERE tiptehn = 'PC'"
        rs = New ADODB.Recordset
        rs.Open(sSQL, DB7, ADODB.CursorTypeEnum.adOpenDynamic, ADODB.LockTypeEnum.adLockOptimistic)
        intj = 0

        With rs
            'If .RecordCount <> 0 Then
            '.MoveFirst
            Do While Not .EOF
                If .Fields("Mb_Id").Value = frmComputers.txtSN_MB.Text And Len(frmComputers.txtSN_MB.Text) <> 0 And .Fields(30).Value = frmComputers.cmbMB.Text And frmComputers.txtSN_MB.Text <> "<N/A>" And frmComputers.txtSN_MB.Text <> "123456789000" And frmComputers.txtSN_MB.Text <> "To be filled by O.E.M." And frmComputers.txtSN_MB.Text <> "MB-1234567890" And frmComputers.txtSN_MB.Text <> "MS9874353456379863" Then     'MS9874353456379863
                    MsgBox(LNGIniFile.GetString("MOD_PROV_SN", "MSG8", "") & " " & LNGIniFile.GetString("MOD_PROV_SN", "MSG9", "") & " " & LNGIniFile.GetString("MOD_PROV_SN", "MSG2", "") & vbCrLf & "Дальнейшее добавление не возможно" & vbCrLf & LNGIniFile.GetString("MOD_PROV_SN", "MSG4", "") & " " & .Fields(31).Value & vbCrLf & LNGIniFile.GetString("MOD_PROV_SN", "MSG5", "") & " " & .Fields(32).Value & vbCrLf & LNGIniFile.GetString("MOD_PROV_SN", "MSG6", "") & " " & .Fields(33).Value, MsgBoxStyle.Exclamation, "!")
                    intj = intj + 1
                End If


                Dim mpamt As Boolean
                mpamt = False

                '#####################
                If Len(.Fields(1)) <= 3 Then
                Else
                    If .Fields(1).Value = frmComputers.txtRamSN1.Text And Len(frmComputers.txtRamSN1.Text) <> 0 Or .Fields(1).Value = frmComputers.txtRamSN2.Text Or .Fields(1).Value = frmComputers.txtRamSN3.Text Or .Fields(1).Value = frmComputers.txtRamSN4.Text And frmComputers.txtRamSN1.Text <> "Нет" Then '
                        'MsgBox LNGIniFile.GetString("MOD_PROV_SN", "MSG8", "")  & " модуля памяти " &  LNGIniFile.GetString("MOD_PROV_SN", "MSG2", "")  & vbCrLf & "Дальнейшее добавление не возможно" & vbCrLf & LNGIniFile.GetString("MOD_PROV_SN", "MSG4", "") & " " & .Fields(31).value & vbCrLf & LNGIniFile.GetString("MOD_PROV_SN", "MSG5", "") & " " & .Fields(32).value & vbCrLf & LNGIniFile.GetString("MOD_PROV_SN", "MSG6", "") & " " & .Fields(33).value, MsgBoxStyle.Exclamation, "!"
                        mpamt = True
                        intj = intj + 1
                    End If
                End If

                If Len(.Fields(2)) <= 3 Then
                Else
                    If .Fields(2).Value = frmComputers.txtRamSN2.Text And Len(frmComputers.txtRamSN2.Text) <> 0 Or .Fields(2).Value = frmComputers.txtRamSN1.Text Or .Fields(2).Value = frmComputers.txtRamSN3.Text Or .Fields(2).Value = frmComputers.txtRamSN4.Text And frmComputers.txtRamSN2.Text <> "Нет" Then
                        'MsgBox LNGIniFile.GetString("MOD_PROV_SN", "MSG8", "")  & " модуля памяти " &  LNGIniFile.GetString("MOD_PROV_SN", "MSG2", "")  & vbCrLf & "Дальнейшее добавление не возможно" & vbCrLf & LNGIniFile.GetString("MOD_PROV_SN", "MSG4", "") & " " & .Fields(31).value & vbCrLf & LNGIniFile.GetString("MOD_PROV_SN", "MSG5", "") & " " & .Fields(32).value & vbCrLf & LNGIniFile.GetString("MOD_PROV_SN", "MSG6", "") & " " & .Fields(33).value, MsgBoxStyle.Exclamation, "!"
                        mpamt = True
                        intj = intj + 1
                    End If
                End If

                If Len(.Fields(3)) <= 3 Then
                Else
                    If .Fields(3).Value = frmComputers.txtRamSN3.Text And Len(frmComputers.txtRamSN3.Text) <> 0 Or .Fields(3).Value = frmComputers.txtRamSN1.Text Or .Fields(3).Value = frmComputers.txtRamSN2.Text Or .Fields(3).Value = frmComputers.txtRamSN4.Text And frmComputers.txtRamSN3.Text <> "Нет" Then
                        'MsgBox LNGIniFile.GetString("MOD_PROV_SN", "MSG8", "")  & " модуля памяти " &  LNGIniFile.GetString("MOD_PROV_SN", "MSG2", "")  & vbCrLf & "Дальнейшее добавление не возможно" & vbCrLf & LNGIniFile.GetString("MOD_PROV_SN", "MSG4", "") & " " & .Fields(31).value & vbCrLf & LNGIniFile.GetString("MOD_PROV_SN", "MSG5", "") & " " & .Fields(32).value & vbCrLf & LNGIniFile.GetString("MOD_PROV_SN", "MSG6", "") & " " & .Fields(33).value, MsgBoxStyle.Exclamation, "!"
                        mpamt = True
                        intj = intj + 1
                    End If
                End If

                If Len(.Fields(4)) <= 3 Then
                Else
                    If .Fields(4).Value = frmComputers.txtRamSN4.Text And Len(frmComputers.txtRamSN4.Text) <> 0 Or .Fields(4).Value = frmComputers.txtRamSN1.Text Or .Fields(4).Value = frmComputers.txtRamSN2.Text Or .Fields(4).Value = frmComputers.txtRamSN3.Text And frmComputers.txtRamSN4.Text <> "Нет" Then
                        'MsgBox LNGIniFile.GetString("MOD_PROV_SN", "MSG8", "")  & " модуля памяти " &  LNGIniFile.GetString("MOD_PROV_SN", "MSG2", "")  & vbCrLf & "Дальнейшее добавление не возможно" & vbCrLf & LNGIniFile.GetString("MOD_PROV_SN", "MSG4", "") & " " & .Fields(31).value & vbCrLf & LNGIniFile.GetString("MOD_PROV_SN", "MSG5", "") & " " & .Fields(32).value & vbCrLf & LNGIniFile.GetString("MOD_PROV_SN", "MSG6", "") & " " & .Fields(33).value, MsgBoxStyle.Exclamation, "!"
                        mpamt = True
                        intj = intj + 1
                    End If
                End If

                If mpamt = True Then
                    MsgBox(LNGIniFile.GetString("MOD_PROV_SN", "MSG8", "") & " " & LNGIniFile.GetString("MOD_PROV_SN", "MSG10", "") & " " & LNGIniFile.GetString("MOD_PROV_SN", "MSG2", "") & vbCrLf & "Дальнейшее добавление не возможно" & vbCrLf & LNGIniFile.GetString("MOD_PROV_SN", "MSG4", "") & " " & .Fields(31).Value & vbCrLf & LNGIniFile.GetString("MOD_PROV_SN", "MSG5", "") & " " & .Fields(32).Value & vbCrLf & LNGIniFile.GetString("MOD_PROV_SN", "MSG6", "") & " " & .Fields(33).Value, MsgBoxStyle.Exclamation, "!")
                    mpamt = False
                Else
                End If




                '####################
                '# ЖД
                '####################
                If Len(.Fields(5)) < 3 Or .Fields(5).Value = "Неизвестно" Then
                Else
                    If .Fields(5).Value = frmComputers.txtHDDsN1.Text And Len(frmComputers.txtHDDsN1.Text) <> 0 Or .Fields(5).Value = frmComputers.txtHDDsN2.Text Or .Fields(5).Value = frmComputers.txtHDDsN3.Text Or .Fields(5).Value = frmComputers.txtHDDsN4.Text Then
                        mpamt = True
                        intj = intj + 1
                    End If
                End If

                If Len(.Fields(6)) < 3 Or .Fields(6).Value = "Неизвестно" Then
                Else
                    If .Fields(6).Value = frmComputers.txtHDDsN2.Text And Len(frmComputers.txtHDDsN2.Text) <> 0 Or .Fields(6).Value = frmComputers.txtHDDsN1.Text Or .Fields(6).Value = frmComputers.txtHDDsN3.Text Or .Fields(6).Value = frmComputers.txtHDDsN4.Text Then
                        mpamt = True
                        intj = intj + 1
                    End If
                End If

                If Len(.Fields(7).Value) < 3 Or .Fields(7).Value = "Неизвестно" Then
                Else
                    If .Fields(7).Value = frmComputers.txtHDDsN3.Text And Len(frmComputers.txtHDDsN3.Text) <> 0 Or .Fields(7).Value = frmComputers.txtHDDsN1.Text Or .Fields(7).Value = frmComputers.txtHDDsN2.Text Or .Fields(7).Value = frmComputers.txtHDDsN4.Text Then
                        mpamt = True
                        intj = intj + 1
                    End If
                End If

                If Len(.Fields(8).Value) < 3 Or .Fields(8).Value = "Неизвестно" Then
                Else
                    If .Fields(8).Value = frmComputers.txtHDDsN4.Text And Len(frmComputers.txtHDDsN4.Text) <> 0 Or .Fields(8).Value = frmComputers.txtHDDsN1.Text Or .Fields(7).Value = frmComputers.txtHDDsN2.Text Or .Fields(7).Value = frmComputers.txtHDDsN3.Text Then
                        mpamt = True
                        intj = intj + 1
                    End If
                End If

                If mpamt = True Then
                    MsgBox(LNGIniFile.GetString("MOD_PROV_SN", "MSG8", "") & " " & LNGIniFile.GetString("MOD_PROV_SN", "MSG11", "") & " " & LNGIniFile.GetString("MOD_PROV_SN", "MSG2", "") & vbCrLf & "Дальнейшее добавление не возможно" & vbCrLf & LNGIniFile.GetString("MOD_PROV_SN", "MSG4", "") & " " & .Fields(31).Value & vbCrLf & LNGIniFile.GetString("MOD_PROV_SN", "MSG5", "") & " " & .Fields(32).Value & vbCrLf & LNGIniFile.GetString("MOD_PROV_SN", "MSG6", "") & " " & .Fields(33).Value, MsgBoxStyle.Exclamation, "!")
                    mpamt = False
                Else
                End If

                '######################################
                If .Fields(9).Value = frmComputers.txtSVGAs1.Text And Len(frmComputers.txtSVGAs1.Text) <> 0 Then
                    MsgBox(LNGIniFile.GetString("MOD_PROV_SN", "MSG8", "") & " " & LNGIniFile.GetString("MOD_PROV_SN", "MSG12", "") & " " & LNGIniFile.GetString("MOD_PROV_SN", "MSG2", "") & vbCrLf & " " & LNGIniFile.GetString("MOD_PROV_SN", "MSG7", "") & vbCrLf & LNGIniFile.GetString("MOD_PROV_SN", "MSG4", "") & " " & .Fields(31).Value & vbCrLf & LNGIniFile.GetString("MOD_PROV_SN", "MSG5", "") & " " & .Fields(32).Value & vbCrLf & LNGIniFile.GetString("MOD_PROV_SN", "MSG6", "") & " " & .Fields(33).Value, MsgBoxStyle.Exclamation, "!")
                    intj = intj + 1
                End If

                If .Fields(10).Value = frmComputers.txtSoundS.Text And Len(frmComputers.txtSoundS.Text) <> 0 Then
                    MsgBox(LNGIniFile.GetString("MOD_PROV_SN", "MSG8", "") & " " & LNGIniFile.GetString("MOD_PROV_SN", "MSG13", "") & " " & LNGIniFile.GetString("MOD_PROV_SN", "MSG2", "") & vbCrLf & " " & LNGIniFile.GetString("MOD_PROV_SN", "MSG7", "") & vbCrLf & LNGIniFile.GetString("MOD_PROV_SN", "MSG4", "") & " " & .Fields(31).Value & vbCrLf & LNGIniFile.GetString("MOD_PROV_SN", "MSG5", "") & " " & .Fields(32).Value & vbCrLf & LNGIniFile.GetString("MOD_PROV_SN", "MSG6", "") & " " & .Fields(33).Value, MsgBoxStyle.Exclamation, "!")
                    intj = intj + 1
                End If

                If .Fields(11).Value = frmComputers.txtSoundS.Text And Len(frmComputers.txtSoundS.Text) <> 0 Then
                    MsgBox(LNGIniFile.GetString("MOD_PROV_SN", "MSG8", "") & " " & LNGIniFile.GetString("MOD_PROV_SN", "MSG14", "") & " " & LNGIniFile.GetString("MOD_PROV_SN", "MSG2", "") & vbCrLf & " " & LNGIniFile.GetString("MOD_PROV_SN", "MSG7", "") & vbCrLf & LNGIniFile.GetString("MOD_PROV_SN", "MSG4", "") & " " & .Fields(31).Value & vbCrLf & LNGIniFile.GetString("MOD_PROV_SN", "MSG5", "") & " " & .Fields(32).Value & vbCrLf & LNGIniFile.GetString("MOD_PROV_SN", "MSG6", "") & " " & .Fields(33).Value, MsgBoxStyle.Exclamation, "!")
                    intj = intj + 1
                End If

                If .Fields(12).Value = frmComputers.txtOPTICsn1.Text And Len(frmComputers.txtOPTICsn1.Text) <> 0 Then
                    MsgBox(LNGIniFile.GetString("MOD_PROV_SN", "MSG8", "") & " " & LNGIniFile.GetString("MOD_PROV_SN", "MSG14", "") & " " & LNGIniFile.GetString("MOD_PROV_SN", "MSG2", "") & vbCrLf & " " & LNGIniFile.GetString("MOD_PROV_SN", "MSG7", "") & vbCrLf & LNGIniFile.GetString("MOD_PROV_SN", "MSG4", "") & " " & .Fields(31).Value & vbCrLf & LNGIniFile.GetString("MOD_PROV_SN", "MSG5", "") & " " & .Fields(32).Value & vbCrLf & LNGIniFile.GetString("MOD_PROV_SN", "MSG6", "") & " " & .Fields(33).Value, MsgBoxStyle.Exclamation, "!")
                    intj = intj + 1
                End If

                If .Fields(13).Value = frmComputers.txtOPTICsn2.Text And Len(frmComputers.txtOPTICsn2.Text) <> 0 Then
                    MsgBox(LNGIniFile.GetString("MOD_PROV_SN", "MSG8", "") & " " & LNGIniFile.GetString("MOD_PROV_SN", "MSG14", "") & " " & LNGIniFile.GetString("MOD_PROV_SN", "MSG2", "") & vbCrLf & " " & LNGIniFile.GetString("MOD_PROV_SN", "MSG7", "") & vbCrLf & LNGIniFile.GetString("MOD_PROV_SN", "MSG4", "") & " " & .Fields(31).Value & vbCrLf & LNGIniFile.GetString("MOD_PROV_SN", "MSG5", "") & " " & .Fields(32).Value & vbCrLf & LNGIniFile.GetString("MOD_PROV_SN", "MSG6", "") & " " & .Fields(33).Value, MsgBoxStyle.Exclamation, "!")
                    intj = intj + 1
                End If

                If .Fields(14).Value = frmComputers.txtSN.Text And Len(frmComputers.txtSN.Text) <> 0 Then
                    MsgBox(LNGIniFile.GetString("MOD_PROV_SN", "MSG8", "") & " " & LNGIniFile.GetString("MOD_PROV_SN", "MSG15", "") & " " & LNGIniFile.GetString("MOD_PROV_SN", "MSG2", "") & vbCrLf & " " & LNGIniFile.GetString("MOD_PROV_SN", "MSG7", "") & vbCrLf & LNGIniFile.GetString("MOD_PROV_SN", "MSG4", "") & " " & .Fields(31).Value & vbCrLf & LNGIniFile.GetString("MOD_PROV_SN", "MSG5", "") & " " & .Fields(32).Value & vbCrLf & LNGIniFile.GetString("MOD_PROV_SN", "MSG6", "") & " " & .Fields(33).Value, MsgBoxStyle.Exclamation, "!")
                    intj = intj + 1
                End If

                If .Fields(15).Value = frmComputers.txtModemSN.Text And Len(frmComputers.txtModemSN.Text) <> 0 Then
                    MsgBox(LNGIniFile.GetString("MOD_PROV_SN", "MSG8", "") & " " & LNGIniFile.GetString("MOD_PROV_SN", "MSG16", "") & " " & LNGIniFile.GetString("MOD_PROV_SN", "MSG2", "") & vbCrLf & " " & LNGIniFile.GetString("MOD_PROV_SN", "MSG7", "") & vbCrLf & LNGIniFile.GetString("MOD_PROV_SN", "MSG4", "") & " " & .Fields(31).Value & vbCrLf & LNGIniFile.GetString("MOD_PROV_SN", "MSG5", "") & " " & .Fields(32).Value & vbCrLf & LNGIniFile.GetString("MOD_PROV_SN", "MSG6", "") & " " & .Fields(33).Value, MsgBoxStyle.Exclamation, "!")
                    intj = intj + 1
                End If

                If .Fields(16).Value = frmComputers.txtKeybSN.Text And Len(frmComputers.txtKeybSN.Text) <> 0 Then
                    MsgBox(LNGIniFile.GetString("MOD_PROV_SN", "MSG8", "") & " " & LNGIniFile.GetString("MOD_PROV_SN", "MSG17", "") & " " & LNGIniFile.GetString("MOD_PROV_SN", "MSG2", "") & vbCrLf & " " & LNGIniFile.GetString("MOD_PROV_SN", "MSG7", "") & vbCrLf & LNGIniFile.GetString("MOD_PROV_SN", "MSG4", "") & " " & .Fields(31).Value & vbCrLf & LNGIniFile.GetString("MOD_PROV_SN", "MSG5", "") & " " & .Fields(32).Value & vbCrLf & LNGIniFile.GetString("MOD_PROV_SN", "MSG6", "") & " " & .Fields(33).Value, MsgBoxStyle.Exclamation, "!")
                    intj = intj + 1
                End If

                If .Fields(17).Value = frmComputers.txtMouseSN.Text And Len(frmComputers.txtMouseSN.Text) <> 0 Then
                    MsgBox(LNGIniFile.GetString("MOD_PROV_SN", "MSG8", "") & " " & LNGIniFile.GetString("MOD_PROV_SN", "MSG18", "") & " " & LNGIniFile.GetString("MOD_PROV_SN", "MSG2", "") & vbCrLf & " " & LNGIniFile.GetString("MOD_PROV_SN", "MSG7", "") & vbCrLf & LNGIniFile.GetString("MOD_PROV_SN", "MSG4", "") & " " & .Fields(31).Value & vbCrLf & LNGIniFile.GetString("MOD_PROV_SN", "MSG5", "") & " " & .Fields(32).Value & vbCrLf & LNGIniFile.GetString("MOD_PROV_SN", "MSG6", "") & " " & .Fields(33).Value, MsgBoxStyle.Exclamation, "!")
                    intj = intj + 1
                End If


                If .Fields(20).Value = frmComputers.txtMon1SN.Text And Len(frmComputers.txtMon1SN.Text) <> 0 And Len(frmComputers.txtMon1SN.Text) > 3 And frmComputers.txtMon1SN.Text <> "141016843009" Then
                    MsgBox(LNGIniFile.GetString("MOD_PROV_SN", "MSG8", "") & " " & LNGIniFile.GetString("MOD_PROV_SN", "MSG19", "") & " " & LNGIniFile.GetString("MOD_PROV_SN", "MSG2", "") & vbCrLf & " " & LNGIniFile.GetString("MOD_PROV_SN", "MSG7", "") & vbCrLf & LNGIniFile.GetString("MOD_PROV_SN", "MSG4", "") & " " & .Fields(31).Value & vbCrLf & LNGIniFile.GetString("MOD_PROV_SN", "MSG5", "") & " " & .Fields(32).Value & vbCrLf & LNGIniFile.GetString("MOD_PROV_SN", "MSG6", "") & " " & .Fields(33).Value, MsgBoxStyle.Exclamation, "!")
                    intj = intj + 1
                End If

                If .Fields(21).Value = frmComputers.txtMon2SN.Text And Len(frmComputers.txtMon2SN.Text) <> 0 And Len(frmComputers.txtMon2SN.Text) > 3 And frmComputers.txtMon2SN.Text <> "141016843009" Then
                    MsgBox(LNGIniFile.GetString("MOD_PROV_SN", "MSG8", "") & " " & LNGIniFile.GetString("MOD_PROV_SN", "MSG19", "") & " " & LNGIniFile.GetString("MOD_PROV_SN", "MSG2", "") & vbCrLf & " " & LNGIniFile.GetString("MOD_PROV_SN", "MSG7", "") & vbCrLf & LNGIniFile.GetString("MOD_PROV_SN", "MSG4", "") & " " & .Fields(31).Value & vbCrLf & LNGIniFile.GetString("MOD_PROV_SN", "MSG5", "") & " " & .Fields(32).Value & vbCrLf & LNGIniFile.GetString("MOD_PROV_SN", "MSG6", "") & " " & .Fields(33).Value, MsgBoxStyle.Exclamation, "!")
                    intj = intj + 1
                End If

                If .Fields(22).Value = frmComputers.txtAsistSN.Text And Len(frmComputers.txtAsistSN.Text) <> 0 Then
                    MsgBox(LNGIniFile.GetString("MOD_PROV_SN", "MSG8", "") & " " & LNGIniFile.GetString("MOD_PROV_SN", "MSG20", "") & " " & LNGIniFile.GetString("MOD_PROV_SN", "MSG2", "") & vbCrLf & " " & LNGIniFile.GetString("MOD_PROV_SN", "MSG7", "") & vbCrLf & LNGIniFile.GetString("MOD_PROV_SN", "MSG4", "") & " " & .Fields(31).Value & vbCrLf & LNGIniFile.GetString("MOD_PROV_SN", "MSG5", "") & " " & .Fields(32).Value & vbCrLf & LNGIniFile.GetString("MOD_PROV_SN", "MSG6", "") & " " & .Fields(33).Value, MsgBoxStyle.Exclamation, "!")
                    intj = intj + 1
                End If

                If .Fields(24).Value = frmComputers.txtFilterSN.Text And Len(frmComputers.txtFilterSN.Text) <> 0 Then
                    MsgBox(LNGIniFile.GetString("MOD_PROV_SN", "MSG8", "") & " " & LNGIniFile.GetString("MOD_PROV_SN", "MSG21", "") & " " & LNGIniFile.GetString("MOD_PROV_SN", "MSG2", "") & vbCrLf & " " & LNGIniFile.GetString("MOD_PROV_SN", "MSG7", "") & vbCrLf & LNGIniFile.GetString("MOD_PROV_SN", "MSG4", "") & " " & .Fields(31).Value & vbCrLf & LNGIniFile.GetString("MOD_PROV_SN", "MSG5", "") & " " & .Fields(32).Value & vbCrLf & LNGIniFile.GetString("MOD_PROV_SN", "MSG6", "") & " " & .Fields(33).Value, MsgBoxStyle.Exclamation, "!")
                    intj = intj + 1
                End If

                If .Fields(25).Value = frmComputers.txtPrint1SN.Text And Len(frmComputers.txtPrint1SN.Text) <> 0 Then
                    MsgBox(LNGIniFile.GetString("MOD_PROV_SN", "MSG8", "") & " " & LNGIniFile.GetString("MOD_PROV_SN", "MSG22", "") & " " & LNGIniFile.GetString("MOD_PROV_SN", "MSG2", "") & vbCrLf & " " & LNGIniFile.GetString("MOD_PROV_SN", "MSG7", "") & vbCrLf & LNGIniFile.GetString("MOD_PROV_SN", "MSG4", "") & " " & .Fields(31).Value & vbCrLf & LNGIniFile.GetString("MOD_PROV_SN", "MSG5", "") & " " & .Fields(32).Value & vbCrLf & LNGIniFile.GetString("MOD_PROV_SN", "MSG6", "") & " " & .Fields(33).Value, MsgBoxStyle.Exclamation, "!")
                    intj = intj + 1
                End If

                If .Fields(26).Value = frmComputers.txtPrint2SN.Text And Len(frmComputers.txtPrint2SN.Text) <> 0 Then
                    MsgBox(LNGIniFile.GetString("MOD_PROV_SN", "MSG8", "") & " " & LNGIniFile.GetString("MOD_PROV_SN", "MSG22", "") & " " & LNGIniFile.GetString("MOD_PROV_SN", "MSG2", "") & vbCrLf & " " & LNGIniFile.GetString("MOD_PROV_SN", "MSG7", "") & vbCrLf & LNGIniFile.GetString("MOD_PROV_SN", "MSG4", "") & " " & .Fields(31).Value & vbCrLf & LNGIniFile.GetString("MOD_PROV_SN", "MSG5", "") & " " & .Fields(32).Value & vbCrLf & LNGIniFile.GetString("MOD_PROV_SN", "MSG6", "") & " " & .Fields(33).Value, MsgBoxStyle.Exclamation, "!")
                    intj = intj + 1
                End If

                If .Fields(27).Value = frmComputers.txtPrint3SN.Text And Len(frmComputers.txtPrint3SN.Text) <> 0 Then
                    MsgBox(LNGIniFile.GetString("MOD_PROV_SN", "MSG8", "") & " " & LNGIniFile.GetString("MOD_PROV_SN", "MSG22", "") & " " & LNGIniFile.GetString("MOD_PROV_SN", "MSG2", "") & vbCrLf & " " & LNGIniFile.GetString("MOD_PROV_SN", "MSG7", "") & vbCrLf & LNGIniFile.GetString("MOD_PROV_SN", "MSG4", "") & " " & .Fields(31).Value & vbCrLf & LNGIniFile.GetString("MOD_PROV_SN", "MSG5", "") & " " & .Fields(32).Value & vbCrLf & LNGIniFile.GetString("MOD_PROV_SN", "MSG6", "") & " " & .Fields(33).Value, MsgBoxStyle.Exclamation, "!")
                    intj = intj + 1
                End If


                .MoveNext()
                'DoEvents
            Loop

        End With

        rs.Close()
        rs = Nothing
        '########################
        '# Завершена проверка серийников
        '########################

        If intj <> 0 Then
            new_prov = True
        Else
            new_prov = False
        End If


    End Sub


End Module