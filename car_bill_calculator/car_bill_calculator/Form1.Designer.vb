<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCarBill
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
        Me.btnQuit = New System.Windows.Forms.Button
        Me.txtHourlyRate = New System.Windows.Forms.TextBox
        Me.txtHoursWorked = New System.Windows.Forms.TextBox
        Me.txtCostOfParts = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.btnCalculate = New System.Windows.Forms.Button
        Me.lblLabourCharge = New System.Windows.Forms.Label
        Me.lblChargeParts = New System.Windows.Forms.Label
        Me.lblSubTotal = New System.Windows.Forms.Label
        Me.lblVAT = New System.Windows.Forms.Label
        Me.lblTotalBill = New System.Windows.Forms.Label
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.Label9 = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.lblVatRate = New System.Windows.Forms.Label
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnQuit
        '
        Me.btnQuit.Location = New System.Drawing.Point(128, 303)
        Me.btnQuit.Name = "btnQuit"
        Me.btnQuit.Size = New System.Drawing.Size(75, 23)
        Me.btnQuit.TabIndex = 1
        Me.btnQuit.Text = "Quit"
        Me.btnQuit.UseVisualStyleBackColor = True
        '
        'txtHourlyRate
        '
        Me.txtHourlyRate.Location = New System.Drawing.Point(132, 12)
        Me.txtHourlyRate.Name = "txtHourlyRate"
        Me.txtHourlyRate.Size = New System.Drawing.Size(71, 20)
        Me.txtHourlyRate.TabIndex = 2
        '
        'txtHoursWorked
        '
        Me.txtHoursWorked.Location = New System.Drawing.Point(133, 39)
        Me.txtHoursWorked.Name = "txtHoursWorked"
        Me.txtHoursWorked.Size = New System.Drawing.Size(70, 20)
        Me.txtHoursWorked.TabIndex = 3
        '
        'txtCostOfParts
        '
        Me.txtCostOfParts.Location = New System.Drawing.Point(133, 66)
        Me.txtCostOfParts.Name = "txtCostOfParts"
        Me.txtCostOfParts.Size = New System.Drawing.Size(70, 20)
        Me.txtCostOfParts.TabIndex = 4
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(24, 15)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(102, 13)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Labour: Hourly Rate"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 42)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(115, 13)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Labour: Hours Worked"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(60, 69)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(67, 13)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "Cost of Parts"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(73, 96)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(54, 13)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "VAT Rate"
        '
        'btnCalculate
        '
        Me.btnCalculate.Location = New System.Drawing.Point(128, 119)
        Me.btnCalculate.Name = "btnCalculate"
        Me.btnCalculate.Size = New System.Drawing.Size(75, 23)
        Me.btnCalculate.TabIndex = 10
        Me.btnCalculate.Text = "Calculate"
        Me.btnCalculate.UseVisualStyleBackColor = True
        '
        'lblLabourCharge
        '
        Me.lblLabourCharge.AutoSize = True
        Me.lblLabourCharge.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblLabourCharge.Location = New System.Drawing.Point(92, 26)
        Me.lblLabourCharge.MaximumSize = New System.Drawing.Size(50, 18)
        Me.lblLabourCharge.MinimumSize = New System.Drawing.Size(50, 18)
        Me.lblLabourCharge.Name = "lblLabourCharge"
        Me.lblLabourCharge.Size = New System.Drawing.Size(50, 18)
        Me.lblLabourCharge.TabIndex = 0
        '
        'lblChargeParts
        '
        Me.lblChargeParts.AutoSize = True
        Me.lblChargeParts.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblChargeParts.Location = New System.Drawing.Point(92, 50)
        Me.lblChargeParts.MaximumSize = New System.Drawing.Size(50, 18)
        Me.lblChargeParts.MinimumSize = New System.Drawing.Size(50, 18)
        Me.lblChargeParts.Name = "lblChargeParts"
        Me.lblChargeParts.Size = New System.Drawing.Size(50, 18)
        Me.lblChargeParts.TabIndex = 1
        '
        'lblSubTotal
        '
        Me.lblSubTotal.AutoSize = True
        Me.lblSubTotal.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblSubTotal.Location = New System.Drawing.Point(92, 74)
        Me.lblSubTotal.MaximumSize = New System.Drawing.Size(50, 18)
        Me.lblSubTotal.MinimumSize = New System.Drawing.Size(50, 18)
        Me.lblSubTotal.Name = "lblSubTotal"
        Me.lblSubTotal.Size = New System.Drawing.Size(50, 18)
        Me.lblSubTotal.TabIndex = 2
        '
        'lblVAT
        '
        Me.lblVAT.AutoSize = True
        Me.lblVAT.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblVAT.Location = New System.Drawing.Point(92, 98)
        Me.lblVAT.MaximumSize = New System.Drawing.Size(50, 18)
        Me.lblVAT.MinimumSize = New System.Drawing.Size(50, 18)
        Me.lblVAT.Name = "lblVAT"
        Me.lblVAT.Size = New System.Drawing.Size(50, 18)
        Me.lblVAT.TabIndex = 3
        '
        'lblTotalBill
        '
        Me.lblTotalBill.AutoSize = True
        Me.lblTotalBill.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblTotalBill.Location = New System.Drawing.Point(92, 122)
        Me.lblTotalBill.MaximumSize = New System.Drawing.Size(50, 18)
        Me.lblTotalBill.MinimumSize = New System.Drawing.Size(50, 18)
        Me.lblTotalBill.Name = "lblTotalBill"
        Me.lblTotalBill.Size = New System.Drawing.Size(50, 18)
        Me.lblTotalBill.TabIndex = 4
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.lblLabourCharge)
        Me.GroupBox1.Controls.Add(Me.lblTotalBill)
        Me.GroupBox1.Controls.Add(Me.lblChargeParts)
        Me.GroupBox1.Controls.Add(Me.lblSubTotal)
        Me.GroupBox1.Controls.Add(Me.lblVAT)
        Me.GroupBox1.ForeColor = System.Drawing.SystemColors.MenuText
        Me.GroupBox1.Location = New System.Drawing.Point(50, 148)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(153, 149)
        Me.GroupBox1.TabIndex = 11
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Bill Summary"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(36, 122)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(50, 13)
        Me.Label9.TabIndex = 9
        Me.Label9.Text = "Bill Total:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(14, 98)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(72, 13)
        Me.Label8.TabIndex = 8
        Me.Label8.Text = "VAT Payable:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(27, 74)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(59, 13)
        Me.Label7.TabIndex = 7
        Me.Label7.Text = "SUB Total:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(52, 50)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(34, 13)
        Me.Label6.TabIndex = 6
        Me.Label6.Text = "Parts:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(6, 26)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(80, 13)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "Labour Charge:"
        '
        'lblVatRate
        '
        Me.lblVatRate.AutoSize = True
        Me.lblVatRate.Location = New System.Drawing.Point(130, 96)
        Me.lblVatRate.Name = "lblVatRate"
        Me.lblVatRate.Size = New System.Drawing.Size(36, 13)
        Me.lblVatRate.TabIndex = 12
        Me.lblVatRate.Text = "17.5%"
        '
        'frmCarBill
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(215, 337)
        Me.ControlBox = False
        Me.Controls.Add(Me.lblVatRate)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btnCalculate)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtCostOfParts)
        Me.Controls.Add(Me.txtHoursWorked)
        Me.Controls.Add(Me.txtHourlyRate)
        Me.Controls.Add(Me.btnQuit)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmCarBill"
        Me.Text = "Car Repair Bill Calculator"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnQuit As System.Windows.Forms.Button
    Friend WithEvents txtHourlyRate As System.Windows.Forms.TextBox
    Friend WithEvents txtHoursWorked As System.Windows.Forms.TextBox
    Friend WithEvents txtCostOfParts As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents lblLabourCharge As System.Windows.Forms.Label
    Friend WithEvents btnCalculate As System.Windows.Forms.Button
    Friend WithEvents lblChargeParts As System.Windows.Forms.Label
    Friend WithEvents lblSubTotal As System.Windows.Forms.Label
    Friend WithEvents lblVAT As System.Windows.Forms.Label
    Friend WithEvents lblTotalBill As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents lblVatRate As System.Windows.Forms.Label

End Class
