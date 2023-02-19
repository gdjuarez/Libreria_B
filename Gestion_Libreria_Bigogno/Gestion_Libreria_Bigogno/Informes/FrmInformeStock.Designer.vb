<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmInformeStock
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
        Me.libreria_bigognoDataSetStock = New GestionLibreriaBigogno.libreria_bigognoDataSetStock()
        Me.vistaarticulosystockyprecioBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.vistaarticulosystockyprecioTableAdapter = New GestionLibreriaBigogno.libreria_bigognoDataSetStockTableAdapters.vistaarticulosystockyprecioTableAdapter()
        CType(Me.libreria_bigognoDataSetStock, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.vistaarticulosystockyprecioBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ReportViewer1
        '
        Me.ReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill
        ReportDataSource1.Name = "DataSetStock"
        ReportDataSource1.Value = Me.vistaarticulosystockyprecioBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "GestionLibreriaBigogno.ReportStock.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(0, 0)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.Size = New System.Drawing.Size(994, 571)
        Me.ReportViewer1.TabIndex = 0
        '
        'libreria_bigognoDataSetStock
        '
        Me.libreria_bigognoDataSetStock.DataSetName = "libreria_bigognoDataSetStock"
        Me.libreria_bigognoDataSetStock.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'vistaarticulosystockyprecioBindingSource
        '
        Me.vistaarticulosystockyprecioBindingSource.DataMember = "vistaarticulosystockyprecio"
        Me.vistaarticulosystockyprecioBindingSource.DataSource = Me.libreria_bigognoDataSetStock
        '
        'vistaarticulosystockyprecioTableAdapter
        '
        Me.vistaarticulosystockyprecioTableAdapter.ClearBeforeFill = True
        '
        'FrmInformeStock
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(994, 571)
        Me.Controls.Add(Me.ReportViewer1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmInformeStock"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FrmInformeStock"
        CType(Me.libreria_bigognoDataSetStock, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.vistaarticulosystockyprecioBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents vistaarticulosystockyprecioBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents libreria_bigognoDataSetStock As GestionLibreriaBigogno.libreria_bigognoDataSetStock
    Friend WithEvents vistaarticulosystockyprecioTableAdapter As GestionLibreriaBigogno.libreria_bigognoDataSetStockTableAdapters.vistaarticulosystockyprecioTableAdapter
End Class
