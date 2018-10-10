Imports System.ComponentModel
Imports ZXing
Public Enum ErrCorrectionLevel
    L
    M
    Q
    H
End Enum
Public Enum CharSet
    ASCII
    ISO_8859_1
    ISO_8859_5
    ISO_8859_15
    windows_1250
    windows_1251
    windows_1252
    UTF_8
End Enum
Public Class Factors
    Public Sub New()
        _Width = 336
        _Height = 316
        _PureBarcode = True
        _ErrorCorrection = ErrCorrectionLevel.L
        _CharacterSet = CharSet.ISO_8859_1
        _Margin = 10
        _Pdf417Compact = False
        _Pdf417Compaction = PDF417.Internal.Compaction.AUTO
        _Pdf417ErrorCorrection = PDF417.Internal.PDF417ErrorCorrectionLevel.L0
        _DataMatrixShape = Datamatrix.Encoder.SymbolShapeHint.FORCE_NONE
        _GS1 = False
    End Sub
    <Description("ширина изображения, px")>
    Public Property Width As Integer
    <Description("высота изображения, px")>
    Public Property Height As Integer
    <Description("true - не включать значение в изображение")>
    Public Property PureBarcode As Boolean
    <Description("степень коррекции ошибок"),
        Category("QRCode")>
    Public Property ErrorCorrection As ErrCorrectionLevel
    <Description("кодировка символов")>
    Public Property CharacterSet As CharSet
    <Description("в зависимости от формата (до и после штрих-кода по горизонтали для большинства 1D-форматов, в px)")>
    Public Property Margin As Integer
    <Description("следует ли использовать компактный режим для PDF417"),
                 Category("Pdf417")>
    Public Property Pdf417Compact As Boolean
    <Description("режим уплотнения для PDF417"),
        Category("Pdf417")>
    Public Property Pdf417Compaction As PDF417.Internal.Compaction
    <Description("степень коррекции ошибок Pdf417"),
        Category("Pdf417")>
    Public Property Pdf417ErrorCorrection As PDF417.Internal.PDF417ErrorCorrectionLevel
    <Description("определяет матричную форму для матрицы данных"),
        Category("Matrix")>
    Public Property DataMatrixShape As Datamatrix.Encoder.SymbolShapeHint
    <Description("использовать стандарт GS1 (General Specifications)")>
    Public Property GS1 As Boolean
End Class
