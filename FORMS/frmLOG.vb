Friend Class frmLOG
    Private LOGLOAD As Decimal
    Private m_SortingColumn As ColumnHeader

    Private Sub RadioButton1_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles RBPrLog.CheckedChanged

        LOGLOAD = 0

        If RBPrLog.Checked = True Then
            Call PROGRAMLOG_LOAD()

        End If
    End Sub

    Private Sub PROGRAMLOG_LOAD()
        On Error GoTo Err_
        Me.Cursor = Cursors.WaitCursor
        Dim objIniFile As New IniFile(sLANGPATH)


        Dim strDate As String

        lvLOG.Columns.Clear()
        lvLOG.Items.Clear()
        lvLOG.Columns.Add(objIniFile.GetString("frmLOG", "MSG1", "id"), 1, HorizontalAlignment.Left)
        lvLOG.Columns.Add(objIniFile.GetString("frmLOG", "MSG2", "Пользователь"), 130, HorizontalAlignment.Left)
        lvLOG.Columns.Add(objIniFile.GetString("frmLOG", "MSG3", "Деятельность"), 400, HorizontalAlignment.Left)
        lvLOG.Columns.Add(objIniFile.GetString("frmLOG", "MSG4", "Дата"), 70, HorizontalAlignment.Left)
        lvLOG.Columns.Add(objIniFile.GetString("frmLOG", "MSG5", "Время"), 70, HorizontalAlignment.Left)


        Dim a, b, c As String
        a = DTLOG.Value.Day

        b = DTLOG.Value.Month

        If Len(b) = 1 Then b = "0" & b

        c = DTLOG.Value.Year

        strDate = c & "-" & b & "-" & a


        Dim ZUG As Decimal = 0
        Dim rscount As Recordset 'Объявляем рекордсет
        rscount = New Recordset

        rscount.Open("SELECT COUNT(*) AS total_number FROM T_Log", DB7, CursorTypeEnum.adOpenDynamic,
                     LockTypeEnum.adLockOptimistic)

        With rscount
            ZUG = .Fields("total_number").Value
        End With

        rscount.Close()
        rscount = Nothing

        Dim sSQl As String


        ' sSQl = "SELECT * FROM T_Log WHERE DATE_FORMAT(DATE,'%yyyy-%mm-%dd') AS data='" & strDate & "'" 'WHERE (DATE=CONVERT(DATETIME, '" & DaSTE & "', 104))"
        sSQl = "SELECT * FROM T_Log"


        '"SELECT id, user_ID, Activity, D_T_FORMAT(data,'%Y-%m-%d') AS out_data, T_M FROM T_Log ORDER BY out_data DESC LIMIT 1" 


        If ZUG > 0 Then

            Dim rs As Recordset
            rs = New Recordset
            rs.Open(sSQl, DB7, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic)

            Dim intCount As Decimal = 0
            With rs
                .MoveFirst()
                Do While Not .EOF
                    ''My.Application.DoEvents()

                    If DTLOG.Value <= .Fields("D_T").Value And DTLOG1.Value >= .Fields("D_T").Value Then

                        lvLOG.Items.Add(.Fields("id").Value) 'col no. 1

                        If Not IsDBNull(.Fields("user_ID").Value) Then
                            lvLOG.Items(CInt(intCount)).SubItems.Add(.Fields("user_ID").Value)
                        Else
                            lvLOG.Items(CInt(intCount)).SubItems.Add("")
                        End If

                        If Not IsDBNull(.Fields("Activity").Value) Then
                            lvLOG.Items(CInt(intCount)).SubItems.Add(.Fields("Activity").Value)
                        Else
                            lvLOG.Items(CInt(intCount)).SubItems.Add("")
                        End If

                        If Not IsDBNull(.Fields("D_T").Value) Then
                            lvLOG.Items(CInt(intCount)).SubItems.Add(.Fields("D_T").Value)
                        Else
                            lvLOG.Items(CInt(intCount)).SubItems.Add("")
                        End If

                        If Not IsDBNull(.Fields("T_M").Value) Then
                            lvLOG.Items(CInt(intCount)).SubItems.Add(.Fields("T_M").Value)
                        Else
                            lvLOG.Items(CInt(intCount)).SubItems.Add("")
                        End If


                        intCount = intCount + 1
                    Else
                    End If

                    .MoveNext()
                    'DoEvents

                Loop

            End With

            rs.Close()
            rs = Nothing

        End If

        Me.Cursor = Cursors.Default

        ResList(Me.lvLOG)

        Exit Sub
Err_:

        MsgBox(Err.Description)

        Me.Cursor = Cursors.Default
    End Sub

    Private Sub MOVE_LOG()
        On Error GoTo Err_
        Me.Cursor = Cursors.WaitCursor
        Dim objIniFile As New IniFile(sLANGPATH)


        lvLOG.Columns.Clear()
        lvLOG.Items.Clear()
        lvLOG.Columns.Add(objIniFile.GetString("frmLOG", "MSG1", "id"), 1, HorizontalAlignment.Left)
        lvLOG.Columns.Add(objIniFile.GetString("frmLOG", "MSG6", "Техника"), 200, HorizontalAlignment.Left)
        lvLOG.Columns.Add(objIniFile.GetString("frmLOG", "MSG7", "От куда"), 150, HorizontalAlignment.Left)
        lvLOG.Columns.Add(objIniFile.GetString("frmLOG", "MSG8", "Куда"), 150, HorizontalAlignment.Left)
        lvLOG.Columns.Add(objIniFile.GetString("frmLOG", "MSG9", "Причина"), 300, HorizontalAlignment.Left)
        lvLOG.Columns.Add(objIniFile.GetString("frmLOG", "MSG10", "Дата"), 70, HorizontalAlignment.Left)
        lvLOG.Columns.Add(objIniFile.GetString("frmLOG", "MSG11", "Время"), 70, HorizontalAlignment.Left)


        Dim ZUG As Decimal = 0
        Dim rscount As Recordset 'Объявляем рекордсет
        rscount = New Recordset

        rscount.Open("SELECT COUNT(*) AS total_number FROM dvig", DB7, CursorTypeEnum.adOpenDynamic,
                     LockTypeEnum.adLockOptimistic)

        With rscount
            ZUG = .Fields("total_number").Value
        End With

        rscount.Close()
        rscount = Nothing

        Dim sSQl As String


        sSQl = "SELECT * FROM dvig"


        If ZUG > 0 Then

            Dim rs2 As Recordset
            Dim Namr
            Dim rs As Recordset
            rs = New Recordset
            rs.Open(sSQl, DB7, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic)

            Dim intCount As Decimal = 0
            With rs
                .MoveFirst()
                Do While Not .EOF


                    If DTLOG.Value <= .Fields("D_T").Value And DTLOG1.Value >= .Fields("D_T").Value Then

                        lvLOG.Items.Add(.Fields("id").Value) 'col no. 1

                        rs2 = New Recordset
                        rs2.Open("SELECT id, NET_name FROM kompy WHERE id = " & .Fields("Id_Comp").Value, DB7,
                                 CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic)
                        With rs2

                            If Not IsDBNull(.Fields("NET_name").Value) Then Namr = .Fields("NET_name").Value

                        End With
                        rs2.Close()
                        rs2 = Nothing

                        lvLOG.Items(CInt(intCount)).SubItems.Add(Namr)


                        If Not IsDBNull(.Fields("oldMesto").Value) Then
                            lvLOG.Items(CInt(intCount)).SubItems.Add(.Fields("oldMesto").Value)
                        Else
                            lvLOG.Items(CInt(intCount)).SubItems.Add("")
                        End If

                        If Not IsDBNull(.Fields("NewMesto").Value) Then
                            lvLOG.Items(CInt(intCount)).SubItems.Add(.Fields("NewMesto").Value)
                        Else
                            lvLOG.Items(CInt(intCount)).SubItems.Add("")
                        End If

                        If Not IsDBNull(.Fields("Prich").Value) Then
                            lvLOG.Items(CInt(intCount)).SubItems.Add(.Fields("Prich").Value)
                        Else
                            lvLOG.Items(CInt(intCount)).SubItems.Add("")
                        End If

                        If Not IsDBNull(.Fields("D_T").Value) Then
                            lvLOG.Items(CInt(intCount)).SubItems.Add(.Fields("D_T").Value)
                        Else
                            lvLOG.Items(CInt(intCount)).SubItems.Add("")
                        End If

                        If Not IsDBNull(.Fields("T_M").Value) Then
                            lvLOG.Items(CInt(intCount)).SubItems.Add(.Fields("T_M").Value)
                        Else
                            lvLOG.Items(CInt(intCount)).SubItems.Add("")
                        End If

                        intCount = intCount + 1
                    Else
                    End If

                    .MoveNext()
                    'DoEvents

                Loop

            End With

            rs.Close()
            rs = Nothing

        End If

        Me.Cursor = Cursors.Default

        ResList(Me.lvLOG)

        Exit Sub
Err_:

        MsgBox(Err.Description)

        Me.Cursor = Cursors.Default
    End Sub

    Private Sub rbMove_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles rbMove.CheckedChanged

        LOGLOAD = 1

        If rbMove.Checked = True Then
            Call MOVE_LOG()
        End If
    End Sub

    Private Sub rbUpdate_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles rbUpdate.CheckedChanged
        LOGLOAD = 2
        Me.Cursor = Cursors.WaitCursor

        lvLOG.Columns.Clear()
        lvLOG.Items.Clear()

        If rbUpdate.Checked = True Then
            Call IZM_LOG()
        End If

        Me.Cursor = Cursors.Default
    End Sub

    Private Sub frmLOG_Activated(ByVal sender As Object, ByVal e As EventArgs) Handles Me.Activated
        frmMain.SaveInfTehButton.Enabled = False
        frmMain.ToolStripDropDownButton1.Enabled = False
    End Sub

    Private Sub frmLOG_Load(ByVal sender As Object, ByVal e As EventArgs) Handles Me.Load

        SendFonts(Me)

        Call LANG_frmLOG()


        DTLOG.Value = Date.Today.AddDays(-1)
        DTLOG1.Value = Date.Today
    End Sub

    Private Sub frmLOG_Resize(ByVal sender As Object, ByVal e As EventArgs) Handles Me.Resize
        lvLOG.Width = Me.Width - 15
        lvLOG.Height = Me.Height - 110
    End Sub

    Private Sub IZM_LOG()
        On Error GoTo Err_
        Me.Cursor = Cursors.WaitCursor
        Dim objIniFile As New IniFile(sLANGPATH)

        lvLOG.Columns.Clear()
        lvLOG.Items.Clear()
        lvLOG.Columns.Add(objIniFile.GetString("frmLOG", "MSG1", "id"), 1, HorizontalAlignment.Left)
        lvLOG.Columns.Add(objIniFile.GetString("frmLOG", "MSG12", "Компьютер"), 200, HorizontalAlignment.Left)
        lvLOG.Columns.Add(objIniFile.GetString("frmLOG", "MSG13", "Старая комплектующая"), 150, HorizontalAlignment.Left)
        lvLOG.Columns.Add(objIniFile.GetString("frmLOG", "MSG14", "Новая комплектующая"), 150, HorizontalAlignment.Left)
        lvLOG.Columns.Add(objIniFile.GetString("frmLOG", "MSG15", "Дата"), 300, HorizontalAlignment.Left)
        lvLOG.Columns.Add(objIniFile.GetString("frmLOG", "MSG16", "Время"), 70, HorizontalAlignment.Left)


        Dim ZUG As Decimal = 0
        Dim rscount As Recordset 'Объявляем рекордсет
        rscount = New Recordset

        rscount.Open("SELECT COUNT(*) AS total_number FROM Update_Log", DB7, CursorTypeEnum.adOpenDynamic,
                     LockTypeEnum.adLockOptimistic)

        With rscount
            ZUG = .Fields("total_number").Value
        End With

        rscount.Close()
        rscount = Nothing

        Dim sSQl As String


        sSQl = "SELECT * FROM Update_Log"


        If ZUG > 0 Then

            Dim rs2 As Recordset
            Dim Namr
            Dim rs As Recordset
            rs = New Recordset
            rs.Open(sSQl, DB7, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic)

            Dim intCount As Decimal = 0
            With rs
                .MoveFirst()
                Do While Not .EOF

                    If DTLOG.Value <= .Fields("D_T").Value And DTLOG1.Value >= .Fields("D_T").Value Then


                        lvLOG.Items.Add(.Fields("id").Value) 'col no. 1

                        rs2 = New Recordset
                        rs2.Open("SELECT id, NET_name FROM kompy WHERE id = " & .Fields("Id_Comp").Value, DB7,
                                 CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic)
                        With rs2

                            If Not IsDBNull(.Fields("NET_name").Value) Then Namr = .Fields("NET_name").Value

                        End With
                        rs2.Close()
                        rs2 = Nothing

                        lvLOG.Items(CInt(intCount)).SubItems.Add(Namr)


                        If Not IsDBNull(.Fields("Komcl_old").Value) Then
                            lvLOG.Items(CInt(intCount)).SubItems.Add(.Fields("Komcl_old").Value)
                        Else
                            lvLOG.Items(CInt(intCount)).SubItems.Add("")
                        End If

                        If Not IsDBNull(.Fields("Kompl_new").Value) Then
                            lvLOG.Items(CInt(intCount)).SubItems.Add(.Fields("Kompl_new").Value)
                        Else
                            lvLOG.Items(CInt(intCount)).SubItems.Add("")
                        End If

                        If Not IsDBNull(.Fields("D_T").Value) Then
                            lvLOG.Items(CInt(intCount)).SubItems.Add(.Fields("D_T").Value)
                        Else
                            lvLOG.Items(CInt(intCount)).SubItems.Add("")
                        End If

                        If Not IsDBNull(.Fields("T_M").Value) Then
                            lvLOG.Items(CInt(intCount)).SubItems.Add(.Fields("T_M").Value)
                        Else
                            lvLOG.Items(CInt(intCount)).SubItems.Add("")
                        End If

                        intCount = intCount + 1
                    Else
                    End If

                    .MoveNext()
                    'DoEvents

                Loop

            End With

            rs.Close()
            rs = Nothing

        End If

        Me.Cursor = Cursors.Default

        ResList(Me.lvLOG)

        Exit Sub
Err_:

        MsgBox(Err.Description)

        Me.Cursor = Cursors.Default
    End Sub

    Private Sub btnUpdate_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnUpdate.Click

        Select Case LOGLOAD

            Case 0

                Call PROGRAMLOG_LOAD()

            Case 1

                Call MOVE_LOG()

            Case 2

                Call IZM_LOG()

        End Select
    End Sub

    Private Sub lvLOG_ColumnClick(ByVal sender As Object, ByVal e As ColumnClickEventArgs) Handles lvLOG.ColumnClick

        SORTING_LV(lvLOG, e)

    End Sub

    Private Sub lvLOG_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) _
        Handles lvLOG.SelectedIndexChanged
    End Sub
End Class