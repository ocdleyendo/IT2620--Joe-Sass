Public Class Form1
    Dim intNum As Integer
    Dim rnd As New Random()

    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click
        Dim intCount As Integer
        Dim OutputString As String = ""
        Dim intArrayLength As Integer = rnd.Next(5, 10)
        Dim intMedianSeries(intArrayLength) As Integer

        For intCount = 0 To intMedianSeries.Length - 1
            intMedianSeries(intCount) = rnd.Next(1, 100)
        Next

        Array.Sort(intMedianSeries)

        For intCount = 0 To intMedianSeries.Length - 1
            If intCount = 0 Then
                OutputString = intMedianSeries(intCount).ToString
            Else
                OutputString = OutputString & ", " & intMedianSeries(intCount).ToString
            End If
        Next
        lblArray.Text = OutputString
        FindMedian(intMedianSeries)
    End Sub

    Function FindMedian(ByVal intMedianSeries() As Integer)

        If intMedianSeries.Length Mod 2 <> 0 Then 'uneven amount of numbers
            lblMedian.Text = (intMedianSeries(intMedianSeries.GetUpperBound(0) \ 2).ToString)
        Else 'even amount of numbers
            Dim Middle As Integer = (intMedianSeries.Length \ 2)
            Dim num1 As Integer = intMedianSeries(Middle)
            Dim num2 As Integer = intMedianSeries(Middle - 1)
            Dim median As Integer = (num1 + num2) \ 2
            lblMedian.Text = median.ToString
        End If
        Return ""
    End Function

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        lblArray.Text = String.Empty
        lblMedian.Text = String.Empty
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
