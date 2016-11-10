Imports Oracle.DataAccess.Client
Public Class Configuracion
    Inherits Coneccion
    Private X As Integer
    Private Y As Integer
    Private Alto As Integer
    Private Ancho As Integer
    Sub EstablecerConfiguracion(Formulario As Form, Panel As Panel, Pestañas As TabControl)
        Formulario.Width = 587
        Formulario.Height = 485
        Panel.Width = 532
        Panel.Height = 390
        Panel.Top = 6
        Panel.Left = 6
        Pestañas.Width = 552
        Pestañas.Height = 428
        Formulario.Show()
        Panel.Visible = True
    End Sub
    Sub EstablecerPanel(Panel As Panel)
        Panel.Left = 3
        Panel.Top = 68
        Panel.Width = 1069
        Panel.Height = 488
        Panel.Visible = True
    End Sub
    Sub CargarComboBox(Combo As ComboBox, Panel As Panel, Tabla As String, Columna As String)
        If Panel.Visible = True Then
            Try
                CargarFilaSQL(Tabla, Tabla & "_" & Columna, Combo)
            Catch ex As Exception
                MessageBox.Show(ex.Message, "Excepción", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If
    End Sub
End Class
