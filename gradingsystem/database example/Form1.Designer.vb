<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.btn_add = New System.Windows.Forms.Button()
        Me.lbl_details2 = New System.Windows.Forms.Label()
        Me.txt_name = New System.Windows.Forms.TextBox()
        Me.cbo_name = New System.Windows.Forms.ComboBox()
        Me.btn_save = New System.Windows.Forms.Button()
        Me.lbl_details4u = New System.Windows.Forms.Label()
        Me.txt_unit1 = New System.Windows.Forms.TextBox()
        Me.lbl_details4 = New System.Windows.Forms.Label()
        Me.lbl_name = New System.Windows.Forms.Label()
        Me.txt_ID = New System.Windows.Forms.TextBox()
        Me.lbl_details = New System.Windows.Forms.Label()
        Me.txt_birth = New System.Windows.Forms.TextBox()
        Me.lbl_details3 = New System.Windows.Forms.Label()
        Me.btn_calculate = New System.Windows.Forms.Button()
        Me.txt_unit2 = New System.Windows.Forms.TextBox()
        Me.lbl_details5 = New System.Windows.Forms.Label()
        Me.lbl_details5u = New System.Windows.Forms.Label()
        Me.txt_unit3 = New System.Windows.Forms.TextBox()
        Me.lbl_details6 = New System.Windows.Forms.Label()
        Me.lbl_details6u = New System.Windows.Forms.Label()
        Me.txt_unit1g = New System.Windows.Forms.TextBox()
        Me.lbl_details4g = New System.Windows.Forms.Label()
        Me.lbl_details5g = New System.Windows.Forms.Label()
        Me.txt_unit2g = New System.Windows.Forms.TextBox()
        Me.lbl_details6g = New System.Windows.Forms.Label()
        Me.txt_unit3g = New System.Windows.Forms.TextBox()
        Me.lbl_marks = New System.Windows.Forms.Label()
        Me.lbl_total = New System.Windows.Forms.Label()
        Me.lbl_output = New System.Windows.Forms.Label()
        Me.lbl_result = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btn_add
        '
        Me.btn_add.Location = New System.Drawing.Point(23, 131)
        Me.btn_add.Name = "btn_add"
        Me.btn_add.Size = New System.Drawing.Size(75, 23)
        Me.btn_add.TabIndex = 0
        Me.btn_add.Text = "Add details"
        Me.btn_add.UseVisualStyleBackColor = True
        '
        'lbl_details2
        '
        Me.lbl_details2.AutoSize = True
        Me.lbl_details2.Location = New System.Drawing.Point(23, 76)
        Me.lbl_details2.Name = "lbl_details2"
        Me.lbl_details2.Size = New System.Drawing.Size(35, 13)
        Me.lbl_details2.TabIndex = 1
        Me.lbl_details2.Text = "Name"
        '
        'txt_name
        '
        Me.txt_name.Location = New System.Drawing.Point(117, 73)
        Me.txt_name.Name = "txt_name"
        Me.txt_name.Size = New System.Drawing.Size(91, 20)
        Me.txt_name.TabIndex = 2
        '
        'cbo_name
        '
        Me.cbo_name.FormattingEnabled = True
        Me.cbo_name.Location = New System.Drawing.Point(117, 12)
        Me.cbo_name.Name = "cbo_name"
        Me.cbo_name.Size = New System.Drawing.Size(91, 21)
        Me.cbo_name.TabIndex = 3
        '
        'btn_save
        '
        Me.btn_save.Location = New System.Drawing.Point(104, 131)
        Me.btn_save.Name = "btn_save"
        Me.btn_save.Size = New System.Drawing.Size(75, 23)
        Me.btn_save.TabIndex = 4
        Me.btn_save.Text = "Save details"
        Me.btn_save.UseVisualStyleBackColor = True
        '
        'lbl_details4u
        '
        Me.lbl_details4u.AutoSize = True
        Me.lbl_details4u.Location = New System.Drawing.Point(394, 12)
        Me.lbl_details4u.Name = "lbl_details4u"
        Me.lbl_details4u.Size = New System.Drawing.Size(35, 13)
        Me.lbl_details4u.TabIndex = 5
        Me.lbl_details4u.Text = "Unit 1"
        '
        'txt_unit1
        '
        Me.txt_unit1.Location = New System.Drawing.Point(365, 28)
        Me.txt_unit1.Name = "txt_unit1"
        Me.txt_unit1.ReadOnly = True
        Me.txt_unit1.Size = New System.Drawing.Size(91, 20)
        Me.txt_unit1.TabIndex = 8
        Me.txt_unit1.Text = "10"
        '
        'lbl_details4
        '
        Me.lbl_details4.AutoSize = True
        Me.lbl_details4.Location = New System.Drawing.Point(306, 31)
        Me.lbl_details4.Name = "lbl_details4"
        Me.lbl_details4.Size = New System.Drawing.Size(53, 13)
        Me.lbl_details4.TabIndex = 7
        Me.lbl_details4.Text = "Unit Mark"
        '
        'lbl_name
        '
        Me.lbl_name.AutoSize = True
        Me.lbl_name.Location = New System.Drawing.Point(21, 15)
        Me.lbl_name.Name = "lbl_name"
        Me.lbl_name.Size = New System.Drawing.Size(66, 13)
        Me.lbl_name.TabIndex = 9
        Me.lbl_name.Text = "Select an ID"
        '
        'txt_ID
        '
        Me.txt_ID.Location = New System.Drawing.Point(117, 47)
        Me.txt_ID.Name = "txt_ID"
        Me.txt_ID.Size = New System.Drawing.Size(91, 20)
        Me.txt_ID.TabIndex = 11
        Me.txt_ID.Text = "0000"
        '
        'lbl_details
        '
        Me.lbl_details.AutoSize = True
        Me.lbl_details.Location = New System.Drawing.Point(23, 50)
        Me.lbl_details.Name = "lbl_details"
        Me.lbl_details.Size = New System.Drawing.Size(58, 13)
        Me.lbl_details.TabIndex = 10
        Me.lbl_details.Text = "Student ID"
        '
        'txt_birth
        '
        Me.txt_birth.Location = New System.Drawing.Point(117, 99)
        Me.txt_birth.Name = "txt_birth"
        Me.txt_birth.Size = New System.Drawing.Size(91, 20)
        Me.txt_birth.TabIndex = 13
        Me.txt_birth.Text = "00/00/00"
        '
        'lbl_details3
        '
        Me.lbl_details3.AutoSize = True
        Me.lbl_details3.Location = New System.Drawing.Point(23, 102)
        Me.lbl_details3.Name = "lbl_details3"
        Me.lbl_details3.Size = New System.Drawing.Size(66, 13)
        Me.lbl_details3.TabIndex = 12
        Me.lbl_details3.Text = "Date of Birth"
        '
        'btn_calculate
        '
        Me.btn_calculate.Location = New System.Drawing.Point(186, 130)
        Me.btn_calculate.Name = "btn_calculate"
        Me.btn_calculate.Size = New System.Drawing.Size(75, 23)
        Me.btn_calculate.TabIndex = 14
        Me.btn_calculate.Text = "Calculate"
        Me.btn_calculate.UseVisualStyleBackColor = True
        '
        'txt_unit2
        '
        Me.txt_unit2.Location = New System.Drawing.Point(365, 108)
        Me.txt_unit2.Name = "txt_unit2"
        Me.txt_unit2.ReadOnly = True
        Me.txt_unit2.Size = New System.Drawing.Size(91, 20)
        Me.txt_unit2.TabIndex = 18
        Me.txt_unit2.Text = "10"
        '
        'lbl_details5
        '
        Me.lbl_details5.AutoSize = True
        Me.lbl_details5.Location = New System.Drawing.Point(306, 111)
        Me.lbl_details5.Name = "lbl_details5"
        Me.lbl_details5.Size = New System.Drawing.Size(53, 13)
        Me.lbl_details5.TabIndex = 17
        Me.lbl_details5.Text = "Unit Mark"
        '
        'lbl_details5u
        '
        Me.lbl_details5u.AutoSize = True
        Me.lbl_details5u.Location = New System.Drawing.Point(394, 95)
        Me.lbl_details5u.Name = "lbl_details5u"
        Me.lbl_details5u.Size = New System.Drawing.Size(35, 13)
        Me.lbl_details5u.TabIndex = 15
        Me.lbl_details5u.Text = "Unit 2"
        '
        'txt_unit3
        '
        Me.txt_unit3.Location = New System.Drawing.Point(365, 193)
        Me.txt_unit3.Name = "txt_unit3"
        Me.txt_unit3.ReadOnly = True
        Me.txt_unit3.Size = New System.Drawing.Size(91, 20)
        Me.txt_unit3.TabIndex = 22
        Me.txt_unit3.Text = "10"
        '
        'lbl_details6
        '
        Me.lbl_details6.AutoSize = True
        Me.lbl_details6.Location = New System.Drawing.Point(306, 200)
        Me.lbl_details6.Name = "lbl_details6"
        Me.lbl_details6.Size = New System.Drawing.Size(53, 13)
        Me.lbl_details6.TabIndex = 21
        Me.lbl_details6.Text = "Unit Mark"
        '
        'lbl_details6u
        '
        Me.lbl_details6u.AutoSize = True
        Me.lbl_details6u.Location = New System.Drawing.Point(394, 177)
        Me.lbl_details6u.Name = "lbl_details6u"
        Me.lbl_details6u.Size = New System.Drawing.Size(35, 13)
        Me.lbl_details6u.TabIndex = 19
        Me.lbl_details6u.Text = "Unit 3"
        '
        'txt_unit1g
        '
        Me.txt_unit1g.Location = New System.Drawing.Point(365, 51)
        Me.txt_unit1g.Name = "txt_unit1g"
        Me.txt_unit1g.Size = New System.Drawing.Size(91, 20)
        Me.txt_unit1g.TabIndex = 25
        Me.txt_unit1g.Text = "0"
        '
        'lbl_details4g
        '
        Me.lbl_details4g.AutoSize = True
        Me.lbl_details4g.Location = New System.Drawing.Point(306, 54)
        Me.lbl_details4g.Name = "lbl_details4g"
        Me.lbl_details4g.Size = New System.Drawing.Size(58, 13)
        Me.lbl_details4g.TabIndex = 26
        Me.lbl_details4g.Text = "Unit Grade"
        '
        'lbl_details5g
        '
        Me.lbl_details5g.AutoSize = True
        Me.lbl_details5g.Location = New System.Drawing.Point(306, 134)
        Me.lbl_details5g.Name = "lbl_details5g"
        Me.lbl_details5g.Size = New System.Drawing.Size(58, 13)
        Me.lbl_details5g.TabIndex = 28
        Me.lbl_details5g.Text = "Unit Grade"
        '
        'txt_unit2g
        '
        Me.txt_unit2g.Location = New System.Drawing.Point(365, 131)
        Me.txt_unit2g.Name = "txt_unit2g"
        Me.txt_unit2g.Size = New System.Drawing.Size(91, 20)
        Me.txt_unit2g.TabIndex = 27
        Me.txt_unit2g.Text = "0"
        '
        'lbl_details6g
        '
        Me.lbl_details6g.AutoSize = True
        Me.lbl_details6g.Location = New System.Drawing.Point(306, 219)
        Me.lbl_details6g.Name = "lbl_details6g"
        Me.lbl_details6g.Size = New System.Drawing.Size(58, 13)
        Me.lbl_details6g.TabIndex = 30
        Me.lbl_details6g.Text = "Unit Grade"
        '
        'txt_unit3g
        '
        Me.txt_unit3g.Location = New System.Drawing.Point(365, 216)
        Me.txt_unit3g.Name = "txt_unit3g"
        Me.txt_unit3g.Size = New System.Drawing.Size(91, 20)
        Me.txt_unit3g.TabIndex = 29
        Me.txt_unit3g.Text = "0"
        '
        'lbl_marks
        '
        Me.lbl_marks.AutoSize = True
        Me.lbl_marks.Location = New System.Drawing.Point(59, 193)
        Me.lbl_marks.Name = "lbl_marks"
        Me.lbl_marks.Size = New System.Drawing.Size(71, 13)
        Me.lbl_marks.TabIndex = 48
        Me.lbl_marks.Text = "Totals Marks:"
        '
        'lbl_total
        '
        Me.lbl_total.AutoSize = True
        Me.lbl_total.Location = New System.Drawing.Point(136, 193)
        Me.lbl_total.Name = "lbl_total"
        Me.lbl_total.Size = New System.Drawing.Size(43, 13)
        Me.lbl_total.TabIndex = 47
        Me.lbl_total.Text = "------------"
        '
        'lbl_output
        '
        Me.lbl_output.AutoSize = True
        Me.lbl_output.Location = New System.Drawing.Point(136, 212)
        Me.lbl_output.Name = "lbl_output"
        Me.lbl_output.Size = New System.Drawing.Size(43, 13)
        Me.lbl_output.TabIndex = 46
        Me.lbl_output.Text = "------------"
        '
        'lbl_result
        '
        Me.lbl_result.AutoSize = True
        Me.lbl_result.Location = New System.Drawing.Point(66, 212)
        Me.lbl_result.Name = "lbl_result"
        Me.lbl_result.Size = New System.Drawing.Size(64, 13)
        Me.lbl_result.TabIndex = 45
        Me.lbl_result.Text = "Final Grade:"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(520, 263)
        Me.Controls.Add(Me.lbl_marks)
        Me.Controls.Add(Me.lbl_total)
        Me.Controls.Add(Me.lbl_output)
        Me.Controls.Add(Me.lbl_result)
        Me.Controls.Add(Me.lbl_details6g)
        Me.Controls.Add(Me.txt_unit3g)
        Me.Controls.Add(Me.lbl_details5g)
        Me.Controls.Add(Me.txt_unit2g)
        Me.Controls.Add(Me.lbl_details4g)
        Me.Controls.Add(Me.txt_unit1g)
        Me.Controls.Add(Me.txt_unit3)
        Me.Controls.Add(Me.lbl_details6)
        Me.Controls.Add(Me.lbl_details6u)
        Me.Controls.Add(Me.txt_unit2)
        Me.Controls.Add(Me.lbl_details5)
        Me.Controls.Add(Me.lbl_details5u)
        Me.Controls.Add(Me.btn_calculate)
        Me.Controls.Add(Me.txt_birth)
        Me.Controls.Add(Me.lbl_details3)
        Me.Controls.Add(Me.txt_ID)
        Me.Controls.Add(Me.lbl_details)
        Me.Controls.Add(Me.lbl_name)
        Me.Controls.Add(Me.txt_unit1)
        Me.Controls.Add(Me.lbl_details4)
        Me.Controls.Add(Me.lbl_details4u)
        Me.Controls.Add(Me.btn_save)
        Me.Controls.Add(Me.cbo_name)
        Me.Controls.Add(Me.txt_name)
        Me.Controls.Add(Me.lbl_details2)
        Me.Controls.Add(Me.btn_add)
        Me.Name = "Form1"
        Me.Text = "Grade Calculator"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btn_add As System.Windows.Forms.Button
    Friend WithEvents lbl_details2 As System.Windows.Forms.Label
    Friend WithEvents txt_name As System.Windows.Forms.TextBox
    Friend WithEvents cbo_name As System.Windows.Forms.ComboBox
    Friend WithEvents btn_save As System.Windows.Forms.Button
    Friend WithEvents lbl_details4u As System.Windows.Forms.Label
    Friend WithEvents txt_unit1 As System.Windows.Forms.TextBox
    Friend WithEvents lbl_details4 As System.Windows.Forms.Label
    Friend WithEvents lbl_name As System.Windows.Forms.Label
    Friend WithEvents txt_ID As System.Windows.Forms.TextBox
    Friend WithEvents lbl_details As System.Windows.Forms.Label
    Friend WithEvents txt_birth As System.Windows.Forms.TextBox
    Friend WithEvents lbl_details3 As System.Windows.Forms.Label
    Friend WithEvents btn_calculate As System.Windows.Forms.Button
    Friend WithEvents txt_unit2 As System.Windows.Forms.TextBox
    Friend WithEvents lbl_details5 As System.Windows.Forms.Label
    Friend WithEvents lbl_details5u As System.Windows.Forms.Label
    Friend WithEvents txt_unit3 As System.Windows.Forms.TextBox
    Friend WithEvents lbl_details6 As System.Windows.Forms.Label
    Friend WithEvents lbl_details6u As System.Windows.Forms.Label
    Friend WithEvents txt_unit1g As System.Windows.Forms.TextBox
    Friend WithEvents lbl_details4g As System.Windows.Forms.Label
    Friend WithEvents lbl_details5g As System.Windows.Forms.Label
    Friend WithEvents txt_unit2g As System.Windows.Forms.TextBox
    Friend WithEvents lbl_details6g As System.Windows.Forms.Label
    Friend WithEvents txt_unit3g As System.Windows.Forms.TextBox
    Friend WithEvents lbl_marks As System.Windows.Forms.Label
    Friend WithEvents lbl_total As System.Windows.Forms.Label
    Friend WithEvents lbl_output As System.Windows.Forms.Label
    Friend WithEvents lbl_result As System.Windows.Forms.Label

End Class
