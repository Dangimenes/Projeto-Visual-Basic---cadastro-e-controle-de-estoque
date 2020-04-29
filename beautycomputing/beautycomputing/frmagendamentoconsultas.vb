Public Class frmagendamentoconsultas

    Private Sub frmagendamentoconsultas_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        datagridagenda.Refresh()

        Call textdesativado()
        Call carregagridagenda()
        datagridagenda.Refresh()

        txttempototal.ReadOnly = True
        txtvalortotal.ReadOnly = True

        

        lbldatagrid.Text = "Tabela de Consultas Agendadas:"
        datagridclientes.Visible = False
        datagridservicos.Visible = False
        datagridagenda.Visible = True
    End Sub

    Private Sub textdesativado()
        txtdata.Enabled = False
        txthora.ReadOnly = True
        txtrgcliente.ReadOnly = True
        txtnomecliente.ReadOnly = True
        txttelcliente.ReadOnly = True
        txtservico1.ReadOnly = True
        txtservico2.ReadOnly = True
        txtservico3.ReadOnly = True
        txtservico4.ReadOnly = True
        txttipo1.Enabled = False
        txttipo2.Enabled = False
        txttipo3.Enabled = False
        txttipo4.Enabled = False
        txttempo1.ReadOnly = True
        txttempo2.ReadOnly = True
        txttempo3.ReadOnly = True
        txttempo4.ReadOnly = True
        txtvalor1.ReadOnly = True
        txtvalor2.ReadOnly = True
        txtvalor3.ReadOnly = True
        txtvalor4.ReadOnly = True
        txtnome1.ReadOnly = True
        txtnome2.ReadOnly = True
        txtnome3.ReadOnly = True
        txtnome4.ReadOnly = True
        datagridclientes.Visible = False
        datagridservicos.Visible = False
        datagridagenda.Visible = True
        lbldatagrid.Text = "Tabela de Consultas Agendadas:"
    End Sub

    Private Sub textativado()
        txtdata.Enabled = True
        txthora.ReadOnly = False
        txtrgcliente.ReadOnly = False
        txtnomecliente.ReadOnly = False
        txttelcliente.ReadOnly = False
        txtservico1.ReadOnly = False
        txtservico2.ReadOnly = False
        txtservico3.ReadOnly = False
        txtservico4.ReadOnly = False
        txttipo1.Enabled = True
        txttipo2.Enabled = True
        txttipo3.Enabled = True
        txttipo4.Enabled = True
        txttempo1.ReadOnly = False
        txttempo2.ReadOnly = False
        txttempo3.ReadOnly = False
        txttempo4.ReadOnly = False
        txtvalor1.ReadOnly = False
        txtvalor2.ReadOnly = False
        txtvalor3.ReadOnly = False
        txtvalor4.ReadOnly = False
        txtnome1.ReadOnly = False
        txtnome2.ReadOnly = False
        txtnome3.ReadOnly = False
        txtnome4.ReadOnly = False
        datagridclientes.Visible = False
        datagridservicos.Visible = False
        datagridagenda.Visible = True
    End Sub

    Private Sub btnnovaconsulta_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnnovaconsulta.Click
        Call limpatextbox()
        Call textativado()
    End Sub

    Private Sub limpatextbox()
        txtdata.ResetText()
        txthora.Clear()
        txtrgcliente.Clear()
        txtnomecliente.Clear()
        txttelcliente.Clear()
        txtservico1.clear()
        txtservico2.Clear()
        txtservico3.clear()
        txtservico4.clear()
        txttipo1.ResetText()
        txttipo2.ResetText()
        txttipo3.ResetText()
        txttipo4.ResetText()
        txttempo1.Clear()
        txttempo2.Clear()
        txttempo3.Clear()
        txttempo4.Clear()
        txtvalor1.Clear()
        txtvalor2.Clear()
        txtvalor3.Clear()
        txtvalor4.Clear()
        txtnome1.Clear()
        txtnome2.Clear()
        txtnome3.Clear()
        txtnome4.Clear()
        datagridclientes.Visible = False
        datagridservicos.Visible = False
        datagridagenda.Visible = True
    End Sub

    Private Sub btnsalvar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnsalvar.Click
        Call conexaogeral()
        conexao.Open()
        Try
            cmd = New OleDb.OleDbCommand
            cmd.CommandText = "INSERT INTO tblagenda(Data_da_Consulta,Hora_da_Consulta,RG_do_Cliente,Nome_do_Cliente,Telefone_do_Cliente,Serviço_1,Nome_1,Tipo_1,Valor_1,Tempo_1,Serviço_2,Nome_2,Tipo_2,Valor_2,Tempo_2,Serviço_3,Nome_3,Tipo_3,Valor_3,Tempo_3,Serviço_4,Nome_4,Tipo_4,Valor_4,Tempo_4,Tempo_Total_da_Consulta,Valor_Total) VALUES(@data,@horaage,@rgcliage,@nomecliage,@telcliage,@servico1age,@nome1,@tipo1age,@valor1age,@tempo1age,@servico2age,@nome2,@tipo2age,@valor2age,@tempo2age,@servico3age,@nome3,@tipo3age,@valor3age,@tempo3age,@servico4age,@nome4,@tipo4age,@valor4age,@tempo4age,@tempototalage,@valortotalage)"
            cmd.Parameters.AddWithValue("@data", txtdata.Text)
            cmd.Parameters.AddWithValue("@horaage", txthora.Text)
            cmd.Parameters.AddWithValue("@rgcliage", txtrgcliente.Text)
            cmd.Parameters.AddWithValue("@nomecliage", txtnomecliente.Text)
            cmd.Parameters.AddWithValue("@telcliage", txttelcliente.Text)
            cmd.Parameters.AddWithValue("@servico1age", txtservico1.Text)
            cmd.Parameters.AddWithValue("@nome1", txtnome1.Text)
            cmd.Parameters.AddWithValue("@tipo1age", txttipo1.Text)
            cmd.Parameters.AddWithValue("@valor1age", txtvalor1.Text)
            cmd.Parameters.AddWithValue("@tempo1age", txttempo1.Text)
            cmd.Parameters.AddWithValue("@servico2age", txtservico2.Text)
            cmd.Parameters.AddWithValue("@nome2", txtnome2.Text)
            cmd.Parameters.AddWithValue("@tipo2age", txttipo2.Text)
            cmd.Parameters.AddWithValue("@valor2age", txtvalor2.Text)
            cmd.Parameters.AddWithValue("@tempo2age", txttempo2.Text)
            cmd.Parameters.AddWithValue("@servico3age", txtservico3.Text)
            cmd.Parameters.AddWithValue("@nome3", txtnome3.Text)
            cmd.Parameters.AddWithValue("@tipo3age", txttipo3.Text)
            cmd.Parameters.AddWithValue("@valor3age", txtvalor3.Text)
            cmd.Parameters.AddWithValue("@tempo3age", txttempo3.Text)
            cmd.Parameters.AddWithValue("@servico4age", txtservico4.Text)
            cmd.Parameters.AddWithValue("@nome4", txtnome4.Text)
            cmd.Parameters.AddWithValue("@tipo4age", txttipo4.Text)
            cmd.Parameters.AddWithValue("@valor4age", txtvalor4.Text)
            cmd.Parameters.AddWithValue("@tempo4age", txttempo4.Text)
            cmd.Parameters.AddWithValue("@tempototalage", txttempototal.Text)
            cmd.Parameters.AddWithValue("@valortotalage", txtvalortotal.Text)
            SalvarDados()
            conexao.Close()
        Catch ex As Exception
            MessageBox.Show(ex.ToString, "Erro na Inclusão", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

        Call textdesativado()
        Call carregagridagenda()
        datagridagenda.Refresh()
    End Sub

    Private Sub btncancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btncancelar.Click
        Call limpatextbox()
        Call textdesativado()
        datagridagenda.Refresh()
        Call carregagridagenda()
        flag = 0
    End Sub

    Private Sub carregagridagenda()
        Call conexaogeral()
        conexao.Open()
        da = New OleDb.OleDbDataAdapter("Select * from tblagenda;", conexao)
        DS = New DataSet
        da.Fill(DS, "tblagenda")
        datagridagenda.DataSource = DS.Tables(0)
        conexao.Close()
    End Sub

    Private Sub carregagridcliente()
        Call conexaogeral()
        conexao.Open()
        da = New OleDb.OleDbDataAdapter("Select * from tblclientes;", conexao)
        DS = New DataSet
        da.Fill(DS, "tblclientes")
        datagridclientes.DataSource = DS.Tables(0)
        conexao.Close()
    End Sub

    Private Sub carregagridservico()
        Call conexaogeral()
        conexao.Open()
        da = New OleDb.OleDbDataAdapter("Select * from tblservicos;", conexao)
        DS = New DataSet
        da.Fill(DS, "tblservicos")
        datagridservicos.DataSource = DS.Tables(0)
        conexao.Close()
    End Sub

    Private Sub btnconsultas_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnconsultas.Click
        frmagenda.Show()
    End Sub

    Private Sub btnprimeiro_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs)
        CManager.Position = 0
    End Sub

    Private Sub btnanterior_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        CManager.Position -= 1
    End Sub

    Private Sub btnproximo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        CManager.Position += 1
    End Sub

    Private Sub btnultimo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        CManager.Position = CManager.Count - 1
    End Sub


    Private Sub txtrgcliente_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtrgcliente.TextChanged
        Call carregagridcliente()
        Call conexaogeral()
        conexao.Open()
        da = New OleDb.OleDbDataAdapter("select * from tblclientes where RG_do_Cliente like '" & txtrgcliente.Text & "';", conexao)
        DS = New DataSet
        da.Fill(DS, "tblclientes")
        datagridclientes.DataSource = DS.Tables(0)
        For I As Integer = 0 To DS.Tables(0).Rows.Count - 1
            txtnomecliente.Text = DS.Tables(0).Rows(I)("Nome").ToString
            txttelcliente.Text = DS.Tables(0).Rows(I)("Telefone").ToString
        Next
        conexao.Close()
        conexao = Nothing

        datagridclientes.Visible = True
        datagridservicos.Visible = False
        datagridagenda.Visible = False
        lbldatagrid.Text = "Tabela de de clientes cadastrados:"

    End Sub

    Private Sub txtservico1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtservico1.TextChanged

        Call carregagridservico()
        Call conexaogeral()
        conexao.Open()
        da = New OleDb.OleDbDataAdapter("select * from tblservicos where Código_do_Serviço like '" & txtservico1.Text & "';", conexao)
        DS = New DataSet
        da.Fill(DS, "tblservicos")
        datagridservicos.DataSource = DS.Tables(0)
        For I As Integer = 0 To DS.Tables(0).Rows.Count - 1
            txtnome1.Text = DS.Tables(0).Rows(I)("Serviço").ToString
            txttipo1.Text = DS.Tables(0).Rows(I)("Tipo").ToString
            txttempo1.Text = DS.Tables(0).Rows(I)("Tempo_Estimado").ToString
            txtvalor1.Text = DS.Tables(0).Rows(I)("Valor").ToString
        Next
        conexao.Close()
        conexao = Nothing

        datagridclientes.Visible = False
        datagridservicos.Visible = True
        datagridagenda.Visible = False
        lbldatagrid.Text = "Tabela de de serviços cadastrados:"
    End Sub

    Private Sub txtservico2_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtservico2.TextChanged
        Call carregagridservico()
        Call conexaogeral()
        conexao.Open()
        da = New OleDb.OleDbDataAdapter("select * from tblservicos where Código_do_Serviço like '" & txtservico1.Text & "';", conexao)
        DS = New DataSet
        da.Fill(DS, "tblservicos")
        datagridservicos.DataSource = DS.Tables(0)
        For I As Integer = 0 To DS.Tables(0).Rows.Count - 1
            txtnome2.Text = DS.Tables(0).Rows(I)("Serviço").ToString
            txttipo2.Text = DS.Tables(0).Rows(I)("Tipo").ToString
            txttempo2.Text = DS.Tables(0).Rows(I)("Tempo_Estimado").ToString
            txtvalor2.Text = DS.Tables(0).Rows(I)("Valor").ToString
        Next
        conexao.Close()
        conexao = Nothing

        datagridclientes.Visible = False
        datagridservicos.Visible = True
        datagridagenda.Visible = False
        lbldatagrid.Text = "Tabela de de serviços cadastrados:"
    End Sub

    Private Sub txtservico3_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtservico3.TextChanged
        Call carregagridservico()
        Call conexaogeral()
        conexao.Open()
        da = New OleDb.OleDbDataAdapter("select * from tblservicos where Código_do_Serviço like '" & txtservico1.Text & "';", conexao)
        DS = New DataSet
        da.Fill(DS, "tblservicos")
        datagridservicos.DataSource = DS.Tables(0)
        For I As Integer = 0 To DS.Tables(0).Rows.Count - 1
            txtnome3.Text = DS.Tables(0).Rows(I)("Serviço").ToString
            txttipo3.Text = DS.Tables(0).Rows(I)("Tipo").ToString
            txttempo3.Text = DS.Tables(0).Rows(I)("Tempo_Estimado").ToString
            txttipo3.Text = DS.Tables(0).Rows(I)("Valor").ToString
        Next
        conexao.Close()
        conexao = Nothing

        datagridclientes.Visible = False
        datagridservicos.Visible = True
        datagridagenda.Visible = False
        lbldatagrid.Text = "Tabela de de serviços cadastrados:"
    End Sub

    Private Sub txtservico4_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtservico4.TextChanged
        Call carregagridservico()
        Call conexaogeral()
        conexao.Open()
        da = New OleDb.OleDbDataAdapter("select * from tblservicos where Código_do_Serviço like '" & txtservico1.Text & "';", conexao)
        DS = New DataSet
        da.Fill(DS, "tblservicos")
        datagridservicos.DataSource = DS.Tables(0)
        For I As Integer = 0 To DS.Tables(0).Rows.Count - 1
            txtnome4.Text = DS.Tables(0).Rows(I)("Serviço").ToString
            txttipo4.Text = DS.Tables(0).Rows(I)("Tipo").ToString
            txttempo4.Text = DS.Tables(0).Rows(I)("Tempo_Estimado").ToString
            txtvalor4.Text = DS.Tables(0).Rows(I)("Valor").ToString
        Next
        conexao.Close()
        conexao = Nothing

        datagridclientes.Visible = False
        datagridservicos.Visible = True
        datagridagenda.Visible = False
        lbldatagrid.Text = "Tabela de de serviços cadastrados:"
    End Sub
End Class