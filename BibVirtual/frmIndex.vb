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
        OpenFormInPanel(frmRecents)
        lblBienvenida.Text = "¡Hola, usuario!"
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

    Private Sub OpenFormInPanel(FormChild As Form)
        ' Abrir un formulario secundario en el panel de actividades
        FormChild.TopLevel = False
        FormChild.Dock = DockStyle.Fill
        PanelActividades.Controls.Add(FormChild)
        PanelActividades.Tag = FormChild
        MDarkMode.ApplyDarkMode(FormChild, MPreferences.toggleOnDarkMode)
        FormChild.Show()
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
        PanelActividades.Controls.Clear() ' Elimina todos los controles del panel
        OpenFormInPanel(frmMisLibros)
        ChangeTitleAndSubtitle("Mis Libros", "Todos tus libros, en un solo lugar.")
    End Sub

    Private Sub btnInicio_Click(sender As Object, e As EventArgs) Handles btnInicio.Click
        ' Limpiar el panel de actividades y cambiar el título y subtítulo
        PanelActividades.Controls.Clear() ' Elimina todos los controles del panel
        ChangeTitleAndSubtitle("Inicio", "¿Qué te gustaría hacer hoy?")
        OpenFormInPanel(frmRecents)
    End Sub

    Private Sub btnReservas_Click(sender As Object, e As EventArgs) Handles btnReservas.Click
        PanelActividades.Controls.Clear()
        ChangeTitleAndSubtitle("Reservas", "Revisa lo que has estado apartando.")
        OpenFormInPanel(frmReserves)
    End Sub

    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        PanelActividades.Controls.Clear() ' Elimina todos los controles del panel
        ChangeTitleAndSubtitle("Buscar", "Iniciemos una búsqueda.")
        OpenFormInPanel(frmSearch)
    End Sub

    Private Sub btnHistorial_Click(sender As Object, e As EventArgs) Handles btnHistorial.Click
        PanelActividades.Controls.Clear() ' Elimina todos los controles del panel
        ChangeTitleAndSubtitle("Historial", "¿Qué has hecho todo este tiempo?")
        OpenFormInPanel(frmHistory)
    End Sub

    Private Sub btnAjustes_Click(sender As Object, e As EventArgs) Handles btnAjustes.Click
        Dim frmWithoutBorders = New frmPersonalizar
        frmWithoutBorders.FormBorderStyle = FormBorderStyle.None
        PanelActividades.Controls.Clear() ' Elimina todos los controles del panel
        ChangeTitleAndSubtitle("Ajustes (personalización)", "¡Movamos algunos engranajes!")
        OpenFormInPanel(frmWithoutBorders)
    End Sub

    Private Sub btnAyuda_Click(sender As Object, e As EventArgs) Handles btnAyuda.Click
        PanelActividades.Controls.Clear() ' Elimina todos los controles del panel
        ChangeTitleAndSubtitle("Ayuda", "¿Algo pasó? Pongámonos en marcha.")
        OpenFormInPanel(frmHelp)
    End Sub

    Private Sub btnAcercaDe_Click(sender As Object, e As EventArgs) Handles btnAcercaDe.Click
        PanelActividades.Controls.Clear() ' Elimina todos los controles del panel
        ChangeTitleAndSubtitle("Acerca de", "Datos importantísimos.")
        OpenFormInPanel(frmAboutUs)
    End Sub

    Private Sub btnCerrarSesion_Click(sender As Object, e As EventArgs) Handles btnCerrarSesion.Click
        Dim dr As DialogResult

        dr = MessageBox.Show("¿Estás seguro que deseas salir?", "¿Salir?", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If dr = DialogResult.Yes Then
            End
        End If
    End Sub
End Class
