<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmmatriculaalunos
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmmatriculaalunos))
        Me.TabPage3 = New System.Windows.Forms.TabPage
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.lstdispositivos = New System.Windows.Forms.ListBox
        Me.Label27 = New System.Windows.Forms.Label
        Me.Label26 = New System.Windows.Forms.Label
        Me.fotoaluno = New System.Windows.Forms.PictureBox
        Me.btntirarfoto = New System.Windows.Forms.Button
        Me.piccaptura = New System.Windows.Forms.PictureBox
        Me.TabPage1 = New System.Windows.Forms.TabPage
        Me.fotoaluno2 = New System.Windows.Forms.PictureBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.dataatualizacao = New System.Windows.Forms.DateTimePicker
        Me.txtfotohora = New System.Windows.Forms.TextBox
        Me.txtmatriculaaluno = New System.Windows.Forms.MaskedTextBox
        Me.txtnascaluno = New System.Windows.Forms.MaskedTextBox
        Me.txtcelaluno = New System.Windows.Forms.MaskedTextBox
        Me.txttelaluno = New System.Windows.Forms.MaskedTextBox
        Me.txtcepaluno = New System.Windows.Forms.MaskedTextBox
        Me.txtrgaluno = New System.Windows.Forms.MaskedTextBox
        Me.cbosexoaluno = New System.Windows.Forms.ComboBox
        Me.lblsexo = New System.Windows.Forms.Label
        Me.cboestadosalunos = New System.Windows.Forms.ComboBox
        Me.txtmaealuno = New System.Windows.Forms.TextBox
        Me.lblmatricula = New System.Windows.Forms.Label
        Me.lblnomepai = New System.Windows.Forms.Label
        Me.txtpaialuno = New System.Windows.Forms.TextBox
        Me.txtcomplealuno = New System.Windows.Forms.TextBox
        Me.txtnumeroaluno = New System.Windows.Forms.TextBox
        Me.txtenderecoaluno = New System.Windows.Forms.TextBox
        Me.txtbairroaluno = New System.Windows.Forms.TextBox
        Me.txtcidadealuno = New System.Windows.Forms.TextBox
        Me.txtnomealuno = New System.Windows.Forms.TextBox
        Me.lblnomemae = New System.Windows.Forms.Label
        Me.lblnascimento = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.lblcelular = New System.Windows.Forms.Label
        Me.lbltelefone = New System.Windows.Forms.Label
        Me.lblcomplemento = New System.Windows.Forms.Label
        Me.lblnumero = New System.Windows.Forms.Label
        Me.lblendereco = New System.Windows.Forms.Label
        Me.lblbairro = New System.Windows.Forms.Label
        Me.lblcidade = New System.Windows.Forms.Label
        Me.lblestado = New System.Windows.Forms.Label
        Me.lblcep = New System.Windows.Forms.Label
        Me.lblnome = New System.Windows.Forms.Label
        Me.lblrg = New System.Windows.Forms.Label
        Me.Label20 = New System.Windows.Forms.Label
        Me.TabControl1 = New System.Windows.Forms.TabControl
        Me.btnexcluiraluno = New System.Windows.Forms.Button
        Me.btnsalvaraluno = New System.Windows.Forms.Button
        Me.btneditaraluno = New System.Windows.Forms.Button
        Me.btncancelaraluno = New System.Windows.Forms.Button
        Me.btnnovoaluno = New System.Windows.Forms.Button
        Me.btnultimoaluno = New System.Windows.Forms.PictureBox
        Me.btnproximoaluno = New System.Windows.Forms.PictureBox
        Me.btnalunoanterior = New System.Windows.Forms.PictureBox
        Me.btnprimeiroaluno = New System.Windows.Forms.PictureBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.btnvoltar = New System.Windows.Forms.PictureBox
        Me.btnrelatoriosdealunos = New System.Windows.Forms.PictureBox
        Me.btnlistadealunos = New System.Windows.Forms.PictureBox
        Me.TabPage3.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.fotoaluno, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.piccaptura, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage1.SuspendLayout()
        CType(Me.fotoaluno2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabControl1.SuspendLayout()
        CType(Me.btnultimoaluno, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnproximoaluno, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnalunoanterior, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnprimeiroaluno, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnvoltar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnrelatoriosdealunos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnlistadealunos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TabPage3
        '
        Me.TabPage3.Controls.Add(Me.PictureBox1)
        Me.TabPage3.Controls.Add(Me.lstdispositivos)
        Me.TabPage3.Controls.Add(Me.Label27)
        Me.TabPage3.Controls.Add(Me.Label26)
        Me.TabPage3.Controls.Add(Me.fotoaluno)
        Me.TabPage3.Controls.Add(Me.btntirarfoto)
        Me.TabPage3.Controls.Add(Me.piccaptura)
        Me.TabPage3.Location = New System.Drawing.Point(4, 22)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Size = New System.Drawing.Size(1086, 609)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "Tirar Foto"
        Me.TabPage3.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.beautycomputing.My.Resources.Resources.webcam
        Me.PictureBox1.Location = New System.Drawing.Point(374, 46)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(59, 49)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 44
        Me.PictureBox1.TabStop = False
        '
        'lstdispositivos
        '
        Me.lstdispositivos.Enabled = False
        Me.lstdispositivos.FormattingEnabled = True
        Me.lstdispositivos.Location = New System.Drawing.Point(53, 367)
        Me.lstdispositivos.Name = "lstdispositivos"
        Me.lstdispositivos.Size = New System.Drawing.Size(104, 30)
        Me.lstdispositivos.TabIndex = 40
        Me.lstdispositivos.Visible = False
        '
        'Label27
        '
        Me.Label27.AutoSize = True
        Me.Label27.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label27.Location = New System.Drawing.Point(587, 30)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(117, 18)
        Me.Label27.TabIndex = 0
        Me.Label27.Text = "Foto Do Aluno"
        '
        'Label26
        '
        Me.Label26.AutoSize = True
        Me.Label26.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label26.Location = New System.Drawing.Point(50, 30)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(87, 18)
        Me.Label26.TabIndex = 0
        Me.Label26.Text = "WEB CAM"
        '
        'fotoaluno
        '
        Me.fotoaluno.ErrorImage = Nothing
        Me.fotoaluno.InitialImage = Nothing
        Me.fotoaluno.Location = New System.Drawing.Point(571, 66)
        Me.fotoaluno.Name = "fotoaluno"
        Me.fotoaluno.Size = New System.Drawing.Size(213, 212)
        Me.fotoaluno.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.fotoaluno.TabIndex = 38
        Me.fotoaluno.TabStop = False
        '
        'btntirarfoto
        '
        Me.btntirarfoto.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btntirarfoto.Location = New System.Drawing.Point(342, 101)
        Me.btntirarfoto.Name = "btntirarfoto"
        Me.btntirarfoto.Size = New System.Drawing.Size(113, 49)
        Me.btntirarfoto.TabIndex = 17
        Me.btntirarfoto.Text = "Tirar Foto"
        Me.btntirarfoto.UseVisualStyleBackColor = True
        '
        'piccaptura
        '
        Me.piccaptura.ErrorImage = Nothing
        Me.piccaptura.InitialImage = Nothing
        Me.piccaptura.Location = New System.Drawing.Point(22, 66)
        Me.piccaptura.Name = "piccaptura"
        Me.piccaptura.Size = New System.Drawing.Size(213, 212)
        Me.piccaptura.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.piccaptura.TabIndex = 27
        Me.piccaptura.TabStop = False
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.fotoaluno2)
        Me.TabPage1.Controls.Add(Me.Label5)
        Me.TabPage1.Controls.Add(Me.dataatualizacao)
        Me.TabPage1.Controls.Add(Me.txtfotohora)
        Me.TabPage1.Controls.Add(Me.txtmatriculaaluno)
        Me.TabPage1.Controls.Add(Me.txtnascaluno)
        Me.TabPage1.Controls.Add(Me.txtcelaluno)
        Me.TabPage1.Controls.Add(Me.txttelaluno)
        Me.TabPage1.Controls.Add(Me.txtcepaluno)
        Me.TabPage1.Controls.Add(Me.txtrgaluno)
        Me.TabPage1.Controls.Add(Me.cbosexoaluno)
        Me.TabPage1.Controls.Add(Me.lblsexo)
        Me.TabPage1.Controls.Add(Me.cboestadosalunos)
        Me.TabPage1.Controls.Add(Me.txtmaealuno)
        Me.TabPage1.Controls.Add(Me.lblmatricula)
        Me.TabPage1.Controls.Add(Me.lblnomepai)
        Me.TabPage1.Controls.Add(Me.txtpaialuno)
        Me.TabPage1.Controls.Add(Me.txtcomplealuno)
        Me.TabPage1.Controls.Add(Me.txtnumeroaluno)
        Me.TabPage1.Controls.Add(Me.txtenderecoaluno)
        Me.TabPage1.Controls.Add(Me.txtbairroaluno)
        Me.TabPage1.Controls.Add(Me.txtcidadealuno)
        Me.TabPage1.Controls.Add(Me.txtnomealuno)
        Me.TabPage1.Controls.Add(Me.lblnomemae)
        Me.TabPage1.Controls.Add(Me.lblnascimento)
        Me.TabPage1.Controls.Add(Me.Label7)
        Me.TabPage1.Controls.Add(Me.lblcelular)
        Me.TabPage1.Controls.Add(Me.lbltelefone)
        Me.TabPage1.Controls.Add(Me.lblcomplemento)
        Me.TabPage1.Controls.Add(Me.lblnumero)
        Me.TabPage1.Controls.Add(Me.lblendereco)
        Me.TabPage1.Controls.Add(Me.lblbairro)
        Me.TabPage1.Controls.Add(Me.lblcidade)
        Me.TabPage1.Controls.Add(Me.lblestado)
        Me.TabPage1.Controls.Add(Me.lblcep)
        Me.TabPage1.Controls.Add(Me.lblnome)
        Me.TabPage1.Controls.Add(Me.lblrg)
        Me.TabPage1.Controls.Add(Me.Label20)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(1086, 609)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Dados Pessois"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'fotoaluno2
        '
        Me.fotoaluno2.ErrorImage = Nothing
        Me.fotoaluno2.InitialImage = Nothing
        Me.fotoaluno2.Location = New System.Drawing.Point(11, 63)
        Me.fotoaluno2.Name = "fotoaluno2"
        Me.fotoaluno2.Size = New System.Drawing.Size(213, 212)
        Me.fotoaluno2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.fotoaluno2.TabIndex = 0
        Me.fotoaluno2.TabStop = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(8, 311)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(148, 18)
        Me.Label5.TabIndex = 46
        Me.Label5.Text = "Ultima Atualização"
        '
        'dataatualizacao
        '
        Me.dataatualizacao.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dataatualizacao.Location = New System.Drawing.Point(11, 337)
        Me.dataatualizacao.Name = "dataatualizacao"
        Me.dataatualizacao.Size = New System.Drawing.Size(145, 20)
        Me.dataatualizacao.TabIndex = 45
        '
        'txtfotohora
        '
        Me.txtfotohora.BackColor = System.Drawing.Color.White
        Me.txtfotohora.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtfotohora.ForeColor = System.Drawing.Color.White
        Me.txtfotohora.Location = New System.Drawing.Point(22, 192)
        Me.txtfotohora.MaxLength = 255
        Me.txtfotohora.Name = "txtfotohora"
        Me.txtfotohora.ReadOnly = True
        Me.txtfotohora.Size = New System.Drawing.Size(100, 13)
        Me.txtfotohora.TabIndex = 42
        '
        'txtmatriculaaluno
        '
        Me.txtmatriculaaluno.Location = New System.Drawing.Point(661, 511)
        Me.txtmatriculaaluno.Mask = "00/00/0000"
        Me.txtmatriculaaluno.Name = "txtmatriculaaluno"
        Me.txtmatriculaaluno.Size = New System.Drawing.Size(127, 20)
        Me.txtmatriculaaluno.TabIndex = 16
        '
        'txtnascaluno
        '
        Me.txtnascaluno.Location = New System.Drawing.Point(661, 408)
        Me.txtnascaluno.Mask = "00/00/0000"
        Me.txtnascaluno.Name = "txtnascaluno"
        Me.txtnascaluno.Size = New System.Drawing.Size(127, 20)
        Me.txtnascaluno.TabIndex = 13
        '
        'txtcelaluno
        '
        Me.txtcelaluno.Location = New System.Drawing.Point(661, 357)
        Me.txtcelaluno.Mask = "(00) 00000-0000"
        Me.txtcelaluno.Name = "txtcelaluno"
        Me.txtcelaluno.Size = New System.Drawing.Size(127, 20)
        Me.txtcelaluno.TabIndex = 11
        '
        'txttelaluno
        '
        Me.txttelaluno.Location = New System.Drawing.Point(661, 327)
        Me.txttelaluno.Mask = "(00) 0000-0000"
        Me.txttelaluno.Name = "txttelaluno"
        Me.txttelaluno.Size = New System.Drawing.Size(127, 20)
        Me.txttelaluno.TabIndex = 10
        '
        'txtcepaluno
        '
        Me.txtcepaluno.Location = New System.Drawing.Point(661, 129)
        Me.txtcepaluno.Mask = "00000-000"
        Me.txtcepaluno.Name = "txtcepaluno"
        Me.txtcepaluno.Size = New System.Drawing.Size(127, 20)
        Me.txtcepaluno.TabIndex = 3
        '
        'txtrgaluno
        '
        Me.txtrgaluno.Location = New System.Drawing.Point(661, 69)
        Me.txtrgaluno.Mask = "00,000,000-0"
        Me.txtrgaluno.Name = "txtrgaluno"
        Me.txtrgaluno.Size = New System.Drawing.Size(127, 20)
        Me.txtrgaluno.TabIndex = 1
        '
        'cbosexoaluno
        '
        Me.cbosexoaluno.FormattingEnabled = True
        Me.cbosexoaluno.Location = New System.Drawing.Point(661, 380)
        Me.cbosexoaluno.Name = "cbosexoaluno"
        Me.cbosexoaluno.Size = New System.Drawing.Size(127, 21)
        Me.cbosexoaluno.TabIndex = 12
        '
        'lblsexo
        '
        Me.lblsexo.AutoSize = True
        Me.lblsexo.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblsexo.Location = New System.Drawing.Point(549, 379)
        Me.lblsexo.Name = "lblsexo"
        Me.lblsexo.Size = New System.Drawing.Size(42, 18)
        Me.lblsexo.TabIndex = 0
        Me.lblsexo.Text = "Sexo"
        '
        'cboestadosalunos
        '
        Me.cboestadosalunos.FormattingEnabled = True
        Me.cboestadosalunos.Location = New System.Drawing.Point(661, 152)
        Me.cboestadosalunos.Name = "cboestadosalunos"
        Me.cboestadosalunos.Size = New System.Drawing.Size(127, 21)
        Me.cboestadosalunos.TabIndex = 4
        '
        'txtmaealuno
        '
        Me.txtmaealuno.Location = New System.Drawing.Point(661, 431)
        Me.txtmaealuno.MaxLength = 255
        Me.txtmaealuno.Name = "txtmaealuno"
        Me.txtmaealuno.Size = New System.Drawing.Size(127, 20)
        Me.txtmaealuno.TabIndex = 14
        '
        'lblmatricula
        '
        Me.lblmatricula.AutoSize = True
        Me.lblmatricula.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblmatricula.Location = New System.Drawing.Point(521, 510)
        Me.lblmatricula.Name = "lblmatricula"
        Me.lblmatricula.Size = New System.Drawing.Size(123, 18)
        Me.lblmatricula.TabIndex = 0
        Me.lblmatricula.Text = "Data da Matricula"
        '
        'lblnomepai
        '
        Me.lblnomepai.AutoSize = True
        Me.lblnomepai.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblnomepai.Location = New System.Drawing.Point(549, 460)
        Me.lblnomepai.Name = "lblnomepai"
        Me.lblnomepai.Size = New System.Drawing.Size(95, 18)
        Me.lblnomepai.TabIndex = 0
        Me.lblnomepai.Text = "Nome do Pai"
        '
        'txtpaialuno
        '
        Me.txtpaialuno.Location = New System.Drawing.Point(661, 460)
        Me.txtpaialuno.MaxLength = 255
        Me.txtpaialuno.Name = "txtpaialuno"
        Me.txtpaialuno.Size = New System.Drawing.Size(127, 20)
        Me.txtpaialuno.TabIndex = 15
        '
        'txtcomplealuno
        '
        Me.txtcomplealuno.Location = New System.Drawing.Point(661, 298)
        Me.txtcomplealuno.MaxLength = 255
        Me.txtcomplealuno.Name = "txtcomplealuno"
        Me.txtcomplealuno.Size = New System.Drawing.Size(127, 20)
        Me.txtcomplealuno.TabIndex = 9
        '
        'txtnumeroaluno
        '
        Me.txtnumeroaluno.Location = New System.Drawing.Point(661, 272)
        Me.txtnumeroaluno.MaxLength = 255
        Me.txtnumeroaluno.Name = "txtnumeroaluno"
        Me.txtnumeroaluno.Size = New System.Drawing.Size(127, 20)
        Me.txtnumeroaluno.TabIndex = 8
        '
        'txtenderecoaluno
        '
        Me.txtenderecoaluno.Location = New System.Drawing.Point(661, 244)
        Me.txtenderecoaluno.MaxLength = 255
        Me.txtenderecoaluno.Name = "txtenderecoaluno"
        Me.txtenderecoaluno.Size = New System.Drawing.Size(127, 20)
        Me.txtenderecoaluno.TabIndex = 7
        '
        'txtbairroaluno
        '
        Me.txtbairroaluno.Location = New System.Drawing.Point(661, 212)
        Me.txtbairroaluno.MaxLength = 255
        Me.txtbairroaluno.Name = "txtbairroaluno"
        Me.txtbairroaluno.Size = New System.Drawing.Size(127, 20)
        Me.txtbairroaluno.TabIndex = 6
        '
        'txtcidadealuno
        '
        Me.txtcidadealuno.Location = New System.Drawing.Point(661, 185)
        Me.txtcidadealuno.MaxLength = 255
        Me.txtcidadealuno.Name = "txtcidadealuno"
        Me.txtcidadealuno.Size = New System.Drawing.Size(127, 20)
        Me.txtcidadealuno.TabIndex = 5
        '
        'txtnomealuno
        '
        Me.txtnomealuno.Location = New System.Drawing.Point(661, 98)
        Me.txtnomealuno.MaxLength = 255
        Me.txtnomealuno.Name = "txtnomealuno"
        Me.txtnomealuno.Size = New System.Drawing.Size(127, 20)
        Me.txtnomealuno.TabIndex = 2
        '
        'lblnomemae
        '
        Me.lblnomemae.AutoSize = True
        Me.lblnomemae.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblnomemae.Location = New System.Drawing.Point(550, 430)
        Me.lblnomemae.Name = "lblnomemae"
        Me.lblnomemae.Size = New System.Drawing.Size(102, 18)
        Me.lblnomemae.TabIndex = 0
        Me.lblnomemae.Text = "Nome da Mãe"
        '
        'lblnascimento
        '
        Me.lblnascimento.AutoSize = True
        Me.lblnascimento.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblnascimento.Location = New System.Drawing.Point(512, 407)
        Me.lblnascimento.Name = "lblnascimento"
        Me.lblnascimento.Size = New System.Drawing.Size(143, 18)
        Me.lblnascimento.TabIndex = 0
        Me.lblnascimento.Text = "Data de Nascimento"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(585, 30)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(132, 18)
        Me.Label7.TabIndex = 0
        Me.Label7.Text = "Dados Pessoais"
        '
        'lblcelular
        '
        Me.lblcelular.AutoSize = True
        Me.lblcelular.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblcelular.Location = New System.Drawing.Point(549, 349)
        Me.lblcelular.Name = "lblcelular"
        Me.lblcelular.Size = New System.Drawing.Size(54, 18)
        Me.lblcelular.TabIndex = 0
        Me.lblcelular.Text = "Celular"
        '
        'lbltelefone
        '
        Me.lbltelefone.AutoSize = True
        Me.lbltelefone.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbltelefone.Location = New System.Drawing.Point(549, 323)
        Me.lbltelefone.Name = "lbltelefone"
        Me.lbltelefone.Size = New System.Drawing.Size(69, 18)
        Me.lbltelefone.TabIndex = 0
        Me.lbltelefone.Text = "Telefone "
        '
        'lblcomplemento
        '
        Me.lblcomplemento.AutoSize = True
        Me.lblcomplemento.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblcomplemento.Location = New System.Drawing.Point(549, 297)
        Me.lblcomplemento.Name = "lblcomplemento"
        Me.lblcomplemento.Size = New System.Drawing.Size(102, 18)
        Me.lblcomplemento.TabIndex = 0
        Me.lblcomplemento.Text = "Complemento"
        '
        'lblnumero
        '
        Me.lblnumero.AutoSize = True
        Me.lblnumero.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblnumero.Location = New System.Drawing.Point(549, 271)
        Me.lblnumero.Name = "lblnumero"
        Me.lblnumero.Size = New System.Drawing.Size(62, 18)
        Me.lblnumero.TabIndex = 0
        Me.lblnumero.Text = "Numero"
        '
        'lblendereco
        '
        Me.lblendereco.AutoSize = True
        Me.lblendereco.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblendereco.Location = New System.Drawing.Point(549, 243)
        Me.lblendereco.Name = "lblendereco"
        Me.lblendereco.Size = New System.Drawing.Size(72, 18)
        Me.lblendereco.TabIndex = 0
        Me.lblendereco.Text = "Endereço"
        '
        'lblbairro
        '
        Me.lblbairro.AutoSize = True
        Me.lblbairro.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblbairro.Location = New System.Drawing.Point(549, 211)
        Me.lblbairro.Name = "lblbairro"
        Me.lblbairro.Size = New System.Drawing.Size(48, 18)
        Me.lblbairro.TabIndex = 0
        Me.lblbairro.Text = "Bairro"
        '
        'lblcidade
        '
        Me.lblcidade.AutoSize = True
        Me.lblcidade.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblcidade.Location = New System.Drawing.Point(549, 184)
        Me.lblcidade.Name = "lblcidade"
        Me.lblcidade.Size = New System.Drawing.Size(54, 18)
        Me.lblcidade.TabIndex = 0
        Me.lblcidade.Text = "Cidade"
        '
        'lblestado
        '
        Me.lblestado.AutoSize = True
        Me.lblestado.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblestado.Location = New System.Drawing.Point(549, 157)
        Me.lblestado.Name = "lblestado"
        Me.lblestado.Size = New System.Drawing.Size(55, 18)
        Me.lblestado.TabIndex = 0
        Me.lblestado.Text = "Estado"
        '
        'lblcep
        '
        Me.lblcep.AutoSize = True
        Me.lblcep.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblcep.Location = New System.Drawing.Point(549, 125)
        Me.lblcep.Name = "lblcep"
        Me.lblcep.Size = New System.Drawing.Size(39, 18)
        Me.lblcep.TabIndex = 0
        Me.lblcep.Text = "CEP"
        '
        'lblnome
        '
        Me.lblnome.AutoSize = True
        Me.lblnome.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblnome.Location = New System.Drawing.Point(549, 97)
        Me.lblnome.Name = "lblnome"
        Me.lblnome.Size = New System.Drawing.Size(49, 18)
        Me.lblnome.TabIndex = 0
        Me.lblnome.Text = "Nome"
        '
        'lblrg
        '
        Me.lblrg.AutoSize = True
        Me.lblrg.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblrg.Location = New System.Drawing.Point(549, 65)
        Me.lblrg.Name = "lblrg"
        Me.lblrg.Size = New System.Drawing.Size(31, 18)
        Me.lblrg.TabIndex = 0
        Me.lblrg.Text = "RG"
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.Location = New System.Drawing.Point(8, 30)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(114, 18)
        Me.Label20.TabIndex = 0
        Me.Label20.Text = "Foto do Aluno"
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage3)
        Me.TabControl1.Location = New System.Drawing.Point(2, 2)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(1094, 635)
        Me.TabControl1.TabIndex = 2
        '
        'btnexcluiraluno
        '
        Me.btnexcluiraluno.Location = New System.Drawing.Point(1140, 224)
        Me.btnexcluiraluno.Name = "btnexcluiraluno"
        Me.btnexcluiraluno.Size = New System.Drawing.Size(92, 33)
        Me.btnexcluiraluno.TabIndex = 22
        Me.btnexcluiraluno.Text = "Excluir"
        Me.btnexcluiraluno.UseVisualStyleBackColor = True
        '
        'btnsalvaraluno
        '
        Me.btnsalvaraluno.Location = New System.Drawing.Point(1140, 173)
        Me.btnsalvaraluno.Name = "btnsalvaraluno"
        Me.btnsalvaraluno.Size = New System.Drawing.Size(92, 33)
        Me.btnsalvaraluno.TabIndex = 21
        Me.btnsalvaraluno.Text = "Salvar"
        Me.btnsalvaraluno.UseVisualStyleBackColor = True
        '
        'btneditaraluno
        '
        Me.btneditaraluno.Location = New System.Drawing.Point(1140, 122)
        Me.btneditaraluno.Name = "btneditaraluno"
        Me.btneditaraluno.Size = New System.Drawing.Size(92, 33)
        Me.btneditaraluno.TabIndex = 20
        Me.btneditaraluno.Text = "Editar" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.btneditaraluno.UseVisualStyleBackColor = True
        '
        'btncancelaraluno
        '
        Me.btncancelaraluno.Location = New System.Drawing.Point(1140, 73)
        Me.btncancelaraluno.Name = "btncancelaraluno"
        Me.btncancelaraluno.Size = New System.Drawing.Size(92, 33)
        Me.btncancelaraluno.TabIndex = 19
        Me.btncancelaraluno.Text = "Cancelar"
        Me.btncancelaraluno.UseVisualStyleBackColor = True
        '
        'btnnovoaluno
        '
        Me.btnnovoaluno.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnnovoaluno.Location = New System.Drawing.Point(1140, 20)
        Me.btnnovoaluno.Name = "btnnovoaluno"
        Me.btnnovoaluno.Size = New System.Drawing.Size(92, 35)
        Me.btnnovoaluno.TabIndex = 18
        Me.btnnovoaluno.Text = "Novo Aluno"
        Me.btnnovoaluno.UseVisualStyleBackColor = True
        '
        'btnultimoaluno
        '
        Me.btnultimoaluno.BackColor = System.Drawing.Color.Transparent
        Me.btnultimoaluno.Image = Global.beautycomputing.My.Resources.Resources.ultimo
        Me.btnultimoaluno.Location = New System.Drawing.Point(551, 670)
        Me.btnultimoaluno.Name = "btnultimoaluno"
        Me.btnultimoaluno.Size = New System.Drawing.Size(36, 36)
        Me.btnultimoaluno.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.btnultimoaluno.TabIndex = 122
        Me.btnultimoaluno.TabStop = False
        '
        'btnproximoaluno
        '
        Me.btnproximoaluno.BackColor = System.Drawing.Color.Transparent
        Me.btnproximoaluno.Image = Global.beautycomputing.My.Resources.Resources.proximo
        Me.btnproximoaluno.Location = New System.Drawing.Point(493, 670)
        Me.btnproximoaluno.Name = "btnproximoaluno"
        Me.btnproximoaluno.Size = New System.Drawing.Size(36, 36)
        Me.btnproximoaluno.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.btnproximoaluno.TabIndex = 121
        Me.btnproximoaluno.TabStop = False
        '
        'btnalunoanterior
        '
        Me.btnalunoanterior.BackColor = System.Drawing.Color.Transparent
        Me.btnalunoanterior.Image = Global.beautycomputing.My.Resources.Resources.anterior
        Me.btnalunoanterior.Location = New System.Drawing.Point(282, 670)
        Me.btnalunoanterior.Name = "btnalunoanterior"
        Me.btnalunoanterior.Size = New System.Drawing.Size(36, 36)
        Me.btnalunoanterior.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.btnalunoanterior.TabIndex = 120
        Me.btnalunoanterior.TabStop = False
        '
        'btnprimeiroaluno
        '
        Me.btnprimeiroaluno.BackColor = System.Drawing.Color.Transparent
        Me.btnprimeiroaluno.Image = Global.beautycomputing.My.Resources.Resources.primeiro
        Me.btnprimeiroaluno.Location = New System.Drawing.Point(223, 670)
        Me.btnprimeiroaluno.Name = "btnprimeiroaluno"
        Me.btnprimeiroaluno.Size = New System.Drawing.Size(36, 36)
        Me.btnprimeiroaluno.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.btnprimeiroaluno.TabIndex = 119
        Me.btnprimeiroaluno.TabStop = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(1277, 271)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(34, 13)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "Menu"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(1249, 173)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(84, 13)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Lista de Clientes"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(1268, 83)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(54, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Relatórios"
        '
        'btnvoltar
        '
        Me.btnvoltar.BackColor = System.Drawing.Color.Transparent
        Me.btnvoltar.Image = Global.beautycomputing.My.Resources.Resources.menu
        Me.btnvoltar.Location = New System.Drawing.Point(1262, 208)
        Me.btnvoltar.Name = "btnvoltar"
        Me.btnvoltar.Size = New System.Drawing.Size(60, 60)
        Me.btnvoltar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.btnvoltar.TabIndex = 125
        Me.btnvoltar.TabStop = False
        '
        'btnrelatoriosdealunos
        '
        Me.btnrelatoriosdealunos.BackColor = System.Drawing.Color.Transparent
        Me.btnrelatoriosdealunos.Image = Global.beautycomputing.My.Resources.Resources.relatorios
        Me.btnrelatoriosdealunos.Location = New System.Drawing.Point(1262, 20)
        Me.btnrelatoriosdealunos.Name = "btnrelatoriosdealunos"
        Me.btnrelatoriosdealunos.Size = New System.Drawing.Size(60, 60)
        Me.btnrelatoriosdealunos.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.btnrelatoriosdealunos.TabIndex = 124
        Me.btnrelatoriosdealunos.TabStop = False
        '
        'btnlistadealunos
        '
        Me.btnlistadealunos.BackColor = System.Drawing.Color.Transparent
        Me.btnlistadealunos.Image = Global.beautycomputing.My.Resources.Resources.lista
        Me.btnlistadealunos.Location = New System.Drawing.Point(1262, 110)
        Me.btnlistadealunos.Name = "btnlistadealunos"
        Me.btnlistadealunos.Size = New System.Drawing.Size(60, 60)
        Me.btnlistadealunos.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.btnlistadealunos.TabIndex = 123
        Me.btnlistadealunos.TabStop = False
        '
        'frmmatriculaalunos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1392, 816)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnvoltar)
        Me.Controls.Add(Me.btnrelatoriosdealunos)
        Me.Controls.Add(Me.btnlistadealunos)
        Me.Controls.Add(Me.btnultimoaluno)
        Me.Controls.Add(Me.btnproximoaluno)
        Me.Controls.Add(Me.btnalunoanterior)
        Me.Controls.Add(Me.btnprimeiroaluno)
        Me.Controls.Add(Me.btnexcluiraluno)
        Me.Controls.Add(Me.btnsalvaraluno)
        Me.Controls.Add(Me.btneditaraluno)
        Me.Controls.Add(Me.btncancelaraluno)
        Me.Controls.Add(Me.btnnovoaluno)
        Me.Controls.Add(Me.TabControl1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmmatriculaalunos"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Matriculas de Alunos"
        Me.TabPage3.ResumeLayout(False)
        Me.TabPage3.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.fotoaluno, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.piccaptura, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        CType(Me.fotoaluno2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabControl1.ResumeLayout(False)
        CType(Me.btnultimoaluno, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnproximoaluno, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnalunoanterior, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnprimeiroaluno, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnvoltar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnrelatoriosdealunos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnlistadealunos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TabPage3 As System.Windows.Forms.TabPage
    Friend WithEvents lstdispositivos As System.Windows.Forms.ListBox
    Friend WithEvents Label27 As System.Windows.Forms.Label
    Friend WithEvents Label26 As System.Windows.Forms.Label
    Friend WithEvents fotoaluno As System.Windows.Forms.PictureBox
    Friend WithEvents btntirarfoto As System.Windows.Forms.Button
    Friend WithEvents piccaptura As System.Windows.Forms.PictureBox
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents lblnomepai As System.Windows.Forms.Label
    Friend WithEvents txtpaialuno As System.Windows.Forms.TextBox
    Friend WithEvents txtcomplealuno As System.Windows.Forms.TextBox
    Friend WithEvents txtnumeroaluno As System.Windows.Forms.TextBox
    Friend WithEvents txtenderecoaluno As System.Windows.Forms.TextBox
    Friend WithEvents txtbairroaluno As System.Windows.Forms.TextBox
    Friend WithEvents txtcidadealuno As System.Windows.Forms.TextBox
    Friend WithEvents txtnomealuno As System.Windows.Forms.TextBox
    Friend WithEvents lblnomemae As System.Windows.Forms.Label
    Friend WithEvents lblnascimento As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents lblcelular As System.Windows.Forms.Label
    Friend WithEvents lbltelefone As System.Windows.Forms.Label
    Friend WithEvents lblcomplemento As System.Windows.Forms.Label
    Friend WithEvents lblnumero As System.Windows.Forms.Label
    Friend WithEvents lblendereco As System.Windows.Forms.Label
    Friend WithEvents lblbairro As System.Windows.Forms.Label
    Friend WithEvents lblcidade As System.Windows.Forms.Label
    Friend WithEvents lblestado As System.Windows.Forms.Label
    Friend WithEvents lblcep As System.Windows.Forms.Label
    Friend WithEvents lblnome As System.Windows.Forms.Label
    Friend WithEvents lblrg As System.Windows.Forms.Label
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents fotoaluno2 As System.Windows.Forms.PictureBox
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents txtmaealuno As System.Windows.Forms.TextBox
    Friend WithEvents lblmatricula As System.Windows.Forms.Label
    Friend WithEvents btnexcluiraluno As System.Windows.Forms.Button
    Friend WithEvents btnsalvaraluno As System.Windows.Forms.Button
    Friend WithEvents btneditaraluno As System.Windows.Forms.Button
    Friend WithEvents btncancelaraluno As System.Windows.Forms.Button
    Friend WithEvents btnnovoaluno As System.Windows.Forms.Button
    Friend WithEvents cboestadosalunos As System.Windows.Forms.ComboBox
    Friend WithEvents cbosexoaluno As System.Windows.Forms.ComboBox
    Friend WithEvents lblsexo As System.Windows.Forms.Label
    Friend WithEvents txtnascaluno As System.Windows.Forms.MaskedTextBox
    Friend WithEvents txtcelaluno As System.Windows.Forms.MaskedTextBox
    Friend WithEvents txttelaluno As System.Windows.Forms.MaskedTextBox
    Friend WithEvents txtcepaluno As System.Windows.Forms.MaskedTextBox
    Friend WithEvents txtrgaluno As System.Windows.Forms.MaskedTextBox
    Friend WithEvents txtmatriculaaluno As System.Windows.Forms.MaskedTextBox
    Friend WithEvents btnultimoaluno As System.Windows.Forms.PictureBox
    Friend WithEvents btnproximoaluno As System.Windows.Forms.PictureBox
    Friend WithEvents btnalunoanterior As System.Windows.Forms.PictureBox
    Friend WithEvents btnprimeiroaluno As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnvoltar As System.Windows.Forms.PictureBox
    Friend WithEvents btnrelatoriosdealunos As System.Windows.Forms.PictureBox
    Friend WithEvents btnlistadealunos As System.Windows.Forms.PictureBox
    Friend WithEvents txtfotohora As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents dataatualizacao As System.Windows.Forms.DateTimePicker
End Class
