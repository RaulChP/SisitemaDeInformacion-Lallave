<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormUsuarioRoles
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
        Me.Label3 = New System.Windows.Forms.Label()
        Me.textidusuarioroles = New System.Windows.Forms.TextBox()
        Me.botnuevo = New System.Windows.Forms.Button()
        Me.botcancelar = New System.Windows.Forms.Button()
        Me.boteditar = New System.Windows.Forms.Button()
        Me.botinsertar = New System.Windows.Forms.Button()
        Me.textcodigo = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.textidusuario = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.checkeliminar = New System.Windows.Forms.CheckBox()
        Me.combobuscar = New System.Windows.Forms.ComboBox()
        Me.inexistente = New System.Windows.Forms.LinkLabel()
        Me.textbuscar = New System.Windows.Forms.TextBox()
        Me.gridusuarioroles = New System.Windows.Forms.DataGridView()
        Me.Eliminar = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.botelimnar = New System.Windows.Forms.Button()
        Me.erroricono = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.botnuevorol = New System.Windows.Forms.Button()
        Me.botnuevousuario = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.gridusuarioroles, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.erroricono, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.botnuevousuario)
        Me.GroupBox1.Controls.Add(Me.botnuevorol)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.textidusuarioroles)
        Me.GroupBox1.Controls.Add(Me.botnuevo)
        Me.GroupBox1.Controls.Add(Me.botcancelar)
        Me.GroupBox1.Controls.Add(Me.boteditar)
        Me.GroupBox1.Controls.Add(Me.botinsertar)
        Me.GroupBox1.Controls.Add(Me.textcodigo)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.textidusuario)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 66)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(345, 231)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Datos"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(15, 40)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(85, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Id Usuario Roles"
        '
        'textidusuarioroles
        '
        Me.textidusuarioroles.Location = New System.Drawing.Point(101, 37)
        Me.textidusuarioroles.Name = "textidusuarioroles"
        Me.textidusuarioroles.Size = New System.Drawing.Size(100, 20)
        Me.textidusuarioroles.TabIndex = 2
        '
        'botnuevo
        '
        Me.botnuevo.Location = New System.Drawing.Point(0, 193)
        Me.botnuevo.Name = "botnuevo"
        Me.botnuevo.Size = New System.Drawing.Size(75, 23)
        Me.botnuevo.TabIndex = 2
        Me.botnuevo.Text = "Nuevo"
        Me.botnuevo.UseVisualStyleBackColor = True
        '
        'botcancelar
        '
        Me.botcancelar.Location = New System.Drawing.Point(182, 193)
        Me.botcancelar.Name = "botcancelar"
        Me.botcancelar.Size = New System.Drawing.Size(75, 23)
        Me.botcancelar.TabIndex = 6
        Me.botcancelar.Text = "Cancelar"
        Me.botcancelar.UseVisualStyleBackColor = True
        '
        'boteditar
        '
        Me.boteditar.Location = New System.Drawing.Point(101, 193)
        Me.boteditar.Name = "boteditar"
        Me.boteditar.Size = New System.Drawing.Size(75, 23)
        Me.boteditar.TabIndex = 5
        Me.boteditar.Text = "Editar"
        Me.boteditar.UseVisualStyleBackColor = True
        '
        'botinsertar
        '
        Me.botinsertar.Location = New System.Drawing.Point(101, 164)
        Me.botinsertar.Name = "botinsertar"
        Me.botinsertar.Size = New System.Drawing.Size(75, 23)
        Me.botinsertar.TabIndex = 4
        Me.botinsertar.Text = "Insertar"
        Me.botinsertar.UseVisualStyleBackColor = True
        '
        'textcodigo
        '
        Me.textcodigo.Location = New System.Drawing.Point(101, 107)
        Me.textcodigo.Name = "textcodigo"
        Me.textcodigo.Size = New System.Drawing.Size(100, 20)
        Me.textcodigo.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(15, 114)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(59, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Codigo Rol"
        '
        'textidusuario
        '
        Me.textidusuario.Location = New System.Drawing.Point(101, 67)
        Me.textidusuario.Name = "textidusuario"
        Me.textidusuario.Size = New System.Drawing.Size(100, 20)
        Me.textidusuario.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(15, 74)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(55, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Id Usuario"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.checkeliminar)
        Me.GroupBox2.Controls.Add(Me.combobuscar)
        Me.GroupBox2.Controls.Add(Me.inexistente)
        Me.GroupBox2.Controls.Add(Me.textbuscar)
        Me.GroupBox2.Controls.Add(Me.gridusuarioroles)
        Me.GroupBox2.Controls.Add(Me.botelimnar)
        Me.GroupBox2.Location = New System.Drawing.Point(374, 12)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(341, 285)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Lista"
        '
        'checkeliminar
        '
        Me.checkeliminar.AutoSize = True
        Me.checkeliminar.Location = New System.Drawing.Point(19, 68)
        Me.checkeliminar.Name = "checkeliminar"
        Me.checkeliminar.Size = New System.Drawing.Size(62, 17)
        Me.checkeliminar.TabIndex = 12
        Me.checkeliminar.Text = "Eliminar"
        Me.checkeliminar.UseVisualStyleBackColor = True
        '
        'combobuscar
        '
        Me.combobuscar.FormattingEnabled = True
        Me.combobuscar.Items.AddRange(New Object() {"IdUsuarioRoles", "IdUsuario", "CodigoRol"})
        Me.combobuscar.Location = New System.Drawing.Point(19, 25)
        Me.combobuscar.Name = "combobuscar"
        Me.combobuscar.Size = New System.Drawing.Size(121, 21)
        Me.combobuscar.TabIndex = 11
        '
        'inexistente
        '
        Me.inexistente.AutoSize = True
        Me.inexistente.Location = New System.Drawing.Point(96, 133)
        Me.inexistente.Name = "inexistente"
        Me.inexistente.Size = New System.Drawing.Size(84, 13)
        Me.inexistente.TabIndex = 10
        Me.inexistente.TabStop = True
        Me.inexistente.Text = "Dato Inexistente"
        '
        'textbuscar
        '
        Me.textbuscar.Location = New System.Drawing.Point(159, 26)
        Me.textbuscar.Name = "textbuscar"
        Me.textbuscar.Size = New System.Drawing.Size(100, 20)
        Me.textbuscar.TabIndex = 9
        '
        'gridusuarioroles
        '
        Me.gridusuarioroles.AllowUserToAddRows = False
        Me.gridusuarioroles.AllowUserToDeleteRows = False
        Me.gridusuarioroles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.gridusuarioroles.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Eliminar})
        Me.gridusuarioroles.Location = New System.Drawing.Point(19, 91)
        Me.gridusuarioroles.Name = "gridusuarioroles"
        Me.gridusuarioroles.ReadOnly = True
        Me.gridusuarioroles.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.gridusuarioroles.Size = New System.Drawing.Size(300, 150)
        Me.gridusuarioroles.TabIndex = 8
        '
        'Eliminar
        '
        Me.Eliminar.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader
        Me.Eliminar.HeaderText = "Eliinar"
        Me.Eliminar.Name = "Eliminar"
        Me.Eliminar.ReadOnly = True
        Me.Eliminar.Width = 39
        '
        'botelimnar
        '
        Me.botelimnar.Location = New System.Drawing.Point(19, 247)
        Me.botelimnar.Name = "botelimnar"
        Me.botelimnar.Size = New System.Drawing.Size(75, 23)
        Me.botelimnar.TabIndex = 7
        Me.botelimnar.Text = "Eliminar"
        Me.botelimnar.UseVisualStyleBackColor = True
        '
        'erroricono
        '
        Me.erroricono.ContainerControl = Me
        '
        'botnuevorol
        '
        Me.botnuevorol.Location = New System.Drawing.Point(232, 104)
        Me.botnuevorol.Name = "botnuevorol"
        Me.botnuevorol.Size = New System.Drawing.Size(86, 23)
        Me.botnuevorol.TabIndex = 7
        Me.botnuevorol.Text = "Nuevo Rol"
        Me.botnuevorol.UseVisualStyleBackColor = True
        '
        'botnuevousuario
        '
        Me.botnuevousuario.Location = New System.Drawing.Point(232, 64)
        Me.botnuevousuario.Name = "botnuevousuario"
        Me.botnuevousuario.Size = New System.Drawing.Size(86, 23)
        Me.botnuevousuario.TabIndex = 8
        Me.botnuevousuario.Text = "Nuevo Usuario"
        Me.botnuevousuario.UseVisualStyleBackColor = True
        '
        'FormUsuarioRoles
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(727, 326)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "FormUsuarioRoles"
        Me.Text = "Formulario Usuario vs Roles"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.gridusuarioroles, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.erroricono, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents textcodigo As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents textidusuario As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents botcancelar As System.Windows.Forms.Button
    Friend WithEvents boteditar As System.Windows.Forms.Button
    Friend WithEvents botinsertar As System.Windows.Forms.Button
    Friend WithEvents textbuscar As System.Windows.Forms.TextBox
    Friend WithEvents gridusuarioroles As System.Windows.Forms.DataGridView
    Friend WithEvents botelimnar As System.Windows.Forms.Button
    Friend WithEvents inexistente As System.Windows.Forms.LinkLabel
    Friend WithEvents botnuevo As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents textidusuarioroles As System.Windows.Forms.TextBox
    Friend WithEvents combobuscar As System.Windows.Forms.ComboBox
    Friend WithEvents erroricono As System.Windows.Forms.ErrorProvider
    Friend WithEvents checkeliminar As System.Windows.Forms.CheckBox
    Friend WithEvents Eliminar As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents botnuevousuario As System.Windows.Forms.Button
    Friend WithEvents botnuevorol As System.Windows.Forms.Button
End Class
