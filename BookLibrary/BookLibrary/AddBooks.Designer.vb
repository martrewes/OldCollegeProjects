<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAddBooks
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
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.txtAddTitle = New System.Windows.Forms.TextBox
        Me.Table1BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.BookDataSet = New BookLibrary.BookDataSet
        Me.txtAddAuthor = New System.Windows.Forms.TextBox
        Me.txtAddISBN = New System.Windows.Forms.TextBox
        Me.txtAddYear = New System.Windows.Forms.TextBox
        Me.txtAddRow = New System.Windows.Forms.TextBox
        Me.txtAddShelf = New System.Windows.Forms.TextBox
        Me.Table1TableAdapter = New BookLibrary.BookDataSetTableAdapters.Table1TableAdapter
        Me.TableAdapterManager = New BookLibrary.BookDataSetTableAdapters.TableAdapterManager
        Me.TextBox1 = New System.Windows.Forms.TextBox
        CType(Me.Table1BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BookDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 50)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(27, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Title"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 77)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(38, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Author"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(12, 104)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(52, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "ISBN No."
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(12, 131)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(29, 13)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Year"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(12, 158)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(29, 13)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Row"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(12, 185)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(31, 13)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = "Shelf"
        '
        'txtAddTitle
        '
        Me.txtAddTitle.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Table1BindingSource, "Title", True))
        Me.txtAddTitle.Location = New System.Drawing.Point(70, 47)
        Me.txtAddTitle.Name = "txtAddTitle"
        Me.txtAddTitle.Size = New System.Drawing.Size(100, 20)
        Me.txtAddTitle.TabIndex = 7
        '
        'Table1BindingSource
        '
        Me.Table1BindingSource.DataMember = "Table1"
        Me.Table1BindingSource.DataSource = Me.BookDataSet
        '
        'BookDataSet
        '
        Me.BookDataSet.DataSetName = "BookDataSet"
        Me.BookDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'txtAddAuthor
        '
        Me.txtAddAuthor.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Table1BindingSource, "Author", True))
        Me.txtAddAuthor.Location = New System.Drawing.Point(70, 74)
        Me.txtAddAuthor.Name = "txtAddAuthor"
        Me.txtAddAuthor.Size = New System.Drawing.Size(100, 20)
        Me.txtAddAuthor.TabIndex = 8
        '
        'txtAddISBN
        '
        Me.txtAddISBN.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Table1BindingSource, "ISBN", True))
        Me.txtAddISBN.Location = New System.Drawing.Point(70, 101)
        Me.txtAddISBN.Name = "txtAddISBN"
        Me.txtAddISBN.Size = New System.Drawing.Size(100, 20)
        Me.txtAddISBN.TabIndex = 9
        '
        'txtAddYear
        '
        Me.txtAddYear.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Table1BindingSource, "Year", True))
        Me.txtAddYear.Location = New System.Drawing.Point(70, 128)
        Me.txtAddYear.Name = "txtAddYear"
        Me.txtAddYear.Size = New System.Drawing.Size(100, 20)
        Me.txtAddYear.TabIndex = 10
        '
        'txtAddRow
        '
        Me.txtAddRow.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Table1BindingSource, "Row", True))
        Me.txtAddRow.Location = New System.Drawing.Point(70, 155)
        Me.txtAddRow.Name = "txtAddRow"
        Me.txtAddRow.Size = New System.Drawing.Size(100, 20)
        Me.txtAddRow.TabIndex = 11
        '
        'txtAddShelf
        '
        Me.txtAddShelf.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Table1BindingSource, "Shelf", True))
        Me.txtAddShelf.Location = New System.Drawing.Point(70, 182)
        Me.txtAddShelf.Name = "txtAddShelf"
        Me.txtAddShelf.Size = New System.Drawing.Size(100, 20)
        Me.txtAddShelf.TabIndex = 12
        '
        'Table1TableAdapter
        '
        Me.Table1TableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.Table1TableAdapter = Me.Table1TableAdapter
        Me.TableAdapterManager.UpdateOrder = BookLibrary.BookDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'TextBox1
        '
        Me.TextBox1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.TextBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.Location = New System.Drawing.Point(1, 1)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.ReadOnly = True
        Me.TextBox1.Size = New System.Drawing.Size(269, 35)
        Me.TextBox1.TabIndex = 13
        Me.TextBox1.Text = "Add A Book"
        '
        'frmAddBooks
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(271, 289)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.txtAddShelf)
        Me.Controls.Add(Me.txtAddRow)
        Me.Controls.Add(Me.txtAddYear)
        Me.Controls.Add(Me.txtAddISBN)
        Me.Controls.Add(Me.txtAddAuthor)
        Me.Controls.Add(Me.txtAddTitle)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Name = "frmAddBooks"
        Me.Text = "Add a New Book"
        CType(Me.Table1BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BookDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtAddTitle As System.Windows.Forms.TextBox
    Friend WithEvents txtAddAuthor As System.Windows.Forms.TextBox
    Friend WithEvents txtAddISBN As System.Windows.Forms.TextBox
    Friend WithEvents txtAddYear As System.Windows.Forms.TextBox
    Friend WithEvents txtAddRow As System.Windows.Forms.TextBox
    Friend WithEvents txtAddShelf As System.Windows.Forms.TextBox
    Friend WithEvents BookDataSet As BookLibrary.BookDataSet
    Friend WithEvents Table1BindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Table1TableAdapter As BookLibrary.BookDataSetTableAdapters.Table1TableAdapter
    Friend WithEvents TableAdapterManager As BookLibrary.BookDataSetTableAdapters.TableAdapterManager
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
End Class
