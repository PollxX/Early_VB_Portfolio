<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
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
        Me.lbl_Lid = New System.Windows.Forms.Label()
        Me.lbl_Lname = New System.Windows.Forms.Label()
        Me.lbl_Lbirth = New System.Windows.Forms.Label()
        Me.lbl_mbirth = New System.Windows.Forms.Label()
        Me.lbl_mname = New System.Windows.Forms.Label()
        Me.lbl_mID = New System.Windows.Forms.Label()
        Me.lbl_S2 = New System.Windows.Forms.Label()
        Me.lbl_S1 = New System.Windows.Forms.Label()
        Me.lbl_S3 = New System.Windows.Forms.Label()
        Me.lbl_Lu3 = New System.Windows.Forms.Label()
        Me.lbl_Lu2 = New System.Windows.Forms.Label()
        Me.lbl_Lu1 = New System.Windows.Forms.Label()
        Me.lbl_award = New System.Windows.Forms.Label()
        Me.lbl_grade = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lbl_Lid
        '
        Me.lbl_Lid.AutoSize = True
        Me.lbl_Lid.Location = New System.Drawing.Point(33, 10)
        Me.lbl_Lid.Name = "lbl_Lid"
        Me.lbl_Lid.Size = New System.Drawing.Size(61, 13)
        Me.lbl_Lid.TabIndex = 45
        Me.lbl_Lid.Text = "Student ID:"
        '
        'lbl_Lname
        '
        Me.lbl_Lname.AutoSize = True
        Me.lbl_Lname.Location = New System.Drawing.Point(16, 23)
        Me.lbl_Lname.Name = "lbl_Lname"
        Me.lbl_Lname.Size = New System.Drawing.Size(78, 13)
        Me.lbl_Lname.TabIndex = 46
        Me.lbl_Lname.Text = "Student Name:"
        '
        'lbl_Lbirth
        '
        Me.lbl_Lbirth.AutoSize = True
        Me.lbl_Lbirth.Location = New System.Drawing.Point(25, 36)
        Me.lbl_Lbirth.Name = "lbl_Lbirth"
        Me.lbl_Lbirth.Size = New System.Drawing.Size(69, 13)
        Me.lbl_Lbirth.TabIndex = 48
        Me.lbl_Lbirth.Text = "Date of Birth:"
        '
        'lbl_mbirth
        '
        Me.lbl_mbirth.AutoSize = True
        Me.lbl_mbirth.Location = New System.Drawing.Point(100, 35)
        Me.lbl_mbirth.Name = "lbl_mbirth"
        Me.lbl_mbirth.Size = New System.Drawing.Size(27, 13)
        Me.lbl_mbirth.TabIndex = 52
        Me.lbl_mbirth.Text = "birth"
        '
        'lbl_mname
        '
        Me.lbl_mname.AutoSize = True
        Me.lbl_mname.Location = New System.Drawing.Point(100, 22)
        Me.lbl_mname.Name = "lbl_mname"
        Me.lbl_mname.Size = New System.Drawing.Size(33, 13)
        Me.lbl_mname.TabIndex = 50
        Me.lbl_mname.Text = "name"
        '
        'lbl_mID
        '
        Me.lbl_mID.AutoSize = True
        Me.lbl_mID.Location = New System.Drawing.Point(100, 9)
        Me.lbl_mID.Name = "lbl_mID"
        Me.lbl_mID.Size = New System.Drawing.Size(15, 13)
        Me.lbl_mID.TabIndex = 49
        Me.lbl_mID.Text = "id"
        '
        'lbl_S2
        '
        Me.lbl_S2.AutoSize = True
        Me.lbl_S2.Location = New System.Drawing.Point(83, 97)
        Me.lbl_S2.Name = "lbl_S2"
        Me.lbl_S2.Size = New System.Drawing.Size(39, 13)
        Me.lbl_S2.TabIndex = 57
        Me.lbl_S2.Text = "score2"
        '
        'lbl_S1
        '
        Me.lbl_S1.AutoSize = True
        Me.lbl_S1.Location = New System.Drawing.Point(25, 97)
        Me.lbl_S1.Name = "lbl_S1"
        Me.lbl_S1.Size = New System.Drawing.Size(39, 13)
        Me.lbl_S1.TabIndex = 54
        Me.lbl_S1.Text = "score1"
        '
        'lbl_S3
        '
        Me.lbl_S3.AutoSize = True
        Me.lbl_S3.Location = New System.Drawing.Point(148, 97)
        Me.lbl_S3.Name = "lbl_S3"
        Me.lbl_S3.Size = New System.Drawing.Size(39, 13)
        Me.lbl_S3.TabIndex = 60
        Me.lbl_S3.Text = "score3"
        '
        'lbl_Lu3
        '
        Me.lbl_Lu3.AutoSize = True
        Me.lbl_Lu3.Location = New System.Drawing.Point(148, 67)
        Me.lbl_Lu3.Name = "lbl_Lu3"
        Me.lbl_Lu3.Size = New System.Drawing.Size(32, 13)
        Me.lbl_Lu3.TabIndex = 64
        Me.lbl_Lu3.Text = "Unit3"
        '
        'lbl_Lu2
        '
        Me.lbl_Lu2.AutoSize = True
        Me.lbl_Lu2.Location = New System.Drawing.Point(83, 67)
        Me.lbl_Lu2.Name = "lbl_Lu2"
        Me.lbl_Lu2.Size = New System.Drawing.Size(32, 13)
        Me.lbl_Lu2.TabIndex = 63
        Me.lbl_Lu2.Text = "Unit2"
        '
        'lbl_Lu1
        '
        Me.lbl_Lu1.AutoSize = True
        Me.lbl_Lu1.Location = New System.Drawing.Point(25, 67)
        Me.lbl_Lu1.Name = "lbl_Lu1"
        Me.lbl_Lu1.Size = New System.Drawing.Size(32, 13)
        Me.lbl_Lu1.TabIndex = 62
        Me.lbl_Lu1.Text = "Unit1"
        '
        'lbl_award
        '
        Me.lbl_award.AutoSize = True
        Me.lbl_award.Location = New System.Drawing.Point(74, 175)
        Me.lbl_award.Name = "lbl_award"
        Me.lbl_award.Size = New System.Drawing.Size(120, 13)
        Me.lbl_award.TabIndex = 65
        Me.lbl_award.Text = "You've been awarded a"
        '
        'lbl_grade
        '
        Me.lbl_grade.AutoSize = True
        Me.lbl_grade.Font = New System.Drawing.Font("Rockwell", 20.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_grade.Location = New System.Drawing.Point(60, 198)
        Me.lbl_grade.Name = "lbl_grade"
        Me.lbl_grade.Size = New System.Drawing.Size(165, 30)
        Me.lbl_grade.TabIndex = 66
        Me.lbl_grade.Text = "GRADEHERE"
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 262)
        Me.Controls.Add(Me.lbl_grade)
        Me.Controls.Add(Me.lbl_award)
        Me.Controls.Add(Me.lbl_Lu3)
        Me.Controls.Add(Me.lbl_Lu2)
        Me.Controls.Add(Me.lbl_Lu1)
        Me.Controls.Add(Me.lbl_S3)
        Me.Controls.Add(Me.lbl_S2)
        Me.Controls.Add(Me.lbl_S1)
        Me.Controls.Add(Me.lbl_mbirth)
        Me.Controls.Add(Me.lbl_mname)
        Me.Controls.Add(Me.lbl_mID)
        Me.Controls.Add(Me.lbl_Lbirth)
        Me.Controls.Add(Me.lbl_Lname)
        Me.Controls.Add(Me.lbl_Lid)
        Me.Name = "Form2"
        Me.Text = "Certificate"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lbl_Lid As System.Windows.Forms.Label
    Friend WithEvents lbl_Lname As System.Windows.Forms.Label
    Friend WithEvents lbl_Lbirth As System.Windows.Forms.Label
    Friend WithEvents lbl_mbirth As System.Windows.Forms.Label
    Friend WithEvents lbl_mname As System.Windows.Forms.Label
    Friend WithEvents lbl_mID As System.Windows.Forms.Label
    Friend WithEvents lbl_S2 As System.Windows.Forms.Label
    Friend WithEvents lbl_S1 As System.Windows.Forms.Label
    Friend WithEvents lbl_S3 As System.Windows.Forms.Label
    Friend WithEvents lbl_Lu3 As System.Windows.Forms.Label
    Friend WithEvents lbl_Lu2 As System.Windows.Forms.Label
    Friend WithEvents lbl_Lu1 As System.Windows.Forms.Label
    Friend WithEvents lbl_award As System.Windows.Forms.Label
    Friend WithEvents lbl_grade As System.Windows.Forms.Label
End Class
