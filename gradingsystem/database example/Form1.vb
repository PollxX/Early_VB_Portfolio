Public Class Form1
    Dim int_unit1, int_unit2, int_unit3, int_sum As Integer
    Dim str_output As String 'diming variables used for output and calculations
    Dim fn As String = "\\kcfs03\StudentHome\KC68663\A---Programming\RandW\structure.txt"
    Structure employee
        Dim name, birth As String
        Dim ID, onemark, twomark, threemark, onegrad, twograd, threegrad As Integer
    End Structure
    Dim employees As List(Of employee) = New List(Of employee) 'diming the structure and list
    Private Sub btn_add_Click(sender As Object, e As EventArgs) Handles btn_add.Click
        Dim em As employee = New employee
        em.name = txt_name.Text
        em.ID = txt_ID.Text
        em.birth = txt_birth.Text
        em.onemark = txt_unit1.Text
        em.twomark = txt_unit2.Text
        em.threemark = txt_unit3.Text
        em.onegrad = txt_unit1g.Text
        em.twograd = txt_unit2g.Text
        em.threegrad = txt_unit3g.Text
        employees.Add(em)
        cbo_name.Items.Add(txt_name)
        cbo_name.Items.Clear()
        For Each item In employees
            cbo_name.Items.Add(item.ID)
        Next 'this is the structure used for saving the details of the user
    End Sub
    Private Sub cbo_name_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbo_name.SelectedIndexChanged
        txt_name.Text = employees(cbo_name.SelectedIndex).name
        txt_ID.Text = employees(cbo_name.SelectedIndex).ID
        txt_birth.Text = employees(cbo_name.SelectedIndex).birth
        txt_unit1.Text = employees(cbo_name.SelectedIndex).onemark
        txt_unit2.Text = employees(cbo_name.SelectedIndex).twomark
        txt_unit3.Text = employees(cbo_name.SelectedIndex).threemark
        txt_unit1g.Text = employees(cbo_name.SelectedIndex).onegrad
        txt_unit2g.Text = employees(cbo_name.SelectedIndex).twograd
        txt_unit3g.Text = employees(cbo_name.SelectedIndex).threegrad 'the combobox is attached to the infomation of the textboxes
    End Sub
    Private Sub btn_save_Click(sender As Object, e As EventArgs) Handles btn_save.Click
        Dim f = My.Computer.FileSystem.OpenTextFileWriter(fn, False)
        For Each item In employees
            f.WriteLine(item.name & "," & item.ID & "," & item.birth & "," & item.onemark & "," & item.twomark & "," & item.threemark & "," & item.onegrad & "," & item.twograd & "," & item.threegrad)
        Next
        f.Close() 'this is how the details are saved, with each partion an associated item of the structure
    End Sub
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If My.Computer.FileSystem.FileExists(fn) Then
            Dim f = My.Computer.FileSystem.OpenTextFieldParser(fn, ",")
            While Not f.EndOfData
                Dim dat() = f.ReadFields
                Dim temp As employee = New employee
                temp.name = dat(0)
                temp.ID = dat(1)
                temp.birth = dat(2)
                temp.onemark = dat(3)
                temp.twomark = dat(4)
                temp.threemark = dat(5)
                temp.onegrad = dat(6)
                temp.twograd = dat(7)
                temp.threegrad = dat(8)
                employees.Add(temp)
            End While
            f.Close()
            cbo_name.Items.Clear()
            For Each item In employees
                cbo_name.Items.Add(item.ID)
            Next
        End If
    End Sub
    Private Sub btn_calculate_Click(sender As Object, e As EventArgs) Handles btn_calculate.Click
        int_unit1 = txt_unit1.Text * txt_unit1g.Text
        int_unit2 = txt_unit2.Text * txt_unit2g.Text
        int_unit3 = txt_unit3.Text * txt_unit3g.Text
        int_sum = int_unit1 + int_unit2 + int_unit3
        lbl_total.Text = int_sum 'calculations to get the grade
        lbl_output.Text = str_output

        Form2.lbl_mID.Text = txt_ID.Text
        Form2.lbl_mname.Text = txt_name.Text
        Form2.lbl_mbirth.Text = txt_birth.Text
        Form2.lbl_S1.Text = int_unit1
        Form2.lbl_S2.Text = int_unit2
        Form2.lbl_S3.Text = int_unit3 'this chunk allows the data to be moved to the second form

        If int_sum <= 230 And int_sum >= 210 Then 'from 210 to 230 is a pass
            str_output = "Pass"
            lbl_output.Text = str_output
            Form2.lbl_grade.Text = str_output
            Form2.Show()
        End If
        If int_sum <= 250 And int_sum >= 231 Then 'from 231 to 250 is a merit
            str_output = "Merit"
            lbl_output.Text = str_output
            Form2.lbl_grade.Text = str_output
            Form2.Show()
        End If
        If int_sum <= 270 And int_sum >= 251 Then 'from 251 to 270 is a distinction
            str_output = "Distinction"
            lbl_output.Text = str_output
            Form2.lbl_grade.Text = str_output
            Form2.Show()
        End If
        If int_sum < 210 Or int_sum > 270 Then 'this stops the user from going too extreme with the input
            MessageBox.Show("Error in calculation, Sum is too high or low.")
            lbl_output.Text = ""
            lbl_total.Text = ""
        End If
    End Sub
    Private Sub txt_unit2g_TextChanged(sender As Object, e As EventArgs) Handles txt_unit2g.TextChanged
        Dim numcheck
        numcheck = IsNumeric(txt_unit2g.Text)
        If numcheck = False Then
            MsgBox("Enter Numbers only.")
        End If
    End Sub
    Private Sub txt_unit1g_TextChanged(sender As Object, e As EventArgs) Handles txt_unit1g.TextChanged
        Dim numcheck
        numcheck = IsNumeric(txt_unit1g.Text)
        If numcheck = False Then
            MsgBox("Enter Numbers only.")   'this is to prevent any wrong values being entered such as symbols, letters, etc.
        End If
    End Sub
    Private Sub txt_unit3g_TextChanged(sender As Object, e As EventArgs) Handles txt_unit3g.TextChanged
        Dim numcheck
        numcheck = IsNumeric(txt_unit3g.Text)
        If numcheck = False Then
            MsgBox("Enter Numbers only.")
        End If
    End Sub
    Private Sub txt_ID_TextChanged(sender As Object, e As EventArgs) Handles txt_ID.TextChanged
        Dim numcheck
        numcheck = IsNumeric(txt_ID.Text)
        If numcheck = False Then
            MsgBox("Enter Numbers only.")
        End If
    End Sub
End Class
