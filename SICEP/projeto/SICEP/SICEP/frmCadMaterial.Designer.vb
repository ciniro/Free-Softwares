<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCadMaterial
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmCadMaterial))
        Me.pnlFormulario = New System.Windows.Forms.Panel
        Me.lkImprimir = New System.Windows.Forms.LinkLabel
        Me.Label21 = New System.Windows.Forms.Label
        Me.lblValNome = New System.Windows.Forms.Label
        Me.lblDataCadastramento = New System.Windows.Forms.Label
        Me.lblCodigo = New System.Windows.Forms.Label
        Me.txtInfo = New System.Windows.Forms.TextBox
        Me.txtNome = New System.Windows.Forms.TextBox
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
        Me.grdMedicamento = New System.Windows.Forms.DataGridView
        Me.cod_medicamento = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.nome_medicamento = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.txtPesquisa = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.ajuda = New System.Windows.Forms.HelpProvider
        Me.pnlFormulario.SuspendLayout()
        Me.tstMenu.SuspendLayout()
        Me.pnlPesquisa.SuspendLayout()
        CType(Me.grdMedicamento, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pnlFormulario
        '
        Me.pnlFormulario.BackColor = System.Drawing.Color.Transparent
        Me.pnlFormulario.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnlFormulario.Controls.Add(Me.lkImprimir)
        Me.pnlFormulario.Controls.Add(Me.Label21)
        Me.pnlFormulario.Controls.Add(Me.lblValNome)
        Me.pnlFormulario.Controls.Add(Me.lblDataCadastramento)
        Me.pnlFormulario.Controls.Add(Me.lblCodigo)
        Me.pnlFormulario.Controls.Add(Me.txtInfo)
        Me.pnlFormulario.Controls.Add(Me.txtNome)
        Me.pnlFormulario.Controls.Add(Me.Label5)
        Me.pnlFormulario.Controls.Add(Me.Label4)
        Me.pnlFormulario.Controls.Add(Me.Label3)
        Me.pnlFormulario.Controls.Add(Me.Label2)
        Me.pnlFormulario.Controls.Add(Me.tstMenu)
        Me.pnlFormulario.Location = New System.Drawing.Point(200, 0)
        Me.pnlFormulario.Name = "pnlFormulario"
        Me.pnlFormulario.Size = New System.Drawing.Size(374, 359)
        Me.pnlFormulario.TabIndex = 7
        '
        'lkImprimir
        '
        Me.lkImprimir.AutoSize = True
        Me.ajuda.SetHelpString(Me.lkImprimir, "Clique aqui para visualizar a relação de materiais de consumo cadastrados em modo" & _
                " de impressão.")
        Me.lkImprimir.Location = New System.Drawing.Point(12, 339)
        Me.lkImprimir.Name = "lkImprimir"
        Me.ajuda.SetShowHelp(Me.lkImprimir, True)
        Me.lkImprimir.Size = New System.Drawing.Size(287, 13)
        Me.lkImprimir.TabIndex = 58
        Me.lkImprimir.TabStop = True
        Me.lkImprimir.Text = "Ver relatório de todos os materiais de consumo cadastrados"
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label21.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.Label21.Location = New System.Drawing.Point(9, 33)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(80, 13)
        Me.Label21.TabIndex = 54
        Me.Label21.Text = "Informações:"
        '
        'lblValNome
        '
        Me.lblValNome.AutoSize = True
        Me.lblValNome.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblValNome.ForeColor = System.Drawing.Color.Red
        Me.lblValNome.Location = New System.Drawing.Point(358, 91)
        Me.lblValNome.Name = "lblValNome"
        Me.lblValNome.Size = New System.Drawing.Size(12, 13)
        Me.lblValNome.TabIndex = 31
        Me.lblValNome.Text = "*"
        Me.lblValNome.Visible = False
        '
        'lblDataCadastramento
        '
        Me.lblDataCadastramento.AutoSize = True
        Me.lblDataCadastramento.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDataCadastramento.Location = New System.Drawing.Point(239, 54)
        Me.lblDataCadastramento.Name = "lblDataCadastramento"
        Me.lblDataCadastramento.Size = New System.Drawing.Size(0, 13)
        Me.lblDataCadastramento.TabIndex = 23
        '
        'lblCodigo
        '
        Me.lblCodigo.AutoSize = True
        Me.lblCodigo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCodigo.Location = New System.Drawing.Point(71, 54)
        Me.lblCodigo.Name = "lblCodigo"
        Me.lblCodigo.Size = New System.Drawing.Size(0, 13)
        Me.lblCodigo.TabIndex = 22
        '
        'txtInfo
        '
        Me.ajuda.SetHelpString(Me.txtInfo, "Estabeleça nesta caixa informações adicionais para futuras referências.")
        Me.txtInfo.Location = New System.Drawing.Point(12, 130)
        Me.txtInfo.MaxLength = 2000
        Me.txtInfo.Multiline = True
        Me.txtInfo.Name = "txtInfo"
        Me.ajuda.SetShowHelp(Me.txtInfo, True)
        Me.txtInfo.Size = New System.Drawing.Size(345, 204)
        Me.txtInfo.TabIndex = 14
        '
        'txtNome
        '
        Me.ajuda.SetHelpString(Me.txtNome, "Digite aqui o nome do material de consumo.")
        Me.txtNome.Location = New System.Drawing.Point(12, 91)
        Me.txtNome.MaxLength = 100
        Me.txtNome.Name = "txtNome"
        Me.ajuda.SetShowHelp(Me.txtNome, True)
        Me.txtNome.Size = New System.Drawing.Size(345, 20)
        Me.txtNome.TabIndex = 12
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(9, 114)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(119, 13)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Informações Adicionais:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(9, 75)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(38, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Nome:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(105, 54)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(122, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Data do Cadastramento:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(9, 54)
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
        Me.tstMenu.Size = New System.Drawing.Size(372, 30)
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
        'pnlPesquisa
        '
        Me.pnlPesquisa.BackColor = System.Drawing.Color.Transparent
        Me.pnlPesquisa.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnlPesquisa.Controls.Add(Me.grdMedicamento)
        Me.pnlPesquisa.Controls.Add(Me.txtPesquisa)
        Me.pnlPesquisa.Controls.Add(Me.Label1)
        Me.pnlPesquisa.Location = New System.Drawing.Point(1, 0)
        Me.pnlPesquisa.Name = "pnlPesquisa"
        Me.pnlPesquisa.Size = New System.Drawing.Size(196, 359)
        Me.pnlPesquisa.TabIndex = 6
        '
        'grdMedicamento
        '
        Me.grdMedicamento.AllowUserToAddRows = False
        Me.grdMedicamento.AllowUserToDeleteRows = False
        Me.grdMedicamento.AllowUserToOrderColumns = True
        Me.grdMedicamento.AllowUserToResizeColumns = False
        Me.grdMedicamento.AllowUserToResizeRows = False
        Me.grdMedicamento.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells
        Me.grdMedicamento.BackgroundColor = System.Drawing.Color.PaleTurquoise
        Me.grdMedicamento.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
        Me.grdMedicamento.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grdMedicamento.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.cod_medicamento, Me.nome_medicamento})
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.grdMedicamento.DefaultCellStyle = DataGridViewCellStyle1
        Me.ajuda.SetHelpString(Me.grdMedicamento, "Clique sobre o nome do item procurado para carrega-lo para o formulário ao lado.")
        Me.grdMedicamento.Location = New System.Drawing.Point(3, 54)
        Me.grdMedicamento.MultiSelect = False
        Me.grdMedicamento.Name = "grdMedicamento"
        Me.grdMedicamento.ReadOnly = True
        Me.grdMedicamento.RowHeadersVisible = False
        Me.grdMedicamento.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.grdMedicamento.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.ajuda.SetShowHelp(Me.grdMedicamento, True)
        Me.grdMedicamento.Size = New System.Drawing.Size(189, 300)
        Me.grdMedicamento.TabIndex = 2
        '
        'cod_medicamento
        '
        Me.cod_medicamento.DataPropertyName = "cod_medicamento"
        Me.cod_medicamento.HeaderText = "Código"
        Me.cod_medicamento.Name = "cod_medicamento"
        Me.cod_medicamento.ReadOnly = True
        Me.cod_medicamento.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.cod_medicamento.Visible = False
        Me.cod_medicamento.Width = 46
        '
        'nome_medicamento
        '
        Me.nome_medicamento.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.nome_medicamento.DataPropertyName = "nome_medicamento"
        Me.nome_medicamento.HeaderText = "Material de Consumo"
        Me.nome_medicamento.Name = "nome_medicamento"
        Me.nome_medicamento.ReadOnly = True
        Me.nome_medicamento.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.nome_medicamento.ToolTipText = "Clique no nome do material para exibir as informações."
        '
        'txtPesquisa
        '
        Me.ajuda.SetHelpString(Me.txtPesquisa, "Digite nesta caixa o nome do material de consumo procurado, e observe que os iten" & _
                "s mais parecidos com o digitado serão carregados.")
        Me.txtPesquisa.Location = New System.Drawing.Point(2, 33)
        Me.txtPesquisa.MaxLength = 100
        Me.txtPesquisa.Name = "txtPesquisa"
        Me.ajuda.SetShowHelp(Me.txtPesquisa, True)
        Me.txtPesquisa.Size = New System.Drawing.Size(190, 20)
        Me.txtPesquisa.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.PaleTurquoise
        Me.Label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label1.Location = New System.Drawing.Point(0, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(194, 30)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "PESQUISAR"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'ajuda
        '
        Me.ajuda.HelpNamespace = "C:\Arquivos de programas\SICEP\Ajuda\frmCadMateriais.html"
        '
        'frmCadMaterial
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(577, 362)
        Me.Controls.Add(Me.pnlFormulario)
        Me.Controls.Add(Me.pnlPesquisa)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.HelpButton = True
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmCadMaterial"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Cadastro de Material de Consumo"
        Me.pnlFormulario.ResumeLayout(False)
        Me.pnlFormulario.PerformLayout()
        Me.tstMenu.ResumeLayout(False)
        Me.tstMenu.PerformLayout()
        Me.pnlPesquisa.ResumeLayout(False)
        Me.pnlPesquisa.PerformLayout()
        CType(Me.grdMedicamento, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents pnlFormulario As System.Windows.Forms.Panel
    Friend WithEvents lkImprimir As System.Windows.Forms.LinkLabel
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents lblValNome As System.Windows.Forms.Label
    Friend WithEvents lblDataCadastramento As System.Windows.Forms.Label
    Friend WithEvents lblCodigo As System.Windows.Forms.Label
    Friend WithEvents txtInfo As System.Windows.Forms.TextBox
    Friend WithEvents txtNome As System.Windows.Forms.TextBox
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
    Friend WithEvents grdMedicamento As System.Windows.Forms.DataGridView
    Friend WithEvents txtPesquisa As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cod_medicamento As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents nome_medicamento As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ajuda As System.Windows.Forms.HelpProvider
End Class
