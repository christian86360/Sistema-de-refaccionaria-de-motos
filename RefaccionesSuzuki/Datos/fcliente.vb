Imports System.Data.SqlClient


Public Class fcliente

    Inherits conexion
    Dim cmd As New SqlCommand

    Public Function mostrar() As DataTable
        Try
            conectado()
            cmd = New SqlCommand("mmostrar_cliente")
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

    Public Function insertar(ByVal dts As vcliente) As Boolean
        Try
            conectado()
            cmd = New SqlCommand("insertar_cliente")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cnn

            cmd.Parameters.AddWithValue("@Nombre", dts.gnombre)
            cmd.Parameters.AddWithValue("@Ap_Paterno", dts.gap_paterno)
            cmd.Parameters.AddWithValue("@Ap_MAterno", dts.gap_materno)
            cmd.Parameters.AddWithValue("@Tele_Cel", dts.gtel_cel)
            cmd.Parameters.AddWithValue("@id_Direccion", dts.gid_direccion)

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


    Public Function editar(ByVal dts As vcliente) As Boolean
        Try
            conectado()
            cmd = New SqlCommand("editar_cliente")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cnn
            cmd.Parameters.AddWithValue("@id_Cliente", dts.gidcliente)
            cmd.Parameters.AddWithValue("@Nombre", dts.gnombre)
            cmd.Parameters.AddWithValue("@Ap_Paterno", dts.gap_paterno)
            cmd.Parameters.AddWithValue("@Ap_Materno", dts.gap_materno)
            cmd.Parameters.AddWithValue("@Tele_Cel", dts.gtel_cel)
            cmd.Parameters.AddWithValue("@id_Direccion", dts.gid_direccion)

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

    Public Function eliminar(ByVal dts As vcliente) As Boolean
        Try
            conectado()
            cmd = New SqlCommand("eliminar_cliente")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cnn
            cmd.Parameters.Add("@id_Cliente", SqlDbType.NVarChar, 50).Value = dts.gidcliente
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
