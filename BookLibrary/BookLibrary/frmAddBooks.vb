Imports System.Data.OleDb
Imports System
Imports System.Data

Public Class frmAddBooks

    Private Sub btnAddBook_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAddBook.Click
        Dim con As OleDbConnection
        Dim sql As String
        Dim str As String
        str = "Provider=Microsoft.Jet.oledb.4.0;Data Source=BookLibrary.mdb;"
        con = New OleDbConnection(str)
        sql = "insert into Books(ISBNNo,Title,Author,ReleaseYear,Row,Shelf) values('" & txtISBNNo.Text & "','" & txtTitle.Text & "','" & txtAuthor.Text & "','" & txtYear.Text & "','" & txtRow.Text & "','" & txtShelf.Text & "')"
        Dim cmd As OleDbCommand
        Try
            con.Open()
            cmd = New OleDbCommand(sql, con)
            cmd.ExecuteNonQuery()
            txtISBNNo.Text = ""
            txtTitle.Text = ""
            txtAuthor.Text = ""
            txtYear.Text = ""
            txtRow.Text = ""
            txtShelf.Text = ""
            MessageBox.Show("Insert Successful :)")
            con.Close()

        Catch ex As OleDbException
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Oledb Error")
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "General Error")
        End Try

    End Sub

    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub
End Class