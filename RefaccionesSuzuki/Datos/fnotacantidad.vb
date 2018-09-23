Imports System.Data.SqlClient
Public Class fnotacantidad
    Inherits conexion
    Dim cmd As New SqlCommand

    Public Function mostrar() As DataTable
        Try
            conectado()
            cmd = New SqlCommand("mostrar_nota")
            cmd.CommandType = CommandType.StoredProcedure

            cmd.Connection = cnn
            If cmd.ExecuteNonQuery Then
                Dim dt As New DataTable
                Dim da As New SqlDataAdapter(cmd)
                da.Fill(dt)
                Return dt
            Else
                Return Nothing

            End If
        Catch ex As Exception
            MsgBox(ex.Message)
            Return Nothing
        Finally
            desconectado()

        End Try

    End Function

    Public Function insertar(ByVal dts As vnotacantidad) As Boolean
        Try
            conectado()
            cmd = New SqlCommand("insertar_nota")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cnn

            cmd.Parameters.AddWithValue("@NumNota", dts.gNumNota)
            cmd.Parameters.AddWithValue("@Codigo", dts.gCodigo)
            cmd.Parameters.AddWithValue("@Cantida", dts.gCantidad)



            If cmd.ExecuteNonQuery Then
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


    Public Function editar(ByVal dts As vnotacantidad) As Boolean
        Try
            conectado()
            cmd = New SqlCommand("editar_nota")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cnn

            cmd.Parameters.AddWithValue("@NumNota", dts.gNumNota)
            cmd.Parameters.AddWithValue("@Cantidad", dts.gCantidad)


            If cmd.ExecuteNonQuery Then
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

    Public Function eliminar(ByVal dts As vnotacantidad) As Boolean
        Try
            conectado()
            cmd = New SqlCommand("eliminar_nota")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cnn
            cmd.Parameters.Add("@NumNota", SqlDbType.NVarChar, 50).Value = dts.gNumNota
            If cmd.ExecuteNonQuery Then
                Return True
            Else
                Return False
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        End Try
    End Function

    Public Function aumentar_stock(ByVal dts As vnotacantidad) As Boolean
        Try
            conectado()
            cmd = New SqlCommand("aumentar_stock")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cnn

            cmd.Parameters.AddWithValue("@codigo", dts.gNumNota)
            cmd.Parameters.AddWithValue("@Cantidad", dts.gCantidad)


            If cmd.ExecuteNonQuery Then
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


    Public Function disminuir_stock(ByVal dts As vnotacantidad) As Boolean
        Try
            conectado()
            cmd = New SqlCommand("disminuir_stock")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cnn

            cmd.Parameters.AddWithValue("@codigo", dts.gNumNota)
            cmd.Parameters.AddWithValue("@Cantidad", dts.gCantidad)


            If cmd.ExecuteNonQuery Then
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
