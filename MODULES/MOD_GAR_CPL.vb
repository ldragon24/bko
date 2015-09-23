Module MOD_GAR_CPL
    Public EditGarant As Boolean

    Public Sub GAR_ED()
        Call CLEAR_CPL()
        Dim garant_comp As Recordset
        garant_comp = New Recordset
        garant_comp.Open("SELECT count(*) as t_n FROM garant_comp WHERE Id_Comp =" & frmComputers.sCOUNT, DB7,
                         CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic)

        Dim un As String

        With garant_comp

            un = .Fields("t_n").Value

        End With
        garant_comp.Close()
        garant_comp = Nothing

        If un > 0 Then

            EditGarant = True

        Else

            EditGarant = False

        End If
    End Sub

    Public Sub GCHTIO()

        On Error Resume Next
        Dim BASECOMP As Recordset

        BASECOMP = New Recordset
        BASECOMP.Open("SELECT * FROM kompy WHERE id =" & frmComputers.sCOUNT, DB7, CursorTypeEnum.adOpenDynamic,
                      LockTypeEnum.adLockOptimistic)

        With BASECOMP

            frmGarCPL.cmbCPU1.Text = .Fields("CPU1").Value
            frmGarCPL.txtMHZ1.Text = .Fields("CPUmhz1").Value
            frmGarCPL.txtSoc1.Text = .Fields("CPUSocket1").Value
            frmGarCPL.PROizV1.Text = .Fields("CPUProizv1").Value

            frmGarCPL.cmbCPU2.Text = .Fields("CPU2").Value
            frmGarCPL.txtMHZ2.Text = .Fields("CPUmhz2").Value
            frmGarCPL.txtSoc2.Text = .Fields("CPUSocket2").Value
            frmGarCPL.PROizV2.Text = .Fields("CPUProizv2").Value

            frmGarCPL.cmbCPU3.Text = .Fields("CPU3").Value
            frmGarCPL.txtMHZ3.Text = .Fields("CPUmhz3").Value
            frmGarCPL.txtSoc3.Text = .Fields("CPUSocket3").Value
            frmGarCPL.PROizV3.Text = .Fields("CPUProizv3").Value

            frmGarCPL.cmbCPU4.Text = .Fields("CPU4").Value
            frmGarCPL.txtMHZ4.Text = .Fields("CPUmhz4").Value
            frmGarCPL.txtSoc4.Text = .Fields("CPUSocket4").Value
            frmGarCPL.PROizV4.Text = .Fields("CPUProizv4").Value


        End With

        Dim garant_comp As Recordset


        garant_comp = New Recordset
        garant_comp.Open("SELECT * FROM garant_comp WHERE Id_Comp =" & frmComputers.sCOUNT, DB7,
                         CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic)

        With garant_comp

            frmGarCPL.DNG.Value = .Fields("CPU_DP").Value & "." & .Fields("CPU_MP").Value & "." &
                                  .Fields("CPU_GP").Value
            frmGarCPL.DOG.Value = .Fields("CPU_DPo").Value & "." & .Fields("CPU_MPo").Value & "." &
                                  .Fields("CPU_GPo").Value

            frmGarCPL.cmbPostav.Text = .Fields("CPU_POST").Value
            'EDTID 'frmMain.nomerPCAbs '.Fields("Id_Comp").value

        End With
        BASECOMP.Close()
        garant_comp.Close()
        garant_comp = Nothing
        BASECOMP = Nothing
    End Sub

    Public Sub PAMIAT()
        On Error Resume Next
        Dim garant_comp As Recordset
        Dim BASECOMP As Recordset

        BASECOMP = New Recordset
        BASECOMP.Open("SELECT * FROM kompy WHERE id =" & frmComputers.sCOUNT, DB7, CursorTypeEnum.adOpenDynamic,
                      LockTypeEnum.adLockOptimistic)


        With BASECOMP

            frmGarCPL.cmbCPU1.Text = .Fields("RAM_1").Value
            frmGarCPL.txtSoc1.Text = .Fields("RAM_SN_1").Value
            frmGarCPL.txtMHZ1.Text = .Fields("RAM_speed_1").Value
            frmGarCPL.PROizV1.Text = .Fields("RAM_PROIZV_1").Value

            frmGarCPL.cmbCPU2.Text = .Fields("RAM_2").Value
            frmGarCPL.txtMHZ2.Text = .Fields("RAM_speed_2").Value
            frmGarCPL.txtSoc2.Text = .Fields("RAM_SN_2").Value
            frmGarCPL.PROizV2.Text = .Fields("RAM_PROIZV_2").Value

            frmGarCPL.cmbCPU3.Text = .Fields("RAM_3").Value
            frmGarCPL.txtSoc3.Text = .Fields("RAM_SN_3").Value
            frmGarCPL.txtMHZ3.Text = .Fields("RAM_speed_3").Value
            frmGarCPL.PROizV3.Text = .Fields("RAM_PROIZV_3").Value

            frmGarCPL.cmbCPU4.Text = .Fields("RAM_4").Value
            frmGarCPL.txtSoc4.Text = .Fields("RAM_SN_4").Value
            frmGarCPL.txtMHZ4.Text = .Fields("RAM_speed_4").Value
            frmGarCPL.PROizV4.Text = .Fields("RAM_PROIZV_4").Value


        End With

        garant_comp = New Recordset
        garant_comp.Open("SELECT * FROM garant_comp WHERE Id_Comp =" & frmComputers.sCOUNT, DB7,
                         CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic)


        With garant_comp

            frmGarCPL.DNG.Value = .Fields("RAM_DP").Value & "." & .Fields("RAM_MP").Value & "." &
                                  .Fields("RAM_GP").Value
            frmGarCPL.DOG.Value = .Fields("RAM_DPo").Value & "." & .Fields("RAM_MPo").Value & "." &
                                  .Fields("RAM_GPo").Value

            frmGarCPL.cmbPostav.Text = .Fields("RAM_POST").Value

        End With

        BASECOMP.Close()
        garant_comp.Close()
        garant_comp = Nothing
        BASECOMP = Nothing
    End Sub

    Public Sub HARDY()
        On Error Resume Next
        Dim garant_comp As Recordset
        Dim BASECOMP As Recordset

        garant_comp = New Recordset
        garant_comp.Open("SELECT * FROM garant_comp WHERE Id_Comp =" & frmComputers.sCOUNT, DB7,
                         CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic)

        BASECOMP = New Recordset
        BASECOMP.Open("SELECT * FROM kompy WHERE id =" & frmComputers.sCOUNT, DB7, CursorTypeEnum.adOpenDynamic,
                      LockTypeEnum.adLockOptimistic)
        With BASECOMP

            frmGarCPL.cmbCPU1.Text = .Fields("HDD_Name_1").Value
            frmGarCPL.txtMHZ1.Text = .Fields("HDD_OB_1").Value
            frmGarCPL.PROizV1.Text = .Fields("HDD_PROIZV_1").Value
            frmGarCPL.txtSoc1.Text = .Fields("HDD_SN_1").Value

            frmGarCPL.cmbCPU2.Text = .Fields("HDD_Name_2").Value
            frmGarCPL.txtMHZ2.Text = .Fields("HDD_OB_2").Value
            frmGarCPL.txtSoc2.Text = .Fields("HDD_SN_2").Value
            frmGarCPL.PROizV2.Text = .Fields("HDD_PROIZV_2").Value

            frmGarCPL.cmbCPU3.Text = .Fields("HDD_Name_3").Value
            frmGarCPL.txtMHZ3.Text = .Fields("HDD_OB_3").Value
            frmGarCPL.txtSoc3.Text = .Fields("HDD_SN_3").Value
            frmGarCPL.PROizV3.Text = .Fields("HDD_PROIZV_3").Value

            frmGarCPL.cmbCPU4.Text = .Fields("HDD_Name_4").Value
            frmGarCPL.txtMHZ4.Text = .Fields("HDD_OB_4").Value
            frmGarCPL.txtSoc4.Text = .Fields("HDD_SN_4").Value
            frmGarCPL.PROizV4.Text = .Fields("HDD_PROIZV_4").Value


        End With


        With garant_comp

            frmGarCPL.DNG.Value = .Fields("HDD_DP").Value & "." & .Fields("HDD_MP").Value & "." &
                                  .Fields("HDD_GP").Value
            frmGarCPL.DOG.Value = .Fields("HDD_DPo").Value & "." & .Fields("HDD_MPo").Value & "." &
                                  .Fields("HDD_GPo").Value

            frmGarCPL.cmbPostav.Text = .Fields("HDD_POST").Value

        End With

        BASECOMP.Close()
        garant_comp.Close()
        garant_comp = Nothing
        BASECOMP = Nothing
    End Sub

    Public Sub VideoCard()
        On Error Resume Next
        Dim garant_comp As Recordset
        Dim BASECOMP As Recordset

        garant_comp = New Recordset
        garant_comp.Open("SELECT * FROM garant_comp WHERE Id_Comp =" & frmComputers.sCOUNT, DB7,
                         CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic)

        BASECOMP = New Recordset
        BASECOMP.Open("SELECT * FROM kompy WHERE id =" & frmComputers.sCOUNT, DB7, CursorTypeEnum.adOpenDynamic,
                      LockTypeEnum.adLockOptimistic)
        With BASECOMP

            frmGarCPL.cmbCPU1.Text = .Fields("SVGA_NAME").Value
            frmGarCPL.txtMHZ1.Text = .Fields("SVGA_OB_RAM").Value
            frmGarCPL.PROizV1.Text = .Fields("SVGA_PROIZV").Value
            frmGarCPL.txtSoc1.Text = .Fields("SVGA_SN").Value


        End With


        With garant_comp

            frmGarCPL.DNG.Value = .Fields("SVGA_DP").Value & "." & .Fields("SVGA_MP").Value & "." &
                                  .Fields("SVGA_GP").Value
            frmGarCPL.DOG.Value = .Fields("SVGA_DPo").Value & "." & .Fields("SVGA_MPo").Value & "." &
                                  .Fields("SVGA_GPo").Value

            frmGarCPL.cmbPostav.Text = .Fields("SVGA_POST").Value

            'EDTID 'frmMain.nomerPCAbs '.Fields("Id_Comp").value
        End With
        BASECOMP.Close()
        garant_comp.Close()
        garant_comp = Nothing
        BASECOMP = Nothing
    End Sub

    Public Sub SoundCard()
        On Error Resume Next
        Dim garant_comp As Recordset
        Dim BASECOMP As Recordset

        garant_comp = New Recordset
        garant_comp.Open("SELECT * FROM garant_comp WHERE Id_Comp =" & frmComputers.sCOUNT, DB7,
                         CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic)

        BASECOMP = New Recordset
        BASECOMP.Open("SELECT * FROM kompy WHERE id =" & frmComputers.sCOUNT, DB7, CursorTypeEnum.adOpenDynamic,
                      LockTypeEnum.adLockOptimistic)
        With BASECOMP

            frmGarCPL.cmbCPU1.Text = .Fields("SOUND_NAME").Value
            frmGarCPL.txtMHZ1.Text = .Fields("SOUND_SN").Value
            frmGarCPL.PROizV1.Text = .Fields("SOUND_PROIZV").Value
            'frmGarCPL.txtSoc1.Text = .Fields("SOUND_SN").value


        End With


        With garant_comp

            frmGarCPL.DNG.Value = .Fields("SOUND_DP").Value & "." & .Fields("SOUND_MP").Value & "." &
                                  .Fields("SOUND_GP").Value
            frmGarCPL.DOG.Value = .Fields("SOUND_DPo").Value & "." & .Fields("SOUND_MPo").Value & "." &
                                  .Fields("SOUND_GPo").Value

            frmGarCPL.cmbPostav.Text = .Fields("SOUND_POST").Value

            'EDTID 'frmMain.nomerPCAbs '.Fields("Id_Comp").value
        End With

        BASECOMP.Close()
        garant_comp.Close()
        garant_comp = Nothing
        BASECOMP = Nothing
    End Sub

    Public Sub GCHTIm()
        On Error Resume Next
        Dim garant_comp As Recordset
        Dim BASECOMP As Recordset

        garant_comp = New Recordset
        garant_comp.Open("SELECT * FROM garant_comp WHERE Id_Comp =" & frmComputers.sCOUNT, DB7,
                         CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic)

        BASECOMP = New Recordset
        BASECOMP.Open("SELECT MB_NAME,Mb_Chip,Mb_Proizvod,Mb_Id FROM kompy WHERE id =" & frmComputers.sCOUNT, DB7, CursorTypeEnum.adOpenDynamic,
                      LockTypeEnum.adLockOptimistic)
        With BASECOMP

            frmGarCPL.cmbCPU1.Text = .Fields("MB_NAME").Value
            frmGarCPL.txtMHZ1.Text = .Fields("Mb_Chip").Value
            frmGarCPL.PROizV1.Text = .Fields("Mb_Proizvod").Value
            frmGarCPL.txtMHZ2.Text = .Fields("Mb_Id").Value


        End With

        With garant_comp

            frmGarCPL.DNG.Value = .Fields("mb_DP").Value & "." & .Fields("mb_MP").Value & "." & .Fields("mb_GP").Value
            frmGarCPL.DOG.Value = .Fields("mb_DPo").Value & "." & .Fields("mb_MPo").Value & "." &
                                  .Fields("mb_GPo").Value

            frmGarCPL.cmbPostav.Text = .Fields("mb_POST").Value

            'EDTIDp = .Fields("Id_Comp").value 'EDTID 'frmMain.nomerPCAbs '.Fields("Id_Comp").value

        End With

        BASECOMP.Close()
        garant_comp.Close()
        garant_comp = Nothing
        BASECOMP = Nothing
    End Sub

    Public Sub CdrF()
        Dim garant_comp As Recordset
        Dim BASECOMP As Recordset


        On Error GoTo Error_
        'Процессор


        On Error Resume Next

        garant_comp = New Recordset
        garant_comp.Open("SELECT * FROM garant_comp WHERE Id_Comp =" & frmComputers.sCOUNT, DB7,
                         CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic)

        BASECOMP = New Recordset
        BASECOMP.Open("SELECT * FROM kompy WHERE id =" & frmComputers.sCOUNT, DB7, CursorTypeEnum.adOpenDynamic,
                      LockTypeEnum.adLockOptimistic)
        With BASECOMP

            frmGarCPL.cmbCPU1.Text = .Fields("CD_NAME").Value
            frmGarCPL.txtMHZ1.Text = .Fields("CD_SPEED").Value
            frmGarCPL.txtSoc1.Text = .Fields("CD_SN").Value
            frmGarCPL.PROizV1.Text = .Fields("CD_PROIZV").Value

            frmGarCPL.cmbCPU2.Text = .Fields("CDrw_NAME").Value
            frmGarCPL.txtMHZ2.Text = .Fields("CDrw_SPEED").Value
            frmGarCPL.txtSoc2.Text = .Fields("CDRW_SN").Value
            frmGarCPL.PROizV2.Text = .Fields("CDrw_PROIZV").Value


            frmGarCPL.cmbCPU3.Text = .Fields("dvd_NAME").Value
            frmGarCPL.txtMHZ3.Text = .Fields("dvd_SPEED").Value
            frmGarCPL.txtSoc3.Text = .Fields("DVD_SN").Value
            frmGarCPL.PROizV3.Text = .Fields("dvd_PROIZV").Value


        End With


        With garant_comp

            frmGarCPL.DNG.Value = .Fields("CDROM_DP").Value & "." & .Fields("CDROM_MP").Value & "." &
                                  .Fields("CDROM_GP").Value
            frmGarCPL.DOG.Value = .Fields("CDROM_DPo").Value & "." & .Fields("CDROM_MPo").Value & "." &
                                  .Fields("CDROM_GPo").Value

            frmGarCPL.cmbPostav.Text = .Fields("CDROM_POST").Value

            'EDTID 'frmMain.nomerPCAbs '.Fields("Id_Comp").value
        End With


        BASECOMP.Close()
        garant_comp.Close()
        garant_comp = Nothing
        BASECOMP = Nothing

        Exit Sub
        Error_:
#If islog Then
WriteLog Err.Description
#End If
    End Sub

    Public Sub NEtr()
        '"Информация о Сети"

        Dim garant_comp As Recordset
        Dim BASECOMP As Recordset


        garant_comp = New Recordset
        garant_comp.Open("SELECT * FROM garant_comp WHERE Id_Comp =" & frmComputers.sCOUNT, DB7,
                         CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic)

        BASECOMP = New Recordset
        BASECOMP.Open("SELECT * FROM kompy WHERE id =" & frmComputers.sCOUNT, DB7, CursorTypeEnum.adOpenDynamic,
                      LockTypeEnum.adLockOptimistic)
        On Error GoTo Error_
        'Процессор
        With BASECOMP
            frmGarCPL.cmbCPU1.Text = .Fields("NET_NAME_1").Value
            frmGarCPL.txtMHZ1.Text = .Fields("NET_IP_1").Value
            frmGarCPL.txtSoc1.Text = .Fields("NET_MAC_1").Value
            frmGarCPL.PROizV1.Text = .Fields("NET_PROIZV_1").Value

            frmGarCPL.cmbCPU2.Text = .Fields("NET_NAME_2").Value
            frmGarCPL.txtMHZ2.Text = .Fields("NET_IP_2").Value
            frmGarCPL.txtSoc2.Text = .Fields("NET_MAC_2").Value
            frmGarCPL.PROizV2.Text = .Fields("NET_PROIZV_2").Value


        End With

        With garant_comp

            frmGarCPL.DNG.Value = .Fields("NET_DP").Value & "." & .Fields("NET_MP").Value & "." &
                                  .Fields("NET_GP").Value
            frmGarCPL.DOG.Value = .Fields("NET_DPo").Value & "." & .Fields("NET_MPo").Value & "." &
                                  .Fields("NET_GPo").Value

            frmGarCPL.cmbPostav.Text = .Fields("NET_POST").Value

            'EDTID 'frmMain.nomerPCAbs '.Fields("Id_Comp").value

        End With
        BASECOMP.Close()
        garant_comp.Close()
        garant_comp = Nothing
        BASECOMP = Nothing
        Exit Sub
        Error_:
#If islog Then
WriteLog Err.Description
#End If
    End Sub

    Public Sub FDDsS()
        '"Информация о Сети"

        Dim garant_comp As Recordset
        Dim BASECOMP As Recordset

        On Error GoTo Error_
        'Процессор
        garant_comp = New Recordset
        garant_comp.Open("SELECT * FROM garant_comp WHERE Id_Comp =" & frmComputers.sCOUNT, DB7,
                         CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic)

        BASECOMP = New Recordset
        BASECOMP.Open("SELECT * FROM kompy WHERE id =" & frmComputers.sCOUNT, DB7, CursorTypeEnum.adOpenDynamic,
                      LockTypeEnum.adLockOptimistic)
        With BASECOMP
            frmGarCPL.cmbCPU1.Text = .Fields("FDD_NAME").Value
            frmGarCPL.txtMHZ1.Text = .Fields("FDD_SN").Value
            frmGarCPL.PROizV1.Text = .Fields("FDD_PROIZV").Value


        End With

        With garant_comp

            frmGarCPL.DNG.Value = .Fields("FDD_DP").Value & "." & .Fields("FDD_MP").Value & "." &
                                  .Fields("FDD_GP").Value
            frmGarCPL.DOG.Value = .Fields("FDD_DPo").Value & "." & .Fields("FDD_MPo").Value & "." &
                                  .Fields("FDD_GPo").Value

            frmGarCPL.cmbPostav.Text = .Fields("FDD_POST").Value

            'EDTID 'frmMain.nomerPCAbs '.Fields("Id_Comp").value

        End With
        BASECOMP.Close()
        garant_comp.Close()
        garant_comp = Nothing
        BASECOMP = Nothing
        Exit Sub
        Error_:
#If islog Then
WriteLog Err.Description
#End If
    End Sub

    Public Sub MODEMs()
        '"Информация о Сети"
        Dim garant_comp As Recordset
        Dim BASECOMP As Recordset


        garant_comp = New Recordset
        garant_comp.Open("SELECT * FROM garant_comp WHERE Id_Comp =" & frmComputers.sCOUNT, DB7,
                         CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic)

        BASECOMP = New Recordset
        BASECOMP.Open("SELECT * FROM kompy WHERE id =" & frmComputers.sCOUNT, DB7, CursorTypeEnum.adOpenDynamic,
                      LockTypeEnum.adLockOptimistic)
        On Error GoTo Error_
        'Процессор
        With BASECOMP
            frmGarCPL.cmbCPU1.Text = .Fields("MODEM_NAME").Value
            frmGarCPL.txtMHZ1.Text = .Fields("MODEM_SN").Value
            frmGarCPL.PROizV1.Text = .Fields("MODEM_PROIZV").Value


        End With

        With garant_comp

            frmGarCPL.DNG.Value = .Fields("MODEM_DP").Value & "." & .Fields("MODEM_MP").Value & "." &
                                  .Fields("MODEM_GP").Value
            frmGarCPL.DOG.Value = .Fields("MODEM_DPo").Value & "." & .Fields("MODEM_MPo").Value & "." &
                                  .Fields("MODEM_GPo").Value

            frmGarCPL.cmbPostav.Text = .Fields("MODEM_POST").Value

            'EDTID 'frmMain.nomerPCAbs '.Fields("Id_Comp").value

        End With

        BASECOMP.Close()
        garant_comp.Close()
        garant_comp = Nothing
        BASECOMP = Nothing

        Exit Sub
        Error_:
#If islog Then
WriteLog Err.Description
#End If
    End Sub

    Public Sub KEYBOARDs()
        '"Информация о Сети"

        Dim garant_comp As Recordset
        Dim BASECOMP As Recordset


        garant_comp = New Recordset
        garant_comp.Open("SELECT * FROM garant_comp WHERE Id_Comp =" & frmComputers.sCOUNT, DB7,
                         CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic)

        BASECOMP = New Recordset
        BASECOMP.Open("SELECT * FROM kompy WHERE id =" & frmComputers.sCOUNT, DB7, CursorTypeEnum.adOpenDynamic,
                      LockTypeEnum.adLockOptimistic)

        On Error GoTo Error_
        'Процессор
        With BASECOMP
            frmGarCPL.cmbCPU1.Text = .Fields("KEYBOARD_NAME").Value
            frmGarCPL.txtMHZ1.Text = .Fields("KEYBOARD_SN").Value
            frmGarCPL.PROizV1.Text = .Fields("KEYBOARD_PROIZV").Value


        End With

        With garant_comp

            frmGarCPL.DNG.Value = .Fields("KEYBOARD_DP").Value & "." & .Fields("KEYBOARD_MP").Value & "." &
                                  .Fields("KEYBOARD_GP").Value
            frmGarCPL.DOG.Value = .Fields("KEYBOARD_DPo").Value & "." & .Fields("KEYBOARD_MPo").Value & "." &
                                  .Fields("KEYBOARD_GPo").Value

            frmGarCPL.cmbPostav.Text = .Fields("KEYBOARD_POST").Value 'nomerPC

            'EDTID 'frmMain.nomerPCAbs '.Fields("Id_Comp").value

        End With

        BASECOMP.Close()
        garant_comp.Close()
        garant_comp = Nothing
        BASECOMP = Nothing

        Exit Sub
        Error_:
#If islog Then
WriteLog Err.Description
#End If
    End Sub

    Public Sub MOUSEs()
        '"Информация о Сети"
        Dim garant_comp As Recordset
        Dim BASECOMP As Recordset


        garant_comp = New Recordset
        garant_comp.Open("SELECT * FROM garant_comp WHERE Id_Comp =" & frmComputers.sCOUNT, DB7,
                         CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic)

        BASECOMP = New Recordset
        BASECOMP.Open("SELECT * FROM kompy WHERE id =" & frmComputers.sCOUNT, DB7, CursorTypeEnum.adOpenDynamic,
                      LockTypeEnum.adLockOptimistic)

        On Error GoTo Error_
        'Процессор
        With BASECOMP
            frmGarCPL.cmbCPU1.Text = .Fields("MOUSE_NAME").Value
            frmGarCPL.txtMHZ1.Text = .Fields("MOUSE_SN").Value
            frmGarCPL.PROizV1.Text = .Fields("MOUSE_PROIZV").Value


        End With

        With garant_comp

            frmGarCPL.DNG.Value = .Fields("MOUSE_DP").Value & "." & .Fields("MOUSE_MP").Value & "." &
                                  .Fields("MOUSE_GP").Value
            frmGarCPL.DOG.Value = .Fields("MOUSE_DPo").Value & "." & .Fields("MOUSE_MPo").Value & "." &
                                  .Fields("MOUSE_GPo").Value

            frmGarCPL.cmbPostav.Text = .Fields("MOUSE_POST").Value

            'EDTID 'frmMain.nomerPCAbs '.Fields("Id_Comp").value

        End With
        BASECOMP.Close()
        garant_comp.Close()
        garant_comp = Nothing
        BASECOMP = Nothing
        Exit Sub
        Error_:
#If islog Then
WriteLog Err.Description
#End If
    End Sub

    Public Sub USBs()
        '"Информация о Сети"

        Dim garant_comp As Recordset
        Dim BASECOMP As Recordset


        On Error GoTo Error_
        'Процессор
        garant_comp = New Recordset
        garant_comp.Open("SELECT * FROM garant_comp WHERE Id_Comp =" & frmComputers.sCOUNT, DB7,
                         CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic)

        BASECOMP = New Recordset
        BASECOMP.Open("SELECT * FROM kompy WHERE id =" & frmComputers.sCOUNT, DB7, CursorTypeEnum.adOpenDynamic,
                      LockTypeEnum.adLockOptimistic)

        With BASECOMP
            frmGarCPL.cmbCPU1.Text = .Fields("USB_NAME").Value
            frmGarCPL.txtMHZ1.Text = .Fields("USB_SN").Value
            frmGarCPL.PROizV1.Text = .Fields("USB_PROIZV").Value


        End With

        With garant_comp

            frmGarCPL.DNG.Value = .Fields("USB_DP").Value & "." & .Fields("USB_MP").Value & "." &
                                  .Fields("USB_GP").Value
            frmGarCPL.DOG.Value = .Fields("USB_DPo").Value & "." & .Fields("USB_MPo").Value & "." &
                                  .Fields("USB_GPo").Value

            frmGarCPL.cmbPostav.Text = .Fields("USB_POST").Value

            'EDTID 'frmMain.nomerPCAbs '.Fields("Id_Comp").value

        End With
        BASECOMP.Close()
        garant_comp.Close()
        garant_comp = Nothing
        BASECOMP = Nothing
        Exit Sub
        Error_:
#If islog Then
WriteLog Err.Description
#End If
    End Sub

    Public Sub PCIsS()
        '"Информация о Сети"
        Dim garant_comp As Recordset
        Dim BASECOMP As Recordset

        On Error GoTo Error_
        'Процессор
        garant_comp = New Recordset
        garant_comp.Open("SELECT * FROM garant_comp WHERE Id_Comp =" & frmComputers.sCOUNT, DB7,
                         CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic)

        BASECOMP = New Recordset
        BASECOMP.Open("SELECT * FROM kompy WHERE id =" & frmComputers.sCOUNT, DB7, CursorTypeEnum.adOpenDynamic,
                      LockTypeEnum.adLockOptimistic)

        'pciinfo.lop.ListItems.Clear()
        ' With PCIuS
        '.MoveFirst()
        'Do While Not .EOF

        '  If .Fields("Id_Comp").value = frmMain.nomerPCAbs Then

        'A = pciinfo.lop.ListItems.Add(, , .Fields("id").value)
        ' 'Set A = lstContacts.ListItems.Add(, , .Fields("NAME_FIRST").value & " " & .Fields("NAME_MIDDLE").value & " " & .Fields("NAME_LAST").value)
        ' A.SubItems(1) = .Fields("PCI").value
        '  A.SubItems(2) = .Fields("PCI_sn").value
        ' A.SubItems(3) = .Fields("PCI_proizv").value

        '        Else
        '        End If
        '
        '' EDTID = .Fields("iD_comp").value
        '.MoveNext()
        ''DoEvents
        'Loop
        'End With
        BASECOMP.Close()
        garant_comp.Close()
        garant_comp = Nothing
        BASECOMP = Nothing
        Exit Sub
        Error_:
#If islog Then
WriteLog Err.Description
#End If
    End Sub

    Public Sub MonitorS()

        Dim garant_comp As Recordset
        Dim BASECOMP As Recordset


        On Error GoTo Error_
        garant_comp = New Recordset
        garant_comp.Open("SELECT * FROM garant_comp WHERE Id_Comp =" & frmComputers.sCOUNT, DB7,
                         CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic)

        BASECOMP = New Recordset
        BASECOMP.Open("SELECT * FROM kompy WHERE id =" & frmComputers.sCOUNT, DB7, CursorTypeEnum.adOpenDynamic,
                      LockTypeEnum.adLockOptimistic)

        'Процессор
        With BASECOMP
            frmGarCPL.cmbCPU1.Text = .Fields("MONITOR_NAME").Value
            frmGarCPL.txtMHZ1.Text = .Fields("MONITOR_DUM").Value
            frmGarCPL.txtSoc1.Text = .Fields("MONITOR_SN").Value
            frmGarCPL.PROizV1.Text = .Fields("MONITOR_PROIZV").Value

            frmGarCPL.cmbCPU2.Text = .Fields("MONITOR_NAME2").Value
            frmGarCPL.txtMHZ2.Text = .Fields("MONITOR_DUM2").Value
            frmGarCPL.txtSoc2.Text = .Fields("MONITOR_SN2").Value
            frmGarCPL.PROizV2.Text = .Fields("MONITOR_PROIZV2").Value


        End With

        With garant_comp

            frmGarCPL.DNG.Value = .Fields("MONITOR_DP").Value & "." & .Fields("MONITOR_MP").Value & "." &
                                  .Fields("MONITOR_GP").Value
            frmGarCPL.DOG.Value = .Fields("MONITOR_DPo").Value & "." & .Fields("MONITOR_MPo").Value & "." &
                                  .Fields("MONITOR_GPo").Value


            frmGarCPL.cmbPostav.Text = .Fields("MONITOR_POST").Value

            'EDTID 'frmMain.nomerPCAbs '.Fields("Id_Comp").value

        End With
        BASECOMP.Close()
        garant_comp.Close()
        garant_comp = Nothing
        BASECOMP = Nothing
        Exit Sub
        Error_:
#If islog Then
WriteLog Err.Description
#End If
    End Sub

    Public Sub IBPsS()
        '"Информация о Сети"
        Dim garant_comp As Recordset
        Dim BASECOMP As Recordset


        garant_comp = New Recordset
        garant_comp.Open("SELECT * FROM garant_comp WHERE Id_Comp =" & frmComputers.sCOUNT, DB7,
                         CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic)

        BASECOMP = New Recordset
        BASECOMP.Open("SELECT * FROM kompy WHERE id =" & frmComputers.sCOUNT, DB7, CursorTypeEnum.adOpenDynamic,
                      LockTypeEnum.adLockOptimistic)


        On Error GoTo Error_
        'Процессор
        With BASECOMP
            frmGarCPL.cmbCPU1.Text = .Fields("IBP_NAME").Value
            frmGarCPL.txtMHZ1.Text = .Fields("IBP_SN").Value
            frmGarCPL.PROizV1.Text = .Fields("IBP_PROIZV").Value


        End With

        With garant_comp

            'frmGarCPL.DNG.Value = .Fields("IBP_DP").value & "." & .Fields("IBP_MP").value & "." & .Fields("IBP_GP").value
            'frmGarCPL.DOG.Value = .Fields("IBP_DPo").value & "." & .Fields("IBP_MPo").value & "." & .Fields("IBP_GPo").value


            frmGarCPL.cmbPostav.Text = .Fields("IBP_POST").Value

            'EDTID 'frmMain.nomerPCAbs '.Fields("Id_Comp").value

        End With
        BASECOMP.Close()
        garant_comp.Close()
        garant_comp = Nothing
        BASECOMP = Nothing
        Exit Sub
        Error_:
#If islog Then
WriteLog Err.Description
#End If
    End Sub

    Public Sub FILTRsS()
        '"Информация о Сети"
        Dim garant_comp As Recordset
        Dim BASECOMP As Recordset

        garant_comp = New Recordset
        garant_comp.Open("SELECT * FROM garant_comp WHERE Id_Comp =" & frmComputers.sCOUNT, DB7,
                         CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic)

        BASECOMP = New Recordset
        BASECOMP.Open("SELECT * FROM kompy WHERE id =" & frmComputers.sCOUNT, DB7, CursorTypeEnum.adOpenDynamic,
                      LockTypeEnum.adLockOptimistic)

        On Error GoTo Error_
        'Процессор
        With BASECOMP
            frmGarCPL.cmbCPU1.Text = .Fields("FILTR_NAME").Value
            frmGarCPL.txtMHZ1.Text = .Fields("FILTR_SN").Value
            frmGarCPL.PROizV1.Text = .Fields("FILTR_PROIZV").Value


        End With

        With garant_comp

            frmGarCPL.DNG.Value = .Fields("FS_DP").Value & "." & .Fields("FS_MP").Value & "." & .Fields("FS_GP").Value
            frmGarCPL.DOG.Value = .Fields("FS_DPo").Value & "." & .Fields("FS_MPo").Value & "." &
                                  .Fields("FS_GPo").Value

            frmGarCPL.cmbPostav.Text = .Fields("FS_POST").Value

            'EDTID 'frmMain.nomerPCAbs '.Fields("Id_Comp").value

        End With
        BASECOMP.Close()
        garant_comp.Close()
        garant_comp = Nothing
        BASECOMP = Nothing

        Exit Sub
        Error_:
#If islog Then
WriteLog Err.Description
#End If
    End Sub

    Public Sub ScanersS()
        '"Информация о Сети"
        Dim garant_comp As Recordset
        Dim BASECOMP As Recordset


        garant_comp = New Recordset
        garant_comp.Open("SELECT * FROM garant_comp WHERE Id_Comp =" & frmComputers.sCOUNT, DB7,
                         CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic)

        BASECOMP = New Recordset
        BASECOMP.Open("SELECT * FROM kompy WHERE id =" & frmComputers.sCOUNT, DB7, CursorTypeEnum.adOpenDynamic,
                      LockTypeEnum.adLockOptimistic)

        On Error GoTo Error_
        'Процессор
        With BASECOMP
            frmGarCPL.cmbCPU1.Text = .Fields("SCANER_NAME").Value
            frmGarCPL.txtMHZ1.Text = .Fields("SCANER_SN").Value
            frmGarCPL.PROizV1.Text = .Fields("SCANER_PROIZV").Value


        End With

        With garant_comp
            'frmGarCPL.DNG.Value = .Fields("SCANER_DP").value & "." & .Fields("SCANER_MP").value & "." & .Fields("SCANER_GP").value
            'frmGarCPL.DOG.Value = .Fields("SCANER_DPo").value & "." & .Fields("SCANER_MPo").value & "." & .Fields("SCANER_GPo").value


            frmGarCPL.cmbPostav.Text = .Fields("SCANER_POST").Value

            'EDTID 'frmMain.nomerPCAbs '.Fields("Id_Comp").value

        End With
        BASECOMP.Close()
        garant_comp.Close()
        garant_comp = Nothing
        BASECOMP = Nothing

        Exit Sub
        Error_:
#If islog Then
WriteLog Err.Description
#End If
    End Sub
End Module
