<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.txtNome = New System.Windows.Forms.TextBox
        Me.lblNOme = New System.Windows.Forms.Label
        Me.btnOk2 = New System.Windows.Forms.Button
        Me.btnOk1 = New System.Windows.Forms.Button
        Me.txtData = New System.Windows.Forms.MaskedTextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.er = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.tipDicas = New System.Windows.Forms.ToolTip(Me.components)
        Me.Button1 = New System.Windows.Forms.Button
        Me.icoAviso = New System.Windows.Forms.NotifyIcon(Me.components)
        CType(Me.er, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtNome
        '
        Me.txtNome.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtNome.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtNome.Location = New System.Drawing.Point(67, 92)
        Me.txtNome.Multiline = True
        Me.txtNome.Name = "txtNome"
        Me.txtNome.Size = New System.Drawing.Size(357, 115)
        Me.txtNome.TabIndex = 1
        '
        'lblNOme
        '
        Me.lblNOme.AutoSize = True
        Me.lblNOme.Location = New System.Drawing.Point(64, 76)
        Me.lblNOme.Name = "lblNOme"
        Me.lblNOme.Size = New System.Drawing.Size(35, 13)
        Me.lblNOme.TabIndex = 2
        Me.lblNOme.Text = "Nome"
        '
        'btnOk2
        '
        Me.btnOk2.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnOk2.ForeColor = System.Drawing.Color.Green
        Me.btnOk2.Image = Global.exemploaulanoite.My.Resources.Resources.add
        Me.btnOk2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnOk2.Location = New System.Drawing.Point(330, 213)
        Me.btnOk2.Name = "btnOk2"
        Me.btnOk2.Size = New System.Drawing.Size(94, 39)
        Me.btnOk2.TabIndex = 3
        Me.btnOk2.Text = "Limpar"
        Me.tipDicas.SetToolTip(Me.btnOk2, "Clique aqui para limpar a tela")
        Me.btnOk2.UseVisualStyleBackColor = True
        '
        'btnOk1
        '
        Me.btnOk1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnOk1.ForeColor = System.Drawing.Color.Green
        Me.btnOk1.Image = Global.exemploaulanoite.My.Resources.Resources.add
        Me.btnOk1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnOk1.Location = New System.Drawing.Point(190, 213)
        Me.btnOk1.Name = "btnOk1"
        Me.btnOk1.Size = New System.Drawing.Size(94, 39)
        Me.btnOk1.TabIndex = 0
        Me.btnOk1.Text = "Ok"
        Me.tipDicas.SetToolTip(Me.btnOk1, "Clique aqui para salvar os dados")
        Me.btnOk1.UseVisualStyleBackColor = True
        '
        'txtData
        '
        Me.txtData.Location = New System.Drawing.Point(67, 43)
        Me.txtData.Mask = "99/99/99"
        Me.txtData.Name = "txtData"
        Me.txtData.Size = New System.Drawing.Size(66, 20)
        Me.txtData.TabIndex = 4
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(64, 27)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(30, 13)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Data"
        '
        'er
        '
        Me.er.ContainerControl = Me
        '
        'tipDicas
        '
        Me.tipDicas.IsBalloon = True
        Me.tipDicas.ToolTipTitle = "Sugestão"
        '
        'Button1
        '
        Me.Button1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button1.ForeColor = System.Drawing.Color.Green
        Me.Button1.Image = Global.exemploaulanoite.My.Resources.Resources.add
        Me.Button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button1.Location = New System.Drawing.Point(349, 24)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(94, 39)
        Me.Button1.TabIndex = 6
        Me.Button1.Text = "Aviso"
        Me.tipDicas.SetToolTip(Me.Button1, "Clique aqui para salvar os dados")
        Me.Button1.UseVisualStyleBackColor = True
        '
        'icoAviso
        '
        Me.icoAviso.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Info
        Me.icoAviso.BalloonTipText = "Oi, por favor clique aqui"
        Me.icoAviso.BalloonTipTitle = "Sistema Nova Casa"
        Me.icoAviso.Icon = CType(resources.GetObject("icoAviso.Icon"), System.Drawing.Icon)
        Me.icoAviso.Text = "Exemplo do balão de avisos"
        Me.icoAviso.Visible = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(455, 264)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtData)
        Me.Controls.Add(Me.btnOk2)
        Me.Controls.Add(Me.lblNOme)
        Me.Controls.Add(Me.txtNome)
        Me.Controls.Add(Me.btnOk1)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
        CType(Me.er, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnOk1 As System.Windows.Forms.Button
    Friend WithEvents txtNome As System.Windows.Forms.TextBox
    Friend WithEvents lblNOme As System.Windows.Forms.Label
    Friend WithEvents btnOk2 As System.Windows.Forms.Button
    Friend WithEvents txtData As System.Windows.Forms.MaskedTextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents er As System.Windows.Forms.ErrorProvider
    Friend WithEvents tipDicas As System.Windows.Forms.ToolTip
    Friend WithEvents icoAviso As System.Windows.Forms.NotifyIcon
    Friend WithEvents Button1 As System.Windows.Forms.Button

End Class
