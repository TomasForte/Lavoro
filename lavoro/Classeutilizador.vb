Public Class Classeutilizador

    Private _Utilizador As String
    Private _Chave As String
    Private _nivel As Integer
    Private _cliente As Cliente

    Public Sub New()

    End Sub

    Public Sub New(ByVal utilizador As String, ByVal chave As String, ByVal nivel As String)
        _Utilizador = utilizador
        _Chave = chave
        _nivel = nivel
    End Sub

    Public Property Utilizador As String
        Get
            Return _Utilizador
        End Get
        Set(value As String)
            _Utilizador = value
        End Set
    End Property

    Public Property Chave As String
        Get
            Return _Chave
        End Get
        Set(value As String)
            _Chave = value
        End Set
    End Property

    Public Property Nivel As Integer
        Get
            Return _nivel
        End Get
        Set(value As Integer)
            _nivel = value
        End Set
    End Property


    Public Property Cliente As Cliente
            Get
                Return _cliente
            End Get
            Set(value As Cliente)
                _cliente = value
            End Set
        End Property
    End Class
