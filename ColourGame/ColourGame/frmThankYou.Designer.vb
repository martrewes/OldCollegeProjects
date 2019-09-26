<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmThankYou
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
        Me.Label1 = New System.Windows.Forms.Label
        Me.lblQuestionsCompleted = New System.Windows.Forms.Label
        Me.lblTotalScore = New System.Windows.Forms.Label
        Me.lblYesOrNo = New System.Windows.Forms.Label
        Me.btnExit = New System.Windows.Forms.Button
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 138)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(139, 16)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Thank you for playing!"
        '
        'lblQuestionsCompleted
        '
        Me.lblQuestionsCompleted.AutoSize = True
        Me.lblQuestionsCompleted.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblQuestionsCompleted.Location = New System.Drawing.Point(12, 53)
        Me.lblQuestionsCompleted.Name = "lblQuestionsCompleted"
        Me.lblQuestionsCompleted.Size = New System.Drawing.Size(260, 20)
        Me.lblQuestionsCompleted.TabIndex = 1
        Me.lblQuestionsCompleted.Text = "You completed 6 out of 6 questions"
        '
        'lblTotalScore
        '
        Me.lblTotalScore.AutoSize = True
        Me.lblTotalScore.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotalScore.Location = New System.Drawing.Point(13, 82)
        Me.lblTotalScore.Name = "lblTotalScore"
        Me.lblTotalScore.Size = New System.Drawing.Size(199, 20)
        Me.lblTotalScore.TabIndex = 2
        Me.lblTotalScore.Text = "With a total score of 10000"
        '
        'lblYesOrNo
        '
        Me.lblYesOrNo.AutoEllipsis = True
        Me.lblYesOrNo.AutoSize = True
        Me.lblYesOrNo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblYesOrNo.Location = New System.Drawing.Point(13, 9)
        Me.lblYesOrNo.MaximumSize = New System.Drawing.Size(300, 32)
        Me.lblYesOrNo.MinimumSize = New System.Drawing.Size(300, 32)
        Me.lblYesOrNo.Name = "lblYesOrNo"
        Me.lblYesOrNo.Size = New System.Drawing.Size(300, 32)
        Me.lblYesOrNo.TabIndex = 3
        Me.lblYesOrNo.Text = "Congratulations! You were able to complete all of the questions."
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(245, 135)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 23)
        Me.btnExit.TabIndex = 4
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'frmThankYou
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(332, 163)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.lblYesOrNo)
        Me.Controls.Add(Me.lblTotalScore)
        Me.Controls.Add(Me.lblQuestionsCompleted)
        Me.Controls.Add(Me.Label1)
        Me.Name = "frmThankYou"
        Me.Text = "Thank You"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lblQuestionsCompleted As System.Windows.Forms.Label
    Friend WithEvents lblTotalScore As System.Windows.Forms.Label
    Friend WithEvents lblYesOrNo As System.Windows.Forms.Label
    Friend WithEvents btnExit As System.Windows.Forms.Button
End Class
