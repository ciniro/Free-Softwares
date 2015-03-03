Imports CamadaDeNegocios

Public Class frmCadPaciente
    
#Region "Funções Privadas"
    Private Sub PreencheGridPesquisa(ByVal nome As String)
        Dim pac As New Paciente
        grdPacientes.DataSource = pac.SelecionaPorNome(nome)
    End Sub
    Private Sub PreencheDropMicroarea()
        Dim micro As New Microarea()
        Dim dts As New dtsBD_SICEP.tb_microareaDataTable()
        dts = micro.Seleciona()
        dpdMicroarea.DataSource = dts
        dpdMicroarea.DisplayMember = "cod_microarea"
        dpdMicroarea.ValueMember = "cod_microarea"
    End Sub
    Private Sub PreencheFormulario(ByVal codigo As Integer)
        Dim pac As New Paciente
        pac.Seleciona(codigo)
        lblCodigo.Text = pac.Codigo.ToString()
        lblDataCadastramento.Text = pac.DataCadastro
        txtNome.Text = pac.Nome
        txtEndereco.Text = pac.Endereco
        txtDataNasc.Text = pac.DataNascimento
        txtMae.Text = pac.NomeDaMae
        txtTelefone.Text = pac.Telefone
        txtCPF.Text = pac.CPF
        txtRG.Text = pac.RG
        If pac.Sexo = "m" Then
            rbtMasculino.Checked = True
            rbtFeminino.Checked = False
        Else
            rbtMasculino.Checked = False
            rbtFeminino.Checked = True
        End If
        dpdMicroarea.SelectedValue = pac.CodigoMicroarea
    End Sub
    Private Sub LimpaTudo()
        lblCodigo.Text = String.Empty
        lblDataCadastramento.Text = String.Empty
        txtNome.Text = String.Empty
        txtEndereco.Text = String.Empty
        txtDataNasc.Text = Date.Today.Date
        txtMae.Text = String.Empty
        txtTelefone.Text = String.Empty
        txtCPF.Text = String.Empty
        txtRG.Text = String.Empty
        rbtMasculino.Checked = True
        rbtFeminino.Checked = False
        lblValEndereco.Visible = False
        lblValNome.Visible = False
        lblValTelefone.Visible = False
        lblValCPF.Visible = False
    End Sub
    Private Sub DefineBotoes(ByVal Novo As Boolean, ByVal Salvar As Boolean, ByVal Alterar As Boolean, ByVal Excluir As Boolean, ByVal Cancelar As Boolean)
        cmdNovo.Visible = Novo
        cmdSalvar.Visible = Salvar
        cmdAlterar.Visible = Alterar
        cmdExcluir.Visible = Excluir
        cmdCancelar.Visible = Cancelar
    End Sub
    Private Sub SetaToolTip()
        Dim mic As New Microarea
        Dim linha As DataRowView = dpdMicroarea.SelectedItem
        Dim codigo As Integer = linha.Item(0)
        mic.SelecionaPorValor(codigo)
        Dim texto As String = "CÓDIGO: " + mic.Codigo.ToString() + vbCr + "AGENTE: " + mic.Agente + vbCr + "DATA DO CADASTRO:" + mic.DataCadastramento
        ToolTip.SetToolTip(imgInformacoes, texto)
    End Sub
    Private Function ValidaDados() As Boolean
        Dim ERRO As Boolean = False
        lblValEndereco.Visible = False
        lblValNome.Visible = False
        lblValTelefone.Visible = False
        lblValCPF.Visible = False
        Dim Telefone As String = Replace(txtTelefone.Text, " ", "")
        Dim CPF As String = Replace(txtCPF.Text, " ", "")
        If Telefone.Length < 13 And Telefone.Length > 3 Then 'ERRO
            ERRO = True
            lblValTelefone.Visible = True
        End If
        If CPF.Length < 14 And CPF.Length > 3 Then 'ERRO
            ERRO = True
            lblValCPF.Visible = True
        End If
        If txtNome.Text.Trim() = "" Then
            ERRO = True
            lblValNome.Visible = True
        End If
        If txtEndereco.Text.Trim() = "" Then
            ERRO = True
            lblValEndereco.Visible = True
        End If

        Return ERRO
    End Function
    Private Sub Cancelar()
        DefineBotoes(True, False, False, False, False)
        pnlPesquisa.Enabled = True
        LimpaTudo()
        PreencheGridPesquisa("")
        dpdMicroarea.SelectedIndex = 0 'volta na posicao inicial sem desvincular do datasource
    End Sub
#End Region
    Private Sub txtPesquisa_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtPesquisa.TextChanged
        PreencheGridPesquisa(txtPesquisa.Text)
    End Sub
    Private Sub grdPacientes_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles grdPacientes.CellContentClick
        Dim codigo As Integer = grdPacientes.SelectedCells(e.ColumnIndex - 1).Value
        PreencheFormulario(codigo)
        DefineBotoes(False, False, True, True, True)
    End Sub
    Private Sub frmCadPaciente_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        LimpaTudo()
        dpdMicroarea.DataSource = New DataTable 'limpa o dpd para reinicializacao
        PreencheGridPesquisa("")
        PreencheDropMicroarea()
        DefineBotoes(True, False, False, False, False)
        pnlPesquisa.Enabled = True 'Para reativar na reinicializacao
    End Sub
    Private Sub cmdNovo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdNovo.Click
        DefineBotoes(False, True, False, False, True)
        pnlPesquisa.Enabled = False
    End Sub
    Private Sub cmdSalvar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSalvar.Click
        If Not ValidaDados() Then
            'SALVANDO
            Dim Tel As String = txtTelefone.Text
            Dim CPF As String = txtCPF.Text
            If Tel = "(  )    -" Then
                Tel = ""
            End If
            If CPF = "   .   .   -" Then
                CPF = ""
            End If
            Dim pac As New Paciente()
            pac.Nome = txtNome.Text
            pac.Endereco = txtEndereco.Text
            pac.DataNascimento = txtDataNasc.Text
            pac.Telefone = Tel
            pac.NomeDaMae = txtMae.Text
            pac.CPF = CPF
            pac.RG = txtRG.Text
            If rbtMasculino.Checked Then
                pac.Sexo = "m"
            Else
                pac.Sexo = "f"
            End If
            Dim linha As DataRowView = dpdMicroarea.SelectedItem
            pac.CodigoMicroarea = linha.Item(0)
            If pac.Salvar() Then
                MsgBox("Paciente salvo com sucesso!")
            End If
            Cancelar()
        Else
            MsgBox("Por favor preencha os campos marcados corretamente!")
        End If
    End Sub
    Private Sub cmdAlterar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAlterar.Click
        If Not ValidaDados() Then
            If MsgBox("Tente certeza que fazer esta alteração?", MsgBoxStyle.OkCancel, "Confirmação") = MsgBoxResult.Ok Then
                Dim Tel As String = txtTelefone.Text
                Dim CPF As String = txtCPF.Text
                If Tel = "(  )    -" Then
                    Tel = ""
                End If
                If CPF = "   .   .   -" Then
                    CPF = ""
                End If
                Dim pac As New Paciente
                pac.Seleciona(Int32.Parse(lblCodigo.Text))
                pac.Nome = txtNome.Text
                pac.Endereco = txtEndereco.Text
                pac.DataNascimento = txtDataNasc.Text
                pac.Telefone = Tel
                pac.NomeDaMae = txtMae.Text
                pac.CPF = CPF
                pac.RG = txtRG.Text
                If rbtMasculino.Checked Then
                    pac.Sexo = "m"
                Else
                    pac.Sexo = "f"
                End If
                Dim linha As DataRowView = dpdMicroarea.SelectedItem
                pac.CodigoMicroarea = linha.Item(0)
                If pac.Alterar() Then
                    MsgBox("Paciente alterado com sucesso!")
                End If
                Cancelar()
            End If
        Else
            MsgBox("Por favor preencha os campos marcados corretamente!")
        End If
    End Sub
    Private Sub cmdExcluir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdExcluir.Click
        If (lblCodigo.Text.Trim <> "") Then
            If MsgBox("Tente certeza que fazer esta exclusão?", MsgBoxStyle.OkCancel, "Confirmação") = MsgBoxResult.Ok Then
                Dim pac As New Paciente
                pac.Seleciona(Int32.Parse(lblCodigo.Text))
                Dim msg As String = pac.Excluir()
                MsgBox(msg)
                Cancelar()
            End If
        End If
    End Sub
    Private Sub cmdCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdCancelar.Click
        Cancelar()
    End Sub
    Private Sub dpdMicroarea_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dpdMicroarea.SelectedIndexChanged
        SetaToolTip()
    End Sub
    Private Sub lkImprimir_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles lkImprimir.LinkClicked
        Dim rel As New Relatorio
        frmRelatorios.crvVisualizador.ReportSource = rel.CriarRelPaciente()
        frmRelatorios.Show()
    End Sub

    Private Sub dpdMicroarea_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles dpdMicroarea.KeyPress
        e.Handled = True
    End Sub
End Class