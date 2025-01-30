Public Class Form2

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim n, cont, valor, resu As Integer
        n = TextBox1.Text
        cont = 1
        resu = 0
        For cont = 1 To n
            valor = Val(InputBox("Digite o Número"))
            resu = resu + valor
        Next
        Label4.Text = resu
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        End
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        TextBox1.Clear()
        Label4.Text = " "
    End Sub
End Class