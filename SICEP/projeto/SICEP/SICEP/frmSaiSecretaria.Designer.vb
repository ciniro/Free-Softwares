<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSaiSecretaria
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
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmSaiSecretaria))
        Me.lkImprimir = New System.Windows.Forms.LinkLabel
        Me.lblPesquisa = New System.Windows.Forms.Label
        Me.txtPesqValidade = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.txtPesqMedicamento = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.grdEstoqueSecretaria = New System.Windows.Forms.DataGridView
        Me.nome_medicamento = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.cod_medicamento = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.val_medicamento = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.quant_medicamento = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.grbInfoEstoque = New System.Windows.Forms.GroupBox
        Me.lblDiferenca = New System.Windows.Forms.Label
        Me.lblUltimaRetirada = New System.Windows.Forms.Label
        Me.lblQuantMedicamento = New System.Windows.Forms.Label
        Me.lblValMedicamento = New System.Windows.Forms.Label
        Me.lblNomeMedicamento = New System.Windows.Forms.Label
        Me.Label11 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.gpbRetirada = New System.Windows.Forms.GroupBox
        Me.imgInforma��esRegiao = New System.Windows.Forms.PictureBox
        Me.lkVerEstoque = New System.Windows.Forms.LinkLabel
        Me.cmdEditarSaida = New System.Windows.Forms.Button
        Me.cmdEfetuarSaida = New System.Windows.Forms.Button
        Me.txtQuantidade = New System.Windows.Forms.TextBox
        Me.dpdRegiao = New System.Windows.Forms.ComboBox
        Me.Label17 = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.Label9 = New System.Windows.Forms.Label
        Me.txtDataCadastro = New System.Windows.Forms.DateTimePicker
        Me.lblUsuarioCadastrante = New System.Windows.Forms.Label
        Me.Label10 = New System.Windows.Forms.Label
        Me.ToolTip = New System.Windows.Forms.ToolTip(Me.components)
        Me.lblCodMedicamento = New System.Windows.Forms.Label
        Me.imgInformacoes = New System.Windows.Forms.PictureBox
        Me.chkMateriais = New System.Windows.Forms.CheckBox
        Me.chkMedicamentos = New System.Windows.Forms.CheckBox
        Me.ajuda = New System.Windows.Forms.HelpProvider
        CType(Me.grdEstoqueSecretaria, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grbInfoEstoque.SuspendLayout()
        Me.gpbRetirada.SuspendLayout()
        CType(Me.imgInforma��esRegiao, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.imgInformacoes, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lkImprimir
        '
        Me.lkImprimir.AutoSize = True
        Me.ajuda.SetHelpString(Me.lkImprimir, "Clique sobre este link para ver a sua pesquisa de estoque em modo de impress�o.")
        Me.lkImprimir.Location = New System.Drawing.Point(107, 288)
        Me.lkImprimir.Name = "lkImprimir"
        Me.ajuda.SetShowHelp(Me.lkImprimir, True)
        Me.lkImprimir.Size = New System.Drawing.Size(202, 13)
        Me.lkImprimir.TabIndex = 7
        Me.lkImprimir.TabStop = True
        Me.lkImprimir.Text = "Ver esta pesquisa em modo de impress�o"
        '
        'lblPesquisa
        '
        Me.lblPesquisa.AutoSize = True
        Me.lblPesquisa.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPesquisa.Location = New System.Drawing.Point(4, 221)
        Me.lblPesquisa.Name = "lblPesquisa"
        Me.lblPesquisa.Size = New System.Drawing.Size(211, 13)
        Me.lblPesquisa.TabIndex = 12
        Me.lblPesquisa.Text = "Voc� n�o est� usando a pesquisa..."
        '
        'txtPesqValidade
        '
        Me.txtPesqValidade.Location = New System.Drawing.Point(103, 265)
        Me.txtPesqValidade.MaxLength = 10
        Me.txtPesqValidade.Name = "txtPesqValidade"
        Me.txtPesqValidade.Size = New System.Drawing.Size(206, 20)
        Me.txtPesqValidade.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(4, 272)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(70, 13)
        Me.Label2.TabIndex = 10
        Me.Label2.Text = "Por Validade:"
        '
        'txtPesqMedicamento
        '
        Me.txtPesqMedicamento.Location = New System.Drawing.Point(103, 237)
        Me.txtPesqMedicamento.MaxLength = 100
        Me.txtPesqMedicamento.Name = "txtPesqMedicamento"
        Me.txtPesqMedicamento.ShortcutsEnabled = False
        Me.txtPesqMedicamento.Size = New System.Drawing.Size(207, 20)
        Me.txtPesqMedicamento.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(4, 240)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(49, 13)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "Por Item:"
        '
        'grdEstoqueSecretaria
        '
        Me.grdEstoqueSecretaria.AllowUserToAddRows = False
        Me.grdEstoqueSecretaria.AllowUserToDeleteRows = False
        Me.grdEstoqueSecretaria.AllowUserToResizeColumns = False
        Me.grdEstoqueSecretaria.AllowUserToResizeRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.PaleTurquoise
        Me.grdEstoqueSecretaria.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.grdEstoqueSecretaria.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.grdEstoqueSecretaria.BackgroundColor = System.Drawing.Color.White
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.grdEstoqueSecretaria.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.grdEstoqueSecretaria.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grdEstoqueSecretaria.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.nome_medicamento, Me.cod_medicamento, Me.val_medicamento, Me.quant_medicamento})
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.grdEstoqueSecretaria.DefaultCellStyle = DataGridViewCellStyle3
        Me.ajuda.SetHelpString(Me.grdEstoqueSecretaria, "Itens em estoque.")
        Me.grdEstoqueSecretaria.Location = New System.Drawing.Point(7, 43)
        Me.grdEstoqueSecretaria.MultiSelect = False
        Me.grdEstoqueSecretaria.Name = "grdEstoqueSecretaria"
        Me.grdEstoqueSecretaria.ReadOnly = True
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.White
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.grdEstoqueSecretaria.RowHeadersDefaultCellStyle = DataGridViewCellStyle4
        Me.grdEstoqueSecretaria.RowHeadersVisible = False
        Me.grdEstoqueSecretaria.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.grdEstoqueSecretaria.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.grdEstoqueSecretaria.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.grdEstoqueSecretaria.ShowEditingIcon = False
        Me.ajuda.SetShowHelp(Me.grdEstoqueSecretaria, True)
        Me.grdEstoqueSecretaria.Size = New System.Drawing.Size(308, 170)
        Me.grdEstoqueSecretaria.StandardTab = True
        Me.grdEstoqueSecretaria.TabIndex = 0
        '
        'nome_medicamento
        '
        Me.nome_medicamento.DataPropertyName = "nome_medicamento"
        Me.nome_medicamento.HeaderText = "Item"
        Me.nome_medicamento.Name = "nome_medicamento"
        Me.nome_medicamento.ReadOnly = True
        '
        'cod_medicamento
        '
        Me.cod_medicamento.DataPropertyName = "cod_medicamento"
        Me.cod_medicamento.HeaderText = "C�digo"
        Me.cod_medicamento.Name = "cod_medicamento"
        Me.cod_medicamento.ReadOnly = True
        Me.cod_medicamento.Visible = False
        '
        'val_medicamento
        '
        Me.val_medicamento.DataPropertyName = "val_medicamento"
        Me.val_medicamento.HeaderText = "Validade"
        Me.val_medicamento.Name = "val_medicamento"
        Me.val_medicamento.ReadOnly = True
        '
        'quant_medicamento
        '
        Me.quant_medicamento.DataPropertyName = "quant_medicamento"
        Me.quant_medicamento.HeaderText = "Quantidade em Estoque"
        Me.quant_medicamento.Name = "quant_medicamento"
        Me.quant_medicamento.ReadOnly = True
        Me.quant_medicamento.Visible = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(6, 21)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(35, 13)
        Me.Label5.TabIndex = 28
        Me.Label5.Text = "Item:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(6, 66)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(60, 13)
        Me.Label6.TabIndex = 29
        Me.Label6.Text = "Validade:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(6, 115)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(132, 13)
        Me.Label7.TabIndex = 30
        Me.Label7.Text = "Quantidade estocada:"
        '
        'grbInfoEstoque
        '
        Me.grbInfoEstoque.Controls.Add(Me.lblDiferenca)
        Me.grbInfoEstoque.Controls.Add(Me.lblUltimaRetirada)
        Me.grbInfoEstoque.Controls.Add(Me.lblQuantMedicamento)
        Me.grbInfoEstoque.Controls.Add(Me.lblValMedicamento)
        Me.grbInfoEstoque.Controls.Add(Me.lblNomeMedicamento)
        Me.grbInfoEstoque.Controls.Add(Me.Label11)
        Me.grbInfoEstoque.Controls.Add(Me.Label5)
        Me.grbInfoEstoque.Controls.Add(Me.Label4)
        Me.grbInfoEstoque.Controls.Add(Me.Label6)
        Me.grbInfoEstoque.Controls.Add(Me.Label7)
        Me.grbInfoEstoque.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grbInfoEstoque.Location = New System.Drawing.Point(328, 5)
        Me.grbInfoEstoque.Name = "grbInfoEstoque"
        Me.grbInfoEstoque.Size = New System.Drawing.Size(268, 280)
        Me.grbInfoEstoque.TabIndex = 36
        Me.grbInfoEstoque.TabStop = False
        Me.grbInfoEstoque.Text = "Informa��es do item em Estoque"
        '
        'lblDiferenca
        '
        Me.lblDiferenca.AutoSize = True
        Me.lblDiferenca.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ajuda.SetHelpString(Me.lblDiferenca, "Total de dias desde a �ltima retirada feita em estoque para o item selecionado.")
        Me.lblDiferenca.Location = New System.Drawing.Point(6, 246)
        Me.lblDiferenca.Name = "lblDiferenca"
        Me.ajuda.SetShowHelp(Me.lblDiferenca, True)
        Me.lblDiferenca.Size = New System.Drawing.Size(77, 13)
        Me.lblDiferenca.TabIndex = 37
        Me.lblDiferenca.Text = "N�o Informado"
        '
        'lblUltimaRetirada
        '
        Me.lblUltimaRetirada.AutoSize = True
        Me.lblUltimaRetirada.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ajuda.SetHelpString(Me.lblUltimaRetirada, "Dados da �ltima retirada feita para este item selecionado.")
        Me.lblUltimaRetirada.Location = New System.Drawing.Point(6, 195)
        Me.lblUltimaRetirada.Name = "lblUltimaRetirada"
        Me.ajuda.SetShowHelp(Me.lblUltimaRetirada, True)
        Me.lblUltimaRetirada.Size = New System.Drawing.Size(77, 13)
        Me.lblUltimaRetirada.TabIndex = 37
        Me.lblUltimaRetirada.Text = "N�o Informado"
        '
        'lblQuantMedicamento
        '
        Me.lblQuantMedicamento.AutoSize = True
        Me.lblQuantMedicamento.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblQuantMedicamento.ForeColor = System.Drawing.Color.Red
        Me.ajuda.SetHelpString(Me.lblQuantMedicamento, "Quantidade em estoque para o item selecionado.")
        Me.lblQuantMedicamento.Location = New System.Drawing.Point(6, 141)
        Me.lblQuantMedicamento.Name = "lblQuantMedicamento"
        Me.ajuda.SetShowHelp(Me.lblQuantMedicamento, True)
        Me.lblQuantMedicamento.Size = New System.Drawing.Size(133, 20)
        Me.lblQuantMedicamento.TabIndex = 37
        Me.lblQuantMedicamento.Text = "N�o Informado!"
        '
        'lblValMedicamento
        '
        Me.lblValMedicamento.AutoSize = True
        Me.lblValMedicamento.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblValMedicamento.ForeColor = System.Drawing.Color.Red
        Me.ajuda.SetHelpString(Me.lblValMedicamento, "Validade do item selecionado.")
        Me.lblValMedicamento.Location = New System.Drawing.Point(6, 90)
        Me.lblValMedicamento.Name = "lblValMedicamento"
        Me.ajuda.SetShowHelp(Me.lblValMedicamento, True)
        Me.lblValMedicamento.Size = New System.Drawing.Size(92, 15)
        Me.lblValMedicamento.TabIndex = 37
        Me.lblValMedicamento.Text = "N�o Informado!"
        '
        'lblNomeMedicamento
        '
        Me.lblNomeMedicamento.AutoSize = True
        Me.lblNomeMedicamento.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNomeMedicamento.ForeColor = System.Drawing.Color.Red
        Me.ajuda.SetHelpString(Me.lblNomeMedicamento, "Nome do item selecionado.")
        Me.lblNomeMedicamento.Location = New System.Drawing.Point(6, 44)
        Me.lblNomeMedicamento.Name = "lblNomeMedicamento"
        Me.ajuda.SetShowHelp(Me.lblNomeMedicamento, True)
        Me.lblNomeMedicamento.Size = New System.Drawing.Size(92, 15)
        Me.lblNomeMedicamento.TabIndex = 37
        Me.lblNomeMedicamento.Text = "N�o Informado!"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(6, 222)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(218, 13)
        Me.Label11.TabIndex = 38
        Me.Label11.Text = "Total de dias desde a �ltima retirada:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(6, 171)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(122, 13)
        Me.Label4.TabIndex = 37
        Me.Label4.Text = "�ltima retirada feita:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(8, 3)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(105, 13)
        Me.Label3.TabIndex = 14
        Me.Label3.Text = "Itens em Estoque"
        '
        'gpbRetirada
        '
        Me.gpbRetirada.Controls.Add(Me.imgInforma��esRegiao)
        Me.gpbRetirada.Controls.Add(Me.lkVerEstoque)
        Me.gpbRetirada.Controls.Add(Me.cmdEditarSaida)
        Me.gpbRetirada.Controls.Add(Me.cmdEfetuarSaida)
        Me.gpbRetirada.Controls.Add(Me.txtQuantidade)
        Me.gpbRetirada.Controls.Add(Me.dpdRegiao)
        Me.gpbRetirada.Controls.Add(Me.Label17)
        Me.gpbRetirada.Controls.Add(Me.Label8)
        Me.gpbRetirada.Controls.Add(Me.Label9)
        Me.gpbRetirada.Controls.Add(Me.txtDataCadastro)
        Me.gpbRetirada.Controls.Add(Me.lblUsuarioCadastrante)
        Me.gpbRetirada.Controls.Add(Me.Label10)
        Me.gpbRetirada.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gpbRetirada.Location = New System.Drawing.Point(7, 304)
        Me.gpbRetirada.Name = "gpbRetirada"
        Me.gpbRetirada.Size = New System.Drawing.Size(589, 216)
        Me.gpbRetirada.TabIndex = 37
        Me.gpbRetirada.TabStop = False
        Me.gpbRetirada.Text = "Retirada de Estoque"
        '
        'imgInforma��esRegiao
        '
        Me.imgInforma��esRegiao.BackColor = System.Drawing.Color.Transparent
        Me.ajuda.SetHelpString(Me.imgInforma��esRegiao, "Posicione o ponteiro do mouse sobre esta imagem para ver detalhes sobre a regi�o " & _
                "ao lado selecionada.")
        Me.imgInforma��esRegiao.Image = Global.SICEP.My.Resources.Resources.infos
        Me.imgInforma��esRegiao.Location = New System.Drawing.Point(313, 73)
        Me.imgInforma��esRegiao.Name = "imgInforma��esRegiao"
        Me.ajuda.SetShowHelp(Me.imgInforma��esRegiao, True)
        Me.imgInforma��esRegiao.Size = New System.Drawing.Size(21, 21)
        Me.imgInforma��esRegiao.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.imgInforma��esRegiao.TabIndex = 49
        Me.imgInforma��esRegiao.TabStop = False
        '
        'lkVerEstoque
        '
        Me.lkVerEstoque.AutoSize = True
        Me.lkVerEstoque.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ajuda.SetHelpString(Me.lkVerEstoque, "Clique aqui para ver a situa��o atual do estoque.")
        Me.lkVerEstoque.Location = New System.Drawing.Point(411, 194)
        Me.lkVerEstoque.Name = "lkVerEstoque"
        Me.ajuda.SetShowHelp(Me.lkVerEstoque, True)
        Me.lkVerEstoque.Size = New System.Drawing.Size(177, 13)
        Me.lkVerEstoque.TabIndex = 8
        Me.lkVerEstoque.TabStop = True
        Me.lkVerEstoque.Text = "Ver situa��o do estoque atualmente"
        '
        'cmdEditarSaida
        '
        Me.cmdEditarSaida.BackColor = System.Drawing.SystemColors.Control
        Me.cmdEditarSaida.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ajuda.SetHelpString(Me.cmdEditarSaida, "Clique aqui para editar uma saida que porventura tenha sido registrada erroneamen" & _
                "te.")
        Me.cmdEditarSaida.Location = New System.Drawing.Point(131, 173)
        Me.cmdEditarSaida.Name = "cmdEditarSaida"
        Me.ajuda.SetShowHelp(Me.cmdEditarSaida, True)
        Me.cmdEditarSaida.Size = New System.Drawing.Size(105, 34)
        Me.cmdEditarSaida.TabIndex = 7
        Me.cmdEditarSaida.Text = "E&ditar Sa�das"
        Me.cmdEditarSaida.UseVisualStyleBackColor = False
        '
        'cmdEfetuarSaida
        '
        Me.cmdEfetuarSaida.BackColor = System.Drawing.SystemColors.Control
        Me.cmdEfetuarSaida.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ajuda.SetHelpString(Me.cmdEfetuarSaida, "Clique aqui para efetuar uma saida do estoque.")
        Me.cmdEfetuarSaida.Location = New System.Drawing.Point(9, 173)
        Me.cmdEfetuarSaida.Name = "cmdEfetuarSaida"
        Me.ajuda.SetShowHelp(Me.cmdEfetuarSaida, True)
        Me.cmdEfetuarSaida.Size = New System.Drawing.Size(105, 34)
        Me.cmdEfetuarSaida.TabIndex = 6
        Me.cmdEfetuarSaida.Text = "&Efetuar Sa�da"
        Me.cmdEfetuarSaida.UseVisualStyleBackColor = False
        '
        'txtQuantidade
        '
        Me.txtQuantidade.Font = New System.Drawing.Font("Microsoft Sans Serif", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtQuantidade.ForeColor = System.Drawing.Color.Red
        Me.ajuda.SetHelpString(Me.txtQuantidade, "Digite a quantidade a ser retirada do estoque.")
        Me.txtQuantidade.Location = New System.Drawing.Point(9, 118)
        Me.txtQuantidade.MaxLength = 8
        Me.txtQuantidade.Name = "txtQuantidade"
        Me.ajuda.SetShowHelp(Me.txtQuantidade, True)
        Me.txtQuantidade.Size = New System.Drawing.Size(298, 49)
        Me.txtQuantidade.TabIndex = 5
        '
        'dpdRegiao
        '
        Me.dpdRegiao.FormattingEnabled = True
        Me.ajuda.SetHelpString(Me.dpdRegiao, "Regi�o para onde vai ser destinado este item.")
        Me.dpdRegiao.Location = New System.Drawing.Point(122, 73)
        Me.dpdRegiao.Name = "dpdRegiao"
        Me.ajuda.SetShowHelp(Me.dpdRegiao, True)
        Me.dpdRegiao.Size = New System.Drawing.Size(185, 21)
        Me.dpdRegiao.TabIndex = 4
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(6, 101)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(123, 13)
        Me.Label17.TabIndex = 43
        Me.Label17.Text = "Quantidade retirada:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(6, 76)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(116, 13)
        Me.Label8.TabIndex = 38
        Me.Label8.Text = "Regi�o de Destino:"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(6, 23)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(54, 13)
        Me.Label9.TabIndex = 40
        Me.Label9.Text = "Usu�rio:"
        '
        'txtDataCadastro
        '
        Me.txtDataCadastro.CalendarFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDataCadastro.Enabled = False
        Me.txtDataCadastro.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDataCadastro.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.ajuda.SetHelpString(Me.txtDataCadastro, "Data da retirada.")
        Me.txtDataCadastro.Location = New System.Drawing.Point(122, 45)
        Me.txtDataCadastro.MaxDate = New Date(2006, 8, 14, 0, 0, 0, 0)
        Me.txtDataCadastro.Name = "txtDataCadastro"
        Me.ajuda.SetShowHelp(Me.txtDataCadastro, True)
        Me.txtDataCadastro.Size = New System.Drawing.Size(185, 20)
        Me.txtDataCadastro.TabIndex = 3
        Me.txtDataCadastro.Value = New Date(2006, 8, 14, 0, 0, 0, 0)
        '
        'lblUsuarioCadastrante
        '
        Me.lblUsuarioCadastrante.AutoSize = True
        Me.lblUsuarioCadastrante.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUsuarioCadastrante.ForeColor = System.Drawing.Color.Red
        Me.ajuda.SetHelpString(Me.lblUsuarioCadastrante, "Nome do usu�rio logado.")
        Me.lblUsuarioCadastrante.Location = New System.Drawing.Point(119, 23)
        Me.lblUsuarioCadastrante.Name = "lblUsuarioCadastrante"
        Me.ajuda.SetShowHelp(Me.lblUsuarioCadastrante, True)
        Me.lblUsuarioCadastrante.Size = New System.Drawing.Size(90, 13)
        Me.lblUsuarioCadastrante.TabIndex = 42
        Me.lblUsuarioCadastrante.Text = "N�o Informado"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(6, 49)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(108, 13)
        Me.Label10.TabIndex = 39
        Me.Label10.Text = "Data da Retirada:"
        '
        'ToolTip
        '
        Me.ToolTip.AutoPopDelay = 12000
        Me.ToolTip.InitialDelay = 500
        Me.ToolTip.IsBalloon = True
        Me.ToolTip.ReshowDelay = 100
        Me.ToolTip.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info
        Me.ToolTip.ToolTipTitle = "Informa��es"
        '
        'lblCodMedicamento
        '
        Me.lblCodMedicamento.AutoSize = True
        Me.lblCodMedicamento.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCodMedicamento.Location = New System.Drawing.Point(217, 300)
        Me.lblCodMedicamento.Name = "lblCodMedicamento"
        Me.lblCodMedicamento.Size = New System.Drawing.Size(0, 13)
        Me.lblCodMedicamento.TabIndex = 38
        Me.lblCodMedicamento.Visible = False
        '
        'imgInformacoes
        '
        Me.imgInformacoes.BackColor = System.Drawing.Color.Transparent
        Me.ajuda.SetHelpString(Me.imgInformacoes, "Posicione o ponteiro do mouse sobre esta imagem para ver detalhes sobre o item se" & _
                "lecionado.")
        Me.imgInformacoes.Image = Global.SICEP.My.Resources.Resources.infos
        Me.imgInformacoes.Location = New System.Drawing.Point(295, 15)
        Me.imgInformacoes.Name = "imgInformacoes"
        Me.ajuda.SetShowHelp(Me.imgInformacoes, True)
        Me.imgInformacoes.Size = New System.Drawing.Size(21, 21)
        Me.imgInformacoes.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.imgInformacoes.TabIndex = 26
        Me.imgInformacoes.TabStop = False
        '
        'chkMateriais
        '
        Me.chkMateriais.AutoSize = True
        Me.chkMateriais.Checked = True
        Me.chkMateriais.CheckState = System.Windows.Forms.CheckState.Checked
        Me.ajuda.SetHelpString(Me.chkMateriais, "Marque esta op��o para exibir os materiais de consumo.")
        Me.chkMateriais.Location = New System.Drawing.Point(107, 23)
        Me.chkMateriais.Name = "chkMateriais"
        Me.ajuda.SetShowHelp(Me.chkMateriais, True)
        Me.chkMateriais.Size = New System.Drawing.Size(130, 17)
        Me.chkMateriais.TabIndex = 40
        Me.chkMateriais.Text = "Materiais de Consumo"
        Me.chkMateriais.UseVisualStyleBackColor = True
        '
        'chkMedicamentos
        '
        Me.chkMedicamentos.AutoSize = True
        Me.chkMedicamentos.Checked = True
        Me.chkMedicamentos.CheckState = System.Windows.Forms.CheckState.Checked
        Me.ajuda.SetHelpString(Me.chkMedicamentos, "Marque esta op��o para exibir os medicamentos.")
        Me.chkMedicamentos.Location = New System.Drawing.Point(11, 23)
        Me.chkMedicamentos.Name = "chkMedicamentos"
        Me.ajuda.SetShowHelp(Me.chkMedicamentos, True)
        Me.chkMedicamentos.Size = New System.Drawing.Size(95, 17)
        Me.chkMedicamentos.TabIndex = 39
        Me.chkMedicamentos.Text = "Medicamentos"
        Me.chkMedicamentos.UseVisualStyleBackColor = True
        '
        'ajuda
        '
        Me.ajuda.HelpNamespace = "C:\Arquivos de programas\SICEP\Ajuda\frmSecGestaoSaidas.html"
        '
        'frmSaiSecretaria
        '
        Me.AcceptButton = Me.cmdEfetuarSaida
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(604, 523)
        Me.Controls.Add(Me.chkMateriais)
        Me.Controls.Add(Me.chkMedicamentos)
        Me.Controls.Add(Me.lblCodMedicamento)
        Me.Controls.Add(Me.gpbRetirada)
        Me.Controls.Add(Me.grbInfoEstoque)
        Me.Controls.Add(Me.imgInformacoes)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.lkImprimir)
        Me.Controls.Add(Me.lblPesquisa)
        Me.Controls.Add(Me.txtPesqValidade)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtPesqMedicamento)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.grdEstoqueSecretaria)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.HelpButton = True
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmSaiSecretaria"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Formul�rio para Gest�o de Sa�das em Estoque da Secretaria"
        CType(Me.grdEstoqueSecretaria, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grbInfoEstoque.ResumeLayout(False)
        Me.grbInfoEstoque.PerformLayout()
        Me.gpbRetirada.ResumeLayout(False)
        Me.gpbRetirada.PerformLayout()
        CType(Me.imgInforma��esRegiao, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.imgInformacoes, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lkImprimir As System.Windows.Forms.LinkLabel
    Friend WithEvents lblPesquisa As System.Windows.Forms.Label
    Friend WithEvents txtPesqValidade As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtPesqMedicamento As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents grdEstoqueSecretaria As System.Windows.Forms.DataGridView
    Friend WithEvents imgInformacoes As System.Windows.Forms.PictureBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents grbInfoEstoque As System.Windows.Forms.GroupBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents lblDiferenca As System.Windows.Forms.Label
    Friend WithEvents lblUltimaRetirada As System.Windows.Forms.Label
    Friend WithEvents lblQuantMedicamento As System.Windows.Forms.Label
    Friend WithEvents lblValMedicamento As System.Windows.Forms.Label
    Friend WithEvents lblNomeMedicamento As System.Windows.Forms.Label
    Friend WithEvents gpbRetirada As System.Windows.Forms.GroupBox
    Friend WithEvents txtQuantidade As System.Windows.Forms.TextBox
    Friend WithEvents dpdRegiao As System.Windows.Forms.ComboBox
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents txtDataCadastro As System.Windows.Forms.DateTimePicker
    Friend WithEvents lblUsuarioCadastrante As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents cmdEfetuarSaida As System.Windows.Forms.Button
    Friend WithEvents cmdEditarSaida As System.Windows.Forms.Button
    Friend WithEvents lkVerEstoque As System.Windows.Forms.LinkLabel
    Friend WithEvents ToolTip As System.Windows.Forms.ToolTip
    Friend WithEvents lblCodMedicamento As System.Windows.Forms.Label
    Friend WithEvents imgInforma��esRegiao As System.Windows.Forms.PictureBox
    Friend WithEvents chkMateriais As System.Windows.Forms.CheckBox
    Friend WithEvents chkMedicamentos As System.Windows.Forms.CheckBox
    Friend WithEvents nome_medicamento As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cod_medicamento As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents val_medicamento As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents quant_medicamento As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ajuda As System.Windows.Forms.HelpProvider
End Class
