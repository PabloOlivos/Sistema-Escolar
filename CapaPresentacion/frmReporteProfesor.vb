Imports Microsoft.Reporting.WinForms
Imports CapaNegocio
Public Class frmReporteProfesor
#Region "Funcionalidad de las ventanas"
    Private Sub frmReporteProfesor_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim objnegAnnoEscolar As New negAnnoEscolar
        cmbannoEscolar.DataSource = objnegAnnoEscolar.listarAnnoEscolar()
        cmbannoEscolar.DisplayMember = "numeroAnno"
    End Sub

    Private Sub cmbcodGrado_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbcodGrado.SelectedIndexChanged
        If rbtinicial.Checked = True Then
            cargarDatosSeccionInicial()
        ElseIf rbtPrimaria.Checked = True Then
            cargarDatosSeccionPrimaria()
        Else
            MsgBox("Debe elegir primaria o preescolar")
        End If
    End Sub

    Public Sub cargarDatosSeccionInicial()
        Dim objneg As New negSeccion
        cmbcodseccion.DataSource = objneg.cargarSeccion(Val(cmbcodGrado.Text), Val(cmbannoEscolar.Text))
        cmbcodseccion.DisplayMember = "nombreSeccion"
        cmbcodseccion.ValueMember = "codigoSeccion"
    End Sub
    Public Sub cargarDatosSeccionPrimaria()
        Dim objneg As New negSeccion
        cmbcodseccion.DataSource = objneg.cargarSeccionP(Val(cmbcodGrado.Text), Val(cmbannoEscolar.Text))
        cmbcodseccion.DisplayMember = "nombreSeccion"
        cmbcodseccion.ValueMember = "codigoSeccion"
    End Sub

    Private Sub rbtinicial_CheckedChanged(sender As Object, e As EventArgs) Handles rbtinicial.CheckedChanged
        Dim objnegGrado As New negGrado
        Dim objnegCurso As New negCurso
        If rbtinicial.Checked = True Then
            cmbcodGrado.DataSource = objnegGrado.listarGradoInicial
            cmbcodGrado.DisplayMember = "numeroGrado"
            cmbcodGrado.ValueMember = "codigoGrado"
        End If
    End Sub

    Private Sub rbtPrimaria_CheckedChanged(sender As Object, e As EventArgs) Handles rbtPrimaria.CheckedChanged
        Dim objnegGrado As New negGrado
        Dim objnegCurso As New negCurso
        If rbtPrimaria.Checked = True Then
            cmbcodGrado.DataSource = objnegGrado.listarGradoPrimaria
            cmbcodGrado.DisplayMember = "numeroGrado"
            cmbcodGrado.ValueMember = "codigoGrado"
        End If
    End Sub


    Private Sub btnMostrar_Click(sender As Object, e As EventArgs) Handles btnMostrar.Click
        Dim objneg As New negProfesor
        Dim nivel As String = ""
        If rbtinicial.Checked = True Then
            nivel = "Preescolar"
        ElseIf rbtPrimaria.Checked = True Then
            nivel = "Primaria"
        End If
        Dim dst As New Colegio_DBDataSet
        dst.Tables.Add(objneg.ObtenerTablaListar(cmbannoEscolar.Text, nivel, cmbcodGrado.SelectedValue, cmbcodseccion.SelectedValue))
        Dim rds As New ReportDataSource("DataSet1", dst.Tables(1))
        Me.ReportViewer1.LocalReport.DataSources.Clear()
        Me.ReportViewer1.LocalReport.DataSources.Add(rds)
        Me.ReportViewer1.RefreshReport()

    End Sub

#End Region

#Region "Finalizar"
    Protected Overrides Sub Finalize()
        Me.Close()
    End Sub

    Private Sub Label6_Click(sender As Object, e As EventArgs) Handles Label6.Click

    End Sub

    Private Sub cmbcodseccion_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbcodseccion.SelectedIndexChanged

    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub
#End Region
End Class