Public Class ClasseVeiculo

    Private _classe As String
    Private _custoBase As Double
    Private _numLugares As Integer
    Private _numPortas As Integer
    Private _transmissao As String
    Private _capMala As Integer

    Public Sub New()

    End Sub

    Public Sub New(ByVal classe As String, ByVal custobase As Double, ByVal numLugares As Integer, ByVal numPortas As Integer, ByVal transmissao As String, ByVal numMalas As Integer)
        _classe = classe
        _custoBase = custobase
        Me.NumLugares = numLugares
        Me.NumPortas = numPortas
        Me.Transmissao = transmissao
        Me.CapMala = numMalas

    End Sub

    Public Property Classe As String
        Get
            Return _classe
        End Get
        Set(value As String)
            _classe = value
        End Set
    End Property

    Public Property Custobase As String
        Get
            Return _custoBase
        End Get
        Set(value As String)
            _custoBase = value
        End Set
    End Property

    Public Property NumLugares As Integer
        Get
            Return _numLugares
        End Get
        Set(value As Integer)
            _numLugares = value
        End Set
    End Property

    Public Property NumPortas As Integer
        Get
            Return _numPortas
        End Get
        Set(value As Integer)
            _numPortas = value
        End Set
    End Property

    Public Property Transmissao As String
        Get
            Return _transmissao
        End Get
        Set(value As String)
            If value = "Automática" Or value = "Manual" Then
                _transmissao = value
            End If
        End Set
    End Property

    Public Property CapMala As Integer
        Get
            Return _capMala
        End Get
        Set(value As Integer)
            _capMala = value
        End Set
    End Property
End Class
