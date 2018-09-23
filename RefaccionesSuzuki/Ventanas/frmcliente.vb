Imports System.ComponentModel

Public Class frmcliente
    Private dt As New DataTable

    Private Sub frmcliente_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        mostrar()

    End Sub

    Public Sub limpiar()
        btnguardar.Visible = True
        btneditar.Visible = False
        txtnombre.Text = ""
        txtap_paterno.Text = ""
        txtdireccion.Text = ""
        txttelefono.Text = ""
        txtidecliente.Text = ""
        txtap_materno.Text = ""
    End Sub


    Private Sub mostrar()
        Try
            Dim fun As New fcliente
            dt = fun.mostrar
            'para ocultar link label'
            datalistado.Columns.Item("Eliminar").Visible = False
            If dt.Rows.Count <> 0 Then
                datalistado.DataSource = dt
                txtbuscar.Enabled = True
                datalistado.ColumnHeadersVisible = True
                inexistente.Visible = False
            Else
                datalistado.DataSource = Nothing
                txtbuscar.Enabled = False
                datalistado.ColumnHeadersVisible = False
                inexistente.Visible = True

            End If


        Catch ex As Exception
            MsgBox(ex.Message)

        End Try
        btnnuevo.Visible = True
        btneditar.Visible = False

        buscar()


    End Sub


    Private Sub buscar()
        Try
            Dim ds As New DataSet
            ds.Tables.Add(dt.Copy)
            Dim dv As New DataView(ds.Tables(0))

            dv.RowFilter = cbocampo.Text & " like '" & txtbuscar.Text & "%'"

            If dv.Count <> 0 Then
                inexistente.Visible = False
                datalistado.DataSource = dv
                ocultar_columna()
            Else
                inexistente.Visible = True
                datalistado.DataSource = Nothing

            End If

        Catch ex As Exception
            MsgBox(ex.Message)

        End Try
    End Sub

    Private Sub ocultar_columna()
        'ocultar la columna'
        datalistado.Columns(1).Visible = False


    End Sub

    Private Sub txtnombre_Validating(sender As Object, e As CancelEventArgs) Handles txtnombre.Validating
        If DirectCast(sender, TextBox).Text.Length > 0 Then
            Me.erroricono.SetError(sender, "")
        Else
            Me.erroricono.SetError(sender, "Ingrese el nombre del cliente porfavor dato obligatorio")
        End If
    End Sub


    Private Sub txtap_paterno_Validating(sender As Object, e As CancelEventArgs) Handles txtap_paterno.Validating
        If DirectCast(sender, TextBox).Text.Length > 0 Then
            Me.erroricono.SetError(sender, "")
        Else
            Me.erroricono.SetError(sender, "Ingrese el apellido paterno de cliente  porfavor datos obligatorios")
        End If
    End Sub

    Private Sub txtap_materno_Validiting(sender As Object, e As CancelEventArgs) Handles txtap_materno.Validating
        If DirectCast(sender, TextBox).Text.Length > 0 Then
            Me.erroricono.SetError(sender, "")
        Else
            Me.erroricono.SetError(sender, "Ingrese el apellido materno del cliente porfavor datos obligatorios")
        End If

    End Sub





    Private Sub txtdireccion_Validating(sender As Object, e As CancelEventArgs) Handles txtdireccion.Validating
        If DirectCast(sender, TextBox).Text.Length > 0 Then
            Me.erroricono.SetError(sender, "")
        Else
            Me.erroricono.SetError(sender, "Ingrese la direccion del cliente porfavor dato obligatorio")
        End If
    End Sub


    Private Sub txttelefono_Validating(sender As Object, e As CancelEventArgs) Handles txttelefono.Validating
        If DirectCast(sender, TextBox).Text.Length > 0 Then
            Me.erroricono.SetError(sender, "")
        Else
            Me.erroricono.SetError(sender, "Ingrese el telefono del cliente porfavor dato obligatorio")
        End If
    End Sub


    'Private Sub txtdni_Validating(sender As Object, e As CancelEventArgs)
    'If DirectCast(sender, TextBox).Text.Length > 0 Then
    'Me.erroricono.SetError(sender, "")
    'Else
    'Me.erroricono.SetError(sender, "Ingrese el dni del cliente porfavor dato obligatorio")
    'End If
    'End Sub


    Private Sub btnnuevo_Click(sender As Object, e As EventArgs) Handles btnnuevo.Click
        limpiar()
        mostrar()
    End Sub



    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If Me.ValidateChildren = True And txtnombre.Text <> "" And txtap_paterno.Text <> "" And txtap_materno.Text <> "" And txttelefono.Text <> "" And txtdireccion.Text <> "" Then
            Try
                Dim dts As New vcliente
                Dim fuc As New fcliente

                dts.gnombre = txtnombre.Text
                dts.gap_paterno = txtap_paterno.Text
                dts.gap_materno = txtap_materno.Text
                dts.gtel_cel = txttelefono.Text
                dts.gid_direccion = txtdireccion.Text


                If fuc.insertar(dts) Then
                    MessageBox.Show("Cliente registrado correctamente", "Guardando registros", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    mostrar()
                    limpiar()
                Else
                    MessageBox.Show("Cliente no registrado intentalo de nuevo ", "Guardando registros", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    mostrar()
                    limpiar()

                End If
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        Else
            MessageBox.Show("Falta inggresar unos datos", "Guardando registros", MessageBoxButtons.OK, MessageBoxIcon.Information)

        End If
    End Sub



    Private Sub datalistado_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles datalistado.CellClick
        txtidecliente.Text = datalistado.SelectedCells.Item(1).Value
        txtnombre.Text = datalistado.SelectedCells.Item(2).Value
        txtap_paterno.Text = datalistado.SelectedCells.Item(3).Value
        txtap_materno.Text = datalistado.SelectedCells.Item(4).Value
        txttelefono.Text = datalistado.SelectedCells.Item(5).Value
        txtdireccion.Text = datalistado.SelectedCells.Item(6).Value
        btneditar.Visible = True
        Button1.Visible = False
    End Sub



    Private Sub btneditar_Click(sender As Object, e As EventArgs) Handles btneditar.Click

        Dim result As DialogResult
        result = MessageBox.Show("Realmente desea editar los datos del cliente?", "Modificando registros", MessageBoxButtons.OKCancel, MessageBoxIcon.Question)

        If result = DialogResult.OK Then

            If Me.ValidateChildren = True And txtnombre.Text <> "" And txtap_paterno.Text <> "" And txtap_materno.Text <> "" And txttelefono.Text <> "" And txtdireccion.Text <> "" And txtidecliente.Text <> "" Then
                Try
                    Dim dts As New vcliente
                    Dim fuc As New fcliente
                    dts.gidcliente = txtidecliente.Text
                    dts.gnombre = txtnombre.Text
                    dts.gap_paterno = txtap_paterno.Text
                    dts.gap_materno = txtdireccion.Text
                    dts.gtel_cel = txttelefono.Text
                    dts.gid_direccion = txtdireccion.Text

                    If fuc.editar(dts) Then
                        MessageBox.Show("Cliente modifado correctamente", "Modificando registros", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        mostrar()
                        limpiar()
                    Else
                        MessageBox.Show("Cliente no fue modificado intentalo de nuevo ", "Modificando  registros", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        mostrar()
                        limpiar()

                    End If
                Catch ex As Exception
                    MsgBox(ex.Message)
                End Try
            Else
                MessageBox.Show("Falta ingresar unos datos", "Modificando registros", MessageBoxButtons.OK, MessageBoxIcon.Information)

            End If
        End If

    End Sub


    Private Sub cbeliminar_CheckedChanged(sender As Object, e As EventArgs) Handles cbeliminar.CheckedChanged
        If cbeliminar.CheckState = CheckState.Checked Then
            datalistado.Columns.Item("Eliminar").Visible = True
        Else
            datalistado.Columns.Item("Eliminar").Visible = False
        End If
    End Sub

    Private Sub datalistado_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles datalistado.CellContentClick
        If e.ColumnIndex = Me.datalistado.Columns.Item("Eliminar").Index Then
            Dim chkcell As DataGridViewCheckBoxCell = Me.datalistado.Rows(e.RowIndex).Cells("Eliminar")
            chkcell.Value = Not chkcell.Value
        End If
    End Sub

    Private Sub btneliminar_Click(sender As Object, e As EventArgs) Handles btneliminar.Click
        Dim resul As DialogResult
        resul = MessageBox.Show("Realmente desea eliminar los clientes seleccionados", "Eliminando registros", MessageBoxButtons.OKCancel, MessageBoxIcon.Question)
        If resul = DialogResult.OK Then
            Try
                For Each row As DataGridViewRow In datalistado.Rows
                    Dim marcado As Boolean = Convert.ToBoolean(row.Cells("Eliminar").Value)
                    If marcado Then
                        Dim onekey As Integer = Convert.ToInt32(row.Cells("id_Cliente").Value)
                        Dim vdb As New vcliente
                        Dim func As New fcliente
                        vdb.gidcliente = onekey

                        If func.eliminar(vdb) Then
                        Else
                            MessageBox.Show("Cliente no fue eliminado", "Eliminando registros", MessageBoxButtons.OK, MessageBoxIcon.Information)

                        End If
                    End If
                Next
                Call mostrar()
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        Else
            MessageBox.Show("Canselando eliminacion de registros", "Eliminando registros", MessageBoxButtons.OKCancel, MessageBoxIcon.Information)
            Call mostrar()
        End If
        Call limpiar()
    End Sub

    Private Sub datalistado_DoubleClick(sender As Object, e As EventArgs) Handles datalistado.DoubleClick
        'If txtflag.Text = "1" Then
        '   frmdirecciones.txtdireccion.Text = datalistado.SelectedCells.Item(1).Value
        ' frmventa.txtnom_cliente.Text = datalistado.SelectedCells.Item(2).Value
        Me.Close()


        'End If
    End Sub

    'para abrir las direcciones de los clientes
    Private Sub btnbuscar_categoria_Click(sender As Object, e As EventArgs) Handles btnbuscar_categoria.Click
        frmdirecciones.txtflag.Text = "1"
        frmdirecciones.ShowDialog()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        buscar()
    End Sub
End Class

