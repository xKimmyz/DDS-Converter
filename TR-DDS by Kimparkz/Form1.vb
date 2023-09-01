Imports System.IO
Imports FreeImageAPI

'Hi, this program is a Kimparkz's project
'Welcome to my code -w-
Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'config
        RadioButtonPNG.Checked = True
        Me.AllowDrop = True
        RadioButtonPNG.Checked = True
        TextBoxStatus.Multiline = True
        OpenFileDialog1.Multiselect = True
        'other
        AddHandler Me.DragEnter, AddressOf Form1_DragEnter
        AddHandler Me.DragDrop, AddressOf Form1_DragDrop
        TextBoxStatus.ScrollBars = ScrollBars.Vertical
    End Sub

    Private Sub Form1_DragEnter(sender As Object, e As DragEventArgs)
        If e.Data.GetDataPresent(DataFormats.FileDrop) Then
            e.Effect = DragDropEffects.Copy
        Else
            e.Effect = DragDropEffects.None
        End If
    End Sub

    Private Sub Form1_DragDrop(sender As Object, e As DragEventArgs)
        Dim files As String() = DirectCast(e.Data.GetData(DataFormats.FileDrop), String())

        If files.Length > 0 Then
            Dim ddsFiles = files.Where(Function(file) Path.GetExtension(file).ToLower() = ".dds").ToList()

            If ddsFiles.Count > 0 Then
                Dim fileNames = ddsFiles.Select(Function(file) Path.GetFileName(file))
                TextBoxInputPath.Text = String.Join(", ", fileNames)
                For Each filePath As String In ddsFiles
                    ConvertDDSFile(filePath)
                Next
            Else
                TextBoxStatus.Text = "No .dds files found."
            End If
        End If
    End Sub

    Private Sub ButtonBrowse_Click(sender As Object, e As EventArgs) Handles ButtonBrowse.Click
        If OpenFileDialog1.ShowDialog() = DialogResult.OK Then
            Dim selectedFiles As String() = OpenFileDialog1.FileNames
            TextBoxInputPath.Text = String.Join(Environment.NewLine, selectedFiles)
        End If
    End Sub

    Private Sub ButtonConvert_Click(sender As Object, e As EventArgs) Handles ButtonConvert.Click
        Dim selectedFiles As String() = TextBoxInputPath.Lines
        For Each filePath As String In selectedFiles
            If Not String.IsNullOrWhiteSpace(filePath) Then
                ConvertDDSFile(filePath)
            End If
        Next
    End Sub

    Private Sub ConvertDDSFile(inputPath As String)
        If File.Exists(inputPath) Then
            Dim fileName As String = Path.GetFileName(inputPath)
            Dim image As FIBITMAP = FreeImage.Load(FREE_IMAGE_FORMAT.FIF_DDS, inputPath, FREE_IMAGE_LOAD_FLAGS.DEFAULT)

            If Not IsNothing(image) Then
                Dim outputFormat As FREE_IMAGE_FORMAT = If(RadioButtonPNG.Checked, FREE_IMAGE_FORMAT.FIF_PNG, FREE_IMAGE_FORMAT.FIF_JPEG)
                Dim outputExtension As String = If(outputFormat = FREE_IMAGE_FORMAT.FIF_PNG, "png", "jpg")
                Dim outputFolder As String = Path.GetDirectoryName(inputPath)
                Dim outputSubFolder As String = Path.Combine(outputFolder, "dds_output")
                Directory.CreateDirectory(outputSubFolder)

                Dim outputFileName As String = Path.GetFileNameWithoutExtension(inputPath)
                Dim outputPath As String = Path.Combine(outputSubFolder, $"{outputFileName}.{outputExtension}")

                Try
                    FreeImage.Save(outputFormat, image, outputPath, FREE_IMAGE_SAVE_FLAGS.DEFAULT)
                    FreeImage.Unload(image)
                    TextBoxOutputPath.Text = Path.GetDirectoryName(outputPath)
                    TextBoxStatus.AppendText($"Process : {fileName} → Convert Success" & Environment.NewLine)
                Catch ex As Exception
                    TextBoxStatus.AppendText($"An error occurred during conversion for {fileName}: {ex.Message}" & Environment.NewLine)
                End Try
            Else
                TextBoxStatus.AppendText($"Input file {inputPath} does not exist." & Environment.NewLine)
            End If
        Else
            TextBoxStatus.AppendText($"Input file does not exist." & Environment.NewLine)
        End If
    End Sub
End Class