Public Class frmHelp
    Implements IPersonalizable
    Dim FormComponentsList As New List(Of Control)
    Dim TableLayoutPanels() As TableLayoutPanel

    Public Sub AplicarPersonalizacion() Implements IPersonalizable.AplicarPersonalizacion
        MDarkMode.ApplyDarkMode(Me, MPreferences.toggleOnDarkMode)
        MFont.ChangeFontFamily(FormComponentsList.ToArray(), MPreferences.fontFamily)
        MFont.PutOnBoldStyle(FormComponentsList.ToArray(), MPreferences.boldStyle)

        For Each tb As TableLayoutPanel In TableLayoutPanels
            MFont.ChangeFontFamily(tb.Controls.OfType(Of Control).ToArray(), MPreferences.fontFamily)
            MFont.PutOnBoldStyle(tb.Controls.OfType(Of Control).ToArray(), MPreferences.boldStyle)
        Next
    End Sub

    Private Sub frmHelp_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TableLayoutPanels = {TableLayoutPanel1, TableLayoutPanel3}
    End Sub
End Class