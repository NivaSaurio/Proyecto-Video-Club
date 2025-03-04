Public Class Form1

    ' El temporizador
    Dim WithEvents timer As New Timer()
    Dim crud As New CRUD()
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        crud.CrearTablas()
        ' Establecer el intervalo del temporizador a 5 segundos
        timer.Interval = 5000
        ' Iniciar el temporizador
        timer.Start()
    End Sub

    ' Al presionar el botón, cambiar de formulario
    Private Sub btnIniciar_Click(sender As Object, e As EventArgs) Handles btnIniciar.Click
        CambiarFormulario()
    End Sub

    ' Cuando el temporizador alcanza los 20 segundos, cambiar de formulario
    Private Sub timer_Tick(sender As Object, e As EventArgs) Handles timer.Tick
        CambiarFormulario()
    End Sub

    ' Función para cambiar de formulario
    Private Sub CambiarFormulario()
        ' Detener el temporizador
        timer.Stop()

        ' Cambiar a Inicio
        Dim nuevoFormulario As New Inicio()
        nuevoFormulario.Show()

        ' Opcional: cerrar el formulario actual
        Me.Hide()
    End Sub
End Class