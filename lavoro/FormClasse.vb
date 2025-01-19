Public Class FormClasse
    Private Sub bt_adicionar_Click(sender As Object, e As EventArgs) Handles bt_adicionar.Click
        If TextBox1.Text <> "" And TextBox2.Text <> "" And TextBox3.Text <> "" And TextBox4.Text <> "" And TextBox5.Text <> "" And ComboBox1.Text <> "" Then
            Dim classe As ClasseVeiculo

            classe = New ClasseVeiculo(TextBox1.Text, TextBox2.Text, TextBox3.Text, TextBox4.Text, ComboBox1.Text, TextBox5.Text)
            empresa.Classesveiculo.Add(classe)
            gravar()
        End If


    End Sub
    Public Sub gravar()
        empresa.gravar(ficheiro)
    End Sub

    Private Sub FormClasse_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class