Public Class MetododeOrdenamiento
    Private tabla As New DataTable
    Public numereos As Integer

    Private Sub MetododeOrdenamiento_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        fillData()
    End Sub

    Public Sub Short1()
        Dim i, j As Integer
        Dim minimo As Integer
        Dim temp As Double

        'y colocamos el código de selección de visual, ahora ya solo debemos llenar la formula con los datos del vector.
        '  For i = 0 To 9 - 1
        ' minimo = i
        'For j = i + 1 To 9
        'If numeros(minimo) > numeros(j) Then
        'minimo = j
        'End If
        'Next j
        'temp = numeros(i)
        'numeros(i) = numeros(minimo)
        'numeros(minimo) = temp
        'Next i



    End Sub

    Public Sub fillData()
        tabla.Columns.Add("id", GetType(Integer))
        tabla.Columns.Add("Categoria", GetType(String))

        ComboBox1.Items.Add("id")
        ComboBox1.Items.Add("Categoria")

        tabla.Rows.Add(1, "Filtros")
        tabla.Rows.Add(2, "Bujias")
        tabla.Rows.Add(3, "Balatas")
        tabla.Rows.Add(4, "Espejos")
        tabla.Rows.Add(5, "Cadenas")
        tabla.Rows.Add(6, "Juntas")
        tabla.Rows.Add(7, "Cilindros")
        tabla.Rows.Add(8, "Carburador")
        tabla.Rows.Add(9, "Espreas")
        tabla.Rows.Add(10, "Escape")
        tabla.Rows.Add(11, "Bombas")

        DataGridView1.DataSource = tabla

    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged

        tabla.DefaultView.Sort = ComboBox1.SelectedItem.ToString()
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub
End Class