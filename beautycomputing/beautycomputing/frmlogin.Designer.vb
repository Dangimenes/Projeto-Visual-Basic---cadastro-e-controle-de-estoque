<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmlogin
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmlogin))
        Me.cbotipo = New System.Windows.Forms.ComboBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.Cancel = New System.Windows.Forms.Button
        Me.OK = New System.Windows.Forms.Button
        Me.txtsenha = New System.Windows.Forms.TextBox
        Me.txtlogin = New System.Windows.Forms.TextBox
        Me.PasswordLabel = New System.Windows.Forms.Label
        Me.UsernameLabel = New System.Windows.Forms.Label
        Me.SuspendLayout()
        '
        'cbotipo
        '
        Me.cbotipo.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.cbotipo.FormattingEnabled = True
        Me.cbotipo.Location = New System.Drawing.Point(199, 134)
        Me.cbotipo.Name = "cbotipo"
        Me.cbotipo.Size = New System.Drawing.Size(167, 21)
        Me.cbotipo.TabIndex = 3
        Me.cbotipo.Text = "Escolha um Tipo de Login"
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label1.Location = New System.Drawing.Point(196, 113)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(86, 18)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Tipo de Login"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Cancel
        '
        Me.Cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Cancel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Cancel.Location = New System.Drawing.Point(291, 172)
        Me.Cancel.Name = "Cancel"
        Me.Cancel.Size = New System.Drawing.Size(77, 23)
        Me.Cancel.TabIndex = 5
        Me.Cancel.Text = "&Sair"
        '
        'OK
        '
        Me.OK.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.OK.Location = New System.Drawing.Point(199, 172)
        Me.OK.Name = "OK"
        Me.OK.Size = New System.Drawing.Size(74, 23)
        Me.OK.TabIndex = 4
        Me.OK.Text = "&OK"
        '
        'txtsenha
        '
        Me.txtsenha.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.txtsenha.Location = New System.Drawing.Point(199, 85)
        Me.txtsenha.MaxLength = 255
        Me.txtsenha.Name = "txtsenha"
        Me.txtsenha.Size = New System.Drawing.Size(169, 20)
        Me.txtsenha.TabIndex = 2
        Me.txtsenha.UseSystemPasswordChar = True
        '
        'txtlogin
        '
        Me.txtlogin.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.txtlogin.Location = New System.Drawing.Point(201, 41)
        Me.txtlogin.MaxLength = 255
        Me.txtlogin.Name = "txtlogin"
        Me.txtlogin.Size = New System.Drawing.Size(169, 20)
        Me.txtlogin.TabIndex = 1
        '
        'PasswordLabel
        '
        Me.PasswordLabel.BackColor = System.Drawing.Color.Transparent
        Me.PasswordLabel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.PasswordLabel.Location = New System.Drawing.Point(196, 64)
        Me.PasswordLabel.Name = "PasswordLabel"
        Me.PasswordLabel.Size = New System.Drawing.Size(42, 18)
        Me.PasswordLabel.TabIndex = 0
        Me.PasswordLabel.Text = "Senha"
        Me.PasswordLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'UsernameLabel
        '
        Me.UsernameLabel.BackColor = System.Drawing.Color.Transparent
        Me.UsernameLabel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.UsernameLabel.Location = New System.Drawing.Point(198, 20)
        Me.UsernameLabel.Name = "UsernameLabel"
        Me.UsernameLabel.Size = New System.Drawing.Size(42, 18)
        Me.UsernameLabel.TabIndex = 0
        Me.UsernameLabel.Text = "Login"
        Me.UsernameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'frmlogin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.beautycomputing.My.Resources.Resources.bg101
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(393, 219)
        Me.Controls.Add(Me.cbotipo)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Cancel)
        Me.Controls.Add(Me.OK)
        Me.Controls.Add(Me.txtsenha)
        Me.Controls.Add(Me.txtlogin)
        Me.Controls.Add(Me.PasswordLabel)
        Me.Controls.Add(Me.UsernameLabel)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmlogin"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmlogin"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cbotipo As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Cancel As System.Windows.Forms.Button
    Friend WithEvents OK As System.Windows.Forms.Button
    Friend WithEvents txtsenha As System.Windows.Forms.TextBox
    Friend WithEvents txtlogin As System.Windows.Forms.TextBox
    Friend WithEvents PasswordLabel As System.Windows.Forms.Label
    Friend WithEvents UsernameLabel As System.Windows.Forms.Label
End Class
