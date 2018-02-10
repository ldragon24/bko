Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Drawing
Imports System.Text
Imports System.Windows.Forms
Imports System.Drawing.Imaging

Imports ThoughtWorks.QRCode.Codec
Imports ThoughtWorks.QRCode.Codec.Data
Imports ThoughtWorks.QRCode.Codec.Util


Public Class QrCode
    Inherits Form

    Private Sub QrCode_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Activated
        frmMain.SaveInfTehButton.Enabled = False
        frmMain.ToolStripDropDownButton1.Enabled = False
    End Sub

    Private Sub QrCode_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        cboEncoding.SelectedIndex = 2
        cboVersion.SelectedIndex = 6
        cboCorrectionLevel.SelectedIndex = 1
    End Sub

    Private Sub btnEncode_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEncode.Click
        If txtEncodeData.Text.Trim() = [String].Empty Then
            MessageBox.Show("Data must not be empty.")
            Return
        End If

        Dim qrCodeEncoder__1 As New QRCodeEncoder()
        Dim encoding As [String] = cboEncoding.Text
        If encoding = "Byte" Then
            qrCodeEncoder__1.QRCodeEncodeMode = QRCodeEncoder.ENCODE_MODE.[BYTE]
        ElseIf encoding = "AlphaNumeric" Then
            qrCodeEncoder__1.QRCodeEncodeMode = QRCodeEncoder.ENCODE_MODE.ALPHA_NUMERIC
        ElseIf encoding = "Numeric" Then
            qrCodeEncoder__1.QRCodeEncodeMode = QRCodeEncoder.ENCODE_MODE.NUMERIC
        End If
        Try
            Dim scale As Integer = Convert.ToInt16(txtSize.Text)
            qrCodeEncoder__1.QRCodeScale = scale
        Catch ex As Exception
            MessageBox.Show("Invalid size!")
            Return
        End Try
        Try
            Dim version As Integer = Convert.ToInt16(cboVersion.Text)
            qrCodeEncoder__1.QRCodeVersion = version
        Catch ex As Exception
            MessageBox.Show("Invalid version !")
        End Try

        Dim errorCorrect As String = cboCorrectionLevel.Text
        If errorCorrect = "L" Then
            qrCodeEncoder__1.QRCodeErrorCorrect = QRCodeEncoder.ERROR_CORRECTION.L
        ElseIf errorCorrect = "M" Then
            qrCodeEncoder__1.QRCodeErrorCorrect = QRCodeEncoder.ERROR_CORRECTION.M
        ElseIf errorCorrect = "Q" Then
            qrCodeEncoder__1.QRCodeErrorCorrect = QRCodeEncoder.ERROR_CORRECTION.Q
        ElseIf errorCorrect = "H" Then
            qrCodeEncoder__1.QRCodeErrorCorrect = QRCodeEncoder.ERROR_CORRECTION.H
        End If

        Dim image As Image
        Dim data As [String] = txtEncodeData.Text
        image = qrCodeEncoder__1.Encode(data)
        picEncode.Image = image
    End Sub

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        saveFileDialog1.Filter = "JPeg Image|*.jpg|Bitmap Image|*.bmp|Gif Image|*.gif|PNG Image|*.png"
        saveFileDialog1.Title = "Save"
        saveFileDialog1.FileName = String.Empty
        saveFileDialog1.ShowDialog()

        ' If the file name is not an empty string open it for saving.
        If saveFileDialog1.FileName <> "" Then
            ' Saves the Image via a FileStream created by the OpenFile method.
            Dim fs As System.IO.FileStream = DirectCast(saveFileDialog1.OpenFile(), System.IO.FileStream)
            ' Saves the Image in the appropriate ImageFormat based upon the
            ' File type selected in the dialog box.
            ' NOTE that the FilterIndex property is one-based.
            Select Case saveFileDialog1.FilterIndex
                Case 1
                    Me.picEncode.Image.Save(fs, System.Drawing.Imaging.ImageFormat.Jpeg)
                    Exit Select

                Case 2
                    Me.picEncode.Image.Save(fs, System.Drawing.Imaging.ImageFormat.Bmp)
                    Exit Select

                Case 3
                    Me.picEncode.Image.Save(fs, System.Drawing.Imaging.ImageFormat.Gif)
                    Exit Select
                Case 4
                    Me.picEncode.Image.Save(fs, System.Drawing.Imaging.ImageFormat.Png)
                    Exit Select
            End Select

            fs.Close()
        End If
    End Sub

    Private Sub btnPrint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPrint.Click
        'PrintDialog1.Document = printDocument1
        'Dim r As DialogResult = PrintDialog1.ShowDialog()
        'If r = DialogResult.OK Then
        '    printDocument1.Print()
        'End If
    End Sub

    Private Sub printDocument1_PrintPage(ByVal sender As Object, ByVal e As System.Drawing.Printing.PrintPageEventArgs)
        e.Graphics.DrawImage(picEncode.Image, 0, 0)
    End Sub

    Private Sub btnOpen_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOpen.Click
        'openFileDialog1.InitialDirectory = "c:\\";
        openFileDialog1.Filter = "JPeg Image|*.jpg|Bitmap Image|*.bmp|Gif Image|*.gif|PNG Image|*.png|All files (*.*)|*.*"
        openFileDialog1.FilterIndex = 1
        openFileDialog1.RestoreDirectory = True
        openFileDialog1.FileName = String.Empty

        If openFileDialog1.ShowDialog() = DialogResult.OK Then
            Dim fileName As [String] = openFileDialog1.FileName

            picDecode.Image = New Bitmap(fileName)
        End If
    End Sub

    Private Sub btnDecode_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDecode.Click
        Try
            Dim decoder As New QRCodeDecoder()
            'QRCodeDecoder.Canvas = new ConsoleCanvas();
            Dim decodedString As [String] = decoder.decode(New QRCodeBitmapImage(New Bitmap(picDecode.Image)))
            txtDecodedData.Text = decodedString
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
End Class