Public Class vcliente
    Dim idcliente, id_direccion As Integer
    Dim nombre, ap_paterno, ap_materno, tel_cel As String
    'metodos seter y geters
    Public Property gidcliente
        Get
            Return idcliente
        End Get
        Set(value)
            idcliente = value

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

    Public Property gap_paterno
        Get
            Return ap_paterno
        End Get
        Set(value)
            ap_paterno = value


        End Set
    End Property


    Public Property gap_materno
        Get
            Return ap_materno
        End Get
        Set(value)
            ap_materno = value
        End Set
    End Property


    Public Property gtel_cel
        Get
            Return tel_cel
        End Get
        Set(value)
            tel_cel = value

        End Set
    End Property

    Public Property gid_direccion
        Get
            Return id_direccion
        End Get
        Set(value)
            id_direccion = value

        End Set
    End Property


    'constructores
    Public Sub New()

    End Sub

    Public Sub New(ByVal idcliente As Integer, ByVal nombre As String, ByVal ap_paterno As String, ByVal ap_materno As String, ByVal tel_cel As String, ByVal id_direccion As Integer)
        gidcliente = idcliente
        gnombre = nombre
        gap_paterno = ap_paterno
        gap_materno = ap_materno
        gtel_cel = tel_cel
        gid_direccion = id_direccion
    End Sub

End Class