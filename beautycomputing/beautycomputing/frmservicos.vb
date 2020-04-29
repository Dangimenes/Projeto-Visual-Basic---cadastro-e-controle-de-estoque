Public Class frmservicos

    'Inicia formulario load
    Private Sub frmserviços_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'conecta com o banco de dados e abre a conexão
        Call conexaogeral()
        conexao.Open()
        'define um objeto command
        cmd = New OleDb.OleDbCommand("SELECT * FROM tblservicos ORDER BY Código_do_Serviço", conexao)
        'define um dataAdapter
        da = New OleDb.OleDbDataAdapter()
        da.SelectCommand = cmd
        'define e preenche um DataTable com os dados
        datatb = New DataTable()
        da.Fill(datatb)
        'vincula os dados aos controles do formulário
        txtcodigo.DataBindings.Add("Text", datatb, "Código_do_Serviço")
        txtservico.DataBindings.Add("Text", datatb, "Serviço")
        txttiposervico.DataBindings.Add("Text", datatb, "Tipo")
        txttemposervico.DataBindings.Add("Text", datatb, "Tempo_Estimado")
        txtvalor.DataBindings.Add("Text", datatb, "Valor")
        'estabelece o currencyManager
        CManager = DirectCast(Me.BindingContext(datatb), CurrencyManager)
        'define o estado de exibição dos dados: visualizar (Ver) e Editar
        Call definirEstado("Ver")
        Call preto()
        btnsalvar.Enabled = False
        btncancelar.Enabled = False
        datagridserviços.ReadOnly = True
        Call carregagrid()
    End Sub
    'Termina formulario load

    Private Sub carregagrid()
        Call conexaogeral()
        conexao.Open()
        da = New OleDb.OleDbDataAdapter("Select * from tblservicos;", conexao)
        DS = New DataSet
        da.Fill(DS, "tblservicos")
        datagridserviços.DataSource = DS.Tables(0)
        conexao.Close()
    End Sub

    Private Sub definirEstado(ByVal AppEstado As String)
        Estado = AppEstado

        Select Case AppEstado
            Case "Ver"
                btnnovo.Enabled = True
                btncancelar.Enabled = True
                btneditar.Enabled = True
                btnsalvar.Enabled = True
                btnexcluir.Enabled = True
                txtcodigo.ReadOnly = True
                txtservico.ReadOnly = True
                txttiposervico.ReadOnly = True
                txtvalor.ReadOnly = True
                txttemposervico.ReadOnly = True

            Case "Editar", "Incluir"
                btneditar.Enabled = False
                btnsalvar.Enabled = True
                btncancelar.Enabled = True
                btnnovo.Enabled = False
                btnexcluir.Enabled = False
                txtcodigo.ReadOnly = False
                txtservico.ReadOnly = False
                txttiposervico.ReadOnly = False
                txtvalor.ReadOnly = False
                txttemposervico.ReadOnly = False
        End Select
    End Sub
    
    Public Sub limpaCampos()
        txtcodigo.Clear()
        txtservico.Clear()
        txttiposervico.Clear()
        txtvalor.Clear()
        txttemposervico.Clear()
    End Sub

    Private Sub grifa()
        If (txtcodigo.Text = "") Then
            lblcodigo.ForeColor = Color.Red
        End If
        If (txtservico.Text = "") Then
            lblservico.ForeColor = Color.Red
        End If
        If (txttiposervico.Text = "") Then
            lbltipo.ForeColor = Color.Red
        End If
        If (txtvalor.Text = "") Then
            lblvalor.ForeColor = Color.Red
        End If
        If (txttemposervico.Text = "") Then
            lbltempo.ForeColor = Color.Red
        End If
    End Sub

    Private Sub preto()
        lblcodigo.ForeColor = Color.Black
        lblservico.ForeColor = Color.Black
        lbltipo.ForeColor = Color.Black
        lblvalor.ForeColor = Color.Black
        lbltempo.ForeColor = Color.Black
    End Sub
    'Inicia codigo dos Botões e termina dos private sub

    Private Sub btnnovo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnnovo.Click
        flag = 1
        Call limpaCampos()
        Call preto()
        Dim mMarcador As Integer
        'define a posicao atual do currencyManager
        mMarcador = CManager.Position
        'define o estado no modo inclusão
        Call definirEstado("Incluir")
        'inclui um novo registro no currenymanager
        CManager.AddNew()
    End Sub

    Private Sub btncancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btncancelar.Click
        flag = 0
        Dim mMarcador As Integer
        'define a posicao atual do currencyManager
        mMarcador = CManager.Position
        CManager.CancelCurrentEdit()
        If Estado = "Incluir" Then
            CManager.Position = mMarcador
        End If
        Call definirEstado("Ver")
        Call carregagrid()
    End Sub

    Private Sub btneditar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btneditar.Click
        flag = 0
        Call definirEstado("Editar")
        Call preto()
    End Sub

    Private Sub btnsalvar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnsalvar.Click
        Call conexaogeral()
        If flag = 1 Then
            conexao.Open()
            Try
                cmd.CommandText = "INSERT INTO tblservicos(Código_do_Serviço,Serviço,Tipo,Tempo_Estimado,Valor) VALUES(@codservico,@servico,@tiposervico,@temposervico,@valorservico)"
                cmd.Parameters.AddWithValue("@codservico", txtcodigo.Text)
                cmd.Parameters.AddWithValue("@servico", txtservico.Text)
                cmd.Parameters.AddWithValue("@tiposervico", txttiposervico.Text)
                cmd.Parameters.AddWithValue("@temposervico", txttemposervico.Text)
                cmd.Parameters.AddWithValue("@valorservico", txtvalor.Text)
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
                cmd = New OleDb.OleDbCommand("update tblservicos set Serviço='" & txtservico.Text & "' where Código_do_Serviço = '" & txtcodigo.Text & "';", conexao)
                ler = cmd.ExecuteReader(CommandBehavior.CloseConnection)
                conexao.Close()

                conexao.Open()
                cmd = New OleDb.OleDbCommand("update tblservicos set Tipo='" & txttiposervico.Text & "' where Código_do_Serviço = '" & txtcodigo.Text & "';", conexao)
                ler = cmd.ExecuteReader(CommandBehavior.CloseConnection)
                conexao.Close()

                conexao.Open()
                cmd = New OleDb.OleDbCommand("update tblservicos set Tempo_Estimado='" & txttemposervico.Text & "' where Código_do_Serviço = '" & txtcodigo.Text & "';", conexao)
                ler = cmd.ExecuteReader(CommandBehavior.CloseConnection)
                conexao.Close()

                conexao.Open()
                cmd = New OleDb.OleDbCommand("update tblservicos set Valor='" & txtvalor.Text & "' where Código_do_Serviço = '" & txtcodigo.Text & "';", conexao)
                ler = cmd.ExecuteReader(CommandBehavior.CloseConnection)
                conexao.Close()

                conexao = Nothing
                MsgBox("Dados atualizados com sucesso!", MsgBoxStyle.OkOnly, "Atualizar")
            Catch ex As Exception
                MessageBox.Show(ex.ToString, "Erro na Inclusão", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If
        flag = 0
        Call definirEstado("Ver")
        Call carregagrid()
    End Sub
    Private Sub btnexcluir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnexcluir.Click
        If MsgBox("deseja excluir", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
            Dim dr As OleDb.OleDbDataReader
            Call conexaogeral()
            I = 0
            conexao.Open()
            cmd = New OleDb.OleDbCommand("DELETE  from tblservicos where Serviço = '" & txtservico.Text & "';", conexao)
            dr = cmd.ExecuteReader(CommandBehavior.CloseConnection)
            MsgBox("'" & txtservico.Text & "'  servico Excluido ", MsgBoxStyle.Information, "Excluido")
            conexao.Close()

            Call conexaogeral()
            conexao.Open()
            da = New OleDb.OleDbDataAdapter("Select * from tblservicos ;", conexao)
            DS = New DataSet
            da.Fill(DS, "tblservicos")
            For I As Integer = 0 To DS.Tables(0).Rows.Count - 1
                txtcodigo.Text = DS.Tables(0).Rows(I)("Código_do_Serviço").ToString
                txtservico.Text = DS.Tables(0).Rows(I)("Serviço").ToString
                txttiposervico.Text = DS.Tables(0).Rows(I)("Tipo").ToString
                txttemposervico.Text = DS.Tables(0).Rows(I)("Tempo_Estimado").ToString
                txtvalor.Text = DS.Tables(0).Rows(I)("Valor").ToString
            Next
            conexao.Close()
            conexao = Nothing
            SalvarDados()
            Call definirEstado("Ver")
            flag = 0
        End If
        Call carregagrid()
    End Sub

    Private Sub btnPrimeiro_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPrimeiro.Click
        CManager.Position = 0
    End Sub

    Private Sub btnAnterior_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAnterior.Click
        CManager.Position -= 1
    End Sub

    Private Sub btnProximo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnProximo.Click
        CManager.Position += 1
    End Sub

    Private Sub btnUltimo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnUltimo.Click
        CManager.Position = CManager.Count - 1
    End Sub
End Class
