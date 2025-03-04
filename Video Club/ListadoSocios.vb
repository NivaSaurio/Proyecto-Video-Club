Imports System.Data.SQLite

Public Class ListadoSocios
    Dim crud As New CRUD() ' Instancia del módulo CRUD

    ' Evento para inicializar el formulario
    Private Sub ListadoSocios_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Configurar las columnas del ListView
        lvSocios.View = View.Details
        lvSocios.Columns.Add("ID", 50, HorizontalAlignment.Left)
        lvSocios.Columns.Add("Nombre", 150, HorizontalAlignment.Left)
        lvSocios.Columns.Add("Dirección", 200, HorizontalAlignment.Left)
        lvSocios.Columns.Add("Teléfono", 100, HorizontalAlignment.Left)
        lvSocios.Columns.Add("Email", 200, HorizontalAlignment.Left)
        lvSocios.FullRowSelect = True

        ' Llenar el ListView con todos los socios
        MostrarTodosLosSocios()
    End Sub

    ' Método para mostrar todos los socios
    Private Sub MostrarTodosLosSocios()
        lvSocios.Items.Clear() ' Limpiar el ListView antes de llenarlo

        Try
            Dim query As String = "SELECT id, nombre, direccion, telefono, email FROM socios"
            Dim dt As New DataTable()

            Using con As New SQLiteConnection("Data Source=C:\Users\Andres\source\repos\Video Club\video_club.db; Version=3;")
                con.Open()
                Using cmd As New SQLiteCommand(query, con)
                    Using adapter As New SQLiteDataAdapter(cmd)
                        adapter.Fill(dt)
                    End Using
                End Using
            End Using

            ' Agregar los datos al ListView
            For Each row As DataRow In dt.Rows
                Dim item As New ListViewItem(row("id").ToString())
                item.SubItems.Add(row("nombre").ToString())
                item.SubItems.Add(row("direccion").ToString())
                item.SubItems.Add(row("telefono").ToString())
                item.SubItems.Add(row("email").ToString())
                lvSocios.Items.Add(item)
            Next
        Catch ex As Exception
            MsgBox("Error al cargar la lista de socios: " & ex.Message, MsgBoxStyle.Critical)
        End Try
    End Sub

    ' Lógica para el botón Volver
    Private Sub btnVolver_Click(sender As Object, e As EventArgs) Handles btnVolver.Click
        Dim gestionSociosForm As New GestionSocios() ' Crear una instancia del formulario GestionSocios
        gestionSociosForm.Show()                    ' Mostrar el formulario GestionSocios
        Me.Close()                                  ' Cerrar el formulario ListadoSocios
    End Sub
End Class