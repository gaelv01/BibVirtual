<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmInicio
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmInicio))
        Me.lblMarca = New System.Windows.Forms.Label()
        Me.lblBienvenido = New System.Windows.Forms.Label()
        Me.gpbLogin = New System.Windows.Forms.GroupBox()
        Me.linkRegistrarse = New System.Windows.Forms.LinkLabel()
        Me.lblNoCuenta = New System.Windows.Forms.Label()
        Me.btnLogin = New System.Windows.Forms.Button()
        Me.txtContrasena = New System.Windows.Forms.TextBox()
        Me.txtUsuario = New System.Windows.Forms.TextBox()
        Me.lblContrasena = New System.Windows.Forms.Label()
        Me.lblUsuario = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.lblLogin = New System.Windows.Forms.Label()
        Me.btnModoOscuro = New System.Windows.Forms.Button()
        Me.gpbLogin.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblMarca
        '
        Me.lblMarca.AutoSize = True
        Me.lblMarca.Font = New System.Drawing.Font("Inter", 6.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblMarca.Location = New System.Drawing.Point(264, 335)
        Me.lblMarca.Name = "lblMarca"
        Me.lblMarca.Size = New System.Drawing.Size(135, 11)
        Me.lblMarca.TabIndex = 13
        Me.lblMarca.Text = "Powered by INTERACTIQ, Ltd."
        '
        'lblBienvenido
        '
        Me.lblBienvenido.AutoSize = True
        Me.lblBienvenido.Font = New System.Drawing.Font("Inter", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lblBienvenido.Location = New System.Drawing.Point(11, 6)
        Me.lblBienvenido.Name = "lblBienvenido"
        Me.lblBienvenido.Size = New System.Drawing.Size(191, 39)
        Me.lblBienvenido.TabIndex = 10
        Me.lblBienvenido.Text = "Bienvenido"
        Me.lblBienvenido.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'gpbLogin
        '
        Me.gpbLogin.Controls.Add(Me.linkRegistrarse)
        Me.gpbLogin.Controls.Add(Me.lblNoCuenta)
        Me.gpbLogin.Controls.Add(Me.btnLogin)
        Me.gpbLogin.Controls.Add(Me.txtContrasena)
        Me.gpbLogin.Controls.Add(Me.txtUsuario)
        Me.gpbLogin.Controls.Add(Me.lblContrasena)
        Me.gpbLogin.Controls.Add(Me.lblUsuario)
        Me.gpbLogin.Controls.Add(Me.PictureBox1)
        Me.gpbLogin.Controls.Add(Me.PictureBox2)
        Me.gpbLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.gpbLogin.Location = New System.Drawing.Point(15, 75)
        Me.gpbLogin.Name = "gpbLogin"
        Me.gpbLogin.Size = New System.Drawing.Size(384, 237)
        Me.gpbLogin.TabIndex = 12
        Me.gpbLogin.TabStop = False
        '
        'linkRegistrarse
        '
        Me.linkRegistrarse.AutoSize = True
        Me.linkRegistrarse.Font = New System.Drawing.Font("Inter Light", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.linkRegistrarse.Location = New System.Drawing.Point(149, 197)
        Me.linkRegistrarse.Name = "linkRegistrarse"
        Me.linkRegistrarse.Size = New System.Drawing.Size(86, 19)
        Me.linkRegistrarse.TabIndex = 10
        Me.linkRegistrarse.TabStop = True
        Me.linkRegistrarse.Text = "Regístrate"
        '
        'lblNoCuenta
        '
        Me.lblNoCuenta.AutoSize = True
        Me.lblNoCuenta.Font = New System.Drawing.Font("Inter Light", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblNoCuenta.Location = New System.Drawing.Point(100, 176)
        Me.lblNoCuenta.Name = "lblNoCuenta"
        Me.lblNoCuenta.Size = New System.Drawing.Size(184, 19)
        Me.lblNoCuenta.TabIndex = 8
        Me.lblNoCuenta.Text = "¿No tienes una cuenta?"
        Me.lblNoCuenta.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnLogin
        '
        Me.btnLogin.BackColor = System.Drawing.Color.White
        Me.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnLogin.Font = New System.Drawing.Font("Inter", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btnLogin.Location = New System.Drawing.Point(141, 122)
        Me.btnLogin.Name = "btnLogin"
        Me.btnLogin.Size = New System.Drawing.Size(103, 39)
        Me.btnLogin.TabIndex = 9
        Me.btnLogin.Text = "Entrar"
        Me.btnLogin.UseVisualStyleBackColor = False
        '
        'txtContrasena
        '
        Me.txtContrasena.Font = New System.Drawing.Font("Inter", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.txtContrasena.Location = New System.Drawing.Point(177, 73)
        Me.txtContrasena.Name = "txtContrasena"
        Me.txtContrasena.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtContrasena.PlaceholderText = "Tu clave"
        Me.txtContrasena.Size = New System.Drawing.Size(187, 30)
        Me.txtContrasena.TabIndex = 8
        '
        'txtUsuario
        '
        Me.txtUsuario.Font = New System.Drawing.Font("Inter", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.txtUsuario.Location = New System.Drawing.Point(177, 28)
        Me.txtUsuario.Name = "txtUsuario"
        Me.txtUsuario.PlaceholderText = "Tu nombre"
        Me.txtUsuario.Size = New System.Drawing.Size(187, 30)
        Me.txtUsuario.TabIndex = 7
        '
        'lblContrasena
        '
        Me.lblContrasena.AutoSize = True
        Me.lblContrasena.Font = New System.Drawing.Font("Inter", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblContrasena.Location = New System.Drawing.Point(50, 73)
        Me.lblContrasena.Name = "lblContrasena"
        Me.lblContrasena.Size = New System.Drawing.Size(119, 23)
        Me.lblContrasena.TabIndex = 6
        Me.lblContrasena.Text = "Contraseña:"
        Me.lblContrasena.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblUsuario
        '
        Me.lblUsuario.AutoSize = True
        Me.lblUsuario.Font = New System.Drawing.Font("Inter", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblUsuario.Location = New System.Drawing.Point(50, 28)
        Me.lblUsuario.Name = "lblUsuario"
        Me.lblUsuario.Size = New System.Drawing.Size(84, 23)
        Me.lblUsuario.TabIndex = 5
        Me.lblUsuario.Text = "Usuario:"
        Me.lblUsuario.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(10, 22)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(34, 35)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 2
        Me.PictureBox1.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(10, 63)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(34, 38)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox2.TabIndex = 3
        Me.PictureBox2.TabStop = False
        '
        'lblLogin
        '
        Me.lblLogin.AutoSize = True
        Me.lblLogin.Font = New System.Drawing.Font("Inter Light", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblLogin.Location = New System.Drawing.Point(15, 53)
        Me.lblLogin.Margin = New System.Windows.Forms.Padding(0)
        Me.lblLogin.Name = "lblLogin"
        Me.lblLogin.Size = New System.Drawing.Size(106, 19)
        Me.lblLogin.TabIndex = 11
        Me.lblLogin.Text = "Iniciar sesión"
        Me.lblLogin.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnModoOscuro
        '
        Me.btnModoOscuro.Location = New System.Drawing.Point(15, 323)
        Me.btnModoOscuro.Name = "btnModoOscuro"
        Me.btnModoOscuro.Size = New System.Drawing.Size(106, 23)
        Me.btnModoOscuro.TabIndex = 11
        Me.btnModoOscuro.Text = "Modo oscuro"
        Me.btnModoOscuro.UseVisualStyleBackColor = True
        '
        'frmInicio
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(414, 355)
        Me.Controls.Add(Me.btnModoOscuro)
        Me.Controls.Add(Me.lblMarca)
        Me.Controls.Add(Me.lblBienvenido)
        Me.Controls.Add(Me.gpbLogin)
        Me.Controls.Add(Me.lblLogin)
        Me.Font = New System.Drawing.Font("Inter", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.MaximizeBox = False
        Me.Name = "frmInicio"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Iniciar sesión"
        Me.gpbLogin.ResumeLayout(False)
        Me.gpbLogin.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
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
    Friend WithEvents btnModoOscuro As Button
End Class
