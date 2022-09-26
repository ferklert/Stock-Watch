Public Class Form1

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Stock_TextChanged(sender As Object, e As EventArgs) Handles lstStocks2.TextChanged
        lstStocks2.ForeColor = Color.DarkGoldenrod





    End Sub

    Private Sub Profitability_Click(sender As Object, e As EventArgs) Handles Profitability.Click
        lstNameOfStock.Items.Add("FORD")
        lstNameOfStock.Items.Clear()

        Dim A As Integer
        lstStocks2.ForeColor = Color.DarkGoldenrod

        lstOgPrice.Items.Add("Original Stock Price:")
        lstOgPrice.Items.Clear()
        lstPrice.Items.Add("$16.08")
        lstPrice.Items.Clear()
        lstCurrentStock.Items.Add("Current Stock Price:")
        lstCurrentStock.Items.Clear()
        lstCurrentPrice.Items.Add("$11.98")
        lstCurrentPrice.Items.Clear()
        lstNumberOfShares.Items.Add("Number of Shares:")
        lstNumberOfShares.Items.Clear()
        lstNumberShare.Items.Add("1")
        lstNumberShare.Items.Clear()
        lstNET.Items.Add("Loss:")
        lstNET.Items.Clear()
        lstNetLoss.Items.Add("-$4.10")
        lstNetLoss.Items.Clear()
        lstNetLoss.ForeColor = Color.Red

        ''' <summary>
        ''' ''' Ford was purchased at <$16.08> and the current price is </$11.98>. Overall it is a loss of <$4.10>
        ''' </summary>

        lstNameOfStock.Items.Add("WWE")
        lstOgPrice.Items.Add("Original Stock Price:")
        lstPrice.Items.Add("$73.26")
        lstCurrentStock.Items.Add("Current Stock Price:")
        lstCurrentPrice.Items.Add("$67.69")
        lstNumberOfShares.Items.Add("Number of Shares:")
        lstNumberShare.Items.Add("1")
        lstNET.Items.Add("Loss:")
        lstNetLoss.Items.Add("-$5.57")
        lstNetLoss.ForeColor = Color.Red
        ''' <summary>
        ''' WWE was purchased at <73.26> and the current price is <67.69>. Overall it is a loss of <5.57>
        ''' </summary>
    End Sub


    Private Sub ListBox1_SelectedIndexChanged(sender As Object, e As EventArgs)





    End Sub

    Private Sub Stock_Leave(sender As Object, e As EventArgs) Handles lstStocks2.Leave
        lstStocks2.ForeColor = Color.DarkGray


    End Sub

    Private Sub ListBox1_SelectedIndexChanged_1(sender As Object, e As EventArgs) Handles lstPrice.SelectedIndexChanged

    End Sub
End Class
