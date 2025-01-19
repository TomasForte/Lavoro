<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Formutilizadores
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
        Me.btneditar = New System.Windows.Forms.Button()
        Me.txbutilizador = New System.Windows.Forms.TextBox()
        Me.btnProcurar = New System.Windows.Forms.Button()
        Me.lvutilizadores = New System.Windows.Forms.ListView()
        Me.btadicionar = New System.Windows.Forms.Button()
        Me.bteleminar = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btneditar
        '
        Me.btneditar.Location = New System.Drawing.Point(52, 357)
        Me.btneditar.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btneditar.Name = "btneditar"
        Me.btneditar.Size = New System.Drawing.Size(100, 28)
        Me.btneditar.TabIndex = 7
        Me.btneditar.Text = "Editar"
        Me.btneditar.UseVisualStyleBackColor = True
        '
        'txbutilizador
        '
        Me.txbutilizador.Location = New System.Drawing.Point(203, 48)
        Me.txbutilizador.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txbutilizador.Name = "txbutilizador"
        Me.txbutilizador.Size = New System.Drawing.Size(247, 22)
        Me.txbutilizador.TabIndex = 6
        '
        'btnProcurar
        '
        Me.btnProcurar.Location = New System.Drawing.Point(504, 44)
        Me.btnProcurar.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnProcurar.Name = "btnProcurar"
        Me.btnProcurar.Size = New System.Drawing.Size(100, 28)
        Me.btnProcurar.TabIndex = 4
        Me.btnProcurar.Text = "Procurar"
        Me.btnProcurar.UseVisualStyleBackColor = True
        '
        'lvutilizadores
        '
        Me.lvutilizadores.HideSelection = False
        Me.lvutilizadores.Location = New System.Drawing.Point(52, 119)
        Me.lvutilizadores.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.lvutilizadores.Name = "lvutilizadores"
        Me.lvutilizadores.Size = New System.Drawing.Size(551, 179)
        Me.lvutilizadores.TabIndex = 8
        Me.lvutilizadores.UseCompatibleStateImageBehavior = False
        '
        'btadicionar
        '
        Me.btadicionar.Location = New System.Drawing.Point(504, 357)
        Me.btadicionar.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btadicionar.Name = "btadicionar"
        Me.btadicionar.Size = New System.Drawing.Size(100, 28)
        Me.btadicionar.TabIndex = 9
        Me.btadicionar.Text = "Adicionar"
        Me.btadicionar.UseVisualStyleBackColor = True
        '
        'bteleminar
        '
        Me.bteleminar.Cursor = System.Windows.Forms.Cursors.Help
        Me.bteleminar.Location = New System.Drawing.Point(276, 357)
        Me.bteleminar.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.bteleminar.Name = "bteleminar"
        Me.bteleminar.Size = New System.Drawing.Size(100, 28)
        Me.bteleminar.TabIndex = 10
        Me.bteleminar.Text = "Eliminar"
        Me.bteleminar.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(48, 53)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(122, 16)
        Me.Label1.TabIndex = 11
        Me.Label1.Text = "Nome de Utilizador"
        '
        'Formutilizadores
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1067, 554)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.bteleminar)
        Me.Controls.Add(Me.btadicionar)
        Me.Controls.Add(Me.lvutilizadores)
        Me.Controls.Add(Me.btneditar)
        Me.Controls.Add(Me.txbutilizador)
        Me.Controls.Add(Me.btnProcurar)
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "Formutilizadores"
        Me.Text = "Formutilizadores"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btneditar As Button
    Friend WithEvents txbutilizador As TextBox
    Friend WithEvents btnProcurar As Button
    Friend WithEvents lvutilizadores As ListView
    Friend WithEvents btadicionar As Button
    Friend WithEvents bteleminar As Button
    Friend WithEvents Label1 As Label
End Class
