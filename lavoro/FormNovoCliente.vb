Public Class FormNovoCliente
    Public login As Boolean = False
    Public Reserva As Boolean = False
    Public Aluguer As Boolean = False

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim cliente As Cliente
        Dim idade As Integer
        Dim unico As Boolean = True

        idade = Today.Year - dtpDataNasc.Value.Year
        If dtpDataNasc.Value > Today.AddYears(-idade) Then
            idade -= 1
        End If

        For i = 0 To empresa.clientes.Count - 1
            If txtNIF.Text = empresa.clientes.item(i).Nif Then
                unico = False
                Exit For
            End If
        Next

        If txtNome.Text <> "" And txtNIF.Text <> "" Then
            If idade >= 18 Then
                If unico = True Then
                    cliente = New Cliente(txtNome.Text, dtpDataNasc.Text, txtNIF.Text)
                    cliente.Email = txtEmail.Text
                    cliente.Telemovel = txtTelemovel.Text
                    cliente.Morada = txtMorada.Text
                    empresa.clientes.Add(cliente)
                    gravar()
                Else
                    MsgBox("Ja existe um cliente com o mesmo NIF.")
                    Exit Sub
                End If
            Else
                MsgBox("Por favor introduza uma data válida.")
                Exit Sub
            End If
        Else
            MsgBox("Por favor introduza o Nome e o NIF.")
            Exit Sub
        End If

        If Reserva Then
            FormReserva.ClienteAtivo = empresa.clientes.Count - 1
            FormReserva.MostrarCliente()
        End If

        If Aluguer Then
            FormALuguer.clienteAtivo = cliente
            FormALuguer.MostrarCliente()
        End If
        If login = True Then
            FormNovoUtilizador.txbcliente.Text = txtNIF.Text
        End If

        Me.Close()

    End Sub
    Public Sub gravar()
        empresa.gravar(ficheiro)
    End Sub

    Private Sub FormNovoCliente_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class