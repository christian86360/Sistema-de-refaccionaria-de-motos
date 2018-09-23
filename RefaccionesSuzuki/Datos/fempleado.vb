Imports System.Data.SqlClient
Public Class fempleado
    Inherits conexion
    Dim cmd As New SqlCommand

    Public Function mostrar() As DataTable
        Try
            conectado()
            cmd = New SqlCommand("mostrar_empleado")
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

    Public Function insertar(ByVal dts As vempleado) As Boolean
        Try
            conectado()
            cmd = New SqlCommand("insertar_empleado")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cnn

            cmd.Parameters.AddWithValue("@Nombre", dts.gNombre)

            cmd.Parameters.AddWithValue("@Ap_Paterno", dts.gAp_Paterno)

            cmd.Parameters.AddWithValue("@Ap_Materno", dts.gAp_Materno)

            cmd.Parameters.AddWithValue("@Tele_Cel", dts.gTele_Cel)

            cmd.Parameters.AddWithValue("@Usuario", dts.gUduario)

            cmd.Parameters.AddWithValue("@id_Dir", dts.gid_Dir)

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


    Public Function editar(ByVal dts As vempleado) As Boolean
        Try
            conectado()
            cmd = New SqlCommand("editar_empleado")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cnn
            cmd.Parameters.AddWithValue("@id_Empleado", dts.gid_Empleado)
            cmd.Parameters.AddWithValue("@Nombre", dts.gNombre)
            cmd.Parameters.AddWithValue("@Ap_Paterno", dts.gAp_Paterno)
            cmd.Parameters.AddWithValue("@Ap_Materno", dts.gAp_Materno)
            cmd.Parameters.AddWithValue("@Tele_Cel", dts.gTele_Cel)


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

    Public Function eliminar(ByVal dts As vempleado) As Boolean
        Try
            conectado()
            cmd = New SqlCommand("eliminar_empleado")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cnn
            cmd.Parameters.Add("@id_Empleado", SqlDbType.NVarChar, 50).Value = dts.gid_Empleado
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
