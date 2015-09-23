Module MOD_REMOVE
    Public Sub REMOVE_TEHN(ByVal sSID As String)
        On Error GoTo Error_
        On Error Resume Next

        DB7.Execute("DELETE FROM Garantia_sis WHERE Id_Comp=" & sSID)
        DB7.Execute("DELETE FROM garant_comp WHERE Id_Comp=" & sSID)
        DB7.Execute("DELETE FROM SOFT_INSTALL WHERE Id_Comp=" & sSID)
        DB7.Execute("DELETE FROM Update_Log WHERE Id_Comp=" & sSID)
        DB7.Execute("DELETE FROM USER_COMP WHERE Id_Comp=" & sSID)
        DB7.Execute("DELETE FROM tbl_bios WHERE Id_Comp=" & sSID)

        Select Case TipTehn

            Case "NET"
                DB7.Execute("DELETE FROM net_port WHERE id_net=" & sSID)
                DB7.Execute("DELETE FROM net_port WHERE Id_Comp=" & sSID)

        End Select
      
        DB7.Execute("DELETE FROM AKT_SP_OS3 WHERE Id_Comp=" & sSID)
        DB7.Execute("DELETE FROM ActOS WHERE computer=" & sSID)
        DB7.Execute("DELETE FROM TrebOvanie WHERE computer='" & sSID & "'")
        DB7.Execute("DELETE FROM dvig WHERE Id_Comp=" & sSID)


        Dim rs As Recordset

        rs = New Recordset
        rs.Open("Select count(*) as t_n FROM Remont where id_comp = " & sSID, DB7, CursorTypeEnum.adOpenDynamic,
                LockTypeEnum.adLockOptimistic)
        Dim sCOUNT As Integer

        With rs
            sCOUNT = .Fields("t_n").Value
        End With
        rs.Close()
        rs = Nothing


        Select Case sCOUNT

            Case 0


            Case Else

                rs = New Recordset
                rs.Open("Select id FROM Remont where id_comp = " & sSID, DB7, CursorTypeEnum.adOpenDynamic,
                        LockTypeEnum.adLockOptimistic)

                With rs
                    .MoveFirst()
                    Do While Not .EOF

                        DB7.Execute("DELETE FROM remonty_plus WHERE id_rem=" & .Fields("id").Value)

                        .MoveNext()
                    Loop
                End With
                rs.Close()
                rs = Nothing

        End Select

        DB7.Execute("DELETE FROM Remont WHERE Id_Comp=" & sSID)
        DB7.Execute("DELETE FROM Zametki WHERE Id_Comp=" & sSID)
        DB7.Execute("DELETE FROM kompy WHERE id=" & sSID)

        DB7.Execute("UPDATE CARTRIDG SET USTR = 0 WHERE USTR=" & sSID)

        DB7.Execute("UPDATE kompy SET PCL='0' where PCL = " & sSID)

        Call FIND_TREE_TAG(frmComputers.lstGroups.Nodes, "C|" & sSID)
        frmComputers.lstGroups.SelectedNode.Remove()

        Exit Sub
Error_:
        MsgBox(Err.Description)
    End Sub

    Public Function RemoveProyzv(ByVal sMestoName As String)
        On Error GoTo ERR1
        On Error Resume Next

        Dim UC As Long
        Dim asert As String
        If Trim(sMestoName) = "" Or sMestoName = 0 Then
            GoTo ERR1
        End If


        Dim rs As Recordset
        rs = New Recordset
        rs.Open("SELECT count(*) as t_n FROM SPR_CPU where Proizv=" & sMestoName, DB7, CursorTypeEnum.adOpenKeyset)
        With rs
            asert = .Fields("t_n").Value
        End With
        rs.Close()
        rs = Nothing

        If asert > 0 Then UC = UC + 1


        rs = New Recordset
        rs.Open("SELECT count(*) as t_n FROM SPR_MB where Proizv=" & sMestoName, DB7, CursorTypeEnum.adOpenKeyset)
        With rs
            asert = .Fields("t_n").Value
        End With
        rs.Close()
        rs = Nothing

        If asert > 0 Then UC = UC + 1


        rs = New Recordset
        rs.Open("SELECT count(*) as t_n FROM spr_cart where Proizv=" & sMestoName, DB7, CursorTypeEnum.adOpenKeyset)
        With rs
            asert = .Fields("t_n").Value
        End With
        rs.Close()
        rs = Nothing

        If asert > 0 Then UC = UC + 1


        rs = New Recordset
        rs.Open("SELECT count(*) as t_n FROM SPR_SVGA where Proizv=" & sMestoName, DB7, CursorTypeEnum.adOpenKeyset)
        With rs
            asert = .Fields("t_n").Value
        End With
        rs.Close()
        rs = Nothing

        If asert > 0 Then UC = UC + 1

        rs = New Recordset
        rs.Open("SELECT count(*) as t_n FROM SPR_RAM where Proizv=" & sMestoName, DB7, CursorTypeEnum.adOpenKeyset)
        With rs
            asert = .Fields("t_n").Value
        End With
        rs.Close()
        rs = Nothing

        If asert > 0 Then UC = UC + 1


        rs = New Recordset
        rs.Open("SELECT count(*) as t_n FROM SPR_HDD where Proizv=" & sMestoName, DB7, CursorTypeEnum.adOpenKeyset)
        With rs
            asert = .Fields("t_n").Value
        End With
        rs.Close()
        rs = Nothing

        If asert > 0 Then UC = UC + 1

        rs = New Recordset
        rs.Open("SELECT count(*) as t_n FROM SPR_SOUND where Proizv=" & sMestoName, DB7, CursorTypeEnum.adOpenKeyset)
        With rs
            asert = .Fields("t_n").Value
        End With
        rs.Close()
        rs = Nothing

        If asert > 0 Then UC = UC + 1

        rs = New Recordset
        rs.Open("SELECT count(*) as t_n FROM SPR_OPTICAL where Proizv=" & sMestoName, DB7, CursorTypeEnum.adOpenKeyset)
        With rs
            asert = .Fields("t_n").Value
        End With
        rs.Close()
        rs = Nothing

        If asert > 0 Then UC = UC + 1


        rs = New Recordset
        rs.Open("SELECT count(*) as t_n FROM SPR_NET where Proizv=" & sMestoName, DB7, CursorTypeEnum.adOpenKeyset)
        With rs
            asert = .Fields("t_n").Value
        End With
        rs.Close()
        rs = Nothing

        If asert > 0 Then UC = UC + 1

        rs = New Recordset
        rs.Open("SELECT count(*) as t_n FROM SPR_FDD where Proizv=" & sMestoName, DB7, CursorTypeEnum.adOpenKeyset)
        With rs
            asert = .Fields("t_n").Value
        End With
        rs.Close()
        rs = Nothing

        If asert > 0 Then UC = UC + 1


        rs = New Recordset
        rs.Open("SELECT count(*) as t_n FROM SPR_MODEM where Proizv=" & sMestoName, DB7, CursorTypeEnum.adOpenKeyset)
        With rs
            asert = .Fields("t_n").Value
        End With
        rs.Close()
        rs = Nothing

        If asert > 0 Then UC = UC + 1


        rs = New Recordset
        rs.Open("SELECT count(*) as t_n FROM SPR_KEYBOARD where Proizv=" & sMestoName, DB7, CursorTypeEnum.adOpenKeyset)
        With rs
            asert = .Fields("t_n").Value
        End With
        rs.Close()
        rs = Nothing

        If asert > 0 Then UC = UC + 1

        rs = New Recordset
        rs.Open("SELECT count(*) as t_n FROM SPR_MOUSE where Proizv=" & sMestoName, DB7, CursorTypeEnum.adOpenKeyset)
        With rs
            asert = .Fields("t_n").Value
        End With
        rs.Close()
        rs = Nothing

        If asert > 0 Then UC = UC + 1

        rs = New Recordset
        rs.Open("SELECT count(*) as t_n FROM SPR_USB where Proizv=" & sMestoName, DB7, CursorTypeEnum.adOpenKeyset)
        With rs
            asert = .Fields("t_n").Value
        End With
        rs.Close()
        rs = Nothing

        If asert > 0 Then UC = UC + 1


        rs = New Recordset
        rs.Open("SELECT count(*) as t_n FROM SPR_PCI where Proizv=" & sMestoName, DB7, CursorTypeEnum.adOpenKeyset)
        With rs
            asert = .Fields("t_n").Value
        End With
        rs.Close()
        rs = Nothing

        If asert > 0 Then UC = UC + 1

        rs = New Recordset
        rs.Open("SELECT count(*) as t_n FROM SPR_MONITOR where Proizv=" & sMestoName, DB7, CursorTypeEnum.adOpenKeyset)
        With rs
            asert = .Fields("t_n").Value
        End With
        rs.Close()
        rs = Nothing

        If asert > 0 Then UC = UC + 1


        rs = New Recordset
        rs.Open("SELECT count(*) as t_n FROM SPR_ASISTEM where Proizv=" & sMestoName, DB7, CursorTypeEnum.adOpenKeyset)
        With rs
            asert = .Fields("t_n").Value
        End With
        rs.Close()
        rs = Nothing

        If asert > 0 Then UC = UC + 1

        rs = New Recordset
        rs.Open("SELECT count(*) as t_n FROM SPR_IBP where Proizv=" & sMestoName, DB7, CursorTypeEnum.adOpenKeyset)
        With rs
            asert = .Fields("t_n").Value
        End With
        rs.Close()
        rs = Nothing

        If asert > 0 Then UC = UC + 1

        rs = New Recordset
        rs.Open("SELECT count(*) as t_n FROM SPR_FS where Proizv=" & sMestoName, DB7, CursorTypeEnum.adOpenKeyset)
        With rs
            asert = .Fields("t_n").Value
        End With
        rs.Close()
        rs = Nothing

        If asert > 0 Then UC = UC + 1


        rs = New Recordset
        rs.Open("SELECT count(*) as t_n FROM SPR_PRINTER where Proizv=" & sMestoName, DB7, CursorTypeEnum.adOpenKeyset)
        With rs
            asert = .Fields("t_n").Value
        End With
        rs.Close()
        rs = Nothing

        If asert > 0 Then UC = UC + 1

        rs = New Recordset
        rs.Open("SELECT count(*) as t_n FROM SPR_KOPIR where Proizv=" & sMestoName, DB7, CursorTypeEnum.adOpenKeyset)
        With rs
            asert = .Fields("t_n").Value
        End With
        rs.Close()
        rs = Nothing

        If asert > 0 Then UC = UC + 1

        rs = New Recordset
        rs.Open("SELECT count(*) as t_n FROM SPR_SCANER where Proizv=" & sMestoName, DB7, CursorTypeEnum.adOpenKeyset)
        With rs
            asert = .Fields("t_n").Value
        End With
        rs.Close()
        rs = Nothing

        If asert > 0 Then UC = UC + 1


        rs = New Recordset
        rs.Open("SELECT count(*) as t_n FROM SPR_DEV_NET where Proizv=" & sMestoName, DB7, CursorTypeEnum.adOpenKeyset)
        With rs
            asert = .Fields("t_n").Value
        End With
        rs.Close()
        rs = Nothing

        If asert > 0 Then UC = UC + 1


        Dim LNGIniFile As New IniFile(sLANGPATH)
        'LNGIniFile.GetString("MOD_REMOVE", "MSG1", "Найдено")

        If UC > 0 Then
            'users are in this group
            If _
                MsgBox(
                    LNGIniFile.GetString("MOD_REMOVE", "MSG1", "Найдено") & " " & UC & " " &
                    LNGIniFile.GetString("MOD_REMOVE", "MSG2",
                                         "производителей в справочниках, Ваше действие может привести к потере данных, желаете продолжить удаление?"),
                    MsgBoxStyle.Exclamation + vbYesNo, ProGramName) = vbNo Then Exit Function

        Else


        End If

        'rs = New Recordset
        'rs.Open("delete FROM SPR_PROIZV WHERE id=" & sMestoName, DB7, CursorTypeEnum.adOpenDynamic,
        '        LockTypeEnum.adLockOptimistic)
        'rs = Nothing

        DB7.Execute("delete FROM SPR_PROIZV WHERE id=" & sMestoName)

        RemoveProyzv = 1

        Exit Function

        RemoveProyzv = -1

        Exit Function
ERR1:

        MsgBox("Database error: " & vbNewLine & vbNewLine & Err.Description, vbCritical, "Database Error!")
    End Function

    Public Function RemoveBrainch(ByVal sGroupName As Long, ByVal stxt As String)
        On Error GoTo ERR1
        Dim UC As Long
        Dim LNGIniFile As New IniFile(sLANGPATH)

        'If Trim(sGroupName) = "" Then Exit Function

        Dim rs As Recordset

        rs = New Recordset
        rs.Open("SELECT COUNT(*) AS total_number FROM kompy WHERE FILIAL='" & stxt & "'", DB7,
                CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic)

        With rs
            UC = .Fields("total_number").Value
        End With
        rs.Close()
        rs = Nothing

        'LNGIniFile.GetString("MOD_REMOVE", "MSG1", "Найдено")

        If UC > 0 Then
            'users are in this group
            If _
                MsgBox(
                    LNGIniFile.GetString("MOD_REMOVE", "MSG1", "Найдено") & " " & UC & " " &
                    LNGIniFile.GetString("MOD_REMOVE", "MSG3",
                                         "единиц техники в филиале, Ваше действие может привести к потере данных, желаете продолжить удаление -") &
                    " " & stxt & " ?" & vbCrLf &
                    LNGIniFile.GetString("MOD_REMOVE", "MSG6",
                                         "ри удалении структуры техника не удаляется. Будьте внимательны."),
                    vbExclamation + vbYesNo, ProGramName) = vbNo Then
                ' Exit Function
                GoTo ERR1
            End If


        Else

        End If

        DB7.Execute("DELETE FROM SPR_FILIAL WHERE id=" & sGroupName)

        'rs = New Recordset
        'rs.Open("DELETE FROM SPR_FILIAL WHERE id=" & sGroupName, DB7, CursorTypeEnum.adOpenDynamic,
        '        LockTypeEnum.adLockOptimistic)
        'rs = Nothing

        RemoveBrainch = 1

        Select Case TREE_UPDATE
            Case 0
                Call RefFilTree(frmComputers.lstGroups)
            Case 1
                '    FIND_TREE(sGroupName)

                Call FIND_TREE_TAG(frmComputers.lstGroups.Nodes, "G|" & sGroupName)

                frmComputers.lstGroups.SelectedNode.Remove()
        End Select

        Call LoadSPR()

        Exit Function


        RemoveBrainch = -1

        'MsgBox("Не найдено филиала " & sGroupName, vbExclamation + vbApplicationModal, "Error!")


        Exit Function
ERR1:
    End Function

    Public Function RemoveDepartment(ByVal sKab As Long)
        On Error GoTo ERR1

        Dim UC As Long

        Dim sFilName, sGroupName As String

        If Trim(sKab) = "" Then
            GoTo ERR1
        End If


        If sKab = 0 Then GoTo ERR1
        If Len(sKab) = 0 Then GoTo ERR1

        Dim rs As Recordset
        rs = New Recordset
        rs.Open("Select * from SPR_OTD_FILIAL where id =" & sKab, DB7, CursorTypeEnum.adOpenDynamic,
                LockTypeEnum.adLockOptimistic)

        With rs
            sGroupName = .Fields("N_Otd").Value
            sFilName = .Fields("Filial").Value
        End With

        rs.Close()
        rs = Nothing

        rs = New Recordset
        rs.Open(
            "SELECT COUNT(*) AS total_number FROM kompy WHERE FILIAL='" & sFilName & "' and mesto='" & sGroupName & "'",
            DB7, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic)

        With rs
            UC = .Fields("total_number").Value
        End With
        rs.Close()
        rs = Nothing
        Dim LNGIniFile As New IniFile(sLANGPATH)

        If UC > 0 Then
            'users are in this group

            If _
                MsgBox(
                    LNGIniFile.GetString("MOD_REMOVE", "MSG1", "Найдено") & " " & UC & " " &
                    LNGIniFile.GetString("MOD_REMOVE", "MSG4",
                                         "единиц техники в отделе, Ваше действие может привести к потере данных, желаете продолжить удаление") &
                    " " & sGroupName & " ?" & vbCrLf &
                    LNGIniFile.GetString("MOD_REMOVE", "MSG6",
                                         "При удалении структуры техника не удаляется. Будьте внимательны."),
                    vbExclamation + vbYesNo, ProGramName) = vbNo Then
                GoTo ERR1
            End If

        Else


        End If

        DB7.Execute("DELETE FROM SPR_OTD_FILIAL WHERE Id=" & sKab)

        'rs = New Recordset
        'rs.Open("DELETE FROM SPR_OTD_FILIAL WHERE Id=" & sKab, DB7, CursorTypeEnum.adOpenDynamic,
        '        LockTypeEnum.adLockOptimistic)
        'rs = Nothing
        RemoveDepartment = 1

        Select Case TREE_UPDATE
            Case 0
                Call RefFilTree(frmComputers.lstGroups)
            Case 1
                '  FIND_TREE(sGroupName)
                Call FIND_TREE_TAG(frmComputers.lstGroups.Nodes, "O|" & sKab)

                frmComputers.lstGroups.SelectedNode.Remove()
        End Select

        Exit Function

        RemoveDepartment = -1
        MsgBox("Не найден отдел" & " " & sGroupName & "'", vbExclamation + vbApplicationModal, "Error!")


        Exit Function
ERR1:
    End Function

    Public Function RemoveOffice(ByVal sKab As Long)
        On Error GoTo ERR1

        Dim UC As Long

        Dim sBran, sDepart, sOffice As String

        If Trim(sKab) = "" Then GoTo ERR1
        If sKab = 0 Then GoTo ERR1
        If Len(sKab) = 0 Then GoTo ERR1

        Dim rs As Recordset
        rs = New Recordset
        rs.Open("Select * from SPR_KAB where id =" & sKab, DB7, CursorTypeEnum.adOpenDynamic,
                LockTypeEnum.adLockOptimistic)

        With rs
            sDepart = .Fields("N_M").Value
            sBran = .Fields("N_F").Value
            sOffice = .Fields("Name").Value
        End With

        rs.Close()
        rs = Nothing

        rs = New Recordset
        rs.Open(
            "SELECT COUNT(*) AS total_number FROM kompy WHERE FILIAL='" & sBran & "' and mesto='" & sDepart &
            "' and kabn='" & sOffice & "'", DB7, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic)

        With rs
            UC = .Fields("total_number").Value
        End With
        rs.Close()
        rs = Nothing

        Dim LNGIniFile As New IniFile(sLANGPATH)

        If UC > 0 Then

            If _
                MsgBox(
                    LNGIniFile.GetString("MOD_REMOVE", "MSG1", "Найдено") & " " & UC & " " &
                    LNGIniFile.GetString("MOD_REMOVE", "MSG5",
                                         "единиц техники в кабинете, Ваше действие может привести к потере данных, желаете продолжить удаление") &
                    " " & sOffice & " ?" & vbCrLf &
                    LNGIniFile.GetString("MOD_REMOVE", "MSG6",
                                         "При удалении структуры техника не удаляется. Будьте внимательны."),
                    vbExclamation + vbYesNo, ProGramName) = vbNo Then
                GoTo ERR1
            End If


        Else

        End If

        DB7.Execute("DELETE FROM SPR_KAB WHERE Id=" & sKab)

        'rs = New Recordset
        'rs.Open("DELETE FROM SPR_KAB WHERE Id=" & sKab, DB7, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic)
        'rs = Nothing
        RemoveOffice = 1

        ' Call RefFilTree(frmComputers.lstGroups)
        Select Case TREE_UPDATE
            Case 0
                Call RefFilTree(frmComputers.lstGroups)
            Case 1
                ' FIND_TREE(sOffice)
                Call FIND_TREE_TAG(frmComputers.lstGroups.Nodes, "K|" & sKab)

                frmComputers.lstGroups.SelectedNode.Remove()
        End Select

        Exit Function

        RemoveOffice = -1
        MsgBox(LNGIniFile.GetString("MOD_REMOVE", "MSG7", "Не найден кабинет") & " " & sOffice & "'",
               vbExclamation + vbApplicationModal, "Error!")


        Exit Function
ERR1:
    End Function
End Module
