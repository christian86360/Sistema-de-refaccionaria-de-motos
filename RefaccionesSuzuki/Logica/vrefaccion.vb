Public Class vrefaccion
    Dim Codigo, Nombre, Ubica_Stock, Moto_Pertenece, Descripcion As String
    Dim Categoria, Costo_Uni, Costo_Vta, Stock As Integer


    Public Property gCodigo
        Get
            Return Codigo
        End Get
        Set(value)
            Codigo = value

        End Set
    End Property

    Public Property gNombre
        Get
            Return Nombre
        End Get
        Set(value)
            Nombre = value

        End Set
    End Property

    Public Property gCategoria
        Get
            Return Categoria
        End Get
        Set(value)
            Categoria = value

        End Set
    End Property

    Public Property gCosto_Uni
        Get
            Return Costo_Uni
        End Get
        Set(value)
            Costo_Uni = value

        End Set
    End Property

    Public Property gCosto_Vta
        Get
            Return Costo_Vta
        End Get
        Set(value)
            Costo_Vta = value

        End Set
    End Property

    Public Property gStock
        Get
            Return Stock
        End Get
        Set(value)
            Stock = value

        End Set
    End Property

    Public Property gUbica_Stock
        Get
            Return Ubica_Stock
        End Get
        Set(value)
            Ubica_Stock = value

        End Set
    End Property

    Public Property gMoto_Pertenece
        Get
            Return Moto_Pertenece
        End Get
        Set(value)
            Moto_Pertenece = value

        End Set
    End Property

    Public Property gDescripcion
        Get
            Return Descripcion
        End Get
        Set(value)
            Descripcion = value


        End Set
    End Property

    Public Sub New()

    End Sub

    Public Sub New(ByVal Codigo As String, ByVal Categoria As Integer, ByVal Costo_Uni As Integer, ByVal Costo_Vta As Integer, ByVal Stock As Integer, ByVal Ubica_Stock As String, ByVal Moto_Pertenece As String, ByVal Descripcion As String)
        gCodigo = Codigo
        gCategoria = Categoria
        gCosto_Uni = Costo_Uni
        gCosto_Vta = gCosto_Vta
        gStock = Stock
        gUbica_Stock = Ubica_Stock
        gMoto_Pertenece = Moto_Pertenece
        gDescripcion = Descripcion


    End Sub




End Class
