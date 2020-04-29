Public Class frmagenda

    Private Sub MonthCalendar1_DateChanged(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DateRangeEventArgs) Handles MonthCalendar1.DateChanged
        txtpesquisaagenda.Text = Me.MonthCalendar1.SelectionStart.ToShortDateString
    End Sub

    Private Sub txtpesquisaagenda_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtpesquisaagenda.TextChanged
        Call conexaogeral()
        conexao.Open()
        da = New OleDb.OleDbDataAdapter("select Data_da_Consulta,Hora_da_Consulta,Nome_do_Cliente,Telefone_do_Cliente,Serviço_1,Tipo_1,Serviço_2,Tipo_2,Serviço_3,Tipo_3,Serviço_4,Tipo_4 from tblagenda where Data_da_Consulta like '" & txtpesquisaagenda.Text & "';", conexao)
        DS = New DataSet
        da.Fill(DS, "tblagenda")
        DataGridView1.DataSource = DS.Tables(0)
        conexao.Close()
        conexao = Nothing
    End Sub

    Private Sub btntodasconsultas_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btntodasconsultas.Click
        Call conexaogeral()
        conexao.Open()
        da = New OleDb.OleDbDataAdapter("select Data_da_Consulta,Hora_da_Consulta,Nome_do_Cliente,Telefone_do_Cliente,Serviço_1,Tipo_1,Serviço_2,Tipo_2,Serviço_3,Tipo_3,Serviço_4,Tipo_4 from tblagenda ", conexao)
        DS = New DataSet
        da.Fill(DS, "tblagenda")
        DataGridView1.DataSource = DS.Tables(0)
        conexao.Close()
        conexao = Nothing
    End Sub

 
End Class