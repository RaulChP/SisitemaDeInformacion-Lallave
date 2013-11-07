<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmcategoria
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
        Me.textidcategoria = New System.Windows.Forms.TextBox()
        Me.Eliminar = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.datalistado = New System.Windows.Forms.DataGridView()
        Me.erroricono = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.cbocampo = New System.Windows.Forms.ComboBox()
        Me.textbuscar = New System.Windows.Forms.TextBox()
        Me.inexistente = New System.Windows.Forms.LinkLabel()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.cbeliminar = New System.Windows.Forms.CheckBox()
        Me.boteliminar = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        CType(Me.datalistado, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.erroricono, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
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
        Me.GroupBox1.Controls.Add(Me.textidcategoria)
        Me.GroupBox1.Location = New System.Drawing.Point(14, 39)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(367, 247)
        Me.GroupBox1.TabIndex = 2
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Mantenimiento"
        '
        'botguardar
        '
        Me.botguardar.Location = New System.Drawing.Point(157, 165)
        Me.botguardar.Name = "botguardar"
        Me.botguardar.Size = New System.Drawing.Size(75, 23)
        Me.botguardar.TabIndex = 7
        Me.botguardar.Text = "Guardar"
        Me.botguardar.UseVisualStyleBackColor = True
        '
        'botcancelar
        '
        Me.botcancelar.Location = New System.Drawing.Point(263, 165)
        Me.botcancelar.Name = "botcancelar"
        Me.botcancelar.Size = New System.Drawing.Size(75, 23)
        Me.botcancelar.TabIndex = 6
        Me.botcancelar.Text = "Cancelar"
        Me.botcancelar.UseVisualStyleBackColor = True
        '
        'boteditar
        '
        Me.boteditar.Location = New System.Drawing.Point(157, 165)
        Me.boteditar.Name = "boteditar"
        Me.boteditar.Size = New System.Drawing.Size(75, 23)
        Me.boteditar.TabIndex = 5
        Me.boteditar.Text = "Editar"
        Me.boteditar.UseVisualStyleBackColor = True
        '
        'botinsertar
        '
        Me.botinsertar.Location = New System.Drawing.Point(51, 165)
        Me.botinsertar.Name = "botinsertar"
        Me.botinsertar.Size = New System.Drawing.Size(75, 23)
        Me.botinsertar.TabIndex = 4
        Me.botinsertar.Text = "Insertar"
        Me.botinsertar.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(48, 89)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(63, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Descripcion"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(45, 44)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(55, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "IdCategria"
        '
        'textdescripcion
        '
        Me.textdescripcion.Location = New System.Drawing.Point(137, 82)
        Me.textdescripcion.Name = "textdescripcion"
        Me.textdescripcion.Size = New System.Drawing.Size(201, 20)
        Me.textdescripcion.TabIndex = 1
        '
        'textidcategoria
        '
        Me.textidcategoria.Location = New System.Drawing.Point(137, 37)
        Me.textidcategoria.Name = "textidcategoria"
        Me.textidcategoria.Size = New System.Drawing.Size(201, 20)
        Me.textidcategoria.TabIndex = 0
        '
        'Eliminar
        '
        Me.Eliminar.HeaderText = "Eliminar"
        Me.Eliminar.Name = "Eliminar"
        Me.Eliminar.ReadOnly = True
        '
        'datalistado
        '
        Me.datalistado.AllowUserToAddRows = False
        Me.datalistado.AllowUserToDeleteRows = False
        Me.datalistado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.datalistado.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Eliminar})
        Me.datalistado.Location = New System.Drawing.Point(38, 80)
        Me.datalistado.Name = "datalistado"
        Me.datalistado.ReadOnly = True
        Me.datalistado.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.datalistado.Size = New System.Drawing.Size(313, 130)
        Me.datalistado.TabIndex = 0
        '
        'erroricono
        '
        Me.erroricono.ContainerControl = Me
        '
        'cbocampo
        '
        Me.cbocampo.FormattingEnabled = True
        Me.cbocampo.Items.AddRange(New Object() {"descripcion"})
        Me.cbocampo.Location = New System.Drawing.Point(38, 31)
        Me.cbocampo.Name = "cbocampo"
        Me.cbocampo.Size = New System.Drawing.Size(109, 21)
        Me.cbocampo.TabIndex = 1
        Me.cbocampo.Text = "descripcion"
        '
        'textbuscar
        '
        Me.textbuscar.Location = New System.Drawing.Point(168, 30)
        Me.textbuscar.Name = "textbuscar"
        Me.textbuscar.Size = New System.Drawing.Size(182, 20)
        Me.textbuscar.TabIndex = 2
        '
        'inexistente
        '
        Me.inexistente.AutoSize = True
        Me.inexistente.Location = New System.Drawing.Point(113, 133)
        Me.inexistente.Name = "inexistente"
        Me.inexistente.Size = New System.Drawing.Size(93, 13)
        Me.inexistente.TabIndex = 3
        Me.inexistente.TabStop = True
        Me.inexistente.Text = "Datos inexistentes"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.cbeliminar)
        Me.GroupBox2.Controls.Add(Me.boteliminar)
        Me.GroupBox2.Controls.Add(Me.inexistente)
        Me.GroupBox2.Controls.Add(Me.textbuscar)
        Me.GroupBox2.Controls.Add(Me.cbocampo)
        Me.GroupBox2.Controls.Add(Me.datalistado)
        Me.GroupBox2.Location = New System.Drawing.Point(417, 41)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(381, 245)
        Me.GroupBox2.TabIndex = 3
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Listado de categorias"
        '
        'cbeliminar
        '
        Me.cbeliminar.AutoSize = True
        Me.cbeliminar.Location = New System.Drawing.Point(38, 57)
        Me.cbeliminar.Name = "cbeliminar"
        Me.cbeliminar.Size = New System.Drawing.Size(62, 17)
        Me.cbeliminar.TabIndex = 9
        Me.cbeliminar.Text = "Eliminar"
        Me.cbeliminar.UseVisualStyleBackColor = True
        '
        'boteliminar
        '
        Me.boteliminar.Location = New System.Drawing.Point(38, 216)
        Me.boteliminar.Name = "boteliminar"
        Me.boteliminar.Size = New System.Drawing.Size(75, 23)
        Me.boteliminar.TabIndex = 8
        Me.boteliminar.Text = "Eliminar"
        Me.boteliminar.UseVisualStyleBackColor = True
        '
        'frmcategoria
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(812, 331)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Name = "frmcategoria"
        Me.Text = "Listado de Categorias"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.datalistado, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.erroricono, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
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
    Friend WithEvents textidcategoria As System.Windows.Forms.TextBox
    Friend WithEvents Eliminar As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents datalistado As System.Windows.Forms.DataGridView
    Friend WithEvents erroricono As System.Windows.Forms.ErrorProvider
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents cbeliminar As System.Windows.Forms.CheckBox
    Friend WithEvents boteliminar As System.Windows.Forms.Button
    Friend WithEvents inexistente As System.Windows.Forms.LinkLabel
    Friend WithEvents textbuscar As System.Windows.Forms.TextBox
    Friend WithEvents cbocampo As System.Windows.Forms.ComboBox
End Class
