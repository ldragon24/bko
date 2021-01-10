Module MOD_CHECKCFG_LOAD
    Public Sub CHECKCFG_Load()
        On Error Resume Next


        Dim everIniFile As New IniFile(CHECKCFGFilePatch)


        frmComputers.cmbResponsible.Text = everIniFile.GetString("Network", "UserName", "")

        frmComputers.cmbCPU1.Text = everIniFile.GetString("Computer", "CPU.BrandName", "")
        frmComputers.txtMHZ1.Text = everIniFile.GetString("Computer", "CPU_Freq_in_MHz", "")
        frmComputers.txtSoc1.Text = everIniFile.GetString("Hardware", "CPU1 socket", "")
        frmComputers.PROizV1.Text = everIniFile.GetString("Hardware", "CPU1 vendor", "")

        'frmComputers.txtSNSB.Text = everIniFile.GetString("DMI", "Система|Свойства системы|Серийный номер", "")
        'frmComputers.PROizV27.Text = everIniFile.GetString("Суммарная информация", "DMI|DMI производитель системы", "")


        '################
        'Материнка
        frmComputers.cmbMB.Text = everIniFile.GetString("Hardware", "Board Product", "")
        'frmComputers.txtChip.Text = everIniFile.GetString("Hardware", "ChipsetName", "")
        frmComputers.txtSN_MB.Text = everIniFile.GetString("Hardware", "Board ser.N", "")
        frmComputers.PROizV5.Text = everIniFile.GetString("Hardware", "Board vendor", "")


        '################
        'Память

        Dim uname As String
        Dim arrAnimals() As String

        uname = everIniFile.GetString("Hardware", "MEM1 info", "")

        If uname <> 0 And uname <> "DIMM Synchronous DDR2 Memory device not installed" And uname <> "DIMM Memory device not installed" And uname <> "Memory device not installed" Then

            arrAnimals = Split(uname, ",")

            frmComputers.cmbRAM1.Text = everIniFile.GetString("Hardware", "MEM1 info", "")
            frmComputers.PROizV6.Text = everIniFile.GetString("Hardware", "MEM1 vendor", "")
            frmComputers.txtRamSN1.Text = everIniFile.GetString("Hardware", "MEM1 Ser.N", "")
            frmComputers.txtRamS1.Text = arrAnimals(2)

        End If


        uname = everIniFile.GetString("Hardware", "MEM2 info", "")

        If uname <> 0 And uname <> "DIMM Synchronous DDR2 Memory device not installed" And uname <> "DIMM Memory device not installed" And uname <> "Memory device not installed" Then

            arrAnimals = Split(uname, ",")

            frmComputers.cmbRAM2.Text = everIniFile.GetString("Hardware", "MEM2 info", "")
            frmComputers.PROizV7.Text = everIniFile.GetString("Hardware", "MEM2 vendor", "")
            frmComputers.txtRamSN2.Text = everIniFile.GetString("Hardware", "MEM2 Ser.N", "")
            frmComputers.txtRamS2.Text = arrAnimals(2)

        End If

        uname = everIniFile.GetString("Hardware", "MEM3 info", "")

        If uname <> 0 And uname <> "DIMM Synchronous DDR2 Memory device not installed" And uname <> "DIMM Memory device not installed" And uname <> "Memory device not installed" Then

            arrAnimals = Split(uname, ",")

            frmComputers.cmbRAM3.Text = everIniFile.GetString("Hardware", "MEM3 info", "")
            frmComputers.PROizV8.Text = everIniFile.GetString("Hardware", "MEM3 vendor", "")
            frmComputers.txtRamSN3.Text = everIniFile.GetString("Hardware", "MEM3 Ser.N", "")
            frmComputers.txtRamS3.Text = arrAnimals(2)

        End If

        uname = everIniFile.GetString("Hardware", "MEM4 info", "")

        If uname <> 0 And uname <> "DIMM Synchronous DDR2 Memory device not installed" And uname <> "DIMM Memory device not installed" And uname <> "Memory device not installed" Then

            arrAnimals = Split(uname, ",")

            frmComputers.cmbRAM4.Text = everIniFile.GetString("Hardware", "MEM4 info", "")
            frmComputers.PROizV9.Text = everIniFile.GetString("Hardware", "MEM4 vendor", "")
            frmComputers.txtRamSN4.Text = everIniFile.GetString("Hardware", "MEM4 Ser.N", "")
            frmComputers.txtRamS4.Text = arrAnimals(2)
        End If

        '################
        'Жесткий диск
        '1
        Dim sTMP As String
        Dim sCDROM As String
        Dim sHDD As String
        Dim sVGA As String
        Dim sMON As String
        Dim sNET As String

        sTMP = everIniFile.GetString("Current_Config", "Device_0", "")

        arrAnimals = Split(sTMP, " ")

        If arrAnimals(0) = "CdRom" Then
            sCDROM = sTMP
        End If

        If arrAnimals(0) = "Display" Then
            sVGA = sTMP
        End If

        If arrAnimals(0) = "HDD" Then
            sHDD = sTMP
        End If

        If arrAnimals(0) = "Monitor" Then
            sMON = sTMP
        End If

        If arrAnimals(0) = "Net" Then
            sNET = sTMP
        End If

        If Len(sHDD) <> 0 Then
            frmComputers.cmbHDD1.Text = sHDD
        Else
            frmComputers.cmbHDD1.Text = everIniFile.GetString("S.M.A.R.T.", "HDD0_Info", "")
        End If

        frmComputers.txtHDDo1.Text = everIniFile.GetString("Computer", "Total_HDD_in_Mb", "")
        'frmComputers.txtHDDsN1.Text = everIniFile.GetString("Computer", "1stSerialNumber", "")
        'frmComputers.PROizV10.Text = everIniFile.GetString("HDD", "ATA1|Производитель ATA-устройства|Фирма", "")

        frmComputers.cmbHDD2.Text = everIniFile.GetString("S.M.A.R.T.", "HDD1_Info", "")
        'frmComputers.txtHDDo2.Text = everIniFile.GetString("Computer", "2ndHDDMarketingSize", "")
        'frmComputers.txtHDDsN2.Text = everIniFile.GetString("Computer", "2ndSerialNumber", "")
        'frmComputers.PROizV10.Text = everIniFile.GetString("HDD", "ATA1|Производитель ATA-устройства|Фирма", "")

        frmComputers.cmbHDD3.Text = everIniFile.GetString("S.M.A.R.T.", "HDD2_Info", "")
        'frmComputers.txtHDDo3.Text = everIniFile.GetString("Computer", "3rdHDDMarketingSize", "")
        'frmComputers.txtHDDsN3.Text = everIniFile.GetString("Computer", "3rdSerialNumber", "")
        'frmComputers.PROizV10.Text = everIniFile.GetString("HDD", "ATA1|Производитель ATA-устройства|Фирма", "")

        frmComputers.cmbHDD4.Text = everIniFile.GetString("S.M.A.R.T.", "HDD3_Info", "")
        'frmComputers.txtHDDo4.Text = everIniFile.GetString("Computer", "4thHDDMarketingSize", "")
        'frmComputers.txtHDDsN4.Text = everIniFile.GetString("Computer", "4thSerialNumber", "")
        'frmComputers.PROizV10.Text = everIniFile.GetString("HDD", "ATA1|Производитель ATA-устройства|Фирма", "")


        '################
        'SVGA

        If Len(sVGA) <> 0 Then
            frmComputers.cmbSVGA1.Text = sVGA

        Else

            'Windows_Devices

            For intj = 0 To 200
                uname = everIniFile.GetString("Windows_Devices", "Win_Device_" & intj, "")
                arrAnimals = Split(uname, " ")

                If arrAnimals(0) = "Display" Then
                    frmComputers.cmbSVGA1.Text = uname
                    GoTo a
                End If

            Next

            ' frmComputers.cmbSVGA1.Text = everIniFile.GetString("Video", "VideoChip", "")

        End If
a:


        '################
        'Звуковая карта

        For intj = 0 To 200
            uname = everIniFile.GetString("Windows_Devices", "Win_Device_" & intj, "")
            arrAnimals = Split(uname, " ")

            If arrAnimals(0) = "MEDIA" Then
                frmComputers.cmbSound.Text = uname
                GoTo b
            End If

        Next

b:

        '################
        'CD-ROM

        If Len(sCDROM) <> 0 Then
            frmComputers.cmbOPTIC1.Text = sCDROM
        Else
            For intj = 0 To 200
                uname = everIniFile.GetString("Windows_Devices", "Win_Device_" & intj, "")
                arrAnimals = Split(uname, " ")
                If arrAnimals(0) = "Display" Then
                    frmComputers.cmbOPTIC1.Text = uname
                    GoTo c
                End If
            Next
        End If
c:


        '################
        'Сетевая карта

        If Len(sNET) <> 0 Then
            frmComputers.cmbNET1.Text = sNET
        Else
            For intj = 0 To 200
                uname = everIniFile.GetString("Windows_Devices", "Win_Device_" & intj, "")
                arrAnimals = Split(uname, " ")
                If arrAnimals(0) = "Net" Then
                    frmComputers.cmbNET1.Text = uname
                    frmComputers.txtNETip1.Text = everIniFile.GetString("Info", "IP_Addr", "")
                    frmComputers.txtNETmac1.Text = everIniFile.GetString("Info", "MAC_Addr", "")
                    'txtNETmac1

                    GoTo d
                End If
            Next
        End If
d:


        '################
        'Монитор

        If Len(sMON) <> 0 Then
            frmComputers.cmbMon1.Text = sMON
        Else
            For intj = 0 To 200
                uname = everIniFile.GetString("Windows_Devices", "Win_Device_" & intj, "")
                arrAnimals = Split(uname, " ")
                If arrAnimals(0) = "Monitor" Then
                    frmComputers.cmbMon1.Text = uname
                    GoTo e
                End If

            Next
        End If
e:


        '################
        'Дисковод

        ' frmComputers.cmbFDD.Text = everIniFile.GetString("Other", "FloppyDrives", "")


        '################
        'Модем

        ' frmComputers.cmbModem.Text = everIniFile.GetString("Other", "1ModemModel", "")
        ' frmComputers.PROizV24.Text = everIniFile.GetString("Other", "1ModemVendor", "")


        '################
        'Клавиатура

        For intj = 0 To 200
            uname = everIniFile.GetString("Windows_Devices", "Win_Device_" & intj, "")
            arrAnimals = Split(uname, " ")
            If arrAnimals(0) = "Keyboard" Then
                frmComputers.cmbKeyb.Text = uname
                GoTo f
            End If

        Next
f:


        '################
        'Мышь
        For intj = 0 To 200
            uname = everIniFile.GetString("Windows_Devices", "Win_Device_" & intj, "")
            arrAnimals = Split(uname, " ")
            If arrAnimals(0) = "Mouse" Then
                frmComputers.cmbMouse.Text = uname
                GoTo g
            End If

        Next
g:


        'frmComputers.cmbMouse.Text = everIniFile.GetString("Суммарная информация", "Ввод|Мышь", "")

        '################
        'Имя компа

        Select Case Upd_flag

            Case False

                frmComputers.txtSNAME.Text = everIniFile.GetString("Info", "Computer_Name", "")
                If Len(frmComputers.txtSNAME.Text) = 0 Then frmComputers.txtSNAME.Text = "NoName"
                frmComputers.txtPSEUDONIM.Text = frmComputers.txtSNAME.Text
            Case True

        End Select

        'Установленное програмное обеспечение
        textpo()

    End Sub

    Private Sub textpo()

        Dim uname As String
        Dim A As String
        Dim DC As String
        Dim uname1 As String
        Dim uname2 As String
        Dim uname3 As String
        Dim uname4 As String


        Dim intj, intcount As Integer
        Dim everIniFile As New IniFile(CHECKCFGFilePatch)

        'On Error GoTo Err_handler
        On Error Resume Next
        A = "Windows_Soft"
        frmComputers.lstSoftware.Items.Clear()
        intcount = 0
        For intj = 1 To 400

            A = "win_Soft_" & intj

            uname = everIniFile.GetString("Windows_Soft", A, "")
            'uname1 = everIniFile.GetString("Установленные программы", uname & "|Publisher", "")
            'uname2 = everIniFile.GetString("Установленные программы", uname & "|Дата", "")

            If Len(uname) = 0 Or uname = "" Then

            Else


                frmComputers.lstSoftware.Items.Add(frmComputers.lstSoftware.Items.Count + 1)
                'frmComputers.lstSoftware.Items(intcount).SubItems.Add(frmComputers.lstSoftware.Items.Count + 1)
                frmComputers.lstSoftware.Items(intcount).SubItems.Add(uname)
                frmComputers.lstSoftware.Items(intcount).SubItems.Add("")
                frmComputers.lstSoftware.Items(intcount).SubItems.Add("")
                frmComputers.lstSoftware.Items(intcount).SubItems.Add("")
                frmComputers.lstSoftware.Items(intcount).SubItems.Add(Date.Today)
                frmComputers.lstSoftware.Items(intcount).SubItems.Add(Date.Today)
                frmComputers.lstSoftware.Items(intcount).SubItems.Add("")

                intcount = intcount + 1
            End If
        Next


        frmComputers.lstSoftware.Items.Add(frmComputers.lstSoftware.Items.Count + 1)
        frmComputers.lstSoftware.Items(intcount).SubItems.Add(everIniFile.GetString("Info", "System", ""))
        frmComputers.lstSoftware.Items(intcount).SubItems.Add("")
        frmComputers.lstSoftware.Items(intcount).SubItems.Add("")
        frmComputers.lstSoftware.Items(intcount).SubItems.Add("")
        frmComputers.lstSoftware.Items(intcount).SubItems.Add(Date.Today)
        frmComputers.lstSoftware.Items(intcount).SubItems.Add(Date.Today)
        frmComputers.lstSoftware.Items(intcount).SubItems.Add("")

        Exit Sub
Err_handler:
        MsgBox(Err.Description)
    End Sub


End Module
