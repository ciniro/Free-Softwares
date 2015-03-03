<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmEntSecretaria
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmEntSecretaria))
        Me.txtDataCadastro = New System.Windows.Forms.DateTimePicker
        Me.txtNumNota = New System.Windows.Forms.TextBox
        Me.txtNumLote = New System.Windows.Forms.TextBox
        Me.ltbMedicamentos = New System.Windows.Forms.ListBox
        Me.txtValidade = New System.Windows.Forms.DateTimePicker
        Me.txtQuantidade = New System.Windows.Forms.TextBox
        Me.grdMedicamentos = New System.Windows.Forms.DataGridView
        Me.cod_medicamento = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.nome_medicamento = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.quant_medicamento = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.val_medicamento = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.lblUsuarioCadastrante = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.cmdAnexar = New System.Windows.Forms.Button
        Me.cmdDesanexar = New System.Windows.Forms.Button
        Me.cmdEfetuarEntradas = New System.Windows.Forms.Button
        Me.cmdEditarEntradas = New System.Windows.Forms.Button
        Me.cmdLimparNota = New System.Windows.Forms.Button
        Me.lkVerEstoque = New System.Windows.Forms.LinkLabel
        Me.ToolTip = New System.Windows.Forms.ToolTip(Me.components)
        Me.Label8 = New System.Windows.Forms.Label
        Me.lblValQuantidade = New System.Windows.Forms.Label
        Me.lblValMedicamentos = New System.Windows.Forms.Label
        Me.imgInformacoes = New System.Windows.Forms.PictureBox
        Me.chkMedicamentos = New System.Windows.Forms.CheckBox
        Me.chkMateriais = New System.Windows.Forms.CheckBox
        Me.ajuda = New System.Windows.Forms.HelpProvider
        CType(Me.grdMedicamentos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.imgInformacoes, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtDataCadastro
        '
        Me.txtDataCadastro.CalendarFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDataCadastro.Enabled = False
        Me.txtDataCadastro.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDataCadastro.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.ajuda.SetHelpString(Me.txtDataCadastro, "Data de hoje.")
        Me.txtDataCadastro.Location = New System.Drawing.Point(355, 37)
        Me.txtDataCadastro.MaxDate = New Date(2006, 8, 14, 0, 0, 0, 0)
        Me.txtDataCadastro.Name = "txtDataCadastro"
        Me.ajuda.SetShowHelp(Me.txtDataCadastro, True)
        Me.txtDataCadastro.Size = New System.Drawing.Size(100, 20)
        Me.txtDataCadastro.TabIndex = 9
        Me.txtDataCadastro.Value = New Date(2006, 8, 14, 0, 0, 0, 0)
        '
        'txtNumNota
        '
        Me.ajuda.SetHelpString(Me.txtNumNota, "Se necessário digite aqui o número da nota de entrada.")
        Me.txtNumNota.Location = New System.Drawing.Point(328, 64)
        Me.txtNumNota.MaxLength = 100
        Me.txtNumNota.Name = "txtNumNota"
        Me.ajuda.SetShowHelp(Me.txtNumNota, True)
        Me.txtNumNota.Size = New System.Drawing.Size(127, 20)
        Me.txtNumNota.TabIndex = 10
        '
        'txtNumLote
        '
        Me.ajuda.SetHelpString(Me.txtNumLote, "Se necessário digite aqui o número do lote que vai dar entrada.")
        Me.txtNumLote.Location = New System.Drawing.Point(328, 94)
        Me.txtNumLote.MaxLength = 100
        Me.txtNumLote.Name = "txtNumLote"
        Me.ajuda.SetShowHelp(Me.txtNumLote, True)
        Me.txtNumLote.Size = New System.Drawing.Size(127, 20)
        Me.txtNumLote.TabIndex = 11
        '
        'ltbMedicamentos
        '
        Me.ltbMedicamentos.FormattingEnabled = True
        Me.ajuda.SetHelpString(Me.ltbMedicamentos, "Clique sobre o nome do item que deseja da entrada em estoque.")
        Me.ltbMedicamentos.Location = New System.Drawing.Point(12, 64)
        Me.ltbMedicamentos.Name = "ltbMedicamentos"
        Me.ajuda.SetShowHelp(Me.ltbMedicamentos, True)
        Me.ltbMedicamentos.Size = New System.Drawing.Size(221, 238)
        Me.ltbMedicamentos.TabIndex = 0
        '
        'txtValidade
        '
        Me.txtValidade.Font = New System.Drawing.Font("Microsoft Sans Serif", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtValidade.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.ajuda.SetHelpString(Me.txtValidade, "Selecione a validade do item que entrará em estoque.")
        Me.txtValidade.Location = New System.Drawing.Point(242, 135)
        Me.txtValidade.Name = "txtValidade"
        Me.ajuda.SetShowHelp(Me.txtValidade, True)
        Me.txtValidade.ShowUpDown = True
        Me.txtValidade.Size = New System.Drawing.Size(356, 49)
        Me.txtValidade.TabIndex = 1
        '
        'txtQuantidade
        '
        Me.txtQuantidade.Font = New System.Drawing.Font("Microsoft Sans Serif", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtQuantidade.ForeColor = System.Drawing.Color.Red
        Me.ajuda.SetHelpString(Me.txtQuantidade, "Digite aqui a quantidade que será inserida em estoque para o item selecionado.")
        Me.txtQuantidade.Location = New System.Drawing.Point(242, 219)
        Me.txtQuantidade.MaxLength = 8
        Me.txtQuantidade.Name = "txtQuantidade"
        Me.ajuda.SetShowHelp(Me.txtQuantidade, True)
        Me.txtQuantidade.Size = New System.Drawing.Size(356, 49)
        Me.txtQuantidade.TabIndex = 2
        '
        'grdMedicamentos
        '
        Me.grdMedicamentos.AllowUserToAddRows = False
        Me.grdMedicamentos.AllowUserToOrderColumns = True
        Me.grdMedicamentos.AllowUserToResizeColumns = False
        Me.grdMedicamentos.AllowUserToResizeRows = False
        Me.grdMedicamentos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.grdMedicamentos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grdMedicamentos.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.cod_medicamento, Me.nome_medicamento, Me.quant_medicamento, Me.val_medicamento})
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.grdMedicamentos.DefaultCellStyle = DataGridViewCellStyle1
        Me.ajuda.SetHelpString(Me.grdMedicamentos, "Nota. Se desejar desanexar algum item, selecione-o clicando sobre ele e em seguid" & _
                "a clique no botão DESANEXAR.")
        Me.grdMedicamentos.Location = New System.Drawing.Point(12, 329)
        Me.grdMedicamentos.MultiSelect = False
        Me.grdMedicamentos.Name = "grdMedicamentos"
        Me.grdMedicamentos.ReadOnly = True
        Me.grdMedicamentos.RowHeadersVisible = False
        Me.grdMedicamentos.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.grdMedicamentos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.ajuda.SetShowHelp(Me.grdMedicamentos, True)
        Me.grdMedicamentos.Size = New System.Drawing.Size(586, 166)
        Me.grdMedicamentos.TabIndex = 6
        '
        'cod_medicamento
        '
        Me.cod_medicamento.HeaderText = "Código"
        Me.cod_medicamento.Name = "cod_medicamento"
        Me.cod_medicamento.ReadOnly = True
        Me.cod_medicamento.Visible = False
        '
        'nome_medicamento
        '
        Me.nome_medicamento.HeaderText = "Item"
        Me.nome_medicamento.Name = "nome_medicamento"
        Me.nome_medicamento.ReadOnly = True
        '
        'quant_medicamento
        '
        Me.quant_medicamento.HeaderText = "Quantidade"
        Me.quant_medicamento.Name = "quant_medicamento"
        Me.quant_medicamento.ReadOnly = True
        '
        'val_medicamento
        '
        Me.val_medicamento.HeaderText = "Validade"
        Me.val_medicamento.Name = "val_medicamento"
        Me.val_medicamento.ReadOnly = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(239, 41)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(110, 13)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "Data do Cadastro:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(239, 16)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(54, 13)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "Usuário:"
        '
        'lblUsuarioCadastrante
        '
        Me.lblUsuarioCadastrante.AutoSize = True
        Me.lblUsuarioCadastrante.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUsuarioCadastrante.ForeColor = System.Drawing.Color.Red
        Me.ajuda.SetHelpString(Me.lblUsuarioCadastrante, "Nome do usuário logado.")
        Me.lblUsuarioCadastrante.Location = New System.Drawing.Point(293, 16)
        Me.lblUsuarioCadastrante.Name = "lblUsuarioCadastrante"
        Me.ajuda.SetShowHelp(Me.lblUsuarioCadastrante, True)
        Me.lblUsuarioCadastrante.Size = New System.Drawing.Size(90, 13)
        Me.lblUsuarioCadastrante.TabIndex = 12
        Me.lblUsuarioCadastrante.Text = "Não Informado"
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.PaleTurquoise
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label3.Location = New System.Drawing.Point(12, 8)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(221, 21)
        Me.Label3.TabIndex = 10
        Me.Label3.Text = "ITENS"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(239, 67)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(65, 13)
        Me.Label4.TabIndex = 11
        Me.Label4.Text = "No da Nota:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(239, 97)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(63, 13)
        Me.Label5.TabIndex = 12
        Me.Label5.Text = "No do Lote:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(239, 119)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(63, 13)
        Me.Label6.TabIndex = 13
        Me.Label6.Text = "VALIDADE:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(239, 203)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(234, 13)
        Me.Label7.TabIndex = 14
        Me.Label7.Text = "QUANTIDADE (insira valores maiores que zero):"
        '
        'cmdAnexar
        '
        Me.cmdAnexar.BackColor = System.Drawing.SystemColors.Control
        Me.ajuda.SetHelpString(Me.cmdAnexar, "Clique aqui para anexar o medicamento escolhido acompanhado da validade e quantid" & _
                "ade a nota.")
        Me.cmdAnexar.Location = New System.Drawing.Point(242, 277)
        Me.cmdAnexar.Name = "cmdAnexar"
        Me.ajuda.SetShowHelp(Me.cmdAnexar, True)
        Me.cmdAnexar.Size = New System.Drawing.Size(89, 25)
        Me.cmdAnexar.TabIndex = 3
        Me.cmdAnexar.Text = "&Anexar"
        Me.cmdAnexar.UseVisualStyleBackColor = False
        '
        'cmdDesanexar
        '
        Me.cmdDesanexar.BackColor = System.Drawing.SystemColors.Control
        Me.ajuda.SetHelpString(Me.cmdDesanexar, "Selecione um medicamento na nota para desanexa-lo.")
        Me.cmdDesanexar.Location = New System.Drawing.Point(355, 277)
        Me.cmdDesanexar.Name = "cmdDesanexar"
        Me.ajuda.SetShowHelp(Me.cmdDesanexar, True)
        Me.cmdDesanexar.Size = New System.Drawing.Size(89, 25)
        Me.cmdDesanexar.TabIndex = 4
        Me.cmdDesanexar.Text = "&Desanexar"
        Me.cmdDesanexar.UseVisualStyleBackColor = False
        '
        'cmdEfetuarEntradas
        '
        Me.cmdEfetuarEntradas.BackColor = System.Drawing.SystemColors.Control
        Me.ajuda.SetHelpString(Me.cmdEfetuarEntradas, "Clique aqui para inserir a nota montada acima em estoque.")
        Me.cmdEfetuarEntradas.Location = New System.Drawing.Point(15, 499)
        Me.cmdEfetuarEntradas.Name = "cmdEfetuarEntradas"
        Me.ajuda.SetShowHelp(Me.cmdEfetuarEntradas, True)
        Me.cmdEfetuarEntradas.Size = New System.Drawing.Size(122, 25)
        Me.cmdEfetuarEntradas.TabIndex = 5
        Me.cmdEfetuarEntradas.Text = "&Efetuar Entradas"
        Me.cmdEfetuarEntradas.UseVisualStyleBackColor = False
        '
        'cmdEditarEntradas
        '
        Me.cmdEditarEntradas.BackColor = System.Drawing.SystemColors.Control
        Me.ajuda.SetHelpString(Me.cmdEditarEntradas, "Clique aqui para editar alguma entrada que porventura tenha sido inserida erronea" & _
                "mente.")
        Me.cmdEditarEntradas.Location = New System.Drawing.Point(143, 499)
        Me.cmdEditarEntradas.Name = "cmdEditarEntradas"
        Me.ajuda.SetShowHelp(Me.cmdEditarEntradas, True)
        Me.cmdEditarEntradas.Size = New System.Drawing.Size(122, 25)
        Me.cmdEditarEntradas.TabIndex = 6
        Me.cmdEditarEntradas.Text = "E&ditar Entradas"
        Me.cmdEditarEntradas.UseVisualStyleBackColor = False
        '
        'cmdLimparNota
        '
        Me.cmdLimparNota.BackColor = System.Drawing.SystemColors.Control
        Me.ajuda.SetHelpString(Me.cmdLimparNota, "Clique aqui e elimine a nota montada.")
        Me.cmdLimparNota.Location = New System.Drawing.Point(271, 499)
        Me.cmdLimparNota.Name = "cmdLimparNota"
        Me.ajuda.SetShowHelp(Me.cmdLimparNota, True)
        Me.cmdLimparNota.Size = New System.Drawing.Size(122, 25)
        Me.cmdLimparNota.TabIndex = 7
        Me.cmdLimparNota.Text = "&Limpar Nota"
        Me.cmdLimparNota.UseVisualStyleBackColor = False
        '
        'lkVerEstoque
        '
        Me.lkVerEstoque.AutoSize = True
        Me.ajuda.SetHelpString(Me.lkVerEstoque, "Clique sobre este link para ver a situação do estoque.")
        Me.lkVerEstoque.Location = New System.Drawing.Point(411, 505)
        Me.lkVerEstoque.Name = "lkVerEstoque"
        Me.ajuda.SetShowHelp(Me.lkVerEstoque, True)
        Me.lkVerEstoque.Size = New System.Drawing.Size(177, 13)
        Me.lkVerEstoque.TabIndex = 8
        Me.lkVerEstoque.TabStop = True
        Me.lkVerEstoque.Text = "Ver situação do estoque atualmente"
        '
        'ToolTip
        '
        Me.ToolTip.AutoPopDelay = 12000
        Me.ToolTip.InitialDelay = 500
        Me.ToolTip.ReshowDelay = 100
        Me.ToolTip.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info
        Me.ToolTip.ToolTipTitle = "Informações"
        '
        'Label8
        '
        Me.Label8.BackColor = System.Drawing.Color.PaleTurquoise
        Me.Label8.Location = New System.Drawing.Point(12, 305)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(586, 21)
        Me.Label8.TabIndex = 26
        Me.Label8.Text = "ITENS PARA ENTRADA EM ESTOQUE:"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblValQuantidade
        '
        Me.lblValQuantidade.AutoSize = True
        Me.lblValQuantidade.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblValQuantidade.ForeColor = System.Drawing.Color.Red
        Me.lblValQuantidade.Location = New System.Drawing.Point(598, 249)
        Me.lblValQuantidade.Name = "lblValQuantidade"
        Me.lblValQuantidade.Size = New System.Drawing.Size(12, 13)
        Me.lblValQuantidade.TabIndex = 32
        Me.lblValQuantidade.Text = "*"
        Me.lblValQuantidade.Visible = False
        '
        'lblValMedicamentos
        '
        Me.lblValMedicamentos.AutoSize = True
        Me.lblValMedicamentos.BackColor = System.Drawing.Color.PaleTurquoise
        Me.lblValMedicamentos.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblValMedicamentos.ForeColor = System.Drawing.Color.Red
        Me.lblValMedicamentos.Location = New System.Drawing.Point(167, 12)
        Me.lblValMedicamentos.Name = "lblValMedicamentos"
        Me.lblValMedicamentos.Size = New System.Drawing.Size(12, 13)
        Me.lblValMedicamentos.TabIndex = 33
        Me.lblValMedicamentos.Text = "*"
        Me.lblValMedicamentos.Visible = False
        '
        'imgInformacoes
        '
        Me.imgInformacoes.BackColor = System.Drawing.Color.PaleTurquoise
        Me.ajuda.SetHelpString(Me.imgInformacoes, "Posicione o mouse sobre esta figura e obtenha detalhes do medicamento selecionado" & _
                ".")
        Me.imgInformacoes.Image = Global.SICEP.My.Resources.Resources.infos
        Me.imgInformacoes.Location = New System.Drawing.Point(18, 8)
        Me.imgInformacoes.Name = "imgInformacoes"
        Me.ajuda.SetShowHelp(Me.imgInformacoes, True)
        Me.imgInformacoes.Size = New System.Drawing.Size(21, 21)
        Me.imgInformacoes.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.imgInformacoes.TabIndex = 25
        Me.imgInformacoes.TabStop = False
        '
        'chkMedicamentos
        '
        Me.chkMedicamentos.AutoSize = True
        Me.chkMedicamentos.Checked = True
        Me.chkMedicamentos.CheckState = System.Windows.Forms.CheckState.Checked
        Me.ajuda.SetHelpString(Me.chkMedicamentos, "Marque esta opção para exibir os medicamentos.")
        Me.chkMedicamentos.Location = New System.Drawing.Point(12, 37)
        Me.chkMedicamentos.Name = "chkMedicamentos"
        Me.ajuda.SetShowHelp(Me.chkMedicamentos, True)
        Me.chkMedicamentos.Size = New System.Drawing.Size(95, 17)
        Me.chkMedicamentos.TabIndex = 34
        Me.chkMedicamentos.Text = "Medicamentos"
        Me.chkMedicamentos.UseVisualStyleBackColor = True
        '
        'chkMateriais
        '
        Me.chkMateriais.AutoSize = True
        Me.chkMateriais.Checked = True
        Me.chkMateriais.CheckState = System.Windows.Forms.CheckState.Checked
        Me.ajuda.SetHelpString(Me.chkMateriais, "Marque esta opção para exibir os materiais de consumo.")
        Me.chkMateriais.Location = New System.Drawing.Point(108, 37)
        Me.chkMateriais.Name = "chkMateriais"
        Me.ajuda.SetShowHelp(Me.chkMateriais, True)
        Me.chkMateriais.Size = New System.Drawing.Size(130, 17)
        Me.chkMateriais.TabIndex = 35
        Me.chkMateriais.Text = "Materiais de Consumo"
        Me.chkMateriais.UseVisualStyleBackColor = True
        '
        'ajuda
        '
        Me.ajuda.HelpNamespace = "C:\Arquivos de programas\SICEP\Ajuda\frmSecGestaoEntradas.html"
        '
        'frmEntSecretaria
        '
        Me.AcceptButton = Me.cmdAnexar
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(608, 528)
        Me.Controls.Add(Me.chkMateriais)
        Me.Controls.Add(Me.chkMedicamentos)
        Me.Controls.Add(Me.lblValMedicamentos)
        Me.Controls.Add(Me.lblValQuantidade)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.imgInformacoes)
        Me.Controls.Add(Me.lkVerEstoque)
        Me.Controls.Add(Me.cmdLimparNota)
        Me.Controls.Add(Me.cmdEditarEntradas)
        Me.Controls.Add(Me.cmdEfetuarEntradas)
        Me.Controls.Add(Me.cmdDesanexar)
        Me.Controls.Add(Me.cmdAnexar)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.lblUsuarioCadastrante)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.grdMedicamentos)
        Me.Controls.Add(Me.txtQuantidade)
        Me.Controls.Add(Me.txtValidade)
        Me.Controls.Add(Me.ltbMedicamentos)
        Me.Controls.Add(Me.txtNumLote)
        Me.Controls.Add(Me.txtNumNota)
        Me.Controls.Add(Me.txtDataCadastro)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.HelpButton = True
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmEntSecretaria"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Gestão das Entradas em Estoque da Secretaria"
        CType(Me.grdMedicamentos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.imgInformacoes, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtDataCadastro As System.Windows.Forms.DateTimePicker
    Friend WithEvents txtNumNota As System.Windows.Forms.TextBox
    Friend WithEvents txtNumLote As System.Windows.Forms.TextBox
    Friend WithEvents ltbMedicamentos As System.Windows.Forms.ListBox
    Friend WithEvents txtValidade As System.Windows.Forms.DateTimePicker
    Friend WithEvents txtQuantidade As System.Windows.Forms.TextBox
    Friend WithEvents grdMedicamentos As System.Windows.Forms.DataGridView
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents lblUsuarioCadastrante As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents cmdAnexar As System.Windows.Forms.Button
    Friend WithEvents cmdDesanexar As System.Windows.Forms.Button
    Friend WithEvents cmdEfetuarEntradas As System.Windows.Forms.Button
    Friend WithEvents cmdEditarEntradas As System.Windows.Forms.Button
    Friend WithEvents cmdLimparNota As System.Windows.Forms.Button
    Friend WithEvents lkVerEstoque As System.Windows.Forms.LinkLabel
    Friend WithEvents imgInformacoes As System.Windows.Forms.PictureBox
    Friend WithEvents ToolTip As System.Windows.Forms.ToolTip
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents lblValQuantidade As System.Windows.Forms.Label
    Friend WithEvents lblValMedicamentos As System.Windows.Forms.Label
    Friend WithEvents chkMedicamentos As System.Windows.Forms.CheckBox
    Friend WithEvents chkMateriais As System.Windows.Forms.CheckBox
    Friend WithEvents cod_medicamento As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents nome_medicamento As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents quant_medicamento As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents val_medicamento As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ajuda As System.Windows.Forms.HelpProvider
End Class
