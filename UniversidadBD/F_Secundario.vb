Public Class F_Secundario
    Public Facultad As New Facultad()
    Private oConeccion As New Coneccion()
    Public Alumno As New Alumnos
    Private Profesor As New Profesores
    Private Otro As New Otros
    Private oConfiguracion As New Configuracion()
    'CLICKS PARA SIGUIENTE PANEL
    Private Sub BTN_A_MateriaSiguiente_Click_1(sender As Object, e As EventArgs) Handles BTN_A_MateriaSiguiente.Click
        PNL_A_Materia.Visible = False
        oConfiguracion.EstablecerConfiguracion(Me, PNL_A_Correlativa, TabControl1)
    End Sub
    Private Sub BTN_A_AlumnoSiguiente_Click(sender As Object, e As EventArgs) Handles BTN_A_AlumnoSiguiente.Click
        PNL_A_Alumno.Visible = False
        oConfiguracion.EstablecerConfiguracion(Me, PNL_A_Alumno2, TabControl1)
    End Sub
    Private Sub BTN_E_ProfesorSiguiente_Click(sender As Object, e As EventArgs) Handles BTN_E_ProfesorSiguiente.Click
        PNL_E_Profesor.Visible = False
        oConfiguracion.EstablecerConfiguracion(Me, PNL_E_Profesor2, TabControl1)
    End Sub
    Private Sub BTN_E_AlumnoSiguiente_Click(sender As Object, e As EventArgs) Handles BTN_E_AlumnoSiguiente.Click
        PNL_E_Alumno.Visible = False
        oConfiguracion.EstablecerConfiguracion(Me, PNL_E_Alumno2, TabControl1)
    End Sub
    Private Sub BTN_A_ProfesorSiguiente_Click(sender As Object, e As EventArgs) Handles BTN_A_ProfesorSiguiente.Click
        PNL_A_Profesor.Visible = False
        oConfiguracion.EstablecerConfiguracion(Me, PNL_A_ProfesorMaterias, TabControl1)
    End Sub
    Private Sub BTN_A_CursoSiguiente_Click(sender As Object, e As EventArgs) Handles BTN_A_CursoSiguiente.Click
        PNL_A_Curso.Visible = False
        oConfiguracion.EstablecerConfiguracion(Me, PNL_A_Curso2, TabControl1)
    End Sub
    Private Sub BTN_E_CursoSiguiente_Click(sender As Object, e As EventArgs) Handles BTN_E_CursoSiguiente.Click
        PNL_E_Curso.Visible = False
        oConfiguracion.EstablecerConfiguracion(Me, PNL_E_Curso2, TabControl1)
    End Sub
    'OPERACIONES EN BASE DE DATOS
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Alumno.Nombre = TXT_A_NombreAlumno.Text
        Alumno.Apellido = TXT_A_ApellidoAlumno.Text
        Alumno.DNI = TXT_A_DNIAlumno.Text
        Alumno.NumeroDeLegajo = TXT_A_NLegajoAlumno.Text
        Alumno.CUIL = TXT_A_CUILAlumno.Text
        Alumno.InsertarAlumno()
    End Sub
    Private Sub BTN_A_FacultadAceptar_Click(sender As Object, e As EventArgs) Handles BTN_A_FacultadAceptar.Click
        Facultad.Codigo = TXT_A_CodigoFacultad.Text
        Facultad.Descripcion = TXT_A_DescripcionFacultad.Text
        Facultad.InsertarFacultad()
        Me.Close()
    End Sub
    'EVENTOS DE LA VISIBILIDAD DE LOS PANELES
    Private Sub PNL_E_Facultad_VisibleChanged(sender As Object, e As EventArgs) Handles PNL_E_Facultad.VisibleChanged
        oConfiguracion.CargarComboBox(CMB_E_SeleccionarFacultad, PNL_E_Facultad, "FACULTAD", "DESCRIPCION")
    End Sub
    'COMBOBOXS
    Private Sub CMB_E_SeleccionarFacultad_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CMB_E_SeleccionarFacultad.SelectedIndexChanged
        TXT_E_CodigoFacultad.Text = Facultad.Codigo
        TXT_E_DescripcionFacultad.Text = Facultad.Descripcion
    End Sub
End Class