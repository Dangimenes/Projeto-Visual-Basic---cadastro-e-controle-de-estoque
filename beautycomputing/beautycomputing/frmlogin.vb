Public Class frmlogin
    Dim tentarivas As Integer
    Dim aprovacao As Integer

    Private Sub frmlogin_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        cbotipo.Items.Add("Admin")
        cbotipo.Items.Add("Usuario")
    End Sub

    Private Sub OK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK.Click
        'se o textbox1 esta em branco...
        If txtlogin.Text.Trim = "" Then
            MessageBox.Show("Informe a seu Login !", "Login", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtlogin.Focus()
        Else
            'se o textbox2 esta em branco...
            If txtsenha.Text.Trim = "" Then
                MessageBox.Show("Informe a sua senha !", "Senha", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                txtsenha.Focus()
            Else
                'se a combobox esta em branco
                If cbotipo.Text.Trim = "" Or cbotipo.Text = "Escolha um Tipo de Login" Then
                    MessageBox.Show("Selecione o modo de Login : Admin ou usuário !", "Login", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    cbotipo.Focus()
                End If
            End If
        End If
        'logando como Admin
        If cbotipo.Text = "Admin" Then
            Call conexaogeral()
            'Abre conexao com banco de dados
            conexao.Open()
            da = New OleDb.OleDbDataAdapter("Select Usuário, Senha FROM admin ;", conexao)
            ' Le a informação do banco de dados
            DS = New DataSet
            da.Fill(DS, "admin")
            verificaLogin()
            ' fecha a conexao com o banco de dados
            conexao.Close()
            conexao = Nothing
        End If
        'logando como usuario
        If cbotipo.Text = "Usuario" Then
            Call conexaogeral()
            'Abre conexao com banco de dados
            conexao.Open()
            da = New OleDb.OleDbDataAdapter("Select Usuário, Senha FROM usuario ;", conexao)
            ' Le a informação do banco de dados
            DS = New DataSet
            da.Fill(DS, "usuario")
            verificaLogin()
            ' fecha a conexao com o banco de dados
            conexao.Close()
            conexao = Nothing
        End If
    End Sub

    Private Sub verificaLogin()
        For I As Integer = 0 To DS.Tables(0).Rows.Count - 1
            If ((txtlogin.Text = DS.Tables(0).Rows(I)("Usuário").ToString) And (txtsenha.Text = DS.Tables(0).Rows(I)("Senha").ToString)) Then
                MessageBox.Show("Acesso permitido ! Bem Vindo """ & " " & txtlogin.Text & """", "Login", MessageBoxButtons.OK, MessageBoxIcon.Information)
                aprovacao = 0
                I = DS.Tables(0).Rows.Count - 1
                If cbotipo.Text = ("Admin") Then
                    Me.Hide()
                    frmmenuprincipaladm.Show()
                    formularioAtual = New frmmenuprincipaladm()
                    lbltipousuarios = "(Administrador)"

                ElseIf cbotipo.Text = ("Usuario") Then
                    Me.Hide()
                    frmmenuprincipalusuario.Show()
                    formularioAtual = New frmmenuprincipalusuario()
                    lbltipousuarios = "(Usuario Comum)"
                End If
            Else
                aprovacao = 1
            End If
        Next
        If aprovacao = 1 Then
            MessageBox.Show("Login ou Senha Incorretos")
            txtlogin.Focus()
        End If
    End Sub

    Private Sub Cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel.Click
        If MsgBox("Deseja realmente Sair?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
            End
        End If
    End Sub
End Class