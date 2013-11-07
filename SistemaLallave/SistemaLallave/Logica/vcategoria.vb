Public Class vcategoria
    Dim idcategoria As Integer
    Dim descripcion As String

    Public Property gidcategoria
        Get
            Return idcategoria
        End Get
        Set(ByVal value)
            idcategoria = value
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

    Public Sub New(ByVal idcategoria As Integer, ByVal descripcion As String)
        gidcategoria = idcategoria
        gdescripcion = descripcion

    End Sub

End Class
