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
        Me.ToolStripStatusLabel1 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.ToolStripStatusLabel = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusLabel3 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusLabel2 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.BackgroundWorker1 = New System.ComponentModel.BackgroundWorker()
        Me.FlowLayoutPanel1 = New System.Windows.Forms.FlowLayoutPanel()
        Me.FlowLayoutPanel2 = New System.Windows.Forms.FlowLayoutPanel()
        Me.FlowLayoutPanel6 = New System.Windows.Forms.FlowLayoutPanel()
        Me.fontAutoCheck = New System.Windows.Forms.CheckBox()
        Me.fontSelectButton = New System.Windows.Forms.Button()
        Me.selectedFontPath = New System.Windows.Forms.Label()
        Me.FlowLayoutPanel5 = New System.Windows.Forms.FlowLayoutPanel()
        Me.fontAutoCheck2 = New System.Windows.Forms.CheckBox()
        Me.fontSelectButton2 = New System.Windows.Forms.Button()
        Me.selectedFontPath2 = New System.Windows.Forms.Label()
        Me.FlowLayoutPanel3 = New System.Windows.Forms.FlowLayoutPanel()
        Me.localeReplaceCheck = New System.Windows.Forms.CheckBox()
        Me.localeDirButton = New System.Windows.Forms.Button()
        Me.selectedDirPath = New System.Windows.Forms.Label()
        Me.localeDatButton = New System.Windows.Forms.Button()
        Me.selectedDatPath = New System.Windows.Forms.Label()
        Me.FlowLayoutPanel4 = New System.Windows.Forms.FlowLayoutPanel()
        Me.commandAutoCheck = New System.Windows.Forms.CheckBox()
        Me.commandTextBox = New System.Windows.Forms.TextBox()
        Me.FlowLayoutPanel7 = New System.Windows.Forms.FlowLayoutPanel()
        Me.randomizeCheck = New System.Windows.Forms.CheckBox()
        Me.randomizeFolderButton = New System.Windows.Forms.Button()
        Me.fontFolderPath = New System.Windows.Forms.Label()
        Me.rerandomizeButton = New System.Windows.Forms.Button()
        Me.StatusStrip1.SuspendLayout()
        Me.FlowLayoutPanel1.SuspendLayout()
        Me.FlowLayoutPanel2.SuspendLayout()
        Me.FlowLayoutPanel6.SuspendLayout()
        Me.FlowLayoutPanel5.SuspendLayout()
        Me.FlowLayoutPanel3.SuspendLayout()
        Me.FlowLayoutPanel4.SuspendLayout()
        Me.FlowLayoutPanel7.SuspendLayout()
        Me.SuspendLayout()
        '
        'ToolStripStatusLabel1
        '
        Me.ToolStripStatusLabel1.BackColor = System.Drawing.SystemColors.Control
        Me.ToolStripStatusLabel1.Name = "ToolStripStatusLabel1"
        Me.ToolStripStatusLabel1.Size = New System.Drawing.Size(99, 17)
        Me.ToolStripStatusLabel1.Text = "Currently Editing:"
        '
        'StatusStrip1
        '
        Me.StatusStrip1.BackColor = System.Drawing.SystemColors.Control
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripStatusLabel, Me.ToolStripStatusLabel3, Me.ToolStripStatusLabel2})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 484)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(624, 22)
        Me.StatusStrip1.TabIndex = 80
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'ToolStripStatusLabel
        '
        Me.ToolStripStatusLabel.Name = "ToolStripStatusLabel"
        Me.ToolStripStatusLabel.Size = New System.Drawing.Size(95, 17)
        Me.ToolStripStatusLabel.Text = "github/PSBlockx"
        Me.ToolStripStatusLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'ToolStripStatusLabel3
        '
        Me.ToolStripStatusLabel3.ForeColor = System.Drawing.SystemColors.AppWorkspace
        Me.ToolStripStatusLabel3.Name = "ToolStripStatusLabel3"
        Me.ToolStripStatusLabel3.Size = New System.Drawing.Size(10, 17)
        Me.ToolStripStatusLabel3.Text = ":"
        '
        'ToolStripStatusLabel2
        '
        Me.ToolStripStatusLabel2.Name = "ToolStripStatusLabel2"
        Me.ToolStripStatusLabel2.Size = New System.Drawing.Size(504, 17)
        Me.ToolStripStatusLabel2.Spring = True
        Me.ToolStripStatusLabel2.Text = "Please Use English Language In Launcher"
        '
        'BackgroundWorker1
        '
        Me.BackgroundWorker1.WorkerReportsProgress = True
        Me.BackgroundWorker1.WorkerSupportsCancellation = True
        '
        'FlowLayoutPanel1
        '
        Me.FlowLayoutPanel1.AutoSize = True
        Me.FlowLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.FlowLayoutPanel1.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.FlowLayoutPanel1.Controls.Add(Me.FlowLayoutPanel2)
        Me.FlowLayoutPanel1.Controls.Add(Me.FlowLayoutPanel3)
        Me.FlowLayoutPanel1.Controls.Add(Me.FlowLayoutPanel4)
        Me.FlowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.FlowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown
        Me.FlowLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.FlowLayoutPanel1.Name = "FlowLayoutPanel1"
        Me.FlowLayoutPanel1.Size = New System.Drawing.Size(624, 484)
        Me.FlowLayoutPanel1.TabIndex = 74
        '
        'FlowLayoutPanel2
        '
        Me.FlowLayoutPanel2.AutoSize = True
        Me.FlowLayoutPanel2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.FlowLayoutPanel2.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.FlowLayoutPanel2.Controls.Add(Me.FlowLayoutPanel6)
        Me.FlowLayoutPanel2.Controls.Add(Me.FlowLayoutPanel5)
        Me.FlowLayoutPanel2.Controls.Add(Me.FlowLayoutPanel7)
        Me.FlowLayoutPanel2.FlowDirection = System.Windows.Forms.FlowDirection.TopDown
        Me.FlowLayoutPanel2.Location = New System.Drawing.Point(3, 3)
        Me.FlowLayoutPanel2.Name = "FlowLayoutPanel2"
        Me.FlowLayoutPanel2.Size = New System.Drawing.Size(127, 254)
        Me.FlowLayoutPanel2.TabIndex = 74
        '
        'FlowLayoutPanel6
        '
        Me.FlowLayoutPanel6.AutoSize = True
        Me.FlowLayoutPanel6.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.FlowLayoutPanel6.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.FlowLayoutPanel6.Controls.Add(Me.fontAutoCheck)
        Me.FlowLayoutPanel6.Controls.Add(Me.fontSelectButton)
        Me.FlowLayoutPanel6.Controls.Add(Me.selectedFontPath)
        Me.FlowLayoutPanel6.FlowDirection = System.Windows.Forms.FlowDirection.TopDown
        Me.FlowLayoutPanel6.Location = New System.Drawing.Point(3, 3)
        Me.FlowLayoutPanel6.Name = "FlowLayoutPanel6"
        Me.FlowLayoutPanel6.Size = New System.Drawing.Size(96, 69)
        Me.FlowLayoutPanel6.TabIndex = 77
        '
        'fontAutoCheck
        '
        Me.fontAutoCheck.AutoSize = True
        Me.fontAutoCheck.ForeColor = System.Drawing.SystemColors.Control
        Me.fontAutoCheck.Location = New System.Drawing.Point(3, 3)
        Me.fontAutoCheck.Name = "fontAutoCheck"
        Me.fontAutoCheck.Size = New System.Drawing.Size(90, 17)
        Me.fontAutoCheck.TabIndex = 2
        Me.fontAutoCheck.Text = "Replace Font"
        Me.fontAutoCheck.UseVisualStyleBackColor = True
        '
        'fontSelectButton
        '
        Me.fontSelectButton.Location = New System.Drawing.Point(3, 26)
        Me.fontSelectButton.Name = "fontSelectButton"
        Me.fontSelectButton.Size = New System.Drawing.Size(75, 23)
        Me.fontSelectButton.TabIndex = 3
        Me.fontSelectButton.Text = "Select Font"
        Me.fontSelectButton.UseVisualStyleBackColor = True
        Me.fontSelectButton.Visible = False
        '
        'selectedFontPath
        '
        Me.selectedFontPath.AutoSize = True
        Me.selectedFontPath.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.selectedFontPath.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.selectedFontPath.ForeColor = System.Drawing.SystemColors.Control
        Me.selectedFontPath.Location = New System.Drawing.Point(3, 52)
        Me.selectedFontPath.Name = "selectedFontPath"
        Me.selectedFontPath.Size = New System.Drawing.Size(0, 17)
        Me.selectedFontPath.TabIndex = 63
        Me.selectedFontPath.Visible = False
        '
        'FlowLayoutPanel5
        '
        Me.FlowLayoutPanel5.AutoSize = True
        Me.FlowLayoutPanel5.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.FlowLayoutPanel5.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.FlowLayoutPanel5.Controls.Add(Me.fontAutoCheck2)
        Me.FlowLayoutPanel5.Controls.Add(Me.fontSelectButton2)
        Me.FlowLayoutPanel5.Controls.Add(Me.selectedFontPath2)
        Me.FlowLayoutPanel5.FlowDirection = System.Windows.Forms.FlowDirection.TopDown
        Me.FlowLayoutPanel5.Location = New System.Drawing.Point(3, 78)
        Me.FlowLayoutPanel5.Name = "FlowLayoutPanel5"
        Me.FlowLayoutPanel5.Size = New System.Drawing.Size(121, 69)
        Me.FlowLayoutPanel5.TabIndex = 77
        '
        'fontAutoCheck2
        '
        Me.fontAutoCheck2.AutoSize = True
        Me.fontAutoCheck2.ForeColor = System.Drawing.SystemColors.Control
        Me.fontAutoCheck2.Location = New System.Drawing.Point(3, 3)
        Me.fontAutoCheck2.Name = "fontAutoCheck2"
        Me.fontAutoCheck2.Size = New System.Drawing.Size(115, 17)
        Me.fontAutoCheck2.TabIndex = 4
        Me.fontAutoCheck2.Text = "Replace Chat Font"
        Me.fontAutoCheck2.UseVisualStyleBackColor = True
        '
        'fontSelectButton2
        '
        Me.fontSelectButton2.Location = New System.Drawing.Point(3, 26)
        Me.fontSelectButton2.Name = "fontSelectButton2"
        Me.fontSelectButton2.Size = New System.Drawing.Size(75, 23)
        Me.fontSelectButton2.TabIndex = 5
        Me.fontSelectButton2.Text = "Select Font"
        Me.fontSelectButton2.UseVisualStyleBackColor = True
        Me.fontSelectButton2.Visible = False
        '
        'selectedFontPath2
        '
        Me.selectedFontPath2.AutoSize = True
        Me.selectedFontPath2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.selectedFontPath2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.selectedFontPath2.ForeColor = System.Drawing.SystemColors.Control
        Me.selectedFontPath2.Location = New System.Drawing.Point(3, 52)
        Me.selectedFontPath2.Name = "selectedFontPath2"
        Me.selectedFontPath2.Size = New System.Drawing.Size(0, 17)
        Me.selectedFontPath2.TabIndex = 72
        Me.selectedFontPath2.Visible = False
        '
        'FlowLayoutPanel3
        '
        Me.FlowLayoutPanel3.AutoSize = True
        Me.FlowLayoutPanel3.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.FlowLayoutPanel3.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.FlowLayoutPanel3.Controls.Add(Me.localeReplaceCheck)
        Me.FlowLayoutPanel3.Controls.Add(Me.localeDirButton)
        Me.FlowLayoutPanel3.Controls.Add(Me.selectedDirPath)
        Me.FlowLayoutPanel3.Controls.Add(Me.localeDatButton)
        Me.FlowLayoutPanel3.Controls.Add(Me.selectedDatPath)
        Me.FlowLayoutPanel3.FlowDirection = System.Windows.Forms.FlowDirection.TopDown
        Me.FlowLayoutPanel3.Location = New System.Drawing.Point(3, 263)
        Me.FlowLayoutPanel3.Name = "FlowLayoutPanel3"
        Me.FlowLayoutPanel3.Size = New System.Drawing.Size(172, 115)
        Me.FlowLayoutPanel3.TabIndex = 75
        Me.FlowLayoutPanel3.Visible = False
        '
        'localeReplaceCheck
        '
        Me.localeReplaceCheck.AutoSize = True
        Me.localeReplaceCheck.ForeColor = System.Drawing.SystemColors.Control
        Me.localeReplaceCheck.Location = New System.Drawing.Point(3, 3)
        Me.localeReplaceCheck.Name = "localeReplaceCheck"
        Me.localeReplaceCheck.Size = New System.Drawing.Size(166, 17)
        Me.localeReplaceCheck.TabIndex = 6
        Me.localeReplaceCheck.Text = "Automatically Replace Locale"
        Me.localeReplaceCheck.UseVisualStyleBackColor = True
        '
        'localeDirButton
        '
        Me.localeDirButton.Location = New System.Drawing.Point(3, 26)
        Me.localeDirButton.Name = "localeDirButton"
        Me.localeDirButton.Size = New System.Drawing.Size(75, 23)
        Me.localeDirButton.TabIndex = 7
        Me.localeDirButton.Text = "Select Dir"
        Me.localeDirButton.UseVisualStyleBackColor = True
        Me.localeDirButton.Visible = False
        '
        'selectedDirPath
        '
        Me.selectedDirPath.AutoSize = True
        Me.selectedDirPath.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.selectedDirPath.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.selectedDirPath.ForeColor = System.Drawing.SystemColors.Control
        Me.selectedDirPath.Location = New System.Drawing.Point(3, 52)
        Me.selectedDirPath.Name = "selectedDirPath"
        Me.selectedDirPath.Size = New System.Drawing.Size(0, 17)
        Me.selectedDirPath.TabIndex = 68
        Me.selectedDirPath.Visible = False
        '
        'localeDatButton
        '
        Me.localeDatButton.Location = New System.Drawing.Point(3, 72)
        Me.localeDatButton.Name = "localeDatButton"
        Me.localeDatButton.Size = New System.Drawing.Size(75, 23)
        Me.localeDatButton.TabIndex = 8
        Me.localeDatButton.Text = "Select Dat"
        Me.localeDatButton.UseVisualStyleBackColor = True
        Me.localeDatButton.Visible = False
        '
        'selectedDatPath
        '
        Me.selectedDatPath.AutoSize = True
        Me.selectedDatPath.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.selectedDatPath.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.selectedDatPath.ForeColor = System.Drawing.SystemColors.Control
        Me.selectedDatPath.Location = New System.Drawing.Point(3, 98)
        Me.selectedDatPath.Name = "selectedDatPath"
        Me.selectedDatPath.Size = New System.Drawing.Size(0, 17)
        Me.selectedDatPath.TabIndex = 70
        Me.selectedDatPath.Visible = False
        '
        'FlowLayoutPanel4
        '
        Me.FlowLayoutPanel4.AutoSize = True
        Me.FlowLayoutPanel4.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.FlowLayoutPanel4.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.FlowLayoutPanel4.Controls.Add(Me.commandAutoCheck)
        Me.FlowLayoutPanel4.Controls.Add(Me.commandTextBox)
        Me.FlowLayoutPanel4.FlowDirection = System.Windows.Forms.FlowDirection.TopDown
        Me.FlowLayoutPanel4.Location = New System.Drawing.Point(181, 3)
        Me.FlowLayoutPanel4.Name = "FlowLayoutPanel4"
        Me.FlowLayoutPanel4.Size = New System.Drawing.Size(250, 147)
        Me.FlowLayoutPanel4.TabIndex = 76
        Me.FlowLayoutPanel4.Visible = False
        '
        'commandAutoCheck
        '
        Me.commandAutoCheck.AutoSize = True
        Me.commandAutoCheck.ForeColor = System.Drawing.SystemColors.Control
        Me.commandAutoCheck.Location = New System.Drawing.Point(3, 3)
        Me.commandAutoCheck.Name = "commandAutoCheck"
        Me.commandAutoCheck.Size = New System.Drawing.Size(216, 17)
        Me.commandAutoCheck.TabIndex = 9
        Me.commandAutoCheck.Text = "Automatically Replace Command Queue"
        Me.commandAutoCheck.UseVisualStyleBackColor = True
        '
        'commandTextBox
        '
        Me.commandTextBox.AcceptsReturn = True
        Me.commandTextBox.Location = New System.Drawing.Point(3, 26)
        Me.commandTextBox.MaxLength = 250
        Me.commandTextBox.Multiline = True
        Me.commandTextBox.Name = "commandTextBox"
        Me.commandTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.commandTextBox.Size = New System.Drawing.Size(244, 118)
        Me.commandTextBox.TabIndex = 10
        Me.commandTextBox.Visible = False
        '
        'FlowLayoutPanel7
        '
        Me.FlowLayoutPanel7.AutoSize = True
        Me.FlowLayoutPanel7.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.FlowLayoutPanel7.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.FlowLayoutPanel7.Controls.Add(Me.randomizeCheck)
        Me.FlowLayoutPanel7.Controls.Add(Me.randomizeFolderButton)
        Me.FlowLayoutPanel7.Controls.Add(Me.fontFolderPath)
        Me.FlowLayoutPanel7.Controls.Add(Me.rerandomizeButton)
        Me.FlowLayoutPanel7.FlowDirection = System.Windows.Forms.FlowDirection.TopDown
        Me.FlowLayoutPanel7.Location = New System.Drawing.Point(3, 153)
        Me.FlowLayoutPanel7.Name = "FlowLayoutPanel7"
        Me.FlowLayoutPanel7.Size = New System.Drawing.Size(90, 98)
        Me.FlowLayoutPanel7.TabIndex = 78
        '
        'randomizeCheck
        '
        Me.randomizeCheck.AutoSize = True
        Me.randomizeCheck.ForeColor = System.Drawing.SystemColors.Control
        Me.randomizeCheck.Location = New System.Drawing.Point(3, 3)
        Me.randomizeCheck.Name = "randomizeCheck"
        Me.randomizeCheck.Size = New System.Drawing.Size(79, 17)
        Me.randomizeCheck.TabIndex = 4
        Me.randomizeCheck.Text = "Randomize"
        Me.randomizeCheck.UseVisualStyleBackColor = True
        '
        'randomizeFolderButton
        '
        Me.randomizeFolderButton.Location = New System.Drawing.Point(3, 26)
        Me.randomizeFolderButton.Name = "randomizeFolderButton"
        Me.randomizeFolderButton.Size = New System.Drawing.Size(75, 23)
        Me.randomizeFolderButton.TabIndex = 5
        Me.randomizeFolderButton.Text = "Fonts Folder"
        Me.randomizeFolderButton.UseVisualStyleBackColor = True
        Me.randomizeFolderButton.Visible = False
        '
        'fontFolderPath
        '
        Me.fontFolderPath.AutoSize = True
        Me.fontFolderPath.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.fontFolderPath.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.fontFolderPath.ForeColor = System.Drawing.SystemColors.Control
        Me.fontFolderPath.Location = New System.Drawing.Point(3, 52)
        Me.fontFolderPath.Name = "fontFolderPath"
        Me.fontFolderPath.Size = New System.Drawing.Size(0, 17)
        Me.fontFolderPath.TabIndex = 72
        Me.fontFolderPath.Visible = False
        '
        'rerandomizeButton
        '
        Me.rerandomizeButton.AutoSize = True
        Me.rerandomizeButton.Location = New System.Drawing.Point(3, 72)
        Me.rerandomizeButton.Name = "rerandomizeButton"
        Me.rerandomizeButton.Size = New System.Drawing.Size(84, 23)
        Me.rerandomizeButton.TabIndex = 73
        Me.rerandomizeButton.Text = "ReRandomize"
        Me.rerandomizeButton.UseVisualStyleBackColor = True
        Me.rerandomizeButton.Visible = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.AutoSize = True
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange
        Me.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.ClientSize = New System.Drawing.Size(624, 506)
        Me.Controls.Add(Me.FlowLayoutPanel1)
        Me.Controls.Add(Me.StatusStrip1)
        Me.MinimumSize = New System.Drawing.Size(360, 39)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Tag = ""
        Me.Text = "PS2 Font Replacer"
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.FlowLayoutPanel1.ResumeLayout(False)
        Me.FlowLayoutPanel1.PerformLayout()
        Me.FlowLayoutPanel2.ResumeLayout(False)
        Me.FlowLayoutPanel2.PerformLayout()
        Me.FlowLayoutPanel6.ResumeLayout(False)
        Me.FlowLayoutPanel6.PerformLayout()
        Me.FlowLayoutPanel5.ResumeLayout(False)
        Me.FlowLayoutPanel5.PerformLayout()
        Me.FlowLayoutPanel3.ResumeLayout(False)
        Me.FlowLayoutPanel3.PerformLayout()
        Me.FlowLayoutPanel4.ResumeLayout(False)
        Me.FlowLayoutPanel4.PerformLayout()
        Me.FlowLayoutPanel7.ResumeLayout(False)
        Me.FlowLayoutPanel7.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ToolStripStatusLabel1 As ToolStripStatusLabel
    Friend WithEvents StatusStrip1 As StatusStrip
    Friend WithEvents ToolStripStatusLabel As ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabel2 As ToolStripStatusLabel
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
    Friend WithEvents commandTextBox As TextBox
    Friend WithEvents commandAutoCheck As CheckBox
    Friend WithEvents selectedDatPath As Label
    Friend WithEvents localeDatButton As Button
    Friend WithEvents localeReplaceCheck As CheckBox
    Friend WithEvents selectedDirPath As Label
    Friend WithEvents localeDirButton As Button
    Friend WithEvents fontAutoCheck2 As CheckBox
    Friend WithEvents fontAutoCheck As CheckBox
    Friend WithEvents selectedFontPath As Label
    Friend WithEvents fontSelectButton As Button
    Friend WithEvents fontSelectButton2 As Button
    Friend WithEvents selectedFontPath2 As Label
    Friend WithEvents FlowLayoutPanel1 As FlowLayoutPanel
    Friend WithEvents FlowLayoutPanel2 As FlowLayoutPanel
    Friend WithEvents FlowLayoutPanel3 As FlowLayoutPanel
    Friend WithEvents FlowLayoutPanel4 As FlowLayoutPanel
    Friend WithEvents ToolStripStatusLabel3 As ToolStripStatusLabel
    Friend WithEvents FlowLayoutPanel5 As FlowLayoutPanel
    Friend WithEvents FlowLayoutPanel6 As FlowLayoutPanel
    Friend WithEvents FlowLayoutPanel7 As FlowLayoutPanel
    Friend WithEvents randomizeCheck As CheckBox
    Friend WithEvents randomizeFolderButton As Button
    Friend WithEvents fontFolderPath As Label
    Friend WithEvents rerandomizeButton As Button
End Class
