'Project Name		Rock Paper Scissors Project
'Project Purpose	This project simulates the game rock, paper, scissors
'Created/Revised By	Martin Weston   October 2008

Option Explicit On
Option Strict On

Public Class Form1
    Dim ScorePlayer As Integer = 0
    Dim ScoreComputer As Integer = 0
    Dim Point As Integer = 1




    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub pbxRock_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pbxRock.Click
        'Displays the appropriate message when the player selects this choice
        Dim randomGenerator As New Random
        Dim computerChoice As Integer
        'display the image corresponding to the players choice
        pbxPlayer.Image = pbxRock.Image
        'Generate a random number form 1 to 3
        'Then use the random number to display the image
        'Corresponding to the computers choice
        computerChoice = randomGenerator.Next(1, 4)
        Select Case computerChoice
            Case 1
                pbxComputer.Image = pbxRock.Image
                lblWinner.Text = "Tie"
            Case 2
                pbxComputer.Image = pbxPaper.Image
                lblWinner.Text = "Computer wins because Paper covers Rock"
                ScoreComputer = ScoreComputer + 1
            Case 3
                pbxComputer.Image = pbxScissors.Image
                lblWinner.Text = "Player wins because Rock breaks Scissors"
                ScorePlayer = ScorePlayer + 1
        End Select
        lblScoreComputer.Text = ScoreComputer.ToString
        lblScorePlayer.Text = ScorePlayer.ToString
    End Sub

    Private Sub pbxPaper_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pbxPaper.Click
        'Displays the appropriate message when the player selects this choice
        Dim randomGenerator As New Random
        Dim computerChoice As Integer
        'display the image corresponding to the players choice
        pbxPlayer.Image = pbxPaper.Image
        'Generate a random number form 1 to 3
        'Then use the random number to display the image
        'Corresponding to the computers choice
        computerChoice = randomGenerator.Next(1, 4)
        Select Case computerChoice
            Case 1
                pbxComputer.Image = pbxPaper.Image
                lblWinner.Text = "Tie"
            Case 2
                pbxComputer.Image = pbxScissors.Image
                lblWinner.Text = "Computer wins because Scissors cut Paper"
                ScoreComputer = ScoreComputer + 1
            Case 3
                pbxComputer.Image = pbxRock.Image
                lblWinner.Text = "Player wins because Paper covers Rock"
                ScorePlayer = ScorePlayer + 1
        End Select
        lblScoreComputer.Text = ScoreComputer.ToString
        lblScorePlayer.Text = ScorePlayer.ToString
    End Sub

    Private Sub pbxScissors_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pbxScissors.Click
        'Displays the appropriate message when the player selects this choice
        Dim randomGenerator As New Random
        Dim computerChoice As Integer
        'display the image corresponding to the players choice
        pbxPlayer.Image = pbxScissors.Image
        'Generate a random number form 1 to 3
        'Then use the random number to display the image
        'Corresponding to the computers choice
        computerChoice = randomGenerator.Next(1, 4)
        Select Case computerChoice
            Case 1
                pbxComputer.Image = pbxScissors.Image
                lblWinner.Text = "Tie"
            Case 2
                pbxComputer.Image = pbxPaper.Image
                lblWinner.Text = "Player wins because Scissors cut Paper"
                ScorePlayer = ScorePlayer + 1
            Case 3
                pbxComputer.Image = pbxRock.Image
                lblWinner.Text = "Computer wins because Rock breaks Scissors"
                ScoreComputer = ScoreComputer + 1
        End Select
        lblScoreComputer.Text = ScoreComputer.ToString
        lblScorePlayer.Text = ScorePlayer.ToString

    End Sub

End Class
