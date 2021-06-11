Public Class check
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If RadioButton1.Checked = True Then
            MsgBox("you have selected red")
        ElseIf RadioButton2.Checked = True Then
            MsgBox("you have selected blue")
        ElseIf RadioButton3.Checked = True Then
            MsgBox("you have selected Yellow")
        Else
            MsgBox("not selcted any items ")

        End If

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim m As String
        If CheckBox1.Checked = True Then
            m = CheckBox1.Text
            MsgBox(m)
        ElseIf CheckBox2.Checked = True Then
            m = m & CheckBox2.Text
            MsgBox(m)
        ElseIf CheckBox3.Checked = True Then
            m = m & CheckBox3.Text
            MsgBox(m)
        Else
            CheckBox4.Checked = True
            m = CheckBox2.Text & CheckBox1.Text
            MsgBox(m)
        End If
    End Sub
End Class