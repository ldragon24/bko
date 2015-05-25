Module MOD_EVEREST_LOAD
    Private stLKEY As String

    Public Sub Everest_Load()
        On Error Resume Next


        Dim everIniFile As New IniFile(EverestFilePatch)


        'frmComputers.cmbResponsible.Text = everIniFile.GetString("Суммарная информация", "Компьютер|Имя пользователя", "")

        frmComputers.cmbCPU1.Text = everIniFile.GetString("DMI", "Процессоры1|Свойства процессора|Версия", "")
        frmComputers.txtMHZ1.Text = everIniFile.GetString("DMI", "Процессоры1|Свойства процессора|Текущая частота", "")
        frmComputers.txtSoc1.Text = everIniFile.GetString("DMI", "Процессоры1|Свойства процессора|Тип разъёма", "")
        frmComputers.PROizV1.Text = everIniFile.GetString("DMI", "Процессоры1|Свойства процессора|Производитель", "")

        frmComputers.cmbCPU2.Text = everIniFile.GetString("DMI", "Процессоры2|Свойства процессора|Версия", "")
        frmComputers.txtMHZ2.Text = everIniFile.GetString("DMI", "Процессоры2|Свойства процессора|Текущая частота", "")
        frmComputers.txtSoc2.Text = everIniFile.GetString("DMI", "Процессоры2|Свойства процессора|Тип разъёма", "")
        frmComputers.PROizV2.Text = everIniFile.GetString("DMI", "Процессоры2|Свойства процессора|Производитель", "")

        frmComputers.cmbCPU3.Text = everIniFile.GetString("DMI", "Процессоры3|Свойства процессора|Версия", "")
        frmComputers.txtMHZ3.Text = everIniFile.GetString("DMI", "Процессоры3|Свойства процессора|Текущая частота", "")
        frmComputers.txtSoc3.Text = everIniFile.GetString("DMI", "Процессоры3|Свойства процессора|Тип разъёма", "")
        frmComputers.PROizV3.Text = everIniFile.GetString("DMI", "Процессоры3|Свойства процессора|Производитель", "")

        frmComputers.cmbCPU4.Text = everIniFile.GetString("DMI", "Процессоры4|Свойства процессора|Версия", "")
        frmComputers.txtMHZ4.Text = everIniFile.GetString("DMI", "Процессоры4|Свойства процессора|Текущая частота", "")
        frmComputers.txtSoc4.Text = everIniFile.GetString("DMI", "Процессоры4|Свойства процессора|Тип разъёма", "")
        frmComputers.PROizV4.Text = everIniFile.GetString("DMI", "Процессоры4|Свойства процессора|Производитель", "")

        If Len(frmComputers.cmbCPU1.Text) = 0 Then
            frmComputers.cmbCPU1.Text = everIniFile.GetString("Суммарная информация", "Системная плата|Тип ЦП", "")
        End If


        frmComputers.txtModSB.Text = everIniFile.GetString("Суммарная информация", "DMI|DMI система", "")
        frmComputers.txtSNSB.Text = everIniFile.GetString("DMI", "Система|Свойства системы|Серийный номер", "")
        frmComputers.PROizV27.Text = everIniFile.GetString("Суммарная информация", "DMI|DMI производитель системы", "")


        '################
        'Материнка
        frmComputers.cmbMB.Text = everIniFile.GetString("Системная плата", "Свойства системной платы|Системная плата",
                                                        "")
        frmComputers.txtChip.Text = everIniFile.GetString("Чипсет",
                                                          "Свойства набора микросхем (чипсета)|Чипсет системной платы",
                                                          "")
        If Len(frmComputers.txtChip.Text) = 0 Then
            frmComputers.txtChip.Text = everIniFile.GetString("Суммарная информация",
                                                              "Системная плата|Чипсет системной платы", "")
        End If

        frmComputers.txtSN_MB.Text = everIniFile.GetString("Суммарная информация",
                                                           "DMI|DMI серийный номер системной платы", "")

        If Len(frmComputers.txtSN_MB.Text) = 0 Then
            frmComputers.txtSN_MB.Text = everIniFile.GetString("DMI",
                                                               "Системная плата|Свойства системной платы|Серийный номер",
                                                               "")
        Else
        End If

        frmComputers.PROizV5.Text = everIniFile.GetString("Системная плата", "Производитель системной платы|Фирма", "")

        If Len(frmComputers.PROizV5.Text) = 0 Then
            frmComputers.PROizV5.Text = everIniFile.GetString("DMI",
                                                              "Системная плата|Свойства системной платы|Производитель",
                                                              "")
        Else
        End If

        If Len(frmComputers.cmbMB.Text) = 0 Then
            frmComputers.cmbMB.Text = everIniFile.GetString("Суммарная информация", "Системная плата|Системная плата",
                                                            "")
        Else
        End If

        If frmComputers.cmbMB.Text = "Unknown" Or frmComputers.cmbMB.Text = "Неизвестно" Then
            frmComputers.cmbMB.Text = everIniFile.GetString("Суммарная информация", "DMI|DMI системная плата", "")
        Else
        End If
        '################
        'Память

        frmComputers.cmbRAM1.Text = everIniFile.GetString("SPD", "SPD1|Свойства модуля памяти|Размер модуля", "")
        frmComputers.PROizV6.Text = everIniFile.GetString("SPD", "SPD1|Производитель модуля памяти|Фирма", "")
        frmComputers.txtRamSN1.Text = everIniFile.GetString("SPD", "SPD1|Свойства модуля памяти|Серийный номер", "")
        frmComputers.txtRamS1.Text = everIniFile.GetString("SPD", "SPD1|Свойства модуля памяти|Скорость памяти", "")

        frmComputers.cmbRAM2.Text = everIniFile.GetString("SPD", "SPD2|Свойства модуля памяти|Размер модуля", "")
        frmComputers.PROizV7.Text = everIniFile.GetString("SPD", "SPD2|Производитель модуля памяти|Фирма", "")
        frmComputers.txtRamSN2.Text = everIniFile.GetString("SPD", "SPD2|Свойства модуля памяти|Серийный номер", "")
        frmComputers.txtRamS2.Text = everIniFile.GetString("SPD", "SPD2|Свойства модуля памяти|Скорость памяти", "")

        frmComputers.cmbRAM3.Text = everIniFile.GetString("SPD", "SPD3|Свойства модуля памяти|Размер модуля", "")
        frmComputers.PROizV8.Text = everIniFile.GetString("SPD", "SPD3|Производитель модуля памяти|Фирма", "")
        frmComputers.txtRamSN3.Text = everIniFile.GetString("SPD", "SPD3|Свойства модуля памяти|Серийный номер", "")
        frmComputers.txtRamS3.Text = everIniFile.GetString("SPD", "SPD3|Свойства модуля памяти|Скорость памяти", "")

        frmComputers.cmbRAM4.Text = everIniFile.GetString("SPD", "SPD4|Свойства модуля памяти|Размер модуля", "")
        frmComputers.PROizV9.Text = everIniFile.GetString("SPD", "SPD4|Производитель модуля памяти|Фирма", "")
        frmComputers.txtRamSN4.Text = everIniFile.GetString("SPD", "SPD4|Свойства модуля памяти|Серийный номер", "")
        frmComputers.txtRamS4.Text = everIniFile.GetString("SPD", "SPD4|Свойства модуля памяти|Скорость памяти", "")

        frmComputers.cmbRAM5.Text = everIniFile.GetString("SPD", "SPD5|Свойства модуля памяти|Размер модуля", "")
        frmComputers.PROizV44.Text = everIniFile.GetString("SPD", "SPD5|Производитель модуля памяти|Фирма", "")
        frmComputers.txtRamSN5.Text = everIniFile.GetString("SPD", "SPD5|Свойства модуля памяти|Серийный номер", "")
        frmComputers.txtRamS5.Text = everIniFile.GetString("SPD", "SPD5|Свойства модуля памяти|Скорость памяти", "")

        frmComputers.cmbRAM6.Text = everIniFile.GetString("SPD", "SPD6|Свойства модуля памяти|Размер модуля", "")
        frmComputers.PROizV45.Text = everIniFile.GetString("SPD", "SPD6|Производитель модуля памяти|Фирма", "")
        frmComputers.txtRamSN6.Text = everIniFile.GetString("SPD", "SPD6|Свойства модуля памяти|Серийный номер", "")
        frmComputers.txtRamS6.Text = everIniFile.GetString("SPD", "SPD6|Свойства модуля памяти|Скорость памяти", "")

        frmComputers.cmbRAM7.Text = everIniFile.GetString("SPD", "SPD7|Свойства модуля памяти|Размер модуля", "")
        frmComputers.PROizV46.Text = everIniFile.GetString("SPD", "SPD7|Производитель модуля памяти|Фирма", "")
        frmComputers.txtRamSN7.Text = everIniFile.GetString("SPD", "SPD7|Свойства модуля памяти|Серийный номер", "")
        frmComputers.txtRamS7.Text = everIniFile.GetString("SPD", "SPD7|Свойства модуля памяти|Скорость памяти", "")

        frmComputers.cmbRAM8.Text = everIniFile.GetString("SPD", "SPD8|Свойства модуля памяти|Размер модуля", "")
        frmComputers.PROizV47.Text = everIniFile.GetString("SPD", "SPD8|Производитель модуля памяти|Фирма", "")
        frmComputers.txtRamSN8.Text = everIniFile.GetString("SPD", "SPD8|Свойства модуля памяти|Серийный номер", "")
        frmComputers.txtRamS8.Text = everIniFile.GetString("SPD", "SPD8|Свойства модуля памяти|Скорость памяти", "")


        'If Len(frmComputers.cmbRAM1.Text) = 0 Then
        '    frmComputers.cmbRAM1.Text = everIniFile.GetString("DMI", "Устройства памяти1|Свойства устройства памяти|Размер", "")
        '    frmComputers.txtRamS1.Text = everIniFile.GetString("DMI", "Устройства памяти1|Свойства устройства памяти|Скорость", "")
        '    frmComputers.txtRamSN1.Text = everIniFile.GetString("DMI", "Устройства памяти1|Свойства устройства памяти|Серийный номер", "")
        '    frmComputers.PROizV6.Text = everIniFile.GetString("DMI", "Устройства памяти1|Свойства устройства памяти|Производитель", "")
        'End If

        'If Len(frmComputers.cmbRAM2.Text) = 0 Then

        '    If Len(everIniFile.GetString("DMI", "Устройства памяти2|Свойства устройства памяти|Размер", "")) <> 0 Then
        '        frmComputers.cmbRAM2.Text = everIniFile.GetString("DMI", "Устройства памяти2|Свойства устройства памяти|Размер", "")
        '        frmComputers.txtRamS2.Text = everIniFile.GetString("DMI", "Устройства памяти2|Свойства устройства памяти|Скорость", "")
        '        frmComputers.txtRamSN2.Text = everIniFile.GetString("DMI", "Устройства памяти2|Свойства устройства памяти|Серийный номер", "")
        '        frmComputers.PROizV7.Text = everIniFile.GetString("DMI", "Устройства памяти2|Свойства устройства памяти|Производитель", "")
        '    End If

        'End If

        'If Len(frmComputers.cmbRAM3.Text) = 0 Then
        '    If Len(everIniFile.GetString("DMI", "Устройства памяти3|Свойства устройства памяти|Размер", "")) <> 0 Then
        '        frmComputers.cmbRAM3.Text = everIniFile.GetString("DMI", "Устройства памяти3|Свойства устройства памяти|Размер", "")
        '        frmComputers.txtRamS3.Text = everIniFile.GetString("DMI", "Устройства памяти3|Свойства устройства памяти|Скорость", "")
        '        frmComputers.txtRamSN3.Text = everIniFile.GetString("DMI", "Устройства памяти3|Свойства устройства памяти|Серийный номер", "")
        '        frmComputers.PROizV8.Text = everIniFile.GetString("DMI", "Устройства памяти3|Свойства устройства памяти|Производитель", "")
        '    End If
        'End If

        'If Len(frmComputers.cmbRAM4.Text) = 0 Then
        '    If Len(everIniFile.GetString("DMI", "Устройства памяти4|Свойства устройства памяти|Размер", "")) <> 0 Then
        '        frmComputers.cmbRAM4.Text = everIniFile.GetString("DMI", "Устройства памяти4|Свойства устройства памяти|Размер", "")
        '        frmComputers.txtRamS4.Text = everIniFile.GetString("DMI", "Устройства памяти4|Свойства устройства памяти|Скорость", "")
        '        frmComputers.txtRamSN4.Text = everIniFile.GetString("DMI", "Устройства памяти4|Свойства устройства памяти|Серийный номер", "")
        '        frmComputers.PROizV9.Text = everIniFile.GetString("DMI", "Устройства памяти4|Свойства устройства памяти|Производитель", "")
        '    End If
        'End If


        If Len(frmComputers.cmbRAM1.Text) = 0 Then
            frmComputers.cmbRAM1.Text = everIniFile.GetString("Суммарная информация", "Системная плата|Системная память",
                                                              "")
        End If


        'Устройства памяти1|Свойства устройства памяти|Размер
        '################
        'Жесткий диск
        '1
        Dim uname, nom_pos1, nom_pos2, ob_lenght, ob1, ob_rez As String

        frmComputers.cmbHDD1.Text = everIniFile.GetString("ATA", "ATA1|Свойства устройства ATA|ID модели", "")
        frmComputers.txtHDDo1.Text = everIniFile.GetString("ATA",
                                                           "ATA1|Физические данные устройства ATA|Форматированная ёмкость",
                                                           "")
        If Len(frmComputers.txtHDDo1.Text) = 0 Then
            uname = everIniFile.GetString("ATA", "ATA1|Свойства устройства ATA|Неформатированная ёмкость", "")

            uname = Left(uname, Len(uname) - 3)
            uname = CInt(uname / 1024) & " Gb"
            frmComputers.txtHDDo1.Text = uname
        End If

        frmComputers.txtHDDsN1.Text = everIniFile.GetString("ATA", "ATA1|Свойства устройства ATA|Серийный номер", "")
        frmComputers.PROizV10.Text = everIniFile.GetString("ATA", "ATA1|Производитель ATA-устройства|Фирма", "")

        '2
        frmComputers.cmbHDD2.Text = everIniFile.GetString("ATA", "ATA2|Свойства устройства ATA|ID модели", "")
        frmComputers.txtHDDo2.Text = everIniFile.GetString("ATA",
                                                           "ATA2|Физические данные устройства ATA|Форматированная ёмкость",
                                                           "")
        frmComputers.txtHDDsN2.Text = everIniFile.GetString("ATA", "ATA2|Свойства устройства ATA|Серийный номер", "")
        frmComputers.PROizV11.Text = everIniFile.GetString("ATA", "ATA2|Производитель ATA-устройства|Фирма", "")

        '3
        frmComputers.cmbHDD3.Text = everIniFile.GetString("ATA", "ATA3|Свойства устройства ATA|ID модели", "")
        frmComputers.txtHDDsN3.Text = everIniFile.GetString("ATA",
                                                            "ATA3|Физические данные устройства ATA|Форматированная ёмкость",
                                                            "")
        frmComputers.txtHDDsN3.Text = everIniFile.GetString("ATA", "ATA3|Свойства устройства ATA|Серийный номер", "")
        frmComputers.PROizV12.Text = everIniFile.GetString("ATA", "ATA3|Производитель ATA-устройства|Фирма", "")

        '4
        frmComputers.cmbHDD4.Text = everIniFile.GetString("ATA", "ATA4|Свойства устройства ATA|ID модели", "")
        frmComputers.txtHDDo4.Text = everIniFile.GetString("ATA",
                                                           "ATA4|Физические данные устройства ATA|Форматированная ёмкость",
                                                           "")
        frmComputers.txtHDDsN4.Text = everIniFile.GetString("ATA", "ATA4|Свойства устройства ATA|Серийный номер", "")
        frmComputers.PROizV13.Text = everIniFile.GetString("ATA", "ATA4|Производитель ATA-устройства|Фирма", "")

        frmComputers.cmbHDD5.Text = everIniFile.GetString("ATA", "ATA5|Свойства устройства ATA|ID модели", "")
        frmComputers.txtHDDo5.Text = everIniFile.GetString("ATA",
                                                           "ATA5|Физические данные устройства ATA|Форматированная ёмкость",
                                                           "")
        frmComputers.txtHDDsN5.Text = everIniFile.GetString("ATA", "ATA5|Свойства устройства ATA|Серийный номер", "")
        frmComputers.PROizV48.Text = everIniFile.GetString("ATA", "ATA5|Производитель ATA-устройства|Фирма", "")

        frmComputers.cmbHDD6.Text = everIniFile.GetString("ATA", "ATA6|Свойства устройства ATA|ID модели", "")
        frmComputers.txtHDDo6.Text = everIniFile.GetString("ATA",
                                                           "ATA6|Физические данные устройства ATA|Форматированная ёмкость",
                                                           "")
        frmComputers.txtHDDsN6.Text = everIniFile.GetString("ATA", "ATA6|Свойства устройства ATA|Серийный номер", "")
        frmComputers.PROizV49.Text = everIniFile.GetString("ATA", "ATA6|Производитель ATA-устройства|Фирма", "")

        frmComputers.cmbHDD7.Text = everIniFile.GetString("ATA", "ATA7|Свойства устройства ATA|ID модели", "")
        frmComputers.txtHDDo7.Text = everIniFile.GetString("ATA",
                                                           "ATA7|Физические данные устройства ATA|Форматированная ёмкость",
                                                           "")
        frmComputers.txtHDDsN7.Text = everIniFile.GetString("ATA", "ATA7|Свойства устройства ATA|Серийный номер", "")
        frmComputers.PROizV50.Text = everIniFile.GetString("ATA", "ATA7|Производитель ATA-устройства|Фирма", "")

        frmComputers.cmbHDD8.Text = everIniFile.GetString("ATA", "ATA8|Свойства устройства ATA|ID модели", "")
        frmComputers.txtHDDo8.Text = everIniFile.GetString("ATA",
                                                           "ATA8|Физические данные устройства ATA|Форматированная ёмкость",
                                                           "")
        frmComputers.txtHDDsN8.Text = everIniFile.GetString("ATA", "ATA8|Свойства устройства ATA|Серийный номер", "")
        frmComputers.PROizV51.Text = everIniFile.GetString("ATA", "ATA8|Производитель ATA-устройства|Фирма", "")

        '------------------
        If Len(frmComputers.cmbHDD1.Text) = 0 Or frmComputers.cmbHDD1.Text = "IOMEGA ZIP 100" Then

            frmComputers.cmbHDD1.Text = everIniFile.GetString("EIDE",
                                                              "EIDE1|Физические данные устройства EIDE|Название жёсткого диска",
                                                              "")
            frmComputers.txtHDDo1.Text = everIniFile.GetString("EIDE",
                                                               "EIDE1|Физические данные устройства EIDE|Форматированная ёмкость",
                                                               "")
            frmComputers.PROizV10.Text = everIniFile.GetString("EIDE", "EIDE1|Производитель EIDE-устройства|Фирма", "")

        End If


        If Len(frmComputers.cmbHDD1.Text) = 0 Or frmComputers.cmbHDD1.Text = "IOMEGA ZIP 100" Then
            'Винт
            frmComputers.cmbHDD1.Text = everIniFile.GetString("Хранение данных Windows",
                                                              "Хранение данных Windows2|Физические данные дискового накопителя|Название жёсткого диска",
                                                              "")
            frmComputers.txtHDDo1.Text = everIniFile.GetString("Хранение данных Windows",
                                                               "Хранение данных Windows2|Физические данные дискового накопителя|Форматированная ёмкость",
                                                               "")
            frmComputers.PROizV10.Text = everIniFile.GetString("Хранение данных Windows",
                                                               "Хранение данных Windows2|Производитель устройства|Фирма",
                                                               "")

        End If


        If Len(frmComputers.cmbHDD1.Text) = 0 Or frmComputers.cmbHDD1.Text = "IOMEGA ZIP 100" Then
            frmComputers.cmbHDD1.Text = everIniFile.GetString("Хранение данных Windows",
                                                              "Хранение данных Windows1|Физические данные дискового накопителя|Название жёсткого диска",
                                                              "")
            frmComputers.txtHDDo1.Text = everIniFile.GetString("Хранение данных Windows",
                                                               "Хранение данных Windows1|Физические данные дискового накопителя|Форматированная ёмкость",
                                                               "")
            frmComputers.PROizV10.Text = everIniFile.GetString("Хранение данных Windows",
                                                               "Хранение данных Windows1|Производитель устройства|Фирма",
                                                               "")
        End If


        'If Len(frmComputers.cmbHDD1.Text) = 0 Or frmComputers.cmbHDD1.Text = "IOMEGA ZIP 100" Then
        'frmComputers.cmbHDD1.Text = everIniFile.GetString("Хранение данных Windows", "Хранение данных Windows3|Свойства устройства|Описание драйвера", "")
        'frmComputers.txtHDDo1.Text = everIniFile.GetString("Хранение данных Windows", "Хранение данных Windows3|Физические данные дискового накопителя|Форматированная ёмкость", "")
        'frmComputers.PROizV10.Text = everIniFile.GetString("Хранение данных Windows", "Хранение данных Windows3|Производитель устройства|Фирма", "")
        'End If


        If Len(frmComputers.PROizV10.Text) = 0 Then
            frmComputers.PROizV10.Text = everIniFile.GetString("Хранение данных Windows",
                                                               "Хранение данных Windows1|Производитель устройства|Фирма",
                                                               "")
        End If


        'Код прислал Славик (aka vindpi) для старой версии, с тех пор не модефицировался

        If Len(frmComputers.cmbHDD1.Text) = 0 Then
            If Len(frmComputers.PROizV10.Text) = 0 Then
                frmComputers.PROizV10.Text = ""
            End If

            uname = everIniFile.GetString("Суммарная информация", "Хранение данных|Дисковый накопитель1", "")
            If Right(uname, 4) = "USB)" Then

            Else
                frmComputers.cmbHDD1.Text = everIniFile.GetString("Суммарная информация",
                                                                  "Хранение данных|Дисковый накопитель1", "")

                uname = everIniFile.GetString("Суммарная информация", "Разделы|Раздел1", "")

                If Len(frmComputers.cmbHDD1.Text) = 0 Then
                    frmComputers.cmbHDD1.Text = everIniFile.GetString("Суммарная информация",
                                                                      "Хранение данных|Дисковый накопитель", "")

                    uname = everIniFile.GetString("Суммарная информация", "Разделы|C: (FAT32)", "")

                    If Len(uname) = 0 Then
                        uname = everIniFile.GetString("Суммарная информация", "Разделы|C: (NTFS)", "")
                    End If
                Else
                End If

                nom_pos1 = InStr(uname, ")") + 2
                nom_pos2 = InStr(nom_pos1, uname, " ", "") + 1
                ob_lenght = nom_pos2 - nom_pos1
                ob1 = Mid(uname, nom_pos1, ob_lenght)
                ob_rez = CInt(ob1)
            End If

            uname = everIniFile.GetString("Суммарная информация", "Разделы|Раздел2", "")
            If Len(uname) = 0 Then
                uname = everIniFile.GetString("Суммарная информация", "Разделы|D: (FAT32)", "")
                If Len(uname) = 0 Then
                    uname = everIniFile.GetString("Суммарная информация", "Разделы|D: (NTFS)", "")
                End If

            Else
            End If
            Dim ob_Gb, ob2, ob3, ASqw As String

            If Len(uname) > 2 Then
                nom_pos1 = InStr(uname, ")") + 2
                nom_pos2 = InStr(nom_pos1, uname, " ", "") + 1
                ob_lenght = nom_pos2 - nom_pos1
                ob2 = Mid(uname, nom_pos1, ob_lenght)
                ob_rez = ob_rez + ob2
            End If

            uname = everIniFile.GetString("Суммарная информация", "Разделы|Раздел3", "")

            If Len(uname) > 2 Then
                nom_pos1 = InStr(uname, ")") + 2
                nom_pos2 = InStr(nom_pos1, uname, " ", "") + 1
                ob_lenght = nom_pos2 - nom_pos1
                ob3 = Mid(uname, nom_pos1, ob_lenght)
                ob_rez = ob_rez + ob3
            End If

            If Len(ob_rez) = 0 Then
                ob_rez = ob1 + ob2 + ob3
            Else
            End If
            ob_Gb = CStr(ob_rez / 1000) & " Гб"
            frmComputers.txtHDDo1.Text = ob_Gb

            uname = everIniFile.GetString("Суммарная информация", "Разделы|Общий объем", "")

            If Len(uname) = 0 Then
            Else
                ASqw = Left$(uname, 6)
            End If

            ob_Gb = CStr(ASqw / 1000) & " Гб"

            If frmComputers.txtHDDo1.Text <> ob_Gb Then
                frmComputers.txtHDDo1.Text = ob_Gb
            Else
            End If

        End If


        '##########################################################
        If Len(frmComputers.txtHDDo1.Text) = 0 Then
            frmComputers.txtHDDo1.Text = everIniFile.GetString("ATA",
                                                               "ATA1|Свойства устройства ATA|Неформатированная ёмкость",
                                                               "")
        End If
        If Len(frmComputers.txtHDDo2.Text) = 0 Then
            frmComputers.txtHDDo2.Text = everIniFile.GetString("ATA",
                                                               "ATA2|Свойства устройства ATA|Неформатированная ёмкость",
                                                               "")
        End If
        If Len(frmComputers.txtHDDsN3.Text) = 0 Then
            frmComputers.txtHDDsN3.Text = everIniFile.GetString("ATA",
                                                                "ATA3|Свойства устройства ATA|Неформатированная ёмкость",
                                                                "")
        End If
        If Len(frmComputers.txtHDDsN4.Text) = 0 Then
            frmComputers.txtHDDsN4.Text = everIniFile.GetString("ATA",
                                                                "ATA4|Свойства устройства ATA|Неформатированная ёмкость",
                                                                "")
        End If

        If Len(frmComputers.cmbHDD1.Text) = 0 Then
            uname = everIniFile.GetString("Суммарная информация", "Хранение данных|Дисковый накопитель1", "")

            If Right(uname, 4) = "USB)" Then

            Else

                If Len(frmComputers.cmbHDD1.Text) = 0 Then
                    frmComputers.cmbHDD1.Text = everIniFile.GetString("Суммарная информация",
                                                                      "Хранение данных|Дисковый накопитель1", "")
                    'frmComputers.txtHDDo1.Text = everIniFile.GetString("Суммарная информация", "ATA1|Физические данные устройства ATA|Форматированная ёмкость", "")
                    'frmComputers.txtHDDsN1.Text = everIniFile.GetString("Суммарная информация", "ATA1|Свойства устройства ATA|Серийный номер", "")
                    'frmComputers.PROizV10.Text = everIniFile.GetString("Суммарная информация", "ATA1|Производитель ATA-устройства|Фирма", "")
                End If
            End If

            If Len(frmComputers.cmbHDD1.Text) = 0 Then
                frmComputers.cmbHDD1.Text = everIniFile.GetString("Суммарная информация",
                                                                  "Хранение данных|Дисковый накопитель2", "")
                frmComputers.cmbHDD2.Text = everIniFile.GetString("Суммарная информация",
                                                                  "Хранение данных|Дисковый накопитель3", "")

            End If
        End If


        If Len(frmComputers.txtHDDo1.Text) = 0 Or frmComputers.txtHDDo1.Text = "0 Гб" Then
            frmComputers.cmbHDD1.Text = everIniFile.GetString("Хранение данных Windows",
                                                              "Хранение данных Windows1|Физические данные дискового накопителя|Название жёсткого диска",
                                                              "")
            frmComputers.txtHDDo1.Text = everIniFile.GetString("Хранение данных Windows",
                                                               "Хранение данных Windows1|Физические данные дискового накопителя|Форматированная ёмкость",
                                                               "")
            frmComputers.PROizV10.Text = everIniFile.GetString("Хранение данных Windows",
                                                               "Хранение данных Windows1|Производитель устройства|Фирма",
                                                               "")
        End If


        '################
        'SVGA

        frmComputers.cmbSVGA1.Text = everIniFile.GetString("Видео Windows",
                                                           "Видео Windows1|Свойства видеоадаптера|Описание устройства",
                                                           "")
        frmComputers.txtSVGAr1.Text = everIniFile.GetString("Видео Windows",
                                                            "Видео Windows1|Свойства видеоадаптера|Объем видеоОЗУ", "")
        'frmComputers.txtSVGAs1.Text = everIniFile.GetString("Видео Windows", "Номер видео карты", "")
        frmComputers.PROizV14.Text = everIniFile.GetString("Видео Windows",
                                                           "Видео Windows1|Производитель видеоадаптера|Фирма", "")

        If Len(frmComputers.cmbSVGA1.Text) = 0 Then
            frmComputers.cmbSVGA1.Text = everIniFile.GetString("Суммарная информация", "Дисплей|Видеоадаптер1", "")
        End If

        If Len(frmComputers.cmbSVGA1.Text) = 0 Then
            frmComputers.cmbSVGA1.Text = everIniFile.GetString("Графический процессор",
                                                               "Свойства графического процессора|Видеоадаптер", "")
        End If

        If Len(frmComputers.PROizV14.Text) = 0 Then
            frmComputers.PROizV14.Text = everIniFile.GetString("Графический процессор",
                                                               "Производитель графического процессора|Фирма", "")
        End If

        If Len(frmComputers.txtSVGAr1.Text) = 0 Then
            frmComputers.txtSVGAr1.Text = everIniFile.GetString("Графический процессор",
                                                                "Свойства графического процессора|Объем видеоОЗУ", "")
        End If

        If Len(frmComputers.cmbSVGA1.Text) = 0 Then
            frmComputers.PROizV14.Text = " "
            frmComputers.cmbSVGA1.Text = everIniFile.GetString("Устройства Windows",
                                                               "Видеоадаптеры1|Свойства устройства|Описание драйвера",
                                                               "")
            frmComputers.txtSVGAr1.Text = " "
        End If

        '################
        'Звуковая карта

        frmComputers.cmbSound.Text = everIniFile.GetString("Аудио PCI / PnP", "Аудио PCI / PnP1", "")
        'frmComputers.cmbSound.Text = Replace(frmComputers.cmbSound.Text, "'", " ", "")


        If Len(frmComputers.cmbSound.Text) = 0 Then
            frmComputers.cmbSound.Text = everIniFile.GetString("Суммарная информация", "Мультимедиа|Звуковой адаптер1",
                                                               "")
            'frmComputers.cmbSound.Text = Replace(frmComputers.cmbSound.Text, "'", " ", "")
        End If

        If Len(frmComputers.cmbSound.Text) = 0 Then
            frmComputers.cmbSound.Text = everIniFile.GetString("Аудио PCI / PnP", "Аудио PCI / PnP", "")
            'frmComputers.cmbSound.Text = Replace(frmComputers.cmbSound.Text, "'", " ", "")
        End If

        '################
        'CD-ROM
        Dim A As String
        Dim B As String
        Dim c As String
        Dim intj As Integer

        'EVEREST
        '  If Len(frmComputers.cmbOPTIC1.Text) = 0 And Len(frmComputers.cmbOPTIC2.Text) = 0 And Len(frmComputers.cmbOPTIC3.Text) = 0 Then

        For intj = 1 To 10
            c = "Оптические накопители"
            c = c & intj

            A = everIniFile.GetString("Оптические накопители", c, "")
            B = everIniFile.GetString("Оптические накопители", c & "|Свойства оптического накопителя|Тип устройства", "")

            uname = everIniFile.GetString("Оптические накопители",
                                          "Оптические накопители1" &
                                          "|Свойства оптического накопителя|Описание устройства", "")

            If uname <> "Generic STEALTH DVD SCSI CdRom Device" Then
                If uname <> "NERO IMAGEDRIVE2 SCSI CdRom Device" Then
                    If uname <> "Generic DVD-ROM SCSI CdRom Device" Then
                        If uname <> "RW8314B IMV135U SCSI CdRom Device" Then

                            frmComputers.cmbOPTIC1.Text = uname
                            frmComputers.PROizV17.Text = everIniFile.GetString("Оптические накопители",
                                                                               "Оптические накопители1" &
                                                                               "|Производитель устройства|Фирма", "")
                            frmComputers.txtOPTICs1.Text = everIniFile.GetString("Оптические накопители",
                                                                                 "Оптические накопители1" &
                                                                                 "|Свойства оптического накопителя|Скорость",
                                                                                 "")
                        Else
                            frmComputers.cmbOPTIC1.Text = ""
                            frmComputers.PROizV17.Text = ""
                            frmComputers.txtOPTICs1.Text = ""
                        End If
                    End If
                End If

                uname = everIniFile.GetString("Оптические накопители",
                                              "Оптические накопители2" &
                                              "|Свойства оптического накопителя|Описание устройства", "")
                If uname <> "Generic STEALTH DVD SCSI CdRom Device" Then
                    If uname <> "NERO IMAGEDRIVE2 SCSI CdRom Device" Then
                        If uname <> "Generic DVD-ROM SCSI CdRom Device" Then
                            If uname <> "RW8314B IMV135U SCSI CdRom Device" Then
                                frmComputers.cmbOPTIC2.Text = uname
                                frmComputers.PROizV18.Text = everIniFile.GetString("Оптические накопители",
                                                                                   "Оптические накопители2" &
                                                                                   "|Производитель устройства|Фирма", "")
                                frmComputers.txtOPTICs2.Text = everIniFile.GetString("Оптические накопители",
                                                                                     "Оптические накопители2" &
                                                                                     "|Свойства оптического накопителя|Скорость",
                                                                                     "")
                            Else
                                frmComputers.cmbOPTIC2.Text = ""
                                frmComputers.PROizV18.Text = ""
                                frmComputers.txtOPTICs2.Text = ""
                            End If
                        End If
                    End If
                End If
                uname = everIniFile.GetString("Оптические накопители",
                                              "Оптические накопители3" &
                                              "|Свойства оптического накопителя|Описание устройства", "")
                If uname <> "Generic STEALTH DVD SCSI CdRom Device" Then
                    If uname <> "NERO IMAGEDRIVE2 SCSI CdRom Device" Then
                        If uname <> "Generic DVD-ROM SCSI CdRom Device" Then
                            If uname <> "RW8314B IMV135U SCSI CdRom Device" Then

                                'Generic DVD-ROM SCSI CdRom Device


                                frmComputers.cmbOPTIC3.Text = uname
                                frmComputers.PROizV19.Text = everIniFile.GetString("Оптические накопители",
                                                                                   "Оптические накопители3" &
                                                                                   "|Производитель устройства|Фирма", "")
                                frmComputers.txtOPTICs3.Text = everIniFile.GetString("Оптические накопители",
                                                                                     "Оптические накопители3" &
                                                                                     "|Свойства оптического накопителя|Скорость",
                                                                                     "")

                            Else
                                frmComputers.cmbOPTIC3.Text = ""
                                frmComputers.PROizV19.Text = ""
                                frmComputers.txtOPTICs3.Text = ""
                            End If
                        End If
                    End If
                End If
            End If
        Next


        If _
            Len(frmComputers.cmbOPTIC1.Text) = 0 And Len(frmComputers.cmbOPTIC2.Text) = 0 And
            Len(frmComputers.cmbOPTIC3.Text) = 0 Then

            For intj = 1 To 2
                c = "Оптические накопители"
                c = c & intj

                A = everIniFile.GetString("Оптические накопители", c, "")

                uname = A

                If uname <> "Generic STEALTH DVD SCSI CdRom Device" Then
                    If uname <> "NERO IMAGEDRIVE2 SCSI CdRom Device" Then
                        If uname <> "Generic DVD-ROM SCSI CdRom Device" Then
                            If uname <> "RW8314B IMV135U SCSI CdRom Device" Then
                                If Len(frmComputers.cmbOPTIC1.Text) = 0 Then
                                    frmComputers.cmbOPTIC1.Text = A
                                Else
                                    frmComputers.cmbOPTIC2.Text = A
                                End If

                            Else
                                frmComputers.cmbOPTIC1.Text = ""
                                frmComputers.PROizV17.Text = ""
                                frmComputers.txtOPTICs1.Text = ""
                            End If
                        End If
                    End If
                End If

            Next
        End If

        If _
            Len(frmComputers.cmbOPTIC2.Text) = 0 And Len(frmComputers.cmbOPTIC1.Text) = 0 And
            Len(frmComputers.cmbOPTIC3.Text) = 0 Then
            A = everIniFile.GetString("Суммарная информация", "Хранение данных|Оптический накопитель1", "")
            frmComputers.cmbOPTIC2.Text = A

        End If


        '################
        'Сетевая карта
        'Код изменен Славиком (aka vindpi) - доработан Алексеем Плотниковым
        Dim cn, setik, asa, asb, prov As String

        For intj = 1 To 3
            cn = "Сеть Windows"
            cn = cn & intj
            If cn = "Сеть Windows1" Then


                setik = everIniFile.GetString("Сеть Windows", cn & "|Свойства сетевого адаптера|Сетевой адаптер", "")
                If setik = "PPP Adapter." Or setik = "PPP Adapter" Or Len(setik) = 0 Then

                    GoTo nextA
                Else
                    frmComputers.cmbNET1.Text = setik
                End If


                asa$ = everIniFile.GetString("Сеть Windows", cn & "|Адреса сетевого адаптера|Маска IP / Подсети", "")
                asb$ = everIniFile.GetString("Сеть Windows", cn & "|Свойства сетевого адаптера|Аппаратный адрес", "")
                If Len(asa$) = 0 Then
                Else
                    frmComputers.txtNETip1.Text = asa$
                    frmComputers.txtNETmac1.Text = asb$

                    frmComputers.PROizV20.Text = everIniFile.GetString("Сеть Windows",
                                                                       cn & "|Производитель сетевого адаптера|Фирма", "")

                End If

            Else

                If cn = "Сеть Windows2" Then

                    setik = everIniFile.GetString("Сеть Windows", cn & "|Свойства сетевого адаптера|Сетевой адаптер", "")
                    If setik = "PPP Adapter." Or setik = "PPP Adapter" Or Len(setik) = 0 Then
                        GoTo nextA
                    Else
                        frmComputers.cmbNET2.Text = setik
                    End If

                    frmComputers.cmbNET2.Text = everIniFile.GetString("Сеть Windows",
                                                                      cn & "|Свойства сетевого адаптера|Сетевой адаптер",
                                                                      "")
                    asa$ = everIniFile.GetString("Сеть Windows", cn & "|Адреса сетевого адаптера|Маска IP / Подсети", "")
                    asb$ = everIniFile.GetString("Сеть Windows", cn & "|Свойства сетевого адаптера|Аппаратный адрес", "")
                    If Len(asa$) = 0 Then
                    Else
                        frmComputers.txtNETip2.Text = asa$
                        frmComputers.txtNETmac2.Text = asb$

                        frmComputers.PROizV21.Text = everIniFile.GetString("Сеть Windows",
                                                                           cn & "|Производитель сетевого адаптера|Фирма",
                                                                           "")
                    End If
                Else

                    If Len(frmComputers.cmbNET1.Text) = 0 Then

                        setik = everIniFile.GetString("Сеть Windows", cn & "|Свойства сетевого адаптера|Сетевой адаптер",
                                                      "")
                        If setik = "PPP Adapter." Or setik = "PPP Adapter" Or Len(setik) = 0 Then
                            GoTo nextA
                        Else
                            frmComputers.cmbNET1.Text = setik
                        End If

                        'frmComputers.cmbNET1.Text = everIniFile.GetString("Сеть Windows", cn & "|Свойства сетевого адаптера|Сетевой адаптер", "")
                        asa$ = everIniFile.GetString("Сеть Windows", cn & "|Адреса сетевого адаптера|Маска IP / Подсети",
                                                     "")
                        asb$ = everIniFile.GetString("Сеть Windows", cn & "|Свойства сетевого адаптера|Аппаратный адрес",
                                                     "")
                        If Len(asa$) = 0 Then
                        Else
                            frmComputers.txtNETip1.Text = asa$
                            frmComputers.txtNETmac1.Text = asb$
                            frmComputers.PROizV20.Text = everIniFile.GetString("Сеть Windows",
                                                                               cn &
                                                                               "|Производитель сетевого адаптера|Фирма",
                                                                               "")
                        End If
                    End If
                End If

            End If
nextA:
        Next


        uname = everIniFile.GetString("Суммарная информация", "Сеть|Сетевой адаптер1", "")
        Dim strAnimals As String
        Dim arrAnimals() As String
        strAnimals = uname

        ' arrAnimals = Split(strAnimals, " ", "")

        'For iCounter = LBound(arrAnimals) To UBound(arrAnimals)
        'uname = arrAnimals(0)
        'Next

        If uname = "Bluetooth" Then

        Else
            If Len(frmComputers.cmbNET1.Text) = 0 Then
                frmComputers.cmbNET1.Text = everIniFile.GetString("Суммарная информация", "Сеть|Сетевой адаптер1", "")
            End If
        End If


        If Len(frmComputers.cmbNET1.Text) = 0 Then
            frmComputers.cmbNET1.Text = everIniFile.GetString("Суммарная информация", "Сеть|Сетевой адаптер2", "")
        End If

        If Len(frmComputers.cmbNET2.Text) = 0 Then
            frmComputers.cmbNET2.Text = everIniFile.GetString("Суммарная информация", "Сеть|Сетевой адаптер3", "")
        End If


        If _
            Left(frmComputers.cmbNET1.Text, 4) = "NDIS" Or Left(frmComputers.cmbNET1.Text, 4) = "Nove" Or
            Len(frmComputers.cmbNET1.Text) = 0 Then
            frmComputers.cmbNET1.Text = everIniFile.GetString("Сеть PCI / PNP", "Сеть PCI / PNP1", "")
        End If

        If Len(frmComputers.cmbNET1.Text) = 0 Then
            uname = everIniFile.GetString("Физические устройства", "PnP-устройства|Устройство1", "")

            prov = InStr(uname, "LAN")
            If prov > 1 Then
                frmComputers.cmbNET1.Text = uname
            Else
                uname = " "
                frmComputers.cmbNET1.Text = uname
            End If
        End If

        If Len(frmComputers.txtNETip1.Text) = 0 Then
            asa$ = everIniFile.GetString("Суммарная информация", "Сеть|Первичный адрес IP", "")
            asb$ = everIniFile.GetString("Суммарная информация", "Сеть|Первичный адрес MAC", "")
            If Len(asa$) = 0 Then
            Else

                If Len(frmComputers.cmbNET1.Text) = 0 Or frmComputers.cmbNET1.Text = " " Then

                Else
                    frmComputers.txtNETip1.Text = asa$
                    frmComputers.txtNETmac1.Text = asb$
                End If

            End If
        End If

        '################
        'Монитор
        frmComputers.cmbMon1.Text = everIniFile.GetString("Монитор", "Монитор1|Свойства монитора|Имя монитора", "")
        frmComputers.txtMon1Dum.Text = everIniFile.GetString("Монитор", "Монитор1|Свойства монитора|Тип монитора", "")
        frmComputers.txtMon1SN.Text = everIniFile.GetString("Монитор", "Монитор1|Свойства монитора|Серийный номер", "")
        frmComputers.PROizV28.Text = everIniFile.GetString("Монитор", "Монитор1|Производитель монитора|Фирма", "")


        If Len(frmComputers.cmbMon1.Text) = 0 Then
            frmComputers.PROizV28.Text = everIniFile.GetString("Монитор", "Монитор2|Производитель монитора|Фирма", "")
            frmComputers.cmbMon1.Text = everIniFile.GetString("Монитор", "Монитор2|Свойства монитора|Имя монитора", "")
            frmComputers.txtMon1Dum.Text = everIniFile.GetString("Монитор", "Монитор2|Свойства монитора|Тип монитора",
                                                                 "")
            frmComputers.txtMon1SN.Text = everIniFile.GetString("Монитор", "Монитор2|Свойства монитора|Серийный номер",
                                                                "")
        End If

        If Len(frmComputers.cmbMon1.Text) = 0 Then
            frmComputers.PROizV28.Text = everIniFile.GetString("Монитор", "Монитор3|Производитель монитора|Фирма", "")
            frmComputers.cmbMon1.Text = everIniFile.GetString("Монитор", "Монитор3|Свойства монитора|Имя монитора", "")
            frmComputers.txtMon1Dum.Text = everIniFile.GetString("Монитор", "Монитор3|Свойства монитора|Тип монитора",
                                                                 "")
            frmComputers.txtMon1SN.Text = everIniFile.GetString("Монитор", "Монитор3|Свойства монитора|Серийный номер",
                                                                "")
        End If

        If Len(frmComputers.cmbMon1.Text) = 0 Then
            frmComputers.PROizV28.Text = everIniFile.GetString("Монитор", "Монитор4|Производитель монитора|Фирма", "")
            frmComputers.cmbMon1.Text = everIniFile.GetString("Монитор", "Монитор4|Свойства монитора|Имя монитора", "")
            frmComputers.txtMon1Dum.Text = everIniFile.GetString("Монитор", "Монитор4|Свойства монитора|Тип монитора",
                                                                 "")
            frmComputers.txtMon1SN.Text = everIniFile.GetString("Монитор", "Монитор4|Свойства монитора|Серийный номер",
                                                                "")
        End If

        If Len(frmComputers.cmbMon1.Text) = 0 Then
            frmComputers.PROizV28.Text = everIniFile.GetString("Монитор", "Монитор5|Производитель монитора|Фирма", "")
            frmComputers.cmbMon1.Text = everIniFile.GetString("Монитор", "Монитор5|Свойства монитора|Имя монитора", "")
            frmComputers.txtMon1Dum.Text = everIniFile.GetString("Монитор", "Монитор5|Свойства монитора|Тип монитора",
                                                                 "")
            frmComputers.txtMon1SN.Text = everIniFile.GetString("Монитор", "Монитор5|Свойства монитора|Серийный номер",
                                                                "")
        End If


        If Len(frmComputers.cmbMon1.Text) = 0 Then
            frmComputers.PROizV28.Text = ""
            frmComputers.cmbMon1.Text = everIniFile.GetString("Устройства Windows",
                                                              "Мониторы1|Свойства устройства|Описание драйвера", "")
            frmComputers.txtMon1SN.Text = ""
        End If


        If Len(frmComputers.cmbMon1.Text) = 0 Then
            frmComputers.PROizV28.Text = ""
            frmComputers.cmbMon1.Text = everIniFile.GetString("Устройства Windows",
                                                              "Monitors1|Свойства устройства|Описание драйвера", "")
            frmComputers.txtMon1SN.Text = ""
        End If


        If Len(frmComputers.cmbMon1.Text) = 0 Then
            frmComputers.PROizV28.Text = ""
            frmComputers.cmbMon1.Text = everIniFile.GetString("Устройства Windows",
                                                              "Monitor1|Свойства устройства|Описание драйвера", "")
            frmComputers.txtMon1SN.Text = ""
        End If

        If Len(frmComputers.cmbMon1.Text) = 0 Then
            frmComputers.cmbMon1.Text = everIniFile.GetString("Суммарная информация", "Дисплей|Монитор1", "")
            If Len(frmComputers.PROizV28.Text) = 0 Then
                frmComputers.PROizV28.Text = " "
            End If
        End If

        'Модуль подключения монитора [NoDB] 

        Dim as1 As String
        as1 = frmComputers.cmbMon1.Text


        If as1 = "Модуль подключения монитора [NoDB]" Then

            frmComputers.cmbMon1.Text = ""

            frmComputers.cmbMon1.Text = everIniFile.GetString("Монитор", "Монитор1|Свойства монитора|ID монитора", "")


            If Len(frmComputers.PROizV28.Text) = 0 Then
                frmComputers.PROizV28.Text = " "
            End If
        End If


        '################
        'Дисковод

        frmComputers.cmbFDD.Text = everIniFile.GetString("Суммарная информация", "Хранение данных|Флоппи-накопитель", "")

        If Len(frmComputers.cmbFDD.Text) = 0 Then
            frmComputers.cmbFDD.Text = everIniFile.GetString("Суммарная информация",
                                                             "Хранение данных|Флоппи-накопитель1", "")
        End If

        '################
        'Модем

        frmComputers.cmbModem.Text = everIniFile.GetString("Суммарная информация", "Сеть|Модем", "")

        If Len(frmComputers.cmbModem.Text) = 0 Then
            frmComputers.cmbModem.Text = everIniFile.GetString("Суммарная информация", "Сеть|Модем1", "")
        End If

        '################
        'Клавиатура

        frmComputers.cmbKeyb.Text = everIniFile.GetString("Суммарная информация", "Ввод|Клавиатура", "")
        If frmComputers.cmbKeyb.Text = "" Then
            frmComputers.cmbKeyb.Text = everIniFile.GetString("Суммарная информация", "Ввод|Клавиатура1", "")
        End If

        '################
        'Мышь
        frmComputers.cmbMouse.Text = everIniFile.GetString("Суммарная информация", "Ввод|Мышь", "")
        If frmComputers.cmbMouse.Text = "" Then
            frmComputers.cmbMouse.Text = everIniFile.GetString("Суммарная информация", "Ввод|Мышь1", "")
        End If

        '################
        'Имя компа
        frmComputers.txtSNAME.Text = everIniFile.GetString("Имя компьютера", "Имя NetBIOS|Имя компьютера", "")

        If Len(frmComputers.txtSNAME.Text) = 0 Then _
            frmComputers.txtSNAME.Text = everIniFile.GetString("Суммарная информация", "Компьютер|Имя компьютера",
                                                               "NoName")

        frmComputers.txtPSEUDONIM.Text = frmComputers.txtSNAME.Text

        '################
        'Принтеры

        uname = everIniFile.GetString("Принтеры", "Принтеры1|Свойства принтера|Имя принтера", "")


        If uname = "Fax" Or uname = "Microsoft XPS Document Writer" Or uname = "Отправить в OneNote 2010" Then
            uname = everIniFile.GetString("Суммарная информация", "Периферийные устройства|Принтер1", "")
        End If

        If uname = "Fax" Or uname = "Microsoft XPS Document Writer" Or uname = "Отправить в OneNote 2010" Then

        Else
            frmComputers.cmbPrinters1.Text = uname
            frmComputers.PROizV34.Text = everIniFile.GetString("Принтеры", "Принтеры1|Производитель принтера|Фирма", "")
            frmComputers.txtPrint1Port.Text = everIniFile.GetString("Принтеры",
                                                                    "Принтеры1|Свойства принтера|Порт принтера", "")
        End If


        uname = everIniFile.GetString("Принтеры", "Принтеры2|Свойства принтера|Имя принтера", "")


        If uname = "Fax" Or uname = "Microsoft XPS Document Writer" Or uname = "Отправить в OneNote 2010" Then
            uname = everIniFile.GetString("Суммарная информация", "Периферийные устройства|Принтер2", "")
        End If

        If uname = "Fax" Or uname = "Microsoft XPS Document Writer" Or uname = "Отправить в OneNote 2010" Then

        Else
            frmComputers.cmbPrinters2.Text = uname
            frmComputers.PROizV35.Text = everIniFile.GetString("Принтеры", "Принтеры2|Производитель принтера|Фирма", "")
            frmComputers.txtPrint2Port.Text = everIniFile.GetString("Принтеры",
                                                                    "Принтеры2|Свойства принтера|Порт принтера", "")
        End If

        uname = everIniFile.GetString("Принтеры", "Принтеры1|Свойства принтера|Имя принтера", "")


        If uname = "Fax" Or uname = "Microsoft XPS Document Writer" Or uname = "Отправить в OneNote 2010" Then
            uname = everIniFile.GetString("Суммарная информация", "Периферийные устройства|Принтер3", "")
        End If

        If uname = "Fax" Or uname = "Microsoft XPS Document Writer" Or uname = "Отправить в OneNote 2010" Then

        Else
            frmComputers.cmbPrinters3.Text = uname
            frmComputers.PROizV36.Text = everIniFile.GetString("Принтеры", "Принтеры3|Производитель принтера|Фирма", "")
            frmComputers.txtPrint3Port.Text = everIniFile.GetString("Принтеры",
                                                                    "Принтеры3|Свойства принтера|Порт принтера", "")
        End If

        'Установленное програмное обеспечение
        usersload() 'esq 130713
        textpo()
    End Sub

    'esq 130713 импорт юзеров
    Public Sub usersload()
        Dim everIniFile As New IniFile(EverestFilePatch)
        Dim intcount As Integer
        Dim A, uname1, uname2 As String
        On Error Resume Next
        'A = "Пользователи"
        frmComputers.lstUsers.Items.Clear()
        intcount = 0


        For intj = 1 To 20
            uname1 = ""
            uname2 = ""

            A = "Пользователи" & intj

            uname1 = everIniFile.GetString("Пользователи", A & "|Свойства пользователя|Имя пользователя", "")
            uname2 = everIniFile.GetString("Пользователи", A & "|Свойства пользователя|Полное имя", "")
            If uname1 = Nothing And uname2 = Nothing Then Exit Sub

            Dim sSQL As String
            Dim rsUser As Recordset

            sSQL = "SELECT ID, FIO FROM USER_COMP WHERE ID_COMP=" & frmComputers.sCOUNT & " AND USERNAME='" & uname2 & "'"
            rsUser = New Recordset
            rsUser.Open(sSQL, DB7, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic)
            If rsUser.EOF = True Then
                frmComputers.lstUsers.Items.Add(0)
                'frmComputers.lstUsers.Items(intcount).SubItems.Add(uname1) ' вместо ФИО? 
                frmComputers.lstUsers.Items(intcount).SubItems.Add("")     'пожалуй, нет
                frmComputers.lstUsers.Items(intcount).SubItems.Add(uname2)
            Else
                frmComputers.lstUsers.Items.Add(rsUser.Fields("ID").Value)
                frmComputers.lstUsers.Items(intcount).SubItems.Add(rsUser.Fields("FIO").Value)
                frmComputers.lstUsers.Items(intcount).SubItems.Add(uname2)
            End If
            frmComputers.lstUsers.Items(intcount).SubItems.Add("")
            frmComputers.lstUsers.Items(intcount).SubItems.Add("")
            frmComputers.lstUsers.Items(intcount).SubItems.Add("")
            intcount = intcount + 1
            rsUser.Close()
            rsUser = Nothing
        Next
        Exit Sub
    End Sub
    'esq 130713

    Public Sub textpo()

        Dim uname As String
        Dim A As String
        Dim DC As String
        Dim unameИздатель As String
        Dim unameДата As String
        Dim uname3 As String
        Dim unameВерсия As String

        'esq 130611 *****************************
        Dim FSO As Object
        Dim tINI, oINI As String
        Dim l As Integer

        FSO = CreateObject("Scripting.FileSystemObject")
        l = Len(EverestFilePatch)
        tINI = Left(EverestFilePatch, l - 4) & "-soft.ini"
        If FSO.FileExists(tINI) Then
            EverestFilePatch = tINI
        End If
        'esq 130611 *****************************

        Dim intj, intcount As Integer
        Dim everIniFile As New IniFile(EverestFilePatch)

        'On Error GoTo Err_handler
        On Error Resume Next
        A = "Установленные программы"
        frmComputers.lstSoftware.Items.Clear()
        intcount = 0
        For intj = 1 To 400
            uname = ""
            unameИздатель = ""
            unameДата = ""

            A = "Установленные программы" & intj

            uname = everIniFile.GetString("Установленные программы", A, "")

            unameИздатель = everIniFile.GetString("Установленные программы", uname & "|Publisher", "")
            unameВерсия = everIniFile.GetString("Установленные программы", uname & "|Версия", "")

            If Len(unameИздатель) = 0 Then
                unameИздатель = everIniFile.GetString("Установленные программы", uname & "|Издатель", "")
            End If

            unameДата = everIniFile.GetString("Установленные программы", uname & "|Дата", "")

            If Not RSExists("PROYZV", "PROiZV", unameИздатель) Then
                AddPr(unameИздатель)
            End If

            'esq [***
            If IsDBNull(unameВерсия) = True And InStr(uname, "<") > 0 And InStr(uname, ">") = Len(uname) Then
                unameВерсия = Mid(uname, InStr(uname, "<") + 1, InStr(uname, ">") - InStr(uname, "<") - 1)
                uname = Trim(Left(uname, InStr(uname, "<") - 1))
            End If
            'esq [***

            If unameДата = "<N/A>" Then unameДата = Date.Today
            If Len(uname) = 0 Then unameДата = Date.Today

            If Len(uname) = 0 Then

                If A = "Установленные программы1" Then


                    uname = everIniFile.GetString("Установленные программы", "Установленные программы2", "")


                    frmComputers.lstSoftware.Items.Add(frmComputers.lstSoftware.Items.Count + 1)
                    frmComputers.lstSoftware.Items(intcount).SubItems.Add(frmComputers.lstSoftware.Items.Count)
                    frmComputers.lstSoftware.Items(intcount).SubItems.Add(uname)

                Else

                    GoTo ASE
                End If

            Else
                Dim sKey As String
                stLKEY = ""
                LICENSE_READ(uname)

                frmComputers.lstSoftware.Items.Add(frmComputers.lstSoftware.Items.Count + 1)
                ' frmComputers.lstSoftware.Items(intcount).SubItems.Add(frmComputers.lstSoftware.Items.Count)
                frmComputers.lstSoftware.Items(intcount).SubItems.Add(uname)
                frmComputers.lstSoftware.Items(intcount).SubItems.Add(unameВерсия)
                frmComputers.lstSoftware.Items(intcount).SubItems.Add(stLKEY)
                frmComputers.lstSoftware.Items(intcount).SubItems.Add("")
                frmComputers.lstSoftware.Items(intcount).SubItems.Add(unameДата)
                frmComputers.lstSoftware.Items(intcount).SubItems.Add(Date.Today)
                frmComputers.lstSoftware.Items(intcount).SubItems.Add(unameИздатель)

                intcount = intcount + 1

            End If

        Next

ASE:
        'Лицензионный номер Операционной системы

        Dim OS_OS, SAGAZOD, B As String

        OS_OS$ = everIniFile.GetString("Операционная система", "Свойства операционной системы|Название ОС", "")
        SAGAZOD$ = everIniFile.GetString("Операционная система", "Лицензионная информация|Ключ продукта", "")

        If Len(SAGAZOD) = 0 Then
            LICENSE_READ(OS_OS$)
            SAGAZOD$ = stLKEY
        End If


        OS_OS$ = OS_OS$ & " " &
                 everIniFile.GetString("Операционная система", "Свойства операционной системы|Пакет обновления ОС", "")
        frmComputers.lstSoftware.Items.Add(frmComputers.lstSoftware.Items.Count + 1)
        'frmComputers.lstSoftware.Items(intcount).SubItems.Add(frmComputers.lstSoftware.Items.Count)
        frmComputers.lstSoftware.Items(intcount).SubItems.Add(OS_OS$)
        frmComputers.lstSoftware.Items(intcount).SubItems.Add("")
        frmComputers.lstSoftware.Items(intcount).SubItems.Add(SAGAZOD$)
        frmComputers.lstSoftware.Items(intcount).SubItems.Add("")
        frmComputers.lstSoftware.Items(intcount).SubItems.Add(Date.Today)
        frmComputers.lstSoftware.Items(intcount).SubItems.Add(Date.Today)
        frmComputers.lstSoftware.Items(intcount).SubItems.Add("Microsoft Corporation")
        frmComputers.lstSoftware.Items(intcount).SubItems.Add("Операционная система")

        intcount = intcount + 1

        A = everIniFile.GetString("Антивирус", "Антивирус1", "")
        B = everIniFile.GetString("Антивирус", A & "|Версия программы", "")
        frmComputers.lstSoftware.Items.Add(frmComputers.lstSoftware.Items.Count + 1)
        frmComputers.lstSoftware.Items(intcount).SubItems.Add(frmComputers.lstSoftware.Items.Count)
        frmComputers.lstSoftware.Items(intcount).SubItems.Add(A & " " & B)
        frmComputers.lstSoftware.Items(intcount).SubItems.Add("")

        frmComputers.lstSoftware.Items(intcount).SubItems.Add("")


        frmComputers.lstSoftware.Items(intcount).SubItems.Add(Date.Today)
        frmComputers.lstSoftware.Items(intcount).SubItems.Add(Date.Today)
        frmComputers.lstSoftware.Items(intcount).SubItems.Add("")
        frmComputers.lstSoftware.Items(intcount).SubItems.Add("Антивирус")

        intcount = intcount + 1

        'esq ***** Лицензионный номер МСОфиса 
        Dim L_name, L_key As String
        Dim lstcount, n As Integer
        If InStr(EverestFilePatch, "-soft.ini") Then
            l = Len(EverestFilePatch)
            n = InStr(EverestFilePatch, "-soft.ini")
            oINI = Left(EverestFilePatch, n - 1) & ".ini"
        End If
        If FSO.FileExists(oINI) Then
            Dim oIniFile As New IniFile(oINI)
            For intj = 1 To 40
                L_name = ""
                L_key = ""
                A = "Лицензии" & intj
                L_name = oIniFile.GetString("Лицензии", A, "")
                If Len(L_name) > 0 Then
                    L_key = oIniFile.GetString("Лицензии", L_name & "|Ключ продукта", "")

                    If InStr(L_name, "office", Microsoft.VisualBasic.CompareMethod.Text) > 0 Then
                        For lstcount = 1 To frmComputers.lstSoftware.Items.Count - 1
                            If InStr(frmComputers.lstSoftware.Items(lstcount).SubItems.Item(1).Text, L_name) > 0 Then
                                frmComputers.lstSoftware.Items(lstcount).SubItems.Item(3).Text = L_key
                            End If
                        Next
                    End If
                End If
            Next
        End If
        'esq  *****************************


        Exit Sub
Err_handler:
        MsgBox(Err.Description)
    End Sub


    Public Sub EVEREST_UPDATE()
        Dim uname As String

        On Error GoTo Err_handler

        On Error Resume Next

        '################
        'Процессор
        Dim everIniFile As New IniFile(EverestFilePatch)


        If frmComputers.MASSLOAD = True Then

        Else

            If _
                MsgBox("Проверять правильность имени компьютера?", vbExclamation + vbYesNo, "Обновление информации") =
                vbNo Then

            Else
                If _
                    frmComputers.txtSNAME.Text <>
                    everIniFile.GetString("Суммарная информация", "Компьютер|Имя компьютера", "") Then

                    If _
                        frmComputers.txtSNAME.Text <>
                        everIniFile.GetString("Имя компьютера", "Имя NetBIOS|Имя компьютера", "") Then

                        MsgBox("Имя компьютера не соответствует выбранному файлу." & vbCrLf & "Выберите другой файл.",
                               MsgBoxStyle.Critical, ProGramName)
                        Exit Sub

                    End If

                End If
            End If
        End If

        'uname = everIniFile.GetString("Суммарная информация", "Компьютер|Имя пользователя", "")

        ''frmComputers.otv.Text = everIniFile.GetString("Суммарная информация", "Компьютер|Имя пользователя","")

        'If frmComputers.cmbResponsible.Text = uname Then
        'Else
        'SaveUpdateLogDB(frmComputers.cmbResponsible.Text, uname)
        'frmComputers.cmbResponsible.Text = uname
        'frmComputers.cmbResponsible.BackColor = Color.Green
        'End If

        uname = ""

        uname = everIniFile.GetString("DMI", "Процессоры1|Свойства процессора|Версия", "")

        If frmComputers.cmbCPU1.Text = uname Then
        Else
            SaveUpdateLogDB(frmComputers.cmbCPU1.Text, uname)
            frmComputers.cmbCPU1.Text = uname
            frmComputers.cmbCPU1.BackColor = Color.Green

        End If

        uname = everIniFile.GetString("DMI", "Процессоры1|Свойства процессора|Текущая частота", "")
        If frmComputers.txtMHZ1.Text = uname Then
        Else
            SaveUpdateLogDB(frmComputers.txtMHZ1.Text, uname)

            frmComputers.txtMHZ1.Text = uname
            frmComputers.txtMHZ1.BackColor = Color.Green
        End If

        uname = everIniFile.GetString("DMI", "Процессоры1|Свойства процессора|Тип разъёма", "")
        If frmComputers.txtSoc1.Text = uname Then
        Else
            SaveUpdateLogDB(frmComputers.txtSoc1.Text, uname)

            frmComputers.txtSoc1.Text = uname
            frmComputers.txtSoc1.BackColor = Color.Green
        End If

        uname = everIniFile.GetString("DMI", "Процессоры1|Свойства процессора|Производитель", "")
        If frmComputers.PROizV1.Text = uname Then
        Else
            SaveUpdateLogDB(frmComputers.PROizV1.Text, uname)

            frmComputers.PROizV1.Text = uname
            frmComputers.PROizV1.BackColor = Color.Green
        End If

        uname = everIniFile.GetString("DMI", "Процессоры2|Свойства процессора|Версия", "")
        If frmComputers.cmbCPU2.Text = uname Then
        Else
            SaveUpdateLogDB(frmComputers.cmbCPU2.Text, uname)

            frmComputers.cmbCPU2.Text = uname
            frmComputers.cmbCPU2.BackColor = Color.Green
        End If

        uname = everIniFile.GetString("DMI", "Процессоры2|Свойства процессора|Текущая частота", "")
        If frmComputers.txtMHZ2.Text = uname Then
        Else
            SaveUpdateLogDB(frmComputers.txtMHZ2.Text, uname)

            frmComputers.txtMHZ2.Text = uname
            frmComputers.txtMHZ2.BackColor = Color.Green
        End If

        uname = everIniFile.GetString("DMI", "Процессоры2|Свойства процессора|Тип разъёма", "")
        If frmComputers.txtSoc2.Text = uname Then
        Else
            SaveUpdateLogDB(frmComputers.txtSoc2.Text, uname)

            frmComputers.txtSoc2.Text = uname
            frmComputers.txtSoc2.BackColor = Color.Green
        End If

        uname = everIniFile.GetString("DMI", "Процессоры2|Свойства процессора|Производитель", "")
        If frmComputers.PROizV2.Text = uname Then
        Else
            SaveUpdateLogDB(frmComputers.PROizV2.Text, uname)
            frmComputers.PROizV2.Text = uname
            frmComputers.PROizV2.BackColor = Color.Green
        End If


        If Len(frmComputers.cmbCPU1.Text) = 0 Then

            uname = everIniFile.GetString("Суммарная информация", "Системная плата|Тип ЦП", "")

            If frmComputers.cmbCPU1.Text = uname Then
            Else
                SaveUpdateLogDB(frmComputers.cmbCPU1.Text, uname)
                frmComputers.cmbCPU1.Text = uname
                frmComputers.cmbCPU1.BackColor = Color.Green
            End If

        End If

        '################
        'Материнка
        'uname = everIniFile.GetString("Суммарная информация", "Системная плата|Системная плата","")
        uname = everIniFile.GetString("Системная плата", "Свойства системной платы|Системная плата", "")

        If uname = "Unknown" Or uname = "Неизвестно" Or uname = "" Or Len(uname) = 0 Then
            uname = everIniFile.GetString("Системная плата", "Свойства системной платы|Системная плата", "")
        Else
        End If

        If uname = "Unknown" Or uname = "Неизвестно" Or uname = "" Or Len(uname) = 0 Then
            'uname = everIniFile.GetString("Суммарная информация", "Системная плата|Системная плата","")
            uname = everIniFile.GetString("Суммарная информация", "DMI|DMI системная плата", "")
        Else
        End If

        If frmComputers.cmbMB.Text = uname Then

        Else
            SaveUpdateLogDB(frmComputers.cmbMB.Text, uname)
            frmComputers.cmbMB.Text = uname
            frmComputers.cmbMB.BackColor = Color.Green
            frmComputers.txtChip.Text = everIniFile.GetString("Чипсет",
                                                              "Свойства набора микросхем (чипсета)|Чипсет системной платы",
                                                              "")
            frmComputers.txtChip.BackColor = Color.Green
            frmComputers.txtSN_MB.Text = everIniFile.GetString("Системная плата",
                                                               "Свойства системной платы|ID системной платы", "")
            frmComputers.txtSN_MB.BackColor = Color.Green
            frmComputers.PROizV5.Text = everIniFile.GetString("Системная плата", "Производитель системной платы|Фирма",
                                                              "")
            frmComputers.PROizV5.BackColor = Color.Green
        End If

        '@@@@@@@@@@@@@@@@@@@@

        If Len(frmComputers.cmbMB.Text) = 0 Then
            frmComputers.cmbMB.Text = everIniFile.GetString("Суммарная информация", "Системная плата|Системная плата",
                                                            "")
        Else
        End If

        If frmComputers.cmbMB.Text = "Unknown" Or frmComputers.cmbMB.Text = "Неизвестно" Then
            frmComputers.cmbMB.Text = everIniFile.GetString("Суммарная информация", "DMI|DMI системная плата", "")
        Else
        End If


        '@@@@@@@@@@@@@@@@@@@@@

        '################
        'Память

        uname = everIniFile.GetString("SPD", "SPD1|Свойства модуля памяти|Размер модуля", "")
        If frmComputers.cmbRAM1.Text = uname Then
        Else
            SaveUpdateLogDB(frmComputers.cmbRAM1.Text, uname)
            frmComputers.cmbRAM1.Text = uname
            frmComputers.cmbRAM1.BackColor = Color.Green
            frmComputers.PROizV6.Text = everIniFile.GetString("SPD", "SPD1|Производитель модуля памяти|Фирма", "")
            frmComputers.txtRamSN1.Text = everIniFile.GetString("SPD", "SPD1|Свойства модуля памяти|Серийный номер", "")
            frmComputers.txtRamS1.Text = everIniFile.GetString("SPD", "SPD1|Свойства модуля памяти|Скорость памяти", "")

        End If


        uname = everIniFile.GetString("SPD", "SPD2|Свойства модуля памяти|Размер модуля", "")
        If frmComputers.cmbRAM2.Text = uname Then
        Else
            SaveUpdateLogDB(frmComputers.cmbRAM2.Text, uname)
            frmComputers.cmbRAM2.Text = uname
            frmComputers.cmbRAM2.BackColor = Color.Green
            frmComputers.PROizV7.Text = everIniFile.GetString("SPD", "SPD2|Производитель модуля памяти|Фирма", "")
            frmComputers.txtRamSN2.Text = everIniFile.GetString("SPD", "SPD2|Свойства модуля памяти|Серийный номер", "")
            frmComputers.txtRamS2.Text = everIniFile.GetString("SPD", "SPD2|Свойства модуля памяти|Скорость памяти", "")

        End If


        uname = everIniFile.GetString("SPD", "SPD3|Свойства модуля памяти|Размер модуля", "")
        If frmComputers.cmbRAM3.Text = uname Then
        Else
            SaveUpdateLogDB(frmComputers.cmbRAM3.Text, uname)
            frmComputers.cmbRAM3.Text = uname
            frmComputers.cmbRAM3.BackColor = Color.Green
            frmComputers.PROizV8.Text = everIniFile.GetString("SPD", "SPD3|Производитель модуля памяти|Фирма", "")
            frmComputers.txtRamSN3.Text = everIniFile.GetString("SPD", "SPD3|Свойства модуля памяти|Серийный номер", "")
            frmComputers.txtRamS3.Text = everIniFile.GetString("SPD", "SPD3|Свойства модуля памяти|Скорость памяти", "")

        End If


        uname = everIniFile.GetString("SPD", "SPD4|Свойства модуля памяти|Размер модуля", "")
        If frmComputers.cmbRAM4.Text = uname Then
        Else
            SaveUpdateLogDB(frmComputers.cmbRAM4.Text, uname)
            frmComputers.cmbRAM4.Text = uname
            frmComputers.cmbRAM4.BackColor = Color.Green
            frmComputers.PROizV9.Text = everIniFile.GetString("SPD", "SPD4|Производитель модуля памяти|Фирма", "")
            frmComputers.txtRamSN4.Text = everIniFile.GetString("SPD", "SPD4|Свойства модуля памяти|Серийный номер", "")
            frmComputers.txtRamS4.Text = everIniFile.GetString("SPD", "SPD4|Свойства модуля памяти|Скорость памяти", "")

        End If

        If Len(frmComputers.cmbRAM1.Text) = 0 Then
            uname = everIniFile.GetString("DMI", "Устройства памяти1|Свойства устройства памяти|Размер", "")
            If frmComputers.cmbRAM1.Text = uname Then
                frmComputers.cmbRAM1.BackColor = Color.White
            Else
                SaveUpdateLogDB(frmComputers.cmbRAM1.Text, uname)
                frmComputers.cmbRAM1.Text = uname
                frmComputers.txtRamS1.Text = everIniFile.GetString("DMI",
                                                                   "Устройства памяти1|Свойства устройства памяти|Скорость",
                                                                   "")
                frmComputers.txtRamSN1.Text = everIniFile.GetString("DMI",
                                                                    "Устройства памяти1|Свойства устройства памяти|Серийный номер",
                                                                    "")
                frmComputers.PROizV6.Text = everIniFile.GetString("DMI",
                                                                  "Устройства памяти1|Свойства устройства памяти|Производитель",
                                                                  "")
                'frmComputers.cmbRAM1.BackColor = Color.Green
                frmComputers.cmbRAM1.BackColor = Color.White
            End If
        End If

        If Len(frmComputers.cmbRAM2.Text) = 0 Then
            uname = everIniFile.GetString("DMI", "Устройства памяти2|Свойства устройства памяти|Размер", "")
            If frmComputers.cmbRAM2.Text = uname Then
                frmComputers.cmbRAM2.BackColor = Color.White
            Else
                SaveUpdateLogDB(frmComputers.cmbRAM2.Text, uname)
                frmComputers.cmbRAM2.Text = uname
                frmComputers.txtRamS2.Text = everIniFile.GetString("DMI",
                                                                   "Устройства памяти2|Свойства устройства памяти|Скорость",
                                                                   "")
                frmComputers.txtRamSN2.Text = everIniFile.GetString("DMI",
                                                                    "Устройства памяти2|Свойства устройства памяти|Серийный номер",
                                                                    "")
                frmComputers.PROizV7.Text = everIniFile.GetString("DMI",
                                                                  "Устройства памяти2|Свойства устройства памяти|Производитель",
                                                                  "")
                frmComputers.cmbRAM2.BackColor = Color.White
            End If
        End If

        If Len(frmComputers.cmbRAM3.Text) = 0 Then
            uname = everIniFile.GetString("DMI", "Устройства памяти3|Свойства устройства памяти|Размер", "")
            If frmComputers.cmbRAM3.Text = uname Then
                frmComputers.cmbRAM3.BackColor = Color.White
            Else
                SaveUpdateLogDB(frmComputers.cmbRAM3.Text, uname)
                frmComputers.cmbRAM3.Text = uname
                frmComputers.txtRamS3.Text = everIniFile.GetString("DMI",
                                                                   "Устройства памяти3|Свойства устройства памяти|Скорость",
                                                                   "")
                frmComputers.txtRamSN3.Text = everIniFile.GetString("DMI",
                                                                    "Устройства памяти3|Свойства устройства памяти|Серийный номер",
                                                                    "")
                frmComputers.PROizV8.Text = everIniFile.GetString("DMI",
                                                                  "Устройства памяти3|Свойства устройства памяти|Производитель",
                                                                  "")
                frmComputers.cmbRAM3.BackColor = Color.White
            End If
        End If

        If Len(frmComputers.cmbRAM4.Text) = 0 Then
            uname = everIniFile.GetString("DMI", "Устройства памяти4|Свойства устройства памяти|Размер", "")
            If frmComputers.cmbRAM4.Text = uname Then
                frmComputers.cmbRAM4.BackColor = Color.White
            Else
                SaveUpdateLogDB(frmComputers.cmbRAM4.Text, uname)
                frmComputers.cmbRAM4.Text = uname
                frmComputers.txtRamS4.Text = everIniFile.GetString("DMI",
                                                                   "Устройства памяти4|Свойства устройства памяти|Скорость",
                                                                   "")
                frmComputers.txtRamSN4.Text = everIniFile.GetString("DMI",
                                                                    "Устройства памяти4|Свойства устройства памяти|Серийный номер",
                                                                    "")
                frmComputers.PROizV9.Text = everIniFile.GetString("DMI",
                                                                  "Устройства памяти4|Свойства устройства памяти|Производитель",
                                                                  "")
                frmComputers.cmbRAM4.BackColor = Color.White
            End If
        End If


        If Len(frmComputers.cmbRAM1.Text) = 0 Then
            uname = everIniFile.GetString("Суммарная информация", "Системная плата|Системная память", "")
            If frmComputers.cmbRAM1.Text = uname Then
                frmComputers.cmbRAM1.BackColor = Color.White
            Else
                SaveUpdateLogDB(frmComputers.cmbRAM1.Text, uname)
                frmComputers.cmbRAM1.Text = uname
                'frmComputers.cmbRAM1.BackColor = Color.Green
                frmComputers.cmbRAM1.BackColor = Color.White
            End If
        End If


        '################
        'Жесткий диск
        '1
        uname = everIniFile.GetString("ATA", "ATA1|Свойства устройства ATA|ID модели", "")
        If frmComputers.cmbHDD1.Text = uname Then
        Else
            SaveUpdateLogDB(frmComputers.cmbHDD1.Text, uname)
            frmComputers.cmbHDD1.Text = uname
            frmComputers.cmbHDD1.BackColor = Color.Green
            frmComputers.txtHDDo1.Text = everIniFile.GetString("ATA",
                                                               "ATA1|Физические данные устройства ATA|Форматированная ёмкость",
                                                               "")
            frmComputers.txtHDDsN1.Text = everIniFile.GetString("ATA", "ATA1|Свойства устройства ATA|Серийный номер", "")
            frmComputers.PROizV10.Text = everIniFile.GetString("ATA", "ATA1|Производитель ATA-устройства|Фирма", "")

        End If

        '2
        uname = everIniFile.GetString("ATA", "ATA2|Свойства устройства ATA|ID модели", "")
        If frmComputers.cmbHDD2.Text = uname Then
        Else
            SaveUpdateLogDB(frmComputers.cmbHDD2.Text, uname)

            frmComputers.cmbHDD2.Text = uname
            frmComputers.cmbHDD2.BackColor = Color.Green
            frmComputers.txtHDDo2.Text = everIniFile.GetString("ATA",
                                                               "ATA2|Физические данные устройства ATA|Форматированная ёмкость",
                                                               "")
            frmComputers.txtHDDsN2.Text = everIniFile.GetString("ATA", "ATA2|Свойства устройства ATA|Серийный номер", "")
            frmComputers.PROizV11.Text = everIniFile.GetString("ATA", "ATA2|Производитель ATA-устройства|Фирма", "")
        End If

        '3
        uname = everIniFile.GetString("ATA", "ATA3|Свойства устройства ATA|ID модели", "")
        If frmComputers.cmbHDD3.Text = uname Then
        Else
            SaveUpdateLogDB(frmComputers.cmbHDD3.Text, uname)
            frmComputers.cmbHDD3.Text = uname
            frmComputers.cmbHDD3.BackColor = Color.Green
            frmComputers.txtHDDo3.Text = everIniFile.GetString("ATA",
                                                               "ATA3|Физические данные устройства ATA|Форматированная ёмкость",
                                                               "")
            frmComputers.txtHDDsN3.Text = everIniFile.GetString("ATA", "ATA3|Свойства устройства ATA|Серийный номер", "")
            frmComputers.PROizV12.Text = everIniFile.GetString("ATA", "ATA3|Производитель ATA-устройства|Фирма", "")
        End If

        '4
        uname = everIniFile.GetString("ATA", "ATA4|Свойства устройства ATA|ID модели", "")
        If frmComputers.cmbHDD4.Text = uname Then
        Else
            SaveUpdateLogDB(frmComputers.cmbHDD4.Text, uname)
            frmComputers.cmbHDD4.Text = uname
            frmComputers.cmbHDD4.BackColor = Color.Green
            frmComputers.txtHDDo4.Text = everIniFile.GetString("ATA",
                                                               "ATA4|Физические данные устройства ATA|Форматированная ёмкость",
                                                               "")
            frmComputers.txtHDDsN4.Text = everIniFile.GetString("ATA", "ATA4|Свойства устройства ATA|Серийный номер", "")
            frmComputers.PROizV13.Text = everIniFile.GetString("ATA", "ATA4|Производитель ATA-устройства|Фирма", "")
        End If


        If Len(frmComputers.cmbHDD1.Text) = 0 Then
            uname = everIniFile.GetString("Хранение данных Windows",
                                          "Хранение данных Windows1|Физические данные дискового накопителя|Название жёсткого диска",
                                          "")
            If frmComputers.cmbHDD1.Text = uname Then
            Else
                SaveUpdateLogDB(frmComputers.cmbHDD1.Text, uname)

                frmComputers.cmbHDD1.Text = uname
                frmComputers.cmbHDD1.BackColor = Color.Green
                frmComputers.txtHDDo1.Text = everIniFile.GetString("Хранение данных Windows",
                                                                   "Хранение данных Windows1|Физические данные дискового накопителя|Форматированная ёмкость",
                                                                   "")
                frmComputers.PROizV10.Text = everIniFile.GetString("Хранение данных Windows",
                                                                   "Хранение данных Windows1|Производитель устройства|Фирма",
                                                                   "")
            End If
        End If


        '------------------
        If Len(frmComputers.cmbHDD1.Text) = 0 Then

            uname = everIniFile.GetString("EIDE", "EIDE1|Физические данные устройства EIDE|Название жёсткого диска", "")
            If frmComputers.cmbHDD1.Text = uname Then
            Else
                SaveUpdateLogDB(frmComputers.cmbHDD1.Text, uname)

                frmComputers.cmbHDD1.Text = uname
                frmComputers.cmbHDD1.BackColor = Color.Green
                frmComputers.txtHDDo1.Text = everIniFile.GetString("EIDE",
                                                                   "EIDE1|Физические данные устройства EIDE|Форматированная ёмкость",
                                                                   "")
                frmComputers.PROizV10.Text = everIniFile.GetString("EIDE", "EIDE1|Производитель EIDE-устройства|Фирма",
                                                                   "")
            End If
        End If


        If Len(frmComputers.PROizV10.Text) = 0 Then
            frmComputers.PROizV10.Text = everIniFile.GetString("Хранение данных Windows",
                                                               "Хранение данных Windows1|Производитель устройства|Фирма",
                                                               "")
        End If

        'Код прислал Славик (aka vindpi)
        If Len(frmComputers.cmbHDD1.Text) = 0 Then
            If Len(frmComputers.PROizV10.Text) = 0 Then
                frmComputers.PROizV10.Text = " "
            End If


            frmComputers.cmbHDD1.Text = everIniFile.GetString("Суммарная информация",
                                                              "Хранение данных|Дисковый накопитель1", "")

            Dim nom_pos1, nom_pos2, ob_lenght, ob1, ob_rez As String
            Dim ob_Gb, ob2, ob3, ASqw As String

            uname = everIniFile.GetString("Суммарная информация", "Разделы|Раздел1", "")

            nom_pos1 = InStr(uname, ")") + 2
            nom_pos2 = InStr(nom_pos1, uname) + 1
            ob_lenght = nom_pos2 - nom_pos1
            ob1 = Mid(uname, nom_pos1, ob_lenght)
            ob_rez = CInt(ob1)

            uname = everIniFile.GetString("Суммарная информация", "Разделы|Раздел2", "")

            If Len(uname) > 2 Then
                nom_pos1 = InStr(uname, ")") + 2
                nom_pos2 = InStr(nom_pos1, uname) + 1
                ob_lenght = nom_pos2 - nom_pos1
                ob2 = Mid(uname, nom_pos1, ob_lenght)
                ob_rez = ob_rez + CInt(ob2)
            End If

            uname = everIniFile.GetString("Суммарная информация", "Разделы|Раздел3", "")

            If Len(uname) > 2 Then
                nom_pos1 = InStr(uname, ")") + 2
                nom_pos2 = InStr(nom_pos1, uname, " ", "") + 1
                ob_lenght = nom_pos2 - nom_pos1
                ob3 = Mid(uname, nom_pos1, ob_lenght)
                ob_rez = ob_rez + CInt(ob3)
            End If

            If Len(ob_rez) = 0 Then
                ob_rez = ob1 + ob2 + ob3
            Else
            End If
            ob_Gb = CStr(ob_rez / 1000) & " Гб"
            frmComputers.txtHDDo1.Text = ob_Gb
        End If


        '################
        'SVGA

        uname = everIniFile.GetString("Видео Windows", "Видео Windows1|Свойства видеоадаптера|Описание устройства", "")
        If frmComputers.cmbSVGA1.Text = uname Then
        Else
            SaveUpdateLogDB(frmComputers.cmbSVGA1.Text, uname)

            frmComputers.cmbSVGA1.Text = uname
            frmComputers.cmbSVGA1.BackColor = Color.Green
            frmComputers.txtSVGAr1.Text = everIniFile.GetString("Видео Windows",
                                                                "Видео Windows1|Свойства видеоадаптера|Объем видеоОЗУ",
                                                                "")
            'frmComputers.txtSVGAr1.Text = everIniFile.GetString("Видео Windows", "Номер видео карты","")
            frmComputers.PROizV14.Text = everIniFile.GetString("Видео Windows",
                                                               "Видео Windows1|Производитель видеоадаптера|Фирма", "")
        End If

        If Len(frmComputers.cmbSVGA1.Text) = 0 Then
            uname = everIniFile.GetString("Суммарная информация", "Дисплей|Видеоадаптер1", "")
            If frmComputers.cmbSVGA1.Text = uname Then
            Else
                SaveUpdateLogDB(frmComputers.cmbSVGA1.Text, uname)

                frmComputers.cmbSVGA1.Text = uname
            End If
        End If

        If Len(frmComputers.cmbSVGA1.Text) = 0 Then
            uname = everIniFile.GetString("Графический процессор", "Свойства графического процессора|Видеоадаптер", "")
            If frmComputers.cmbSVGA1.Text = uname Then
            Else
                SaveUpdateLogDB(frmComputers.cmbSVGA1.Text, uname)

                frmComputers.cmbSVGA1.Text = uname
            End If
        End If

        If Len(frmComputers.PROizV14.Text) = 0 Then
            uname = everIniFile.GetString("Графический процессор", "Производитель графического процессора|Фирма", "")
            If frmComputers.PROizV14.Text = uname Then
            Else
                frmComputers.PROizV14.Text = uname
            End If
        End If

        If Len(frmComputers.txtSVGAr1.Text) = 0 Then
            frmComputers.txtSVGAr1.Text = everIniFile.GetString("Графический процессор",
                                                                "Свойства графического процессора|Объем видеоОЗУ", "")


        End If


        If Len(frmComputers.txtSVGAr1.Text) = 0 Then
            frmComputers.PROizV14.Text = " "
            frmComputers.cmbSVGA1.Text = everIniFile.GetString("Устройства Windows",
                                                               "Видеоадаптеры1|Свойства устройства|Описание драйвера",
                                                               "")
            frmComputers.txtSVGAr1.Text = ""
        End If


        '################
        'Звуковая карта
        uname = everIniFile.GetString("Аудио PCI / PnP", "Аудио PCI / PnP1", "0")
        uname = Replace(uname, "'", " ", "")

        If frmComputers.cmbSound.Text <> uname And uname <> "0" Then

            SaveUpdateLogDB(frmComputers.cmbSound.Text, uname)

            frmComputers.cmbSound.Text = uname
            frmComputers.cmbSound.BackColor = Color.Green

        Else

        End If

        If Len(uname) = 0 Or Len(frmComputers.cmbSound.Text) = 0 Then
            uname = everIniFile.GetString("Суммарная информация", "Мультимедиа|Звуковой адаптер1", "")
            uname = Replace(uname, "'", " ", "")

            If frmComputers.cmbSound.Text = uname Then

            Else
                SaveUpdateLogDB(frmComputers.cmbSound.Text, uname)

                frmComputers.cmbSound.Text = uname
                frmComputers.cmbSound.BackColor = Color.Green
            End If

        End If

        If Len(frmComputers.cmbSound.Text) = 0 Then
            uname = everIniFile.GetString("Аудио PCI / PnP", "Аудио PCI / PnP", "")
            uname = Replace(uname, "'", " ", "")
            If frmComputers.cmbSound.Text = uname Then
            Else
                SaveUpdateLogDB(frmComputers.cmbSound.Text, uname)

                frmComputers.cmbSound.Text = uname
                frmComputers.cmbSound.BackColor = Color.Green
            End If
        End If


        '################
        'CD-ROM
        Dim A As String
        Dim B As String
        Dim c As String
        Dim intj As Integer


        'Everest CD Drive
        'If Len(frmComputers.cmbOPTIC1.Text) = 0 And Len(frmComputers.cmbOPTIC1.Text) = 0 And Len(frmComputers.cmbOPTIC3.Text) = 0 Then

        For intj = 1 To 3
            c = "Оптические накопители"
            c = c & intj

            A = everIniFile.GetString("Оптические накопители", c, "")
            B = everIniFile.GetString("Оптические накопители", c & "|Свойства оптического накопителя|Тип устройства", "")


            uname = everIniFile.GetString("Оптические накопители",
                                          "Оптические накопители2" &
                                          "|Свойства оптического накопителя|Описание устройства", "")

            If uname <> "Generic STEALTH DVD SCSI CdRom Device" Then
                If uname <> "NERO IMAGEDRIVE2 SCSI CdRom Device" Then
                    If uname <> "Generic DVD-ROM SCSI CdRom Device" Then
                        If uname <> "RW8314B IMV135U SCSI CdRom Device" Then

                            If frmComputers.cmbOPTIC2.Text <> uname Then
                                frmComputers.cmbOPTIC2.Text = uname
                                frmComputers.cmbOPTIC2.BackColor = Color.Green
                                frmComputers.PROizV18.Text = everIniFile.GetString("Оптические накопители",
                                                                                   "Оптические накопители2" &
                                                                                   "|Производитель устройства|Фирма", "")
                                frmComputers.txtOPTICs2.Text = everIniFile.GetString("Оптические накопители",
                                                                                     "Оптические накопители2" &
                                                                                     "|Свойства оптического накопителя|Скорость",
                                                                                     "")
                            End If
                        End If
                    End If
                End If
            End If

            uname = everIniFile.GetString("Оптические накопители",
                                          "Оптические накопители1" &
                                          "|Свойства оптического накопителя|Описание устройства", "")
            If uname <> "Generic STEALTH DVD SCSI CdRom Device" Then
                If uname <> "NERO IMAGEDRIVE2 SCSI CdRom Device" Then
                    If uname <> "Generic DVD-ROM SCSI CdRom Device" Then
                        If uname <> "RW8314B IMV135U SCSI CdRom Device" Then
                            If frmComputers.cmbOPTIC1.Text <> uname Then
                                frmComputers.cmbOPTIC1.Text = uname
                                frmComputers.cmbOPTIC1.BackColor = Color.Green
                                frmComputers.PROizV17.Text = everIniFile.GetString("Оптические накопители",
                                                                                   "Оптические накопители1" &
                                                                                   "|Производитель устройства|Фирма", "")
                                frmComputers.txtOPTICs1.Text = everIniFile.GetString("Оптические накопители",
                                                                                     "Оптические накопители1" &
                                                                                     "|Свойства оптического накопителя|Скорость",
                                                                                     "")
                            End If
                        End If
                    End If
                End If
            End If
            If _
                Len(frmComputers.cmbOPTIC1.Text) = 0 And Len(frmComputers.cmbOPTIC1.Text) = 0 And
                Len(frmComputers.cmbOPTIC3.Text) = 0 Then
                A = everIniFile.GetString("Суммарная информация", "Хранение данных|Оптический накопитель1", "")
                frmComputers.cmbOPTIC1.Text = A
            End If


            uname = everIniFile.GetString("Оптические накопители",
                                          "Оптические накопители3" &
                                          "|Свойства оптического накопителя|Описание устройства", "")
            If uname <> "Generic STEALTH DVD SCSI CdRom Device" Then
                If uname <> "NERO IMAGEDRIVE2 SCSI CdRom Device" Then
                    If uname <> "Generic DVD-ROM SCSI CdRom Device" Then
                        If uname <> "RW8314B IMV135U SCSI CdRom Device" Then

                            If frmComputers.cmbOPTIC3.Text <> uname Then
                                frmComputers.cmbOPTIC3.Text = uname
                                frmComputers.cmbOPTIC1.BackColor = Color.Green
                                frmComputers.PROizV19.Text = everIniFile.GetString("Оптические накопители",
                                                                                   "Оптические накопители3" &
                                                                                   "|Производитель устройства|Фирма", "")
                                frmComputers.txtOPTICs3.Text = everIniFile.GetString("Оптические накопители",
                                                                                     "Оптические накопители3" &
                                                                                     "|Свойства оптического накопителя|Скорость",
                                                                                     "")
                            End If
                        End If
                    End If
                End If
            End If
        Next
        'End If


        'hhhh

        '################
        'Сетевая карта
        'Код изменен Славиком (aka vindpi) - доработан Алексеем Плотниковым
        Dim cn As String
        Dim sNETset, asa, asb, prov As String
        For intj = 1 To 3
            cn = "Сеть Windows"
            cn = cn & intj

            If cn = "Сеть Windows1" Then


                sNETset = everIniFile.GetString("Сеть Windows", cn & "|Свойства сетевого адаптера|Сетевой адаптер", "")
                If sNETset = "PPP Adapter." Or sNETset = "PPP Adapter" Then

                    GoTo nextA
                Else
                    frmComputers.cmbNET1.Text = sNETset
                End If


                asa$ = everIniFile.GetString("Сеть Windows", cn & "|Адреса сетевого адаптера|Маска IP / Подсети", "")
                asb$ = everIniFile.GetString("Сеть Windows", cn & "|Свойства сетевого адаптера|Аппаратный адрес", "")
                frmComputers.txtNETip1.Text = asa$
                frmComputers.txtNETmac1.Text = asb$

                'frmComputers.txtNETip1.Text = everIniFile.GetString("Сеть Windows", cn & "|Адреса сетевого адаптера|Маска IP / Подсети","")

                frmComputers.PROizV20.Text = everIniFile.GetString("Сеть Windows",
                                                                   cn & "|Производитель сетевого адаптера|Фирма", "")

            Else

                If cn = "Сеть Windows2" Then

                    sNETset = everIniFile.GetString("Сеть Windows", cn & "|Свойства сетевого адаптера|Сетевой адаптер",
                                                    "")
                    If sNETset = "PPP Adapter." Or sNETset = "PPP Adapter" Then
                        GoTo nextA
                    Else
                        frmComputers.cmbNET2.Text = sNETset
                    End If

                    frmComputers.cmbNET2.Text = everIniFile.GetString("Сеть Windows",
                                                                      cn & "|Свойства сетевого адаптера|Сетевой адаптер",
                                                                      "")
                    asa$ = everIniFile.GetString("Сеть Windows", cn & "|Адреса сетевого адаптера|Маска IP / Подсети", "")
                    asb$ = everIniFile.GetString("Сеть Windows", cn & "|Свойства сетевого адаптера|Аппаратный адрес", "")
                    frmComputers.txtNETip2.Text = asa$
                    frmComputers.txtNETmac1.Text = asb$

                    frmComputers.PROizV21.Text = everIniFile.GetString("Сеть Windows",
                                                                       cn & "|Производитель сетевого адаптера|Фирма", "")

                Else

                    If Len(frmComputers.cmbNET1.Text) = 0 Then

                        sNETset = everIniFile.GetString("Сеть Windows",
                                                        cn & "|Свойства сетевого адаптера|Сетевой адаптер", "")
                        If sNETset = "PPP Adapter." Or sNETset = "PPP Adapter" Then
                            GoTo nextA
                        Else
                            frmComputers.cmbNET1.Text = sNETset
                        End If

                        'frmComputers.cmbNET1.Text = everIniFile.GetString("Сеть Windows", cn & "|Свойства сетевого адаптера|Сетевой адаптер","")
                        asa$ = everIniFile.GetString("Сеть Windows", cn & "|Адреса сетевого адаптера|Маска IP / Подсети",
                                                     "")
                        asb$ = everIniFile.GetString("Сеть Windows", cn & "|Свойства сетевого адаптера|Аппаратный адрес",
                                                     "")
                        frmComputers.txtNETip1.Text = asa$
                        frmComputers.txtNETmac1.Text = asb$

                        frmComputers.PROizV20.Text = everIniFile.GetString("Сеть Windows",
                                                                           cn & "|Производитель сетевого адаптера|Фирма",
                                                                           "")
                    End If
                End If

            End If
nextA:
        Next


        If Len(frmComputers.cmbNET1.Text) = 0 Then
            frmComputers.cmbNET1.Text = everIniFile.GetString("Суммарная информация", "Сеть|Сетевой адаптер1", "")
        End If

        If Len(frmComputers.cmbNET1.Text) = 0 Then
            frmComputers.cmbNET1.Text = everIniFile.GetString("Суммарная информация", "Сеть|Сетевой адаптер2", "")
        End If

        If _
            Left(frmComputers.cmbNET1.Text, 4) = "NDIS" Or Left(frmComputers.cmbNET1.Text, 4) = "Nove" Or
            Len(frmComputers.cmbNET1.Text) = 0 Then
            frmComputers.cmbNET1.Text = everIniFile.GetString("Сеть PCI / PNP", "Сеть PCI / PNP1", "")
        End If

        If Len(frmComputers.cmbNET1.Text) = 0 Then
            uname = everIniFile.GetString("Физические устройства", "PnP-устройства|Устройство1", "")

            prov = InStr(uname, "LAN")
            If prov > 1 Then
                frmComputers.cmbNET1.Text = uname
            Else
                uname = " "
                frmComputers.cmbNET1.Text = uname
            End If
        End If

        If Len(frmComputers.txtNETip1.Text) = 0 Then
            asa$ = everIniFile.GetString("Суммарная информация", "Сеть|Первичный адрес IP", "")
            asb$ = everIniFile.GetString("Суммарная информация", "Сеть|Первичный адрес MAC", "")
            frmComputers.txtNETip1.Text = asa$
            frmComputers.txtNETmac1.Text = asb$
        End If


        '################
        'Монитор
        frmComputers.cmbMon1.Text = everIniFile.GetString("Монитор", "Монитор1|Свойства монитора|Имя монитора", "")
        frmComputers.txtMon1Dum.Text = everIniFile.GetString("Монитор", "Монитор1|Свойства монитора|Тип монитора", "")
        frmComputers.txtMon1SN.Text = everIniFile.GetString("Монитор", "Монитор1|Свойства монитора|Серийный номер", "")
        frmComputers.PROizV28.Text = everIniFile.GetString("Монитор", "Монитор1|Производитель монитора|Фирма", "")


        If Len(frmComputers.cmbMon1.Text) = 0 Then
            frmComputers.PROizV28.Text = everIniFile.GetString("Монитор", "Монитор2|Производитель монитора|Фирма", "")
            frmComputers.cmbMon1.Text = everIniFile.GetString("Монитор", "Монитор2|Свойства монитора|Имя монитора", "")
            frmComputers.txtMon1Dum.Text = everIniFile.GetString("Монитор", "Монитор2|Свойства монитора|Тип монитора",
                                                                 "")
            frmComputers.txtMon1SN.Text = everIniFile.GetString("Монитор", "Монитор2|Свойства монитора|Серийный номер",
                                                                "")
        End If

        If Len(frmComputers.cmbMon1.Text) = 0 Then
            frmComputers.PROizV28.Text = everIniFile.GetString("Монитор", "Монитор3|Производитель монитора|Фирма", "")
            frmComputers.cmbMon1.Text = everIniFile.GetString("Монитор", "Монитор3|Свойства монитора|Имя монитора", "")
            frmComputers.txtMon1Dum.Text = everIniFile.GetString("Монитор", "Монитор3|Свойства монитора|Тип монитора",
                                                                 "")
            frmComputers.txtMon1SN.Text = everIniFile.GetString("Монитор", "Монитор3|Свойства монитора|Серийный номер",
                                                                "")
        End If

        If Len(frmComputers.cmbMon1.Text) = 0 Then
            frmComputers.PROizV28.Text = everIniFile.GetString("Монитор", "Монитор4|Производитель монитора|Фирма", "")
            frmComputers.cmbMon1.Text = everIniFile.GetString("Монитор", "Монитор4|Свойства монитора|Имя монитора", "")
            frmComputers.txtMon1Dum.Text = everIniFile.GetString("Монитор", "Монитор4|Свойства монитора|Тип монитора",
                                                                 "")
            frmComputers.txtMon1SN.Text = everIniFile.GetString("Монитор", "Монитор4|Свойства монитора|Серийный номер",
                                                                "")
        End If


        If Len(frmComputers.cmbMon1.Text) = 0 Then
            frmComputers.PROizV28.Text = ""
            frmComputers.cmbMon1.Text = everIniFile.GetString("Устройства Windows",
                                                              "Мониторы1|Свойства устройства|Описание драйвера", "")
            frmComputers.txtMon1SN.Text = ""
        End If


        If Len(frmComputers.cmbMon1.Text) = 0 Then
            frmComputers.PROizV28.Text = ""
            frmComputers.cmbMon1.Text = everIniFile.GetString("Устройства Windows",
                                                              "Monitors1|Свойства устройства|Описание драйвера", "")
            frmComputers.txtMon1SN.Text = ""
        End If


        If Len(frmComputers.cmbMon1.Text) = 0 Then
            frmComputers.PROizV28.Text = ""
            frmComputers.cmbMon1.Text = everIniFile.GetString("Устройства Windows",
                                                              "Monitor1|Свойства устройства|Описание драйвера", "")
            frmComputers.txtMon1SN.Text = ""
        End If

        If Len(frmComputers.cmbMon1.Text) = 0 Then
            frmComputers.cmbMon1.Text = everIniFile.GetString("Суммарная информация", "Дисплей|Монитор1", "")
            If Len(frmComputers.PROizV28.Text) = 0 Then
                frmComputers.PROizV28.Text = " "
            End If
        End If


        'Модуль подключения монитора [NoDB] 

        Dim as1 As String
        as1 = frmComputers.cmbMon1.Text


        If as1 = "Модуль подключения монитора [NoDB]" Then

            frmComputers.cmbMon1.Text = ""

            frmComputers.cmbMon1.Text = everIniFile.GetString("Монитор", "Монитор1|Свойства монитора|ID монитора", "")


            If Len(frmComputers.PROizV28.Text) = 0 Then
                frmComputers.PROizV28.Text = " "
            End If
        End If


        '################
        'Дисковод

        frmComputers.cmbFDD.Text = everIniFile.GetString("Суммарная информация", "Хранение данных|Флоппи-накопитель", "")

        If Len(frmComputers.cmbFDD.Text) = 0 Then
            frmComputers.cmbFDD.Text = everIniFile.GetString("Суммарная информация",
                                                             "Хранение данных|Флоппи-накопитель1", "")
        End If

        '################
        'Модем

        frmComputers.cmbModem.Text = everIniFile.GetString("Суммарная информация", "Сеть|Модем", "")

        If Len(frmComputers.cmbModem.Text) = 0 Then
            frmComputers.cmbModem.Text = everIniFile.GetString("Суммарная информация", "Сеть|Модем1", "")
        End If


        '################
        'Клавиатура

        frmComputers.cmbKeyb.Text = everIniFile.GetString("Суммарная информация", "Ввод|Клавиатура", "")
        If frmComputers.cmbKeyb.Text = "" Then
            frmComputers.cmbKeyb.Text = everIniFile.GetString("Суммарная информация", "Ввод|Клавиатура1", "")
        End If

        '################
        'Мышь
        frmComputers.cmbMouse.Text = everIniFile.GetString("Суммарная информация", "Ввод|Мышь", "")
        If frmComputers.cmbMouse.Text = "" Then
            frmComputers.cmbMouse.Text = everIniFile.GetString("Суммарная информация", "Ввод|Мышь1", "")
        End If


        '################
        'Антивирус
        'frmComputers.Ant.Text = ""
        'A = everIniFile.GetString("Антивирус", "Антивирус1","")
        'frmComputers.Ant.SelText = A
        'frmComputers.Ant.SelText = everIniFile.GetString("Антивирус", A & "|Версия программы","")

        '################
        'OS
        'frmComputers.os.Text = everIniFile.GetString("Суммарная информация", "Компьютер|Операционная система","")

        '################
        'Имя компа
        frmComputers.txtSNAME.Text = everIniFile.GetString("Имя компьютера", "Имя NetBIOS|Имя компьютера", "")
        'frmComputers.ps.Text = everIniFile.GetString("Имя компьютера", "Имя NetBIOS|Имя компьютера","")
        If Len(frmComputers.txtSNAME.Text) = 0 Then _
            frmComputers.txtSNAME.Text = everIniFile.GetString("Суммарная информация", "Компьютер|Имя компьютера",
                                                               "NoName")

        '################
        'Принтеры

        frmComputers.cmbPrinters1.Text = everIniFile.GetString("Принтеры", "Принтеры1|Свойства принтера|Имя принтера",
                                                               "")
        frmComputers.PROizV34.Text = everIniFile.GetString("Принтеры", "Принтеры1|Производитель принтера|Фирма", "")
        frmComputers.txtPrint1Port.Text = everIniFile.GetString("Принтеры", "Принтеры1|Свойства принтера|Порт принтера",
                                                                "")


        If Len(frmComputers.cmbPrinters1.Text) = 0 Then
            frmComputers.cmbPrinters1.Text = everIniFile.GetString("Суммарная информация",
                                                                   "Периферийные устройства|Принтер1", "")
        End If

        '2

        frmComputers.cmbPrinters2.Text = everIniFile.GetString("Принтеры", "Принтеры2|Свойства принтера|Имя принтера",
                                                               "")
        frmComputers.PROizV35.Text = everIniFile.GetString("Принтеры", "Принтеры2|Производитель принтера|Фирма", "")
        frmComputers.txtPrint2Port.Text = everIniFile.GetString("Принтеры", "Принтеры2|Свойства принтера|Порт принтера",
                                                                "")


        If Len(frmComputers.cmbPrinters2.Text) = 0 Then
            frmComputers.cmbPrinters2.Text = everIniFile.GetString("Суммарная информация",
                                                                   "Периферийные устройства|Принтер", "")
        End If

        '3
        frmComputers.cmbPrinters3.Text = everIniFile.GetString("Принтеры", "Принтеры3|Свойства принтера|Имя принтера",
                                                               "")
        frmComputers.PROizV36.Text = everIniFile.GetString("Принтеры", "Принтеры3|Производитель принтера|Фирма", "")
        frmComputers.txtPrint3Port.Text = everIniFile.GetString("Принтеры", "Принтеры3|Свойства принтера|Порт принтера",
                                                                "")

        If Len(frmComputers.cmbPrinters3.Text) = 0 Then
            frmComputers.cmbPrinters3.Text = everIniFile.GetString("Суммарная информация",
                                                                   "Периферийные устройства|Принтер3", "")
        End If


        frmComputers.txtModSB.Text = everIniFile.GetString("Суммарная информация", "DMI|DMI система", "")
        frmComputers.txtSNSB.Text = everIniFile.GetString("DMI", "Система|Свойства системы|Серийный номер", "")
        frmComputers.PROizV27.Text = everIniFile.GetString("Суммарная информация", "DMI|DMI производитель системы", "")

        Call usersload() 'esq 130728
        Call textp_Upd(frmComputers.lstSoftware, frmComputers.sCOUNT) 'esq
        Call SAVE_SOFT(frmComputers.lstSoftware, frmComputers.sCOUNT) 'esq

        Exit Sub
Err_handler:
        'cdat
    End Sub

    Public Sub textp_Upd(ByVal lstV As ListView, ByVal sSID As Integer)
        Dim uname As String
        Dim unameИздатель As String
        Dim unameДата As String
        Dim uname3 As String
        Dim unameВерсия As String

        Dim A As String
        Dim intj, intjk, beg, po_count As Integer 'esq

        'If MsgBox("Обновление программного обеспечения может привести к потере" & vbNewLine & " ваших старых данных о ПО" & vbNewLine & "Желаете продолжить?", vbExclamation + vbYesNo, "Обновление ПО","") = vbNo Then Exit Sub

        On Error GoTo Err_handler
        A = "Установленные программы"
        'lstV.ListItems.Clear

        'esq [*****************************
        Dim FSO As Object
        Dim tINI, oINI As String
        Dim l As Integer

        FSO = CreateObject("Scripting.FileSystemObject")
        oINI = EverestFilePatch
        l = Len(EverestFilePatch)
        tINI = Left(EverestFilePatch, l - 4) & "-soft.ini"
        If FSO.FileExists(tINI) Then
            EverestFilePatch = tINI
        End If

        Dim EverAll_PO As String
        Dim everFile As New IniFile(EverestFilePatch)
        EverAll_PO = "/"
        For intj = 1 To 400
            A = "Установленные программы" & intj
            uname = Trim(everFile.GetString("Установленные программы", A, ""))
            EverAll_PO = EverAll_PO & uname & "/"
        Next
        Dim sSQL, sSQL2 As String
        sSQL = "SELECT * FROM SOFT_INSTALL WHERE Id_Comp =" & sSID ' & " and Soft not like '%update%' and Soft not like '%Обновление%'" ORDER BY Soft, NomerSoftKomp"
        sSQL2 = "SELECT COUNT(*) as po_count FROM SOFT_INSTALL WHERE Id_Comp =" & sSID

        Dim rs As Recordset
        rs = New Recordset
        rs.Open(sSQL2, DB7, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic)
        po_count = rs.Fields("po_count").Value
        rs.Close()
        rs.Open(sSQL, DB7, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic)
        If po_count > 0 Then
            rs.MoveFirst()
            Do While Not rs.EOF
                'esq +WO_SETUP
                If rs.Fields("WO_SETUP").Value = True Then
                ElseIf InStr(EverAll_PO, "/" & Trim(rs.Fields("Soft").Value) & "/") = 0 Then
                    rs.Delete()
                Else
                    beg = InStr(EverAll_PO, "/" & Trim(rs.Fields("Soft").Value) & "/")
                    EverAll_PO = Left(EverAll_PO, beg) & Right(EverAll_PO, Len(EverAll_PO) - beg - Len(Trim(rs.Fields("Soft").Value)) - 1)
                End If
                rs.MoveNext()
            Loop
        End If
        rs.Close()
        rs = Nothing
        Call LOAD_SOFT(sSID, lstV)

        Dim everIniFile As New IniFile(EverestFilePatch)
        'esq ]*****************************

        For intj = 1 To 400

            A = "Установленные программы" & intj


            uname = everIniFile.GetString("Установленные программы", A, "")

            If uname Like "Update" Then GoTo A2
            If uname Like "Обновление" Then GoTo A2


            unameИздатель = everIniFile.GetString("Установленные программы", uname & "|Publisher", "")
            unameВерсия = everIniFile.GetString("Установленные программы", uname & "|Версия", "")

            If Len(unameИздатель) = 0 Then
                unameИздатель = everIniFile.GetString("Установленные программы", uname & "|Издатель", "")
            End If

            unameДата = everIniFile.GetString("Установленные программы", uname & "|Дата", "")

            If Not RSExists("PROYZV", "PROiZV", unameИздатель) Then
                AddPr(unameИздатель)
            End If

            'esq [***
            If IsDBNull(unameВерсия) = True And InStr(uname, "<") > 0 And InStr(uname, ">") = Len(uname) Then
                unameВерсия = Mid(uname, InStr(uname, "<") + 1, InStr(uname, ">") - InStr(uname, "<") - 1)
                uname = Trim(Left(uname, InStr(uname, "<") - 1))
            End If
            'esq [***

            If Len(uname) = 0 Then

                If A = "Установленные программы1" Then

                    uname = everIniFile.GetString("Установленные программы", "Установленные программы2", "")
                    unameИздатель = everIniFile.GetString("Установленные программы", uname & "|Publisher", "")
                    unameВерсия = everIniFile.GetString("Установленные программы", uname & "|Версия", "")

                    If Len(unameИздатель) = 0 Then
                        unameИздатель = everIniFile.GetString("Установленные программы", uname & "|Издатель", "")
                    End If

                    unameДата = everIniFile.GetString("Установленные программы", uname & "|Дата", "")

                    If Not (RSExistsSoft(sSID, uname)) Then 'esq frmComputers.sCOUNT

                        If unameДата = "<N/A>" Then unameДата = Date.Today
                        If Len(unameДата) = 0 Then unameДата = Date.Today

                        lstV.Items.Add(lstV.Items.Count + 1)
                        'esq [*****************************
                        intjk = lstV.Items.Count - 1

                        ' lstV.Items(intjk).SubItems.Add(lstV.Items.Count + 1)
                        lstV.Items(intjk).SubItems.Add(uname)
                        lstV.Items(intjk).SubItems.Add(unameВерсия)
                        lstV.Items(intjk).SubItems.Add("")
                        lstV.Items(intjk).SubItems.Add("")
                        lstV.Items(intjk).SubItems.Add(unameДата)
                        lstV.Items(intjk).SubItems.Add(Date.Today)
                        lstV.Items(intjk).SubItems.Add(unameИздатель)
                        lstV.Items(intjk).SubItems.Add("")
                        'lstV.Items(intjk).EnsureVisible()
                        'esq ]*****************************
                    End If
                End If
            Else
                Dim zagu As String
                zagu = InStr(uname, "для Windows XP")
                If zagu = "0" Then

                    If Not (RSExistsSoft(sSID, uname)) Then 'esq frmComputers.sCOUNT
                        'If SERT$ = 0 Then
                        If unameДата = "<N/A>" Then unameДата = Date.Today
                        If Len(unameДата) = 0 Then unameДата = Date.Today

                        lstV.Items.Add(lstV.Items.Count + 1)
                        'esq [*****************************
                        intjk = lstV.Items.Count - 1

                        ' lstV.Items(intjk).SubItems.Add(lstV.Items.Count + 1)
                        lstV.Items(intjk).SubItems.Add(uname)
                        lstV.Items(intjk).SubItems.Add(unameВерсия)
                        lstV.Items(intjk).SubItems.Add("")
                        lstV.Items(intjk).SubItems.Add("")
                        lstV.Items(intjk).SubItems.Add(unameДата)
                        lstV.Items(intjk).SubItems.Add(Date.Today)
                        lstV.Items(intjk).SubItems.Add(unameИздатель)
                        lstV.Items(intjk).SubItems.Add("")
                        'lstV.ListItems(intj).SubItems(7) = uname2              
                        'lstV.Items(intjk).EnsureVisible()                      
                        'esq ]*****************************
                    End If
                Else
                End If
            End If
A2:
        Next

        'esq [*****************************
        Dim OS_OS, SAGAZOD, B As String
        OS_OS = everIniFile.GetString("Операционная система", "Свойства операционной системы|Название ОС", "")
        SAGAZOD = everIniFile.GetString("Операционная система", "Лицензионная информация|Ключ продукта", "")
        OS_OS = OS_OS & " " & everIniFile.GetString("Операционная система", "Свойства операционной системы|Пакет обновления ОС", "")

        If Not (RSExistsSoft(sSID, OS_OS)) Then
            lstV.Items.Add(lstV.Items.Count + 1)
            intjk = lstV.Items.Count - 1

            lstV.Items(intjk).SubItems.Add(OS_OS)
            lstV.Items(intjk).SubItems.Add("")
            lstV.Items(intjk).SubItems.Add(SAGAZOD)
            lstV.Items(intjk).SubItems.Add("")
            lstV.Items(intjk).SubItems.Add(Date.Today)
            lstV.Items(intjk).SubItems.Add(Date.Today)
            lstV.Items(intjk).SubItems.Add("Microsoft Corporation")
            lstV.Items(intjk).SubItems.Add("Операционная система")
        End If
        'esq ]*****************************

        'esq [***** Лицензионный номер МСОфиса 
        Dim L_name, L_key As String
        Dim lstcount, n As Integer
        If InStr(oINI, "-soft.ini") Then
            l = Len(oINI)
            n = InStr(oINI, "-soft.ini")
            oINI = Left(oINI, n - 1) & ".ini"
        End If
        If FSO.FileExists(oINI) Then
            Dim oIniFile As New IniFile(oINI)
            For intj = 1 To 40
                L_name = ""
                L_key = ""
                A = "Лицензии" & intj
                L_name = oIniFile.GetString("Лицензии", A, "")
                If Len(L_name) > 0 Then
                    L_key = oIniFile.GetString("Лицензии", L_name & "|Ключ продукта", "")

                    If InStr(L_name, "office", Microsoft.VisualBasic.CompareMethod.Text) > 0 Then
                        For lstcount = 1 To lstV.Items.Count - 1
                            If InStr(lstV.Items(lstcount).SubItems.Item(1).Text, L_name) <> 0 Then
                                lstV.Items(lstcount).SubItems.Item(3).Text = L_key
                            End If
                        Next
                    End If
                End If
            Next
        End If
        'esq  ]**********
        Exit Sub
Err_handler:
    End Sub

    Private Sub LICENSE_READ(ByVal sProg As String)
        On Error GoTo err_
        Dim everIniFile As New IniFile(EverestFilePatch)
        Dim uname1, uname2 As String
        'esq [***** Лицензионный номер МСОфиса 
        Dim FSO As Object
        Dim oINI As String
        Dim l, n As Integer

        FSO = CreateObject("Scripting.FileSystemObject")

        If InStr(everIniFile.FileName, "-soft.ini") Then
            l = Len(everIniFile.FileName)
            n = InStr(everIniFile.FileName, "-soft.ini")
            oINI = Left(everIniFile.FileName, n - 1) & ".ini"
        End If

        If FSO.FileExists(oINI) Then
            'esq  ]**********
            For intj = 1 To 50

                uname1 = "Лицензии" & intj
                uname2 = everIniFile.GetString("Лицензии", uname1, "")

                If Len(uname2) = 0 Then Exit Sub

                Select Case Len(uname2)

                    Case 0


                    Case Else

                        If sProg = uname2 Then

                            stLKEY = everIniFile.GetString("Лицензии", uname2 & "|Ключ продукта", "")
                            Exit Sub
                        End If

                End Select

            Next
        End If 'esq


err_:
    End Sub

End Module
