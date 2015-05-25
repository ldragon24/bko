Public Class frmCartr_Add_Zap
    Public EDTRCARTZ As Boolean

    Private Sub frmCartr_Add_Zap_Load(ByVal sender As Object, ByVal e As EventArgs) Handles Me.Load

        SendFonts(Me)

        FillComboNET(Me.cmbPost, "Name", "SPR_Postav", "", False, True)
    End Sub

    Private Sub btnCancel_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub

    Private Sub btnAdd_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnAdd.Click
        Dim objIniFile As New IniFile(sLANGPATH)


        If Len(cmbPost.Text) = 0 Then
            MsgBox(objIniFile.GetString("frmCartr_Add_Zap", "MSG1", "Не выбран сервис центр!"), MsgBoxStyle.Critical,
                   ProGramName)
            cmbPost.Focus()
            Exit Sub
        End If

        If Not (RSExists("Postav", "name", cmbPost.Text)) Then
            AddOnePar(Me.cmbPost.Text, "NAME", "SPR_Postav", Me.cmbPost)
        End If


        Dim uname As String
        uname = cmbPost.Text

        Dim rs As Recordset
        rs = New Recordset
        rs.Open("SELECT * FROM SPR_Postav where Name ='" & cmbPost.Text & "'", DB7, CursorTypeEnum.adOpenDynamic,
                LockTypeEnum.adLockOptimistic)

        With rs
            uname = .Fields("id").Value
        End With
        rs.Close()
        rs = Nothing

        If Len(txtAvR.Text) = 0 Then txtAvR.Text = " "
        If Len(txtCashe.Text) = 0 Then txtCashe.Text = " "

        Dim sSQL As String

        If EDTRCARTZ = False Then

            sSQL = "SELECT * FROM CARTRIDG_Z"

        Else

            sSQL = "SELECT * FROM CARTRIDG_Z where id=" & frmCRT3.zCOUNT

        End If


        rs = New Recordset

        rs.Open(sSQL, DB7, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic)

        With rs
            If EDTRCARTZ = False Then
                .AddNew()
                .Fields("Z_N").Value = frmCRT3.lvCartZAP.Items.Count + 1
                .Fields("ID_C").Value = frmCRT3.rCOUNT
            Else

            End If

            .Fields("SC").Value = uname

            .Fields("AKTVR").Value = txtAvR.Text
            .Fields("DATAAKT").Value = dtAvR.Value
            .Fields("STOIM").Value = txtCashe.Text
            .Fields("DATAZAP").Value = dtDateZ.Value
            .Fields("Paper").Value = txtPage.Text
            .Fields("VOST").Value = chkRef.Checked

            .Update()
        End With
        rs.Close()
        rs = Nothing

        Call frmCRT3.Zap_load(frmCRT3.rCOUNT)
        Me.Close()
    End Sub
End Class