Public Class Carrera
    Private pFacultad As Facultad
    Private pDescripcion As String
    Private pCodigo As String
    Private pDuracion As Integer
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
    Public Property Duracion() As Integer
        Get
            Return pDuracion
        End Get
        Set(ByVal value As Integer)
            pDuracion = value
        End Set
    End Property
    Public Property Facultad() As Facultad
        Get
            Return pFacultad
        End Get
        Set(ByVal value As Facultad)
            pFacultad = value
        End Set
    End Property
End Class
