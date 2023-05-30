<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmIndex
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmIndex))
        Me.spcContenedorProgram = New System.Windows.Forms.SplitContainer()
        Me.btnCerrarSesion = New System.Windows.Forms.Button()
        Me.btnAcercaDe = New System.Windows.Forms.Button()
        Me.btnAyuda = New System.Windows.Forms.Button()
        Me.btnAjustes = New System.Windows.Forms.Button()
        Me.btnHistorial = New System.Windows.Forms.Button()
        Me.btnReservas = New System.Windows.Forms.Button()
        Me.btnBuscar = New System.Windows.Forms.Button()
        Me.btnMisLibros = New System.Windows.Forms.Button()
        Me.btnInicio = New System.Windows.Forms.Button()
        Me.PanelInicio = New System.Windows.Forms.Panel()
        Me.btnPersonalizar = New System.Windows.Forms.Button()
        Me.lblSubBienvenida = New System.Windows.Forms.Label()
        Me.lblBienvenida = New System.Windows.Forms.Label()
        CType(Me.spcContenedorProgram, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.spcContenedorProgram.Panel1.SuspendLayout()
        Me.spcContenedorProgram.Panel2.SuspendLayout()
        Me.spcContenedorProgram.SuspendLayout()
        Me.PanelInicio.SuspendLayout()
        Me.SuspendLayout()
        '
        'spcContenedorProgram
        '
        Me.spcContenedorProgram.Dock = System.Windows.Forms.DockStyle.Fill
        Me.spcContenedorProgram.Location = New System.Drawing.Point(0, 0)
        Me.spcContenedorProgram.Name = "spcContenedorProgram"
        '
        'spcContenedorProgram.Panel1
        '
        Me.spcContenedorProgram.Panel1.Controls.Add(Me.btnCerrarSesion)
        Me.spcContenedorProgram.Panel1.Controls.Add(Me.btnAcercaDe)
        Me.spcContenedorProgram.Panel1.Controls.Add(Me.btnAyuda)
        Me.spcContenedorProgram.Panel1.Controls.Add(Me.btnAjustes)
        Me.spcContenedorProgram.Panel1.Controls.Add(Me.btnHistorial)
        Me.spcContenedorProgram.Panel1.Controls.Add(Me.btnReservas)
        Me.spcContenedorProgram.Panel1.Controls.Add(Me.btnBuscar)
        Me.spcContenedorProgram.Panel1.Controls.Add(Me.btnMisLibros)
        Me.spcContenedorProgram.Panel1.Controls.Add(Me.btnInicio)
        '
        'spcContenedorProgram.Panel2
        '
        Me.spcContenedorProgram.Panel2.Controls.Add(Me.PanelInicio)
        Me.spcContenedorProgram.Size = New System.Drawing.Size(1094, 654)
        Me.spcContenedorProgram.SplitterDistance = 189
        Me.spcContenedorProgram.TabIndex = 1
        '
        'btnCerrarSesion
        '
        Me.btnCerrarSesion.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnCerrarSesion.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.btnCerrarSesion.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCerrarSesion.Font = New System.Drawing.Font("Inter", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btnCerrarSesion.Location = New System.Drawing.Point(0, 562)
        Me.btnCerrarSesion.Name = "btnCerrarSesion"
        Me.btnCerrarSesion.Size = New System.Drawing.Size(189, 92)
        Me.btnCerrarSesion.TabIndex = 9
        Me.btnCerrarSesion.Text = "Cerrar sesión"
        Me.btnCerrarSesion.UseVisualStyleBackColor = True
        '
        'btnAcercaDe
        '
        Me.btnAcercaDe.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnAcercaDe.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.btnAcercaDe.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAcercaDe.Font = New System.Drawing.Font("Inter", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btnAcercaDe.Image = CType(resources.GetObject("btnAcercaDe.Image"), System.Drawing.Image)
        Me.btnAcercaDe.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnAcercaDe.Location = New System.Drawing.Point(0, 500)
        Me.btnAcercaDe.Name = "btnAcercaDe"
        Me.btnAcercaDe.Size = New System.Drawing.Size(189, 62)
        Me.btnAcercaDe.TabIndex = 8
        Me.btnAcercaDe.Text = "Acerca de"
        Me.btnAcercaDe.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnAcercaDe.UseVisualStyleBackColor = True
        '
        'btnAyuda
        '
        Me.btnAyuda.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnAyuda.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.btnAyuda.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAyuda.Font = New System.Drawing.Font("Inter", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btnAyuda.Image = CType(resources.GetObject("btnAyuda.Image"), System.Drawing.Image)
        Me.btnAyuda.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnAyuda.Location = New System.Drawing.Point(0, 438)
        Me.btnAyuda.Name = "btnAyuda"
        Me.btnAyuda.Size = New System.Drawing.Size(189, 62)
        Me.btnAyuda.TabIndex = 7
        Me.btnAyuda.Text = "Ayuda"
        Me.btnAyuda.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnAyuda.UseVisualStyleBackColor = True
        '
        'btnAjustes
        '
        Me.btnAjustes.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnAjustes.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.btnAjustes.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAjustes.Font = New System.Drawing.Font("Inter", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btnAjustes.Image = CType(resources.GetObject("btnAjustes.Image"), System.Drawing.Image)
        Me.btnAjustes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnAjustes.Location = New System.Drawing.Point(0, 376)
        Me.btnAjustes.Name = "btnAjustes"
        Me.btnAjustes.Size = New System.Drawing.Size(189, 62)
        Me.btnAjustes.TabIndex = 6
        Me.btnAjustes.Text = "Ajustes"
        Me.btnAjustes.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnAjustes.UseVisualStyleBackColor = True
        '
        'btnHistorial
        '
        Me.btnHistorial.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnHistorial.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.btnHistorial.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnHistorial.Font = New System.Drawing.Font("Inter", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btnHistorial.Image = CType(resources.GetObject("btnHistorial.Image"), System.Drawing.Image)
        Me.btnHistorial.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnHistorial.Location = New System.Drawing.Point(0, 314)
        Me.btnHistorial.Name = "btnHistorial"
        Me.btnHistorial.Size = New System.Drawing.Size(189, 62)
        Me.btnHistorial.TabIndex = 5
        Me.btnHistorial.Text = "Historial"
        Me.btnHistorial.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnHistorial.UseVisualStyleBackColor = True
        '
        'btnReservas
        '
        Me.btnReservas.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnReservas.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.btnReservas.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnReservas.Font = New System.Drawing.Font("Inter", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btnReservas.Image = CType(resources.GetObject("btnReservas.Image"), System.Drawing.Image)
        Me.btnReservas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnReservas.Location = New System.Drawing.Point(0, 252)
        Me.btnReservas.Name = "btnReservas"
        Me.btnReservas.Size = New System.Drawing.Size(189, 62)
        Me.btnReservas.TabIndex = 4
        Me.btnReservas.Text = "Reservas"
        Me.btnReservas.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnReservas.UseVisualStyleBackColor = True
        '
        'btnBuscar
        '
        Me.btnBuscar.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnBuscar.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBuscar.Font = New System.Drawing.Font("Inter", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btnBuscar.Image = CType(resources.GetObject("btnBuscar.Image"), System.Drawing.Image)
        Me.btnBuscar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnBuscar.Location = New System.Drawing.Point(0, 190)
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.Size = New System.Drawing.Size(189, 62)
        Me.btnBuscar.TabIndex = 3
        Me.btnBuscar.Text = "Buscar"
        Me.btnBuscar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnBuscar.UseVisualStyleBackColor = True
        '
        'btnMisLibros
        '
        Me.btnMisLibros.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnMisLibros.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.btnMisLibros.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnMisLibros.Font = New System.Drawing.Font("Inter", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btnMisLibros.Image = CType(resources.GetObject("btnMisLibros.Image"), System.Drawing.Image)
        Me.btnMisLibros.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnMisLibros.Location = New System.Drawing.Point(0, 128)
        Me.btnMisLibros.Name = "btnMisLibros"
        Me.btnMisLibros.Size = New System.Drawing.Size(189, 62)
        Me.btnMisLibros.TabIndex = 2
        Me.btnMisLibros.Text = "Mis libros"
        Me.btnMisLibros.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnMisLibros.UseVisualStyleBackColor = True
        '
        'btnInicio
        '
        Me.btnInicio.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnInicio.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.btnInicio.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnInicio.Font = New System.Drawing.Font("Inter", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btnInicio.Image = CType(resources.GetObject("btnInicio.Image"), System.Drawing.Image)
        Me.btnInicio.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnInicio.Location = New System.Drawing.Point(0, 0)
        Me.btnInicio.Name = "btnInicio"
        Me.btnInicio.Size = New System.Drawing.Size(189, 128)
        Me.btnInicio.TabIndex = 1
        Me.btnInicio.Text = "Inicio"
        Me.btnInicio.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnInicio.UseVisualStyleBackColor = True
        '
        'PanelInicio
        '
        Me.PanelInicio.Controls.Add(Me.btnPersonalizar)
        Me.PanelInicio.Controls.Add(Me.lblSubBienvenida)
        Me.PanelInicio.Controls.Add(Me.lblBienvenida)
        Me.PanelInicio.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelInicio.Location = New System.Drawing.Point(0, 0)
        Me.PanelInicio.Name = "PanelInicio"
        Me.PanelInicio.Size = New System.Drawing.Size(901, 654)
        Me.PanelInicio.TabIndex = 0
        '
        'btnPersonalizar
        '
        Me.btnPersonalizar.Location = New System.Drawing.Point(799, 12)
        Me.btnPersonalizar.Name = "btnPersonalizar"
        Me.btnPersonalizar.Size = New System.Drawing.Size(90, 23)
        Me.btnPersonalizar.TabIndex = 3
        Me.btnPersonalizar.Text = "Personalizar"
        Me.btnPersonalizar.UseVisualStyleBackColor = True
        '
        'lblSubBienvenida
        '
        Me.lblSubBienvenida.AutoSize = True
        Me.lblSubBienvenida.Font = New System.Drawing.Font("Inter", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblSubBienvenida.Location = New System.Drawing.Point(24, 89)
        Me.lblSubBienvenida.Margin = New System.Windows.Forms.Padding(0)
        Me.lblSubBienvenida.Name = "lblSubBienvenida"
        Me.lblSubBienvenida.Size = New System.Drawing.Size(443, 39)
        Me.lblSubBienvenida.TabIndex = 1
        Me.lblSubBienvenida.Text = "¿Qué te gustaría hacer hoy?"
        '
        'lblBienvenida
        '
        Me.lblBienvenida.AutoSize = True
        Me.lblBienvenida.Font = New System.Drawing.Font("Inter", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lblBienvenida.Location = New System.Drawing.Point(20, 22)
        Me.lblBienvenida.Name = "lblBienvenida"
        Me.lblBienvenida.Size = New System.Drawing.Size(417, 58)
        Me.lblBienvenida.TabIndex = 1
        Me.lblBienvenida.Text = "Bienvenido, user"
        '
        'frmIndex
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1094, 654)
        Me.Controls.Add(Me.spcContenedorProgram)
        Me.Font = New System.Drawing.Font("Inter", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.MaximizeBox = False
        Me.Name = "frmIndex"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Inicio: Biblioteca Virtual"
        Me.spcContenedorProgram.Panel1.ResumeLayout(False)
        Me.spcContenedorProgram.Panel2.ResumeLayout(False)
        CType(Me.spcContenedorProgram, System.ComponentModel.ISupportInitialize).EndInit()
        Me.spcContenedorProgram.ResumeLayout(False)
        Me.PanelInicio.ResumeLayout(False)
        Me.PanelInicio.PerformLayout()
        Me.ResumeLayout(False)

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
    Friend WithEvents lblSubBienvenida As Label
    Friend WithEvents btnPersonalizar As Button
End Class
