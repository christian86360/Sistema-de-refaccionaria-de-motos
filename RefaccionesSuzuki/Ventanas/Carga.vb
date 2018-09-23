Public Class Carga



    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If ProgressBar1.Value < 100 Then
            ProgressBar1.Value = ProgressBar1.Value + 10
            Label1.Text = "Cargando el sistema al" & ProgressBar1.Value & "%"
        Else
            Timer1.Enabled = False
            Me.Hide()
            formularioUsuarios.Show()
        End If
    End Sub


    Private Sub Carga_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class