Public Class frmAudio_Books

    Private Sub btnCloseAudio_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles btnCloseAudio.Click
        Me.Close()
    End Sub

    Private Sub frmAudiobooks_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        For x = 0 To UBound(MainFormShpCart.audioBookName)

            lstAudioBooks.Items.Add(MainFormShpCart.audioBookName(x) & " " & String.Format("{0:C}", MainFormShpCart.audioBookPrice(x)))
        Next x
    End Sub

    Private Sub btnAddAudioBook_Click(sender As Object, e As EventArgs) Handles btnAddAudioBook.Click
        MainFormShpCart.lstProducts.Items.Add("A" & lstAudioBooks.SelectedIndex & ": " & lstAudioBooks.SelectedItem.ToString)
        MainFormShpCart.DisplayCharges()
    End Sub

End Class



