Public Class vusuario
    Dim idusuario, idpersona As Integer
    Dim contraseña, palabra As String

    Public Property gidusuario
        Get
            Return idusuario
        End Get
        Set(ByVal value)
            idusuario = value
        End Set
    End Property

    Public Property gidpersona
        Get
            Return idpersona
        End Get
        Set(ByVal value)
            idpersona = value
        End Set
    End Property
    Public Property gcontraseña
        Get
            Return contraseña
        End Get
        Set(ByVal value)
            contraseña = value
        End Set
    End Property

    Public Property gpalabra
        Get
            Return palabra
        End Get
        Set(ByVal value)
            palabra = value
        End Set
    End Property

    Public Sub New()

    End Sub

    Public Sub New(ByVal idusuario As Integer, ByVal contraseña As String, ByVal palabra As String, ByVal idpersona As Integer)
        gidusuario = idusuario
        gcontraseña = contraseña
        gpalabra = palabra
        gidpersona = idpersona
    End Sub
End Class
