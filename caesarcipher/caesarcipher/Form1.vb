Public Class Form1
    Dim str_input, str_encrypt, str_decrypt As String
    Dim int_shift As Integer
    Dim char_convert As Char
    Private Sub btn_encrypt_Click(sender As Object, e As EventArgs) Handles btn_encrypt.Click
        str_decrypt = ""                'resets the input text
        str_input = txt_input.Text
        int_shift = nud_shift.Text
        For int_temp As Integer = 0 To Len(str_input) - 1   'length of the string is capped after the end to prevent cutoff
            char_convert = ChrW(Asc(str_input(int_temp)) + int_shift)
            str_encrypt += char_convert
        Next
        str_encrypt += vbTab
        txt_output.Text = str_encrypt   'displays the encrypted ascii version of input
    End Sub
    Private Sub nud_shift_ValueChanged(sender As Object, e As EventArgs) Handles nud_shift.ValueChanged
        nud_shift.Minimum = 0       'limiting the nud's ability of shift from 0 to 3
        nud_shift.Maximum = 3
    End Sub
    Private Sub btn_clear_Click(sender As Object, e As EventArgs) Handles btn_clear.Click
        txt_input.Text = ""         'this button clears previous inputs when needed
        txt_output.Text = ""
        str_encrypt = ""
        str_decrypt = ""
    End Sub
    Private Sub btn_decrypt_Click(sender As Object, e As EventArgs) Handles btn_decrypt.Click
        str_encrypt = ""            'resets the input text
        str_input = txt_input.Text
        int_shift = nud_shift.Text  'input of textbox is set at the value of the NumericUpDown
        For int_temp2 As Integer = 0 To Len(str_input) - 1
            char_convert = ChrW(Asc(str_input(int_temp2)) - int_shift)
            str_decrypt += char_convert
        Next
        str_decrypt += vbTab
        txt_output.Text = str_decrypt   'displays the decrypted ascii version of input
    End Sub
End Class
