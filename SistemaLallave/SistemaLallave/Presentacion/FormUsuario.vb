Public Class FormUsuario
    Private dt As DataTable

    Private Sub FormUsuario_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        mostrar()
    End Sub

    Public Sub limpiar()
        botinsertar.Visible = True
        boteditar.Visible = False
        textcontraseña.Text = ""
        textclave.Text = ""
        texidpersona.Text = ""
    End Sub


    Private Sub mostrar()
        Try
            Dim func As New fusuario
            dt = func.Mostrar
            gridusuario.Columns.Item("Eliminar").Visible = False

            If dt.Rows.Count <> 0 Then
                gridusuario.DataSource = dt
                textbuscar.Enabled = True
                gridusuario.ColumnHeadersVisible = True
                inexistente.Visible = False
            Else
                gridusuario.DataSource = Nothing
                textbuscar.Enabled = False
                gridusuario.ColumnHeadersVisible = False
                inexistente.Visible = True
            End If
        Catch ex As Exception
            MsgBox(ex.Message)

        End Try
        botnuevo.Visible = True
        botinsertar.Visible = False
        boteditar.Visible = False
        boteliminar.Visible = False
        botnuevopersona.Visible = False

        ' buscar()
    End Sub
    'Private Sub buscar()
    '    Try
    '        Dim ds As New DataSet
    '        ds.Tables.Add(dt.Copy)
    '        Dim dv As New DataView(ds.Tables(0))

    '        dv.RowFilter = CStr(combollave.Text) & " like '" & CStr(textbuscar.Text) & " %'"

    '        If dv.Count <> 0 Then
    '            inexistente.Visible = False
    '            gridusuario.DataSource = dv
    '        Else
    '            inexistente.Visible = True
    '            gridusuario.DataSource = Nothing
    '        End If
    '    Catch ex As Exception
    '        MsgBox(ex.Message)
    '    End Try
    'End Sub
    Public Sub mostrar_persona()
        Try
            Dim func As New fpersona
            dt = func.Mostrar
            gridusuario.Columns.Item("Eliminar").Visible = False
            If dt.Rows.Count <> 0 Then
                gridusuario.DataSource = dt
                textbuscar.Enabled = True
                gridusuario.ColumnHeadersVisible = True
                inexistente.Visible = False
            Else
                gridusuario.DataSource = Nothing
                textbuscar.Enabled = False
                gridusuario.ColumnHeadersVisible = False
                inexistente.Visible = True
            End If
        Catch ex As Exception
            MsgBox(ex.Message)

        End Try
        ' buscar()
    End Sub
    Private Sub textcontraseña_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles textcontraseña.TextChanged

    End Sub

    Private Sub textcontraseña_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles textcontraseña.Validating
        If DirectCast(sender, TextBox).Text.Length > 0 Then
            Me.erroricono.SetError(sender, "")
        Else
            Me.erroricono.SetError(sender, "Ingrese Datos")
        End If
    End Sub

    Private Sub textclave_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles textclave.TextChanged

    End Sub

    Private Sub textclave_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles textclave.Validating
        If DirectCast(sender, TextBox).Text.Length > 0 Then
            Me.erroricono.SetError(sender, "")
        Else
            Me.erroricono.SetError(sender, "Ingrese Datos")
        End If
    End Sub

    Private Sub texidpersona_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles texidpersona.Click
        If botinsertar.Visible = True Then
            mostrar_persona()
        End If
    End Sub

    Private Sub textci_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles texidpersona.TextChanged

    End Sub

    Private Sub textci_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles texidpersona.Validating
        If DirectCast(sender, TextBox).Text.Length > 0 Then
            Me.erroricono.SetError(sender, "")
        Else
            Me.erroricono.SetError(sender, "Ingrese Datos")
        End If
    End Sub

    Private Sub botnuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles botnuevo.Click
        limpiar()
        mostrar()
        botinsertar.Visible = True
        botnuevo.Visible = False
        botnuevopersona.Visible = True


    End Sub

    Private Sub botinsertar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles botinsertar.Click
        If Me.ValidateChildren = True And textcontraseña.Text <> "" And textclave.Text <> "" And texidpersona.Text <> "" Then
            Try
                Dim dts As New vusuario
                Dim fun As New fusuario
                dts.gcontraseña = textcontraseña.Text
                dts.gpalabra = textclave.Text
                dts.gidpersona = texidpersona.Text

                If fun.Insertar(dts) Then
                    MessageBox.Show("Usuario registrado correctamente", "Guardar Usuario", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    mostrar()
                    limpiar()
                Else
                    MessageBox.Show("Usuario no fue registrado", "Guardar Usuario", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If

            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        Else
            MessageBox.Show("Faltan Datos", "Guardar Usuario", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If

    End Sub

    Private Sub gridusuario_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles gridusuario.CellClick
        textidusuario.Text = gridusuario.SelectedCells.Item(1).Value
        textcontraseña.Text = gridusuario.SelectedCells.Item(2).Value
        textclave.Text = gridusuario.SelectedCells.Item(3).Value
        texidpersona.Text = gridusuario.SelectedCells.Item(4).Value
        boteditar.Visible = True
        botinsertar.Visible = False
    End Sub

    Private Sub gridusuario_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles gridusuario.CellContentClick
        If e.ColumnIndex = Me.gridusuario.Columns.Item("Eliminar").Index Then
            Dim checkcell As DataGridViewCheckBoxCell = Me.gridusuario.Rows(e.RowIndex).Cells("Eliminar")
            checkcell.Value = Not checkcell.Value
        End If
    End Sub

    Private Sub boteditar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles boteditar.Click
        Dim resultado As DialogResult

        resultado = MessageBox.Show("Desea Modificar registro", "Modificar Registro", MessageBoxButtons.OKCancel, MessageBoxIcon.Question)

        If resultado = DialogResult.OK Then

            If Me.ValidateChildren = True And textcontraseña.Text <> "" And textclave.Text <> "" And texidpersona.Text <> "" And textidusuario.Text <> "" Then
                Try
                    Dim dts As New vusuario
                    Dim fun As New fusuario

                    dts.gidusuario = textidusuario.Text
                    dts.gcontraseña = textcontraseña.Text
                    dts.gpalabra = textclave.Text
                    dts.gidpersona = texidpersona.Text

                    If fun.Editar(dts) Then
                        MessageBox.Show("Usuario modificado correctamente", "Modificar Usuario", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        mostrar()
                        limpiar()
                    Else
                        MessageBox.Show("Usuario no fue modificado", "Modificiar Usuario", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End If

                Catch ex As Exception
                    MsgBox(ex.Message)
                End Try
            Else
                MessageBox.Show("Faltan Datos", "Modificar Usuario", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        End If

    End Sub

    Private Sub checkeliminar_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles checkeliminar.CheckedChanged
        If checkeliminar.CheckState = CheckState.Checked Then
            gridusuario.Columns.Item("Eliminar").Visible = True
            boteliminar.Visible = True
        Else
            gridusuario.Columns.Item("Eliminar").Visible = False
            boteliminar.Visible = False
        End If
    End Sub

    Private Sub boteliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles boteliminar.Click
        Dim resultado As DialogResult
        resultado = MessageBox.Show("Desea eliminar usuario seleccionados", "Elimimando Usuario", MessageBoxButtons.OKCancel, MessageBoxIcon.Question)

        If resultado = DialogResult.OK Then
            Try
                For Each row As DataGridViewRow In gridusuario.Rows
                    Dim marcado As Boolean = Convert.ToBoolean(row.Cells("Eliminar").Value)
                    If marcado Then
                        Dim llave As Integer = Convert.ToInt32(row.Cells("idusuario").Value)
                        Dim lallavedb As New vusuario
                        Dim func As New fusuario
                        lallavedb.gidusuario = llave
                        If func.eliminar(lallavedb) Then
                        Else
                            MessageBox.Show("Usuario no eliminado", "Elimimando Usuario", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        End If
                    End If
                Next
                Call mostrar()
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        Else
            MessageBox.Show("Cancelando eliminacion de usuarios", "Elimimando Usuario", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Call mostrar()
        End If
        Call limpiar()
    End Sub

    Private Sub botnuevopersona_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles botnuevopersona.Click
        Dim formpersona As New frmpersona
        formpersona.Show()
    End Sub
End Class