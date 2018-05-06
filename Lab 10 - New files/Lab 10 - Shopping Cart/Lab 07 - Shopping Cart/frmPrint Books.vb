Public Class frmPrintBooks

    Private Sub btnClosePrint_Click(sender As Object, e As EventArgs) Handles btnClosePrint.Click
        Me.Close()

    End Sub

    Public Sub btnAddPrintBook_Click(sender As System.Object, ByVal e As System.EventArgs) Handles btnAddPrintBook.Click
        'Private Sub btnAddprint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAddprint.Click

        MainFormShpCart.lstProducts.Items.Add("P" & lstPrintBooks.SelectedIndex & ": " & lstPrintBooks.SelectedItem.ToString)
        MainFormShpCart.DisplayCharges()
    End Sub

    Private Sub frmPrintbooks_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

            For x = 0 To UBound(MainFormShpCart.printBookName)
                lstPrintBooks.Items.Add(MainFormShpCart.printBookName(x) & " " & String.Format("{0:C}", MainFormShpCart.printBookPrice(x)))

            Next x
        End Sub

    End Class




