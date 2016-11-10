Public Class Materia
    Private pCarrera As Carrera
    Private pDescripcion As String
    Private pCodigo As String
    Private pDireccion As String
    Private pCorrelativa As Boolean
    Private pOptativa As Boolean
    Private pGrupo As String
    Public Property Descripcion() As String
        Get
            Return pDescripcion
        End Get
        Set(ByVal value As String)
            pDescripcion = value
        End Set
    End Property
    Public Property Codigo() As String
        Get
            Return pCodigo
        End Get
        Set(ByVal value As String)
            pCodigo = value
        End Set
    End Property
    Public Property Direccion() As String
        Get
            Return pDireccion
        End Get
        Set(ByVal value As String)
            pDireccion = value
        End Set
    End Property
    Public Property Correlativa() As Boolean
        Get
            Return pCorrelativa
        End Get
        Set(ByVal value As Boolean)
            pCorrelativa = value
        End Set
    End Property
    Public Property Optativa() As Boolean
        Get
            Return pOptativa
        End Get
        Set(ByVal value As Boolean)
            pOptativa = value
        End Set
    End Property
    Public Property Carrera() As Carrera
        Get
            Return pCarrera
        End Get
        Set(ByVal value As Carrera)
            pCarrera = value
        End Set
    End Property
    Public Property Grupo() As String
        Get
            Return pGrupo
        End Get
        Set(ByVal value As String)
            pGrupo = value
        End Set
    End Property
End Class
