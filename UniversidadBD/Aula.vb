Public Class Aula
    Private pFacultad As Facultad
    Private pCodigo As String
    Private pDescripcion As String
    Public Property Facultad() As Facultad
        Get
            Return pFacultad
        End Get
        Set(ByVal value As Facultad)
            pFacultad = value
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
    Public Property Descripcion() As String
        Get
            Return pDescripcion
        End Get
        Set(ByVal value As String)
            pDescripcion = value
        End Set
    End Property
End Class
