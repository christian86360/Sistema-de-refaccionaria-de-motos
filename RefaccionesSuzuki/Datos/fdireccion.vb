Imports System.Data.SqlClient
Public Class fdireccion

    Inherits conexion
    Dim cmd As New SqlCommand

    Public Function mostrar() As DataTable
        Try
            conectado()
            cmd = New SqlCommand("mostrar_direccion")
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

    Public Function insertar(ByVal dts As vdireccion) As Boolean
        Try
            conectado()
            cmd = New SqlCommand("insertar_direccion")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cnn

            cmd.Parameters.AddWithValue("@Calle", dts.gcalle)
            cmd.Parameters.AddWithValue("@Numero", dts.gnumero)
            cmd.Parameters.AddWithValue("@Colonia", dts.gcolonia)


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


    Public Function editar(ByVal dts As vdireccion) As Boolean
        Try
            conectado()
            cmd = New SqlCommand("editar_direccion")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cnn
            cmd.Parameters.AddWithValue("@id_Direccion", dts.gid_direccion)
            cmd.Parameters.AddWithValue("@Calle", dts.gcalle)
            cmd.Parameters.AddWithValue("@Numero", dts.gnumero)
            cmd.Parameters.AddWithValue("@Colonia", dts.gcolonia)


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

    Public Function eliminar(ByVal dts As vdireccion) As Boolean
        Try
            conectado()
            cmd = New SqlCommand("eliminar_direccion")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cnn
            cmd.Parameters.Add("@id_Direccion", SqlDbType.NVarChar, 50).Value = dts.gid_direccion
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
