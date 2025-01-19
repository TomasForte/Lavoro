<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Formveiculoinfo
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Txbmatricula = New System.Windows.Forms.TextBox()
        Me.Matrícula = New System.Windows.Forms.Label()
        Me.cmbClasse = New System.Windows.Forms.ComboBox()
        Me.cmbTransm = New System.Windows.Forms.ComboBox()
        Me.cmbCombustivel = New System.Windows.Forms.ComboBox()
        Me.txbNumPortas = New System.Windows.Forms.TextBox()
        Me.txbNumLugares = New System.Windows.Forms.TextBox()
        Me.txbModelo = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.ListView1 = New System.Windows.Forms.ListView()
        Me.SuspendLayout()
        '
        'Txbmatricula
        '
        Me.Txbmatricula.Location = New System.Drawing.Point(166, 246)
        Me.Txbmatricula.Margin = New System.Windows.Forms.Padding(2)
        Me.Txbmatricula.Name = "Txbmatricula"
        Me.Txbmatricula.Size = New System.Drawing.Size(143, 20)
        Me.Txbmatricula.TabIndex = 52
        '
        'Matrícula
        '
        Me.Matrícula.AutoSize = True
        Me.Matrícula.Location = New System.Drawing.Point(40, 249)
        Me.Matrícula.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Matrícula.Name = "Matrícula"
        Me.Matrícula.Size = New System.Drawing.Size(52, 13)
        Me.Matrícula.TabIndex = 51
        Me.Matrícula.Text = "Matrícula"
        '
        'cmbClasse
        '
        Me.cmbClasse.FormattingEnabled = True
        Me.cmbClasse.Location = New System.Drawing.Point(165, 212)
        Me.cmbClasse.Margin = New System.Windows.Forms.Padding(2)
        Me.cmbClasse.Name = "cmbClasse"
        Me.cmbClasse.Size = New System.Drawing.Size(144, 21)
        Me.cmbClasse.TabIndex = 47
        '
        'cmbTransm
        '
        Me.cmbTransm.FormattingEnabled = True
        Me.cmbTransm.Items.AddRange(New Object() {"Manual", "Automático"})
        Me.cmbTransm.Location = New System.Drawing.Point(164, 136)
        Me.cmbTransm.Margin = New System.Windows.Forms.Padding(2)
        Me.cmbTransm.Name = "cmbTransm"
        Me.cmbTransm.Size = New System.Drawing.Size(144, 21)
        Me.cmbTransm.TabIndex = 46
        '
        'cmbCombustivel
        '
        Me.cmbCombustivel.FormattingEnabled = True
        Me.cmbCombustivel.Items.AddRange(New Object() {"Diesel", "Gasolina"})
        Me.cmbCombustivel.Location = New System.Drawing.Point(165, 173)
        Me.cmbCombustivel.Margin = New System.Windows.Forms.Padding(2)
        Me.cmbCombustivel.Name = "cmbCombustivel"
        Me.cmbCombustivel.Size = New System.Drawing.Size(144, 21)
        Me.cmbCombustivel.TabIndex = 45
        '
        'txbNumPortas
        '
        Me.txbNumPortas.Location = New System.Drawing.Point(165, 99)
        Me.txbNumPortas.Margin = New System.Windows.Forms.Padding(2)
        Me.txbNumPortas.Name = "txbNumPortas"
        Me.txbNumPortas.Size = New System.Drawing.Size(144, 20)
        Me.txbNumPortas.TabIndex = 44
        '
        'txbNumLugares
        '
        Me.txbNumLugares.Location = New System.Drawing.Point(165, 64)
        Me.txbNumLugares.Margin = New System.Windows.Forms.Padding(2)
        Me.txbNumLugares.Name = "txbNumLugares"
        Me.txbNumLugares.Size = New System.Drawing.Size(144, 20)
        Me.txbNumLugares.TabIndex = 43
        '
        'txbModelo
        '
        Me.txbModelo.Location = New System.Drawing.Point(165, 25)
        Me.txbModelo.Margin = New System.Windows.Forms.Padding(2)
        Me.txbModelo.Name = "txbModelo"
        Me.txbModelo.Size = New System.Drawing.Size(144, 20)
        Me.txbModelo.TabIndex = 42
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(39, 214)
        Me.Label6.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(93, 13)
        Me.Label6.TabIndex = 41
        Me.Label6.Text = "Classe do Veículo"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(39, 175)
        Me.Label5.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(66, 13)
        Me.Label5.TabIndex = 40
        Me.Label5.Text = "Combustível"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(39, 139)
        Me.Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(66, 13)
        Me.Label4.TabIndex = 39
        Me.Label4.Text = "Transmissão"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(39, 102)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(92, 13)
        Me.Label3.TabIndex = 38
        Me.Label3.Text = "Número de Portas"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(39, 68)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(100, 13)
        Me.Label2.TabIndex = 37
        Me.Label2.Text = "Número de Lugares"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(39, 28)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(42, 13)
        Me.Label1.TabIndex = 36
        Me.Label1.Text = "Modelo"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(176, 314)
        Me.Button1.Margin = New System.Windows.Forms.Padding(2)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(103, 30)
        Me.Button1.TabIndex = 35
        Me.Button1.Text = "Guardar"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'ListView1
        '
        Me.ListView1.Location = New System.Drawing.Point(429, 25)
        Me.ListView1.Name = "ListView1"
        Me.ListView1.Size = New System.Drawing.Size(359, 288)
        Me.ListView1.TabIndex = 53
        Me.ListView1.UseCompatibleStateImageBehavior = False
        '
        'Formveiculoinfo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.ListView1)
        Me.Controls.Add(Me.Txbmatricula)
        Me.Controls.Add(Me.Matrícula)
        Me.Controls.Add(Me.cmbClasse)
        Me.Controls.Add(Me.cmbTransm)
        Me.Controls.Add(Me.cmbCombustivel)
        Me.Controls.Add(Me.txbNumPortas)
        Me.Controls.Add(Me.txbNumLugares)
        Me.Controls.Add(Me.txbModelo)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button1)
        Me.Name = "Formveiculoinfo"
        Me.Text = "Form"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Txbmatricula As TextBox
    Friend WithEvents Matrícula As Label
    Friend WithEvents cmbClasse As ComboBox
    Friend WithEvents cmbTransm As ComboBox
    Friend WithEvents cmbCombustivel As ComboBox
    Friend WithEvents txbNumPortas As TextBox
    Friend WithEvents txbNumLugares As TextBox
    Friend WithEvents txbModelo As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents ListView1 As ListView
End Class
