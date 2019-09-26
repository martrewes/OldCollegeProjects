<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmQuestions
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
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmQuestions))
        Me.lblQuestion = New System.Windows.Forms.Label
        Me.pbxQuestionImage = New System.Windows.Forms.PictureBox
        Me.lblQuestionNo = New System.Windows.Forms.Label
        Me.btnAnswer1 = New System.Windows.Forms.Button
        Me.btnAnswer2 = New System.Windows.Forms.Button
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.lblTotalScore = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.btnAnswer3 = New System.Windows.Forms.Button
        Me.btnAnswer4 = New System.Windows.Forms.Button
        Me.btnExit = New System.Windows.Forms.Button
        Me.pgrQuestion = New System.Windows.Forms.Button
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.pgrTimeRemaining = New System.Windows.Forms.Button
        CType(Me.pbxQuestionImage, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblQuestion
        '
        Me.lblQuestion.AutoSize = True
        Me.lblQuestion.BackColor = System.Drawing.Color.Transparent
        Me.lblQuestion.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblQuestion.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblQuestion.Location = New System.Drawing.Point(70, 191)
        Me.lblQuestion.MaximumSize = New System.Drawing.Size(350, 39)
        Me.lblQuestion.MinimumSize = New System.Drawing.Size(350, 39)
        Me.lblQuestion.Name = "lblQuestion"
        Me.lblQuestion.Size = New System.Drawing.Size(350, 39)
        Me.lblQuestion.TabIndex = 0
        '
        'pbxQuestionImage
        '
        Me.pbxQuestionImage.BackColor = System.Drawing.Color.Transparent
        Me.pbxQuestionImage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.pbxQuestionImage.Location = New System.Drawing.Point(121, 12)
        Me.pbxQuestionImage.Name = "pbxQuestionImage"
        Me.pbxQuestionImage.Size = New System.Drawing.Size(176, 166)
        Me.pbxQuestionImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pbxQuestionImage.TabIndex = 1
        Me.pbxQuestionImage.TabStop = False
        '
        'lblQuestionNo
        '
        Me.lblQuestionNo.AutoSize = True
        Me.lblQuestionNo.BackColor = System.Drawing.Color.Transparent
        Me.lblQuestionNo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblQuestionNo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lblQuestionNo.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblQuestionNo.Location = New System.Drawing.Point(16, 191)
        Me.lblQuestionNo.Name = "lblQuestionNo"
        Me.lblQuestionNo.Size = New System.Drawing.Size(2, 35)
        Me.lblQuestionNo.TabIndex = 2
        '
        'btnAnswer1
        '
        Me.btnAnswer1.BackgroundImage = CType(resources.GetObject("btnAnswer1.BackgroundImage"), System.Drawing.Image)
        Me.btnAnswer1.Location = New System.Drawing.Point(112, 238)
        Me.btnAnswer1.Name = "btnAnswer1"
        Me.btnAnswer1.Size = New System.Drawing.Size(75, 23)
        Me.btnAnswer1.TabIndex = 3
        Me.btnAnswer1.Text = "1"
        Me.btnAnswer1.UseVisualStyleBackColor = True
        '
        'btnAnswer2
        '
        Me.btnAnswer2.BackColor = System.Drawing.Color.Transparent
        Me.btnAnswer2.BackgroundImage = CType(resources.GetObject("btnAnswer2.BackgroundImage"), System.Drawing.Image)
        Me.btnAnswer2.Location = New System.Drawing.Point(231, 238)
        Me.btnAnswer2.Name = "btnAnswer2"
        Me.btnAnswer2.Size = New System.Drawing.Size(75, 23)
        Me.btnAnswer2.TabIndex = 5
        Me.btnAnswer2.Text = "2"
        Me.btnAnswer2.UseVisualStyleBackColor = False
        '
        'Timer1
        '
        '
        'lblTotalScore
        '
        Me.lblTotalScore.AutoSize = True
        Me.lblTotalScore.BackColor = System.Drawing.Color.Transparent
        Me.lblTotalScore.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotalScore.Location = New System.Drawing.Point(303, 152)
        Me.lblTotalScore.Name = "lblTotalScore"
        Me.lblTotalScore.Size = New System.Drawing.Size(19, 20)
        Me.lblTotalScore.TabIndex = 6
        Me.lblTotalScore.Text = "0"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Location = New System.Drawing.Point(28, 132)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(86, 13)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Time Remaining:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Location = New System.Drawing.Point(304, 132)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(62, 13)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Total Score"
        '
        'btnAnswer3
        '
        Me.btnAnswer3.BackgroundImage = CType(resources.GetObject("btnAnswer3.BackgroundImage"), System.Drawing.Image)
        Me.btnAnswer3.Location = New System.Drawing.Point(112, 267)
        Me.btnAnswer3.Name = "btnAnswer3"
        Me.btnAnswer3.Size = New System.Drawing.Size(75, 23)
        Me.btnAnswer3.TabIndex = 9
        Me.btnAnswer3.Text = "3"
        Me.btnAnswer3.UseVisualStyleBackColor = True
        '
        'btnAnswer4
        '
        Me.btnAnswer4.BackColor = System.Drawing.Color.Transparent
        Me.btnAnswer4.BackgroundImage = CType(resources.GetObject("btnAnswer4.BackgroundImage"), System.Drawing.Image)
        Me.btnAnswer4.Location = New System.Drawing.Point(231, 267)
        Me.btnAnswer4.Name = "btnAnswer4"
        Me.btnAnswer4.Size = New System.Drawing.Size(75, 23)
        Me.btnAnswer4.TabIndex = 10
        Me.btnAnswer4.Text = "4"
        Me.btnAnswer4.UseVisualStyleBackColor = False
        '
        'btnExit
        '
        Me.btnExit.BackgroundImage = CType(resources.GetObject("btnExit.BackgroundImage"), System.Drawing.Image)
        Me.btnExit.Location = New System.Drawing.Point(390, 12)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(30, 30)
        Me.btnExit.TabIndex = 11
        Me.btnExit.Text = "X"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'pgrQuestion
        '
        Me.pgrQuestion.BackgroundImage = CType(resources.GetObject("pgrQuestion.BackgroundImage"), System.Drawing.Image)
        Me.pgrQuestion.Location = New System.Drawing.Point(31, 297)
        Me.pgrQuestion.Name = "pgrQuestion"
        Me.pgrQuestion.Size = New System.Drawing.Size(360, 30)
        Me.pgrQuestion.TabIndex = 13
        Me.pgrQuestion.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PictureBox1.Location = New System.Drawing.Point(32, 296)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(360, 32)
        Me.PictureBox1.TabIndex = 14
        Me.PictureBox1.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Location = New System.Drawing.Point(29, 280)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(75, 13)
        Me.Label1.TabIndex = 15
        Me.Label1.Text = "Total Progress"
        '
        'pgrTimeRemaining
        '
        Me.pgrTimeRemaining.BackColor = System.Drawing.Color.Transparent
        Me.pgrTimeRemaining.BackgroundImage = CType(resources.GetObject("pgrTimeRemaining.BackgroundImage"), System.Drawing.Image)
        Me.pgrTimeRemaining.Location = New System.Drawing.Point(14, 148)
        Me.pgrTimeRemaining.Name = "pgrTimeRemaining"
        Me.pgrTimeRemaining.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.pgrTimeRemaining.Size = New System.Drawing.Size(100, 30)
        Me.pgrTimeRemaining.TabIndex = 16
        Me.pgrTimeRemaining.UseVisualStyleBackColor = False
        '
        'frmQuestions
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(432, 340)
        Me.Controls.Add(Me.pgrTimeRemaining)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.pgrQuestion)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnAnswer4)
        Me.Controls.Add(Me.btnAnswer3)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.lblTotalScore)
        Me.Controls.Add(Me.btnAnswer2)
        Me.Controls.Add(Me.btnAnswer1)
        Me.Controls.Add(Me.lblQuestionNo)
        Me.Controls.Add(Me.pbxQuestionImage)
        Me.Controls.Add(Me.lblQuestion)
        Me.Controls.Add(Me.PictureBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmQuestions"
        Me.Text = "Colour Game"
        CType(Me.pbxQuestionImage, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblQuestion As System.Windows.Forms.Label
    Friend WithEvents pbxQuestionImage As System.Windows.Forms.PictureBox
    Friend WithEvents lblQuestionNo As System.Windows.Forms.Label
    Friend WithEvents btnAnswer1 As System.Windows.Forms.Button
    Friend WithEvents btnAnswer2 As System.Windows.Forms.Button
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents lblTotalScore As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents btnAnswer3 As System.Windows.Forms.Button
    Friend WithEvents btnAnswer4 As System.Windows.Forms.Button
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents pgrQuestion As System.Windows.Forms.Button
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents pgrTimeRemaining As System.Windows.Forms.Button

End Class
