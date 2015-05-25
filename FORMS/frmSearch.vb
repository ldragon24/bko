Imports System.ComponentModel

Public Class frmSearch
    Public SfilS As String
    Private a, b As Integer
    Private _backgroundWorker1 As BackgroundWorker

    Private Sub status(ByVal strText As String)

        On Error GoTo Error_
        Dim LNGIniFile As New IniFile(sLANGPATH)

        Label2.Text = LNGIniFile.GetString("frmSearch", "MSG1", "Результатов найдено:") & " " & strText

        Exit Sub
        Error_:
    End Sub

    Public Sub Search(ByVal sGroupName As String, ByVal sFindText As String, Optional ByVal MtchWord As Byte = 0,
                      Optional ByVal MtchCase As Byte = 0)
        Dim sSQL As String
        Dim FirstColumn As Boolean
        Dim intCount As Decimal = 0

        'On Error Resume Next


        Dim LNGIniFile As New IniFile(sLANGPATH)
        'MSG13
        lstSearch.Items.Clear()

        Dim rs As Recordset 'Объявляем рекордсет
        rs = New Recordset

        sSQL = "SELECT count(*) as t_n FROM kompy where CPU1 like '%" & sFindText &
               "%' or CPUmhz1 like '%" & sFindText & "%' or CPU2 like '%" & sFindText & "%' or CPUmhz2 like '%" &
               sFindText & "%' or CPU3 like '%" & sFindText & "%' or CPUmhz3 like '%" & sFindText & "%' or CPU4 like '%" &
               sFindText & "%' or CPUmhz4 like '%" & sFindText & "%' or Mb_Name like '%" & sFindText &
               "%' or Mb_Chip like '%" & sFindText & "%' or Mb_Proizvod like '%" & sFindText & "%' or RAM_1 like '%" &
               sFindText & "%' or RAM_2 like '%" & sFindText & "%' or RAM_3 like '%" & sFindText & "%' or RAM_4 like '%" &
               sFindText & "%' or HDD_Name_1 like '%" & sFindText & "%' or HDD_OB_1 like '%" & sFindText &
               "%' or HDD_SN_1 like '%" & sFindText & "%' or HDD_Name_2 like '%" & sFindText & "%' or HDD_OB_2 like '%" &
               sFindText & "%' or HDD_SN_2 like '%" & sFindText & "%' or HDD_Name_3 like '%" & sFindText &
               "%' or HDD_OB_3 like '%" & sFindText & "%' or HDD_SN_3 like '%" & sFindText & "%' or HDD_Name_4 like '%" &
               sFindText & "%' or HDD_OB_4 like '%" & sFindText & "%' or HDD_SN_4 like '%" & sFindText &
               "%' or SVGA_NAME like '%" & sFindText & "%' or SVGA_SN like '%" & sFindText & "%' or SOUND_NAME like '%" &
               sFindText & "%' or CD_NAME like '%" & sFindText & "%' or CD_SPEED like '%" & sFindText &
               "%' or CD_SN like '%" & sFindText & "%' or CDRW_NAME like '%" & sFindText & "%' or CDRW_SPEED like '%" &
               sFindText & "%' or CDRW_SN like '%" & sFindText & "%' or DVD_NAME like '%" & sFindText &
               "%' or DVD_SPEED like '%" & sFindText & "%' or DVD_SN like '%" & sFindText & "%' or NET_NAME_1 like '%" &
               sFindText & "%' or NET_IP_1 like '%" & sFindText & "%' or NET_MAC_1 like '%" & sFindText &
               "%' or NET_NAME_2 like '%" & sFindText & "%' or NET_IP_2 like '%" & sFindText & "%' or NET_MAC_2 like '%" &
               sFindText & "%' or MODEM_NAME like '%" & sFindText & "%' or MODEM_SN like '%" & sFindText &
               "%' or MONITOR_NAME like '%" & sFindText & "%' or MONITOR_NAME2 like '%" & sFindText &
               "%' or MONITOR_SN like '%" & sFindText & "%' or MONITOR_SN2 like '%" & sFindText & "%'or AS_NAME like '%" &
               sFindText & "%' or AS_PROIZV like '%" & sFindText & "%' or IBP_NAME like '%" & sFindText &
               "%' or FILTR_NAME like '%" & sFindText & "%' or PRINTER_NAME_1 like '%" & sFindText &
               "%' or PRINTER_SN_1 like '%" & sFindText & "%' or PORT_1 like '%" & sFindText &
               "%' or PRINTER_PROIZV_1 like '%" & sFindText & "%' or PRINTER_NAME_2 like '%" & sFindText &
               "%' or PORT_2 like '%" & sFindText & "%' or PRINTER_SN_2 like '%" & sFindText &
               "%' or PRINTER_PROIZV_2 like '%" & sFindText & "%' or PRINTER_NAME_3 like '%" & sFindText &
               "%' or PORT_3 like '%" & sFindText & "%' or PRINTER_SN_3 like '%" & sFindText &
               "%' or PRINTER_PROIZV_3 like '%" & sFindText & "%' or PORT_4 like '%" & sFindText &
               "%' or PRINTER_NAME_4 like '%" & sFindText & "%' or PRINTER_SN_4 like '%" & sFindText &
               "%' or PRINTER_PROIZV_4 like '%" & sFindText & "%' or SCANER_NAME like '%" & sFindText &
               "%' or NET_NAME like '%" & sFindText & "%' or PSEVDONIM like '%" & sFindText & "%' or MESTO like '%" &
               sFindText & "%' or kabn like '%" & sFindText & "%' or FILIAL like '%" & sFindText &
               "%' or TELEPHONE like '%" & sFindText & "%' or INV_NO_SYSTEM like '%" & sFindText &
               "%' or INV_NO_PRINTER like '%" & sFindText & "%' or INV_NO_MODEM like '%" & sFindText &
               "%' or INV_NO_SCANER like '%" & sFindText & "%' or INV_NO_MONITOR like '%" & sFindText &
               "%' or INV_NO_IBP like '%" & sFindText & "%' or OTvetstvennyj like '%" & sFindText &
               "%' or Ser_N_SIS like '%" & sFindText & "%' or BLOCK like '%" & sFindText & "%' or SN_BLOCK like '%" &
               sFindText & "%' or CREADER_NAME like '%" & sFindText & "%' or CASE_NAME like '%" & sFindText &
               "%' or CASE_SN like '%" & sFindText & "%' or CASE_PROIZV like '%" & sFindText & "%' or SYS_PR like '%" &
               sFindText & "%'"

        rs.Open(sSQL, DB7, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic)

        Dim sCOUNT As String
        With rs
            sCOUNT = .Fields("t_n").Value
        End With
        rs.Close()
        rs = Nothing


        If sCOUNT = 0 Then

            Label3.Text = "Поиск не удачен, полей найдено " & sCOUNT
            Exit Sub
        End If


        rs = New Recordset
        'sSQL = "SELECT * FROM kompy where ID like '%" & sFindText & "%'  or CPU1 like '%" & sFindText & "%'  or CPUmhz1 like '%" & sFindText & "%'  or CPU2 like '%" & sFindText & "%'  or CPUmhz2 like '%" & sFindText & "%'  or CPU3 like '%" & sFindText & "%'  or CPUmhz3 like '%" & sFindText & "%'  or CPU4 like '%" & sFindText & "%'  or CPUmhz4 like '%" & sFindText & "%'  or Mb like '%" & sFindText & "%'  or Mb_Chip like '%" & sFindText & "%'  or Mb_Proizvod like '%" & sFindText & "%'  or RAM_1 like '%" & sFindText & "%'  or RAM_2 like '%" & sFindText & "%'  or RAM_3 like '%" & sFindText & "%'  or RAM_4 like '%" & sFindText & "%'  or HDD_Name_1 like '%" & sFindText & "%'  or HDD_OB_1 like '%" & sFindText & "%'  or HDD_SN_1 like '%" & sFindText & "%'  or HDD_Name_2 like '%" & sFindText & "%'  or HDD_OB_2 like '%" & sFindText & "%'  or HDD_SN_2 like '%" & sFindText & "%'  or HDD_Name_3 like '%" & sFindText & "%'  or HDD_OB_3 like '%" & sFindText & "%'  or HDD_SN_3 like '%" & sFindText & "%'  or HDD_Name_4 like '%" & sFindText & "%'  or HDD_OB_4 like '%" & sFindText & "%'  or HDD_SN_4 like '%" & sFindText & "%'  or SVGA_NAME like '%" & sFindText & "%'  or SVGA_SN like '%" & sFindText & "%'  or SOUND_NAME like '%" & sFindText & "%'  or CD_NAME like '%" & sFindText & "%'  or CD_SPEED like '%" & sFindText & "%'  or CD_SN like '%" & sFindText & "%'  or CDRW_NAME like '%" & sFindText & "%'  or CDRW_SPEED like '%" & sFindText & "%'  or CDRW_SN like '%" & sFindText & "%'  or DVD_NAME like '%" & sFindText & "%'  or DVD_SPEED like '%" & sFindText & "%'  or DVD_SN like '%" & sFindText & "%'  or NET_NAME_1 like '%" & sFindText & "%'  or NET_IP_1 like '%" & sFindText & "%'  or NET_NAME_2 like '%" & sFindText & "%'  or NET_IP_2 like '%" & sFindText & "%'  or NET_MAC_2 like '%" & sFindText & "%'  or MODEM_NAME like '%" & sFindText & "%'  or MODEM_SN like '%" & sFindText & "%'  or MONITor_NAME like '%" & sFindText & "%'  or MONITor_NAME2 like '%" & sFindText & "%'  or AS_NAME like '%" & sFindText & "%'  or AS_PROIZV like '%" & sFindText & "%'  or IBP_NAME like '%" & sFindText & "%'  or FILTR_NAME like '%" & sFindText & "%'  or PRINTER_NAME_1 like '%" & sFindText & "%'  or PRINTER_NAME_2 like '%" & sFindText & "%'  or PRINTER_NAME_3 like '%" & sFindText & "%'  or SCANER_NAME like '%" & sFindText & "%'  or NET_NAME like '%" & sFindText & "%'  or PSEVDONIM like '%" & sFindText & "%'  or MESTO like '%" & sFindText & "%'  or kabn like '%" & sFindText & "%'  or FILIAL like '%" & sFindText & "%'  or TELEPHONE like '%" & sFindText & "%'  or INV_NO_SYSTEM like '%" & sFindText & "%'  or INV_NO_PRINTER like '%" & sFindText & "%'  or INV_NO_MODEM like '%" & sFindText & "%'  or INV_NO_SCANER like '%" & sFindText & "%'  or INV_NO_MONITOR like '%" & sFindText & "%'  or INV_NO_IBP like '%" & sFindText & "%'  or OTvetstvennyj like '%" & sFindText & "%'  or Ser_N_SIS like '%" & sFindText & "%'  or BLOCK like '%" & sFindText & "%'  or SN_BLOCK like '%" & sFindText & "%'  or CREADER_NAME like '%" & sFindText & "%'  or CASE_NAME like '%" & sFindText & "%'  or CASE_SN like '%" & sFindText & "%'  or CASE_PROIZV like '%" & sFindText & "%'  or SYS_PR like '%" & sFindText & "%'"
        'sSQL = "SELECT * FROM kompy where ID like '%" & sFindText & "%'  or CPU1 like '%" & sFindText & "%'  or CPUmhz1 like '%" & sFindText & "%'  or CPU2 like '%" & sFindText & "%'  or CPUmhz2 like '%" & sFindText & "%'  or CPU3 like '%" & sFindText & "%'  or CPUmhz3 like '%" & sFindText & "%'  or CPU4 like '%" & sFindText & "%'  or CPUmhz4 like '%" & sFindText & "%'  or Mb like '%" & sFindText & "%'  or Mb_Chip like '%" & sFindText & "%'  or Mb_Proizvod like '%" & sFindText & "%'  or RAM_1 like '%" & sFindText & "%'  or RAM_2 like '%" & sFindText & "%'  or RAM_3 like '%" & sFindText & "%'  or RAM_4 like '%" & sFindText & "%'  or HDD_Name_1 like '%" & sFindText & "%'  or HDD_OB_1 like '%" & sFindText & "%'  or HDD_SN_1 like '%" & sFindText & "%'  or HDD_Name_2 like '%" & sFindText & "%'  or HDD_OB_2 like '%" & sFindText & "%'  or HDD_SN_2 like '%" & sFindText & "%'  or HDD_Name_3 like '%" & sFindText & "%'  or HDD_OB_3 like '%" & sFindText & "%'  or HDD_SN_3 like '%" & sFindText & "%'  or HDD_Name_4 like '%" & sFindText & "%'  or HDD_OB_4 like '%" & sFindText & "%'  or HDD_SN_4 like '%" & sFindText & "%'  or SVGA_NAME like '%" & sFindText & "%'  or SVGA_SN like '%" & sFindText & "%'  or SOUND_NAME like '%" & sFindText & "%'  or CD_NAME like '%" & sFindText & "%'  or CD_SPEED like '%" & sFindText & "%'  or CD_SN like '%" & sFindText & "%'  or CDRW_NAME like '%" & sFindText & "%'  or CDRW_SPEED like '%" & sFindText & "%'  or CDRW_SN like '%" & sFindText & "%'  or DVD_NAME like '%" & sFindText & "%'  or DVD_SPEED like '%" & sFindText & "%'  or DVD_SN like '%" & sFindText & "%'  or NET_NAME_1 like '%" & sFindText & "%'  or NET_IP_1 like '%" & sFindText & "%'  or NET_NAME_2 like '%" & sFindText & "%'  or NET_IP_2 like '%" & sFindText & "%'  or NET_MAC_2 like '%" & sFindText & "%'  or MODEM_NAME like '%" & sFindText & "%'  or MODEM_SN like '%" & sFindText & "%'  or MONITor_NAME like '%" & sFindText & "%'  or MONITor_NAME2 like '%" & sFindText & "%'  or AS_NAME like '%" & sFindText & "%'  or AS_PROIZV like '%" & sFindText & "%'  or IBP_NAME like '%" & sFindText & "%'  or FILTR_NAME like '%" & sFindText & "%'  or PRINTER_NAME_1 like '%" & sFindText & "%'  or PRINTER_NAME_2 like '%" & sFindText & "%'  or PRINTER_NAME_3 like '%" & sFindText & "%'  or SCANER_NAME like '%" & sFindText & "%'  or NET_NAME like '%" & sFindText & "%'  or PSEVDONIM like '%" & sFindText & "%'  or MESTO like '%" & sFindText & "%'  or kabn like '%" & sFindText & "%'  or FILIAL like '%" & sFindText & "%'  or TELEPHONE like '%" & sFindText & "%'  or INV_NO_SYSTEM like '%" & sFindText & "%'  or INV_NO_PRINTER like '%" & sFindText & "%'  or INV_NO_MODEM like '%" & sFindText & "%'  or INV_NO_SCANER like '%" & sFindText & "%'  or INV_NO_MONITOR like '%" & sFindText & "%'  or INV_NO_IBP like '%" & sFindText & "%'  or OTvetstvennyj like '%" & sFindText & "%'  or Ser_N_SIS like '%" & sFindText & "%'  or BLOCK like '%" & sFindText & "%'  or SN_BLOCK like '%" & sFindText & "%'  or CREADER_NAME like '%" & sFindText & "%'  or CASE_NAME like '%" & sFindText & "%'  or CASE_SN like '%" & sFindText & "%'  or CASE_PROIZV like '%" & sFindText & "%'  or SYS_PR like '%" & sFindText & "%' order by PSEVDONIM, filial"

        sSQL = "SELECT * FROM kompy where  CPU1 like '%" & sFindText & "%' or CPUmhz1 like '%" & sFindText & "%' or CPU2 like '%" & sFindText & "%' or CPUmhz2 like '%" & sFindText & "%' or CPU3 like '%" & sFindText & "%' or CPUmhz3 like '%" & sFindText & "%' or CPU4 like '%" & sFindText & "%' or CPUmhz4 like '%" & sFindText & "%' or Mb_Name like '%" & sFindText & "%' or Mb_Chip like '%" & sFindText & "%' or Mb_Proizvod like '%" & sFindText & "%' or RAM_1 like '%" & sFindText & "%' or RAM_2 like '%" & sFindText & "%' or RAM_3 like '%" & sFindText & "%' or RAM_4 like '%" & sFindText & "%' or HDD_Name_1 like '%" & sFindText & "%' or HDD_OB_1 like '%" & sFindText & "%' or HDD_SN_1 like '%" & sFindText & "%' or HDD_Name_2 like '%" & sFindText & "%' or HDD_OB_2 like '%" & sFindText & "%' or HDD_SN_2 like '%" & sFindText & "%' or HDD_Name_3 like '%" & sFindText & "%' or HDD_OB_3 like '%" & sFindText & "%' or HDD_SN_3 like '%" & sFindText & "%' or HDD_Name_4 like '%" & sFindText & "%' or HDD_OB_4 like '%" & sFindText & "%' or HDD_SN_4 like '%" & sFindText & "%' or SVGA_NAME like '%" & sFindText & "%' or SVGA_SN like '%" & sFindText & "%' or SOUND_NAME like '%" & sFindText & "%' or CD_NAME like '%" & sFindText & "%' or CD_SPEED like '%" & sFindText & "%' or CD_SN like '%" & sFindText & "%' or CDRW_NAME like '%" & sFindText & "%' or CDRW_SPEED like '%" & sFindText & "%' or CDRW_SN like '%" & sFindText & "%' or DVD_NAME like '%" & sFindText & "%' or DVD_SPEED like '%" & sFindText & "%' or DVD_SN like '%" & sFindText & "%' or NET_NAME_1 like '%" & sFindText & "%' or NET_IP_1 like '%" & sFindText & "%' or NET_MAC_1 like '%" & sFindText & "%' or NET_NAME_2 like '%" & sFindText & "%' or NET_IP_2 like '%" & sFindText & "%' or NET_MAC_2 like '%" & sFindText & "%' or MODEM_NAME like '%" & sFindText & "%' or MODEM_SN like '%" & sFindText & "%' or MONITOR_NAME like '%" & sFindText & "%' or MONITOR_NAME2 like '%" & sFindText & "%' or MONITOR_SN like '%" & sFindText & "%' or MONITOR_SN2 like '%" & sFindText & "%'or AS_NAME like '%" & sFindText & "%' or AS_PROIZV like '%" & sFindText & "%' or IBP_NAME like '%" & sFindText & "%' or FILTR_NAME like '%" & sFindText & "%' or PRINTER_NAME_1 like '%" & sFindText & "%' or PRINTER_SN_1 like '%" & sFindText & "%' or PORT_1 like '%" & sFindText & "%' or PRINTER_PROIZV_1 like '%" & sFindText & "%' or PRINTER_NAME_2 like '%" & sFindText & "%' or PORT_2 like '%" & sFindText & "%' or PRINTER_SN_2 like '%" & sFindText & "%' or PRINTER_PROIZV_2 like '%" & sFindText & "%' or PRINTER_NAME_3 like '%" & sFindText & "%' or PORT_3 like '%" & sFindText & "%' or PRINTER_SN_3 like '%" & sFindText & "%' or PRINTER_PROIZV_3 like '%" & sFindText & "%' or PORT_4 like '%" & sFindText & "%' or PRINTER_NAME_4 like '%" & sFindText & "%' or PRINTER_SN_4 like '%" & sFindText & "%' or PRINTER_PROIZV_4 like '%" & sFindText & "%' or SCANER_NAME like '%" & sFindText & "%' or NET_NAME like '%" & sFindText & "%' or PSEVDONIM like '%" & sFindText & "%' or MESTO like '%" & sFindText & "%' or kabn like '%" & sFindText & "%' or FILIAL like '%" & sFindText & "%' or TELEPHONE like '%" & sFindText & "%' or INV_NO_SYSTEM like '%" & sFindText & "%' or INV_NO_PRINTER like '%" & sFindText & "%' or INV_NO_MODEM like '%" & sFindText & "%' or INV_NO_SCANER like '%" & sFindText & "%' or INV_NO_MONITOR like '%" & sFindText & "%' or INV_NO_IBP like '%" & sFindText & "%' or OTvetstvennyj like '%" & sFindText & "%' or Ser_N_SIS like '%" & sFindText & "%' or BLOCK like '%" & sFindText & "%' or SN_BLOCK like '%" & sFindText & "%' or CREADER_NAME like '%" & sFindText & "%' or CASE_NAME like '%" & sFindText & "%' or CASE_SN like '%" & sFindText & "%' or CASE_PROIZV like '%" & sFindText & "%' or SYS_PR like '%" & sFindText & "%'order by PSEVDONIM, filial"

        rs.Open(sSQL, DB7, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic)

        If Trim(sGroupName) = LNGIniFile.GetString("frmSearch", "MSG13", "Все") Then
            sGroupName = "*"
        End If

        If MtchWord = 1 And MtchCase = 1 Then
            mde = 3
        Else
            If MtchWord = 1 And MtchCase = 0 Then
                mde = 2
            Else
                If MtchCase = 1 And MtchWord = 0 Then
                    mde = 1
                Else
                    If MtchCase = 0 And MtchWord = 0 Then
                        mde = 0
                    End If
                End If
            End If
        End If

        Dim lngCounter As Integer
        Label3.Text = "Идет поиск ждите..."

        With rs
            .MoveFirst()
            Do While Not .EOF

                If Trim(sGroupName) = "*" Then GoTo SRCCH

                If .Fields("filial").Value <> sGroupName Then GoTo SRCCH2


                SRCCH:

                FirstColumn = True

                For lngCounter = 0 To rs.Fields.Count - 2

                    If FirstColumn Then

                        If Not IsDBNull(.Fields(lngCounter).Value) Then _
                            If isThere(.Fields(lngCounter).Value, sFindText, mde) = True Then GoTo Foundit

                    Else

                    End If                  'TO KEEP DATA FROM SHIFTING LEFT

                Next


                GoTo SRCCH2
                Foundit:
                ' Application.DoEvents()

                lstSearch.Items.Add(.Fields("id").Value) 'col no. 1

             Select Case .Fields("Tiptehn").Value

                        Case "MFU"
                            lstSearch.Items(CInt(intCount)).SubItems.Add(LNGIniFile.GetString("frmSearch", "MSG2", "МФУ"))
                            lstSearch.Items(CInt(intCount)).SubItems.Add("")
                            lstSearch.Items(CInt(intCount)).SubItems.Add("")
                            lstSearch.Items(CInt(intCount)).SubItems.Add("")
                            lstSearch.Items(CInt(intCount)).SubItems.Add("")

                        Case "Printer"
                            lstSearch.Items(CInt(intCount)).SubItems.Add(LNGIniFile.GetString("frmSearch", "MSG3",
                                                                                              "Принтер"))
                            lstSearch.Items(CInt(intCount)).SubItems.Add("")
                            lstSearch.Items(CInt(intCount)).SubItems.Add("")
                            lstSearch.Items(CInt(intCount)).SubItems.Add("")
                            lstSearch.Items(CInt(intCount)).SubItems.Add("")

                        Case "KOpir"
                            lstSearch.Items(CInt(intCount)).SubItems.Add(LNGIniFile.GetString("frmSearch", "MSG4",
                                                                                              "Копировальный аппарат"))
                            lstSearch.Items(CInt(intCount)).SubItems.Add("")
                            lstSearch.Items(CInt(intCount)).SubItems.Add("")
                            lstSearch.Items(CInt(intCount)).SubItems.Add("")
                            lstSearch.Items(CInt(intCount)).SubItems.Add("")

                        Case "PHOTO"
                            lstSearch.Items(CInt(intCount)).SubItems.Add(LNGIniFile.GetString("frmSearch", "MSG5",
                                                                                              "Фотоаппарат"))
                            lstSearch.Items(CInt(intCount)).SubItems.Add("")
                            lstSearch.Items(CInt(intCount)).SubItems.Add("")
                            lstSearch.Items(CInt(intCount)).SubItems.Add("")
                            lstSearch.Items(CInt(intCount)).SubItems.Add("")

                        Case "PHONE"
                            lstSearch.Items(CInt(intCount)).SubItems.Add(LNGIniFile.GetString("frmSearch", "MSG6",
                                                                                              "Телефон"))
                            lstSearch.Items(CInt(intCount)).SubItems.Add("")
                            lstSearch.Items(CInt(intCount)).SubItems.Add("")
                            lstSearch.Items(CInt(intCount)).SubItems.Add("")
                            lstSearch.Items(CInt(intCount)).SubItems.Add("")

                        Case "FAX"
                            lstSearch.Items(CInt(intCount)).SubItems.Add(LNGIniFile.GetString("frmSearch", "MSG7",
                                                                                              "Факс"))
                            lstSearch.Items(CInt(intCount)).SubItems.Add("")
                            lstSearch.Items(CInt(intCount)).SubItems.Add("")
                            lstSearch.Items(CInt(intCount)).SubItems.Add("")
                            lstSearch.Items(CInt(intCount)).SubItems.Add("")

                        Case "ZIP"
                            lstSearch.Items(CInt(intCount)).SubItems.Add(LNGIniFile.GetString("frmSearch", "MSG8", "ZIP"))
                            lstSearch.Items(CInt(intCount)).SubItems.Add("")
                            lstSearch.Items(CInt(intCount)).SubItems.Add("")
                            lstSearch.Items(CInt(intCount)).SubItems.Add("")
                            lstSearch.Items(CInt(intCount)).SubItems.Add("")

                        Case "MONITOR"
                            lstSearch.Items(CInt(intCount)).SubItems.Add(LNGIniFile.GetString("frmSearch", "MSG9",
                                                                                              "Монитор"))
                            lstSearch.Items(CInt(intCount)).SubItems.Add("")
                            lstSearch.Items(CInt(intCount)).SubItems.Add("")
                            lstSearch.Items(CInt(intCount)).SubItems.Add("")
                            lstSearch.Items(CInt(intCount)).SubItems.Add("")

                        Case "SCANER"
                            lstSearch.Items(CInt(intCount)).SubItems.Add(LNGIniFile.GetString("frmSearch", "MSG10",
                                                                                              "Сканер"))
                            lstSearch.Items(CInt(intCount)).SubItems.Add("")
                            lstSearch.Items(CInt(intCount)).SubItems.Add("")
                            lstSearch.Items(CInt(intCount)).SubItems.Add("")
                            lstSearch.Items(CInt(intCount)).SubItems.Add("")

                        Case "NET"
                            lstSearch.Items(CInt(intCount)).SubItems.Add(LNGIniFile.GetString("frmSearch", "MSG11",
                                                                                              "Сетевое устройство"))
                            lstSearch.Items(CInt(intCount)).SubItems.Add("")
                            lstSearch.Items(CInt(intCount)).SubItems.Add("")
                            lstSearch.Items(CInt(intCount)).SubItems.Add("")
                            lstSearch.Items(CInt(intCount)).SubItems.Add("")

                        Case "OT"
                            lstSearch.Items(CInt(intCount)).SubItems.Add(LNGIniFile.GetString("frmSearch", "MSG12",
                                                                                              "Другое оборудование"))
                            lstSearch.Items(CInt(intCount)).SubItems.Add("")
                            lstSearch.Items(CInt(intCount)).SubItems.Add("")
                            lstSearch.Items(CInt(intCount)).SubItems.Add("")
                            lstSearch.Items(CInt(intCount)).SubItems.Add("")


                        Case "PC"

                            lstSearch.Items(CInt(intCount)).SubItems.Add(.Fields("CPU1").Value)
                        lstSearch.Items(CInt(intCount)).SubItems.Add(
                            IIf(.Fields("MB_NAME").Value <> "", "MB: " & .Fields("MB_NAME").Value, "") &
                            IIf(.Fields("Mb_Chip").Value <> "", " Чипсет: " & .Fields("Mb_Chip").Value, "") &
                            IIf(.Fields("RAM_1").Value <> "", " Память: " & .Fields("RAM_1").Value, "") &
                            IIf(.Fields("HDD_Name_1").Value <> "", " Жесткий диск: " & .Fields("HDD_Name_1").Value, ""))

                            lstSearch.Items(CInt(intCount)).SubItems.Add(.Fields("SVGA_NAME").Value)
                            lstSearch.Items(CInt(intCount)).SubItems.Add(.Fields("SOUND_NAME").Value)
                            lstSearch.Items(CInt(intCount)).SubItems.Add(.Fields("CD_NAME").Value)


                    End Select

                
                lstSearch.Items(CInt(intCount)).SubItems.Add(.Fields("mesto").Value & "/" & .Fields("filial").Value)

                SfilS = .Fields("filial").Value
                lstSearch.Items(CInt(intCount)).SubItems.Add(.Fields("NET_NAME").Value)
                lstSearch.Items(CInt(intCount)).SubItems.Add(FINDTXT)

                intCount = intCount + 1

                If intCount Mod 1 = 0 Then
                    status(intCount & " ")
                Else
                End If

                'Application.DoEvents()

                Label3.Text = "Идет поиск ждите, найдено: " & intCount
                SRCCH2:
                'Application.DoEvents()
                .MoveNext()
            Loop
        End With

        rs.Close()
        rs = Nothing


        Label3.Text = "Поиск завершен, найдено: " & intCount

        ResList(Me.lstSearch)

        If intCount Mod 1 = 0 Then
            status(intCount & " ")
        Else
        End If
    End Sub


    Private Sub frmSearch_Activated(ByVal sender As Object, ByVal e As EventArgs) Handles Me.Activated
        frmMain.SaveInfTehButton.Enabled = False
        frmMain.ToolStripDropDownButton1.Enabled = False
    End Sub

    Private Sub frmSearch_Load(ByVal sender As Object, ByVal e As EventArgs) Handles Me.Load

        SendFonts(Me)

        Call frmSearch_Lang()
        FillComboNET(Me.lstGroups, "FILIAL", "SPR_FILIAL", "", False, True)

        Dim objIniFile As New IniFile(sLANGPATH)
        lstGroups.Items.Add(objIniFile.GetString("frmSearch", "MSG13", "Все"))

        lstGroups.Text = objIniFile.GetString("frmSearch", "MSG13", "Все")
        txtSearch.Focus()
    End Sub


    Private Sub Button1_Click(ByVal sender As Object, ByVal e As EventArgs) Handles Button1.Click
        lstSearch.Items.Clear()
        FINDTXT = ""

        If CheckBox1.Checked = True Then
            a = 1
        Else
            a = 0
        End If

        If CheckBox2.Checked = True Then
            b = 1
        Else
            b = 0
        End If

        Me.BeginInvoke(New MethodInvoker(AddressOf RT_SEARCHE))

        ' Search(lstGroups.Text, txtSearch.Text, a, b)

    End Sub

    Private Sub RT_SEARCHE()
        Search(lstGroups.Text, txtSearch.Text, a, b)
    End Sub



    Private Sub btnOfSend_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnOfSend.Click
        On Error GoTo Err_

        If lstSearch.Items.Count = 0 Then Exit Sub


        Select Case sOfficePACK

            Case "OpenOffice.org"

                ExportListViewToCalc(lstSearch, Me.Text & " " & txtSearch.Text)

            Case Else

                ExportListViewToExcel(lstSearch, Me.Text & " " & txtSearch.Text)

        End Select


        Exit Sub
        Err_:
        MsgBox("Error " & Err.Number & " " & Err.Description)
    End Sub

    Private Sub lstSearch_DoubleClick(ByVal sender As Object, ByVal e As EventArgs) Handles lstSearch.DoubleClick
        Dim objIniFile As New IniFile(PrPath & "base.ini")

        If lstSearch.Items.Count = 0 Then Exit Sub
        Dim z As Integer

        For z = 0 To lstSearch.SelectedItems.Count - 1
            objIniFile.WriteString("general", "DK", lstSearch.SelectedItems(z).Text)
            objIniFile.WriteString("general", "Default", 0)
        Next

        'Dim newThread4 As New Thread(AddressOf frmComputers.R_T_LOAD)
        'newThread4.Start()
        Me.BeginInvoke(New MethodInvoker(AddressOf frmComputers.R_T_LOAD))

        frmComputers.Focus()
    End Sub

    Private Sub txtSearch_KeyDown(ByVal sender As Object, ByVal e As KeyEventArgs) Handles txtSearch.KeyDown
        Select Case e.KeyCode

            Case Keys.Enter

                lstSearch.Items.Clear()
                FINDTXT = ""

                If CheckBox1.Checked = True Then
                    a = 1
                Else
                    a = 0
                End If

                If CheckBox2.Checked = True Then
                    b = 1
                Else
                    b = 0
                End If

                'Dim newThread4 As New Thread(AddressOf RT_SEARCHE)
                'newThread4.Start()

                '_backgroundWorker1 = New BackgroundWorker()
                '_backgroundWorker1.WorkerSupportsCancellation = False
                '_backgroundWorker1.WorkerReportsProgress = False

                'AddHandler Me._backgroundWorker1.DoWork, New DoWorkEventHandler(AddressOf RT_SEARCHE)
                '_backgroundWorker1.RunWorkerAsync()


                Me.BeginInvoke(New MethodInvoker(AddressOf RT_SEARCHE))

        End Select
    End Sub
End Class