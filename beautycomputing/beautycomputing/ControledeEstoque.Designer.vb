<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmcontroleestoque
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmcontroleestoque))
        Me.pltabas = New System.Windows.Forms.TabControl
        Me.abaproduto = New System.Windows.Forms.TabPage
        Me.btnexcluirproduto = New System.Windows.Forms.Button
        Me.txtfornecedor = New System.Windows.Forms.TextBox
        Me.lblfornecedor = New System.Windows.Forms.Label
        Me.btnsalvarproduto = New System.Windows.Forms.Button
        Me.btneditarproduto = New System.Windows.Forms.Button
        Me.btncancelarproduto = New System.Windows.Forms.Button
        Me.btnnovoproduto = New System.Windows.Forms.Button
        Me.datagridprodutos = New System.Windows.Forms.DataGridView
        Me.txtcategoria = New System.Windows.Forms.TextBox
        Me.txttipodeproduto = New System.Windows.Forms.TextBox
        Me.txtvalorunitario = New System.Windows.Forms.TextBox
        Me.txtnomeproduto = New System.Windows.Forms.TextBox
        Me.txtcodproduto = New System.Windows.Forms.TextBox
        Me.lblcategoria = New System.Windows.Forms.Label
        Me.lbltipo = New System.Windows.Forms.Label
        Me.lblvalor = New System.Windows.Forms.Label
        Me.lblnome = New System.Windows.Forms.Label
        Me.lblcodigo = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.abaentrada = New System.Windows.Forms.TabPage
        Me.txtdataentrada = New System.Windows.Forms.DateTimePicker
        Me.txtcategoriaentrada = New System.Windows.Forms.TextBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.txtcodentrada = New System.Windows.Forms.TextBox
        Me.txttipoentrada = New System.Windows.Forms.TextBox
        Me.lbltipoentrada = New System.Windows.Forms.Label
        Me.btnexcluirentrada = New System.Windows.Forms.Button
        Me.btnsalvarentrada = New System.Windows.Forms.Button
        Me.btncancelarentrada = New System.Windows.Forms.Button
        Me.btnnovaentrada = New System.Windows.Forms.Button
        Me.btnabrirlistaentrada = New System.Windows.Forms.Button
        Me.txttotalvalorentradaprod = New System.Windows.Forms.TextBox
        Me.txtquantidadeentrada = New System.Windows.Forms.TextBox
        Me.txtvalorunitarioentrada = New System.Windows.Forms.TextBox
        Me.txtnomeprodutoentrada = New System.Windows.Forms.TextBox
        Me.txtcodprodutoentrada = New System.Windows.Forms.TextBox
        Me.datagridentrada = New System.Windows.Forms.DataGridView
        Me.lbltotalentrada = New System.Windows.Forms.Label
        Me.lblquantidadeentrada = New System.Windows.Forms.Label
        Me.lblvalorentrada = New System.Windows.Forms.Label
        Me.lblnomeentrada = New System.Windows.Forms.Label
        Me.lblcodentrada = New System.Windows.Forms.Label
        Me.lbldataentrada = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.abasaida = New System.Windows.Forms.TabPage
        Me.txtdatasaida = New System.Windows.Forms.DateTimePicker
        Me.txtcategoriasaida = New System.Windows.Forms.TextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.txtcodsaida = New System.Windows.Forms.TextBox
        Me.txttiposaida = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.btnexcluirsaida = New System.Windows.Forms.Button
        Me.datagridsaida = New System.Windows.Forms.DataGridView
        Me.btnsalvarsaida = New System.Windows.Forms.Button
        Me.btncancelarsaida = New System.Windows.Forms.Button
        Me.btnnovosaida = New System.Windows.Forms.Button
        Me.btnabrirlistasaida = New System.Windows.Forms.Button
        Me.txttotalsaida = New System.Windows.Forms.TextBox
        Me.Label21 = New System.Windows.Forms.Label
        Me.Label20 = New System.Windows.Forms.Label
        Me.txtquantprodsaida = New System.Windows.Forms.TextBox
        Me.txtvaloruniprodsaida = New System.Windows.Forms.TextBox
        Me.txtnomeprodsaida = New System.Windows.Forms.TextBox
        Me.txtcodsaidaprod = New System.Windows.Forms.TextBox
        Me.lblquantidadesaida = New System.Windows.Forms.Label
        Me.Label16 = New System.Windows.Forms.Label
        Me.lblnomesaida = New System.Windows.Forms.Label
        Me.lblcodigosaida = New System.Windows.Forms.Label
        Me.lbldatasaida = New System.Windows.Forms.Label
        Me.pltabas.SuspendLayout()
        Me.abaproduto.SuspendLayout()
        CType(Me.datagridprodutos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.abaentrada.SuspendLayout()
        CType(Me.datagridentrada, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.abasaida.SuspendLayout()
        CType(Me.datagridsaida, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pltabas
        '
        Me.pltabas.Controls.Add(Me.abaproduto)
        Me.pltabas.Controls.Add(Me.abaentrada)
        Me.pltabas.Controls.Add(Me.abasaida)
        Me.pltabas.Location = New System.Drawing.Point(3, 3)
        Me.pltabas.Name = "pltabas"
        Me.pltabas.SelectedIndex = 0
        Me.pltabas.Size = New System.Drawing.Size(834, 522)
        Me.pltabas.TabIndex = 0
        '
        'abaproduto
        '
        Me.abaproduto.Controls.Add(Me.btnexcluirproduto)
        Me.abaproduto.Controls.Add(Me.txtfornecedor)
        Me.abaproduto.Controls.Add(Me.lblfornecedor)
        Me.abaproduto.Controls.Add(Me.btnsalvarproduto)
        Me.abaproduto.Controls.Add(Me.btneditarproduto)
        Me.abaproduto.Controls.Add(Me.btncancelarproduto)
        Me.abaproduto.Controls.Add(Me.btnnovoproduto)
        Me.abaproduto.Controls.Add(Me.datagridprodutos)
        Me.abaproduto.Controls.Add(Me.txtcategoria)
        Me.abaproduto.Controls.Add(Me.txttipodeproduto)
        Me.abaproduto.Controls.Add(Me.txtvalorunitario)
        Me.abaproduto.Controls.Add(Me.txtnomeproduto)
        Me.abaproduto.Controls.Add(Me.txtcodproduto)
        Me.abaproduto.Controls.Add(Me.lblcategoria)
        Me.abaproduto.Controls.Add(Me.lbltipo)
        Me.abaproduto.Controls.Add(Me.lblvalor)
        Me.abaproduto.Controls.Add(Me.lblnome)
        Me.abaproduto.Controls.Add(Me.lblcodigo)
        Me.abaproduto.Controls.Add(Me.Label1)
        Me.abaproduto.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.abaproduto.Location = New System.Drawing.Point(4, 22)
        Me.abaproduto.Name = "abaproduto"
        Me.abaproduto.Padding = New System.Windows.Forms.Padding(3)
        Me.abaproduto.Size = New System.Drawing.Size(826, 496)
        Me.abaproduto.TabIndex = 0
        Me.abaproduto.Text = "Produtos"
        Me.abaproduto.UseVisualStyleBackColor = True
        '
        'btnexcluirproduto
        '
        Me.btnexcluirproduto.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnexcluirproduto.Location = New System.Drawing.Point(598, 144)
        Me.btnexcluirproduto.Name = "btnexcluirproduto"
        Me.btnexcluirproduto.Size = New System.Drawing.Size(92, 30)
        Me.btnexcluirproduto.TabIndex = 10
        Me.btnexcluirproduto.Text = "Excluir"
        Me.btnexcluirproduto.UseVisualStyleBackColor = True
        '
        'txtfornecedor
        '
        Me.txtfornecedor.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtfornecedor.Location = New System.Drawing.Point(174, 193)
        Me.txtfornecedor.MaxLength = 255
        Me.txtfornecedor.Name = "txtfornecedor"
        Me.txtfornecedor.Size = New System.Drawing.Size(121, 22)
        Me.txtfornecedor.TabIndex = 6
        '
        'lblfornecedor
        '
        Me.lblfornecedor.AutoSize = True
        Me.lblfornecedor.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblfornecedor.Location = New System.Drawing.Point(33, 192)
        Me.lblfornecedor.Name = "lblfornecedor"
        Me.lblfornecedor.Size = New System.Drawing.Size(85, 18)
        Me.lblfornecedor.TabIndex = 0
        Me.lblfornecedor.Text = "Fornecedor"
        '
        'btnsalvarproduto
        '
        Me.btnsalvarproduto.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnsalvarproduto.Location = New System.Drawing.Point(598, 184)
        Me.btnsalvarproduto.Name = "btnsalvarproduto"
        Me.btnsalvarproduto.Size = New System.Drawing.Size(92, 30)
        Me.btnsalvarproduto.TabIndex = 11
        Me.btnsalvarproduto.Text = "Salvar"
        Me.btnsalvarproduto.UseVisualStyleBackColor = True
        '
        'btneditarproduto
        '
        Me.btneditarproduto.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btneditarproduto.Location = New System.Drawing.Point(598, 108)
        Me.btneditarproduto.Name = "btneditarproduto"
        Me.btneditarproduto.Size = New System.Drawing.Size(92, 30)
        Me.btneditarproduto.TabIndex = 9
        Me.btneditarproduto.Text = "Editar"
        Me.btneditarproduto.UseVisualStyleBackColor = True
        '
        'btncancelarproduto
        '
        Me.btncancelarproduto.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btncancelarproduto.Location = New System.Drawing.Point(598, 72)
        Me.btncancelarproduto.Name = "btncancelarproduto"
        Me.btncancelarproduto.Size = New System.Drawing.Size(92, 30)
        Me.btncancelarproduto.TabIndex = 8
        Me.btncancelarproduto.Text = "Cancelar"
        Me.btncancelarproduto.UseVisualStyleBackColor = True
        '
        'btnnovoproduto
        '
        Me.btnnovoproduto.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnnovoproduto.Location = New System.Drawing.Point(598, 36)
        Me.btnnovoproduto.Name = "btnnovoproduto"
        Me.btnnovoproduto.Size = New System.Drawing.Size(92, 30)
        Me.btnnovoproduto.TabIndex = 7
        Me.btnnovoproduto.Text = "Novo Produto"
        Me.btnnovoproduto.UseVisualStyleBackColor = True
        '
        'datagridprodutos
        '
        Me.datagridprodutos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.datagridprodutos.Location = New System.Drawing.Point(36, 245)
        Me.datagridprodutos.Name = "datagridprodutos"
        Me.datagridprodutos.Size = New System.Drawing.Size(744, 223)
        Me.datagridprodutos.TabIndex = 12
        '
        'txtcategoria
        '
        Me.txtcategoria.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtcategoria.Location = New System.Drawing.Point(174, 162)
        Me.txtcategoria.MaxLength = 255
        Me.txtcategoria.Name = "txtcategoria"
        Me.txtcategoria.Size = New System.Drawing.Size(121, 22)
        Me.txtcategoria.TabIndex = 5
        '
        'txttipodeproduto
        '
        Me.txttipodeproduto.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txttipodeproduto.Location = New System.Drawing.Point(174, 131)
        Me.txttipodeproduto.MaxLength = 255
        Me.txttipodeproduto.Name = "txttipodeproduto"
        Me.txttipodeproduto.Size = New System.Drawing.Size(121, 22)
        Me.txttipodeproduto.TabIndex = 4
        '
        'txtvalorunitario
        '
        Me.txtvalorunitario.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtvalorunitario.Location = New System.Drawing.Point(174, 104)
        Me.txtvalorunitario.MaxLength = 255
        Me.txtvalorunitario.Name = "txtvalorunitario"
        Me.txtvalorunitario.Size = New System.Drawing.Size(121, 22)
        Me.txtvalorunitario.TabIndex = 3
        '
        'txtnomeproduto
        '
        Me.txtnomeproduto.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtnomeproduto.Location = New System.Drawing.Point(174, 77)
        Me.txtnomeproduto.MaxLength = 255
        Me.txtnomeproduto.Name = "txtnomeproduto"
        Me.txtnomeproduto.Size = New System.Drawing.Size(121, 22)
        Me.txtnomeproduto.TabIndex = 2
        '
        'txtcodproduto
        '
        Me.txtcodproduto.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtcodproduto.Location = New System.Drawing.Point(174, 44)
        Me.txtcodproduto.MaxLength = 255
        Me.txtcodproduto.Name = "txtcodproduto"
        Me.txtcodproduto.Size = New System.Drawing.Size(121, 22)
        Me.txtcodproduto.TabIndex = 1
        '
        'lblcategoria
        '
        Me.lblcategoria.AutoSize = True
        Me.lblcategoria.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblcategoria.Location = New System.Drawing.Point(33, 161)
        Me.lblcategoria.Name = "lblcategoria"
        Me.lblcategoria.Size = New System.Drawing.Size(72, 18)
        Me.lblcategoria.TabIndex = 0
        Me.lblcategoria.Text = "Categoria"
        '
        'lbltipo
        '
        Me.lbltipo.AutoSize = True
        Me.lbltipo.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbltipo.Location = New System.Drawing.Point(33, 133)
        Me.lbltipo.Name = "lbltipo"
        Me.lbltipo.Size = New System.Drawing.Size(114, 18)
        Me.lbltipo.TabIndex = 0
        Me.lbltipo.Text = "Tipo de Produto"
        '
        'lblvalor
        '
        Me.lblvalor.AutoSize = True
        Me.lblvalor.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblvalor.Location = New System.Drawing.Point(33, 106)
        Me.lblvalor.Name = "lblvalor"
        Me.lblvalor.Size = New System.Drawing.Size(97, 18)
        Me.lblvalor.TabIndex = 0
        Me.lblvalor.Text = "Valor Unitario"
        '
        'lblnome
        '
        Me.lblnome.AutoSize = True
        Me.lblnome.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblnome.Location = New System.Drawing.Point(33, 76)
        Me.lblnome.Name = "lblnome"
        Me.lblnome.Size = New System.Drawing.Size(106, 18)
        Me.lblnome.TabIndex = 0
        Me.lblnome.Text = "Nome Produto"
        '
        'lblcodigo
        '
        Me.lblcodigo.AutoSize = True
        Me.lblcodigo.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblcodigo.Location = New System.Drawing.Point(33, 44)
        Me.lblcodigo.Name = "lblcodigo"
        Me.lblcodigo.Size = New System.Drawing.Size(113, 18)
        Me.lblcodigo.TabIndex = 0
        Me.lblcodigo.Text = "Codigo Produto"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(263, 3)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(156, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Cadastrar Produto"
        '
        'abaentrada
        '
        Me.abaentrada.Controls.Add(Me.txtdataentrada)
        Me.abaentrada.Controls.Add(Me.txtcategoriaentrada)
        Me.abaentrada.Controls.Add(Me.Label4)
        Me.abaentrada.Controls.Add(Me.txtcodentrada)
        Me.abaentrada.Controls.Add(Me.txttipoentrada)
        Me.abaentrada.Controls.Add(Me.lbltipoentrada)
        Me.abaentrada.Controls.Add(Me.btnexcluirentrada)
        Me.abaentrada.Controls.Add(Me.btnsalvarentrada)
        Me.abaentrada.Controls.Add(Me.btncancelarentrada)
        Me.abaentrada.Controls.Add(Me.btnnovaentrada)
        Me.abaentrada.Controls.Add(Me.btnabrirlistaentrada)
        Me.abaentrada.Controls.Add(Me.txttotalvalorentradaprod)
        Me.abaentrada.Controls.Add(Me.txtquantidadeentrada)
        Me.abaentrada.Controls.Add(Me.txtvalorunitarioentrada)
        Me.abaentrada.Controls.Add(Me.txtnomeprodutoentrada)
        Me.abaentrada.Controls.Add(Me.txtcodprodutoentrada)
        Me.abaentrada.Controls.Add(Me.datagridentrada)
        Me.abaentrada.Controls.Add(Me.lbltotalentrada)
        Me.abaentrada.Controls.Add(Me.lblquantidadeentrada)
        Me.abaentrada.Controls.Add(Me.lblvalorentrada)
        Me.abaentrada.Controls.Add(Me.lblnomeentrada)
        Me.abaentrada.Controls.Add(Me.lblcodentrada)
        Me.abaentrada.Controls.Add(Me.lbldataentrada)
        Me.abaentrada.Controls.Add(Me.Label7)
        Me.abaentrada.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.abaentrada.Location = New System.Drawing.Point(4, 22)
        Me.abaentrada.Name = "abaentrada"
        Me.abaentrada.Padding = New System.Windows.Forms.Padding(3)
        Me.abaentrada.Size = New System.Drawing.Size(826, 496)
        Me.abaentrada.TabIndex = 1
        Me.abaentrada.Text = "Entrada"
        Me.abaentrada.UseVisualStyleBackColor = True
        '
        'txtdataentrada
        '
        Me.txtdataentrada.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.txtdataentrada.Location = New System.Drawing.Point(136, 81)
        Me.txtdataentrada.Name = "txtdataentrada"
        Me.txtdataentrada.Size = New System.Drawing.Size(127, 24)
        Me.txtdataentrada.TabIndex = 402
        '
        'txtcategoriaentrada
        '
        Me.txtcategoriaentrada.Location = New System.Drawing.Point(136, 260)
        Me.txtcategoriaentrada.MaxLength = 255
        Me.txtcategoriaentrada.Name = "txtcategoriaentrada"
        Me.txtcategoriaentrada.Size = New System.Drawing.Size(127, 24)
        Me.txtcategoriaentrada.TabIndex = 19
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(21, 259)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(72, 18)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "Categoria"
        '
        'txtcodentrada
        '
        Me.txtcodentrada.Location = New System.Drawing.Point(136, 51)
        Me.txtcodentrada.MaxLength = 255
        Me.txtcodentrada.Name = "txtcodentrada"
        Me.txtcodentrada.Size = New System.Drawing.Size(127, 24)
        Me.txtcodentrada.TabIndex = 400
        '
        'txttipoentrada
        '
        Me.txttipoentrada.Location = New System.Drawing.Point(137, 172)
        Me.txttipoentrada.MaxLength = 255
        Me.txttipoentrada.Name = "txttipoentrada"
        Me.txttipoentrada.Size = New System.Drawing.Size(127, 24)
        Me.txttipoentrada.TabIndex = 16
        '
        'lbltipoentrada
        '
        Me.lbltipoentrada.AutoSize = True
        Me.lbltipoentrada.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbltipoentrada.Location = New System.Drawing.Point(22, 171)
        Me.lbltipoentrada.Name = "lbltipoentrada"
        Me.lbltipoentrada.Size = New System.Drawing.Size(115, 18)
        Me.lbltipoentrada.TabIndex = 0
        Me.lbltipoentrada.Text = "Tipo do Produto"
        '
        'btnexcluirentrada
        '
        Me.btnexcluirentrada.Location = New System.Drawing.Point(543, 171)
        Me.btnexcluirentrada.Name = "btnexcluirentrada"
        Me.btnexcluirentrada.Size = New System.Drawing.Size(92, 33)
        Me.btnexcluirentrada.TabIndex = 23
        Me.btnexcluirentrada.Text = "Excluir"
        Me.btnexcluirentrada.UseVisualStyleBackColor = True
        '
        'btnsalvarentrada
        '
        Me.btnsalvarentrada.Location = New System.Drawing.Point(543, 220)
        Me.btnsalvarentrada.Name = "btnsalvarentrada"
        Me.btnsalvarentrada.Size = New System.Drawing.Size(92, 33)
        Me.btnsalvarentrada.TabIndex = 24
        Me.btnsalvarentrada.Text = "Salvar"
        Me.btnsalvarentrada.UseVisualStyleBackColor = True
        '
        'btncancelarentrada
        '
        Me.btncancelarentrada.Location = New System.Drawing.Point(543, 124)
        Me.btncancelarentrada.Name = "btncancelarentrada"
        Me.btncancelarentrada.Size = New System.Drawing.Size(92, 33)
        Me.btncancelarentrada.TabIndex = 22
        Me.btncancelarentrada.Text = "Cancelar"
        Me.btncancelarentrada.UseVisualStyleBackColor = True
        '
        'btnnovaentrada
        '
        Me.btnnovaentrada.Location = New System.Drawing.Point(543, 80)
        Me.btnnovaentrada.Name = "btnnovaentrada"
        Me.btnnovaentrada.Size = New System.Drawing.Size(92, 33)
        Me.btnnovaentrada.TabIndex = 21
        Me.btnnovaentrada.Text = "Nova Entrada"
        Me.btnnovaentrada.UseVisualStyleBackColor = True
        '
        'btnabrirlistaentrada
        '
        Me.btnabrirlistaentrada.Location = New System.Drawing.Point(543, 38)
        Me.btnabrirlistaentrada.Name = "btnabrirlistaentrada"
        Me.btnabrirlistaentrada.Size = New System.Drawing.Size(92, 33)
        Me.btnabrirlistaentrada.TabIndex = 20
        Me.btnabrirlistaentrada.Text = "Abrir Lista"
        Me.btnabrirlistaentrada.UseVisualStyleBackColor = True
        '
        'txttotalvalorentradaprod
        '
        Me.txttotalvalorentradaprod.BackColor = System.Drawing.Color.White
        Me.txttotalvalorentradaprod.Location = New System.Drawing.Point(136, 314)
        Me.txttotalvalorentradaprod.MaxLength = 255
        Me.txttotalvalorentradaprod.Name = "txttotalvalorentradaprod"
        Me.txttotalvalorentradaprod.ReadOnly = True
        Me.txttotalvalorentradaprod.Size = New System.Drawing.Size(127, 24)
        Me.txttotalvalorentradaprod.TabIndex = 401
        '
        'txtquantidadeentrada
        '
        Me.txtquantidadeentrada.Location = New System.Drawing.Point(136, 230)
        Me.txtquantidadeentrada.MaxLength = 255
        Me.txtquantidadeentrada.Name = "txtquantidadeentrada"
        Me.txtquantidadeentrada.Size = New System.Drawing.Size(127, 24)
        Me.txtquantidadeentrada.TabIndex = 18
        '
        'txtvalorunitarioentrada
        '
        Me.txtvalorunitarioentrada.Location = New System.Drawing.Point(136, 199)
        Me.txtvalorunitarioentrada.MaxLength = 255
        Me.txtvalorunitarioentrada.Name = "txtvalorunitarioentrada"
        Me.txtvalorunitarioentrada.Size = New System.Drawing.Size(127, 24)
        Me.txtvalorunitarioentrada.TabIndex = 17
        '
        'txtnomeprodutoentrada
        '
        Me.txtnomeprodutoentrada.Location = New System.Drawing.Point(136, 141)
        Me.txtnomeprodutoentrada.MaxLength = 255
        Me.txtnomeprodutoentrada.Name = "txtnomeprodutoentrada"
        Me.txtnomeprodutoentrada.Size = New System.Drawing.Size(127, 24)
        Me.txtnomeprodutoentrada.TabIndex = 15
        '
        'txtcodprodutoentrada
        '
        Me.txtcodprodutoentrada.Location = New System.Drawing.Point(136, 113)
        Me.txtcodprodutoentrada.MaxLength = 255
        Me.txtcodprodutoentrada.Name = "txtcodprodutoentrada"
        Me.txtcodprodutoentrada.Size = New System.Drawing.Size(127, 24)
        Me.txtcodprodutoentrada.TabIndex = 14
        '
        'datagridentrada
        '
        Me.datagridentrada.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.datagridentrada.Location = New System.Drawing.Point(24, 358)
        Me.datagridentrada.Name = "datagridentrada"
        Me.datagridentrada.Size = New System.Drawing.Size(611, 132)
        Me.datagridentrada.TabIndex = 25
        '
        'lbltotalentrada
        '
        Me.lbltotalentrada.AutoSize = True
        Me.lbltotalentrada.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbltotalentrada.Location = New System.Drawing.Point(25, 317)
        Me.lbltotalentrada.Name = "lbltotalentrada"
        Me.lbltotalentrada.Size = New System.Drawing.Size(79, 18)
        Me.lbltotalentrada.TabIndex = 0
        Me.lbltotalentrada.Text = "Total Valor"
        '
        'lblquantidadeentrada
        '
        Me.lblquantidadeentrada.AutoSize = True
        Me.lblquantidadeentrada.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblquantidadeentrada.Location = New System.Drawing.Point(21, 229)
        Me.lblquantidadeentrada.Name = "lblquantidadeentrada"
        Me.lblquantidadeentrada.Size = New System.Drawing.Size(83, 18)
        Me.lblquantidadeentrada.TabIndex = 0
        Me.lblquantidadeentrada.Text = "Quantidade"
        '
        'lblvalorentrada
        '
        Me.lblvalorentrada.AutoSize = True
        Me.lblvalorentrada.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblvalorentrada.Location = New System.Drawing.Point(21, 198)
        Me.lblvalorentrada.Name = "lblvalorentrada"
        Me.lblvalorentrada.Size = New System.Drawing.Size(97, 18)
        Me.lblvalorentrada.TabIndex = 0
        Me.lblvalorentrada.Text = "Valor Unitario"
        '
        'lblnomeentrada
        '
        Me.lblnomeentrada.AutoSize = True
        Me.lblnomeentrada.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblnomeentrada.Location = New System.Drawing.Point(21, 140)
        Me.lblnomeentrada.Name = "lblnomeentrada"
        Me.lblnomeentrada.Size = New System.Drawing.Size(106, 18)
        Me.lblnomeentrada.TabIndex = 0
        Me.lblnomeentrada.Text = "Nome Produto"
        '
        'lblcodentrada
        '
        Me.lblcodentrada.AutoSize = True
        Me.lblcodentrada.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblcodentrada.Location = New System.Drawing.Point(21, 112)
        Me.lblcodentrada.Name = "lblcodentrada"
        Me.lblcodentrada.Size = New System.Drawing.Size(113, 18)
        Me.lblcodentrada.TabIndex = 0
        Me.lblcodentrada.Text = "Codigo Produto"
        '
        'lbldataentrada
        '
        Me.lbldataentrada.AutoSize = True
        Me.lbldataentrada.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbldataentrada.Location = New System.Drawing.Point(21, 80)
        Me.lbldataentrada.Name = "lbldataentrada"
        Me.lbldataentrada.Size = New System.Drawing.Size(39, 18)
        Me.lbldataentrada.TabIndex = 0
        Me.lbldataentrada.Text = "Data"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(209, 3)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(278, 20)
        Me.Label7.TabIndex = 0
        Me.Label7.Text = "Cadastro de Entrada de Produtos"
        '
        'abasaida
        '
        Me.abasaida.Controls.Add(Me.txtdatasaida)
        Me.abasaida.Controls.Add(Me.txtcategoriasaida)
        Me.abasaida.Controls.Add(Me.Label3)
        Me.abasaida.Controls.Add(Me.txtcodsaida)
        Me.abasaida.Controls.Add(Me.txttiposaida)
        Me.abasaida.Controls.Add(Me.Label2)
        Me.abasaida.Controls.Add(Me.btnexcluirsaida)
        Me.abasaida.Controls.Add(Me.datagridsaida)
        Me.abasaida.Controls.Add(Me.btnsalvarsaida)
        Me.abasaida.Controls.Add(Me.btncancelarsaida)
        Me.abasaida.Controls.Add(Me.btnnovosaida)
        Me.abasaida.Controls.Add(Me.btnabrirlistasaida)
        Me.abasaida.Controls.Add(Me.txttotalsaida)
        Me.abasaida.Controls.Add(Me.Label21)
        Me.abasaida.Controls.Add(Me.Label20)
        Me.abasaida.Controls.Add(Me.txtquantprodsaida)
        Me.abasaida.Controls.Add(Me.txtvaloruniprodsaida)
        Me.abasaida.Controls.Add(Me.txtnomeprodsaida)
        Me.abasaida.Controls.Add(Me.txtcodsaidaprod)
        Me.abasaida.Controls.Add(Me.lblquantidadesaida)
        Me.abasaida.Controls.Add(Me.Label16)
        Me.abasaida.Controls.Add(Me.lblnomesaida)
        Me.abasaida.Controls.Add(Me.lblcodigosaida)
        Me.abasaida.Controls.Add(Me.lbldatasaida)
        Me.abasaida.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.abasaida.Location = New System.Drawing.Point(4, 22)
        Me.abasaida.Name = "abasaida"
        Me.abasaida.Size = New System.Drawing.Size(826, 496)
        Me.abasaida.TabIndex = 2
        Me.abasaida.Text = "Saida"
        Me.abasaida.UseVisualStyleBackColor = True
        '
        'txtdatasaida
        '
        Me.txtdatasaida.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.txtdatasaida.Location = New System.Drawing.Point(132, 79)
        Me.txtdatasaida.Name = "txtdatasaida"
        Me.txtdatasaida.Size = New System.Drawing.Size(127, 24)
        Me.txtdatasaida.TabIndex = 404
        '
        'txtcategoriasaida
        '
        Me.txtcategoriasaida.Location = New System.Drawing.Point(132, 258)
        Me.txtcategoriasaida.MaxLength = 255
        Me.txtcategoriasaida.Name = "txtcategoriasaida"
        Me.txtcategoriasaida.Size = New System.Drawing.Size(127, 24)
        Me.txtcategoriasaida.TabIndex = 32
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(17, 257)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(72, 18)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Categoria"
        '
        'txtcodsaida
        '
        Me.txtcodsaida.Location = New System.Drawing.Point(132, 49)
        Me.txtcodsaida.MaxLength = 255
        Me.txtcodsaida.Name = "txtcodsaida"
        Me.txtcodsaida.Size = New System.Drawing.Size(127, 24)
        Me.txtcodsaida.TabIndex = 402
        Me.txtcodsaida.Visible = False
        '
        'txttiposaida
        '
        Me.txttiposaida.Location = New System.Drawing.Point(132, 171)
        Me.txttiposaida.MaxLength = 255
        Me.txttiposaida.Name = "txttiposaida"
        Me.txttiposaida.Size = New System.Drawing.Size(127, 24)
        Me.txttiposaida.TabIndex = 29
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(17, 170)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(115, 18)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Tipo do Produto"
        '
        'btnexcluirsaida
        '
        Me.btnexcluirsaida.Location = New System.Drawing.Point(539, 172)
        Me.btnexcluirsaida.Name = "btnexcluirsaida"
        Me.btnexcluirsaida.Size = New System.Drawing.Size(92, 33)
        Me.btnexcluirsaida.TabIndex = 36
        Me.btnexcluirsaida.Text = "Excluir"
        Me.btnexcluirsaida.UseVisualStyleBackColor = True
        '
        'datagridsaida
        '
        Me.datagridsaida.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.datagridsaida.Location = New System.Drawing.Point(5, 351)
        Me.datagridsaida.Name = "datagridsaida"
        Me.datagridsaida.Size = New System.Drawing.Size(611, 132)
        Me.datagridsaida.TabIndex = 38
        '
        'btnsalvarsaida
        '
        Me.btnsalvarsaida.Location = New System.Drawing.Point(539, 213)
        Me.btnsalvarsaida.Name = "btnsalvarsaida"
        Me.btnsalvarsaida.Size = New System.Drawing.Size(92, 33)
        Me.btnsalvarsaida.TabIndex = 37
        Me.btnsalvarsaida.Text = "Salvar"
        Me.btnsalvarsaida.UseVisualStyleBackColor = True
        '
        'btncancelarsaida
        '
        Me.btncancelarsaida.Location = New System.Drawing.Point(539, 131)
        Me.btncancelarsaida.Name = "btncancelarsaida"
        Me.btncancelarsaida.Size = New System.Drawing.Size(92, 33)
        Me.btncancelarsaida.TabIndex = 35
        Me.btncancelarsaida.Text = "Cancelar"
        Me.btncancelarsaida.UseVisualStyleBackColor = True
        '
        'btnnovosaida
        '
        Me.btnnovosaida.Location = New System.Drawing.Point(539, 87)
        Me.btnnovosaida.Name = "btnnovosaida"
        Me.btnnovosaida.Size = New System.Drawing.Size(92, 33)
        Me.btnnovosaida.TabIndex = 34
        Me.btnnovosaida.Text = "Nova Entrada"
        Me.btnnovosaida.UseVisualStyleBackColor = True
        '
        'btnabrirlistasaida
        '
        Me.btnabrirlistasaida.Location = New System.Drawing.Point(539, 45)
        Me.btnabrirlistasaida.Name = "btnabrirlistasaida"
        Me.btnabrirlistasaida.Size = New System.Drawing.Size(92, 33)
        Me.btnabrirlistasaida.TabIndex = 33
        Me.btnabrirlistasaida.Text = "Abrir Lista"
        Me.btnabrirlistasaida.UseVisualStyleBackColor = True
        '
        'txttotalsaida
        '
        Me.txttotalsaida.BackColor = System.Drawing.Color.White
        Me.txttotalsaida.Location = New System.Drawing.Point(132, 311)
        Me.txttotalsaida.MaxLength = 255
        Me.txttotalsaida.Name = "txttotalsaida"
        Me.txttotalsaida.ReadOnly = True
        Me.txttotalsaida.Size = New System.Drawing.Size(127, 24)
        Me.txttotalsaida.TabIndex = 403
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label21.Location = New System.Drawing.Point(15, 311)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(45, 18)
        Me.Label21.TabIndex = 0
        Me.Label21.Text = "Total "
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.Location = New System.Drawing.Point(207, 9)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(244, 18)
        Me.Label20.TabIndex = 0
        Me.Label20.Text = "Cadastro de Saida de Produtos"
        '
        'txtquantprodsaida
        '
        Me.txtquantprodsaida.Location = New System.Drawing.Point(132, 228)
        Me.txtquantprodsaida.MaxLength = 255
        Me.txtquantprodsaida.Name = "txtquantprodsaida"
        Me.txtquantprodsaida.Size = New System.Drawing.Size(127, 24)
        Me.txtquantprodsaida.TabIndex = 31
        '
        'txtvaloruniprodsaida
        '
        Me.txtvaloruniprodsaida.Location = New System.Drawing.Point(132, 201)
        Me.txtvaloruniprodsaida.MaxLength = 255
        Me.txtvaloruniprodsaida.Name = "txtvaloruniprodsaida"
        Me.txtvaloruniprodsaida.Size = New System.Drawing.Size(127, 24)
        Me.txtvaloruniprodsaida.TabIndex = 30
        '
        'txtnomeprodsaida
        '
        Me.txtnomeprodsaida.Location = New System.Drawing.Point(132, 139)
        Me.txtnomeprodsaida.MaxLength = 255
        Me.txtnomeprodsaida.Name = "txtnomeprodsaida"
        Me.txtnomeprodsaida.Size = New System.Drawing.Size(127, 24)
        Me.txtnomeprodsaida.TabIndex = 28
        '
        'txtcodsaidaprod
        '
        Me.txtcodsaidaprod.Location = New System.Drawing.Point(132, 111)
        Me.txtcodsaidaprod.MaxLength = 255
        Me.txtcodsaidaprod.Name = "txtcodsaidaprod"
        Me.txtcodsaidaprod.Size = New System.Drawing.Size(127, 24)
        Me.txtcodsaidaprod.TabIndex = 27
        '
        'lblquantidadesaida
        '
        Me.lblquantidadesaida.AutoSize = True
        Me.lblquantidadesaida.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblquantidadesaida.Location = New System.Drawing.Point(17, 227)
        Me.lblquantidadesaida.Name = "lblquantidadesaida"
        Me.lblquantidadesaida.Size = New System.Drawing.Size(83, 18)
        Me.lblquantidadesaida.TabIndex = 0
        Me.lblquantidadesaida.Text = "Quantidade"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(17, 200)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(97, 18)
        Me.Label16.TabIndex = 0
        Me.Label16.Text = "Valor Unitario"
        '
        'lblnomesaida
        '
        Me.lblnomesaida.AutoSize = True
        Me.lblnomesaida.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblnomesaida.Location = New System.Drawing.Point(17, 138)
        Me.lblnomesaida.Name = "lblnomesaida"
        Me.lblnomesaida.Size = New System.Drawing.Size(106, 18)
        Me.lblnomesaida.TabIndex = 0
        Me.lblnomesaida.Text = "Nome Produto"
        '
        'lblcodigosaida
        '
        Me.lblcodigosaida.AutoSize = True
        Me.lblcodigosaida.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblcodigosaida.Location = New System.Drawing.Point(17, 110)
        Me.lblcodigosaida.Name = "lblcodigosaida"
        Me.lblcodigosaida.Size = New System.Drawing.Size(113, 18)
        Me.lblcodigosaida.TabIndex = 0
        Me.lblcodigosaida.Text = "Código Produto"
        '
        'lbldatasaida
        '
        Me.lbldatasaida.AutoSize = True
        Me.lbldatasaida.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbldatasaida.Location = New System.Drawing.Point(17, 78)
        Me.lbldatasaida.Name = "lbldatasaida"
        Me.lbldatasaida.Size = New System.Drawing.Size(39, 18)
        Me.lbldatasaida.TabIndex = 0
        Me.lbldatasaida.Text = "Data"
        '
        'frmcontroleestoque
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.ClientSize = New System.Drawing.Size(1392, 816)
        Me.Controls.Add(Me.pltabas)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmcontroleestoque"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ControledeEstoque"
        Me.pltabas.ResumeLayout(False)
        Me.abaproduto.ResumeLayout(False)
        Me.abaproduto.PerformLayout()
        CType(Me.datagridprodutos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.abaentrada.ResumeLayout(False)
        Me.abaentrada.PerformLayout()
        CType(Me.datagridentrada, System.ComponentModel.ISupportInitialize).EndInit()
        Me.abasaida.ResumeLayout(False)
        Me.abasaida.PerformLayout()
        CType(Me.datagridsaida, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents pltabas As System.Windows.Forms.TabControl
    Friend WithEvents abaproduto As System.Windows.Forms.TabPage
    Friend WithEvents datagridprodutos As System.Windows.Forms.DataGridView
    Friend WithEvents txtcategoria As System.Windows.Forms.TextBox
    Friend WithEvents txttipodeproduto As System.Windows.Forms.TextBox
    Friend WithEvents txtvalorunitario As System.Windows.Forms.TextBox
    Friend WithEvents txtnomeproduto As System.Windows.Forms.TextBox
    Friend WithEvents txtcodproduto As System.Windows.Forms.TextBox
    Friend WithEvents lblcategoria As System.Windows.Forms.Label
    Friend WithEvents lbltipo As System.Windows.Forms.Label
    Friend WithEvents lblvalor As System.Windows.Forms.Label
    Friend WithEvents lblnome As System.Windows.Forms.Label
    Friend WithEvents lblcodigo As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents abaentrada As System.Windows.Forms.TabPage
    Friend WithEvents abasaida As System.Windows.Forms.TabPage
    Friend WithEvents btnsalvarproduto As System.Windows.Forms.Button
    Friend WithEvents btneditarproduto As System.Windows.Forms.Button
    Friend WithEvents btncancelarproduto As System.Windows.Forms.Button
    Friend WithEvents btnnovoproduto As System.Windows.Forms.Button
    Friend WithEvents btnabrirlistaentrada As System.Windows.Forms.Button
    Friend WithEvents txttotalvalorentradaprod As System.Windows.Forms.TextBox
    Friend WithEvents txtquantidadeentrada As System.Windows.Forms.TextBox
    Friend WithEvents txtvalorunitarioentrada As System.Windows.Forms.TextBox
    Friend WithEvents txtnomeprodutoentrada As System.Windows.Forms.TextBox
    Friend WithEvents txtcodprodutoentrada As System.Windows.Forms.TextBox
    Friend WithEvents datagridentrada As System.Windows.Forms.DataGridView
    Friend WithEvents lbltotalentrada As System.Windows.Forms.Label
    Friend WithEvents lblquantidadeentrada As System.Windows.Forms.Label
    Friend WithEvents lblvalorentrada As System.Windows.Forms.Label
    Friend WithEvents lblnomeentrada As System.Windows.Forms.Label
    Friend WithEvents lblcodentrada As System.Windows.Forms.Label
    Friend WithEvents lbldataentrada As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents btnsalvarentrada As System.Windows.Forms.Button
    Friend WithEvents btncancelarentrada As System.Windows.Forms.Button
    Friend WithEvents btnnovaentrada As System.Windows.Forms.Button
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents txtquantprodsaida As System.Windows.Forms.TextBox
    Friend WithEvents txtvaloruniprodsaida As System.Windows.Forms.TextBox
    Friend WithEvents txtnomeprodsaida As System.Windows.Forms.TextBox
    Friend WithEvents txtcodsaidaprod As System.Windows.Forms.TextBox
    Friend WithEvents lblquantidadesaida As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents lblnomesaida As System.Windows.Forms.Label
    Friend WithEvents lblcodigosaida As System.Windows.Forms.Label
    Friend WithEvents lbldatasaida As System.Windows.Forms.Label
    Friend WithEvents datagridsaida As System.Windows.Forms.DataGridView
    Friend WithEvents btnsalvarsaida As System.Windows.Forms.Button
    Friend WithEvents btncancelarsaida As System.Windows.Forms.Button
    Friend WithEvents btnnovosaida As System.Windows.Forms.Button
    Friend WithEvents btnabrirlistasaida As System.Windows.Forms.Button
    Friend WithEvents txttotalsaida As System.Windows.Forms.TextBox
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents txtfornecedor As System.Windows.Forms.TextBox
    Friend WithEvents lblfornecedor As System.Windows.Forms.Label
    Friend WithEvents btnexcluirproduto As System.Windows.Forms.Button
    Friend WithEvents btnexcluirentrada As System.Windows.Forms.Button
    Friend WithEvents btnexcluirsaida As System.Windows.Forms.Button
    Friend WithEvents txttiposaida As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txttipoentrada As System.Windows.Forms.TextBox
    Friend WithEvents lbltipoentrada As System.Windows.Forms.Label
    Friend WithEvents txtcodentrada As System.Windows.Forms.TextBox
    Friend WithEvents txtcodsaida As System.Windows.Forms.TextBox
    Friend WithEvents txtcategoriasaida As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtcategoriaentrada As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtdataentrada As System.Windows.Forms.DateTimePicker
    Friend WithEvents txtdatasaida As System.Windows.Forms.DateTimePicker
End Class
