<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAgregarAlumno
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmAgregarAlumno))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtnombreAlumno = New System.Windows.Forms.TextBox()
        Me.txtapellidoAlumno = New System.Windows.Forms.TextBox()
        Me.txtdireccionAlumno = New System.Windows.Forms.TextBox()
        Me.txtnombreApoderadoAlumno = New System.Windows.Forms.TextBox()
        Me.btnagregarAlumno = New System.Windows.Forms.Button()
        Me.cmbsexoAlumno = New System.Windows.Forms.ComboBox()
        Me.btneditarAlumno = New System.Windows.Forms.Button()
        Me.btneliminarAlumno = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.btnbuscarAlumno = New System.Windows.Forms.Button()
        Me.txtdniiAlumno = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtdniAlumno = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtedadAlumno = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtnumeroTelefonoApoderado = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.btnListar = New System.Windows.Forms.Button()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Graphik Bold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(88, 68)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(74, 22)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Nombre"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Graphik Bold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(85, 102)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(77, 22)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Apellido"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Graphik Bold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(107, 181)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(49, 22)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Sexo"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Graphik Bold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.White
        Me.Label7.Location = New System.Drawing.Point(72, 218)
        Me.Label7.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(87, 22)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = "Direccion"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Graphik Bold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.White
        Me.Label8.Location = New System.Drawing.Point(58, 258)
        Me.Label8.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(98, 22)
        Me.Label8.TabIndex = 7
        Me.Label8.Text = "Apoderado"
        '
        'txtnombreAlumno
        '
        Me.txtnombreAlumno.Font = New System.Drawing.Font("Graphik Bold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtnombreAlumno.Location = New System.Drawing.Point(189, 65)
        Me.txtnombreAlumno.Margin = New System.Windows.Forms.Padding(2)
        Me.txtnombreAlumno.Name = "txtnombreAlumno"
        Me.txtnombreAlumno.Size = New System.Drawing.Size(139, 25)
        Me.txtnombreAlumno.TabIndex = 8
        '
        'txtapellidoAlumno
        '
        Me.txtapellidoAlumno.Font = New System.Drawing.Font("Graphik Bold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtapellidoAlumno.Location = New System.Drawing.Point(189, 102)
        Me.txtapellidoAlumno.Margin = New System.Windows.Forms.Padding(2)
        Me.txtapellidoAlumno.Name = "txtapellidoAlumno"
        Me.txtapellidoAlumno.Size = New System.Drawing.Size(139, 25)
        Me.txtapellidoAlumno.TabIndex = 9
        '
        'txtdireccionAlumno
        '
        Me.txtdireccionAlumno.Font = New System.Drawing.Font("Graphik Bold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtdireccionAlumno.Location = New System.Drawing.Point(190, 215)
        Me.txtdireccionAlumno.Margin = New System.Windows.Forms.Padding(2)
        Me.txtdireccionAlumno.Name = "txtdireccionAlumno"
        Me.txtdireccionAlumno.Size = New System.Drawing.Size(139, 25)
        Me.txtdireccionAlumno.TabIndex = 12
        '
        'txtnombreApoderadoAlumno
        '
        Me.txtnombreApoderadoAlumno.Font = New System.Drawing.Font("Graphik Bold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtnombreApoderadoAlumno.Location = New System.Drawing.Point(190, 255)
        Me.txtnombreApoderadoAlumno.Margin = New System.Windows.Forms.Padding(2)
        Me.txtnombreApoderadoAlumno.Name = "txtnombreApoderadoAlumno"
        Me.txtnombreApoderadoAlumno.Size = New System.Drawing.Size(139, 25)
        Me.txtnombreApoderadoAlumno.TabIndex = 13
        '
        'btnagregarAlumno
        '
        Me.btnagregarAlumno.BackColor = System.Drawing.Color.DodgerBlue
        Me.btnagregarAlumno.Font = New System.Drawing.Font("Graphik Bold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnagregarAlumno.ForeColor = System.Drawing.Color.White
        Me.btnagregarAlumno.Location = New System.Drawing.Point(30, 345)
        Me.btnagregarAlumno.Margin = New System.Windows.Forms.Padding(2)
        Me.btnagregarAlumno.Name = "btnagregarAlumno"
        Me.btnagregarAlumno.Size = New System.Drawing.Size(299, 46)
        Me.btnagregarAlumno.TabIndex = 14
        Me.btnagregarAlumno.Text = "Agregar"
        Me.btnagregarAlumno.UseVisualStyleBackColor = False
        '
        'cmbsexoAlumno
        '
        Me.cmbsexoAlumno.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbsexoAlumno.Font = New System.Drawing.Font("Graphik Bold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbsexoAlumno.FormattingEnabled = True
        Me.cmbsexoAlumno.Items.AddRange(New Object() {"M", "F", "N"})
        Me.cmbsexoAlumno.Location = New System.Drawing.Point(190, 173)
        Me.cmbsexoAlumno.Margin = New System.Windows.Forms.Padding(2)
        Me.cmbsexoAlumno.Name = "cmbsexoAlumno"
        Me.cmbsexoAlumno.Size = New System.Drawing.Size(139, 30)
        Me.cmbsexoAlumno.TabIndex = 15
        '
        'btneditarAlumno
        '
        Me.btneditarAlumno.BackColor = System.Drawing.Color.DodgerBlue
        Me.btneditarAlumno.Font = New System.Drawing.Font("Graphik Bold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btneditarAlumno.ForeColor = System.Drawing.Color.White
        Me.btneditarAlumno.Location = New System.Drawing.Point(30, 397)
        Me.btneditarAlumno.Margin = New System.Windows.Forms.Padding(2)
        Me.btneditarAlumno.Name = "btneditarAlumno"
        Me.btneditarAlumno.Size = New System.Drawing.Size(151, 46)
        Me.btneditarAlumno.TabIndex = 22
        Me.btneditarAlumno.Text = "EDITAR"
        Me.btneditarAlumno.UseVisualStyleBackColor = False
        '
        'btneliminarAlumno
        '
        Me.btneliminarAlumno.BackColor = System.Drawing.Color.DodgerBlue
        Me.btneliminarAlumno.Font = New System.Drawing.Font("Graphik Bold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btneliminarAlumno.ForeColor = System.Drawing.Color.White
        Me.btneliminarAlumno.Location = New System.Drawing.Point(193, 397)
        Me.btneliminarAlumno.Margin = New System.Windows.Forms.Padding(2)
        Me.btneliminarAlumno.Name = "btneliminarAlumno"
        Me.btneliminarAlumno.Size = New System.Drawing.Size(136, 46)
        Me.btneliminarAlumno.TabIndex = 23
        Me.btneliminarAlumno.Text = "ELIMINAR"
        Me.btneliminarAlumno.UseVisualStyleBackColor = False
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(372, 76)
        Me.DataGridView1.Margin = New System.Windows.Forms.Padding(2)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowTemplate.Height = 24
        Me.DataGridView1.Size = New System.Drawing.Size(514, 367)
        Me.DataGridView1.TabIndex = 24
        '
        'btnbuscarAlumno
        '
        Me.btnbuscarAlumno.BackColor = System.Drawing.Color.DodgerBlue
        Me.btnbuscarAlumno.Font = New System.Drawing.Font("Graphik Bold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnbuscarAlumno.ForeColor = System.Drawing.Color.White
        Me.btnbuscarAlumno.Location = New System.Drawing.Point(650, 17)
        Me.btnbuscarAlumno.Margin = New System.Windows.Forms.Padding(2)
        Me.btnbuscarAlumno.Name = "btnbuscarAlumno"
        Me.btnbuscarAlumno.Size = New System.Drawing.Size(102, 46)
        Me.btnbuscarAlumno.TabIndex = 25
        Me.btnbuscarAlumno.Text = "BUSCAR"
        Me.btnbuscarAlumno.UseVisualStyleBackColor = False
        '
        'txtdniiAlumno
        '
        Me.txtdniiAlumno.Font = New System.Drawing.Font("Graphik Bold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtdniiAlumno.Location = New System.Drawing.Point(372, 38)
        Me.txtdniiAlumno.Margin = New System.Windows.Forms.Padding(2)
        Me.txtdniiAlumno.Name = "txtdniiAlumno"
        Me.txtdniiAlumno.Size = New System.Drawing.Size(213, 25)
        Me.txtdniiAlumno.TabIndex = 26
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Graphik Bold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.White
        Me.Label9.Location = New System.Drawing.Point(368, 14)
        Me.Label9.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(154, 22)
        Me.Label9.TabIndex = 27
        Me.Label9.Text = "Número de cuenta"
        '
        'txtdniAlumno
        '
        Me.txtdniAlumno.Font = New System.Drawing.Font("Graphik Bold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtdniAlumno.Location = New System.Drawing.Point(189, 31)
        Me.txtdniAlumno.Margin = New System.Windows.Forms.Padding(2)
        Me.txtdniAlumno.Name = "txtdniAlumno"
        Me.txtdniAlumno.Size = New System.Drawing.Size(139, 25)
        Me.txtdniAlumno.TabIndex = 29
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Graphik Bold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.White
        Me.Label10.Location = New System.Drawing.Point(11, 34)
        Me.Label10.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(154, 22)
        Me.Label10.TabIndex = 28
        Me.Label10.Text = "Número de cuenta"
        '
        'txtedadAlumno
        '
        Me.txtedadAlumno.Font = New System.Drawing.Font("Graphik Bold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtedadAlumno.Location = New System.Drawing.Point(189, 134)
        Me.txtedadAlumno.Margin = New System.Windows.Forms.Padding(2)
        Me.txtedadAlumno.Name = "txtedadAlumno"
        Me.txtedadAlumno.Size = New System.Drawing.Size(48, 25)
        Me.txtedadAlumno.TabIndex = 31
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Graphik Bold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(107, 137)
        Me.Label6.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(49, 22)
        Me.Label6.TabIndex = 30
        Me.Label6.Text = "Edad"
        '
        'txtnumeroTelefonoApoderado
        '
        Me.txtnumeroTelefonoApoderado.Font = New System.Drawing.Font("Graphik Bold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtnumeroTelefonoApoderado.Location = New System.Drawing.Point(189, 294)
        Me.txtnumeroTelefonoApoderado.Margin = New System.Windows.Forms.Padding(2)
        Me.txtnumeroTelefonoApoderado.Name = "txtnumeroTelefonoApoderado"
        Me.txtnumeroTelefonoApoderado.Size = New System.Drawing.Size(139, 25)
        Me.txtnumeroTelefonoApoderado.TabIndex = 33
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Graphik Bold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(31, 297)
        Me.Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(131, 22)
        Me.Label4.TabIndex = 32
        Me.Label4.Text = "Telf Apoderado"
        '
        'btnListar
        '
        Me.btnListar.BackColor = System.Drawing.Color.DodgerBlue
        Me.btnListar.Font = New System.Drawing.Font("Graphik Bold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnListar.ForeColor = System.Drawing.Color.White
        Me.btnListar.Location = New System.Drawing.Point(756, 17)
        Me.btnListar.Margin = New System.Windows.Forms.Padding(2)
        Me.btnListar.Name = "btnListar"
        Me.btnListar.Size = New System.Drawing.Size(102, 46)
        Me.btnListar.TabIndex = 34
        Me.btnListar.Text = "LISTAR"
        Me.btnListar.UseVisualStyleBackColor = False
        '
        'frmAgregarAlumno
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(90, Byte), Integer), CType(CType(110, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(907, 461)
        Me.Controls.Add(Me.btnListar)
        Me.Controls.Add(Me.txtnumeroTelefonoApoderado)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtedadAlumno)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txtdniAlumno)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.txtdniiAlumno)
        Me.Controls.Add(Me.btnbuscarAlumno)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.btneliminarAlumno)
        Me.Controls.Add(Me.btneditarAlumno)
        Me.Controls.Add(Me.cmbsexoAlumno)
        Me.Controls.Add(Me.btnagregarAlumno)
        Me.Controls.Add(Me.txtnombreApoderadoAlumno)
        Me.Controls.Add(Me.txtdireccionAlumno)
        Me.Controls.Add(Me.txtapellidoAlumno)
        Me.Controls.Add(Me.txtnombreAlumno)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "frmAgregarAlumno"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmAgregarAlumno"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txtnombreAlumno As System.Windows.Forms.TextBox
    Friend WithEvents txtapellidoAlumno As System.Windows.Forms.TextBox
    Friend WithEvents txtdireccionAlumno As System.Windows.Forms.TextBox
    Friend WithEvents txtnombreApoderadoAlumno As System.Windows.Forms.TextBox
    Friend WithEvents btnagregarAlumno As System.Windows.Forms.Button
    Friend WithEvents cmbsexoAlumno As System.Windows.Forms.ComboBox
    Friend WithEvents btneditarAlumno As System.Windows.Forms.Button
    Friend WithEvents btneliminarAlumno As System.Windows.Forms.Button
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents btnbuscarAlumno As System.Windows.Forms.Button
    Friend WithEvents txtdniiAlumno As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents txtdniAlumno As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents txtedadAlumno As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtnumeroTelefonoApoderado As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents btnListar As System.Windows.Forms.Button
End Class
