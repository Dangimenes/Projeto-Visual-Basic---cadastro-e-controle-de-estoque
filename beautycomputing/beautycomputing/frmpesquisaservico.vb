Public Class frmpesquisaservico

    Private Sub frmpesquisaservico_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        carregagrid()
    End Sub

    Private Sub radionome_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles radioservico.CheckedChanged
        Call carregagrid()
        txtnome.Clear()
        Dataservico.Refresh()
        txtcodservico.Visible = False
        txtnome.Visible = True
    End Sub

    Private Sub radiorg_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles radiocodigo.CheckedChanged
        Call carregagrid()
        txtnome.Clear()
        Dataservico.Refresh()
        txtcodservico.Visible = True
        txtnome.Visible = False
    End Sub

    Private Sub carregagrid()
        Call conexaogeral()
        conexao.Open()
        da = New OleDb.OleDbDataAdapter("Select * from tblservicos;", conexao)
        DS = New DataSet
        da.Fill(DS, "tblservicos")
        Dataservico.DataSource = DS.Tables(0)
        conexao.Close()
    End Sub

    Private Sub txtgeral_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtnome.TextChanged
        If radioservico.Checked = True Then
            Call conexaogeral()
            conexao.Open()
            da = New OleDb.OleDbDataAdapter("select * from tblservicos where Serviço like '" & txtnome.Text & "';", conexao)
            DS = New DataSet
            da.Fill(DS, "tblservicos")
            Dataservico.DataSource = DS.Tables(0)
            conexao.Close()
            conexao = Nothing
        Else
            conexao.Dispose()
        End If
    End Sub

    Private Sub mostrartodos_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mostrartodos.Click
        Call carregagrid()
        Dataservico.Refresh()
    End Sub

    Private Sub btnsair_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnsair.Click
        Me.Close()
    End Sub

    Private Sub txtcodservico_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtcodservico.TextChanged
        If radiocodigo.Checked = True Then
            Call conexaogeral()
            conexao.Open()
            da = New OleDb.OleDbDataAdapter("select * from tblservicos where Código_do_Serviço like '" & txtcodservico.Text & "';", conexao)
            DS = New DataSet
            da.Fill(DS, "tblservicos")
            Dataservico.DataSource = DS.Tables(0)
            conexao.Close()
            conexao = Nothing
        Else
            conexao.Dispose()
        End If
    End Sub
End Class