<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPrincipal
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
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip
        Me.CadastroToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ClientesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.FornecedoresToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripSeparator
        Me.UsuariosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.NovoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.AlterarSenhaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ControleToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.OrçamentosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.SairToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CadastroToolStripMenuItem, Me.ControleToolStripMenuItem, Me.SairToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(532, 24)
        Me.MenuStrip1.TabIndex = 1
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'CadastroToolStripMenuItem
        '
        Me.CadastroToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ClientesToolStripMenuItem, Me.FornecedoresToolStripMenuItem, Me.ToolStripMenuItem1, Me.UsuariosToolStripMenuItem})
        Me.CadastroToolStripMenuItem.Name = "CadastroToolStripMenuItem"
        Me.CadastroToolStripMenuItem.Size = New System.Drawing.Size(66, 20)
        Me.CadastroToolStripMenuItem.Text = "Cadastro"
        '
        'ClientesToolStripMenuItem
        '
        Me.ClientesToolStripMenuItem.Image = Global.exemploaulanoite.My.Resources.Resources.add
        Me.ClientesToolStripMenuItem.Name = "ClientesToolStripMenuItem"
        Me.ClientesToolStripMenuItem.Size = New System.Drawing.Size(153, 22)
        Me.ClientesToolStripMenuItem.Text = "Clientes"
        '
        'FornecedoresToolStripMenuItem
        '
        Me.FornecedoresToolStripMenuItem.Name = "FornecedoresToolStripMenuItem"
        Me.FornecedoresToolStripMenuItem.Size = New System.Drawing.Size(153, 22)
        Me.FornecedoresToolStripMenuItem.Text = "Fornecedores"
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(150, 6)
        '
        'UsuariosToolStripMenuItem
        '
        Me.UsuariosToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NovoToolStripMenuItem, Me.AlterarSenhaToolStripMenuItem})
        Me.UsuariosToolStripMenuItem.Name = "UsuariosToolStripMenuItem"
        Me.UsuariosToolStripMenuItem.Size = New System.Drawing.Size(153, 22)
        Me.UsuariosToolStripMenuItem.Text = "Usuarios"
        '
        'NovoToolStripMenuItem
        '
        Me.NovoToolStripMenuItem.Name = "NovoToolStripMenuItem"
        Me.NovoToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.NovoToolStripMenuItem.Text = "Novo"
        '
        'AlterarSenhaToolStripMenuItem
        '
        Me.AlterarSenhaToolStripMenuItem.Name = "AlterarSenhaToolStripMenuItem"
        Me.AlterarSenhaToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.AlterarSenhaToolStripMenuItem.Text = "Alterar Senha"
        '
        'ControleToolStripMenuItem
        '
        Me.ControleToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.OrçamentosToolStripMenuItem})
        Me.ControleToolStripMenuItem.Name = "ControleToolStripMenuItem"
        Me.ControleToolStripMenuItem.Size = New System.Drawing.Size(65, 20)
        Me.ControleToolStripMenuItem.Text = "Controle"
        '
        'OrçamentosToolStripMenuItem
        '
        Me.OrçamentosToolStripMenuItem.Name = "OrçamentosToolStripMenuItem"
        Me.OrçamentosToolStripMenuItem.Size = New System.Drawing.Size(147, 22)
        Me.OrçamentosToolStripMenuItem.Text = "Orçamentos"
        '
        'SairToolStripMenuItem
        '
        Me.SairToolStripMenuItem.Name = "SairToolStripMenuItem"
        Me.SairToolStripMenuItem.Size = New System.Drawing.Size(38, 20)
        Me.SairToolStripMenuItem.Text = "Sair"
        '
        'frmPrincipal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(532, 264)
        Me.Controls.Add(Me.MenuStrip1)
        Me.IsMdiContainer = True
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "frmPrincipal"
        Me.Text = "frmPrincipal"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents CadastroToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ClientesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents FornecedoresToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents UsuariosToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents NovoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AlterarSenhaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ControleToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents OrçamentosToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SairToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
End Class
