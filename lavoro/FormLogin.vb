Public Class FormLogin
    Public Event LoginOK(ByVal NomeUser As String, ByVal Nivel As Integer, ByVal index As Integer)
    Public Event LoginErro(ByVal NomeUser As String, ByVal Erro As String)

    Private _loginok As Boolean = False
    Private Sub LoginForm_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing

    End Sub

    Private Sub ValidaLogin(ByVal NomeUser As String, ByVal Password As String, ByRef loginok As Boolean, ByRef Nivel As Integer, ByRef index As Integer)
        For i = 0 To empresa.Utilizadores.Count - 1
            If NomeUser = empresa.Utilizadores.item(i).Utilizador And Password = empresa.Utilizadores.item(i).Chave Then
                loginok = True
                Nivel = empresa.Utilizadores.item(i).Nivel
                index = i

                Exit For
            End If
        Next
    End Sub

    Private Sub Btentar_Click(sender As Object, e As EventArgs) Handles Btentar.Click

        entrar()

    End Sub

    Private Sub Btcancelar_Click(sender As Object, e As EventArgs) Handles Btcancelar.Click
        _loginok = False
        RaiseEvent LoginErro(Me.txbUtilizdor.Text, "Login Cancelado")
        Me.Close()
    End Sub

    Private Sub FormLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub entrar()
        Dim loginok As Boolean
        Dim Nivel As Integer
        Dim index As Integer

        ValidaLogin(Me.txbUtilizdor.Text, Me.txbChave.Text, loginok, Nivel, index)
        _loginok = loginok

        If _loginok = True Then
            RaiseEvent loginok(Me.txbUtilizdor.Text, Nivel, index)
            FormPrincipal.nivel = Nivel
            FormPrincipal.index = index
            Me.Close()
        Else
            MsgBox("Login Errado")

        End If
    End Sub


    Private Sub txbChave_KeyDown(sender As Object, e As KeyEventArgs) Handles txbChave.KeyDown
        If e.KeyCode = Keys.Enter Then
            entrar()
        End If
    End Sub

    Private Sub btnregistrar_Click(sender As Object, e As EventArgs) Handles btnregistrar.Click
        FormNovoUtilizador.login = True
        FormNovoUtilizador.Show()
    End Sub
End Class