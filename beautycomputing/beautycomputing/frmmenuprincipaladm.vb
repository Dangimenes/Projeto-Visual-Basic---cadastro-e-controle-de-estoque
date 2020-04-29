Public Class frmmenuprincipaladm
    Private Sub frmenudeprincipaladm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Timer1.Start()

    End Sub
    Private Sub btncadastros_load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        btncadastros.Image = My.Resources.cadastro
    End Sub

    Private Sub btncadastros_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btncadastros.Click
        frmmenudecadastros.Show()
        groupboxmenu = groupboxmenuprincipal
        groupboxmenuprincipal.Visible = False


    End Sub

    Private Sub btncadastros_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles btncadastros.MouseLeave
        btncadastros.Image = My.Resources.cadastroclaro
        btncadastros.Image = My.Resources.cadastro
        lbltexto.Text = ""
        lbltitulo.Text = ""

    End Sub

    Private Sub btncadastros_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles btncadastros.MouseMove
        btncadastros.Image = My.Resources.cadastro
        btncadastros.Image = My.Resources.cadastroclaro
        lbltexto.Text = "Neste atalho Você pode Cadastrar alunos, clientes, funcionarios e serviços."
        lbltitulo.Text = "Cadastros"

    End Sub

    Private Sub brnprocurar_load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        brnprocurar.Image = My.Resources.procurar
    End Sub

    Private Sub brnprocurar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles brnprocurar.Click
        groupboxmenu.visible = False
        frmmenudepesquisas.Show()
    End Sub

    Private Sub brnprocurar_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles brnprocurar.MouseLeave
        brnprocurar.Image = My.Resources.procurarclaro
        brnprocurar.Image = My.Resources.procurar
        lbltexto.Text = ""
        lbltitulo.Text = ""


    End Sub

    Private Sub brnprocurar_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles brnprocurar.MouseMove
        brnprocurar.Image = My.Resources.procurar
        brnprocurar.Image = My.Resources.procurarclaro
        lbltexto.Text = "Neste atalho Você pode Pesquisar todos os alunos, clientes, funcionarios e serviços."
        lbltitulo.Text = "Pesquisas"

    End Sub

    Private Sub btnaddusuario_load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        btnaddusuario.Image = My.Resources.addusuario
    End Sub

    Private Sub btnaddusuario_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnaddusuario.MouseLeave
        btnaddusuario.Image = My.Resources.addusuarioclaro
        btnaddusuario.Image = My.Resources.addusuario
    End Sub

    Private Sub btnaddusuario_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles btnaddusuario.MouseMove
        btnaddusuario.Image = My.Resources.addusuario
        btnaddusuario.Image = My.Resources.addusuarioclaro
    End Sub

    Private Sub btnagenda_load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        btnagenda.Image = My.Resources.agenda
    End Sub

    Private Sub btnagenda_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnagenda.Click
        frmagendamentoconsultas.Show()
    End Sub

    Private Sub btnagenda_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnagenda.MouseLeave
        btnagenda.Image = My.Resources.agendaclaro
        btnagenda.Image = My.Resources.agenda
    End Sub

    Private Sub btnagenda_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles btnagenda.MouseMove
        btnagenda.Image = My.Resources.agenda
        btnagenda.Image = My.Resources.agendaclaro
    End Sub

    Private Sub btncursos_load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        btncursos.Image = My.Resources.cursos
    End Sub

    Private Sub btncursos_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles btncursos.MouseLeave
        btncursos.Image = My.Resources.cursosclaro
        btncursos.Image = My.Resources.cursos
    End Sub

    Private Sub btncursos_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles btncursos.MouseMove
        btncursos.Image = My.Resources.cursos
        btncursos.Image = My.Resources.cursosclaro
    End Sub

    Private Sub btnestoque_load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        btnestoque.Image = My.Resources.estoque
    End Sub

    Private Sub btnestoque_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnestoque.Click
        frmcontroleestoque.Show()
    End Sub

    Private Sub btnestoque_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnestoque.MouseLeave
        btnestoque.Image = My.Resources.estoqueclaro
        btnestoque.Image = My.Resources.estoque
    End Sub

    Private Sub btnestoque_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles btnestoque.MouseMove
        btnestoque.Image = My.Resources.estoque
        btnestoque.Image = My.Resources.estoqueclaro
    End Sub

    Private Sub btnvoltar_load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        btnvoltar.Image = My.Resources.voltar
    End Sub

    Private Sub btnvoltar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnvoltar.Click
        Me.Hide()
        formularioAtual = New frmlogin
        formularioAtual.Show()
    End Sub

    Private Sub btnvoltar_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnvoltar.MouseLeave
        btnvoltar.Image = My.Resources.voltarclaro
        btnvoltar.Image = My.Resources.voltar
    End Sub

    Private Sub btnvoltar_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles btnvoltar.MouseMove
        btnvoltar.Image = My.Resources.voltar
        btnvoltar.Image = My.Resources.voltarclaro
    End Sub

    Private Sub btnnackup_load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        btnnackup.Image = My.Resources.backup
    End Sub

    Private Sub btnnackup_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnnackup.MouseLeave
        btnnackup.Image = My.Resources.backupclaro
        btnnackup.Image = My.Resources.backup
    End Sub

    Private Sub btnnackup_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles btnnackup.MouseMove
        btnnackup.Image = My.Resources.backup
        btnnackup.Image = My.Resources.backupclaro
    End Sub

    Private Sub btnaddusuario_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnaddusuario.Click
        frmadicionar.Show()
    End Sub

    Private Sub btnrelatorios_load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        btnrelatorios.Image = My.Resources.relatorios
    End Sub

    Private Sub btnsair_load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        btnsair.Image = My.Resources.sair
    End Sub

    Private Sub btnsair_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnsair.Click
        If MessageBox.Show("Deseja Realmente Sair?", "Beauty Computing ®", MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.Yes Then
            End
        End If

    End Sub

    Private Sub btnsair_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnsair.MouseLeave
        btnsair.Image = My.Resources.sairClaro
        btnsair.Image = My.Resources.sair
    End Sub

    Private Sub btnsair_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles btnsair.MouseMove
        btnsair.Image = My.Resources.sair
        btnsair.Image = My.Resources.sairClaro
    End Sub

    Private Sub btnrelatorios_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnrelatorios.Click
        frmrelatorios.Show()
    End Sub

    Private Sub btnrelatorios_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnrelatorios.MouseLeave
        btnrelatorios.Image = My.Resources.relatoriosClaro
        btnrelatorios.Image = My.Resources.relatorios
    End Sub

    Private Sub btnrelatorios_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles btnrelatorios.MouseMove
        btnrelatorios.Image = My.Resources.relatorios
        btnrelatorios.Image = My.Resources.relatoriosClaro
    End Sub

    Private Sub ConsultasToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ConsultasToolStripMenuItem.Click
        frmagendamentoconsultas.Show()
    End Sub

    Private Sub LogoutToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LogoutToolStripMenuItem.Click
        formularioAtual = New frmlogin
        formularioAtual.Show()
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        lblhora.Text = TimeString
        lbldata.Text = DateString.ToString




    End Sub

    Private Sub ClientesToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ClientesToolStripMenuItem.Click
        frmclientes.Show()
    End Sub

    Private Sub FuncionariosToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FuncionariosToolStripMenuItem.Click
        frmfuncionarios.Show()
    End Sub

    Private Sub AlunosToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AlunosToolStripMenuItem.Click
        frmmatriculaalunos.Show()
    End Sub

    Private Sub ServicosToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ServicosToolStripMenuItem.Click
        frmservicos.Show()
    End Sub

    Private Sub ClientesToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ClientesToolStripMenuItem1.Click
        frmpesquisasClientes.Show()
    End Sub

    Private Sub FuncionariosToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FuncionariosToolStripMenuItem1.Click
        frmpesquisafuncionarios.Show()
    End Sub

    Private Sub AlunosToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AlunosToolStripMenuItem1.Click
        frmpesquisaalunos.Show()
    End Sub

    Private Sub ServicosToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ServicosToolStripMenuItem1.Click
        frmpesquisaservico.Show()
    End Sub

    Private Sub AdicionarUsuariosToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AdicionarUsuariosToolStripMenuItem.Click
        frmadicionar.Show()
    End Sub

    Private Sub ConsultasToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ConsultasToolStripMenuItem1.Click
        frmagenda.Show()
    End Sub

    Private Sub RelatoriosToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RelatoriosToolStripMenuItem.Click

    End Sub

    Private Sub ClientesToolStripMenuItem2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ClientesToolStripMenuItem2.Click
        frmrelatoriodeClientes.Show()
    End Sub

    Private Sub SairToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SairToolStripMenuItem1.Click
        If MessageBox.Show("Deseja Realmente Sair?", "Beauty Computing ®", MessageBoxButtons.YesNo) = MsgBoxResult.Yes Then
            End
        End If
    End Sub

    Private Sub ToolStripStatusLabel1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripStatusLabel1.Click

    End Sub

    Private Sub ToolStripStatusLabel3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripStatusLabel3.Click
        MessageBox.Show("Sistema de Gestão Versão 1.0.1", "Beauty Computing ®")

    End Sub

    Private Sub StatusStrip1_ItemClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ToolStripItemClickedEventArgs) Handles StatusStrip1.ItemClicked

    End Sub

End Class
