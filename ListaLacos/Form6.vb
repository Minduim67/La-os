Public Class Form6

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim valor, soma As Integer
        valor = 1
        Do Until (valor = 0)
            valor = InputBox("Digite um Número:")
            soma = soma + valor
        Loop
        ListBox1.Items.Add("A Soma dos Números:")
        ListBox1.Items.Add(soma)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        End
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        ListBox1.Items.Clear()
    End Sub
End Class