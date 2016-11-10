Imports Oracle.DataAccess.Client
Public Class Coneccion
    Private Conexion As New OracleConnection()
    Private Comando As New OracleCommand()
    Private Almacenamiento As New DataSet()
    Private Fila As DataRow
    Private Columna As DataColumn
    Private Tabla As DataTable
    Sub New()
        Conexion.ConnectionString = "Data Source=localhost;" + "User Id=TPBD;" + "Password=balditofc42;"
    End Sub
    'COMANDOS
    Private Sub InsertarSQL(Tabla As String)
        Dim Adaptador = New OracleDataAdapter("Select * From " & Tabla, Conexion)
        Almacenamiento.Tables.Clear()
        Adaptador.Fill(Almacenamiento, Tabla)
        Fila = Almacenamiento.Tables(Tabla).NewRow()
    End Sub
    Private Sub ActualizarSQL(Tabla As String)
        Dim Adaptador = New OracleDataAdapter()
        Adaptador.InsertCommand = Comando
        Adaptador.Update(Almacenamiento, Tabla)
    End Sub
    Private Sub Insert(Tabla As String)
        Almacenamiento.Tables(Tabla).Rows.Add(Fila)
        Comando.Connection = Conexion
    End Sub
    'INSERTAR LOS DATOS
    Friend Sub InsertarAlumno()
        Try
            Dim Tabla As String = "PERSONA"
            InsertarSQL(Tabla)
            Fila("PERSONA_NOMBRE") = F_Secundario.Alumno.Nombre
            Fila("PERSONA_APELLIDO") = F_Secundario.Alumno.Apellido
            Fila("PERSONA_CUIL") = F_Secundario.Alumno.CUIL
            Fila("PERSONA_DNI") = F_Secundario.Alumno.DNI
            Insert(Tabla)
            Comando.CommandText = "Insert Into Persona VALUES(:idpersona,:nombre,:apellido,:cuil,:dni)"
            Comando.Parameters.Add(New OracleParameter(":idpersona", OracleDbType.Int64, 10, "ID_PERSONA"))
            Comando.Parameters.Add(New OracleParameter(":nombre", OracleDbType.Varchar2, 100, "PERSONA_NOMBRE"))
            Comando.Parameters.Add(New OracleParameter(":apellido", OracleDbType.Varchar2, 100, "PERSONA_APELLIDO"))
            Comando.Parameters.Add(New OracleParameter(":cuil", OracleDbType.Int64, 11, "PERSONA_CUIL"))
            Comando.Parameters.Add(New OracleParameter(":dni", OracleDbType.Int64, 10, "PERSONA_DNI"))
            ActualizarSQL(Tabla)
            ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
            'Tabla = "ALUMNO"
            'InsertarSQL(Tabla)
            'Fila("ALUMNO_NUMERO_LEGAJO") = F_Secundario.Alumno.NumeroDeLegajo
            'Fila("ALUMNO_FECHA_INGRESO") = F_Secundario.Alumno.FechaDeIngreso
            'Insert(Tabla)
            'Comando.CommandText = "Insert Into Alumno VALUES(:idalumno,:numerodelegajo,:fechaingreso,:relapersona)"
            'Comando.Parameters.Add(New OracleParameter(":idalumno", OracleDbType.Int64, 10, "ID_ALUMNO"))
            'Comando.Parameters.Add(New OracleParameter(":numerodelegajo", OracleDbType.Int64, 10, "ALUMNO_NUMERO_LEGAJO"))
            'Comando.Parameters.Add(New OracleParameter(":fechaingreso", OracleDbType.Date, 0, "ALUMNO_FECHA_INGRESO"))
            'Comando.Parameters.Add(New OracleParameter(":relapersona", OracleDbType.Int64, 10, "ALUMNO_RELA_PERSONA"))
            'ActualizarSQL(Tabla)
            MessageBox.Show("Los datos se guardaron correctamente")
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Excepción", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
End Class
