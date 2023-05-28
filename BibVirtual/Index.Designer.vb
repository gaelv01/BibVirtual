<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Index
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        spcContenedorProgram = New SplitContainer()
        btnCerrarSesion = New Button()
        btnAcercaDe = New Button()
        btnAyuda = New Button()
        btnAjustes = New Button()
        btnHistorial = New Button()
        btnReservas = New Button()
        btnBuscar = New Button()
        btnMisLibros = New Button()
        btnInicio = New Button()
        PanelInicio = New Panel()
        btnPersonalizar = New Button()
        GroupBox1 = New GroupBox()
        lblSubBienvenida = New Label()
        lblBienvenida = New Label()
        CType(spcContenedorProgram, ComponentModel.ISupportInitialize).BeginInit()
        spcContenedorProgram.Panel1.SuspendLayout()
        spcContenedorProgram.Panel2.SuspendLayout()
        spcContenedorProgram.SuspendLayout()
        PanelInicio.SuspendLayout()
        SuspendLayout()
        ' 
        ' spcContenedorProgram
        ' 
        spcContenedorProgram.Dock = DockStyle.Fill
        spcContenedorProgram.Location = New Point(0, 0)
        spcContenedorProgram.Name = "spcContenedorProgram"
        ' 
        ' spcContenedorProgram.Panel1
        ' 
        spcContenedorProgram.Panel1.Controls.Add(btnCerrarSesion)
        spcContenedorProgram.Panel1.Controls.Add(btnAcercaDe)
        spcContenedorProgram.Panel1.Controls.Add(btnAyuda)
        spcContenedorProgram.Panel1.Controls.Add(btnAjustes)
        spcContenedorProgram.Panel1.Controls.Add(btnHistorial)
        spcContenedorProgram.Panel1.Controls.Add(btnReservas)
        spcContenedorProgram.Panel1.Controls.Add(btnBuscar)
        spcContenedorProgram.Panel1.Controls.Add(btnMisLibros)
        spcContenedorProgram.Panel1.Controls.Add(btnInicio)
        ' 
        ' spcContenedorProgram.Panel2
        ' 
        spcContenedorProgram.Panel2.Controls.Add(PanelInicio)
        spcContenedorProgram.Size = New Size(1094, 654)
        spcContenedorProgram.SplitterDistance = 189
        spcContenedorProgram.TabIndex = 1
        ' 
        ' btnCerrarSesion
        ' 
        btnCerrarSesion.Dock = DockStyle.Top
        btnCerrarSesion.FlatAppearance.BorderColor = Color.White
        btnCerrarSesion.FlatStyle = FlatStyle.Flat
        btnCerrarSesion.Font = New Font("Inter SemiBold", 15.75F, FontStyle.Bold, GraphicsUnit.Point)
        btnCerrarSesion.Location = New Point(0, 562)
        btnCerrarSesion.Name = "btnCerrarSesion"
        btnCerrarSesion.Size = New Size(189, 92)
        btnCerrarSesion.TabIndex = 9
        btnCerrarSesion.Text = "Cerrar sesión"
        btnCerrarSesion.UseVisualStyleBackColor = True
        ' 
        ' btnAcercaDe
        ' 
        btnAcercaDe.Dock = DockStyle.Top
        btnAcercaDe.FlatAppearance.BorderColor = Color.White
        btnAcercaDe.FlatStyle = FlatStyle.Flat
        btnAcercaDe.Font = New Font("Inter", 14.25F, FontStyle.Regular, GraphicsUnit.Point)
        btnAcercaDe.Location = New Point(0, 500)
        btnAcercaDe.Name = "btnAcercaDe"
        btnAcercaDe.Size = New Size(189, 62)
        btnAcercaDe.TabIndex = 8
        btnAcercaDe.Text = "Acerca de"
        btnAcercaDe.TextAlign = ContentAlignment.MiddleLeft
        btnAcercaDe.UseVisualStyleBackColor = True
        ' 
        ' btnAyuda
        ' 
        btnAyuda.Dock = DockStyle.Top
        btnAyuda.FlatAppearance.BorderColor = Color.White
        btnAyuda.FlatStyle = FlatStyle.Flat
        btnAyuda.Font = New Font("Inter", 14.25F, FontStyle.Regular, GraphicsUnit.Point)
        btnAyuda.Location = New Point(0, 438)
        btnAyuda.Name = "btnAyuda"
        btnAyuda.Size = New Size(189, 62)
        btnAyuda.TabIndex = 7
        btnAyuda.Text = "Ayuda"
        btnAyuda.TextAlign = ContentAlignment.MiddleLeft
        btnAyuda.UseVisualStyleBackColor = True
        ' 
        ' btnAjustes
        ' 
        btnAjustes.Dock = DockStyle.Top
        btnAjustes.FlatAppearance.BorderColor = Color.White
        btnAjustes.FlatStyle = FlatStyle.Flat
        btnAjustes.Font = New Font("Inter", 14.25F, FontStyle.Regular, GraphicsUnit.Point)
        btnAjustes.Location = New Point(0, 376)
        btnAjustes.Name = "btnAjustes"
        btnAjustes.Size = New Size(189, 62)
        btnAjustes.TabIndex = 6
        btnAjustes.Text = "Ajustes"
        btnAjustes.TextAlign = ContentAlignment.MiddleLeft
        btnAjustes.UseVisualStyleBackColor = True
        ' 
        ' btnHistorial
        ' 
        btnHistorial.Dock = DockStyle.Top
        btnHistorial.FlatAppearance.BorderColor = Color.White
        btnHistorial.FlatStyle = FlatStyle.Flat
        btnHistorial.Font = New Font("Inter", 14.25F, FontStyle.Regular, GraphicsUnit.Point)
        btnHistorial.Location = New Point(0, 314)
        btnHistorial.Name = "btnHistorial"
        btnHistorial.Size = New Size(189, 62)
        btnHistorial.TabIndex = 5
        btnHistorial.Text = "Historial"
        btnHistorial.TextAlign = ContentAlignment.MiddleLeft
        btnHistorial.UseVisualStyleBackColor = True
        ' 
        ' btnReservas
        ' 
        btnReservas.Dock = DockStyle.Top
        btnReservas.FlatAppearance.BorderColor = Color.White
        btnReservas.FlatStyle = FlatStyle.Flat
        btnReservas.Font = New Font("Inter", 14.25F, FontStyle.Regular, GraphicsUnit.Point)
        btnReservas.Location = New Point(0, 252)
        btnReservas.Name = "btnReservas"
        btnReservas.Size = New Size(189, 62)
        btnReservas.TabIndex = 4
        btnReservas.Text = "Reservas"
        btnReservas.TextAlign = ContentAlignment.MiddleLeft
        btnReservas.UseVisualStyleBackColor = True
        ' 
        ' btnBuscar
        ' 
        btnBuscar.Dock = DockStyle.Top
        btnBuscar.FlatAppearance.BorderColor = Color.White
        btnBuscar.FlatStyle = FlatStyle.Flat
        btnBuscar.Font = New Font("Inter", 14.25F, FontStyle.Regular, GraphicsUnit.Point)
        btnBuscar.Location = New Point(0, 190)
        btnBuscar.Name = "btnBuscar"
        btnBuscar.Size = New Size(189, 62)
        btnBuscar.TabIndex = 3
        btnBuscar.Text = "Buscar"
        btnBuscar.TextAlign = ContentAlignment.MiddleLeft
        btnBuscar.UseVisualStyleBackColor = True
        ' 
        ' btnMisLibros
        ' 
        btnMisLibros.Dock = DockStyle.Top
        btnMisLibros.FlatAppearance.BorderColor = Color.White
        btnMisLibros.FlatStyle = FlatStyle.Flat
        btnMisLibros.Font = New Font("Inter", 14.25F, FontStyle.Regular, GraphicsUnit.Point)
        btnMisLibros.Location = New Point(0, 128)
        btnMisLibros.Name = "btnMisLibros"
        btnMisLibros.Size = New Size(189, 62)
        btnMisLibros.TabIndex = 2
        btnMisLibros.Text = "Mis libros"
        btnMisLibros.TextAlign = ContentAlignment.MiddleLeft
        btnMisLibros.UseVisualStyleBackColor = True
        ' 
        ' btnInicio
        ' 
        btnInicio.Dock = DockStyle.Top
        btnInicio.FlatAppearance.BorderColor = Color.White
        btnInicio.FlatStyle = FlatStyle.Flat
        btnInicio.Font = New Font("Inter", 20.25F, FontStyle.Bold, GraphicsUnit.Point)
        btnInicio.Location = New Point(0, 0)
        btnInicio.Name = "btnInicio"
        btnInicio.Size = New Size(189, 128)
        btnInicio.TabIndex = 1
        btnInicio.Text = "Inicio"
        btnInicio.TextAlign = ContentAlignment.MiddleLeft
        btnInicio.UseVisualStyleBackColor = True
        ' 
        ' PanelInicio
        ' 
        PanelInicio.Controls.Add(btnPersonalizar)
        PanelInicio.Controls.Add(GroupBox1)
        PanelInicio.Controls.Add(lblSubBienvenida)
        PanelInicio.Controls.Add(lblBienvenida)
        PanelInicio.Dock = DockStyle.Fill
        PanelInicio.Location = New Point(0, 0)
        PanelInicio.Name = "PanelInicio"
        PanelInicio.Size = New Size(901, 654)
        PanelInicio.TabIndex = 0
        ' 
        ' btnPersonalizar
        ' 
        btnPersonalizar.Location = New Point(799, 12)
        btnPersonalizar.Name = "btnPersonalizar"
        btnPersonalizar.Size = New Size(90, 23)
        btnPersonalizar.TabIndex = 3
        btnPersonalizar.Text = "Personalizar"
        btnPersonalizar.UseVisualStyleBackColor = True
        ' 
        ' GroupBox1
        ' 
        GroupBox1.Location = New Point(24, 152)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(825, 460)
        GroupBox1.TabIndex = 2
        GroupBox1.TabStop = False
        GroupBox1.Text = "GroupBox1"
        ' 
        ' lblSubBienvenida
        ' 
        lblSubBienvenida.AutoSize = True
        lblSubBienvenida.Font = New Font("Inter", 24F, FontStyle.Regular, GraphicsUnit.Point)
        lblSubBienvenida.Location = New Point(24, 89)
        lblSubBienvenida.Margin = New Padding(0)
        lblSubBienvenida.Name = "lblSubBienvenida"
        lblSubBienvenida.Size = New Size(443, 39)
        lblSubBienvenida.TabIndex = 1
        lblSubBienvenida.Text = "¿Qué te gustaría hacer hoy?"
        ' 
        ' lblBienvenida
        ' 
        lblBienvenida.AutoSize = True
        lblBienvenida.Font = New Font("Inter", 36F, FontStyle.Bold, GraphicsUnit.Point)
        lblBienvenida.Location = New Point(20, 22)
        lblBienvenida.Name = "lblBienvenida"
        lblBienvenida.Size = New Size(417, 58)
        lblBienvenida.TabIndex = 1
        lblBienvenida.Text = "Bienvenido, user"
        ' 
        ' Index
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.White
        ClientSize = New Size(1094, 654)
        Controls.Add(spcContenedorProgram)
        Name = "Index"
        Text = "Index"
        spcContenedorProgram.Panel1.ResumeLayout(False)
        spcContenedorProgram.Panel2.ResumeLayout(False)
        CType(spcContenedorProgram, ComponentModel.ISupportInitialize).EndInit()
        spcContenedorProgram.ResumeLayout(False)
        PanelInicio.ResumeLayout(False)
        PanelInicio.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents spcContenedorProgram As SplitContainer
    Friend WithEvents PanelInicio As Panel
    Friend WithEvents lblBienvenida As Label
    Friend WithEvents btnCerrarSesion As Button
    Friend WithEvents btnAcercaDe As Button
    Friend WithEvents btnAyuda As Button
    Friend WithEvents btnAjustes As Button
    Friend WithEvents btnHistorial As Button
    Friend WithEvents btnReservas As Button
    Friend WithEvents btnBuscar As Button
    Friend WithEvents btnMisLibros As Button
    Friend WithEvents btnInicio As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents lblSubBienvenida As Label
    Friend WithEvents btnPersonalizar As Button
End Class
