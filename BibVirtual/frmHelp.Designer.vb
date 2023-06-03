<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmHelp
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
        Dim resources As ComponentModel.ComponentResourceManager = New ComponentModel.ComponentResourceManager(GetType(frmHelp))
        TableLayoutPanel3 = New TableLayoutPanel()
        Button3 = New Button()
        Button2 = New Button()
        Button1 = New Button()
        TableLayoutPanel1 = New TableLayoutPanel()
        Label1 = New Label()
        TableLayoutPanel3.SuspendLayout()
        TableLayoutPanel1.SuspendLayout()
        SuspendLayout()
        ' 
        ' TableLayoutPanel3
        ' 
        TableLayoutPanel3.ColumnCount = 3
        TableLayoutPanel3.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 33.3333321F))
        TableLayoutPanel3.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 33.3333321F))
        TableLayoutPanel3.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 33.3333321F))
        TableLayoutPanel3.Controls.Add(Button3, 2, 0)
        TableLayoutPanel3.Controls.Add(Button2, 1, 0)
        TableLayoutPanel3.Controls.Add(Button1, 0, 0)
        TableLayoutPanel3.Dock = DockStyle.Fill
        TableLayoutPanel3.Location = New Point(10, 70)
        TableLayoutPanel3.Name = "TableLayoutPanel3"
        TableLayoutPanel3.RowCount = 1
        TableLayoutPanel3.RowStyles.Add(New RowStyle(SizeType.Percent, 50F))
        TableLayoutPanel3.Size = New Size(780, 251)
        TableLayoutPanel3.TabIndex = 3
        ' 
        ' Button3
        ' 
        Button3.Dock = DockStyle.Fill
        Button3.Font = New Font("Inter", 15.75F, FontStyle.Regular, GraphicsUnit.Point)
        Button3.Image = CType(resources.GetObject("Button3.Image"), Image)
        Button3.Location = New Point(528, 10)
        Button3.Margin = New Padding(10)
        Button3.Name = "Button3"
        Button3.Padding = New Padding(0, 0, 0, 20)
        Button3.Size = New Size(242, 231)
        Button3.TabIndex = 2
        Button3.Text = "¿Qué es esto?"
        Button3.TextAlign = ContentAlignment.BottomCenter
        Button3.UseVisualStyleBackColor = True
        ' 
        ' Button2
        ' 
        Button2.Dock = DockStyle.Fill
        Button2.Font = New Font("Inter", 15.75F, FontStyle.Regular, GraphicsUnit.Point)
        Button2.Image = CType(resources.GetObject("Button2.Image"), Image)
        Button2.Location = New Point(269, 10)
        Button2.Margin = New Padding(10)
        Button2.Name = "Button2"
        Button2.Padding = New Padding(0, 0, 0, 20)
        Button2.Size = New Size(239, 231)
        Button2.TabIndex = 1
        Button2.Text = "Soporte Técnico"
        Button2.TextAlign = ContentAlignment.BottomCenter
        Button2.UseVisualStyleBackColor = True
        ' 
        ' Button1
        ' 
        Button1.Dock = DockStyle.Fill
        Button1.Font = New Font("Inter", 15.75F, FontStyle.Regular, GraphicsUnit.Point)
        Button1.Image = CType(resources.GetObject("Button1.Image"), Image)
        Button1.Location = New Point(10, 10)
        Button1.Margin = New Padding(10)
        Button1.Name = "Button1"
        Button1.Padding = New Padding(0, 0, 0, 20)
        Button1.Size = New Size(239, 231)
        Button1.TabIndex = 0
        Button1.Text = "Ver el manual de usuario"
        Button1.TextAlign = ContentAlignment.BottomCenter
        Button1.UseVisualStyleBackColor = True
        ' 
        ' TableLayoutPanel1
        ' 
        TableLayoutPanel1.ColumnCount = 1
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 50F))
        TableLayoutPanel1.Controls.Add(Label1, 0, 0)
        TableLayoutPanel1.Dock = DockStyle.Top
        TableLayoutPanel1.Location = New Point(10, 10)
        TableLayoutPanel1.Name = "TableLayoutPanel1"
        TableLayoutPanel1.RowCount = 1
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 50F))
        TableLayoutPanel1.Size = New Size(780, 60)
        TableLayoutPanel1.TabIndex = 2
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Dock = DockStyle.Fill
        Label1.Font = New Font("Inter", 15.75F, FontStyle.Regular, GraphicsUnit.Point)
        Label1.Location = New Point(3, 0)
        Label1.Name = "Label1"
        Label1.Size = New Size(774, 60)
        Label1.TabIndex = 0
        Label1.Text = "¿Cómo podemos ayudarte?"
        Label1.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' frmHelp
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 331)
        Controls.Add(TableLayoutPanel3)
        Controls.Add(TableLayoutPanel1)
        FormBorderStyle = FormBorderStyle.None
        Name = "frmHelp"
        Padding = New Padding(10)
        Text = "frmHelp"
        TableLayoutPanel3.ResumeLayout(False)
        TableLayoutPanel1.ResumeLayout(False)
        TableLayoutPanel1.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents TableLayoutPanel3 As TableLayoutPanel
    Friend WithEvents Button3 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents Label1 As Label
End Class
