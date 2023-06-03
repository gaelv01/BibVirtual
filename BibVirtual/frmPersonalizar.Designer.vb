<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPersonalizar
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
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        cbxModoColor = New ComboBox()
        btnAplicar = New Button()
        cbxTipografia = New ComboBox()
        chbxNegritas = New CheckBox()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Inter", 18F, FontStyle.Bold, GraphicsUnit.Point)
        Label1.Location = New Point(12, 9)
        Label1.Name = "Label1"
        Label1.Size = New Size(287, 29)
        Label1.TabIndex = 0
        Label1.Text = "Personalizar el sistema"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(12, 55)
        Label2.Name = "Label2"
        Label2.Size = New Size(108, 19)
        Label2.TabIndex = 1
        Label2.Text = "Modo de luz:"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(12, 86)
        Label3.Name = "Label3"
        Label3.Size = New Size(91, 19)
        Label3.TabIndex = 2
        Label3.Text = "Tipografía:"
        ' 
        ' cbxModoColor
        ' 
        cbxModoColor.FormattingEnabled = True
        cbxModoColor.Items.AddRange(New Object() {"Claro", "Oscuro"})
        cbxModoColor.Location = New Point(138, 52)
        cbxModoColor.Name = "cbxModoColor"
        cbxModoColor.Size = New Size(182, 27)
        cbxModoColor.TabIndex = 3
        ' 
        ' btnAplicar
        ' 
        btnAplicar.Location = New Point(12, 148)
        btnAplicar.Name = "btnAplicar"
        btnAplicar.Size = New Size(102, 44)
        btnAplicar.TabIndex = 4
        btnAplicar.Text = "Aplicar"
        btnAplicar.UseVisualStyleBackColor = True
        ' 
        ' cbxTipografia
        ' 
        cbxTipografia.FormattingEnabled = True
        cbxTipografia.Items.AddRange(New Object() {"Inter", "Arial", "Tahoma", "Times New Roman", "Segoe UI"})
        cbxTipografia.Location = New Point(138, 86)
        cbxTipografia.Name = "cbxTipografia"
        cbxTipografia.Size = New Size(182, 27)
        cbxTipografia.TabIndex = 5
        ' 
        ' chbxNegritas
        ' 
        chbxNegritas.AutoSize = True
        chbxNegritas.Location = New Point(12, 119)
        chbxNegritas.Name = "chbxNegritas"
        chbxNegritas.Size = New Size(152, 23)
        chbxNegritas.TabIndex = 7
        chbxNegritas.Text = "Texto en negrita"
        chbxNegritas.UseVisualStyleBackColor = True
        ' 
        ' frmPersonalizar
        ' 
        AutoScaleDimensions = New SizeF(10F, 19F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.White
        ClientSize = New Size(389, 292)
        Controls.Add(chbxNegritas)
        Controls.Add(cbxTipografia)
        Controls.Add(btnAplicar)
        Controls.Add(cbxModoColor)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Font = New Font("Inter", 12F, FontStyle.Regular, GraphicsUnit.Point)
        FormBorderStyle = FormBorderStyle.SizableToolWindow
        Margin = New Padding(4)
        Name = "frmPersonalizar"
        Text = "Personalizar"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents cbxModoColor As ComboBox
    Friend WithEvents btnAplicar As Button
    Friend WithEvents cbxTipografia As ComboBox
    Friend WithEvents chbxNegritas As CheckBox
End Class
