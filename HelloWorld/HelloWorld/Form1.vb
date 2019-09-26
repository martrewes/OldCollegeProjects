Public Class Form1

    Private Sub btnDo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDo.Click

        If lblHello.Text = "I'm Visible" Then
            MsgBox("Click OK to Hide")
            lblHello.Text = ""
        ElseIf lblHello.Text = "" Then
            MsgBox("Click OK to Show")
            lblHello.Text = "I'm Visible"
        End If


    End Sub

    Private Sub btn2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn2.Click
        If btn2.Text = "Yes" Then
            btn2.Text = "No"
        ElseIf btn2.Text = "No" Then
            btn2.Text = "Yes"
        End If
    End Sub
End Class
