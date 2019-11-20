Public Class ModeloClientes

    'Campos Privados
    Private CampoID As Integer
    Private CampoNome As String
    Private CampoEndereco As String
    Private CampoTelefone As String

    'Propriedades
    Public Property ID() As Integer
        Get
            Return CampoID
        End Get
        Set(ByVal valor As Integer)
            CampoID = valor
        End Set
    End Property

    Public Property Nome() As String
        Get
            Return CampoNome
        End Get
        Set(ByVal valor As String)
            CampoNome = valor
        End Set
    End Property

    Public Property Endereco() As String
        Get
            Return CampoEndereco
        End Get
        Set(ByVal valor As String)
            CampoEndereco = valor
        End Set
    End Property

    Public Property Telefone() As String
        Get
            Return CampoTelefone
        End Get
        Set(ByVal valor As String)
            CampoTelefone = valor
        End Set
    End Property

End Class