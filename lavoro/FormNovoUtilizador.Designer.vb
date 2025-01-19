<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormNovoUtilizador
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
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txbcliente = New System.Windows.Forms.TextBox()
        Me.cmbnivel = New System.Windows.Forms.ComboBox()
        Me.txbchave = New System.Windows.Forms.TextBox()
        Me.txbUtilizador = New System.Windows.Forms.TextBox()
        Me.btAdicionar = New System.Windows.Forms.Button()
        Me.lbcliente = New System.Windows.Forms.Label()
        Me.btnnovocliente = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(34, 167)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(31, 13)
        Me.Label3.TabIndex = 15
        Me.Label3.Text = "Nivel"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(34, 106)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(77, 13)
        Me.Label2.TabIndex = 14
        Me.Label2.Text = "Palavra-Chave"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(34, 48)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(81, 13)
        Me.Label1.TabIndex = 13
        Me.Label1.Text = "Nome Utilizador"
        '
        'txbcliente
        '
        Me.txbcliente.Location = New System.Drawing.Point(130, 206)
        Me.txbcliente.Name = "txbcliente"
        Me.txbcliente.Size = New System.Drawing.Size(187, 20)
        Me.txbcliente.TabIndex = 12
        '
        'cmbnivel
        '
        Me.cmbnivel.FormattingEnabled = True
        Me.cmbnivel.Items.AddRange(New Object() {"1", "2", "3"})
        Me.cmbnivel.Location = New System.Drawing.Point(130, 164)
        Me.cmbnivel.Name = "cmbnivel"
        Me.cmbnivel.Size = New System.Drawing.Size(187, 21)
        Me.cmbnivel.TabIndex = 11
        '
        'txbchave
        '
        Me.txbchave.Location = New System.Drawing.Point(130, 103)
        Me.txbchave.Name = "txbchave"
        Me.txbchave.Size = New System.Drawing.Size(187, 20)
        Me.txbchave.TabIndex = 10
        '
        'txbUtilizador
        '
        Me.txbUtilizador.Location = New System.Drawing.Point(130, 45)
        Me.txbUtilizador.Name = "txbUtilizador"
        Me.txbUtilizador.Size = New System.Drawing.Size(187, 20)
        Me.txbUtilizador.TabIndex = 9
        '
        'btAdicionar
        '
        Me.btAdicionar.Location = New System.Drawing.Point(191, 247)
        Me.btAdicionar.Name = "btAdicionar"
        Me.btAdicionar.Size = New System.Drawing.Size(75, 23)
        Me.btAdicionar.TabIndex = 8
        Me.btAdicionar.Text = "Adicionar"
        Me.btAdicionar.UseVisualStyleBackColor = True
        '
        'lbcliente
        '
        Me.lbcliente.AutoSize = True
        Me.lbcliente.Location = New System.Drawing.Point(34, 213)
        Me.lbcliente.Name = "lbcliente"
        Me.lbcliente.Size = New System.Drawing.Size(70, 13)
        Me.lbcliente.TabIndex = 16
        Me.lbcliente.Text = "Nif do Cliente"
        '
        'btnnovocliente
        '
        Me.btnnovocliente.Location = New System.Drawing.Point(366, 203)
        Me.btnnovocliente.Name = "btnnovocliente"
        Me.btnnovocliente.Size = New System.Drawing.Size(120, 23)
        Me.btnnovocliente.TabIndex = 17
        Me.btnnovocliente.Text = "Novo Cliente"
        Me.btnnovocliente.UseVisualStyleBackColor = True
        '
        'FormNovoUtilizador
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.btnnovocliente)
        Me.Controls.Add(Me.lbcliente)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txbcliente)
        Me.Controls.Add(Me.cmbnivel)
        Me.Controls.Add(Me.txbchave)
        Me.Controls.Add(Me.txbUtilizador)
        Me.Controls.Add(Me.btAdicionar)
        Me.Name = "FormNovoUtilizador"
        Me.Text = "FormNovoUtilizdor"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents txbcliente As TextBox
    Friend WithEvents cmbnivel As ComboBox
    Friend WithEvents txbchave As TextBox
    Friend WithEvents txbUtilizador As TextBox
    Friend WithEvents btAdicionar As Button
    Friend WithEvents lbcliente As Label
    Friend WithEvents btnnovocliente As Button
End Class
