Public Class frm_wmi
    Public wmiIP As String
    Public wmiIP2 As String
    Public wmiUser As String
    Public wmiPasword As String
    Public wmiDomen As String


    Private Sub frm_wmi_Load(ByVal sender As Object, ByVal e As EventArgs) Handles Me.Load
        SendFonts(Me)

        Call LANG_frm_wmi()

        Dim sTmp() As String

        sTmp = Split(uUSERNAME, "\")

        If Len(sTmp(0)) = 0 Then sTmp(0) = ""
        If Len(sTmp(1)) = 0 Then sTmp(1) = ""

        wmiIP = uPCNAME
        txtIP.Text = wmiIP
        wmiUser = sTmp(1)
        txtUserName.Text = wmiUser
        wmiPasword = ""
        txtPassword.Text = wmiPasword
        wmiDomen = sTmp(0)
        txtDomen.Text = wmiDomen
    End Sub

    Private Sub Button2_Click(ByVal sender As Object, ByVal e As EventArgs) Handles Button2.Click
        Me.Close()
    End Sub

    Private Sub Button1_Click(ByVal sender As Object, ByVal e As EventArgs) Handles Button1.Click

        On Error GoTo err_
        wmiIP = txtIP.Text
        wmiIP2 = txtIP2.Text
        wmiUser = txtUserName.Text
        wmiPasword = txtPassword.Text
        wmiDomen = txtDomen.Text

       
            Call LOAD_WMI2()
            Me.Close()

            Exit Sub
err_:
    End Sub
End Class