Public Class frmReserves
    Implements IPersonalizable
    Dim FormComponentsList As New List(Of Control)
    Dim grid As DataGridView
    Dim TableLayoutPanels() As TableLayoutPanel


    Public Sub AplicarPersonalizacion() Implements IPersonalizable.AplicarPersonalizacion
        MDarkMode.ApplyDarkMode(Me, MPreferences.toggleOnDarkMode)
        MFont.ChangeFontFamily(FormComponentsList.ToArray(), MPreferences.fontFamily)
        MFont.PutOnBoldStyle(FormComponentsList.ToArray(), MPreferences.boldStyle)

        For Each container As TableLayoutPanel In TableLayoutPanels
            MDarkMode.ApplyDarkMode(Me, MPreferences.toggleOnDarkMode)
            MFont.ChangeFontFamily(container.Controls.OfType(Of Control).ToArray(), MPreferences.fontFamily)
            MFont.PutOnBoldStyle(container.Controls.OfType(Of Control).ToArray(), MPreferences.boldStyle)
        Next

        MFont.ChangeFontFamily(grid.Controls.OfType(Of Control).ToArray(), MPreferences.fontFamily)
        MFont.PutOnBoldStyle(grid.Controls.OfType(Of Control).ToArray(), MPreferences.boldStyle)

    End Sub

    Private Sub frmReserves_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        grid = DataGridView1
        TableLayoutPanels = {TableLayoutPanel1, TableLayoutPanel2}
    End Sub
End Class