Public Class Form1
    Dim n, cont, valor, ia, ib, ja, jb, a As Integer

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        n = TextBox1.Text
        ia = 0
        ib = 0
        ja = 0
        jb = 0
        a = 0
        cont = 1
        Do While (cont <= n)
            valor = Val(InputBox("entre com a idade do nadador"))
            If valor >= 5 And valor <= 7 Then
                ia = ia + 1
            ElseIf valor >= 8 And valor <= 11 Then
                ib = ib + 1
            ElseIf valor >= 12 And valor <= 13 Then
                ja = ja + 1
            ElseIf valor >= 14 And valor <= 17 Then
                jb = jb + 1
            ElseIf valor >= 18 Then
                a = a + 1
            End If

            cont = cont + 1
        Loop
        ListBox1.Items.Add("Infantil A")
        ListBox1.Items.Add(ia & " Nadadores")
        ListBox1.Items.Add(" ")
        ListBox1.Items.Add("Infantil B")
        ListBox1.Items.Add(ib & " Nadadores")
        ListBox1.Items.Add(" ")
        ListBox1.Items.Add("Juvenil A")
        ListBox1.Items.Add(ja & " Nadadores")
        ListBox1.Items.Add(" ")
        ListBox1.Items.Add("Juvenil B")
        ListBox1.Items.Add(jb & " Nadadores")
        ListBox1.Items.Add(" ")
        ListBox1.Items.Add("Adultos")
        ListBox1.Items.Add(a & " Nadadores")

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        End
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        TextBox1.Clear()
        ListBox1.Items.Clear()
    End Sub
End Class
