Public Class Direccion
    Private pNumero As Integer
    Private pCalle As String
    Private pCiudad As String
    Private pCodigoPostal As Integer
    Private pProvincia As String
    Private pPais As String
    Public Property Numero() As Integer
        Get
            Return pNumero
        End Get
        Set(ByVal value As Integer)
            pNumero = value
        End Set
    End Property
    Public Property Calle() As String
        Get
            Return pCalle
        End Get
        Set(ByVal value As String)
            pCalle = value
        End Set
    End Property
    Public Property Ciudad() As String
        Get
            Return pCiudad
        End Get
        Set(ByVal value As String)
            pCiudad = value
        End Set
    End Property
    Public Property CodigoPostal() As Integer
        Get
            Return pCodigoPostal
        End Get
        Set(ByVal value As Integer)
            pCodigoPostal = value
        End Set
    End Property
    Public Property Provincia() As String
        Get
            Return pProvincia
        End Get
        Set(ByVal value As String)
            pProvincia = value
        End Set
    End Property
    Public Property Pais() As String
        Get
            Return pPais
        End Get
        Set(ByVal value As String)
            pPais = value
        End Set
    End Property
End Class
