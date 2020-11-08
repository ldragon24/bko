Imports System.IO

Public Class Form1
    Private File_bitmap_path As String
    Private Exc As Object = CreateObject("Excel.Application")
    Private ExcWB As Workbook
    Private matrix()() As Color
    Private heightBMP As Integer
    Private widthBMP As Integer
    Private file_is_create As Boolean = False

    Public Sub GetBitmapColorMatrix(ByVal filePath As String)
        Dim bmp As New Bitmap(filePath)
        heightBMP = bmp.Height
        widthBMP = bmp.Width
        If heightBMP > widthBMP Then
            matrix = New Color(bmp.Width - 1)() {}
            Dim i As Integer = 0
            Do While i <= bmp.Width - 1
                matrix(i) = New Color(bmp.Height - 1) {}
                Dim j As Integer = 0
                Do While j < bmp.Height - 1
                    matrix(i)(j) = bmp.GetPixel(i, j)
                    j += 1
                Loop
                i += 1
            Loop
        Else
            matrix = New Color(bmp.Height - 1)() {}
            Dim i As Integer = 0
            Do While i <= bmp.Height - 1
                matrix(i) = New Color(bmp.Width - 1) {}
                Dim j As Integer = 0
                Do While j < bmp.Width - 1
                    matrix(i)(j) = bmp.GetPixel(j, i)
                    j += 1
                Loop
                i += 1
            Loop
        End If
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        ' конвертировать

        If File_bitmap_path <> "" Then
            Select Case (MsgBox("Если хотите сконвертировать в Excel, нажмите ""Да"", в DataGridView, нажмите ""Нет""", vbYesNo + vbQuestion))
                Case vbYes
                    'Me.Enabled = False
                    'Form2.Show()
                    'Form2.Location = Me.Location
                    GetBitmapColorMatrix(File_bitmap_path)
                    ExcWB = Exc.Workbooks.Add
                    Dim xls = ExcWB.Worksheets(1)
                    Exc.Visible = False
                    file_is_create = True
                    'xls.Range(xls.Cells(1, 1), xls.Cells(heightBMP, widthBMP)).ColumnWidth = 2.14
                    'xls.Range(xls.Cells(1, 1), xls.Cells(heightBMP, widthBMP)).RowHeight = 15
                    xls.range(xls.rows(1), xls.rows(heightBMP)).RowHeight = 15.0
                    xls.range(xls.columns(1), xls.columns(widthBMP)).ColumnWidth = 2.14
                    'Dim schetchik As Integer = 0
                    ProgressBar1.Maximum = heightBMP - 1
                    For y As Integer = 1 To heightBMP - 1
                        'If schetchik >= heightBMP / 100 Then
                        '    ProgressBar1.Value += 1
                        '    schetchik = 0
                        'End If
                        ProgressBar1.Value = y
                        For x As Integer = 1 To widthBMP - 1
                            'Form2.PictureBox1.Refresh()
                            If widthBMP > heightBMP Then xls.Cells(y, x).Interior.Color = matrix(y - 1)(x - 1)
                            If heightBMP > widthBMP Then xls.Cells(y, x).Interior.Color = matrix(x - 1)(y - 1)
                        Next
                        'schetchik += 1
                    Next
                Case vbNo
                    
                    GetBitmapColorMatrix(File_bitmap_path)

                    Form3.Show()
                    Dim gridV As Object = Form3.DataGridView1
                    gridV.ColumnCount = widthBMP
                    gridV.RowCount = heightBMP
                    For i As Integer = 0 To gridV.ColumnCount - 1
                        For j As Integer = 0 To gridV.RowCount - 1
                            Form3.DataGridView1.Columns(i).Width = 5
                            Form3.DataGridView1.Rows(j).Height = 5
                            If widthBMP > heightBMP Then Form3.DataGridView1.Rows(j).Cells(i).Style.BackColor = matrix(j)(i)
                            If heightBMP > widthBMP Then Form3.DataGridView1.Rows(j).Cells(i).Style.BackColor = matrix(i)(j)
                        Next
                    Next
                    

                    'Form3.DataGridView1.CurrentCell = (1,1)


                    'ExcWB = Exc.Workbooks.Add
                    'Dim xls = ExcWB.Worksheets(1)
                    'Exc.Visible = False
                    'file_is_create = True

                    'xls.range(xls.rows(1), xls.rows(heightBMP)).RowHeight = 15.0
                    'xls.range(xls.columns(1), xls.columns(widthBMP)).ColumnWidth = 2.14

                    'ProgressBar1.Maximum = heightBMP - 1
                    'For y As Integer = 1 To heightBMP - 1

                    '    ProgressBar1.Value = y
                    '    For x As Integer = 1 To widthBMP - 1

                    '        If widthBMP > heightBMP Then xls.Cells(y, x).Interior.Color = matrix(y - 1)(x - 1)
                    '        If heightBMP > widthBMP Then xls.Cells(y, x).Interior.Color = matrix(x - 1)(y - 1)
                    '    Next

                    'Next
            End Select

            
        End If
        ProgressBar1.Value = 0
        'Form2.Close()
        'Me.Enabled = True
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        ' выбрать файл
        Dim openFileDialog As New OpenFileDialog With {.Filter = "Файлы Images|*.bmp;*.png;*.jpg"}
        If openFileDialog.ShowDialog() = DialogResult.OK Then
            File_bitmap_path = Path.GetFullPath(openFileDialog.FileName)
            PictureBox1.Load(File_bitmap_path)
        End If

    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        If file_is_create Then
            ExcWB.Application.DisplayAlerts = False
            ExcWB.Close()
            Exc = Nothing
        End If
        Me.Close()
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        If file_is_create Then
            Dim SFD As New SaveFileDialog With {.Filter = "Файлы Excel|*.xls"}
            If SFD.ShowDialog = System.Windows.Forms.DialogResult.OK Then
                ExcWB.Application.DisplayAlerts = False
                ExcWB.SaveAs(SFD.FileName)
                If CreateObject("Scripting.FilesyStemObject").FileExists(SFD.FileName) Then
                    MsgBox(SFD.FileName & Chr(10) & Chr(10) & "Успешно сохранен!")
                    ExcWB.Close()
                    file_is_create = False
                Else
                    MsgBox("Ошибка сохранения, праверьте правильность введенных данных!")
                End If
            End If
        End If
    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class
