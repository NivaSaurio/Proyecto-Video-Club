Imports System.Data.SQLite

Public Class Gestion
    Dim crud As New CRUD()
    Dim contexto As String = "" ' Variable global para controlar el contexto (editar o eliminar)

    ' Evento para inicializar el formulario
    Private Sub Gestion_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Estado inicial: desactivar todo excepto btnListado
        ResetFormulario()
        cbGenero.Items.AddRange(New String() {"Aventura", "Catástrofe", "Ciencia Ficción", "Comedia", "Documentales", "Drama", "Fantasía"})
        cbGenero.DropDownStyle = ComboBoxStyle.DropDownList ' Evitar escritura
    End Sub

    ' Método para resetear el formulario al estado inicial
    Private Sub ResetFormulario()
        For Each control As Control In Me.Controls
            If TypeOf control Is TextBox Or TypeOf control Is ComboBox Or TypeOf control Is Button Then
                control.Enabled = False
            End If
        Next
        btnListado.Enabled = True ' Mantener habilitado siempre
        btnVolver.Enabled = True  ' Asegurar que btnVolver siempre esté activo
        tbAnio.MaxLength = 4 ' Limitar a 4 dígitos
        tbDuracion.Text = "introducir en minutos" ' Placeholder
        tbDuracion.ForeColor = Color.Gray
    End Sub

    ' Placeholder para tbDuracion
    Private Sub tbDuracion_Enter(sender As Object, e As EventArgs) Handles tbDuracion.Enter
        If tbDuracion.Text = "introducir en minutos" Then
            tbDuracion.Text = ""
            tbDuracion.ForeColor = Color.Black
        End If
    End Sub

    Private Sub tbDuracion_Leave(sender As Object, e As EventArgs) Handles tbDuracion.Leave
        If String.IsNullOrWhiteSpace(tbDuracion.Text) Then
            tbDuracion.Text = "introducir en minutos"
            tbDuracion.ForeColor = Color.Gray
        End If
    End Sub

    ' Lógica para Añadir
    Private Sub AnadirToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AnadirToolStripMenuItem.Click
        ResetFormulario()
        btnAnadir.Enabled = True
        tbTitulo.Enabled = True : tbAnio.Enabled = True : tbDuracion.Enabled = True
        tbDirector.Enabled = True : cbGenero.Enabled = True : tbSinopsis.Enabled = True
    End Sub

    Private Sub btnAnadir_Click(sender As Object, e As EventArgs) Handles btnAnadir.Click
        If String.IsNullOrWhiteSpace(tbTitulo.Text) Or String.IsNullOrWhiteSpace(tbAnio.Text) Or
       String.IsNullOrWhiteSpace(tbDuracion.Text) Or String.IsNullOrWhiteSpace(tbDirector.Text) Or
       cbGenero.SelectedIndex = -1 Then
            MsgBox("Error al introducir la película, faltan datos", MsgBoxStyle.Critical)
            Exit Sub
        End If

        Try
            ' Construir la consulta con parámetros
            Dim query As String = "INSERT INTO peliculas (titulo, anio, duracion, director, genero, sinopsis) " &
                              "VALUES (@titulo, @anio, @duracion, @director, @genero, @sinopsis)"

            ' Usar un comando SQLite con parámetros
            Using con As New SQLiteConnection("Data Source=C:\Users\Andres\source\repos\Video Club\video_club.db; Version=3;")
                Using cmd As New SQLiteCommand(query, con)
                    ' Agregar valores a los parámetros
                    cmd.Parameters.AddWithValue("@titulo", tbTitulo.Text)
                    cmd.Parameters.AddWithValue("@anio", CInt(tbAnio.Text)) ' Convertir a entero
                    cmd.Parameters.AddWithValue("@duracion", CInt(tbDuracion.Text)) ' Convertir a entero
                    cmd.Parameters.AddWithValue("@director", tbDirector.Text)
                    cmd.Parameters.AddWithValue("@genero", cbGenero.Text)
                    cmd.Parameters.AddWithValue("@sinopsis", If(String.IsNullOrWhiteSpace(tbSinopsis.Text), DBNull.Value, tbSinopsis.Text)) ' Permitir que sinopsis sea NULL

                    ' Abrir conexión y ejecutar consulta
                    con.Open()
                    cmd.ExecuteNonQuery()
                End Using
            End Using

            MsgBox("Película añadida correctamente", MsgBoxStyle.Information)
            ResetFormulario()
        Catch ex As Exception
            MsgBox("Error al añadir la película: " & ex.Message, MsgBoxStyle.Critical)
        End Try
    End Sub

    ' Lógica para Editar
    Private Sub EditarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EditarToolStripMenuItem.Click
        ResetFormulario()
        contexto = "editar" ' Establecer contexto
        lblID.Enabled = True : tbID.Enabled = True : btnBuscar.Enabled = True
        MsgBox("Introduce ID para editar", MsgBoxStyle.Information)
    End Sub

    ' Lógica para Eliminar
    Private Sub EliminarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EliminarToolStripMenuItem.Click
        ResetFormulario()
        contexto = "eliminar" ' Establecer contexto
        lblID.Enabled = True
        tbID.Enabled = True
        btnBuscar.Enabled = True
        MsgBox("Introduce ID para eliminar", MsgBoxStyle.Information)
    End Sub

    ' Lógica para Buscar (usada tanto en editar como en eliminar)
    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        ' Validar si el ID ingresado es válido
        If String.IsNullOrWhiteSpace(tbID.Text) OrElse Not IsNumeric(tbID.Text) Then
            MsgBox("Por favor, ingrese un ID válido.", MsgBoxStyle.Critical)
            Exit Sub
        End If

        Dim query As String = "SELECT * FROM peliculas WHERE id = " & tbID.Text
        Try
            Dim dt As DataTable = crud.consulta(query)
            If dt.Rows.Count = 0 Then
                MsgBox("Error, ID inexistente, pruebe otra vez", MsgBoxStyle.Critical)
                Exit Sub
            End If

            ' Rellenar los campos con los datos de la película
            tbTitulo.Text = dt.Rows(0)("titulo").ToString()
            tbAnio.Text = dt.Rows(0)("anio").ToString()
            tbDuracion.Text = dt.Rows(0)("duracion").ToString()
            tbDirector.Text = dt.Rows(0)("director").ToString()
            cbGenero.Text = dt.Rows(0)("genero").ToString()
            tbSinopsis.Text = dt.Rows(0)("sinopsis").ToString()

            ' Comportamiento según el contexto
            If contexto = "editar" Then
                ' Habilitar campos para edición
                tbTitulo.Enabled = True
                tbAnio.Enabled = True
                tbDuracion.Enabled = True
                tbDirector.Enabled = True
                cbGenero.Enabled = True
                tbSinopsis.Enabled = True
                btnEditar.Enabled = True
            ElseIf contexto = "eliminar" Then
                ' Desactivar campos para evitar ediciones
                tbTitulo.Enabled = False
                tbAnio.Enabled = False
                tbDuracion.Enabled = False
                tbDirector.Enabled = False
                cbGenero.Enabled = False
                tbSinopsis.Enabled = False
                btnEliminar.Enabled = True
            End If
        Catch ex As Exception
            MsgBox("Error al buscar ID: " & ex.Message, MsgBoxStyle.Critical)
        End Try
    End Sub

    ' Lógica para Editar
    Private Sub btnEditar_Click(sender As Object, e As EventArgs) Handles btnEditar.Click
        If String.IsNullOrWhiteSpace(tbTitulo.Text) Or String.IsNullOrWhiteSpace(tbAnio.Text) Or
           String.IsNullOrWhiteSpace(tbDuracion.Text) Or String.IsNullOrWhiteSpace(tbDirector.Text) Or
           cbGenero.SelectedIndex = -1 Then
            MsgBox("Error al editar la película, faltan datos", MsgBoxStyle.Critical)
            Exit Sub
        End If

        Dim query As String = "UPDATE peliculas SET titulo = '" & tbTitulo.Text & "', " &
                              "anio = " & tbAnio.Text & ", duracion = " & tbDuracion.Text & ", " &
                              "director = '" & tbDirector.Text & "', genero = '" & cbGenero.Text & "', " &
                              "sinopsis = '" & tbSinopsis.Text & "' WHERE id = " & tbID.Text
        crud.operaciones(query)
        MsgBox("Película editada correctamente", MsgBoxStyle.Information)
        ResetFormulario()
        contexto = "" ' Restablecer contexto
    End Sub

    ' Lógica para Eliminar
    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        Dim result As DialogResult = MessageBox.Show("¿Está seguro de que desea eliminar esta película?", "Confirmar eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
        If result = DialogResult.No Then
            Exit Sub
        End If

        Dim query As String = "DELETE FROM peliculas WHERE id = " & tbID.Text
        Try
            crud.operaciones(query)
            MsgBox("Película eliminada correctamente", MsgBoxStyle.Information)
            ResetFormulario()
            contexto = "" ' Restablecer contexto
        Catch ex As Exception
            MsgBox("Error al eliminar película: " & ex.Message, MsgBoxStyle.Critical)
        End Try
    End Sub
    Private Sub btnListado_Click(sender As Object, e As EventArgs) Handles btnListado.Click
        Dim listadoForm As New Listado() ' Crear una instancia del formulario Listado
        listadoForm.Show()               ' Mostrar el formulario Listado
        Me.Hide()                        ' Ocultar el formulario Gestion
    End Sub

    'Volver a Inicio
    Private Sub btnVolver_Click(sender As Object, e As EventArgs) Handles btnVolver.Click
        Dim inicioForm As New Inicio() ' Crear una instancia del formulario Inicio
        inicioForm.Show()              ' Mostrar el formulario Inicio
        Me.Close()                     ' Cerrar el formulario actual (Gestion)
    End Sub

    ' Finalizar programa
    Private Sub SalirToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SalirToolStripMenuItem.Click
        MsgBox("Finalizando programa", MsgBoxStyle.Information)
        Application.Exit()
    End Sub
End Class
