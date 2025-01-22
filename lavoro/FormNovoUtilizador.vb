Imports System.Diagnostics.Tracing

Public Class FormNovoUtilizador
    Public ativo As Integer = -1
    Public login As Boolean = False
    Private Sub btAdicionar_Click(sender As Object, e As EventArgs) Handles btAdicionar.Click
        Dim _utilizador As Classeutilizador
        Dim find As Boolean = False
        Dim utiliusado As Boolean = False
        Dim nifusado As Boolean = False
        Dim _cliente As Cliente
        Dim IsAtivo As Boolean
        IsAtivo = False
        If Len(txbchave.Text) < 4 Or Len(txbchave.Text) > 30 Or Len(txbUtilizador.Text) < 4 Or Len(txbUtilizador.Text) > 30 And cmbnivel.Text = "" Then
            MsgBox("O nome de utilizador e a palavra chave deverão possuir entre 4 e 30 caracteres")
        Else
            For Each utilizador As Classeutilizador In empresa.Utilizadores
                If txbUtilizador.Text = utilizador.Utilizador Then
                    If ativo > 0 Then
                        If empresa.Utilizadores.item(ativo).Utilizador <> txbUtilizador.Text Then
                            MsgBox("Nome de utilizador já existente")
                            utiliusado = True
                            Exit For
                        End If
                    Else

                        MsgBox("Nome de utilizador já existente")
                        utiliusado = True
                        Exit For

                    End If
                End If
            Next
            If utiliusado = False Then

                If cmbnivel.Text = 1 Then

                    For Each cliente As Cliente In empresa.clientes
                        If txbcliente.Text = cliente.Nif Then
                            find = True
                            For Each utilizador As Classeutilizador In empresa.Utilizadores
                                If utilizador.Nivel = 1 Then
                                    If utilizador.Cliente.Nif = txbcliente.Text Then
                                        If ativo >= 0 Then
                                            If Not empresa.Utilizadores.item(ativo).Cliente Is Nothing Then
                                                If empresa.Utilizadores.item(ativo).Cliente.Nif <> txbcliente.Text Then
                                                    MsgBox("já existe um utilizador com esse nif")
                                                    nifusado = True
                                                    Exit For
                                                End If
                                            End If

                                        Else


                                            MsgBox("já existe um utilizador com esse nif")
                                            nifusado = True

                                            Exit For
                                        End If
                                    End If

                                End If

                            Next
                            If nifusado = True Then
                                Exit For

                            End If
                            'se ativo maior que 0 é para editar e não criar utilizador
                            If ativo >= 0 Then
                                empresa.Utilizadores.item(ativo).Utilizador = txbUtilizador.Text
                                empresa.Utilizadores.item(ativo).Chave = txbchave.Text
                                empresa.Utilizadores.item(ativo).Nivel = cmbnivel.Text
                                empresa.Utilizadores.item(ativo).Cliente = cliente
                                empresa.gravar(ficheiro)
                                Formutilizadores.refreshform()
                                Me.Close()
                                Exit For
                            Else
                                _cliente = cliente
                                _utilizador = New Classeutilizador(txbUtilizador.Text, txbchave.Text, cmbnivel.Text)
                                empresa.Utilizadores.Add(_utilizador)
                                empresa.Utilizadores.item(empresa.Utilizadores.Count - 1).Cliente = _cliente

                                empresa.gravar(ficheiro)
                                Formutilizadores.refreshform()
                                Me.Close()
                                Exit For

                            End If
                        End If
                    Next

                    If find = False Then
                        MsgBox("Nif ainda não foi registado")
                    End If
                Else


                    If ativo >= 0 Then
                        empresa.Utilizadores.item(ativo).Utilizador = txbUtilizador.Text
                        empresa.Utilizadores.item(ativo).Chave = txbchave.Text
                        empresa.Utilizadores.item(ativo).Nivel = cmbnivel.Text
                        empresa.gravar(ficheiro)
                        Formutilizadores.refreshform()
                        Me.Close()
                    Else
                        _utilizador = New Classeutilizador(txbUtilizador.Text, txbchave.Text, cmbnivel.Text)

                        empresa.Utilizadores.Add(_utilizador)
                        empresa.gravar(ficheiro)
                        Formutilizadores.refreshform()
                        Me.Close()
                    End If

                End If
            End If
        End If




    End Sub

    Private Sub cmbnivel_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbnivel.SelectedIndexChanged
        If cmbnivel.Text = 1 Then
            txbcliente.Visible = True
            lbcliente.Visible = True
            btnnovocliente.Visible = True
        Else
            txbcliente.Visible = False
            lbcliente.Visible = False
            btnnovocliente.Visible = False
        End If
    End Sub

    Private Sub FormNovoUtilizador_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txbcliente.Visible = False
        lbcliente.Visible = False
        btnnovocliente.Visible = False
        If ativo >= 0 Then
            txbUtilizador.Text = empresa.Utilizadores.item(ativo).Utilizador
            txbchave.Text = empresa.Utilizadores.item(ativo).Chave
            cmbnivel.Text = empresa.Utilizadores.item(ativo).Nivel
            If empresa.Utilizadores.item(ativo).Nivel > 1 Then
                txbcliente.Visible = False
                lbcliente.Visible = False
            Else
                txbcliente.Text = empresa.Utilizadores.item(ativo).Cliente.Nif
            End If

            btAdicionar.Text = "Guardar"
            btnnovocliente.Visible = False
        End If
        If login = True Then
            cmbnivel.Text = 1
            cmbnivel.Visible = False
            Label3.Visible = False
            btnnovocliente.Visible = True
        End If
    End Sub

    Private Sub btnnovocliente_Click(sender As Object, e As EventArgs) Handles btnnovocliente.Click
        FormNovoCliente.login = True
        FormNovoCliente.Show()
    End Sub
End Class