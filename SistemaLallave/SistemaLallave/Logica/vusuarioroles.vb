Public Class vusuarioroles
    Dim idusuarioroles, idusuario, codigorol As Integer

    Sub New()
        ' TODO: Complete member initialization 
    End Sub

    Public Property gidusuarioroles
        Get
            Return idusuarioroles
        End Get
        Set(ByVal value)
            idusuarioroles = value
        End Set
    End Property
    Public Property gidusuario
        Get
            Return idusuario
        End Get
        Set(ByVal value)
            idusuario = value
        End Set
    End Property
    Public Property gcodigorol
        Get
            Return codigorol
        End Get
        Set(ByVal value)
            codigorol = value
        End Set
    End Property
    Public Sub New(ByVal idusuarioroles As Integer, ByVal idusuario As Integer, ByVal codigorol As Integer)
        gidusuarioroles = idusuarioroles
        gidusuario = idusuario
        gcodigorol = codigorol
    End Sub
End Class
