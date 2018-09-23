Public Class frmalmacen

    Private dt As New DataTable
    Private Sub frmalmacen_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        mostrar()
    End Sub
    Public Sub limpiar()
        btnguardar.Visible = True
        btneditar.Visible = False
        txtubica_almacen.Text = ""

    End Sub

    Private Sub mostrar()
        Try
            Dim fun As New falmacen
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


            dv.RowFilter = cboalmacen.Text & " like '" & txtbuscar.Text & "%'"

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
        'datalistado.Columns(1).Visible = False


    End Sub


    Private Sub txtnombre_Validated(sender As Object, e As EventArgs) Handles txtubica_almacen.Validated
        If DirectCast(sender, TextBox).Text.Length > 0 Then
            Me.erroricono.SetError(sender, "")
        Else
            Me.erroricono.SetError(sender, "Ingrese el nombre porfavor dato obligatorio")
        End If
    End Sub
    Private Sub btnnuevo_Click(sender As Object, e As EventArgs) Handles btnnuevo.Click
        limpiar()
        mostrar()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If Me.ValidateChildren = True And txtid_almacen.Text <> "" And txtubica_almacen.Text <> "" And txtcantida_cajas.Text <> "" And txtidcategoria.Text <> "" And txtnom_categoria.Text <> "" Then
            Try
                Dim dts As New valmacen
                Dim fuc As New falmacen


                dts.gid_almacen = txtid_almacen.Text
                dts.gubica_almacen = txtubica_almacen.Text
                dts.gcantidad_cajas = txtubica_almacen
                dts.gcategoria = txtidcategoria


                If fuc.insertar(dts) Then
                    MessageBox.Show(" Registrada correctamente", "Guardando ", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    mostrar()
                    limpiar()
                Else
                    MessageBox.Show(" Registrado intentalo de nuevo ", "Guardando ", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    mostrar()
                    limpiar()

                End If
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        Else
            MessageBox.Show("Falta inggresar unos datos", "Guardando ", MessageBoxButtons.OK, MessageBoxIcon.Information)

        End If
    End Sub

    Private Sub datalistado_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles datalistado.CellClick
        txtid_almacen.Text = datalistado.SelectedCells.Item(1).Value
        txtubica_almacen.Text = datalistado.SelectedCells.Item(2).Value
        txtcantida_cajas.Text = datalistado.SelectedCells.Item(3).Value
        txtidcategoria.Text = datalistado.SelectedCells.Item(4).Value
        btneditar.Visible = True
        Button1.Visible = False
    End Sub


    Private Sub btneditar_Click(sender As Object, e As EventArgs) Handles btneditar.Click

        Dim result As DialogResult
        result = MessageBox.Show("Realmente desea editar los datos del Almacen?", "Modificando ", MessageBoxButtons.OKCancel, MessageBoxIcon.Question)

        If result = DialogResult.OK Then

            If Me.ValidateChildren = True And txtubica_almacen.Text <> "" And txtid_almacen.Text <> "" Then
                Try
                    Dim dts As New valmacen
                    Dim fuc As New falmacen
                    dts.gid_almacen = txtid_almacen.Text
                    dts.gubica_almacen = txtubica_almacen.Text
                    dts.gcantidad_cajas = txtcantida_cajas.Text
                    dts.gcategoria = txtidcategoria.Text


                    If fuc.editar(dts) Then
                        MessageBox.Show("Almacen modifado correctamente", "Modificando Almacen", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        mostrar()
                        limpiar()
                    Else
                        MessageBox.Show("No fue modificado intentalo de nuevo ", "Modificando ", MessageBoxButtons.OK, MessageBoxIcon.Error)
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
        resul = MessageBox.Show("Realmente desea eliminar  ", "Eliminando registros", MessageBoxButtons.OKCancel, MessageBoxIcon.Question)
        If resul = DialogResult.OK Then
            Try
                For Each row As DataGridViewRow In datalistado.Rows
                    Dim marcado As Boolean = Convert.ToBoolean(row.Cells("Eliminar").Value)
                    If marcado Then
                        Dim onekey As Integer = Convert.ToInt32(row.Cells("id_Almacen").Value)
                        Dim vdb As New valmacen
                        Dim func As New falmacen
                        vdb.gid_almacen = onekey

                        If func.eliminar(vdb) Then

                        Else
                            MessageBox.Show("No fue eliminado", "Eliminando registros", MessageBoxButtons.OK, MessageBoxIcon.Information)

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

    Private Sub datalistado_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles datalistado.CellDoubleClick
        If txtflag.Text = "1" Then
            'frmcategoria.txtid_almacen.Text = datalistado.SelectedCells.Item(1).Value
            'frmrefacciones.txtnom_categoria.Text = datalistado.SelectedCells.Item(2).Value
            Me.Close()
        End If
    End Sub

    Private Sub btnbuscar_categoria_Click(sender As Object, e As EventArgs) Handles btnbuscar_categoria.Click
        frmcategoria.txtflag.Text = "1"
        frmcategoria.ShowDialog()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        buscar()
    End Sub


End Class