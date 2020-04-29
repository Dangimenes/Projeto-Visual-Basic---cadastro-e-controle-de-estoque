Public Class frmmenudecadastros
    Private Sub frmenudecadastros_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        lbltipousuario.Text = lbltipousuarios
        If lbltipousuario.Text = "(Usuario Comum)" Then
            btncadastrofunc.Visible = False
            lblfuncionarios.Visible = False


        End If
    End Sub
 
    Private Sub btnvoltaraomenu_load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        btnvoltaraomenu.Image = My.Resources.menu
    End Sub

    Private Sub btnvoltaraomenu_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnvoltaraomenu.Click
        groupboxmenu.visible = True
        Me.Close()


    End Sub

    Private Sub btnvoltaraomenu_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnvoltaraomenu.MouseLeave
        btnvoltaraomenu.Image = My.Resources.menuClaro
        btnvoltaraomenu.Image = My.Resources.menu
    End Sub

    Private Sub btnvoltaraomenu_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles btnvoltaraomenu.MouseMove
        btnvoltaraomenu.Image = My.Resources.menu
        btnvoltaraomenu.Image = My.Resources.menuClaro
    End Sub

    Private Sub btncadastroclientes_load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        btncadastroclientes.Image = My.Resources.cientes
    End Sub

    Private Sub btncadastroclientes_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btncadastroclientes.Click
        frmclientes.Show()
    End Sub

    Private Sub btncadastroclientes_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles btncadastroclientes.MouseLeave
        btncadastroclientes.Image = My.Resources.cientesClaro
        btncadastroclientes.Image = My.Resources.cientes
    End Sub

    Private Sub btncadastroclientes_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles btncadastroclientes.MouseMove
        btncadastroclientes.Image = My.Resources.cientes
        btncadastroclientes.Image = My.Resources.cientesClaro
    End Sub

    Private Sub btncadastrofunc_load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        btncadastrofunc.Image = My.Resources.funcionarios
    End Sub

    Private Sub btncadastrofunc_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btncadastrofunc.Click
        frmfuncionarios.Show()
    End Sub

    Private Sub btncadastrofunc_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles btncadastrofunc.MouseLeave
        btncadastrofunc.Image = My.Resources.funcionariosClaro
        btncadastrofunc.Image = My.Resources.funcionarios
    End Sub

    Private Sub btncadastrofunc_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles btncadastrofunc.MouseMove
        btncadastrofunc.Image = My.Resources.funcionarios
        btncadastrofunc.Image = My.Resources.funcionariosClaro
    End Sub

    Private Sub btncadastroalunnos_load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        btncadastroalunnos.Image = My.Resources.aluno
    End Sub

    Private Sub btncadastroalunnos_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btncadastroalunnos.Click
        frmmatriculaalunos.Show()
    End Sub

    Private Sub btncadastroalunnos_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles btncadastroalunnos.MouseLeave
        btncadastroalunnos.Image = My.Resources.alunoClaro
        btncadastroalunnos.Image = My.Resources.aluno
    End Sub

    Private Sub btncadastroalunnos_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles btncadastroalunnos.MouseMove
        btncadastroalunnos.Image = My.Resources.aluno
        btncadastroalunnos.Image = My.Resources.alunoClaro
    End Sub

    Private Sub btncadastrodeservicos_load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        btncadastrodeservicos.Image = My.Resources.servicos
    End Sub

    Private Sub btncadastrodeservicos_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btncadastrodeservicos.Click
        frmservicos.Show()
    End Sub

    Private Sub btncadastrodeservicos_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles btncadastrodeservicos.MouseLeave
        btncadastrodeservicos.Image = My.Resources.servicosClaro
        btncadastrodeservicos.Image = My.Resources.servicos
    End Sub

    Private Sub btncadastrodeservicos_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles btncadastrodeservicos.MouseMove
        btncadastrodeservicos.Image = My.Resources.servicos
        btncadastrodeservicos.Image = My.Resources.servicosClaro
    End Sub
End Class