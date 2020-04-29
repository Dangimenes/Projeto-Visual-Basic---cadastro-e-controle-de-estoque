Public Class frmpesquisaalunos

    Private Sub frmpesquisaalunos_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        carregagrid()
    End Sub

    Private Sub radionome_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles radionome.CheckedChanged
        Call carregagrid()
        txtnome.Clear()
        Dataaluno.Refresh()
        txtnome.Visible = True
        txtrg.Visible = False
        txtnome.Clear()
        txtrg.Clear()
    End Sub

    Private Sub radiorg_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles radiorg.CheckedChanged
        Call carregagrid()
        txtnome.Clear()
        Dataaluno.Refresh()
        txtnome.Visible = False
        txtrg.Visible = True
        txtnome.Clear()
        txtrg.Clear()
    End Sub

    Private Sub carregagrid()
        Call conexaogeral()
        conexao.Open()
        da = New OleDb.OleDbDataAdapter("Select * from tblalunos;", conexao)
        DS = New DataSet
        da.Fill(DS, "tblalunos")
        Dataaluno.DataSource = DS.Tables(0)
        conexao.Close()
    End Sub

    Private Sub txtgeral_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtnome.TextChanged
        If radionome.Checked = True Then
            Call conexaogeral()
            conexao.Open()
            da = New OleDb.OleDbDataAdapter("select * from tblalunos where Nome like '" & txtnome.Text & "';", conexao)
            DS = New DataSet
            da.Fill(DS, "tblalunos")
            Dataaluno.DataSource = DS.Tables(0)
            conexao.Close()
            conexao = Nothing
        Else
            conexao.Dispose()
        End If
    End Sub

    Private Sub mostrartodos_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mostrartodos.Click
        Call carregagrid()
        Dataaluno.Refresh()
    End Sub

    Private Sub btnsair_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnsair.Click
        Me.Close()
    End Sub

    Private Sub txtrg_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtrg.TextChanged
        If radiorg.Checked = True Then
            Call conexaogeral()
            conexao.Open()
            da = New OleDb.OleDbDataAdapter("select * from tblalunos where RG_do_Aluno like '" & txtrg.Text & "';", conexao)
            DS = New DataSet
            da.Fill(DS, "tblalunos")
            Dataaluno.DataSource = DS.Tables(0)

            conexao.Close()
            conexao = Nothing
        Else
            conexao.Dispose()
        End If
    End Sub
End Class