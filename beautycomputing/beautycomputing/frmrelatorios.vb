Public Class frmrelatorios
    Private Sub frrelatorios_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        lbltipousuario.Text = lbltipousuarios
        If lbltipousuario.Text = "(Usuario Comum)" Then
            btnrelatoriosdefuncionarios.Visible = False
            lbltitulo.Text = ""
            lbltexto.Text = ""
            picrelatorios.Visible = False

            lblfuncionarios.Visible = False


        End If
    End Sub
    Private Sub btnrelatoriosdeclientes_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnrelatoriosdeclientes.Click
        frmrelatoriodeClientes.Show()
    End Sub
    Private Sub btnrelatoriosdeclientes_load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        btnrelatoriosdeclientes.Image = My.Resources.cientes
    End Sub

    Private Sub btnrelatoriosdefuncionarios_load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        btnrelatoriosdefuncionarios.Image = My.Resources.funcionarios
    End Sub

    Private Sub btnrelatoriosdealunos_load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        btnrelatoriosdealunos.Image = My.Resources.aluno
    End Sub

    Private Sub btnvoltaraomenu_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnvoltaraomenu.Click
        Me.Close()
    End Sub

    Private Sub btnvoltaraomenu_load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        btnvoltaraomenu.Image = My.Resources.menu
    End Sub

    Private Sub btnrelatoriosdeservicos_load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        btnrelatoriosdeservicos.Image = My.Resources.servicos
    End Sub

    Private Sub btnrelatoriosdeclientes_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnrelatoriosdeclientes.MouseLeave
        btnrelatoriosdeclientes.Image = My.Resources.cientesClaro
        btnrelatoriosdeclientes.Image = My.Resources.cientes
        lbltitulo.Text = ""
        lbltexto.Text = ""
        picrelatorios.Visible = False


    End Sub

    Private Sub btnrelatoriosdeclientes_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles btnrelatoriosdeclientes.MouseMove
        btnrelatoriosdeclientes.Image = My.Resources.cientes
        btnrelatoriosdeclientes.Image = My.Resources.cientesClaro
        lbltitulo.Text = "Relatório de Clientes"
        lbltexto.Text = "Imprima Aqui Relatórios de Clientes"
        picrelatorios.Visible = True
        picrelatorios.Image = My.Resources.relatoriosdeclientes


    End Sub

    Private Sub btnrelatoriosdealunos_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnrelatoriosdealunos.MouseLeave
        btnrelatoriosdealunos.Image = My.Resources.alunoClaro
        btnrelatoriosdealunos.Image = My.Resources.aluno
        lbltitulo.Text = ""
        lbltexto.Text = ""
        picrelatorios.Visible = False

    End Sub

    Private Sub btnrelatoriosdealunos_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles btnrelatoriosdealunos.MouseMove
        btnrelatoriosdealunos.Image = My.Resources.aluno
        btnrelatoriosdealunos.Image = My.Resources.alunoClaro
        lbltitulo.Text = "Relatórios de Alunos"
        lbltexto.Text = "Imprima Aqui Relatórios de Alunos"
        picrelatorios.Visible = True
        picrelatorios.Image = My.Resources.relatoriosdealunos


    End Sub

    Private Sub btnrelatoriosdefuncionarios_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnrelatoriosdefuncionarios.MouseLeave
        btnrelatoriosdefuncionarios.Image = My.Resources.funcionariosClaro
        btnrelatoriosdefuncionarios.Image = My.Resources.funcionarios
        lbltitulo.Text = ""
        lbltexto.Text = ""
    End Sub

    Private Sub btnrelatoriosdefuncionarios_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles btnrelatoriosdefuncionarios.MouseMove
        btnrelatoriosdefuncionarios.Image = My.Resources.funcionarios
        btnrelatoriosdefuncionarios.Image = My.Resources.funcionariosClaro
        lbltitulo.Text = "Relatórios de Funcionarios"
        lbltexto.Text = "Imprima Aqui Relatórios de Funcionarios"
    End Sub

    Private Sub btnrelatoriosdeservicos_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnrelatoriosdeservicos.MouseLeave
        btnrelatoriosdeservicos.Image = My.Resources.servicosClaro
        btnrelatoriosdeservicos.Image = My.Resources.servicos
        lbltitulo.Text = ""
        lbltexto.Text = ""
    End Sub

    Private Sub btnrelatoriosdeservicos_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles btnrelatoriosdeservicos.MouseMove
        btnrelatoriosdeservicos.Image = My.Resources.servicos
        btnrelatoriosdeservicos.Image = My.Resources.servicosClaro
        lbltitulo.Text = "Relatórios de Servicos"
        lbltexto.Text = "Imprima Aqui Relatórios de Servicos"

    End Sub

    Private Sub btnvoltaraomenu_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnvoltaraomenu.MouseLeave
        btnvoltaraomenu.Image = My.Resources.menuClaro
        btnvoltaraomenu.Image = My.Resources.menu
    End Sub

    Private Sub btnvoltaraomenu_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles btnvoltaraomenu.MouseMove
        btnvoltaraomenu.Image = My.Resources.menu
        btnvoltaraomenu.Image = My.Resources.menuClaro
    End Sub

    Private Sub btnrelatoriosdealunos_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnrelatoriosdealunos.Click
        frmrelatorioalunos.Show()

    End Sub

    Private Sub btnrelatoriosdefuncionarios_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnrelatoriosdefuncionarios.Click
        frmrelatoriofuncionarios.Show()

    End Sub

    Private Sub btnrelatoriosdeservicos_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnrelatoriosdeservicos.Click

    End Sub

    Private Sub lbltexto_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lbltexto.Click

    End Sub
End Class