Imports Oracle.DataAccess.Client
Public NotInheritable Class Alumnos
    Inherits Persona
    Private pNumeroDeLegajo As String
    Private pFechaDeIngreso As Date
    'Propiedades heredadas
    Friend Overrides Property Nombre As String
        Get
            Return MyBase.Nombre
        End Get
        Set(value As String)
            MyBase.Nombre = value
        End Set
    End Property
    Friend Overrides Property Apellido As String
        Get
            Return MyBase.Apellido
        End Get
        Set(value As String)
            MyBase.Apellido = value
        End Set
    End Property
    Friend Overrides Property CUIL As String
        Get
            Return MyBase.CUIL
        End Get
        Set(value As String)
            MyBase.CUIL = value
        End Set
    End Property
    Friend Overrides Property DNI As String
        Get
            Return MyBase.DNI
        End Get
        Set(value As String)
            MyBase.DNI = value
        End Set
    End Property
    Friend Overrides Property Telefono As String
        Get
            Return MyBase.Telefono
        End Get
        Set(value As String)
            MyBase.Telefono = value
        End Set
    End Property
    Friend Overrides Property TipoTelefono As String
        Get
            Return MyBase.TipoTelefono
        End Get
        Set(value As String)
            MyBase.TipoTelefono = value
        End Set
    End Property
    'Propiedades especiales
    Friend Property NumeroDeLegajo() As String
        Get
            Return pNumeroDeLegajo
        End Get
        Set(ByVal value As String)
            pNumeroDeLegajo = value
        End Set
    End Property
    Friend Property FechaDeIngreso() As Date
        Get
            pFechaDeIngreso = DateAndTime.Now()
            Return pFechaDeIngreso
        End Get
        Set(ByVal value As Date)
            pFechaDeIngreso = value
        End Set
    End Property
    'INSERTAR ALUMNOS
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
            MessageBox.Show("Los datos se guardaron correctamente")
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Excepción", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
End Class
