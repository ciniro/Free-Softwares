<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmEntPoliclinica
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmEntPoliclinica))
        Me.lblValMedicamentos = New System.Windows.Forms.Label
        Me.lblValQuantidade = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.imgInformacoes = New System.Windows.Forms.PictureBox
        Me.lkVerEstoque = New System.Windows.Forms.LinkLabel
        Me.cmdLimparNota = New System.Windows.Forms.Button
        Me.cmdEditarEntradas = New System.Windows.Forms.Button
        Me.cmdEfetuarEntradas = New System.Windows.Forms.Button
        Me.cmdDesanexar = New System.Windows.Forms.Button
        Me.cmdAnexar = New System.Windows.Forms.Button
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.lblUsuarioCadastrante = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.grdMedicamentos = New System.Windows.Forms.DataGridView
        Me.cod_medicamento = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.nome_medicamento = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.quant_medicamento = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.val_medicamento = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.txtQuantidade = New System.Windows.Forms.TextBox
        Me.txtValidade = New System.Windows.Forms.DateTimePicker
        Me.ltbMedicamentos = New System.Windows.Forms.ListBox
        Me.txtDataCadastro = New System.Windows.Forms.DateTimePicker
        Me.ToolTip = New System.Windows.Forms.ToolTip(Me.components)
        Me.chkMateriais = New System.Windows.Forms.CheckBox
        Me.chkMedicamentos = New System.Windows.Forms.CheckBox
        Me.ajuda = New System.Windows.Forms.HelpProvider
        CType(Me.imgInformacoes, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grdMedicamentos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblValMedicamentos
        '
        Me.lblValMedicamentos.AutoSize = True
        Me.lblValMedicamentos.BackColor = System.Drawing.Color.PaleTurquoise
        Me.lblValMedicamentos.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblValMedicamentos.ForeColor = System.Drawing.Color.Red
        Me.lblValMedicamentos.Location = New System.Drawing.Point(167, 13)
        Me.lblValMedicamentos.Name = "lblValMedicamentos"
        Me.lblValMedicamentos.Size = New System.Drawing.Size(12, 13)
        Me.lblValMedicamentos.TabIndex = 59
        Me.lblValMedicamentos.Text = "*"
        Me.lblValMedicamentos.Visible = False
        '
        'lblValQuantidade
        '
        Me.lblValQuantidade.AutoSize = True
        Me.lblValQuantidade.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblValQuantidade.ForeColor = System.Drawing.Color.Red
        Me.lblValQuantidade.Location = New System.Drawing.Point(597, 216)
        Me.lblValQuantidade.Name = "lblValQuantidade"
        Me.lblValQuantidade.Size = New System.Drawing.Size(12, 13)
        Me.lblValQuantidade.TabIndex = 58
        Me.lblValQuantidade.Text = "*"
        Me.lblValQuantidade.Visible = False
        '
        'Label8
        '
        Me.Label8.BackColor = System.Drawing.Color.PaleTurquoise
        Me.Label8.Location = New System.Drawing.Point(12, 301)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(586, 21)
        Me.Label8.TabIndex = 57
        Me.Label8.Text = "ITENS PARA ENTRADA EM ESTOQUE:"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'imgInformacoes
        '
        Me.imgInformacoes.BackColor = System.Drawing.Color.PaleTurquoise
        Me.ajuda.SetHelpString(Me.imgInformacoes, "Posicione o ponteiro do mouse sobre esta imagem pra ver detalhes do item selecion" & _
                "ado.")
        Me.imgInformacoes.Image = Global.SICEP.My.Resources.Resources.infos
        Me.imgInformacoes.Location = New System.Drawing.Point(18, 9)
        Me.imgInformacoes.Name = "imgInformacoes"
        Me.ajuda.SetShowHelp(Me.imgInformacoes, True)
        Me.imgInformacoes.Size = New System.Drawing.Size(21, 21)
        Me.imgInformacoes.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.imgInformacoes.TabIndex = 56
        Me.imgInformacoes.TabStop = False
        '
        'lkVerEstoque
        '
        Me.lkVerEstoque.AutoSize = True
        Me.ajuda.SetHelpString(Me.lkVerEstoque, "Clique sobre este link para ver a situação atual do estoque. Itens, validades e q" & _
                "uantidades.")
        Me.lkVerEstoque.Location = New System.Drawing.Point(413, 513)
        Me.lkVerEstoque.Name = "lkVerEstoque"
        Me.ajuda.SetShowHelp(Me.lkVerEstoque, True)
        Me.lkVerEstoque.Size = New System.Drawing.Size(177, 13)
        Me.lkVerEstoque.TabIndex = 46
        Me.lkVerEstoque.TabStop = True
        Me.lkVerEstoque.Text = "Ver situação do estoque atualmente"
        '
        'cmdLimparNota
        '
        Me.cmdLimparNota.BackColor = System.Drawing.SystemColors.Control
        Me.cmdLimparNota.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.ajuda.SetHelpString(Me.cmdLimparNota, "Clique aqui para eliminar a nota montada.")
        Me.cmdLimparNota.Location = New System.Drawing.Point(273, 507)
        Me.cmdLimparNota.Name = "cmdLimparNota"
        Me.ajuda.SetShowHelp(Me.cmdLimparNota, True)
        Me.cmdLimparNota.Size = New System.Drawing.Size(122, 25)
        Me.cmdLimparNota.TabIndex = 44
        Me.cmdLimparNota.Text = "&Limpar Nota"
        Me.cmdLimparNota.UseVisualStyleBackColor = False
        '
        'cmdEditarEntradas
        '
        Me.cmdEditarEntradas.BackColor = System.Drawing.SystemColors.Control
        Me.ajuda.SetHelpString(Me.cmdEditarEntradas, "Clique aqui para alterar uma entrada que porventura tenha sido cadastrada erronea" & _
                "mente.")
        Me.cmdEditarEntradas.Location = New System.Drawing.Point(145, 507)
        Me.cmdEditarEntradas.Name = "cmdEditarEntradas"
        Me.ajuda.SetShowHelp(Me.cmdEditarEntradas, True)
        Me.cmdEditarEntradas.Size = New System.Drawing.Size(122, 25)
        Me.cmdEditarEntradas.TabIndex = 41
        Me.cmdEditarEntradas.Text = "E&ditar Entradas"
        Me.cmdEditarEntradas.UseVisualStyleBackColor = False
        '
        'cmdEfetuarEntradas
        '
        Me.cmdEfetuarEntradas.BackColor = System.Drawing.SystemColors.Control
        Me.ajuda.SetHelpString(Me.cmdEfetuarEntradas, "Clique aqui para inserir a nota montada em estoque.")
        Me.cmdEfetuarEntradas.Location = New System.Drawing.Point(17, 507)
        Me.cmdEfetuarEntradas.Name = "cmdEfetuarEntradas"
        Me.ajuda.SetShowHelp(Me.cmdEfetuarEntradas, True)
        Me.cmdEfetuarEntradas.Size = New System.Drawing.Size(122, 25)
        Me.cmdEfetuarEntradas.TabIndex = 40
        Me.cmdEfetuarEntradas.Text = "&Efetuar Entradas"
        Me.cmdEfetuarEntradas.UseVisualStyleBackColor = False
        '
        'cmdDesanexar
        '
        Me.cmdDesanexar.BackColor = System.Drawing.SystemColors.Control
        Me.ajuda.SetHelpString(Me.cmdDesanexar, "Selecione um item na nota e clique aqui para desanexa-lo.")
        Me.cmdDesanexar.Location = New System.Drawing.Point(345, 273)
        Me.cmdDesanexar.Name = "cmdDesanexar"
        Me.ajuda.SetShowHelp(Me.cmdDesanexar, True)
        Me.cmdDesanexar.Size = New System.Drawing.Size(89, 25)
        Me.cmdDesanexar.TabIndex = 39
        Me.cmdDesanexar.Text = "&Desanexar"
        Me.cmdDesanexar.UseVisualStyleBackColor = False
        '
        'cmdAnexar
        '
        Me.cmdAnexar.BackColor = System.Drawing.SystemColors.Control
        Me.ajuda.SetHelpString(Me.cmdAnexar, "Clique sobre este botão para anexar a nota o item selecionado, bem como sua valid" & _
                "ade e quantidade informadas.")
        Me.cmdAnexar.Location = New System.Drawing.Point(239, 273)
        Me.cmdAnexar.Name = "cmdAnexar"
        Me.ajuda.SetShowHelp(Me.cmdAnexar, True)
        Me.cmdAnexar.Size = New System.Drawing.Size(89, 25)
        Me.cmdAnexar.TabIndex = 38
        Me.cmdAnexar.Text = "&Anexar"
        Me.cmdAnexar.UseVisualStyleBackColor = False
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(239, 200)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(234, 13)
        Me.Label7.TabIndex = 55
        Me.Label7.Text = "QUANTIDADE (insira valores maiores que zero):"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(239, 88)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(63, 13)
        Me.Label6.TabIndex = 54
        Me.Label6.Text = "VALIDADE:"
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.PaleTurquoise
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label3.Location = New System.Drawing.Point(12, 9)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(221, 21)
        Me.Label3.TabIndex = 48
        Me.Label3.Text = "ITENS"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblUsuarioCadastrante
        '
        Me.lblUsuarioCadastrante.AutoSize = True
        Me.lblUsuarioCadastrante.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUsuarioCadastrante.ForeColor = System.Drawing.Color.Red
        Me.ajuda.SetHelpString(Me.lblUsuarioCadastrante, "Nome do usuário logado.")
        Me.lblUsuarioCadastrante.Location = New System.Drawing.Point(293, 17)
        Me.lblUsuarioCadastrante.Name = "lblUsuarioCadastrante"
        Me.ajuda.SetShowHelp(Me.lblUsuarioCadastrante, True)
        Me.lblUsuarioCadastrante.Size = New System.Drawing.Size(90, 13)
        Me.lblUsuarioCadastrante.TabIndex = 53
        Me.lblUsuarioCadastrante.Text = "Não Informado"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(239, 17)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(54, 13)
        Me.Label2.TabIndex = 45
        Me.Label2.Text = "Usuário:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(239, 42)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(110, 13)
        Me.Label1.TabIndex = 43
        Me.Label1.Text = "Data do Cadastro:"
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
        Me.ajuda.SetHelpString(Me.grdMedicamentos, "Nota. Para excluir algum item, clique sobre ele para seleciona-lo e clique no bot" & _
                "ão DESANEXAR.")
        Me.grdMedicamentos.Location = New System.Drawing.Point(12, 325)
        Me.grdMedicamentos.MultiSelect = False
        Me.grdMedicamentos.Name = "grdMedicamentos"
        Me.grdMedicamentos.ReadOnly = True
        Me.grdMedicamentos.RowHeadersVisible = False
        Me.grdMedicamentos.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.grdMedicamentos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.ajuda.SetShowHelp(Me.grdMedicamentos, True)
        Me.grdMedicamentos.Size = New System.Drawing.Size(586, 176)
        Me.grdMedicamentos.TabIndex = 42
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
        'txtQuantidade
        '
        Me.txtQuantidade.Font = New System.Drawing.Font("Microsoft Sans Serif", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtQuantidade.ForeColor = System.Drawing.Color.Red
        Me.ajuda.SetHelpString(Me.txtQuantidade, "Digite aqui a quantidade do item selecionado que será inserido em estoque.")
        Me.txtQuantidade.Location = New System.Drawing.Point(242, 216)
        Me.txtQuantidade.MaxLength = 8
        Me.txtQuantidade.Name = "txtQuantidade"
        Me.ajuda.SetShowHelp(Me.txtQuantidade, True)
        Me.txtQuantidade.Size = New System.Drawing.Size(356, 49)
        Me.txtQuantidade.TabIndex = 37
        '
        'txtValidade
        '
        Me.txtValidade.Font = New System.Drawing.Font("Microsoft Sans Serif", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtValidade.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.ajuda.SetHelpString(Me.txtValidade, "Digite aqui a validade do item que será inserido em estoque.")
        Me.txtValidade.Location = New System.Drawing.Point(242, 104)
        Me.txtValidade.Name = "txtValidade"
        Me.ajuda.SetShowHelp(Me.txtValidade, True)
        Me.txtValidade.ShowUpDown = True
        Me.txtValidade.Size = New System.Drawing.Size(356, 49)
        Me.txtValidade.TabIndex = 36
        '
        'ltbMedicamentos
        '
        Me.ltbMedicamentos.FormattingEnabled = True
        Me.ajuda.SetHelpString(Me.ltbMedicamentos, "Clique sobre o item desejado para dar entrada em estoque.")
        Me.ltbMedicamentos.Location = New System.Drawing.Point(12, 60)
        Me.ltbMedicamentos.Name = "ltbMedicamentos"
        Me.ajuda.SetShowHelp(Me.ltbMedicamentos, True)
        Me.ltbMedicamentos.Size = New System.Drawing.Size(221, 238)
        Me.ltbMedicamentos.TabIndex = 35
        '
        'txtDataCadastro
        '
        Me.txtDataCadastro.CalendarFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDataCadastro.Enabled = False
        Me.txtDataCadastro.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDataCadastro.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.ajuda.SetHelpString(Me.txtDataCadastro, "Data de hoje.")
        Me.txtDataCadastro.Location = New System.Drawing.Point(355, 38)
        Me.txtDataCadastro.MaxDate = New Date(2006, 8, 14, 0, 0, 0, 0)
        Me.txtDataCadastro.Name = "txtDataCadastro"
        Me.ajuda.SetShowHelp(Me.txtDataCadastro, True)
        Me.txtDataCadastro.Size = New System.Drawing.Size(100, 20)
        Me.txtDataCadastro.TabIndex = 47
        Me.txtDataCadastro.Value = New Date(2006, 8, 14, 0, 0, 0, 0)
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
        'chkMateriais
        '
        Me.chkMateriais.AutoSize = True
        Me.chkMateriais.Checked = True
        Me.chkMateriais.CheckState = System.Windows.Forms.CheckState.Checked
        Me.ajuda.SetHelpString(Me.chkMateriais, "Marque esta opção para exibir os materiais de consumo.")
        Me.chkMateriais.Location = New System.Drawing.Point(108, 39)
        Me.chkMateriais.Name = "chkMateriais"
        Me.ajuda.SetShowHelp(Me.chkMateriais, True)
        Me.chkMateriais.Size = New System.Drawing.Size(130, 17)
        Me.chkMateriais.TabIndex = 62
        Me.chkMateriais.Text = "Materiais de Consumo"
        Me.chkMateriais.UseVisualStyleBackColor = True
        '
        'chkMedicamentos
        '
        Me.chkMedicamentos.AutoSize = True
        Me.chkMedicamentos.Checked = True
        Me.chkMedicamentos.CheckState = System.Windows.Forms.CheckState.Checked
        Me.ajuda.SetHelpString(Me.chkMedicamentos, "Marque esta opção para exibir os medicamentos.")
        Me.chkMedicamentos.Location = New System.Drawing.Point(12, 39)
        Me.chkMedicamentos.Name = "chkMedicamentos"
        Me.ajuda.SetShowHelp(Me.chkMedicamentos, True)
        Me.chkMedicamentos.Size = New System.Drawing.Size(95, 17)
        Me.chkMedicamentos.TabIndex = 61
        Me.chkMedicamentos.Text = "Medicamentos"
        Me.chkMedicamentos.UseVisualStyleBackColor = True
        '
        'ajuda
        '
        Me.ajuda.HelpNamespace = "C:\Arquivos de programas\SICEP\Ajuda\frmPoliGestaoEntradas.html"
        '
        'frmEntPoliclinica
        '
        Me.AcceptButton = Me.cmdAnexar
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.CancelButton = Me.cmdLimparNota
        Me.ClientSize = New System.Drawing.Size(614, 534)
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
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.lblUsuarioCadastrante)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.grdMedicamentos)
        Me.Controls.Add(Me.txtQuantidade)
        Me.Controls.Add(Me.txtValidade)
        Me.Controls.Add(Me.ltbMedicamentos)
        Me.Controls.Add(Me.txtDataCadastro)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.HelpButton = True
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmEntPoliclinica"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Gestão de Entradas em Estoque da Policlínica"
        CType(Me.imgInformacoes, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grdMedicamentos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblValMedicamentos As System.Windows.Forms.Label
    Friend WithEvents lblValQuantidade As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents imgInformacoes As System.Windows.Forms.PictureBox
    Friend WithEvents lkVerEstoque As System.Windows.Forms.LinkLabel
    Friend WithEvents cmdLimparNota As System.Windows.Forms.Button
    Friend WithEvents cmdEditarEntradas As System.Windows.Forms.Button
    Friend WithEvents cmdEfetuarEntradas As System.Windows.Forms.Button
    Friend WithEvents cmdDesanexar As System.Windows.Forms.Button
    Friend WithEvents cmdAnexar As System.Windows.Forms.Button
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents lblUsuarioCadastrante As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents grdMedicamentos As System.Windows.Forms.DataGridView
    Friend WithEvents txtQuantidade As System.Windows.Forms.TextBox
    Friend WithEvents txtValidade As System.Windows.Forms.DateTimePicker
    Friend WithEvents ltbMedicamentos As System.Windows.Forms.ListBox
    Friend WithEvents txtDataCadastro As System.Windows.Forms.DateTimePicker
    Friend WithEvents ToolTip As System.Windows.Forms.ToolTip
    Friend WithEvents chkMateriais As System.Windows.Forms.CheckBox
    Friend WithEvents chkMedicamentos As System.Windows.Forms.CheckBox
    Friend WithEvents cod_medicamento As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents nome_medicamento As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents quant_medicamento As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents val_medicamento As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ajuda As System.Windows.Forms.HelpProvider
End Class
