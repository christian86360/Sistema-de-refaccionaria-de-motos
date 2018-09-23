Public Class vusuario
    Dim id As Integer
    Dim nombre, contraseña As String
    Public Property gid
        Get
            Return id
        End Get
        Set(value)
            id = value

        End Set
    End Property

    Public Property gnombre
        Get
            Return nombre
        End Get
        Set(value)
            nombre = value

        End Set
    End Property

    Public Property gcontraseña
        Get
            Return contraseña
        End Get
        Set(value)
            contraseña = value

        End Set
    End Property




    Public Sub New()

    End Sub
    Public Sub New(ByVal id As Integer, nombre As String, contraseña As String)
        gid = id
        gnombre = nombre
        gcontraseña = contraseña

    End Sub
End Class
