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
        Me.lbl_read_input = New System.Windows.Forms.Label()
        Me.txt_input = New System.Windows.Forms.TextBox()
        Me.btn_encrypt = New System.Windows.Forms.Button()
        Me.nud_shift = New System.Windows.Forms.NumericUpDown()
        Me.txt_output = New System.Windows.Forms.TextBox()
        Me.lbl_read_output = New System.Windows.Forms.Label()
        Me.btn_clear = New System.Windows.Forms.Button()
        Me.btn_decrypt = New System.Windows.Forms.Button()
        CType(Me.nud_shift, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lbl_read_input
        '
        Me.lbl_read_input.AutoSize = True
        Me.lbl_read_input.Location = New System.Drawing.Point(159, 20)
        Me.lbl_read_input.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbl_read_input.Name = "lbl_read_input"
        Me.lbl_read_input.Size = New System.Drawing.Size(235, 18)
        Me.lbl_read_input.TabIndex = 0
        Me.lbl_read_input.Text = "Type text below to encrypt/decrypt:"
        '
        'txt_input
        '
        Me.txt_input.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_input.Location = New System.Drawing.Point(164, 49)
        Me.txt_input.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txt_input.Multiline = True
        Me.txt_input.Name = "txt_input"
        Me.txt_input.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txt_input.Size = New System.Drawing.Size(385, 164)
        Me.txt_input.TabIndex = 1
        '
        'btn_encrypt
        '
        Me.btn_encrypt.Location = New System.Drawing.Point(22, 54)
        Me.btn_encrypt.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btn_encrypt.Name = "btn_encrypt"
        Me.btn_encrypt.Size = New System.Drawing.Size(112, 31)
        Me.btn_encrypt.TabIndex = 2
        Me.btn_encrypt.Text = "Encrypt"
        Me.btn_encrypt.UseVisualStyleBackColor = True
        '
        'nud_shift
        '
        Me.nud_shift.BackColor = System.Drawing.SystemColors.Window
        Me.nud_shift.Location = New System.Drawing.Point(22, 170)
        Me.nud_shift.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.nud_shift.Name = "nud_shift"
        Me.nud_shift.ReadOnly = True
        Me.nud_shift.Size = New System.Drawing.Size(62, 24)
        Me.nud_shift.TabIndex = 3
        '
        'txt_output
        '
        Me.txt_output.BackColor = System.Drawing.SystemColors.Window
        Me.txt_output.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_output.Location = New System.Drawing.Point(164, 268)
        Me.txt_output.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txt_output.Multiline = True
        Me.txt_output.Name = "txt_output"
        Me.txt_output.ReadOnly = True
        Me.txt_output.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txt_output.Size = New System.Drawing.Size(385, 164)
        Me.txt_output.TabIndex = 4
        '
        'lbl_read_output
        '
        Me.lbl_read_output.AutoSize = True
        Me.lbl_read_output.Location = New System.Drawing.Point(159, 241)
        Me.lbl_read_output.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbl_read_output.Name = "lbl_read_output"
        Me.lbl_read_output.Size = New System.Drawing.Size(215, 18)
        Me.lbl_read_output.TabIndex = 5
        Me.lbl_read_output.Text = "Result of encryption/decryption:"
        '
        'btn_clear
        '
        Me.btn_clear.Location = New System.Drawing.Point(22, 403)
        Me.btn_clear.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btn_clear.Name = "btn_clear"
        Me.btn_clear.Size = New System.Drawing.Size(112, 31)
        Me.btn_clear.TabIndex = 6
        Me.btn_clear.Text = "Clear"
        Me.btn_clear.UseVisualStyleBackColor = True
        '
        'btn_decrypt
        '
        Me.btn_decrypt.Location = New System.Drawing.Point(22, 111)
        Me.btn_decrypt.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btn_decrypt.Name = "btn_decrypt"
        Me.btn_decrypt.Size = New System.Drawing.Size(112, 31)
        Me.btn_decrypt.TabIndex = 7
        Me.btn_decrypt.Text = "Decrypt"
        Me.btn_decrypt.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(568, 452)
        Me.Controls.Add(Me.btn_decrypt)
        Me.Controls.Add(Me.btn_clear)
        Me.Controls.Add(Me.lbl_read_output)
        Me.Controls.Add(Me.txt_output)
        Me.Controls.Add(Me.nud_shift)
        Me.Controls.Add(Me.btn_encrypt)
        Me.Controls.Add(Me.txt_input)
        Me.Controls.Add(Me.lbl_read_input)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!)
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "Form1"
        Me.Text = "Caesar Cipher"
        CType(Me.nud_shift, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lbl_read_input As System.Windows.Forms.Label
    Friend WithEvents txt_input As System.Windows.Forms.TextBox
    Friend WithEvents btn_encrypt As System.Windows.Forms.Button
    Friend WithEvents nud_shift As System.Windows.Forms.NumericUpDown
    Friend WithEvents txt_output As System.Windows.Forms.TextBox
    Friend WithEvents lbl_read_output As System.Windows.Forms.Label
    Friend WithEvents btn_clear As System.Windows.Forms.Button
    Friend WithEvents btn_decrypt As System.Windows.Forms.Button

End Class
