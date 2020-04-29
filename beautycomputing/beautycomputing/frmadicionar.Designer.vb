<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmadicionar
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmadicionar))
        Me.btnsair = New System.Windows.Forms.Button
        Me.cbotipo = New System.Windows.Forms.ComboBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.txtconfirmasenha = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.txtsenha = New System.Windows.Forms.TextBox
        Me.txtlogin = New System.Windows.Forms.TextBox
        Me.btnoquei = New System.Windows.Forms.Button
        Me.cbopergunta = New System.Windows.Forms.ComboBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.txtresposta = New System.Windows.Forms.TextBox
        Me.Label8 = New System.Windows.Forms.Label
        Me.SuspendLayout()
        '
        'btnsair
        '
        Me.btnsair.Location = New System.Drawing.Point(339, 79)
        Me.btnsair.Name = "btnsair"
        Me.btnsair.Size = New System.Drawing.Size(75, 23)
        Me.btnsair.TabIndex = 7
        Me.btnsair.Text = "Sair"
        Me.btnsair.UseVisualStyleBackColor = True
        '
        'cbotipo
        '
        Me.cbotipo.FormattingEnabled = True
        Me.cbotipo.Location = New System.Drawing.Point(148, 128)
        Me.cbotipo.Name = "cbotipo"
        Me.cbotipo.Size = New System.Drawing.Size(185, 21)
        Me.cbotipo.TabIndex = 5
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(12, 131)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(82, 13)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "Tipo de Usuario"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 105)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(85, 13)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Confirmar Senha"
        '
        'txtconfirmasenha
        '
        Me.txtconfirmasenha.Location = New System.Drawing.Point(148, 102)
        Me.txtconfirmasenha.MaxLength = 255
        Me.txtconfirmasenha.Name = "txtconfirmasenha"
        Me.txtconfirmasenha.Size = New System.Drawing.Size(126, 20)
        Me.txtconfirmasenha.TabIndex = 4
        Me.txtconfirmasenha.UseSystemPasswordChar = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 79)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(38, 13)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Senha"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 53)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(36, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Login "
        '
        'txtsenha
        '
        Me.txtsenha.Location = New System.Drawing.Point(148, 76)
        Me.txtsenha.MaxLength = 255
        Me.txtsenha.Name = "txtsenha"
        Me.txtsenha.Size = New System.Drawing.Size(126, 20)
        Me.txtsenha.TabIndex = 2
        Me.txtsenha.UseSystemPasswordChar = True
        '
        'txtlogin
        '
        Me.txtlogin.Location = New System.Drawing.Point(148, 50)
        Me.txtlogin.MaxLength = 255
        Me.txtlogin.Name = "txtlogin"
        Me.txtlogin.Size = New System.Drawing.Size(185, 20)
        Me.txtlogin.TabIndex = 1
        '
        'btnoquei
        '
        Me.btnoquei.Location = New System.Drawing.Point(339, 50)
        Me.btnoquei.Name = "btnoquei"
        Me.btnoquei.Size = New System.Drawing.Size(75, 23)
        Me.btnoquei.TabIndex = 6
        Me.btnoquei.Text = "OK"
        Me.btnoquei.UseVisualStyleBackColor = True
        '
        'cbopergunta
        '
        Me.cbopergunta.FormattingEnabled = True
        Me.cbopergunta.Location = New System.Drawing.Point(202, 164)
        Me.cbopergunta.Name = "cbopergunta"
        Me.cbopergunta.Size = New System.Drawing.Size(185, 21)
        Me.cbopergunta.TabIndex = 9
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(12, 167)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(184, 13)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "Escolha uma Pergunta de Segurança"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(12, 206)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(52, 13)
        Me.Label6.TabIndex = 10
        Me.Label6.Text = "Resposta"
        '
        'txtresposta
        '
        Me.txtresposta.Location = New System.Drawing.Point(148, 203)
        Me.txtresposta.MaxLength = 255
        Me.txtresposta.Name = "txtresposta"
        Me.txtresposta.Size = New System.Drawing.Size(126, 20)
        Me.txtresposta.TabIndex = 11
        Me.txtresposta.UseSystemPasswordChar = True
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Haettenschweiler", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(143, 9)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(173, 26)
        Me.Label8.TabIndex = 12
        Me.Label8.Text = "Adicionar Usuarios"
        '
        'frmadicionar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(434, 249)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.txtresposta)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.cbopergunta)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.btnsair)
        Me.Controls.Add(Me.cbotipo)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtconfirmasenha)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtsenha)
        Me.Controls.Add(Me.txtlogin)
        Me.Controls.Add(Me.btnoquei)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmadicionar"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmadicionar"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnsair As System.Windows.Forms.Button
    Friend WithEvents cbotipo As System.Windows.Forms.ComboBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtconfirmasenha As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtsenha As System.Windows.Forms.TextBox
    Friend WithEvents txtlogin As System.Windows.Forms.TextBox
    Friend WithEvents btnoquei As System.Windows.Forms.Button
    Friend WithEvents cbopergunta As System.Windows.Forms.ComboBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtresposta As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
End Class
