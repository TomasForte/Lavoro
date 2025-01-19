Public Class FormALuguer

    Private comReserva As Boolean = False
    Private registoAtivo As Registo
    Friend clienteAtivo As Cliente
    Private carroAtivo As Veiculo


    Private Sub btnReserva_Click(sender As Object, e As EventArgs) Handles btnReserva.Click
        For Each reserva As Registo In empresa.Registos
            If reserva.Codigo = txtReserva.Text Then
                registoAtivo = reserva

                datDataInicio.Value = registoAtivo.Datainicio
                datDataFim.Value = registoAtivo.Datafim
                cmbClasse.Text = registoAtivo.Classeveiculo.Classe
                txtLugares.Text = registoAtivo.Classeveiculo.NumLugares
                txtPortas.Text = registoAtivo.Classeveiculo.NumPortas
                txtMala.Text = registoAtivo.Classeveiculo.CapMala
                txtTransmissao.Text = registoAtivo.Classeveiculo.Transmissao

                clienteAtivo = registoAtivo.Cliente
                MostrarCliente()

                UpdateListView()

                comReserva = True

            End If
        Next




    End Sub

    Private Sub cmbClasse_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbClasse.SelectedIndexChanged
        txtPortas.Text = empresa.Classesveiculo.item(cmbClasse.SelectedIndex).NumPortas
        txtLugares.Text = empresa.Classesveiculo.item(cmbClasse.SelectedIndex).NumLugares
        txtTransmissao.Text = empresa.Classesveiculo.item(cmbClasse.SelectedIndex).Transmissao
        txtMala.Text = empresa.Classesveiculo.item(cmbClasse.SelectedIndex).CapMala

        UpdateListView()

    End Sub

    Private Sub FormALuguer_Load(sender As Object, e As EventArgs) Handles Me.Load

        For i = 0 To empresa.Classesveiculo.Count - 1
            cmbClasse.Items.Add(empresa.Classesveiculo.item(i).Classe)
        Next

        lvwVeiculos.FullRowSelect = True
        lvwVeiculos.Columns.Add("Modelo", 100, HorizontalAlignment.Left)
        lvwVeiculos.Columns.Add("Nº Lugares", 80, HorizontalAlignment.Left)
        lvwVeiculos.Columns.Add("Nº Portas", 80, HorizontalAlignment.Left)
        lvwVeiculos.Columns.Add("Combustível", 100, HorizontalAlignment.Left)
        lvwVeiculos.Columns.Add("Classe", 100, HorizontalAlignment.Left)
        lvwVeiculos.Columns.Add("Matricula", 100, HorizontalAlignment.Left)
    End Sub

    Private Function VeiculoLivre(ByVal dataInicio As Date, ByVal carro As Veiculo) As Boolean
        Dim livre As Boolean = True

        For Each aluguer As Registo In empresa.Registos

            If aluguer.Estado = "Aluguer" Then
                If aluguer.Veiculo.Matricula = carro.Matricula Then
                    If aluguer.Datafim > dataInicio Then
                        livre = False
                        Exit For
                    End If
                End If
            End If

        Next

        Return livre

    End Function

    Private Sub UpdateListView()
        lvwVeiculos.Items.Clear()

        For Each veiculo As Veiculo In empresa.Veiculos
            If veiculo.Classe.Classe = cmbClasse.Text Then

                If VeiculoLivre(datDataInicio.Value, veiculo) Then
                    lvwVeiculos.Items.Add(New ListViewItem({veiculo.Modelo, veiculo.Classe.NumLugares, veiculo.Classe.NumPortas, veiculo.Combustivel, veiculo.Classe.Classe, veiculo.Matricula}))
                End If
            End If

        Next

    End Sub

    Private Sub btnCliente_Click(sender As Object, e As EventArgs) Handles btnCliente.Click
        FormNovoCliente.Show()
        FormNovoCliente.Aluguer = True

    End Sub

    Public Sub MostrarCliente()
        txtCliente.Text = clienteAtivo.Nome
        txtNif.Text = clienteAtivo.Nif
    End Sub

    Private Sub chkSeguro_CheckedChanged(sender As Object, e As EventArgs) Handles chkSeguro.CheckedChanged
        MsgBox("O seguro tem um acŕescimo de 10% ao preço de aluguer mas cobre qualquer dano do veículo!")
    End Sub

    Private Sub btnConfirmar_Click(sender As Object, e As EventArgs) Handles btnConfirmar.Click

        For Each cliente As Cliente In empresa.clientes
            If cliente.Nif = txtNif.Text Then
                clienteAtivo = cliente
            End If
        Next

        If comReserva Then
            registoAtivo.Reserva2Aluguer(carroAtivo)
            empresa.gravar(ficheiro)
        ElseIf datDataInicio.Value > datDataFim.Value Then
            MsgBox("Por favor insira datas válidas.")
            Exit Sub
        ElseIf clienteAtivo Is Nothing Then
            MsgBox("Por favor insira o NIF de um cliente atual ou adicione um novo cliente.")
            Exit Sub
        ElseIf carroAtivo Is Nothing Then
            MsgBox("Por favor selecione um veiculo disponível.")
            Exit Sub
        Else
            registoAtivo = New Registo(clienteAtivo, datDataInicio.Value.Date, datDataFim.Value.Date, carroAtivo, empresa.Registos.IndiceCod + 1)
            empresa.Registos.Add(registoAtivo)
            empresa.gravar(ficheiro)
            MsgBox("O preço final do aluguer é: " & registoAtivo.CalcularPreco(epocaAlta, chkSeguro.Checked))
        End If
        Me.Close()


    End Sub

    Private Sub lvwVeiculos_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lvwVeiculos.SelectedIndexChanged

    End Sub

    Private Function VeiculoDeMatricula(matricula As String) As Veiculo

        For Each veiculo As Veiculo In empresa.Veiculos
            If veiculo.Matricula = matricula Then
                Return veiculo
                Exit For
            Else
                Return Nothing
            End If
        Next

    End Function

    Private Sub lvwVeiculos_Click(sender As Object, e As EventArgs) Handles lvwVeiculos.Click
        carroAtivo = VeiculoDeMatricula(lvwVeiculos.SelectedItems(0).SubItems(5).Text)
    End Sub

    Private Sub txtNif_TextChanged(sender As Object, e As EventArgs) Handles txtNif.TextChanged

        txtCliente.Text = ""

        For Each cliente As Cliente In empresa.clientes
            If cliente.Nif = txtNif.Text Then
                clienteAtivo = cliente
                MostrarCliente()
                Exit For
            End If
        Next


    End Sub

    Private Sub datDataInicio_ValueChanged(sender As Object, e As EventArgs) Handles datDataInicio.ValueChanged
        UpdateListView()
    End Sub

    Private Sub datDataFim_ValueChanged(sender As Object, e As EventArgs) Handles datDataFim.ValueChanged
        UpdateListView()
    End Sub
End Class
