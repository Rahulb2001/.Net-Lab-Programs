Public Class multipliaction_table
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Dim i As Integer
        Dim m As Integer
        m = TextBox1.Text
        For i = 1 To 10 Step 1
            ListBox1.Items.Add(m & "x" & i & "=" & m * i)
        Next
    End Sub
End Class