Public Class FrmInformeComprasxProveedores

    Private Sub FrmInformeComprasxProveedores_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'libreria_bigognoDataSetComprasXproveedor.Get_ComprasXvendedorYfecha' Puede moverla o quitarla según sea necesario.
        Me.Get_ComprasXvendedorYfechaTableAdapter.Fill(Me.libreria_bigognoDataSetComprasXproveedor.Get_ComprasXvendedorYfecha, GlobalIdProveedor, GlobalDesdeProveedor, GlobalHastaProveedor)
        Me.ReportViewer1.LocalReport.SetParameters(New Microsoft.Reporting.WinForms.ReportParameter("Desde", GlobalDesdeProveedor))
        Me.ReportViewer1.LocalReport.SetParameters(New Microsoft.Reporting.WinForms.ReportParameter("Hasta", GlobalHastaProveedor))
        Me.ReportViewer1.LocalReport.SetParameters(New Microsoft.Reporting.WinForms.ReportParameter("IdProveedor", GlobalIdProveedor))
        Me.ReportViewer1.LocalReport.SetParameters(New Microsoft.Reporting.WinForms.ReportParameter("Proveedor", GlobalProveedor))

        Me.ReportViewer1.ZoomMode = Microsoft.Reporting.WinForms.ZoomMode.PageWidth
        Me.ReportViewer1.RefreshReport()
    End Sub
End Class