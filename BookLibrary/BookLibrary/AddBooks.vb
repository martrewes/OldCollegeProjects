Public Class frmAddBooks

    Private Sub frmAddBooks_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'BookDataSet.Table1' table. You can move, or remove it, as needed.
        Me.Table1TableAdapter.Fill(Me.BookDataSet.Table1)
        'TODO: This line of code loads data into the 'BookDataSet.Table1' table. You can move, or remove it, as needed.
        Me.Table1TableAdapter.Fill(Me.BookDataSet.Table1)

    End Sub
End Class