Public Class Form5

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim num, soma As Integer
        num = 1001
        Do While (num < 3000)
            soma = soma + num
            num = num + 2
        Loop
        ListBox1.Items.Add("Soma dos Números Ímpares:")
        ListBox1.Items.Add(soma)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        End
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        ListBox1.Items.Clear()
    End Sub
End Class