Imports System.Data.OleDb

Public Class frmcontroleestoque

    'Inicia formulario load
    Private Sub frmcontroleestoque_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'Aba produtos
        Call carregaabaprodutos()
        'define o estado de exibição dos dados: visualizar (Ver) e Editar
        Call definirEstadoprodutos("Ver")
        Call pretoprodutos()
        btnsalvarproduto.Enabled = False
        btncancelarproduto.Enabled = False
        datagridprodutos.ReadOnly = True
        Call carregagridprodutos()

        'Aba Entrada
        Call carregaabaentrada()
        'define o estado de exibição dos dados: visualizar (Ver) e Editar
        Call definirEstadoentrada("Ver")
        Call pretoentrada()
        btnsalvarentrada.Enabled = False
        btncancelarentrada.Enabled = False
        datagridentrada.ReadOnly = True
        Call carregagridentrada()

        'Aba Saida
        Call carregaabasaida()
        'define o estado de exibição dos dados: visualizar (Ver) e Editar
        Call definirEstadosaida("Ver")
        Call pretosaida()
        btnsalvarsaida.Enabled = False
        btncancelarsaida.Enabled = False
        datagridsaida.ReadOnly = True
        Call carregagridsaida()
    End Sub

    Private Sub carregagridprodutos()
        Call conexaogeral()
        conexao.Open()
        da = New OleDb.OleDbDataAdapter("Select * from tblprodutos;", conexao)
        DS = New DataSet
        da.Fill(DS, "tblprodutos")
        datagridprodutos.DataSource = DS.Tables(0)
        conexao.Close()
    End Sub

    Private Sub carregagridentrada()
        Call conexaogeral()
        conexao.Open()
        da = New OleDb.OleDbDataAdapter("Select * from tblentrada;", conexao)
        DS = New DataSet
        da.Fill(DS, "tblentrada")
        datagridentrada.DataSource = DS.Tables(0)
        conexao.Close()
    End Sub

    Private Sub carregagridsaida()
        Call conexaogeral()
        conexao.Open()
        da = New OleDb.OleDbDataAdapter("Select * from tblsaida;", conexao)
        DS = New DataSet
        da.Fill(DS, "tblsaida")
        datagridsaida.DataSource = DS.Tables(0)
        conexao.Close()
    End Sub

    Private Sub carregaabaprodutos()
        'conecta com o banco de dados e abre a conexão
        Call conexaogeral()
        conexao.Open()
        'define um objeto command
        cmd = New OleDb.OleDbCommand("SELECT * FROM tblprodutos ORDER BY Código_do_Produto", conexao)
        'define um dataAdapter
        da = New OleDb.OleDbDataAdapter()
        da.SelectCommand = cmd
        'define e preenche um DataTable com os dados
        datatb = New DataTable()
        da.Fill(datatb)

        'vincula os dados aos controles do formulário
        txtcodproduto.DataBindings.Add("Text", datatb, "Código_do_Produto")
        txtnomeproduto.DataBindings.Add("Text", datatb, "Nome")
        txtvalorunitario.DataBindings.Add("Text", datatb, "Valor")
        txttipodeproduto.DataBindings.Add("Text", datatb, "Tipo")
        txtcategoria.DataBindings.Add("Text", datatb, "Categoria")
        txtfornecedor.DataBindings.Add("Text", datatb, "Fornecedor")
        'estabelece o currencyManager

        CManager = DirectCast(Me.BindingContext(datatb), CurrencyManager)
        conexao.Close()
    End Sub

    Private Sub carregaabaentrada()
        'conecta com o banco de dados e abre a conexão
        Call conexaogeral()
        conexao.Open()
        'define um objeto command
        cmd = New OleDb.OleDbCommand("SELECT * FROM tblentrada ORDER BY Código_de_Entrada", conexao)
        'define um dataAdapter
        da = New OleDb.OleDbDataAdapter()
        da.SelectCommand = cmd
        'define e preenche um DataTable com os dados
        datatb = New DataTable()
        da.Fill(datatb)
        'vincula os dados aos controles do formulário
        txtcodentrada.DataBindings.Add("Text", datatb, "Código_de_Entrada")
        txtdataentrada.DataBindings.Add("Text", datatb, "Data_da_Entrada")
        txtcodprodutoentrada.DataBindings.Add("Text", datatb, "Código_do_Produto")
        txtnomeprodutoentrada.DataBindings.Add("Text", datatb, "Nome_do_Produto")
        txttipoentrada.DataBindings.Add("Text", datatb, "Tipo_de_Produto")
        txtcategoriaentrada.DataBindings.Add("Text", datatb, "Categoria_do_Produto")
        txtvalorunitarioentrada.DataBindings.Add("Text", datatb, "Valor_Unitário_Produto")
        txtquantidadeentrada.DataBindings.Add("Text", datatb, "Quantidade_de_Entrada")
        txttotalvalorentradaprod.DataBindings.Add("Text", datatb, "Valor_Total_Entrada")
        'estabelece o currencyManager
        CManager = DirectCast(Me.BindingContext(datatb), CurrencyManager)
        conexao.Close()
    End Sub

    Private Sub carregaabasaida()
        'conecta com o banco de dados e abre a conexão
        Call conexaogeral()
        conexao.Open()
        'define um objeto command
        cmd = New OleDb.OleDbCommand("SELECT * FROM tblsaida ORDER BY Código_de_Saída", conexao)
        'define um dataAdapter
        da = New OleDb.OleDbDataAdapter()
        da.SelectCommand = cmd
        'define e preenche um DataTable com os dados
        datatb = New DataTable()
        da.Fill(datatb)
        'vincula os dados aos controles do formulário
        txtcodsaida.DataBindings.Add("Text", datatb, "Código_de_Saída")
        txtdatasaida.DataBindings.Add("Text", datatb, "Data_de_Saída")
        txtcodsaidaprod.DataBindings.Add("Text", datatb, "Código_do_Prod")
        txtnomeprodsaida.DataBindings.Add("Text", datatb, "Nome_do_Prod")
        txttiposaida.DataBindings.Add("Text", datatb, "Tipo_Prod")
        txtcategoriasaida.DataBindings.Add("Text", datatb, "Categoria_Prod")
        txtvaloruniprodsaida.DataBindings.Add("Text", datatb, "Valor_Unitário_Prod")
        txtquantprodsaida.DataBindings.Add("Text", datatb, "Quantidade_de_Saída")
        txttotalsaida.DataBindings.Add("Text", datatb, "Valor_Total_Saída")
        'estabelece o currencyManager
        CManager = DirectCast(Me.BindingContext(datatb), CurrencyManager)
        conexao.Close()
    End Sub

    Private Sub definirEstadoprodutos(ByVal AppEstado As String)
        Estado = AppEstado

        Select Case AppEstado
            Case "Ver"
                btnnovoproduto.Enabled = True
                btncancelarproduto.Enabled = False
                btneditarproduto.Enabled = True
                btnsalvarproduto.Enabled = False
                btnexcluirproduto.Enabled = True
                txtcodproduto.ReadOnly = True
                txtnomeproduto.ReadOnly = True
                txtvalorunitario.ReadOnly = True
                txttipodeproduto.ReadOnly = True
                txtcategoria.ReadOnly = True
                txtfornecedor.ReadOnly = True

            Case "Editar", "Incluir"
                btneditarproduto.Enabled = False
                btnsalvarproduto.Enabled = True
                btncancelarproduto.Enabled = True
                btnnovoproduto.Enabled = False
                btnexcluirproduto.Enabled = False
                txtcodproduto.ReadOnly = False
                txtnomeproduto.ReadOnly = False
                txtvalorunitario.ReadOnly = False
                txttipodeproduto.ReadOnly = False
                txtcategoria.ReadOnly = False
                txtfornecedor.ReadOnly = False
        End Select
    End Sub

    Private Sub definirEstadoentrada(ByVal AppEstado As String)
        Estado = AppEstado

        Select Case AppEstado
            Case "Ver"
                btnnovaentrada.Enabled = True
                btncancelarentrada.Enabled = False
                btnsalvarentrada.Enabled = False
                btnexcluirentrada.Enabled = True
                txtcodentrada.ReadOnly = True
                txtdataentrada.Enabled = False
                txtcodprodutoentrada.ReadOnly = True
                txtnomeprodutoentrada.ReadOnly = True
                txttipoentrada.ReadOnly = True
                txtcategoriaentrada.ReadOnly = True
                txtvalorunitarioentrada.ReadOnly = True
                txtquantidadeentrada.ReadOnly = True
                txttotalvalorentradaprod.ReadOnly = True

            Case "Editar", "Incluir"
                btnsalvarentrada.Enabled = True
                btncancelarentrada.Enabled = True
                btnnovaentrada.Enabled = False
                btnexcluirentrada.Enabled = False
                txtcodentrada.ReadOnly = False
                txtdataentrada.Enabled = True
                txtcodprodutoentrada.ReadOnly = False
                txtnomeprodutoentrada.ReadOnly = False
                txttipoentrada.ReadOnly = False
                txtcategoriaentrada.ReadOnly = False
                txtvalorunitarioentrada.ReadOnly = False
                txtquantidadeentrada.ReadOnly = False
                txttotalvalorentradaprod.ReadOnly = False
        End Select
    End Sub

    Private Sub definirEstadosaida(ByVal AppEstado As String)
        Estado = AppEstado

        Select Case AppEstado
            Case "Ver"
                btnnovosaida.Enabled = True
                btncancelarsaida.Enabled = False
                btnsalvarsaida.Enabled = False
                btnexcluirsaida.Enabled = True
                txtcodsaida.ReadOnly = True
                txtdatasaida.Enabled = False
                txtcodsaidaprod.ReadOnly = True
                txtnomeprodsaida.ReadOnly = True
                txttiposaida.ReadOnly = True
                txtcategoriasaida.ReadOnly = True
                txtvaloruniprodsaida.ReadOnly = True
                txtquantprodsaida.ReadOnly = True
                txttotalsaida.ReadOnly = True

            Case "Editar", "Incluir"
                btnsalvarsaida.Enabled = True
                btncancelarsaida.Enabled = True
                btnnovosaida.Enabled = False
                btnexcluirsaida.Enabled = False
                txtcodsaida.ReadOnly = False
                txtdatasaida.Enabled = True
                txtcodsaidaprod.ReadOnly = False
                txtnomeprodsaida.ReadOnly = False
                txttiposaida.ReadOnly = False
                txtcategoriasaida.ReadOnly = False
                txtvaloruniprodsaida.ReadOnly = False
                txtquantprodsaida.ReadOnly = False
                txttotalsaida.ReadOnly = False
        End Select
    End Sub

    Public Sub limpaCamposprodutos()
        txtcodproduto.Clear()
        txtnomeproduto.Clear()
        txtvalorunitario.Clear()
        txttipodeproduto.Clear()
        txtcategoria.Clear()
        txtfornecedor.Clear()
    End Sub

    Public Sub limpaCamposentrada()
        txtcodentrada.Clear()
        txtdataentrada.ResetText()
        txtcodprodutoentrada.Clear()
        txtnomeprodutoentrada.Clear()
        txttipoentrada.Clear()
        txtcategoriaentrada.Clear()
        txtvalorunitarioentrada.Clear()
        txtquantidadeentrada.Clear()
        txttotalvalorentradaprod.Clear()
    End Sub

    Public Sub limpaCampossaida()
        txtcodsaida.Clear()
        txtdatasaida.ResetText()
        txtcodsaidaprod.Clear()
        txtnomeprodsaida.Clear()
        txttiposaida.Clear()
        txtcategoriasaida.Clear()
        txtvaloruniprodsaida.Clear()
        txtquantprodsaida.Clear()
        txttotalsaida.Clear()
    End Sub

    Private Sub grifaprodutos()
        If (txtcodproduto.Text = "") Then
            lblcodigo.ForeColor = Color.Red
        End If
        If (txtnomeproduto.Text = "") Then
            lblnome.ForeColor = Color.Red
        End If
        If (txtvalorunitario.Text = "") Then
            lblvalor.ForeColor = Color.Red
        End If
        If (txttipodeproduto.Text = "") Then
            lbltipo.ForeColor = Color.Red
        End If
        If (txtcategoria.Text = "") Then
            lblcategoria.ForeColor = Color.Red
        End If
        If (txtfornecedor.Text = "") Then
            lblfornecedor.ForeColor = Color.Red
        End If
    End Sub

    Private Sub grifaentrada()
        If (txtdataentrada.Text = "") Then
            lbldataentrada.ForeColor = Color.Red
        End If
        If (txtcodprodutoentrada.Text = "") Then
            lblcodentrada.ForeColor = Color.Red
        End If
        If (txtnomeprodutoentrada.Text = "") Then
            lblnomeentrada.ForeColor = Color.Red
        End If
        If (txtquantidadeentrada.Text = "") Then
            lblquantidadeentrada.ForeColor = Color.Red
        End If
    End Sub

    Private Sub grifasaida()
        If (txtdatasaida.Text = "") Then
            lbldatasaida.ForeColor = Color.Red
        End If
        If (txtcodsaidaprod.Text = "") Then
            lblcodigosaida.ForeColor = Color.Red
        End If
        If (txtnomeprodsaida.Text = "") Then
            lblnomesaida.ForeColor = Color.Red
        End If
        If (txtquantprodsaida.Text = "") Then
            lblquantidadesaida.ForeColor = Color.Red
        End If
    End Sub

    Private Sub pretoprodutos()
        lblcodigo.ForeColor = Color.Black
        lblnome.ForeColor = Color.Black
        lblvalor.ForeColor = Color.Black
        lbltipo.ForeColor = Color.Black
        lblcategoria.ForeColor = Color.Black
        lblfornecedor.ForeColor = Color.Black
    End Sub

    Private Sub pretoentrada()
        lbldataentrada.ForeColor = Color.Black
        lblcodentrada.ForeColor = Color.Black
        lblnomeentrada.ForeColor = Color.Black
        lblquantidadeentrada.ForeColor = Color.Black
    End Sub

    Private Sub pretosaida()
        lbldatasaida.ForeColor = Color.Black
        lblcodigosaida.ForeColor = Color.Black
        lblnomesaida.ForeColor = Color.Black
        lblquantidadesaida.ForeColor = Color.Black
    End Sub

    Private Sub btnnovoproduto_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnnovoproduto.Click
        flag = 1
        Call limpaCamposprodutos()
        Call pretoprodutos()
        Dim mMarcador As Integer
        'define a posicao atual do currencyManager
        mMarcador = CManager.Position
        'define o estado no modo inclusão
        Call definirEstadoprodutos("Incluir")
        'inclui um novo registro no currenymanager
        CManager.AddNew()
    End Sub

    Private Sub btnnovaentrada_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnnovaentrada.Click
        flag = 1
        Call limpaCamposentrada()
        Call pretoentrada()
        Dim mMarcador As Integer
        'define a posicao atual do currencyManager
        mMarcador = CManager.Position
        'define o estado no modo inclusão
        Call definirEstadoentrada("Incluir")
        'inclui um novo registro no currenymanager
        CManager.AddNew()
    End Sub

    Private Sub btnnovosaida_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnnovosaida.Click
        flag = 1
        Call limpaCampossaida()
        Call pretosaida()
        Dim mMarcador As Integer
        'define a posicao atual do currencyManager
        mMarcador = CManager.Position
        'define o estado no modo inclusão
        Call definirEstadosaida("Incluir")
        'inclui um novo registro no currenymanager
        CManager.AddNew()
    End Sub

    Private Sub btncancelarproduto_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btncancelarproduto.Click
        flag = 0
        Dim mMarcador As Integer
        'define a posicao atual do currencyManager
        mMarcador = CManager.Position
        CManager.CancelCurrentEdit()
        If Estado = "Incluir" Then
            CManager.Position = mMarcador
        End If
        Call definirEstadoprodutos("Ver")
        Call carregagridprodutos()
    End Sub

    Private Sub btncancelarentrada_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btncancelarentrada.Click
        flag = 0
        Dim mMarcador As Integer
        'define a posicao atual do currencyManager
        mMarcador = CManager.Position
        CManager.CancelCurrentEdit()
        If Estado = "Incluir" Then
            CManager.Position = mMarcador
        End If
        Call definirEstadoentrada("Ver")
        Call carregagridentrada()
    End Sub

    Private Sub btncancelarsaida_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btncancelarsaida.Click
        flag = 0
        Dim mMarcador As Integer
        'define a posicao atual do currencyManager
        mMarcador = CManager.Position
        CManager.CancelCurrentEdit()
        If Estado = "Incluir" Then
            CManager.Position = mMarcador
        End If
        Call definirEstadosaida("Ver")
        Call carregagridsaida()
    End Sub

    Private Sub btneditarproduto_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btneditarproduto.Click
        flag = 0
        Call definirEstadoprodutos("Editar")
        Call pretoprodutos()
    End Sub

    Private Sub btnexcluirproduto_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnexcluirproduto.Click
        Call conexaogeral()
        If MsgBox("deseja excluir", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
            Dim dr As OleDb.OleDbDataReader
            I = 0
            conexao.Open()
            cmd = New OleDb.OleDbCommand("DELETE  from tblprodutos where Nome = '" & txtnomeproduto.Text & "';", conexao)
            dr = cmd.ExecuteReader(CommandBehavior.CloseConnection)
            MsgBox("'" & txtnomeproduto.Text & "'  Produto Excluido ", MsgBoxStyle.Information, "Excluido")
            conexao.Close()

            conexao.Open()
            da = New OleDb.OleDbDataAdapter("Select * from tblprodutos ;", conexao)
            DS = New DataSet
            da.Fill(DS, "tblprodutos")
            For I As Integer = 0 To DS.Tables(0).Rows.Count - 1
                txtcodproduto.Text = DS.Tables(0).Rows(I)("Código_do_Produto").ToString
                txtnomeproduto.Text = DS.Tables(0).Rows(I)("Nome").ToString
                txtvalorunitario.Text = DS.Tables(0).Rows(I)("Valor").ToString
                txttipodeproduto.Text = DS.Tables(0).Rows(I)("Tipo").ToString
                txtcategoria.Text = DS.Tables(0).Rows(I)("Categoria").ToString
                txtfornecedor.Text = DS.Tables(0).Rows(I)("Fornecedor").ToString
            Next
            conexao.Close()
            conexao = Nothing
            SalvarDados()
            Call definirEstadoprodutos("Ver")
            flag = 0
        End If
        Call carregagridprodutos()
    End Sub

    Private Sub btnexcluirentrada_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnexcluirentrada.Click
        Call conexaogeral()
        If MsgBox("deseja excluir", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
            Dim dr As OleDb.OleDbDataReader

            I = 0
            conexao.Open()
            cmd = New OleDbCommand("DELETE  from tblentrada where Código_de_Entrada = '" & txtcodentrada.Text & "';", conexao)
            dr = cmd.ExecuteReader(CommandBehavior.CloseConnection)
            MsgBox("'" & txtcodentrada.Text & "'  Entrada Excluido ", MsgBoxStyle.Information, "Excluido")
            conexao.Close()

            conexao.Open()
            da = New OleDb.OleDbDataAdapter("Select * from tblentrada ;", conexao)
            DS = New DataSet
            da.Fill(DS, "tblentrada")
            For I As Integer = 0 To DS.Tables(0).Rows.Count - 1
                txtcodentrada.Text = DS.Tables(0).Rows(I)("Código_de_Entrada").ToString
                txtdataentrada.Text = DS.Tables(0).Rows(I)("Data_da_Entrada").ToString
                txtcodprodutoentrada.Text = DS.Tables(0).Rows(I)("Código_do_Produto").ToString
                txtnomeprodutoentrada.Text = DS.Tables(0).Rows(I)("Nome_do_Produto").ToString
                txttipoentrada.Text = DS.Tables(0).Rows(I)("Tipo_de_Produto").ToString
                txtcategoriaentrada.Text = DS.Tables(0).Rows(I)("Categoria_do_Produto").ToString
                txtvalorunitarioentrada.Text = DS.Tables(0).Rows(I)("Valor_Unitário_Produto").ToString
                txtquantidadeentrada.Text = DS.Tables(0).Rows(I)("Quantidade_de_Entrada").ToString
                txttotalvalorentradaprod.Text = DS.Tables(0).Rows(I)("Valor_Total_Entrada").ToString
            Next
            conexao.Close()
            conexao = Nothing
            SalvarDados()
            Call definirEstadoentrada("Ver")
        End If
        Call carregagridentrada()
    End Sub

    Private Sub btnexcluirsaida_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnexcluirsaida.Click
        Call conexaogeral()
        If MsgBox("deseja excluir", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
            Dim dr As OleDb.OleDbDataReader
            I = 0
            conexao.Open()
            cmd = New OleDb.OleDbCommand("DELETE  from tblsaida where Código_de_Saída = '" & txtcodsaida.Text & "';", conexao)
            dr = cmd.ExecuteReader(CommandBehavior.CloseConnection)
            MsgBox("'" & txtdatasaida.Text & "'  Saida Excluido ", MsgBoxStyle.Information, "Excluido")
            conexao.Close()

            conexao.Open()
            da = New OleDb.OleDbDataAdapter("Select * from tblsaida ;", conexao)
            DS = New DataSet
            da.Fill(DS, "tblsaida")
            For I As Integer = 0 To DS.Tables(0).Rows.Count - 1
                txtcodsaida.Text = DS.Tables(0).Rows(I)("Código_de_Saída").ToString
                txtdatasaida.Text = DS.Tables(0).Rows(I)("Data_de_Saída").ToString
                txtcodsaidaprod.Text = DS.Tables(0).Rows(I)("Código_do_Prod").ToString
                txtnomeprodsaida.Text = DS.Tables(0).Rows(I)("Nome_do_Prod").ToString
                txttiposaida.Text = DS.Tables(0).Rows(I)("Tipo_Prod").ToString
                txtcategoriasaida.Text = DS.Tables(0).Rows(I)("Categoria_Prod").ToString
                txtvaloruniprodsaida.Text = DS.Tables(0).Rows(I)("Valor_Unitário_Prod").ToString
                txtquantprodsaida.Text = DS.Tables(0).Rows(I)("Quantidade_de_Saída").ToString
                txttotalsaida.Text = DS.Tables(0).Rows(I)("Valor_Total_Saída").ToString
            Next
            conexao.Close()
            conexao = Nothing
            SalvarDados()
            Call definirEstadosaida("Ver")
            flag = 0
        End If
        Call carregagridsaida()
    End Sub

    Private Sub btnsalvarproduto_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnsalvarproduto.Click
        Call conexaogeral()
        If flag = 1 Then
            conexao.Open()
            Try
                cmd.CommandText = "INSERT INTO tblprodutos(Código_do_Produto,Nome,Valor,Tipo,Categoria,Fornecedor) VALUES(@codproduto,@nomeprod,@valorunitprod,@tipoprod,@categoriaprod,@fornecedoresprod)"
                cmd.Parameters.AddWithValue("@codproduto", txtcodproduto.Text)
                cmd.Parameters.AddWithValue("@nomeprod", txtnomeproduto.Text)
                cmd.Parameters.AddWithValue("@valorunitprod", txtvalorunitario.Text)
                cmd.Parameters.AddWithValue("@tipoprod", txttipodeproduto.Text)
                cmd.Parameters.AddWithValue("@categoriaprod", txtcategoria.Text)
                cmd.Parameters.AddWithValue("@fornecedoresprod", txtfornecedor.Text)
                SalvarDados()
                conexao.Close()
            Catch ex As Exception
                MessageBox.Show(ex.ToString, "Erro na Inclusão", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        Else
            Try
                Call conexaogeral()
                Dim cmd As New OleDb.OleDbCommand
                Dim ler As OleDb.OleDbDataReader
                conexao.Open()
                cmd = New OleDb.OleDbCommand("update tblprodutos set Nome='" & txtnomeproduto.Text & "' where Código_do_Produto = '" & txtcodproduto.Text & "';", conexao)
                ler = cmd.ExecuteReader(CommandBehavior.CloseConnection)
                conexao.Close()

                conexao.Open()
                cmd = New OleDb.OleDbCommand("update tblprodutos set Valor ='" & txtvalorunitario.Text & "' where Código_do_Produto = '" & txtcodproduto.Text & "';", conexao)
                ler = cmd.ExecuteReader(CommandBehavior.CloseConnection)
                conexao.Close()

                conexao.Open()
                cmd = New OleDb.OleDbCommand("update tblprodutos set Tipo='" & txttipodeproduto.Text & "' where Código_do_Produto = '" & txtcodproduto.Text & "';", conexao)
                ler = cmd.ExecuteReader(CommandBehavior.CloseConnection)
                conexao.Close()

                conexao.Open()
                cmd = New OleDb.OleDbCommand("update tblprodutos set Categoria='" & txtcategoria.Text & "' where Código_do_Produto = '" & txtcodproduto.Text & "';", conexao)
                ler = cmd.ExecuteReader(CommandBehavior.CloseConnection)
                conexao.Close()

                conexao.Open()
                cmd = New OleDb.OleDbCommand("update tblprodutos set Fornecedor='" & txtfornecedor.Text & "' where Código_do_Produto = '" & txtcodproduto.Text & "';", conexao)
                ler = cmd.ExecuteReader(CommandBehavior.CloseConnection)
                conexao.Close()

                conexao = Nothing
                MsgBox("Dados atualizados com sucesso!", MsgBoxStyle.OkOnly, "Atualizar")
            Catch ex As Exception
                MessageBox.Show(ex.ToString, "Erro na Inclusão", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If
        flag = 0
        Call definirEstadoprodutos("Ver")
        Call carregagridprodutos()
    End Sub

    Private Sub btnsalvarentrada_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnsalvarentrada.Click
        Call conexaogeral()
        If flag = 1 Then
            conexao.Open()
            Try
                cmd.CommandText = "INSERT INTO tblentrada(Data_da_Entrada,Código_do_Produto,Nome_do_Produto,Tipo_de_Produto,Categoria_do_Produto,Valor_Unitário_Produto,Quantidade_de_Entrada,Valor_Total_Entrada) VALUES(@dataentr,@codprodutoentr,@nomeprodentr,@tipoprodentr,@categoriaprodentr,@valorunitprodentr,@quantidadeentr,@valortotalentr)"
                cmd.Parameters.AddWithValue("@dataentr", txtdataentrada.Text)
                cmd.Parameters.AddWithValue("@codprodutoentr", txtcodprodutoentrada.Text)
                cmd.Parameters.AddWithValue("@nomeprodentr", txtnomeprodutoentrada.Text)
                cmd.Parameters.AddWithValue("@tipoprodentr", txttipoentrada.Text)
                cmd.Parameters.AddWithValue("@categoriaprodentr", txtcategoriaentrada.Text)
                cmd.Parameters.AddWithValue("@valorunitprodentr", txtvalorunitarioentrada.Text)
                cmd.Parameters.AddWithValue("@quantidadeentr", txtquantidadeentrada.Text)
                cmd.Parameters.AddWithValue("@valortotalentr", txttotalvalorentradaprod.Text)
                SalvarDados()
                conexao.Close()
            Catch ex As Exception
                MessageBox.Show(ex.ToString, "Erro na Inclusão", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If
        flag = 0
        Call definirEstadoentrada("Ver")
        Call carregagridentrada()
    End Sub

    Private Sub btnsalvarsaida_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnsalvarsaida.Click
        Call conexaogeral()
        If flag = 1 Then
            conexao.Open()
            Try
                cmd.CommandText = "INSERT INTO tblsaida(Data_de_Saída,Código_do_Prod,Nome_do_Prod,Tipo_Prod,Categoria_Prod,Valor_Unitário_Prod,Quantidade_de_Saída,Valor_Total_Saída) VALUES(@datasaida,@codprodutosaida,@nomeprodsaida,@tipoprodsaida,@categoriaprodsaida,@valorunitsaida,@quantidadesaida,@valortotalsaida)"
                cmd.Parameters.AddWithValue("@datasaida", txtdatasaida.Text)
                cmd.Parameters.AddWithValue("@codprodutosaida", txtcodsaidaprod.Text)
                cmd.Parameters.AddWithValue("@nomeprodsaida", txtnomeprodsaida.Text)
                cmd.Parameters.AddWithValue("@tipoprodsaida", txttiposaida.Text)
                cmd.Parameters.AddWithValue("@categoriaprodsaida", txtcategoriasaida.Text)
                cmd.Parameters.AddWithValue("@valorunitsaida", txtvaloruniprodsaida.Text)
                cmd.Parameters.AddWithValue("@quantidadesaida", txtquantprodsaida.Text)
                cmd.Parameters.AddWithValue("@valortotalsaida", txttotalsaida.Text)
                SalvarDados()
                conexao.Close()
            Catch ex As Exception
                MessageBox.Show(ex.ToString, "Erro na Inclusão", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If
        flag = 0
        Call definirEstadosaida("Ver")
        Call carregagridsaida()
    End Sub

    Private Sub abaproduto_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles abaproduto.Click
        Call carregagridprodutos()
        datagridprodutos.Refresh()
    End Sub

    Private Sub abaentrada_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles abaentrada.Click
        Call carregagridentrada()
        datagridentrada.Refresh()
    End Sub

    Private Sub abasaida_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles abasaida.Click
        Call carregagridsaida()
        datagridsaida.Refresh()
    End Sub

    Private Sub calculoentrada()
        Dim valor1 As Double
        Dim valor2 As Double
        Dim resultado As Double
        Dim resultstring As String

        valor1 = Val(txtvalorunitarioentrada.Text)
        valor2 = Val(txtquantidadeentrada.Text)
        resultado = valor1 * valor2
        resultstring = resultado.ToString
        txttotalvalorentradaprod.Text = resultstring
    End Sub

    Private Sub calculosaida()
        Dim valor1 As Double
        Dim valor2 As Double
        Dim resultado As Double
        Dim resultstring As String

        valor1 = Val(txtvaloruniprodsaida.Text)
        valor2 = Val(txtquantprodsaida.Text)
        resultado = valor1 * valor2
        resultstring = resultado.ToString
        txttotalsaida.Text = resultstring
    End Sub

    Private Sub txtvalorunitarioentrada_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtvalorunitarioentrada.TextChanged
        Call calculoentrada()
    End Sub

    Private Sub txtquantidadeentrada_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtquantidadeentrada.TextChanged
        Call calculoentrada()
    End Sub

    Private Sub txttotalvalorentradaprod_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txttotalvalorentradaprod.TextChanged
        Call calculoentrada()
    End Sub

    Private Sub txtvaloruniprodsaida_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtvaloruniprodsaida.TextChanged
        Call calculosaida()
    End Sub

    Private Sub txtquantprodsaida_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtquantprodsaida.TextChanged
        Call calculosaida()
    End Sub

    Private Sub txttotalsaida_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txttotalsaida.TextChanged
        Call calculosaida()
    End Sub

    Private Sub txtcodprodutoentrada_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtcodprodutoentrada.TextChanged
        Call conexaogeral()
        conexao.Open()
        da = New OleDb.OleDbDataAdapter("select * from tblprodutos where Código_do_Produto like '" & txtcodprodutoentrada.Text & "';", conexao)
        DS = New DataSet
        da.Fill(DS, "tblprodutos")
        datagridentrada.DataSource = DS.Tables(0)
        For I As Integer = 0 To DS.Tables(0).Rows.Count - 1
            txtnomeprodutoentrada.Text = DS.Tables(0).Rows(I)("Nome").ToString
            txtvalorunitarioentrada.Text = DS.Tables(0).Rows(I)("Valor").ToString
            txttipoentrada.Text = DS.Tables(0).Rows(I)("Tipo").ToString
            txtcategoriaentrada.Text = DS.Tables(0).Rows(I)("Categoria").ToString
        Next
        conexao.Close()
        conexao = Nothing
        If txttipoentrada.Text <> "" Then
            Call carregagridentrada()
        End If
    End Sub

    Private Sub txtcodsaidaprod_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtcodsaidaprod.TextChanged
        Call conexaogeral()
        conexao.Open()
        da = New OleDb.OleDbDataAdapter("select * from tblprodutos where Código_do_Produto like '" & txtcodsaidaprod.Text & "';", conexao)
        DS = New DataSet
        da.Fill(DS, "tblprodutos")
        datagridsaida.DataSource = DS.Tables(0)
        For I As Integer = 0 To DS.Tables(0).Rows.Count - 1
            txtnomeprodsaida.Text = DS.Tables(0).Rows(I)("Nome").ToString
            txtvaloruniprodsaida.Text = DS.Tables(0).Rows(I)("Valor").ToString
            txttiposaida.Text = DS.Tables(0).Rows(I)("Tipo").ToString
            txtcategoriasaida.Text = DS.Tables(0).Rows(I)("Categoria").ToString
        Next
        conexao.Close()
        conexao = Nothing
        If txttiposaida.Text <> "" Then
            Call carregagridsaida()
        End If
    End Sub


End Class