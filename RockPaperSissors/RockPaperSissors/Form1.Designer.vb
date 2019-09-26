<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.pbxRock = New System.Windows.Forms.PictureBox
        Me.pbxPaper = New System.Windows.Forms.PictureBox
        Me.pbxScissors = New System.Windows.Forms.PictureBox
        Me.btnExit = New System.Windows.Forms.Button
        Me.lblWinner = New System.Windows.Forms.Label
        Me.pbxPlayer = New System.Windows.Forms.PictureBox
        Me.pbxComputer = New System.Windows.Forms.PictureBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.lblScorePlayer = New System.Windows.Forms.Label
        Me.lblScoreComputer = New System.Windows.Forms.Label
        CType(Me.pbxRock, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbxPaper, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbxScissors, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbxPlayer, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbxComputer, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pbxRock
        '
        Me.pbxRock.BackColor = System.Drawing.Color.White
        Me.pbxRock.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.pbxRock.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.pbxRock.Image = CType(resources.GetObject("pbxRock.Image"), System.Drawing.Image)
        Me.pbxRock.Location = New System.Drawing.Point(12, 152)
        Me.pbxRock.Name = "pbxRock"
        Me.pbxRock.Size = New System.Drawing.Size(86, 80)
        Me.pbxRock.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.pbxRock.TabIndex = 0
        Me.pbxRock.TabStop = False
        '
        'pbxPaper
        '
        Me.pbxPaper.BackColor = System.Drawing.Color.White
        Me.pbxPaper.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.pbxPaper.Image = CType(resources.GetObject("pbxPaper.Image"), System.Drawing.Image)
        Me.pbxPaper.Location = New System.Drawing.Point(104, 152)
        Me.pbxPaper.Name = "pbxPaper"
        Me.pbxPaper.Size = New System.Drawing.Size(86, 80)
        Me.pbxPaper.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.pbxPaper.TabIndex = 1
        Me.pbxPaper.TabStop = False
        '
        'pbxScissors
        '
        Me.pbxScissors.BackColor = System.Drawing.Color.White
        Me.pbxScissors.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.pbxScissors.Image = CType(resources.GetObject("pbxScissors.Image"), System.Drawing.Image)
        Me.pbxScissors.Location = New System.Drawing.Point(196, 152)
        Me.pbxScissors.Name = "pbxScissors"
        Me.pbxScissors.Size = New System.Drawing.Size(86, 80)
        Me.pbxScissors.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.pbxScissors.TabIndex = 2
        Me.pbxScissors.TabStop = False
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(41, 265)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(224, 21)
        Me.btnExit.TabIndex = 3
        Me.btnExit.Text = "Exit, It's The Safest Option!"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'lblWinner
        '
        Me.lblWinner.AutoSize = True
        Me.lblWinner.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblWinner.Location = New System.Drawing.Point(12, 114)
        Me.lblWinner.Name = "lblWinner"
        Me.lblWinner.Size = New System.Drawing.Size(0, 13)
        Me.lblWinner.TabIndex = 4
        '
        'pbxPlayer
        '
        Me.pbxPlayer.BackColor = System.Drawing.Color.White
        Me.pbxPlayer.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.pbxPlayer.Location = New System.Drawing.Point(60, 25)
        Me.pbxPlayer.Name = "pbxPlayer"
        Me.pbxPlayer.Size = New System.Drawing.Size(86, 80)
        Me.pbxPlayer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.pbxPlayer.TabIndex = 5
        Me.pbxPlayer.TabStop = False
        '
        'pbxComputer
        '
        Me.pbxComputer.BackColor = System.Drawing.Color.White
        Me.pbxComputer.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.pbxComputer.Location = New System.Drawing.Point(152, 25)
        Me.pbxComputer.Name = "pbxComputer"
        Me.pbxComputer.Size = New System.Drawing.Size(86, 80)
        Me.pbxComputer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.pbxComputer.TabIndex = 6
        Me.pbxComputer.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(62, 133)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(192, 13)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "Please Select Rock, Paper, or Scissors"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(38, 235)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(33, 13)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "Rock"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(127, 235)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(35, 13)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "Paper"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(219, 235)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(46, 13)
        Me.Label4.TabIndex = 10
        Me.Label4.Text = "Scissors"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(57, 9)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(36, 13)
        Me.Label5.TabIndex = 11
        Me.Label5.Text = "Player"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(151, 9)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(52, 13)
        Me.Label6.TabIndex = 12
        Me.Label6.Text = "Computer"
        '
        'lblScorePlayer
        '
        Me.lblScorePlayer.AutoSize = True
        Me.lblScorePlayer.Location = New System.Drawing.Point(99, 9)
        Me.lblScorePlayer.Name = "lblScorePlayer"
        Me.lblScorePlayer.Size = New System.Drawing.Size(13, 13)
        Me.lblScorePlayer.TabIndex = 13
        Me.lblScorePlayer.Text = "0"
        '
        'lblScoreComputer
        '
        Me.lblScoreComputer.AutoSize = True
        Me.lblScoreComputer.Location = New System.Drawing.Point(209, 9)
        Me.lblScoreComputer.Name = "lblScoreComputer"
        Me.lblScoreComputer.Size = New System.Drawing.Size(13, 13)
        Me.lblScoreComputer.TabIndex = 14
        Me.lblScoreComputer.Text = "0"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(292, 302)
        Me.ControlBox = False
        Me.Controls.Add(Me.lblScoreComputer)
        Me.Controls.Add(Me.lblScorePlayer)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.pbxComputer)
        Me.Controls.Add(Me.pbxPlayer)
        Me.Controls.Add(Me.lblWinner)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.pbxScissors)
        Me.Controls.Add(Me.pbxPaper)
        Me.Controls.Add(Me.pbxRock)
        Me.Name = "Form1"
        Me.Text = "Rock, Paper, Scissors"
        CType(Me.pbxRock, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbxPaper, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbxScissors, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbxPlayer, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbxComputer, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents pbxRock As System.Windows.Forms.PictureBox
    Friend WithEvents pbxPaper As System.Windows.Forms.PictureBox
    Friend WithEvents pbxScissors As System.Windows.Forms.PictureBox
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents lblWinner As System.Windows.Forms.Label
    Friend WithEvents pbxPlayer As System.Windows.Forms.PictureBox
    Friend WithEvents pbxComputer As System.Windows.Forms.PictureBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents lblScorePlayer As System.Windows.Forms.Label
    Friend WithEvents lblScoreComputer As System.Windows.Forms.Label

End Class
