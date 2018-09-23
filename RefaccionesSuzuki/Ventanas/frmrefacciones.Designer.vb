<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmrefacciones
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmrefacciones))
        Me.btnnombre = New System.Windows.Forms.GroupBox()
        Me.txtmoto_pertenece = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtdescripcion = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txt_ubicastock = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtflag = New System.Windows.Forms.TextBox()
        Me.txtstock = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnbuscar_categoria = New System.Windows.Forms.Button()
        Me.txtnom_categoria = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtidcategoria = New System.Windows.Forms.TextBox()
        Me.btnguardar = New System.Windows.Forms.Button()
        Me.btncancelar = New System.Windows.Forms.Button()
        Me.btneditar = New System.Windows.Forms.Button()
        Me.btnnuevo = New System.Windows.Forms.Button()
        Me.txtpreciodeventa = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtprecio_uni = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtnombre = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtcodigo = New System.Windows.Forms.TextBox()
        Me.txtidproducto = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.btnBuscar = New System.Windows.Forms.Button()
        Me.cbeliminar = New System.Windows.Forms.CheckBox()
        Me.btneliminar = New System.Windows.Forms.Button()
        Me.inexistente = New System.Windows.Forms.LinkLabel()
        Me.txtbuscar = New System.Windows.Forms.TextBox()
        Me.cbocampo = New System.Windows.Forms.ComboBox()
        Me.datalistado = New System.Windows.Forms.DataGridView()
        Me.Eliminar = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.erroricono = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.btnnombre.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.datalistado, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.erroricono, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnnombre
        '
        Me.btnnombre.BackColor = System.Drawing.Color.Transparent
        Me.btnnombre.Controls.Add(Me.txtmoto_pertenece)
        Me.btnnombre.Controls.Add(Me.Label8)
        Me.btnnombre.Controls.Add(Me.txtdescripcion)
        Me.btnnombre.Controls.Add(Me.Label4)
        Me.btnnombre.Controls.Add(Me.txt_ubicastock)
        Me.btnnombre.Controls.Add(Me.Label7)
        Me.btnnombre.Controls.Add(Me.txtflag)
        Me.btnnombre.Controls.Add(Me.txtstock)
        Me.btnnombre.Controls.Add(Me.Label2)
        Me.btnnombre.Controls.Add(Me.btnbuscar_categoria)
        Me.btnnombre.Controls.Add(Me.txtnom_categoria)
        Me.btnnombre.Controls.Add(Me.Label1)
        Me.btnnombre.Controls.Add(Me.txtidcategoria)
        Me.btnnombre.Controls.Add(Me.btnguardar)
        Me.btnnombre.Controls.Add(Me.btncancelar)
        Me.btnnombre.Controls.Add(Me.btneditar)
        Me.btnnombre.Controls.Add(Me.btnnuevo)
        Me.btnnombre.Controls.Add(Me.txtpreciodeventa)
        Me.btnnombre.Controls.Add(Me.Label6)
        Me.btnnombre.Controls.Add(Me.txtprecio_uni)
        Me.btnnombre.Controls.Add(Me.Label5)
        Me.btnnombre.Controls.Add(Me.txtnombre)
        Me.btnnombre.Controls.Add(Me.Label3)
        Me.btnnombre.Controls.Add(Me.txtcodigo)
        Me.btnnombre.Controls.Add(Me.txtidproducto)
        Me.btnnombre.Font = New System.Drawing.Font("Century", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnnombre.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnnombre.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnnombre.Location = New System.Drawing.Point(12, 22)
        Me.btnnombre.Name = "btnnombre"
        Me.btnnombre.Size = New System.Drawing.Size(393, 446)
        Me.btnnombre.TabIndex = 3
        Me.btnnombre.TabStop = False
        Me.btnnombre.Text = "Mantenimiento"
        '
        'txtmoto_pertenece
        '
        Me.txtmoto_pertenece.Location = New System.Drawing.Point(115, 285)
        Me.txtmoto_pertenece.Name = "txtmoto_pertenece"
        Me.txtmoto_pertenece.Size = New System.Drawing.Size(82, 23)
        Me.txtmoto_pertenece.TabIndex = 30
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(20, 292)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(102, 16)
        Me.Label8.TabIndex = 29
        Me.Label8.Text = "Moto_Pertenece"
        '
        'txtdescripcion
        '
        Me.txtdescripcion.Location = New System.Drawing.Point(115, 328)
        Me.txtdescripcion.Multiline = True
        Me.txtdescripcion.Name = "txtdescripcion"
        Me.txtdescripcion.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtdescripcion.Size = New System.Drawing.Size(227, 32)
        Me.txtdescripcion.TabIndex = 7
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(22, 331)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(77, 16)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Descripcion"
        '
        'txt_ubicastock
        '
        Me.txt_ubicastock.Location = New System.Drawing.Point(115, 249)
        Me.txt_ubicastock.Name = "txt_ubicastock"
        Me.txt_ubicastock.Size = New System.Drawing.Size(82, 23)
        Me.txt_ubicastock.TabIndex = 28
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(22, 249)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(83, 16)
        Me.Label7.TabIndex = 27
        Me.Label7.Text = "Ubica_Stock"
        '
        'txtflag
        '
        Me.txtflag.Location = New System.Drawing.Point(289, 0)
        Me.txtflag.Name = "txtflag"
        Me.txtflag.Size = New System.Drawing.Size(73, 23)
        Me.txtflag.TabIndex = 26
        Me.txtflag.Text = "0"
        Me.txtflag.Visible = False
        '
        'txtstock
        '
        Me.txtstock.Location = New System.Drawing.Point(115, 213)
        Me.txtstock.Name = "txtstock"
        Me.txtstock.Size = New System.Drawing.Size(89, 23)
        Me.txtstock.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(27, 213)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(41, 16)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Stock"
        '
        'btnbuscar_categoria
        '
        Me.btnbuscar_categoria.Location = New System.Drawing.Point(344, 99)
        Me.btnbuscar_categoria.Name = "btnbuscar_categoria"
        Me.btnbuscar_categoria.Size = New System.Drawing.Size(49, 22)
        Me.btnbuscar_categoria.TabIndex = 19
        Me.btnbuscar_categoria.Text = "..."
        Me.btnbuscar_categoria.UseVisualStyleBackColor = True
        '
        'txtnom_categoria
        '
        Me.txtnom_categoria.Location = New System.Drawing.Point(181, 101)
        Me.txtnom_categoria.Name = "txtnom_categoria"
        Me.txtnom_categoria.Size = New System.Drawing.Size(161, 23)
        Me.txtnom_categoria.TabIndex = 18
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(20, 101)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(65, 16)
        Me.Label1.TabIndex = 17
        Me.Label1.Text = "Categoria"
        '
        'txtidcategoria
        '
        Me.txtidcategoria.Location = New System.Drawing.Point(116, 101)
        Me.txtidcategoria.Name = "txtidcategoria"
        Me.txtidcategoria.Size = New System.Drawing.Size(59, 23)
        Me.txtidcategoria.TabIndex = 16
        '
        'btnguardar
        '
        Me.btnguardar.Image = Global.RefaccionesSuzuki.My.Resources.Resources.guardar
        Me.btnguardar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnguardar.Location = New System.Drawing.Point(116, 403)
        Me.btnguardar.Name = "btnguardar"
        Me.btnguardar.Size = New System.Drawing.Size(88, 22)
        Me.btnguardar.TabIndex = 15
        Me.btnguardar.Text = "    Guardar"
        Me.btnguardar.UseVisualStyleBackColor = True
        '
        'btncancelar
        '
        Me.btncancelar.Image = Global.RefaccionesSuzuki.My.Resources.Resources._error
        Me.btncancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btncancelar.Location = New System.Drawing.Point(214, 403)
        Me.btncancelar.Name = "btncancelar"
        Me.btncancelar.Size = New System.Drawing.Size(86, 22)
        Me.btncancelar.TabIndex = 14
        Me.btncancelar.Text = "    Cancelar"
        Me.btncancelar.UseVisualStyleBackColor = True
        '
        'btneditar
        '
        Me.btneditar.Image = Global.RefaccionesSuzuki.My.Resources.Resources.editar
        Me.btneditar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btneditar.Location = New System.Drawing.Point(115, 403)
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
        Me.btnnuevo.Location = New System.Drawing.Point(23, 403)
        Me.btnnuevo.Name = "btnnuevo"
        Me.btnnuevo.Size = New System.Drawing.Size(76, 22)
        Me.btnnuevo.TabIndex = 12
        Me.btnnuevo.Text = "  Nuevo"
        Me.btnnuevo.UseVisualStyleBackColor = True
        '
        'txtpreciodeventa
        '
        Me.txtpreciodeventa.Location = New System.Drawing.Point(115, 176)
        Me.txtpreciodeventa.MaxLength = 8
        Me.txtpreciodeventa.Name = "txtpreciodeventa"
        Me.txtpreciodeventa.Size = New System.Drawing.Size(89, 23)
        Me.txtpreciodeventa.TabIndex = 11
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(22, 179)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(73, 16)
        Me.Label6.TabIndex = 10
        Me.Label6.Text = "Precio_Vta"
        '
        'txtprecio_uni
        '
        Me.txtprecio_uni.Location = New System.Drawing.Point(115, 139)
        Me.txtprecio_uni.MaxLength = 9
        Me.txtprecio_uni.Name = "txtprecio_uni"
        Me.txtprecio_uni.Size = New System.Drawing.Size(89, 23)
        Me.txtprecio_uni.TabIndex = 9
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(22, 141)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(75, 16)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "Precio_Uni"
        '
        'txtnombre
        '
        Me.txtnombre.Location = New System.Drawing.Point(116, 64)
        Me.txtnombre.Name = "txtnombre"
        Me.txtnombre.Size = New System.Drawing.Size(227, 23)
        Me.txtnombre.TabIndex = 5
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(22, 64)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(60, 16)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Nombre "
        '
        'txtcodigo
        '
        Me.txtcodigo.Location = New System.Drawing.Point(115, 32)
        Me.txtcodigo.Name = "txtcodigo"
        Me.txtcodigo.Size = New System.Drawing.Size(227, 23)
        Me.txtcodigo.TabIndex = 1
        '
        'txtidproducto
        '
        Me.txtidproducto.AutoSize = True
        Me.txtidproducto.Location = New System.Drawing.Point(20, 39)
        Me.txtidproducto.Name = "txtidproducto"
        Me.txtidproducto.Size = New System.Drawing.Size(47, 16)
        Me.txtidproducto.TabIndex = 0
        Me.txtidproducto.Text = "Codigo"
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox2.Controls.Add(Me.btnBuscar)
        Me.GroupBox2.Controls.Add(Me.cbeliminar)
        Me.GroupBox2.Controls.Add(Me.btneliminar)
        Me.GroupBox2.Controls.Add(Me.inexistente)
        Me.GroupBox2.Controls.Add(Me.txtbuscar)
        Me.GroupBox2.Controls.Add(Me.cbocampo)
        Me.GroupBox2.Controls.Add(Me.datalistado)
        Me.GroupBox2.Font = New System.Drawing.Font("Century", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.GroupBox2.Location = New System.Drawing.Point(462, 32)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(651, 436)
        Me.GroupBox2.TabIndex = 27
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Listado de productos"
        '
        'btnBuscar
        '
        Me.btnBuscar.Image = Global.RefaccionesSuzuki.My.Resources.Resources.buscar
        Me.btnBuscar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnBuscar.Location = New System.Drawing.Point(167, 45)
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.Size = New System.Drawing.Size(72, 24)
        Me.btnBuscar.TabIndex = 27
        Me.btnBuscar.Text = "Bucar  "
        Me.btnBuscar.UseVisualStyleBackColor = True
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
        Me.btneliminar.Location = New System.Drawing.Point(11, 351)
        Me.btneliminar.Name = "btneliminar"
        Me.btneliminar.Size = New System.Drawing.Size(87, 36)
        Me.btneliminar.TabIndex = 2
        Me.btneliminar.Text = "  Eliminar"
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
        Me.txtbuscar.Location = New System.Drawing.Point(155, 18)
        Me.txtbuscar.Name = "txtbuscar"
        Me.txtbuscar.Size = New System.Drawing.Size(125, 23)
        Me.txtbuscar.TabIndex = 2
        '
        'cbocampo
        '
        Me.cbocampo.FormattingEnabled = True
        Me.cbocampo.Items.AddRange(New Object() {"nombre", "Codigo"})
        Me.cbocampo.Location = New System.Drawing.Point(11, 18)
        Me.cbocampo.Name = "cbocampo"
        Me.cbocampo.Size = New System.Drawing.Size(138, 24)
        Me.cbocampo.TabIndex = 1
        Me.cbocampo.Text = "nombre"
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
        Me.datalistado.Size = New System.Drawing.Size(629, 273)
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
        'frmrefacciones
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.BackgroundImage = Global.RefaccionesSuzuki.My.Resources.Resources._31
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1145, 505)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.btnnombre)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "frmrefacciones"
        Me.Text = "Refacciones"
        Me.btnnombre.ResumeLayout(False)
        Me.btnnombre.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.datalistado, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.erroricono, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnnombre As GroupBox
    Friend WithEvents txtflag As TextBox
    Friend WithEvents btnbuscar_categoria As Button
    Friend WithEvents txtnom_categoria As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents txtidcategoria As TextBox
    Friend WithEvents btnguardar As Button
    Friend WithEvents btncancelar As Button
    Friend WithEvents btneditar As Button
    Friend WithEvents btnnuevo As Button
    Friend WithEvents txtpreciodeventa As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents txtprecio_uni As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txtdescripcion As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txtnombre As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtstock As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtcodigo As TextBox
    Friend WithEvents txtidproducto As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents cbeliminar As CheckBox
    Friend WithEvents btneliminar As Button
    Friend WithEvents inexistente As LinkLabel
    Friend WithEvents txtbuscar As TextBox
    Friend WithEvents cbocampo As ComboBox
    Friend WithEvents datalistado As DataGridView
    Friend WithEvents Eliminar As DataGridViewCheckBoxColumn
    Friend WithEvents btnBuscar As Button
    Friend WithEvents txtmoto_pertenece As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents txt_ubicastock As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents erroricono As ErrorProvider
End Class
