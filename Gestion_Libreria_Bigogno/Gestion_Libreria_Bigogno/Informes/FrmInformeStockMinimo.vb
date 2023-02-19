Public Class FrmInformeStockMinimo

    Private Sub FrmStockMinimo_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'libreria_bigognoDataSetStockMinimo.vista_stockminimocompleto' Puede moverla o quitarla según sea necesario.
        Me.vista_stockminimocompletoTableAdapter.Fill(Me.libreria_bigognoDataSetStockMinimo.vista_stockminimocompleto)
        Me.ReportViewer1.ZoomMode = Microsoft.Reporting.WinForms.ZoomMode.PageWidth
        Me.ReportViewer1.RefreshReport()
    End Sub
End Class