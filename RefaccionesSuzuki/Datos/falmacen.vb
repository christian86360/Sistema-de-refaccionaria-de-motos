Imports System.Data.SqlClient

Public Class falmacen
    Inherits conexion
    Dim cmd As New SqlCommand

    Public Function mostrar() As DataTable
        Try
            conectado()
            cmd = New SqlCommand("mostrar_almacen")
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

    Public Function insertar(ByVal dts As valmacen) As Boolean
        Try
            conectado()
            cmd = New SqlCommand("insertar_Almacen")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cnn

            cmd.Parameters.AddWithValue("@Ubica_Almacen", dts.gubica_almacen)
            cmd.Parameters.AddWithValue("@@Cantidad_Cajas", dts.gcantidad_cajas)
            cmd.Parameters.AddWithValue("@Categoria", dts.gcategoria)

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


    Public Function editar(ByVal dts As valmacen) As Boolean
        Try
            conectado()
            cmd = New SqlCommand("editar_Almacen")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cnn
            cmd.Parameters.AddWithValue("@id_Almacen", dts.gid_almacen)
            cmd.Parameters.AddWithValue("@Ubica_Almacen", dts.gubica_almacen)
            cmd.Parameters.AddWithValue("@Cantidad_Cajas", dts.gcantidad_cajas)
            cmd.Parameters.AddWithValue("@Categoria", dts.gcategoria)


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

    Public Function eliminar(ByVal dts As valmacen) As Boolean
        Try
            conectado()
            cmd = New SqlCommand("eliminar_Almacen")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cnn
            cmd.Parameters.Add("@id_Almacen", SqlDbType.NVarChar, 50).Value = dts.gid_almacen
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
