Public Class Form1
    Dim int_input, int_inputalt As Integer
    Dim lng_out, lng_count, lng_dup As Long
    Dim lng_out2, lng_count2, lng_dup2 As Long
    Dim str_numval, str_txtval As String


    Private Sub btn_Start_Click(sender As Object, e As EventArgs) Handles btn_Start.Click
        txt_sequence.Clear()
        int_input = txt_input.Text
        If int_input <= 90 Then                 'limit of the integer value is after the 91st term of the fibonacci sequence
            lng_out = 0                           ' if loop to keep the process working until int_temp = int_input
            lng_count = 1
            lng_dup = 0
            For int_temp As Integer = 0 To int_input - 1
                txt_sequence.Text += Str(lng_out) & vbCrLf             'display values to the output textbox
                lng_out = lng_count
                lng_count = lng_out + lng_dup
                lng_dup = lng_out
            Next
        Else
            MsgBox("Input value cannot exceed 90.", , "Error")           ' added a written error for the high limit of 90 as mentioned above
        End If
    End Sub
    Private Sub nud_counter1_ValueChanged(sender As Object, e As EventArgs) Handles nud_counter1.ValueChanged
        nud_counter1.Minimum = 1 & nud_counter1.Maximum = 90
        nud_counter1.TextAlign = 1
        int_inputalt = nud_counter1.Text      ' to keep the output of the number counter as a variable to control the process  
    End Sub

    Private Sub txt_input_TextChanged(sender As Object, e As EventArgs) Handles txt_input.TextChanged
        str_txtval = txt_input.Text
        If IsNumeric(str_txtval) Then
            str_numval = str_txtval
        Else
            txt_input.Text = CStr(str_numval)
        End If
    End Sub


    Private Sub btn_run2_Click(sender As Object, e As EventArgs) Handles btn_run2.Click
        txt_sequence2.Text = ""
        int_inputalt = nud_counter1.Text
        If int_inputalt <= 90 Then
            lng_out2 = 0
            lng_count2 = 1
            lng_dup2 = 0
            For int_temp2 As Integer = 0 To int_inputalt - 1
                txt_sequence2.Text = Str(lng_out2)
                lng_out2 = lng_count2
                lng_count2 = lng_out2 + lng_dup2
                lng_dup2 = lng_out2
            Next
        Else
            MsgBox("Input value cannot exceed 90 as well as being a postive integer from 1.", , "Error")
            txt_sequence2.Text = 0                      ' this is to stop the numericupdown from sticking at a value and giving a runtime error
            nud_counter1.Text = 1                       ' it also resets the given value to prevent overlap 
        End If

    End Sub
End Class
