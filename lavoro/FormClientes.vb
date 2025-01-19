Public Class FormClientes

    Public nifs As String()
    Private clienteativo As Integer

    Private Sub FormClientes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        clientesparalistbox()
    End Sub
    Public Sub clientesparalistbox()
        ListViewClientes.Items.Clear()
        ReDim nifs(empresa.clientes.Count)
        For i = 0 To empresa.clientes.Count - 1
            ListViewClientes.Items.Add(New ListViewItem({empresa.clientes.item(i).Nif, empresa.clientes.item(i).Nome, empresa.clientes.item(i).DataNasc, empresa.clientes.item(i).Idade})) 'qualquer coisa aqui
            nifs(i + 1) = empresa.clientes.item(i).Nif
        Next
    End Sub

    Private Sub btnAdicionarClientes_Click(sender As Object, e As EventArgs) Handles btnAdicionarClientes.Click
        FormNovoCliente.Show()
    End Sub

    Private Sub btnProcurar_Click(sender As Object, e As EventArgs) Handles btnProcurar.Click
        Dim count As Integer

        ReDim nifs(0)
        count = 0

        clienteativo = 0

        ListViewClientes.Items.Clear()
        For i = 0 To empresa.clientes.Count - 1
            If empresa.clientes.item(i).Nome.Contains(txtNome.Text) Then
                If empresa.clientes.item(i).Nif.Contains(txtNIF.Text) Then
                    ListViewClientes.Items.Add(New ListViewItem({empresa.clientes.item(i).Nif, empresa.clientes.item(i).Nome, empresa.clientes.item(i).DataNasc, empresa.clientes.item(i).Idade}))
                    count = count + 1
                    ReDim Preserve nifs(count)
                    nifs(count) = empresa.clientes.item(i).Nif
                End If
            End If
        Next
    End Sub

    Private Sub btnInfo_Click(sender As Object, e As EventArgs) Handles btnInfo.Click

        If ListViewClientes.SelectedItems.Count > 0 Then

            For i = 0 To empresa.clientes.Count - 1
                If empresa.clientes.item(i).Nif = nifs(ListViewClientes.FocusedItem.Index + 1) Then
                    clienteativo = i + 1
                    Exit For
                End If
            Next
        Else
            MsgBox("Selecione um cliente primeiro.")
            Exit Sub
        End If

        FormClientesInfo.ativo = clienteativo - 1


        FormClientesInfo.Show()


    End Sub
End Class