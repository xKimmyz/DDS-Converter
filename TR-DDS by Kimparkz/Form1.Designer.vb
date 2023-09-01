<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As ComponentModel.ComponentResourceManager = New ComponentModel.ComponentResourceManager(GetType(Form1))
        TextBoxStatus = New TextBox()
        TextBoxInputPath = New TextBox()
        GroupBox1 = New GroupBox()
        TextBox3 = New TextBox()
        Label1 = New Label()
        RadioButtonJPEG = New RadioButton()
        RadioButtonPNG = New RadioButton()
        ButtonBrowse = New Button()
        ButtonConvert = New Button()
        Label2 = New Label()
        TextBoxOutputPath = New TextBox()
        Label3 = New Label()
        OpenFileDialog1 = New OpenFileDialog()
        GroupBox1.SuspendLayout()
        SuspendLayout()
        ' 
        ' TextBoxStatus
        ' 
        TextBoxStatus.Location = New Point(16, 22)
        TextBoxStatus.Multiline = True
        TextBoxStatus.Name = "TextBoxStatus"
        TextBoxStatus.ReadOnly = True
        TextBoxStatus.Size = New Size(406, 175)
        TextBoxStatus.TabIndex = 0
        ' 
        ' TextBoxInputPath
        ' 
        TextBoxInputPath.Location = New Point(79, 251)
        TextBoxInputPath.Name = "TextBoxInputPath"
        TextBoxInputPath.ReadOnly = True
        TextBoxInputPath.Size = New Size(277, 23)
        TextBoxInputPath.TabIndex = 1
        ' 
        ' GroupBox1
        ' 
        GroupBox1.Controls.Add(TextBox3)
        GroupBox1.Controls.Add(Label1)
        GroupBox1.Controls.Add(RadioButtonJPEG)
        GroupBox1.Controls.Add(RadioButtonPNG)
        GroupBox1.Controls.Add(TextBoxStatus)
        GroupBox1.Location = New Point(12, 12)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(438, 233)
        GroupBox1.TabIndex = 3
        GroupBox1.TabStop = False
        GroupBox1.Text = "Process Box :"
        ' 
        ' TextBox3
        ' 
        TextBox3.Cursor = Cursors.Help
        TextBox3.ForeColor = Color.Lime
        TextBox3.Location = New Point(323, 203)
        TextBox3.Name = "TextBox3"
        TextBox3.ReadOnly = True
        TextBox3.Size = New Size(109, 23)
        TextBox3.TabIndex = 7
        TextBox3.Text = "Discord : kimparkz"
        TextBox3.TextAlign = HorizontalAlignment.Center
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(16, 206)
        Label1.Name = "Label1"
        Label1.Size = New Size(95, 15)
        Label1.TabIndex = 4
        Label1.Text = "Convert Option :"
        ' 
        ' RadioButtonJPEG
        ' 
        RadioButtonJPEG.AutoSize = True
        RadioButtonJPEG.Cursor = Cursors.Help
        RadioButtonJPEG.Enabled = False
        RadioButtonJPEG.Location = New Point(167, 204)
        RadioButtonJPEG.Name = "RadioButtonJPEG"
        RadioButtonJPEG.Size = New Size(45, 19)
        RadioButtonJPEG.TabIndex = 2
        RadioButtonJPEG.TabStop = True
        RadioButtonJPEG.Text = ".jpg"
        RadioButtonJPEG.UseVisualStyleBackColor = True
        ' 
        ' RadioButtonPNG
        ' 
        RadioButtonPNG.AutoSize = True
        RadioButtonPNG.Cursor = Cursors.Hand
        RadioButtonPNG.Location = New Point(117, 204)
        RadioButtonPNG.Name = "RadioButtonPNG"
        RadioButtonPNG.Size = New Size(49, 19)
        RadioButtonPNG.TabIndex = 1
        RadioButtonPNG.TabStop = True
        RadioButtonPNG.Text = ".png"
        RadioButtonPNG.UseVisualStyleBackColor = True
        ' 
        ' ButtonBrowse
        ' 
        ButtonBrowse.Cursor = Cursors.Hand
        ButtonBrowse.Location = New Point(362, 251)
        ButtonBrowse.Name = "ButtonBrowse"
        ButtonBrowse.Size = New Size(88, 23)
        ButtonBrowse.TabIndex = 4
        ButtonBrowse.Text = "Browse File.."
        ButtonBrowse.UseVisualStyleBackColor = True
        ' 
        ' ButtonConvert
        ' 
        ButtonConvert.Cursor = Cursors.Hand
        ButtonConvert.Location = New Point(12, 308)
        ButtonConvert.Name = "ButtonConvert"
        ButtonConvert.Size = New Size(438, 23)
        ButtonConvert.TabIndex = 5
        ButtonConvert.Text = "Convert"
        ButtonConvert.UseVisualStyleBackColor = True
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(8, 255)
        Label2.Name = "Label2"
        Label2.Size = New Size(64, 15)
        Label2.TabIndex = 6
        Label2.Text = "image list :"
        ' 
        ' TextBoxOutputPath
        ' 
        TextBoxOutputPath.Location = New Point(78, 279)
        TextBoxOutputPath.Name = "TextBoxOutputPath"
        TextBoxOutputPath.ReadOnly = True
        TextBoxOutputPath.Size = New Size(372, 23)
        TextBoxOutputPath.TabIndex = 9
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(23, 282)
        Label3.Name = "Label3"
        Label3.Size = New Size(49, 15)
        Label3.TabIndex = 10
        Label3.Text = "output :"
        ' 
        ' OpenFileDialog1
        ' 
        OpenFileDialog1.FileName = "OpenFileDialog1"
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(458, 337)
        Controls.Add(Label3)
        Controls.Add(TextBoxOutputPath)
        Controls.Add(Label2)
        Controls.Add(ButtonConvert)
        Controls.Add(ButtonBrowse)
        Controls.Add(GroupBox1)
        Controls.Add(TextBoxInputPath)
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        MaximumSize = New Size(474, 376)
        MinimumSize = New Size(474, 376)
        Name = "Form1"
        Text = "DDS Converter By Kimparkz"
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents TextBoxStatus As TextBox
    Friend WithEvents TextBoxInputPath As TextBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label1 As Label
    Friend WithEvents RadioButtonJPEG As RadioButton
    Friend WithEvents RadioButtonPNG As RadioButton
    Friend WithEvents ButtonBrowse As Button
    Friend WithEvents ButtonConvert As Button
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents TextBoxOutputPath As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
End Class
