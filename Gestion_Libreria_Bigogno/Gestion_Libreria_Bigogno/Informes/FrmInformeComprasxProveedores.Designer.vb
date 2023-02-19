<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmInformeComprasxProveedores
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
        Dim ReportDataSource2 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.libreria_bigognoDataSetComprasXproveedor = New GestionLibreriaBigogno.libreria_bigognoDataSetComprasXproveedor()
        Me.Get_ComprasXvendedorYfechaBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Get_ComprasXvendedorYfechaTableAdapter = New GestionLibreriaBigogno.libreria_bigognoDataSetComprasXproveedorTableAdapters.Get_ComprasXvendedorYfechaTableAdapter()
        CType(Me.libreria_bigognoDataSetComprasXproveedor, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Get_ComprasXvendedorYfechaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ReportViewer1
        '
        Me.ReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill
        ReportDataSource2.Name = "DataSetComprasXProveedor"
        ReportDataSource2.Value = Me.Get_ComprasXvendedorYfechaBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource2)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "GestionLibreriaBigogno.ReportComprasXProveedor.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(0, 0)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.Size = New System.Drawing.Size(794, 571)
        Me.ReportViewer1.TabIndex = 0
        '
        'libreria_bigognoDataSetComprasXproveedor
        '
        Me.libreria_bigognoDataSetComprasXproveedor.DataSetName = "libreria_bigognoDataSetComprasXproveedor"
        Me.libreria_bigognoDataSetComprasXproveedor.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Get_ComprasXvendedorYfechaBindingSource
        '
        Me.Get_ComprasXvendedorYfechaBindingSource.DataMember = "Get_ComprasXvendedorYfecha"
        Me.Get_ComprasXvendedorYfechaBindingSource.DataSource = Me.libreria_bigognoDataSetComprasXproveedor
        '
        'Get_ComprasXvendedorYfechaTableAdapter
        '
        Me.Get_ComprasXvendedorYfechaTableAdapter.ClearBeforeFill = True
        '
        'FrmInformeComprasxProveedores
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(794, 571)
        Me.Controls.Add(Me.ReportViewer1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmInformeComprasxProveedores"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FrmInformeComprasxProveedores"
        CType(Me.libreria_bigognoDataSetComprasXproveedor, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Get_ComprasXvendedorYfechaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents Get_ComprasXvendedorYfechaBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents libreria_bigognoDataSetComprasXproveedor As GestionLibreriaBigogno.libreria_bigognoDataSetComprasXproveedor
    Friend WithEvents Get_ComprasXvendedorYfechaTableAdapter As GestionLibreriaBigogno.libreria_bigognoDataSetComprasXproveedorTableAdapters.Get_ComprasXvendedorYfechaTableAdapter
End Class
