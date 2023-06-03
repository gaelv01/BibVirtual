Public Class frmPersonalizar
    Private Sub btnAplicar_Click(sender As Object, e As EventArgs) Handles btnAplicar.Click
        ' Obtener el formulario de índice abierto
        Dim fPrincipal As frmIndex = CType(Application.OpenForms("frmIndex"), frmIndex)
        ' Obtener los componentes del formulario de índice
        Dim components As Control() = fPrincipal.FormComponents

        ' Aplicar el modo oscuro según la selección del usuario
        Select Case cbxModoColor.Text
            Case "Claro"
                MPreferences.toggleOnDarkMode = False
            Case "Oscuro"
                MPreferences.toggleOnDarkMode = True
        End Select

        ' Cambiar la fuente y negrita según la selección del usuario
        MPreferences.fontFamily = cbxTipografia.Text
        MPreferences.boldStyle = chbxNegritas.Checked

        ' Aplicar la personalización en frmIndex y en cualquier formulario que implemente IPersonalizable
        fPrincipal.AplicarPersonalizacion()

        For Each form As Form In Application.OpenForms
            If TypeOf form Is IPersonalizable AndAlso form IsNot fPrincipal Then
                CType(form, IPersonalizable).AplicarPersonalizacion()
            End If
        Next
    End Sub

    Private Sub frmPersonalizar_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MDarkMode.ApplyDarkMode(Me, MPreferences.toggleOnDarkMode)
        MFont.PutOnBoldStyle(Me.Controls.OfType(Of Control).ToArray(), MPreferences.boldStyle)
        MFont.ChangeFontFamily(Me.Controls.OfType(Of Control).ToArray(), MPreferences.fontFamily)

        cbxModoColor.Text = "Claro"
        cbxTipografia.Text = "Inter"
        If MPreferences.boldStyle = True Then
            chbxNegritas.Checked = True
        End If
    End Sub
End Class
