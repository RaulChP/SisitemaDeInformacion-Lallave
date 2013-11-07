Public Class vpais
    Dim idpais As Integer
    Dim nombre As String
    Dim descripcion As String

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

    Public Property gdescripcion
        Get
            Return descripcion
        End Get
        Set(ByVal value)
            descripcion = value
        End Set
    End Property

    Public Sub New()

    End Sub

    Public Sub New(ByVal idpais As Integer, ByVal nombre As String, ByVal descripcion As String)
        gidpais = idpais
        gnombre = nombre
        gdescripcion = descripcion

    End Sub
End Class
