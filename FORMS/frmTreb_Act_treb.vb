﻿Public Class frmTreb_Act_treb
    Public EDTR As Boolean
    Public sIDTR As Long


    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAdd.Click
        On Error GoTo Error_



        Dim rs As ADODB.Recordset
        rs = New ADODB.Recordset

        If Me.EDTR = True Then

            rs.Open("SELECT * FROM TrebOvanie WHERE id =" & sIDTR, DB7, ADODB.CursorTypeEnum.adOpenDynamic, ADODB.LockTypeEnum.adLockOptimistic)
        Else

            rs.Open("SELECT * FROM TrebOvanie", DB7, ADODB.CursorTypeEnum.adOpenDynamic, ADODB.LockTypeEnum.adLockOptimistic)
        End If


        With rs
            If EDTR = True Then

            Else
                .AddNew()
            End If

            .Fields("Nomer").Value = txtNomer.Text
            .Fields("dataSost").Value = txtDate.Value
            .Fields("otdel").Value = frmComputers.cmbDepartment.Text
            .Fields("computer").Value = frmComputers.sCOUNT
            .Fields("cherezkogo").Value = cmbLich.Text
            .Fields("zatreboval").Value = cmbLich2.Text
            .Fields("tiporgtex").Value = cmbTip.Text
            .Fields("cena").Value = txtPrice.Text
            .Fields("kolich").Value = txtCokVo.Text
            .Fields("model").Value = txtNodel.Text

            .Fields("Filial").Value = frmComputers.cmbBranch.Text

            .Update()
        End With
        rs.Close()
        rs = Nothing

        Call frmAct_Treb.TREB_LOAD()


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

    Private Sub frmTreb_Act_treb_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        Call LANG_frmTreb_Act_treb()

        FillComboNET(Me.cmbLich2, "Name", "SPR_OTV", "", False, True)
        FillComboNET(Me.cmbLich, "Name", "SPR_OTV", "", False, True)
        FillComboNET(Me.cmbTip, "Name", "SPR_Complect", "", False, True)


    End Sub
End Class