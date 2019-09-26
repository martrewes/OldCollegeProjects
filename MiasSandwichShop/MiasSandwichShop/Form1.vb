Imports System.Runtime.InteropServices




Public Class Form1



    Dim Shift As Boolean
    Dim key As String
    Dim button As String

    Private Sub btnQ_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnQ.Click
        MsgBox("It seems that the name you have entered is not in the database, please add the Address information for it to be added to the database.")
    End Sub
    Private Sub btnShift_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnShift.Click
        If Shift = True Then
            btnShift.ForeColor = Color.Black
            Shift = False
        ElseIf Shift = False Then
            btnShift.ForeColor = Color.Red
            Shift = True
        End If
    End Sub


    Private Sub CheckBox1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked = True Then

            TextBox2.Enabled = False
            TextBox3.Enabled = False
            TextBox4.Enabled = False
            Label1.Enabled = False
            Label2.Enabled = False
            Label3.Enabled = False
            Label4.Enabled = False
        ElseIf CheckBox1.Checked = False Then
            TextBox1.Enabled = True
            TextBox2.Enabled = True
            TextBox3.Enabled = True
            TextBox4.Enabled = True
            Label1.Enabled = True
            Label2.Enabled = True
            Label3.Enabled = True
            Label4.Enabled = True
        End If
    End Sub


    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If Button1.Location.X = 0 Then
            Button1.Location = New Point(692, 12)
            Panel1.Location = New Point(12, 12)
            Button1.Text = "<"
        ElseIf Button1.Location.X = 692 Then
            Button1.Location = New Point(0, 12)
            Panel1.Location = New Point(-680, 12)
            Button1.Text = ">"

        End If
    End Sub


    Private Sub TextBox7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub TextBox5_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox5.TextChanged


    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim CardNo4 As Double = TextBox9.Text
    End Sub
    Private Sub Add()
        Dim n As Integer = 1
        Dim Label As String

        If Label(n) = "" Then

        End If

    End Sub
    Private Sub Button2_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        button = "EGSLD"

    End Sub

    Private Sub btnM_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnM.Click
        TextBox1.Text = TextBox1.Text + "M"
    End Sub

    Private Sub TextBox9_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox9.TextChanged

    End Sub

    Private Sub Panel1_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub Button16_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button16.Click
        MsgBox("Please varify the order to the customer. Is it okay to proceed?", MsgBoxStyle.YesNo)

    End Sub
End Class
