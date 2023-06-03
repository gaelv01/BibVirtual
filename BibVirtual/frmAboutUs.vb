Public Class frmAboutUs
    Implements IPersonalizable

    Public Sub AplicarPersonalizacion() Implements IPersonalizable.AplicarPersonalizacion
        MDarkMode.ApplyDarkMode(Me, MPreferences.toggleOnDarkMode)
        MFont.ExcludeComponent(Label5)
        MFont.ChangeFontFamily(Me.Controls.OfType(Of Control).ToArray(), MPreferences.fontFamily)
    End Sub

    Private Sub frmAboutUs_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class