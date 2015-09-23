'Imports System.Data.SqlClient
Imports System.Net.Mail
Imports System.Net
Imports System.Text

Module MOD_INF_TECH_LOAD
    Private zID As String

    Public Sub LOADnet(ByVal sID As String)
        On Error Resume Next
        Dim unaPCL As Integer

        Dim rs As Recordset 'Объявляем рекордсет
        Dim sSQL As String 'Переменная, где будет размещён SQL запрос

        sSQL = "SELECT * FROM kompy WHERE id =" & sID
        rs = New Recordset
        rs.Open(sSQL, DB7, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic)

        With rs

            frmComputers.lblSidNET.Text = .Fields("id").Value
            If Not IsDBNull(.Fields("PRINTER_NAME_1").Value) Then _
                frmComputers.cmbNetDev.Text = .Fields("PRINTER_NAME_1").Value
            If Not IsDBNull(.Fields("PRINTER_SN_1").Value) Then _
                frmComputers.cmbDevNet.Text = .Fields("PRINTER_SN_1").Value
            If Not IsDBNull(.Fields("PRINTER_PROIZV_1").Value) Then _
                frmComputers.PROiZV40.Text = .Fields("PRINTER_PROIZV_1").Value

            If Not IsDBNull(.Fields("NET_IP_1").Value) Then frmComputers.txtNetIP.Text = .Fields("NET_IP_1").Value
            If Not IsDBNull(.Fields("NET_MAC_1").Value) Then frmComputers.txtNetMac.Text = .Fields("NET_MAC_1").Value


            If Len(frmComputers.txtNetIP.Text) = 0 Then

                If Not IsDBNull(.Fields("PRINTER_NAME_2").Value) Then _
                    frmComputers.txtNetIP.Text = .Fields("PRINTER_NAME_2").Value
                If Not IsDBNull(.Fields("PRINTER_PROIZV_2").Value) Then _
                    frmComputers.txtNetMac.Text = .Fields("PRINTER_PROIZV_2").Value

            End If


            If Not IsDBNull(.Fields("PRINTER_SN_2").Value) Then _
                frmComputers.txtNetPort.Text = .Fields("PRINTER_SN_2").Value

            If Not IsDBNull(.Fields("PRINTER_PROIZV_3").Value) Then _
                frmComputers.txtNetINN.Text = .Fields("PRINTER_PROIZV_3").Value
            If Not IsDBNull(.Fields("PRINTER_SN_3").Value) Then _
                frmComputers.txtNetIsp.Text = .Fields("PRINTER_SN_3").Value

            If Not IsDBNull(.Fields("PRINTER_NAME_4").Value) Then _
                frmComputers.cmbNetVkl.Text = .Fields("PRINTER_NAME_4").Value
            If Not IsDBNull(.Fields("PRINTER_PROIZV_4").Value) Then _
                frmComputers.cmbNetCable.Text = .Fields("PRINTER_PROIZV_4").Value
            If Not IsDBNull(.Fields("PRINTER_SN_4").Value) Then _
                frmComputers.txtNetCableCat.Text = .Fields("PRINTER_SN_4").Value

            'If Not IsDBNull(.Fields("OTvetstvennyj").Value) Then frmComputers.txtNetNumberPorts.Text = .Fields("OTvetstvennyj").Value
            'If Not IsDBNull(.Fields("telephone").Value) Then frmComputers.cmbNETotv.Text = .Fields("telephone").Value


            If Not IsDBNull(.Fields("OTvetstvennyj").Value) Then _
                frmComputers.cmbNETotv.Text = .Fields("OTvetstvennyj").Value
            If Not IsDBNull(.Fields("telephone").Value) Then frmComputers.txtNETphone.Text = .Fields("telephone").Value
            If Not IsDBNull(.Fields("port_2").Value) Then frmComputers.txtNetNumberPorts.Text = .Fields("port_2").Value


            If Not IsDBNull(.Fields("filial").Value) Then frmComputers.cmbNETBranch.Text = .Fields("filial").Value
            If Not IsDBNull(.Fields("mesto").Value) Then frmComputers.cmbNetDepart.Text = .Fields("mesto").Value
            If Not IsDBNull(.Fields("kabn").Value) Then frmComputers.cmbNETOffice.Text = .Fields("kabn").Value

            If Not IsDBNull(.Fields("SFAktNo").Value) Then frmComputers.txtNETSfN.Text = .Fields("SFAktNo").Value
            If Not IsDBNull(.Fields("CenaRub").Value) Then frmComputers.txtNETcash.Text = .Fields("CenaRub").Value
            If Not IsDBNull(.Fields("StoimRub").Value) Then frmComputers.txtNETSumm.Text = .Fields("StoimRub").Value
            If Not IsDBNull(.Fields("Zaiavk").Value) Then frmComputers.txtNETZay.Text = .Fields("Zaiavk").Value

            If Not IsDBNull(.Fields("DataVVoda").Value) Then _
                frmComputers.dtNETdataVvoda.Value = .Fields("DataVVoda").Value
            If Not IsDBNull(.Fields("dataSF").Value) Then frmComputers.dtNETSFdate.Value = .Fields("dataSF").Value

            If Not IsDBNull(.Fields("Spisan").Value) Then frmComputers.chkNETspis.Checked = .Fields("Spisan").Value
            If Not IsDBNull(.Fields("Balans").Value) Then frmComputers.chkNETNNb.Checked = .Fields("Balans").Value

            Select Case frmComputers.chkNETspis.Checked

                Case True
                    frmComputers.dtNETSpisanie.Visible = True
                    If Not IsDBNull(.Fields("data_sp").Value) Then frmComputers.dtNETSpisanie.Value = .Fields("data_sp").Value Else frmComputers.dtNETSpisanie.Value = Date.Today
                Case False
                    frmComputers.dtNETSpisanie.Visible = False
            End Select

            sName = frmComputers.cmbDevNet.Text

            If Not IsDBNull(.Fields("port_1").Value) Then frmComputers.txtNetSN.Text = .Fields("port_1").Value

            If Not IsDBNull(.Fields("PCL").Value) Then
                unaPCL = .Fields("PCL").Value
            Else
                unaPCL = 0

            End If


        End With

        rs.Close()
        rs = Nothing

        If unaPCL = 0 Then

        Else
            rs = New Recordset
            rs.Open("Select NET_NAME From kompy where id=" & unaPCL, DB7, CursorTypeEnum.adOpenDynamic,
                    LockTypeEnum.adLockOptimistic)

            With rs

                frmComputers.cmbCNTNet.Text = .Fields("NET_NAME").Value

            End With
            rs.Close()
            rs = Nothing
        End If


        '#############################################
        'Проверка есть ли контейнеры в справочнике
        '#############################################

        sSQL = "SELECT count(*) as t_n from spr_other where C='1'"
        rs = New Recordset
        rs.Open(sSQL, DB7, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic)

        Dim A1 As String
        With rs
            A1 = .Fields("t_n").Value

        End With
        rs.Close()
        rs = Nothing

        Select Case A1
            Case 0
                frmComputers.cmbCNTNet.Visible = False
                frmComputers.lblPCLNET.Visible = False

            Case Else
                frmComputers.cmbCNTNet.Visible = True
                frmComputers.lblPCLNET.Visible = True

                Call _
                    LOAD_PCL(frmComputers.cmbNETBranch.Text, frmComputers.cmbNetDepart.Text,
                             frmComputers.cmbNETOffice.Text, frmComputers.cmbCNTNet, frmComputers.cmbNETotv.Text, frmComputers.sCOUNT)
                'Call LOAD_PCL(frmComputers.cmbBranch.Text, frmComputers.cmbDepartment.Text, frmComputers.cmbOffice.Text, frmComputers.cmbPCLK)
        End Select

        '#############################################
        '#############################################
        '#############################################


        Call LOAD_GARs(sID, frmComputers.cmbNETPostav, frmComputers.dtGNETPr, frmComputers.dtGNETok)
        ' Call LOAD_NET_PORT(sID)
        Call LOAD_NET_PORT2(sID)
        Call LOAD_NOTES(sID, frmComputers.lvNotesNET)
        Call LOAD_REPAIR(sID, frmComputers.lvRepairNET)
        Call LOAD_DVIG_TEHN(sID, frmComputers.lvMovementNET)
    End Sub

    Public Sub LOAD_NET_PORT(ByVal sID As String)
        Dim rs1 As Recordset
        rs1 = New Recordset
        rs1.Open("SELECT count(*) as t_n FROM net_port WHERE id_net=" & sID, DB7, CursorTypeEnum.adOpenKeyset)

        frmComputers.lvNetPort.Sorting = SortOrder.None
        frmComputers.lvNetPort.ListViewItemSorter = Nothing
        frmComputers.lvNetPort.Items.Clear()

        Dim UCount As Integer

        With rs1
            UCount = .Fields("t_n").Value
        End With
        rs1.Close()
        rs1 = Nothing


        If UCount > 0 Then

            rs1 = New Recordset
            rs1.Open("SELECT * FROM net_port WHERE id_net=" & sID, DB7, CursorTypeEnum.adOpenDynamic,
                     LockTypeEnum.adLockOptimistic)

            Dim intCount As Decimal = 0


            With rs1
                .MoveFirst()
                Do While Not .EOF


                    frmComputers.lvNetPort.Items.Add(.Fields("id").Value) 'col no. 1

                    If Not IsDBNull(.Fields("port").Value) Then
                        frmComputers.lvNetPort.Items(CInt(intCount)).SubItems.Add(.Fields("port").Value)
                    Else
                        frmComputers.lvNetPort.Items(CInt(intCount)).SubItems.Add("")
                    End If

                    If Not IsDBNull(.Fields("net_n").Value) Then
                        frmComputers.lvNetPort.Items(CInt(intCount)).SubItems.Add(.Fields("net_n").Value)
                    Else
                        frmComputers.lvNetPort.Items(CInt(intCount)).SubItems.Add("")
                    End If

                    If Not IsDBNull(.Fields("mac").Value) Then
                        frmComputers.lvNetPort.Items(CInt(intCount)).SubItems.Add(.Fields("mac").Value)
                    Else
                        frmComputers.lvNetPort.Items(CInt(intCount)).SubItems.Add("")
                    End If

                    intCount = intCount + 1

                    .MoveNext()
                Loop
            End With
            rs1.Close()
            rs1 = Nothing

        Else

        End If

        ResList(frmComputers.lvNetPort)
    End Sub

    Public Sub LOAD_NET_PORT2(ByVal sID As Integer)
        On Error GoTo err_


        Dim rs1 As Recordset
        rs1 = New Recordset
        rs1.Open("SELECT count(*) as t_n FROM TBL_NET_MAG WHERE COMMUTATOR=" & sID, DB7, CursorTypeEnum.adOpenDynamic,
                 LockTypeEnum.adLockOptimistic)

        frmComputers.lvNetPort.Sorting = SortOrder.None
        frmComputers.lvNetPort.ListViewItemSorter = Nothing
        frmComputers.lvNetPort.Items.Clear()

        Dim UCount As Integer

        With rs1
            UCount = .Fields("t_n").Value
        End With
        rs1.Close()
        rs1 = Nothing


        If UCount > 0 Then

            frmComputers.Label35.Visible = False
            frmComputers.Label34.Visible = False
            frmComputers.Label33.Visible = False
            frmComputers.txtNetnumberPort.Visible = False
            frmComputers.txtNetPortMapping.Visible = False
            frmComputers.txtNetPortMac.Visible = False
            frmComputers.btnNetPortAdd.Visible = False


            rs1 = New Recordset
            rs1.Open("SELECT * FROM TBL_NET_MAG WHERE COMMUTATOR=" & sID, DB7, CursorTypeEnum.adOpenDynamic,
                     LockTypeEnum.adLockOptimistic)

            Dim intCount As Decimal = 0


            With rs1
                .MoveFirst()
                Do While Not .EOF


                    frmComputers.lvNetPort.Items.Add(.Fields("id").Value) 'col no. 1

                    If Not IsDBNull(.Fields("NET_PORT_COMMUTATOR").Value) Then
                        frmComputers.lvNetPort.Items(CInt(intCount)).SubItems.Add(.Fields("NET_PORT_COMMUTATOR").Value)
                    Else
                        frmComputers.lvNetPort.Items(CInt(intCount)).SubItems.Add("")
                    End If


                    Dim rs As Recordset
                    rs = New Recordset
                    rs.Open("SELECT count(*) as t_n FROM kompy WHERE id=" & .Fields("SVT").Value, DB7,
                            CursorTypeEnum.adOpenKeyset)


                    With rs
                        UCount = .Fields("t_n").Value
                    End With
                    rs.Close()
                    rs = Nothing

                    If UCount > 0 Then

                        rs = New Recordset
                        rs.Open("SELECT net_name,NET_MAC_1 FROM kompy WHERE id=" & .Fields("SVT").Value, DB7,
                                CursorTypeEnum.adOpenKeyset)

                        With rs
                            If Not IsDBNull(.Fields("net_name").Value) Then
                                frmComputers.lvNetPort.Items(CInt(intCount)).SubItems.Add(.Fields("net_name").Value)
                            Else
                                frmComputers.lvNetPort.Items(CInt(intCount)).SubItems.Add("")
                            End If

                            If Not IsDBNull(.Fields("NET_MAC_1").Value) Then
                                frmComputers.lvNetPort.Items(CInt(intCount)).SubItems.Add(.Fields("NET_MAC_1").Value)
                            Else
                                frmComputers.lvNetPort.Items(CInt(intCount)).SubItems.Add("")
                            End If

                        End With
                        rs.Close()
                        rs = Nothing


                    End If

                    intCount = intCount + 1

                    .MoveNext()
                Loop
            End With
            rs1.Close()
            rs1 = Nothing

        Else

            frmComputers.Label35.Visible = True
            frmComputers.Label34.Visible = True
            frmComputers.Label33.Visible = True
            frmComputers.txtNetnumberPort.Visible = True
            frmComputers.txtNetPortMapping.Visible = True
            frmComputers.txtNetPortMac.Visible = True
            frmComputers.btnNetPortAdd.Visible = True


            LOAD_NET_PORT(sID)


        End If

        ResList(frmComputers.lvNetPort)


        Exit Sub
        err_:
        MsgBox(Err.Description)
    End Sub

    Public Sub LOADot(ByVal sID As String)

        On Error Resume Next
        Dim unaPCL As Integer

        Dim rs As Recordset 'Объявляем рекордсет
        Dim sSQL As String 'Переменная, где будет размещён SQL запрос

        sSQL = "SELECT * FROM kompy WHERE id =" & sID
        rs = New Recordset
        rs.Open(sSQL, DB7, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic)

        With rs

            frmComputers.lblsIDOTH.Text = .Fields("id").Value

            If Not IsDBNull(.Fields("PRINTER_NAME_1").Value) Then _
                frmComputers.cmbOTH.Text = .Fields("PRINTER_NAME_1").Value
            If Not IsDBNull(.Fields("PRINTER_SN_1").Value) Then _
                frmComputers.txtOTHSN.Text = .Fields("PRINTER_SN_1").Value
            If Not IsDBNull(.Fields("PRINTER_PROIZV_1").Value) Then _
                frmComputers.PROiZV39.Text = .Fields("PRINTER_PROIZV_1").Value
            If Not IsDBNull(.Fields("port_1").Value) Then frmComputers.txtOTHmemo.Text = .Fields("port_1").Value
            If Not IsDBNull(.Fields("OTvetstvennyj").Value) Then _
                frmComputers.cmbOTHotv.Text = .Fields("OTvetstvennyj").Value
            If Not IsDBNull(.Fields("INV_NO_PRINTER").Value) Then _
                frmComputers.txtOTHinnumber.Text = .Fields("INV_NO_PRINTER").Value

            If Not IsDBNull(.Fields("FILIAL").Value) Then frmComputers.cmbOTHFil.Text = .Fields("FILIAL").Value
            If Not IsDBNull(.Fields("MESTO").Value) Then frmComputers.cmbOTHDepart.Text = .Fields("MESTO").Value
            If Not IsDBNull(.Fields("kabn").Value) Then frmComputers.cmbOTHOffice.Text = .Fields("kabn").Value

            sName = .Fields("PRINTER_NAME_1").Value

            If Not IsDBNull(.Fields("NET_IP_1").Value) Then frmComputers.txtOTHIP.Text = .Fields("NET_IP_1").Value
            If Not IsDBNull(.Fields("NET_MAC_1").Value) Then frmComputers.txtOTHMAC.Text = .Fields("NET_MAC_1").Value
            If Not IsDBNull(.Fields("TIP_COMPA").Value) Then _
                frmComputers.cmbOTHConnect.Text = .Fields("TIP_COMPA").Value


            If Len(frmComputers.cmbOTH.Text) = 0 Then frmComputers.cmbOTH.Text = .Fields("net_name").Value

            If Len(.Fields("NET_IP_1").Value) > 4 And TipTehn = "IBP" Then

                frmComputers.chkSNMP.Checked = .Fields("SNMP").Value
                frmComputers.chkSNMP.Visible = True


                If frmComputers.chkSNMP.Checked = True Or 0 Then
                    'frmComputers.chkSNMP.Visible = True
                    frmComputers.lblSNMP.Visible = True
                    frmComputers.txtSNMP.Visible = True
                    frmComputers.gbSNMP.Visible = True
                Else
                    ' frmComputers.chkSNMP.Visible = False
                    frmComputers.lblSNMP.Visible = False
                    frmComputers.txtSNMP.Visible = False
                    frmComputers.gbSNMP.Visible = False
                End If

                If Not IsDBNull(.Fields("SNMP_COMMUNITY").Value) Then

                    frmComputers.txtSNMP.Text = .Fields("SNMP_COMMUNITY").Value

                    Dim rsSNMP As Recordset
                    Dim sTXT As String
                    rsSNMP = New Recordset
                    rsSNMP.Open("SELECT B FROM SPR_IBP WHERE Name='" & .Fields("PRINTER_NAME_1").Value & "'", DB7,
                                CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic)

                    With rsSNMP

                        sTXT = .Fields("B").Value

                    End With
                    rsSNMP.Close()
                    rsSNMP = Nothing

                    'lblSNMP_Ping

                    If frmComputers.chkSNMP.Checked = True Then _
                        Call _
                            REQUEST_OID_IBP_DB(.Fields("NET_IP_1").Value, .Fields("SNMP_COMMUNITY").Value, sTXT,
                                               .Fields("PRINTER_PROIZV_1").Value)

                End If

            Else

                frmComputers.chkSNMP.Visible = False
                frmComputers.lblSNMP.Visible = False
                frmComputers.txtSNMP.Visible = False
                frmComputers.gbSNMP.Visible = False

            End If

            frmComputers.txtOTHphone.Text = .Fields("TELEPHONE").Value

            If Not IsDBNull(.Fields("SFAktNo").Value) Then frmComputers.txtOTHSfN.Text = .Fields("SFAktNo").Value
            If Not IsDBNull(.Fields("CenaRub").Value) Then frmComputers.txtOTHcash.Text = .Fields("CenaRub").Value
            If Not IsDBNull(.Fields("StoimRub").Value) Then frmComputers.txtOTHSumm.Text = .Fields("StoimRub").Value
            If Not IsDBNull(.Fields("Zaiavk").Value) Then frmComputers.txtOTHZay.Text = .Fields("Zaiavk").Value

            If Not IsDBNull(.Fields("DataVVoda").Value) Then _
                frmComputers.dtOTHdataVvoda.Value = .Fields("DataVVoda").Value
            If Not IsDBNull(.Fields("dataSF").Value) Then frmComputers.dtOTHSFdate.Value = .Fields("dataSF").Value

            If Not IsDBNull(.Fields("Spisan").Value) Then frmComputers.chkOTHspis.Checked = .Fields("Spisan").Value
            If Not IsDBNull(.Fields("Balans").Value) Then frmComputers.chkOTHNNb.Checked = .Fields("Balans").Value

            If Not IsDBNull(.Fields("PCL").Value) Then
                unaPCL = .Fields("PCL").Value
            Else
                unaPCL = 0

            End If

            Select Case frmComputers.chkOTHspis.Checked

                Case True
                    frmComputers.dtOTHSpisanie.Visible = True
                    If Not IsDBNull(.Fields("data_sp").Value) Then frmComputers.dtOTHSpisanie.Value = .Fields("data_sp").Value Else frmComputers.dtOTHSpisanie.Value = Date.Today
                Case False
                    frmComputers.dtOTHSpisanie.Visible = False
            End Select


            'If frmComputers.chkSNMP.Checked = True Or 0 Then
            '    'frmComputers.chkSNMP.Visible = True
            '    frmComputers.lblSNMP.Visible = True
            '    frmComputers.txtSNMP.Visible = True
            '    frmComputers.gbSNMP.Visible = True
            'Else
            '    'frmComputers.chkSNMP.Visible = False
            '    frmComputers.lblSNMP.Visible = False
            '    frmComputers.txtSNMP.Visible = False
            '    frmComputers.gbSNMP.Visible = False
            'End If

        End With

        rs.Close()
        rs = Nothing

        If unaPCL = 0 Then
        Else
            rs = New Recordset
            rs.Open("Select NET_NAME From kompy where id=" & unaPCL, DB7, CursorTypeEnum.adOpenDynamic,
                    LockTypeEnum.adLockOptimistic)

            With rs

                frmComputers.cmbOTHPCL.Text = .Fields("NET_NAME").Value

            End With
            rs.Close()
            rs = Nothing
        End If


        Call LOAD_GARs(sID, frmComputers.cmbOTHPostav, frmComputers.dtGOTHPr, frmComputers.dtGOTHok)
        'Call LOAD_NOTES(sID, frmComputers.lvNotesOTH)
        'Call LOAD_REPAIR(sID, frmComputers.lvRepairOTH)
        'Call LOAD_DVIG_TEHN(sID, frmComputers.lvMovementOTH)
    End Sub

    Public Sub LOADp(ByVal sID As String)
        On Error Resume Next

        Dim kol As Long
        Dim uname As String
        Dim rs1 As Recordset 'Объявляем рекордсет
        Dim sSQL1 As String 'Переменная, где будет размещён SQL запрос
        Dim unaPCL As Integer

        Dim rs As Recordset 'Объявляем рекордсет
        Dim sSQL As String 'Переменная, где будет размещён SQL запрос

        sSQL = "SELECT * FROM kompy WHERE id =" & sID
        rs = New Recordset
        rs.Open(sSQL, DB7, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic)

        With rs

            frmComputers.lblSidPRN.Text = .Fields("id").Value
            If Not IsDBNull(.Fields("PRINTER_NAME_1")) Then frmComputers.cmbPRN.Text = .Fields("PRINTER_NAME_1").Value
            If Not IsDBNull(.Fields("os")) Then frmComputers.cmbModCartr.Text = .Fields("os").Value

            If Len(frmComputers.cmbModCartr.Text) <> 0 Then
                Call frmComputers.Tip_Model_CARTR()
            End If

            If Not IsDBNull(.Fields("PRINTER_SN_1")) Then frmComputers.txtPRNSN.Text = .Fields("PRINTER_SN_1").Value
            If Not IsDBNull(.Fields("PRINTER_PROIZV_1")) Then _
                frmComputers.PROiZV38.Text = .Fields("PRINTER_PROIZV_1").Value
            If Not IsDBNull(.Fields("INV_NO_PRINTER")) Then _
                frmComputers.txtPRNinnumber.Text = .Fields("INV_NO_PRINTER").Value
            If Not IsDBNull(.Fields("port_1")) Then frmComputers.cmbFormat.Text = .Fields("port_1").Value

            If Not IsDBNull(.Fields("FILIAL")) Then frmComputers.cmbPRNFil.Text = .Fields("FILIAL").Value
            If Not IsDBNull(.Fields("mesto")) Then frmComputers.cmbPRNDepart.Text = .Fields("mesto").Value
            If Not IsDBNull(.Fields("kabn")) Then frmComputers.cmbPRNOffice.Text = .Fields("kabn").Value

            If Not IsDBNull(.Fields("OTvetstvennyj")) Then frmComputers.cmbPRNotv.Text = .Fields("OTvetstvennyj").Value
            If Not IsDBNull(.Fields("TELEPHONE")) Then frmComputers.txtPRNphone.Text = .Fields("TELEPHONE").Value
            If Not IsDBNull(.Fields("NET_IP_1")) Then frmComputers.txtPrnIP.Text = .Fields("NET_IP_1").Value


            '###################################################################################
            'Ищем устройства использующие принтер
            '###################################################################################

            Select Case Len(frmComputers.txtPrnIP.Text)

                Case 0

                    frmComputers.gbPRN_USTR.Visible = False

                Case Else

                    sSQL1 = "SELECT count(*) as t_n FROM kompy WHERE PORT_1 like'IP_" & frmComputers.txtPrnIP.Text & "' or PORT_2 like 'IP_" & frmComputers.txtPrnIP.Text & "' or PORT_3 like 'IP_" & frmComputers.txtPrnIP.Text & "' "
                    rs1 = New Recordset
                    rs1.Open(sSQL1, DB7, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic)

                    Dim tmpCount As Integer

                    With rs1
                        tmpCount = .Fields("t_n").Value
                    End With

                    rs1.Close()
                    rs1 = Nothing

                    Select Case tmpCount

                        Case 0

                        Case Else

                            frmComputers.gbPRN_USTR.Visible = True

                            sSQL1 = "SELECT id, net_name, filial, mesto,kabn FROM kompy WHERE PORT_1 like'IP_" & frmComputers.txtPrnIP.Text & "' or PORT_2 like 'IP_" & frmComputers.txtPrnIP.Text & "' or PORT_3 like 'IP_" & frmComputers.txtPrnIP.Text & "' "
                            rs1 = New Recordset
                            rs1.Open(sSQL1, DB7, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic)

                            Dim intCount As Integer = 0

                            With rs1
                                .MoveFirst()
                                Do While Not .EOF
                                    frmComputers.lvUSTR_PRINT.Items.Add(.Fields("id").Value)
                                    frmComputers.lvUSTR_PRINT.Items(CInt(intCount)).SubItems.Add(.Fields("net_name").Value)
                                    frmComputers.lvUSTR_PRINT.Items(CInt(intCount)).SubItems.Add(.Fields("filial").Value)
                                    frmComputers.lvUSTR_PRINT.Items(CInt(intCount)).SubItems.Add(.Fields("mesto").Value)
                                    frmComputers.lvUSTR_PRINT.Items(CInt(intCount)).SubItems.Add(.Fields("kabn").Value)
                                    intCount = intCount + 1
                                    .MoveNext()
                                Loop
                            End With

                            rs1.Close()
                            rs1 = Nothing
                            ResList(frmComputers.lvUSTR_PRINT)

                    End Select

            End Select

            '###################################################################################
            '###################################################################################
            '###################################################################################


            If Not IsDBNull(.Fields("NET_MAC_1")) Then frmComputers.txtPRNMAC.Text = .Fields("NET_MAC_1").Value

            If Not IsDBNull(.Fields("SFAktNo").Value) Then frmComputers.txtPRNSfN.Text = .Fields("SFAktNo").Value
            If Not IsDBNull(.Fields("CenaRub").Value) Then frmComputers.txtPRNcash.Text = .Fields("CenaRub").Value
            If Not IsDBNull(.Fields("StoimRub").Value) Then frmComputers.txtPRNSumm.Text = .Fields("StoimRub").Value
            If Not IsDBNull(.Fields("Zaiavk").Value) Then frmComputers.txtPRNZay.Text = .Fields("Zaiavk").Value

            If Not IsDBNull(.Fields("DataVVoda").Value) Then _
                frmComputers.dtPRNdataVvoda.Value = .Fields("DataVVoda").Value
            If Not IsDBNull(.Fields("dataSF").Value) Then frmComputers.dtPRNSFdate.Value = .Fields("dataSF").Value

            If Not IsDBNull(.Fields("Spisan").Value) Then frmComputers.chkPRNspis.Checked = .Fields("Spisan").Value
            If Not IsDBNull(.Fields("Balans").Value) Then frmComputers.chkPRNNNb.Checked = .Fields("Balans").Value

            Select Case frmComputers.chkPRNspis.Checked

                Case True
                    frmComputers.dtPRNSpisanie.Visible = True
                    If Not IsDBNull(.Fields("data_sp").Value) Then frmComputers.dtPRNSpisanie.Value = .Fields("data_sp").Value Else frmComputers.dtPRNSpisanie.Value = Date.Today
                Case False
                    frmComputers.dtPRNSpisanie.Visible = False
            End Select

            If Not IsDBNull(.Fields("PCL").Value) Then
                unaPCL = .Fields("PCL").Value
            Else
                unaPCL = 0

            End If

            '###################################################################################
            'Ищем устройства использующие принтер
            '###################################################################################
            Select Case unaPCL

                Case 0


                    Select Case frmComputers.gbPRN_USTR.Visible

                        Case True

                        Case False

                            frmComputers.gbPRN_USTR.Visible = False

                    End Select

                Case Else

                    sSQL1 = "SELECT net_name FROM kompy WHERE id =" & unaPCL
                    rs1 = New Recordset
                    rs1.Open(sSQL1, DB7, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic)

                    Dim tmpName As String

                    With rs1
                        tmpName = .Fields("net_name").Value
                    End With
                    rs1.Close()
                    rs1 = Nothing

                    sSQL1 = "SELECT count(*) as t_n FROM kompy WHERE PRINTER_NAME_1 like '\\" & tmpName & "\" & frmComputers.cmbPRN.Text & "' or  PRINTER_NAME_2 like '\\" & tmpName & "\" & frmComputers.cmbPRN.Text & "' or  PRINTER_NAME_3 like '\\" & tmpName & "\" & frmComputers.cmbPRN.Text & "'"
                    rs1 = New Recordset
                    rs1.Open(sSQL1, DB7, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic)

                    Dim tmpCount As Integer

                    With rs1
                        tmpCount = .Fields("t_n").Value
                    End With

                    rs1.Close()
                    rs1 = Nothing

                    Select Case tmpCount

                        Case 0

                        Case Else

                            frmComputers.gbPRN_USTR.Visible = True

                            sSQL1 = "SELECT id, net_name, filial, mesto,kabn FROM kompy WHERE PRINTER_NAME_1 like'\\" & tmpName & "\" & frmComputers.cmbPRN.Text & "' or  PRINTER_NAME_2 like'\\" & tmpName & "\" & frmComputers.cmbPRN.Text & "' or PRINTER_NAME_3 like'\\" & tmpName & "\" & frmComputers.cmbPRN.Text & "'"
                            rs1 = New Recordset
                            rs1.Open(sSQL1, DB7, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic)

                            Dim intCount As Integer = 0

                            With rs1
                                .MoveFirst()
                                Do While Not .EOF
                                    frmComputers.lvUSTR_PRINT.Items.Add(.Fields("id").Value)
                                    frmComputers.lvUSTR_PRINT.Items(CInt(intCount)).SubItems.Add(.Fields("net_name").Value)
                                    frmComputers.lvUSTR_PRINT.Items(CInt(intCount)).SubItems.Add(.Fields("filial").Value)
                                    frmComputers.lvUSTR_PRINT.Items(CInt(intCount)).SubItems.Add(.Fields("mesto").Value)
                                    frmComputers.lvUSTR_PRINT.Items(CInt(intCount)).SubItems.Add(.Fields("kabn").Value)
                                    intCount = intCount + 1
                                    .MoveNext()
                                Loop
                            End With

                            rs1.Close()
                            rs1 = Nothing
                            ResList(frmComputers.lvUSTR_PRINT)
                    End Select

            End Select

            '###################################################################################
            '###################################################################################
            '###################################################################################

            If Not IsDBNull(.Fields("port_2").Value) Then frmComputers.cmbPRNConnect.Text = .Fields("port_2").Value

            sName = .Fields("PRINTER_NAME_1").Value

            If Len(frmComputers.cmbModCartr.Text) = 0 Then

            Else

                sSQL1 = "SELECT * FROM spr_cart WHERE name='" & frmComputers.cmbTIPCartridg.Text & "'"
                rs1 = New Recordset
                rs1.Open(sSQL1, DB7, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic)

                With rs1
                    frmComputers.cmbTIPCartridg.Text = .Fields("A").Value
                End With

                rs1.Close()
                rs1 = Nothing

            End If

        End With


        If Len(unaPCL) <> 0 Then

            rs = New Recordset
            rs.Open("Select NET_NAME From kompy where id=" & unaPCL, DB7, CursorTypeEnum.adOpenDynamic,
                    LockTypeEnum.adLockOptimistic)

            With rs

                frmComputers.cmbPCL.Text = .Fields("NET_NAME").Value

            End With
            rs.Close()
            rs = Nothing

            frmComputers.cmbPCL.Enabled = True
        End If


        Call LOAD_CRT(sID)

        Call LOAD_GARs(sID, frmComputers.cmbPRNPostav, frmComputers.dtGPRNPr, frmComputers.dtGPRNok)

        'Call LOAD_NOTES(sID, frmComputers.lvNotesPRN)
        'Call LOAD_REPAIR(sID, frmComputers.lvRepairPRN)
        'Call LOAD_DVIG_TEHN(sID, frmComputers.lvMovementPRN)
    End Sub

    Public Sub LOAD_CRT(ByVal sID As String)
        On Error Resume Next
        'Обнаруженные картриджи
        frmComputers.lvPRNCartr.Items.Clear()
        frmComputers.lblPRNPage.Text = ""

        Dim kol As Long
        Dim uname As String
        Dim rs1 As Recordset
        Dim sSQL1 As String

        sSQL1 = "SELECT COUNT(*) AS t_number FROM CARTRIDG WHERE USTR=" & sID
        rs1 = New Recordset
        rs1.Open(sSQL1, DB7, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic)

        With rs1

            kol = .Fields("t_number").Value

        End With

        rs1.Close()
        rs1 = Nothing

        If kol = 0 Then

        Else

            Dim intCount As Decimal = 0
            Dim scid As Integer

            'Dim rs1 As ADODB.Recordset 'Объявляем рекордсет
            'Dim sSQL1 As String 'Переменная, где будет размещён SQL запрос

            sSQL1 = "SELECT * FROM CARTRIDG WHERE USTR=" & sID
            rs1 = New Recordset
            rs1.Open(sSQL1, DB7, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic)


            With rs1
                .MoveFirst()
                Do While Not .EOF

                    frmComputers.lvPRNCartr.Items.Add(.Fields("id").Value) 'col no. 1
                    uname = .Fields("Model").Value
                    scid = .Fields("id").Value


                    Dim rs2 As Recordset 'Объявляем рекордсет
                    Dim sSQL2 As String 'Переменная, где будет размещён SQL запрос

                    sSQL2 = "SELECT * FROM spr_cart where ID =" & uname
                    rs2 = New Recordset
                    rs2.Open(sSQL2, DB7, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic)

                    With rs2
                        If Not IsDBNull(.Fields("name").Value) Then _
                            frmComputers.lvPRNCartr.Items(CInt(intCount)).SubItems.Add(.Fields("name").Value)
                    End With
                    rs2.Close()
                    rs2 = Nothing


                    If Not IsDBNull(.Fields("SN")) Then _
                        frmComputers.lvPRNCartr.Items(CInt(intCount)).SubItems.Add(.Fields("SN").Value)


                    Dim uname1 As Decimal = 0
                    Dim uname2 As Decimal = 0

                    sSQL2 = "SELECT Paper, STOIM FROM CARTRIDG_Z where ID_C =" & scid
                    rs2 = New Recordset
                    rs2.Open(sSQL2, DB7, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic)

                    With rs2
                        .MoveFirst()
                        Do While Not .EOF
                            uname1 = uname1 + .Fields("Paper").Value
                            uname2 = uname2 + .Fields("STOIM").Value

                            .MoveNext()
                        Loop
                    End With

                    rs2.Close()
                    rs2 = Nothing


                    frmComputers.lblPRNPage.Text = uname1


                    sSQL2 = "SELECT COUNT(*) as total_num FROM CARTRIDG_Z where ID_C =" & scid
                    rs2 = New Recordset
                    rs2.Open(sSQL2, DB7, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic)

                    With rs2

                        If Not IsDBNull(.Fields("total_num").Value) Then _
                            frmComputers.lvPRNCartr.Items(CInt(intCount)).SubItems.Add(.Fields("total_num").Value)

                    End With

                    rs2.Close()
                    rs2 = Nothing


                    frmComputers.lvPRNCartr.Items(CInt(intCount)).SubItems.Add(uname2)

                    intCount = intCount + 1

                    .MoveNext()
                Loop
            End With

        End If


        ResList(frmComputers.lvPRNCartr)
    End Sub

    Public Sub LOADt(ByVal sID As String)
        On Error Resume Next
        zID = sID

        Dim unaPCL As Integer

        Dim rs As Recordset 'Объявляем рекордсет
        Dim sSQL As String 'Переменная, где будет размещён SQL запрос

        sSQL = "SELECT * FROM kompy WHERE id =" & sID
        rs = New Recordset
        rs.Open(sSQL, DB7, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic)

        frmComputers.bCPUPlus.Visible = True
        frmComputers.bRamPlus.Visible = True
        frmComputers.bHddPlus.Visible = True
        frmComputers.bSVGAPlus.Visible = True
        frmComputers.bOpticalPlus.Visible = True
        frmComputers.bNETPlus.Visible = True
        frmComputers.bMonitorPlus.Visible = True
        frmComputers.bPrinterPlus.Visible = True

        With rs
            'Процессоры

            frmComputers.lblsID.Text = .Fields("id").Value

            If Not IsDBNull(.Fields("CPU1").Value) Then frmComputers.cmbCPU1.Text = .Fields("CPU1").Value
            If Not IsDBNull(.Fields("CPUmhz1").Value) Then frmComputers.txtMHZ1.Text = .Fields("CPUmhz1").Value
            If Not IsDBNull(.Fields("CPUSocket1").Value) Then frmComputers.txtSoc1.Text = .Fields("CPUSocket1").Value
            If Not IsDBNull(.Fields("CPUProizv1").Value) Then frmComputers.PROizV1.Text = .Fields("CPUProizv1").Value
            frmComputers.sCPU = 1

            If Not IsDBNull(.Fields("CPU2").Value) And Len(.Fields("CPU2").Value) > 1 Then
                frmComputers.cmbCPU2.Text = .Fields("CPU2").Value
                frmComputers.sCPU = 2
                frmComputers.cmbCPU2.Visible = True
                frmComputers.txtMHZ2.Visible = True
                frmComputers.txtSoc2.Visible = True
                frmComputers.PROizV2.Visible = True
                If Not IsDBNull(.Fields("CPUmhz2").Value) Then frmComputers.txtMHZ2.Text = .Fields("CPUmhz2").Value
                If Not IsDBNull(.Fields("CPUSocket2").Value) Then _
                    frmComputers.txtSoc2.Text = .Fields("CPUSocket2").Value
                If Not IsDBNull(.Fields("CPUProizv2").Value) Then _
                    frmComputers.PROizV2.Text = .Fields("CPUProizv2").Value
            Else
                frmComputers.cmbCPU2.Visible = False
                frmComputers.txtMHZ2.Visible = False
                frmComputers.txtSoc2.Visible = False
                frmComputers.PROizV2.Visible = False
            End If


            If Not IsDBNull(.Fields("CPU3").Value) And Len(.Fields("CPU3").Value) > 1 Then
                frmComputers.cmbCPU3.Text = .Fields("CPU3").Value
                frmComputers.sCPU = 3
                frmComputers.cmbCPU3.Visible = True
                frmComputers.txtMHZ3.Visible = True
                frmComputers.txtSoc3.Visible = True
                frmComputers.PROizV3.Visible = True
                If Not IsDBNull(.Fields("CPUmhz3").Value) Then frmComputers.txtMHZ3.Text = .Fields("CPUmhz3").Value
                If Not IsDBNull(.Fields("CPUSocket3").Value) Then _
                    frmComputers.txtSoc3.Text = .Fields("CPUSocket3").Value
                If Not IsDBNull(.Fields("CPUProizv3").Value) Then _
                    frmComputers.PROizV3.Text = .Fields("CPUProizv3").Value
            Else
                frmComputers.cmbCPU3.Visible = False
                frmComputers.txtMHZ3.Visible = False
                frmComputers.txtSoc3.Visible = False
                frmComputers.PROizV3.Visible = False

            End If


            'If Not IsDBNull(.Fields("CPU4").Value) Then frmComputers.cmbCPU4.Text = .Fields("CPU4").Value

            If Not IsDBNull(.Fields("CPU4").Value) And Len(.Fields("CPU4").Value) > 1 Then
                frmComputers.cmbCPU4.Text = .Fields("CPU4").Value
                frmComputers.sCPU = 4
                frmComputers.bCPUPlus.Visible = False
                frmComputers.cmbCPU4.Visible = True
                frmComputers.txtMHZ4.Visible = True
                frmComputers.txtSoc4.Visible = True
                frmComputers.PROizV4.Visible = True
                If Not IsDBNull(.Fields("CPUmhz4").Value) Then frmComputers.txtMHZ4.Text = .Fields("CPUmhz4").Value
                If Not IsDBNull(.Fields("CPUSocket4").Value) Then _
                    frmComputers.txtSoc4.Text = .Fields("CPUSocket4").Value
                If Not IsDBNull(.Fields("CPUProizv4").Value) Then _
                    frmComputers.PROizV4.Text = .Fields("CPUProizv4").Value
            Else
                frmComputers.cmbCPU4.Visible = False
                frmComputers.txtMHZ4.Visible = False
                frmComputers.txtSoc4.Visible = False
                frmComputers.PROizV4.Visible = False

            End If


            'Материнская плата
            If Not IsDBNull(.Fields("MB_NAME").Value) Then frmComputers.cmbMB.Text = .Fields("MB_NAME").Value
            If Not IsDBNull(.Fields("Mb_Chip").Value) Then frmComputers.txtChip.Text = .Fields("Mb_Chip").Value
            If Not IsDBNull(.Fields("Mb_Proizvod").Value) Then frmComputers.PROizV5.Text = .Fields("Mb_Proizvod").Value
            If Not IsDBNull(.Fields("Mb_Id").Value) Then frmComputers.txtSN_MB.Text = .Fields("Mb_Id").Value

            'Модули памяти

            If Not IsDBNull(.Fields("RAM_1").Value) Then frmComputers.cmbRAM1.Text = .Fields("RAM_1").Value
            If Not IsDBNull(.Fields("RAM_SN_1").Value) Then frmComputers.txtRamSN1.Text = .Fields("RAM_SN_1").Value
            If Not IsDBNull(.Fields("RAM_speed_1").Value) Then frmComputers.txtRamS1.Text = .Fields("RAM_speed_1").Value
            If Not IsDBNull(.Fields("RAM_PROIZV_1").Value) Then _
                frmComputers.PROizV6.Text = .Fields("RAM_PROIZV_1").Value

            'If Not IsDBNull(.Fields("RAM_2").Value) Then frmComputers.cmbRAM2.Text = .Fields("RAM_2").Value
            frmComputers.sRAM = 1

            If Not IsDBNull(.Fields("RAM_2").Value) And Len(.Fields("RAM_2").Value) > 1 Then
                frmComputers.cmbRAM2.Text = .Fields("RAM_2").Value
                frmComputers.sRAM = frmComputers.sRAM + 1
                frmComputers.cmbRAM2.Visible = True
                frmComputers.txtRamSN2.Visible = True
                frmComputers.txtRamS2.Visible = True
                frmComputers.PROizV7.Visible = True
                If Not IsDBNull(.Fields("RAM_speed_2").Value) Then _
                    frmComputers.txtRamS2.Text = .Fields("RAM_speed_2").Value
                If Not IsDBNull(.Fields("RAM_SN_2").Value) Then frmComputers.txtRamSN2.Text = .Fields("RAM_SN_2").Value
                If Not IsDBNull(.Fields("RAM_PROIZV_2").Value) Then _
                    frmComputers.PROizV7.Text = .Fields("RAM_PROIZV_2").Value
            Else
                frmComputers.cmbRAM2.Visible = False
                frmComputers.txtRamSN2.Visible = False
                frmComputers.txtRamS2.Visible = False
                frmComputers.PROizV7.Visible = False

            End If

            'If Not IsDBNull(.Fields("RAM_3").Value) Then frmComputers.cmbRAM3.Text = .Fields("RAM_3").Value

            If Not IsDBNull(.Fields("RAM_3").Value) And Len(.Fields("RAM_3").Value) > 1 Then
                frmComputers.cmbRAM3.Text = .Fields("RAM_3").Value
                frmComputers.sRAM = frmComputers.sRAM + 1
                frmComputers.cmbRAM2.Visible = True
                frmComputers.txtRamSN2.Visible = True
                frmComputers.txtRamS2.Visible = True
                frmComputers.PROizV7.Visible = True
                frmComputers.cmbRAM3.Visible = True
                frmComputers.txtRamSN3.Visible = True
                frmComputers.txtRamS3.Visible = True
                frmComputers.PROizV8.Visible = True
                If Not IsDBNull(.Fields("RAM_speed_3").Value) Then _
                    frmComputers.txtRamS3.Text = .Fields("RAM_speed_3").Value
                If Not IsDBNull(.Fields("RAM_SN_3").Value) Then frmComputers.txtRamSN3.Text = .Fields("RAM_SN_3").Value
                If Not IsDBNull(.Fields("RAM_PROIZV_3").Value) Then _
                    frmComputers.PROizV8.Text = .Fields("RAM_PROIZV_3").Value
            Else
                frmComputers.cmbRAM3.Visible = False
                frmComputers.txtRamSN3.Visible = False
                frmComputers.txtRamS3.Visible = False
                frmComputers.PROizV8.Visible = False

            End If


            'If Not IsDBNull(.Fields("RAM_4").Value) Then frmComputers.cmbRAM4.Text = .Fields("RAM_4").Value
            If Not IsDBNull(.Fields("RAM_4").Value) And Len(.Fields("RAM_4").Value) > 1 Then
                frmComputers.cmbRAM4.Text = .Fields("RAM_4").Value
                frmComputers.sRAM = frmComputers.sRAM + 1
                ' frmComputers.bRamPlus.Visible = False
                frmComputers.cmbRAM2.Visible = True
                frmComputers.txtRamSN2.Visible = True
                frmComputers.txtRamS2.Visible = True
                frmComputers.PROizV7.Visible = True
                frmComputers.cmbRAM3.Visible = True
                frmComputers.txtRamSN3.Visible = True
                frmComputers.txtRamS3.Visible = True
                frmComputers.PROizV8.Visible = True
                frmComputers.cmbRAM4.Visible = True
                frmComputers.txtRamSN4.Visible = True
                frmComputers.txtRamS4.Visible = True
                frmComputers.PROizV9.Visible = True
                If Not IsDBNull(.Fields("RAM_speed_4").Value) Then _
                    frmComputers.txtRamS4.Text = .Fields("RAM_speed_4").Value
                If Not IsDBNull(.Fields("RAM_SN_4").Value) Then frmComputers.txtRamSN4.Text = .Fields("RAM_SN_4").Value
                If Not IsDBNull(.Fields("RAM_PROIZV_4").Value) Then _
                    frmComputers.PROizV9.Text = .Fields("RAM_PROIZV_4").Value
            Else
                frmComputers.cmbRAM4.Visible = False
                frmComputers.txtRamSN4.Visible = False
                frmComputers.txtRamS4.Visible = False
                frmComputers.PROizV9.Visible = False

            End If

            'Новые модули памяти
            If Not IsDBNull(.Fields("RAM_5").Value) And Len(.Fields("RAM_5").Value) > 1 Then
                frmComputers.cmbRAM5.Text = .Fields("RAM_5").Value
                frmComputers.sRAM = frmComputers.sRAM + 1
                ' frmComputers.bRamPlus.Visible = False
                frmComputers.cmbRAM2.Visible = True
                frmComputers.txtRamSN2.Visible = True
                frmComputers.txtRamS2.Visible = True
                frmComputers.PROizV7.Visible = True
                frmComputers.cmbRAM3.Visible = True
                frmComputers.txtRamSN3.Visible = True
                frmComputers.txtRamS3.Visible = True
                frmComputers.PROizV8.Visible = True
                frmComputers.cmbRAM4.Visible = True
                frmComputers.txtRamSN4.Visible = True
                frmComputers.txtRamS4.Visible = True
                frmComputers.PROizV9.Visible = True
                frmComputers.cmbRAM5.Visible = True
                frmComputers.txtRamSN5.Visible = True
                frmComputers.txtRamS5.Visible = True
                frmComputers.PROizV44.Visible = True
                If Not IsDBNull(.Fields("RAM_speed_5").Value) Then _
                    frmComputers.txtRamS5.Text = .Fields("RAM_speed_5").Value
                If Not IsDBNull(.Fields("RAM_SN_5").Value) Then frmComputers.txtRamSN5.Text = .Fields("RAM_SN_5").Value
                If Not IsDBNull(.Fields("RAM_PROIZV_5").Value) Then _
                    frmComputers.PROizV44.Text = .Fields("RAM_PROIZV_5").Value
            Else
                frmComputers.cmbRAM5.Visible = False
                frmComputers.txtRamSN5.Visible = False
                frmComputers.txtRamS5.Visible = False
                frmComputers.PROizV44.Visible = False

            End If

            If Not IsDBNull(.Fields("RAM_6").Value) And Len(.Fields("RAM_6").Value) > 1 Then
                frmComputers.cmbRAM6.Text = .Fields("RAM_6").Value
                frmComputers.sRAM = frmComputers.sRAM + 1
                ' frmComputers.bRamPlus.Visible = False
                frmComputers.cmbRAM2.Visible = True
                frmComputers.txtRamSN2.Visible = True
                frmComputers.txtRamS2.Visible = True
                frmComputers.PROizV7.Visible = True
                frmComputers.cmbRAM3.Visible = True
                frmComputers.txtRamSN3.Visible = True
                frmComputers.txtRamS3.Visible = True
                frmComputers.PROizV8.Visible = True
                frmComputers.cmbRAM4.Visible = True
                frmComputers.txtRamSN4.Visible = True
                frmComputers.txtRamS4.Visible = True
                frmComputers.PROizV9.Visible = True
                frmComputers.cmbRAM5.Visible = True
                frmComputers.txtRamSN5.Visible = True
                frmComputers.txtRamS5.Visible = True
                frmComputers.PROizV44.Visible = True
                frmComputers.cmbRAM6.Visible = True
                frmComputers.txtRamSN6.Visible = True
                frmComputers.txtRamS6.Visible = True
                frmComputers.PROizV45.Visible = True
                If Not IsDBNull(.Fields("RAM_speed_6").Value) Then _
                    frmComputers.txtRamS6.Text = .Fields("RAM_speed_6").Value
                If Not IsDBNull(.Fields("RAM_SN_6").Value) Then frmComputers.txtRamSN6.Text = .Fields("RAM_SN_6").Value
                If Not IsDBNull(.Fields("RAM_PROIZV_6").Value) Then _
                    frmComputers.PROizV45.Text = .Fields("RAM_PROIZV_6").Value
            Else
                frmComputers.cmbRAM6.Visible = False
                frmComputers.txtRamSN6.Visible = False
                frmComputers.txtRamS6.Visible = False
                frmComputers.PROizV45.Visible = False

            End If

            If Not IsDBNull(.Fields("RAM_7").Value) And Len(.Fields("RAM_7").Value) > 1 Then
                frmComputers.cmbRAM7.Text = .Fields("RAM_7").Value
                frmComputers.sRAM = frmComputers.sRAM + 1
                'frmComputers.bRamPlus.Visible = False
                frmComputers.cmbRAM2.Visible = True
                frmComputers.txtRamSN2.Visible = True
                frmComputers.txtRamS2.Visible = True
                frmComputers.PROizV7.Visible = True
                frmComputers.cmbRAM3.Visible = True
                frmComputers.txtRamSN3.Visible = True
                frmComputers.txtRamS3.Visible = True
                frmComputers.PROizV8.Visible = True
                frmComputers.cmbRAM4.Visible = True
                frmComputers.txtRamSN4.Visible = True
                frmComputers.txtRamS4.Visible = True
                frmComputers.PROizV9.Visible = True
                frmComputers.cmbRAM5.Visible = True
                frmComputers.txtRamSN5.Visible = True
                frmComputers.txtRamS5.Visible = True
                frmComputers.PROizV44.Visible = True
                frmComputers.cmbRAM6.Visible = True
                frmComputers.txtRamSN6.Visible = True
                frmComputers.txtRamS6.Visible = True
                frmComputers.PROizV45.Visible = True
                frmComputers.cmbRAM6.Visible = True
                frmComputers.txtRamSN6.Visible = True
                frmComputers.txtRamS6.Visible = True
                frmComputers.PROizV45.Visible = True
                If Not IsDBNull(.Fields("RAM_speed_7").Value) Then _
                    frmComputers.txtRamS7.Text = .Fields("RAM_speed_7").Value
                If Not IsDBNull(.Fields("RAM_SN_7").Value) Then frmComputers.txtRamSN7.Text = .Fields("RAM_SN_7").Value
                If Not IsDBNull(.Fields("RAM_PROIZV_7").Value) Then _
                    frmComputers.PROizV46.Text = .Fields("RAM_PROIZV_7").Value
            Else
                frmComputers.cmbRAM7.Visible = False
                frmComputers.txtRamSN7.Visible = False
                frmComputers.txtRamS7.Visible = False
                frmComputers.PROizV46.Visible = False

            End If

            If Not IsDBNull(.Fields("RAM_8").Value) And Len(.Fields("RAM_8").Value) > 1 Then
                frmComputers.cmbRAM8.Text = .Fields("RAM_8").Value
                frmComputers.sRAM = frmComputers.sRAM + 1
                frmComputers.bRamPlus.Visible = False
                frmComputers.cmbRAM2.Visible = True
                frmComputers.txtRamSN2.Visible = True
                frmComputers.txtRamS2.Visible = True
                frmComputers.PROizV7.Visible = True
                frmComputers.cmbRAM3.Visible = True
                frmComputers.txtRamSN3.Visible = True
                frmComputers.txtRamS3.Visible = True
                frmComputers.PROizV8.Visible = True
                frmComputers.cmbRAM4.Visible = True
                frmComputers.txtRamSN4.Visible = True
                frmComputers.txtRamS4.Visible = True
                frmComputers.PROizV9.Visible = True
                frmComputers.cmbRAM5.Visible = True
                frmComputers.txtRamSN5.Visible = True
                frmComputers.txtRamS5.Visible = True
                frmComputers.PROizV44.Visible = True
                frmComputers.cmbRAM6.Visible = True
                frmComputers.txtRamSN6.Visible = True
                frmComputers.txtRamS6.Visible = True
                frmComputers.PROizV45.Visible = True
                frmComputers.cmbRAM6.Visible = True
                frmComputers.txtRamSN6.Visible = True
                frmComputers.txtRamS6.Visible = True
                frmComputers.PROizV45.Visible = True
                frmComputers.cmbRAM7.Visible = True
                frmComputers.txtRamSN7.Visible = True
                frmComputers.txtRamS7.Visible = True
                frmComputers.PROizV46.Visible = True
                If Not IsDBNull(.Fields("RAM_speed_8").Value) Then _
                    frmComputers.txtRamS8.Text = .Fields("RAM_speed_8").Value
                If Not IsDBNull(.Fields("RAM_SN_8").Value) Then frmComputers.txtRamSN8.Text = .Fields("RAM_SN_8").Value
                If Not IsDBNull(.Fields("RAM_PROIZV_8").Value) Then _
                    frmComputers.PROizV47.Text = .Fields("RAM_PROIZV_8").Value
            Else
                frmComputers.cmbRAM8.Visible = False
                frmComputers.txtRamSN8.Visible = False
                frmComputers.txtRamS8.Visible = False
                frmComputers.PROizV47.Visible = False

            End If

            'Жесткие диски

            If Not IsDBNull(.Fields("HDD_Name_1").Value) Then frmComputers.cmbHDD1.Text = .Fields("HDD_Name_1").Value
            If Not IsDBNull(.Fields("HDD_OB_1").Value) Then frmComputers.txtHDDo1.Text = .Fields("HDD_OB_1").Value
            If Not IsDBNull(.Fields("HDD_SN_1").Value) Then frmComputers.txtHDDsN1.Text = .Fields("HDD_SN_1").Value
            If Not IsDBNull(.Fields("HDD_PROIZV_1").Value) Then _
                frmComputers.PROizV10.Text = .Fields("HDD_PROIZV_1").Value
            frmComputers.sHDD = 1

            If Not IsDBNull(.Fields("HDD_Name_2").Value) And Len(.Fields("HDD_Name_2").Value) > 1 Then
                frmComputers.cmbHDD2.Text = .Fields("HDD_Name_2").Value
                frmComputers.sHDD = frmComputers.sHDD + 1
                frmComputers.cmbHDD2.Visible = True
                frmComputers.txtHDDo2.Visible = True
                frmComputers.txtHDDsN2.Visible = True
                frmComputers.PROizV11.Visible = True

                If Not IsDBNull(.Fields("HDD_OB_2").Value) Then frmComputers.txtHDDo2.Text = .Fields("HDD_OB_2").Value
                If Not IsDBNull(.Fields("HDD_SN_2").Value) Then frmComputers.txtHDDsN2.Text = .Fields("HDD_SN_2").Value
                If Not IsDBNull(.Fields("HDD_PROIZV_2").Value) Then _
                    frmComputers.PROizV11.Text = .Fields("HDD_PROIZV_2").Value

            Else
                frmComputers.cmbHDD2.Visible = False
                frmComputers.txtHDDo2.Visible = False
                frmComputers.txtHDDsN2.Visible = False
                frmComputers.PROizV11.Visible = False

            End If


            If Not IsDBNull(.Fields("HDD_Name_3").Value) And Len(.Fields("HDD_Name_3").Value) > 1 Then
                frmComputers.cmbHDD3.Text = .Fields("HDD_Name_3").Value
                frmComputers.sHDD = frmComputers.sHDD + 1
                frmComputers.cmbHDD3.Visible = True
                frmComputers.txtHDDo3.Visible = True
                frmComputers.txtHDDsN3.Visible = True
                frmComputers.PROizV12.Visible = True

                If Not IsDBNull(.Fields("HDD_OB_3").Value) Then frmComputers.txtHDDo3.Text = .Fields("HDD_OB_3").Value
                If Not IsDBNull(.Fields("HDD_SN_3").Value) Then frmComputers.txtHDDsN3.Text = .Fields("HDD_SN_3").Value
                If Not IsDBNull(.Fields("HDD_PROIZV_3").Value) Then _
                    frmComputers.PROizV12.Text = .Fields("HDD_PROIZV_3").Value

            Else
                frmComputers.cmbHDD3.Visible = False
                frmComputers.txtHDDo3.Visible = False
                frmComputers.txtHDDsN3.Visible = False
                frmComputers.PROizV12.Visible = False

            End If

            If Not IsDBNull(.Fields("HDD_Name_4").Value) And Len(.Fields("HDD_Name_4").Value) > 1 Then
                frmComputers.cmbHDD4.Text = .Fields("HDD_Name_4").Value
                frmComputers.sHDD = frmComputers.sHDD + 1
                'frmComputers.bHddPlus.Visible = False
                frmComputers.cmbHDD4.Visible = True
                frmComputers.txtHDDo4.Visible = True
                frmComputers.txtHDDsN4.Visible = True
                frmComputers.PROizV13.Visible = True

                If Not IsDBNull(.Fields("HDD_OB_4").Value) Then frmComputers.txtHDDo4.Text = .Fields("HDD_OB_4").Value
                If Not IsDBNull(.Fields("HDD_SN_4").Value) Then frmComputers.txtHDDsN4.Text = .Fields("HDD_SN_4").Value
                If Not IsDBNull(.Fields("HDD_PROIZV_4").Value) Then _
                    frmComputers.PROizV13.Text = .Fields("HDD_PROIZV_4").Value

            Else
                frmComputers.cmbHDD4.Visible = False
                frmComputers.txtHDDo4.Visible = False
                frmComputers.txtHDDsN4.Visible = False
                frmComputers.PROizV13.Visible = False

            End If

            If Not IsDBNull(.Fields("HDD_Name_5").Value) And Len(.Fields("HDD_Name_5").Value) > 1 Then
                frmComputers.cmbHDD5.Text = .Fields("HDD_Name_5").Value
                frmComputers.sHDD = frmComputers.sHDD + 1
                'frmComputers.bHddPlus.Visible = False
                frmComputers.cmbHDD5.Visible = True
                frmComputers.txtHDDo5.Visible = True
                frmComputers.txtHDDsN5.Visible = True
                frmComputers.PROizV48.Visible = True

                If Not IsDBNull(.Fields("HDD_OB_5").Value) Then frmComputers.txtHDDo5.Text = .Fields("HDD_OB_5").Value
                If Not IsDBNull(.Fields("HDD_SN_5").Value) Then frmComputers.txtHDDsN5.Text = .Fields("HDD_SN_5").Value
                If Not IsDBNull(.Fields("HDD_PROIZV_5").Value) Then _
                    frmComputers.PROizV48.Text = .Fields("HDD_PROIZV_5").Value

            Else
                frmComputers.cmbHDD5.Visible = False
                frmComputers.txtHDDo5.Visible = False
                frmComputers.txtHDDsN5.Visible = False
                frmComputers.PROizV48.Visible = False

            End If

            If Not IsDBNull(.Fields("HDD_Name_6").Value) And Len(.Fields("HDD_Name_6").Value) > 1 Then
                frmComputers.cmbHDD6.Text = .Fields("HDD_Name_6").Value
                frmComputers.sHDD = frmComputers.sHDD + 1
                'frmComputers.bHddPlus.Visible = False
                frmComputers.cmbHDD6.Visible = True
                frmComputers.txtHDDo6.Visible = True
                frmComputers.txtHDDsN6.Visible = True
                frmComputers.PROizV49.Visible = True

                If Not IsDBNull(.Fields("HDD_OB_6").Value) Then frmComputers.txtHDDo6.Text = .Fields("HDD_OB_6").Value
                If Not IsDBNull(.Fields("HDD_SN_6").Value) Then frmComputers.txtHDDsN6.Text = .Fields("HDD_SN_6").Value
                If Not IsDBNull(.Fields("HDD_PROIZV_6").Value) Then _
                    frmComputers.PROizV49.Text = .Fields("HDD_PROIZV_6").Value

            Else
                frmComputers.cmbHDD6.Visible = False
                frmComputers.txtHDDo6.Visible = False
                frmComputers.txtHDDsN6.Visible = False
                frmComputers.PROizV49.Visible = False

            End If

            If Not IsDBNull(.Fields("HDD_Name_7").Value) And Len(.Fields("HDD_Name_7").Value) > 1 Then
                frmComputers.cmbHDD7.Text = .Fields("HDD_Name_7").Value
                frmComputers.sHDD = frmComputers.sHDD + 1
                'frmComputers.bHddPlus.Visible = False
                frmComputers.cmbHDD7.Visible = True
                frmComputers.txtHDDo7.Visible = True
                frmComputers.txtHDDsN7.Visible = True
                frmComputers.PROizV50.Visible = True

                If Not IsDBNull(.Fields("HDD_OB_7").Value) Then frmComputers.txtHDDo7.Text = .Fields("HDD_OB_7").Value
                If Not IsDBNull(.Fields("HDD_SN_7").Value) Then frmComputers.txtHDDsN7.Text = .Fields("HDD_SN_7").Value
                If Not IsDBNull(.Fields("HDD_PROIZV_7").Value) Then _
                    frmComputers.PROizV49.Text = .Fields("HDD_PROIZV_7").Value

            Else
                frmComputers.cmbHDD7.Visible = False
                frmComputers.txtHDDo7.Visible = False
                frmComputers.txtHDDsN7.Visible = False
                frmComputers.PROizV50.Visible = False

            End If

            If Not IsDBNull(.Fields("HDD_Name_8").Value) And Len(.Fields("HDD_Name_8").Value) > 1 Then
                frmComputers.cmbHDD8.Text = .Fields("HDD_Name_8").Value
                frmComputers.sHDD = frmComputers.sHDD + 1
                'frmComputers.bHddPlus.Visible = False
                frmComputers.cmbHDD8.Visible = True
                frmComputers.txtHDDo8.Visible = True
                frmComputers.txtHDDsN8.Visible = True
                frmComputers.PROizV51.Visible = True

                If Not IsDBNull(.Fields("HDD_OB_8").Value) Then frmComputers.txtHDDo8.Text = .Fields("HDD_OB_8").Value
                If Not IsDBNull(.Fields("HDD_SN_8").Value) Then frmComputers.txtHDDsN8.Text = .Fields("HDD_SN_8").Value
                If Not IsDBNull(.Fields("HDD_PROIZV_8").Value) Then _
                    frmComputers.PROizV49.Text = .Fields("HDD_PROIZV_8").Value

            Else
                frmComputers.cmbHDD8.Visible = False
                frmComputers.txtHDDo8.Visible = False
                frmComputers.txtHDDsN8.Visible = False
                frmComputers.PROizV51.Visible = False

            End If

            'Видео карта
            If Not IsDBNull(.Fields("SVGA_NAME").Value) Then frmComputers.cmbSVGA1.Text = .Fields("SVGA_NAME").Value
            If Not IsDBNull(.Fields("SVGA_OB_RAM").Value) Then _
                frmComputers.txtSVGAr1.Text = .Fields("SVGA_OB_RAM").Value
            If Not IsDBNull(.Fields("SVGA_SN").Value) Then frmComputers.txtSVGAs1.Text = .Fields("SVGA_SN").Value
            If Not IsDBNull(.Fields("SVGA_PROIZV").Value) Then frmComputers.PROizV14.Text = .Fields("SVGA_PROIZV").Value

            frmComputers.sVGA = 1
            If Not IsDBNull(.Fields("SVGA2_NAME").Value) And Len(.Fields("SVGA2_NAME").Value) <> 0 Then
                frmComputers.cmbSVGA2.Text = .Fields("SVGA2_NAME").Value
                frmComputers.sVGA = 2
                frmComputers.bSVGAPlus.Visible = False
                frmComputers.cmbSVGA2.Visible = True
                frmComputers.txtSVGAs2.Visible = True
                frmComputers.txtSVGAr2.Visible = True
                frmComputers.PROizV15.Visible = True

                If Not IsDBNull(.Fields("SVGA2_OB_RAM").Value) Then _
                    frmComputers.txtSVGAr2.Text = .Fields("SVGA2_OB_RAM").Value
                If Not IsDBNull(.Fields("SVGA2_SN").Value) Then frmComputers.txtSVGAs2.Text = .Fields("SVGA2_SN").Value
                If Not IsDBNull(.Fields("SVGA2_PROIZV").Value) Then _
                    frmComputers.PROizV15.Text = .Fields("SVGA2_PROIZV").Value
            Else
                frmComputers.cmbSVGA2.Visible = False
                frmComputers.txtSVGAr2.Visible = False
                frmComputers.txtSVGAs2.Visible = False
                frmComputers.PROizV15.Visible = False

            End If


            'Звуковая карта

            If Not IsDBNull(.Fields("SOUND_NAME").Value) Then frmComputers.cmbSound.Text = .Fields("SOUND_NAME").Value
            'If Not IsDBNull(.fields("SVGA_OB_RAM").value) Then frmComputers.txtSoundB.Text = .fields("SVGA_OB_RAM").value
            If Not IsDBNull(.Fields("SOUND_SN").Value) Then frmComputers.txtSoundS.Text = .Fields("SOUND_SN").Value
            If Not IsDBNull(.Fields("SOUND_PROIZV").Value) Then _
                frmComputers.PROizV16.Text = .Fields("SOUND_PROIZV").Value

            'Оптические накопители

            If Not IsDBNull(.Fields("CD_NAME").Value) Then frmComputers.cmbOPTIC1.Text = .Fields("CD_NAME").Value
            If Not IsDBNull(.Fields("CD_SPEED").Value) Then frmComputers.txtOPTICs1.Text = .Fields("CD_SPEED").Value
            If Not IsDBNull(.Fields("CD_SN").Value) Then frmComputers.txtOPTICsn1.Text = .Fields("CD_SN").Value
            If Not IsDBNull(.Fields("CD_PROIZV").Value) Then frmComputers.PROizV17.Text = .Fields("CD_PROIZV").Value
            frmComputers.sOPTICAL = 1

            If Not IsDBNull(.Fields("CDRW_NAME").Value) And Len(.Fields("CDRW_NAME").Value) > 1 Then
                frmComputers.cmbOPTIC2.Text = .Fields("CDRW_NAME").Value
                frmComputers.sOPTICAL = 2
                frmComputers.cmbOPTIC2.Visible = True
                frmComputers.txtOPTICs2.Visible = True
                frmComputers.txtOPTICsn2.Visible = True
                frmComputers.PROizV18.Visible = True

                If Not IsDBNull(.Fields("CDRW_SPEED").Value) Then _
                    frmComputers.txtOPTICs2.Text = .Fields("CDRW_SPEED").Value
                If Not IsDBNull(.Fields("CDRW_SN").Value) Then frmComputers.txtOPTICsn2.Text = .Fields("CDRW_SN").Value
                If Not IsDBNull(.Fields("CDRW_PROIZV").Value) Then _
                    frmComputers.PROizV18.Text = .Fields("CDRW_PROIZV").Value
            Else
                frmComputers.cmbOPTIC2.Visible = False
                frmComputers.txtOPTICs2.Visible = False
                frmComputers.txtOPTICsn2.Visible = False
                frmComputers.PROizV18.Visible = False

            End If

            If Not IsDBNull(.Fields("DVD_NAME").Value) And Len(.Fields("DVD_NAME").Value) > 1 Then
                frmComputers.cmbOPTIC3.Text = .Fields("DVD_NAME").Value
                frmComputers.sOPTICAL = 2
                frmComputers.bOpticalPlus.Visible = False
                frmComputers.cmbOPTIC3.Visible = True
                frmComputers.txtOPTICs3.Visible = True
                frmComputers.txtOPTICsn3.Visible = True
                frmComputers.PROizV19.Visible = True

                If Not IsDBNull(.Fields("DVD_SPEED").Value) Then _
                    frmComputers.txtOPTICs3.Text = .Fields("DVD_SPEED").Value
                If Not IsDBNull(.Fields("DVD_SN").Value) Then frmComputers.txtOPTICsn3.Text = .Fields("DVD_SN").Value
                If Not IsDBNull(.Fields("DVD_PROIZV").Value) Then _
                    frmComputers.PROizV19.Text = .Fields("DVD_PROIZV").Value
            Else
                frmComputers.cmbOPTIC3.Visible = False
                frmComputers.txtOPTICs3.Visible = False
                frmComputers.txtOPTICsn3.Visible = False
                frmComputers.PROizV19.Visible = False

            End If

            'Сетевые карты
            If Not IsDBNull(.Fields("NET_NAME_1").Value) Then frmComputers.cmbNET1.Text = .Fields("NET_NAME_1").Value
            If Not IsDBNull(.Fields("NET_IP_1").Value) Then frmComputers.txtNETip1.Text = .Fields("NET_IP_1").Value
            If Not IsDBNull(.Fields("NET_MAC_1").Value) Then frmComputers.txtNETmac1.Text = .Fields("NET_MAC_1").Value
            If Not IsDBNull(.Fields("NET_PROIZV_1").Value) Then _
                frmComputers.PROizV20.Text = .Fields("NET_PROIZV_1").Value
            frmComputers.sNET = 1

            If Not IsDBNull(.Fields("NET_NAME_2").Value) And Len(.Fields("NET_NAME_2").Value) > 1 Then
                frmComputers.cmbNET2.Text = .Fields("NET_NAME_2").Value
                frmComputers.sNET = 2
                frmComputers.bNETPlus.Visible = False
                frmComputers.cmbNET2.Visible = True
                frmComputers.txtNETip2.Visible = True
                frmComputers.txtNETmac2.Visible = True
                frmComputers.PROizV21.Visible = True

                If Not IsDBNull(.Fields("NET_IP_2").Value) Then frmComputers.txtNETip2.Text = .Fields("NET_IP_2").Value
                If Not IsDBNull(.Fields("NET_MAC_2").Value) Then _
                    frmComputers.txtNETmac2.Text = .Fields("NET_MAC_2").Value
                If Not IsDBNull(.Fields("NET_PROIZV_2").Value) Then _
                    frmComputers.PROizV21.Text = .Fields("NET_PROIZV_2").Value
            Else
                frmComputers.cmbNET2.Visible = False
                frmComputers.txtNETip2.Visible = False
                frmComputers.txtNETmac2.Visible = False
                frmComputers.PROizV21.Visible = False

            End If


            'Дисковод
            If Not IsDBNull(.Fields("FDD_NAME").Value) Then frmComputers.cmbFDD.Text = .Fields("FDD_NAME").Value
            If Not IsDBNull(.Fields("FDD_SN").Value) Then frmComputers.txtSN.Text = .Fields("FDD_SN").Value
            'If Not IsDBNull(.fields("txtFDD_").value) Then frmComputers.txtFDD_.Text = .fields("txtFDD_").value
            If Not IsDBNull(.Fields("FDD_PROIZV").Value) Then frmComputers.PROizV22.Text = .Fields("FDD_PROIZV").Value

            'Кардридер
            If Not IsDBNull(.Fields("CREADER_NAME").Value) Then _
                frmComputers.cmbCreader.Text = .Fields("CREADER_NAME").Value
            If Not IsDBNull(.Fields("CREADER_SN").Value) Then _
                frmComputers.txtCreader1.Text = .Fields("CREADER_SN").Value
            If Not IsDBNull(.Fields("CREADER_PROIZV").Value) Then _
                frmComputers.PROizV23.Text = .Fields("CREADER_PROIZV").Value

            'Модем
            If Not IsDBNull(.Fields("MODEM_NAME").Value) Then frmComputers.cmbModem.Text = .Fields("MODEM_NAME").Value
            If Not IsDBNull(.Fields("MODEM_SN").Value) Then frmComputers.txtModemSN.Text = .Fields("MODEM_SN").Value
            'If Not IsDBNull(.fields("txtFDD_").value) Then frmComputers.txtModem2.Text = .fields("txtFDD_").value
            If Not IsDBNull(.Fields("MODEM_PROIZV").Value) Then _
                frmComputers.PROizV24.Text = .Fields("MODEM_PROIZV").Value

            'Корпус
            If Not IsDBNull(.Fields("CASE_NAME").Value) Then frmComputers.cmbCase.Text = .Fields("CASE_NAME").Value
            If Not IsDBNull(.Fields("CASE_SN").Value) Then frmComputers.txtCase1.Text = .Fields("CASE_SN").Value
            If Not IsDBNull(.Fields("CASE_PROIZV").Value) Then frmComputers.PROizV25.Text = .Fields("CASE_PROIZV").Value

            'Блок питания
            If Not IsDBNull(.Fields("BLOCK").Value) Then frmComputers.cmbBP.Text = .Fields("BLOCK").Value
            If Not IsDBNull(.Fields("SN_BLOCK").Value) Then frmComputers.txtBP1.Text = .Fields("SN_BLOCK").Value
            'If Not IsDBNull(.fields("txtFDD_").value) Then frmComputers.txtBP2.Text = .fields("txtFDD_").value
            If Not IsDBNull(.Fields("PROIZV_BLOCK").Value) Then _
                frmComputers.PROizV26.Text = .Fields("PROIZV_BLOCK").Value

            'Производитель системного блока
            If Not IsDBNull(.Fields("SYS_PR").Value) Then frmComputers.PROizV27.Text = .Fields("SYS_PR").Value

            'Серийный номер системного блока
            If Not IsDBNull(.Fields("Ser_N_SIS").Value) Then frmComputers.txtSNSB.Text = .Fields("Ser_N_SIS").Value

            'Модель системного блока
            If Not IsDBNull(.Fields("PATH").Value) Then frmComputers.txtModSB.Text = .Fields("PATH").Value

            'USB
            If Not IsDBNull(.Fields("USB_NAME").Value) Then frmComputers.cmbUSB.Text = .Fields("USB_NAME").Value
            If Not IsDBNull(.Fields("USB_SN").Value) Then frmComputers.txtUSBSN.Text = .Fields("USB_SN").Value
            If Not IsDBNull(.Fields("USB_PROIZV").Value) Then frmComputers.PROizV41.Text = .Fields("USB_PROIZV").Value

            'PCI
            If Not IsDBNull(.Fields("PCI_NAME").Value) Then frmComputers.cmbPCI.Text = .Fields("PCI_NAME").Value
            If Not IsDBNull(.Fields("PCI_SN").Value) Then frmComputers.txtSNPCI.Text = .Fields("PCI_SN").Value
            If Not IsDBNull(.Fields("PCI_PROIZV").Value) Then frmComputers.PROizV42.Text = .Fields("PCI_PROIZV").Value


            'Монитор
            '1
            If Not IsDBNull(.Fields("MONITOR_NAME").Value) Then _
                frmComputers.cmbMon1.Text = .Fields("MONITOR_NAME").Value
            If Not IsDBNull(.Fields("MONITOR_DUM").Value) Then _
                frmComputers.txtMon1Dum.Text = .Fields("MONITOR_DUM").Value
            If Not IsDBNull(.Fields("MONITOR_SN").Value) Then frmComputers.txtMon1SN.Text = .Fields("MONITOR_SN").Value
            If Not IsDBNull(.Fields("MONITOR_PROIZV").Value) Then _
                frmComputers.PROizV28.Text = .Fields("MONITOR_PROIZV").Value

            '2
            frmComputers.sMonitor = 1
            If Not IsDBNull(.Fields("MONITOR_NAME2").Value) And Len(.Fields("MONITOR_NAME2").Value) > 1 Then
                frmComputers.cmbMon2.Text = .Fields("MONITOR_NAME2").Value
                frmComputers.sMonitor = 2
                frmComputers.bMonitorPlus.Visible = False
                frmComputers.cmbMon2.Visible = True
                frmComputers.txtMon2Dum.Visible = True
                frmComputers.txtMon2SN.Visible = True
                frmComputers.PROizV29.Visible = True
                If Not IsDBNull(.Fields("MONITOR_DUM2").Value) Then _
                    frmComputers.txtMon2Dum.Text = .Fields("MONITOR_DUM2").Value
                If Not IsDBNull(.Fields("MONITOR_SN2").Value) Then _
                    frmComputers.txtMon2SN.Text = .Fields("MONITOR_SN2").Value
                If Not IsDBNull(.Fields("MONITOR_PROIZV2").Value) Then _
                    frmComputers.PROizV29.Text = .Fields("MONITOR_PROIZV2").Value
            Else
                frmComputers.cmbMon2.Visible = False
                frmComputers.txtMon2Dum.Visible = False
                frmComputers.txtMon2SN.Visible = False
                frmComputers.PROizV29.Visible = False

            End If


            'Клавиатура
            If Not IsDBNull(.Fields("KEYBOARD_NAME").Value) Then _
                frmComputers.cmbKeyb.Text = .Fields("KEYBOARD_NAME").Value
            If Not IsDBNull(.Fields("KEYBOARD_SN").Value) Then _
                frmComputers.txtKeybSN.Text = .Fields("KEYBOARD_SN").Value
            If Not IsDBNull(.Fields("KEYBOARD_PROIZV").Value) Then _
                frmComputers.PROizV30.Text = .Fields("KEYBOARD_PROIZV").Value

            'Мышь
            If Not IsDBNull(.Fields("MOUSE_NAME").Value) Then frmComputers.cmbMouse.Text = .Fields("MOUSE_NAME").Value
            If Not IsDBNull(.Fields("MOUSE_SN").Value) Then frmComputers.txtMouseSN.Text = .Fields("MOUSE_SN").Value
            If Not IsDBNull(.Fields("MOUSE_PROIZV").Value) Then _
                frmComputers.PROizV31.Text = .Fields("MOUSE_PROIZV").Value

            'Колонки

            If Not IsDBNull(.Fields("AS_NAME").Value) Then frmComputers.cmbAsist.Text = .Fields("AS_NAME").Value
            If Not IsDBNull(.Fields("AS_SN").Value) Then frmComputers.txtAsistSN.Text = .Fields("AS_SN").Value
            If Not IsDBNull(.Fields("AS_PROIZV").Value) Then frmComputers.PROizV32.Text = .Fields("AS_PROIZV").Value

            'Сетевой фильтр
            If Not IsDBNull(.Fields("FILTR_NAME").Value) Then frmComputers.cmbFilter.Text = .Fields("FILTR_NAME").Value
            If Not IsDBNull(.Fields("FILTR_SN").Value) Then frmComputers.txtFilterSN.Text = .Fields("FILTR_SN").Value
            If Not IsDBNull(.Fields("FILTR_PROIZV").Value) Then _
                frmComputers.PROizV33.Text = .Fields("FILTR_PROIZV").Value

            'ИБП
            If Not IsDBNull(.Fields("IBP_NAME").Value) Then frmComputers.cmbIBP.Text = .Fields("IBP_NAME").Value
            If Not IsDBNull(.Fields("IBP_SN").Value) Then frmComputers.txtSNIBP.Text = .Fields("IBP_SN").Value
            If Not IsDBNull(.Fields("IBP_PROIZV").Value) Then frmComputers.PROizV43.Text = .Fields("IBP_PROIZV").Value

            'Подключенные принтеры
            If Not IsDBNull(.Fields("PRINTER_NAME_1").Value) Then _
                frmComputers.cmbPrinters1.Text = .Fields("PRINTER_NAME_1").Value
            If Not IsDBNull(.Fields("PRINTER_SN_1").Value) Then _
                frmComputers.txtPrint1SN.Text = .Fields("PRINTER_SN_1").Value
            If Not IsDBNull(.Fields("PORT_1").Value) Then frmComputers.txtPrint1Port.Text = .Fields("PORT_1").Value
            If Not IsDBNull(.Fields("PRINTER_PROIZV_1").Value) Then _
                frmComputers.PROizV34.Text = .Fields("PRINTER_PROIZV_1").Value
            frmComputers.sPrinter = 1


            If Not IsDBNull(.Fields("PRINTER_NAME_2").Value) And Len(.Fields("PRINTER_NAME_2").Value) > 1 Then
                frmComputers.cmbPrinters2.Text = .Fields("PRINTER_NAME_2").Value
                frmComputers.sPrinter = 2
                frmComputers.cmbPrinters2.Visible = True
                frmComputers.txtPrint2SN.Visible = True
                frmComputers.txtPrint2Port.Visible = True
                frmComputers.PROizV35.Visible = True
                If Not IsDBNull(.Fields("PRINTER_SN_2").Value) Then _
                    frmComputers.txtPrint2SN.Text = .Fields("PRINTER_SN_2").Value
                If Not IsDBNull(.Fields("PORT_2").Value) Then frmComputers.txtPrint2Port.Text = .Fields("PORT_2").Value
                If Not IsDBNull(.Fields("PRINTER_PROIZV_2").Value) Then _
                    frmComputers.PROizV35.Text = .Fields("PRINTER_PROIZV_2").Value
            Else
                frmComputers.cmbPrinters2.Visible = False
                frmComputers.txtPrint2SN.Visible = False
                frmComputers.txtPrint2Port.Visible = False
                frmComputers.PROizV35.Visible = False

            End If


            If Not IsDBNull(.Fields("PRINTER_NAME_3").Value) And Len(.Fields("PRINTER_NAME_3").Value) > 1 Then
                frmComputers.cmbPrinters3.Text = .Fields("PRINTER_NAME_3").Value
                frmComputers.sPrinter = 3
                frmComputers.bPrinterPlus.Visible = False
                frmComputers.cmbPrinters3.Visible = True
                frmComputers.txtPrint3SN.Visible = True
                frmComputers.txtPrint3Port.Visible = True
                frmComputers.PROizV36.Visible = True
                If Not IsDBNull(.Fields("PRINTER_SN_3").Value) Then _
                    frmComputers.txtPrint3SN.Text = .Fields("PRINTER_SN_3").Value
                If Not IsDBNull(.Fields("PORT_3").Value) Then frmComputers.txtPrint3Port.Text = .Fields("PORT_3").Value
                If Not IsDBNull(.Fields("PRINTER_PROIZV_3").Value) Then _
                    frmComputers.PROizV36.Text = .Fields("PRINTER_PROIZV_3").Value
            Else
                frmComputers.cmbPrinters3.Visible = False
                frmComputers.txtPrint3SN.Visible = False
                frmComputers.txtPrint3Port.Visible = False
                frmComputers.PROizV36.Visible = False

            End If


            If Not IsDBNull(.Fields("NET_NAME").Value) Then frmComputers.txtSNAME.Text = .Fields("NET_NAME").Value
            If Not IsDBNull(.Fields("PSEVDONIM").Value) Then frmComputers.txtPSEUDONIM.Text = .Fields("PSEVDONIM").Value

            If Not IsDBNull(.Fields("FILIAL").Value) Then frmComputers.cmbBranch.Text = .Fields("FILIAL").Value
            If Not IsDBNull(.Fields("MESTO").Value) Then frmComputers.cmbDepartment.Text = .Fields("MESTO").Value
            If Not IsDBNull(.Fields("kabn").Value) Then frmComputers.cmbOffice.Text = .Fields("kabn").Value

            'sBranch = .Fields("FILIAL").Value
            'sDepartment = .Fields("MESTO").Value
            'sOffice = .Fields("kabn").Value
            sName = .Fields("NET_NAME").Value

            If Not IsDBNull(.Fields("OTvetstvennyj").Value) Then _
                frmComputers.cmbResponsible.Text = .Fields("OTvetstvennyj").Value
            If Not IsDBNull(.Fields("TELEPHONE").Value) Then frmComputers.txtPHONE.Text = .Fields("TELEPHONE").Value
            If Not IsDBNull(.Fields("TIP_COMPA").Value) Then _
                frmComputers.cmbAppointment.Text = .Fields("TIP_COMPA").Value

            If Not IsDBNull(.Fields("INV_NO_SYSTEM").Value) Then _
                frmComputers.txtSBSN.Text = .Fields("INV_NO_SYSTEM").Value
            If Not IsDBNull(.Fields("INV_NO_MONITOR").Value) Then _
                frmComputers.txtMSN.Text = .Fields("INV_NO_MONITOR").Value
            If Not IsDBNull(.Fields("INV_NO_IBP").Value) Then frmComputers.IN_IBP.Text = .Fields("INV_NO_IBP").Value
            If Not IsDBNull(.Fields("INV_NO_PRINTER").Value) Then _
                frmComputers.IN_PRN.Text = .Fields("INV_NO_PRINTER").Value

            If .Fields("TIP_COMPA").Value = "Сервер" Then
                frmComputers.ChkPDC.Visible = True
            Else
                frmComputers.ChkPDC.Visible = False
            End If


            Dim Gar As Boolean

            If Not IsDBNull(.Fields("Garantia_Sist").Value) Then Gar = .Fields("Garantia_Sist").Value

            Select Case Gar

                Case False
                    frmComputers.rbKompl.Checked = True
                    For Each C In frmComputers.sSTAB1.TabPages(0).Controls
                        If TypeOf C Is GroupBox Then C.Cursor = Cursors.Hand
                    Next C
                    For Each C In frmComputers.sSTAB1.TabPages(1).Controls
                        If TypeOf C Is GroupBox Then C.Cursor = Cursors.Hand
                    Next C
                    For Each C In frmComputers.sSTAB1.TabPages(2).Controls
                        If TypeOf C Is GroupBox Then C.Cursor = Cursors.Hand
                    Next C

                Case Else

                    frmComputers.rbSist.Checked = True
                    For Each C In frmComputers.sSTAB1.TabPages(0).Controls
                        If TypeOf C Is GroupBox Then C.Cursor = Cursors.Default
                    Next C
                    For Each C In frmComputers.sSTAB1.TabPages(1).Controls
                        If TypeOf C Is GroupBox Then C.Cursor = Cursors.Default
                    Next C

                    For Each C In frmComputers.sSTAB1.TabPages(2).Controls
                        If TypeOf C Is GroupBox Then C.Cursor = Cursors.Default
                    Next C

                    Call LOAD_GARs(sID, frmComputers.cmbPostav, frmComputers.dtGPr, frmComputers.dtGok)

            End Select

            If Not IsDBNull(.Fields("SFAktNo").Value) Then frmComputers.txtPCSfN.Text = .Fields("SFAktNo").Value
            If Not IsDBNull(.Fields("CenaRub").Value) Then frmComputers.txtPCcash.Text = .Fields("CenaRub").Value
            If Not IsDBNull(.Fields("StoimRub").Value) Then frmComputers.txtPCSumm.Text = .Fields("StoimRub").Value
            If Not IsDBNull(.Fields("Zaiavk").Value) Then frmComputers.txtPCZay.Text = .Fields("Zaiavk").Value

            If Not IsDBNull(.Fields("DataVVoda").Value) Then _
                frmComputers.dtPCdataVvoda.Value = .Fields("DataVVoda").Value
            If Not IsDBNull(.Fields("dataSF").Value) Then frmComputers.dtPCSFdate.Value = .Fields("dataSF").Value

            If Not IsDBNull(.Fields("Spisan").Value) Then frmComputers.chkPCspis.Checked = .Fields("Spisan").Value

            Select Case frmComputers.chkPCspis.Checked

                Case True
                    frmComputers.dtSpisanie.Visible = True
                    If Not IsDBNull(.Fields("data_sp").Value) Then frmComputers.dtSpisanie.Value = .Fields("data_sp").Value Else frmComputers.dtSpisanie.Value = Date.Today
                Case False
                    frmComputers.dtSpisanie.Visible = False
            End Select


            If Not IsDBNull(.Fields("Balans").Value) Then frmComputers.chkPCNNb.Checked = .Fields("Balans").Value

            If Not IsDBNull(.Fields("PCL").Value) Then

                unaPCL = .Fields("PCL").Value

            Else

                unaPCL = 0

            End If


            'Получаем номер розетки если он есть

            Dim rs1 As Recordset
            rs1 = New Recordset
            rs1.Open("SELECT count(*) as t_n FROM TBL_NET_MAG WHERE SVT=" & .Fields("id").Value, DB7,
                     CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic)

            Dim UCount As Integer

            With rs1
                UCount = .Fields("t_n").Value
            End With
            rs1.Close()
            rs1 = Nothing

            Select Case UCount

                Case 0
                    frmComputers.Label89.Visible = False
                    frmComputers.lblNumberNET.Visible = False
                Case Else

                    frmComputers.Label89.Visible = True
                    frmComputers.lblNumberNET.Visible = True

                    rs1 = New Recordset
                    rs1.Open("SELECT id_line FROM TBL_NET_MAG WHERE SVT=" & .Fields("id").Value, DB7,
                             CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic)

                    With rs1
                        frmComputers.lblNumberNET.Text = .Fields("id_line").Value
                    End With
                    rs1.Close()
                    rs1 = Nothing

            End Select


        End With

        rs.Close()
        rs = Nothing

        If unaPCL = 0 Then

        Else

            rs = New Recordset
            rs.Open("Select NET_NAME From kompy where id=" & unaPCL, DB7, CursorTypeEnum.adOpenDynamic,
                    LockTypeEnum.adLockOptimistic)

            With rs

                frmComputers.cmbPCLK.Text = .Fields("NET_NAME").Value

            End With
            rs.Close()
            rs = Nothing
        End If

        '#############################################
        'Проверка есть ли контейнеры в справочнике
        '#############################################

        sSQL = "SELECT count(*) as t_n from spr_other where C='1'"
        rs = New Recordset
        rs.Open(sSQL, DB7, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic)

        Dim A1 As String
        With rs
            A1 = .Fields("t_n").Value
        End With
        rs.Close()
        rs = Nothing

        Select Case A1
            Case 0
                frmComputers.cmbPCLK.Visible = False
                frmComputers.Label88.Visible = False

            Case Else
                frmComputers.cmbPCLK.Visible = True
                frmComputers.Label88.Visible = True

                Call _
                    LOAD_PCL(frmComputers.cmbBranch.Text, frmComputers.cmbDepartment.Text, frmComputers.cmbOffice.Text,
                             frmComputers.cmbPCLK, frmComputers.cmbResponsible.Text, frmComputers.sCOUNT)
        End Select

        '#############################################
        '#############################################
        '#############################################


        'Call LOAD_SOFT(sID, frmComputers.lstSoftware)
        'Call LOAD_USER(sID)
        'Call LOAD_NOTES(sID, frmComputers.lvNotes)
        'Call LOAD_REPAIR(sID, frmComputers.lvRepair)
        'Call LOAD_DVIG_TEHN(sID, frmComputers.lvMovement)


        'frmComputers.IN_PRN.Text = frmComputers.IN_PRN.Font.Size & "," & frmComputers.IN_PRN.Font.Style
    End Sub

    Public Sub LOADmon(ByVal sID As String)
        On Error Resume Next
        Dim unaPCL As Integer
        Dim rs As Recordset 'Объявляем рекордсет
        Dim sSQL As String 'Переменная, где будет размещён SQL запрос

        sSQL = "SELECT * FROM kompy WHERE id =" & sID
        rs = New Recordset
        rs.Open(sSQL, DB7, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic)

        With rs
            frmComputers.lblsIDOTH.Text = .Fields("id").Value

            ' If Not IsDBNull(.Fields("MONITOR_NAME").Value) Then frmComputers.cmbOTH.Text = .Fields("MONITOR_NAME").Value

            If Not IsDBNull(.Fields("NET_NAME").Value) Then frmComputers.cmbOTH.Text = .Fields("NET_NAME").Value
           
            If Not IsDBNull(.Fields("MONITOR_DUM").Value) Then frmComputers.txtMonDum.Text = .Fields("MONITOR_DUM").Value
            If Not IsDBNull(.Fields("MONITOR_SN").Value) Then frmComputers.txtOTHSN.Text = .Fields("MONITOR_SN").Value
            If Not IsDBNull(.Fields("MONITOR_PROIZV").Value) Then frmComputers.PROiZV39.Text = .Fields("MONITOR_PROIZV").Value
            If Not IsDBNull(.Fields("OTvetstvennyj").Value) Then frmComputers.cmbOTHotv.Text = .Fields("OTvetstvennyj").Value
            If Not IsDBNull(.Fields("INV_NO_MONITOR").Value) Then frmComputers.txtOTHinnumber.Text = .Fields("INV_NO_MONITOR").Value
            If Not IsDBNull(.Fields("port_1").Value) Then frmComputers.txtOTHmemo.Text = .Fields("port_1").Value

            'txtOTHmemo

            If Not IsDBNull(.Fields("FILIAL").Value) Then frmComputers.cmbOTHFil.Text = .Fields("FILIAL").Value
            If Not IsDBNull(.Fields("MESTO").Value) Then frmComputers.cmbOTHDepart.Text = .Fields("MESTO").Value
            If Not IsDBNull(.Fields("kabn").Value) Then frmComputers.cmbOTHOffice.Text = .Fields("kabn").Value

            'sName = .Fields("PRINTER_NAME_1").Value

            'If Not IsDBNull(.Fields("NET_IP_1").Value) Then frmComputers.txtOTHIP.Text = .Fields("NET_IP_1").Value
            'If Not IsDBNull(.Fields("NET_MAC_1").Value) Then frmComputers.txtOTHMAC.Text = .Fields("NET_MAC_1").Value
            'If Not IsDBNull(.Fields("TIP_COMPA").Value) Then frmComputers.cmbOTHConnect.Text = .Fields("TIP_COMPA").Value

            frmComputers.txtOTHphone.Text = .Fields("TELEPHONE").Value


            If Not IsDBNull(.Fields("SFAktNo").Value) Then frmComputers.txtOTHSfN.Text = .Fields("SFAktNo").Value
            If Not IsDBNull(.Fields("CenaRub").Value) Then frmComputers.txtOTHcash.Text = .Fields("CenaRub").Value
            If Not IsDBNull(.Fields("StoimRub").Value) Then frmComputers.txtOTHSumm.Text = .Fields("StoimRub").Value
            If Not IsDBNull(.Fields("Zaiavk").Value) Then frmComputers.txtOTHZay.Text = .Fields("Zaiavk").Value

            If Not IsDBNull(.Fields("DataVVoda").Value) Then _
                frmComputers.dtOTHdataVvoda.Value = .Fields("DataVVoda").Value
            If Not IsDBNull(.Fields("dataSF").Value) Then frmComputers.dtOTHSFdate.Value = .Fields("dataSF").Value

            If Not IsDBNull(.Fields("Spisan").Value) Then frmComputers.chkOTHspis.Checked = .Fields("Spisan").Value
            If Not IsDBNull(.Fields("Balans").Value) Then frmComputers.chkOTHNNb.Checked = .Fields("Balans").Value

            If Not IsDBNull(.Fields("PCL").Value) Then
                unaPCL = .Fields("PCL").Value
            Else
                unaPCL = 0

            End If


            Select Case frmComputers.chkOTHspis.Checked

                Case True
                    frmComputers.dtOTHSpisanie.Visible = True
                    If Not IsDBNull(.Fields("data_sp").Value) Then frmComputers.dtOTHSpisanie.Value = .Fields("data_sp").Value Else frmComputers.dtOTHSpisanie.Value = Date.Today
                Case False
                    frmComputers.dtOTHSpisanie.Visible = False
            End Select

        End With

        rs.Close()
        rs = Nothing


        If unaPCL = 0 Then

        Else

            rs = New Recordset
            rs.Open("Select NET_NAME From kompy where id=" & unaPCL, DB7, CursorTypeEnum.adOpenDynamic,
                    LockTypeEnum.adLockOptimistic)

            With rs

                frmComputers.cmbOTHPCL.Text = .Fields("NET_NAME").Value

            End With
            rs.Close()
            rs = Nothing
        End If


        Call LOAD_GARs(sID, frmComputers.cmbOTHPostav, frmComputers.dtGOTHPr, frmComputers.dtGOTHok)
        'Call LOAD_NOTES(sID, frmComputers.lvNotesOTH)
        'Call LOAD_REPAIR(sID, frmComputers.lvRepairOTH)
        'Call LOAD_DVIG_TEHN(sID, frmComputers.lvMovementOTH)
    End Sub

    Public Sub LOAD_SOFT(ByVal sID As String, ByVal lstSoftware As ListView)
        On Error Resume Next
        lstSoftware.Items.Clear()

        lstSoftware.Sorting = SortOrder.None
        lstSoftware.ListViewItemSorter = Nothing


        Dim rs As Recordset 'Объявляем рекордсет
        Dim sSQL As String 'Переменная, где будет размещён SQL запрос

        sSQL = "SELECT * FROM SOFT_INSTALL WHERE Id_Comp =" & sID &
               " and Soft not like '%update%' and Soft not like '%Обновление%' ORDER BY Soft, NomerSoftKomp"
        rs = New Recordset
        rs.Open(sSQL, DB7, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic)

        Dim intCount As Decimal = 0

        With rs
            .MoveFirst()
            Do While Not .EOF

                lstSoftware.Items.Add(.Fields("id").Value) 'col no. 1

                If Not IsDBNull(.Fields("Soft").Value) Then _
                    lstSoftware.Items(CInt(intCount)).SubItems.Add(.Fields("Soft").Value)

                If Not IsDBNull(.Fields("VERS").Value) Then
                    lstSoftware.Items(CInt(intCount)).SubItems.Add(.Fields("VERS").Value)
                Else 'esq
                    lstSoftware.Items(CInt(intCount)).SubItems.Add("")
                End If

                If (Not IsDBNull(.Fields("L_key").Value)) And (.Fields("L_key").Value <> "") Then
                    lstSoftware.Items(CInt(intCount)).SubItems.Add(.Fields("L_key").Value)
                Else
                    lstSoftware.Items(CInt(intCount)).SubItems.Add("")
                End If

                If Not IsDBNull(.Fields("t_lic").Value) Then
                    lstSoftware.Items(CInt(intCount)).SubItems.Add(.Fields("t_lic").Value)
                Else
                    lstSoftware.Items(CInt(intCount)).SubItems.Add("")
                End If
                If Not IsDBNull(.Fields("d_p").Value) Then
                    lstSoftware.Items(CInt(intCount)).SubItems.Add(.Fields("d_p").Value)
                Else
                    lstSoftware.Items(CInt(intCount)).SubItems.Add("")
                End If
                If Not IsDBNull(.Fields("d_o").Value) Then
                    lstSoftware.Items(CInt(intCount)).SubItems.Add(.Fields("d_o").Value)
                Else
                    lstSoftware.Items(CInt(intCount)).SubItems.Add("")
                End If

                If Not IsDBNull(.Fields("Publisher").Value) Then
                    lstSoftware.Items(CInt(intCount)).SubItems.Add(.Fields("Publisher").Value)
                Else
                    lstSoftware.Items(CInt(intCount)).SubItems.Add("")
                End If

                If Not IsDBNull(.Fields("TIP").Value) Then
                    lstSoftware.Items(CInt(intCount)).SubItems.Add(.Fields("TIP").Value)
                Else
                    lstSoftware.Items(CInt(intCount)).SubItems.Add("")
                End If

                intCount = intCount + 1
                .MoveNext()
            Loop
        End With

        rs.Close()
        rs = Nothing

        ResList(lstSoftware)
    End Sub

    Public Sub LOAD_USER(ByVal sID As String)
        On Error Resume Next
        frmComputers.lstUsers.Items.Clear()

        Dim rs As Recordset 'Объявляем рекордсет
        Dim sSQL As String 'Переменная, где будет размещён SQL запрос

        sSQL = "SELECT * FROM USER_COMP WHERE Id_Comp =" & sID & " ORDER BY USERNAME"
        rs = New Recordset
        rs.Open(sSQL, DB7, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic)

        Dim intCount As Decimal = 0

        With rs
            .MoveFirst()
            Do While Not .EOF
                frmComputers.lstUsers.Items.Add(.Fields("id").Value) 'col no. 1

                If Not IsDBNull(.Fields("FIO").Value) Then
                    frmComputers.lstUsers.Items(CInt(intCount)).SubItems.Add(.Fields("FIO").Value)
                Else
                    frmComputers.lstUsers.Items(CInt(intCount)).SubItems.Add("")
                End If

                If Not IsDBNull(.Fields("USERNAME").Value) Then
                    frmComputers.lstUsers.Items(CInt(intCount)).SubItems.Add(.Fields("USERNAME").Value)
                Else
                    frmComputers.lstUsers.Items(CInt(intCount)).SubItems.Add("")
                End If

                If Not IsDBNull(.Fields("EMAIL").Value) Then
                    frmComputers.lstUsers.Items(CInt(intCount)).SubItems.Add(.Fields("EMAIL").Value)
                Else
                    frmComputers.lstUsers.Items(CInt(intCount)).SubItems.Add("")
                End If

                If Not IsDBNull(.Fields("icq").Value) Then
                    frmComputers.lstUsers.Items(CInt(intCount)).SubItems.Add(.Fields("icq").Value)
                Else
                    frmComputers.lstUsers.Items(CInt(intCount)).SubItems.Add("")
                End If

                If Not IsDBNull(.Fields("jabber").Value) Then
                    frmComputers.lstUsers.Items(CInt(intCount)).SubItems.Add(.Fields("jabber").Value)
                Else
                    frmComputers.lstUsers.Items(CInt(intCount)).SubItems.Add("")
                End If

                intCount = intCount + 1
                .MoveNext()
            Loop
        End With

        rs.Close()
        rs = Nothing

        ResList(frmComputers.lstUsers)
    End Sub

    Public Sub LOAD_NOTES(ByVal sID As String, ByVal lstGroups As ListView)
        On Error Resume Next
        lstGroups.Items.Clear()

        Dim rs As Recordset 'Объявляем рекордсет
        Dim sSQL As String 'Переменная, где будет размещён SQL запрос
        sSQL = "SELECT * FROM Zametki WHERE Id_Comp =" & sID & " ORDER BY D_T DESC, id DESC"
        rs = New Recordset
        rs.Open(sSQL, DB7, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic)

        Dim intCount As Decimal = 0

        With rs
            .MoveFirst()
            Do While Not .EOF
                lstGroups.Items.Add(.Fields("id").Value) 'col no. 1

                If Not IsDBNull(.Fields("NomerZamKomp").Value) Then
                    lstGroups.Items(CInt(intCount)).SubItems.Add(.Fields("NomerZamKomp").Value)
                Else
                    lstGroups.Items(CInt(intCount)).SubItems.Add("")
                End If

                If Not IsDBNull(.Fields("D_T").Value) Then
                    lstGroups.Items(CInt(intCount)).SubItems.Add(.Fields("D_T").Value)
                Else
                    lstGroups.Items(CInt(intCount)).SubItems.Add("")
                End If

                If Not IsDBNull(.Fields("Zametki").Value) Then
                    lstGroups.Items(CInt(intCount)).SubItems.Add(.Fields("Zametki").Value)
                Else
                    lstGroups.Items(CInt(intCount)).SubItems.Add("")
                End If

                If Not IsDBNull(.Fields("Master").Value) Then
                    lstGroups.Items(CInt(intCount)).SubItems.Add(.Fields("Master").Value)
                Else
                    lstGroups.Items(CInt(intCount)).SubItems.Add("")
                End If

                intCount = intCount + 1
                .MoveNext()
            Loop
        End With

        rs.Close()
        rs = Nothing
        ResList(lstGroups)
    End Sub

    Public Sub LOAD_REPAIR(ByVal sID As String, ByVal lstGroups As ListView)
        On Error Resume Next
        lstGroups.Items.Clear()

        If frmserviceDesc.ilsCMD.Images.Count = 0 Then

            Call frmservills_load()

        End If

        lstGroups.Sorting = SortOrder.None
        lstGroups.ListViewItemSorter = Nothing

        Dim rs As Recordset 'Объявляем рекордсет
        Dim sSQL As String 'Переменная, где будет размещён SQL запрос
        Dim uname As Integer

        rs = New Recordset
        sSQL = "SELECT COUNT(*) AS t_number FROM Remont WHERE id_comp=" & sID & " AND PREF='" & frmComputers.sPREF & "'"
        rs.Open(sSQL, DB7, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic)

        With rs
            uname = .Fields("t_number").Value
        End With
        rs.Close()
        rs = Nothing

        ResList(lstGroups)

        If uname = 0 Then Exit Sub

        Dim tID As Long

        'Dim rs As ADODB.Recordset 'Объявляем рекордсет
        'Dim sSQL As String 'Переменная, где будет размещён SQL запрос
        sSQL = "SELECT * FROM Remont WHERE id_comp=" & sID & " and PREF='" & frmComputers.sPREF &
               "' ORDER BY D_T DESC, id DESC"
        rs = New Recordset
        rs.Open(sSQL, DB7, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic)

        Dim intCount As Decimal = 0

        'intCount = 0
        'intCount = 0

        lstGroups.SmallImageList = frmserviceDesc.ilsCMD

        'Dim uname As Integer

        With rs
            .MoveFirst()
            Do While Not .EOF

                If .Fields("zakryt").Value = 1 Or .Fields("zakryt").Value = True Then

                    uname = 0
                Else
                    uname = 1

                End If

                Dim item As ListViewItem = lstGroups.Items.Add(.Fields("id").Value)
                item.ImageIndex = uname

                Select Case uname

                    Case 0

                    Case 1

                        lstGroups.Items(CInt(intCount)).ForeColor = Color.FromName(ServiceColor)
                        lstGroups.Items(CInt(intCount)).BackColor = Color.Olive

                End Select

                'lstGroups.Items.Add(.Fields("id").Value) 'col no. 1

                tID = .Fields("id").Value

                If Not IsDBNull(.Fields("NomerRemKomp").Value) Then
                    lstGroups.Items(CInt(intCount)).SubItems.Add(.Fields("NomerRemKomp").Value)
                Else
                    lstGroups.Items(CInt(intCount)).SubItems.Add("")
                End If

                If Not IsDBNull(.Fields("D_T").Value) Then
                    lstGroups.Items(CInt(intCount)).SubItems.Add(.Fields("D_T").Value)
                Else
                    lstGroups.Items(CInt(intCount)).SubItems.Add("")
                End If

                If Not IsDBNull(.Fields("name_of_remont").Value) Then

                    If Len(.Fields("name_of_remont").Value) = 0 Then

                        lstGroups.Items(CInt(intCount)).SubItems.Add(Left(.Fields("Remont").Value, 35) & "...")
                    Else
                        's = Right(.Fields("name_of_remont").Value, 50)
                        lstGroups.Items(CInt(intCount)).SubItems.Add(.Fields("name_of_remont").Value)
                    End If
                Else
                    lstGroups.Items(CInt(intCount)).SubItems.Add("")
                End If


                If Not IsDBNull(.Fields("Uroven").Value) Then
                    lstGroups.Items(CInt(intCount)).SubItems.Add(.Fields("Uroven").Value)
                Else
                    lstGroups.Items(CInt(intCount)).SubItems.Add("")
                End If

                If Not IsDBNull(.Fields("Master").Value) Then
                    lstGroups.Items(CInt(intCount)).SubItems.Add(.Fields("Master").Value)
                Else
                    lstGroups.Items(CInt(intCount)).SubItems.Add("")
                End If

                If Not IsDBNull(.Fields("vip").Value) Then
                    lstGroups.Items(CInt(intCount)).SubItems.Add(.Fields("vip").Value)
                Else
                    lstGroups.Items(CInt(intCount)).SubItems.Add("")
                End If

                If Not IsDBNull(.Fields("srok").Value) Then
                    lstGroups.Items(CInt(intCount)).SubItems.Add(.Fields("srok").Value)
                Else
                    lstGroups.Items(CInt(intCount)).SubItems.Add("")
                End If

                If Not IsDBNull(.Fields("User_Name").Value) Then
                    lstGroups.Items(CInt(intCount)).SubItems.Add(.Fields("User_Name").Value)
                Else
                    lstGroups.Items(CInt(intCount)).SubItems.Add("")
                End If

                Dim rs1 As Recordset 'Объявляем рекордсет
                Dim sSQL1 As String 'Переменная, где будет размещён SQL запрос
                sSQL1 = "SELECT COUNT(*) as t_n FROM remonty_plus WHERE id_rem =" & tID
                rs1 = New Recordset
                rs1.Open(sSQL1, DB7, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic)

                With rs1
                    If Not IsDBNull(.Fields("t_n").Value) Then
                        lstGroups.Items(CInt(intCount)).SubItems.Add(.Fields("t_n").Value)
                    Else
                        lstGroups.Items(CInt(intCount)).SubItems.Add("0")
                    End If
                End With

                rs1.Close()
                rs1 = Nothing

                intCount = intCount + 1
                .MoveNext()
            Loop
        End With

        rs.Close()
        rs = Nothing

        ResList(lstGroups)
    End Sub

    Public Sub LOAD_DVIG_TEHN(ByVal sID As String, ByVal lstGroup As ListView)
        On Error Resume Next
        Dim sNom As Integer
        lstGroup.Items.Clear()

        Dim rscount As Recordset 'Объявляем рекордсет
        rscount = New Recordset
        rscount.Open("SELECT COUNT(*) AS total_number FROM dvig where id_comp=" & frmComputers.sCOUNT, DB7,
                     CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic)

        With rscount

            sNom = .Fields("total_number").Value

        End With

        rscount.Close()
        rscount = Nothing

        ResList(lstGroup)


        Select Case sNom
            Case 0


            Case Else
                Dim rs As Recordset 'Объявляем рекордсет
                Dim sSQL As String 'Переменная, где будет размещён SQL запрос

                sSQL = "SELECT ID_comp, D_T, id, oldmesto, newmesto, prich, T_M FROM dvig where id_comp=" &
                       frmComputers.sCOUNT
                rs = New Recordset
                rs.Open(sSQL, DB7, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic)

                Dim intCount As Decimal = 0
                With rs
                    .MoveFirst()
                    Do While Not .EOF
                        'NomR = .Fields(0)
                        lstGroup.Items.Add(.Fields("id").Value) 'col no. 1

                        If Not IsDBNull(.Fields("oldmesto").Value) Then
                            lstGroup.Items(CInt(intCount)).SubItems.Add(.Fields("oldmesto").Value)
                        Else
                            lstGroup.Items(CInt(intCount)).SubItems.Add("")
                        End If

                        If Not IsDBNull(.Fields("newmesto").Value) Then
                            lstGroup.Items(CInt(intCount)).SubItems.Add(.Fields("newmesto").Value)
                        Else
                            lstGroup.Items(CInt(intCount)).SubItems.Add("")
                        End If

                        If Not IsDBNull(.Fields("prich").Value) Then
                            lstGroup.Items(CInt(intCount)).SubItems.Add(.Fields("prich").Value)
                        Else
                            lstGroup.Items(CInt(intCount)).SubItems.Add("")
                        End If

                        If Not IsDBNull(.Fields("D_T").Value) Then
                            lstGroup.Items(CInt(intCount)).SubItems.Add(.Fields("D_T").Value)
                        Else
                            lstGroup.Items(CInt(intCount)).SubItems.Add("")
                        End If

                        If Not IsDBNull(.Fields("T_M").Value) Then
                            lstGroup.Items(CInt(intCount)).SubItems.Add(.Fields("T_M").Value)
                        Else
                            lstGroup.Items(CInt(intCount)).SubItems.Add("")
                        End If

                        intCount = intCount + 1

                        .MoveNext()
                        'DoEvents
                    Loop
                End With

                rs.Close()
                rs = Nothing

                ResList(lstGroup)

        End Select

    End Sub

    Private Sub LOAD_GARs(ByVal sID As String, ByVal dPost As ComboBox, ByVal dtp As DateTimePicker,
                          ByVal dto As DateTimePicker)

        Dim rsGa As Recordset
        Dim A, B, C As String
        Dim dDate As Date
        rsGa = New Recordset

        rsGa.Open("SELECT * FROM Garantia_sis WHERE id_Comp=" & sID, DB7, CursorTypeEnum.adOpenDynamic,
                  LockTypeEnum.adLockOptimistic)

        With rsGa

            If Not IsDBNull(.Fields("Postav").Value) Then dPost.Text = .Fields("Postav").Value
            If Not IsDBNull(.Fields("den").Value) Then A = .Fields("den").Value
            If Not IsDBNull(.Fields("mesiac").Value) Then B = .Fields("mesiac").Value
            If Not IsDBNull(.Fields("god").Value) Then C = .Fields("god").Value

            dDate = A & "." & B & "." & C
            dtp.Value = dDate

            If Not IsDBNull(.Fields("Day_O").Value) Then A = .Fields("Day_O").Value
            If Not IsDBNull(.Fields("Month_O").Value) Then B = .Fields("Month_O").Value
            If Not IsDBNull(.Fields("Year_O").Value) Then C = .Fields("Year_O").Value

            dDate = A & "." & B & "." & C

            dto.Value = dDate

        End With
        rsGa.Close()
        rsGa = Nothing
    End Sub

    Public Sub LOAD_INF_BRANCHE(ByVal sID As String)
        'Dim sSQL As String
        'On Error GoTo err_
        frmComputers.lvNotesBR.Items.Clear()

        TipTehn = ""

        Dim SerD As String
        Dim rs As Recordset


        Select Case frmComputers.sPREF

            Case "G"

                SerD = sID & "F"


            Case "O"

                SerD = sID & "O_F"

            Case "K"
                SerD = sID & "K"

        End Select

        Dim sSQL As String
        Dim sCN As String
        Dim sSQL1 As String
        Dim sSQL2 As String
        Dim sSQL3 As String


        sSQL1 = "Select * FROM SES_Pass where id_OF='" & SerD & "'"
        sSQL2 = "Select * FROM OTD_O where Id_OTD='" & SerD & "'"


        sSQL = "Select count(*) as t_n FROM SES_Pass where id_OF='" & SerD & "'"

        rs = New Recordset
        rs.Open(sSQL, DB7, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic)

        With rs
            sCN = .Fields("t_n").Value
        End With
        rs.Close()
        rs = Nothing

        Select Case sCN

            Case 0

            Case Else

                rs = New Recordset
                rs.Open(sSQL1, DB7, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic)

                With rs
                    frmComputers.txtspplo.Text = .Fields("Ploshad").Value
                    frmComputers.txtspvis.Text = .Fields("visota").Value
                    frmComputers.txtspPloOneEVM.Text = .Fields("Pl1Pk").Value
                    frmComputers.txtspObOneEVM.Text = .Fields("ob1Pk").Value
                    frmComputers.cmbSpRemEVM.Text = .Fields("nalpom").Value
                    frmComputers.cmbSpVent.Text = .Fields("vent").Value
                    frmComputers.cmbSpWater.Text = .Fields("voda").Value
                    frmComputers.cmbSpTeplo.Text = .Fields("kanal").Value
                    frmComputers.cmbSpKanal.Text = .Fields("teplo").Value
                    frmComputers.txtSpWall.Text = .Fields("otdelka").Value
                    frmComputers.txtSpMebel.Text = .Fields("mebel").Value
                End With

                rs.Close()
                rs = Nothing

        End Select


        sSQL = "Select count(*) as t_n FROM OTD_O where Id_OTD='" & SerD & "'"
        rs = New Recordset
        rs.Open(sSQL, DB7, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic)

        With rs
            sCN = .Fields("t_n").Value
        End With
        rs.Close()
        rs = Nothing

        Select Case sCN

            Case 0

            Case Else

                rs = New Recordset
                rs.Open(sSQL2, DB7, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic)

                With rs
                    frmComputers.txtBRAddress.Text = .Fields("ADRESS").Value
                    frmComputers.txtBRBoss.Text = .Fields("OTV").Value
                    frmComputers.txtBRPhone.Text = .Fields("Phone").Value

                    If Not IsDBNull(.Fields("Prim").Value) Then
                        frmComputers.txtBRMemo.Text = .Fields("Prim").Value
                    Else
                        frmComputers.txtBRMemo.Text = ""
                    End If

                End With

                rs.Close()
                rs = Nothing

        End Select

        sSQL = "Select count(*) as t_n FROM ZAM_OTD where ID_OTD='" & SerD & "'"
        rs = New Recordset
        rs.Open(sSQL, DB7, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic)

        With rs
            sCN = .Fields("t_n").Value
        End With
        rs.Close()
        rs = Nothing

        Select Case sCN

            Case 0

            Case Else
                sSQL3 = "Select * FROM ZAM_OTD where ID_OTD='" & SerD & "' ORDER BY D_T DESC, id DESC"

                rs = New Recordset
                rs.Open(sSQL3, DB7, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic)

                Dim intCount As Decimal = 0

                With rs
                    .MoveFirst()
                    Do While Not .EOF
                        frmComputers.lvNotesBR.Items.Add(.Fields("id").Value) 'col no. 1

                        If Not IsDBNull(.Fields("ID_ZAM").Value) Then
                            frmComputers.lvNotesBR.Items(CInt(intCount)).SubItems.Add(.Fields("ID_ZAM").Value)
                        Else
                            frmComputers.lvNotesBR.Items(CInt(intCount)).SubItems.Add("")
                        End If

                        If Not IsDBNull(.Fields("D_T").Value) Then
                            frmComputers.lvNotesBR.Items(CInt(intCount)).SubItems.Add(.Fields("D_T").Value)
                        Else
                            frmComputers.lvNotesBR.Items(CInt(intCount)).SubItems.Add("")
                        End If

                        If Not IsDBNull(.Fields("ZAMETKA").Value) Then
                            frmComputers.lvNotesBR.Items(CInt(intCount)).SubItems.Add(.Fields("ZAMETKA").Value)
                        Else
                            frmComputers.lvNotesBR.Items(CInt(intCount)).SubItems.Add("")
                        End If

                        If Not IsDBNull(.Fields("Master").Value) Then
                            frmComputers.lvNotesBR.Items(CInt(intCount)).SubItems.Add(.Fields("Master").Value)
                        Else
                            frmComputers.lvNotesBR.Items(CInt(intCount)).SubItems.Add("")
                        End If

                        intCount = intCount + 1
                        .MoveNext()
                    Loop
                End With

                rs.Close()
                rs = Nothing
        End Select

        ResList(frmComputers.lvNotesBR)

        Exit Sub
err_:
    End Sub

    Public Sub SHED_CHECK()
        On Error GoTo err_

        Dim objIniFile As New IniFile(PrPath & "base.ini")

        Dim uname As String

        uname = objIniFile.GetString("General", "Sheduler", "unChecked")

        Select Case uname

            Case "unChecked"

                frmMain.lblShed.Visible = False

                Select Case frmMain.lblShed.Visible

                    Case False

                        frmMain.lblSplet.Visible = False

                End Select

        End Select

        Dim rs As Recordset

        Dim sSQL, SERT, SERT2 As String
        Dim LNGIniFile As New IniFile(sLANGPATH)

        sSQL = "SELECT COUNT(*) AS total_number FROM Sheduler"

        rs = New Recordset
        rs.Open(sSQL, DB7, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic)

        With rs
            SERT = .Fields("total_number").Value
        End With

        rs.Close()
        rs = Nothing

        Select Case SERT

            Case 0

                frmMain.lblShed.Visible = False

                Select Case frmMain.lblShed.Visible

                    Case False

                        frmMain.lblSplet.Visible = False

                End Select


            Case Else

                frmMain.lblShed.Visible = True

                Select Case frmMain.lblShed.Visible

                    Case True

                        frmMain.lblSplet.Visible = True

                End Select

                frmMain.lblShed.Text = LNGIniFile.GetString("frmMain", "lblShed", "Напоминания") & " " & "(" & "0" & "/" &
                                       SERT$ & ")"

                sSQL = "SELECT COUNT(*) AS total_number FROM Sheduler Where foruser='" & UserNames & "'"

                rs = New Recordset
                rs.Open(sSQL, DB7, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic)

                With rs
                    SERT2 = .Fields("total_number").Value
                End With
                rs.Close()
                rs = Nothing

                Select Case SERT2

                    Case 0

                        frmMain.lblShed.Text = LNGIniFile.GetString("frmMain", "lblShed", "Напоминания") & " " & "(" & "0" & "/" &
                                                              SERT$ & ")"
                        frmMain.lblShed.ForeColor = Color.Black

                    Case Else

                        sSQL = "SELECT DATA, FORUSER, OPIS FROM Sheduler Where foruser='" & UserNames & "'"

                        rs = New Recordset
                        rs.Open(sSQL, DB7, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic)
                        Dim intj As Integer
                        intj = 0
                        With rs
                            .MoveFirst()
                            Do While Not .EOF

                                If .Fields(0).Value <= Date.Today.AddDays(-3) Or .Fields(0).Value >= Date.Today.AddDays(+3) _
                                    Then

                                Else

                                    Select Case .Fields(1).Value

                                        Case UserNames

                                            intj = intj + 1

                                            frmMain.lblShed.Text = LNGIniFile.GetString("frmMain", "lblShed", "Напоминания") & " " &
                                                                   "(" & intj & "/" & SERT$ & ")"
                                            frmMain.lblShed.ForeColor = Color.Red

                                    End Select

                                End If

                                .MoveNext()
                                'DoEvents
                            Loop
                        End With

                        rs.Close()
                        rs = Nothing

                End Select

        End Select


        'frmMain.lblShed.Text = "Напоминания "

err_:

    End Sub

    Public Sub REM_CHECK()
        Dim LNGIniFile As New IniFile(sLANGPATH)

        On Error Resume Next

        Dim rs As Recordset

        Dim sSQL, SERT, SERT2, uname, SERT3 As String


        sSQL = "SELECT COUNT(*) AS total_number FROM Remont"

        rs = New Recordset
        rs.Open(sSQL, DB7, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic)

        With rs
            SERT = .Fields("total_number").Value
        End With

        rs.Close()
        rs = Nothing

        Select Case SERT

            Case 0

                frmMain.lblRem.Visible = False

                Select Case frmMain.lblRem.Visible

                    Case False

                        frmMain.ToolStripStatusLabel4.Visible = False
                End Select

            Case Else

                frmMain.lblRem.Visible = True

                Select Case frmMain.lblRem.Visible

                    Case True
                        frmMain.ToolStripStatusLabel4.Visible = True

                End Select

                rs = New Recordset
                rs.Open("SELECT * FROM SPR_Master WHERE A='" & UserNames & "'", DB7, CursorTypeEnum.adOpenDynamic,
                        LockTypeEnum.adLockOptimistic)

                With rs
                    uname = .Fields("name").Value
                End With

                rs.Close()
                rs = Nothing

                If uname = Nothing Then uname = "ADMINISTRATOR"

                sSQL = "SELECT COUNT(*) AS total_number FROM Remont WHERE otvetstv='" & uname & "'"

                rs = New Recordset
                rs.Open(sSQL, DB7, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic)

                With rs
                    SERT2 = .Fields("total_number").Value
                End With
                rs.Close()
                rs = Nothing
                'LNGIniFile.GetString("frmMain", "lblRem", "Заявки") & " " & 
                frmMain.lblRem.Text = LNGIniFile.GetString("frmMain", "lblRem", "Заявки") & " " & "(" & "0" & "/" & SERT &
                                      ")"

                Select Case SERT2

                    Case 0

                        frmMain.lblRem.Text = LNGIniFile.GetString("frmMain", "lblRem", "Заявки") & " " & "(" & "0" & "/" & SERT &
                                         ")"

                    Case Else

                        sSQL = "SELECT COUNT(*) AS total_number FROM Remont Where otvetstv='" & uname & "' and zakryt = 0"

                        rs = New Recordset
                        rs.Open(sSQL, DB7, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic)

                        With rs
                            SERT3 = .Fields("total_number").Value
                        End With
                        rs.Close()
                        rs = Nothing

                        Select Case SERT3

                            Case 0

                                frmMain.lblRem.Text = LNGIniFile.GetString("frmMain", "lblRem", "Заявки") & " " & "(" & "0" & "/" &
                                            SERT & ")"
                                frmMain.lblRem.ForeColor = Color.Black

                            Case Else

                                frmMain.lblRem.Text = LNGIniFile.GetString("frmMain", "lblRem", "Заявки") & " " & "(" & SERT3 & "/" &
                                             SERT & ")"
                                frmMain.lblRem.ForeColor = Color.Red

                        End Select

                End Select

        End Select

    End Sub

    Public Sub ExLoadParFow(ByVal sCombo1 As String, ByVal sText1 As TextBox, ByVal sText2 As TextBox,
                            ByVal sCombo2 As ComboBox, ByVal sTABLE As String)

        On Error Resume Next
        Dim rs As Recordset
        Dim sSQL As String
        Dim uNI As String
        rs = New Recordset


        sSQL = "SELECT * FROM " & sTABLE & " WHERE Name = '" & sCombo1 & "'"

        rs.Open(sSQL, DB7, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic)

        With rs

            If Not IsDBNull(.Fields("proizv").Value) Then uNI = .Fields("proizv").Value

            Dim PROYZV As Recordset
            PROYZV = New Recordset
            PROYZV.Open("SELECT * FROM SPR_PROIZV WHERE iD=" & uNI, DB7, CursorTypeEnum.adOpenDynamic,
                        LockTypeEnum.adLockOptimistic)

            With PROYZV
                sCombo2.Text = .Fields("proizv").Value
            End With
            PROYZV.Close()
            PROYZV = Nothing

            If Not IsDBNull(.Fields("A").Value) Then sText1.Text = .Fields("A").Value
            If Not IsDBNull(.Fields("B").Value) Then sText2.Text = .Fields("B").Value
        End With

        rs.Close()
        rs = Nothing
    End Sub

    Public Sub ExLoadParTree(ByVal sCombo1 As String, ByVal sText1 As TextBox, ByVal sCombo2 As ComboBox,
                             ByVal sTABLE As String)

        On Error Resume Next
        Dim rs As Recordset
        Dim sSQL As String
        Dim uNI As String
        rs = New Recordset


        sSQL = "SELECT * FROM " & sTABLE & " WHERE Name = '" & sCombo1 & "'"

        rs.Open(sSQL, DB7, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic)

        With rs

            If Not IsDBNull(.Fields("proizv").Value) Then uNI = .Fields("proizv").Value

            Dim PROYZV As Recordset
            PROYZV = New Recordset
            PROYZV.Open("SELECT * FROM SPR_PROIZV WHERE iD=" & uNI, DB7, CursorTypeEnum.adOpenDynamic,
                        LockTypeEnum.adLockOptimistic)

            With PROYZV
                sCombo2.Text = .Fields("proizv").Value
            End With
            PROYZV.Close()
            PROYZV = Nothing

            If Not IsDBNull(.Fields("A").Value) Then sText1.Text = .Fields("A").Value

        End With

        rs.Close()
        rs = Nothing
    End Sub

    Public Sub ExLoadParTwo(ByVal sCombo1 As String, ByVal sCombo2 As ComboBox, ByVal sTABLE As String)

        On Error Resume Next
        Dim rs As Recordset
        Dim sSQL As String
        Dim uNI As String
        rs = New Recordset


        sSQL = "SELECT * FROM " & sTABLE & " WHERE Name = '" & sCombo1 & "'"

        rs.Open(sSQL, DB7, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic)

        With rs

            If Not IsDBNull(.Fields("proizv").Value) Then uNI = .Fields("proizv").Value

            Dim PROYZV As Recordset
            PROYZV = New Recordset
            PROYZV.Open("SELECT * FROM SPR_PROIZV WHERE iD=" & uNI, DB7, CursorTypeEnum.adOpenDynamic,
                        LockTypeEnum.adLockOptimistic)

            With PROYZV
                sCombo2.Text = .Fields("proizv").Value
            End With
            PROYZV.Close()
            PROYZV = Nothing

        End With

        rs.Close()
        rs = Nothing
    End Sub

    Public Sub REMONT_SEND_MASTER(ByVal sID As String)

        Dim sSQL, sSQL1, a1, b1, c1, d1, e1, g1, h1, i1, j1, k1, l1, PREFs, m1, frm, srok As String

        sSQL = "SELECT * FROM Remont where id =" & sID

        Dim rs As Recordset
        rs = New Recordset
        rs.Open(sSQL, DB7, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic)

        With rs
            a1 = .Fields("D_T").Value
            b1 = .Fields("Id_Comp").Value
            c1 = .Fields("Remont").Value
            d1 = .Fields("Master").Value
            e1 = .Fields("otvetstv").Value
            g1 = .Fields("name_of_remont").Value
            l1 = .Fields("istochnik").Value
            PREFs = .Fields("PREF").Value

            srok = .Fields("srok").Value
        End With
        rs.Close()
        rs = Nothing

        sSQL1 = "SELECT * FROM SPR_Master where Name ='" & d1 & "'"
        rs = New Recordset
        rs.Open(sSQL1, DB7, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic)

        With rs
            m1 = .Fields("B").Value
            ' smtp = .Fields("C").Value
        End With
        rs.Close()
        rs = Nothing

        sSQL1 = "SELECT * FROM CONFIGURE"
        rs = New Recordset
        rs.Open(sSQL1, DB7, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic)

        With rs
            frm = .Fields("nr").Value
        End With
        rs.Close()
        rs = Nothing

        Select Case PREFs

            Case "C"

                sSQL1 = "SELECT NET_NAME,FILIAL,MESTO,kabn FROM kompy where id =" & b1
                rs = New Recordset
                rs.Open(sSQL1, DB7, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic)
                With rs
                    h1 = .Fields("NET_NAME").Value
                    i1 = .Fields("FILIAL").Value
                    j1 = .Fields("MESTO").Value
                    k1 = .Fields("kabn").Value
                End With
                rs.Close()
                rs = Nothing

            Case "G"

                sSQL1 = "SELECT FILIAL FROM SPR_FILIAL where id =" & b1
                rs = New Recordset
                rs.Open(sSQL1, DB7, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic)
                With rs
                    i1 = .Fields("FILIAL").Value

                End With
                rs.Close()
                rs = Nothing

            Case "O"

                sSQL1 = "SELECT FILIAL,N_Otd FROM SPR_OTD_FILIAL where id =" & b1
                rs = New Recordset
                rs.Open(sSQL1, DB7, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic)
                With rs
                    i1 = .Fields("FILIAL").Value
                    j1 = .Fields("N_Otd").Value
                    'k1 = .Fields("MESTO").Value

                End With
                rs.Close()
                rs = Nothing

            Case "K"

                sSQL1 = "SELECT N_F,N_M,Name FROM SPR_KAB where id =" & b1
                rs = New Recordset
                rs.Open(sSQL1, DB7, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic)
                With rs
                    i1 = .Fields("N_F").Value
                    j1 = .Fields("N_M").Value
                    k1 = .Fields("Name").Value

                End With
                rs.Close()
                rs = Nothing

        End Select

        If Len(m1) <> 0 Then

        Else

            MsgBox("Отсутствует электронная почта у мастера", MsgBoxStyle.Information, ProGramName)
            Exit Sub
        End If

        If Len(frm) = 0 Then

            MsgBox("Не заполнен адрес для ответа", MsgBoxStyle.Information, ProGramName)
            Exit Sub

        End If

        If Len(l1) = 0 Then l1 = "Источник не известен. "

        i1 = "Филиал - " & i1 & ", "
        j1 = "Отдел - " & j1 & ", "
        k1 = "Кабинет - " & k1 & ". "
        h1 = "Объект - " & h1 & " "

        Dim Subject As String
        Dim Body As String

        Dim bAns As Boolean = True
        Dim sParams As String

        Dim sTEXT As TextBox
        sTEXT = New TextBox
        sTEXT.Multiline = True
        sTEXT.Text = "Здравствуйте " & d1 & ", " _
                                            + vbNewLine + "получено сообщение от " & l1 & ": " _
                     & vbNewLine & c1 _
                     & vbNewLine & "Срок исполнения: " & srok _
                     & vbNewLine & h1 _
                     & vbNewLine & i1 _
                     & vbNewLine & j1 _
                     & vbNewLine & k1

        Subject = "БКО::Ремонт " & g1
        sParams = m1

        On Error GoTo err_

        Dim objIniFile As New IniFile(PrPath & "base.ini")
        Dim sORG As String

        Dim decr As String = DecryptBytes(objIniFile.GetString("SMTP", "Password", ""))

        Dim client As New SmtpClient
        client.Port = objIniFile.GetString("SMTP", "Port", "25")
        client.Host = objIniFile.GetString("SMTP", "Server", "")
        client.EnableSsl = objIniFile.GetString("SMTP", "TLS", "False")

        client.Credentials = New NetworkCredential(objIniFile.GetString("SMTP", "User", ""), decr)

        If Len(client.Host) = 0 Then Exit Sub

        Dim fromAdr As MailAddress = New MailAddress(frm, sORG, Encoding.UTF8)
        Dim toAdr As MailAddress = New MailAddress(objIniFile.GetString("SMTP", "User", ""))
        Dim message As MailMessage = New MailMessage(fromAdr, toAdr)
        message.Subject = Subject
        message.SubjectEncoding = Encoding.UTF8
        message.Body = sTEXT.Text
        message.BodyEncoding = Encoding.UTF8

        client.Send(message)
        message.Dispose()
        sTEXT = Nothing

        MsgBox("Сообщение отправлено", MsgBoxStyle.Information, ProGramName)
        Exit Sub
err_:
        MsgBox(Err.Description)

    End Sub
End Module
