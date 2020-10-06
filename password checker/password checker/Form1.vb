Public Class Form1
    Dim fn As String = "\\kcfs03\StudentHome\KC68663\A---Programming\RandW\checking.txt"
    Dim int_strlength, int_strength As Integer
    Dim str_genoutput, str_gen, str_check, str_verify As String
    Dim int_aLow, int_aUp, int_aNum, int_aSym As Integer 'declaring values for integers, strings.
    Structure username 'defining the structure
        Dim str_name As String
        Dim str_password As String
    End Structure
    Dim usernames As List(Of username) = New List(Of username)
    Private Sub btn_check_Click(sender As Object, e As EventArgs) Handles btn_check.Click
        int_aLow = 1
        int_aNum = 1
        int_aSym = 1
        int_aUp = 1
        str_check = txt_check.Text 'when checked, it resets any previous values

        If Len(str_check) >= 8 Then 'check length (has to be more than or equal to 8)
            For int_temp As Integer = 0 To Len(str_check) - 1
                int_strength = int_aLow + int_aNum + int_aSym + int_aUp

                If IsNumeric(str_check(int_temp)) = True Then
                    int_aNum += 1
                End If
                If Char.IsLower(str_check(int_temp)) Then
                    int_aLow += 1
                End If
                If Char.IsUpper(str_check(int_temp)) = True Then
                    int_aUp += 1
                End If
                If Char.IsSymbol(str_check(int_temp)) = True Or Char.IsPunctuation(str_check(int_temp)) = True Then
                    int_aSym += 1         'checking for symbols, uppercase, lowercase or numbers
                End If
                If int_aNum < 2 Then
                    lbl_num2.Text = "Not enough numbers."
                ElseIf int_aNum >= 2 Then
                    lbl_num2.Text = "Acceptable amount."
                End If
                If int_aUp < 2 Then
                    lbl_upp2.Text = "Not enough upper case letters."
                ElseIf int_aUp >= 2 Then
                    lbl_upp2.Text = "Acceptable amount."
                End If
                If int_aLow < 2 Then
                    lbl_low2.Text = "Not enough lower case letters."
                ElseIf int_aLow >= 2 Then
                    lbl_low2.Text = "Acceptable amount."
                End If
                If int_aSym < 2 Then
                    lbl_sym2.Text = "Not enough symbols."
                ElseIf int_aSym >= 2 Then
                    lbl_sym2.Text = "Acceptable amount."
                End If
                If int_strength <= 24 And int_strength >= 19 Then
                    lbl_password2.Text = "Strong"
                ElseIf int_strength <= 12 And int_strength >= 0 Then
                    lbl_password2.Text = "Weak"
                ElseIf int_strength <= 18 And int_strength >= 13 Then
                    lbl_password2.Text = "Moderate"
                End If
            Next
        ElseIf MsgBox("Too short.", , "Error: Minimum Length of 8") Then
        End If

        
        Dim user As username = New username 'adding the values to the structure but not saved yet
        user.str_name = txt_name.Text
        user.str_password = txt_check.Text
        usernames.Add(user)
        cbo_user.Items.Add(txt_name)
        cbo_user.Items.Clear()
        For Each item In usernames
            cbo_user.Items.Add(item.str_name)
        Next
        'checks the input

    End Sub
    Private Sub btn_save_che_Click(sender As Object, e As EventArgs) Handles btn_save_che.Click
        Dim f = My.Computer.FileSystem.OpenTextFileWriter(fn, False)
        For Each item In usernames
            f.WriteLine(item.str_name & "," & item.str_password)
        Next
        f.Close()
        MsgBox("Item saved to file.", , "Item Saved!")
        'saves and writes to file
    End Sub
    Private Sub btn_clear_che_Click(sender As Object, e As EventArgs) Handles btn_clear_che.Click
        txt_check.Text = ""
        txt_name.Text = ""
        int_aNum = 1
        int_aLow = 1
        int_aSym = 1
        int_aUp = 1
        lbl_low2.Text = ""
        lbl_num2.Text = ""
        lbl_upp2.Text = ""
        lbl_sym2.Text = ""
        'clears the last entry
    End Sub
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If My.Computer.FileSystem.FileExists(fn) Then
            Dim f = My.Computer.FileSystem.OpenTextFieldParser(fn, ",")
            While Not f.EndOfData
                Dim dat() = f.ReadFields
                Dim temp As username = New username
                temp.str_name = dat(0)
                temp.str_password = dat(1)
                usernames.Add(temp)
            End While
            f.Close()
            cbo_user.Items.Clear()
            For Each item In usernames
                cbo_user.Items.Add(item.str_name)
            Next
        End If
    End Sub
    Private Sub cbo_user_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbo_user.SelectedIndexChanged
        txt_name.Text = usernames(cbo_user.SelectedIndex).str_name
        txt_check.Text = usernames(cbo_user.SelectedIndex).str_password
        'links the combobox with the structure
    End Sub
    Private Sub btn_disp1_Click(sender As Object, e As EventArgs) Handles btn_disp1.Click
        Form2.Show()
        'shows the second form, the password generator
    End Sub
End Class
