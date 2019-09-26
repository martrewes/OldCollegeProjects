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
        Me.components = New System.ComponentModel.Container
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Me.btnAddNewBook = New System.Windows.Forms.Button
        Me.btnSearch = New System.Windows.Forms.Button
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.txtSearch = New System.Windows.Forms.TextBox
        Me.rbnAuthor = New System.Windows.Forms.RadioButton
        Me.rbnTitle = New System.Windows.Forms.RadioButton
        Me.rbnISBN = New System.Windows.Forms.RadioButton
        Me.DatabaseData = New System.Windows.Forms.DataGridView
        Me.ISBNNoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.TitleDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.AuthorDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ReleaseYearDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.RowDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ShelfDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.BooksBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.BookLibraryDataSet = New BookLibrary.BookLibraryDataSet
        Me.BooksTableAdapter = New BookLibrary.BookLibraryDataSetTableAdapters.BooksTableAdapter
        Me.TableAdapterManager = New BookLibrary.BookLibraryDataSetTableAdapters.TableAdapterManager
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.Label7 = New System.Windows.Forms.Label
        Me.GroupBox1.SuspendLayout()
        CType(Me.DatabaseData, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BooksBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BookLibraryDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnAddNewBook
        '
        Me.btnAddNewBook.Location = New System.Drawing.Point(202, 17)
        Me.btnAddNewBook.Name = "btnAddNewBook"
        Me.btnAddNewBook.Size = New System.Drawing.Size(100, 23)
        Me.btnAddNewBook.TabIndex = 0
        Me.btnAddNewBook.Text = "Add New Book"
        Me.btnAddNewBook.UseVisualStyleBackColor = True
        '
        'btnSearch
        '
        Me.btnSearch.Location = New System.Drawing.Point(202, 50)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(100, 23)
        Me.btnSearch.TabIndex = 2
        Me.btnSearch.Text = "Search Books"
        Me.btnSearch.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtSearch)
        Me.GroupBox1.Controls.Add(Me.rbnAuthor)
        Me.GroupBox1.Controls.Add(Me.rbnTitle)
        Me.GroupBox1.Controls.Add(Me.rbnISBN)
        Me.GroupBox1.Controls.Add(Me.btnSearch)
        Me.GroupBox1.Controls.Add(Me.btnAddNewBook)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 59)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(312, 79)
        Me.GroupBox1.TabIndex = 8
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Search For A Book"
        '
        'txtSearch
        '
        Me.txtSearch.Location = New System.Drawing.Point(7, 50)
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.Size = New System.Drawing.Size(184, 20)
        Me.txtSearch.TabIndex = 9
        '
        'rbnAuthor
        '
        Me.rbnAuthor.AutoSize = True
        Me.rbnAuthor.Location = New System.Drawing.Point(135, 19)
        Me.rbnAuthor.Name = "rbnAuthor"
        Me.rbnAuthor.Size = New System.Drawing.Size(56, 17)
        Me.rbnAuthor.TabIndex = 8
        Me.rbnAuthor.TabStop = True
        Me.rbnAuthor.Text = "Author"
        Me.rbnAuthor.UseVisualStyleBackColor = True
        '
        'rbnTitle
        '
        Me.rbnTitle.AutoSize = True
        Me.rbnTitle.Location = New System.Drawing.Point(83, 20)
        Me.rbnTitle.Name = "rbnTitle"
        Me.rbnTitle.Size = New System.Drawing.Size(45, 17)
        Me.rbnTitle.TabIndex = 7
        Me.rbnTitle.TabStop = True
        Me.rbnTitle.Text = "Title"
        Me.rbnTitle.UseVisualStyleBackColor = True
        '
        'rbnISBN
        '
        Me.rbnISBN.AutoSize = True
        Me.rbnISBN.Location = New System.Drawing.Point(6, 19)
        Me.rbnISBN.Name = "rbnISBN"
        Me.rbnISBN.Size = New System.Drawing.Size(70, 17)
        Me.rbnISBN.TabIndex = 6
        Me.rbnISBN.TabStop = True
        Me.rbnISBN.Text = "ISBN No."
        Me.rbnISBN.UseVisualStyleBackColor = True
        '
        'DatabaseData
        '
        Me.DatabaseData.AllowUserToDeleteRows = False
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.DatabaseData.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle2
        Me.DatabaseData.AutoGenerateColumns = False
        Me.DatabaseData.BackgroundColor = System.Drawing.SystemColors.Control
        Me.DatabaseData.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DatabaseData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DatabaseData.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ISBNNoDataGridViewTextBoxColumn, Me.TitleDataGridViewTextBoxColumn, Me.AuthorDataGridViewTextBoxColumn, Me.ReleaseYearDataGridViewTextBoxColumn, Me.RowDataGridViewTextBoxColumn, Me.ShelfDataGridViewTextBoxColumn})
        Me.DatabaseData.DataSource = Me.BooksBindingSource
        Me.DatabaseData.Location = New System.Drawing.Point(12, 144)
        Me.DatabaseData.Name = "DatabaseData"
        Me.DatabaseData.RowHeadersVisible = False
        Me.DatabaseData.Size = New System.Drawing.Size(605, 123)
        Me.DatabaseData.TabIndex = 10
        '
        'ISBNNoDataGridViewTextBoxColumn
        '
        Me.ISBNNoDataGridViewTextBoxColumn.DataPropertyName = "ISBNNo"
        Me.ISBNNoDataGridViewTextBoxColumn.HeaderText = "ISBNNo"
        Me.ISBNNoDataGridViewTextBoxColumn.Name = "ISBNNoDataGridViewTextBoxColumn"
        '
        'TitleDataGridViewTextBoxColumn
        '
        Me.TitleDataGridViewTextBoxColumn.DataPropertyName = "Title"
        Me.TitleDataGridViewTextBoxColumn.HeaderText = "Title"
        Me.TitleDataGridViewTextBoxColumn.Name = "TitleDataGridViewTextBoxColumn"
        '
        'AuthorDataGridViewTextBoxColumn
        '
        Me.AuthorDataGridViewTextBoxColumn.DataPropertyName = "Author"
        Me.AuthorDataGridViewTextBoxColumn.HeaderText = "Author"
        Me.AuthorDataGridViewTextBoxColumn.Name = "AuthorDataGridViewTextBoxColumn"
        '
        'ReleaseYearDataGridViewTextBoxColumn
        '
        Me.ReleaseYearDataGridViewTextBoxColumn.DataPropertyName = "ReleaseYear"
        Me.ReleaseYearDataGridViewTextBoxColumn.HeaderText = "ReleaseYear"
        Me.ReleaseYearDataGridViewTextBoxColumn.Name = "ReleaseYearDataGridViewTextBoxColumn"
        '
        'RowDataGridViewTextBoxColumn
        '
        Me.RowDataGridViewTextBoxColumn.DataPropertyName = "Row"
        Me.RowDataGridViewTextBoxColumn.HeaderText = "Row"
        Me.RowDataGridViewTextBoxColumn.Name = "RowDataGridViewTextBoxColumn"
        '
        'ShelfDataGridViewTextBoxColumn
        '
        Me.ShelfDataGridViewTextBoxColumn.DataPropertyName = "Shelf"
        Me.ShelfDataGridViewTextBoxColumn.HeaderText = "Shelf"
        Me.ShelfDataGridViewTextBoxColumn.Name = "ShelfDataGridViewTextBoxColumn"
        '
        'BooksBindingSource
        '
        Me.BooksBindingSource.DataMember = "Books"
        Me.BooksBindingSource.DataSource = Me.BookLibraryDataSet
        '
        'BookLibraryDataSet
        '
        Me.BookLibraryDataSet.DataSetName = "BookLibraryDataSet"
        Me.BookLibraryDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'BooksTableAdapter
        '
        Me.BooksTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.BooksTableAdapter = Me.BooksTableAdapter
        Me.TableAdapterManager.UpdateOrder = BookLibrary.BookLibraryDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.PictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PictureBox1.Location = New System.Drawing.Point(1, 1)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(627, 52)
        Me.PictureBox1.TabIndex = 11
        Me.PictureBox1.TabStop = False
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(14, 9)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(315, 29)
        Me.Label7.TabIndex = 14
        Me.Label7.Text = "Library Book Search System"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(629, 280)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.DatabaseData)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "Form1"
        Me.Text = "Libray Book Search System"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.DatabaseData, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BooksBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BookLibraryDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnAddNewBook As System.Windows.Forms.Button
    Friend WithEvents btnSearch As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents DatabaseData As System.Windows.Forms.DataGridView
    Friend WithEvents BookLibraryDataSet As BookLibrary.BookLibraryDataSet
    Friend WithEvents BooksBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents BooksTableAdapter As BookLibrary.BookLibraryDataSetTableAdapters.BooksTableAdapter
    Friend WithEvents TableAdapterManager As BookLibrary.BookLibraryDataSetTableAdapters.TableAdapterManager
    Friend WithEvents ISBNNoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TitleDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents AuthorDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ReleaseYearDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents RowDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ShelfDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents txtSearch As System.Windows.Forms.TextBox
    Friend WithEvents rbnAuthor As System.Windows.Forms.RadioButton
    Friend WithEvents rbnTitle As System.Windows.Forms.RadioButton
    Friend WithEvents rbnISBN As System.Windows.Forms.RadioButton
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Label7 As System.Windows.Forms.Label

End Class
