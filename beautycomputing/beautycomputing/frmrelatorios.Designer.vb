<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmrelatorios
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmrelatorios))
        Me.Label6 = New System.Windows.Forms.Label
        Me.lblfuncionarios = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.Cadastros = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.lbltipousuario = New System.Windows.Forms.Label
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.lbltitulo = New System.Windows.Forms.Label
        Me.lbltexto = New System.Windows.Forms.Label
        Me.picrelatorios = New System.Windows.Forms.PictureBox
        Me.btnrelatoriosdeclientes = New System.Windows.Forms.PictureBox
        Me.btnrelatoriosdealunos = New System.Windows.Forms.PictureBox
        Me.btnrelatoriosdefuncionarios = New System.Windows.Forms.PictureBox
        Me.btnrelatoriosdeservicos = New System.Windows.Forms.PictureBox
        Me.btnvoltaraomenu = New System.Windows.Forms.PictureBox
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.GroupBox1.SuspendLayout()
        CType(Me.picrelatorios, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnrelatoriosdeclientes, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnrelatoriosdealunos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnrelatoriosdefuncionarios, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnrelatoriosdeservicos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnvoltaraomenu, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Haettenschweiler", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label6.Location = New System.Drawing.Point(15, 491)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(82, 34)
        Me.Label6.TabIndex = 6
        Me.Label6.Text = "Voltar ao " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Menu Principal"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'lblfuncionarios
        '
        Me.lblfuncionarios.AutoSize = True
        Me.lblfuncionarios.BackColor = System.Drawing.Color.Transparent
        Me.lblfuncionarios.Font = New System.Drawing.Font("Haettenschweiler", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblfuncionarios.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblfuncionarios.Location = New System.Drawing.Point(15, 380)
        Me.lblfuncionarios.Name = "lblfuncionarios"
        Me.lblfuncionarios.Size = New System.Drawing.Size(73, 17)
        Me.lblfuncionarios.TabIndex = 4
        Me.lblfuncionarios.Text = "Funcionarios"
        Me.lblfuncionarios.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Haettenschweiler", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label3.Location = New System.Drawing.Point(23, 291)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(53, 17)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Servicos"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Haettenschweiler", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label1.Location = New System.Drawing.Point(27, 202)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(42, 17)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Alunos"
        '
        'Cadastros
        '
        Me.Cadastros.AutoSize = True
        Me.Cadastros.BackColor = System.Drawing.Color.Transparent
        Me.Cadastros.Font = New System.Drawing.Font("Haettenschweiler", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cadastros.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Cadastros.Location = New System.Drawing.Point(27, 97)
        Me.Cadastros.Name = "Cadastros"
        Me.Cadastros.Size = New System.Drawing.Size(49, 17)
        Me.Cadastros.TabIndex = 2
        Me.Cadastros.Text = "Clientes"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Haettenschweiler", 18.0!, System.Drawing.FontStyle.Bold)
        Me.Label4.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label4.Location = New System.Drawing.Point(341, 41)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(293, 26)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "Menu de Impressão de Relatórios"
        '
        'lbltipousuario
        '
        Me.lbltipousuario.AutoSize = True
        Me.lbltipousuario.BackColor = System.Drawing.Color.Transparent
        Me.lbltipousuario.Font = New System.Drawing.Font("Haettenschweiler", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbltipousuario.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lbltipousuario.Location = New System.Drawing.Point(417, 67)
        Me.lbltipousuario.Name = "lbltipousuario"
        Me.lbltipousuario.Size = New System.Drawing.Size(110, 21)
        Me.lbltipousuario.TabIndex = 72
        Me.lbltipousuario.Text = "(Adiministrador)"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btnrelatoriosdeclientes)
        Me.GroupBox1.Controls.Add(Me.Cadastros)
        Me.GroupBox1.Controls.Add(Me.btnrelatoriosdealunos)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.btnrelatoriosdefuncionarios)
        Me.GroupBox1.Controls.Add(Me.lblfuncionarios)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.btnrelatoriosdeservicos)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.btnvoltaraomenu)
        Me.GroupBox1.Font = New System.Drawing.Font("Haettenschweiler", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.GroupBox1.Location = New System.Drawing.Point(23, 83)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.GroupBox1.Size = New System.Drawing.Size(105, 555)
        Me.GroupBox1.TabIndex = 73
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Relatórios"
        '
        'lbltitulo
        '
        Me.lbltitulo.BackColor = System.Drawing.Color.Transparent
        Me.lbltitulo.Font = New System.Drawing.Font("Haettenschweiler", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbltitulo.Location = New System.Drawing.Point(256, 141)
        Me.lbltitulo.Name = "lbltitulo"
        Me.lbltitulo.Size = New System.Drawing.Size(217, 64)
        Me.lbltitulo.TabIndex = 75
        Me.lbltitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lbltexto
        '
        Me.lbltexto.BackColor = System.Drawing.Color.Transparent
        Me.lbltexto.Font = New System.Drawing.Font("Haettenschweiler", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbltexto.Location = New System.Drawing.Point(161, 205)
        Me.lbltexto.Name = "lbltexto"
        Me.lbltexto.Size = New System.Drawing.Size(378, 125)
        Me.lbltexto.TabIndex = 76
        Me.lbltexto.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'picrelatorios
        '
        Me.picrelatorios.Location = New System.Drawing.Point(614, 123)
        Me.picrelatorios.Name = "picrelatorios"
        Me.picrelatorios.Size = New System.Drawing.Size(214, 281)
        Me.picrelatorios.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picrelatorios.TabIndex = 77
        Me.picrelatorios.TabStop = False
        '
        'btnrelatoriosdeclientes
        '
        Me.btnrelatoriosdeclientes.BackColor = System.Drawing.Color.Transparent
        Me.btnrelatoriosdeclientes.Image = Global.beautycomputing.My.Resources.Resources.cientes
        Me.btnrelatoriosdeclientes.Location = New System.Drawing.Point(26, 41)
        Me.btnrelatoriosdeclientes.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnrelatoriosdeclientes.Name = "btnrelatoriosdeclientes"
        Me.btnrelatoriosdeclientes.Size = New System.Drawing.Size(47, 52)
        Me.btnrelatoriosdeclientes.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.btnrelatoriosdeclientes.TabIndex = 61
        Me.btnrelatoriosdeclientes.TabStop = False
        '
        'btnrelatoriosdealunos
        '
        Me.btnrelatoriosdealunos.BackColor = System.Drawing.Color.Transparent
        Me.btnrelatoriosdealunos.Image = Global.beautycomputing.My.Resources.Resources.aluno
        Me.btnrelatoriosdealunos.Location = New System.Drawing.Point(26, 146)
        Me.btnrelatoriosdealunos.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnrelatoriosdealunos.Name = "btnrelatoriosdealunos"
        Me.btnrelatoriosdealunos.Size = New System.Drawing.Size(47, 52)
        Me.btnrelatoriosdealunos.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.btnrelatoriosdealunos.TabIndex = 67
        Me.btnrelatoriosdealunos.TabStop = False
        '
        'btnrelatoriosdefuncionarios
        '
        Me.btnrelatoriosdefuncionarios.BackColor = System.Drawing.Color.Transparent
        Me.btnrelatoriosdefuncionarios.Image = Global.beautycomputing.My.Resources.Resources.funcionarios
        Me.btnrelatoriosdefuncionarios.Location = New System.Drawing.Point(26, 324)
        Me.btnrelatoriosdefuncionarios.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnrelatoriosdefuncionarios.Name = "btnrelatoriosdefuncionarios"
        Me.btnrelatoriosdefuncionarios.Size = New System.Drawing.Size(47, 52)
        Me.btnrelatoriosdefuncionarios.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.btnrelatoriosdefuncionarios.TabIndex = 69
        Me.btnrelatoriosdefuncionarios.TabStop = False
        '
        'btnrelatoriosdeservicos
        '
        Me.btnrelatoriosdeservicos.BackColor = System.Drawing.Color.Transparent
        Me.btnrelatoriosdeservicos.Image = Global.beautycomputing.My.Resources.Resources.servicos
        Me.btnrelatoriosdeservicos.Location = New System.Drawing.Point(26, 235)
        Me.btnrelatoriosdeservicos.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnrelatoriosdeservicos.Name = "btnrelatoriosdeservicos"
        Me.btnrelatoriosdeservicos.Size = New System.Drawing.Size(47, 52)
        Me.btnrelatoriosdeservicos.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.btnrelatoriosdeservicos.TabIndex = 68
        Me.btnrelatoriosdeservicos.TabStop = False
        '
        'btnvoltaraomenu
        '
        Me.btnvoltaraomenu.BackColor = System.Drawing.Color.Transparent
        Me.btnvoltaraomenu.Image = Global.beautycomputing.My.Resources.Resources.menu
        Me.btnvoltaraomenu.Location = New System.Drawing.Point(26, 435)
        Me.btnvoltaraomenu.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnvoltaraomenu.Name = "btnvoltaraomenu"
        Me.btnvoltaraomenu.Size = New System.Drawing.Size(47, 52)
        Me.btnvoltaraomenu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.btnvoltaraomenu.TabIndex = 70
        Me.btnvoltaraomenu.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.Image = Global.beautycomputing.My.Resources.Resources.gtk_print_report
        Me.PictureBox1.Location = New System.Drawing.Point(261, 26)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(64, 56)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 71
        Me.PictureBox1.TabStop = False
        '
        'frmrelatorios
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Snow
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(972, 651)
        Me.Controls.Add(Me.picrelatorios)
        Me.Controls.Add(Me.lbltexto)
        Me.Controls.Add(Me.lbltitulo)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.lbltipousuario)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.PictureBox1)
        Me.Font = New System.Drawing.Font("Haettenschweiler", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.SystemColors.ControlText
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "frmrelatorios"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmrelatorios"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.picrelatorios, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnrelatoriosdeclientes, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnrelatoriosdealunos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnrelatoriosdefuncionarios, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnrelatoriosdeservicos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnvoltaraomenu, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnvoltaraomenu As System.Windows.Forms.PictureBox
    Friend WithEvents btnrelatoriosdefuncionarios As System.Windows.Forms.PictureBox
    Friend WithEvents btnrelatoriosdeservicos As System.Windows.Forms.PictureBox
    Friend WithEvents btnrelatoriosdealunos As System.Windows.Forms.PictureBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents lblfuncionarios As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Cadastros As System.Windows.Forms.Label
    Friend WithEvents btnrelatoriosdeclientes As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents lbltipousuario As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents lbltitulo As System.Windows.Forms.Label
    Friend WithEvents lbltexto As System.Windows.Forms.Label
    Friend WithEvents picrelatorios As System.Windows.Forms.PictureBox
End Class
