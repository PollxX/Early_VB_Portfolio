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
        Me.lbl_check = New System.Windows.Forms.Label()
        Me.txt_name = New System.Windows.Forms.TextBox()
        Me.txt_check = New System.Windows.Forms.TextBox()
        Me.btn_check = New System.Windows.Forms.Button()
        Me.btn_clear_che = New System.Windows.Forms.Button()
        Me.btn_save_che = New System.Windows.Forms.Button()
        Me.cbo_user = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lbl_num1 = New System.Windows.Forms.Label()
        Me.lbl_upp1 = New System.Windows.Forms.Label()
        Me.lbl_low1 = New System.Windows.Forms.Label()
        Me.lbl_num2 = New System.Windows.Forms.Label()
        Me.lbl_upp2 = New System.Windows.Forms.Label()
        Me.lbl_low2 = New System.Windows.Forms.Label()
        Me.lbl_sym1 = New System.Windows.Forms.Label()
        Me.lbl_sym2 = New System.Windows.Forms.Label()
        Me.btn_disp1 = New System.Windows.Forms.Button()
        Me.lbl_password2 = New System.Windows.Forms.Label()
        Me.lbl_password1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lbl_check
        '
        Me.lbl_check.AutoSize = True
        Me.lbl_check.Location = New System.Drawing.Point(61, 9)
        Me.lbl_check.Name = "lbl_check"
        Me.lbl_check.Size = New System.Drawing.Size(133, 13)
        Me.lbl_check.TabIndex = 0
        Me.lbl_check.Text = "Enter Name and Password"
        '
        'txt_name
        '
        Me.txt_name.Location = New System.Drawing.Point(66, 56)
        Me.txt_name.Name = "txt_name"
        Me.txt_name.Size = New System.Drawing.Size(145, 20)
        Me.txt_name.TabIndex = 1
        '
        'txt_check
        '
        Me.txt_check.Location = New System.Drawing.Point(66, 82)
        Me.txt_check.Name = "txt_check"
        Me.txt_check.Size = New System.Drawing.Size(145, 20)
        Me.txt_check.TabIndex = 10
        '
        'btn_check
        '
        Me.btn_check.Location = New System.Drawing.Point(66, 108)
        Me.btn_check.Name = "btn_check"
        Me.btn_check.Size = New System.Drawing.Size(50, 23)
        Me.btn_check.TabIndex = 11
        Me.btn_check.Text = "Check"
        Me.btn_check.UseVisualStyleBackColor = True
        '
        'btn_clear_che
        '
        Me.btn_clear_che.Location = New System.Drawing.Point(169, 108)
        Me.btn_clear_che.Name = "btn_clear_che"
        Me.btn_clear_che.Size = New System.Drawing.Size(42, 23)
        Me.btn_clear_che.TabIndex = 12
        Me.btn_clear_che.Text = "Clear"
        Me.btn_clear_che.UseVisualStyleBackColor = True
        '
        'btn_save_che
        '
        Me.btn_save_che.Location = New System.Drawing.Point(122, 108)
        Me.btn_save_che.Name = "btn_save_che"
        Me.btn_save_che.Size = New System.Drawing.Size(41, 23)
        Me.btn_save_che.TabIndex = 17
        Me.btn_save_che.Text = "Save"
        Me.btn_save_che.UseVisualStyleBackColor = True
        '
        'cbo_user
        '
        Me.cbo_user.FormattingEnabled = True
        Me.cbo_user.Location = New System.Drawing.Point(66, 30)
        Me.cbo_user.Name = "cbo_user"
        Me.cbo_user.Size = New System.Drawing.Size(145, 21)
        Me.cbo_user.TabIndex = 21
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 59)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(55, 13)
        Me.Label1.TabIndex = 22
        Me.Label1.Text = "Username"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(6, 87)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(53, 13)
        Me.Label2.TabIndex = 23
        Me.Label2.Text = "Password"
        '
        'lbl_num1
        '
        Me.lbl_num1.AutoSize = True
        Me.lbl_num1.Location = New System.Drawing.Point(12, 153)
        Me.lbl_num1.Name = "lbl_num1"
        Me.lbl_num1.Size = New System.Drawing.Size(52, 13)
        Me.lbl_num1.TabIndex = 24
        Me.lbl_num1.Text = "Numbers:"
        '
        'lbl_upp1
        '
        Me.lbl_upp1.AutoSize = True
        Me.lbl_upp1.Location = New System.Drawing.Point(12, 166)
        Me.lbl_upp1.Name = "lbl_upp1"
        Me.lbl_upp1.Size = New System.Drawing.Size(62, 13)
        Me.lbl_upp1.TabIndex = 25
        Me.lbl_upp1.Text = "Uppercase:"
        '
        'lbl_low1
        '
        Me.lbl_low1.AutoSize = True
        Me.lbl_low1.Location = New System.Drawing.Point(12, 179)
        Me.lbl_low1.Name = "lbl_low1"
        Me.lbl_low1.Size = New System.Drawing.Size(62, 13)
        Me.lbl_low1.TabIndex = 26
        Me.lbl_low1.Text = "Lowercase:"
        '
        'lbl_num2
        '
        Me.lbl_num2.AutoSize = True
        Me.lbl_num2.Location = New System.Drawing.Point(80, 153)
        Me.lbl_num2.Name = "lbl_num2"
        Me.lbl_num2.Size = New System.Drawing.Size(48, 13)
        Me.lbl_num2.TabIndex = 27
        Me.lbl_num2.Text = "Test me."
        '
        'lbl_upp2
        '
        Me.lbl_upp2.AutoSize = True
        Me.lbl_upp2.Location = New System.Drawing.Point(80, 166)
        Me.lbl_upp2.Name = "lbl_upp2"
        Me.lbl_upp2.Size = New System.Drawing.Size(48, 13)
        Me.lbl_upp2.TabIndex = 28
        Me.lbl_upp2.Text = "Test me."
        '
        'lbl_low2
        '
        Me.lbl_low2.AutoSize = True
        Me.lbl_low2.Location = New System.Drawing.Point(80, 179)
        Me.lbl_low2.Name = "lbl_low2"
        Me.lbl_low2.Size = New System.Drawing.Size(48, 13)
        Me.lbl_low2.TabIndex = 29
        Me.lbl_low2.Text = "Test me."
        '
        'lbl_sym1
        '
        Me.lbl_sym1.AutoSize = True
        Me.lbl_sym1.Location = New System.Drawing.Point(12, 192)
        Me.lbl_sym1.Name = "lbl_sym1"
        Me.lbl_sym1.Size = New System.Drawing.Size(49, 13)
        Me.lbl_sym1.TabIndex = 30
        Me.lbl_sym1.Text = "Symbols:"
        '
        'lbl_sym2
        '
        Me.lbl_sym2.AutoSize = True
        Me.lbl_sym2.Location = New System.Drawing.Point(80, 192)
        Me.lbl_sym2.Name = "lbl_sym2"
        Me.lbl_sym2.Size = New System.Drawing.Size(48, 13)
        Me.lbl_sym2.TabIndex = 31
        Me.lbl_sym2.Text = "Test me."
        '
        'btn_disp1
        '
        Me.btn_disp1.Location = New System.Drawing.Point(64, 278)
        Me.btn_disp1.Name = "btn_disp1"
        Me.btn_disp1.Size = New System.Drawing.Size(158, 23)
        Me.btn_disp1.TabIndex = 32
        Me.btn_disp1.Text = "Display Password Generator"
        Me.btn_disp1.UseVisualStyleBackColor = True
        '
        'lbl_password2
        '
        Me.lbl_password2.AutoSize = True
        Me.lbl_password2.Location = New System.Drawing.Point(139, 239)
        Me.lbl_password2.Name = "lbl_password2"
        Me.lbl_password2.Size = New System.Drawing.Size(49, 13)
        Me.lbl_password2.TabIndex = 34
        Me.lbl_password2.Text = "--------------"
        '
        'lbl_password1
        '
        Me.lbl_password1.AutoSize = True
        Me.lbl_password1.Location = New System.Drawing.Point(78, 239)
        Me.lbl_password1.Name = "lbl_password1"
        Me.lbl_password1.Size = New System.Drawing.Size(50, 13)
        Me.lbl_password1.TabIndex = 33
        Me.lbl_password1.Text = "Strength:"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(289, 313)
        Me.Controls.Add(Me.lbl_password2)
        Me.Controls.Add(Me.lbl_password1)
        Me.Controls.Add(Me.btn_disp1)
        Me.Controls.Add(Me.lbl_sym2)
        Me.Controls.Add(Me.lbl_sym1)
        Me.Controls.Add(Me.lbl_low2)
        Me.Controls.Add(Me.lbl_upp2)
        Me.Controls.Add(Me.lbl_num2)
        Me.Controls.Add(Me.lbl_low1)
        Me.Controls.Add(Me.lbl_upp1)
        Me.Controls.Add(Me.lbl_num1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cbo_user)
        Me.Controls.Add(Me.btn_save_che)
        Me.Controls.Add(Me.btn_clear_che)
        Me.Controls.Add(Me.btn_check)
        Me.Controls.Add(Me.txt_check)
        Me.Controls.Add(Me.txt_name)
        Me.Controls.Add(Me.lbl_check)
        Me.Name = "Form1"
        Me.Text = "Password Checker"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lbl_check As System.Windows.Forms.Label
    Friend WithEvents txt_name As System.Windows.Forms.TextBox
    Friend WithEvents txt_check As System.Windows.Forms.TextBox
    Friend WithEvents btn_check As System.Windows.Forms.Button
    Friend WithEvents btn_clear_che As System.Windows.Forms.Button
    Friend WithEvents btn_save_che As System.Windows.Forms.Button
    Friend WithEvents cbo_user As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents lbl_num1 As System.Windows.Forms.Label
    Friend WithEvents lbl_upp1 As System.Windows.Forms.Label
    Friend WithEvents lbl_low1 As System.Windows.Forms.Label
    Friend WithEvents lbl_num2 As System.Windows.Forms.Label
    Friend WithEvents lbl_upp2 As System.Windows.Forms.Label
    Friend WithEvents lbl_low2 As System.Windows.Forms.Label
    Friend WithEvents lbl_sym1 As System.Windows.Forms.Label
    Friend WithEvents lbl_sym2 As System.Windows.Forms.Label
    Friend WithEvents btn_disp1 As System.Windows.Forms.Button
    Friend WithEvents lbl_password2 As System.Windows.Forms.Label
    Friend WithEvents lbl_password1 As System.Windows.Forms.Label

End Class
