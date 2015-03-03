Public MustInherit Class Pessoa 'CLASSE ABSTRATA PARA HERANÇA - PESSOA

    Protected _codigo As Integer
    Protected _dataCadastro As Date
    Protected _nome As String
    Protected _endereco As String
    Protected _CPF As String
    Protected _RG As String

    MustOverride Function Salvar() As Boolean
    MustOverride Function Excluir() As String
    MustOverride Function Alterar() As Boolean

    Public ReadOnly Property Codigo() As Integer
        Get
            Return _codigo
        End Get
    End Property
    Public ReadOnly Property DataCadastro() As Date
        Get
            Return _dataCadastro
        End Get
    End Property
    Public Property Nome() As String
        Get
            Return _nome
        End Get
        Set(ByVal value As String)
            _nome = value
        End Set
    End Property
    Public Property Endereco() As String
        Get
            Return _endereco
        End Get
        Set(ByVal value As String)
            _endereco = value
        End Set
    End Property
    Public Property CPF() As String
        Get
            Return _CPF
        End Get
        Set(ByVal value As String)
            _CPF = value
        End Set
    End Property
    Public Property RG() As String
        Get
            Return _RG
        End Get
        Set(ByVal value As String)
            _RG = value
        End Set
    End Property

End Class