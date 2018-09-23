<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmcliente
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmcliente))
        Me.btnguardar = New System.Windows.Forms.GroupBox()
        Me.btnbuscar_categoria = New System.Windows.Forms.Button()
        Me.txtap_materno = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.btncancelar = New System.Windows.Forms.Button()
        Me.btneditar = New System.Windows.Forms.Button()
        Me.btnnuevo = New System.Windows.Forms.Button()
        Me.txttelefono = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtap_paterno = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtnombre = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtdireccion = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtidecliente = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.cbeliminar = New System.Windows.Forms.CheckBox()
        Me.btneliminar = New System.Windows.Forms.Button()
        Me.inexistente = New System.Windows.Forms.LinkLabel()
        Me.txtbuscar = New System.Windows.Forms.TextBox()
        Me.cbocampo = New System.Windows.Forms.ComboBox()
        Me.datalistado = New System.Windows.Forms.DataGridView()
        Me.Eliminar = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.erroricono = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.btnguardar.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.datalistado, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.erroricono, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnguardar
        '
        Me.btnguardar.BackColor = System.Drawing.Color.Transparent
        Me.btnguardar.Controls.Add(Me.btnbuscar_categoria)
        Me.btnguardar.Controls.Add(Me.txtap_materno)
        Me.btnguardar.Controls.Add(Me.Label7)
        Me.btnguardar.Controls.Add(Me.Button1)
        Me.btnguardar.Controls.Add(Me.btncancelar)
        Me.btnguardar.Controls.Add(Me.btneditar)
        Me.btnguardar.Controls.Add(Me.btnnuevo)
        Me.btnguardar.Controls.Add(Me.txttelefono)
        Me.btnguardar.Controls.Add(Me.Label5)
        Me.btnguardar.Controls.Add(Me.txtap_paterno)
        Me.btnguardar.Controls.Add(Me.Label4)
        Me.btnguardar.Controls.Add(Me.txtnombre)
        Me.btnguardar.Controls.Add(Me.Label3)
        Me.btnguardar.Controls.Add(Me.txtdireccion)
        Me.btnguardar.Controls.Add(Me.Label2)
        Me.btnguardar.Controls.Add(Me.txtidecliente)
        Me.btnguardar.Controls.Add(Me.Label1)
        Me.btnguardar.Font = New System.Drawing.Font("Century", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.btnguardar.ForeColor = System.Drawing.Color.Black
        Me.btnguardar.Location = New System.Drawing.Point(23, 39)
        Me.btnguardar.Name = "btnguardar"
        Me.btnguardar.Size = New System.Drawing.Size(425, 365)
        Me.btnguardar.TabIndex = 17
        Me.btnguardar.TabStop = False
        Me.btnguardar.Text = "Mantenimiento"
        '
        'btnbuscar_categoria
        '
        Me.btnbuscar_categoria.Location = New System.Drawing.Point(348, 178)
        Me.btnbuscar_categoria.Name = "btnbuscar_categoria"
        Me.btnbuscar_categoria.Size = New System.Drawing.Size(49, 22)
        Me.btnbuscar_categoria.TabIndex = 22
        Me.btnbuscar_categoria.Text = "..."
        Me.btnbuscar_categoria.UseVisualStyleBackColor = True
        '
        'txtap_materno
        '
        Me.txtap_materno.Location = New System.Drawing.Point(115, 110)
        Me.txtap_materno.Name = "txtap_materno"
        Me.txtap_materno.Size = New System.Drawing.Size(227, 23)
        Me.txtap_materno.TabIndex = 17
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(22, 117)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(71, 16)
        Me.Label7.TabIndex = 16
        Me.Label7.Text = "Apellido M"
        '
        'Button1
        '
        Me.Button1.Image = Global.RefaccionesSuzuki.My.Resources.Resources.guardar
        Me.Button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button1.Location = New System.Drawing.Point(115, 278)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(93, 22)
        Me.Button1.TabIndex = 15
        Me.Button1.Text = "  Guardar"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'btncancelar
        '
        Me.btncancelar.Image = Global.RefaccionesSuzuki.My.Resources.Resources._error
        Me.btncancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btncancelar.Location = New System.Drawing.Point(215, 278)
        Me.btncancelar.Name = "btncancelar"
        Me.btncancelar.Size = New System.Drawing.Size(85, 22)
        Me.btncancelar.TabIndex = 14
        Me.btncancelar.Text = "   Cancelar"
        Me.btncancelar.UseVisualStyleBackColor = True
        '
        'btneditar
        '
        Me.btneditar.Image = Global.RefaccionesSuzuki.My.Resources.Resources.editar
        Me.btneditar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btneditar.Location = New System.Drawing.Point(116, 278)
        Me.btneditar.Name = "btneditar"
        Me.btneditar.Size = New System.Drawing.Size(76, 22)
        Me.btneditar.TabIndex = 13
        Me.btneditar.Text = "Editar"
        Me.btneditar.UseVisualStyleBackColor = True
        '
        'btnnuevo
        '
        Me.btnnuevo.Image = Global.RefaccionesSuzuki.My.Resources.Resources.anadir
        Me.btnnuevo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnnuevo.Location = New System.Drawing.Point(6, 278)
        Me.btnnuevo.Name = "btnnuevo"
        Me.btnnuevo.Size = New System.Drawing.Size(76, 22)
        Me.btnnuevo.TabIndex = 12
        Me.btnnuevo.Text = "  Nuevo"
        Me.btnnuevo.UseVisualStyleBackColor = True
        '
        'txttelefono
        '
        Me.txttelefono.Location = New System.Drawing.Point(115, 148)
        Me.txttelefono.MaxLength = 10
        Me.txttelefono.Name = "txttelefono"
        Me.txttelefono.Size = New System.Drawing.Size(227, 23)
        Me.txttelefono.TabIndex = 9
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(22, 151)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(57, 16)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "Telefono"
        '
        'txtap_paterno
        '
        Me.txtap_paterno.Location = New System.Drawing.Point(115, 75)
        Me.txtap_paterno.Name = "txtap_paterno"
        Me.txtap_paterno.Size = New System.Drawing.Size(227, 23)
        Me.txtap_paterno.TabIndex = 7
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(20, 82)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(68, 16)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Apellido P"
        '
        'txtnombre
        '
        Me.txtnombre.Location = New System.Drawing.Point(115, 49)
        Me.txtnombre.Name = "txtnombre"
        Me.txtnombre.Size = New System.Drawing.Size(227, 23)
        Me.txtnombre.TabIndex = 5
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(20, 56)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(56, 16)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Nombre"
        '
        'txtdireccion
        '
        Me.txtdireccion.Location = New System.Drawing.Point(115, 178)
        Me.txtdireccion.Name = "txtdireccion"
        Me.txtdireccion.Size = New System.Drawing.Size(227, 23)
        Me.txtdireccion.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(20, 181)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(82, 16)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "id_Direccion"
        '
        'txtidecliente
        '
        Me.txtidecliente.Location = New System.Drawing.Point(115, 23)
        Me.txtidecliente.Name = "txtidecliente"
        Me.txtidecliente.Size = New System.Drawing.Size(227, 23)
        Me.txtidecliente.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(20, 30)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(59, 16)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Idcliente"
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox2.Controls.Add(Me.Button2)
        Me.GroupBox2.Controls.Add(Me.cbeliminar)
        Me.GroupBox2.Controls.Add(Me.btneliminar)
        Me.GroupBox2.Controls.Add(Me.inexistente)
        Me.GroupBox2.Controls.Add(Me.txtbuscar)
        Me.GroupBox2.Controls.Add(Me.cbocampo)
        Me.GroupBox2.Controls.Add(Me.datalistado)
        Me.GroupBox2.Font = New System.Drawing.Font("Century", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.GroupBox2.ForeColor = System.Drawing.Color.Black
        Me.GroupBox2.Location = New System.Drawing.Point(454, 39)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(406, 380)
        Me.GroupBox2.TabIndex = 19
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Listado de clientes"
        '
        'Button2
        '
        Me.Button2.Image = Global.RefaccionesSuzuki.My.Resources.Resources.buscar
        Me.Button2.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button2.Location = New System.Drawing.Point(181, 42)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(94, 24)
        Me.Button2.TabIndex = 5
        Me.Button2.Text = "Buscar"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'cbeliminar
        '
        Me.cbeliminar.AutoSize = True
        Me.cbeliminar.Location = New System.Drawing.Point(17, 50)
        Me.cbeliminar.Name = "cbeliminar"
        Me.cbeliminar.Size = New System.Drawing.Size(81, 20)
        Me.cbeliminar.TabIndex = 4
        Me.cbeliminar.Text = "Eliminar"
        Me.cbeliminar.UseVisualStyleBackColor = True
        '
        'btneliminar
        '
        Me.btneliminar.Image = Global.RefaccionesSuzuki.My.Resources.Resources.basura
        Me.btneliminar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btneliminar.Location = New System.Drawing.Point(11, 347)
        Me.btneliminar.Name = "btneliminar"
        Me.btneliminar.Size = New System.Drawing.Size(87, 27)
        Me.btneliminar.TabIndex = 2
        Me.btneliminar.Text = "   Eliminar"
        Me.btneliminar.UseVisualStyleBackColor = True
        '
        'inexistente
        '
        Me.inexistente.AutoSize = True
        Me.inexistente.Location = New System.Drawing.Point(111, 149)
        Me.inexistente.Name = "inexistente"
        Me.inexistente.Size = New System.Drawing.Size(117, 16)
        Me.inexistente.TabIndex = 3
        Me.inexistente.TabStop = True
        Me.inexistente.Text = "Datos inexistentes"
        '
        'txtbuscar
        '
        Me.txtbuscar.Location = New System.Drawing.Point(164, 18)
        Me.txtbuscar.Name = "txtbuscar"
        Me.txtbuscar.Size = New System.Drawing.Size(125, 23)
        Me.txtbuscar.TabIndex = 2
        '
        'cbocampo
        '
        Me.cbocampo.FormattingEnabled = True
        Me.cbocampo.Items.AddRange(New Object() {"Nombre", "Ap_Paterno", "Ap_Materno", "Tele_Cel"})
        Me.cbocampo.Location = New System.Drawing.Point(11, 18)
        Me.cbocampo.Name = "cbocampo"
        Me.cbocampo.Size = New System.Drawing.Size(138, 24)
        Me.cbocampo.TabIndex = 1
        Me.cbocampo.Text = "Nombre"
        '
        'datalistado
        '
        Me.datalistado.AllowUserToAddRows = False
        Me.datalistado.AllowUserToDeleteRows = False
        Me.datalistado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.datalistado.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Eliminar})
        Me.datalistado.Location = New System.Drawing.Point(16, 72)
        Me.datalistado.Name = "datalistado"
        Me.datalistado.ReadOnly = True
        Me.datalistado.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.datalistado.Size = New System.Drawing.Size(384, 273)
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
        'frmcliente
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.BackgroundImage = Global.RefaccionesSuzuki.My.Resources.Resources._4
        Me.ClientSize = New System.Drawing.Size(888, 440)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.btnguardar)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "frmcliente"
        Me.Text = "Cliente"
        Me.btnguardar.ResumeLayout(False)
        Me.btnguardar.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.datalistado, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.erroricono, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnguardar As GroupBox
    Friend WithEvents Button1 As Button
    Friend WithEvents btncancelar As Button
    Friend WithEvents btneditar As Button
    Friend WithEvents btnnuevo As Button
    Friend WithEvents txttelefono As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txtap_paterno As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txtnombre As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtdireccion As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtidecliente As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents cbeliminar As CheckBox
    Friend WithEvents btneliminar As Button
    Friend WithEvents inexistente As LinkLabel
    Friend WithEvents txtbuscar As TextBox
    Friend WithEvents cbocampo As ComboBox
    Friend WithEvents datalistado As DataGridView
    Friend WithEvents Eliminar As DataGridViewCheckBoxColumn
    Friend WithEvents txtap_materno As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents btnbuscar_categoria As Button
    Friend WithEvents erroricono As ErrorProvider
    Friend WithEvents Button2 As Button
End Class
