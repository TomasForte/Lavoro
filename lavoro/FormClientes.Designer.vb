<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormClientes
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
        Me.btnProcurar = New System.Windows.Forms.Button()
        Me.btnAdicionarClientes = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtNome = New System.Windows.Forms.TextBox()
        Me.txtNIF = New System.Windows.Forms.TextBox()
        Me.btnInfo = New System.Windows.Forms.Button()
        Me.ListViewClientes = New System.Windows.Forms.ListView()
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader4 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Label3 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnProcurar
        '
        Me.btnProcurar.Location = New System.Drawing.Point(440, 38)
        Me.btnProcurar.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnProcurar.Name = "btnProcurar"
        Me.btnProcurar.Size = New System.Drawing.Size(100, 28)
        Me.btnProcurar.TabIndex = 1
        Me.btnProcurar.Text = "Procurar"
        Me.btnProcurar.UseVisualStyleBackColor = True
        '
        'btnAdicionarClientes
        '
        Me.btnAdicionarClientes.Location = New System.Drawing.Point(357, 341)
        Me.btnAdicionarClientes.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnAdicionarClientes.Name = "btnAdicionarClientes"
        Me.btnAdicionarClientes.Size = New System.Drawing.Size(183, 28)
        Me.btnAdicionarClientes.TabIndex = 2
        Me.btnAdicionarClientes.Text = "Adicionar Cliente"
        Me.btnAdicionarClientes.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(59, 45)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(45, 17)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Nome"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(59, 84)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(29, 17)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "NIF"
        '
        'txtNome
        '
        Me.txtNome.Location = New System.Drawing.Point(127, 42)
        Me.txtNome.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtNome.Name = "txtNome"
        Me.txtNome.Size = New System.Drawing.Size(280, 22)
        Me.txtNome.TabIndex = 5
        '
        'txtNIF
        '
        Me.txtNIF.Location = New System.Drawing.Point(127, 80)
        Me.txtNIF.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtNIF.Name = "txtNIF"
        Me.txtNIF.Size = New System.Drawing.Size(215, 22)
        Me.txtNIF.TabIndex = 6
        '
        'btnInfo
        '
        Me.btnInfo.Location = New System.Drawing.Point(63, 341)
        Me.btnInfo.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnInfo.Name = "btnInfo"
        Me.btnInfo.Size = New System.Drawing.Size(183, 28)
        Me.btnInfo.TabIndex = 7
        Me.btnInfo.Text = "Informações"
        Me.btnInfo.UseVisualStyleBackColor = True
        '
        'ListViewClientes
        '
        Me.ListViewClientes.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader3, Me.ColumnHeader4})
        Me.ListViewClientes.FullRowSelect = True
        Me.ListViewClientes.Location = New System.Drawing.Point(62, 140)
        Me.ListViewClientes.Name = "ListViewClientes"
        Me.ListViewClientes.Size = New System.Drawing.Size(478, 169)
        Me.ListViewClientes.TabIndex = 8
        Me.ListViewClientes.UseCompatibleStateImageBehavior = False
        Me.ListViewClientes.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "NIF"
        Me.ColumnHeader1.Width = 73
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "Nome"
        Me.ColumnHeader2.Width = 90
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "Data de Nascimento"
        Me.ColumnHeader3.Width = 102
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "Idade"
        Me.ColumnHeader4.Width = 52
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(62, 120)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(112, 17)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "Lista de Clientes"
        '
        'FormClientes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(596, 403)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.ListViewClientes)
        Me.Controls.Add(Me.btnInfo)
        Me.Controls.Add(Me.txtNIF)
        Me.Controls.Add(Me.txtNome)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnAdicionarClientes)
        Me.Controls.Add(Me.btnProcurar)
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "FormClientes"
        Me.Text = "FormClientes"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnProcurar As Button
    Friend WithEvents btnAdicionarClientes As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtNome As TextBox
    Friend WithEvents txtNIF As TextBox
    Friend WithEvents btnInfo As Button
    Friend WithEvents ListViewClientes As ListView
    Friend WithEvents ColumnHeader1 As ColumnHeader
    Friend WithEvents ColumnHeader2 As ColumnHeader
    Friend WithEvents ColumnHeader3 As ColumnHeader
    Friend WithEvents ColumnHeader4 As ColumnHeader
    Friend WithEvents Label3 As Label
End Class
