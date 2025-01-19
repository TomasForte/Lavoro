<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormPrincipal
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
        Me.btnNovaReserva = New System.Windows.Forms.Button()
        Me.btnClientes = New System.Windows.Forms.Button()
        Me.btnNovoAluguer = New System.Windows.Forms.Button()
        Me.btnFrota = New System.Windows.Forms.Button()
        Me.btnRegistos = New System.Windows.Forms.Button()
        Me.btutilizadores = New System.Windows.Forms.Button()
        Me.ListView1 = New System.Windows.Forms.ListView()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnNovaReserva
        '
        Me.btnNovaReserva.Location = New System.Drawing.Point(90, 151)
        Me.btnNovaReserva.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.btnNovaReserva.Name = "btnNovaReserva"
        Me.btnNovaReserva.Size = New System.Drawing.Size(275, 100)
        Me.btnNovaReserva.TabIndex = 0
        Me.btnNovaReserva.Text = "Nova Reserva"
        Me.btnNovaReserva.UseVisualStyleBackColor = True
        '
        'btnClientes
        '
        Me.btnClientes.Location = New System.Drawing.Point(90, 576)
        Me.btnClientes.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.btnClientes.Name = "btnClientes"
        Me.btnClientes.Size = New System.Drawing.Size(600, 100)
        Me.btnClientes.TabIndex = 1
        Me.btnClientes.Text = "Clientes"
        Me.btnClientes.UseVisualStyleBackColor = True
        '
        'btnNovoAluguer
        '
        Me.btnNovoAluguer.Location = New System.Drawing.Point(415, 151)
        Me.btnNovoAluguer.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.btnNovoAluguer.Name = "btnNovoAluguer"
        Me.btnNovoAluguer.Size = New System.Drawing.Size(275, 100)
        Me.btnNovoAluguer.TabIndex = 2
        Me.btnNovoAluguer.Text = "Novo Aluguer"
        Me.btnNovoAluguer.UseVisualStyleBackColor = True
        '
        'btnFrota
        '
        Me.btnFrota.Location = New System.Drawing.Point(90, 433)
        Me.btnFrota.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.btnFrota.Name = "btnFrota"
        Me.btnFrota.Size = New System.Drawing.Size(600, 100)
        Me.btnFrota.TabIndex = 3
        Me.btnFrota.Text = "Frota"
        Me.btnFrota.UseVisualStyleBackColor = True
        '
        'btnRegistos
        '
        Me.btnRegistos.Location = New System.Drawing.Point(90, 293)
        Me.btnRegistos.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.btnRegistos.Name = "btnRegistos"
        Me.btnRegistos.Size = New System.Drawing.Size(600, 100)
        Me.btnRegistos.TabIndex = 4
        Me.btnRegistos.Text = "Registos"
        Me.btnRegistos.UseVisualStyleBackColor = True
        '
        'btutilizadores
        '
        Me.btutilizadores.Location = New System.Drawing.Point(90, 720)
        Me.btutilizadores.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.btutilizadores.Name = "btutilizadores"
        Me.btutilizadores.Size = New System.Drawing.Size(600, 100)
        Me.btutilizadores.TabIndex = 6
        Me.btutilizadores.Text = "Utilizadores"
        Me.btutilizadores.UseVisualStyleBackColor = True
        '
        'ListView1
        '
        Me.ListView1.Location = New System.Drawing.Point(833, 195)
        Me.ListView1.Name = "ListView1"
        Me.ListView1.Size = New System.Drawing.Size(784, 625)
        Me.ListView1.TabIndex = 7
        Me.ListView1.UseCompatibleStateImageBehavior = False
        Me.ListView1.View = System.Windows.Forms.View.Details
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(828, 151)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(159, 25)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "Reservas Hoje:"
        '
        'FormPrincipal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(2142, 1058)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ListView1)
        Me.Controls.Add(Me.btutilizadores)
        Me.Controls.Add(Me.btnRegistos)
        Me.Controls.Add(Me.btnFrota)
        Me.Controls.Add(Me.btnNovoAluguer)
        Me.Controls.Add(Me.btnClientes)
        Me.Controls.Add(Me.btnNovaReserva)
        Me.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.Name = "FormPrincipal"
        Me.Text = "FormPrincipal"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnNovaReserva As Button
    Friend WithEvents btnClientes As Button
    Friend WithEvents btnNovoAluguer As Button
    Friend WithEvents btnFrota As Button
    Friend WithEvents btnRegistos As Button
    Friend WithEvents btutilizadores As Button
    Friend WithEvents ListView1 As ListView
    Friend WithEvents Label1 As Label
End Class
