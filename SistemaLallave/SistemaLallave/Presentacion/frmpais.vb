Public Class frmpais

    Private dt As New DataTable

    Private Sub frmpais_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        mostrar()

    End Sub



    Public Sub limpiar()
        botinsertar.Visible = True
        boteditar.Visible = False
        textnombre.Text = ""
        textdescripcion.Text = ""
        textidpais.Text = ""

    End Sub

    Private Sub mostrar()
        Try
            Dim func As New fpais
            dt = func.mostrar
            datalistado.Columns.Item("Eliminar").Visible = False
            If dt.Rows.Count <> 0 Then
                datalistado.DataSource = dt
                textbuscar.Enabled = True
                datalistado.ColumnHeadersVisible = True
                inexistente.Visible = False
            Else
                datalistado.DataSource = Nothing
                textbuscar.Enabled = False
                datalistado.ColumnHeadersVisible = False
                inexistente.Visible = True

            End If

        Catch ex As Exception
            MsgBox(ex.Message)

        End Try
        botnuevo.Visible = True
        boteditar.Visible = False

        'buscar()

    End Sub

    'Private Sub buscar()
    '    Try
    '        Dim ds As New DataSet
    '        ds.Tables.Add(dt.Copy)
    '        Dim dv As New DataView(ds.Tables(0))

    '        dv.RowFilter = cbocampo.Text & "like'" & textbuscar.Text & "%'"

    '        If dv.Count <> 0 Then
    '            inexistente.Visible = False
    '            datalistado.DataSource = dv
    '            ocultar_columnas()
    '        Else
    '            inexistente.Visible = True
    '            datalistado.DataSource = Nothing
    '        End If

    '    Catch ex As Exception
    '        MsgBox(ex.Message)
    '    End Try
    'End Sub

    Private Sub ocultar_columnas()
        datalistado.Columns(1).Visible = False
    End Sub

    Private Sub textdescripcion_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles textdescripcion.Validating

        If DirectCast(sender, TextBox).Text.Length > 0 Then

            Me.erroricono.SetError(sender, "")
        Else
            Me.erroricono.SetError(sender, "Ingrese la descripcion del pais por favor. Este dato es obligatorio")
        End If
    End Sub

    Private Sub GroupBox1_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GroupBox1.Enter

    End Sub

    Private Sub botinsertar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles botnuevo.Click
        limpiar()
        mostrar()

    End Sub

    Private Sub botguardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles botinsertar.Click
        If Me.ValidateChildren = True And textnombre.Text <> "" And textdescripcion.Text <> "" Then
            Try
                Dim dts As New vpais
                Dim func As New fpais

                dts.gnombre = textnombre.Text
                dts.gdescripcion = textdescripcion.Text

                If func.insertar(dts) Then
                    MessageBox.Show("Pais registrado correctamente", "Guardando registros", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    mostrar()
                    limpiar()
                Else
                    MessageBox.Show("Pais no fue registrado correctamente", "Intente de nuevo", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    mostrar()
                    limpiar()
                End If

            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        Else
            MessageBox.Show("Falta ingresar algunos datos", "Intente de nuevo", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub datalistado_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles datalistado.CellClick
        textidpais.Text = datalistado.SelectedCells.Item(1).Value
        textnombre.Text = datalistado.SelectedCells.Item(2).Value
        textdescripcion.Text = datalistado.SelectedCells.Item(3).Value

        boteditar.Visible = True
        botinsertar.Visible = False


    End Sub

    Private Sub datalistado_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles datalistado.CellContentClick
        If e.ColumnIndex = Me.datalistado.Columns.Item("Eliminar").Index Then
            Dim chkcell As DataGridViewCheckBoxCell = Me.datalistado.Rows(e.RowIndex).Cells("Eliminar")
            chkcell.Value = Not chkcell.Value

        End If
    End Sub

    Private Sub boteditar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles boteditar.Click
        Dim result As DialogResult

        result = MessageBox.Show("Realmente desea editar los datos del pais?", "Modificando registros", MessageBoxButtons.OKCancel, MessageBoxIcon.Question)

        If result = DialogResult.OK Then

            If Me.ValidateChildren = True And textnombre.Text <> "" And textidpais.Text <> "" And textdescripcion.Text <> "" Then

                Try
                    Dim dts As New vpais
                    Dim func As New fpais

                    dts.gidpais = textidpais.Text
                    dts.gnombre = textnombre.Text
                    dts.gdescripcion = textdescripcion.Text

                    If func.editar(dts) Then
                        MessageBox.Show("Pais modificado correctamente", "Modificando registros", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        mostrar()
                        limpiar()
                    Else
                        MessageBox.Show("Pais no fue modificado correctamente", "Modificando registros", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        mostrar()
                        limpiar()
                    End If

                Catch ex As Exception
                    MsgBox(ex.Message)
                End Try
            Else
                MessageBox.Show("Falta ingresar algunos datos", "Modificando registros", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        End If

    End Sub

    Private Sub cbeliminar_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbeliminar.CheckedChanged
        If cbeliminar.CheckState = CheckState.Checked Then
            datalistado.Columns.Item("Eliminar").Visible = True
        Else
            datalistado.Columns.Item("Eliminar").Visible = False
        End If
    End Sub

    Private Sub boteliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles boteliminar.Click

        Dim result As DialogResult
        result = MessageBox.Show("Realmente desea eliminar los paises seleccionados?", "Eliminando roles", MessageBoxButtons.OKCancel, MessageBoxIcon.Question)

        If result = DialogResult.OK Then
            Try
                For Each row As DataGridViewRow In datalistado.Rows
                    Dim marcado As Boolean = Convert.ToBoolean(row.Cells("Eliminar").Value)

                    If marcado Then
                        Dim onekey As Integer = Convert.ToInt32(row.Cells("idpais").Value)
                        Dim vdb As New vpais
                        Dim func As New fpais

                        vdb.gidpais = onekey

                        If func.eliminar(vdb) Then
                        Else
                            MessageBox.Show("Pais no fue eliminado", "Eliminando registros", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        End If
                    End If
                Next
                Call mostrar()

            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        Else
            MessageBox.Show("Cancelando eliminacion de registros", "Eliminando registros", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Call mostrar()
        End If
        Call limpiar()
    End Sub

    Private Sub textnombre_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles textnombre.Validating

        If DirectCast(sender, TextBox).Text.Length > 0 Then

            Me.erroricono.SetError(sender, "")
        Else
            Me.erroricono.SetError(sender, "Ingrese el nombre del pais por favor. Este dato es obligatorio")
        End If
    End Sub


    Private Sub textidpais_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles textidpais.TextChanged
        If DirectCast(sender, TextBox).Text.Length > 0 Then

            Me.erroricono.SetError(sender, "")
        Else
            Me.erroricono.SetError(sender, "Ingrese el codigo del pais por favor. Este dato es obligatorio")
        End If
    End Sub

End Class