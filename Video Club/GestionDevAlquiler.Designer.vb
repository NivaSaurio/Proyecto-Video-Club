<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class GestionDevAlquiler
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(GestionDevAlquiler))
        Me.dtDev = New System.Windows.Forms.DateTimePicker()
        Me.dtAlq = New System.Windows.Forms.DateTimePicker()
        Me.cbSocio = New System.Windows.Forms.ComboBox()
        Me.lblFdev = New System.Windows.Forms.Label()
        Me.lblFalq = New System.Windows.Forms.Label()
        Me.lblTitulo = New System.Windows.Forms.Label()
        Me.lblSocio = New System.Windows.Forms.Label()
        Me.btnGuardar = New System.Windows.Forms.Button()
        Me.btnVolver = New System.Windows.Forms.Button()
        Me.cbTitulo = New System.Windows.Forms.ComboBox()
        Me.dtPDev = New System.Windows.Forms.DateTimePicker()
        Me.lvlPDev = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'dtDev
        '
        Me.dtDev.Location = New System.Drawing.Point(780, 207)
        Me.dtDev.Name = "dtDev"
        Me.dtDev.Size = New System.Drawing.Size(200, 20)
        Me.dtDev.TabIndex = 71
        '
        'dtAlq
        '
        Me.dtAlq.Location = New System.Drawing.Point(780, 148)
        Me.dtAlq.Name = "dtAlq"
        Me.dtAlq.Size = New System.Drawing.Size(200, 20)
        Me.dtAlq.TabIndex = 70
        '
        'cbSocio
        '
        Me.cbSocio.FormattingEnabled = True
        Me.cbSocio.Location = New System.Drawing.Point(288, 146)
        Me.cbSocio.Name = "cbSocio"
        Me.cbSocio.Size = New System.Drawing.Size(225, 21)
        Me.cbSocio.TabIndex = 68
        '
        'lblFdev
        '
        Me.lblFdev.AutoSize = True
        Me.lblFdev.BackColor = System.Drawing.Color.Transparent
        Me.lblFdev.Font = New System.Drawing.Font("Lucida Bright", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFdev.Location = New System.Drawing.Point(547, 206)
        Me.lblFdev.Name = "lblFdev"
        Me.lblFdev.Size = New System.Drawing.Size(221, 23)
        Me.lblFdev.TabIndex = 66
        Me.lblFdev.Text = "Fecha de devolución"
        '
        'lblFalq
        '
        Me.lblFalq.AutoSize = True
        Me.lblFalq.BackColor = System.Drawing.Color.Transparent
        Me.lblFalq.Font = New System.Drawing.Font("Lucida Bright", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFalq.Location = New System.Drawing.Point(547, 144)
        Me.lblFalq.Name = "lblFalq"
        Me.lblFalq.Size = New System.Drawing.Size(183, 23)
        Me.lblFalq.TabIndex = 65
        Me.lblFalq.Text = "Fecha de alquiler"
        '
        'lblTitulo
        '
        Me.lblTitulo.AutoSize = True
        Me.lblTitulo.BackColor = System.Drawing.Color.Transparent
        Me.lblTitulo.Font = New System.Drawing.Font("Lucida Bright", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitulo.Location = New System.Drawing.Point(63, 208)
        Me.lblTitulo.Name = "lblTitulo"
        Me.lblTitulo.Size = New System.Drawing.Size(153, 23)
        Me.lblTitulo.TabIndex = 64
        Me.lblTitulo.Text = "Título película"
        '
        'lblSocio
        '
        Me.lblSocio.AutoSize = True
        Me.lblSocio.BackColor = System.Drawing.Color.Transparent
        Me.lblSocio.Font = New System.Drawing.Font("Lucida Bright", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSocio.Location = New System.Drawing.Point(63, 146)
        Me.lblSocio.Name = "lblSocio"
        Me.lblSocio.Size = New System.Drawing.Size(177, 23)
        Me.lblSocio.TabIndex = 63
        Me.lblSocio.Text = "Selecciona socio"
        '
        'btnGuardar
        '
        Me.btnGuardar.Font = New System.Drawing.Font("Lucida Bright", 15.0!, System.Drawing.FontStyle.Bold)
        Me.btnGuardar.Location = New System.Drawing.Point(856, 336)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(138, 67)
        Me.btnGuardar.TabIndex = 61
        Me.btnGuardar.Text = "Guardar Devolución"
        Me.btnGuardar.UseVisualStyleBackColor = True
        '
        'btnVolver
        '
        Me.btnVolver.Font = New System.Drawing.Font("Lucida Bright", 15.0!, System.Drawing.FontStyle.Bold)
        Me.btnVolver.Location = New System.Drawing.Point(547, 336)
        Me.btnVolver.Name = "btnVolver"
        Me.btnVolver.Size = New System.Drawing.Size(138, 67)
        Me.btnVolver.TabIndex = 60
        Me.btnVolver.Text = "Volver"
        Me.btnVolver.UseVisualStyleBackColor = True
        '
        'cbTitulo
        '
        Me.cbTitulo.FormattingEnabled = True
        Me.cbTitulo.Location = New System.Drawing.Point(288, 210)
        Me.cbTitulo.Name = "cbTitulo"
        Me.cbTitulo.Size = New System.Drawing.Size(225, 21)
        Me.cbTitulo.TabIndex = 72
        '
        'dtPDev
        '
        Me.dtPDev.Location = New System.Drawing.Point(780, 271)
        Me.dtPDev.Name = "dtPDev"
        Me.dtPDev.Size = New System.Drawing.Size(200, 20)
        Me.dtPDev.TabIndex = 74
        '
        'lvlPDev
        '
        Me.lvlPDev.AutoSize = True
        Me.lvlPDev.BackColor = System.Drawing.Color.Transparent
        Me.lvlPDev.Font = New System.Drawing.Font("Lucida Bright", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lvlPDev.Location = New System.Drawing.Point(547, 270)
        Me.lvlPDev.Name = "lvlPDev"
        Me.lvlPDev.Size = New System.Drawing.Size(163, 23)
        Me.lvlPDev.TabIndex = 73
        Me.lvlPDev.Text = "Fecha devuelta"
        '
        'GestionDevAlquiler
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Video_Club.My.Resources.Resources.background
        Me.ClientSize = New System.Drawing.Size(1104, 561)
        Me.Controls.Add(Me.dtPDev)
        Me.Controls.Add(Me.lvlPDev)
        Me.Controls.Add(Me.cbTitulo)
        Me.Controls.Add(Me.dtDev)
        Me.Controls.Add(Me.dtAlq)
        Me.Controls.Add(Me.cbSocio)
        Me.Controls.Add(Me.lblFdev)
        Me.Controls.Add(Me.lblFalq)
        Me.Controls.Add(Me.lblTitulo)
        Me.Controls.Add(Me.lblSocio)
        Me.Controls.Add(Me.btnGuardar)
        Me.Controls.Add(Me.btnVolver)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "GestionDevAlquiler"
        Me.Text = "Devolución de alquiler"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents dtDev As DateTimePicker
    Friend WithEvents dtAlq As DateTimePicker
    Friend WithEvents cbSocio As ComboBox
    Friend WithEvents lblFdev As Label
    Friend WithEvents lblFalq As Label
    Friend WithEvents lblTitulo As Label
    Friend WithEvents lblSocio As Label
    Friend WithEvents btnGuardar As Button
    Friend WithEvents btnVolver As Button
    Friend WithEvents cbTitulo As ComboBox
    Friend WithEvents dtPDev As DateTimePicker
    Friend WithEvents lvlPDev As Label
End Class
