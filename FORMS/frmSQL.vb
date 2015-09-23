Public Class frmSQL
    Private m_SortingColumn As ColumnHeader

    Private Sub frmSQL_Activated(ByVal sender As Object, ByVal e As EventArgs) Handles Me.Activated
        frmMain.SaveInfTehButton.Enabled = False
        frmMain.ToolStripDropDownButton1.Enabled = False
    End Sub

    Private Sub frmSQL_Load(ByVal sender As Object, ByVal e As EventArgs) Handles Me.Load
        SendFonts(Me)
        Call LANG_frmSQL()

        Dim oRS As Recordset

        oRS = DB7.OpenSchema(SchemaEnum.adSchemaTables, New Object() {Nothing, Nothing, Nothing, "TABLE"})


        If Not (oRS.EOF) Then
            Do Until oRS.EOF
                If UCase(oRS.Fields.Item("TABLE_TYPE").Value) = "TABLE" Then
                    lstTable.Items.Add(oRS.Fields.Item("TABLE_NAME").Value)
                End If
                oRS.MoveNext()
            Loop
        End If

        oRS.Close()
        oRS = Nothing

        FillComboNET(cmbSaveQ, "Name", "T_Que", "", False, True)
        'cmbSaveQ
    End Sub

    Private Sub cmbSaveQ_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) _
        Handles cmbSaveQ.SelectedIndexChanged
        On Error GoTo Error_
        Dim rs As Recordset 'Объявляем рекордсет
        Dim sSQL As String 'Переменная, где будет размещён SQL запрос

        sSQL = "SELECT * FROM T_Que where name='" & cmbSaveQ.Text & "'"

        rs = New Recordset
        rs.Open(sSQL, DB7, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic)


        With rs

            txtQ.Text = .Fields("sqlsq").Value

        End With


        rs.Close()
        rs = Nothing


        Exit Sub
        Error_:
    End Sub

    Private Sub LOAD_Q()
        On Error GoTo Err_

        Me.Cursor = Cursors.WaitCursor

        Dim sSQL As String 'Переменная, где будет размещён SQL запрос
        Dim rs As Recordset 'Объявляем рекордсет
        Dim arrAnimals(), uname As String
        Dim iCounter As Integer


        sSQL = txtQ.Text

        arrAnimals = Split(txtQ.Text, " ")
        For iCounter = LBound(arrAnimals) To UBound(arrAnimals)
            If iCounter <> 2 Then
            Else
                uname = arrAnimals(0)
                'unam1 = Left(arrAnimals(0), uname)
            End If
        Next
        Dim UpperCase, LowerCase
        UpperCase = uname
        LowerCase = UCase(UpperCase)
        uname = LowerCase

        Dim LNGIniFile As New IniFile(sLANGPATH)


        If uname = "DELETE" Then
            If _
                MsgBox(
                    LNGIniFile.GetString("frmSQL", "MSG1", "Данный запрос приведет к удалению информации продолжить?"),
                    vbExclamation + vbYesNo, "Запрос на удаление") = vbNo Then Exit Sub
            rs = New Recordset
            rs.Open(sSQL, DB7, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic)
            rs = Nothing
            Me.Cursor = Cursors.Default
            Exit Sub
        Else
            rs = New Recordset
            rs.Open(sSQL, DB7, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic)

        End If


        Dim lngCounter As Integer

        Dim FirstColumn As Boolean

        LvQ.Items.Clear()
        LvQ.Columns.Clear()


        'POPULATE HEADERS
        For lngCounter = 0 To rs.Fields.Count - 1
            LvQ.Columns.Add(rs.Fields(lngCounter).Name, 100, HorizontalAlignment.Left)
        Next

        'PREALLOCATE MEMORY FOR ROWS

        Do Until rs.EOF
            FirstColumn = True      'FIRST COLUMN IS A LISTITEM, REST ARE LISTSUBITEMS


            If DB_N <> "MS Access" Then uname = 2 Else uname = 1

            For lngCounter = 0 To rs.Fields.Count - uname

                If FirstColumn Then
                    If Not IsDBNull(rs.Fields(lngCounter).Value) Then
                        LvQ.Items.Add(rs.Fields(lngCounter).Value).ToString()
                    Else
                        LvQ.Items.Add("")  'NULL FIELDS NEED A BLANK ITEM
                    End If                  'TO KEEP DATA FROM SHIFTING LEFT
                    FirstColumn = False
                Else
                    If Not IsDBNull(rs.Fields(lngCounter).Value) Then
                        LvQ.Items(LvQ.Items.Count - 1).SubItems.Add(rs.Fields(lngCounter).Value).ToString()
                    Else
                        LvQ.Items(LvQ.Items.Count - 1).SubItems.Add("")
                    End If
                End If
            Next

            'If Not IsMissing(Owner) Then Owner.pbrProgress.Value = (rs.AbsolutePosition / rs.RecordCount) * 100

            rs.MoveNext()
        Loop

        rs.Close()
        rs = Nothing

        ResList(Me.LvQ)
        Me.Cursor = Cursors.Default

        Exit Sub
        Err_:
        Me.Cursor = Cursors.Default
        MsgBox(Err.Description)
    End Sub


    Private Sub lstTable_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) _
        Handles lstTable.SelectedIndexChanged
        txtQ.Text = "SELECT * FROM " & lstTable.Text

        'Call LOAD_Q()
        Me.Invoke(New MethodInvoker(AddressOf LOAD_Q))
    End Sub

    Private Sub btnClear_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnClear.Click
        txtQ.Text = ""
    End Sub

    Private Sub btnResSend_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnResSend.Click
        On Error GoTo Err_

        If LvQ.Items.Count = 0 Then Exit Sub


        Select Case sOfficePACK

            Case "OpenOffice.org"

                ExportListViewToCalc(LvQ, Me.Text)

            Case Else

                ExportListViewToExcel(LvQ, Me.Text)


        End Select


        Exit Sub
        Err_:
        MsgBox("Error " & Err.Number & " " & Err.Description)
    End Sub

    Private Sub btnSave_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnSave.Click
        On Error GoTo Error_
        Dim strTmp As String
        Dim sTmp As String

        'Dim T_Que As Recordset
        'T_Que = New Recordset
        'T_Que.Open("SELECT * FROM T_Que", DB7, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic)

        If Len(txtQ.Text) = 0 Then Exit Sub

        Dim LNGIniFile As New IniFile(sLANGPATH)

        If Not (RSExists("T_Que", "sqlsq", Me.txtQ.Text)) Then

            Dim Message, Title, Default1 As String
            Message = LNGIniFile.GetString("frmSQL", "MSG2", "Укажите Название для запроса")
            Title = LNGIniFile.GetString("frmSQL", "MSG3", "Запрос")
            Default1 = LNGIniFile.GetString("frmSQL", "MSG3", "Запрос") & " " & Date.Today
            strTmp = InputBox(Message, Title, Default1)
            If Len(strTmp) = 0 Then Exit Sub

            Dim sSQL As String
 'esq *********
            If Not RSExists("T_Que", "Name", strTmp) Then
                sSQL = "INSERT INTO T_Que (name,sqlsq) VALUES ('" & strTmp & "',""" & txtQ.Text & """)"
            Else
                sSQL = "UPDATE T_Que SET sqlsq=""" & txtQ.Text & """ WHERE Name='" & strTmp & "'"
            End If
            DB7.Execute(sSQL)
            'esq *********

            'With T_Que
            '    .AddNew()
            '    .Fields("name").Value = strTmp
            '    .Fields("sqlsq").Value = txtQ.Text
            '    .Update()
            'End With

            FillComboNET(Me.cmbSaveQ, "name", "T_Que", "", False, False)

        End If


        'T_Que.Close()
        'T_Que = Nothing
        Exit Sub
        Error_:
    End Sub

    Private Sub btnExecute_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnExecute.Click
        'Call LOAD_Q()
        LvQ.Sorting = SortOrder.None
        LvQ.ListViewItemSorter = Nothing
        LvQ.Items.Clear()
        Me.Invoke(New MethodInvoker(AddressOf LOAD_Q))
    End Sub

    Private Sub btnDelete_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnDelete.Click

        If Len(cmbSaveQ.Text) = 0 Then Exit Sub

        Dim T_Que As Recordset
        T_Que = New Recordset
        T_Que.Open("DELETE FROM T_Que Where name ='" & cmbSaveQ.Text & "'", DB7, CursorTypeEnum.adOpenDynamic,
                   LockTypeEnum.adLockOptimistic)
        T_Que = Nothing
        cmbSaveQ.Text = ""
        FillComboNET(Me.cmbSaveQ, "name", "T_Que", "", False, False)
    End Sub

    Private Sub LvQ_ColumnClick(ByVal sender As Object, ByVal e As ColumnClickEventArgs) Handles LvQ.ColumnClick

        SORTING_LV(LvQ, e)

    End Sub

    Private Sub LvQ_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles LvQ.SelectedIndexChanged
    End Sub
End Class