﻿Public Class frmdireccionEm
    Private dt As New DataTable

    Private Sub frmdireccionEm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        mostrar()
    End Sub
    Public Sub limpiar()
        btnguardar.Visible = True
        btneditar.Visible = False
        txtcalle.Text = ""
        txtnumero.Text = ""
        txtcolonia.Text = """"

    End Sub
    Private Sub mostrar()
        Try
            Dim fun As New fdireccionEmp
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
        '  datalistado.Columns(1).Visible = False


    End Sub
    Private Sub txtiddireccion_Validated(sender As Object, e As EventArgs) Handles txtiddireccion.Validated
        If DirectCast(sender, TextBox).Text.Length > 0 Then
            Me.erroricono.SetError(sender, "")
        Else
            Me.erroricono.SetError(sender, "Ingrese el nombre dela categoria porfavor dato obligatorio")
        End If
    End Sub
    Private Sub btnnuevo_Click(sender As Object, e As EventArgs) Handles btnnuevo.Click
        limpiar()
        mostrar()
    End Sub

    Private Sub btnguardar_Click(sender As Object, e As EventArgs) Handles btnguardar.Click
        If Me.ValidateChildren = True And txtcalle.Text <> "" And txtnumero.Text <> "" And txtcolonia.Text <> "" Then
            Try
                Dim dts As New vdireccionEmp
                Dim fuc As New fdireccionEmp

                dts.gcalle = txtcalle.Text
                dts.gnumero = txtnumero.Text
                dts.gcolonia = txtcolonia.Text


                If fuc.insertar(dts) Then
                    MessageBox.Show("Direcccion registrada correctamente", "Guardando direccion", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    mostrar()
                    limpiar()
                Else
                    MessageBox.Show("Direccion no registrado intentalo de nuevo ", "Guardando Direccion", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    mostrar()
                    limpiar()

                End If
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        Else
            MessageBox.Show("Falta inggresar unos datos", "Guardando direccion", MessageBoxButtons.OK, MessageBoxIcon.Information)

        End If
    End Sub

    Private Sub datalistado_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles datalistado.CellClick
        txtiddireccion.Text = datalistado.SelectedCells.Item(1).Value
        txtcalle.Text = datalistado.SelectedCells.Item(2).Value
        txtnumero.Text = datalistado.SelectedCells.Item(3).Value
        txtcolonia.Text = datalistado.SelectedCells.Item(4).Value

        btneditar.Visible = True
        btnguardar.Visible = False
    End Sub

    Private Sub btneditar_Click(sender As Object, e As EventArgs) Handles btneditar.Click

        Dim result As DialogResult
        result = MessageBox.Show("Realmente desea editar los datos de la categoria?", "Modificando categoria", MessageBoxButtons.OKCancel, MessageBoxIcon.Question)

        If result = DialogResult.OK Then

            If Me.ValidateChildren = True And txtcalle.Text <> "" And txtnumero.Text <> "" And txtcolonia.Text <> "" Then
                Try
                    Dim dts As New vdireccionEmp
                    Dim fuc As New fdireccionEmp

                    dts.gcalle = txtcalle.Text
                    dts.gnumero = txtnumero.Text
                    dts.gcolonia = txtcolonia.Text


                    If fuc.editar(dts) Then
                        MessageBox.Show("Direccion modifado correctamente", "Modificando direccion", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        mostrar()
                        limpiar()
                    Else
                        MessageBox.Show("Direccion no fue modificado intentalo de nuevo ", "Modificando  direccion", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        mostrar()
                        limpiar()

                    End If
                Catch ex As Exception
                    MsgBox(ex.Message)
                End Try
            Else
                MessageBox.Show("Falta ingresar unos datos", "Modificando direccion", MessageBoxButtons.OK, MessageBoxIcon.Information)

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
        resul = MessageBox.Show("Realmente desea eliminar la direccions seleccionados", "Eliminando registros", MessageBoxButtons.OKCancel, MessageBoxIcon.Question)
        If resul = DialogResult.OK Then
            Try
                For Each row As DataGridViewRow In datalistado.Rows
                    Dim marcado As Boolean = Convert.ToBoolean(row.Cells("Eliminar").Value)
                    If marcado Then
                        Dim onekey As Integer = Convert.ToInt32(row.Cells("id_Direccion").Value)
                        Dim vdb As New vdireccionEmp
                        Dim func As New fdireccionEmp
                        vdb.gid_direccion = onekey

                        If func.eliminar(vdb) Then
                        Else
                            MessageBox.Show("Direccion no fue eliminado", "Eliminando registros", MessageBoxButtons.OK, MessageBoxIcon.Information)

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
            frmalmacen.txtidcategoria.Text = datalistado.SelectedCells.Item(1).Value
            frmalmacen.txtnom_categoria.Text = datalistado.SelectedCells.Item(2).Value
            frmrefacciones.txtidcategoria.Text = datalistado.SelectedCells.Item(1).Value
            frmrefacciones.txtnom_categoria.Text = datalistado.SelectedCells.Item(2).Value
            Me.Close()
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        buscar()
    End Sub


End Class