Public Class text_move
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        PictureBox1.Visible = Not PictureBox1.Visible
    End Sub
End Class