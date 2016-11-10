Public Class Cursos
    Private pMateria As Materia
    Private pAula As Aula
    Private pInicio As Date
    Private pFin As Date
    Private pHorario As Horario
    Public Property Materia() As Materia
        Get
            Return pMateria
        End Get
        Set(ByVal value As Materia)
            pMateria = value
        End Set
    End Property
    Public Property Aula() As Aula
        Get
            Return pAula
        End Get
        Set(ByVal value As Aula)
            pAula = value
        End Set
    End Property
    Public Property Inicio() As Date
        Get
            Return pInicio
        End Get
        Set(ByVal value As Date)
            pInicio = value
        End Set
    End Property
    Public Property Fin() As Date
        Get
            Return pFin
        End Get
        Set(ByVal value As Date)
            pFin = value
        End Set
    End Property
    Public Property Horario() As Horario
        Get
            Return pHorario
        End Get
        Set(ByVal value As Horario)
            pHorario = value
        End Set
    End Property
End Class
