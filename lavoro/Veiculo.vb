Imports lavoro

Public Class Veiculo

    Private _modelo As String
    Private _combustivel As String

    Private _matricula As String
    Private _classe As ClasseVeiculo

    Sub New()

    End Sub
    Public Sub New(ByVal modelo As String, ByVal tipocombustivel As String, ByVal classe As ClasseVeiculo, ByVal matricula As String)
        _modelo = modelo

        _classe = classe
        Me.Combustivel = tipocombustivel
        _matricula = matricula

    End Sub

    Public Property Modelo As String
        Get
            Return _modelo
        End Get
        Set(value As String)
            _modelo = value
        End Set

    End Property



    Public Property Combustivel As String
        Get
            Return _combustivel
        End Get
        Set(value As String)
            If value = "Diesel" Or value = "Gasolina" Then
                _combustivel = value
            End If
        End Set
    End Property


    Public Property Classe As ClasseVeiculo
        Get
            Return _classe
        End Get
        Set(value As ClasseVeiculo)
            _classe = value
        End Set
    End Property

    Public Property Matricula As String
        Get
            Return _matricula
        End Get
        Set(value As String)
            _matricula = value
        End Set
    End Property

    Public Function printinf() As String
        Dim texto As String
        texto = _modelo & vbTab & _classe.NumLugares & vbTab & _classe.NumPortas & vbTab & _combustivel & vbTab & _classe.Classe
        Return texto
    End Function

End Class
