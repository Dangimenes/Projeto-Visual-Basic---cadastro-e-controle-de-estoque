Public Class frmadicionar

    Private Sub frmadicionar_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        cbopergunta.Items.Add("Qual Nome do Seu Animal de Estimação preferido?")
        cbopergunta.Items.Add("Qual o nome do seu pai?")
        cbopergunta.Items.Add("Qual o seu esporte preferido?")
        cbopergunta.Items.Add("Nome de uma comida")
        cbopergunta.Items.Add("Data comemorativa")
        cbotipo.Items.Add("Admin")
        cbotipo.Items.Add("Usuario")
    End Sub

    Private Sub btnoquei_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnoquei.Click
        If txtlogin.Text.Trim = "" Then
            MessageBox.Show("Escolha um Login !", "Login", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtlogin.Focus()
        Else
            'se o textbox2 esta em branco...
        End If
        If txtsenha.Text.Trim = "" Then
            MessageBox.Show("Escolha uma Senha !", "Senha", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtsenha.Focus()
        Else
            If txtconfirmasenha.Text.Trim = "" Then
                MessageBox.Show("Confirme sua  Senha !", "Senha", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                txtsenha.Focus()
            Else
                'se a combobox esta em branco
                If cbotipo.Text.Trim = "" Then
                    MessageBox.Show("Selecione o Tipo de Usuario : Admin ou usuário !", "Login", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    cbotipo.Focus()
                ElseIf cbopergunta.Text = "Escolha uma Pergunta de Segurança" Or cbopergunta.Text = "" Then
                    MessageBox.Show("Esolha uma Pergunta de Segurança", "Atenção")
                ElseIf txtresposta.Text = "" Then
                    MessageBox.Show("Digite Sua resposta", "Atenção")

                End If
            End If
        End If
        If txtsenha.Text = txtconfirmasenha.Text Then
            If cbotipo.Text = "Admin" Then
                Try
                    cmd = New OleDb.OleDbCommand
                    cmd.CommandText = "INSERT INTO admin(Usuário,Senha,Perguntaseguranca,Resposta) VALUES(@usuario, @senha,@resposta,@pergunta)"
                    cmd.Parameters.AddWithValue("@usuario", txtlogin.Text)
                    cmd.Parameters.AddWithValue("@senha", txtsenha.Text)
                    cmd.Parameters.AddWithValue("@resposta", txtresposta.Text)
                    cmd.Parameters.AddWithValue("@pergunta", cbopergunta.Text)
                    SalvarDados()
                Catch ex As Exception
                    MessageBox.Show(ex.ToString, "Erro na Inclusão", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End Try
            End If
            If cbotipo.Text = "Usuario" Then
                Try
                    cmd = New OleDb.OleDbCommand
                    cmd.CommandText = "INSERT INTO usuario (Usuário,Senha,Perguntaseguranca,Resposta) values(@usuario,@senha,@resposta,@pergunta)"
                    cmd.Parameters.AddWithValue("@usuario", txtlogin.Text)
                    cmd.Parameters.AddWithValue("@senha", txtsenha.Text)
                    cmd.Parameters.AddWithValue("@pergunta", cbopergunta.Text)
                    cmd.Parameters.AddWithValue("@resposta", txtresposta.Text)
                    SalvarDados()
                Catch ex As Exception
                    MessageBox.Show(ex.ToString, "Erro na Inclusão", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End Try
            End If
        Else
            MsgBox("Senhas não Combinam", MsgBoxStyle.Information)
        End If
        txtconfirmasenha.Clear()
        txtlogin.Clear()
        txtsenha.Clear()
        cbotipo.ResetText()
        cbopergunta.ResetText()
        txtresposta.Clear()

    End Sub

    Private Sub btnsair_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnsair.Click
        Me.Close()
    End Sub
End Class