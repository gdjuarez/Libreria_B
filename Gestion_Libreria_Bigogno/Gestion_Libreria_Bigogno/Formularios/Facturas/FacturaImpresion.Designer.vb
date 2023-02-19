<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FacturaImpresion
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
        Dim ReportDataSource2 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.libreria_bigognoDataSetMisDatosFactura = New GestionLibreriaBigogno.libreria_bigognoDataSetMisDatosFactura()
        Me.misdatosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.misdatosTableAdapter = New GestionLibreriaBigogno.libreria_bigognoDataSetMisDatosFacturaTableAdapters.misdatosTableAdapter()
        Me.libreria_bigognoDataSetDetallesFactura = New GestionLibreriaBigogno.libreria_bigognoDataSetDetallesFactura()
        Me.get_FacturaBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.get_FacturaTableAdapter = New GestionLibreriaBigogno.libreria_bigognoDataSetDetallesFacturaTableAdapters.get_FacturaTableAdapter()
        CType(Me.libreria_bigognoDataSetMisDatosFactura, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.misdatosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.libreria_bigognoDataSetDetallesFactura, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.get_FacturaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ReportViewer1
        '
        Me.ReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill
        ReportDataSource1.Name = "DataSetMisDatosFactura"
        ReportDataSource1.Value = Me.misdatosBindingSource
        ReportDataSource2.Name = "DataSetDetallesFactura"
        ReportDataSource2.Value = Me.get_FacturaBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource2)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "GestionLibreriaBigogno.ReportFactu.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(0, 0)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.Size = New System.Drawing.Size(694, 621)
        Me.ReportViewer1.TabIndex = 0
        '
        'libreria_bigognoDataSetMisDatosFactura
        '
        Me.libreria_bigognoDataSetMisDatosFactura.DataSetName = "libreria_bigognoDataSetMisDatosFactura"
        Me.libreria_bigognoDataSetMisDatosFactura.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'misdatosBindingSource
        '
        Me.misdatosBindingSource.DataMember = "misdatos"
        Me.misdatosBindingSource.DataSource = Me.libreria_bigognoDataSetMisDatosFactura
        '
        'misdatosTableAdapter
        '
        Me.misdatosTableAdapter.ClearBeforeFill = True
        '
        'libreria_bigognoDataSetDetallesFactura
        '
        Me.libreria_bigognoDataSetDetallesFactura.DataSetName = "libreria_bigognoDataSetDetallesFactura"
        Me.libreria_bigognoDataSetDetallesFactura.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'get_FacturaBindingSource
        '
        Me.get_FacturaBindingSource.DataMember = "get_Factura"
        Me.get_FacturaBindingSource.DataSource = Me.libreria_bigognoDataSetDetallesFactura
        '
        'get_FacturaTableAdapter
        '
        Me.get_FacturaTableAdapter.ClearBeforeFill = True
        '
        'FacturaImpresion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(694, 621)
        Me.Controls.Add(Me.ReportViewer1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FacturaImpresion"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FacturaImpresion"
        CType(Me.libreria_bigognoDataSetMisDatosFactura, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.misdatosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.libreria_bigognoDataSetDetallesFactura, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.get_FacturaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents misdatosBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents libreria_bigognoDataSetMisDatosFactura As GestionLibreriaBigogno.libreria_bigognoDataSetMisDatosFactura
    Friend WithEvents get_FacturaBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents libreria_bigognoDataSetDetallesFactura As GestionLibreriaBigogno.libreria_bigognoDataSetDetallesFactura
    Friend WithEvents misdatosTableAdapter As GestionLibreriaBigogno.libreria_bigognoDataSetMisDatosFacturaTableAdapters.misdatosTableAdapter
    Friend WithEvents get_FacturaTableAdapter As GestionLibreriaBigogno.libreria_bigognoDataSetDetallesFacturaTableAdapters.get_FacturaTableAdapter
End Class
