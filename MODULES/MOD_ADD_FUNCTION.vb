Module MOD_ADD_FUNCTION
    Public Function AddPr(ByVal sGroupName As String) As Long
        On Error GoTo ERR1
        If Len(sGroupName) = 0 Then Exit Function
        If sGroupName = "<N/A>" Then Exit Function

        If Len(sGroupName) = 0 Or sGroupName = " " Or Len(sGroupName) < 3 Then Exit Function

        Dim rs As Recordset
        rs = New Recordset

        If Len(sGroupName) > 0 Or sGroupName <> "NoName" Or Len(sGroupName) > 1 Then
            DB7.Execute("INSERT INTO SPR_PROIZV (PROIZV) VALUES ('" & sGroupName & "')")
        Else
        End If

        AddPr = 1

        Exit Function
ERR1:
        MsgBox(Err.Description)
        AddPr = -1
    End Function

    Public Function AddOnePar(ByVal sGroupName As String, ByVal sColumns As String, ByVal sTABLE As String,
                              ByVal sCOMBO As ComboBox) As Long

        On Error GoTo ERR1
        If Len(sGroupName) = 0 Then Exit Function

        Select Case TipTehn

            Case "CNT"

                DB7.Execute("INSERT INTO  " & sTABLE & " (" & sColumns & ", C) VALUES ('" & sGroupName & "', '1')")
            Case Else

                DB7.Execute("INSERT INTO  " & sTABLE & " (" & sColumns & ") VALUES ('" & sGroupName & "')")
        End Select

        sCOMBO.Items.Add(sGroupName)

        AddOnePar = 1

        Exit Function
ERR1:
        AddOnePar = -1
        MsgBox(Err.Description)
    End Function

    Public Function AddTwoPar(ByVal sGroupName As String, ByVal sPR As String, ByVal sTABLE As String,
                              ByVal sCOMBO As ComboBox) As Long
        On Error GoTo ERR1

        Dim uname As Integer

        If Len(sGroupName) = 0 Then Exit Function

        If Len(sPR) < 3 Then sPR = "NoName"


        If Not RSExists("PROYZV", "PROiZV", sPR) Then
            AddPr(sPR)
        End If
        Dim rs As Recordset
        rs = New Recordset
        rs.Open("SELECT * FROM SPR_PROIZV WHERE Proizv ='" & sPR & "'", DB7, CursorTypeEnum.adOpenDynamic,
                LockTypeEnum.adLockOptimistic)

        With rs
            uname = .Fields("id").Value
        End With
        rs.Close()
        rs = Nothing

        DB7.Execute("INSERT INTO " & sTABLE & " (Name,proizv) VALUES ('" & sGroupName & "', " & uname & ")")
       
        sCOMBO.Items.Add(sGroupName)

        AddTwoPar = 1

        Exit Function
        ERR1:
        AddTwoPar = - 1
    End Function

    Public Function AddFOwPar(ByVal sGroupName As String, ByVal sMHZ As String, ByVal sSoc As String,
                              ByVal sPR As String, ByVal sTABLE As String, ByVal sCOMBO As ComboBox) As Long
        On Error GoTo ERR1

        If Len(sGroupName) = 0 Then Exit Function
        Dim uname As Integer

        If Len(sPR) < 3 Then sPR = "NoName"

        If Not (RSExists("PROYZV", "PROiZV", Trim(sPR))) Then
            AddPr(Trim(sPR))
        End If

        Dim rs As Recordset
        rs = New Recordset
        rs.Open("SELECT * FROM SPR_PROIZV WHERE Proizv ='" & sPR & "'", DB7, CursorTypeEnum.adOpenDynamic,
                LockTypeEnum.adLockOptimistic)

        With rs
           
            uname = .Fields("id").Value
               
        End With
        rs.Close()
        rs = Nothing

        DB7.Execute("INSERT INTO " & sTABLE & " (Name,proizv,A,B) VALUES ('" & sGroupName & "', " & uname & ",'" & sMHZ & "','" & sSoc & "')")

        sCOMBO.Items.Add(sGroupName)

        AddFOwPar = 1

        Exit Function
        ERR1:
        AddFOwPar = - 1
    End Function

    Public Function AddTreePar(ByVal sGroupName As String, ByVal sMHZ As String, ByVal sPR As String,
                               ByVal sTABLE As String, ByVal sCOMBO As ComboBox) As Long
        On Error GoTo ERR1
        If Len(sGroupName) = 0 Then Exit Function
        Dim uname As Integer

        If Len(sPR) < 3 Then sPR = "NoName"

        If Not RSExists("PROYZV", "PROiZV", sPR) Then
            AddPr(sPR)
        End If

        Dim rs As Recordset
        rs = New Recordset
        rs.Open("SELECT * FROM SPR_PROIZV WHERE Proizv ='" & sPR & "'", DB7, CursorTypeEnum.adOpenDynamic,
                LockTypeEnum.adLockOptimistic)

        With rs

            uname = .Fields("id").Value

        End With
        rs.Close()
        rs = Nothing

        DB7.Execute("INSERT INTO " & sTABLE & " (Name,a,proizv) VALUES ('" & sGroupName & "', '" & sMHZ & "'," & uname & ")")

        sCOMBO.Items.Add(sGroupName)


        AddTreePar = 1
        Exit Function
        ERR1:
        AddTreePar = - 1
    End Function

    Public Function AddDepartment(ByVal sBR As String, ByVal sDP As String) As Long

        On Error GoTo ERR1
        If Len(sBR) = 0 Then Exit Function
        If Len(sDP) = 0 Then Exit Function

        DB7.Execute("INSERT INTO SPR_OTD_FILIAL (N_OTD,FILIAL) VALUES ('" & sDP & "','" & sBR & "')")

        AddDepartment = 1

        Exit Function
        ERR1:
        AddDepartment = - 1
    End Function

    Public Function AddOffice(ByVal sBR As String, ByVal sDP As String, ByVal sOFF As String) As Long

        On Error GoTo ERR1
        If Len(sBR) = 0 Then Exit Function
        If Len(sDP) = 0 Then Exit Function
        If Len(sOFF) = 0 Then Exit Function

        Dim strSimbol1, strSimbol2 As String
        strSimbol1 = "'" : strSimbol2 = "."

        sOFF = Replace(sOFF, strSimbol1, "")
        sDP = Replace(sDP, strSimbol1, "")
        sBR = Replace(sBR, strSimbol1, "")

        DB7.Execute("INSERT INTO SPR_KAB (N_M,N_F,Name) VALUES ('" & sDP & "','" & sBR & "','" & sOFF & "')")

        AddOffice = 1

        Exit Function
        ERR1:
        AddOffice = - 1
    End Function
End Module
