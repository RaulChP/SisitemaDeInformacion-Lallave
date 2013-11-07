Public Class FormUsuarioRoles
    Private dt As DataTable
    Private Sub FormUsuarioRoles_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        mostrar()
    End Sub
    Public Sub limpiar()
        botinsertar.Visible = True
        boteditar.Visible = False
        textidusuario.Text = ""
        textcodigo.Text = ""
    End Sub

    Private Sub mostrar()
        Try
            Dim func As New fusuarioroles
            dt = func.Mostrar
            gridusuarioroles.Columns.Item("Eliminar").Visible = False

            If dt.Rows.Count <> 0 Then
                gridusuarioroles.DataSource = dt
                textbuscar.Enabled = True
                gridusuarioroles.ColumnHeadersVisible = True
                inexistente.Visible = False
            Else
                gridusuarioroles.DataSource = Nothing
                textbuscar.Enabled = False
                gridusuarioroles.ColumnHeadersVisible = False
                inexistente.Visible = True
            End If
        Catch ex As Exception
            MsgBox(ex.Message)

        End Try
        botnuevo.Visible = True
        botinsertar.Visible = False
        boteditar.Visible = False
        botelimnar.Visible = False
        botnuevousuario.Visible = False
        botnuevorol.Visible = False
        ' buscar()
    End Sub
    Public Sub mostrar_usuario()
        Try
            Dim func As New fusuario
            dt = func.Mostrar
            gridusuarioroles.Columns.Item("Eliminar").Visible = False
            If dt.Rows.Count <> 0 Then
                gridusuarioroles.DataSource = dt
                textbuscar.Enabled = True
                gridusuarioroles.ColumnHeadersVisible = True
                inexistente.Visible = False
            Else
                gridusuarioroles.DataSource = Nothing
                textbuscar.Enabled = False
                gridusuarioroles.ColumnHeadersVisible = False
                inexistente.Visible = True
            End If
        Catch ex As Exception
            MsgBox(ex.Message)

        End Try
        ' buscar()
    End Sub

    Private Sub textidusuario_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles textidusuario.Click
        If botinsertar.Visible = True Then
            mostrar_usuario()
        End If
    End Sub

    Private Sub textidusuario_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles textidusuario.TextChanged

    End Sub

    Private Sub textidusuario_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles textidusuario.Validating
        If DirectCast(sender, TextBox).Text.Length > 0 Then
            Me.erroricono.SetError(sender, "")
        Else
            Me.erroricono.SetError(sender, "Ingrese Datos")
        End If
    End Sub

    Private Sub textcodigo_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles textcodigo.TextChanged

    End Sub

    Private Sub textcodigo_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles textcodigo.Validating
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
        botnuevousuario.Visible = True
        botnuevorol.Visible = True
    End Sub

    Private Sub botinsertar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles botinsertar.Click
        If Me.ValidateChildren = True And textidusuario.Text <> "" And textcodigo.Text <> "" Then
            Try
                Dim dts As New vusuarioroles
                Dim fun As New fusuarioroles
                dts.gidusuario = textidusuario.Text
                dts.gcodigorol = textcodigo.Text

                If fun.Insertar(dts) Then
                    MessageBox.Show("Usuario-Roles registrado correctamente", "Guardar Usuario-Roles", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    mostrar()
                    limpiar()
                Else
                    MessageBox.Show("Usuario-Roles no fue registrado", "Guardar Usuario-Roles", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If

            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        Else
            MessageBox.Show("Faltan Datos", "Guardar Usuario-Roles", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub gridusuarioroles_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles gridusuarioroles.CellClick
        textidusuarioroles.Text = gridusuarioroles.SelectedCells.Item(1).Value
        textidusuario.Text = gridusuarioroles.SelectedCells.Item(2).Value
        textcodigo.Text = gridusuarioroles.SelectedCells.Item(3).Value
        boteditar.Visible = True
        botinsertar.Visible = False
    End Sub

    Private Sub gridusuarioroles_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles gridusuarioroles.CellContentClick
        If e.ColumnIndex = Me.gridusuarioroles.Columns.Item("Eliminar").Index Then
            Dim checkcell As DataGridViewCheckBoxCell = Me.gridusuarioroles.Rows(e.RowIndex).Cells("Eliminar")
            checkcell.Value = Not checkcell.Value
        End If
    End Sub

    Private Sub boteditar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles boteditar.Click
        Dim resultado As DialogResult

        resultado = MessageBox.Show("Desea Modificar registro", "Modificar Registro", MessageBoxButtons.OKCancel, MessageBoxIcon.Question)

        If resultado = DialogResult.OK Then

            If Me.ValidateChildren = True And textidusuario.Text <> "" And textcodigo.Text <> "" And textidusuarioroles.Text <> "" Then
                Try
                    Dim dts As New vusuarioroles
                    Dim fun As New fusuarioroles

                    dts.gidusuarioroles = textidusuarioroles.Text
                    dts.gidusuario = textidusuario.Text
                    dts.gcodigorol = textcodigo.Text

                    If fun.Editar(dts) Then
                        MessageBox.Show("Usuario-Roles modificado correctamente", "Modificar Usuario-Roles", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        mostrar()
                        limpiar()
                    Else
                        MessageBox.Show("Usuario-Roles no fue modificado", "Modificiar Usuario-Roles", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End If

                Catch ex As Exception
                    MsgBox(ex.Message)
                End Try
            Else
                MessageBox.Show("Faltan Datos", "Modificar Usuario-Roles", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        End If
    End Sub

    Private Sub checkeliminar_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles checkeliminar.CheckedChanged
        If checkeliminar.CheckState = CheckState.Checked Then
            gridusuarioroles.Columns.Item("Eliminar").Visible = True
            botelimnar.Visible = True
        Else
            gridusuarioroles.Columns.Item("Eliminar").Visible = False
            botelimnar.Visible = False
        End If
    End Sub

    Private Sub botelimnar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles botelimnar.Click
        Dim resultado As DialogResult
        resultado = MessageBox.Show("Desea eliminar usuario-rol seleccionados", "Elimimando Usuario-Roles", MessageBoxButtons.OKCancel, MessageBoxIcon.Question)

        If resultado = DialogResult.OK Then
            Try
                For Each row As DataGridViewRow In gridusuarioroles.Rows
                    Dim marcado As Boolean = Convert.ToBoolean(row.Cells("Eliminar").Value)
                    If marcado Then
                        Dim llave As Integer = Convert.ToInt32(row.Cells("idusuarioroles").Value)
                        Dim lallavedb As New vusuarioroles
                        Dim func As New fusuarioroles
                        lallavedb.gidusuarioroles = llave
                        If func.eliminar(lallavedb) Then
                        Else
                            MessageBox.Show("Usuario-Roles no eliminado", "Elimimando Usuario-Roles", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        End If
                    End If
                Next
                Call mostrar()
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        Else
            MessageBox.Show("Cancelando eliminacion de usuario-roles", "Elimimando Usuario-Roles", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Call mostrar()
        End If
        Call limpiar()
    End Sub

    Private Sub botnuevousuario_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles botnuevousuario.Click
        Dim formusuario As New FormUsuario
        formusuario.Show()
    End Sub
End Class