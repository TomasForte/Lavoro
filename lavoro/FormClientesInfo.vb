Public Class FormClientesInfo

    Public ativo As Integer

    Private Sub FormClientesInfo_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        txtNome.Text = empresa.clientes.item(ativo).Nome
        txtNIF.Text = empresa.clientes.item(ativo).Nif
        txtDataNasc.Text = empresa.clientes.item(ativo).DataNasc
        txtMorada.Text = empresa.clientes.item(ativo).Morada
        txtEmail.Text = empresa.clientes.item(ativo).Email
        txtTelemovel.Text = empresa.clientes.item(ativo).Telemovel
        txtIdade.Text = empresa.clientes.item(ativo).Idade
        reservasparalistbox()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        empresa.clientes.item(ativo).Nome = txtNome.Text
        empresa.clientes.item(ativo).Nif = txtNIF.Text
        empresa.clientes.item(ativo).DataNasc = txtDataNasc.Text
        empresa.clientes.item(ativo).Morada = txtMorada.Text
        empresa.clientes.item(ativo).Email = txtEmail.Text
        empresa.clientes.item(ativo).Telemovel = txtTelemovel.Text

        empresa.gravar(ficheiro)

        FormClientes.clientesparalistbox()
        Me.Close()

    End Sub

    Public Sub reservasparalistbox()

        ListView1.Items.Clear()

        For i = 0 To empresa.Registos.Count - 1
            If empresa.Registos.item(i).Cliente.Nif.Contains(txtNIF.Text) Then
                ListView1.Items.Add(New ListViewItem({empresa.Registos.item(i).Classeveiculo.Classe, empresa.Registos.item(i).Datainicio, empresa.Registos.item(i).Datafim, empresa.Registos.item(i).Estado}))
            End If
        Next
    End Sub
End Class