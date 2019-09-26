Public Class frmQuestions
    'Declare Public variables
    Public TotalScore As Integer
    Public QuestionNo As Integer
    'Declare Private variables
    Dim TimeCount As Integer = 1000
    Private Sub Form1_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        QuestionNo = 1

        Questions()
    End Sub
    Private CountDownStart
    Private Sub Questions()
        Dim strQuestion1 As String = "What colour is the missing colour from this image?"
        Dim strQuestion2 As String = "If I mix myself with blue to get purple, what colour am I?"
        Dim strQuestion3 As String = "What type of animal is a Black Widow?"
        Dim strQuestion4 As String = "What colour is a Green House?"
        Dim strQuestion5 As String = "My colour is usually associated with anger or passion. What colour am I?"
        Dim strQuestion6 As String = "Look at the image above. What colour is the sea?"
        Dim imgQuestion1 As Image = Image.FromFile("ColorWheel.jpg")
        Dim imgQuestion2 As Image = Image.FromFile("Blue-Purple.jpg")
        Dim imgQuestion3 As Image = Image.FromFile("Black-Cat.jpg")
        Dim imgQuestion4 As Image = Image.FromFile("GreenHouse.jpg")
        Dim imgQuestion5 As Image = Image.FromFile("Anger.jpg")
        Dim imgQuestion6 As Image = Image.FromFile("Beach.jpg")

        If QuestionNo = 1 Then
            lblQuestionNo.Text = QuestionNo
            lblQuestion.Text = strQuestion1
            pbxQuestionImage.Image = imgQuestion1
            btnAnswer1.Text = "Blue"
            btnAnswer2.Text = "Green" '
            btnAnswer3.Text = "Red"
            btnAnswer4.Text = "Orange"
            QuestionTimerStart()
            pgrQuestion.Size = New Size(60, 30)

        ElseIf QuestionNo = 2 Then
            lblQuestionNo.Text = QuestionNo
            lblQuestion.Text = strQuestion2
            pbxQuestionImage.Image = imgQuestion2
            btnAnswer1.Text = "Orange"
            btnAnswer2.Text = "Green"
            btnAnswer3.Text = "Red" '
            btnAnswer4.Text = "Yellow"
            QuestionTimerStart()
            pgrQuestion.Size = New Size(120, 30)

        ElseIf QuestionNo = 3 Then
            lblQuestionNo.Text = QuestionNo
            lblQuestion.Text = strQuestion3
            pbxQuestionImage.Image = imgQuestion3
            btnAnswer1.Text = "Snake"
            btnAnswer2.Text = "Beatle"
            btnAnswer3.Text = "Cat"
            btnAnswer4.Text = "Spider"
            QuestionTimerStart()
            pgrQuestion.Size = New Size(180, 30)

        ElseIf QuestionNo = 4 Then
            lblQuestionNo.Text = QuestionNo
            lblQuestion.Text = strQuestion4
            pbxQuestionImage.Image = imgQuestion4
            btnAnswer1.Text = "Green"
            btnAnswer2.Text = "Clear"
            btnAnswer3.Text = "Brown"
            btnAnswer4.Text = "Grey"
            QuestionTimerStart()
            pgrQuestion.Size = New Size(240, 30)

        ElseIf QuestionNo = 5 Then
            lblQuestionNo.Text = QuestionNo
            lblQuestion.Text = strQuestion5
            pbxQuestionImage.Image = imgQuestion5
            btnAnswer1.Text = "Green"
            btnAnswer2.Text = "Purple"
            btnAnswer3.Text = "Orange"
            btnAnswer4.Text = "Red"
            QuestionTimerStart()
            pgrQuestion.Size = New Size(300, 30)

        ElseIf QuestionNo = 6 Then
            lblQuestionNo.Text = QuestionNo
            lblQuestion.Text = strQuestion6
            pbxQuestionImage.Image = imgQuestion6
            btnAnswer1.Text = "Blue"
            btnAnswer2.Text = "Brown"
            btnAnswer3.Text = "Clear"
            btnAnswer4.Text = "Green"
            QuestionTimerStart()
            pgrQuestion.Size = New Size(360, 30)
        End If

    End Sub

    Private Sub QuestionTimerStop()
        Timer1.Enabled = False
    End Sub
    Public Sub QuestionTimerStart()
        TimeCount = 1000
        Timer1.Enabled = True
        Timer1.Interval = 1
        Timer1.Start()
    End Sub

    Private Sub WrongAnswer()
        Dim Retry As MsgBoxResult = MsgBox("Sorry, you answered incorrectly. Would you like to try again?", MsgBoxStyle.YesNo)
        Select Case Retry
            Case MsgBoxResult.Yes
                Questions()
            Case MsgBoxResult.No
                frmThankYou.Show()
                Me.Hide()
        End Select
    End Sub
    Private Sub RightAnswer()
        lblTotalScore.Text = lblTotalScore.Text + TimeCount
        If QuestionNo <= 5 Then
            MsgBox("Well done, you were correct! Please continue to the next question")
            QuestionNo = QuestionNo + 1
            Questions()
        ElseIf QuestionNo = 6 Then
            frmThankYou.Show()
            Me.Hide()
        End If

    End Sub
    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        Dim TimeRemain As Integer
        TimeRemain = TimeCount / 10
        pgrTimeRemaining.Size = New Size(TimeRemain, 30)
        TimeCount = TimeCount - 1
    End Sub

    Private Sub btn1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAnswer1.Click
        QuestionTimerStop()
        If QuestionNo = 1 Then
            WrongAnswer()
        ElseIf QuestionNo = 2 Then
            WrongAnswer()
        ElseIf QuestionNo = 3 Then
            WrongAnswer()
        ElseIf QuestionNo = 4 Then
            RightAnswer()
        ElseIf QuestionNo = 5 Then
            WrongAnswer()
        ElseIf QuestionNo = 6 Then
            WrongAnswer()
        End If
    End Sub

    Private Sub btnAnswer2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAnswer2.Click
        QuestionTimerStop()
        If QuestionNo = 1 Then
            RightAnswer()
        ElseIf QuestionNo = 2 Then
            WrongAnswer()
        ElseIf QuestionNo = 3 Then
            WrongAnswer()
        ElseIf QuestionNo = 4 Then
            WrongAnswer()
        ElseIf QuestionNo = 5 Then
            WrongAnswer()
        ElseIf QuestionNo = 6 Then
            WrongAnswer()
        End If
    End Sub

    Private Sub btnAnswer3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAnswer3.Click
        QuestionTimerStop()
        If QuestionNo = 1 Then
            WrongAnswer()
        ElseIf QuestionNo = 2 Then
            RightAnswer()
        ElseIf QuestionNo = 3 Then
            WrongAnswer()
        ElseIf QuestionNo = 4 Then
            WrongAnswer()
        ElseIf QuestionNo = 5 Then
            WrongAnswer()
        ElseIf QuestionNo = 6 Then
            RightAnswer()
        End If
    End Sub

    Private Sub btnAnswer4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAnswer4.Click
        QuestionTimerStop()
        If QuestionNo = 1 Then
            WrongAnswer()
        ElseIf QuestionNo = 2 Then
            WrongAnswer()
        ElseIf QuestionNo = 3 Then
            RightAnswer()
        ElseIf QuestionNo = 4 Then
            WrongAnswer()
        ElseIf QuestionNo = 5 Then
            RightAnswer()
        ElseIf QuestionNo = 6 Then
            WrongAnswer()
        End If
    End Sub

    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        Dim Quit As MsgBoxResult = MsgBox("Are you sure you wish to exit and quit the game?", MsgBoxStyle.YesNo)
        Select Case Quit
            Case MsgBoxResult.Yes
                Application.Exit()
            Case MsgBoxResult.No
                Questions()
        End Select
    End Sub
End Class
