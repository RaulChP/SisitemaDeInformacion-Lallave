Public Class vroles
    Dim codigo As Integer
    Dim descripcion As String

    'seeter y getter

    Public Property gcodigo
        Get
            Return codigo
        End Get
        Set(ByVal value)
            codigo = value
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

    'constructores

    Public Sub New()

    End Sub

    Public Sub New(ByVal codigo As Integer, ByVal descripcion As String)
        gcodigo = codigo
        gdescripcion = descripcion

    End Sub
End Class
