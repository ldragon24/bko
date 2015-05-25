Public Class frmDev
    Public cID As Integer
    Public cEDT As Boolean = False
    Public sTIPtehn As String

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        cEDT = False
        Me.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        If Len(ComboBox1.Text) = 0 Then Exit Sub

        Dim rs As Recordset
        Dim sSQL As String

        rs = New Recordset


        If cEDT = True Then

            sSQL = "Select * FROM TBL_DEV_OID WHERE Device='" & sTIPtehn & "' AND Model ='" & ComboBox1.Text & "'"

        Else

            sSQL = "Select * FROM TBL_DEV_OID"

        End If


        rs.Open("Select * FROM TBL_DEV_OID WHERE Device='" & sTIPtehn & "' AND Model ='" & ComboBox1.Text & "'", DB7,
                CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic)

        With rs
            If cEDT = False Then
                .AddNew()
            End If

            .Fields("SER_NUM_OID").Value = TextBox6.Text
            .Fields("TIME_BATTERY_OID").Value = TextBox7.Text
            .Fields("ZARIAD_BATTARY_OID").Value = TextBox8.Text
            .Fields("SOST_BATTARY_OID").Value = TextBox9.Text
            .Fields("ZAMENA_BATTARY_OID").Value = TextBox10.Text
            .Fields("UPTIME_OID").Value = TextBox11.Text
            .Fields("MAC_OID").Value = TextBox12.Text
            .Fields("IN_TOK_OID").Value = TextBox13.Text
            .Fields("OUT_TOK_OID").Value = TextBox14.Text
            .Fields("OUTPUT_LOAD_OID").Value = TextBox20.Text
            .Fields("OUTPUT_STATUS_OID").Value = TextBox16.Text
            .Fields("SELFTEST_OID").Value = TextBox17.Text
            .Fields("TEMPERATURE_OID").Value = TextBox19.Text
            .Fields("TEMPERATURE2_OID").Value = TextBox20.Text
            .Fields("SELFTEST_DAY_OID").Value = TextBox21.Text

            .Fields("Model").Value = ComboBox1.Text
            .Fields("Device").Value = sTIPtehn


            .Update()
        End With

        rs.Close()
        rs = Nothing


        '################################
        'Очищаем текстовые поля
        '################################

        TextBox6.Text = ""
        TextBox7.Text = ""
        TextBox8.Text = ""
        TextBox9.Text = ""
        TextBox10.Text = ""
        TextBox11.Text = ""
        TextBox12.Text = ""
        TextBox13.Text = ""
        TextBox14.Text = ""
        TextBox16.Text = ""
        TextBox17.Text = ""
        TextBox18.Text = ""
        TextBox19.Text = ""
        TextBox20.Text = ""
        TextBox21.Text = ""

        Me.Close()
    End Sub

    Private Sub frmDev_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        cEDT = False

        TextBox6.Text = ""
        TextBox7.Text = ""
        TextBox8.Text = ""
        TextBox9.Text = ""
        TextBox10.Text = ""
        TextBox11.Text = ""
        TextBox12.Text = ""
        TextBox13.Text = ""
        TextBox14.Text = ""
        TextBox16.Text = ""
        TextBox17.Text = ""
        TextBox18.Text = ""
        TextBox19.Text = ""
        TextBox20.Text = ""
    End Sub

    Private Sub frmDev_Load(sender As Object, e As EventArgs) Handles Me.Load

        Label20.Text = "Температура"
        Label13.Text = "В работе (UpTime)"
        Label18.Text = "Статус (Сеть\Батарея)"

        Label8.Visible = True
        Label9.Visible = True
        Label10.Visible = True
        Label11.Visible = True
        Label12.Visible = True
        Label15.Visible = True
        Label16.Visible = True
        Label18.Visible = True
        Label19.Visible = True
        Label21.Visible = True
        Label22.Visible = True
        Label23.Visible = True
        TextBox6.Visible = True
        TextBox7.Visible = True
        TextBox8.Visible = True
        TextBox9.Visible = True
        TextBox10.Visible = True
        TextBox13.Visible = True
        TextBox14.Visible = True
        TextBox16.Visible = True
        TextBox17.Visible = True
        TextBox19.Visible = True
        TextBox20.Visible = True
        TextBox21.Visible = True


        Dim rs As Recordset
        rs = New Recordset
        rs.Open("Select Model FROM TBL_DEV_OID WHERE Device='" & sTIPtehn & "'", DB7, CursorTypeEnum.adOpenDynamic,
                LockTypeEnum.adLockOptimistic)

        With rs
            .MoveFirst()
            Do While Not .EOF

                If Not IsDBNull(.Fields("Model").Value) Then ComboBox1.Items.Add(.Fields("Model").Value)

                .MoveNext()
            Loop
        End With

        rs.Close()
        rs = Nothing
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        On Error GoTo err_

        Dim rs As Recordset
        rs = New Recordset
        rs.Open("Select * FROM TBL_DEV_OID WHERE Device='" & sTIPtehn & "' AND Model ='" & ComboBox1.Text & "'", DB7,
                CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic)

        With rs

            TextBox6.Text = .Fields("SER_NUM_OID").Value
            TextBox7.Text = .Fields("TIME_BATTERY_OID").Value
            TextBox8.Text = .Fields("ZARIAD_BATTARY_OID").Value
            TextBox9.Text = .Fields("SOST_BATTARY_OID").Value
            TextBox10.Text = .Fields("ZAMENA_BATTARY_OID").Value
            TextBox11.Text = .Fields("UPTIME_OID").Value
            TextBox12.Text = .Fields("MAC_OID").Value
            TextBox13.Text = .Fields("IN_TOK_OID").Value
            TextBox14.Text = .Fields("OUT_TOK_OID").Value
            TextBox20.Text = .Fields("OUTPUT_LOAD_OID").Value
            TextBox16.Text = .Fields("OUTPUT_STATUS_OID").Value
            TextBox17.Text = .Fields("SELFTEST_OID").Value
            TextBox19.Text = .Fields("TEMPERATURE_OID").Value
            TextBox20.Text = .Fields("TEMPERATURE2_OID").Value
            TextBox21.Text = .Fields("SELFTEST_DAY_OID").Value

        End With

        rs.Close()
        rs = Nothing

        Exit Sub
        err_:
    End Sub
End Class