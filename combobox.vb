Public Class combobox
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim inp As String
        inp = InputBox("Enter the Item to be added")
        ComboBox1.Items.Add(inp)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim inp As String
        inp = InputBox("Enter the Item to be added")
        ComboBox1.Items.Remove(inp)

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        ComboBox1.Items.Remove(ComboBox1.SelectedItem)
    End Sub
End Class