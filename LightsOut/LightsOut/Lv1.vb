
Public Class Lv1
    Dim LevelNumber As Integer
    Public Function Check() As Boolean
        If btn1.BackColor = Color.Transparent And btn2.BackColor = Color.Transparent And btn3.BackColor = Color.Transparent And btn4.BackColor = Color.Transparent And btn5.BackColor = Color.Transparent And btn6.BackColor = Color.Transparent And btn7.BackColor = Color.Transparent And btn8.BackColor = Color.Transparent And btn8.BackColor = Color.Transparent And btn9.BackColor = Color.Transparent And btn10.BackColor = Color.Transparent And btn11.BackColor = Color.Transparent And btn12.BackColor = Color.Transparent And btn13.BackColor = Color.Transparent And btn14.BackColor = Color.Transparent And btn15.BackColor = Color.Transparent And btn16.BackColor = Color.Transparent And btn17.BackColor = Color.Transparent And btn18.BackColor = Color.Transparent And btn19.BackColor = Color.Transparent And btn20.BackColor = Color.Transparent And btn21.BackColor = Color.Transparent And btn22.BackColor = Color.Transparent And btn23.BackColor = Color.Transparent And btn24.BackColor = Color.Transparent And btn25.BackColor = Color.Transparent Then
            Check = True
        End If
    End Function
    Public Function NextLevel() As Boolean
        If Val(LevelNumber) = 1 And Check() = True Then
            MsgBox("Well Done, Please continue to the next Level")
            Me.Text = "Lights Out! - Level 2"
            btn6.BackColor = Color.Green
            btn8.BackColor = Color.Green
            btn10.BackColor = Color.Green
            btn16.BackColor = Color.Green
            btn18.BackColor = Color.Green
            btn20.BackColor = Color.Green
            btn1.BackColor = Color.Green
            btn3.BackColor = Color.Green
            btn5.BackColor = Color.Green
            btn21.BackColor = Color.Green
            btn23.BackColor = Color.Green
            btn25.BackColor = Color.Green
            LevelNumber = 2
        ElseIf Val(LevelNumber) = 2 And Check() = True Then
            MsgBox("Well Done, Please continue to the next Level")
            Me.Text = "Lights Out! - Level 3"
            btn2.BackColor = Color.Green
            btn4.BackColor = Color.Green
            btn6.BackColor = Color.Green
            btn7.BackColor = Color.Green
            btn9.BackColor = Color.Green
            btn10.BackColor = Color.Green
            btn11.BackColor = Color.Green
            btn12.BackColor = Color.Green
            btn14.BackColor = Color.Green
            btn15.BackColor = Color.Green
            btn16.BackColor = Color.Green
            btn17.BackColor = Color.Green
            btn19.BackColor = Color.Green
            btn20.BackColor = Color.Green
            btn22.BackColor = Color.Green
            btn24.BackColor = Color.Green
            LevelNumber = 3
        ElseIf Val(LevelNumber) = 3 And Check() = True Then
            MsgBox("Well Done, Please continue to the next Level")
            Me.Text = "Lights Out! - Level 4"
            btn6.BackColor = Color.Green
            btn7.BackColor = Color.Green
            btn9.BackColor = Color.Green
            btn10.BackColor = Color.Green
            btn16.BackColor = Color.Green
            btn20.BackColor = Color.Green
            btn21.BackColor = Color.Green
            btn22.BackColor = Color.Green
            btn24.BackColor = Color.Green
            btn25.BackColor = Color.Green
            LevelNumber = 4
            MsgBox("Thank you for playing this Game. I hope you had fun :)", MsgBoxStyle.OkOnly, AcceptButton)
            Me.Close()
            End If

    End Function

    Private Sub btna1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn1.Click
        If btn1.BackColor = Color.Green Then
            btn1.BackColor = Color.Transparent
        ElseIf btn1.BackColor = Color.Transparent Then
            btn1.BackColor = Color.Green
        End If

        If btn2.BackColor = Color.Green Then
            btn2.BackColor = Color.Transparent
        ElseIf btn2.BackColor = Color.Transparent Then
            btn2.BackColor = Color.Green
        End If

        If btn6.BackColor = Color.Green Then
            btn6.BackColor = Color.Transparent
        ElseIf btn6.BackColor = Color.Transparent Then
            btn6.BackColor = Color.Green
        End If
        NextLevel()
    End Sub

    Private Sub btna2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn2.Click
        If btn1.BackColor = Color.Green Then
            btn1.BackColor = Color.Transparent
        ElseIf btn1.BackColor = Color.Transparent Then
            btn1.BackColor = Color.Green
        End If

        If btn2.BackColor = Color.Green Then
            btn2.BackColor = Color.Transparent
        ElseIf btn2.BackColor = Color.Transparent Then
            btn2.BackColor = Color.Green
        End If

        If btn3.BackColor = Color.Green Then
            btn3.BackColor = Color.Transparent
        ElseIf btn3.BackColor = Color.Transparent Then
            btn3.BackColor = Color.Green
        End If

        If btn7.BackColor = Color.Green Then
            btn7.BackColor = Color.Transparent
        ElseIf btn7.BackColor = Color.Transparent Then
            btn7.BackColor = Color.Green
        End If
        NextLevel()
    End Sub

    Private Sub btna3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn3.Click
        If btn4.BackColor = Color.Green Then
            btn4.BackColor = Color.Transparent
        ElseIf btn4.BackColor = Color.Transparent Then
            btn4.BackColor = Color.Green
        End If

        If btn2.BackColor = Color.Green Then
            btn2.BackColor = Color.Transparent
        ElseIf btn2.BackColor = Color.Transparent Then
            btn2.BackColor = Color.Green
        End If

        If btn3.BackColor = Color.Green Then
            btn3.BackColor = Color.Transparent
        ElseIf btn3.BackColor = Color.Transparent Then
            btn3.BackColor = Color.Green
        End If

        If btn8.BackColor = Color.Green Then
            btn8.BackColor = Color.Transparent
        ElseIf btn8.BackColor = Color.Transparent Then
            btn8.BackColor = Color.Green
        End If
        NextLevel()
    End Sub

    Private Sub btna4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn4.Click
        If btn4.BackColor = Color.Green Then
            btn4.BackColor = Color.Transparent
        ElseIf btn4.BackColor = Color.Transparent Then
            btn4.BackColor = Color.Green
        End If

        If btn5.BackColor = Color.Green Then
            btn5.BackColor = Color.Transparent
        ElseIf btn5.BackColor = Color.Transparent Then
            btn5.BackColor = Color.Green
        End If

        If btn3.BackColor = Color.Green Then
            btn3.BackColor = Color.Transparent
        ElseIf btn3.BackColor = Color.Transparent Then
            btn3.BackColor = Color.Green
        End If

        If btn9.BackColor = Color.Green Then
            btn9.BackColor = Color.Transparent
        ElseIf btn9.BackColor = Color.Transparent Then
            btn9.BackColor = Color.Green
        End If
        NextLevel()
    End Sub

    Private Sub btna5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn5.Click
        If btn5.BackColor = Color.Green Then
            btn5.BackColor = Color.Transparent
        ElseIf btn5.BackColor = Color.Transparent Then
            btn5.BackColor = Color.Green
        End If

        If btn4.BackColor = Color.Green Then
            btn4.BackColor = Color.Transparent
        ElseIf btn4.BackColor = Color.Transparent Then
            btn4.BackColor = Color.Green
        End If

        If btn10.BackColor = Color.Green Then
            btn10.BackColor = Color.Transparent
        ElseIf btn10.BackColor = Color.Transparent Then
            btn10.BackColor = Color.Green
        End If
        NextLevel()
    End Sub

    Private Sub btna6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn6.Click
        If btn1.BackColor = Color.Green Then
            btn1.BackColor = Color.Transparent
        ElseIf btn1.BackColor = Color.Transparent Then
            btn1.BackColor = Color.Green
        End If

        If btn6.BackColor = Color.Green Then
            btn6.BackColor = Color.Transparent
        ElseIf btn6.BackColor = Color.Transparent Then
            btn6.BackColor = Color.Green
        End If

        If btn7.BackColor = Color.Green Then
            btn7.BackColor = Color.Transparent
        ElseIf btn7.BackColor = Color.Transparent Then
            btn7.BackColor = Color.Green
        End If

        If btn11.BackColor = Color.Green Then
            btn11.BackColor = Color.Transparent
        ElseIf btn11.BackColor = Color.Transparent Then
            btn11.BackColor = Color.Green
        End If
        NextLevel()
    End Sub

    Private Sub btna7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn7.Click
        If btn6.BackColor = Color.Green Then
            btn6.BackColor = Color.Transparent
        ElseIf btn6.BackColor = Color.Transparent Then
            btn6.BackColor = Color.Green
        End If

        If btn7.BackColor = Color.Green Then
            btn7.BackColor = Color.Transparent
        ElseIf btn7.BackColor = Color.Transparent Then
            btn7.BackColor = Color.Green
        End If

        If btn8.BackColor = Color.Green Then
            btn8.BackColor = Color.Transparent
        ElseIf btn8.BackColor = Color.Transparent Then
            btn8.BackColor = Color.Green
        End If

        If btn2.BackColor = Color.Green Then
            btn2.BackColor = Color.Transparent
        ElseIf btn2.BackColor = Color.Transparent Then
            btn2.BackColor = Color.Green
        End If

        If btn12.BackColor = Color.Green Then
            btn12.BackColor = Color.Transparent
        ElseIf btn12.BackColor = Color.Transparent Then
            btn12.BackColor = Color.Green
        End If
        NextLevel()
    End Sub

    Private Sub btna8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn8.Click
        If btn7.BackColor = Color.Green Then
            btn7.BackColor = Color.Transparent
        ElseIf btn7.BackColor = Color.Transparent Then
            btn7.BackColor = Color.Green
        End If

        If btn8.BackColor = Color.Green Then
            btn8.BackColor = Color.Transparent
        ElseIf btn8.BackColor = Color.Transparent Then
            btn8.BackColor = Color.Green
        End If

        If btn9.BackColor = Color.Green Then
            btn9.BackColor = Color.Transparent
        ElseIf btn9.BackColor = Color.Transparent Then
            btn9.BackColor = Color.Green
        End If

        If btn3.BackColor = Color.Green Then
            btn3.BackColor = Color.Transparent
        ElseIf btn3.BackColor = Color.Transparent Then
            btn3.BackColor = Color.Green
        End If

        If btn13.BackColor = Color.Green Then
            btn13.BackColor = Color.Transparent
        ElseIf btn13.BackColor = Color.Transparent Then
            btn13.BackColor = Color.Green
        End If
        NextLevel()
    End Sub

    Private Sub btna9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn9.Click
        If btn10.BackColor = Color.Green Then
            btn10.BackColor = Color.Transparent
        ElseIf btn10.BackColor = Color.Transparent Then
            btn10.BackColor = Color.Green
        End If

        If btn8.BackColor = Color.Green Then
            btn8.BackColor = Color.Transparent
        ElseIf btn8.BackColor = Color.Transparent Then
            btn8.BackColor = Color.Green
        End If

        If btn9.BackColor = Color.Green Then
            btn9.BackColor = Color.Transparent
        ElseIf btn9.BackColor = Color.Transparent Then
            btn9.BackColor = Color.Green
        End If

        If btn4.BackColor = Color.Green Then
            btn4.BackColor = Color.Transparent
        ElseIf btn4.BackColor = Color.Transparent Then
            btn4.BackColor = Color.Green
        End If

        If btn14.BackColor = Color.Green Then
            btn14.BackColor = Color.Transparent
        ElseIf btn14.BackColor = Color.Transparent Then
            btn14.BackColor = Color.Green
        End If
        NextLevel()
    End Sub

    Private Sub btna10_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn10.Click

        If btn9.BackColor = Color.Green Then
            btn9.BackColor = Color.Transparent
        ElseIf btn9.BackColor = Color.Transparent Then
            btn9.BackColor = Color.Green
        End If

        If btn10.BackColor = Color.Green Then
            btn10.BackColor = Color.Transparent
        ElseIf btn10.BackColor = Color.Transparent Then
            btn10.BackColor = Color.Green
        End If

        If btn5.BackColor = Color.Green Then
            btn5.BackColor = Color.Transparent
        ElseIf btn5.BackColor = Color.Transparent Then
            btn5.BackColor = Color.Green
        End If

        If btn15.BackColor = Color.Green Then
            btn15.BackColor = Color.Transparent
        ElseIf btn15.BackColor = Color.Transparent Then
            btn15.BackColor = Color.Green
        End If
        NextLevel()
    End Sub

    Private Sub btna11_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn11.Click
        If btn6.BackColor = Color.Green Then
            btn6.BackColor = Color.Transparent
        ElseIf btn6.BackColor = Color.Transparent Then
            btn6.BackColor = Color.Green
        End If

        If btn11.BackColor = Color.Green Then
            btn11.BackColor = Color.Transparent
        ElseIf btn11.BackColor = Color.Transparent Then
            btn11.BackColor = Color.Green
        End If

        If btn12.BackColor = Color.Green Then
            btn12.BackColor = Color.Transparent
        ElseIf btn12.BackColor = Color.Transparent Then
            btn12.BackColor = Color.Green
        End If

        If btn16.BackColor = Color.Green Then
            btn16.BackColor = Color.Transparent
        ElseIf btn16.BackColor = Color.Transparent Then
            btn16.BackColor = Color.Green
        End If
        NextLevel()
    End Sub

    Private Sub btna12_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn12.Click
        If btn11.BackColor = Color.Green Then
            btn11.BackColor = Color.Transparent
        ElseIf btn11.BackColor = Color.Transparent Then
            btn11.BackColor = Color.Green
        End If

        If btn12.BackColor = Color.Green Then
            btn12.BackColor = Color.Transparent
        ElseIf btn12.BackColor = Color.Transparent Then
            btn12.BackColor = Color.Green
        End If

        If btn13.BackColor = Color.Green Then
            btn13.BackColor = Color.Transparent
        ElseIf btn13.BackColor = Color.Transparent Then
            btn13.BackColor = Color.Green
        End If

        If btn7.BackColor = Color.Green Then
            btn7.BackColor = Color.Transparent
        ElseIf btn7.BackColor = Color.Transparent Then
            btn7.BackColor = Color.Green
        End If

        If btn17.BackColor = Color.Green Then
            btn17.BackColor = Color.Transparent
        ElseIf btn17.BackColor = Color.Transparent Then
            btn17.BackColor = Color.Green
        End If
        NextLevel()
    End Sub

    Private Sub btna13_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn13.Click
        If btn12.BackColor = Color.Green Then
            btn12.BackColor = Color.Transparent
        ElseIf btn12.BackColor = Color.Transparent Then
            btn12.BackColor = Color.Green
        End If

        If btn13.BackColor = Color.Green Then
            btn13.BackColor = Color.Transparent
        ElseIf btn13.BackColor = Color.Transparent Then
            btn13.BackColor = Color.Green
        End If

        If btn14.BackColor = Color.Green Then
            btn14.BackColor = Color.Transparent
        ElseIf btn14.BackColor = Color.Transparent Then
            btn14.BackColor = Color.Green
        End If

        If btn8.BackColor = Color.Green Then
            btn8.BackColor = Color.Transparent
        ElseIf btn8.BackColor = Color.Transparent Then
            btn8.BackColor = Color.Green
        End If

        If btn18.BackColor = Color.Green Then
            btn18.BackColor = Color.Transparent
        ElseIf btn18.BackColor = Color.Transparent Then
            btn18.BackColor = Color.Green
        End If
        NextLevel()
    End Sub

    Private Sub btna14_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn14.Click
        If btn13.BackColor = Color.Green Then
            btn13.BackColor = Color.Transparent
        ElseIf btn13.BackColor = Color.Transparent Then
            btn13.BackColor = Color.Green
        End If

        If btn14.BackColor = Color.Green Then
            btn14.BackColor = Color.Transparent
        ElseIf btn14.BackColor = Color.Transparent Then
            btn14.BackColor = Color.Green
        End If

        If btn15.BackColor = Color.Green Then
            btn15.BackColor = Color.Transparent
        ElseIf btn15.BackColor = Color.Transparent Then
            btn15.BackColor = Color.Green
        End If

        If btn9.BackColor = Color.Green Then
            btn9.BackColor = Color.Transparent
        ElseIf btn9.BackColor = Color.Transparent Then
            btn9.BackColor = Color.Green
        End If

        If btn19.BackColor = Color.Green Then
            btn19.BackColor = Color.Transparent
        ElseIf btn19.BackColor = Color.Transparent Then
            btn19.BackColor = Color.Green
        End If
        NextLevel()
    End Sub

    Private Sub btna15_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn15.Click
        If btn14.BackColor = Color.Green Then
            btn14.BackColor = Color.Transparent
        ElseIf btn14.BackColor = Color.Transparent Then
            btn14.BackColor = Color.Green
        End If

        If btn15.BackColor = Color.Green Then
            btn15.BackColor = Color.Transparent
        ElseIf btn15.BackColor = Color.Transparent Then
            btn15.BackColor = Color.Green
        End If

        If btn10.BackColor = Color.Green Then
            btn10.BackColor = Color.Transparent
        ElseIf btn10.BackColor = Color.Transparent Then
            btn10.BackColor = Color.Green
        End If

        If btn20.BackColor = Color.Green Then
            btn20.BackColor = Color.Transparent
        ElseIf btn20.BackColor = Color.Transparent Then
            btn20.BackColor = Color.Green
        End If

        NextLevel()
    End Sub

    Private Sub btna16_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn16.Click
        If btn11.BackColor = Color.Green Then
            btn11.BackColor = Color.Transparent
        ElseIf btn11.BackColor = Color.Transparent Then
            btn11.BackColor = Color.Green
        End If

        If btn16.BackColor = Color.Green Then
            btn16.BackColor = Color.Transparent
        ElseIf btn16.BackColor = Color.Transparent Then
            btn16.BackColor = Color.Green
        End If

        If btn17.BackColor = Color.Green Then
            btn17.BackColor = Color.Transparent
        ElseIf btn17.BackColor = Color.Transparent Then
            btn17.BackColor = Color.Green
        End If

        If btn21.BackColor = Color.Green Then
            btn21.BackColor = Color.Transparent
        ElseIf btn21.BackColor = Color.Transparent Then
            btn21.BackColor = Color.Green
        End If

        NextLevel()

    End Sub

    Private Sub btna17_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn17.Click
        If btn16.BackColor = Color.Green Then
            btn16.BackColor = Color.Transparent
        ElseIf btn16.BackColor = Color.Transparent Then
            btn16.BackColor = Color.Green
        End If

        If btn17.BackColor = Color.Green Then
            btn17.BackColor = Color.Transparent
        ElseIf btn17.BackColor = Color.Transparent Then
            btn17.BackColor = Color.Green
        End If

        If btn18.BackColor = Color.Green Then
            btn18.BackColor = Color.Transparent
        ElseIf btn18.BackColor = Color.Transparent Then
            btn18.BackColor = Color.Green
        End If

        If btn12.BackColor = Color.Green Then
            btn12.BackColor = Color.Transparent
        ElseIf btn12.BackColor = Color.Transparent Then
            btn12.BackColor = Color.Green
        End If

        If btn22.BackColor = Color.Green Then
            btn22.BackColor = Color.Transparent
        ElseIf btn22.BackColor = Color.Transparent Then
            btn22.BackColor = Color.Green
        End If

        NextLevel()
    End Sub

    Private Sub btna18_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn18.Click
        If btn17.BackColor = Color.Green Then
            btn17.BackColor = Color.Transparent
        ElseIf btn17.BackColor = Color.Transparent Then
            btn17.BackColor = Color.Green
        End If

        If btn18.BackColor = Color.Green Then
            btn18.BackColor = Color.Transparent
        ElseIf btn18.BackColor = Color.Transparent Then
            btn18.BackColor = Color.Green
        End If

        If btn19.BackColor = Color.Green Then
            btn19.BackColor = Color.Transparent
        ElseIf btn19.BackColor = Color.Transparent Then
            btn19.BackColor = Color.Green
        End If

        If btn13.BackColor = Color.Green Then
            btn13.BackColor = Color.Transparent
        ElseIf btn13.BackColor = Color.Transparent Then
            btn13.BackColor = Color.Green
        End If

        If btn23.BackColor = Color.Green Then
            btn23.BackColor = Color.Transparent
        ElseIf btn23.BackColor = Color.Transparent Then
            btn23.BackColor = Color.Green
        End If

        NextLevel()
    End Sub

    Private Sub btna19_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn19.Click
        If btn18.BackColor = Color.Green Then
            btn18.BackColor = Color.Transparent
        ElseIf btn18.BackColor = Color.Transparent Then
            btn18.BackColor = Color.Green
        End If

        If btn19.BackColor = Color.Green Then
            btn19.BackColor = Color.Transparent
        ElseIf btn19.BackColor = Color.Transparent Then
            btn19.BackColor = Color.Green
        End If

        If btn20.BackColor = Color.Green Then
            btn20.BackColor = Color.Transparent
        ElseIf btn20.BackColor = Color.Transparent Then
            btn20.BackColor = Color.Green
        End If

        If btn14.BackColor = Color.Green Then
            btn14.BackColor = Color.Transparent
        ElseIf btn14.BackColor = Color.Transparent Then
            btn14.BackColor = Color.Green
        End If

        If btn24.BackColor = Color.Green Then
            btn24.BackColor = Color.Transparent
        ElseIf btn24.BackColor = Color.Transparent Then
            btn24.BackColor = Color.Green
        End If

        NextLevel()
    End Sub

    Private Sub btna20_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn20.Click

        If btn19.BackColor = Color.Green Then
            btn19.BackColor = Color.Transparent
        ElseIf btn19.BackColor = Color.Transparent Then
            btn19.BackColor = Color.Green
        End If

        If btn20.BackColor = Color.Green Then
            btn20.BackColor = Color.Transparent
        ElseIf btn20.BackColor = Color.Transparent Then
            btn20.BackColor = Color.Green
        End If

        If btn15.BackColor = Color.Green Then
            btn15.BackColor = Color.Transparent
        ElseIf btn15.BackColor = Color.Transparent Then
            btn15.BackColor = Color.Green
        End If

        If btn25.BackColor = Color.Green Then
            btn25.BackColor = Color.Transparent
        ElseIf btn25.BackColor = Color.Transparent Then
            btn25.BackColor = Color.Green
        End If

        NextLevel()
    End Sub

    Private Sub btna21_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn21.Click
        If btn16.BackColor = Color.Green Then
            btn16.BackColor = Color.Transparent
        ElseIf btn16.BackColor = Color.Transparent Then
            btn16.BackColor = Color.Green
        End If

        If btn21.BackColor = Color.Green Then
            btn21.BackColor = Color.Transparent
        ElseIf btn21.BackColor = Color.Transparent Then
            btn21.BackColor = Color.Green
        End If

        If btn22.BackColor = Color.Green Then
            btn22.BackColor = Color.Transparent
        ElseIf btn22.BackColor = Color.Transparent Then
            btn22.BackColor = Color.Green
        End If

        NextLevel()
    End Sub

    Private Sub btna22_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn22.Click
        If btn17.BackColor = Color.Green Then
            btn17.BackColor = Color.Transparent
        ElseIf btn17.BackColor = Color.Transparent Then
            btn17.BackColor = Color.Green
        End If

        If btn21.BackColor = Color.Green Then
            btn21.BackColor = Color.Transparent
        ElseIf btn21.BackColor = Color.Transparent Then
            btn21.BackColor = Color.Green
        End If

        If btn22.BackColor = Color.Green Then
            btn22.BackColor = Color.Transparent
        ElseIf btn22.BackColor = Color.Transparent Then
            btn22.BackColor = Color.Green
        End If

        If btn23.BackColor = Color.Green Then
            btn23.BackColor = Color.Transparent
        ElseIf btn23.BackColor = Color.Transparent Then
            btn23.BackColor = Color.Green
        End If

        NextLevel()
    End Sub

    Private Sub btna23_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn23.Click
        If btn18.BackColor = Color.Green Then
            btn18.BackColor = Color.Transparent
        ElseIf btn18.BackColor = Color.Transparent Then
            btn18.BackColor = Color.Green
        End If

        If btn22.BackColor = Color.Green Then
            btn22.BackColor = Color.Transparent
        ElseIf btn22.BackColor = Color.Transparent Then
            btn22.BackColor = Color.Green
        End If

        If btn23.BackColor = Color.Green Then
            btn23.BackColor = Color.Transparent
        ElseIf btn23.BackColor = Color.Transparent Then
            btn23.BackColor = Color.Green
        End If

        If btn24.BackColor = Color.Green Then
            btn24.BackColor = Color.Transparent
        ElseIf btn24.BackColor = Color.Transparent Then
            btn24.BackColor = Color.Green
        End If

        NextLevel()

    End Sub

    Private Sub btna24_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn24.Click
        If btn19.BackColor = Color.Green Then
            btn19.BackColor = Color.Transparent
        ElseIf btn19.BackColor = Color.Transparent Then
            btn19.BackColor = Color.Green
        End If

        If btn23.BackColor = Color.Green Then
            btn23.BackColor = Color.Transparent
        ElseIf btn23.BackColor = Color.Transparent Then
            btn23.BackColor = Color.Green
        End If

        If btn24.BackColor = Color.Green Then
            btn24.BackColor = Color.Transparent
        ElseIf btn24.BackColor = Color.Transparent Then
            btn24.BackColor = Color.Green
        End If

        If btn25.BackColor = Color.Green Then
            btn25.BackColor = Color.Transparent
        ElseIf btn25.BackColor = Color.Transparent Then
            btn25.BackColor = Color.Green

            NextLevel()
        End If
    End Sub

    Private Sub btna25_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn25.Click
        If btn20.BackColor = Color.Green Then
            btn20.BackColor = Color.Transparent
        ElseIf btn20.BackColor = Color.Transparent Then
            btn20.BackColor = Color.Green
        End If

        If btn24.BackColor = Color.Green Then
            btn24.BackColor = Color.Transparent
        ElseIf btn24.BackColor = Color.Transparent Then
            btn24.BackColor = Color.Green
        End If

        If btn25.BackColor = Color.Green Then
            btn25.BackColor = Color.Transparent
        ElseIf btn25.BackColor = Color.Transparent Then
            btn25.BackColor = Color.Green
        End If

        NextLevel()
    End Sub

    Private Sub Lv1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        LevelNumber = 1
    End Sub
End Class
