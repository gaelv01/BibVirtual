<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmIndex
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As ComponentModel.ComponentResourceManager = New ComponentModel.ComponentResourceManager(GetType(frmIndex))
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
        Label1 = New Label()
        PanelActividades = New Panel()
        btnPersonalizar = New Button()
        lblSubBienvenida = New Label()
        lblBienvenida = New Label()
        CType(spcContenedorProgram, ComponentModel.ISupportInitialize).BeginInit()
        spcContenedorProgram.Panel1.SuspendLayout()
        spcContenedorProgram.Panel2.SuspendLayout()
        spcContenedorProgram.SuspendLayout()
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
        spcContenedorProgram.Panel2.Controls.Add(Label1)
        spcContenedorProgram.Panel2.Controls.Add(PanelActividades)
        spcContenedorProgram.Panel2.Controls.Add(btnPersonalizar)
        spcContenedorProgram.Panel2.Controls.Add(lblSubBienvenida)
        spcContenedorProgram.Panel2.Controls.Add(lblBienvenida)
        spcContenedorProgram.Size = New Size(1094, 654)
        spcContenedorProgram.SplitterDistance = 189
        spcContenedorProgram.TabIndex = 1
        ' 
        ' btnCerrarSesion
        ' 
        btnCerrarSesion.Dock = DockStyle.Top
        btnCerrarSesion.FlatAppearance.BorderColor = Color.White
        btnCerrarSesion.FlatStyle = FlatStyle.Flat
        btnCerrarSesion.Font = New Font("Inter", 15.75F, FontStyle.Regular, GraphicsUnit.Point)
        btnCerrarSesion.Location = New Point(0, 562)
        btnCerrarSesion.Name = "btnCerrarSesion"
        btnCerrarSesion.Size = New Size(189, 92)
        btnCerrarSesion.TabIndex = 9
        btnCerrarSesion.Text = "Salir"
        btnCerrarSesion.UseVisualStyleBackColor = True
        ' 
        ' btnAcercaDe
        ' 
        btnAcercaDe.Dock = DockStyle.Top
        btnAcercaDe.FlatAppearance.BorderColor = Color.White
        btnAcercaDe.FlatStyle = FlatStyle.Flat
        btnAcercaDe.Font = New Font("Inter", 14.25F, FontStyle.Regular, GraphicsUnit.Point)
        btnAcercaDe.Image = CType(resources.GetObject("btnAcercaDe.Image"), Image)
        btnAcercaDe.ImageAlign = ContentAlignment.MiddleRight
        btnAcercaDe.Location = New Point(0, 500)
        btnAcercaDe.Name = "btnAcercaDe"
        btnAcercaDe.Padding = New Padding(15, 0, 15, 0)
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
        btnAyuda.Image = CType(resources.GetObject("btnAyuda.Image"), Image)
        btnAyuda.ImageAlign = ContentAlignment.MiddleRight
        btnAyuda.Location = New Point(0, 438)
        btnAyuda.Name = "btnAyuda"
        btnAyuda.Padding = New Padding(15, 0, 15, 0)
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
        btnAjustes.Image = CType(resources.GetObject("btnAjustes.Image"), Image)
        btnAjustes.ImageAlign = ContentAlignment.MiddleRight
        btnAjustes.Location = New Point(0, 376)
        btnAjustes.Name = "btnAjustes"
        btnAjustes.Padding = New Padding(15, 0, 15, 0)
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
        btnHistorial.Image = CType(resources.GetObject("btnHistorial.Image"), Image)
        btnHistorial.ImageAlign = ContentAlignment.MiddleRight
        btnHistorial.Location = New Point(0, 314)
        btnHistorial.Name = "btnHistorial"
        btnHistorial.Padding = New Padding(15, 0, 15, 0)
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
        btnReservas.Image = CType(resources.GetObject("btnReservas.Image"), Image)
        btnReservas.ImageAlign = ContentAlignment.MiddleRight
        btnReservas.Location = New Point(0, 252)
        btnReservas.Name = "btnReservas"
        btnReservas.Padding = New Padding(15, 0, 15, 0)
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
        btnBuscar.Image = CType(resources.GetObject("btnBuscar.Image"), Image)
        btnBuscar.ImageAlign = ContentAlignment.MiddleRight
        btnBuscar.Location = New Point(0, 190)
        btnBuscar.Name = "btnBuscar"
        btnBuscar.Padding = New Padding(15, 0, 15, 0)
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
        btnMisLibros.Image = CType(resources.GetObject("btnMisLibros.Image"), Image)
        btnMisLibros.ImageAlign = ContentAlignment.MiddleRight
        btnMisLibros.Location = New Point(0, 128)
        btnMisLibros.Name = "btnMisLibros"
        btnMisLibros.Padding = New Padding(15, 0, 15, 0)
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
        btnInicio.Font = New Font("Inter", 20.25F, FontStyle.Regular, GraphicsUnit.Point)
        btnInicio.Image = CType(resources.GetObject("btnInicio.Image"), Image)
        btnInicio.ImageAlign = ContentAlignment.MiddleRight
        btnInicio.Location = New Point(0, 0)
        btnInicio.Name = "btnInicio"
        btnInicio.Padding = New Padding(15, 0, 15, 0)
        btnInicio.Size = New Size(189, 128)
        btnInicio.TabIndex = 1
        btnInicio.Text = "Inicio"
        btnInicio.TextAlign = ContentAlignment.MiddleLeft
        btnInicio.UseVisualStyleBackColor = True
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Inter", 8.25F, FontStyle.Regular, GraphicsUnit.Point)
        Label1.Location = New Point(724, 0)
        Label1.Name = "Label1"
        Label1.Size = New Size(177, 14)
        Label1.TabIndex = 8
        Label1.Text = "Impulsado por INTERACTIQ, Ltd."
        ' 
        ' PanelActividades
        ' 
        PanelActividades.Location = New Point(26, 162)
        PanelActividades.Name = "PanelActividades"
        PanelActividades.Size = New Size(846, 480)
        PanelActividades.TabIndex = 7
        ' 
        ' btnPersonalizar
        ' 
        btnPersonalizar.Location = New Point(782, 58)
        btnPersonalizar.Name = "btnPersonalizar"
        btnPersonalizar.Size = New Size(90, 23)
        btnPersonalizar.TabIndex = 6
        btnPersonalizar.Text = "Personalizar"
        btnPersonalizar.UseVisualStyleBackColor = True
        btnPersonalizar.Visible = False
        ' 
        ' lblSubBienvenida
        ' 
        lblSubBienvenida.AutoSize = True
        lblSubBienvenida.Font = New Font("Inter", 24F, FontStyle.Regular, GraphicsUnit.Point)
        lblSubBienvenida.Location = New Point(26, 95)
        lblSubBienvenida.Margin = New Padding(0)
        lblSubBienvenida.Name = "lblSubBienvenida"
        lblSubBienvenida.Size = New Size(443, 39)
        lblSubBienvenida.TabIndex = 4
        lblSubBienvenida.Text = "¿Qué te gustaría hacer hoy?"
        ' 
        ' lblBienvenida
        ' 
        lblBienvenida.AutoSize = True
        lblBienvenida.Font = New Font("Inter", 36F, FontStyle.Regular, GraphicsUnit.Point)
        lblBienvenida.Location = New Point(22, 28)
        lblBienvenida.Name = "lblBienvenida"
        lblBienvenida.Size = New Size(154, 58)
        lblBienvenida.TabIndex = 5
        lblBienvenida.Text = "¡Hola!"
        ' 
        ' frmIndex
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.White
        ClientSize = New Size(1094, 654)
        Controls.Add(spcContenedorProgram)
        Font = New Font("Inter", 9F, FontStyle.Regular, GraphicsUnit.Point)
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        MaximizeBox = False
        Name = "frmIndex"
        StartPosition = FormStartPosition.CenterScreen
        Text = "BibVirtual"
        spcContenedorProgram.Panel1.ResumeLayout(False)
        spcContenedorProgram.Panel2.ResumeLayout(False)
        spcContenedorProgram.Panel2.PerformLayout()
        CType(spcContenedorProgram, ComponentModel.ISupportInitialize).EndInit()
        spcContenedorProgram.ResumeLayout(False)
        ResumeLayout(False)
    End Sub

    Friend WithEvents spcContenedorProgram As SplitContainer
    Friend WithEvents btnCerrarSesion As Button
    Friend WithEvents btnAcercaDe As Button
    Friend WithEvents btnAyuda As Button
    Friend WithEvents btnAjustes As Button
    Friend WithEvents btnHistorial As Button
    Friend WithEvents btnReservas As Button
    Friend WithEvents btnBuscar As Button
    Friend WithEvents btnMisLibros As Button
    Friend WithEvents btnInicio As Button
    Friend WithEvents btnPersonalizar As Button
    Friend WithEvents lblSubBienvenida As Label
    Friend WithEvents lblBienvenida As Label
    Friend WithEvents PanelActividades As Panel
    Friend WithEvents Label1 As Label
End Class
