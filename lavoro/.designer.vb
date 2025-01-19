<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormALuguer
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtReserva = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtCliente = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtLugares = New System.Windows.Forms.TextBox()
        Me.txtTransmissao = New System.Windows.Forms.TextBox()
        Me.txtPortas = New System.Windows.Forms.TextBox()
        Me.txtMala = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.chkSeguro = New System.Windows.Forms.CheckBox()
        Me.txtPrecoFinal = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.btnConfirmar = New System.Windows.Forms.Button()
        Me.datDataInicio = New System.Windows.Forms.DateTimePicker()
        Me.datDataFim = New System.Windows.Forms.DateTimePicker()
        Me.btnReserva = New System.Windows.Forms.Button()
        Me.btnCliente = New System.Windows.Forms.Button()
        Me.lvwVeiculos = New System.Windows.Forms.ListView()
        Me.txtNif = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.cmbClasse = New System.Windows.Forms.ComboBox()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(26, 25)
        Me.Label1.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(98, 25)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Reserva:"
        '
        'txtReserva
        '
        Me.txtReserva.Location = New System.Drawing.Point(138, 19)
        Me.txtReserva.Margin = New System.Windows.Forms.Padding(6)
        Me.txtReserva.Name = "txtReserva"
        Me.txtReserva.Size = New System.Drawing.Size(320, 31)
        Me.txtReserva.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(26, 340)
        Me.Label2.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(179, 25)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Veículo a atribuir:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(26, 102)
        Me.Label3.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(119, 25)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Data Início:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(500, 102)
        Me.Label4.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(104, 25)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "Data Fim:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(26, 162)
        Me.Label5.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(161, 25)
        Me.Label5.TabIndex = 6
        Me.Label5.Text = "Classe Veículo:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(520, 162)
        Me.Label6.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(85, 25)
        Me.Label6.TabIndex = 8
        Me.Label6.Text = "Cliente:"
        '
        'txtCliente
        '
        Me.txtCliente.Location = New System.Drawing.Point(616, 156)
        Me.txtCliente.Margin = New System.Windows.Forms.Padding(6)
        Me.txtCliente.Name = "txtCliente"
        Me.txtCliente.Size = New System.Drawing.Size(280, 31)
        Me.txtCliente.TabIndex = 9
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(24, 229)
        Me.Label7.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(96, 25)
        Me.Label7.TabIndex = 10
        Me.Label7.Text = "Lugares:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(24, 288)
        Me.Label8.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(80, 25)
        Me.Label8.TabIndex = 11
        Me.Label8.Text = "Portas:"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(216, 229)
        Me.Label9.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(141, 25)
        Me.Label9.TabIndex = 12
        Me.Label9.Text = "Transmissão:"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(192, 288)
        Me.Label10.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(161, 25)
        Me.Label10.TabIndex = 13
        Me.Label10.Text = "Tamanho Mala:"
        '
        'txtLugares
        '
        Me.txtLugares.Location = New System.Drawing.Point(132, 223)
        Me.txtLugares.Margin = New System.Windows.Forms.Padding(6)
        Me.txtLugares.Name = "txtLugares"
        Me.txtLugares.Size = New System.Drawing.Size(52, 31)
        Me.txtLugares.TabIndex = 14
        '
        'txtTransmissao
        '
        Me.txtTransmissao.Location = New System.Drawing.Point(357, 223)
        Me.txtTransmissao.Margin = New System.Windows.Forms.Padding(6)
        Me.txtTransmissao.Name = "txtTransmissao"
        Me.txtTransmissao.Size = New System.Drawing.Size(101, 31)
        Me.txtTransmissao.TabIndex = 15
        '
        'txtPortas
        '
        Me.txtPortas.Location = New System.Drawing.Point(132, 283)
        Me.txtPortas.Margin = New System.Windows.Forms.Padding(6)
        Me.txtPortas.Name = "txtPortas"
        Me.txtPortas.Size = New System.Drawing.Size(52, 31)
        Me.txtPortas.TabIndex = 16
        '
        'txtMala
        '
        Me.txtMala.Location = New System.Drawing.Point(357, 283)
        Me.txtMala.Margin = New System.Windows.Forms.Padding(6)
        Me.txtMala.Name = "txtMala"
        Me.txtMala.Size = New System.Drawing.Size(101, 31)
        Me.txtMala.TabIndex = 17
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(26, 667)
        Me.Label11.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(0, 25)
        Me.Label11.TabIndex = 18
        '
        'chkSeguro
        '
        Me.chkSeguro.AutoSize = True
        Me.chkSeguro.Location = New System.Drawing.Point(106, 633)
        Me.chkSeguro.Margin = New System.Windows.Forms.Padding(6)
        Me.chkSeguro.Name = "chkSeguro"
        Me.chkSeguro.Size = New System.Drawing.Size(125, 29)
        Me.chkSeguro.TabIndex = 19
        Me.chkSeguro.Text = "Seguro?"
        Me.chkSeguro.UseVisualStyleBackColor = True
        '
        'txtPrecoFinal
        '
        Me.txtPrecoFinal.Location = New System.Drawing.Point(438, 629)
        Me.txtPrecoFinal.Margin = New System.Windows.Forms.Padding(6)
        Me.txtPrecoFinal.Name = "txtPrecoFinal"
        Me.txtPrecoFinal.Size = New System.Drawing.Size(280, 31)
        Me.txtPrecoFinal.TabIndex = 21
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(298, 635)
        Me.Label12.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(127, 25)
        Me.Label12.TabIndex = 20
        Me.Label12.Text = "Preço Final:"
        '
        'btnConfirmar
        '
        Me.btnConfirmar.Location = New System.Drawing.Point(750, 625)
        Me.btnConfirmar.Margin = New System.Windows.Forms.Padding(6)
        Me.btnConfirmar.Name = "btnConfirmar"
        Me.btnConfirmar.Size = New System.Drawing.Size(150, 44)
        Me.btnConfirmar.TabIndex = 22
        Me.btnConfirmar.Text = "Confirmar"
        Me.btnConfirmar.UseVisualStyleBackColor = True
        '
        'datDataInicio
        '
        Me.datDataInicio.Location = New System.Drawing.Point(164, 90)
        Me.datDataInicio.Margin = New System.Windows.Forms.Padding(6)
        Me.datDataInicio.Name = "datDataInicio"
        Me.datDataInicio.Size = New System.Drawing.Size(294, 31)
        Me.datDataInicio.TabIndex = 23
        '
        'datDataFim
        '
        Me.datDataFim.Location = New System.Drawing.Point(616, 90)
        Me.datDataFim.Margin = New System.Windows.Forms.Padding(6)
        Me.datDataFim.Name = "datDataFim"
        Me.datDataFim.Size = New System.Drawing.Size(280, 31)
        Me.datDataFim.TabIndex = 24
        '
        'btnReserva
        '
        Me.btnReserva.Location = New System.Drawing.Point(474, 13)
        Me.btnReserva.Margin = New System.Windows.Forms.Padding(6)
        Me.btnReserva.Name = "btnReserva"
        Me.btnReserva.Size = New System.Drawing.Size(150, 44)
        Me.btnReserva.TabIndex = 25
        Me.btnReserva.Text = "Verificar"
        Me.btnReserva.UseVisualStyleBackColor = True
        '
        'btnCliente
        '
        Me.btnCliente.Location = New System.Drawing.Point(616, 253)
        Me.btnCliente.Margin = New System.Windows.Forms.Padding(6)
        Me.btnCliente.Name = "btnCliente"
        Me.btnCliente.Size = New System.Drawing.Size(202, 44)
        Me.btnCliente.TabIndex = 26
        Me.btnCliente.Text = "Novo Cliente"
        Me.btnCliente.UseVisualStyleBackColor = True
        '
        'lvwVeiculos
        '
        Me.lvwVeiculos.FullRowSelect = True
        Me.lvwVeiculos.HideSelection = False
        Me.lvwVeiculos.Location = New System.Drawing.Point(31, 369)
        Me.lvwVeiculos.Name = "lvwVeiculos"
        Me.lvwVeiculos.Size = New System.Drawing.Size(869, 247)
        Me.lvwVeiculos.TabIndex = 27
        Me.lvwVeiculos.UseCompatibleStateImageBehavior = False
        Me.lvwVeiculos.View = System.Windows.Forms.View.Details
        '
        'txtNif
        '
        Me.txtNif.Location = New System.Drawing.Point(616, 199)
        Me.txtNif.Margin = New System.Windows.Forms.Padding(6)
        Me.txtNif.Name = "txtNif"
        Me.txtNif.Size = New System.Drawing.Size(280, 31)
        Me.txtNif.TabIndex = 29
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(553, 202)
        Me.Label13.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(51, 25)
        Me.Label13.TabIndex = 28
        Me.Label13.Text = "NIF:"
        '
        'cmbClasse
        '
        Me.cmbClasse.FormattingEnabled = True
        Me.cmbClasse.Location = New System.Drawing.Point(197, 156)
        Me.cmbClasse.Name = "cmbClasse"
        Me.cmbClasse.Size = New System.Drawing.Size(261, 33)
        Me.cmbClasse.TabIndex = 30
        '
        'FormALuguer
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(924, 700)
        Me.Controls.Add(Me.cmbClasse)
        Me.Controls.Add(Me.txtNif)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.lvwVeiculos)
        Me.Controls.Add(Me.btnCliente)
        Me.Controls.Add(Me.btnReserva)
        Me.Controls.Add(Me.datDataFim)
        Me.Controls.Add(Me.datDataInicio)
        Me.Controls.Add(Me.btnConfirmar)
        Me.Controls.Add(Me.txtPrecoFinal)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.chkSeguro)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.txtMala)
        Me.Controls.Add(Me.txtPortas)
        Me.Controls.Add(Me.txtTransmissao)
        Me.Controls.Add(Me.txtLugares)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.txtCliente)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtReserva)
        Me.Controls.Add(Me.Label1)
        Me.Margin = New System.Windows.Forms.Padding(6)
        Me.Name = "FormALuguer"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents txtReserva As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents txtCliente As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents txtLugares As TextBox
    Friend WithEvents txtTransmissao As TextBox
    Friend WithEvents txtPortas As TextBox
    Friend WithEvents txtMala As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents chkSeguro As CheckBox
    Friend WithEvents txtPrecoFinal As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents btnConfirmar As Button
    Friend WithEvents datDataInicio As DateTimePicker
    Friend WithEvents datDataFim As DateTimePicker
    Friend WithEvents btnReserva As Button
    Friend WithEvents btnCliente As Button
    Friend WithEvents lvwVeiculos As ListView
    Friend WithEvents txtNif As TextBox
    Friend WithEvents Label13 As Label
    Friend WithEvents cmbClasse As ComboBox
End Class
