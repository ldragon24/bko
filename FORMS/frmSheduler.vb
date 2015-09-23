Public Class frmSheduler
    Private uCOUNT As Integer

    Private Sub frmSheduler_Activated(ByVal sender As Object, ByVal e As EventArgs) Handles Me.Activated
        frmMain.SaveInfTehButton.Enabled = False
        frmMain.ToolStripDropDownButton1.Enabled = False
    End Sub

    Private Sub frmSheduler_Load(ByVal sender As Object, ByVal e As EventArgs) Handles Me.Load

        SendFonts(Me)

        Call frmSheduler_LANG()

        Call SHEDULER_LOAD()


        If uLevelTehAdd = False And uLevel <> "Admin" Then
            btnAdd.Enabled = False
            btnDel.Enabled = False

        Else

            btnAdd.Enabled = True
            btnDel.Enabled = True

        End If


        FillComboNET(cmbUser, "Name", "T_User", "", False, True)
        DTSHED.Value = Date.Today.AddDays(+ 1)
        txtShed.Text = ""
        cmbUser.Text = ""
    End Sub

    Private Sub frmSheduler_Resize(ByVal sender As Object, ByVal e As EventArgs) Handles Me.Resize


        'lstShed.Width = Me.Width - 10
        'lstShed.Height = Me.Height - 200
    End Sub

    Private Sub btnClear_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnClear.Click
        Call CLR()
    End Sub

    Private Sub CLR()
        Dim LNGIniFile As New IniFile(sLANGPATH)

        DTSHED.Value = Date.Today.AddDays(+ 1)
        txtShed.Text = ""
        cmbUser.Text = ""
        btnAdd.Text = LNGIniFile.GetString("frmSheduler", "MSG1", "Добавить")
    End Sub

    Private Sub SHEDULER_LOAD()
        On Error GoTo Error_

        Dim rs As Recordset 'Объявляем рекордсет
        Dim sSQL As String 'Переменная, где будет размещён SQL запрос

        lstShed.Items.Clear()
        sSQL = "SELECT id, D_T, OPIS, foruser FROM Sheduler ORDER BY D_T DESC"

        rs = New Recordset
        rs.Open(sSQL, DB7, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic)

        'UserNames
        Dim intj As Long
        intj = 0

        With rs
            .MoveFirst()
            Do While Not .EOF

                If _
                    .Fields(1).Value <= Date.Today.AddDays(-2) Or
                    .Fields(1).Value >= Date.Today.AddDays(+2) And .Fields(3).Value <> UserNames Then

                Else

                    If .Fields(3).Value = UserNames Then

                        lstShed.Items.Add(.Fields(0).Value) 'col no. 1

                        If Not IsDBNull(.Fields(1).Value) Then
                            lstShed.Items(CInt(intj)).SubItems.Add(.Fields(1).Value)
                        Else
                            lstShed.Items(CInt(intj)).SubItems.Add("")
                        End If

                        If Not IsDBNull(.Fields(2).Value) Then
                            lstShed.Items(CInt(intj)).SubItems.Add(.Fields(2).Value)
                        Else
                            lstShed.Items(CInt(intj)).SubItems.Add("")
                        End If

                        If Not IsDBNull(.Fields(3).Value) Then
                            lstShed.Items(CInt(intj)).SubItems.Add(.Fields(3).Value)
                        Else
                            lstShed.Items(CInt(intj)).SubItems.Add("")
                        End If

                        intj = intj + 1
                    End If
                End If

                .MoveNext()
            Loop
        End With
        rs.Close()
        rs = Nothing

        ResList(Me.lstShed)

        Exit Sub
Error_:
    End Sub

    Private Sub btnAll_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnAll.Click
        On Error GoTo Error_

        Dim rs As Recordset 'Объявляем рекордсет
        Dim sSQL As String 'Переменная, где будет размещён SQL запрос

        lstShed.Items.Clear()
        sSQL = "SELECT id, D_T, OPIS, foruser FROM Sheduler ORDER BY D_T DESC"

        rs = New Recordset
        rs.Open(sSQL, DB7, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic)

        'UserNames
        Dim intj As Long
        intj = 0

        With rs
            .MoveFirst()
            Do While Not .EOF

                lstShed.Items.Add(.Fields(0).Value) 'col no. 1

                If Not IsDBNull(.Fields(1).Value) Then
                    lstShed.Items(CInt(intj)).SubItems.Add(.Fields(1).Value)
                Else
                    lstShed.Items(CInt(intj)).SubItems.Add("")
                End If

                If Not IsDBNull(.Fields(2).Value) Then
                    lstShed.Items(CInt(intj)).SubItems.Add(.Fields(2).Value)
                Else
                    lstShed.Items(CInt(intj)).SubItems.Add("")
                End If

                If Not IsDBNull(.Fields(3).Value) Then
                    lstShed.Items(CInt(intj)).SubItems.Add(.Fields(3).Value)
                Else
                    lstShed.Items(CInt(intj)).SubItems.Add("")
                End If

                intj = intj + 1

                .MoveNext()
            Loop
        End With
        rs.Close()
        rs = Nothing

        ResList(Me.lstShed)

        Exit Sub
Error_:
    End Sub

    Private Sub lstShed_DoubleClick(ByVal sender As Object, ByVal e As EventArgs) Handles lstShed.DoubleClick
        If lstShed.Items.Count = 0 Then Exit Sub

        Dim z As Integer

        For z = 0 To lstShed.SelectedItems.Count - 1
            uCOUNT = (lstShed.SelectedItems(z).Text)
        Next

        Dim rs As Recordset
        rs = New Recordset

        rs.Open("SELECT * FROM Sheduler WHERE id=" & uCOUNT, DB7, CursorTypeEnum.adOpenDynamic,
                LockTypeEnum.adLockOptimistic)

        With rs

            If Not IsDBNull(.Fields("D_T").Value) Then DTSHED.Value = .Fields("D_T").Value
            If Not IsDBNull(.Fields("OPIS").Value) Then txtShed.Text = .Fields("OPIS").Value
            If Not IsDBNull(.Fields("foruser").Value) Then cmbUser.Text = .Fields("foruser").Value

            'If Not IsDBNull(.Fields("fromuser").Value) Then txtUserEmailPwd.Text = .Fields("fromuser").Value


        End With
        rs.Close()
        rs = Nothing
        Dim LNGIniFile As New IniFile(sLANGPATH)
        btnAdd.Text = LNGIniFile.GetString("frmSheduler", "MSG2", "Сохранить")
    End Sub

    Private Sub lstShed_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) _
        Handles lstShed.SelectedIndexChanged
    End Sub

    Private Sub btnAdd_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnAdd.Click
        On Error GoTo Error_
        Dim rs As Recordset 'Объявляем рекордсет
        Dim sSQL As String 'Переменная, где будет размещён SQL запрос

        Dim LNGIniFile As New IniFile(sLANGPATH)


        If btnAdd.Text = LNGIniFile.GetString("frmSheduler", "MSG2", "Сохранить") Then

            sSQL = "SELECT * FROM Sheduler WHERE id = " & Me.uCOUNT
        Else
            sSQL = "SELECT * FROM Sheduler"

        End If

        rs = New Recordset
        rs.Open(sSQL, DB7, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic)

        With rs
            If btnAdd.Text = LNGIniFile.GetString("frmSheduler", "MSG2", "Сохранить") Then
                '.Edit
            Else
                .AddNew()
            End If

            .Fields("D_T").Value = DTSHED.Value
            .Fields("OPIS").Value = txtShed.Text
            .Fields("foruser").Value = cmbUser.Text
            .Fields("FROMuser").Value = uSERID

            .Update()
        End With

        rs.Close()
        rs = Nothing


        Call CLR()
        Call SHEDULER_LOAD()
        Call SHED_CHECK()

        Exit Sub
Error_:
    End Sub

    Private Sub btnDel_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnDel.Click
        If lstShed.Items.Count = 0 Then Exit Sub

        Dim z As Integer

        For z = 0 To lstShed.SelectedItems.Count - 1
            uCOUNT = (lstShed.SelectedItems(z).Text)
        Next

        Dim rs As Recordset
        rs = New Recordset

        rs.Open("Delete FROM Sheduler WHERE id=" & uCOUNT, DB7, CursorTypeEnum.adOpenDynamic,
                LockTypeEnum.adLockOptimistic)
        rs = Nothing


        Call CLR()
        Call SHEDULER_LOAD()
        Call SHED_CHECK()
    End Sub
End Class