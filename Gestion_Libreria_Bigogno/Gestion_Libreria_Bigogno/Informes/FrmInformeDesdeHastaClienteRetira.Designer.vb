<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmInformeDesdeHastaClienteRetira
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
        Me.libreria_bigognoDataSetDesdeHastaClienteRetira = New GestionLibreriaBigogno.libreria_bigognoDataSetDesdeHastaClienteRetira()
        Me.Get_ArticulosEnCCporClienteRetiraXFechaBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Get_ArticulosEnCCporClienteRetiraXFechaTableAdapter = New GestionLibreriaBigogno.libreria_bigognoDataSetDesdeHastaClienteRetiraTableAdapters.Get_ArticulosEnCCporClienteRetiraXFechaTableAdapter()
        CType(Me.libreria_bigognoDataSetDesdeHastaClienteRetira, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Get_ArticulosEnCCporClienteRetiraXFechaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ReportViewer1
        '
        Me.ReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill
        ReportDataSource1.Name = "DataSetDesdeHastaClienteRetira"
        ReportDataSource1.Value = Me.Get_ArticulosEnCCporClienteRetiraXFechaBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "GestionLibreriaBigogno.ReportDesdeHastaClienteRetira.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(0, 0)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.Size = New System.Drawing.Size(894, 571)
        Me.ReportViewer1.TabIndex = 0
        '
        'libreria_bigognoDataSetDesdeHastaClienteRetira
        '
        Me.libreria_bigognoDataSetDesdeHastaClienteRetira.DataSetName = "libreria_bigognoDataSetDesdeHastaClienteRetira"
        Me.libreria_bigognoDataSetDesdeHastaClienteRetira.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Get_ArticulosEnCCporClienteRetiraXFechaBindingSource
        '
        Me.Get_ArticulosEnCCporClienteRetiraXFechaBindingSource.DataMember = "Get_ArticulosEnCCporClienteRetiraXFecha"
        Me.Get_ArticulosEnCCporClienteRetiraXFechaBindingSource.DataSource = Me.libreria_bigognoDataSetDesdeHastaClienteRetira
        '
        'Get_ArticulosEnCCporClienteRetiraXFechaTableAdapter
        '
        Me.Get_ArticulosEnCCporClienteRetiraXFechaTableAdapter.ClearBeforeFill = True
        '
        'FrmInformeDesdeHastaClienteRetira
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(894, 571)
        Me.Controls.Add(Me.ReportViewer1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmInformeDesdeHastaClienteRetira"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FrmInformeDesdeHastaClienteRetira"
        CType(Me.libreria_bigognoDataSetDesdeHastaClienteRetira, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Get_ArticulosEnCCporClienteRetiraXFechaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents Get_ArticulosEnCCporClienteRetiraXFechaBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents libreria_bigognoDataSetDesdeHastaClienteRetira As GestionLibreriaBigogno.libreria_bigognoDataSetDesdeHastaClienteRetira
    Friend WithEvents Get_ArticulosEnCCporClienteRetiraXFechaTableAdapter As GestionLibreriaBigogno.libreria_bigognoDataSetDesdeHastaClienteRetiraTableAdapters.Get_ArticulosEnCCporClienteRetiraXFechaTableAdapter
End Class
