<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormLogin
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormLogin))
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Btcancelar = New System.Windows.Forms.Button()
        Me.Btentar = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txbChave = New System.Windows.Forms.TextBox()
        Me.txbUtilizdor = New System.Windows.Forms.TextBox()
        Me.btnregistrar = New System.Windows.Forms.Button()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(47, 35)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(263, 80)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 13
        Me.PictureBox1.TabStop = False
        '
        'Btcancelar
        '
        Me.Btcancelar.Location = New System.Drawing.Point(170, 284)
        Me.Btcancelar.Name = "Btcancelar"
        Me.Btcancelar.Size = New System.Drawing.Size(75, 23)
        Me.Btcancelar.TabIndex = 12
        Me.Btcancelar.Text = "Cancelar"
        Me.Btcancelar.UseVisualStyleBackColor = True
        '
        'Btentar
        '
        Me.Btentar.Location = New System.Drawing.Point(47, 284)
        Me.Btentar.Name = "Btentar"
        Me.Btentar.Size = New System.Drawing.Size(75, 23)
        Me.Btentar.TabIndex = 11
        Me.Btentar.Text = "Entrar"
        Me.Btentar.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(47, 228)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(77, 13)
        Me.Label2.TabIndex = 10
        Me.Label2.Text = "Palavra-Chave"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(38, 150)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(96, 13)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "Nome de Utilizador"
        '
        'txbChave
        '
        Me.txbChave.Location = New System.Drawing.Point(140, 221)
        Me.txbChave.Name = "txbChave"
        Me.txbChave.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txbChave.Size = New System.Drawing.Size(147, 20)
        Me.txbChave.TabIndex = 8
        '
        'txbUtilizdor
        '
        Me.txbUtilizdor.Location = New System.Drawing.Point(140, 147)
        Me.txbUtilizdor.Name = "txbUtilizdor"
        Me.txbUtilizdor.Size = New System.Drawing.Size(147, 20)
        Me.txbUtilizdor.TabIndex = 7
        '
        'btnregistrar
        '
        Me.btnregistrar.Location = New System.Drawing.Point(281, 284)
        Me.btnregistrar.Name = "btnregistrar"
        Me.btnregistrar.Size = New System.Drawing.Size(75, 23)
        Me.btnregistrar.TabIndex = 14
        Me.btnregistrar.Text = "Registar"
        Me.btnregistrar.UseVisualStyleBackColor = True
        '
        'FormLogin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(452, 450)
        Me.Controls.Add(Me.btnregistrar)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Btcancelar)
        Me.Controls.Add(Me.Btentar)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txbChave)
        Me.Controls.Add(Me.txbUtilizdor)
        Me.Name = "FormLogin"
        Me.Text = "FormLogin"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Btcancelar As Button
    Friend WithEvents Btentar As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents txbChave As TextBox
    Friend WithEvents txbUtilizdor As TextBox
    Friend WithEvents btnregistrar As Button
End Class
