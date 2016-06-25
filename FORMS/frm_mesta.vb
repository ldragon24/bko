Public Class frm_mesta

    Private Sub frm_mesta_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing

        Me.lvReport2Cl.Columns.Clear

    End Sub

    Private Sub frm_mesta_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim tt As String
        tt = frmReports.tmp_mesta
        Me.Text = " ''" & tt & "''"

        Call Report()

    End Sub

    Private Sub Button2_Click(ByVal sender As Object, ByVal e As EventArgs) Handles Button2.Click
        On Error GoTo Err_

        If lvReport2Cl.Items.Count = 0 Then Exit Sub

        Select Case sOfficePACK
            Case "OpenOffice.org"
                ExportListViewToCalc(lvReport2Cl, Me.Text)
            Case Else
                ExportListViewToExcel(lvReport2Cl, Me.Text)
        End Select

        Exit Sub
Err_:
        MsgBox("Error " & Err.Number & " " & Err.Description)
    End Sub

    Private Sub Report()
        Dim langIni As New IniFile(sLANGPATH)

        lvReport2Cl.Sorting = SortOrder.None
        lvReport2Cl.ListViewItemSorter = Nothing

        '#################
        Dim Parametr As String
        Dim unam1 As String
        On Error Resume Next

        Dim sSQL As String

        On Error GoTo Error_

        lvReport2Cl.Items.Clear()

        frmReports.chkReport2Prn.Visible = False

        Select Case Trim(frmReports.cmnReport2Compl.Text)

            Case langIni.GetString("frmReports", "MSG25", "Другое")

                If _
                    frmReports.cmbReport2fil.Text = langIni.GetString("frmReports", "MSG1", "Все") And
                    frmReports.cmbReport2Department.Text = langIni.GetString("frmReports", "MSG1", "Все") Then

                    'sSQL = "SELECT NET_NAME FROM kompy WHERE (tiptehn) = 'MFU'"
                    'sSQL =
                    '    "SELECT net_name, COUNT(net_name) as tot_num FROM kompy WHERE tiptehn = 'OT' group by net_name"

                    sSQL =
                        "SELECT FILIAL, MESTO, kabn, NET_NAME FROM kompy WHERE " &
                        "tiptehn = 'OT' and net_name='" & frmReports.tmp_mesta & "' " &
                        "order by FILIAL, MESTO, kabn, NET_NAME"

                Else

                    If frmReports.cmbReport2Department.Text = langIni.GetString("frmReports", "MSG1", "Все") Then

                        'sSQL = "SELECT NET_NAME FROM kompy WHERE FILIAL='" & frmReports.cmbReport2fil.Text & "' AND tiptehn = 'MFU'"
                        'sSQL = "SELECT net_name, COUNT(net_name) as tot_num FROM kompy WHERE FILIAL='" &
                        '       frmReports.cmbReport2fil.Text & "' AND tiptehn = 'OT' group by net_name"

                        sSQL =
                            "SELECT FILIAL, MESTO, kabn, NET_NAME FROM kompy WHERE " &
                            "tiptehn = 'OT' and net_name='" & frmReports.tmp_mesta & "' " &
                            "and FILIAL='" & frmReports.cmbReport2fil.Text & "' " &
                            "order by FILIAL, MESTO, kabn, NET_NAME"

                    Else
                        'sSQL = "SELECT NET_NAME FROM kompy WHERE FILIAL='" & frmReports.cmbReport2fil.Text & "' and MESTO='" & frmReports.cmbReport2Department.Text & "' AND tiptehn = 'MFU'"
                        'sSQL = "SELECT net_name, COUNT(net_name) as tot_num FROM kompy WHERE FILIAL='" &
                        '       frmReports.cmbReport2fil.Text & "' and MESTO='" & frmReports.cmbReport2Department.Text &
                        '       "' AND tiptehn = 'OT' group by net_name"

                        sSQL =
                            "SELECT FILIAL, MESTO, kabn, NET_NAME FROM kompy WHERE " &
                            "tiptehn = 'OT' and net_name='" & frmReports.tmp_mesta & "' " &
                            "and FILIAL='" & frmReports.cmbReport2fil.Text & "' " &
                            "and MESTO='" & frmReports.cmbReport2Department.Text & "' " &
                            "order by FILIAL, MESTO, kabn, NET_NAME"

                    End If
                End If


            Case langIni.GetString("frmReports", "MSG21", "МФУ")

                If _
                    frmReports.cmbReport2fil.Text = langIni.GetString("frmReports", "MSG1", "Все") And
                    frmReports.cmbReport2Department.Text = langIni.GetString("frmReports", "MSG1", "Все") Then

                    'sSQL = "SELECT NET_NAME FROM kompy WHERE (tiptehn) = 'MFU'"
                    'sSQL =
                    '    "SELECT net_name, COUNT(tiptehn) as tot_num FROM kompy WHERE tiptehn = 'MFU' group by net_name"

                    sSQL =
                        "SELECT FILIAL, MESTO, kabn, NET_NAME FROM kompy WHERE " &
                        "tiptehn = 'MFU' and net_name='" & frmReports.tmp_mesta & "' " &
                        "order by FILIAL, MESTO, kabn, NET_NAME"

                Else

                    If frmReports.cmbReport2Department.Text = langIni.GetString("frmReports", "MSG1", "Все") Then

                        'sSQL = "SELECT NET_NAME FROM kompy WHERE FILIAL='" & frmReports.cmbReport2fil.Text & "' AND tiptehn = 'MFU'"
                        'sSQL = "SELECT net_name, COUNT(tiptehn) as tot_num FROM kompy WHERE FILIAL='" &
                        '       frmReports.cmbReport2fil.Text & "' AND tiptehn = 'MFU' group by net_name"

                        sSQL =
                            "SELECT FILIAL, MESTO, kabn, NET_NAME FROM kompy WHERE " &
                            "tiptehn = 'MFU' and net_name='" & frmReports.tmp_mesta & "' " &
                            "and FILIAL='" & frmReports.cmbReport2fil.Text & "' " &
                            "order by FILIAL, MESTO, kabn, NET_NAME"

                    Else
                        'sSQL = "SELECT NET_NAME FROM kompy WHERE FILIAL='" & frmReports.cmbReport2fil.Text & "' and MESTO='" & frmReports.cmbReport2Department.Text & "' AND tiptehn = 'MFU'"
                        'sSQL = "SELECT net_name, COUNT(tiptehn) as tot_num FROM kompy WHERE FILIAL='" &
                        '       frmReports.cmbReport2fil.Text & "' and MESTO='" & frmReports.cmbReport2Department.Text &
                        '       "' AND tiptehn = 'MFU' group by net_name"

                        sSQL =
                            "SELECT FILIAL, MESTO, kabn, NET_NAME FROM kompy WHERE " &
                            "tiptehn = 'MFU' and net_name='" & frmReports.tmp_mesta & "' " &
                            "and FILIAL='" & frmReports.cmbReport2fil.Text & "' " &
                            "and MESTO='" & frmReports.cmbReport2Department.Text & "' " &
                            "order by FILIAL, MESTO, kabn, NET_NAME"

                    End If
                End If


            Case langIni.GetString("frmReports", "MSG24", "Фотоаппарат")

                If _
                    frmReports.cmbReport2fil.Text = langIni.GetString("frmReports", "MSG1", "Все") And
                    frmReports.cmbReport2Department.Text = langIni.GetString("frmReports", "MSG1", "Все") Then

                    'sSQL = "SELECT NET_NAME FROM kompy WHERE (tiptehn) = 'MFU'"
                    'sSQL =
                    '    "SELECT net_name, COUNT(tiptehn) as tot_num FROM kompy WHERE tiptehn = 'PHOTO' group by net_name"

                    sSQL =
                        "SELECT FILIAL, MESTO, kabn, NET_NAME FROM kompy WHERE " &
                        "tiptehn = 'PHOTO' and net_name='" & frmReports.tmp_mesta & "' " &
                        "order by FILIAL, MESTO, kabn, NET_NAME"

                Else

                    If frmReports.cmbReport2Department.Text = langIni.GetString("frmReports", "MSG1", "Все") Then

                        'sSQL = "SELECT NET_NAME FROM kompy WHERE FILIAL='" & frmReports.cmbReport2fil.Text & "' AND tiptehn = 'MFU'"
                        'sSQL = "SELECT net_name, COUNT(tiptehn) as tot_num FROM kompy WHERE FILIAL='" &
                        '       frmReports.cmbReport2fil.Text & "' AND tiptehn = 'PHOTO' group by net_name"

                        sSQL =
                            "SELECT FILIAL, MESTO, kabn, NET_NAME FROM kompy WHERE " &
                            "tiptehn = 'PHOTO' and net_name='" & frmReports.tmp_mesta & "' " &
                            "and FILIAL='" & frmReports.cmbReport2fil.Text & "' " &
                            "order by FILIAL, MESTO, kabn, NET_NAME"

                    Else
                        'sSQL = "SELECT NET_NAME FROM kompy WHERE FILIAL='" & frmReports.cmbReport2fil.Text & "' and MESTO='" & frmReports.cmbReport2Department.Text & "' AND tiptehn = 'MFU'"
                        'sSQL = "SELECT net_name, COUNT(tiptehn) as tot_num FROM kompy WHERE FILIAL='" &
                        '       frmReports.cmbReport2fil.Text & "' and MESTO='" & frmReports.cmbReport2Department.Text &
                        '       "' AND tiptehn = 'PHOTO' group by net_name"

                        sSQL =
                            "SELECT FILIAL, MESTO, kabn, NET_NAME FROM kompy WHERE " &
                            "tiptehn = 'PHOTO' and net_name='" & frmReports.tmp_mesta & "' " &
                            "and FILIAL='" & frmReports.cmbReport2fil.Text & "' " &
                            "and MESTO='" & frmReports.cmbReport2Department.Text & "' " &
                            "order by FILIAL, MESTO, kabn, NET_NAME"

                    End If
                End If

            Case langIni.GetString("frmReports", "MSG23", "Факс")

                If _
                    frmReports.cmbReport2fil.Text = langIni.GetString("frmReports", "MSG1", "Все") And
                    frmReports.cmbReport2Department.Text = langIni.GetString("frmReports", "MSG1", "Все") Then

                    'sSQL = "SELECT NET_NAME FROM kompy WHERE (tiptehn) = 'MFU'"
                    'sSQL =
                    '    "SELECT net_name, COUNT(tiptehn) as tot_num FROM kompy WHERE tiptehn = 'FAX' group by net_name"

                    sSQL =
                        "SELECT FILIAL, MESTO, kabn, NET_NAME FROM kompy WHERE " &
                        "tiptehn = 'FAX' and net_name='" & frmReports.tmp_mesta & "' " &
                        "order by FILIAL, MESTO, kabn, NET_NAME"

                Else

                    If frmReports.cmbReport2Department.Text = langIni.GetString("frmReports", "MSG1", "Все") Then

                        'sSQL = "SELECT NET_NAME FROM kompy WHERE FILIAL='" & frmReports.cmbReport2fil.Text & "' AND tiptehn = 'MFU'"
                        'sSQL = "SELECT net_name, COUNT(tiptehn) as tot_num FROM kompy WHERE FILIAL='" &
                        '       frmReports.cmbReport2fil.Text & "' AND tiptehn = 'FAX' group by net_name"

                        sSQL =
                            "SELECT FILIAL, MESTO, kabn, NET_NAME FROM kompy WHERE " &
                            "tiptehn = 'FAX' and net_name='" & frmReports.tmp_mesta & "' " &
                            "and FILIAL='" & frmReports.cmbReport2fil.Text & "' " &
                            "order by FILIAL, MESTO, kabn, NET_NAME"

                    Else
                        'sSQL = "SELECT NET_NAME FROM kompy WHERE FILIAL='" & frmReports.cmbReport2fil.Text & "' and MESTO='" & frmReports.cmbReport2Department.Text & "' AND tiptehn = 'MFU'"
                        'sSQL = "SELECT net_name, COUNT(tiptehn) as tot_num FROM kompy WHERE FILIAL='" &
                        '       frmReports.cmbReport2fil.Text & "' and MESTO='" & frmReports.cmbReport2Department.Text &
                        '       "' AND tiptehn = 'FAX' group by net_name"

                        sSQL =
                            "SELECT FILIAL, MESTO, kabn, NET_NAME FROM kompy WHERE " &
                            "tiptehn = 'FAX' and net_name='" & frmReports.tmp_mesta & "' " &
                            "and FILIAL='" & frmReports.cmbReport2fil.Text & "' " &
                            "and MESTO='" & frmReports.cmbReport2Department.Text & "' " &
                            "order by FILIAL, MESTO, kabn, NET_NAME"

                    End If
                End If


                'Êîïèðû
            Case langIni.GetString("frmReports", "MSG20", "Копиры")

                If _
                    frmReports.cmbReport2fil.Text = langIni.GetString("frmReports", "MSG1", "Все") And
                    frmReports.cmbReport2Department.Text = langIni.GetString("frmReports", "MSG1", "Все") Then

                    'sSQL = "SELECT NET_NAME FROM kompy WHERE (tiptehn) = 'MFU'"
                    'sSQL =
                    '    "SELECT net_name, COUNT(tiptehn) as tot_num FROM kompy WHERE tiptehn = 'KOpir' group by net_name"

                    sSQL =
                        "SELECT FILIAL, MESTO, kabn, NET_NAME FROM kompy WHERE " &
                        "tiptehn = 'KOpir' and net_name='" & frmReports.tmp_mesta & "' " &
                        "order by FILIAL, MESTO, kabn, NET_NAME"

                Else

                    If frmReports.cmbReport2Department.Text = langIni.GetString("frmReports", "MSG1", "Все") Then

                        'sSQL = "SELECT NET_NAME FROM kompy WHERE FILIAL='" & frmReports.cmbReport2fil.Text & "' AND tiptehn = 'MFU'"
                        'sSQL = "SELECT net_name, COUNT(tiptehn) as tot_num FROM kompy WHERE FILIAL='" &
                        '       frmReports.cmbReport2fil.Text & "' AND tiptehn = 'KOpir' group by net_name"

                        sSQL =
                            "SELECT FILIAL, MESTO, kabn, NET_NAME FROM kompy WHERE " &
                            "tiptehn = 'KOpir' and net_name='" & frmReports.tmp_mesta & "' " &
                            "and FILIAL='" & frmReports.cmbReport2fil.Text & "' " &
                            "order by FILIAL, MESTO, kabn, NET_NAME"

                    Else
                        'sSQL = "SELECT NET_NAME FROM kompy WHERE FILIAL='" & frmReports.cmbReport2fil.Text & "' and MESTO='" & frmReports.cmbReport2Department.Text & "' AND tiptehn = 'MFU'"
                        'sSQL = "SELECT net_name, COUNT(tiptehn) as tot_num FROM kompy WHERE FILIAL='" &
                        '       frmReports.cmbReport2fil.Text & "' and MESTO='" & frmReports.cmbReport2Department.Text &
                        '       "' AND tiptehn = 'KOpir' group by net_name"

                        sSQL =
                            "SELECT FILIAL, MESTO, kabn, NET_NAME FROM kompy WHERE " &
                            "tiptehn = 'KOpir' and net_name='" & frmReports.tmp_mesta & "' " &
                            "and FILIAL='" & frmReports.cmbReport2fil.Text & "' " &
                            "and MESTO='" & frmReports.cmbReport2Department.Text & "' " &
                            "order by FILIAL, MESTO, kabn, NET_NAME"

                    End If
                End If


            Case langIni.GetString("frmReports", "MSG22", "Телефон")

                If _
                    frmReports.cmbReport2fil.Text = langIni.GetString("frmReports", "MSG1", "Все") And
                    frmReports.cmbReport2Department.Text = langIni.GetString("frmReports", "MSG1", "Все") Then

                    'sSQL = "SELECT NET_NAME FROM kompy WHERE (tiptehn) = 'MFU'"
                    'sSQL =
                    '    "SELECT net_name, COUNT(tiptehn) as tot_num FROM kompy WHERE tiptehn = 'PHONE' group by net_name"

                    sSQL =
                        "SELECT FILIAL, MESTO, kabn, NET_NAME FROM kompy WHERE " &
                        "tiptehn = 'PHONE' and net_name='" & frmReports.tmp_mesta & "' " &
                        "order by FILIAL, MESTO, kabn, NET_NAME"

                Else

                    If frmReports.cmbReport2Department.Text = langIni.GetString("frmReports", "MSG1", "Все") Then

                        'sSQL = "SELECT NET_NAME FROM kompy WHERE FILIAL='" & frmReports.cmbReport2fil.Text & "' AND tiptehn = 'MFU'"
                        'sSQL = "SELECT net_name, COUNT(tiptehn) as tot_num FROM kompy WHERE FILIAL='" &
                        '       frmReports.cmbReport2fil.Text & "' AND tiptehn = 'PHONE' group by net_name"

                        sSQL =
                            "SELECT FILIAL, MESTO, kabn, NET_NAME FROM kompy WHERE " &
                            "tiptehn = 'PHONE' and net_name='" & frmReports.tmp_mesta & "' " &
                            "and FILIAL='" & frmReports.cmbReport2fil.Text & "' " &
                            "order by FILIAL, MESTO, kabn, NET_NAME"

                    Else
                        'sSQL = "SELECT NET_NAME FROM kompy WHERE FILIAL='" & frmReports.cmbReport2fil.Text & "' and MESTO='" & frmReports.cmbReport2Department.Text & "' AND tiptehn = 'MFU'"
                        'sSQL = "SELECT net_name, COUNT(tiptehn) as tot_num FROM kompy WHERE FILIAL='" &
                        '       frmReports.cmbReport2fil.Text & "' and MESTO='" & frmReports.cmbReport2Department.Text &
                        '       "' AND tiptehn = 'PHONE' group by net_name"

                        sSQL =
                            "SELECT FILIAL, MESTO, kabn, NET_NAME FROM kompy WHERE " &
                            "tiptehn = 'PHONE' and net_name='" & frmReports.tmp_mesta & "' " &
                            "and FILIAL='" & frmReports.cmbReport2fil.Text & "' " &
                            "and MESTO='" & frmReports.cmbReport2Department.Text & "' " &
                            "order by FILIAL, MESTO, kabn, NET_NAME"

                    End If
                End If


            Case langIni.GetString("frmReports", "MSG13", "Процессоры")

                If _
                    frmReports.cmbReport2fil.Text = langIni.GetString("frmReports", "MSG1", "Все") And
                    frmReports.cmbReport2Department.Text = langIni.GetString("frmReports", "MSG1", "Все") Then
                    'sSQL = "SELECT cpus.cpu1, Count(*) AS tot_num FROM (SELECT cpu1 FROM kompy union all SELECT cpu2 FROM kompy union all SELECT cpu3 FROM kompy union all SELECT cpu4 FROM kompy) AS cpus GROUP BY cpus.cpu1"
                    'sSQL =
                    '    "SELECT cpus.cpu1, Count(*) AS tot_num FROM (SELECT cpu1 FROM kompy WHERE tiptehn = 'PC' union all SELECT cpu2 FROM kompy WHERE tiptehn = 'PC'  union all SELECT cpu3 FROM kompy WHERE tiptehn = 'PC'  union all SELECT cpu4 FROM kompy WHERE tiptehn = 'PC') AS cpus GROUP BY cpus.cpu1"
                    'sSQL = "SELECT cpus.cpu1, Count(*) AS tot_num FROM (SELECT cpu1 FROM kompy union all SELECT cpu2 FROM kompy union all SELECT cpu3 FROM kompy union all SELECT cpu4 FROM kompy) AS cpus GROUP BY cpus.cpu1"

                    sSQL =
                        "SELECT * FROM " &
                        "(SELECT FILIAL, MESTO, kabn, NET_NAME FROM kompy WHERE tiptehn = 'PC' and cpu1='" & frmReports.tmp_mesta & "' " &
                        "union all SELECT FILIAL, MESTO, kabn, NET_NAME FROM kompy WHERE tiptehn = 'PC' and cpu2='" & frmReports.tmp_mesta & "' " &
                        "union all SELECT FILIAL, MESTO, kabn, NET_NAME FROM kompy WHERE tiptehn = 'PC' and cpu3='" & frmReports.tmp_mesta & "' " &
                        "union all SELECT FILIAL, MESTO, kabn, NET_NAME FROM kompy WHERE tiptehn = 'PC' and cpu4='" & frmReports.tmp_mesta & "' " &
                        ") order by FILIAL, MESTO, kabn, NET_NAME"

                Else

                    If frmReports.cmbReport2Department.Text = langIni.GetString("frmReports", "MSG1", "Все") Then
                        'sSQL =
                        '    "SELECT cpus.cpu1, Count(*) AS tot_num FROM (SELECT cpu1 FROM kompy WHERE FILIAL='" &
                        '    frmReports.cmbReport2fil.Text &
                        '    "' AND tiptehn = 'PC' union all SELECT cpu2 FROM kompy WHERE FILIAL='" &
                        '    frmReports.cmbReport2fil.Text &
                        '    "' AND tiptehn = 'PC'  union all SELECT cpu3 FROM kompy WHERE FILIAL='" &
                        '    frmReports.cmbReport2fil.Text &
                        '    "' AND tiptehn = 'PC'  union all SELECT cpu4 FROM kompy WHERE FILIAL='" &
                        '    frmReports.cmbReport2fil.Text & "' AND tiptehn = 'PC') AS cpus GROUP BY cpus.cpu1"

                        sSQL =
                            "SELECT * FROM " &
                            "(SELECT FILIAL, MESTO, kabn, NET_NAME FROM kompy WHERE tiptehn = 'PC' and cpu1='" & frmReports.tmp_mesta & "' " &
                            "and FILIAL='" & frmReports.cmbReport2fil.Text & "' " &
                            "union all SELECT FILIAL, MESTO, kabn, NET_NAME FROM kompy WHERE tiptehn = 'PC' and cpu2='" & frmReports.tmp_mesta & "' " &
                            "and FILIAL='" & frmReports.cmbReport2fil.Text & "' " &
                            "union all SELECT FILIAL, MESTO, kabn, NET_NAME FROM kompy WHERE tiptehn = 'PC' and cpu3='" & frmReports.tmp_mesta & "' " &
                            "and FILIAL='" & frmReports.cmbReport2fil.Text & "' " &
                            "union all SELECT FILIAL, MESTO, kabn, NET_NAME FROM kompy WHERE tiptehn = 'PC' and cpu4='" & frmReports.tmp_mesta & "' " &
                            "and FILIAL='" & frmReports.cmbReport2fil.Text & "' " &
                            ") order by FILIAL, MESTO, kabn, NET_NAME"

                    Else
                        'sSQL =
                        '    "SELECT cpus.cpu1, Count(*) AS tot_num FROM (SELECT cpu1 FROM kompy WHERE FILIAL='" &
                        '    frmReports.cmbReport2fil.Text & "' and MESTO='" & frmReports.cmbReport2Department.Text &
                        '    "' AND tiptehn = 'PC' union all SELECT cpu2 FROM kompy WHERE FILIAL='" &
                        '    frmReports.cmbReport2fil.Text & "' and MESTO='" & frmReports.cmbReport2Department.Text &
                        '    "' AND tiptehn = 'PC' union all SELECT cpu3 FROM kompy WHERE FILIAL='" &
                        '    frmReports.cmbReport2fil.Text & "' and MESTO='" & frmReports.cmbReport2Department.Text &
                        '    "' AND tiptehn = 'PC' union all SELECT cpu4 FROM kompy WHERE FILIAL='" &
                        '    frmReports.cmbReport2fil.Text & "' and MESTO='" & frmReports.cmbReport2Department.Text &
                        '    "' AND tiptehn = 'PC') AS cpus GROUP BY cpus.cpu1"

                        sSQL =
                            "SELECT * FROM " &
                            "(SELECT FILIAL, MESTO, kabn, NET_NAME FROM kompy WHERE tiptehn = 'PC' and cpu1='" & frmReports.tmp_mesta & "' " &
                            "and FILIAL='" & frmReports.cmbReport2fil.Text & "' " &
                            "and MESTO='" & frmReports.cmbReport2Department.Text & "' " &
                            "union all SELECT FILIAL, MESTO, kabn, NET_NAME FROM kompy WHERE tiptehn = 'PC' and cpu2='" & frmReports.tmp_mesta & "' " &
                            "and FILIAL='" & frmReports.cmbReport2fil.Text & "' " &
                            "and MESTO='" & frmReports.cmbReport2Department.Text & "' " &
                            "union all SELECT FILIAL, MESTO, kabn, NET_NAME FROM kompy WHERE tiptehn = 'PC' and cpu3='" & frmReports.tmp_mesta & "' " &
                            "and FILIAL='" & frmReports.cmbReport2fil.Text & "' " &
                            "and MESTO='" & frmReports.cmbReport2Department.Text & "' " &
                            "union all SELECT FILIAL, MESTO, kabn, NET_NAME FROM kompy WHERE tiptehn = 'PC' and cpu4='" & frmReports.tmp_mesta & "' " &
                            "and FILIAL='" & frmReports.cmbReport2fil.Text & "' " &
                            "and MESTO='" & frmReports.cmbReport2Department.Text & "' " &
                            ") order by FILIAL, MESTO, kabn, NET_NAME"

                    End If
                End If


            Case langIni.GetString("frmReports", "MSG15", "Тип и частота процессора")

                Select Case DB_N

                    Case "MySQL"

                        If _
                            frmReports.cmbReport2fil.Text = langIni.GetString("frmReports", "MSG1", "Все") And
                            frmReports.cmbReport2Department.Text = langIni.GetString("frmReports", "MSG1", "Все") Then
                            sSQL =
                                "SELECT * FROM " &
                                "(SELECT FILIAL, MESTO, kabn, NET_NAME FROM kompy WHERE tiptehn = 'PC' and CONCAT(cpu1,' ',cpumhz1)='" & frmReports.tmp_mesta & "' " &
                                "union all SELECT FILIAL, MESTO, kabn, NET_NAME FROM kompy WHERE tiptehn = 'PC' and CONCAT(cpu2,' ',cpumhz2)='" & frmReports.tmp_mesta & "' " &
                                "union all SELECT FILIAL, MESTO, kabn, NET_NAME FROM kompy WHERE tiptehn = 'PC' and CONCAT(cpu3,' ',cpumhz3)='" & frmReports.tmp_mesta & "' " &
                                "union all SELECT FILIAL, MESTO, kabn, NET_NAME FROM kompy WHERE tiptehn = 'PC' and CONCAT(cpu4,' ',cpumhz4)='" & frmReports.tmp_mesta & "' " &
                                ") order by FILIAL, MESTO, kabn, NET_NAME"

                        Else

                            If frmReports.cmbReport2Department.Text = langIni.GetString("frmReports", "MSG1", "Все") Then
                                sSQL =
                                    "SELECT * FROM " &
                                    "(SELECT FILIAL, MESTO, kabn, NET_NAME FROM kompy WHERE tiptehn = 'PC' and CONCAT(cpu1,' ',cpumhz1)='" & frmReports.tmp_mesta & "' " &
                                    "and FILIAL='" & frmReports.cmbReport2fil.Text & "' " &
                                    "union all SELECT FILIAL, MESTO, kabn, NET_NAME FROM kompy WHERE tiptehn = 'PC' and CONCAT(cpu2,' ',cpumhz2)='" & frmReports.tmp_mesta & "' " &
                                    "and FILIAL='" & frmReports.cmbReport2fil.Text & "' " &
                                    "union all SELECT FILIAL, MESTO, kabn, NET_NAME FROM kompy WHERE tiptehn = 'PC' and CONCAT(cpu3,' ',cpumhz3)='" & frmReports.tmp_mesta & "' " &
                                    "and FILIAL='" & frmReports.cmbReport2fil.Text & "' " &
                                    "union all SELECT FILIAL, MESTO, kabn, NET_NAME FROM kompy WHERE tiptehn = 'PC' and CONCAT(cpu4,' ',cpumhz4)='" & frmReports.tmp_mesta & "' " &
                                    "and FILIAL='" & frmReports.cmbReport2fil.Text & "' " &
                                    ") order by FILIAL, MESTO, kabn, NET_NAME"

                            Else
                                sSQL =
                                    "SELECT * FROM " &
                                    "(SELECT FILIAL, MESTO, kabn, NET_NAME FROM kompy WHERE tiptehn = 'PC' and CONCAT(cpu1,' ',cpumhz1)='" & frmReports.tmp_mesta & "' " &
                                    "and FILIAL='" & frmReports.cmbReport2fil.Text & "' " &
                                    "and MESTO='" & frmReports.cmbReport2Department.Text & "' " &
                                    "union all SELECT FILIAL, MESTO, kabn, NET_NAME FROM kompy WHERE tiptehn = 'PC' and CONCAT(cpu2,' ',cpumhz2)='" & frmReports.tmp_mesta & "' " &
                                    "and FILIAL='" & frmReports.cmbReport2fil.Text & "' " &
                                    "and MESTO='" & frmReports.cmbReport2Department.Text & "' " &
                                    "union all SELECT FILIAL, MESTO, kabn, NET_NAME FROM kompy WHERE tiptehn = 'PC' and CONCAT(cpu3,' ',cpumhz3)='" & frmReports.tmp_mesta & "' " &
                                    "and FILIAL='" & frmReports.cmbReport2fil.Text & "' " &
                                    "and MESTO='" & frmReports.cmbReport2Department.Text & "' " &
                                    "union all SELECT FILIAL, MESTO, kabn, NET_NAME FROM kompy WHERE tiptehn = 'PC' and CONCAT(cpu4,' ',cpumhz4)='" & frmReports.tmp_mesta & "' " &
                                    "and FILIAL='" & frmReports.cmbReport2fil.Text & "' " &
                                    "and MESTO='" & frmReports.cmbReport2Department.Text & "' " &
                                    ") order by FILIAL, MESTO, kabn, NET_NAME"


                            End If
                        End If


                    Case Else

                        If _
                            frmReports.cmbReport2fil.Text = langIni.GetString("frmReports", "MSG1", "Все") And
                            frmReports.cmbReport2Department.Text = langIni.GetString("frmReports", "MSG1", "Все") Then
                            sSQL =
                                "SELECT * FROM " &
                                "(SELECT FILIAL, MESTO, kabn, NET_NAME FROM kompy WHERE tiptehn = 'PC' and (cpu1+' '+ cpumhz1)='" & frmReports.tmp_mesta & "' " &
                                "union all SELECT FILIAL, MESTO, kabn, NET_NAME FROM kompy WHERE tiptehn = 'PC' and (cpu2+' '+ cpumhz2)='" & frmReports.tmp_mesta & "' " &
                                "union all SELECT FILIAL, MESTO, kabn, NET_NAME FROM kompy WHERE tiptehn = 'PC' and (cpu3+' '+ cpumhz3)='" & frmReports.tmp_mesta & "' " &
                                "union all SELECT FILIAL, MESTO, kabn, NET_NAME FROM kompy WHERE tiptehn = 'PC' and (cpu4+' '+ cpumhz4)='" & frmReports.tmp_mesta & "' " &
                                ") order by FILIAL, MESTO, kabn, NET_NAME"

                        Else

                            If frmReports.cmbReport2Department.Text = langIni.GetString("frmReports", "MSG1", "Все") Then
                                sSQL =
                                    "SELECT * FROM " &
                                    "(SELECT FILIAL, MESTO, kabn, NET_NAME FROM kompy WHERE tiptehn = 'PC' and (cpu1+' '+ cpumhz1)='" & frmReports.tmp_mesta & "' " &
                                    "and FILIAL='" & frmReports.cmbReport2fil.Text & "' " &
                                    "union all SELECT FILIAL, MESTO, kabn, NET_NAME FROM kompy WHERE tiptehn = 'PC' and (cpu2+' '+ cpumhz2)='" & frmReports.tmp_mesta & "' " &
                                    "and FILIAL='" & frmReports.cmbReport2fil.Text & "' " &
                                    "union all SELECT FILIAL, MESTO, kabn, NET_NAME FROM kompy WHERE tiptehn = 'PC' and (cpu3+' '+ cpumhz3)='" & frmReports.tmp_mesta & "' " &
                                    "and FILIAL='" & frmReports.cmbReport2fil.Text & "' " &
                                    "union all SELECT FILIAL, MESTO, kabn, NET_NAME FROM kompy WHERE tiptehn = 'PC' and (cpu4+' '+ cpumhz4)='" & frmReports.tmp_mesta & "' " &
                                    "and FILIAL='" & frmReports.cmbReport2fil.Text & "' " &
                                    ") order by FILIAL, MESTO, kabn, NET_NAME"

                            Else
                                sSQL =
                                    "SELECT * FROM " &
                                    "(SELECT FILIAL, MESTO, kabn, NET_NAME FROM kompy WHERE tiptehn = 'PC' and (cpu1+' '+ cpumhz1)='" & frmReports.tmp_mesta & "' " &
                                    "and FILIAL='" & frmReports.cmbReport2fil.Text & "' " &
                                    "and MESTO='" & frmReports.cmbReport2Department.Text & "' " &
                                    "union all SELECT FILIAL, MESTO, kabn, NET_NAME FROM kompy WHERE tiptehn = 'PC' and (cpu2+' '+ cpumhz2)='" & frmReports.tmp_mesta & "' " &
                                    "and FILIAL='" & frmReports.cmbReport2fil.Text & "' " &
                                    "and MESTO='" & frmReports.cmbReport2Department.Text & "' " &
                                    "union all SELECT FILIAL, MESTO, kabn, NET_NAME FROM kompy WHERE tiptehn = 'PC' and (cpu3+' '+ cpumhz3)='" & frmReports.tmp_mesta & "' " &
                                    "and FILIAL='" & frmReports.cmbReport2fil.Text & "' " &
                                    "and MESTO='" & frmReports.cmbReport2Department.Text & "' " &
                                    "union all SELECT FILIAL, MESTO, kabn, NET_NAME FROM kompy WHERE tiptehn = 'PC' and (cpu4+' '+ cpumhz4)='" & frmReports.tmp_mesta & "' " &
                                    "and FILIAL='" & frmReports.cmbReport2fil.Text & "' " &
                                    "and MESTO='" & frmReports.cmbReport2Department.Text & "' " &
                                    ") order by FILIAL, MESTO, kabn, NET_NAME"

                            End If
                        End If

                End Select

            Case langIni.GetString("frmReports", "MSG7", "Материнские платы")

                If _
                    frmReports.cmbReport2fil.Text = langIni.GetString("frmReports", "MSG1", "Все") And
                    frmReports.cmbReport2Department.Text = langIni.GetString("frmReports", "MSG1", "Все") Then

                    'sSQL = "SELECT Mb_name, COUNT(tiptehn) as tot_num FROM kompy WHERE tiptehn = 'PC' group by mb"

                    sSQL =
                        "SELECT FILIAL, MESTO, kabn, NET_NAME FROM kompy WHERE " &
                        "tiptehn = 'PC' and Mb_name='" & frmReports.tmp_mesta & "' " &
                        "order by FILIAL, MESTO, kabn, NET_NAME"

                Else

                    If frmReports.cmbReport2Department.Text = langIni.GetString("frmReports", "MSG1", "Все") Then


                        'sSQL = "SELECT Mb_name, COUNT(tiptehn) as tot_num FROM kompy WHERE FILIAL='" &
                        '       frmReports.cmbReport2fil.Text & "' AND tiptehn = 'PC' group by mb"

                        sSQL =
                            "SELECT FILIAL, MESTO, kabn, NET_NAME FROM kompy WHERE " &
                            "tiptehn = 'PC' and Mb_name='" & frmReports.tmp_mesta & "' " &
                            "and FILIAL='" & frmReports.cmbReport2fil.Text & "' " &
                            "order by FILIAL, MESTO, kabn, NET_NAME"

                    Else

                        'sSQL = "SELECT Mb_name, COUNT(tiptehn) as tot_num FROM kompy WHERE FILIAL='" &
                        '       frmReports.cmbReport2fil.Text & "' and MESTO='" & frmReports.cmbReport2Department.Text &
                        '       "' AND tiptehn = 'PC' group by mb"

                        sSQL =
                            "SELECT FILIAL, MESTO, kabn, NET_NAME FROM kompy WHERE " &
                            "tiptehn = 'PC' and Mb_name='" & frmReports.tmp_mesta & "' " &
                            "and FILIAL='" & frmReports.cmbReport2fil.Text & "' " &
                            "and MESTO='" & frmReports.cmbReport2Department.Text & "' " &
                            "order by FILIAL, MESTO, kabn, NET_NAME"

                    End If
                End If


            Case langIni.GetString("frmReports", "MSG4", "Видео карты")

                If _
                    frmReports.cmbReport2fil.Text = langIni.GetString("frmReports", "MSG1", "Все") And
                    frmReports.cmbReport2Department.Text = langIni.GetString("frmReports", "MSG1", "Все") Then

                    'sSQL = "SELECT NET_NAME FROM kompy WHERE (tiptehn) = 'MFU'"
                    'sSQL =
                    '    "SELECT SVGA_NAME, COUNT(tiptehn) as tot_num FROM kompy WHERE tiptehn = 'PC' group by SVGA_NAME"

                    sSQL =
                        "SELECT FILIAL, MESTO, kabn, NET_NAME FROM kompy WHERE " &
                        "tiptehn = 'PC' and SVGA_NAME='" & frmReports.tmp_mesta & "' " &
                        "order by FILIAL, MESTO, kabn, NET_NAME"

                Else

                    If frmReports.cmbReport2Department.Text = langIni.GetString("frmReports", "MSG1", "Все") Then

                        'sSQL = "SELECT NET_NAME FROM kompy WHERE FILIAL='" & frmReports.cmbReport2fil.Text & "' AND tiptehn = 'MFU'"
                        'sSQL = "SELECT SVGA_NAME, COUNT(tiptehn) as tot_num FROM kompy WHERE FILIAL='" &
                        '       frmReports.cmbReport2fil.Text & "' AND tiptehn = 'PC' group by SVGA_NAME"

                        sSQL =
                            "SELECT FILIAL, MESTO, kabn, NET_NAME FROM kompy WHERE " &
                            "tiptehn = 'PC' and SVGA_NAME='" & frmReports.tmp_mesta & "' " &
                            "and FILIAL='" & frmReports.cmbReport2fil.Text & "' " &
                            "order by FILIAL, MESTO, kabn, NET_NAME"

                    Else
                        'sSQL = "SELECT NET_NAME FROM kompy WHERE FILIAL='" & frmReports.cmbReport2fil.Text & "' and MESTO='" & frmReports.cmbReport2Department.Text & "' AND tiptehn = 'MFU'"
                        'sSQL = "SELECT SVGA_NAME, COUNT(tiptehn) as tot_num FROM kompy WHERE FILIAL='" &
                        '       frmReports.cmbReport2fil.Text & "' and MESTO='" & frmReports.cmbReport2Department.Text &
                        '       "' AND tiptehn = 'PC' group by SVGA_NAME"

                        sSQL =
                            "SELECT FILIAL, MESTO, kabn, NET_NAME FROM kompy WHERE " &
                            "tiptehn = 'PC' and SVGA_NAME='" & frmReports.tmp_mesta & "' " &
                            "and FILIAL='" & frmReports.cmbReport2fil.Text & "' " &
                            "and MESTO='" & frmReports.cmbReport2Department.Text & "' " &
                            "order by FILIAL, MESTO, kabn, NET_NAME"

                    End If
                End If


            Case langIni.GetString("frmReports", "MSG5", "Жесткие диски")

                If _
                    frmReports.cmbReport2fil.Text = langIni.GetString("frmReports", "MSG1", "Все") And
                    frmReports.cmbReport2Department.Text = langIni.GetString("frmReports", "MSG1", "Все") Then

                    'sSQL = "SELECT cpus.HDD_Name_1, Count(*) AS tot_num FROM (SELECT HDD_Name_1 FROM kompy WHERE tiptehn = 'PC' union all SELECT HDD_Name_2 FROM kompy union all SELECT HDD_Name_3 FROM kompy union all SELECT  HDD_Name_4 FROM kompy) AS cpus GROUP BY cpus.HDD_Name_1"
                    'sSQL =
                    '    "SELECT cpus.HDD_Name_1, Count(*) AS tot_num FROM (SELECT HDD_Name_1 FROM kompy WHERE tiptehn = 'PC' union all SELECT HDD_Name_2 FROM kompy WHERE FILIAL='" &
                    '    frmReports.cmbReport2fil.Text &
                    '    "' AND tiptehn = 'PC' union all SELECT HDD_Name_3 FROM kompy WHERE FILIAL='" &
                    '    frmReports.cmbReport2fil.Text &
                    '    "' AND tiptehn = 'PC' union all SELECT  HDD_Name_4 FROM kompy WHERE tiptehn = 'PC' ) AS cpus GROUP BY cpus.HDD_Name_1"

                    sSQL =
                        "SELECT * FROM " &
                        "(SELECT FILIAL, MESTO, kabn, NET_NAME FROM kompy WHERE tiptehn = 'PC' and HDD_Name_1='" & frmReports.tmp_mesta & "' " &
                        "union all SELECT FILIAL, MESTO, kabn, NET_NAME FROM kompy WHERE tiptehn = 'PC' and HDD_Name_2='" & frmReports.tmp_mesta & "' " &
                        "union all SELECT FILIAL, MESTO, kabn, NET_NAME FROM kompy WHERE tiptehn = 'PC' and HDD_Name_3='" & frmReports.tmp_mesta & "' " &
                        "union all SELECT FILIAL, MESTO, kabn, NET_NAME FROM kompy WHERE tiptehn = 'PC' and HDD_Name_4='" & frmReports.tmp_mesta & "' " &
                        ") order by FILIAL, MESTO, kabn, NET_NAME"

                Else

                    If frmReports.cmbReport2Department.Text = langIni.GetString("frmReports", "MSG1", "Все") Then
                        'sSQL =
                        '    "SELECT cpus.HDD_Name_1, Count(*) AS tot_num FROM (SELECT HDD_Name_1 FROM kompy WHERE FILIAL='" &
                        '    frmReports.cmbReport2fil.Text &
                        '    "' AND tiptehn = 'PC' union all SELECT HDD_Name_2 FROM kompy WHERE FILIAL='" &
                        '    frmReports.cmbReport2fil.Text &
                        '    "' AND tiptehn = 'PC' union all SELECT HDD_Name_3 FROM kompy WHERE FILIAL='" &
                        '    frmReports.cmbReport2fil.Text &
                        '    "' AND tiptehn = 'PC' union all SELECT  HDD_Name_4 FROM kompy WHERE FILIAL='" &
                        '    frmReports.cmbReport2fil.Text & "' AND tiptehn = 'PC' ) AS cpus GROUP BY cpus.HDD_Name_1"

                        sSQL =
                            "SELECT * FROM " &
                            "(SELECT FILIAL, MESTO, kabn, NET_NAME FROM kompy WHERE tiptehn = 'PC' and HDD_Name_1='" & frmReports.tmp_mesta & "' " &
                            "and FILIAL='" & frmReports.cmbReport2fil.Text & "' " &
                            "union all SELECT FILIAL, MESTO, kabn, NET_NAME FROM kompy WHERE tiptehn = 'PC' and HDD_Name_2='" & frmReports.tmp_mesta & "' " &
                            "and FILIAL='" & frmReports.cmbReport2fil.Text & "' " &
                            "union all SELECT FILIAL, MESTO, kabn, NET_NAME FROM kompy WHERE tiptehn = 'PC' and HDD_Name_3='" & frmReports.tmp_mesta & "' " &
                            "and FILIAL='" & frmReports.cmbReport2fil.Text & "' " &
                            "union all SELECT FILIAL, MESTO, kabn, NET_NAME FROM kompy WHERE tiptehn = 'PC' and HDD_Name_4='" & frmReports.tmp_mesta & "' " &
                            "and FILIAL='" & frmReports.cmbReport2fil.Text & "' " &
                            ") order by FILIAL, MESTO, kabn, NET_NAME"

                    Else
                        'sSQL =
                        '    "SELECT cpus.HDD_Name_1, Count(*) AS tot_num FROM (SELECT HDD_Name_1 FROM kompy WHERE FILIAL='" &
                        '    frmReports.cmbReport2fil.Text & "' and MESTO='" & frmReports.cmbReport2Department.Text &
                        '    "' AND tiptehn = 'PC'union all SELECT HDD_Name_2 FROM kompy WHERE FILIAL='" &
                        '    frmReports.cmbReport2fil.Text & "' and MESTO='" & frmReports.cmbReport2Department.Text &
                        '    "' AND tiptehn = 'PC'union all SELECT HDD_Name_3 FROM kompy WHERE FILIAL='" &
                        '    frmReports.cmbReport2fil.Text & "' and MESTO='" & frmReports.cmbReport2Department.Text &
                        '    "' AND tiptehn = 'PC' union all SELECT HDD_Name_4 FROM kompy  WHERE FILIAL='" &
                        '    frmReports.cmbReport2fil.Text & "' and MESTO='" & frmReports.cmbReport2Department.Text &
                        '    "' AND tiptehn = 'PC') AS cpus GROUP BY cpus.HDD_Name_1"

                        sSQL =
                            "SELECT * FROM " &
                            "(SELECT FILIAL, MESTO, kabn, NET_NAME FROM kompy WHERE tiptehn = 'PC' and HDD_Name_1='" & frmReports.tmp_mesta & "' " &
                            "and FILIAL='" & frmReports.cmbReport2fil.Text & "' " &
                            "and MESTO='" & frmReports.cmbReport2Department.Text & "' " &
                            "union all SELECT FILIAL, MESTO, kabn, NET_NAME FROM kompy WHERE tiptehn = 'PC' and HDD_Name_2='" & frmReports.tmp_mesta & "' " &
                            "and FILIAL='" & frmReports.cmbReport2fil.Text & "' " &
                            "and MESTO='" & frmReports.cmbReport2Department.Text & "' " &
                            "union all SELECT FILIAL, MESTO, kabn, NET_NAME FROM kompy WHERE tiptehn = 'PC' and HDD_Name_3='" & frmReports.tmp_mesta & "' " &
                            "and FILIAL='" & frmReports.cmbReport2fil.Text & "' " &
                            "and MESTO='" & frmReports.cmbReport2Department.Text & "' " &
                            "union all SELECT FILIAL, MESTO, kabn, NET_NAME FROM kompy WHERE tiptehn = 'PC' and HDD_Name_4='" & frmReports.tmp_mesta & "' " &
                            "and FILIAL='" & frmReports.cmbReport2fil.Text & "' " &
                            "and MESTO='" & frmReports.cmbReport2Department.Text & "' " &
                            ") order by FILIAL, MESTO, kabn, NET_NAME"

                    End If
                End If


            Case langIni.GetString("frmReports", "MSG14", "Сетевые карты")

                If _
                    frmReports.cmbReport2fil.Text = langIni.GetString("frmReports", "MSG1", "Все") And
                    frmReports.cmbReport2Department.Text = langIni.GetString("frmReports", "MSG1", "Все") Then
                    'sSQL = "SELECT cpus.NET_NAME_1, Count(*) AS tot_num FROM (SELECT NET_NAME_1 FROM kompy union all SELECT NET_NAME_2 FROM kompy) AS cpus GROUP BY cpus.NET_NAME_1"
                    'sSQL =
                    '    "SELECT cpus.NET_NAME_1, Count(*) AS tot_num FROM (SELECT NET_NAME_1 FROM kompy WHERE tiptehn = 'PC' union all SELECT NET_NAME_2 FROM kompy WHERE tiptehn = 'PC' ) AS cpus GROUP BY cpus.NET_NAME_1"

                    sSQL =
                        "SELECT * FROM " &
                        "(SELECT FILIAL, MESTO, kabn, NET_NAME FROM kompy WHERE tiptehn = 'PC' and NET_NAME_1='" & frmReports.tmp_mesta & "' " &
                        "union all SELECT FILIAL, MESTO, kabn, NET_NAME FROM kompy WHERE tiptehn = 'PC' and NET_NAME_2='" & frmReports.tmp_mesta & "' " &
                        ") order by FILIAL, MESTO, kabn, NET_NAME"

                Else

                    If frmReports.cmbReport2Department.Text = langIni.GetString("frmReports", "MSG1", "Все") Then
                        'sSQL =
                        '    "SELECT cpus.NET_NAME_1, Count(*) AS tot_num FROM (SELECT NET_NAME_1 FROM kompy WHERE FILIAL='" &
                        '    frmReports.cmbReport2fil.Text &
                        '    "' AND tiptehn = 'PC' union all SELECT NET_NAME_2 FROM kompy WHERE FILIAL='" &
                        '    frmReports.cmbReport2fil.Text & "' AND tiptehn = 'PC' ) AS cpus GROUP BY cpus.NET_NAME_1"

                        sSQL =
                            "SELECT * FROM " &
                            "(SELECT FILIAL, MESTO, kabn, NET_NAME FROM kompy WHERE tiptehn = 'PC' and NET_NAME_1='" & frmReports.tmp_mesta & "' " &
                            "and FILIAL='" & frmReports.cmbReport2fil.Text & "' " &
                            "union all SELECT FILIAL, MESTO, kabn, NET_NAME FROM kompy WHERE tiptehn = 'PC' and NET_NAME_2='" & frmReports.tmp_mesta & "' " &
                            "and FILIAL='" & frmReports.cmbReport2fil.Text & "' " &
                            ") order by FILIAL, MESTO, kabn, NET_NAME"

                    Else
                        'sSQL =
                        '    "SELECT cpus.NET_NAME_1, Count(*) AS tot_num FROM (SELECT NET_NAME_1 FROM kompy WHERE FILIAL='" &
                        '    frmReports.cmbReport2fil.Text & "' and MESTO='" & frmReports.cmbReport2Department.Text &
                        '    "' AND tiptehn = 'PC'union all SELECT NET_NAME_2 FROM kompy WHERE FILIAL='" &
                        '    frmReports.cmbReport2fil.Text & "' and MESTO='" & frmReports.cmbReport2Department.Text &
                        '    "' AND tiptehn = 'PC') AS cpus GROUP BY cpus.NET_NAME_1"

                        sSQL =
                            "SELECT * FROM " &
                            "(SELECT FILIAL, MESTO, kabn, NET_NAME FROM kompy WHERE tiptehn = 'PC' and NET_NAME_1='" & frmReports.tmp_mesta & "' " &
                            "and FILIAL='" & frmReports.cmbReport2fil.Text & "' " &
                            "and MESTO='" & frmReports.cmbReport2Department.Text & "' " &
                            "union all SELECT FILIAL, MESTO, kabn, NET_NAME FROM kompy WHERE tiptehn = 'PC' and NET_NAME_2='" & frmReports.tmp_mesta & "' " &
                            "and FILIAL='" & frmReports.cmbReport2fil.Text & "' " &
                            "and MESTO='" & frmReports.cmbReport2Department.Text & "' " &
                            ") order by FILIAL, MESTO, kabn, NET_NAME"

                    End If
                End If

            Case langIni.GetString("frmReports", "MSG8", "Модем")

                If _
                    frmReports.cmbReport2fil.Text = langIni.GetString("frmReports", "MSG1", "Все") And
                    frmReports.cmbReport2Department.Text = langIni.GetString("frmReports", "MSG1", "Все") Then

                    'sSQL =
                    '    "SELECT MODEM_NAME, COUNT(tiptehn) as tot_num FROM kompy WHERE tiptehn = 'PC' group by MODEM_NAME"

                    sSQL =
                        "SELECT FILIAL, MESTO, kabn, NET_NAME FROM kompy WHERE " &
                        "tiptehn = 'PC' and MODEM_NAME='" & frmReports.tmp_mesta & "' " &
                        "order by FILIAL, MESTO, kabn, NET_NAME"

                Else

                    If frmReports.cmbReport2Department.Text = langIni.GetString("frmReports", "MSG1", "Все") Then

                        sSQL = "SELECT MODEM_NAME, COUNT(tiptehn) as tot_num FROM kompy WHERE FILIAL='" &
                               frmReports.cmbReport2fil.Text & "' AND tiptehn = 'PC' group by MODEM_NAME"

                        sSQL =
                            "SELECT FILIAL, MESTO, kabn, NET_NAME FROM kompy WHERE " &
                            "tiptehn = 'PC' and MODEM_NAME='" & frmReports.tmp_mesta & "' " &
                            "and FILIAL='" & frmReports.cmbReport2fil.Text & "' " &
                            "order by FILIAL, MESTO, kabn, NET_NAME"

                    Else

                        'sSQL = "SELECT MODEM_NAME, COUNT(tiptehn) as tot_num FROM kompy WHERE FILIAL='" &
                        '       frmReports.cmbReport2fil.Text & "' and MESTO='" & frmReports.cmbReport2Department.Text &
                        '       "' AND tiptehn = 'PC' group by MODEM_NAME"

                        sSQL =
                            "SELECT FILIAL, MESTO, kabn, NET_NAME FROM kompy WHERE " &
                            "tiptehn = 'PC' and MODEM_NAME='" & frmReports.tmp_mesta & "' " &
                            "and FILIAL='" & frmReports.cmbReport2fil.Text & "' " &
                            "and MESTO='" & frmReports.cmbReport2Department.Text & "' " &
                            "order by FILIAL, MESTO, kabn, NET_NAME"

                    End If
                End If


            Case langIni.GetString("frmReports", "MSG3", "USB")

                If _
                    frmReports.cmbReport2fil.Text = langIni.GetString("frmReports", "MSG1", "Все") And
                    frmReports.cmbReport2Department.Text = langIni.GetString("frmReports", "MSG1", "Все") Then

                    'sSQL =
                    '    "SELECT USB_NAME, COUNT(tiptehn) as tot_num FROM kompy WHERE tiptehn = 'PC' group by USB_NAME"

                    sSQL =
                        "SELECT FILIAL, MESTO, kabn, NET_NAME FROM kompy WHERE " &
                        "tiptehn = 'PC' and USB_NAME='" & frmReports.tmp_mesta & "' " &
                        "order by FILIAL, MESTO, kabn, NET_NAME"

                Else

                    If frmReports.cmbReport2Department.Text = langIni.GetString("frmReports", "MSG1", "Все") Then


                        'sSQL = "SELECT USB_NAME, COUNT(tiptehn) as tot_num FROM kompy WHERE FILIAL='" &
                        '       frmReports.cmbReport2fil.Text & "' AND tiptehn = 'PC' group by USB_NAME"

                        sSQL =
                            "SELECT FILIAL, MESTO, kabn, NET_NAME FROM kompy WHERE " &
                            "tiptehn = 'PC' and USB_NAME='" & frmReports.tmp_mesta & "' " &
                            "and FILIAL='" & frmReports.cmbReport2fil.Text & "' " &
                            "order by FILIAL, MESTO, kabn, NET_NAME"

                    Else

                        'sSQL = "SELECT USB_NAME, COUNT(tiptehn) as tot_num FROM kompy WHERE FILIAL='" &
                        '       frmReports.cmbReport2fil.Text & "' and MESTO='" & frmReports.cmbReport2Department.Text &
                        '       "' AND tiptehn = 'PC' group by USB_NAME"

                        sSQL =
                            "SELECT FILIAL, MESTO, kabn, NET_NAME FROM kompy WHERE " &
                            "tiptehn = 'PC' and USB_NAME='" & frmReports.tmp_mesta & "' " &
                            "and FILIAL='" & frmReports.cmbReport2fil.Text & "' " &
                            "and MESTO='" & frmReports.cmbReport2Department.Text & "' " &
                            "order by FILIAL, MESTO, kabn, NET_NAME"

                    End If
                End If


            Case langIni.GetString("frmReports", "MSG2", "PCI")

                If _
                    frmReports.cmbReport2fil.Text = langIni.GetString("frmReports", "MSG1", "Все") And
                    frmReports.cmbReport2Department.Text = langIni.GetString("frmReports", "MSG1", "Все") Then

                    'sSQL =
                    '    "SELECT PCI_NAME, COUNT(tiptehn) as tot_num FROM kompy WHERE tiptehn = 'PC' group by PCI_NAME"

                    sSQL =
                        "SELECT FILIAL, MESTO, kabn, NET_NAME FROM kompy WHERE " &
                        "tiptehn = 'PC' and PCI_NAME='" & frmReports.tmp_mesta & "' " &
                        "order by FILIAL, MESTO, kabn, NET_NAME"

                Else

                    If frmReports.cmbReport2Department.Text = langIni.GetString("frmReports", "MSG1", "Все") Then


                        'sSQL = "SELECT PCI_NAME, COUNT(tiptehn) as tot_num FROM kompy WHERE FILIAL='" &
                        '       frmReports.cmbReport2fil.Text & "' AND tiptehn = 'PC' group by PCI_NAME"

                        sSQL =
                            "SELECT FILIAL, MESTO, kabn, NET_NAME FROM kompy WHERE " &
                            "tiptehn = 'PC' and PCI_NAME='" & frmReports.tmp_mesta & "' " &
                            "and FILIAL='" & frmReports.cmbReport2fil.Text & "' " &
                            "order by FILIAL, MESTO, kabn, NET_NAME"

                    Else

                        'sSQL = "SELECT PCI_NAME, COUNT(tiptehn) as tot_num FROM kompy WHERE FILIAL='" &
                        '       frmReports.cmbReport2fil.Text & "' and MESTO='" & frmReports.cmbReport2Department.Text &
                        '       "' AND tiptehn = 'PC' group by PCI_NAME"

                        sSQL =
                            "SELECT FILIAL, MESTO, kabn, NET_NAME FROM kompy WHERE " &
                            "tiptehn = 'PC' and PCI_NAME='" & frmReports.tmp_mesta & "' " &
                            "and FILIAL='" & frmReports.cmbReport2fil.Text & "' " &
                            "and MESTO='" & frmReports.cmbReport2Department.Text & "' " &
                            "order by FILIAL, MESTO, kabn, NET_NAME"

                    End If
                End If


            Case langIni.GetString("frmReports", "MSG19", "Оптические накопители")

                If _
                    frmReports.cmbReport2fil.Text = langIni.GetString("frmReports", "MSG1", "Все") And
                    frmReports.cmbReport2Department.Text = langIni.GetString("frmReports", "MSG1", "Все") Then
                    'sSQL = "SELECT cpus.CD_NAME, Count(*) AS tot_num FROM (SELECT CD_NAME FROM kompy union all SELECT CDRW_NAME FROM kompy union all SELECT DVD_NAME FROM kompy) AS cpus GROUP BY cpus.CD_NAME"
                    'sSQL =
                    '    "SELECT cpus.CD_NAME, Count(*) AS tot_num FROM (SELECT CD_NAME FROM kompy WHERE tiptehn = 'PC' union all SELECT CDRW_NAME FROM kompy WHERE tiptehn = 'PC'  union all SELECT DVD_NAME FROM kompy WHERE tiptehn = 'PC') AS cpus GROUP BY cpus.CD_NAME"

                    sSQL =
                        "SELECT * FROM " &
                        "(SELECT FILIAL, MESTO, kabn, NET_NAME FROM kompy WHERE tiptehn = 'PC' and CD_NAME='" & frmReports.tmp_mesta & "' " &
                        "union all SELECT FILIAL, MESTO, kabn, NET_NAME FROM kompy WHERE tiptehn = 'PC' and CDRW_NAME='" & frmReports.tmp_mesta & "' " &
                        "union all SELECT FILIAL, MESTO, kabn, NET_NAME FROM kompy WHERE tiptehn = 'PC' and DVD_NAME='" & frmReports.tmp_mesta & "' " &
                        ") order by FILIAL, MESTO, kabn, NET_NAME"
                Else

                    If frmReports.cmbReport2Department.Text = langIni.GetString("frmReports", "MSG1", "Все") Then
                        'sSQL =
                        '    "SELECT cpus.CD_NAME, Count(*) AS tot_num FROM (SELECT CD_NAME FROM kompy WHERE FILIAL='" &
                        '    frmReports.cmbReport2fil.Text &
                        '    "' AND tiptehn = 'PC' union all SELECT CDRW_NAME FROM kompy WHERE FILIAL='" &
                        '    frmReports.cmbReport2fil.Text &
                        '    "' AND tiptehn = 'PC'  union all SELECT DVD_NAME FROM kompy WHERE FILIAL='" &
                        '    frmReports.cmbReport2fil.Text & "' AND tiptehn = 'PC') AS cpus GROUP BY cpus.CD_NAME"

                        sSQL =
                            "SELECT * FROM " &
                            "(SELECT FILIAL, MESTO, kabn, NET_NAME FROM kompy WHERE tiptehn = 'PC' and CD_NAME='" & frmReports.tmp_mesta & "' " &
                            "and FILIAL='" & frmReports.cmbReport2fil.Text & "' " &
                            "union all SELECT FILIAL, MESTO, kabn, NET_NAME FROM kompy WHERE tiptehn = 'PC' and CDRW_NAME='" & frmReports.tmp_mesta & "' " &
                            "and FILIAL='" & frmReports.cmbReport2fil.Text & "' " &
                            "union all SELECT FILIAL, MESTO, kabn, NET_NAME FROM kompy WHERE tiptehn = 'PC' and DVD_NAME='" & frmReports.tmp_mesta & "' " &
                            "and FILIAL='" & frmReports.cmbReport2fil.Text & "' " &
                            ") order by FILIAL, MESTO, kabn, NET_NAME"

                    Else
                        'sSQL =
                        '    "SELECT cpus.CD_NAME, Count(*) AS tot_num FROM (SELECT CD_NAME FROM kompy WHERE FILIAL='" &
                        '    frmReports.cmbReport2fil.Text & "' and MESTO='" & frmReports.cmbReport2Department.Text &
                        '    "' AND tiptehn = 'PC' union all SELECT CDRW_NAME FROM kompy WHERE FILIAL='" &
                        '    frmReports.cmbReport2fil.Text & "' and MESTO='" & frmReports.cmbReport2Department.Text &
                        '    "' AND tiptehn = 'PC' union all SELECT DVD_NAME FROM kompy WHERE FILIAL='" &
                        '    frmReports.cmbReport2fil.Text & "' and MESTO='" & frmReports.cmbReport2Department.Text &
                        '    "' AND tiptehn = 'PC') AS cpus GROUP BY cpus.CD_NAME"

                        sSQL =
                            "SELECT * FROM " &
                            "(SELECT FILIAL, MESTO, kabn, NET_NAME FROM kompy WHERE tiptehn = 'PC' and CD_NAME='" & frmReports.tmp_mesta & "' " &
                            "and FILIAL='" & frmReports.cmbReport2fil.Text & "' " &
                            "and MESTO='" & frmReports.cmbReport2Department.Text & "' " &
                            "union all SELECT FILIAL, MESTO, kabn, NET_NAME FROM kompy WHERE tiptehn = 'PC' and CDRW_NAME='" & frmReports.tmp_mesta & "' " &
                            "and FILIAL='" & frmReports.cmbReport2fil.Text & "' " &
                            "and MESTO='" & frmReports.cmbReport2Department.Text & "' " &
                            "union all SELECT FILIAL, MESTO, kabn, NET_NAME FROM kompy WHERE tiptehn = 'PC' and DVD_NAME='" & frmReports.tmp_mesta & "' " &
                            "and FILIAL='" & frmReports.cmbReport2fil.Text & "' " &
                            "and MESTO='" & frmReports.cmbReport2Department.Text & "' " &
                            ") order by FILIAL, MESTO, kabn, NET_NAME"

                    End If
                End If


            Case langIni.GetString("frmReports", "MSG9", "Монитор")

                If _
                    frmReports.cmbReport2fil.Text = langIni.GetString("frmReports", "MSG1", "Все") And
                    frmReports.cmbReport2Department.Text = langIni.GetString("frmReports", "MSG1", "Все") Then
                    'sSQL = "SELECT cpus.MONITOR_NAME, Count(*) AS tot_num FROM (SELECT MONITOR_NAME FROM kompy union all SELECT MONITOR_NAME2 FROM kompy) AS cpus GROUP BY cpus.MONITOR_NAME"
                    'sSQL =
                    '    "SELECT cpus.MONITOR_NAME, Count(*) AS tot_num FROM (SELECT MONITOR_NAME FROM kompy union all SELECT MONITOR_NAME2 FROM kompy) AS cpus GROUP BY cpus.MONITOR_NAME"

                    sSQL =
                        "SELECT * FROM " &
                        "(SELECT FILIAL, MESTO, kabn, NET_NAME FROM kompy WHERE MONITOR_NAME='" & frmReports.tmp_mesta & "' " &
                        "union all SELECT FILIAL, MESTO, kabn, NET_NAME FROM kompy WHERE MONITOR_NAME2='" & frmReports.tmp_mesta & "' " &
                        ") order by FILIAL, MESTO, kabn, NET_NAME"

                Else

                    If frmReports.cmbReport2Department.Text = langIni.GetString("frmReports", "MSG1", "Все") Then
                        'sSQL =
                        '    "SELECT cpus.MONITOR_NAME, Count(*) AS tot_num FROM (SELECT MONITOR_NAME FROM kompy WHERE FILIAL='" &
                        '    frmReports.cmbReport2fil.Text & "' union all SELECT MONITOR_NAME2 FROM kompy WHERE FILIAL='" &
                        '    frmReports.cmbReport2fil.Text & "') AS cpus GROUP BY cpus.MONITOR_NAME"

                        sSQL =
                            "SELECT * FROM " &
                            "(SELECT FILIAL, MESTO, kabn, NET_NAME FROM kompy WHERE MONITOR_NAME='" & frmReports.tmp_mesta & "' " &
                            "union all SELECT FILIAL, MESTO, kabn, NET_NAME FROM kompy WHERE MONITOR_NAME2='" & frmReports.tmp_mesta & "' " &
                            ") order by FILIAL, MESTO, kabn, NET_NAME"

                    Else
                        'sSQL =
                        '    "SELECT cpus.MONITOR_NAME, Count(*) AS tot_num FROM (SELECT MONITOR_NAME FROM kompy WHERE FILIAL='" &
                        '    frmReports.cmbReport2fil.Text & "' and MESTO='" & frmReports.cmbReport2Department.Text &
                        '    "' union all SELECT MONITOR_NAME2 FROM kompy WHERE FILIAL='" & frmReports.cmbReport2fil.Text &
                        '    "' and MESTO='" & frmReports.cmbReport2Department.Text & "') AS cpus GROUP BY cpus.MONITOR_NAME"

                        sSQL =
                            "SELECT * FROM " &
                            "(SELECT FILIAL, MESTO, kabn, NET_NAME FROM kompy WHERE MONITOR_NAME='" & frmReports.tmp_mesta & "' " &
                            "and FILIAL='" & frmReports.cmbReport2fil.Text & "' " &
                            "and MESTO='" & frmReports.cmbReport2Department.Text & "' " &
                            "union all SELECT FILIAL, MESTO, kabn, NET_NAME FROM kompy WHERE MONITOR_NAME2='" & frmReports.tmp_mesta & "' " &
                            "and FILIAL='" & frmReports.cmbReport2fil.Text & "' " &
                            "and MESTO='" & frmReports.cmbReport2Department.Text & "' " &
                            ") order by FILIAL, MESTO, kabn, NET_NAME"

                    End If
                End If


            Case langIni.GetString("frmReports", "MSG6", "Звуковая карта")

                If _
                    frmReports.cmbReport2fil.Text = langIni.GetString("frmReports", "MSG1", "Все") And
                    frmReports.cmbReport2Department.Text = langIni.GetString("frmReports", "MSG1", "Все") Then

                    'sSQL = "SELECT NET_NAME FROM kompy WHERE (tiptehn) = 'MFU'"
                    'sSQL =
                    '    "SELECT SOUND_NAME, COUNT(tiptehn) as tot_num FROM kompy WHERE tiptehn = 'PC' group by SOUND_NAME"

                    sSQL =
                        "SELECT FILIAL, MESTO, kabn, NET_NAME FROM kompy WHERE " &
                        "tiptehn = 'PC' and SOUND_NAME='" & frmReports.tmp_mesta & "' " &
                        "order by FILIAL, MESTO, kabn, NET_NAME"

                Else

                    If frmReports.cmbReport2Department.Text = langIni.GetString("frmReports", "MSG1", "Все") Then

                        'sSQL = "SELECT NET_NAME FROM kompy WHERE FILIAL='" & frmReports.cmbReport2fil.Text & "' AND tiptehn = 'MFU'"
                        'sSQL = "SELECT SOUND_NAME, COUNT(tiptehn) as tot_num FROM kompy WHERE FILIAL='" &
                        '       frmReports.cmbReport2fil.Text & "' AND tiptehn = 'PC' group by SOUND_NAME"

                        sSQL =
                            "SELECT FILIAL, MESTO, kabn, NET_NAME FROM kompy WHERE " &
                            "tiptehn = 'PC' and SOUND_NAME='" & frmReports.tmp_mesta & "' " &
                            "and FILIAL='" & frmReports.cmbReport2fil.Text & "' " &
                            "order by FILIAL, MESTO, kabn, NET_NAME"

                    Else
                        'sSQL = "SELECT NET_NAME FROM kompy WHERE FILIAL='" & frmReports.cmbReport2fil.Text & "' and MESTO='" & frmReports.cmbReport2Department.Text & "' AND tiptehn = 'MFU'"
                        'sSQL = "SELECT SOUND_NAME, COUNT(tiptehn) as tot_num FROM kompy WHERE FILIAL='" &
                        '       frmReports.cmbReport2fil.Text & "' and MESTO='" & frmReports.cmbReport2Department.Text &
                        '       "' AND tiptehn = 'PC' group by SOUND_NAME"

                        sSQL =
                            "SELECT FILIAL, MESTO, kabn, NET_NAME FROM kompy WHERE " &
                            "tiptehn = 'PC' and SOUND_NAME='" & frmReports.tmp_mesta & "' " &
                            "and FILIAL='" & frmReports.cmbReport2fil.Text & "' " &
                            "and MESTO='" & frmReports.cmbReport2Department.Text & "' " &
                            "order by FILIAL, MESTO, kabn, NET_NAME"

                    End If
                End If


            Case langIni.GetString("frmReports", "MSG10", "Память ОЗУ")
                Select Case DB_N
                    Case "MySQL"
                        If _
                            frmReports.cmbReport2fil.Text = langIni.GetString("frmReports", "MSG1", "Все") And
                            frmReports.cmbReport2Department.Text = langIni.GetString("frmReports", "MSG1", "Все") Then
                            sSQL =
                                "SELECT * FROM " &
                                "(SELECT FILIAL, MESTO, kabn, NET_NAME FROM kompy WHERE tiptehn = 'PC' and CONCAT(RAM_1,' ',RAM_speed_1)='" & frmReports.tmp_mesta & "' " &
                                "union all SELECT FILIAL, MESTO, kabn, NET_NAME FROM kompy WHERE tiptehn = 'PC' and CONCAT(RAM_2,' ',RAM_speed_2)='" & frmReports.tmp_mesta & "' " &
                                "union all SELECT FILIAL, MESTO, kabn, NET_NAME FROM kompy WHERE tiptehn = 'PC' and CONCAT(RAM_3,' ',RAM_speed_3)='" & frmReports.tmp_mesta & "' " &
                                "union all SELECT FILIAL, MESTO, kabn, NET_NAME FROM kompy WHERE tiptehn = 'PC' and CONCAT(RAM_4,' ',RAM_speed_4)='" & frmReports.tmp_mesta & "' " &
                                ") order by FILIAL, MESTO, kabn, NET_NAME"

                        Else

                            If frmReports.cmbReport2Department.Text = langIni.GetString("frmReports", "MSG1", "Все") Then
                                sSQL =
                                    "SELECT * FROM " &
                                    "(SELECT FILIAL, MESTO, kabn, NET_NAME FROM kompy WHERE tiptehn = 'PC' and CONCAT(RAM_1,' ',RAM_speed_1)='" & frmReports.tmp_mesta & "' " &
                                    "and FILIAL='" & frmReports.cmbReport2fil.Text & "' " &
                                    "union all SELECT FILIAL, MESTO, kabn, NET_NAME FROM kompy WHERE tiptehn = 'PC' and CONCAT(RAM_2,' ',RAM_speed_2)='" & frmReports.tmp_mesta & "' " &
                                    "and FILIAL='" & frmReports.cmbReport2fil.Text & "' " &
                                    "union all SELECT FILIAL, MESTO, kabn, NET_NAME FROM kompy WHERE tiptehn = 'PC' and CONCAT(RAM_3,' ',RAM_speed_3)='" & frmReports.tmp_mesta & "' " &
                                    "and FILIAL='" & frmReports.cmbReport2fil.Text & "' " &
                                    "union all SELECT FILIAL, MESTO, kabn, NET_NAME FROM kompy WHERE tiptehn = 'PC' and CONCAT(RAM_4,' ',RAM_speed_4)='" & frmReports.tmp_mesta & "' " &
                                    "and FILIAL='" & frmReports.cmbReport2fil.Text & "' " &
                                    ") order by FILIAL, MESTO, kabn, NET_NAME"

                            Else
                                sSQL =
                                    "SELECT * FROM " &
                                    "(SELECT FILIAL, MESTO, kabn, NET_NAME FROM kompy WHERE tiptehn = 'PC' and CONCAT(RAM_1,' ',RAM_speed_1)='" & frmReports.tmp_mesta & "' " &
                                    "and FILIAL='" & frmReports.cmbReport2fil.Text & "' " &
                                    "and MESTO='" & frmReports.cmbReport2Department.Text & "' " &
                                    "union all SELECT FILIAL, MESTO, kabn, NET_NAME FROM kompy WHERE tiptehn = 'PC' and CONCAT(RAM_2,' ',RAM_speed_2)='" & frmReports.tmp_mesta & "' " &
                                    "and FILIAL='" & frmReports.cmbReport2fil.Text & "' " &
                                    "and MESTO='" & frmReports.cmbReport2Department.Text & "' " &
                                    "union all SELECT FILIAL, MESTO, kabn, NET_NAME FROM kompy WHERE tiptehn = 'PC' and CONCAT(RAM_3,' ',RAM_speed_3)='" & frmReports.tmp_mesta & "' " &
                                    "and FILIAL='" & frmReports.cmbReport2fil.Text & "' " &
                                    "and MESTO='" & frmReports.cmbReport2Department.Text & "' " &
                                    "union all SELECT FILIAL, MESTO, kabn, NET_NAME FROM kompy WHERE tiptehn = 'PC' and CONCAT(RAM_4,' ',RAM_speed_4)='" & frmReports.tmp_mesta & "' " &
                                    "and FILIAL='" & frmReports.cmbReport2fil.Text & "' " &
                                    "and MESTO='" & frmReports.cmbReport2Department.Text & "' " &
                                    ") order by FILIAL, MESTO, kabn, NET_NAME"

                            End If
                        End If
                    Case Else
                        If _
                            frmReports.cmbReport2fil.Text = langIni.GetString("frmReports", "MSG1", "Все") And
                            frmReports.cmbReport2Department.Text = langIni.GetString("frmReports", "MSG1", "Все") Then
                            sSQL =
                                "SELECT * FROM " &
                                "(SELECT FILIAL, MESTO, kabn, NET_NAME FROM kompy WHERE tiptehn = 'PC' and (RAM_1+' '+RAM_speed_1)='" & frmReports.tmp_mesta & "' " &
                                "union all SELECT FILIAL, MESTO, kabn, NET_NAME FROM kompy WHERE tiptehn = 'PC' and (RAM_2+' '+RAM_speed_2)='" & frmReports.tmp_mesta & "' " &
                                "union all SELECT FILIAL, MESTO, kabn, NET_NAME FROM kompy WHERE tiptehn = 'PC' and (RAM_3+' '+RAM_speed_3)='" & frmReports.tmp_mesta & "' " &
                                "union all SELECT FILIAL, MESTO, kabn, NET_NAME FROM kompy WHERE tiptehn = 'PC' and (RAM_4+' '+RAM_speed_4)='" & frmReports.tmp_mesta & "' " &
                                ") order by FILIAL, MESTO, kabn, NET_NAME"

                        Else

                            If frmReports.cmbReport2Department.Text = langIni.GetString("frmReports", "MSG1", "Все") Then
                                sSQL =
                                    "SELECT * FROM " &
                                    "(SELECT FILIAL, MESTO, kabn, NET_NAME FROM kompy WHERE tiptehn = 'PC' and (RAM_1+' '+RAM_speed_1)='" & frmReports.tmp_mesta & "' " &
                                    "and FILIAL='" & frmReports.cmbReport2fil.Text & "' " &
                                    "union all SELECT FILIAL, MESTO, kabn, NET_NAME FROM kompy WHERE tiptehn = 'PC' and (RAM_2+' '+RAM_speed_2)='" & frmReports.tmp_mesta & "' " &
                                    "and FILIAL='" & frmReports.cmbReport2fil.Text & "' " &
                                    "union all SELECT FILIAL, MESTO, kabn, NET_NAME FROM kompy WHERE tiptehn = 'PC' and (RAM_3+' '+RAM_speed_3)='" & frmReports.tmp_mesta & "' " &
                                    "and FILIAL='" & frmReports.cmbReport2fil.Text & "' " &
                                    "union all SELECT FILIAL, MESTO, kabn, NET_NAME FROM kompy WHERE tiptehn = 'PC' and (RAM_4+' '+RAM_speed_4)='" & frmReports.tmp_mesta & "' " &
                                    "and FILIAL='" & frmReports.cmbReport2fil.Text & "' " &
                                    ") order by FILIAL, MESTO, kabn, NET_NAME"

                            Else
                                sSQL =
                                    "SELECT * FROM " &
                                    "(SELECT FILIAL, MESTO, kabn, NET_NAME FROM kompy WHERE tiptehn = 'PC' and (RAM_1+' '+RAM_speed_1)='" & frmReports.tmp_mesta & "' " &
                                    "and FILIAL='" & frmReports.cmbReport2fil.Text & "' " &
                                    "and MESTO='" & frmReports.cmbReport2Department.Text & "' " &
                                    "union all SELECT FILIAL, MESTO, kabn, NET_NAME FROM kompy WHERE tiptehn = 'PC' and (RAM_2+' '+RAM_speed_2)='" & frmReports.tmp_mesta & "' " &
                                    "and FILIAL='" & frmReports.cmbReport2fil.Text & "' " &
                                    "and MESTO='" & frmReports.cmbReport2Department.Text & "' " &
                                    "union all SELECT FILIAL, MESTO, kabn, NET_NAME FROM kompy WHERE tiptehn = 'PC' and (RAM_3+' '+RAM_speed_3)='" & frmReports.tmp_mesta & "' " &
                                    "and FILIAL='" & frmReports.cmbReport2fil.Text & "' " &
                                    "and MESTO='" & frmReports.cmbReport2Department.Text & "' " &
                                    "union all SELECT FILIAL, MESTO, kabn, NET_NAME FROM kompy WHERE tiptehn = 'PC' and (RAM_4+' '+RAM_speed_4)='" & frmReports.tmp_mesta & "' " &
                                    "and FILIAL='" & frmReports.cmbReport2fil.Text & "' " &
                                    "and MESTO='" & frmReports.cmbReport2Department.Text & "' " &
                                    ") order by FILIAL, MESTO, kabn, NET_NAME"

                            End If
                        End If
                End Select

            Case langIni.GetString("frmReports", "MSG46", "Тип ОЗУ")

                Select Case DB_N
                    Case "MySQL"
                        If _
                            frmReports.cmbReport2fil.Text = langIni.GetString("frmReports", "MSG1", "Все") And
                            frmReports.cmbReport2Department.Text = langIni.GetString("frmReports", "MSG1", "Все") Then
                            sSQL =
                                "SELECT * FROM " &
                                "(SELECT FILIAL, MESTO, kabn, NET_NAME FROM kompy WHERE tiptehn = 'PC' and CONCAT(RAM_speed_1,' / ',RAM_1)='" & frmReports.tmp_mesta & "' " &
                                "union all SELECT FILIAL, MESTO, kabn, NET_NAME FROM kompy WHERE tiptehn = 'PC' and CONCAT(RAM_speed_2,' / ',RAM_2)='" & frmReports.tmp_mesta & "' " &
                                "union all SELECT FILIAL, MESTO, kabn, NET_NAME FROM kompy WHERE tiptehn = 'PC' and CONCAT(RAM_speed_3,' / ',RAM_3)='" & frmReports.tmp_mesta & "' " &
                                "union all SELECT FILIAL, MESTO, kabn, NET_NAME FROM kompy WHERE tiptehn = 'PC' and CONCAT(RAM_speed_4,' / ',RAM_4)='" & frmReports.tmp_mesta & "' " &
                                ") order by FILIAL, MESTO, kabn, NET_NAME"

                        Else

                            If frmReports.cmbReport2Department.Text = langIni.GetString("frmReports", "MSG1", "Все") Then
                                sSQL =
                                    "SELECT * FROM " &
                                    "(SELECT FILIAL, MESTO, kabn, NET_NAME FROM kompy WHERE tiptehn = 'PC' and CONCAT(RAM_speed_1,' / ',RAM_1)='" & frmReports.tmp_mesta & "' " &
                                    "and FILIAL='" & frmReports.cmbReport2fil.Text & "' " &
                                    "union all SELECT FILIAL, MESTO, kabn, NET_NAME FROM kompy WHERE tiptehn = 'PC' and CONCAT(RAM_speed_2,' / ',RAM_2)='" & frmReports.tmp_mesta & "' " &
                                    "and FILIAL='" & frmReports.cmbReport2fil.Text & "' " &
                                    "union all SELECT FILIAL, MESTO, kabn, NET_NAME FROM kompy WHERE tiptehn = 'PC' and CONCAT(RAM_speed_3,' / ',RAM_3)='" & frmReports.tmp_mesta & "' " &
                                    "and FILIAL='" & frmReports.cmbReport2fil.Text & "' " &
                                    "union all SELECT FILIAL, MESTO, kabn, NET_NAME FROM kompy WHERE tiptehn = 'PC' and CONCAT(RAM_speed_4,' / ',RAM_4)='" & frmReports.tmp_mesta & "' " &
                                    "and FILIAL='" & frmReports.cmbReport2fil.Text & "' " &
                                    ") order by FILIAL, MESTO, kabn, NET_NAME"

                            Else
                                sSQL =
                                    "SELECT * FROM " &
                                    "(SELECT FILIAL, MESTO, kabn, NET_NAME FROM kompy WHERE tiptehn = 'PC' and CONCAT(RAM_speed_1,' / ',RAM_1)='" & frmReports.tmp_mesta & "' " &
                                    "and FILIAL='" & frmReports.cmbReport2fil.Text & "' " &
                                    "and MESTO='" & frmReports.cmbReport2Department.Text & "' " &
                                    "union all SELECT FILIAL, MESTO, kabn, NET_NAME FROM kompy WHERE tiptehn = 'PC' and CONCAT(RAM_speed_2,' / ',RAM_2)='" & frmReports.tmp_mesta & "' " &
                                    "and FILIAL='" & frmReports.cmbReport2fil.Text & "' " &
                                    "and MESTO='" & frmReports.cmbReport2Department.Text & "' " &
                                    "union all SELECT FILIAL, MESTO, kabn, NET_NAME FROM kompy WHERE tiptehn = 'PC' and CONCAT(RAM_speed_3,' / ',RAM_3)='" & frmReports.tmp_mesta & "' " &
                                    "and FILIAL='" & frmReports.cmbReport2fil.Text & "' " &
                                    "and MESTO='" & frmReports.cmbReport2Department.Text & "' " &
                                    "union all SELECT FILIAL, MESTO, kabn, NET_NAME FROM kompy WHERE tiptehn = 'PC' and CONCAT(RAM_speed_4,' / ',RAM_4)='" & frmReports.tmp_mesta & "' " &
                                    "and FILIAL='" & frmReports.cmbReport2fil.Text & "' " &
                                    "and MESTO='" & frmReports.cmbReport2Department.Text & "' " &
                                    ") order by FILIAL, MESTO, kabn, NET_NAME"

                            End If
                        End If

                    Case Else
                        If _
                            frmReports.cmbReport2fil.Text = langIni.GetString("frmReports", "MSG1", "Все") And
                            frmReports.cmbReport2Department.Text = langIni.GetString("frmReports", "MSG1", "Все") Then
                            sSQL =
                                "SELECT * FROM " &
                                "(SELECT FILIAL, MESTO, kabn, NET_NAME FROM kompy WHERE tiptehn = 'PC' and (RAM_speed_1+' / '+RAM_1)='" & frmReports.tmp_mesta & "' " &
                                "union all SELECT FILIAL, MESTO, kabn, NET_NAME FROM kompy WHERE tiptehn = 'PC' and (RAM_speed_2+' / '+RAM_2)='" & frmReports.tmp_mesta & "' " &
                                "union all SELECT FILIAL, MESTO, kabn, NET_NAME FROM kompy WHERE tiptehn = 'PC' and (RAM_speed_3+' / '+RAM_3)='" & frmReports.tmp_mesta & "' " &
                                "union all SELECT FILIAL, MESTO, kabn, NET_NAME FROM kompy WHERE tiptehn = 'PC' and (RAM_speed_4+' / '+RAM_4)='" & frmReports.tmp_mesta & "' " &
                                ") order by FILIAL, MESTO, kabn, NET_NAME"

                        Else

                            If frmReports.cmbReport2Department.Text = langIni.GetString("frmReports", "MSG1", "Все") Then
                                sSQL =
                                    "SELECT * FROM " &
                                    "(SELECT FILIAL, MESTO, kabn, NET_NAME FROM kompy WHERE tiptehn = 'PC' and (RAM_speed_1+' / '+RAM_1)='" & frmReports.tmp_mesta & "' " &
                                    "and FILIAL='" & frmReports.cmbReport2fil.Text & "' " &
                                    "union all SELECT FILIAL, MESTO, kabn, NET_NAME FROM kompy WHERE tiptehn = 'PC' and (RAM_speed_2+' / '+RAM_2)='" & frmReports.tmp_mesta & "' " &
                                    "and FILIAL='" & frmReports.cmbReport2fil.Text & "' " &
                                    "union all SELECT FILIAL, MESTO, kabn, NET_NAME FROM kompy WHERE tiptehn = 'PC' and (RAM_speed_3+' / '+RAM_3)='" & frmReports.tmp_mesta & "' " &
                                    "and FILIAL='" & frmReports.cmbReport2fil.Text & "' " &
                                    "union all SELECT FILIAL, MESTO, kabn, NET_NAME FROM kompy WHERE tiptehn = 'PC' and (RAM_speed_4+' / '+RAM_4)='" & frmReports.tmp_mesta & "' " &
                                    "and FILIAL='" & frmReports.cmbReport2fil.Text & "' " &
                                    ") order by FILIAL, MESTO, kabn, NET_NAME"

                            Else
                                sSQL =
                                    "SELECT * FROM " &
                                    "(SELECT FILIAL, MESTO, kabn, NET_NAME FROM kompy WHERE tiptehn = 'PC' and (RAM_speed_1+' / '+RAM_1)='" & frmReports.tmp_mesta & "' " &
                                    "and FILIAL='" & frmReports.cmbReport2fil.Text & "' " &
                                    "and MESTO='" & frmReports.cmbReport2Department.Text & "' " &
                                    "union all SELECT FILIAL, MESTO, kabn, NET_NAME FROM kompy WHERE tiptehn = 'PC' and (RAM_speed_2+' / '+RAM_2)='" & frmReports.tmp_mesta & "' " &
                                    "and FILIAL='" & frmReports.cmbReport2fil.Text & "' " &
                                    "and MESTO='" & frmReports.cmbReport2Department.Text & "' " &
                                    "union all SELECT FILIAL, MESTO, kabn, NET_NAME FROM kompy WHERE tiptehn = 'PC' and (RAM_speed_3+' / '+RAM_3)='" & frmReports.tmp_mesta & "' " &
                                    "and FILIAL='" & frmReports.cmbReport2fil.Text & "' " &
                                    "and MESTO='" & frmReports.cmbReport2Department.Text & "' " &
                                    "union all SELECT FILIAL, MESTO, kabn, NET_NAME FROM kompy WHERE tiptehn = 'PC' and (RAM_speed_4+' / '+RAM_4)='" & frmReports.tmp_mesta & "' " &
                                    "and FILIAL='" & frmReports.cmbReport2fil.Text & "' " &
                                    "and MESTO='" & frmReports.cmbReport2Department.Text & "' " &
                                    ") order by FILIAL, MESTO, kabn, NET_NAME"

                            End If
                        End If

                End Select


            Case langIni.GetString("frmReports", "MSG12", "Производители жестких дисков")

                If _
                    frmReports.cmbReport2fil.Text = langIni.GetString("frmReports", "MSG1", "Все") And
                    frmReports.cmbReport2Department.Text = langIni.GetString("frmReports", "MSG1", "Все") Then
                    'sSQL = "SELECT cpus.HDD_PROIZV_1, Count(*) AS tot_num FROM (SELECT HDD_PROIZV_1 FROM kompy union all SELECT HDD_PROIZV_2 FROM kompy union all SELECT HDD_PROIZV_3 FROM kompy union all SELECT  HDD_PROIZV_4 FROM kompy) AS cpus GROUP BY cpus.HDD_PROIZV_1"
                    'sSQL =
                    '    "SELECT cpus.HDD_PROIZV_1, Count(*) AS tot_num FROM (SELECT HDD_PROIZV_1 FROM kompy WHERE tiptehn = 'PC' union all SELECT HDD_PROIZV_2 FROM kompy WHERE FILIAL='" &
                    '    frmReports.cmbReport2fil.Text &
                    '    "' AND tiptehn = 'PC' union all SELECT HDD_PROIZV_3 FROM kompy WHERE FILIAL='" &
                    '    frmReports.cmbReport2fil.Text &
                    '    "' AND tiptehn = 'PC' union all SELECT  HDD_PROIZV_4 FROM kompy WHERE tiptehn = 'PC' ) AS cpus GROUP BY cpus.HDD_PROIZV_1"

                    sSQL =
                        "SELECT * FROM " &
                        "(SELECT FILIAL, MESTO, kabn, NET_NAME FROM kompy WHERE tiptehn = 'PC' and HDD_PROIZV_1='" & frmReports.tmp_mesta & "' " &
                        "union all SELECT FILIAL, MESTO, kabn, NET_NAME FROM kompy WHERE tiptehn = 'PC' and HDD_PROIZV_2='" & frmReports.tmp_mesta & "' " &
                        "union all SELECT FILIAL, MESTO, kabn, NET_NAME FROM kompy WHERE tiptehn = 'PC' and HDD_PROIZV_3='" & frmReports.tmp_mesta & "' " &
                        "union all SELECT FILIAL, MESTO, kabn, NET_NAME FROM kompy WHERE tiptehn = 'PC' and HDD_PROIZV_4='" & frmReports.tmp_mesta & "' " &
                        ") order by FILIAL, MESTO, kabn, NET_NAME"

                Else

                    If frmReports.cmbReport2Department.Text = langIni.GetString("frmReports", "MSG1", "Все") Then
                        'sSQL =
                        '    "SELECT cpus.HDD_PROIZV_1, Count(*) AS tot_num FROM (SELECT HDD_PROIZV_1 FROM kompy WHERE FILIAL='" &
                        '    frmReports.cmbReport2fil.Text &
                        '    "' AND tiptehn = 'PC' union all SELECT HDD_PROIZV_2 FROM kompy WHERE FILIAL='" &
                        '    frmReports.cmbReport2fil.Text &
                        '    "' AND tiptehn = 'PC' union all SELECT HDD_PROIZV_3 FROM kompy WHERE FILIAL='" &
                        '    frmReports.cmbReport2fil.Text &
                        '    "' AND tiptehn = 'PC' union all SELECT  HDD_PROIZV_4 FROM kompy WHERE FILIAL='" &
                        '    frmReports.cmbReport2fil.Text & "' AND tiptehn = 'PC' ) AS cpus GROUP BY cpus.HDD_PROIZV_1"

                        sSQL =
                            "SELECT * FROM " &
                            "(SELECT FILIAL, MESTO, kabn, NET_NAME FROM kompy WHERE tiptehn = 'PC' and HDD_PROIZV_1='" & frmReports.tmp_mesta & "' " &
                            "and FILIAL='" & frmReports.cmbReport2fil.Text & "' " &
                            "union all SELECT FILIAL, MESTO, kabn, NET_NAME FROM kompy WHERE tiptehn = 'PC' and HDD_PROIZV_2='" & frmReports.tmp_mesta & "' " &
                            "and FILIAL='" & frmReports.cmbReport2fil.Text & "' " &
                            "union all SELECT FILIAL, MESTO, kabn, NET_NAME FROM kompy WHERE tiptehn = 'PC' and HDD_PROIZV_3='" & frmReports.tmp_mesta & "' " &
                            "and FILIAL='" & frmReports.cmbReport2fil.Text & "' " &
                            "union all SELECT FILIAL, MESTO, kabn, NET_NAME FROM kompy WHERE tiptehn = 'PC' and HDD_PROIZV_4='" & frmReports.tmp_mesta & "' " &
                            "and FILIAL='" & frmReports.cmbReport2fil.Text & "' " &
                            ") order by FILIAL, MESTO, kabn, NET_NAME"

                    Else
                        'sSQL =
                        '    "SELECT cpus.HDD_PROIZV_1, Count(*) AS tot_num FROM (SELECT HDD_PROIZV_1 FROM kompy WHERE FILIAL='" &
                        '    frmReports.cmbReport2fil.Text & "' and MESTO='" & frmReports.cmbReport2Department.Text &
                        '    "' AND tiptehn = 'PC'union all SELECT HDD_PROIZV_2 FROM kompy WHERE FILIAL='" &
                        '    frmReports.cmbReport2fil.Text & "' and MESTO='" & frmReports.cmbReport2Department.Text &
                        '    "' AND tiptehn = 'PC'union all SELECT HDD_PROIZV_3 FROM kompy WHERE FILIAL='" &
                        '    frmReports.cmbReport2fil.Text & "' and MESTO='" & frmReports.cmbReport2Department.Text &
                        '    "' AND tiptehn = 'PC' union all SELECT HDD_PROIZV_4 FROM kompy  WHERE FILIAL='" &
                        '    frmReports.cmbReport2fil.Text & "' and MESTO='" & frmReports.cmbReport2Department.Text &
                        '    "' AND tiptehn = 'PC') AS cpus GROUP BY cpus.HDD_PROIZV_1"

                        sSQL =
                            "SELECT * FROM " &
                            "(SELECT FILIAL, MESTO, kabn, NET_NAME FROM kompy WHERE tiptehn = 'PC' and HDD_PROIZV_1='" & frmReports.tmp_mesta & "' " &
                            "and FILIAL='" & frmReports.cmbReport2fil.Text & "' " &
                            "and MESTO='" & frmReports.cmbReport2Department.Text & "' " &
                            "union all SELECT FILIAL, MESTO, kabn, NET_NAME FROM kompy WHERE tiptehn = 'PC' and HDD_PROIZV_2='" & frmReports.tmp_mesta & "' " &
                            "and FILIAL='" & frmReports.cmbReport2fil.Text & "' " &
                            "and MESTO='" & frmReports.cmbReport2Department.Text & "' " &
                            "union all SELECT FILIAL, MESTO, kabn, NET_NAME FROM kompy WHERE tiptehn = 'PC' and HDD_PROIZV_3='" & frmReports.tmp_mesta & "' " &
                            "and FILIAL='" & frmReports.cmbReport2fil.Text & "' " &
                            "and MESTO='" & frmReports.cmbReport2Department.Text & "' " &
                            "union all SELECT FILIAL, MESTO, kabn, NET_NAME FROM kompy WHERE tiptehn = 'PC' and HDD_PROIZV_4='" & frmReports.tmp_mesta & "' " &
                            "and FILIAL='" & frmReports.cmbReport2fil.Text & "' " &
                            "and MESTO='" & frmReports.cmbReport2Department.Text & "' " &
                            ") order by FILIAL, MESTO, kabn, NET_NAME"

                    End If
                End If

                '#PRINTERS
                '######################################################
            Case langIni.GetString("frmReports", "MSG11", "Принтеры")

                frmReports.chkReport2Prn.Visible = True

                Select Case frmReports.chkReport2Prn.Checked


                    Case 0


                        If _
                            frmReports.cmbReport2fil.Text = langIni.GetString("frmReports", "MSG1", "Все") And
                            frmReports.cmbReport2Department.Text = langIni.GetString("frmReports", "MSG1", "Все") Then
                            'sSQL =
                            '    "SELECT net_name as cpus, COUNT(tiptehn) as tot_num  FROM kompy WHERE tiptehn = 'Printer' group by net_name"

                            sSQL =
                                "SELECT FILIAL, MESTO, kabn, NET_NAME FROM kompy WHERE " &
                                "tiptehn = 'Printer' and net_name='" & frmReports.tmp_mesta & "' " &
                                "order by FILIAL, MESTO, kabn,NET_NAME"
                        Else

                            If frmReports.cmbReport2Department.Text = langIni.GetString("frmReports", "MSG1", "Все") Then
                                'sSQL =
                                '    "SELECT net_name as cpus, COUNT(tiptehn) as tot_num  FROM kompy WHERE FILIAL='" &
                                '    frmReports.cmbReport2fil.Text & "' AND tiptehn = 'Printer' group by net_name"

                                sSQL =
                                    "SELECT FILIAL, MESTO, kabn, NET_NAME FROM kompy WHERE " &
                                    "tiptehn = 'Printer' and net_name='" & frmReports.tmp_mesta & "' " &
                                    "and FILIAL='" & frmReports.cmbReport2fil.Text & "' " &
                                    "order by FILIAL, MESTO, kabn,NET_NAME"

                            Else
                                'sSQL =
                                '    "SELECT net_name as cpus, COUNT(tiptehn) as tot_num  FROM kompy WHERE FILIAL='" &
                                '    frmReports.cmbReport2fil.Text & "' and MESTO='" & frmReports.cmbReport2Department.Text &
                                '    "' AND tiptehn = 'Printer' group by net_name"

                                sSQL =
                                    "SELECT FILIAL, MESTO, kabn, NET_NAME FROM kompy WHERE " &
                                    "tiptehn = 'Printer' and net_name='" & frmReports.tmp_mesta & "' " &
                                    "and FILIAL='" & frmReports.cmbReport2fil.Text & "' " &
                                    "and MESTO='" & frmReports.cmbReport2Department.Text & "' " &
                                    "order by FILIAL, MESTO, kabn, NET_NAME"

                            End If
                        End If

                    Case 1

                        If _
                            frmReports.cmbReport2fil.Text = langIni.GetString("frmReports", "MSG1", "Все") And
                            frmReports.cmbReport2Department.Text = langIni.GetString("frmReports", "MSG1", "Все") Then
                            sSQL =
                                "SELECT * FROM " &
                                "(SELECT FILIAL, MESTO, kabn, NET_NAME FROM kompy WHERE tiptehn = 'PC' and PRINTER_NAME_1='" & frmReports.tmp_mesta & "' " &
                                "union all SELECT FILIAL, MESTO, kabn, NET_NAME FROM kompy WHERE tiptehn = 'PC' and PRINTER_NAME_2='" & frmReports.tmp_mesta & "' " &
                                "union all SELECT FILIAL, MESTO, kabn, NET_NAME FROM kompy WHERE tiptehn = 'PC' and PRINTER_NAME_3='" & frmReports.tmp_mesta & "' " &
                                "union all SELECT FILIAL, MESTO, kabn, NET_NAME FROM kompy WHERE tiptehn = 'PC' and PRINTER_NAME_4='" & frmReports.tmp_mesta & "' " &
                                ") order by FILIAL, MESTO, kabn, NET_NAME"

                        Else

                            If frmReports.cmbReport2Department.Text = langIni.GetString("frmReports", "MSG1", "Все") Then
                                'sSQL =
                                '    "SELECT cpus.PRINTER_NAME_1, Count(*) AS tot_num FROM (SELECT PRINTER_NAME_1 FROM kompy WHERE FILIAL='" &
                                '    frmReports.cmbReport2fil.Text &
                                '    "' AND tiptehn = 'PC' union all SELECT PRINTER_NAME_2 FROM kompy WHERE FILIAL='" &
                                '    frmReports.cmbReport2fil.Text &
                                '    "' AND tiptehn = 'PC' union all SELECT PRINTER_NAME_3 FROM kompy WHERE FILIAL='" &
                                '    frmReports.cmbReport2fil.Text &
                                '    "' AND tiptehn = 'PC' union all SELECT  PRINTER_NAME_4 FROM kompy WHERE FILIAL='" &
                                '    frmReports.cmbReport2fil.Text & "' AND tiptehn = 'PC' ) AS cpus GROUP BY cpus.PRINTER_NAME_1"

                                sSQL =
                                    "SELECT * FROM " &
                                    "(SELECT FILIAL, MESTO, kabn, NET_NAME FROM kompy WHERE tiptehn = 'PC' and PRINTER_NAME_1='" & frmReports.tmp_mesta & "' " &
                                    "and FILIAL='" & frmReports.cmbReport2fil.Text & "' " &
                                    "union all SELECT FILIAL, MESTO, kabn, NET_NAME FROM kompy WHERE tiptehn = 'PC' and PRINTER_NAME_2='" & frmReports.tmp_mesta & "' " &
                                    "and FILIAL='" & frmReports.cmbReport2fil.Text & "' " &
                                    "union all SELECT FILIAL, MESTO, kabn, NET_NAME FROM kompy WHERE tiptehn = 'PC' and PRINTER_NAME_3='" & frmReports.tmp_mesta & "' " &
                                    "and FILIAL='" & frmReports.cmbReport2fil.Text & "' " &
                                    "union all SELECT FILIAL, MESTO, kabn, NET_NAME FROM kompy WHERE tiptehn = 'PC' and PRINTER_NAME_4='" & frmReports.tmp_mesta & "' " &
                                    "and FILIAL='" & frmReports.cmbReport2fil.Text & "' " &
                                    ") order by FILIAL, MESTO, kabn, NET_NAME"

                            Else
                                'sSQL =
                                '    "SELECT cpus.PRINTER_NAME_1, Count(*) AS tot_num FROM (SELECT PRINTER_NAME_1 FROM kompy WHERE FILIAL='" &
                                '    frmReports.cmbReport2fil.Text & "' and MESTO='" & frmReports.cmbReport2Department.Text &
                                '    "' AND tiptehn = 'PC' union all SELECT PRINTER_NAME_2 FROM kompy WHERE FILIAL='" &
                                '    frmReports.cmbReport2fil.Text & "' and MESTO='" & frmReports.cmbReport2Department.Text &
                                '    "' AND tiptehn = 'PC' union all SELECT PRINTER_NAME_3 FROM kompy WHERE FILIAL='" &
                                '    frmReports.cmbReport2fil.Text & "' and MESTO='" & frmReports.cmbReport2Department.Text &
                                '    "' AND tiptehn = 'PC' union all SELECT PRINTER_NAME_4 FROM kompy  WHERE FILIAL='" &
                                '    frmReports.cmbReport2fil.Text & "' and MESTO='" & frmReports.cmbReport2Department.Text &
                                '    "' AND tiptehn = 'PC') AS cpus GROUP BY cpus.PRINTER_NAME_1"

                                sSQL =
                                    "SELECT * FROM " &
                                    "(SELECT FILIAL, MESTO, kabn, NET_NAME FROM kompy WHERE tiptehn = 'PC' and PRINTER_NAME_1='" & frmReports.tmp_mesta & "' " &
                                    "and FILIAL='" & frmReports.cmbReport2fil.Text & "' " &
                                    "and MESTO='" & frmReports.cmbReport2Department.Text & "' " &
                                    "union all SELECT FILIAL, MESTO, kabn, NET_NAME FROM kompy WHERE tiptehn = 'PC' and PRINTER_NAME_2='" & frmReports.tmp_mesta & "' " &
                                    "and FILIAL='" & frmReports.cmbReport2fil.Text & "' " &
                                    "and MESTO='" & frmReports.cmbReport2Department.Text & "' " &
                                    "union all SELECT FILIAL, MESTO, kabn, NET_NAME FROM kompy WHERE tiptehn = 'PC' and PRINTER_NAME_3='" & frmReports.tmp_mesta & "' " &
                                    "and FILIAL='" & frmReports.cmbReport2fil.Text & "' " &
                                    "and MESTO='" & frmReports.cmbReport2Department.Text & "' " &
                                    "union all SELECT FILIAL, MESTO, kabn, NET_NAME FROM kompy WHERE tiptehn = 'PC' and PRINTER_NAME_4='" & frmReports.tmp_mesta & "' " &
                                    "and FILIAL='" & frmReports.cmbReport2fil.Text & "' " &
                                    "and MESTO='" & frmReports.cmbReport2Department.Text & "' " &
                                    ") order by FILIAL, MESTO, kabn, NET_NAME"

                            End If
                        End If


                End Select


            Case langIni.GetString("frmReports", "MSG16", "Установленное ПО")
                Dim intCount As Integer = 0

                If _
                    frmReports.cmbReport2fil.Text = langIni.GetString("frmReports", "MSG1", "Все") And
                    frmReports.cmbReport2Department.Text = langIni.GetString("frmReports", "MSG1", "Все") Then

                    sSQL =
                        "SELECT SOFT_INSTALL.VERS, FILIAL, MESTO, kabn, NET_NAME FROM SOFT_INSTALL, kompy WHERE SOFT_INSTALL.Id_Comp=ID " &
                        "and SOFT_INSTALL.Soft='" & frmReports.tmp_mesta & "' order by SOFT_INSTALL.VERS, FILIAL, MESTO, kabn,NET_NAME"

                Else

                    If frmReports.cmbReport2Department.Text = langIni.GetString("frmReports", "MSG1", "Все") Then

                        sSQL =
                             "SELECT SOFT_INSTALL.VERS, FILIAL, MESTO, kabn, NET_NAME FROM SOFT_INSTALL, kompy WHERE SOFT_INSTALL.Id_Comp=ID " &
                             "and FILIAL='" & frmReports.cmbReport2fil.Text & "' " &
                             "and SOFT_INSTALL.Soft='" & frmReports.tmp_mesta & "' order by SOFT_INSTALL.VERS, FILIAL, MESTO, kabn,NET_NAME"
                    Else

                        sSQL =
                            "SELECT SOFT_INSTALL.VERS, FILIAL, MESTO, kabn, NET_NAME FROM SOFT_INSTALL, kompy WHERE SOFT_INSTALL.Id_Comp=ID " &
                            "and FILIAL='" & frmReports.cmbReport2fil.Text & "' " &
                            "and MESTO='" & frmReports.cmbReport2Department.Text & "' " &
                            "and SOFT_INSTALL.Soft='" & frmReports.tmp_mesta & "' order by SOFT_INSTALL.VERS, FILIAL, MESTO, kabn,NET_NAME"

                    End If

                End If


            Case langIni.GetString("frmReports", "MSG17", "Тип и диагональ монитора")

                If _
                    frmReports.cmbReport2fil.Text = langIni.GetString("frmReports", "MSG1", "Все") And
                    frmReports.cmbReport2Department.Text = langIni.GetString("frmReports", "MSG1", "Все") Then
                    'sSQL = "SELECT cpus.Monitor_dum, Count(*) AS tot_num FROM (SELECT Monitor_dum FROM kompy union all SELECT Monitor_dum2 FROM kompy) AS cpus GROUP BY cpus.Monitor_dum"
                    'sSQL =
                    '    "SELECT cpus.Monitor_dum, Count(*) AS tot_num FROM (SELECT Monitor_dum FROM kompy WHERE tiptehn = 'PC' union all SELECT Monitor_dum2 FROM kompy WHERE tiptehn = 'PC' ) AS cpus GROUP BY cpus.Monitor_dum"

                    sSQL =
                        "SELECT * FROM " &
                        "(SELECT FILIAL, MESTO, kabn, NET_NAME FROM kompy WHERE (tiptehn = 'PC' or tiptehn = 'MONITOR') and Monitor_dum='" & frmReports.tmp_mesta & "' " &
                        "union all SELECT FILIAL, MESTO, kabn, NET_NAME FROM kompy WHERE (tiptehn = 'PC' or tiptehn = 'MONITOR') and Monitor_dum2='" & frmReports.tmp_mesta & "' " &
                        ") order by FILIAL, MESTO, kabn, NET_NAME"

                Else

                    If frmReports.cmbReport2Department.Text = langIni.GetString("frmReports", "MSG1", "Все") Then
                        'sSQL =
                        '    "SELECT cpus.Monitor_dum, Count(*) AS tot_num FROM (SELECT Monitor_dum FROM kompy WHERE FILIAL='" &
                        '    frmReports.cmbReport2fil.Text &
                        '    "' AND tiptehn = 'PC' union all SELECT Monitor_dum2 FROM kompy WHERE FILIAL='" &
                        '    frmReports.cmbReport2fil.Text & "' AND tiptehn = 'PC' ) AS cpus GROUP BY cpus.Monitor_dum"

                        sSQL =
                            "SELECT * FROM " &
                            "(SELECT FILIAL, MESTO, kabn, NET_NAME FROM kompy WHERE (tiptehn = 'PC' or tiptehn = 'MONITOR') and Monitor_dum='" & frmReports.tmp_mesta & "' " &
                            "and FILIAL='" & frmReports.cmbReport2fil.Text & "' " &
                            "union all SELECT FILIAL, MESTO, kabn, NET_NAME FROM kompy WHERE (tiptehn = 'PC' or tiptehn = 'MONITOR') and Monitor_dum2='" & frmReports.tmp_mesta & "' " &
                            "and FILIAL='" & frmReports.cmbReport2fil.Text & "' " &
                            ") order by FILIAL, MESTO, kabn, NET_NAME"

                    Else
                        'sSQL =
                        '    "SELECT cpus.Monitor_dum, Count(*) AS tot_num FROM (SELECT Monitor_dum FROM kompy WHERE FILIAL='" &
                        '    frmReports.cmbReport2fil.Text & "' and MESTO='" & frmReports.cmbReport2Department.Text &
                        '    "' AND tiptehn = 'PC'union all SELECT Monitor_dum2 FROM kompy WHERE FILIAL='" &
                        '    frmReports.cmbReport2fil.Text & "' and MESTO='" & frmReports.cmbReport2Department.Text &
                        '    "' AND tiptehn = 'PC') AS cpus GROUP BY cpus.Monitor_dum"

                        sSQL =
                            "SELECT * FROM " &
                            "(SELECT FILIAL, MESTO, kabn, NET_NAME FROM kompy WHERE (tiptehn = 'PC' or tiptehn = 'MONITOR') and Monitor_dum='" & frmReports.tmp_mesta & "' " &
                            "and FILIAL='" & frmReports.cmbReport2fil.Text & "' " &
                            "and MESTO='" & frmReports.cmbReport2Department.Text & "' " &
                            "union all SELECT FILIAL, MESTO, kabn, NET_NAME FROM kompy WHERE (tiptehn = 'PC' or tiptehn = 'MONITOR') and Monitor_dum2='" & frmReports.tmp_mesta & "' " &
                            "and FILIAL='" & frmReports.cmbReport2fil.Text & "' " &
                            "and MESTO='" & frmReports.cmbReport2Department.Text & "' " &
                            ") order by FILIAL, MESTO, kabn, NET_NAME"
                    End If
                End If

            Case langIni.GetString("frmReports", "MSG18", "Сетевые устройства")

                If _
                    frmReports.cmbReport2fil.Text = langIni.GetString("frmReports", "MSG1", "Все") And
                    frmReports.cmbReport2Department.Text = langIni.GetString("frmReports", "MSG1", "Все") Then

                    'sSQL = "SELECT NET_NAME FROM kompy WHERE (tiptehn) = 'MFU'"
                    'sSQL =
                    '    "SELECT PRINTER_SN_1, COUNT(tiptehn) as tot_num FROM kompy WHERE tiptehn = 'NET' group by PRINTER_SN_1"

                    sSQL =
                        "SELECT FILIAL, MESTO, kabn, NET_NAME FROM kompy WHERE " &
                            "tiptehn = 'NET' and PRINTER_SN_1='" & frmReports.tmp_mesta & "' " &
                            "order by FILIAL, MESTO, kabn,NET_NAME"

                Else

                    If frmReports.cmbReport2Department.Text = langIni.GetString("frmReports", "MSG1", "Все") Then

                        'sSQL = "SELECT NET_NAME FROM kompy WHERE FILIAL='" & frmReports.cmbReport2fil.Text & "' AND tiptehn = 'MFU'"
                        'sSQL = "SELECT PRINTER_SN_1, COUNT(tiptehn) as tot_num FROM kompy WHERE FILIAL='" &
                        '       frmReports.cmbReport2fil.Text & "' AND tiptehn = 'NET' group by PRINTER_SN_1"

                        sSQL =
                            "SELECT FILIAL, MESTO, kabn, NET_NAME FROM kompy WHERE " &
                            "tiptehn = 'NET' and PRINTER_SN_1='" & frmReports.tmp_mesta & "' " &
                            "and FILIAL='" & frmReports.cmbReport2fil.Text & "' " &
                            "order by FILIAL, MESTO, kabn,NET_NAME"

                    Else
                        'sSQL = "SELECT NET_NAME FROM kompy WHERE FILIAL='" & frmReports.cmbReport2fil.Text & "' and MESTO='" & frmReports.cmbReport2Department.Text & "' AND tiptehn = 'MFU'"
                        'sSQL = "SELECT PRINTER_SN_1, COUNT(tiptehn) as tot_num FROM kompy WHERE FILIAL='" &
                        '       frmReports.cmbReport2fil.Text & "' and MESTO='" & frmReports.cmbReport2Department.Text &
                        '       "' AND tiptehn = 'NET' group by PRINTER_SN_1"

                        sSQL =
                            "SELECT FILIAL, MESTO, kabn, NET_NAME FROM kompy WHERE " &
                            "tiptehn = 'NET' and PRINTER_SN_1='" & frmReports.tmp_mesta & "' " &
                            "and FILIAL='" & frmReports.cmbReport2fil.Text & "' " &
                            "and MESTO='" & frmReports.cmbReport2Department.Text & "' " &
                            "order by FILIAL, MESTO, kabn,NET_NAME"

                    End If
                End If


            Case Else

                If _
                    frmReports.cmbReport2fil.Text = langIni.GetString("frmReports", "MSG1", "Все") And
                    frmReports.cmbReport2Department.Text = langIni.GetString("frmReports", "MSG1", "Все") Then

                    'sSQL =
                    '   "SELECT SOFT_INSTALL.Soft, COUNT(SOFT_INSTALL.Soft) as tot_num FROM SOFT_INSTALL, kompy WHERE SOFT_INSTALL.Id_Comp=ID and SOFT_INSTALL.TIP='" &
                    '   frmReports.cmnReport2Compl.Text & "' group by SOFT_INSTALL.Soft order by SOFT_INSTALL.Soft"

                    sSQL =
                         "SELECT SOFT_INSTALL.VERS, SOFT_INSTALL.L_key, FILIAL, MESTO, kabn, NET_NAME FROM SOFT_INSTALL, kompy WHERE SOFT_INSTALL.Id_Comp=kompy.ID " &
                         "and SOFT_INSTALL.Soft='" & frmReports.tmp_mesta & "' order by SOFT_INSTALL.VERS, FILIAL, MESTO, kabn, NET_NAME"

                Else

                    If frmReports.cmbReport2Department.Text = langIni.GetString("frmReports", "MSG1", "Все") Then

                        sSQL =
                            "SELECT SOFT_INSTALL.VERS, SOFT_INSTALL.L_key, FILIAL, MESTO, kabn, NET_NAME FROM SOFT_INSTALL, kompy WHERE SOFT_INSTALL.Id_Comp=kompy.ID " &
                            "and FILIAL='" & frmReports.cmbReport2fil.Text & "' " &
                            "and SOFT_INSTALL.Soft='" & frmReports.tmp_mesta & "' order by SOFT_INSTALL.VERS, FILIAL, MESTO, kabn, NET_NAME"

                    Else

                        sSQL =
                            "SELECT SOFT_INSTALL.VERS, SOFT_INSTALL.L_key, FILIAL, MESTO, kabn, NET_NAME FROM SOFT_INSTALL, kompy WHERE SOFT_INSTALL.Id_Comp=kompy.ID " &
                            "and FILIAL='" & frmReports.cmbReport2fil.Text & "' " &
                            "and MESTO='" & frmReports.cmbReport2Department.Text & "' " &
                            "and SOFT_INSTALL.Soft='" & frmReports.tmp_mesta & "' order by SOFT_INSTALL.VERS, FILIAL, MESTO, kabn, NET_NAME"

                    End If

                End If

        End Select

        Dim intj As Integer = 0

        'On Error Resume Next
        Dim rs As Recordset
        rs = New Recordset
        rs.Open(sSQL, DB7, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic)
        If InStr(rs.Source, "VERS") > 0 Then
            Me.lvReport2Cl.Columns.Add("Версия", 100, HorizontalAlignment.Left)
        End If
        If InStr(rs.Source, "L_key") > 0 Then
            Me.lvReport2Cl.Columns.Add("Лиценз. ключ", 300, HorizontalAlignment.Left)
        End If
        Me.lvReport2Cl.Columns.Add("Филиал", 100, HorizontalAlignment.Left)
        Me.lvReport2Cl.Columns.Add("Отдел", 100, HorizontalAlignment.Left)
        Me.lvReport2Cl.Columns.Add("Кабинет", 100, HorizontalAlignment.Left)
        Me.lvReport2Cl.Columns.Add("Устройство", 150, HorizontalAlignment.Left)
        With rs
            .MoveFirst()
            Do While Not .EOF

                If InStr(.Source, "VERS") > 0 Then
                    If InStr(.Source, "L_key") > 0 Then
                        If IsDBNull(.Fields(0).Value) Then
                            Me.lvReport2Cl.Items.Add("")
                            Me.lvReport2Cl.Items(intj).SubItems.Add(.Fields(1).Value)
                            Me.lvReport2Cl.Items(intj).SubItems.Add(.Fields(2).Value)
                            Me.lvReport2Cl.Items(intj).SubItems.Add(.Fields(3).Value)
                            Me.lvReport2Cl.Items(intj).SubItems.Add(.Fields(4).Value)
                            Me.lvReport2Cl.Items(intj).SubItems.Add(.Fields(5).Value)
                        Else
                            Me.lvReport2Cl.Items.Add(Trim(.Fields(0).Value))
                            Me.lvReport2Cl.Items(intj).SubItems.Add(.Fields(1).Value)
                            Me.lvReport2Cl.Items(intj).SubItems.Add(.Fields(2).Value)
                            Me.lvReport2Cl.Items(intj).SubItems.Add(.Fields(3).Value)
                            Me.lvReport2Cl.Items(intj).SubItems.Add(.Fields(4).Value)
                            Me.lvReport2Cl.Items(intj).SubItems.Add(.Fields(5).Value)
                        End If
                    Else
                        If IsDBNull(.Fields(0).Value) Then
                            Me.lvReport2Cl.Items.Add("")
                            Me.lvReport2Cl.Items(intj).SubItems.Add(.Fields(1).Value)
                            Me.lvReport2Cl.Items(intj).SubItems.Add(.Fields(2).Value)
                            Me.lvReport2Cl.Items(intj).SubItems.Add(.Fields(3).Value)
                            Me.lvReport2Cl.Items(intj).SubItems.Add(.Fields(4).Value)
                        Else
                            Me.lvReport2Cl.Items.Add(Trim(.Fields(0).Value))
                            Me.lvReport2Cl.Items(intj).SubItems.Add(.Fields(1).Value)
                            Me.lvReport2Cl.Items(intj).SubItems.Add(.Fields(2).Value)
                            Me.lvReport2Cl.Items(intj).SubItems.Add(.Fields(3).Value)
                            Me.lvReport2Cl.Items(intj).SubItems.Add(.Fields(4).Value)
                        End If
                    End If
                    intj = intj + 1
                ElseIf Not IsDBNull(.Fields(0).Value) Then
                    If Len(.Fields(0).Value) > 0 Then
                        Me.lvReport2Cl.Items.Add(.Fields(0).Value)
                        Me.lvReport2Cl.Items(intj).SubItems.Add(.Fields(1).Value)
                        Me.lvReport2Cl.Items(intj).SubItems.Add(.Fields(2).Value)
                        Me.lvReport2Cl.Items(intj).SubItems.Add(.Fields(3).Value)
                        intj = intj + 1
                    Else
                    End If

                End If

                .MoveNext()
            Loop
        End With
        rs.Close()
        rs = Nothing


        ResList(Me.lvReport2Cl)

        Exit Sub
Error_:
        'MsgBox(Err.Description)
    End Sub

    Public Sub New()

        ' Этот вызов является обязательным для конструктора.
        InitializeComponent()

        ' Добавьте все инициализирующие действия после вызова InitializeComponent().

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.Close()
    End Sub
End Class