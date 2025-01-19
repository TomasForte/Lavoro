Public Class Veiculos
    Inherits Collections.CollectionBase

    Public Sub Add(ByVal Newveiculo As Veiculo)
        Me.List.Add(Newveiculo)
    End Sub

    Public Sub Remove(ByVal oldveiculo As Veiculo)
        Me.List.Remove(oldveiculo)
    End Sub

    Default Public Property item(ByVal index As Integer) As Veiculo
        Get
            Return Me.List.Item(index)
        End Get
        Set(ByVal value As Veiculo)
            Me.List.Item(index) = value
        End Set
    End Property

    Public Shadows Sub clear()
        MyBase.Clear()
    End Sub

    Public Shadows Sub RemoveAt(ByVal index As Integer)
        Remove(item(index))
    End Sub

End Class
