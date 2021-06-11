Public Class trafficsignal


    Private Sub RadioButton1_Click(sender As Object, e As EventArgs) Handles RadioButton1.Click
        Me.BackColor = Color.Red
        Dim t As String
        t = "Stop  "
        TextBox1.Text = t
    End Sub

    Private Sub RadioButton2_Click(sender As Object, e As EventArgs) Handles RadioButton2.Click
        Me.BackColor = Color.Yellow
        Dim t As String
        t = "Be Ready... "
        TextBox1.Text = t
    End Sub

    Private Sub RadioButton3_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton3.Click
        Me.BackColor = Color.Green
        Dim t As String
        t = "GO.... "
        TextBox1.Text = (t)
    End Sub
End Class