<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmInformeCCxCliente
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
        Me.libreria_bigognoDataSetCCxCliente = New GestionLibreriaBigogno.libreria_bigognoDataSetCCxCliente()
        Me.get_listadoCCxClienteBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.get_listadoCCxClienteTableAdapter = New GestionLibreriaBigogno.libreria_bigognoDataSetCCxClienteTableAdapters.get_listadoCCxClienteTableAdapter()
        CType(Me.libreria_bigognoDataSetCCxCliente, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.get_listadoCCxClienteBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ReportViewer1
        '
        Me.ReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill
        ReportDataSource1.Name = "DataSetCCxCliente"
        ReportDataSource1.Value = Me.get_listadoCCxClienteBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "GestionLibreriaBigogno.ReportCCxCliente.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(0, 0)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.Size = New System.Drawing.Size(944, 571)
        Me.ReportViewer1.TabIndex = 0
        '
        'libreria_bigognoDataSetCCxCliente
        '
        Me.libreria_bigognoDataSetCCxCliente.DataSetName = "libreria_bigognoDataSetCCxCliente"
        Me.libreria_bigognoDataSetCCxCliente.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'get_listadoCCxClienteBindingSource
        '
        Me.get_listadoCCxClienteBindingSource.DataMember = "get_listadoCCxCliente"
        Me.get_listadoCCxClienteBindingSource.DataSource = Me.libreria_bigognoDataSetCCxCliente
        '
        'get_listadoCCxClienteTableAdapter
        '
        Me.get_listadoCCxClienteTableAdapter.ClearBeforeFill = True
        '
        'FrmInformeCCxCliente
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(944, 571)
        Me.Controls.Add(Me.ReportViewer1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmInformeCCxCliente"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Informe de Cuenta Corriente por Cliente"
        CType(Me.libreria_bigognoDataSetCCxCliente, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.get_listadoCCxClienteBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents get_listadoCCxClienteBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents libreria_bigognoDataSetCCxCliente As GestionLibreriaBigogno.libreria_bigognoDataSetCCxCliente
    Friend WithEvents get_listadoCCxClienteTableAdapter As GestionLibreriaBigogno.libreria_bigognoDataSetCCxClienteTableAdapters.get_listadoCCxClienteTableAdapter
End Class
