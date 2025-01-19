Public Class Cliente

    Private _nome As String
    Private _dataNasc As Date
    Private _idade As Integer
    Private _nif As String
    Private _morada As String
    Private _telemovel As String
    Private _email As String


    Public Sub New()
    End Sub

    Public Sub New(ByVal nome As String, ByVal datanascimento As Date, ByVal nif As String)
        Me.Nome = nome
        Me.DataNasc = datanascimento
        Me.Nif = nif
    End Sub

    Public Property Nome As String
        Get
            Return _nome
        End Get
        Set(value As String)
            _nome = value
        End Set
    End Property
    Public Property DataNasc As Date
        Get
            Return _dataNasc
        End Get
        Set(value As Date)
            _dataNasc = value
            _idade = Today.Year - _dataNasc.Year
            If _dataNasc > Today.AddYears(-Idade) Then
                _idade -= 1
            End If
        End Set
    End Property
    Public Property Nif As String
        Get
            Return _nif
        End Get
        Set(value As String)
            _nif = value
        End Set
    End Property

    Public Property Idade As Integer
        Get
            Return _idade
        End Get
        Set(value As Integer)
            _idade = value
        End Set
    End Property

    Public Property Morada As String
        Get
            Return _morada
        End Get
        Set(value As String)
            _morada = value
        End Set
    End Property

    Public Property Email As String
        Get
            Return _email
        End Get
        Set(value As String)
            _email = value
        End Set
    End Property

    Public Property Telemovel As String
        Get
            Return _telemovel
        End Get
        Set(value As String)
            _telemovel = value
        End Set
    End Property

    Public Function Print() As String
        Dim texto As String

        texto = _nif & vbTab & _nome & vbTab & _dataNasc & vbTab & _idade

        Return texto

    End Function

End Class
