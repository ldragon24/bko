

Public Class frmDirectory
    Private curr As Integer 'esq
    Private m_SortingColumn As ColumnHeader
    Private dSID As Integer
    Private eDTI As Boolean
    Private sREALNAME As String

    'Public Shared Function GetUser(ByVal UserName As String, ByVal Password As String) As directoryEntry

    'End Function


    Private Sub TreeDirectoryFill()
        Dim objIniFile As New IniFile(sLANGPATH)

        tvDirectory.ImageList = Me.ilsCommands

        Dim nodeRoot As New TreeNode(objIniFile.GetString("frmDirectory", "MSG1", "Справочники"), 0, 0)
        nodeRoot.Tag = "ROOT" & GENID()

        tvDirectory.Nodes.Add(nodeRoot)
        '#############################################################
        'Создаем группу в дереве
        Dim TempNode As New TreeNode(objIniFile.GetString("frmDirectory", "MSG2", "Периферийные устройства"), 1, 1)
        TempNode.Tag = "G|" & GENID()
        nodeRoot.Nodes.Add(TempNode)

        Dim TEHNode1 As New TreeNode(objIniFile.GetString("frmDirectory", "MSG3", "USB Устройства"), 2, 2) _
        '--------------VIP_Graff Обновлен------------------
        TEHNode1.Tag = "C|" & GENID()
        TempNode.Nodes.Add(TEHNode1)

        Dim TEHNode2 As New TreeNode(objIniFile.GetString("frmDirectory", "MSG4", "ZIP"), 3, 3)
        TEHNode2.Tag = "C|" & GENID()
        TempNode.Nodes.Add(TEHNode2)

        Dim TEHNode3 As New TreeNode(objIniFile.GetString("frmDirectory", "MSG5", "Акустические системы"), 4, 4)
        TEHNode3.Tag = "C|" & GENID()
        TempNode.Nodes.Add(TEHNode3)

        Dim TEHNode4 As New TreeNode(objIniFile.GetString("frmDirectory", "MSG6", "Источники БП"), 5, 5) _
        '--------------VIP_Graff Обновлен------------------
        TEHNode4.Tag = "C|" & GENID()
        TempNode.Nodes.Add(TEHNode4)

        Dim TEHNode5 As New TreeNode(objIniFile.GetString("frmDirectory", "MSG7", "Клавиатуры"), 6, 6)
        TEHNode5.Tag = "C|" & GENID()
        TempNode.Nodes.Add(TEHNode5)

        Dim TEHNode6 As New TreeNode(objIniFile.GetString("frmDirectory", "MSG8", "Копиры"), 7, 7)
        TEHNode6.Tag = "C|" & GENID()
        TempNode.Nodes.Add(TEHNode6)

        Dim TEHNode8 As New TreeNode(objIniFile.GetString("frmDirectory", "MSG9", "Мониторы"), 8, 8)
        TEHNode8.Tag = "C|" & GENID()
        TempNode.Nodes.Add(TEHNode8)

        Dim TEHNode9 As New TreeNode(objIniFile.GetString("frmDirectory", "MSG10", "МФУ"), 9, 9)
        TEHNode9.Tag = "C|" & GENID()
        TempNode.Nodes.Add(TEHNode9)

        Dim TEHNode10 As New TreeNode(objIniFile.GetString("frmDirectory", "MSG11", "Мыши"), 10, 10)
        TEHNode10.Tag = "C|" & GENID()
        TempNode.Nodes.Add(TEHNode10)

        Dim TEHNode11 As New TreeNode(objIniFile.GetString("frmDirectory", "MSG12", "Принтеры"), 11, 11)
        TEHNode11.Tag = "C|" & GENID()
        TempNode.Nodes.Add(TEHNode11)

        Dim TEHNode12 As New TreeNode(objIniFile.GetString("frmDirectory", "MSG13", "Сетевые фильтры"), 12, 12) _
        '--------------VIP_Graff Обновлен------------------
        TEHNode12.Tag = "C|" & GENID()
        TempNode.Nodes.Add(TEHNode12)

        Dim TEHNode13 As New TreeNode(objIniFile.GetString("frmDirectory", "MSG14", "Сетевые устройства"), 13, 13) _
        '--------------VIP_Graff Обновлен------------------
        TEHNode13.Tag = "C|" & GENID()
        TempNode.Nodes.Add(TEHNode13)

        Dim TEHNode14 As New TreeNode(objIniFile.GetString("frmDirectory", "MSG15", "Сканер"), 14, 14)
        TEHNode14.Tag = "C|" & GENID()
        TempNode.Nodes.Add(TEHNode14)

        Dim TEHNode15 As New TreeNode(objIniFile.GetString("frmDirectory", "MSG16", "Телефон"), 15, 15) '(4,4)
        TEHNode15.Tag = "C|" & GENID()
        TempNode.Nodes.Add(TEHNode15)

        Dim TEHNode16 As New TreeNode(objIniFile.GetString("frmDirectory", "MSG17", "Факс"), 16, 16) _
        '--------------VIP_Graff Обновлен------------------
        TEHNode16.Tag = "C|" & GENID()
        TempNode.Nodes.Add(TEHNode16)

        Dim TEHNode17 As New TreeNode(objIniFile.GetString("frmDirectory", "MSG18", "Фотоаппарат"), 17, 17)
        TEHNode17.Tag = "C|" & GENID()
        TempNode.Nodes.Add(TEHNode17)
        '#############################################################
        'Создаем группу в дереве
        Dim TempNode2 As New TreeNode(objIniFile.GetString("frmDirectory", "MSG19", "Комплектующие"), 21, 21)
        TempNode2.Tag = "G|" & GENID()
        nodeRoot.Nodes.Add(TempNode2)

        Dim TEHNode18 As New TreeNode(objIniFile.GetString("frmDirectory", "MSG20", "Видео карты"), 19, 19)
        TEHNode18.Tag = "C|" & GENID()
        TempNode2.Nodes.Add(TEHNode18)

        Dim TEHNode19 As New TreeNode(objIniFile.GetString("frmDirectory", "MSG21", "Дисководы"), 20, 20)
        TEHNode19.Tag = "C|" & GENID()
        TempNode2.Nodes.Add(TEHNode19)

        Dim TEHNode20 As New TreeNode(objIniFile.GetString("frmDirectory", "MSG22", "Жесткие диски"), 18, 18)
        TEHNode20.Tag = "C|" & GENID()
        TempNode2.Nodes.Add(TEHNode20)

        Dim TEHNode21 As New TreeNode(objIniFile.GetString("frmDirectory", "MSG23", "Звуковые карты"), 22, 22)
        TEHNode21.Tag = "C|" & GENID()
        TempNode2.Nodes.Add(TEHNode21)

        Dim TEHNode27 As New TreeNode(objIniFile.GetString("frmDirectory", "MSG24", "Кардридер"), 23, 23)
        TEHNode27.Tag = "C|" & GENID()
        TempNode2.Nodes.Add(TEHNode27)

        Dim TEHNode22 As New TreeNode(objIniFile.GetString("frmDirectory", "MSG25", "Материнские платы"), 24, 24)
        TEHNode22.Tag = "C|" & GENID()
        TempNode2.Nodes.Add(TEHNode22)

        Dim TEHNode23 As New TreeNode(objIniFile.GetString("frmDirectory", "MSG26", "Модули памяти"), 25, 25)
        TEHNode23.Tag = "C|" & GENID()
        TempNode2.Nodes.Add(TEHNode23)

        'Добавляем узлы
        Dim TEHNode As New TreeNode(objIniFile.GetString("frmDirectory", "MSG27", "Оптические накопители"), 26, 26)
        TEHNode.Tag = "C|" & GENID()
        TempNode2.Nodes.Add(TEHNode)

        Dim TEHNode24 As New TreeNode(objIniFile.GetString("frmDirectory", "MSG28", "Процессор"), 27, 27)
        TEHNode24.Tag = "C|" & GENID()
        TempNode2.Nodes.Add(TEHNode24)

        Dim TEHNode25 As New TreeNode(objIniFile.GetString("frmDirectory", "MSG29", "Сетевые карты"), 28, 28)
        TEHNode25.Tag = "C|" & GENID()
        TempNode2.Nodes.Add(TEHNode25)

        Dim TEHNode26 As New TreeNode(objIniFile.GetString("frmDirectory", "MSG30", "Устройства PCI"), 29, 29)
        TEHNode26.Tag = "C|" & GENID()
        TempNode2.Nodes.Add(TEHNode26)

        '#############################################################
        Dim TEHNode44 As New TreeNode(objIniFile.GetString("frmDirectory", "MSG31", "Блок питания"), 30, 30)
        TEHNode44.Tag = "C|" & GENID()
        TempNode2.Nodes.Add(TEHNode44)

        Dim TEHNode48 As New TreeNode(objIniFile.GetString("frmDirectory", "MSG33", "Корпус"), 32, 32)
        TEHNode48.Tag = "C|" & GENID()
        TempNode2.Nodes.Add(TEHNode48)

        Dim TEHNode7 As New TreeNode(objIniFile.GetString("frmDirectory", "MSG34", "Модемы"), 33, 33)
        TEHNode7.Tag = "C|" & GENID()
        TempNode2.Nodes.Add(TEHNode7)


        '#############################################################

        'Создаем группу в дереве
        Dim TempNode3 As New TreeNode(objIniFile.GetString("frmDirectory", "MSG35", "Сотрудники"), 34, 34)
        TempNode3.Tag = "G|" & GENID()
        nodeRoot.Nodes.Add(TempNode3)

        Dim TEHNode28 As New TreeNode(objIniFile.GetString("frmDirectory", "MSG36", "Мастер"), 35, 35)
        TEHNode28.Tag = "C|" & GENID()
        TempNode3.Nodes.Add(TEHNode28)

        Dim TEHNode29 As New TreeNode(objIniFile.GetString("frmDirectory", "MSG37", "Ответственный"), 34, 34)
        TEHNode29.Tag = "C|" & GENID()
        TempNode3.Nodes.Add(TEHNode29)

        'Пользователь - экспереминтально
        Dim TEHNode57 As New TreeNode(objIniFile.GetString("frmDirectory", "MSG57", "Пользователь"), 34, 34)
        TEHNode57.Tag = "C|" & GENID()
        TempNode3.Nodes.Add(TEHNode57)


        'Создаем группу в дереве
        Dim TempNode4 As New TreeNode(objIniFile.GetString("frmDirectory", "MSG38", "Структура"), 50, 50)
        TempNode4.Tag = "G|" & GENID()
        nodeRoot.Nodes.Add(TempNode4)

        Dim TEHNode30 As New TreeNode(objIniFile.GetString("frmDirectory", "MSG39", "Филиал"), 36, 36)
        TEHNode30.Tag = "C|" & GENID()
        TempNode4.Nodes.Add(TEHNode30)

        Dim TEHNode31 As New TreeNode(objIniFile.GetString("frmDirectory", "MSG40", "Отдел"), 37, 37)
        TEHNode31.Tag = "C|" & GENID()
        TempNode4.Nodes.Add(TEHNode31)

        Dim TEHNode32 As New TreeNode(objIniFile.GetString("frmDirectory", "MSG41", "Кабинет"), 38, 38)
        TEHNode32.Tag = "C|" & GENID()
        TempNode4.Nodes.Add(TEHNode32)

        '#############################################################
        'Создаем группу в дереве
        Dim TempNode5 As New TreeNode(objIniFile.GetString("frmDirectory", "MSG42", "Заявки"), 39, 39)
        TempNode5.Tag = "G|" & GENID()
        nodeRoot.Nodes.Add(TempNode5)

        Dim TEHNode33 As New TreeNode(objIniFile.GetString("frmDirectory", "MSG43", "Уровень заявки"), 51, 51)
        TEHNode33.Tag = "C|" & GENID()
        TempNode5.Nodes.Add(TEHNode33)

        Dim TEHNode34 As New TreeNode(objIniFile.GetString("frmDirectory", "MSG44", "Уровень выполнения"), 52, 52)
        TEHNode34.Tag = "C|" & GENID()
        TempNode5.Nodes.Add(TEHNode34)

        Dim TEHNode35 As New TreeNode(objIniFile.GetString("frmDirectory", "MSG45", "Тип заявки"), 53, 53)
        TEHNode35.Tag = "C|" & GENID()
        TempNode5.Nodes.Add(TEHNode35)

        '#############################################################
        'Создаем группу в дереве
        Dim TempNode6 As New TreeNode(objIniFile.GetString("frmDirectory", "MSG46", "Разное"), 41, 41)
        TempNode6.Tag = "G|" & GENID()
        nodeRoot.Nodes.Add(TempNode6)

        Dim TEHNode36 As New TreeNode(objIniFile.GetString("frmDirectory", "MSG47", "Поставщики"), 42, 42)
        TEHNode36.Tag = "C|" & GENID()
        TempNode6.Nodes.Add(TEHNode36)

        Dim TEHNode37 As New TreeNode(objIniFile.GetString("frmDirectory", "MSG48", "Производители"), 43, 43)
        TEHNode37.Tag = "C|" & GENID()
        TempNode6.Nodes.Add(TEHNode37)

        Dim TEHNode38 As New TreeNode(objIniFile.GetString("frmDirectory", "MSG49", "Тип компьютера"), 44, 44)
        TEHNode38.Tag = "C|" & GENID()
        TempNode6.Nodes.Add(TEHNode38)

        Dim TEHNode39 As New TreeNode(objIniFile.GetString("frmDirectory", "MSG50", "Модель картриджа"), 45, 45)
        TEHNode39.Tag = "C|" & GENID()
        TempNode6.Nodes.Add(TEHNode39)

        Dim _
            TEHNode40 As _
                New TreeNode(objIniFile.GetString("frmDirectory", "MSG51", "Оборудование (Другое-тип)"), 46, 46)
        TEHNode40.Tag = "C|" & GENID()
        TempNode6.Nodes.Add(TEHNode40)

        Dim _
            TEHNode47 As _
                New TreeNode(objIniFile.GetString("frmDirectory", "MSG52", "Оборудование (Другое-устройства)"), 46, 46)
        TEHNode47.Tag = "C|" & GENID()
        TempNode6.Nodes.Add(TEHNode47)

        Dim TEHNode41 As New TreeNode(objIniFile.GetString("frmDirectory", "MSG53", "Тип лицензии"), 47, 47)
        TEHNode41.Tag = "C|" & GENID()
        TempNode6.Nodes.Add(TEHNode41)

        Dim _
            TEHNode42 As _
                New TreeNode(objIniFile.GetString("frmDirectory", "MSG54", "Тип программного обеспечения"), 48, 48)
        TEHNode42.Tag = "C|" & GENID()
        TempNode6.Nodes.Add(TEHNode42)

        Dim TEHNode43 As New TreeNode(objIniFile.GetString("frmDirectory", "MSG55", "Комплектующие"), 49, 49)
        TEHNode43.Tag = "C|" & GENID()
        TempNode6.Nodes.Add(TEHNode43)

        Dim TEHNode46 As New TreeNode(objIniFile.GetString("frmDirectory", "MSG56", "Программное обеспечение"), 48, 48)
        TEHNode46.Tag = "C|" & GENID()
        TempNode6.Nodes.Add(TEHNode46)

        tvDirectory.SelectedNode = nodeRoot
        Dim tNode As New TreeNode
        tNode = tvDirectory.Nodes(0)
        tNode.Expand()
    End Sub

    Private Sub frmDirectory_Activated(ByVal sender As Object, ByVal e As EventArgs) Handles Me.Activated
        frmMain.SaveInfTehButton.Enabled = False
        frmMain.ToolStripDropDownButton1.Enabled = False
    End Sub

    Private Sub frmDirectory_Load(ByVal sender As Object, ByVal e As EventArgs) Handles Me.Load

        Call Tree_Icons_Feel(ilsCommands, "sDIR", "pic\directory\")

        SendFonts(Me)

        Call frmDirectory_Lang()

        Me.TreeDirectoryFill()
    End Sub

    Private Sub tvDirectory_AfterSelect(ByVal sender As Object, ByVal e As TreeViewEventArgs) _
        Handles tvDirectory.AfterSelect

        curr = 0 'esq
        lvDirectory.Sorting = SortOrder.None
        lvDirectory.ListViewItemSorter = Nothing

        ' Call LOAD_LIST_SPR()
        Me.Invoke(New MethodInvoker(AddressOf LOAD_LIST_SPR))
    End Sub

    Public Sub LOAD_LIST_SPR()
        ToolStripButton1.Visible = False
        ToolStripSeparator5.Visible = False

        On Error GoTo err_
        chkCont.Visible = False

        eDTI = False
        Dim objIniFile As New IniFile(sLANGPATH)


        Dim d() As String
        d = Split(tvDirectory.SelectedNode.Tag, "|")

        If d(0) = "G" Then Exit Sub

        btnDirAdd.Text = objIniFile.GetString("frmDirectory", "btnDirAdd", "Добавить")
        cmbName.Items.Clear()
        cmbName2.Items.Clear()
        cmbName3.Items.Clear()
        cmb1.Items.Clear()
        cmb2.Items.Clear()
        cmb1.Text = ""
        cmb2.Text = ""

        cmbName3.Text = ""
        txtName.Text = ""

        txtMemo.Text = ""
        Label3.Text = objIniFile.GetString("frmDirectory", "Label3", "Производитель")
        Label1.Text = objIniFile.GetString("frmDirectory", "Label2", "Наименование")

        Me.lvDirectory.Columns.Clear()
        Me.lvDirectory.Columns.Add(objIniFile.GetString("frmDirectory", "lvDirectory1", "id"), 20,
                                   HorizontalAlignment.Left)
        Me.lvDirectory.Columns.Add(objIniFile.GetString("frmDirectory", "lvDirectory2", "Наименование"), 300,
                                   HorizontalAlignment.Left)
        Me.lvDirectory.Columns.Add(objIniFile.GetString("frmDirectory", "lvDirectory3", "Производитель"), 300,
                                   HorizontalAlignment.Left)
'esq  добавил Тип ПО
        If tvDirectory.SelectedNode.Text = objIniFile.GetString("frmDirectory", "MSG56", "Программное обеспечение") Then
            Me.lvDirectory.Columns.Add(objIniFile.GetString("frmDirectory", "gb1", "Тип"), 100,
                                       HorizontalAlignment.Left)
        End If

        Me.lvDirectory.Columns.Add(objIniFile.GetString("frmDirectory", "MSG99", "Используется"), 70,
                                   HorizontalAlignment.Left)

        FillComboNET(Me.cmbName3, "PROIZV", "SPR_PROIZV", "", False, True)

        lbl1.Visible = False
        gb1.Visible = False
        gb2.Visible = False
        gbOther.Visible = False
        cmbName2.Visible = False
        Label2.Visible = False
        txtName.Visible = False
        Label3.Visible = True
        txtName.Visible = False
        cmbName3.Visible = True
        chkVisibleSTR.Visible = False
        cmbName.Visible = True
        Label1.Visible = True

        lvDirectory.Items.Clear()

        If tvDirectory.SelectedNode.Text <> objIniFile.GetString("frmDirectory", "MSG41", "Кабинет") Then

            cmbName.Text = ""
            cmbName2.Text = ""

        Else

        End If

        Dim sSQL As String

        Select Case tvDirectory.SelectedNode.Text

            Case objIniFile.GetString("frmDirectory", "MSG57", "Пользователь")
                '#######################################
                'Пользователь экспериментально
                '#######################################

                Label3.Visible = False
                txtName.Visible = False
                cmbName3.Visible = False
                gb1.Visible = False
                gb2.Visible = False

                Me.lvDirectory.Columns.Clear()
                Me.lvDirectory.Columns.Add(objIniFile.GetString("frmDirectory", "lvDirectory1", "id"), 20,
                                           HorizontalAlignment.Left)
                Me.lvDirectory.Columns.Add(objIniFile.GetString("frmDirectory", "lvDirectory2", "Наименование"), 300,
                                           HorizontalAlignment.Left)
                Me.lvDirectory.Columns.Add(objIniFile.GetString("frmDirectory", "lvDirectory4", "ФИО"), 300,
                                           HorizontalAlignment.Left)
                Me.lvDirectory.Columns.Add(objIniFile.GetString("frmDirectory", "MSG99", "Используется"), 70,
                                           HorizontalAlignment.Left)


                If unamDB <> "MS Access" Or unamDB <> "MS Access 2007" Then
                    sSQL = "SELECT id, name, A from SPR_USER ORDER BY NAME"
                Else
                    sSQL =
                        "SELECT SPR_USER.id, SPR_USER.name, SPR_USER.A, (Select count(*) FROM USER_COMP where USER_COMP.USERNAME=SPR_USER.Name) as temp from SPR_USER ORDER BY NAME"
                End If

                cmbName2.Visible = True
                Label2.Visible = True
                cmbName3.Visible = False
                Label3.Visible = False

                Label1.Text = "Имя пользователя"
                Label2.Text = "ФИО"

            Case objIniFile.GetString("frmDirectory", "MSG27", "Оптические накопители")


                If unamDB <> "MS Access" Or unamDB <> "MS Access 2007" Then
                    sSQL =
                        "SELECT SPR_OPTICAL.Id, SPR_OPTICAL.Name, SPR_PROIZV.PROIZV FROM SPR_PROIZV INNER JOIN SPR_OPTICAL ON (SPR_PROIZV.iD = SPR_OPTICAL.Proizv) AND (SPR_PROIZV.iD = SPR_OPTICAL.Proizv) WHERE ((SPR_OPTICAL.Proizv=SPR_PROIZV.iD)) ORDER BY NAME"

                Else
                    sSQL =
                        "SELECT SPR_OPTICAL.Id, SPR_OPTICAL.Name, SPR_PROIZV.PROIZV, (Select count(*) FROM  (SELECT cpus.CD_NAME FROM (SELECT CD_NAME FROM kompy WHERE tiptehn = 'PC' union all SELECT CDRW_NAME FROM kompy WHERE tiptehn = 'PC'  union all SELECT DVD_NAME FROM kompy WHERE tiptehn = 'PC') AS cpus)  where cpus.CD_NAME=SPR_OPTICAL.Name) as temp FROM SPR_PROIZV INNER JOIN SPR_OPTICAL ON (SPR_PROIZV.iD = SPR_OPTICAL.Proizv) AND (SPR_PROIZV.iD = SPR_OPTICAL.Proizv) WHERE ((SPR_OPTICAL.Proizv=SPR_PROIZV.iD)) ORDER BY NAME"
                End If

                lbl1.Visible = True
                gb1.Visible = True
                gb2.Visible = True

                cmbName2.Visible = False
                Label2.Visible = False
                txtName.Visible = False

                cmb1.Items.Clear()
                gb1.Text = objIniFile.GetString("frmDirectory", "MSG98", "Скорость")
                For intj = 1 To 77
                    cmb1.Items.Add(intj & "x")
                Next
                lbl1.Text = objIniFile.GetString("frmDirectory", "MSG57", "Скорость чтения оптического диска (Max)")

                cmb2.Items.Clear()
                gb2.Text = objIniFile.GetString("frmDirectory", "MSG98", "Скорость")
                For intj = 1 To 77
                    cmb2.Items.Add(intj & "x")
                Next
                lbl2.Text = objIniFile.GetString("frmDirectory", "MSG58", "Скорость записи оптического диска (Max)")

            Case objIniFile.GetString("frmDirectory", "MSG3", "USB Устройства")
                lbl1.Visible = True
                gb1.Visible = True
                gb1.Text = objIniFile.GetString("frmDirectory", "MSG59", "Версия USB")

                For intj = 1 To 3
                    cmb1.Items.Add(intj & "x")
                Next
                lbl1.Text = objIniFile.GetString("frmDirectory", "MSG59", "Версия USB")


                If unamDB <> "MS Access" Or unamDB <> "MS Access 2007" Then
                    sSQL =
                        "SELECT SPR_USB.Id, SPR_USB.Name, SPR_PROIZV.PROIZV FROM SPR_PROIZV INNER JOIN SPR_USB ON (SPR_PROIZV.id = SPR_USB.Proizv) AND (SPR_PROIZV.iD = SPR_USB.Proizv) WHERE ((SPR_USB.Proizv=SPR_PROIZV.iD)) ORDER BY NAME"

                Else
                    sSQL =
                        "SELECT SPR_USB.Id, SPR_USB.Name, SPR_PROIZV.PROIZV, (Select count(*) FROM kompy where kompy.USB_NAME=SPR_USB.Name) as temp FROM SPR_PROIZV INNER JOIN SPR_USB ON (SPR_PROIZV.id = SPR_USB.Proizv) AND (SPR_PROIZV.iD = SPR_USB.Proizv) WHERE ((SPR_USB.Proizv=SPR_PROIZV.iD)) ORDER BY NAME"
                End If


            Case objIniFile.GetString("frmDirectory", "MSG4", "ZIP")


                If unamDB <> "MS Access" Or unamDB <> "MS Access 2007" Then
                    sSQL =
                        "SELECT spr_zip.Id, spr_zip.NAME, SPR_PROIZV.PROIZV FROM SPR_PROIZV INNER JOIN spr_zip ON (SPR_PROIZV.id = spr_zip.Proizv) AND (SPR_PROIZV.iD = spr_zip.Proizv) WHERE ((spr_zip.Proizv=SPR_PROIZV.iD)) ORDER BY NAME"

                Else
                    sSQL =
                        "SELECT spr_zip.Id, spr_zip.NAME, SPR_PROIZV.PROIZV, (Select count(*) FROM kompy where kompy.net_name=spr_zip.Name and tiptehn='zip') as temp FROM SPR_PROIZV INNER JOIN spr_zip ON (SPR_PROIZV.id = spr_zip.Proizv) AND (SPR_PROIZV.iD = spr_zip.Proizv) WHERE ((spr_zip.Proizv=SPR_PROIZV.iD)) ORDER BY NAME"
                End If


            Case objIniFile.GetString("frmDirectory", "MSG5", "Акустические системы")
                lbl1.Visible = True
                gb1.Visible = True
                gb1.Text = objIniFile.GetString("frmDirectory", "MSG5", "Акустические системы")
                cmb1.Items.Add("2.0")
                cmb1.Items.Add("2.1")
                cmb1.Items.Add("5.0")
                cmb1.Items.Add("5.1")
                cmb1.Items.Add("6.1")
                cmb1.Items.Add("7.1")
                cmb1.Items.Add("8.1")

                lbl1.Text = objIniFile.GetString("frmDirectory", "MSG5", "Акустические системы")


                If unamDB <> "MS Access" Or unamDB <> "MS Access 2007" Then
                    sSQL =
                        "SELECT SPR_ASISTEM.Id, SPR_ASISTEM.Name, SPR_PROIZV.PROIZV FROM SPR_PROIZV INNER JOIN SPR_ASISTEM ON (SPR_PROIZV.id = SPR_ASISTEM.Proizv) AND (SPR_PROIZV.iD = SPR_ASISTEM.Proizv) WHERE ((SPR_ASISTEM.Proizv=SPR_PROIZV.iD)) ORDER BY NAME"

                Else
                    sSQL =
                        "SELECT SPR_ASISTEM.Id, SPR_ASISTEM.Name, SPR_PROIZV.PROIZV, (Select count(*) FROM kompy where kompy.AS_NAME=SPR_ASISTEM.Name) as temp FROM SPR_PROIZV INNER JOIN SPR_ASISTEM ON (SPR_PROIZV.id = SPR_ASISTEM.Proizv) AND (SPR_PROIZV.iD = SPR_ASISTEM.Proizv) WHERE ((SPR_ASISTEM.Proizv=SPR_PROIZV.iD)) ORDER BY NAME"
                End If


            Case objIniFile.GetString("frmDirectory", "MSG6", "Источники БП")

                lbl1.Visible = True
                gb1.Visible = True
                gb1.Text = objIniFile.GetString("frmDirectory", "MSG60", "Мощность Ватт")
                lbl1.Text = objIniFile.GetString("frmDirectory", "MSG61", "Укажите мощность в Вт.")


                ToolStripButton1.Visible = True
                ToolStripSeparator5.Visible = True
                gb2.Visible = True
                gb2.Text = "SNMP Model"
                FillComboNET(Me.cmb2, "Model", "TBL_DEV_OID", "", False, True)


                If unamDB <> "MS Access" Or unamDB <> "MS Access 2007" Then
                    sSQL =
                        "SELECT SPR_IBP.Id, SPR_IBP.Name, SPR_PROIZV.PROIZV FROM SPR_PROIZV INNER JOIN SPR_IBP ON (SPR_PROIZV.id = SPR_IBP.Proizv) AND (SPR_PROIZV.iD = SPR_IBP.Proizv) WHERE ((SPR_IBP.Proizv=SPR_PROIZV.iD)) ORDER BY NAME"

                Else
                    sSQL =
                        "SELECT SPR_IBP.Id, SPR_IBP.Name, SPR_PROIZV.PROIZV, (Select count(*) FROM kompy where kompy.NET_NAME=SPR_IBP.Name) as temp FROM SPR_PROIZV INNER JOIN SPR_IBP ON (SPR_PROIZV.id = SPR_IBP.Proizv) AND (SPR_PROIZV.iD = SPR_IBP.Proizv) WHERE ((SPR_IBP.Proizv=SPR_PROIZV.iD)) ORDER BY NAME"
                End If

            Case objIniFile.GetString("frmDirectory", "MSG7", "Клавиатуры")


                If unamDB <> "MS Access" Or unamDB <> "MS Access 2007" Then
                    sSQL =
                        "SELECT SPR_KEYBOARD.Id, SPR_KEYBOARD.Name, SPR_PROIZV.PROIZV FROM SPR_PROIZV INNER JOIN SPR_KEYBOARD ON (SPR_PROIZV.id = SPR_KEYBOARD.Proizv) AND (SPR_PROIZV.iD = SPR_KEYBOARD.Proizv) WHERE ((SPR_KEYBOARD.Proizv=SPR_PROIZV.iD)) ORDER BY NAME"

                Else
                    sSQL =
                        "SELECT SPR_KEYBOARD.Id, SPR_KEYBOARD.Name, SPR_PROIZV.PROIZV, (Select count(*) FROM kompy where kompy.KEYBOARD_NAME=SPR_KEYBOARD.Name) as temp FROM SPR_PROIZV INNER JOIN SPR_KEYBOARD ON (SPR_PROIZV.id = SPR_KEYBOARD.Proizv) AND (SPR_PROIZV.iD = SPR_KEYBOARD.Proizv) WHERE ((SPR_KEYBOARD.Proizv=SPR_PROIZV.iD)) ORDER BY NAME"
                End If


            Case objIniFile.GetString("frmDirectory", "MSG8", "Копиры")
                lbl1.Visible = True
                gb1.Visible = True
                cmb1.Items.Clear()
                gb1.Text = objIniFile.GetString("frmDirectory", "MSG62", "Формат")
                For intj = 1 To 5
                    cmb1.Items.Add("A" & intj)
                Next
                lbl1.Text = objIniFile.GetString("frmDirectory", "MSG63", "Формат бумаги")

                lbl2.Visible = True
                gb2.Visible = True
                cmb2.Items.Clear()
                gb2.Text = objIniFile.GetString("frmDirectory", "MSG64", "Модель картриджа")

                FillComboNET(Me.cmb2, "name", "spr_cart", "", False, True)

                lbl2.Text = objIniFile.GetString("frmDirectory", "MSG64", "Модель картриджа")

                If unamDB <> "MS Access" Or unamDB <> "MS Access 2007" Then

                    sSQL =
                        "SELECT SPR_KOPIR.Id, SPR_KOPIR.Name, SPR_PROIZV.PROIZV FROM SPR_PROIZV INNER JOIN SPR_KOPIR ON (SPR_PROIZV.iD = SPR_KOPIR.Proizv) AND (SPR_PROIZV.iD = SPR_KOPIR.Proizv) WHERE ((SPR_KOPIR.Proizv=SPR_PROIZV.iD)) ORDER BY NAME"
                Else

                    sSQL =
                        "SELECT SPR_KOPIR.Id, SPR_KOPIR.Name, SPR_PROIZV.PROIZV, (Select count(*) FROM kompy where kompy.net_name=SPR_KOPIR.Name and tiptehn='KOpir') as temp FROM SPR_PROIZV INNER JOIN SPR_KOPIR ON (SPR_PROIZV.iD = SPR_KOPIR.Proizv) AND (SPR_PROIZV.iD = SPR_KOPIR.Proizv) WHERE ((SPR_KOPIR.Proizv=SPR_PROIZV.iD)) ORDER BY NAME"
                End If


            Case objIniFile.GetString("frmDirectory", "MSG34", "Модемы")
                lbl1.Visible = True
                gb1.Visible = True
                gb1.Text = objIniFile.GetString("frmDirectory", "MSG65", "Скорость BOD")
                lbl1.Text = objIniFile.GetString("frmDirectory", "MSG65", "Скорость BOD")

                If unamDB <> "MS Access" Or unamDB <> "MS Access 2007" Then
                    sSQL =
                        "SELECT SPR_MODEM.Id, SPR_MODEM.Name, SPR_PROIZV.PROIZV FROM SPR_PROIZV INNER JOIN SPR_MODEM ON (SPR_PROIZV.id = SPR_MODEM.Proizv) AND (SPR_PROIZV.iD = SPR_MODEM.Proizv) WHERE ((SPR_MODEM.Proizv=SPR_PROIZV.iD)) ORDER BY NAME"

                Else
                    sSQL =
                        "SELECT SPR_MODEM.Id, SPR_MODEM.Name, SPR_PROIZV.PROIZV, (Select count(*) FROM kompy where kompy.MODEM_NAME=SPR_MODEM.Name) as temp FROM SPR_PROIZV INNER JOIN SPR_MODEM ON (SPR_PROIZV.id = SPR_MODEM.Proizv) AND (SPR_PROIZV.iD = SPR_MODEM.Proizv) WHERE ((SPR_MODEM.Proizv=SPR_PROIZV.iD)) ORDER BY NAME"
                End If


            Case objIniFile.GetString("frmDirectory", "MSG9", "Мониторы")

                lbl1.Visible = True
                gb1.Visible = True
                gb1.Text = objIniFile.GetString("frmDirectory", "gb1", "Тип")
                lbl1.Text = objIniFile.GetString("frmDirectory", "MSG66", "Укажите тип")
                cmb1.Items.Add("14 LCD")
                cmb1.Items.Add("15 LCD")
                cmb1.Items.Add("17 LCD")
                cmb1.Items.Add("19 LCD")
                cmb1.Items.Add("20 LCD")
                cmb1.Items.Add("21 LCD")
                cmb1.Items.Add("23 LCD")
                cmb1.Items.Add("25 LCD")
                cmb1.Items.Add("27 LCD")
                cmb1.Items.Add("14 CRT")
                cmb1.Items.Add("15 CRT")
                cmb1.Items.Add("17 CRT")
                cmb1.Items.Add("19 CRT")
                cmb1.Items.Add("20 CRT")
                cmb1.Items.Add("21 CRT")

                If unamDB <> "MS Access" Or unamDB <> "MS Access 2007" Then
                    sSQL =
                        "SELECT SPR_MONITOR.Id, SPR_MONITOR.Name, SPR_PROIZV.PROIZV FROM SPR_PROIZV INNER JOIN SPR_MONITOR ON (SPR_PROIZV.id = SPR_MONITOR.Proizv) AND (SPR_PROIZV.iD = SPR_MONITOR.Proizv) WHERE ((SPR_MONITOR.Proizv=SPR_PROIZV.iD)) ORDER BY NAME"

                Else
                    sSQL =
                        "SELECT SPR_MONITOR.Id, SPR_MONITOR.Name, SPR_PROIZV.PROIZV,(Select count(*) FROM  (SELECT cpus.MONITOR_NAME FROM (SELECT MONITOR_NAME FROM kompy union all SELECT MONITOR_NAME2 FROM kompy) AS cpus) where cpus.MONITOR_NAME=SPR_MONITOR.Name) as temp FROM SPR_PROIZV INNER JOIN SPR_MONITOR ON (SPR_PROIZV.id = SPR_MONITOR.Proizv) AND (SPR_PROIZV.iD = SPR_MONITOR.Proizv) WHERE ((SPR_MONITOR.Proizv=SPR_PROIZV.iD)) ORDER BY NAME"
                End If


            Case objIniFile.GetString("frmDirectory", "MSG10", "МФУ")
                lbl1.Visible = True
                gb1.Visible = True
                cmb1.Items.Clear()
                gb1.Text = objIniFile.GetString("frmDirectory", "MSG62", "Формат")
                For intj = 1 To 5
                    cmb1.Items.Add("A" & intj)
                Next
                lbl1.Text = objIniFile.GetString("frmDirectory", "MSG63", "Формат бумаги")

                lbl2.Visible = True
                gb2.Visible = True
                cmb2.Items.Clear()
                gb2.Text = objIniFile.GetString("frmDirectory", "MSG64", "Модель картриджа")

                FillComboNET(Me.cmb2, "name", "spr_cart", "", False, True)

                lbl2.Text = objIniFile.GetString("frmDirectory", "MSG64", "Модель картриджа")


                If unamDB <> "MS Access" Or unamDB <> "MS Access 2007" Then

                    sSQL =
                        "SELECT SPR_MFU.Id, SPR_MFU.Name, SPR_PROIZV.PROIZV FROM SPR_PROIZV INNER JOIN SPR_MFU ON (SPR_PROIZV.iD = SPR_MFU.Proizv) AND (SPR_PROIZV.iD = SPR_MFU.Proizv) WHERE ((SPR_MFU.Proizv=SPR_PROIZV.iD)) ORDER BY NAME"

                Else
                    sSQL =
                        "SELECT SPR_MFU.Id, SPR_MFU.Name, SPR_PROIZV.PROIZV, (Select count(*) FROM kompy where kompy.net_name=SPR_MFU.Name and tiptehn='MFU') as temp FROM SPR_PROIZV INNER JOIN SPR_MFU ON (SPR_PROIZV.iD = SPR_MFU.Proizv) AND (SPR_PROIZV.iD = SPR_MFU.Proizv) WHERE ((SPR_MFU.Proizv=SPR_PROIZV.iD)) ORDER BY NAME"
                End If


            Case objIniFile.GetString("frmDirectory", "MSG11", "Мыши")


                If unamDB <> "MS Access" Or unamDB <> "MS Access 2007" Then

                    sSQL =
                        "SELECT SPR_MOUSE.Id, SPR_MOUSE.Name, SPR_PROIZV.PROIZV FROM SPR_PROIZV INNER JOIN SPR_MOUSE ON (SPR_PROIZV.id = SPR_MOUSE.Proizv) AND (SPR_PROIZV.iD = SPR_MOUSE.Proizv) WHERE ((SPR_MOUSE.Proizv=SPR_PROIZV.iD)) ORDER BY NAME"

                Else
                    sSQL =
                        "SELECT SPR_MOUSE.Id, SPR_MOUSE.Name, SPR_PROIZV.PROIZV, (Select count(*) FROM kompy where kompy.MOUSE_NAME=SPR_MOUSE.Name) as temp FROM SPR_PROIZV INNER JOIN SPR_MOUSE ON (SPR_PROIZV.id = SPR_MOUSE.Proizv) AND (SPR_PROIZV.iD = SPR_MOUSE.Proizv) WHERE ((SPR_MOUSE.Proizv=SPR_PROIZV.iD)) ORDER BY NAME"
                End If


            Case objIniFile.GetString("frmDirectory", "MSG12", "Принтеры")
                lbl1.Visible = True
                gb1.Visible = True
                cmb1.Items.Clear()
                gb1.Text = objIniFile.GetString("frmDirectory", "MSG62", "Формат")
                For intj = 1 To 5
                    cmb1.Items.Add("A" & intj)
                Next
                lbl1.Text = objIniFile.GetString("frmDirectory", "MSG63", "Формат бумаги")

                lbl2.Visible = True
                gb2.Visible = True
                cmb2.Items.Clear()
                gb2.Text = objIniFile.GetString("frmDirectory", "MSG64", "Модель картриджа")

                FillComboNET(Me.cmb2, "name", "spr_cart", "", False, True)

                lbl2.Text = objIniFile.GetString("frmDirectory", "MSG64", "Модель картриджа")


                If unamDB <> "MS Access" Or unamDB <> "MS Access 2007" Then

                    sSQL =
                        "SELECT SPR_PRINTER.Id, SPR_PRINTER.Name, SPR_PROIZV.PROIZV FROM SPR_PROIZV INNER JOIN SPR_PRINTER ON (SPR_PROIZV.id = SPR_PRINTER.Proizv) AND (SPR_PROIZV.iD = SPR_PRINTER.Proizv) WHERE ((SPR_PRINTER.Proizv=SPR_PROIZV.iD)) ORDER BY NAME"

                Else
                    sSQL =
                        "SELECT SPR_PRINTER.Id, SPR_PRINTER.Name, SPR_PROIZV.PROIZV, (Select count(*) FROM (SELECT cpus.PRINTER_NAME_1 FROM (SELECT PRINTER_NAME_1 FROM kompy WHERE tiptehn = 'PC' union all SELECT PRINTER_NAME_2 FROM kompy WHERE tiptehn = 'PC' union all SELECT PRINTER_NAME_3 FROM kompy WHERE tiptehn = 'PC' union all SELECT  PRINTER_NAME_4 FROM kompy WHERE tiptehn = 'PC') AS cpus) where cpus.PRINTER_NAME_1=SPR_PRINTER.Name) as temp FROM SPR_PROIZV INNER JOIN SPR_PRINTER ON (SPR_PROIZV.id = SPR_PRINTER.Proizv) AND (SPR_PROIZV.iD = SPR_PRINTER.Proizv) WHERE ((SPR_PRINTER.Proizv=SPR_PROIZV.iD)) ORDER BY NAME"
                End If


            Case objIniFile.GetString("frmDirectory", "MSG13", "Сетевые фильтры")

                If unamDB <> "MS Access" Or unamDB <> "MS Access 2007" Then

                    sSQL =
                        "SELECT SPR_FS.Id, SPR_FS.Name, SPR_PROIZV.PROIZV FROM SPR_PROIZV INNER JOIN SPR_FS ON (SPR_PROIZV.id = SPR_FS.Proizv) AND (SPR_PROIZV.iD = SPR_FS.Proizv) WHERE ((SPR_FS.Proizv=SPR_PROIZV.iD)) ORDER BY NAME"

                Else
                    'sSQL = "SELECT SPR_FS.Id, SPR_FS.Name, SPR_PROIZV.PROIZV, (Select count(*) FROM kompy where kompy.FILTR_NAME=SPR_FS.Name)               as temp FROM SPR_PROIZV INNER JOIN SPR_FS ON (SPR_PROIZV.id = SPR_FS.Proizv) AND (SPR_PROIZV.iD = SPR_FS.Proizv) WHERE ((SPR_FS.Proizv=SPR_PROIZV.iD)) ORDER BY NAME"
                    sSQL =
                        "SELECT SPR_FS.Id, SPR_FS.Name, SPR_PROIZV.PROIZV, (Select count(*) FROM kompy where kompy.NET_NAME=SPR_FS.Name and tiptehn='FS') as temp FROM SPR_PROIZV INNER JOIN SPR_FS ON (SPR_PROIZV.id = SPR_FS.Proizv) AND (SPR_PROIZV.iD = SPR_FS.Proizv) WHERE ((SPR_FS.Proizv=SPR_PROIZV.iD)) ORDER BY NAME"

                End If


            Case objIniFile.GetString("frmDirectory", "MSG14", "Сетевые устройства")
                gb1.Visible = True
                gb2.Visible = True
                gb1.Text = objIniFile.GetString("frmDirectory", "MSG67", "Тип устройства")
                lbl1.Text = ""
                gb2.Text = objIniFile.GetString("frmDirectory", "MSG68", "Количество портов")
                lbl2.Text = ""
                FillComboNET(Me.cmb1, "name", "SPR_NET_DEV", "", False, True)


                If unamDB <> "MS Access" Or unamDB <> "MS Access 2007" Then

                    sSQL =
                        "SELECT SPR_DEV_NET.Id, SPR_DEV_NET.Name, SPR_PROIZV.PROIZV FROM SPR_PROIZV INNER JOIN SPR_DEV_NET ON (SPR_PROIZV.id = SPR_DEV_NET.Proizv) AND (SPR_PROIZV.iD = SPR_DEV_NET.Proizv) WHERE ((SPR_DEV_NET.Proizv=SPR_PROIZV.iD)) ORDER BY NAME"

                Else
                    sSQL =
                        "SELECT SPR_DEV_NET.Id, SPR_DEV_NET.Name, SPR_PROIZV.PROIZV, (Select count(*) FROM kompy where kompy.NET_NAME=SPR_DEV_NET.Name and tiptehn='NET') as temp FROM SPR_PROIZV INNER JOIN SPR_DEV_NET ON (SPR_PROIZV.id = SPR_DEV_NET.Proizv) AND (SPR_PROIZV.iD = SPR_DEV_NET.Proizv) WHERE ((SPR_DEV_NET.Proizv=SPR_PROIZV.iD)) ORDER BY NAME"
                End If


            Case objIniFile.GetString("frmDirectory", "MSG15", "Сканер")
                gb1.Visible = True

                If unamDB <> "MS Access" Or unamDB <> "MS Access 2007" Then

                    sSQL =
                        "SELECT SPR_SCANER.Id, SPR_SCANER.Name, SPR_PROIZV.PROIZV FROM SPR_PROIZV INNER JOIN SPR_SCANER ON (SPR_PROIZV.id = SPR_SCANER.Proizv) AND (SPR_PROIZV.iD = SPR_SCANER.Proizv) WHERE ((SPR_SCANER.Proizv=SPR_PROIZV.iD)) ORDER BY NAME"

                Else
                    sSQL =
                        "SELECT SPR_SCANER.Id, SPR_SCANER.Name, SPR_PROIZV.PROIZV, (Select count(*) FROM kompy where kompy.NET_NAME=SPR_SCANER.Name and tiptehn='SCANER') as temp FROM SPR_PROIZV INNER JOIN SPR_SCANER ON (SPR_PROIZV.id = SPR_SCANER.Proizv) AND (SPR_PROIZV.iD = SPR_SCANER.Proizv) WHERE ((SPR_SCANER.Proizv=SPR_PROIZV.iD)) ORDER BY NAME"
                End If


            Case objIniFile.GetString("frmDirectory", "MSG16", "Телефон")
                gb1.Visible = True

                If unamDB <> "MS Access" Or unamDB <> "MS Access 2007" Then

                    sSQL =
                        "SELECT spr_phone.Id, spr_phone.NAME, SPR_PROIZV.PROIZV FROM SPR_PROIZV INNER JOIN spr_phone ON (SPR_PROIZV.id = spr_phone.Proizv) AND (SPR_PROIZV.iD = spr_phone.Proizv) WHERE ((spr_phone.Proizv=SPR_PROIZV.iD)) ORDER BY NAME"

                Else
                    sSQL =
                        "SELECT spr_phone.Id, spr_phone.NAME, SPR_PROIZV.PROIZV, (Select count(*) FROM kompy where kompy.NET_NAME=spr_phone.Name and tiptehn='PHONE') as temp FROM SPR_PROIZV INNER JOIN spr_phone ON (SPR_PROIZV.id = spr_phone.Proizv) AND (SPR_PROIZV.iD = spr_phone.Proizv) WHERE ((spr_phone.Proizv=SPR_PROIZV.iD)) ORDER BY NAME"
                End If


            Case objIniFile.GetString("frmDirectory", "MSG17", "Факс")
                gb1.Visible = True

                If unamDB <> "MS Access" Or unamDB <> "MS Access 2007" Then

                    sSQL =
                        "SELECT spr_fax.Id, spr_fax.NAME, SPR_PROIZV.PROIZV FROM SPR_PROIZV INNER JOIN spr_fax ON (SPR_PROIZV.id = spr_fax.Proizv) AND (SPR_PROIZV.iD = spr_fax.Proizv) WHERE ((spr_fax.Proizv=SPR_PROIZV.iD)) ORDER BY NAME"

                Else
                    sSQL =
                        "SELECT spr_fax.Id, spr_fax.NAME, SPR_PROIZV.PROIZV, (Select count(*) FROM kompy where kompy.NET_NAME=spr_fax.Name and tiptehn='FAX') as temp FROM SPR_PROIZV INNER JOIN spr_fax ON (SPR_PROIZV.id = spr_fax.Proizv) AND (SPR_PROIZV.iD = spr_fax.Proizv) WHERE ((spr_fax.Proizv=SPR_PROIZV.iD)) ORDER BY NAME"
                End If


            Case objIniFile.GetString("frmDirectory", "MSG18", "Фотоаппарат")
                gb1.Visible = True
                gb2.Visible = True
                gb1.Text = objIniFile.GetString("frmDirectory", "MSG69", "Мегапикселов")
                lbl1.Text = objIniFile.GetString("frmDirectory", "MSG70", "Укажите Mp")
                gb2.Text = objIniFile.GetString("frmDirectory", "MSG71", "Объем карты памяти")
                lbl2.Text = objIniFile.GetString("frmDirectory", "MSG71", "Объем карты памяти")

                If unamDB <> "MS Access" Or unamDB <> "MS Access 2007" Then

                    sSQL =
                        "SELECT spr_photo.Id, spr_photo.NAME, SPR_PROIZV.PROIZV FROM SPR_PROIZV INNER JOIN spr_photo ON (SPR_PROIZV.id = spr_photo.Proizv) AND (SPR_PROIZV.iD = spr_photo.Proizv) WHERE ((spr_photo.Proizv=SPR_PROIZV.iD)) ORDER BY NAME"

                Else
                    sSQL =
                        "SELECT spr_photo.Id, spr_photo.NAME, SPR_PROIZV.PROIZV, (Select count(*) FROM kompy where kompy.NET_NAME=spr_photo.Name and tiptehn='PHOTO') as temp FROM SPR_PROIZV INNER JOIN spr_photo ON (SPR_PROIZV.id = spr_photo.Proizv) AND (SPR_PROIZV.iD = spr_photo.Proizv) WHERE ((spr_photo.Proizv=SPR_PROIZV.iD)) ORDER BY NAME"
                End If


            Case objIniFile.GetString("frmDirectory", "MSG20", "Видео карты")
                lbl1.Visible = True
                gb1.Visible = True
                gb1.Text = objIniFile.GetString("frmDirectory", "MSG72", "Объем памяти")
                lbl1.Text = objIniFile.GetString("frmDirectory", "MSG73", "Укажите объем памяти в Мб.")

                If unamDB <> "MS Access" Or unamDB <> "MS Access 2007" Then

                    sSQL =
                        "SELECT SPR_SVGA.Id, SPR_SVGA.Name, SPR_PROIZV.PROIZV FROM SPR_PROIZV INNER JOIN SPR_SVGA ON (SPR_PROIZV.id = SPR_SVGA.Proizv) AND (SPR_PROIZV.iD = SPR_SVGA.Proizv) WHERE ((SPR_SVGA.Proizv=SPR_PROIZV.iD)) ORDER BY NAME"

                Else
                    sSQL =
                        "SELECT SPR_SVGA.Id, SPR_SVGA.Name, SPR_PROIZV.PROIZV, (Select count(*) FROM kompy where kompy.SVGA_NAME=SPR_SVGA.Name) as temp FROM SPR_PROIZV INNER JOIN SPR_SVGA ON (SPR_PROIZV.id = SPR_SVGA.Proizv) AND (SPR_PROIZV.iD = SPR_SVGA.Proizv) WHERE ((SPR_SVGA.Proizv=SPR_PROIZV.iD)) ORDER BY NAME"
                End If


            Case objIniFile.GetString("frmDirectory", "MSG21", "Дисководы")
                lbl1.Visible = True
                gb1.Visible = True
                cmb1.Items.Add("3.5")
                cmb1.Items.Add("5.5")

                gb1.Text = objIniFile.GetString("frmDirectory", "MSG74", "Форм Фактор")
                lbl1.Text = objIniFile.GetString("frmDirectory", "MSG75", "Укажите формфактор")


                If unamDB <> "MS Access" Or unamDB <> "MS Access 2007" Then
                    sSQL =
                        "SELECT SPR_FDD.Id, SPR_FDD.Name, SPR_PROIZV.PROIZV FROM SPR_PROIZV INNER JOIN SPR_FDD ON (SPR_PROIZV.id = SPR_FDD.Proizv) AND (SPR_PROIZV.iD = SPR_FDD.Proizv) WHERE ((SPR_FDD.Proizv=SPR_PROIZV.iD)) ORDER BY NAME"
                Else
                    sSQL =
                        "SELECT SPR_FDD.Id, SPR_FDD.Name, SPR_PROIZV.PROIZV, (Select count(*) FROM kompy where kompy.FDD_NAME=SPR_FDD.Name) as temp FROM SPR_PROIZV INNER JOIN SPR_FDD ON (SPR_PROIZV.id = SPR_FDD.Proizv) AND (SPR_PROIZV.iD = SPR_FDD.Proizv) WHERE ((SPR_FDD.Proizv=SPR_PROIZV.iD)) ORDER BY NAME"
                End If

            Case objIniFile.GetString("frmDirectory", "MSG22", "Жесткие диски")
                lbl1.Visible = True
                gb1.Visible = True
                gb1.Text = objIniFile.GetString("frmDirectory", "MSG76", "Объем в Гб.")
                lbl1.Text = objIniFile.GetString("frmDirectory", "MSG77", "Укажите Объем HDD в Гб.")


                If unamDB <> "MS Access" Or unamDB <> "MS Access 2007" Then
                    sSQL =
                        "SELECT SPR_HDD.Id, SPR_HDD.Name, SPR_PROIZV.PROIZV FROM SPR_PROIZV INNER JOIN SPR_HDD ON (SPR_PROIZV.id = SPR_HDD.Proizv) AND (SPR_PROIZV.iD = SPR_HDD.Proizv) WHERE ((SPR_HDD.Proizv=SPR_PROIZV.iD)) ORDER BY NAME"
                Else
                    sSQL =
                        "SELECT SPR_HDD.Id, SPR_HDD.Name, SPR_PROIZV.PROIZV,(Select count(*) FROM  (SELECT cpus.HDD_Name_1 FROM (SELECT HDD_Name_1 FROM kompy WHERE tiptehn = 'PC' union all SELECT HDD_Name_2 FROM kompy WHERE tiptehn = 'PC' union all SELECT HDD_Name_3 FROM kompy WHERE tiptehn = 'PC' union all SELECT  HDD_Name_4 FROM kompy WHERE tiptehn = 'PC' ) AS cpus) where cpus.HDD_Name_1=SPR_HDD.Name) as temp FROM SPR_PROIZV INNER JOIN SPR_HDD ON (SPR_PROIZV.id = SPR_HDD.Proizv) AND (SPR_PROIZV.iD = SPR_HDD.Proizv) WHERE ((SPR_HDD.Proizv=SPR_PROIZV.iD)) ORDER BY NAME"
                End If

            Case objIniFile.GetString("frmDirectory", "MSG23", "Звуковые карты")
                lbl1.Visible = True
                gb1.Visible = True
                gb1.Text = objIniFile.GetString("frmDirectory", "MSG78", "Дополнительно")
                lbl1.Text = objIniFile.GetString("frmDirectory", "MSG79", "Параметры")

                If unamDB <> "MS Access" Or unamDB <> "MS Access 2007" Then
                    sSQL =
                        "SELECT SPR_SOUND.Id, SPR_SOUND.Name, SPR_PROIZV.PROIZV FROM SPR_PROIZV INNER JOIN SPR_SOUND ON (SPR_PROIZV.id = SPR_SOUND.Proizv) AND (SPR_PROIZV.iD = SPR_SOUND.Proizv) WHERE ((SPR_SOUND.Proizv=SPR_PROIZV.iD)) ORDER BY NAME"
                Else
                    sSQL =
                        "SELECT SPR_SOUND.Id, SPR_SOUND.Name, SPR_PROIZV.PROIZV, (Select count(*) FROM kompy where kompy.SOUND_NAME=SPR_SOUND.Name) as temp FROM SPR_PROIZV INNER JOIN SPR_SOUND ON (SPR_PROIZV.id = SPR_SOUND.Proizv) AND (SPR_PROIZV.iD = SPR_SOUND.Proizv) WHERE ((SPR_SOUND.Proizv=SPR_PROIZV.iD)) ORDER BY NAME"
                End If

            Case objIniFile.GetString("frmDirectory", "MSG24", "Кардридер")
                lbl1.Visible = True
                gb1.Visible = True
                gb1.Text = objIniFile.GetString("frmDirectory", "MSG78", "Дополнительно")
                lbl1.Text = objIniFile.GetString("frmDirectory", "MSG79", "Параметры")

                If unamDB <> "MS Access" Or unamDB <> "MS Access 2007" Then
                    sSQL =
                        "SELECT SPR_CREADER.Id, SPR_CREADER.Name, SPR_PROIZV.PROIZV FROM SPR_PROIZV INNER JOIN SPR_CREADER ON (SPR_PROIZV.id = SPR_CREADER.Proizv) AND (SPR_PROIZV.iD = SPR_CREADER.Proizv) WHERE ((SPR_CREADER.Proizv=SPR_PROIZV.iD)) ORDER BY NAME"
                Else
                    sSQL =
                        "SELECT SPR_CREADER.Id, SPR_CREADER.Name, SPR_PROIZV.PROIZV, (Select count(*) FROM kompy where kompy.CREADER_NAME=SPR_CREADER.Name) as temp FROM SPR_PROIZV INNER JOIN SPR_CREADER ON (SPR_PROIZV.id = SPR_CREADER.Proizv) AND (SPR_PROIZV.iD = SPR_CREADER.Proizv) WHERE ((SPR_CREADER.Proizv=SPR_PROIZV.iD)) ORDER BY NAME"
                End If

            Case objIniFile.GetString("frmDirectory", "MSG25", "Материнские платы")
                lbl1.Visible = True
                gb1.Visible = True
                gb1.Text = objIniFile.GetString("frmDirectory", "MSG80", "Чипсет")
                lbl1.Text = objIniFile.GetString("frmDirectory", "MSG81", "Укажите Чипсет")


                If unamDB <> "MS Access" Or unamDB <> "MS Access 2007" Then
                    sSQL =
                        "SELECT SPR_MB.Id, SPR_MB.Name, SPR_PROIZV.PROIZV FROM SPR_PROIZV INNER JOIN SPR_MB ON (SPR_PROIZV.id = SPR_MB.Proizv) AND (SPR_PROIZV.iD = SPR_MB.Proizv) WHERE ((SPR_MB.Proizv=SPR_PROIZV.iD)) ORDER BY NAME"
                Else
                    sSQL =
                        "SELECT SPR_MB.Id, SPR_MB.Name, SPR_PROIZV.PROIZV, (Select count(*) FROM kompy where kompy.mb_name=SPR_MB.Name) as temp FROM SPR_PROIZV INNER JOIN SPR_MB ON (SPR_PROIZV.id = SPR_MB.Proizv) AND (SPR_PROIZV.iD = SPR_MB.Proizv) WHERE ((SPR_MB.Proizv=SPR_PROIZV.iD)) ORDER BY NAME"
                End If


            Case objIniFile.GetString("frmDirectory", "MSG26", "Модули памяти")
                lbl1.Visible = True
                gb1.Visible = True
                gb1.Text = objIniFile.GetString("frmDirectory", "MSG82", "Скорость памяти")
                lbl1.Text = objIniFile.GetString("frmDirectory", "MSG83", "(Частота)")


                If unamDB <> "MS Access" Or unamDB <> "MS Access 2007" Then
                    sSQL =
                        "SELECT SPR_RAM.Id, SPR_RAM.Name, SPR_PROIZV.PROIZV FROM SPR_PROIZV INNER JOIN SPR_RAM ON (SPR_PROIZV.id = SPR_RAM.Proizv) AND (SPR_PROIZV.iD = SPR_RAM.Proizv) WHERE ((SPR_RAM.Proizv=SPR_PROIZV.iD)) ORDER BY NAME"
                Else
                    sSQL =
                        "SELECT SPR_RAM.Id, SPR_RAM.Name, SPR_PROIZV.PROIZV,(Select count(*) FROM  (SELECT cpus.RAM_1 FROM (SELECT RAM_1 FROM kompy WHERE tiptehn = 'PC' union all SELECT RAM_2 FROM kompy WHERE tiptehn = 'PC' union all SELECT RAM_3 FROM kompy WHERE  tiptehn = 'PC' union all SELECT  RAM_4 FROM kompy WHERE tiptehn = 'PC' ) AS cpus)  where cpus.RAM_1=SPR_RAM.Name) as temp FROM SPR_PROIZV INNER JOIN SPR_RAM ON (SPR_PROIZV.id = SPR_RAM.Proizv) AND (SPR_PROIZV.iD = SPR_RAM.Proizv) WHERE ((SPR_RAM.Proizv=SPR_PROIZV.iD)) ORDER BY NAME"
                End If


            Case objIniFile.GetString("frmDirectory", "MSG28", "Процессор")
                lbl1.Visible = True
                gb1.Visible = True
                gb2.Visible = True

                cmbName2.Visible = False
                Label2.Visible = False
                txtName.Visible = False

                cmb1.Items.Clear()
                gb1.Text = objIniFile.GetString("frmDirectory", "MSG84", "Реальная частота")
                lbl1.Text = objIniFile.GetString("frmDirectory", "MSG85", "Укажите реальную частоту процессора")

                cmb2.Items.Clear()
                gb2.Text = objIniFile.GetString("frmDirectory", "MSG86", "Сокет")
                lbl2.Text = objIniFile.GetString("frmDirectory", "MSG87", "Укажите сокет")

                If unamDB <> "MS Access" Or unamDB <> "MS Access 2007" Then
                    sSQL =
                        "SELECT SPR_CPU.Id, SPR_CPU.Name, SPR_PROIZV.PROIZV FROM SPR_PROIZV INNER JOIN SPR_CPU ON (SPR_PROIZV.id = SPR_CPU.Proizv) AND (SPR_PROIZV.iD = SPR_CPU.Proizv) WHERE ((SPR_CPU.Proizv=SPR_PROIZV.iD)) ORDER BY NAME"
                Else
                    sSQL =
                        "SELECT SPR_CPU.Id, SPR_CPU.Name, SPR_PROIZV.PROIZV,(Select count(*) FROM  (SELECT cpus.cpu1 FROM (SELECT cpu1 FROM kompy WHERE tiptehn = 'PC' union all SELECT cpu2 FROM kompy WHERE tiptehn = 'PC'  union all SELECT cpu3 FROM kompy WHERE tiptehn = 'PC'  union all SELECT cpu4 FROM kompy WHERE tiptehn = 'PC') AS cpus)  where cpus.cpu1=SPR_CPU.Name) as temp FROM SPR_PROIZV INNER JOIN SPR_CPU ON (SPR_PROIZV.id = SPR_CPU.Proizv) AND (SPR_PROIZV.iD = SPR_CPU.Proizv) WHERE ((SPR_CPU.Proizv=SPR_PROIZV.iD)) ORDER BY NAME"
                End If

            Case objIniFile.GetString("frmDirectory", "MSG29", "Сетевые карты")

                If unamDB <> "MS Access" Or unamDB <> "MS Access 2007" Then
                    sSQL =
                        "SELECT SPR_NET.Id, SPR_NET.Name, SPR_PROIZV.PROIZV FROM SPR_PROIZV INNER JOIN SPR_NET ON (SPR_PROIZV.id = SPR_NET.Proizv) AND (SPR_PROIZV.iD = SPR_NET.Proizv) WHERE ((SPR_NET.Proizv=SPR_PROIZV.iD)) ORDER BY NAME"
                Else
                    sSQL =
                        "SELECT SPR_NET.Id, SPR_NET.Name, SPR_PROIZV.PROIZV, (Select count(*) FROM (SELECT cpus.NET_NAME_1 FROM (SELECT NET_NAME_1 FROM kompy WHERE tiptehn = 'PC' union all SELECT NET_NAME_2 FROM kompy WHERE tiptehn = 'PC' ) AS cpus) where cpus.NET_NAME_1=SPR_NET.Name) as temp FROM SPR_PROIZV INNER JOIN SPR_NET ON (SPR_PROIZV.id = SPR_NET.Proizv) AND (SPR_PROIZV.iD = SPR_NET.Proizv) WHERE ((SPR_NET.Proizv=SPR_PROIZV.iD)) ORDER BY NAME"
                End If


            Case objIniFile.GetString("frmDirectory", "MSG30", "Устройства PCI")

                If unamDB <> "MS Access" Or unamDB <> "MS Access 2007" Then
                    sSQL =
                        "SELECT SPR_PCI.Id, SPR_PCI.Name, SPR_PROIZV.PROIZV FROM SPR_PROIZV INNER JOIN SPR_PCI ON (SPR_PROIZV.id = SPR_PCI.Proizv) AND (SPR_PROIZV.iD = SPR_PCI.Proizv) WHERE ((SPR_PCI.Proizv=SPR_PROIZV.iD)) ORDER BY NAME"
                Else
                    sSQL =
                        "SELECT SPR_PCI.Id, SPR_PCI.Name, SPR_PROIZV.PROIZV, (Select count(*) FROM kompy where kompy.PCI_Name=SPR_PCI.Name) as temp FROM SPR_PROIZV INNER JOIN SPR_PCI ON (SPR_PROIZV.id = SPR_PCI.Proizv) AND (SPR_PROIZV.iD = SPR_PCI.Proizv) WHERE ((SPR_PCI.Proizv=SPR_PROIZV.iD)) ORDER BY NAME"
                End If

            Case objIniFile.GetString("frmDirectory", "MSG36", "Мастер")

                Label3.Visible = False
                txtName.Visible = False
                cmbName3.Visible = False
                cmbName2.Visible = True
                Label2.Visible = True
                Label2.Text = objIniFile.GetString("frmDirectory", "MSG88", "Пользователь")

                gb1.Visible = True
                gb1.Text = objIniFile.GetString("frmDirectory", "MSG89", "E-Mail")

                gb2.Visible = True
                gb2.Text = objIniFile.GetString("frmDirectory", "MSG90", "SMTP Сервер")

                Dim rs1 As Recordset
                rs1 = New Recordset
                rs1.Open("SELECT * FROM T_User", DB7, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic)

                With rs1
                    .MoveFirst()
                    Do While Not .EOF
                        cmbName2.Items.Add(.Fields("name").Value)
                        .MoveNext()
                    Loop
                End With
                rs1.Close()
                rs1 = Nothing

                Me.lvDirectory.Columns.Clear()
                Me.lvDirectory.Columns.Add(objIniFile.GetString("frmDirectory", "lvDirectory1", "id"), 20,
                                           HorizontalAlignment.Left)
                Me.lvDirectory.Columns.Add(objIniFile.GetString("frmDirectory", "lvDirectory2", "Наименование"), 300,
                                           HorizontalAlignment.Left)
                'Me.lotd.Columns.Add(("Производитель"), 300, HorizontalAlignment.Left)

                sSQL = "SELECT id, Name,A FROM SPR_Master ORDER BY NAME"

            Case objIniFile.GetString("frmDirectory", "MSG37", "Ответственный")
                Label2.Visible = False
                cmbName2.Visible = False
                Label3.Visible = False
                txtName.Visible = False
                cmbName3.Visible = False
                gb1.Visible = False
                gb2.Visible = False

                Me.lvDirectory.Columns.Clear()
                Me.lvDirectory.Columns.Add(objIniFile.GetString("frmDirectory", "lvDirectory1", "id"), 20,
                                           HorizontalAlignment.Left)
                Me.lvDirectory.Columns.Add(objIniFile.GetString("frmDirectory", "lvDirectory2", "Наименование"), 300,
                                           HorizontalAlignment.Left)

                sSQL = "SELECT id, Name FROM SPR_OTV ORDER BY NAME"

            Case objIniFile.GetString("frmDirectory", "MSG39", "Филиал")

                chkVisibleSTR.Visible = True
                Label3.Visible = False
                txtName.Visible = False
                cmbName3.Visible = False

                Me.lvDirectory.Columns.Clear()
                Me.lvDirectory.Columns.Add(objIniFile.GetString("frmDirectory", "lvDirectory1", "id"), 20,
                                           HorizontalAlignment.Left)
                Me.lvDirectory.Columns.Add(objIniFile.GetString("frmDirectory", "lvDirectory2", "Наименование"), 300,
                                           HorizontalAlignment.Left)

                sSQL = "SELECT Id, filial FROM SPR_FILIAL ORDER BY filial"

            Case objIniFile.GetString("frmDirectory", "MSG40", "Отдел")

                Label1.Text = objIniFile.GetString("frmDirectory", "MSG39", "Филиал")

                chkVisibleSTR.Visible = True
                Label3.Text = objIniFile.GetString("frmDirectory", "MSG40", "Отдел")
                txtName.Visible = True
                cmbName3.Visible = False
                cmbName.Items.Clear()
                FillComboNET(Me.cmbName, "FILIAL", "SPR_FILIAL", "", False, True)

                Me.lvDirectory.Columns.Clear()
                Me.lvDirectory.Columns.Add(objIniFile.GetString("frmDirectory", "lvDirectory1", "id"), 20,
                                           HorizontalAlignment.Left)
                Me.lvDirectory.Columns.Add(objIniFile.GetString("frmDirectory", "MSG39", "Филиал"), 300,
                                           HorizontalAlignment.Left)
                Me.lvDirectory.Columns.Add(objIniFile.GetString("frmDirectory", "MSG40", "Отдел"), 300,
                                           HorizontalAlignment.Left)

                sSQL = "SELECT id, filial, n_otd FROM SPR_OTD_FILIAL ORDER BY filial"

            Case objIniFile.GetString("frmDirectory", "MSG41", "Кабинет")

                Label1.Text = objIniFile.GetString("frmDirectory", "MSG39", "Филиал")
                chkVisibleSTR.Visible = True
                Label3.Text = objIniFile.GetString("frmDirectory", "MSG41", "Кабинет")
                Label2.Text = objIniFile.GetString("frmDirectory", "MSG40", "Отдел")
                Label2.Visible = True
                cmbName2.Visible = True
                txtName.Visible = True
                cmbName3.Visible = False
                cmbName.Items.Clear()

                FillComboNET(Me.cmbName, "FILIAL", "SPR_FILIAL", "", False, True)


                sSQL = "SELECT id, N_F, N_M, Name FROM SPR_KAB ORDER BY Name"

                Me.lvDirectory.Columns.Clear()
                Me.lvDirectory.Columns.Add(objIniFile.GetString("frmDirectory", "lvDirectory1", "id"), 20,
                                           HorizontalAlignment.Left)
                Me.lvDirectory.Columns.Add(objIniFile.GetString("frmDirectory", "MSG39", "Филиал"), 250,
                                           HorizontalAlignment.Left)
                Me.lvDirectory.Columns.Add(objIniFile.GetString("frmDirectory", "MSG40", "Отдел"), 250,
                                           HorizontalAlignment.Left)
                Me.lvDirectory.Columns.Add(objIniFile.GetString("frmDirectory", "MSG41", "Кабинет"), 250,
                                           HorizontalAlignment.Left)
                'Me.lvDirectory.Columns.Add(objIniFile.GetString("frmDirectory", "MSG99", "Используется"), 70, HorizontalAlignment.Left)


            Case objIniFile.GetString("frmDirectory", "MSG43", "Уровень заявки")
                Label2.Visible = False
                cmbName2.Visible = False
                Label3.Visible = False
                txtName.Visible = False
                cmbName3.Visible = False
                gb1.Visible = False
                gb2.Visible = False
                sSQL = "SELECT id, uroven  FROM SPR_Uroven order by uroven"
                Me.lvDirectory.Columns.Clear()
                Me.lvDirectory.Columns.Add(objIniFile.GetString("frmDirectory", "lvDirectory1", "id"), 20,
                                           HorizontalAlignment.Left)
                Me.lvDirectory.Columns.Add(objIniFile.GetString("frmDirectory", "lvDirectory2", "Наименование"), 300,
                                           HorizontalAlignment.Left)

            Case objIniFile.GetString("frmDirectory", "MSG44", "Уровень выполнения")
                Label2.Visible = False
                cmbName2.Visible = False
                Label3.Visible = False
                txtName.Visible = False
                cmbName3.Visible = False
                gb1.Visible = False
                gb2.Visible = False
                sSQL = "SELECT id, name FROM spr_vip order by name"

                Me.lvDirectory.Columns.Clear()
                Me.lvDirectory.Columns.Add(objIniFile.GetString("frmDirectory", "lvDirectory1", "id"), 20,
                                           HorizontalAlignment.Left)
                Me.lvDirectory.Columns.Add(objIniFile.GetString("frmDirectory", "lvDirectory2", "Наименование"), 300,
                                           HorizontalAlignment.Left)

            Case objIniFile.GetString("frmDirectory", "MSG45", "Тип заявки")
                Label2.Visible = False
                cmbName2.Visible = False
                Label3.Visible = False
                txtName.Visible = False
                cmbName3.Visible = False
                gb1.Visible = False
                gb2.Visible = False
                sSQL = "SELECT id, name FROM spr_tip_z order by name"

                Me.lvDirectory.Columns.Clear()
                Me.lvDirectory.Columns.Add(objIniFile.GetString("frmDirectory", "lvDirectory1", "id"), 20,
                                           HorizontalAlignment.Left)
                Me.lvDirectory.Columns.Add(objIniFile.GetString("frmDirectory", "lvDirectory2", "Наименование"), 300,
                                           HorizontalAlignment.Left)

            Case objIniFile.GetString("frmDirectory", "MSG47", "Поставщики")
                Label3.Visible = False
                txtName.Visible = False
                cmbName3.Visible = False

                sSQL = "SELECT id, Name FROM SPR_Postav ORDER BY Name"

                Me.lvDirectory.Columns.Clear()
                Me.lvDirectory.Columns.Add(objIniFile.GetString("frmDirectory", "lvDirectory1", "id"), 20,
                                           HorizontalAlignment.Left)
                Me.lvDirectory.Columns.Add(objIniFile.GetString("frmDirectory", "lvDirectory2", "Наименование"), 300,
                                           HorizontalAlignment.Left)

            Case objIniFile.GetString("frmDirectory", "MSG48", "Производители")
                cmbName3.Visible = False
                txtName.Visible = False
                Label3.Visible = False

                sSQL = "SELECT SPR_PROIZV.Id, SPR_PROIZV.PROIZV FROM SPR_PROIZV ORDER BY PROIZV"

                Me.lvDirectory.Columns.Clear()
                Me.lvDirectory.Columns.Add(objIniFile.GetString("frmDirectory", "lvDirectory1", "id"), 20,
                                           HorizontalAlignment.Left)
                Me.lvDirectory.Columns.Add(objIniFile.GetString("frmDirectory", "lvDirectory2", "Наименование"), 300,
                                           HorizontalAlignment.Left)

            Case objIniFile.GetString("frmDirectory", "MSG49", "Тип компьютера")
                Label2.Visible = False
                cmbName2.Visible = False
                Label3.Visible = False
                txtName.Visible = False
                cmbName3.Visible = False
                gb1.Visible = False
                gb2.Visible = False
                sSQL = "SELECT id, tip FROM SPR_TIP ORDER BY tip"

                Me.lvDirectory.Columns.Clear()
                Me.lvDirectory.Columns.Add(objIniFile.GetString("frmDirectory", "lvDirectory1", "id"), 20,
                                           HorizontalAlignment.Left)
                Me.lvDirectory.Columns.Add(objIniFile.GetString("frmDirectory", "lvDirectory2", "Наименование"), 300,
                                           HorizontalAlignment.Left)

            Case objIniFile.GetString("frmDirectory", "MSG50", "Модель картриджа")
                Label2.Visible = False
                cmbName2.Visible = False
                Label3.Visible = True
                txtName.Visible = False
                cmbName3.Visible = True
                gb1.Visible = True
                gb2.Visible = False
                cmb1.Items.Clear()
                gb1.Text = objIniFile.GetString("frmDirectory", "gb1", "Тип")
                cmb1.Items.Add(objIniFile.GetString("frmDirectory", "MSG91", "Струйный"))
                cmb1.Items.Add(objIniFile.GetString("frmDirectory", "MSG92", "Матричный"))
                cmb1.Items.Add(objIniFile.GetString("frmDirectory", "MSG93", "Лазерный"))
                cmb1.Items.Add(objIniFile.GetString("frmDirectory", "MSG94", "Барабан"))
                cmb1.Items.Add(objIniFile.GetString("frmDirectory", "MSG95", "Термо Пленка"))
                cmb1.Items.Add(objIniFile.GetString("frmDirectory", "MSG96", "Фотокондуктор"))


                sSQL =
                    "SELECT spr_cart.Id, spr_cart.Name, SPR_PROIZV.PROIZV FROM SPR_PROIZV INNER JOIN spr_cart ON (SPR_PROIZV.iD = spr_cart.Proizv) AND (SPR_PROIZV.iD = spr_cart.Proizv) WHERE ((spr_cart.Proizv=SPR_PROIZV.iD)) ORDER BY Name"

            Case objIniFile.GetString("frmDirectory", "MSG51", "Оборудование (Другое-тип)")

                chkCont.Visible = True
                gbOther.Visible = True
                gb1.Visible = True
                gb1.Text = objIniFile.GetString("frmDirectory", "frmDirectory", "Справочники")
                Dim intj As Decimal


                cmbIcon.Items.Clear()

                For intj = 0 To frmComputers.ilsCommands.Images.Count - 1
                    cmbIcon.Items.Add(intj)
                Next


                Me.lvDirectory.Columns.Clear()
                Me.lvDirectory.Columns.Add(objIniFile.GetString("frmDirectory", "lvDirectory1", "id"), 20,
                                           HorizontalAlignment.Left)
                Me.lvDirectory.Columns.Add(objIniFile.GetString("frmDirectory", "lvDirectory2", "Наименование"), 300,
                                           HorizontalAlignment.Left)

                'sSQL = "SELECT spr_other.Id, spr_other.Name, SPR_PROIZV.PROIZV FROM SPR_PROIZV INNER JOIN SPR_PCI ON (SPR_PROIZV.id = spr_other.Proizv) AND (SPR_PROIZV.iD = spr_other.Proizv) WHERE ((spr_other.Proizv=SPR_PROIZV.iD)) ORDER BY Name"
                sSQL = "SELECT Id, Name FROM spr_other"

                Call LOAD_COMBO_SPR()


            Case objIniFile.GetString("frmDirectory", "MSG52", "Оборудование (Другое-устройства)")
                lbl1.Visible = True
                gb1.Visible = True
                gb1.Text = objIniFile.GetString("frmDirectory", "gb1", "Тип")
                lbl1.Text = objIniFile.GetString("frmDirectory", "gb1", "Тип")

                FillComboNET(Me.cmb1, "Name", "spr_other", "", False, True)


                If unamDB <> "MS Access" Or unamDB <> "MS Access 2007" Then
                    sSQL =
                        "SELECT SPR_OTH_DEV.Id, SPR_OTH_DEV.Name, SPR_PROIZV.PROIZV FROM SPR_PROIZV INNER JOIN SPR_OTH_DEV ON (SPR_PROIZV.id = SPR_OTH_DEV.Proizv) AND (SPR_PROIZV.iD = SPR_OTH_DEV.Proizv) WHERE ((SPR_OTH_DEV.Proizv=SPR_PROIZV.iD)) ORDER BY NAME"
                Else
                    sSQL =
                        "SELECT SPR_OTH_DEV.Id, SPR_OTH_DEV.Name, SPR_PROIZV.PROIZV, (Select count(*) FROM kompy where kompy.net_Name=SPR_OTH_DEV.Name) as temp FROM SPR_PROIZV INNER JOIN SPR_OTH_DEV ON (SPR_PROIZV.id = SPR_OTH_DEV.Proizv) AND (SPR_PROIZV.iD = SPR_OTH_DEV.Proizv) WHERE ((SPR_OTH_DEV.Proizv=SPR_PROIZV.iD)) ORDER BY NAME"
                End If


            Case objIniFile.GetString("frmDirectory", "MSG53", "Тип лицензии")
                Label2.Visible = False
                cmbName2.Visible = False
                Label3.Visible = False
                txtName.Visible = False
                cmbName3.Visible = False
                gb1.Visible = False
                gb2.Visible = False

                sSQL = "SELECT SPR_LIC.Id, SPR_LIC.name FROM SPR_LIC ORDER BY Name"

                Me.lvDirectory.Columns.Clear()
                Me.lvDirectory.Columns.Add(objIniFile.GetString("frmDirectory", "lvDirectory1", "id"), 20,
                                           HorizontalAlignment.Left)
                Me.lvDirectory.Columns.Add(objIniFile.GetString("frmDirectory", "lvDirectory2", "Наименование"), 300,
                                           HorizontalAlignment.Left)

            Case objIniFile.GetString("frmDirectory", "MSG54", "Тип программного обеспечения")
                Label2.Visible = False
                cmbName2.Visible = False
                Label3.Visible = False
                txtName.Visible = False
                cmbName3.Visible = False
                gb1.Visible = False
                gb2.Visible = False

                sSQL = "SELECT id, Name FROM SPR_TIP_PO order by Name"

                Me.lvDirectory.Columns.Clear()
                Me.lvDirectory.Columns.Add(objIniFile.GetString("frmDirectory", "lvDirectory1", "id"), 20,
                                           HorizontalAlignment.Left)
                Me.lvDirectory.Columns.Add(objIniFile.GetString("frmDirectory", "lvDirectory2", "Наименование"), 300,
                                           HorizontalAlignment.Left)

            Case objIniFile.GetString("frmDirectory", "MSG55", "Комплектующие")
                Label2.Visible = False
                cmbName2.Visible = False
                Label3.Visible = False
                txtName.Visible = False
                cmbName3.Visible = False
                gb1.Visible = False
                gb2.Visible = False
                gbOther.Visible = False

                'Dim intj As Decimal

                'cmbIcon.Items.Clear()

                'For intj = 0 To frmComputers.ilsCommands.Images.Count - 1
                '    cmbIcon.Items.Add(intj)
                'Next
                'gb1.Text = objIniFile.GetString("frmDirectory", "frmDirectory", "Справочники")

                sSQL = "SELECT Id, Name FROM SPR_Complect ORDER BY Name"


                Me.lvDirectory.Columns.Clear()
                Me.lvDirectory.Columns.Add(objIniFile.GetString("frmDirectory", "lvDirectory1", "id"), 20,
                                           HorizontalAlignment.Left)
                Me.lvDirectory.Columns.Add(objIniFile.GetString("frmDirectory", "lvDirectory2", "Наименование"), 300,
                                           HorizontalAlignment.Left)

            Case objIniFile.GetString("frmDirectory", "MSG56", "Программное обеспечение")
                cmbName2.Visible = True
                Label2.Visible = True
                Label2.Text = objIniFile.GetString("frmDirectory", "gb1", "Тип")

                FillComboNET(Me.cmbName2, "Name", "SPR_TIP_PO", "", False, True)

                If unamDB <> "MS Access" Or unamDB <> "MS Access 2007" Then
                    'sSQL = "SELECT SPR_PO.Id, SPR_PO.Name, SPR_PROIZV.PROIZV FROM SPR_PROIZV INNER JOIN SPR_PO ON (SPR_PROIZV.id = SPR_PO.Proizv) AND (SPR_PROIZV.iD = SPR_PO.Proizv) WHERE ((SPR_PO.Proizv=SPR_PROIZV.iD)) ORDER BY NAME"
                    sSQL = "SELECT SPR_PO.Id, SPR_PO.Name, SPR_PROIZV.PROIZV, SPR_PO.A FROM SPR_PROIZV INNER JOIN SPR_PO ON (SPR_PROIZV.id = SPR_PO.Proizv) AND (SPR_PROIZV.iD = SPR_PO.Proizv) WHERE ((SPR_PO.Proizv=SPR_PROIZV.iD)) ORDER BY NAME"
                Else
                    sSQL =
                        "SELECT SPR_PO.Id, SPR_PO.Name, SPR_PROIZV.PROIZV, (Select count(*) FROM SOFT_INSTALL where SOFT_INSTALL.Soft=SPR_PO.Name) as temp FROM SPR_PROIZV INNER JOIN SPR_PO ON (SPR_PROIZV.id = SPR_PO.Proizv) AND (SPR_PROIZV.iD = SPR_PO.Proizv) WHERE ((SPR_PO.Proizv=SPR_PROIZV.iD)) ORDER BY NAME"
                End If


                'sSQL = "SELECT SPR_PO.Id, SPR_PO.Name, SPR_PROIZV.PROIZV FROM SPR_PROIZV INNER JOIN SPR_PO ON (SPR_PROIZV.id = SPR_PO.Proizv) AND (SPR_PROIZV.iD = SPR_PO.Proizv) WHERE ((SPR_PO.Proizv=SPR_PROIZV.iD)) ORDER BY NAME"


            Case objIniFile.GetString("frmDirectory", "MSG33", "Корпус")
                lbl1.Visible = True
                gb1.Visible = True
                gb1.Text = objIniFile.GetString("frmDirectory", "MSG78", "Дополнительно")
                lbl1.Text = objIniFile.GetString("frmDirectory", "MSG79", "Параметры")


                If unamDB <> "MS Access" Or unamDB <> "MS Access 2007" Then
                    sSQL =
                        "SELECT SPR_CASE.Id, SPR_CASE.Name, SPR_PROIZV.PROIZV FROM SPR_PROIZV INNER JOIN SPR_CASE ON (SPR_PROIZV.id = SPR_CASE.Proizv) AND (SPR_PROIZV.iD = SPR_CASE.Proizv) WHERE ((SPR_CASE.Proizv=SPR_PROIZV.iD)) ORDER BY NAME"
                Else
                    sSQL =
                        "SELECT SPR_CASE.Id, SPR_CASE.Name, SPR_PROIZV.PROIZV, (Select count(*) FROM kompy where kompy.CASE_NAME=SPR_CASE.Name) as temp FROM SPR_PROIZV INNER JOIN SPR_CASE ON (SPR_PROIZV.id = SPR_CASE.Proizv) AND (SPR_PROIZV.iD = SPR_CASE.Proizv) WHERE ((SPR_CASE.Proizv=SPR_PROIZV.iD)) ORDER BY NAME"
                End If

            Case objIniFile.GetString("frmDirectory", "MSG31", "Блок питания")
                lbl1.Visible = True
                gb1.Visible = True
                gb1.Text = objIniFile.GetString("frmDirectory", "MSG78", "Дополнительно")
                lbl1.Text = objIniFile.GetString("frmDirectory", "MSG79", "Параметры")

                If unamDB <> "MS Access" Or unamDB <> "MS Access 2007" Then
                    sSQL =
                        "SELECT SPR_BP.Id, SPR_BP.Name, SPR_PROIZV.PROIZV FROM SPR_PROIZV INNER JOIN SPR_BP ON (SPR_PROIZV.id = SPR_BP.Proizv) AND (SPR_PROIZV.iD = SPR_BP.Proizv) WHERE ((SPR_BP.Proizv=SPR_PROIZV.iD)) ORDER BY NAME"

                Else
                    sSQL =
                        "SELECT SPR_BP.Id, SPR_BP.Name, SPR_PROIZV.PROIZV, (Select count(*) FROM kompy where kompy.BLOCK=SPR_BP.Name) as temp FROM SPR_PROIZV INNER JOIN SPR_BP ON (SPR_PROIZV.id = SPR_BP.Proizv) AND (SPR_PROIZV.iD = SPR_BP.Proizv) WHERE ((SPR_BP.Proizv=SPR_PROIZV.iD)) ORDER BY NAME"
                End If

        End Select

        'sSQL = "SELECT id, Name FROM SPR_NET_DEV order by Name"

        If Len(sSQL) = 0 Then Exit Sub


        Dim rs As Recordset

        Dim FirstColumn As Boolean

        rs = New Recordset
        rs.Open(sSQL, DB7, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic)

        ' Dim intCount As Decimal = 0

        Do Until rs.EOF

            FirstColumn = True      'FIRST COLUMN IS A LISTITEM, REST ARE LISTSUBITEMS
            For lngCounter = 0 To rs.Fields.Count - 1

                If FirstColumn Then
                    If Not IsDBNull(rs.Fields(lngCounter).Value) Then
                        lvDirectory.Items.Add(rs.Fields(lngCounter).Value)
                    Else
                        lvDirectory.Items.Add("")  'NULL FIELDS NEED A BLANK ITEM
                    End If                  'TO KEEP DATA FROM SHIFTING LEFT
                    FirstColumn = False
                Else
                    If Not IsDBNull(rs.Fields(lngCounter).Value) Then
                        lvDirectory.Items(lvDirectory.Items.Count - 1).SubItems.Add(rs.Fields(lngCounter).Value)
                    Else
                        lvDirectory.Items(lvDirectory.Items.Count - 1).SubItems.Add("")
                    End If
                End If
            Next

            ' If Not IsMissing(Owner) Then Owner.pbrProgress.Value = (rs.AbsolutePosition / rs.RecordCount) * 100

            rs.MoveNext()
        Loop

        FirstColumn = False
        rs.Close()
        rs = Nothing

'esq ******** отредактированый элемент -> в поле зрения
        If (Not IsNothing(curr) = True) And (lvDirectory.Items.Count > 0) Then
            lvDirectory.EnsureVisible(curr)
            lvDirectory.Items(curr).Selected = True
        End If
        'esq ********

        ResList(Me.lvDirectory)


        Exit Sub
        err_:
        MsgBox(Err.Description)
    End Sub

    Private Sub lvDirectory_Click(ByVal sender As Object, ByVal e As EventArgs) Handles lvDirectory.Click
        'Call Load_SPR_TO_EDIT()
    End Sub

    Private Sub lvDirectory_ColumnClick(ByVal sender As Object, ByVal e As ColumnClickEventArgs) _
        Handles lvDirectory.ColumnClick

        SORTING_LV(lvDirectory, e)

    End Sub

    Private Sub lvDirectory_DoubleClick(ByVal sender As Object, ByVal e As EventArgs) Handles lvDirectory.DoubleClick

        Call Load_SPR_TO_EDIT()
    End Sub

    Private Sub Load_SPR_TO_EDIT()
        On Error Resume Next
        Dim objIniFile As New IniFile(sLANGPATH)

        eDTI = True

        cmb1.Text = ""
        cmb2.Text = ""
        cmbName.Text = ""
        cmbName2.Text = ""
        cmbName3.Text = ""
        txtMemo.Text = ""
        cmbIcon.Text = ""

        If lvDirectory.Items.Count = 0 Then Exit Sub

        Dim z As Integer

        For z = 0 To lvDirectory.SelectedItems.Count - 1
            dSID = (lvDirectory.SelectedItems(z).Text)
        Next

        Dim sSQL As String
        Dim rs As Recordset

        Select Case tvDirectory.SelectedNode.Text


            Case objIniFile.GetString("frmDirectory", "MSG57", "Пользователь")

                '######################################
                'Пользователи - экспериментально
                '######################################

                sSQL = "SELECT * FROM SPR_USER WHERE id =" & dSID

            Case objIniFile.GetString("frmDirectory", "MSG27", "Оптические накопители")

                'SELECT * FROM SPR_OPTICAL INNER JOIN SPR_PROIZV ON SPR_OPTICAL.PROIZV = SPR_PROIZV.PROIZV AND ON SPR_OPTICAL.id =" & dSID

                sSQL = "SELECT * FROM SPR_OPTICAL WHERE id =" & dSID

            Case objIniFile.GetString("frmDirectory", "MSG3", "USB Устройства")

                sSQL = "SELECT * FROM SPR_USB WHERE id =" & dSID

            Case objIniFile.GetString("frmDirectory", "MSG4", "ZIP")

                sSQL = "SELECT * FROM spr_zip WHERE id =" & dSID

            Case objIniFile.GetString("frmDirectory", "MSG5", "Акустические системы")

                sSQL = "SELECT * FROM SPR_ASISTEM WHERE id =" & dSID

            Case objIniFile.GetString("frmDirectory", "MSG6", "Источники БП")

                sSQL = "SELECT * FROM SPR_IBP WHERE id =" & dSID


            Case objIniFile.GetString("frmDirectory", "MSG7", "Клавиатуры")

                sSQL = "SELECT * FROM SPR_KEYBOARD WHERE id =" & dSID

            Case objIniFile.GetString("frmDirectory", "MSG8", "Копиры")

                sSQL = "SELECT * FROM SPR_KOPIR WHERE id =" & dSID

            Case objIniFile.GetString("frmDirectory", "MSG34", "Модемы")

                sSQL = "SELECT * FROM SPR_MODEM WHERE id =" & dSID

            Case objIniFile.GetString("frmDirectory", "MSG9", "Мониторы")

                sSQL = "SELECT * FROM SPR_MONITOR WHERE id =" & dSID

            Case objIniFile.GetString("frmDirectory", "MSG10", "МФУ")

                sSQL = "SELECT * FROM SPR_MFU WHERE id =" & dSID

            Case objIniFile.GetString("frmDirectory", "MSG11", "Мыши")

                sSQL = "SELECT * FROM SPR_MOUSE WHERE id =" & dSID

            Case objIniFile.GetString("frmDirectory", "MSG12", "Принтеры")

                sSQL = "SELECT * FROM SPR_PRINTER WHERE id =" & dSID

            Case objIniFile.GetString("frmDirectory", "MSG13", "Сетевые фильтры")

                sSQL = "SELECT * FROM SPR_FS WHERE id =" & dSID

            Case objIniFile.GetString("frmDirectory", "MSG14", "Сетевые устройства")

                sSQL = "SELECT * FROM SPR_DEV_NET WHERE id =" & dSID

            Case objIniFile.GetString("frmDirectory", "MSG15", "Сканер")

                sSQL = "SELECT * FROM SPR_SCANER WHERE id =" & dSID

            Case objIniFile.GetString("frmDirectory", "MSG16", "Телефон")

                sSQL = "SELECT * FROM spr_phone WHERE id =" & dSID

            Case objIniFile.GetString("frmDirectory", "MSG17", "Факс")

                sSQL = "SELECT * FROM spr_fax WHERE id =" & dSID

            Case objIniFile.GetString("frmDirectory", "MSG18", "Фотоаппарат")

                sSQL = "SELECT * FROM spr_photo WHERE id =" & dSID

            Case objIniFile.GetString("frmDirectory", "MSG20", "Видео карты")

                sSQL = "SELECT * FROM SPR_SVGA WHERE id =" & dSID

            Case objIniFile.GetString("frmDirectory", "MSG21", "Дисководы")

                sSQL = "SELECT * FROM SPR_FDD WHERE id =" & dSID

            Case objIniFile.GetString("frmDirectory", "MSG22", "Жесткие диски")

                sSQL = "SELECT * FROM SPR_HDD WHERE id =" & dSID

            Case objIniFile.GetString("frmDirectory", "MSG23", "Звуковые карты")

                sSQL = "SELECT * FROM SPR_SOUND WHERE id =" & dSID

            Case objIniFile.GetString("frmDirectory", "MSG25", "Материнские платы")

                sSQL = "SELECT * FROM SPR_MB WHERE id =" & dSID

            Case objIniFile.GetString("frmDirectory", "MSG26", "Модули памяти")

                sSQL = "SELECT * FROM SPR_RAM WHERE id =" & dSID

            Case objIniFile.GetString("frmDirectory", "MSG28", "Процессор")

                sSQL = "SELECT * FROM SPR_CPU WHERE id =" & dSID

            Case objIniFile.GetString("frmDirectory", "MSG29", "Сетевые карты")

                sSQL = "SELECT * FROM SPR_NET WHERE id =" & dSID

            Case objIniFile.GetString("frmDirectory", "MSG30", "Устройства PCI")

                sSQL = "SELECT * FROM SPR_PCI WHERE id =" & dSID

            Case objIniFile.GetString("frmDirectory", "MSG36", "Мастер")

                sSQL = "SELECT * FROM SPR_Master WHERE id =" & dSID

            Case objIniFile.GetString("frmDirectory", "MSG37", "Ответственный")

                sSQL = "SELECT * FROM SPR_OTV WHERE id =" & dSID

            Case objIniFile.GetString("frmDirectory", "MSG39", "Филиал")

                sSQL = "SELECT * FROM SPR_FILIAL WHERE id =" & dSID

                rs = New Recordset
                rs.Open(sSQL, DB7, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic)

                With rs

                    chkVisibleSTR.Checked = .Fields("ARHIV").Value

                    cmbName.Text = .Fields("FILIAL").Value

                    If Not IsDBNull(.Fields("A")) Then
                        cmb1.Text = .Fields("A").Value
                    End If

                    If Not IsDBNull(.Fields("B")) Then
                        cmb2.Text = .Fields("B").Value
                    End If

                    If Not IsDBNull(.Fields("prim")) Then
                        txtMemo.Text = .Fields("prim").Value
                    End If

                End With

                rs.Close()
                rs = Nothing

                sREALNAME = cmbName.Text
                btnDirAdd.Text = objIniFile.GetString("frmDirectory", "MSG97", "Сохранить")

                Exit Sub


            Case objIniFile.GetString("frmDirectory", "MSG40", "Отдел")

                sSQL = "SELECT * FROM SPR_OTD_FILIAL WHERE id =" & dSID

                rs = New Recordset
                rs.Open(sSQL, DB7, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic)

                With rs

                    chkVisibleSTR.Checked = .Fields("ARHIV").Value

                    cmbName.Text = .Fields("Filial").Value
                    txtName.Text = .Fields("N_Otd").Value

                    If Not IsDBNull(.Fields("A")) Then
                        cmb1.Text = .Fields("A").Value
                    End If

                    If Not IsDBNull(.Fields("B")) Then
                        cmb2.Text = .Fields("B").Value
                    End If

                    If Not IsDBNull(.Fields("prim")) Then
                        txtMemo.Text = .Fields("prim").Value
                    End If

                End With

                rs.Close()
                rs = Nothing

                sREALNAME = txtName.Text
                btnDirAdd.Text = objIniFile.GetString("frmDirectory", "MSG97", "Сохранить")
                Exit Sub


            Case objIniFile.GetString("frmDirectory", "MSG41", "Кабинет")

                sSQL = "SELECT * FROM SPR_KAB WHERE id =" & dSID

                rs = New Recordset
                rs.Open(sSQL, DB7, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic)

                With rs

                    chkVisibleSTR.Checked = .Fields("ARHIV").Value

                    cmbName.Text = .Fields("N_F").Value
                    cmbName2.Text = .Fields("N_M").Value
                    txtName.Text = .Fields("Name").Value

                    If Not IsDBNull(.Fields("A")) Then
                        cmb1.Text = .Fields("A").Value
                    End If

                    If Not IsDBNull(.Fields("B")) Then
                        cmb2.Text = .Fields("B").Value
                    End If

                    If Not IsDBNull(.Fields("prim")) Then
                        txtMemo.Text = .Fields("prim").Value
                    End If

                End With

                rs.Close()
                rs = Nothing

                sREALNAME = txtName.Text
                btnDirAdd.Text = objIniFile.GetString("frmDirectory", "MSG97", "Сохранить")

                Exit Sub

            Case objIniFile.GetString("frmDirectory", "MSG43", "Уровень заявки")

                sSQL = "SELECT id, uroven as name, proizv, Prim, a, b, c FROM SPR_Uroven WHERE id =" & dSID

            Case objIniFile.GetString("frmDirectory", "MSG44", "Уровень выполнения")

                sSQL = "SELECT * FROM spr_vip WHERE id =" & dSID

            Case objIniFile.GetString("frmDirectory", "MSG45", "Тип заявки")

                sSQL = "SELECT * FROM spr_tip_z WHERE id =" & dSID

            Case objIniFile.GetString("frmDirectory", "MSG47", "Поставщики")

                sSQL = "SELECT * FROM SPR_Postav WHERE id =" & dSID

            Case objIniFile.GetString("frmDirectory", "MSG48", "Производители")

                sSQL = "SELECT * FROM SPR_PROIZV WHERE id =" & dSID

            Case objIniFile.GetString("frmDirectory", "MSG49", "Тип компьютера")

                sSQL = "SELECT * FROM SPR_TIP WHERE id =" & dSID

            Case objIniFile.GetString("frmDirectory", "MSG50", "Модель картриджа")

                sSQL = "SELECT * FROM spr_cart WHERE id =" & dSID

            Case objIniFile.GetString("frmDirectory", "MSG51", "Оборудование (Другое-тип)")

                sSQL = "SELECT * FROM spr_other WHERE id =" & dSID

            Case objIniFile.GetString("frmDirectory", "MSG52", "Оборудование (Другое-устройства)")

                sSQL = "SELECT * FROM SPR_OTH_DEV WHERE id =" & dSID


            Case objIniFile.GetString("frmDirectory", "MSG53", "Тип лицензии")

                sSQL = "SELECT * FROM SPR_LIC WHERE id =" & dSID

            Case objIniFile.GetString("frmDirectory", "MSG54", "Тип программного обеспечения")

                sSQL = "SELECT * FROM SPR_TIP_PO WHERE id =" & dSID

            Case objIniFile.GetString("frmDirectory", "MSG55", "Комплектующие")

                sSQL = "SELECT * FROM SPR_Complect WHERE id =" & dSID

            Case objIniFile.GetString("frmDirectory", "MSG56", "Программное обеспечение")

                sSQL = "SELECT * FROM SPR_PO WHERE id =" & dSID

            Case objIniFile.GetString("frmDirectory", "MSG33", "Корпус")

                sSQL = "SELECT * FROM SPR_CASE WHERE id =" & dSID

            Case objIniFile.GetString("frmDirectory", "MSG24", "Кардридер")

                sSQL = "SELECT * FROM SPR_CREADER WHERE id =" & dSID

            Case objIniFile.GetString("frmDirectory", "MSG31", "Блок питания")

                sSQL = "SELECT * FROM SPR_BP WHERE id =" & dSID

        End Select


        Dim uname As String

        Dim PROYZV As Recordset
        PROYZV = New Recordset


        rs = New Recordset
        rs.Open(sSQL, DB7, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic)

        With rs

            If tvDirectory.SelectedNode.Text = objIniFile.GetString("frmDirectory", "MSG48", "Производители") Then

                cmbName.Text = .Fields("PROIZV").Value
            Else
                cmbName.Text = .Fields("Name").Value

                If Not IsDBNull(.Fields("Proizv").Value) Then uname = .Fields("Proizv").Value
                PROYZV.Open("Select * from SPR_PROIZV WHERE id =" & uname, DB7, CursorTypeEnum.adOpenDynamic,
                            LockTypeEnum.adLockOptimistic)

                With PROYZV
                    If Not IsDBNull(.Fields("Proizv").Value) Then cmbName3.Text = .Fields("Proizv").Value
                End With

                PROYZV.Close()
                PROYZV = Nothing
            End If

            Select Case tvDirectory.SelectedNode.Text

                Case objIniFile.GetString("frmDirectory", "MSG36", "Мастер")

                    If Not IsDBNull(.Fields("A")) Then
                        cmbName2.Text = .Fields("A").Value
                        cmb1.Text = .Fields("B").Value
                    End If

                Case objIniFile.GetString("frmDirectory", "MSG51", "Оборудование (Другое-тип)")

                    If Not IsDBNull(.Fields("A")) Then
                        cmbIcon.Text = .Fields("A").Value
                    End If

                    If Not IsDBNull(.Fields("B")) Then
                        cmb1.Text = .Fields("B").Value
                    End If


                    'Case objIniFile.GetString("frmDirectory", "MSG55", "Комплектующие")

                    '    If Not IsDBNull(.Fields("B")) Then
                    '        cmbIcon.Text = .Fields("B").Value
                    '    End If

                    '    If Not IsDBNull(.Fields("A")) Then
                    '        cmb1.Text = .Fields("A").Value
                    '    End If


                Case objIniFile.GetString("frmDirectory", "MSG56", "Программное обеспечение")

                    If Not IsDBNull(.Fields("A")) Then
                        cmbName2.Text = .Fields("A").Value
                    End If

                Case objIniFile.GetString("frmDirectory", "MSG57", "Пользователь")

                    If Not IsDBNull(.Fields("A")) Then
                        cmbName2.Text = .Fields("A").Value
                    End If


                Case Else

                    If Not IsDBNull(.Fields("A")) Then
                        cmb1.Text = .Fields("A").Value
                    End If
            End Select

            If tvDirectory.SelectedNode.Text = objIniFile.GetString("frmDirectory", "MSG36", "Мастер") Then

                If Not IsDBNull(.Fields("C")) Then
                    cmb2.Text = .Fields("C").Value
                End If

            Else
                If Not IsDBNull(.Fields("B")) Then
                    cmb2.Text = .Fields("B").Value
                End If
            End If


            If _
                tvDirectory.SelectedNode.Text =
                objIniFile.GetString("frmDirectory", "MSG51", "Оборудование (Другое-тип)") Then
                chkCont.Checked = False


                If Not IsDBNull(.Fields("C")) Then

                    Dim A1 As String = .Fields("C").Value


                    Select Case A1

                        Case "1"
                            chkCont.Checked = True

                        Case Else
                            chkCont.Checked = False

                    End Select

                End If

            End If

            If Not IsDBNull(.Fields("prim")) Then
                txtMemo.Text = .Fields("prim").Value
            End If


        End With

        rs.Close()
        rs = Nothing

        sREALNAME = cmbName.Text
        btnDirAdd.Text = objIniFile.GetString("frmDirectory", "MSG97", "Сохранить")
    End Sub

    Private Sub frmDirectory_Resize(ByVal sender As Object, ByVal e As EventArgs) Handles Me.Resize
        'tvDirectory.Height = Me.Height - 65

        'lvDirectory.Height = Me.Height - (gbSpr.Height + 70)
        'gbSpr.Top = lvDirectory.Height + 10

        'gbSpr.Width = Me.Width - (tvDirectory.Width + 20)
        'lvDirectory.Width = Me.Width - (tvDirectory.Width + 20)
    End Sub

    Private Sub cmbName_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) _
        Handles cmbName.SelectedIndexChanged
        On Error GoTo err_
        Dim objIniFile As New IniFile(sLANGPATH)

        If tvDirectory.SelectedNode.Text = objIniFile.GetString("frmDirectory", "MSG41", "Кабинет") Then


            cmbName2.Items.Clear()
            Dim rs1 As Recordset
            rs1 = New Recordset
            rs1.Open("select * from SPR_OTD_FILIAL WHERE Filial='" & cmbName.Text & "' ORDER BY N_Otd", DB7,
                     CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic)
            cmbName2.Items.Clear()
            With rs1
                .MoveFirst()
                Do While Not .EOF

                    If Not IsDBNull(.Fields("N_Otd").Value) Then cmbName2.Items.Add(.Fields("N_Otd").Value)

                    .MoveNext()
                Loop
            End With

            rs1.Close()
            rs1 = Nothing

        End If

        Exit Sub
        err_:
    End Sub

    Private Sub DELETE_SPR(Optional ByVal ssid As Integer = 0)
        'Тут код на удаление

        Dim objIniFile As New IniFile(sLANGPATH)

        If ssid <> 0 Then

            dSID = ssid

        Else

            For z = 0 To lvDirectory.SelectedItems.Count - 1
                dSID = (lvDirectory.SelectedItems(z).Text)
            Next

        End If

        Dim sTABLE As String

        Select Case tvDirectory.SelectedNode.Text

            Case objIniFile.GetString("frmDirectory", "MSG57", "Пользователь")

                '#######################################
                'Пользователь экспериментально
                '#######################################

                sTABLE = "SPR_USER"

            Case objIniFile.GetString("frmDirectory", "MSG27", "Оптические накопители")

                sTABLE = "SPR_OPTICAL"

            Case objIniFile.GetString("frmDirectory", "MSG3", "USB Устройства")

                sTABLE = "SPR_USB"

            Case objIniFile.GetString("frmDirectory", "MSG4", "ZIP")
                
                sTABLE = "spr_zip"

            Case objIniFile.GetString("frmDirectory", "MSG5", "Акустические системы")
                sTABLE = "SPR_ASISTEM"

            Case objIniFile.GetString("frmDirectory", "MSG6", "Источники БП")
                sTABLE = "SPR_IBP"

            Case objIniFile.GetString("frmDirectory", "MSG7", "Клавиатуры")
                sTABLE = "SPR_KEYBOARD"

            Case objIniFile.GetString("frmDirectory", "MSG8", "Копиры")

                sTABLE = "SPR_KOPIR"
            Case objIniFile.GetString("frmDirectory", "MSG34", "Модемы")
                
                sTABLE = "SPR_MODEM"

            Case objIniFile.GetString("frmDirectory", "MSG9", "Мониторы")
                
                sTABLE = "SPR_MONITOR"

            Case objIniFile.GetString("frmDirectory", "MSG10", "МФУ")
                sTABLE = "SPR_MFU"

            Case objIniFile.GetString("frmDirectory", "MSG11", "Мыши")
                
                sTABLE = "SPR_MOUSE"

            Case objIniFile.GetString("frmDirectory", "MSG12", "Принтеры")

                sTABLE = "SPR_PRINTER"

            Case objIniFile.GetString("frmDirectory", "MSG13", "Сетевые фильтры")
                sTABLE = "SPR_FS"

            Case objIniFile.GetString("frmDirectory", "MSG14", "Сетевые устройства")
                
                sTABLE = "SPR_DEV_NET"

            Case objIniFile.GetString("frmDirectory", "MSG15", "Сканер")

                sTABLE = "SPR_SCANER"

            Case objIniFile.GetString("frmDirectory", "MSG16", "Телефон")

                sTABLE = "spr_phone"

            Case objIniFile.GetString("frmDirectory", "MSG17", "Факс")
                
                sTABLE = "spr_fax"

            Case objIniFile.GetString("frmDirectory", "MSG18", "Фотоаппарат")
                
                sTABLE = "spr_photo"
            Case objIniFile.GetString("frmDirectory", "MSG20", "Видео карты")

                sTABLE = "SPR_SVGA"

            Case objIniFile.GetString("frmDirectory", "MSG21", "Дисководы")

                sTABLE = "SPR_FDD"

            Case objIniFile.GetString("frmDirectory", "MSG22", "Жесткие диски")
               
                sTABLE = "SPR_HDD"

            Case objIniFile.GetString("frmDirectory", "MSG23", "Звуковые карты")

                sTABLE = "SPR_SOUND"

            Case objIniFile.GetString("frmDirectory", "MSG25", "Материнские платы")

                sTABLE = "SPR_MB"

            Case objIniFile.GetString("frmDirectory", "MSG26", "Модули памяти")

                sTABLE = "SPR_RAM"

            Case objIniFile.GetString("frmDirectory", "MSG28", "Процессор")

                sTABLE = "SPR_CPU"

            Case objIniFile.GetString("frmDirectory", "MSG29", "Сетевые карты")

                sTABLE = "SPR_NET"

            Case objIniFile.GetString("frmDirectory", "MSG30", "Устройства PCI")

                sTABLE = "SPR_PCI"

            Case objIniFile.GetString("frmDirectory", "MSG37", "Ответственный")

                sTABLE = "SPR_OTV"

            Case objIniFile.GetString("frmDirectory", "MSG39", "Филиал")
                sTABLE = "0"
                RemoveBrainch(dSID, lvDirectory.Items.Item(lvDirectory.FocusedItem.Index).SubItems(1).Text)

            Case objIniFile.GetString("frmDirectory", "MSG40", "Отдел")
                sTABLE = "0"
                RemoveDepartment(dSID)

            Case objIniFile.GetString("frmDirectory", "MSG41", "Кабинет")
                sTABLE = "0"
                RemoveOffice(dSID)

            Case objIniFile.GetString("frmDirectory", "MSG43", "Уровень заявки")
                
                sTABLE = "SPR_Uroven"
            Case objIniFile.GetString("frmDirectory", "MSG44", "Уровень выполнения")
                
                sTABLE = "spr_vip"
            Case objIniFile.GetString("frmDirectory", "MSG45", "Тип заявки")
                
                sTABLE = "spr_tip_z"
            Case objIniFile.GetString("frmDirectory", "MSG47", "Поставщики")
               
                sTABLE = "SPR_Postav"
            Case objIniFile.GetString("frmDirectory", "MSG48", "Производители")
                sTABLE = "0"
                Call RemoveProyzv(dSID)

            Case objIniFile.GetString("frmDirectory", "MSG49", "Тип компьютера")
               
                sTABLE = "SPR_TIP"
            Case objIniFile.GetString("frmDirectory", "MSG50", "Модель картриджа")
               
                sTABLE = "spr_cart"
            Case objIniFile.GetString("frmDirectory", "MSG51", "Оборудование (Другое-тип)")
               
                sTABLE = "spr_other"
            Case objIniFile.GetString("frmDirectory", "MSG52", "Оборудование (Другое-устройства)")
               
                sTABLE = "SPR_OTH_DEV"
            Case objIniFile.GetString("frmDirectory", "MSG53", "Тип лицензии")
                
                sTABLE = "SPR_LIC"
            Case objIniFile.GetString("frmDirectory", "MSG54", "Тип программного обеспечения")
                
                sTABLE = "SPR_TIP_PO"
            Case objIniFile.GetString("frmDirectory", "MSG55", "Комплектующие")
                
                sTABLE = "SPR_Complect"
            Case objIniFile.GetString("frmDirectory", "MSG56", "Программное обеспечение")
               
                sTABLE = "SPR_PO"
            Case objIniFile.GetString("frmDirectory", "MSG33", "Корпус")
                
                sTABLE = "SPR_CASE"
            Case objIniFile.GetString("frmDirectory", "MSG24", "Кардридер")
                
                sTABLE = "SPR_CREADER"
            Case objIniFile.GetString("frmDirectory", "MSG31", "Блок питания")
                
                sTABLE = "SPR_BP"
            Case objIniFile.GetString("frmDirectory", "MSG36", "Мастер")
              
                sTABLE = "SPR_Master"
        End Select

        Select Case sTABLE

            Case "0"

            Case Else
                DB7.Execute("Delete FROM " & sTABLE & " WHERE id =" & dSID)

        End Select


        btnDirAdd.Text = objIniFile.GetString("frmDirectory", "btnDirAdd", "Добавить")
    End Sub


    Private Sub lvDirectory_MouseUp(ByVal sender As Object, ByVal e As MouseEventArgs) Handles lvDirectory.MouseUp
    End Sub

    Private Sub lvDirectory_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) _
        Handles lvDirectory.SelectedIndexChanged
        'Call Load_SPR_TO_EDIT()
    End Sub

    Private Sub cmbIcon_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) _
        Handles cmbIcon.SelectedIndexChanged
        'pbOtherICO.Image=

        Dim s1 As Integer
        s1 = cmbIcon.Text
        'frmComputers.ilsCommands.ImageSize = New System.Drawing.Size(32, 32)


        'Select Case sICONS

        '    Case "32*32"

        '        pbOtherICO.Image = frmComputers.ImageList11.Images(s1)

        '    Case Else

        '        pbOtherICO.Image = frmComputers.ilsCommands.Images(s1)

        'End Select

        pbOtherICO.Image = frmComputers.ilsCommands.Images(s1)

        'frmMain.imglist_cont.ListImages(s1).Picture
    End Sub

    Private Sub Button3_Click(ByVal sender As Object, ByVal e As EventArgs) Handles Button3.Click
        Me.Cursor = Cursors.WaitCursor

        Call LoadSPR()

        Me.Cursor = Cursors.Default
        Me.Close()
    End Sub

    Private Sub btnCancell_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnCancell.Click
        Dim objIniFile As New IniFile(sLANGPATH)
        eDTI = False

        btnDirAdd.Text = objIniFile.GetString("frmDirectory", "btnDirAdd", "Добавить")

        cmbName.Text = ""
        cmbName2.Text = ""
        txtName.Text = ""
        cmbName3.Text = ""
        txtMemo.Text = ""
        cmb1.Text = ""
        cmb2.Text = ""
        cmbIcon.Text = ""
        chkVisibleSTR.Checked = False
    End Sub

    Private Sub btnDirAdd_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnDirAdd.Click
        On Error GoTo Err_

        Dim sTABLE As String
        Dim sFields As String

        lvDirectory.Sorting = SortOrder.None
        lvDirectory.ListViewItemSorter = Nothing

        'Тут код редактирования, добавления
        If Len(cmbName.Text) = 0 Then Exit Sub

        Dim sSQL As String
        Dim sPRID As String
        Dim sNAME As String
        Dim sPRIM As String
        Dim sPAR1 As String
        Dim sPAR2 As String
        Dim sPAR3 As String

        Dim objIniFile As New IniFile(sLANGPATH)

        If _
            tvDirectory.SelectedNode.Text = objIniFile.GetString("frmDirectory", "MSG47", "Поставщики") Or
            tvDirectory.SelectedNode.Text = objIniFile.GetString("frmDirectory", "MSG39", "Филиал") Or
            tvDirectory.SelectedNode.Text = objIniFile.GetString("frmDirectory", "MSG40", "Отдел") Or
            tvDirectory.SelectedNode.Text = objIniFile.GetString("frmDirectory", "MSG41", "Кабинет") Or
            tvDirectory.SelectedNode.Text = objIniFile.GetString("frmDirectory", "MSG48", "Производители") Or
            tvDirectory.SelectedNode.Text = objIniFile.GetString("frmDirectory", "MSG36", "Мастер") Or
            tvDirectory.SelectedNode.Text = objIniFile.GetString("frmDirectory", "MSG37", "Ответственный") Then

        Else
            If Len(cmbName3.Text) = 0 Then cmbName3.Text = "NoName"

            If Not (RSExists("PROYZV", "PROiZV", cmbName3.Text)) Then
                AddPr(cmbName3.Text)
            End If

            Dim rs1 As Recordset
            rs1 = New Recordset

            rs1.Open("SELECT * FROM SPR_PROIZV WHERE PROIZV='" & cmbName3.Text & "'", DB7, CursorTypeEnum.adOpenDynamic,
                     LockTypeEnum.adLockOptimistic)

            With rs1

                sPRID = .Fields("ID").Value

            End With
            rs1.Close()
            rs1 = Nothing

        End If

        sNAME = cmbName.Text
        sPRIM = txtMemo.Text
        sPAR1 = cmb1.Text
        sPAR2 = cmb2.Text
        sPAR3 = ""

        Dim rs As Recordset

        Select Case tvDirectory.SelectedNode.Text

            Case objIniFile.GetString("frmDirectory", "MSG57", "Пользователь")

                '#######################################
                'Пользователь экспериментально
                '#######################################

                sTABLE = "SPR_USER"

                sPAR1 = cmbName2.Text

            Case objIniFile.GetString("frmDirectory", "MSG27", "Оптические накопители")

                sTABLE = "SPR_OPTICAL"

            Case objIniFile.GetString("frmDirectory", "MSG3", "USB Устройства")

                sTABLE = "SPR_USB"

            Case objIniFile.GetString("frmDirectory", "MSG4", "ZIP")

                sTABLE = "spr_zip"

            Case objIniFile.GetString("frmDirectory", "MSG5", "Акустические системы")

                sTABLE = "SPR_ASISTEM"

            Case objIniFile.GetString("frmDirectory", "MSG6", "Источники БП")

                sTABLE = "SPR_IBP"

            Case objIniFile.GetString("frmDirectory", "MSG7", "Клавиатуры")

                sTABLE = "SPR_KEYBOARD"

            Case objIniFile.GetString("frmDirectory", "MSG8", "Копиры")

                sTABLE = "SPR_KOPIR"

            Case objIniFile.GetString("frmDirectory", "MSG34", "Модемы")

                sTABLE = "SPR_MODEM"

            Case objIniFile.GetString("frmDirectory", "MSG9", "Мониторы")

                sTABLE = "SPR_MONITOR"

            Case objIniFile.GetString("frmDirectory", "MSG10", "МФУ")

                sTABLE = "SPR_MFU"

            Case objIniFile.GetString("frmDirectory", "MSG11", "Мыши")

                sTABLE = "SPR_MOUSE"

            Case objIniFile.GetString("frmDirectory", "MSG12", "Принтеры")

                sTABLE = "SPR_PRINTER"

            Case objIniFile.GetString("frmDirectory", "MSG13", "Сетевые фильтры")

                sTABLE = "SPR_FS"

            Case objIniFile.GetString("frmDirectory", "MSG14", "Сетевые устройства")

                sTABLE = "SPR_DEV_NET"

            Case objIniFile.GetString("frmDirectory", "MSG15", "Сканер")

                sTABLE = "SPR_SCANER"

            Case objIniFile.GetString("frmDirectory", "MSG16", "Телефон")

                sTABLE = "spr_phone"

            Case objIniFile.GetString("frmDirectory", "MSG17", "Факс")

                sTABLE = "spr_fax"

            Case objIniFile.GetString("frmDirectory", "MSG18", "Фотоаппарат")

                sTABLE = "spr_photo"

            Case objIniFile.GetString("frmDirectory", "MSG20", "Видео карты")

                sTABLE = "SPR_SVGA"

            Case objIniFile.GetString("frmDirectory", "MSG21", "Дисководы")

                sTABLE = "SPR_FDD"

            Case objIniFile.GetString("frmDirectory", "MSG22", "Жесткие диски")

                sTABLE = "SPR_HDD"

            Case objIniFile.GetString("frmDirectory", "MSG23", "Звуковые карты")

                sTABLE = "SPR_SOUND"

            Case objIniFile.GetString("frmDirectory", "MSG25", "Материнские платы")

                sTABLE = "SPR_MB"

            Case objIniFile.GetString("frmDirectory", "MSG26", "Модули памяти")

                sTABLE = "SPR_RAM"

            Case objIniFile.GetString("frmDirectory", "MSG28", "Процессор")

                sTABLE = "SPR_CPU"

            Case objIniFile.GetString("frmDirectory", "MSG29", "Сетевые карты")

                sTABLE = "SPR_NET"

            Case objIniFile.GetString("frmDirectory", "MSG30", "Устройства PCI")

                sTABLE = "SPR_PCI"

            Case objIniFile.GetString("frmDirectory", "MSG36", "Мастер")

                sTABLE = "SPR_Master"

                sPAR1 = cmbName2.Text
                sPAR2 = cmb1.Text
                sPAR3 = cmb2.Text

                Dim rscount As Recordset
                rscount = New Recordset
                rscount.Open("SELECT COUNT(*) AS total_number FROM Remont where master ='" & sREALNAME & "'", DB7,
                             CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic)

                Dim sNUM As Decimal
                With rscount
                    sNUM = .Fields("total_number").Value
                End With
                rscount.Close()
                rscount = Nothing

                If sNUM > 0 Then

                    DB7.Execute("UPDATE Remont SET master='" & sNAME & "' WHERE master='" & sREALNAME & "'")

                End If

                rscount = New Recordset
                rscount.Open("SELECT COUNT(*) AS total_number FROM Zametki where master ='" & sREALNAME & "'", DB7,
                             CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic)

                With rscount
                    sNUM = .Fields("total_number").Value
                End With
                rscount.Close()
                rscount = Nothing

                If sNUM > 0 Then

                    DB7.Execute("UPDATE Zametki SET master='" & sNAME & "' WHERE master='" & sREALNAME & "'")

                End If

                rscount = New Recordset
                rscount.Open("SELECT COUNT(*) AS total_number FROM ZAM_OTD where master ='" & sREALNAME & "'", DB7,
                             CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic)

                With rscount
                    sNUM = .Fields("total_number").Value
                End With
                rscount.Close()
                rscount = Nothing

                If sNUM > 0 Then

                    DB7.Execute("UPDATE ZAM_OTD SET master='" & sNAME & "' WHERE master='" & sREALNAME & "'")

                End If

                rscount = New Recordset
                rscount.Open("SELECT COUNT(*) AS total_number FROM remonty_plus where master ='" & sREALNAME & "'", DB7,
                             CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic)

                With rscount
                    sNUM = .Fields("total_number").Value
                End With
                rscount.Close()
                rscount = Nothing

                If sNUM > 0 Then

                    DB7.Execute("UPDATE remonty_plus SET master='" & sNAME & "' WHERE master='" & sREALNAME & "'")

                End If

            Case objIniFile.GetString("frmDirectory", "MSG37", "Ответственный")

                sTABLE = "SPR_OTV"

                If eDTI = False Then

                Else

                    Dim rscount As Recordset
                    Dim sNUM As Decimal
                    rscount = New Recordset
                    rscount.Open("SELECT COUNT(*) AS total_number FROM kompy where OTvetstvennyj ='" & sREALNAME & "'",
                                 DB7, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic)

                    With rscount
                        sNUM = .Fields("total_number").Value
                    End With
                    rscount.Close()
                    rscount = Nothing

                    If sNUM > 0 Then

                        DB7.Execute("UPDATE kompy SET OTvetstvennyj='" & sNAME & "' WHERE OTvetstvennyj='" & sREALNAME & "'")

                    End If

                End If

                'Добавить код проверяющий в оргтехники ответственного

            Case objIniFile.GetString("frmDirectory", "MSG39", "Филиал")

                sTABLE = "0"

                If eDTI = False Then

                    If Not (RSExists("FILIAL", "FILIAL", cmbName.Text)) Then
                        AddOnePar(Me.cmbName.Text, "FILIAL", "SPR_FILIAL", Me.cmbName)
                        Select Case TREE_UPDATE
                            Case 0
                                Call RefFilTree(frmComputers.lstGroups)
                            Case 1
                                Add_FILIAL_TREE(cmbName.Text)
                        End Select
                    End If

                Else

                    Dim Sck As String
                    If chkVisibleSTR.Checked = False Then
                        Sck = 0
                    Else
                        Sck = 1
                    End If

                    Dim rs1 As Recordset
                    rs1 = New Recordset
                    rs1.Open(
                        "UPDATE SPR_FILIAL SET filial='" & LTrim(cmbName.Text) & "', Prim='" & txtMemo.Text & "', A ='" &
                        cmb1.Text & "', B ='" & cmb2.Text & "', C='" & "', ARHIV=" & Sck & " WHERE ID=" & dSID, DB7,
                        CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic)
                    rs1 = Nothing

                    Dim rscount As Recordset
                    rscount = New Recordset
                    rscount.Open("SELECT COUNT(*) AS total_number FROM kompy where filial ='" & sREALNAME & "'", DB7,
                                 CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic)
                    Dim sNUM As Decimal
                    With rscount
                        sNUM = .Fields("total_number").Value
                    End With
                    rscount.Close()
                    rscount = Nothing

                    If sNUM > 0 Then
                        rscount = New Recordset
                        rscount.Open("UPDATE kompy SET filial='" & sNAME & "' WHERE filial='" & sREALNAME & "'", DB7,
                                     CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic)
                        rscount = Nothing

                        rscount = New Recordset
                        rscount.Open("UPDATE SPR_OTD_FILIAL SET filial='" & sNAME & "' WHERE filial='" & sREALNAME & "'",
                                     DB7, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic)
                        rscount = Nothing

                        rscount = New Recordset
                        rscount.Open("UPDATE SPR_KAB SET N_F='" & sNAME & "' WHERE N_F='" & sREALNAME & "'", DB7,
                                     CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic)
                        rscount = Nothing

                    End If

                End If

                Call LOAD_LIST_SPR()

            btnDirAdd.Text = objIniFile.GetString("frmDirectory", "btnDirAdd", "Добавить")
                eDTI = False
                Exit Sub

            Case objIniFile.GetString("frmDirectory", "MSG40", "Отдел")

                sTABLE = "0"

                If eDTI = False Then

                    If Not (RSExistsDB(cmbName.Text, txtName.Text)) Then
                        AddDepartment(cmbName.Text, txtName.Text)
                        Select Case TREE_UPDATE
                            Case 0
                                Call RefFilTree(frmComputers.lstGroups)
                            Case 1
                                Add_OTDEL_TREE(cmbName.Text, txtName.Text)
                        End Select
                    End If

                Else

                    Dim Sck As String
                    If chkVisibleSTR.Checked = False Then
                        Sck = 0
                    Else
                        Sck = 1
                    End If

                    Dim rs1 As Recordset
                    rs1 = New Recordset
                    rs1.Open(
                        "UPDATE SPR_OTD_FILIAL SET N_Otd='" & LTrim(txtName.Text) & "', Filial='" & LTrim(cmbName.Text) &
                        "', Prim='" & txtMemo.Text & "', A ='" & cmb1.Text & "', B ='" & cmb2.Text & "', C='" &
                        "', ARHIV=" & Sck & " WHERE ID=" & dSID, DB7, CursorTypeEnum.adOpenDynamic,
                        LockTypeEnum.adLockOptimistic)
                    rs1 = Nothing

                    Dim rscount As Recordset
                    rscount = New Recordset
                    rscount.Open(
                        "SELECT COUNT(*) AS total_number FROM kompy where mesto ='" & sREALNAME & "' and filial ='" &
                        LTrim(cmbName.Text) & "'", DB7, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic)
                    Dim sNUM As String
                    With rscount
                        sNUM = .Fields("total_number").Value
                    End With
                    rscount.Close()
                    rscount = Nothing

                    If sNUM > 0 Then
                        rscount = New Recordset
                        rscount.Open(
                            "UPDATE kompy SET mesto='" & LTrim(txtName.Text) & "' WHERE mesto='" & sREALNAME &
                            "' and filial ='" & LTrim(cmbName.Text) & "'", DB7, CursorTypeEnum.adOpenDynamic,
                            LockTypeEnum.adLockOptimistic)
                        rscount = Nothing

                        rscount = New Recordset
                        rscount.Open(
                            "UPDATE SPR_KAB SET N_M='" & LTrim(txtName.Text) & "' WHERE N_M='" & sREALNAME &
                            "' AND N_F='" & LTrim(cmbName.Text) & "'", DB7, CursorTypeEnum.adOpenDynamic,
                            LockTypeEnum.adLockOptimistic)
                        rscount = Nothing

                    End If

                End If

                Call LOAD_LIST_SPR()
              
                btnDirAdd.Text = objIniFile.GetString("frmDirectory", "btnDirAdd", "Добавить")
                eDTI = False
                Exit Sub

            Case objIniFile.GetString("frmDirectory", "MSG41", "Кабинет")

                sTABLE = "0"

                If eDTI = False Then

                    If Not (RSExistsDBO(cmbName.Text, cmbName2.Text, txtName.Text)) Then
                        AddOffice(cmbName.Text, cmbName2.Text, txtName.Text)
                        Select Case TREE_UPDATE
                            Case 0
                                Call RefFilTree(frmComputers.lstGroups)
                            Case 1
                                Add_KABINET_TREE(cmbName.Text, cmbName2.Text, txtName.Text)
                        End Select
                    End If

                Else

                    Dim rs1 As Recordset
                    rs1 = New Recordset

                    Dim Sck As String
                    If chkVisibleSTR.Checked = False Then
                        Sck = 0
                    Else
                        Sck = 1
                    End If

                    rs1.Open(
                        "UPDATE SPR_KAB SET Name='" & LTrim(txtName.Text) & "', N_M='" & LTrim(cmbName2.Text) &
                        "', N_F='" & LTrim(cmbName.Text) & "', Prim='" & txtMemo.Text & "', A ='" & cmb1.Text &
                        "', B ='" & cmb2.Text & "', C='" & "', ARHIV=" & Sck & " WHERE ID=" & dSID, DB7,
                        CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic)
                    rs1 = Nothing

                    Dim rscount As Recordset
                    rscount = New Recordset
                    rscount.Open(
                        "SELECT COUNT(*) AS total_number FROM kompy where kabn ='" & sREALNAME & "' and filial ='" &
                        LTrim(cmbName.Text) & "' and mesto ='" & LTrim(cmbName2.Text) & "'", DB7,
                        CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic)
                    Dim sNUM As String
                    With rscount
                        sNUM = .Fields("total_number").Value
                    End With
                    rscount.Close()
                    rscount = Nothing

                    If sNUM > 0 Then
                        rscount = New Recordset
                        rscount.Open(
                            "UPDATE kompy SET kabn='" & txtName.Text & "' WHERE kabn='" & sREALNAME & "' and filial ='" &
                            LTrim(cmbName.Text) & "' and mesto ='" & LTrim(cmbName2.Text) & "'", DB7,
                            CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic)
                        rscount = Nothing
                    End If


                End If


                Call LOAD_LIST_SPR()
                
                btnDirAdd.Text = objIniFile.GetString("frmDirectory", "btnDirAdd", "Добавить")
                eDTI = False

                Exit Sub

            Case objIniFile.GetString("frmDirectory", "MSG43", "Уровень заявки")

                sTABLE = "0"

                If eDTI = False Then
                    sSQL = "INSERT INTO " & sTABLE & " (uroven,Proizv,A,B,C) VALUES ('" & LTrim(sNAME) & "'," & sPRID & ",'" & sPAR1 & "','" & sPAR2 & "','" & sPAR3 & "')"
                Else
                    sSQL = "UPDATE " & sTABLE & " SET " &
                        "uroven='" & LTrim(sNAME) & "'," &
                        "Proizv=" & sPRID & "," &
                        "A='" & LTrim(sPAR1) & "'," &
                        "B='" & LTrim(sPAR2) & "'," &
                        "C='" & LTrim(sPAR3) & "'," & "WHERE id = " & dSID
                End If

                DB7.Execute(sSQL)

                Call LOAD_LIST_SPR()

                btnDirAdd.Text = objIniFile.GetString("frmDirectory", "btnDirAdd", "Добавить")
                eDTI = False

                Exit Sub


            Case objIniFile.GetString("frmDirectory", "MSG44", "Уровень выполнения")

                sTABLE = "spr_vip"

            Case objIniFile.GetString("frmDirectory", "MSG45", "Тип заявки")

                sTABLE = "spr_tip_z"

            Case objIniFile.GetString("frmDirectory", "MSG47", "Поставщики")

                sTABLE = "SPR_Postav"

            Case objIniFile.GetString("frmDirectory", "MSG48", "Производители")

                sTABLE = "0"
cmbName.Text = Replace(cmbName.Text, "'", "") 'esq
                If eDTI = False Then

                    If Not (RSExists("PROYZV", "PROiZV", cmbName.Text)) Then
                        AddPr(cmbName.Text)
                    End If

                Else
                    sSQL = "SELECT * FROM SPR_PROIZV WHERE id =" & dSID

                    Dim rs1 As Recordset
                    rs1 = New Recordset
                    rs1.Open(
                        "UPDATE SPR_PROIZV SET PROIZV='" & LTrim(cmbName.Text) & "', Prim='" & txtMemo.Text & "', A ='" &
                        cmb1.Text & "', B ='" & cmb2.Text & "', C='" & " ' WHERE ID=" & dSID, DB7,
                        CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic)
                    rs1 = Nothing

                End If

                GoTo Ar

            Case objIniFile.GetString("frmDirectory", "MSG49", "Тип компьютера")

                sTABLE = "SPR_TIP"

            Case objIniFile.GetString("frmDirectory", "MSG50", "Модель картриджа")

                sTABLE = "spr_cart"

            Case objIniFile.GetString("frmDirectory", "MSG51", "Оборудование (Другое-тип)")

                sTABLE = "spr_other"

                If eDTI = False Then

                Else


                    Dim rs1 As Recordset
                    rs1 = New Recordset
                    rs1.Open("UPDATE SPR_OTH_DEV SET A='" & LTrim(sNAME) & "' WHERE A='" & sREALNAME & "'", DB7,
                             CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic)
                    rs1 = Nothing

                    rs1 = New Recordset
                    rs1.Open(
                        "UPDATE kompy SET TIP_COMPA='" & LTrim(sNAME) & "' WHERE TIP_COMPA='" & sREALNAME &
                        "' and TipTehn='OT'", DB7, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic)
                    rs1 = Nothing

                End If

                sPAR1 = cmbIcon.Text
                sPAR2 = cmb1.Text
                If Len(sPAR2) = 0 Then sPAR2 = "SPR_OTH_DEV"


                If chkCont.Checked = True Then sPAR3 = 1 Else sPAR3 = ""


            Case objIniFile.GetString("frmDirectory", "MSG52", "Оборудование (Другое-устройства)")

                sTABLE = "SPR_OTH_DEV"

                If Not (RSExists("COMPL", "Name", cmb1.Text)) Then
                    AddOnePar(cmb1.Text, "Name", "SPR_Complect", cmb1)
                End If

            Case objIniFile.GetString("frmDirectory", "MSG53", "Тип лицензии")

                sTABLE = "SPR_LIC"

            Case objIniFile.GetString("frmDirectory", "MSG54", "Тип программного обеспечения")


                sTABLE = "SPR_TIP_PO"

                If eDTI = False Then

                Else

                    Dim rscount As Recordset
                    rscount = New Recordset
                    rscount.Open("SELECT count(*) as t_n from SPR_PO Where A ='" & sREALNAME & "'", DB7,
                                 CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic)

                    Dim sCCC As String

                    With rscount

                        sCCC = .Fields("t_n").Value

                    End With
                    rscount.Close()
                    rscount = Nothing

                    If sCCC > 0 Then

                        rscount = New Recordset
                        rscount.Open("UPDATE SPR_PO SET A='" & sNAME & "' WHERE A='" & sREALNAME & "'", DB7,
                                     CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic)
                        rscount = Nothing

                    End If


                End If


            Case objIniFile.GetString("frmDirectory", "MSG55", "Комплектующие")

                sTABLE = "SPR_Complect"

            Case objIniFile.GetString("frmDirectory", "MSG56", "Программное обеспечение")

                sTABLE = "SPR_PO"

                If Not (RSExists("TIPPO", "Name", cmbName2.Text)) Then

                    AddOnePar(cmbName2.Text, "Name", "SPR_TIP_PO", cmbName2)

                End If

                sPAR1 = cmbName2.Text


            Case objIniFile.GetString("frmDirectory", "MSG24", "Кардридер")

                sTABLE = "SPR_CREADER"

            Case objIniFile.GetString("frmDirectory", "MSG31", "Блок питания")

                sTABLE = "SPR_BP"

            Case objIniFile.GetString("frmDirectory", "MSG33", "Корпус")

                sTABLE = "SPR_CASE"

        End Select

        If Len(sPAR1) = 0 Then sPAR1 = ""
        If Len(sPAR2) = 0 Then sPAR2 = ""
        If Len(sPAR3) = 0 Then sPAR3 = ""
        If Len(sPRIM) = 0 Then sPRIM = ""
        If Len(sPRID) = 0 Then sPRID = 0


        'Новая функция сохранения\обновления

        If sTABLE = "0" Then GoTo Ar

        Select Case tvDirectory.SelectedNode.Text
            Case objIniFile.GetString("frmDirectory", "MSG49", "Тип компьютера")
                sFields = "Tip"
            Case Else
                sFields = "Name"
        End Select

        If _
                tvDirectory.SelectedNode.Text = objIniFile.GetString("frmDirectory", "MSG53", "Тип лицензии") Or
                tvDirectory.SelectedNode.Text = objIniFile.GetString("frmDirectory", "MSG45", "Тип заявки") Or
                tvDirectory.SelectedNode.Text = objIniFile.GetString("frmDirectory", "MSG44", "Уровень выполнения") Or
                tvDirectory.SelectedNode.Text = objIniFile.GetString("frmDirectory", "MSG43", "Уровень заявки") Or
                tvDirectory.SelectedNode.Text =
                objIniFile.GetString("frmDirectory", "MSG54", "Тип программного обеспечения") Then

            Select eDTI

                Case False
                    sSQL = "INSERT INTO " & sTABLE & " (" & sFields & ",Prim) VALUES ('" & LTrim(sNAME) & "','" & sPRIM & "')"

                Case True
                    sSQL = "UPDATE " & sTABLE & " SET " &
                    sFields & "='" & LTrim(sNAME) & "'," &
                    "Prim='" & LTrim(sPRIM) & "'" & "WHERE id = " & dSID

            End Select

        Else

            If Len(sPAR1) = 0 Then sPAR1 = "-"
            If Len(sPAR2) = 0 Then sPAR2 = "-"
            If Len(sPAR3) = 0 Then sPAR3 = "-"
            If Len(sPRIM) = 0 Then sPRIM = "-"

            Select Case eDTI

                Case False

                    sSQL = "INSERT INTO " & sTABLE & " (" & sFields & ",Proizv,A,B,C,Prim) VALUES ('" & LTrim(sNAME) & "'," & sPRID & ",'" & sPAR1 & "','" & sPAR2 & "','" & sPAR3 & "','" & sPRIM & "')"

                Case True

                    sSQL = "UPDATE " & sTABLE & " SET " &
                    sFields & "='" & LTrim(sNAME) & "'," &
                   "Proizv=" & sPRID & "," &
                   "A='" & LTrim(sPAR1) & "'," &
                   "B='" & LTrim(sPAR2) & "'," &
                   "C='" & LTrim(sPAR3) & "'," &
                   "Prim='" & LTrim(sPRIM) & "'" & "WHERE id = " & dSID

                    'esq **********
                    If sTABLE = "SPR_PO" Then
                        Dim rs2 As Recordset
                        rs2 = New Recordset
                        rs2.Open("SELECT * FROM SPR_PROIZV WHERE ID=" & sPRID, DB7, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic)
                        Dim S_PROIZV As String
                        S_PROIZV = rs2.Fields("PROIZV").Value
                        rs2.Close()
                        rs2 = Nothing

                        rs2 = New Recordset
                        rs2.Open("SELECT * FROM SOFT_INSTALL WHERE Soft='" & LTrim(sNAME) & "'", DB7, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic)
                        With rs2
                            .MoveFirst()
                            Do While Not .EOF
                                .Fields("Publisher").Value = S_PROIZV
                                .Fields("TIP").Value = LTrim(sPAR1)
                                .Update()
                                .MoveNext()
                            Loop
                        End With
                        rs2.Close()
                        rs2 = Nothing
                    End If
                    'esq **********
            End Select

        End If

        DB7.Execute(sSQL)

 curr = lvDirectory.FocusedItem.Index 'esq
Ar:
        Me.BeginInvoke(New MethodInvoker(AddressOf LOAD_LIST_SPR))
        ' Call LOAD_LIST_SPR()

        btnDirAdd.Text = objIniFile.GetString("frmDirectory", "btnDirAdd", "Добавить")
        eDTI = False

        Exit Sub
Err_:
6:      MsgBox(Err.Description)
    End Sub

    Private Sub Button2_Click(ByVal sender As Object, ByVal e As EventArgs) Handles Button2.Click

        For z = 0 To lvDirectory.SelectedItems.Count - 1
            dSID = (lvDirectory.SelectedItems(z).Text)
        Next


        Dim intj As Integer = 0
        Dim intj1 As Integer = 0

        lvDirectory.Select()

        'If CheckBox2.Checked = False Then

        '    Call DELETE_SPR(dSID)
        '    Call LOAD_LIST_SPR()
        '    Exit Sub

        'End If


        For intj = 0 To lvDirectory.Items.Count - 1

            lvDirectory.Items(intj).Selected = True
            lvDirectory.Items(intj).EnsureVisible()

            If lvDirectory.Items(intj).Checked = True Then

                intj1 = intj1 + 1

            End If

        Next

        If intj1 > 0 Then

            lvDirectory.Select()

            For intj = 0 To lvDirectory.Items.Count - 1

                lvDirectory.Items(intj).Selected = True
                lvDirectory.Items(intj).EnsureVisible()

                If lvDirectory.Items(intj).Checked = True Then

                    Call DELETE_SPR(lvDirectory.SelectedItems(intj).Text)

                End If

            Next

        Else

            Call DELETE_SPR(dSID)

        End If


        Call LOAD_LIST_SPR()


        eDTI = False
    End Sub

    Private Sub CheckBox2_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox2.CheckedChanged

        If CheckBox2.Checked = True Then
            lvDirectory.CheckBoxes = True
            lvDirectory.MultiSelect = True
        End If

        If CheckBox2.Checked = False Then
            lvDirectory.CheckBoxes = False
            lvDirectory.MultiSelect = False
        End If
    End Sub

    Private Sub ToolStripButton1_Click(sender As Object, e As EventArgs) Handles ToolStripButton1.Click
        dSID = 0

        If lvDirectory.Items.Count = 0 Then Exit Sub

        For z = 0 To lvDirectory.SelectedItems.Count - 1
            dSID = (lvDirectory.SelectedItems(z).Text)
        Next

        If cmbName.Text = "" Or Len(cmbName.Text) = 0 Then Exit Sub

        If dSID = 0 Then Exit Sub


        frmDev.sTIPtehn = "IBP"

        frmDev.ShowDialog(Me)
    End Sub

End Class