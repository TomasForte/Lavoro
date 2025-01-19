<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormReserva
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.btnConcluir = New System.Windows.Forms.Button()
        Me.lblDataInicio = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.cmbClasseVeiculo = New System.Windows.Forms.ComboBox()
        Me.dtpDataInicio = New System.Windows.Forms.DateTimePicker()
        Me.dtpDataFim = New System.Windows.Forms.DateTimePicker()
        Me.txtMala = New System.Windows.Forms.TextBox()
        Me.txtTrans = New System.Windows.Forms.TextBox()
        Me.txtLugares = New System.Windows.Forms.TextBox()
        Me.txtPreco = New System.Windows.Forms.TextBox()
        Me.txtPortas = New System.Windows.Forms.TextBox()
        Me.txtNome = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.btnNovoCliente = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txtIdade = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.txtDataNasc = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtNif = New System.Windows.Forms.TextBox()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnConcluir
        '
        Me.btnConcluir.Location = New System.Drawing.Point(443, 304)
        Me.btnConcluir.Name = "btnConcluir"
        Me.btnConcluir.Size = New System.Drawing.Size(80, 34)
        Me.btnConcluir.TabIndex = 1
        Me.btnConcluir.Text = "Concluir"
        Me.btnConcluir.UseVisualStyleBackColor = True
        '
        'lblDataInicio
        '
        Me.lblDataInicio.AutoSize = True
        Me.lblDataInicio.Location = New System.Drawing.Point(19, 35)
        Me.lblDataInicio.Name = "lblDataInicio"
        Me.lblDataInicio.Size = New System.Drawing.Size(63, 13)
        Me.lblDataInicio.TabIndex = 2
        Me.lblDataInicio.Text = "Data Início:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(19, 27)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(80, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Classe veículo:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(270, 35)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(52, 13)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Data Fim:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(186, 58)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(38, 13)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "Malas:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(332, 25)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(69, 13)
        Me.Label5.TabIndex = 6
        Me.Label5.Text = "Transmissão:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(176, 27)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(48, 13)
        Me.Label6.TabIndex = 7
        Me.Label6.Text = "Lugares:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(362, 58)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(40, 13)
        Me.Label7.TabIndex = 8
        Me.Label7.Text = "Portas:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(36, 304)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(35, 13)
        Me.Label8.TabIndex = 9
        Me.Label8.Text = "Preço"
        '
        'cmbClasseVeiculo
        '
        Me.cmbClasseVeiculo.FormattingEnabled = True
        Me.cmbClasseVeiculo.Location = New System.Drawing.Point(101, 25)
        Me.cmbClasseVeiculo.Name = "cmbClasseVeiculo"
        Me.cmbClasseVeiculo.Size = New System.Drawing.Size(70, 21)
        Me.cmbClasseVeiculo.TabIndex = 11
        '
        'dtpDataInicio
        '
        Me.dtpDataInicio.Location = New System.Drawing.Point(84, 33)
        Me.dtpDataInicio.Name = "dtpDataInicio"
        Me.dtpDataInicio.Size = New System.Drawing.Size(162, 20)
        Me.dtpDataInicio.TabIndex = 12
        '
        'dtpDataFim
        '
        Me.dtpDataFim.Location = New System.Drawing.Point(324, 33)
        Me.dtpDataFim.Name = "dtpDataFim"
        Me.dtpDataFim.Size = New System.Drawing.Size(161, 20)
        Me.dtpDataFim.TabIndex = 13
        '
        'txtMala
        '
        Me.txtMala.Location = New System.Drawing.Point(230, 57)
        Me.txtMala.Name = "txtMala"
        Me.txtMala.Size = New System.Drawing.Size(100, 20)
        Me.txtMala.TabIndex = 14
        '
        'txtTrans
        '
        Me.txtTrans.Location = New System.Drawing.Point(408, 23)
        Me.txtTrans.Name = "txtTrans"
        Me.txtTrans.Size = New System.Drawing.Size(100, 20)
        Me.txtTrans.TabIndex = 15
        '
        'txtLugares
        '
        Me.txtLugares.Location = New System.Drawing.Point(230, 25)
        Me.txtLugares.Name = "txtLugares"
        Me.txtLugares.Size = New System.Drawing.Size(100, 20)
        Me.txtLugares.TabIndex = 16
        '
        'txtPreco
        '
        Me.txtPreco.Location = New System.Drawing.Point(88, 302)
        Me.txtPreco.Name = "txtPreco"
        Me.txtPreco.Size = New System.Drawing.Size(100, 20)
        Me.txtPreco.TabIndex = 18
        '
        'txtPortas
        '
        Me.txtPortas.Location = New System.Drawing.Point(408, 57)
        Me.txtPortas.Name = "txtPortas"
        Me.txtPortas.Size = New System.Drawing.Size(100, 20)
        Me.txtPortas.TabIndex = 19
        '
        'txtNome
        '
        Me.txtNome.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.txtNome.Location = New System.Drawing.Point(60, 21)
        Me.txtNome.Name = "txtNome"
        Me.txtNome.Size = New System.Drawing.Size(146, 20)
        Me.txtNome.TabIndex = 20
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(18, 24)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(38, 13)
        Me.Label9.TabIndex = 21
        Me.Label9.Text = "Nome:"
        '
        'btnNovoCliente
        '
        Me.btnNovoCliente.Location = New System.Drawing.Point(382, 21)
        Me.btnNovoCliente.Name = "btnNovoCliente"
        Me.btnNovoCliente.Size = New System.Drawing.Size(100, 28)
        Me.btnNovoCliente.TabIndex = 22
        Me.btnNovoCliente.Text = "Novo Cliente"
        Me.btnNovoCliente.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.dtpDataFim)
        Me.GroupBox1.Controls.Add(Me.dtpDataInicio)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.lblDataInicio)
        Me.GroupBox1.Location = New System.Drawing.Point(17, 14)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.GroupBox1.Size = New System.Drawing.Size(526, 73)
        Me.GroupBox1.TabIndex = 23
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Datas"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.txtPortas)
        Me.GroupBox2.Controls.Add(Me.txtLugares)
        Me.GroupBox2.Controls.Add(Me.txtTrans)
        Me.GroupBox2.Controls.Add(Me.txtMala)
        Me.GroupBox2.Controls.Add(Me.cmbClasseVeiculo)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Location = New System.Drawing.Point(17, 194)
        Me.GroupBox2.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Padding = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.GroupBox2.Size = New System.Drawing.Size(526, 94)
        Me.GroupBox2.TabIndex = 24
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Veículo"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.Label11)
        Me.GroupBox3.Controls.Add(Me.txtIdade)
        Me.GroupBox3.Controls.Add(Me.Label12)
        Me.GroupBox3.Controls.Add(Me.txtDataNasc)
        Me.GroupBox3.Controls.Add(Me.Label10)
        Me.GroupBox3.Controls.Add(Me.txtNif)
        Me.GroupBox3.Controls.Add(Me.btnNovoCliente)
        Me.GroupBox3.Controls.Add(Me.Label9)
        Me.GroupBox3.Controls.Add(Me.txtNome)
        Me.GroupBox3.Location = New System.Drawing.Point(19, 94)
        Me.GroupBox3.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Padding = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.GroupBox3.Size = New System.Drawing.Size(524, 89)
        Me.GroupBox3.TabIndex = 25
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Cliente"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(268, 52)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(37, 13)
        Me.Label11.TabIndex = 28
        Me.Label11.Text = "Idade:"
        '
        'txtIdade
        '
        Me.txtIdade.Enabled = False
        Me.txtIdade.Location = New System.Drawing.Point(316, 50)
        Me.txtIdade.Name = "txtIdade"
        Me.txtIdade.Size = New System.Drawing.Size(40, 20)
        Me.txtIdade.TabIndex = 27
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(18, 55)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(107, 13)
        Me.Label12.TabIndex = 26
        Me.Label12.Text = "Data de Nascimento:"
        '
        'txtDataNasc
        '
        Me.txtDataNasc.Location = New System.Drawing.Point(130, 52)
        Me.txtDataNasc.Name = "txtDataNasc"
        Me.txtDataNasc.Size = New System.Drawing.Size(108, 20)
        Me.txtDataNasc.TabIndex = 25
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(210, 23)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(27, 13)
        Me.Label10.TabIndex = 24
        Me.Label10.Text = "NIF:"
        '
        'txtNif
        '
        Me.txtNif.Location = New System.Drawing.Point(242, 21)
        Me.txtNif.Name = "txtNif"
        Me.txtNif.Size = New System.Drawing.Size(115, 20)
        Me.txtNif.TabIndex = 23
        '
        'FormReserva
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(561, 366)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.txtPreco)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btnConcluir)
        Me.Controls.Add(Me.Label8)
        Me.Name = "FormReserva"
        Me.Text = "FormReserva"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnConcluir As Button
    Friend WithEvents lblDataInicio As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents cmbClasseVeiculo As ComboBox
    Friend WithEvents dtpDataInicio As DateTimePicker
    Friend WithEvents dtpDataFim As DateTimePicker
    Friend WithEvents txtMala As TextBox
    Friend WithEvents txtTrans As TextBox
    Friend WithEvents txtLugares As TextBox
    Friend WithEvents txtPreco As TextBox
    Friend WithEvents txtPortas As TextBox
    Friend WithEvents txtNome As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents btnNovoCliente As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents Label10 As Label
    Friend WithEvents txtNif As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents txtIdade As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents txtDataNasc As TextBox
End Class
