<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmInformeProveedores
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
        Me.libreria_bigognoDataSetProveedores = New GestionLibreriaBigogno.libreria_bigognoDataSetProveedores()
        Me.proveedoresBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.proveedoresTableAdapter = New GestionLibreriaBigogno.libreria_bigognoDataSetProveedoresTableAdapters.proveedoresTableAdapter()
        CType(Me.libreria_bigognoDataSetProveedores, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.proveedoresBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ReportViewer1
        '
        Me.ReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill
        ReportDataSource1.Name = "DataSetProveedores"
        ReportDataSource1.Value = Me.proveedoresBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "GestionLibreriaBigogno.ReportProveedores.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(0, 0)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.Size = New System.Drawing.Size(784, 561)
        Me.ReportViewer1.TabIndex = 0
        '
        'libreria_bigognoDataSetProveedores
        '
        Me.libreria_bigognoDataSetProveedores.DataSetName = "libreria_bigognoDataSetProveedores"
        Me.libreria_bigognoDataSetProveedores.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'proveedoresBindingSource
        '
        Me.proveedoresBindingSource.DataMember = "proveedores"
        Me.proveedoresBindingSource.DataSource = Me.libreria_bigognoDataSetProveedores
        '
        'proveedoresTableAdapter
        '
        Me.proveedoresTableAdapter.ClearBeforeFill = True
        '
        'FrmInformeProveedores
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(784, 561)
        Me.Controls.Add(Me.ReportViewer1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmInformeProveedores"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FrmInformeProveedores"
        CType(Me.libreria_bigognoDataSetProveedores, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.proveedoresBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents proveedoresBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents libreria_bigognoDataSetProveedores As GestionLibreriaBigogno.libreria_bigognoDataSetProveedores
    Friend WithEvents proveedoresTableAdapter As GestionLibreriaBigogno.libreria_bigognoDataSetProveedoresTableAdapters.proveedoresTableAdapter
End Class
