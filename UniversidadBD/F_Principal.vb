
Public Class F_Principal
    Private oConfiguracion As New Configuracion
    'FACULTAD
    Private Sub AgregarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AgregarToolStripMenuItem.Click
        oConfiguracion.EstablecerConfiguracion(F_Secundario, F_Secundario.PNL_S_Facultad, F_Secundario.TabControl1)
        oConfiguracion.EstablecerConfiguracion(F_Secundario, F_Secundario.PNL_A_Facultad, F_Secundario.TabControl1)
        oConfiguracion.EstablecerConfiguracion(F_Secundario, F_Secundario.PNL_E_Facultad, F_Secundario.TabControl1)
    End Sub
    'CARRERA
    Private Sub ModificarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ModificarToolStripMenuItem.Click
        oConfiguracion.EstablecerConfiguracion(F_Secundario, F_Secundario.PNL_A_Carrera, F_Secundario.TabControl1)
        oConfiguracion.EstablecerConfiguracion(F_Secundario, F_Secundario.PNL_E_Carrera, F_Secundario.TabControl1)
        oConfiguracion.EstablecerConfiguracion(F_Secundario, F_Secundario.PNL_S_Carrera, F_Secundario.TabControl1)
    End Sub
    'MATERIA
    Private Sub EliminarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EliminarToolStripMenuItem.Click
        oConfiguracion.EstablecerConfiguracion(F_Secundario, F_Secundario.PNL_A_Materia, F_Secundario.TabControl1)
        oConfiguracion.EstablecerConfiguracion(F_Secundario, F_Secundario.PNL_E_Materia, F_Secundario.TabControl1)
        oConfiguracion.EstablecerConfiguracion(F_Secundario, F_Secundario.PNL_S_Materia, F_Secundario.TabControl1)
    End Sub
    'AULA
    Private Sub TSM_Salir_Click(sender As Object, e As EventArgs) Handles TSM_Salir.Click
        oConfiguracion.EstablecerConfiguracion(F_Secundario, F_Secundario.PNL_A_Aula, F_Secundario.TabControl1)
        oConfiguracion.EstablecerConfiguracion(F_Secundario, F_Secundario.PNL_E_Aula, F_Secundario.TabControl1)
        oConfiguracion.EstablecerConfiguracion(F_Secundario, F_Secundario.PNL_S_Aula, F_Secundario.TabControl1)
    End Sub
    'SALIR
    Private Sub SalirToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SalirToolStripMenuItem.Click
        Me.Close()
        F_IniciarSesion.Close()
    End Sub
    'PROFESOR
    Private Sub AgregarToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles AgregarToolStripMenuItem1.Click
        oConfiguracion.EstablecerConfiguracion(F_Secundario, F_Secundario.PNL_A_Profesor, F_Secundario.TabControl1)
        oConfiguracion.EstablecerConfiguracion(F_Secundario, F_Secundario.PNL_E_Profesor, F_Secundario.TabControl1)
        oConfiguracion.EstablecerConfiguracion(F_Secundario, F_Secundario.PNL_S_Profesor, F_Secundario.TabControl1)
    End Sub
    'ALUMNO
    Private Sub EditarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EditarToolStripMenuItem.Click
        oConfiguracion.EstablecerConfiguracion(F_Secundario, F_Secundario.PNL_A_Alumno, F_Secundario.TabControl1)
        oConfiguracion.EstablecerConfiguracion(F_Secundario, F_Secundario.PNL_E_Alumno, F_Secundario.TabControl1)
        oConfiguracion.EstablecerConfiguracion(F_Secundario, F_Secundario.PNL_S_Alumno, F_Secundario.TabControl1)
    End Sub
    'OTRO
    Private Sub EliminarToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles EliminarToolStripMenuItem1.Click
        oConfiguracion.EstablecerConfiguracion(F_Secundario, F_Secundario.PNL_A_Otro, F_Secundario.TabControl1)
        oConfiguracion.EstablecerConfiguracion(F_Secundario, F_Secundario.PNL_E_Otro, F_Secundario.TabControl1)
        oConfiguracion.EstablecerConfiguracion(F_Secundario, F_Secundario.PNL_S_Otro, F_Secundario.TabControl1)
    End Sub
    'USUARIO
    Private Sub UsuarioToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles UsuarioToolStripMenuItem.Click
        oConfiguracion.EstablecerConfiguracion(F_Secundario, F_Secundario.PNL_A_Usuario, F_Secundario.TabControl1)
        oConfiguracion.EstablecerConfiguracion(F_Secundario, F_Secundario.PNL_E_Usuario, F_Secundario.TabControl1)
        oConfiguracion.EstablecerConfiguracion(F_Secundario, F_Secundario.PNL_S_Usuario, F_Secundario.TabControl1)
    End Sub
    'GESTION DE ALUMNOS
    Private Sub GestiónDeAlumnosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GestiónDeAlumnosToolStripMenuItem.Click
        F_GestionAlumnos.Show()
    End Sub
    'CURSO
    Private Sub CuatrimestreToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CuatrimestreToolStripMenuItem.Click
        oConfiguracion.EstablecerConfiguracion(F_Secundario, F_Secundario.PNL_A_Curso, F_Secundario.TabControl1)
        oConfiguracion.EstablecerConfiguracion(F_Secundario, F_Secundario.PNL_E_Curso, F_Secundario.TabControl1)
        oConfiguracion.EstablecerConfiguracion(F_Secundario, F_Secundario.PNL_S_Curso, F_Secundario.TabControl1)
    End Sub
    'EXAMEN FINAL
    Private Sub ExamenFinalToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExamenFinalToolStripMenuItem.Click
        oConfiguracion.EstablecerConfiguracion(F_Secundario, F_Secundario.PNL_A_ExamenFinal, F_Secundario.TabControl1)
        oConfiguracion.EstablecerConfiguracion(F_Secundario, F_Secundario.PNL_E_ExamenFinal, F_Secundario.TabControl1)
        oConfiguracion.EstablecerConfiguracion(F_Secundario, F_Secundario.PNL_S_ExamenFinal, F_Secundario.TabControl1)
    End Sub
    ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
    'CONSULTA DE CURSOS
    Private Sub InscripcionesAMateriasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles InscripcionesAMateriasToolStripMenuItem.Click
        PNL_C_ExamenesFinales.Visible = False
        PNL_C_ExamenesParciales.Visible = False
        PNL_C_NotasExamen.Visible = False
        oConfiguracion.EstablecerPanel(PNL_C_Cursos)
    End Sub
    'CONSULTA DE EXAMENES FINALES
    Private Sub FinalesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FinalesToolStripMenuItem.Click
        PNL_C_Cursos.Visible = False
        PNL_C_ExamenesParciales.Visible = False
        PNL_C_NotasExamen.Visible = False
        oConfiguracion.EstablecerPanel(PNL_C_ExamenesFinales)
    End Sub
    'CONSULTA DE EXAMENES PARCIALES
    Private Sub ParcialesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ParcialesToolStripMenuItem.Click
        PNL_C_Cursos.Visible = False
        PNL_C_ExamenesFinales.Visible = False
        PNL_C_NotasExamen.Visible = False
        oConfiguracion.EstablecerPanel(PNL_C_ExamenesParciales)
    End Sub
    'NOTAS
    Private Sub NotasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NotasToolStripMenuItem.Click
        PNL_C_Cursos.Visible = False
        PNL_C_ExamenesFinales.Visible = False
        PNL_C_ExamenesParciales.Visible = False
        oConfiguracion.EstablecerPanel(PNL_C_NotasExamen)
    End Sub
End Class