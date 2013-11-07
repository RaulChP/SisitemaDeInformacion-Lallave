Imports System.Data.SqlClient

Public Class fpais
    Inherits conexion
    Dim cmd As New SqlCommand

    Public Function mostrar() As DataTable
        Try
            conectado()
            cmd = New SqlCommand("mostrar_pais")
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
            desconectado()
        End Try
    End Function

    Public Function insertar(ByVal dts As vpais) As Boolean
        Try
            conectado()
            cmd = New SqlCommand("insertar_pais")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cnn

            cmd.Parameters.AddWithValue("@nombre", dts.gnombre)
            cmd.Parameters.AddWithValue("@descripcion", dts.gdescripcion)

            If cmd.ExecuteNonQuery Then
                Return True
            Else
                Return False
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        Finally
            desconectado()

        End Try

    End Function

    Public Function editar(ByVal dts As vpais) As Boolean
        Try
            conectado()
            cmd = New SqlCommand("editar_pais")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cnn

            cmd.Parameters.AddWithValue("@idpais", dts.gidpais)
            cmd.Parameters.AddWithValue("@nombre", dts.gnombre)
            cmd.Parameters.AddWithValue("@descripcion", dts.gdescripcion)

            If cmd.ExecuteNonQuery Then
                Return True
            Else
                Return False
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        Finally
            desconectado()

        End Try

    End Function

    Public Function eliminar(ByVal dts As vpais) As Boolean
        Try
            conectado()
            cmd = New SqlCommand("eliminar_pais")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cnn

            cmd.Parameters.Add("@idpais", SqlDbType.NVarChar, 50).Value = dts.gidpais
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
