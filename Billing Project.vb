Public Class Billing_Project

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim t1, t2, t3, t4, t5, t6, t7, t8, t As Double
        ListBox1.Items.Clear()
        ListBox1.Items.Add("Bill....")
        If CheckBox1.Checked = True Then
            t1 = TextBox1.Text * 10
            ListBox1.Items.Add("Idly : " & TextBox1.Text & " * " & "10" & "=" & t1)
        End If
        If CheckBox2.Checked = True Then
            t2 = TextBox2.Text * 15
            ListBox1.Items.Add("Vada : " & TextBox2.Text & " * " & "15" & "=" & t2)
        End If
        If CheckBox3.Checked = True Then
            t3 = TextBox3.Text * 10
            ListBox1.Items.Add("Chapathi : " & TextBox3.Text & " * " & "10" & "=" & t3)
        End If
        If CheckBox4.Checked = True Then
            t4 = TextBox4.Text * 20
            ListBox1.Items.Add("Porata : " & TextBox4.Text & " * " & "20" & "=" & t4)
        End If
        If RadioButton1.Checked = True Then
            t5 = TextBox9.Text * 0
            ListBox1.Items.Add("Water : " & TextBox9.Text & " * " & "0" & "=" & t5)
        End If
        If RadioButton2.Checked = True Then
            t6 = TextBox10.Text * 10
            ListBox1.Items.Add("Tea : " & TextBox10.Text & " * " & "10" & "=" & t6)
        End If
        If RadioButton3.Checked = True Then
            t7 = TextBox11.Text * 15
            ListBox1.Items.Add("Coffee : " & TextBox11.Text & " * " & "15" & "=" & t7)
        End If
        If RadioButton4.Checked = True Then
            t8 = TextBox12.Text * 20
            ListBox1.Items.Add("Milk : " & TextBox12.Text & " * " & "20" & "=" & t8)
        End If
        t = t1 + t2 + t3 + t4 + t5 + t6 + t7 + t8
        TextBox13.Text = t
        ListBox1.Items.Add("Total : " & "=" & t)

    End Sub
End Class