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
        Me.Label1 = New System.Windows.Forms.Label
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.txtHourWorked = New System.Windows.Forms.TextBox
        Me.txtHourRate = New System.Windows.Forms.TextBox
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.txtAfterTax = New System.Windows.Forms.TextBox
        Me.txtTaxPaid = New System.Windows.Forms.TextBox
        Me.txtBeforeTax = New System.Windows.Forms.TextBox
        Me.btnCalculate = New System.Windows.Forms.Button
        Me.btnTaxPerHour = New System.Windows.Forms.Button
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(80, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(151, 25)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Tax Calculator"
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.PictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PictureBox1.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(331, 43)
        Me.PictureBox1.TabIndex = 1
        Me.PictureBox1.TabStop = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 46)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(312, 39)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Thank you for using this program. Using this program, you will" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "be able to work o" & _
            "ut how much tax you could expect to be paying" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "from your upcoming wage. At least" & _
            " this way, no nasty surprises."
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(19, 20)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(66, 13)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Hourly Rate:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(19, 49)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(79, 13)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Hours Worked:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(19, 16)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(126, 13)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "Total Earned Before Tax:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(19, 42)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(52, 13)
        Me.Label6.TabIndex = 6
        Me.Label6.Text = "Tax Paid:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(19, 67)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(80, 13)
        Me.Label7.TabIndex = 7
        Me.Label7.Text = "Total After Tax:"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtHourWorked)
        Me.GroupBox1.Controls.Add(Me.txtHourRate)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Location = New System.Drawing.Point(15, 103)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(216, 87)
        Me.GroupBox1.TabIndex = 8
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Income Information"
        '
        'txtHourWorked
        '
        Me.txtHourWorked.Location = New System.Drawing.Point(162, 46)
        Me.txtHourWorked.Name = "txtHourWorked"
        Me.txtHourWorked.Size = New System.Drawing.Size(48, 20)
        Me.txtHourWorked.TabIndex = 6
        '
        'txtHourRate
        '
        Me.txtHourRate.Location = New System.Drawing.Point(162, 17)
        Me.txtHourRate.Name = "txtHourRate"
        Me.txtHourRate.Size = New System.Drawing.Size(48, 20)
        Me.txtHourRate.TabIndex = 5
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.txtAfterTax)
        Me.GroupBox2.Controls.Add(Me.txtTaxPaid)
        Me.GroupBox2.Controls.Add(Me.txtBeforeTax)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Location = New System.Drawing.Point(15, 196)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(216, 102)
        Me.GroupBox2.TabIndex = 9
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Tax Information"
        '
        'txtAfterTax
        '
        Me.txtAfterTax.Location = New System.Drawing.Point(162, 64)
        Me.txtAfterTax.Name = "txtAfterTax"
        Me.txtAfterTax.ReadOnly = True
        Me.txtAfterTax.Size = New System.Drawing.Size(48, 20)
        Me.txtAfterTax.TabIndex = 10
        '
        'txtTaxPaid
        '
        Me.txtTaxPaid.Location = New System.Drawing.Point(162, 39)
        Me.txtTaxPaid.Name = "txtTaxPaid"
        Me.txtTaxPaid.ReadOnly = True
        Me.txtTaxPaid.Size = New System.Drawing.Size(48, 20)
        Me.txtTaxPaid.TabIndex = 9
        '
        'txtBeforeTax
        '
        Me.txtBeforeTax.Location = New System.Drawing.Point(162, 13)
        Me.txtBeforeTax.Name = "txtBeforeTax"
        Me.txtBeforeTax.ReadOnly = True
        Me.txtBeforeTax.Size = New System.Drawing.Size(48, 20)
        Me.txtBeforeTax.TabIndex = 8
        '
        'btnCalculate
        '
        Me.btnCalculate.Location = New System.Drawing.Point(237, 147)
        Me.btnCalculate.Name = "btnCalculate"
        Me.btnCalculate.Size = New System.Drawing.Size(87, 23)
        Me.btnCalculate.TabIndex = 10
        Me.btnCalculate.Text = "Tax by Week"
        Me.btnCalculate.UseVisualStyleBackColor = True
        '
        'btnTaxPerHour
        '
        Me.btnTaxPerHour.Location = New System.Drawing.Point(237, 118)
        Me.btnTaxPerHour.Name = "btnTaxPerHour"
        Me.btnTaxPerHour.Size = New System.Drawing.Size(87, 23)
        Me.btnTaxPerHour.TabIndex = 11
        Me.btnTaxPerHour.Text = "Tax Per Hour"
        Me.btnTaxPerHour.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(332, 331)
        Me.ControlBox = False
        Me.Controls.Add(Me.btnTaxPerHour)
        Me.Controls.Add(Me.btnCalculate)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox1)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Form1"
        Me.Text = "Tax Calculator"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents txtHourWorked As System.Windows.Forms.TextBox
    Friend WithEvents txtHourRate As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents txtBeforeTax As System.Windows.Forms.TextBox
    Friend WithEvents txtTaxPaid As System.Windows.Forms.TextBox
    Friend WithEvents txtAfterTax As System.Windows.Forms.TextBox
    Friend WithEvents btnCalculate As System.Windows.Forms.Button
    Friend WithEvents btnTaxPerHour As System.Windows.Forms.Button

End Class
