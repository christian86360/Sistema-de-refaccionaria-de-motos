<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmalmacen
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmalmacen))
        Me.btnguardar = New System.Windows.Forms.GroupBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtcantida_cajas = New System.Windows.Forms.TextBox()
        Me.btnbuscar_categoria = New System.Windows.Forms.Button()
        Me.txtnom_categoria = New System.Windows.Forms.TextBox()
        Me.txtidcategoria = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtflag = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.btncancelar = New System.Windows.Forms.Button()
        Me.btneditar = New System.Windows.Forms.Button()
        Me.btnnuevo = New System.Windows.Forms.Button()
        Me.txtubica_almacen = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtid_almacen = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.cbeliminar = New System.Windows.Forms.CheckBox()
        Me.btneliminar = New System.Windows.Forms.Button()
        Me.inexistente = New System.Windows.Forms.LinkLabel()
        Me.txtbuscar = New System.Windows.Forms.TextBox()
        Me.cboalmacen = New System.Windows.Forms.ComboBox()
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
        Me.btnguardar.Controls.Add(Me.Label4)
        Me.btnguardar.Controls.Add(Me.txtcantida_cajas)
        Me.btnguardar.Controls.Add(Me.btnbuscar_categoria)
        Me.btnguardar.Controls.Add(Me.txtnom_categoria)
        Me.btnguardar.Controls.Add(Me.txtidcategoria)
        Me.btnguardar.Controls.Add(Me.Label2)
        Me.btnguardar.Controls.Add(Me.txtflag)
        Me.btnguardar.Controls.Add(Me.Button1)
        Me.btnguardar.Controls.Add(Me.btncancelar)
        Me.btnguardar.Controls.Add(Me.btneditar)
        Me.btnguardar.Controls.Add(Me.btnnuevo)
        Me.btnguardar.Controls.Add(Me.txtubica_almacen)
        Me.btnguardar.Controls.Add(Me.Label3)
        Me.btnguardar.Controls.Add(Me.txtid_almacen)
        Me.btnguardar.Controls.Add(Me.Label1)
        Me.btnguardar.Font = New System.Drawing.Font("Century", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnguardar.ForeColor = System.Drawing.Color.Black
        Me.btnguardar.Location = New System.Drawing.Point(12, 42)
        Me.btnguardar.Name = "btnguardar"
        Me.btnguardar.Size = New System.Drawing.Size(420, 454)
        Me.btnguardar.TabIndex = 3
        Me.btnguardar.TabStop = False
        Me.btnguardar.Text = "Mantenimiento"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(9, 139)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(102, 16)
        Me.Label4.TabIndex = 23
        Me.Label4.Text = "Cantidad_Cajas"
        '
        'txtcantida_cajas
        '
        Me.txtcantida_cajas.Location = New System.Drawing.Point(115, 132)
        Me.txtcantida_cajas.Name = "txtcantida_cajas"
        Me.txtcantida_cajas.Size = New System.Drawing.Size(58, 23)
        Me.txtcantida_cajas.TabIndex = 22
        '
        'btnbuscar_categoria
        '
        Me.btnbuscar_categoria.Location = New System.Drawing.Point(347, 164)
        Me.btnbuscar_categoria.Name = "btnbuscar_categoria"
        Me.btnbuscar_categoria.Size = New System.Drawing.Size(49, 22)
        Me.btnbuscar_categoria.TabIndex = 21
        Me.btnbuscar_categoria.Text = "..."
        Me.btnbuscar_categoria.UseVisualStyleBackColor = True
        '
        'txtnom_categoria
        '
        Me.txtnom_categoria.Location = New System.Drawing.Point(180, 166)
        Me.txtnom_categoria.Name = "txtnom_categoria"
        Me.txtnom_categoria.Size = New System.Drawing.Size(161, 23)
        Me.txtnom_categoria.TabIndex = 20
        '
        'txtidcategoria
        '
        Me.txtidcategoria.Location = New System.Drawing.Point(115, 166)
        Me.txtidcategoria.Name = "txtidcategoria"
        Me.txtidcategoria.Size = New System.Drawing.Size(59, 23)
        Me.txtidcategoria.TabIndex = 19
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(9, 173)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(65, 16)
        Me.Label2.TabIndex = 18
        Me.Label2.Text = "Categoria"
        '
        'txtflag
        '
        Me.txtflag.Location = New System.Drawing.Point(298, 19)
        Me.txtflag.Name = "txtflag"
        Me.txtflag.Size = New System.Drawing.Size(44, 23)
        Me.txtflag.TabIndex = 16
        Me.txtflag.Text = "0"
        '
        'Button1
        '
        Me.Button1.Image = Global.RefaccionesSuzuki.My.Resources.Resources.guardar
        Me.Button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button1.Location = New System.Drawing.Point(115, 225)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(88, 22)
        Me.Button1.TabIndex = 15
        Me.Button1.Text = "   Guardar"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'btncancelar
        '
        Me.btncancelar.Image = Global.RefaccionesSuzuki.My.Resources.Resources._error
        Me.btncancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btncancelar.Location = New System.Drawing.Point(218, 225)
        Me.btncancelar.Name = "btncancelar"
        Me.btncancelar.Size = New System.Drawing.Size(86, 22)
        Me.btncancelar.TabIndex = 14
        Me.btncancelar.Text = "    Cancelar"
        Me.btncancelar.UseVisualStyleBackColor = True
        '
        'btneditar
        '
        Me.btneditar.Image = Global.RefaccionesSuzuki.My.Resources.Resources.editar
        Me.btneditar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btneditar.Location = New System.Drawing.Point(124, 225)
        Me.btneditar.Name = "btneditar"
        Me.btneditar.Size = New System.Drawing.Size(76, 22)
        Me.btneditar.TabIndex = 13
        Me.btneditar.Text = "   Editar"
        Me.btneditar.UseVisualStyleBackColor = True
        '
        'btnnuevo
        '
        Me.btnnuevo.Image = Global.RefaccionesSuzuki.My.Resources.Resources.anadir
        Me.btnnuevo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnnuevo.Location = New System.Drawing.Point(12, 225)
        Me.btnnuevo.Name = "btnnuevo"
        Me.btnnuevo.Size = New System.Drawing.Size(79, 22)
        Me.btnnuevo.TabIndex = 12
        Me.btnnuevo.Text = "   Nuevo"
        Me.btnnuevo.UseVisualStyleBackColor = True
        '
        'txtubica_almacen
        '
        Me.txtubica_almacen.Location = New System.Drawing.Point(115, 90)
        Me.txtubica_almacen.Name = "txtubica_almacen"
        Me.txtubica_almacen.Size = New System.Drawing.Size(227, 23)
        Me.txtubica_almacen.TabIndex = 5
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(9, 97)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(102, 16)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Ubica_Almacen"
        '
        'txtid_almacen
        '
        Me.txtid_almacen.Location = New System.Drawing.Point(115, 57)
        Me.txtid_almacen.Name = "txtid_almacen"
        Me.txtid_almacen.Size = New System.Drawing.Size(227, 23)
        Me.txtid_almacen.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(9, 64)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(79, 16)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Id_Almacen"
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox2.Controls.Add(Me.Button2)
        Me.GroupBox2.Controls.Add(Me.cbeliminar)
        Me.GroupBox2.Controls.Add(Me.btneliminar)
        Me.GroupBox2.Controls.Add(Me.inexistente)
        Me.GroupBox2.Controls.Add(Me.txtbuscar)
        Me.GroupBox2.Controls.Add(Me.cboalmacen)
        Me.GroupBox2.Controls.Add(Me.datalistado)
        Me.GroupBox2.Font = New System.Drawing.Font("Century", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.ForeColor = System.Drawing.Color.Black
        Me.GroupBox2.Location = New System.Drawing.Point(448, 42)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(499, 454)
        Me.GroupBox2.TabIndex = 4
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Listado del almacen"
        '
        'Button2
        '
        Me.Button2.Image = Global.RefaccionesSuzuki.My.Resources.Resources.buscar
        Me.Button2.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button2.Location = New System.Drawing.Point(187, 53)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(86, 31)
        Me.Button2.TabIndex = 5
        Me.Button2.Text = "Buscar"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'cbeliminar
        '
        Me.cbeliminar.AutoSize = True
        Me.cbeliminar.Location = New System.Drawing.Point(21, 57)
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
        Me.btneliminar.Location = New System.Drawing.Point(6, 372)
        Me.btneliminar.Name = "btneliminar"
        Me.btneliminar.Size = New System.Drawing.Size(96, 28)
        Me.btneliminar.TabIndex = 2
        Me.btneliminar.Text = "   Eliminar         "
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
        Me.txtbuscar.Location = New System.Drawing.Point(168, 24)
        Me.txtbuscar.Name = "txtbuscar"
        Me.txtbuscar.Size = New System.Drawing.Size(125, 23)
        Me.txtbuscar.TabIndex = 2
        '
        'cboalmacen
        '
        Me.cboalmacen.FormattingEnabled = True
        Me.cboalmacen.Items.AddRange(New Object() {"Ubica_Almacen", "", ""})
        Me.cboalmacen.Location = New System.Drawing.Point(11, 23)
        Me.cboalmacen.Name = "cboalmacen"
        Me.cboalmacen.Size = New System.Drawing.Size(138, 24)
        Me.cboalmacen.TabIndex = 1
        Me.cboalmacen.Text = "Ubica_Almacen"
        '
        'datalistado
        '
        Me.datalistado.AllowUserToAddRows = False
        Me.datalistado.AllowUserToDeleteRows = False
        Me.datalistado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.datalistado.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Eliminar})
        Me.datalistado.Location = New System.Drawing.Point(12, 93)
        Me.datalistado.Name = "datalistado"
        Me.datalistado.ReadOnly = True
        Me.datalistado.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.datalistado.Size = New System.Drawing.Size(469, 273)
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
        'frmalmacen
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.BackgroundImage = Global.RefaccionesSuzuki.My.Resources.Resources._3
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(946, 492)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.btnguardar)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "frmalmacen"
        Me.Text = "Almacen"
        Me.btnguardar.ResumeLayout(False)
        Me.btnguardar.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.datalistado, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.erroricono, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnguardar As GroupBox
    Friend WithEvents txtflag As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents btncancelar As Button
    Friend WithEvents btneditar As Button
    Friend WithEvents btnnuevo As Button
    Friend WithEvents txtubica_almacen As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtid_almacen As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents cbeliminar As CheckBox
    Friend WithEvents btneliminar As Button
    Friend WithEvents inexistente As LinkLabel
    Friend WithEvents txtbuscar As TextBox
    Friend WithEvents cboalmacen As ComboBox
    Friend WithEvents datalistado As DataGridView
    Friend WithEvents Eliminar As DataGridViewCheckBoxColumn
    Friend WithEvents Label4 As Label
    Friend WithEvents txtcantida_cajas As TextBox
    Friend WithEvents btnbuscar_categoria As Button
    Friend WithEvents txtnom_categoria As TextBox
    Friend WithEvents txtidcategoria As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents erroricono As ErrorProvider
    Friend WithEvents Button2 As Button
End Class
