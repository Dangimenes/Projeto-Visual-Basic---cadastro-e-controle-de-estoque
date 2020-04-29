Public Class frmclientes

    'Inicia formulario load
    Private Sub frmclientess_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
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
        cmd = New OleDb.OleDbCommand("SELECT * FROM tblclientes ORDER BY RG_do_Cliente", conexao)
        'define um dataAdapter
        da = New OleDb.OleDbDataAdapter()
        da.SelectCommand = cmd
        'define e preenche um DataTable com os dados
        datatb = New DataTable()
        da.Fill(datatb)

        'vincula os dados aos controles do formulário
        txtrgcli.DataBindings.Add("Text", datatb, "RG_do_Cliente")
        txtnomecli.DataBindings.Add("Text", datatb, "Nome")
        txtcepcli.DataBindings.Add("Text", datatb, "CEP")
        cboestadoscli.DataBindings.Add("Text", datatb, "Estado")
        txtcidadecli.DataBindings.Add("Text", datatb, "Cidade")
        txtbairrocli.DataBindings.Add("Text", datatb, "Bairro")
        txtendcli.DataBindings.Add("Text", datatb, "Endereço")
        txtnumerocli.DataBindings.Add("Text", datatb, "Número")
        txtcompcli.DataBindings.Add("Text", datatb, "Complemento")
        txttelcli.DataBindings.Add("Text", datatb, "Telefone")
        txtcelcli.DataBindings.Add("Text", datatb, "Celular")
        txtemailcli.DataBindings.Add("Text", datatb, "Email")
        cbosexocli.DataBindings.Add("Text", datatb, "Sexo")
        txtprofissaocli.DataBindings.Add("Text", datatb, "Profissão")
        cboalergias.DataBindings.Add("Text", datatb, "Possui_Alergias")
        txtalergiascli.DataBindings.Add("Text", datatb, "Quais_Alergias")
        cbotratamentomedicocli.DataBindings.Add("Text", datatb, "Está_em_Tratamento_Médico")
        cbomedicamentocli.DataBindings.Add("Text", datatb, "Esta_Usando_Algum_Medicamento")
        cbodoencacli.DataBindings.Add("Text", datatb, "Doenças")
        txtdoencacli.DataBindings.Add("Text", datatb, "Quais_Doenças")
        cbogravidacli.DataBindings.Add("Text", datatb, "Está_Gravida")
        cbometodoanticli.DataBindings.Add("Text", datatb, "Utiliza_Método_Anticoncepcional")
        cbotabagismocli.DataBindings.Add("Text", datatb, "Tabagismo")
        cboatividadefisicacli.DataBindings.Add("Text", datatb, "Atividade_Física")
        cbotratamentoesticocli.DataBindings.Add("Text", datatb, "Fez_Algum_Tratamento_Estético_Anterior")
        txtmotivoprocuracli.DataBindings.Add("Text", datatb, "Motivo_da_Procura")
        txtobservacoescli.DataBindings.Add("Text", datatb, "Observações")
        txtfotohora.DataBindings.Add("Text", datatb, "Nome_da_Imagem")
        'estabelece o currencyManager
        CManager = DirectCast(Me.BindingContext(datatb), CurrencyManager)

        Call exibirdados()
        'define o estado de exibição dos dados: visualizar (Ver) e Editar
        Call definirEstado("Ver")
        Call preto()
        'ComboBox inicia
        cboestadoscli.Items.Add("AC")
        cboestadoscli.Items.Add("AL")
        cboestadoscli.Items.Add("AP")
        cboestadoscli.Items.Add("AM")
        cboestadoscli.Items.Add("BA")
        cboestadoscli.Items.Add("CE")
        cboestadoscli.Items.Add("DF")
        cboestadoscli.Items.Add("GO")
        cboestadoscli.Items.Add("ES")
        cboestadoscli.Items.Add("MA")
        cboestadoscli.Items.Add("MT")
        cboestadoscli.Items.Add("MS")
        cboestadoscli.Items.Add("MG")
        cboestadoscli.Items.Add("PA")
        cboestadoscli.Items.Add("PB")
        cboestadoscli.Items.Add("PR")
        cboestadoscli.Items.Add("PE")
        cboestadoscli.Items.Add("PI")
        cboestadoscli.Items.Add("RJ")
        cboestadoscli.Items.Add("RN")
        cboestadoscli.Items.Add("RS")
        cboestadoscli.Items.Add("RO")
        cboestadoscli.Items.Add("RR")
        cboestadoscli.Items.Add("SP")
        cboestadoscli.Items.Add("SC")
        cboestadoscli.Items.Add("SE")
        cboestadoscli.Items.Add("TO")

        cbosexocli.Items.Add("Masculino")
        cbosexocli.Items.Add("Feminino")

        cboalergias.Items.Add("Sim")
        cboalergias.Items.Add("Não")

        cbotratamentomedicocli.Items.Add("Sim")
        cbotratamentomedicocli.Items.Add("Não")

        cbomedicamentocli.Items.Add("Sim")
        cbomedicamentocli.Items.Add("Não")

        cbodoencacli.Items.Add("Sim")
        cbodoencacli.Items.Add("Não")

        cbogravidacli.Items.Add("Sim")
        cbogravidacli.Items.Add("Não")

        cbotabagismocli.Items.Add("Sim")
        cbotabagismocli.Items.Add("Não")

        cboatividadefisicacli.Items.Add("Sim")
        cboatividadefisicacli.Items.Add("Não")

        cbometodoanticli.Items.Add("Sim")
        cbometodoanticli.Items.Add("Não")

        cbotratamentoesticocli.Items.Add("Sim")
        cbotratamentoesticocli.Items.Add("Não")
        'ComboBox Termina
        lstdispositivos.Visible = False
        Call fechaJanelaVisualizacao()
        lblgravida.Visible = False
        cbogravidacli.Visible = False
        lblmetodoanticonceptivo.Visible = False
        cbometodoanticli.Visible = False

        txtalergiascli.ReadOnly = True
        txtdoencacli.ReadOnly = True
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
        foto.Save(LocalFotosclientes & "\" & idimagem, Imaging.ImageFormat.Jpeg)
        fotocliente1.Image = foto
        fotocliente2.Image = foto
        txtfotohora.Refresh()
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
                fotocliente2.Image = Image.FromFile(LocalFotosclientes & "\" & txtfotohora.Text)
            Catch ex As Exception
                fotocliente2.Image = Nothing
                MessageBox.Show(ex.Message, "Erro ao carregar Foto.", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        Else
            fotocliente2.Image = Nothing
        End If
    End Sub

    Private Sub definirEstado(ByVal AppEstado As String)
        Estado = AppEstado

        Select Case AppEstado
            Case "Ver"
                'Aba Clientes
                txtrgcli.ReadOnly = True
                txtcidadecli.ReadOnly = True
                txtnomecli.ReadOnly = True
                cboestadoscli.Enabled = False
                txtbairrocli.ReadOnly = True
                txtendcli.ReadOnly = True
                txtnumerocli.ReadOnly = True
                txtcompcli.ReadOnly = True
                txtcepcli.ReadOnly = True
                txttelcli.ReadOnly = True
                txtcelcli.ReadOnly = True
                txtemailcli.ReadOnly = True
                cbosexocli.Enabled = False
                txtprofissaocli.ReadOnly = True
                'Aba Historico patologico pregressa
                cboalergias.Enabled = False
                cbotratamentomedicocli.Enabled = False
                cbomedicamentocli.Enabled = False
                cbodoencacli.Enabled = False
                cbogravidacli.Enabled = False
                cbometodoanticli.Enabled = False
                txtmotivoprocuracli.ReadOnly = True
                'Aba Historico social
                cbotabagismocli.Enabled = False
                cboatividadefisicacli.Enabled = False
                cbotratamentoesticocli.Enabled = False
                'aba observacao
                txtobservacoescli.ReadOnly = True

            Case "Editar", "Incluir"
                'Aba Clientes
                txtrgcli.ReadOnly = False
                txtcidadecli.ReadOnly = False
                txtnomecli.ReadOnly = False
                cboestadoscli.Enabled = True
                txtbairrocli.ReadOnly = False
                txtendcli.ReadOnly = False
                txtnumerocli.ReadOnly = False
                txtcompcli.ReadOnly = False
                txtcepcli.ReadOnly = False
                txttelcli.ReadOnly = False
                txtcelcli.ReadOnly = False
                txtemailcli.ReadOnly = False
                cbosexocli.Enabled = True
                txtprofissaocli.ReadOnly = False
                'Aba Historico patologico pregressa
                cboalergias.Enabled = True
                cbotratamentomedicocli.Enabled = True
                cbomedicamentocli.Enabled = True
                cbodoencacli.Enabled = True
                cbogravidacli.Enabled = True
                cbometodoanticli.Enabled = True
                txtmotivoprocuracli.ReadOnly = False
                'Aba Historico social
                cbotabagismocli.Enabled = True
                cboatividadefisicacli.Enabled = True
                cbotratamentoesticocli.Enabled = True
                'aba observacao
                txtobservacoescli.ReadOnly = False
        End Select
        txtnomecli.Focus()
    End Sub

    Public Sub limpaCampos()
        'Aba Clientes
        txtrgcli.Clear()
        txtcidadecli.Clear()
        txtnomecli.Clear()
        cboestadoscli.ResetText()
        cboestadoscli.Enabled = True
        txtbairrocli.Clear()
        txtendcli.Clear()
        txtnumerocli.Clear()
        txtcompcli.Clear()
        txtcepcli.Clear()
        txttelcli.Clear()
        txtcelcli.Clear()
        txtemailcli.Clear()
        cbosexocli.ResetText()
        cbosexocli.Enabled = False
        txtprofissaocli.Clear()
        'Aba Historico patologico pregressa
        cboalergias.ResetText()
        cboalergias.Enabled = True
        txtalergiascli.Clear()
        cbotratamentomedicocli.ResetText()
        cbomedicamentocli.Enabled = True
        cbodoencacli.ResetText()
        cbodoencacli.Enabled = True
        txtdoencacli.Clear()
        cbogravidacli.ResetText()
        cbogravidacli.Enabled = True
        txtmotivoprocuracli.Clear()
        cbometodoanticli.ResetText()
        cbometodoanticli.Enabled = True
        'Aba Historico social
        cbotabagismocli.ResetText()
        cbotabagismocli.Enabled = True
        cboatividadefisicacli.ResetText()
        cboatividadefisicacli.Enabled = True
        cbotratamentoesticocli.ResetText()
        cbotratamentoesticocli.Enabled = True
        'aba observacao
        txtobservacoescli.Clear()
        'Limpar campos das imagens
        fotocliente1.Image = fotocliente1.InitialImage
        fotocliente2.Image = fotocliente2.InitialImage
    End Sub

    Private Sub grifa()
        If (txtrgcli.Text = "") Then
            lblrg.ForeColor = Color.Red
        End If
        If (txtnomecli.Text = "") Then
            lblnomes.ForeColor = Color.Red
        End If
        If (txtcidadecli.Text = "") Then
            lblcidade.ForeColor = Color.Red
        End If
        If (cboestadoscli.Focus) Then
            lblestado.ForeColor = Color.Red
        End If
        If (txtbairrocli.Text = "") Then
            lblbairro.ForeColor = Color.Red
        End If
        If (txtendcli.Text = "") Then
            lblendereco.ForeColor = Color.Red
        End If
        If (txtnumerocli.Text = "") Then
            lblnumero.ForeColor = Color.Red
        End If
        If (txtcepcli.Text = "") Then
            lblcep.ForeColor = Color.Red
        End If
        If (txttelcli.Text = "") Then
            lbltelefone.ForeColor = Color.Red
        End If
    End Sub

    Private Sub preto()
        lblrg.ForeColor = Color.Black
        lblnomes.ForeColor = Color.Black
        lblcidade.ForeColor = Color.Black
        lblestado.ForeColor = Color.Black
        lblbairro.ForeColor = Color.Black
        lblendereco.ForeColor = Color.Black
        lblnumero.ForeColor = Color.Black
        lblcep.ForeColor = Color.Black
        lbltelefone.ForeColor = Color.Black
    End Sub

    Private Sub contagemsemerro()
        Dim bla As String
        bla = Len(txtobservacoescli.Text)
        lblchar.Text = bla
    End Sub

    Private Sub contagem()
        Dim bla As String
        bla = Len(txtobservacoescli.Text)
        lblchar.Text = bla
        If lblchar.Text = ("255") Then
            MsgBox("O Campo de Anotações não pode ultrapassar a marca de 255 caracteres.", MsgBoxStyle.Critical)
        End If
    End Sub

    Private Sub masculino()
        If cbogravidacli.Text = "" Then
            cbogravidacli.Text = "Não"
        End If
        If cbometodoanticli.Text = "" Then
            cbometodoanticli.Text = "Não"
        End If
        lblgravida.Visible = False
        cbogravidacli.Visible = False
        lblmetodoanticonceptivo.Visible = False
        cbometodoanticli.Visible = False
    End Sub

    'Inicia codigo dos Botões e termina dos private sub
    Private Sub btnnovocli_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnnovocli.Click
        btnnovocli.Enabled = False
        btneditarcli.Enabled = False
        btnexcluircli.Enabled = False
        btncancelarcli.Enabled = True
        btnsalvarcli.Enabled = True
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
        fotocliente2.Image = Nothing
        txtfotohora.Text = ""
    End Sub

    Private Sub btneditarcli_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btneditarcli.Click
        btnnovocli.Enabled = False
        btneditarcli.Enabled = False
        btnexcluircli.Enabled = False
        btncancelarcli.Enabled = True
        btnsalvarcli.Enabled = True
        flag = 0
        Call definirEstado("Editar")
        Call preto()
        Call abreJanelaVisualizacao()
    End Sub

    Private Sub btnexcluircli_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnexcluircli.Click
        If MsgBox("Deseja Realmente excluir", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
            Dim dr As OleDb.OleDbDataReader
            Call conexaogeral()
            I = 0
            conexao.Open()
            cmd = New OleDb.OleDbCommand("DELETE  from tblclientes where Nome = '" & txtnomecli.Text & "';", conexao)
            dr = cmd.ExecuteReader(CommandBehavior.CloseConnection)
            MsgBox("'" & txtnomecli.Text & "'  Cliente Excluido ", MsgBoxStyle.Information, "Excluido")
            conexao.Close()

            Call conexaogeral()
            conexao.Open()
            da = New OleDb.OleDbDataAdapter("Select * from tblclientes ;", conexao)
            DS = New DataSet
            da.Fill(DS, "tblclientes")
            For I As Integer = 0 To DS.Tables(0).Rows.Count - 1
                txtrgcli.Text = DS.Tables(0).Rows(I)("RG_do_Cliente").ToString
                txtnomecli.Text = DS.Tables(0).Rows(I)("Nome").ToString
                txtcepcli.Text = DS.Tables(0).Rows(I)("CEP").ToString
                cboestadoscli.Text = DS.Tables(0).Rows(I)("Estado").ToString
                txtcidadecli.Text = DS.Tables(0).Rows(I)("Cidade").ToString
                txtbairrocli.Text = DS.Tables(0).Rows(I)("Bairro").ToString
                txtendcli.Text = DS.Tables(0).Rows(I)("Endereço").ToString
                txtnumerocli.Text = DS.Tables(0).Rows(I)("Número").ToString
                txtcompcli.Text = DS.Tables(0).Rows(I)("Complemento").ToString
                txttelcli.Text = DS.Tables(0).Rows(I)("Telefone").ToString
                txtcelcli.Text = DS.Tables(0).Rows(I)("Celular").ToString
                txtemailcli.Text = DS.Tables(0).Rows(I)("Email").ToString
                cbosexocli.Text = DS.Tables(0).Rows(I)("Sexo").ToString
                txtprofissaocli.Text = DS.Tables(0).Rows(I)("Profissão").ToString
                cboalergias.Text = DS.Tables(0).Rows(I)("Possui_Alergias").ToString
                txtalergiascli.Text = DS.Tables(0).Rows(I)("Quais_Alergias").ToString
                cbotratamentomedicocli.Text = DS.Tables(0).Rows(I)("Está_em_Tratamento_Médico").ToString
                cbomedicamentocli.Text = DS.Tables(0).Rows(I)("Esta_Usando_Algum_Medicamento").ToString
                cbodoencacli.Text = DS.Tables(0).Rows(I)("Doenças").ToString
                txtdoencacli.Text = DS.Tables(0).Rows(I)("Quais_Doenças").ToString
                cbogravidacli.Text = DS.Tables(0).Rows(I)("Está_Gravida").ToString
                cbometodoanticli.Text = DS.Tables(0).Rows(I)("Utiliza_Método_Anticoncepcional").ToString
                cbotabagismocli.Text = DS.Tables(0).Rows(I)("Tabagismo").ToString
                cboatividadefisicacli.Text = DS.Tables(0).Rows(I)("Atividade_Física").ToString
                cbotratamentoesticocli.Text = DS.Tables(0).Rows(I)("Fez_Algum_Tratamento_Estético_Anterior").ToString
                txtmotivoprocuracli.Text = DS.Tables(0).Rows(I)("Motivo_da_Procura").ToString
                txtobservacoescli.Text = DS.Tables(0).Rows(I)("Observações").ToString
                txtfotohora.Text = DS.Tables(0).Rows(I)("Nome_da_Imagem").ToString
            Next
            conexao.Close()
            conexao = Nothing
            SalvarDados()
            exibirdados()
            Call definirEstado("Ver")
            flag = 0
        End If
        btncancelarcli.Enabled = False
        btnsalvarcli.Enabled = False
    End Sub

    Private Sub btnsalvarcli_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnsalvarcli.Click
        Call conexaogeral()
        If flag = 1 Then
            conexao.Open()
            Try
                cmd.CommandText = "INSERT INTO tblclientes(RG_do_Cliente,Nome,CEP,Estado,Cidade,Bairro,Endereço,Número,Complemento,Telefone,Celular,Email,Sexo,Profissão,Possui_Alergias,Quais_Alergias,Está_em_Tratamento_Médico,Esta_Usando_Algum_Medicamento,Doenças,Quais_Doenças,Está_Gravida,Utiliza_Método_Anticoncepcional,Tabagismo,Atividade_Física,Fez_Algum_Tratamento_Estético_Anterior,Motivo_da_Procura,Observações,Nome_da_Imagem) VALUES(@rgcliente,@nomecli,@cepcli,@estadocli,@cidadecli,@bairrocli,@endcli,@numcli,@complcli,@telcli,@celcli,@emailcli,@sexocli,@profissaocli,@alergiascli,@quaisalecli,@tratamentomedcli,@algummedcli,@doencascli,@quaisdoencascli,@gravidacli,@metodanticonptivocli,@tabagismocli,@atividadefisicacli,@tratesteticantcli,@motprocuracli,@observacaocli,@idimage)"
                cmd.Parameters.AddWithValue("@rgcliente", txtrgcli.Text)
                cmd.Parameters.AddWithValue("@nomecli", txtnomecli.Text)
                cmd.Parameters.AddWithValue("@cepcli", txtcepcli.Text)
                cmd.Parameters.AddWithValue("@estadocli", cboestadoscli.Text)
                cmd.Parameters.AddWithValue("@cidadecli", txtcidadecli.Text)
                cmd.Parameters.AddWithValue("@bairrocli", txtbairrocli.Text)
                cmd.Parameters.AddWithValue("@endcli", txtendcli.Text)
                cmd.Parameters.AddWithValue("@numcli", txtnumerocli.Text)
                cmd.Parameters.AddWithValue("@complcli", txtcompcli.Text)
                cmd.Parameters.AddWithValue("@telcli", txttelcli.Text)
                cmd.Parameters.AddWithValue("@celcli", txtcelcli.Text)
                cmd.Parameters.AddWithValue("@emailcli", txtemailcli.Text)
                cmd.Parameters.AddWithValue("@sexocli", cbosexocli.Text)
                cmd.Parameters.AddWithValue("@profissaocli", txtprofissaocli.Text)
                cmd.Parameters.AddWithValue("@alergiascli", cboalergias.Text)
                cmd.Parameters.AddWithValue("@quaisalecli", txtalergiascli.Text)
                cmd.Parameters.AddWithValue("@tratamentomedcli", cbotratamentoesticocli.Text)
                cmd.Parameters.AddWithValue("@algummedcli", cbomedicamentocli.Text)
                cmd.Parameters.AddWithValue("@doencascli", cbodoencacli.Text)
                cmd.Parameters.AddWithValue("@quaisdoencascli", txtdoencacli.Text)
                cmd.Parameters.AddWithValue("@gravidacli", cbogravidacli.Text)
                cmd.Parameters.AddWithValue("@metodanticonptivocli", cbometodoanticli.Text)
                cmd.Parameters.AddWithValue("@tabagismocli", cbotabagismocli.Text)
                cmd.Parameters.AddWithValue("@atividadefisicacli", cboatividadefisicacli.Text)
                cmd.Parameters.AddWithValue("@tratesteticantcli", cbotratamentoesticocli.Text)
                cmd.Parameters.AddWithValue("@motprocuracli", txtmotivoprocuracli.Text)
                cmd.Parameters.AddWithValue("@observacaocli", txtobservacoescli.Text)
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
                cmd = New OleDb.OleDbCommand("update tblclientes set Nome='" & txtnomecli.Text & "' where RG_do_Cliente = '" & txtrgcli.Text & "';", conexao)
                ler = cmd.ExecuteReader(CommandBehavior.CloseConnection)
                conexao.Close()

                conexao.Open()
                cmd = New OleDb.OleDbCommand("update tblclientes set CEP='" & txtcepcli.Text & "' where RG_do_Cliente = '" & txtrgcli.Text & "';", conexao)
                ler = cmd.ExecuteReader(CommandBehavior.CloseConnection)
                conexao.Close()

                conexao.Open()
                cmd = New OleDb.OleDbCommand("update tblclientes set Estado='" & cboestadoscli.Text & "' where RG_do_Cliente = '" & txtrgcli.Text & "';", conexao)
                ler = cmd.ExecuteReader(CommandBehavior.CloseConnection)
                conexao.Close()

                conexao.Open()
                cmd = New OleDb.OleDbCommand("update tblclientes set Cidade='" & txtcidadecli.Text & "' where RG_do_Cliente = '" & txtrgcli.Text & "';", conexao)
                ler = cmd.ExecuteReader(CommandBehavior.CloseConnection)
                conexao.Close()

                conexao.Open()
                cmd = New OleDb.OleDbCommand("update tblclientes set Bairro='" & txtbairrocli.Text & "' where RG_do_Cliente = '" & txtrgcli.Text & "';", conexao)
                ler = cmd.ExecuteReader(CommandBehavior.CloseConnection)
                conexao.Close()

                conexao.Open()
                cmd = New OleDb.OleDbCommand("update tblclientes set Endereço='" & txtendcli.Text & "' where RG_do_Cliente = '" & txtrgcli.Text & "';", conexao)
                ler = cmd.ExecuteReader(CommandBehavior.CloseConnection)
                conexao.Close()

                conexao.Open()
                cmd = New OleDb.OleDbCommand("update tblclientes set Número='" & txtnumerocli.Text & "' where RG_do_Cliente = '" & txtalergiascli.Text & "';", conexao)
                ler = cmd.ExecuteReader(CommandBehavior.CloseConnection)
                conexao.Close()

                conexao.Open()
                cmd = New OleDb.OleDbCommand("update tblclientes set Complemento='" & txtcompcli.Text & "' where RG_do_Cliente = '" & txtrgcli.Text & "';", conexao)
                ler = cmd.ExecuteReader(CommandBehavior.CloseConnection)
                conexao.Close()

                conexao.Open()
                cmd = New OleDb.OleDbCommand("update tblclientes set Telefone='" & txttelcli.Text & "' where RG_do_Cliente = '" & txtrgcli.Text & "';", conexao)
                ler = cmd.ExecuteReader(CommandBehavior.CloseConnection)
                conexao.Close()

                conexao.Open()
                cmd = New OleDb.OleDbCommand("update tblclientes set Celular='" & txtcelcli.Text & "' where RG_do_Cliente = '" & txtrgcli.Text & "';", conexao)
                ler = cmd.ExecuteReader(CommandBehavior.CloseConnection)
                conexao.Close()

                conexao.Open()
                cmd = New OleDb.OleDbCommand("update tblclientes set Email='" & txtemailcli.Text & "' where RG_do_Cliente = '" & txtrgcli.Text & "';", conexao)
                ler = cmd.ExecuteReader(CommandBehavior.CloseConnection)
                conexao.Close()

                conexao.Open()
                cmd = New OleDb.OleDbCommand("update tblclientes set Sexo='" & cbosexocli.Text & "' where RG_do_Cliente = '" & txtrgcli.Text & "';", conexao)
                ler = cmd.ExecuteReader(CommandBehavior.CloseConnection)
                conexao.Close()

                conexao.Open()
                cmd = New OleDb.OleDbCommand("update tblclientes set Profissão='" & txtprofissaocli.Text & "' where RG_do_Cliente = '" & txtrgcli.Text & "';", conexao)
                ler = cmd.ExecuteReader(CommandBehavior.CloseConnection)
                conexao.Close()

                conexao.Open()
                cmd = New OleDb.OleDbCommand("update tblclientes set Possui_Alergias='" & cboalergias.Text & "' where RG_do_Cliente = '" & txtrgcli.Text & "';", conexao)
                ler = cmd.ExecuteReader(CommandBehavior.CloseConnection)
                conexao.Close()

                conexao.Open()
                cmd = New OleDb.OleDbCommand("update tblclientes set Quais_Alergias='" & txtalergiascli.Text & "' where RG_do_Cliente = '" & txtrgcli.Text & "';", conexao)
                ler = cmd.ExecuteReader(CommandBehavior.CloseConnection)
                conexao.Close()

                conexao.Open()
                cmd = New OleDb.OleDbCommand("update tblclientes set Está_em_Tratamento_Médico='" & cbotratamentomedicocli.Text & "' where RG_do_Cliente = '" & txtrgcli.Text & "';", conexao)
                ler = cmd.ExecuteReader(CommandBehavior.CloseConnection)
                conexao.Close()

                conexao.Open()
                cmd = New OleDb.OleDbCommand("update tblclientes set Esta_Usando_Algum_Medicamento='" & cbomedicamentocli.Text & "' where RG_do_Cliente = '" & txtrgcli.Text & "';", conexao)
                ler = cmd.ExecuteReader(CommandBehavior.CloseConnection)
                conexao.Close()

                conexao.Open()
                cmd = New OleDb.OleDbCommand("update tblclientes set Doenças='" & txtdoencacli.Text & "' where RG_do_Cliente = '" & txtalergiascli.Text & "';", conexao)
                ler = cmd.ExecuteReader(CommandBehavior.CloseConnection)
                conexao.Close()

                conexao.Open()
                cmd = New OleDb.OleDbCommand("update tblclientes set Quais_Doenças='" & txtdoencacli.Text & "' where RG_do_Cliente = '" & txtrgcli.Text & "';", conexao)
                ler = cmd.ExecuteReader(CommandBehavior.CloseConnection)
                conexao.Close()

                conexao.Open()
                cmd = New OleDb.OleDbCommand("update tblclientes set Está_Gravida='" & cbogravidacli.Text & "' where RG_do_Cliente = '" & txtrgcli.Text & "';", conexao)
                ler = cmd.ExecuteReader(CommandBehavior.CloseConnection)
                conexao.Close()

                conexao.Open()
                cmd = New OleDb.OleDbCommand("update tblclientes set Utiliza_Método_Anticoncepcional='" & cbometodoanticli.Text & "' where RG_do_Cliente = '" & txtalergiascli.Text & "';", conexao)
                ler = cmd.ExecuteReader(CommandBehavior.CloseConnection)
                conexao.Close()

                conexao.Open()
                cmd = New OleDb.OleDbCommand("update tblclientes set Tabagismo='" & cbotabagismocli.Text & "' where RG_do_Cliente = '" & txtrgcli.Text & "';", conexao)
                ler = cmd.ExecuteReader(CommandBehavior.CloseConnection)
                conexao.Close()

                conexao.Open()
                cmd = New OleDb.OleDbCommand("update tblclientes set Atividade_Física='" & cboatividadefisicacli.Text & "' where RG_do_Cliente = '" & txtrgcli.Text & "';", conexao)
                ler = cmd.ExecuteReader(CommandBehavior.CloseConnection)
                conexao.Close()

                conexao.Open()
                cmd = New OleDb.OleDbCommand("update tblclientes set Fez_Algum_Tratamento_Estético_Anterior='" & cbotratamentoesticocli.Text & "' where RG_do_Cliente = '" & txtrgcli.Text & "';", conexao)
                ler = cmd.ExecuteReader(CommandBehavior.CloseConnection)
                conexao.Close()

                conexao.Open()
                cmd = New OleDb.OleDbCommand("update tblclientes set Motivo_da_Procura='" & txtmotivoprocuracli.Text & "' where RG_do_Cliente = '" & txtrgcli.Text & "';", conexao)
                ler = cmd.ExecuteReader(CommandBehavior.CloseConnection)
                conexao.Close()

                conexao.Open()
                cmd = New OleDb.OleDbCommand("update tblclientes set Observações='" & txtobservacoescli.Text & "' where RG_do_Cliente = '" & txtrgcli.Text & "';", conexao)
                ler = cmd.ExecuteReader(CommandBehavior.CloseConnection)
                conexao.Close()

                conexao.Open()
                cmd = New OleDb.OleDbCommand("update tblclientes set Nome_da_Imagem='" & txtfotohora.Text & "' where RG_do_Cliente = '" & txtrgcli.Text & "';", conexao)
                ler = cmd.ExecuteReader(CommandBehavior.CloseConnection)
                conexao.Close()

                conexao = Nothing
                MsgBox("Dados atualizados com sucesso!", MsgBoxStyle.OkOnly, "Atualizar")
            Catch ex As Exception
                MessageBox.Show(ex.ToString, "Erro na Inclusão", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If
        flag = 0
        If txtendcli.Text.Trim = "" Then
            MessageBox.Show("Informe o endereço.", "Erro Entrada", MessageBoxButtons.OK, MessageBoxIcon.Information)
            txtendcli.Focus()
            Exit Sub
        End If
        Dim itemSalvo As String = txtendcli.Text
        Dim linhaSalva As Integer
        'encerra edição do CurrencyManager
        CManager.EndCurrentEdit()
        'define o modo de exibição ordenado por Nome
        datatb.DefaultView.Sort = "RG_do_Cliente"
        'obtem o id da linha Salva
        linhaSalva = datatb.DefaultView.Find(itemSalvo)
        'atribui a posição da linha em edição ao CurrencyManager
        CManager.Position = linhaSalva
        Call exibirdados()
        Call definirEstado("Ver")
        btnnovocli.Enabled = True
        btneditarcli.Enabled = True
        btnexcluircli.Enabled = True
        btncancelarcli.Enabled = False
        btnsalvarcli.Enabled = False

        fotocliente1.Dispose()
        Call fechaJanelaVisualizacao()
    End Sub

    Private Sub btncancelarcli_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btncancelarcli.Click
        btnnovocli.Enabled = True
        btneditarcli.Enabled = True
        btnexcluircli.Enabled = True
        btncancelarcli.Enabled = False
        btnsalvarcli.Enabled = False
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

    Private Sub cboestadoscli_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cboestadoscli.TextChanged
        If cboestadoscli.Text = "AC" Then
            txtcidadecli.Text = "Acre"
        End If
        If cboestadoscli.Text = "AL" Then
            txtcidadecli.Text = "Alagoas"
        End If
        If cboestadoscli.Text = "AP" Then
            txtcidadecli.Text = "Amapá"
        End If
        If cboestadoscli.Text = "AM" Then
            txtcidadecli.Text = "Amazonas"
        End If
        If cboestadoscli.Text = "SP" Then
            txtcidadecli.Text = "São Paulo"
        End If
        If cboestadoscli.Text = "BA" Then
            txtcidadecli.Text = "Bahia"
        End If
        If cboestadoscli.Text = "CE" Then
            txtcidadecli.Text = "Ceará"
        End If
        If cboestadoscli.Text = "DF" Then
            txtcidadecli.Text = "Distrito Federal"
        End If
        If cboestadoscli.Text = "GO" Then
            txtcidadecli.Text = "Goiás"
        End If
        If cboestadoscli.Text = "ES" Then
            txtcidadecli.Text = "Espírito Santo"
        End If
        If cboestadoscli.Text = "MA" Then
            txtcidadecli.Text = "Maranhão"
        End If
        If cboestadoscli.Text = "MT" Then
            txtcidadecli.Text = "Mato Grosso"
        End If
        If cboestadoscli.Text = "MS" Then
            txtcidadecli.Text = "Mato Grosso do Sul"
        End If
        If cboestadoscli.Text = "MG" Then
            txtcidadecli.Text = "Minas Gerais"
        End If
        If cboestadoscli.Text = "PA" Then
            txtcidadecli.Text = "Pará"
        End If
        If cboestadoscli.Text = "PB" Then
            txtcidadecli.Text = "Paraiba"
        End If
        If cboestadoscli.Text = "PR" Then
            txtcidadecli.Text = "Paraná"
        End If
        If cboestadoscli.Text = "PE" Then
            txtcidadecli.Text = "Pernambuco"
        End If
        If cboestadoscli.Text = "PI" Then
            txtcidadecli.Text = "Piauí"
        End If
        If cboestadoscli.Text = "RJ" Then
            txtcidadecli.Text = "Rio de Janeiro"
        End If
        If cboestadoscli.Text = "RN" Then
            txtcidadecli.Text = "Rio Grande do Norte"
        End If
        If cboestadoscli.Text = "RS" Then
            txtcidadecli.Text = "Rio Grande do Sul"
        End If
        If cboestadoscli.Text = "RO" Then
            txtcidadecli.Text = "Rondônia"
        End If
        If cboestadoscli.Text = "RR" Then
            txtcidadecli.Text = "Rorâima"
        End If
        If cboestadoscli.Text = "SP" Then
            txtcidadecli.Text = "São Paulo"
        End If
        If cboestadoscli.Text = "SC" Then
            txtcidadecli.Text = "Santa Catarina"
        End If
        If cboestadoscli.Text = "SE" Then
            txtcidadecli.Text = "Sergipe"
        End If
        If cboestadoscli.Text = "TO" Then
            txtcidadecli.Text = "Tocantins"
        End If
    End Sub

    Private Sub cbosexocli_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cbosexocli.TextChanged
        If cbosexocli.Text = "Masculino" Then
            Call masculino()
        End If
        If cbosexocli.Text = "Feminino" Then
            lblgravida.Visible = True
            cbogravidacli.Visible = True
            lblmetodoanticonceptivo.Visible = True
            cbometodoanticli.Visible = True
            cbogravidacli.ResetText()
            cbometodoanticli.ResetText()
        End If
    End Sub

    Private Sub txtobservacoescli_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtobservacoescli.KeyPress
        Call contagemsemerro()
    End Sub

    Private Sub txtobservacoescli_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles txtobservacoescli.MouseDown
        Call contagemsemerro()
    End Sub

    Private Sub txtobservacoescli_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtobservacoescli.MouseEnter
        Call contagemsemerro()
    End Sub

    Private Sub txtobservacoescli_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtobservacoescli.TextChanged
        Call contagem()
    End Sub

    Private Sub btnPrimeiro_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        CManager.Position = 0
        Call exibirdados()
    End Sub

    Private Sub btnAnterior_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        CManager.Position -= 1
        Call exibirdados()
    End Sub

    Private Sub btnProximo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        CManager.Position += 1
        Call exibirdados()
    End Sub

    Private Sub btnUltimo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        CManager.Position = CManager.Count - 1
        Call exibirdados()
    End Sub

    Private Sub btnprimeirocliente_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnprimeirocliente.Click
        CManager.Position = 0
        Call exibirdados()
    End Sub

    Private Sub btnprimeirocliente_load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        btnprimeirocliente.Image = My.Resources.primeiro
    End Sub

    Private Sub btnclienteanterior_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnclienteanterior.Click
        CManager.Position -= 1
        Call exibirdados()
    End Sub

    Private Sub btnclienteanterior_load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        btnclienteanterior.Image = My.Resources.anterior
    End Sub

    Private Sub btnproximocliente_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnproximocliente.Click
        CManager.Position += 1
        Call exibirdados()
    End Sub

    Private Sub btnproximocliente_load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        btnproximocliente.Image = My.Resources.proximo
    End Sub

    Private Sub btnultimocliente_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnultimocliente.Click
        CManager.Position = CManager.Count - 1
        Call exibirdados()
    End Sub

    Private Sub btnultimocliente_load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        btnultimocliente.Image = My.Resources.ultimo
    End Sub

    Private Sub btnprimeirocliente_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnprimeirocliente.MouseLeave
        btnprimeirocliente.Image = My.Resources.primeiroClaro
        btnprimeirocliente.Image = My.Resources.primeiro
    End Sub

    Private Sub btnprimeirocliente_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles btnprimeirocliente.MouseMove
        btnprimeirocliente.Image = My.Resources.primeiro
        btnprimeirocliente.Image = My.Resources.primeiroClaro
    End Sub

    Private Sub btnclienteanterior_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnclienteanterior.MouseLeave
        btnclienteanterior.Image = My.Resources.anteriorClaro
        btnclienteanterior.Image = My.Resources.anterior
    End Sub

    Private Sub btnclienteanterior_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles btnclienteanterior.MouseMove
        btnclienteanterior.Image = My.Resources.anterior
        btnclienteanterior.Image = My.Resources.anteriorClaro
    End Sub

    Private Sub btnproximocliente_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnproximocliente.MouseLeave
        btnproximocliente.Image = My.Resources.proximoClaro
        btnproximocliente.Image = My.Resources.proximo
    End Sub

    Private Sub btnproximocliente_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles btnproximocliente.MouseMove
        btnproximocliente.Image = My.Resources.proximo
        btnproximocliente.Image = My.Resources.proximoClaro
    End Sub

    Private Sub btnultimocliente_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnultimocliente.MouseLeave
        btnultimocliente.Image = My.Resources.ultimoClaro
        btnultimocliente.Image = My.Resources.ultimo
    End Sub

    Private Sub btnultimocliente_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles btnultimocliente.MouseMove
        btnultimocliente.Image = My.Resources.ultimo
        btnultimocliente.Image = My.Resources.ultimoClaro
    End Sub

    Private Sub btnlistadecliente_load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        btnlistadecliente.Image = My.Resources.lista
    End Sub

    Private Sub btnlistadecliente_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnlistadecliente.Click
        frmpesquisasClientes.Show()
    End Sub

    Private Sub btnlistadecliente_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnlistadecliente.MouseLeave
        btnlistadecliente.Image = My.Resources.listaClaro
        btnlistadecliente.Image = My.Resources.lista
    End Sub

    Private Sub btnlistadecliente_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles btnlistadecliente.MouseMove
        btnlistadecliente.Image = My.Resources.lista
        btnlistadecliente.Image = My.Resources.listaClaro
    End Sub

    Private Sub btnrelatoriodecliente_load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        btnrelatoriodecliente.Image = My.Resources.relatorios
    End Sub

    Private Sub btnrelatoriodecliente_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnrelatoriodecliente.Click
        frmrelatoriodeClientes.Show()
    End Sub

    Private Sub btnrelatoriodecliente_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnrelatoriodecliente.MouseLeave
        btnrelatoriodecliente.Image = My.Resources.relatoriosClaro
        btnrelatoriodecliente.Image = My.Resources.relatorios
    End Sub

    Private Sub btnrelatoriodecliente_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles btnrelatoriodecliente.MouseMove
        btnrelatoriodecliente.Image = My.Resources.relatorios
        btnrelatoriodecliente.Image = My.Resources.relatoriosClaro
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

    Private Sub cboalergias_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboalergias.SelectedIndexChanged
        If cboalergias.Text = "Sim" Then
            txtalergiascli.ReadOnly = False
            txtalergiascli.Clear()
        End If
        If cboalergias.Text = "Não" Then
            txtalergiascli.ReadOnly = True
            txtalergiascli.Text = "Não consta."
        End If
    End Sub

    
    Private Sub cbodoencacli_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbodoencacli.SelectedIndexChanged
        If cbodoencacli.Text = "Sim" Then
            txtdoencacli.ReadOnly = False
            txtdoencacli.Clear()
        End If
        If cbodoencacli.Text = "Não" Then
            txtdoencacli.ReadOnly = True
            txtdoencacli.Text = "Não consta."
        End If
    End Sub

  
End Class