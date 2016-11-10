Public MustInherit Class Persona
    Inherits Coneccion
    Protected pNombre As String
    Protected pApellido As String
    Protected pCUIL As String
    Protected pDNI As String
    Protected pTelefono As String
    Protected pTipoTelefono As String
    Friend Overridable Property Nombre() As String
        Get
            Return pNombre
        End Get
        Set(ByVal value As String)
            pNombre = value
        End Set
    End Property
    Friend Overridable Property Apellido() As String
        Get
            Return pApellido
        End Get
        Set(value As String)
            pApellido = value
        End Set
    End Property
    Friend Overridable Property CUIL() As String
        Get
            Return pCUIL
        End Get
        Set(value As String)
            pCUIL = value
        End Set
    End Property
    Friend Overridable Property DNI() As String
        Get
            Return pDNI
        End Get
        Set(value As String)
            pDNI = value
        End Set
    End Property
    Friend Overridable Property Telefono() As String
        Get
            Return pTelefono
        End Get
        Set(value As String)
            pTelefono = value
        End Set
    End Property
    Friend Overridable Property TipoTelefono() As String
        Get
            Return pTipoTelefono
        End Get
        Set(value As String)
            pTipoTelefono = value
        End Set
    End Property
End Class
