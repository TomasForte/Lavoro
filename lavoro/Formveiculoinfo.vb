Public Class Formveiculoinfo
    Public ativo As Integer
    Public nivel As Integer
    Private Sub Formveiculoinfo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim aux As Integer = 0
        For i = 0 To empresa.Classesveiculo.Count - 1
            cmbClasse.Items.Add(empresa.Classesveiculo.item(i).Classe)
        Next
        txbModelo.Text = empresa.Veiculos.item(ativo).Modelo
        txbNumLugares.Text = empresa.Veiculos.item(ativo).Classe.NumLugares
        txbNumPortas.Text = empresa.Veiculos.item(ativo).Classe.NumPortas
        cmbTransm.Text = empresa.Veiculos.item(ativo).Classe.Transmissao
        cmbClasse.Text = empresa.Veiculos.item(ativo).Classe.Classe
        cmbCombustivel.Text = empresa.Veiculos.item(ativo).Combustivel
        Txbmatricula.Text = empresa.Veiculos.item(ativo).Matricula
        ListView1.View = View.Details
        Me.ListView1.FullRowSelect = True
        ListView1.Columns.Add("Cliente", 100, HorizontalAlignment.Left)
        ListView1.Columns.Add("Estado", 80, HorizontalAlignment.Left)
        ListView1.Columns.Add("Data Início", 80, HorizontalAlignment.Left)
        ListView1.Columns.Add("Data Fim", 100, HorizontalAlignment.Left)

        For Each registo As Registo In empresa.Registos
            If registo.Veiculo Is Nothing Then
            Else
                If registo.Veiculo.Modelo = empresa.Veiculos.item(ativo).Modelo Then
                    aux = aux + 1
                    If aux >= 1 Then


                        If registo.Estado <> "reserva" And registo.Estado <> "cancelado" Then
                            If registo.Veiculo.Matricula = empresa.Veiculos.item(ativo).Matricula Then
                                ListView1.Items.Add(New ListViewItem({registo.Cliente.Nome, registo.Estado, registo.Datainicio, registo.Datafim}))
                            End If
                        End If
                    End If
                End If



            End If


        Next
        If nivel = 2 Then
            txbModelo.ReadOnly = True
            txbNumLugares.ReadOnly = True
            txbNumPortas.ReadOnly = True
            cmbTransm.Enabled = False
            cmbClasse.Enabled = False
            cmbCombustivel.Enabled = False
            Txbmatricula.ReadOnly = True

            Button1.Visible = False

        End If



    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        empresa.Veiculos.item(ativo).Modelo = txbModelo.Text
        empresa.Veiculos.item(ativo).Classe.NumLugares = txbNumLugares.Text
        empresa.Veiculos.item(ativo).Classe.NumPortas = txbNumPortas.Text
        empresa.Veiculos.item(ativo).Classe.Transmissao = cmbTransm.Text
        empresa.Veiculos.item(ativo).Classe.Classe = cmbClasse.Text
        empresa.Veiculos.item(ativo).Combustivel = cmbCombustivel.Text
        empresa.Veiculos.item(ativo).Matricula = Txbmatricula.Text
        empresa.gravar(ficheiro)
        FormFrota.refreshfrom()
        Me.Close()
    End Sub

End Class