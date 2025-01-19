Public Class FormRegistos

    Private registoAtivo As Registo

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
    End Sub

    Private Sub FormRegistos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ListView1.Columns.Add("Código", 80, HorizontalAlignment.Left)
        ListView1.Columns.Add("Cliente", 110, HorizontalAlignment.Left)
        ListView1.Columns.Add("Classe", 50, HorizontalAlignment.Left)
        ListView1.Columns.Add("Data inicial", 80, HorizontalAlignment.Left)
        ListView1.Columns.Add("Data final", 80, HorizontalAlignment.Left)
        ListView1.Columns.Add("Estado", 80, HorizontalAlignment.Left)
        DateTimePicker1.CustomFormat = " "  'An empty SPACE
        DateTimePicker1.Format = DateTimePickerFormat.Custom

        DateTimePicker2.CustomFormat = " "  'An empty SPACE
        DateTimePicker2.Format = DateTimePickerFormat.Custom

        For Each classe As ClasseVeiculo In empresa.Classesveiculo
            cmbClasse.Items.Add(classe.Classe)
        Next

        For Each registo As Registo In empresa.Registos
            ListView1.Items.Add(New ListViewItem({registo.Codigo, registo.Cliente.Nome, registo.Classeveiculo.Classe, registo.Datainicio, registo.Datafim, registo.Estado}))
        Next


    End Sub



    'Private Sub ComboBox2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox2.SelectedIndexChanged

    '    ListView1.Items.Clear()
    '    For i = 0 To empresa.Registos.Count - 1
    '        If empresa.Registos.item(ComboBox2.SelectedIndex).Estado = empresa.Registos.item(i).Estado Then
    '            ListView1.Items.Add(New ListViewItem({empresa.Registos.item(i).Cliente.Nome, empresa.Registos.item(i).Classeveiculo.Classe, empresa.Registos.item(i).Datainicio, empresa.Registos.item(i).Datafim, empresa.Registos.item(i).Estado}))
    '        End If
    '    Next
    'End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        ListView1.Items.Clear()
        For i = 0 To empresa.Registos.Count - 1
            If empresa.Registos.item(i).Cliente.Nome.Contains(NomeTextBox.Text) Then
                If DateTimePicker1.CustomFormat = " " Then
                    If DateTimePicker2.CustomFormat = " " Then
                        If cmbEstado.Text <> "" Then
                            If empresa.Registos.item(i).Estado = cmbEstado.Text Then
                                If cmbClasse.Text <> "" Then

                                    If empresa.Registos.item(i).Classeveiculo.Classe = cmbClasse.Text Then
                                        ListView1.Items.Add(New ListViewItem({empresa.Registos.item(i).Codigo, empresa.Registos.item(i).Cliente.Nome, empresa.Registos.item(i).Classeveiculo.Classe, empresa.Registos.item(i).Datainicio, empresa.Registos.item(i).Datafim, empresa.Registos.item(i).Estado}))
                                    End If
                                Else

                                    ListView1.Items.Add(New ListViewItem({empresa.Registos.item(i).Codigo, empresa.Registos.item(i).Cliente.Nome, empresa.Registos.item(i).Classeveiculo.Classe, empresa.Registos.item(i).Datainicio, empresa.Registos.item(i).Datafim, empresa.Registos.item(i).Estado}))


                                End If

                            End If
                        Else
                            If cmbClasse.Text <> "" Then

                                If empresa.Registos.item(i).Classeveiculo.Classe = cmbClasse.Text Then
                                    ListView1.Items.Add(New ListViewItem({empresa.Registos.item(i).Codigo, empresa.Registos.item(i).Cliente.Nome, empresa.Registos.item(i).Classeveiculo.Classe, empresa.Registos.item(i).Datainicio, empresa.Registos.item(i).Datafim, empresa.Registos.item(i).Estado}))
                                End If
                            Else

                                ListView1.Items.Add(New ListViewItem({empresa.Registos.item(i).Codigo, empresa.Registos.item(i).Cliente.Nome, empresa.Registos.item(i).Classeveiculo.Classe, empresa.Registos.item(i).Datainicio, empresa.Registos.item(i).Datafim, empresa.Registos.item(i).Estado}))


                            End If

                        End If
                    Else

                        If empresa.Registos.item(i).Datafim <= DateTimePicker2.Value Then
                            If cmbEstado.Text <> "" Then
                                If empresa.Registos.item(i).Estado = cmbEstado.Text Then
                                    If cmbClasse.Text <> "" Then

                                        If empresa.Registos.item(i).Classeveiculo.Classe = cmbClasse.Text Then
                                            ListView1.Items.Add(New ListViewItem({empresa.Registos.item(i).Codigo, empresa.Registos.item(i).Cliente.Nome, empresa.Registos.item(i).Classeveiculo.Classe, empresa.Registos.item(i).Datainicio, empresa.Registos.item(i).Datafim, empresa.Registos.item(i).Estado}))
                                        End If
                                    Else

                                        ListView1.Items.Add(New ListViewItem({empresa.Registos.item(i).Codigo, empresa.Registos.item(i).Cliente.Nome, empresa.Registos.item(i).Classeveiculo.Classe, empresa.Registos.item(i).Datainicio, empresa.Registos.item(i).Datafim, empresa.Registos.item(i).Estado}))

                                    End If

                                End If
                            Else
                                If cmbClasse.Text <> "" Then

                                    If empresa.Registos.item(i).Classeveiculo.Classe = cmbClasse.Text Then
                                        ListView1.Items.Add(New ListViewItem({empresa.Registos.item(i).Codigo, empresa.Registos.item(i).Cliente.Nome, empresa.Registos.item(i).Classeveiculo.Classe, empresa.Registos.item(i).Datainicio, empresa.Registos.item(i).Datafim, empresa.Registos.item(i).Estado}))
                                    End If
                                Else

                                    ListView1.Items.Add(New ListViewItem({empresa.Registos.item(i).Codigo, empresa.Registos.item(i).Cliente.Nome, empresa.Registos.item(i).Classeveiculo.Classe, empresa.Registos.item(i).Datainicio, empresa.Registos.item(i).Datafim, empresa.Registos.item(i).Estado}))
                                End If

                            End If
                        End If
                    End If
                Else
                    If empresa.Registos.item(i).Datainicio >= DateTimePicker1.Value Then

                        If DateTimePicker2.CustomFormat = " " Then
                            If cmbEstado.Text <> "" Then
                                If empresa.Registos.item(i).Estado = cmbEstado.Text Then
                                    If cmbClasse.Text <> "" Then

                                        If empresa.Registos.item(i).Classeveiculo.Classe = cmbClasse.Text Then
                                            ListView1.Items.Add(New ListViewItem({empresa.Registos.item(i).Codigo, empresa.Registos.item(i).Cliente.Nome, empresa.Registos.item(i).Classeveiculo.Classe, empresa.Registos.item(i).Datainicio, empresa.Registos.item(i).Datafim, empresa.Registos.item(i).Estado}))
                                        End If
                                    Else

                                        ListView1.Items.Add(New ListViewItem({empresa.Registos.item(i).Codigo, empresa.Registos.item(i).Cliente.Nome, empresa.Registos.item(i).Classeveiculo.Classe, empresa.Registos.item(i).Datainicio, empresa.Registos.item(i).Datafim, empresa.Registos.item(i).Estado}))


                                    End If

                                End If
                            Else
                                If cmbClasse.Text <> "" Then

                                    If empresa.Registos.item(i).Classeveiculo.Classe = cmbClasse.Text Then
                                        ListView1.Items.Add(New ListViewItem({empresa.Registos.item(i).Codigo, empresa.Registos.item(i).Cliente.Nome, empresa.Registos.item(i).Classeveiculo.Classe, empresa.Registos.item(i).Datainicio, empresa.Registos.item(i).Datafim, empresa.Registos.item(i).Estado}))
                                    End If
                                Else

                                    ListView1.Items.Add(New ListViewItem({empresa.Registos.item(i).Codigo, empresa.Registos.item(i).Cliente.Nome, empresa.Registos.item(i).Classeveiculo.Classe, empresa.Registos.item(i).Datainicio, empresa.Registos.item(i).Datafim, empresa.Registos.item(i).Estado}))


                                End If

                            End If
                        Else

                            If empresa.Registos.item(i).Datafim <= DateTimePicker2.Value Then
                                If cmbEstado.Text <> "" Then
                                    If empresa.Registos.item(i).Estado = cmbEstado.Text Then
                                        If cmbClasse.Text <> "" Then

                                            If empresa.Registos.item(i).Classeveiculo.Classe = cmbClasse.Text Then
                                                ListView1.Items.Add(New ListViewItem({empresa.Registos.item(i).Codigo, empresa.Registos.item(i).Cliente.Nome, empresa.Registos.item(i).Classeveiculo.Classe, empresa.Registos.item(i).Datainicio, empresa.Registos.item(i).Datafim, empresa.Registos.item(i).Estado}))
                                            End If
                                        Else

                                            ListView1.Items.Add(New ListViewItem({empresa.Registos.item(i).Codigo, empresa.Registos.item(i).Cliente.Nome, empresa.Registos.item(i).Classeveiculo.Classe, empresa.Registos.item(i).Datainicio, empresa.Registos.item(i).Datafim, empresa.Registos.item(i).Estado}))

                                        End If

                                    End If
                                Else
                                    If cmbClasse.Text <> "" Then

                                        If empresa.Registos.item(i).Classeveiculo.Classe = cmbClasse.Text Then
                                            ListView1.Items.Add(New ListViewItem({empresa.Registos.item(i).Codigo, empresa.Registos.item(i).Cliente.Nome, empresa.Registos.item(i).Classeveiculo.Classe, empresa.Registos.item(i).Datainicio, empresa.Registos.item(i).Datafim, empresa.Registos.item(i).Estado}))
                                        End If
                                    Else

                                        ListView1.Items.Add(New ListViewItem({empresa.Registos.item(i).Codigo, empresa.Registos.item(i).Cliente.Nome, empresa.Registos.item(i).Classeveiculo.Classe, empresa.Registos.item(i).Datainicio, empresa.Registos.item(i).Datafim, empresa.Registos.item(i).Estado}))
                                    End If

                                End If
                            End If
                        End If
                    End If
                End If



            End If
        Next
    End Sub

    Private Sub DateTimePicker1_ValueChanged(sender As Object, e As EventArgs) Handles DateTimePicker1.ValueChanged
        DateTimePicker1.CustomFormat = "dd-MM-yyyy"
    End Sub

    Private Sub DateTimePicker2_ValueChanged(sender As Object, e As EventArgs) Handles DateTimePicker2.ValueChanged
        DateTimePicker2.CustomFormat = "dd-MM-yyyy"
    End Sub

    Private Sub btnCancelarReserva_Click(sender As Object, e As EventArgs) Handles btnCancelarReserva.Click
        If registoAtivo Is Nothing Then
            MsgBox("Selecionar uma reserva primeiro.")
        ElseIf registoAtivo.Estado <> "Reserva" Then
            MsgBox("Apenas é possível cancelar reservas.")
        Else
            registoAtivo.CancelReserva()
            empresa.gravar(ficheiro)
            MsgBox("Reserva cancelada com sucesso!")
            Button1.PerformClick()
        End If
    End Sub

    Private Sub ListView1_Click(sender As Object, e As EventArgs) Handles ListView1.Click
        For Each registo As Registo In empresa.Registos
            If registo.Codigo = ListView1.SelectedItems(0).SubItems(0).Text Then
                registoAtivo = registo
                Exit For
            End If
        Next

        If registoAtivo.Estado = "Reserva" Then
            btnCancelarReserva.Visible = True
        Else
            btnCancelarReserva.Visible = False
        End If

    End Sub
End Class