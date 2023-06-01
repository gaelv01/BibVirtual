Module MDarkMode
    Public Sub ApplyDarkMode(form As Form, isDarkModeOn As Boolean)
        ' Aplicar el modo oscuro a un formulario y sus controles
        Dim backgroundColor As Color
        Dim foregroundColor As Color

        If isDarkModeOn Then
            backgroundColor = Color.FromArgb(255, 30, 30, 30)
            foregroundColor = Color.White
        Else
            backgroundColor = Color.White
            foregroundColor = Color.Black
        End If

        ApplyDarkModeOnControl(form, backgroundColor, foregroundColor)
    End Sub

    Private Sub ApplyDarkModeOnControl(control As Control, backgroundColor As Color, foregroundColor As Color)
        ' Aplicar el modo oscuro a un control y sus controles secundarios
        control.BackColor = backgroundColor
        control.ForeColor = foregroundColor

        For Each childControl In control.Controls
            ApplyDarkModeOnControl(childControl, backgroundColor, foregroundColor)
        Next
    End Sub
End Module
