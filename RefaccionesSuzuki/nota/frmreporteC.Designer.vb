<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmreporteC
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
        Dim ReportDataSource1 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmreporteC))
        Me.generar_comprobanteBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.RefaccionessDataSet = New RefaccionesSuzuki.RefaccionessDataSet()
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.generar_comprobanteTableAdapter = New RefaccionesSuzuki.RefaccionessDataSetTableAdapters.generar_comprobanteTableAdapter()
        Me.txtidventa = New System.Windows.Forms.TextBox()
        CType(Me.generar_comprobanteBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RefaccionessDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'generar_comprobanteBindingSource
        '
        Me.generar_comprobanteBindingSource.DataMember = "generar_comprobante"
        Me.generar_comprobanteBindingSource.DataSource = Me.RefaccionessDataSet
        '
        'RefaccionessDataSet
        '
        Me.RefaccionessDataSet.DataSetName = "RefaccionessDataSet"
        Me.RefaccionessDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ReportViewer1
        '
        Me.ReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill
        ReportDataSource1.Name = "DataSet1"
        ReportDataSource1.Value = Me.generar_comprobanteBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "RefaccionesSuzuki.rptcomprobante.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(0, 0)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.Size = New System.Drawing.Size(772, 433)
        Me.ReportViewer1.TabIndex = 0
        '
        'generar_comprobanteTableAdapter
        '
        Me.generar_comprobanteTableAdapter.ClearBeforeFill = True
        '
        'txtidventa
        '
        Me.txtidventa.Location = New System.Drawing.Point(80, 54)
        Me.txtidventa.Name = "txtidventa"
        Me.txtidventa.Size = New System.Drawing.Size(100, 20)
        Me.txtidventa.TabIndex = 1
        Me.txtidventa.Visible = False
        '
        'frmreporteC
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(772, 433)
        Me.Controls.Add(Me.txtidventa)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "frmreporteC"
        Me.Text = "Nota de Compra"
        CType(Me.generar_comprobanteBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RefaccionessDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents generar_comprobanteBindingSource As BindingSource
    Friend WithEvents RefaccionessDataSet As RefaccionessDataSet
    Friend WithEvents generar_comprobanteTableAdapter As RefaccionessDataSetTableAdapters.generar_comprobanteTableAdapter
    Friend WithEvents txtidventa As TextBox
End Class
