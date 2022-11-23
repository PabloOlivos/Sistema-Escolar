<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmEditarDatosProfesor
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmEditarDatosProfesor))
        Me.btnEditarMisDatos = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.txtcargouser = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtcorreouser = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtapellidouser = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtnombreuser = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtdniuser = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtcontraseña = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txtUsername = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnEditarMisDatos
        '
        Me.btnEditarMisDatos.BackColor = System.Drawing.Color.DodgerBlue
        Me.btnEditarMisDatos.FlatAppearance.BorderSize = 0
        Me.btnEditarMisDatos.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEditarMisDatos.Font = New System.Drawing.Font("Graphik Bold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEditarMisDatos.ForeColor = System.Drawing.Color.White
        Me.btnEditarMisDatos.Location = New System.Drawing.Point(40, 354)
        Me.btnEditarMisDatos.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btnEditarMisDatos.Name = "btnEditarMisDatos"
        Me.btnEditarMisDatos.Size = New System.Drawing.Size(277, 47)
        Me.btnEditarMisDatos.TabIndex = 18
        Me.btnEditarMisDatos.Text = "Editar Mis datos"
        Me.btnEditarMisDatos.UseVisualStyleBackColor = False
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(355, 25)
        Me.DataGridView1.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowTemplate.Height = 24
        Me.DataGridView1.Size = New System.Drawing.Size(506, 376)
        Me.DataGridView1.TabIndex = 65
        '
        'txtcargouser
        '
        Me.txtcargouser.Font = New System.Drawing.Font("Graphik Bold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtcargouser.Location = New System.Drawing.Point(178, 301)
        Me.txtcargouser.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtcargouser.Name = "txtcargouser"
        Me.txtcargouser.ReadOnly = True
        Me.txtcargouser.Size = New System.Drawing.Size(139, 25)
        Me.txtcargouser.TabIndex = 82
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Graphik Bold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(57, 301)
        Me.Label6.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(98, 22)
        Me.Label6.TabIndex = 81
        Me.Label6.Text = "Cargo User"
        '
        'txtcorreouser
        '
        Me.txtcorreouser.Font = New System.Drawing.Font("Graphik Bold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtcorreouser.Location = New System.Drawing.Point(178, 257)
        Me.txtcorreouser.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtcorreouser.Name = "txtcorreouser"
        Me.txtcorreouser.Size = New System.Drawing.Size(139, 25)
        Me.txtcorreouser.TabIndex = 80
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Graphik Bold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.White
        Me.Label7.Location = New System.Drawing.Point(47, 260)
        Me.Label7.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(106, 22)
        Me.Label7.TabIndex = 79
        Me.Label7.Text = "Correo User"
        '
        'txtapellidouser
        '
        Me.txtapellidouser.Font = New System.Drawing.Font("Graphik Bold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtapellidouser.Location = New System.Drawing.Point(178, 216)
        Me.txtapellidouser.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtapellidouser.Name = "txtapellidouser"
        Me.txtapellidouser.Size = New System.Drawing.Size(139, 25)
        Me.txtapellidouser.TabIndex = 78
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Graphik Bold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.White
        Me.Label8.Location = New System.Drawing.Point(36, 219)
        Me.Label8.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(117, 22)
        Me.Label8.TabIndex = 77
        Me.Label8.Text = "Apellido User"
        '
        'txtnombreuser
        '
        Me.txtnombreuser.Font = New System.Drawing.Font("Graphik Bold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtnombreuser.Location = New System.Drawing.Point(178, 174)
        Me.txtnombreuser.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtnombreuser.Name = "txtnombreuser"
        Me.txtnombreuser.Size = New System.Drawing.Size(139, 25)
        Me.txtnombreuser.TabIndex = 76
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Graphik Bold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.White
        Me.Label9.Location = New System.Drawing.Point(41, 174)
        Me.Label9.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(114, 22)
        Me.Label9.TabIndex = 75
        Me.Label9.Text = "Nombre User"
        '
        'txtdniuser
        '
        Me.txtdniuser.Font = New System.Drawing.Font("Graphik Bold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtdniuser.Location = New System.Drawing.Point(178, 131)
        Me.txtdniuser.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtdniuser.Name = "txtdniuser"
        Me.txtdniuser.ReadOnly = True
        Me.txtdniuser.Size = New System.Drawing.Size(139, 25)
        Me.txtdniuser.TabIndex = 74
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Graphik Bold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.White
        Me.Label10.Location = New System.Drawing.Point(1, 134)
        Me.Label10.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(154, 22)
        Me.Label10.TabIndex = 73
        Me.Label10.Text = "Número de cuenta"
        '
        'txtcontraseña
        '
        Me.txtcontraseña.Font = New System.Drawing.Font("Graphik Bold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtcontraseña.Location = New System.Drawing.Point(178, 88)
        Me.txtcontraseña.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtcontraseña.Name = "txtcontraseña"
        Me.txtcontraseña.Size = New System.Drawing.Size(139, 25)
        Me.txtcontraseña.TabIndex = 72
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Graphik Bold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.White
        Me.Label11.Location = New System.Drawing.Point(54, 91)
        Me.Label11.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(101, 22)
        Me.Label11.TabIndex = 71
        Me.Label11.Text = "Contraseña"
        '
        'txtUsername
        '
        Me.txtUsername.Font = New System.Drawing.Font("Graphik Bold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtUsername.Location = New System.Drawing.Point(178, 46)
        Me.txtUsername.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtUsername.Name = "txtUsername"
        Me.txtUsername.ReadOnly = True
        Me.txtUsername.Size = New System.Drawing.Size(139, 25)
        Me.txtUsername.TabIndex = 70
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Graphik Bold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.White
        Me.Label12.Location = New System.Drawing.Point(64, 49)
        Me.Label12.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(91, 22)
        Me.Label12.TabIndex = 69
        Me.Label12.Text = "Username"
        '
        'frmEditarDatosProfesor
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(90, Byte), Integer), CType(CType(110, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(872, 442)
        Me.Controls.Add(Me.txtcargouser)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txtcorreouser)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.txtapellidouser)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.txtnombreuser)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.txtdniuser)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.txtcontraseña)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.txtUsername)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.btnEditarMisDatos)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Name = "frmEditarDatosProfesor"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmEditarDatosProfesor"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnEditarMisDatos As System.Windows.Forms.Button
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents txtcargouser As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtcorreouser As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtapellidouser As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txtnombreuser As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents txtdniuser As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents txtcontraseña As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents txtUsername As System.Windows.Forms.TextBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
End Class
