Public Class frmCartr_ADD
    Public EDTRCART As Boolean
    Public EDTIDTr As Decimal
    Public CRTFU As Boolean

    Private Sub frmCartr_ADD_Load(ByVal sender As Object, ByVal e As EventArgs) Handles Me.Load

        SendFonts(Me)


        FillComboNET(Me.cmbProizv, "PROIZV", "SPR_PROIZV", "", False, True)
        FillComboNET(Me.cmbSaler, "Name", "SPR_Postav", "", False, True)
        FillComboNET(Me.cmbModC, "name", "spr_cart", "", False, True)

        Call LANG_frmCartr_ADD()

        Dim objIniFile As New IniFile(sLANGPATH)

        cmbTipC.Items.Clear()
        cmbTipC.Items.Add(objIniFile.GetString("frmCartr_ADD", "MSG1", "Струйный"))
        cmbTipC.Items.Add(objIniFile.GetString("frmCartr_ADD", "MSG2", "Матричный"))
        cmbTipC.Items.Add(objIniFile.GetString("frmCartr_ADD", "MSG3", "Лазерный"))
        cmbTipC.Items.Add(objIniFile.GetString("frmCartr_ADD", "MSG4", "Барабан"))
        cmbTipC.Items.Add(objIniFile.GetString("frmCartr_ADD", "MSG5", "Термо Пленка"))
        cmbTipC.Items.Add(objIniFile.GetString("frmCartr_ADD", "MSG6", "Фотокондуктор"))

        'dtSale.Value = Date.Today


        If EDTRCART = True Then

            Label6.Enabled = True
            cmbSostUstr.Enabled = True

        Else

            Label6.Enabled = False
            cmbSostUstr.Enabled = False

        End If


        Dim sSQL As String
        Dim Counter As Decimal
        Dim rs As Recordset
        sSQL = "SELECT COUNT(*) AS total_number FROM kompy"
        rs = New Recordset
        rs.Open(sSQL, DB7, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic)

        With rs
            Counter = .Fields("total_number").Value
        End With
        rs.Close()
        rs = Nothing


        If Counter > 0 Then
            cmbSostUstr.Items.Clear()
            rs = New Recordset
            rs.Open("SELECT TipTehn,PRINTER_NAME_1,filial,mesto,id FROM kompy", DB7, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic)

            With rs
                .MoveFirst()
                Do While Not .EOF
                    If _
                        .Fields("TipTehn").Value = "Printer" Or .Fields("TipTehn").Value = "KOpir" Or
                        .Fields("TipTehn").Value = "MFU" Then
                        cmbSostUstr.Items.Add(
                            .Fields("PRINTER_NAME_1").Value & " (" & .Fields("filial").Value & "/" &
                            .Fields("mesto").Value & ")" & " № " & .Fields("id").Value)
                    Else
                    End If
                    .MoveNext()
                    'DoEvents
                Loop
            End With
            rs.Close()
            rs = Nothing

        End If


        'If Not IsDBNull(.Fields("os")) Then frmComputers.cmbModCartr.Text = .Fields("os").Value
        If EDTRCART = False Then

            rs = New Recordset
            rs.Open("SELECT os FROM kompy where id=" & frmCRT3.cCOUNT, DB7, CursorTypeEnum.adOpenDynamic,
                    LockTypeEnum.adLockOptimistic)

            With rs

                cmbModC.Text = .Fields("os").Value

            End With
            rs.Close()
            rs = Nothing

        End If


        Exit Sub
    End Sub

    Private Sub btnAdd_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnAdd.Click

        Dim uname As String
        Dim uname2 As String
        Dim uname3 As String
        Dim uname4 As String

        uname = cmbProizv.Text

        If Not (RSExists("PROYZV", "PROiZV", cmbProizv.Text)) Then
            AddPr(cmbProizv.Text)
        End If

        If Not (RSExists("Postav", "name", cmbSaler.Text)) Then
            AddOnePar(cmbSaler.Text, "NAME", "SPR_Postav", cmbSaler)
        End If

        If Not (RSExists("CARTR", "name", cmbModC.Text)) Then

            AddTreePar(cmbModC.Text, cmbTipC.Text, cmbProizv.Text, "spr_cart", cmbModC)

        End If

        Dim PROYZV As Recordset
        PROYZV = New Recordset
        PROYZV.Open("SELECT * FROM SPR_PROIZV WHERE Proizv='" & uname & "'", DB7, CursorTypeEnum.adOpenDynamic,
                    LockTypeEnum.adLockOptimistic)

        With PROYZV
            uname = .Fields("Id").Value
        End With
        PROYZV.Close()
        PROYZV = Nothing

        uname2 = cmbModC.Text

        If Not (RSExists("CARTR", "name", cmbModC.Text)) Then
            'AddCARTR(Combo2.Text, Combo4.Text, Combo3.Text)
        End If

        Dim CARTR As Recordset
        CARTR = New Recordset
        CARTR.Open("SELECT * FROM spr_cart WHERE name='" & uname2 & "'", DB7, CursorTypeEnum.adOpenDynamic,
                   LockTypeEnum.adLockOptimistic)

        With CARTR
            uname2 = .Fields("id").Value
        End With
        CARTR.Close()
        CARTR = Nothing


        If EDTRCART = True Then

            uname3 = cmbSostUstr.Text

            Dim BASECOMP As Recordset
            BASECOMP = New Recordset
            BASECOMP.Open("SELECT PRINTER_NAME_1,filial,mesto,id FROM kompy", DB7, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic)
            With BASECOMP

                If Len(cmbSostUstr.Text) = 0 Then
                    uname3 = 0
                Else
                    .MoveFirst()
                    Do While Not .EOF
                        If _
                            uname3 =
                            .Fields("PRINTER_NAME_1").Value & " (" & .Fields("filial").Value & "/" &
                            .Fields("mesto").Value & ")" & " № " & .Fields("id").Value Then
                            uname3 = .Fields("id").Value
                        End If
                        .MoveNext()
                        'DoEvents
                    Loop

                End If
            End With
            BASECOMP.Close()
            BASECOMP = Nothing


        Else

            uname3 = frmCRT3.cCOUNT

        End If


        uname4 = cmbSaler.Text


        If Len(cmbSaler.Text) = 0 Then

            uname4 = 0

        Else

            If Not (RSExists("Postav", "name", cmbSaler.Text)) Then
                ' AddPost(cmbSaler.Text)
            End If

            Dim Postav As Recordset
            Postav = New Recordset
            Postav.Open("SELECT * FROM SPR_Postav WHERE Name='" & uname4 & "'", DB7, CursorTypeEnum.adOpenDynamic,
                        LockTypeEnum.adLockOptimistic)

            With Postav
                uname4 = .Fields("id").Value
            End With
            Postav.Close()
            Postav = Nothing

        End If


        Dim sSQL As String
        If EDTRCART = True Then
            sSQL = "SELECT * FROM CARTRIDG WHERE id = " & EDTIDTr
        Else

            sSQL = "SELECT * FROM CARTRIDG"

        End If

        Dim rs1 As Recordset
        rs1 = New Recordset
        rs1.Open(sSQL, DB7, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic)

        If Len(txtSerNumb.Text) = 0 Then txtSerNumb.Text = "Б\Н"
        If Len(txtSaleNumb.Text) = 0 Then txtSaleNumb.Text = 0
        If Len(txtCashe.Text) = 0 Then txtCashe.Text = 0

        With rs1
            If EDTRCART = True Then
            Else
                .AddNew()
            End If

            .Fields("SN").Value = txtSerNumb.Text
            .Fields("Proizv").Value = uname
            .Fields("TIP").Value = cmbTipC.Text
            .Fields("Model").Value = uname2
            .Fields("USTR").Value = uname3
            .Fields("PROD").Value = uname4
            .Fields("SCHET").Value = txtSaleNumb.Text
            .Fields("Cena").Value = txtCashe.Text
            .Fields("D_T").Value = dtSale.Value
            .Fields("NZap").Value = chkNezap.Checked
            .Fields("NeZap").Value = chkNZ.Checked
            .Fields("Iznos").Value = chkIznos.Checked
            .Fields("Spisan").Value = chkSPS.Checked
            .Fields("NaSpisanie").Value = chkNaSP.Checked
            .Fields("PRIM").Value = txtMemo.Text
            .Fields("PREF").Value = 0

            .Update()
        End With

        rs1.Close()
        rs1 = Nothing


        If CRTFU = True Then

            Call LOAD_CRT(frmComputers.sCOUNT)

        Else

            'Call frmCRT3.Load_C(frmCRT3.cCOUNT)

        End If

        Dim objIniFile As New IniFile(sLANGPATH)
        Me.btnAdd.Text = objIniFile.GetString("frmCartr_ADD", "btnAdd", "Добавить")
        CRTFU = False
        Me.Close()

        Exit Sub
    End Sub

    Private Sub cmbSostUstr_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) _
        Handles cmbSostUstr.SelectedIndexChanged
    End Sub

    Private Sub cmbModC_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) _
        Handles cmbModC.SelectedIndexChanged

        On Error Resume Next
        Dim rs As Recordset
        Dim sSQL As String
        Dim uNI As String
        rs = New Recordset


        sSQL = "SELECT * FROM spr_cart WHERE Name = '" & cmbModC.Text & "'"

        rs.Open(sSQL, DB7, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic)

        With rs

            If Not IsDBNull(.Fields("proizv").Value) Then uNI = .Fields("proizv").Value

            Dim PROYZV As Recordset
            PROYZV = New Recordset
            PROYZV.Open("SELECT * FROM SPR_PROIZV WHERE iD=" & uNI, DB7, CursorTypeEnum.adOpenDynamic,
                        LockTypeEnum.adLockOptimistic)

            With PROYZV
                cmbProizv.Text = .Fields("proizv").Value
            End With
            PROYZV.Close()
            PROYZV = Nothing

            If Not IsDBNull(.Fields("A").Value) Then cmbTipC.Text = .Fields("A").Value

        End With

        rs.Close()
        rs = Nothing
    End Sub

    Private Sub btnCancel_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub
End Class