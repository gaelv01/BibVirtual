Public Class Form1


    Private Sub btnClaroOscuro_Click_1(sender As Object, e As EventArgs) Handles btnClaroOscuro.Click
        Dim fondoOscuro = Color.FromArgb(255, 60, 60, 60)
        Dim fondoOscuroSecondary = Color.FromArgb(255, 100, 100, 100)
        Dim blanco = Color.White
        Dim negro = Color.Black
        If btnClaroOscuro.Text = "Modo Oscuro" Then
            Preferences.colorMode = "Modo Oscuro"
            Me.BackColor = fondoOscuro
            gpbLogin.BackColor = fondoOscuroSecondary
            lblBienvenido.ForeColor = blanco
            lblLogin.ForeColor = blanco
            lblUsuario.ForeColor = blanco
            lblContrasena.ForeColor = blanco
            lblNoCuenta.ForeColor = blanco
            linkRegistrarse.ForeColor = blanco
            lblMarca.ForeColor = blanco
            btnClaroOscuro.Text = "Modo Claro"
            btnClaroOscuro.ForeColor = negro
            btnClaroOscuro.BackColor = blanco
        ElseIf btnClaroOscuro.Text = "Modo Claro" Then
            Preferences.colorMode = "Modo Claro"
            Me.BackColor = blanco
            gpbLogin.BackColor = blanco
            lblBienvenido.ForeColor = negro
            lblLogin.ForeColor = negro
            lblUsuario.ForeColor = negro
            lblContrasena.ForeColor = negro
            lblNoCuenta.ForeColor = negro
            linkRegistrarse.ForeColor = negro
            lblMarca.ForeColor = negro
            btnClaroOscuro.Text = "Modo Oscuro"
            btnClaroOscuro.ForeColor = blanco
            btnClaroOscuro.BackColor = fondoOscuro
        End If



    End Sub

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        Dim user As String
        Dim password As String
        user = txtUsuario.Text
        password = txtContrasena.Text
        If user = "admin" And password = "admin" Then
            Preferences.CustomName = "Gael Vivas"
            Index.Show()
            Me.Hide()
        End If
    End Sub

End Class
