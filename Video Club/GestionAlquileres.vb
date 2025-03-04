Imports System.Data.SQLite

Public Class GestionAlquileres
    Public Class Item
        Public Property Text As String ' El texto a mostrar en el ComboBox
        Public Property Value As Integer ' El valor asociado (ID)

        Public Overrides Function ToString() As String
            Return Text ' Mostrar el texto en el ComboBox
        End Function
    End Class

    Private Sub GestionAlquileres_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ResetFormulario() ' Llamar al estado inicial
        CargarSocios() ' Cargar socios elegibles
        CargarPeliculasDisponibles() ' Cargar películas disponibles
    End Sub

    Private Sub ResetFormulario()
        ' Limpiar ComboBoxes
        cbSocio.SelectedIndex = -1
        cbTitulo.SelectedIndex = -1

        ' Configurar DateTimePickers
        dtAlq.Value = DateTime.Now
        dtDev.Value = DateTime.Now.AddDays(15)

        ' Deshabilitar DateTimePickers
        dtAlq.Enabled = False
        dtDev.Enabled = False
    End Sub
    Private Sub CargarSocios()
        cbSocio.Items.Clear()

        Dim query As String = "SELECT id, nombre FROM socios WHERE id NOT IN " &
                          "(SELECT id_socio FROM alquileres WHERE fecha_devuelta IS NULL GROUP BY id_socio HAVING COUNT(*) >= 3)"

        Using con As New SQLiteConnection("Data Source=C:\Users\Andres\source\repos\Video Club\video_club.db; Version=3;")
            con.Open()
            Using cmd As New SQLiteCommand(query, con)
                Using reader As SQLiteDataReader = cmd.ExecuteReader()
                    While reader.Read()
                        Dim socio As New Item With {
                        .Text = reader("nombre").ToString(),
                        .Value = Convert.ToInt32(reader("id"))
                    }
                        cbSocio.Items.Add(socio)
                    End While
                End Using
            End Using
        End Using

        cbSocio.DisplayMember = "Text"
        cbSocio.ValueMember = "Value"
    End Sub
    Private Sub CargarPeliculasDisponibles()
        cbTitulo.Items.Clear()

        Dim query As String = "SELECT id, titulo FROM peliculas WHERE disponible = 1"

        Using con As New SQLiteConnection("Data Source=C:\Users\Andres\source\repos\Video Club\video_club.db; Version=3;")
            con.Open()
            Using cmd As New SQLiteCommand(query, con)
                Using reader As SQLiteDataReader = cmd.ExecuteReader()
                    While reader.Read()
                        Dim pelicula As New Item With {
                        .Text = reader("titulo").ToString(),
                        .Value = Convert.ToInt32(reader("id"))
                    }
                        cbTitulo.Items.Add(pelicula)
                    End While
                End Using
            End Using
        End Using

        cbTitulo.DisplayMember = "Text"
        cbTitulo.ValueMember = "Value"
    End Sub
    Private Sub btnAnadir_Click(sender As Object, e As EventArgs) Handles btnAnadir.Click
        ' Validar que se hayan seleccionado un socio y una película
        If cbSocio.SelectedIndex = -1 Or cbTitulo.SelectedIndex = -1 Then
            MsgBox("Error, rellene los campos correctamente", MsgBoxStyle.Critical)
            Exit Sub
        End If

        Try
            Dim socioSeleccionado As Item = DirectCast(cbSocio.SelectedItem, Item)
            Dim peliculaSeleccionada As Item = DirectCast(cbTitulo.SelectedItem, Item)

            Dim query As String = "INSERT INTO alquileres (id_socio, id_pelicula, fecha_alquiler, fecha_devolucion) " &
                              "VALUES (@id_socio, @id_pelicula, @fecha_alquiler, @fecha_devolucion); " &
                              "UPDATE peliculas SET disponible = 0 WHERE id = @id_pelicula"

            Using con As New SQLiteConnection("Data Source=C:\Users\Andres\source\repos\Video Club\video_club.db; Version=3;")
                con.Open()
                Using cmd As New SQLiteCommand(query, con)
                    ' Insertar parámetros
                    cmd.Parameters.AddWithValue("@id_socio", socioSeleccionado.Value)
                    cmd.Parameters.AddWithValue("@id_pelicula", peliculaSeleccionada.Value)
                    cmd.Parameters.AddWithValue("@fecha_alquiler", dtAlq.Value)
                    cmd.Parameters.AddWithValue("@fecha_devolucion", dtDev.Value)

                    cmd.ExecuteNonQuery()
                End Using
            End Using

            MsgBox("Alquiler guardado", MsgBoxStyle.Information)
            ResetFormulario()
        Catch ex As Exception
            MsgBox("Error al registrar el alquiler: " & ex.Message, MsgBoxStyle.Critical)
        End Try
    End Sub
    Private Sub btnListado_Click(sender As Object, e As EventArgs) Handles btnListado.Click
        Dim listadoAlquileresForm As New ListadoAlquileres()
        listadoAlquileresForm.Show()
        Me.Hide() ' Oculta el formulario actual
    End Sub
    Private Sub ListadoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ListadoToolStripMenuItem.Click
        Dim listadoAlquileresForm As New ListadoAlquileres()
        listadoAlquileresForm.Show()
        Me.Hide()
    End Sub
    Private Sub GdevToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GdevToolStripMenuItem.Click
        Dim gestionDevAlquilerForm As New GestionDevAlquiler()
        gestionDevAlquilerForm.Show()
        Me.Hide() ' Oculta el formulario actual
    End Sub
    Private Sub btnGdev_Click(sender As Object, e As EventArgs) Handles btnGdev.Click
        Dim gestionDevAlquilerForm As New GestionDevAlquiler()
        gestionDevAlquilerForm.Show()
        Me.Hide() ' Oculta el formulario actual
    End Sub

    Private Sub SalirToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SalirToolStripMenuItem.Click
        MsgBox("Finalizando programa", MsgBoxStyle.Information, "Salir")
        Application.Exit() ' Finaliza la aplicación
    End Sub
    Private Sub btnVolver_Click(sender As Object, e As EventArgs) Handles btnVolver.Click
        Dim inicioForm As New Inicio()
        inicioForm.Show()
        Me.Close()
    End Sub
    Private Sub btnLimpiar_Click(sender As Object, e As EventArgs) Handles btnLimpiar.Click
        ResetFormulario()
        CargarSocios()
        CargarPeliculasDisponibles()
    End Sub
End Class