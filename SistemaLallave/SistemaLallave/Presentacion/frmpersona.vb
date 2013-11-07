
Public Class frmpersona

    Private dt As New DataTable

    Private Sub frmpersona_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        mostrar()

    End Sub

    Public Sub limpiar()
        botguardar.Visible = True
        boteditar.Visible = False
        textnombre.Text = ""
        textci.Text = ""
        textidpersona.Text = ""
        textidpais.Text = ""
        textdireccion.Text = ""
        texttelefono.Text = ""
        textlocalidad.Text = ""
        textcodigopostal.Text = ""

    End Sub

    Private Sub mostrar()
        Try
            Dim func As New fpersona
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
        botinsertar.Visible = True
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


    Private Sub botinsertar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles botinsertar.Click
        limpiar()
        mostrar()

    End Sub

    Private Sub botguardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles botguardar.Click
        If Me.ValidateChildren = True And textnombre.Text <> "" And textci.Text <> "" And textdireccion.Text <> "" And texttelefono.Text <> "" And textidpais.Text <> "" And textlocalidad.Text <> "" And textcodigopostal.Text <> "" Then
            Try
                Dim dts As New vpersona
                Dim func As New fpersona

                dts.gnombre = textnombre.Text
                dts.gci = textci.Text
                dts.gdireccion = textdireccion.Text
                dts.gtelefono = texttelefono.Text
                dts.gidpais = textidpais.Text
                dts.glocalidad = textlocalidad.Text
                dts.gcodigopostal = textcodigopostal.Text

                If func.insertar(dts) Then
                    MessageBox.Show("Persona registrada correctamente", "Guardando registros", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    mostrar()
                    limpiar()
                Else
                    MessageBox.Show("Persona no fue registrada correctamente", "Intente de nuevo", MessageBoxButtons.OK, MessageBoxIcon.Error)
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

        textidpersona.Text = datalistado.SelectedCells.Item(1).Value
        textnombre.Text = datalistado.SelectedCells.Item(2).Value
        textci.Text = datalistado.SelectedCells.Item(3).Value
        textdireccion.Text = datalistado.SelectedCells.Item(4).Value
        texttelefono.Text = datalistado.SelectedCells.Item(5).Value
        textlocalidad.Text = datalistado.SelectedCells.Item(6).Value
        textcodigopostal.Text = datalistado.SelectedCells.Item(7).Value
        textidpais.Text = datalistado.SelectedCells.Item(8).Value

        boteditar.Visible = True
        botguardar.Visible = False


    End Sub

    Private Sub datalistado_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles datalistado.CellContentClick
        If e.ColumnIndex = Me.datalistado.Columns.Item("Eliminar").Index Then
            Dim chkcell As DataGridViewCheckBoxCell = Me.datalistado.Rows(e.RowIndex).Cells("Eliminar")
            chkcell.Value = Not chkcell.Value

        End If
    End Sub

    Private Sub boteditar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles boteditar.Click
        Dim result As DialogResult

        result = MessageBox.Show("Realmente desea editar los datos de la persona?", "Modificando registros", MessageBoxButtons.OKCancel, MessageBoxIcon.Question)

        If result = DialogResult.OK Then

            If Me.ValidateChildren = True And textnombre.Text <> "" And textidpersona.Text <> "" And textci.Text <> "" And textdireccion.Text <> "" And texttelefono.Text <> "" And textlocalidad.Text <> "" And textcodigopostal.Text <> "" And textidpais.Text <> "" Then

                Try
                    Dim dts As New vpersona
                    Dim func As New fpersona

                    dts.gidpersona = textidpersona.Text
                    dts.gnombre = textnombre.Text
                    dts.gci = textci.Text
                    dts.gdireccion = textdireccion.Text
                    dts.gtelefono = texttelefono.Text
                    dts.glocalidad = textlocalidad.Text
                    dts.gcodigopostal = textcodigopostal.Text
                    dts.gidpais = textidpais.Text

                    If func.editar(dts) Then
                        MessageBox.Show("Persona modificada correctamente", "Modificando registros", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        mostrar()
                        limpiar()
                    Else
                        MessageBox.Show("Persona no fue modificada correctamente", "Modificando registros", MessageBoxButtons.OK, MessageBoxIcon.Error)
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
        result = MessageBox.Show("Realmente desea eliminar las personas seleccionadas?", "Eliminando personas", MessageBoxButtons.OKCancel, MessageBoxIcon.Question)

        If result = DialogResult.OK Then
            Try
                For Each row As DataGridViewRow In datalistado.Rows
                    Dim marcado As Boolean = Convert.ToBoolean(row.Cells("Eliminar").Value)

                    If marcado Then
                        Dim onekey As Integer = Convert.ToInt32(row.Cells("idpersona").Value)
                        Dim vdb As New vpersona
                        Dim func As New fpersona

                        vdb.gidpais = onekey

                        If func.eliminar(vdb) Then
                        Else
                            MessageBox.Show("Persona no fue eliminada", "Eliminando registros", MessageBoxButtons.OK, MessageBoxIcon.Information)
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
            Me.erroricono.SetError(sender, "Ingrese el nombre de la persona por favor. Este dato es obligatorio")
        End If
    End Sub

    Private Sub textci_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles textci.TextChanged

    End Sub

    Private Sub textci_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles textci.Validating
        If DirectCast(sender, TextBox).Text.Length > 0 Then

            Me.erroricono.SetError(sender, "")
        Else
            Me.erroricono.SetError(sender, "Ingrese el carnet de identidad de la persona por favor. Este dato es obligatorio")
        End If
    End Sub

    Private Sub texttelefono_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles texttelefono.TextChanged

    End Sub

    Private Sub texttelefono_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles texttelefono.Validating
        If DirectCast(sender, TextBox).Text.Length > 0 Then

            Me.erroricono.SetError(sender, "")
        Else
            Me.erroricono.SetError(sender, "Ingrese el telefono de la persona por favor. Este dato es obligatorio")
        End If
    End Sub

End Class

