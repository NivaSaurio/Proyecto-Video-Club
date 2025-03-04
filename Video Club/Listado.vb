Imports System.Data.SQLite

Public Class Listado
    Dim crud As New CRUD() ' Instancia del módulo CRUD

    ' Evento para inicializar el formulario
    Private Sub FormularioListadoPeliculas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Añadir los géneros al ComboBox, incluyendo la opción "Todos"
        cbGenero.Items.AddRange(New String() {"Todos", "Aventura", "Catástrofe", "Ciencia Ficción", "Comedia", "Documentales", "Drama", "Fantasía"})
        cbGenero.SelectedIndex = 0 ' Seleccionar "Todos" por defecto
        cbGenero.DropDownStyle = ComboBoxStyle.DropDownList ' Evitar la escritura en el ComboBox

        ' Configurar las columnas del ListView
        lvPeliculas.View = View.Details
        lvPeliculas.Columns.Add("ID", 50)
        lvPeliculas.Columns.Add("Título", 150)
        lvPeliculas.Columns.Add("Año", 70)
        lvPeliculas.Columns.Add("Duración", 90)
        lvPeliculas.Columns.Add("Director", 150)
        lvPeliculas.Columns.Add("Género", 120)

        ' Mostrar todas las películas al abrir el formulario
        MostrarPeliculas("Todos")
    End Sub

    ' Método para mostrar películas basado en el género seleccionado
    Private Sub MostrarPeliculas(generoSeleccionado As String)
        ' Limpiar el ListView antes de mostrar resultados
        lvPeliculas.Items.Clear()

        ' Construir la consulta SQL
        Dim query As String
        If generoSeleccionado = "Todos" Then
            query = "SELECT id, titulo, anio, duracion, director, genero FROM peliculas"
        Else
            query = "SELECT id, titulo, anio, duracion, director, genero FROM peliculas WHERE genero = @genero"
        End If

        Try
            ' Crear un DataTable para almacenar los resultados
            Dim dt As New DataTable()

            Using con As New SQLiteConnection("Data Source=C:\Users\Andres\source\repos\Video Club\video_club.db; Version=3;")
                con.Open()
                Using cmd As New SQLiteCommand(query, con)
                    ' Si no es "Todos", agregar el parámetro del género
                    If generoSeleccionado <> "Todos" Then
                        cmd.Parameters.AddWithValue("@genero", generoSeleccionado)
                    End If

                    ' Llenar el DataTable con los resultados
                    Using adapter As New SQLiteDataAdapter(cmd)
                        adapter.Fill(dt)
                    End Using
                End Using
            End Using

            ' Añadir los resultados al ListView
            For Each row As DataRow In dt.Rows
                Dim item As New ListViewItem(row("id").ToString())
                item.SubItems.Add(row("titulo").ToString())
                item.SubItems.Add(row("anio").ToString())
                item.SubItems.Add(row("duracion").ToString() & " min")
                item.SubItems.Add(row("director").ToString())
                item.SubItems.Add(row("genero").ToString())
                lvPeliculas.Items.Add(item)
            Next
        Catch ex As Exception
            MsgBox("Error al buscar películas: " & ex.Message, MsgBoxStyle.Critical)
        End Try
    End Sub

    ' Lógica para el botón Buscar
    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        ' Obtener el género seleccionado del ComboBox
        Dim generoSeleccionado As String = cbGenero.SelectedItem.ToString()
        MostrarPeliculas(generoSeleccionado)
    End Sub

    ' Lógica para el botón Volver
    Private Sub btnVolver_Click(sender As Object, e As EventArgs) Handles btnVolver.Click
        ' Volver al formulario principal (Gestion.vb)
        Dim gestionForm As New Gestion()
        gestionForm.Show()
        Me.Close()
    End Sub
End Class