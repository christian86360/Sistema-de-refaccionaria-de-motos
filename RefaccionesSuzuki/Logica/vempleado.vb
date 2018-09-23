Public Class vempleado
    Dim Nombre, Ap_Paterno, Ap_Materno, Tele_Cel As String
    Dim id_Empleado, Usuario, id_Dir As Integer

    Public Property gid_Empleado
        Get
            Return id_Empleado
        End Get
        Set(value)
            id_Empleado = value

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
    Public Property gAp_Paterno
        Get
            Return Ap_Paterno
        End Get
        Set(value)
            Ap_Paterno = value

        End Set
    End Property
    Public Property gAp_Materno
        Get
            Return Ap_Materno
        End Get
        Set(value)
            Ap_Materno = value

        End Set
    End Property
    Public Property gTele_Cel
        Get
            Return Tele_Cel
        End Get
        Set(value)
            Tele_Cel = value

        End Set
    End Property
    Public Property gUduario
        Get
            Return Usuario
        End Get
        Set(value)
            Usuario = value

        End Set
    End Property
    Public Property gid_Dir
        Get
            Return id_Dir
        End Get
        Set(value)
            id_Dir = value

        End Set
    End Property

    Public Sub New()

    End Sub

    Public Sub New(ByVal id_Empleado As Integer, ByVal Nombre As String, ByVal Ap_Paterno As String, ByVal Ap_Materno As String, ByVal Tele_Cel As String, ByVal Usuario As Integer, ByVal id_Dir As Integer)

        gid_Empleado = id_Empleado
        gNombre = Nombre
        gAp_Paterno = Ap_Paterno
        gAp_Materno = Ap_Materno
        gTele_Cel = Tele_Cel
        gUduario = Usuario
        gid_Dir = id_Dir


    End Sub




End Class
