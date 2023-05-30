Module MDarkMode
    Public Sub ApplyDarkMode(f As Form, isDarkModeOn As Boolean)
        Dim backgroundColor As Color
        Dim foregroundColor As Color

        If isDarkModeOn Then
            backgroundColor = Color.FromArgb(255, 30, 30, 30)
            foregroundColor = Color.White
        Else
            backgroundColor = Color.White
            foregroundColor = Color.Black
        End If

        ApplyDarkModeOnControl(f, backgroundColor, foregroundColor)
    End Sub

    Private Sub ApplyDarkModeOnControl(control As Control, backgroundColor As Color, foregroundColor As Color)
        control.BackColor = backgroundColor
        control.ForeColor = foregroundColor

        For Each childControl In control.Controls
            ApplyDarkModeOnControl(childControl, backgroundColor, foregroundColor)
        Next
    End Sub
End Module
