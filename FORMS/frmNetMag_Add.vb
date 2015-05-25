Public Class frmNetMag_Add
    Public sEDT As Boolean
    Public sID As Integer = 0

    Public Sub New()
        InitializeComponent()
    End Sub 'New

    Private Sub Button2_Click(ByVal sender As Object, ByVal e As EventArgs) Handles Button2.Click
        Me.Close()
    End Sub

    Private Sub ToolStripButton1_Click(ByVal sender As Object, ByVal e As EventArgs) Handles ToolStripButton1.Click

        frmNetMagazin.sBDO_SVT_Pref = "PC"
        frmNetMag_selectSVT.ShowDialog(Me)
    End Sub

    Private Sub ToolStripButton3_Click(ByVal sender As Object, ByVal e As EventArgs) Handles ToolStripButton3.Click

        frmNetMagazin.sBDO_SVT_Pref = "NET"
        frmNetMag_selectSVT.ShowDialog(Me)
    End Sub

    Private Sub Button1_Click(ByVal sender As Object, ByVal e As EventArgs) Handles Button1.Click

        If Len(txtLineRoz.Text) = 0 Then

            txtLineRoz.Select()
            Beep()
            Exit Sub
        End If


        Dim sSQL As String
        Dim rs As Recordset
        Dim A1, A2, A3, A4 As String


        If frmNetMagazin.sBDO_Pref = "ROOT" And frmNetMagazin.sBDO_SVT_count <> 0 Then

            sSQL = "Select id,filial,mesto,kabn from kompy where id=" & frmNetMagazin.sBDO_SVT_count

            rs = New Recordset
            rs.Open(sSQL, DB7, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic)

            With rs
                A1 = .Fields("filial").Value
                A2 = .Fields("mesto").Value
                A3 = .Fields("kabn").Value
            End With

            rs.Close()
            rs = Nothing

            If Len(A1) <> 0 Then A4 = "G"
            If Len(A2) <> 0 Then A4 = "O"
            If Len(A3) <> 0 Then A4 = "K"

            frmNetMagazin.sBDO_Pref = A4

            Select Case A4

                Case "G"

                    sSQL = "SELECT id, Filial as one_par FROM SPR_FILIAL where filial='" & A1 & "'"

                Case "O"

                    sSQL = "SELECT id, Filial as one_par, N_Otd as two_par FROM SPR_OTD_FILIAL WHERE Filial='" & A1 &
                           "' AND N_Otd='" & A2 & "'"

                Case "K"

                    sSQL = "SELECT id, Name as tree_par, N_F as one_par, N_M as two_par FROM SPR_KAB where N_F='" & A1 &
                           "' AND N_M='" & A2 & "' AND Name='" & A3 & "'"


            End Select

            rs = New Recordset
            rs.Open(sSQL, DB7, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic)


            With rs

                frmNetMagazin.sBDO_count = .Fields("id").Value

            End With

            rs.Close()
            rs = Nothing


        End If


        If sEDT = True Then

            sSQL = "SELECT * FROM TBL_NET_MAG where id=" & sID
        Else
            sSQL = "SELECT * FROM TBL_NET_MAG"

        End If


        rs = New Recordset
        rs.Open(sSQL, DB7, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic)

        Dim uname As String = frmNetMagazin.sBDO_SVT_count
        Dim uname1 As String = frmNetMagazin.sBDO_NET_count


        With rs

            If sEDT = True Then

            Else

                .AddNew()

            End If

            .Fields("id_line").Value = txtLineRoz.Text
            .Fields("tip_cab").Value = cmbTipCab.Text
            .Fields("dlin_cab").Value = txtDlina.Text
            .Fields("tip_cab_line").Value = cmbTipKabLine.Text

            .Fields("SVT").Value = frmNetMagazin.sBDO_SVT_count

            .Fields("NET_PORT_SVT").Value = txtNetPortSVT.Text
            .Fields("PHONE").Value = cmbPhone.Text
            .Fields("SVT_MEMO").Value = txtSVT_MEMO.Text

            .Fields("COMMUTATOR").Value = frmNetMagazin.sBDO_NET_count 'txtKom.Text

            'frmNetMagazin.sBDO_NET_count

            .Fields("NET_PORT_COMMUTATOR").Value = txtPortCom.Text
            .Fields("COMMUTATOR_MEMO").Value = txtComMemo.Text


            .Fields("PREF").Value = frmNetMagazin.sBDO_Pref
            .Fields("sID").Value = frmNetMagazin.sBDO_count


            .Update()
        End With
        rs.Close()
        rs = Nothing

        Call frmNetMagazin.NET_MAG_LOAD()

        Me.Close()
    End Sub

    Private Sub frmNetMag_Add_Load(ByVal sender As Object, ByVal e As EventArgs) Handles Me.Load


        SendFonts(Me)


        'btnSearch.Image = New System.Drawing.Bitmap(PrPath & "pic\iface\search.png")
        ToolStripButton1.Image = New Bitmap(PrPath & "pic\iface\add.png")
        ToolStripButton2.Image = New Bitmap(PrPath & "pic\iface\remove.png")

        ToolStripButton3.Image = New Bitmap(PrPath & "pic\iface\add.png")
        ToolStripButton4.Image = New Bitmap(PrPath & "pic\iface\remove.png")


        Call frmNetMag_Add_LANG()

        If sEDT = False Then
            frmNetMagazin.sBDO_NET_count = 0
            frmNetMagazin.sBDO_SVT_count = 0

            Me.txtLineRoz.Text = ""
            Me.cmbTipCab.Text = ""
            Me.cmbTipKabLine.Text = ""
            Me.txtDlina.Text = 0
            Me.cmbTipKabLine.Text = ""
            Me.txtSVT.Text = ""
            Me.txtNetPortSVT.Text = ""
            Me.cmbPhone.Text = ""
            Me.txtSVT_MEMO.Text = ""
            Me.txtKom.Text = ""
            Me.txtPortCom.Text = ""
            Me.txtComMemo.Text = ""


        End If
    End Sub

    Private Sub ToolStripButton2_Click(ByVal sender As Object, ByVal e As EventArgs) Handles ToolStripButton2.Click
        'frmNetMagazin.sBDO_NET_count = 0
        frmNetMagazin.sBDO_SVT_count = 0
        txtSVT.Text = ""
    End Sub

    Private Sub ToolStripButton4_Click(ByVal sender As Object, ByVal e As EventArgs) Handles ToolStripButton4.Click

        frmNetMagazin.sBDO_NET_count = 0
        'frmNetMagazin.sBDO_SVT_count = 0
        txtKom.Text = ""
    End Sub
End Class