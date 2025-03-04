Public Class Inicio
    ' Lógica para el botón btnGpelis
    Private Sub btnGpelis_Click(sender As Object, e As EventArgs) Handles btnGpelis.Click
        Dim gestionPeliculasForm As New Gestion() ' Crear una instancia del formulario Gestion.vb
        gestionPeliculasForm.Show()              ' Mostrar el formulario Gestion
        Me.Hide()                                ' Ocultar el formulario Inicio
    End Sub

    ' Lógica para el botón btnGsocios
    Private Sub btnGsocios_Click(sender As Object, e As EventArgs) Handles btnGsocios.Click
        Dim gestionSociosForm As New GestionSocios() ' Crear una instancia del formulario GestionSocios.vb
        gestionSociosForm.Show()                    ' Mostrar el formulario GestionSocios
        Me.Hide()                                   ' Ocultar el formulario Inicio
    End Sub

    ' Lógica para el botón btnGalquileres
    Private Sub btnGalquileres_Click(sender As Object, e As EventArgs) Handles btnGalquileres.Click
        Dim gestionAlquileresForm As New GestionAlquileres() ' Crear una instancia del formulario GestionAlquileres.vb
        gestionAlquileresForm.Show()                        ' Mostrar el formulario GestionAlquileres
        Me.Hide()                                           ' Ocultar el formulario Inicio
    End Sub

    ' Lógica para el botón btnSalir
    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        MsgBox("Finalizando programa", MsgBoxStyle.Information) ' Mostrar mensaje al usuario
        Application.Exit() ' Cerrar la aplicación
    End Sub

    ' Lógica para el MenuStrip: GestionarPelículasToolStripMenuItem
    Private Sub GestionarPelículasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GestionarPeliculasToolStripMenuItem.Click
        Dim gestionPeliculasForm As New Gestion() ' Crear una instancia del formulario Gestion.vb
        gestionPeliculasForm.Show()              ' Mostrar el formulario Gestion
        Me.Hide()                                ' Ocultar el formulario Inicio
    End Sub

    ' Lógica para el MenuStrip: GestionarSociosToolStripMenuItem
    Private Sub GestionarSociosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GestionarSociosToolStripMenuItem.Click
        Dim gestionSociosForm As New GestionSocios() ' Crear una instancia del formulario GestionSocios.vb
        gestionSociosForm.Show()                    ' Mostrar el formulario GestionSocios
        Me.Hide()                                   ' Ocultar el formulario Inicio
    End Sub

    ' Lógica para el MenuStrip: GestionarAlquileresToolStripMenuItem
    Private Sub GestionarAlquileresToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GestionarAlquileresToolStripMenuItem.Click
        Dim gestionAlquileresForm As New GestionAlquileres() ' Crear una instancia del formulario GestionAlquileres.vb
        gestionAlquileresForm.Show()                        ' Mostrar el formulario GestionAlquileres
        Me.Hide()                                           ' Ocultar el formulario Inicio
    End Sub

    ' Lógica para el MenuStrip: SalirToolStripMenuItem
    Private Sub SalirToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SalirToolStripMenuItem.Click
        MsgBox("Finalizando programa", MsgBoxStyle.Information) ' Mostrar mensaje al usuario
        Application.Exit() ' Cerrar la aplicación
    End Sub
End Class