Public Class FormFrota
    Public nivel As Integer
    Private Sub btnAdicionar_Click(sender As Object, e As EventArgs) Handles btnAdicionar.Click
        FormNovoVeiculo.Show()
    End Sub

    Private Sub FormFrota_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        refreshfrom()
        ListView1.FullRowSelect = True
        ListView1.Columns.Add("Modelo", 100, HorizontalAlignment.Left)
        ListView1.Columns.Add("Nº Lugares", 80, HorizontalAlignment.Left)
        ListView1.Columns.Add("Nº Portas", 80, HorizontalAlignment.Left)
        ListView1.Columns.Add("Combustível", 100, HorizontalAlignment.Left)
        ListView1.Columns.Add("Classe", 100, HorizontalAlignment.Left)
        ListView1.Columns.Add("Matricula", 100, HorizontalAlignment.Left)


    End Sub

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click


        If ListView1.SelectedItems.Count = 0 Then
            MsgBox("Selecione um veiculo primeiro")
        Else

            For i = 0 To empresa.Veiculos.Count - 1
                If empresa.Veiculos.item(i).Matricula = ListView1.SelectedItems(0).SubItems(5).Text Then
                    empresa.Veiculos.Remove(empresa.Veiculos.item(i))
                    empresa.gravar(ficheiro)

                    Exit For
                End If
            Next
        End If
        refreshfrom()


    End Sub

    Private Sub btnEditar_Click(sender As Object, e As EventArgs) Handles btnEditar.Click
        Dim veiculoativo As Integer
        If ListView1.SelectedItems.Count = 0 Then
            MsgBox("Selecione um veiculo primeiro")
        Else

            For i = 0 To empresa.Veiculos.Count - 1
                If empresa.Veiculos.item(i).Matricula = ListView1.SelectedItems(0).SubItems(5).Text Then
                    veiculoativo = i

                    Formveiculoinfo.ativo = veiculoativo
                    Formveiculoinfo.nivel = nivel
                    Formveiculoinfo.Show()
                    Exit For
                End If
            Next
        End If
    End Sub

    Public Sub refreshfrom()
        cmbclasse.Items.Clear()
        ListView1.Items.Clear()
        For i = 0 To empresa.Classesveiculo.Count - 1
            cmbclasse.Items.Add(empresa.Classesveiculo.item(i).Classe)
        Next

        For Each veiculo As Veiculo In empresa.Veiculos
            ListView1.Items.Add(New ListViewItem({veiculo.Modelo, veiculo.Classe.NumLugares, veiculo.Classe.NumPortas, veiculo.Combustivel, veiculo.Classe.Classe, veiculo.Matricula}))
        Next
        If nivel = 2 Then
            btnEliminar.Visible = False
            btnAdicionar.Visible = False

        End If
    End Sub

    Private Sub cmbclasse_SelectedIndexChanged_1(sender As Object, e As EventArgs) Handles cmbclasse.SelectedIndexChanged
        ListView1.Items.Clear()
        For Each veiculo As Veiculo In empresa.Veiculos
            If empresa.Classesveiculo.item(cmbclasse.SelectedIndex).Classe = veiculo.Classe.Classe Then
                ListView1.Items.Add(New ListViewItem({veiculo.Modelo, veiculo.Classe.NumLugares, veiculo.Classe.NumPortas, veiculo.Combustivel, veiculo.Classe.Classe, veiculo.Matricula}))
            End If
        Next
    End Sub

    Private Sub btnprocurar_Click(sender As Object, e As EventArgs) Handles btnprocurar.Click
        ListView1.Items.Clear()
        For Each veiculo As Veiculo In empresa.Veiculos
            If cmbclasse.Text <> "" Then
                If veiculo.Classe.Classe = cmbclasse.Text Then
                    If veiculo.Matricula.Contains(TextBox1.Text) Then
                        ListView1.Items.Add(New ListViewItem({veiculo.Modelo, veiculo.Classe.NumLugares, veiculo.Classe.NumPortas, veiculo.Combustivel, veiculo.Classe.Classe, veiculo.Matricula}))
                    End If
                End If

            Else
                If veiculo.Matricula.Contains(TextBox1.Text) Then
                    ListView1.Items.Add(New ListViewItem({veiculo.Modelo, veiculo.Classe.NumLugares, veiculo.Classe.NumPortas, veiculo.Combustivel, veiculo.Classe.Classe, veiculo.Matricula}))
                End If
            End If
        Next
    End Sub
End Class