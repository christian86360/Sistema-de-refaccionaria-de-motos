Public Class vventa
    Dim NumNota, Cliente As Integer
    Dim Fecha As Date

    Public Property gNumNota
        Get
            Return NumNota
        End Get
        Set(value)
            NumNota = value

        End Set
    End Property
    Public Property gCliente
        Get
            Return Cliente
        End Get
        Set(value)
            Cliente = value

        End Set
    End Property

    Public Property gFecha
        Get
            Return Fecha
        End Get
        Set(value)
            Fecha = value

        End Set
    End Property

    Public Sub New()

    End Sub
    Public Sub New(ByVal NumNota As Integer, ByVal Cliente As Integer, ByVal Fecha As Date)
        gNumNota = NumNota
        gCliente = NumNota
        gFecha = Fecha
    End Sub
End Class
