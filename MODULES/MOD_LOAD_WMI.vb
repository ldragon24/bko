Imports System.Management

Module MOD_LOAD_WMI
    Private strComputer As String
    Private Username As String
    Private Password As String
    Private Authority As String

    Dim connection As New ConnectionOptions

    Public Sub LOAD_WMI()

        frm_wmi.ShowDialog(frmMain)

    End Sub

    Public Sub LOAD_WMI2()
        Dim intj As Integer

        Dim sTmp() As String
        Dim sTmp2() As String

        If Len(frm_wmi.wmiIP2) <> 0 Then
            Dim A1, A2 As Integer

            sTmp = Split(frm_wmi.wmiIP, ".")
            A1 = sTmp(3)
            sTmp2 = Split(frm_wmi.wmiIP2, ".")
            A2 = sTmp2(3)


            For intj = A1 To A2

                Call VisibleForm(frmComputers)
                Call ClearForm(frmComputers)
                'frmComputers.selectTECMesto()
                frmComputers.EDT = False
                TipTehn = "PC"

                strComputer = sTmp2(0) & "." & sTmp2(1) & "." & sTmp2(2) & "." & intj

                connection.Username = frm_wmi.wmiUser
                connection.Password = frm_wmi.wmiPasword
                Authority = frm_wmi.wmiDomen
                connection.Authority = "ntlmdomain:" & Authority


                frmComputers.cmbBranch.Text = sBranch
                frmComputers.cmbDepartment.Text = sDepartment
                frmComputers.cmbOffice.Text = sOffice

                If My.Computer.Network.Ping(strComputer) Then

                    Call LOAD_WMI_3()

                    Call frmMain.SaveInfTeh()

                Else

                End If

            Next


        Else

            strComputer = frm_wmi.wmiIP
            connection.Username = frm_wmi.wmiUser
            connection.Password = frm_wmi.wmiPasword
            Authority = frm_wmi.wmiDomen
            connection.Authority = "ntlmdomain:" & Authority

            If My.Computer.Network.Ping(strComputer) Then

                Call LOAD_WMI_3()

            Else

            End If

            frmComputers.cmbBranch.Text = sBranch
            frmComputers.cmbDepartment.Text = sDepartment
            frmComputers.cmbOffice.Text = sOffice

        End If
    End Sub

    Private Sub LOAD_WMI_3()
        On Error GoTo err_
        Dim LNGIniFile As New IniFile(sLANGPATH)


        If Len(strComputer) = 0 Or Len(connection.Username) = 0 Or Len(Authority) = 0 Then
            MsgBox(
                LNGIniFile.GetString("MOD_LOAD_WMI", "MSG1", "Не заполены обязательные поля") & vbCrLf &
                LNGIniFile.GetString("MOD_LOAD_WMI", "MSG2", "Дальнейшая загрузка не возможна"), MsgBoxStyle.Exclamation,
                ProGramName)
            Exit Sub
        End If

        'connection.EnablePrivileges = True

        frmMain.Cursor = Cursors.WaitCursor

        frmComputers.BeginInvoke(New MethodInvoker(AddressOf wSOFT))

        frmComputers.BeginInvoke(New MethodInvoker(AddressOf wCPU))

        frmComputers.BeginInvoke(New MethodInvoker(AddressOf wMB))

        frmComputers.BeginInvoke(New MethodInvoker(AddressOf wRAM))

        frmComputers.BeginInvoke(New MethodInvoker(AddressOf wHDD))

        frmComputers.BeginInvoke(New MethodInvoker(AddressOf wSVGA))

        frmComputers.BeginInvoke(New MethodInvoker(AddressOf wSOUND))

        frmComputers.BeginInvoke(New MethodInvoker(AddressOf wCDROM))

        frmComputers.BeginInvoke(New MethodInvoker(AddressOf wNET))

        frmComputers.BeginInvoke(New MethodInvoker(AddressOf wFDD))

        frmComputers.BeginInvoke(New MethodInvoker(AddressOf wKeyboard))

        frmComputers.BeginInvoke(New MethodInvoker(AddressOf wModem))

        frmComputers.BeginInvoke(New MethodInvoker(AddressOf wMouse))

        frmComputers.BeginInvoke(New MethodInvoker(AddressOf wPRN))

        frmComputers.BeginInvoke(New MethodInvoker(AddressOf wMONITOR))

        frmComputers.BeginInvoke(New MethodInvoker(AddressOf wSYS))

        'If frmComputers.InvokeRequired Then
        '    frmComputers.Invoke(New MethodInvoker(AddressOf wSOFT))
        'Else
        '    Call wSOFT()
        'End If

        'If frmComputers.InvokeRequired Then
        '    frmComputers.Invoke(New MethodInvoker(AddressOf wCPU))
        'Else
        '    Call wCPU()
        'End If

        'If frmComputers.InvokeRequired Then
        '    frmComputers.Invoke(New MethodInvoker(AddressOf wMB))
        'Else
        '    Call wMB()
        'End If

        'If frmComputers.InvokeRequired Then
        '    frmComputers.Invoke(New MethodInvoker(AddressOf wRAM))
        'Else
        '    Call wRAM()
        'End If

        'If frmComputers.InvokeRequired Then
        '    frmComputers.Invoke(New MethodInvoker(AddressOf wHDD))
        'Else
        '    Call wHDD()
        'End If

        'If frmComputers.InvokeRequired Then
        '    frmComputers.Invoke(New MethodInvoker(AddressOf wSVGA))
        'Else
        '    Call wSVGA()
        'End If

        'If frmComputers.InvokeRequired Then
        '    frmComputers.Invoke(New MethodInvoker(AddressOf wSOUND))
        'Else
        '    Call wSOUND()
        'End If

        'If frmComputers.InvokeRequired Then
        '    frmComputers.Invoke(New MethodInvoker(AddressOf wCDROM))
        'Else
        '    Call wCDROM()
        'End If

        'If frmComputers.InvokeRequired Then
        '    frmComputers.Invoke(New MethodInvoker(AddressOf wNET))
        'Else
        '    Call wNET()
        'End If

        'If frmComputers.InvokeRequired Then
        '    frmComputers.Invoke(New MethodInvoker(AddressOf wFDD))
        'Else
        '    Call wFDD()
        'End If

        'If frmComputers.InvokeRequired Then
        '    frmComputers.Invoke(New MethodInvoker(AddressOf wKeyboard))
        'Else
        '    Call wKeyboard()
        'End If

        'If frmComputers.InvokeRequired Then
        '    frmComputers.Invoke(New MethodInvoker(AddressOf wModem))
        'Else
        '    Call wModem()
        'End If

        'If frmComputers.InvokeRequired Then
        '    frmComputers.Invoke(New MethodInvoker(AddressOf wMouse))
        'Else
        '    Call wMouse()
        'End If

        'If frmComputers.InvokeRequired Then
        '    frmComputers.Invoke(New MethodInvoker(AddressOf wPRN))
        'Else
        '    Call wPRN()
        'End If

        'If frmComputers.InvokeRequired Then
        '    frmComputers.Invoke(New MethodInvoker(AddressOf wMONITOR))
        'Else
        '    Call wMONITOR()
        'End If


        'If frmComputers.InvokeRequired Then
        '    frmComputers.Invoke(New MethodInvoker(AddressOf wSYS))
        'Else
        '    Call wSYS()
        'End If


        Application.DoEvents()
        frmMain.Cursor = Cursors.Default

        Exit Sub
        err_:
        frmMain.Cursor = Cursors.Default
    End Sub

    Private Sub wCPU()

        On Error GoTo err_
        '$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$


        Dim scope As New ManagementScope("\\" & strComputer & "\root\CIMV2", connection)
        scope.Connect()

        Dim _
            query As _
                New ObjectQuery("SELECT Name, CurrentClockSpeed, SocketDesignation, Manufacturer FROM Win32_Processor")

        Dim searcher As New ManagementObjectSearcher(scope, query)

        For Each queryObj As ManagementObject In searcher.Get()

            frmComputers.cmbCPU1.Text = queryObj("Name")
            frmComputers.txtMHZ1.Text = queryObj("CurrentClockSpeed") & " Мгц."
            frmComputers.txtSoc1.Text = queryObj("SocketDesignation")
            frmComputers.PROizV1.Text = queryObj("Manufacturer")

        Next

        err_:
    End Sub

    Private Sub wMB()
        On Error GoTo err_

        Dim scope As New ManagementScope("\\" & strComputer & "\root\CIMV2", connection)
        scope.Connect()
        Dim _
            query As _
                New ObjectQuery("SELECT Product, OtherIdentifyingInfo, SerialNumber, Manufacturer FROM Win32_BaseBoard")

        Dim searcher As New ManagementObjectSearcher(scope, query)

        For Each queryObj As ManagementObject In searcher.Get()

            frmComputers.cmbMB.Text = queryObj("Product")
            frmComputers.txtChip.Text = queryObj("OtherIdentifyingInfo")
            frmComputers.txtSN_MB.Text = queryObj("SerialNumber")
            frmComputers.PROizV5.Text = queryObj("Manufacturer")

        Next


        err_:
    End Sub

    Private Sub wRAM()

        On Error GoTo err_

        Dim scope As New ManagementScope("\\" & strComputer & "\root\CIMV2", connection)
        scope.Connect()

        Dim query As New ObjectQuery("SELECT TotalVisibleMemorySize FROM Win32_OperatingSystem")

        Dim searcher As New ManagementObjectSearcher(scope, query)


        For Each queryObj As ManagementObject In searcher.Get()

            frmComputers.cmbRAM1.Text = CLng((queryObj("TotalVisibleMemorySize")/1024)/1024) & " ГБ"
            'frmComputers.txtRamS1.Text = queryObj("CurrentClockSpeed") & " Мгц."
            'frmComputers.txtRamSN1.Text = queryObj("SocketDesignation")
            'frmComputers.PROizV6.Text = queryObj("Manufacturer")

        Next


        err_:
    End Sub

    Private Sub wHDD()

        On Error GoTo err_

        Dim scope As New ManagementScope("\\" & strComputer & "\root\CIMV2", connection)
        scope.Connect()

        Dim query As New ObjectQuery("SELECT Model, size, Manufacturer FROM Win32_DiskDrive")

        Dim searcher As New ManagementObjectSearcher(scope, query)


        'GetObject("winmgmts:\\" & strComputer & "\ROOT\CIMV2")
        Dim intj As Integer = 1
        For Each queryObj As ManagementObject In searcher.Get()

            Select Case intj

                Case 1

                    frmComputers.cmbHDD1.Text = queryObj("Model") ' / 1024) / 1024) & " ГБ"
                    frmComputers.txtHDDo1.Text = CLng(((queryObj("size")/1024)/1024)/1024) & " Гб."
                    'frmComputers.txtHDDsN1.Text = queryObj("SocketDesignation")
                    frmComputers.PROizV10.Text = queryObj("Manufacturer")

                Case 2

                    frmComputers.cmbHDD2.Text = queryObj("Model") ' / 1024) / 1024) & " ГБ"
                    frmComputers.txtHDDo2.Text = CLng(((queryObj("size")/1024)/1024)/1024) & " Гб."
                    'frmComputers.txtHDDsN1.Text = queryObj("SocketDesignation")
                    frmComputers.PROizV11.Text = queryObj("Manufacturer")

                Case 3
                    frmComputers.cmbHDD3.Text = queryObj("Model") ' / 1024) / 1024) & " ГБ"
                    frmComputers.txtHDDo3.Text = CLng(((queryObj("size")/1024)/1024)/1024) & " Гб."
                    'frmComputers.txtHDDsN1.Text = queryObj("SocketDesignation")
                    frmComputers.PROizV12.Text = queryObj("Manufacturer")

                Case 4

                    frmComputers.cmbHDD4.Text = queryObj("Model") ' / 1024) / 1024) & " ГБ"
                    frmComputers.txtHDDo4.Text = CLng(((queryObj("size")/1024)/1024)/1024) & " Гб."
                    'frmComputers.txtHDDsN1.Text = queryObj("SocketDesignation")
                    frmComputers.PROizV13.Text = queryObj("Manufacturer")


            End Select

            intj = intj + 1

        Next

        err_:
    End Sub

    Private Sub wSVGA()

        On Error GoTo err_

        Dim scope As New ManagementScope("\\" & strComputer & "\root\CIMV2", connection)
        scope.Connect()

        Dim query As New ObjectQuery("SELECT Name, AdapterRAM FROM Win32_VideoController")

        Dim searcher As New ManagementObjectSearcher(scope, query)

        'GetObject("winmgmts:\\" & strComputer & "\ROOT\CIMV2")

        For Each queryObj As ManagementObject In searcher.Get()

            frmComputers.cmbSVGA1.Text = queryObj("Name")
            frmComputers.txtSVGAr1.Text = CLng((queryObj("AdapterRAM")/1024)/1024) & " Мб."
            'CLng((queryObj("AdapterRAM") / 1024) / 1024) & " Мб."
            'frmComputers.txtSoc1.Text = queryObj("SocketDesignation")
            'frmComputers.PROizV14.Text = queryObj("Manufacturer")

        Next

        err_:
    End Sub

    Private Sub wSOUND()


        On Error GoTo err_

        Dim scope As New ManagementScope("\\" & strComputer & "\root\CIMV2", connection)
        scope.Connect()

        Dim query As New ObjectQuery("SELECT Description, Manufacturer FROM Win32_SoundDevice")

        Dim searcher As New ManagementObjectSearcher(scope, query)

        'GetObject("winmgmts:\\" & strComputer & "\ROOT\CIMV2")

        For Each queryObj As ManagementObject In searcher.Get()

            frmComputers.cmbSound.Text = queryObj("Description")

            frmComputers.PROizV16.Text = queryObj("Manufacturer")

        Next

        err_:
    End Sub

    Private Sub wNET()

        On Error GoTo err_

        Dim scope As New ManagementScope("\\" & strComputer & "\root\CIMV2", connection)
        scope.Connect()

        Dim query As New ObjectQuery("SELECT * FROM Win32_NetworkAdapterConfiguration")

        Dim searcher As New ManagementObjectSearcher(scope, query)


        For Each queryObj As ManagementObject In searcher.Get()

            If queryObj("IPAddress") Is Nothing Then

            Else

                Dim arrIPAddress As String()
                arrIPAddress = queryObj("IPAddress")

                For Each arrValue As String In arrIPAddress
                    Debug.WriteLine("IPAddress: {0}", arrValue)

                    frmComputers.txtNETip1.Text = arrValue
                    frmComputers.cmbNET1.Text = queryObj("Description")
                    frmComputers.txtNETmac1.Text = queryObj("MACAddress")

                    'frmComputers.txtNETmac1.Text = mo("MACAddress").ToString
                Next
            End If

        Next

        err_:
    End Sub

    Private Sub wCDROM()

        On Error GoTo err_

        Dim scope As New ManagementScope("\\" & strComputer & "\root\CIMV2", connection)
        scope.Connect()

        Dim query As New ObjectQuery("SELECT Name, Manufacturer FROM Win32_CDROMDrive")

        Dim searcher As New ManagementObjectSearcher(scope, query)


        Dim intj As Integer = 1
        For Each queryObj As ManagementObject In searcher.Get()

            Select Case intj

                Case 1

                    frmComputers.cmbOPTIC1.Text = queryObj("Name")
                    frmComputers.PROizV17.Text = queryObj("Manufacturer")

                Case 2

                    frmComputers.cmbOPTIC2.Text = queryObj("Name")
                    frmComputers.PROizV18.Text = queryObj("Manufacturer")
                Case 3

                    frmComputers.cmbOPTIC3.Text = queryObj("Name")
                    frmComputers.PROizV19.Text = queryObj("Manufacturer")


            End Select

            intj = intj + 1

        Next

        err_:
    End Sub

    Private Sub wFDD()

        On Error GoTo err_

        Dim scope As New ManagementScope("\\" & strComputer & "\root\CIMV2", connection)
        scope.Connect()

        Dim query As New ObjectQuery("SELECT Name, Manufacturer FROM Win32_FloppyDrive")

        Dim searcher As New ManagementObjectSearcher(scope, query)

        For Each queryObj As ManagementObject In searcher.Get()

            frmComputers.cmbFDD.Text = queryObj("Name")

            frmComputers.PROizV22.Text = queryObj("Manufacturer")

        Next

        err_:
    End Sub

    Private Sub wModem()
        On Error GoTo err_

        Dim scope As New ManagementScope("\\" & strComputer & "\root\CIMV2", connection)
        scope.Connect()

        Dim query As New ObjectQuery("SELECT Model FROM Win32_POTSModem")

        Dim searcher As New ManagementObjectSearcher(scope, query)


        'GetObject("winmgmts:\\" & strComputer & "\ROOT\CIMV2")


        For Each queryObj As ManagementObject In searcher.Get()

            frmComputers.cmbModem.Text = queryObj("Model")

        Next
        err_:
    End Sub

    Private Sub wKeyboard()
        On Error GoTo err_

        Dim scope As New ManagementScope("\\" & strComputer & "\root\CIMV2", connection)
        scope.Connect()

        Dim query As New ObjectQuery("SELECT Name FROM Win32_Keyboard")

        Dim searcher As New ManagementObjectSearcher(scope, query)


        For Each queryObj As ManagementObject In searcher.Get()

            frmComputers.cmbKeyb.Text = queryObj("Name")

        Next
        err_:
    End Sub

    Private Sub wMouse()
        On Error GoTo err_

        Dim scope As New ManagementScope("\\" & strComputer & "\root\CIMV2", connection)
        scope.Connect()

        Dim query As New ObjectQuery("SELECT Description, SystemName FROM Win32_PointingDevice")

        Dim searcher As New ManagementObjectSearcher(scope, query)


        For Each queryObj As ManagementObject In searcher.Get()

            frmComputers.cmbMouse.Text = queryObj("Description")
            frmComputers.txtSNAME.Text = queryObj("SystemName")
            frmComputers.txtPSEUDONIM.Text = queryObj("SystemName")
            'txtSNAME
        Next

        err_:
    End Sub

    Private Sub wPRN()

        On Error GoTo err_

        Dim scope As New ManagementScope("\\" & strComputer & "\root\CIMV2", connection)
        scope.Connect()

        Dim query As New ObjectQuery("SELECT Name FROM Win32_Printer")

        Dim searcher As New ManagementObjectSearcher(scope, query)


        Dim intj As Integer = 1
        For Each queryObj As ManagementObject In searcher.Get()

            Select Case intj

                Case 1

                    frmComputers.cmbPrinters1.Text = queryObj("Name")
                    'frmComputers.PROizV34.Text = queryObj("Manufacturer")

                Case 2

                    frmComputers.cmbPrinters2.Text = queryObj("Name")
                    'frmComputers.PROizV35.Text = queryObj("Manufacturer")
                Case 3

                    frmComputers.cmbPrinters3.Text = queryObj("Name")
                    'frmComputers.PROizV36.Text = queryObj("Manufacturer")

            End Select

            intj = intj + 1

        Next

        err_:
    End Sub

    Private Sub wMONITOR()

        On Error GoTo err_

        Dim scope As New ManagementScope("\\" & strComputer & "\root\CIMV2", connection)
        scope.Connect()

        Dim query As New ObjectQuery("SELECT Name FROM Win32_DesktopMonitor")

        Dim searcher As New ManagementObjectSearcher(scope, query)


        Dim intj As Integer = 1
        For Each queryObj As ManagementObject In searcher.Get()

            Select Case intj

                Case 1

                    frmComputers.cmbMon1.Text = queryObj("Name")
                    'frmComputers.PROizV28.Text = queryObj("Manufacturer")

                Case 2

                    frmComputers.cmbMon2.Text = queryObj("Name")
                    'frmComputers.PROizV29.Text = queryObj("Manufacturer")

            End Select

            intj = intj + 1

        Next
        err_:
    End Sub

    Private Sub wSOFT()
        On Error GoTo err_


        Dim scope As New ManagementScope("\\" & strComputer & "\root\CIMV2", connection)
        scope.Connect()

        Dim query As New ObjectQuery("SELECT Name, Vendor FROM Win32_Product")

        Dim searcher As New ManagementObjectSearcher(scope, query)


        Dim intj As Integer = 0
        For Each queryObj As ManagementObject In searcher.[Get]()

            Dim li As ListViewItem = frmComputers.lstSoftware.Items.Add(frmComputers.lstSoftware.Items.Count + 1)

            frmComputers.lstSoftware.Items(intj).SubItems.Add(frmComputers.lstSoftware.Items.Count + 1)
            frmComputers.lstSoftware.Items(intj).SubItems.Add(queryObj.Item("Name").ToString)
            frmComputers.lstSoftware.Items(intj).SubItems.Add("")
            frmComputers.lstSoftware.Items(intj).SubItems.Add("")
            frmComputers.lstSoftware.Items(intj).SubItems.Add(Date.Today)
            frmComputers.lstSoftware.Items(intj).SubItems.Add(Date.Today)
            frmComputers.lstSoftware.Items(intj).SubItems.Add(queryObj.Item("Vendor").ToString)

            'li.SubItems.Add(queryObj.Item("Name").ToString)
            'li.SubItems.Add("")
            'li.SubItems.Add("")
            'li.SubItems.Add(Date.Today)
            'li.SubItems.Add(Date.Today)
            'li.SubItems.Add(queryObj.Item("Vendor").ToString)
            '(queryObj.Item("Caption").ToString)
            intj = intj + 1
        Next


        Exit Sub
        err_:
        'MsgBox(Err.Description)
    End Sub

    Private Sub wSYS()

        On Error GoTo err_

        Dim scope As New ManagementScope("\\" & strComputer & "\root\CIMV2", connection)
        scope.Connect()

        Dim query As New ObjectQuery("SELECT * FROM Win32_OperatingSystem")

        Dim searcher As New ManagementObjectSearcher(scope, query)

        Dim intj As Integer = 1
        For Each queryObj As ManagementObject In searcher.Get()

            Dim li As ListViewItem = frmComputers.lstSoftware.Items.Add(frmComputers.lstSoftware.Items.Count + 1)

            li.SubItems.Add(frmComputers.lstSoftware.Items.Count + 1)
            li.SubItems.Add(queryObj("Caption") & " " & queryObj("CSDVersion"))
            li.SubItems.Add(queryObj("SerialNumber"))
            li.SubItems.Add("")
            li.SubItems.Add(Date.Today)
            li.SubItems.Add(Date.Today)
            li.SubItems.Add(queryObj.Item("Manufacturer").ToString)

        Next

        Exit Sub
        err_:
        'MsgBox(Err.Description)
    End Sub
End Module
