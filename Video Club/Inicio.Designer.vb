<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Inicio
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Inicio))
        Me.lblGpelis = New System.Windows.Forms.Label()
        Me.btnGpelis = New System.Windows.Forms.Button()
        Me.btnGsocios = New System.Windows.Forms.Button()
        Me.lblGsocios = New System.Windows.Forms.Label()
        Me.btnGalquileres = New System.Windows.Forms.Button()
        Me.lblGalquileres = New System.Windows.Forms.Label()
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.OpcionesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GestionarPeliculasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GestionarSociosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GestionarAlquileresToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SalirToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.InformaciónToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GestiónDeVideoClubV0001ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblGpelis
        '
        Me.lblGpelis.AutoSize = True
        Me.lblGpelis.BackColor = System.Drawing.Color.Transparent
        Me.lblGpelis.Font = New System.Drawing.Font("Lucida Bright", 24.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblGpelis.Location = New System.Drawing.Point(12, 186)
        Me.lblGpelis.Name = "lblGpelis"
        Me.lblGpelis.Size = New System.Drawing.Size(336, 37)
        Me.lblGpelis.TabIndex = 2
        Me.lblGpelis.Text = "Gestionar películas"
        '
        'btnGpelis
        '
        Me.btnGpelis.Font = New System.Drawing.Font("Lucida Bright", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGpelis.Location = New System.Drawing.Point(119, 254)
        Me.btnGpelis.Name = "btnGpelis"
        Me.btnGpelis.Size = New System.Drawing.Size(124, 61)
        Me.btnGpelis.TabIndex = 3
        Me.btnGpelis.Text = "Iniciar"
        Me.btnGpelis.UseVisualStyleBackColor = True
        '
        'btnGsocios
        '
        Me.btnGsocios.Font = New System.Drawing.Font("Lucida Bright", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGsocios.Location = New System.Drawing.Point(494, 254)
        Me.btnGsocios.Name = "btnGsocios"
        Me.btnGsocios.Size = New System.Drawing.Size(124, 61)
        Me.btnGsocios.TabIndex = 5
        Me.btnGsocios.Text = "Iniciar"
        Me.btnGsocios.UseVisualStyleBackColor = True
        '
        'lblGsocios
        '
        Me.lblGsocios.AutoSize = True
        Me.lblGsocios.BackColor = System.Drawing.Color.Transparent
        Me.lblGsocios.Font = New System.Drawing.Font("Lucida Bright", 24.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblGsocios.Location = New System.Drawing.Point(387, 186)
        Me.lblGsocios.Name = "lblGsocios"
        Me.lblGsocios.Size = New System.Drawing.Size(291, 37)
        Me.lblGsocios.TabIndex = 4
        Me.lblGsocios.Text = "Gestionar socios"
        '
        'btnGalquileres
        '
        Me.btnGalquileres.Font = New System.Drawing.Font("Lucida Bright", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGalquileres.Location = New System.Drawing.Point(863, 254)
        Me.btnGalquileres.Name = "btnGalquileres"
        Me.btnGalquileres.Size = New System.Drawing.Size(124, 61)
        Me.btnGalquileres.TabIndex = 7
        Me.btnGalquileres.Text = "Iniciar"
        Me.btnGalquileres.UseVisualStyleBackColor = True
        '
        'lblGalquileres
        '
        Me.lblGalquileres.AutoSize = True
        Me.lblGalquileres.BackColor = System.Drawing.Color.Transparent
        Me.lblGalquileres.Font = New System.Drawing.Font("Lucida Bright", 24.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblGalquileres.Location = New System.Drawing.Point(756, 186)
        Me.lblGalquileres.Name = "lblGalquileres"
        Me.lblGalquileres.Size = New System.Drawing.Size(352, 37)
        Me.lblGalquileres.TabIndex = 6
        Me.lblGalquileres.Text = "Gestionar alquileres"
        '
        'btnSalir
        '
        Me.btnSalir.Font = New System.Drawing.Font("Lucida Bright", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSalir.Location = New System.Drawing.Point(863, 438)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(124, 61)
        Me.btnSalir.TabIndex = 8
        Me.btnSalir.Text = "Salir"
        Me.btnSalir.UseVisualStyleBackColor = True
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.Color.Transparent
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.OpcionesToolStripMenuItem, Me.InformaciónToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1104, 24)
        Me.MenuStrip1.TabIndex = 9
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'OpcionesToolStripMenuItem
        '
        Me.OpcionesToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.GestionarPeliculasToolStripMenuItem, Me.GestionarSociosToolStripMenuItem, Me.GestionarAlquileresToolStripMenuItem, Me.SalirToolStripMenuItem})
        Me.OpcionesToolStripMenuItem.Name = "OpcionesToolStripMenuItem"
        Me.OpcionesToolStripMenuItem.Size = New System.Drawing.Size(50, 20)
        Me.OpcionesToolStripMenuItem.Text = "Menú"
        '
        'GestionarPeliculasToolStripMenuItem
        '
        Me.GestionarPeliculasToolStripMenuItem.Name = "GestionarPeliculasToolStripMenuItem"
        Me.GestionarPeliculasToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.GestionarPeliculasToolStripMenuItem.Text = "Gestionar Películas"
        '
        'GestionarSociosToolStripMenuItem
        '
        Me.GestionarSociosToolStripMenuItem.Name = "GestionarSociosToolStripMenuItem"
        Me.GestionarSociosToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.GestionarSociosToolStripMenuItem.Text = "Gestionar Socios"
        '
        'GestionarAlquileresToolStripMenuItem
        '
        Me.GestionarAlquileresToolStripMenuItem.Name = "GestionarAlquileresToolStripMenuItem"
        Me.GestionarAlquileresToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.GestionarAlquileresToolStripMenuItem.Text = "Gestionar Alquileres"
        '
        'SalirToolStripMenuItem
        '
        Me.SalirToolStripMenuItem.Name = "SalirToolStripMenuItem"
        Me.SalirToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.SalirToolStripMenuItem.Text = "Salir"
        '
        'InformaciónToolStripMenuItem
        '
        Me.InformaciónToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.GestiónDeVideoClubV0001ToolStripMenuItem})
        Me.InformaciónToolStripMenuItem.Name = "InformaciónToolStripMenuItem"
        Me.InformaciónToolStripMenuItem.Size = New System.Drawing.Size(84, 20)
        Me.InformaciónToolStripMenuItem.Text = "Información"
        '
        'GestiónDeVideoClubV0001ToolStripMenuItem
        '
        Me.GestiónDeVideoClubV0001ToolStripMenuItem.Name = "GestiónDeVideoClubV0001ToolStripMenuItem"
        Me.GestiónDeVideoClubV0001ToolStripMenuItem.Size = New System.Drawing.Size(230, 22)
        Me.GestiónDeVideoClubV0001ToolStripMenuItem.Text = "Gestión de VideoClub v.0.0.01"
        '
        'Inicio
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Video_Club.My.Resources.Resources.background
        Me.ClientSize = New System.Drawing.Size(1104, 561)
        Me.Controls.Add(Me.btnSalir)
        Me.Controls.Add(Me.btnGalquileres)
        Me.Controls.Add(Me.lblGalquileres)
        Me.Controls.Add(Me.btnGsocios)
        Me.Controls.Add(Me.lblGsocios)
        Me.Controls.Add(Me.btnGpelis)
        Me.Controls.Add(Me.lblGpelis)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.MaximizeBox = False
        Me.Name = "Inicio"
        Me.Text = "INICIO"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblGpelis As Label
    Friend WithEvents btnGpelis As Button
    Friend WithEvents btnGsocios As Button
    Friend WithEvents lblGsocios As Label
    Friend WithEvents btnGalquileres As Button
    Friend WithEvents lblGalquileres As Label
    Friend WithEvents btnSalir As Button
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents OpcionesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents GestionarPeliculasToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents GestionarSociosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents GestionarAlquileresToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents InformaciónToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents GestiónDeVideoClubV0001ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SalirToolStripMenuItem As ToolStripMenuItem
End Class
