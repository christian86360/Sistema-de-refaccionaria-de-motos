Public Class vdireccion

    Dim id_direccion As Integer
    Dim calle, numero, colonia As String

    Public Property gid_direccion
        Get
            Return id_direccion

        End Get
        Set(value)
            id_direccion = value

        End Set
    End Property

    Public Property gcalle
        Get
            Return calle
        End Get
        Set(value)
            calle = value

        End Set
    End Property

    Public Property gnumero
        Get
            Return numero
        End Get
        Set(value)
            numero = value

        End Set
    End Property
    Public Property gcolonia
        Get
            Return colonia
        End Get
        Set(value)
            colonia = value

        End Set
    End Property

    Public Sub New()

    End Sub

    Public Sub New(ByVal id_direccion As Integer, ByVal calle As String, ByVal numero As String, ByVal colonia As String)

        gid_direccion = gid_direccion
        gcalle = calle
        gnumero = numero
        gcolonia = colonia
    End Sub
End Class
