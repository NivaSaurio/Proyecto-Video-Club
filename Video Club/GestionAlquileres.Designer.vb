<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class GestionAlquileres
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(GestionAlquileres))
        Me.msGestion = New System.Windows.Forms.MenuStrip()
        Me.MenuToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GdevToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ListadoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SalirToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AyudaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.InformacionToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GestionDeVideoClubV09ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.btnListado = New System.Windows.Forms.Button()
        Me.lblFdev = New System.Windows.Forms.Label()
        Me.lblFalq = New System.Windows.Forms.Label()
        Me.lblTitulo = New System.Windows.Forms.Label()
        Me.lblSocio = New System.Windows.Forms.Label()
        Me.btnGdev = New System.Windows.Forms.Button()
        Me.btnAnadir = New System.Windows.Forms.Button()
        Me.btnVolver = New System.Windows.Forms.Button()
        Me.cbSocio = New System.Windows.Forms.ComboBox()
        Me.cbTitulo = New System.Windows.Forms.ComboBox()
        Me.dtAlq = New System.Windows.Forms.DateTimePicker()
        Me.dtDev = New System.Windows.Forms.DateTimePicker()
        Me.btnLimpiar = New System.Windows.Forms.Button()
        Me.msGestion.SuspendLayout()
        Me.SuspendLayout()
        '
        'msGestion
        '
        Me.msGestion.BackColor = System.Drawing.Color.Transparent
        Me.msGestion.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MenuToolStripMenuItem, Me.AyudaToolStripMenuItem, Me.InformacionToolStripMenuItem})
        Me.msGestion.Location = New System.Drawing.Point(0, 0)
        Me.msGestion.Name = "msGestion"
        Me.msGestion.Size = New System.Drawing.Size(1104, 24)
        Me.msGestion.TabIndex = 19
        Me.msGestion.Text = "MenuStrip1"
        '
        'MenuToolStripMenuItem
        '
        Me.MenuToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.GdevToolStripMenuItem, Me.ListadoToolStripMenuItem, Me.SalirToolStripMenuItem})
        Me.MenuToolStripMenuItem.Name = "MenuToolStripMenuItem"
        Me.MenuToolStripMenuItem.Size = New System.Drawing.Size(50, 20)
        Me.MenuToolStripMenuItem.Text = "Menú"
        '
        'GdevToolStripMenuItem
        '
        Me.GdevToolStripMenuItem.Name = "GdevToolStripMenuItem"
        Me.GdevToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.GdevToolStripMenuItem.Text = "Gestionar dev."
        '
        'ListadoToolStripMenuItem
        '
        Me.ListadoToolStripMenuItem.Name = "ListadoToolStripMenuItem"
        Me.ListadoToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.ListadoToolStripMenuItem.Text = "Lista alquileres"
        '
        'SalirToolStripMenuItem
        '
        Me.SalirToolStripMenuItem.Name = "SalirToolStripMenuItem"
        Me.SalirToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.SalirToolStripMenuItem.Text = "Salir"
        '
        'AyudaToolStripMenuItem
        '
        Me.AyudaToolStripMenuItem.Name = "AyudaToolStripMenuItem"
        Me.AyudaToolStripMenuItem.Size = New System.Drawing.Size(53, 20)
        Me.AyudaToolStripMenuItem.Text = "Ayuda"
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
        'btnListado
        '
        Me.btnListado.Font = New System.Drawing.Font("Lucida Bright", 15.0!, System.Drawing.FontStyle.Bold)
        Me.btnListado.Location = New System.Drawing.Point(888, 324)
        Me.btnListado.Name = "btnListado"
        Me.btnListado.Size = New System.Drawing.Size(138, 67)
        Me.btnListado.TabIndex = 54
        Me.btnListado.Text = "Lista Alquileres"
        Me.btnListado.UseVisualStyleBackColor = True
        '
        'lblFdev
        '
        Me.lblFdev.AutoSize = True
        Me.lblFdev.BackColor = System.Drawing.Color.Transparent
        Me.lblFdev.Font = New System.Drawing.Font("Lucida Bright", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFdev.Location = New System.Drawing.Point(560, 184)
        Me.lblFdev.Name = "lblFdev"
        Me.lblFdev.Size = New System.Drawing.Size(221, 23)
        Me.lblFdev.TabIndex = 52
        Me.lblFdev.Text = "Fecha de devolución"
        '
        'lblFalq
        '
        Me.lblFalq.AutoSize = True
        Me.lblFalq.BackColor = System.Drawing.Color.Transparent
        Me.lblFalq.Font = New System.Drawing.Font("Lucida Bright", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFalq.Location = New System.Drawing.Point(560, 122)
        Me.lblFalq.Name = "lblFalq"
        Me.lblFalq.Size = New System.Drawing.Size(183, 23)
        Me.lblFalq.TabIndex = 50
        Me.lblFalq.Text = "Fecha de alquiler"
        '
        'lblTitulo
        '
        Me.lblTitulo.AutoSize = True
        Me.lblTitulo.BackColor = System.Drawing.Color.Transparent
        Me.lblTitulo.Font = New System.Drawing.Font("Lucida Bright", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitulo.Location = New System.Drawing.Point(48, 184)
        Me.lblTitulo.Name = "lblTitulo"
        Me.lblTitulo.Size = New System.Drawing.Size(201, 23)
        Me.lblTitulo.TabIndex = 48
        Me.lblTitulo.Text = "Selecciona película"
        '
        'lblSocio
        '
        Me.lblSocio.AutoSize = True
        Me.lblSocio.BackColor = System.Drawing.Color.Transparent
        Me.lblSocio.Font = New System.Drawing.Font("Lucida Bright", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSocio.Location = New System.Drawing.Point(48, 122)
        Me.lblSocio.Name = "lblSocio"
        Me.lblSocio.Size = New System.Drawing.Size(177, 23)
        Me.lblSocio.TabIndex = 46
        Me.lblSocio.Text = "Selecciona socio"
        '
        'btnGdev
        '
        Me.btnGdev.Font = New System.Drawing.Font("Lucida Bright", 15.0!, System.Drawing.FontStyle.Bold)
        Me.btnGdev.Location = New System.Drawing.Point(633, 324)
        Me.btnGdev.Name = "btnGdev"
        Me.btnGdev.Size = New System.Drawing.Size(138, 67)
        Me.btnGdev.TabIndex = 43
        Me.btnGdev.Text = "Gestionar Devolución"
        Me.btnGdev.UseVisualStyleBackColor = True
        '
        'btnAnadir
        '
        Me.btnAnadir.Font = New System.Drawing.Font("Lucida Bright", 15.0!, System.Drawing.FontStyle.Bold)
        Me.btnAnadir.Location = New System.Drawing.Point(360, 324)
        Me.btnAnadir.Name = "btnAnadir"
        Me.btnAnadir.Size = New System.Drawing.Size(138, 67)
        Me.btnAnadir.TabIndex = 42
        Me.btnAnadir.Text = "Añadir alquiler"
        Me.btnAnadir.UseVisualStyleBackColor = True
        '
        'btnVolver
        '
        Me.btnVolver.Font = New System.Drawing.Font("Lucida Bright", 15.0!, System.Drawing.FontStyle.Bold)
        Me.btnVolver.Location = New System.Drawing.Point(51, 324)
        Me.btnVolver.Name = "btnVolver"
        Me.btnVolver.Size = New System.Drawing.Size(138, 67)
        Me.btnVolver.TabIndex = 41
        Me.btnVolver.Text = "Volver"
        Me.btnVolver.UseVisualStyleBackColor = True
        '
        'cbSocio
        '
        Me.cbSocio.FormattingEnabled = True
        Me.cbSocio.Location = New System.Drawing.Point(273, 124)
        Me.cbSocio.Name = "cbSocio"
        Me.cbSocio.Size = New System.Drawing.Size(225, 21)
        Me.cbSocio.TabIndex = 55
        '
        'cbTitulo
        '
        Me.cbTitulo.FormattingEnabled = True
        Me.cbTitulo.Location = New System.Drawing.Point(273, 186)
        Me.cbTitulo.Name = "cbTitulo"
        Me.cbTitulo.Size = New System.Drawing.Size(225, 21)
        Me.cbTitulo.TabIndex = 56
        '
        'dtAlq
        '
        Me.dtAlq.Location = New System.Drawing.Point(808, 124)
        Me.dtAlq.Name = "dtAlq"
        Me.dtAlq.Size = New System.Drawing.Size(200, 20)
        Me.dtAlq.TabIndex = 57
        '
        'dtDev
        '
        Me.dtDev.Location = New System.Drawing.Point(808, 183)
        Me.dtDev.Name = "dtDev"
        Me.dtDev.Size = New System.Drawing.Size(200, 20)
        Me.dtDev.TabIndex = 58
        '
        'btnLimpiar
        '
        Me.btnLimpiar.Font = New System.Drawing.Font("Lucida Bright", 15.0!, System.Drawing.FontStyle.Bold)
        Me.btnLimpiar.Location = New System.Drawing.Point(868, 242)
        Me.btnLimpiar.Name = "btnLimpiar"
        Me.btnLimpiar.Size = New System.Drawing.Size(140, 31)
        Me.btnLimpiar.TabIndex = 59
        Me.btnLimpiar.Text = "Limpiar"
        Me.btnLimpiar.UseVisualStyleBackColor = True
        '
        'GestionAlquileres
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Video_Club.My.Resources.Resources.background
        Me.ClientSize = New System.Drawing.Size(1104, 561)
        Me.Controls.Add(Me.btnLimpiar)
        Me.Controls.Add(Me.dtDev)
        Me.Controls.Add(Me.dtAlq)
        Me.Controls.Add(Me.cbTitulo)
        Me.Controls.Add(Me.cbSocio)
        Me.Controls.Add(Me.btnListado)
        Me.Controls.Add(Me.lblFdev)
        Me.Controls.Add(Me.lblFalq)
        Me.Controls.Add(Me.lblTitulo)
        Me.Controls.Add(Me.lblSocio)
        Me.Controls.Add(Me.btnGdev)
        Me.Controls.Add(Me.btnAnadir)
        Me.Controls.Add(Me.btnVolver)
        Me.Controls.Add(Me.msGestion)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "GestionAlquileres"
        Me.Text = "GestionAlquileres"
        Me.msGestion.ResumeLayout(False)
        Me.msGestion.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents msGestion As MenuStrip
    Friend WithEvents MenuToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents GdevToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ListadoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SalirToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AyudaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents InformacionToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents GestionDeVideoClubV09ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents btnListado As Button
    Friend WithEvents lblFdev As Label
    Friend WithEvents lblFalq As Label
    Friend WithEvents lblTitulo As Label
    Friend WithEvents lblSocio As Label
    Friend WithEvents btnGdev As Button
    Friend WithEvents btnAnadir As Button
    Friend WithEvents btnVolver As Button
    Friend WithEvents cbSocio As ComboBox
    Friend WithEvents cbTitulo As ComboBox
    Friend WithEvents dtAlq As DateTimePicker
    Friend WithEvents dtDev As DateTimePicker
    Friend WithEvents btnLimpiar As Button
End Class
