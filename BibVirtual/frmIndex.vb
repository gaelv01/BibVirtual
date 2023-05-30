Public Class frmIndex
    Public FormComponents As Control()

    Private Sub frmIndex_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        FormComponents = New Control() {
            spcContenedorProgram,
            PanelInicio,
            lblBienvenida,
            lblSubBienvenida,
            btnAcercaDe,
            btnAjustes,
            btnAyuda,
            btnBuscar,
            btnCerrarSesion,
            btnHistorial,
            btnInicio,
            btnMisLibros,
            btnPersonalizar,
            btnReservas
        }
        MDarkMode.ApplyDarkMode(Me, MPreferences.toggleOnDarkMode)
    End Sub

    Private Sub btnPersonalizar_Click(sender As Object, e As EventArgs) Handles btnPersonalizar.Click
        frmPersonalizar.Show()
    End Sub
End Class