Public Class Form1
    Private Sub HojaImpresion_PrintPage(sender As Object, e As Printing.PrintPageEventArgs) Handles HojaImpresion.PrintPage
        Try
            ' La fuente a usar
            Dim prFont As New Font("Arial", 15, FontStyle.Bold)
            ' la posición superior

            'imprimimos la fecha y hora
            prFont = New Font("Arial", 10, FontStyle.Regular)
            e.Graphics.DrawString(Date.Now.ToShortDateString.ToString & " " &
                                Date.Now.ToShortTimeString.ToString, prFont, Brushes.Black, 15, 385)

            'imprimimos el nombre del cliente
            prFont = New Font("Arial", 25, FontStyle.Bold)
            e.Graphics.DrawString("Nombre del Cliente", prFont, Brushes.Black, 50, 250)

            'imprimimos la referencia del pedido
            e.Graphics.DrawString("Referencia", prFont, Brushes.Black, 50, 520)
            prFont = New Font("Arial", 18, FontStyle.Bold)
            e.Graphics.DrawString("Nombre de la Referencia", prFont, Brushes.Black, 50, 555)

            'imprimimos Pedido Ondupack y Pedido del cliente
            prFont = New Font("Arial", 22, FontStyle.Regular)
            e.Graphics.DrawString("Pedido", prFont, Brushes.Black, 50, 660)
            e.Graphics.DrawString("Palets", prFont, Brushes.Black, 250, 660)

            prFont = New Font("Arial", 24, FontStyle.Regular)
            e.Graphics.DrawString("19875", prFont, Brushes.Black, 50, 700)
            e.Graphics.DrawString("44", prFont, Brushes.Black, 250, 700)

            'imprimimos Cajas X Palet y Cajas x Paquete
            prFont = New Font("Arial", 22, FontStyle.Regular)
            e.Graphics.DrawString("Cajas x Palet", prFont, Brushes.Black, 50, 760)
            e.Graphics.DrawString("Cajas x Paquete", prFont, Brushes.Black, 250, 760)

            prFont = New Font("Arial", 24, FontStyle.Regular)
            e.Graphics.DrawString("500", prFont, Brushes.Black, 50, 800)
            e.Graphics.DrawString("32", prFont, Brushes.Black, 250, 800)

            'imprimimos el numero del Palet
            prFont = New Font("Arial", 24, FontStyle.Regular)
            e.Graphics.DrawString("Número del Palet     45", prFont, Brushes.Black, 50, 880)
            'indicamos que hemos llegado al final de la pagina
            e.HasMorePages = False

        Catch ex As Exception
            MessageBox.Show("ERROR: " & ex.Message, "Administrador",
                              MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub cmdImprimir_Click(sender As Object, e As EventArgs) Handles cmdImprimir.Click
        HojaImpresion.Print()

    End Sub
End Class