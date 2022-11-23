<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmagregarSeccion
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmagregarSeccion))
        Me.txtvacantes = New System.Windows.Forms.TextBox()
        Me.label = New System.Windows.Forms.Label()
        Me.txtSeccion = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cmbGrado = New System.Windows.Forms.ComboBox()
        Me.cmbProfesor = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.rbtinicial = New System.Windows.Forms.RadioButton()
        Me.rbtprimaria = New System.Windows.Forms.RadioButton()
        Me.dgvSeccion = New System.Windows.Forms.DataGridView()
        Me.btnguardar = New System.Windows.Forms.Button()
        Me.cmbannoEscolar = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        CType(Me.dgvSeccion, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtvacantes
        '
        Me.txtvacantes.Font = New System.Drawing.Font("Graphik Bold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtvacantes.Location = New System.Drawing.Point(188, 286)
        Me.txtvacantes.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtvacantes.Name = "txtvacantes"
        Me.txtvacantes.Size = New System.Drawing.Size(139, 25)
        Me.txtvacantes.TabIndex = 39
        '
        'label
        '
        Me.label.AutoSize = True
        Me.label.Font = New System.Drawing.Font("Graphik Bold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label.ForeColor = System.Drawing.Color.White
        Me.label.Location = New System.Drawing.Point(64, 51)
        Me.label.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.label.Name = "label"
        Me.label.Size = New System.Drawing.Size(103, 22)
        Me.label.TabIndex = 38
        Me.label.Text = "Año Escolar"
        '
        'txtSeccion
        '
        Me.txtSeccion.Font = New System.Drawing.Font("Graphik Bold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSeccion.Location = New System.Drawing.Point(188, 87)
        Me.txtSeccion.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtSeccion.Name = "txtSeccion"
        Me.txtSeccion.Size = New System.Drawing.Size(139, 25)
        Me.txtSeccion.TabIndex = 37
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Graphik Bold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.White
        Me.Label10.Location = New System.Drawing.Point(27, 87)
        Me.Label10.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(140, 22)
        Me.Label10.TabIndex = 36
        Me.Label10.Text = "Nombre Seccion"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Graphik Bold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(89, 241)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(78, 22)
        Me.Label2.TabIndex = 33
        Me.Label2.Text = "Profesor"
        '
        'cmbGrado
        '
        Me.cmbGrado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbGrado.Font = New System.Drawing.Font("Graphik Bold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbGrado.FormattingEnabled = True
        Me.cmbGrado.Location = New System.Drawing.Point(188, 196)
        Me.cmbGrado.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.cmbGrado.Name = "cmbGrado"
        Me.cmbGrado.Size = New System.Drawing.Size(139, 30)
        Me.cmbGrado.TabIndex = 40
        '
        'cmbProfesor
        '
        Me.cmbProfesor.BackColor = System.Drawing.SystemColors.Window
        Me.cmbProfesor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbProfesor.Font = New System.Drawing.Font("Graphik Bold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbProfesor.FormattingEnabled = True
        Me.cmbProfesor.Location = New System.Drawing.Point(188, 241)
        Me.cmbProfesor.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.cmbProfesor.Name = "cmbProfesor"
        Me.cmbProfesor.Size = New System.Drawing.Size(139, 30)
        Me.cmbProfesor.TabIndex = 41
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Graphik Bold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(85, 286)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(82, 22)
        Me.Label3.TabIndex = 42
        Me.Label3.Text = "Vacantes"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Graphik Bold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(116, 136)
        Me.Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(51, 22)
        Me.Label4.TabIndex = 43
        Me.Label4.Text = "Nivel"
        '
        'rbtinicial
        '
        Me.rbtinicial.AutoSize = True
        Me.rbtinicial.Font = New System.Drawing.Font("Graphik Bold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbtinicial.Location = New System.Drawing.Point(188, 121)
        Me.rbtinicial.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.rbtinicial.Name = "rbtinicial"
        Me.rbtinicial.Size = New System.Drawing.Size(113, 26)
        Me.rbtinicial.TabIndex = 44
        Me.rbtinicial.TabStop = True
        Me.rbtinicial.Text = "Preescolar"
        Me.rbtinicial.UseVisualStyleBackColor = True
        '
        'rbtprimaria
        '
        Me.rbtprimaria.AutoSize = True
        Me.rbtprimaria.Font = New System.Drawing.Font("Graphik Bold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbtprimaria.Location = New System.Drawing.Point(188, 151)
        Me.rbtprimaria.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.rbtprimaria.Name = "rbtprimaria"
        Me.rbtprimaria.Size = New System.Drawing.Size(95, 26)
        Me.rbtprimaria.TabIndex = 45
        Me.rbtprimaria.TabStop = True
        Me.rbtprimaria.Text = "Primaria"
        Me.rbtprimaria.UseVisualStyleBackColor = True
        '
        'dgvSeccion
        '
        Me.dgvSeccion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvSeccion.Location = New System.Drawing.Point(373, 20)
        Me.dgvSeccion.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.dgvSeccion.Name = "dgvSeccion"
        Me.dgvSeccion.RowTemplate.Height = 24
        Me.dgvSeccion.Size = New System.Drawing.Size(439, 374)
        Me.dgvSeccion.TabIndex = 46
        '
        'btnguardar
        '
        Me.btnguardar.BackColor = System.Drawing.Color.DodgerBlue
        Me.btnguardar.Font = New System.Drawing.Font("Graphik Bold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnguardar.ForeColor = System.Drawing.Color.White
        Me.btnguardar.Location = New System.Drawing.Point(58, 329)
        Me.btnguardar.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btnguardar.Name = "btnguardar"
        Me.btnguardar.Size = New System.Drawing.Size(281, 42)
        Me.btnguardar.TabIndex = 47
        Me.btnguardar.Text = "GUARDAR"
        Me.btnguardar.UseVisualStyleBackColor = False
        '
        'cmbannoEscolar
        '
        Me.cmbannoEscolar.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbannoEscolar.Font = New System.Drawing.Font("Graphik Bold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbannoEscolar.FormattingEnabled = True
        Me.cmbannoEscolar.Location = New System.Drawing.Point(188, 48)
        Me.cmbannoEscolar.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.cmbannoEscolar.Name = "cmbannoEscolar"
        Me.cmbannoEscolar.Size = New System.Drawing.Size(139, 30)
        Me.cmbannoEscolar.TabIndex = 48
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Graphik Bold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(108, 196)
        Me.Label5.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(59, 22)
        Me.Label5.TabIndex = 32
        Me.Label5.Text = "Grado"
        '
        'frmagregarSeccion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(90, Byte), Integer), CType(CType(110, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(835, 405)
        Me.Controls.Add(Me.cmbannoEscolar)
        Me.Controls.Add(Me.btnguardar)
        Me.Controls.Add(Me.dgvSeccion)
        Me.Controls.Add(Me.rbtprimaria)
        Me.Controls.Add(Me.rbtinicial)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.cmbProfesor)
        Me.Controls.Add(Me.cmbGrado)
        Me.Controls.Add(Me.txtvacantes)
        Me.Controls.Add(Me.label)
        Me.Controls.Add(Me.txtSeccion)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label5)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Name = "frmagregarSeccion"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmagregarSeccion"
        CType(Me.dgvSeccion, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtvacantes As System.Windows.Forms.TextBox
    Friend WithEvents label As System.Windows.Forms.Label
    Friend WithEvents txtSeccion As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents cmbGrado As System.Windows.Forms.ComboBox
    Friend WithEvents cmbProfesor As System.Windows.Forms.ComboBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents rbtinicial As System.Windows.Forms.RadioButton
    Friend WithEvents rbtprimaria As System.Windows.Forms.RadioButton
    Friend WithEvents dgvSeccion As System.Windows.Forms.DataGridView
    Friend WithEvents btnguardar As System.Windows.Forms.Button
    Friend WithEvents cmbannoEscolar As System.Windows.Forms.ComboBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
End Class
