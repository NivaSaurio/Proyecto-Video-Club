<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class GestionSocios
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(GestionSocios))
        Me.msGestion = New System.Windows.Forms.MenuStrip()
        Me.MenuToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AnadirToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EditarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EliminarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SalirToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.InformacionToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GestionDeVideoClubV09ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.btnListado = New System.Windows.Forms.Button()
        Me.btnBuscar = New System.Windows.Forms.Button()
        Me.lblEmail = New System.Windows.Forms.Label()
        Me.tbDireccion = New System.Windows.Forms.TextBox()
        Me.lblDireccion = New System.Windows.Forms.Label()
        Me.tbTfn = New System.Windows.Forms.TextBox()
        Me.lblTfn = New System.Windows.Forms.Label()
        Me.tbNombre = New System.Windows.Forms.TextBox()
        Me.lblNombre = New System.Windows.Forms.Label()
        Me.tbID = New System.Windows.Forms.TextBox()
        Me.lblID = New System.Windows.Forms.Label()
        Me.btnEditar = New System.Windows.Forms.Button()
        Me.btnAnadir = New System.Windows.Forms.Button()
        Me.tbEmail = New System.Windows.Forms.TextBox()
        Me.btnVolver = New System.Windows.Forms.Button()
        Me.btnEliminar = New System.Windows.Forms.Button()
        Me.msGestion.SuspendLayout()
        Me.SuspendLayout()
        '
        'msGestion
        '
        Me.msGestion.BackColor = System.Drawing.Color.Transparent
        Me.msGestion.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MenuToolStripMenuItem, Me.InformacionToolStripMenuItem})
        Me.msGestion.Location = New System.Drawing.Point(0, 0)
        Me.msGestion.Name = "msGestion"
        Me.msGestion.Size = New System.Drawing.Size(1104, 24)
        Me.msGestion.TabIndex = 18
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
        Me.AnadirToolStripMenuItem.Size = New System.Drawing.Size(149, 22)
        Me.AnadirToolStripMenuItem.Text = "Añadir Socio"
        '
        'EditarToolStripMenuItem
        '
        Me.EditarToolStripMenuItem.Name = "EditarToolStripMenuItem"
        Me.EditarToolStripMenuItem.Size = New System.Drawing.Size(149, 22)
        Me.EditarToolStripMenuItem.Text = "Editar Socio"
        '
        'EliminarToolStripMenuItem
        '
        Me.EliminarToolStripMenuItem.Name = "EliminarToolStripMenuItem"
        Me.EliminarToolStripMenuItem.Size = New System.Drawing.Size(149, 22)
        Me.EliminarToolStripMenuItem.Text = "Eliminar Socio"
        '
        'SalirToolStripMenuItem
        '
        Me.SalirToolStripMenuItem.Name = "SalirToolStripMenuItem"
        Me.SalirToolStripMenuItem.Size = New System.Drawing.Size(149, 22)
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
        'btnListado
        '
        Me.btnListado.Font = New System.Drawing.Font("Lucida Bright", 15.0!, System.Drawing.FontStyle.Bold)
        Me.btnListado.Location = New System.Drawing.Point(885, 334)
        Me.btnListado.Name = "btnListado"
        Me.btnListado.Size = New System.Drawing.Size(138, 53)
        Me.btnListado.TabIndex = 36
        Me.btnListado.Text = "Ver Lista"
        Me.btnListado.UseVisualStyleBackColor = True
        '
        'btnBuscar
        '
        Me.btnBuscar.Font = New System.Drawing.Font("Lucida Bright", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBuscar.Location = New System.Drawing.Point(342, 62)
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.Size = New System.Drawing.Size(98, 23)
        Me.btnBuscar.TabIndex = 35
        Me.btnBuscar.Text = "Buscar"
        Me.btnBuscar.UseVisualStyleBackColor = True
        '
        'lblEmail
        '
        Me.lblEmail.AutoSize = True
        Me.lblEmail.BackColor = System.Drawing.Color.Transparent
        Me.lblEmail.Font = New System.Drawing.Font("Lucida Bright", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEmail.Location = New System.Drawing.Point(556, 188)
        Me.lblEmail.Name = "lblEmail"
        Me.lblEmail.Size = New System.Drawing.Size(65, 23)
        Me.lblEmail.TabIndex = 33
        Me.lblEmail.Text = "Email"
        '
        'tbDireccion
        '
        Me.tbDireccion.Location = New System.Drawing.Point(669, 131)
        Me.tbDireccion.Name = "tbDireccion"
        Me.tbDireccion.Size = New System.Drawing.Size(282, 20)
        Me.tbDireccion.TabIndex = 32
        '
        'lblDireccion
        '
        Me.lblDireccion.AutoSize = True
        Me.lblDireccion.BackColor = System.Drawing.Color.Transparent
        Me.lblDireccion.Font = New System.Drawing.Font("Lucida Bright", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDireccion.Location = New System.Drawing.Point(556, 126)
        Me.lblDireccion.Name = "lblDireccion"
        Me.lblDireccion.Size = New System.Drawing.Size(107, 23)
        Me.lblDireccion.TabIndex = 31
        Me.lblDireccion.Text = "Dirección"
        '
        'tbTfn
        '
        Me.tbTfn.Location = New System.Drawing.Point(247, 193)
        Me.tbTfn.Name = "tbTfn"
        Me.tbTfn.Size = New System.Drawing.Size(282, 20)
        Me.tbTfn.TabIndex = 28
        '
        'lblTfn
        '
        Me.lblTfn.AutoSize = True
        Me.lblTfn.BackColor = System.Drawing.Color.Transparent
        Me.lblTfn.Font = New System.Drawing.Font("Lucida Bright", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTfn.Location = New System.Drawing.Point(44, 188)
        Me.lblTfn.Name = "lblTfn"
        Me.lblTfn.Size = New System.Drawing.Size(155, 23)
        Me.lblTfn.TabIndex = 27
        Me.lblTfn.Text = "Num Teléfono"
        '
        'tbNombre
        '
        Me.tbNombre.Location = New System.Drawing.Point(247, 129)
        Me.tbNombre.Name = "tbNombre"
        Me.tbNombre.Size = New System.Drawing.Size(282, 20)
        Me.tbNombre.TabIndex = 26
        '
        'lblNombre
        '
        Me.lblNombre.AutoSize = True
        Me.lblNombre.BackColor = System.Drawing.Color.Transparent
        Me.lblNombre.Font = New System.Drawing.Font("Lucida Bright", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNombre.Location = New System.Drawing.Point(44, 126)
        Me.lblNombre.Name = "lblNombre"
        Me.lblNombre.Size = New System.Drawing.Size(197, 23)
        Me.lblNombre.TabIndex = 25
        Me.lblNombre.Text = "Nombre Completo"
        '
        'tbID
        '
        Me.tbID.Location = New System.Drawing.Point(236, 65)
        Me.tbID.Name = "tbID"
        Me.tbID.Size = New System.Drawing.Size(100, 20)
        Me.tbID.TabIndex = 24
        '
        'lblID
        '
        Me.lblID.AutoSize = True
        Me.lblID.BackColor = System.Drawing.Color.Transparent
        Me.lblID.Font = New System.Drawing.Font("Lucida Bright", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblID.Location = New System.Drawing.Point(44, 62)
        Me.lblID.Name = "lblID"
        Me.lblID.Size = New System.Drawing.Size(33, 23)
        Me.lblID.TabIndex = 23
        Me.lblID.Text = "ID"
        '
        'btnEditar
        '
        Me.btnEditar.Font = New System.Drawing.Font("Lucida Bright", 15.0!, System.Drawing.FontStyle.Bold)
        Me.btnEditar.Location = New System.Drawing.Point(357, 334)
        Me.btnEditar.Name = "btnEditar"
        Me.btnEditar.Size = New System.Drawing.Size(138, 53)
        Me.btnEditar.TabIndex = 21
        Me.btnEditar.Text = "Editar"
        Me.btnEditar.UseVisualStyleBackColor = True
        '
        'btnAnadir
        '
        Me.btnAnadir.Font = New System.Drawing.Font("Lucida Bright", 15.0!, System.Drawing.FontStyle.Bold)
        Me.btnAnadir.Location = New System.Drawing.Point(48, 334)
        Me.btnAnadir.Name = "btnAnadir"
        Me.btnAnadir.Size = New System.Drawing.Size(138, 53)
        Me.btnAnadir.TabIndex = 20
        Me.btnAnadir.Text = "Añadir"
        Me.btnAnadir.UseVisualStyleBackColor = True
        '
        'tbEmail
        '
        Me.tbEmail.Location = New System.Drawing.Point(669, 195)
        Me.tbEmail.Name = "tbEmail"
        Me.tbEmail.Size = New System.Drawing.Size(282, 20)
        Me.tbEmail.TabIndex = 39
        '
        'btnVolver
        '
        Me.btnVolver.Font = New System.Drawing.Font("Lucida Bright", 15.0!, System.Drawing.FontStyle.Bold)
        Me.btnVolver.Location = New System.Drawing.Point(494, 462)
        Me.btnVolver.Name = "btnVolver"
        Me.btnVolver.Size = New System.Drawing.Size(138, 53)
        Me.btnVolver.TabIndex = 40
        Me.btnVolver.Text = "Volver"
        Me.btnVolver.UseVisualStyleBackColor = True
        '
        'btnEliminar
        '
        Me.btnEliminar.Font = New System.Drawing.Font("Lucida Bright", 15.0!, System.Drawing.FontStyle.Bold)
        Me.btnEliminar.Location = New System.Drawing.Point(630, 334)
        Me.btnEliminar.Name = "btnEliminar"
        Me.btnEliminar.Size = New System.Drawing.Size(138, 53)
        Me.btnEliminar.TabIndex = 22
        Me.btnEliminar.Text = "Eliminar"
        Me.btnEliminar.UseVisualStyleBackColor = True
        '
        'GestionSocios
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Video_Club.My.Resources.Resources.background
        Me.ClientSize = New System.Drawing.Size(1104, 561)
        Me.Controls.Add(Me.btnVolver)
        Me.Controls.Add(Me.tbEmail)
        Me.Controls.Add(Me.btnListado)
        Me.Controls.Add(Me.btnBuscar)
        Me.Controls.Add(Me.lblEmail)
        Me.Controls.Add(Me.tbDireccion)
        Me.Controls.Add(Me.lblDireccion)
        Me.Controls.Add(Me.tbTfn)
        Me.Controls.Add(Me.lblTfn)
        Me.Controls.Add(Me.tbNombre)
        Me.Controls.Add(Me.lblNombre)
        Me.Controls.Add(Me.tbID)
        Me.Controls.Add(Me.lblID)
        Me.Controls.Add(Me.btnEliminar)
        Me.Controls.Add(Me.btnEditar)
        Me.Controls.Add(Me.btnAnadir)
        Me.Controls.Add(Me.msGestion)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "GestionSocios"
        Me.Text = "Gestion de socios"
        Me.msGestion.ResumeLayout(False)
        Me.msGestion.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents msGestion As MenuStrip
    Friend WithEvents MenuToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AnadirToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EditarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EliminarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SalirToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents InformacionToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents GestionDeVideoClubV09ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents btnListado As Button
    Friend WithEvents btnBuscar As Button
    Friend WithEvents lblEmail As Label
    Friend WithEvents tbDireccion As TextBox
    Friend WithEvents lblDireccion As Label
    Friend WithEvents tbTfn As TextBox
    Friend WithEvents lblTfn As Label
    Friend WithEvents tbNombre As TextBox
    Friend WithEvents lblNombre As Label
    Friend WithEvents tbID As TextBox
    Friend WithEvents lblID As Label
    Friend WithEvents btnEditar As Button
    Friend WithEvents btnAnadir As Button
    Friend WithEvents tbEmail As TextBox
    Friend WithEvents btnVolver As Button
    Friend WithEvents btnEliminar As Button
End Class
