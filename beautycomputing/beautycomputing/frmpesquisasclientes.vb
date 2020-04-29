Public Class frmpesquisasClientes

    Private Sub frmpesquisasClientes_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        carregagrid()
    End Sub

    Private Sub radionome_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles radionome.CheckedChanged
        Call carregagrid()
        txtrg.Clear()
        Datacliente.Refresh()
        txtgeral.Visible = True
        txtrg.Visible = False
    End Sub

    Private Sub radiorg_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles radiorg.CheckedChanged
        Call carregagrid()
        txtgeral.Clear()
        Datacliente.Refresh()
        txtgeral.Visible = False
        txtrg.Visible = True
    End Sub

    Private Sub carregagrid()
        Call conexaogeral()
        conexao.Open()
        da = New OleDb.OleDbDataAdapter("Select * from tblclientes;", conexao)
        DS = New DataSet
        da.Fill(DS, "tblclientes")
        Datacliente.DataSource = DS.Tables(0)
        conexao.Close()
    End Sub

    Private Sub txtnome_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtgeral.TextChanged
        If radionome.Checked = True Then
            Call conexaogeral()
            conexao.Open()
            da = New OleDb.OleDbDataAdapter("select * from tblclientes where Nome like '" & txtgeral.Text & "';", conexao)
            DS = New DataSet
            da.Fill(DS, "tblclientes")
            Datacliente.DataSource = DS.Tables(0)
            conexao.Close()
            conexao = Nothing
        Else
            conexao.Dispose()
        End If
    End Sub

    Private Sub mostrartodos_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mostrartodos.Click
        Call carregagrid()
        Datacliente.Refresh()
    End Sub

    Private Sub btnsair_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnsair.Click
        Me.Close()
    End Sub

   
    Private Sub txtrg_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtrg.TextChanged
        If radiorg.Checked = True Then
            Call conexaogeral()
            conexao.Open()
            da = New OleDb.OleDbDataAdapter("select * from tblclientes where RG_do_Cliente like '" & txtrg.Text & "';", conexao)
            DS = New DataSet
            da.Fill(DS, "tblclientes")
            Datacliente.DataSource = DS.Tables(0)
            conexao.Close()
            conexao = Nothing
        Else
            conexao.Dispose()
        End If
    End Sub
End Class