Imports System.Data.SqlClient
Public Class frefaccion
    Inherits conexion
    Dim cmd As New SqlCommand

    Public Function mostrar() As DataTable
        Try
            conectado()
            cmd = New SqlCommand("mostrar_refaccion")
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


    Public Function insertar(ByVal dts As vrefaccion) As Boolean
        Try
            conectado()
            cmd = New SqlCommand("insertar_refaccion")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cnn


            cmd.Parameters.AddWithValue("@Codigo", dts.gCategoria)
            cmd.Parameters.AddWithValue("@Nombre", dts.gNombre)
            cmd.Parameters.AddWithValue("@Categoria", dts.gCategoria)
            cmd.Parameters.AddWithValue("@Costo_Uni", dts.gCosto_Uni)
            cmd.Parameters.AddWithValue("@Costo_Vta", dts.gCosto_Vta)
            cmd.Parameters.AddWithValue("@Stock", dts.gStock)
            cmd.Parameters.AddWithValue("@Ubica_Stock", dts.gUbica_Stock)
            cmd.Parameters.AddWithValue("@Moto_Pertenece", dts.gMoto_Pertenece)
            cmd.Parameters.AddWithValue("@Descripcion", dts.gDescripcion)
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



    Public Function editar(ByVal dts As vrefaccion) As Boolean
        Try
            conectado()
            cmd = New SqlCommand("editar_refaccion")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cnn

            cmd.Parameters.AddWithValue("@Codigo", dts.gCategoria)
            cmd.Parameters.AddWithValue("@Nombre", dts.gNombre)
            cmd.Parameters.AddWithValue("@Categoria", dts.gCategoria)
            cmd.Parameters.AddWithValue("@Costo_Uni", dts.gCosto_Uni)
            cmd.Parameters.AddWithValue("@Costo_Vta", dts.gCosto_Vta)
            cmd.Parameters.AddWithValue("@Stock", dts.gStock)
            cmd.Parameters.AddWithValue("@Ubica_Stock", dts.gUbica_Stock)
            cmd.Parameters.AddWithValue("@Moto_Pertenece", dts.gMoto_Pertenece)
            cmd.Parameters.AddWithValue("@Descripcion", dts.gDescripcion)
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
    Public Function eliminar(ByVal dts As vrefaccion) As Boolean
        Try
            conectado()
            cmd = New SqlCommand("eliminar_refaccion")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cnn

            cmd.Parameters.Add("@Codigo", SqlDbType.NVarChar, 50).Value = dts.gCodigo
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

End Class
