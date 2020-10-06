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
        Me.btn_gen = New System.Windows.Forms.Button()
        Me.btn_clear_gen = New System.Windows.Forms.Button()
        Me.lbl_gen = New System.Windows.Forms.Label()
        Me.txt_gen = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btn_gen
        '
        Me.btn_gen.Location = New System.Drawing.Point(79, 87)
        Me.btn_gen.Name = "btn_gen"
        Me.btn_gen.Size = New System.Drawing.Size(62, 23)
        Me.btn_gen.TabIndex = 23
        Me.btn_gen.Text = "Generate"
        Me.btn_gen.UseVisualStyleBackColor = True
        '
        'btn_clear_gen
        '
        Me.btn_clear_gen.Location = New System.Drawing.Point(147, 87)
        Me.btn_clear_gen.Name = "btn_clear_gen"
        Me.btn_clear_gen.Size = New System.Drawing.Size(50, 23)
        Me.btn_clear_gen.TabIndex = 22
        Me.btn_clear_gen.Text = "Clear"
        Me.btn_clear_gen.UseVisualStyleBackColor = True
        '
        'lbl_gen
        '
        Me.lbl_gen.AutoSize = True
        Me.lbl_gen.Location = New System.Drawing.Point(42, 35)
        Me.lbl_gen.Name = "lbl_gen"
        Me.lbl_gen.Size = New System.Drawing.Size(103, 13)
        Me.lbl_gen.TabIndex = 20
        Me.lbl_gen.Text = "Password Generator"
        '
        'txt_gen
        '
        Me.txt_gen.Location = New System.Drawing.Point(45, 61)
        Me.txt_gen.Name = "txt_gen"
        Me.txt_gen.ReadOnly = True
        Me.txt_gen.Size = New System.Drawing.Size(176, 20)
        Me.txt_gen.TabIndex = 19
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(42, 123)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(155, 26)
        Me.Label1.TabIndex = 24
        Me.Label1.Text = "Note: When generated, the " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "password is saved to clipboard."
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(256, 158)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btn_gen)
        Me.Controls.Add(Me.btn_clear_gen)
        Me.Controls.Add(Me.lbl_gen)
        Me.Controls.Add(Me.txt_gen)
        Me.Name = "Form2"
        Me.Text = "Password Generator"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btn_gen As System.Windows.Forms.Button
    Friend WithEvents btn_clear_gen As System.Windows.Forms.Button
    Friend WithEvents lbl_gen As System.Windows.Forms.Label
    Friend WithEvents txt_gen As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
End Class
