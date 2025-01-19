Public Class ClassesVeiculo
    Inherits Collections.CollectionBase

    Public Sub Add(ByVal NewClasseVeiculo As ClasseVeiculo)
        Me.List.Add(NewClasseVeiculo)
    End Sub

    Public Sub Remove(ByVal oldClasseVeiculo As ClasseVeiculo)
        Me.List.Remove(oldClasseVeiculo)
    End Sub

    Default Public Property item(ByVal index As Integer) As ClasseVeiculo
        Get
            Return Me.List.Item(index)
        End Get
        Set(ByVal value As ClasseVeiculo)
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
