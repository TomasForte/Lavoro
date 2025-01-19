Public Class FormPrincipal
    Public nivel As Integer = -1
    Public index As Integer = -1
    Private Sub btnNovaReserva_Click(sender As Object, e As EventArgs) Handles btnNovaReserva.Click
        FormReserva.index = index
        FormReserva.nivel = nivel
        FormReserva.Show()

    End Sub
    Private WithEvents Login As FormLogin

    Private Sub FormPrincipal_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        VarGlobal.InitVars()
        Login = New FormLogin
        Login.ShowDialog()
        If nivel < 0 Then
            Me.Close()
        End If
        If nivel > 1 Then
            ListView1.Columns.Add("Cliente", 110, HorizontalAlignment.Left)
            ListView1.Columns.Add("Classe", 50, HorizontalAlignment.Left)
            ListView1.Columns.Add("Data inicial", 100, HorizontalAlignment.Left)
            ListView1.Columns.Add("Data final", 100, HorizontalAlignment.Left)

            For Each registo As Registo In empresa.Registos
                If registo.Estado = "Reserva" Then
                    If registo.Datainicio.Date = Today Then
                        ListView1.Items.Add(New ListViewItem({registo.Cliente.Nome, registo.Classeveiculo.Classe, registo.Datainicio.Date, registo.Datafim.Date}))
                    End If
                End If
            Next
        Else
            Label1.Visible = False
            ListView1.Visible = False
        End If


    End Sub

    Private Sub btnClientes_Click(sender As Object, e As EventArgs) Handles btnClientes.Click
        FormClientes.Show()

    End Sub

    Private Sub btnNovoAluguer_Click(sender As Object, e As EventArgs) Handles btnNovoAluguer.Click
        FormALuguer.Show()

    End Sub

    Private Sub btnFrota_Click(sender As Object, e As EventArgs) Handles btnFrota.Click
        FormFrota.nivel = nivel
        FormFrota.Show()
    End Sub

    Private Sub btnRegistos_Click(sender As Object, e As EventArgs) Handles btnRegistos.Click
        FormRegistos.Show()

    End Sub
    Private Sub LoginOK(ByVal NomeUser As String, ByVal Nivel As Integer, ByVal index As Integer) Handles Login.LoginOK
        MsgBox("Olá " & NomeUser & " de Nivel " & Nivel)
        refreshform(Nivel)

    End Sub
    Private Sub loginCancel(ByVal NomeUser As String, ByVal Erro As String) Handles Login.LoginErro
        MsgBox(NomeUser & " - " & Erro)
        Me.Close()
    End Sub

    Private Sub btutilizadores_Click(sender As Object, e As EventArgs) Handles btutilizadores.Click
        Formutilizadores.Show()
    End Sub
    Private Sub refreshform(ByVal nivel As Integer)
        If nivel = 1 Then
            btutilizadores.Visible = False
            btnFrota.Visible = False
            btnClientes.Visible = False
            btnNovoAluguer.Visible = False
            btnRegistos.Visible = False
        End If
        If nivel = 2 Then
            btutilizadores.Visible = False
        End If
    End Sub
End Class