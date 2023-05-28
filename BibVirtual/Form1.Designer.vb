<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As ComponentModel.ComponentResourceManager = New ComponentModel.ComponentResourceManager(GetType(Form1))
        btnClaroOscuro = New Button()
        lblMarca = New Label()
        lblBienvenido = New Label()
        gpbLogin = New GroupBox()
        linkRegistrarse = New LinkLabel()
        lblNoCuenta = New Label()
        btnLogin = New Button()
        txtContrasena = New TextBox()
        txtUsuario = New TextBox()
        lblContrasena = New Label()
        lblUsuario = New Label()
        PictureBox1 = New PictureBox()
        PictureBox2 = New PictureBox()
        lblLogin = New Label()
        gpbLogin.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' btnClaroOscuro
        ' 
        btnClaroOscuro.BackColor = Color.FromArgb(CByte(80), CByte(80), CByte(80))
        btnClaroOscuro.FlatStyle = FlatStyle.Flat
        btnClaroOscuro.Font = New Font("Inter", 6.749999F, FontStyle.Regular, GraphicsUnit.Point)
        btnClaroOscuro.ForeColor = Color.White
        btnClaroOscuro.Location = New Point(15, 318)
        btnClaroOscuro.Name = "btnClaroOscuro"
        btnClaroOscuro.Size = New Size(83, 28)
        btnClaroOscuro.TabIndex = 14
        btnClaroOscuro.Text = "Modo Oscuro"
        btnClaroOscuro.UseVisualStyleBackColor = False
        ' 
        ' lblMarca
        ' 
        lblMarca.AutoSize = True
        lblMarca.Font = New Font("Inter", 6.749999F, FontStyle.Regular, GraphicsUnit.Point)
        lblMarca.Location = New Point(264, 335)
        lblMarca.Name = "lblMarca"
        lblMarca.Size = New Size(135, 11)
        lblMarca.TabIndex = 13
        lblMarca.Text = "Powered by INTERACTIQ, Ltd."
        ' 
        ' lblBienvenido
        ' 
        lblBienvenido.AutoSize = True
        lblBienvenido.Font = New Font("Inter", 24F, FontStyle.Bold, GraphicsUnit.Point)
        lblBienvenido.Location = New Point(11, 6)
        lblBienvenido.Name = "lblBienvenido"
        lblBienvenido.Size = New Size(191, 39)
        lblBienvenido.TabIndex = 10
        lblBienvenido.Text = "Bienvenido"
        lblBienvenido.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' gpbLogin
        ' 
        gpbLogin.Controls.Add(linkRegistrarse)
        gpbLogin.Controls.Add(lblNoCuenta)
        gpbLogin.Controls.Add(btnLogin)
        gpbLogin.Controls.Add(txtContrasena)
        gpbLogin.Controls.Add(txtUsuario)
        gpbLogin.Controls.Add(lblContrasena)
        gpbLogin.Controls.Add(lblUsuario)
        gpbLogin.Controls.Add(PictureBox1)
        gpbLogin.Controls.Add(PictureBox2)
        gpbLogin.FlatStyle = FlatStyle.Flat
        gpbLogin.Location = New Point(15, 75)
        gpbLogin.Name = "gpbLogin"
        gpbLogin.Size = New Size(384, 237)
        gpbLogin.TabIndex = 12
        gpbLogin.TabStop = False
        ' 
        ' linkRegistrarse
        ' 
        linkRegistrarse.AutoSize = True
        linkRegistrarse.Font = New Font("Inter Light", 12F, FontStyle.Regular, GraphicsUnit.Point)
        linkRegistrarse.Location = New Point(149, 197)
        linkRegistrarse.Name = "linkRegistrarse"
        linkRegistrarse.Size = New Size(86, 19)
        linkRegistrarse.TabIndex = 10
        linkRegistrarse.TabStop = True
        linkRegistrarse.Text = "Regístrate"
        ' 
        ' lblNoCuenta
        ' 
        lblNoCuenta.AutoSize = True
        lblNoCuenta.Font = New Font("Inter Light", 12F, FontStyle.Regular, GraphicsUnit.Point)
        lblNoCuenta.Location = New Point(100, 176)
        lblNoCuenta.Name = "lblNoCuenta"
        lblNoCuenta.Size = New Size(184, 19)
        lblNoCuenta.TabIndex = 8
        lblNoCuenta.Text = "¿No tienes una cuenta?"
        lblNoCuenta.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' btnLogin
        ' 
        btnLogin.BackColor = Color.White
        btnLogin.FlatStyle = FlatStyle.Flat
        btnLogin.Font = New Font("Inter", 14.25F, FontStyle.Regular, GraphicsUnit.Point)
        btnLogin.Location = New Point(141, 122)
        btnLogin.Name = "btnLogin"
        btnLogin.Size = New Size(103, 39)
        btnLogin.TabIndex = 9
        btnLogin.Text = "Entrar"
        btnLogin.UseVisualStyleBackColor = False
        ' 
        ' txtContrasena
        ' 
        txtContrasena.Font = New Font("Inter", 14F, FontStyle.Regular, GraphicsUnit.Point)
        txtContrasena.Location = New Point(177, 73)
        txtContrasena.Name = "txtContrasena"
        txtContrasena.PasswordChar = "*"c
        txtContrasena.PlaceholderText = "Tu clave"
        txtContrasena.Size = New Size(187, 30)
        txtContrasena.TabIndex = 8
        ' 
        ' txtUsuario
        ' 
        txtUsuario.Font = New Font("Inter", 14F, FontStyle.Regular, GraphicsUnit.Point)
        txtUsuario.Location = New Point(177, 28)
        txtUsuario.Name = "txtUsuario"
        txtUsuario.PlaceholderText = "Tu nombre"
        txtUsuario.Size = New Size(187, 30)
        txtUsuario.TabIndex = 7
        ' 
        ' lblContrasena
        ' 
        lblContrasena.AutoSize = True
        lblContrasena.Font = New Font("Inter", 14F, FontStyle.Regular, GraphicsUnit.Point)
        lblContrasena.Location = New Point(50, 73)
        lblContrasena.Name = "lblContrasena"
        lblContrasena.Size = New Size(119, 23)
        lblContrasena.TabIndex = 6
        lblContrasena.Text = "Contraseña:"
        lblContrasena.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' lblUsuario
        ' 
        lblUsuario.AutoSize = True
        lblUsuario.Font = New Font("Inter", 14F, FontStyle.Regular, GraphicsUnit.Point)
        lblUsuario.Location = New Point(50, 28)
        lblUsuario.Name = "lblUsuario"
        lblUsuario.Size = New Size(84, 23)
        lblUsuario.TabIndex = 5
        lblUsuario.Text = "Usuario:"
        lblUsuario.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(10, 22)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(34, 35)
        PictureBox1.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox1.TabIndex = 2
        PictureBox1.TabStop = False
        ' 
        ' PictureBox2
        ' 
        PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), Image)
        PictureBox2.Location = New Point(10, 63)
        PictureBox2.Name = "PictureBox2"
        PictureBox2.Size = New Size(34, 38)
        PictureBox2.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox2.TabIndex = 3
        PictureBox2.TabStop = False
        ' 
        ' lblLogin
        ' 
        lblLogin.AutoSize = True
        lblLogin.Font = New Font("Inter Light", 12F, FontStyle.Regular, GraphicsUnit.Point)
        lblLogin.Location = New Point(15, 53)
        lblLogin.Margin = New Padding(0)
        lblLogin.Name = "lblLogin"
        lblLogin.Size = New Size(106, 19)
        lblLogin.TabIndex = 11
        lblLogin.Text = "Iniciar sesión"
        lblLogin.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        AutoSizeMode = AutoSizeMode.GrowAndShrink
        BackColor = Color.White
        ClientSize = New Size(414, 355)
        Controls.Add(btnClaroOscuro)
        Controls.Add(lblMarca)
        Controls.Add(lblBienvenido)
        Controls.Add(gpbLogin)
        Controls.Add(lblLogin)
        Font = New Font("Inter", 9F, FontStyle.Regular, GraphicsUnit.Point)
        MaximizeBox = False
        Name = "Form1"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Iniciar sesión"
        gpbLogin.ResumeLayout(False)
        gpbLogin.PerformLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents btnClaroOscuro As Button
    Friend WithEvents lblMarca As Label
    Friend WithEvents lblBienvenido As Label
    Friend WithEvents gpbLogin As GroupBox
    Friend WithEvents linkRegistrarse As LinkLabel
    Friend WithEvents lblNoCuenta As Label
    Friend WithEvents btnLogin As Button
    Friend WithEvents txtContrasena As TextBox
    Friend WithEvents txtUsuario As TextBox
    Friend WithEvents lblContrasena As Label
    Friend WithEvents lblUsuario As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents lblLogin As Label
End Class
