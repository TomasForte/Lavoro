Module VarGlobal
    Public empresa As New ClassEmpresa
    Public ficheiro As String
    Public epocaAlta As Boolean
    Public multTaxaOcup As Double(,)

    Public Sub InitVars()

        If Today.Month = 7 Or 8 Then
            epocaAlta = True
        End If

        gerarMultTaxaOcup()

        ficheiro = "OsMeusDados2.xml"

        Try
            empresa = empresa.ler(ficheiro)
        Catch ex As Exception
            empresa = New ClassEmpresa
        End Try



        'Dim i As Integer
        'i = empresa.Utilizadores.Count
        'i = empresa.clientes.Count
        'i = empresa.Registos.Count

    End Sub

    Public Function TaxaOcupacao(ByVal dataInicio As Date, ByVal dataFim As Date, ByVal classe As ClasseVeiculo) As Double
        Dim nOcup As Integer = 0
        Dim nCarrosClasse As Integer = 0

        For Each registo As Registo In empresa.Registos
            If registo.Classeveiculo Is classe Then
                If registo.Datainicio < dataFim And registo.Datafim > dataInicio Then
                    nOcup += 1
                End If
            End If
        Next

        For Each carro As Veiculo In empresa.Veiculos
            If carro.Classe Is classe Then
                nCarrosClasse += 1
            End If
        Next

        Return nOcup / nCarrosClasse


    End Function

    Private Sub gerarMultTaxaOcup()
        ReDim multTaxaOcup(4, 2)
        multTaxaOcup(1, 1) = 0.5
        multTaxaOcup(1, 2) = 0.5
        multTaxaOcup(2, 1) = 0.8
        multTaxaOcup(2, 2) = 1
        multTaxaOcup(3, 1) = 0.9
        multTaxaOcup(3, 2) = 1.5
        multTaxaOcup(4, 1) = 0.95
        multTaxaOcup(4, 2) = 2
    End Sub

End Module
