Public Class frmACT_OS_Act_treb
    Public EDTR As Boolean
    Public EDTRs As Long

    Private Sub akt_add_Click(ByVal sender As Object, ByVal e As EventArgs) Handles akt_add.Click
        On Error GoTo Error_


        Dim rs As Recordset

        If EDTR = True Then
            rs = New Recordset
            rs.Open("SELECT * FROM ActOS WHERE nomer ='" & EDTRs & "'", DB7, CursorTypeEnum.adOpenDynamic,
                    LockTypeEnum.adLockOptimistic)
        Else
            rs = New Recordset
            rs.Open("SELECT * FROM ActOS", DB7, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic)
        End If


        With rs
            If EDTR = True Then

            Else
                .AddNew()
            End If
            .Fields("Nomer").Value = txt_akt_nomer.Text
            .Fields("dataSost").Value = txt_akt_data_sostav.Value
            .Fields("computer").Value = frmComputers.sCOUNT
            .Fields("tiporgtex").Value = txt_akt_tip.Text
            .Fields("cena").Value = txt_akt_cena.Text
            .Fields("NomerPrikaza").Value = txt_akt_nomer_prikaza.Text
            .Fields("dataprikaza").Value = txt_akt_data_prikaza.Value
            .Fields("postavshik").Value = txt_akt_postavshik.Text
            .Fields("godVipuska").Value = txt_akt_god_vipuska.Text
            .Fields("datasost").Value = txt_akt_data_sostav.Value
            .Fields("modTexn").Value = txt_akt_mod.Text

            If Len(frmComputers.cmbBranch.Text) = 0 Then

            Else
                .Fields("Filial").Value = frmComputers.cmbBranch.Text
            End If

            If Len(frmComputers.cmbDepartment.Text) = 0 Then

            Else
                .Fields("otdel").Value = frmComputers.cmbDepartment.Text
            End If
            .Update()
        End With

        rs.Close()
        rs = Nothing

        Call frmAct_Treb.ACTVV_LOAD()


        Me.Close()
        Exit Sub
        Error_:


        Select Case Err.Number
            Case 3021 'ignore, no entries in list
                Resume Next
            Case Else

                MsgBox(Err.Description, MsgBoxStyle.Information, ProGramName)

        End Select
        Me.Close()
    End Sub

    Private Sub frmACT_OS_Act_treb_Load(ByVal sender As Object, ByVal e As EventArgs) Handles Me.Load

        SendFonts(Me)

        FillComboNET(Me.txt_akt_tip, "Name", "SPR_Complect", "", False, True)
        FillComboNET(Me.txt_akt_postavshik, "Name", "SPR_Postav", "", False, True)

        Call LANG_frmACT_OS_Act_treb()
    End Sub

    Private Sub akt_cancel_Click(ByVal sender As Object, ByVal e As EventArgs) Handles akt_cancel.Click
        Me.Close()
    End Sub
End Class