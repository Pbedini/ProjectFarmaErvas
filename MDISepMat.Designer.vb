<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MdiSepMat
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
        Me.components = New System.ComponentModel.Container()
        Me.SeparacaoDeProdutoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SeparaçaoDeProdutosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RelatoriosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GerarRelatórioToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SairToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.ToolTip = New System.Windows.Forms.ToolTip(Me.components)
        Me.StatusStrip = New System.Windows.Forms.StatusStrip()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'SeparacaoDeProdutoToolStripMenuItem
        '
        Me.SeparacaoDeProdutoToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SeparaçaoDeProdutosToolStripMenuItem})
        Me.SeparacaoDeProdutoToolStripMenuItem.Name = "SeparacaoDeProdutoToolStripMenuItem"
        Me.SeparacaoDeProdutoToolStripMenuItem.Size = New System.Drawing.Size(61, 20)
        Me.SeparacaoDeProdutoToolStripMenuItem.Text = "Arquivo"
        '
        'SeparaçaoDeProdutosToolStripMenuItem
        '
        Me.SeparaçaoDeProdutosToolStripMenuItem.Name = "SeparaçaoDeProdutosToolStripMenuItem"
        Me.SeparaçaoDeProdutosToolStripMenuItem.Size = New System.Drawing.Size(195, 22)
        Me.SeparaçaoDeProdutosToolStripMenuItem.Text = "Separaçao de Produtos"
        '
        'RelatoriosToolStripMenuItem
        '
        Me.RelatoriosToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.GerarRelatórioToolStripMenuItem})
        Me.RelatoriosToolStripMenuItem.Name = "RelatoriosToolStripMenuItem"
        Me.RelatoriosToolStripMenuItem.Size = New System.Drawing.Size(71, 20)
        Me.RelatoriosToolStripMenuItem.Text = "Relatorios"
        '
        'GerarRelatórioToolStripMenuItem
        '
        Me.GerarRelatórioToolStripMenuItem.Name = "GerarRelatórioToolStripMenuItem"
        Me.GerarRelatórioToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.GerarRelatórioToolStripMenuItem.Text = "Gerar Relatório"
        '
        'SairToolStripMenuItem
        '
        Me.SairToolStripMenuItem.Name = "SairToolStripMenuItem"
        Me.SairToolStripMenuItem.Size = New System.Drawing.Size(38, 20)
        Me.SairToolStripMenuItem.Text = "Sair"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SeparacaoDeProdutoToolStripMenuItem, Me.RelatoriosToolStripMenuItem, Me.SairToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(632, 24)
        Me.MenuStrip1.TabIndex = 9
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'StatusStrip
        '
        Me.StatusStrip.Location = New System.Drawing.Point(0, 431)
        Me.StatusStrip.Name = "StatusStrip"
        Me.StatusStrip.Size = New System.Drawing.Size(632, 22)
        Me.StatusStrip.TabIndex = 7
        Me.StatusStrip.Text = "StatusStrip"
        '
        'MdiSepMat
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(632, 453)
        Me.ControlBox = False
        Me.Controls.Add(Me.StatusStrip)
        Me.Controls.Add(Me.MenuStrip1)
        Me.IsMdiContainer = True
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "MdiSepMat"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Separação de Material"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents SeparacaoDeProdutoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SeparaçaoDeProdutosToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RelatoriosToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents GerarRelatórioToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SairToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents ToolTip As System.Windows.Forms.ToolTip
    Friend WithEvents StatusStrip As System.Windows.Forms.StatusStrip

End Class
