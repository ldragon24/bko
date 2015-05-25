

Module Mod_Load_SPR
    Public Sub LoadSPR()

        'frmComputers.Cursor = Cursors.WaitCursor
        ClearCMB(frmComputers)

        frmComputers.cmbPRNConnect.Items.Add("BlueTouch")
        frmComputers.cmbPRNConnect.Items.Add("LPT")
        frmComputers.cmbPRNConnect.Items.Add("NetWork")
        frmComputers.cmbPRNConnect.Items.Add("USB")
        frmComputers.cmbPRNConnect.Items.Add("Wi-Fi")
        frmComputers.cmbPRNConnect.Items.Add("IR")
        frmComputers.cmbPRNConnect.Items.Add("Usb Printserver")
        frmComputers.cmbPRNConnect.Items.Add("LPT Printserver")

        frmComputers.cmbNetCable.Items.Add("Coaxial")
        frmComputers.cmbNetCable.Items.Add("Fiber-Optic Cable")
        frmComputers.cmbNetCable.Items.Add("Quadrax")
        frmComputers.cmbNetCable.Items.Add("Quadshield")
        frmComputers.cmbNetCable.Items.Add("S-STP")
        frmComputers.cmbNetCable.Items.Add("STP")
        frmComputers.cmbNetCable.Items.Add("Twinaxial")
        frmComputers.cmbNetCable.Items.Add("UTP")

        frmComputers.cmbNetVkl.Items.Add("On")
        frmComputers.cmbNetVkl.Items.Add("Off")
        frmComputers.cmbNetVkl.Items.Add("Defective")


        FillComboNET(frmComputers.PROizV1, "PROIZV", "SPR_PROIZV", "", False, True)

        Dim obj As Object() = New Object(frmComputers.PROizV1.Items.Count - 1) {}
        frmComputers.PROizV1.Items.CopyTo(obj, 0)
        frmComputers.PROizV2.Items.AddRange(obj)
        frmComputers.PROizV3.Items.AddRange(obj)
        frmComputers.PROizV4.Items.AddRange(obj)
        frmComputers.PROizV5.Items.AddRange(obj)
        frmComputers.PROizV6.Items.AddRange(obj)
        frmComputers.PROizV7.Items.AddRange(obj)
        frmComputers.PROizV8.Items.AddRange(obj)
        frmComputers.PROizV9.Items.AddRange(obj)
        frmComputers.PROizV10.Items.AddRange(obj)
        frmComputers.PROizV11.Items.AddRange(obj)
        frmComputers.PROizV12.Items.AddRange(obj)
        frmComputers.PROizV13.Items.AddRange(obj)
        frmComputers.PROizV14.Items.AddRange(obj)
        frmComputers.PROizV15.Items.AddRange(obj)
        frmComputers.PROizV16.Items.AddRange(obj)
        frmComputers.PROizV17.Items.AddRange(obj)
        frmComputers.PROizV18.Items.AddRange(obj)
        frmComputers.PROizV19.Items.AddRange(obj)
        frmComputers.PROizV20.Items.AddRange(obj)
        frmComputers.PROizV21.Items.AddRange(obj)
        frmComputers.PROizV22.Items.AddRange(obj)
        frmComputers.PROizV23.Items.AddRange(obj)
        frmComputers.PROizV24.Items.AddRange(obj)
        frmComputers.PROizV25.Items.AddRange(obj)
        frmComputers.PROizV26.Items.AddRange(obj)
        frmComputers.PROizV27.Items.AddRange(obj)
        frmComputers.PROizV28.Items.AddRange(obj)
        frmComputers.PROizV29.Items.AddRange(obj)
        frmComputers.PROizV30.Items.AddRange(obj)
        frmComputers.PROizV31.Items.AddRange(obj)
        frmComputers.PROizV32.Items.AddRange(obj)
        frmComputers.PROizV33.Items.AddRange(obj)
        frmComputers.PROizV34.Items.AddRange(obj)
        frmComputers.PROizV35.Items.AddRange(obj)
        frmComputers.PROizV36.Items.AddRange(obj)

        frmComputers.PROiZV38.Items.AddRange(obj)
        frmComputers.PROiZV39.Items.AddRange(obj)
        frmComputers.PROiZV40.Items.AddRange(obj)
        frmComputers.PROizV41.Items.AddRange(obj)
        frmComputers.PROizV42.Items.AddRange(obj)
        frmComputers.PROizV43.Items.AddRange(obj)
        frmComputers.PROizV44.Items.AddRange(obj)
        frmComputers.PROizV45.Items.AddRange(obj)
        frmComputers.PROizV46.Items.AddRange(obj)
        frmComputers.PROizV47.Items.AddRange(obj)
        frmComputers.PROizV48.Items.AddRange(obj)
        frmComputers.PROizV49.Items.AddRange(obj)
        frmComputers.PROizV50.Items.AddRange(obj)
        frmComputers.PROizV51.Items.AddRange(obj)


        FillComboNET(frmComputers.cmbPostav, "Name", "SPR_Postav", "", False, True)

        Dim obj6 As Object() = New Object(frmComputers.cmbPostav.Items.Count - 1) {}
        frmComputers.cmbPostav.Items.CopyTo(obj6, 0)
        frmComputers.cmbOTHPostav.Items.AddRange(obj6)
        frmComputers.cmbPRNPostav.Items.AddRange(obj6)
        frmComputers.cmbNETPostav.Items.AddRange(obj6)


        FillComboNET(frmComputers.cmbCPU1, "Name", "SPR_CPU", "", False, True)

        Dim obj1 As Object() = New Object(frmComputers.cmbCPU1.Items.Count - 1) {}
        frmComputers.cmbCPU1.Items.CopyTo(obj1, 0)
        frmComputers.cmbCPU2.Items.AddRange(obj1)
        frmComputers.cmbCPU3.Items.AddRange(obj1)
        frmComputers.cmbCPU4.Items.AddRange(obj1)


        FillComboNET(frmComputers.cmbMB, "Name", "SPR_MB", "", False, True)


        FillComboNET(frmComputers.cmbRAM1, "Name", "SPR_RAM", "", False, True)

        Dim obj2 As Object() = New Object(frmComputers.cmbRAM1.Items.Count - 1) {}
        frmComputers.cmbRAM1.Items.CopyTo(obj2, 0)
        frmComputers.cmbRAM2.Items.AddRange(obj2)
        frmComputers.cmbRAM3.Items.AddRange(obj2)
        frmComputers.cmbRAM4.Items.AddRange(obj2)
        frmComputers.cmbRAM5.Items.AddRange(obj2)
        frmComputers.cmbRAM6.Items.AddRange(obj2)
        frmComputers.cmbRAM7.Items.AddRange(obj2)
        frmComputers.cmbRAM8.Items.AddRange(obj2)

        FillComboNET(frmComputers.cmbHDD1, "Name", "SPR_HDD", "", False, True)

        Dim obj3 As Object() = New Object(frmComputers.cmbHDD1.Items.Count - 1) {}
        frmComputers.cmbHDD1.Items.CopyTo(obj3, 0)
        frmComputers.cmbHDD2.Items.AddRange(obj3)
        frmComputers.cmbHDD3.Items.AddRange(obj3)
        frmComputers.cmbHDD4.Items.AddRange(obj3)
        frmComputers.cmbHDD5.Items.CopyTo(obj3, 0)
        frmComputers.cmbHDD6.Items.AddRange(obj3)
        frmComputers.cmbHDD7.Items.AddRange(obj3)
        frmComputers.cmbHDD8.Items.AddRange(obj3)


        FillComboNET(frmComputers.cmbSVGA1, "Name", "SPR_SVGA", "", False, True)
        FillComboNET(frmComputers.cmbSVGA2, "Name", "SPR_SVGA", "", False, True)

        FillComboNET(frmComputers.cmbSound, "Name", "SPR_SOUND", "", False, True)

        FillComboNET(frmComputers.cmbOPTIC1, "Name", "SPR_OPTICAL", "", False, True)

        Dim obj10 As Object() = New Object(frmComputers.cmbOPTIC1.Items.Count - 1) {}
        frmComputers.cmbOPTIC1.Items.CopyTo(obj10, 0)
        frmComputers.cmbOPTIC2.Items.AddRange(obj10)
        frmComputers.cmbOPTIC3.Items.AddRange(obj10)


        FillComboNET(frmComputers.cmbNET1, "Name", "SPR_NET", "", False, True)
        FillComboNET(frmComputers.cmbNET2, "Name", "SPR_NET", "", False, True)

        FillComboNET(frmComputers.cmbFDD, "Name", "SPR_FDD", "", False, True)
        FillComboNET(frmComputers.cmbModem, "Name", "SPR_MODEM", "", False, True)
        FillComboNET(frmComputers.cmbUSB, "Name", "SPR_USB", "", False, True)
        FillComboNET(frmComputers.cmbPCI, "Name", "SPR_PCI", "", False, True)


        FillComboNET(frmComputers.cmbMon1, "Name", "SPR_MONITOR", "", False, True)
        FillComboNET(frmComputers.cmbMon2, "Name", "SPR_MONITOR", "", False, True)

        FillComboNET(frmComputers.cmbKeyb, "Name", "SPR_KEYBOARD", "", False, True)
        FillComboNET(frmComputers.cmbMouse, "Name", "SPR_MOUSE", "", False, True)
        FillComboNET(frmComputers.cmbAsist, "Name", "SPR_ASISTEM", "", False, True)
        FillComboNET(frmComputers.cmbFilter, "Name", "SPR_FS", "", False, True)
        FillComboNET(frmComputers.cmbIBP, "Name", "SPR_IBP", "", False, True)
        FillComboNET(frmComputers.cmbCreader, "Name", "SPR_CREADER", "", False, True)
        FillComboNET(frmComputers.cmbCase, "Name", "SPR_CASE", "", False, True)
        FillComboNET(frmComputers.cmbBP, "Name", "SPR_BP", "", False, True)

        'frmSplash.lblLoadSPR.Text = "Принтеры"
        FillComboNET(frmComputers.cmbPrinters1, "Name", "SPR_PRINTER", "", False, True)

        Dim obj9 As Object() = New Object(frmComputers.cmbPrinters1.Items.Count - 1) {}
        frmComputers.cmbPrinters1.Items.CopyTo(obj9, 0)
        frmComputers.cmbPrinters2.Items.AddRange(obj9)
        frmComputers.cmbPrinters3.Items.AddRange(obj9)

        'frmSplash.lblLoadSPR.Text = "Инфраструктура"
        ' FillComboNET(frmComputers.cmbBranch, "FILIAL", "SPR_FILIAL", "", False, True)

        Dim LNGIniFile As New IniFile(sLANGPATH)
        frmComputers.treebranche.Items.Add(LNGIniFile.GetString("frmComputers", "MSG53", "Все"))

        FillComboNET(frmComputers.cmbBranch, "FILIAL", "SPR_FILIAL", "", False, True)

        Dim obj5 As Object() = New Object(frmComputers.cmbBranch.Items.Count - 1) {}
        frmComputers.cmbBranch.Items.CopyTo(obj5, 0)
        frmComputers.cmbPRNFil.Items.AddRange(obj5)
        frmComputers.cmbOTHFil.Items.AddRange(obj5)
        frmComputers.cmbNETBranch.Items.AddRange(obj5)
        frmComputers.treebranche.Items.AddRange(obj5)


        'Ответственный компьютеров
        FillComboNET(frmComputers.cmbResponsible, "Name", "SPR_OTV", "", False, True)

        Dim obj7 As Object() = New Object(frmComputers.cmbResponsible.Items.Count - 1) {}
        frmComputers.cmbResponsible.Items.CopyTo(obj7, 0)
        frmComputers.cmbPRNotv.Items.AddRange(obj7)
        frmComputers.cmbOTHotv.Items.AddRange(obj7)
        frmComputers.cmbNETotv.Items.AddRange(obj7)

        'Тип компьютера
        FillComboNET(frmComputers.cmbAppointment, "TIP", "SPR_TIP", "", False, True)

        'Заметки компьютеров - мастер
        FillComboNET(frmComputers.cmbNotesMaster, "Name", "SPR_Master", "", False, True)

        Dim obj8 As Object() = New Object(frmComputers.cmbNotesMaster.Items.Count - 1) {}
        frmComputers.cmbNotesMaster.Items.CopyTo(obj8, 0)
        frmComputers.cmbNotesPRNMaster.Items.AddRange(obj8)
        frmComputers.cmbNotesNETMaster.Items.AddRange(obj8)
        frmComputers.cmbNotesOTHMaster.Items.AddRange(obj8)
        frmComputers.cmbBRMaster.Items.AddRange(obj8)


        'Модель картриджа
        FillComboNET(frmComputers.cmbModCartr, "Name", "spr_cart", "", False, True)
        FillComboNET(frmComputers.cmbNetDev, "Name", "SPR_NET_DEV", "", False, True)
        FillComboNET(frmComputers.cmbDevNet, "Name", "SPR_DEV_NET", "", False, True)

        FillComboNET(frmComputers.txtUserName, "Name", "SPR_USER", "", False, True)
        FillComboNET(frmComputers.txtUserFIO, "A", "SPR_USER", "", False, True)


        'frmSplash.lblLoadSPR.Text = "Построение дерева.."


        'cmbNotesMaster
        'frmSplash.Close()
        'frmComputers.Cursor = Cursors.Default

        'OPTIC
    End Sub

    Public Sub FillComboNET(ByVal pCombo As ComboBox, ByVal pField As String, ByVal pTable As String,
                            Optional ByVal WHEREClause As String = "", Optional ByVal AddBlank As Boolean = False,
                            Optional ByVal ClearFirst As Boolean = True, Optional ByVal PreserveValue As Boolean = True)
        'On Error Resume Next
        On Error GoTo err_

        pCombo.Items.Clear()

        Dim rs As Recordset

        rs = New Recordset
        rs.Open("SELECT count(*) as t_n FROM " & pTable & " WHERE " & pField & "<>''", DB7, CursorTypeEnum.adOpenDynamic,
                LockTypeEnum.adLockReadOnly)

        Dim COUnT As String

        With rs

            COUnT = .Fields("t_n").Value

        End With
        rs.Close()
        rs = Nothing

        Select Case COUnT

            Case 0

            Case Else

                rs = New Recordset
                rs.Open("SELECT " & pField & " FROM " & pTable & " WHERE " & pField & "<>'' ORDER BY " & pField, DB7,
                        CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockReadOnly)

                With rs
                    .MoveFirst()
                    Do While Not .EOF

                        If Not IsDBNull(.Fields(pField).Value) Then pCombo.Items.Add(.Fields(pField).Value)

                       .MoveNext()
                    Loop
                End With

                rs.Close()
                rs = Nothing

        End Select

        Exit Sub
err_:
        MsgBox(Err.Description, MsgBoxStyle.Information, ProGramName)
    End Sub
End Module
