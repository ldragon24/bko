Imports System.IO

Module MOD_Database
    Public unamDB As String
    Public DBserv As String
    Public DBtabl As String
    Public DBuser As String
    Public DBpass As String
    Public DBport As String
    Public DBsec As String
    Public DATAB As Boolean
    Public BasePath As String
    Public Base_Name As String
    Public DB_N As String

    Public strPassword As String, Temp As String
    Public SUBD As String

    Public DB7 As Connection
    Public ConNect As String

    Public Function GENID() As Long

        Randomize()
        GENID = Int(Rnd()*1000000000)


        'Dim numbers As Integer() = Enumerable.Range(1, 1000000000).ToArray()
    End Function

    Public Sub LoadDatabase(Optional ByRef sFile As String = "")
        On Error GoTo ERR1
        Dim uname As String
        sFile = Base_Name

        If Len(unamDB) = 0 Or unamDB = Nothing Then Exit Sub
        If unamDB = "MS Access" And Len(sFile) = 0 Then Exit Sub

        Dim MyShadowPassword As String
        Dim TempStr As String

        DATAB = True
        sFile = Base_Name

        MyShadowPassword = ""


        If Len(unamDB) = 0 Then
            unamDB = "MS Access"
        Else
        End If
        DB7 = New Connection

        DB_N = unamDB

        Select Case unamDB

            'Case "MS SQL 2008-file"


            '    DB7.Open("Driver={SQL Server Native Client 10.0};Server=./SQLEXPRESS;AttachDBFileName=" & BasePath & "\" & "mSQL.bak;Database=mSQL;Uid=sa;Pwd=lfplhf1vf!;Trusted_connection=Yes;")


            Case "MS SQL 2008"

                DB7.Open(
                    "Driver={SQL Server Native Client 10.0};Server=" & DBserv & ";Database=" & DBtabl & ";Uid=" & DBuser & ";Pwd=" & DBpass & ";")

                Base_Name = DBserv & "\" & DBtabl
            Case "MS SQL"

                '2000
                DB7.Open(
                    "Driver={SQL Server};Server=" & DBserv & ";Database=" & DBtabl & ";Uid=" & DBuser & ";Pwd=" & DBpass &
                    ";")

                Base_Name = DBserv & "\" & DBtabl

            Case "MS Access"

                DB7.Open("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" & BasePath & "\" & sFile & ";Jet OLEDB:Database Password=" & MyShadowPassword & ";")

            Case "MS Access 2007"

                DB7.Open("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & BasePath & "\" & sFile & ";Persist Security Info=False" & ";")

            Case "MySQL"

                DB7.Open(
                    "Driver={MySQL ODBC 3.51 Driver};Server=" & DBserv & ";Port=" & DBport & ";Database=" & DBtabl &
                    ";User=" & DBuser & "; Password=" & DBpass & ";OPTION=2059; -С;")

                'Driver={MySQL ODBC 3.51 Driver};Server=myServerAddress;charset=UTF8;Database=myDataBase;User=myUsername; Password=myPassword;Option=3;
                'DB7.Open("Driver={MySQL ODBC 5.1 Driver};Server=" & DBserv & ";Port=" & DBport & ";Database=" & DBtabl & ";User=" & DBuser & "; Password=" & DBpass & ";OPTION=2059;")
                'DB7.Open("DSN=BKO2;Server=" & DBserv & ";Port=" & DBport & ";Database=" & DBtabl & ";Uid=" & DBuser & ";Pwd=" & DBpass & ";")

                Base_Name = DBserv & "\" & DBtabl

            Case "MySQL (MyODBC 5.1)"

                DB7.Open(
                    "Driver={MySQL ODBC 5.1 Driver};Server=" & DBserv & ";Database=" & DBtabl & ";Port=" & DBport &
                    ";User=" & DBuser & "; Password=" & DBpass & ";Option=2059;-С;")

                Base_Name = DBserv & "\" & DBtabl

            Case "PostgreSQL"

                DB7.Open(
                    "DSN=PGS;Server=" & DBserv & ";Port=" & DBport & ";Database=" & DBtabl & ";Uid=" & DBuser & ";Pwd=" &
                    DBpass & ";")

                'DB7.Open("Driver={PostgreSQL};Server=" & DBserv & ";Port=" & DBport & ";Database=" & DBtabl & ";Uid=" & DBuser & ";Pwd=" & DBpass & ";")

                'DB7.Open("DSN=PGS" & ";UID=" & DBuser & ";PWD=" & DBpass & ";" & "Database=" & DBtabl & ";")

                Base_Name = DBserv & "\" & DBtabl

            Case "SQLLite"

                DB7.Open(
                    "DRIVER=SQLite3 ODBC Driver;Database=" & BasePath & "\" & sFile &
                    ";LongNames=0;Timeout=1000;NoTXN=0;SyncPragma=NORMAL;StepAPI=0;")

            Case "DSN"
                DB7.Open("DSN=" & DBserv & ";UID=" & DBuser & ";PWD=" & DBpass & ";")


        End Select


        Exit Sub
        ERR1:

        DATAB = False
        MsgBox(Err.Description)

        If unamDB = "MS Access" Then


            BasePath = Directory.GetParent(Application.ExecutablePath).ToString & "\database\"

            Dim objIniFile As New IniFile(PrPath & "base.ini")
            objIniFile.WriteString("general", "BasePath", BasePath)

            'LoadDatabase()


        Else

            MsgBox(Err.Description)

        End If
    End Sub

    Public Sub UnLoadDatabase(Optional ByRef sFile As String = "")

        On Error GoTo err_


        If Len(unamDB) = 0 Or unamDB = Nothing Then Exit Sub
        'If unamDB = "MS Access" And Len(sFile) = 0 Then Exit Sub
        If DATAB = False Then Exit Sub

        DB7.Close()
        DB7 = Nothing

        DATAB = False
        Exit Sub
        Err_:
    End Sub


    Public Sub EncryptDecrypt(ByVal Strpassword As String)
        Dim i, Code, intLocation

        Code = "1234567890" 'This is key for encrypting/decrypting
        Temp = ""
        For i = 1 To Len(Strpassword)
            intLocation = (i Mod Len(Code)) + 1
            'Use XOR logic combination for encrypting/decrypting
            Temp = Temp + Chr(Asc(Mid(Strpassword, i, 1)) Xor Asc(Mid(Code, intLocation, 1)))
        Next
    End Sub
End Module
