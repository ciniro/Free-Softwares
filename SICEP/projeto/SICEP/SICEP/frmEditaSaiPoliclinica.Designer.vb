<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmEditaSaiPoliclinica
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmEditaSaiPoliclinica))
        Me.lkImprimir = New System.Windows.Forms.LinkLabel
        Me.lblCodSaida = New System.Windows.Forms.Label
        Me.cmdExcluir = New System.Windows.Forms.Button
        Me.cmdAlterar = New System.Windows.Forms.Button
        Me.txtQuantidade = New System.Windows.Forms.TextBox
        Me.txtValidade = New System.Windows.Forms.DateTimePicker
        Me.dpdMedicamentos = New System.Windows.Forms.ComboBox
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.lblInfoData = New System.Windows.Forms.Label
        Me.chkPesquisaPorData = New System.Windows.Forms.CheckBox
        Me.txtDataFinal = New System.Windows.Forms.DateTimePicker
        Me.txtDataInicial = New System.Windows.Forms.DateTimePicker
        Me.Label4 = New System.Windows.Forms.Label
        Me.txtPesqValidade = New System.Windows.Forms.TextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.txtPesqMedicamento = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.grdEditarEntradas = New System.Windows.Forms.DataGridView
        Me.cod_sai_poli = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.data_sai_poli = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.FKcod_medicamento = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.nome_medicamento = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.validade_sai_poli = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.quantidade_sai_poli = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.FKcod_usuario = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.nome_usuario = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.FKcod_paciente = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.nome_paciente = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.flg_material = New System.Windows.Forms.DataGridViewCheckBoxColumn
        Me.chkMateriais = New System.Windows.Forms.CheckBox
        Me.chkMedicamentos = New System.Windows.Forms.CheckBox
        Me.ajuda = New System.Windows.Forms.HelpProvider
        CType(Me.grdEditarEntradas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lkImprimir
        '
        Me.lkImprimir.AutoSize = True
        Me.ajuda.SetHelpString(Me.lkImprimir, "Clique aqui para ver a pesquisa efetuada em modo de impressão.")
        Me.lkImprimir.Location = New System.Drawing.Point(12, 449)
        Me.lkImprimir.Name = "lkImprimir"
        Me.ajuda.SetShowHelp(Me.lkImprimir, True)
        Me.lkImprimir.Size = New System.Drawing.Size(202, 13)
        Me.lkImprimir.TabIndex = 10
        Me.lkImprimir.TabStop = True
        Me.lkImprimir.Text = "Ver esta pesquisa em modo de impressão"
        '
        'lblCodSaida
        '
        Me.lblCodSaida.AutoSize = True
        Me.lblCodSaida.Location = New System.Drawing.Point(593, 368)
        Me.lblCodSaida.Name = "lblCodSaida"
        Me.lblCodSaida.Size = New System.Drawing.Size(0, 13)
        Me.lblCodSaida.TabIndex = 69
        Me.lblCodSaida.Visible = False
        '
        'cmdExcluir
        '
        Me.cmdExcluir.BackColor = System.Drawing.SystemColors.Control
        Me.ajuda.SetHelpString(Me.cmdExcluir, "Clique aqui para excluir a saida selecionada.")
        Me.cmdExcluir.Location = New System.Drawing.Point(502, 431)
        Me.cmdExcluir.Name = "cmdExcluir"
        Me.ajuda.SetShowHelp(Me.cmdExcluir, True)
        Me.cmdExcluir.Size = New System.Drawing.Size(130, 31)
        Me.cmdExcluir.TabIndex = 7
        Me.cmdExcluir.Text = "Excluir"
        Me.cmdExcluir.UseVisualStyleBackColor = False
        '
        'cmdAlterar
        '
        Me.cmdAlterar.BackColor = System.Drawing.SystemColors.Control
        Me.ajuda.SetHelpString(Me.cmdAlterar, "Clique aqui para alterar a quantidade da saida selecionada.")
        Me.cmdAlterar.Location = New System.Drawing.Point(330, 431)
        Me.cmdAlterar.Name = "cmdAlterar"
        Me.ajuda.SetShowHelp(Me.cmdAlterar, True)
        Me.cmdAlterar.Size = New System.Drawing.Size(136, 31)
        Me.cmdAlterar.TabIndex = 6
        Me.cmdAlterar.Text = "Alterar "
        Me.cmdAlterar.UseVisualStyleBackColor = False
        '
        'txtQuantidade
        '
        Me.txtQuantidade.Font = New System.Drawing.Font("Microsoft Sans Serif", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtQuantidade.ForeColor = System.Drawing.Color.Red
        Me.ajuda.SetHelpString(Me.txtQuantidade, "Digite aqui a quantidade.")
        Me.txtQuantidade.Location = New System.Drawing.Point(330, 366)
        Me.txtQuantidade.Name = "txtQuantidade"
        Me.ajuda.SetShowHelp(Me.txtQuantidade, True)
        Me.txtQuantidade.Size = New System.Drawing.Size(305, 49)
        Me.txtQuantidade.TabIndex = 5
        '
        'txtValidade
        '
        Me.txtValidade.Enabled = False
        Me.txtValidade.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.ajuda.SetHelpString(Me.txtValidade, "A validade do item selecionado.")
        Me.txtValidade.Location = New System.Drawing.Point(82, 396)
        Me.txtValidade.Name = "txtValidade"
        Me.ajuda.SetShowHelp(Me.txtValidade, True)
        Me.txtValidade.ShowUpDown = True
        Me.txtValidade.Size = New System.Drawing.Size(178, 20)
        Me.txtValidade.TabIndex = 9
        '
        'dpdMedicamentos
        '
        Me.dpdMedicamentos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple
        Me.dpdMedicamentos.Enabled = False
        Me.dpdMedicamentos.FormattingEnabled = True
        Me.ajuda.SetHelpString(Me.dpdMedicamentos, "O nome do item selecionado.")
        Me.dpdMedicamentos.Location = New System.Drawing.Point(82, 366)
        Me.dpdMedicamentos.Name = "dpdMedicamentos"
        Me.ajuda.SetShowHelp(Me.dpdMedicamentos, True)
        Me.dpdMedicamentos.Size = New System.Drawing.Size(178, 21)
        Me.dpdMedicamentos.TabIndex = 8
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(266, 369)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(65, 13)
        Me.Label7.TabIndex = 68
        Me.Label7.Text = "Quantidade:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(12, 400)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(51, 13)
        Me.Label6.TabIndex = 67
        Me.Label6.Text = "Validade:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(9, 369)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(30, 13)
        Me.Label5.TabIndex = 66
        Me.Label5.Text = "Item:"
        '
        'lblInfoData
        '
        Me.lblInfoData.AutoSize = True
        Me.lblInfoData.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblInfoData.ForeColor = System.Drawing.Color.Red
        Me.lblInfoData.Location = New System.Drawing.Point(403, 16)
        Me.lblInfoData.Name = "lblInfoData"
        Me.lblInfoData.Size = New System.Drawing.Size(240, 13)
        Me.lblInfoData.TabIndex = 65
        Me.lblInfoData.Text = "A data inicial está maior que a data final!"
        Me.lblInfoData.Visible = False
        '
        'chkPesquisaPorData
        '
        Me.chkPesquisaPorData.AutoSize = True
        Me.ajuda.SetHelpString(Me.chkPesquisaPorData, "Marque esta opção para habilitar a pesquisa por data.")
        Me.chkPesquisaPorData.Location = New System.Drawing.Point(12, 12)
        Me.chkPesquisaPorData.Name = "chkPesquisaPorData"
        Me.ajuda.SetShowHelp(Me.chkPesquisaPorData, True)
        Me.chkPesquisaPorData.Size = New System.Drawing.Size(151, 17)
        Me.chkPesquisaPorData.TabIndex = 50
        Me.chkPesquisaPorData.Text = "Habilitar pesquisa por data"
        Me.chkPesquisaPorData.UseVisualStyleBackColor = True
        '
        'txtDataFinal
        '
        Me.txtDataFinal.Enabled = False
        Me.txtDataFinal.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.ajuda.SetHelpString(Me.txtDataFinal, "Digite aqui a data final.")
        Me.txtDataFinal.Location = New System.Drawing.Point(481, 73)
        Me.txtDataFinal.Name = "txtDataFinal"
        Me.ajuda.SetShowHelp(Me.txtDataFinal, True)
        Me.txtDataFinal.Size = New System.Drawing.Size(151, 20)
        Me.txtDataFinal.TabIndex = 3
        Me.txtDataFinal.Value = New Date(2010, 12, 12, 4, 47, 0, 0)
        '
        'txtDataInicial
        '
        Me.txtDataInicial.Enabled = False
        Me.txtDataInicial.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.ajuda.SetHelpString(Me.txtDataInicial, "Digite aqui a data inicial.")
        Me.txtDataInicial.Location = New System.Drawing.Point(481, 44)
        Me.txtDataInicial.Name = "txtDataInicial"
        Me.ajuda.SetShowHelp(Me.txtDataInicial, True)
        Me.txtDataInicial.Size = New System.Drawing.Size(151, 20)
        Me.txtDataInicial.TabIndex = 2
        Me.txtDataInicial.Value = New Date(2000, 1, 1, 4, 47, 0, 0)
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(403, 76)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(58, 13)
        Me.Label4.TabIndex = 64
        Me.Label4.Text = "Data Final:"
        '
        'txtPesqValidade
        '
        Me.ajuda.SetHelpString(Me.txtPesqValidade, "Digite aqui a validade do item procurado.")
        Me.txtPesqValidade.Location = New System.Drawing.Point(108, 73)
        Me.txtPesqValidade.MaxLength = 10
        Me.txtPesqValidade.Name = "txtPesqValidade"
        Me.ajuda.SetShowHelp(Me.txtPesqValidade, True)
        Me.txtPesqValidade.Size = New System.Drawing.Size(220, 20)
        Me.txtPesqValidade.TabIndex = 1
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(9, 76)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(70, 13)
        Me.Label3.TabIndex = 63
        Me.Label3.Text = "Por Validade:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(403, 47)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(63, 13)
        Me.Label2.TabIndex = 60
        Me.Label2.Text = "Data Inicial:"
        '
        'txtPesqMedicamento
        '
        Me.ajuda.SetHelpString(Me.txtPesqMedicamento, "Digite aqui o nome do item procurado.")
        Me.txtPesqMedicamento.Location = New System.Drawing.Point(108, 44)
        Me.txtPesqMedicamento.MaxLength = 100
        Me.txtPesqMedicamento.Name = "txtPesqMedicamento"
        Me.ajuda.SetShowHelp(Me.txtPesqMedicamento, True)
        Me.txtPesqMedicamento.Size = New System.Drawing.Size(220, 20)
        Me.txtPesqMedicamento.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(9, 47)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(49, 13)
        Me.Label1.TabIndex = 56
        Me.Label1.Text = "Por Item:"
        '
        'grdEditarEntradas
        '
        Me.grdEditarEntradas.AllowUserToAddRows = False
        Me.grdEditarEntradas.AllowUserToDeleteRows = False
        Me.grdEditarEntradas.AllowUserToResizeColumns = False
        Me.grdEditarEntradas.AllowUserToResizeRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.PaleTurquoise
        Me.grdEditarEntradas.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.grdEditarEntradas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.grdEditarEntradas.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells
        Me.grdEditarEntradas.BackgroundColor = System.Drawing.Color.White
        Me.grdEditarEntradas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grdEditarEntradas.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.cod_sai_poli, Me.data_sai_poli, Me.FKcod_medicamento, Me.nome_medicamento, Me.validade_sai_poli, Me.quantidade_sai_poli, Me.FKcod_usuario, Me.nome_usuario, Me.FKcod_paciente, Me.nome_paciente, Me.flg_material})
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.grdEditarEntradas.DefaultCellStyle = DataGridViewCellStyle2
        Me.ajuda.SetHelpString(Me.grdEditarEntradas, "Clique no nome do item para carregar seus dados.")
        Me.grdEditarEntradas.Location = New System.Drawing.Point(12, 122)
        Me.grdEditarEntradas.MultiSelect = False
        Me.grdEditarEntradas.Name = "grdEditarEntradas"
        Me.grdEditarEntradas.ReadOnly = True
        Me.grdEditarEntradas.RowHeadersVisible = False
        Me.grdEditarEntradas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.ajuda.SetShowHelp(Me.grdEditarEntradas, True)
        Me.grdEditarEntradas.Size = New System.Drawing.Size(623, 234)
        Me.grdEditarEntradas.TabIndex = 4
        '
        'cod_sai_poli
        '
        Me.cod_sai_poli.DataPropertyName = "cod_sai_poli"
        Me.cod_sai_poli.HeaderText = "Código da Saída"
        Me.cod_sai_poli.Name = "cod_sai_poli"
        Me.cod_sai_poli.ReadOnly = True
        Me.cod_sai_poli.Visible = False
        '
        'data_sai_poli
        '
        Me.data_sai_poli.DataPropertyName = "data_sai_poli"
        Me.data_sai_poli.HeaderText = "Data da Saída"
        Me.data_sai_poli.Name = "data_sai_poli"
        Me.data_sai_poli.ReadOnly = True
        '
        'FKcod_medicamento
        '
        Me.FKcod_medicamento.DataPropertyName = "FKcod_medicamento"
        Me.FKcod_medicamento.HeaderText = "Código do Medicamento"
        Me.FKcod_medicamento.Name = "FKcod_medicamento"
        Me.FKcod_medicamento.ReadOnly = True
        Me.FKcod_medicamento.Visible = False
        '
        'nome_medicamento
        '
        Me.nome_medicamento.DataPropertyName = "nome_medicamento"
        Me.nome_medicamento.HeaderText = "Item"
        Me.nome_medicamento.Name = "nome_medicamento"
        Me.nome_medicamento.ReadOnly = True
        '
        'validade_sai_poli
        '
        Me.validade_sai_poli.DataPropertyName = "validade_sai_poli"
        Me.validade_sai_poli.HeaderText = "Validade"
        Me.validade_sai_poli.Name = "validade_sai_poli"
        Me.validade_sai_poli.ReadOnly = True
        '
        'quantidade_sai_poli
        '
        Me.quantidade_sai_poli.DataPropertyName = "quantidade_sai_poli"
        Me.quantidade_sai_poli.HeaderText = "Quantidade"
        Me.quantidade_sai_poli.Name = "quantidade_sai_poli"
        Me.quantidade_sai_poli.ReadOnly = True
        '
        'FKcod_usuario
        '
        Me.FKcod_usuario.DataPropertyName = "FKcod_usuario"
        Me.FKcod_usuario.HeaderText = "Código do Usuário"
        Me.FKcod_usuario.Name = "FKcod_usuario"
        Me.FKcod_usuario.ReadOnly = True
        Me.FKcod_usuario.Visible = False
        '
        'nome_usuario
        '
        Me.nome_usuario.DataPropertyName = "nome_usuario"
        Me.nome_usuario.HeaderText = "Usuário"
        Me.nome_usuario.Name = "nome_usuario"
        Me.nome_usuario.ReadOnly = True
        '
        'FKcod_paciente
        '
        Me.FKcod_paciente.DataPropertyName = "FKcod_paciente"
        Me.FKcod_paciente.HeaderText = "Código do Paciente"
        Me.FKcod_paciente.Name = "FKcod_paciente"
        Me.FKcod_paciente.ReadOnly = True
        Me.FKcod_paciente.Visible = False
        '
        'nome_paciente
        '
        Me.nome_paciente.DataPropertyName = "nome_paciente"
        Me.nome_paciente.HeaderText = "Paciente"
        Me.nome_paciente.Name = "nome_paciente"
        Me.nome_paciente.ReadOnly = True
        '
        'flg_material
        '
        Me.flg_material.DataPropertyName = "flg_material"
        Me.flg_material.HeaderText = "Tipo"
        Me.flg_material.Name = "flg_material"
        Me.flg_material.ReadOnly = True
        Me.flg_material.Visible = False
        '
        'chkMateriais
        '
        Me.chkMateriais.AutoSize = True
        Me.chkMateriais.Checked = True
        Me.chkMateriais.CheckState = System.Windows.Forms.CheckState.Checked
        Me.ajuda.SetHelpString(Me.chkMateriais, "Marque esta opção para exibir os materias de consumo na pesquisa.")
        Me.chkMateriais.Location = New System.Drawing.Point(113, 99)
        Me.chkMateriais.Name = "chkMateriais"
        Me.ajuda.SetShowHelp(Me.chkMateriais, True)
        Me.chkMateriais.Size = New System.Drawing.Size(130, 17)
        Me.chkMateriais.TabIndex = 72
        Me.chkMateriais.Text = "Materiais de Consumo"
        Me.chkMateriais.UseVisualStyleBackColor = True
        '
        'chkMedicamentos
        '
        Me.chkMedicamentos.AutoSize = True
        Me.chkMedicamentos.Checked = True
        Me.chkMedicamentos.CheckState = System.Windows.Forms.CheckState.Checked
        Me.ajuda.SetHelpString(Me.chkMedicamentos, "Marque esta opção para ver os medicamentos na pesquisa.")
        Me.chkMedicamentos.Location = New System.Drawing.Point(12, 99)
        Me.chkMedicamentos.Name = "chkMedicamentos"
        Me.ajuda.SetShowHelp(Me.chkMedicamentos, True)
        Me.chkMedicamentos.Size = New System.Drawing.Size(95, 17)
        Me.chkMedicamentos.TabIndex = 71
        Me.chkMedicamentos.Text = "Medicamentos"
        Me.chkMedicamentos.UseVisualStyleBackColor = True
        '
        'ajuda
        '
        Me.ajuda.HelpNamespace = "C:\Arquivos de programas\SICEP\Ajuda\frmPoliGestaoSaidas.html"
        '
        'frmEditaSaiPoliclinica
        '
        Me.AcceptButton = Me.cmdAlterar
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(653, 479)
        Me.Controls.Add(Me.chkMateriais)
        Me.Controls.Add(Me.chkMedicamentos)
        Me.Controls.Add(Me.lkImprimir)
        Me.Controls.Add(Me.lblCodSaida)
        Me.Controls.Add(Me.cmdExcluir)
        Me.Controls.Add(Me.cmdAlterar)
        Me.Controls.Add(Me.txtQuantidade)
        Me.Controls.Add(Me.txtValidade)
        Me.Controls.Add(Me.dpdMedicamentos)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.lblInfoData)
        Me.Controls.Add(Me.chkPesquisaPorData)
        Me.Controls.Add(Me.txtDataFinal)
        Me.Controls.Add(Me.txtDataInicial)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtPesqValidade)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtPesqMedicamento)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.grdEditarEntradas)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.HelpButton = True
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmEditaSaiPoliclinica"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Formulário para Edição de Saídas na Policlínica"
        CType(Me.grdEditarEntradas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lkImprimir As System.Windows.Forms.LinkLabel
    Friend WithEvents lblCodSaida As System.Windows.Forms.Label
    Friend WithEvents cmdExcluir As System.Windows.Forms.Button
    Friend WithEvents cmdAlterar As System.Windows.Forms.Button
    Friend WithEvents txtQuantidade As System.Windows.Forms.TextBox
    Friend WithEvents txtValidade As System.Windows.Forms.DateTimePicker
    Friend WithEvents dpdMedicamentos As System.Windows.Forms.ComboBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents lblInfoData As System.Windows.Forms.Label
    Friend WithEvents chkPesquisaPorData As System.Windows.Forms.CheckBox
    Friend WithEvents txtDataFinal As System.Windows.Forms.DateTimePicker
    Friend WithEvents txtDataInicial As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtPesqValidade As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtPesqMedicamento As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents grdEditarEntradas As System.Windows.Forms.DataGridView
    Friend WithEvents chkMateriais As System.Windows.Forms.CheckBox
    Friend WithEvents chkMedicamentos As System.Windows.Forms.CheckBox
    Friend WithEvents cod_sai_poli As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents data_sai_poli As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FKcod_medicamento As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents nome_medicamento As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents validade_sai_poli As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents quantidade_sai_poli As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FKcod_usuario As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents nome_usuario As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FKcod_paciente As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents nome_paciente As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents flg_material As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents ajuda As System.Windows.Forms.HelpProvider
End Class
