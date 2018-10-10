Imports ZXing
Module MOD_QRCODE
    Public Enum CodeType
        Code39 = 4      'Code 39 1D format.
        Code93 = 8      'Code 93 1D format.
        Code128 = 16    'Code 128 1D format.
        DataMatrix = 32 'Data Matrix 2D barcode format.
        Pdf417 = 1024   'PDF417 format.
        QRCode = 2048   'QR Code 2D barcode format.
    End Enum

    Public fact As Factors
    Public EncodingOptions As Common.EncodingOptions
    Public Renderer As Rendering.IBarcodeRenderer(Of Bitmap)

    Public Function optPDF_417() As PDF417.PDF417EncodingOptions
        Dim options = New PDF417.PDF417EncodingOptions
        With options
            .Width = fact.Width
            .Height = fact.Height
            .GS1Format = fact.GS1
            .Margin = fact.Margin
            .PureBarcode = fact.PureBarcode
            .ErrorCorrection = fact.Pdf417ErrorCorrection
            .CharacterSet = getCharset(fact.CharacterSet.ToString)
            .Compact = fact.Pdf417Compact
            .Compaction = fact.Pdf417Compaction
        End With
        Return options
    End Function

    Public Function optQR_CODE() As QrCodeEncodingOptions
        Dim options = New QrCodeEncodingOptions
        With options
            .Width = fact.Width
            .Height = fact.Height
            .GS1Format = fact.GS1
            .Margin = fact.Margin
            .PureBarcode = fact.PureBarcode
            Dim erCr As String = fact.ErrorCorrection.ToString
            Select Case erCr
                'Case "L" '7%
                '    .ErrorCorrection = QrCode.Internal.ErrorCorrectionLevel.L
                'Case "M" '15%
                '    .ErrorCorrection = QrCode.Internal.ErrorCorrectionLevel.M
                'Case "Q" '25%
                '    .ErrorCorrection = QrCode.Internal.ErrorCorrectionLevel.Q
                'Case "H" '30%
                '    .ErrorCorrection = QrCode.Internal.ErrorCorrectionLevel.H
            End Select
            .CharacterSet = getCharset(fact.CharacterSet.ToString) ' s
        End With
        Return options
    End Function

    Public Function optDATA_MATRIX() As Datamatrix.DatamatrixEncodingOptions
        Dim options = New Datamatrix.DatamatrixEncodingOptions
        With options
            .Width = fact.Width
            .Height = fact.Height
            .GS1Format = fact.GS1
            .Margin = fact.Margin
            .PureBarcode = fact.PureBarcode
            .SymbolShape = fact.DataMatrixShape
        End With
        Return options
    End Function

    Public Function optCODE_128() As OneD.Code128EncodingOptions
        Dim options = New OneD.Code128EncodingOptions
        With options
            .Width = fact.Width
            .Height = fact.Height
            .GS1Format = fact.GS1
            .Margin = fact.Margin
            .PureBarcode = fact.PureBarcode
            .ForceCodesetB = True
        End With
        Return options
    End Function

    Private Function getCharset(ByVal ss As String) As String
        Select Case ss
            Case "ASCII"
                ss = "US-ASCII"
            Case Else
                ss = ss.Replace("_"c, "-"c)
        End Select
        Return ss
    End Function

    Public Function loadBitmap(ByVal fileName As String) As Bitmap
        If Not IO.File.Exists(fileName) Then Return Nothing
        Using bm As Bitmap = New Bitmap(fileName)
            Return New Bitmap(bm)
        End Using
    End Function
End Module
