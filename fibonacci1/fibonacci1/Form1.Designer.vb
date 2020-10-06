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
        Me.txt_input = New System.Windows.Forms.TextBox()
        Me.lbl_output1 = New System.Windows.Forms.Label()
        Me.btn_Start = New System.Windows.Forms.Button()
        Me.lbl_nthterm = New System.Windows.Forms.Label()
        Me.txt_sequence = New System.Windows.Forms.TextBox()
        Me.txt_sequence2 = New System.Windows.Forms.TextBox()
        Me.nud_counter1 = New System.Windows.Forms.NumericUpDown()
        Me.lbl_output2 = New System.Windows.Forms.Label()
        Me.lbl_specificterm = New System.Windows.Forms.Label()
        Me.btn_run2 = New System.Windows.Forms.Button()
        CType(Me.nud_counter1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txt_input
        '
        Me.txt_input.Location = New System.Drawing.Point(63, 49)
        Me.txt_input.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txt_input.Name = "txt_input"
        Me.txt_input.Size = New System.Drawing.Size(89, 23)
        Me.txt_input.TabIndex = 1
        Me.txt_input.Text = "1"
        '
        'lbl_output1
        '
        Me.lbl_output1.AutoSize = True
        Me.lbl_output1.Location = New System.Drawing.Point(56, 78)
        Me.lbl_output1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbl_output1.Name = "lbl_output1"
        Me.lbl_output1.Size = New System.Drawing.Size(55, 17)
        Me.lbl_output1.TabIndex = 3
        Me.lbl_output1.Text = "Output:"
        '
        'btn_Start
        '
        Me.btn_Start.Location = New System.Drawing.Point(161, 49)
        Me.btn_Start.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btn_Start.Name = "btn_Start"
        Me.btn_Start.Size = New System.Drawing.Size(76, 28)
        Me.btn_Start.TabIndex = 5
        Me.btn_Start.Text = "Start"
        Me.btn_Start.UseVisualStyleBackColor = True
        '
        'lbl_nthterm
        '
        Me.lbl_nthterm.AutoSize = True
        Me.lbl_nthterm.Location = New System.Drawing.Point(56, 30)
        Me.lbl_nthterm.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbl_nthterm.Name = "lbl_nthterm"
        Me.lbl_nthterm.Size = New System.Drawing.Size(116, 17)
        Me.lbl_nthterm.TabIndex = 11
        Me.lbl_nthterm.Text = "List until nth term"
        '
        'txt_sequence
        '
        Me.txt_sequence.BackColor = System.Drawing.Color.White
        Me.txt_sequence.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txt_sequence.Location = New System.Drawing.Point(60, 97)
        Me.txt_sequence.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txt_sequence.Multiline = True
        Me.txt_sequence.Name = "txt_sequence"
        Me.txt_sequence.ReadOnly = True
        Me.txt_sequence.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txt_sequence.Size = New System.Drawing.Size(216, 281)
        Me.txt_sequence.TabIndex = 12
        '
        'txt_sequence2
        '
        Me.txt_sequence2.BackColor = System.Drawing.Color.White
        Me.txt_sequence2.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txt_sequence2.Location = New System.Drawing.Point(63, 490)
        Me.txt_sequence2.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txt_sequence2.Multiline = True
        Me.txt_sequence2.Name = "txt_sequence2"
        Me.txt_sequence2.ReadOnly = True
        Me.txt_sequence2.Size = New System.Drawing.Size(188, 32)
        Me.txt_sequence2.TabIndex = 13
        Me.txt_sequence2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'nud_counter1
        '
        Me.nud_counter1.Location = New System.Drawing.Point(60, 442)
        Me.nud_counter1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.nud_counter1.Name = "nud_counter1"
        Me.nud_counter1.Size = New System.Drawing.Size(79, 23)
        Me.nud_counter1.TabIndex = 14
        Me.nud_counter1.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'lbl_output2
        '
        Me.lbl_output2.AutoSize = True
        Me.lbl_output2.Location = New System.Drawing.Point(59, 470)
        Me.lbl_output2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbl_output2.Name = "lbl_output2"
        Me.lbl_output2.Size = New System.Drawing.Size(55, 17)
        Me.lbl_output2.TabIndex = 15
        Me.lbl_output2.Text = "Output:"
        '
        'lbl_specificterm
        '
        Me.lbl_specificterm.AutoSize = True
        Me.lbl_specificterm.Location = New System.Drawing.Point(59, 418)
        Me.lbl_specificterm.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbl_specificterm.Name = "lbl_specificterm"
        Me.lbl_specificterm.Size = New System.Drawing.Size(137, 17)
        Me.lbl_specificterm.TabIndex = 16
        Me.lbl_specificterm.Text = "Display specific term"
        '
        'btn_run2
        '
        Me.btn_run2.Location = New System.Drawing.Point(148, 438)
        Me.btn_run2.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btn_run2.Name = "btn_run2"
        Me.btn_run2.Size = New System.Drawing.Size(64, 28)
        Me.btn_run2.TabIndex = 17
        Me.btn_run2.Text = "Run"
        Me.btn_run2.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(312, 560)
        Me.Controls.Add(Me.btn_run2)
        Me.Controls.Add(Me.lbl_specificterm)
        Me.Controls.Add(Me.lbl_output2)
        Me.Controls.Add(Me.nud_counter1)
        Me.Controls.Add(Me.txt_sequence2)
        Me.Controls.Add(Me.txt_sequence)
        Me.Controls.Add(Me.lbl_nthterm)
        Me.Controls.Add(Me.btn_Start)
        Me.Controls.Add(Me.lbl_output1)
        Me.Controls.Add(Me.txt_input)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "Form1"
        Me.Text = "Fibonacci Sequence"
        CType(Me.nud_counter1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txt_input As System.Windows.Forms.TextBox
    Friend WithEvents lbl_output1 As System.Windows.Forms.Label
    Friend WithEvents btn_Start As System.Windows.Forms.Button
    Friend WithEvents lbl_nthterm As System.Windows.Forms.Label
    Friend WithEvents txt_sequence As System.Windows.Forms.TextBox
    Friend WithEvents txt_sequence2 As System.Windows.Forms.TextBox
    Friend WithEvents nud_counter1 As System.Windows.Forms.NumericUpDown
    Friend WithEvents lbl_output2 As System.Windows.Forms.Label
    Friend WithEvents lbl_specificterm As System.Windows.Forms.Label
    Friend WithEvents btn_run2 As System.Windows.Forms.Button

End Class
