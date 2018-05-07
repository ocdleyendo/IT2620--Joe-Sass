Imports System.IO

Public Class frmEmployeeDataPart2

    ' Declare global variables
    Dim recordNumber As Integer = 1
    Dim filename As String
    Dim sr As StreamReader
    Dim message As String
    Dim fileValid As Boolean = False

    Private Sub frmEmployeeDataPart2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Ask the user for the name of the text file and opens the file
        ' Checks user input to make sure that the file name is valid 
        Do
            filename = InputBox("Input Needed", "Enter the name of the file.")
            If File.Exists(filename) Then
                sr = File.OpenText(filename)
                fileValid = True
            Else
                message = "Either no file has yet been created or the file "
                message &= "is not where expected."
                MessageBox.Show(message, "File Not Found")
                fileValid = False
            End If
        Loop Until fileValid = True
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        ' clears all of the fields when the Clear button is pressed
        lblRecordNumber.Text = ""
        lblFirstName.Text = ""
        lblMiddleName.Text = ""
        lblLastName.Text = ""
        lblEmployeeNumber.Text = ""
        lblDepartment.Text = ""
        lblTelephone.Text = ""
        lblExtension.Text = ""
        lblEmailAddress.Text = ""
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        ' Ends the program when the Exit button is pressed.
        End
    End Sub

    Private Sub btnNext_Click(sender As Object, e As EventArgs) Handles btnNext.Click
        If sr.EndOfStream = True Then
            MessageBox.Show("End of file")
        Else
            lblRecordNumber.Text = CStr(recordNumber)
            lblFirstName.Text = sr.ReadLine
            lblMiddleName.Text = sr.ReadLine
            lblLastName.Text = sr.ReadLine
            lblEmployeeNumber.Text = sr.ReadLine
            lblDepartment.Text = sr.ReadLine
            lblTelephone.Text = sr.ReadLine
            lblExtension.Text = sr.ReadLine
            lblEmailAddress.Text = sr.ReadLine
            recordNumber += 1
        End If
    End Sub

    Private Sub btnNext_Click_1(sender As Object, e As EventArgs) Handles btnNext.Click

    End Sub
End Class
