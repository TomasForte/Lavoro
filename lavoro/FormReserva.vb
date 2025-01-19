Public Class FormReserva
    Public index As Integer
    Public nivel As Integer
    Public ClienteAtivo As Integer

    Private Sub RefreshForm()
        Me.Controls.Clear()
        Me.InitializeComponent()

    End Sub

    Private Sub btnConcluir_Click(sender As Object, e As EventArgs) Handles btnConcluir.Click
        Dim reserva As Registo
        Dim nliv As Integer = 0
        Dim nveic As Integer = 0
        Dim codigoReserva As String


        If ClienteAtivo >= 0 Then
            If dtpDataInicio.Value < Date.Today Or dtpDataFim.Value < dtpDataInicio.Value Then
                MsgBox("Datas Invádidas")
                Exit Sub
            Else

                For Each veiculo As Veiculo In empresa.Veiculos
                    If veiculo.Classe.Classe = cmbClasseVeiculo.Text Then
                        nveic += 1
                    End If
                Next

                nliv = nveic

                For Each registo As Registo In empresa.Registos
                    If registo.Classeveiculo.Classe = cmbClasseVeiculo.Text Then
                        If registo.Datafim > dtpDataInicio.Value And registo.Datainicio < dtpDataFim.Value Then

                            nliv -= 1

                        End If
                    End If

                Next

                If nliv > 0 Then
                    reserva = New Registo(empresa.clientes.item(ClienteAtivo), dtpDataInicio.Value.Date, dtpDataFim.Value.Date, empresa.Classesveiculo.item(cmbClasseVeiculo.SelectedIndex), empresa.Registos.IndiceCod + 1)
                    empresa.Registos.Add(reserva)
                    codigoReserva = reserva.GerarCodigo(empresa.Registos.IndiceCod)
                    empresa.gravar(ficheiro)
                    MsgBox("O código da reserva é: " & codigoReserva)
                Else
                    MsgBox("Não estão disponível veiculos dessa classe para as datas apresentadas")
                    Exit Sub
                End If

            End If
            Me.Close()
        Else

            MsgBox("Ainda não é cliente")
        End If

    End Sub


    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles btnNovoCliente.Click
        FormNovoCliente.Show()

        FormNovoCliente.Reserva = True

    End Sub

    Private Sub FormReserva_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        For i = 0 To empresa.Classesveiculo.Count - 1
            cmbClasseVeiculo.Items.Add(empresa.Classesveiculo.item(i).Classe)
        Next
        If nivel = 1 Then
            txtNif.Text = empresa.Utilizadores.item(index).Cliente.Nif
            txtNif.Enabled = False
            txtNome.Text = empresa.Utilizadores.item(index).Cliente.Nome
            txtDataNasc.Text = empresa.Utilizadores.item(index).Cliente.DataNasc
            txtIdade.Text = empresa.Utilizadores.item(index).Cliente.Idade
            ClienteAtivo = index
            btnNovoCliente.Visible = False


        End If
    End Sub

    Private Sub cmbClasseVeiculo_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbClasseVeiculo.SelectedIndexChanged
        txtPortas.Text = empresa.Classesveiculo.item(cmbClasseVeiculo.SelectedIndex).NumPortas
        txtLugares.Text = empresa.Classesveiculo.item(cmbClasseVeiculo.SelectedIndex).NumLugares
        txtTrans.Text = empresa.Classesveiculo.item(cmbClasseVeiculo.SelectedIndex).Transmissao
        txtMala.Text = empresa.Classesveiculo.item(cmbClasseVeiculo.SelectedIndex).CapMala
        txtPreco.Text = empresa.Classesveiculo.item(cmbClasseVeiculo.SelectedIndex).Custobase
    End Sub

    Public Sub MostrarCliente()
        Me.txtNome.Text = empresa.clientes.item(ClienteAtivo).Nome
        Me.txtNif.Text = empresa.clientes.item(ClienteAtivo).Nif
        Me.txtDataNasc.Text = empresa.clientes.item(ClienteAtivo).DataNasc
        Me.txtIdade.Text = empresa.clientes.item(ClienteAtivo).Idade

    End Sub

    Private Sub txtNif_TextChanged(sender As Object, e As EventArgs) Handles txtNif.TextChanged

        txtNome.Text = ""
        txtDataNasc.Text = ""
        txtIdade.Text = ""
        ClienteAtivo = Nothing

        For i = 0 To empresa.clientes.Count - 1
            If empresa.clientes.item(i).Nif = txtNif.Text Then
                txtNome.Text = empresa.clientes.item(i).Nome
                txtDataNasc.Text = empresa.clientes.item(i).DataNasc
                txtIdade.Text = empresa.clientes.item(i).Idade
                ClienteAtivo = i
                Exit For
            End If
        Next

    End Sub


End Class