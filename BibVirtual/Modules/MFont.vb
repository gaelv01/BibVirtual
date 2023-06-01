Module MFont
    Private ExcludedComponents As New List(Of Control)

    Public Sub ChangeFontFamily(components As Control(), fontName As String)
        ' Cambiar la fuente de los componentes excepto los excluidos
        For Each control In components
            If Not ExcludedComponents.Contains(control) Then
                control.Font = New Font(fontName, control.Font.Size, control.Font.Style)
            End If
        Next
    End Sub

    Public Sub PutOnBoldStyle(components As Control(), toggle As Boolean)
        ' Aplicar o quitar el estilo de negrita a los componentes
        For Each control In components
            If toggle Then
                control.Font = New Font(control.Font.Name, control.Font.Size, FontStyle.Bold)
            Else
                control.Font = New Font(control.Font.Name, control.Font.Size, FontStyle.Regular)
            End If
        Next
    End Sub

    Public Sub ExcludeComponent(component As Control)
        ' Excluir un componente de los cambios de fuente
        ExcludedComponents.Add(component)
    End Sub
End Module
