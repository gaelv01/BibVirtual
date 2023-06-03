Imports System.Windows.Forms.VisualStyles.VisualStyleElement.Button

Public Class frmSearch
    Implements IPersonalizable
    Private FormComponentsList As New List(Of Control)
    Private TableLayoutP1() As TableLayoutPanel


    Public Sub AplicarPersonalizacion() Implements IPersonalizable.AplicarPersonalizacion
        ' Aplicar la personalización en frmMisLibros
        MDarkMode.ApplyDarkMode(Me, MPreferences.toggleOnDarkMode)
        MFont.ChangeFontFamily(FormComponentsList.ToArray(), MPreferences.fontFamily)
        MFont.PutOnBoldStyle(FormComponentsList.ToArray(), MPreferences.boldStyle)

        For Each tb As TableLayoutPanel In TableLayoutP1
            MDarkMode.ApplyDarkMode(Me, MPreferences.toggleOnDarkMode)
            MFont.ChangeFontFamily(tb.Controls.OfType(Of Control)().ToArray(), MPreferences.fontFamily)
            MFont.PutOnBoldStyle(tb.Controls.OfType(Of Control)().ToArray(), MPreferences.boldStyle)
        Next
    End Sub

    Private Sub frmSearch_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TableLayoutP1 = {TableLayoutPanel1, TableLayoutPanel2} ' Reemplaza FlowLayoutPanel1 con el nombre real de tu FlowLayoutPanel
    End Sub
End Class