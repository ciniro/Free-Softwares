<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmEstPoliclinica
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
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmEstPoliclinica))
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
        Me.chkMateriais = New System.Windows.Forms.CheckBox
        Me.chkMedicamentos = New System.Windows.Forms.CheckBox
        Me.ajuda = New System.Windows.Forms.HelpProvider
        CType(Me.grdEstoqueSecretaria, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lkImprimir
        '
        Me.lkImprimir.AutoSize = True
        Me.ajuda.SetHelpString(Me.lkImprimir, "Clique sobre este link para exibir sua pesquisa de estoque em modo de impressão.")
        Me.lkImprimir.Location = New System.Drawing.Point(347, 456)
        Me.lkImprimir.Name = "lkImprimir"
        Me.ajuda.SetShowHelp(Me.lkImprimir, True)
        Me.lkImprimir.Size = New System.Drawing.Size(202, 13)
        Me.lkImprimir.TabIndex = 5
        Me.lkImprimir.TabStop = True
        Me.lkImprimir.Text = "Ver esta pesquisa em modo de impressão"
        '
        'lblPesquisa
        '
        Me.lblPesquisa.AutoSize = True
        Me.lblPesquisa.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPesquisa.Location = New System.Drawing.Point(21, 13)
        Me.lblPesquisa.Name = "lblPesquisa"
        Me.lblPesquisa.Size = New System.Drawing.Size(211, 13)
        Me.lblPesquisa.TabIndex = 12
        Me.lblPesquisa.Text = "Você não está usando a pesquisa..."
        '
        'txtPesqValidade
        '
        Me.ajuda.SetHelpString(Me.txtPesqValidade, "Digite aqui a validade do item procurado.")
        Me.txtPesqValidade.Location = New System.Drawing.Point(409, 37)
        Me.txtPesqValidade.MaxLength = 10
        Me.txtPesqValidade.Name = "txtPesqValidade"
        Me.ajuda.SetShowHelp(Me.txtPesqValidade, True)
        Me.txtPesqValidade.Size = New System.Drawing.Size(128, 20)
        Me.txtPesqValidade.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(333, 40)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(70, 13)
        Me.Label2.TabIndex = 10
        Me.Label2.Text = "Por Validade:"
        '
        'txtPesqMedicamento
        '
        Me.ajuda.SetHelpString(Me.txtPesqMedicamento, "Digite aqui o nome do item procurado.")
        Me.txtPesqMedicamento.Location = New System.Drawing.Point(120, 37)
        Me.txtPesqMedicamento.MaxLength = 100
        Me.txtPesqMedicamento.Name = "txtPesqMedicamento"
        Me.ajuda.SetShowHelp(Me.txtPesqMedicamento, True)
        Me.txtPesqMedicamento.Size = New System.Drawing.Size(207, 20)
        Me.txtPesqMedicamento.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(21, 40)
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
        Me.grdEstoqueSecretaria.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grdEstoqueSecretaria.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.nome_medicamento, Me.cod_medicamento, Me.val_medicamento, Me.quant_medicamento})
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.grdEstoqueSecretaria.DefaultCellStyle = DataGridViewCellStyle2
        Me.ajuda.SetHelpString(Me.grdEstoqueSecretaria, "Itens em estoque, validades e suas quantidades.")
        Me.grdEstoqueSecretaria.Location = New System.Drawing.Point(14, 86)
        Me.grdEstoqueSecretaria.MultiSelect = False
        Me.grdEstoqueSecretaria.Name = "grdEstoqueSecretaria"
        Me.grdEstoqueSecretaria.ReadOnly = True
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.White
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.grdEstoqueSecretaria.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.grdEstoqueSecretaria.RowHeadersVisible = False
        Me.grdEstoqueSecretaria.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.grdEstoqueSecretaria.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.grdEstoqueSecretaria.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.grdEstoqueSecretaria.ShowEditingIcon = False
        Me.ajuda.SetShowHelp(Me.grdEstoqueSecretaria, True)
        Me.grdEstoqueSecretaria.Size = New System.Drawing.Size(534, 363)
        Me.grdEstoqueSecretaria.TabIndex = 4
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
        Me.cod_medicamento.HeaderText = "Código"
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
        Me.quant_medicamento.HeaderText = "Quantidade"
        Me.quant_medicamento.Name = "quant_medicamento"
        Me.quant_medicamento.ReadOnly = True
        '
        'chkMateriais
        '
        Me.chkMateriais.AutoSize = True
        Me.chkMateriais.Checked = True
        Me.chkMateriais.CheckState = System.Windows.Forms.CheckState.Checked
        Me.ajuda.SetHelpString(Me.chkMateriais, "Marque esta opção para exibir os materiais de consumo.")
        Me.chkMateriais.Location = New System.Drawing.Point(125, 63)
        Me.chkMateriais.Name = "chkMateriais"
        Me.ajuda.SetShowHelp(Me.chkMateriais, True)
        Me.chkMateriais.Size = New System.Drawing.Size(130, 17)
        Me.chkMateriais.TabIndex = 3
        Me.chkMateriais.Text = "Materiais de Consumo"
        Me.chkMateriais.UseVisualStyleBackColor = True
        '
        'chkMedicamentos
        '
        Me.chkMedicamentos.AutoSize = True
        Me.chkMedicamentos.Checked = True
        Me.chkMedicamentos.CheckState = System.Windows.Forms.CheckState.Checked
        Me.ajuda.SetHelpString(Me.chkMedicamentos, "Marque esta opção para exibir os medicamentos.")
        Me.chkMedicamentos.Location = New System.Drawing.Point(24, 63)
        Me.chkMedicamentos.Name = "chkMedicamentos"
        Me.ajuda.SetShowHelp(Me.chkMedicamentos, True)
        Me.chkMedicamentos.Size = New System.Drawing.Size(95, 17)
        Me.chkMedicamentos.TabIndex = 2
        Me.chkMedicamentos.Text = "Medicamentos"
        Me.chkMedicamentos.UseVisualStyleBackColor = True
        '
        'ajuda
        '
        Me.ajuda.HelpNamespace = "C:\Arquivos de programas\SICEP\Ajuda\frmPoliGestaoEntradas.html"
        '
        'frmEstPoliclinica
        '
        Me.AcceptButton = Me.lkImprimir
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(563, 477)
        Me.Controls.Add(Me.chkMateriais)
        Me.Controls.Add(Me.chkMedicamentos)
        Me.Controls.Add(Me.lkImprimir)
        Me.Controls.Add(Me.lblPesquisa)
        Me.Controls.Add(Me.txtPesqValidade)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtPesqMedicamento)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.grdEstoqueSecretaria)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.HelpButton = True
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmEstPoliclinica"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Estoque Atual da Policlínica"
        CType(Me.grdEstoqueSecretaria, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents chkMateriais As System.Windows.Forms.CheckBox
    Friend WithEvents chkMedicamentos As System.Windows.Forms.CheckBox
    Friend WithEvents nome_medicamento As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cod_medicamento As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents val_medicamento As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents quant_medicamento As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ajuda As System.Windows.Forms.HelpProvider
End Class
