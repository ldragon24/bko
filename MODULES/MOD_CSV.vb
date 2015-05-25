Imports System
Imports System.IO
Module MOD_CSV

    Public Sub ReadFromFile(ByVal strPath As String)
        Dim FileHolder As FileInfo = New FileInfo(strPath)
        Dim ReadFile As StreamReader = FileHolder.OpenText()
        Dim InputText As String
        Dim strLine

        Do
            strLine = ReadFile.ReadLine
            If Not strLine = "" Then
                ParseCSV(strLine)
                'MsgBox("ENDLINE")
            Else
                ReadFile.Close()
                ReadFile = Nothing
            End If
        Loop Until ReadFile Is Nothing

        'Return True

    End Sub


    Public Sub ParseCSV(ByVal CSVstr As String)

        Dim startPos As Integer
        Dim endPos As Integer
        Dim currPos As Integer
        Dim tempPos As Integer
        Dim tempstr As String
        Dim commaPos As Integer
        Dim quotePos As Integer
        Dim strLen As Integer
        Dim charLen As Integer

        startPos = 1
        currPos = 1

        strLen = Len(CSVstr)


        Do While strLen <> 0
            CSVstr = Replace(CSVstr, Chr(34) & Chr(34), "'")
            commaPos = InStr(currPos, CSVstr, ",")
            quotePos = InStr(currPos, CSVstr, Chr(34))
            'last data
            If commaPos = 0 Then
                If quotePos = 0 Then
                    If Not currPos > endPos Then
                        endPos = strLen + 1
                        charLen = endPos - currPos
                        tempstr = Mid(CSVstr, currPos, charLen)
                        'If Not tempstr = "" Then
                        ReadChars(tempstr, 1, charLen, charLen)
                        'End If
                    End If
                Else
                    currPos = quotePos
                    endPos = InStr(currPos + 1, CSVstr, Chr(34))
                    charLen = endPos - currPos
                    tempstr = Mid(CSVstr, currPos + 1, charLen - 1)

                    'If Not tempstr = "" Then
                    ReadChars(tempstr, 1, charLen, charLen)
                    'End If
                End If
                Exit Do
            End If
            'no " in line
            If quotePos = 0 Then

                endPos = commaPos
                charLen = endPos - currPos
                tempstr = Mid(CSVstr, currPos, charLen)
                'If Not tempstr = "" Then
                ReadChars(tempstr, 1, charLen, charLen)
                'End If


            ElseIf (quotePos <> 0) Then
                '" in line
                If commaPos < quotePos Then
                    endPos = commaPos
                    charLen = endPos - currPos
                    tempstr = Mid(CSVstr, currPos, charLen)
                    'If Not tempstr = "" Then
                    ReadChars(tempstr, 1, charLen, charLen)
                    'End If
                Else
                    currPos = quotePos
                    endPos = InStr(currPos + 1, CSVstr, Chr(34))
                    charLen = endPos - currPos
                    tempstr = Mid(CSVstr, currPos + 1, charLen - 1)

                    'If Not tempstr = "" Then
                    ReadChars(tempstr, 1, charLen, charLen)
                    'End If
                    endPos = endPos + 1
                End If
            End If
            currPos = endPos + 1
        Loop



    End Sub

    Public Function ReadChars(ByVal str As String, ByVal StartPos As Integer, ByVal EndPos As Integer, ByVal strLen As Integer)

        Dim strArray As [String] = str
        Dim b(strLen) As Char
        Dim sr As New StringReader(strArray)

        sr.Read(b, 0, EndPos)

        MsgBox(b)

        sr.Close()
    End Function


End Module
