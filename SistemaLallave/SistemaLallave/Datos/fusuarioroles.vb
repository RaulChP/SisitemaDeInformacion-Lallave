Imports System.Data.SqlClient
Public Class fusuarioroles
    Inherits Conexion
    Dim cmd As SqlCommand 'variable para hacer peticiones a la base de datos
    Public Function Mostrar() As DataTable
        Try
            Conectado()
            cmd = New SqlCommand("mostrar_usuarioroles")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cnn
            If cmd.ExecuteNonQuery Then
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
    Public Function Insertar(ByVal dts As vusuarioroles) As Boolean
        Try
            Conectado()
            cmd = New SqlCommand("insertar_usuarioroles") 'Inicializa una nueva instancia de la clase SqlCommand con el texto de la consulta.
            cmd.CommandType = CommandType.StoredProcedure 'Obtiene o establece un valor que indica cómo se interpreta la propiedad CommandText
            cmd.Connection = cnn 'Obtiene o establece el objeto SqlConnection utilizado por esta instancia de SqlCommand.

            cmd.Parameters.AddWithValue("@idusuario", dts.gidusuario) 'Agrega un valor al final de la colección SqlParameterCollection.
            cmd.Parameters.AddWithValue("@codigorol", dts.gcodigorol)


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

    Public Function Editar(ByVal dts As vusuarioroles) As Boolean
        Try
            Conectado()
            cmd = New SqlCommand("editar_usuarioroles")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cnn

            cmd.Parameters.AddWithValue("@idusuarioroles", dts.gidusuarioroles)
            cmd.Parameters.AddWithValue("@idusuario", dts.gidusuario)
            cmd.Parameters.AddWithValue("@codigorol", dts.gcodigorol)

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
    Public Function eliminar(ByVal dts As vusuarioroles) As Boolean
        Try
            Conectado()
            cmd = New SqlCommand("eliminar_usuarioroles")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cnn
            cmd.Parameters.Add("@idusuarioroles", SqlDbType.NVarChar, 50).Value = dts.gidusuarioroles
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
End Class
