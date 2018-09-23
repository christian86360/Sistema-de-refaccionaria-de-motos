Public Class valmacen


    Dim id_almacen, cantida_cajas, categoria As Integer
    Dim ubica_almacen As String

    Public Property gid_almacen
        Get
            Return id_almacen
        End Get
        Set(value)
            id_almacen = value
        End Set
    End Property

    Public Property gubica_almacen
        Get
            Return ubica_almacen
        End Get
        Set(value)
            ubica_almacen = value

        End Set
    End Property

    Public Property gcantidad_cajas
        Get
            Return cantida_cajas
        End Get
        Set(value)
            cantida_cajas = value

        End Set
    End Property

    Public Property gcategoria
        Get
            Return categoria
        End Get
        Set(value)
            categoria = value
        End Set
    End Property

    Public Sub New()

    End Sub
    Public Sub New(ByVal id_almacen As Integer, ByVal ubica_almacen As String, ByVal cantidad_cajas As Integer, ByVal categoria As Integer)

        gid_almacen = id_almacen
        gubica_almacen = ubica_almacen
        gcantidad_cajas = cantidad_cajas
        gcategoria = categoria




    End Sub



End Class
