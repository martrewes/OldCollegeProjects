<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMain
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMain))
        Me.btnButLogin = New System.Windows.Forms.Button
        Me.Label1 = New System.Windows.Forms.Label
        Me.txtArtist = New System.Windows.Forms.TextBox
        Me.btnPlay = New System.Windows.Forms.Button
        Me.lblStation = New System.Windows.Forms.Label
        Me.lblListening = New System.Windows.Forms.Label
        Me.WMP = New AxWMPLib.AxWindowsMediaPlayer
        Me.btnStop = New System.Windows.Forms.Button
        CType(Me.WMP, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnButLogin
        '
        Me.btnButLogin.Location = New System.Drawing.Point(12, 12)
        Me.btnButLogin.Name = "btnButLogin"
        Me.btnButLogin.Size = New System.Drawing.Size(115, 23)
        Me.btnButLogin.TabIndex = 0
        Me.btnButLogin.Text = "Login"
        Me.btnButLogin.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 40)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(109, 13)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "Please Enter An Artist"
        '
        'txtArtist
        '
        Me.txtArtist.Location = New System.Drawing.Point(15, 57)
        Me.txtArtist.Name = "txtArtist"
        Me.txtArtist.Size = New System.Drawing.Size(112, 20)
        Me.txtArtist.TabIndex = 9
        '
        'btnPlay
        '
        Me.btnPlay.Location = New System.Drawing.Point(15, 83)
        Me.btnPlay.Name = "btnPlay"
        Me.btnPlay.Size = New System.Drawing.Size(53, 45)
        Me.btnPlay.TabIndex = 10
        Me.btnPlay.Text = "Play"
        Me.btnPlay.UseVisualStyleBackColor = True
        '
        'lblStation
        '
        Me.lblStation.AutoSize = True
        Me.lblStation.Location = New System.Drawing.Point(16, 358)
        Me.lblStation.Name = "lblStation"
        Me.lblStation.Size = New System.Drawing.Size(0, 13)
        Me.lblStation.TabIndex = 11
        '
        'lblListening
        '
        Me.lblListening.AutoSize = True
        Me.lblListening.Location = New System.Drawing.Point(12, 131)
        Me.lblListening.MaximumSize = New System.Drawing.Size(127, 30)
        Me.lblListening.Name = "lblListening"
        Me.lblListening.Size = New System.Drawing.Size(0, 13)
        Me.lblListening.TabIndex = 12
        '
        'WMP
        '
        Me.WMP.Enabled = True
        Me.WMP.Location = New System.Drawing.Point(15, 151)
        Me.WMP.Name = "WMP"
        Me.WMP.OcxState = CType(resources.GetObject("WMP.OcxState"), System.Windows.Forms.AxHost.State)
        Me.WMP.Size = New System.Drawing.Size(14, 22)
        Me.WMP.TabIndex = 13
        Me.WMP.Visible = False
        '
        'btnStop
        '
        Me.btnStop.Location = New System.Drawing.Point(74, 83)
        Me.btnStop.Name = "btnStop"
        Me.btnStop.Size = New System.Drawing.Size(53, 45)
        Me.btnStop.TabIndex = 15
        Me.btnStop.Text = "Stop"
        Me.btnStop.UseVisualStyleBackColor = True
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(138, 160)
        Me.Controls.Add(Me.btnStop)
        Me.Controls.Add(Me.WMP)
        Me.Controls.Add(Me.lblListening)
        Me.Controls.Add(Me.lblStation)
        Me.Controls.Add(Me.btnPlay)
        Me.Controls.Add(Me.txtArtist)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnButLogin)
        Me.Name = "frmMain"
        Me.Text = "Last.NET"
        CType(Me.WMP, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnButLogin As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtArtist As System.Windows.Forms.TextBox
    Friend WithEvents btnPlay As System.Windows.Forms.Button
    Friend WithEvents lblStation As System.Windows.Forms.Label
    Friend WithEvents lblListening As System.Windows.Forms.Label
    Friend WithEvents WMP As AxWMPLib.AxWindowsMediaPlayer
    Friend WithEvents btnStop As System.Windows.Forms.Button
End Class
