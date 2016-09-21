<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SepdeMat
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(SepdeMat))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Txt_NumeroPedido = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Txt_Conferente = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Txt_Separador = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Txt_Volume = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Txt_Item = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.LblVerificandoItem = New System.Windows.Forms.Label()
        Me.DGridDadosNota = New System.Windows.Forms.DataGridView()
        Me.Btn_Separar = New System.Windows.Forms.Button()
        Me.Btn_FinalizarSep = New System.Windows.Forms.Button()
        Me.Btn_CortarPedido = New System.Windows.Forms.Button()
        Me.List_Dados_Lidos = New System.Windows.Forms.ListBox()
        Me.txt_GetProduto = New System.Windows.Forms.TextBox()
        Me.Txt_QtdeLida = New System.Windows.Forms.TextBox()
        Me.Txt_QuantidadeRestante = New System.Windows.Forms.TextBox()
        Me.LblStatus = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.DGridDadosNota, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Txt_NumeroPedido)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Txt_Conferente)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Txt_Separador)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Txt_Volume)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Txt_Item)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(10, 7)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(553, 68)
        Me.GroupBox1.TabIndex = 4
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Dados do Pedido"
        '
        'Txt_NumeroPedido
        '
        Me.Txt_NumeroPedido.Location = New System.Drawing.Point(394, 14)
        Me.Txt_NumeroPedido.Name = "Txt_NumeroPedido"
        Me.Txt_NumeroPedido.Size = New System.Drawing.Size(131, 20)
        Me.Txt_NumeroPedido.TabIndex = 1
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(305, 16)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(70, 13)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "Nº do Pedido"
        '
        'Txt_Conferente
        '
        Me.Txt_Conferente.Location = New System.Drawing.Point(449, 42)
        Me.Txt_Conferente.Name = "Txt_Conferente"
        Me.Txt_Conferente.Size = New System.Drawing.Size(76, 20)
        Me.Txt_Conferente.TabIndex = 5
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(387, 45)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(59, 13)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Conferente"
        '
        'Txt_Separador
        '
        Me.Txt_Separador.Location = New System.Drawing.Point(302, 42)
        Me.Txt_Separador.Name = "Txt_Separador"
        Me.Txt_Separador.Size = New System.Drawing.Size(76, 20)
        Me.Txt_Separador.TabIndex = 4
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(241, 45)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(56, 13)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Separador"
        '
        'Txt_Volume
        '
        Me.Txt_Volume.Location = New System.Drawing.Point(177, 42)
        Me.Txt_Volume.Name = "Txt_Volume"
        Me.Txt_Volume.Size = New System.Drawing.Size(51, 20)
        Me.Txt_Volume.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(117, 45)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(56, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Volume (s)"
        '
        'Txt_Item
        '
        Me.Txt_Item.Location = New System.Drawing.Point(60, 42)
        Me.Txt_Item.Name = "Txt_Item"
        Me.Txt_Item.Size = New System.Drawing.Size(51, 20)
        Me.Txt_Item.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 45)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(48, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Itens = >"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.LblStatus)
        Me.GroupBox2.Controls.Add(Me.LblVerificandoItem)
        Me.GroupBox2.Controls.Add(Me.DGridDadosNota)
        Me.GroupBox2.Controls.Add(Me.Btn_Separar)
        Me.GroupBox2.Controls.Add(Me.Btn_FinalizarSep)
        Me.GroupBox2.Controls.Add(Me.Btn_CortarPedido)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 81)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(551, 153)
        Me.GroupBox2.TabIndex = 5
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Itens"
        '
        'LblVerificandoItem
        '
        Me.LblVerificandoItem.AutoSize = True
        Me.LblVerificandoItem.ForeColor = System.Drawing.Color.Red
        Me.LblVerificandoItem.Location = New System.Drawing.Point(123, 132)
        Me.LblVerificandoItem.Name = "LblVerificandoItem"
        Me.LblVerificandoItem.Size = New System.Drawing.Size(41, 13)
        Me.LblVerificandoItem.TabIndex = 1
        Me.LblVerificandoItem.Text = "Faltam:"
        '
        'DGridDadosNota
        '
        Me.DGridDadosNota.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.DGridDadosNota.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGridDadosNota.Location = New System.Drawing.Point(7, 19)
        Me.DGridDadosNota.Name = "DGridDadosNota"
        Me.DGridDadosNota.RowHeadersVisible = False
        Me.DGridDadosNota.Size = New System.Drawing.Size(530, 89)
        Me.DGridDadosNota.TabIndex = 0
        '
        'Btn_Separar
        '
        Me.Btn_Separar.Image = CType(resources.GetObject("Btn_Separar.Image"), System.Drawing.Image)
        Me.Btn_Separar.Location = New System.Drawing.Point(7, 112)
        Me.Btn_Separar.Name = "Btn_Separar"
        Me.Btn_Separar.Size = New System.Drawing.Size(32, 31)
        Me.Btn_Separar.TabIndex = 6
        Me.Btn_Separar.UseVisualStyleBackColor = True
        '
        'Btn_FinalizarSep
        '
        Me.Btn_FinalizarSep.Image = CType(resources.GetObject("Btn_FinalizarSep.Image"), System.Drawing.Image)
        Me.Btn_FinalizarSep.Location = New System.Drawing.Point(45, 112)
        Me.Btn_FinalizarSep.Name = "Btn_FinalizarSep"
        Me.Btn_FinalizarSep.Size = New System.Drawing.Size(33, 31)
        Me.Btn_FinalizarSep.TabIndex = 7
        Me.Btn_FinalizarSep.UseVisualStyleBackColor = True
        '
        'Btn_CortarPedido
        '
        Me.Btn_CortarPedido.Image = CType(resources.GetObject("Btn_CortarPedido.Image"), System.Drawing.Image)
        Me.Btn_CortarPedido.Location = New System.Drawing.Point(84, 113)
        Me.Btn_CortarPedido.Name = "Btn_CortarPedido"
        Me.Btn_CortarPedido.Size = New System.Drawing.Size(32, 30)
        Me.Btn_CortarPedido.TabIndex = 8
        Me.Btn_CortarPedido.UseVisualStyleBackColor = True
        '
        'List_Dados_Lidos
        '
        Me.List_Dados_Lidos.FormattingEnabled = True
        Me.List_Dados_Lidos.Location = New System.Drawing.Point(888, 16)
        Me.List_Dados_Lidos.Name = "List_Dados_Lidos"
        Me.List_Dados_Lidos.Size = New System.Drawing.Size(470, 173)
        Me.List_Dados_Lidos.TabIndex = 9
        '
        'txt_GetProduto
        '
        Me.txt_GetProduto.Location = New System.Drawing.Point(633, 20)
        Me.txt_GetProduto.Name = "txt_GetProduto"
        Me.txt_GetProduto.Size = New System.Drawing.Size(234, 20)
        Me.txt_GetProduto.TabIndex = 10
        '
        'Txt_QtdeLida
        '
        Me.Txt_QtdeLida.Location = New System.Drawing.Point(633, 49)
        Me.Txt_QtdeLida.Name = "Txt_QtdeLida"
        Me.Txt_QtdeLida.Size = New System.Drawing.Size(233, 20)
        Me.Txt_QtdeLida.TabIndex = 11
        '
        'Txt_QuantidadeRestante
        '
        Me.Txt_QuantidadeRestante.Location = New System.Drawing.Point(633, 75)
        Me.Txt_QuantidadeRestante.Name = "Txt_QuantidadeRestante"
        Me.Txt_QuantidadeRestante.Size = New System.Drawing.Size(162, 20)
        Me.Txt_QuantidadeRestante.TabIndex = 12
        '
        'LblStatus
        '
        Me.LblStatus.AutoSize = True
        Me.LblStatus.Location = New System.Drawing.Point(122, 116)
        Me.LblStatus.Name = "LblStatus"
        Me.LblStatus.Size = New System.Drawing.Size(102, 13)
        Me.LblStatus.TabIndex = 9
        Me.LblStatus.Text = "Separando Material:"
        '
        'SepdeMat
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1370, 278)
        Me.Controls.Add(Me.Txt_QuantidadeRestante)
        Me.Controls.Add(Me.Txt_QtdeLida)
        Me.Controls.Add(Me.txt_GetProduto)
        Me.Controls.Add(Me.List_Dados_Lidos)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "SepdeMat"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = " Separador de Produtos"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.DGridDadosNota, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Txt_Conferente As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Txt_Separador As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Txt_Volume As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Txt_Item As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Txt_NumeroPedido As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Btn_Separar As System.Windows.Forms.Button
    Friend WithEvents Btn_FinalizarSep As System.Windows.Forms.Button
    Friend WithEvents Btn_CortarPedido As System.Windows.Forms.Button
    Friend WithEvents DGridDadosNota As System.Windows.Forms.DataGridView
    Friend WithEvents List_Dados_Lidos As System.Windows.Forms.ListBox
    Friend WithEvents txt_GetProduto As System.Windows.Forms.TextBox
    Friend WithEvents Txt_QtdeLida As System.Windows.Forms.TextBox
    Friend WithEvents Txt_QuantidadeRestante As System.Windows.Forms.TextBox
    Friend WithEvents LblVerificandoItem As System.Windows.Forms.Label
    Friend WithEvents LblStatus As System.Windows.Forms.Label
End Class
