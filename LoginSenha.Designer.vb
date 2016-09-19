<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class LoginSenha
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
        Me.Btn_Entrar = New System.Windows.Forms.Button()
        Me.Btn_Sair = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.CmbUsuario = New System.Windows.Forms.ComboBox()
        Me.Txt_Senha = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'Btn_Entrar
        '
        Me.Btn_Entrar.Location = New System.Drawing.Point(17, 86)
        Me.Btn_Entrar.Name = "Btn_Entrar"
        Me.Btn_Entrar.Size = New System.Drawing.Size(83, 31)
        Me.Btn_Entrar.TabIndex = 0
        Me.Btn_Entrar.Text = "Entrar"
        Me.Btn_Entrar.UseVisualStyleBackColor = True
        '
        'Btn_Sair
        '
        Me.Btn_Sair.Location = New System.Drawing.Point(144, 86)
        Me.Btn_Sair.Name = "Btn_Sair"
        Me.Btn_Sair.Size = New System.Drawing.Size(83, 31)
        Me.Btn_Sair.TabIndex = 1
        Me.Btn_Sair.Text = "Sair"
        Me.Btn_Sair.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(15, 18)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(43, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Usuário"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(15, 55)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(38, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Senha"
        '
        'CmbUsuario
        '
        Me.CmbUsuario.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CmbUsuario.FormattingEnabled = True
        Me.CmbUsuario.Items.AddRange(New Object() {"Coletor 1", "Coletor 2", "Coletor 3", "Administrador"})
        Me.CmbUsuario.Location = New System.Drawing.Point(64, 15)
        Me.CmbUsuario.Name = "CmbUsuario"
        Me.CmbUsuario.Size = New System.Drawing.Size(163, 21)
        Me.CmbUsuario.TabIndex = 4
        '
        'Txt_Senha
        '
        Me.Txt_Senha.Location = New System.Drawing.Point(64, 52)
        Me.Txt_Senha.Name = "Txt_Senha"
        Me.Txt_Senha.Size = New System.Drawing.Size(163, 20)
        Me.Txt_Senha.TabIndex = 5
        '
        'LoginSenha
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.ClientSize = New System.Drawing.Size(241, 129)
        Me.Controls.Add(Me.Txt_Senha)
        Me.Controls.Add(Me.CmbUsuario)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Btn_Sair)
        Me.Controls.Add(Me.Btn_Entrar)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "LoginSenha"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Login e Senha"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Btn_Entrar As System.Windows.Forms.Button
    Friend WithEvents Btn_Sair As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents CmbUsuario As System.Windows.Forms.ComboBox
    Friend WithEvents Txt_Senha As System.Windows.Forms.TextBox

End Class
