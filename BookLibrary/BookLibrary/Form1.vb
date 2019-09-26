Imports System.Data.OleDb
Imports System
Imports System.Data

Public Class Form1
    Private Sub btnAddNewBook_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAddNewBook.Click
        frmAddBooks.Show()
    End Sub

    Private Sub btnSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSearch.Click

        If rbnISBN.Checked = True Then
            Me.BooksTableAdapter.ISBN(Me.BookLibraryDataSet.Books, txtSearch.Text)
        ElseIf rbnTitle.Checked = True Then
            Me.BooksTableAdapter.Title(Me.BookLibraryDataSet.Books, txtSearch.Text)
        ElseIf rbnAuthor.Checked = True Then
            Me.BooksTableAdapter.Author(Me.BookLibraryDataSet.Books, txtSearch.Text)
        End If
        If DatabaseData.RowCount = 1 Then
            MsgBox("Please try again.")
            txtSearch.Text = ""
        End If
    End Sub

End Class
