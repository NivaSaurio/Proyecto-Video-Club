<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ListadoSocios
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ListadoSocios))
        Me.btnVolver = New System.Windows.Forms.Button()
        Me.lblTituloTabla = New System.Windows.Forms.Label()
        Me.lvSocios = New System.Windows.Forms.ListView()
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
        Me.lblTituloTabla.Size = New System.Drawing.Size(187, 23)
        Me.lblTituloTabla.TabIndex = 24
        Me.lblTituloTabla.Text = "Listado de socios"
        '
        'lvSocios
        '
        Me.lvSocios.HideSelection = False
        Me.lvSocios.Location = New System.Drawing.Point(12, 184)
        Me.lvSocios.Name = "lvSocios"
        Me.lvSocios.Size = New System.Drawing.Size(1080, 365)
        Me.lvSocios.TabIndex = 20
        Me.lvSocios.UseCompatibleStateImageBehavior = False
        '
        'ListadoSocios
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Video_Club.My.Resources.Resources.background
        Me.ClientSize = New System.Drawing.Size(1104, 561)
        Me.Controls.Add(Me.btnVolver)
        Me.Controls.Add(Me.lblTituloTabla)
        Me.Controls.Add(Me.lvSocios)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "ListadoSocios"
        Me.Text = "Listado de socios"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnVolver As Button
    Friend WithEvents lblTituloTabla As Label
    Friend WithEvents lvSocios As ListView
End Class
