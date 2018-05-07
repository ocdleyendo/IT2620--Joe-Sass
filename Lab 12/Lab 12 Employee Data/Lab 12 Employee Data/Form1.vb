

'Private strEmployeeDataFile As String = String.Empty


'Dim stream As New System.IO.FileStream("C:\CONFIG\PA.txt", IO.FileMode.Append, IO.FileAccess.Write)

'Write code in the Form_Load event handler that allows the user to enter the name of the file. 
'if a file doesn't exist, a new one will be created. 
Imports System.IO

Public Class frmEmployeeDataPart1
        ' Declare global variables
        Dim fileName As String
        Dim firstName As String
        Dim middleName As String
        Dim lastName As String
        Dim employeeNumber As Integer
        Dim department As String
        Dim telephone As String
        Dim extension As Integer
        Dim emailAddress As String
        Dim valid As Boolean = True

        Private Sub frmEmployeeDataPart1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
            Do
                fileName = InputBox("Input Needed", "Enter the name of the file.")
                If fileName = Nothing Or fileName = "" Then
                    MessageBox.Show("No file name entered.")
                Else
                    Exit Do
                End If
            Loop
        End Sub

        Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
            valid = True ' reset value to account for prior invalid input
            InputData()
            If valid = True Then
                WriteDataToFile()
            Else
                InputData()
            End If
        End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClearData.Click
        txtFirstName.Text = ""
        txtMiddleName.Text = ""
        txtLastName.Text = ""
        txtEmployeeNumber.Text = ""
        cboDepartment.SelectedIndex = -1
        txtTelephone.Text = ""
        txtExtension.Text = ""
        txtEmailAddress.Text = ""
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
            ' Ends the program when the user clicks on the Exit button
            End
        End Sub

        Sub InputData()
            ' populate the variables
            firstName = txtFirstName.Text
            If (firstName.ToUpper >= "A") And (firstName.ToUpper <= "Z") Then
                firstName = firstName
            Else
                valid = False
                MessageBox.Show("First Name must start with a letter")
            End If
            middleName = txtMiddleName.Text
            If (middleName.ToUpper >= "A") And (middleName.ToUpper <= "Z") Then
                middleName = middleName
            Else
                valid = False
                MessageBox.Show("Middle Name must start with a letter")
            End If
            lastName = txtLastName.Text
            If (lastName.ToUpper >= "A") And (lastName.ToUpper <= "Z") Then
                lastName = lastName
            Else
                valid = False
                MessageBox.Show("Last Name must start with a letter")
            End If
            Try
                employeeNumber = CInt(txtEmployeeNumber.Text)
            Catch
                MessageBox.Show("You must enter an integer for Employee Number.")
                valid = False
            End Try
            If cboDepartment.SelectedIndex <> -1 Then
                department = cboDepartment.Text
            Else
                valid = False
                MessageBox.Show("You must select a department.")
            End If
            telephone = txtTelephone.Text
            Try
                extension = CInt(txtExtension.Text)
            Catch
                MessageBox.Show("You must enter an integer for Extension.")
                valid = False
            End Try
        emailAddress = txtEmailAddress.Text
    End Sub

        Sub WriteDataToFile()
        ' write the data to the file
        Dim OutputFile As System.IO.StreamWriter
        OutputFile = File.CreateText(fileName)
        'Dim sw As System.IO.StreamWriter = file.AppendText(fileName)
        OutputFile.WriteLine(firstName)
        OutputFile.WriteLine(middleName)
        OutputFile.WriteLine(lastName)
        OutputFile.WriteLine(employeeNumber)
        OutputFile.WriteLine(department)
        OutputFile.WriteLine(telephone)
        OutputFile.WriteLine(extension)
        OutputFile.WriteLine(emailAddress)
        OutputFile.Close()
        MessageBox.Show("Record Saved.  Please clear the form and enter additional records or exit.")
        End Sub
    End Class




'Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

'End Sub