Public Class telaincial

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        ProgressBar1.Increment(1)
        If ProgressBar1.Value = ProgressBar1.Maximum Then
            Me.Hide()
            frmlogin.Show()
            Timer1.Stop()
        End If
    End Sub

    Private Sub telaincial_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Timer1.Start()
    End Sub

    Private Sub ProgressBar1_BackColorChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles ProgressBar1.BackColorChanged
        ProgressBar1.BackColor = Color.Aqua
    End Sub

    Private Sub ProgressBar1_ForeColorChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles ProgressBar1.ForeColorChanged
        ProgressBar1.ForeColor = Color.Aqua
    End Sub
End Class