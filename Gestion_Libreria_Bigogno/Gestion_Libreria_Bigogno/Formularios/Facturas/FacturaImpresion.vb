Public Class FacturaImpresion

    Private Sub FacturaImpresion_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'libreria_bigognoDataSetMisDatosFactura.misdatos' Puede moverla o quitarla según sea necesario.
        Me.misdatosTableAdapter.Fill(Me.libreria_bigognoDataSetMisDatosFactura.misdatos)
        'TODO: esta línea de código carga datos en la tabla 'libreria_bigognoDataSetDetallesFactura.get_Factura' Puede moverla o quitarla según sea necesario.
        Me.get_FacturaTableAdapter.Fill(Me.libreria_bigognoDataSetDetallesFactura.get_Factura, Global_numeroVenta)
        Me.ReportViewer1.ZoomMode = Microsoft.Reporting.WinForms.ZoomMode.PageWidth
        Me.ReportViewer1.RefreshReport()
    End Sub
End Class