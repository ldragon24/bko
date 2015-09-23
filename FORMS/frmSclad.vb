Public Class frmSclad
    Public scCOUNT As Integer
    Public cf1 As String
    Public nam1 As String
    Public otd1 As String
    Public pol1 As String
    Public MOD1 As String
    Public MOD2 As String
    Public KOL As String

    Private Sub frmSclad_Activated(ByVal sender As Object, ByVal e As EventArgs) Handles Me.Activated

        frmMain.SaveInfTehButton.Enabled = False
        frmMain.ToolStripDropDownButton1.Enabled = False
    End Sub

    Private Sub frmSclad_Load(ByVal sender As Object, ByVal e As EventArgs) Handles Me.Load

        SendFonts(Me)


        Call frmSclad_Lang()

        Call Load_SCLAD3()
    End Sub

    Public Sub Load_SCLAD3()
        Dim rs As Recordset 'Объявляем рекордсет
        Dim sSQL As String 'Переменная, где будет размещён SQL запрос
        Dim iCount As Decimal = 0

        sSQL = "SELECT count(*) as t_n FROM Sclad"
        rs = New Recordset
        rs.Open(sSQL, DB7, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic)

        With rs

            iCount = .Fields("T_n").Value

        End With
        rs.Close()
        rs = Nothing

        If iCount = 0 Then Exit Sub

        sSQL =
            "SELECT number, ComplectName, Kolvo, Ostalos, Firma, DaysAndTimes, Prim, Chet, Garant, Cena, NumberTreb, Platejka, NDS, Otdel FROM Sclad"
        rs = New Recordset
        rs.Open(sSQL, DB7, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic)

        Dim intCount As Decimal = 0
        lvSclad.Items.Clear()

        With rs

            .MoveFirst()
            Do While Not .EOF
                lvSclad.Items.Add(.Fields("number").Value) 'col no. 1

                If Not IsDBNull(.Fields("ComplectName").Value) Then
                    lvSclad.Items(CInt(intCount)).SubItems.Add(.Fields("ComplectName").Value)
                Else
                    lvSclad.Items(CInt(intCount)).SubItems.Add("")
                End If

                If Not IsDBNull(.Fields("Kolvo").Value) Then
                    lvSclad.Items(CInt(intCount)).SubItems.Add(.Fields("Kolvo").Value)
                Else
                    lvSclad.Items(CInt(intCount)).SubItems.Add("")
                End If

                If Not IsDBNull(.Fields("Ostalos").Value) Then
                    lvSclad.Items(CInt(intCount)).SubItems.Add(.Fields("Ostalos").Value)
                Else
                    lvSclad.Items(CInt(intCount)).SubItems.Add("")
                End If

                If Not IsDBNull(.Fields("Firma").Value) Then
                    lvSclad.Items(CInt(intCount)).SubItems.Add(.Fields("Firma").Value)
                Else
                    lvSclad.Items(CInt(intCount)).SubItems.Add("")
                End If

                If Not IsDBNull(.Fields("DaysAndTimes").Value) Then
                    lvSclad.Items(CInt(intCount)).SubItems.Add(.Fields("DaysAndTimes").Value)
                Else
                    lvSclad.Items(CInt(intCount)).SubItems.Add("")
                End If

                If Not IsDBNull(.Fields("Prim").Value) Then
                    lvSclad.Items(CInt(intCount)).SubItems.Add(.Fields("Prim").Value)
                Else
                    lvSclad.Items(CInt(intCount)).SubItems.Add("")
                End If

                If Not IsDBNull(.Fields("Chet").Value) Then
                    lvSclad.Items(CInt(intCount)).SubItems.Add(.Fields("Chet").Value)
                Else
                    lvSclad.Items(CInt(intCount)).SubItems.Add("")
                End If

                If Not IsDBNull(.Fields("Garant").Value) Then
                    lvSclad.Items(CInt(intCount)).SubItems.Add(.Fields("Garant").Value)
                Else
                    lvSclad.Items(CInt(intCount)).SubItems.Add("")
                End If

                If Not IsDBNull(.Fields("Cena").Value) Then
                    lvSclad.Items(CInt(intCount)).SubItems.Add(.Fields("Cena").Value)
                Else
                    lvSclad.Items(CInt(intCount)).SubItems.Add("")
                End If

                If Not IsDBNull(.Fields("NumberTreb").Value) Then
                    lvSclad.Items(CInt(intCount)).SubItems.Add(.Fields("NumberTreb").Value)
                Else
                    lvSclad.Items(CInt(intCount)).SubItems.Add("")
                End If

                If Not IsDBNull(.Fields("Platejka").Value) Then
                    lvSclad.Items(CInt(intCount)).SubItems.Add(.Fields("Platejka").Value)
                Else
                    lvSclad.Items(CInt(intCount)).SubItems.Add("")
                End If

                If Not IsDBNull(.Fields("NDS").Value) Then
                    lvSclad.Items(CInt(intCount)).SubItems.Add(.Fields("NDS").Value)
                Else
                    lvSclad.Items(CInt(intCount)).SubItems.Add("")
                End If

                If Not IsDBNull(.Fields("Otdel").Value) Then
                    lvSclad.Items(CInt(intCount)).SubItems.Add(.Fields("Otdel").Value)
                Else
                    lvSclad.Items(CInt(intCount)).SubItems.Add("")
                End If


                intCount = intCount + 1
                .MoveNext()
            Loop
        End With

        rs.Close()
        rs = Nothing

        ResList(Me.lvSclad)
    End Sub

    Private Sub btnAdd_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnAdd.Click

        frmSclad_ADD.EDTR = False


        frmSclad_ADD.nazvan.Text = ""
        frmSclad_ADD.kol.Text = ""
        frmSclad_ADD.ost.Text = ""
        frmSclad_ADD.postavshik.Text = ""
        frmSclad_ADD.poluch.Value = Date.Today
        frmSclad_ADD.prim.Text = ""
        frmSclad_ADD.price.Text = ""
        frmSclad_ADD.garant.Value = Date.Today
        frmSclad_ADD.cena_nds.Text = ""
        frmSclad_ADD.nomer_treb.Text = ""
        frmSclad_ADD.nomer_plat.Text = ""
        frmSclad_ADD.cena_free.Text = ""
        frmSclad_ADD.v_otdel.Text = ""

        frmSclad_ADD.ShowDialog(Me)
    End Sub

    Private Sub lvSclad_Click(ByVal sender As Object, ByVal e As EventArgs) Handles lvSclad.Click
        Dim z As Integer
        For z = 0 To lvSclad.SelectedItems.Count - 1
            scCOUNT = (lvSclad.SelectedItems(z).Text)
        Next
    End Sub

    Private Sub lvSclad_DoubleClick(ByVal sender As Object, ByVal e As EventArgs) Handles lvSclad.DoubleClick


        Dim z As Integer

        For z = 0 To lvSclad.SelectedItems.Count - 1
            scCOUNT = (lvSclad.SelectedItems(z).Text)
        Next
        frmSclad_ADD.EDTR = True
        Dim rs As Recordset

        rs = New Recordset
        rs.Open("SELECT * FROM Sclad WHERE number=" & scCOUNT, DB7, CursorTypeEnum.adOpenDynamic,
                LockTypeEnum.adLockOptimistic)


        frmSclad_ADD.nazvan.Text = ""
        frmSclad_ADD.kol.Text = ""
        frmSclad_ADD.ost.Text = ""
        frmSclad_ADD.postavshik.Text = ""
        frmSclad_ADD.poluch.Value = Date.Today
        frmSclad_ADD.prim.Text = ""
        frmSclad_ADD.price.Text = ""
        frmSclad_ADD.garant.Value = Date.Today
        frmSclad_ADD.cena_nds.Text = ""
        frmSclad_ADD.nomer_treb.Text = ""
        frmSclad_ADD.nomer_plat.Text = ""
        frmSclad_ADD.cena_free.Text = ""
        frmSclad_ADD.v_otdel.Text = ""

        frmSclad_ADD.EDTR = True

        With rs
            frmSclad_ADD.nazvan.Text = .Fields("ComplectName").Value
            frmSclad_ADD.kol.Text = .Fields("Kolvo").Value
            frmSclad_ADD.ost.Text = .Fields("Ostalos").Value
            frmSclad_ADD.postavshik.Text = .Fields("Firma").Value
            frmSclad_ADD.poluch.Value = .Fields("DaysAndTimes").Value
            frmSclad_ADD.prim.Text = .Fields("Prim").Value
            frmSclad_ADD.price.Text = .Fields("Chet").Value
            frmSclad_ADD.garant.Value = .Fields("Garant").Value
            frmSclad_ADD.cena_nds.Text = .Fields("Cena").Value
            frmSclad_ADD.nomer_treb.Text = .Fields("NumberTreb").Value
            frmSclad_ADD.nomer_plat.Text = .Fields("Platejka").Value
            frmSclad_ADD.cena_free.Text = .Fields("NDS").Value
            frmSclad_ADD.v_otdel.Text = .Fields("Otdel").Value
            'frmSclad_ADD.lblNumber.Caption = .Fields("number").Value

            scCOUNT = .Fields("number").Value
        End With
        rs.Close()
        rs = Nothing

        frmSclad_ADD.ShowDialog(Me)
    End Sub

    Private Sub lvSclad_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) _
        Handles lvSclad.SelectedIndexChanged
    End Sub

    Private Sub btnTREB_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnTREB.Click
        cf1 = ""
        nam1 = ""
        otd1 = ""
        pol1 = ""
        MOD1 = ""
        MOD2 = ""
        KOL = ""
        Dim z As Integer
        For z = 0 To lvSclad.SelectedItems.Count - 1
            scCOUNT = (lvSclad.SelectedItems(z).Text)
        Next
        cf1 = lvSclad.Items.Item(lvSclad.FocusedItem.Index).SubItems(12).Text
        nam1 = lvSclad.Items.Item(lvSclad.FocusedItem.Index).SubItems(1).Text
        otd1 = lvSclad.Items.Item(lvSclad.FocusedItem.Index).SubItems(13).Text
        'pol1 = lvSclad.Items.Item(lvSclad.FocusedItem.Index).SubItems(1).Text
        MOD1 = lvSclad.Items.Item(lvSclad.FocusedItem.Index).SubItems(1).Text
        MOD2 = lvSclad.Items.Item(lvSclad.FocusedItem.Index).SubItems(6).Text
        KOL = lvSclad.Items.Item(lvSclad.FocusedItem.Index).SubItems(3).Text

        frmSclad_treb.txtNom.Text = ""
        frmSclad_treb.Combo3.Text = ""
        frmSclad_treb.cmbLich.Text = ""
        frmSclad_treb.cmbLich2.Text = ""
        frmSclad_treb.txtkol.Text = ""
        frmSclad_treb.Combo2.Text = ""

        frmSclad_treb.ShowDialog(Me)
    End Sub

    Private Sub btnOffice_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnOffice.Click


        Select sOfficePACK

            Case "OpenOffice.org"

                ExportListViewToCalc(lvSclad, Me.Text)

            Case Else

                ExportListViewToExcel(lvSclad, Me.Text)


        End Select
    End Sub

    Private Sub btnDel_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnDel.Click
        On Error GoTo err_
        If lvSclad.Items.Count = 0 Then Exit Sub

        'Dim z As Integer

        'For z = 0 To lvSclad.SelectedItems.Count - 1
        '    scCOUNT = (lvSclad.SelectedItems(z).Text)
        'Next

        Dim rs1 As Recordset
        rs1 = New Recordset

        rs1.Open("Delete FROM Sclad WHERE number=" & scCOUNT, DB7, CursorTypeEnum.adOpenDynamic,
                 LockTypeEnum.adLockOptimistic)

        rs1 = Nothing

        Call Load_SCLAD3()

        Exit Sub
        err_:
        MsgBox(Err.Description)
    End Sub
End Class

