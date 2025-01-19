
Public Class Registos
        Inherits Collections.CollectionBase

    Private _indiceCod As Integer


    Public Sub Add(ByVal NewRegisto As Registo)
        Me.List.Add(NewRegisto)
        _indiceCod += 1
    End Sub

    Public Sub Remove(ByVal oldRegisto As Registo)
        Me.List.Remove(oldRegisto)
    End Sub

    Default Public Property item(ByVal index As Integer) As Registo
        Get
            Return Me.List.Item(index)
        End Get
        Set(ByVal value As Registo)
            Me.List.Item(index) = value
        End Set
    End Property

    Public Property IndiceCod As Integer
        Get
            Return _indiceCod
        End Get
        Set(value As Integer)
            _indiceCod = value
        End Set
    End Property

    Public Shadows Sub clear()
        MyBase.Clear()
    End Sub

    Public Shadows Sub RemoveAt(ByVal index As Integer)
        Remove(item(index))
    End Sub

    Public Function PrintReservas(datainicio As Date, datafim As Date) As String
        'imprimir todas as reservas entre duas datas 

        Dim texto As String

        texto = ""

        For i = 0 To Me.Count - 1    'verificar indice
            If Me.item(i).Estado = "Reserva" Then
                If Me.item(i).Datainicio >= datainicio Then
                    If Me.item(i).Datafim <= datafim Then
                        texto = texto & Me.item(i).PrintReserva & vbNewLine     'verificar compatibilidade com listbox
                    End If
                End If
            End If
        Next

        Return texto

    End Function

    Public Function PrintAlugueres(ByVal datainicio As Date, ByVal datafim As Date) As String
        'imprimir todos os alugueres entre duas datas

        Dim texto As String

        texto = ""

        For i = 0 To Me.Count - 1    'verificar indice
            If Me.item(i).Estado = "Aluguer" Then
                If Me.item(i).Datainicio >= datainicio Then
                    If Me.item(i).Datafim <= datafim Then
                        texto = texto & Me.item(i).PrintAluguer & vbNewLine     'verificar compatibilidade com listbox
                    End If
                End If
            End If

        Next

        Return texto

    End Function


End Class

