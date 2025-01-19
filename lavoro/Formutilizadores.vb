Public Class Formutilizadores
    Private Sub Formutilizadores_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lvutilizadores.View = View.Details
        Me.lvutilizadores.FullRowSelect = True
        Me.lvutilizadores.Columns.Add("Nome Utilizador", 150, HorizontalAlignment.Left)
        Me.lvutilizadores.Columns.Add("Palavra Chave", 150, HorizontalAlignment.Left)
        Me.lvutilizadores.Columns.Add("Nivel", 50, HorizontalAlignment.Left)
        Me.lvutilizadores.Columns.Add("NIF", 50, HorizontalAlignment.Left)
        refreshform()
    End Sub

    Private Sub btnProcurar_Click(sender As Object, e As EventArgs) Handles btnProcurar.Click
        lvutilizadores.Items.Clear()
        For Each utilizador As Classeutilizador In empresa.Utilizadores
            If utilizador.Utilizador.Contains(txbutilizador.Text) Then
                If utilizador.Nivel = 1 Then
                    lvutilizadores.Items.Add(New ListViewItem({utilizador.Utilizador, utilizador.Chave, utilizador.Nivel, utilizador.Cliente.Nif}))
                Else
                    lvutilizadores.Items.Add(New ListViewItem({utilizador.Utilizador, utilizador.Chave, utilizador.Nivel}))
                End If

            ElseIf txbutilizador.Text = "" Then
                If utilizador.Nivel = 1 Then
                    lvutilizadores.Items.Add(New ListViewItem({utilizador.Utilizador, utilizador.Chave, utilizador.Nivel, utilizador.Cliente.Nif}))
                Else
                    lvutilizadores.Items.Add(New ListViewItem({utilizador.Utilizador, utilizador.Chave, utilizador.Nivel}))
                End If
            End If

        Next
    End Sub

    Private Sub btneditar_Click(sender As Object, e As EventArgs) Handles btneditar.Click
        Dim utilizadorativo As Integer
        If lvutilizadores.SelectedItems.Count = 0 Then
            MsgBox("selecione um Utilizador")
        Else
            For i = 0 To empresa.Utilizadores.Count - 1
                If empresa.Utilizadores.item(i).Utilizador = lvutilizadores.SelectedItems(0).SubItems(0).Text Then
                    utilizadorativo = i
                    FormNovoUtilizador.ativo = utilizadorativo
                    FormNovoUtilizador.Show()
                    Exit For
                End If
            Next
        End If


    End Sub

    Private Sub btadicionar_Click(sender As Object, e As EventArgs) Handles btadicionar.Click
        FormNovoUtilizador.Show()
    End Sub
    Private Sub bteleminar_Click(sender As Object, e As EventArgs) Handles bteleminar.Click

        If lvutilizadores.SelectedItems.Count = 0 Then
            MsgBox("Selecione um utilizador primeiro")
        Else

            For i = 0 To empresa.Utilizadores.Count - 1
                If empresa.Utilizadores.item(i).Utilizador = lvutilizadores.SelectedItems(0).SubItems(0).Text Then
                    empresa.Utilizadores.Remove(empresa.Utilizadores.item(i))
                    empresa.gravar(ficheiro)

                    Exit For
                End If
            Next
        End If
        refreshform()
    End Sub
    Public Sub refreshform()
        lvutilizadores.Items.Clear()

        For Each utilizador As Classeutilizador In empresa.Utilizadores
            If utilizador.Nivel = 1 Then
                lvutilizadores.Items.Add(New ListViewItem({utilizador.Utilizador, utilizador.Chave, utilizador.Nivel, utilizador.Cliente.Nif}))
            Else
                lvutilizadores.Items.Add(New ListViewItem({utilizador.Utilizador, utilizador.Chave, utilizador.Nivel}))
            End If
        Next
        txbutilizador.Clear()
    End Sub


End Class