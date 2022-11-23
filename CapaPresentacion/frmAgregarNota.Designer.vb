<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAgregarNota
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmAgregarNota))
        Me.cmbnota = New System.Windows.Forms.ComboBox()
        Me.cmbtrimestre = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtapellidoAlumno = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.btneditarNota = New System.Windows.Forms.Button()
        Me.btnagregarNota = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cmbcodigocurso = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.cmbCompetencia = New System.Windows.Forms.ComboBox()
        Me.rbtInicial = New System.Windows.Forms.RadioButton()
        Me.rbtprimaria = New System.Windows.Forms.RadioButton()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cmbannoEscolar = New System.Windows.Forms.ComboBox()
        Me.DataGridView2 = New System.Windows.Forms.DataGridView()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cmbnota
        '
        Me.cmbnota.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbnota.Font = New System.Drawing.Font("Graphik Bold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbnota.FormattingEnabled = True
        Me.cmbnota.Items.AddRange(New Object() {"A", "B", "C"})
        Me.cmbnota.Location = New System.Drawing.Point(40, 368)
        Me.cmbnota.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.cmbnota.Name = "cmbnota"
        Me.cmbnota.Size = New System.Drawing.Size(135, 30)
        Me.cmbnota.TabIndex = 70
        '
        'cmbtrimestre
        '
        Me.cmbtrimestre.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbtrimestre.Font = New System.Drawing.Font("Graphik Bold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbtrimestre.FormattingEnabled = True
        Me.cmbtrimestre.Location = New System.Drawing.Point(40, 186)
        Me.cmbtrimestre.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.cmbtrimestre.Name = "cmbtrimestre"
        Me.cmbtrimestre.Size = New System.Drawing.Size(140, 30)
        Me.cmbtrimestre.TabIndex = 69
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Graphik Bold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(37, 346)
        Me.Label6.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(56, 22)
        Me.Label6.TabIndex = 68
        Me.Label6.Text = "NOTA"
        '
        'txtapellidoAlumno
        '
        Me.txtapellidoAlumno.Font = New System.Drawing.Font("Graphik Bold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtapellidoAlumno.Location = New System.Drawing.Point(41, 73)
        Me.txtapellidoAlumno.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtapellidoAlumno.Name = "txtapellidoAlumno"
        Me.txtapellidoAlumno.Size = New System.Drawing.Size(139, 25)
        Me.txtapellidoAlumno.TabIndex = 67
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Graphik Bold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.White
        Me.Label10.Location = New System.Drawing.Point(41, 52)
        Me.Label10.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(167, 22)
        Me.Label10.TabIndex = 66
        Me.Label10.Text = "APELLIDO ALUMNO"
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(291, 176)
        Me.DataGridView1.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowTemplate.Height = 24
        Me.DataGridView1.Size = New System.Drawing.Size(537, 267)
        Me.DataGridView1.TabIndex = 65
        '
        'btneditarNota
        '
        Me.btneditarNota.BackColor = System.Drawing.Color.DodgerBlue
        Me.btneditarNota.Font = New System.Drawing.Font("Graphik Bold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btneditarNota.ForeColor = System.Drawing.Color.White
        Me.btneditarNota.Location = New System.Drawing.Point(53, 463)
        Me.btneditarNota.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btneditarNota.Name = "btneditarNota"
        Me.btneditarNota.Size = New System.Drawing.Size(177, 46)
        Me.btneditarNota.TabIndex = 63
        Me.btneditarNota.Text = "EDITAR"
        Me.btneditarNota.UseVisualStyleBackColor = False
        '
        'btnagregarNota
        '
        Me.btnagregarNota.BackColor = System.Drawing.Color.DodgerBlue
        Me.btnagregarNota.Font = New System.Drawing.Font("Graphik Bold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnagregarNota.ForeColor = System.Drawing.Color.White
        Me.btnagregarNota.Location = New System.Drawing.Point(53, 411)
        Me.btnagregarNota.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btnagregarNota.Name = "btnagregarNota"
        Me.btnagregarNota.Size = New System.Drawing.Size(177, 46)
        Me.btnagregarNota.TabIndex = 62
        Me.btnagregarNota.Text = "Agregar"
        Me.btnagregarNota.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Graphik Bold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(36, 283)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(132, 22)
        Me.Label2.TabIndex = 60
        Me.Label2.Text = "COMPETENCIA"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Graphik Bold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(37, 166)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(103, 22)
        Me.Label1.TabIndex = 59
        Me.Label1.Text = "TRIMESTRE"
        '
        'cmbcodigocurso
        '
        Me.cmbcodigocurso.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbcodigocurso.Font = New System.Drawing.Font("Graphik Bold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbcodigocurso.FormattingEnabled = True
        Me.cmbcodigocurso.Location = New System.Drawing.Point(39, 131)
        Me.cmbcodigocurso.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.cmbcodigocurso.Name = "cmbcodigocurso"
        Me.cmbcodigocurso.Size = New System.Drawing.Size(141, 30)
        Me.cmbcodigocurso.TabIndex = 74
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Graphik Bold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(36, 111)
        Me.Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(68, 22)
        Me.Label4.TabIndex = 73
        Me.Label4.Text = "CURSO"
        '
        'cmbCompetencia
        '
        Me.cmbCompetencia.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbCompetencia.Font = New System.Drawing.Font("Graphik Bold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbCompetencia.FormattingEnabled = True
        Me.cmbCompetencia.Items.AddRange(New Object() {"Exposicion", "Trabajos", "Examen"})
        Me.cmbCompetencia.Location = New System.Drawing.Point(39, 305)
        Me.cmbCompetencia.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.cmbCompetencia.Name = "cmbCompetencia"
        Me.cmbCompetencia.Size = New System.Drawing.Size(136, 30)
        Me.cmbCompetencia.TabIndex = 75
        '
        'rbtInicial
        '
        Me.rbtInicial.AutoSize = True
        Me.rbtInicial.Font = New System.Drawing.Font("Graphik Bold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbtInicial.Location = New System.Drawing.Point(41, 11)
        Me.rbtInicial.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.rbtInicial.Name = "rbtInicial"
        Me.rbtInicial.Size = New System.Drawing.Size(113, 26)
        Me.rbtInicial.TabIndex = 76
        Me.rbtInicial.TabStop = True
        Me.rbtInicial.Text = "Preescolar"
        Me.rbtInicial.UseVisualStyleBackColor = True
        '
        'rbtprimaria
        '
        Me.rbtprimaria.AutoSize = True
        Me.rbtprimaria.Font = New System.Drawing.Font("Graphik Bold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbtprimaria.Location = New System.Drawing.Point(158, 11)
        Me.rbtprimaria.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.rbtprimaria.Name = "rbtprimaria"
        Me.rbtprimaria.Size = New System.Drawing.Size(95, 26)
        Me.rbtprimaria.TabIndex = 77
        Me.rbtprimaria.TabStop = True
        Me.rbtprimaria.Text = "Primaria"
        Me.rbtprimaria.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Graphik Bold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(37, 223)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(127, 22)
        Me.Label3.TabIndex = 79
        Me.Label3.Text = "AÑO ESCOLAR"
        '
        'cmbannoEscolar
        '
        Me.cmbannoEscolar.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbannoEscolar.Font = New System.Drawing.Font("Graphik Bold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbannoEscolar.FormattingEnabled = True
        Me.cmbannoEscolar.Location = New System.Drawing.Point(40, 245)
        Me.cmbannoEscolar.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.cmbannoEscolar.Name = "cmbannoEscolar"
        Me.cmbannoEscolar.Size = New System.Drawing.Size(140, 30)
        Me.cmbannoEscolar.TabIndex = 80
        '
        'DataGridView2
        '
        Me.DataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView2.Location = New System.Drawing.Point(291, 52)
        Me.DataGridView2.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.DataGridView2.Name = "DataGridView2"
        Me.DataGridView2.RowTemplate.Height = 24
        Me.DataGridView2.Size = New System.Drawing.Size(222, 101)
        Me.DataGridView2.TabIndex = 81
        '
        'frmAgregarNota
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(90, Byte), Integer), CType(CType(110, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(890, 537)
        Me.Controls.Add(Me.DataGridView2)
        Me.Controls.Add(Me.rbtInicial)
        Me.Controls.Add(Me.rbtprimaria)
        Me.Controls.Add(Me.cmbannoEscolar)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.cmbCompetencia)
        Me.Controls.Add(Me.cmbcodigocurso)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.cmbnota)
        Me.Controls.Add(Me.cmbtrimestre)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txtapellidoAlumno)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.btneditarNota)
        Me.Controls.Add(Me.btnagregarNota)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Name = "frmAgregarNota"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmAgregarNota"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cmbnota As System.Windows.Forms.ComboBox
    Friend WithEvents cmbtrimestre As System.Windows.Forms.ComboBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtapellidoAlumno As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents btneditarNota As System.Windows.Forms.Button
    Friend WithEvents btnagregarNota As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cmbcodigocurso As System.Windows.Forms.ComboBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents cmbCompetencia As System.Windows.Forms.ComboBox
    Friend WithEvents rbtInicial As System.Windows.Forms.RadioButton
    Friend WithEvents rbtprimaria As System.Windows.Forms.RadioButton
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents cmbannoEscolar As System.Windows.Forms.ComboBox
    Friend WithEvents DataGridView2 As System.Windows.Forms.DataGridView
End Class
