Public Class frmIndex
    Implements IPersonalizable
    ' Array que almacena los componentes del formulario
    Public Property FormComponents As Control()



    ' ...

    Public Sub AplicarPersonalizacion() Implements IPersonalizable.AplicarPersonalizacion
        ' Aplicar la personalización en frmIndex
        MDarkMode.ApplyDarkMode(Me, MPreferences.toggleOnDarkMode)
        MFont.ChangeFontFamily(FormComponents, MPreferences.fontFamily)
        MFont.PutOnBoldStyle(FormComponents, MPreferences.boldStyle)
    End Sub


    Private Sub frmIndex_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Inicializar los componentes del formulario
        InitializeFormComponents()
        ' Aplicar el modo oscuro según la preferencia almacenada
        ApplyDarkMode()
    End Sub

    Private Sub InitializeFormComponents()
        ' Inicializar los componentes del formulario en un array
        FormComponents = New Control() {
            spcContenedorProgram,
            PanelActividades,
            lblBienvenida,
            lblSubBienvenida,
            btnAcercaDe,
            btnAjustes,
            btnAyuda,
            btnBuscar,
            btnCerrarSesion,
            btnHistorial,
            btnInicio,
            btnMisLibros,
            btnPersonalizar,
            btnReservas
        }
    End Sub

    Private Sub ApplyDarkMode()
        ' Aplicar el modo oscuro a todos los componentes del formulario
        MDarkMode.ApplyDarkMode(Me, MPreferences.toggleOnDarkMode)
    End Sub

    Private Sub OpenFormInPanel(FormChild As Object)
        ' Abrir un formulario secundario en el panel de actividades
        Dim frm As Form = FormChild
        frm.TopLevel = False
        frm.Dock = DockStyle.Fill
        PanelActividades.Controls.Add(frm)
        PanelActividades.Tag = frm
        MDarkMode.ApplyDarkMode(frm, MPreferences.toggleOnDarkMode)
        frm.Show()
    End Sub

    Private Sub ChangeTitleAndSubtitle(title As String, subtitle As String)
        ' Cambiar el título y el subtítulo del formulario
        lblSubBienvenida.Text = subtitle
        lblBienvenida.Text = title
    End Sub

    Private Sub btnPersonalizar_Click_1(sender As Object, e As EventArgs) Handles btnPersonalizar.Click
        ' Abrir el formulario de personalización
        frmPersonalizar.Show()
    End Sub

    Private Sub btnMisLibros_Click(sender As Object, e As EventArgs) Handles btnMisLibros.Click
        ' Abrir el formulario "Mis Libros" en el panel de actividades y cambiar el título y subtítulo
        OpenFormInPanel(frmMisLibros)
        ChangeTitleAndSubtitle("Mis Libros", "Todos tus libros, en un solo lugar.")
    End Sub

    Private Sub btnInicio_Click(sender As Object, e As EventArgs) Handles btnInicio.Click
        ' Limpiar el panel de actividades y cambiar el título y subtítulo
        If PanelActividades.Controls.Count > 0 Then
            PanelActividades.Controls.RemoveAt(0)
        End If
        ChangeTitleAndSubtitle("Inicio", "¿Qué te gustaría hacer hoy?")
    End Sub
End Class
