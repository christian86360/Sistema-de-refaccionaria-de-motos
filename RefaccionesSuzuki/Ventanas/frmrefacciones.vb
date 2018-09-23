Public Class frmrefacciones
    Private dt As New DataTable
    Private Sub frmrefacciones_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        mostrar()
    End Sub
    Public Sub limpiar()
        btnguardar.Visible = True
        btneditar.Visible = False
        txtnombre.Text = ""
        txtdescripcion.Text = ""
        txtstock.Text = "0"
        txtprecio_uni.Text = "0"
        txtpreciodeventa.Text = "0"
        txtcodigo.Text = ""

        'imagen.Image = Nothing
        'imagen.BackgroundImage = My.Resources.file
        'imagen.SizeMode = PictureBoxSizeMode.StretchImage

    End Sub

    Private Sub mostrar()
        Try
            Dim func As New frefaccion
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
        ' datalistado.Columns(2).Visible = False
    End Sub


    Private Sub txtnombre_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txtnombre.Validating
        If DirectCast(sender, TextBox).Text.Length > 0 Then
            Me.erroricono.SetError(sender, "")
        Else
            Me.erroricono.SetError(sender, "Ingrese el nombre del cliente porfavor, este datos es obligatorio")
        End If
    End Sub





    Private Sub btnnuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnnuevo.Click
        limpiar()
        mostrar()

    End Sub

    Private Sub btnguardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnguardar.Click
        If Me.ValidateChildren = True And txtcodigo.Text <> "" And txtnombre.Text <> "" And txtidcategoria.Text <> "" And txtprecio_uni.Text <> "" And txtpreciodeventa.Text <> "" And txtstock.Text <> "" And txt_ubicastock.Text <> "" And txtmoto_pertenece.Text <> "" And txtdescripcion.Text <> "" Then
            Try
                Dim dts As New vrefaccion
                Dim func As New frefaccion

                dts.gCodigo = txtcodigo.Text
                dts.gNombre = txtnombre.Text
                dts.gCategoria = txtidcategoria.Text
                dts.gCosto_Uni = txtprecio_uni.Text
                dts.gCosto_Vta = txtpreciodeventa.Text
                dts.gStock = txtstock.Text
                dts.gUbica_Stock = txt_ubicastock.Text
                dts.gMoto_Pertenece = txtmoto_pertenece.Text
                dts.gDescripcion = txtdescripcion.Text


                'Dim ms As New IO.MemoryStream()

                ' If Not imagen.Image Is Nothing Then
                'imagen.Image.Save(ms, imagen.Image.RawFormat)
                'Else
                'imagen.Image = My.Resources.file
                'imagen.Image.Save(ms, imagen.Image.RawFormat)
                'End If
                '       dts.gimagen = ms.GetBuffer


                If func.insertar(dts) Then
                    MessageBox.Show("refaccion registrado correctamente", "Guardando registros", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    mostrar()
                    limpiar()
                Else
                    MessageBox.Show("refacciom no fue registrada intente de nuevo", "Guardando registros", MessageBoxButtons.OK, MessageBoxIcon.Error)
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
        txtcodigo.Text = datalistado.SelectedCells.Item(1).Value
        txtnombre.Text = datalistado.SelectedCells.Item(2).Value
        txtidcategoria.Text = datalistado.SelectedCells.Item(3).Value
        txtprecio_uni.Text = datalistado.SelectedCells.Item(4).Value
        txtpreciodeventa.Text = datalistado.SelectedCells.Item(5).Value
        txtstock.Text = datalistado.SelectedCells.Item(6).Value
        txt_ubicastock.Text = datalistado.SelectedCells.Item(7).Value
        txtmoto_pertenece.Text = datalistado.SelectedCells.Item(8).Value
        txtdescripcion.Text = datalistado.SelectedCells.Item(9).Value



        btneditar.Visible = True
        btnguardar.Visible = False
    End Sub

    Private Sub datalistado_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles datalistado.CellContentClick
        If e.ColumnIndex = Me.datalistado.Columns.Item("Eliminar").Index Then
            Dim chkcell As DataGridViewCheckBoxCell = Me.datalistado.Rows(e.RowIndex).Cells("Eliminar")
            chkcell.Value = Not chkcell.Value
        End If
    End Sub

    Private Sub btneditar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btneditar.Click
        Dim result As DialogResult

        result = MessageBox.Show("Realmente desea editar los datos dela refacciones?", "Modificando registros", MessageBoxButtons.OKCancel, MessageBoxIcon.Question)

        If result = DialogResult.OK Then

            If Me.ValidateChildren = True And txtcodigo.Text <> "" And txtnombre.Text <> "" And txtidcategoria.Text <> "" And txtprecio_uni.Text <> "" And txtpreciodeventa.Text <> "" And txtstock.Text <> "" And txt_ubicastock.Text <> "" And txtmoto_pertenece.Text <> "" And txtdescripcion.Text <> "" Then

                Try
                    Dim dts As New vrefaccion
                    Dim func As New frefaccion

                    dts.gCodigo = txtcodigo.Text
                    dts.gNombre = txtnombre.Text
                    dts.gCategoria = txtidcategoria.Text
                    dts.gCosto_Uni = txtprecio_uni.Text
                    dts.gCosto_Vta = txtpreciodeventa.Text
                    dts.gStock = txtstock.Text
                    dts.gUbica_Stock = txt_ubicastock.Text
                    dts.gMoto_Pertenece = txtmoto_pertenece.Text
                    dts.gDescripcion = txtdescripcion.Text





                    If func.editar(dts) Then
                        MessageBox.Show("refaccion Modificado correctamente", "Modificando registros", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        mostrar()
                        limpiar()
                    Else
                        MessageBox.Show("refaccion no fue modifcado intente de nuevo", "Modificando registros", MessageBoxButtons.OK, MessageBoxIcon.Error)
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

        result = MessageBox.Show("Realmente desea eliminar las refacciones seleccionados?", "Eliminando registros", MessageBoxButtons.OKCancel, MessageBoxIcon.Question)

        If result = DialogResult.OK Then
            Try
                For Each row As DataGridViewRow In datalistado.Rows
                    Dim marcado As Boolean = Convert.ToBoolean(row.Cells("Eliminar").Value)

                    If marcado Then
                        Dim onekey As Integer = Convert.ToInt32(row.Cells("Codigo").Value)
                        Dim vdb As New vrefaccion
                        Dim func As New frefaccion
                        vdb.gCodigo = onekey

                        If func.eliminar(vdb) Then
                        Else
                            MessageBox.Show("refaccion no fue eliminado", "Eliminando registros", MessageBoxButtons.OK, MessageBoxIcon.Information)
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

    Private Sub btncargar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        '   If dlg.ShowDialog() = DialogResult.OK Then
        '   imagen.BackgroundImage = Nothing
        '  imagen.Image = New Bitmap(dlg.FileName)
        ' imagen.SizeMode = PictureBoxSizeMode.StretchImage
        'End If
    End Sub

    Private Sub btnlimpiar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        '   imagen.Image = Nothing
        '  imagen.BackgroundImage = My.Resources.file
        ' imagen.SizeMode = PictureBoxSizeMode.StretchImage
    End Sub

    Private Sub btnbuscar_categoria_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnbuscar_categoria.Click
        frmcategoria.txtflag.Text = "1"
        frmcategoria.ShowDialog()
    End Sub




    Private Sub txtbuscar_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtbuscar.TextChanged
        buscar()
    End Sub





    Private Sub txtidcategoria_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txtidcategoria.Validating
        If DirectCast(sender, TextBox).Text.Length > 0 Then
            Me.erroricono.SetError(sender, "")
        Else
            Me.erroricono.SetError(sender, "Seleccione la categoría dela refaccion, este dato es obligatorio")
        End If
    End Sub



    Private Sub txtstock_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txtstock.Validating
        If DirectCast(sender, TextBox).Text.Length > 0 Then
            Me.erroricono.SetError(sender, "")
        Else
            Me.erroricono.SetError(sender, "Ingrese el stock dela refaccion  porfavor, este datos es obligatorio")
        End If
    End Sub



    Private Sub txtprecio_uni_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txtprecio_uni.Validating
        If DirectCast(sender, TextBox).Text.Length > 0 Then
            Me.erroricono.SetError(sender, "")
        Else
            Me.erroricono.SetError(sender, "Ingrese el precio de compra dela refaccion porfavor, este datos es obligatorio")
        End If
    End Sub



    Private Sub txtpreciodeventa_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txtpreciodeventa.Validating
        If DirectCast(sender, TextBox).Text.Length > 0 Then
            Me.erroricono.SetError(sender, "")
        Else
            Me.erroricono.SetError(sender, "Ingrese el precio en el que se vendera el producto porfavor, este datos es obligatorio")
        End If
    End Sub

    Private Sub datalistado_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles datalistado.CellDoubleClick
        If txtflag.Text = "0" Then
            '' frmnotacantidad.txtcodigo.Text = datalistado.SelectedCells.Item(1).Value
            frmnotacantidad.txtstock.Text = datalistado.SelectedCells.Item(6).Value
            Me.Close()
        End If

    End Sub

    Private Sub inexistente_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles inexistente.LinkClicked

    End Sub
End Class