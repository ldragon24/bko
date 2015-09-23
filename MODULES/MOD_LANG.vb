'Imports System.Drawing
'Imports System.Collections
'Imports System.ComponentModel
'Imports System.Xml
'Imports System.Xml.XPath

Module modLang
    Public Sub frmNetMag_selectSVT_LANG()

        frmNetMag_selectSVT.lvNetMagazin.Columns.Clear()

        Dim LNGIniFile As New IniFile(sLANGPATH)

        'lvNetMagazin
        frmNetMag_selectSVT.lvNetMagazin.Columns.Add(LNGIniFile.GetString("frmNetMag_selectSVT", "lvNetMagazin1", "id"),
                                                     1, HorizontalAlignment.Left)
        frmNetMag_selectSVT.lvNetMagazin.Columns.Add(LNGIniFile.GetString("frmNetMag_selectSVT", "lvNetMagazin2", "Тип"),
                                                     50, HorizontalAlignment.Left)
        frmNetMag_selectSVT.lvNetMagazin.Columns.Add(
            LNGIniFile.GetString("frmNetMag_selectSVT", "lvNetMagazin3", "Инв. №"), 50, HorizontalAlignment.Left)
        frmNetMag_selectSVT.lvNetMagazin.Columns.Add(
            LNGIniFile.GetString("frmNetMag_selectSVT", "lvNetMagazin4", "Имя в сети"), 50, HorizontalAlignment.Left)
        frmNetMag_selectSVT.lvNetMagazin.Columns.Add(
            LNGIniFile.GetString("frmNetMag_selectSVT", "lvNetMagazin5", "Ответственный"), 50, HorizontalAlignment.Left)
        frmNetMag_selectSVT.lvNetMagazin.Columns.Add(
            LNGIniFile.GetString("frmNetMag_selectSVT", "lvNetMagazin6", "Филиал"), 30, HorizontalAlignment.Left)
        frmNetMag_selectSVT.lvNetMagazin.Columns.Add(
            LNGIniFile.GetString("frmNetMag_selectSVT", "lvNetMagazin7", "Отдел"), 100, HorizontalAlignment.Left)
        frmNetMag_selectSVT.lvNetMagazin.Columns.Add(
            LNGIniFile.GetString("frmNetMag_selectSVT", "lvNetMagazin8", "Кабинет"), 100, HorizontalAlignment.Left)


        ResList(frmNetMag_selectSVT.lvNetMagazin)

        frmNetMag_selectSVT.Text = LNGIniFile.GetString("frmNetMag_selectSVT", "frmNetMag_selectSVT ", "Выбор СВТ")
        frmNetMag_selectSVT.Button1.Text = LNGIniFile.GetString("frmNetMag_selectSVT", "Button1", "Ок")
        frmNetMag_selectSVT.Button2.Text = LNGIniFile.GetString("frmNetMag_selectSVT", "Button2", "Отмена")
    End Sub

    Public Sub frmNetMag_Add_LANG()

        Dim LNGIniFile As New IniFile(sLANGPATH)

        frmNetMag_Add.Text = LNGIniFile.GetString("frmNetMag_Add", "frmNetMag_Add ", "Добавить\Изменить кабель СКС")

        frmNetMag_Add.Label1.Text = LNGIniFile.GetString("frmNetMag_Add", "Label1 ", "Идентификатор линии розетки")
        frmNetMag_Add.Label2.Text = LNGIniFile.GetString("frmNetMag_Add", "Label2 ", "Тип кабеля")
        frmNetMag_Add.Label3.Text = LNGIniFile.GetString("frmNetMag_Add", "Label3 ", "Длинна кабельной линии м.")
        frmNetMag_Add.Label4.Text = LNGIniFile.GetString("frmNetMag_Add", "Label4 ", "Тип кабельной линии")
        frmNetMag_Add.Label5.Text = LNGIniFile.GetString("frmNetMag_Add", "Label5 ", "Подключенное СВТ")
        frmNetMag_Add.Label6.Text = LNGIniFile.GetString("frmNetMag_Add", "Label6 ", "Сетевой порт СВТ")
        frmNetMag_Add.Label7.Text = LNGIniFile.GetString("frmNetMag_Add", "Label7 ", "Подключен телефон")
        frmNetMag_Add.Label8.Text = LNGIniFile.GetString("frmNetMag_Add", "Label8 ", "Примечание")
        frmNetMag_Add.Label9.Text = LNGIniFile.GetString("frmNetMag_Add", "Label9 ", "(в формате Eth0, Eth1 и т.д.)")
        frmNetMag_Add.Label10.Text = LNGIniFile.GetString("frmNetMag_Add", "Label10 ", "Коммутатор")
        frmNetMag_Add.Label11.Text = LNGIniFile.GetString("frmNetMag_Add", "Label11 ", "Сетевой порт коммутатора")
        frmNetMag_Add.Label13.Text = LNGIniFile.GetString("frmNetMag_Add", "Label13 ", "Примечание")
        frmNetMag_Add.Label14.Text = LNGIniFile.GetString("frmNetMag_Add", "Label14 ",
                                                          "(в формате Fa 0/xx, Gi 1/0/xx и т.д.)")

        frmNetMag_Add.GroupBox1.Text = LNGIniFile.GetString("frmNetMag_Add", "GroupBox1", "Рабочее место")
        frmNetMag_Add.GroupBox2.Text = LNGIniFile.GetString("frmNetMag_Add", "GroupBox2 ", "Коммуникационный шкаф")

        frmNetMag_Add.Button1.Text = LNGIniFile.GetString("frmNetMag_Add", "Button1 ", "Добавить")
        frmNetMag_Add.Button2.Text = LNGIniFile.GetString("frmNetMag_Add", "Button2 ", "Отмена")
    End Sub


    Public Sub frmMagazin_LANG()

        frmNetMagazin.lvNetMagazin.Columns.Clear()
        Dim LNGIniFile As New IniFile(sLANGPATH)


        'lvNetMagazin
        frmNetMagazin.lvNetMagazin.Columns.Add(LNGIniFile.GetString("frmNetMagazin", "lvNetMagazin1", "id"), 1,
                                               HorizontalAlignment.Left)
        frmNetMagazin.lvNetMagazin.Columns.Add(LNGIniFile.GetString("frmNetMagazin", "lvNetMagazin2", "Маркировка"), 50,
                                               HorizontalAlignment.Left)
        frmNetMagazin.lvNetMagazin.Columns.Add(LNGIniFile.GetString("frmNetMagazin", "lvNetMagazin3", "Тип кабеля"), 50,
                                               HorizontalAlignment.Left)
        frmNetMagazin.lvNetMagazin.Columns.Add(LNGIniFile.GetString("frmNetMagazin", "lvNetMagazin4", "Длина,м"), 50,
                                               HorizontalAlignment.Left)
        frmNetMagazin.lvNetMagazin.Columns.Add(LNGIniFile.GetString("frmNetMagazin", "lvNetMagazin5", "Тип линии"), 50,
                                               HorizontalAlignment.Left)
        frmNetMagazin.lvNetMagazin.Columns.Add(LNGIniFile.GetString("frmNetMagazin", "lvNetMagazin6", "Телефон"), 30,
                                               HorizontalAlignment.Left)
        frmNetMagazin.lvNetMagazin.Columns.Add(LNGIniFile.GetString("frmNetMagazin", "lvNetMagazin7", "Ответственный"),
                                               100, HorizontalAlignment.Left)
        frmNetMagazin.lvNetMagazin.Columns.Add(LNGIniFile.GetString("frmNetMagazin", "lvNetMagazin8", "СВТ"), 100,
                                               HorizontalAlignment.Left)

        frmNetMagazin.lvNetMagazin.Columns.Add(
            LNGIniFile.GetString("frmNetMagazin", "lvNetMagazin12", "Место установки"), 100, HorizontalAlignment.Left)

        frmNetMagazin.lvNetMagazin.Columns.Add(LNGIniFile.GetString("frmNetMagazin", "lvNetMagazin9", "Коммутатор"), 100,
                                               HorizontalAlignment.Left)
        frmNetMagazin.lvNetMagazin.Columns.Add(LNGIniFile.GetString("frmNetMagazin", "lvNetMagazin10", "Порт"), 100,
                                               HorizontalAlignment.Left)
        frmNetMagazin.lvNetMagazin.Columns.Add(LNGIniFile.GetString("frmNetMagazin", "lvNetMagazin11", "Примечание"),
                                               100, HorizontalAlignment.Left)

        ResList(frmNetMagazin.lvNetMagazin)

        frmNetMagazin.gbTree.Text = LNGIniFile.GetString("frmNetMagazin", "gbTree", "Дерево")
        frmNetMagazin.tsbExcell.Text = LNGIniFile.GetString("frmNetMagazin", "tsbExcell", "В Офис")
        frmNetMagazin.Text = LNGIniFile.GetString("frmNetMagazin", "frmNetMagazin", "Кабельный журнал")


        frmNetMagazin.GroupBox1.Text = LNGIniFile.GetString("frmNetMagazin", "GroupBox1", "КЛС")
        frmNetMagazin.Label1.Text = LNGIniFile.GetString("frmNetMagazin", "Label1", "Всего портов:")
        frmNetMagazin.Label2.Text = LNGIniFile.GetString("frmNetMagazin", "Label2", "Из них занято:")
        frmNetMagazin.Label3.Text = LNGIniFile.GetString("frmNetMagazin", "Label3", "Длинна КЛС:")
    End Sub


    Public Sub frmCartr3_Lang()
        Dim objIniFile As New IniFile(sLANGPATH)


        frmCRT3.lvCartZAP.Columns.Add(objIniFile.GetString("frmCRT3", "lvCartZAP1", "id"), 20, HorizontalAlignment.Left)
        frmCRT3.lvCartZAP.Columns.Add(objIniFile.GetString("frmCRT3", "lvCartZAP2", "Номер"), 50,
                                      HorizontalAlignment.Left)
        frmCRT3.lvCartZAP.Columns.Add(objIniFile.GetString("frmCRT3", "lvCartZAP3", "Дата"), 70,
                                      HorizontalAlignment.Left)
        frmCRT3.lvCartZAP.Columns.Add(objIniFile.GetString("frmCRT3", "lvCartZAP4", "Операция"), 100,
                                      HorizontalAlignment.Left)
        frmCRT3.lvCartZAP.Columns.Add(objIniFile.GetString("frmCRT3", "lvCartZAP5", "Цена"), 60,
                                      HorizontalAlignment.Left)
        frmCRT3.lvCartZAP.Columns.Add(objIniFile.GetString("frmCRT3", "lvCartZAP6", "Фирма"), 100,
                                      HorizontalAlignment.Left)

        frmCRT3.lvCRTMove.Columns.Add(objIniFile.GetString("frmCRT3", "lvCRTMove1", "id"), 20, HorizontalAlignment.Left)
        frmCRT3.lvCRTMove.Columns.Add(objIniFile.GetString("frmCRT3", "lvCRTMove2", "От куда"), 100,
                                      HorizontalAlignment.Left)
        frmCRT3.lvCRTMove.Columns.Add(objIniFile.GetString("frmCRT3", "lvCRTMove3", "Куда"), 100,
                                      HorizontalAlignment.Left)
        frmCRT3.lvCRTMove.Columns.Add(objIniFile.GetString("frmCRT3", "lvCRTMove4", "Причина"), 300,
                                      HorizontalAlignment.Left)
        frmCRT3.lvCRTMove.Columns.Add(objIniFile.GetString("frmCRT3", "lvCRTMove5", "Дата"), 50,
                                      HorizontalAlignment.Left)
        frmCRT3.lvCRTMove.Columns.Add(objIniFile.GetString("frmCRT3", "lvCRTMove6", "Время"), 50,
                                      HorizontalAlignment.Left)

        frmCRT3.Text = objIniFile.GetString("frmCRT3", "frmCRT3", "Учёт картриджей")
        frmCRT3.gbTree.Text = objIniFile.GetString("frmCRT3", "gbTree", "Печатающие устройства")
        frmCRT3.Label1.Text = objIniFile.GetString("frmCRT3", "Label1", "№")
        frmCRT3.Label2.Text = objIniFile.GetString("frmCRT3", "Label2", "Серийный номер:")
        frmCRT3.Label3.Text = objIniFile.GetString("frmCRT3", "Label3", "Производитель:")
        frmCRT3.Label4.Text = objIniFile.GetString("frmCRT3", "Label4", "Тип картриджа:")
        frmCRT3.Label5.Text = objIniFile.GetString("frmCRT3", "Label5", "Модель:")
        frmCRT3.Label6.Text = objIniFile.GetString("frmCRT3", "Label6", "В составе устройства:")
        frmCRT3.Label7.Text = objIniFile.GetString("frmCRT3", "Label7", "Примечания:")
        frmCRT3.Label8.Text = objIniFile.GetString("frmCRT3", "Label8", "Продавец:")
        frmCRT3.Label9.Text = objIniFile.GetString("frmCRT3", "Label9", "Счёт фактура:")
        frmCRT3.Label10.Text = objIniFile.GetString("frmCRT3", "Label10", "Цена:")
        frmCRT3.Label11.Text = objIniFile.GetString("frmCRT3", "Label11", "Дата приобретения:")

        frmCRT3.TabControl1.TabPages("TabPage1").Text = objIniFile.GetString("frmCRT3", "TabControl1.TabPage1",
                                                                             "Картридж")
        frmCRT3.TabControl1.TabPages("TabPage2").Text = objIniFile.GetString("frmCRT3", "TabControl1.TabPage2",
                                                                             "Заправки")
        frmCRT3.TabControl1.TabPages("TabPage3").Text = objIniFile.GetString("frmCRT3", "TabControl1.TabPage3",
                                                                             "Перемещения")

        frmCRT3.chkIznos.Text = objIniFile.GetString("frmCRT3", "chkIznos", "Изношен")
        frmCRT3.chkSPS.Text = objIniFile.GetString("frmCRT3", "chkSPS", "Списан")
        frmCRT3.chkNezap.Text = objIniFile.GetString("frmCRT3", "chkNezap", "Не заправляемый")
        frmCRT3.chkNZ.Text = objIniFile.GetString("frmCRT3", "chkNZ", "Не заправлен")
        frmCRT3.chkNaSP.Text = objIniFile.GetString("frmCRT3", "chkNaSP", "На списание")
        frmCRT3.btnAdd.Text = objIniFile.GetString("frmCRT3", "btnAdd", "Добавить")
        frmCRT3.btnCancel.Text = objIniFile.GetString("frmCRT3", "btnCancel", "Отмена")
        frmCRT3.btnDelete.Text = objIniFile.GetString("frmCRT3", "btnDelete", "Удалить")

        frmCRT3.btnZapAdd.Text = objIniFile.GetString("frmCRT3", "btnZapAdd", "Добавить")
        frmCRT3.btnZapDel.Text = objIniFile.GetString("frmCRT3", "btnZapDel", "Удалить")
        frmCRT3.btnZapReport.Text = objIniFile.GetString("frmCRT3", "btnZapReport", "Отчёт по заправкам")


        'ResList(frmCRT3.lvCartZAP)
        'ResList(frmCRT3.lvCRTMove)
        ''ResList(frmCartr2.LVCart)
        'lvCartZAP
    End Sub

    Public Sub LANG_frmCartr_ADD_ZAp()
        Dim objIniFile As New IniFile(sLANGPATH)


        frmCartr_Add_Zap.Text = objIniFile.GetString("frmCartr_Add_Zap", "frmCartr_Add_Zap",
                                                     "Добавление (редактирование) заправки")

        frmCartr_Add_Zap.Label1.Text = objIniFile.GetString("frmCartr_Add_Zap", "Label1", "Заправка №")
        frmCartr_Add_Zap.Label2.Text = objIniFile.GetString("frmCartr_Add_Zap", "Label2", "Сервис центр")
        frmCartr_Add_Zap.Label3.Text = objIniFile.GetString("frmCartr_Add_Zap", "Label3", "Акт выполненных работ")
        frmCartr_Add_Zap.Label4.Text = objIniFile.GetString("frmCartr_Add_Zap", "Label4", "от")
        frmCartr_Add_Zap.Label5.Text = objIniFile.GetString("frmCartr_Add_Zap", "Label5", "Стоимость")
        frmCartr_Add_Zap.Label6.Text = objIniFile.GetString("frmCartr_Add_Zap", "Label6", "Количество страниц")
        frmCartr_Add_Zap.Label7.Text = objIniFile.GetString("frmCartr_Add_Zap", "Label7", "Заправлен")

        frmCartr_Add_Zap.chkRef.Text = objIniFile.GetString("frmCartr_Add_Zap", "chkRef", "Восстановлен")
        frmCartr_Add_Zap.btnAdd.Text = objIniFile.GetString("frmCartr_Add_Zap", "btnAdd", "Добавить")
        frmCartr_Add_Zap.btnCancel.Text = objIniFile.GetString("frmCartr_Add_Zap", "btnCancel", "Отмена")
    End Sub

    Public Sub LANG_frmCartr_ADD()
        Dim objIniFile As New IniFile(sLANGPATH)


        frmCartr_ADD.Text = objIniFile.GetString("frmCartr_ADD", "frmCartr_ADD", "Добавление (Редактирование) картриджа")
        frmCartr_ADD.Label1.Text = objIniFile.GetString("frmCartr_ADD", "Label1", "№")
        frmCartr_ADD.Label2.Text = objIniFile.GetString("frmCartr_ADD", "Label2", "Серийный номер:")
        frmCartr_ADD.Label3.Text = objIniFile.GetString("frmCartr_ADD", "Label3", "Производитель:")
        frmCartr_ADD.Label4.Text = objIniFile.GetString("frmCartr_ADD", "Label4", "Тип картриджа:")
        frmCartr_ADD.Label5.Text = objIniFile.GetString("frmCartr_ADD", "Label5", "Модель:")
        frmCartr_ADD.Label6.Text = objIniFile.GetString("frmCartr_ADD", "Label6", "В составе устройства:")
        frmCartr_ADD.Label7.Text = objIniFile.GetString("frmCartr_ADD", "Label7", "Примечания:")
        frmCartr_ADD.Label8.Text = objIniFile.GetString("frmCartr_ADD", "Label8", "Продавец:")
        frmCartr_ADD.Label9.Text = objIniFile.GetString("frmCartr_ADD", "Label9", "Счёт фактура:")
        frmCartr_ADD.Label10.Text = objIniFile.GetString("frmCartr_ADD", "Label10", "Цена:")
        frmCartr_ADD.Label11.Text = objIniFile.GetString("frmCartr_ADD", "Label11", "Дата приобретения:")

        frmCartr_ADD.chkNezap.Text = objIniFile.GetString("frmCartr_ADD", "chkNezap", "Не заправляемый")
        frmCartr_ADD.chkNZ.Text = objIniFile.GetString("frmCartr_ADD", "chkNZ", "Не заправлен")
        frmCartr_ADD.chkIznos.Text = objIniFile.GetString("frmCartr_ADD", "chkIznos", "Изношен")
        frmCartr_ADD.chkSPS.Text = objIniFile.GetString("frmCartr_ADD", "chkSPS", "Списан")
        frmCartr_ADD.chkNaSP.Text = objIniFile.GetString("frmCartr_ADD", "chkNaSP", "На списание")
        frmCartr_ADD.btnAdd.Text = objIniFile.GetString("frmCartr_ADD", "btnAdd", "Добавить")
        'frmCartr_ADD.btnAdd2.Text = objIniFile.GetString("frmCartr_ADD", "btnAdd2", "")
        frmCartr_ADD.btnCancel.Text = objIniFile.GetString("frmCartr_ADD", "btnCancel", "Отмена")
    End Sub

    Public Sub LANG_frmserviceDesk()
        Dim LNGIniFile As New IniFile(sLANGPATH)

        frmserviceDesc.lvRem.Columns.Clear()
        frmserviceDesc.lvRem.Columns.Add(LNGIniFile.GetString("frmserviceDesc", "lvRem1", "id"), 20,
                                         HorizontalAlignment.Left)
        frmserviceDesc.lvRem.Columns.Add(LNGIniFile.GetString("frmserviceDesc", "lvRem3", "№"), 30,
                                         HorizontalAlignment.Left)
        frmserviceDesc.lvRem.Columns.Add(LNGIniFile.GetString("frmserviceDesc", "lvRem4", "Дата"), 90,
                                         HorizontalAlignment.Left)
        frmserviceDesc.lvRem.Columns.Add(LNGIniFile.GetString("frmserviceDesc", "lvRem5", "Описание"), 300,
                                         HorizontalAlignment.Left)
        frmserviceDesc.lvRem.Columns.Add(LNGIniFile.GetString("frmserviceDesc", "lvRem6", "Уровень"), 100,
                                         HorizontalAlignment.Left)
        frmserviceDesc.lvRem.Columns.Add(LNGIniFile.GetString("frmserviceDesc", "lvRem7", "Мастер"), 100,
                                         HorizontalAlignment.Left)
        frmserviceDesc.lvRem.Columns.Add(LNGIniFile.GetString("frmserviceDesc", "lvRem8", "Выполнение"), 100,
                                         HorizontalAlignment.Left)
        frmserviceDesc.lvRem.Columns.Add(LNGIniFile.GetString("frmserviceDesc", "lvRem9", "Срок выполнения"), 90,
                                         HorizontalAlignment.Left)
        frmserviceDesc.lvRem.Columns.Add(LNGIniFile.GetString("frmserviceDesc", "lvRem10", "Пользователь"), 100,
                                         HorizontalAlignment.Left)


        frmserviceDesc.lvRem2.Columns.Clear()
        frmserviceDesc.lvRem2.Columns.Add(LNGIniFile.GetString("frmserviceDesc", "lvRem2_1", "id"), 20,
                                          HorizontalAlignment.Left)
        frmserviceDesc.lvRem2.Columns.Add(LNGIniFile.GetString("frmserviceDesc", "lvRem2_2", "Дата"), 90,
                                          HorizontalAlignment.Left)
        frmserviceDesc.lvRem2.Columns.Add(LNGIniFile.GetString("frmserviceDesc", "lvRem2_3", "Мастер"), 100,
                                          HorizontalAlignment.Left)
        frmserviceDesc.lvRem2.Columns.Add(LNGIniFile.GetString("frmserviceDesc", "lvRem2_4", "Описание"), 300,
                                          HorizontalAlignment.Left)

        'ResList(frmserviceDesc.lvRem)
        'ResList(frmserviceDesc.lvRem2)

        frmserviceDesc.Text = LNGIniFile.GetString("frmserviceDesc", "frmserviceDesc", "Учёт заявок")
        frmserviceDesc.gbTree.Text = LNGIniFile.GetString("frmserviceDesc", "gbTree", "Дерево")
        frmserviceDesc.gbRem.Text = LNGIniFile.GetString("frmserviceDesc", "gbRem", "Заявки:")
        frmserviceDesc.btnRemAdd.Text = LNGIniFile.GetString("frmserviceDesc", "btnRemAdd", "Регистрация новой")
        frmserviceDesc.btnSBTAdd.Text = LNGIniFile.GetString("frmserviceDesc", "btnSBTAdd", "Добавить событие")
        frmserviceDesc.btnRemDel.Text = LNGIniFile.GetString("frmserviceDesc", "btnRemDel", "Удалить заявку")
        frmserviceDesc.chkNZ.Text = LNGIniFile.GetString("frmserviceDesc", "chkNZ", "Не завершенные")
        frmserviceDesc.CheckBox2.Text = LNGIniFile.GetString("frmserviceDesc", "CheckBox2", "Все не завершенные")
        frmserviceDesc.btnSendEmail.Text = LNGIniFile.GetString("frmserviceDesc", "btnSendEmail", "Отправить мастеру")
        frmserviceDesc.gbRem2.Text = LNGIniFile.GetString("frmserviceDesc", "gbRem2", "Выполненные работы:")
        frmserviceDesc.CheckBox1.Text = LNGIniFile.GetString("frmSoftware", "CheckBox2", "Массовое удаление")

        frmserviceDesc.ToolStripDropDownButton1.Text = LNGIniFile.GetString("frmserviceDesc", "ToolStripDropDownButton1", "Печать")
        frmserviceDesc.btn_Z_to_Office.Text = LNGIniFile.GetString("frmserviceDesc", "btn_Z_to_Office", "Акт-заявка")
        frmserviceDesc.btn_N_to_Office.Text = LNGIniFile.GetString("frmserviceDesc", "btn_N_to_Office", "Наряд")
        frmserviceDesc.btn_MAT_to_Office.Text = LNGIniFile.GetString("frmserviceDesc", "btn_MAT_to_Office", "Материальный пропуск")
        frmserviceDesc.Button1.Text = LNGIniFile.GetString("frmserviceDesc", "Button1", "Расписка")
        frmserviceDesc.MnuBlank.Text = LNGIniFile.GetString("frmMain", "19", "Бланк")


        frmserviceDesc.EditService.Text = LNGIniFile.GetString("frmComputers", "EditService", "Редактировать")
        frmserviceDesc.DeleteService.Text = LNGIniFile.GetString("frmComputers", "DeleteService", "Удалить")
        frmserviceDesc.MnuSendEmail.Text = LNGIniFile.GetString("frmComputers", "MnuSendEmail", "Отправить мастеру")
        frmserviceDesc.addServiseWork.Text = LNGIniFile.GetString("frmserviceDesc", "btnSBTAdd", "Добавить событие")
        frmserviceDesc.mnu_Z_to_Office.Text = LNGIniFile.GetString("frmserviceDesc", "ToolStripDropDownButton1", "Печать")
        frmserviceDesc.mnu_z_rasp.Text = LNGIniFile.GetString("frmserviceDesc", "Button1", "Расписка")



        'MnuBlank
    End Sub

    Public Sub frmSearch_Lang()
        Dim objIniFile As New IniFile(sLANGPATH)


        frmSearch.lstSearch.Columns.Add(objIniFile.GetString("frmSearch", "lstSearch1", "id"), 20,
                                        HorizontalAlignment.Left)
        frmSearch.lstSearch.Columns.Add(objIniFile.GetString("frmSearch", "lstSearch2", "Процессор"), 100,
                                        HorizontalAlignment.Left)
        frmSearch.lstSearch.Columns.Add(
            objIniFile.GetString("frmSearch", "lstSearch3", "Материнская плата, память и Жесткий диск"), 100,
            HorizontalAlignment.Left)
        frmSearch.lstSearch.Columns.Add(objIniFile.GetString("frmSearch", "lstSearch4", "Видео карта"), 100,
                                        HorizontalAlignment.Left)
        frmSearch.lstSearch.Columns.Add(objIniFile.GetString("frmSearch", "lstSearch5", "Звуковая карта"), 100,
                                        HorizontalAlignment.Left)
        frmSearch.lstSearch.Columns.Add(objIniFile.GetString("frmSearch", "lstSearch6", "Оптический диск"), 100,
                                        HorizontalAlignment.Left)
        frmSearch.lstSearch.Columns.Add(objIniFile.GetString("frmSearch", "lstSearch7", "Место установки"), 100,
                                        HorizontalAlignment.Left)
        frmSearch.lstSearch.Columns.Add(objIniFile.GetString("frmSearch", "lstSearch8", "Имя компьютера"), 100,
                                        HorizontalAlignment.Left)
        frmSearch.lstSearch.Columns.Add(objIniFile.GetString("frmSearch", "lstSearch9", "Найденное"), 100,
                                        HorizontalAlignment.Left)

        'ResList(frmSearch.lstSearch)

        frmSearch.Text = objIniFile.GetString("frmSearch", "frmSearch", "Поиск")
        frmSearch.gbSearch.Text = objIniFile.GetString("frmSearch", "gbSearch", "Что и где ищем?")

        frmSearch.Label1.Text = objIniFile.GetString("frmSearch", "Label1", "Что ищем?")
        frmSearch.CheckBox1.Text = objIniFile.GetString("frmSearch", "CheckBox1", "Только слово")
        frmSearch.CheckBox2.Text = objIniFile.GetString("frmSearch", "CheckBox2", "Учитывать регистр")
        frmSearch.Button1.Text = objIniFile.GetString("frmSearch", "Button1", "Искать")
        frmSearch.btnOfSend.Text = objIniFile.GetString("frmSearch", "btnOfSend", "В офис")
    End Sub

    Public Sub frmService_add_Lang()
        Dim objIniFile As New IniFile(sLANGPATH)


        'If frmService_add.REMED = True Then

        'Else
        '    frmService_add.Text = objIniFile.GetString("frmService_add", "frmService_add",
        '                                                      "Добавление (редактирование) заявки")

        'End If

        frmService_add.Label1.Text = objIniFile.GetString("frmService_add", "Label1", "Источник:")
        frmService_add.Label2.Text = objIniFile.GetString("frmService_add", "Label2", "Мастер:")
        frmService_add.Label3.Text = objIniFile.GetString("frmService_add", "Label3", "Дата регистрации:")
        frmService_add.Label4.Text = objIniFile.GetString("frmService_add", "Label4", "Телефон:")
        frmService_add.Label5.Text = objIniFile.GetString("frmService_add", "Label5", "Срок исполнения:")
        frmService_add.Label6.Text = objIniFile.GetString("frmService_add", "Label6", "Заголовок:")
        frmService_add.Label7.Text = objIniFile.GetString("frmService_add", "Label7", "Сообщение:")
        frmService_add.Label8.Text = objIniFile.GetString("frmService_add", "Label8", "Ответственный:")
        frmService_add.Label9.Text = objIniFile.GetString("frmService_add", "Label9", "Статус:")
        frmService_add.Label10.Text = objIniFile.GetString("frmService_add", "Label10", "Тип:")
        frmService_add.Label11.Text = objIniFile.GetString("frmService_add", "Label11", "Критичность:")
        frmService_add.Label12.Text = objIniFile.GetString("frmService_add", "Label12",
                                                           "Действительный характер неисправности:")
        frmService_add.Label13.Text = objIniFile.GetString("frmService_add", "Label13", "Затраты:")

        frmService_add.chkClose.Text = objIniFile.GetString("frmService_add", "chkClose", "Заявка закрыта")
        frmService_add.cmbAdd.Text = objIniFile.GetString("frmService_add", "cmbAdd", "Добавить")
        frmService_add.cmbCancel.Text = objIniFile.GetString("frmService_add", "cmbCancel", "Отмена")
        frmService_add.lblWarant.Text = objIniFile.GetString("frmService_add", "lblWarant", "Гарантия:")


    End Sub

    Public Sub frmservice_add_otvets_Lang()
        Dim LNGIniFile As New IniFile(sLANGPATH)

        frmservice_add_otvets.Text = LNGIniFile.GetString("frmservice_add_otvets", "frmservice_add_otvets",
                                                          "Выполненные работы")
        frmservice_add_otvets.GroupBox1.Text = LNGIniFile.GetString("frmservice_add_otvets", "GroupBox1",
                                                                    "Выполненные работы")

        frmservice_add_otvets.Label1.Text = LNGIniFile.GetString("frmservice_add_otvets", "Label1", "Дата")
        frmservice_add_otvets.Label2.Text = LNGIniFile.GetString("frmservice_add_otvets", "Label2", "Мастер")
        frmservice_add_otvets.chcClose.Text = LNGIniFile.GetString("frmservice_add_otvets", "chcClose", "Закрыта")
        frmservice_add_otvets.Label3.Text = LNGIniFile.GetString("frmservice_add_otvets", "Label3", "Тип:")
        frmservice_add_otvets.gbExt.Text = LNGIniFile.GetString("frmservice_add_otvets", "gbExt", "Расширенный вариант")
        frmservice_add_otvets.Label4.Text = LNGIniFile.GetString("frmservice_add_otvets", "Label4", "Статус:")
        frmservice_add_otvets.Label5.Text = LNGIniFile.GetString("frmservice_add_otvets", "Label5", "Ответственный:")
        frmservice_add_otvets.Label6.Text = LNGIniFile.GetString("frmservice_add_otvets", "Label6", "Критичность:")
        frmservice_add_otvets.Label7.Text = LNGIniFile.GetString("frmservice_add_otvets", "Label7", "Объект:")
        frmservice_add_otvets.cmdAdd.Text = LNGIniFile.GetString("frmservice_add_otvets", "cmdAdd", "Добавить")
        frmservice_add_otvets.cmdCancel.Text = LNGIniFile.GetString("frmservice_add_otvets", "cmdCancel", "Отменить")
    End Sub

    Public Sub frmDirectory_Lang()
        Dim objIniFile As New IniFile(sLANGPATH)


        frmDirectory.lvDirectory.Columns.Add(objIniFile.GetString("frmDirectory", "lvDirectory1", "id"), 20,
                                             HorizontalAlignment.Left)
        frmDirectory.lvDirectory.Columns.Add(objIniFile.GetString("frmDirectory", "lvDirectory2", "Наименование"), 300,
                                             HorizontalAlignment.Left)
        frmDirectory.lvDirectory.Columns.Add(objIniFile.GetString("frmDirectory", "lvDirectory3", "Производитель"), 300,
                                             HorizontalAlignment.Left)

        'ResList(frmDirectory.lvDirectory)

        frmDirectory.Text = objIniFile.GetString("frmDirectory", "frmDirectory", "Справочники")

        frmDirectory.gbSpr.Text = objIniFile.GetString("frmDirectory", "gbSpr", "Параметры")
        frmDirectory.Label1.Text = objIniFile.GetString("frmDirectory", "Label1", "Наименование")
        frmDirectory.Label2.Text = objIniFile.GetString("frmDirectory", "Label2", "Наименование")
        frmDirectory.Label3.Text = objIniFile.GetString("frmDirectory", "Label3", "Производитель")
        frmDirectory.Label4.Text = objIniFile.GetString("frmDirectory", "Label4", "Примечание")

        frmDirectory.gb1.Text = objIniFile.GetString("frmDirectory", "gb1", "Тип")
        frmDirectory.gb2.Text = objIniFile.GetString("frmDirectory", "gb2", "Тип")
        frmDirectory.chkVisibleSTR.Text = objIniFile.GetString("frmDirectory", "chkVisibleSTR", "Не отображать")
        frmDirectory.btnDirAdd.Text = objIniFile.GetString("frmDirectory", "btnDirAdd", "Добавить")

        frmDirectory.Button2.Text = objIniFile.GetString("frmDirectory", "Button2", "Удалить")
        frmDirectory.btnCancell.Text = objIniFile.GetString("frmDirectory", "btnCancell", "Отмена")
        frmDirectory.Button3.Text = objIniFile.GetString("frmDirectory", "Button3", "Выход")
        frmDirectory.CheckBox2.Text = objIniFile.GetString("frmSoftware", "CheckBox2", "Массовое удаление")
    End Sub

    Public Sub frmSclad_Lang()
        Dim objIniFile As New IniFile(sLANGPATH)


        frmSclad.lvSclad.Columns.Add(objIniFile.GetString("frmSclad", "lvSclad1", "id"), 20, HorizontalAlignment.Left)
        frmSclad.lvSclad.Columns.Add(objIniFile.GetString("frmSclad", "lvSclad2", "Наименование"), 150,
                                     HorizontalAlignment.Left)
        frmSclad.lvSclad.Columns.Add(objIniFile.GetString("frmSclad", "lvSclad3", "Поступило"), 50,
                                     HorizontalAlignment.Left)
        frmSclad.lvSclad.Columns.Add(objIniFile.GetString("frmSclad", "lvSclad4", "Осталось"), 50,
                                     HorizontalAlignment.Left)
        frmSclad.lvSclad.Columns.Add(objIniFile.GetString("frmSclad", "lvSclad5", "Поставщик"), 100,
                                     HorizontalAlignment.Left)
        frmSclad.lvSclad.Columns.Add(objIniFile.GetString("frmSclad", "lvSclad6", "Дата получения"), 65,
                                     HorizontalAlignment.Left)
        frmSclad.lvSclad.Columns.Add(objIniFile.GetString("frmSclad", "lvSclad7", "Примечание"), 120,
                                     HorizontalAlignment.Left)
        frmSclad.lvSclad.Columns.Add(objIniFile.GetString("frmSclad", "lvSclad8", "Номер счёта"), 50,
                                     HorizontalAlignment.Left)
        frmSclad.lvSclad.Columns.Add(objIniFile.GetString("frmSclad", "lvSclad9", "Гарантия"), 67,
                                     HorizontalAlignment.Left)
        frmSclad.lvSclad.Columns.Add(objIniFile.GetString("frmSclad", "lvSclad10", "Стоимость с НДС"), 67,
                                     HorizontalAlignment.Left)
        frmSclad.lvSclad.Columns.Add(objIniFile.GetString("frmSclad", "lvSclad11", "Требование"), 67,
                                     HorizontalAlignment.Left)
        frmSclad.lvSclad.Columns.Add(objIniFile.GetString("frmSclad", "lvSclad12", "Номер платежного поручения"), 67,
                                     HorizontalAlignment.Left)
        frmSclad.lvSclad.Columns.Add(objIniFile.GetString("frmSclad", "lvSclad13", "Цена"), 67, HorizontalAlignment.Left)
        frmSclad.lvSclad.Columns.Add(objIniFile.GetString("frmSclad", "lvSclad14", "Приписано к..."), 67,
                                     HorizontalAlignment.Left)

        'ResList(frmSclad.lvSclad)


        frmSclad.Text = objIniFile.GetString("frmSclad", "frmSclad", "Склад")

        frmSclad.btnAdd.Text = objIniFile.GetString("frmSclad", "btnAdd", "Добавить")
        frmSclad.btnDel.Text = objIniFile.GetString("frmSclad", "btnDel", "Удалить")
        frmSclad.btnTREB.Text = objIniFile.GetString("frmSclad", "btnTREB", "Выписать требование")
        frmSclad.btnOffice.Text = objIniFile.GetString("frmSclad", "btnOffice", "В Офис")
    End Sub

    Public Sub LANG_frmSclad_ADD()
        Dim objIniFile As New IniFile(sLANGPATH)
        frmSclad_ADD.Text = objIniFile.GetString("frmSclad_ADD", "frmSclad_ADD", "Добавить (редактировать) на склад")

        frmSclad_ADD.Label1.Text = objIniFile.GetString("frmSclad_ADD", "Label1", "Наименование:")
        frmSclad_ADD.Label2.Text = objIniFile.GetString("frmSclad_ADD", "Label2", "Поступило:")
        frmSclad_ADD.Label3.Text = objIniFile.GetString("frmSclad_ADD", "Label3", "Остаток:")
        frmSclad_ADD.Label4.Text = objIniFile.GetString("frmSclad_ADD", "Label4", "Номер требования:")
        frmSclad_ADD.Label5.Text = objIniFile.GetString("frmSclad_ADD", "Label5", "Поставщик:")
        frmSclad_ADD.Label6.Text = objIniFile.GetString("frmSclad_ADD", "Label6", "Примечание:")
        frmSclad_ADD.Label7.Text = objIniFile.GetString("frmSclad_ADD", "Label7", "Счёт:")
        frmSclad_ADD.Label8.Text = objIniFile.GetString("frmSclad_ADD", "Label8", "№ Платежного поручения:")
        frmSclad_ADD.Label9.Text = objIniFile.GetString("frmSclad_ADD", "Label9", "Дата получения:")
        frmSclad_ADD.Label10.Text = objIniFile.GetString("frmSclad_ADD", "Label10", "Гарантия:")
        frmSclad_ADD.Label11.Text = objIniFile.GetString("frmSclad_ADD", "Label11", "Стоимость включая НДС:")
        frmSclad_ADD.Label12.Text = objIniFile.GetString("frmSclad_ADD", "Label12", "Цена единицы без НДС:")
        frmSclad_ADD.Label13.Text = objIniFile.GetString("frmSclad_ADD", "Label13", "Переведено в филиал:")

        frmSclad_ADD.add.Text = objIniFile.GetString("frmSclad_ADD", "add", "Добавить")
        frmSclad_ADD.cancel.Text = objIniFile.GetString("frmSclad_ADD", "cancel", "Отмена")
    End Sub

    Public Sub LANG_frmSclad_treb()
        Dim objIniFile As New IniFile(sLANGPATH)

        frmSclad_treb.Label1.Text = objIniFile.GetString("frmSclad_treb", "Label1", "№")
        frmSclad_treb.Label2.Text = objIniFile.GetString("frmSclad_treb", "Label2", "Через кого:")
        frmSclad_treb.Label3.Text = objIniFile.GetString("frmSclad_treb", "Label3", "Затребовал:")
        frmSclad_treb.Label4.Text = objIniFile.GetString("frmSclad_treb", "Label4", "Получил:")
        frmSclad_treb.Label5.Text = objIniFile.GetString("frmSclad_treb", "Label5", "Привязать к устройству:")
        frmSclad_treb.Label6.Text = objIniFile.GetString("frmSclad_treb", "Label6", "Количество:")
        frmSclad_treb.Label7.Text = objIniFile.GetString("frmSclad_treb", "Label7", "Филиал:")
        frmSclad_treb.Label8.Text = objIniFile.GetString("frmSclad_treb", "Label8", "Отдел:")
        frmSclad_treb.Label9.Text = objIniFile.GetString("frmSclad_treb", "Label9", "Отпустил:")
        frmSclad_treb.Label10.Text = objIniFile.GetString("frmSclad_treb", "Label10", "Получил:")

        frmSclad_treb.Text = objIniFile.GetString("frmSclad_treb", "frmSclad_treb", "")
        frmSclad_treb.btnVipiska.Text = objIniFile.GetString("frmSclad_treb", "btnVipiska", "Выписать")
        frmSclad_treb.btnCancel.Text = objIniFile.GetString("frmSclad_treb", "btnCancel", "Отмена")
    End Sub

    Public Sub frmSetup_Lang()
        Dim LNGIniFile As New IniFile(sLANGPATH)

        'frmSetup.lvFindDB.Columns.Add(LNGIniFile.GetString("frmSetup", "lvFindDB1", "id"), 20, HorizontalAlignment.Left)
        'frmSetup.lvFindDB.Columns.Add(LNGIniFile.GetString("frmSetup", "lvFindDB2", "Имя файла"), 300, HorizontalAlignment.Left)
        'frmSetup.lvFindDB.Columns.Add(LNGIniFile.GetString("frmSetup", "lvFindDB3", "Подключен"), 70, HorizontalAlignment.Left)

        'lvPrUsers
        frmSetup.lvPrUsers.Columns.Add(LNGIniFile.GetString("frmSetup", "lvPrUsers1", "id"), 20,
                                       HorizontalAlignment.Left)
        frmSetup.lvPrUsers.Columns.Add(LNGIniFile.GetString("frmSetup", "lvPrUsers2", "Идентификатор"), 100,
                                       HorizontalAlignment.Left)
        frmSetup.lvPrUsers.Columns.Add(LNGIniFile.GetString("frmSetup", "lvPrUsers3", "Имя пользователя"), 200,
                                       HorizontalAlignment.Left)
        frmSetup.lvPrUsers.Columns.Add(LNGIniFile.GetString("frmSetup", "lvPrUsers4", "Уровень"), 70,
                                       HorizontalAlignment.Left)

        ''ResList(frmSetup.lvPrUsers)

        frmSetup.Text = LNGIniFile.GetString("frmSetup", "frmSetup", "Настройки программы БКО")

        frmSetup.SStab1.TabPages("TabPage1").Text = LNGIniFile.GetString("frmSetup", "SStab1_1", "Настройки программы")
        frmSetup.SStab1.TabPages("TabPage3").Text = LNGIniFile.GetString("frmSetup", "SStab1_2",
                                                                         "Организация и системный администратор")
        ' frmSetup.SStab1.TabPages("TabPage4").Text = LNGIniFile.GetString("frmSetup", "SStab1_3", "Найденные базы")
        frmSetup.SStab1.TabPages("TabPage5").Text = LNGIniFile.GetString("frmSetup", "SStab1_4", "Пользователи")

        frmSetup.gbSetup.Text = LNGIniFile.GetString("frmSetup", "gbSetup", "Пользователи")

        frmSetup.chkUpdate.Text = LNGIniFile.GetString("frmSetup", "chkUpdate", "Проверять обновление при старте")
        frmSetup.chkSNPro.Text = LNGIniFile.GetString("frmSetup", "chkSNPro",
                                                      "Проверять серийные номера при внесении нового оборудования")
        frmSetup.chkSheduler.Text = LNGIniFile.GetString("frmSetup", "chkSheduler", "Использовать напоминания")
        frmSetup.chkMenuServices.Text = LNGIniFile.GetString("frmSetup", "chkMenuServices", "Показывать меню служебные")

        frmSetup.chkArhiv2exit.Text = LNGIniFile.GetString("frmSetup", "chkArhiv2exit", "Архивация при выходе")
        frmSetup.lblDefaultModul.Text = LNGIniFile.GetString("frmSetup", "lblDefaultModul", "Модуль по умолчанию")
        frmSetup.lblSortTree.Text = LNGIniFile.GetString("frmSetup", "lblSortTree", "Сортировка в дереве")
        frmSetup.lblOffice.Text = LNGIniFile.GetString("frmSetup", "lblOffice", "Офисный пакет")
        frmSetup.lblOtchet.Text = LNGIniFile.GetString("frmSetup", "lblOtchet", "Каталог с отчетами для загрузки")
        frmSetup.lblDB.Text = LNGIniFile.GetString("frmSetup", "lblDB", "Каталог с базами")
        frmSetup.GroupBox1.Text = LNGIniFile.GetString("frmSetup", "GroupBox1", "Шрифт")
        frmSetup.Label9.Text = LNGIniFile.GetString("frmSetup", "Label9", "База Компьютеров Организации")
        frmSetup.Button2.Text = LNGIniFile.GetString("frmSetup", "Button2", "Выбрать")
        frmSetup.gbTree_o.Text = LNGIniFile.GetString("frmSetup", "gbTree_o", "Отображение в дереве")
        frmSetup.RadioButton1.Text = LNGIniFile.GetString("frmSetup", "RadioButton1", "Имя компьютера")
        frmSetup.RadioButton2.Text = LNGIniFile.GetString("frmSetup", "RadioButton2", "Псевдоним компьютера")
        frmSetup.RadioButton3.Text = LNGIniFile.GetString("frmSetup", "RadioButton3", "Имя компьютера (Псевдоним)")
        frmSetup.GroupBox2.Text = LNGIniFile.GetString("frmSetup", "GroupBox2", "Отделять (При нажатии разделить):")
        frmSetup.RadioButton4.Text = LNGIniFile.GetString("frmSetup", "RadioButton4", "Принтеры")
        frmSetup.RadioButton5.Text = LNGIniFile.GetString("frmSetup", "RadioButton5", "Мониторы")
        frmSetup.RadioButton6.Text = LNGIniFile.GetString("frmSetup", "RadioButton6", "Все перечисленное")
        frmSetup.RadioButton7.Text = LNGIniFile.GetString("frmSetup", "RadioButton7", "ИБП")

        frmSetup.RadioButton8.Text = LNGIniFile.GetString("frmSetup", "RadioButton8", "Клавиатуры+Мыши")
        frmSetup.RadioButton9.Text = LNGIniFile.GetString("frmSetup", "RadioButton9", "Сетевые фильтры")
        frmSetup.Label6.Text = LNGIniFile.GetString("frmSetup", "Label6", "Организация:")
        frmSetup.Label7.Text = LNGIniFile.GetString("frmSetup", "Label7", "Системный администратор:")
        frmSetup.Label8.Text = LNGIniFile.GetString("frmSetup", "Label8", "Заголовок окна программы:")
        frmSetup.Label10.Text = LNGIniFile.GetString("frmSetup", "Label10", "E-mail администратора:")
        frmSetup.Label11.Text = LNGIniFile.GetString("frmSetup", "Label11", "Начальник службы:")
        frmSetup.btnSave.Text = LNGIniFile.GetString("frmSetup", "btnSave", "Сохранить")

        'frmSetup.Button1.Text = LNGIniFile.GetString("frmSetup", "Button1", "Подключить")
        frmSetup.Label1.Text = LNGIniFile.GetString("frmSetup", "Label1", "Имя:")
        frmSetup.Label2.Text = LNGIniFile.GetString("frmSetup", "Label2", "Уровень:")
        frmSetup.Label3.Text = LNGIniFile.GetString("frmSetup", "Label3", "Имя входа:")
        frmSetup.Label4.Text = LNGIniFile.GetString("frmSetup", "Label4", "Пароль:")
        frmSetup.Label5.Text = LNGIniFile.GetString("frmSetup", "Label5", "Повтор пароля:")
        frmSetup.btnEnc.Text = LNGIniFile.GetString("frmSetup", "btnEnc", "Расшифровать")
        frmSetup.btnAdd.Text = LNGIniFile.GetString("frmSetup", "btnAdd", "Добавить")
        frmSetup.btnDel.Text = LNGIniFile.GetString("frmSetup", "btnDel", "Удалить")
        frmSetup.btnCancel.Text = LNGIniFile.GetString("frmSetup", "btnCancel", "Отмена")
        frmSetup.gbUsers.Text = LNGIniFile.GetString("frmSetup", "gbUsers", "Пользователи")
        frmSetup.gbUserLevel.Text = LNGIniFile.GetString("frmSetup", "gbUserLevel", "Разрешения")
        frmSetup.chkSetup.Text = LNGIniFile.GetString("frmSetup", "chkSetup", "Настройки программы")
        frmSetup.chkTehAdd.Text = LNGIniFile.GetString("frmSetup", "chkTehAdd", "Добавление техники")
        frmSetup.chkTehDel.Text = LNGIniFile.GetString("frmSetup", "chkTehDel", "Удаление техники")
        frmSetup.chkNotesAdd.Text = LNGIniFile.GetString("frmSetup", "chkNotesAdd", "Добавление заметок")
        frmSetup.chkNotesDel.Text = LNGIniFile.GetString("frmSetup", "chkNotesDel", "Удаление заметок")
        frmSetup.chkRepAdd.Text = LNGIniFile.GetString("frmSetup", "chkRepAdd", "обавление ремонтов")
        frmSetup.chkRepEd.Text = LNGIniFile.GetString("frmSetup", "chkRepEd", "Редактирование ремонтов")
        frmSetup.chkRepDel.Text = LNGIniFile.GetString("frmSetup", "chkRepDel", "Удаление ремонтов")
        frmSetup.chkCart.Text = LNGIniFile.GetString("frmSetup", "chkCart", "Учёт картриджей")
        frmSetup.chkWarehause.Text = LNGIniFile.GetString("frmSetup", "chkWarehause", "Склад")
        frmSetup.chkPO.Text = LNGIniFile.GetString("frmSetup", "chkPO", "Учёт Программного обеспечения")
        frmSetup.chkPOAdd.Text = LNGIniFile.GetString("frmSetup", "chkPOAdd", "Добавление П.О.")
        frmSetup.chkPODel.Text = LNGIniFile.GetString("frmSetup", "chkPODel", "Удаление П.О.")


        frmSetup.chkDVIG.Text = LNGIniFile.GetString("frmSetup", "chkDVIG", "Движение техники")
        frmSetup.chkREMONT.Text = LNGIniFile.GetString("frmSetup", "chkREMONT", "Ремонты")
        frmSetup.chkPOu.Text = LNGIniFile.GetString("frmSetup", "chkPOu", "Программное обеспечение")
        frmSetup.chkVSUst.Text = LNGIniFile.GetString("frmSetup", "chkVSUst", "В составе устройства")
        frmSetup.chk_no_log.Text = LNGIniFile.GetString("frmSetup", "chk_no_log", "Не вести журнал")
        frmSetup.gbMyBlank.Text = LNGIniFile.GetString("frmSetup", "gbMyBlank", "Мой бланк")


        frmSetup.chkFullScreen.Text = LNGIniFile.GetString("frmSetup", "chkFullScreen", "На весь экран")
        frmSetup.GroupBox3.Text = LNGIniFile.GetString("frmSetup", "GroupBox3", "Размер иконок в дереве")
        frmSetup.chkFonts.Text = LNGIniFile.GetString("frmSetup", "chkFonts", "Использовать изменение шрифта")

        frmSetup.GroupBox4.Text = LNGIniFile.GetString("frmSetup", "GroupBox4", "Дерево:")
        frmSetup.RadioButton10.Text = LNGIniFile.GetString("frmSetup", "RadioButton10", "Обновлять после каждого сохранения")
        frmSetup.RadioButton11.Text = LNGIniFile.GetString("frmSetup", "RadioButton11", "Обновлять по запросу")
        frmSetup.chkRemVisible.Text = LNGIniFile.GetString("frmSetup", "chkRemVisible", "Отмечать технику в ремонте")
        frmSetup.chkNB.Text = LNGIniFile.GetString("frmSetup", "chkNB", "Отмечать технику не на балансе")
        frmSetup.chkSP.Text = LNGIniFile.GetString("frmSetup", "chkSP", "Отмечать списанную технику")



        frmSetup.btnServiceColor.Text = LNGIniFile.GetString("frmSetup", "btnServiceColor", "В ремонте")
        frmSetup.btnNbColor.Text = LNGIniFile.GetString("frmSetup", "btnNbColor", "Не на балансе")
        frmSetup.btnSpisanColor.Text = LNGIniFile.GetString("frmSetup", "btnSpisanColor", "Списан")


        frmSetup.gbSMTP.Text = LNGIniFile.GetString("frmSetup", "gbSMTP", "Настройки SMTP:")
        frmSetup.lblServ.Text = LNGIniFile.GetString("frmSetup", "lblServ", "Сервер:")
        frmSetup.lblPort.Text = LNGIniFile.GetString("frmSetup", "lblPort", "Порт:")
        frmSetup.lblUserName.Text = LNGIniFile.GetString("frmSetup", "lblUserName", "Имя пользователя:")
        frmSetup.lblPassword.Text = LNGIniFile.GetString("frmSetup", "lblPassword", "Пароль:")
        frmSetup.chkTLS.Text = LNGIniFile.GetString("frmSetup", "chkTLS", "Использовать TLS\SSL")
        frmSetup.btnSMTP_Save.Text = LNGIniFile.GetString("frmSetup", "btnSMTP_Save", "Сохранить")
        frmSetup.btnSMTP_Clear.Text = LNGIniFile.GetString("frmSetup", "btnSMTP_Clear", "Очистить")



        '        GroupBox4 = Дерево
        'RadioButton10 = Обновлять после каждого сохранения
        'RadioButton11 = Обновлять по запросу
        'chkRemVisible = Отмечать технику в ремонте
        'chkNB = Отмечать технику не на балансе
        'chkSP = Отмечать списанную технику








    End Sub

    Public Sub frmARHIV_Lang()
        Dim objIniFile As New IniFile(sLANGPATH)

        'frmARHIV.lstArh.Columns.Add("id", 20, HorizontalAlignment.Left)
        'frmARHIV.lstArh.Columns.Add(("Архив"), 300, HorizontalAlignment.Left)

        frmARHIV.Text = objIniFile.GetString("frmARHIV", "frmARHIV", "Архивация")
        frmARHIV.btnZipUp.Text = objIniFile.GetString("frmARHIV", "btnZipUp", "Упаковать")
        frmARHIV.btnUnZip.Text = objIniFile.GetString("frmARHIV", "btnUnZip", "Распаковать")
        frmARHIV.btnUnZip.Visible = False
    End Sub

    Public Sub frmComputers_Lang()
        On Error GoTo err_

        Dim objIniFile As New IniFile(sLANGPATH)


        frmComputers.addRemToolStripMenuItem.Text = objIniFile.GetString("frmComputers", "addRemToolStripMenuItem",
                                                                         "Добавить Заявку")
        frmComputers.CartrAddToolStripMenuItem.Text = objIniFile.GetString("frmComputers", "CartrAddToolStripMenuItem",
                                                                           "Добавить картридж")
        frmComputers.CopyToolStripMenuItem.Text = objIniFile.GetString("frmComputers", "CopyToolStripMenuItem",
                                                                       "Скопировать")
        frmComputers.UpdateToolStripMenuItem.Text = objIniFile.GetString("frmComputers", "UpdateToolStripMenuItem",
                                                                         "Обновить")
        frmComputers.DeleteToolStripMenuItem.Text = objIniFile.GetString("frmComputers", "DeleteToolStripMenuItem",
                                                                         "Удалить")
        frmComputers.ОтделитьПринтерыИМониторыToolStripMenuItem.Text = objIniFile.GetString("frmComputers",
                                                                                            "ОтделитьПринтерыИМониторыToolStripMenuItem",
                                                                                            "Отделить принтеры и мониторы")
        frmComputers.ВернутьПерефериюToolStripMenuItem.Text = objIniFile.GetString("frmComputers",
                                                                                   "ВернутьПерефериюToolStripMenuItem",
                                                                                   "Присоеденить принтеры и мониторы")

        frmComputers.MassRazdelPerf.Text = objIniFile.GetString("frmComputers",
                                                                "ОтделитьПринтерыИМониторыToolStripMenuItem",
                                                                "Отделить принтеры и мониторы")
        frmComputers.MassObedPerf.Text = objIniFile.GetString("frmComputers", "ВернутьПерефериюToolStripMenuItem",
                                                              "Присоеденить принтеры и мониторы")
        'MassObedPerf
        'MassRazdelPerf


        frmComputers.mnuDeltoBranch.Text = objIniFile.GetString("frmComputers", "mnuDeltoBranch", "Удалить из...")
        frmComputers.addFoldertoBranch.Text = objIniFile.GetString("frmComputers", "addFoldertoBranch",
                                                                   " Добавить папку в... (ini)")
        frmComputers.DeleteBranche.Text = objIniFile.GetString("frmComputers", "DeleteBranche", "Удалить")
        frmComputers.RepAddBrToolStripMenuItem.Text = objIniFile.GetString("frmComputers", "RepAddBrToolStripMenuItem",
                                                                           "Добавить заявку")
        frmComputers.SoftInstallToolStripMenuItem.Text = objIniFile.GetString("frmComputers",
                                                                              "SoftInstallToolStripMenuItem",
                                                                              "Установленное П.О.")
        frmComputers.ПаспортКомпьютераToolStripMenuItem.Text = objIniFile.GetString("frmComputers",
                                                                                    "ПаспортКомпьютераToolStripMenuItem",
                                                                                    "Паспорт компьютера")

        frmComputers.lstUsers.Columns.Add(objIniFile.GetString("frmComputers", "lstUsers1", "id"), 20,
                                          HorizontalAlignment.Left)
        frmComputers.lstUsers.Columns.Add(objIniFile.GetString("frmComputers", "lstUsers2", "ФИО"), 300,
                                          HorizontalAlignment.Left)
        frmComputers.lstUsers.Columns.Add(objIniFile.GetString("frmComputers", "lstUsers3", "Имя пользователя"), 100,
                                          HorizontalAlignment.Left)
        frmComputers.lstUsers.Columns.Add(objIniFile.GetString("frmComputers", "lstUsers4", "E-mail"), 100,
                                          HorizontalAlignment.Left)
        frmComputers.lstUsers.Columns.Add(objIniFile.GetString("frmComputers", "lstUsers5", "#ICQ"), 75,
                                          HorizontalAlignment.Left)
        frmComputers.lstUsers.Columns.Add(objIniFile.GetString("frmComputers", "lstUsers6", "Jabber"), 75,
                                          HorizontalAlignment.Left)


        LANG_REPAIR(frmComputers.lvRepairPRN)
        LANG_REPAIR(frmComputers.lvRepair)
        LANG_REPAIR(frmComputers.lvRepairOTH)
        LANG_REPAIR(frmComputers.lvRepairNET)
        LANG_REPAIR(frmComputers.lvRepairBR)

        LANG_NOTES(frmComputers.lvNotes)
        LANG_NOTES(frmComputers.lvNotesPRN)
        LANG_NOTES(frmComputers.lvNotesOTH)
        LANG_NOTES(frmComputers.lvNotesNET)
        LANG_NOTES(frmComputers.lvNotesBR)


        LANG_SOFT(frmComputers.lstSoftware)

        LANG_MOVEMENT(frmComputers.lvMovement)
        LANG_MOVEMENT(frmComputers.lvMovementOTH)
        LANG_MOVEMENT(frmComputers.lvMovementPRN)
        LANG_MOVEMENT(frmComputers.lvMovementNET)


        frmComputers.lvNetPort.Columns.Add(objIniFile.GetString("frmComputers", "lvNetPort1", "id"), 20,
                                           HorizontalAlignment.Left)
        frmComputers.lvNetPort.Columns.Add(objIniFile.GetString("frmComputers", "lvNetPort2", "Номер порта"), 50,
                                           HorizontalAlignment.Left)
        frmComputers.lvNetPort.Columns.Add(objIniFile.GetString("frmComputers", "lvNetPort3", "Направление"), 300,
                                           HorizontalAlignment.Left)
        frmComputers.lvNetPort.Columns.Add(objIniFile.GetString("frmComputers", "lvNetPort4", "MAC"), 100,
                                           HorizontalAlignment.Left)

        frmComputers.lvPRNCartr.Columns.Add(objIniFile.GetString("frmComputers", "lvPRNCartr1", "id"), 20,
                                            HorizontalAlignment.Left)
        frmComputers.lvPRNCartr.Columns.Add(objIniFile.GetString("frmComputers", "lvPRNCartr2", "Модель"), 300,
                                            HorizontalAlignment.Left)
        frmComputers.lvPRNCartr.Columns.Add(objIniFile.GetString("frmComputers", "lvPRNCartr3", "Серийный номер"), 100,
                                            HorizontalAlignment.Left)
        frmComputers.lvPRNCartr.Columns.Add(objIniFile.GetString("frmComputers", "lvPRNCartr4", "Заправок"), 100,
                                            HorizontalAlignment.Left)
        frmComputers.lvPRNCartr.Columns.Add(objIniFile.GetString("frmComputers", "lvPRNCartr5", "Затраты"), 75,
                                            HorizontalAlignment.Left)

        '#########################################
        '12.08.2013
        frmComputers.lvUSTR_PRINT.Columns.Add(objIniFile.GetString("frmComputers", "lvPRNCartr1", "id"), 20, HorizontalAlignment.Left)
        frmComputers.lvUSTR_PRINT.Columns.Add(objIniFile.GetString("frmComputers", "lblNetName", "Имя техники"), 300, HorizontalAlignment.Left)
        frmComputers.lvUSTR_PRINT.Columns.Add(objIniFile.GetString("frmComputers", "lblBranch", "Филиал"), 300, HorizontalAlignment.Left)
        frmComputers.lvUSTR_PRINT.Columns.Add(objIniFile.GetString("frmComputers", "lblDepartment", "Отдел"), 300, HorizontalAlignment.Left)
        frmComputers.lvUSTR_PRINT.Columns.Add(objIniFile.GetString("frmComputers", "lblOffice", "Кабинет"), 300, HorizontalAlignment.Left)
        frmComputers.gbPRN_USTR.Text = objIniFile.GetString("frmComputers", "gbPRN_USTR", "Устройства использующие принтер")
        '12.08.2013
        '#########################################

        frmComputers.Text = objIniFile.GetString("frmComputers", "frmComputers", "Учёт оргтехники")
        frmComputers.gbTree.Text = objIniFile.GetString("frmComputers", "gbTree", "Дерево")
        frmComputers.chkVisibleSTR.Text = objIniFile.GetString("frmComputers", "chkVisibleSTR", "Показать всё")
        ' frmComputers.gbStat.Text = objIniFile.GetString("frmComputers", "gbStat", "")
        ' frmComputers.lblT_All_T.Text = objIniFile.GetString("frmComputers", "lblT_All_T", "")
        ' frmComputers.lblT_O_T.Text = objIniFile.GetString("frmComputers", "lblT_O_T", "")
        frmComputers.sSTAB1.TabPages("TabPage6").Text = objIniFile.GetString("frmComputers", "sSTAB1.TabPages(6)",
                                                                             "Информация")
        frmComputers.sSTAB1.TabPages("TabPage1").Text = objIniFile.GetString("frmComputers", "sSTAB1.TabPages(1)",
                                                                             "Системный блок")
        'frmComputers.sSTAB1.TabPages("TabPage2").Text = objIniFile.GetString("frmComputers", "sSTAB1.TabPages(2)", "")
        frmComputers.sSTAB1.TabPages("TabPage3").Text = objIniFile.GetString("frmComputers", "sSTAB1.TabPages(3)",
                                                                             "Периферия")
        frmComputers.sSTAB1.TabPages("TabPage4").Text = objIniFile.GetString("frmComputers", "sSTAB1.TabPages(4)",
                                                                             "Программное обеспечение")
        frmComputers.sSTAB1.TabPages("TabPage5").Text = objIniFile.GetString("frmComputers", "sSTAB1.TabPages(5)",
                                                                             "Пользователи")
        frmComputers.sSTAB1.TabPages("TabPage7").Text = objIniFile.GetString("frmComputers", "sSTAB1.TabPages(7)",
                                                                             "Сервис")
        frmComputers.sSTAB1.TabPages("TabPage8").Text = objIniFile.GetString("frmComputers", "sSTAB1.TabPages(8)",
                                                                             "Гарантия")

        Call _
            INFO_P_LANG(frmComputers.lblBranch, frmComputers.lblDepartment, frmComputers.lblOffice,
                        frmComputers.lblResponsible, frmComputers.lblPhone, frmComputers.Label84)

        frmComputers.lblNetName.Text = objIniFile.GetString("frmComputers", "lblNetName", "Имя в сети")
        frmComputers.lblPseudonym.Text = objIniFile.GetString("frmComputers", "lblPseudonym", "Псевдоним")
        frmComputers.lblAppointment.Text = objIniFile.GetString("frmComputers", "lblAppointment", "Назначение")

        frmComputers.gbInNumber.Text = objIniFile.GetString("frmComputers", "gbInNumber", "Инвентарные номера")
        frmComputers.Label16.Text = objIniFile.GetString("frmComputers", "Label16", "Инвентарный номер системного блока")
        frmComputers.Label17.Text = objIniFile.GetString("frmComputers", "Label17", "Инвентарный номер монитора")
        frmComputers.Label18.Text = objIniFile.GetString("frmComputers", "Label18", "Инвентарный номер ИБП")
        frmComputers.Label19.Text = objIniFile.GetString("frmComputers", "Label19", "Инвентарный номер принтера")


        frmComputers.gbMovement.Text = objIniFile.GetString("frmComputers", "gbMovement", "Движение")

        frmComputers.gbcpu.Text = objIniFile.GetString("frmComputers", "gbcpu", "Процессор")
        frmComputers.gbMB.Text = objIniFile.GetString("frmComputers", "gbMB", "Материнская плата")
        frmComputers.gbRAM.Text = objIniFile.GetString("frmComputers", "gbRAM", "Память")
        frmComputers.gbHDD.Text = objIniFile.GetString("frmComputers", "gbHDD", "Жесткий диск")
        frmComputers.gbSVGA.Text = objIniFile.GetString("frmComputers", "gbSVGA", "Видео карта")
        frmComputers.gbSOUND.Text = objIniFile.GetString("frmComputers", "gbSOUND", "Звуковая карта")
        frmComputers.gbOptical.Text = objIniFile.GetString("frmComputers", "gbOptical", "Оптические накопители")
        frmComputers.gbNetwork.Text = objIniFile.GetString("frmComputers", "gbNetwork", "Сетевые карты")
        frmComputers.gbFDD.Text = objIniFile.GetString("frmComputers", "gbFDD", "Дисковод")
        frmComputers.gbCreader.Text = objIniFile.GetString("frmComputers", "gbCreader", "КардРидер")
        frmComputers.gbModem.Text = objIniFile.GetString("frmComputers", "gbModem", "Модем")
        frmComputers.gbCase.Text = objIniFile.GetString("frmComputers", "gbCase", "Корпус")
        frmComputers.gbBP.Text = objIniFile.GetString("frmComputers", "gbBP", "Блок питания")
        frmComputers.gbUSB.Text = objIniFile.GetString("frmComputers", "gbUSB", "USB Устройства")
        frmComputers.gbPCI.Text = objIniFile.GetString("frmComputers", "gbPCI", "PCI Устройства")
        frmComputers.gbSBP.Text = objIniFile.GetString("frmComputers", "gbSBP",
                                                       "Модель, серийный номер, производитель системного блока")
        frmComputers.gbMonitor.Text = objIniFile.GetString("frmComputers", "gbMonitor", "Монитор")
        frmComputers.gbKeyboard.Text = objIniFile.GetString("frmComputers", "gbKeyboard", "Клавиатура")
        frmComputers.gbMouse.Text = objIniFile.GetString("frmComputers", "gbMouse", "Мышь")
        frmComputers.gbAsystem.Text = objIniFile.GetString("frmComputers", "gbAsystem", "Акустические системы")
        frmComputers.gbFilter.Text = objIniFile.GetString("frmComputers", "gbFilter", "Сетевой фильтр")
        frmComputers.gbIBP.Text = objIniFile.GetString("frmComputers", "gbIBP", "Источник бесперебойного питания")
        frmComputers.gbPrinters.Text = objIniFile.GetString("frmComputers", "gbPrinters", "Подключенные принтеры")

        frmComputers.lblUsername.Text = objIniFile.GetString("frmComputers", "lblUsername", "Имя пользователя")
        frmComputers.lblSurname.Text = objIniFile.GetString("frmComputers", "lblSurname", "ФИО")
        frmComputers.lblICQ.Text = objIniFile.GetString("frmComputers", "lblICQ", "#ICQ")
        frmComputers.lblEMAIL.Text = objIniFile.GetString("frmComputers", "lblEMAIL", "Email")
        frmComputers.Label36.Text = objIniFile.GetString("frmComputers", "Label36", "Примечание:")
        frmComputers.lbluserPassword.Text = objIniFile.GetString("frmComputers", "lbluserPassword", "Пароль")
        frmComputers.lblJabber.Text = objIniFile.GetString("frmComputers", "lblJabber", "Jabber")
        frmComputers.lblEmailPass.Text = objIniFile.GetString("frmComputers", "lblEmailPass", "Пароль электронной почты")
        frmComputers.ChkPDC.Text = objIniFile.GetString("frmComputers", "ChkPDC", "User AD (Samba, LDAP)")
        frmComputers.cmdUserAdd.Text = objIniFile.GetString("frmComputers", "cmdUserAdd", "Добавить")
        frmComputers.cmdUserDel.Text = objIniFile.GetString("frmComputers", "cmdUserDel", "Удалить")
        frmComputers.cmdUserPassEncript.Text = objIniFile.GetString("frmComputers", "cmdUserPassEncript", "Расшифровать")
        frmComputers.btnUserCancel.Text = objIniFile.GetString("frmComputers", "btnUserCancel", "Отмена")

        Call _
            NOTES_P_LANG(frmComputers.gbNotes, frmComputers.btnNotesAdd, frmComputers.btnNotesDel,
                         frmComputers.btnNotesCancel)

        frmComputers.gbRepair.Text = objIniFile.GetString("frmComputers", "gbRepair", "Ремонты")

        frmComputers.gbGuarantee.Text = objIniFile.GetString("frmComputers", "gbGuarantee", "Гарантия")
        frmComputers.rbKompl.Text = objIniFile.GetString("frmComputers", "rbKompl", "Отдельные комплектующие")
        frmComputers.rbSist.Text = objIniFile.GetString("frmComputers", "rbSist", "Компьютер целиком")

        Call GARANT_P_LANG(frmComputers.gbSeller, frmComputers.Label20, frmComputers.Label22, frmComputers.Label21)

        Call _
            SALE_P_LANG(frmComputers.gbSale, frmComputers.Label43, frmComputers.Label44, frmComputers.Label45,
                        frmComputers.chkPCspis, frmComputers.Label46, frmComputers.Label47, frmComputers.Label48,
                        frmComputers.chkPCNNb)

        'Отделы
        frmComputers.sSTAB5.TabPages("TabPage19").Text = objIniFile.GetString("frmComputers", "sSTAB5.TabPages(19)",
                                                                              "Информация")
        frmComputers.sSTAB5.TabPages("TabPage20").Text = objIniFile.GetString("frmComputers", "sSTAB5.TabPages(20)",
                                                                              "Сервис")
        frmComputers.sSTAB5.TabPages("TabPage21").Text = objIniFile.GetString("frmComputers", "sSTAB5.TabPages(21)",
                                                                              "Санитарный паспорт")

        frmComputers.Label70.Text = objIniFile.GetString("frmComputers", "Label70", "Адрес:")
        frmComputers.Label69.Text = objIniFile.GetString("frmComputers", "Label69", "Ответственный (Начальник):")
        frmComputers.Label68.Text = objIniFile.GetString("frmComputers", "Label68", "Телефон:")
        frmComputers.Label67.Text = objIniFile.GetString("frmComputers", "Label67", "Описание:")

        frmComputers.gbBRRemont.Text = objIniFile.GetString("frmComputers", "gbBRRemont", "Ремонты")
        frmComputers.Label82.Text = objIniFile.GetString("frmComputers", "Label82", "Площадь помещения:")
        frmComputers.Label81.Text = objIniFile.GetString("frmComputers", "Label81", "Высота:")
        frmComputers.Label80.Text = objIniFile.GetString("frmComputers", "Label80",
                                                         "Площадь на одно рабочее место ПЭВМ:")
        frmComputers.Label79.Text = objIniFile.GetString("frmComputers", "Label79", "Объем на одно рабочее место ПЭВМ:")
        frmComputers.Label78.Text = objIniFile.GetString("frmComputers", "Label78",
                                                         "Наличие помещений для ремонта ПЭВМ:")
        frmComputers.Label77.Text = objIniFile.GetString("frmComputers", "Label77",
                                                         "Санитарно-техническое оборудование помещения:")
        frmComputers.Label76.Text = objIniFile.GetString("frmComputers", "Label76", "Вентиляция:")
        frmComputers.Label75.Text = objIniFile.GetString("frmComputers", "Label75", "Водоснабжение:")
        frmComputers.Label74.Text = objIniFile.GetString("frmComputers", "Label74", "Теплоснабжение:")
        frmComputers.Label73.Text = objIniFile.GetString("frmComputers", "Label73", "Канализация:")
        frmComputers.Label72.Text = objIniFile.GetString("frmComputers", "Label72",
                                                         "Внутренняя отделка помещений (стен, потолков, пола):")
        frmComputers.Label71.Text = objIniFile.GetString("frmComputers", "Label71",
                                                         "Оборудование рабочих мест мебелью соответствующей (не соответствующей) требованиям САНПиН:")
        frmComputers.btnOfficeSend.Text = objIniFile.GetString("frmComputers", "btnOfficeSend", "В Офис")

        Call _
            NOTES_P_LANG(frmComputers.gbBRNotes, frmComputers.btnBRNotesAdd, frmComputers.btnBRNotesDel,
                         frmComputers.btnBRNotesCancel)

        'Вкладка принтеры

        frmComputers.sSTAB2.TabPages("TabPage9").Text = objIniFile.GetString("frmComputers", "sSTAB2.TabPages(9)",
                                                                             "Информация")
        frmComputers.sSTAB2.TabPages("TabPage23").Text = objIniFile.GetString("frmComputers", "sSTAB2.TabPages(23)",
                                                                              "Движение")
        frmComputers.sSTAB2.TabPages("TabPage10").Text = objIniFile.GetString("frmComputers", "sSTAB2.TabPages(10)",
                                                                              "Сервис")
        frmComputers.sSTAB2.TabPages("TabPage16").Text = objIniFile.GetString("frmComputers", "sSTAB2.TabPages(16)",
                                                                              "Гарантия")
        frmComputers.gbPRN.Text = objIniFile.GetString("frmComputers", "gbPRN", "Информация")
        frmComputers.lblFormat.Text = objIniFile.GetString("frmComputers", "lblFormat", "Формат:")

        Call _
            INFO_P_LANG(frmComputers.lblPRNFil, frmComputers.lblPRNDepart, frmComputers.lblPRNOffice,
                        frmComputers.lblPRNotv, frmComputers.lblPRNphone, frmComputers.Label85)

        frmComputers.lblPRNConnect.Text = objIniFile.GetString("frmComputers", "lblPRNConnect", "Подключение:")
        frmComputers.lblInNumber.Text = objIniFile.GetString("frmComputers", "lblInNumber", "Инвентарный номер")
        frmComputers.lblTIPCartridg.Text = objIniFile.GetString("frmComputers", "lblTIPCartridg", "Тип картриджа:")
        frmComputers.lblModCartr.Text = objIniFile.GetString("frmComputers", "lblModCartr", "Модель картриджа")
        frmComputers.lblPRNprintPage.Text = objIniFile.GetString("frmComputers", "lblPRNprintPage",
                                                                 "Отпечатано страниц:")
        frmComputers.lblPrnIP.Text = objIniFile.GetString("frmComputers", "lblPrnIP", "IP:")
        frmComputers.lblPrnMAC.Text = objIniFile.GetString("frmComputers", "lblPrnMAC", "MAC:")
        frmComputers.Label83.Text = objIniFile.GetString("frmComputers", "Label83", "В составе устройства:")
        frmComputers.gbPRNCartr.Text = objIniFile.GetString("frmComputers", "gbPRNCartr", "Обнаруженные картриджи")

        Call _
            NOTES_P_LANG(frmComputers.gbPRNNotes, frmComputers.btnPRNNotesAdd, frmComputers.btnPRNNotesDel,
                         frmComputers.btnPRNNotesCancel)

        frmComputers.gbPRNRemont.Text = objIniFile.GetString("frmComputers", "gbRepair", "Ремонты")

        Call GARANT_P_LANG(frmComputers.gbPostPRN, frmComputers.Label4, frmComputers.Label2, frmComputers.Label1)
        Call _
            SALE_P_LANG(frmComputers.gbSalePRN, frmComputers.Label54, frmComputers.Label53, frmComputers.Label52,
                        frmComputers.chkPRNspis, frmComputers.Label51, frmComputers.Label50, frmComputers.Label49,
                        frmComputers.chkPRNNNb)

        'Вкладка сетевое оборудование

        frmComputers.sSTAB4.TabPages("TabPage13").Text = objIniFile.GetString("frmComputers", "sSTAB4.TabPages(13)",
                                                                              "Информация")
        frmComputers.sSTAB4.TabPages("TabPage14").Text = objIniFile.GetString("frmComputers", "sSTAB4.TabPages(14)",
                                                                              "Порты")
        frmComputers.sSTAB4.TabPages("TabPage24").Text = objIniFile.GetString("frmComputers", "sSTAB4.TabPages(24)",
                                                                              "Движение")
        frmComputers.sSTAB4.TabPages("TabPage15").Text = objIniFile.GetString("frmComputers", "sSTAB4.TabPages(15)",
                                                                              "Сервис")
        frmComputers.sSTAB4.TabPages("TabPage17").Text = objIniFile.GetString("frmComputers", "sSTAB4.TabPages(17)",
                                                                              "Гарантия")

        frmComputers.gbNet.Text = objIniFile.GetString("frmComputers", "gbNet",
                                                       "Тип сетевого оборудования, наименование, производитель")
        frmComputers.gbExNet.Text = objIniFile.GetString("frmComputers", "gbExNet", "Расширенная информация")
        frmComputers.Label27.Text = objIniFile.GetString("frmComputers", "Label27", "IP:")
        frmComputers.Label23.Text = objIniFile.GetString("frmComputers", "Label23", "Инвентарный номер:")
        frmComputers.Label13.Text = objIniFile.GetString("frmComputers", "Label13", "Категория кабеля:")
        frmComputers.Label26.Text = objIniFile.GetString("frmComputers", "Label26", "MAC:")
        frmComputers.Label12.Text = objIniFile.GetString("frmComputers", "Label12", "Состояние:")
        frmComputers.Label25.Text = objIniFile.GetString("frmComputers", "Label25", "Количество портов:")
        frmComputers.Label15.Text = objIniFile.GetString("frmComputers", "Label15", "Номер порта:")
        frmComputers.Label11.Text = objIniFile.GetString("frmComputers", "Label11", "Серийный номер:")
        frmComputers.Label24.Text = objIniFile.GetString("frmComputers", "Label24", "Исполнение:")
        frmComputers.Label14.Text = objIniFile.GetString("frmComputers", "Label14", "Тип кабеля:")

        Call _
            INFO_P_LANG(frmComputers.Label32, frmComputers.Label31, frmComputers.Label30, frmComputers.Label29,
                        frmComputers.Label28, frmComputers.Label86)

        frmComputers.gbNetPortMapping.Text = objIniFile.GetString("frmComputers", "gbNetPortMapping", "")
        frmComputers.Label35.Text = objIniFile.GetString("frmComputers", "Label35", "Номер порта:")
        frmComputers.Label34.Text = objIniFile.GetString("frmComputers", "Label34", "Направление:")
        frmComputers.Label33.Text = objIniFile.GetString("frmComputers", "Label33", "MAC:")


        Call _
            NOTES_P_LANG(frmComputers.gbNETNotes, frmComputers.btnNETAdd, frmComputers.btnNETNotesDel,
                         frmComputers.btnNETNotesCancel)
        frmComputers.gbNETRemont.Text = objIniFile.GetString("frmComputers", "gbRepair", "Ремонты")

        Call GARANT_P_LANG(frmComputers.gbPostNET, frmComputers.Label39, frmComputers.Label38, frmComputers.Label37)
        Call _
            SALE_P_LANG(frmComputers.gbSaleNet, frmComputers.Label60, frmComputers.Label59, frmComputers.Label58,
                        frmComputers.chkNETspis, frmComputers.Label57, frmComputers.Label56, frmComputers.Label55,
                        frmComputers.chkNETNNb)


        'Другое оборудование

        frmComputers.sSTAB3.TabPages("TabPage11").Text = objIniFile.GetString("frmComputers", "sSTAB3.TabPages(11)",
                                                                              "Информация")
        frmComputers.sSTAB3.TabPages("TabPage22").Text = objIniFile.GetString("frmComputers", "sSTAB3.TabPages(22)",
                                                                              "Движение")
        frmComputers.sSTAB3.TabPages("TabPage12").Text = objIniFile.GetString("frmComputers", "sSTAB3.TabPages(12)",
                                                                              "Сервис")
        frmComputers.sSTAB3.TabPages("TabPage18").Text = objIniFile.GetString("frmComputers", "sSTAB3.TabPages(18)",
                                                                              "Гарантия")

        frmComputers.gbOTh.Text = objIniFile.GetString("frmComputers", "gbOTh", "Информация")
        frmComputers.Label3.Text = objIniFile.GetString("frmComputers", "Label3", "Краткое описание:")

        Call _
            INFO_P_LANG(frmComputers.Label9, frmComputers.Label8, frmComputers.Label7, frmComputers.Label6,
                        frmComputers.Label5, frmComputers.Label87)

        frmComputers.lblTipOther.Text = objIniFile.GetString("frmComputers", "lblTipOther", "Тип устройства:")
        frmComputers.Label10.Text = objIniFile.GetString("frmComputers", "Label10", "Инвентарный номер")
        frmComputers.lblOTPCL.Text = objIniFile.GetString("frmComputers", "lblOTPCL", "В составе устройства:")
        frmComputers.lblOtIp.Text = objIniFile.GetString("frmComputers", "lblOtIp", "IP:")
        frmComputers.lblOTMac.Text = objIniFile.GetString("frmComputers", "lblOTMac", "MAC:")

        Call _
            NOTES_P_LANG(frmComputers.gbOTHNotes, frmComputers.btnOTHAdd, frmComputers.btnOTHNotesDel,
                         frmComputers.btnOTHNotesCancel)
        frmComputers.gbOTHRemont.Text = objIniFile.GetString("frmComputers", "gbRepair", "Ремонты")

        Call GARANT_P_LANG(frmComputers.gbPostOTH, frmComputers.Label42, frmComputers.Label41, frmComputers.Label40)
        Call _
            SALE_P_LANG(frmComputers.gbSaleOTH, frmComputers.Label66, frmComputers.Label65, frmComputers.Label64,
                        frmComputers.chkOTHspis, frmComputers.Label63, frmComputers.Label62, frmComputers.Label61,
                        frmComputers.chkOTHNNb)

        frmComputers.Label88.Text = objIniFile.GetString("frmComputers", "Label83", "В составе устройства:")
        frmComputers.lblPCLNET.Text = objIniFile.GetString("frmComputers", "Label83", "В составе устройства:")

        frmComputers.Label89.Text = objIniFile.GetString("frmComputers", "Label89", "Номер розетки")

        'EditService
        'DeleteService

        frmComputers.EditService.Text = objIniFile.GetString("frmComputers", "EditService", "Редактировать")
        frmComputers.DeleteService.Text = objIniFile.GetString("frmComputers", "DeleteService", "Удалить")
        frmComputers.MnuSendEmail.Text = objIniFile.GetString("frmComputers", "MnuSendEmail", "Отправить мастеру")
        frmComputers.addServiseWork.Text = objIniFile.GetString("frmserviceDesc", "btnSBTAdd", "Добавить событие")

        frmComputers.ПечатьToolStripMenuItem.Text = objIniFile.GetString("frmserviceDesc", "ToolStripDropDownButton1", "Печать")
        frmComputers.mnu_Z_to_Office.Text = objIniFile.GetString("frmserviceDesc", "btn_Z_to_Office", "Акт-заявка")
        frmComputers.НарядToolStripMenuItem.Text = objIniFile.GetString("frmserviceDesc", "btn_N_to_Office", "Наряд")
        frmComputers.МатериальныйПропускToolStripMenuItem.Text = objIniFile.GetString("frmserviceDesc", "btn_MAT_to_Office", "Материальный пропуск")
        frmComputers.РаспискаToolStripMenuItem.Text = objIniFile.GetString("frmserviceDesc", "Button1", "Расписка")
        frmComputers.БланкToolStripMenuItem.Text = objIniFile.GetString("frmMain", "19", "Бланк")



        Exit Sub

        err_:
        MsgBox(Err.Description)
    End Sub

    Public Sub LANG_NOTES(ByVal lstGroups As ListView)

        Dim objIniFile As New IniFile(sLANGPATH)

        lstGroups.Columns.Add(objIniFile.GetString("frmComputers", "lstNOTES1", "id"), 20, HorizontalAlignment.Left)
        lstGroups.Columns.Add(objIniFile.GetString("frmComputers", "lstNOTES2", "№"), 30, HorizontalAlignment.Left)
        lstGroups.Columns.Add(objIniFile.GetString("frmComputers", "lstNOTES3", "Дата"), 75, HorizontalAlignment.Left)
        lstGroups.Columns.Add(objIniFile.GetString("frmComputers", "lstNOTES4", "Описание"), 300,
                              HorizontalAlignment.Left)
        lstGroups.Columns.Add(objIniFile.GetString("frmComputers", "lstNOTES5", "Мастер"), 100, HorizontalAlignment.Left)

        'ResList(lstGroups)
    End Sub

    Private Sub LANG_MOVEMENT(ByVal lstGroup As ListView)
        Dim objIniFile As New IniFile(sLANGPATH)


        lstGroup.Columns.Add(objIniFile.GetString("frmComputers", "lstMOVEMENT1", "id"), 20, HorizontalAlignment.Left)
        lstGroup.Columns.Add(objIniFile.GetString("frmComputers", "lstMOVEMENT2", "От куда"), 100,
                             HorizontalAlignment.Left)
        lstGroup.Columns.Add(objIniFile.GetString("frmComputers", "lstMOVEMENT3", "Куда"), 100, HorizontalAlignment.Left)
        lstGroup.Columns.Add(objIniFile.GetString("frmComputers", "lstMOVEMENT4", "Причина"), 300,
                             HorizontalAlignment.Left)
        lstGroup.Columns.Add(objIniFile.GetString("frmComputers", "lstMOVEMENT5", "Дата"), 50, HorizontalAlignment.Left)
        lstGroup.Columns.Add(objIniFile.GetString("frmComputers", "lstMOVEMENT6", "Время"), 50, HorizontalAlignment.Left)
    End Sub

    Public Sub LANG_REPAIR(ByVal lstGroups As ListView)
        Dim objIniFile As New IniFile(sLANGPATH)


        lstGroups.Columns.Add(objIniFile.GetString("frmComputers", "lstRemont1", "id"), 20, HorizontalAlignment.Left)
        lstGroups.Columns.Add(objIniFile.GetString("frmComputers", "lstRemont2", "№"), 30, HorizontalAlignment.Left)
        lstGroups.Columns.Add(objIniFile.GetString("frmComputers", "lstRemont3", "Дата"), 90, HorizontalAlignment.Left)
        lstGroups.Columns.Add(objIniFile.GetString("frmComputers", "lstRemont4", "Описание"), 300,
                              HorizontalAlignment.Left)
        lstGroups.Columns.Add(objIniFile.GetString("frmComputers", "lstRemont5", "Уровень"), 100,
                              HorizontalAlignment.Left)
        lstGroups.Columns.Add(objIniFile.GetString("frmComputers", "lstRemont6", "Мастер"), 100,
                              HorizontalAlignment.Left)
        lstGroups.Columns.Add(objIniFile.GetString("frmComputers", "lstRemont7", "Выполнение"), 100,
                              HorizontalAlignment.Left)
        lstGroups.Columns.Add(objIniFile.GetString("frmComputers", "lstRemont8", "Срок выполнения"), 90,
                              HorizontalAlignment.Left)
        lstGroups.Columns.Add(objIniFile.GetString("frmComputers", "lstRemont9", "Пользователь"), 100,
                              HorizontalAlignment.Left)
        lstGroups.Columns.Add(objIniFile.GetString("frmComputers", "lstRemont10", "События"), 30,
                              HorizontalAlignment.Left)

        'ResList(lstGroups)
    End Sub

    Public Sub LANG_SOFT(ByVal lstGroups As ListView)
        Dim objIniFile As New IniFile(sLANGPATH)

        lstGroups.Columns.Add(objIniFile.GetString("frmComputers", "lstSOFT1", "id"), 20, HorizontalAlignment.Left)

        ' lstGroups.Columns.Add(objIniFile.GetString("frmComputers", "lstSOFT9", "Номер ПО"), 20, HorizontalAlignment.Left)

        lstGroups.Columns.Add(objIniFile.GetString("frmComputers", "lstSOFT2", "Программное обеспечение"), 300, HorizontalAlignment.Left)
        lstGroups.Columns.Add(objIniFile.GetString("frmComputers", "lstSOFT10", "Версия"), 100, HorizontalAlignment.Left)
        lstGroups.Columns.Add(objIniFile.GetString("frmComputers", "lstSOFT3", "Лицензионный ключ"), 100, HorizontalAlignment.Left)
        lstGroups.Columns.Add(objIniFile.GetString("frmComputers", "lstSOFT4", "Лицензия"), 100, HorizontalAlignment.Left)
        lstGroups.Columns.Add(objIniFile.GetString("frmComputers", "lstSOFT5", "Дата установки"), 60, HorizontalAlignment.Left)
        lstGroups.Columns.Add(objIniFile.GetString("frmComputers", "lstSOFT6", "Дата окончания"), 60, HorizontalAlignment.Left)
        lstGroups.Columns.Add(objIniFile.GetString("frmComputers", "lstSOFT7", "Производитель"), 200, HorizontalAlignment.Left)
        lstGroups.Columns.Add(objIniFile.GetString("frmComputers", "lstSOFT8", "Тип программного обеспечения"), 100, HorizontalAlignment.Left)

        'ResList(lstGroups)
    End Sub

    Private Sub NOTES_P_LANG(ByVal gb As GroupBox, ByVal badd As ToolStripButton, ByVal bdel As ToolStripButton,
                             ByVal bcancel As ToolStripButton)
        Dim objIniFile As New IniFile(sLANGPATH)

        gb.Text = objIniFile.GetString("frmComputers", "gbNotes", "Заметки")
        badd.Text = objIniFile.GetString("frmComputers", "btnNotesAdd", "Добавить")
        bdel.Text = objIniFile.GetString("frmComputers", "btnNotesDel", "Удалить")
        bcancel.Text = objIniFile.GetString("frmComputers", "btnNotesCancel", "Отмена")
    End Sub

    Private Sub GARANT_P_LANG(ByVal gbS As GroupBox, ByVal lb1 As Label, ByVal lb2 As Label, ByVal lb3 As Label)
        Dim objIniFile As New IniFile(sLANGPATH)

        gbS.Text = objIniFile.GetString("frmComputers", "gbSeller", "Поставщик")
        lb1.Text = objIniFile.GetString("frmComputers", "Label20", "Продавец")
        lb2.Text = objIniFile.GetString("frmComputers", "Label22", "Приобретено:")
        lb3.Text = objIniFile.GetString("frmComputers", "Label21", "Окончание:")
    End Sub

    Private Sub SALE_P_LANG(ByVal gbS As GroupBox, ByVal lb1 As Label, ByVal lb2 As Label, ByVal lb3 As Label,
                            ByVal chkS As CheckBox, ByVal lb4 As Label, ByVal lb5 As Label, ByVal lb6 As Label,
                            ByVal chkN As CheckBox)
        Dim objIniFile As New IniFile(sLANGPATH)

        gbS.Text = objIniFile.GetString("frmComputers", "gbSale", "Данные о приобретении")
        lb1.Text = objIniFile.GetString("frmComputers", "Label43", "Счёт фактура №")
        lb2.Text = objIniFile.GetString("frmComputers", "Label44", "Цена")
        lb3.Text = objIniFile.GetString("frmComputers", "Label45", "Сумма")
        chkS.Text = objIniFile.GetString("frmComputers", "chkPCspis", "Списано")
        lb4.Text = objIniFile.GetString("frmComputers", "Label46", "от")
        lb5.Text = objIniFile.GetString("frmComputers", "Label47", "Заявка")
        lb6.Text = objIniFile.GetString("frmComputers", "Label48", "Дата ввода")
        chkN.Text = objIniFile.GetString("frmComputers", "chkPCNNb", "Не на балансе")
    End Sub

    Private Sub INFO_P_LANG(ByVal lb1 As Label, ByVal lb2 As Label, ByVal lb3 As Label, ByVal lb4 As Label,
                            ByVal lb5 As Label, ByVal lb6 As Label)
        Dim objIniFile As New IniFile(sLANGPATH)

        lb1.Text = objIniFile.GetString("frmComputers", "lblBranch", "Филиал")
        lb2.Text = objIniFile.GetString("frmComputers", "lblDepartment", "Отдел")
        lb3.Text = objIniFile.GetString("frmComputers", "lblOffice", "Кабинет")
        lb4.Text = objIniFile.GetString("frmComputers", "lblResponsible", "Ответственный")
        lb5.Text = objIniFile.GetString("frmComputers", "lblPhone", "Телефон")
        lb6.Text = objIniFile.GetString("frmComputers", "Label84", "№ в базе")
    End Sub

    Public Sub frmLogin_Lang()


        'Dim langIni As New IniFile(LangPath)
        'frmLogin.lblSUBD.Text = langini.GetString("forms", "l1001", "")
        'frmLogin.lblBase.Text = langini.GetString("forms", "l1002", "")
        'frmLogin.lblUser.Text = langini.GetString("forms", "l1003", "")
        'frmLogin.lblPassword.Text = langini.GetString("forms", "l1004", "")
    End Sub

    Public Sub frmSoftware_Lang()

        LANG_SOFT(frmSoftware.lstSoftware)

        Dim LNGIniFile As New IniFile(sLANGPATH)

        frmSoftware.Text = LNGIniFile.GetString("frmSoftware", "frmSoftware", "Учет программного обеспечения")

        frmSoftware.gbTree.Text = LNGIniFile.GetString("frmSoftware", "gbTree", "Дерево")

        frmSoftware.gbSoftware.Text = LNGIniFile.GetString("frmSoftware", "gbSoftware",
                                                           "Установленное программное обеспечение")
        frmSoftware.Label1.Text = LNGIniFile.GetString("frmSoftware", "Label1", "Программное обеспечение")
        frmSoftware.Label2.Text = LNGIniFile.GetString("frmSoftware", "Label2", "Тип лицензии:")
        frmSoftware.Label4.Text = LNGIniFile.GetString("frmSoftware", "Label4", "Лицензионный номер:")
        frmSoftware.Label3.Text = LNGIniFile.GetString("frmSoftware", "Label3", "Тип П.О.:")
        frmSoftware.Label5.Text = LNGIniFile.GetString("frmSoftware", "Label5", "Производитель:")
        frmSoftware.Label7.Text = LNGIniFile.GetString("frmSoftware", "Label7", "Дата приобретения (установки):")
        frmSoftware.Label6.Text = LNGIniFile.GetString("frmSoftware", "Label6", "Дата окончания лицензии:")
        frmSoftware.CheckBox1.Text = LNGIniFile.GetString("frmSoftware", "CheckBox1", "Бессрочно")
        frmSoftware.btnAdd.Text = LNGIniFile.GetString("frmSoftware", "btnAdd", "Добавить")
        frmSoftware.btnDelete.Text = LNGIniFile.GetString("frmSoftware", "btnDelete", "Удалить")
        frmSoftware.btnCancel.Text = LNGIniFile.GetString("frmSoftware", "btnCancel", "Отмена")
        frmSoftware.ToolStripButton1.Text = LNGIniFile.GetString("frmSoftware", "ToolStripButton1", "Обновить ПО")

        frmSoftware.CheckBox2.Text = LNGIniFile.GetString("frmSoftware", "CheckBox2", "Массовое удаление")
        'CheckBox2
    End Sub

    Public Sub LANG_frmSQL()
        Dim LNGIniFile As New IniFile(sLANGPATH)

        frmSQL.Text = LNGIniFile.GetString("frmSQL", "frmSQL", "Запросы SQL")

        frmSQL.btnExecute.Text = LNGIniFile.GetString("frmSQL", "btnExecute", "Выполнить")

        frmSQL.btnClear.Text = LNGIniFile.GetString("frmSQL", "btnClear", "Очистить")
        frmSQL.btnResSend.Text = LNGIniFile.GetString("frmSQL", "btnResSend", "В офис")
        frmSQL.btnSave.Text = LNGIniFile.GetString("frmSQL", "btnSave", "Сохранить")
        frmSQL.btnDelete.Text = LNGIniFile.GetString("frmSQL", "btnDelete", "Удалить")
    End Sub

    Public Sub LANG_frmTreb_Act_treb()
        Dim LNGIniFile As New IniFile(sLANGPATH)

        frmTreb_Act_treb.Text = LNGIniFile.GetString("frmTreb_Act_treb", "frmTreb_Act_treb", "Данные для требования")

        frmTreb_Act_treb.Label1.Text = LNGIniFile.GetString("frmTreb_Act_treb", "Label1", "Номер требования")
        frmTreb_Act_treb.Label2.Text = LNGIniFile.GetString("frmTreb_Act_treb", "Label2", "Тип комплектующей")
        frmTreb_Act_treb.Label3.Text = LNGIniFile.GetString("frmTreb_Act_treb", "Label3", "Модель комплектующей")
        frmTreb_Act_treb.Label4.Text = LNGIniFile.GetString("frmTreb_Act_treb", "Label4", "Кол-во")
        frmTreb_Act_treb.Label5.Text = LNGIniFile.GetString("frmTreb_Act_treb", "Label5", "Цена")
        frmTreb_Act_treb.Label6.Text = LNGIniFile.GetString("frmTreb_Act_treb", "Label6", "Через кого")
        frmTreb_Act_treb.Label7.Text = LNGIniFile.GetString("frmTreb_Act_treb", "Label7", "Затребовал")
        frmTreb_Act_treb.Label8.Text = LNGIniFile.GetString("frmTreb_Act_treb", "Label8", "Дата")


        frmTreb_Act_treb.cmdAdd.Text = LNGIniFile.GetString("frmTreb_Act_treb", "cmdAdd", "Добавить")
        frmTreb_Act_treb.cmdCancel.Text = LNGIniFile.GetString("frmTreb_Act_treb", "cmdCancel", "Отмена")
    End Sub


    Public Sub frmReports_LANG()
        Dim langIni As New IniFile(sLANGPATH)


        frmReports.lvReport2Cl.Columns.Add((langIni.GetString("frmReports", "lvReport2Cl1", "Наименование")), 300,
                                           HorizontalAlignment.Left)
        ' frmReports.lvReport2Cl.Columns.Add(("Производитель"), 300, HorizontalAlignment.Left)
        frmReports.lvReport2Cl.Columns.Add((langIni.GetString("frmReports", "lvReport2Cl2", "Количество")), 100,
                                           HorizontalAlignment.Left)

        'ResList(frmReports.lvReport2Cl)

        'lvRemont
        frmReports.lvRemont.Columns.Add(langIni.GetString("frmReports", "lvRemont1", "id"), 15, HorizontalAlignment.Left)
        frmReports.lvRemont.Columns.Add(langIni.GetString("frmReports", "lvRemont2", "Дата"), 70,
                                        HorizontalAlignment.Left)
        frmReports.lvRemont.Columns.Add(langIni.GetString("frmReports", "lvRemont3", "Описание ремонта"), 300,
                                        HorizontalAlignment.Left)
        frmReports.lvRemont.Columns.Add(langIni.GetString("frmReports", "lvRemont4", "Уровень"), 70,
                                        HorizontalAlignment.Left)
        frmReports.lvRemont.Columns.Add(langIni.GetString("frmReports", "lvRemont5", "Мастер"), 70,
                                        HorizontalAlignment.Left)
        frmReports.lvRemont.Columns.Add(langIni.GetString("frmReports", "lvRemont6", "Имя устройства"), 70,
                                        HorizontalAlignment.Left)
        frmReports.lvRemont.Columns.Add(langIni.GetString("frmReports", "lvRemont7", "Место установки"), 70,
                                        HorizontalAlignment.Left)
        frmReports.lvRemont.Columns.Add(langIni.GetString("frmReports", "lvRemont8", "Выполнение"), 70,
                                        HorizontalAlignment.Left)
        frmReports.lvRemont.Columns.Add(langIni.GetString("frmReports", "lvRemont9", "Пользователь"), 30,
                                        HorizontalAlignment.Left)
        frmReports.lvRemont.Columns.Add(langIni.GetString("frmReports", "lvRemont10", "Затраченное время"), 30,
                                        HorizontalAlignment.Left)
        frmReports.lvRemont.Columns.Add(langIni.GetString("frmReports", "lvRemont11", "SN"), 30,
                                        HorizontalAlignment.Left)
        'ResList(frmReports.lvRemont)

        frmReports.lvGar.Columns.Add(langIni.GetString("frmReports", "lvGar1", "Наименование"), 100,
                                     HorizontalAlignment.Left)
        frmReports.lvGar.Columns.Add(langIni.GetString("frmReports", "lvGar2", "Место установки"), 100,
                                     HorizontalAlignment.Left)
        frmReports.lvGar.Columns.Add(langIni.GetString("frmReports", "lvGar3", "Дата окончания"), 75,
                                     HorizontalAlignment.Left)
        frmReports.lvGar.Columns.Add(langIni.GetString("frmReports", "lvGar4", "Дней до конца"), 70,
                                     HorizontalAlignment.Left)
        frmReports.lvGar.Columns.Add(langIni.GetString("frmReports", "lvGar5", "В сборе..."), 70,
                                     HorizontalAlignment.Left)

        'ResList(frmReports.lvGar)

        frmReports.lvOTV.Columns.Add(langIni.GetString("frmReports", "lvOTV1", "Тип техники"), 250,
                                     HorizontalAlignment.Left)
        frmReports.lvOTV.Columns.Add(langIni.GetString("frmReports", "lvOTV2", "Инвентарный номер"), 100,
                                     HorizontalAlignment.Left)
        frmReports.lvOTV.Columns.Add(langIni.GetString("frmReports", "lvOTV3", "Серийный номер"), 100,
                                     HorizontalAlignment.Left)
        frmReports.lvOTV.Columns.Add(langIni.GetString("frmReports", "lvOTV4", "Место установки"), 200,
                                     HorizontalAlignment.Left)

        'ResList(frmReports.lvOTV)

        frmReports.lvCashe.Columns.Add(langIni.GetString("frmReports", "lvCashe1", "Тип техники"), 350,
                                       HorizontalAlignment.Left)
        frmReports.lvCashe.Columns.Add(langIni.GetString("frmReports", "lvCashe2", "Затраты"), 150,
                                       HorizontalAlignment.Left)
        frmReports.lvCashe.Columns.Add(langIni.GetString("frmReports", "lvCashe3", "Дата приобретения"), 75,
                                       HorizontalAlignment.Left)
        frmReports.lvCashe.Columns.Add(langIni.GetString("frmReports", "lvCashe4", "Место установки"), 200,
                                       HorizontalAlignment.Left)

        'ResList(frmReports.lvCashe)


        frmReports.Text = langIni.GetString("frmReports", "frmReports", "Статистические отчеты")

        frmReports.sSTAB1.TabPages("TabPage1").Text = langIni.GetString("frmReports", "TabPage1",
                                                                        "Комплектующие по отделам")
        frmReports.sSTAB1.TabPages("TabPage2").Text = langIni.GetString("frmReports", "TabPage2", "Комплектующие")
        frmReports.sSTAB1.TabPages("TabPage3").Text = langIni.GetString("frmReports", "TabPage3", "Ремонты")
        frmReports.sSTAB1.TabPages("TabPage4").Text = langIni.GetString("frmReports", "TabPage4", "Гарантия")
        frmReports.sSTAB1.TabPages("TabPage5").Text = langIni.GetString("frmReports", "TabPage5",
                                                                        "Выборка по ответственным")
        frmReports.sSTAB1.TabPages("TabPage6").Text = langIni.GetString("frmReports", "TabPage6", "Затраты")

        frmReports.Label6.Text = langIni.GetString("frmReports", "Label6", "Филиал")
        frmReports.Label7.Text = langIni.GetString("frmReports", "Label7", "Отдел")
        frmReports.Label13.Text = langIni.GetString("frmReports", "Label13", "Кабинет")
        frmReports.optPC.Text = langIni.GetString("frmReports", "optPC", "Только компьютеры")
        frmReports.optOTH.Text = langIni.GetString("frmReports", "optOTH", "Разное")
        frmReports.gbSN.Text = langIni.GetString("frmReports", "gbSN", "Системный блок")
        frmReports.chk_K1.Text = langIni.GetString("frmReports", "chk_K1", "Процессор")
        frmReports.chk_K2.Text = langIni.GetString("frmReports", "chk_K2", "Материнская плата")
        frmReports.chk_K3.Text = langIni.GetString("frmReports", "chk_K3", "Видео карта")
        frmReports.chk_K4.Text = langIni.GetString("frmReports", "chk_K4", "Звуковая карта")
        frmReports.chk_K5.Text = langIni.GetString("frmReports", "chk_K5", "HDD (1)")
        frmReports.chk_K6.Text = langIni.GetString("frmReports", "chk_K6", "HDD (1) SN")
        frmReports.chk_K7.Text = langIni.GetString("frmReports", "chk_K7", "HDD (2)")
        frmReports.chk_K8.Text = langIni.GetString("frmReports", "chk_K8", "HDD (2) SN")
        frmReports.chk_K9.Text = langIni.GetString("frmReports", "chk_K9", "HDD (3)")
        frmReports.chk_K10.Text = langIni.GetString("frmReports", "chk_K10", "HDD (3) SN")
        frmReports.chk_K11.Text = langIni.GetString("frmReports", "chk_K11", "HDD (4)")
        frmReports.chk_K12.Text = langIni.GetString("frmReports", "chk_K12", "HDD (2) SN")
        frmReports.chk_K13.Text = langIni.GetString("frmReports", "chk_K13", "RAM (1)")
        frmReports.chk_K14.Text = langIni.GetString("frmReports", "chk_K14", "RAM (2)")
        frmReports.chk_K15.Text = langIni.GetString("frmReports", "chk_K15", "RAM (3)")
        frmReports.chk_K16.Text = langIni.GetString("frmReports", "chk_K16", "RAM (4)")
        frmReports.chk_K17.Text = langIni.GetString("frmReports", "chk_K17", "Оптический накопитель (1)")
        frmReports.chk_K18.Text = langIni.GetString("frmReports", "chk_K18", "Оптический накопитель (2)")
        frmReports.chk_K19.Text = langIni.GetString("frmReports", "chk_K19", "Оптический накопитель (3)")
        frmReports.chk_K20.Text = langIni.GetString("frmReports", "chk_K20", "Сетевая карта (1)")
        frmReports.chk_K21.Text = langIni.GetString("frmReports", "chk_K21", "Сетевая карта (2)")
        frmReports.chk_K22.Text = langIni.GetString("frmReports", "chk_K22", "IP (1)")
        frmReports.chk_K23.Text = langIni.GetString("frmReports", "chk_K23", "IP (2)")
        frmReports.chk_K24.Text = langIni.GetString("frmReports", "chk_K24", "MAC (1)")
        frmReports.chk_K25.Text = langIni.GetString("frmReports", "chk_K25", "MAC (2)")
        frmReports.chk_K26.Text = langIni.GetString("frmReports", "chk_K26", "Дисковод")
        frmReports.chk_K27.Text = langIni.GetString("frmReports", "chk_K27", "Производитель системного блока")
        frmReports.chk_K28.Text = langIni.GetString("frmReports", "chk_K28", "С.Н. системного блока")

        frmReports.gbPer.Text = langIni.GetString("frmReports", "gbPer", "Периферия")
        frmReports.chk_K29.Text = langIni.GetString("frmReports", "chk_K29", "Монитор")
        frmReports.chk_K30.Text = langIni.GetString("frmReports", "chk_K30", "СН монитора")
        frmReports.chk_K31.Text = langIni.GetString("frmReports", "chk_K31", "Принтер (1)")
        frmReports.chk_K32.Text = langIni.GetString("frmReports", "chk_K32", "Принтер (2)")
        frmReports.chk_K33.Text = langIni.GetString("frmReports", "chk_K33", "Принтер (3)")
        frmReports.chk_K34.Text = langIni.GetString("frmReports", "chk_K34", "Колонки")
        frmReports.chk_K35.Text = langIni.GetString("frmReports", "chk_K35", "Модем")
        frmReports.chk_K36.Text = langIni.GetString("frmReports", "chk_K36", "Клавиатура")
        frmReports.chk_K37.Text = langIni.GetString("frmReports", "chk_K37", "Мышь")
        frmReports.chk_K38.Text = langIni.GetString("frmReports", "chk_K38", "Корпус")
        frmReports.chk_K39.Text = langIni.GetString("frmReports", "chk_K39", "Блок питания")

        frmReports.gbInf.Text = langIni.GetString("frmReports", "gbInf", "Информация")
        frmReports.chk_K40.Text = langIni.GetString("frmReports", "chk_K40", "И.Н. Системного блока")
        frmReports.chk_K41.Text = langIni.GetString("frmReports", "chk_K41", "И.Н. Монитора")
        frmReports.chk_K42.Text = langIni.GetString("frmReports", "chk_K42", "И.Н. ИБП")
        frmReports.chk_K43.Text = langIni.GetString("frmReports", "chk_K43", "Псевдоним техники")
        frmReports.chk_K44.Text = langIni.GetString("frmReports", "chk_K44", "Ответственный")
        frmReports.chk_K45.Text = langIni.GetString("frmReports", "chk_K45", "Место установки")
        frmReports.chk_K46.Text = langIni.GetString("frmReports", "chk_K46", "Установить всё")
        frmReports.chk_K47.Text = langIni.GetString("frmReports", "chk_K47", "И.Н. Принтера")
        frmReports.chk_K48.Text = langIni.GetString("frmReports", "chk_K48", "Стоимость")
        frmReports.chk_K49.Text = langIni.GetString("frmReports", "chk_K49", "Дата ввода")
        frmReports.chk_K50.Text = langIni.GetString("frmReports", "chk_K50", "Поставщик")
        frmReports.chk_K51.Text = langIni.GetString("frmReports", "chk_K51", "Назначение")
        frmReports.chk_K52.Text = langIni.GetString("frmReports", "chk_K52", "Пользователь")

        frmReports.btnUpdate.Text = langIni.GetString("frmReports", "btnUpdate", "Обновить")
        frmReports.btnSendToOffice.Text = langIni.GetString("frmReports", "btnSendToOffice", "В офис")


        frmReports.lblReport2Cl.Text = langIni.GetString("frmReports", "lblReport2Cl", "Количество")

        frmReports.Label1.Text = langIni.GetString("frmReports", "Label1", "Филиал")
        frmReports.Label2.Text = langIni.GetString("frmReports", "Label2", "Отдел")
        frmReports.Button1.Text = langIni.GetString("frmReports", "Button1", "Выход")
        frmReports.Button2.Text = langIni.GetString("frmReports", "Button2", "В офис")
        frmReports.chkReport2Prn.Text = langIni.GetString("frmReports", "chkReport2Prn",
                                                          "Показывать принтеры описанные в конфигурации компьютера")

        frmReports.Label3.Text = langIni.GetString("frmReports", "Label3", "Мастер")
        frmReports.btnRefresh.Text = langIni.GetString("frmReports", "btnRefresh", "Выбрать")
        frmReports.Button3.Text = langIni.GetString("frmReports", "Button3", "В офис")

        frmReports.chkFltr.Text = langIni.GetString("frmReports", "chkFltr", "Фильтр")
        frmReports.Label4.Text = langIni.GetString("frmReports", "Label4", "С")
        frmReports.Label5.Text = langIni.GetString("frmReports", "Label5", "по")
        frmReports.chkUroven.Text = langIni.GetString("frmReports", "chkUroven", "Уровень")
        frmReports.ChckVip.Text = langIni.GetString("frmReports", "ChckVip", "Уровень выполнения")

        frmReports.chkNZ.Text = langIni.GetString("frmReports", "chkNZ", "Не закрытые")
        frmReports.Label8.Text = langIni.GetString("frmReports", "Label8", "Гарантия")
        frmReports.Label9.Text = langIni.GetString("frmReports", "Label9", "Ответственный:")
        frmReports.btnCRZakSendOff.Text = langIni.GetString("frmReports", "btnCRZakSendOff", "В офис")
        frmReports.Label12.Text = langIni.GetString("frmReports", "Label12", "Не закрытые")


        frmReports.Label11.Text = langIni.GetString("frmReports", "Label11", "Филиал")
        frmReports.Label10.Text = langIni.GetString("frmReports", "Label10", "Отдел")
        frmReports.btnCashe.Text = langIni.GetString("frmReports", "btnCashe", "Обновить")
        frmReports.btnCacheOff.Text = langIni.GetString("frmReports", "btnCacheOff", "В офис")


        'frmReports.lvCRT.Columns.Add("Модель", 100, HorizontalAlignment.Left)
        'frmReports.lvCRT.Columns.Add("Установлен\Не установлен", 70, HorizontalAlignment.Left)
        'frmReports.lvCRT.Columns.Add("Заправок", 70, HorizontalAlignment.Left)
        'frmReports.lvCRT.Columns.Add("Востановлен", 70, HorizontalAlignment.Left)
        'frmReports.lvCRT.Columns.Add("Затраты", 70, HorizontalAlignment.Left)

        'ResList(frmReports.lvCRT)


        frmReports.lstvPPR.Columns.Add(langIni.GetString("frmReports", "lstvPPR1", "id"), 1, HorizontalAlignment.Left)
        frmReports.lstvPPR.Columns.Add(langIni.GetString("frmReports", "lstvPPR2", "Тип техники"), 100,
                                       HorizontalAlignment.Left)
        frmReports.lstvPPR.Columns.Add(langIni.GetString("frmReports", "lstvPPR3", "Наименование"), 100,
                                       HorizontalAlignment.Left)
        frmReports.lstvPPR.Columns.Add(langIni.GetString("frmReports", "lstvPPR4", "Место установки"), 100,
                                       HorizontalAlignment.Left)
        frmReports.lstvPPR.Columns.Add(langIni.GetString("frmReports", "lstvPPR5", "Вид ТО"), 100,
                                       HorizontalAlignment.Left)
        frmReports.lstvPPR.Columns.Add(langIni.GetString("frmReports", "lstvPPR6", "Период"), 100,
                                       HorizontalAlignment.Left)
    End Sub

    Public Sub frmAct_treb_LANG()

        Dim objIniFile As New IniFile(sLANGPATH)

        frmAct_Treb.lvACTSP.Columns.Add(objIniFile.GetString("frmAct_Treb", "lvACTSP1", "id"), 20,
                                        HorizontalAlignment.Left)
        frmAct_Treb.lvACTSP.Columns.Add((objIniFile.GetString("frmAct_Treb", "lvACTSP2", "Номер")), 70,
                                        HorizontalAlignment.Left)
        frmAct_Treb.lvACTSP.Columns.Add((objIniFile.GetString("frmAct_Treb", "lvACTSP3", "Дата выписки")), 75,
                                        HorizontalAlignment.Left)
        frmAct_Treb.lvACTSP.Columns.Add((objIniFile.GetString("frmAct_Treb", "lvACTSP4", "Комплектующая тип")), 100,
                                        HorizontalAlignment.Left)
        frmAct_Treb.lvACTSP.Columns.Add((objIniFile.GetString("frmAct_Treb", "lvACTSP5", "Модель")), 100,
                                        HorizontalAlignment.Left)
        frmAct_Treb.lvACTSP.Columns.Add((objIniFile.GetString("frmAct_Treb", "lvACTSP6", "Год производства")), 75,
                                        HorizontalAlignment.Left)
        frmAct_Treb.lvACTSP.Columns.Add((objIniFile.GetString("frmAct_Treb", "lvACTSP7", "Дата постановки")), 75,
                                        HorizontalAlignment.Left)
        frmAct_Treb.lvACTSP.Columns.Add((objIniFile.GetString("frmAct_Treb", "lvACTSP8", "Балансовая стоимость")), 75,
                                        HorizontalAlignment.Left)
        frmAct_Treb.lvACTSP.Columns.Add((objIniFile.GetString("frmAct_Treb", "lvACTSP9", "Дата последнего кап.ремонта")),
                                        75, HorizontalAlignment.Left)


        frmAct_Treb.lvACTVV.Columns.Add(objIniFile.GetString("frmAct_Treb", "lvACTVV1", "id"), 20,
                                        HorizontalAlignment.Left)
        frmAct_Treb.lvACTVV.Columns.Add(objIniFile.GetString("frmAct_Treb", "lvACTVV2", "Номер акта"), 70,
                                        HorizontalAlignment.Left)
        frmAct_Treb.lvACTVV.Columns.Add(objIniFile.GetString("frmAct_Treb", "lvACTVV3", "Модель"), 70,
                                        HorizontalAlignment.Left)
        frmAct_Treb.lvACTVV.Columns.Add(objIniFile.GetString("frmAct_Treb", "lvACTVV4", "Цена"), 75,
                                        HorizontalAlignment.Left)
        frmAct_Treb.lvACTVV.Columns.Add(objIniFile.GetString("frmAct_Treb", "lvACTVV5", "Дата составления"), 100,
                                        HorizontalAlignment.Left)
        frmAct_Treb.lvACTVV.Columns.Add(objIniFile.GetString("frmAct_Treb", "lvACTVV6", "Тип О.С."), 100,
                                        HorizontalAlignment.Left)


        frmAct_Treb.lvTREB.Columns.Add(objIniFile.GetString("frmAct_Treb", "lvTREB1", "id"), 20,
                                       HorizontalAlignment.Left)
        frmAct_Treb.lvTREB.Columns.Add(objIniFile.GetString("frmAct_Treb", "lvTREB2", "Номер требования"), 70,
                                       HorizontalAlignment.Left)
        frmAct_Treb.lvTREB.Columns.Add(objIniFile.GetString("frmAct_Treb", "lvTREB3", "Модель"), 70,
                                       HorizontalAlignment.Left)
        frmAct_Treb.lvTREB.Columns.Add(objIniFile.GetString("frmAct_Treb", "lvTREB4", "Цена"), 75,
                                       HorizontalAlignment.Left)
        frmAct_Treb.lvTREB.Columns.Add(objIniFile.GetString("frmAct_Treb", "lvTREB5", "Дата составления"), 100,
                                       HorizontalAlignment.Left)
        frmAct_Treb.lvTREB.Columns.Add(objIniFile.GetString("frmAct_Treb", "lvTREB6", "Тип"), 100,
                                       HorizontalAlignment.Left)

        frmAct_Treb.Text = objIniFile.GetString("frmAct_Treb", "frmAct_Treb", "Акты-Требования")
        frmAct_Treb.TabControl1.TabPages("TabPage1").Text = objIniFile.GetString("frmAct_Treb", "TabPage1",
                                                                                 "Акт ввода основных средств")
        frmAct_Treb.TabControl1.TabPages("TabPage2").Text = objIniFile.GetString("frmAct_Treb", "TabPage2",
                                                                                 "Акт на списание")
        frmAct_Treb.TabControl1.TabPages("TabPage3").Text = objIniFile.GetString("frmAct_Treb", "TabPage3",
                                                                                 "Требования-накладные")

        frmAct_Treb.btnAVOSadd.Text = objIniFile.GetString("frmAct_Treb", "btnAVOSadd", "Добавить")
        frmAct_Treb.btnAVOSdel.Text = objIniFile.GetString("frmAct_Treb", "btnAVOSdel", "Удалить")
        frmAct_Treb.btnAVOSofsend.Text = objIniFile.GetString("frmAct_Treb", "btnAVOSofsend", "В офис")


        frmAct_Treb.btnTRadd.Text = objIniFile.GetString("frmAct_Treb", "btnTRadd", "Добавить")
        frmAct_Treb.btnTRdel.Text = objIniFile.GetString("frmAct_Treb", "btnTRdel", "Удалить")
        frmAct_Treb.btnTRofSend.Text = objIniFile.GetString("frmAct_Treb", "btnTRofSend", "В офис")

        frmAct_Treb.btnASPadd.Text = objIniFile.GetString("frmAct_Treb", "btnASPadd", "Добавить")
        frmAct_Treb.btnASPdel.Text = objIniFile.GetString("frmAct_Treb", "btnASPdel", "Удалить")
        frmAct_Treb.btnASPofsend.Text = objIniFile.GetString("frmAct_Treb", "btnASPofsend", "В офис")

        'frmAct_Treb
    End Sub

    Public Sub frmSheduler_LANG()
        Dim LNGIniFile As New IniFile(sLANGPATH)

        frmSheduler.Text = LNGIniFile.GetString("frmSheduler", "frmSheduler", "Напоминания")


        frmSheduler.lstShed.Columns.Add(LNGIniFile.GetString("frmSheduler", "lstShed1", "id"), 15,
                                        HorizontalAlignment.Left)
        frmSheduler.lstShed.Columns.Add(LNGIniFile.GetString("frmSheduler", "lstShed2", "Дата"), 70,
                                        HorizontalAlignment.Left)
        frmSheduler.lstShed.Columns.Add(LNGIniFile.GetString("frmSheduler", "lstShed3", "Напоминание"), 300,
                                        HorizontalAlignment.Left)
        frmSheduler.lstShed.Columns.Add(LNGIniFile.GetString("frmSheduler", "lstShed4", "Для пользователя"), 70,
                                        HorizontalAlignment.Left)


        frmSheduler.Label1.Text = LNGIniFile.GetString("frmSheduler", "Label1", "Дата:")
        frmSheduler.Label2.Text = LNGIniFile.GetString("frmSheduler", "Label2", "Для пользователя:")
        frmSheduler.btnAdd.Text = LNGIniFile.GetString("frmSheduler", "btnAdd", "Добавить")
        frmSheduler.btnDel.Text = LNGIniFile.GetString("frmSheduler", "btnDel", "Удалить")
        frmSheduler.btnClear.Text = LNGIniFile.GetString("frmSheduler", "btnClear", "Очистить")
        frmSheduler.btnAll.Text = LNGIniFile.GetString("frmSheduler", "btnAll", "Показать все")
    End Sub

    Public Sub LANG_frm_os3()
        Dim objIniFile As New IniFile(sLANGPATH)


        frm_os3.Label1.Text = objIniFile.GetString("frm_os3", "Label1", "Номер акта")
        frm_os3.Label2.Text = objIniFile.GetString("frm_os3", "Label2", "Дата выписки")
        frm_os3.Label3.Text = objIniFile.GetString("frm_os3", "Label3", "Комплектующая")
        frm_os3.Label4.Text = objIniFile.GetString("frm_os3", "Label4", "Модель")
        frm_os3.Label5.Text = objIniFile.GetString("frm_os3", "Label5", "Год изготовления")
        frm_os3.Label6.Text = objIniFile.GetString("frm_os3", "Label6", "Дата поступления")
        frm_os3.Label7.Text = objIniFile.GetString("frm_os3", "Label7", "Балансовая стоимость")
        frm_os3.Label8.Text = objIniFile.GetString("frm_os3", "Label8", "Количество кап.ремонтов")
        frm_os3.Label9.Text = objIniFile.GetString("frm_os3", "Label9", "Дата последнего кап.ремонта")
        frm_os3.Label10.Text = objIniFile.GetString("frm_os3", "Label10", "Дефекты")
        frm_os3.Button1.Text = objIniFile.GetString("frm_os3", "Button1", "Списать")
        frm_os3.Button2.Text = objIniFile.GetString("frm_os3", "Button2", "Отмена")
        frm_os3.Text = objIniFile.GetString("frm_os3", "frm_os3", "Данные для списания") 'frm_os3
    End Sub

    Public Sub LANG_frm_wmi()

        Dim objIniFile As New IniFile(sLANGPATH)

        frm_wmi.Label1.Text = objIniFile.GetString("frm_wmi", "Label1", "Ip адрес")
        frm_wmi.Label2.Text = objIniFile.GetString("frm_wmi", "Label2", "Имя пользователя")
        frm_wmi.Label3.Text = objIniFile.GetString("frm_wmi", "Label3", "Пароль")
        frm_wmi.Label4.Text = objIniFile.GetString("frm_wmi", "Label4", "Домен")

        frm_wmi.Button1.Text = objIniFile.GetString("frm_wmi", "Button1", "Получить")
        frm_wmi.Button2.Text = objIniFile.GetString("frm_wmi", "Button2", "Отмена")
        frm_wmi.Text = objIniFile.GetString("frm_wmi", "frm_wmi", "Данные для загрузки")
    End Sub

    Public Sub LANG_frmACT_OS_Act_treb()
        Dim objIniFile As New IniFile(sLANGPATH)

        frmACT_OS_Act_treb.Text = objIniFile.GetString("frmACT_OS_Act_treb", "frmACT_OS_Act_treb",
                                                       "Данные для Акта ввода ОС")
        frmACT_OS_Act_treb.Label1.Text = objIniFile.GetString("frmACT_OS_Act_treb", "Label1", "Номер акта")
        frmACT_OS_Act_treb.Label2.Text = objIniFile.GetString("frmACT_OS_Act_treb", "Label2", "Тип основных средств")
        frmACT_OS_Act_treb.Label3.Text = objIniFile.GetString("frmACT_OS_Act_treb", "Label3", "Модель комплектующей")
        frmACT_OS_Act_treb.Label4.Text = objIniFile.GetString("frmACT_OS_Act_treb", "Label4", "Цена")
        frmACT_OS_Act_treb.Label5.Text = objIniFile.GetString("frmACT_OS_Act_treb", "Label5", "Номер приказа")
        frmACT_OS_Act_treb.Label6.Text = objIniFile.GetString("frmACT_OS_Act_treb", "Label6", "Дата приказа")
        frmACT_OS_Act_treb.Label7.Text = objIniFile.GetString("frmACT_OS_Act_treb", "Label7", "Поставщик")
        frmACT_OS_Act_treb.Label8.Text = objIniFile.GetString("frmACT_OS_Act_treb", "Label8", "Год выпуска")
        frmACT_OS_Act_treb.Label9.Text = objIniFile.GetString("frmACT_OS_Act_treb", "Label9", "Дата составления")

        frmACT_OS_Act_treb.akt_add.Text = objIniFile.GetString("frmACT_OS_Act_treb", "akt_add", "Добавить")
        frmACT_OS_Act_treb.akt_cancel.Text = objIniFile.GetString("frmACT_OS_Act_treb", "akt_cancel", "Отмена")
    End Sub

    Public Sub LANG_frmGAR_CPL()
        Dim LNGIniFile As New IniFile(sLANGPATH)

        frmGarCPL.Text = LNGIniFile.GetString("frmGarCPL", "frmGarCPL", "Гарантия")
        frmGarCPL.gbcpu.Text = LNGIniFile.GetString("frmGarCPL", "gbcpu", "Процессор")
        frmGarCPL.gbPost.Text = LNGIniFile.GetString("frmGarCPL", "gbPost", "Поставщик")
        frmGarCPL.Label4.Text = LNGIniFile.GetString("frmGarCPL", "Label4", "Продавец")
        frmGarCPL.Label2.Text = LNGIniFile.GetString("frmGarCPL", "Label2", "Приобретено:")
        frmGarCPL.Label1.Text = LNGIniFile.GetString("frmGarCPL", "Label1", "Окончание:")
        frmGarCPL.btnAdd.Text = LNGIniFile.GetString("frmGarCPL", "btnAdd", "Сохранить")
        frmGarCPL.btnCancel.Text = LNGIniFile.GetString("frmGarCPL", "btnCancel", "Отмена")
    End Sub

    Public Sub LANG_frmLOG()
        Dim LNGIniFile As New IniFile(sLANGPATH)

        frmLOG.Text = LNGIniFile.GetString("frmLOG", "frmLOG", "Журналы программы")
        frmLOG.RBPrLog.Text = LNGIniFile.GetString("frmLOG", "RBPrLog", "Журнал программы")
        frmLOG.rbMove.Text = LNGIniFile.GetString("frmLOG", "rbMove", "Журнал движения")
        frmLOG.rbUpdate.Text = LNGIniFile.GetString("frmLOG", "rbUpdate", "Журнал обновления")
        frmLOG.Label1.Text = LNGIniFile.GetString("frmLOG", "Label1", "с")
        frmLOG.Label2.Text = LNGIniFile.GetString("frmLOG", "Label2", "по")
        frmLOG.btnUpdate.Text = LNGIniFile.GetString("frmLOG", "btnUpdate", "Обновить")
    End Sub

    Public Sub LANG_frmLogin()

        Dim LNGIniFile As New IniFile(sLANGPATH)

        frmLogin.Text = LNGIniFile.GetString("frmLogin", "frmLogin", "Вход в программу")
        frmLogin.lblSUBD.Text = LNGIniFile.GetString("frmLogin", "lblSUBD", "Выберете СУБД")
        frmLogin.gbsql.Text = LNGIniFile.GetString("frmLogin", "gbsql", "Соединение с сервером")
        frmLogin.lblServer.Text = LNGIniFile.GetString("frmLogin", "lblServer", "Сервер:")
        frmLogin.Label1.Text = LNGIniFile.GetString("frmLogin", "Label1", "Порт:")
        frmLogin.Label2.Text = LNGIniFile.GetString("frmLogin", "Label2", "База:")
        frmLogin.Label3.Text = LNGIniFile.GetString("frmLogin", "Label3", "Имя пользователя:")
        frmLogin.Label4.Text = LNGIniFile.GetString("frmLogin", "Label4", "Пароль:")
        frmLogin.Button1.Text = LNGIniFile.GetString("frmLogin", "Button1", "Connect")
        frmLogin.gbData.Text = LNGIniFile.GetString("frmLogin", "gbData", "Вход в программу:")
        frmLogin.lblBase.Text = LNGIniFile.GetString("frmLogin", "lblBase", "База:")
        frmLogin.lblUser.Text = LNGIniFile.GetString("frmLogin", "lblUser", "Имя пользователя:")
        frmLogin.lblPassword.Text = LNGIniFile.GetString("frmLogin", "lblPassword", "Пароль:")
        frmLogin.Label5.Text = LNGIniFile.GetString("frmLogin", "Label5", "Language:")

        frmLogin.btnLogin.Text = LNGIniFile.GetString("frmLogin", "btnLogin", "Вход")
        frmLogin.btnCancel.Text = LNGIniFile.GetString("frmLogin", "btnCancel", "Отмена")
    End Sub

    Public Sub LANG_frmMain()


        Dim LNGIniFile As New IniFile(sLANGPATH)

        'frmMain.Text = LNGIniFile.GetString("frmMain", "frmMain", "")
        frmMain.FileMenu.Text = LNGIniFile.GetString("frmMain", "FileMenu", "Настройки")
        frmMain.NewToolStripMenuItem.Text = LNGIniFile.GetString("frmMain", "NewToolStripMenuItem", "Настройки")
        frmMain.ПроверитьОбновлениеToolStripMenuItem.Text = LNGIniFile.GetString("frmMain", "1", "Проверить обновление")
        frmMain.MailToAuthors.Text = LNGIniFile.GetString("frmMain", "MailToAuthors", "Письмо авторам")
        frmMain.ФорумToolStripMenuItem.Text = LNGIniFile.GetString("frmMain", "2", "Форум")
        frmMain.BugTrackerToolStripMenuItem.Text = LNGIniFile.GetString("frmMain", "BugTrackerToolStripMenuItem",
                                                                        "Сообщить об ошибке")

        'frmMain.BugMaiSend.Text = LNGIniFile.GetString("frmMain", "BugTrackerToolStripMenuItem", "")
        'BugMaiSend


        frmMain.ExitToolStripMenuItem.Text = LNGIniFile.GetString("frmMain", "ExitToolStripMenuItem", "Выход")
        frmMain.УчётToolStripMenuItem.Text = LNGIniFile.GetString("frmMain", "3", "Учёт")
        frmMain.FrmComputersMenuItem.Text = LNGIniFile.GetString("frmMain", "FrmComputersMenuItem", "Учёт оргтехники")
        frmMain.УчётЗаявокремонтовToolStripMenuItem.Text = LNGIniFile.GetString("frmMain", "4", "Учёт заявок (ремонтов)")
        frmMain.УчётКартриджейToolStripMenuItem.Text = LNGIniFile.GetString("frmMain", "5", "Учёт картриджей")
        frmMain.УчётПрограммногоОбеспеченияToolStripMenuItem.Text = LNGIniFile.GetString("frmMain", "6",
                                                                                         "Учёт программного обеспечения")
        frmMain.СкладToolStripMenuItem.Text = LNGIniFile.GetString("frmMain", "7", "Склад")
        frmMain.СправочникиToolStripMenuItem.Text = LNGIniFile.GetString("frmMain", "8", "Справочники")
        frmMain.СправочникиОборудованияToolStripMenuItem.Text = LNGIniFile.GetString("frmMain", "9",
                                                                                     "Справочники оборудования")
        frmMain.ОрганизацияToolStripMenuItem.Text = LNGIniFile.GetString("frmMain", "10", "Организация")
        frmMain.ОтчётыToolStripMenuItem.Text = LNGIniFile.GetString("frmMain", "11", "Отчёты")
        frmMain.БланкиToolStripMenuItem.Text = LNGIniFile.GetString("frmMain", "12", "Бланки")
        frmMain.ПаспортКомпьютераToolStripMenuItem.Text = LNGIniFile.GetString("frmMain", "13", "Паспорт компьютера")
        frmMain.ПаспортМФУToolStripMenuItem.Text = LNGIniFile.GetString("frmMain", "14", "Паспорт МФУ")
        frmMain.ПаспортСетевогоОборудованияToolStripMenuItem.Text = LNGIniFile.GetString("frmMain", "15",
                                                                                         "Паспорт Сетевого оборудования")
        frmMain.ПаспортПринтераToolStripMenuItem.Text = LNGIniFile.GetString("frmMain", "16", "Паспорт Принтера")
        frmMain.ПаспортКопираToolStripMenuItem.Text = LNGIniFile.GetString("frmMain", "17", "Паспорт Копира")
        frmMain.ПаспортСканераToolStripMenuItem.Text = LNGIniFile.GetString("frmMain", "18", "Паспорт сканера")
        frmMain.МойБланкToolStripMenuItem.Text = LNGIniFile.GetString("frmMain", "19", "Мой бланк")
        frmMain.ЖурналыПрограммыToolStripMenuItem.Text = LNGIniFile.GetString("frmMain", "20", "Журналы программы")
        frmMain.АктытребованияToolStripMenuItem.Text = LNGIniFile.GetString("frmMain", "21", "Акты-требования")
        frmMain.ToolsMenu.Text = LNGIniFile.GetString("frmMain", "ToolsMenu", "Сервис")
        frmMain.OptionsToolStripMenuItem.Text = LNGIniFile.GetString("frmMain", "OptionsToolStripMenuItem",
                                                                     "Напоминания")
        frmMain.ОбслуживаниеБДToolStripMenuItem.Text = LNGIniFile.GetString("frmMain", "22", "Обслуживание БД")
        frmMain.CompareDBToolStripMenuItem.Text = LNGIniFile.GetString("frmMain", "CompareDBToolStripMenuItem",
                                                                       "Сжатие БД")
        frmMain.ЗапросыToolStripMenuItem.Text = LNGIniFile.GetString("frmMain", "23", "Запросы")
        frmMain.CleerDBToolStripMenuItem.Text = LNGIniFile.GetString("frmMain", "CleerDBToolStripMenuItem", "Очистка БД")
        frmMain.QRCodeTestingToolStripMenuItem.Text = LNGIniFile.GetString("frmMain", "QRCodeTestingToolStripMenuItem",
                                                                           "QR Code Testing")
        frmMain.ViewMenu.Text = LNGIniFile.GetString("frmMain", "ViewMenu", "Вид")
        frmMain.ToolBarToolStripMenuItem.Text = LNGIniFile.GetString("frmMain", "ToolBarToolStripMenuItem",
                                                                     "Панель инструментов")
        frmMain.StatusBarToolStripMenuItem.Text = LNGIniFile.GetString("frmMain", "StatusBarToolStripMenuItem",
                                                                       "Строка состояния")
        frmMain.LabelPanelToolStripMenuItem.Text = LNGIniFile.GetString("frmMain", "LabelPanelToolStripMenuItem",
                                                                        "Надписи на панели")
        frmMain.WindowsMenu.Text = LNGIniFile.GetString("frmMain", "WindowsMenu", "Окна")
        frmMain.CascadeToolStripMenuItem.Text = LNGIniFile.GetString("frmMain", "CascadeToolStripMenuItem", "Каскадом")
        frmMain.TileVerticalToolStripMenuItem.Text = LNGIniFile.GetString("frmMain", "TileVerticalToolStripMenuItem",
                                                                          "Слева направо")
        frmMain.TileHorizontalToolStripMenuItem.Text = LNGIniFile.GetString("frmMain", "TileHorizontalToolStripMenuItem",
                                                                            "Сверху вниз")
        frmMain.CloseAllToolStripMenuItem.Text = LNGIniFile.GetString("frmMain", "CloseAllToolStripMenuItem",
                                                                      "Закрыть все")
        frmMain.ArrangeIconsToolStripMenuItem.Text = LNGIniFile.GetString("frmMain", "ArrangeIconsToolStripMenuItem",
                                                                          "Упорядочить значки")
        frmMain.HelpMenu.Text = LNGIniFile.GetString("frmMain", "HelpMenu", "О программе")
        frmMain.ToolStripDropDownButton1.Text = LNGIniFile.GetString("frmMain", "ToolStripDropDownButton1", "Новый...")
        frmMain.ЗагрузитьИзEverestiniToolStripMenuItem.Text = LNGIniFile.GetString("frmMain", "24",
                                                                                   "Загрузить из AIDA64 (ini)")
        frmMain.CNTToolStripMenuItem.Text = LNGIniFile.GetString("frmMain", "CNTToolStripMenuItem",
                                                                                  "Контейнер")

        frmMain.ЗагрузитьИзASTRA32ToolStripMenuItem.Text = LNGIniFile.GetString("frmMain", "25", "Загрузить из ASTRA32")
        frmMain.ЗагрузитьЧерезWMIToolStripMenuItem.Text = LNGIniFile.GetString("frmMain", "26", "Загрузить через WMI")
        frmMain.ЗагрузитьИзCSVEverestToolStripMenuItem.Text = LNGIniFile.GetString("frmMain", "27",
                                                                                   "Загрузить из CSV Everest")
        frmMain.HANDINSERTToolStripMenuItem.Text = LNGIniFile.GetString("frmMain", "HANDINSERTToolStripMenuItem",
                                                                        "Ручной ввод")
        frmMain.КопирToolStripMenuItem.Text = LNGIniFile.GetString("frmMain", "28", "Копир")
        frmMain.ПринтерToolStripMenuItem.Text = LNGIniFile.GetString("frmMain", "29", "Принтер")
        frmMain.МФУToolStripMenuItem.Text = LNGIniFile.GetString("frmMain", "30", "МФУ")
        frmMain.СетевоеОборудованиеToolStripMenuItem.Text = LNGIniFile.GetString("frmMain", "31", "Сетевое оборудование")
        frmMain.ТелефонToolStripMenuItem.Text = LNGIniFile.GetString("frmMain", "32", "Телефон")
        frmMain.ФотоаппаратToolStripMenuItem.Text = LNGIniFile.GetString("frmMain", "33", "Фотоаппарат")
        frmMain.ФаксToolStripMenuItem.Text = LNGIniFile.GetString("frmMain", "34", "Факс")
        frmMain.МониторToolStripMenuItem.Text = LNGIniFile.GetString("frmMain", "35", "Монитор")
        frmMain.ДисководZIPToolStripMenuItem.Text = LNGIniFile.GetString("frmMain", "36", "дисковод ZIP")
        frmMain.СканерToolStripMenuItem.Text = LNGIniFile.GetString("frmMain", "37", "Сканер")
        frmMain.ДругоеОборудованиеToolStripMenuItem.Text = LNGIniFile.GetString("frmMain", "38", "Другое оборудование")
        frmMain.NewToolStripButton.Text = LNGIniFile.GetString("frmMain", "NewToolStripButton", "Поиск")
        frmMain.SaveInfTehButton.Text = LNGIniFile.GetString("frmMain", "SaveInfTehButton", "Сохранить")
        frmMain.ArhToolZipbutton.Text = LNGIniFile.GetString("frmMain", "ArhToolZipbutton", "Архивация")
        frmMain.ToolStripButton1.Text = LNGIniFile.GetString("frmMain", "ToolStripButton1", "Отчеты")
        frmMain.lblShed.Text = LNGIniFile.GetString("frmMain", "lblShed", "Напоминания")
        frmMain.lblRem.Text = LNGIniFile.GetString("frmMain", "lblRem", "Заявки")

        frmMain.USBУстройстваToolStripMenuItem.Text = LNGIniFile.GetString("frmMain", "39", "USB Устройства")
        frmMain.АккустическиеСистемыToolStripMenuItem.Text = LNGIniFile.GetString("frmMain", "40",
                                                                                  "Акустические Системы")
        frmMain.БесперебойникиToolStripMenuItem.Text = LNGIniFile.GetString("frmMain", "41", "Бесперебойники")
        frmMain.ПерефирийныеУстройстваToolStripMenuItem.Text = LNGIniFile.GetString("frmMain", "42",
                                                                                    "Периферийные устройства")

        frmMain.ИнвентаризацияToolStripMenuItem.Text = LNGIniFile.GetString("frmMain", "43",
                                                                            "Количество устройств (инвентаризация)")


        frmMain.КлавиатураToolStripMenuItem.Text = LNGIniFile.GetString("frmMain", "44", "Клавиатура")
        frmMain.МышьToolStripMenuItem.Text = LNGIniFile.GetString("frmMain", "45", "Мышь")
        frmMain.СетевыеФильтрыToolStripMenuItem.Text = LNGIniFile.GetString("frmMain", "46", "Сетевой фильтр")
        frmMain.СтатистическиеОтчетыToolStripMenuItem.Text = LNGIniFile.GetString("frmMain", "47",
                                                                                  "Статистические отчеты")

        frmMain.netMagmnu.Text = LNGIniFile.GetString("frmMain", "netMagmnu", "Кабельный журнал")

        frmMain.LBL_STAT_2.Text = LNGIniFile.GetString("frmMain", "LBL_STAT_2", "Техники в:")
    End Sub
End Module
