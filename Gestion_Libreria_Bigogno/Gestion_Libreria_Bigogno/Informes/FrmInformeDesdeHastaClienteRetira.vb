Public Class FrmInformeDesdeHastaClienteRetira

    Private Sub FrmInformeDesdeHastaClienteRetira_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'libreria_bigognoDataSetDesdeHastaClienteRetira.Get_ArticulosEnCCporClienteRetiraXFecha' Puede moverla o quitarla según sea necesario.
        Me.Get_ArticulosEnCCporClienteRetiraXFechaTableAdapter.Fill(Me.libreria_bigognoDataSetDesdeHastaClienteRetira.Get_ArticulosEnCCporClienteRetiraXFecha, GlobalDesdeClienteCCRetira, GlobalHastaClienteCCRetira, GlobalIdClienteCCClienteretira, GlobalIdClienteCCRetira)
        Me.ReportViewer1.LocalReport.SetParameters(New Microsoft.Reporting.WinForms.ReportParameter("Desde", GlobalDesdeClienteCCRetira))
        Me.ReportViewer1.LocalReport.SetParameters(New Microsoft.Reporting.WinForms.ReportParameter("Hasta", GlobalHastaClienteCCRetira))
        Me.ReportViewer1.LocalReport.SetParameters(New Microsoft.Reporting.WinForms.ReportParameter("Cliente", GlobalClienteCCClienteretira))
        Me.ReportViewer1.LocalReport.SetParameters(New Microsoft.Reporting.WinForms.ReportParameter("Retira", GlobalClienteCCRetira))
        Me.ReportViewer1.ZoomMode = Microsoft.Reporting.WinForms.ZoomMode.PageWidth
        Me.ReportViewer1.RefreshReport()
    End Sub
End Class