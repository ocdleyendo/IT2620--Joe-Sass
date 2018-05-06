Public Class MainFormShpCart
    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter
    End Sub
    Private Sub PrintBooksToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles mnuPrintBooks.Click

    End Sub

    'Public Sub MainFormShpCart_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    ' Public Class frmShoppingCart

    'Sales tax on total cost
    Public Const decSALES_TAX As Decimal = 0.06D

    'Shipping Cost on each item
    Public Const decSHIPPING_CHARGE As Decimal = 2
    Public printBookPrice() As Decimal = {11.95D, 14.5D, 29.95D, 18.5D}
    Public printBookName() As String = {"I Did It your Way", "The History of Scotland", "Learn Calculus in One Day", "Feel the Stress"}
    Public audioBookPrice() As Decimal = {29.95D, 14.5D, 12.95D, 11.5D}
    Public audioBookName() As String = {"Learn Calculus in One Day", "The History of Scotland", "The Science of Body Language", "Relaxation Techniques"}

    Private Sub mnuReset_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuReset.Click
        'Reset the form.
        lblSubtotal.Text = String.Empty
        lblTax.Text = String.Empty
        lblShipping.Text = String.Empty
        lblTotal.Text = String.Empty
        lstProducts.Items.Clear()

    End Sub

    Private Sub mnuPrint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuPrintBooks.Click
        frmPrintbooks.Show()
    End Sub

    Private Sub mnuAudio_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuAudioBooks.Click
        frmAudio_Books.Show()
    End Sub



    Public Sub DisplayCharges()

        'This procedure calculates the tax, shipping charge and total cart purchase.
        Dim BookTotal As Decimal = 0

        For Each Book As String In lstProducts.Items
            If Book.StartsWith("A") Then
                BookTotal += audioBookPrice(CInt(Book.Substring(1, 1)))
            Else ' must be a print book

                BookTotal += printBookPrice(CInt(Book.Substring(1, 1)))
            End If
        Next

        Dim BookCount As Integer = lstProducts.Items.Count

        'Display the Data.
        lblSubtotal.Text = BookTotal.ToString("c")
        lblTax.Text = (BookTotal * decSALES_TAX).ToString("c")
        BookTotal += BookTotal * decSALES_TAX
        lblShipping.Text = (BookCount * decSHIPPING_CHARGE).ToString("c")
        BookTotal += BookCount * decSHIPPING_CHARGE
        lblTotal.Text = BookTotal.ToString("c")



        End Sub

    Private Sub mnuExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuExit.Click
        'End the application

        Me.Close()

    End Sub


    'Private Sub mnuAbout_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuAbout.Click
    Private Sub mnuHelpAbout_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuHelpAbout.Click
        'Displays an about box.
        MessageBox.Show("The Shopping Cart allows you to select and purchase both Print and Audio Books.", "Shopping Cart About")
    End Sub

    Private Sub btnRemove_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRemoveItems.Click
        'Remove Items from List Box
        If lstProducts.SelectedIndex <> -1 Then
            lstProducts.Items.RemoveAt(lstProducts.SelectedIndex)
        End If
        DisplayCharges()
    End Sub
End Class

