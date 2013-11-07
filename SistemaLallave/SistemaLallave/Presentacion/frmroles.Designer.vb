<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmroles
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.botguardar = New System.Windows.Forms.Button()
        Me.botcancelar = New System.Windows.Forms.Button()
        Me.boteditar = New System.Windows.Forms.Button()
        Me.botinsertar = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.textdescripcion = New System.Windows.Forms.TextBox()
        Me.textcodigo = New System.Windows.Forms.TextBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.boteliminar = New System.Windows.Forms.Button()
        Me.inexistente = New System.Windows.Forms.LinkLabel()
        Me.textbuscar = New System.Windows.Forms.TextBox()
        Me.cbocampo = New System.Windows.Forms.ComboBox()
        Me.datalistado = New System.Windows.Forms.DataGridView()
        Me.Eliminar = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.erroricono = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.cbeliminar = New System.Windows.Forms.CheckBox()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.datalistado, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.erroricono, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.botguardar)
        Me.GroupBox1.Controls.Add(Me.botcancelar)
        Me.GroupBox1.Controls.Add(Me.boteditar)
        Me.GroupBox1.Controls.Add(Me.botinsertar)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.textdescripcion)
        Me.GroupBox1.Controls.Add(Me.textcodigo)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 34)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(367, 247)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Mantenimiento"
        '
        'botguardar
        '
        Me.botguardar.Location = New System.Drawing.Point(139, 165)
        Me.botguardar.Name = "botguardar"
        Me.botguardar.Size = New System.Drawing.Size(75, 23)
        Me.botguardar.TabIndex = 7
        Me.botguardar.Text = "Guardar"
        Me.botguardar.UseVisualStyleBackColor = True
        '
        'botcancelar
        '
        Me.botcancelar.Location = New System.Drawing.Point(245, 165)
        Me.botcancelar.Name = "botcancelar"
        Me.botcancelar.Size = New System.Drawing.Size(75, 23)
        Me.botcancelar.TabIndex = 6
        Me.botcancelar.Text = "Cancelar"
        Me.botcancelar.UseVisualStyleBackColor = True
        '
        'boteditar
        '
        Me.boteditar.Location = New System.Drawing.Point(139, 165)
        Me.boteditar.Name = "boteditar"
        Me.boteditar.Size = New System.Drawing.Size(75, 23)
        Me.boteditar.TabIndex = 5
        Me.boteditar.Text = "Editar"
        Me.boteditar.UseVisualStyleBackColor = True
        '
        'botinsertar
        '
        Me.botinsertar.Location = New System.Drawing.Point(33, 165)
        Me.botinsertar.Name = "botinsertar"
        Me.botinsertar.Size = New System.Drawing.Size(75, 23)
        Me.botinsertar.TabIndex = 4
        Me.botinsertar.Text = "Insertar"
        Me.botinsertar.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(30, 89)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(63, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Descripcion"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(27, 44)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(40, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Codigo"
        '
        'textdescripcion
        '
        Me.textdescripcion.Location = New System.Drawing.Point(119, 82)
        Me.textdescripcion.Name = "textdescripcion"
        Me.textdescripcion.Size = New System.Drawing.Size(201, 20)
        Me.textdescripcion.TabIndex = 1
        '
        'textcodigo
        '
        Me.textcodigo.Location = New System.Drawing.Point(119, 37)
        Me.textcodigo.Name = "textcodigo"
        Me.textcodigo.Size = New System.Drawing.Size(201, 20)
        Me.textcodigo.TabIndex = 0
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.cbeliminar)
        Me.GroupBox2.Controls.Add(Me.boteliminar)
        Me.GroupBox2.Controls.Add(Me.inexistente)
        Me.GroupBox2.Controls.Add(Me.textbuscar)
        Me.GroupBox2.Controls.Add(Me.cbocampo)
        Me.GroupBox2.Controls.Add(Me.datalistado)
        Me.GroupBox2.Location = New System.Drawing.Point(415, 36)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(381, 245)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Listado de roles"
        '
        'boteliminar
        '
        Me.boteliminar.Location = New System.Drawing.Point(20, 216)
        Me.boteliminar.Name = "boteliminar"
        Me.boteliminar.Size = New System.Drawing.Size(75, 23)
        Me.boteliminar.TabIndex = 8
        Me.boteliminar.Text = "Eliminar"
        Me.boteliminar.UseVisualStyleBackColor = True
        '
        'inexistente
        '
        Me.inexistente.AutoSize = True
        Me.inexistente.Location = New System.Drawing.Point(95, 133)
        Me.inexistente.Name = "inexistente"
        Me.inexistente.Size = New System.Drawing.Size(93, 13)
        Me.inexistente.TabIndex = 3
        Me.inexistente.TabStop = True
        Me.inexistente.Text = "Datos inexistentes"
        '
        'textbuscar
        '
        Me.textbuscar.Location = New System.Drawing.Point(150, 30)
        Me.textbuscar.Name = "textbuscar"
        Me.textbuscar.Size = New System.Drawing.Size(182, 20)
        Me.textbuscar.TabIndex = 2
        '
        'cbocampo
        '
        Me.cbocampo.FormattingEnabled = True
        Me.cbocampo.Items.AddRange(New Object() {"codigo", "descripcion"})
        Me.cbocampo.Location = New System.Drawing.Point(20, 31)
        Me.cbocampo.Name = "cbocampo"
        Me.cbocampo.Size = New System.Drawing.Size(109, 21)
        Me.cbocampo.TabIndex = 1
        Me.cbocampo.Text = "codigo"
        '
        'datalistado
        '
        Me.datalistado.AllowUserToAddRows = False
        Me.datalistado.AllowUserToDeleteRows = False
        Me.datalistado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.datalistado.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Eliminar})
        Me.datalistado.Location = New System.Drawing.Point(20, 80)
        Me.datalistado.Name = "datalistado"
        Me.datalistado.ReadOnly = True
        Me.datalistado.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.datalistado.Size = New System.Drawing.Size(313, 130)
        Me.datalistado.TabIndex = 0
        '
        'Eliminar
        '
        Me.Eliminar.HeaderText = "Eliminar"
        Me.Eliminar.Name = "Eliminar"
        Me.Eliminar.ReadOnly = True
        '
        'erroricono
        '
        Me.erroricono.ContainerControl = Me
        '
        'cbeliminar
        '
        Me.cbeliminar.AutoSize = True
        Me.cbeliminar.Location = New System.Drawing.Point(20, 57)
        Me.cbeliminar.Name = "cbeliminar"
        Me.cbeliminar.Size = New System.Drawing.Size(62, 17)
        Me.cbeliminar.TabIndex = 9
        Me.cbeliminar.Text = "Eliminar"
        Me.cbeliminar.UseVisualStyleBackColor = True
        '
        'frmroles
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(821, 352)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "frmroles"
        Me.Text = "frmroles"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.datalistado, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.erroricono, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents botguardar As System.Windows.Forms.Button
    Friend WithEvents botcancelar As System.Windows.Forms.Button
    Friend WithEvents boteditar As System.Windows.Forms.Button
    Friend WithEvents botinsertar As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents textdescripcion As System.Windows.Forms.TextBox
    Friend WithEvents textcodigo As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents boteliminar As System.Windows.Forms.Button
    Friend WithEvents inexistente As System.Windows.Forms.LinkLabel
    Friend WithEvents textbuscar As System.Windows.Forms.TextBox
    Friend WithEvents cbocampo As System.Windows.Forms.ComboBox
    Friend WithEvents datalistado As System.Windows.Forms.DataGridView
    Friend WithEvents Eliminar As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents erroricono As System.Windows.Forms.ErrorProvider
    Friend WithEvents cbeliminar As System.Windows.Forms.CheckBox
End Class
