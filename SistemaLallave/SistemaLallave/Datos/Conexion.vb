Imports System.Data.SqlClient

Public Class Conexion
    
    Protected cnn As New SqlConnection 'variable para establecer una conexion con la base de datos

    Public idusuario As Integer 'variable para que el usuario pueda interactuar con el menu

    Protected Function Conectado()
        Try
            cnn = New SqlConnection("data source=RAUL-VAIO\SQLEXPRESS;initial catalog=Lallave2;integrated security=true")
            cnn.Open()
            Return True

        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        End Try
    End Function

    Protected Function Desconectado()
        Try
            If cnn.State = ConnectionState.Open Then
                cnn.Close()
                Return True
            Else
                Return False
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        End Try
    End Function
End Class
