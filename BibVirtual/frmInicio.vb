Public Class frmInicio
    ' Array que almacena los componentes del formulario
    Public FormComponents As Control()

    Private Sub frmInicio_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Inicializar los componentes del formulario
        InitializeFormComponents()
        ' Establecer la preferencia de modo oscuro en falso
        MPreferences.toggleOnDarkMode = False
    End Sub

    Private Sub InitializeFormComponents()
        ' Inicializar los componentes del formulario en un array
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
    End Sub

    Private Sub btnModoOscuro_Click(sender As Object, e As EventArgs) Handles btnModoOscuro.Click
        ' Cambiar la preferencia de modo oscuro y aplicar el modo oscuro al formulario actual
        MPreferences.toggleOnDarkMode = Not MPreferences.toggleOnDarkMode
        MDarkMode.ApplyDarkMode(Me, MPreferences.toggleOnDarkMode)
    End Sub

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        ' Verificar el nombre de usuario y contraseña y abrir el formulario de índice si son válidos
        Dim user As String = txtUsuario.Text
        Dim password As String = txtContrasena.Text
        If user = "admin" And password = "admin" Then
            frmIndex.Show()
            Me.Hide()
        End If
    End Sub
End Class
