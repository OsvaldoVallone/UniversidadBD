Public Class Examen
    Private pMateria As Materia
    Private pCodigo As String
    Private pFecha As Date
    Private pHora As Integer
    Private pTipo As String
    Private pCondicion As String
    Public Property Materia() As Materia
        Get
            Return pMateria
        End Get
        Set(ByVal value As Materia)
            pMateria = value
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
    Public Property Fecha() As Date
        Get
            Return pFecha
        End Get
        Set(ByVal value As Date)
            pFecha = value
        End Set
    End Property
    Public Property Hora() As Integer
        Get
            Return pHora
        End Get
        Set(ByVal value As Integer)
            pHora = value
        End Set
    End Property
    Public Property Tipo() As String
        Get
            Return pTipo
        End Get
        Set(ByVal value As String)
            pTipo = value
        End Set
    End Property
    Public Property Condicion() As String
        Get
            Return pCondicion
        End Get
        Set(ByVal value As String)
            pCondicion = value
        End Set
    End Property
End Class
