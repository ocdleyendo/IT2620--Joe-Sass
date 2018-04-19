Public Class Form1
    Dim intCount As Integer = 1
    Dim strUserInput As String
    Dim decInput As Decimal
    Dim decTotal As Decimal

    Private Sub btnEnterNumbers_Click(sender As Object, e As EventArgs) Handles btnEnterNumbers.Click

        strUserInput = InputBox("Enter a positive integer value", "Input Needed", 10)

        If Decimal.TryParse(strUserInput, decInput) Then
            If decInput > 0 Then

                For intCount = 1 To decInput
                    'Sum the Values
                    decTotal += intCount

                    'Add 1 to the loop counter
                    'intCount += 1
                Next
                MessageBox.Show("The sum of numbers 1 through " & strUserInput.ToString & " is " & decTotal.ToString())
            Else
                'Display an error message for invalid input.
                MessageBox.Show("Enter a positive value.")
            End If
        End If
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
