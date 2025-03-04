<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ListadoAlquileres
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ListadoAlquileres))
        Me.btnVolver = New System.Windows.Forms.Button()
        Me.lblTituloTabla = New System.Windows.Forms.Label()
        Me.btnBuscar = New System.Windows.Forms.Button()
        Me.cbFiltro = New System.Windows.Forms.ComboBox()
        Me.lblFiltro = New System.Windows.Forms.Label()
        Me.lvAlquileres = New System.Windows.Forms.ListView()
        Me.SuspendLayout()
        '
        'btnVolver
        '
        Me.btnVolver.Font = New System.Drawing.Font("Lucida Bright", 15.0!, System.Drawing.FontStyle.Bold)
        Me.btnVolver.Location = New System.Drawing.Point(882, 26)
        Me.btnVolver.Name = "btnVolver"
        Me.btnVolver.Size = New System.Drawing.Size(138, 53)
        Me.btnVolver.TabIndex = 25
        Me.btnVolver.Text = "Volver"
        Me.btnVolver.UseVisualStyleBackColor = True
        '
        'lblTituloTabla
        '
        Me.lblTituloTabla.AutoSize = True
        Me.lblTituloTabla.BackColor = System.Drawing.Color.Transparent
        Me.lblTituloTabla.Font = New System.Drawing.Font("Lucida Bright", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTituloTabla.Location = New System.Drawing.Point(439, 118)
        Me.lblTituloTabla.Name = "lblTituloTabla"
        Me.lblTituloTabla.Size = New System.Drawing.Size(211, 23)
        Me.lblTituloTabla.TabIndex = 24
        Me.lblTituloTabla.Text = "Listado de películas"
        '
        'btnBuscar
        '
        Me.btnBuscar.Font = New System.Drawing.Font("Lucida Bright", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBuscar.Location = New System.Drawing.Point(352, 41)
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.Size = New System.Drawing.Size(98, 23)
        Me.btnBuscar.TabIndex = 23
        Me.btnBuscar.Text = "Buscar"
        Me.btnBuscar.UseVisualStyleBackColor = True
        '
        'cbFiltro
        '
        Me.cbFiltro.FormattingEnabled = True
        Me.cbFiltro.Location = New System.Drawing.Point(181, 43)
        Me.cbFiltro.Name = "cbFiltro"
        Me.cbFiltro.Size = New System.Drawing.Size(165, 21)
        Me.cbFiltro.TabIndex = 22
        '
        'lblFiltro
        '
        Me.lblFiltro.AutoSize = True
        Me.lblFiltro.BackColor = System.Drawing.Color.Transparent
        Me.lblFiltro.Font = New System.Drawing.Font("Lucida Bright", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFiltro.Location = New System.Drawing.Point(12, 41)
        Me.lblFiltro.Name = "lblFiltro"
        Me.lblFiltro.Size = New System.Drawing.Size(152, 23)
        Me.lblFiltro.TabIndex = 21
        Me.lblFiltro.Text = "Filtrar alquiler"
        '
        'lvAlquileres
        '
        Me.lvAlquileres.HideSelection = False
        Me.lvAlquileres.Location = New System.Drawing.Point(12, 184)
        Me.lvAlquileres.Name = "lvAlquileres"
        Me.lvAlquileres.Size = New System.Drawing.Size(1080, 365)
        Me.lvAlquileres.TabIndex = 20
        Me.lvAlquileres.UseCompatibleStateImageBehavior = False
        Me.lvAlquileres.View = System.Windows.Forms.View.Details
        '
        'ListadoAlquileres
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Video_Club.My.Resources.Resources.background
        Me.ClientSize = New System.Drawing.Size(1104, 561)
        Me.Controls.Add(Me.btnVolver)
        Me.Controls.Add(Me.lblTituloTabla)
        Me.Controls.Add(Me.btnBuscar)
        Me.Controls.Add(Me.cbFiltro)
        Me.Controls.Add(Me.lblFiltro)
        Me.Controls.Add(Me.lvAlquileres)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "ListadoAlquileres"
        Me.Text = "Listado de alquileres"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnVolver As Button
    Friend WithEvents lblTituloTabla As Label
    Friend WithEvents btnBuscar As Button
    Friend WithEvents cbFiltro As ComboBox
    Friend WithEvents lblFiltro As Label
    Friend WithEvents lvAlquileres As ListView
End Class
