Imports System.Net.Mail
Imports System.Net
Imports System.Text
'Imports System
'Imports System.IO
Imports System.Security.Cryptography

Module MOD_SENDMAIL

    Private sCRTKey As String = "HfcibahjdrfCjj,otybz0981"
    'HfcibahjdrfCjj,otybz0981"

 Public Function EncryptString(ByVal sTEXTBLOC As String) As String

        Try

            '    Dim AESkey As New AesCryptoServiceProvider()
            '    AESkey.IV = UnicodeEncoding.Unicode.GetBytes(Mid(sCRTKey, 1, 8)) 'вектор
            '    AESkey.Key = UnicodeEncoding.Unicode.GetBytes(Mid(sCRTKey, 9, 16)) 'Ключ
            '    Dim inBlock() As Byte = UnicodeEncoding.Unicode.GetBytes(sTEXTBLOC)
            '    Dim AEStransForm As ICryptoTransform = AESkey.CreateEncryptor()
            '    Dim outBlock() As Byte = AEStransForm.TransformFinalBlock(inBlock, 0, inBlock.Length)

            '    Return Convert.ToBase64String(outBlock)

        Catch ex As Exception

            '    Return "ERR_" + ex.Message
        End Try

    End Function
    
    Public Function DecryptBytes(ByVal sTEXTBLOC As String) As String

        If Len(sTEXTBLOC) = 0 Then Exit Function

        Try

            '    Dim AESkey As New AesCryptoServiceProvider()
            '    AESkey.IV = UnicodeEncoding.Unicode.GetBytes(Mid(sCRTKey, 1, 8)) 'вектор
            '    AESkey.Key = UnicodeEncoding.Unicode.GetBytes(Mid(sCRTKey, 9, 16)) 'Ключ
            '    Dim inBytes() As Byte = Convert.FromBase64String(sTEXTBLOC)
            '    Dim AEStransForm As ICryptoTransform = AESkey.CreateDecryptor()
            '    Dim outBlock() As Byte = AEStransForm.TransformFinalBlock(inBytes, 0, inBytes.Length)

            '    Return UnicodeEncoding.Unicode.GetString(outBlock)

        Catch ex As Exception

            '    Return "ERR_" + ex.Message
        End Try

    End Function
End Module
