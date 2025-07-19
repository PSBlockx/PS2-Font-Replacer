Imports System.Diagnostics.Eventing.Reader
Imports System.IO
Imports System.ComponentModel
Public Class Form1
    Public Shared doneLoading As Boolean = False
    Public Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If Not File.Exists(CurDir() + "\LaunchPad.exe") Then
            MessageBox.Show("Could not locate PS2 LaunchPad. Please ensure exe is placed in PS2 game folder.")
            End
        End If
        If File.Exists(iniPath) Then
            iniini = File.ReadAllLines(iniPath).ToList
        Else
            Dim inistart As String = "[iniEdit]"
            File.WriteAllText(iniPath, inistart)
            iniini = File.ReadAllLines(iniPath).ToList
        End If
        readAllOptions()
        doneLoading = True
        BackgroundWorker1.RunWorkerAsync()
    End Sub
    Function readAllOptions()
        'Big list of checking where the options are at cus i dont code good
#Region "iniEditGets"
        fontAutoCheck.Checked = GetStateMyIni("FontAutoReplace=")
        fontAutoCheck2.Checked = GetStateMyIni("FontAutoReplace2=")
        If fontAutoCheck.Checked Then
            selectedFontPath.Visible = True
            fontSelectButton.Visible = True
        Else
            selectedFontPath.Visible = False
            fontSelectButton.Visible = False
        End If
        If fontAutoCheck2.Checked Then
            selectedFontPath2.Visible = True
            fontSelectButton2.Visible = True
        Else
            selectedFontPath2.Visible = False
            fontSelectButton2.Visible = False
        End If
        selectedFontPath.Text = GetStateMyIni("FontFilePath=")
        selectedFontPath2.Text = GetStateMyIni("FontFilePath2=")
        localeReplaceCheck.Checked = GetStateMyIni("LocaleAutoReplace=")
        If localeReplaceCheck.Checked Then
            localeDatButton.Visible = True
            localeDirButton.Visible = True
            selectedDatPath.Visible = True
            selectedDirPath.Visible = True
        Else
            localeDatButton.Visible = False
            localeDirButton.Visible = False
            selectedDatPath.Visible = False
            selectedDirPath.Visible = False
        End If
        selectedDirPath.Text = GetStateMyIni("LocaleDirPath=")
        selectedDatPath.Text = GetStateMyIni("LocaleDatPath=")
        commandAutoCheck.Checked = GetStateMyIni("CommandAutoReplace=")
        If commandAutoCheck.Checked Then
            commandTextBox.Visible = True
        Else
            commandTextBox.Visible = False
        End If
        If File.Exists(commandPath) Then
            commandTextBox.Lines = File.ReadAllLines(commandPath)
        End If
        randomizeCheck.Checked = GetStateMyIni("FontRandomize=")
        If randomizeCheck.Checked Then
            rerandomizeButton.Visible = True
            randomizeFolderButton.Visible = True
            fontFolderPath.Visible = True
        Else
            rerandomizeButton.Visible = False
            randomizeFolderButton.Visible = False
            fontFolderPath.Visible = False
        End If
        fontFolderPath.Text = GetStateMyIni("FontRandomFolder=")
#End Region
    End Function
#Region "FontStuff"
    Private Sub fontSelectButton_Click(sender As Object, e As EventArgs) Handles fontSelectButton.Click
        Dim fontPath As String = Nothing
        Dim fontDialog As New OpenFileDialog()

        fontDialog.Filter = "TrueType Font files (*.ttf)|*.ttf"
        fontDialog.RestoreDirectory = True

        If fontDialog.ShowDialog() = DialogResult.OK Then
            'Using a dialog, get the desired font file path
            fontPath = fontDialog.FileName.ToString
            'Show user selected font path
            selectedFontPath.Text() = fontPath
            UpdateValMyIni("FontFilePath=", fontPath)
        End If
    End Sub
    Private Sub fontSelectButton2_Click(sender As Object, e As EventArgs) Handles fontSelectButton2.Click
        Dim fontPath As String = Nothing
        Dim fontDialog As New OpenFileDialog()

        fontDialog.Filter = "TrueType Font files (*.ttf)|*.ttf"
        fontDialog.RestoreDirectory = True

        If fontDialog.ShowDialog() = DialogResult.OK Then
            'Using a dialog, get the desired font file path
            fontPath = fontDialog.FileName.ToString
            'Show user selected font path
            selectedFontPath2.Text() = fontPath
            UpdateValMyIni("FontFilePath2=", fontPath)
        End If
    End Sub
    Private Sub randomizeFolderButton_Click(sender As Object, e As EventArgs) Handles randomizeFolderButton.Click
        Dim folderPath As String = Nothing
        Dim folderDialog As New FolderBrowserDialog()

        If folderDialog.ShowDialog() = DialogResult.OK Then
            'Using a dialog, get the desired font file path
            folderPath = folderDialog.SelectedPath.ToString
            'Show user selected font path
            fontFolderPath.Text() = folderPath
            UpdateValMyIni("FontRandomFolder=", folderPath)
        End If
    End Sub
    Private Sub fontAutoCheck_CheckChanged(sender As Object, e As EventArgs) Handles fontAutoCheck.Click
        If fontAutoCheck.Checked Then
            UpdateValMyIni("FontAutoReplace=", True)
            selectedFontPath.Visible = True
            fontSelectButton.Visible = True
        Else
            UpdateValMyIni("FontAutoReplace=", False)
            selectedFontPath.Visible = False
            fontSelectButton.Visible = False
        End If
    End Sub
    Private Sub fontAutoCheck2_CheckChanged(sender As Object, e As EventArgs) Handles fontAutoCheck2.Click
        If fontAutoCheck2.Checked Then
            UpdateValMyIni("FontAutoReplace2=", True)
            selectedFontPath2.Visible = True
            fontSelectButton2.Visible = True
        Else
            UpdateValMyIni("FontAutoReplace2=", False)
            selectedFontPath2.Visible = False
            fontSelectButton2.Visible = False
        End If
    End Sub
    Private Sub randomizeCheck_CheckedChanged(sender As Object, e As EventArgs) Handles randomizeCheck.CheckedChanged
        If randomizeCheck.Checked Then
            UpdateValMyIni("FontRandomize=", True)
            rerandomizeButton.Visible = True
            randomizeFolderButton.Visible = True
            fontFolderPath.Visible = True
        Else
            UpdateValMyIni("FontRandomize=", False)
            rerandomizeButton.Visible = False
            randomizeFolderButton.Visible = False
            fontFolderPath.Visible = False
        End If
    End Sub
    Private Sub rerandomizeButton_Click(sender As Object, e As EventArgs) Handles rerandomizeButton.Click
        Dim fontList As Array = IO.Directory.GetFiles(fontFolderPath.Text, "*.ttf", 0)
        If fontAutoCheck.Checked Then
            Dim Rand As New Random()
            Dim chosenFont As String = fontList(Rand.Next(0, fontList.Length - 1))
            UpdateValMyIni("FontFilePath=", chosenFont)
            selectedFontPath.Text = chosenFont
        End If
        If fontAutoCheck2.Checked Then
            Dim Rand As New Random()
            Dim chosenFont As String = fontList(Rand.Next(0, fontList.Length - 1))
            UpdateValMyIni("FontFilePath2=", chosenFont)
            selectedFontPath2.Text = chosenFont
        End If
    End Sub

    Public Sub BackgroundWorker1_DoWork(sender As Object, e As DoWorkEventArgs) Handles BackgroundWorker1.DoWork
        Dim watcher As EventLogWatcher
        watcher = Nothing
        Try
            Dim subQuery As New EventLogQuery("System", PathType.LogName, "*[System[Provider[@Name='Service Control Manager'] and (Level=4 or Level=0) and (band(Keywords,36028797018963968)) and (EventID=7045)]] and *[EventData[Data[@Name='ServiceName'] and (Data='BEDaisy')]]")
            watcher = New EventLogWatcher(subQuery)
            AddHandler watcher.EventRecordWritten, AddressOf BackgroundHandleEvent
            watcher.Enabled = True
            Console.WriteLine("waiting for event detect")
            While Not BackgroundWorker1.CancellationPending
                System.Threading.Thread.Sleep(500)
                If BackgroundWorker1.CancellationPending Then
                    Exit While
                End If
            End While
        Catch ex As EventLogReadingException
            Console.WriteLine("error: {0}", ex.Message)
        Finally
            watcher.Enabled = False
            If Not watcher Is Nothing Then
                watcher.Dispose()
            End If
        End Try
    End Sub
    Public Sub BackgroundHandleEvent(ByVal obj As Object, ByVal arg As EventRecordWrittenEventArgs)
        If Not arg.EventRecord Is Nothing Then
            Console.WriteLine("received event {0} from sub", arg.EventRecord.Id)
            Console.WriteLine("desc: {0}", arg.EventRecord.FormatDescription())
            If fontAutoCheck.Checked Then
                Dim fontSource As String = GetStateMyIni("FontFilePath=")
                Dim fontDest As String = CurDir() + "\UI\Resource\Fonts\Ps2GeoMdRosaVerde.ttf"
                File.Copy(fontSource, fontDest, True)
                Console.WriteLine("Copied font1")
            End If
            If fontAutoCheck2.Checked Then
                Dim fontSource2 As String = GetStateMyIni("FontFilePath2=")
                Dim fontDest2 As String = CurDir() + "\UI\Resource\Fonts\ARIALUNI.ttf"
                FileCopy(fontSource2, fontDest2)
                Console.WriteLine("Copied font2")
            End If
            If localeReplaceCheck.Checked Then
                Dim dirSource As String = GetStateMyIni("LocaleDirPath=")
                Dim datSource As String = GetStateMyIni("LocaleDatPath=")
                Dim dirDest As String = CurDir() + "\Locale\en_us_data.dir"
                Dim datDest As String = CurDir() + "\Locale\en_us_data.dat"
                File.Copy(dirSource, dirDest, True)
                File.Copy(datSource, datDest, True)
                Console.WriteLine("Copied locale")
            End If
            If commandAutoCheck.Checked Then
                Dim commandList As List(Of String) = Nothing
                commandList = File.ReadAllLines(commandPath).ToList
                commandList(0) = vbCrLf + commandList(0)
                File.AppendAllLines("ClientConfig.ini", commandList)
            End If
            End
        Else
            Console.WriteLine("event instance null")
        End If
    End Sub
    Private Sub localeReplaceCheck_CheckedChanged(sender As Object, e As EventArgs) Handles localeReplaceCheck.Click
        If localeReplaceCheck.Checked Then
            UpdateValMyIni("LocaleAutoReplace=", True)
            localeDatButton.Visible = True
            localeDirButton.Visible = True
            selectedDatPath.Visible = True
            selectedDirPath.Visible = True
        Else
            UpdateValMyIni("LocaleAutoReplace=", False)
            localeDatButton.Visible = False
            localeDirButton.Visible = False
            selectedDatPath.Visible = False
            selectedDirPath.Visible = False
        End If
    End Sub
    Private Sub localeDirButton_Click(sender As Object, e As EventArgs) Handles localeDirButton.Click
        Dim filePath As String = Nothing
        Dim newDialog As New OpenFileDialog()

        newDialog.Filter = "Dir files (*.dir)|*.dir"
        newDialog.RestoreDirectory = True

        If newDialog.ShowDialog() = DialogResult.OK Then
            filePath = newDialog.FileName.ToString
            selectedDirPath.Text() = filePath
            UpdateValMyIni("LocaleDirPath=", filePath)
        End If
    End Sub
    Private Sub localeDatButton_Click(sender As Object, e As EventArgs) Handles localeDatButton.Click
        Dim filePath As String = Nothing
        Dim newDialog As New OpenFileDialog()

        newDialog.Filter = "Dat files (*.dat)|*.dat"
        newDialog.RestoreDirectory = True

        If newDialog.ShowDialog() = DialogResult.OK Then
            filePath = newDialog.FileName.ToString
            selectedDatPath.Text() = filePath
            UpdateValMyIni("LocaleDatPath=", filePath)
        End If
    End Sub
    Private Sub commandAutoCheck_CheckedChanged(sender As Object, e As EventArgs) Handles commandAutoCheck.Click
        If commandAutoCheck.Checked Then
            UpdateValMyIni("CommandAutoReplace=", True)
            commandTextBox.Visible = True
        Else
            UpdateValMyIni("CommandAutoReplace=", False)
            commandTextBox.Visible = False
        End If
    End Sub
    Private Sub commandTextBox_TextChanged(sender As Object, e As EventArgs) Handles commandTextBox.LostFocus
        File.WriteAllLines(commandPath, commandTextBox.Lines)
    End Sub
#End Region
    Function UpdateValMyIni(ByVal optionName As String, ByVal newVal As Object)
        If Not doneLoading Then
            Exit Function
        End If
        Dim found As Boolean = False
        For index As Integer = 0 To iniini.Count - 1
            If iniini(index).StartsWith(optionName, StringComparison.OrdinalIgnoreCase) Then
                found = True
                iniini(index) = optionName & newVal
                Console.WriteLine($"Updated {optionName} to {newVal}")
            End If
        Next
        If Not found Then
            AddValMyIni(optionName, newVal)
        End If
        File.WriteAllLines(iniPath, iniini)
    End Function
    Function GetStateMyIni(ByVal optionName As String)
        For Each line In iniini
            If line.StartsWith(optionName, StringComparison.OrdinalIgnoreCase) Then
                Dim optionVal As Array = line.Split("="c)
                Console.WriteLine($"Got {optionName} with {optionVal(1)}")
                Return optionVal(1)
            End If
        Next
    End Function
    Sub AddValMyIni(ByVal optionName As String, ByVal newVal As String)
        iniini.Add(optionName & newVal)
        Console.WriteLine($"Added {optionName} with val {newVal}")
    End Sub
End Class