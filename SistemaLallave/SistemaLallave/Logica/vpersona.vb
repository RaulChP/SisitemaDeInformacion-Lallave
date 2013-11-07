Public Class vpersona

    Dim idpersona, ci, idpais As Integer
    Dim nombre, direccion, telefono, localidad, codigopostal As String

    Public Property gidpersona
        Get
            Return idpersona
        End Get
        Set(ByVal value)
            idpersona = value
        End Set
    End Property

    Public Property gci
        Get
            Return ci
        End Get
        Set(ByVal value)
            ci = value
        End Set
    End Property

    Public Property gidpais
        Get
            Return idpais
        End Get
        Set(ByVal value)
            idpais = value
        End Set
    End Property

    Public Property gnombre
        Get
            Return nombre
        End Get
        Set(ByVal value)
            nombre = value
        End Set
    End Property

    Public Property gdireccion
        Get
            Return direccion
        End Get
        Set(ByVal value)
            direccion = value
        End Set
    End Property

    Public Property gtelefono
        Get
            Return telefono
        End Get
        Set(ByVal value)
            telefono = value
        End Set
    End Property

    Public Property glocalidad
        Get
            Return localidad
        End Get
        Set(ByVal value)
            localidad = value
        End Set
    End Property

    Public Property gcodigopostal
        Get
            Return codigopostal
        End Get
        Set(ByVal value)
            codigopostal = value
        End Set
    End Property

    Public Sub New()

    End Sub

    Public Sub New(ByVal idpersona As Integer, ByVal ci As Integer, ByVal idpais As Integer, ByVal nombre As String, ByVal direccion As String, ByVal telefono As String, ByVal localidad As String, ByVal codigopostal As String)
        gidpersona = idpersona
        gci = ci
        gidpais = idpais
        gnombre = nombre
        gdireccion = direccion
        gtelefono = telefono
        glocalidad = localidad
        gcodigopostal = codigopostal

    End Sub
End Class
