Public Class FrmInformeProveedores

    Private Sub FrmInformeProveedores_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'libreria_bigognoDataSetProveedores.proveedores' Puede moverla o quitarla según sea necesario.
        Me.proveedoresTableAdapter.Fill(Me.libreria_bigognoDataSetProveedores.proveedores)
        Me.ReportViewer1.ZoomMode = Microsoft.Reporting.WinForms.ZoomMode.PageWidth

        Me.ReportViewer1.RefreshReport()
    End Sub
End Class