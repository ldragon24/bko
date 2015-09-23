Imports System.IO
Imports Microsoft.Office.Interop.Word
Imports XlBorderWeight = Microsoft.Office.Interop.Excel.XlBorderWeight
Imports XlColorIndex = Microsoft.Office.Interop.Excel.XlColorIndex
Imports XlLineStyle = Microsoft.Office.Interop.Excel.XlLineStyle

Module MOD_OPENOFFICE
    Public oSheet As Object

    Sub insertIntoCell(ByVal strCellName, ByVal strText, ByVal objTable)
        Dim objCellText, objCellCursor As Object ' objects from OOo API 

        objCellText = objTable.getCellByName(strCellName)
        objCellCursor = objCellText.createTextCursor
        objCellCursor.setPropertyValue("CharColor", 0)
        objCellText.insertString(objCellCursor, strText, False)
    End Sub

    Public Sub OOO_SEND_PK(ByVal sID As String)
        On Error Resume Next
        Dim LNGIniFile As New IniFile(sLANGPATH)

        Dim rs As Recordset
        Dim rs1 As Recordset
        Dim sSQL, sSQL1, scN, cOTV As String

        Dim iA As String
        Dim iB As String
        Dim iC As String
        Dim iD As String
        Dim iE As String

        Call COUNT_FIELDS(sID)

        sSQL = "SELECT * FROM kompy WHERE TipTehn='PC' AND id=" & sID


        rs = New Recordset
        rs.Open(sSQL, DB7, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic)

        Dim oSM As Object                 'Root object for accessing OpenOffice FROM VB
        Dim oDesk, oDoc As Object 'First objects FROM the API
        Dim arg(- 1) As Object                 'Ignore it for the moment !
        Dim mmerge As Object
        Dim objCoreReflection As Object ' objects from OOo API 

        'Instanciate OOo : this line is mandatory with VB for OOo API
        oSM = CreateObject("com.sun.star.ServiceManager")
        'Create the first and most important service
        objCoreReflection = oSM.createInstance("com.sun.star.reflection.CoreReflection")

        oDesk = oSM.createInstance("com.sun.star.frame.Desktop")
        'Create a new doc

        oDoc = oDesk.loadComponentFROMURL("private:factory/swriter", "_blank", 0, arg)

        ' jon code
        Dim objText As Object, objCursor As Object

        Dim objTable As Object ' objects from OOo API 
        Dim objRows, objRow As Object

        objText = oDoc.GetText
        objCursor = objText.createTextCursor

        ' replace all
        Dim oSrch As Object

        Dim CONFIGURE As Recordset

        Dim tiptehCP, uname, QWERT As String
        Dim GIST As Decimal = 0
        Dim intj As Decimal = 0

        With rs
            .MoveFirst()
            Do While Not .EOF
                tiptehCP = .Fields("TipTehn").Value
                GIST = 0

                objText.insertString(objCursor, " " & vbLf, False)
                objCursor.setPropertyValue("CharColor", 255)
                objCursor.setPropertyValue("CharShadowed", True)

                objText.insertString(objCursor,
                                     LNGIniFile.GetString("MOD_OPENOFFICE", "MSG1", "Паспорт компьютера №") & ": " & sID &
                                     vbLf, False)
                objText.insertControlCharacter(objCursor, 0, False)

                objTable = oDoc.createInstance("com.sun.star.text.TextTable")
                objTable.Initialize(7, 2)

                'Insert the table
                objText.insertTextContent(objCursor, objTable, False)

                'Get first row
                objRows = objTable.GetRows
                objRow = objRows.getByIndex(0)

                'Set the table background color
                objTable.setPropertyValue("BackTransparent", False)
                objTable.setPropertyValue("BackColor", 16777215)

                'Set a different background color for the first row
                objRow.setPropertyValue("BackTransparent", False)
                objRow.setPropertyValue("BackColor", 16777215)

                'Fill the first table row

                insertIntoCell("A1", LNGIniFile.GetString("MOD_OPENOFFICE", "MSG2", "Организация"), objTable)
                insertIntoCell("A2", LNGIniFile.GetString("MOD_OPENOFFICE", "MSG3", "Место установки"), objTable)
                insertIntoCell("A3", LNGIniFile.GetString("MOD_OPENOFFICE", "MSG4", "Тип компьютера"), objTable)
                insertIntoCell("A4", LNGIniFile.GetString("MOD_OPENOFFICE", "MSG5", "Ответственный"), objTable)
                insertIntoCell("A5", LNGIniFile.GetString("MOD_OPENOFFICE", "MSG6", "Имя в сети"), objTable)
                insertIntoCell("A6", LNGIniFile.GetString("MOD_OPENOFFICE", "MSG7", "Псевдоним"), objTable)
                insertIntoCell("A7", LNGIniFile.GetString("MOD_OPENOFFICE", "MSG8", "Инвентарный номер"), objTable)


                CONFIGURE = New Recordset
                CONFIGURE.Open("SELECT ORG FROM CONFIGURE", DB7, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockReadOnly)
                With CONFIGURE
                    If Not IsDBNull(.Fields("ORG").Value) Then uname = .Fields("ORG").Value
                End With
                CONFIGURE.Close()
                CONFIGURE = Nothing

                cOTV = .Fields("OTvetstvennyj").Value

                insertIntoCell("B1", uname, objTable)
                insertIntoCell("B2",
                               .Fields("filial").Value & "\" & .Fields("mesto").Value & "\" & .Fields("kabn").Value,
                               objTable)
                insertIntoCell("B3", .Fields("TIP_COMPA").Value, objTable)
                insertIntoCell("B4", .Fields("OTvetstvennyj").Value, objTable)

                insertIntoCell("B5", .Fields("NET_NAME").Value, objTable)
                insertIntoCell("B6", .Fields("PSEVDONIM").Value, objTable)
                insertIntoCell("B7", .Fields("INV_NO_SYSTEM").Value, objTable)


                objText.insertControlCharacter(objCursor, 0, False)

                '33333333

                objTable = oDoc.createInstance("com.sun.star.text.TextTable")
                objTable.Initialize(iCOUNTFIELLDS + 1, 3)

                'Insert the table
                objText.insertControlCharacter(objCursor, 0, False)
                objText.insertTextContent(objCursor, objTable, False)

                'Get first row
                objRows = objTable.GetRows
                objRow = objRows.getByIndex(0)

                'Set the table background color
                objTable.setPropertyValue("BackTransparent", True)
                objTable.setPropertyValue("BackColor", 16777215)

                '333333


                'Формируем заголовок
                insertIntoCell("A1", LNGIniFile.GetString("MOD_OPENOFFICE", "MSG9", "Комплектующие"), objTable)
                insertIntoCell("B1", LNGIniFile.GetString("MOD_OPENOFFICE", "MSG10", "Модель"), objTable)
                insertIntoCell("C1", LNGIniFile.GetString("MOD_OPENOFFICE", "MSG11", "Производитель"), objTable)
                'Mb
                insertIntoCell("A2", LNGIniFile.GetString("MOD_OPENOFFICE", "MSG12", "Системная плата"), objTable)
                insertIntoCell("B2", .Fields("MB_NAME").Value & ", " & "SN: " & .Fields("Mb_Id").Value, objTable)
                insertIntoCell("C2", .Fields("Mb_Proizvod").Value, objTable)

                insertIntoCell("A3", LNGIniFile.GetString("MOD_OPENOFFICE", "MSG13", "Процессор"), objTable)
                insertIntoCell("B3", .Fields("CPU1").Value & ", " & .Fields("CPUmhz1").Value, objTable)
                insertIntoCell("C3", .Fields("CPUProizv1").Value, objTable)

                intj = 4
                iA = "A" & intj
                iB = "B" & intj
                iC = "C" & intj

                If Len(.Fields("CPU2").Value) = 0 Then
                Else
                    insertIntoCell(iA, LNGIniFile.GetString("MOD_OPENOFFICE", "MSG13", "Процессор"), objTable)
                    insertIntoCell(iB, .Fields("CPU2").Value & ", " & .Fields("CPUmhz2").Value, objTable)
                    insertIntoCell(iC, .Fields("CPUProizv2").Value, objTable)

                    intj = intj + 1
                    iA = "A" & intj
                    iB = "B" & intj
                    iC = "C" & intj
                End If

                If Len(.Fields("CPU3").Value) = 0 Then
                Else
                    insertIntoCell(iA, LNGIniFile.GetString("MOD_OPENOFFICE", "MSG13", "Процессор"), objTable)
                    insertIntoCell(iB, .Fields("CPU3").Value & ", " & .Fields("CPUmhz3").Value, objTable)
                    insertIntoCell(iC, .Fields("CPUProizv3").Value, objTable)

                    intj = intj + 1
                    iA = "A" & intj
                    iB = "B" & intj
                    iC = "C" & intj
                End If

                If Len(.Fields("CPU4").Value) = 0 Then
                Else
                    insertIntoCell(iA, LNGIniFile.GetString("MOD_OPENOFFICE", "MSG13", "Процессор"), objTable)
                    insertIntoCell(iB, .Fields("CPU4").Value & ", " & .Fields("CPUmhz4").Value, objTable)
                    insertIntoCell(iC, .Fields("CPUProizv4").Value, objTable)

                    intj = intj + 1
                    iA = "A" & intj
                    iB = "B" & intj
                    iC = "C" & intj
                End If

                If Len(.Fields("RAM_1").Value) = 0 Then
                Else
                    insertIntoCell(iA, LNGIniFile.GetString("MOD_OPENOFFICE", "MSG14", "Модуль памяти"), objTable)
                    insertIntoCell(iB, .Fields("RAM_1").Value & ", " & .Fields("RAM_SN_1").Value, objTable)
                    insertIntoCell(iC, .Fields("RAM_PROIZV_1").Value, objTable)

                    intj = intj + 1
                    iA = "A" & intj
                    iB = "B" & intj
                    iC = "C" & intj
                End If

                If Len(.Fields("RAM_2").Value) = 0 Then
                Else
                    insertIntoCell(iA, LNGIniFile.GetString("MOD_OPENOFFICE", "MSG14", "Модуль памяти"), objTable)
                    insertIntoCell(iB, .Fields("RAM_2").Value & ", " & "SN: " & .Fields("RAM_SN_2").Value, objTable)
                    insertIntoCell(iC, .Fields("RAM_PROIZV_2").Value, objTable)

                    intj = intj + 1
                    iA = "A" & intj
                    iB = "B" & intj
                    iC = "C" & intj
                End If

                If Len(.Fields("RAM_3").Value) = 0 Then
                Else
                    insertIntoCell(iA, LNGIniFile.GetString("MOD_OPENOFFICE", "MSG14", "Модуль памяти"), objTable)
                    insertIntoCell(iB, .Fields("RAM_3").Value & ", " & "SN: " & .Fields("RAM_SN_3").Value, objTable)
                    insertIntoCell(iC, .Fields("RAM_PROIZV_3").Value, objTable)

                    intj = intj + 1
                    iA = "A" & intj
                    iB = "B" & intj
                    iC = "C" & intj
                End If

                If Len(.Fields("RAM_4").Value) = 0 Then
                Else
                    insertIntoCell(iA, LNGIniFile.GetString("MOD_OPENOFFICE", "MSG14", "Модуль памяти"), objTable)
                    insertIntoCell(iB, .Fields("RAM_4").Value & ", " & "SN: " & .Fields("RAM_SN_4").Value, objTable)
                    insertIntoCell(iC, .Fields("RAM_PROIZV_4").Value, objTable)

                    intj = intj + 1
                    iA = "A" & intj
                    iB = "B" & intj
                    iC = "C" & intj
                End If

                If Len(.Fields("HDD_Name_1").Value) = 0 Then
                Else
                    insertIntoCell(iA, LNGIniFile.GetString("MOD_OPENOFFICE", "MSG15", "Жесткий диск"), objTable)
                    insertIntoCell(iB,
                                   .Fields("HDD_Name_1").Value & ", " & .Fields("HDD_OB_1").Value & ", SN: " &
                                   .Fields("HDD_SN_1").Value, objTable)
                    insertIntoCell(iC, .Fields("HDD_PROIZV_1").Value, objTable)

                    intj = intj + 1
                    iA = "A" & intj
                    iB = "B" & intj
                    iC = "C" & intj
                End If

                If Len(.Fields("HDD_Name_2").Value) = 0 Then
                Else
                    insertIntoCell(iA, LNGIniFile.GetString("MOD_OPENOFFICE", "MSG15", "Жесткий диск"), objTable)
                    insertIntoCell(iB,
                                   .Fields("HDD_Name_2").Value & ", " & .Fields("HDD_OB_2").Value & ", SN: " &
                                   .Fields("HDD_SN_2").Value, objTable)
                    insertIntoCell(iC, .Fields("HDD_PROIZV_2").Value, objTable)

                    intj = intj + 1
                    iA = "A" & intj
                    iB = "B" & intj
                    iC = "C" & intj
                End If

                If Len(.Fields("HDD_Name_3").Value) = 0 Then
                Else
                    insertIntoCell(iA, LNGIniFile.GetString("MOD_OPENOFFICE", "MSG15", "Жесткий диск"), objTable)
                    insertIntoCell(iB,
                                   .Fields("HDD_Name_3").Value & ", " & .Fields("HDD_OB_3").Value & ", SN: " &
                                   .Fields("HDD_SN_3").Value, objTable)
                    insertIntoCell(iC, .Fields("HDD_PROIZV_3").Value, objTable)

                    intj = intj + 1
                    iA = "A" & intj
                    iB = "B" & intj
                    iC = "C" & intj
                End If

                If Len(.Fields("HDD_Name_4").Value) = 0 Then
                Else
                    insertIntoCell(iA, LNGIniFile.GetString("MOD_OPENOFFICE", "MSG15", "Жесткий диск"), objTable)
                    insertIntoCell(iB,
                                   .Fields("HDD_Name_4").Value & ", " & .Fields("HDD_OB_4").Value & ", SN: " &
                                   .Fields("HDD_SN_4").Value, objTable)
                    insertIntoCell(iC, .Fields("HDD_PROIZV_4").Value, objTable)

                    intj = intj + 1
                    iA = "A" & intj
                    iB = "B" & intj
                    iC = "C" & intj
                End If

                If Len(.Fields("FDD_NAME").Value) = 0 Then
                Else
                    insertIntoCell(iA, LNGIniFile.GetString("MOD_OPENOFFICE", "MSG16", "Дисковод"), objTable)
                    insertIntoCell(iB, .Fields("FDD_NAME").Value & ", SN: " & .Fields("FDD_SN").Value, objTable)
                    insertIntoCell(iC, .Fields("FDD_PROIZV").Value, objTable)

                    intj = intj + 1
                    iA = "A" & intj
                    iB = "B" & intj
                    iC = "C" & intj
                End If

                If Len(.Fields("SVGA_NAME").Value) = 0 Then
                Else
                    insertIntoCell(iA, LNGIniFile.GetString("MOD_OPENOFFICE", "MSG17", "Видео карта"), objTable)
                    insertIntoCell(iB, .Fields("SVGA_NAME").Value & ", SN: " & .Fields("SVGA_SN").Value, objTable)
                    insertIntoCell(iC, .Fields("SVGA_PROIZV").Value, objTable)

                    intj = intj + 1
                    iA = "A" & intj
                    iB = "B" & intj
                    iC = "C" & intj
                End If

                If Len(.Fields("SOUND_NAME").Value) = 0 Then
                Else
                    insertIntoCell(iA, LNGIniFile.GetString("MOD_OPENOFFICE", "MSG18", "Звуковая карта"), objTable)
                    insertIntoCell(iB, .Fields("SOUND_NAME").Value & ", SN: " & .Fields("SOUND_SN").Value, objTable)
                    insertIntoCell(iC, .Fields("SOUND_PROIZV").Value, objTable)

                    intj = intj + 1
                    iA = "A" & intj
                    iB = "B" & intj
                    iC = "C" & intj
                End If

                If Len(.Fields("CD_NAME").Value) = 0 Then
                Else
                    insertIntoCell(iA, LNGIniFile.GetString("MOD_OPENOFFICE", "MSG19", "Оптический диск"), objTable)
                    insertIntoCell(iB, .Fields("CD_NAME").Value & ", SN: " & .Fields("CD_SN").Value, objTable)
                    insertIntoCell(iC, .Fields("CD_PROIZV").Value, objTable)

                    intj = intj + 1
                    iA = "A" & intj
                    iB = "B" & intj
                    iC = "C" & intj
                End If

                If Len(.Fields("CDRW_NAME").Value) = 0 Then
                Else
                    insertIntoCell(iA, LNGIniFile.GetString("MOD_OPENOFFICE", "MSG19", "Оптический диск"), objTable)
                    insertIntoCell(iB, .Fields("CDRW_NAME").Value & ", SN: " & .Fields("CDRW_SN").Value, objTable)
                    insertIntoCell(iC, .Fields("CDRW_PROIZV").Value, objTable)

                    intj = intj + 1
                    iA = "A" & intj
                    iB = "B" & intj
                    iC = "C" & intj
                End If

                If Len(.Fields("DVD_NAME").Value) = 0 Then
                Else
                    insertIntoCell(iA, LNGIniFile.GetString("MOD_OPENOFFICE", "MSG19", "Оптический диск"), objTable)
                    insertIntoCell(iB, .Fields("DVD_NAME").Value & ", SN: " & .Fields("DVD_SN").Value, objTable)
                    insertIntoCell(iC, .Fields("DVD_PROIZV").Value, objTable)

                    intj = intj + 1
                    iA = "A" & intj
                    iB = "B" & intj
                    iC = "C" & intj
                End If

                If Len(.Fields("NET_NAME_1").Value) = 0 Then
                Else
                    insertIntoCell(iA, LNGIniFile.GetString("MOD_OPENOFFICE", "MSG20", "Сетевая карта"), objTable)
                    insertIntoCell(iB, .Fields("NET_NAME_1").Value & ", MAC: " & .Fields("NET_MAC_1").Value, objTable)
                    insertIntoCell(iC, .Fields("NET_PROIZV_1").Value, objTable)

                    intj = intj + 1
                    iA = "A" & intj
                    iB = "B" & intj
                    iC = "C" & intj
                End If

                If Len(.Fields("NET_NAME_2").Value) = 0 Then
                Else
                    insertIntoCell(iA, LNGIniFile.GetString("MOD_OPENOFFICE", "MSG20", "Сетевая карта"), objTable)
                    insertIntoCell(iB, .Fields("NET_NAME_2").Value & ", MAC: " & .Fields("NET_MAC_2").Value, objTable)
                    insertIntoCell(iC, .Fields("NET_PROIZV_2").Value, objTable)

                    intj = intj + 1
                    iA = "A" & intj
                    iB = "B" & intj
                    iC = "C" & intj
                End If

                If Len(.Fields("BLOCK").Value) = 0 Then
                Else
                    insertIntoCell(iA, LNGIniFile.GetString("MOD_OPENOFFICE", "MSG21", "Блок питания"), objTable)
                    insertIntoCell(iB, .Fields("BLOCK").Value & ", SN: " & .Fields("SN_BLOCK").Value, objTable)
                    insertIntoCell(iC, .Fields("PROIZV_BLOCK").Value, objTable)

                    intj = intj + 1
                    iA = "A" & intj
                    iB = "B" & intj
                    iC = "C" & intj
                End If

                If Len(.Fields("KEYBOARD_NAME").Value) = 0 Then
                Else
                    insertIntoCell(iA, LNGIniFile.GetString("MOD_OPENOFFICE", "MSG22", "Клавиатура"), objTable)
                    insertIntoCell(iB, .Fields("KEYBOARD_NAME").Value & ", SN: " & .Fields("KEYBOARD_SN").Value,
                                   objTable)
                    insertIntoCell(iC, .Fields("KEYBOARD_PROIZV").Value, objTable)

                    intj = intj + 1
                    iA = "A" & intj
                    iB = "B" & intj
                    iC = "C" & intj
                End If

                If Len(.Fields("MOUSE_NAME").Value) = 0 Then
                Else
                    insertIntoCell(iA, LNGIniFile.GetString("MOD_OPENOFFICE", "MSG23", "Мышь"), objTable)
                    insertIntoCell(iB, .Fields("MOUSE_NAME").Value & ", SN: " & .Fields("MOUSE_SN").Value, objTable)
                    insertIntoCell(iC, .Fields("MOUSE_PROIZV").Value, objTable)

                    intj = intj + 1
                    iA = "A" & intj
                    iB = "B" & intj
                    iC = "C" & intj
                End If

                If Len(.Fields("MONITOR_NAME").Value) = 0 Then
                Else
                    insertIntoCell(iA, LNGIniFile.GetString("MOD_OPENOFFICE", "MSG24", "Монитор"), objTable)
                    insertIntoCell(iB, .Fields("MONITOR_NAME").Value & ", SN: " & .Fields("MONITOR_SN").Value, objTable)
                    insertIntoCell(iC, .Fields("MONITOR_PROIZV").Value, objTable)

                    intj = intj + 1
                    iA = "A" & intj
                    iB = "B" & intj
                    iC = "C" & intj
                End If

                If Len(.Fields("MONITOR_NAME2").Value) = 0 Then
                Else
                    insertIntoCell(iA, LNGIniFile.GetString("MOD_OPENOFFICE", "MSG24", "Монитор"), objTable)
                    insertIntoCell(iB, .Fields("MONITOR_NAME2").Value & ", SN: " & .Fields("MONITOR_SN2").Value,
                                   objTable)
                    insertIntoCell(iC, .Fields("MONITOR_PROIZV2").Value, objTable)

                    intj = intj + 1
                    iA = "A" & intj
                    iB = "B" & intj
                    iC = "C" & intj
                End If

                If Len(.Fields("AS_NAME").Value) = 0 Then
                Else
                    insertIntoCell(iA, LNGIniFile.GetString("MOD_OPENOFFICE", "MSG25", "Акустическая система"), objTable)
                    insertIntoCell(iB, .Fields("AS_NAME").Value & ", SN: " & .Fields("AS_SN").Value, objTable)
                    insertIntoCell(iC, .Fields("AS_PROIZV").Value, objTable)

                    intj = intj + 1
                    iA = "A" & intj
                    iB = "B" & intj
                    iC = "C" & intj
                End If


                If Len(.Fields("FILTR_NAME").Value) = 0 Then
                Else
                    insertIntoCell(iA, LNGIniFile.GetString("MOD_OPENOFFICE", "MSG26", "Сетевой фильтр"), objTable)
                    insertIntoCell(iB, .Fields("FILTR_NAME").Value & ", SN: " & .Fields("FILTR_SN").Value, objTable)
                    insertIntoCell(iC, .Fields("FILTR_PROIZV").Value, objTable)

                    intj = intj + 1
                    iA = "A" & intj
                    iB = "B" & intj
                    iC = "C" & intj
                End If


                If Len(.Fields("PRINTER_NAME_1").Value) = 0 Then
                Else
                    insertIntoCell(iA, LNGIniFile.GetString("MOD_OPENOFFICE", "MSG27", "Принтер"), objTable)
                    insertIntoCell(iB, .Fields("PRINTER_NAME_1").Value & ", SN: " & .Fields("PRINTER_SN_1").Value,
                                   objTable)
                    insertIntoCell(iC, .Fields("PRINTER_PROIZV_1").Value, objTable)

                    intj = intj + 1
                    iA = "A" & intj
                    iB = "B" & intj
                    iC = "C" & intj
                End If

                If Len(.Fields("PRINTER_NAME_2").Value) = 0 Then
                Else
                    insertIntoCell(iA, LNGIniFile.GetString("MOD_OPENOFFICE", "MSG27", "Принтер"), objTable)
                    insertIntoCell(iB, .Fields("PRINTER_NAME_2").Value & ", SN: " & .Fields("PRINTER_SN_2").Value,
                                   objTable)
                    insertIntoCell(iC, .Fields("PRINTER_PROIZV_2").Value, objTable)

                    intj = intj + 1
                    iA = "A" & intj
                    iB = "B" & intj
                    iC = "C" & intj
                End If

                If Len(.Fields("PRINTER_NAME_3").Value) = 0 Then
                Else
                    insertIntoCell(iA, LNGIniFile.GetString("MOD_OPENOFFICE", "MSG27", "Принтер"), objTable)
                    insertIntoCell(iB, .Fields("PRINTER_NAME_3").Value & ", SN: " & .Fields("PRINTER_SN_3").Value,
                                   objTable)
                    insertIntoCell(iC, .Fields("PRINTER_PROIZV_3").Value, objTable)

                    intj = intj + 1
                    iA = "A" & intj
                    iB = "B" & intj
                    iC = "C" & intj
                End If


                objText.insertControlCharacter(objCursor, 0, False)
                objText.insertControlCharacter(objCursor, 0, False)


                .MoveNext()
            Loop
        End With

        rs.Close()
        rs = Nothing


        'В составе устройства

        sSQL1 = "SELECT count(*) as t_n FROM kompy WHERE PCL=" & sID

        rs1 = New Recordset
        rs1.Open(sSQL1, DB7, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic)

        With rs1

            GIST = .Fields("t_n").Value

        End With

        rs1.Close()
        rs1 = Nothing

        If GIST = 0 Then

        Else

            objText.insertControlCharacter(objCursor, 0, False)

            objText.insertString(objCursor,
                                 LNGIniFile.GetString("MOD_OPENOFFICE", "MSG28", "В составе устройства") & vbLf, False)

            objTable = oDoc.createInstance("com.sun.star.text.TextTable")
            objTable.Initialize(GIST + 1, 3)

            'Insert the table
            objText.insertControlCharacter(objCursor, 0, False)
            objText.insertTextContent(objCursor, objTable, False)

            'Get first row
            objRows = objTable.GetRows
            objRow = objRows.getByIndex(0)

            'Set the table background color
            objTable.setPropertyValue("BackTransparent", False)
            objTable.setPropertyValue("BackColor", 16777215)


            insertIntoCell("A1", LNGIniFile.GetString("MOD_OPENOFFICE", "MSG29", "Устройство"), objTable)
            insertIntoCell("B1", LNGIniFile.GetString("MOD_OPENOFFICE", "MSG10", "Модель"), objTable)
            insertIntoCell("C1", LNGIniFile.GetString("MOD_OPENOFFICE", "MSG31", "Серийный номер"), objTable)


            sSQL1 = "SELECT * FROM kompy WHERE PCL=" & sID
            rs1 = New Recordset
            rs1.Open(sSQL1, DB7, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic)

            intj = 2
            With rs1
                If .RecordCount <> 0 Then
                    .MoveFirst()
                    Do While Not .EOF

                        iA = "A" & intj
                        iB = "B" & intj
                        iC = "C" & intj


                        Select Case .Fields("tiptehn").Value

                            Case "Printer"

                                insertIntoCell(iA, LNGIniFile.GetString("MOD_OPENOFFICE", "MSG27", "Принтер"), objTable)
                                insertIntoCell(iB, .Fields("NET_NAME").Value, objTable)
                                insertIntoCell(iC, .Fields("PRINTER_SN_1").Value, objTable)

                            Case "MFU"
                                insertIntoCell(iA, LNGIniFile.GetString("MOD_OPENOFFICE", "MSG32", "МФУ"), objTable)
                                insertIntoCell(iB, .Fields("NET_NAME").Value, objTable)
                                insertIntoCell(iC, .Fields("PRINTER_SN_1").Value, objTable)

                            Case "MONITOR"

                                insertIntoCell(iA, LNGIniFile.GetString("MOD_OPENOFFICE", "MSG24", "Монитор"), objTable)
                                insertIntoCell(iB, .Fields("NET_NAME").Value, objTable)
                                insertIntoCell(iC, .Fields("MONITOR_SN").Value, objTable)

                            Case "OT"

                                insertIntoCell(iA, .Fields("TIP_COMPA").Value, objTable)
                                insertIntoCell(iB, .Fields("NET_NAME").Value, objTable)
                                insertIntoCell(iC, .Fields("PRINTER_SN_1").Value, objTable)

                            Case "SCANER"

                                insertIntoCell(iA, LNGIniFile.GetString("MOD_OPENOFFICE", "MSG34", "Сканер"), objTable)
                                insertIntoCell(iB, .Fields("NET_NAME").Value, objTable)
                                insertIntoCell(iC, .Fields("PRINTER_SN_1").Value, objTable)

                            Case "FS"

                                insertIntoCell(iA, LNGIniFile.GetString("MOD_OPENOFFICE", "MSG26", "Сетевой фильтр"),
                                               objTable)
                                insertIntoCell(iB, .Fields("NET_NAME").Value, objTable)
                                insertIntoCell(iC, .Fields("PRINTER_SN_1").Value, objTable)


                            Case "IBP"

                                insertIntoCell(iA,
                                               LNGIniFile.GetString("MOD_OPENOFFICE", "MSG35",
                                                                    "Источник бесперебойного питания"), objTable)
                                insertIntoCell(iB, .Fields("NET_NAME").Value, objTable)
                                insertIntoCell(iC, .Fields("PRINTER_SN_1").Value, objTable)

                            Case "SOUND"

                                insertIntoCell(iA,
                                               LNGIniFile.GetString("MOD_OPENOFFICE", "MSG25", "Акустическая система"),
                                               objTable)
                                insertIntoCell(iB, .Fields("NET_NAME").Value, objTable)
                                insertIntoCell(iC, .Fields("PRINTER_SN_1").Value, objTable)

                            Case "USB"

                                insertIntoCell(iA, LNGIniFile.GetString("MOD_OPENOFFICE", "MSG37", "USB Устройство"),
                                               objTable)
                                insertIntoCell(iB, .Fields("NET_NAME").Value, objTable)
                                insertIntoCell(iC, .Fields("PRINTER_SN_1").Value, objTable)


                            Case "MOUSE"

                                insertIntoCell(iA, LNGIniFile.GetString("MOD_OPENOFFICE", "MSG23", "Мышь"), objTable)
                                insertIntoCell(iB, .Fields("NET_NAME").Value, objTable)
                                insertIntoCell(iC, .Fields("PRINTER_SN_1").Value, objTable)

                            Case "KEYB"

                                insertIntoCell(iA, LNGIniFile.GetString("MOD_OPENOFFICE", "MSG22", "Клавиатура"),
                                               objTable)
                                insertIntoCell(iB, .Fields("NET_NAME").Value, objTable)
                                insertIntoCell(iC, .Fields("PRINTER_SN_1").Value, objTable)

                                'insertIntoCell(iD, .Fields("INV_NO_PRINTER").Value, objTable)

                        End Select


                        intj = intj + 1

                        .MoveNext()
                    Loop
                End If
            End With

            rs1.Close()
            rs1 = Nothing

            objText.insertString(objCursor, " " & vbLf, False)

        End If


        'Установленное ПО

        sSQL1 = "SELECT count(*) as t_n FROM SOFT_INSTALL WHERE id_comp=" & sID

        rs1 = New Recordset
        rs1.Open(sSQL1, DB7, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic)

        With rs1

            GIST = .Fields("t_n").Value

        End With

        rs1.Close()
        rs1 = Nothing

        If GIST = 0 Then
        Else


            objTable = oDoc.createInstance("com.sun.star.text.TextTable")
            objTable.Initialize(GIST + 1, 1)
            objText.insertTextContent(objCursor, objTable, False)

            objRows = objTable.GetRows
            objRow = objRows.getByIndex(0)

            objTable.setPropertyValue("BackTransparent", True)
            objTable.setPropertyValue("BackColor", 16777215)


            intj = 1
            insertIntoCell("A1",
                           LNGIniFile.GetString("MOD_OPENOFFICE", "MSG38", "Установленное Программное обеспечение"),
                           objTable) 'lv_teh_fil_otd.SELECTedItem.Text, objTable

            sSQL1 = "SELECT * FROM SOFT_INSTALL WHERE id_comp=" & sID
            rs1 = New Recordset
            rs1.Open(sSQL1, DB7, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic)
            With rs1
                If .RecordCount <> 0 Then
                    .MoveFirst()
                    Do While Not .EOF
                        iA = "A" & intj + 1

                        insertIntoCell(iA, .Fields("Soft"), objTable) 'lv_teh_fil_otd.SELECTedItem.Text, objTable
                        intj = intj + 1

                        .MoveNext()
                    Loop
                End If
            End With

            rs1.Close()
            rs1 = Nothing

            objText.insertString(objCursor, " " & vbLf, False)

        End If


        '#####################################################################################
        'ПЕРЕМЕЩЕНИЕ ТЕХНИКИ


        Dim rscount As Recordset 'Объявляем рекордсет
        rscount = New Recordset
        rscount.Open("SELECT COUNT(*) AS total_number FROM dvig WHERE id_comp=" & sID, DB7, CursorTypeEnum.adOpenDynamic,
                     LockTypeEnum.adLockOptimistic)

        With rscount
            GIST = .Fields("total_number").Value
        End With

        rscount.Close()
        rscount = Nothing


        If GIST > 0 Then

            objText.insertControlCharacter(objCursor, 0, False)

            objText.insertString(objCursor,
                                 LNGIniFile.GetString("MOD_OPENOFFICE", "MSG39", "Перемещение техники") & vbLf, False)

            objTable = oDoc.createInstance("com.sun.star.text.TextTable")
            objTable.Initialize(GIST + 1, 4)

            'Insert the table
            objText.insertControlCharacter(objCursor, 0, False)
            objText.insertTextContent(objCursor, objTable, False)

            'Get first row
            objRows = objTable.GetRows
            objRow = objRows.getByIndex(0)

            'Set the table background color
            objTable.setPropertyValue("BackTransparent", False)
            objTable.setPropertyValue("BackColor", 16777215)

            'Формируем заголовок
            insertIntoCell("A1", LNGIniFile.GetString("MOD_OPENOFFICE", "MSG40", "Старое место"), objTable)
            insertIntoCell("B1", LNGIniFile.GetString("MOD_OPENOFFICE", "MSG41", "Новое место"), objTable)
            insertIntoCell("C1", LNGIniFile.GetString("MOD_OPENOFFICE", "MSG42", "Причина"), objTable)
            insertIntoCell("D1", LNGIniFile.GetString("MOD_OPENOFFICE", "MSG43", "Дата"), objTable)

            rscount = New Recordset
            rscount.Open("SELECT * FROM dvig WHERE id_comp=" & sID & " ORDER BY D_T", DB7, CursorTypeEnum.adOpenDynamic,
                         LockTypeEnum.adLockOptimistic)

            intj = 2
            With rscount
                .MoveFirst()
                Do While Not .EOF = True

                    iA = "A" & intj
                    iB = "B" & intj
                    iC = "C" & intj
                    iD = "D" & intj

                    insertIntoCell(iA, .Fields("oldMesto").Value, objTable)
                    insertIntoCell(iB, .Fields("NewMesto").Value, objTable)
                    insertIntoCell(iC, .Fields("Prich").Value, objTable)
                    insertIntoCell(iD, .Fields("D_T").Value, objTable)
                    intj = intj + 1


                    .MoveNext()
                    'DoEvents
                Loop
            End With
            rscount.Close()
            rscount = Nothing

        End If

        '#####################################################################################
        'РЕМОНТЫ

        rscount = New Recordset
        rscount.Open("SELECT COUNT(*) AS total_number FROM Remont WHERE id_comp=" & sID, DB7,
                     CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic)

        With rscount
            GIST = .Fields("total_number").Value
        End With

        rscount.Close()
        rscount = Nothing


        If GIST > 0 Then


            objText.insertControlCharacter(objCursor, 0, False)

            objText.insertString(objCursor, LNGIniFile.GetString("MOD_OPENOFFICE", "MSG44", "Ремонты") & vbLf, False)

            objTable = oDoc.createInstance("com.sun.star.text.TextTable")
            objTable.Initialize(GIST + 1, 5)

            'Insert the table
            objText.insertControlCharacter(objCursor, 0, False)
            objText.insertTextContent(objCursor, objTable, False)

            'Get first row
            objRows = objTable.GetRows
            objRow = objRows.getByIndex(0)

            'Set the table background color
            objTable.setPropertyValue("BackTransparent", False)
            objTable.setPropertyValue("BackColor", 16777215)


            insertIntoCell("A1", LNGIniFile.GetString("MOD_OPENOFFICE", "MSG43", "Дата"), objTable)
            insertIntoCell("B1", LNGIniFile.GetString("MOD_OPENOFFICE", "MSG46", "Ремонт"), objTable)
            insertIntoCell("C1", LNGIniFile.GetString("MOD_OPENOFFICE", "MSG47", "Мастер"), objTable)
            insertIntoCell("D1", LNGIniFile.GetString("MOD_OPENOFFICE", "MSG48", "Уровень"), objTable)
            insertIntoCell("E1", LNGIniFile.GetString("MOD_OPENOFFICE", "MSG49", "Выполнение"), objTable)

            rscount = New Recordset
            rscount.Open("SELECT * FROM Remont WHERE id_comp=" & sID & " ORDER BY D_T", DB7,
                         CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic)

            'Dim A As String

            intj = 2
            With rscount
                .MoveFirst()
                Do While Not .EOF = True

                    iA = "A" & intj
                    iB = "B" & intj
                    iC = "C" & intj
                    iD = "D" & intj
                    iE = "E" & intj
                    insertIntoCell(iA, .Fields("D_T").Value, objTable)
                    insertIntoCell(iB, .Fields("Remont").Value, objTable)
                    insertIntoCell(iC, .Fields("Master").Value, objTable)
                    insertIntoCell(iD, .Fields("Uroven").Value, objTable)
                    insertIntoCell(iE, .Fields("vip").Value, objTable)
                    intj = intj + 1


                    .MoveNext()
                    'DoEvents
                Loop
            End With
            rscount.Close()
            rscount = Nothing

        End If


        objText.insertString(objCursor, LNGIniFile.GetString("MOD_OPENOFFICE", "MSG50", "Подписи") & vbLf, False)


        objTable = oDoc.createInstance("com.sun.star.text.TextTable")
        objTable.Initialize(3, 2)

        'Insert the table
        objText.insertTextContent(objCursor, objTable, False)

        'Get first row
        objRows = objTable.GetRows
        objRow = objRows.getByIndex(0)

        'Set the table background color
        objTable.setPropertyValue("BackTransparent", False)
        objTable.setPropertyValue("BackColor", 16777215)

        'Set a different background color for the first row
        'objRow.setPropertyValue "BackTransparent", False
        'objRow.setPropertyValue "BackColor", vbWhite


        CONFIGURE = New Recordset
        CONFIGURE.Open("SELECT * FROM CONFIGURE", DB7, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic)
        With CONFIGURE
            If .RecordCount <> 0 Then
                If Not IsDBNull(.Fields("SISADM")) Then uname = .Fields("SISADM").Value
            Else
                uname = "Nothing"
            End If
        End With
        CONFIGURE.Close()
        CONFIGURE = Nothing


        'Формируем заголовок
        insertIntoCell("A1", LNGIniFile.GetString("MOD_OPENOFFICE", "MSG51", "Системный администратор"), objTable)
        insertIntoCell("B1", LNGIniFile.GetString("MOD_OPENOFFICE", "MSG52", "Подписи ответственных лиц"), objTable)

        insertIntoCell("A2", uname, objTable)
        insertIntoCell("B2", cOTV, objTable)
        insertIntoCell("A3", DateAndTime.Today, objTable)
        insertIntoCell("B3", DateAndTime.Today, objTable)

        'DateAndTime.Today
    End Sub

    Public Sub blanks_my_o(ByVal tipot As String)
        'Dim tipot As String
        Dim sSQL, sSQL1, SISADM, Organ As String
        Dim LNGIniFile As New IniFile(sLANGPATH)
        'Указать файл необхадимо
        Dim uname As String

        'tipot = frmMain.lbl_path 'App.Path & "\blanks\blanks_my.dot"


        If Len(tipot) = 0 Then Exit Sub
        On Error Resume Next

        Dim rs1 As Recordset
        sSQL1 = "SELECT org,SISADM FROM CONFIGURE"
        rs1 = New Recordset
        rs1.Open(sSQL1, DB7, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic)

        With rs1
            Organ = .Fields("org").Value
            SISADM$ = .Fields("SISADM").Value
        End With
        rs1.Close()
        rs1 = Nothing


        Dim rs As Recordset
        sSQL = "SELECT * FROM kompy WHERE id = " & frmComputers.sCOUNT
        rs = New Recordset
        rs.Open(sSQL, DB7, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic)

        Dim intj As String
        Dim A, B, C, D, E As String


        Dim oSM As Object            'Root object for accessing OpenOffice FROM VB
        Dim oDesk, oDoc As Object 'First objects FROM the API
        Dim arg(-1) As Object             'Ignore it for the moment !
        Dim mmerge As Object
        'Instanciate OOo : this line is mandatory with VB for OOo API

        Dim objCoreReflection As Object ' objects from OOo API 
        'Dim objText As Object, objCursor As Object

        Dim objTable As Object ' objects from OOo API 
        Dim objRows, objRow As Object

        oSM = CreateObject("com.sun.star.ServiceManager")


        'Create the first and most important service
        oDesk = oSM.createInstance("com.sun.star.frame.Desktop")
        'Create a new doc
        oDoc = oDesk.loadComponentFROMURL("file:///" & tipot, "_blank", 0, arg)
        ' jon code
        Dim objText As Object, objCursor As Object
        objText = oDoc.GetText
        objCursor = objText.createTextCursor



        Dim oSrch As Object
        Dim lngCounter As Integer
        Dim FirstColumn As Boolean

        oSrch = oDoc.createReplaceDescriptor
        oSrch.setSearchString("Организация")
        oSrch.setReplaceString(Organ)
        Debug.Print(oDoc.replaceAll(oSrch))

        oSrch = oDoc.createReplaceDescriptor
        oSrch.setSearchString("Сисадмин")
        oSrch.setReplaceString(SISADM$)
        Debug.Print(oDoc.replaceAll(oSrch))


        Do Until rs.EOF
            FirstColumn = True      'FIRST COLUMN IS A LISTITEM, REST ARE LISTSUBITEMS


            If DB_N <> "MS Access" Then uname = 2 Else uname = 1

            For lngCounter = 0 To rs.Fields.Count - uname

                If FirstColumn Then
                    If Not IsDBNull(rs.Fields(lngCounter).Value) Then


                        oSrch = oDoc.createReplaceDescriptor
                        oSrch.setSearchString(rs.Fields(lngCounter).Name)
                        oSrch.setReplaceString(rs.Fields(lngCounter).Value)
                        Debug.Print(oDoc.replaceAll(oSrch))


                    Else

                    End If                  'TO KEEP DATA FROM SHIFTING LEFT
                    FirstColumn = False
                Else
                    If Not IsDBNull(rs.Fields(lngCounter).Value) Then

                        oSrch = oDoc.createReplaceDescriptor
                        oSrch.setSearchString(rs.Fields(lngCounter).Name)
                        oSrch.setReplaceString(rs.Fields(lngCounter).Value)
                        Debug.Print(oDoc.replaceAll(oSrch))

                    Else

                    End If
                End If
            Next
            rs.MoveNext()
        Loop

        rs.Close()
        rs = Nothing

        Dim rs2 As Recordset
        rs2 = New Recordset
        rs2.Open("Select Postav FROM Garantia_sis WHERE Id_Comp=" & frmComputers.sCOUNT, DB7,
                         CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic)


        With rs2
            uname = .Fields("Postav").Value
        End With
        rs2.Close()
        rs2 = Nothing

        oSrch = oDoc.createReplaceDescriptor
        oSrch.setSearchString("Postav")
        oSrch.setReplaceString(uname)
        Debug.Print(oDoc.replaceAll(oSrch))


        Dim objIniFile As New IniFile(PrPath & "base.ini")

        uname = objIniFile.GetString("MYBLANK", "VSU", "0")

        If uname = 1 Then
            'В составе устройства
            '#####################################################################################

            sSQL1 = "SELECT count(*) as t_n FROM kompy WHERE PCL=" & frmComputers.sCOUNT
            Dim GIST As String

            rs1 = New Recordset
            rs1.Open(sSQL1, DB7, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic)

            With rs1

                GIST = .Fields("t_n").Value

            End With

            rs1.Close()
            rs1 = Nothing

            If GIST = 0 Then

            Else
                Dim iA, iB, iC, iD As String

                objText.insertControlCharacter(objCursor, 0, False)
                objText.insertString(objCursor,
                                     LNGIniFile.GetString("MOD_OPENOFFICE", "MSG28", "В составе устройства") & vbLf,
                                     False)


                objTable = oDoc.createInstance("com.sun.star.text.TextTable")
                objTable.Initialize(GIST + 1, 4)
                objText.insertTextContent(objCursor, objTable, False)

                objRows = objTable.GetRows
                objRow = objRows.getByIndex(0)

                objTable.setPropertyValue("BackTransparent", True)
                objTable.setPropertyValue("BackColor", 16777215)


                intj = 1


                insertIntoCell("A1", LNGIniFile.GetString("MOD_OPENOFFICE", "MSG28", "В составе устройства"), objTable) _
                'lv_teh_fil_otd.SELECTedItem.Text, objTable
                insertIntoCell("B1", LNGIniFile.GetString("MOD_OPENOFFICE", "MSG10", "Модель"), objTable) _
                'lv_teh_fil_otd.SELECTedItem.Text, objTable
                insertIntoCell("C1", LNGIniFile.GetString("MOD_OPENOFFICE", "MSG31", "Серийный номер"), objTable) _
                'lv_teh_fil_otd.SELECTedItem.Text, objTable
                insertIntoCell("D1", LNGIniFile.GetString("MOD_OPENOFFICE", "MSG8", "Инвентарный номер"), objTable) _
                'lv_teh_fil_otd.SELECTedItem.Text, objTable


                sSQL1 = "SELECT * FROM kompy WHERE PCL=" & frmComputers.sCOUNT
                rs1 = New Recordset
                rs1.Open(sSQL1, DB7, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic)
                With rs1
                    If .RecordCount <> 0 Then
                        .MoveFirst()
                        Do While Not .EOF
                            iA = "A" & intj + 1
                            iB = "B" & intj + 1
                            iC = "C" & intj + 1
                            iD = "C" & intj + 1

                            Select Case .Fields("tiptehn").Value

                                Case "Printer"

                                    insertIntoCell(iA, LNGIniFile.GetString("MOD_OPENOFFICE", "MSG27", "Принтер"),
                                                   objTable)
                                    insertIntoCell(iB, .Fields("NET_NAME").Value, objTable)
                                    insertIntoCell(iC, .Fields("PRINTER_SN_1").Value, objTable)
                                    insertIntoCell(iD, .Fields("INV_NO_PRINTER").Value, objTable)


                                Case "MFU"
                                    insertIntoCell(iA, LNGIniFile.GetString("MOD_OPENOFFICE", "MSG32", "МФУ"), objTable)
                                    insertIntoCell(iB, .Fields("NET_NAME").Value, objTable)
                                    insertIntoCell(iC, .Fields("PRINTER_SN_1").Value, objTable)
                                    insertIntoCell(iD, .Fields("INV_NO_PRINTER").Value, objTable)

                                Case "MONITOR"

                                    insertIntoCell(iA, LNGIniFile.GetString("MOD_OPENOFFICE", "MSG24", "Монитор"),
                                                   objTable)
                                    insertIntoCell(iB, .Fields("NET_NAME").Value, objTable)
                                    insertIntoCell(iC, .Fields("MONITOR_SN").Value, objTable)
                                    insertIntoCell(iD, .Fields("INV_NO_MONITOR").Value, objTable)

                                Case "OT"

                                    insertIntoCell(iA, .Fields("TIP_COMPA").Value, objTable)
                                    insertIntoCell(iB, .Fields("NET_NAME").Value, objTable)
                                    insertIntoCell(iC, .Fields("PRINTER_SN_1").Value, objTable)
                                    insertIntoCell(iD, .Fields("INV_NO_PRINTER").Value, objTable)

                                Case "SCANER"

                                    insertIntoCell(iA, LNGIniFile.GetString("MOD_OPENOFFICE", "MSG34", "Сканер"),
                                                   objTable)
                                    insertIntoCell(iB, .Fields("NET_NAME").Value, objTable)
                                    insertIntoCell(iC, .Fields("PRINTER_SN_1").Value, objTable)
                                    insertIntoCell(iD, .Fields("INV_NO_PRINTER").Value, objTable)

                                Case "FS"

                                    insertIntoCell(iA, LNGIniFile.GetString("MOD_OPENOFFICE", "MSG26", "Сетевой фильтр"),
                                                   objTable)
                                    insertIntoCell(iB, .Fields("NET_NAME").Value, objTable)
                                    insertIntoCell(iC, .Fields("PRINTER_SN_1").Value, objTable)
                                    insertIntoCell(iD, .Fields("INV_NO_PRINTER").Value, objTable)


                                Case "IBP"

                                    insertIntoCell(iA,
                                                   LNGIniFile.GetString("MOD_OPENOFFICE", "MSG35",
                                                                        "Источник бесперебойного питания"), objTable)
                                    insertIntoCell(iB, .Fields("NET_NAME").Value, objTable)
                                    insertIntoCell(iC, .Fields("PRINTER_SN_1").Value, objTable)
                                    insertIntoCell(iD, .Fields("INV_NO_PRINTER").Value, objTable)

                                Case "SOUND"

                                    insertIntoCell(iA,
                                                   LNGIniFile.GetString("MOD_OPENOFFICE", "MSG25",
                                                                        "Акустическая система"), objTable)
                                    insertIntoCell(iB, .Fields("NET_NAME").Value, objTable)
                                    insertIntoCell(iC, .Fields("PRINTER_SN_1").Value, objTable)
                                    insertIntoCell(iD, .Fields("INV_NO_PRINTER").Value, objTable)

                                Case "USB"

                                    insertIntoCell(iA, LNGIniFile.GetString("MOD_OPENOFFICE", "MSG37", "USB Устройство"),
                                                   objTable)
                                    insertIntoCell(iB, .Fields("NET_NAME").Value, objTable)
                                    insertIntoCell(iC, .Fields("PRINTER_SN_1").Value, objTable)
                                    insertIntoCell(iD, .Fields("INV_NO_PRINTER").Value, objTable)


                                Case "MOUSE"

                                    insertIntoCell(iA, LNGIniFile.GetString("MOD_OPENOFFICE", "MSG23", "Мышь"),
                                                   objTable)
                                    insertIntoCell(iB, .Fields("NET_NAME").Value, objTable)
                                    insertIntoCell(iC, .Fields("PRINTER_SN_1").Value, objTable)
                                    insertIntoCell(iD, .Fields("INV_NO_PRINTER").Value, objTable)

                                Case "KEYB"

                                    insertIntoCell(iA, LNGIniFile.GetString("MOD_OPENOFFICE", "MSG22", "Клавиатура"),
                                                   objTable)
                                    insertIntoCell(iB, .Fields("NET_NAME").Value, objTable)
                                    insertIntoCell(iC, .Fields("PRINTER_SN_1").Value, objTable)
                                    insertIntoCell(iD, .Fields("INV_NO_PRINTER").Value, objTable)

                            End Select


                            intj = intj + 1


                            .MoveNext()
                        Loop
                    End If
                End With

                rs1.Close()
                rs1 = Nothing

                objText.insertString(objCursor, " " & vbLf, False)

            End If
        End If

        Dim rscount As Recordset 'Объявляем рекордсет
        Dim Coun1 As Long


        uname = objIniFile.GetString("MYBLANK", "POu", "0")

        If uname = 1 Then

            '#####################################################################################
            'Установленное ПО

            rscount = New Recordset
            rscount.Open("SELECT COUNT(*) AS total_number FROM SOFT_INSTALL WHERE id_comp=" & frmComputers.sCOUNT, DB7,
                         CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic)

            With rscount
                Coun1 = .Fields("total_number").Value
            End With

            rscount.Close()
            rscount = Nothing


            If Coun1 > 0 Then

                objText.insertControlCharacter(objCursor, 0, False)
                objText.insertString(objCursor,
                                     LNGIniFile.GetString("MOD_OPENOFFICE", "MSG38",
                                                          "Установленное Программное обеспечение") & vbLf, False)


                objTable = oDoc.createInstance("com.sun.star.text.TextTable")
                objTable.Initialize(Coun1 + 1, 1)

                'Insert the table
                objText.insertControlCharacter(objCursor, 0, False)
                objText.insertTextContent(objCursor, objTable, False)

                'Get first row
                objRows = objTable.GetRows
                objRow = objRows.getByIndex(0)

                'Set the table background color
                objTable.setPropertyValue("BackTransparent", False)
                objTable.setPropertyValue("BackColor", Color.White)

                'Set a different background color for the first row
                'objRow.setPropertyValue "BackTransparent", False
                'objRow.setPropertyValue "BackColor", vbWhite

                'frmContacts.SoftClick()
                'Формируем заголовок
                insertIntoCell("A1",
                               LNGIniFile.GetString("MOD_OPENOFFICE", "MSG38", "Установленное Программное обеспечение"),
                               objTable)

                rscount = New Recordset
                rscount.Open("SELECT Soft FROM SOFT_INSTALL WHERE id_comp=" & frmComputers.sCOUNT, DB7,
                             CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic)

                'Dim A As String

                intj = 2
                With rscount
                    .MoveFirst()
                    Do While Not .EOF = True

                        A = "A" & intj
                        insertIntoCell(A, .Fields("Soft"), objTable)
                        intj = intj + 1

                        .MoveNext()
                        'DoEvents
                    Loop
                End With
                rscount.Close()
                rscount = Nothing


                objText.insertControlCharacter(objCursor, 0, False)

            End If

        End If


        '#####################################################################################
        'ПЕРЕМЕЩЕНИЕ ТЕХНИКИ


        uname = objIniFile.GetString("MYBLANK", "DVIG", "0")

        If uname = 1 Then


            'Dim rscount As ADODB.Recordset 'Объявляем рекордсет
            rscount = New Recordset
            rscount.Open("SELECT COUNT(*) AS total_number FROM dvig WHERE id_comp=" & frmComputers.sCOUNT, DB7,
                         CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic)

            With rscount
                Coun1 = .Fields("total_number").Value
            End With

            rscount.Close()
            rscount = Nothing


            If Coun1 > 0 Then


                objText.insertControlCharacter(objCursor, 0, False)

                objText.insertString(objCursor,
                                     LNGIniFile.GetString("MOD_OPENOFFICE", "MSG39", "Перемещение техники") & vbLf,
                                     False)

                objTable = oDoc.createInstance("com.sun.star.text.TextTable")
                objTable.Initialize(Coun1 + 1, 4)

                'Insert the table
                objText.insertControlCharacter(objCursor, 0, False)
                objText.insertTextContent(objCursor, objTable, False)

                'Get first row
                objRows = objTable.GetRows
                objRow = objRows.getByIndex(0)

                'Set the table background color
                objTable.setPropertyValue("BackTransparent", False)
                objTable.setPropertyValue("BackColor", Color.White)

                'Set a different background color for the first row
                'objRow.setPropertyValue "BackTransparent", False
                'objRow.setPropertyValue "BackColor", vbWhite

                'Формируем заголовок
                insertIntoCell("A1", LNGIniFile.GetString("MOD_OPENOFFICE", "MSG40", "Старое место"), objTable)
                insertIntoCell("B1", LNGIniFile.GetString("MOD_OPENOFFICE", "MSG41", "Новое место"), objTable)
                insertIntoCell("C1", LNGIniFile.GetString("MOD_OPENOFFICE", "MSG42", "Причина"), objTable)
                insertIntoCell("D1", LNGIniFile.GetString("MOD_OPENOFFICE", "MSG43", "Дата"), objTable)

                rscount = New Recordset
                rscount.Open("SELECT * FROM dvig WHERE id_comp=" & frmComputers.sCOUNT, DB7,
                             CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic)


                intj = 2
                With rscount
                    .MoveFirst()
                    Do While Not .EOF = True

                        A = "A" & intj
                        B = "B" & intj
                        C = "C" & intj
                        D = "D" & intj

                        insertIntoCell(A, .Fields("oldMesto"), objTable)
                        insertIntoCell(B, .Fields("NewMesto"), objTable)
                        insertIntoCell(C, .Fields("Prich"), objTable)
                        insertIntoCell(D, .Fields("D_T"), objTable)
                        intj = intj + 1


                        .MoveNext()
                        'DoEvents
                    Loop
                End With
                rscount.Close()
                rscount = Nothing

            End If
        End If


        '#####################################################################################
        'РЕМОНТЫ


        uname = objIniFile.GetString("MYBLANK", "REMONT", "0")

        If uname = 1 Then

            rscount = New Recordset
            rscount.Open("SELECT COUNT(*) AS total_number FROM Remont WHERE id_comp=" & frmComputers.sCOUNT, DB7,
                         CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic)

            With rscount
                Coun1 = .Fields("total_number").Value
            End With

            rscount.Close()
            rscount = Nothing


            If Coun1 > 0 Then


                objText.insertControlCharacter(objCursor, 0, False)

                objText.insertString(objCursor, LNGIniFile.GetString("MOD_OPENOFFICE", "MSG44", "Ремонты") & vbLf, False)

                objTable = oDoc.createInstance("com.sun.star.text.TextTable")
                objTable.Initialize(Coun1 + 1, 5)

                'Insert the table
                objText.insertControlCharacter(objCursor, 0, False)
                objText.insertTextContent(objCursor, objTable, False)

                'Get first row
                objRows = objTable.GetRows
                objRow = objRows.getByIndex(0)

                'Set the table background color
                objTable.setPropertyValue("BackTransparent", False)
                objTable.setPropertyValue("BackColor", Color.White)


                insertIntoCell("A1", LNGIniFile.GetString("MOD_OPENOFFICE", "MSG43", "Дата"), objTable)
                insertIntoCell("B1", LNGIniFile.GetString("MOD_OPENOFFICE", "MSG46", "Ремонт"), objTable)
                insertIntoCell("C1", LNGIniFile.GetString("MOD_OPENOFFICE", "MSG47", "Мастер"), objTable)
                insertIntoCell("D1", LNGIniFile.GetString("MOD_OPENOFFICE", "MSG48", "Уровень"), objTable)
                insertIntoCell("E1", LNGIniFile.GetString("MOD_OPENOFFICE", "MSG49", "Выполнение"), objTable)

                rscount = New Recordset
                rscount.Open("SELECT D_T,Remont,Name,Uroven,vip FROM Remont WHERE id_comp=" & frmComputers.sCOUNT, DB7,
                             CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic)

                intj = 2
                With rscount
                    .MoveFirst()
                    Do While Not .EOF = True

                        A = "A" & intj
                        B = "B" & intj
                        C = "C" & intj
                        D = "D" & intj
                        E = "E" & intj
                        insertIntoCell(A, .Fields("D_T"), objTable)
                        insertIntoCell(B, .Fields("Remont"), objTable)
                        insertIntoCell(C, .Fields("Name"), objTable)
                        insertIntoCell(D, .Fields("Uroven"), objTable)
                        insertIntoCell(E, .Fields("vip"), objTable)
                        intj = intj + 1


                        .MoveNext()
                        'DoEvents
                    Loop
                End With
                rscount.Close()
                rscount = Nothing

            End If
        End If
    End Sub

    Public Sub PASSWORD_MFU(ByVal sSID As String, ByVal sTEH As String)

        Dim tipot, SIS, sSQL As String

        Dim CONFIGURE As Recordset


        Select Case sTEH

            Case "Printer"

                tipot = Directory.GetParent(System.Windows.Forms.Application.ExecutablePath).ToString &
                        "\blanks\pswgl4.dot"

            Case "MFU"

                tipot = Directory.GetParent(System.Windows.Forms.Application.ExecutablePath).ToString &
                        "\blanks\pswgl5.dot"

            Case "KOpir"
                tipot = Directory.GetParent(System.Windows.Forms.Application.ExecutablePath).ToString &
                        "\blanks\pswgl3.dot"

        End Select


        CONFIGURE = New Recordset
        CONFIGURE.Open("SELECT * FROM CONFIGURE", DB7, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic)
        With CONFIGURE
            SIS = .Fields("sisadm").Value
        End With
        CONFIGURE.Close()
        CONFIGURE = Nothing


        Select Case sOfficePACK

            Case "OpenOffice.org"
                Dim oSM As Object            'Root object for accessing OpenOffice FROM VB
                Dim oDesk, oDoc As Object 'First objects FROM the API
                Dim arg(-1) As Object             'Ignore it for the moment !

                oSM = CreateObject("com.sun.star.ServiceManager")


                'Create the first and most important service
                oDesk = oSM.createInstance("com.sun.star.frame.Desktop")
                'Create a new doc
                oDoc = oDesk.loadComponentFROMURL("file:///" & tipot, "_blank", 0, arg)
                ' jon code
                Dim objText As Object, objCursor As Object
                objText = oDoc.GetText
                objCursor = objText.createTextCursor

                ' replace all
                Dim oSrch As Object

                Dim rs As Recordset
                sSQL = "SELECT * FROM kompy WHERE id = " & sSID
                rs = New Recordset
                rs.Open(sSQL, DB7, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic)


                With rs
                    'Set oSrch = oDoc.createSearchDescriptor
                    oSrch = oDoc.createReplaceDescriptor
                    oSrch.setSearchString("naimenovan")
                    oSrch.setReplaceString(.Fields("PRINTER_NAME_1"))
                    Debug.Print(oDoc.replaceAll(oSrch))

                    oSrch.setSearchString("kab otd")
                    oSrch.setReplaceString(
                        .Fields("FILIAL").Value & "\" & .Fields("mesto").Value & "\" & .Fields("kabn").Value)
                    Debug.Print(oDoc.replaceAll(oSrch))

                    oSrch.setSearchString("otvet")
                    oSrch.setReplaceString(.Fields("OTvetstvennyj"))
                    Debug.Print(oDoc.replaceAll(oSrch))

                    oSrch.setSearchString("tel")
                    oSrch.setReplaceString(.Fields("TELEPHONE"))
                    Debug.Print(oDoc.replaceAll(oSrch))

                    oSrch.setSearchString("serial")
                    oSrch.setReplaceString(.Fields("PRINTER_SN_1"))
                    Debug.Print(oDoc.replaceAll(oSrch))

                    oSrch.setSearchString("invent")
                    oSrch.setReplaceString(.Fields("INV_NO_PRINTER"))
                    Debug.Print(oDoc.replaceAll(oSrch))

                    oSrch.setSearchString("format")
                    oSrch.setReplaceString(.Fields("port_1"))
                    Debug.Print(oDoc.replaceAll(oSrch))

                End With


                rs.Close()
                rs = Nothing


            Case Else

                Dim Wrd As Application
                Dim WrdDc As Object
                Wrd = New Application

                WrdDc = Wrd.Documents.Open(tipot, , False)  'Application.
                WrdDc.Application.Visible = True

                Wrd.Selection.Find.ClearFormatting()
                Wrd.Selection.Find.Replacement.ClearFormatting()
                'Номер

                Dim rs As Recordset
                sSQL = "SELECT * FROM kompy WHERE id = " & sSID
                rs = New Recordset
                rs.Open(sSQL, DB7, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic)

                Dim a1, a2, a3, a4, a5, a6, a7 As String
                With rs

                    a1 = .Fields("PRINTER_NAME_1").Value
                    a2 = .Fields("FILIAL").Value & "\" & .Fields("mesto").Value & "\" & .Fields("kabn").Value
                    a3 = .Fields("OTvetstvennyj").Value
                    a4 = .Fields("TELEPHONE").Value
                    a5 = .Fields("PRINTER_SN_1").Value
                    a6 = .Fields("INV_NO_PRINTER").Value
                    a7 = .Fields("port_1").Value

                End With

                rs.Close()
                rs = Nothing


                With Wrd.Selection.Find
                    .Text = "naimenovan"
                    .Replacement.Text = a1
                    .Forward = True
                    .Wrap = WdFindWrap.wdFindContinue
                    .Format = False
                    .MatchCase = True
                    .MatchWholeWord = False
                    .MatchWildcards = False
                    ' .MatchSoundsLike = False
                    .MatchAllWordForms = False
                End With
                Wrd.Selection.Find.Execute(Replace:=WdReplace.wdReplaceAll)

                With Wrd.Selection.Find
                    .Text = "kab otd"
                    .Replacement.Text = a2
                    .Forward = True
                    .Wrap = WdFindWrap.wdFindContinue
                    .Format = False
                    .MatchCase = True
                    .MatchWholeWord = False
                    .MatchWildcards = False
                    ' .MatchSoundsLike = False
                    .MatchAllWordForms = False
                End With
                Wrd.Selection.Find.Execute(Replace:=WdReplace.wdReplaceAll)

                With Wrd.Selection.Find
                    .Text = "otvet"
                    .Replacement.Text = a3
                    .Forward = True
                    .Wrap = WdFindWrap.wdFindContinue
                    .Format = False
                    .MatchCase = True
                    .MatchWholeWord = False
                    .MatchWildcards = False
                    ' .MatchSoundsLike = False
                    .MatchAllWordForms = False
                End With
                Wrd.Selection.Find.Execute(Replace:=WdReplace.wdReplaceAll)

                With Wrd.Selection.Find
                    .Text = "tel"
                    .Replacement.Text = a4
                    .Forward = True
                    .Wrap = WdFindWrap.wdFindContinue
                    .Format = False
                    .MatchCase = True
                    .MatchWholeWord = False
                    .MatchWildcards = False
                    ' .MatchSoundsLike = False
                    .MatchAllWordForms = False
                End With
                Wrd.Selection.Find.Execute(Replace:=WdReplace.wdReplaceAll)

                With Wrd.Selection.Find
                    .Text = "serial"
                    .Replacement.Text = a5
                    .Forward = True
                    .Wrap = WdFindWrap.wdFindContinue
                    .Format = False
                    .MatchCase = True
                    .MatchWholeWord = False
                    .MatchWildcards = False
                    ' .MatchSoundsLike = False
                    .MatchAllWordForms = False
                End With
                Wrd.Selection.Find.Execute(Replace:=WdReplace.wdReplaceAll)

                With Wrd.Selection.Find
                    .Text = "invent"
                    .Replacement.Text = a6
                    .Forward = True
                    .Wrap = WdFindWrap.wdFindContinue
                    .Format = False
                    .MatchCase = True
                    .MatchWholeWord = False
                    .MatchWildcards = False
                    ' .MatchSoundsLike = False
                    .MatchAllWordForms = False
                End With
                Wrd.Selection.Find.Execute(Replace:=WdReplace.wdReplaceAll)

                With Wrd.Selection.Find
                    .Text = "Format"
                    .Replacement.Text = a7
                    .Forward = True
                    .Wrap = WdFindWrap.wdFindContinue
                    .Format = False
                    .MatchCase = True
                    .MatchWholeWord = False
                    .MatchWildcards = False
                    ' .MatchSoundsLike = False
                    .MatchAllWordForms = False
                End With
                Wrd.Selection.Find.Execute(Replace:=WdReplace.wdReplaceAll)
                WrdDc = Nothing
                Wrd = Nothing
        End Select
    End Sub

    Public Sub PASSWORD_NET(ByVal sSID As String)

        Dim tipot, SIS, sSQL As String

        Dim CONFIGURE As Recordset

        CONFIGURE = New Recordset
        CONFIGURE.Open("SELECT * FROM CONFIGURE", DB7, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic)
        With CONFIGURE
            SIS = .Fields("sisadm").Value
        End With
        CONFIGURE.Close()
        CONFIGURE = Nothing

        tipot = Directory.GetParent(System.Windows.Forms.Application.ExecutablePath).ToString & "\blanks\pswgl6.dot"


        Select Case sOfficePACK

            Case "OpenOffice.org"

                Dim oSM As Object            'Root object for accessing OpenOffice FROM VB
                Dim oDesk, oDoc As Object 'First objects FROM the API
                Dim arg(-1) As Object             'Ignore it for the moment !

                oSM = CreateObject("com.sun.star.ServiceManager")


                'Create the first and most important service
                oDesk = oSM.createInstance("com.sun.star.frame.Desktop")
                'Create a new doc
                oDoc = oDesk.loadComponentFROMURL("file:///" & tipot, "_blank", 0, arg)
                ' jon code
                Dim objText As Object, objCursor As Object
                objText = oDoc.GetText
                objCursor = objText.createTextCursor

                ' replace all
                Dim oSrch As Object

                Dim rs As Recordset
                sSQL = "SELECT * FROM kompy WHERE id = " & sSID
                rs = New Recordset
                rs.Open(sSQL, DB7, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic)


                With rs
                    'Set oSrch = oDoc.createSearchDescriptor
                    oSrch = oDoc.createReplaceDescriptor
                    oSrch.setSearchString("naimenovan")
                    oSrch.setReplaceString(.Fields("PRINTER_SN_1"))
                    Debug.Print(oDoc.replaceAll(oSrch))

                    oSrch.setSearchString("proizv")
                    oSrch.setReplaceString(.Fields("PRINTER_PROIZV_1"))
                    Debug.Print(oDoc.replaceAll(oSrch))

                    oSrch.setSearchString("porti")
                    oSrch.setReplaceString(.Fields("PRINTER_SN_2"))
                    Debug.Print(oDoc.replaceAll(oSrch))

                    oSrch.setSearchString("ipaddr")
                    oSrch.setReplaceString(.Fields("PRINTER_NAME_2"))
                    Debug.Print(oDoc.replaceAll(oSrch))

                    oSrch.setSearchString("tip")
                    oSrch.setReplaceString(.Fields("PRINTER_NAME_1"))
                    Debug.Print(oDoc.replaceAll(oSrch))

                    oSrch.setSearchString("serial")
                    oSrch.setReplaceString(.Fields("port_1"))
                    Debug.Print(oDoc.replaceAll(oSrch))

                    'proizv
                    oSrch.setSearchString("_kab\otd")
                    oSrch.setReplaceString(
                        .Fields("FILIAL").Value & "\" & .Fields("mesto").Value & "\" & .Fields("kabn").Value)
                    Debug.Print(oDoc.replaceAll(oSrch))

                    oSrch.setSearchString("otvet")
                    oSrch.setReplaceString(.Fields("TELEPHONE"))
                    Debug.Print(oDoc.replaceAll(oSrch))

                    oSrch.setSearchString("tel")
                    oSrch.setReplaceString("")
                    Debug.Print(oDoc.replaceAll(oSrch))

                    oSrch.setSearchString("invent")
                    oSrch.setReplaceString(.Fields("PRINTER_PROIZV_3"))
                    Debug.Print(oDoc.replaceAll(oSrch))

                End With

                rs.Close()
                rs = Nothing

            Case Else

                Dim Wrd As Application
                Dim WrdDc As Object
                Wrd = New Application

                WrdDc = Wrd.Documents.Open(tipot, , False)  'Application.
                WrdDc.Application.Visible = True

                Wrd.Selection.Find.ClearFormatting()
                Wrd.Selection.Find.Replacement.ClearFormatting()
                'Номер

                Dim rs As Recordset
                sSQL = "SELECT * FROM kompy WHERE id = " & sSID
                rs = New Recordset
                rs.Open(sSQL, DB7, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic)

                Dim a1, a2, a3, a4, a5, a6, a7, a8, a9 As String
                With rs

                    a1 = .Fields("PRINTER_SN_1").Value
                    a2 = .Fields("FILIAL").Value & "\" & .Fields("mesto").Value & "\" & .Fields("kabn").Value
                    a3 = .Fields("PRINTER_PROIZV_1").Value
                    a4 = .Fields("PRINTER_SN_2").Value
                    a5 = .Fields("PRINTER_NAME_2").Value
                    a6 = .Fields("PRINTER_NAME_1").Value

                    a7 = .Fields("port_1").Value
                    a8 = .Fields("TELEPHONE").Value
                    a9 = .Fields("PRINTER_PROIZV_3").Value


                End With

                rs.Close()
                rs = Nothing

                With Wrd.Selection.Find
                    .Text = "naimenovan"
                    .Replacement.Text = a1
                    .Forward = True
                    .Wrap = WdFindWrap.wdFindContinue
                    .Format = False
                    .MatchCase = True
                    .MatchWholeWord = False
                    .MatchWildcards = False
                    ' .MatchSoundsLike = False
                    .MatchAllWordForms = False
                End With
                Wrd.Selection.Find.Execute(Replace:=WdReplace.wdReplaceAll)

                With Wrd.Selection.Find
                    .Text = "_kab\otd"
                    .Replacement.Text = a2
                    .Forward = True
                    .Wrap = WdFindWrap.wdFindContinue
                    .Format = False
                    .MatchCase = True
                    .MatchWholeWord = False
                    .MatchWildcards = False
                    ' .MatchSoundsLike = False
                    .MatchAllWordForms = False
                End With
                Wrd.Selection.Find.Execute(Replace:=WdReplace.wdReplaceAll)

                With Wrd.Selection.Find
                    .Text = "proizv"
                    .Replacement.Text = a3
                    .Forward = True
                    .Wrap = WdFindWrap.wdFindContinue
                    .Format = False
                    .MatchCase = True
                    .MatchWholeWord = False
                    .MatchWildcards = False
                    ' .MatchSoundsLike = False
                    .MatchAllWordForms = False
                End With
                Wrd.Selection.Find.Execute(Replace:=WdReplace.wdReplaceAll)

                With Wrd.Selection.Find
                    .Text = "tel"
                    .Replacement.Text = ""
                    .Forward = True
                    .Wrap = WdFindWrap.wdFindContinue
                    .Format = False
                    .MatchCase = True
                    .MatchWholeWord = False
                    .MatchWildcards = False
                    ' .MatchSoundsLike = False
                    .MatchAllWordForms = False
                End With
                Wrd.Selection.Find.Execute(Replace:=WdReplace.wdReplaceAll)

                With Wrd.Selection.Find
                    .Text = "serial"
                    .Replacement.Text = a7
                    .Forward = True
                    .Wrap = WdFindWrap.wdFindContinue
                    .Format = False
                    .MatchCase = True
                    .MatchWholeWord = False
                    .MatchWildcards = False
                    ' .MatchSoundsLike = False
                    .MatchAllWordForms = False
                End With
                Wrd.Selection.Find.Execute(Replace:=WdReplace.wdReplaceAll)

                With Wrd.Selection.Find
                    .Text = "porti"
                    .Replacement.Text = a4
                    .Forward = True
                    .Wrap = WdFindWrap.wdFindContinue
                    .Format = False
                    .MatchCase = True
                    .MatchWholeWord = False
                    .MatchWildcards = False
                    ' .MatchSoundsLike = False
                    .MatchAllWordForms = False
                End With
                Wrd.Selection.Find.Execute(Replace:=WdReplace.wdReplaceAll)

                With Wrd.Selection.Find
                    .Text = "ipaddr"
                    .Replacement.Text = a5
                    .Forward = True
                    .Wrap = WdFindWrap.wdFindContinue
                    .Format = False
                    .MatchCase = True
                    .MatchWholeWord = False
                    .MatchWildcards = False
                    ' .MatchSoundsLike = False
                    .MatchAllWordForms = False
                End With
                Wrd.Selection.Find.Execute(Replace:=WdReplace.wdReplaceAll)

                With Wrd.Selection.Find
                    .Text = "tip"
                    .Replacement.Text = a6
                    .Forward = True
                    .Wrap = WdFindWrap.wdFindContinue
                    .Format = False
                    .MatchCase = True
                    .MatchWholeWord = False
                    .MatchWildcards = False
                    ' .MatchSoundsLike = False
                    .MatchAllWordForms = False
                End With
                Wrd.Selection.Find.Execute(Replace:=WdReplace.wdReplaceAll)

                With Wrd.Selection.Find
                    .Text = "otvet"
                    .Replacement.Text = a8
                    .Forward = True
                    .Wrap = WdFindWrap.wdFindContinue
                    .Format = False
                    .MatchCase = True
                    .MatchWholeWord = False
                    .MatchWildcards = False
                    ' .MatchSoundsLike = False
                    .MatchAllWordForms = False
                End With
                Wrd.Selection.Find.Execute(Replace:=WdReplace.wdReplaceAll)


                With Wrd.Selection.Find
                    .Text = "invent"
                    .Replacement.Text = a9
                    .Forward = True
                    .Wrap = WdFindWrap.wdFindContinue
                    .Format = False
                    .MatchCase = True
                    .MatchWholeWord = False
                    .MatchWildcards = False
                    ' .MatchSoundsLike = False
                    .MatchAllWordForms = False
                End With
                Wrd.Selection.Find.Execute(Replace:=WdReplace.wdReplaceAll)


                WrdDc = Nothing
                Wrd = Nothing

        End Select
    End Sub

    Public Sub PASSWORD_OTH(ByVal sSID As String, ByVal sTEH As String)
        Dim tipot, SIS, sSQL As String

        Dim CONFIGURE As Recordset


        Select Case sTEH

            Case "SCANER"

                tipot = Directory.GetParent(System.Windows.Forms.Application.ExecutablePath).ToString &
                        "\blanks\pswgl2.dot"

            Case Else

                'tipot = Directory.GetParent(Application.ExecutablePath).ToString & "\blanks\pswgl5.dot"

        End Select


        CONFIGURE = New Recordset
        CONFIGURE.Open("SELECT * FROM CONFIGURE", DB7, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic)
        With CONFIGURE
            SIS = .Fields("sisadm").Value
        End With
        CONFIGURE.Close()
        CONFIGURE = Nothing

        Select Case sOfficePACK

            Case "OpenOffice.org"

                Dim oSM As Object            'Root object for accessing OpenOffice FROM VB
                Dim oDesk, oDoc As Object 'First objects FROM the API
                Dim arg(-1) As Object             'Ignore it for the moment !

                oSM = CreateObject("com.sun.star.ServiceManager")


                'Create the first and most important service
                oDesk = oSM.createInstance("com.sun.star.frame.Desktop")
                'Create a new doc
                oDoc = oDesk.loadComponentFROMURL("file:///" & tipot, "_blank", 0, arg)
                ' jon code
                Dim objText As Object, objCursor As Object
                objText = oDoc.GetText
                objCursor = objText.createTextCursor

                ' replace all
                Dim oSrch As Object

                Dim rs As Recordset
                sSQL = "SELECT * FROM kompy WHERE id = " & sSID
                rs = New Recordset
                rs.Open(sSQL, DB7, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic)


                With rs
                    'Set oSrch = oDoc.createSearchDescriptor
                    oSrch = oDoc.createReplaceDescriptor
                    oSrch.setSearchString("naimenovan")
                    oSrch.setReplaceString(.Fields("PRINTER_NAME_1"))
                    Debug.Print(oDoc.replaceAll(oSrch))

                    oSrch.setSearchString("kab_otd")
                    oSrch.setReplaceString(
                        .Fields("FILIAL").Value & "\" & .Fields("mesto").Value & "\" & .Fields("kabn").Value)
                    Debug.Print(oDoc.replaceAll(oSrch))

                    oSrch.setSearchString("otvet")
                    oSrch.setReplaceString(.Fields("OTvetstvennyj"))
                    Debug.Print(oDoc.replaceAll(oSrch))

                    oSrch.setSearchString("tel")
                    oSrch.setReplaceString(.Fields("TELEPHONE"))
                    Debug.Print(oDoc.replaceAll(oSrch))

                    oSrch.setSearchString("ser")
                    oSrch.setReplaceString(.Fields("PRINTER_SN_1"))
                    Debug.Print(oDoc.replaceAll(oSrch))

                    oSrch.setSearchString("INN")
                    oSrch.setReplaceString(.Fields("INV_NO_PRINTER"))
                    Debug.Print(oDoc.replaceAll(oSrch))


                End With

                rs.Close()
                rs = Nothing

            Case Else

                Dim Wrd As Application
                Dim WrdDc As Object
                Wrd = New Application

                WrdDc = Wrd.Documents.Open(tipot, , False)  'Application.
                WrdDc.Application.Visible = True

                Wrd.Selection.Find.ClearFormatting()
                Wrd.Selection.Find.Replacement.ClearFormatting()
                'Номер

                Dim rs As Recordset
                sSQL = "SELECT * FROM kompy WHERE id = " & sSID
                rs = New Recordset
                rs.Open(sSQL, DB7, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic)

                Dim a1, a2, a3, a4, a5, a6 As String
                With rs

                    a1 = .Fields("PRINTER_NAME_1").Value
                    a2 = .Fields("FILIAL").Value & "\" & .Fields("mesto").Value & "\" & .Fields("kabn").Value
                    a3 = .Fields("OTvetstvennyj").Value
                    a4 = .Fields("TELEPHONE").Value
                    a5 = .Fields("PRINTER_SN_1").Value
                    a6 = .Fields("INV_NO_PRINTER").Value


                End With

                rs.Close()
                rs = Nothing


                With Wrd.Selection.Find
                    .Text = "naimenovan"
                    .Replacement.Text = a1
                    .Forward = True
                    .Wrap = WdFindWrap.wdFindContinue
                    .Format = False
                    .MatchCase = True
                    .MatchWholeWord = False
                    .MatchWildcards = False
                    ' .MatchSoundsLike = False
                    .MatchAllWordForms = False
                End With
                Wrd.Selection.Find.Execute(Replace:=WdReplace.wdReplaceAll)

                With Wrd.Selection.Find
                    .Text = "kab_otd"
                    .Replacement.Text = a2
                    .Forward = True
                    .Wrap = WdFindWrap.wdFindContinue
                    .Format = False
                    .MatchCase = True
                    .MatchWholeWord = False
                    .MatchWildcards = False
                    ' .MatchSoundsLike = False
                    .MatchAllWordForms = False
                End With
                Wrd.Selection.Find.Execute(Replace:=WdReplace.wdReplaceAll)

                With Wrd.Selection.Find
                    .Text = "otvet"
                    .Replacement.Text = a3
                    .Forward = True
                    .Wrap = WdFindWrap.wdFindContinue
                    .Format = False
                    .MatchCase = True
                    .MatchWholeWord = False
                    .MatchWildcards = False
                    ' .MatchSoundsLike = False
                    .MatchAllWordForms = False
                End With
                Wrd.Selection.Find.Execute(Replace:=WdReplace.wdReplaceAll)

                With Wrd.Selection.Find
                    .Text = "tel"
                    .Replacement.Text = a4
                    .Forward = True
                    .Wrap = WdFindWrap.wdFindContinue
                    .Format = False
                    .MatchCase = True
                    .MatchWholeWord = False
                    .MatchWildcards = False
                    ' .MatchSoundsLike = False
                    .MatchAllWordForms = False
                End With
                Wrd.Selection.Find.Execute(Replace:=WdReplace.wdReplaceAll)

                With Wrd.Selection.Find
                    .Text = "ser"
                    .Replacement.Text = a5
                    .Forward = True
                    .Wrap = WdFindWrap.wdFindContinue
                    .Format = False
                    .MatchCase = True
                    .MatchWholeWord = False
                    .MatchWildcards = False
                    ' .MatchSoundsLike = False
                    .MatchAllWordForms = False
                End With
                Wrd.Selection.Find.Execute(Replace:=WdReplace.wdReplaceAll)

                With Wrd.Selection.Find
                    .Text = "INN"
                    .Replacement.Text = a6
                    .Forward = True
                    .Wrap = WdFindWrap.wdFindContinue
                    .Format = False
                    .MatchCase = True
                    .MatchWholeWord = False
                    .MatchWildcards = False
                    ' .MatchSoundsLike = False
                    .MatchAllWordForms = False
                End With
                Wrd.Selection.Find.Execute(Replace:=WdReplace.wdReplaceAll)

                WrdDc = Nothing
                Wrd = Nothing

        End Select
    End Sub

    Public Sub blanks_my_o_ZKP()
        On Error GoTo err_
        Dim LNGIniFile As New IniFile(sLANGPATH)

        Dim tipot As String

        Dim sSQL, sSQL1, SISADM, Organ As String

        tipot = Directory.GetParent(System.Windows.Forms.Application.ExecutablePath).ToString & "\blanks\cr_zak.doc"

        If Len(tipot) = 0 Then Exit Sub
        On Error Resume Next

        Dim intj As Integer

        Dim rs As Recordset 'Объявляем рекордсет
        Dim Count As String

        rs = New Recordset
        rs.Open("Select COUNT(*) as tot_num FROM kompy where OTvetstvennyj='" & frmReports.cmbOTV.Text & "'", DB7,
                CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic)

        With rs
            Count = .Fields("tot_num").Value
        End With

        rs.Close()
        rs = Nothing
        If Count = 0 Then Exit Sub

        Dim iA, iB, iC, iD, iE As String

        Dim rs1 As Recordset
        sSQL1 = "SELECT * FROM CONFIGURE"
        rs1 = New Recordset
        rs1.Open(sSQL1, DB7, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic)

        With rs1
            Organ = .Fields("org").Value
            SISADM$ = .Fields("SISADM").Value
        End With
        rs1.Close()
        rs1 = Nothing

        Select Case sOfficePACK

            Case "OpenOffice.org"

                Dim oSM As Object            'Root object for accessing OpenOffice FROM VB
                Dim oDesk, oDoc As Object 'First objects FROM the API
                Dim arg(-1) As Object             'Ignore it for the moment !
                Dim mmerge As Object
                'Instanciate OOo : this line is mandatory with VB for OOo API

                Dim objCoreReflection As Object ' objects from OOo API 
                'Dim objText As Object, objCursor As Object

                Dim objTable As Object ' objects from OOo API 
                Dim objRows, objRow, objColumns As Object

                oSM = CreateObject("com.sun.star.ServiceManager")


                'Create the first and most important service
                oDesk = oSM.createInstance("com.sun.star.frame.Desktop")
                'Create a new doc
                oDoc = oDesk.loadComponentFROMURL("file:///" & tipot, "_blank", 0, arg)
                ' jon code
                Dim objText As Object, objCursor As Object
                objText = oDoc.GetText
                objCursor = objText.createTextCursor

                ' replace all
                Dim oSrch As Object

                oSrch = oDoc.createReplaceDescriptor
                oSrch.setSearchString(LNGIniFile.GetString("MOD_OPENOFFICE", "MSG2", "Организация"))
                oSrch.setReplaceString(Organ)
                Debug.Print(oDoc.replaceAll(oSrch))

                oSrch = oDoc.createReplaceDescriptor
                oSrch.setSearchString(LNGIniFile.GetString("MOD_OPENOFFICE", "MSG5", "Ответственный"))
                oSrch.setReplaceString(frmReports.cmbOTV.Text)
                Debug.Print(oDoc.replaceAll(oSrch))


                rs = New Recordset
                rs.Open("Select * FROM kompy where OTvetstvennyj='" & frmReports.cmbOTV.Text & "'", DB7,
                        CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic)

                With rs
                    iA = .Fields("FILIAL").Value
                    iB = .Fields("mesto").Value
                    iC = .Fields("kabn").Value
                End With

                rs.Close()
                rs = Nothing

                oSrch = oDoc.createReplaceDescriptor
                oSrch.setSearchString("Branch")
                oSrch.setReplaceString(iA)
                Debug.Print(oDoc.replaceAll(oSrch))

                oSrch = oDoc.createReplaceDescriptor
                oSrch.setSearchString("Department")
                oSrch.setReplaceString(iB)
                Debug.Print(oDoc.replaceAll(oSrch))

                oSrch = oDoc.createReplaceDescriptor
                oSrch.setSearchString("Office")
                oSrch.setReplaceString(iC)
                Debug.Print(oDoc.replaceAll(oSrch))


                rs = New Recordset
                rs.Open("Select * FROM kompy where OTvetstvennyj='" & frmReports.cmbOTV.Text & "' ORDER BY tiptehn", DB7,
                        CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic)


                oSrch = oDoc.createReplaceDescriptor
                oSrch.setSearchString("TABLE")
                oSrch.setReplaceString("")
                Debug.Print(oDoc.replaceAll(oSrch))


                intj = 1

                objTable = oDoc.createInstance("com.sun.star.text.TextTable")
                objTable.Initialize(Count + 1, 5)
                objText.insertTextContent(objCursor, objTable, False)

                'Ширина полей таблицы
                objColumns = objTable.TableColumnSeparators
                objColumns(0).Position = 500

                objTable.TableColumnSeparators = objColumns


                objRows = objTable.GetRows
                objRow = objRows.getByIndex(0)

                objTable.setPropertyValue("BackTransparent", True)
                objTable.setPropertyValue("BackColor", 16777215)

                'LNGIniFile.GetString("MOD_OPENOFFICE", "MSG38", "Установленное Программное обеспечение")
                intj = 1
                insertIntoCell("A1", LNGIniFile.GetString("MOD_OPENOFFICE", "MSG53", "№ п/п"), objTable)
                insertIntoCell("B1", LNGIniFile.GetString("MOD_OPENOFFICE", "MSG54", "Наименование СТК"), objTable)
                insertIntoCell("C1", LNGIniFile.GetString("MOD_OPENOFFICE", "MSG55", "Инвентарный №"), objTable)
                insertIntoCell("D1", LNGIniFile.GetString("MOD_OPENOFFICE", "MSG56", "Заводской №"), objTable)
                insertIntoCell("E1", LNGIniFile.GetString("MOD_OPENOFFICE", "MSG57", "Дата закрепления"), objTable)


                'Column.OlePropertySet("optimalWidth", True)

                With rs
                    .MoveFirst()
                    Do While Not .EOF

                        iA = "A" & intj + 1
                        iB = "B" & intj + 1
                        iC = "C" & intj + 1
                        iD = "D" & intj + 1
                        iE = "E" & intj + 1

                        Select Case .Fields("tiptehn").Value

                            Case "PC"

                                insertIntoCell(iA, intj, objTable)
                                insertIntoCell(iB,
                                               LNGIniFile.GetString("MOD_OPENOFFICE", "MSG58", "Компьютер") & " - " &
                                               .Fields("NET_NAME").Value, objTable)
                                insertIntoCell(iC, .Fields("INV_NO_SYSTEM").Value, objTable)
                                insertIntoCell(iD, .Fields("Ser_N_SIS").Value, objTable)
                                insertIntoCell(iE, .Fields("DataVVoda").Value, objTable)

                                intj = intj + 1

                            Case "Printer"

                                insertIntoCell(iA, intj, objTable)
                                insertIntoCell(iB,
                                               LNGIniFile.GetString("MOD_OPENOFFICE", "MSG27", "Принтер") & " - " &
                                               .Fields("NET_NAME").Value, objTable)
                                insertIntoCell(iC, .Fields("INV_NO_PRINTER").Value, objTable)
                                insertIntoCell(iD, .Fields("PRINTER_SN_1").Value, objTable)
                                insertIntoCell(iE, .Fields("DataVVoda").Value, objTable)


                                intj = intj + 1

                            Case "MFU"

                                insertIntoCell(iA, intj, objTable)
                                insertIntoCell(iB,
                                               LNGIniFile.GetString("MOD_OPENOFFICE", "MSG32", "МФУ") & " - " &
                                               .Fields("NET_NAME").Value, objTable)
                                insertIntoCell(iC, .Fields("INV_NO_PRINTER").Value, objTable)
                                insertIntoCell(iD, .Fields("PRINTER_SN_1").Value, objTable)
                                insertIntoCell(iE, .Fields("DataVVoda").Value, objTable)

                                intj = intj + 1

                            Case "OT"

                                insertIntoCell(iA, intj, objTable)

                                If Len(.Fields("TIP_COMPA").Value) = 0 Then

                                    insertIntoCell(iB,
                                                   LNGIniFile.GetString("MOD_OPENOFFICE", "MSG59", "Другое") & " - (" &
                                                   .Fields("TIP_COMPA").Value & ") " & .Fields("NET_NAME").Value,
                                                   objTable)

                                Else

                                    insertIntoCell(iB, .Fields("TIP_COMPA").Value & " - " & .Fields("NET_NAME").Value,
                                                   objTable)

                                End If


                                insertIntoCell(iC, .Fields("INV_NO_PRINTER").Value, objTable)
                                insertIntoCell(iD, .Fields("PRINTER_SN_1").Value, objTable)
                                insertIntoCell(iE, .Fields("DataVVoda").Value, objTable)

                                intj = intj + 1


                            Case "KOpir"

                                insertIntoCell(iA, intj, objTable)
                                insertIntoCell(iB,
                                               LNGIniFile.GetString("MOD_OPENOFFICE", "MSG60", "Копир") & " - " &
                                               .Fields("NET_NAME").Value, objTable)
                                insertIntoCell(iC, .Fields("INV_NO_PRINTER").Value, objTable)
                                insertIntoCell(iD, .Fields("PRINTER_SN_1").Value, objTable)
                                insertIntoCell(iE, .Fields("DataVVoda").Value, objTable)
                                intj = intj + 1

                            Case "NET"

                                insertIntoCell(iA, intj, objTable)
                                insertIntoCell(iB,
                                               LNGIniFile.GetString("MOD_OPENOFFICE", "MSG61", "Сетевое оборудование") &
                                               " - " & .Fields("NET_NAME").Value, objTable)
                                insertIntoCell(iC, .Fields("PRINTER_PROIZV_3").Value, objTable)
                                insertIntoCell(iD, .Fields("port_1").Value, objTable)
                                insertIntoCell(iE, .Fields("DataVVoda").Value, objTable)

                                intj = intj + 1

                            Case "PHOTO"

                                insertIntoCell(iA, intj, objTable)
                                insertIntoCell(iB,
                                               LNGIniFile.GetString("MOD_OPENOFFICE", "MSG62", "Фотоаппарат") & " - " &
                                               .Fields("NET_NAME").Value, objTable)
                                insertIntoCell(iC, .Fields("INV_NO_PRINTER").Value, objTable)
                                insertIntoCell(iD, .Fields("PRINTER_SN_1").Value, objTable)
                                insertIntoCell(iE, .Fields("DataVVoda").Value, objTable)

                                intj = intj + 1

                            Case "PHONE"

                                insertIntoCell(iA, intj, objTable)
                                insertIntoCell(iB,
                                               LNGIniFile.GetString("MOD_OPENOFFICE", "MSG63", "Телефон") & " - " &
                                               .Fields("NET_NAME").Value, objTable)
                                insertIntoCell(iC, .Fields("INV_NO_PRINTER").Value, objTable)
                                insertIntoCell(iD, .Fields("PRINTER_SN_1").Value, objTable)
                                insertIntoCell(iE, .Fields("DataVVoda").Value, objTable)

                                intj = intj + 1

                            Case "FAX"
                                insertIntoCell(iA, intj, objTable)
                                insertIntoCell(iB,
                                               LNGIniFile.GetString("MOD_OPENOFFICE", "MSG64", "Факс") & " - " &
                                               .Fields("NET_NAME").Value, objTable)
                                insertIntoCell(iC, .Fields("INV_NO_PRINTER").Value, objTable)
                                insertIntoCell(iD, .Fields("PRINTER_SN_1").Value, objTable)
                                insertIntoCell(iE, .Fields("DataVVoda").Value, objTable)

                                intj = intj + 1

                            Case "SCANER"
                                insertIntoCell(iA, intj, objTable)
                                insertIntoCell(iB,
                                               LNGIniFile.GetString("MOD_OPENOFFICE", "MSG34", "Сканер") & " - " &
                                               .Fields("NET_NAME").Value, objTable)
                                insertIntoCell(iC, .Fields("INV_NO_PRINTER").Value, objTable)
                                insertIntoCell(iD, .Fields("PRINTER_SN_1").Value, objTable)
                                insertIntoCell(iE, .Fields("DataVVoda").Value, objTable)


                                intj = intj + 1

                            Case "ZIP"

                                insertIntoCell(iA, intj, objTable)
                                insertIntoCell(iB,
                                               LNGIniFile.GetString("MOD_OPENOFFICE", "MSG65", "Дисковод ZIP") & " - " &
                                               .Fields("NET_NAME").Value, objTable)
                                insertIntoCell(iC, .Fields("INV_NO_PRINTER").Value, objTable)
                                insertIntoCell(iD, .Fields("PRINTER_SN_1").Value, objTable)
                                insertIntoCell(iE, .Fields("DataVVoda").Value, objTable)

                                intj = intj + 1


                            Case "MONITOR"

                                insertIntoCell(iA, intj, objTable)
                                insertIntoCell(iB,
                                               LNGIniFile.GetString("MOD_OPENOFFICE", "MSG24", "Монитор") & " - " &
                                               .Fields("NET_NAME").Value, objTable)
                                insertIntoCell(iC, .Fields("INV_NO_MONITOR").Value, objTable)
                                insertIntoCell(iD, .Fields("MONITOR_SN").Value, objTable)
                                insertIntoCell(iE, .Fields("DataVVoda").Value, objTable)

                                'DataVVoda
                                intj = intj + 1


                            Case "USB"

                                insertIntoCell(iA, intj, objTable)
                                insertIntoCell(iB,
                                               LNGIniFile.GetString("MOD_OPENOFFICE", "MSG37", "USB Устройство") & " - " &
                                               .Fields("NET_NAME").Value, objTable)
                                insertIntoCell(iC, .Fields("INV_NO_PRINTER").Value, objTable)
                                insertIntoCell(iD, .Fields("PRINTER_SN_1").Value, objTable)
                                insertIntoCell(iE, .Fields("DataVVoda").Value, objTable)

                                'DataVVoda
                                intj = intj + 1

                            Case "SOUND"

                                insertIntoCell(iA, intj, objTable)
                                insertIntoCell(iB,
                                               LNGIniFile.GetString("MOD_OPENOFFICE", "MSG25", "Акустическая система") &
                                               " - " & .Fields("NET_NAME").Value, objTable)
                                insertIntoCell(iC, .Fields("INV_NO_PRINTER").Value, objTable)
                                insertIntoCell(iD, .Fields("MONITOR_SN").Value, objTable)
                                insertIntoCell(iE, .Fields("DataVVoda").Value, objTable)

                                'DataVVoda
                                intj = intj + 1

                            Case "IBP"

                                insertIntoCell(iA, intj, objTable)
                                insertIntoCell(iB,
                                               LNGIniFile.GetString("MOD_OPENOFFICE", "MSG35",
                                                                    "Источник бесперебойного питания") & " - " &
                                               .Fields("NET_NAME").Value, objTable)
                                insertIntoCell(iC, .Fields("INV_NO_PRINTER").Value, objTable)
                                insertIntoCell(iD, .Fields("PRINTER_SN_1").Value, objTable)
                                insertIntoCell(iE, .Fields("DataVVoda").Value, objTable)

                                'DataVVoda
                                intj = intj + 1

                            Case ("FS")

                                insertIntoCell(iA, intj, objTable)
                                insertIntoCell(iB,
                                               LNGIniFile.GetString("MOD_OPENOFFICE", "MSG26", "Сетевой фильтр") & " - " &
                                               .Fields("NET_NAME").Value, objTable)
                                insertIntoCell(iC, .Fields("INV_NO_PRINTER").Value, objTable)
                                insertIntoCell(iD, .Fields("PRINTER_SN_1").Value, objTable)
                                insertIntoCell(iE, .Fields("DataVVoda").Value, objTable)

                                'DataVVoda
                                intj = intj + 1


                            Case "KEYB"

                                insertIntoCell(iA, intj, objTable)
                                insertIntoCell(iB,
                                               LNGIniFile.GetString("MOD_OPENOFFICE", "MSG22", "Клавиатура") & " - " &
                                               .Fields("NET_NAME").Value, objTable)
                                insertIntoCell(iC, .Fields("INV_NO_PRINTER").Value, objTable)
                                insertIntoCell(iD, .Fields("PRINTER_SN_1").Value, objTable)
                                insertIntoCell(iE, .Fields("DataVVoda").Value, objTable)

                                intj = intj + 1

                            Case "MOUSE"

                                insertIntoCell(iA, intj, objTable)
                                insertIntoCell(iB,
                                               LNGIniFile.GetString("MOD_OPENOFFICE", "MSG23", "Мышь") & " - " &
                                               .Fields("NET_NAME").Value, objTable)
                                insertIntoCell(iC, .Fields("INV_NO_PRINTER").Value, objTable)
                                insertIntoCell(iD, .Fields("PRINTER_SN_1").Value, objTable)
                                insertIntoCell(iE, .Fields("DataVVoda").Value, objTable)

                                intj = intj + 1

                        End Select

                        .MoveNext()
                        'DoEvents
                    Loop
                End With

                rs.Close()
                rs = Nothing


                objText.insertControlCharacter(objCursor, 0, False)


            Case Else

                Dim Wrd As Application
                Dim WrdDc As Document
                Wrd = New Application

                Dim oDoc As Document
                Dim oTable As Table
                Dim oPara1 As Paragraph, oPara2 As Paragraph
                Dim oPara3 As Paragraph, oPara4 As Paragraph
                Dim oRng As Range
                Dim oShape As InlineShape
                Dim oChart As Object
                Dim Pos As Double

                'oDoc = Wrd.Documents.Add


                WrdDc = Wrd.Documents.Open(tipot, , False)  'Application.
                WrdDc.Application.Visible = True

                Wrd.Selection.Find.ClearFormatting()
                Wrd.Selection.Find.Replacement.ClearFormatting()


                rs = New Recordset
                rs.Open("Select * FROM kompy where OTvetstvennyj='" & frmReports.cmbOTV.Text & "'", DB7,
                        CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic)

                With rs
                    iA = .Fields("FILIAL").Value
                    iB = .Fields("mesto").Value
                    iC = .Fields("kabn").Value
                End With

                rs.Close()
                rs = Nothing

                With Wrd.Selection.Find
                    .Text = "Организация"
                    .Replacement.Text = Organ
                    .Forward = True
                    .Wrap = WdFindWrap.wdFindContinue
                    .Format = False
                    .MatchCase = True
                    .MatchWholeWord = False
                    .MatchWildcards = False
                    ' .MatchSoundsLike = False
                    .MatchAllWordForms = False
                End With
                Wrd.Selection.Find.Execute(Replace:=WdReplace.wdReplaceAll)

                With Wrd.Selection.Find
                    .Text = "Ответственный"
                    .Replacement.Text = frmReports.cmbOTV.Text
                    .Forward = True
                    .Wrap = WdFindWrap.wdFindContinue
                    .Format = False
                    .MatchCase = True
                    .MatchWholeWord = False
                    .MatchWildcards = False
                    ' .MatchSoundsLike = False
                    .MatchAllWordForms = False
                End With
                Wrd.Selection.Find.Execute(Replace:=WdReplace.wdReplaceAll)


                With Wrd.Selection.Find
                    .Text = "Branch"
                    .Replacement.Text = iA
                    .Forward = True
                    .Wrap = WdFindWrap.wdFindContinue
                    .Format = False
                    .MatchCase = True
                    .MatchWholeWord = False
                    .MatchWildcards = False
                    ' .MatchSoundsLike = False
                    .MatchAllWordForms = False
                End With
                Wrd.Selection.Find.Execute(Replace:=WdReplace.wdReplaceAll)

                With Wrd.Selection.Find
                    .Text = "Department"
                    .Replacement.Text = iB
                    .Forward = True
                    .Wrap = WdFindWrap.wdFindContinue
                    .Format = False
                    .MatchCase = True
                    .MatchWholeWord = False
                    .MatchWildcards = False
                    ' .MatchSoundsLike = False
                    .MatchAllWordForms = False
                End With
                Wrd.Selection.Find.Execute(Replace:=WdReplace.wdReplaceAll)

                With Wrd.Selection.Find
                    .Text = "Office"
                    .Replacement.Text = iC
                    .Forward = True
                    .Wrap = WdFindWrap.wdFindContinue
                    .Format = False
                    .MatchCase = True
                    .MatchWholeWord = False
                    .MatchWildcards = False
                    ' .MatchSoundsLike = False
                    .MatchAllWordForms = False
                End With
                Wrd.Selection.Find.Execute(Replace:=WdReplace.wdReplaceAll)

                'rs = New ADODB.Recordset
                'rs.Open("Select * FROM kompy where OTvetstvennyj='" & frmReports.cmbOTV.Text & "'", DB7, ADODB.CursorTypeEnum.adOpenDynamic, ADODB.LockTypeEnum.adLockOptimistic)

                With Wrd.Selection.Find
                    .Text = "TABLE"
                    .Replacement.Text = ""
                    .Forward = True
                    .Wrap = WdFindWrap.wdFindContinue
                    .Format = False
                    .MatchCase = True
                    .MatchWholeWord = False
                    .MatchWildcards = False
                    ' .MatchSoundsLike = False
                    .MatchAllWordForms = False
                End With
                Wrd.Selection.Find.Execute(Replace:=WdReplace.wdReplaceAll)


                oTable = WrdDc.Tables.Add(WrdDc.Bookmarks.Item("TABLE1").Range, Count + 1, 5)
                oTable.Range.ParagraphFormat.SpaceAfter = 6

                oTable.Cell(1, 1).Range.Text = LNGIniFile.GetString("MOD_OPENOFFICE", "MSG53", "№ п/п")
                oTable.Cell(1, 2).Range.Text = LNGIniFile.GetString("MOD_OPENOFFICE", "MSG54", "Наименование СТК")
                oTable.Cell(1, 3).Range.Text = LNGIniFile.GetString("MOD_OPENOFFICE", "MSG55", "Инвентарный №")
                oTable.Cell(1, 4).Range.Text = LNGIniFile.GetString("MOD_OPENOFFICE", "MSG56", "Заводской №")
                oTable.Cell(1, 5).Range.Text = LNGIniFile.GetString("MOD_OPENOFFICE", "MSG57", "Дата закрепления")


                intj = 2

                rs = New Recordset
                rs.Open("Select * FROM kompy where OTvetstvennyj='" & frmReports.cmbOTV.Text & "' ORDER BY tiptehn", DB7,
                        CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic)

                With rs
                    .MoveFirst()
                    Do While Not .EOF


                        Select Case .Fields("tiptehn").Value


                            Case "PC"

                                oTable.Cell(intj, 1).Range.Text = intj - 1
                                oTable.Cell(intj, 2).Range.Text =
                                    LNGIniFile.GetString("MOD_OPENOFFICE", "MSG58", "Компьютер") & " - " &
                                    .Fields("NET_NAME").Value
                                oTable.Cell(intj, 3).Range.Text = .Fields("INV_NO_SYSTEM").Value
                                oTable.Cell(intj, 4).Range.Text = .Fields("Ser_N_SIS").Value
                                oTable.Cell(intj, 5).Range.Text = .Fields("DataVVoda").Value

                                intj = intj + 1

                            Case "Printer"

                                oTable.Cell(intj, 1).Range.Text = intj - 1
                                oTable.Cell(intj, 2).Range.Text =
                                    LNGIniFile.GetString("MOD_OPENOFFICE", "MSG27", "Принтер") & " - " &
                                    .Fields("NET_NAME").Value
                                oTable.Cell(intj, 3).Range.Text = .Fields("INV_NO_PRINTER").Value
                                oTable.Cell(intj, 4).Range.Text = .Fields("PRINTER_SN_1").Value
                                oTable.Cell(intj, 5).Range.Text = .Fields("DataVVoda").Value


                                intj = intj + 1

                            Case "MFU"

                                oTable.Cell(intj, 1).Range.Text = intj - 1
                                oTable.Cell(intj, 2).Range.Text =
                                    LNGIniFile.GetString("MOD_OPENOFFICE", "MSG32", "МФУ") & " - " &
                                    .Fields("NET_NAME").Value
                                oTable.Cell(intj, 3).Range.Text = .Fields("INV_NO_PRINTER").Value
                                oTable.Cell(intj, 4).Range.Text = .Fields("PRINTER_SN_1").Value
                                oTable.Cell(intj, 5).Range.Text = .Fields("DataVVoda").Value

                                intj = intj + 1

                            Case "OT"
                                oTable.Cell(intj, 1).Range.Text = intj - 1

                                If Len(.Fields("TIP_COMPA").Value) = 0 Then

                                    oTable.Cell(intj, 2).Range.Text =
                                        LNGIniFile.GetString("MOD_OPENOFFICE", "MSG59", "Другое") & " - (" &
                                        .Fields("TIP_COMPA").Value & ") " & .Fields("NET_NAME").Value
                                Else
                                    oTable.Cell(intj, 2).Range.Text = .Fields("TIP_COMPA").Value & " - " &
                                                                      .Fields("NET_NAME").Value

                                End If


                                oTable.Cell(intj, 3).Range.Text = .Fields("INV_NO_PRINTER").Value
                                oTable.Cell(intj, 4).Range.Text = .Fields("PRINTER_SN_1").Value
                                oTable.Cell(intj, 5).Range.Text = .Fields("DataVVoda").Value

                                intj = intj + 1


                            Case "KOpir"

                                oTable.Cell(intj, 1).Range.Text = intj - 1
                                oTable.Cell(intj, 2).Range.Text =
                                    LNGIniFile.GetString("MOD_OPENOFFICE", "MSG60", "Копир") & " - " &
                                    .Fields("NET_NAME").Value
                                oTable.Cell(intj, 3).Range.Text = .Fields("INV_NO_PRINTER").Value
                                oTable.Cell(intj, 4).Range.Text = .Fields("PRINTER_SN_1").Value
                                oTable.Cell(intj, 5).Range.Text = .Fields("DataVVoda").Value
                                intj = intj + 1

                            Case "NET"

                                oTable.Cell(intj, 1).Range.Text = intj - 1
                                oTable.Cell(intj, 2).Range.Text =
                                    LNGIniFile.GetString("MOD_OPENOFFICE", "MSG61", "Сетевое оборудование") & " - " &
                                    .Fields("NET_NAME").Value
                                oTable.Cell(intj, 3).Range.Text = .Fields("PRINTER_PROIZV_3").Value
                                oTable.Cell(intj, 4).Range.Text = .Fields("port_1").Value
                                oTable.Cell(intj, 5).Range.Text = .Fields("DataVVoda").Value

                                intj = intj + 1

                            Case "PHOTO"

                                oTable.Cell(intj, 1).Range.Text = intj - 1
                                oTable.Cell(intj, 2).Range.Text =
                                    LNGIniFile.GetString("MOD_OPENOFFICE", "MSG62", "Фотоаппарат") & " - " &
                                    .Fields("NET_NAME").Value
                                oTable.Cell(intj, 3).Range.Text = .Fields("INV_NO_PRINTER").Value
                                oTable.Cell(intj, 4).Range.Text = .Fields("PRINTER_SN_1").Value
                                oTable.Cell(intj, 5).Range.Text = .Fields("DataVVoda").Value

                                intj = intj + 1

                            Case "PHONE"

                                oTable.Cell(intj, 1).Range.Text = intj - 1
                                oTable.Cell(intj, 2).Range.Text =
                                    LNGIniFile.GetString("MOD_OPENOFFICE", "MSG63", "Телефон") & " - " &
                                    .Fields("NET_NAME").Value
                                oTable.Cell(intj, 3).Range.Text = .Fields("INV_NO_PRINTER").Value
                                oTable.Cell(intj, 4).Range.Text = .Fields("PRINTER_SN_1").Value
                                oTable.Cell(intj, 5).Range.Text = .Fields("DataVVoda").Value

                                intj = intj + 1

                            Case "FAX"
                                oTable.Cell(intj, 1).Range.Text = intj - 1
                                oTable.Cell(intj, 2).Range.Text =
                                    LNGIniFile.GetString("MOD_OPENOFFICE", "MSG64", "Факс") & " - " &
                                    .Fields("NET_NAME").Value
                                oTable.Cell(intj, 3).Range.Text = .Fields("INV_NO_PRINTER").Value
                                oTable.Cell(intj, 4).Range.Text = .Fields("PRINTER_SN_1").Value
                                oTable.Cell(intj, 5).Range.Text = .Fields("DataVVoda").Value

                                intj = intj + 1

                            Case "SCANER"
                                oTable.Cell(intj, 1).Range.Text = intj - 1
                                oTable.Cell(intj, 2).Range.Text =
                                    LNGIniFile.GetString("MOD_OPENOFFICE", "MSG34", "Сканер") & " - " &
                                    .Fields("NET_NAME").Value
                                oTable.Cell(intj, 3).Range.Text = .Fields("INV_NO_PRINTER").Value
                                oTable.Cell(intj, 4).Range.Text = .Fields("PRINTER_SN_1").Value
                                oTable.Cell(intj, 5).Range.Text = .Fields("DataVVoda").Value


                                intj = intj + 1

                            Case "ZIP"

                                oTable.Cell(intj, 1).Range.Text = intj - 1
                                oTable.Cell(intj, 2).Range.Text =
                                    LNGIniFile.GetString("MOD_OPENOFFICE", "MSG65", "Дисковод ZIP") & " - " &
                                    .Fields("NET_NAME").Value
                                oTable.Cell(intj, 3).Range.Text = .Fields("INV_NO_PRINTER").Value
                                oTable.Cell(intj, 4).Range.Text = .Fields("PRINTER_SN_1").Value
                                oTable.Cell(intj, 5).Range.Text = .Fields("DataVVoda").Value

                                intj = intj + 1


                            Case "MONITOR"

                                oTable.Cell(intj, 1).Range.Text = intj - 1
                                oTable.Cell(intj, 2).Range.Text =
                                    LNGIniFile.GetString("MOD_OPENOFFICE", "MSG24", "Монитор") & " - " &
                                    .Fields("NET_NAME").Value
                                oTable.Cell(intj, 3).Range.Text = .Fields("INV_NO_MONITOR").Value
                                oTable.Cell(intj, 4).Range.Text = .Fields("MONITOR_SN").Value
                                oTable.Cell(intj, 5).Range.Text = .Fields("DataVVoda").Value

                                'DataVVoda
                                intj = intj + 1

                            Case "FS"

                                oTable.Cell(intj, 1).Range.Text = intj - 1
                                oTable.Cell(intj, 2).Range.Text =
                                    LNGIniFile.GetString("MOD_OPENOFFICE", "MSG26", "Сетевой фильтр") & " - " &
                                    .Fields("NET_NAME").Value
                                oTable.Cell(intj, 3).Range.Text = .Fields("INV_NO_PRINTER").Value
                                oTable.Cell(intj, 4).Range.Text = .Fields("PRINTER_SN_1").Value
                                oTable.Cell(intj, 5).Range.Text = .Fields("DataVVoda").Value

                                'DataVVoda
                                intj = intj + 1

                            Case "IBP"

                                oTable.Cell(intj, 1).Range.Text = intj - 1
                                oTable.Cell(intj, 2).Range.Text =
                                    LNGIniFile.GetString("MOD_OPENOFFICE", "MSG35", "Источник бесперебойного питания") &
                                    " - " & .Fields("NET_NAME").Value
                                oTable.Cell(intj, 3).Range.Text = .Fields("INV_NO_PRINTER").Value
                                oTable.Cell(intj, 4).Range.Text = .Fields("PRINTER_SN_1").Value
                                oTable.Cell(intj, 5).Range.Text = .Fields("DataVVoda").Value

                                'DataVVoda
                                intj = intj + 1

                            Case "SOUND"

                                oTable.Cell(intj, 1).Range.Text = intj - 1
                                oTable.Cell(intj, 2).Range.Text =
                                    LNGIniFile.GetString("MOD_OPENOFFICE", "MSG25", "Акустическая система") & " - " &
                                    .Fields("NET_NAME").Value
                                oTable.Cell(intj, 3).Range.Text = .Fields("INV_NO_PRINTER").Value
                                oTable.Cell(intj, 4).Range.Text = .Fields("PRINTER_SN_1").Value
                                oTable.Cell(intj, 5).Range.Text = .Fields("DataVVoda").Value

                                'DataVVoda
                                intj = intj + 1

                            Case "USB"

                                oTable.Cell(intj, 1).Range.Text = intj - 1
                                oTable.Cell(intj, 2).Range.Text =
                                    LNGIniFile.GetString("MOD_OPENOFFICE", "MSG37", "USB Устройство") & " - " &
                                    .Fields("NET_NAME").Value
                                oTable.Cell(intj, 3).Range.Text = .Fields("INV_NO_PRINTER").Value
                                oTable.Cell(intj, 4).Range.Text = .Fields("PRINTER_SN_1").Value
                                oTable.Cell(intj, 5).Range.Text = .Fields("DataVVoda").Value

                                'DataVVoda
                                intj = intj + 1


                            Case "KEYB"

                                oTable.Cell(intj, 1).Range.Text = intj - 1
                                oTable.Cell(intj, 2).Range.Text =
                                    LNGIniFile.GetString("MOD_OPENOFFICE", "MSG22", "Клавиатура") & " - " &
                                    .Fields("NET_NAME").Value
                                oTable.Cell(intj, 3).Range.Text = .Fields("INV_NO_PRINTER").Value
                                oTable.Cell(intj, 4).Range.Text = .Fields("PRINTER_SN_1").Value
                                oTable.Cell(intj, 5).Range.Text = .Fields("DataVVoda").Value

                                intj = intj + 1

                            Case "MOUSE"

                                oTable.Cell(intj, 1).Range.Text = intj - 1
                                oTable.Cell(intj, 2).Range.Text =
                                    LNGIniFile.GetString("MOD_OPENOFFICE", "MSG23", "Мышь") & " - " &
                                    .Fields("NET_NAME").Value
                                oTable.Cell(intj, 3).Range.Text = .Fields("INV_NO_PRINTER").Value
                                oTable.Cell(intj, 4).Range.Text = .Fields("PRINTER_SN_1").Value
                                oTable.Cell(intj, 5).Range.Text = .Fields("DataVVoda").Value

                                intj = intj + 1

                        End Select


                        .MoveNext()
                        'DoEvents
                    Loop
                End With

                rs.Close()
                rs = Nothing

                oTable.Columns.Item(1).Width = Wrd.InchesToPoints(0.5)   'Change width of columns 1 & 2
                oTable.Columns.Item(2).Width = Wrd.InchesToPoints(2.5)

        End Select


        Exit Sub
err_:

        MsgBox(Err.Description)
    End Sub

    Public Sub WRD_SEND_PK(ByVal sID As String)
        On Error Resume Next
        Dim LNGIniFile As New IniFile(sLANGPATH)

        Dim rs As Recordset
        Dim rs1 As Recordset
        Dim sSQL, sSQL1, scN, cOTV As String

        Dim iA As String
        Dim iB As String
        Dim iC As String
        Dim iD As String
        Dim iE As String
        Dim uname As String

        Dim oWord As Application
        Dim oDoc As Document
        Dim oTable As Table
        Dim oPara1 As Paragraph, oPara2 As Paragraph
        Dim oPara3 As Paragraph, oPara4 As Paragraph
        Dim oRng As Range
        Dim oShape As InlineShape
        Dim oChart As Object
        Dim Pos As Double


        Call COUNT_FIELDS(sID)

        sSQL = "SELECT * FROM kompy WHERE TipTehn='PC' AND id=" & sID

        Dim CONFIGURE As Recordset
        CONFIGURE = New Recordset
        CONFIGURE.Open("SELECT ORG FROM CONFIGURE", DB7, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockReadOnly)

        With CONFIGURE
            If Not IsDBNull(.Fields("ORG").Value) Then uname = .Fields("ORG").Value
        End With
        CONFIGURE.Close()
        CONFIGURE = Nothing


        rs = New Recordset
        rs.Open(sSQL, DB7, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic)
        Dim intj As Integer

        With rs

            'Start Word and open the document template.
            oWord = CreateObject("Word.Application")
            oWord.Visible = True
            oDoc = oWord.Documents.Add

            'Insert a paragraph at the beginning of the document.
            oPara1 = oDoc.Content.Paragraphs.Add
            oPara1.Range.Text = LNGIniFile.GetString("MOD_OPENOFFICE", "MSG1", "Паспорт компьютера №") & " " & sID
            oPara1.Range.Font.Bold = True
            oPara1.Format.SpaceAfter = 24    '24 pt spacing after paragraph.
            oPara1.Range.InsertParagraphAfter()

            oTable = oDoc.Tables.Add(oDoc.Bookmarks.Item("\endofdoc").Range, 7, 2)
            oTable.Range.ParagraphFormat.SpaceAfter = 6
            oTable.Borders.Enable = True

            cOTV = .Fields("OTvetstvennyj").Value

            oTable.Cell(1, 1).Range.Text = LNGIniFile.GetString("MOD_OPENOFFICE", "MSG2", "Организация")
            oTable.Cell(2, 1).Range.Text = LNGIniFile.GetString("MOD_OPENOFFICE", "MSG3", "Место установки")
            oTable.Cell(3, 1).Range.Text = LNGIniFile.GetString("MOD_OPENOFFICE", "MSG4", "Тип компьютера")
            oTable.Cell(4, 1).Range.Text = LNGIniFile.GetString("MOD_OPENOFFICE", "MSG5", "Ответственный")
            oTable.Cell(5, 1).Range.Text = LNGIniFile.GetString("MOD_OPENOFFICE", "MSG6", "Имя в сети")
            oTable.Cell(6, 1).Range.Text = LNGIniFile.GetString("MOD_OPENOFFICE", "MSG7", "Псевдоним")
            oTable.Cell(7, 1).Range.Text = LNGIniFile.GetString("MOD_OPENOFFICE", "MSG8", "Инвентарный номер")

            oTable.Cell(1, 2).Range.Text = uname
            oTable.Cell(2, 2).Range.Text = .Fields("filial").Value & "\" & .Fields("mesto").Value & "\" &
                                           .Fields("kabn").Value
            oTable.Cell(3, 2).Range.Text = .Fields("TIP_COMPA").Value
            oTable.Cell(4, 2).Range.Text = .Fields("OTvetstvennyj").Value
            oTable.Cell(5, 2).Range.Text = .Fields("NET_NAME").Value
            oTable.Cell(6, 2).Range.Text = .Fields("PSEVDONIM").Value
            oTable.Cell(7, 2).Range.Text = .Fields("INV_NO_SYSTEM").Value


            oTable.Rows.Item(1).Range.Font.Bold = True
            oTable.Rows.Item(1).Range.Font.Italic = False

            oPara1 = oDoc.Content.Paragraphs.Add
            oPara1.Range.Text = ""
            oPara1.Range.Font.Bold = True
            oPara1.Format.SpaceAfter = 24    '24 pt spacing after paragraph.
            oPara1.Range.InsertParagraphAfter()

            'iCOUNTFIELLDS + 1

            oTable = oDoc.Tables.Add(oDoc.Bookmarks.Item("\endofdoc").Range, iCOUNTFIELLDS + 1, 3)
            oTable.Range.ParagraphFormat.SpaceAfter = 6
            oTable.Borders.Enable = True

            oTable.Cell(1, 1).Range.Text = LNGIniFile.GetString("MOD_OPENOFFICE", "MSG9", "Комплектующие")
            oTable.Cell(1, 2).Range.Text = LNGIniFile.GetString("MOD_OPENOFFICE", "MSG10", "Модель")
            oTable.Cell(1, 3).Range.Text = LNGIniFile.GetString("MOD_OPENOFFICE", "MSG11", "Производитель")

            oTable.Cell(2, 1).Range.Text = LNGIniFile.GetString("MOD_OPENOFFICE", "MSG12", "Системная плата")
            oTable.Cell(2, 2).Range.Text = .Fields("MB_NAME").Value & ", " & "SN: " & .Fields("Mb_Id").Value
            oTable.Cell(2, 3).Range.Text = .Fields("Mb_Proizvod").Value

            oTable.Cell(3, 1).Range.Text = LNGIniFile.GetString("MOD_OPENOFFICE", "MSG13", "Процессор")
            oTable.Cell(3, 2).Range.Text = .Fields("CPU1").Value & ", " & .Fields("CPUmhz1").Value
            oTable.Cell(3, 3).Range.Text = .Fields("CPUProizv1").Value

            intj = 4

            oTable.Cell(intj, 1).Range.Text = LNGIniFile.GetString("MOD_OPENOFFICE", "MSG13", "Процессор")
            oTable.Cell(intj, 2).Range.Text = .Fields("CPU1").Value & ", " & .Fields("CPUmhz1").Value
            oTable.Cell(intj, 3).Range.Text = .Fields("CPUProizv1").Value


            If Len(.Fields("CPU2").Value) = 0 Then
            Else
                oTable.Cell(intj, 1).Range.Text = LNGIniFile.GetString("MOD_OPENOFFICE", "MSG13", "Процессор")
                oTable.Cell(intj, 2).Range.Text = .Fields("CPU2").Value & ", " & .Fields("CPUmhz2").Value
                oTable.Cell(intj, 3).Range.Text = .Fields("CPUProizv2").Value

                intj = intj + 1

            End If

            If Len(.Fields("CPU3").Value) = 0 Then
            Else
                oTable.Cell(intj, 1).Range.Text = LNGIniFile.GetString("MOD_OPENOFFICE", "MSG13", "Процессор")
                oTable.Cell(intj, 2).Range.Text = .Fields("CPU3").Value & ", " & .Fields("CPUmhz3").Value
                oTable.Cell(intj, 3).Range.Text = .Fields("CPUProizv3").Value

                intj = intj + 1

            End If

            If Len(.Fields("CPU4").Value) = 0 Then
            Else
                oTable.Cell(intj, 1).Range.Text = LNGIniFile.GetString("MOD_OPENOFFICE", "MSG13", "Процессор")
                oTable.Cell(intj, 2).Range.Text = .Fields("CPU4").Value & ", " & .Fields("CPUmhz4").Value
                oTable.Cell(intj, 3).Range.Text = .Fields("CPUProizv4").Value

                intj = intj + 1

            End If

            If Len(.Fields("RAM_1").Value) = 0 Then
            Else
                oTable.Cell(intj, 1).Range.Text = LNGIniFile.GetString("MOD_OPENOFFICE", "MSG14", "Модуль памяти")
                oTable.Cell(intj, 2).Range.Text = .Fields("RAM_1").Value & ", " & .Fields("RAM_SN_1").Value
                oTable.Cell(intj, 3).Range.Text = .Fields("RAM_PROIZV_1").Value

                intj = intj + 1

            End If

            If Len(.Fields("RAM_2").Value) = 0 Then
            Else
                oTable.Cell(intj, 1).Range.Text = LNGIniFile.GetString("MOD_OPENOFFICE", "MSG14", "Модуль памяти")
                oTable.Cell(intj, 2).Range.Text = .Fields("RAM_2").Value & ", " & "SN: " & .Fields("RAM_SN_2").Value
                oTable.Cell(intj, 3).Range.Text = .Fields("RAM_PROIZV_2").Value

                intj = intj + 1

            End If

            If Len(.Fields("RAM_3").Value) = 0 Then
            Else
                oTable.Cell(intj, 1).Range.Text = LNGIniFile.GetString("MOD_OPENOFFICE", "MSG14", "Модуль памяти")
                oTable.Cell(intj, 2).Range.Text = .Fields("RAM_3").Value & ", " & "SN: " & .Fields("RAM_SN_3").Value
                oTable.Cell(intj, 3).Range.Text = .Fields("RAM_PROIZV_3").Value

                intj = intj + 1

            End If

            If Len(.Fields("RAM_4").Value) = 0 Then
            Else
                oTable.Cell(intj, 1).Range.Text = LNGIniFile.GetString("MOD_OPENOFFICE", "MSG14", "Модуль памяти")
                oTable.Cell(intj, 2).Range.Text = .Fields("RAM_4").Value & ", " & "SN: " & .Fields("RAM_SN_4").Value
                oTable.Cell(intj, 3).Range.Text = .Fields("RAM_PROIZV_4").Value

                intj = intj + 1

            End If

            If Len(.Fields("HDD_Name_1").Value) = 0 Then
            Else
                oTable.Cell(intj, 1).Range.Text = LNGIniFile.GetString("MOD_OPENOFFICE", "MSG15", "Жесткий диск")
                oTable.Cell(intj, 2).Range.Text = .Fields("HDD_Name_1").Value & ", " & .Fields("HDD_OB_1").Value &
                                                  ", SN: " & .Fields("HDD_SN_1").Value
                oTable.Cell(intj, 3).Range.Text = .Fields("HDD_PROIZV_1").Value

                intj = intj + 1

            End If

            If Len(.Fields("HDD_Name_2").Value) = 0 Then
            Else
                oTable.Cell(intj, 1).Range.Text = LNGIniFile.GetString("MOD_OPENOFFICE", "MSG15", "Жесткий диск")
                oTable.Cell(intj, 2).Range.Text = .Fields("HDD_Name_2").Value & ", " & .Fields("HDD_OB_2").Value &
                                                  ", SN: " & .Fields("HDD_SN_2").Value
                oTable.Cell(intj, 3).Range.Text = .Fields("HDD_PROIZV_2").Value

                intj = intj + 1

            End If

            If Len(.Fields("HDD_Name_3").Value) = 0 Then
            Else
                oTable.Cell(intj, 1).Range.Text = LNGIniFile.GetString("MOD_OPENOFFICE", "MSG15", "Жесткий диск")
                oTable.Cell(intj, 2).Range.Text = .Fields("HDD_Name_3").Value & ", " & .Fields("HDD_OB_3").Value &
                                                  ", SN: " & .Fields("HDD_SN_3").Value
                oTable.Cell(intj, 3).Range.Text = .Fields("HDD_PROIZV_3").Value

                intj = intj + 1

            End If

            If Len(.Fields("HDD_Name_4").Value) = 0 Then
            Else
                oTable.Cell(intj, 1).Range.Text = LNGIniFile.GetString("MOD_OPENOFFICE", "MSG15", "Жесткий диск")
                oTable.Cell(intj, 2).Range.Text = .Fields("HDD_Name_4").Value & ", " & .Fields("HDD_OB_4").Value &
                                                  ", SN: " & .Fields("HDD_SN_4").Value
                oTable.Cell(intj, 3).Range.Text = .Fields("HDD_PROIZV_4").Value

                intj = intj + 1

            End If

            If Len(.Fields("FDD_NAME").Value) = 0 Then
            Else
                oTable.Cell(intj, 1).Range.Text = LNGIniFile.GetString("MOD_OPENOFFICE", "MSG16", "Дисковод")
                oTable.Cell(intj, 2).Range.Text = .Fields("FDD_NAME").Value & ", SN: " & .Fields("FDD_SN").Value
                oTable.Cell(intj, 3).Range.Text = .Fields("FDD_PROIZV").Value

                intj = intj + 1

            End If

            If Len(.Fields("SVGA_NAME").Value) = 0 Then
            Else
                oTable.Cell(intj, 1).Range.Text = LNGIniFile.GetString("MOD_OPENOFFICE", "MSG17", "Видео карта")
                oTable.Cell(intj, 2).Range.Text = .Fields("SVGA_NAME").Value & ", SN: " & .Fields("SVGA_SN").Value
                oTable.Cell(intj, 3).Range.Text = .Fields("SVGA_PROIZV").Value

                intj = intj + 1

            End If

            If Len(.Fields("SOUND_NAME").Value) = 0 Then
            Else
                oTable.Cell(intj, 1).Range.Text = LNGIniFile.GetString("MOD_OPENOFFICE", "MSG18", "Звуковая карта")
                oTable.Cell(intj, 2).Range.Text = .Fields("SOUND_NAME").Value & ", SN: " & .Fields("SOUND_SN").Value
                oTable.Cell(intj, 3).Range.Text = .Fields("SOUND_PROIZV").Value

                intj = intj + 1

            End If

            If Len(.Fields("CD_NAME").Value) = 0 Then
            Else
                oTable.Cell(intj, 1).Range.Text = LNGIniFile.GetString("MOD_OPENOFFICE", "MSG19", "Оптический диск")
                oTable.Cell(intj, 2).Range.Text = .Fields("CD_NAME").Value & ", SN: " & .Fields("CD_SN").Value
                oTable.Cell(intj, 3).Range.Text = .Fields("CD_PROIZV").Value

                intj = intj + 1

            End If

            If Len(.Fields("CDRW_NAME").Value) = 0 Then
            Else
                oTable.Cell(intj, 1).Range.Text = LNGIniFile.GetString("MOD_OPENOFFICE", "MSG19", "Оптический диск")
                oTable.Cell(intj, 2).Range.Text = .Fields("CDRW_NAME").Value & ", SN: " & .Fields("CDRW_SN").Value
                oTable.Cell(intj, 3).Range.Text = .Fields("CDRW_PROIZV").Value

                intj = intj + 1

            End If

            If Len(.Fields("DVD_NAME").Value) = 0 Then
            Else
                oTable.Cell(intj, 1).Range.Text = LNGIniFile.GetString("MOD_OPENOFFICE", "MSG19", "Оптический диск")
                oTable.Cell(intj, 2).Range.Text = .Fields("DVD_NAME").Value & ", SN: " & .Fields("DVD_SN").Value
                oTable.Cell(intj, 3).Range.Text = .Fields("DVD_PROIZV").Value

                intj = intj + 1

            End If

            If Len(.Fields("NET_NAME_1").Value) = 0 Then
            Else
                oTable.Cell(intj, 1).Range.Text = LNGIniFile.GetString("MOD_OPENOFFICE", "MSG20", "Сетевая карта")
                oTable.Cell(intj, 2).Range.Text = .Fields("NET_NAME_1").Value & ", MAC: " & .Fields("NET_MAC_1").Value
                oTable.Cell(intj, 3).Range.Text = .Fields("NET_PROIZV_1").Value

                intj = intj + 1

            End If

            If Len(.Fields("NET_NAME_2").Value) = 0 Then
            Else
                oTable.Cell(intj, 1).Range.Text = LNGIniFile.GetString("MOD_OPENOFFICE", "MSG20", "Сетевая карта")
                oTable.Cell(intj, 2).Range.Text = .Fields("NET_NAME_2").Value & ", MAC: " & .Fields("NET_MAC_2").Value
                oTable.Cell(intj, 3).Range.Text = .Fields("NET_PROIZV_2").Value

                intj = intj + 1

            End If

            If Len(.Fields("BLOCK").Value) = 0 Then
            Else
                oTable.Cell(intj, 1).Range.Text = LNGIniFile.GetString("MOD_OPENOFFICE", "MSG21", "Блок питания")
                oTable.Cell(intj, 2).Range.Text = .Fields("BLOCK").Value & ", SN: " & .Fields("SN_BLOCK").Value
                oTable.Cell(intj, 3).Range.Text = .Fields("PROIZV_BLOCK").Value

                intj = intj + 1

            End If

            If Len(.Fields("KEYBOARD_NAME").Value) = 0 Then
            Else
                oTable.Cell(intj, 1).Range.Text = LNGIniFile.GetString("MOD_OPENOFFICE", "MSG22", "Клавиатура")
                oTable.Cell(intj, 2).Range.Text = .Fields("KEYBOARD_NAME").Value & ", SN: " &
                                                  .Fields("KEYBOARD_SN").Value
                oTable.Cell(intj, 3).Range.Text = .Fields("KEYBOARD_PROIZV").Value

                intj = intj + 1

            End If

            If Len(.Fields("MOUSE_NAME").Value) = 0 Then
            Else
                oTable.Cell(intj, 1).Range.Text = LNGIniFile.GetString("MOD_OPENOFFICE", "MSG23", "Мышь")
                oTable.Cell(intj, 2).Range.Text = .Fields("MOUSE_NAME").Value & ", SN: " & .Fields("MOUSE_SN").Value
                oTable.Cell(intj, 3).Range.Text = .Fields("MOUSE_PROIZV").Value

                intj = intj + 1

            End If

            If Len(.Fields("MONITOR_NAME").Value) = 0 Then
            Else
                oTable.Cell(intj, 1).Range.Text = LNGIniFile.GetString("MOD_OPENOFFICE", "MSG24", "Монитор")
                oTable.Cell(intj, 2).Range.Text = .Fields("MONITOR_NAME").Value & ", SN: " & .Fields("MONITOR_SN").Value
                oTable.Cell(intj, 3).Range.Text = .Fields("MONITOR_PROIZV").Value

                intj = intj + 1

            End If

            If Len(.Fields("MONITOR_NAME2").Value) = 0 Then
            Else
                oTable.Cell(intj, 1).Range.Text = LNGIniFile.GetString("MOD_OPENOFFICE", "MSG24", "Монитор")
                oTable.Cell(intj, 2).Range.Text = .Fields("MONITOR_NAME2").Value & ", SN: " &
                                                  .Fields("MONITOR_SN2").Value
                oTable.Cell(intj, 3).Range.Text = .Fields("MONITOR_PROIZV2").Value

                intj = intj + 1

            End If

            If Len(.Fields("AS_NAME").Value) = 0 Then
            Else
                oTable.Cell(intj, 1).Range.Text = LNGIniFile.GetString("MOD_OPENOFFICE", "MSG25", "Акустическая система")
                oTable.Cell(intj, 2).Range.Text = .Fields("AS_NAME").Value & ", SN: " & .Fields("AS_SN").Value
                oTable.Cell(intj, 3).Range.Text = .Fields("AS_PROIZV").Value

                intj = intj + 1

            End If


            If Len(.Fields("FILTR_NAME").Value) = 0 Then
            Else
                oTable.Cell(intj, 1).Range.Text = LNGIniFile.GetString("MOD_OPENOFFICE", "MSG26", "Сетевой фильтр")
                oTable.Cell(intj, 2).Range.Text = .Fields("FILTR_NAME").Value & ", SN: " & .Fields("FILTR_SN").Value
                oTable.Cell(intj, 3).Range.Text = .Fields("FILTR_PROIZV").Value

                intj = intj + 1

            End If


            If Len(.Fields("PRINTER_NAME_1").Value) = 0 Then
            Else
                oTable.Cell(intj, 1).Range.Text = LNGIniFile.GetString("MOD_OPENOFFICE", "MSG27", "Принтер")
                oTable.Cell(intj, 2).Range.Text = .Fields("PRINTER_NAME_1").Value & ", SN: " &
                                                  .Fields("PRINTER_SN_1").Value
                oTable.Cell(intj, 3).Range.Text = .Fields("PRINTER_PROIZV_1").Value

                intj = intj + 1

            End If

            If Len(.Fields("PRINTER_NAME_2").Value) = 0 Then
            Else
                oTable.Cell(intj, 1).Range.Text = LNGIniFile.GetString("MOD_OPENOFFICE", "MSG27", "Принтер")
                oTable.Cell(intj, 2).Range.Text = .Fields("PRINTER_NAME_2").Value & ", SN: " &
                                                  .Fields("PRINTER_SN_2").Value
                oTable.Cell(intj, 3).Range.Text = .Fields("PRINTER_PROIZV_2").Value

                intj = intj + 1

            End If

            If Len(.Fields("PRINTER_NAME_3").Value) = 0 Then
            Else
                oTable.Cell(intj, 1).Range.Text = LNGIniFile.GetString("MOD_OPENOFFICE", "MSG27", "Принтер")
                oTable.Cell(intj, 2).Range.Text = .Fields("PRINTER_NAME_3").Value & ", SN: " &
                                                  .Fields("PRINTER_SN_3").Value
                oTable.Cell(intj, 3).Range.Text = .Fields("PRINTER_PROIZV_3").Value

                intj = intj + 1

            End If


        End With

        rs.Close()
        rs = Nothing


        'В составе устройства

        sSQL1 = "SELECT count(*) as t_n FROM kompy WHERE PCL=" & sID

        rs1 = New Recordset
        rs1.Open(sSQL1, DB7, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic)

        Dim GIST As String

        With rs1

            GIST = .Fields("t_n").Value

        End With

        rs1.Close()
        rs1 = Nothing

        If GIST = 0 Then

        Else
            oPara1 = oDoc.Content.Paragraphs.Add
            oPara1.Range.Text = ""
            oPara1.Range.Font.Bold = True
            oPara1.Format.SpaceAfter = 12    '24 pt spacing after paragraph.
            oPara1.Range.InsertParagraphAfter()

            oPara1 = oDoc.Content.Paragraphs.Add
            oPara1.Range.Text = LNGIniFile.GetString("MOD_OPENOFFICE", "MSG28", "В составе устройства")
            oPara1.Range.Font.Bold = True
            oPara1.Format.SpaceAfter = 12    '24 pt spacing after paragraph.
            oPara1.Range.InsertParagraphAfter()

            'iCOUNTFIELLDS + 1

            oTable = oDoc.Tables.Add(oDoc.Bookmarks.Item("\endofdoc").Range, GIST + 1, 3)
            oTable.Range.ParagraphFormat.SpaceAfter = 6
            oTable.Borders.Enable = True

            oTable.Cell(1, 1).Range.Text = LNGIniFile.GetString("MOD_OPENOFFICE", "MSG29", "Устройство")
            oTable.Cell(1, 2).Range.Text = LNGIniFile.GetString("MOD_OPENOFFICE", "MSG10", "Модель")
            oTable.Cell(1, 3).Range.Text = LNGIniFile.GetString("MOD_OPENOFFICE", "MSG31", "Серийный номер")

            sSQL1 = "SELECT * FROM kompy WHERE PCL=" & sID
            rs1 = New Recordset
            rs1.Open(sSQL1, DB7, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic)

            intj = 2

            With rs1
                If .RecordCount <> 0 Then
                    .MoveFirst()
                    Do While Not .EOF


                        Select Case .Fields("tiptehn").Value

                            Case "Printer"
                                oTable.Cell(intj, 1).Range.Text = LNGIniFile.GetString("MOD_OPENOFFICE", "MSG27",
                                                                                       "Принтер")
                                oTable.Cell(intj, 2).Range.Text = .Fields("NET_NAME").Value
                                oTable.Cell(intj, 3).Range.Text = .Fields("PRINTER_SN_1").Value

                            Case "MFU"
                                oTable.Cell(intj, 1).Range.Text = LNGIniFile.GetString("MOD_OPENOFFICE", "MSG32", "МФУ")
                                oTable.Cell(intj, 2).Range.Text = .Fields("NET_NAME").Value
                                oTable.Cell(intj, 3).Range.Text = .Fields("PRINTER_SN_1").Value

                            Case "MONITOR"
                                oTable.Cell(intj, 1).Range.Text = LNGIniFile.GetString("MOD_OPENOFFICE", "MSG24",
                                                                                       "Монитор")
                                oTable.Cell(intj, 2).Range.Text = .Fields("NET_NAME").Value
                                oTable.Cell(intj, 3).Range.Text = .Fields("MONITOR_SN").Value

                            Case "OT"
                                oTable.Cell(intj, 1).Range.Text = .Fields("TIP_COMPA").Value
                                oTable.Cell(intj, 2).Range.Text = .Fields("NET_NAME").Value
                                oTable.Cell(intj, 3).Range.Text = .Fields("PRINTER_SN_1").Value


                            Case "SCANER"
                                oTable.Cell(intj, 1).Range.Text = LNGIniFile.GetString("MOD_OPENOFFICE", "MSG34",
                                                                                       "Сканер")
                                oTable.Cell(intj, 2).Range.Text = .Fields("NET_NAME").Value
                                oTable.Cell(intj, 3).Range.Text = .Fields("PRINTER_SN_1").Value

                            Case "USB"
                                oTable.Cell(intj, 1).Range.Text = LNGIniFile.GetString("MOD_OPENOFFICE", "MSG37",
                                                                                       "USB Устройство")
                                oTable.Cell(intj, 2).Range.Text = .Fields("NET_NAME").Value
                                oTable.Cell(intj, 3).Range.Text = .Fields("PRINTER_SN_1").Value

                            Case "IBP"
                                oTable.Cell(intj, 1).Range.Text = LNGIniFile.GetString("MOD_OPENOFFICE", "MSG35",
                                                                                       "Источник бесперебойного питания")
                                oTable.Cell(intj, 2).Range.Text = .Fields("NET_NAME").Value
                                oTable.Cell(intj, 3).Range.Text = .Fields("PRINTER_SN_1").Value

                            Case "FS"
                                oTable.Cell(intj, 1).Range.Text = LNGIniFile.GetString("MOD_OPENOFFICE", "MSG26",
                                                                                       "Сетевой фильтр")
                                oTable.Cell(intj, 2).Range.Text = .Fields("NET_NAME").Value
                                oTable.Cell(intj, 3).Range.Text = .Fields("PRINTER_SN_1").Value

                            Case "SOUND"
                                oTable.Cell(intj, 1).Range.Text = LNGIniFile.GetString("MOD_OPENOFFICE", "MSG25",
                                                                                       "Акустическая система")
                                oTable.Cell(intj, 2).Range.Text = .Fields("NET_NAME").Value
                                oTable.Cell(intj, 3).Range.Text = .Fields("PRINTER_SN_1").Value


                            Case "MOUSE"

                                oTable.Cell(intj, 1).Range.Text = LNGIniFile.GetString("MOD_OPENOFFICE", "MSG23", "Мышь")
                                oTable.Cell(intj, 2).Range.Text = .Fields("NET_NAME").Value
                                oTable.Cell(intj, 3).Range.Text = .Fields("PRINTER_SN_1").Value

                            Case "KEYB"

                                oTable.Cell(intj, 1).Range.Text = LNGIniFile.GetString("MOD_OPENOFFICE", "MSG22",
                                                                                       "Клавиатура")
                                oTable.Cell(intj, 2).Range.Text = .Fields("NET_NAME").Value
                                oTable.Cell(intj, 3).Range.Text = .Fields("PRINTER_SN_1").Value


                        End Select


                        intj = intj + 1

                        .MoveNext()
                    Loop
                End If
            End With
            rs1.Close()
            rs1 = Nothing

        End If

        'Установленное ПО

        sSQL1 = "SELECT count(*) as t_n FROM SOFT_INSTALL WHERE id_comp=" & sID

        rs1 = New Recordset
        rs1.Open(sSQL1, DB7, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic)

        With rs1

            GIST = .Fields("t_n").Value

        End With

        rs1.Close()
        rs1 = Nothing

        If GIST = 0 Then
        Else

            oPara1 = oDoc.Content.Paragraphs.Add
            oPara1.Range.Text = ""
            oPara1.Range.Font.Bold = True
            oPara1.Format.SpaceAfter = 12    '24 pt spacing after paragraph.
            oPara1.Range.InsertParagraphAfter()

            oPara1 = oDoc.Content.Paragraphs.Add
            oPara1.Range.Text = LNGIniFile.GetString("MOD_OPENOFFICE", "MSG38", "Установленное Программное обеспечение")
            oPara1.Range.Font.Bold = True
            oPara1.Format.SpaceAfter = 12    '24 pt spacing after paragraph.
            oPara1.Range.InsertParagraphAfter()


            'iCOUNTFIELLDS + 1

            oTable = oDoc.Tables.Add(oDoc.Bookmarks.Item("\endofdoc").Range, GIST + 1, 1)
            oTable.Range.ParagraphFormat.SpaceAfter = 6
            oTable.Borders.Enable = True

            oTable.Cell(1, 1).Range.Text = LNGIniFile.GetString("MOD_OPENOFFICE", "MSG38",
                                                                "Установленное Программное обеспечение")

            intj = 2

            sSQL1 = "SELECT * FROM SOFT_INSTALL WHERE id_comp=" & sID
            rs1 = New Recordset
            rs1.Open(sSQL1, DB7, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic)
            With rs1
                If .RecordCount <> 0 Then
                    .MoveFirst()
                    Do While Not .EOF

                        oTable.Cell(intj, 1).Range.Text = .Fields("Soft").Value
                        intj = intj + 1

                        .MoveNext()
                    Loop
                End If
            End With

            rs1.Close()
            rs1 = Nothing


        End If

        '#####################################################################################
        'ПЕРЕМЕЩЕНИЕ ТЕХНИКИ


        Dim rscount As Recordset 'Объявляем рекордсет
        rscount = New Recordset
        rscount.Open("SELECT COUNT(*) AS total_number FROM dvig WHERE id_comp=" & sID, DB7, CursorTypeEnum.adOpenDynamic,
                     LockTypeEnum.adLockOptimistic)

        With rscount
            GIST = .Fields("total_number").Value
        End With

        rscount.Close()
        rscount = Nothing


        If GIST > 0 Then

            oPara1 = oDoc.Content.Paragraphs.Add
            oPara1.Range.Text = ""
            oPara1.Range.Font.Bold = True
            oPara1.Format.SpaceAfter = 12    '24 pt spacing after paragraph.
            oPara1.Range.InsertParagraphAfter()

            oPara1 = oDoc.Content.Paragraphs.Add
            oPara1.Range.Text = LNGIniFile.GetString("MOD_OPENOFFICE", "MSG39", "Перемещение техники")
            oPara1.Range.Font.Bold = True
            oPara1.Format.SpaceAfter = 12    '24 pt spacing after paragraph.
            oPara1.Range.InsertParagraphAfter()

            oTable = oDoc.Tables.Add(oDoc.Bookmarks.Item("\endofdoc").Range, GIST + 1, 4)
            oTable.Range.ParagraphFormat.SpaceAfter = 6
            oTable.Borders.Enable = True

            oTable.Cell(1, 1).Range.Text = LNGIniFile.GetString("MOD_OPENOFFICE", "MSG40", "Старое место")
            oTable.Cell(1, 2).Range.Text = LNGIniFile.GetString("MOD_OPENOFFICE", "MSG41", "Новое место")
            oTable.Cell(1, 3).Range.Text = LNGIniFile.GetString("MOD_OPENOFFICE", "MSG42", "Причина")
            oTable.Cell(1, 4).Range.Text = LNGIniFile.GetString("MOD_OPENOFFICE", "MSG43", "Дата")

            intj = 2
            rscount = New Recordset
            rscount.Open("SELECT * FROM dvig WHERE id_comp=" & sID & " ORDER BY D_T", DB7, CursorTypeEnum.adOpenDynamic,
                         LockTypeEnum.adLockOptimistic)

            intj = 2
            With rscount
                .MoveFirst()
                Do While Not .EOF = True

                    oTable.Cell(intj, 1).Range.Text = .Fields("oldMesto").Value
                    oTable.Cell(intj, 2).Range.Text = .Fields("NewMesto").Value
                    oTable.Cell(intj, 3).Range.Text = .Fields("Prich").Value
                    oTable.Cell(intj, 4).Range.Text = .Fields("D_T").Value
                    intj = intj + 1

                    .MoveNext()
                    'DoEvents
                Loop
            End With
            rscount.Close()
            rscount = Nothing


        End If

        '#####################################################################################
        'РЕМОНТЫ

        rscount = New Recordset
        rscount.Open("SELECT COUNT(*) AS total_number FROM Remont WHERE id_comp=" & sID, DB7,
                     CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic)

        With rscount
            GIST = .Fields("total_number").Value
        End With

        rscount.Close()
        rscount = Nothing


        If GIST > 0 Then

            oPara1 = oDoc.Content.Paragraphs.Add
            oPara1.Range.Text = ""
            oPara1.Range.Font.Bold = True
            oPara1.Format.SpaceAfter = 12    '24 pt spacing after paragraph.
            oPara1.Range.InsertParagraphAfter()

            oPara1 = oDoc.Content.Paragraphs.Add
            oPara1.Range.Text = LNGIniFile.GetString("MOD_OPENOFFICE", "MSG44", "Ремонты")
            oPara1.Range.Font.Bold = True
            oPara1.Format.SpaceAfter = 12    '24 pt spacing after paragraph.
            oPara1.Range.InsertParagraphAfter()

            oTable = oDoc.Tables.Add(oDoc.Bookmarks.Item("\endofdoc").Range, GIST + 1, 5)
            oTable.Range.ParagraphFormat.SpaceAfter = 6
            oTable.Borders.Enable = True

            oTable.Cell(1, 1).Range.Text = LNGIniFile.GetString("MOD_OPENOFFICE", "MSG43", "Дата")
            oTable.Cell(1, 2).Range.Text = LNGIniFile.GetString("MOD_OPENOFFICE", "MSG46", "Ремонт")
            oTable.Cell(1, 3).Range.Text = LNGIniFile.GetString("MOD_OPENOFFICE", "MSG47", "Мастер")
            oTable.Cell(1, 4).Range.Text = LNGIniFile.GetString("MOD_OPENOFFICE", "MSG48", "Уровень")
            oTable.Cell(1, 5).Range.Text = LNGIniFile.GetString("MOD_OPENOFFICE", "MSG49", "Выполнение")

            rscount = New Recordset
            rscount.Open("SELECT * FROM Remont WHERE id_comp=" & sID & " ORDER BY D_T", DB7,
                         CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic)

            'Dim A As String

            intj = 2
            With rscount
                .MoveFirst()
                Do While Not .EOF = True

                    oTable.Cell(intj, 1).Range.Text = .Fields("D_T").Value
                    oTable.Cell(intj, 2).Range.Text = .Fields("Remont").Value
                    oTable.Cell(intj, 3).Range.Text = .Fields("Master").Value
                    oTable.Cell(intj, 4).Range.Text = .Fields("Uroven").Value
                    oTable.Cell(intj, 5).Range.Text = .Fields("vip").Value
                    intj = intj + 1


                    .MoveNext()
                    'DoEvents
                Loop
            End With
            rscount.Close()
            rscount = Nothing


        End If


        oPara1 = oDoc.Content.Paragraphs.Add
        oPara1.Range.Text = ""
        oPara1.Range.Font.Bold = True
        oPara1.Format.SpaceAfter = 12    '24 pt spacing after paragraph.
        oPara1.Range.InsertParagraphAfter()

        oPara1 = oDoc.Content.Paragraphs.Add
        oPara1.Range.Text = LNGIniFile.GetString("MOD_OPENOFFICE", "MSG50", "Подписи")
        oPara1.Range.Font.Bold = True
        oPara1.Format.SpaceAfter = 12    '24 pt spacing after paragraph.
        oPara1.Range.InsertParagraphAfter()

        oTable = oDoc.Tables.Add(oDoc.Bookmarks.Item("\endofdoc").Range, 3, 2)
        oTable.Range.ParagraphFormat.SpaceAfter = 6
        oTable.Borders.Enable = True

        oTable.Cell(1, 1).Range.Text = LNGIniFile.GetString("MOD_OPENOFFICE", "MSG51", "Системный администратор")
        oTable.Cell(1, 2).Range.Text = LNGIniFile.GetString("MOD_OPENOFFICE", "MSG52", "Подписи ответственных лиц")


        CONFIGURE = New Recordset
        CONFIGURE.Open("SELECT SISADM FROM CONFIGURE", DB7, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic)
        With CONFIGURE
            If .RecordCount <> 0 Then
                If Not IsDBNull(.Fields("SISADM")) Then uname = .Fields("SISADM").Value
            Else
                uname = "Nothing"
            End If
        End With
        CONFIGURE.Close()
        CONFIGURE = Nothing

        oTable.Cell(2, 1).Range.Text = uname
        oTable.Cell(2, 2).Range.Text = cOTV
        oTable.Cell(3, 1).Range.Text = DateAndTime.Today
        oTable.Cell(3, 2).Range.Text = DateAndTime.Today
    End Sub

    Public Sub blanks_my_wrd(ByVal tipot As String)
        Dim sSQL, sSQL1, SISADM, Organ As String
        Dim LNGIniFile As New IniFile(sLANGPATH)
        Dim uname As String


        If Len(tipot) = 0 Then Exit Sub
        On Error Resume Next

        Dim rs1 As Recordset
        sSQL1 = "SELECT org,SISADM FROM CONFIGURE"
        rs1 = New Recordset
        rs1.Open(sSQL1, DB7, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic)

        With rs1
            Organ = .Fields("org").Value
            SISADM$ = .Fields("SISADM").Value
        End With
        rs1.Close()
        rs1 = Nothing


        Dim rs As Recordset
        sSQL = "SELECT * FROM kompy WHERE id = " & frmComputers.sCOUNT
        rs = New Recordset
        rs.Open(sSQL, DB7, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic)

        Dim intj As String
        Dim A, B, C, D, E As String

        Dim Wrd As Application
        Dim WrdDc As Document
        Wrd = New Application

        Dim oDoc As Document
        Dim oTable As Table
        Dim oPara1 As Paragraph, oPara2 As Paragraph
        Dim oPara3 As Paragraph, oPara4 As Paragraph
        Dim oRng As Range
        Dim oShape As InlineShape
        Dim oChart As Object
        Dim Pos As Double

        WrdDc = Wrd.Documents.Open(tipot, , False)  'Application.
        WrdDc.Application.Visible = True

        Wrd.Selection.Find.ClearFormatting()
        Wrd.Selection.Find.Replacement.ClearFormatting()

        With Wrd.Selection.Find
            .Text = "Организация"
            .Replacement.Text = Organ
            .Forward = True
            .Wrap = WdFindWrap.wdFindContinue
            .Format = False
            .MatchCase = True
            .MatchWholeWord = False
            .MatchWildcards = False
            ' .MatchSoundsLike = False
            .MatchAllWordForms = False
        End With
        Wrd.Selection.Find.Execute(Replace:=WdReplace.wdReplaceAll)

        With Wrd.Selection.Find
            .Text = "Сисадмин"
            .Replacement.Text = SISADM
            .Forward = True
            .Wrap = WdFindWrap.wdFindContinue
            .Format = False
            .MatchCase = True
            .MatchWholeWord = False
            .MatchWildcards = False
            ' .MatchSoundsLike = False
            .MatchAllWordForms = False
        End With
        Wrd.Selection.Find.Execute(Replace:=WdReplace.wdReplaceAll)


        Dim lngCounter As Integer
        Dim FirstColumn As Boolean

        Do Until rs.EOF
            FirstColumn = True      'FIRST COLUMN IS A LISTITEM, REST ARE LISTSUBITEMS


            If DB_N <> "MS Access" Then uname = 2 Else uname = 1

            For lngCounter = 0 To rs.Fields.Count - uname

                If FirstColumn Then
                    If Not IsDBNull(rs.Fields(lngCounter).Value) Then

                        With Wrd.Selection.Find
                            .Text = rs.Fields(lngCounter).Name
                            .Replacement.Text = rs.Fields(lngCounter).Value
                            .Forward = True
                            .Wrap = WdFindWrap.wdFindContinue
                            .Format = False
                            .MatchCase = True
                            .MatchWholeWord = False
                            .MatchWildcards = False
                            ' .MatchSoundsLike = False
                            .MatchAllWordForms = False
                        End With
                        Wrd.Selection.Find.Execute(Replace:=WdReplace.wdReplaceAll)

                    Else

                    End If                  'TO KEEP DATA FROM SHIFTING LEFT
                    FirstColumn = False
                Else
                    If Not IsDBNull(rs.Fields(lngCounter).Value) Then
                        With Wrd.Selection.Find
                            .Text = rs.Fields(lngCounter).Name
                            .Replacement.Text = rs.Fields(lngCounter).Value
                            .Forward = True
                            .Wrap = WdFindWrap.wdFindContinue
                            .Format = False
                            .MatchCase = True
                            .MatchWholeWord = False
                            .MatchWildcards = False
                            ' .MatchSoundsLike = False
                            .MatchAllWordForms = False
                        End With
                        Wrd.Selection.Find.Execute(Replace:=WdReplace.wdReplaceAll)
                    Else

                    End If
                End If
            Next
            rs.MoveNext()
        Loop

        rs.Close()
        rs = Nothing


        Dim rs2 As Recordset
        rs2 = New Recordset
        rs2.Open("Select Postav FROM Garantia_sis WHERE Id_Comp=" & frmComputers.sCOUNT, DB7,
                         CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic)


        With rs2
            uname = .Fields("Postav").Value
        End With
        rs2.Close()
        rs2 = Nothing

        With Wrd.Selection.Find
            .Text = "Postav"
            .Replacement.Text = uname
            .Forward = True
            .Wrap = WdFindWrap.wdFindContinue
            .Format = False
            .MatchCase = True
            .MatchWholeWord = False
            .MatchWildcards = False
            ' .MatchSoundsLike = False
            .MatchAllWordForms = False
        End With
        Wrd.Selection.Find.Execute(Replace:=WdReplace.wdReplaceAll)

        oPara1 = oDoc.Content.Paragraphs.Add
        oPara1.Range.Text = ""
        oPara1.Range.Font.Bold = True
        oPara1.Format.SpaceAfter = 24    '24 pt spacing after paragraph.
        oPara1.Range.InsertParagraphAfter()

        'В составе устройства
        '#####################################################################################


        Dim GIST As String


        Dim objIniFile As New IniFile(PrPath & "base.ini")
        uname = objIniFile.GetString("MYBLANK", "VSU", "0")

        If uname = 1 Then


            sSQL1 = "SELECT count(*) as t_n FROM kompy WHERE PCL=" & frmComputers.sCOUNT

            rs1 = New Recordset
            rs1.Open(sSQL1, DB7, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic)

            With rs1

                GIST = .Fields("t_n").Value

            End With

            rs1.Close()
            rs1 = Nothing

            If GIST = 0 Then

            Else


                oPara1 = WrdDc.Content.Paragraphs.Add
                oPara1.Range.Text = ""
                oPara1.Range.Font.Bold = True
                oPara1.Format.SpaceAfter = 24    '24 pt spacing after paragraph.
                oPara1.Range.InsertParagraphAfter()

                oPara1 = WrdDc.Content.Paragraphs.Add
                oPara1.Range.Text = LNGIniFile.GetString("MOD_OPENOFFICE", "MSG28", "В составе устройства")
                oPara1.Range.Font.Bold = True
                oPara1.Format.SpaceAfter = 24    '24 pt spacing after paragraph.
                oPara1.Range.InsertParagraphAfter()

                'iCOUNTFIELLDS + 1


                oTable = WrdDc.Tables.Add(WrdDc.Bookmarks.Item("\endofdoc").Range, GIST + 1, 4)
                oTable.Range.ParagraphFormat.SpaceAfter = 6

                oTable.Cell(1, 1).Range.Text = LNGIniFile.GetString("MOD_OPENOFFICE", "MSG29", "Устройство")
                oTable.Cell(1, 2).Range.Text = LNGIniFile.GetString("MOD_OPENOFFICE", "MSG10", "Модель")
                oTable.Cell(1, 3).Range.Text = LNGIniFile.GetString("MOD_OPENOFFICE", "MSG31", "Серийный номер")
                oTable.Cell(1, 4).Range.Text = LNGIniFile.GetString("MOD_OPENOFFICE", "MSG8", "Инвентарный номер")

                sSQL1 = "SELECT * FROM kompy WHERE PCL=" & frmComputers.sCOUNT
                rs1 = New Recordset
                rs1.Open(sSQL1, DB7, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic)

                intj = 2

                With rs1
                    .MoveFirst()
                    Do While Not .EOF

                        Select Case .Fields("tiptehn").Value

                            Case "Printer"
                                oTable.Cell(intj, 1).Range.Text = LNGIniFile.GetString("MOD_OPENOFFICE", "MSG27",
                                                                                       "Принтер")
                                oTable.Cell(intj, 2).Range.Text = .Fields("NET_NAME").Value
                                oTable.Cell(intj, 3).Range.Text = .Fields("PRINTER_SN_1").Value
                                oTable.Cell(intj, 4).Range.Text = .Fields("INV_NO_PRINTER").Value

                            Case "MFU"
                                oTable.Cell(intj, 1).Range.Text = LNGIniFile.GetString("MOD_OPENOFFICE", "MSG32", "МФУ")
                                oTable.Cell(intj, 2).Range.Text = .Fields("NET_NAME").Value
                                oTable.Cell(intj, 3).Range.Text = .Fields("PRINTER_SN_1").Value
                                oTable.Cell(intj, 4).Range.Text = .Fields("INV_NO_PRINTER").Value

                            Case "MONITOR"
                                oTable.Cell(intj, 1).Range.Text = LNGIniFile.GetString("MOD_OPENOFFICE", "MSG24",
                                                                                       "Монитор")
                                oTable.Cell(intj, 2).Range.Text = .Fields("NET_NAME").Value
                                oTable.Cell(intj, 3).Range.Text = .Fields("MONITOR_SN").Value
                                oTable.Cell(intj, 4).Range.Text = .Fields("INV_NO_MONITOR").Value

                            Case "OT"
                                oTable.Cell(intj, 1).Range.Text = .Fields("TIP_COMPA").Value
                                oTable.Cell(intj, 2).Range.Text = .Fields("NET_NAME").Value
                                oTable.Cell(intj, 3).Range.Text = .Fields("PRINTER_SN_1").Value
                                oTable.Cell(intj, 4).Range.Text = .Fields("INV_NO_PRINTER").Value

                            Case "SCANER"
                                oTable.Cell(intj, 1).Range.Text = LNGIniFile.GetString("MOD_OPENOFFICE", "MSG34",
                                                                                       "Сканер")
                                oTable.Cell(intj, 2).Range.Text = .Fields("NET_NAME").Value
                                oTable.Cell(intj, 3).Range.Text = .Fields("PRINTER_SN_1").Value
                                oTable.Cell(intj, 4).Range.Text = .Fields("INV_NO_PRINTER").Value


                            Case "USB"
                                oTable.Cell(intj, 1).Range.Text = LNGIniFile.GetString("MOD_OPENOFFICE", "MSG37",
                                                                                       "USB Устройство")
                                oTable.Cell(intj, 2).Range.Text = .Fields("NET_NAME").Value
                                oTable.Cell(intj, 3).Range.Text = .Fields("PRINTER_SN_1").Value
                                oTable.Cell(intj, 4).Range.Text = .Fields("INV_NO_PRINTER").Value

                            Case "IBP"
                                oTable.Cell(intj, 1).Range.Text = LNGIniFile.GetString("MOD_OPENOFFICE", "MSG35",
                                                                                       "Источник бесперебойного питания")
                                oTable.Cell(intj, 2).Range.Text = .Fields("NET_NAME").Value
                                oTable.Cell(intj, 3).Range.Text = .Fields("PRINTER_SN_1").Value
                                oTable.Cell(intj, 4).Range.Text = .Fields("INV_NO_PRINTER").Value

                            Case "FS"
                                oTable.Cell(intj, 1).Range.Text = LNGIniFile.GetString("MOD_OPENOFFICE", "MSG26",
                                                                                       "Сетевой фильтр")
                                oTable.Cell(intj, 2).Range.Text = .Fields("NET_NAME").Value
                                oTable.Cell(intj, 3).Range.Text = .Fields("PRINTER_SN_1").Value
                                oTable.Cell(intj, 4).Range.Text = .Fields("INV_NO_PRINTER").Value

                            Case "SOUND"
                                oTable.Cell(intj, 1).Range.Text = LNGIniFile.GetString("MOD_OPENOFFICE", "MSG25",
                                                                                       "Акустическая система")
                                oTable.Cell(intj, 2).Range.Text = .Fields("NET_NAME").Value
                                oTable.Cell(intj, 3).Range.Text = .Fields("PRINTER_SN_1").Value
                                oTable.Cell(intj, 4).Range.Text = .Fields("INV_NO_PRINTER").Value


                            Case "MOUSE"
                                oTable.Cell(intj, 1).Range.Text = LNGIniFile.GetString("MOD_OPENOFFICE", "MSG23",
                                                                                     "Мышь")
                                oTable.Cell(intj, 2).Range.Text = .Fields("NET_NAME").Value
                                oTable.Cell(intj, 3).Range.Text = .Fields("PRINTER_SN_1").Value
                                oTable.Cell(intj, 4).Range.Text = .Fields("INV_NO_PRINTER").Value

                            Case "KEYB"

                                oTable.Cell(intj, 1).Range.Text = LNGIniFile.GetString("MOD_OPENOFFICE", "MSG22",
                                                                                     "Клавиатура")
                                oTable.Cell(intj, 2).Range.Text = .Fields("NET_NAME").Value
                                oTable.Cell(intj, 3).Range.Text = .Fields("PRINTER_SN_1").Value
                                oTable.Cell(intj, 4).Range.Text = .Fields("INV_NO_PRINTER").Value



                        End Select

                        intj = intj + 1

                        .MoveNext()
                    Loop

                End With
                rs1.Close()
                rs1 = Nothing

            End If

        End If


        'Установленное ПО

        uname = objIniFile.GetString("MYBLANK", "POu", "0")

        If uname = 1 Then

            sSQL1 = "SELECT count(*) as t_n FROM SOFT_INSTALL WHERE id_comp=" & frmComputers.sCOUNT

            rs1 = New Recordset
            rs1.Open(sSQL1, DB7, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic)

            With rs1

                GIST = .Fields("t_n").Value

            End With

            rs1.Close()
            rs1 = Nothing

            If GIST = 0 Then
            Else

                oPara1 = WrdDc.Content.Paragraphs.Add
                oPara1.Range.Text = ""
                oPara1.Range.Font.Bold = True
                oPara1.Format.SpaceAfter = 24    '24 pt spacing after paragraph.
                oPara1.Range.InsertParagraphAfter()

                oPara1 = WrdDc.Content.Paragraphs.Add
                oPara1.Range.Text = LNGIniFile.GetString("MOD_OPENOFFICE", "MSG38",
                                                         "Установленное Программное обеспечение")
                oPara1.Range.Font.Bold = True
                oPara1.Format.SpaceAfter = 24    '24 pt spacing after paragraph.
                oPara1.Range.InsertParagraphAfter()


                'iCOUNTFIELLDS + 1

                oTable = WrdDc.Tables.Add(WrdDc.Bookmarks.Item("\endofdoc").Range, GIST + 1, 1)
                oTable.Range.ParagraphFormat.SpaceAfter = 6

                oTable.Cell(1, 1).Range.Text = LNGIniFile.GetString("MOD_OPENOFFICE", "MSG38",
                                                                    "Установленное Программное обеспечение")

                intj = 2

                sSQL1 = "SELECT * FROM SOFT_INSTALL WHERE id_comp=" & frmComputers.sCOUNT
                rs1 = New Recordset
                rs1.Open(sSQL1, DB7, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic)
                With rs1
                    If .RecordCount <> 0 Then
                        .MoveFirst()
                        Do While Not .EOF

                            oTable.Cell(intj, 1).Range.Text = .Fields("Soft").Value
                            intj = intj + 1

                            .MoveNext()
                        Loop
                    End If
                End With

                rs1.Close()
                rs1 = Nothing


            End If

        End If


        '#####################################################################################
        'ПЕРЕМЕЩЕНИЕ ТЕХНИКИ
        Dim rscount As Recordset 'Объявляем рекордсет

        uname = objIniFile.GetString("MYBLANK", "DVIG", "0")

        If uname = 1 Then

            rscount = New Recordset
            rscount.Open("SELECT COUNT(*) AS total_number FROM dvig WHERE id_comp=" & frmComputers.sCOUNT, DB7,
                         CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic)

            With rscount
                GIST = .Fields("total_number").Value
            End With

            rscount.Close()
            rscount = Nothing


            If GIST > 0 Then

                oPara1 = WrdDc.Content.Paragraphs.Add
                oPara1.Range.Text = ""
                oPara1.Range.Font.Bold = True
                oPara1.Format.SpaceAfter = 24    '24 pt spacing after paragraph.
                oPara1.Range.InsertParagraphAfter()

                oPara1 = WrdDc.Content.Paragraphs.Add
                oPara1.Range.Text = LNGIniFile.GetString("MOD_OPENOFFICE", "MSG39", "Перемещение техники")
                oPara1.Range.Font.Bold = True
                oPara1.Format.SpaceAfter = 12    '24 pt spacing after paragraph.
                oPara1.Range.InsertParagraphAfter()

                oTable = WrdDc.Tables.Add(WrdDc.Bookmarks.Item("\endofdoc").Range, GIST + 1, 4)
                oTable.Range.ParagraphFormat.SpaceAfter = 6

                oTable.Cell(1, 1).Range.Text = LNGIniFile.GetString("MOD_OPENOFFICE", "MSG40", "Старое место")
                oTable.Cell(1, 2).Range.Text = LNGIniFile.GetString("MOD_OPENOFFICE", "MSG41", "Новое место")
                oTable.Cell(1, 3).Range.Text = LNGIniFile.GetString("MOD_OPENOFFICE", "MSG42", "Причина")
                oTable.Cell(1, 4).Range.Text = LNGIniFile.GetString("MOD_OPENOFFICE", "MSG43", "Дата")

                intj = 2
                rscount = New Recordset
                rscount.Open("SELECT * FROM dvig WHERE id_comp=" & frmComputers.sCOUNT, DB7,
                             CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic)

                intj = 2
                With rscount
                    .MoveFirst()
                    Do While Not .EOF = True

                        oTable.Cell(intj, 1).Range.Text = .Fields("oldMesto").Value
                        oTable.Cell(intj, 2).Range.Text = .Fields("NewMesto").Value
                        oTable.Cell(intj, 3).Range.Text = .Fields("Prich").Value
                        oTable.Cell(intj, 4).Range.Text = .Fields("D_T").Value
                        intj = intj + 1

                        .MoveNext()
                        'DoEvents
                    Loop
                End With
                rscount.Close()
                rscount = Nothing


            End If

        End If

        '#####################################################################################
        'РЕМОНТЫ

        uname = objIniFile.GetString("MYBLANK", "REMONT", "0")

        If uname = 1 Then

            rscount = New Recordset
            rscount.Open("SELECT COUNT(*) AS total_number FROM Remont WHERE id_comp=" & frmComputers.sCOUNT, DB7,
                         CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic)

            With rscount
                GIST = .Fields("total_number").Value
            End With

            rscount.Close()
            rscount = Nothing


            If GIST > 0 Then

                oPara1 = WrdDc.Content.Paragraphs.Add
                oPara1.Range.Text = ""
                oPara1.Range.Font.Bold = True
                oPara1.Format.SpaceAfter = 12    '24 pt spacing after paragraph.
                oPara1.Range.InsertParagraphAfter()

                oPara1 = WrdDc.Content.Paragraphs.Add
                oPara1.Range.Text = LNGIniFile.GetString("MOD_OPENOFFICE", "MSG44", "Ремонты")
                oPara1.Range.Font.Bold = True
                oPara1.Format.SpaceAfter = 12    '24 pt spacing after paragraph.
                oPara1.Range.InsertParagraphAfter()

                oTable = WrdDc.Tables.Add(WrdDc.Bookmarks.Item("\endofdoc").Range, GIST + 1, 5)
                oTable.Range.ParagraphFormat.SpaceAfter = 6

                oTable.Cell(1, 1).Range.Text = LNGIniFile.GetString("MOD_OPENOFFICE", "MSG43", "Дата")
                oTable.Cell(1, 2).Range.Text = LNGIniFile.GetString("MOD_OPENOFFICE", "MSG46", "Ремонт")
                oTable.Cell(1, 3).Range.Text = LNGIniFile.GetString("MOD_OPENOFFICE", "MSG47", "Мастер")
                oTable.Cell(1, 4).Range.Text = LNGIniFile.GetString("MOD_OPENOFFICE", "MSG48", "Уровень")
                oTable.Cell(1, 5).Range.Text = LNGIniFile.GetString("MOD_OPENOFFICE", "MSG49", "Выполнение")

                rscount = New Recordset
                rscount.Open("SELECT * FROM Remont WHERE id_comp=" & frmComputers.sCOUNT, DB7,
                             CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic)

                'Dim A As String

                intj = 2
                With rscount
                    .MoveFirst()
                    Do While Not .EOF = True

                        oTable.Cell(intj, 1).Range.Text = .Fields("D_T").Value
                        oTable.Cell(intj, 2).Range.Text = .Fields("Remont").Value
                        oTable.Cell(intj, 3).Range.Text = .Fields("Master").Value
                        oTable.Cell(intj, 4).Range.Text = .Fields("Uroven").Value
                        oTable.Cell(intj, 5).Range.Text = .Fields("vip").Value
                        intj = intj + 1


                        .MoveNext()
                        'DoEvents
                    Loop
                End With
                rscount.Close()
                rscount = Nothing


            End If
        End If
    End Sub

    Public Sub ExportListViewToCalc(ByVal listV As ListView, ByVal sTXT As String)
        On Error Resume Next

        Dim replacer As Object
        Dim objServiceManager, objDesktop, Cell As Object 'ODS, Sheets,
        Dim objCoreReflection, oDoc As Object 'objDocument,oSheet
        'Dim objText, objCursor As Object
        ' Dim objTable As Object
        Dim oCol As Object 'objRows, objRow,

        objServiceManager = CreateObject("com.sun.star.ServiceManager")
        objCoreReflection = objServiceManager.createInstance("com.sun.star.reflection.CoreReflection")


        objDesktop = objServiceManager.createInstance("com.sun.star.frame.Desktop")


        Dim args(-1) As Object

        '%$$$$$$$$$$$$
        objServiceManager = CreateObject("com.sun.star.ServiceManager")
        objDesktop = objServiceManager.createInstance("com.sun.star.frame.Desktop")

        Dim CurrentHeader As ColumnHeader

        oDoc = objDesktop.loadComponentFROMURL("private:factory/scalc", "_blank", 0, args)

        oSheet = oDoc.getSheets().getByIndex(0)


        Dim intj As Integer = 0
        Dim a, b As String

        ''Объединение ячеек
        'Dim intParaAdjust As Integer
        'Dim oRange As Object
        'oRange = oSheet.getCellRangeByName("A1:E1")
        'oRange.Merge(True)
        'oRange.ParaAdjust = intParaAdjust


        intj = 1
        a = "A1" '& intj


        'oSheet.getCellByPosition(intj - 1, 0).setString(sTXT)
        'intj = 3

        For Each CurrentHeader In listV.Columns

            a = "A" & intj
            b = CurrentHeader.Text
            oSheet.getCellByPosition(intj - 1, 0).setString(b)


            intj = intj + 1
        Next


        Dim STrX As Integer
        STrX = intj - 2

        listV.Select()
        For intj = 0 To listV.Items.Count - 1

            listV.Items(intj).Selected = True
            listV.Items(intj).EnsureVisible()

            For INTZ = 1 To STrX
                Cell = oSheet.getCellByPosition(0, intj + 1).setString(listV.Items.Item(intj).Text)

                Cell = oSheet.getCellByPosition(INTZ, intj + 1).setString(listV.Items(intj).SubItems(INTZ).Text)

                oCol = oSheet.getColumns().getByIndex(INTZ - 1)
                oCol.optimalWidth = True 'Autofit
                oCol = oSheet.getColumns().getByIndex(STrX)
                oCol.optimalWidth = True 'Autofit

            Next


        Next

        'replacer = oSheet.getByIndex().createReplaceDescriptor
        'replacer.setSearchString(".*")
        'replacer.setReplaceString("&")
        'Debug.Print(oDoc.replaceAll(replacer))
    End Sub


    Public Sub SRASP(ByVal sSID As String)
        On Error GoTo err_


        Dim LNGIniFile As New IniFile(sLANGPATH)


        Dim tipot, sSQL As String

        tipot = Directory.GetParent(System.Windows.Forms.Application.ExecutablePath).ToString & "\blanks\SRASP.doc"

        Dim rs As Recordset
        sSQL = "SELECT * FROM Remont WHERE id = " & sSID

        rs = New Recordset
        rs.Open(sSQL, DB7, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic)


        Dim sTEXT, sMASTER, sISTOCHNIK, sDATE, sMODEL, sSERNUMBER, sTIP, sTIP2, sOBJECT As String
        Dim sIDCMP As Integer

        With rs
            sTEXT = .Fields("Remont").Value
            sMASTER = .Fields("Master").Value

            sISTOCHNIK = .Fields("istochnik").Value
            sDATE = .Fields("D_T").Value
            sIDCMP = .Fields("Id_Comp").Value

        End With
        rs.Close()
        rs = Nothing

        sSQL = "SELECT * FROM kompy WHERE id = " & sIDCMP
        rs = New Recordset
        rs.Open(sSQL, DB7, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic)

        With rs
            sTIP = .Fields("TipTehn").Value

            Select Case sTIP

                Case "PC"

                    sSERNUMBER = .Fields("Ser_N_SIS").Value
                    sOBJECT = LNGIniFile.GetString("MOD_OPENOFFICE", "MSG66", "Системный блок")
                Case "Printer"

                    sSERNUMBER = .Fields("PRINTER_SN_1").Value
                    sOBJECT = LNGIniFile.GetString("MOD_OPENOFFICE", "MSG27", "Принтер") & " " &
                              .Fields("NET_NAME").Value
                Case "KOpir"

                    sSERNUMBER = .Fields("PRINTER_SN_1").Value
                    sOBJECT = LNGIniFile.GetString("MOD_OPENOFFICE", "MSG60", "Копир") & " " & .Fields("NET_NAME").Value
                Case "MONITOR"
                    sSERNUMBER = .Fields("MONITOR_SN").Value
                    sOBJECT = LNGIniFile.GetString("MOD_OPENOFFICE", "MSG24", "Монитор") & " " &
                              .Fields("NET_NAME").Value
                Case "SCANER"
                    sSERNUMBER = .Fields("PRINTER_SN_1").Value
                    sOBJECT = LNGIniFile.GetString("MOD_OPENOFFICE", "MSG34", "Сканер") & " " &
                              .Fields("NET_NAME").Value
                Case "NET"
                    sSERNUMBER = .Fields("port_1").Value
                    sOBJECT = LNGIniFile.GetString("MOD_OPENOFFICE", "MSG61", "Сетевое оборудование") & " " &
                              .Fields("NET_NAME").Value
                Case "PHOTO"
                    sSERNUMBER = .Fields("PRINTER_SN_1").Value
                    sOBJECT = LNGIniFile.GetString("MOD_OPENOFFICE", "MSG62", "Фотоаппарат") & " " &
                              .Fields("NET_NAME").Value
                Case "OT"
                    sSERNUMBER = .Fields("PRINTER_SN_1").Value
                    sMODEL = .Fields("NET_NAME").Value
                    sTIP2 = .Fields("TIP_COMPA").Value
                    sOBJECT = .Fields("NET_NAME").Value
                    sOBJECT = sOBJECT & " " & sTIP2
                Case "ZIP"
                    sSERNUMBER = .Fields("PRINTER_SN_1").Value
                    sOBJECT = LNGIniFile.GetString("MOD_OPENOFFICE", "MSG65", "Дисковод ZIP") & " " &
                              .Fields("NET_NAME").Value
                Case "PHONE"
                    sSERNUMBER = .Fields("PRINTER_SN_1").Value
                    sOBJECT = LNGIniFile.GetString("MOD_OPENOFFICE", "MSG63", "Телефон") & " " &
                              .Fields("NET_NAME").Value
                Case "MFU"
                    sSERNUMBER = .Fields("PRINTER_SN_1").Value
                    sOBJECT = LNGIniFile.GetString("MOD_OPENOFFICE", "MSG32", "МФУ") & " " & .Fields("NET_NAME").Value
                Case "FAX"
                    sSERNUMBER = .Fields("PRINTER_SN_1").Value
                    sOBJECT = LNGIniFile.GetString("MOD_OPENOFFICE", "MSG64", "Факс") & " " & .Fields("NET_NAME").Value

                Case "USB"

                    sSERNUMBER = .Fields("PRINTER_SN_1").Value
                    sOBJECT = LNGIniFile.GetString("MOD_OPENOFFICE", "MSG37", "USB Устройство") & " " &
                              .Fields("NET_NAME").Value
                Case "IBP"

                    sSERNUMBER = .Fields("PRINTER_SN_1").Value
                    sOBJECT = LNGIniFile.GetString("MOD_OPENOFFICE", "MSG35", "Источник бесперебойного питания") & " " &
                              .Fields("NET_NAME").Value
                Case "FS"
                    sSERNUMBER = .Fields("PRINTER_SN_1").Value
                    sOBJECT = LNGIniFile.GetString("MOD_OPENOFFICE", "MSG26", "Сетевой фильтр") & " " &
                              .Fields("NET_NAME").Value

                Case "SOUND"
                    sSERNUMBER = .Fields("PRINTER_SN_1").Value
                    sOBJECT = LNGIniFile.GetString("MOD_OPENOFFICE", "MSG25", "Акустическая система") & " " &
                              .Fields("NET_NAME").Value


            End Select


        End With
        rs.Close()
        rs = Nothing


        Select Case sOfficePACK

            Case "OpenOffice.org"
                Dim oSM As Object            'Root object for accessing OpenOffice FROM VB
                Dim oDesk, oDoc As Object 'First objects FROM the API
                Dim arg(-1) As Object             'Ignore it for the moment !

                oSM = CreateObject("com.sun.star.ServiceManager")

                'Create the first and most important service
                oDesk = oSM.createInstance("com.sun.star.frame.Desktop")
                oDoc = oDesk.loadComponentFROMURL("file:///" & tipot, "_blank", 0, arg)

                ' jon code
                Dim objText As Object, objCursor As Object
                objText = oDoc.GetText
                objCursor = objText.createTextCursor

                ' replace all
                Dim oSrch As Object

                'Set oSrch = oDoc.createSearchDescriptor
                oSrch = oDoc.createReplaceDescriptor
                oSrch.setSearchString("источник")
                oSrch.setReplaceString(sISTOCHNIK)
                Debug.Print(oDoc.replaceAll(oSrch))

                oSrch.setSearchString("Объект")
                oSrch.setReplaceString(sOBJECT)
                Debug.Print(oDoc.replaceAll(oSrch))

                oSrch.setSearchString("Модель")
                oSrch.setReplaceString(sMODEL & " SN::" & sSERNUMBER)
                Debug.Print(oDoc.replaceAll(oSrch))

                oSrch.setSearchString("Дефект")
                oSrch.setReplaceString(sTEXT)
                Debug.Print(oDoc.replaceAll(oSrch))

                oSrch.setSearchString("Мастер")
                oSrch.setReplaceString(sMASTER)
                Debug.Print(oDoc.replaceAll(oSrch))

                oSrch.setSearchString("Число")
                oSrch.setReplaceString(sDATE)
                Debug.Print(oDoc.replaceAll(oSrch))

            Case Else

                Dim Wrd As Application
                Dim WrdDc As Object
                Wrd = New Application

                WrdDc = Wrd.Documents.Open(tipot, , False)  'Application.
                WrdDc.Application.Visible = True

                Wrd.Selection.Find.ClearFormatting()
                Wrd.Selection.Find.Replacement.ClearFormatting()
                'Номер


                With Wrd.Selection.Find
                    .Text = "источник"
                    .Replacement.Text = sISTOCHNIK
                    .Forward = True
                    .Wrap = WdFindWrap.wdFindContinue
                    .Format = False
                    .MatchCase = True
                    .MatchWholeWord = False
                    .MatchWildcards = False
                    ' .MatchSoundsLike = False
                    .MatchAllWordForms = False
                End With
                Wrd.Selection.Find.Execute(Replace:=WdReplace.wdReplaceAll)

                With Wrd.Selection.Find
                    .Text = "Объект"
                    .Replacement.Text = sOBJECT
                    .Forward = True
                    .Wrap = WdFindWrap.wdFindContinue
                    .Format = False
                    .MatchCase = True
                    .MatchWholeWord = False
                    .MatchWildcards = False
                    ' .MatchSoundsLike = False
                    .MatchAllWordForms = False
                End With
                Wrd.Selection.Find.Execute(Replace:=WdReplace.wdReplaceAll)

                With Wrd.Selection.Find
                    .Text = "Модель"
                    .Replacement.Text = sMODEL & " SN::" & sSERNUMBER
                    .Forward = True
                    .Wrap = WdFindWrap.wdFindContinue
                    .Format = False
                    .MatchCase = True
                    .MatchWholeWord = False
                    .MatchWildcards = False
                    ' .MatchSoundsLike = False
                    .MatchAllWordForms = False
                End With
                Wrd.Selection.Find.Execute(Replace:=WdReplace.wdReplaceAll)

                With Wrd.Selection.Find
                    .Text = "Дефект"
                    .Replacement.Text = sTEXT
                    .Forward = True
                    .Wrap = WdFindWrap.wdFindContinue
                    .Format = False
                    .MatchCase = True
                    .MatchWholeWord = False
                    .MatchWildcards = False
                    ' .MatchSoundsLike = False
                    .MatchAllWordForms = False
                End With
                Wrd.Selection.Find.Execute(Replace:=WdReplace.wdReplaceAll)

                With Wrd.Selection.Find
                    .Text = "Мастер"
                    .Replacement.Text = sMASTER
                    .Forward = True
                    .Wrap = WdFindWrap.wdFindContinue
                    .Format = False
                    .MatchCase = True
                    .MatchWholeWord = False
                    .MatchWildcards = False
                    ' .MatchSoundsLike = False
                    .MatchAllWordForms = False
                End With
                Wrd.Selection.Find.Execute(Replace:=WdReplace.wdReplaceAll)

                With Wrd.Selection.Find
                    .Text = "Число"
                    .Replacement.Text = sDATE
                    .Forward = True
                    .Wrap = WdFindWrap.wdFindContinue
                    .Format = False
                    .MatchCase = True
                    .MatchWholeWord = False
                    .MatchWildcards = False
                    ' .MatchSoundsLike = False
                    .MatchAllWordForms = False
                End With
                Wrd.Selection.Find.Execute(Replace:=WdReplace.wdReplaceAll)
                WrdDc = Nothing
                Wrd = Nothing

        End Select

        Exit Sub
err_:
        MsgBox(Err.Description, MsgBoxStyle.Critical, ProGramName)
    End Sub

    Public Sub SRASP2(ByVal sSID As String, ByVal doc As String)
        On Error GoTo err_
        On Error Resume Next

        Dim LNGIniFile As New IniFile(sLANGPATH)

        If sSID = 0 Then Exit Sub

        Dim rs As Recordset
        Dim tipot, sSQL, uname As String

        tipot = doc


        Dim _
            sTEXT,
            sMASTER,
            sISTOCHNIK,
            sDATE,
            sTIP,
            Sorganization,
            sMEMO,
            stTIME,
            stDATE,
            spTIME,
            spDATE,
            sRAB,
            sSERNUM,
            spCena,
            sTIPteh,
            sBIGBOSS,
            sGAR As String
        Dim sIDCMP As Integer

        sSQL = "SELECT nomer_compa FROM CONFIGURE"
        rs = New Recordset
        rs.Open(sSQL, DB7, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic)

        With rs

            sBIGBOSS = .Fields("nomer_compa").Value

        End With
        rs.Close()
        rs = Nothing


        sSQL = "SELECT * FROM Remont WHERE id = " & sSID
        rs = New Recordset
        rs.Open(sSQL, DB7, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic)
        With rs
            If Not IsDBNull(.Fields("Remont").Value) Then sTEXT = .Fields("Remont").Value
            If Not IsDBNull(.Fields("Master").Value) Then sMASTER = .Fields("Master").Value
            If Not IsDBNull(.Fields("istochnik").Value) Then sISTOCHNIK = .Fields("istochnik").Value
            If Not IsDBNull(.Fields("srok").Value) Then sDATE = .Fields("srok").Value
            If Not IsDBNull(.Fields("Id_Comp").Value) Then sIDCMP = .Fields("Id_Comp").Value
            If Not IsDBNull(.Fields("Uroven").Value) Then sTIP = .Fields("Uroven").Value
            If Not IsDBNull(.Fields("PAMIATKA").Value) Then sMEMO = .Fields("PAMIATKA").Value

            If Not IsDBNull(.Fields("starttime").Value) Then stTIME = .Fields("starttime").Value
            If Not IsDBNull(.Fields("startdate").Value) Then stDATE = .Fields("startdate").Value

            If Not IsDBNull(.Fields("stoptime").Value) Then spTIME = .Fields("stoptime").Value
            If Not IsDBNull(.Fields("stopdate").Value) Then spDATE = .Fields("stopdate").Value
            If Not IsDBNull(.Fields("CUMMA").Value) Then spCena = .Fields("CUMMA").Value
            If Not IsDBNull(.Fields("GARANT").Value) Then sGAR = .Fields("GARANT").Value

        End With
        rs.Close()
        rs = Nothing


        sSQL = "SELECT count(*) as t_n FROM remonty_plus WHERE id_rem = " & sSID
        Dim rCOUNTer As Integer
        rs = New Recordset
        rs.Open(sSQL, DB7, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic)
        With rs
            .MoveFirst()
            Do While Not .EOF

                rCOUNTer = .Fields("t_n").Value

                .MoveNext()
            Loop
        End With
        rs.Close()
        rs = Nothing


        If rCOUNTer > 0 Then

            sSQL = "SELECT otzyv FROM remonty_plus WHERE id_rem = " & sSID
            rs = New Recordset
            rs.Open(sSQL, DB7, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic)
            With rs
                .MoveFirst()
                Do While Not .EOF

                    If Len(sRAB) = 0 Then
                        If Not IsDBNull(.Fields("otzyv").Value) Then sRAB = .Fields("otzyv").Value
                    Else
                        If Not IsDBNull(.Fields("otzyv").Value) Then _
                            sRAB = sRAB & vbNewLine & vbNewLine & .Fields("otzyv").Value
                    End If

                    .MoveNext()
                Loop
            End With
            rs.Close()
            rs = Nothing

        End If


        rs = New Recordset
        rs.Open("select * from kompy where id=" & sIDCMP, DB7, CursorTypeEnum.adOpenDynamic,
                LockTypeEnum.adLockOptimistic)

        Dim sINN, sBR, sDEP, sKab, Snname As String
        With rs

            If Not IsDBNull(.Fields("FILIAL").Value) Then sBR = .Fields("FILIAL").Value
            If Not IsDBNull(.Fields("MESTO").Value) Then sDEP = .Fields("MESTO").Value
            If Not IsDBNull(.Fields("kabn").Value) Then sKab = .Fields("kabn").Value
            If Not IsDBNull(.Fields("NET_NAME").Value) Then Snname = .Fields("NET_NAME").Value
            'If Not IsDBNull(.Fields("TipTehn").Value) Then uname = .Fields("TipTehn").Value
            '

            Select Case .Fields("TipTehn").Value


                Case "PC"
                    sSERNUM = .Fields("Ser_N_SIS").Value
                    If Not IsDBNull(.Fields("INV_NO_SYSTEM").Value) Then sINN = .Fields("INV_NO_SYSTEM").Value

                Case "Printer"
                    sSERNUM = .Fields("PRINTER_SN_1").Value
                    If Not IsDBNull(.Fields("INV_NO_PRINTER").Value) Then sINN = .Fields("INV_NO_PRINTER").Value

                Case "MFU"
                    sSERNUM = .Fields("PRINTER_SN_1").Value
                    If Not IsDBNull(.Fields("INV_NO_PRINTER").Value) Then sINN = .Fields("INV_NO_PRINTER").Value
                Case "OT"
                    sSERNUM = .Fields("PRINTER_SN_1").Value
                    If Not IsDBNull(.Fields("INV_NO_PRINTER").Value) Then sINN = .Fields("INV_NO_PRINTER").Value
                Case "KOpir"
                    sSERNUM = .Fields("PRINTER_SN_1").Value
                    If Not IsDBNull(.Fields("INV_NO_PRINTER").Value) Then sINN = .Fields("INV_NO_PRINTER").Value
                Case "NET"
                    sSERNUM = .Fields("port_1").Value

                    If Not IsDBNull(.Fields("PRINTER_PROIZV_3").Value) Then sINN = .Fields("PRINTER_PROIZV_3").Value

                Case "PHOTO"
                    sSERNUM = .Fields("PRINTER_SN_1").Value
                    If Not IsDBNull(.Fields("INV_NO_PRINTER").Value) Then sINN = .Fields("INV_NO_PRINTER").Value
                Case "PHONE"
                    sSERNUM = .Fields("PRINTER_SN_1").Value
                    If Not IsDBNull(.Fields("INV_NO_PRINTER").Value) Then sINN = .Fields("INV_NO_PRINTER").Value
                Case "FAX"
                    sSERNUM = .Fields("PRINTER_SN_1").Value
                    If Not IsDBNull(.Fields("INV_NO_PRINTER").Value) Then sINN = .Fields("INV_NO_PRINTER").Value
                Case "SCANER"
                    sSERNUM = .Fields("PRINTER_SN_1").Value
                    If Not IsDBNull(.Fields("INV_NO_SCANER").Value) Then sINN = .Fields("INV_NO_SCANER").Value
                Case "ZIP"
                    sSERNUM = .Fields("PRINTER_SN_1").Value
                    If Not IsDBNull(.Fields("INV_NO_PRINTER").Value) Then sINN = .Fields("INV_NO_PRINTER").Value
                Case "MONITOR"
                    sSERNUM = .Fields("MONITOR_SN").Value
                    If Not IsDBNull(.Fields("INV_NO_MONITOR").Value) Then sINN = .Fields("INV_NO_MONITOR").Value
                Case "USB"
                    sSERNUM = .Fields("PRINTER_SN_1").Value
                    If Not IsDBNull(.Fields("INV_NO_PRINTER").Value) Then sINN = .Fields("INV_NO_PRINTER").Value
                Case "SOUND"
                    sSERNUM = .Fields("PRINTER_SN_1").Value
                    If Not IsDBNull(.Fields("INV_NO_PRINTER").Value) Then sINN = .Fields("INV_NO_PRINTER").Value
                Case "IBP"
                    sSERNUM = .Fields("PRINTER_SN_1").Value
                    If Not IsDBNull(.Fields("INV_NO_PRINTER").Value) Then sINN = .Fields("INV_NO_PRINTER").Value
                Case ("FS")
                    sSERNUM = .Fields("PRINTER_SN_1").Value
                    If Not IsDBNull(.Fields("INV_NO_PRINTER").Value) Then sINN = .Fields("INV_NO_PRINTER").Value
            End Select

            Select Case .Fields("TipTehn").Value

                Case "PC"

                    sTIPteh = LNGIniFile.GetString("MOD_OPENOFFICE", "MSG66", "Системный блок")
                Case "Printer"

                    sTIPteh = LNGIniFile.GetString("MOD_OPENOFFICE", "MSG27", "Принтер")
                Case "KOpir"

                    sTIPteh = LNGIniFile.GetString("MOD_OPENOFFICE", "MSG60", "Копир")
                Case "MONITOR"

                    sTIPteh = LNGIniFile.GetString("MOD_OPENOFFICE", "MSG24", "Монитор")
                Case "SCANER"

                    sTIPteh = LNGIniFile.GetString("MOD_OPENOFFICE", "MSG34", "Сканер")
                Case "NET"

                    sTIPteh = LNGIniFile.GetString("MOD_OPENOFFICE", "MSG61", "Сетевое оборудование")
                Case "PHOTO"

                    sTIPteh = LNGIniFile.GetString("MOD_OPENOFFICE", "MSG62", "Фотоаппарат")
                Case "OT"

                    sTIPteh = .Fields("NET_NAME").Value & " " & .Fields("TIP_COMPA").Value
                Case "ZIP"

                    sTIPteh = LNGIniFile.GetString("MOD_OPENOFFICE", "MSG65", "Дисковод ZIP")
                Case "PHONE"

                    sTIPteh = LNGIniFile.GetString("MOD_OPENOFFICE", "MSG63", "Телефон")
                Case "MFU"

                    sTIPteh = LNGIniFile.GetString("MOD_OPENOFFICE", "MSG32", "МФУ")
                Case "FAX"

                    sTIPteh = LNGIniFile.GetString("MOD_OPENOFFICE", "MSG64", "Факс")

                Case "USB"

                    sTIPteh = LNGIniFile.GetString("MOD_OPENOFFICE", "MSG37", "USB Устройство")
                Case "IBP"


                    sTIPteh = LNGIniFile.GetString("MOD_OPENOFFICE", "MSG35", "Источник бесперебойного питания")
                Case "FS"

                    sTIPteh = LNGIniFile.GetString("MOD_OPENOFFICE", "MSG26", "Сетевой фильтр")

                Case "SOUND"

                    sTIPteh = LNGIniFile.GetString("MOD_OPENOFFICE", "MSG25", "Акустическая система")

            End Select


        End With
        rs.Close()
        rs = Nothing

        Dim rs1 As Recordset
        rs1 = New Recordset
        rs1.Open("SELECT org FROM CONFIGURE", DB7, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic)

        With rs1
            If Not IsDBNull(.Fields("org").Value) Then Sorganization = .Fields("org").Value
        End With
        rs1.Close()
        rs1 = Nothing


        Select Case sOfficePACK

            Case "OpenOffice.org"
                Dim oSM As Object            'Root object for accessing OpenOffice FROM VB
                Dim oDesk, oDoc As Object 'First objects FROM the API
                Dim arg(- 1) As Object             'Ignore it for the moment !

                oSM = CreateObject("com.sun.star.ServiceManager")


                'Create the first and most important service
                oDesk = oSM.createInstance("com.sun.star.frame.Desktop")
                'Create a new doc
                oDoc = oDesk.loadComponentFROMURL("file:///" & tipot, "_blank", 0, arg)
                ' jon code
                Dim objText As Object, objCursor As Object
                objText = oDoc.GetText
                objCursor = objText.createTextCursor

                ' replace all
                Dim oSrch As Object

                'Sorganization

                oSrch = oDoc.createReplaceDescriptor
                oSrch.setSearchString("#boss")
                oSrch.setReplaceString(sBIGBOSS)
                Debug.Print(oDoc.replaceAll(oSrch))

                oSrch = oDoc.createReplaceDescriptor
                oSrch.setSearchString("#organization")
                oSrch.setReplaceString(Sorganization)
                Debug.Print(oDoc.replaceAll(oSrch))

                oSrch = oDoc.createReplaceDescriptor
                oSrch.setSearchString("#number")
                oSrch.setReplaceString(sSID)
                Debug.Print(oDoc.replaceAll(oSrch))

                oSrch = oDoc.createReplaceDescriptor
                oSrch.setSearchString("#sernumber")
                oSrch.setReplaceString(sSERNUM)
                Debug.Print(oDoc.replaceAll(oSrch))

                'Set oSrch = oDoc.createSearchDescriptor
                oSrch = oDoc.createReplaceDescriptor
                oSrch.setSearchString("#branche")
                oSrch.setReplaceString(sBR & "/" & sDEP & "/" & sKab)
                Debug.Print(oDoc.replaceAll(oSrch))

                oSrch.setSearchString("#tehn_name")
                oSrch.setReplaceString(sTIPteh & "::" & Snname)
                Debug.Print(oDoc.replaceAll(oSrch))

                oSrch.setSearchString("#invnumber")
                oSrch.setReplaceString(sINN)
                Debug.Print(oDoc.replaceAll(oSrch))

                oSrch.setSearchString("#textzaiavki")
                oSrch.setReplaceString(sTEXT)
                Debug.Print(oDoc.replaceAll(oSrch))

                oSrch.setSearchString("#tip")
                oSrch.setReplaceString(sTIP)
                Debug.Print(oDoc.replaceAll(oSrch))

                oSrch.setSearchString("#istochnik")
                oSrch.setReplaceString(sISTOCHNIK)
                Debug.Print(oDoc.replaceAll(oSrch))

                oSrch.setSearchString("#dateisp")
                oSrch.setReplaceString(sDATE)
                Debug.Print(oDoc.replaceAll(oSrch))

                oSrch.setSearchString("#koment")
                oSrch.setReplaceString(sMEMO)
                Debug.Print(oDoc.replaceAll(oSrch))

                oSrch.setSearchString("#raboty")
                oSrch.setReplaceString(sRAB)
                Debug.Print(oDoc.replaceAll(oSrch))

                oSrch.setSearchString("#stoim_Rab")
                oSrch.setReplaceString(spCena)
                Debug.Print(oDoc.replaceAll(oSrch))

                oSrch.setSearchString("#master")
                oSrch.setReplaceString(sMASTER)
                Debug.Print(oDoc.replaceAll(oSrch))

                oSrch.setSearchString("#starttime")
                oSrch.setReplaceString(stTIME)
                Debug.Print(oDoc.replaceAll(oSrch))

                oSrch.setSearchString("#startdate")
                oSrch.setReplaceString(stDATE)
                Debug.Print(oDoc.replaceAll(oSrch))

                oSrch.setSearchString("#stoptime")
                oSrch.setReplaceString(spTIME)
                Debug.Print(oDoc.replaceAll(oSrch))

                oSrch.setSearchString("#stopdate")
                oSrch.setReplaceString(spDATE)
                Debug.Print(oDoc.replaceAll(oSrch))

                oSrch.setSearchString("#date")
                oSrch.setReplaceString(Date.Today)
                Debug.Print(oDoc.replaceAll(oSrch))

                oSrch.setSearchString("#time")
                oSrch.setReplaceString(DateTime.Now.Hour & ":" & DateTime.Now.Minute)
                Debug.Print(oDoc.replaceAll(oSrch))

                oSrch.setSearchString("#tiptehn")
                oSrch.setReplaceString(sTIPteh)
                Debug.Print(oDoc.replaceAll(oSrch))

                Dim d() As String
                d = Split(sMASTER, " ")

                oSrch.setSearchString("#Fmaster")
                oSrch.setReplaceString(d(0))
                Debug.Print(oDoc.replaceAll(oSrch))

                oSrch.setSearchString("#Imaster")
                oSrch.setReplaceString(d(1))
                Debug.Print(oDoc.replaceAll(oSrch))

                oSrch.setSearchString("#Omaster")
                oSrch.setReplaceString(d(2))
                Debug.Print(oDoc.replaceAll(oSrch))

                oSrch.setSearchString("#garant_Rem")
                oSrch.setReplaceString(sGAR)
                Debug.Print(oDoc.replaceAll(oSrch))

                '#garant_Rem
                '#date #time
                '#organization

            Case Else

                Dim Wrd As Application
                Dim WrdDc As Object
                Wrd = New Application

                WrdDc = Wrd.Documents.Open(tipot, , False)  'Application.
                WrdDc.Application.Visible = True

                Wrd.Selection.Find.ClearFormatting()
                Wrd.Selection.Find.Replacement.ClearFormatting()
                'Номер

                With Wrd.Selection.Find
                    .Text = "#boss"
                    .Replacement.Text = sBIGBOSS
                    .Forward = True
                    .Wrap = WdFindWrap.wdFindContinue
                    .Format = False
                    .MatchCase = True
                    .MatchWholeWord = False
                    .MatchWildcards = False
                    ' .MatchSoundsLike = False
                    .MatchAllWordForms = False
                End With
                Wrd.Selection.Find.Execute(Replace := WdReplace.wdReplaceAll)

                Dim d() As String
                d = Split(sMASTER, " ")

                With Wrd.Selection.Find
                    .Text = "#Fmaster"
                    .Replacement.Text = d(0)
                    .Forward = True
                    .Wrap = WdFindWrap.wdFindContinue
                    .Format = False
                    .MatchCase = True
                    .MatchWholeWord = False
                    .MatchWildcards = False
                    ' .MatchSoundsLike = False
                    .MatchAllWordForms = False
                End With
                Wrd.Selection.Find.Execute(Replace := WdReplace.wdReplaceAll)

                With Wrd.Selection.Find
                    .Text = "#Imaster"
                    .Replacement.Text = d(1)
                    .Forward = True
                    .Wrap = WdFindWrap.wdFindContinue
                    .Format = False
                    .MatchCase = True
                    .MatchWholeWord = False
                    .MatchWildcards = False
                    ' .MatchSoundsLike = False
                    .MatchAllWordForms = False
                End With
                Wrd.Selection.Find.Execute(Replace := WdReplace.wdReplaceAll)


                With Wrd.Selection.Find
                    .Text = "#Omaster"
                    .Replacement.Text = d(2)
                    .Forward = True
                    .Wrap = WdFindWrap.wdFindContinue
                    .Format = False
                    .MatchCase = True
                    .MatchWholeWord = False
                    .MatchWildcards = False
                    ' .MatchSoundsLike = False
                    .MatchAllWordForms = False
                End With
                Wrd.Selection.Find.Execute(Replace := WdReplace.wdReplaceAll)


                With Wrd.Selection.Find
                    .Text = "#tiptehn"
                    .Replacement.Text = sTIPteh
                    .Forward = True
                    .Wrap = WdFindWrap.wdFindContinue
                    .Format = False
                    .MatchCase = True
                    .MatchWholeWord = False
                    .MatchWildcards = False
                    ' .MatchSoundsLike = False
                    .MatchAllWordForms = False
                End With
                Wrd.Selection.Find.Execute(Replace := WdReplace.wdReplaceAll)


                '#number
                With Wrd.Selection.Find
                    .Text = "#number"
                    .Replacement.Text = sSID
                    .Forward = True
                    .Wrap = WdFindWrap.wdFindContinue
                    .Format = False
                    .MatchCase = True
                    .MatchWholeWord = False
                    .MatchWildcards = False
                    ' .MatchSoundsLike = False
                    .MatchAllWordForms = False
                End With
                Wrd.Selection.Find.Execute(Replace := WdReplace.wdReplaceAll)


                With Wrd.Selection.Find
                    .Text = "#organization"
                    .Replacement.Text = Sorganization
                    .Forward = True
                    .Wrap = WdFindWrap.wdFindContinue
                    .Format = False
                    .MatchCase = True
                    .MatchWholeWord = False
                    .MatchWildcards = False
                    ' .MatchSoundsLike = False
                    .MatchAllWordForms = False
                End With
                Wrd.Selection.Find.Execute(Replace := WdReplace.wdReplaceAll)

                With Wrd.Selection.Find
                    .Text = "#branche"
                    .Replacement.Text = sBR & "/" & sDEP & "/" & sKab
                    .Forward = True
                    .Wrap = WdFindWrap.wdFindContinue
                    .Format = False
                    .MatchCase = True
                    .MatchWholeWord = False
                    .MatchWildcards = False
                    ' .MatchSoundsLike = False
                    .MatchAllWordForms = False
                End With
                Wrd.Selection.Find.Execute(Replace := WdReplace.wdReplaceAll)

                With Wrd.Selection.Find
                    .Text = "#tehn_name"
                    .Replacement.Text = sTIPteh & "::" & Snname
                    .Forward = True
                    .Wrap = WdFindWrap.wdFindContinue
                    .Format = False
                    .MatchCase = True
                    .MatchWholeWord = False
                    .MatchWildcards = False
                    ' .MatchSoundsLike = False
                    .MatchAllWordForms = False
                End With
                Wrd.Selection.Find.Execute(Replace := WdReplace.wdReplaceAll)

                With Wrd.Selection.Find
                    .Text = "#invnumber"
                    .Replacement.Text = sINN
                    .Forward = True
                    .Wrap = WdFindWrap.wdFindContinue
                    .Format = False
                    .MatchCase = True
                    .MatchWholeWord = False
                    .MatchWildcards = False
                    ' .MatchSoundsLike = False
                    .MatchAllWordForms = False
                End With
                Wrd.Selection.Find.Execute(Replace := WdReplace.wdReplaceAll)


                With Wrd.Selection.Find
                    .Text = "#sernumber"
                    .Replacement.Text = sSERNUM
                    .Forward = True
                    .Wrap = WdFindWrap.wdFindContinue
                    .Format = False
                    .MatchCase = True
                    .MatchWholeWord = False
                    .MatchWildcards = False
                    ' .MatchSoundsLike = False
                    .MatchAllWordForms = False
                End With
                Wrd.Selection.Find.Execute(Replace := WdReplace.wdReplaceAll)


                With Wrd.Selection.Find
                    .Text = "#textzaiavki"
                    .Replacement.Text = sTEXT
                    .Forward = True
                    .Wrap = WdFindWrap.wdFindContinue
                    .Format = False
                    .MatchCase = True
                    .MatchWholeWord = False
                    .MatchWildcards = False
                    ' .MatchSoundsLike = False
                    .MatchAllWordForms = False
                End With
                Wrd.Selection.Find.Execute(Replace := WdReplace.wdReplaceAll)

                With Wrd.Selection.Find
                    .Text = "#tip"
                    .Replacement.Text = sTIP
                    .Forward = True
                    .Wrap = WdFindWrap.wdFindContinue
                    .Format = False
                    .MatchCase = True
                    .MatchWholeWord = False
                    .MatchWildcards = False
                    ' .MatchSoundsLike = False
                    .MatchAllWordForms = False
                End With
                Wrd.Selection.Find.Execute(Replace := WdReplace.wdReplaceAll)

                With Wrd.Selection.Find
                    .Text = "#istochnik"
                    .Replacement.Text = sISTOCHNIK
                    .Forward = True
                    .Wrap = WdFindWrap.wdFindContinue
                    .Format = False
                    .MatchCase = True
                    .MatchWholeWord = False
                    .MatchWildcards = False
                    ' .MatchSoundsLike = False
                    .MatchAllWordForms = False
                End With
                Wrd.Selection.Find.Execute(Replace := WdReplace.wdReplaceAll)

                With Wrd.Selection.Find
                    .Text = "#dateisp"
                    .Replacement.Text = sDATE
                    .Forward = True
                    .Wrap = WdFindWrap.wdFindContinue
                    .Format = False
                    .MatchCase = True
                    .MatchWholeWord = False
                    .MatchWildcards = False
                    ' .MatchSoundsLike = False
                    .MatchAllWordForms = False
                End With
                Wrd.Selection.Find.Execute(Replace := WdReplace.wdReplaceAll)


                With Wrd.Selection.Find
                    .Text = "#koment"
                    .Replacement.Text = sMEMO
                    .Forward = True
                    .Wrap = WdFindWrap.wdFindContinue
                    .Format = False
                    .MatchCase = True
                    .MatchWholeWord = False
                    .MatchWildcards = False
                    ' .MatchSoundsLike = False
                    .MatchAllWordForms = False
                End With
                Wrd.Selection.Find.Execute(Replace := WdReplace.wdReplaceAll)

                With Wrd.Selection.Find
                    .Text = "#raboty"
                    .Replacement.Text = sRAB
                    .Forward = True
                    .Wrap = WdFindWrap.wdFindContinue
                    .Format = False
                    .MatchCase = True
                    .MatchWholeWord = False
                    .MatchWildcards = False
                    ' .MatchSoundsLike = False
                    .MatchAllWordForms = False
                End With
                Wrd.Selection.Find.Execute(Replace := WdReplace.wdReplaceAll)

                With Wrd.Selection.Find
                    .Text = "#stoim_Rab"
                    .Replacement.Text = spCena
                    .Forward = True
                    .Wrap = WdFindWrap.wdFindContinue
                    .Format = False
                    .MatchCase = True
                    .MatchWholeWord = False
                    .MatchWildcards = False
                    ' .MatchSoundsLike = False
                    .MatchAllWordForms = False
                End With
                Wrd.Selection.Find.Execute(Replace := WdReplace.wdReplaceAll)

                With Wrd.Selection.Find
                    .Text = "#master"
                    .Replacement.Text = sMASTER
                    .Forward = True
                    .Wrap = WdFindWrap.wdFindContinue
                    .Format = False
                    .MatchCase = True
                    .MatchWholeWord = False
                    .MatchWildcards = False
                    ' .MatchSoundsLike = False
                    .MatchAllWordForms = False
                End With
                Wrd.Selection.Find.Execute(Replace := WdReplace.wdReplaceAll)

                With Wrd.Selection.Find
                    .Text = "#starttime"
                    .Replacement.Text = stTIME
                    .Forward = True
                    .Wrap = WdFindWrap.wdFindContinue
                    .Format = False
                    .MatchCase = True
                    .MatchWholeWord = False
                    .MatchWildcards = False
                    ' .MatchSoundsLike = False
                    .MatchAllWordForms = False
                End With
                Wrd.Selection.Find.Execute(Replace := WdReplace.wdReplaceAll)

                With Wrd.Selection.Find
                    .Text = "#stopdate"
                    .Replacement.Text = spDATE
                    .Forward = True
                    .Wrap = WdFindWrap.wdFindContinue
                    .Format = False
                    .MatchCase = True
                    .MatchWholeWord = False
                    .MatchWildcards = False
                    ' .MatchSoundsLike = False
                    .MatchAllWordForms = False
                End With
                Wrd.Selection.Find.Execute(Replace := WdReplace.wdReplaceAll)

                With Wrd.Selection.Find
                    .Text = "#stoptime"
                    .Replacement.Text = spTIME
                    .Forward = True
                    .Wrap = WdFindWrap.wdFindContinue
                    .Format = False
                    .MatchCase = True
                    .MatchWholeWord = False
                    .MatchWildcards = False
                    ' .MatchSoundsLike = False
                    .MatchAllWordForms = False
                End With
                Wrd.Selection.Find.Execute(Replace := WdReplace.wdReplaceAll)

                With Wrd.Selection.Find
                    .Text = "#startdate"
                    .Replacement.Text = stDATE
                    .Forward = True
                    .Wrap = WdFindWrap.wdFindContinue
                    .Format = False
                    .MatchCase = True
                    .MatchWholeWord = False
                    .MatchWildcards = False
                    ' .MatchSoundsLike = False
                    .MatchAllWordForms = False
                End With
                Wrd.Selection.Find.Execute(Replace := WdReplace.wdReplaceAll)

                With Wrd.Selection.Find
                    .Text = "#date"
                    .Replacement.Text = Date.Today
                    .Forward = True
                    .Wrap = WdFindWrap.wdFindContinue
                    .Format = False
                    .MatchCase = True
                    .MatchWholeWord = False
                    .MatchWildcards = False
                    ' .MatchSoundsLike = False
                    .MatchAllWordForms = False
                End With
                Wrd.Selection.Find.Execute(Replace := WdReplace.wdReplaceAll)

                With Wrd.Selection.Find
                    .Text = "#time"
                    .Replacement.Text = DateTime.Now.Hour & ":" & DateTime.Now.Minute
                    .Forward = True
                    .Wrap = WdFindWrap.wdFindContinue
                    .Format = False
                    .MatchCase = True
                    .MatchWholeWord = False
                    .MatchWildcards = False
                    ' .MatchSoundsLike = False
                    .MatchAllWordForms = False
                End With
                Wrd.Selection.Find.Execute(Replace := WdReplace.wdReplaceAll)

                With Wrd.Selection.Find
                    .Text = "#garant_Rem"
                    .Replacement.Text = sGAR
                    .Forward = True
                    .Wrap = WdFindWrap.wdFindContinue
                    .Format = False
                    .MatchCase = True
                    .MatchWholeWord = False
                    .MatchWildcards = False
                    ' .MatchSoundsLike = False
                    .MatchAllWordForms = False
                End With
                Wrd.Selection.Find.Execute(Replace := WdReplace.wdReplaceAll)


                ' '#garant_Rem

                WrdDc = Nothing
                Wrd = Nothing

        End Select

        Exit Sub
        err_:
        MsgBox(Err.Description, MsgBoxStyle.Critical, ProGramName)
    End Sub

    Public Sub ExportListViewToExcel(ByVal MyListView As ListView, ByVal sTXT As String)

        'Dim ExcelReport As Excel.ApplicationClass

        ' Const MAX_COLOURS As Int16 = 40

        Const MAX_COLUMS As Int16 = 254

        Dim i As Integer

        Dim New_Item As ListViewItem

        Dim TempColum As Int16

        Dim ColumLetter As String

        Dim TempRow As Int16

        Dim TempColum2 As Int16

        Dim AddedColours As Int16 = 1

        Dim MyColours As Hashtable = New Hashtable

        Dim AddNewBackColour As Boolean = True

        Dim AddNewFrontColour As Boolean = True

        'Dim BackColour As String

        'Dim FrontColour As String


        '##########################

        Dim chartRange As Excel.Range

        '##########################


        Dim ExcelReport As Excel.Application

        'ExcelReport = New Excel.ApplicationClass

        ExcelReport = New Excel.Application

        ExcelReport.Visible = True

        ExcelReport.Workbooks.Add()


        'ExcelReport.Worksheets("Sheet1").Select()

        'ExcelReport.Sheets("Sheet1").Name = sTXT


        i = 0

        Do Until i = MyListView.Columns.Count

            If i > MAX_COLUMS Then

                MsgBox("Too many Colums added")

                Exit Do

            End If

            TempColum = i

            TempColum2 = 0

            Do While TempColum > 25

                TempColum -= 26

                TempColum2 += 1

            Loop

            ColumLetter = Chr(97 + TempColum)

            If TempColum2 > 0 Then ColumLetter = Chr(96 + TempColum2) & ColumLetter

            ExcelReport.Range(ColumLetter & 3).Value = MyListView.Columns(i).Text

            'ExcelReport.Range(ColumLetter & 3).Font.Name = MyListView.Font.Name

            ' ExcelReport.Range(ColumLetter & 3).Font.Size = MyListView.Font.Size + 2

            ExcelReport.Range(ColumLetter & 3).Font.Bold = True

            chartRange = ExcelReport.Range(ColumLetter & 3)

            chartRange.BorderAround(XlLineStyle.xlContinuous, XlBorderWeight.xlMedium,
                                    XlColorIndex.xlColorIndexAutomatic, XlColorIndex.xlColorIndexAutomatic)

            i += 1

        Loop

        '###############################################

        'Вставляем заголовок

        '###############################################

        'Устанавливаем диапазон ячеек

        chartRange = ExcelReport.Range("A1", ColumLetter & 2)

        'Объединяем ячейки

        chartRange.Merge()

        'Вставляем текст

        chartRange.FormulaR1C1 = sTXT

        'Выравниваем по центру

        chartRange.HorizontalAlignment = 3

        chartRange.VerticalAlignment = 2

        'Устанавливаем шрифт

        ExcelReport.Range("A1").Font.Name = MyListView.Font.Name

        'Увеличиваем шрифт

        ExcelReport.Range("A1").Font.Size = MyListView.Font.Size + 4

        'Делаем шрифт жирным

        ExcelReport.Range("A1").Font.Bold = True

        '###############################################

        '###############################################


        TempRow = 4

        For Each New_Item In MyListView.Items

            i = 0

            Do Until i = New_Item.SubItems.Count

                If i > MAX_COLUMS Then

                    MsgBox("Too many Colums added")

                    Exit Do

                End If

                TempColum = i

                TempColum2 = 0

                Do While TempColum > 25

                    TempColum -= 26

                    TempColum2 += 1

                Loop

                ColumLetter = Chr(97 + TempColum)

                If TempColum2 > 0 Then ColumLetter = Chr(96 + TempColum2) & ColumLetter

                ExcelReport.Range(ColumLetter & TempRow).Value = New_Item.SubItems(i).Text

                'ExcelReport.Range(ColumLetter & TempRow).Font.Name = New_Item.Font.Name

                'ExcelReport.Range(ColumLetter & TempRow).Font.Size = New_Item.Font.Size

                chartRange = ExcelReport.Range(ColumLetter & TempRow)

                chartRange.BorderAround(XlLineStyle.xlContinuous, XlBorderWeight.xlMedium,
                                        XlColorIndex.xlColorIndexAutomatic, XlColorIndex.xlColorIndexAutomatic)

                'AddNewFrontColour = False

                'AddNewBackColour = False

                'Try

                '    BackColour = MyColours(New_Item.BackColor.ToString)

                '    If BackColour = "" Then AddNewBackColour = True

                '    FrontColour = MyColours(New_Item.ForeColor.ToString)

                '    If FrontColour = "" Then AddNewFrontColour = True

                'Catch ex As Exception

                '    AddNewFrontColour = False

                '    AddNewBackColour = False

                'End Try

                'If AddedColours < MAX_COLOURS And (AddNewFrontColour Or AddNewBackColour) And (New_Item.BackColor.ToArgb <> -1) Then

                '    If AddNewBackColour Then

                '        MyColours.Add(New_Item.BackColor.ToString, AddedColours)

                '        ExcelReport.Workbooks.Item(1).Colors(AddedColours) = RGB(New_Item.BackColor.R, New_Item.BackColor.G, New_Item.BackColor.B)

                '        AddedColours += 1

                '    End If

                '    If AddNewFrontColour Then

                '        MyColours.Add(New_Item.ForeColor.ToString, AddedColours)

                '        ExcelReport.Workbooks.Item(1).Colors(AddedColours) = RGB(New_Item.ForeColor.R, New_Item.ForeColor.G, New_Item.ForeColor.B)

                '        AddedColours += 1

                '    End If

                'End If

                'ExcelReport.Rows(TempRow & ":" & TempRow).select()

                'ExcelReport.Selection.Interior.ColorIndex = MyColours(New_Item.BackColor.ToString)

                'ExcelReport.Selection.Font.ColorIndex = MyColours(New_Item.ForeColor.ToString)

                i += 1

            Loop

            TempRow += 1

        Next


        ExcelReport.Cells.Select()

        ExcelReport.Cells.EntireColumn.AutoFit()

        ExcelReport.Cells.Range("A1").Select()

    End Sub

End Module
