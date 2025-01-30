Public Class Form10

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim sexo, nome As String
        Dim h, m, cont As Integer
        cont = 1
        Do Until (cont = 3)
            nome = InputBox("Digite Seu Nome:")
            sexo = InputBox("Digite se Você é Homem ou Mulher (Obs: H para Homem e M para Mulher, Ambas as Letras em Maiusculas)")
            If (sexo = "M") Then
                m = m + 1
            ElseIf (sexo = "H") Then
                h = h + 1
            End If
            cont = cont + 1
        Loop
        ListBox1.Items.Add("Quantidade de Homens:")
        ListBox1.Items.Add(h)
        ListBox1.Items.Add("Quantidade de Mulheres:")
        ListBox1.Items.Add(m)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        End
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        ListBox1.Items.Clear()
    End Sub
End Class