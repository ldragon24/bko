Module MOD_ASTRA_LOAD
    Public Sub ASTRA_Load()
        On Error Resume Next


        Dim everIniFile As New IniFile(EverestFilePatch)


        frmComputers.cmbResponsible.Text = everIniFile.GetString("Network", "UserName", "")

        frmComputers.cmbCPU1.Text = everIniFile.GetString("Processor", "Processor", "")
        frmComputers.txtMHZ1.Text = everIniFile.GetString("Processor", "CPUClock", "")
        frmComputers.txtSoc1.Text = everIniFile.GetString("Processor", "PlatformID", "")
        frmComputers.PROizV1.Text = everIniFile.GetString("Processor", "ProcessorVendor", "")

        'frmComputers.txtSNSB.Text = everIniFile.GetString("DMI", "Система|Свойства системы|Серийный номер", "")
        'frmComputers.PROizV27.Text = everIniFile.GetString("Суммарная информация", "DMI|DMI производитель системы", "")


        '################
        'Материнка
        frmComputers.cmbMB.Text = everIniFile.GetString("DMIMotherboard", "DMIProductName", "")
        frmComputers.txtChip.Text = everIniFile.GetString("Other", "ChipsetName", "")
        frmComputers.txtSN_MB.Text = everIniFile.GetString("BIOS", "BIOSID", "")
        frmComputers.PROizV5.Text = everIniFile.GetString("BIOS", "MotherBoardOEM", "")


        '################
        'Память

        Dim uname As String

        uname = everIniFile.GetString("SPD", "1stModuleSize", "")

        If uname <> 0 Then

            frmComputers.cmbRAM1.Text = everIniFile.GetString("SPD", "1stModuleSize", "")
            frmComputers.PROizV6.Text = everIniFile.GetString("SPD", "1stModuleManufacturer", "")
            frmComputers.txtRamSN1.Text = everIniFile.GetString("SPD", "1stSerialNumber", "")
            frmComputers.txtRamS1.Text = everIniFile.GetString("SPD", "1stMemoryType", "")

        End If

        uname = everIniFile.GetString("SPD", "2ndModuleSize", "")

        If uname <> 0 Then

            frmComputers.cmbRAM2.Text = everIniFile.GetString("SPD", "2ndModuleSize", "")
            frmComputers.PROizV7.Text = everIniFile.GetString("SPD", "2ndModuleManufacturer", "")
            frmComputers.txtRamSN2.Text = everIniFile.GetString("SPD", "2ndSerialNumber", "")
            frmComputers.txtRamS2.Text = everIniFile.GetString("SPD", "2ndMemoryType", "")

        End If

        uname = everIniFile.GetString("SPD", "3rdModuleSize", "")

        If uname <> 0 Then

            frmComputers.cmbRAM3.Text = everIniFile.GetString("SPD", "3rdModuleSize", "")
            frmComputers.PROizV8.Text = everIniFile.GetString("SPD", "3rdModuleManufacturer", "")
            frmComputers.txtRamSN3.Text = everIniFile.GetString("SPD", "3rdSerialNumber", "")
            frmComputers.txtRamS3.Text = everIniFile.GetString("SPD", "3rdMemoryType", "")

        End If

        uname = everIniFile.GetString("SPD", "4thModuleSize", "")

        If uname <> 0 Then


            frmComputers.cmbRAM4.Text = everIniFile.GetString("SPD", "4thModuleSize", "")
            frmComputers.PROizV9.Text = everIniFile.GetString("SPD", "4thModuleManufacturer", "")
            frmComputers.txtRamSN4.Text = everIniFile.GetString("SPD", "4thSerialNumber", "")
            frmComputers.txtRamS4.Text = everIniFile.GetString("SPD", "4thMemoryType", "")
        End If

        '################
        'Жесткий диск
        '1


        frmComputers.cmbHDD1.Text = everIniFile.GetString("HDD", "1stHDDModel", "")
        frmComputers.txtHDDo1.Text = everIniFile.GetString("HDD", "1stHDDMarketingSize", "")
        frmComputers.txtHDDsN1.Text = everIniFile.GetString("HDD", "1stSerialNumber", "")
        'frmComputers.PROizV10.Text = everIniFile.GetString("HDD", "ATA1|Производитель ATA-устройства|Фирма", "")

        frmComputers.cmbHDD2.Text = everIniFile.GetString("HDD", "2ndHDDModel", "")
        frmComputers.txtHDDo2.Text = everIniFile.GetString("HDD", "2ndHDDMarketingSize", "")
        frmComputers.txtHDDsN2.Text = everIniFile.GetString("HDD", "2ndSerialNumber", "")
        'frmComputers.PROizV10.Text = everIniFile.GetString("HDD", "ATA1|Производитель ATA-устройства|Фирма", "")

        frmComputers.cmbHDD3.Text = everIniFile.GetString("HDD", "3rdHDDModel", "")
        frmComputers.txtHDDo3.Text = everIniFile.GetString("HDD", "3rdHDDMarketingSize", "")
        frmComputers.txtHDDsN3.Text = everIniFile.GetString("HDD", "3rdSerialNumber", "")
        'frmComputers.PROizV10.Text = everIniFile.GetString("HDD", "ATA1|Производитель ATA-устройства|Фирма", "")

        frmComputers.cmbHDD4.Text = everIniFile.GetString("HDD", "4thHDDModel", "")
        frmComputers.txtHDDo4.Text = everIniFile.GetString("HDD", "4thHDDMarketingSize", "")
        frmComputers.txtHDDsN4.Text = everIniFile.GetString("HDD", "4thSerialNumber", "")
        'frmComputers.PROizV10.Text = everIniFile.GetString("HDD", "ATA1|Производитель ATA-устройства|Фирма", "")


        '################
        'SVGA

        frmComputers.cmbSVGA1.Text = everIniFile.GetString("Video", "VideoChip", "")
        frmComputers.txtSVGAr1.Text = everIniFile.GetString("Video", "VideoMemory", "")
        'frmComputers.txtSVGAs1.Text = everIniFile.GetString("Видео Windows", "Номер видео карты", "")
        frmComputers.PROizV14.Text = everIniFile.GetString("Video", "VideoChipVendor", "")


        '################
        'Звуковая карта

        frmComputers.cmbSound.Text = everIniFile.GetString("Other", "CodecName", "")
        frmComputers.PROizV16.Text = everIniFile.GetString("Other", "SoundSubsystemVendor", "")
        'frmComputers.cmbSound.Text = Replace(frmComputers.cmbSound.Text, "'", " ", "")


        '################
        'CD-ROM

        frmComputers.cmbOPTIC1.Text = everIniFile.GetString("ATAPI", "1stCD-ROMModel", "")
        frmComputers.txtOPTICsn1.Text = everIniFile.GetString("ATAPI", "1stSerialNumber", "")
        'frmComputers.PROizV17.Text = everIniFile.GetString("ATAPI", "Оптические накопители2" & "|Производитель устройства|Фирма", "")
        frmComputers.txtOPTICs1.Text = everIniFile.GetString("ATAPI", "1stWriteSpeed", "")

        frmComputers.cmbOPTIC2.Text = everIniFile.GetString("ATAPI", "2ndCD-ROMModel", "")
        frmComputers.txtOPTICsn2.Text = everIniFile.GetString("ATAPI", "2ndSerialNumber", "")
        'frmComputers.PROizV17.Text = everIniFile.GetString("ATAPI", "Оптические накопители2" & "|Производитель устройства|Фирма", "")
        frmComputers.txtOPTICs2.Text = everIniFile.GetString("ATAPI", "2ndWriteSpeed", "")


        '################
        'Сетевая карта

        frmComputers.cmbNET1.Text = everIniFile.GetString("Network", "1stPCINetworkCard", "")
        frmComputers.txtNETip1.Text = everIniFile.GetString("Network", "1stIPAddress", "")
        frmComputers.txtNETmac1.Text = everIniFile.GetString("Network", "1stMACAddress", "")
        frmComputers.PROizV20.Text = everIniFile.GetString("Network", "1stPCINetworkVendor", "")

        frmComputers.cmbNET2.Text = everIniFile.GetString("Network", "2ndPCINetworkCard", "")
        frmComputers.txtNETip2.Text = everIniFile.GetString("Network", "2ndIPAddress", "")
        frmComputers.txtNETmac2.Text = everIniFile.GetString("Network", "2ndMACAddress", "")
        frmComputers.PROizV21.Text = everIniFile.GetString("Network", "2ndPCINetworkVendor", "")


        '################
        'Монитор
        frmComputers.cmbMon1.Text = everIniFile.GetString("Monitor", "MonitorModel", "")
        frmComputers.txtMon1Dum.Text = everIniFile.GetString("Monitor", "Diagonal", "")
        frmComputers.txtMon1SN.Text = everIniFile.GetString("Monitor", "SerialNumber", "")
        frmComputers.PROizV28.Text = everIniFile.GetString("Monitor", "MonitorVendor", "")


        '################
        'Дисковод

        frmComputers.cmbFDD.Text = everIniFile.GetString("Other", "FloppyDrives", "")


        '################
        'Модем

        frmComputers.cmbModem.Text = everIniFile.GetString("Other", "1ModemModel", "")
        frmComputers.PROizV24.Text = everIniFile.GetString("Other", "1ModemVendor", "")


        '################
        'Клавиатура
        'frmComputers.cmbKeyb.Text = everIniFile.GetString("Суммарная информация", "Ввод|Клавиатура", "")


        '################
        'Мышь
        'frmComputers.cmbMouse.Text = everIniFile.GetString("Суммарная информация", "Ввод|Мышь", "")


        '################
        'Имя компа
        frmComputers.txtSNAME.Text = everIniFile.GetString("Network", "NetworkName", "")

        If Len(frmComputers.txtSNAME.Text) = 0 Then frmComputers.txtSNAME.Text = "NoName"

        frmComputers.txtPSEUDONIM.Text = frmComputers.txtSNAME.Text


        '################
        'Принтеры

        frmComputers.cmbPrinters1.Text = everIniFile.GetString("Other", "1stPrinterModel", "")
        frmComputers.PROizV34.Text = everIniFile.GetString("Other", "1stPrinterVendor", "")
        'frmComputers.txtPrint1Port.Text = everIniFile.GetString("Other", "Принтеры1|Свойства принтера|Порт принтера", "")


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
        Dim everIniFile As New IniFile(EverestFilePatch)

        'On Error GoTo Err_handler
        On Error Resume Next
        A = "InstalledPrograms"
        frmComputers.lstSoftware.Items.Clear()
        intcount = 0
        For intj = 1 To 400

            A = "Program" & intj

            uname = everIniFile.GetString("InstalledPrograms", A, "")
            'uname1 = everIniFile.GetString("Установленные программы", uname & "|Publisher", "")
            'uname2 = everIniFile.GetString("Установленные программы", uname & "|Дата", "")

            If Len(uname) = 0 Or uname = "" Then

            Else


                frmComputers.lstSoftware.Items.Add(frmComputers.lstSoftware.Items.Count + 1)
                frmComputers.lstSoftware.Items(intcount).SubItems.Add(frmComputers.lstSoftware.Items.Count + 1)
                frmComputers.lstSoftware.Items(intcount).SubItems.Add(uname)
                frmComputers.lstSoftware.Items(intcount).SubItems.Add("")
                frmComputers.lstSoftware.Items(intcount).SubItems.Add("")
                frmComputers.lstSoftware.Items(intcount).SubItems.Add(Date.Today)
                frmComputers.lstSoftware.Items(intcount).SubItems.Add(Date.Today)
                frmComputers.lstSoftware.Items(intcount).SubItems.Add("")

                intcount = intcount + 1
            End If
        Next


        'Лицензионный номер Операционной системы

        Dim OS_OS, SAGAZOD, B As String

        OS_OS$ = everIniFile.GetString("Other", "MultitaskOS", "")
        SAGAZOD$ = everIniFile.GetString("Other", "ProductID", "")
        OS_OS$ = OS_OS$ & " " & everIniFile.GetString("Other", "WindowsBuild", "")
        frmComputers.lstSoftware.Items.Add(frmComputers.lstSoftware.Items.Count + 1)
        frmComputers.lstSoftware.Items(intcount).SubItems.Add(frmComputers.lstSoftware.Items.Count + 1)
        frmComputers.lstSoftware.Items(intcount).SubItems.Add(OS_OS$)
        frmComputers.lstSoftware.Items(intcount).SubItems.Add(SAGAZOD$)
        frmComputers.lstSoftware.Items(intcount).SubItems.Add("")
        frmComputers.lstSoftware.Items(intcount).SubItems.Add(Date.Today)
        frmComputers.lstSoftware.Items(intcount).SubItems.Add(Date.Today)
        frmComputers.lstSoftware.Items(intcount).SubItems.Add("Microsoft Corporation")
        frmComputers.lstSoftware.Items(intcount).SubItems.Add("Операционная система")

        'intcount = intcount + 1

        Exit Sub
        Err_handler:
        MsgBox(Err.Description)
    End Sub
End Module
