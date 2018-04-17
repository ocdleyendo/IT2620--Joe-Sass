Public Class Form1
    Dim intNum As Integer
    Const intMAX_ROW As Integer = 2
    Const intMAX_COL As Integer = 2
    Dim dblTicTacToe(intMAX_ROW, intMAX_COL) As Double

    Private Sub btnNewGame_Click(sender As Object, e As EventArgs) Handles btnNewGame.Click

        Dim rnd As New Random
        Dim intRow, intCol As Integer

        For intRow = 0 To intMAX_ROW
            For intCol = 0 To intMAX_COL
                dblTicTacToe(intRow, intCol) = rnd.Next(2)
            Next
        Next

        If dblTicTacToe(0, 0) = 0 Then
            lblFirst.Text = "O"
        Else
            lblFirst.Text = "X"
        End If
        '2nd label: 
        If dblTicTacToe(0, 1) = 0 Then
            lblSecond.Text = "O"
        Else
            lblSecond.Text = "X"
        End If
        '3rd
        If dblTicTacToe(0, 2) = 0 Then
            lblThird.Text = "O"
        Else
            lblThird.Text = "X"
        End If
        '4th
        If dblTicTacToe(1, 0) = 0 Then
            lblFourth.Text = "O"
        Else
            lblFourth.Text = "X"
        End If
        '5th
        If dblTicTacToe(1, 1) = 0 Then
            lblFifth.Text = "O"
        Else
            lblFifth.Text = "X"
        End If
        '6th
        If dblTicTacToe(1, 2) = 0 Then
            lblSixth.Text = "O"
        Else
            lblSixth.Text = "X"
        End If
        '7th
        If dblTicTacToe(2, 0) = 0 Then
            lblSeventh.Text = "O"
        Else
            lblSeventh.Text = "X"
        End If
        '8th
        If dblTicTacToe(2, 1) = 0 Then
            lblEighth.Text = "O"
        Else
            lblEighth.Text = "X"
        End If
        '9th
        If dblTicTacToe(2, 2) = 0 Then
            lblNinth.Text = "O"
        Else
            lblNinth.Text = "X"
        End If


        If (lblFirst.Text = "O" And lblSecond.Text = "O" _
                And lblThird.Text = "O") _
                Or (lblFourth.Text = "O" And lblFifth.Text = "O" _
                And lblSixth.Text = "O") _
                Or (lblSeventh.Text = "O" And lblEighth.Text = "O" _
                And lblNinth.Text = "O") _
                Or (lblFirst.Text = "O" And lblFourth.Text = "O" _
                And lblSeventh.Text = "O") _
                Or (lblSecond.Text = "O" And lblFifth.Text = "O" _
                And lblEighth.Text = "O") _
                Or (lblThird.Text = "O" And lblSixth.Text = "O" _
                And lblNinth.Text = "O") _
                Or (lblFirst.Text = "O" And lblFifth.Text = "O" _
                And lblNinth.Text = "O") _
                Or (lblSeventh.Text = "O" And lblFifth.Text = "O" _
                And lblThird.Text = "O") Then

            lblWinner.Text = "You Lose"

        ElseIf (lblFirst.Text = "X" And lblSecond.Text = "X" _
                And lblThird.Text = "X") _
                Or (lblFourth.Text = "X" And lblFifth.Text = "X" _
                And lblSixth.Text = "X") _
                Or (lblSeventh.Text = "X" And lblEighth.Text = "X" _
                And lblNinth.Text = "X") _
                Or (lblFirst.Text = "X" And lblFourth.Text = "X" _
                And lblSeventh.Text = "X") _
                Or (lblSecond.Text = "X" And lblFifth.Text = "X" _
                And lblEighth.Text = "X") _
                Or (lblThird.Text = "X" And lblSixth.Text = "X" _
                And lblNinth.Text = "X") _
                Or (lblFirst.Text = "X" And lblFifth.Text = "X" _
                And lblNinth.Text = "X") _
                Or (lblSeventh.Text = "X" And lblFifth.Text = "X" _
                And lblThird.Text = "X") Then

            lblWinner.Text = "You Win"

        ElseIf Not lblWinner.Text = "You Win" Or Not lblWinner.Text = "You Lose" Then
            lblWinner.Text = "Tie Game"
        End If

    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        lblFirst.Text = String.Empty
        lblSecond.Text = String.Empty
        lblThird.Text = String.Empty
        lblFourth.Text = String.Empty
        lblFifth.Text = String.Empty
        lblSixth.Text = String.Empty
        lblSeventh.Text = String.Empty
        lblEighth.Text = String.Empty
        lblNinth.Text = String.Empty
        lblWinner.Text = String.Empty
    End Sub



    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub
End Class

