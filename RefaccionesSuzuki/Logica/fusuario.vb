Imports System.Data.SqlClient
Public Class fusuario
    Inherits conexion
    Dim cmd As New SqlCommand

    Public Function validar_usuario(ByVal dts As vusuario)
        Try
            conectado()
            cmd = New SqlCommand("validar_usuario")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cnn
            cmd.Parameters.AddWithValue("@Nombre", dts.gnombre)
            cmd.Parameters.AddWithValue("@Contraseña", dts.gcontraseña)
            Dim dr As SqlDataReader
            dr = cmd.ExecuteReader
            If dr.HasRows = True Then
                Return True
            Else
                Return False
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        Finally
            desconectado()

        End Try
    End Function
End Class
