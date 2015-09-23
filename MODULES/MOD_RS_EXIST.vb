Module MOD_RS_EXIST
    Public Function RSExistsSoft(ByVal sSID As String, ByVal sGroupName As String) As Boolean
        On Error GoTo Error_
        RSExistsSoft = False
        Dim sSQL2 As String

        sGroupName = Replace(sGroupName, "'", " ")
        If Len(sGroupName) = 0 Then Exit Function

        sSQL2 = "SELECT COUNT(*) AS total_number FROM SOFT_INSTALL WHERE Id_Comp= " & sSID & " AND Soft='" & sGroupName &
                "'"

        Dim rs As Recordset
        rs = New Recordset

        If Len(sGroupName) = 0 Then Exit Function
        rs.Open(sSQL2, DB7, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic)

        Select Case rs.Fields("total_number").Value

            Case 0

            Case Else
                RSExistsSoft = True
                rs.Close()
                rs = Nothing
                Exit Function
        End Select

        rs.Close()
        rs = Nothing

        RSExistsSoft = False

        Exit Function
Error_:
        RSExistsSoft = False
    End Function

    Public Function RSExists(ByVal rs123 As String, ByVal fs As String, ByVal sGroupName As String) As Boolean

        On Error GoTo Error_
        RSExists = False
        Dim sSQL2 As String

        sGroupName = Replace(sGroupName, "'", " ")


        'sSQL2 = "SELECT COUNT(*) AS total_number FROM SOFT_INSTALL WHERE " & fs & "='" & sGroupName & "'"


        If Len(sGroupName) = 0 Then
            RSExists = True
            Exit Function
        End If


        Select Case rs123


            Case "BP"
                'sSQL2 = "SELECT * FROM SPR_PROIZV"
                sSQL2 = "SELECT COUNT(*) AS total_number FROM SPR_BP WHERE " & fs & "='" & sGroupName & "'"

            Case "CASE"
                'sSQL2 = "SELECT * FROM SPR_PROIZV"
                sSQL2 = "SELECT COUNT(*) AS total_number FROM SPR_CASE WHERE " & fs & "='" & sGroupName & "'"

            Case "CREADER"
                'sSQL2 = "SELECT * FROM SPR_PROIZV"
                sSQL2 = "SELECT COUNT(*) AS total_number FROM SPR_CREADER WHERE " & fs & "='" & sGroupName & "'"

            Case "PO"
                'sSQL2 = "SELECT * FROM SPR_PROIZV"
                sSQL2 = "SELECT COUNT(*) AS total_number FROM SPR_PO WHERE " & fs & "='" & sGroupName & "'"

            Case "TIPPO"
                'sSQL2 = "SELECT * FROM SPR_PROIZV"
                sSQL2 = "SELECT COUNT(*) AS total_number FROM SPR_TIP_PO WHERE " & fs & "='" & sGroupName & "'"

            Case "PROYZV"
                'sSQL2 = "SELECT * FROM SPR_PROIZV"
                sSQL2 = "SELECT COUNT(*) AS total_number FROM SPR_PROIZV WHERE " & fs & "='" & sGroupName & "'"

            Case "SPR_LIC"
                'sSQL2 = "SELECT * FROM SPR_LIC"
                sSQL2 = "SELECT COUNT(*) AS total_number FROM SPR_LIC WHERE " & fs & "='" & sGroupName & "'"

            Case "CPUS"
                'sSQL2 = "SELECT * FROM SPR_CPU"
                sSQL2 = "SELECT COUNT(*) AS total_number FROM SPR_CPU WHERE " & fs & "='" & sGroupName & "'"

            Case "MB"
                'sSQL2 = "SELECT * FROM SPR_MB"
                sSQL2 = "SELECT COUNT(*) AS total_number FROM SPR_MB WHERE " & fs & "='" & sGroupName & "'"

            Case "RAM"
                'sSQL2 = "SELECT * FROM SPR_RAM"
                sSQL2 = "SELECT COUNT(*) AS total_number FROM SPR_RAM WHERE " & fs & "='" & sGroupName & "'"

            Case "HDDS"
                'sSQL2 = "SELECT * FROM SPR_HDD"
                sSQL2 = "SELECT COUNT(*) AS total_number FROM SPR_HDD WHERE " & fs & "='" & sGroupName & "'"

            Case "SVGA"
                'sSQL2 = "SELECT * FROM SPR_SVGA"
                sSQL2 = "SELECT COUNT(*) AS total_number FROM SPR_SVGA WHERE " & fs & "='" & sGroupName & "'"

            Case "SOUND"
                'sSQL2 = "SELECT * FROM SPR_SOUND"
                sSQL2 = "SELECT COUNT(*) AS total_number FROM SPR_SOUND WHERE " & fs & "='" & sGroupName & "'"

            Case "CDROMS"
                'sSQL2 = "SELECT * FROM SPR_OPTICAL"
                sSQL2 = "SELECT COUNT(*) AS total_number FROM SPR_OPTICAL WHERE " & fs & "='" & sGroupName & "'"

            Case "CDRWS"
                'sSQL2 = "SELECT * FROM SPR_OPTICAL"
                sSQL2 = "SELECT COUNT(*) AS total_number FROM SPR_OPTICAL WHERE " & fs & "='" & sGroupName & "'"

            Case "DVDROMS"
                'sSQL2 = "SELECT * FROM SPR_OPTICAL"
                sSQL2 = "SELECT COUNT(*) AS total_number FROM SPR_OPTICAL WHERE " & fs & "='" & sGroupName & "'"

            Case "NET"
                'sSQL2 = "SELECT * FROM SPR_NET"
                sSQL2 = "SELECT COUNT(*) AS total_number FROM SPR_NET WHERE " & fs & "='" & sGroupName & "'"

            Case "FDDs"
                'sSQL2 = "SELECT * FROM SPR_FDD"
                sSQL2 = "SELECT COUNT(*) AS total_number FROM SPR_FDD WHERE " & fs & "='" & sGroupName & "'"

            Case "MODEM"
                'sSQL2 = "SELECT * FROM SPR_MODEM"
                sSQL2 = "SELECT COUNT(*) AS total_number FROM SPR_MODEM WHERE " & fs & "='" & sGroupName & "'"

            Case "KEYBOARD"
                'sSQL2 = "SELECT * FROM SPR_KEYBOARD"
                sSQL2 = "SELECT COUNT(*) AS total_number FROM SPR_KEYBOARD WHERE " & fs & "='" & sGroupName & "'"

            Case "MOUSE"
                'sSQL2 = "SELECT * FROM SPR_MOUSE"
                sSQL2 = "SELECT COUNT(*) AS total_number FROM SPR_MOUSE WHERE " & fs & "='" & sGroupName & "'"

            Case "USB"
                'sSQL2 = "SELECT * FROM SPR_USB"
                sSQL2 = "SELECT COUNT(*) AS total_number FROM SPR_USB WHERE " & fs & "='" & sGroupName & "'"

            Case "MONITOR"
                'sSQL2 = "SELECT * FROM SPR_MONITOR"
                sSQL2 = "SELECT COUNT(*) AS total_number FROM SPR_MONITOR WHERE " & fs & "='" & sGroupName & "'"

            Case "DNDEV"

                sSQL2 = "SELECT COUNT(*) AS total_number FROM SPR_NET_DEV WHERE " & fs & "='" & sGroupName & "'"

            Case "NDEV"

                sSQL2 = "SELECT COUNT(*) AS total_number FROM SPR_DEV_NET WHERE " & fs & "='" & sGroupName & "'"

            Case "ASISTEM"
                'sSQL2 = "SELECT * FROM SPR_ASISTEM"
                sSQL2 = "SELECT COUNT(*) AS total_number FROM SPR_ASISTEM WHERE " & fs & "='" & sGroupName & "'"

            Case "IBP"
                'sSQL2 = "SELECT * FROM SPR_IBP"
                sSQL2 = "SELECT COUNT(*) AS total_number FROM SPR_IBP WHERE " & fs & "='" & sGroupName & "'"

            Case "SCANER"
                'sSQL2 = "SELECT * FROM SPR_SCANER"
                sSQL2 = "SELECT COUNT(*) AS total_number FROM SPR_SCANER WHERE " & fs & "='" & sGroupName & "'"

            Case "otv"
                'sSQL2 = "SELECT * FROM SPR_OTV"
                sSQL2 = "SELECT COUNT(*) AS total_number FROM SPR_OTV WHERE " & fs & "='" & sGroupName & "'"

            Case "TIPS"
                'sSQL2 = "SELECT * FROM SPR_TIP"
                sSQL2 = "SELECT COUNT(*) AS total_number FROM SPR_TIP WHERE " & fs & "='" & sGroupName & "'"

            Case "FILIAL"
                'sSQL2 = "SELECT * FROM SPR_FILIAL"
                sSQL2 = "SELECT COUNT(*) AS total_number FROM SPR_FILIAL WHERE " & fs & "='" & sGroupName & "'"

            Case "mesto"
                'sSQL2 = "SELECT * FROM SPR_MESTO"
                sSQL2 = "SELECT COUNT(*) AS total_number FROM SPR_MESTO WHERE " & fs & "='" & sGroupName & "'"

            Case "MFU"
                'sSQL2 = "SELECT * FROM SPR_MFU"
                sSQL2 = "SELECT COUNT(*) AS total_number FROM SPR_MFU WHERE " & fs & "='" & sGroupName & "'"

            Case "CARTR"
                'sSQL2 = "SELECT * FROM spr_cart"
                sSQL2 = "SELECT COUNT(*) AS total_number FROM spr_cart WHERE " & fs & "='" & sGroupName & "'"

            Case "Postav"
                'sSQL2 = "SELECT * FROM SPR_Postav"
                sSQL2 = "SELECT COUNT(*) AS total_number FROM SPR_Postav WHERE " & fs & "='" & sGroupName & "'"

            Case "PDC"
                'sSQL2 = "SELECT * FROM spr_pdc"
                sSQL2 = "SELECT COUNT(*) AS total_number FROM spr_pdc WHERE " & fs & "='" & sGroupName & "'"

            Case "PRINTERY"
                'sSQL2 = "SELECT * FROM SPR_PRINTER"
                sSQL2 = "SELECT COUNT(*) AS total_number FROM SPR_PRINTER WHERE " & fs & "='" & sGroupName & "'"

            Case "KOPIRY"
                'sSQL2 = "SELECT * FROM SPR_KOPIR"
                sSQL2 = "SELECT COUNT(*) AS total_number FROM SPR_KOPIR WHERE " & fs & "='" & sGroupName & "'"

            Case "SPR_DEV"
                'sSQL2 = "SELECT * FROM SPR_DEV_NET"
                sSQL2 = "SELECT COUNT(*) AS total_number FROM SPR_DEV_NET WHERE " & fs & "='" & sGroupName & "'"

            Case "PHOTO"
                'sSQL2 = "SELECT * FROM spr_photo"
                sSQL2 = "SELECT COUNT(*) AS total_number FROM spr_photo WHERE " & fs & "='" & sGroupName & "'"

            Case "FAX"
                'sSQL2 = "SELECT * FROM spr_fax"
                sSQL2 = "SELECT COUNT(*) AS total_number FROM spr_fax WHERE " & fs & "='" & sGroupName & "'"

            Case "PHONE"
                'sSQL2 = "SELECT * FROM spr_phone"
                sSQL2 = "SELECT COUNT(*) AS total_number FROM spr_phone WHERE " & fs & "='" & sGroupName & "'"

            Case "spr_zip"
                'sSQL2 = "SELECT * FROM spr_zip"
                sSQL2 = "SELECT COUNT(*) AS total_number FROM spr_zip WHERE " & fs & "='" & sGroupName & "'"

            Case "T_Que"
                'sSQL2 = "SELECT * FROM T_Que"
                sSQL2 = "SELECT COUNT(*) AS total_number FROM T_Que WHERE " & fs & "='" & sGroupName & "'"

            Case "OTHER"
                'sSQL2 = "SELECT * FROM T_Que"
                sSQL2 = "SELECT COUNT(*) AS total_number FROM spr_other WHERE " & fs & "='" & sGroupName & "'"

            Case "OTHD"
                'sSQL2 = "SELECT * FROM T_Que"
                sSQL2 = "SELECT COUNT(*) AS total_number FROM SPR_OTH_DEV WHERE " & fs & "='" & sGroupName & "'"

            Case "SPR_FS"
                'sSQL2 = "SELECT * FROM T_Que"
                sSQL2 = "SELECT COUNT(*) AS total_number FROM SPR_FS WHERE " & fs & "='" & sGroupName & "'"

            Case "USER"
                'sSQL2 = "SELECT * FROM T_Que"
                sSQL2 = "SELECT COUNT(*) AS total_number FROM SPR_USER WHERE " & fs & "='" & sGroupName & "'"

            Case "COMPL"

                sSQL2 = "SELECT COUNT(*) AS total_number FROM SPR_Complect WHERE " & fs & "='" & sGroupName & "'"

            Case "MASTER"

                sSQL2 = "SELECT COUNT(*) AS total_number FROM SPR_Master WHERE " & fs & "='" & sGroupName & "'"

            Case "SPR_Uroven"

                sSQL2 = "SELECT COUNT(*) AS total_number FROM SPR_Uroven WHERE " & fs & "='" & sGroupName & "'"

            Case "spr_vip"

                sSQL2 = "SELECT COUNT(*) AS total_number FROM spr_vip WHERE " & fs & "='" & sGroupName & "'"
               
            Case "spr_tip_z"

                sSQL2 = "SELECT COUNT(*) AS total_number FROM spr_tip_z WHERE " & fs & "='" & sGroupName & "'"

        End Select


        Dim rs As Recordset
        rs = New Recordset

        If Len(sGroupName) = 0 Then Exit Function
        rs.Open(sSQL2, DB7, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic)

         Select Case rs.Fields("total_number").Value

            Case 0

            Case Else
                RSExists = True
                rs.Close()
                rs = Nothing
                Exit Function
        End Select

        rs.Close()
        rs = Nothing

        RSExists = False

        Exit Function
        Error_:
        RSExists = False
        'MsgBox(Err.Description)
    End Function

    Public Function RSExistsDB(ByVal sBR As String, ByVal sDP As String) As Boolean
        On Error GoTo Error_
        RSExistsDB = False
        Dim sSQL2 As String

        sBR = Replace(sBR, "'", " ")
        If Len(sBR) = 0 Then Exit Function
        If Len(sDP) = 0 Then Exit Function

        sSQL2 = "SELECT COUNT(*) AS total_number FROM SPR_OTD_FILIAL WHERE N_OTD='" & sDP & "' AND FILIAL='" & sBR & "'"

        Dim rs As Recordset
        rs = New Recordset

        If Len(sBR) = 0 Then Exit Function
        rs.Open(sSQL2, DB7, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic)

       Select Case rs.Fields("total_number").Value

            Case 0

            Case Else
                RSExistsDB = True
                rs.Close()
                rs = Nothing
                Exit Function
        End Select

        rs.Close()
        rs = Nothing

        RSExistsDB = False

        Exit Function
        Error_:
        RSExistsDB = False
    End Function

    Public Function RSExistsDBO(ByVal sBR As String, ByVal sDP As String, ByVal sOFF As String) As Boolean
        On Error GoTo Error_
        RSExistsDBO = False
        Dim sSQL2 As String

        sBR = Replace(sBR, "'", " ")
        If Len(sBR) = 0 Then Exit Function
        If Len(sDP) = 0 Then Exit Function

        sSQL2 = "SELECT COUNT(*) AS total_number FROM SPR_KAB WHERE N_M='" & sDP & "' AND N_F='" & sBR & "' AND Name='" &
                sOFF & "'"

        Dim rs As Recordset
        rs = New Recordset

        If Len(sBR) = 0 Then Exit Function
        rs.Open(sSQL2, DB7, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic)

       Select Case rs.Fields("total_number").Value

            Case 0

            Case Else
                RSExistsDBO = True
                rs.Close()
                rs = Nothing
                Exit Function
        End Select

        rs.Close()
        rs = Nothing

        RSExistsDBO = False

        Exit Function
        Error_:
        RSExistsDBO = False
    End Function
End Module
