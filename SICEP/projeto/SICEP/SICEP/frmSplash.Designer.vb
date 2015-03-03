<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSplash
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing Then
            If Not (components Is Nothing) Then
                components.Dispose()
            End If
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.txtLogin = New System.Windows.Forms.TextBox
        Me.txtSenha = New System.Windows.Forms.TextBox
        Me.cmdCancelar = New System.Windows.Forms.Button
        Me.cmdOK = New System.Windows.Forms.Button
        Me.erro = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.ajuda = New System.Windows.Forms.HelpProvider
        CType(Me.erro, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(138, 168)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(46, 14)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Login:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(137, 200)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(52, 14)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Senha:"
        '
        'txtLogin
        '
        Me.txtLogin.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.ajuda.SetHelpString(Me.txtLogin, "")
        Me.txtLogin.Location = New System.Drawing.Point(191, 167)
        Me.txtLogin.MaxLength = 7
        Me.txtLogin.Name = "txtLogin"
        Me.ajuda.SetShowHelp(Me.txtLogin, True)
        Me.txtLogin.Size = New System.Drawing.Size(175, 20)
        Me.txtLogin.TabIndex = 2
        Me.txtLogin.WordWrap = False
        '
        'txtSenha
        '
        Me.txtSenha.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.ajuda.SetHelpString(Me.txtSenha, "")
        Me.txtSenha.Location = New System.Drawing.Point(191, 197)
        Me.txtSenha.MaxLength = 7
        Me.txtSenha.Name = "txtSenha"
        Me.txtSenha.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.ajuda.SetShowHelp(Me.txtSenha, True)
        Me.txtSenha.Size = New System.Drawing.Size(175, 20)
        Me.txtSenha.TabIndex = 3
        Me.txtSenha.UseSystemPasswordChar = True
        Me.txtSenha.WordWrap = False
        '
        'cmdCancelar
        '
        Me.cmdCancelar.CausesValidation = False
        Me.cmdCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.ajuda.SetHelpString(Me.cmdCancelar, "")
        Me.cmdCancelar.Location = New System.Drawing.Point(191, 223)
        Me.cmdCancelar.Name = "cmdCancelar"
        Me.ajuda.SetShowHelp(Me.cmdCancelar, True)
        Me.cmdCancelar.Size = New System.Drawing.Size(83, 23)
        Me.cmdCancelar.TabIndex = 4
        Me.cmdCancelar.Text = "Cancelar"
        Me.cmdCancelar.UseVisualStyleBackColor = True
        '
        'cmdOK
        '
        Me.ajuda.SetHelpString(Me.cmdOK, "")
        Me.cmdOK.Location = New System.Drawing.Point(280, 223)
        Me.cmdOK.Name = "cmdOK"
        Me.ajuda.SetShowHelp(Me.cmdOK, True)
        Me.cmdOK.Size = New System.Drawing.Size(86, 23)
        Me.cmdOK.TabIndex = 5
        Me.cmdOK.Text = "OK"
        Me.cmdOK.UseVisualStyleBackColor = True
        '
        'erro
        '
        Me.erro.ContainerControl = Me
        '
        'ajuda
        '
        Me.ajuda.HelpNamespace = "C:\Arquivos de programas\SICEP\Ajuda\frmLogando.html"
        '
        'frmSplash
        '
        Me.AcceptButton = Me.cmdOK
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.SICEP.My.Resources.Resources.bg_splash
        Me.CancelButton = Me.cmdCancelar
        Me.ClientSize = New System.Drawing.Size(498, 298)
        Me.ControlBox = False
        Me.Controls.Add(Me.cmdOK)
        Me.Controls.Add(Me.cmdCancelar)
        Me.Controls.Add(Me.txtSenha)
        Me.Controls.Add(Me.txtLogin)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmSplash"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        CType(Me.erro, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtLogin As System.Windows.Forms.TextBox
    Friend WithEvents txtSenha As System.Windows.Forms.TextBox
    Friend WithEvents cmdCancelar As System.Windows.Forms.Button
    Friend WithEvents cmdOK As System.Windows.Forms.Button
    Friend WithEvents erro As System.Windows.Forms.ErrorProvider
    Friend WithEvents ajuda As System.Windows.Forms.HelpProvider

End Class
