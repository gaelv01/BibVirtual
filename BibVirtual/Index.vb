Public Class Index
    Public fondoOscuro = Color.FromArgb(255, 60, 60, 60)
    Public fondoOscuroSecondary = Color.FromArgb(255, 100, 100, 100)
    Public blanco = Color.White
    Public negro = Color.Black
    Private Sub Index_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblBienvenida.Text = "Bienvenido, " + Preferences.CustomName
        If Preferences.colorMode = "Modo Oscuro" Then
            spcContenedorProgram.BackColor = fondoOscuro
            PanelInicio.BackColor = fondoOscuro
            lblBienvenida.ForeColor = blanco
            btnAcercaDe.BackColor = fondoOscuro
            btnAcercaDe.ForeColor = blanco

        End If
    End Sub

End Class