Public Class Form1
    Private Sub Fechar_button_Click(sender As Object, e As EventArgs) Handles Fechar_button.Click
        End
    End Sub

    Private Sub Jogar_button_Click(sender As Object, e As EventArgs) Handles Jogar_button.Click
        ImagemResultado.Visible = False
        Randomize()
        num1.Text = CStr(Int(Rnd() * 10))
        num2.Text = CStr(Int(Rnd() * 10))
        num3.Text = CStr(Int(Rnd() * 10))
        'Isto ocorrera se dar todos 7 no jogo'
        If (num1.Text = "7") And (num2.Text = "7") And (num3.Text = "7") Then
            ImagemResultado.Image = Image.FromFile("C:\unintervisualstudio\JogoSetedaSortesln\sorte7.png")
            ImagemResultado.Visible = True
            Beep()
            'se somente um 7 aparecer'
        ElseIf (num1.Text = "7") Or (num2.Text = "7") Or (num3.Text = "7") Then
            ImagemResultado.Image = Image.FromFile("C:\unintervisualstudio\JogoSetedaSortesln\7dasorte.jpg")
            ImagemResultado.Visible = True
            Beep()
            'se não aparecer nenhum 7'
        Else
            ImagemResultado.Image = Image.FromFile("C:\unintervisualstudio\JogoSetedaSortesln\perdeu.jpg")
            ImagemResultado.Visible = True
        End If
    End Sub

    Private Sub ImagemResultado_Click(sender As Object, e As EventArgs) Handles ImagemResultado.Click

    End Sub
End Class
