<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCadPaciente
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmCadPaciente))
        Me.BottomToolStripPanel = New System.Windows.Forms.ToolStripPanel
        Me.TopToolStripPanel = New System.Windows.Forms.ToolStripPanel
        Me.RightToolStripPanel = New System.Windows.Forms.ToolStripPanel
        Me.LeftToolStripPanel = New System.Windows.Forms.ToolStripPanel
        Me.pnlPesquisa = New System.Windows.Forms.Panel
        Me.grdPacientes = New System.Windows.Forms.DataGridView
        Me.cod_paciente = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.nome_paciente = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.txtPesquisa = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.pnlFormulario = New System.Windows.Forms.Panel
        Me.lkImprimir = New System.Windows.Forms.LinkLabel
        Me.Label21 = New System.Windows.Forms.Label
        Me.lblValCPF = New System.Windows.Forms.Label
        Me.lblValTelefone = New System.Windows.Forms.Label
        Me.lblValEndereco = New System.Windows.Forms.Label
        Me.lblValNome = New System.Windows.Forms.Label
        Me.Label14 = New System.Windows.Forms.Label
        Me.Label13 = New System.Windows.Forms.Label
        Me.txtDataNasc = New System.Windows.Forms.DateTimePicker
        Me.txtTelefone = New System.Windows.Forms.MaskedTextBox
        Me.txtCPF = New System.Windows.Forms.MaskedTextBox
        Me.imgInformacoes = New System.Windows.Forms.PictureBox
        Me.lblDataCadastramento = New System.Windows.Forms.Label
        Me.lblCodigo = New System.Windows.Forms.Label
        Me.dpdMicroarea = New System.Windows.Forms.ComboBox
        Me.txtRG = New System.Windows.Forms.TextBox
        Me.txtMae = New System.Windows.Forms.TextBox
        Me.rbtFeminino = New System.Windows.Forms.RadioButton
        Me.rbtMasculino = New System.Windows.Forms.RadioButton
        Me.txtEndereco = New System.Windows.Forms.TextBox
        Me.txtNome = New System.Windows.Forms.TextBox
        Me.Label12 = New System.Windows.Forms.Label
        Me.Label11 = New System.Windows.Forms.Label
        Me.Label10 = New System.Windows.Forms.Label
        Me.Label9 = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
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
        Me.ContentPanel = New System.Windows.Forms.ToolStripContentPanel
        Me.ToolTip = New System.Windows.Forms.ToolTip(Me.components)
        Me.ajuda = New System.Windows.Forms.HelpProvider
        Me.pnlPesquisa.SuspendLayout()
        CType(Me.grdPacientes, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlFormulario.SuspendLayout()
        CType(Me.imgInformacoes, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tstMenu.SuspendLayout()
        Me.SuspendLayout()
        '
        'BottomToolStripPanel
        '
        Me.BottomToolStripPanel.Location = New System.Drawing.Point(0, 0)
        Me.BottomToolStripPanel.Name = "BottomToolStripPanel"
        Me.BottomToolStripPanel.Orientation = System.Windows.Forms.Orientation.Horizontal
        Me.BottomToolStripPanel.RowMargin = New System.Windows.Forms.Padding(3, 0, 0, 0)
        Me.BottomToolStripPanel.Size = New System.Drawing.Size(0, 0)
        '
        'TopToolStripPanel
        '
        Me.TopToolStripPanel.Location = New System.Drawing.Point(0, 0)
        Me.TopToolStripPanel.Name = "TopToolStripPanel"
        Me.TopToolStripPanel.Orientation = System.Windows.Forms.Orientation.Horizontal
        Me.TopToolStripPanel.RowMargin = New System.Windows.Forms.Padding(3, 0, 0, 0)
        Me.TopToolStripPanel.Size = New System.Drawing.Size(0, 0)
        '
        'RightToolStripPanel
        '
        Me.RightToolStripPanel.Location = New System.Drawing.Point(0, 0)
        Me.RightToolStripPanel.Name = "RightToolStripPanel"
        Me.RightToolStripPanel.Orientation = System.Windows.Forms.Orientation.Horizontal
        Me.RightToolStripPanel.RowMargin = New System.Windows.Forms.Padding(3, 0, 0, 0)
        Me.RightToolStripPanel.Size = New System.Drawing.Size(0, 0)
        '
        'LeftToolStripPanel
        '
        Me.LeftToolStripPanel.Location = New System.Drawing.Point(0, 0)
        Me.LeftToolStripPanel.Name = "LeftToolStripPanel"
        Me.LeftToolStripPanel.Orientation = System.Windows.Forms.Orientation.Horizontal
        Me.LeftToolStripPanel.RowMargin = New System.Windows.Forms.Padding(3, 0, 0, 0)
        Me.LeftToolStripPanel.Size = New System.Drawing.Size(0, 0)
        '
        'pnlPesquisa
        '
        Me.pnlPesquisa.BackColor = System.Drawing.Color.Transparent
        Me.pnlPesquisa.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnlPesquisa.Controls.Add(Me.grdPacientes)
        Me.pnlPesquisa.Controls.Add(Me.txtPesquisa)
        Me.pnlPesquisa.Controls.Add(Me.Label1)
        Me.pnlPesquisa.Location = New System.Drawing.Point(0, 1)
        Me.pnlPesquisa.Name = "pnlPesquisa"
        Me.pnlPesquisa.Size = New System.Drawing.Size(115, 401)
        Me.pnlPesquisa.TabIndex = 0
        '
        'grdPacientes
        '
        Me.grdPacientes.AllowUserToAddRows = False
        Me.grdPacientes.AllowUserToDeleteRows = False
        Me.grdPacientes.AllowUserToOrderColumns = True
        Me.grdPacientes.AllowUserToResizeColumns = False
        Me.grdPacientes.AllowUserToResizeRows = False
        Me.grdPacientes.BackgroundColor = System.Drawing.Color.PaleTurquoise
        Me.grdPacientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grdPacientes.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.cod_paciente, Me.nome_paciente})
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.grdPacientes.DefaultCellStyle = DataGridViewCellStyle1
        Me.ajuda.SetHelpString(Me.grdPacientes, "Clique no nome do paciente para carregar seus dados para o formulário ao lado")
        Me.grdPacientes.Location = New System.Drawing.Point(2, 57)
        Me.grdPacientes.MultiSelect = False
        Me.grdPacientes.Name = "grdPacientes"
        Me.grdPacientes.ReadOnly = True
        Me.grdPacientes.RowHeadersVisible = False
        Me.grdPacientes.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.grdPacientes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.ajuda.SetShowHelp(Me.grdPacientes, True)
        Me.grdPacientes.Size = New System.Drawing.Size(109, 339)
        Me.grdPacientes.TabIndex = 2
        '
        'cod_paciente
        '
        Me.cod_paciente.DataPropertyName = "cod_paciente"
        Me.cod_paciente.HeaderText = "Código"
        Me.cod_paciente.Name = "cod_paciente"
        Me.cod_paciente.ReadOnly = True
        Me.cod_paciente.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.cod_paciente.Visible = False
        '
        'nome_paciente
        '
        Me.nome_paciente.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.nome_paciente.DataPropertyName = "nome_paciente"
        Me.nome_paciente.HeaderText = "Paciente"
        Me.nome_paciente.Name = "nome_paciente"
        Me.nome_paciente.ReadOnly = True
        Me.nome_paciente.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.nome_paciente.ToolTipText = "Clique no nome do paciente para exibir suas informações."
        '
        'txtPesquisa
        '
        Me.ajuda.SetHelpString(Me.txtPesquisa, "Digite nesta caixa o nome do paciente procurado. Repare que o sistema listará os " & _
                "nomes mais parecidos com o digitado.")
        Me.txtPesquisa.Location = New System.Drawing.Point(2, 33)
        Me.txtPesquisa.MaxLength = 100
        Me.txtPesquisa.Name = "txtPesquisa"
        Me.ajuda.SetShowHelp(Me.txtPesquisa, True)
        Me.txtPesquisa.Size = New System.Drawing.Size(109, 20)
        Me.txtPesquisa.TabIndex = 1
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
        'pnlFormulario
        '
        Me.pnlFormulario.BackColor = System.Drawing.Color.Transparent
        Me.pnlFormulario.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnlFormulario.Controls.Add(Me.lkImprimir)
        Me.pnlFormulario.Controls.Add(Me.Label21)
        Me.pnlFormulario.Controls.Add(Me.lblValCPF)
        Me.pnlFormulario.Controls.Add(Me.lblValTelefone)
        Me.pnlFormulario.Controls.Add(Me.lblValEndereco)
        Me.pnlFormulario.Controls.Add(Me.lblValNome)
        Me.pnlFormulario.Controls.Add(Me.Label14)
        Me.pnlFormulario.Controls.Add(Me.Label13)
        Me.pnlFormulario.Controls.Add(Me.txtDataNasc)
        Me.pnlFormulario.Controls.Add(Me.txtTelefone)
        Me.pnlFormulario.Controls.Add(Me.txtCPF)
        Me.pnlFormulario.Controls.Add(Me.imgInformacoes)
        Me.pnlFormulario.Controls.Add(Me.lblDataCadastramento)
        Me.pnlFormulario.Controls.Add(Me.lblCodigo)
        Me.pnlFormulario.Controls.Add(Me.dpdMicroarea)
        Me.pnlFormulario.Controls.Add(Me.txtRG)
        Me.pnlFormulario.Controls.Add(Me.txtMae)
        Me.pnlFormulario.Controls.Add(Me.rbtFeminino)
        Me.pnlFormulario.Controls.Add(Me.rbtMasculino)
        Me.pnlFormulario.Controls.Add(Me.txtEndereco)
        Me.pnlFormulario.Controls.Add(Me.txtNome)
        Me.pnlFormulario.Controls.Add(Me.Label12)
        Me.pnlFormulario.Controls.Add(Me.Label11)
        Me.pnlFormulario.Controls.Add(Me.Label10)
        Me.pnlFormulario.Controls.Add(Me.Label9)
        Me.pnlFormulario.Controls.Add(Me.Label8)
        Me.pnlFormulario.Controls.Add(Me.Label7)
        Me.pnlFormulario.Controls.Add(Me.Label6)
        Me.pnlFormulario.Controls.Add(Me.Label5)
        Me.pnlFormulario.Controls.Add(Me.Label4)
        Me.pnlFormulario.Controls.Add(Me.Label3)
        Me.pnlFormulario.Controls.Add(Me.Label2)
        Me.pnlFormulario.Controls.Add(Me.tstMenu)
        Me.pnlFormulario.Location = New System.Drawing.Point(117, 1)
        Me.pnlFormulario.Name = "pnlFormulario"
        Me.pnlFormulario.Size = New System.Drawing.Size(526, 401)
        Me.pnlFormulario.TabIndex = 1
        '
        'lkImprimir
        '
        Me.lkImprimir.AutoSize = True
        Me.ajuda.SetHelpString(Me.lkImprimir, "Clique aqui para ver uma relação de todos os pacientes cadastrados no sistema em " & _
                "modo de impressão.")
        Me.lkImprimir.Location = New System.Drawing.Point(23, 380)
        Me.lkImprimir.Name = "lkImprimir"
        Me.ajuda.SetShowHelp(Me.lkImprimir, True)
        Me.lkImprimir.Size = New System.Drawing.Size(231, 13)
        Me.lkImprimir.TabIndex = 55
        Me.lkImprimir.TabStop = True
        Me.lkImprimir.Text = "Ver relatório de todos os pacientes cadastrados"
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label21.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.Label21.Location = New System.Drawing.Point(22, 36)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(97, 13)
        Me.Label21.TabIndex = 54
        Me.Label21.Text = "Dados Pessoais"
        '
        'lblValCPF
        '
        Me.lblValCPF.AutoSize = True
        Me.lblValCPF.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblValCPF.ForeColor = System.Drawing.Color.Red
        Me.lblValCPF.Location = New System.Drawing.Point(274, 276)
        Me.lblValCPF.Name = "lblValCPF"
        Me.lblValCPF.Size = New System.Drawing.Size(12, 13)
        Me.lblValCPF.TabIndex = 34
        Me.lblValCPF.Text = "*"
        Me.lblValCPF.Visible = False
        '
        'lblValTelefone
        '
        Me.lblValTelefone.AutoSize = True
        Me.lblValTelefone.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblValTelefone.ForeColor = System.Drawing.Color.Red
        Me.lblValTelefone.Location = New System.Drawing.Point(274, 244)
        Me.lblValTelefone.Name = "lblValTelefone"
        Me.lblValTelefone.Size = New System.Drawing.Size(12, 13)
        Me.lblValTelefone.TabIndex = 33
        Me.lblValTelefone.Text = "*"
        Me.lblValTelefone.Visible = False
        '
        'lblValEndereco
        '
        Me.lblValEndereco.AutoSize = True
        Me.lblValEndereco.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblValEndereco.ForeColor = System.Drawing.Color.Red
        Me.lblValEndereco.Location = New System.Drawing.Point(509, 153)
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
        Me.lblValNome.Location = New System.Drawing.Point(509, 119)
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
        Me.Label14.Location = New System.Drawing.Point(283, 276)
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
        Me.Label13.Location = New System.Drawing.Point(283, 246)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(123, 13)
        Me.Label13.TabIndex = 29
        Me.Label13.Text = "Digite somente números."
        '
        'txtDataNasc
        '
        Me.txtDataNasc.CustomFormat = "dd/mm/yyyy"
        Me.txtDataNasc.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.ajuda.SetHelpString(Me.txtDataNasc, "Defina aqui a data de nascimente do paciente. Digitando-a ou clicando sobre a set" & _
                "a ao lado da caixa para exibir o calendário.")
        Me.txtDataNasc.Location = New System.Drawing.Point(82, 180)
        Me.txtDataNasc.MaxDate = New Date(2200, 12, 12, 0, 0, 0, 0)
        Me.txtDataNasc.MinDate = New Date(1800, 1, 1, 0, 0, 0, 0)
        Me.txtDataNasc.Name = "txtDataNasc"
        Me.ajuda.SetShowHelp(Me.txtDataNasc, True)
        Me.txtDataNasc.Size = New System.Drawing.Size(191, 20)
        Me.txtDataNasc.TabIndex = 14
        Me.txtDataNasc.Value = New Date(2006, 8, 9, 0, 0, 0, 0)
        '
        'txtTelefone
        '
        Me.ajuda.SetHelpString(Me.txtTelefone, "Se necessário digite aqui o telefone do paciente.")
        Me.txtTelefone.Location = New System.Drawing.Point(84, 243)
        Me.txtTelefone.Mask = "(99)9999-9999"
        Me.txtTelefone.Name = "txtTelefone"
        Me.ajuda.SetShowHelp(Me.txtTelefone, True)
        Me.txtTelefone.Size = New System.Drawing.Size(189, 20)
        Me.txtTelefone.TabIndex = 18
        '
        'txtCPF
        '
        Me.ajuda.SetHelpString(Me.txtCPF, "Digite aqui o CPF do paciente.")
        Me.txtCPF.Location = New System.Drawing.Point(82, 273)
        Me.txtCPF.Mask = "999,999,999-99"
        Me.txtCPF.Name = "txtCPF"
        Me.ajuda.SetShowHelp(Me.txtCPF, True)
        Me.txtCPF.Size = New System.Drawing.Size(191, 20)
        Me.txtCPF.TabIndex = 19
        '
        'imgInformacoes
        '
        Me.imgInformacoes.Image = Global.SICEP.My.Resources.Resources.infos
        Me.imgInformacoes.Location = New System.Drawing.Point(286, 335)
        Me.imgInformacoes.Name = "imgInformacoes"
        Me.imgInformacoes.Size = New System.Drawing.Size(21, 21)
        Me.imgInformacoes.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.imgInformacoes.TabIndex = 24
        Me.imgInformacoes.TabStop = False
        '
        'lblDataCadastramento
        '
        Me.lblDataCadastramento.AutoSize = True
        Me.lblDataCadastramento.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDataCadastramento.Location = New System.Drawing.Point(276, 78)
        Me.lblDataCadastramento.Name = "lblDataCadastramento"
        Me.lblDataCadastramento.Size = New System.Drawing.Size(0, 13)
        Me.lblDataCadastramento.TabIndex = 23
        '
        'lblCodigo
        '
        Me.lblCodigo.AutoSize = True
        Me.lblCodigo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCodigo.Location = New System.Drawing.Point(71, 78)
        Me.lblCodigo.Name = "lblCodigo"
        Me.lblCodigo.Size = New System.Drawing.Size(0, 13)
        Me.lblCodigo.TabIndex = 22
        '
        'dpdMicroarea
        '
        Me.dpdMicroarea.FormattingEnabled = True
        Me.ajuda.SetHelpString(Me.dpdMicroarea, "Selecione aqui o código da micro-área onde este paciente reside. Para ver mais in" & _
                "formações sobre esta micro-área posicione o ponteiro do mouse em cima da figura " & _
                "ao lado.")
        Me.dpdMicroarea.Location = New System.Drawing.Point(82, 335)
        Me.dpdMicroarea.Name = "dpdMicroarea"
        Me.ajuda.SetShowHelp(Me.dpdMicroarea, True)
        Me.dpdMicroarea.Size = New System.Drawing.Size(191, 21)
        Me.dpdMicroarea.TabIndex = 21
        Me.dpdMicroarea.Tag = ""
        Me.dpdMicroarea.Text = "-Selecione-"
        '
        'txtRG
        '
        Me.ajuda.SetHelpString(Me.txtRG, "Digite aqui o RG do paciente.")
        Me.txtRG.Location = New System.Drawing.Point(82, 304)
        Me.txtRG.MaxLength = 20
        Me.txtRG.Name = "txtRG"
        Me.ajuda.SetShowHelp(Me.txtRG, True)
        Me.txtRG.Size = New System.Drawing.Size(191, 20)
        Me.txtRG.TabIndex = 20
        '
        'txtMae
        '
        Me.ajuda.SetHelpString(Me.txtMae, "Se necessário digite aqui o nome da mãe.")
        Me.txtMae.Location = New System.Drawing.Point(82, 210)
        Me.txtMae.MaxLength = 100
        Me.txtMae.Name = "txtMae"
        Me.ajuda.SetShowHelp(Me.txtMae, False)
        Me.txtMae.Size = New System.Drawing.Size(424, 20)
        Me.txtMae.TabIndex = 17
        '
        'rbtFeminino
        '
        Me.rbtFeminino.AutoSize = True
        Me.ajuda.SetHelpString(Me.rbtFeminino, "Define o paciente com Mulher.")
        Me.rbtFeminino.Location = New System.Drawing.Point(418, 182)
        Me.rbtFeminino.Name = "rbtFeminino"
        Me.ajuda.SetShowHelp(Me.rbtFeminino, True)
        Me.rbtFeminino.Size = New System.Drawing.Size(67, 17)
        Me.rbtFeminino.TabIndex = 16
        Me.rbtFeminino.Text = "Feminino"
        Me.rbtFeminino.UseVisualStyleBackColor = True
        '
        'rbtMasculino
        '
        Me.rbtMasculino.AutoSize = True
        Me.rbtMasculino.Checked = True
        Me.ajuda.SetHelpString(Me.rbtMasculino, "Define o paciente como Homem.")
        Me.rbtMasculino.Location = New System.Drawing.Point(339, 182)
        Me.rbtMasculino.Name = "rbtMasculino"
        Me.ajuda.SetShowHelp(Me.rbtMasculino, True)
        Me.rbtMasculino.Size = New System.Drawing.Size(73, 17)
        Me.rbtMasculino.TabIndex = 15
        Me.rbtMasculino.TabStop = True
        Me.rbtMasculino.Text = "Masculino"
        Me.rbtMasculino.UseVisualStyleBackColor = True
        '
        'txtEndereco
        '
        Me.ajuda.SetHelpString(Me.txtEndereco, "Digite aqui o endereço residencial do paciente.")
        Me.txtEndereco.Location = New System.Drawing.Point(82, 150)
        Me.txtEndereco.MaxLength = 100
        Me.txtEndereco.Name = "txtEndereco"
        Me.ajuda.SetShowHelp(Me.txtEndereco, True)
        Me.txtEndereco.Size = New System.Drawing.Size(424, 20)
        Me.txtEndereco.TabIndex = 13
        '
        'txtNome
        '
        Me.ajuda.SetHelpString(Me.txtNome, "Digite aqui o nome do paciente.")
        Me.txtNome.Location = New System.Drawing.Point(82, 119)
        Me.txtNome.MaxLength = 100
        Me.txtNome.Name = "txtNome"
        Me.ajuda.SetShowHelp(Me.txtNome, True)
        Me.txtNome.Size = New System.Drawing.Size(424, 20)
        Me.txtNome.TabIndex = 12
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(22, 338)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(61, 13)
        Me.Label12.TabIndex = 11
        Me.Label12.Text = "Micro-Área:"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(22, 307)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(26, 13)
        Me.Label11.TabIndex = 10
        Me.Label11.Text = "RG:"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(23, 276)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(30, 13)
        Me.Label10.TabIndex = 9
        Me.Label10.Text = "CPF:"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(22, 213)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(31, 13)
        Me.Label9.TabIndex = 8
        Me.Label9.Text = "Mãe:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(22, 246)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(52, 13)
        Me.Label8.TabIndex = 7
        Me.Label8.Text = "Telefone:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(299, 184)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(34, 13)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = "Sexo:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(22, 184)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(61, 13)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Data Nasc:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(22, 153)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(56, 13)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Endereço:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(22, 122)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(38, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Nome:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(151, 78)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(122, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Data do Cadastramento:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(22, 78)
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
        Me.tstMenu.Text = "ToolStrip1"
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
        'ContentPanel
        '
        Me.ContentPanel.BackgroundImage = Global.SICEP.My.Resources.Resources.bg_form800600
        Me.ContentPanel.Size = New System.Drawing.Size(402, 382)
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
        Me.ajuda.HelpNamespace = "C:\Arquivos de programas\SICEP\Ajuda\frmCadPacientes.html"
        '
        'frmCadPaciente
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(644, 404)
        Me.Controls.Add(Me.pnlFormulario)
        Me.Controls.Add(Me.pnlPesquisa)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.HelpButton = True
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmCadPaciente"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Formulário para Cadastro de Paciente"
        Me.pnlPesquisa.ResumeLayout(False)
        Me.pnlPesquisa.PerformLayout()
        CType(Me.grdPacientes, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlFormulario.ResumeLayout(False)
        Me.pnlFormulario.PerformLayout()
        CType(Me.imgInformacoes, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tstMenu.ResumeLayout(False)
        Me.tstMenu.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents BottomToolStripPanel As System.Windows.Forms.ToolStripPanel
    Friend WithEvents TopToolStripPanel As System.Windows.Forms.ToolStripPanel
    Friend WithEvents RightToolStripPanel As System.Windows.Forms.ToolStripPanel
    Friend WithEvents LeftToolStripPanel As System.Windows.Forms.ToolStripPanel
    Friend WithEvents ContentPanel As System.Windows.Forms.ToolStripContentPanel
    Friend WithEvents pnlPesquisa As System.Windows.Forms.Panel
    Friend WithEvents pnlFormulario As System.Windows.Forms.Panel
    Friend WithEvents tstMenu As System.Windows.Forms.ToolStrip
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cmdNovo As System.Windows.Forms.ToolStripButton
    Friend WithEvents cmdSalvar As System.Windows.Forms.ToolStripButton
    Friend WithEvents cmdAlterar As System.Windows.Forms.ToolStripButton
    Friend WithEvents cmdExcluir As System.Windows.Forms.ToolStripButton
    Friend WithEvents cmdCancelar As System.Windows.Forms.ToolStripButton
    Friend WithEvents txtPesquisa As System.Windows.Forms.TextBox
    Friend WithEvents grdPacientes As System.Windows.Forms.DataGridView
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents rbtFeminino As System.Windows.Forms.RadioButton
    Friend WithEvents rbtMasculino As System.Windows.Forms.RadioButton
    Friend WithEvents txtEndereco As System.Windows.Forms.TextBox
    Friend WithEvents txtNome As System.Windows.Forms.TextBox
    Friend WithEvents dpdMicroarea As System.Windows.Forms.ComboBox
    Friend WithEvents txtRG As System.Windows.Forms.TextBox
    Friend WithEvents txtMae As System.Windows.Forms.TextBox
    Friend WithEvents lblDataCadastramento As System.Windows.Forms.Label
    Friend WithEvents lblCodigo As System.Windows.Forms.Label
    Friend WithEvents cod_paciente As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents nome_paciente As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents imgInformacoes As System.Windows.Forms.PictureBox
    Friend WithEvents ToolTip As System.Windows.Forms.ToolTip
    Friend WithEvents txtCPF As System.Windows.Forms.MaskedTextBox
    Friend WithEvents txtTelefone As System.Windows.Forms.MaskedTextBox
    Friend WithEvents txtDataNasc As System.Windows.Forms.DateTimePicker
    Friend WithEvents lblValEndereco As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents lblValCPF As System.Windows.Forms.Label
    Friend WithEvents lblValTelefone As System.Windows.Forms.Label
    Friend WithEvents lblValNome As System.Windows.Forms.Label
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents lkImprimir As System.Windows.Forms.LinkLabel
    Friend WithEvents ajuda As System.Windows.Forms.HelpProvider
End Class
