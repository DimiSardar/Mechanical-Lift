<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Eisodos
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
        Me.EjodosBtn = New System.Windows.Forms.Button()
        Me.EisodosBtn = New System.Windows.Forms.Button()
        Me.KwdikosXrhsthBox = New System.Windows.Forms.TextBox()
        Me.OnomaXrhsthBox = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.EgrafhBtn = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'EjodosBtn
        '
        Me.EjodosBtn.BackColor = System.Drawing.SystemColors.HotTrack
        Me.EjodosBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.EjodosBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
        Me.EjodosBtn.Location = New System.Drawing.Point(550, 225)
        Me.EjodosBtn.Name = "EjodosBtn"
        Me.EjodosBtn.Size = New System.Drawing.Size(100, 40)
        Me.EjodosBtn.TabIndex = 12
        Me.EjodosBtn.Text = "Έξοδος"
        Me.EjodosBtn.UseVisualStyleBackColor = False
        '
        'EisodosBtn
        '
        Me.EisodosBtn.BackColor = System.Drawing.SystemColors.HotTrack
        Me.EisodosBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.EisodosBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
        Me.EisodosBtn.ForeColor = System.Drawing.Color.Black
        Me.EisodosBtn.Location = New System.Drawing.Point(403, 225)
        Me.EisodosBtn.Name = "EisodosBtn"
        Me.EisodosBtn.Size = New System.Drawing.Size(100, 40)
        Me.EisodosBtn.TabIndex = 13
        Me.EisodosBtn.Text = "Είσοδος"
        Me.EisodosBtn.UseVisualStyleBackColor = False
        '
        'KwdikosXrhsthBox
        '
        Me.KwdikosXrhsthBox.Location = New System.Drawing.Point(578, 143)
        Me.KwdikosXrhsthBox.Name = "KwdikosXrhsthBox"
        Me.KwdikosXrhsthBox.Size = New System.Drawing.Size(100, 20)
        Me.KwdikosXrhsthBox.TabIndex = 9
        Me.KwdikosXrhsthBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'OnomaXrhsthBox
        '
        Me.OnomaXrhsthBox.Location = New System.Drawing.Point(578, 88)
        Me.OnomaXrhsthBox.Name = "OnomaXrhsthBox"
        Me.OnomaXrhsthBox.Size = New System.Drawing.Size(100, 20)
        Me.OnomaXrhsthBox.TabIndex = 11
        Me.OnomaXrhsthBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label3.Location = New System.Drawing.Point(378, 144)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(67, 16)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Κωδικός:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label1.Location = New System.Drawing.Point(378, 89)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(112, 16)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "Όνομα Χρήστη:"
        '
        'EgrafhBtn
        '
        Me.EgrafhBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.EgrafhBtn.FlatAppearance.BorderColor = System.Drawing.Color.DodgerBlue
        Me.EgrafhBtn.FlatAppearance.BorderSize = 0
        Me.EgrafhBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.EgrafhBtn.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.EgrafhBtn.Location = New System.Drawing.Point(648, 319)
        Me.EgrafhBtn.Name = "EgrafhBtn"
        Me.EgrafhBtn.Size = New System.Drawing.Size(75, 23)
        Me.EgrafhBtn.TabIndex = 15
        Me.EgrafhBtn.Text = "Εγγραφή"
        Me.EgrafhBtn.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.White
        Me.PictureBox1.Image = Global.Μηχανικός_Ανελκυστήρας.My.Resources.Resources._65_651790_user_icon_login_logo
        Me.PictureBox1.Location = New System.Drawing.Point(33, 32)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(291, 291)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 14
        Me.PictureBox1.TabStop = False
        '
        'Eisodos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DodgerBlue
        Me.ClientSize = New System.Drawing.Size(735, 354)
        Me.Controls.Add(Me.EgrafhBtn)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.EjodosBtn)
        Me.Controls.Add(Me.EisodosBtn)
        Me.Controls.Add(Me.KwdikosXrhsthBox)
        Me.Controls.Add(Me.OnomaXrhsthBox)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Eisodos"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Login Form"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents EjodosBtn As Button
    Friend WithEvents EisodosBtn As Button
    Friend WithEvents KwdikosXrhsthBox As TextBox
    Friend WithEvents OnomaXrhsthBox As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents EgrafhBtn As Button
End Class
