Imports lavoro

Public Class ClassEmpresa
    Private _clientes As Clientes
    Private _veiculos As Veiculos
    Private _classesveiculo As ClassesVeiculo
    Private _registos As Registos
    Private _utilizadores As Classeutilizadores
    'Private _reservas As Reservas
    'Private _alugueres As Alugueres

    Sub New()
        clientes = New Clientes
        Veiculos = New Veiculos
        Classesveiculo = New ClassesVeiculo
        Registos = New Registos
        Utilizadores = New Classeutilizadores
        'Reservas = New Reservas
        'Alugueres = New Alugueres
    End Sub
    Public Property clientes As Clientes
        Get
            Return _clientes
        End Get
        Set(value As Clientes)
            _clientes = value
        End Set
    End Property

    Public Property Veiculos As Veiculos
        Get
            Return _veiculos
        End Get
        Set(value As Veiculos)
            _veiculos = value
        End Set
    End Property

    Public Property Registos As Registos
        Get
            Return _registos
        End Get
        Set(value As Registos)
            _registos = value
        End Set
    End Property

    Public Property Classesveiculo As ClassesVeiculo
        Get
            Return _classesveiculo
        End Get
        Set(value As ClassesVeiculo)
            _classesveiculo = value
        End Set
    End Property

    Public Property Utilizadores As Classeutilizadores
        Get
            Return _utilizadores
        End Get
        Set(value As Classeutilizadores)
            _utilizadores = value
        End Set
    End Property

    Sub gravar(ByVal ficheiro As String)

        Dim writer As New System.Xml.Serialization.XmlSerializer(GetType(ClassEmpresa))

        Dim file As New System.IO.StreamWriter(ficheiro)

        writer.Serialize(file, Me)

        file.Close()

    End Sub

    Public Function ler(ByVal ficheiro As String) As ClassEmpresa
        Dim reader As New System.Xml.Serialization.XmlSerializer(GetType(ClassEmpresa))

        Dim file As New System.IO.StreamReader(ficheiro)

        Dim MyObject As ClassEmpresa
        MyObject = CType(reader.Deserialize(file), ClassEmpresa)

        file.Close()

        Return MyObject

    End Function
End Class
