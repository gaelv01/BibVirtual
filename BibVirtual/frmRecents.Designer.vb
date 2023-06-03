<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmRecents
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
        Dim resources As ComponentModel.ComponentResourceManager = New ComponentModel.ComponentResourceManager(GetType(frmRecents))
        GroupBox6 = New GroupBox()
        Button6 = New Button()
        GroupBox5 = New GroupBox()
        Button5 = New Button()
        GroupBox3 = New GroupBox()
        Button3 = New Button()
        GroupBox2 = New GroupBox()
        Button2 = New Button()
        TableLayoutPanel1 = New TableLayoutPanel()
        Button4 = New Button()
        GroupBox4 = New GroupBox()
        Button1 = New Button()
        GroupBox1 = New GroupBox()
        GroupBox6.SuspendLayout()
        GroupBox5.SuspendLayout()
        GroupBox3.SuspendLayout()
        GroupBox2.SuspendLayout()
        TableLayoutPanel1.SuspendLayout()
        GroupBox4.SuspendLayout()
        GroupBox1.SuspendLayout()
        SuspendLayout()
        ' 
        ' GroupBox6
        ' 
        GroupBox6.Controls.Add(Button6)
        GroupBox6.Dock = DockStyle.Fill
        GroupBox6.Location = New Point(545, 228)
        GroupBox6.Name = "GroupBox6"
        GroupBox6.Padding = New Padding(0)
        GroupBox6.Size = New Size(252, 219)
        GroupBox6.TabIndex = 5
        GroupBox6.TabStop = False
        ' 
        ' Button6
        ' 
        Button6.Dock = DockStyle.Fill
        Button6.Font = New Font("Inter", 14.25F, FontStyle.Regular, GraphicsUnit.Point)
        Button6.Image = CType(resources.GetObject("Button6.Image"), Image)
        Button6.Location = New Point(0, 16)
        Button6.Name = "Button6"
        Button6.Padding = New Padding(0, 0, 0, 20)
        Button6.Size = New Size(252, 203)
        Button6.TabIndex = 5
        Button6.Text = "Ver mi historial"
        Button6.TextAlign = ContentAlignment.BottomCenter
        Button6.UseVisualStyleBackColor = True
        ' 
        ' GroupBox5
        ' 
        GroupBox5.Controls.Add(Button5)
        GroupBox5.Dock = DockStyle.Fill
        GroupBox5.Location = New Point(275, 228)
        GroupBox5.Name = "GroupBox5"
        GroupBox5.Padding = New Padding(0)
        GroupBox5.Size = New Size(264, 219)
        GroupBox5.TabIndex = 4
        GroupBox5.TabStop = False
        ' 
        ' Button5
        ' 
        Button5.Dock = DockStyle.Fill
        Button5.Font = New Font("Inter", 14.25F, FontStyle.Regular, GraphicsUnit.Point)
        Button5.Image = CType(resources.GetObject("Button5.Image"), Image)
        Button5.Location = New Point(0, 16)
        Button5.Name = "Button5"
        Button5.Padding = New Padding(0, 0, 0, 20)
        Button5.Size = New Size(264, 203)
        Button5.TabIndex = 4
        Button5.Text = "Ajustes"
        Button5.TextAlign = ContentAlignment.BottomCenter
        Button5.UseVisualStyleBackColor = True
        ' 
        ' GroupBox3
        ' 
        GroupBox3.Controls.Add(Button3)
        GroupBox3.Dock = DockStyle.Fill
        GroupBox3.Location = New Point(545, 3)
        GroupBox3.Name = "GroupBox3"
        GroupBox3.Padding = New Padding(0)
        GroupBox3.Size = New Size(252, 219)
        GroupBox3.TabIndex = 2
        GroupBox3.TabStop = False
        ' 
        ' Button3
        ' 
        Button3.Dock = DockStyle.Fill
        Button3.Font = New Font("Inter", 14.25F, FontStyle.Regular, GraphicsUnit.Point)
        Button3.Image = CType(resources.GetObject("Button3.Image"), Image)
        Button3.Location = New Point(0, 16)
        Button3.Name = "Button3"
        Button3.Padding = New Padding(0, 0, 0, 20)
        Button3.Size = New Size(252, 203)
        Button3.TabIndex = 2
        Button3.Text = "Ver mis libros"
        Button3.TextAlign = ContentAlignment.BottomCenter
        Button3.UseVisualStyleBackColor = True
        ' 
        ' GroupBox2
        ' 
        GroupBox2.Controls.Add(Button2)
        GroupBox2.Dock = DockStyle.Fill
        GroupBox2.Location = New Point(275, 3)
        GroupBox2.Name = "GroupBox2"
        GroupBox2.Padding = New Padding(0)
        GroupBox2.Size = New Size(264, 219)
        GroupBox2.TabIndex = 1
        GroupBox2.TabStop = False
        ' 
        ' Button2
        ' 
        Button2.Dock = DockStyle.Fill
        Button2.Font = New Font("Inter", 14.25F, FontStyle.Regular, GraphicsUnit.Point)
        Button2.Image = CType(resources.GetObject("Button2.Image"), Image)
        Button2.Location = New Point(0, 16)
        Button2.Name = "Button2"
        Button2.Padding = New Padding(0, 0, 0, 20)
        Button2.Size = New Size(264, 203)
        Button2.TabIndex = 1
        Button2.Text = "Hacer una reserva"
        Button2.TextAlign = ContentAlignment.BottomCenter
        Button2.UseVisualStyleBackColor = True
        ' 
        ' TableLayoutPanel1
        ' 
        TableLayoutPanel1.ColumnCount = 3
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 50.1845F))
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 49.8155F))
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Absolute, 258F))
        TableLayoutPanel1.Controls.Add(GroupBox1, 0, 0)
        TableLayoutPanel1.Controls.Add(GroupBox2, 1, 0)
        TableLayoutPanel1.Controls.Add(GroupBox3, 2, 0)
        TableLayoutPanel1.Controls.Add(GroupBox4, 0, 1)
        TableLayoutPanel1.Controls.Add(GroupBox5, 1, 1)
        TableLayoutPanel1.Controls.Add(GroupBox6, 2, 1)
        TableLayoutPanel1.Dock = DockStyle.Fill
        TableLayoutPanel1.Location = New Point(0, 0)
        TableLayoutPanel1.Name = "TableLayoutPanel1"
        TableLayoutPanel1.RowCount = 2
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 50F))
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 50F))
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Absolute, 20F))
        TableLayoutPanel1.Size = New Size(800, 450)
        TableLayoutPanel1.TabIndex = 0
        ' 
        ' Button4
        ' 
        Button4.Dock = DockStyle.Fill
        Button4.Font = New Font("Inter", 14.25F, FontStyle.Regular, GraphicsUnit.Point)
        Button4.Image = CType(resources.GetObject("Button4.Image"), Image)
        Button4.Location = New Point(0, 16)
        Button4.Name = "Button4"
        Button4.Padding = New Padding(0, 0, 0, 20)
        Button4.Size = New Size(266, 203)
        Button4.TabIndex = 3
        Button4.Text = "Personalizar"
        Button4.TextAlign = ContentAlignment.BottomCenter
        Button4.UseVisualStyleBackColor = True
        ' 
        ' GroupBox4
        ' 
        GroupBox4.Controls.Add(Button4)
        GroupBox4.Dock = DockStyle.Fill
        GroupBox4.Location = New Point(3, 228)
        GroupBox4.Name = "GroupBox4"
        GroupBox4.Padding = New Padding(0)
        GroupBox4.Size = New Size(266, 219)
        GroupBox4.TabIndex = 3
        GroupBox4.TabStop = False
        ' 
        ' Button1
        ' 
        Button1.Dock = DockStyle.Fill
        Button1.Font = New Font("Inter", 14.25F, FontStyle.Regular, GraphicsUnit.Point)
        Button1.Image = CType(resources.GetObject("Button1.Image"), Image)
        Button1.Location = New Point(0, 16)
        Button1.Name = "Button1"
        Button1.Padding = New Padding(0, 0, 0, 20)
        Button1.Size = New Size(266, 203)
        Button1.TabIndex = 0
        Button1.Text = "Buscar un libro"
        Button1.TextAlign = ContentAlignment.BottomCenter
        Button1.UseVisualStyleBackColor = True
        ' 
        ' GroupBox1
        ' 
        GroupBox1.Controls.Add(Button1)
        GroupBox1.Dock = DockStyle.Fill
        GroupBox1.Location = New Point(3, 3)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Padding = New Padding(0)
        GroupBox1.Size = New Size(266, 219)
        GroupBox1.TabIndex = 0
        GroupBox1.TabStop = False
        ' 
        ' frmRecents
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(TableLayoutPanel1)
        FormBorderStyle = FormBorderStyle.None
        Name = "frmRecents"
        Text = "frmRecents"
        GroupBox6.ResumeLayout(False)
        GroupBox5.ResumeLayout(False)
        GroupBox3.ResumeLayout(False)
        GroupBox2.ResumeLayout(False)
        TableLayoutPanel1.ResumeLayout(False)
        GroupBox4.ResumeLayout(False)
        GroupBox1.ResumeLayout(False)
        ResumeLayout(False)
    End Sub

    Friend WithEvents GroupBox6 As GroupBox
    Friend WithEvents Button6 As Button
    Friend WithEvents GroupBox5 As GroupBox
    Friend WithEvents Button5 As Button
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents Button3 As Button
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Button2 As Button
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Button1 As Button
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents Button4 As Button
End Class
