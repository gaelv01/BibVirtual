Public Class frmInicio
    'Public isDarkModeOn As Boolean

    Private FormComponents As Control()

    Private Sub frmInicio_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        FormComponents = New Control() {
            lblBienvenido,
            lblContrasena,
            lblLogin,
            lblMarca,
            lblNoCuenta,
            lblUsuario,
            txtContrasena,
            txtUsuario,
            gpbLogin,
            btnLogin,
            btnModoOscuro
        }
        MPreferences.toggleOnDarkMode = False
    End Sub

    Private Sub btnModoOscuro_Click(sender As Object, e As EventArgs) Handles btnModoOscuro.Click
        MPreferences.toggleOnDarkMode = Not MPreferences.toggleOnDarkMode

        MDarkMode.ApplyDarkMode(Me, MPreferences.toggleOnDarkMode)

    End Sub

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        Dim user As String
        Dim password As String
        user = txtUsuario.Text
        password = txtContrasena.Text
        If user = "admin" And password = "admin" Then
            frmIndex.Show()
            Me.Hide()
        End If
    End Sub
End Class
