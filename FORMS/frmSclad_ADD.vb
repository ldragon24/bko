Public Class frmSclad_ADD
    Public EDTR As Boolean


    Private Sub frmSclad_ADD_Load(ByVal sender As Object, ByVal e As EventArgs) Handles Me.Load

        SendFonts(Me)


        Call LANG_frmSclad_ADD()

        FillComboNET(Me.postavshik, "Name", "SPR_Postav", "", False, True)
        FillComboNET(Me.v_otdel, "filial", "SPR_FILIAL", "", False, True)
        FillComboNET(Me.nazvan, "name", "SPR_Complect", "", False, True)

        If EDTR = False Then
            garant.Value = Date.Today
            poluch.Value = Date.Today

        End If
    End Sub

    Private Sub cancel_Click(ByVal sender As Object, ByVal e As EventArgs) Handles cancel.Click
        Me.Close()
    End Sub

    Private Sub add_Click(ByVal sender As Object, ByVal e As EventArgs) Handles add.Click

        On Error GoTo Error_
        Dim sSQL As String

        If EDTR = True Then
            sSQL = "SELECT * FROM Sclad WHERE number=" & frmSclad.scCOUNT
        Else
            sSQL = "SELECT * FROM Sclad"


        End If

        Dim rs As Recordset
        rs = New Recordset
        rs.Open(sSQL, DB7, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic)

        With rs
            If EDTR = True Then

            Else
                .AddNew()
            End If

            .Fields("Firma").Value = postavshik.Text
            .Fields("ComplectName").Value = nazvan.Text
            .Fields("NumberTreb").Value = nomer_treb.Text
            .Fields("Kolvo").Value = kol.Text
            .Fields("Prim").Value = prim.Text
            .Fields("Chet").Value = price.Text
            .Fields("Garant").Value = garant.Value
            If Len(cena_free.Text) = 0 Then cena_free.Text = "0"
            .Fields("NDS").Value = cena_free.Text
            .Fields("DaysAndTimes").Value = poluch.Value
            .Fields("Platejka").Value = nomer_plat.Text
            .Fields("Cena").Value = cena_nds.Text
            If Len(ost.Text) = 0 Then ost.Text = "0"
            .Fields("Ostalos").Value = ost.Text
            .Fields("Otdel").Value = v_otdel.Text

            .Update()
        End With

        rs.Close()
        rs = Nothing

        Call frmSclad.Load_SCLAD3()

        Me.Close()
        Exit Sub
        Error_:
        MsgBox(Err.Description, MsgBoxStyle.Information, ProGramName)
    End Sub
End Class