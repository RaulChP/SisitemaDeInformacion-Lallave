Imports System.Data.SqlClient

Public Class fpersona

    Inherits conexion
    Dim cmd As New SqlCommand

    Public Function mostrar() As DataTable
        Try
            conectado()
            cmd = New SqlCommand("mostrar_persona")
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

    Public Function insertar(ByVal dts As vpersona) As Boolean
        Try
            conectado()
            cmd = New SqlCommand("insertar_persona")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cnn

            cmd.Parameters.AddWithValue("@ci", dts.gci)
            cmd.Parameters.AddWithValue("@idpais", dts.gidpais)
            cmd.Parameters.AddWithValue("@nombre", dts.gnombre)
            cmd.Parameters.AddWithValue("@direccion", dts.gdireccion)
            cmd.Parameters.AddWithValue("@telefono", dts.gtelefono)
            cmd.Parameters.AddWithValue("@localidad", dts.glocalidad)
            cmd.Parameters.AddWithValue("@codigopostal", dts.gcodigopostal)

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

    Public Function editar(ByVal dts As vpersona) As Boolean
        Try
            conectado()
            cmd = New SqlCommand("editar_persona")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cnn

            cmd.Parameters.AddWithValue("@idpersona", dts.gidpersona)
            cmd.Parameters.AddWithValue("@ci", dts.gci)
            cmd.Parameters.AddWithValue("@idpais", dts.gidpais)
            cmd.Parameters.AddWithValue("@nombre", dts.gnombre)
            cmd.Parameters.AddWithValue("@direccion", dts.gdireccion)
            cmd.Parameters.AddWithValue("@telefono", dts.gtelefono)
            cmd.Parameters.AddWithValue("@localidad", dts.glocalidad)
            cmd.Parameters.AddWithValue("@codigopostal", dts.gcodigopostal)

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

    Public Function eliminar(ByVal dts As vpersona) As Boolean
        Try
            conectado()
            cmd = New SqlCommand("eliminar_persona")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cnn

            cmd.Parameters.Add("@idpersona", SqlDbType.NVarChar, 50).Value = dts.gidpersona
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
