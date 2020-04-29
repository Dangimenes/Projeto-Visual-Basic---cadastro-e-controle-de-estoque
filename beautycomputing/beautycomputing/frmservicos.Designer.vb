<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmservicos
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmservicos))
        Me.lblservico = New System.Windows.Forms.Label
        Me.lbltipo = New System.Windows.Forms.Label
        Me.lblvalor = New System.Windows.Forms.Label
        Me.lbltempo = New System.Windows.Forms.Label
        Me.btnnovo = New System.Windows.Forms.Button
        Me.datagridserviços = New System.Windows.Forms.DataGridView
        Me.txtservico = New System.Windows.Forms.TextBox
        Me.txttiposervico = New System.Windows.Forms.TextBox
        Me.txtvalor = New System.Windows.Forms.TextBox
        Me.btncancelar = New System.Windows.Forms.Button
        Me.btneditar = New System.Windows.Forms.Button
        Me.btnsalvar = New System.Windows.Forms.Button
        Me.Label8 = New System.Windows.Forms.Label
        Me.btnexcluir = New System.Windows.Forms.Button
        Me.txtcodigo = New System.Windows.Forms.TextBox
        Me.lblcodigo = New System.Windows.Forms.Label
        Me.btnUltimo = New System.Windows.Forms.Button
        Me.btnProximo = New System.Windows.Forms.Button
        Me.btnAnterior = New System.Windows.Forms.Button
        Me.btnPrimeiro = New System.Windows.Forms.Button
        Me.txttemposervico = New System.Windows.Forms.MaskedTextBox
        CType(Me.datagridserviços, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblservico
        '
        Me.lblservico.AutoSize = True
        Me.lblservico.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblservico.Location = New System.Drawing.Point(12, 63)
        Me.lblservico.Name = "lblservico"
        Me.lblservico.Size = New System.Drawing.Size(58, 18)
        Me.lblservico.TabIndex = 0
        Me.lblservico.Text = "Serviço"
        '
        'lbltipo
        '
        Me.lbltipo.AutoSize = True
        Me.lbltipo.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbltipo.Location = New System.Drawing.Point(12, 93)
        Me.lbltipo.Name = "lbltipo"
        Me.lbltipo.Size = New System.Drawing.Size(91, 18)
        Me.lbltipo.TabIndex = 0
        Me.lbltipo.Text = "Tipo Serviço"
        '
        'lblvalor
        '
        Me.lblvalor.AutoSize = True
        Me.lblvalor.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblvalor.Location = New System.Drawing.Point(12, 128)
        Me.lblvalor.Name = "lblvalor"
        Me.lblvalor.Size = New System.Drawing.Size(42, 18)
        Me.lblvalor.TabIndex = 0
        Me.lblvalor.Text = "Valor"
        '
        'lbltempo
        '
        Me.lbltempo.AutoSize = True
        Me.lbltempo.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbltempo.Location = New System.Drawing.Point(12, 164)
        Me.lbltempo.Name = "lbltempo"
        Me.lbltempo.Size = New System.Drawing.Size(188, 18)
        Me.lbltempo.TabIndex = 0
        Me.lbltempo.Text = "Tempo Previsto do Serviço"
        '
        'btnnovo
        '
        Me.btnnovo.Location = New System.Drawing.Point(566, 22)
        Me.btnnovo.Name = "btnnovo"
        Me.btnnovo.Size = New System.Drawing.Size(97, 29)
        Me.btnnovo.TabIndex = 6
        Me.btnnovo.Text = "Novo Serviço"
        Me.btnnovo.UseVisualStyleBackColor = True
        '
        'datagridserviços
        '
        Me.datagridserviços.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.datagridserviços.Location = New System.Drawing.Point(15, 222)
        Me.datagridserviços.Name = "datagridserviços"
        Me.datagridserviços.Size = New System.Drawing.Size(632, 187)
        Me.datagridserviços.TabIndex = 11
        '
        'txtservico
        '
        Me.txtservico.Location = New System.Drawing.Point(206, 64)
        Me.txtservico.MaxLength = 255
        Me.txtservico.Name = "txtservico"
        Me.txtservico.Size = New System.Drawing.Size(100, 20)
        Me.txtservico.TabIndex = 2
        '
        'txttiposervico
        '
        Me.txttiposervico.Location = New System.Drawing.Point(206, 94)
        Me.txttiposervico.MaxLength = 255
        Me.txttiposervico.Name = "txttiposervico"
        Me.txttiposervico.Size = New System.Drawing.Size(100, 20)
        Me.txttiposervico.TabIndex = 3
        '
        'txtvalor
        '
        Me.txtvalor.Location = New System.Drawing.Point(206, 129)
        Me.txtvalor.MaxLength = 255
        Me.txtvalor.Name = "txtvalor"
        Me.txtvalor.Size = New System.Drawing.Size(100, 20)
        Me.txtvalor.TabIndex = 4
        '
        'btncancelar
        '
        Me.btncancelar.Location = New System.Drawing.Point(566, 69)
        Me.btncancelar.Name = "btncancelar"
        Me.btncancelar.Size = New System.Drawing.Size(97, 29)
        Me.btncancelar.TabIndex = 7
        Me.btncancelar.Text = "Cancelar"
        Me.btncancelar.UseVisualStyleBackColor = True
        '
        'btneditar
        '
        Me.btneditar.Location = New System.Drawing.Point(566, 104)
        Me.btneditar.Name = "btneditar"
        Me.btneditar.Size = New System.Drawing.Size(97, 29)
        Me.btneditar.TabIndex = 8
        Me.btneditar.Text = "Editar"
        Me.btneditar.UseVisualStyleBackColor = True
        '
        'btnsalvar
        '
        Me.btnsalvar.Location = New System.Drawing.Point(566, 178)
        Me.btnsalvar.Name = "btnsalvar"
        Me.btnsalvar.Size = New System.Drawing.Size(97, 29)
        Me.btnsalvar.TabIndex = 10
        Me.btnsalvar.Text = "Salvar"
        Me.btnsalvar.UseVisualStyleBackColor = True
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(222, 9)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(171, 18)
        Me.Label8.TabIndex = 0
        Me.Label8.Text = "Cadastro de Serviços"
        '
        'btnexcluir
        '
        Me.btnexcluir.Location = New System.Drawing.Point(566, 143)
        Me.btnexcluir.Name = "btnexcluir"
        Me.btnexcluir.Size = New System.Drawing.Size(97, 29)
        Me.btnexcluir.TabIndex = 9
        Me.btnexcluir.Text = "Excluir"
        Me.btnexcluir.UseVisualStyleBackColor = True
        '
        'txtcodigo
        '
        Me.txtcodigo.Location = New System.Drawing.Point(206, 34)
        Me.txtcodigo.MaxLength = 255
        Me.txtcodigo.Name = "txtcodigo"
        Me.txtcodigo.Size = New System.Drawing.Size(100, 20)
        Me.txtcodigo.TabIndex = 1
        '
        'lblcodigo
        '
        Me.lblcodigo.AutoSize = True
        Me.lblcodigo.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblcodigo.Location = New System.Drawing.Point(12, 33)
        Me.lblcodigo.Name = "lblcodigo"
        Me.lblcodigo.Size = New System.Drawing.Size(56, 18)
        Me.lblcodigo.TabIndex = 0
        Me.lblcodigo.Text = "Codigo"
        '
        'btnUltimo
        '
        Me.btnUltimo.Image = CType(resources.GetObject("btnUltimo.Image"), System.Drawing.Image)
        Me.btnUltimo.Location = New System.Drawing.Point(379, 422)
        Me.btnUltimo.Name = "btnUltimo"
        Me.btnUltimo.Size = New System.Drawing.Size(55, 36)
        Me.btnUltimo.TabIndex = 15
        Me.btnUltimo.UseVisualStyleBackColor = True
        '
        'btnProximo
        '
        Me.btnProximo.Image = CType(resources.GetObject("btnProximo.Image"), System.Drawing.Image)
        Me.btnProximo.Location = New System.Drawing.Point(323, 422)
        Me.btnProximo.Name = "btnProximo"
        Me.btnProximo.Size = New System.Drawing.Size(43, 36)
        Me.btnProximo.TabIndex = 14
        Me.btnProximo.UseVisualStyleBackColor = True
        '
        'btnAnterior
        '
        Me.btnAnterior.Image = CType(resources.GetObject("btnAnterior.Image"), System.Drawing.Image)
        Me.btnAnterior.Location = New System.Drawing.Point(260, 422)
        Me.btnAnterior.Name = "btnAnterior"
        Me.btnAnterior.Size = New System.Drawing.Size(50, 36)
        Me.btnAnterior.TabIndex = 13
        Me.btnAnterior.UseVisualStyleBackColor = True
        '
        'btnPrimeiro
        '
        Me.btnPrimeiro.Image = CType(resources.GetObject("btnPrimeiro.Image"), System.Drawing.Image)
        Me.btnPrimeiro.Location = New System.Drawing.Point(195, 422)
        Me.btnPrimeiro.Name = "btnPrimeiro"
        Me.btnPrimeiro.Size = New System.Drawing.Size(51, 36)
        Me.btnPrimeiro.TabIndex = 12
        Me.btnPrimeiro.UseVisualStyleBackColor = True
        '
        'txttemposervico
        '
        Me.txttemposervico.Location = New System.Drawing.Point(206, 164)
        Me.txttemposervico.Mask = "00:00"
        Me.txttemposervico.Name = "txttemposervico"
        Me.txttemposervico.Size = New System.Drawing.Size(127, 20)
        Me.txttemposervico.TabIndex = 5
        '
        'frmservicos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.ClientSize = New System.Drawing.Size(1390, 814)
        Me.Controls.Add(Me.txttemposervico)
        Me.Controls.Add(Me.btnUltimo)
        Me.Controls.Add(Me.btnProximo)
        Me.Controls.Add(Me.btnAnterior)
        Me.Controls.Add(Me.btnPrimeiro)
        Me.Controls.Add(Me.txtcodigo)
        Me.Controls.Add(Me.lblcodigo)
        Me.Controls.Add(Me.btnexcluir)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.btnsalvar)
        Me.Controls.Add(Me.btneditar)
        Me.Controls.Add(Me.btncancelar)
        Me.Controls.Add(Me.txtvalor)
        Me.Controls.Add(Me.txttiposervico)
        Me.Controls.Add(Me.txtservico)
        Me.Controls.Add(Me.datagridserviços)
        Me.Controls.Add(Me.btnnovo)
        Me.Controls.Add(Me.lbltempo)
        Me.Controls.Add(Me.lblvalor)
        Me.Controls.Add(Me.lbltipo)
        Me.Controls.Add(Me.lblservico)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmservicos"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Cadastros de Serviços"
        CType(Me.datagridserviços, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblservico As System.Windows.Forms.Label
    Friend WithEvents lbltipo As System.Windows.Forms.Label
    Friend WithEvents lblvalor As System.Windows.Forms.Label
    Friend WithEvents lbltempo As System.Windows.Forms.Label
    Friend WithEvents btnnovo As System.Windows.Forms.Button
    Friend WithEvents datagridserviços As System.Windows.Forms.DataGridView
    Friend WithEvents txtservico As System.Windows.Forms.TextBox
    Friend WithEvents txttiposervico As System.Windows.Forms.TextBox
    Friend WithEvents txtvalor As System.Windows.Forms.TextBox
    Friend WithEvents btncancelar As System.Windows.Forms.Button
    Friend WithEvents btneditar As System.Windows.Forms.Button
    Friend WithEvents btnsalvar As System.Windows.Forms.Button
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents btnexcluir As System.Windows.Forms.Button
    Friend WithEvents txtcodigo As System.Windows.Forms.TextBox
    Friend WithEvents lblcodigo As System.Windows.Forms.Label
    Friend WithEvents btnUltimo As System.Windows.Forms.Button
    Friend WithEvents btnProximo As System.Windows.Forms.Button
    Friend WithEvents btnAnterior As System.Windows.Forms.Button
    Friend WithEvents btnPrimeiro As System.Windows.Forms.Button
    Friend WithEvents txttemposervico As System.Windows.Forms.MaskedTextBox

End Class
