﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmMisLibros
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
        Dim resources As ComponentModel.ComponentResourceManager = New ComponentModel.ComponentResourceManager(GetType(frmMisLibros))
        FlowLayoutPanel1 = New FlowLayoutPanel()
        GroupBox1 = New GroupBox()
        Label3 = New Label()
        Label2 = New Label()
        Label1 = New Label()
        PictureBox1 = New PictureBox()
        GroupBox2 = New GroupBox()
        Label4 = New Label()
        Label5 = New Label()
        Label6 = New Label()
        PictureBox2 = New PictureBox()
        GroupBox3 = New GroupBox()
        Label7 = New Label()
        Label8 = New Label()
        Label9 = New Label()
        PictureBox3 = New PictureBox()
        GroupBox6 = New GroupBox()
        Label16 = New Label()
        Label17 = New Label()
        Label18 = New Label()
        PictureBox6 = New PictureBox()
        GroupBox5 = New GroupBox()
        Label13 = New Label()
        Label14 = New Label()
        Label15 = New Label()
        PictureBox5 = New PictureBox()
        GroupBox7 = New GroupBox()
        PictureBox4 = New PictureBox()
        LinkLabel1 = New LinkLabel()
        GroupBox4 = New GroupBox()
        Button2 = New Button()
        Button1 = New Button()
        VScrollBar1 = New VScrollBar()
        FlowLayoutPanel1.SuspendLayout()
        GroupBox1.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        GroupBox2.SuspendLayout()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        GroupBox3.SuspendLayout()
        CType(PictureBox3, ComponentModel.ISupportInitialize).BeginInit()
        GroupBox6.SuspendLayout()
        CType(PictureBox6, ComponentModel.ISupportInitialize).BeginInit()
        GroupBox5.SuspendLayout()
        CType(PictureBox5, ComponentModel.ISupportInitialize).BeginInit()
        GroupBox7.SuspendLayout()
        CType(PictureBox4, ComponentModel.ISupportInitialize).BeginInit()
        GroupBox4.SuspendLayout()
        SuspendLayout()
        ' 
        ' FlowLayoutPanel1
        ' 
        FlowLayoutPanel1.Controls.Add(GroupBox1)
        FlowLayoutPanel1.Controls.Add(GroupBox2)
        FlowLayoutPanel1.Controls.Add(GroupBox3)
        FlowLayoutPanel1.Controls.Add(GroupBox6)
        FlowLayoutPanel1.Controls.Add(GroupBox5)
        FlowLayoutPanel1.Controls.Add(GroupBox7)
        FlowLayoutPanel1.Controls.Add(GroupBox4)
        FlowLayoutPanel1.Dock = DockStyle.Fill
        FlowLayoutPanel1.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        FlowLayoutPanel1.Location = New Point(0, 0)
        FlowLayoutPanel1.Name = "FlowLayoutPanel1"
        FlowLayoutPanel1.Size = New Size(800, 450)
        FlowLayoutPanel1.TabIndex = 2
        ' 
        ' GroupBox1
        ' 
        GroupBox1.Controls.Add(Label3)
        GroupBox1.Controls.Add(Label2)
        GroupBox1.Controls.Add(Label1)
        GroupBox1.Controls.Add(PictureBox1)
        GroupBox1.Location = New Point(3, 3)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(259, 159)
        GroupBox1.TabIndex = 0
        GroupBox1.TabStop = False
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(105, 88)
        Label3.Name = "Label3"
        Label3.Size = New Size(46, 21)
        Label3.TabIndex = 3
        Label3.Text = "1988"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(105, 51)
        Label2.Name = "Label2"
        Label2.Size = New Size(101, 21)
        Label2.TabIndex = 2
        Label2.Text = "Paulo Coehlo"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(105, 17)
        Label1.Name = "Label1"
        Label1.Size = New Size(98, 21)
        Label1.TabIndex = 1
        Label1.Text = "El alquimista"
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(9, 17)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(90, 133)
        PictureBox1.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox1.TabIndex = 0
        PictureBox1.TabStop = False
        ' 
        ' GroupBox2
        ' 
        GroupBox2.Controls.Add(Label4)
        GroupBox2.Controls.Add(Label5)
        GroupBox2.Controls.Add(Label6)
        GroupBox2.Controls.Add(PictureBox2)
        GroupBox2.Location = New Point(268, 3)
        GroupBox2.Name = "GroupBox2"
        GroupBox2.Size = New Size(259, 159)
        GroupBox2.TabIndex = 4
        GroupBox2.TabStop = False
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(105, 108)
        Label4.Name = "Label4"
        Label4.Size = New Size(46, 21)
        Label4.TabIndex = 3
        Label4.Text = "1943"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(105, 51)
        Label5.Name = "Label5"
        Label5.Size = New Size(106, 42)
        Label5.TabIndex = 2
        Label5.Text = "Antoine de " & vbCrLf & "Saint-Exupéry"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Location = New Point(105, 17)
        Label6.Name = "Label6"
        Label6.Size = New Size(92, 21)
        Label6.TabIndex = 1
        Label6.Text = "El Principito" & vbCrLf
        ' 
        ' PictureBox2
        ' 
        PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), Image)
        PictureBox2.Location = New Point(9, 17)
        PictureBox2.Name = "PictureBox2"
        PictureBox2.Size = New Size(90, 133)
        PictureBox2.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox2.TabIndex = 0
        PictureBox2.TabStop = False
        ' 
        ' GroupBox3
        ' 
        GroupBox3.Controls.Add(Label7)
        GroupBox3.Controls.Add(Label8)
        GroupBox3.Controls.Add(Label9)
        GroupBox3.Controls.Add(PictureBox3)
        GroupBox3.Location = New Point(533, 3)
        GroupBox3.Name = "GroupBox3"
        GroupBox3.Size = New Size(259, 159)
        GroupBox3.TabIndex = 5
        GroupBox3.TabStop = False
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Location = New Point(105, 88)
        Label7.Name = "Label7"
        Label7.Size = New Size(46, 21)
        Label7.TabIndex = 3
        Label7.Text = "1950"
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Location = New Point(105, 51)
        Label8.Name = "Label8"
        Label8.Size = New Size(100, 21)
        Label8.TabIndex = 2
        Label8.Text = "Isaac Asimov"
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Location = New Point(105, 17)
        Label9.Name = "Label9"
        Label9.Size = New Size(76, 21)
        Label9.TabIndex = 1
        Label9.Text = "Yo, Robot"
        ' 
        ' PictureBox3
        ' 
        PictureBox3.Image = CType(resources.GetObject("PictureBox3.Image"), Image)
        PictureBox3.Location = New Point(9, 17)
        PictureBox3.Name = "PictureBox3"
        PictureBox3.Size = New Size(90, 133)
        PictureBox3.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox3.TabIndex = 0
        PictureBox3.TabStop = False
        ' 
        ' GroupBox6
        ' 
        GroupBox6.Controls.Add(Label16)
        GroupBox6.Controls.Add(Label17)
        GroupBox6.Controls.Add(Label18)
        GroupBox6.Controls.Add(PictureBox6)
        GroupBox6.Location = New Point(3, 168)
        GroupBox6.Name = "GroupBox6"
        GroupBox6.Size = New Size(268, 159)
        GroupBox6.TabIndex = 4
        GroupBox6.TabStop = False
        ' 
        ' Label16
        ' 
        Label16.AutoSize = True
        Label16.Location = New Point(105, 88)
        Label16.Name = "Label16"
        Label16.Size = New Size(46, 21)
        Label16.TabIndex = 3
        Label16.Text = "1851"
        ' 
        ' Label17
        ' 
        Label17.AutoSize = True
        Label17.Location = New Point(105, 51)
        Label17.Name = "Label17"
        Label17.Size = New Size(159, 21)
        Label17.TabIndex = 2
        Label17.Text = "Arthur Schopenhauer"
        ' 
        ' Label18
        ' 
        Label18.AutoSize = True
        Label18.Location = New Point(105, 17)
        Label18.Name = "Label18"
        Label18.Size = New Size(131, 21)
        Label18.TabIndex = 1
        Label18.Text = "El arte de ser feliz"
        ' 
        ' PictureBox6
        ' 
        PictureBox6.Image = CType(resources.GetObject("PictureBox6.Image"), Image)
        PictureBox6.Location = New Point(9, 17)
        PictureBox6.Name = "PictureBox6"
        PictureBox6.Size = New Size(90, 133)
        PictureBox6.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox6.TabIndex = 0
        PictureBox6.TabStop = False
        ' 
        ' GroupBox5
        ' 
        GroupBox5.Controls.Add(Label13)
        GroupBox5.Controls.Add(Label14)
        GroupBox5.Controls.Add(Label15)
        GroupBox5.Controls.Add(PictureBox5)
        GroupBox5.Location = New Point(277, 168)
        GroupBox5.Name = "GroupBox5"
        GroupBox5.Size = New Size(355, 159)
        GroupBox5.TabIndex = 4
        GroupBox5.TabStop = False
        ' 
        ' Label13
        ' 
        Label13.AutoSize = True
        Label13.Location = New Point(105, 88)
        Label13.Name = "Label13"
        Label13.Size = New Size(46, 21)
        Label13.TabIndex = 3
        Label13.Text = "1967"
        ' 
        ' Label14
        ' 
        Label14.AutoSize = True
        Label14.Location = New Point(105, 51)
        Label14.Name = "Label14"
        Label14.Size = New Size(173, 21)
        Label14.TabIndex = 2
        Label14.Text = "Gabriel García Márquez"
        ' 
        ' Label15
        ' 
        Label15.AutoSize = True
        Label15.Location = New Point(105, 17)
        Label15.Name = "Label15"
        Label15.Size = New Size(157, 21)
        Label15.TabIndex = 1
        Label15.Text = "Cien años de soledad"
        ' 
        ' PictureBox5
        ' 
        PictureBox5.Image = CType(resources.GetObject("PictureBox5.Image"), Image)
        PictureBox5.Location = New Point(9, 17)
        PictureBox5.Name = "PictureBox5"
        PictureBox5.Size = New Size(90, 133)
        PictureBox5.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox5.TabIndex = 0
        PictureBox5.TabStop = False
        ' 
        ' GroupBox7
        ' 
        GroupBox7.Controls.Add(PictureBox4)
        GroupBox7.Controls.Add(LinkLabel1)
        GroupBox7.Location = New Point(638, 168)
        GroupBox7.Name = "GroupBox7"
        GroupBox7.Size = New Size(151, 159)
        GroupBox7.TabIndex = 7
        GroupBox7.TabStop = False
        ' 
        ' PictureBox4
        ' 
        PictureBox4.Image = CType(resources.GetObject("PictureBox4.Image"), Image)
        PictureBox4.Location = New Point(50, 88)
        PictureBox4.Name = "PictureBox4"
        PictureBox4.Size = New Size(51, 50)
        PictureBox4.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox4.TabIndex = 1
        PictureBox4.TabStop = False
        ' 
        ' LinkLabel1
        ' 
        LinkLabel1.AutoSize = True
        LinkLabel1.Location = New Point(21, 35)
        LinkLabel1.Name = "LinkLabel1"
        LinkLabel1.Size = New Size(109, 21)
        LinkLabel1.TabIndex = 0
        LinkLabel1.TabStop = True
        LinkLabel1.Text = "Ver más libros"
        ' 
        ' GroupBox4
        ' 
        GroupBox4.Controls.Add(VScrollBar1)
        GroupBox4.Controls.Add(Button2)
        GroupBox4.Controls.Add(Button1)
        GroupBox4.Location = New Point(3, 333)
        GroupBox4.Name = "GroupBox4"
        GroupBox4.Size = New Size(785, 100)
        GroupBox4.TabIndex = 6
        GroupBox4.TabStop = False
        ' 
        ' Button2
        ' 
        Button2.Image = CType(resources.GetObject("Button2.Image"), Image)
        Button2.ImageAlign = ContentAlignment.MiddleLeft
        Button2.Location = New Point(430, 34)
        Button2.Name = "Button2"
        Button2.Padding = New Padding(5)
        Button2.Size = New Size(115, 48)
        Button2.TabIndex = 1
        Button2.Text = "Ayuda"
        Button2.TextAlign = ContentAlignment.MiddleRight
        Button2.UseVisualStyleBackColor = True
        ' 
        ' Button1
        ' 
        Button1.Image = CType(resources.GetObject("Button1.Image"), Image)
        Button1.ImageAlign = ContentAlignment.MiddleLeft
        Button1.Location = New Point(239, 34)
        Button1.Name = "Button1"
        Button1.Padding = New Padding(5)
        Button1.Size = New Size(177, 48)
        Button1.TabIndex = 0
        Button1.Text = "Eliminar un libro"
        Button1.TextAlign = ContentAlignment.MiddleRight
        Button1.UseVisualStyleBackColor = True
        ' 
        ' VScrollBar1
        ' 
        VScrollBar1.Location = New Point(0, 436)
        VScrollBar1.Name = "VScrollBar1"
        VScrollBar1.Size = New Size(17, 80)
        VScrollBar1.TabIndex = 2
        ' 
        ' frmMisLibros
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(FlowLayoutPanel1)
        FormBorderStyle = FormBorderStyle.None
        Name = "frmMisLibros"
        Text = "frmMisLibros"
        FlowLayoutPanel1.ResumeLayout(False)
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        GroupBox2.ResumeLayout(False)
        GroupBox2.PerformLayout()
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        GroupBox3.ResumeLayout(False)
        GroupBox3.PerformLayout()
        CType(PictureBox3, ComponentModel.ISupportInitialize).EndInit()
        GroupBox6.ResumeLayout(False)
        GroupBox6.PerformLayout()
        CType(PictureBox6, ComponentModel.ISupportInitialize).EndInit()
        GroupBox5.ResumeLayout(False)
        GroupBox5.PerformLayout()
        CType(PictureBox5, ComponentModel.ISupportInitialize).EndInit()
        GroupBox7.ResumeLayout(False)
        GroupBox7.PerformLayout()
        CType(PictureBox4, ComponentModel.ISupportInitialize).EndInit()
        GroupBox4.ResumeLayout(False)
        ResumeLayout(False)
    End Sub

    Friend WithEvents FlowLayoutPanel1 As FlowLayoutPanel
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents GroupBox6 As GroupBox
    Friend WithEvents Label16 As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents Label18 As Label
    Friend WithEvents PictureBox6 As PictureBox
    Friend WithEvents GroupBox5 As GroupBox
    Friend WithEvents Label13 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents PictureBox5 As PictureBox
    Friend WithEvents GroupBox7 As GroupBox
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents LinkLabel1 As LinkLabel
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents Button2 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents VScrollBar1 As VScrollBar
End Class
