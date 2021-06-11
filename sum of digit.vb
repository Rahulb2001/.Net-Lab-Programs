Public Class sum_of_digit
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Dim n As Integer
        Dim sum As Integer

        n = Val(TextBox1.Text)
        While n <> 0
            sum = sum + n Mod 10
            n = n \ 10
        End While
        TextBox2.Text = Val(sum)
        'MsgBox(sum)
    End Sub

End Class