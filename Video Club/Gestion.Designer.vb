<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Gestion
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Gestion))
        Me.btnAnadir = New System.Windows.Forms.Button()
        Me.lblID = New System.Windows.Forms.Label()
        Me.tbID = New System.Windows.Forms.TextBox()
        Me.tbTitulo = New System.Windows.Forms.TextBox()
        Me.lblTitulo = New System.Windows.Forms.Label()
        Me.tbAnio = New System.Windows.Forms.TextBox()
        Me.lblAnio = New System.Windows.Forms.Label()
        Me.tbDuracion = New System.Windows.Forms.TextBox()
        Me.lblDuracion = New System.Windows.Forms.Label()
        Me.tbDirector = New System.Windows.Forms.TextBox()
        Me.lblDirector = New System.Windows.Forms.Label()
        Me.lblGenero = New System.Windows.Forms.Label()
        Me.cbGenero = New System.Windows.Forms.ComboBox()
        Me.btnBuscar = New System.Windows.Forms.Button()
        Me.btnListado = New System.Windows.Forms.Button()
        Me.btnEliminar = New System.Windows.Forms.Button()
        Me.btnEditar = New System.Windows.Forms.Button()
        Me.msGestion = New System.Windows.Forms.MenuStrip()
        Me.MenuToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AnadirToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EditarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EliminarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SalirToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.InformacionToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GestionDeVideoClubV09ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.lblSinopsis = New System.Windows.Forms.Label()
        Me.tbSinopsis = New System.Windows.Forms.TextBox()
        Me.btnVolver = New System.Windows.Forms.Button()
        Me.msGestion.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnAnadir
        '
        Me.btnAnadir.Font = New System.Drawing.Font("Lucida Bright", 15.0!, System.Drawing.FontStyle.Bold)
        Me.btnAnadir.Location = New System.Drawing.Point(52, 411)
        Me.btnAnadir.Name = "btnAnadir"
        Me.btnAnadir.Size = New System.Drawing.Size(138, 53)
        Me.btnAnadir.TabIndex = 0
        Me.btnAnadir.Text = "Añadir"
        Me.btnAnadir.UseVisualStyleBackColor = True
        '
        'lblID
        '
        Me.lblID.AutoSize = True
        Me.lblID.BackColor = System.Drawing.Color.Transparent
        Me.lblID.Font = New System.Drawing.Font("Lucida Bright", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblID.Location = New System.Drawing.Point(44, 62)
        Me.lblID.Name = "lblID"
        Me.lblID.Size = New System.Drawing.Size(33, 23)
        Me.lblID.TabIndex = 3
        Me.lblID.Text = "ID"
        '
        'tbID
        '
        Me.tbID.Location = New System.Drawing.Point(236, 65)
        Me.tbID.Name = "tbID"
        Me.tbID.Size = New System.Drawing.Size(100, 20)
        Me.tbID.TabIndex = 4
        '
        'tbTitulo
        '
        Me.tbTitulo.Location = New System.Drawing.Point(236, 129)
        Me.tbTitulo.Name = "tbTitulo"
        Me.tbTitulo.Size = New System.Drawing.Size(282, 20)
        Me.tbTitulo.TabIndex = 6
        '
        'lblTitulo
        '
        Me.lblTitulo.AutoSize = True
        Me.lblTitulo.BackColor = System.Drawing.Color.Transparent
        Me.lblTitulo.Font = New System.Drawing.Font("Lucida Bright", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitulo.Location = New System.Drawing.Point(44, 126)
        Me.lblTitulo.Name = "lblTitulo"
        Me.lblTitulo.Size = New System.Drawing.Size(153, 23)
        Me.lblTitulo.TabIndex = 5
        Me.lblTitulo.Text = "Título película"
        '
        'tbAnio
        '
        Me.tbAnio.Location = New System.Drawing.Point(236, 193)
        Me.tbAnio.Name = "tbAnio"
        Me.tbAnio.Size = New System.Drawing.Size(282, 20)
        Me.tbAnio.TabIndex = 8
        '
        'lblAnio
        '
        Me.lblAnio.AutoSize = True
        Me.lblAnio.BackColor = System.Drawing.Color.Transparent
        Me.lblAnio.Font = New System.Drawing.Font("Lucida Bright", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAnio.Location = New System.Drawing.Point(44, 188)
        Me.lblAnio.Name = "lblAnio"
        Me.lblAnio.Size = New System.Drawing.Size(135, 23)
        Me.lblAnio.TabIndex = 7
        Me.lblAnio.Text = "Año película"
        '
        'tbDuracion
        '
        Me.tbDuracion.Location = New System.Drawing.Point(236, 267)
        Me.tbDuracion.Name = "tbDuracion"
        Me.tbDuracion.Size = New System.Drawing.Size(100, 20)
        Me.tbDuracion.TabIndex = 10
        '
        'lblDuracion
        '
        Me.lblDuracion.AutoSize = True
        Me.lblDuracion.BackColor = System.Drawing.Color.Transparent
        Me.lblDuracion.Font = New System.Drawing.Font("Lucida Bright", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDuracion.Location = New System.Drawing.Point(44, 264)
        Me.lblDuracion.Name = "lblDuracion"
        Me.lblDuracion.Size = New System.Drawing.Size(186, 23)
        Me.lblDuracion.TabIndex = 9
        Me.lblDuracion.Text = "Duración película"
        '
        'tbDirector
        '
        Me.tbDirector.Location = New System.Drawing.Point(761, 129)
        Me.tbDirector.Name = "tbDirector"
        Me.tbDirector.Size = New System.Drawing.Size(247, 20)
        Me.tbDirector.TabIndex = 12
        '
        'lblDirector
        '
        Me.lblDirector.AutoSize = True
        Me.lblDirector.BackColor = System.Drawing.Color.Transparent
        Me.lblDirector.Font = New System.Drawing.Font("Lucida Bright", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDirector.Location = New System.Drawing.Point(556, 126)
        Me.lblDirector.Name = "lblDirector"
        Me.lblDirector.Size = New System.Drawing.Size(199, 23)
        Me.lblDirector.TabIndex = 11
        Me.lblDirector.Text = "Director/a película"
        '
        'lblGenero
        '
        Me.lblGenero.AutoSize = True
        Me.lblGenero.BackColor = System.Drawing.Color.Transparent
        Me.lblGenero.Font = New System.Drawing.Font("Lucida Bright", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblGenero.Location = New System.Drawing.Point(556, 188)
        Me.lblGenero.Name = "lblGenero"
        Me.lblGenero.Size = New System.Drawing.Size(169, 23)
        Me.lblGenero.TabIndex = 13
        Me.lblGenero.Text = "Genero película"
        '
        'cbGenero
        '
        Me.cbGenero.FormattingEnabled = True
        Me.cbGenero.Location = New System.Drawing.Point(761, 193)
        Me.cbGenero.Name = "cbGenero"
        Me.cbGenero.Size = New System.Drawing.Size(165, 21)
        Me.cbGenero.TabIndex = 14
        '
        'btnBuscar
        '
        Me.btnBuscar.Font = New System.Drawing.Font("Lucida Bright", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBuscar.Location = New System.Drawing.Point(342, 62)
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.Size = New System.Drawing.Size(98, 23)
        Me.btnBuscar.TabIndex = 15
        Me.btnBuscar.Text = "Buscar"
        Me.btnBuscar.UseVisualStyleBackColor = True
        '
        'btnListado
        '
        Me.btnListado.Font = New System.Drawing.Font("Lucida Bright", 15.0!, System.Drawing.FontStyle.Bold)
        Me.btnListado.Location = New System.Drawing.Point(889, 411)
        Me.btnListado.Name = "btnListado"
        Me.btnListado.Size = New System.Drawing.Size(138, 53)
        Me.btnListado.TabIndex = 16
        Me.btnListado.Text = "Ver Lista"
        Me.btnListado.UseVisualStyleBackColor = True
        '
        'btnEliminar
        '
        Me.btnEliminar.Font = New System.Drawing.Font("Lucida Bright", 15.0!, System.Drawing.FontStyle.Bold)
        Me.btnEliminar.Location = New System.Drawing.Point(634, 411)
        Me.btnEliminar.Name = "btnEliminar"
        Me.btnEliminar.Size = New System.Drawing.Size(138, 53)
        Me.btnEliminar.TabIndex = 2
        Me.btnEliminar.Text = "Eliminar"
        Me.btnEliminar.UseVisualStyleBackColor = True
        '
        'btnEditar
        '
        Me.btnEditar.Font = New System.Drawing.Font("Lucida Bright", 15.0!, System.Drawing.FontStyle.Bold)
        Me.btnEditar.Location = New System.Drawing.Point(361, 411)
        Me.btnEditar.Name = "btnEditar"
        Me.btnEditar.Size = New System.Drawing.Size(138, 53)
        Me.btnEditar.TabIndex = 1
        Me.btnEditar.Text = "Editar"
        Me.btnEditar.UseVisualStyleBackColor = True
        '
        'msGestion
        '
        Me.msGestion.BackColor = System.Drawing.Color.Transparent
        Me.msGestion.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MenuToolStripMenuItem, Me.InformacionToolStripMenuItem})
        Me.msGestion.Location = New System.Drawing.Point(0, 0)
        Me.msGestion.Name = "msGestion"
        Me.msGestion.Size = New System.Drawing.Size(1104, 24)
        Me.msGestion.TabIndex = 17
        Me.msGestion.Text = "MenuStrip1"
        '
        'MenuToolStripMenuItem
        '
        Me.MenuToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AnadirToolStripMenuItem, Me.EditarToolStripMenuItem, Me.EliminarToolStripMenuItem, Me.SalirToolStripMenuItem})
        Me.MenuToolStripMenuItem.Name = "MenuToolStripMenuItem"
        Me.MenuToolStripMenuItem.Size = New System.Drawing.Size(50, 20)
        Me.MenuToolStripMenuItem.Text = "Menú"
        '
        'AnadirToolStripMenuItem
        '
        Me.AnadirToolStripMenuItem.Name = "AnadirToolStripMenuItem"
        Me.AnadirToolStripMenuItem.Size = New System.Drawing.Size(117, 22)
        Me.AnadirToolStripMenuItem.Text = "Añadir"
        '
        'EditarToolStripMenuItem
        '
        Me.EditarToolStripMenuItem.Name = "EditarToolStripMenuItem"
        Me.EditarToolStripMenuItem.Size = New System.Drawing.Size(117, 22)
        Me.EditarToolStripMenuItem.Text = "Editar"
        '
        'EliminarToolStripMenuItem
        '
        Me.EliminarToolStripMenuItem.Name = "EliminarToolStripMenuItem"
        Me.EliminarToolStripMenuItem.Size = New System.Drawing.Size(117, 22)
        Me.EliminarToolStripMenuItem.Text = "Eliminar"
        '
        'SalirToolStripMenuItem
        '
        Me.SalirToolStripMenuItem.Name = "SalirToolStripMenuItem"
        Me.SalirToolStripMenuItem.Size = New System.Drawing.Size(117, 22)
        Me.SalirToolStripMenuItem.Text = "Salir"
        '
        'InformacionToolStripMenuItem
        '
        Me.InformacionToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.GestionDeVideoClubV09ToolStripMenuItem})
        Me.InformacionToolStripMenuItem.Name = "InformacionToolStripMenuItem"
        Me.InformacionToolStripMenuItem.Size = New System.Drawing.Size(84, 20)
        Me.InformacionToolStripMenuItem.Text = "Información"
        '
        'GestionDeVideoClubV09ToolStripMenuItem
        '
        Me.GestionDeVideoClubV09ToolStripMenuItem.Name = "GestionDeVideoClubV09ToolStripMenuItem"
        Me.GestionDeVideoClubV09ToolStripMenuItem.Size = New System.Drawing.Size(230, 22)
        Me.GestionDeVideoClubV09ToolStripMenuItem.Text = "Gestión de VideoClub v.0.0.01"
        '
        'lblSinopsis
        '
        Me.lblSinopsis.AutoSize = True
        Me.lblSinopsis.BackColor = System.Drawing.Color.Transparent
        Me.lblSinopsis.Font = New System.Drawing.Font("Lucida Bright", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSinopsis.Location = New System.Drawing.Point(556, 262)
        Me.lblSinopsis.Name = "lblSinopsis"
        Me.lblSinopsis.Size = New System.Drawing.Size(95, 23)
        Me.lblSinopsis.TabIndex = 18
        Me.lblSinopsis.Text = "Sinopsis"
        '
        'tbSinopsis
        '
        Me.tbSinopsis.Location = New System.Drawing.Point(662, 253)
        Me.tbSinopsis.Multiline = True
        Me.tbSinopsis.Name = "tbSinopsis"
        Me.tbSinopsis.Size = New System.Drawing.Size(393, 131)
        Me.tbSinopsis.TabIndex = 19
        '
        'btnVolver
        '
        Me.btnVolver.Font = New System.Drawing.Font("Lucida Bright", 15.0!, System.Drawing.FontStyle.Bold)
        Me.btnVolver.Location = New System.Drawing.Point(494, 496)
        Me.btnVolver.Name = "btnVolver"
        Me.btnVolver.Size = New System.Drawing.Size(138, 53)
        Me.btnVolver.TabIndex = 20
        Me.btnVolver.Text = "Volver"
        Me.btnVolver.UseVisualStyleBackColor = True
        '
        'Gestion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Video_Club.My.Resources.Resources.background
        Me.ClientSize = New System.Drawing.Size(1104, 561)
        Me.Controls.Add(Me.btnVolver)
        Me.Controls.Add(Me.tbSinopsis)
        Me.Controls.Add(Me.lblSinopsis)
        Me.Controls.Add(Me.btnListado)
        Me.Controls.Add(Me.btnBuscar)
        Me.Controls.Add(Me.cbGenero)
        Me.Controls.Add(Me.lblGenero)
        Me.Controls.Add(Me.tbDirector)
        Me.Controls.Add(Me.lblDirector)
        Me.Controls.Add(Me.tbDuracion)
        Me.Controls.Add(Me.lblDuracion)
        Me.Controls.Add(Me.tbAnio)
        Me.Controls.Add(Me.lblAnio)
        Me.Controls.Add(Me.tbTitulo)
        Me.Controls.Add(Me.lblTitulo)
        Me.Controls.Add(Me.tbID)
        Me.Controls.Add(Me.lblID)
        Me.Controls.Add(Me.btnEliminar)
        Me.Controls.Add(Me.btnEditar)
        Me.Controls.Add(Me.btnAnadir)
        Me.Controls.Add(Me.msGestion)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.msGestion
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Gestion"
        Me.Text = "Gestión de peliculas"
        Me.msGestion.ResumeLayout(False)
        Me.msGestion.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnAnadir As Button
    Friend WithEvents lblID As Label
    Friend WithEvents tbID As TextBox
    Friend WithEvents tbTitulo As TextBox
    Friend WithEvents lblTitulo As Label
    Friend WithEvents tbAnio As TextBox
    Friend WithEvents lblAnio As Label
    Friend WithEvents tbDuracion As TextBox
    Friend WithEvents lblDuracion As Label
    Friend WithEvents tbDirector As TextBox
    Friend WithEvents lblDirector As Label
    Friend WithEvents lblGenero As Label
    Friend WithEvents cbGenero As ComboBox
    Friend WithEvents btnBuscar As Button
    Friend WithEvents btnListado As Button
    Friend WithEvents btnEliminar As Button
    Friend WithEvents btnEditar As Button
    Friend WithEvents msGestion As MenuStrip
    Friend WithEvents MenuToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AnadirToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EditarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EliminarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SalirToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents InformacionToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents GestionDeVideoClubV09ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents lblSinopsis As Label
    Friend WithEvents tbSinopsis As TextBox
    Friend WithEvents btnVolver As Button
End Class
