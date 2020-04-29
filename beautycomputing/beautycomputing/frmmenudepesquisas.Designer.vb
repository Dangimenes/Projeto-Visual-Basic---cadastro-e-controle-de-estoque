<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmmenudepesquisas
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmmenudepesquisas))
        Me.btnvoltaraomenu = New System.Windows.Forms.PictureBox
        Me.btnfuncionarios = New System.Windows.Forms.PictureBox
        Me.btnservicos = New System.Windows.Forms.PictureBox
        Me.btnalunos = New System.Windows.Forms.PictureBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.lblfuncionario = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.Cadastros = New System.Windows.Forms.Label
        Me.btnclientes = New System.Windows.Forms.PictureBox
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.lbltipousuario = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        CType(Me.btnvoltaraomenu, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnfuncionarios, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnservicos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnalunos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnclientes, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnvoltaraomenu
        '
        Me.btnvoltaraomenu.BackColor = System.Drawing.Color.Transparent
        Me.btnvoltaraomenu.Image = Global.beautycomputing.My.Resources.Resources.menu
        Me.btnvoltaraomenu.Location = New System.Drawing.Point(26, 429)
        Me.btnvoltaraomenu.Name = "btnvoltaraomenu"
        Me.btnvoltaraomenu.Size = New System.Drawing.Size(47, 52)
        Me.btnvoltaraomenu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.btnvoltaraomenu.TabIndex = 70
        Me.btnvoltaraomenu.TabStop = False
        '
        'btnfuncionarios
        '
        Me.btnfuncionarios.BackColor = System.Drawing.Color.Transparent
        Me.btnfuncionarios.Image = Global.beautycomputing.My.Resources.Resources.funcionarios
        Me.btnfuncionarios.Location = New System.Drawing.Point(26, 301)
        Me.btnfuncionarios.Name = "btnfuncionarios"
        Me.btnfuncionarios.Size = New System.Drawing.Size(47, 52)
        Me.btnfuncionarios.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.btnfuncionarios.TabIndex = 69
        Me.btnfuncionarios.TabStop = False
        '
        'btnservicos
        '
        Me.btnservicos.BackColor = System.Drawing.Color.Transparent
        Me.btnservicos.Image = Global.beautycomputing.My.Resources.Resources.servicos
        Me.btnservicos.Location = New System.Drawing.Point(26, 214)
        Me.btnservicos.Name = "btnservicos"
        Me.btnservicos.Size = New System.Drawing.Size(47, 52)
        Me.btnservicos.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.btnservicos.TabIndex = 68
        Me.btnservicos.TabStop = False
        '
        'btnalunos
        '
        Me.btnalunos.BackColor = System.Drawing.Color.Transparent
        Me.btnalunos.Image = Global.beautycomputing.My.Resources.Resources.aluno
        Me.btnalunos.Location = New System.Drawing.Point(26, 128)
        Me.btnalunos.Name = "btnalunos"
        Me.btnalunos.Size = New System.Drawing.Size(47, 52)
        Me.btnalunos.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.btnalunos.TabIndex = 67
        Me.btnalunos.TabStop = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Haettenschweiler", 12.0!)
        Me.Label6.Location = New System.Drawing.Point(9, 484)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(82, 34)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Voltar ao " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Menu Principal"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'lblfuncionario
        '
        Me.lblfuncionario.AutoSize = True
        Me.lblfuncionario.BackColor = System.Drawing.Color.Transparent
        Me.lblfuncionario.Font = New System.Drawing.Font("Haettenschweiler", 12.0!)
        Me.lblfuncionario.Location = New System.Drawing.Point(18, 356)
        Me.lblfuncionario.Name = "lblfuncionario"
        Me.lblfuncionario.Size = New System.Drawing.Size(73, 17)
        Me.lblfuncionario.TabIndex = 3
        Me.lblfuncionario.Text = "Funcionarios"
        Me.lblfuncionario.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Haettenschweiler", 12.0!)
        Me.Label3.Location = New System.Drawing.Point(26, 269)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(53, 17)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Servicos"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Haettenschweiler", 12.0!)
        Me.Label1.Location = New System.Drawing.Point(31, 183)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(42, 17)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Alunos"
        '
        'Cadastros
        '
        Me.Cadastros.AutoSize = True
        Me.Cadastros.BackColor = System.Drawing.Color.Transparent
        Me.Cadastros.Font = New System.Drawing.Font("Haettenschweiler", 12.0!)
        Me.Cadastros.Location = New System.Drawing.Point(25, 95)
        Me.Cadastros.Name = "Cadastros"
        Me.Cadastros.Size = New System.Drawing.Size(49, 17)
        Me.Cadastros.TabIndex = 1
        Me.Cadastros.Text = "Clientes"
        '
        'btnclientes
        '
        Me.btnclientes.BackColor = System.Drawing.Color.Transparent
        Me.btnclientes.Image = Global.beautycomputing.My.Resources.Resources.cientes
        Me.btnclientes.Location = New System.Drawing.Point(26, 41)
        Me.btnclientes.Name = "btnclientes"
        Me.btnclientes.Size = New System.Drawing.Size(47, 52)
        Me.btnclientes.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.btnclientes.TabIndex = 61
        Me.btnclientes.TabStop = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btnclientes)
        Me.GroupBox1.Controls.Add(Me.Cadastros)
        Me.GroupBox1.Controls.Add(Me.btnalunos)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.btnvoltaraomenu)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.btnfuncionarios)
        Me.GroupBox1.Controls.Add(Me.lblfuncionario)
        Me.GroupBox1.Controls.Add(Me.btnservicos)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Font = New System.Drawing.Font("Haettenschweiler", 14.25!)
        Me.GroupBox1.Location = New System.Drawing.Point(23, 83)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(105, 555)
        Me.GroupBox1.TabIndex = 72
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Pesquisas"
        '
        'lbltipousuario
        '
        Me.lbltipousuario.AutoSize = True
        Me.lbltipousuario.BackColor = System.Drawing.Color.Transparent
        Me.lbltipousuario.Font = New System.Drawing.Font("Haettenschweiler", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbltipousuario.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lbltipousuario.Location = New System.Drawing.Point(371, 67)
        Me.lbltipousuario.Name = "lbltipousuario"
        Me.lbltipousuario.Size = New System.Drawing.Size(110, 21)
        Me.lbltipousuario.TabIndex = 76
        Me.lbltipousuario.Text = "(Adiministrador)"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Haettenschweiler", 18.0!, System.Drawing.FontStyle.Bold)
        Me.Label5.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label5.Location = New System.Drawing.Point(341, 41)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(172, 26)
        Me.Label5.TabIndex = 75
        Me.Label5.Text = "Menu de Pesquisas"
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.Image = Global.beautycomputing.My.Resources.Resources.procurar
        Me.PictureBox1.Location = New System.Drawing.Point(261, 26)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(64, 56)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 77
        Me.PictureBox1.TabStop = False
        '
        'frmmenudepesquisas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Snow
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(972, 651)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.lbltipousuario)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmmenudepesquisas"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmmenudepesquisas"
        CType(Me.btnvoltaraomenu, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnfuncionarios, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnservicos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnalunos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnclientes, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnvoltaraomenu As System.Windows.Forms.PictureBox
    Friend WithEvents btnfuncionarios As System.Windows.Forms.PictureBox
    Friend WithEvents btnservicos As System.Windows.Forms.PictureBox
    Friend WithEvents btnalunos As System.Windows.Forms.PictureBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents lblfuncionario As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Cadastros As System.Windows.Forms.Label
    Friend WithEvents btnclientes As System.Windows.Forms.PictureBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents lbltipousuario As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
End Class
