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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cbxModoColor = New System.Windows.Forms.ComboBox()
        Me.btnAplicar = New System.Windows.Forms.Button()
        Me.cbxTipografia = New System.Windows.Forms.ComboBox()
        Me.chbxNegritas = New System.Windows.Forms.CheckBox()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Inter", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(287, 29)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Personalizar el sistema"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 55)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(108, 19)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Modo de luz:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 86)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(91, 19)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Tipografía:"
        '
        'cbxModoColor
        '
        Me.cbxModoColor.FormattingEnabled = True
        Me.cbxModoColor.Items.AddRange(New Object() {"Claro", "Oscuro"})
        Me.cbxModoColor.Location = New System.Drawing.Point(138, 52)
        Me.cbxModoColor.Name = "cbxModoColor"
        Me.cbxModoColor.Size = New System.Drawing.Size(121, 27)
        Me.cbxModoColor.TabIndex = 3
        '
        'btnAplicar
        '
        Me.btnAplicar.Location = New System.Drawing.Point(157, 164)
        Me.btnAplicar.Name = "btnAplicar"
        Me.btnAplicar.Size = New System.Drawing.Size(102, 44)
        Me.btnAplicar.TabIndex = 4
        Me.btnAplicar.Text = "Aplicar"
        Me.btnAplicar.UseVisualStyleBackColor = True
        '
        'cbxTipografia
        '
        Me.cbxTipografia.FormattingEnabled = True
        Me.cbxTipografia.Items.AddRange(New Object() {"Inter", "Arial", "Tahoma", "Times New Roman", "Segoe UI"})
        Me.cbxTipografia.Location = New System.Drawing.Point(138, 86)
        Me.cbxTipografia.Name = "cbxTipografia"
        Me.cbxTipografia.Size = New System.Drawing.Size(121, 27)
        Me.cbxTipografia.TabIndex = 5
        '
        'chbxNegritas
        '
        Me.chbxNegritas.AutoSize = True
        Me.chbxNegritas.Location = New System.Drawing.Point(12, 119)
        Me.chbxNegritas.Name = "chbxNegritas"
        Me.chbxNegritas.Size = New System.Drawing.Size(152, 23)
        Me.chbxNegritas.TabIndex = 7
        Me.chbxNegritas.Text = "Texto en negrita"
        Me.chbxNegritas.UseVisualStyleBackColor = True
        '
        'frmPersonalizar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 19.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(389, 292)
        Me.Controls.Add(Me.chbxNegritas)
        Me.Controls.Add(Me.cbxTipografia)
        Me.Controls.Add(Me.btnAplicar)
        Me.Controls.Add(Me.cbxModoColor)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Inter", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "frmPersonalizar"
        Me.Text = "Personalizar"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents cbxModoColor As ComboBox
    Friend WithEvents btnAplicar As Button
    Friend WithEvents cbxTipografia As ComboBox
    Friend WithEvents chbxNegritas As CheckBox
End Class
