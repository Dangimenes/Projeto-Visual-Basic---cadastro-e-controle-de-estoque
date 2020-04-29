Public Class frmcarregando

    Private Sub tempo_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tempo.Tick
        carrega.Increment(1)
        If carrega.Value = carrega.Maximum Then
            Me.Close()
            formularioAtual.Show()
            tempo.Stop()
        End If
    End Sub

    Private Sub frmcarregando_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        tempo.Start()
    End Sub
End Class