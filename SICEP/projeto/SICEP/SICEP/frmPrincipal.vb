Imports CamadaDeNegocios

Public Class frmPrincipal

    Private Sub frmPrincipal_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        DefineTela()
        DefineUsuarioLogado()
        DefinePermissoes()
    End Sub
    Private Sub DefineTela()
        Dim largura As Integer = Screen.PrimaryScreen.WorkingArea.Width
        Dim Posicao As New Point
        If largura = 1024 Then
            Me.BackgroundImage = Image.FromFile("C:\Arquivos de programas\SICEP\bg\bg_1024.jpg")
            Posicao.X = 15
            Posicao.Y = 151
            flpFlowPainel.Location = Posicao
        Else
            Me.BackgroundImage = Image.FromFile("C:\Arquivos de programas\SICEP\bg\bg_800.jpg")
            Posicao.X = 15
            Posicao.Y = 122
            flpFlowPainel.Location = Posicao
        End If
    End Sub
    Private Sub DefineUsuarioLogado()
        lblBemVindo.Text = "Seja Bem Vindo(a) " & UsuarioLogado.Nome & "!"
        lblPerfil.Text = UsuarioLogado.GetNomePerfil()
    End Sub
    Private Sub DefinePermissoes()
        Select Case UsuarioLogado.Perfil
            Case 2
                UsuarioSecretaria()
            Case 3
                UsuarioPoliclinica()
            Case 4
                UsuarioVisitante()
        End Select
    End Sub
#Region "Menu Principal"
    Private Sub mnuCalculadora_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuCalculadora.Click
        Shell("C:\Arquivos de programas\SICEP\Ferramentas\calc.exe", AppWinStyle.NormalFocus)
    End Sub

    Private Sub mnuBlocoDeNotas_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuBlocoDeNotas.Click
        Shell("C:\Arquivos de programas\SICEP\Ferramentas\notepad.exe", AppWinStyle.NormalFocus)
    End Sub

    Private Sub mnuCalendario_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuCalendario.Click
        frmCalendario.Show()
    End Sub

    Private Sub mnuSair_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuSair.Click
        Application.Exit()
    End Sub

    Private Sub frmPrincipal_FormClosed(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles MyBase.FormClosed
        Application.Exit()
    End Sub
    Private Sub mnuLogout_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuLogout.Click
        Me.Dispose()
        frmSplash.Show()
    End Sub

    Private Sub cmdCadastroDePaciente_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdCadastroDePaciente.Click
        frmCadPaciente.ShowDialog()
    End Sub

    Private Sub mnuCadastroDePaciente_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuCadastroDePaciente.Click
        frmCadPaciente.ShowDialog()
    End Sub

    Private Sub cmdCadastroDeUsuario_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdCadastroDeUsuario.Click
        frmCadUsuario.ShowDialog()
    End Sub

    Private Sub mnuCadastroDeUsuario_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuCadastroDeUsuario.Click
        frmCadUsuario.ShowDialog()
    End Sub

    Private Sub cmdCadastroDeMicroarea_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdCadastroDeMicroarea.Click
        frmCadMicroarea.ShowDialog()
    End Sub

    Private Sub mnuCadastroDeMicroarea_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuCadastroDeMicroarea.Click
        frmCadMicroarea.ShowDialog()
    End Sub

    Private Sub cmdCadastroDeMedicamento_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdCadastroDeMedicamento.Click
        frmCadMedicamento.ShowDialog()
    End Sub

    Private Sub mnuCadastroDeMedicamentos_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuCadastroDeMedicamentos.Click
        frmCadMedicamento.ShowDialog()
    End Sub
    Private Sub mnuRelRelacaoDePacientes_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuRelRelacaoDePacientes.Click
        Dim rel As New Relatorio
        frmRelatorios.crvVisualizador.ReportSource = rel.CriarRelPaciente()
        frmRelatorios.Show()
    End Sub
    Private Sub mnuRelRelacaoDeMedicamentos_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuRelRelacaoDeMedicamentos.Click
        Dim rel As New Relatorio
        frmRelatorios.crvVisualizador.ReportSource = rel.CriarRelMedicamento()
        frmRelatorios.Show()
    End Sub
    Private Sub mnuRelMateriaisDeConsumo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuRelMateriaisDeConsumo.Click
        Dim rel As New Relatorio
        frmRelatorios.crvVisualizador.ReportSource = rel.CriarRelMaterial()
        frmRelatorios.Show()
    End Sub
    Private Sub mnuRelRelacaoDeUsuarios_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuRelRelacaoDeUsuarios.Click
        Dim rel As New Relatorio
        frmRelatorios.crvVisualizador.ReportSource = rel.CriarRelUsuario()
        frmRelatorios.Show()
    End Sub
    Private Sub mnuRelRelacaoDeMicroareas_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuRelRelacaoDeMicroareas.Click
        Dim rel As New Relatorio
        frmRelatorios.crvVisualizador.ReportSource = rel.CriarRelMicroArea()
        frmRelatorios.Show()
    End Sub
    Private Sub mnuOperarEntradasDaSecretaria_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuOperarEntradasDaSecretaria.Click
        frmEntSecretaria.ShowDialog()
    End Sub
    Private Sub cmdEntSecretaria_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdEntSecretaria.Click
        frmEntSecretaria.ShowDialog()
    End Sub
    Private Sub cmdSaiSecretaria_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSaiSecretaria.Click
        frmSaiSecretaria.ShowDialog()
    End Sub

    Private Sub mnuOperarSaídasDaSecretaria_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuOperarSaídasDaSecretaria.Click
        frmSaiSecretaria.ShowDialog()
    End Sub

    Private Sub cmdEntPoliclinica_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdEntPoliclinica.Click
        frmEntPoliclinica.ShowDialog()
    End Sub

    Private Sub mnuOperarEntradasDaPoliclinica_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuOperarEntradasDaPoliclinica.Click
        frmEntPoliclinica.ShowDialog()
    End Sub
    Private Sub cmdSaiPoliclinica_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSaiPoliclinica.Click
        frmSaiPoliclinica.ShowDialog()
    End Sub

    Private Sub mnuOperarSaidasDaPoliclinica_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuOperarSaidasDaPoliclinica.Click
        frmSaiPoliclinica.ShowDialog()
    End Sub
    Private Sub mnuRelEntradasNaSecretaria_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuRelEntradasNaSecretaria.Click
        Dim rel As New Relatorio
        frmRelatorios.crvVisualizador.ReportSource = rel.CriarRelEntradasSecretaria()
        frmRelatorios.Show()
    End Sub

    Private Sub mnuRelSaidasNaSecretaria_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuRelSaidasNaSecretaria.Click
        Dim rel As New Relatorio
        frmRelatorios.crvVisualizador.ReportSource = rel.CriarRelSaidasSecretaria()
        frmRelatorios.Show()
    End Sub

    Private Sub mnuRelQuantidadeNaSecretaria_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuRelQuantidadeNaSecretaria.Click
        Dim rel As New Relatorio
        frmRelatorios.crvVisualizador.ReportSource = rel.CriarRelEstoqueSecretaria()
        frmRelatorios.Show()
    End Sub

    Private Sub mnuRelEntradasNaPoliclinica_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuRelEntradasNaPoliclinica.Click
        Dim rel As New Relatorio
        frmRelatorios.crvVisualizador.ReportSource = rel.CriarRelEntradasPoliclinica()
        frmRelatorios.Show()
    End Sub

    Private Sub mnuRelSaidasNaPoliclinica_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuRelSaidasNaPoliclinica.Click
        Dim rel As New Relatorio
        frmRelatorios.crvVisualizador.ReportSource = rel.CriarRelSaidasPoliclinica()
        frmRelatorios.Show()
    End Sub

    Private Sub mnuRelQuantidadeNaPoliclinica_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuRelQuantidadeNaPoliclinica.Click
        Dim rel As New Relatorio
        frmRelatorios.crvVisualizador.ReportSource = rel.CriarRelEstoquePoliclinica()
        frmRelatorios.Show()
    End Sub

    Private Sub cmdRelSecretaria_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdRelSecretaria.Click
        mnuRelatorios.ShowDropDown()
        mnuRelEstoqueDaSecretaria.ShowDropDown()
        mnuRelEstoqueDaSecretaria.Select()
    End Sub

    Private Sub cmdRelPoliclinica_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdRelPoliclinica.Click
        mnuRelatorios.ShowDropDown()
        mnuRelEstoqueDaPoliclinica.ShowDropDown()
        mnuRelEstoqueDaPoliclinica.Select()
    End Sub

    Private Sub mnuBackup_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuBackup.Click
        frmBackup.ShowDialog()
    End Sub

    Private Sub mnuAjudaDoSICEP10_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuAjudaDoSICEP10.Click
        frmAjuda.Show()
    End Sub

    Private Sub mnuSobre_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuSobre.Click
        frmSobre.ShowDialog()
    End Sub

    Private Sub mnuCadMaterial_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuCadMaterial.Click
        frmCadMaterial.ShowDialog()
    End Sub

    Private Sub cmdCadMaterial_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdCadMaterial.Click
        frmCadMaterial.ShowDialog()
    End Sub
    Private Sub cmdAjuda_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAjuda.Click
        frmAjuda.Show()
    End Sub
#End Region
#Region "Permissoes"
    Private Sub UsuarioPoliclinica()
        mnuBackup.Visible = False
        mnuCadastroDeMedicamentos.Visible = False
        mnuCadastroDeMicroarea.Visible = False
        mnuCadastroDeUsuario.Visible = False
        mnuEstoqueDaSecretaria.Visible = False
        mnuRelEstoqueDaSecretaria.Visible = False
        mnuRelRelatoriosDeCadastros.Visible = False
        cmdCadastroDeMedicamento.Visible = False
        cmdCadastroDeMicroarea.Visible = False
        cmdCadastroDeUsuario.Visible = False
        cmdRelSecretaria.Visible = False
        cmdEntSecretaria.Visible = False
        cmdSaiSecretaria.Visible = False
        mnuCadMaterial.Visible = False
        cmdCadMaterial.Visible = False
        mnuRelMateriaisDeConsumo.Visible = False
    End Sub
    Private Sub UsuarioSecretaria()
        mnuBackup.Visible = False
        mnuCadastroDeMedicamentos.Visible = False
        mnuCadastroDeMicroarea.Visible = False
        mnuCadastroDeUsuario.Visible = False
        mnuEstoqueDaPoliclinica.Visible = False
        mnuRelEstoqueDaPoliclinica.Visible = False
        mnuRelRelatoriosDeCadastros.Visible = False
        cmdCadastroDeMedicamento.Visible = False
        cmdCadastroDeMicroarea.Visible = False
        cmdCadastroDeUsuario.Visible = False
        cmdRelPoliclinica.Visible = False
        cmdEntPoliclinica.Visible = False
        cmdSaiPoliclinica.Visible = False
        mnuCadMaterial.Visible = False
        cmdCadMaterial.Visible = False
        mnuRelMateriaisDeConsumo.Visible = False
    End Sub
    Private Sub UsuarioVisitante()
        mnuAjudaDoSICEP10.Visible = False
        mnuRelatorios.Visible = False
        mnuEstoqueDaPoliclinica.Visible = False
        mnuEstoqueDaSecretaria.Visible = False
        mnuCadastros.Visible = False
        mnuBackup.Visible = False
        mnuFerramentas.Visible = False
        flpFlowPainel.Visible = False
    End Sub
#End Region

End Class
