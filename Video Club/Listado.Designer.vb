<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Listado
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Listado))
        Me.lvPeliculas = New System.Windows.Forms.ListView()
        Me.cbGenero = New System.Windows.Forms.ComboBox()
        Me.lblGenero = New System.Windows.Forms.Label()
        Me.btnBuscar = New System.Windows.Forms.Button()
        Me.lblTituloTabla = New System.Windows.Forms.Label()
        Me.btnVolver = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lvPeliculas
        '
        Me.lvPeliculas.HideSelection = False
        Me.lvPeliculas.Location = New System.Drawing.Point(12, 184)
        Me.lvPeliculas.Name = "lvPeliculas"
        Me.lvPeliculas.Size = New System.Drawing.Size(1080, 365)
        Me.lvPeliculas.TabIndex = 0
        Me.lvPeliculas.UseCompatibleStateImageBehavior = False
        '
        'cbGenero
        '
        Me.cbGenero.FormattingEnabled = True
        Me.cbGenero.Location = New System.Drawing.Point(217, 43)
        Me.cbGenero.Name = "cbGenero"
        Me.cbGenero.Size = New System.Drawing.Size(165, 21)
        Me.cbGenero.TabIndex = 16
        '
        'lblGenero
        '
        Me.lblGenero.AutoSize = True
        Me.lblGenero.BackColor = System.Drawing.Color.Transparent
        Me.lblGenero.Font = New System.Drawing.Font("Lucida Bright", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblGenero.Location = New System.Drawing.Point(12, 41)
        Me.lblGenero.Name = "lblGenero"
        Me.lblGenero.Size = New System.Drawing.Size(188, 23)
        Me.lblGenero.TabIndex = 15
        Me.lblGenero.Text = "Filtrar por género"
        '
        'btnBuscar
        '
        Me.btnBuscar.Font = New System.Drawing.Font("Lucida Bright", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBuscar.Location = New System.Drawing.Point(388, 41)
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.Size = New System.Drawing.Size(98, 23)
        Me.btnBuscar.TabIndex = 17
        Me.btnBuscar.Text = "Buscar"
        Me.btnBuscar.UseVisualStyleBackColor = True
        '
        'lblTituloTabla
        '
        Me.lblTituloTabla.AutoSize = True
        Me.lblTituloTabla.BackColor = System.Drawing.Color.Transparent
        Me.lblTituloTabla.Font = New System.Drawing.Font("Lucida Bright", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTituloTabla.Location = New System.Drawing.Point(439, 118)
        Me.lblTituloTabla.Name = "lblTituloTabla"
        Me.lblTituloTabla.Size = New System.Drawing.Size(211, 23)
        Me.lblTituloTabla.TabIndex = 18
        Me.lblTituloTabla.Text = "Listado de películas"
        '
        'btnVolver
        '
        Me.btnVolver.Font = New System.Drawing.Font("Lucida Bright", 15.0!, System.Drawing.FontStyle.Bold)
        Me.btnVolver.Location = New System.Drawing.Point(882, 26)
        Me.btnVolver.Name = "btnVolver"
        Me.btnVolver.Size = New System.Drawing.Size(138, 53)
        Me.btnVolver.TabIndex = 19
        Me.btnVolver.Text = "Volver"
        Me.btnVolver.UseVisualStyleBackColor = True
        '
        'Listado
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Video_Club.My.Resources.Resources.background
        Me.ClientSize = New System.Drawing.Size(1104, 561)
        Me.Controls.Add(Me.btnVolver)
        Me.Controls.Add(Me.lblTituloTabla)
        Me.Controls.Add(Me.btnBuscar)
        Me.Controls.Add(Me.cbGenero)
        Me.Controls.Add(Me.lblGenero)
        Me.Controls.Add(Me.lvPeliculas)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "Listado"
        Me.Text = "Listado de películas"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lvPeliculas As ListView
    Friend WithEvents cbGenero As ComboBox
    Friend WithEvents lblGenero As Label
    Friend WithEvents btnBuscar As Button
    Friend WithEvents lblTituloTabla As Label
    Friend WithEvents btnVolver As Button
End Class
