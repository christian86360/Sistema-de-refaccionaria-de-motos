Public Class vnotacantidad
    Dim NumNota, Cantida As Integer
    Dim Codigo As String

    Public Property gNumNota
        Get
            Return NumNota
        End Get
        Set(value)
            NumNota = value

        End Set
    End Property
    Public Property gCodigo
        Get
            Return Codigo
        End Get
        Set(value)
            Codigo = value

        End Set
    End Property
    Public Property gCantidad
        Get
            Return Cantida
        End Get
        Set(value)
            Cantida = value

        End Set
    End Property

    Public Sub New()

    End Sub

    Public Sub New(ByVal NumNota As Integer, ByVal Codigo As String, ByVal Cantidad As Integer)
        gNumNota = NumNota
        gCodigo = Codigo
        gCantidad = Cantida
    End Sub
End Class
