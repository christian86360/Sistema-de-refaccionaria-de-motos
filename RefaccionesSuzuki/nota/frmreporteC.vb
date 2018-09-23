Public Class frmreporteC
    Private Sub frmreporteC_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'RefaccionessDataSet.generar_comprobante' Puede moverla o quitarla según sea necesario.
        Me.generar_comprobanteTableAdapter.Fill(Me.RefaccionessDataSet.generar_comprobante, NumNota:=txtidventa.Text)
        Me.ReportViewer1.RefreshReport()
    End Sub

    Private Sub ReportViewer1_Load(sender As Object, e As EventArgs) Handles ReportViewer1.Load

    End Sub
End Class