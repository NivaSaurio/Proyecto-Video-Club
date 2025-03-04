Imports System.Data.SQLite

Public Class GestionDevAlquiler
    Public Class ComboBoxItem
        Public Property Value As Integer
        Public Property Text As String

        Public Sub New(ByVal value As Integer, ByVal text As String)
            Me.Value = value
            Me.Text = text
        End Sub

        Public Overrides Function ToString() As String
            Return Me.Text ' Esto asegura que solo se muestre el texto en el ComboBox
        End Function
    End Class

    Private Sub GestionDevAlquiler_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Configurar ComboBox
        cbSocio.DropDownStyle = ComboBoxStyle.DropDownList
        cbTitulo.DropDownStyle = ComboBoxStyle.DropDownList
        CargarSociosConAlquileres()
    End Sub

    Private Sub CargarSociosConAlquileres()
        cbSocio.Items.Clear()
        Dim query As String = "SELECT DISTINCT s.id, s.nombre FROM socios s " &
                              "JOIN alquileres a ON s.id = a.id_socio " &
                              "WHERE a.fecha_devuelta IS NULL"

        Using con As New SQLiteConnection("Data Source=C:\Users\Andres\source\repos\Video Club\video_club.db; Version=3;")
            con.Open()
            Using cmd As New SQLiteCommand(query, con)
                Using reader As SQLiteDataReader = cmd.ExecuteReader()
                    While reader.Read()
                        cbSocio.Items.Add(New ComboBoxItem(reader("id"), reader("nombre").ToString()))
                    End While
                End Using
            End Using
        End Using
    End Sub

    Private Sub cbSocio_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbSocio.SelectedIndexChanged
        If cbSocio.SelectedItem IsNot Nothing Then
            Dim selectedSocioId As Integer = CType(cbSocio.SelectedItem, ComboBoxItem).Value
            CargarPeliculasDelSocio(selectedSocioId)
        End If
    End Sub

    Private Sub CargarPeliculasDelSocio(idSocio As Integer)
        cbTitulo.Items.Clear()
        Dim query As String = "SELECT p.id, p.titulo FROM peliculas p " &
                              "JOIN alquileres a ON p.id = a.id_pelicula " &
                              "WHERE a.id_socio = @idSocio AND a.fecha_devuelta IS NULL"

        Using con As New SQLiteConnection("Data Source=C:\Users\Andres\source\repos\Video Club\video_club.db; Version=3;")
            con.Open()
            Using cmd As New SQLiteCommand(query, con)
                cmd.Parameters.AddWithValue("@idSocio", idSocio)
                Using reader As SQLiteDataReader = cmd.ExecuteReader()
                    While reader.Read()
                        cbTitulo.Items.Add(New ComboBoxItem(reader("id"), reader("titulo").ToString()))
                    End While
                End Using
            End Using
        End Using
    End Sub

    Private Sub cbTitulo_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbTitulo.SelectedIndexChanged
        If cbTitulo.SelectedItem IsNot Nothing Then
            Dim selectedPeliculaId As Integer = CType(cbTitulo.SelectedItem, ComboBoxItem).Value
            MostrarFechasDelAlquiler(selectedPeliculaId)
        End If
    End Sub

    Private Sub MostrarFechasDelAlquiler(idPelicula As Integer)
        Dim query As String = "SELECT a.fecha_alquiler, DATE(a.fecha_alquiler, '+15 days') AS fecha_devolucion " &
                              "FROM alquileres a " &
                              "WHERE a.id_pelicula = @idPelicula AND a.fecha_devuelta IS NULL"

        Using con As New SQLiteConnection("Data Source=C:\Users\Andres\source\repos\Video Club\video_club.db; Version=3;")
            con.Open()
            Using cmd As New SQLiteCommand(query, con)
                cmd.Parameters.AddWithValue("@idPelicula", idPelicula)
                Using reader As SQLiteDataReader = cmd.ExecuteReader()
                    If reader.Read() Then
                        dtAlq.Value = Convert.ToDateTime(reader("fecha_alquiler"))
                        dtDev.Value = Convert.ToDateTime(reader("fecha_devolucion"))
                        dtPDev.Value = DateTime.Now
                    End If
                End Using
            End Using
        End Using
    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        If cbTitulo.SelectedItem IsNot Nothing Then
            Dim idPelicula As Integer = CType(cbTitulo.SelectedItem, ComboBoxItem).Value
            Dim fechaDevuelta As DateTime = dtPDev.Value

            Dim query As String = "UPDATE alquileres SET fecha_devuelta = @fechaDevuelta WHERE id_pelicula = @idPelicula AND fecha_devuelta IS NULL; " &
                                  "UPDATE peliculas SET disponible = 1 WHERE id = @idPelicula"

            Using con As New SQLiteConnection("Data Source=C:\Users\Andres\source\repos\Video Club\video_club.db; Version=3;")
                con.Open()
                Using cmd As New SQLiteCommand(query, con)
                    cmd.Parameters.AddWithValue("@fechaDevuelta", fechaDevuelta)
                    cmd.Parameters.AddWithValue("@idPelicula", idPelicula)
                    cmd.ExecuteNonQuery()
                    MsgBox("Fecha de devolución registrada y película disponible.", MsgBoxStyle.Information)
                    LimpiarCampos()
                End Using
            End Using
        Else
            MsgBox("Por favor, selecciona una película.", MsgBoxStyle.Exclamation)
        End If
    End Sub

    Private Sub btnVolver_Click(sender As Object, e As EventArgs) Handles btnVolver.Click
        Dim gestionAlquileresForm As New GestionAlquileres()
        gestionAlquileresForm.Show()
        Me.Close()
    End Sub

    Private Sub LimpiarCampos()
        cbSocio.SelectedIndex = -1
        cbTitulo.Items.Clear()
        dtAlq.Value = DateTime.Now
        dtDev.Value = DateTime.Now
        dtPDev.Value = DateTime.Now
    End Sub
End Class