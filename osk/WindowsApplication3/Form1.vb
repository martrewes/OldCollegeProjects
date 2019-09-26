Public Class Form1
    Dim Shift As Boolean

    Private Sub btnA_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnA.Click
        If Shift = True Then
            TextBox1.Text = TextBox1.Text & "A"
            Shift = False
            btnShift.ForeColor = Color.Black
        Else
            TextBox1.Text = TextBox1.Text & "a"
        End If
    End Sub

    Private Sub btnB_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnB.Click
        If Shift = True Then
            TextBox1.Text = TextBox1.Text & "B"
            Shift = False
            btnShift.ForeColor = Color.Black
        Else
            TextBox1.Text = TextBox1.Text & "b"
        End If
    End Sub

    Private Sub btnC_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnC.Click
        If Shift = True then
            TextBox1.Text = TextBox1.Text & "C"
            Shift = False
            btnShift.ForeColor = Color.Black

        Else
            TextBox1.Text = TextBox1.Text & "c"
        End If
    End Sub

    Private Sub btnShift_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnShift.Click
        If btnShift.ForeColor = Color.Red Then
            Shift = False
            btnShift.ForeColor = Color.Black
        Else
            btnShift.ForeColor = Color.Red
            Shift = True
        End If
    End Sub
End Class
