Public Class frmHistory
    Implements IPersonalizable
    Private FormComponentsList As New List(Of Control)
    Dim splitContainer As SplitContainer
    Dim tableLayout As TableLayoutPanel
    Dim grid As DataGridView


    Public Sub AplicarPersonalizacion() Implements IPersonalizable.AplicarPersonalizacion
        MDarkMode.ApplyDarkMode(Me, MPreferences.toggleOnDarkMode)
        MFont.ChangeFontFamily(FormComponentsList.ToArray(), MPreferences.fontFamily)
        MFont.PutOnBoldStyle(FormComponentsList.ToArray(), MPreferences.boldStyle)

        MDarkMode.ApplyDarkMode(Me, MPreferences.toggleOnDarkMode)
        MFont.ChangeFontFamily(splitContainer.Controls.OfType(Of Control).ToArray(), MPreferences.fontFamily)
        MFont.PutOnBoldStyle(splitContainer.Controls.OfType(Of Control).ToArray(), MPreferences.boldStyle)

        MDarkMode.ApplyDarkMode(Me, MPreferences.toggleOnDarkMode)
        MFont.ChangeFontFamily(tableLayout.Controls.OfType(Of Control).ToArray(), MPreferences.fontFamily)
        MFont.PutOnBoldStyle(tableLayout.Controls.OfType(Of Control).ToArray(), MPreferences.boldStyle)

        MDarkMode.ApplyDarkMode(Me, MPreferences.toggleOnDarkMode)
        MFont.ChangeFontFamily(grid.Controls.OfType(Of Control).ToArray(), MPreferences.fontFamily)
        MFont.PutOnBoldStyle(grid.Controls.OfType(Of Control).ToArray(), MPreferences.boldStyle)

    End Sub

    Private Sub frmHistory_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        splitContainer = SplitContainer1
        tableLayout = TableLayoutPanel1
        grid = DataGridView1

    End Sub
End Class