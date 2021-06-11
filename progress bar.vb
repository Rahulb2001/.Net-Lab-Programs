Public Class progress_bar
    Private Sub ProgressBar1_Click(sender As Object, e As EventArgs) Handles ProgressBar1.Click
        If ProgressBar1.Value < 100 Then
            ProgressBar1.Value = ProgressBar1.Value + 10
            Label3.Text = ProgressBar1.Value & "%"
        Else
            multipliaction_table.Show()
            Me.Hide()
        End If
    End Sub
End Class