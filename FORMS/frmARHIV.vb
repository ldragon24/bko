Imports System.ComponentModel
Imports System.IO
Imports Ionic.Zip

Public Class frmARHIV

    Private _backgroundWorker1 As BackgroundWorker
    Private _saveCanceled As Boolean
    Private _totalBytesAfterCompress As Long
    Private _totalBytesBeforeCompress As Long
    Private _nFilesCompleted As Integer
    Private _progress2MaxFactor As Integer
    Private _entriesToZip As Integer

    'Private rvn_DirToZip As String = "dirToZip"
    Private sFIleName As String

    Private Delegate Sub SaveEntryProgress(ByVal e As SaveProgressEventArgs)

    Private Delegate Sub ButtonClick(ByVal sender As Object, ByVal e As EventArgs)

    Private Sub frmARHIV_Load(ByVal sender As Object, ByVal e As EventArgs) Handles Me.Load

        SendFonts(Me)

        Call frmARHIV_Lang()

        Call find_file() 'esq
        'Me.find_file()

    End Sub

    Class ListViewItemComparer
        Implements IComparer

        Private col As Integer

        Public Sub New()
            col = 0
        End Sub

        Public Sub New(ByVal column As Integer)
            col = column
        End Sub

        Public Function Compare(ByVal y As Object, ByVal x As Object) As Integer _
           Implements IComparer.Compare
            Return [String].Compare(CType(x, ListViewItem).SubItems(col).Text, CType(y, ListViewItem).SubItems(col).Text)
        End Function
    End Class

    Private Sub find_file()

        lbArh.Items.Clear()
        Me.lvArh.Items.Clear()
        Me.lvArh.Columns.Clear()
        Me.lvArh.Columns.Add("сорт", 3)
        Me.lvArh.Columns.Add("Дата", 120, HorizontalAlignment.Left)
        Me.lvArh.Columns.Add("Имя", 200, HorizontalAlignment.Left)
        'Me.lvArh.HeaderStyle() = ColumnHeaderStyle.Nonclickable
        Me.lvArh.Sorting() = SortOrder.Ascending
        Me.lvArh.ListViewItemSorter() = New ListViewItemComparer(0)


        Try
            ' Only get files that begin with the letter "c."
            Dim dirs As String() = Directory.GetFiles(PrPath, "arhiv\*.zip")
            ' Console.WriteLine("The number of files starting with c is {0}.", dirs.Length)
            Dim dir As String
            Dim cnt As Integer

            For Each dir In dirs
                Dim d() As String
                d = Split(dir, "\")

                lbArh.Items.Add(d(d.Length - 1))
                lvArh.Items.Add(Format(FileSystem.FileDateTime(dir), "yyMMddHHmmss"))
                cnt = lvArh.Items.Count - 1
                lvArh.Items(cnt).SubItems.Add(FileSystem.FileDateTime(dir))
                lvArh.Items(cnt).SubItems.Add(d(d.Length - 1))
            Next
            lvArh.Sort()
        Catch e1 As Exception
            Console.WriteLine("The process failed: {0}", e1.ToString())
        End Try
    End Sub

    Private Sub btnZIP_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnZipUp.Click
        UnLoadDatabase()

        Me.KickoffZipup()
    End Sub

    Private Sub KickoffZipup()
        Dim dirs As String
        dirs = BasePath
        sFIleName = PrPath & "arhiv\" & GENID() & "_" & Date.Today & "_" & My.Application.Info.Version.Major & "." &
                    My.Application.Info.Version.Minor & "." & My.Application.Info.Version.Build & "." &
                    My.Application.Info.Version.Revision & ".zip"


        Dim folderName As String = dirs

        If _
            (((Not folderName Is Nothing) AndAlso (folderName <> "")) AndAlso
             ((Not sFIleName Is Nothing) AndAlso (sFIleName <> ""))) Then

            If File.Exists(sFIleName) Then
                If _
                    (MessageBox.Show(
                        String.Format(
                            "The file you have specified ({0}) already exists.  Do you want to overwrite this file?",
                            sFIleName), "Confirmation is Required",
                        MessageBoxButtons.YesNo, MessageBoxIcon.Question) <> DialogResult.Yes) Then
                    Return
                End If
                File.Delete(sFIleName)
            End If

            Me._saveCanceled = False
            Me._nFilesCompleted = 0
            Me._totalBytesAfterCompress = 0
            Me._totalBytesBeforeCompress = 0

            Me.btnZipUp.Enabled = False
            'Me.btnZipUp.Text = "Zipping..."
            '  Me.btnCancel.Enabled = True
            Me.lblStatus.Text = "Упаковка..."

            Dim options As New WorkerOptions
            options.ZipName = sFIleName
            options.Folder = folderName

            _backgroundWorker1 = New BackgroundWorker()
            _backgroundWorker1.WorkerSupportsCancellation = False
            _backgroundWorker1.WorkerReportsProgress = False

            AddHandler Me._backgroundWorker1.DoWork, New DoWorkEventHandler(AddressOf Me.DoSave)
            _backgroundWorker1.RunWorkerAsync(options)

        End If
    End Sub

    Private Sub DoSave(ByVal sender As Object, ByVal e As DoWorkEventArgs)
        Dim options As WorkerOptions = e.Argument

        Try
            Using zip1 As ZipFile = New ZipFile
                zip1.AddDirectory(options.Folder)
                Me._entriesToZip = zip1.EntryFileNames.Count
                Me.SetProgressBars()
                AddHandler zip1.SaveProgress, New EventHandler(Of SaveProgressEventArgs)(AddressOf Me.zip1_SaveProgress)
                zip1.Save(options.ZipName)
            End Using
        Catch exc1 As Exception
            MessageBox.Show(String.Format("Исключение при сжатии: {0}", exc1.Message))
            'Me.btnCancel_Click(Nothing, Nothing)
        End Try
    End Sub

    Private Sub zip1_SaveProgress(ByVal sender As Object, ByVal e As SaveProgressEventArgs)
        If Me._saveCanceled Then
            e.Cancel = True
            Return
        End If

        Select Case e.EventType
            Case ZipProgressEventType.Saving_AfterWriteEntry
                Me.StepArchiveProgress(e)
                Exit Select
            Case ZipProgressEventType.Saving_Completed
                Me.SaveCompleted()
                Exit Select
            Case ZipProgressEventType.Saving_EntryBytesRead
                Me.StepEntryProgress(e)
                Exit Select
        End Select
    End Sub

    Private Sub StepArchiveProgress(ByVal e As SaveProgressEventArgs)

        If Me.ProgressBar1.InvokeRequired Then
            Me.ProgressBar1.Invoke(New SaveEntryProgress(AddressOf Me.StepArchiveProgress), New Object() {e})
        ElseIf Not Me._saveCanceled Then
            Me._nFilesCompleted += 1
            Me.ProgressBar1.PerformStep()
            Me._totalBytesAfterCompress = (Me._totalBytesAfterCompress + e.CurrentEntry.CompressedSize)
            Me._totalBytesBeforeCompress = (Me._totalBytesBeforeCompress + e.CurrentEntry.UncompressedSize)
            ' progressBar2 is the one dealing with the item being added to the archive
            ' if we got this event, then the add of that item (or file) is complete, so we 
            ' update the progressBar2 appropriately.
            Me.ProgressBar2.Value = Me.ProgressBar2.Maximum = 1
            MyBase.Update()
        End If
    End Sub

    Private Sub SaveCompleted()
        If Me.lblStatus.InvokeRequired Then
            Me.lblStatus.Invoke(New MethodInvoker(AddressOf SaveCompleted))
            'Me.lblStatus.Invoke(New MethodInvoker(Me, DirectCast(Me.SaveCompleted, IntPtr)))
        Else
            Me.lblStatus.Text = String.Format("Выполнено, заархивировано {0} файлов, {1:N0}% от оригинала",
                                              Me._nFilesCompleted,
                                              ((100 * Me._totalBytesAfterCompress) / CDbl(Me._totalBytesBeforeCompress)))
            Me.ResetState()
            Call find_file() 'esq
            'Me.find_file()

            LoadDatabase()
        End If
    End Sub

    Private Sub StepEntryProgress(ByVal e As SaveProgressEventArgs)
        If Me.ProgressBar2.InvokeRequired Then
            Me.ProgressBar2.Invoke(New SaveEntryProgress(AddressOf Me.StepEntryProgress), New Object() {e})
        ElseIf Not Me._saveCanceled Then
            If (Me.ProgressBar2.Maximum = 1) Then
                Dim entryMax As Long = e.TotalBytesToTransfer
                Dim absoluteMax As Long = &H7FFFFFFF
                Me._progress2MaxFactor = 0
                Do While (entryMax > absoluteMax)
                    entryMax = (entryMax / 2)
                    Me._progress2MaxFactor += 1
                Loop
                If (CInt(entryMax) < 0) Then
                    entryMax = (entryMax * -1)
                End If
                Me.ProgressBar2.Maximum = CInt(entryMax)
                Me.lblStatus.Text = String.Format("{0} из {1} файлов...({2})", (Me._nFilesCompleted + 1),
                                                  Me._entriesToZip, e.CurrentEntry.FileName)
            End If
            Dim xferred As Integer = CInt((e.BytesTransferred >> Me._progress2MaxFactor))
            Me.ProgressBar2.Value = IIf((xferred >= Me.ProgressBar2.Maximum), Me.ProgressBar2.Maximum, xferred)
            MyBase.Update()
        End If
    End Sub

    Private Sub ResetState()
        'Me.btnCancel.Enabled = False
        Me.btnZipUp.Enabled = True
        'Me.btnZipUp.Text = "Zip it!"
        Me.ProgressBar1.Value = 0
        Me.ProgressBar2.Value = 0
        Me.Cursor = Cursors.Default
    End Sub

    Private Sub SetProgressBars()
        If Me.ProgressBar1.InvokeRequired Then
            'Me.ProgressBar1.Invoke(New MethodInvoker(Me, DirectCast(Me.SetProgressBars, IntPtr)))
            Me.ProgressBar1.Invoke(New MethodInvoker(AddressOf SetProgressBars))
        Else
            Me.ProgressBar1.Value = 0
            Me.ProgressBar1.Maximum = Me._entriesToZip
            Me.ProgressBar1.Minimum = 0
            Me.ProgressBar1.Step = 1
            Me.ProgressBar2.Value = 0
            Me.ProgressBar2.Minimum = 0
            Me.ProgressBar2.Maximum = 1
            Me.ProgressBar2.Step = 2
        End If
    End Sub

    Public Class WorkerOptions
        ' Fields
        'Public Comment As String
        'Public CompressionLevel As CompressionLevel
        'Public Encoding As String
        'Public Encryption As EncryptionAlgorithm
        Public Folder As String
        'Public Password As String
        'Public Zip64 As Zip64Option
        'Public ZipFlavor As Integer
        Public ZipName As String
    End Class

End Class