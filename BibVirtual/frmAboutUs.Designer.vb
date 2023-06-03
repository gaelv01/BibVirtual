<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAboutUs
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
        Dim resources As ComponentModel.ComponentResourceManager = New ComponentModel.ComponentResourceManager(GetType(frmAboutUs))
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        Label5 = New Label()
        Button1 = New Button()
        PictureBox1 = New PictureBox()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Inter", 15.75F, FontStyle.Regular, GraphicsUnit.Point)
        Label1.Location = New Point(33, 30)
        Label1.Name = "Label1"
        Label1.Size = New Size(305, 25)
        Label1.TabIndex = 0
        Label1.Text = "Versión de la app: 0.8.0 alpha"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Inter", 15.75F, FontStyle.Regular, GraphicsUnit.Point)
        Label2.Location = New Point(33, 66)
        Label2.Name = "Label2"
        Label2.Size = New Size(415, 25)
        Label2.TabIndex = 1
        Label2.Text = "Parche de seguridad: 2 de junio de 2023"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Inter", 15.75F, FontStyle.Regular, GraphicsUnit.Point)
        Label3.Location = New Point(33, 100)
        Label3.Name = "Label3"
        Label3.Size = New Size(338, 25)
        Label3.TabIndex = 2
        Label3.Text = "Número de compilación: A8050F"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Inter", 15.75F, FontStyle.Regular, GraphicsUnit.Point)
        Label4.Location = New Point(250, 169)
        Label4.Name = "Label4"
        Label4.Size = New Size(301, 25)
        Label4.TabIndex = 3
        Label4.Text = "Potenciado por INTERACTIQ:" & vbCrLf
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Inter", 20.25F, FontStyle.Italic, GraphicsUnit.Point)
        Label5.Location = New Point(120, 213)
        Label5.Name = "Label5"
        Label5.Size = New Size(560, 33)
        Label5.TabIndex = 4
        Label5.Text = """Transformando las experiencias digitales.""" & vbCrLf
        ' 
        ' Button1
        ' 
        Button1.Font = New Font("Inter", 15.75F, FontStyle.Regular, GraphicsUnit.Point)
        Button1.Image = CType(resources.GetObject("Button1.Image"), Image)
        Button1.ImageAlign = ContentAlignment.TopCenter
        Button1.Location = New Point(256, 277)
        Button1.Name = "Button1"
        Button1.Padding = New Padding(0, 0, 0, 10)
        Button1.Size = New Size(289, 112)
        Button1.TabIndex = 5
        Button1.Text = "¡Cómpranos un café!"
        Button1.TextAlign = ContentAlignment.BottomCenter
        Button1.UseVisualStyleBackColor = True
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(698, 25)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(69, 66)
        PictureBox1.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox1.TabIndex = 6
        PictureBox1.TabStop = False
        ' 
        ' frmAboutUs
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(PictureBox1)
        Controls.Add(Button1)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        FormBorderStyle = FormBorderStyle.None
        Name = "frmAboutUs"
        Padding = New Padding(30)
        Text = "frmAboutUs"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents PictureBox1 As PictureBox
End Class
