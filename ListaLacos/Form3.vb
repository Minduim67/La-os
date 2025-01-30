Public Class Form3

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim num, mini, maxi, cont, valor, med, soma As Integer
        num = TextBox1.Text
        cont = 1
        maxi = 0
        mini = 999999
        Do While (cont <= num)
            valor = val(InputBox("Digite o Número"))
            If (valor > maxi) Then
                maxi = valor
            End If
            If (valor < mini) Then
                mini = valor
            End If
            soma = soma + valor
            med = soma / num
            cont = cont + 1
        Loop
        ListBox1.Items.Add("Maior Valor:")
        ListBox1.Items.Add(maxi)
        ListBox1.Items.Add("Menor Valor:")
        ListBox1.Items.Add(mini)
        ListBox1.Items.Add("Média:")
        ListBox1.Items.Add(med)


    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        End
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        TextBox1.Clear()
        ListBox1.Items.Clear()
    End Sub
End Class