'importamos la libreria para conectarnos a sql server'
Imports System.Data.SqlClient




Public Class conexion

    Protected cnn As New SqlConnection

    Public idusuario As Integer

    Protected Function conectado()
        Try
            'cnn = New SqlConnection("data source=(DESKTOP-QI6AUGP);initial catalog=ssventas;integrated security=true")
            'Conexion a la misma computadora
            'cnn = New SqlConnection("data source=DESKTOP-QI6AUGP;initial catalog=Refaccioness; user id=Christian;password=123")
            'Conexion a otra computadora
            cnn = New SqlConnection("data source=192.168.1.1,1433;initial catalog=Refaccioness; user id=usuario1;password=123")


            cnn.Open()
            Return True

        Catch ex As Exception
            MsgBox(ex.Message)
            Return False

        End Try
    End Function

    Protected Function desconectado()
        Try
            If cnn.State = ConnectionState.Open Then
                cnn.Close()
                Return True

            Else
                Return False
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
            Return False

        End Try
    End Function



End Class
