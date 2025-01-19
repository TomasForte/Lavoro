Imports lavoro

Public Class Registo

    Private _cliente As Cliente
    Private _veiculo As Veiculo
    Private _datainicio As Date
    Private _datafim As Date
    Private _datareserva As Date
    Private _estado As String
    Private _classeveiculo As ClasseVeiculo
    Private _codigo As String


    Public Sub New()

    End Sub

    Public Sub New(ByVal cliente As Cliente, ByVal datainicio As Date, ByVal datafim As Date, ByVal classecarro As ClasseVeiculo, ByVal indice As Integer)
        'nova reserva

        _cliente = cliente
        _datainicio = datainicio
        _datafim = datafim
        _estado = "Reserva"
        _datareserva = Today
        Classeveiculo = classecarro
        GerarCodigo(indice)

    End Sub

    Public Sub New(ByVal cliente As Cliente, ByVal datainicio As Date, ByVal datafim As Date, ByVal veiculo As Veiculo, ByVal indice As Integer)
        'novo aluguer

        _cliente = cliente
        _datainicio = datainicio
        _datafim = datafim
        _estado = "Aluguer"
        _veiculo = veiculo
        _classeveiculo = veiculo.Classe
        GerarCodigo(indice)


    End Sub

    Public Property Cliente As Cliente
        Get
            Return _cliente
        End Get
        Set(value As Cliente)
            _cliente = value
        End Set
    End Property

    Public Property Veiculo As Veiculo
        Get
            Return _veiculo
        End Get
        Set(value As Veiculo)
            _veiculo = value
        End Set
    End Property

    Public Property Datainicio As Date
        Get
            Return _datainicio.Date
        End Get
        Set(value As Date)
            _datainicio = value
        End Set
    End Property

    Public Property Datafim As Date
        Get
            Return _datafim.Date
        End Get
        Set(value As Date)
            _datafim = value
        End Set
    End Property

    Public Property Estado As String
        Get
            If _estado = "Aluguer" Then
                If _datafim < Today Then
                    _estado = "Concluído"
                    _codigo = "C" & Mid(_codigo, 2)
                End If
            End If
            Return _estado
        End Get
        Set(value As String)
            _estado = value
        End Set
    End Property


    Public Property Datareserva As Date
        Get
            Return _datareserva.Date
        End Get
        Set(value As Date)
            _datareserva = value
        End Set
    End Property

    Public Property Classeveiculo As ClasseVeiculo
        Get
            If _classeveiculo Is Nothing Then
                _classeveiculo = _veiculo.Classe
            End If
            Return _classeveiculo
        End Get
        Set(value As ClasseVeiculo)
            _classeveiculo = value
        End Set
    End Property

    Public Property Codigo As String
        Get
            Return _codigo
        End Get
        Set(value As String)
            _codigo = value
        End Set
    End Property

    Public Sub Reserva2Aluguer(ByVal veiculo As Veiculo)
        'transformar reserva em aluguer

        _estado = "Aluguer"
        _veiculo = veiculo
        _codigo = "A" & Mid(_codigo, 2)

    End Sub

    Public Sub CancelReserva()
        'cancelar uma reserva

        _estado = "Cancelado"
        _codigo = "X" & Mid(_codigo, 2)

    End Sub

    Public Function PrintReserva() As String
        Dim texto As String

        texto = _codigo & vbTab & _cliente.Nome & vbTab & _datainicio & vbTab & _datafim

        Return texto

    End Function

    Public Function PrintAluguer() As String
        Dim texto As String

        texto = _cliente.Nome & vbTab & _datainicio & vbTab & _datafim & vbTab & _veiculo.Modelo

        Return texto

    End Function

    Public Function GerarCodigo(indice As Integer) As String

        If Me.Codigo = "" Then
            _codigo = Mid(_estado, 1, 1) & _datainicio.Month & _datafim.Year & _classeveiculo.Classe & indice
        End If

        Return Codigo

    End Function

    Public Function CalcularPreco(ByVal epocaAlta As Boolean, Optional ByVal seguro As Boolean = False)

        Dim preco, multiplicador As Double

        multiplicador = 1

        If _cliente.Idade < 25 Or _cliente.Idade > 60 Then
            multiplicador *= 1.2
        End If

        If seguro Then
            multiplicador *= 1.1
        End If

        If epocaAlta Then
            multiplicador *= 2
        End If

        preco = (_datafim - _datainicio).Days * _classeveiculo.Custobase * multiplicador

        Return preco

    End Function


End Class
