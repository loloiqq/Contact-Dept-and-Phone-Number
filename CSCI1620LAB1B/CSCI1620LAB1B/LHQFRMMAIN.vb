Public Class VBMailOrderForm
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles CustomerRelationsButton.Click
        DepartmentContactTextBox.Text = "Tricia Mills"
        PhoneNumberTextBox.Text = "500-1111"

    End Sub

    Private Sub VBMailOrderForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub ExitButton_Click(sender As Object, e As EventArgs) Handles ExitButton.Click
        Close()
    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles DepartementContactLabel.Click

    End Sub

    Private Sub DepartmentContactTextBox_TextChanged(sender As Object, e As EventArgs) Handles DepartmentContactTextBox.TextChanged


    End Sub

    Private Sub MarketingButton_Click(sender As Object, e As EventArgs) Handles MarketingButton.Click
        DepartmentContactTextBox.Text = "Michelle Rigner"
        PhoneNumberTextBox.Text = "500-2222"
    End Sub

    Private Sub OrderProcessingButton_Click(sender As Object, e As EventArgs) Handles OrderProcessingButton.Click
        DepartmentContactTextBox.Text = "Kenna DeVoss"
        PhoneNumberTextBox.Text = "500-3333"
    End Sub

    Private Sub ShippingButton_Click(sender As Object, e As EventArgs) Handles ShippingButton.Click
        DepartmentContactTextBox.Text = "Eric Andrews"
        PhoneNumberTextBox.Text = "500-4444"
    End Sub
End Class
