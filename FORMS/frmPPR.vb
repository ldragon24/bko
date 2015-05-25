Public Class frmPPR
    Private Sub frmPPR_Load(sender As Object, e As EventArgs) Handles Me.Load

        cmbYear.Items.Clear()

        Dim z As Integer

        For z = 0 To 10
            cmbYear.Items.Add(Date.Today.Year + z)
        Next
    End Sub

    Private Sub btnOk_Click(sender As Object, e As EventArgs) Handles btnOk.Click

        If Len(cmbKvartal.Text) = 0 Then Exit Sub
        If Len(cmbYear.Text) = 0 Then Exit Sub

        'Код сохранения результатов в таблицу

        'TBL_PPR
        Dim sSQL As String
        Dim rs As Recordset

        Dim sCOUNT As Integer

        sSQL = "SELECT count(*) as t_n FROM TBL_PPR WHERE id_comp=" & frmComputers.sCOUNT & " AND YEAR_TO='" &
               cmbYear.Text & "'" & " AND TIP_TO='" & frmComputers.TIP_TO & "'" & " AND KVARTAL_TO='" & cmbKvartal.Text &
               "'"
        rs = New Recordset
        rs.Open(sSQL, DB7, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic)


        With rs

            sCOUNT = .Fields("t_n").Value

        End With

        rs.Close()
        rs = Nothing

        If sCOUNT > 0 Then

            MsgBox("ТО для данного оборудования уже запланировано на выбранный год - смените год...",
                   MsgBoxStyle.Information, ProGramName)

            Exit Sub

        End If

        sSQL = "INSERT INTO TBL_PPR (ID_COMP,TIP_TO,KVARTAL_TO,YEAR_TO) VALUES (" & frmComputers.sCOUNT & ",'" & frmComputers.TIP_TO & "','" & cmbKvartal.Text & "','" & cmbYear.Text & "')"

        rs = New Recordset
        rs.Open(sSQL, DB7, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic)
        rs = Nothing

        Me.Close()
    End Sub
End Class