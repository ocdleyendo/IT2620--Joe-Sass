



Module ShoppingCartModule

    'Sales tax on total cost
    Const decSALES_TAX As Decimal = 0.06D
    'Shipping Cost on each item
    Const decSHIPPING_CHARGE As Decimal = 2

    Public printBookPrice() As Decimal = {11.95D, 14.5D, 29.95D, 18.5D}
    Public printBookName() As String = {"I Did It your Way", "The History of Scotland", "Learn Calculus in One Day", "Feel the Stress"}
    Public audioBookPrice() As Decimal = {29.95D, 14.5D, 12.95D, 11.5D}
    Public audioBookName() As String = {"Learn Calculus in One Day", "The History of Scotland", "The Science of Body Language", "Relaxation Techniques"}

    'Declare global variables
    'Public g_lstProducts As String       'List of Items in cart
    Public g_decSubtotal As Decimal      'Subtotal of charges
    Public g_decTotal As Decimal            'Total Charges
    Public g_Shipping As Decimal            'Total Shipping
    Public g_Tax As Decimal              'Tax Percentage



    Public Function CalcSubtotal(ByVal decSubtotal As Decimal) As Decimal

        'ByVal decCart_Subtotal As Decimal

        decSubtotal = decSubtotal
        Return decSubtotal
    End Function



    Public Function CalcTax(ByVal decSubtotal As Decimal) As Decimal
        'ByVal decTax As Decimal
        Return decSubtotal * decSALES_TAX

    End Function

    Public Function CalcShipping(ByVal intShipping As Decimal, ByVal intShipping_Charge As Decimal) As Decimal

        Dim intCount As Integer
        For x = 0 To intCount - 1

            intShipping = MainFormShpCart.lstProducts.SelectedIndex * decSHIPPING_CHARGE
            'lstPrintbooks.Items.Add(printBookName(x))
        Next x
        'intShipping = lstProducts * decSHIPPING_CHARGE
        Return intShipping
    End Function

    Dim decTax As Decimal



    Public Function CalcTotal(ByVal decCart_Charges As Decimal) As Decimal

        Return g_decTotal + g_Tax + g_Shipping

    End Function
End Module



