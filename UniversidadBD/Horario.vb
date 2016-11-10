Public Class Horario
    Private pMeses As String
    Private pDias As String
    Private pHoras As Integer
    Private pMinuto As Integer
    Public Property Dias() As String
        Get
            Return pDias
        End Get
        Set(ByVal value As String)
            pDias = value
        End Set
    End Property
    Public Property Horas() As Integer
        Get
            Return pHoras
        End Get
        Set(ByVal value As Integer)
            pHoras = value
        End Set
    End Property
    Public Property Minuto() As Integer
        Get
            Return pMinuto
        End Get
        Set(ByVal value As Integer)
            pMinuto = value
        End Set
    End Property
    Public Property Meses() As String
        Get
            Return pMeses
        End Get
        Set(ByVal value As String)
            pMeses = value
        End Set
    End Property
End Class
