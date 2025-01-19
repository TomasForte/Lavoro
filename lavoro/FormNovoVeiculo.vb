Public Class FormNovoVeiculo
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim veiculo As Veiculo
        Dim matriusado As Boolean = False


        If txbModelo.Text <> "" And txbNumLugares.Text <> "" And txbNumPortas.Text <> "" And empresa.Classesveiculo.item(cmbClasse.SelectedIndex).Classe <> "" And cmbTransm.Text <> "" And cmbClasse.Text <> "" And Txbmatricula.Text <> "" Then

            For Each _veiculo As Veiculo In empresa.Veiculos
                If _veiculo.Matricula = Txbmatricula.Text Then
                    matriusado = True
                    Exit For
                End If
            Next
            If matriusado = False Then

                veiculo = New Veiculo(txbModelo.Text, cmbCombustivel.Text, empresa.Classesveiculo.item(cmbClasse.SelectedIndex), Txbmatricula.Text)
                '' Falta por custo extra
                empresa.Veiculos.Add(veiculo)

                gravar()
                FormFrota.refreshfrom()

                Me.Close()
            Else
                MsgBox("Matricula já existente")
            End If

        Else
            MsgBox("Por favor preencha tudos os campos")
        End If



    End Sub

    Public Sub gravar()
        empresa.gravar(ficheiro)
    End Sub

    Private Sub FormNovoVeiculo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        For i = 0 To empresa.Classesveiculo.Count - 1
            cmbClasse.Items.Add(empresa.Classesveiculo.item(i).Classe)
        Next
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        FormClasse.Show()

    End Sub

    Private Sub ClasseComboBox2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbClasse.SelectedIndexChanged
        txbNumLugares.Text = empresa.Classesveiculo.item(cmbClasse.SelectedIndex).NumLugares
        txbNumPortas.Text = empresa.Classesveiculo.item(cmbClasse.SelectedIndex).NumPortas
        cmbTransm.Text = empresa.Classesveiculo.item(cmbClasse.SelectedIndex).Transmissao
    End Sub
End Class