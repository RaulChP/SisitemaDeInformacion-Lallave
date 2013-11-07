Imports System.Data.SqlClient
Public Class fusuario
    Inherits Conexion
    Dim cmd As SqlCommand 'variable para hacer peticiones a la base de datos

    Public Function Mostrar() As DataTable
        Try
            Conectado()
            cmd = New SqlCommand("mostrar_usuario") 'Inicializa una nueva instancia de la clase SqlCommand con el texto de la consulta.
            cmd.CommandType = CommandType.StoredProcedure 'Obtiene o establece un valor que indica cómo se interpreta la propiedad CommandText=
            cmd.Connection = cnn
            If cmd.ExecuteNonQuery Then 'Ejecuta comandos como instrucciones INSERT, DELETE, UPDATE y SET de Transact-SQL.
                Dim dt As New DataTable
                Dim da As New SqlDataAdapter(cmd)
                da.Fill(dt)
                Return dt
            Else
                Return Nothing

            End If
        Catch ex As Exception
            MsgBox(ex.Message)
            Return Nothing
        Finally
            Desconectado()
        End Try
    End Function

    Private Function mostrar_usuario() As Object
        Throw New NotImplementedException
    End Function
    Public Function Insertar(ByVal dts As vusuario) As Boolean
        Try
            Conectado()
            cmd = New SqlCommand("insertar_usuario") 'Inicializa una nueva instancia de la clase SqlCommand con el texto de la consulta.
            cmd.CommandType = CommandType.StoredProcedure 'Obtiene o establece un valor que indica cómo se interpreta la propiedad CommandText
            cmd.Connection = cnn 'Obtiene o establece el objeto SqlConnection utilizado por esta instancia de SqlCommand.

            cmd.Parameters.AddWithValue("@contraseña", dts.gcontraseña) 'Agrega un valor al final de la colección SqlParameterCollection.
            cmd.Parameters.AddWithValue("@palabra", dts.gpalabra)
            cmd.Parameters.AddWithValue("@idpersona", dts.gidpersona)

            If cmd.ExecuteNonQuery Then 'Ejecuta comandos como instrucciones INSERT, DELETE, UPDATE y SET de Transact-SQL.
                Return True
            Else
                Return False
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        Finally
            Desconectado()
        End Try

    End Function

    Public Function Editar(ByVal dts As vusuario) As Boolean
        Try
            Conectado()
            cmd = New SqlCommand("editar_usuario")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cnn

            cmd.Parameters.AddWithValue("@idusuario", dts.gidusuario)
            cmd.Parameters.AddWithValue("@contraseña", dts.gcontraseña)
            cmd.Parameters.AddWithValue("@palabra", dts.gpalabra)
            cmd.Parameters.AddWithValue("@idpersona", dts.gidpersona)

            If cmd.ExecuteNonQuery Then
                Return True
            Else
                Return False
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        Finally
            Desconectado()
        End Try

    End Function
    Public Function eliminar(ByVal dts As vusuario) As Boolean
        Try
            Conectado()
            cmd = New SqlCommand("eliminar_usuario")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cnn
            cmd.Parameters.Add("@idusuario", SqlDbType.NVarChar, 50).Value = dts.gidusuario
            If cmd.ExecuteNonQuery Then
                Return True
            Else
                Return False
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        End Try
    End Function

    Function eliminar(ByVal lallavedb As vusuarioroles) As Boolean
        Throw New NotImplementedException
    End Function

End Class
