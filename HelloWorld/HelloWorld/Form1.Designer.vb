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
        Me.btnDo = New System.Windows.Forms.Button
        Me.lblHello = New System.Windows.Forms.Label
        Me.btn2 = New System.Windows.Forms.Button
        Me.SuspendLayout()
        '
        'btnDo
        '
        Me.btnDo.Location = New System.Drawing.Point(12, 12)
        Me.btnDo.Name = "btnDo"
        Me.btnDo.Size = New System.Drawing.Size(122, 36)
        Me.btnDo.TabIndex = 0
        Me.btnDo.Text = "Say Hello World"
        Me.btnDo.UseVisualStyleBackColor = True
        '
        'lblHello
        '
        Me.lblHello.AutoSize = True
        Me.lblHello.Location = New System.Drawing.Point(15, 65)
        Me.lblHello.Name = "lblHello"
        Me.lblHello.Size = New System.Drawing.Size(0, 13)
        Me.lblHello.TabIndex = 1
        '
        'btn2
        '
        Me.btn2.Location = New System.Drawing.Point(33, 119)
        Me.btn2.Name = "btn2"
        Me.btn2.Size = New System.Drawing.Size(110, 28)
        Me.btn2.TabIndex = 2
        Me.btn2.Text = "Yes"
        Me.btn2.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 264)
        Me.Controls.Add(Me.btn2)
        Me.Controls.Add(Me.lblHello)
        Me.Controls.Add(Me.btnDo)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnDo As System.Windows.Forms.Button
    Friend WithEvents lblHello As System.Windows.Forms.Label
    Friend WithEvents btn2 As System.Windows.Forms.Button

End Class
