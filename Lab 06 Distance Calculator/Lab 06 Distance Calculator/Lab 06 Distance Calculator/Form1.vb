Public Class Form1
    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click
        Dim strSpeed As String
        Dim strHours As String
        Dim intSpeed As Integer
        Dim intHours As Integer
        Dim dblDistanceRunning As Double  ' to hold the running distance
        Dim intTotalDistance As Integer = 0
        Dim intCount As Integer = 0

        strSpeed = InputBox("Please enter the vehicle speed in mph", "Vehicle Speed")
        strHours = InputBox("Please enter the amount of time, in hours, that the vehicle has traveled", "Time Traveled")

        'Try
        '    intHours = CInt(InputBox("Enter the time traveled, in Hours.", "Input Needed"))
        '    If Not IsNumeric(intHours) Or intHours < 1 Then
        '        MessageBox.Show("Please enter a positive integer value for the hour traveled")
        '    Else
        '        Return
        '    End If
        'Catch
        '    MessageBox.Show("Please enter a positive value for the hour traveled")
        '    Return
        'End Try

        'Try
        '    intSpeed = CInt(InputBox("Enter the vehicle's speed, in MPH.", "Input Needed"))
        '    If Not IsNumeric(intSpeed) Or intSpeed < 1 Then
        '        MessageBox.Show("Please enter a positive integer value for the vehicle speed")
        '    Else
        '        Return
        '    End If
        'Catch
        '    MessageBox.Show("Please enter a positive value for the vehicle speed")
        '    Return
        'End Try

        If Integer.TryParse(strSpeed, intSpeed) Then
            If Integer.TryParse(strHours, intHours) Then
                If intHours < 1 Then
                    MessageBox.Show("Please enter a postive number for the hours traveled.")
                End If
                If intSpeed < 1 Then
                    MessageBox.Show("Please enter a positive value for the Vehicle Speed")
                End If

                lstDistance.Items.Add("Vehicle Speed: " & intSpeed.ToString & " MPH")
                lstDistance.Items.Add("Time Traveled: " & intHours.ToString & " hours")
                lstDistance.Items.Add("Hours" + "        " & "Distance Traveled")
                lstDistance.Items.Add("_______________________________________")


                For intCount = 1 To intHours

                    dblDistanceRunning = Distance(intSpeed, intCount)

                    intTotalDistance = 0.0 'reset the total to 0
                    intTotalDistance += dblDistanceRunning
                    lstDistance.Items.Add(intCount.ToString & " -> " & dblDistanceRunning.ToString)
                Next
                lstDistance.Items.Add("Total Distance: " & intTotalDistance.ToString)

                'Else
                '    MessageBox.Show("Please Enter a positive value for the hours traveled")
            End If
            'Else
            '    MessageBox.Show("Please enter a positive value for the vehicle speed")
        End If

    End Sub


    Private Function Distance(ByVal intSpeed As Integer, ByVal intCount As Integer) As Double
        'Distance = CDbl(intSpeed * intCount)
        Return CDbl(intSpeed * intCount)
    End Function

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()

    End Sub

End Class


