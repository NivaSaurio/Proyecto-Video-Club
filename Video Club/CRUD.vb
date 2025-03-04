Imports System.Data.SQLite

Public Class CRUD
    ' Ruta de la base de datos SQLite
    Dim con As New SQLiteConnection("Data Source=C:\Users\Andres\source\repos\Video Club\video_club.db; Version=3;")
    Public Sub CrearTablas()
        Dim queries As String() = {
        "CREATE TABLE IF NOT EXISTS peliculas (
            id INTEGER PRIMARY KEY AUTOINCREMENT,
            titulo TEXT NOT NULL,
            anio INTEGER NOT NULL,
            duracion INTEGER NOT NULL,
            director TEXT NOT NULL,
            genero TEXT NOT NULL,
            sinopsis TEXT,
            disponible BOOLEAN NOT NULL DEFAULT 1
        );",
        "CREATE TABLE IF NOT EXISTS socios (
            id INTEGER PRIMARY KEY AUTOINCREMENT,
            nombre TEXT NOT NULL,
            direccion TEXT NOT NULL,
            telefono TEXT NOT NULL,
            email TEXT
        );",
        "CREATE TABLE IF NOT EXISTS alquileres (
            id INTEGER PRIMARY KEY AUTOINCREMENT,
            id_socio INTEGER NOT NULL,
            id_pelicula INTEGER NOT NULL,
            fecha_alquiler DATE NOT NULL,
            fecha_devolucion DATE,
            fecha_devuelta DATE,
            FOREIGN KEY(id_socio) REFERENCES socios(id),
            FOREIGN KEY(id_pelicula) REFERENCES peliculas(id)
        );"
    }

        Try
            ' Ejecutar consultas para crear tablas
            For Each query As String In queries
                operaciones(query)
            Next

            ' Verificar y agregar columnas a las tablas existentes
            VerificarYAgregarColumnas()
        Catch ex As Exception
            MsgBox("Error al crear las tablas: " & ex.Message, MsgBoxStyle.Critical)
        End Try
    End Sub

    Private Sub VerificarYAgregarColumnas()
        Try
            ' Verificar y agregar la columna "disponible" en "peliculas"
            Dim queryCheck As String = "PRAGMA table_info(peliculas)"
            Dim columnaExiste As Boolean = False

            Using con As New SQLiteConnection("Data Source=C:\Users\Andres\source\repos\Video Club\video_club.db; Version=3;")
                con.Open()
                Using cmd As New SQLiteCommand(queryCheck, con)
                    Using reader As SQLiteDataReader = cmd.ExecuteReader()
                        While reader.Read()
                            If reader("name").ToString() = "disponible" Then
                                columnaExiste = True
                                Exit While
                            End If
                        End While
                    End Using
                End Using

                ' Si la columna no existe, agregarla
                If Not columnaExiste Then
                    Dim queryAlter As String = "ALTER TABLE peliculas ADD COLUMN disponible BOOLEAN NOT NULL DEFAULT 1"
                    Using cmd As New SQLiteCommand(queryAlter, con)
                        cmd.ExecuteNonQuery()
                    End Using
                End If
            End Using
        Catch ex As Exception
            MsgBox("Error al verificar o agregar columnas: " & ex.Message, MsgBoxStyle.Critical)
        End Try
    End Sub


    ' Método para probar la conexión a la base de datos
    Sub conexion()
        Try
            con.Open()
            MsgBox("Conexión realizada de manera exitosa", MsgBoxStyle.Information, "Tutorial CRUD con SQLite")
            con.Close()
        Catch ex As Exception
            MsgBox("No se logró realizar la conexión: " & ex.Message, MsgBoxStyle.Critical, "Tutorial CRUD con SQLite")
        End Try
    End Sub

    ' Método para realizar consultas y llenar un DataGridView
    Public Function consulta(query As String) As DataTable
        Dim dt As New DataTable()
        Try
            Using con As New SQLiteConnection("Data Source=C:\Users\Andres\source\repos\Video Club\video_club.db; Version=3;")
                con.Open()
                Using cmd As New SQLiteCommand(query, con)
                    Using adapter As New SQLiteDataAdapter(cmd)
                        adapter.Fill(dt)
                    End Using
                End Using
            End Using
        Catch ex As Exception
            MsgBox("No se logró realizar la consulta: " & ex.Message, MsgBoxStyle.Critical)
        End Try
        Return dt
    End Function

    ' Método para realizar operaciones CRUD (Agregar, Actualizar, Eliminar)
    Sub operaciones(ByVal Sql As String)
        Try
            con.Open()
            Dim cmd As New SQLiteCommand(Sql, con)
            cmd.ExecuteNonQuery()
        Catch ex As Exception
            MsgBox("No se logró realizar la operación: " & ex.Message, MsgBoxStyle.Critical, "Tutorial CRUD con SQLite")
        Finally
            con.Close()
        End Try
    End Sub
End Class