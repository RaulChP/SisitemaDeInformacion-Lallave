<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormUsuario
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
        Me.botnuevopersona = New System.Windows.Forms.Button()
        Me.botnuevo = New System.Windows.Forms.Button()
        Me.texidpersona = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.botcancelar = New System.Windows.Forms.Button()
        Me.boteditar = New System.Windows.Forms.Button()
        Me.botinsertar = New System.Windows.Forms.Button()
        Me.textclave = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.textcontraseña = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.textidusuario = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.checkeliminar = New System.Windows.Forms.CheckBox()
        Me.combollave = New System.Windows.Forms.ComboBox()
        Me.inexistente = New System.Windows.Forms.LinkLabel()
        Me.textbuscar = New System.Windows.Forms.TextBox()
        Me.boteliminar = New System.Windows.Forms.Button()
        Me.gridusuario = New System.Windows.Forms.DataGridView()
        Me.Eliminar = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.erroricono = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.gridusuario, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.erroricono, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.botnuevopersona)
        Me.GroupBox1.Controls.Add(Me.botnuevo)
        Me.GroupBox1.Controls.Add(Me.texidpersona)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.botcancelar)
        Me.GroupBox1.Controls.Add(Me.boteditar)
        Me.GroupBox1.Controls.Add(Me.botinsertar)
        Me.GroupBox1.Controls.Add(Me.textclave)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.textcontraseña)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.textidusuario)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(28, 49)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(303, 253)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Datos"
        '
        'botnuevopersona
        '
        Me.botnuevopersona.Location = New System.Drawing.Point(206, 127)
        Me.botnuevopersona.Name = "botnuevopersona"
        Me.botnuevopersona.Size = New System.Drawing.Size(91, 23)
        Me.botnuevopersona.TabIndex = 12
        Me.botnuevopersona.Text = "Nueva Persona"
        Me.botnuevopersona.UseVisualStyleBackColor = True
        '
        'botnuevo
        '
        Me.botnuevo.Location = New System.Drawing.Point(-2, 169)
        Me.botnuevo.Name = "botnuevo"
        Me.botnuevo.Size = New System.Drawing.Size(75, 23)
        Me.botnuevo.TabIndex = 11
        Me.botnuevo.Text = "Nuevo"
        Me.botnuevo.UseVisualStyleBackColor = True
        '
        'texidpersona
        '
        Me.texidpersona.Location = New System.Drawing.Point(97, 129)
        Me.texidpersona.Name = "texidpersona"
        Me.texidpersona.Size = New System.Drawing.Size(100, 20)
        Me.texidpersona.TabIndex = 10
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(18, 129)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(58, 13)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "Id Persona"
        '
        'botcancelar
        '
        Me.botcancelar.Location = New System.Drawing.Point(206, 169)
        Me.botcancelar.Name = "botcancelar"
        Me.botcancelar.Size = New System.Drawing.Size(75, 23)
        Me.botcancelar.TabIndex = 8
        Me.botcancelar.Text = "Cancelar"
        Me.botcancelar.UseVisualStyleBackColor = True
        '
        'boteditar
        '
        Me.boteditar.Location = New System.Drawing.Point(97, 198)
        Me.boteditar.Name = "boteditar"
        Me.boteditar.Size = New System.Drawing.Size(75, 23)
        Me.boteditar.TabIndex = 7
        Me.boteditar.Text = "Editar"
        Me.boteditar.UseVisualStyleBackColor = True
        '
        'botinsertar
        '
        Me.botinsertar.Location = New System.Drawing.Point(97, 169)
        Me.botinsertar.Name = "botinsertar"
        Me.botinsertar.Size = New System.Drawing.Size(75, 23)
        Me.botinsertar.TabIndex = 6
        Me.botinsertar.Text = "Insertar"
        Me.botinsertar.UseVisualStyleBackColor = True
        '
        'textclave
        '
        Me.textclave.Location = New System.Drawing.Point(97, 100)
        Me.textclave.Name = "textclave"
        Me.textclave.Size = New System.Drawing.Size(100, 20)
        Me.textclave.TabIndex = 5
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(18, 103)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(73, 13)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Palabra Clave"
        '
        'textcontraseña
        '
        Me.textcontraseña.Location = New System.Drawing.Point(97, 64)
        Me.textcontraseña.Name = "textcontraseña"
        Me.textcontraseña.Size = New System.Drawing.Size(100, 20)
        Me.textcontraseña.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(18, 67)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(61, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Contraseña"
        '
        'textidusuario
        '
        Me.textidusuario.Location = New System.Drawing.Point(97, 29)
        Me.textidusuario.Name = "textidusuario"
        Me.textidusuario.Size = New System.Drawing.Size(100, 20)
        Me.textidusuario.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(18, 32)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(55, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Id Usuario"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.checkeliminar)
        Me.GroupBox2.Controls.Add(Me.combollave)
        Me.GroupBox2.Controls.Add(Me.inexistente)
        Me.GroupBox2.Controls.Add(Me.textbuscar)
        Me.GroupBox2.Controls.Add(Me.boteliminar)
        Me.GroupBox2.Controls.Add(Me.gridusuario)
        Me.GroupBox2.Location = New System.Drawing.Point(337, 15)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(395, 287)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Listado"
        '
        'checkeliminar
        '
        Me.checkeliminar.AutoSize = True
        Me.checkeliminar.Location = New System.Drawing.Point(35, 51)
        Me.checkeliminar.Name = "checkeliminar"
        Me.checkeliminar.Size = New System.Drawing.Size(62, 17)
        Me.checkeliminar.TabIndex = 13
        Me.checkeliminar.Text = "Eliminar"
        Me.checkeliminar.UseVisualStyleBackColor = True
        '
        'combollave
        '
        Me.combollave.FormattingEnabled = True
        Me.combollave.Items.AddRange(New Object() {"IdUsuario", "CI"})
        Me.combollave.Location = New System.Drawing.Point(61, 16)
        Me.combollave.Name = "combollave"
        Me.combollave.Size = New System.Drawing.Size(121, 21)
        Me.combollave.TabIndex = 12
        Me.combollave.Text = "CI"
        '
        'inexistente
        '
        Me.inexistente.AutoSize = True
        Me.inexistente.Location = New System.Drawing.Point(114, 117)
        Me.inexistente.Name = "inexistente"
        Me.inexistente.Size = New System.Drawing.Size(84, 13)
        Me.inexistente.TabIndex = 11
        Me.inexistente.TabStop = True
        Me.inexistente.Text = "Valor inexistente"
        '
        'textbuscar
        '
        Me.textbuscar.Location = New System.Drawing.Point(212, 19)
        Me.textbuscar.Name = "textbuscar"
        Me.textbuscar.Size = New System.Drawing.Size(100, 20)
        Me.textbuscar.TabIndex = 10
        '
        'boteliminar
        '
        Me.boteliminar.Location = New System.Drawing.Point(28, 249)
        Me.boteliminar.Name = "boteliminar"
        Me.boteliminar.Size = New System.Drawing.Size(75, 23)
        Me.boteliminar.TabIndex = 9
        Me.boteliminar.Text = "Eliminar"
        Me.boteliminar.UseVisualStyleBackColor = True
        '
        'gridusuario
        '
        Me.gridusuario.AllowUserToAddRows = False
        Me.gridusuario.AllowUserToDeleteRows = False
        Me.gridusuario.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader
        Me.gridusuario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.gridusuario.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Eliminar})
        Me.gridusuario.Location = New System.Drawing.Point(28, 76)
        Me.gridusuario.Name = "gridusuario"
        Me.gridusuario.ReadOnly = True
        Me.gridusuario.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.gridusuario.Size = New System.Drawing.Size(343, 150)
        Me.gridusuario.TabIndex = 0
        '
        'Eliminar
        '
        Me.Eliminar.HeaderText = "Eliminar"
        Me.Eliminar.Name = "Eliminar"
        Me.Eliminar.ReadOnly = True
        Me.Eliminar.Width = 47
        '
        'erroricono
        '
        Me.erroricono.ContainerControl = Me
        '
        'FormUsuario
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(752, 314)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "FormUsuario"
        Me.Text = "Formulario Usuario"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.gridusuario, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.erroricono, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents textclave As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents textcontraseña As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents textidusuario As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents gridusuario As System.Windows.Forms.DataGridView
    Friend WithEvents Eliminar As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents botcancelar As System.Windows.Forms.Button
    Friend WithEvents boteditar As System.Windows.Forms.Button
    Friend WithEvents botinsertar As System.Windows.Forms.Button
    Friend WithEvents inexistente As System.Windows.Forms.LinkLabel
    Friend WithEvents textbuscar As System.Windows.Forms.TextBox
    Friend WithEvents boteliminar As System.Windows.Forms.Button
    Friend WithEvents combollave As System.Windows.Forms.ComboBox
    Friend WithEvents texidpersona As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents erroricono As System.Windows.Forms.ErrorProvider
    Friend WithEvents botnuevo As System.Windows.Forms.Button
    Friend WithEvents checkeliminar As System.Windows.Forms.CheckBox
    Friend WithEvents botnuevopersona As System.Windows.Forms.Button
End Class
