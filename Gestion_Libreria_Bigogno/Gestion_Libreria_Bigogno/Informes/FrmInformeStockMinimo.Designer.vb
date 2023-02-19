<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmInformeStockMinimo
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
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.libreria_bigognoDataSetStockMinimo = New GestionLibreriaBigogno.libreria_bigognoDataSetStockMinimo()
        Me.vista_stockminimocompletoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.vista_stockminimocompletoTableAdapter = New GestionLibreriaBigogno.libreria_bigognoDataSetStockMinimoTableAdapters.vista_stockminimocompletoTableAdapter()
        CType(Me.libreria_bigognoDataSetStockMinimo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.vista_stockminimocompletoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ReportViewer1
        '
        Me.ReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill
        ReportDataSource1.Name = "DataSetStockMinimo"
        ReportDataSource1.Value = Me.vista_stockminimocompletoBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "GestionLibreriaBigogno.ReportStockMinimo.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(0, 0)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.Size = New System.Drawing.Size(994, 571)
        Me.ReportViewer1.TabIndex = 0
        '
        'libreria_bigognoDataSetStockMinimo
        '
        Me.libreria_bigognoDataSetStockMinimo.DataSetName = "libreria_bigognoDataSetStockMinimo"
        Me.libreria_bigognoDataSetStockMinimo.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'vista_stockminimocompletoBindingSource
        '
        Me.vista_stockminimocompletoBindingSource.DataMember = "vista_stockminimocompleto"
        Me.vista_stockminimocompletoBindingSource.DataSource = Me.libreria_bigognoDataSetStockMinimo
        '
        'vista_stockminimocompletoTableAdapter
        '
        Me.vista_stockminimocompletoTableAdapter.ClearBeforeFill = True
        '
        'FrmStockMinimo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(994, 571)
        Me.Controls.Add(Me.ReportViewer1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmStockMinimo"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "StockMinimo"
        CType(Me.libreria_bigognoDataSetStockMinimo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.vista_stockminimocompletoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents vista_stockminimocompletoBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents libreria_bigognoDataSetStockMinimo As GestionLibreriaBigogno.libreria_bigognoDataSetStockMinimo
    Friend WithEvents vista_stockminimocompletoTableAdapter As GestionLibreriaBigogno.libreria_bigognoDataSetStockMinimoTableAdapters.vista_stockminimocompletoTableAdapter
End Class
