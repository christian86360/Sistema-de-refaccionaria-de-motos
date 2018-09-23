Public Class formularioUsuarios




    Private Sub formularioUsuarios_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Lbhora.Text = TimeOfDay
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Lbhora.Text = TimeOfDay
    End Sub

    Private Sub btnsalir_Click(sender As Object, e As EventArgs) Handles btnsalir.Click
        End
    End Sub

    Private Sub btningresar_Click(sender As Object, e As EventArgs) Handles btningresar.Click
        Try
            Dim dts As New vusuario
            Dim fuc As New fusuario

            dts.gnombre = txtlogin.Text
            dts.gcontraseña = txtpassword.Text

            If fuc.validar_usuario(dts) = True Then
                InicioRefacciones.Show()
                Me.Hide()
            Else
                MsgBox("Ingrese nuevamente sus datos correctos", MsgBoxStyle.Information, "Acceso denegado al sistema")
                txtpassword.Clear()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

End Class