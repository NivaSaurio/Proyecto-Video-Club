Imports System.Data.SQLite

Public Class GestionSocios
    Dim crud As New CRUD() ' Instancia del módulo CRUD
    Private contexto As String = ""

    ' Evento para inicializar el formulario
    Private Sub GestionSocios_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Estado inicial del formulario
        ResetFormulario()
    End Sub

    ' Método para resetear el formulario al estado inicial
    Private Sub ResetFormulario()
        For Each control As Control In Me.Controls
            If TypeOf control Is TextBox Or TypeOf control Is Button Then
                control.Enabled = False
            End If
        Next
        btnListado.Enabled = True ' Siempre activo
        btnVolver.Enabled = True  ' Asegurar que btnVolver siempre esté habilitado
        tbEmail.Text = "ejemplo@correo.com" ' Placeholder para email
        tbEmail.ForeColor = Color.Gray
    End Sub

    ' Placeholder para tbEmail
    Private Sub tbEmail_Enter(sender As Object, e As EventArgs) Handles tbEmail.Enter
        If tbEmail.Text = "ejemplo@correo.com" Then
            tbEmail.Text = ""
            tbEmail.ForeColor = Color.Black
        End If
    End Sub

    Private Sub tbEmail_Leave(sender As Object, e As EventArgs) Handles tbEmail.Leave
        If String.IsNullOrWhiteSpace(tbEmail.Text) Then
            tbEmail.Text = "ejemplo@correo.com"
            tbEmail.ForeColor = Color.Gray
        End If
    End Sub

    ' Validar que solo se introduzcan números en tbTfn
    Private Sub tbTfn_KeyPress(sender As Object, e As KeyPressEventArgs) Handles tbTfn.KeyPress
        If Not Char.IsDigit(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then
            e.Handled = True ' Bloquea la entrada de caracteres no numéricos
        End If
    End Sub

    ' Lógica para Añadir
    Private Sub AnadirToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AnadirToolStripMenuItem.Click
        ResetFormulario()
        btnAnadir.Enabled = True
        tbNombre.Enabled = True
        tbDireccion.Enabled = True
        tbTfn.Enabled = True
        tbEmail.Enabled = True
    End Sub

    Private Sub btnAnadir_Click(sender As Object, e As EventArgs) Handles btnAnadir.Click
        ' Validar que todos los campos estén llenos
        If String.IsNullOrWhiteSpace(tbNombre.Text) Or String.IsNullOrWhiteSpace(tbDireccion.Text) Or
           String.IsNullOrWhiteSpace(tbTfn.Text) Or String.IsNullOrWhiteSpace(tbEmail.Text) Or
           tbEmail.Text = "ejemplo@correo.com" Or Not tbEmail.Text.Contains("@") Then
            MsgBox("Error al registrar socio, faltan datos o el correo es inválido", MsgBoxStyle.Critical)
            Exit Sub
        End If

        Try
            ' Consulta SQL para insertar un nuevo socio
            Dim query As String = "INSERT INTO socios (nombre, direccion, telefono, email) " &
                                  "VALUES (@nombre, @direccion, @telefono, @email)"

            Using con As New SQLiteConnection("Data Source=C:\Users\Andres\source\repos\Video Club\video_club.db; Version=3;")
                Using cmd As New SQLiteCommand(query, con)
                    cmd.Parameters.AddWithValue("@nombre", tbNombre.Text)
                    cmd.Parameters.AddWithValue("@direccion", tbDireccion.Text)
                    cmd.Parameters.AddWithValue("@telefono", tbTfn.Text)
                    cmd.Parameters.AddWithValue("@email", tbEmail.Text)

                    con.Open()
                    cmd.ExecuteNonQuery()
                End Using
            End Using

            MsgBox("Socio registrado con éxito", MsgBoxStyle.Information)
            ResetFormulario()
        Catch ex As Exception
            MsgBox("Error al registrar socio: " & ex.Message, MsgBoxStyle.Critical)
        End Try
    End Sub

    ' Lógica para Editar
    Private Sub EditarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EditarToolStripMenuItem.Click
        ResetFormulario()
        contexto = "editar"
        lblID.Enabled = True
        tbID.Enabled = True
        btnBuscar.Enabled = True
        MsgBox("Introduce ID para editar", MsgBoxStyle.Information)
    End Sub
    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        ' Validar que el ID es válido
        If String.IsNullOrWhiteSpace(tbID.Text) OrElse Not IsNumeric(tbID.Text) Then
            MsgBox("Por favor, ingrese un ID válido.", MsgBoxStyle.Critical)
            Exit Sub
        End If

        Dim query As String = "SELECT * FROM socios WHERE id = @id"
        Try
            Dim dt As New DataTable()

            Using con As New SQLiteConnection("Data Source=C:\Users\Andres\source\repos\Video Club\video_club.db; Version=3;")
                Using cmd As New SQLiteCommand(query, con)
                    cmd.Parameters.AddWithValue("@id", tbID.Text)

                    Using adapter As New SQLiteDataAdapter(cmd)
                        adapter.Fill(dt)
                    End Using
                End Using
            End Using

            If dt.Rows.Count = 0 Then
                MsgBox("Error, ID inexistente, pruebe otra vez", MsgBoxStyle.Critical)
                Exit Sub
            End If

            ' Rellenar los campos con los datos del socio
            tbNombre.Text = dt.Rows(0)("nombre").ToString()
            tbDireccion.Text = dt.Rows(0)("direccion").ToString()
            tbTfn.Text = dt.Rows(0)("telefono").ToString()
            tbEmail.Text = dt.Rows(0)("email").ToString()

            ' Controlar el comportamiento según el contexto
            If contexto = "editar" Then
                ' Habilitar campos para edición
                tbNombre.Enabled = True
                tbDireccion.Enabled = True
                tbTfn.Enabled = True
                tbEmail.Enabled = True
                btnEditar.Enabled = True
            ElseIf contexto = "eliminar" Then
                ' Desactivar campos y habilitar solo el botón de eliminación
                tbNombre.Enabled = False
                tbDireccion.Enabled = False
                tbTfn.Enabled = False
                tbEmail.Enabled = False
                btnEditar.Enabled = True
            End If
        Catch ex As Exception
            MsgBox("Error al buscar socio: " & ex.Message, MsgBoxStyle.Critical)
        End Try
    End Sub

    Private Sub btnEditar_Click(sender As Object, e As EventArgs) Handles btnEditar.Click
        ' Validar que todos los campos estén llenos
        If String.IsNullOrWhiteSpace(tbNombre.Text) Or String.IsNullOrWhiteSpace(tbDireccion.Text) Or
       String.IsNullOrWhiteSpace(tbTfn.Text) Or String.IsNullOrWhiteSpace(tbEmail.Text) Or
       tbEmail.Text = "ejemplo@correo.com" Or Not tbEmail.Text.Contains("@") Then
            MsgBox("Error al registrar socio, faltan datos o el correo es inválido", MsgBoxStyle.Critical)
            Exit Sub
        End If

        Try
            ' Consulta SQL para actualizar los datos del socio
            Dim query As String = "UPDATE socios SET nombre = @nombre, direccion = @direccion, telefono = @telefono, email = @email WHERE id = @id"

            Using con As New SQLiteConnection("Data Source=C:\Users\Andres\source\repos\Video Club\video_club.db; Version=3;")
                Using cmd As New SQLiteCommand(query, con)
                    cmd.Parameters.AddWithValue("@nombre", tbNombre.Text)
                    cmd.Parameters.AddWithValue("@direccion", tbDireccion.Text)
                    cmd.Parameters.AddWithValue("@telefono", tbTfn.Text)
                    cmd.Parameters.AddWithValue("@email", tbEmail.Text)
                    cmd.Parameters.AddWithValue("@id", tbID.Text)

                    con.Open()
                    cmd.ExecuteNonQuery()
                End Using
            End Using

            MsgBox("Socio editado correctamente", MsgBoxStyle.Information)
            ResetFormulario()
            contexto = "" ' Restablecer el contexto aquí
        Catch ex As Exception
            MsgBox("Error al editar socio: " & ex.Message, MsgBoxStyle.Critical)
        End Try
    End Sub

    ' Lógica para Eliminar
    Private Sub EliminarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EliminarToolStripMenuItem.Click
        ResetFormulario()
        contexto = "eliminar"
        lblID.Enabled = True
        tbID.Enabled = True
        btnBuscar.Enabled = True
        MsgBox("Introduce ID para eliminar", MsgBoxStyle.Information)
    End Sub

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        ' Confirmar eliminación
        Dim result As DialogResult = MessageBox.Show("¿Está seguro de que desea eliminar este socio?", "Confirmar eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
        If result = DialogResult.No Then
            Exit Sub
        End If

        Try
            ' Consulta SQL para eliminar el socio
            Dim query As String = "DELETE FROM socios WHERE id = @id"

            Using con As New SQLiteConnection("Data Source=C:\Users\Andres\source\repos\Video Club\video_club.db; Version=3;")
                Using cmd As New SQLiteCommand(query, con)
                    cmd.Parameters.AddWithValue("@id", tbID.Text)

                    con.Open()
                    cmd.ExecuteNonQuery()
                End Using
            End Using

            MsgBox("Socio eliminado correctamente", MsgBoxStyle.Information)
            ResetFormulario()
            contexto = ""
        Catch ex As Exception
            MsgBox("Error al eliminar socio: " & ex.Message, MsgBoxStyle.Critical)
        End Try
    End Sub

    'Volver a Inicio
    Private Sub btnVolver_Click(sender As Object, e As EventArgs) Handles btnVolver.Click
        Dim inicioForm As New Inicio() ' Crear una instancia del formulario Inicio
        inicioForm.Show()              ' Mostrar el formulario Inicio
        Me.Close()                     ' Cerrar el formulario GestionSocios
    End Sub

    'Ver lista de socios
    Private Sub btnListado_Click(sender As Object, e As EventArgs) Handles btnListado.Click
        Dim listadoSociosForm As New ListadoSocios() ' Crear una instancia del formulario ListadoSocios
        listadoSociosForm.Show()                    ' Mostrar el formulario ListadoSocios
        Me.Hide()                                   ' Ocultar el formulario GestionSocios
    End Sub

    ' Salir del programa
    Private Sub SalirToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SalirToolStripMenuItem.Click
        MsgBox("Finalizando programa", MsgBoxStyle.Information)
        Application.Exit() ' Cierra la aplicación completamente
    End Sub
End Class