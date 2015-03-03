<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCadUsuario
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmCadUsuario))
        Me.pnlFormulario = New System.Windows.Forms.Panel
        Me.lkImprimir = New System.Windows.Forms.LinkLabel
        Me.imgInformacoes = New System.Windows.Forms.PictureBox
        Me.Label21 = New System.Windows.Forms.Label
        Me.Label20 = New System.Windows.Forms.Label
        Me.Label16 = New System.Windows.Forms.Label
        Me.lblValLogin = New System.Windows.Forms.Label
        Me.lblValConfSenha = New System.Windows.Forms.Label
        Me.lblValSenha = New System.Windows.Forms.Label
        Me.txtSenha = New System.Windows.Forms.TextBox
        Me.txtConfSenha = New System.Windows.Forms.TextBox
        Me.Label19 = New System.Windows.Forms.Label
        Me.txtLogin = New System.Windows.Forms.TextBox
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.lblValTelCel = New System.Windows.Forms.Label
        Me.Label17 = New System.Windows.Forms.Label
        Me.txtTelCel = New System.Windows.Forms.MaskedTextBox
        Me.Label18 = New System.Windows.Forms.Label
        Me.txtCargo = New System.Windows.Forms.TextBox
        Me.Label15 = New System.Windows.Forms.Label
        Me.lblValCPF = New System.Windows.Forms.Label
        Me.lblValTelRes = New System.Windows.Forms.Label
        Me.lblValEndereco = New System.Windows.Forms.Label
        Me.lblValNome = New System.Windows.Forms.Label
        Me.Label14 = New System.Windows.Forms.Label
        Me.Label13 = New System.Windows.Forms.Label
        Me.txtTelRes = New System.Windows.Forms.MaskedTextBox
        Me.txtCPF = New System.Windows.Forms.MaskedTextBox
        Me.lblDataCadastramento = New System.Windows.Forms.Label
        Me.lblCodigo = New System.Windows.Forms.Label
        Me.dpdPerfil = New System.Windows.Forms.ComboBox
        Me.txtRG = New System.Windows.Forms.TextBox
        Me.txtEmail = New System.Windows.Forms.TextBox
        Me.txtEndereco = New System.Windows.Forms.TextBox
        Me.txtNome = New System.Windows.Forms.TextBox
        Me.Label12 = New System.Windows.Forms.Label
        Me.Label11 = New System.Windows.Forms.Label
        Me.Label10 = New System.Windows.Forms.Label
        Me.Label9 = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.tstMenu = New System.Windows.Forms.ToolStrip
        Me.cmdNovo = New System.Windows.Forms.ToolStripButton
        Me.cmdSalvar = New System.Windows.Forms.ToolStripButton
        Me.cmdAlterar = New System.Windows.Forms.ToolStripButton
        Me.cmdExcluir = New System.Windows.Forms.ToolStripButton
        Me.cmdCancelar = New System.Windows.Forms.ToolStripButton
        Me.pnlPesquisa = New System.Windows.Forms.Panel
        Me.grdUsuario = New System.Windows.Forms.DataGridView
        Me.cod_usuario = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.nome_usuario = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.txtPesquisa = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.ToolTip = New System.Windows.Forms.ToolTip(Me.components)
        Me.ajuda = New System.Windows.Forms.HelpProvider
        Me.pnlFormulario.SuspendLayout()
        CType(Me.imgInformacoes, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tstMenu.SuspendLayout()
        Me.pnlPesquisa.SuspendLayout()
        CType(Me.grdUsuario, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pnlFormulario
        '
        Me.pnlFormulario.BackColor = System.Drawing.Color.Transparent
        Me.pnlFormulario.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnlFormulario.Controls.Add(Me.lkImprimir)
        Me.pnlFormulario.Controls.Add(Me.imgInformacoes)
        Me.pnlFormulario.Controls.Add(Me.Label21)
        Me.pnlFormulario.Controls.Add(Me.Label20)
        Me.pnlFormulario.Controls.Add(Me.Label16)
        Me.pnlFormulario.Controls.Add(Me.lblValLogin)
        Me.pnlFormulario.Controls.Add(Me.lblValConfSenha)
        Me.pnlFormulario.Controls.Add(Me.lblValSenha)
        Me.pnlFormulario.Controls.Add(Me.txtSenha)
        Me.pnlFormulario.Controls.Add(Me.txtConfSenha)
        Me.pnlFormulario.Controls.Add(Me.Label19)
        Me.pnlFormulario.Controls.Add(Me.txtLogin)
        Me.pnlFormulario.Controls.Add(Me.Label7)
        Me.pnlFormulario.Controls.Add(Me.Label6)
        Me.pnlFormulario.Controls.Add(Me.lblValTelCel)
        Me.pnlFormulario.Controls.Add(Me.Label17)
        Me.pnlFormulario.Controls.Add(Me.txtTelCel)
        Me.pnlFormulario.Controls.Add(Me.Label18)
        Me.pnlFormulario.Controls.Add(Me.txtCargo)
        Me.pnlFormulario.Controls.Add(Me.Label15)
        Me.pnlFormulario.Controls.Add(Me.lblValCPF)
        Me.pnlFormulario.Controls.Add(Me.lblValTelRes)
        Me.pnlFormulario.Controls.Add(Me.lblValEndereco)
        Me.pnlFormulario.Controls.Add(Me.lblValNome)
        Me.pnlFormulario.Controls.Add(Me.Label14)
        Me.pnlFormulario.Controls.Add(Me.Label13)
        Me.pnlFormulario.Controls.Add(Me.txtTelRes)
        Me.pnlFormulario.Controls.Add(Me.txtCPF)
        Me.pnlFormulario.Controls.Add(Me.lblDataCadastramento)
        Me.pnlFormulario.Controls.Add(Me.lblCodigo)
        Me.pnlFormulario.Controls.Add(Me.dpdPerfil)
        Me.pnlFormulario.Controls.Add(Me.txtRG)
        Me.pnlFormulario.Controls.Add(Me.txtEmail)
        Me.pnlFormulario.Controls.Add(Me.txtEndereco)
        Me.pnlFormulario.Controls.Add(Me.txtNome)
        Me.pnlFormulario.Controls.Add(Me.Label12)
        Me.pnlFormulario.Controls.Add(Me.Label11)
        Me.pnlFormulario.Controls.Add(Me.Label10)
        Me.pnlFormulario.Controls.Add(Me.Label9)
        Me.pnlFormulario.Controls.Add(Me.Label8)
        Me.pnlFormulario.Controls.Add(Me.Label5)
        Me.pnlFormulario.Controls.Add(Me.Label4)
        Me.pnlFormulario.Controls.Add(Me.Label3)
        Me.pnlFormulario.Controls.Add(Me.Label2)
        Me.pnlFormulario.Controls.Add(Me.tstMenu)
        Me.pnlFormulario.Location = New System.Drawing.Point(121, 1)
        Me.pnlFormulario.Name = "pnlFormulario"
        Me.pnlFormulario.Size = New System.Drawing.Size(526, 496)
        Me.pnlFormulario.TabIndex = 3
        '
        'lkImprimir
        '
        Me.lkImprimir.AutoSize = True
        Me.ajuda.SetHelpString(Me.lkImprimir, "Clique aqui para exibir a relação de todos os usuário cadastrados no sistema em m" & _
                "odo de impressão.")
        Me.lkImprimir.Location = New System.Drawing.Point(23, 474)
        Me.lkImprimir.Name = "lkImprimir"
        Me.ajuda.SetShowHelp(Me.lkImprimir, True)
        Me.lkImprimir.Size = New System.Drawing.Size(224, 13)
        Me.lkImprimir.TabIndex = 55
        Me.lkImprimir.TabStop = True
        Me.lkImprimir.Text = "Ver relatório de todos os usuários cadastrados"
        '
        'imgInformacoes
        '
        Me.imgInformacoes.Image = Global.SICEP.My.Resources.Resources.infos
        Me.imgInformacoes.Location = New System.Drawing.Point(255, 437)
        Me.imgInformacoes.Name = "imgInformacoes"
        Me.imgInformacoes.Size = New System.Drawing.Size(21, 21)
        Me.imgInformacoes.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.imgInformacoes.TabIndex = 54
        Me.imgInformacoes.TabStop = False
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label21.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.Label21.Location = New System.Drawing.Point(24, 36)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(97, 13)
        Me.Label21.TabIndex = 53
        Me.Label21.Text = "Dados Pessoais"
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.Label20.Location = New System.Drawing.Point(24, 351)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(307, 13)
        Me.Label20.TabIndex = 52
        Me.Label20.Text = "Para login e senha digite no mínimo 1 e no máximo 7 caracteres."
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.Label16.Location = New System.Drawing.Point(24, 328)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(68, 13)
        Me.Label16.TabIndex = 51
        Me.Label16.Text = "Segurança"
        '
        'lblValLogin
        '
        Me.lblValLogin.AutoSize = True
        Me.lblValLogin.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblValLogin.ForeColor = System.Drawing.Color.Red
        Me.lblValLogin.Location = New System.Drawing.Point(238, 376)
        Me.lblValLogin.Name = "lblValLogin"
        Me.lblValLogin.Size = New System.Drawing.Size(12, 13)
        Me.lblValLogin.TabIndex = 50
        Me.lblValLogin.Text = "*"
        Me.lblValLogin.Visible = False
        '
        'lblValConfSenha
        '
        Me.lblValConfSenha.AutoSize = True
        Me.lblValConfSenha.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblValConfSenha.ForeColor = System.Drawing.Color.Red
        Me.lblValConfSenha.Location = New System.Drawing.Point(494, 407)
        Me.lblValConfSenha.Name = "lblValConfSenha"
        Me.lblValConfSenha.Size = New System.Drawing.Size(12, 13)
        Me.lblValConfSenha.TabIndex = 49
        Me.lblValConfSenha.Text = "*"
        Me.lblValConfSenha.Visible = False
        '
        'lblValSenha
        '
        Me.lblValSenha.AutoSize = True
        Me.lblValSenha.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblValSenha.ForeColor = System.Drawing.Color.Red
        Me.lblValSenha.Location = New System.Drawing.Point(238, 410)
        Me.lblValSenha.Name = "lblValSenha"
        Me.lblValSenha.Size = New System.Drawing.Size(12, 13)
        Me.lblValSenha.TabIndex = 48
        Me.lblValSenha.Text = "*"
        Me.lblValSenha.Visible = False
        '
        'txtSenha
        '
        Me.txtSenha.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.ajuda.SetHelpString(Me.txtSenha, "Digite aqui a senha do usuário.")
        Me.txtSenha.Location = New System.Drawing.Point(84, 407)
        Me.txtSenha.MaxLength = 7
        Me.txtSenha.Name = "txtSenha"
        Me.txtSenha.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.ajuda.SetShowHelp(Me.txtSenha, True)
        Me.txtSenha.Size = New System.Drawing.Size(155, 20)
        Me.txtSenha.TabIndex = 21
        Me.txtSenha.UseSystemPasswordChar = True
        '
        'txtConfSenha
        '
        Me.txtConfSenha.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.ajuda.SetHelpString(Me.txtConfSenha, "Confirme a senha digitada ao lado.")
        Me.txtConfSenha.Location = New System.Drawing.Point(300, 407)
        Me.txtConfSenha.MaxLength = 7
        Me.txtConfSenha.Name = "txtConfSenha"
        Me.txtConfSenha.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.ajuda.SetShowHelp(Me.txtConfSenha, True)
        Me.txtConfSenha.Size = New System.Drawing.Size(192, 20)
        Me.txtConfSenha.TabIndex = 22
        Me.txtConfSenha.UseSystemPasswordChar = True
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Location = New System.Drawing.Point(252, 410)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(51, 13)
        Me.Label19.TabIndex = 45
        Me.Label19.Text = "Confirme:"
        '
        'txtLogin
        '
        Me.txtLogin.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.ajuda.SetHelpString(Me.txtLogin, "Digite aqui o login do usuário. Lembre-se que quanto mais diferenciado de palavra" & _
                "s comuns, mais difícil de ser lembrado.")
        Me.txtLogin.Location = New System.Drawing.Point(84, 376)
        Me.txtLogin.MaxLength = 7
        Me.txtLogin.Name = "txtLogin"
        Me.ajuda.SetShowHelp(Me.txtLogin, True)
        Me.txtLogin.Size = New System.Drawing.Size(155, 20)
        Me.txtLogin.TabIndex = 20
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(23, 379)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(36, 13)
        Me.Label7.TabIndex = 43
        Me.Label7.Text = "Login:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(24, 410)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(41, 13)
        Me.Label6.TabIndex = 41
        Me.Label6.Text = "Senha:"
        '
        'lblValTelCel
        '
        Me.lblValTelCel.AutoSize = True
        Me.lblValTelCel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblValTelCel.ForeColor = System.Drawing.Color.Red
        Me.lblValTelCel.Location = New System.Drawing.Point(275, 226)
        Me.lblValTelCel.Name = "lblValTelCel"
        Me.lblValTelCel.Size = New System.Drawing.Size(12, 13)
        Me.lblValTelCel.TabIndex = 40
        Me.lblValTelCel.Text = "*"
        Me.lblValTelCel.Visible = False
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.Label17.Location = New System.Drawing.Point(296, 228)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(123, 13)
        Me.Label17.TabIndex = 39
        Me.Label17.Text = "Digite somente números."
        '
        'txtTelCel
        '
        Me.ajuda.SetHelpString(Me.txtTelCel, "Defina aqui o telefone celular do usuário.")
        Me.txtTelCel.Location = New System.Drawing.Point(84, 225)
        Me.txtTelCel.Mask = "(99)9999-9999"
        Me.txtTelCel.Name = "txtTelCel"
        Me.ajuda.SetShowHelp(Me.txtTelCel, True)
        Me.txtTelCel.Size = New System.Drawing.Size(189, 20)
        Me.txtTelCel.TabIndex = 17
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(22, 228)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(55, 13)
        Me.Label18.TabIndex = 37
        Me.Label18.Text = "Fone Cel.:"
        '
        'txtCargo
        '
        Me.ajuda.SetHelpString(Me.txtCargo, "Se necessário especifique aqui o cargo do usuário.")
        Me.txtCargo.Location = New System.Drawing.Point(84, 136)
        Me.txtCargo.MaxLength = 100
        Me.txtCargo.Name = "txtCargo"
        Me.ajuda.SetShowHelp(Me.txtCargo, True)
        Me.txtCargo.Size = New System.Drawing.Size(191, 20)
        Me.txtCargo.TabIndex = 14
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(23, 139)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(38, 13)
        Me.Label15.TabIndex = 35
        Me.Label15.Text = "Cargo:"
        '
        'lblValCPF
        '
        Me.lblValCPF.AutoSize = True
        Me.lblValCPF.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblValCPF.ForeColor = System.Drawing.Color.Red
        Me.lblValCPF.Location = New System.Drawing.Point(276, 258)
        Me.lblValCPF.Name = "lblValCPF"
        Me.lblValCPF.Size = New System.Drawing.Size(12, 13)
        Me.lblValCPF.TabIndex = 34
        Me.lblValCPF.Text = "*"
        Me.lblValCPF.Visible = False
        '
        'lblValTelRes
        '
        Me.lblValTelRes.AutoSize = True
        Me.lblValTelRes.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblValTelRes.ForeColor = System.Drawing.Color.Red
        Me.lblValTelRes.Location = New System.Drawing.Point(276, 197)
        Me.lblValTelRes.Name = "lblValTelRes"
        Me.lblValTelRes.Size = New System.Drawing.Size(12, 13)
        Me.lblValTelRes.TabIndex = 33
        Me.lblValTelRes.Text = "*"
        Me.lblValTelRes.Visible = False
        '
        'lblValEndereco
        '
        Me.lblValEndereco.AutoSize = True
        Me.lblValEndereco.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblValEndereco.ForeColor = System.Drawing.Color.Red
        Me.lblValEndereco.Location = New System.Drawing.Point(494, 108)
        Me.lblValEndereco.Name = "lblValEndereco"
        Me.lblValEndereco.Size = New System.Drawing.Size(12, 13)
        Me.lblValEndereco.TabIndex = 32
        Me.lblValEndereco.Text = "*"
        Me.lblValEndereco.Visible = False
        '
        'lblValNome
        '
        Me.lblValNome.AutoSize = True
        Me.lblValNome.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblValNome.ForeColor = System.Drawing.Color.Red
        Me.lblValNome.Location = New System.Drawing.Point(494, 77)
        Me.lblValNome.Name = "lblValNome"
        Me.lblValNome.Size = New System.Drawing.Size(12, 13)
        Me.lblValNome.TabIndex = 31
        Me.lblValNome.Text = "*"
        Me.lblValNome.Visible = False
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.Label14.Location = New System.Drawing.Point(297, 258)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(123, 13)
        Me.Label14.TabIndex = 30
        Me.Label14.Text = "Digite somente números."
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.Label13.Location = New System.Drawing.Point(297, 199)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(123, 13)
        Me.Label13.TabIndex = 29
        Me.Label13.Text = "Digite somente números."
        '
        'txtTelRes
        '
        Me.ajuda.SetHelpString(Me.txtTelRes, "Defina aqui o telefone residencial do usuário.")
        Me.txtTelRes.Location = New System.Drawing.Point(84, 195)
        Me.txtTelRes.Mask = "(99)9999-9999"
        Me.txtTelRes.Name = "txtTelRes"
        Me.ajuda.SetShowHelp(Me.txtTelRes, True)
        Me.txtTelRes.Size = New System.Drawing.Size(189, 20)
        Me.txtTelRes.TabIndex = 16
        '
        'txtCPF
        '
        Me.ajuda.SetHelpString(Me.txtCPF, "Defina aqui o CPF do usuário.")
        Me.txtCPF.Location = New System.Drawing.Point(84, 255)
        Me.txtCPF.Mask = "999,999,999-99"
        Me.txtCPF.Name = "txtCPF"
        Me.ajuda.SetShowHelp(Me.txtCPF, True)
        Me.txtCPF.Size = New System.Drawing.Size(191, 20)
        Me.txtCPF.TabIndex = 18
        '
        'lblDataCadastramento
        '
        Me.lblDataCadastramento.AutoSize = True
        Me.lblDataCadastramento.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDataCadastramento.Location = New System.Drawing.Point(276, 57)
        Me.lblDataCadastramento.Name = "lblDataCadastramento"
        Me.lblDataCadastramento.Size = New System.Drawing.Size(0, 13)
        Me.lblDataCadastramento.TabIndex = 23
        '
        'lblCodigo
        '
        Me.lblCodigo.AutoSize = True
        Me.lblCodigo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCodigo.Location = New System.Drawing.Point(71, 57)
        Me.lblCodigo.Name = "lblCodigo"
        Me.lblCodigo.Size = New System.Drawing.Size(0, 13)
        Me.lblCodigo.TabIndex = 22
        '
        'dpdPerfil
        '
        Me.dpdPerfil.FormattingEnabled = True
        Me.ajuda.SetHelpString(Me.dpdPerfil, "Escolha aqui o perfil que este usuário determinará no sistema. Para mais informaç" & _
                "ões sobre o perfil escolhido, posicione o ponteiro do mouse sobre a imagem ao la" & _
                "do.")
        Me.dpdPerfil.Location = New System.Drawing.Point(82, 437)
        Me.dpdPerfil.Name = "dpdPerfil"
        Me.ajuda.SetShowHelp(Me.dpdPerfil, True)
        Me.dpdPerfil.Size = New System.Drawing.Size(158, 21)
        Me.dpdPerfil.TabIndex = 23
        Me.dpdPerfil.Tag = ""
        '
        'txtRG
        '
        Me.ajuda.SetHelpString(Me.txtRG, "Digite aqui o RG do usuário.")
        Me.txtRG.Location = New System.Drawing.Point(84, 286)
        Me.txtRG.MaxLength = 20
        Me.txtRG.Name = "txtRG"
        Me.ajuda.SetShowHelp(Me.txtRG, True)
        Me.txtRG.Size = New System.Drawing.Size(191, 20)
        Me.txtRG.TabIndex = 19
        '
        'txtEmail
        '
        Me.ajuda.SetHelpString(Me.txtEmail, "Se necessário digite aqui o email do usuário.")
        Me.txtEmail.Location = New System.Drawing.Point(84, 167)
        Me.txtEmail.MaxLength = 300
        Me.txtEmail.Name = "txtEmail"
        Me.ajuda.SetShowHelp(Me.txtEmail, False)
        Me.txtEmail.Size = New System.Drawing.Size(409, 20)
        Me.txtEmail.TabIndex = 15
        '
        'txtEndereco
        '
        Me.ajuda.SetHelpString(Me.txtEndereco, "Digite aqui o endereço do usuário.")
        Me.txtEndereco.Location = New System.Drawing.Point(84, 105)
        Me.txtEndereco.MaxLength = 100
        Me.txtEndereco.Name = "txtEndereco"
        Me.ajuda.SetShowHelp(Me.txtEndereco, True)
        Me.txtEndereco.Size = New System.Drawing.Size(408, 20)
        Me.txtEndereco.TabIndex = 13
        '
        'txtNome
        '
        Me.ajuda.SetHelpString(Me.txtNome, "Digite aqui o nome do usuário.")
        Me.txtNome.Location = New System.Drawing.Point(84, 77)
        Me.txtNome.MaxLength = 100
        Me.txtNome.Name = "txtNome"
        Me.ajuda.SetShowHelp(Me.txtNome, True)
        Me.txtNome.Size = New System.Drawing.Size(409, 20)
        Me.txtNome.TabIndex = 12
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(24, 440)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(33, 13)
        Me.Label12.TabIndex = 11
        Me.Label12.Text = "Perfil:"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(22, 289)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(26, 13)
        Me.Label11.TabIndex = 10
        Me.Label11.Text = "RG:"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(23, 258)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(30, 13)
        Me.Label10.TabIndex = 9
        Me.Label10.Text = "CPF:"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(23, 170)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(38, 13)
        Me.Label9.TabIndex = 8
        Me.Label9.Text = "E-mail:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(23, 199)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(59, 13)
        Me.Label8.TabIndex = 7
        Me.Label8.Text = "Fone Res.:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(22, 108)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(56, 13)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Endereço:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(22, 80)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(38, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Nome:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(151, 57)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(122, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Data do Cadastramento:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(22, 57)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(43, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Código:"
        '
        'tstMenu
        '
        Me.tstMenu.BackColor = System.Drawing.Color.White
        Me.tstMenu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.cmdNovo, Me.cmdSalvar, Me.cmdAlterar, Me.cmdExcluir, Me.cmdCancelar})
        Me.tstMenu.Location = New System.Drawing.Point(0, 0)
        Me.tstMenu.Name = "tstMenu"
        Me.tstMenu.RenderMode = System.Windows.Forms.ToolStripRenderMode.System
        Me.tstMenu.Size = New System.Drawing.Size(524, 30)
        Me.tstMenu.TabIndex = 0
        Me.tstMenu.Text = "Menu Principal"
        '
        'cmdNovo
        '
        Me.cmdNovo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.cmdNovo.Image = Global.SICEP.My.Resources.Resources.bt_novo
        Me.cmdNovo.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.cmdNovo.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.cmdNovo.Name = "cmdNovo"
        Me.cmdNovo.Size = New System.Drawing.Size(102, 27)
        Me.cmdNovo.Text = "&Novo"
        '
        'cmdSalvar
        '
        Me.cmdSalvar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.cmdSalvar.Image = Global.SICEP.My.Resources.Resources.bt_salvar
        Me.cmdSalvar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.cmdSalvar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.cmdSalvar.Name = "cmdSalvar"
        Me.cmdSalvar.Size = New System.Drawing.Size(102, 27)
        Me.cmdSalvar.Text = "&Salvar"
        '
        'cmdAlterar
        '
        Me.cmdAlterar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.cmdAlterar.Image = Global.SICEP.My.Resources.Resources.bt_alterar
        Me.cmdAlterar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.cmdAlterar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.cmdAlterar.Name = "cmdAlterar"
        Me.cmdAlterar.Size = New System.Drawing.Size(102, 27)
        Me.cmdAlterar.Text = "&Alterar"
        '
        'cmdExcluir
        '
        Me.cmdExcluir.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.cmdExcluir.Image = Global.SICEP.My.Resources.Resources.bt_excluir
        Me.cmdExcluir.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.cmdExcluir.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.cmdExcluir.Name = "cmdExcluir"
        Me.cmdExcluir.Size = New System.Drawing.Size(102, 27)
        Me.cmdExcluir.Text = "&Excluir"
        '
        'cmdCancelar
        '
        Me.cmdCancelar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.cmdCancelar.Image = Global.SICEP.My.Resources.Resources.bt_cancelar
        Me.cmdCancelar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.cmdCancelar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.cmdCancelar.Name = "cmdCancelar"
        Me.cmdCancelar.Size = New System.Drawing.Size(102, 27)
        Me.cmdCancelar.Text = "&Cancelar"
        '
        'pnlPesquisa
        '
        Me.pnlPesquisa.BackColor = System.Drawing.Color.Transparent
        Me.pnlPesquisa.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnlPesquisa.Controls.Add(Me.grdUsuario)
        Me.pnlPesquisa.Controls.Add(Me.txtPesquisa)
        Me.pnlPesquisa.Controls.Add(Me.Label1)
        Me.pnlPesquisa.Location = New System.Drawing.Point(2, 1)
        Me.pnlPesquisa.Name = "pnlPesquisa"
        Me.pnlPesquisa.Size = New System.Drawing.Size(115, 496)
        Me.pnlPesquisa.TabIndex = 2
        '
        'grdUsuario
        '
        Me.grdUsuario.AllowUserToAddRows = False
        Me.grdUsuario.AllowUserToDeleteRows = False
        Me.grdUsuario.AllowUserToOrderColumns = True
        Me.grdUsuario.AllowUserToResizeColumns = False
        Me.grdUsuario.AllowUserToResizeRows = False
        Me.grdUsuario.BackgroundColor = System.Drawing.Color.PaleTurquoise
        Me.grdUsuario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grdUsuario.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.cod_usuario, Me.nome_usuario})
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.grdUsuario.DefaultCellStyle = DataGridViewCellStyle1
        Me.ajuda.SetHelpString(Me.grdUsuario, "Clique no nome do usuário desejado para carregar suas informações para o formulár" & _
                "io ao lado.")
        Me.grdUsuario.Location = New System.Drawing.Point(2, 57)
        Me.grdUsuario.MultiSelect = False
        Me.grdUsuario.Name = "grdUsuario"
        Me.grdUsuario.ReadOnly = True
        Me.grdUsuario.RowHeadersVisible = False
        Me.grdUsuario.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.grdUsuario.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.ajuda.SetShowHelp(Me.grdUsuario, True)
        Me.grdUsuario.Size = New System.Drawing.Size(109, 434)
        Me.grdUsuario.TabIndex = 2
        '
        'cod_usuario
        '
        Me.cod_usuario.DataPropertyName = "cod_usuario"
        Me.cod_usuario.HeaderText = "Código"
        Me.cod_usuario.Name = "cod_usuario"
        Me.cod_usuario.ReadOnly = True
        Me.cod_usuario.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.cod_usuario.Visible = False
        '
        'nome_usuario
        '
        Me.nome_usuario.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.nome_usuario.DataPropertyName = "nome_usuario"
        Me.nome_usuario.HeaderText = "Usuário"
        Me.nome_usuario.Name = "nome_usuario"
        Me.nome_usuario.ReadOnly = True
        Me.nome_usuario.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.nome_usuario.ToolTipText = "Clique no nome do usuário para exibir suas informações."
        '
        'txtPesquisa
        '
        Me.ajuda.SetHelpString(Me.txtPesquisa, "Digite aqui o nome do usuário procurado. Repare que o sistema listará os usuários" & _
                " com o nome mais parecido com o digitado.")
        Me.txtPesquisa.Location = New System.Drawing.Point(2, 33)
        Me.txtPesquisa.MaxLength = 100
        Me.txtPesquisa.Name = "txtPesquisa"
        Me.ajuda.SetShowHelp(Me.txtPesquisa, True)
        Me.txtPesquisa.Size = New System.Drawing.Size(109, 20)
        Me.txtPesquisa.TabIndex = 11
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.PaleTurquoise
        Me.Label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label1.Location = New System.Drawing.Point(0, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(113, 30)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "PESQUISAR"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'ToolTip
        '
        Me.ToolTip.AutoPopDelay = 12000
        Me.ToolTip.InitialDelay = 500
        Me.ToolTip.IsBalloon = True
        Me.ToolTip.ReshowDelay = 100
        Me.ToolTip.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info
        Me.ToolTip.ToolTipTitle = "Informações"
        '
        'ajuda
        '
        Me.ajuda.HelpNamespace = "C:\Arquivos de programas\SICEP\Ajuda\frmCadUsuarios.html"
        '
        'frmCadUsuario
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(648, 498)
        Me.Controls.Add(Me.pnlFormulario)
        Me.Controls.Add(Me.pnlPesquisa)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.HelpButton = True
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmCadUsuario"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Formulário para Cadastro de Usuário"
        Me.pnlFormulario.ResumeLayout(False)
        Me.pnlFormulario.PerformLayout()
        CType(Me.imgInformacoes, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tstMenu.ResumeLayout(False)
        Me.tstMenu.PerformLayout()
        Me.pnlPesquisa.ResumeLayout(False)
        Me.pnlPesquisa.PerformLayout()
        CType(Me.grdUsuario, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents pnlFormulario As System.Windows.Forms.Panel
    Friend WithEvents lblValCPF As System.Windows.Forms.Label
    Friend WithEvents lblValTelRes As System.Windows.Forms.Label
    Friend WithEvents lblValEndereco As System.Windows.Forms.Label
    Friend WithEvents lblValNome As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents txtTelRes As System.Windows.Forms.MaskedTextBox
    Friend WithEvents txtCPF As System.Windows.Forms.MaskedTextBox
    Friend WithEvents lblDataCadastramento As System.Windows.Forms.Label
    Friend WithEvents lblCodigo As System.Windows.Forms.Label
    Friend WithEvents dpdPerfil As System.Windows.Forms.ComboBox
    Friend WithEvents txtRG As System.Windows.Forms.TextBox
    Friend WithEvents txtEndereco As System.Windows.Forms.TextBox
    Friend WithEvents txtNome As System.Windows.Forms.TextBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents tstMenu As System.Windows.Forms.ToolStrip
    Friend WithEvents cmdNovo As System.Windows.Forms.ToolStripButton
    Friend WithEvents cmdSalvar As System.Windows.Forms.ToolStripButton
    Friend WithEvents cmdAlterar As System.Windows.Forms.ToolStripButton
    Friend WithEvents cmdExcluir As System.Windows.Forms.ToolStripButton
    Friend WithEvents cmdCancelar As System.Windows.Forms.ToolStripButton
    Friend WithEvents pnlPesquisa As System.Windows.Forms.Panel
    Friend WithEvents grdUsuario As System.Windows.Forms.DataGridView
    Friend WithEvents txtPesquisa As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents lblValTelCel As System.Windows.Forms.Label
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents txtTelCel As System.Windows.Forms.MaskedTextBox
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents txtCargo As System.Windows.Forms.TextBox
    Friend WithEvents txtSenha As System.Windows.Forms.TextBox
    Friend WithEvents txtConfSenha As System.Windows.Forms.TextBox
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents txtLogin As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtEmail As System.Windows.Forms.TextBox
    Friend WithEvents lblValLogin As System.Windows.Forms.Label
    Friend WithEvents lblValConfSenha As System.Windows.Forms.Label
    Friend WithEvents lblValSenha As System.Windows.Forms.Label
    Friend WithEvents cod_usuario As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents nome_usuario As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents imgInformacoes As System.Windows.Forms.PictureBox
    Friend WithEvents ToolTip As System.Windows.Forms.ToolTip
    Friend WithEvents lkImprimir As System.Windows.Forms.LinkLabel
    Friend WithEvents ajuda As System.Windows.Forms.HelpProvider
End Class
