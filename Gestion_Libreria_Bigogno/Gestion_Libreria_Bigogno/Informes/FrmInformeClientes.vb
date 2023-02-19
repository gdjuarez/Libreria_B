Public Class FrmInformeClientes

    Private Sub FrmInformeClientes_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'libreria_BigognoDataSetClientes.cliente' Puede moverla o quitarla según sea necesario.
        Me.clienteTableAdapter.Fill(Me.libreria_BigognoDataSetClientes.cliente)
        Me.ReportViewer1.ZoomMode = Microsoft.Reporting.WinForms.ZoomMode.PageWidth
        Me.ReportViewer1.RefreshReport()
    End Sub
End Class