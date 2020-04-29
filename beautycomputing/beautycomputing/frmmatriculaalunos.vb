Public Class frmmatriculaalunos

    'Inicia formulario load
    Private Sub frmmatriculaalunos_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'Inicia conteudo web cam 
        'verifica e carrega os dispositivos
        Call carregaDispositivos()
        Call abreJanelaVisualizacao()
        If lstdispositivos.Items.Count > 0 Then
            lstdispositivos.SelectedIndex = 0
        Else
            lstdispositivos.Items.Add("Não há dispositivo de captura instalado.")
        End If
        piccaptura.SizeMode = PictureBoxSizeMode.StretchImage
        'Termina conteudo WEBCAM

        lstdispositivos.Visible = False

        'conecta com o banco de dados e abre a conexão
        Call conexaogeral()
        conexao.Open()
        'define um objeto command
        cmd = New OleDb.OleDbCommand("SELECT * FROM tblalunos ORDER BY RG_do_Aluno", conexao)
        'define um dataAdapter
        da = New OleDb.OleDbDataAdapter()
        da.SelectCommand = cmd
        'define e preenche um DataTable com os dados
        datatb = New DataTable()
        da.Fill(datatb)
        'vincula os dados aos controles do formulário
        txtrgaluno.DataBindings.Add("Text", datatb, "RG_do_Aluno")
        txtnomealuno.DataBindings.Add("Text", datatb, "Nome")
        txtcepaluno.DataBindings.Add("Text", datatb, "CEP")
        cboestadosalunos.DataBindings.Add("Text", datatb, "Estado")
        txtcidadealuno.DataBindings.Add("Text", datatb, "Cidade")
        txtbairroaluno.DataBindings.Add("Text", datatb, "Bairro")
        txtenderecoaluno.DataBindings.Add("Text", datatb, "Endereço")
        txtnumeroaluno.DataBindings.Add("Text", datatb, "Número")
        txtcomplealuno.DataBindings.Add("Text", datatb, "Complemento")
        txttelaluno.DataBindings.Add("Text", datatb, "Telefone")
        txtcelaluno.DataBindings.Add("Text", datatb, "Celular")
        cbosexoaluno.DataBindings.Add("Text", datatb, "Sexo")
        txtnascaluno.DataBindings.Add("Text", datatb, "Data_de_Nascimento")
        txtmaealuno.DataBindings.Add("Text", datatb, "Nome_da_Mãe")
        txtpaialuno.DataBindings.Add("Text", datatb, "Nome_do_Pai")
        txtmatriculaaluno.DataBindings.Add("Text", datatb, "Data_da_Matricula")
        txtfotohora.DataBindings.Add("Text", datatb, "Nome_da_Imagem")
        'estabelece o currencyManager
        CManager = DirectCast(Me.BindingContext(datatb), CurrencyManager)
        Call exibirdados()
        'define o estado de exibição dos dados: visualizar (Ver) e Editar
        Call definirEstado("Ver")
        Call preto()
        txtcidadealuno.ReadOnly = True
        'ComboBox inicia
        cboestadosalunos.Items.Add("AC")
        cboestadosalunos.Items.Add("AL")
        cboestadosalunos.Items.Add("AP")
        cboestadosalunos.Items.Add("AM")
        cboestadosalunos.Items.Add("BA")
        cboestadosalunos.Items.Add("CE")
        cboestadosalunos.Items.Add("DF")
        cboestadosalunos.Items.Add("GO")
        cboestadosalunos.Items.Add("ES")
        cboestadosalunos.Items.Add("MA")
        cboestadosalunos.Items.Add("MT")
        cboestadosalunos.Items.Add("MS")
        cboestadosalunos.Items.Add("MG")
        cboestadosalunos.Items.Add("PA")
        cboestadosalunos.Items.Add("PB")
        cboestadosalunos.Items.Add("PR")
        cboestadosalunos.Items.Add("PE")
        cboestadosalunos.Items.Add("PI")
        cboestadosalunos.Items.Add("RJ")
        cboestadosalunos.Items.Add("RN")
        cboestadosalunos.Items.Add("RS")
        cboestadosalunos.Items.Add("RO")
        cboestadosalunos.Items.Add("RR")
        cboestadosalunos.Items.Add("SP")
        cboestadosalunos.Items.Add("SC")
        cboestadosalunos.Items.Add("SE")
        cboestadosalunos.Items.Add("TO")

        cbosexoaluno.Items.Add("Masculino")
        cbosexoaluno.Items.Add("Feminino")
        'ComboBox Termina
        lstdispositivos.Visible = False
        Call fechaJanelaVisualizacao()
    End Sub
    'Termina formulario load

    Private Sub btntirarfoto_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btntirarfoto.Click
        Dim dados As IDataObject
        Dim foto As Image
        Dim ano As String = Now.Year
        Dim mes As String = Now.Month
        Dim dia As String = Now.Day
        Dim hora As String = Now.Hour
        Dim minuto As String = Now.Minute
        Dim segundo As String = Now.Second
        Dim milessimo As String = Now.Millisecond
        txtfotohora.Text = ano + mes + dia + hora + minuto + segundo + milessimo
        Dim idimagem As String = txtfotohora.Text
        ' Copia a imagem para o clipboard
        SendMessage(hHwnd, WM_CAP_EDIT_COPY, 0, 0)
        ' Obtem a imagem do clipboard e converte para bitmap
        dados = Clipboard.GetDataObject()
        dados.GetDataPresent(GetType(System.Drawing.Bitmap))
        foto = CType(dados.GetData(GetType(System.Drawing.Bitmap)), Image)
        foto.Save(LocalFotosaluno & "\" & idimagem, Imaging.ImageFormat.Jpeg)
        fotoaluno.Image = foto
        fotoaluno2.Image = foto
        'obtem a posição da / na string
        Dim posicaoBarra As Integer = idimagem.LastIndexOf("\")
        'extrai somente o nome do arquivo da string e atribui a lblFoto
        txtfotohora.Text = idimagem.Substring(posicaoBarra + 1)
        'chama a rotina para exibir a foto
        Call ExibirFoto()
    End Sub

    'privates sub da WEBCAM
    Private Sub carregaDispositivos()
        Dim strNome As String = Space(100)
        Dim strVer As String = Space(100)
        Dim bRetorna As Boolean
        Dim x As Integer = 0
        ' Carrega os dispositivos em lstDevices
        Do
            ' Obtem o nome e a versão Driver
            bRetorna = capGetDriverDescriptionA(x, strNome, 100, strVer, 100)
            ' se existir um dispositivo inclui o nome da lista
            If bRetorna Then lstdispositivos.Items.Add(strNome.Trim)
            x += 1
        Loop Until bRetorna = False
    End Sub

    Private Sub abreJanelaVisualizacao()
        Dim iHeight As Integer = piccaptura.Height
        Dim iWidth As Integer = piccaptura.Width
        ' Abre a janela de visualização no picturebox
        hHwnd = capCreateCaptureWindowA(iDevice, WS_VISIBLE Or WS_CHILD, 0, 0, 640, _
            480, piccaptura.Handle.ToInt32, 0)
        'Conecta com o drive
        If SendMessage(hHwnd, WM_CAP_DRIVER_CONNECT, iDevice, 0) Then
            'Define a escala de previsão
            SendMessage(hHwnd, WM_CAP_SET_SCALE, True, 0)
            'Define a taxa de visualização em milisegundos
            SendMessage(hHwnd, WM_CAP_SET_PREVIEWRATE, 66, 0)
            'Iniciar a visualização da imagem a partir da camara
            SendMessage(hHwnd, WM_CAP_SET_PREVIEW, True, 0)
            ' Redimensiona a janela para se ajustar no picturebox
            SetWindowPos(hHwnd, HWND_BOTTOM, 0, 0, piccaptura.Width, piccaptura.Height, _
                    SWP_NOMOVE Or SWP_NOZORDER)
        Else
            ' Erro de conexão fecha a janela de dispostivos
            DestroyWindow(hHwnd)
        End If
    End Sub

    Private Sub fechaJanelaVisualizacao()
        ' Desconecta do dispositivo
        SendMessage(hHwnd, WM_CAP_DRIVER_DISCONNECT, iDevice, 0)
        ' fecha a chama a janela
        DestroyWindow(hHwnd)
    End Sub
    'privates sub do cadastro e acima da WEBCAM

    'Exibe dados do BD 
    Private Sub exibirdados()
        Call ExibirFoto()
    End Sub
    'Exibe foto da pasta Imagens
    Private Sub ExibirFoto()
        If txtfotohora.Text <> "" Then
            Try
                fotoaluno2.Image = Image.FromFile(LocalFotosaluno & "\" & txtfotohora.Text)
            Catch ex As Exception
                fotoaluno2.Image = Nothing
                MessageBox.Show(ex.Message, "Erro ao carregar Foto.", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        Else
            fotoaluno2.Image = Nothing
        End If
    End Sub

    Private Sub definirEstado(ByVal AppEstado As String)
        Estado = AppEstado

        Select Case AppEstado
            Case "Ver"
                btnnovoaluno.Enabled = True
                btncancelaraluno.Enabled = True
                btneditaraluno.Enabled = True
                btnsalvaraluno.Enabled = True
                btnexcluiraluno.Enabled = True
                txtrgaluno.ReadOnly = True
                txtnomealuno.ReadOnly = True
                txtcepaluno.ReadOnly = True
                cboestadosalunos.Enabled = False
                txtcidadealuno.ReadOnly = True
                txtbairroaluno.ReadOnly = True
                txtenderecoaluno.ReadOnly = True
                txtnumeroaluno.ReadOnly = True
                txtcomplealuno.ReadOnly = True
                txttelaluno.ReadOnly = True
                txtcelaluno.ReadOnly = True
                cbosexoaluno.Enabled = False
                txtnascaluno.ReadOnly = True
                txtmaealuno.ReadOnly = True
                txtpaialuno.ReadOnly = True
                txtmatriculaaluno.ReadOnly = True

            Case "Editar", "Incluir"
                btneditaraluno.Enabled = False
                btnsalvaraluno.Enabled = True
                btncancelaraluno.Enabled = True
                btnnovoaluno.Enabled = False
                btnexcluiraluno.Enabled = False
                txtrgaluno.ReadOnly = False
                txtnomealuno.ReadOnly = False
                txtcepaluno.ReadOnly = False
                cboestadosalunos.Enabled = True
                txtcidadealuno.ReadOnly = False
                txtbairroaluno.ReadOnly = False
                txtenderecoaluno.ReadOnly = False
                txtnumeroaluno.ReadOnly = False
                txtcomplealuno.ReadOnly = False
                txttelaluno.ReadOnly = False
                txtcelaluno.ReadOnly = False
                cbosexoaluno.Enabled = True
                txtnascaluno.ReadOnly = False
                txtmaealuno.ReadOnly = False
                txtpaialuno.ReadOnly = False
                txtmatriculaaluno.ReadOnly = False
        End Select
        txtnomealuno.Focus()
    End Sub
  
    Public Sub limpaCampos()
        txtrgaluno.Clear()
        txtnomealuno.Clear()
        txtcepaluno.Clear()
        cboestadosalunos.ResetText()
        txtcidadealuno.Clear()
        txtbairroaluno.Clear()
        txtenderecoaluno.Clear()
        txtnumeroaluno.Clear()
        txtcomplealuno.Clear()
        txttelaluno.Clear()
        txtcelaluno.Clear()
        cbosexoaluno.ResetText()
        txtnascaluno.Clear()
        txtmaealuno.Clear()
        txtpaialuno.Clear()
        txtmatriculaaluno.Clear()
        fotoaluno.Image = fotoaluno.InitialImage
        fotoaluno2.Image = fotoaluno2.InitialImage
    End Sub

    Private Sub grifa()
        If (txtrgaluno.Text = "") Then
            lblrg.ForeColor = Color.Red
        End If
        If (txtnomealuno.Text = "") Then
            lblnome.ForeColor = Color.Red
        End If
        If (txtcepaluno.Text = "") Then
            lblcep.ForeColor = Color.Red
        End If
        If (cboestadosalunos.Focus) Then
            lblestado.ForeColor = Color.Red
        End If
        If (txtcidadealuno.Text = "") Then
            lblcidade.ForeColor = Color.Red
        End If
        If (txtbairroaluno.Text = "") Then
            lblbairro.ForeColor = Color.Red
        End If
        If (txtenderecoaluno.Text = "") Then
            lblendereco.ForeColor = Color.Red
        End If
        If (txtnumeroaluno.Text = "") Then
            lblnumero.ForeColor = Color.Red
        End If
        If (txttelaluno.Text = "") Then
            lbltelefone.ForeColor = Color.Red
        End If
        If (txtcelaluno.Text = "") Then
            lblcelular.ForeColor = Color.Red
        End If
        If (cbosexoaluno.Text = "") Then
            lblsexo.ForeColor = Color.Red
        End If
        If (txtnascaluno.Text = "") Then
            lblnascimento.ForeColor = Color.Red
        End If
        If (txtmaealuno.Text = "") Then
            lblnomemae.ForeColor = Color.Red
        End If
        If (txtpaialuno.Text = "") Then
            lblnomepai.ForeColor = Color.Red
        End If
        If (txtmatriculaaluno.Text = "") Then
            lblmatricula.ForeColor = Color.Red
        End If
    End Sub
    Private Sub preto()
        lblrg.ForeColor = Color.Black
        lblnome.ForeColor = Color.Black
        lblcep.ForeColor = Color.Black
        lblestado.ForeColor = Color.Black
        lblcidade.ForeColor = Color.Black
        lblbairro.ForeColor = Color.Black
        lblendereco.ForeColor = Color.Black
        lblnumero.ForeColor = Color.Black
        lbltelefone.ForeColor = Color.Black
        lblcelular.ForeColor = Color.Black
        lblsexo.ForeColor = Color.Black
        lblnascimento.ForeColor = Color.Black
        lblnomemae.ForeColor = Color.Black
        lblnomepai.ForeColor = Color.Black
        lblmatricula.ForeColor = Color.Black
    End Sub
    'Inicia codigo dos Botões e termina dos private sub

    Private Sub btnnovoaluno_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnnovoaluno.Click
        flag = 1
        Call limpaCampos()
        Call preto()
        Call abreJanelaVisualizacao()
        Dim mMarcador As Integer
        'define a posicao atual do currencyManager
        mMarcador = CManager.Position
        'define o estado no modo inclusão
        Call definirEstado("Incluir")
        'inclui um novo registro no currenymanager
        CManager.AddNew()
        fotoaluno2.Image = Nothing
        txtfotohora.Text = ""
    End Sub

    Private Sub btneditaraluno_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btneditaraluno.Click
        flag = 0
        Call definirEstado("Editar")
        Call preto()
        Call abreJanelaVisualizacao()
    End Sub

    Private Sub btnexcluiraluno_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnexcluiraluno.Click
        If MsgBox("deseja excluir", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
            Dim dr As OleDb.OleDbDataReader
            Call conexaogeral()
            I = 0
            conexao.Open()
            cmd = New OleDb.OleDbCommand("DELETE  from tblalunos where Nome = '" & txtnomealuno.Text & "';", conexao)
            dr = cmd.ExecuteReader(CommandBehavior.CloseConnection)
            MsgBox("'" & txtnomealuno.Text & "'  Aluno Excluido ", MsgBoxStyle.Information, "Excluido")
            conexao.Close()

            Call conexaogeral()
            conexao.Open()
            da = New OleDb.OleDbDataAdapter("Select * from tblalunos ;", conexao)
            DS = New DataSet
            da.Fill(DS, "tblalunos")
            For I As Integer = 0 To DS.Tables(0).Rows.Count - 1
                txtrgaluno.Text = DS.Tables(0).Rows(I)("RG_do_Aluno").ToString
                txtnomealuno.Text = DS.Tables(0).Rows(I)("Nome").ToString
                txtcepaluno.Text = DS.Tables(0).Rows(I)("CEP").ToString
                cboestadosalunos.Text = DS.Tables(0).Rows(I)("Estado").ToString
                txtcidadealuno.Text = DS.Tables(0).Rows(I)("Cidade").ToString
                txtbairroaluno.Text = DS.Tables(0).Rows(I)("Bairro").ToString
                txtenderecoaluno.Text = DS.Tables(0).Rows(I)("Endereço").ToString
                txtnumeroaluno.Text = DS.Tables(0).Rows(I)("Número").ToString
                txtcomplealuno.Text = DS.Tables(0).Rows(I)("Complemento").ToString
                txttelaluno.Text = DS.Tables(0).Rows(I)("Telefone").ToString
                txtcelaluno.Text = DS.Tables(0).Rows(I)("Celular").ToString
                cbosexoaluno.Text = DS.Tables(0).Rows(I)("Sexo").ToString
                txtnascaluno.Text = DS.Tables(0).Rows(I)("Data_de_Nascimento").ToString
                txtmaealuno.Text = DS.Tables(0).Rows(I)("Nome_da_Mãe").ToString
                txtpaialuno.Text = DS.Tables(0).Rows(I)("Nome_do_Pai").ToString
                txtmatriculaaluno.Text = DS.Tables(0).Rows(I)("Data_da_Matricula").ToString
                txtfotohora.Text = DS.Tables(0).Rows(I)("Nome_da_Imagem").ToString
            Next
            conexao.Close()
            conexao = Nothing
            SalvarDados()
            exibirdados()
            Call definirEstado("Ver")
            flag = 0
        End If
    End Sub

    Private Sub btnsalvaraluno_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnsalvaraluno.Click
        Call conexaogeral()
        If flag = 1 Then
            conexao.Open()
            Try
                cmd.CommandText = "INSERT INTO tblalunos(RG_do_Aluno,Nome,CEP,Estado,Cidade,Bairro,Endereço,Número,Complemento,Telefone,Celular,Sexo,Data_de_Nascimento,Nome_da_Mãe,Nome_do_Pai,Data_da_Matricula,Nome_da_Imagem) VALUES(@rgaluno,@nomealuno,@cepaluno,@estadoaluno,@cidadealuno,@bairroaluno,@endaluno,@numaluno,@complaluno,@telaluno,@celaluno,@sexoaluno,@nascimentoaluno,@nomemaealuno,@nomepaialuno,@matriculaaluno,@idimage)"
                cmd.Parameters.AddWithValue("@rgaluno", txtrgaluno.Text)
                cmd.Parameters.AddWithValue("@nomealuno", txtnomealuno.Text)
                cmd.Parameters.AddWithValue("@cepaluno", txtcepaluno.Text)
                cmd.Parameters.AddWithValue("@estadoaluno", cboestadosalunos.Text)
                cmd.Parameters.AddWithValue("@cidadealuno", txtcidadealuno.Text)
                cmd.Parameters.AddWithValue("@bairroaluno", txtbairroaluno.Text)
                cmd.Parameters.AddWithValue("@endaluno", txtenderecoaluno.Text)
                cmd.Parameters.AddWithValue("@numaluno", txtnumeroaluno.Text)
                cmd.Parameters.AddWithValue("@complaluno", txtcomplealuno.Text)
                cmd.Parameters.AddWithValue("@telaluno", txttelaluno.Text)
                cmd.Parameters.AddWithValue("@celaluno", txtcelaluno.Text)
                cmd.Parameters.AddWithValue("@sexoaluno", cbosexoaluno.Text)
                cmd.Parameters.AddWithValue("@nascimentoaluno", txtnascaluno.Text)
                cmd.Parameters.AddWithValue("@nomemaealuno", txtmaealuno.Text)
                cmd.Parameters.AddWithValue("@nomepaialuno", txtpaialuno.Text)
                cmd.Parameters.AddWithValue("@matriculaaluno", txtmatriculaaluno.Text)
                cmd.Parameters.AddWithValue("@idimage", txtfotohora.Text)
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
                cmd = New OleDb.OleDbCommand("update tblalunos set Nome='" & txtnomealuno.Text & "' where RG_do_Aluno = '" & txtrgaluno.Text & "';", conexao)
                ler = cmd.ExecuteReader(CommandBehavior.CloseConnection)
                conexao.Close()

                conexao.Open()
                cmd = New OleDb.OleDbCommand("update tblalunos set CEP='" & txtcepaluno.Text & "' where RG_do_Aluno = '" & txtrgaluno.Text & "';", conexao)
                ler = cmd.ExecuteReader(CommandBehavior.CloseConnection)
                conexao.Close()

                conexao.Open()
                cmd = New OleDb.OleDbCommand("update tblalunos set Estado='" & cboestadosalunos.Text & "' where RG_do_Aluno = '" & txtrgaluno.Text & "';", conexao)
                ler = cmd.ExecuteReader(CommandBehavior.CloseConnection)
                conexao.Close()

                conexao.Open()
                cmd = New OleDb.OleDbCommand("update tblalunos set Cidade='" & txtcidadealuno.Text & "' where RG_do_Aluno = '" & txtrgaluno.Text & "';", conexao)
                ler = cmd.ExecuteReader(CommandBehavior.CloseConnection)
                conexao.Close()

                conexao.Open()
                cmd = New OleDb.OleDbCommand("update tblalunos set Bairro='" & txtbairroaluno.Text & "' where RG_do_Aluno = '" & txtrgaluno.Text & "';", conexao)
                ler = cmd.ExecuteReader(CommandBehavior.CloseConnection)
                conexao.Close()

                conexao.Open()
                cmd = New OleDb.OleDbCommand("update tblalunos set Endereço='" & txtenderecoaluno.Text & "' where RG_do_Aluno = '" & txtrgaluno.Text & "';", conexao)
                ler = cmd.ExecuteReader(CommandBehavior.CloseConnection)
                conexao.Close()

                conexao.Open()
                cmd = New OleDb.OleDbCommand("update tblalunos set Número='" & txtnumeroaluno.Text & "' where RG_do_Aluno = '" & txtrgaluno.Text & "';", conexao)
                ler = cmd.ExecuteReader(CommandBehavior.CloseConnection)
                conexao.Close()

                conexao.Open()
                cmd = New OleDb.OleDbCommand("update tblalunos set Complemento='" & txtcomplealuno.Text & "' where RG_do_Aluno = '" & txtrgaluno.Text & "';", conexao)
                ler = cmd.ExecuteReader(CommandBehavior.CloseConnection)
                conexao.Close()

                conexao.Open()
                cmd = New OleDb.OleDbCommand("update tblalunos set Telefone='" & txttelaluno.Text & "' where RG_do_Aluno = '" & txtrgaluno.Text & "';", conexao)
                ler = cmd.ExecuteReader(CommandBehavior.CloseConnection)
                conexao.Close()

                conexao.Open()
                cmd = New OleDb.OleDbCommand("update tblalunos set Celular='" & txtcelaluno.Text & "' where RG_do_Aluno = '" & txtrgaluno.Text & "';", conexao)
                ler = cmd.ExecuteReader(CommandBehavior.CloseConnection)
                conexao.Close()

                conexao.Open()
                cmd = New OleDb.OleDbCommand("update tblalunos set Sexo='" & cbosexoaluno.Text & "' where RG_do_Aluno = '" & txtrgaluno.Text & "';", conexao)
                ler = cmd.ExecuteReader(CommandBehavior.CloseConnection)
                conexao.Close()

                conexao.Open()
                cmd = New OleDb.OleDbCommand("update tblalunos set Data_de_Nascimento='" & txtnascaluno.Text & "' where RG_do_Aluno = '" & txtrgaluno.Text & "';", conexao)
                ler = cmd.ExecuteReader(CommandBehavior.CloseConnection)
                conexao.Close()

                conexao.Open()
                cmd = New OleDb.OleDbCommand("update tblalunos set Nome_da_Mãe='" & txtmaealuno.Text & "' where RG_do_Aluno = '" & txtrgaluno.Text & "';", conexao)
                ler = cmd.ExecuteReader(CommandBehavior.CloseConnection)
                conexao.Close()

                conexao.Open()
                cmd = New OleDb.OleDbCommand("update tblalunos set Nome_do_Pai='" & txtpaialuno.Text & "' where RG_do_Aluno = '" & txtrgaluno.Text & "';", conexao)
                ler = cmd.ExecuteReader(CommandBehavior.CloseConnection)
                conexao.Close()

                conexao.Open()
                cmd = New OleDb.OleDbCommand("update tblalunos set Data_da_Matricula='" & txtmatriculaaluno.Text & "' where RG_do_Aluno = '" & txtrgaluno.Text & "';", conexao)
                ler = cmd.ExecuteReader(CommandBehavior.CloseConnection)
                conexao.Close()

                conexao.Open()
                cmd = New OleDb.OleDbCommand("update tblalunos set Nome_da_Imagem='" & txtfotohora.Text & "' where RG_do_Aluno = '" & txtrgaluno.Text & "';", conexao)
                ler = cmd.ExecuteReader(CommandBehavior.CloseConnection)
                conexao.Close()

                conexao = Nothing
                MsgBox("Dados atualizados com sucesso!", MsgBoxStyle.OkOnly, "Atualizar")
            Catch ex As Exception
                MessageBox.Show(ex.ToString, "Erro na Inclusão", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If
        flag = 0
        If txtenderecoaluno.Text.Trim = "" Then
            MessageBox.Show("Informe o endereço.", "Erro Entrada", MessageBoxButtons.OK, MessageBoxIcon.Information)
            txtenderecoaluno.Focus()
            Exit Sub
        End If
        Dim itemSalvo As String = txtenderecoaluno.Text
        Dim linhaSalva As Integer
        'encerra edição do CurrencyManager
        CManager.EndCurrentEdit()
        'define o modo de exibição ordenado por Nome
        datatb.DefaultView.Sort = "RG_do_Aluno"
        'obtem o id da linha Salva
        linhaSalva = datatb.DefaultView.Find(itemSalvo)
        'atribui a posição da linha em edição ao CurrencyManager
        CManager.Position = linhaSalva
        Call exibirdados()
        Call definirEstado("Ver")

        Call fechaJanelaVisualizacao()
        fotoaluno.Dispose()
    End Sub

    Private Sub btncancelaraluno_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btncancelaraluno.Click
        flag = 0
        Dim mMarcador As Integer
        'define a posicao atual do currencyManager
        mMarcador = CManager.Position
        CManager.CancelCurrentEdit()
        If Estado = "Incluir" Then
            CManager.Position = mMarcador
        End If
        Call exibirdados()
        Call definirEstado("Ver")
    End Sub

    Private Sub cboestadosalunos_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cboestadosalunos.TextChanged
        If cboestadosalunos.Text = "AC" Then
            txtcidadealuno.Text = "Acre"
        End If
        If cboestadosalunos.Text = "AL" Then
            txtcidadealuno.Text = "Alagoas"
        End If
        If cboestadosalunos.Text = "AP" Then
            txtcidadealuno.Text = "Amapá"
        End If
        If cboestadosalunos.Text = "AM" Then
            txtcidadealuno.Text = "Amazonas"
        End If
        If cboestadosalunos.Text = "SP" Then
            txtcidadealuno.Text = "São Paulo"
        End If
        If cboestadosalunos.Text = "BA" Then
            txtcidadealuno.Text = "Bahia"
        End If
        If cboestadosalunos.Text = "CE" Then
            txtcidadealuno.Text = "Ceará"
        End If
        If cboestadosalunos.Text = "DF" Then
            txtcidadealuno.Text = "Distrito Federal"
        End If
        If cboestadosalunos.Text = "GO" Then
            txtcidadealuno.Text = "Goiás"
        End If
        If cboestadosalunos.Text = "ES" Then
            txtcidadealuno.Text = "Espírito Santo"
        End If
        If cboestadosalunos.Text = "MA" Then
            txtcidadealuno.Text = "Maranhão"
        End If
        If cboestadosalunos.Text = "MT" Then
            txtcidadealuno.Text = "Mato Grosso"
        End If
        If cboestadosalunos.Text = "MS" Then
            txtcidadealuno.Text = "Mato Grosso do Sul"
        End If
        If cboestadosalunos.Text = "MG" Then
            txtcidadealuno.Text = "Minas Gerais"
        End If
        If cboestadosalunos.Text = "PA" Then
            txtcidadealuno.Text = "Pará"
        End If
        If cboestadosalunos.Text = "PB" Then
            txtcidadealuno.Text = "Paraiba"
        End If
        If cboestadosalunos.Text = "PR" Then
            txtcidadealuno.Text = "Paraná"
        End If
        If cboestadosalunos.Text = "PE" Then
            txtcidadealuno.Text = "Pernambuco"
        End If
        If cboestadosalunos.Text = "PI" Then
            txtcidadealuno.Text = "Piauí"
        End If
        If cboestadosalunos.Text = "RJ" Then
            txtcidadealuno.Text = "Rio de Janeiro"
        End If
        If cboestadosalunos.Text = "RN" Then
            txtcidadealuno.Text = "Rio Grande do Norte"
        End If
        If cboestadosalunos.Text = "RS" Then
            txtcidadealuno.Text = "Rio Grande do Sul"
        End If
        If cboestadosalunos.Text = "RO" Then
            txtcidadealuno.Text = "Rondônia"
        End If
        If cboestadosalunos.Text = "RR" Then
            txtcidadealuno.Text = "Rorâima"
        End If
        If cboestadosalunos.Text = "SP" Then
            txtcidadealuno.Text = "São Paulo"
        End If
        If cboestadosalunos.Text = "SC" Then
            txtcidadealuno.Text = "Santa Catarina"
        End If
        If cboestadosalunos.Text = "SE" Then
            txtcidadealuno.Text = "Sergipe"
        End If
        If cboestadosalunos.Text = "TO" Then
            txtcidadealuno.Text = "Tocantins"
        End If
    End Sub

    Private Sub btnprimeiroaluno_load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        btnprimeiroaluno.Image = My.Resources.primeiro
    End Sub

    Private Sub btnprimeiroaluno_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnprimeiroaluno.Click
        CManager.Position = 0
        Call exibirdados()
    End Sub

    Private Sub btnprimeiroaluno_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnprimeiroaluno.MouseLeave
        btnprimeiroaluno.Image = My.Resources.primeiroClaro
        btnprimeiroaluno.Image = My.Resources.primeiro
    End Sub

    Private Sub btnprimeiroaluno_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles btnprimeiroaluno.MouseMove
        btnprimeiroaluno.Image = My.Resources.primeiro
        btnprimeiroaluno.Image = My.Resources.primeiroClaro
    End Sub

    Private Sub btnalunoanterior_load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        btnalunoanterior.Image = My.Resources.anterior
    End Sub

    Private Sub btnalunoanterior_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnalunoanterior.Click
        CManager.Position -= 1
        Call exibirdados()
    End Sub

    Private Sub btnalunoanterior_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnalunoanterior.MouseLeave
        btnalunoanterior.Image = My.Resources.anteriorClaro
        btnalunoanterior.Image = My.Resources.anterior
    End Sub

    Private Sub btnalunoanterior_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles btnalunoanterior.MouseMove
        btnalunoanterior.Image = My.Resources.anterior
        btnalunoanterior.Image = My.Resources.anteriorClaro
    End Sub

    Private Sub btnproximoaluno_load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        btnproximoaluno.Image = My.Resources.proximo
    End Sub

    Private Sub btnproximoaluno_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnproximoaluno.Click
        CManager.Position += 1
        Call exibirdados()
    End Sub

    Private Sub btnproximoaluno_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnproximoaluno.MouseLeave
        btnproximoaluno.Image = My.Resources.proximoClaro
        btnproximoaluno.Image = My.Resources.proximo
    End Sub

    Private Sub btnproximoaluno_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles btnproximoaluno.MouseMove
        btnproximoaluno.Image = My.Resources.proximo
        btnproximoaluno.Image = My.Resources.proximoClaro
    End Sub

    Private Sub btnultimoaluno_load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        btnultimoaluno.Image = My.Resources.ultimo
    End Sub

    Private Sub btnultimoaluno_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnultimoaluno.Click
        CManager.Position = CManager.Count - 1
        Call exibirdados()
    End Sub

    Private Sub btnultimoaluno_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnultimoaluno.MouseLeave
        btnultimoaluno.Image = My.Resources.ultimoClaro
        btnultimoaluno.Image = My.Resources.ultimo
    End Sub

    Private Sub btnultimoaluno_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles btnultimoaluno.MouseMove
        btnultimoaluno.Image = My.Resources.ultimo
        btnultimoaluno.Image = My.Resources.ultimoClaro
    End Sub

    Private Sub btnrelatoriosdealunos_load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        btnrelatoriosdealunos.Image = My.Resources.relatorios
    End Sub

    Private Sub btnrelatoriosdealunos_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnrelatoriosdealunos.MouseLeave
        btnrelatoriosdealunos.Image = My.Resources.relatoriosClaro
        btnrelatoriosdealunos.Image = My.Resources.relatorios
    End Sub

    Private Sub btnrelatoriosdealunos_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles btnrelatoriosdealunos.MouseMove
        btnrelatoriosdealunos.Image = My.Resources.relatorios
        btnrelatoriosdealunos.Image = My.Resources.relatoriosClaro
    End Sub

    Private Sub btnlistadealunos_load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        btnlistadealunos.Image = My.Resources.lista
    End Sub

    Private Sub btnlistadealunos_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnlistadealunos.MouseLeave
        btnlistadealunos.Image = My.Resources.listaClaro
        btnlistadealunos.Image = My.Resources.lista
    End Sub

    Private Sub btnlistadealunos_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles btnlistadealunos.MouseMove
        btnlistadealunos.Image = My.Resources.lista
        btnlistadealunos.Image = My.Resources.listaClaro
    End Sub

    Private Sub btnvoltar_load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        btnvoltar.Image = My.Resources.menu
    End Sub

    Private Sub btnvoltar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnvoltar.Click
        Me.Close()
    End Sub

    Private Sub btnvoltar_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnvoltar.MouseLeave
        btnvoltar.Image = My.Resources.menuClaro
        btnvoltar.Image = My.Resources.menu
    End Sub

    Private Sub btnvoltar_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles btnvoltar.MouseMove
        btnvoltar.Image = My.Resources.menu
        btnvoltar.Image = My.Resources.menuClaro
    End Sub
End Class