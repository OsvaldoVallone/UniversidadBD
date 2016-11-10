Public NotInheritable Class Profesores
    Inherits Persona
    Private pMatricula As String
    Private pFechaDeIngreso As Date
    Private pFechaDeBaja As Date
    Private pAntiguedad As Integer
    Private pCorreo As String
    Private pProfesion As String
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
    'Propiedades especiales
    Friend Property Matricula() As String
        Get
            Return pMatricula
        End Get
        Set(ByVal value As String)
            pMatricula = value
        End Set
    End Property
    Friend Property FechaDeIngreso() As Date
        Get
            Return pFechaDeIngreso
        End Get
        Set(ByVal value As Date)
            pFechaDeIngreso = value
        End Set
    End Property
    Friend Property FechaDeBaja() As Date
        Get
            Return pFechaDeBaja
        End Get
        Set(ByVal value As Date)
            pFechaDeBaja = value
        End Set
    End Property
    Friend Property Antiguedad() As Integer
        Get
            Return pAntiguedad
        End Get
        Set(ByVal value As Integer)
            pAntiguedad = value
        End Set
    End Property
    Friend Property Correo() As String
        Get
            Return pCorreo
        End Get
        Set(ByVal value As String)
            pCorreo = value
        End Set
    End Property
    Friend Property Profesion() As String
        Get
            Return pProfesion
        End Get
        Set(ByVal value As String)
            pProfesion = value
        End Set
    End Property

End Class
