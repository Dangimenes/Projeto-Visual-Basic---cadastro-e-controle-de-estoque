Public Class frmfuncionarios

    'Inicia formulario load
    Private Sub frmfuncionarios_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
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
        cmd = New OleDb.OleDbCommand("SELECT * FROM tblfuncionarios ORDER BY RG_Funcionário", conexao)
        'define um dataAdapter
        da = New OleDb.OleDbDataAdapter()
        da.SelectCommand = cmd
        'define e preenche um DataTable com os dados
        datatb = New DataTable()
        da.Fill(datatb)
        'vincula os dados aos controles do formulário
        txtrgfunc.DataBindings.Add("Text", datatb, "RG_Funcionário")
        txtnomefunc.DataBindings.Add("Text", datatb, "Nome")
        txtcepfunc.DataBindings.Add("Text", datatb, "CEP")
        cboestadosfunc.DataBindings.Add("Text", datatb, "Estado")
        txtcidadefunc.DataBindings.Add("Text", datatb, "Cidade")
        txtbairrofunc.DataBindings.Add("Text", datatb, "Bairro")
        txtendfunc.DataBindings.Add("Text", datatb, "Endereço")
        txtnumerofunc.DataBindings.Add("Text", datatb, "Número")
        txtcompfunc.DataBindings.Add("Text", datatb, "Complemento")
        cbosexofunc.DataBindings.Add("Text", datatb, "Sexo")
        txttelfunc.DataBindings.Add("Text", datatb, "Telefone")
        txtnomemaefunc.DataBindings.Add("Text", datatb, "Nome_da_Mãe")
        txtnomepaifunc.DataBindings.Add("Text", datatb, "Nome_do_Pai")
        txtcpffunc.DataBindings.Add("Text", datatb, "CPF")
        txtpisfunc.DataBindings.Add("Text", datatb, "PIS")
        txtcarteirafunc.DataBindings.Add("Text", datatb, "Carteira_de_Trabalho")
        txtdatadenascfunc.DataBindings.Add("Text", datatb, "Data_de_Nascimento")
        cboestadocivilfunc.DataBindings.Add("Text", datatb, "Estado_Civil")
        txtgraufunc.DataBindings.Add("Text", datatb, "Grau_de_Escolaridade")
        txtfuncaofunc.DataBindings.Add("Text", datatb, "Função")
        txtsalariofunc.DataBindings.Add("Text", datatb, "Salário")
        txthorarioentradafunc.DataBindings.Add("Text", datatb, "Horário_de_Entrada")
        txthorariosaidafunc.DataBindings.Add("Text", datatb, "Horário_de_Saída")
        txtdataadmissaofunc.DataBindings.Add("Text", datatb, "Data_de_Admissão")
        txtfotohora.DataBindings.Add("Text", datatb, "Nome_da_Imagem")
        'estabelece o currencyManager
        CManager = DirectCast(Me.BindingContext(datatb), CurrencyManager)
        Call exibirdados()
        'define o estado de exibição dos dados: visualizar (Ver) e Editar
        Call definirEstado("Ver")
        Call preto()

        'ComboBox inicia
        cboestadosfunc.Items.Add("AC")
        cboestadosfunc.Items.Add("AL")
        cboestadosfunc.Items.Add("AP")
        cboestadosfunc.Items.Add("AM")
        cboestadosfunc.Items.Add("BA")
        cboestadosfunc.Items.Add("CE")
        cboestadosfunc.Items.Add("DF")
        cboestadosfunc.Items.Add("GO")
        cboestadosfunc.Items.Add("ES")
        cboestadosfunc.Items.Add("MA")
        cboestadosfunc.Items.Add("MT")
        cboestadosfunc.Items.Add("MS")
        cboestadosfunc.Items.Add("MG")
        cboestadosfunc.Items.Add("PA")
        cboestadosfunc.Items.Add("PB")
        cboestadosfunc.Items.Add("PR")
        cboestadosfunc.Items.Add("PE")
        cboestadosfunc.Items.Add("PI")
        cboestadosfunc.Items.Add("RJ")
        cboestadosfunc.Items.Add("RN")
        cboestadosfunc.Items.Add("RS")
        cboestadosfunc.Items.Add("RO")
        cboestadosfunc.Items.Add("RR")
        cboestadosfunc.Items.Add("SP")
        cboestadosfunc.Items.Add("SC")
        cboestadosfunc.Items.Add("SE")
        cboestadosfunc.Items.Add("TO")

        cbosexofunc.Items.Add("Masculino")
        cbosexofunc.Items.Add("Feminino")
        cboestadocivilfunc.Items.Add("Solteiro(a)")
        cboestadocivilfunc.Items.Add("Casado(a)")
        'ComboBox Termina
        lstdispositivos.Visible = False
        Call fechaJanelaVisualizacao()
    End Sub

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
        foto.Save(LocalFotosfuncionario & "\" & idimagem, Imaging.ImageFormat.Jpeg)
        fotofunc1.Image = foto
        fotofunc2.Image = foto
        'obtem a posição da / na string
        Dim posicaoBarra As Integer = idimagem.LastIndexOf("\")
        'extrai somente o nome do arquivo da string e atribui a lblFoto
        txtfotohora.Text = idimagem.Substring(posicaoBarra + 1)
        'chama a rotina para exibir a foto
        Call ExibirFoto()
    End Sub
    'Termina formulario load

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
                fotofunc2.Image = Image.FromFile(LocalFotosfuncionario & "\" & txtfotohora.Text)
            Catch ex As Exception
                fotofunc2.Image = Nothing
                MessageBox.Show(ex.Message, "Erro ao carregar Foto.", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        Else
            fotofunc2.Image = Nothing
        End If
    End Sub

    Private Sub definirEstado(ByVal AppEstado As String)
        Estado = AppEstado

        Select Case AppEstado
            Case "Ver"
                btnnovofunc.Enabled = True
                btncancelarfunc.Enabled = True
                btneditarfunc.Enabled = True
                btnsalvarfunc.Enabled = True
                btnexcluirfunc.Enabled = True
                txtrgfunc.ReadOnly = True
                txtnomefunc.ReadOnly = True
                cboestadosfunc.Enabled = False
                txtcidadefunc.ReadOnly = True
                txtbairrofunc.ReadOnly = True
                txtendfunc.ReadOnly = True
                txtnumerofunc.ReadOnly = True
                txtcompfunc.ReadOnly = True
                txtcepfunc.ReadOnly = True
                txttelfunc.ReadOnly = True
                cbosexofunc.Enabled = False
                txtnomemaefunc.ReadOnly = True
                txtnomepaifunc.ReadOnly = True
                txtcpffunc.ReadOnly = True
                txtpisfunc.ReadOnly = True
                txtcarteirafunc.ReadOnly = True
                txtdatadenascfunc.ReadOnly = True
                cboestadocivilfunc.Enabled = False
                txtgraufunc.ReadOnly = True
                txtfuncaofunc.ReadOnly = True
                txtsalariofunc.ReadOnly = True
                txthorarioentradafunc.ReadOnly = True
                txthorariosaidafunc.ReadOnly = True
                txtdataadmissaofunc.ReadOnly = True

            Case "Editar", "Incluir"
                btneditarfunc.Enabled = False
                btnsalvarfunc.Enabled = True
                btncancelarfunc.Enabled = True
                btnnovofunc.Enabled = False
                btnexcluirfunc.Enabled = False
                txtrgfunc.ReadOnly = False
                txtnomefunc.ReadOnly = False
                cboestadosfunc.Enabled = True
                txtcidadefunc.ReadOnly = False
                txtbairrofunc.ReadOnly = False
                txtendfunc.ReadOnly = False
                txtnumerofunc.ReadOnly = False
                txtcompfunc.ReadOnly = False
                txtcepfunc.ReadOnly = False
                txttelfunc.ReadOnly = False
                cbosexofunc.Enabled = True
                txtnomemaefunc.ReadOnly = False
                txtnomepaifunc.ReadOnly = False
                txtcpffunc.ReadOnly = False
                txtpisfunc.ReadOnly = False
                txtcarteirafunc.ReadOnly = False
                txtdatadenascfunc.ReadOnly = False
                cboestadocivilfunc.Enabled = True
                txtgraufunc.ReadOnly = False
                txtfuncaofunc.ReadOnly = False
                txtsalariofunc.ReadOnly = False
                txthorarioentradafunc.ReadOnly = False
                txthorariosaidafunc.ReadOnly = False
                txtdataadmissaofunc.ReadOnly = False
        End Select
        txtnomefunc.Focus()
    End Sub

    Public Sub limpaCampos()
        txtrgfunc.Clear()
        txtnomefunc.Clear()
        txtcepfunc.Clear()
        cboestadosfunc.ResetText()
        cboestadosfunc.Enabled = True
        txtcidadefunc.Clear()
        txtcidadefunc.Clear()
        txtbairrofunc.Clear()
        txtendfunc.Clear()
        txtnumerofunc.Clear()
        txtcompfunc.Clear()
        cbosexofunc.ResetText()
        cbosexofunc.Enabled = True
        txttelfunc.Clear()
        txtnomemaefunc.Clear()
        txtnomepaifunc.Clear()
        txtcpffunc.Clear()
        txtpisfunc.Clear()
        txtcarteirafunc.Clear()
        txtdatadenascfunc.Clear()
        cboestadocivilfunc.ResetText()
        cboestadocivilfunc.Enabled = True
        txtgraufunc.Clear()
        txtfuncaofunc.Clear()
        txtsalariofunc.Clear()
        txthorarioentradafunc.Clear()
        txthorariosaidafunc.Clear()
        txtdataadmissaofunc.Clear()
        fotofunc1.Image = fotofunc1.InitialImage
        fotofunc2.Image = fotofunc2.InitialImage
    End Sub

    Private Sub grifa()
        If (txtrgfunc.Text = "") Then
            lblrg.ForeColor = Color.Red
        End If
        If (txtnomefunc.Text = "") Then
            lblnome.ForeColor = Color.Red
        End If
        If (txtcepfunc.Text = "") Then
            lblcep.ForeColor = Color.Red
        End If
        If (cboestadosfunc.Focus) Then
            lblestado.ForeColor = Color.Red
        End If
        If (txtcidadefunc.Text = "") Then
            lblcidade.ForeColor = Color.Red
        End If
        If (txtbairrofunc.Text = "") Then
            lblbairro.ForeColor = Color.Red
        End If
        If (txtendfunc.Text = "") Then
            lblendereco.ForeColor = Color.Red
        End If
        If (txtnumerofunc.Text = "") Then
            lblnumero.ForeColor = Color.Red
        End If
        If (txttelfunc.Text = "") Then
            lbltelefone.ForeColor = Color.Red
        End If
        If (cbosexofunc.Text = "") Then
            lblsexo.ForeColor = Color.Red
        End If
        If (txtnomemaefunc.Text = "") Then
            lblnomemae.ForeColor = Color.Red
        End If
        If (txtnomepaifunc.Text = "") Then
            lblnomepai.ForeColor = Color.Red
        End If
        If (txttelfunc.Text = "") Then
            lbltelefone.ForeColor = Color.Red
        End If
        If (txtcpffunc.Text = "") Then
            lblcpf.ForeColor = Color.Red
        End If
        If (txtpisfunc.Text = "") Then
            lblpis.ForeColor = Color.Red
        End If
        If (txtcarteirafunc.Text = "") Then
            lblcarteiratrabalho.ForeColor = Color.Red
        End If
        If (txtdatadenascfunc.Text = "") Then
            lbldatanascimento.ForeColor = Color.Red
        End If
        If (cboestadocivilfunc.Text = "") Then
            lblestadocivil.ForeColor = Color.Red
        End If
        If (txtgraufunc.Text = "") Then
            lblgrau.ForeColor = Color.Red
        End If
        If (txtfuncaofunc.Text = "") Then
            lblfuncao.ForeColor = Color.Red
        End If
        If (txtsalariofunc.Text = "") Then
            lblsalario.ForeColor = Color.Red
        End If
        If (txthorarioentradafunc.Text = "") Then
            lblhoraentrada.ForeColor = Color.Red
        End If
        If (txthorariosaidafunc.Text = "") Then
            lblhorasaida.ForeColor = Color.Red
        End If
        If (txtdataadmissaofunc.Text = "") Then
            lbladmissão.ForeColor = Color.Red
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
        lblsexo.ForeColor = Color.Black
        lblnomemae.ForeColor = Color.Black
        lblnomepai.ForeColor = Color.Black
        lbltelefone.ForeColor = Color.Black
        lblcpf.ForeColor = Color.Black
        lblpis.ForeColor = Color.Black
        lblcarteiratrabalho.ForeColor = Color.Black
        lbldatanascimento.ForeColor = Color.Black
        lblestadocivil.ForeColor = Color.Black
        lblgrau.ForeColor = Color.Black
        lblfuncao.ForeColor = Color.Black
        lblsalario.ForeColor = Color.Black
        lblhoraentrada.ForeColor = Color.Black
        lblhorasaida.ForeColor = Color.Black
        lbladmissão.ForeColor = Color.Black
    End Sub
    'Inicia codigo dos Botões e termina dos private sub

    Private Sub btnnovofunc_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnnovofunc.Click
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
        fotofunc2.Image = Nothing
        txtfotohora.Text = ""
    End Sub

    Private Sub btneditarfunc_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btneditarfunc.Click
        flag = 0
        Call definirEstado("Editar")
        Call preto()
        Call abreJanelaVisualizacao()
    End Sub

    Private Sub btnexcluirfunc_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnexcluirfunc.Click
        If MsgBox("deseja excluir", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
            Dim dr As OleDb.OleDbDataReader
            Call conexaogeral()
            I = 0
            conexao.Open()
            cmd = New OleDb.OleDbCommand("DELETE  from tblfuncionarios where Nome = '" & txtnomefunc.Text & "';", conexao)
            dr = cmd.ExecuteReader(CommandBehavior.CloseConnection)
            MsgBox("'" & txtnomefunc.Text & "'  Funcionario Excluido ", MsgBoxStyle.Information, "Excluido")
            conexao.Close()

            Call conexaogeral()
            conexao.Open()
            da = New OleDb.OleDbDataAdapter("Select * from tblfuncionarios ;", conexao)
            DS = New DataSet
            da.Fill(DS, "tblfuncionarios")
            For I As Integer = 0 To DS.Tables(0).Rows.Count - 1
                txtrgfunc.Text = DS.Tables(0).Rows(I)("RG_Funcionário").ToString
                txtnomefunc.Text = DS.Tables(0).Rows(I)("Nome").ToString
                txtcepfunc.Text = DS.Tables(0).Rows(I)("CEP").ToString
                cboestadosfunc.Text = DS.Tables(0).Rows(I)("Estado").ToString
                txtcidadefunc.Text = DS.Tables(0).Rows(I)("Cidade").ToString
                txtbairrofunc.Text = DS.Tables(0).Rows(I)("Bairro").ToString
                txtendfunc.Text = DS.Tables(0).Rows(I)("Endereço").ToString
                txtnumerofunc.Text = DS.Tables(0).Rows(I)("Número").ToString
                txtcompfunc.Text = DS.Tables(0).Rows(I)("Complemento").ToString
                cbosexofunc.Text = DS.Tables(0).Rows(I)("Sexo").ToString
                txttelfunc.Text = DS.Tables(0).Rows(I)("Telefone").ToString
                txtnomemaefunc.Text = DS.Tables(0).Rows(I)("Nome_da_Mãe").ToString
                txtnomepaifunc.Text = DS.Tables(0).Rows(I)("Nome_do_Pai").ToString
                txtcpffunc.Text = DS.Tables(0).Rows(I)("CPF").ToString
                txtpisfunc.Text = DS.Tables(0).Rows(I)("PIS").ToString
                txtcarteirafunc.Text = DS.Tables(0).Rows(I)("Carteira_de_Trabalho").ToString
                txtdatadenascfunc.Text = DS.Tables(0).Rows(I)("Data_de_Nascimento").ToString
                cboestadocivilfunc.Text = DS.Tables(0).Rows(I)("Estado_Civil").ToString
                txtgraufunc.Text = DS.Tables(0).Rows(I)("Grau_de_Escolaridade").ToString
                txtfuncaofunc.Text = DS.Tables(0).Rows(I)("Função").ToString
                txtsalariofunc.Text = DS.Tables(0).Rows(I)("Salário").ToString
                txthorarioentradafunc.Text = DS.Tables(0).Rows(I)("Horário_de_Entrada").ToString
                txthorariosaidafunc.Text = DS.Tables(0).Rows(I)("Horário_de_Saída").ToString
                txtdataadmissaofunc.Text = DS.Tables(0).Rows(I)("Data_de_Admissão").ToString
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

    Private Sub btnsalvarfunc_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnsalvarfunc.Click
        Call conexaogeral()
        If flag = 1 Then
            conexao.Open()
            Try
                cmd.CommandText = "INSERT INTO tblfuncionarios(RG_Funcionário,Nome,CEP,Estado,Cidade,Bairro,Endereço,Número,Complemento,Sexo,Telefone,Nome_da_Mãe,Nome_do_Pai,CPF,PIS,Carteira_de_Trabalho,Data_de_Nascimento,Estado_Civil,Grau_de_Escolaridade,Função,Salário,Horário_de_Entrada,Horário_de_Saída,Data_de_Admissão,Nome_da_Imagem) VALUES(@rgfunc,@nomefunc,@cepfunc,@estadofunc,@cidadefunc,@bairrofunc,@enderecofunc,@numerofunc,@complfunc,@sexofunc,@telfunc,@nomemaefunc,@nomepaifunc,@cpffunc,@pisfunc,@carttrabfunc,@nascimentofunc,@estcivilfunc,@graufunc,@funcaofunc,@salariofunc,@hrentradafunc,@hrsaidafunc,@admissaofunc,@idimage)"
                cmd.Parameters.AddWithValue("@rgfunc", txtrgfunc.Text)
                cmd.Parameters.AddWithValue("@nomefunc", txtnomefunc.Text)
                cmd.Parameters.AddWithValue("@cepfunc", txtcepfunc.Text)
                cmd.Parameters.AddWithValue("@estadofunc", cboestadosfunc.Text)
                cmd.Parameters.AddWithValue("@cidadefunc", txtcidadefunc.Text)
                cmd.Parameters.AddWithValue("@bairrofunc", txtbairrofunc.Text)
                cmd.Parameters.AddWithValue("@enderecofunc", txtendfunc.Text)
                cmd.Parameters.AddWithValue("@numerofunc", txtnumerofunc.Text)
                cmd.Parameters.AddWithValue("@complfunc", txtcompfunc.Text)
                cmd.Parameters.AddWithValue("@sexofunc", cbosexofunc.Text)
                cmd.Parameters.AddWithValue("@telfunc", txttelfunc.Text)
                cmd.Parameters.AddWithValue("@nomemaefunc", txtnomemaefunc.Text)
                cmd.Parameters.AddWithValue("@nomepaifunc", txtnomepaifunc.Text)
                cmd.Parameters.AddWithValue("@cpffunc", txtcpffunc.Text)
                cmd.Parameters.AddWithValue("@pisfunc", txtpisfunc.Text)
                cmd.Parameters.AddWithValue("@carttrabfunc", txtcarteirafunc.Text)
                cmd.Parameters.AddWithValue("@nascimentofunc", txtdatadenascfunc.Text)
                cmd.Parameters.AddWithValue("@estcivilfunc", cboestadocivilfunc.Text)
                cmd.Parameters.AddWithValue("@graufunc", txtgraufunc.Text)
                cmd.Parameters.AddWithValue("@funcaofunc", txtfuncaofunc.Text)
                cmd.Parameters.AddWithValue("@salariofunc", txtsalariofunc.Text)
                cmd.Parameters.AddWithValue("@hrentradafunc", txthorarioentradafunc.Text)
                cmd.Parameters.AddWithValue("@hrsaidafunc", txthorariosaidafunc.Text)
                cmd.Parameters.AddWithValue("@admissaofunc", txtdataadmissaofunc.Text)
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
                cmd = New OleDb.OleDbCommand("update tblfuncionarios set Nome='" & txtnomefunc.Text & "' where RG_Funcionário = '" & txtrgfunc.Text & "';", conexao)
                ler = cmd.ExecuteReader(CommandBehavior.CloseConnection)
                conexao.Close()

                conexao.Open()
                cmd = New OleDb.OleDbCommand("update tblfuncionarios set CEP='" & txtcepfunc.Text & "' where RG_Funcionário = '" & txtrgfunc.Text & "';", conexao)
                ler = cmd.ExecuteReader(CommandBehavior.CloseConnection)
                conexao.Close()

                conexao.Open()
                cmd = New OleDb.OleDbCommand("update tblfuncionarios set Estado='" & cboestadosfunc.Text & "' where RG_Funcionário = '" & txtrgfunc.Text & "';", conexao)
                ler = cmd.ExecuteReader(CommandBehavior.CloseConnection)
                conexao.Close()

                conexao.Open()
                cmd = New OleDb.OleDbCommand("update tblfuncionarios set Cidade='" & txtcidadefunc.Text & "' where RG_Funcionário = '" & txtrgfunc.Text & "';", conexao)
                ler = cmd.ExecuteReader(CommandBehavior.CloseConnection)
                conexao.Close()

                conexao.Open()
                cmd = New OleDb.OleDbCommand("update tblfuncionarios set Bairro='" & txtbairrofunc.Text & "' where RG_Funcionário = '" & txtrgfunc.Text & "';", conexao)
                ler = cmd.ExecuteReader(CommandBehavior.CloseConnection)
                conexao.Close()

                conexao.Open()
                cmd = New OleDb.OleDbCommand("update tblfuncionarios set Endereço='" & txtendfunc.Text & "' where RG_Funcionário = '" & txtrgfunc.Text & "';", conexao)
                ler = cmd.ExecuteReader(CommandBehavior.CloseConnection)
                conexao.Close()

                conexao.Open()
                cmd = New OleDb.OleDbCommand("update tblfuncionarios set Número='" & txtnumerofunc.Text & "' where RG_Funcionário = '" & txtrgfunc.Text & "';", conexao)
                ler = cmd.ExecuteReader(CommandBehavior.CloseConnection)
                conexao.Close()

                conexao.Open()
                cmd = New OleDb.OleDbCommand("update tblfuncionarios set Complemento='" & txtcompfunc.Text & "' where RG_Funcionário = '" & txtrgfunc.Text & "';", conexao)
                ler = cmd.ExecuteReader(CommandBehavior.CloseConnection)
                conexao.Close()

                conexao.Open()
                cmd = New OleDb.OleDbCommand("update tblfuncionarios set Sexo='" & cbosexofunc.Text & "' where RG_Funcionário = '" & txtrgfunc.Text & "';", conexao)
                ler = cmd.ExecuteReader(CommandBehavior.CloseConnection)
                conexao.Close()

                conexao.Open()
                cmd = New OleDb.OleDbCommand("update tblfuncionarios set Telefone='" & txttelfunc.Text & "' where RG_Funcionário = '" & txtrgfunc.Text & "';", conexao)
                ler = cmd.ExecuteReader(CommandBehavior.CloseConnection)
                conexao.Close()

                conexao.Open()
                cmd = New OleDb.OleDbCommand("update tblfuncionarios set Nome_da_Mãe='" & txtnomemaefunc.Text & "' where RG_Funcionário = '" & txtrgfunc.Text & "';", conexao)
                ler = cmd.ExecuteReader(CommandBehavior.CloseConnection)
                conexao.Close()

                conexao.Open()
                cmd = New OleDb.OleDbCommand("update tblfuncionarios set Nome_do_Pai='" & txtnomepaifunc.Text & "' where RG_Funcionário = '" & txtrgfunc.Text & "';", conexao)
                ler = cmd.ExecuteReader(CommandBehavior.CloseConnection)
                conexao.Close()

                conexao.Open()
                cmd = New OleDb.OleDbCommand("update tblfuncionarios set CPF='" & txtcpffunc.Text & "' where RG_Funcionário = '" & txtrgfunc.Text & "';", conexao)
                ler = cmd.ExecuteReader(CommandBehavior.CloseConnection)
                conexao.Close()

                conexao.Open()
                cmd = New OleDb.OleDbCommand("update tblfuncionarios set PIS='" & txtpisfunc.Text & "' where RG_Funcionário = '" & txtrgfunc.Text & "';", conexao)
                ler = cmd.ExecuteReader(CommandBehavior.CloseConnection)
                conexao.Close()

                conexao.Open()
                cmd = New OleDb.OleDbCommand("update tblfuncionarios set Carteira_de_Trabalho='" & txtcarteirafunc.Text & "' where RG_Funcionário = '" & txtrgfunc.Text & "';", conexao)
                ler = cmd.ExecuteReader(CommandBehavior.CloseConnection)
                conexao.Close()

                conexao.Open()
                cmd = New OleDb.OleDbCommand("update tblfuncionarios set Data_de_Nascimento='" & txtdatadenascfunc.Text & "' where RG_Funcionário = '" & txtrgfunc.Text & "';", conexao)
                ler = cmd.ExecuteReader(CommandBehavior.CloseConnection)
                conexao.Close()

                conexao.Open()
                cmd = New OleDb.OleDbCommand("update tblfuncionarios set Estado_Civil='" & cboestadocivilfunc.Text & "' where RG_Funcionário = '" & txtrgfunc.Text & "';", conexao)
                ler = cmd.ExecuteReader(CommandBehavior.CloseConnection)
                conexao.Close()

                conexao.Open()
                cmd = New OleDb.OleDbCommand("update tblfuncionarios set Grau_de_Escolaridade='" & txtgraufunc.Text & "' where RG_Funcionário = '" & txtrgfunc.Text & "';", conexao)
                ler = cmd.ExecuteReader(CommandBehavior.CloseConnection)
                conexao.Close()

                conexao.Open()
                cmd = New OleDb.OleDbCommand("update tblfuncionarios set Função='" & txtfuncaofunc.Text & "' where RG_Funcionário = '" & txtrgfunc.Text & "';", conexao)
                ler = cmd.ExecuteReader(CommandBehavior.CloseConnection)
                conexao.Close()

                conexao.Open()
                cmd = New OleDb.OleDbCommand("update tblfuncionarios set Salário='" & txtsalariofunc.Text & "' where RG_Funcionário = '" & txtrgfunc.Text & "';", conexao)
                ler = cmd.ExecuteReader(CommandBehavior.CloseConnection)
                conexao.Close()

                conexao.Open()
                cmd = New OleDb.OleDbCommand("update tblfuncionarios set Horário_de_Entrada='" & txthorarioentradafunc.Text & "' where RG_Funcionário = '" & txtrgfunc.Text & "';", conexao)
                ler = cmd.ExecuteReader(CommandBehavior.CloseConnection)
                conexao.Close()

                conexao.Open()
                cmd = New OleDb.OleDbCommand("update tblfuncionarios set Horário_de_Saída='" & txthorariosaidafunc.Text & "' where RG_Funcionário = '" & txtrgfunc.Text & "';", conexao)
                ler = cmd.ExecuteReader(CommandBehavior.CloseConnection)
                conexao.Close()

                conexao.Open()
                cmd = New OleDb.OleDbCommand("update tblfuncionarios set Data_de_Admissão='" & txtdataadmissaofunc.Text & "' where RG_Funcionário = '" & txtrgfunc.Text & "';", conexao)
                ler = cmd.ExecuteReader(CommandBehavior.CloseConnection)
                conexao.Close()

                conexao.Open()
                cmd = New OleDb.OleDbCommand("update tblfuncionarios set Nome_da_Imagem='" & txtfotohora.Text & "' where RG_Funcionário = '" & txtrgfunc.Text & "';", conexao)
                ler = cmd.ExecuteReader(CommandBehavior.CloseConnection)
                conexao.Close()

                conexao = Nothing
                MsgBox("Dados atualizados com sucesso!", MsgBoxStyle.OkOnly, "Atualizar")
            Catch ex As Exception
                MessageBox.Show(ex.ToString, "Erro na Inclusão", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If
        flag = 0
        If txtendfunc.Text.Trim = "" Then
            MessageBox.Show("Informe o endereço.", "Erro Entrada", MessageBoxButtons.OK, MessageBoxIcon.Information)
            txtendfunc.Focus()
            Exit Sub
        End If
        Dim itemSalvo As String = txtendfunc.Text
        Dim linhaSalva As Integer
        'encerra edição do CurrencyManager
        CManager.EndCurrentEdit()
        'define o modo de exibição ordenado por Nome
        datatb.DefaultView.Sort = "RG_Funcionário"
        'obtem o id da linha Salva
        linhaSalva = datatb.DefaultView.Find(itemSalvo)
        'atribui a posição da linha em edição ao CurrencyManager
        CManager.Position = linhaSalva
        Call exibirdados()
        Call definirEstado("Ver")

        fotofunc1.Dispose()
        Call fechaJanelaVisualizacao()
    End Sub

    Private Sub btncancelarfunc_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btncancelarfunc.Click
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

    Private Sub cboestadosfunc_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cboestadosfunc.TextChanged
        If cboestadosfunc.Text = "AC" Then
            txtcidadefunc.Text = "Acre"
        End If
        If cboestadosfunc.Text = "AL" Then
            txtcidadefunc.Text = "Alagoas"
        End If
        If cboestadosfunc.Text = "AP" Then
            txtcidadefunc.Text = "Amapá"
        End If
        If cboestadosfunc.Text = "AM" Then
            txtcidadefunc.Text = "Amazonas"
        End If
        If cboestadosfunc.Text = "SP" Then
            txtcidadefunc.Text = "São Paulo"
        End If
        If cboestadosfunc.Text = "BA" Then
            txtcidadefunc.Text = "Bahia"
        End If
        If cboestadosfunc.Text = "CE" Then
            txtcidadefunc.Text = "Ceará"
        End If
        If cboestadosfunc.Text = "DF" Then
            txtcidadefunc.Text = "Distrito Federal"
        End If
        If cboestadosfunc.Text = "GO" Then
            txtcidadefunc.Text = "Goiás"
        End If
        If cboestadosfunc.Text = "ES" Then
            txtcidadefunc.Text = "Espírito Santo"
        End If
        If cboestadosfunc.Text = "MA" Then
            txtcidadefunc.Text = "Maranhão"
        End If
        If cboestadosfunc.Text = "MT" Then
            txtcidadefunc.Text = "Mato Grosso"
        End If
        If cboestadosfunc.Text = "MS" Then
            txtcidadefunc.Text = "Mato Grosso do Sul"
        End If
        If cboestadosfunc.Text = "MG" Then
            txtcidadefunc.Text = "Minas Gerais"
        End If
        If cboestadosfunc.Text = "PA" Then
            txtcidadefunc.Text = "Pará"
        End If
        If cboestadosfunc.Text = "PB" Then
            txtcidadefunc.Text = "Paraiba"
        End If
        If cboestadosfunc.Text = "PR" Then
            txtcidadefunc.Text = "Paraná"
        End If
        If cboestadosfunc.Text = "PE" Then
            txtcidadefunc.Text = "Pernambuco"
        End If
        If cboestadosfunc.Text = "PI" Then
            txtcidadefunc.Text = "Piauí"
        End If
        If cboestadosfunc.Text = "RJ" Then
            txtcidadefunc.Text = "Rio de Janeiro"
        End If
        If cboestadosfunc.Text = "RN" Then
            txtcidadefunc.Text = "Rio Grande do Norte"
        End If
        If cboestadosfunc.Text = "RS" Then
            txtcidadefunc.Text = "Rio Grande do Sul"
        End If
        If cboestadosfunc.Text = "RO" Then
            txtcidadefunc.Text = "Rondônia"
        End If
        If cboestadosfunc.Text = "RR" Then
            txtcidadefunc.Text = "Rorâima"
        End If
        If cboestadosfunc.Text = "SP" Then
            txtcidadefunc.Text = "São Paulo"
        End If
        If cboestadosfunc.Text = "SC" Then
            txtcidadefunc.Text = "Santa Catarina"
        End If
        If cboestadosfunc.Text = "SE" Then
            txtcidadefunc.Text = "Sergipe"
        End If
        If cboestadosfunc.Text = "TO" Then
            txtcidadefunc.Text = "Tocantins"
        End If
    End Sub

    Private Sub btnrelatoriodefuncionario_load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        btnrelatoriodefuncionario.Image = My.Resources.relatorios
    End Sub

    Private Sub btnrelatoriodefuncionario_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnrelatoriodefuncionario.MouseLeave
        btnrelatoriodefuncionario.Image = My.Resources.relatoriosClaro
        btnrelatoriodefuncionario.Image = My.Resources.relatorios
    End Sub

    Private Sub btnrelatoriodefuncionario_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles btnrelatoriodefuncionario.MouseMove
        btnrelatoriodefuncionario.Image = My.Resources.relatorios
        btnrelatoriodefuncionario.Image = My.Resources.relatoriosClaro
    End Sub

    Private Sub btnlistadefuncionarios_load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        btnlistadefuncionarios.Image = My.Resources.lista
    End Sub
    Private Sub btnlistadefuncionarios_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnlistadefuncionarios.MouseLeave
        btnlistadefuncionarios.Image = My.Resources.listaClaro
        btnlistadefuncionarios.Image = My.Resources.lista
    End Sub

    Private Sub btnlistadefuncionarios_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles btnlistadefuncionarios.MouseMove
        btnlistadefuncionarios.Image = My.Resources.lista
        btnlistadefuncionarios.Image = My.Resources.listaClaro
    End Sub

    Private Sub btnvoltar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnvoltar.Click
        Me.Close()
    End Sub
    Private Sub btnvoltar_load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        btnvoltar.Image = My.Resources.menu
    End Sub

    Private Sub btnvoltar_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnvoltar.MouseLeave
        btnvoltar.Image = My.Resources.menuClaro
        btnvoltar.Image = My.Resources.menu
    End Sub

    Private Sub btnvoltar_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles btnvoltar.MouseMove
        btnvoltar.Image = My.Resources.menu
        btnvoltar.Image = My.Resources.menuClaro
    End Sub

    Private Sub btnprimeirofuncionarios_load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        btnprimeirofuncionarios.Image = My.Resources.primeiro
    End Sub

    Private Sub btnprimeirofuncionarios_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnprimeirofuncionarios.Click
        CManager.Position = 0
        Call exibirdados()
    End Sub

    Private Sub btnprimeirofuncionarios_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnprimeirofuncionarios.MouseLeave
        btnprimeirofuncionarios.Image = My.Resources.primeiroClaro
        btnprimeirofuncionarios.Image = My.Resources.primeiro
    End Sub

    Private Sub btnprimeirofuncionarios_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles btnprimeirofuncionarios.MouseMove
        btnprimeirofuncionarios.Image = My.Resources.primeiro
        btnprimeirofuncionarios.Image = My.Resources.primeiroClaro
    End Sub

    Private Sub btnfuncionarioanterior_load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        btnfuncionarioanterior.Image = My.Resources.anterior
    End Sub

    Private Sub btnfuncionarioanterior_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnfuncionarioanterior.Click
        CManager.Position -= 1
        Call exibirdados()
    End Sub

    Private Sub btnfuncionarioanterior_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnfuncionarioanterior.MouseLeave
        btnfuncionarioanterior.Image = My.Resources.anteriorClaro
        btnfuncionarioanterior.Image = My.Resources.anterior
    End Sub

    Private Sub btnfuncionarioanterior_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles btnfuncionarioanterior.MouseMove
        btnfuncionarioanterior.Image = My.Resources.anterior
        btnfuncionarioanterior.Image = My.Resources.anteriorClaro
    End Sub

    Private Sub btnproximofuncionario_load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        btnproximofuncionario.Image = My.Resources.proximo
    End Sub

    Private Sub btnproximofuncionario_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnproximofuncionario.Click
        CManager.Position += 1
        Call exibirdados()
    End Sub

    Private Sub btnproximofuncionario_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnproximofuncionario.MouseLeave
        btnproximofuncionario.Image = My.Resources.proximoClaro
        btnproximofuncionario.Image = My.Resources.proximo
    End Sub

    Private Sub btnproximofuncionario_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles btnproximofuncionario.MouseMove
        btnproximofuncionario.Image = My.Resources.proximo
        btnproximofuncionario.Image = My.Resources.proximoClaro
    End Sub

    Private Sub btnultimofuncionario_load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        btnultimofuncionario.Image = My.Resources.ultimo
    End Sub

    Private Sub btnultimofuncionario_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnultimofuncionario.Click
        CManager.Position = CManager.Count - 1
        Call exibirdados()
    End Sub

    Private Sub btnultimofuncionario_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnultimofuncionario.MouseLeave
        btnultimofuncionario.Image = My.Resources.ultimoClaro
        btnultimofuncionario.Image = My.Resources.ultimo
    End Sub

    Private Sub btnultimofuncionario_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles btnultimofuncionario.MouseMove
        btnultimofuncionario.Image = My.Resources.ultimo
        btnultimofuncionario.Image = My.Resources.ultimoClaro
    End Sub
End Class