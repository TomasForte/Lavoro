Public Class Classeutilizadores
    Inherits Collections.CollectionBase

    Public Sub Add(ByVal Newclasseutilizador As Classeutilizador)
        Me.List.Add(Newclasseutilizador)
    End Sub

    Public Sub Remove(ByVal oldclasseutilizador As Classeutilizador)
        Me.List.Remove(oldclasseutilizador)
    End Sub

    Default Public Property item(ByVal index As Integer) As Classeutilizador
        Get
            Return Me.List.Item(index)
        End Get
        Set(ByVal value As Classeutilizador)
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
