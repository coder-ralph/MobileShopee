Imports System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox

Public Class MainForm

    Private cart As New DataTable

    Private Sub MainForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Set up the available items ListBox
        ' List of Samsung
        lstItems.Items.Add("Samsung Galaxy 10 - $152.99")
        lstItems.Items.Add("Samsung Galaxy 56 - $159.99")
        lstItems.Items.Add("Samsung Galaxy 57 - $349.99")

        ' List of Redmi Note 
        lstItems.Items.Add("Redmi Note 4 - $159.99")
        lstItems.Items.Add("Redmi Note 5 - $179.79")
        lstItems.Items.Add("Redmi Note 6 - $183.99")
        lstItems.Items.Add("Redmi Note 7 - $195.99")
        lstItems.Items.Add("Redmi Note 8 - $349.99")
        lstItems.Items.Add("Redmi Note 9 - $399.99")

        ' List of iPhone
        lstItems.Items.Add("Apple iPhone 5 - $249.68")
        lstItems.Items.Add("Apple iPhone 6 - $399.99")
        lstItems.Items.Add("Apple iPhone 7 - $480.99")

        ' Set up the quantity ComboBox
        For i As Integer = 1 To 10
            cmbQuantity.Items.Add(i)
        Next
        cmbQuantity.SelectedIndex = 0

        ' Set up the cart DataGridView
        cart.Columns.Add("Item")
        cart.Columns.Add("Price")
        cart.Columns.Add("Quantity")
        cart.Columns.Add("Total")
        dgvCart.DataSource = cart
    End Sub

    Private Sub btnAddToCart_Click(sender As Object, e As EventArgs) Handles btnAddToCart.Click
        ' Add the selected item to the cart with the selected quantity
        Dim item As String = lstItems.SelectedItem.ToString()
        Dim price As Decimal = CDec(item.Substring(item.LastIndexOf("$") + 1))
        Dim quantity As Integer = CInt(cmbQuantity.SelectedItem)
        Dim total As Decimal = price * quantity

        cart.Rows.Add(item.Substring(0, item.LastIndexOf("-") - 1), price.ToString("C"), quantity, total.ToString("C"))
    End Sub

    Private Sub btnCalculateTotal_Click(sender As Object, e As EventArgs) Handles btnCalculateTotal.Click
        ' Calculate the total price of all items in the cart
        Dim total As Decimal = 0
        For Each row As DataRow In cart.Rows
            total += CDec(row("Total"))
        Next
        lblTotal.Text = "Total: " + total.ToString("C")

    End Sub

    Private Sub btnLogout_Click(sender As Object, e As EventArgs) Handles btnLogout.Click
        ' Reset the user session
        ' ...

        ' Return to the login form
        Dim loginForm As New Form1()
        loginForm.Show()
        Me.Close()
    End Sub

End Class