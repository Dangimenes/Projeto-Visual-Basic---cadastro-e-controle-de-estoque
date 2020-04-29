Public Class login
    'define as variaveis
    Dim comando As New OleDb.OleDbCommand
    Dim conexao As New OleDb.OleDbConnection
    Dim ler As OleDb.OleDbDataReader
    Dim banco As OleDb.OleDbDataAdapter
    Dim DS As DataSet
    Dim tentarivas As Integer
    Dim aprovacao As Integer

    Private Sub Cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnsair.Click
        If MsgBox("Deseja Realmente Sair?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
            End
        End If
    End Sub

    Private Sub btnok_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnok.Click
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

            'conexao joel
            'conexao = New OleDb.OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\Joel\Desktop\TCC- oficial\Estetica-oficial.mdb")

            'conexao casa
            conexao = New OleDb.OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\Edu\Desktop\TCC- oficial\Estetica-oficial.mdb")

            'conexão etec
            'conexao = New OleDb.OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=D:\TCC- oficial\Estetica-oficial.mdb")

            conexao.Open()

            banco = New OleDb.OleDbDataAdapter("Select usuario, senha FROM admin ;", conexao)

            ' Le a informação do banco de dados
            DS = New DataSet
            banco.Fill(DS, "admin")

            verificaLogin()


            ' fecha a conexao com o banco de dados

            conexao.Close()
            conexao = Nothing


        End If

        'logando como usuario

        If cbotipo.Text = "Usuario" Then


            'conexao joel
            'conexao = New OleDb.OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\Joel\Desktop\TCC- oficial\Estetica-oficial.mdb")

            'conexao casa
            conexao = New OleDb.OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\Edu\Desktop\TCC- oficial\Estetica-oficial.mdb")

            'conexão etec
            'conexao = New OleDb.OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=D:\TCC- oficial\Estetica-oficial.mdb")


            conexao.Open()

            banco = New OleDb.OleDbDataAdapter("Select usuario, senha FROM usuario ;", conexao)

            ' Le a informação do banco de dados
            DS = New DataSet
            banco.Fill(DS, "usuario")


            verificaLogin()


            ' fecha a conexao com o banco de dados

            conexao.Close()
            conexao = Nothing

        End If
    End Sub

    Private Sub verificaLogin()


        For I As Integer = 0 To DS.Tables(0).Rows.Count - 1

            If ((txtlogin.Text = DS.Tables(0).Rows(I)("usuario").ToString) And (txtsenha.Text = DS.Tables(0).Rows(I)("senha").ToString)) Then

                MessageBox.Show("Acesso permitido ! Bem Vindo """ & " " & txtlogin.Text & """", "Login", MessageBoxButtons.OK, MessageBoxIcon.Information)
                aprovacao = 0
                I = DS.Tables(0).Rows.Count - 1
                If cbotipo.Text = ("Admin") Then

                    Me.Hide()

                    'Ponha seu formulario aqui
                    frmcarregando.Show()
                    formularioAtual = frmmenuprincipaladm

                ElseIf cbotipo.Text = ("Usuario") Then

                    Me.Hide()

                    'Ponha seu formulario aqui

                    frmcarregando.Show()
                    formularioAtual = frmmenuprincipalusuario

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

    Private Sub login_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        cbotipo.Items.Add("Admin")
        cbotipo.Items.Add("Usuario")
    End Sub
End Class
