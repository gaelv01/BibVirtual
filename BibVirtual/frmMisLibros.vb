Public Class frmMisLibros
    Implements IPersonalizable
    Private GroupBoxes() As GroupBox
    Private FlowLayoutPanel As FlowLayoutPanel
    Private FormComponentsList As New List(Of Control)




    ' ...

    Public Sub AplicarPersonalizacion() Implements IPersonalizable.AplicarPersonalizacion
        ' Aplicar la personalización en frmMisLibros
        MDarkMode.ApplyDarkMode(Me, MPreferences.toggleOnDarkMode)
        MFont.ChangeFontFamily(FormComponentsList.ToArray(), MPreferences.fontFamily)
        MFont.PutOnBoldStyle(FormComponentsList.ToArray(), MPreferences.boldStyle)
        ' Aplicar la personalización en los GroupBoxes
        For Each groupBox As GroupBox In GroupBoxes
            MDarkMode.ApplyDarkMode(Me, MPreferences.toggleOnDarkMode)
            MFont.ChangeFontFamily(groupBox.Controls.OfType(Of Control)().ToArray(), MPreferences.fontFamily)
            MFont.PutOnBoldStyle(groupBox.Controls.OfType(Of Control)().ToArray(), MPreferences.boldStyle)
        Next

        ' Aplicar la personalización en el FlowLayoutPanel
        MDarkMode.ApplyDarkMode(Me, MPreferences.toggleOnDarkMode)
        MFont.ChangeFontFamily(FlowLayoutPanel.Controls.OfType(Of Control)().ToArray(), MPreferences.fontFamily)
        MFont.PutOnBoldStyle(FlowLayoutPanel.Controls.OfType(Of Control)().ToArray(), MPreferences.boldStyle)
    End Sub


    Private Sub frmMisLibros_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        GroupBoxes = {GroupBox1, GroupBox2, GroupBox3} ' Reemplaza GroupBox1, GroupBox2, GroupBox3 con los nombres reales de tus GroupBoxes
        FlowLayoutPanel = FlowLayoutPanel1 ' Reemplaza FlowLayoutPanel1 con el nombre real de tu FlowLayoutPanel
    End Sub

    ' ...
End Class
