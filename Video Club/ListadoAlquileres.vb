Imports System.Data.SQLite

Public Class ListadoAlquileres
    Private Sub ListadoAlquileres_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Configurar el ComboBox
        cbFiltro.Items.Add("Alquileres activos")
        cbFiltro.Items.Add("Películas disponibles")
        cbFiltro.DropDownStyle = ComboBoxStyle.DropDownList ' Evitar escritura en el ComboBox
        cbFiltro.SelectedIndex = 0 ' Seleccionar "Alquileres activos" por defecto
        MostrarAlquileresActivos() ' Mostrar los alquileres activos al cargar el formulario
    End Sub

    Private Sub MostrarAlquileresActivos()
        lvAlquileres.Items.Clear()
        lvAlquileres.Columns.Clear()

        ' Configurar columnas del ListView
        lvAlquileres.Columns.Add("ID Película", 100, HorizontalAlignment.Left)
        lvAlquileres.Columns.Add("ID Socio", 100, HorizontalAlignment.Left)
        lvAlquileres.Columns.Add("Título Película", 200, HorizontalAlignment.Left)
        lvAlquileres.Columns.Add("Fecha para Devolver", 150, HorizontalAlignment.Left)

        Dim query As String = "SELECT a.id_pelicula, a.id_socio, p.titulo, a.fecha_devolucion " &
                          "FROM alquileres a " &
                          "JOIN peliculas p ON a.id_pelicula = p.id " &
                          "WHERE a.fecha_devuelta IS NULL"

        Using con As New SQLiteConnection("Data Source=C:\Users\Andres\source\repos\Video Club\video_club.db; Version=3;")
            con.Open()
            Using cmd As New SQLiteCommand(query, con)
                Using reader As SQLiteDataReader = cmd.ExecuteReader()
                    If reader.HasRows Then
                        While reader.Read()
                            Dim item As New ListViewItem(reader("id_pelicula").ToString())
                            item.SubItems.Add(reader("id_socio").ToString())
                            item.SubItems.Add(reader("titulo").ToString())
                            item.SubItems.Add(Convert.ToDateTime(reader("fecha_devolucion")).ToString("yyyy-MM-dd"))
                            lvAlquileres.Items.Add(item)
                        End While
                    Else
                        lvAlquileres.Items.Add(New ListViewItem("No hay datos disponibles"))
                    End If
                End Using
            End Using
        End Using
    End Sub

    Private Sub MostrarPeliculasDisponibles()
        lvAlquileres.Items.Clear()
        lvAlquileres.Columns.Clear()

        ' Configurar columnas del ListView
        lvAlquileres.Columns.Add("ID Película", 100, HorizontalAlignment.Left)
        lvAlquileres.Columns.Add("Título Película", 200, HorizontalAlignment.Left)
        lvAlquileres.Columns.Add("Género Película", 150, HorizontalAlignment.Left)

        Dim query As String = "SELECT id, titulo, genero FROM peliculas WHERE disponible = 1"

        Using con As New SQLiteConnection("Data Source=C:\Users\Andres\source\repos\Video Club\video_club.db; Version=3;")
            con.Open()
            Using cmd As New SQLiteCommand(query, con)
                Using reader As SQLiteDataReader = cmd.ExecuteReader()
                    If reader.HasRows Then
                        While reader.Read()
                            Dim item As New ListViewItem(reader("id").ToString())
                            item.SubItems.Add(reader("titulo").ToString())
                            item.SubItems.Add(reader("genero").ToString())
                            lvAlquileres.Items.Add(item)
                        End While
                    Else
                        lvAlquileres.Items.Add(New ListViewItem("No hay datos disponibles"))
                    End If
                End Using
            End Using
        End Using
    End Sub
    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        If cbFiltro.SelectedItem Is Nothing Then
            MsgBox("Por favor, selecciona una opción del filtro.", MsgBoxStyle.Exclamation)
        ElseIf cbFiltro.SelectedItem.ToString() = "Alquileres activos" Then
            MostrarAlquileresActivos()
        ElseIf cbFiltro.SelectedItem.ToString() = "Películas disponibles" Then
            MostrarPeliculasDisponibles()
        End If
    End Sub

    Private Sub btnVolver_Click(sender As Object, e As EventArgs) Handles btnVolver.Click
        Dim gestionAlquileresForm As New GestionAlquileres()
        gestionAlquileresForm.Show()
        Me.Close()
    End Sub
End Class
