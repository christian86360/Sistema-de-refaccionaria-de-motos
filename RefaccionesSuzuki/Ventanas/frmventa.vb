Public Class frmventa

    Private dt As New DataTable
    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter

    End Sub

    Private Sub frmventa_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        mostrar()
    End Sub
    Public Sub limpiar()
        btnGuardar.Visible = True
        btnEditar.Visible = False
        txtnumnota.Text = ""
        txtcliente.Text = ""
        txtempleado.Text = ""
        txtfecha.Text = ""

    End Sub

    Private Sub mostrar()
        Try
            Dim func As New fventa
            dt = func.mostrar
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
        btnNuevo.Visible = True
        btnEditar.Visible = False

        'buscar()
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
                ocultar_columnas()

            Else
                inexistente.Visible = True
                datalistado.DataSource = Nothing
            End If

        Catch ex As Exception
            MsgBox(ex.Message)

        End Try
    End Sub


    Private Sub ocultar_columnas()
        datalistado.Columns(1).Visible = False
        datalistado.Columns(2).Visible = False
    End Sub

    Private Sub btnNuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNuevo.Click
        limpiar()
        mostrar()
        Dim g As Double
        'Dim texto As String
        g = 313 + 1
        'g = Convert.ToInt32(txtnumnota.Text)
        'g = Convert.ToDouble(txtnumnota.Text)
        'texto = txtnumnota.Text
        'g = Convert.ToDouble(texto)
        'g = g + 1
        '    g = g + 1
        g = g.ToString()
        '  txtnumnota.Text = g

        'g = conver.txtnumnota

        'txtnumnota.Text = datalistado.SelectedCells.Item(1).Value
        txtnumnota.Text = g
        txtempleado.Visible = False

    End Sub

    Private Sub btnGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGuardar.Click 'And txtfecha.Text <> ""
        If Me.ValidateChildren = True And txtnumnota.Text <> "" And txtempleado.Text <> "" And txtfecha.Text <> "" Then
            Try
                Dim dts As New vventa
                Dim func As New fventa

                dts.gNumNota = txtnumnota.Text
                dts.gCliente = txtcliente.Text
                dts.gFecha = txtfecha.Text

                If func.insertar(dts) Then
                    MessageBox.Show("Venta registrada correctamente vamos añadir productos", "Guardando registros", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    mostrar()
                    limpiar()



                Else
                    MessageBox.Show("venta no fue registrada intente de nuevo", "Guardando registros", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    mostrar()
                    limpiar()
                End If

            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        Else
            MessageBox.Show("Falta ingresar algunos datos", "Guardando registros", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub datalistado_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles datalistado.CellClick
        txtnumnota.Text = datalistado.SelectedCells.Item(1).Value
        txtcliente.Text = datalistado.SelectedCells.Item(5).Value
        txtempleado.Text = datalistado.SelectedCells.Item(6).Value
        txtfecha.Text = datalistado.SelectedCells.Item(4).Value

        btnEditar.Visible = True
        btnGuardar.Visible = False
    End Sub
    Private Sub datalistado_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles datalistado.CellContentClick
        If e.ColumnIndex = Me.datalistado.Columns.Item("Eliminar").Index Then
            Dim chkcell As DataGridViewCheckBoxCell = Me.datalistado.Rows(e.RowIndex).Cells("Eliminar")
            chkcell.Value = Not chkcell.Value
        End If
    End Sub

    Private Sub btnEditar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEditar.Click
        Dim result As DialogResult

        result = MessageBox.Show("Realmente desea editar los datos de la venta?", "MOdificando registros", MessageBoxButtons.OKCancel, MessageBoxIcon.Question)

        If result = DialogResult.OK Then
            'And txtfecha.Text <> ""
            If Me.ValidateChildren = True And txtnumnota.Text <> "" And txtcliente.Text <> "" And txtempleado.Text <> "" Then
                Try
                    Dim dts As New vventa
                    Dim func As New fventa
                    dts.gNumNota = txtnumnota.Text
                    dts.gCliente = txtcliente.Text
                    ' dts.gEmpleado = txtempleado.Text
                    dts.gFecha = txtfecha.Text



                    If func.editar(dts) Then
                        MessageBox.Show("venta Modificada correctamente", "Modificando registros", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        mostrar()
                        limpiar()
                    Else
                        MessageBox.Show("Venta no fue modifcada intente de nuevo", "Modificando registros", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        mostrar()
                        limpiar()
                    End If

                Catch ex As Exception
                    MsgBox(ex.Message)
                End Try
            Else
                MessageBox.Show("Falta ingresar algunos datos", "MOdificando registros", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        End If
    End Sub
    Private Sub cbeliminar_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbeliminar.CheckedChanged
        If cbeliminar.CheckState = CheckState.Checked Then
            datalistado.Columns.Item("Eliminar").Visible = True
        Else
            datalistado.Columns.Item("Eliminar").Visible = False
        End If
    End Sub
    Private Sub btneliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btneliminar.Click
        Dim result As DialogResult

        result = MessageBox.Show("Realmente desea eliminar las venta seleccionados?", "Eliminando registros", MessageBoxButtons.OKCancel, MessageBoxIcon.Question)

        If result = DialogResult.OK Then
            Try
                For Each row As DataGridViewRow In datalistado.Rows
                    Dim marcado As Boolean = Convert.ToBoolean(row.Cells("Eliminar").Value)

                    If marcado Then
                        Dim onekey As Integer = Convert.ToInt32(row.Cells("NumNota").Value)
                        Dim vdb As New vnotacantidad
                        Dim func As New fnotacantidad
                        vdb.gNumNota = onekey

                        If func.eliminar(vdb) Then
                        Else
                            MessageBox.Show("venta no fue eliminado", "Eliminando registros", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        End If
                    End If

                Next
                Call mostrar()

            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        Else
            MessageBox.Show("Cancelando eliminación de registros", "Eliminando registros", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Call mostrar()
        End If

        Call limpiar()
    End Sub

    Private Sub txtbuscar_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtbuscar.TextChanged
        buscar()
    End Sub

    Private Sub txtnumnota_TextChanged(sender As Object, e As EventArgs) Handles txtnumnota.TextChanged
        If DirectCast(sender, TextBox).Text.Length > 0 Then
            Me.erroricono.SetError(sender, "")
        Else
            Me.erroricono.SetError(sender, "Seleccione el Numero de la venta, este dato es obligatorio")
        End If
    End Sub

    Private Sub txtcliente_TextChanged(sender As Object, e As EventArgs) Handles txtcliente.TextChanged
        If DirectCast(sender, TextBox).Text.Length > 0 Then
            Me.erroricono.SetError(sender, "")
        Else
            Me.erroricono.SetError(sender, "Seleccione el cliente de la venta, este dato es obligatorio")
        End If
    End Sub

    Private Sub TextBox3_TextChanged(sender As Object, e As EventArgs) Handles txtempleado.TextChanged
        If DirectCast(sender, TextBox).Text.Length > 0 Then
            Me.erroricono.SetError(sender, "")
        Else
            Me.erroricono.SetError(sender, "Seleccione el Empleado de la venta, este dato es obligatorio")
        End If
    End Sub

    Private Sub btnImprimir_Click(sender As Object, e As EventArgs) Handles btnImprimir.Click
        frmreporteC.txtidventa.Text = Me.txtnumnota.Text
        frmreporteC.ShowDialog()

    End Sub
End Class