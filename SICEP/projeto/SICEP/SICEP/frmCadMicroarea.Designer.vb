<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCadMicroarea
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
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmCadMicroarea))
        Me.pnlFormulario = New System.Windows.Forms.Panel
        Me.lkImprimir = New System.Windows.Forms.LinkLabel
        Me.Label21 = New System.Windows.Forms.Label
        Me.lblValAgente = New System.Windows.Forms.Label
        Me.lblDataCadastramento = New System.Windows.Forms.Label
        Me.lblCodigo = New System.Windows.Forms.Label
        Me.txtObservacoes = New System.Windows.Forms.TextBox
        Me.txtAgente = New System.Windows.Forms.TextBox
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
        Me.lblPesquisando = New System.Windows.Forms.Label
        Me.grdMicroarea = New System.Windows.Forms.DataGridView
        Me.cod_microarea = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.agente_microarea = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.txtPesquisa = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.ajuda = New System.Windows.Forms.HelpProvider
        Me.pnlFormulario.SuspendLayout()
        Me.tstMenu.SuspendLayout()
        Me.pnlPesquisa.SuspendLayout()
        CType(Me.grdMicroarea, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pnlFormulario
        '
        Me.pnlFormulario.BackColor = System.Drawing.Color.Transparent
        Me.pnlFormulario.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnlFormulario.Controls.Add(Me.lkImprimir)
        Me.pnlFormulario.Controls.Add(Me.Label21)
        Me.pnlFormulario.Controls.Add(Me.lblValAgente)
        Me.pnlFormulario.Controls.Add(Me.lblDataCadastramento)
        Me.pnlFormulario.Controls.Add(Me.lblCodigo)
        Me.pnlFormulario.Controls.Add(Me.txtObservacoes)
        Me.pnlFormulario.Controls.Add(Me.txtAgente)
        Me.pnlFormulario.Controls.Add(Me.Label5)
        Me.pnlFormulario.Controls.Add(Me.Label4)
        Me.pnlFormulario.Controls.Add(Me.Label3)
        Me.pnlFormulario.Controls.Add(Me.Label2)
        Me.pnlFormulario.Controls.Add(Me.tstMenu)
        Me.pnlFormulario.Location = New System.Drawing.Point(200, 1)
        Me.pnlFormulario.Name = "pnlFormulario"
        Me.pnlFormulario.Size = New System.Drawing.Size(374, 330)
        Me.pnlFormulario.TabIndex = 3
        '
        'lkImprimir
        '
        Me.lkImprimir.AutoSize = True
        Me.ajuda.SetHelpString(Me.lkImprimir, "Clique neste link para exibir uma relação de todas as micro-área cadastradas no s" & _
                "istema em modo de impressão.")
        Me.lkImprimir.Location = New System.Drawing.Point(9, 311)
        Me.lkImprimir.Name = "lkImprimir"
        Me.ajuda.SetShowHelp(Me.lkImprimir, True)
        Me.lkImprimir.Size = New System.Drawing.Size(205, 13)
        Me.lkImprimir.TabIndex = 55
        Me.lkImprimir.TabStop = True
        Me.lkImprimir.Text = "Ver a relatório de micro-áreas cadastradas"
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
        'lblValAgente
        '
        Me.lblValAgente.AutoSize = True
        Me.lblValAgente.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblValAgente.ForeColor = System.Drawing.Color.Red
        Me.lblValAgente.Location = New System.Drawing.Point(358, 100)
        Me.lblValAgente.Name = "lblValAgente"
        Me.lblValAgente.Size = New System.Drawing.Size(12, 13)
        Me.lblValAgente.TabIndex = 31
        Me.lblValAgente.Text = "*"
        Me.lblValAgente.Visible = False
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
        'txtObservacoes
        '
        Me.ajuda.SetHelpString(Me.txtObservacoes, "Digite nesta caixa observações para futuras consultas.")
        Me.txtObservacoes.Location = New System.Drawing.Point(12, 138)
        Me.txtObservacoes.MaxLength = 2000
        Me.txtObservacoes.Multiline = True
        Me.txtObservacoes.Name = "txtObservacoes"
        Me.ajuda.SetShowHelp(Me.txtObservacoes, True)
        Me.txtObservacoes.Size = New System.Drawing.Size(345, 165)
        Me.txtObservacoes.TabIndex = 13
        '
        'txtAgente
        '
        Me.ajuda.SetHelpString(Me.txtAgente, "Digite nesta caixa o nome da agente que corresponde a micro-área cadastrada.")
        Me.txtAgente.Location = New System.Drawing.Point(12, 100)
        Me.txtAgente.MaxLength = 100
        Me.txtAgente.Name = "txtAgente"
        Me.ajuda.SetShowHelp(Me.txtAgente, True)
        Me.txtAgente.Size = New System.Drawing.Size(345, 20)
        Me.txtAgente.TabIndex = 12
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(9, 122)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(73, 13)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Observações:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(9, 84)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(44, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Agente:"
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
        Me.pnlPesquisa.Controls.Add(Me.lblPesquisando)
        Me.pnlPesquisa.Controls.Add(Me.grdMicroarea)
        Me.pnlPesquisa.Controls.Add(Me.txtPesquisa)
        Me.pnlPesquisa.Controls.Add(Me.Label1)
        Me.pnlPesquisa.Location = New System.Drawing.Point(1, 1)
        Me.pnlPesquisa.Name = "pnlPesquisa"
        Me.pnlPesquisa.Size = New System.Drawing.Size(196, 330)
        Me.pnlPesquisa.TabIndex = 2
        '
        'lblPesquisando
        '
        Me.lblPesquisando.AutoSize = True
        Me.lblPesquisando.Location = New System.Drawing.Point(3, 56)
        Me.lblPesquisando.Name = "lblPesquisando"
        Me.lblPesquisando.Size = New System.Drawing.Size(131, 13)
        Me.lblPesquisando.TabIndex = 3
        Me.lblPesquisando.Text = "Pesquisando por agente..."
        '
        'grdMicroarea
        '
        Me.grdMicroarea.AllowUserToAddRows = False
        Me.grdMicroarea.AllowUserToDeleteRows = False
        Me.grdMicroarea.AllowUserToOrderColumns = True
        Me.grdMicroarea.AllowUserToResizeColumns = False
        Me.grdMicroarea.AllowUserToResizeRows = False
        Me.grdMicroarea.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells
        Me.grdMicroarea.BackgroundColor = System.Drawing.Color.PaleTurquoise
        Me.grdMicroarea.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
        Me.grdMicroarea.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grdMicroarea.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.cod_microarea, Me.agente_microarea})
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.grdMicroarea.DefaultCellStyle = DataGridViewCellStyle2
        Me.ajuda.SetHelpString(Me.grdMicroarea, "Clique no nome da agente o no código da micro-área para carregar suas informações" & _
                " para o formulário ao lado.")
        Me.grdMicroarea.Location = New System.Drawing.Point(2, 72)
        Me.grdMicroarea.MultiSelect = False
        Me.grdMicroarea.Name = "grdMicroarea"
        Me.grdMicroarea.ReadOnly = True
        Me.grdMicroarea.RowHeadersVisible = False
        Me.grdMicroarea.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.grdMicroarea.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.ajuda.SetShowHelp(Me.grdMicroarea, True)
        Me.grdMicroarea.Size = New System.Drawing.Size(189, 253)
        Me.grdMicroarea.TabIndex = 2
        '
        'cod_microarea
        '
        Me.cod_microarea.DataPropertyName = "cod_microarea"
        Me.cod_microarea.HeaderText = "Código"
        Me.cod_microarea.Name = "cod_microarea"
        Me.cod_microarea.ReadOnly = True
        Me.cod_microarea.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.cod_microarea.Width = 65
        '
        'agente_microarea
        '
        Me.agente_microarea.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.agente_microarea.DataPropertyName = "agente_microarea"
        Me.agente_microarea.HeaderText = "Agente"
        Me.agente_microarea.Name = "agente_microarea"
        Me.agente_microarea.ReadOnly = True
        Me.agente_microarea.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.agente_microarea.ToolTipText = "Clique no nome da micro-área para exibir as informações."
        '
        'txtPesquisa
        '
        Me.ajuda.SetHelpString(Me.txtPesquisa, "Digite o nome da agente ou o código da micro-área procurada.")
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
        Me.ajuda.HelpNamespace = "C:\Arquivos de programas\SICEP\Ajuda\frmCadMicroareas.html"
        '
        'frmCadMicroarea
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(575, 332)
        Me.Controls.Add(Me.pnlFormulario)
        Me.Controls.Add(Me.pnlPesquisa)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.HelpButton = True
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmCadMicroarea"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Formulário para Cadastro de Micro-Área"
        Me.pnlFormulario.ResumeLayout(False)
        Me.pnlFormulario.PerformLayout()
        Me.tstMenu.ResumeLayout(False)
        Me.tstMenu.PerformLayout()
        Me.pnlPesquisa.ResumeLayout(False)
        Me.pnlPesquisa.PerformLayout()
        CType(Me.grdMicroarea, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents pnlFormulario As System.Windows.Forms.Panel
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents lblValAgente As System.Windows.Forms.Label
    Friend WithEvents lblDataCadastramento As System.Windows.Forms.Label
    Friend WithEvents lblCodigo As System.Windows.Forms.Label
    Friend WithEvents txtObservacoes As System.Windows.Forms.TextBox
    Friend WithEvents txtAgente As System.Windows.Forms.TextBox
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
    Friend WithEvents grdMicroarea As System.Windows.Forms.DataGridView
    Friend WithEvents txtPesquisa As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cod_microarea As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents agente_microarea As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents lblPesquisando As System.Windows.Forms.Label
    Friend WithEvents lkImprimir As System.Windows.Forms.LinkLabel
    Friend WithEvents ajuda As System.Windows.Forms.HelpProvider
End Class
