<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
<Global.System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1726")> _
Partial Class login
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
    Friend WithEvents UsernameLabel As System.Windows.Forms.Label
    Friend WithEvents PasswordLabel As System.Windows.Forms.Label
    Friend WithEvents txtlogin As System.Windows.Forms.TextBox
    Friend WithEvents txtsenha As System.Windows.Forms.TextBox
    Friend WithEvents btnsair As System.Windows.Forms.Button

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.UsernameLabel = New System.Windows.Forms.Label
        Me.PasswordLabel = New System.Windows.Forms.Label
        Me.txtlogin = New System.Windows.Forms.TextBox
        Me.txtsenha = New System.Windows.Forms.TextBox
        Me.btnsair = New System.Windows.Forms.Button
        Me.btnok = New System.Windows.Forms.Button
        Me.Label1 = New System.Windows.Forms.Label
        Me.cbotipo = New System.Windows.Forms.ComboBox
        Me.SuspendLayout()
        '
        'UsernameLabel
        '
        Me.UsernameLabel.BackColor = System.Drawing.Color.Transparent
        Me.UsernameLabel.ForeColor = System.Drawing.SystemColors.ControlText
        Me.UsernameLabel.Location = New System.Drawing.Point(162, 11)
        Me.UsernameLabel.Name = "UsernameLabel"
        Me.UsernameLabel.Size = New System.Drawing.Size(220, 23)
        Me.UsernameLabel.TabIndex = 0
        Me.UsernameLabel.Text = "&Login"
        Me.UsernameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'PasswordLabel
        '
        Me.PasswordLabel.BackColor = System.Drawing.Color.Transparent
        Me.PasswordLabel.ForeColor = System.Drawing.SystemColors.ControlText
        Me.PasswordLabel.Location = New System.Drawing.Point(163, 51)
        Me.PasswordLabel.Name = "PasswordLabel"
        Me.PasswordLabel.Size = New System.Drawing.Size(220, 23)
        Me.PasswordLabel.TabIndex = 2
        Me.PasswordLabel.Text = "&Senha"
        Me.PasswordLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtlogin
        '
        Me.txtlogin.Location = New System.Drawing.Point(164, 31)
        Me.txtlogin.Name = "txtlogin"
        Me.txtlogin.Size = New System.Drawing.Size(152, 20)
        Me.txtlogin.TabIndex = 1
        '
        'txtsenha
        '
        Me.txtsenha.Location = New System.Drawing.Point(165, 71)
        Me.txtsenha.Name = "txtsenha"
        Me.txtsenha.Size = New System.Drawing.Size(151, 20)
        Me.txtsenha.TabIndex = 3
        Me.txtsenha.UseSystemPasswordChar = True
        '
        'btnsair
        '
        Me.btnsair.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.btnsair.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnsair.Location = New System.Drawing.Point(266, 148)
        Me.btnsair.Name = "btnsair"
        Me.btnsair.Size = New System.Drawing.Size(94, 23)
        Me.btnsair.TabIndex = 5
        Me.btnsair.Text = "&Sair"
        Me.btnsair.UseVisualStyleBackColor = False
        '
        'btnok
        '
        Me.btnok.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.btnok.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnok.Location = New System.Drawing.Point(165, 148)
        Me.btnok.Name = "btnok"
        Me.btnok.Size = New System.Drawing.Size(94, 23)
        Me.btnok.TabIndex = 6
        Me.btnok.Text = "&Entrar"
        Me.btnok.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label1.Location = New System.Drawing.Point(163, 94)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(28, 13)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "Tipo"
        '
        'cbotipo
        '
        Me.cbotipo.FormattingEnabled = True
        Me.cbotipo.Location = New System.Drawing.Point(166, 110)
        Me.cbotipo.Name = "cbotipo"
        Me.cbotipo.Size = New System.Drawing.Size(150, 21)
        Me.cbotipo.TabIndex = 8
        Me.cbotipo.Text = "Escolha um Tipo de Login"
        '
        'login
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.CancelButton = Me.btnsair
        Me.ClientSize = New System.Drawing.Size(368, 206)
        Me.ControlBox = False
        Me.Controls.Add(Me.cbotipo)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnok)
        Me.Controls.Add(Me.btnsair)
        Me.Controls.Add(Me.txtsenha)
        Me.Controls.Add(Me.txtlogin)
        Me.Controls.Add(Me.PasswordLabel)
        Me.Controls.Add(Me.UsernameLabel)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "login"
        Me.Opacity = 0.9
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Login e Senha "
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnok As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cbotipo As System.Windows.Forms.ComboBox

End Class
