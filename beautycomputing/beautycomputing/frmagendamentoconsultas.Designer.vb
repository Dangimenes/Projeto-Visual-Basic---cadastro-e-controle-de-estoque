<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmagendamentoconsultas
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmagendamentoconsultas))
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.Label9 = New System.Windows.Forms.Label
        Me.Label10 = New System.Windows.Forms.Label
        Me.Label14 = New System.Windows.Forms.Label
        Me.Label18 = New System.Windows.Forms.Label
        Me.Label22 = New System.Windows.Forms.Label
        Me.txtnomecliente = New System.Windows.Forms.TextBox
        Me.btnnovaconsulta = New System.Windows.Forms.Button
        Me.btncancelar = New System.Windows.Forms.Button
        Me.btnsalvar = New System.Windows.Forms.Button
        Me.btnconsultas = New System.Windows.Forms.Button
        Me.datagridagenda = New System.Windows.Forms.DataGridView
        Me.txtvalor1 = New System.Windows.Forms.TextBox
        Me.txtvalor2 = New System.Windows.Forms.TextBox
        Me.txtvalor3 = New System.Windows.Forms.TextBox
        Me.txtvalor4 = New System.Windows.Forms.TextBox
        Me.txtvalortotal = New System.Windows.Forms.TextBox
        Me.txtservico1 = New System.Windows.Forms.TextBox
        Me.txtservico2 = New System.Windows.Forms.TextBox
        Me.txtservico3 = New System.Windows.Forms.TextBox
        Me.txtservico4 = New System.Windows.Forms.TextBox
        Me.txthora = New System.Windows.Forms.MaskedTextBox
        Me.txtrgcliente = New System.Windows.Forms.MaskedTextBox
        Me.txttempo1 = New System.Windows.Forms.MaskedTextBox
        Me.txttempo2 = New System.Windows.Forms.MaskedTextBox
        Me.txttempo3 = New System.Windows.Forms.MaskedTextBox
        Me.txttempo4 = New System.Windows.Forms.MaskedTextBox
        Me.txttelcliente = New System.Windows.Forms.MaskedTextBox
        Me.txtdata = New System.Windows.Forms.DateTimePicker
        Me.Label23 = New System.Windows.Forms.Label
        Me.txttempototal = New System.Windows.Forms.MaskedTextBox
        Me.Label24 = New System.Windows.Forms.Label
        Me.txtnome4 = New System.Windows.Forms.TextBox
        Me.txtnome3 = New System.Windows.Forms.TextBox
        Me.txtnome2 = New System.Windows.Forms.TextBox
        Me.txtnome1 = New System.Windows.Forms.TextBox
        Me.Label25 = New System.Windows.Forms.Label
        Me.txttipo1 = New System.Windows.Forms.TextBox
        Me.txttipo4 = New System.Windows.Forms.TextBox
        Me.txttipo3 = New System.Windows.Forms.TextBox
        Me.txttipo2 = New System.Windows.Forms.TextBox
        Me.datagridclientes = New System.Windows.Forms.DataGridView
        Me.datagridservicos = New System.Windows.Forms.DataGridView
        Me.lbldatagrid = New System.Windows.Forms.Label
        Me.txtcodigoagenda = New System.Windows.Forms.TextBox
        CType(Me.datagridagenda, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.datagridclientes, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.datagridservicos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 12)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(39, 18)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Data"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(12, 44)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(121, 18)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Hora da consulta"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(12, 78)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(80, 18)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "RG Cliente"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(12, 105)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(98, 18)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "Nome Cliente"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(12, 137)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(77, 18)
        Me.Label5.TabIndex = 0
        Me.Label5.Text = "Tel Cliente"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(6, 226)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(70, 18)
        Me.Label6.TabIndex = 0
        Me.Label6.Text = "Serviço 1"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(6, 255)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(70, 18)
        Me.Label7.TabIndex = 0
        Me.Label7.Text = "Serviço 2"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(6, 287)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(70, 18)
        Me.Label8.TabIndex = 0
        Me.Label8.Text = "Serviço 3"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(6, 319)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(70, 18)
        Me.Label9.TabIndex = 0
        Me.Label9.Text = "Serviço 4"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(485, 203)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(113, 18)
        Me.Label10.TabIndex = 0
        Me.Label10.Text = "Tipo de serviço:"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(683, 203)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(119, 18)
        Me.Label14.TabIndex = 0
        Me.Label14.Text = "Valor do serviço:"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.Location = New System.Drawing.Point(849, 203)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(197, 18)
        Me.Label18.TabIndex = 0
        Me.Label18.Text = "Tempo estimado do serviço:"
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label22.Location = New System.Drawing.Point(488, 367)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(79, 18)
        Me.Label22.TabIndex = 0
        Me.Label22.Text = "Valor Total"
        '
        'txtnomecliente
        '
        Me.txtnomecliente.BackColor = System.Drawing.Color.White
        Me.txtnomecliente.Location = New System.Drawing.Point(139, 102)
        Me.txtnomecliente.MaxLength = 255
        Me.txtnomecliente.Name = "txtnomecliente"
        Me.txtnomecliente.ReadOnly = True
        Me.txtnomecliente.Size = New System.Drawing.Size(109, 20)
        Me.txtnomecliente.TabIndex = 4
        '
        'btnnovaconsulta
        '
        Me.btnnovaconsulta.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnnovaconsulta.Location = New System.Drawing.Point(382, 12)
        Me.btnnovaconsulta.Name = "btnnovaconsulta"
        Me.btnnovaconsulta.Size = New System.Drawing.Size(107, 26)
        Me.btnnovaconsulta.TabIndex = 29
        Me.btnnovaconsulta.Text = "Nova consulta"
        Me.btnnovaconsulta.UseVisualStyleBackColor = True
        '
        'btncancelar
        '
        Me.btncancelar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btncancelar.Location = New System.Drawing.Point(382, 73)
        Me.btncancelar.Name = "btncancelar"
        Me.btncancelar.Size = New System.Drawing.Size(105, 26)
        Me.btncancelar.TabIndex = 34
        Me.btncancelar.Text = "Cancelar"
        Me.btncancelar.UseVisualStyleBackColor = True
        '
        'btnsalvar
        '
        Me.btnsalvar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnsalvar.Location = New System.Drawing.Point(382, 44)
        Me.btnsalvar.Name = "btnsalvar"
        Me.btnsalvar.Size = New System.Drawing.Size(106, 26)
        Me.btnsalvar.TabIndex = 32
        Me.btnsalvar.Text = "Salvar"
        Me.btnsalvar.UseVisualStyleBackColor = True
        '
        'btnconsultas
        '
        Me.btnconsultas.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnconsultas.Location = New System.Drawing.Point(548, 44)
        Me.btnconsultas.Name = "btnconsultas"
        Me.btnconsultas.Size = New System.Drawing.Size(133, 26)
        Me.btnconsultas.TabIndex = 35
        Me.btnconsultas.Text = "Consultas do Dia"
        Me.btnconsultas.UseVisualStyleBackColor = True
        '
        'datagridagenda
        '
        Me.datagridagenda.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.datagridagenda.Location = New System.Drawing.Point(15, 498)
        Me.datagridagenda.Name = "datagridagenda"
        Me.datagridagenda.Size = New System.Drawing.Size(1274, 245)
        Me.datagridagenda.TabIndex = 28
        '
        'txtvalor1
        '
        Me.txtvalor1.Location = New System.Drawing.Point(686, 222)
        Me.txtvalor1.Name = "txtvalor1"
        Me.txtvalor1.Size = New System.Drawing.Size(126, 20)
        Me.txtvalor1.TabIndex = 9
        '
        'txtvalor2
        '
        Me.txtvalor2.Location = New System.Drawing.Point(686, 251)
        Me.txtvalor2.Name = "txtvalor2"
        Me.txtvalor2.Size = New System.Drawing.Size(126, 20)
        Me.txtvalor2.TabIndex = 14
        '
        'txtvalor3
        '
        Me.txtvalor3.Location = New System.Drawing.Point(686, 283)
        Me.txtvalor3.Name = "txtvalor3"
        Me.txtvalor3.Size = New System.Drawing.Size(126, 20)
        Me.txtvalor3.TabIndex = 19
        '
        'txtvalor4
        '
        Me.txtvalor4.Location = New System.Drawing.Point(686, 315)
        Me.txtvalor4.Name = "txtvalor4"
        Me.txtvalor4.Size = New System.Drawing.Size(126, 20)
        Me.txtvalor4.TabIndex = 24
        '
        'txtvalortotal
        '
        Me.txtvalortotal.Location = New System.Drawing.Point(575, 365)
        Me.txtvalortotal.Name = "txtvalortotal"
        Me.txtvalortotal.Size = New System.Drawing.Size(126, 20)
        Me.txtvalortotal.TabIndex = 26
        '
        'txtservico1
        '
        Me.txtservico1.Location = New System.Drawing.Point(82, 224)
        Me.txtservico1.MaxLength = 255
        Me.txtservico1.Name = "txtservico1"
        Me.txtservico1.Size = New System.Drawing.Size(153, 20)
        Me.txtservico1.TabIndex = 6
        '
        'txtservico2
        '
        Me.txtservico2.Location = New System.Drawing.Point(82, 253)
        Me.txtservico2.MaxLength = 255
        Me.txtservico2.Name = "txtservico2"
        Me.txtservico2.Size = New System.Drawing.Size(153, 20)
        Me.txtservico2.TabIndex = 11
        '
        'txtservico3
        '
        Me.txtservico3.Location = New System.Drawing.Point(82, 282)
        Me.txtservico3.MaxLength = 255
        Me.txtservico3.Name = "txtservico3"
        Me.txtservico3.Size = New System.Drawing.Size(153, 20)
        Me.txtservico3.TabIndex = 16
        '
        'txtservico4
        '
        Me.txtservico4.Location = New System.Drawing.Point(82, 317)
        Me.txtservico4.MaxLength = 255
        Me.txtservico4.Name = "txtservico4"
        Me.txtservico4.Size = New System.Drawing.Size(153, 20)
        Me.txtservico4.TabIndex = 21
        '
        'txthora
        '
        Me.txthora.Location = New System.Drawing.Point(139, 44)
        Me.txthora.Mask = "00:00"
        Me.txthora.Name = "txthora"
        Me.txthora.Size = New System.Drawing.Size(109, 20)
        Me.txthora.TabIndex = 2
        '
        'txtrgcliente
        '
        Me.txtrgcliente.Location = New System.Drawing.Point(139, 73)
        Me.txtrgcliente.Mask = "00,000,000-0"
        Me.txtrgcliente.Name = "txtrgcliente"
        Me.txtrgcliente.Size = New System.Drawing.Size(109, 20)
        Me.txtrgcliente.TabIndex = 3
        '
        'txttempo1
        '
        Me.txttempo1.Location = New System.Drawing.Point(852, 224)
        Me.txttempo1.Mask = "00:00"
        Me.txttempo1.Name = "txttempo1"
        Me.txttempo1.Size = New System.Drawing.Size(157, 20)
        Me.txttempo1.TabIndex = 10
        '
        'txttempo2
        '
        Me.txttempo2.Location = New System.Drawing.Point(852, 253)
        Me.txttempo2.Mask = "00:00"
        Me.txttempo2.Name = "txttempo2"
        Me.txttempo2.Size = New System.Drawing.Size(157, 20)
        Me.txttempo2.TabIndex = 15
        '
        'txttempo3
        '
        Me.txttempo3.Location = New System.Drawing.Point(852, 287)
        Me.txttempo3.Mask = "00:00"
        Me.txttempo3.Name = "txttempo3"
        Me.txttempo3.Size = New System.Drawing.Size(157, 20)
        Me.txttempo3.TabIndex = 20
        '
        'txttempo4
        '
        Me.txttempo4.Location = New System.Drawing.Point(852, 317)
        Me.txttempo4.Mask = "00:00"
        Me.txttempo4.Name = "txttempo4"
        Me.txttempo4.Size = New System.Drawing.Size(157, 20)
        Me.txttempo4.TabIndex = 25
        '
        'txttelcliente
        '
        Me.txttelcliente.BackColor = System.Drawing.Color.White
        Me.txttelcliente.Location = New System.Drawing.Point(139, 128)
        Me.txttelcliente.Mask = "(00) 0000-0000"
        Me.txttelcliente.Name = "txttelcliente"
        Me.txttelcliente.ReadOnly = True
        Me.txttelcliente.Size = New System.Drawing.Size(109, 20)
        Me.txttelcliente.TabIndex = 5
        '
        'txtdata
        '
        Me.txtdata.CustomFormat = ""
        Me.txtdata.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.txtdata.Location = New System.Drawing.Point(139, 10)
        Me.txtdata.Name = "txtdata"
        Me.txtdata.Size = New System.Drawing.Size(109, 20)
        Me.txtdata.TabIndex = 30
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label23.Location = New System.Drawing.Point(752, 367)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(92, 18)
        Me.Label23.TabIndex = 0
        Me.Label23.Text = "Tempo Total"
        '
        'txttempototal
        '
        Me.txttempototal.Location = New System.Drawing.Point(852, 365)
        Me.txttempototal.Mask = "00:00"
        Me.txttempototal.Name = "txttempototal"
        Me.txttempototal.Size = New System.Drawing.Size(86, 20)
        Me.txttempototal.TabIndex = 27
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label24.Location = New System.Drawing.Point(79, 203)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(182, 18)
        Me.Label24.TabIndex = 31
        Me.Label24.Text = "Insira o código do serviço:"
        '
        'txtnome4
        '
        Me.txtnome4.Location = New System.Drawing.Point(302, 317)
        Me.txtnome4.MaxLength = 255
        Me.txtnome4.Name = "txtnome4"
        Me.txtnome4.Size = New System.Drawing.Size(153, 20)
        Me.txtnome4.TabIndex = 22
        '
        'txtnome3
        '
        Me.txtnome3.Location = New System.Drawing.Point(302, 282)
        Me.txtnome3.MaxLength = 255
        Me.txtnome3.Name = "txtnome3"
        Me.txtnome3.Size = New System.Drawing.Size(153, 20)
        Me.txtnome3.TabIndex = 17
        '
        'txtnome2
        '
        Me.txtnome2.Location = New System.Drawing.Point(302, 253)
        Me.txtnome2.MaxLength = 255
        Me.txtnome2.Name = "txtnome2"
        Me.txtnome2.Size = New System.Drawing.Size(153, 20)
        Me.txtnome2.TabIndex = 12
        '
        'txtnome1
        '
        Me.txtnome1.Location = New System.Drawing.Point(302, 224)
        Me.txtnome1.MaxLength = 255
        Me.txtnome1.Name = "txtnome1"
        Me.txtnome1.Size = New System.Drawing.Size(153, 20)
        Me.txtnome1.TabIndex = 7
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label25.Location = New System.Drawing.Point(299, 203)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(49, 18)
        Me.Label25.TabIndex = 36
        Me.Label25.Text = "Nome"
        '
        'txttipo1
        '
        Me.txttipo1.Location = New System.Drawing.Point(488, 226)
        Me.txttipo1.MaxLength = 255
        Me.txttipo1.Name = "txttipo1"
        Me.txttipo1.Size = New System.Drawing.Size(153, 20)
        Me.txttipo1.TabIndex = 37
        '
        'txttipo4
        '
        Me.txttipo4.Location = New System.Drawing.Point(488, 317)
        Me.txttipo4.MaxLength = 255
        Me.txttipo4.Name = "txttipo4"
        Me.txttipo4.Size = New System.Drawing.Size(153, 20)
        Me.txttipo4.TabIndex = 40
        '
        'txttipo3
        '
        Me.txttipo3.Location = New System.Drawing.Point(488, 282)
        Me.txttipo3.MaxLength = 255
        Me.txttipo3.Name = "txttipo3"
        Me.txttipo3.Size = New System.Drawing.Size(153, 20)
        Me.txttipo3.TabIndex = 39
        '
        'txttipo2
        '
        Me.txttipo2.Location = New System.Drawing.Point(488, 253)
        Me.txttipo2.MaxLength = 255
        Me.txttipo2.Name = "txttipo2"
        Me.txttipo2.Size = New System.Drawing.Size(153, 20)
        Me.txttipo2.TabIndex = 38
        '
        'datagridclientes
        '
        Me.datagridclientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.datagridclientes.Location = New System.Drawing.Point(15, 498)
        Me.datagridclientes.Name = "datagridclientes"
        Me.datagridclientes.Size = New System.Drawing.Size(1274, 245)
        Me.datagridclientes.TabIndex = 41
        '
        'datagridservicos
        '
        Me.datagridservicos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.datagridservicos.Location = New System.Drawing.Point(12, 498)
        Me.datagridservicos.Name = "datagridservicos"
        Me.datagridservicos.Size = New System.Drawing.Size(1274, 245)
        Me.datagridservicos.TabIndex = 42
        '
        'lbldatagrid
        '
        Me.lbldatagrid.AutoSize = True
        Me.lbldatagrid.Location = New System.Drawing.Point(12, 464)
        Me.lbldatagrid.Name = "lbldatagrid"
        Me.lbldatagrid.Size = New System.Drawing.Size(161, 13)
        Me.lbldatagrid.TabIndex = 43
        Me.lbldatagrid.Text = "Tabela de Consultas Agendadas"
        '
        'txtcodigoagenda
        '
        Me.txtcodigoagenda.BackColor = System.Drawing.Color.White
        Me.txtcodigoagenda.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtcodigoagenda.ForeColor = System.Drawing.Color.Black
        Me.txtcodigoagenda.Location = New System.Drawing.Point(548, 19)
        Me.txtcodigoagenda.MaxLength = 255
        Me.txtcodigoagenda.Name = "txtcodigoagenda"
        Me.txtcodigoagenda.ReadOnly = True
        Me.txtcodigoagenda.Size = New System.Drawing.Size(153, 13)
        Me.txtcodigoagenda.TabIndex = 44
        '
        'frmagendamentoconsultas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.ClientSize = New System.Drawing.Size(1392, 816)
        Me.Controls.Add(Me.txtcodigoagenda)
        Me.Controls.Add(Me.lbldatagrid)
        Me.Controls.Add(Me.datagridservicos)
        Me.Controls.Add(Me.datagridclientes)
        Me.Controls.Add(Me.txttipo4)
        Me.Controls.Add(Me.txttipo3)
        Me.Controls.Add(Me.txttipo2)
        Me.Controls.Add(Me.txttipo1)
        Me.Controls.Add(Me.Label25)
        Me.Controls.Add(Me.txtnome4)
        Me.Controls.Add(Me.txtnome3)
        Me.Controls.Add(Me.txtnome2)
        Me.Controls.Add(Me.txtnome1)
        Me.Controls.Add(Me.Label24)
        Me.Controls.Add(Me.txtdata)
        Me.Controls.Add(Me.txttelcliente)
        Me.Controls.Add(Me.txttempototal)
        Me.Controls.Add(Me.txttempo4)
        Me.Controls.Add(Me.txttempo3)
        Me.Controls.Add(Me.txttempo2)
        Me.Controls.Add(Me.txttempo1)
        Me.Controls.Add(Me.txtrgcliente)
        Me.Controls.Add(Me.txthora)
        Me.Controls.Add(Me.txtservico4)
        Me.Controls.Add(Me.txtservico3)
        Me.Controls.Add(Me.txtservico2)
        Me.Controls.Add(Me.txtservico1)
        Me.Controls.Add(Me.txtvalortotal)
        Me.Controls.Add(Me.txtvalor4)
        Me.Controls.Add(Me.txtvalor3)
        Me.Controls.Add(Me.txtvalor2)
        Me.Controls.Add(Me.txtvalor1)
        Me.Controls.Add(Me.datagridagenda)
        Me.Controls.Add(Me.btnconsultas)
        Me.Controls.Add(Me.btnsalvar)
        Me.Controls.Add(Me.btncancelar)
        Me.Controls.Add(Me.btnnovaconsulta)
        Me.Controls.Add(Me.txtnomecliente)
        Me.Controls.Add(Me.Label23)
        Me.Controls.Add(Me.Label22)
        Me.Controls.Add(Me.Label18)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmagendamentoconsultas"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Agendamento de Consultas"
        CType(Me.datagridagenda, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.datagridclientes, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.datagridservicos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents txtnomecliente As System.Windows.Forms.TextBox
    Friend WithEvents btnnovaconsulta As System.Windows.Forms.Button
    Friend WithEvents btncancelar As System.Windows.Forms.Button
    Friend WithEvents btnsalvar As System.Windows.Forms.Button
    Friend WithEvents btnconsultas As System.Windows.Forms.Button
    Friend WithEvents datagridagenda As System.Windows.Forms.DataGridView
    Friend WithEvents txtvalor1 As System.Windows.Forms.TextBox
    Friend WithEvents txtvalor2 As System.Windows.Forms.TextBox
    Friend WithEvents txtvalor3 As System.Windows.Forms.TextBox
    Friend WithEvents txtvalor4 As System.Windows.Forms.TextBox
    Friend WithEvents txtvalortotal As System.Windows.Forms.TextBox
    Friend WithEvents txtservico1 As System.Windows.Forms.TextBox
    Friend WithEvents txtservico2 As System.Windows.Forms.TextBox
    Friend WithEvents txtservico3 As System.Windows.Forms.TextBox
    Friend WithEvents txtservico4 As System.Windows.Forms.TextBox
    Friend WithEvents txthora As System.Windows.Forms.MaskedTextBox
    Friend WithEvents txtrgcliente As System.Windows.Forms.MaskedTextBox
    Friend WithEvents txttempo1 As System.Windows.Forms.MaskedTextBox
    Friend WithEvents txttempo2 As System.Windows.Forms.MaskedTextBox
    Friend WithEvents txttempo3 As System.Windows.Forms.MaskedTextBox
    Friend WithEvents txttempo4 As System.Windows.Forms.MaskedTextBox
    Friend WithEvents txttelcliente As System.Windows.Forms.MaskedTextBox
    Friend WithEvents txtdata As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label23 As System.Windows.Forms.Label
    Friend WithEvents txttempototal As System.Windows.Forms.MaskedTextBox
    Friend WithEvents Label24 As System.Windows.Forms.Label
    Friend WithEvents txtnome4 As System.Windows.Forms.TextBox
    Friend WithEvents txtnome3 As System.Windows.Forms.TextBox
    Friend WithEvents txtnome2 As System.Windows.Forms.TextBox
    Friend WithEvents txtnome1 As System.Windows.Forms.TextBox
    Friend WithEvents Label25 As System.Windows.Forms.Label
    Friend WithEvents txttipo1 As System.Windows.Forms.TextBox
    Friend WithEvents txttipo4 As System.Windows.Forms.TextBox
    Friend WithEvents txttipo3 As System.Windows.Forms.TextBox
    Friend WithEvents txttipo2 As System.Windows.Forms.TextBox
    Friend WithEvents datagridclientes As System.Windows.Forms.DataGridView
    Friend WithEvents datagridservicos As System.Windows.Forms.DataGridView
    Friend WithEvents lbldatagrid As System.Windows.Forms.Label
    Friend WithEvents txtcodigoagenda As System.Windows.Forms.TextBox
End Class
