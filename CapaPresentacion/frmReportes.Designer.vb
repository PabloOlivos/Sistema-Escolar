<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmReportes
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmReportes))
        Me.btnReporteProfesor = New System.Windows.Forms.Button()
        Me.btnReporteAlumno = New System.Windows.Forms.Button()
        Me.btnReporteNota = New System.Windows.Forms.Button()
        Me.lblHora = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnReporteProfesor
        '
        Me.btnReporteProfesor.BackColor = System.Drawing.Color.DodgerBlue
        Me.btnReporteProfesor.FlatAppearance.BorderSize = 0
        Me.btnReporteProfesor.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnReporteProfesor.Font = New System.Drawing.Font("Graphik Black", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnReporteProfesor.ForeColor = System.Drawing.Color.White
        Me.btnReporteProfesor.Location = New System.Drawing.Point(41, 107)
        Me.btnReporteProfesor.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btnReporteProfesor.Name = "btnReporteProfesor"
        Me.btnReporteProfesor.Size = New System.Drawing.Size(256, 47)
        Me.btnReporteProfesor.TabIndex = 16
        Me.btnReporteProfesor.Text = "Reportes de Profesor"
        Me.btnReporteProfesor.UseVisualStyleBackColor = False
        '
        'btnReporteAlumno
        '
        Me.btnReporteAlumno.BackColor = System.Drawing.Color.DodgerBlue
        Me.btnReporteAlumno.FlatAppearance.BorderSize = 0
        Me.btnReporteAlumno.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnReporteAlumno.Font = New System.Drawing.Font("Graphik Black", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnReporteAlumno.ForeColor = System.Drawing.Color.White
        Me.btnReporteAlumno.Location = New System.Drawing.Point(41, 210)
        Me.btnReporteAlumno.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btnReporteAlumno.Name = "btnReporteAlumno"
        Me.btnReporteAlumno.Size = New System.Drawing.Size(256, 47)
        Me.btnReporteAlumno.TabIndex = 17
        Me.btnReporteAlumno.Text = "Reportes de Alumnos"
        Me.btnReporteAlumno.UseVisualStyleBackColor = False
        '
        'btnReporteNota
        '
        Me.btnReporteNota.BackColor = System.Drawing.Color.DodgerBlue
        Me.btnReporteNota.FlatAppearance.BorderSize = 0
        Me.btnReporteNota.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnReporteNota.Font = New System.Drawing.Font("Graphik Black", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnReporteNota.ForeColor = System.Drawing.Color.White
        Me.btnReporteNota.Location = New System.Drawing.Point(41, 310)
        Me.btnReporteNota.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btnReporteNota.Name = "btnReporteNota"
        Me.btnReporteNota.Size = New System.Drawing.Size(256, 47)
        Me.btnReporteNota.TabIndex = 18
        Me.btnReporteNota.Text = "Reportes de Notas"
        Me.btnReporteNota.UseVisualStyleBackColor = False
        '
        'lblHora
        '
        Me.lblHora.AutoSize = True
        Me.lblHora.Font = New System.Drawing.Font("Kabel Bd", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHora.ForeColor = System.Drawing.Color.White
        Me.lblHora.Location = New System.Drawing.Point(69, 35)
        Me.lblHora.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblHora.Name = "lblHora"
        Me.lblHora.Size = New System.Drawing.Size(228, 44)
        Me.lblHora.TabIndex = 19
        Me.lblHora.Text = "REPORTES "
        '
        'frmReportes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(90, Byte), Integer), CType(CType(110, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(357, 444)
        Me.Controls.Add(Me.lblHora)
        Me.Controls.Add(Me.btnReporteNota)
        Me.Controls.Add(Me.btnReporteAlumno)
        Me.Controls.Add(Me.btnReporteProfesor)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Name = "frmReportes"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmReportes"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnReporteProfesor As System.Windows.Forms.Button
    Friend WithEvents btnReporteAlumno As System.Windows.Forms.Button
    Friend WithEvents btnReporteNota As System.Windows.Forms.Button
    Friend WithEvents lblHora As System.Windows.Forms.Label
End Class
