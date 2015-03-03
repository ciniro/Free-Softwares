<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPrincipal
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmPrincipal))
        Me.mnuPrincipal = New System.Windows.Forms.MenuStrip
        Me.mnuArquivo = New System.Windows.Forms.ToolStripMenuItem
        Me.mnuFerramentas = New System.Windows.Forms.ToolStripMenuItem
        Me.mnuCalculadora = New System.Windows.Forms.ToolStripMenuItem
        Me.mnuBlocoDeNotas = New System.Windows.Forms.ToolStripMenuItem
        Me.mnuCalendario = New System.Windows.Forms.ToolStripMenuItem
        Me.mnuBackup = New System.Windows.Forms.ToolStripMenuItem
        Me.mnuLogout = New System.Windows.Forms.ToolStripMenuItem
        Me.mnuSair = New System.Windows.Forms.ToolStripMenuItem
        Me.mnuCadastros = New System.Windows.Forms.ToolStripMenuItem
        Me.mnuCadastroDePaciente = New System.Windows.Forms.ToolStripMenuItem
        Me.mnuCadastroDeMedicamentos = New System.Windows.Forms.ToolStripMenuItem
        Me.mnuCadMaterial = New System.Windows.Forms.ToolStripMenuItem
        Me.mnuCadastroDeUsuario = New System.Windows.Forms.ToolStripMenuItem
        Me.mnuCadastroDeMicroarea = New System.Windows.Forms.ToolStripMenuItem
        Me.mnuEstoqueDaSecretaria = New System.Windows.Forms.ToolStripMenuItem
        Me.mnuOperarEntradasDaSecretaria = New System.Windows.Forms.ToolStripMenuItem
        Me.mnuOperarSaídasDaSecretaria = New System.Windows.Forms.ToolStripMenuItem
        Me.mnuEstoqueDaPoliclinica = New System.Windows.Forms.ToolStripMenuItem
        Me.mnuOperarEntradasDaPoliclinica = New System.Windows.Forms.ToolStripMenuItem
        Me.mnuOperarSaidasDaPoliclinica = New System.Windows.Forms.ToolStripMenuItem
        Me.mnuRelatorios = New System.Windows.Forms.ToolStripMenuItem
        Me.mnuRelEstoqueDaSecretaria = New System.Windows.Forms.ToolStripMenuItem
        Me.mnuRelEntradasNaSecretaria = New System.Windows.Forms.ToolStripMenuItem
        Me.mnuRelSaidasNaSecretaria = New System.Windows.Forms.ToolStripMenuItem
        Me.mnuRelQuantidadeNaSecretaria = New System.Windows.Forms.ToolStripMenuItem
        Me.mnuRelEstoqueDaPoliclinica = New System.Windows.Forms.ToolStripMenuItem
        Me.mnuRelEntradasNaPoliclinica = New System.Windows.Forms.ToolStripMenuItem
        Me.mnuRelSaidasNaPoliclinica = New System.Windows.Forms.ToolStripMenuItem
        Me.mnuRelQuantidadeNaPoliclinica = New System.Windows.Forms.ToolStripMenuItem
        Me.mnuRelRelatoriosDeCadastros = New System.Windows.Forms.ToolStripMenuItem
        Me.mnuRelRelacaoDePacientes = New System.Windows.Forms.ToolStripMenuItem
        Me.mnuRelRelacaoDeMedicamentos = New System.Windows.Forms.ToolStripMenuItem
        Me.mnuRelMateriaisDeConsumo = New System.Windows.Forms.ToolStripMenuItem
        Me.mnuRelRelacaoDeUsuarios = New System.Windows.Forms.ToolStripMenuItem
        Me.mnuRelRelacaoDeMicroareas = New System.Windows.Forms.ToolStripMenuItem
        Me.mnuAjuda = New System.Windows.Forms.ToolStripMenuItem
        Me.mnuAjudaDoSICEP10 = New System.Windows.Forms.ToolStripMenuItem
        Me.mnuSobre = New System.Windows.Forms.ToolStripMenuItem
        Me.Label1 = New System.Windows.Forms.Label
        Me.lblBemVindo = New System.Windows.Forms.Label
        Me.lblPerfil = New System.Windows.Forms.Label
        Me.flpFlowPainel = New System.Windows.Forms.FlowLayoutPanel
        Me.cmdCadastroDePaciente = New System.Windows.Forms.Button
        Me.cmdCadastroDeMedicamento = New System.Windows.Forms.Button
        Me.cmdCadastroDeUsuario = New System.Windows.Forms.Button
        Me.cmdCadastroDeMicroarea = New System.Windows.Forms.Button
        Me.cmdCadMaterial = New System.Windows.Forms.Button
        Me.cmdRelSecretaria = New System.Windows.Forms.Button
        Me.cmdEntSecretaria = New System.Windows.Forms.Button
        Me.cmdSaiSecretaria = New System.Windows.Forms.Button
        Me.cmdRelPoliclinica = New System.Windows.Forms.Button
        Me.cmdEntPoliclinica = New System.Windows.Forms.Button
        Me.cmdSaiPoliclinica = New System.Windows.Forms.Button
        Me.cmdAjuda = New System.Windows.Forms.Button
        Me.ttInformacao = New System.Windows.Forms.ToolTip(Me.components)
        Me.mnuPrincipal.SuspendLayout()
        Me.flpFlowPainel.SuspendLayout()
        Me.SuspendLayout()
        '
        'mnuPrincipal
        '
        Me.mnuPrincipal.BackColor = System.Drawing.SystemColors.Info
        Me.mnuPrincipal.ImageScalingSize = New System.Drawing.Size(25, 25)
        Me.mnuPrincipal.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuArquivo, Me.mnuCadastros, Me.mnuEstoqueDaSecretaria, Me.mnuEstoqueDaPoliclinica, Me.mnuRelatorios, Me.mnuAjuda})
        Me.mnuPrincipal.Location = New System.Drawing.Point(0, 0)
        Me.mnuPrincipal.Name = "mnuPrincipal"
        Me.mnuPrincipal.RenderMode = System.Windows.Forms.ToolStripRenderMode.System
        Me.mnuPrincipal.Size = New System.Drawing.Size(803, 38)
        Me.mnuPrincipal.Stretch = False
        Me.mnuPrincipal.TabIndex = 0
        Me.mnuPrincipal.Text = "Menu Principal"
        '
        'mnuArquivo
        '
        Me.mnuArquivo.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuFerramentas, Me.mnuBackup, Me.mnuLogout, Me.mnuSair})
        Me.mnuArquivo.Image = Global.SICEP.My.Resources.Resources.arquivo
        Me.mnuArquivo.Name = "mnuArquivo"
        Me.mnuArquivo.Size = New System.Drawing.Size(86, 34)
        Me.mnuArquivo.Text = "&Arquivo"
        '
        'mnuFerramentas
        '
        Me.mnuFerramentas.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuCalculadora, Me.mnuBlocoDeNotas, Me.mnuCalendario})
        Me.mnuFerramentas.Image = Global.SICEP.My.Resources.Resources.ferramentas
        Me.mnuFerramentas.Name = "mnuFerramentas"
        Me.mnuFerramentas.Size = New System.Drawing.Size(146, 22)
        Me.mnuFerramentas.Text = "Ferramentas"
        '
        'mnuCalculadora
        '
        Me.mnuCalculadora.Image = Global.SICEP.My.Resources.Resources.calculadora
        Me.mnuCalculadora.Name = "mnuCalculadora"
        Me.mnuCalculadora.Size = New System.Drawing.Size(156, 22)
        Me.mnuCalculadora.Text = "Calculadora"
        '
        'mnuBlocoDeNotas
        '
        Me.mnuBlocoDeNotas.Image = Global.SICEP.My.Resources.Resources.blocodenotas
        Me.mnuBlocoDeNotas.Name = "mnuBlocoDeNotas"
        Me.mnuBlocoDeNotas.Size = New System.Drawing.Size(156, 22)
        Me.mnuBlocoDeNotas.Text = "Bloco de Notas"
        '
        'mnuCalendario
        '
        Me.mnuCalendario.Image = Global.SICEP.My.Resources.Resources.calendario
        Me.mnuCalendario.Name = "mnuCalendario"
        Me.mnuCalendario.Size = New System.Drawing.Size(156, 22)
        Me.mnuCalendario.Text = "Calendário"
        '
        'mnuBackup
        '
        Me.mnuBackup.Image = Global.SICEP.My.Resources.Resources.backup
        Me.mnuBackup.Name = "mnuBackup"
        Me.mnuBackup.Size = New System.Drawing.Size(146, 22)
        Me.mnuBackup.Text = "Backup"
        '
        'mnuLogout
        '
        Me.mnuLogout.Image = Global.SICEP.My.Resources.Resources.logoff
        Me.mnuLogout.Name = "mnuLogout"
        Me.mnuLogout.Size = New System.Drawing.Size(146, 22)
        Me.mnuLogout.Text = "&Logout"
        '
        'mnuSair
        '
        Me.mnuSair.Image = Global.SICEP.My.Resources.Resources.sair
        Me.mnuSair.Name = "mnuSair"
        Me.mnuSair.Size = New System.Drawing.Size(146, 22)
        Me.mnuSair.Text = "&Fechar"
        '
        'mnuCadastros
        '
        Me.mnuCadastros.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuCadastroDePaciente, Me.mnuCadastroDeMedicamentos, Me.mnuCadMaterial, Me.mnuCadastroDeUsuario, Me.mnuCadastroDeMicroarea})
        Me.mnuCadastros.Image = Global.SICEP.My.Resources.Resources.cadastros1
        Me.mnuCadastros.Name = "mnuCadastros"
        Me.mnuCadastros.Size = New System.Drawing.Size(98, 34)
        Me.mnuCadastros.Text = "&Cadastros"
        '
        'mnuCadastroDePaciente
        '
        Me.mnuCadastroDePaciente.Image = Global.SICEP.My.Resources.Resources.pac
        Me.mnuCadastroDePaciente.Name = "mnuCadastroDePaciente"
        Me.mnuCadastroDePaciente.Size = New System.Drawing.Size(247, 22)
        Me.mnuCadastroDePaciente.Text = "Cadastro de Paciente"
        '
        'mnuCadastroDeMedicamentos
        '
        Me.mnuCadastroDeMedicamentos.Image = Global.SICEP.My.Resources.Resources.med
        Me.mnuCadastroDeMedicamentos.Name = "mnuCadastroDeMedicamentos"
        Me.mnuCadastroDeMedicamentos.Size = New System.Drawing.Size(247, 22)
        Me.mnuCadastroDeMedicamentos.Text = "Cadastro de Medicamentos"
        '
        'mnuCadMaterial
        '
        Me.mnuCadMaterial.Image = Global.SICEP.My.Resources.Resources.material
        Me.mnuCadMaterial.Name = "mnuCadMaterial"
        Me.mnuCadMaterial.Size = New System.Drawing.Size(247, 22)
        Me.mnuCadMaterial.Text = "Cadastro de Material de Consumo"
        '
        'mnuCadastroDeUsuario
        '
        Me.mnuCadastroDeUsuario.Image = Global.SICEP.My.Resources.Resources.usu
        Me.mnuCadastroDeUsuario.Name = "mnuCadastroDeUsuario"
        Me.mnuCadastroDeUsuario.Size = New System.Drawing.Size(247, 22)
        Me.mnuCadastroDeUsuario.Text = "Cadastro de Usuário"
        '
        'mnuCadastroDeMicroarea
        '
        Me.mnuCadastroDeMicroarea.Image = Global.SICEP.My.Resources.Resources.micro
        Me.mnuCadastroDeMicroarea.Name = "mnuCadastroDeMicroarea"
        Me.mnuCadastroDeMicroarea.Size = New System.Drawing.Size(247, 22)
        Me.mnuCadastroDeMicroarea.Text = "Cadastro de Micro-Área"
        '
        'mnuEstoqueDaSecretaria
        '
        Me.mnuEstoqueDaSecretaria.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuOperarEntradasDaSecretaria, Me.mnuOperarSaídasDaSecretaria})
        Me.mnuEstoqueDaSecretaria.Image = Global.SICEP.My.Resources.Resources.EstoqueSec
        Me.mnuEstoqueDaSecretaria.Name = "mnuEstoqueDaSecretaria"
        Me.mnuEstoqueDaSecretaria.Size = New System.Drawing.Size(155, 34)
        Me.mnuEstoqueDaSecretaria.Text = "Estoque da &Secretaria"
        '
        'mnuOperarEntradasDaSecretaria
        '
        Me.mnuOperarEntradasDaSecretaria.Image = Global.SICEP.My.Resources.Resources.saiSecretaria
        Me.mnuOperarEntradasDaSecretaria.Name = "mnuOperarEntradasDaSecretaria"
        Me.mnuOperarEntradasDaSecretaria.Size = New System.Drawing.Size(232, 22)
        Me.mnuOperarEntradasDaSecretaria.Text = "Operar entradas da Secretaria"
        '
        'mnuOperarSaídasDaSecretaria
        '
        Me.mnuOperarSaídasDaSecretaria.Image = Global.SICEP.My.Resources.Resources.entSecretaria
        Me.mnuOperarSaídasDaSecretaria.Name = "mnuOperarSaídasDaSecretaria"
        Me.mnuOperarSaídasDaSecretaria.Size = New System.Drawing.Size(232, 22)
        Me.mnuOperarSaídasDaSecretaria.Text = "Operar saídas da Secretaria"
        '
        'mnuEstoqueDaPoliclinica
        '
        Me.mnuEstoqueDaPoliclinica.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuOperarEntradasDaPoliclinica, Me.mnuOperarSaidasDaPoliclinica})
        Me.mnuEstoqueDaPoliclinica.Image = Global.SICEP.My.Resources.Resources.EstoquePoli
        Me.mnuEstoqueDaPoliclinica.Name = "mnuEstoqueDaPoliclinica"
        Me.mnuEstoqueDaPoliclinica.Size = New System.Drawing.Size(150, 34)
        Me.mnuEstoqueDaPoliclinica.Text = "Estoque da &Policlínica"
        '
        'mnuOperarEntradasDaPoliclinica
        '
        Me.mnuOperarEntradasDaPoliclinica.Image = Global.SICEP.My.Resources.Resources.saiPoliclinica
        Me.mnuOperarEntradasDaPoliclinica.Name = "mnuOperarEntradasDaPoliclinica"
        Me.mnuOperarEntradasDaPoliclinica.Size = New System.Drawing.Size(227, 22)
        Me.mnuOperarEntradasDaPoliclinica.Text = "Operar entradas da Policlínica"
        '
        'mnuOperarSaidasDaPoliclinica
        '
        Me.mnuOperarSaidasDaPoliclinica.Image = Global.SICEP.My.Resources.Resources.entPoliclinica
        Me.mnuOperarSaidasDaPoliclinica.Name = "mnuOperarSaidasDaPoliclinica"
        Me.mnuOperarSaidasDaPoliclinica.Size = New System.Drawing.Size(227, 22)
        Me.mnuOperarSaidasDaPoliclinica.Text = "Operar saídas da Policlínica"
        '
        'mnuRelatorios
        '
        Me.mnuRelatorios.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuRelEstoqueDaSecretaria, Me.mnuRelEstoqueDaPoliclinica, Me.mnuRelRelatoriosDeCadastros})
        Me.mnuRelatorios.Image = Global.SICEP.My.Resources.Resources.rel
        Me.mnuRelatorios.Name = "mnuRelatorios"
        Me.mnuRelatorios.Size = New System.Drawing.Size(97, 34)
        Me.mnuRelatorios.Text = "&Relatórios"
        '
        'mnuRelEstoqueDaSecretaria
        '
        Me.mnuRelEstoqueDaSecretaria.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuRelEntradasNaSecretaria, Me.mnuRelSaidasNaSecretaria, Me.mnuRelQuantidadeNaSecretaria})
        Me.mnuRelEstoqueDaSecretaria.Image = Global.SICEP.My.Resources.Resources.relSecretaria
        Me.mnuRelEstoqueDaSecretaria.Name = "mnuRelEstoqueDaSecretaria"
        Me.mnuRelEstoqueDaSecretaria.Size = New System.Drawing.Size(200, 22)
        Me.mnuRelEstoqueDaSecretaria.Text = "Estoque da Secretaria"
        '
        'mnuRelEntradasNaSecretaria
        '
        Me.mnuRelEntradasNaSecretaria.Image = Global.SICEP.My.Resources.Resources.entra
        Me.mnuRelEntradasNaSecretaria.Name = "mnuRelEntradasNaSecretaria"
        Me.mnuRelEntradasNaSecretaria.Size = New System.Drawing.Size(208, 22)
        Me.mnuRelEntradasNaSecretaria.Text = "Entradas na Secretaria"
        '
        'mnuRelSaidasNaSecretaria
        '
        Me.mnuRelSaidasNaSecretaria.Image = Global.SICEP.My.Resources.Resources.sai
        Me.mnuRelSaidasNaSecretaria.Name = "mnuRelSaidasNaSecretaria"
        Me.mnuRelSaidasNaSecretaria.Size = New System.Drawing.Size(208, 22)
        Me.mnuRelSaidasNaSecretaria.Text = "Saídas na Secretaria"
        '
        'mnuRelQuantidadeNaSecretaria
        '
        Me.mnuRelQuantidadeNaSecretaria.Image = Global.SICEP.My.Resources.Resources.quantidade
        Me.mnuRelQuantidadeNaSecretaria.Name = "mnuRelQuantidadeNaSecretaria"
        Me.mnuRelQuantidadeNaSecretaria.Size = New System.Drawing.Size(208, 22)
        Me.mnuRelQuantidadeNaSecretaria.Text = "Quantidade na Secretaria"
        '
        'mnuRelEstoqueDaPoliclinica
        '
        Me.mnuRelEstoqueDaPoliclinica.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuRelEntradasNaPoliclinica, Me.mnuRelSaidasNaPoliclinica, Me.mnuRelQuantidadeNaPoliclinica})
        Me.mnuRelEstoqueDaPoliclinica.Image = Global.SICEP.My.Resources.Resources.relPoliclinica
        Me.mnuRelEstoqueDaPoliclinica.Name = "mnuRelEstoqueDaPoliclinica"
        Me.mnuRelEstoqueDaPoliclinica.Size = New System.Drawing.Size(200, 22)
        Me.mnuRelEstoqueDaPoliclinica.Text = "Estoque da Policlínica"
        '
        'mnuRelEntradasNaPoliclinica
        '
        Me.mnuRelEntradasNaPoliclinica.Image = Global.SICEP.My.Resources.Resources.entra
        Me.mnuRelEntradasNaPoliclinica.Name = "mnuRelEntradasNaPoliclinica"
        Me.mnuRelEntradasNaPoliclinica.Size = New System.Drawing.Size(203, 22)
        Me.mnuRelEntradasNaPoliclinica.Text = "Entradas na Policlínica"
        '
        'mnuRelSaidasNaPoliclinica
        '
        Me.mnuRelSaidasNaPoliclinica.Image = Global.SICEP.My.Resources.Resources.sai
        Me.mnuRelSaidasNaPoliclinica.Name = "mnuRelSaidasNaPoliclinica"
        Me.mnuRelSaidasNaPoliclinica.Size = New System.Drawing.Size(203, 22)
        Me.mnuRelSaidasNaPoliclinica.Text = "Saídas na Policlínica"
        '
        'mnuRelQuantidadeNaPoliclinica
        '
        Me.mnuRelQuantidadeNaPoliclinica.Image = Global.SICEP.My.Resources.Resources.quantidade
        Me.mnuRelQuantidadeNaPoliclinica.Name = "mnuRelQuantidadeNaPoliclinica"
        Me.mnuRelQuantidadeNaPoliclinica.Size = New System.Drawing.Size(203, 22)
        Me.mnuRelQuantidadeNaPoliclinica.Text = "Quantidade na Policlínica"
        '
        'mnuRelRelatoriosDeCadastros
        '
        Me.mnuRelRelatoriosDeCadastros.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuRelRelacaoDePacientes, Me.mnuRelRelacaoDeMedicamentos, Me.mnuRelMateriaisDeConsumo, Me.mnuRelRelacaoDeUsuarios, Me.mnuRelRelacaoDeMicroareas})
        Me.mnuRelRelatoriosDeCadastros.Image = Global.SICEP.My.Resources.Resources.relCadastros
        Me.mnuRelRelatoriosDeCadastros.Name = "mnuRelRelatoriosDeCadastros"
        Me.mnuRelRelatoriosDeCadastros.Size = New System.Drawing.Size(200, 22)
        Me.mnuRelRelatoriosDeCadastros.Text = "Relatórios de Cadastros"
        '
        'mnuRelRelacaoDePacientes
        '
        Me.mnuRelRelacaoDePacientes.Image = Global.SICEP.My.Resources.Resources.pac
        Me.mnuRelRelacaoDePacientes.Name = "mnuRelRelacaoDePacientes"
        Me.mnuRelRelacaoDePacientes.Size = New System.Drawing.Size(246, 22)
        Me.mnuRelRelacaoDePacientes.Text = "Relação de Pacientes"
        '
        'mnuRelRelacaoDeMedicamentos
        '
        Me.mnuRelRelacaoDeMedicamentos.Image = Global.SICEP.My.Resources.Resources.med
        Me.mnuRelRelacaoDeMedicamentos.Name = "mnuRelRelacaoDeMedicamentos"
        Me.mnuRelRelacaoDeMedicamentos.Size = New System.Drawing.Size(246, 22)
        Me.mnuRelRelacaoDeMedicamentos.Text = "Relação de Medicamentos"
        '
        'mnuRelMateriaisDeConsumo
        '
        Me.mnuRelMateriaisDeConsumo.Image = Global.SICEP.My.Resources.Resources.material
        Me.mnuRelMateriaisDeConsumo.Name = "mnuRelMateriaisDeConsumo"
        Me.mnuRelMateriaisDeConsumo.Size = New System.Drawing.Size(246, 22)
        Me.mnuRelMateriaisDeConsumo.Text = "Relação de Materiais de Consumo"
        '
        'mnuRelRelacaoDeUsuarios
        '
        Me.mnuRelRelacaoDeUsuarios.Image = Global.SICEP.My.Resources.Resources.usu
        Me.mnuRelRelacaoDeUsuarios.Name = "mnuRelRelacaoDeUsuarios"
        Me.mnuRelRelacaoDeUsuarios.Size = New System.Drawing.Size(246, 22)
        Me.mnuRelRelacaoDeUsuarios.Text = "Relação de Usuários"
        '
        'mnuRelRelacaoDeMicroareas
        '
        Me.mnuRelRelacaoDeMicroareas.Image = Global.SICEP.My.Resources.Resources.micro
        Me.mnuRelRelacaoDeMicroareas.Name = "mnuRelRelacaoDeMicroareas"
        Me.mnuRelRelacaoDeMicroareas.Size = New System.Drawing.Size(246, 22)
        Me.mnuRelRelacaoDeMicroareas.Text = "Relação de Micro-Áreas"
        '
        'mnuAjuda
        '
        Me.mnuAjuda.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuAjudaDoSICEP10, Me.mnuSobre})
        Me.mnuAjuda.Image = Global.SICEP.My.Resources.Resources.ajuda
        Me.mnuAjuda.Name = "mnuAjuda"
        Me.mnuAjuda.Size = New System.Drawing.Size(77, 34)
        Me.mnuAjuda.Text = "&Ajuda"
        '
        'mnuAjudaDoSICEP10
        '
        Me.mnuAjudaDoSICEP10.Image = Global.SICEP.My.Resources.Resources.ajudaSICEP
        Me.mnuAjudaDoSICEP10.Name = "mnuAjudaDoSICEP10"
        Me.mnuAjudaDoSICEP10.Size = New System.Drawing.Size(179, 22)
        Me.mnuAjudaDoSICEP10.Text = "Ajuda do SICEP 1.0"
        '
        'mnuSobre
        '
        Me.mnuSobre.Image = Global.SICEP.My.Resources.Resources.sobre
        Me.mnuSobre.Name = "mnuSobre"
        Me.mnuSobre.Size = New System.Drawing.Size(179, 22)
        Me.mnuSobre.Text = "Sobre"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 41)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(41, 16)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Perfil:"
        '
        'lblBemVindo
        '
        Me.lblBemVindo.AutoSize = True
        Me.lblBemVindo.BackColor = System.Drawing.Color.Transparent
        Me.lblBemVindo.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBemVindo.Location = New System.Drawing.Point(11, 64)
        Me.lblBemVindo.Name = "lblBemVindo"
        Me.lblBemVindo.Size = New System.Drawing.Size(139, 24)
        Me.lblBemVindo.TabIndex = 2
        Me.lblBemVindo.Text = "Não Informado!"
        '
        'lblPerfil
        '
        Me.lblPerfil.AutoSize = True
        Me.lblPerfil.BackColor = System.Drawing.Color.Transparent
        Me.lblPerfil.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPerfil.Location = New System.Drawing.Point(47, 41)
        Me.lblPerfil.Name = "lblPerfil"
        Me.lblPerfil.Size = New System.Drawing.Size(100, 16)
        Me.lblPerfil.TabIndex = 3
        Me.lblPerfil.Text = "Não Informado!"
        '
        'flpFlowPainel
        '
        Me.flpFlowPainel.AutoScroll = True
        Me.flpFlowPainel.AutoScrollMargin = New System.Drawing.Size(5, 5)
        Me.flpFlowPainel.AutoScrollMinSize = New System.Drawing.Size(5, 5)
        Me.flpFlowPainel.BackColor = System.Drawing.Color.Transparent
        Me.flpFlowPainel.Controls.Add(Me.cmdCadastroDePaciente)
        Me.flpFlowPainel.Controls.Add(Me.cmdCadastroDeMedicamento)
        Me.flpFlowPainel.Controls.Add(Me.cmdCadastroDeUsuario)
        Me.flpFlowPainel.Controls.Add(Me.cmdCadastroDeMicroarea)
        Me.flpFlowPainel.Controls.Add(Me.cmdCadMaterial)
        Me.flpFlowPainel.Controls.Add(Me.cmdRelSecretaria)
        Me.flpFlowPainel.Controls.Add(Me.cmdEntSecretaria)
        Me.flpFlowPainel.Controls.Add(Me.cmdSaiSecretaria)
        Me.flpFlowPainel.Controls.Add(Me.cmdRelPoliclinica)
        Me.flpFlowPainel.Controls.Add(Me.cmdEntPoliclinica)
        Me.flpFlowPainel.Controls.Add(Me.cmdSaiPoliclinica)
        Me.flpFlowPainel.Controls.Add(Me.cmdAjuda)
        Me.flpFlowPainel.Location = New System.Drawing.Point(15, 151)
        Me.flpFlowPainel.Margin = New System.Windows.Forms.Padding(15)
        Me.flpFlowPainel.Name = "flpFlowPainel"
        Me.flpFlowPainel.Size = New System.Drawing.Size(347, 267)
        Me.flpFlowPainel.TabIndex = 18
        '
        'cmdCadastroDePaciente
        '
        Me.cmdCadastroDePaciente.BackColor = System.Drawing.Color.White
        Me.cmdCadastroDePaciente.Image = Global.SICEP.My.Resources.Resources.pac
        Me.cmdCadastroDePaciente.ImageAlign = System.Drawing.ContentAlignment.BottomLeft
        Me.cmdCadastroDePaciente.Location = New System.Drawing.Point(3, 3)
        Me.cmdCadastroDePaciente.Name = "cmdCadastroDePaciente"
        Me.cmdCadastroDePaciente.Size = New System.Drawing.Size(77, 70)
        Me.cmdCadastroDePaciente.TabIndex = 16
        Me.ttInformacao.SetToolTip(Me.cmdCadastroDePaciente, "Cadastro de Pacientes")
        Me.cmdCadastroDePaciente.UseVisualStyleBackColor = False
        '
        'cmdCadastroDeMedicamento
        '
        Me.cmdCadastroDeMedicamento.BackColor = System.Drawing.Color.White
        Me.cmdCadastroDeMedicamento.Image = Global.SICEP.My.Resources.Resources.med
        Me.cmdCadastroDeMedicamento.Location = New System.Drawing.Point(86, 3)
        Me.cmdCadastroDeMedicamento.Name = "cmdCadastroDeMedicamento"
        Me.cmdCadastroDeMedicamento.Size = New System.Drawing.Size(77, 70)
        Me.cmdCadastroDeMedicamento.TabIndex = 17
        Me.ttInformacao.SetToolTip(Me.cmdCadastroDeMedicamento, "Cadastro de Medicamentos")
        Me.cmdCadastroDeMedicamento.UseVisualStyleBackColor = False
        '
        'cmdCadastroDeUsuario
        '
        Me.cmdCadastroDeUsuario.BackColor = System.Drawing.Color.White
        Me.cmdCadastroDeUsuario.Image = Global.SICEP.My.Resources.Resources.usu
        Me.cmdCadastroDeUsuario.Location = New System.Drawing.Point(169, 3)
        Me.cmdCadastroDeUsuario.Name = "cmdCadastroDeUsuario"
        Me.cmdCadastroDeUsuario.Size = New System.Drawing.Size(77, 70)
        Me.cmdCadastroDeUsuario.TabIndex = 18
        Me.ttInformacao.SetToolTip(Me.cmdCadastroDeUsuario, "Cadastro de Usuários")
        Me.cmdCadastroDeUsuario.UseVisualStyleBackColor = False
        '
        'cmdCadastroDeMicroarea
        '
        Me.cmdCadastroDeMicroarea.BackColor = System.Drawing.Color.White
        Me.cmdCadastroDeMicroarea.Image = Global.SICEP.My.Resources.Resources.micro
        Me.cmdCadastroDeMicroarea.Location = New System.Drawing.Point(252, 3)
        Me.cmdCadastroDeMicroarea.Name = "cmdCadastroDeMicroarea"
        Me.cmdCadastroDeMicroarea.Size = New System.Drawing.Size(77, 70)
        Me.cmdCadastroDeMicroarea.TabIndex = 19
        Me.ttInformacao.SetToolTip(Me.cmdCadastroDeMicroarea, "Cadastro de Micro-Áreas")
        Me.cmdCadastroDeMicroarea.UseVisualStyleBackColor = False
        '
        'cmdCadMaterial
        '
        Me.cmdCadMaterial.BackColor = System.Drawing.Color.White
        Me.cmdCadMaterial.Image = Global.SICEP.My.Resources.Resources.material
        Me.cmdCadMaterial.Location = New System.Drawing.Point(3, 79)
        Me.cmdCadMaterial.Name = "cmdCadMaterial"
        Me.cmdCadMaterial.Size = New System.Drawing.Size(77, 70)
        Me.cmdCadMaterial.TabIndex = 26
        Me.ttInformacao.SetToolTip(Me.cmdCadMaterial, "Cadastro de Material de Consumo")
        Me.cmdCadMaterial.UseVisualStyleBackColor = False
        '
        'cmdRelSecretaria
        '
        Me.cmdRelSecretaria.BackColor = System.Drawing.Color.White
        Me.cmdRelSecretaria.Image = Global.SICEP.My.Resources.Resources.relSecretaria
        Me.cmdRelSecretaria.Location = New System.Drawing.Point(86, 79)
        Me.cmdRelSecretaria.Name = "cmdRelSecretaria"
        Me.cmdRelSecretaria.Size = New System.Drawing.Size(77, 70)
        Me.cmdRelSecretaria.TabIndex = 20
        Me.ttInformacao.SetToolTip(Me.cmdRelSecretaria, "Relatórios da Secretaria")
        Me.cmdRelSecretaria.UseVisualStyleBackColor = False
        '
        'cmdEntSecretaria
        '
        Me.cmdEntSecretaria.BackColor = System.Drawing.Color.White
        Me.cmdEntSecretaria.Image = Global.SICEP.My.Resources.Resources.saiSecretaria
        Me.cmdEntSecretaria.Location = New System.Drawing.Point(169, 79)
        Me.cmdEntSecretaria.Name = "cmdEntSecretaria"
        Me.cmdEntSecretaria.Size = New System.Drawing.Size(77, 70)
        Me.cmdEntSecretaria.TabIndex = 21
        Me.ttInformacao.SetToolTip(Me.cmdEntSecretaria, "Entradas na Secretaria")
        Me.cmdEntSecretaria.UseVisualStyleBackColor = False
        '
        'cmdSaiSecretaria
        '
        Me.cmdSaiSecretaria.BackColor = System.Drawing.Color.White
        Me.cmdSaiSecretaria.Image = Global.SICEP.My.Resources.Resources.entSecretaria
        Me.cmdSaiSecretaria.Location = New System.Drawing.Point(252, 79)
        Me.cmdSaiSecretaria.Name = "cmdSaiSecretaria"
        Me.cmdSaiSecretaria.Size = New System.Drawing.Size(77, 70)
        Me.cmdSaiSecretaria.TabIndex = 22
        Me.ttInformacao.SetToolTip(Me.cmdSaiSecretaria, "Saídas na Secretaria")
        Me.cmdSaiSecretaria.UseVisualStyleBackColor = False
        '
        'cmdRelPoliclinica
        '
        Me.cmdRelPoliclinica.BackColor = System.Drawing.Color.White
        Me.cmdRelPoliclinica.Image = Global.SICEP.My.Resources.Resources.relPoliclinica
        Me.cmdRelPoliclinica.Location = New System.Drawing.Point(3, 155)
        Me.cmdRelPoliclinica.Name = "cmdRelPoliclinica"
        Me.cmdRelPoliclinica.Size = New System.Drawing.Size(77, 70)
        Me.cmdRelPoliclinica.TabIndex = 24
        Me.ttInformacao.SetToolTip(Me.cmdRelPoliclinica, "Relatórios na Policlínica")
        Me.cmdRelPoliclinica.UseVisualStyleBackColor = False
        '
        'cmdEntPoliclinica
        '
        Me.cmdEntPoliclinica.BackColor = System.Drawing.Color.White
        Me.cmdEntPoliclinica.Image = Global.SICEP.My.Resources.Resources.saiPoliclinica
        Me.cmdEntPoliclinica.Location = New System.Drawing.Point(86, 155)
        Me.cmdEntPoliclinica.Name = "cmdEntPoliclinica"
        Me.cmdEntPoliclinica.Size = New System.Drawing.Size(77, 70)
        Me.cmdEntPoliclinica.TabIndex = 25
        Me.ttInformacao.SetToolTip(Me.cmdEntPoliclinica, "Entradas na Policlínica")
        Me.cmdEntPoliclinica.UseVisualStyleBackColor = False
        '
        'cmdSaiPoliclinica
        '
        Me.cmdSaiPoliclinica.BackColor = System.Drawing.Color.White
        Me.cmdSaiPoliclinica.Image = Global.SICEP.My.Resources.Resources.entPoliclinica
        Me.cmdSaiPoliclinica.Location = New System.Drawing.Point(169, 155)
        Me.cmdSaiPoliclinica.Name = "cmdSaiPoliclinica"
        Me.cmdSaiPoliclinica.Size = New System.Drawing.Size(77, 70)
        Me.cmdSaiPoliclinica.TabIndex = 25
        Me.ttInformacao.SetToolTip(Me.cmdSaiPoliclinica, "Saídas na Policlinica")
        Me.cmdSaiPoliclinica.UseVisualStyleBackColor = False
        '
        'cmdAjuda
        '
        Me.cmdAjuda.BackColor = System.Drawing.Color.White
        Me.cmdAjuda.Image = Global.SICEP.My.Resources.Resources.ajuda
        Me.cmdAjuda.Location = New System.Drawing.Point(252, 155)
        Me.cmdAjuda.Name = "cmdAjuda"
        Me.cmdAjuda.Size = New System.Drawing.Size(77, 70)
        Me.cmdAjuda.TabIndex = 27
        Me.ttInformacao.SetToolTip(Me.cmdAjuda, "Ajuda do SICEP 1.0")
        Me.cmdAjuda.UseVisualStyleBackColor = False
        '
        'frmPrincipal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(803, 474)
        Me.Controls.Add(Me.flpFlowPainel)
        Me.Controls.Add(Me.lblPerfil)
        Me.Controls.Add(Me.lblBemVindo)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.mnuPrincipal)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.mnuPrincipal
        Me.Name = "frmPrincipal"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "SICEP 1.0 - Sistema de Controle de Estoque de Medicamentos e Pacientes da Prefeit" & _
            "ura de Medeiros"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.mnuPrincipal.ResumeLayout(False)
        Me.mnuPrincipal.PerformLayout()
        Me.flpFlowPainel.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents mnuPrincipal As System.Windows.Forms.MenuStrip
    Friend WithEvents mnuArquivo As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuFerramentas As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuCalculadora As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuBlocoDeNotas As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuCalendario As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuBackup As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuSair As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuCadastros As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuCadastroDePaciente As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuCadastroDeMedicamentos As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuCadastroDeUsuario As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuCadastroDeMicroarea As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuEstoqueDaSecretaria As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuOperarEntradasDaSecretaria As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuOperarSaídasDaSecretaria As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuEstoqueDaPoliclinica As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuOperarEntradasDaPoliclinica As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuOperarSaidasDaPoliclinica As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuRelatorios As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuRelEstoqueDaSecretaria As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuRelEstoqueDaPoliclinica As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuAjuda As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuRelRelatoriosDeCadastros As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuRelEntradasNaSecretaria As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuRelSaidasNaSecretaria As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuRelQuantidadeNaSecretaria As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuRelEntradasNaPoliclinica As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuRelSaidasNaPoliclinica As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuRelQuantidadeNaPoliclinica As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuRelRelacaoDePacientes As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuRelRelacaoDeMedicamentos As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuRelRelacaoDeUsuarios As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuRelRelacaoDeMicroareas As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuAjudaDoSICEP10 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuSobre As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lblBemVindo As System.Windows.Forms.Label
    Friend WithEvents lblPerfil As System.Windows.Forms.Label
    Friend WithEvents mnuLogout As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents cmdEntSecretaria As System.Windows.Forms.Button
    Friend WithEvents cmdRelPoliclinica As System.Windows.Forms.Button
    Friend WithEvents cmdCadastroDePaciente As System.Windows.Forms.Button
    Friend WithEvents cmdCadastroDeMedicamento As System.Windows.Forms.Button
    Friend WithEvents cmdCadastroDeUsuario As System.Windows.Forms.Button
    Friend WithEvents cmdCadastroDeMicroarea As System.Windows.Forms.Button
    Friend WithEvents cmdRelSecretaria As System.Windows.Forms.Button
    Friend WithEvents cmdSaiSecretaria As System.Windows.Forms.Button
    Friend WithEvents cmdSaiPoliclinica As System.Windows.Forms.Button
    Friend WithEvents cmdEntPoliclinica As System.Windows.Forms.Button
    Friend WithEvents flpFlowPainel As System.Windows.Forms.FlowLayoutPanel
    Friend WithEvents ttInformacao As System.Windows.Forms.ToolTip
    Friend WithEvents mnuCadMaterial As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents cmdCadMaterial As System.Windows.Forms.Button
    Friend WithEvents mnuRelMateriaisDeConsumo As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents cmdAjuda As System.Windows.Forms.Button

End Class
