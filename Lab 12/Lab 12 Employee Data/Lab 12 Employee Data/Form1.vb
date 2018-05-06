Public Class Form1

    Private strEmployeeDataFile As String = String.Empty


    'Dim stream As New System.IO.FileStream("C:\CONFIG\PA.txt", IO.FileMode.Append, IO.FileAccess.Write)

    'Write code in the Form_Load event handler that allows the user to enter the name of the file. 
    'if a file doesn't exist, a new one will be created. 

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Dim strEmployeeData As String       'File name
        Dim file As System.IO.StreamWriter

        file = My.Computer.FileSystem.OpenTextFileWriter("C:\JSass - Class Files\IT2620--Joe-Sass\Lab 12\strEmployeeData.txt", True)
        file.WriteLine(txtFirstName.Text)
        file.WriteLine(txtMiddleName.Text)
        file.WriteLine(txtLastName.Text)
        file.WriteLine(txtEmployeeNumber.Text)
        If Not cmboboxDepartment.SelectedItem Is Nothing Then
            file.WriteLine("C:\JSass - Class Files\IT2620--Joe-Sass\Lab 12\strEmployeeData.txt", cmboboxDepartment.Text)
        End If
        file.WriteLine(txtTelephone.Text)
        file.WriteLine(txtExtension.Text)
        file.WriteLine(txtEmailAddress.Text)
        file.Close()


    End Sub

    Private Sub btnClearData_Click(sender As Object, e As EventArgs) Handles btnClearData.Click
        'Clear the textboxes
        txtFirstName.Text = String.Empty
        txtMiddleName.Text = String.Empty
        txtLastName.Text = String.Empty
        txtEmployeeNumber.Text = String.Empty
        'cmboboxDepartment.Select = None()
        txtTelephone.Text = String.Empty
        txtExtension.Text = String.Empty
        txtEmailAddress.Text = String.Empty
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
