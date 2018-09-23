Public Class frmnotacantidad
    Private dt As New DataTable


    Private Sub frmnotacantidad_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        mostrar()
    End Sub

    Public Sub limpiar()
        btnguardar.Visible = True
        btneditar.Visible = False
        txtnumnota.Text = ""
        txtcodigo.Text = ""
        txtcant.Text = 0
        txtstock.Text = 0


    End Sub

    Private Sub mostrar()
        Try
            Dim func As New fnotacantidad
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
        ' datalistado.Columns(1).Visible = False
        'datalistado.Columns(2).Visible = False
    End Sub

    Private Sub btnnuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnnuevo.Click
        limpiar()
        mostrar()
    End Sub

    Private Sub btnguardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnguardar.Click
        If Me.ValidateChildren = True And txtnumnota.Text <> "" And txtcodigo.Text <> "" And txtcodigo.Text <> "" Then
            Try
                Dim dts As New vnotacantidad
                Dim func As New fnotacantidad

                dts.gNumNota = txtnumnota.Text
                dts.gCodigo = txtcodigo.Text
                dts.gCantidad = txtcant.Text


                If func.insertar(dts) Then
                    If func.disminuir_stock(dts) Then
                        MessageBox.Show("Nota registrada correctamente ", "Guardando registros", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        mostrar()
                        limpiar()



                    Else
                        MessageBox.Show("Nota no fue registrada intente de nuevo", "Guardando registros", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        mostrar()
                        limpiar()
                    End If
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
        txtcodigo.Text = datalistado.SelectedCells.Item(2).Value
        txtcant.Text = datalistado.SelectedCells.Item(3).Value


        btneditar.Visible = True
        btnguardar.Visible = False
    End Sub
    Private Sub datalistado_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles datalistado.CellContentClick
        If e.ColumnIndex = Me.datalistado.Columns.Item("Eliminar").Index Then
            Dim chkcell As DataGridViewCheckBoxCell = Me.datalistado.Rows(e.RowIndex).Cells("Eliminar")
            chkcell.Value = Not chkcell.Value
        End If
    End Sub

    Private Sub btnEditar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btneditar.Click
        Dim result As DialogResult

        result = MessageBox.Show("Realmente desea editar los datos de la Nota ?", "Modificando registros", MessageBoxButtons.OKCancel, MessageBoxIcon.Question)

        If result = DialogResult.OK Then

            If Me.ValidateChildren = True And txtnumnota.Text <> "" And txtcant.Text <> "" Then
                Try
                    Dim dts As New vnotacantidad
                    Dim func As New fnotacantidad

                    dts.gNumNota = txtnumnota.Text
                    dts.gCantidad = txtcant.Text




                    If func.editar(dts) Then
                        MessageBox.Show("Nota Modificada correctamente", "Modificando registros", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        mostrar()
                        limpiar()
                    Else
                        MessageBox.Show("Nota no fue modifcada intente de nuevo", "Modificando registros", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        mostrar()
                        limpiar()
                    End If

                Catch ex As Exception
                    MsgBox(ex.Message)
                End Try
            Else
                MessageBox.Show("Falta ingresar algunos datos", "Modificando registros", MessageBoxButtons.OK, MessageBoxIcon.Information)
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

        result = MessageBox.Show("Realmente desea eliminar las notas seleccionados?", "Eliminando registros", MessageBoxButtons.OKCancel, MessageBoxIcon.Question)

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
                            If func.aumentar_stock(vdb) Then
                            Else
                                MessageBox.Show("nota no fue eliminado", "Eliminando registros", MessageBoxButtons.OK, MessageBoxIcon.Information)
                            End If
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
            Me.erroricono.SetError(sender, "Seleccione el Numero de la nota, este dato es obligatorio")
        End If
    End Sub

    Private Sub txtcodigo_TextChanged(sender As Object, e As EventArgs) Handles txtcodigo.TextChanged
        If DirectCast(sender, TextBox).Text.Length > 0 Then
            Me.erroricono.SetError(sender, "")
        Else
            Me.erroricono.SetError(sender, "Seleccione el codigo de la nota, este dato es obligatorio")
        End If
    End Sub

    Private Sub txtcantida_TextChanged(sender As Object, e As EventArgs)
        If DirectCast(sender, TextBox).Text.Length > 0 Then
            Me.erroricono.SetError(sender, "")
        Else
            Me.erroricono.SetError(sender, "Seleccione la cantidad de la nota, este dato es obligatorio")
        End If
    End Sub

    Private Sub txtcant_ValueChanged(sender As Object, e As EventArgs) Handles txtcant.ValueChanged
        Dim cant As Double
        cant = txtcant.Value

        If txtcant.Value > txtstock.Value Then
            MessageBox.Show("La catidad supera stock", "Error", MessageBoxButtons.OK)
            btnguardar.Visible = 0
            txtcant.Value = txtstock.Value
        Else
            btnguardar.Visible = 1
        End If
        If txtcant.Value = 0 Then
            btnguardar.Visible = 0
        Else
            btnguardar.Visible = 1

        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If txtflag.Text = "0" Then
            frmrefacciones.ShowDialog()

        End If

    End Sub
End Class