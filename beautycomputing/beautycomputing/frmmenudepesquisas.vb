Public Class frmmenudepesquisas
    Private Sub frmenudepesquisas_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        lbltipousuario.Text = lbltipousuarios
        If lbltipousuario.Text = "(Usuario Comum)" Then
            btnfuncionarios.Visible = False
            lblfuncionario.Visible = False

        End If
    End Sub
    Private Sub PictureBox1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        frmpesquisasClientes.Show()
    End Sub

    Private Sub PictureBox2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        frmpesquisaalunos.Show()
    End Sub

    Private Sub PictureBox7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        frmpesquisafuncionarios.Show()
    End Sub

    Private Sub PictureBox5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Close()
    End Sub

    Private Sub btnclientes_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnclientes.Click
        frmpesquisasClientes.Show()
    End Sub

    Private Sub btnclientes_load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        btnclientes.Image = My.Resources.cientes
    End Sub

    Private Sub btnclientes_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnclientes.MouseLeave
        btnclientes.Image = My.Resources.cientesClaro
        btnclientes.Image = My.Resources.cientes
    End Sub

    Private Sub btnclientes_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles btnclientes.MouseMove
        btnclientes.Image = My.Resources.cientes
        btnclientes.Image = My.Resources.cientesClaro
    End Sub

    Private Sub btnalunos_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnalunos.Click
        frmpesquisaalunos.Show()
    End Sub

    Private Sub btnalunnos_load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        btnalunos.Image = My.Resources.aluno
    End Sub

    Private Sub btnalunnos_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnalunos.MouseLeave
        btnalunos.Image = My.Resources.alunoClaro
        btnalunos.Image = My.Resources.aluno
    End Sub

    Private Sub btnalunnos_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles btnalunos.MouseMove
        btnalunos.Image = My.Resources.aluno
        btnalunos.Image = My.Resources.alunoClaro
    End Sub

    Private Sub btnfuncionarios_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnfuncionarios.Click
        frmpesquisafuncionarios.Show()
    End Sub

    Private Sub btnfuncionarios_load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        btnfuncionarios.Image = My.Resources.funcionarios
    End Sub

    Private Sub btnfuncionarios_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnfuncionarios.MouseLeave
        btnfuncionarios.Image = My.Resources.funcionariosClaro
        btnfuncionarios.Image = My.Resources.funcionarios
    End Sub

    Private Sub btncadastrofunc_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles btnfuncionarios.MouseMove
        btnfuncionarios.Image = My.Resources.funcionarios
        btnfuncionarios.Image = My.Resources.funcionariosClaro
    End Sub

    Private Sub btnservicos_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnservicos.Click
        frmpesquisaservico.Show()
    End Sub

    Private Sub btnservicos_load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        btnservicos.Image = My.Resources.servicos
    End Sub
    Private Sub btnservicos_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnservicos.MouseLeave
        btnservicos.Image = My.Resources.servicosClaro
        btnservicos.Image = My.Resources.servicos
    End Sub

    Private Sub btnservicos_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles btnservicos.MouseMove
        btnservicos.Image = My.Resources.servicos
        btnservicos.Image = My.Resources.servicosClaro
    End Sub

    Private Sub btnvoltaraomenu_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnvoltaraomenu.Click
        groupboxmenu.visible = True
        Me.Close()
    End Sub
    Private Sub btnvoltaraomenu_load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        btnvoltaraomenu.Image = My.Resources.menu
    End Sub
    Private Sub btnvoltaraomenu_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnvoltaraomenu.MouseLeave
        btnvoltaraomenu.Image = My.Resources.menuClaro
        btnvoltaraomenu.Image = My.Resources.menu
    End Sub

    Private Sub btnvoltaraomenu_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles btnvoltaraomenu.MouseMove
        btnvoltaraomenu.Image = My.Resources.menu
        btnvoltaraomenu.Image = My.Resources.menuClaro
    End Sub
End Class