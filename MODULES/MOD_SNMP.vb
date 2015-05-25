Imports SnmpSharpNet

Module MOD_SNMP
    Public result_ As Boolean
    Public Name_DEV As String
    Public TEMP_DEV As String
    Public IP_DEV_A As String
    Public COMM_DEV_A As String
    Public STATUS_BATTERY As String

    Public Function REQUEST2(ByVal IP_ As String, ByVal COMMUNITY_ As String, ByVal OID1 As String,
                             ByVal Develop As String) As String

        On Error GoTo Err_

        Dim uname As String
        Dim host As String = IP_
        Dim community As String = COMMUNITY_
        Dim requestOid() As String
        Dim result As Dictionary(Of Oid, AsnType)
        requestOid = New String() {OID1, OID1}
        Dim snmp As SimpleSnmp = New SimpleSnmp(host, community)

        If Not snmp.Valid Then
            GoTo Err_
        End If

        result = snmp.Get(SnmpVersion.Ver1, requestOid)

        If result IsNot Nothing Then
            result_ = True
        Else
            result_ = False
            REQUEST2 = "---"
        End If

        If result IsNot Nothing Then

            Dim kvp As KeyValuePair(Of Oid, AsnType)
            For Each kvp In result

                Select Case Develop

                    Case "APC"


                        Select Case OID1

                            Case "1.3.6.1.4.1.318.1.1.1.4.1.1.0"

                                Select Case kvp.Value.ToString

                                    Case "1"
                                        uname = "Неизветсно"
                                    Case "2"
                                        uname = "От сети"
                                    Case "3"
                                        uname = "От батареи"
                                    Case "4"
                                        uname = "On Smart Boost"
                                    Case "5"
                                        uname = "Timed Sleeping"
                                    Case "6"
                                        uname = "Software Bypass"
                                    Case "7"
                                        uname = "Off"
                                    Case "8"
                                        uname = "Rebooting"
                                    Case "9"
                                        uname = "Switched Bypass"
                                    Case "10"
                                        uname = "Hardware Failure Bypass"
                                    Case "11"
                                        uname = "Sleeping Until Pawer Returns"
                                    Case "12"
                                        uname = "On Smart Trim"

                                End Select

                                REQUEST2 = uname

                                STATUS_BATTERY = uname

                            Case "1.3.6.1.4.1.318.1.1.1.2.1.1.0"

                                Select Case kvp.Value.ToString

                                    Case "1"
                                        uname = "Неизвестно"
                                    Case "2"
                                        uname = "Батарея нормальная"
                                    Case "3"
                                        uname = "Батарея слабая"

                                End Select

                                REQUEST2 = uname

                            Case "1.3.6.1.4.1.318.1.1.1.2.2.4.0"

                                Select Case kvp.Value.ToString

                                    Case "1"

                                        uname = "Не требуется замена"

                                    Case "2"

                                        uname = "Требуется замена"

                                End Select

                                REQUEST2 = uname

                            Case "1.3.6.1.4.1.318.1.1.1.7.2.3.0"

                                Select Case kvp.Value.ToString

                                    Case "1"

                                        uname = "Пройден"

                                    Case Else

                                        uname = "Не пройден"

                                End Select

                                REQUEST2 = uname

                            Case Else

                                REQUEST2 = kvp.Value.ToString

                                If OID1 = "1.3.6.1.2.1.1.6.0" Then Name_DEV = kvp.Value.ToString

                                If OID1 = "1.3.6.1.2.1.1.5.0" Then Name_DEV = Name_DEV & "/" & kvp.Value.ToString

                                If OID1 = "1.3.6.1.4.1.318.1.1.1.2.2.2.0" Then TEMP_DEV = kvp.Value.ToString

                        End Select


                    Case "EATON"

                        Select Case OID1

                            Case "1.3.6.1.4.1.705.1.5.9.0"

                                Select Case kvp.Value.ToString

                                    Case "1"
                                        uname = "Батарея слабая"
                                    Case "2"
                                        uname = "Батарея нормальная"

                                End Select

                                REQUEST2 = uname

                            Case "1.3.6.1.4.1.705.1.5.1.0"
                                ' 1.3.6.1.4.1.705.1.5.1.0

                                uname = kvp.Value.ToString/60

                                REQUEST2 = uname & " минут"

                            Case "1.3.6.1.4.1.705.1.5.11.0"

                                Select Case kvp.Value.ToString

                                    Case "2"
                                        uname = "Не требуется замена"
                                    Case "1"
                                        uname = "Требуется замена"

                                End Select

                                REQUEST2 = uname

                            Case "1.3.6.1.4.1.705.1.5.14.0"

                                Select Case kvp.Value.ToString

                                    Case "1"
                                        uname = "да"
                                    Case "2"
                                        uname = "нет"

                                End Select

                                REQUEST2 = uname

                            Case "1.3.6.1.4.1.705.1.10.3.0"

                                Select Case kvp.Value.ToString

                                    Case "1"

                                        uname = "Пройден"

                                    Case "2"

                                        uname = "Не пройден"

                                    Case Else

                                        uname = "-----"

                                End Select

                                REQUEST2 = uname

                            Case "1.3.6.1.4.1.705.1.7.3.0"

                                Select Case kvp.Value.ToString

                                    Case "1"
                                        uname = "От батареи"
                                    Case "2"
                                        uname = "От сети"

                                End Select

                                REQUEST2 = uname
                                STATUS_BATTERY = uname

                                '1.3.6.1.4.1.705.1.7.3.0
                            Case "1.3.6.1.4.1.705.1.7.2.1.3.1"

                                uname = kvp.Value.ToString/10

                                REQUEST2 = uname '& " Hz"

                            Case Else

                                REQUEST2 = kvp.Value.ToString

                        End Select

                    Case Else

                        REQUEST2 = kvp.Value.ToString

                End Select


            Next

        End If

        Exit Function
        Err_:
    End Function


    Public Sub REQUEST_OID_IBP_DB(ByVal IPDEV As String, ByVal COMMDEV As String, ByVal MODEL As String,
                                  ByVal Develop As String)

        frmComputers.Label94.Text = ""
        frmComputers.Label95.Text = ""
        frmComputers.Label96.Text = ""
        frmComputers.Label97.Text = ""
        frmComputers.Label110.Text = ""
        frmComputers.Label111.Text = ""
        frmComputers.Label112.Text = ""
        frmComputers.Label113.Text = ""
        frmComputers.Label102.Text = ""
        frmComputers.Label103.Text = ""
        frmComputers.Label104.Text = ""
        frmComputers.Label105.Text = ""
        frmComputers.txtOTHSN.Text = ""



        If My.Computer.Network.Ping(IPDEV) Then
            frmComputers.lblSNMP_Ping.Visible = False
        Else

            frmComputers.lblSNMP_Ping.Text = "Devices no reply"
            frmComputers.lblSNMP_Ping.Visible = True
            frmComputers.gbSNMP.Visible = False
            frmComputers.lblSNMP.Visible = False
            frmComputers.txtSNMP.Visible = False
            Exit Sub
        End If


        Dim uname As String

        uname = (REQUEST2(IPDEV, COMMDEV, "1.3.6.1.2.1.1.6.0", Develop))

        If result_ = False Then

            Exit Sub

        End If


        Dim rs1 As Recordset
        rs1 = New Recordset

        rs1.Open("SELECT * FROM TBL_DEV_OID where MODEL='" & MODEL & "'", DB7, CursorTypeEnum.adOpenDynamic,
                 LockTypeEnum.adLockOptimistic)


        With rs1

            frmComputers.Label94.Text = REQUEST2(IPDEV, COMMDEV, .Fields("SELFTEST_OID").Value, Develop)
            frmComputers.Label95.Text = REQUEST2(IPDEV, COMMDEV, .Fields("SELFTEST_DAY_OID").Value, Develop)

            frmComputers.Label96.Text = REQUEST2(IPDEV, COMMDEV, .Fields("TEMPERATURE_OID").Value, Develop) & " °C"
            frmComputers.Label97.Text = REQUEST2(IPDEV, COMMDEV, .Fields("TEMPERATURE2_OID").Value, Develop) & " °C"

            frmComputers.Label110.Text = REQUEST2(IPDEV, COMMDEV, .Fields("IN_TOK_OID").Value, Develop) & " VAC"
            frmComputers.Label111.Text = REQUEST2(IPDEV, COMMDEV, .Fields("OUT_TOK_OID").Value, Develop) & " VAC"
            frmComputers.Label112.Text = REQUEST2(IPDEV, COMMDEV, .Fields("OUTPUT_LOAD_OID").Value, Develop) & " %"
            frmComputers.Label113.Text = REQUEST2(IPDEV, COMMDEV, .Fields("OUTPUT_STATUS_OID").Value, Develop)

            frmComputers.Label102.Text = REQUEST2(IPDEV, COMMDEV, .Fields("TIME_BATTERY_OID").Value, Develop)
            frmComputers.Label103.Text = REQUEST2(IPDEV, COMMDEV, .Fields("ZARIAD_BATTARY_OID").Value, Develop) & " %"
            frmComputers.Label104.Text = REQUEST2(IPDEV, COMMDEV, .Fields("ZAMENA_BATTARY_OID").Value, Develop)
            frmComputers.Label105.Text = REQUEST2(IPDEV, COMMDEV, .Fields("UPTIME_OID").Value, Develop)

            frmComputers.txtOTHSN.Text = REQUEST2(IPDEV, COMMDEV, .Fields("SER_NUM_OID").Value, Develop)
            frmComputers.txtOTHMAC.Text = REQUEST2(IPDEV, COMMDEV, .Fields("MAC_OID").Value, Develop)


        End With

        rs1.Close()
        rs1 = Nothing
    End Sub
End Module
