Public Class frmThankYou
    Private Sub frmThankYou_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If frmQuestions.QuestionNo <= 5 Then
            lblYesOrNo.Text = "Unlucky! Sorry you were not able to omplete all of the questions."
            lblQuestionsCompleted.Text = "You completed " & frmQuestions.QuestionNo & " out of 6 questions"
            lblTotalScore.Text = "You scored a total of " & frmQuestions.lblTotalScore.Text & " points!"
        ElseIf frmQuestions.QuestionNo = 6 Then
            lblYesOrNo.Text = "Congratulations! You were able to complete all of the questions."
            lblQuestionsCompleted.Text = "You completed " & frmQuestions.QuestionNo & " out of 6 questions"
            lblTotalScore.Text = "You scored a total of " & frmQuestions.lblTotalScore.Text & " points!"
        End If
    End Sub

    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        Application.Exit()
    End Sub
End Class