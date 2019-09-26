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
        Me.TextBox1 = New System.Windows.Forms.TextBox
        Me.btnA = New System.Windows.Forms.Button
        Me.btnB = New System.Windows.Forms.Button
        Me.btnC = New System.Windows.Forms.Button
        Me.btnShift = New System.Windows.Forms.Button
        Me.SuspendLayout()
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(13, 13)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(100, 20)
        Me.TextBox1.TabIndex = 0
        '
        'btnA
        '
        Me.btnA.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnA.Location = New System.Drawing.Point(12, 63)
        Me.btnA.Name = "btnA"
        Me.btnA.Size = New System.Drawing.Size(75, 23)
        Me.btnA.TabIndex = 1
        Me.btnA.Text = "A"
        Me.btnA.UseVisualStyleBackColor = True
        '
        'btnB
        '
        Me.btnB.Location = New System.Drawing.Point(93, 63)
        Me.btnB.Name = "btnB"
        Me.btnB.Size = New System.Drawing.Size(75, 23)
        Me.btnB.TabIndex = 2
        Me.btnB.Text = "B"
        Me.btnB.UseVisualStyleBackColor = True
        '
        'btnC
        '
        Me.btnC.Location = New System.Drawing.Point(174, 63)
        Me.btnC.Name = "btnC"
        Me.btnC.Size = New System.Drawing.Size(75, 23)
        Me.btnC.TabIndex = 3
        Me.btnC.Text = "C"
        Me.btnC.UseVisualStyleBackColor = True
        '
        'btnShift
        '
        Me.btnShift.Location = New System.Drawing.Point(13, 93)
        Me.btnShift.Name = "btnShift"
        Me.btnShift.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.btnShift.Size = New System.Drawing.Size(75, 23)
        Me.btnShift.TabIndex = 4
        Me.btnShift.Text = "Shift"
        Me.btnShift.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(292, 266)
        Me.Controls.Add(Me.btnShift)
        Me.Controls.Add(Me.btnC)
        Me.Controls.Add(Me.btnB)
        Me.Controls.Add(Me.btnA)
        Me.Controls.Add(Me.TextBox1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents btnA As System.Windows.Forms.Button
    Friend WithEvents btnB As System.Windows.Forms.Button
    Friend WithEvents btnC As System.Windows.Forms.Button
    Friend WithEvents btnShift As System.Windows.Forms.Button

End Class
