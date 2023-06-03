<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSearch
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
        Dim resources As ComponentModel.ComponentResourceManager = New ComponentModel.ComponentResourceManager(GetType(frmSearch))
        TableLayoutPanel1 = New TableLayoutPanel()
        Button1 = New Button()
        PictureBox1 = New PictureBox()
        TextBox1 = New TextBox()
        TableLayoutPanel2 = New TableLayoutPanel()
        Button2 = New Button()
        Label1 = New Label()
        DataGridView1 = New DataGridView()
        Nombre = New DataGridViewTextBoxColumn()
        Column2 = New DataGridViewTextBoxColumn()
        Column3 = New DataGridViewTextBoxColumn()
        Column4 = New DataGridViewTextBoxColumn()
        Estado = New DataGridViewTextBoxColumn()
        Accion = New DataGridViewTextBoxColumn()
        TableLayoutPanel1.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        TableLayoutPanel2.SuspendLayout()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' TableLayoutPanel1
        ' 
        TableLayoutPanel1.ColumnCount = 3
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 7.72659731F))
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 92.2734F))
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Absolute, 126F))
        TableLayoutPanel1.Controls.Add(Button1, 2, 0)
        TableLayoutPanel1.Controls.Add(PictureBox1, 0, 0)
        TableLayoutPanel1.Controls.Add(TextBox1, 1, 0)
        TableLayoutPanel1.Dock = DockStyle.Top
        TableLayoutPanel1.Location = New Point(0, 0)
        TableLayoutPanel1.Name = "TableLayoutPanel1"
        TableLayoutPanel1.RowCount = 1
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 50F))
        TableLayoutPanel1.Size = New Size(800, 46)
        TableLayoutPanel1.TabIndex = 0
        ' 
        ' Button1
        ' 
        Button1.Dock = DockStyle.Fill
        Button1.Font = New Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point)
        Button1.Location = New Point(676, 3)
        Button1.Name = "Button1"
        Button1.Size = New Size(121, 40)
        Button1.TabIndex = 1
        Button1.Text = "Buscar"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Dock = DockStyle.Fill
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(3, 3)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(46, 40)
        PictureBox1.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox1.TabIndex = 0
        PictureBox1.TabStop = False
        ' 
        ' TextBox1
        ' 
        TextBox1.Dock = DockStyle.Fill
        TextBox1.Font = New Font("Inter", 18F, FontStyle.Regular, GraphicsUnit.Point)
        TextBox1.Location = New Point(55, 3)
        TextBox1.Name = "TextBox1"
        TextBox1.PlaceholderText = "¿Qué deseas buscar?"
        TextBox1.Size = New Size(615, 37)
        TextBox1.TabIndex = 1
        ' 
        ' TableLayoutPanel2
        ' 
        TableLayoutPanel2.ColumnCount = 2
        TableLayoutPanel2.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 50F))
        TableLayoutPanel2.ColumnStyles.Add(New ColumnStyle(SizeType.Absolute, 127F))
        TableLayoutPanel2.Controls.Add(Button2, 1, 0)
        TableLayoutPanel2.Controls.Add(Label1, 0, 0)
        TableLayoutPanel2.Dock = DockStyle.Top
        TableLayoutPanel2.Location = New Point(0, 46)
        TableLayoutPanel2.Name = "TableLayoutPanel2"
        TableLayoutPanel2.RowCount = 1
        TableLayoutPanel2.RowStyles.Add(New RowStyle(SizeType.Percent, 50F))
        TableLayoutPanel2.Size = New Size(800, 38)
        TableLayoutPanel2.TabIndex = 1
        ' 
        ' Button2
        ' 
        Button2.Dock = DockStyle.Fill
        Button2.Location = New Point(676, 3)
        Button2.Name = "Button2"
        Button2.Size = New Size(121, 32)
        Button2.TabIndex = 0
        Button2.Text = "Filtrar..."
        Button2.UseVisualStyleBackColor = True
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Dock = DockStyle.Fill
        Label1.Font = New Font("Inter", 15.75F, FontStyle.Regular, GraphicsUnit.Point)
        Label1.Location = New Point(3, 0)
        Label1.Name = "Label1"
        Label1.Size = New Size(667, 38)
        Label1.TabIndex = 1
        Label1.Text = "Resultados para: "
        ' 
        ' DataGridView1
        ' 
        DataGridView1.AllowUserToAddRows = False
        DataGridView1.AllowUserToDeleteRows = False
        DataGridView1.AllowUserToOrderColumns = True
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Columns.AddRange(New DataGridViewColumn() {Nombre, Column2, Column3, Column4, Estado, Accion})
        DataGridView1.Dock = DockStyle.Fill
        DataGridView1.Location = New Point(0, 84)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.RowTemplate.Height = 25
        DataGridView1.Size = New Size(800, 366)
        DataGridView1.TabIndex = 3
        ' 
        ' Nombre
        ' 
        Nombre.HeaderText = "Nombre"
        Nombre.Name = "Nombre"
        ' 
        ' Column2
        ' 
        Column2.HeaderText = "Autor"
        Column2.Name = "Column2"
        ' 
        ' Column3
        ' 
        Column3.HeaderText = "Año"
        Column3.Name = "Column3"
        ' 
        ' Column4
        ' 
        Column4.HeaderText = "Editorial"
        Column4.Name = "Column4"
        ' 
        ' Estado
        ' 
        Estado.HeaderText = "Estado"
        Estado.Name = "Estado"
        Estado.ReadOnly = True
        ' 
        ' Accion
        ' 
        Accion.HeaderText = "Acción"
        Accion.Name = "Accion"
        ' 
        ' frmSearch
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(DataGridView1)
        Controls.Add(TableLayoutPanel2)
        Controls.Add(TableLayoutPanel1)
        FormBorderStyle = FormBorderStyle.None
        Name = "frmSearch"
        Text = "frmSearch"
        TableLayoutPanel1.ResumeLayout(False)
        TableLayoutPanel1.PerformLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        TableLayoutPanel2.ResumeLayout(False)
        TableLayoutPanel2.PerformLayout()
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents Button1 As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TableLayoutPanel2 As TableLayoutPanel
    Friend WithEvents Button2 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Nombre As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents Estado As DataGridViewTextBoxColumn
    Friend WithEvents Accion As DataGridViewTextBoxColumn
End Class
