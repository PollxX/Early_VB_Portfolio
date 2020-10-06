Public Class Form2
    Private Sub btn_gen_Click(sender As Object, e As EventArgs) Handles btn_gen.Click
        Dim str_genStringNorm As String = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz1234567890£$%^&*()_+!/.,<>?;'#[]{}:@~`¬|\" 'defined viable character for password
        Dim rnd_random As New Random
        Dim sb As New System.Text.StringBuilder 'using stringbuilder and random to create the string
        For temp As Integer = 1 To 9
            Dim index As Integer = rnd_random.Next(0, 93)
            sb.Append(str_genStringNorm.Substring(index, 1))
        Next
        txt_gen.Text = (sb.ToString()) 'outputs the string to textbox
        Clipboard.SetText(txt_gen.Text) 'sets the password to clipboard
    End Sub
End Class