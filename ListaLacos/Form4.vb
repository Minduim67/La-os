Public Class Form4

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim tor, time As String
        Dim cont, palm, cori, sp As Integer
        cont = 1
        Do While (cont <= 10)
            tor = InputBox("Digite o nome do torcedor (Obs: todas as letras MINUSCULAS e SEM ACENTOS)")
            time = InputBox("Digite o time do torcedor (Obs: todas as letras MINUSCULAS e SEM ACENTOS)")
            If (time = "corinthians") Then
                cori = cori + 1
                ListBox1.Items.Add(tor)
            ElseIf (time = "sao paulo") Then
                sp = sp + 1
                ListBox2.Items.Add(tor)
            ElseIf (time = "palmeiras") Then
                palm = palm + 1
                ListBox3.Items.Add(tor)
            End If
            cont = cont + 1
        Loop
        ListBox1.Items.Add("Quantidade de Torcedores:")
        ListBox1.Items.Add(cori)
        ListBox2.Items.Add("Quantidade de Torcedores:")
        ListBox2.Items.Add(sp)
        ListBox3.Items.Add("Quantidade de Torcedores:")
        ListBox3.Items.Add(palm)
    End Sub
End Class